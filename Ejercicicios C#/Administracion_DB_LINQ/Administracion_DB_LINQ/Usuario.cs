using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DB_LINQ
{
    class Usuario
    {
        int id;
        string nombre;
        string login;
        string password;
        
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

        public Usuario (int ini_id, string ini_nombre, string ini_login, string ini_password)
        {
            id = ini_id;
            nombre = ini_nombre;
            login = ini_login;
            password = ini_password;
        }

        public Usuario()
        {
        }

        public override string ToString()
        {
            return id + "  " + nombre;
        }
    }
}
