using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios10
{
    class Carta
    {
        public int num;
        public int palo;

        public Carta(int num, int palo)
        {
            this.num = num;
            this.palo = palo;
        }
    }

    class Baraja
    {
        public static List<Carta> CrearBaraja(List<Carta> baraja)
        {
            for (int i = 0; i< 4; i++)
                for (int j = 1; j< 13; j++)
                    if (j == 8 || j == 9)
                        Console.Write(' ');
                    else
                        baraja.Add(new Carta(j, i));
            return baraja;
        }
        public static List<Carta> Barajar(List<Carta> baraja)
        {
            Random rnd = new Random();
            List<Carta> nuevaBaraja = new List<Carta>();

            for (int i = baraja.Count; i > 0; i--)
            {
                int numAleatorio = rnd.Next(0, baraja.Count);
                nuevaBaraja.Add(baraja[numAleatorio]);
                baraja.Remove(baraja[numAleatorio]);
            }
            return nuevaBaraja;
        }

        public static List<Carta> Repartir(List<Carta> baraja, int repartir)
        {
            if (repartir < baraja.Count)
                for (int i = repartir; i > 0; i--)
                    baraja.RemoveAt(0);
            else
                Console.WriteLine("No hay suficientes cartas");

            return baraja;
        }

        public static int CartasDisponibles(List<Carta> baraja)
        {
            return baraja.Count;
        }

        public static string SigCarta(List<Carta> baraja)
        {
            return "Num: " + baraja[0].num + " | palo: " + baraja[0].palo ;
        }

        public static int MostrarBaraja(List<Carta> baraja)
        {
            int n = 0;
            Console.SetCursorPosition(0, 0);
            foreach (Carta carta in baraja)
            {
                Console.Write("            | palo: " + carta.palo);
                Console.SetCursorPosition(0, n++);
                Console.WriteLine("numCart: " + carta.num);
            }
            return baraja.Count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            void Clear()
            {
                Console.Clear();
            }
            
            List<Carta> baraja = new List<Carta>();
            Baraja.CrearBaraja(baraja);
            
            while (true)
            {
                Clear();
                Console.WriteLine("Que quiere hacer?");
                Console.WriteLine("1. Mostrar baraja");
                Console.WriteLine("2. Barajar baraja");
                Console.WriteLine("3. Repartir cartas");
                Console.WriteLine("4. ¿Cuantas cartas quedan?");
                Console.WriteLine("5. ¿Cual es la siguiente carta?");
                Console.WriteLine("6. Reiniciar baraja");

                int op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Clear();
                        Baraja.MostrarBaraja(baraja);
                        Console.ReadKey();
                        break;
                    case 2:
                        baraja = Baraja.Barajar(baraja);
                        break;
                    case 3:
                        Console.WriteLine("Cuantas quiere repartir?");
                        int rep = Convert.ToInt16(Console.ReadLine());
                        Baraja.Repartir(baraja, rep);
                        break;
                    case 4:
                        Clear();
                        Console.WriteLine("Hay " + Baraja.CartasDisponibles(baraja) + " cartas disponibles");
                        Console.ReadKey();
                        break;
                    case 5:
                        Clear();
                        Console.WriteLine(Baraja.SigCarta(baraja));
                        Console.ReadKey();
                        break;
                    case 6:
                        Baraja.CrearBaraja(baraja);
                        break;
                }
            }
        }
    }
}
