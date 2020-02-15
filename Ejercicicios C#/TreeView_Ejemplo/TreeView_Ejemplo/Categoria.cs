using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView_Ejemplo
{
    class Categoria
    {
        int id_Categoria;
        string nombre_Categoria;
        
        public int Id_Categoria
        {
            get { return id_Categoria; }
            set { id_Categoria = value; }
        }
        public string Nombre_Categoria
        {
            get { return nombre_Categoria; }
            set { nombre_Categoria = value; }
        }

        public Categoria(int ini_id_Categoria, string ini_nombre_Categoria)
        {
            id_Categoria = ini_id_Categoria;
            nombre_Categoria = ini_nombre_Categoria;
        }

        public override string ToString()
        {
            return nombre_Categoria;
        }
    }
}
