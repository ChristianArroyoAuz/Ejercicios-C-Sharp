using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traspaso_de_Datos_Formularios
{
    public class Usuario
    {
        int id;
        string login;
        string password;
        int edad;

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
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public Usuario(int ini_id, string ini_login, string ini_password, int ini_edad)
        {
            id = ini_id;
            login = ini_login;
            password = ini_password;
            edad = ini_edad;
        }

        public override string ToString()
        {
            return "Id: "+ id + "   " + "User: " + login + "   " + "Password: " + password + "   " + "Edad: " + edad; 
        }
    }
}
