using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ControlUsuarioBuscar
{
    public partial class CuadroDeBusqueda : UserControl
    {
        private String Texto_a_Buscar;
        private List<String> ResultadoBusqueda;
        public event EventHandler BuscarSeñalado;

        public CuadroDeBusqueda()
        {
            this.ResultadoBusqueda = new List<string>();
            InitializeComponent();
        }

        public String Texto_a_Buscar1
        {
            get { return Texto_a_Buscar; }
            set { Texto_a_Buscar = value; }
        }

        public List<String> ResultadoBusqueda1
        {
            get { return ResultadoBusqueda; }
            set { ResultadoBusqueda = value; }
        }

        private void OnClick(object sender)
        {
            if (this.BuscarSeñalado != null)
            {
                this.BuscarSeñalado(sender, new EventArgs());
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            ResultadoBusqueda.Clear();
            if(Buscartxt.Text == "" || Buscartxt.Text == "Ingrese la Palabra o Letra a Buscar...")
            {
                EtiquetaMensajeError.Text = "DEBE IMGRESAR DATOS...";
            }
            else
            {
                string[] Coincidensias =
                {
                    "Quito",
                    "Guayaquil",
                    "Ambato",
                    "Cuenca",
                    "Loja"
                };
                
                string Palabra_a_Buscar = Buscartxt.Text;
                foreach (string Letras in Coincidensias)
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(Letras, Palabra_a_Buscar, System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        EtiquetaMensajeBusqueda.Text = "BUSCANDO...";
                        this.Texto_a_Buscar = Letras;
                        this.ResultadoBusqueda.Add(this.Texto_a_Buscar);
                        OnClick(sender);
                    }
                    else
                    {
                        EtiquetaMensajeError.Text = "NO EXISTEN COINCIDENCIAS EN ALGUNAS PALABRAS...";
                    }
                }
            }
        }

        private void LimpiarTextBox(Control CuadroDeBusqueda)
        {
            foreach (Control Texto in CuadroDeBusqueda.Controls)
            {
                if (Texto is TextBox)
                {
                    ((TextBox)Texto).Text = "";
                }
                if (Texto.Controls.Count > 0)
                {
                    LimpiarTextBox(Texto);
                }
            }
        }

        private void Buscartxt_Click(object sender, EventArgs e)
        {
            LimpiarTextBox(this);
        }
    }
}