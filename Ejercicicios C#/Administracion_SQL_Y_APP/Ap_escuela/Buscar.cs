using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ap_escuela
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        public Alumno AlumnoSeleccionado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AlumnoDAL.BuscarAlumnos(txtNombre.Text, txtApellido.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                AlumnoSeleccionado = AlumnoDAL.ObtenerAlumno(Id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Alumno");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

                   
        
    }
}
