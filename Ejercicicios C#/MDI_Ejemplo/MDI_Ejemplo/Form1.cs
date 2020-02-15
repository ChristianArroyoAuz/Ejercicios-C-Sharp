using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Ejemplo
{
    public partial class Form1 : Form
    {
        Compras cambioFormulario;

        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Compras_Click(object sender, EventArgs e)
        {
            if (cambioFormulario == null)
            {
                cambioFormulario = new Compras();
                cambioFormulario.MdiParent = this;
                cambioFormulario.Show();
                cambioFormulario.FormClosed += cambioFormulario_FormClosed;
                cambioFormulario.Activated += cambioFormulario_Activated;
            }
            else
            {
                cambioFormulario.Activate();
            }
        }
        private void boton_Ventas_Click(object sender, EventArgs e)
        {
            Ventas cambioFormulario = new Ventas();
            cambioFormulario.MdiParent = this;
            cambioFormulario.Show();
        }
        void cambioFormulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            cambioFormulario = null;
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
