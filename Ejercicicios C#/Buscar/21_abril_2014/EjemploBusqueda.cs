using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21_abril_2014
{
    public partial class EjemploBusqueda : Form
    {
        public EjemploBusqueda()
        {
            InitializeComponent();
        }

        private void EjemploBusqueda_Load(object sender, EventArgs e)
        {
            cuadroBusqueda1.BuscarClicked += cuadroBusqueda1_BuscarClicked;
        }


        private void cuadroBusqueda1_Load(object sender, EventArgs e)
        {

        }

        public void cuadroBusqueda1_BuscarClicked(object sender, EventArgs e)
        {
            foreach (var resul in cuadroBusqueda1.Resultado)
            {
                lstResultados.Items.Add(resul);
            }
        }
    }
}
