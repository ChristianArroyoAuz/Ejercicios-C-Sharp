using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Contextual
{
    public partial class Menu_Contextual : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        string generos;
        string interes;

        public Menu_Contextual()
        {
            InitializeComponent();
        }

        private void Lista()
        {
            if (InteresTecnologia.Checked)
            {
                interes = "Tecnologia";
            }
            if (InteresDeportes.Checked)
            {
                interes = "Deportes";
            }
            if (InteresMusica.Checked)
            {
                interes = "Musica";
            }
            if (InteresLectura.Checked)
            {
                interes = "Lectura";
            }
            if (InteresTecnologia.Checked && InteresDeportes.Checked)
            {
                interes = "Tegnologia, Deportes";
            }
            if (InteresTecnologia.Checked && InteresMusica.Checked)
            {
                interes = "Tecnologia, Musica";
            }
            if (InteresTecnologia.Checked && InteresLectura.Checked)
            {
                interes = "Tecnologia, Lectura";
            }
            if (InteresDeportes.Checked && InteresMusica.Checked)
            {
                interes = "Deporte, Musica";
            }
            if (InteresDeportes.Checked && InteresLectura.Checked)
            {
                interes = "Deporte, Lectura";
            }
            if (InteresMusica.Checked && InteresLectura.Checked)
            {
                interes = "Musica, Lectura";
            }
            if (InteresTecnologia.Checked && InteresDeportes.Checked && InteresMusica.Checked)
            {
                interes = "Tecnologia, Deportes, Musica";
            }
            if (InteresTecnologia.Checked && InteresDeportes.Checked && InteresLectura.Checked)
            {
                interes = "Tecnologia, Deportes, Lectura";
            }
            if (InteresTecnologia.Checked && InteresMusica.Checked && InteresLectura.Checked)
            {
                interes = "Tecnologia, Musica, Lectura";
            }
            if (InteresDeportes.Checked && InteresMusica.Checked && InteresLectura.Checked)
            {
                interes = "Deportes, Musica, Lectura";
            }
            if (InteresLectura.Checked && InteresMusica.Checked && InteresDeportes.Checked && InteresTecnologia.Checked)
            {
                interes = "Tecnologia, Musica, Deportes, Tecnologia";
            }
        }

        private void Genero()
        {
            if(rbFemenino.Checked.Equals(true))
            {
                generos = "Femenino";
            }
            if (rbMasculino.Checked.Equals(true))
            {
                generos = "Masculino";
            }
            if (rbSinEspecificar.Checked.Equals(true))
            {
                generos = "Otro";
            }
        }

        private void Refrescar()
        {
            listaIntereses.Items.Clear();
            foreach (var nuevo in listaUsuarios)
            {
                listaIntereses.Items.Add(nuevo);
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if(rbFemenino.Checked.Equals(false) && rbMasculino.Checked.Equals(false) && rbSinEspecificar.Checked.Equals(false) || txtNombre.Text == "" ||
                InteresTecnologia.Checked.Equals(false) && InteresMusica.Checked.Equals(false) && InteresLectura.Checked.Equals(false) && InteresDeportes.Checked.Equals(false))
            {
                MessageBox.Show("Debe llenar todos los campos.","Advertencia");
            }
            else
            {
                Genero();
                Lista();
                Usuario nuevoUsuario = new Usuario(txtNombre.Text, generos, interes);
                listaUsuarios.Add(nuevoUsuario);
                Refrescar();
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda abierta proximamente.");
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbSinEspecificar.Checked = false;
            InteresDeportes.Checked = false;
            InteresLectura.Checked = false;
            InteresMusica.Checked = false;
            InteresTecnologia.Checked = false;
        }
    }
}
