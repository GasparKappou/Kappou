using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
16) Nos piden realizar una agenda telefónica de contactos.
Un contacto está definido por un nombre y un teléfono (No es necesario de validar). Un contacto es igual a otro cuando sus nombres son iguales.

Una agenda de contactos está formada por un conjunto de contactos (Piensa en qué tipo puede ser)

Se podrá crear de dos formas, indicando nosotros el tamaño o con un tamaño por defecto (10)

Los métodos de la agenda serán los siguientes:
aniadirContacto(Contacto c): Añade un contacto a la agenda, sino se pueden meter más a la agenda se indicará por pantalla. No se pueden meter contactos que existan, es decir, no podemos duplicar nombres, aunque tengan distinto teléfono.

existeContacto(Conctacto c): indica si el contacto pasado existe o no.

listarContactos(): Lista toda la agenda

buscaContacto(String nombre): busca un contacto por su nombre y muestra su teléfono.

eliminarContacto(Contacto c): elimina el contacto de la agenda, indica si se ha eliminado o no por pantalla

agendaLlena(): indica si la agenda está llena.

huecosLibres(): indica cuántos contactos más podemos meter.

Crea un menú con opciones por consola para probar todas estas funcionalidades.
*/

namespace ejerciciosObligatorios16
{
	class Contacto
	{
		public string nombre;
		public int telefono;

		public Contacto(string nombre, int telefono)
		{
			this.nombre = nombre;
			this.telefono = telefono;
		}
	}
	class Agenda
	{
		//aniadirContacto(Contacto c): Añade un contacto a la agenda, sino se pueden meter más a la agenda se indicará por pantalla.
		//No se pueden meter contactos que existan, es decir, no podemos duplicar nombres, aunque tengan distinto teléfono.
		public static void AddContact(List<Contacto> agenda, Random rnd, string[] nombres)
		{
			string nom = nombres[rnd.Next(0, nombres.Length)];
			if (agenda.Exists(a => a.nombre == nom) && agenda.Count() <= 20)
				Console.WriteLine("Nombre ya usado");
			else if (!agenda.Exists(a => a.nombre == nom) && agenda.Count() <= 20)
                agenda.Add(new Contacto(nom, rnd.Next(1000, 99999)));
            else if (agenda.Count == 20)
				Console.WriteLine("No hay mas espacio");
		}
		//existeContacto(Conctacto c): indica si el contacto pasado existe o no.

		public static bool ExistContact(List<Contacto> agenda)
		{
			string nom = Console.ReadLine();
			return agenda.Exists(a => a.nombre == nom);
		}
		//listarContactos(): Lista toda la agenda

		public static void ShowContact(List<Contacto> agenda)
		{
			foreach(Contacto contacto in agenda)
			{
				Console.WriteLine("Nombre: " + contacto.nombre);
				Console.WriteLine("Telefono: " + contacto.telefono);
				Console.WriteLine("----------------------------------------");
			}
		}
		//buscaContacto(String nombre): busca un contacto por su nombre y muestra su teléfono.

		public static void FindContact(List<Contacto> agenda)
		{
			string nom = Console.ReadLine();
			if (agenda.Exists(a => a.nombre == nom))
				Console.WriteLine(agenda.Find(a => a.nombre == nom).telefono);
			else
				Console.WriteLine("No se encontro");
		}
		//eliminarContacto(Contacto c): elimina el contacto de la agenda, indica si se ha eliminado o no por pantalla

		public static void DelContact(List<Contacto> agenda)
		{
			string nom = Console.ReadLine();
			if (agenda.Exists(a => a.nombre == nom))
				agenda.Remove(agenda.Find(a => a.nombre == nom));
			else
				Console.WriteLine("No se encontro");
		}
		//agendaLlena(): indica si la agenda está llena.

		public static bool Full(List<Contacto> agenda)
		{
			if (agenda.Count() == 20)
				return true;
			else 
				return false;
		}
		//huecosLibres() : indica cuántos contactos más podemos meter.

		public static void Free(List<Contacto> agenda)
		{
			Console.WriteLine(20 - agenda.Count());
		}

	}
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Contacto> agenda = new List<Contacto>();
			Random rnd = new Random();
			string[] nombres = { "Magda", "Sofia", "Angie", "Luis", "Gaspar", "Tobias", "Azul", "Marina", "Tamara", "Folco",
								 "Leandro", "Claudia", "Marcos", "Evelyn", "Gabriel", "Facundo", "Luca", "Mike", "Aaron", "Felipe" };
			for (int i = 0; i < 10; i++)
				Agenda.AddContact(agenda, rnd, nombres);

			while (true)
			{
				Console.Clear();
				Console.WriteLine("1. Agregar contacto\n2. Preguntar por contacto existente\n" +
								  "3. Mostrar contactos\n4. Buscar contacto\n" +
								  "5. Eliminar\n6. Agenda llena?\n7. Cuantos contactos me faltan?");
				int op = Convert.ToInt32(Console.ReadLine());
				switch (op)
				{
					case 1:
						Agenda.AddContact(agenda, rnd, nombres);
						break;
					case 2:
						Console.WriteLine(Agenda.ExistContact(agenda));
						break;
					case 3:
						Agenda.ShowContact(agenda);
						break;
					case 4:
						Agenda.FindContact(agenda);
						break;
					case 5:
						Agenda.DelContact(agenda);
						break;
					case 6:
						Console.WriteLine(Agenda.Full(agenda)? "Esta llena" : "Faltan contactos");
						break;
					case 7:
						Agenda.Free(agenda);
						break;
				}
				Console.ReadKey();
			}

		}
	}
}
