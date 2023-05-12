using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios2
{
    class Persona
    {
        public string nombre = "";
        public int edad = 0;
        public int dni;
        public char genero = 'h';
        public double peso = 0;
        public double altura = 0;

        public Persona()
        {
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
        static public double calcularIMC(List<Persona> personas)
        {

        }
        static public double mayorDeEdad(List<Persona> personas)
        {
        
        }
        static public double comprobarGenero(List<Persona> personas)
        {

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
            personas.Add(new Persona());
        }   
    }
}
