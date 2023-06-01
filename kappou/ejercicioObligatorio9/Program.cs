using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioObligatorio9
{
    class Persona
    {
        public string nombre;
        public int edad;
        public double dinero;

        public Persona(string nom, int edad, double dinero)
        {
            this.nombre = nom;
            this.edad = edad;
            this.dinero = dinero;
        }
    }
    class Pelicula
    {
        public string nombre;
        public string director;
        public double duracionHrs;
        public int edadMin;

        public Pelicula(string nombre, string director, double duracion, int edadMin)
        {
            this.nombre = nombre;
            this.director = director;
            this.duracionHrs = duracion;
            this.edadMin = edadMin;
        }
    }
    class Cine
    {
        public string pelicula;
        public double costEntr;
        
        public Cine(string nomPel, double coste)
        {
            this.pelicula = nomPel;
            this.costEntr = coste;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int[] fil = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            string[] col = { "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I" };
            string[] nombres = { "Gaspar", "Luis", "Angie", "Sofia", "Tobias", "Claudia" };
            string[] nomPelis = { "Pelicula1", "Pelicula2", "Pelicula3", "Pelicula4", "Pelicula5"};
            List<Persona> personas = new List<Persona>();
            Random rnd = new Random();
            Pelicula peli = new Pelicula(nomPelis[rnd.Next(0, nomPelis.Length)], nombres[rnd.Next(0, nombres.Length)], rnd.Next(0, 3) + rnd.NextDouble(), rnd.Next(0, 18));
            Cine cine = new Cine(peli.nombre, rnd.Next(25, 75) + rnd.NextDouble());
            for (int i = 0; i < rnd.Next(0, 75); i++)
            {
                personas.Add(new Persona(nombres[rnd.Next(0, nombres.Length)], rnd.Next(12, 70), rnd.Next(0, 100) + rnd.NextDouble()));
            }
            
            //muestro cine
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = fil.Length-1; i > 0; i--)
            {
                for (int j = 1; j < col.Length; j++)
                {
                    Console.Write(fil[i] + col[j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            
            //parte logica
            int fila = 0;
            int columna = 0;
            foreach (Persona persona in personas)
            {
                fila = rnd.Next(0, fil.Length);
                columna = rnd.Next(0, col.Length);
                fil[fila] = 0;
                col[columna] = "Z";

                if (persona.edad > peli.edadMin && persona.dinero > cine.costEntr)
                {
                }
            }

            Console.ReadKey();

        }
    }
}
