using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios7
{
    class Raices
    {
        public int a;
        public int b;
        public int c;
        public Raices(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
    internal class Program
    {
        static double[] getRaices(Raices formula)
        {
            double[] raices = new double[2];
            raices[0] = (-1 * formula.b - Math.Sqrt((Math.Pow(formula.b, 2)) - 4 * formula.a * formula.c)) / (2 * formula.a);
            raices[1] = (-1 * formula.b + Math.Sqrt((Math.Pow(formula.b, 2)) - 4 * formula.a * formula.c)) / (2 * formula.a);
            return raices;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese los valores que primero multiplica a x₂, luego el que multiplica a x, y por ultimo el valor independiente, cada uno seguido de un 'enter'");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    if (((Math.Pow(b, 2)) - 4 * a * c) < 0) { break; }
                    Raices formula = new Raices(a, b, c);

                    double[] raices = getRaices(formula);
                    Console.WriteLine("Las soluciones son: Xsub1 = " + raices[0] + " Xsub2 = " + raices[1]);

                    Console.ReadKey();
                }
                Console.WriteLine("Ecuacion no valida");
                Console.ReadKey();
            }
        }
    }
}
