using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paso_Datos_MDI
{
    public partial class Login : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();

        public Login()
        {
            InitializeComponent();
            txtBox_LoginForm1.Focus();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            Usuario user1 = new Usuario(1, "Christian", "1234", "Christian");
            Usuario user2 = new Usuario(2, "Xavier", "1234", "Xavier");
            listaUsuarios.Add(user1);
            listaUsuarios.Add(user2);
        }

        private void btn_OKForm1_Click(object sender, EventArgs e)
        {
            Usuario usuarioIngresado = new Usuario(1, txtBox_LoginForm1.Text, txtBox_PassForm1.Text, txtBox_LoginForm1.Text);
            
            foreach (var user in listaUsuarios)
            {
                if (txtBox_LoginForm1.Text == "" || txtBox_PassForm1.Text == "")
                {
                    MessageBox.Show("Faltan llenar campos.", "No se puede ingresar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    if (usuarioIngresado.Login == user.Login && usuarioIngresado.Password == user.Password)
                    {
                        Usuario usuarioValidado = new Usuario(user.Id, user.Login, user.Password, user.Nombre);
                        MDI mdi = new MDI(usuarioValidado, listaUsuarios);
                        mdi.Show();
                        Hide();
                        break;
                    }
                    else
                    {
                        txtBox_LoginForm1.Clear();
                        txtBox_PassForm1.Clear();
                        txtBox_LoginForm1.Focus();
                        MessageBox.Show("Datos Ingresados Incorectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("Seguro desea Cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(cerrar == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}