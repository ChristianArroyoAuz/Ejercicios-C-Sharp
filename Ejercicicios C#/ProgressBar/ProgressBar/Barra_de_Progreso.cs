using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Barra_de_Progreso : Form
    {
        public Barra_de_Progreso()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void botonPausar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void botonReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
        }
    }
}
