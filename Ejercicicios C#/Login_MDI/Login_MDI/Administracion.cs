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
    public partial class Administracion : Form
    {
        Ventas cambioFormulario_Ventas;
        Compras cambioFormulario_Compras;

        public string tipo;

        public Administracion()
        {
            InitializeComponent();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            if (tipo == "user")
            {
                Text = "BIENVENIDO USER: " + " " + tipo;
                boton_Nuevo.Enabled = true;
                boton_Compras.Enabled = true;
                boton_Ventas.Enabled = false;
            }
            else
            {
                Text = "BIENVENIDO USER: " + " " + tipo;
                boton_Nuevo.Enabled = true;
                boton_Compras.Enabled = true;
                boton_Ventas.Enabled = true;
            }
        }

        private void boton_Ventas_Click(object sender, EventArgs e)
        {
            if (cambioFormulario_Ventas == null)
            {
                cambioFormulario_Ventas = new Ventas();
                cambioFormulario_Ventas.MdiParent = this;
                cambioFormulario_Ventas.Show();
                cambioFormulario_Ventas.FormClosed += null;
                cambioFormulario_Ventas.Activated += cambioFormulario_Activated;
            }
            else
            {
                cambioFormulario_Ventas.Activate();
            }
        }

        private void boton_Compras_Click(object sender, EventArgs e)
        {
            if (cambioFormulario_Compras == null)
            {
                cambioFormulario_Compras = new Compras();
                cambioFormulario_Compras.MdiParent = this;
                cambioFormulario_Compras.Show();
                cambioFormulario_Compras.FormClosed += null;
                cambioFormulario_Compras.Activated += cambioFormulario_Activated;
            }
            else
            {
                cambioFormulario_Compras.Activate();
            }
        }

        void cambioFormulario_Activated(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
            }
        }
    }
}