using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios17
{
	public enum PalosEsp { Espadas, Bastos, Copas, Oros }
	public enum PalosFra { Picas, Treboles, Diamantes, Corazones }
	abstract class Baraja
	{
		public int cantCartas;
		public int cantCartasPalo;
	}

	class Carta : Baraja
	{
		public int num;
		public string fig = null;
		public string palo;
		PalosEsp paloEsp;
		PalosFra paloFra;
	}

	class BarajaEsp : Carta
	{
		public BarajaEsp(int i, string palo) : base()
		{
			this.num = i;
			this.palo = palo;
			switch (num)
			{
				case 1:
					this.fig = "Ancho";
					break;
				case 10:
					this.fig = "Sota";
					break;
				case 11:
					this.fig = "Caballo";
					break;
				case 12:
					this.fig = "Rey";
					break;
				default:
					this.fig = Convert.ToString(num);
					break;
			}

		}
	}
	class BarajaFra : Carta
	{
		public bool Roja(BarajaFra c)
		{
			if (c.palo == "Diamantes" || c.palo == "Corazones")
				return true;
			else
				return false;
		}
		public bool Negra(BarajaFra c)
		{
			if (c.palo == "Treboles" || c.palo == "Picas")
				return true;
			else
				return false;
		}
		public BarajaFra(int i, string palo) : base()
		{
			this.cantCartas = 52;
			this.num = i;
			this.palo = palo;
			switch (num)
			{
				case 1:
					this.fig = "As";
					break;
				case 10:
					this.fig = "Jota";
					break;
				case 11:
					this.fig = "Reina";
					break;
				case 12:
					this.fig = "Rey";
					break;
				default:
					this.fig = Convert.ToString(num);
					break;
			}

		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Elija un tipo de carta:\n1. Francesa\n2. Española");
			int op = Convert.ToInt32(Console.ReadLine());
			List<BarajaFra> barajaF = new List<BarajaFra>();
			List<BarajaEsp> barajaE = new List<BarajaEsp>();
			switch (op)
			{
				case 1:
					foreach (string palo in Enum.GetNames(typeof(PalosFra)))
						for (int i = 1; i <= 13; i++)
							barajaF.Add(new BarajaFra(i, palo));
					break;
				case 2:
					Console.WriteLine("Quiere incluir 8's y 9's?\n1. Si\n2. No");
					bool o = (Convert.ToInt32(Console.ReadLine()) == 1);
					foreach (string palo in Enum.GetNames(typeof(PalosEsp)))
						for (int i = 1; i <= 12; i++)
						{
							if (!o && i == 8)
								i += 2;
							barajaE.Add(new BarajaEsp(i, palo));
						}
					break;
			}
			if (!(barajaF.Count() <= 0))
				foreach (BarajaFra carta in barajaF)
					Console.WriteLine(carta.fig + "\t" + carta.palo);
			if (!(barajaE.Count() <= 0))
				foreach (BarajaEsp carta in barajaE)
					Console.WriteLine(carta.fig + "\t" + carta.palo);
			Console.ReadLine();
		}
	}
}