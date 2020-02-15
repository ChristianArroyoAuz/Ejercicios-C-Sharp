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
    public partial class Cuadros_de_Dialogo : Form
    {
        public Cuadros_de_Dialogo()
        {
            InitializeComponent();
        }

        private void botonBienvenido_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Bievenido", "Titulo", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == resultado)
            {
                MessageBox.Show("Bienvenido: " + textBox1.Text);
            }
            else
            {
                MessageBox.Show("Chao: " + textBox1.Text);
            }
        }

        private void botonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
                //label1.BackColor = colorDialog1.Color;
                //label1.ForeColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("No Hubo Cambios...");
            }
        }

        private void botonPersonal_Click(object sender, EventArgs e)
        {
            Cuadro_Dialogo_Personalizado cambio = new Cuadro_Dialogo_Personalizado();
            if (cambio.ShowDialog() == DialogResult.OK)
            {
                label2.Text = cambio.nombre;
                this.Text = "Bienvenido" + " " + cambio.nombre;
                //Usando Metodos
                //Text = cambio.Nombre();
            }
            else
            {
                MessageBox.Show("No Hubo Cambios...");
            }
        }
    }
}
