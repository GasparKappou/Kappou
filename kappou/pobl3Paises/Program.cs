using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    class Pais
    {
        List<Persona> personas;

        public Pais(List<Persona> personas)
        {
            this.personas = personas;
        }
    }
    class Persona
    {
        string nombre;
        string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }

    internal class Program
    {
        /*static void mostrarPersonas(List<Paises> paises)
        {
            Console.Clear();
            Console.WriteLine("Poblacion:");
            for (int i = 0; i < personas.Count; i++)
            {
                Console.WriteLine(personas[i].Nombre + " " + personas[i].Apellido);
            }
        }*/
        static void agregarPersonas(List<Pais> paises)
        {
            string[] nombres = { "Angie", "Tobias", "Sofia", "Gaspar" };
            string[] apellidos = { "Ventura", "Coman", "Zabalza", "Kappou" };
            Random ran = new Random();
            paises.Add(new Pais(new List<Persona>(nombres[ran.Next(0, 4)], apellidos[ran.Next(0, 4)])));
        }/*
        static void matarPersonas(List<Paises> paises)
        {
            personas.Remove(personas[0]);
        }*/
        static void Main(string[] args)
        {
            //personas.Add(new Persona("" , ""));

            // Eliminar una persona de la lista
            //personas.Remove(personas.Find(p => p.Nombre == "María" && p.Apellido == "García"));

            // Buscar una persona en la lista
            //Persona personaEncontrada = personas.Find(p => p.email == "juanperez@gmail.com");
            List<Pais> paises = new List<Pais>();
            List<Persona> arg = new List<Persona>();
            List<Persona> bra = new List<Persona>();
            List<Persona> par = new List<Persona>();

            paises.Add(new Pais(arg));
            paises.Add(new Pais(bra));
            paises.Add(new Pais(par));

            agregarPersonas(paises);
            Console.ReadKey();

            /*int cant10 = 1;
            int cant30 = 2;
            DateTime hora = DateTime.Now;

            while (true)
            {
                DateTime horaActual = DateTime.Now;

                TimeSpan lapso = horaActual - hora;


                if (lapso.Seconds == 1)
                {
                    hora = DateTime.Now;
                    cant10++;
                    //Console.WriteLine("pasaron 10 seg");
                    mostrarPersonas(paises);
                }
                if (cant10 % 4 == 0)
                {
                    cant10 = 1;
                    cant30++;
                    agregarPersonas(paises);
                }
                if (cant30 % 4 == 0)
                {
                    cant10 = 1;
                    cant30 = 1;
                    matarPersonas(paises);
                }
                Console.SetCursorPosition(0, 0);
            }*/
        }
    }
}