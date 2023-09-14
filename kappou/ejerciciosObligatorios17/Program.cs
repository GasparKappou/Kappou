using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios17
{
	/*public enum PalosEsp { Espadas, Bastos, Copas, Oros }
	public enum PalosFra { Picas, Treboles, Diamantes, Corazones }

	abstract class Baraja
	{
		public int cantCartas;
		public int cantCartasPalo;



	}

	class Carta : Baraja
	{
		public int num;
	}

	class BarajaEsp : Carta
	{
		private bool ochoNueve;
		PalosEsp palosEsp = new PalosEsp();
		public BarajaEsp(bool ochoNueve, int num) : base()
		{
			if (!this.ochoNueve)
			{
				this.cantCartas = 40;
				this.cantCartasPalo = 10;
			}
			else
			{
				this.cantCartas = 48;
				this.cantCartasPalo = 12;
			}
			this.palosEsp = new PalosEsp();
			this.num = num;
		}
	}

	class BarajaFra : Carta
	{
		PalosFra palosFra = new PalosFra();
		public BarajaFra(int num) : base()
		{
			this.cantCartas = 52;
			this.cantCartasPalo = 13;
			this.palosFra = new PalosFra();
			this.num = num;
		}
	}*/
	public enum PalosEsp { Espadas, Bastos, Copas, Oros }
	public enum PalosFra { Picas, Treboles, Diamantes, Corazones }

	abstract class Baraja
	{
		public int cantCartas;
		public int cantCartasPalo;


	}
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Elija un tipo de carta:\n1. Francesa\n2. Española");
			int op = Convert.ToInt32(Console.ReadLine());
			switch(op)
			{
				case 1:
					//List<Carta> baraja = new List<Carta>();
					BarajaFra baraja = new BarajaFra();
					foreach (PalosEsp palo in baraja.)
					{

					}
					break;
				case 2:
					break;
			}
			
		}
	}
}
