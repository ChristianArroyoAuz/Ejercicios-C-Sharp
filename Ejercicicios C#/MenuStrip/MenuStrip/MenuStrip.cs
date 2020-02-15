using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class MenuStrip : Form
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog_txtUsuario.ShowDialog() == DialogResult.OK)
            {
                txt_Usuario.BackColor = colorDialog_txtUsuario.Color;
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void dropDown1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estilo MenuStrip");
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Solo dio Click");
        }

        private void splitButton1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dio Clic en Split");
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel_Estado.Text = "Nuevo";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel_Estado.Text = "Abrir";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel_Estado.Text = "Guardar";
        }
    }
}
