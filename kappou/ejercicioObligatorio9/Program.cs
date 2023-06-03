using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioObligatorio9
{
    class Asiento
    {
        public int x, y;
        public string etiqueta;
        public bool usado;
        public Asiento(int x, int y, string etiqueta, bool usado)
        {
            this.x = x;
            this.y = y;
            this.etiqueta = etiqueta;
            this.usado = usado;
        }
    }
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
            while (true)
            {
                Console.Clear();
                //variables
                string[] nombres = { "Gaspar", "Luis", "Angie", "Sofia", "Tobias", "Claudia" };
                string[] nomPelis = { "Pelicula1", "Pelicula2", "Pelicula3", "Pelicula4", "Pelicula5" };
                string[] fil = { "1", "2", "3", "4", "5", "6", "7", "8" };
                string[] col = { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
                int cantAsientos = fil.Length * col.Length;
                int asientosOcupados = 0;

                Random rnd = new Random();

                List<Persona> personas = new List<Persona>();
                List<Asiento> asientos = new List<Asiento>();

                Pelicula peli = new Pelicula(nomPelis[rnd.Next(0, nomPelis.Length)], nombres[rnd.Next(0, nombres.Length)], rnd.Next(0, 3) + rnd.NextDouble(), rnd.Next(0, 18));
                Cine cine = new Cine(peli.nombre, rnd.Next(25, 75) + rnd.NextDouble());

                //hago personas
                for (int i = 0; i < rnd.Next(60, 250); i++)
                {
                    personas.Add(new Persona(nombres[rnd.Next(0, nombres.Length)], rnd.Next(7, 60), rnd.Next(0, 201) + rnd.NextDouble()));
                }

                //muestro y asigno asientos
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < fil.Length; i++)
                {
                    for (int j = 0; j < col.Length; j++)
                    {
                        asientos.Add(new Asiento(i, j, fil[i] + col[j], false));
                        Console.Write(" " + fil[i] + col[j] + " ");
                    }
                    Console.WriteLine("");
                }
                Console.ForegroundColor = ConsoleColor.Green;

                //parte logica
                foreach (Persona persona in personas)
                {
                    for (int i = 0; i < cantAsientos; i++)
                    {
                        if (persona.edad > peli.edadMin && persona.dinero > cine.costEntr && asientos[i].usado == false)
                        {
                            asientosOcupados++;
                            Console.SetCursorPosition(asientos[i].y * 4, asientos[i].x);
                            Console.WriteLine(" " + asientos[i].etiqueta + " ");
                            asientos[i].usado = true;
                            break;
                        }
                    }
                }
                Console.SetCursorPosition(0, 10);
                Console.WriteLine(asientosOcupados < cantAsientos ? "Nos quedamos con asientos libres" : "Se vendieron todas las entradas");

                Console.ReadKey();
            }
        }
    }
}
