using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_Directorio
{
    class Directorio
    {
        int id;
        string nombre;
        List<Directorio> directorios;

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
        internal List<Directorio> Directorios
        {
            get { return directorios; }
            set { directorios = value; }
        }

        public Directorio()
        {
            this.id = 0;
            this.nombre = "";
            this.directorios = new List<Directorio>();
        }
        public Directorio(int id_ini, string nombre_ini)
        {
            this.id = id_ini;
            this.nombre = nombre_ini;
        }
        public Directorio(int id_ini, string nombre_ini, List<Directorio> directorios_ini)
        {
            this.id = id_ini;
            this.nombre = nombre_ini;
            this.directorios = directorios_ini;
        }

        public override string ToString()
        {
            return id + "-" + nombre;
        }
    }
}