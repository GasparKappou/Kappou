using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

//matematica = 0, filosofia = 1, fisica = 2

namespace ejerciciosObligatorios8
{
    class Caracteristicas
    {
        public string nombre;
        public int edad;
        public bool sexo;
        public bool asiste;
        public int aula;
    }
    class Profesor : Caracteristicas
    {
        public int materia;

        public Profesor(string nombre, int edad, bool sexo, bool asiste, int materia)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.asiste = asiste;
            this.materia = materia;
        }
    }
    class Alumno : Caracteristicas
    {
        public int calificacion;
        public Alumno(string nombre, int edad, bool sexo, bool asiste, int calificacion, int aula)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.asiste = asiste;
            this.calificacion = calificacion;
            this.aula = aula;
        }
    }
    class Aula
    {
        public int materia;

        public Aula(int materia)
        {
            this.materia = materia;
        }
    }
    internal class Program
    {
        static bool aulaValida(Profesor[] profes, Alumno[] alumnos, int idAula, Aula aula)
        {
            int cantAluAsis = 0;
            bool hayProf = false;
            foreach (Alumno alumno in alumnos)
                if (alumno.asiste && alumno.aula == idAula)
                    cantAluAsis++;

            foreach (Profesor prof in profes)
                if (prof.asiste && prof.materia == aula.materia)
                    hayProf = true;

            if (hayProf == true && cantAluAsis < 30)
            {
                return true;
            }
            return false;

        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool[] usarAula = new bool[5];
            Random rnd = new Random();
            Aula[] aulas = new Aula[5];
            string[] nombres = { "Tobias", "Gaspar", "Sofia", "Angie", "Luis", "Claudia" };
            aulas[0] = new Aula(rnd.Next(0, 3));
            aulas[1] = new Aula(rnd.Next(0, 3));
            aulas[2] = new Aula(rnd.Next(0, 3));
            aulas[3] = new Aula(rnd.Next(0, 3));
            aulas[4] = new Aula(rnd.Next(0, 3));

            Alumno[] alumnos = new Alumno[150];
            Profesor[] profes = new Profesor[5];

            for (int i = 0; i < 150; i++)
            {
                alumnos[i] = new Alumno(nombres[rnd.Next(0, nombres.Length)], rnd.Next(0, 30), Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)), rnd.Next(0, 11), rnd.Next(0, 6));
            }
            for (int i = 0; i < 5; i++)
            {
                profes[i] = new Profesor(nombres[rnd.Next(0, nombres.Length)], rnd.Next(25, 66), Convert.ToBoolean(rnd.Next(0, 2)), Convert.ToBoolean(rnd.Next(0, 2)), rnd.Next(0, 4));
            }
            for (int i = 0; i < aulas.Length; i++)
            {
                //Console.WriteLine("aula" + i);
                int countMasc = 0;
                int countFeme = 0;
                if (aulaValida(profes, alumnos, i, aulas[i]))
                {
                    //Console.WriteLine("aulaValida");
                    for (int j = 0; j < alumnos.Length; j++)
                    {
                        //Console.WriteLine("\tpruebaAlu" + j + " " + alumnos[j].calificacion + " " + alumnos[j].aula + " " + alumnos[j].asiste);
                        if (alumnos[j].calificacion >= 6 && alumnos[j].aula == i && alumnos[j].sexo && alumnos[j].asiste)
                        {
                            //Console.WriteLine("debugFem");
                            countFeme++;
                        }
                        else if (alumnos[j].calificacion >= 6 && alumnos[j].aula == i && alumnos[j].asiste)
                        {
                            //Console.WriteLine("debugMas");
                            countMasc++;
                        }
                    }
                    Console.WriteLine("En el aula " + i + " hay " + countMasc + " alumnos y " + countFeme + " alumnas aprobadas.");
                }
                else
                {
                    Console.WriteLine("No hay data del aula " + i);
                }
            }
            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
