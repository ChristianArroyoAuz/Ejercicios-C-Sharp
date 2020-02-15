using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ConsoleApplication2
{
    class Program
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int ID { get; set; }
            public List<int> Puntajes;

        }

        // Create a data source by using a collection initializer.
        static List<Estudiante> estudiantes = new List<Estudiante>
        {
           new Estudiante {Nombre="Lucía", Apellido="Guaña", ID=111, Puntajes= new List<int> {97, 92, 81, 60}},
           new Estudiante {Nombre="Violeta", Apellido="O’Donnell", ID=112, Puntajes= new List<int> {75, 84, 91, 39}},
           new Estudiante {Nombre="Steven", Apellido="Torres", ID=113, Puntajes= new List<int> {88, 94, 65, 91}},
           new Estudiante {Nombre="César", Apellido="García", ID=114, Puntajes= new List<int> {97, 89, 85, 82}},
           new Estudiante {Nombre="Dévora", Apellido="García", ID=115, Puntajes= new List<int> {35, 72, 91, 70}},
           new Estudiante {Nombre="Fabricio", Apellido="Fuentes", ID=116, Puntajes= new List<int> {99, 86, 90, 94}},
           new Estudiante {Nombre="Hanna", Apellido="Gutiérrez", ID=117, Puntajes= new List<int> {93, 92, 80, 87}},
           new Estudiante {Nombre="Hugo", Apellido="García", ID=118, Puntajes= new List<int> {92, 90, 83, 78}},
           new Estudiante {Nombre="Yadira", Apellido="Túqueres", ID=119, Puntajes= new List<int> {68, 79, 88, 92}},
           new Estudiante {Nombre="Teodora", Apellido="Adams", ID=120, Puntajes= new List<int> {99, 82, 81, 79}},
           new Estudiante {Nombre="Eugenia", Apellido="Jiménez", ID=121, Puntajes= new List<int> {96, 85, 91, 60}},
           new Estudiante {Nombre="Michael", Apellido="Túqueres", ID=122, Puntajes= new List<int> {94, 92, 91, 91} }
        };
        static void Main(string[] args)
        {
            //Creación de la consulta1.
            //La primera línea podría estar escrita como "var studentQuery ="
            IEnumerable<Estudiante> consultaEstudiante4 =
                from Estudiante in estudiantes
                where Estudiante.Puntajes[0] > 90
                select Estudiante;

            //Ejecución de la consulta1.
            foreach (Estudiante student in consultaEstudiante4)
            {
                Console.WriteLine("{0}, {1}", student.Apellido, student.Nombre);
            }
            Console.ReadLine();

            //Creación de la consulta2.
            IEnumerable<string> consultaEstudiante0 =
               from estudiante in estudiantes
               where estudiante.Apellido == "García"
               select estudiante.Nombre;

            //Ejecución de la consulta2.
            Console.WriteLine("Los estudiantes de apellido García en la clase son:");
            foreach (string s in consultaEstudiante0)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

            var consultaEstudiante6 =
               from estudiante in estudiantes
               where estudiante.Apellido == "García"
               select estudiante.Nombre;

            //Ejecución de la consulta2.
            Console.WriteLine("Los estudiantes de apellido García en la clase son:");
            foreach (string s in consultaEstudiante6)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

            //Ejercicio en CLASE:
            //Consulta #3:
            //1. Escriba la sentencia de modo var


            /*var studentQuery4 =
                from Estudiante in estudiantes
                group Estudiante by Estudiante.Apellido[0] into GrupoEstudiantes
                orderby GrupoEstudiantes.Key
                select GrupoEstudiantes;

            foreach (var GrupoEstudiantes in studentQuery4)
            {
                Console.WriteLine(GrupoEstudiantes.Key);
                foreach (var estudiante in GrupoEstudiantes)
                {
                    Console.WriteLine("   {0}, {1}",
                        estudiante.Apellido, estudiante.Nombre);
                }
                Console.ReadLine();
            }*/

            //Ejercicio en CLASE:
            //Consulta #3:
            //1. Escriba la sentencia de modo var
            /*var studentQuery4 =
                from Estudiante in estudiantes
                group Estudiante by Estudiante.Apellido[0] into GrupoEstudiantes
                orderby GrupoEstudiantes.Key
                select GrupoEstudiantes;

            foreach (var GrupoEstudiantes in studentQuery4)
            {
                Console.WriteLine(GrupoEstudiantes.Key);
                foreach (var estudiante in GrupoEstudiantes)
                {
                    Console.WriteLine("   {0}, {1}",
                        estudiante.Apellido, estudiante.Nombre);
                }
                Console.ReadLine();
            }*/




            //Actualizar
            var query =
                from estudiante in estudiantes
                where estudiante.ID == 111
                select estudiante;


            foreach (Estudiante estudiante in query)
            {
                estudiante.Nombre = "Martha";
                estudiante.Apellido = "López";
                estudiante.Puntajes = new List<int> { 99, 82, 81, 79 };
            }

            //Actualizar datos
            var query2 =
                from estudiante in estudiantes
                where estudiante.ID == 111
                select estudiante;

            //Ejecución de la consulta2.
            Console.WriteLine("El nuevo estudiante se llamará:");
            foreach (Estudiante estudiante in query2)
            {
                Console.WriteLine("   {0}, {1}",
                        estudiante.Nombre, estudiante.Apellido);
            }
            Console.ReadLine();

            //Consulta #4:
            //2. Escriba la consulta que despliegue los nombres de los estudianes cuyo
            //puntaje sea mayor a 80 y además que se pueda ordenar en orden alfabético
            //de los nombres.

            //Creación de la consulta5.
            var consultaEstudiante9 =
                from Estudiante in estudiantes
                where Estudiante.Puntajes[0
                ] > 80
                group Estudiante by Estudiante.Nombre[0] into GrupoEstudiantes1
                orderby GrupoEstudiantes1.Key
                select GrupoEstudiantes1;


            foreach (var GrupoEstudiantes1 in consultaEstudiante9)
            {
                Console.WriteLine(GrupoEstudiantes1.Key);
                foreach (var estudiante in GrupoEstudiantes1)
                {
                    Console.WriteLine("   {0}, {1}",
                        estudiante.Nombre, estudiante.Apellido);
                }
                Console.ReadLine();
            }
        }


    }
}