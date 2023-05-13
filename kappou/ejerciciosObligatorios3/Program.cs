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

        static public bool contraFuerte(Password[] contraseñas, char[] upper, char[] lower)
        {
            char[] numeros = "0123456789".ToCharArray();
            int up = 0;
            int lo = 0;
            int nu = 0;
            for (int i = 0; i < contraseñas.Length; i++)
            {
                char[] contraAct = contraseñas[i].Contraseña.ToCharArray();
                for (int j = 0; j < upper.Length; j++)
                { 
                    if (contraAct[i] == upper[j])
                    {
                        up++;
                    }
                    else if (contraAct[i] == lower[j])
                    {
                        lo++;
                    }
                }
                for (int j = 0; j < numeros.Length; j++)
                { 
                    if (contraAct[i] == numeros[j])
                    {
                        nu++;
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
                }
                for (int i = 0; i < cant; i++)
                {
                    fuerte[i] = contraFuerte(contraseñas, upper, lower);
                    Console.WriteLine(contraseñas[i].Contraseña + " " + fuerte[i]);
                }
                Console.Read();
            }
        }
    }
}
