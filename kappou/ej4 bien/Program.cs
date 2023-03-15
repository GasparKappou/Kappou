using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Ej05
{
    internal class Program
    {
        static int arreglaEsp(int monY)
        {
            monY++;
            Console.SetCursorPosition(0, monY);
            Console.WriteLine("║");
            return monY;
        }
        static void Main(string[] args)
        {
            //variables
            ConsoleKeyInfo tecla;
            int col = 12, row = 6;
            int score = 0;
            int cont = 0;
            int once = 0;
            Random rnd = new Random();
            int monx = rnd.Next(2, 21);
            int mony = rnd.Next(1, 10);
            Stopwatch stopwatch = new Stopwatch();
            

            //introduccion
            Console.WriteLine("Tienes 10 segundos para conseguir la mayor puntuacion posible");
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            //mapa
            Console.WriteLine("╔═══════════════════════╗");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("║                       ║");
            }
            Console.WriteLine("╚═══════════════════════╝");
            Console.WriteLine("Puntuacion: " + score);
            Console.SetCursorPosition(col, row);
            Console.Write("+");

            Console.CursorVisible = false;

            //juego
            while (stopwatch.Elapsed.TotalSeconds < 10)
            {
                if (once == 0) {
                    once++;
                    stopwatch.Start();
                }
                //monedas
                if (cont == 0)
                {
                    cont++;
                    monx = rnd.Next(2, 21);
                    mony = rnd.Next(1, 10);
                    
                }
                Console.SetCursorPosition(monx, mony);
                Console.WriteLine("°");
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    arreglaEsp(mony);
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (row > 1)
                        row--;
                    Console.SetCursorPosition(col, row);
                    Console.Write("+");
                }
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    arreglaEsp(mony);
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (row < 11)
                        row++;
                    Console.SetCursorPosition(col, row);
                    Console.Write("+");
                }
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    arreglaEsp(mony);
                    Console.SetCursorPosition(col, row);
                    Console.Write(" ");
                    if (col > 2)
                        col--;
                    Console.SetCursorPosition(col, row);
                    Console.Write("+");
                }
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    arreglaEsp(mony);
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
                    cont--;
                    Console.WriteLine(score);
                }
            }
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine("Puntaje final: " + score);
            Thread.Sleep(3000);
            Console.ReadKey();
        }
    }
}