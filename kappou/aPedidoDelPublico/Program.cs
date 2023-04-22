using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aPedidoDelPublico
{
    internal class Program
    {
        static void salir(int prg, int op)
        {
            if (prg == 1)
            {
                Environment.Exit(0);
            }
            else if (prg == 0)
            {
                op = 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("que programa quiere utilizar?");
            Console.WriteLine("1. Calculo de promedio");
            Console.WriteLine("2. Cajero automatico");
            Console.WriteLine("3. Adivinar numeros");
            Console.WriteLine("4. Numeros primos");
            Console.WriteLine("5. Ahorcado");
            Console.WriteLine("6. Lista de tareas");
            Console.WriteLine("7. Min Max");
            Console.WriteLine("8. Biblioteca");
            Console.WriteLine("9. Distancia en plano cartesiano");
            Console.WriteLine("10. Conversor de unidades");
            int op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //1.Crear un programa que calcule el promedio de un conjunto de números ingresados por el usuario.
            while (op == 1)
            {
                List<int> nums = new List<int>();
                int prom = 0;
                Console.WriteLine("Ingrese la cantidad de numeros que quiera ingresar: ");
                int cant = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Ingrese sus numeros: ");
                for (int i = 0; i < cant; i++)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    nums.Add(num);
                }
                for (int i = 0; i < cant; i++)
                {
                    prom += nums[i]; 
                }
                float promTot = prom / cant;
                Console.WriteLine(promTot);
                Console.WriteLine("Si quiere usar otro progama toque '0', si quiere cerrar la ventana toque '1'");
                int sale = Convert.ToInt32(Console.ReadLine());
                salir(sale, op);
            }
            //2. Crear un programa que simule un cajero automático, permitiendo al usuario hacer depósitos, retiros y consultar su saldo.
            while (op == 2)
            {
                float saldo = 0;
                Console.WriteLine("Que quiere hacer?");
                Console.WriteLine("1. Hacer un deposito");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Consultar saldo");
                int prg = Convert.ToInt32(Console.ReadLine());

                if (prg == 1)
                {
                    Console.WriteLine("¿Cuanto quiere ingresar?");
                    float ingreso = Convert.ToInt32(Console.ReadLine());
                    if(ingreso <= 0) {
                        Console.WriteLine("Cantidad de dinero invalida, vuelva a intentar.");
                    }
                    else {
                        saldo = ingreso;
                    }
                }
                else if (prg == 2) 
                {
                    Console.WriteLine("¿Cuanto quiere retirar?");
                    float retiro = Convert.ToInt32(Console.ReadLine());
                    if (retiro <= 0 || retiro >= saldo)
                    {
                        Console.WriteLine("Cantidad de dinero fuera de rango, vuelva a intentar.");
                    }
                    else if (retiro <= saldo)
                    {
                        Console.WriteLine("Saldo retirado.");
                        saldo = saldo - retiro;
                    }
                }
                else if(prg == 3)
                {
                    Console.WriteLine(saldo);
                }
            }
            //3. Crear un programa que simule un juego de adivinanza de números, en el que el usuario debe adivinar un número generado aleatoriamente por el programa.
            while (op == 3)
            {
            }
            //4. Crear un programa que genere una lista de números primos hasta un número ingresado por el usuario.
            while (op == 4)
            {
            }
            //5. Crear un programa que simule un juego de ahorcado, en el que el usuario debe adivinar una palabra oculta letra por letra.
            while (op == 5)
            {
            }
            //6. Crear un programa que permita al usuario ingresar una lista de tareas y organizarlas por orden de prioridad.
            while (op == 6)
            {
            }
            //7. Crear un programa que permita al usuario ingresar una serie de números y determine cuál es el número más grande y cuál es el número más pequeño.
            while (op == 7)
            {
            }
            //8.Crear un programa que simule una biblioteca, permitiendo al usuario buscar y prestar libros, y llevando un registro de los préstamos y devoluciones.
            while (op == 8)
            {
            }
            //9. Crear un programa que permita al usuario calcular la distancia entre dos puntos en un plano cartesiano.
            while (op == 9)
            {
            }
            //10. Crear un programa que permita al usuario convertir una cantidad de una unidad de medida a otra, por ejemplo, de metros a pies.
            while (op == 10)
            {
            }
        }
    }
}