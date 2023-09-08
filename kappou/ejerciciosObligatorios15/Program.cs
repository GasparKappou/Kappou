using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ejerciciosObligatorios15
{
	class Bebida
	{
		public int id;
		public string marca;
		public bool azucar;
		public double precio;
		public double litros;
		public string donde;

		public Bebida(int id, string marca, bool azucar, double precio, double litros, string donde)
		{
			this.id = id;
			this.marca = marca;
			this.azucar = azucar;
			this.precio = precio;
			this.litros = litros;
			this.donde = donde;
		}
	}
	class Almacen
	{
		public int col;
		public int fil;

		public Almacen(int col, int fil)
		{
			this.col = col;
			this.fil = fil;
		}

		public double precioTot(List<Bebida> bebidas)
		{
			double tot = 0;
			tot += bebidas.Sum(b => b.precio);
			return tot;
		}
		public double precioMarca(List<Bebida> bebidas)
		{
			string marcaQ = Console.ReadLine();
			double tot = 0;
			for (int i = 0; i < bebidas.Count(); i++)
				if (bebidas[i].marca == marcaQ)
					tot += bebidas[i].precio;
			return tot;
		}
		public double precioColumna(List<Bebida> bebidas)
		{
			string marcaQ = Console.ReadLine();
			double tot = 0;
			for (int i = 0; i < bebidas.Count(); i++)
				if (bebidas[i].marca == marcaQ)
					tot += bebidas[i].precio;
			return tot;
		}

	}
	internal class Program
	{
		static public void AgregarBebida(Random rnd, Almacen alma, List<Bebida> bebidas, int id, string[] marcas)
		{
			bool[] bools = { true, false };
			string[] dondes = { "Manantial", "Glaciar", "Otro Lugar" };
			bool azucar;
			string donde = null;
			string marca;
			double precio;
			double litros;
			bool promo;

			precio = rnd.Next(25, 101);
			azucar = bools[rnd.Next(0, 2)];
			promo = bools[rnd.Next(0, 2)];
			if (!azucar)
				donde = dondes[rnd.Next(0, dondes.Length)];
			else if (azucar && promo)
				precio *= 0.9;
			marca = marcas[rnd.Next(0, marcas.Length)];
			litros = rnd.Next(0, 4) + rnd.NextDouble();
			for (int j = 0; id < alma.fil; id++)
			{
				bebidas.Add(new Bebida(id, marca, azucar, precio, litros, donde));
				id++;
			}
		}
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Almacen alma = new Almacen(5, 5);
			List<Bebida> bebidas = new List<Bebida>();
			int id = 0;
			string[] marcas = { "Villavicencio", "Coca-Cola", "Paso de los Toros", "Pepsi", "SmartWater" };

			for (int i = 0; i < alma.col; i++)
			{
				AgregarBebida(rnd, alma, bebidas, id, marcas);
			}
			while (true)
			{
				Console.Clear();
				Console.WriteLine("1. Ver precio de todas las bebidas\n2. Ver precio de todas las bebidas por marca\n" +
								"3. Ver precio de todas las bebidas por estanteria\n4. Agregar producto\n" +
								"5. Eliminar producto\n6. Mostrar productos");
				int op = Convert.ToInt32(Console.ReadLine());
				switch (op)
				{
					case 1:
						Console.WriteLine(alma.precioTot(bebidas));
						break;
					case 2:
						Console.Write("Marcas disponibles: |");
						for (int i = 0; i < marcas.Count(); i++)
							Console.Write(marcas[i] + "|");
						Console.WriteLine(alma.precioMarca(bebidas));
						break;
					case 3:
						Console.WriteLine(alma.precioColumna(bebidas));
						break;
					case 4:
						AgregarBebida(rnd, alma, bebidas, id, marcas);
						break;
					case 5:
						Console.WriteLine("Ingrese el id de la bebida a eliminar");
						int idElim = Convert.ToInt32(Console.ReadLine());
						if (bebidas.Exists(b => b.id == idElim))
						{
							bebidas.Find(b => b.id == idElim).id = 0;
							bebidas.Find(b => b.id == idElim).marca = null;
							bebidas.Find(b => b.id == idElim).azucar = false;
							bebidas.Find(b => b.id == idElim).precio = 0;
							bebidas.Find(b => b.id == idElim).litros = 0;
							bebidas.Find(b => b.id == idElim).donde = null;
						}
						else
							Console.WriteLine("Id inexistente");
						break;
					case 6:
						Console.WriteLine("Ingrese el id de la bebida para ver su informacion");
						int idBuscar = Convert.ToInt32(Console.ReadLine());
						if (bebidas.Exists(b => b.id == idBuscar))
						{
							Console.WriteLine("Id: " + bebidas.Find(b => b.id == idBuscar).id);
							Console.WriteLine("Marca: " + bebidas.Find(b => b.id == idBuscar).marca);
							Console.WriteLine("Azucar: " + bebidas.Find(b => b.id == idBuscar).azucar);
							Console.WriteLine("Precio: " + bebidas.Find(b => b.id == idBuscar).precio);
							Console.WriteLine("Litros: " + bebidas.Find(b => b.id == idBuscar).litros);
							Console.WriteLine("Proviene de: " + bebidas.Find(b => b.id == idBuscar).donde);
						}
						else
							Console.WriteLine("Id inexistente");
						break;
					default:
						break;
				}
				Console.ReadKey();
			}
		}
	}
}
