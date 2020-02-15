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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Alumno AlumnoActual { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Alumno Alumno = new Alumno();
                Alumno.Nombre = txtNombre.Text;
                Alumno.Apellido = txtApellido.Text;
                Alumno.Direccion = txtDireccion.Text;
                Alumno.Fecha_Nac = dtfecha.Value.ToShortDateString();


                int resultado = AlumnoDAL.Agregar(Alumno);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                   
                }

                else
                {
                    MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar pBuscar = new Buscar();
            pBuscar.ShowDialog();

            if (pBuscar.AlumnoSeleccionado != null)
            {
                AlumnoActual = pBuscar.AlumnoSeleccionado;

                txtNombre.Text = pBuscar.AlumnoSeleccionado.Nombre;
                txtApellido.Text = pBuscar.AlumnoSeleccionado.Apellido;
                txtDireccion.Text = pBuscar.AlumnoSeleccionado.Direccion;
                dtfecha.Text = pBuscar.AlumnoSeleccionado.Fecha_Nac;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno pAlumno = new Alumno();
            pAlumno.Nombre = txtNombre.Text;
            pAlumno.Apellido = txtApellido.Text;
            pAlumno.Direccion = txtDireccion.Text;
            pAlumno.Fecha_Nac = dtfecha.Value.ToShortDateString();
            pAlumno.Id = AlumnoActual.Id;


            int resultado = AlumnoDAL.Modificar(pAlumno);

            if (resultado > 0)
            {

                MessageBox.Show("ALumno Modificado con exito", "ALumno Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = true;
            }

            else
            {
                MessageBox.Show("No se pudo Modificar el alumno", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }


        void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            dtfecha.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el alumno??", "Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int resultado = AlumnoDAL.Eliminar(AlumnoActual.Id);

                if (resultado > 0)
                {

                    MessageBox.Show("Alumnos Eliminado Correctamente", "ALumno Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo Eliminar el alumno", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Registro_Usuarios re = new Registro_Usuarios();
            re.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
       
    }
}
