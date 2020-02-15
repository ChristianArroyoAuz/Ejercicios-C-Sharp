using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paso_Datos_MDI
{
    public class Usuario
    {
        int id;
        string login;
        string password;
        string nombre;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Usuario(int id, string login, string password, string nombre)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Login = login;
            this.Password = password;
        }

        public override string ToString()
        {
            return login;
        }
    }
}
