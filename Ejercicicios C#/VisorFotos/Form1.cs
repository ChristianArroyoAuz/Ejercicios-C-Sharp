using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisorFotos
{
    public partial class VisorFotos : Form
    {
        const int incremento = 20;
        public VisorFotos()
        {
            InitializeComponent();
        }

        private void btnSeleccionFoto_Click(object sender, EventArgs e)
        {
            //Con ok se selecciona una imagen
            if (ofdSeleccionFoto.ShowDialog() == DialogResult.OK)
            {
                  //con image pongo en el picturebox
                 //el control ofdSeleccion nos deja elegir la imagen
                picMostrarFoto.Image = Image.FromFile(ofdSeleccionFoto.FileName);
                this.Text = "VisorFotos (" + ofdSeleccionFoto.FileName + ")";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgrandar_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + incremento;
            this.Height += incremento;

        }

        private void btnReducir_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - incremento;
            this.Height -= incremento;
        }

        private void VisorFotos_Load(object sender, EventArgs e)
        {
            Button btnMostrarControles = new Button();
            btnMostrarControles.Location = new Point(580, 180);
            btnMostrarControles.Text = "&Mostrar";
            this.Controls.Add(btnMostrarControles);
            btnMostrarControles.Click += new System.EventHandler(this.btnMostrarControles_Click);

        }
        //El siguiente metodo se crearlo ya que el boton no esta en el formulario y el IDE no lo puede crear
        private void btnMostrarControles_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < this.Controls.Count; i++)
            {
                MessageBox.Show("Control#" + i.ToString() + "tiene el nombre" + this.Controls[i].Name);
            }

            //usando foreach
            /*int i=0;
              foreach(Control cnt in this.Controls)
              MessageBox.Show("Control#" + i.ToString() + "tiene el nombre" + cnt.Name);
             * i++
                
              }
             */

        }

        private void picMostrarFoto_Click(object sender, EventArgs e)
        {

        }

    }
}
