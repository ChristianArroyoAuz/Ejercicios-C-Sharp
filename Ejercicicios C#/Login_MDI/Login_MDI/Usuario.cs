using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_MDI
{
    public class Usuario
    {
        int id;
        string user;
        string password;
        string tipo;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Usuario(int ini_id, string ini_user, string ini_password, string ini_tipo)
        {
            id = ini_id;
            user = ini_user;
            password = ini_password;
            tipo = ini_tipo;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
