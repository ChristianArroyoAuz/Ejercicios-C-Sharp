using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traspaso_de_Datos_Formularios
{
    public partial class Recepcion_de_Datos : Form
    {
        List<Usuario> recibirDatos = new List<Usuario>();
        List<Usuario> actualizarDatos = new List<Usuario>();
        List<Usuario> eliminarDatos = new List<Usuario>();

        public Recepcion_de_Datos(List<Usuario> recibirLista_Ingreso, List<Usuario> recibirLista_Actualizar, List<Usuario> recibirLista_Eliminar)
        {
            InitializeComponent();
            recibirDatos = recibirLista_Ingreso;
            actualizarDatos = recibirLista_Actualizar;
            eliminarDatos = recibirLista_Eliminar;
        }

        private void Recepcion_de_Datos_Load(object sender, EventArgs e)
        {
            lista_Usuarios.Items.Clear();
            boton_Eliminar.Enabled = false;
            boton_Actualizar.Enabled = false;
            foreach (var item in recibirDatos)
            {
                lista_Usuarios.Items.Add(item);
            }
        }

        public void Contador()
        {
            if (lista_Usuarios.Items.Count > 0)
            {
                boton_Actualizar.Enabled = true;
                boton_Eliminar.Enabled = true;
            }
            else
            {
                boton_Eliminar.Enabled = false;
                boton_Actualizar.Enabled = false;
            }
        }

        public void Eliminar()
        {
            Usuario borrar = (Usuario)lista_Usuarios.SelectedItem;
            recibirDatos.Remove(borrar);
            lista_Usuarios.Items.Remove(borrar);
        }

        private void boton_Ingresar_Click(object sender, EventArgs e)
        {
            Envio_de_Datos cambioFormulario = new Envio_de_Datos(recibirDatos, actualizarDatos, eliminarDatos);
            Hide();
            cambioFormulario.nombre_Boton = "GUARDAR";
            cambioFormulario.Show();
        }

        private void boton_Actualizar_Click(object sender, EventArgs e)
        {
            Envio_de_Datos cambioFormulario = new Envio_de_Datos(recibirDatos, actualizarDatos, eliminarDatos);
            Hide();
            Eliminar();
            cambioFormulario.nombre_Boton = "ACTUALIZAR";
            cambioFormulario.Show();
            Contador();
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            Envio_de_Datos cambioFormulario = new Envio_de_Datos(recibirDatos, actualizarDatos, eliminarDatos);
            Hide();
            Eliminar();
            cambioFormulario.nombre_Boton = "ELIMINAR";
            cambioFormulario.Show();
            Contador();
        }

        private void lista_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            boton_Actualizar.Enabled = true;
            boton_Eliminar.Enabled = true;
            foreach (Usuario item in lista_Usuarios.SelectedItems)
            {
                eliminarDatos.Add(item);
                actualizarDatos.Add(item);
                etiquetaEstado.Text = "Selecciono el Usuario: " + item.Id.ToString();
            }
        }

        private void Recepcion_de_Datos_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Nuevo";
            boton_Ingresar_Click(sender, e);
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Actualizar";
            if (lista_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista...");
            }
            else
            {
                boton_Actualizar_Click(sender, e);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Eliminar";
            if (lista_Usuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista...");
            }
            else 
            {
                boton_Eliminar_Click(sender, e);
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            etiquetaEstado.Text = "Archivo";
        }
    }
}
