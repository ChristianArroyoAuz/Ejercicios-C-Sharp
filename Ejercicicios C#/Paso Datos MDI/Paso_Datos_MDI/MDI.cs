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
    public partial class MDI : Form
    {
        public Usuario usuarioMDI;
        public List<Usuario> listaUsuarioMDI;

        public MDI(Usuario initialUsuario, List<Usuario> initialListaUsuario) 
        {
            InitializeComponent();
            usuarioMDI = initialUsuario;
            listaUsuarioMDI = initialListaUsuario;
        }
        
        private void miCuentaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FormHijo_MiCuenta formHijo_MiCuenta = new FormHijo_MiCuenta(usuarioMDI, listaUsuarioMDI); 
            formHijo_MiCuenta.MdiParent = this;
            formHijo_MiCuenta.Show();
        }

        private void administradorDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHijo_AdminUsuarios formHijo_AdminUsuarios = new FormHijo_AdminUsuarios(listaUsuarioMDI);
            formHijo_AdminUsuarios.MdiParent = this;
            formHijo_AdminUsuarios.Show();
        }

        private void MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("Seguro desea Cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cerrar == DialogResult.Yes)
            {
                e.Cancel = false;
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
