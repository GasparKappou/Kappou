using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios5
{
    class Serie
    {
        private string titulo;
        private int cantTemp = 3;
        private bool entregado = false;
        private string genero;
        private string autor;

        public Serie()
        {

        }
        public Serie(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public Serie(string titulo, int cantTemp, string genero, string autor)
        {
            this.titulo = titulo;
            this.cantTemp= cantTemp;
            this.genero = genero;
            this.autor = autor;
        }

        public void agregarSerie(string titulo, string autor)
        {
            new Serie(titulo, autor);
        }
        public void agregarSerie(string titulo, int cantTemp, string genero, string autor)
        {
            new Serie(titulo, cantTemp, genero, autor);
        }
    }

    class Videojuego
    {
        private string titulo;
        private int horasEstimadas = 10;
        private bool entregado = false;
        private string genero;
        private string compañia;

        public Videojuego()
        {

        }
        public Videojuego(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
        }
        public Videojuego(string titulo, int horasEstimadas, string genero, string compañia)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            this.genero = genero;
            this.compañia = compañia;
        }

        public void agregarJuego(string titulo, int horasEstimadas)
        {
            new Videojuego(titulo, horasEstimadas);
        }
        public void agregarJuego(string titulo, int horasEstimadas, string genero, string compañia)
        {
            new Videojuego(titulo, horasEstimadas, genero, compañia);
        }
    }

    class Ejecutable
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
