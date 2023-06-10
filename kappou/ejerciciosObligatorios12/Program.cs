using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejerciciosObligatorios12
{
    /*
    Vamos a hacer el juego de la ruleta rusa en Java.
    Como muchos sabéis, se trata de un número de jugadores que con un revólver con un sola bala en el tambor se dispara en la cabeza.
    Las clases a hacer son:

        Revolver:
            Atributos:
                posición actual(posición del tambor donde se dispara, puede que esté la bala o no)
                posición bala(la posición del tambor donde se encuentra la bala)
                Estas dos posiciones, se generarán aleatoriamente.
            Funciones:
                disparar() : devuelve true si la bala coincide con la posición actual
                siguienteBala() : cambia a la siguiente posición del tambor
        */
    class Revolver
    {
        public int posActu;
        public int posBala;

        public Revolver(int posActu, int posBala)
        {
            this.posActu = posActu;
            this.posBala = posBala;
        }

        static public bool disparar(Revolver revo)
        {
            if (revo.posActu == revo.posBala)
            {
                siguienteBala(revo);
                return true;
            }
            siguienteBala(revo);
            return false;
        }

        static public Revolver siguienteBala(Revolver revo)
        {
            if (revo.posActu == 10)
                revo.posActu = 0;
            else
                revo.posActu++;
            return revo;
        }

    }
    /*
    Jugador:
        Atributos
            id (representa el número del jugador, empieza en 1)
            nombre (Empezara con Jugador más su ID, «Jugador 1» por ejemplo)
            vivo (indica si está vivo o no el jugador)
        Funciones:
            disparar(Revólver r): el jugador se apunta y se dispara, si la bala se dispara, el jugador muere.
    */
    class Jugador
    {
        public int id;
        public string nom;
        public bool vivo = true;

        public Jugador(int id, string nom)
        {
            this.id = id;
            this.nom = nom;
        }

        static public void disparar(Revolver revo, Jugador juga)
        {
            if (Revolver.disparar(revo))
            {
                juga.vivo = false;
            }
        }
    }
    /*
    Juego:
        Atributos:
            Jugadores (conjunto de Jugadores)
            Revolver
        Funciones:
            finJuego(): cuando un jugador muere, devuelve true
            ronda(): cada jugador se apunta y se dispara, se informará del estado de la partida (El jugador se dispara, no ha muerto en esa ronda, etc.)
    */
    class Juego
    {
        static public bool finJuego(List<Jugador> jugadores)
        {
            if (jugadores.Count(j => j.vivo) == 1)
                return true;
            return false;
        }
        static public string ronda(Jugador jugador, Revolver revo)
        { 
            
            Jugador.disparar(revo, jugador);
            Revolver.disparar(revo);
            if (jugador.vivo)
                return "Jugador/a " + jugador.nom + jugador.id + " no ha muerto en esta ronda";
            return "Jugador/a " + jugador.nom + jugador.id + " ha muerto en esta ronda";
        }
    }
    internal class Program
    {
        /*
            El número de jugadores será decidido por el usuario, pero debe ser entre 1 y 6. Si no está en este rango, por defecto será 6.
            En cada turno uno de los jugadores, dispara el revólver, si este tiene la bala  el jugador muere y el juego termina.
            Aunque no lo haya comentado, recuerda usar una clase ejecutable para probarlo.
        */
        static void Main(string[] args)
        {
            while (true)
            {
                int cantJug;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad de jugadores en esta partida, debe estar entre 2 y 6:");
                    cantJug = Convert.ToInt32(Console.ReadLine());
                    if (cantJug >= 2 && cantJug <= 6)
                        break;
                }

                List<Jugador> jugadores = new List<Jugador>();
                Random rnd = new Random();
                string[] noms = { "Gaspar", "Angie", "Luis", "Sofia", "Tobias", "Claudia" };


                Revolver revo = new Revolver(rnd.Next(0, 11), rnd.Next(0, 11));

                int id = 1;
                for (int i = 0; i < cantJug; i++)
                {
                    jugadores.Add(new Jugador(id++, noms[rnd.Next(0, noms.Length)]));
                }

                for (int i = 0; i < cantJug || !Juego.finJuego(jugadores); i++)
                {
                    Console.WriteLine("Ronda " + i);
                    for(int j = 0; j < cantJug; j++)
                        Console.WriteLine(Juego.ronda(jugadores[j], revo));
                }
                Console.ReadKey();
            }
        }
    }
}
