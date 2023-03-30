using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros= new List<int>();
            Random rand = new Random();
            for(int i = 0; i <= 10; i++)
                numeros.Add(rand.Next(10000));
            for (int i = 0; i < numeros.Count; i++)
                Console.WriteLine(numeros[i]);
            Console.ReadKey();
        }
    }
}
