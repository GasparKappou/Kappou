using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
Nos piden hacer una un programa que gestione empleados.
    Los empleados se definen por tener:
        Nombre
        Edad
        Salario
        También tendremos una constante llamada PLUS, que tendrá un valor de 300€
    Tenemos dos tipos de empleados: repartidor y comercial.
        El comercial, aparte de los atributos anteriores, tiene uno más llamado comisión (double).
        El repartidor, aparte de los atributos de empleado, tiene otro llamado zona (String).
    Crea sus constructores, getters and setters (piensa cómo aprovechar la herencia).
No se podrán crear objetos del tipo Empleado (la clase padre) pero sí de sus hijas.
Las clases tendrán un método llamado plus, que según en cada clase tendrá una implementación distinta. Este plus básicamente aumenta el salario del empleado.
    En comercial, si tiene más de 30 años y cobra una comisión de más de 200 euros, se le aplicará el plus.
    En repartidor, si tiene menos de 25 y reparte en la “zona 3”, este recibirá el plus.
    Puedes hacer que devuelva un booleano o que no devuelva nada, lo dejo a tu elección.
Crea una clase ejecutable donde crees distintos empleados y le apliques el plus para comprobar que funciona.
*/
namespace ejerciciosObligatorios13
{
    class Empleado
    {
        public string nomb;
        public int edad;
        public double salario;
        public const double PLUS = 300;
    }
    class Comercial : Empleado
    {
        public double comision;

        public Comercial(string nomb, int edad, double salario, double comision)
        {
            this.nomb = nomb;
            this.edad = edad;
            this.salario = salario;
            this.comision = comision;
        }

        public static void plus(Comercial comerciante)
        {
            if (comerciante.edad > 30 && comerciante.comision > 200)
            {
                comerciante.salario += Empleado.PLUS;
            }
            return;
        }
    }
    class Repartidor : Empleado
    {
        public string zona;

        public Repartidor(string nomb, int edad, double salario, string zona)
        {
            this.nomb= nomb;
            this.edad = edad;
            this.salario = salario;
            this.zona = zona;
        }
        public static void plus(Repartidor delivery)
        {
            if (delivery.edad < 25 && delivery.zona == "zona 3")
            {
                delivery.salario += Empleado.PLUS;
            }
            return;
        }
    }
    internal class Program
    {
        public static string mostrarInfo(Repartidor delivery)
        {
            return "Delivery: " + delivery.nomb + " salario: " + delivery.salario + " zona " + delivery.zona + " edad: " + delivery.edad;
        }
        public static string mostrarInfo(Comercial comerciante)
        {
            return "Comercial: " + comerciante.nomb + " salario: " + comerciante.salario + " comision: " + comerciante.comision + " edad: " + comerciante.edad;
        }
        static void Main(string[] args)
        {
            List<Repartidor> deliveris = new List<Repartidor>();
            List<Comercial> comerciantes= new List<Comercial>();
            Random rnd = new Random();
            string[] noms = { "Gaspar", "Angie", "Luis", "Sofia", "Tobias", "Claudia" };
            int cantD = 5;
            int cantC = 5;

            for (int i = 0; i < cantD; i++)
            {
                deliveris.Add(new Repartidor(noms[rnd.Next(0, noms.Length)], rnd.Next(16, 50), rnd.Next(150, 600) + rnd.NextDouble(), String.Join("zona", rnd.Next(1, 10))));
            }
            for (int i = 0; i < cantC; i++)
            {
                comerciantes.Add(new Comercial(noms[rnd.Next(0, noms.Length)], rnd.Next(16, 50), rnd.Next(150, 600) + rnd.NextDouble(), rnd.Next(100, 300) + rnd.NextDouble()));
            }

            if (cantC != cantD)
            {
                foreach (Repartidor delivery in deliveris)
                {
                    Console.WriteLine("Antes: " + mostrarInfo(delivery));
                    Repartidor.plus(delivery);
                    Console.WriteLine("Despues: " +mostrarInfo(delivery));
                }
                foreach (Comercial comercial in comerciantes)
                {
                    Console.WriteLine("Antes: " + mostrarInfo(comercial));
                    Comercial.plus(comercial);
                    Console.WriteLine("Despues: " + mostrarInfo(comercial));
                }
            }
            else
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Antes: " + mostrarInfo(deliveris[i]));
                    Repartidor.plus(deliveris[i]);
                    Console.WriteLine("Despues: " + mostrarInfo(deliveris[i]));
                    Console.WriteLine("Antes: " + mostrarInfo(comerciantes[i]));
                    Comercial.plus(comerciantes[i]);
                    Console.WriteLine("Despues: " + mostrarInfo(comerciantes[i]));
                }

            Console.ReadKey();
        }
    }
}
