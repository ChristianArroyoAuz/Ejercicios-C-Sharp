using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Estudiante
    {
        int id;
        string nombre;
        string apellido;
        string carrera;
        string password;

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
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Estudiante()
        { }

        public Estudiante(int id, string nombre, string apellido, string carrera, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.carrera = carrera;
            this.password = password;
        }
    }
}
