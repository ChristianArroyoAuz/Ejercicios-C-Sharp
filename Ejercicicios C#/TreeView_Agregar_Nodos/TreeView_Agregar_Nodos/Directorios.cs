using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_Agregar_Nodos
{
    class Directorios
    {
        string nombre;
        int id;
        List<Directorios> directoriosListas;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        internal List<Directorios> DirectoriosListas
        {
            get { return directoriosListas; }
            set { directoriosListas = value; }
        }

        public Directorios(int id, string nombre, List<Directorios> directoriosListas = null)
        {
            this.nombre = nombre;
            this.id = id;
            this.directoriosListas = directoriosListas;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}