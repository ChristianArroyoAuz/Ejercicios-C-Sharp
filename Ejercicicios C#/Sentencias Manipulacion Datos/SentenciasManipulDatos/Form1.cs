using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using SentenciasManipulDatos;

namespace SentenciasManipulDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Datos obDatos = new Datos();

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string sql = @"insert into ejemplo (Nombre, Apellido) values 
                        ('" + this.txtNombreInsertar.Text + "','" + this.txtApellidoInsertar.Text + "')";
            if (obDatos.insertar(sql))
            {
                MessageBox.Show("Registro Insertado");
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obDatos.consulta("select * from", "Ejemplo");
            //Mostramos la tabla 
            this.dataGridView1.DataSource = obDatos.ds.Tables["Ejemplo"];
            this.dataGridView1.Refresh();
            //Enlazamos los datos al listbox
            this.lstEliminar.DataSource = obDatos.consultar2("ejemplo");
            this.lstEliminar.DisplayMember = "Nombre";
            this.lstEliminar.ValueMember = "Id";
            this.lstEliminar.Refresh();
            //enlazamos los datos al combobox
            this.cmbDatosActuales.DataSource = obDatos.consultar2("ejemplo");
            this.cmbDatosActuales.DisplayMember = "Nombre";
            this.cmbDatosActuales.ValueMember = "Id";
            this.cmbDatosActuales.Refresh();
        }

        private void btnEliminarDatos_Click(object sender, EventArgs e)
        {
            if (obDatos.eliminar("ejemplo", "Id='" + this.lstEliminar.SelectedValue.ToString() + "'"))
            {
                MessageBox.Show("Registro eliminado");
            }
            else 
            {
                MessageBox.Show("Error al Eliminar");
            }
            Application.Restart();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            string campos = "Nombre='" + this.txtNombreActualizar.Text + "','" + this.txtApellidoActualizar.Text + "'";
            if (obDatos.actualizar("ejemplo", campos, "Id='" + this.cmbDatosActuales.SelectedValue.ToString() + "'"))
            {
                MessageBox.Show("Registro Actualizado");
            }
            else 
            {
                MessageBox.Show("Error al Actualizar");
            }
            Application.Restart();
        }
    }
}
