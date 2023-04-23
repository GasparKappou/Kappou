using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibioteca
{
    class Libro
    {
        public string Titulo;
        public string Autor;
        public bool Disponible;

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            Disponible = true;
        }

        public void Prestar()
        {
            if (Disponible)
            {
                Disponible = false;
                Console.WriteLine("El libro " + Titulo + " ha sido prestado.");
            }
            else
            {
                Console.WriteLine("El libro " + Titulo + " no está disponible para préstamo.");
            }
        }

        public void Devolver()
        {
            if (!Disponible)
            {
                Disponible = true;
                Console.WriteLine("El libro " + Titulo + " ha sido devuelto.");
            }
            else
            {
                Console.WriteLine("El libro " + Titulo + " no está prestado.");
            }
        }
    }

    class Program
    {
        static List<Libro> libros = new List<Libro>();

        static void Main(string[] args)
        {
            libros.Add(new Libro("Diccionario", "RAE"));
            libros.Add(new Libro("Manual de Usuario", "Aorus"));
            libros.Add(new Libro("Destruccion y caos", "Fulano"));
            libros.Add(new Libro("El Libro Troll", "ElRubius"));

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1. Buscar libro");
                Console.WriteLine("2. Prestar libro");
                Console.WriteLine("3. Devolver libro");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        BuscarLibro();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        PrestarLibro();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        DevolverLibro();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void BuscarLibro()
        {
            Console.Write("Ingrese el título del libro a buscar: ");
            string titulo = Console.ReadLine();
            bool encontrado = false;
            foreach (var libro in libros)
            {
                if (libro.Titulo.ToLower() == titulo.ToLower())
                {
                    Console.WriteLine("Libro encontrado:");
                    Console.WriteLine("Título: " + libro.Titulo);
                    Console.WriteLine("Autor: " + libro.Autor);
                    if (libro.Disponible)
                    {
                        Console.WriteLine("Disponible: Sí");
                    }
                    else
                    {
                        Console.WriteLine("Disponible: No");
                    }
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        static void PrestarLibro()
        {
            Console.Write("Ingrese el título del libro a prestar: ");
            string titulo = Console.ReadLine();
            bool encontrado = false;
            foreach (var libro in libros)
            {
                if (libro.Titulo.ToLower() == titulo.ToLower())
                {
                    if (libro.Disponible)
                    {
                        libro.Prestar();
                        encontrado = true;
                    }
                    else
                    {
                        Console.WriteLine("El libro " + titulo + " no está disponible para préstamo.");
                    }
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
        static void DevolverLibro()
        {
            Console.Write("Ingrese el título del libro a devolver: ");
            string titulo = Console.ReadLine();
            bool encontrado = false;
            foreach (var libro in libros)
            {
                if (libro.Titulo.ToLower() == titulo.ToLower())
                {
                    if (!libro.Disponible)
                    {
                        libro.Devolver();
                        encontrado = true;
                    }
                    else
                    {
                        Console.WriteLine("El libro " + titulo + " no está prestado.");
                    }
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }
    } 
}

