using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios6
{
    class Libro
    {
        long isbn;
        string titulo;
        string autor;
        int cantPag;
        public Libro(long isbn, string titulo, string autor, int numPag)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.cantPag = numPag;
        }
        public long Isbn
        {
            get
            {
                return this.isbn;
            }
            set
            {
            }
        }
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
            }
        }
        public string Autor
        {
            get
            {
                return this.autor;
            }
            set
            {
            }
        }
        public int CantPag
        {
            get
            {
                return this.cantPag;
            }
            set
            {
            }
        }
    }
    internal class Program
    {
        static public void mostrarLibros(Libro[] libros)
        {
            for (int i = 0; i < libros.Length; i++)
            {
                Console.WriteLine("El libro " + libros[i].Titulo + " creado por " + libros[i].Autor + " tiene " + libros[i].CantPag + " paginas.");
            }
        }
        static void Main(string[] args)
        {
            Libro[] libros = new Libro[2];

            libros[0] = new Libro(9789872243739, "El matadero", "Esteban Echeverria", 15);
            libros[1] = new Libro(8466319050, "Rayuela", "Esteban Echeverria", 728);

            mostrarLibros(libros);

            int mayorLibro = 0;
            int mayorL = libros[0].CantPag;

            for (int i = 0; i < libros.Length; i++)
            {
                if (mayorL < libros[i].CantPag)
                {
                    mayorLibro = i;
                    mayorL = libros[i].CantPag;
                }
            }
            Console.WriteLine(libros[mayorLibro].Titulo + " es el libro con mayor cantidad de paginas");

            Console.ReadKey();
        }
    }
}
