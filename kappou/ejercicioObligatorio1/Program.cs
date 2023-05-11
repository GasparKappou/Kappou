using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioObligatorio1
{
    class Cuenta
    {
        private string titular;
        private double cant;
        
        public Cuenta(string titular, double cant)
        {
            this.titular = titular;
            this.cant = cant;
        }
    }

    internal class Program
    {
        public void ingresar(double cant)
        {
            
        }
        public void retirar(string titular, double cant)
        {
            new Cuenta(titular, cant);
        }
        
        static void Main(string[] args)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            cuentas.Add(new Cuenta("Tobias", 420.69));
            cuentas.Add(new Cuenta("Gaspar", 420.69));
            cuentas.Add(new Cuenta("Angie", 420.69));
            cuentas.Add(new Cuenta("Sofia", 420.69));
        }
    }
}
