using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListView
{
    public   class Archivo
    {
       public  int id;
       public string nombre;
       List<Archivo> lsitaArc;
       char subindice;

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

        public List<Archivo> LsitaArc
        {
            get { return lsitaArc; }
            set { lsitaArc = value; }
        }

        public char Subindice
        {
            get { return subindice; }
            set { subindice = value; }
        }

        public Archivo(int _id, string _nombre, List<Archivo> _lista, char _subindice)
        {
            id = _id;
            nombre = _nombre;
            lsitaArc = _lista;
            subindice = _subindice;
        }
    }
}