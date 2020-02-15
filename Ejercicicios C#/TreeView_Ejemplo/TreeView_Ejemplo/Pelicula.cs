using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_Ejemplo
{
    class Pelicula
    {
        int id;
        string nombre;
        Categoria categorias;
        
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
        internal Categoria Categorias
        {
            get { return categorias; }
            set { categorias = value; }
        }
        
        public Pelicula(int ini_id, string ini_nombre, Categoria ini_nombreCategoria)
        {
            id = ini_id;
            nombre = ini_nombre;
            categorias = ini_nombreCategoria;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
