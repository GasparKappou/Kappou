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
}

internal class Program
{
    static List<Persona> personas = new List<Persona>();

    static Persona buscarDni(string dni)
    {
        for (int i = 0; i < personas.Count; i++)
        {
            if (personas[i].dni == dni)
                return personas[i];
        }
        return null;
    }

    static void Main(string[] args)
    {
        Persona persona1;
        /*
        persona1 == AB ("pablo", 10)
        list == [0] => FF("sergio", 14)
                [1] => AB("pablo", 10)
        

        
        for (int i = 0; i < personas.Count; i++)
        {
            Console.WriteLine(personas[i].dni);
        }
        Console.ReadLine();
        */
        personas.Add(new Persona("Sergio", "aj1234"));
        personas.Add(new Persona("Pablo", "aj2345"));
        personas.Add(new Persona("Florencia", "uj3456"));

        string dni;

        Console.Write("Ingrese un dni para buscar: ");
        dni = Console.ReadLine();
        Persona personaBuscada = buscarDni(dni);
        if (personaBuscada != null)
        {
            Console.WriteLine("Se encontro");
            Console.WriteLine(personaBuscada.name);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("No se encontro");
            Console.ReadKey();
        }

        Console.Write("Ingrese un dni a buscar para luego borrar: ");
        dni = Console.ReadLine();
        persona1 = buscarDni(dni);
        if (persona1 != null)
        {
            personas.Remove(persona1);
        }

        for (int i = 0; i < personas.Count; i++)
        {
            Console.WriteLine(personas[i].mostrarTodo());
        }
        Console.ReadKey();
        
    }
}