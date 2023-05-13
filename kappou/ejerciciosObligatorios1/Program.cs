using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosObligatorios1
{
    class Cuenta
    {
        public string titular;
        public double cant;
        
        public Cuenta(string titular, double cant)
        {
            this.titular = titular;
            this.cant = cant;
        }
    }

    internal class Program
    {
        static public void ingresar(List<Cuenta> cuentas, string cuentaId, double cant)
        {
            if (cant > 0)
            for(int i = 0; i < cuentas.Count; i++)
            {
                if (cuentas[i].titular.ToLower() == cuentaId)
                {
                    cuentas[i].cant += cant;
                }
            }
            else
            {
                Console.WriteLine("Cualquier cosa pusiste pibe.");
            }
        }
        static public void retirar(List<Cuenta> cuentas, string cuentaId, double cant)
        {
            for (int i = 0; i < cuentas.Count; i++)
            {
                if (cuentas[i].titular.ToLower() == cuentaId && (cuentas[i].cant-cant) > 0)
                {
                    cuentas[i].cant -= cant;
                }
            }
        }
        
        static void Main(string[] args)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            cuentas.Add(new Cuenta("Tobias", 420.69));
            cuentas.Add(new Cuenta("Gaspar", 420.69));
            cuentas.Add(new Cuenta("Angie", 420.69));
            cuentas.Add(new Cuenta("Sofia", 420.69));
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Que quierer hacer?\n1.Ingresar cantidad\n2.Retirar cantidad\n3.Salir");
                int op = Convert.ToInt32(Console.ReadLine());
                string cuenta;
                double cant;
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre de cuenta");
                        cuenta = Console.ReadLine().ToLower();
                        Console.WriteLine("Ingrese la cantidad a ingresar");
                        cant = Convert.ToDouble(Console.ReadLine());
                        ingresar(cuentas, cuenta, cant);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre de cuenta");
                        cuenta = Console.ReadLine().ToLower();
                        Console.WriteLine("Ingrese la cantidad a retirar");
                        cant = Convert.ToDouble(Console.ReadLine());
                        retirar(cuentas, cuenta, cant);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                for(int i = 0; i < cuentas.Count; i++)
                {
                    Console.WriteLine(cuentas[i].titular + " " + cuentas[i].cant);
                }
                Console.ReadKey();
            }
        }
    }
}
