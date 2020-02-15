using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace User_Activo_Inactivo
{
    public partial class Cancelar : Form
    {
        public Cancelar()
        {
            InitializeComponent();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Formulario_en_Modo("Ingresando Datos");
            this.Close();
        }

        private void btn_Si_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Formulario_en_Modo("Boton Nuevo");
            this.Close();
        }

        
    }
}
