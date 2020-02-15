using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Contextual
{
    class Usuario
    {
        string nombre;
        string intereses;
        string sexo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Intereses
        {
            get { return intereses; }
            set { intereses = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Usuario (string nombre, string intereses, string sexo)
        {
            this.nombre = nombre;
            this.intereses = intereses;
            this.sexo = sexo;
        }

        public override string ToString()
        {
            return nombre + "    " + intereses + "    " + sexo;
        }
    }
}
