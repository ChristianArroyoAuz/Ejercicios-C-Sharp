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
    public partial class FormHijo_AdminUsuarios : Form
    {
        List<Usuario> listaUsuariosRec;

        public FormHijo_AdminUsuarios(List<Usuario> listaUsuariosRecibidos) 
        {
            InitializeComponent();
            listaUsuariosRec = listaUsuariosRecibidos; 
        }

        private void FormHijo_AdminUsuarios_Load(object sender, EventArgs e)
        {
            txtBox_Nombre_AdminUsuarios.Enabled = false;
            txtBox_Password_AdminUsuarios.Enabled = false;
            txtBox_Login_AdminUsuarios.Enabled = false;
            txtBox_ID_AdminUsuarios.Enabled = false;

            foreach (var usuar in listaUsuariosRec)
            {
                lstBox_Usuarios_FormAdminUsuarios.Items.Add(usuar);
            }
        }

        private void lstBox_Usuarios_FormAdminUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var usuario in listaUsuariosRec)
            {
                if (lstBox_Usuarios_FormAdminUsuarios.SelectedItem.ToString() == usuario.Login)
                {
                    txtBox_ID_AdminUsuarios.Text = usuario.Id.ToString();
                    txtBox_Login_AdminUsuarios.Text = usuario.Login;
                    txtBox_Nombre_AdminUsuarios.Text = usuario.Nombre;
                    txtBox_Password_AdminUsuarios.Text = usuario.Password;
                }
            }
        }

        private void btn_Aceptar_AdminUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
