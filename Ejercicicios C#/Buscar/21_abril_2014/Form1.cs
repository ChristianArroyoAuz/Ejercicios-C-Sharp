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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            Button btn_Salir = new Button();
            btn_Salir.Text = "Salir";
            btn_Salir.Location = new Point(150, 150);
            btn_Salir.Height = 20;
            btn_Salir.Width = 50;
            btn_Salir.Click += btn_Salir_Click;
            this.Controls.Add(btn_Salir);
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
