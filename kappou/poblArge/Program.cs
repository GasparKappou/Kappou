using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ej11
{
    class Persona
    {
        string nombre;
        string apellido;
        int edad;
        public string email;

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
        public int Edad
        {
            get
            {
                return edad;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
        }


        public Persona(string nombre, string apellido, int edad, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.email = email;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();

            DateTime hora = DateTime.Now;

            personas.Add(new Persona("" , "" , 4 , ""));

            // Eliminar una persona de la lista
            personas.Remove(personas.Find(p => p.Nombre == "María" && p.Apellido == "García"));

            // Buscar una persona en la lista
            Persona personaEncontrada = personas.Find(p => p.email == "juanperez@gmail.com");
            while (true)
            {
                DateTime horaActual = DateTime.Now;
                TimeSpan timeSpan = hora - horaActual;

                if (timeSpan.Seconds % 30 == 0)
                {

                }
                if (timeSpan.Seconds % 60 == 0)
                {

                }
            }
            Console.ReadKey();
        }
    }
}