using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Dinamico
{
    public partial class Controles_Dinamicos : Form
    {
        public Controles_Dinamicos()
        {
            InitializeComponent();
        }

        private void boton_Crear_Click(object sender, EventArgs e)
        {
            Button cerrar = new Button();
            this.Controls.Add(cerrar);
            cerrar.Text = "Cerrar";
            cerrar.Location = new Point(200, 200);
            cerrar.Click += cerrar_Click;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
