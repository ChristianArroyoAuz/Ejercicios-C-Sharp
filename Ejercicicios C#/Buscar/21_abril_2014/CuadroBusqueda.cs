using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _21_abril_2014
{
    public partial class CuadroBusqueda : UserControl
    {
        private String textoBuscar;
        private List<String> resultado;
        public event EventHandler BuscarClicked;


        public CuadroBusqueda()
        {
            this.resultado = new List<String>();
            InitializeComponent();
        }
        
        public List<String> Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }


        public String TextoBuscar
        {
            get { return textoBuscar; }
            set { textoBuscar = value; }
        }

        private void CuadroBusqueda_Load(object sender, EventArgs e)
        {

        }

        private void OnClick(object sender)
        {
            if (this.BuscarClicked != null)
            {
                this.BuscarClicked(sender, new EventArgs());
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            this.textoBuscar = txtBox_Buscar.Text;

            this.resultado.Add("Inicializando la búsqueda con " + this.textoBuscar);

            foreach (var res in resultado)
            {
                System.Console.WriteLine(res);
            }

            OnClick(sender);
        }
    }
}
