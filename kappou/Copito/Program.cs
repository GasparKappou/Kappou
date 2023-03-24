using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copito
{
    class Copo
    {
        public int x, y, limit;

        public Copo(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.limit = 10;
        }

        public void mostrar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }

        public void bajar(List<Copo> list)
        {
            if (y < limit)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");

                if (y + 1 < limit && list.FirstOrDefault(c => c.x == x && c.y == y + 1) == null)
                {
                    // La posición debajo del copo está vacía, por lo que simplemente se mueve hacia abajo
                    y++;
                }
                else
                {
                    // La posición debajo del copo está ocupada, por lo que se elimina el copo actual
                    // y se agrega un nuevo copo en la posición superior de la misma columna
                    list.Remove(this);
                    list.Add(new Copo(x, y));
                }

                Console.SetCursorPosition(x, y);
                Console.Write("*");
            }
            else
            {
                // Si se alcanza el límite superior, se elimina el copo actual
                list.Remove(this);
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Copo> Copos = new List<Copo>();
            Random rand = new Random();

            DateTime hora = DateTime.Now;
            DateTime horaActual = DateTime.Now;
            TimeSpan tiempoTrasncurrido;

            Console.CursorVisible = false;
            while (true)
            {

                horaActual = DateTime.Now;
                tiempoTrasncurrido = horaActual - hora;
                if (tiempoTrasncurrido.Milliseconds == 300)
                {
                    Copos.Add(new Copo(rand.Next(6), 0));
                    hora = DateTime.Now;

                    for (int i = Copos.Count - 1; i >= 0; i--)
                    {
                        Copo copoLista = Copos[i];
                        copoLista.bajar(Copos);
                        copoLista.mostrar();
                    }
                }
            }
        }
    }
}