using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlUsuarioBuscar
{
    public partial class Buscador_de_Palabras : Form
    {
        public Buscador_de_Palabras()
        {
            InitializeComponent();
        }

        public void Busca_Palabras(object sender, EventArgs e)
        {
            Lista_de_Resultados.Items.Clear();
            foreach (var Palabra in this.Control_Usuario.ResultadoBusqueda1)
            {
                Lista_de_Resultados.Items.Add(Palabra);
            }
        }

        private void Buscador_de_Palabras_Load(object sender, EventArgs e)
        {
            this.Control_Usuario.BuscarSeñalado += Busca_Palabras;
        }
    }
}