using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_AI
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de mazmorras!");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Estás en una habitación oscura.");
            Console.WriteLine("Hay una puerta cerrada frente a ti.");
            Console.WriteLine("Presione 'o' para abrir la puerta...");

            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.KeyChar == 'o')
                {
                    Console.Clear();
                    Console.WriteLine("La puerta se abre y entras en otra habitación.");
                    break;
                }
                else
                {
                    Console.Beep();
                }
            }

            // Aquí puedes agregar más código para el resto del juego.
        }
    }
}
