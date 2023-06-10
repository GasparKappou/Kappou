using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Nos piden que gestionemos una serie de productos.
Los productos tienen los siguientes atributos:
    Nombre
    Precio
Tenemos dos tipos de productos:
    Perecedero: tiene un atributo llamado días a caducar
    No perecedero: tiene un atributo llamado tipo
Crea sus constructores, getters, setters y toString.
Tendremos una función
    Calcular, que según cada clase hará una cosa u otra, a esta función le pasaremos un número siendo la cantidad de productos
En Producto, simplemente sería multiplicar el precio por la cantidad de productos pasados.
En Perecedero, aparte de lo que hace producto, el precio se reducirá según los días a caducar:
    Si le queda 1 día para caducar, se reducirá 4 veces el precio final.
    Si le quedan 2 días para caducar, se reducirá 3 veces el precio final.
    Si le quedan 3 días para caducar, se reducirá a la mitad de su precio final.
En No Perecedero, hace lo mismo que en producto
    Crea una clase ejecutable y crea un array de productos y muestra el precio total de vender 5 productos de cada uno.
    Crea tú mismo los elementos del array.
*/
namespace ejerciciosObligatorios14
{
    class Producto
    {
        public string nom;
        public int precio;
        public Producto(string nom, int precio)
        {
            this.nom = nom;
            this.precio = precio;
        }

        public static void Calcular(List<Producto> productos)
        {
            int precioTot = 0;
            for (int i = 0; i < productos.Count; i++)
            {
                precioTot += productos[i].precio;
            }
        }
    }
    class Perecedero : Producto
    {
        public int diasCaducar;
        
        public Perecedero(string nom, int precio, int dias) : base(nom, precio)
        {
            this.nom = nom;
            this.precio = precio;
            this.diasCaducar = dias;
        }

        public static void Calcular(List<Perecedero> pPerec)
        {

        }
    }
    class noPerecedero : Producto
    {
        public int tipo;

        public noPerecedero(string nom, int precio, int tipo) : base(nom, precio)
        {
            this.nom = nom;
            this.precio = precio;
            this.tipo = tipo;
        }

        public static void Calcular(List<Perecedero> pNoPerec)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
