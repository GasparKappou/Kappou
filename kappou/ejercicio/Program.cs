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
                Console.WriteLine("Cualquier cosa pibe, andate a usar otro menu");
                Environment.Exit(0);
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
                    if(listaPersonas.Count == 0)
                    {
                        Console.WriteLine("No hay personas para modificar");
                        Console.ReadKey();
                        break;
                    }

                    Console.Write("Ingrese el dni de la persona a modificar: ");
                    string confirma = Console.ReadLine();

                    Console.WriteLine("Ingrese que quiere modificar, dni o nombre: ");
                    string modif = Console.ReadLine().ToLower();


                    for (int i = 0; i < 5; i++)
                    {
                        if(listaPersonas[i].dni == confirma)
                        {
                            if(modif == "nombre")
                            {
                                Console.Write("Ingrese el nuevo nombre: ");
                                listaPersonas[i].name = Console.ReadLine();
                                break;
                            }
                            else if(modif == "dni")
                            {
                                Console.Write("Ingrese el nuevo dni: ");
                                listaPersonas[i].dni = Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Cualquier cosa pusiste.");
                                break;
                            }
                        }
                        Console.WriteLine("No se encontró.");
                    }

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

                    for (int i = 0; i < listaPersonas.Count; i++)
                        if (listaPersonas[i].dni == elimina)
                        {
                            listaPersonas.RemoveAt(i);
                            break;
                        }
                    
                    break;
                case 4:
                    Console.Clear();
                    for(int i = 0; i < listaPersonas.Count; i++)
                    {
                        Console.WriteLine(listaPersonas[i].name + " " + listaPersonas[i].dni);
                    }
                    Console.ReadLine();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }

            /*string dni;

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
            Console.ReadKey();*/
        }
    }
}