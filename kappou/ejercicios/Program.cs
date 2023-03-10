using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class Program
    {
        static Int32 suma(Int16 num1, Int16 num2)
        {
            return num1 + num2;
        }

        static void Main(string[] args)
        {
            Int16 n1 = 10, n2 = 20;
            Int32 resultado1, resultado2, resultado3;

            resultado1 = suma(n1, n2);
            resultado2 = suma(100, 3);
            resultado3 = suma(1, 232);

            if (resultado1 > resultado2 && resultado1 > resultado3)
                Console.WriteLine(resultado1);
            if (resultado2 > resultado3 && resultado2 > resultado1)
                Console.WriteLine(resultado2);
            if (resultado3 > resultado1 && resultado3 > resultado2)
                Console.WriteLine(resultado3);
            Console.ReadKey();
        }
    }
}
