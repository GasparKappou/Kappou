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
        static int salir(int op)
        {
            Console.WriteLine("1. Usar otro programa");
            Console.WriteLine("2. Apagar programa");
            int sale = Convert.ToInt32(Console.ReadLine());

            if (sale == 2)
            {
                Environment.Exit(0);
            }
            return 0;
        }
        static void Main(string[] args)
        {
            double saldo = 0;
            while (true)
            {
                Console.WriteLine("¿Que programa quiere utilizar?");
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


                Random rd = new Random();

                //1.Crear un programa que calcule el promedio de un conjunto de números ingresados por el usuario.
                while (op == 1)
                {
                    Console.Clear();
                    List<int> nums = new List<int>();
                    double prom = 0;
                    Console.WriteLine("Ingrese la cantidad de numeros que quiera ingresar: ");
                    double cant = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese sus numeros: ");
                    for (int i = 0; i < cant; i++)
                    {
                        int num = Convert.ToInt32(Console.ReadLine());
                        nums.Add(num);
                        prom += nums[i];
                    }
                    double promTot = prom / cant;
                    Console.WriteLine("El promedio es: " + promTot);
                    op = salir(op);
                }
                //2. Crear un programa que simule un cajero automático, permitiendo al usuario hacer depósitos, retiros y consultar su saldo.
                while (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Que quiere hacer?");
                    Console.WriteLine("1. Hacer un deposito");
                    Console.WriteLine("2. Retirar dinero");
                    Console.WriteLine("3. Consultar saldo");
                    int prg = Convert.ToInt32(Console.ReadLine());

                    if (prg == 1)
                    {
                        Console.WriteLine("¿Cuanto quiere ingresar?");
                        double ingreso = Convert.ToInt32(Console.ReadLine());
                        if (ingreso < 0)
                        {
                            Console.WriteLine("Cantidad de dinero invalida, vuelva a intentar.");
                        }
                        else
                        {
                            saldo += ingreso;
                        }
                    }
                    else if (prg == 2)
                    {
                        Console.WriteLine("¿Cuanto quiere retirar?");
                        double retiro = Convert.ToInt32(Console.ReadLine());
                        if (retiro <= 0 || retiro >= saldo)
                        {
                            Console.WriteLine("Cantidad de dinero fuera de rango, vuelva a intentar.");
                        }
                        else if (retiro <= saldo)
                        {
                            Console.WriteLine("Saldo retirado.");
                            saldo -= retiro;
                        }
                    }
                    else if (prg == 3)
                    {
                        Console.WriteLine(saldo);
                    }
                    op = salir(op);

                }
                //3. Crear un programa que simule un juego de adivinanza de números, en el que el usuario debe adivinar un número generado aleatoriamente por el programa.
                while (op == 3)
                {
                    Console.Clear();
                    int ranNum = rd.Next(0, 100);
                    for (int i = 5; i > 0; i--)
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Tiene " + i + " intentos. Ingrese un numero entre 0 y 100:");
                        int num = Convert.ToInt32(Console.ReadLine());

                        if (ranNum == num)
                        {
                            Console.WriteLine("Felicidades, usted ganó");
                            op = salir(op);
                        }
                    }
                    Console.WriteLine("Que lastima, ahora mismo estamos borrando el system32");
                    op = salir(op);
                }
                //4. Crear un programa que genere una lista de números primos hasta un número ingresado por el usuario.
                while (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Indique hasta donde quiere calcular numeros primos");
                    int limit = Convert.ToInt32(Console.ReadLine());
                    for (int i = 2; i <= limit; i++)
                    {
                        int cont = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                cont++;
                            }
                        }
                        if (cont == 2)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.ReadKey();
                    op = salir(op);
                }
                //5. Crear un programa que simule un juego de ahorcado, en el que el usuario debe adivinar una palabra oculta letra por letra.
                while (op == 5)
                {
                    Console.Clear();
                    string[] palabras = { "hola", "chau", "programacion", "computadora", "teclado" };
                    Random random = new Random();
                    string palabra = palabras[random.Next(palabras.Length)];
                    char[] letras = palabra.ToCharArray();
                    char[] adivinadas = new char[letras.Length];
                    for (int i = 0; i < adivinadas.Length; i++)
                    {
                        adivinadas[i] = '_';
                    }
                    int intentos = 0;
                    while (intentos < 6)
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine(adivinadas);
                        Console.Write("Ingresa una letra: ");
                        char letra = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        bool acierto = false;
                        for (int i = 0; i < letras.Length; i++)
                        {
                            if (letras[i] == letra)
                            {
                                adivinadas[i] = letra;
                                acierto = true;
                            }
                        }
                        if (!acierto)
                        {
                            intentos++;
                            Console.WriteLine("Fallaste. Te quedan " + (6 - intentos) + " intentos.");
                            Console.Clear();
                        }
                        if (adivinadas.SequenceEqual(letras))
                        {
                            Console.WriteLine("¡Ganaste!");
                            return;
                        }
                    }
                    Console.WriteLine("Perdiste. La palabra era " + palabra);
                    op = salir(op);
                    Console.Clear();
                }
                //6. Crear un programa que permita al usuario ingresar una lista de tareas y organizarlas por orden de prioridad.
                while (op == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Cuantas tareas tiene?");
                    int cant = Convert.ToInt32(Console.ReadLine());
                    List<int> prioridad = new List<int>();
                    List<string> tareas = new List<string>();
                    for (int i = 0; i < cant; i++)
                    {
                        Console.WriteLine("Ingrese la tarea");
                        tareas.Add(Console.ReadLine());
                        Console.WriteLine("Ingrese su prioridad");
                        prioridad.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    int k;
                    string a;
                    for (int i = 1; i < prioridad.Count; i++)
                    {
                        for (int j = prioridad.Count - 1; j >= i; j--)
                        {
                            if (prioridad[j - 1] > prioridad[j])
                            {
                                k = prioridad[j - 1];
                                prioridad[j - 1] = prioridad[j];
                                prioridad[j] = k;
                                a = tareas[j - 1];
                                tareas[j - 1] = tareas[j];
                                tareas[j] = a;
                            }
                        }
                    }
                    for (int i = 0; i < tareas.Count; i++)
                    {
                        Console.WriteLine(tareas[i] + " en prioridad " + prioridad[i]);
                    }
                    op = salir(op);
                }
                //7. Crear un programa que permita al usuario ingresar una serie de números y determine cuál es el número más grande y cuál es el número más pequeño.
                while (op == 7)
                {
                    Console.Clear();
                    List<int> list = new List<int>();
                    Console.WriteLine("Cuantos numeros va a ingresar?");
                    int cant = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese sus numeros:");
                    for (int i = 0; i < cant; i++)
                    {
                        int num = Convert.ToInt32(Console.ReadLine());
                        list.Add(num);
                    }
                    Console.WriteLine("Valor maximo " + list.Max());
                    Console.WriteLine("Valor minimo " + list.Min());
                    op = salir(op);
                }
                //8.Crear un programa que simule una biblioteca, permitiendo al usuario buscar y prestar libros, y llevando un registro de los préstamos y devoluciones.
                while (op == 8)
                {
                    Console.Clear();
                    Console.WriteLine("este lo hice en un archivo a parte porque era muy largo");
                    op = salir(op);
                    Console.Clear();
                }
                //9. Crear un programa que permita al usuario calcular la distancia entre dos puntos en un plano cartesiano.
                while (op == 9)
                {
                    Console.Clear();
                    double x1, y1, x2, y2;
                    double D;
                    string si = "s";
                    while (si == "s")
                    {

                        Console.WriteLine("Ingresar coordenada del Punto 1");
                        x1 = Convert.ToDouble(Console.ReadLine());
                        y1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Coordenada: (" + x1 + "," + y1 + ")");

                        Console.WriteLine("Ingresar coordenada del Punto 2");
                        x2 = Convert.ToDouble(Console.ReadLine());
                        y2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Coordenada: (" + x2 + "," + y2 + ")");

                        D = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

                        Console.WriteLine("La distancia del punto 1 (" + x1 + "," + y1 + ") y el punto 2 (" + x2 + "," + y2 + ") es: " + D);

                        si = "n";
                        op = salir(op);
                        Console.Clear();
                    }
                }
                //10. Crear un programa que permita al usuario convertir una cantidad de una unidad de medida a otra, por ejemplo, de metros a pies.
                while (op == 10)
                {
                    Console.Clear();
                    Console.WriteLine("¿Que conversion quiere realizar?");
                    Console.WriteLine("1. Metros a pies");
                    Console.WriteLine("2. Pies a metros");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion == 1)
                    {
                        Console.WriteLine("Ingrese los metros");
                        double mts = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(mts + " equivalen a " + (mts * 3.28084) + "fts");
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("Ingrese los pies");
                        double fts = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(fts + " equivalen a " + (fts / 3.28084) + "mts");
                    }
                    op = salir(op);
                    Console.Clear();
                }
            }
        }
    }
}