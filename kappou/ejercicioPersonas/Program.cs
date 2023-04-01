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
    static public string mostrarTodo(List<Persona> listaPersonas)
    {
        for (int i = 0; i < listaPersonas.Count; i++)
        {
            Console.WriteLine(listaPersonas[i].name + ", " + listaPersonas[i].dni);
        }
        return null;
    }

    static public string buscarDni(List<Persona> pers, string dni, string modif)
    {
        for (int i = 0; i < pers.Count; i++)
        {
            if (pers[i].dni == dni)
            {
                if (modif == "nombre")
                {
                    return pers[i].name = Console.ReadLine();
                }
                else if (modif == "dni")
                {
                    return pers[i].dni = Console.ReadLine();
                }
            }
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
        while (true)
        {
            Console.Clear();

            Console.WriteLine("1 Nuevo");
            Console.WriteLine("2 Modificar");
            Console.WriteLine("3 Eliminar");
            Console.WriteLine("4 Listar");
            Console.WriteLine("5 Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Cualquier cosa pibe, pusiste cualquier numero.");
            }

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Ingrese la cantidad de personas que quiere agregar: ");
                    int vueltas = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= vueltas; i++)
                    {
                        Console.Write("Ingrese el nombre de la persona numero " + i + ": ");
                        string nombrePer = Console.ReadLine();

                        Console.Write("Ingrese el DNI de la persona numero " + i + ": ");
                        string dniPer = Console.ReadLine();

                        listaPersonas.Add(new Persona(nombrePer, dniPer));
                    }
                    break;
                case 2:
                    Console.Clear();
                    if (listaPersonas.Count == 0)
                    {
                        Console.WriteLine("No hay personas para modificar");
                        Console.ReadKey();
                        break;
                    }

                    Console.Write("Ingrese el dni de la persona a modificar: ");
                    string confirma = Console.ReadLine();

                    Console.WriteLine("Ingrese que quiere modificar, dni o nombre y luego el nuevo valor: ");
                    string modif = Console.ReadLine().ToLower();
                    
                    Persona.buscarDni(listaPersonas, confirma, modif);
                    break;
                case 3:
                    Console.Clear();
                    if (listaPersonas.Count == 0)
                    {
                        Console.WriteLine("No hay personas para eliminar");
                        Console.ReadKey();
                        break;
                    }

                    Console.Write("Ingrese el dni de la persona a eliminar: ");
                    string elimina = Console.ReadLine();

                    Persona.borrarElemento(listaPersonas, elimina);
                    
                    break;
                case 4:
                    Console.Clear();
                    if (listaPersonas.Count == 0)
                    {
                        Console.WriteLine("No hay personas para mostrar");
                        Console.ReadKey();
                        break;
                    }
                    Persona.mostrarTodo(listaPersonas);
                    
                    Console.ReadLine();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}