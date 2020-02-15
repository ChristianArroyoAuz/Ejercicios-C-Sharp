using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace User_Activo_Inactivo
{
    class Pais
    {
        string pais;

        public string Paises
        {
            get { return pais; }
            set { pais = value; }
        }

        public Pais(string pais) 
        {
            this.pais = pais;
        }


        public override string ToString()
        {
            return this.pais;
        }
    }
}
