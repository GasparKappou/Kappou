using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Persona
{
    public string name;
    public string dni;

    //Constructor por defaul - Mismo nombre que la clase
    public Persona()
    {
    }


    public Persona(string name, string dni)
    {
        this.name = name;
        this.dni = dni;
    }
    //Mas de un constructor = sobrecarga de constructores

    //Metodo para mostrar los datos del objeto
    public string mostrarTodo()
    {
        return name + ", " + dni;
    }

    static public string buscarDni(List<Persona> pers, string dni)
    {
        for (int i = 0; i < pers.Count; i++)
        {
            if (pers[i].dni == dni)
                return pers[i].name;
        }
        return null;
        
    }

    static public string borrarElemento(List<Persona> pers, string dni)
    {
        for (int i = 0; i < pers.Count; i++)
        {
            if (pers[i].dni == dni)
            {
                pers.RemoveAt(i);
            }
        }
        return null;

    }

}

internal class Program
{
    static List<Persona> listaPersonas = new List<Persona>();

    static void Main(string[] args)
    {
        
        listaPersonas.Add(new Persona("Sergio", "aj1234"));
        listaPersonas.Add(new Persona("Pablo", "aj2345"));
        listaPersonas.Add(new Persona("Florencia", "uj3456"));
        
        

        string dni;
        
        Console.Write("Ingrese un dni para buscar: ");
        dni = Console.ReadLine();
        string personaBuscada = Persona.buscarDni(listaPersonas, dni);
        if (personaBuscada != null)
        {
            Console.WriteLine("Se encontro, presione una tecla para continuar");
            Console.WriteLine(personaBuscada);
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("No se encontro, presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        int cantPers = listaPersonas.Count; 
        Console.Write("Ingrese un dni a buscar para luego borrar: ");
        dni = Console.ReadLine();
        Persona.borrarElemento(listaPersonas, dni);
        
        if (cantPers < listaPersonas.Count)
        {
            Console.WriteLine("Se borro, estos son los usuarios restantes");
        }
        for (int i = 0; i < listaPersonas.Count; i++)
        {
            Console.WriteLine(listaPersonas[i].mostrarTodo());
        }
        Console.ReadKey();
    }
}