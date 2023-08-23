using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Almacen alma = new Almacen(5, 5);
            List<Bebida> bebidas = new List<Bebida>();
            string[] marcas = { "Villavicencio", "Coca-Cola", "Paso de los Toros", "Pepsi", "SmartWater"};
            bool[] bools = {true, false};
            bool azucar;
            string[] dondes = {"Manantial", "Glaciar", "Otro Lugar"};
            string donde = null;
            string marca;
            double precio;
            double litros;
            bool promo;
            int id = 0;

            for (int i = 0; i < alma.col; i++)
            {
                precio = rnd.Next(25, 101);
                azucar = bools[rnd.Next(0, 2)];
                promo = bools[rnd.Next(0, 2)];
                if (!azucar)
                    donde = dondes[rnd.Next(0, dondes.Length)];
                else if (azucar && promo)
                    precio *= 0.9;
                marca = marcas[rnd.Next(0, marcas.Length)];
                litros = rnd.Next(0, 4) + rnd.NextDouble();
                for (int j = 0; j < alma.fil; j++)
                {
                    bebidas.Add(new Bebida(id, marca, azucar, precio, litros, donde));
                    id++;
                }
            }
            Console.WriteLine(alma.precioTot(bebidas));
            Console.Write("Marcas disponibles: |");
            for (int i = 0; i < marcas.Count(); i++)
                Console.Write(marcas[i] + "|");
            Console.WriteLine("");
            Console.WriteLine(alma.precioMarca(bebidas));
            Console.WriteLine(alma.precioColumna(bebidas));
            Console.ReadKey();
        }
    }
}
