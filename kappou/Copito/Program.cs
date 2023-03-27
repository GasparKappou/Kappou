﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nieve
{
    class Copo
    {
        public int x, y;

        public Copo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void mostrar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
        }

        public void bajar(int altura)
        {
            if (y < altura)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                y++;
                Console.SetCursorPosition(x, y);
                Console.Write("*");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int ancho = 5;
            int altura = 5;
            int cantPart = 0;
            List<Copo> list = new List<Copo>();
            Random rand = new Random();

            DateTime hora = DateTime.Now;
            //DateTime horaActual = DateTime.Now;
            TimeSpan tiempoTrasncurrido;

            bool bajar;
            Console.CursorVisible = false;
            while (true)
            {
                DateTime horaActual = DateTime.Now;
                tiempoTrasncurrido = horaActual - hora;
                if (tiempoTrasncurrido.Milliseconds >= 500)
                {
                    list.Add(new Copo(rand.Next(ancho), 0));
                    hora = DateTime.Now;
                    foreach (Copo copoLista in list)
                    {
                        if(copoLista.y == altura)
                        {
                            cantPart++;
                        }
                        bajar = true;
                        foreach (Copo temp in list)
                        {
                            if ((temp.x == copoLista.x) && (temp.y == copoLista.y + 1))
                            {
                                bajar = false;
                                break;
                            }  
                        }
                        if (bajar)
                        {
                            copoLista.bajar(altura);
                            copoLista.mostrar();
                        }
                    }
                    if (cantPart == ancho)
                    {
                        for(int i = list.Count-1; i >= 0; i--)
                        {
                            if (list[i].y == altura)
                            {
                                list.RemoveAt(i);
                            }
                        }
                        Console.SetCursorPosition(0, altura);
                        Console.Write("                                      ");
                    }
                    cantPart = 0;
                }
            }
        }
    }
}