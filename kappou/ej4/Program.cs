using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int y = 10;
            int x = 10;
            ConsoleKeyInfo flecha;
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("+");
                flecha = Console.ReadKey();
                if (flecha.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    y--;
                }
                if (flecha.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    y++;
                }
                if (flecha.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    x--;
                }
                if (flecha.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    x++;
                }
            }
                
        }
    }
}
