using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios11
{
    class Persona
    {
        public int dinero;
        public int cantWins;
        public int predA;
        public int predB;

        public Persona(int predA, int predB)
        {
            this.dinero = 100;
            this.predA = predA;
            this.predB = predB;
        }
    }
    class Pozo
    {
        public int dineroTot;
        public int resultadoA;
        public int resultadoB;
        public Pozo(int dinero, int resultadoA, int resultadoB)
        {
            this.dineroTot = dinero;
            this.resultadoA = resultadoA;
            this.resultadoB = resultadoB;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            int cantWinsToWin = 4;
            Random rnd = new Random();
            int cantPers = rnd.Next(2, 37);

            for (int i = 0; i < cantPers; i++)
            {
                personas.Add(new Persona(rnd.Next(0, 6), rnd.Next(0, 6)));
            }

            Pozo apuesta = new Pozo(cantPers, rnd.Next(0, 6), rnd.Next(0, 6));
            bool lol = true;
            while (lol)
            {
                for (int i = 0; i < personas.Count; i++)
                {
                    personas[i].dinero = personas[i].dinero - 1;
                    if (personas[i].predA == apuesta.resultadoA && personas[i].predB == apuesta.resultadoB)
                    {
                        personas[i].dinero += apuesta.dineroTot;
                        personas[i].cantWins++;
                    }
                    personas[i].predA = rnd.Next(0, 6);
                    personas[i].predB = rnd.Next(0, 6);
                }

                //personas.Remove(personas.Find(p => p.dinero < 0));
                
                if (personas.Find(p => p.cantWins == cantWinsToWin) is Persona)
                {
                    lol = false;
                }
            }
            //cantPers = personas.Count;
            int count = 1;
            for (int i = 0; i < cantPers; i++)
            {
                Console.WriteLine("La persona " + count + " tiene " + personas[i].dinero + " y gano " + personas[i].cantWins + " veces");
                count++;
            }
            int winner = personas.FindIndex(p => p.cantWins == cantWinsToWin) + 1;
            Console.WriteLine(winner + " es la persona con mayor cantindad de victorias");
            Console.ReadKey();
        }
    }
}
