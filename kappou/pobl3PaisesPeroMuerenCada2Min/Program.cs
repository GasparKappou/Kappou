using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej11
{
    class Persona
    {
        string nombre;
        string apellido;

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }

    internal class Program
    {
        static void mostrarPersonas(List<Persona> personas, int index)
        {
            for (int persona = 0; persona < personas.Count; persona++)
            {
                Console.SetCursorPosition(index * 30, persona + 1);
                Console.WriteLine(personas[persona].Nombre + " " + personas[persona].Apellido);
            }
        }

        static void agregarPersonas(List<Persona> pais)
        {
            string[] nombres = { "Angie ", "Tobias", "Sofia ", "Gaspar" };
            string[] apellidos = { "Ventura", "Coman  ", "Zabalza", "Kappou " };
            Random ran = new Random();
            pais.Add(new Persona(nombres[ran.Next(0, 4)], apellidos[ran.Next(0, 4)]));
        }

        static void matarPersonas(List<Persona> personas)
        {
            if (personas.Count == 0)
                return;
            personas.Remove(personas[0]);
        }

        static void Main(string[] args)
        {
            //personas.Add(new Persona("" , ""));

            // Eliminar una persona de la lista
            //personas.Remove(personas.Find(p => p.Nombre == "María" && p.Apellido == "García"));

            // Buscar una persona en la lista
            //Persona personaEncontrada = personas.Find(p => p.email == "juanperez@gmail.com");
            //List<Pais> paises = new List<Pais>();


            List<Persona> arg = new List<Persona>();
            List<Persona> bra = new List<Persona>();
            List<Persona> par = new List<Persona>();
            List<Persona>[] paises = { arg, bra, par };
            Random rn = new Random();
            int cant10 = 1;
            int cant120 = 5;

            DateTime hora = DateTime.Now;

            Console.CursorVisible = false;
            while (true)
            {
                DateTime horaActual = DateTime.Now;

                TimeSpan lapso = horaActual - hora;

                Console.WriteLine("Pobl Arg: ");
                Console.SetCursorPosition(30, 0);
                Console.WriteLine("Pobl Bra: ");
                Console.SetCursorPosition(60, 0);
                Console.WriteLine("Pobl Par: ");

                if (lapso.Seconds == 1)
                {
                    Console.Clear();
                    hora = DateTime.Now;
                    cant10++;
                    mostrarPersonas(paises[0], 0);
                    Console.SetCursorPosition(30, 0);
                    mostrarPersonas(paises[1], 1);
                    Console.SetCursorPosition(60, 0);
                    mostrarPersonas(paises[2], 2);
                }
                if (cant10 % 4 == 0)
                {
                    cant10 = 1;
                    cant120++;
                    int index = rn.Next(0, 3);
                    agregarPersonas(paises[index]);
                }
                if (cant120 % 17 == 0)
                {
                    cant10 = 1;
                    cant120 = 5;
                    matarPersonas(paises[0]);
                    matarPersonas(paises[1]);
                    matarPersonas(paises[2]);
                }
                Console.SetCursorPosition(0, 0);
            }
        }
    }
}