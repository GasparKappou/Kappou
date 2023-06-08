using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios2
{
    class Persona
    {
        public string nombre = "Default";
        public int edad = 0;
        public int dni;
        public char genero = 'h';
        public double peso = 0;
        public double altura = 0;

        public Persona(int rnd)
        {
            this.nombre = "Pablo";
            this.edad = 47;
            this.dni = rnd;
            this.genero = 'h';
            this.peso = 75;
            this.altura = 1.75;
        }
        public Persona(string nombre, int edad, int dni, char genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
            this.dni = dni;
        }
        public Persona(string nombre, int edad, int dni, char genero, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.genero = genero;
            this.peso = peso;
            this.altura  = altura;
        }
        static public double calcularIMC(Persona persona)
        {//kg/(altura^2  en m))
            double IMC = persona.peso / (Math.Pow(persona.altura, 2));
            if (IMC < 20)
            {
                return -1;
            }
            else if (IMC >= 20 && IMC <= 25)
            {
                return 0;
            }
            else if (IMC > 25)
            {
                return 1;
            }
            return 2;
        }
        static public bool mayorDeEdad(Persona personas)
        {
            if (personas.edad < 18)
            {
                return false;
            }
            else if (personas.edad > 18)
            {
                return true;
            }
            return false;
        }
        static public char comprobarGenero(Persona persona)
        {
            if (persona.genero != 'h' || persona.genero != 'H' || persona.genero != 'm' || persona.genero != 'M')
            {
                return 'h';
            }
            return persona.genero;
        }
        static public int generaDNI(Random rnd)
        {
            return rnd.Next(10000000, 99999999);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            Random rnd = new Random();

            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese genero");
            char genero = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ingrese peso en kilogramos");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese altura en metros");
            double altura = Convert.ToDouble(Console.ReadLine());

            personas.Add(new Persona(nombre, edad, Persona.generaDNI(rnd), genero, peso, altura));
            personas.Add(new Persona(nombre, edad, Persona.generaDNI(rnd), genero));
            personas.Add(new Persona(Persona.generaDNI(rnd)));
            Console.Clear();
            for (int i = 0; i < personas.Count; i++)
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Nombre: " + personas[i].nombre);
                Console.WriteLine("edad: " + personas[i].edad);
                Console.WriteLine("dni: " + personas[i].dni);
                Console.WriteLine("genero: " + Persona.comprobarGenero(personas[i]));
                Console.WriteLine("peso: " + personas[i].peso);
                Console.WriteLine("altura: " + personas[i].altura);
                double imc = Persona.calcularIMC(personas[i]);
                if (imc == -1)
                {
                    Console.WriteLine("Debajo del promedio");
                }
                else if (imc == 0)
                {
                    Console.WriteLine("Promedio");
                }
                else if (imc == 1)
                {
                    Console.WriteLine("Arriba del promedio");
                }
                else if (imc == 2)
                {
                    Console.WriteLine("Llega otro valor");
                }
                if (Persona.mayorDeEdad(personas[i]))
                {
                    Console.WriteLine("Es mayor");
                }
                else
                {
                    Console.WriteLine("No es mayor");
                }
            }
            Console.ReadKey();
        }   
    }
}
