using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios5
{
    class Serie
    {
        public string titulo;
        public int cantTemp = 3;
        public bool entregado = false;
        public string genero;
        public string autor;

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

        static public Serie agregarSerie(string titulo, string autor)
        {
            return new Serie(titulo, autor);
        }
        static public Serie agregarSerie(string titulo, int cantTemp, string genero, string autor)
        {
            return new Serie(titulo, cantTemp, genero, autor);
        }
    }

    class Videojuego
    {
        public string titulo;
        public int horasEstimadas = 10;
        public bool entregado = false;
        public string genero;
        public string compañia;

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

        static public Videojuego agregarJuego(string titulo, int horasEstimadas)
        {
            return new Videojuego(titulo, horasEstimadas);
        }
        static public Videojuego agregarJuego(string titulo, int horasEstimadas, string genero, string compañia)
        {
            return new Videojuego(titulo, horasEstimadas, genero, compañia);
        }
    }

    class Entregable
    {
        static public void entregar(Videojuego juego)
        {
            juego.entregado = true;
        }
        static public void entregar(Serie serie)
        {
            serie.entregado = true;
        }
        static public void devolver(Videojuego juego)
        {
            juego.entregado = false;
        }
        static public void devolver(Serie serie)
        {
            serie.entregado = false;
        }
        static public bool isEntregado(Videojuego juego)
        {
            return juego.entregado;
        }
        static public bool isEntregado(Serie serie)
        {
            return serie.entregado;
        }
        static public int compareTo(Videojuego[] juegos)
        {
            int mayorJuego = 0;
            int mayorJ = juegos[0].horasEstimadas;

            for (int i = 0; i < 5; i++)
            {
                int j = juegos[i].horasEstimadas;
                if (mayorJ < j)
                {
                    mayorJuego = i;
                    mayorJ = juegos[i].horasEstimadas;
                }
            }
            return mayorJuego;
        }
        static public int compareTo(Serie[] series)
        {
            int mayorSerie = 0;
            int mayorS = series[0].cantTemp;

            for (int i = 0; i < 5; i++)
            {
                if (mayorS < series[i].cantTemp)
                {
                    mayorSerie = i;
                    mayorS = series[i].cantTemp;
                }
            }
            return mayorSerie;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Serie[] series = new Serie[5];
            Videojuego[] juegos = new Videojuego[5];

            series[0] = Serie.agregarSerie("HIMYM", 9, "Comedia", "Craig Thomas");
            series[1] = Serie.agregarSerie("Los chicos del barrio", 6, "Comedia", "Carter Bays");
            series[2] = Serie.agregarSerie("Friends", 10, "Comedia", "James Burrows");
            series[3] = Serie.agregarSerie("Brooklyn Nine-Nine", 8, "Comedia", "Michael Schur");
            series[4] = Serie.agregarSerie("The Office", 9, "Comedia", "Greg Daniels");
            juegos[0] = Videojuego.agregarJuego("Hollow Knight", 50, "Metroidvania", "TeamCherry");
            juegos[1] = Videojuego.agregarJuego("Hollow Knight: Silksong", 100, "Metroidvania", "TeamCherry");
            juegos[2] = Videojuego.agregarJuego("The Legend of Zelda: Breath Of The Wild", 50, "Mundo Abierto", "Nintendo");
            juegos[3] = Videojuego.agregarJuego("The Stanley Parable", 1000, "Puzzles", "Valve");
            juegos[4] = Videojuego.agregarJuego("Elden Ring", 200, "Mundo Abierto", "From SoftWare");

            Entregable.entregar(juegos[2]);
            Entregable.entregar(juegos[1]);
            Entregable.entregar(juegos[3]);
            Entregable.entregar(series[2]);
            Entregable.entregar(series[0]);

            List<int> seriesEntregadas = new List<int>();
            List<int> juegosEntregados = new List<int>();
            

            for (int i = 0; i < 5; i++)
            { 
                if (Entregable.isEntregado(series[i]))
                {
                    seriesEntregadas.Add(i);
                }
                if (Entregable.isEntregado(juegos[i]))
                {
                    juegosEntregados.Add(i);
                }
            }
            Console.WriteLine("Cantidad de juegos entregados: " + juegosEntregados.Count);
            Console.WriteLine("Estos juegos son: ");
            foreach(int ju in juegosEntregados)
            {
                Console.WriteLine(juegos[ju].titulo);
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Cantidad de series entregadas: " + seriesEntregadas.Count);
            Console.WriteLine("Estas series son: ");
            foreach (int se in seriesEntregadas)
            {
                Console.WriteLine(series[se].titulo);
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("El juego con mas horas estimadas es: " + juegos[Entregable.compareTo(juegos)].titulo);
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("La serie con mas temporadas es: " + series[Entregable.compareTo(series)].titulo);

            Console.ReadKey();
        }
    }
}
