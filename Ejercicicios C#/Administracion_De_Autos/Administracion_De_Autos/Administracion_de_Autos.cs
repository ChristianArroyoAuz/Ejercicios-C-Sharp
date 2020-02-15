using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Administracion_De_Autos
{
    public partial class Administracion_de_Autos : Form
    {
        List<Auto> listaAutos = new List<Auto>();
        int x= 1;
        int y = 2;
        
        public Administracion_de_Autos()
        {
            InitializeComponent();
        }

        private void Administracion_de_Autos_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        public void Inicio()
        {
            idtxt.Enabled = false;
            nombretxt.Enabled = false;
            modelotxt.Enabled = false;
            marcatxt.Enabled = false;
            botonEliminar.Enabled = false;
            botonGuardar.Enabled = false;
            lista_de_Autos.Enabled = false;
            botonNuevo.Enabled = true;
        }

        public void Limpiar()
        {
            nombretxt.Clear();
            marcatxt.Clear();
            modelotxt.Clear();
            lista_de_Autos.Items.Clear();
        }

        public void IngresoAutos()
        {
            foreach (var auto in listaAutos)
            {
                lista_de_Autos.Items.Add(auto);
            }
        }

        public bool Validar()
        {
            if (nombretxt.Text == "" || modelotxt.Text == "" ||  marcatxt.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Nuevo()
        {
            idtxt.Enabled = true;
            nombretxt.Enabled = true;
            modelotxt.Enabled = true;
            marcatxt.Enabled = true;
            botonNuevo.Enabled = true;
            botonGuardar.Enabled = true;
            botonEliminar.Enabled = true;
            lista_de_Autos.Enabled = true;
        }
     
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (Validar() != true)
            {
                idtxt.Text = Convert.ToString(y++);
                Auto ingresoAuto = new Auto(x++, nombretxt.Text, modelotxt.Text, marcatxt.Text);
                listaAutos.Add(ingresoAuto);
                Limpiar();
                IngresoAutos();
            }
            else
            {
                MessageBox.Show("Debe Llenar todos los espacios.");
            }
            Inicio();
        }

        private void lista_de_Autos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Auto auto in lista_de_Autos.SelectedItems)
            {
                idtxt.Text = Convert.ToString(auto.Id);
                nombretxt.Text = auto.Nombre;
                modelotxt.Text = auto.Modelo;
                marcatxt.Text = auto.Marca;
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
            botonNuevo.Enabled = false;
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (lista_de_Autos.Items.Count > 0)
            {
                Auto borrar = lista_de_Autos.SelectedItem as Auto;
                listaAutos.Remove(borrar);
                lista_de_Autos.Items.RemoveAt(lista_de_Autos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Item...");
            }
        }
    }
}