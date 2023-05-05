using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4._4
{
    class Electrodomestico
    {
        double precioBase;
        string color;
        Char consumoEnergetico;
        double peso;

        public Electrodomestico()
        {
            this.precioBase = 100;
            this.color = "blanco";
            this.consumoEnergetico = 'F';
            this.peso = 5;
        }
        public Electrodomestico(double precio, double peso)
        {
            this.color = "blanco";
            this.consumoEnergetico = 'F';
            this.precioBase = precio;
            this.peso = peso;
        }
        public Electrodomestico(double precioBase, string color, Char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }
    }
    class Lavadora : Electrodomestico
    {
        double carga;
        public Lavadora() : base()
        {
            this.carga = 5;
        }
        public Lavadora(double precio, double peso) : base(precio, peso)
        {
            this.carga = 5;
        }
        public Lavadora(double precio, string color, Char consumoEnergetico, double peso, double carga) : base(precio, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }
    }

    class Tv : Electrodomestico
    {
        double resolucion;
        bool TDT;
        public Tv() : base()
        {
            this.resolucion = 20;
            this.TDT = false;
        }
        public Tv(double precio, double peso) : base(precio, peso)
        {
            this.resolucion = 20;
            this.TDT = false;
        }
        public Tv(double precio, string color, Char consumoEnergetico, double peso, double resolucion, bool TDT) : base(precio, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.TDT = TDT;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Electrodomestico> elecs = new List<Electrodomestico>();
            List<Lavadora> lavas = new List<Lavadora>();
            List<Tv> teles = new List<Tv>();

            elecs.Add(new Electrodomestico());
            lavas.Add(new Lavadora());
            teles.Add(new Tv());

            Console.WriteLine(elecs[0]);
            Console.WriteLine(lavas[0]);
            Console.WriteLine(teles[0]);

            Console.ReadKey();
        }
    }
}