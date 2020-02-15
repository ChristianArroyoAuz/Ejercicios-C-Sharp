using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_MDI
{
    public partial class Login : Form
    {
        List<Usuario> listaLogin = new List<Usuario>();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(1, "user", "user", "user");
            Usuario administrador = new Usuario(2, "admin", "admin", "admin");
            listaLogin.Add(usuario);
            listaLogin.Add(administrador);
        }

        private void boton_Ingresar_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
            else
            {
                foreach (Usuario item in listaLogin)
                {
                    if (txt_User.Text == item.User && txt_Password.Text == item.Password)
                    {
                        Administracion cambioFormulario = new Administracion();
                        Hide();
                        cambioFormulario.tipo = item.User;
                        cambioFormulario.Show();
                    }
                }
            }
        }
    }
}
