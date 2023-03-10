using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tecla;
            int row = 5, col = 10;
            Console.WriteLine("#########################");
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("#                       #");
            }
            Console.WriteLine("#########################");

            Console.SetCursorPosition(col, row);
            Console.Write("+");

            Console.CursorVisible = false;
            while (true)
            {
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (row > 1)
                        row--;
                    Console.SetCursorPosition(col, row);
                    Console.Write("+");
                }
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (row < 11)
                        row++;
                    Console.SetCursorPosition(col, row);
                    Console.Write("+");
                }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (col > 1)
                        col--;
                    Console.SetCursorPosition(col, row);
                    Console.Write("+");
                }
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (col < 22)
                        col++;
                    Console.SetCursorPosition(col, row);
                    Console.Write("+");
                }
                if (tecla.Key == ConsoleKey.Escape)
                    break;
            }
            Console.CursorVisible = false;


        }
    }
}