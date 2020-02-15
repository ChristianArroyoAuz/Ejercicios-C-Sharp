using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Genealogico
{
    class Persona
    {
        int id;
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        List<Persona> descendencia;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        internal List<Persona> Descendencia
        {
            get { return descendencia; }
            set { descendencia = value; }
        }

        public Persona()
        {
            id = 0;
            nombre = "raiz";
        }

        public Persona(int ini_id, string ini_nombre, string ini_apellido, DateTime ini_fechaNacimiento, List<Persona> ini_descendencia)
        {
            id = ini_id;
            nombre = ini_nombre;
            apellido = ini_apellido;
            fechaNacimiento = ini_fechaNacimiento;
            descendencia = ini_descendencia;
        }

        public override string ToString()
        {
            return nombre + " " + "(" + fechaNacimiento.Year + ")";
        }
    }
}
