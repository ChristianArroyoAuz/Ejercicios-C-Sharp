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
    public partial class Registro_Usuarios : Form
    {
        public Registro_Usuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseña.Text)
            {
                if (UsuarioDAL.CrearCuentas(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada con exito");
                }
                else
                    MessageBox.Show("No se pudo crear la cuenta");
            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        

        
    }
}
