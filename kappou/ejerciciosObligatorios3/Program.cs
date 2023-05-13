using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios3
{
    class Password
    {
        int longitud = 8;
        string contraseña;

        public int Longitud
        {
            get
            {
                return longitud;
            }
            set
            {
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }
        }
        public Password()
        {
        }

        public Password(int longitud, string contraseña)
        {
            this.longitud = longitud;
            this.contraseña = contraseña;
        }
    }
    internal class Program
    {
        static public string generarPassword(Random rnd, char[] upper, char[] lower, int longitud)
        {
            string contraseña = "";
            for (int i = 0; i < longitud; i++)
            {
                int random = rnd.Next(0, 3);
                if (random == 0)
                {
                    contraseña += upper[rnd.Next(0, upper.Length)];
                }
                else if (random == 1)
                {
                    contraseña += lower[rnd.Next(0, lower.Length)];
                }
                else if (random == 2)
                {
                    contraseña += rnd.Next(0, 10);
                }
            }
            return contraseña;
        }

        static public bool contraFuerte(string contraseña, char[] upper, char[] lower)
        {
            char[] numeros = "0123456789".ToCharArray();
            int up = 0;
            int lo = 0;
            int nu = 0;
            char[] contraAct = contraseña.ToCharArray();
            for (int Caracter = 0; Caracter < contraAct.Length; Caracter++)
            {

                for (int Lugar = 0; Lugar < upper.Length; Lugar++)
                {
                    if (contraAct[Caracter] == upper[Lugar])
                    {
                        up++;
                        break;
                    }
                }
                for (int Lugar = 0; Lugar < upper.Length; Lugar++)
                {
                    if (contraAct[Caracter] == lower[Lugar])
                    {
                        lo++;
                        break;
                    }
                }
                for (int Lugar = 0; Lugar < numeros.Length; Lugar++)
                {
                    if (contraAct[Caracter] == numeros[Lugar])
                    {
                        nu++;
                        break;
                    }
                }
            }
            if (up > 2 && lo > 1 && nu > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Cuantas contraseñas quiere?");
            int cant = Convert.ToInt32(Console.ReadLine());
            Password[] contraseñas = new Password[cant];
            bool[] fuerte = new bool[cant];

            char[] upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] lower = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            Console.WriteLine("Indique la longitud que quiere par su contraseña");
            int longi = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < cant; i++)
                {
                    contraseñas[i] = new Password(longi, generarPassword(rnd, upper, lower, longi));
                    fuerte[i] = contraFuerte(contraseñas[i].Contraseña, upper, lower);
                }
                for (int i = 0; i < cant; i++)
                {
                    Console.WriteLine(contraseñas[i].Contraseña + " " + fuerte[i]);
                }
                Console.Read();
            }
        }
    }
}
