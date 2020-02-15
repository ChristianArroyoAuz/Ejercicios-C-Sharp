using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadros_de_Dialogo
{
    public partial class Cuadro_Dialogo_Personalizado : Form
    {
        public string nombre;

        public Cuadro_Dialogo_Personalizado()
        {
            InitializeComponent();
        }

        //Usando Metodos
        //public string Nombre()
        //{
        //    return txtNombre.Text;
        //}

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
        }
    }
}
