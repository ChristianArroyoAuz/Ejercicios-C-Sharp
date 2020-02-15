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
    public partial class FormHijo_MiCuenta : Form
    {
        Usuario usuarioValidado;
        List<Usuario> listaUsuarioRecibida;

        public FormHijo_MiCuenta(Usuario usuarioValidadoLogged, List<Usuario> listaUsuarioRecib)
        {
            InitializeComponent();
            usuarioValidado = usuarioValidadoLogged;
            listaUsuarioRecibida = listaUsuarioRecib;
        }

        private void FormHijo_MiCuenta_Load(object sender, EventArgs e)
        {
            lbl_contadorID.Text = usuarioValidado.Id.ToString();
            txtBox_Login_MiCuenta.Text = usuarioValidado.Login;
            txtBox_Password_MiCuenta.Text = usuarioValidado.Password;
            txtBox_Nombre_MiCuenta.Text = usuarioValidado.Nombre;
            txtBox_Nombre_MiCuenta.Enabled = false;
        }

        private void btn_Guardar_MiCuenta_Click(object sender, EventArgs e) 
        {
            usuarioValidado.Login = lbl_contadorID.ToString();
            usuarioValidado.Login = txtBox_Login_MiCuenta.Text;
            usuarioValidado.Nombre = txtBox_Nombre_MiCuenta.Text;
            usuarioValidado.Password = txtBox_Password_MiCuenta.Text;
            Usuario usuarioActualizado = new Usuario(usuarioValidado.Id, usuarioValidado.Login, usuarioValidado.Password, usuarioValidado.Nombre);
            listaUsuarioRecibida.Add(usuarioActualizado);
            MDI userActualizado = new MDI(usuarioActualizado, listaUsuarioRecibida);
            //MessageBox.Show("Datos Actualizados con Exitos...!");
            Hide();
        }
    }
}
