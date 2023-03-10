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
            Random rnd = new Random();
            int cont = 0;
            int monx = rnd.Next(2, 21);
            int mony = rnd.Next(1, 10);
            ConsoleKeyInfo tecla;
            int col = 12, row = 6;
            int score = 0;
            
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("╔═══════════════════════╗");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("║                       ║");
            }
            Console.WriteLine("╚═══════════════════════╝");
            Console.WriteLine("Puntuacion: " + score);
            Console.SetCursorPosition(col, row);
            Console.Write("+");

            Console.SetCursorPosition(monx, mony);
            Console.WriteLine("°");

            Console.CursorVisible = false;
            while (true)
            {
                if (cont == 0)
                {
                    cont++;
                    mony++;
                    Console.SetCursorPosition(0, mony);
                    Console.WriteLine("║");
                }
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
                    if (col > 2)
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
                if (col == monx && row == mony)
                {
                    Console.Beep();
                    monx = 0;
                    mony = 0;
                    Console.SetCursorPosition(12, 13);
                    score++;
                    Console.WriteLine(score);
                }
            }
            Console.CursorVisible = false;
        }
    }
}