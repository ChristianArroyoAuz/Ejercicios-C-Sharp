using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace User_Activo_Inactivo
{
        
    class Usuario
    {
        string id;
        string login;
        string nombre;
        string pais;
        string fecha;
        string contrasenia;
        string telefono;
        string interes;
        string sexo;
        string estado;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Interes
        {
            get { return interes; }
            set { interes = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Usuario(string id, string login, string nombre, string pais, string fecha, string constrasenia, string telefono, string interes, string sexo, string estado) 
        {
            this.id = id;
            this.login = login;
            this.nombre = nombre;
            this.pais = pais;
            this.fecha = fecha;
            this.contrasenia = constrasenia;
            this.telefono = telefono;
            this.interes = interes;
            this.sexo = sexo;
            this.estado = estado;
        }

        public override string ToString()
        {
            return this.id + "   " + this.login + "   " + this.nombre + "   " + this.pais+"   "+this.fecha+"   "+this.telefono+"   "+this.sexo+"   "+this.interes;
        }
    }
}
