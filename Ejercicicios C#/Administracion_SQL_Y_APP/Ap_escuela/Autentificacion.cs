using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ap_escuela
{
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(UsuarioDAL.Autentificar(txtUsuario.Text,txtContraseña.Text)>0)
                {
                    this.Hide();
                   Form1 f=new Form1();
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Error en los datos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (UsuarioDAL.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.ShowDialog();
                }
                else
                    MessageBox.Show("Error en los datos");

            }
        }

      


       
    }
}
