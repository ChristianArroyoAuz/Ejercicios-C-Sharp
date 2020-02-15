using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Administracion_De_Autos
{
    class Auto
    {
        int id;
        string nombre;
        string modelo;
        string marca;

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
        
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public Auto(int id, string nombre, string modelo, string marca)
        {
            this.id = id;
            this.nombre = nombre;
            this.modelo = modelo;
            this.marca = marca;
        }

        public override string ToString()
        {
            return this.id + "\t\t" + this.nombre + "\t\t" + this.modelo + "\t\t" + this.marca;
        }
    }
}
