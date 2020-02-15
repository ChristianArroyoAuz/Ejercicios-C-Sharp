using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        List<Estudiante> nuevoEstudiante = new List<Estudiante>();
        //Estudiante estudiante1 = new Estudiante();
        //Estudiante estudiante2 = new Estudiante();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Estudiante estudiante1 = new Estudiante(1, "Christian", "Arroyo", "Redes", "1234");
            Estudiante estudiante2 = new Estudiante(1, "Xavier", "Arroyo", "Redes", "5678");
            nuevoEstudiante.Add(estudiante1);
            nuevoEstudiante.Add(estudiante2);

            //estudiante1.Nombre = "Christian";
            //estudiante1.Password = "1234";
            //estudiante2.Nombre = "Xavier";
            //estudiante2.Password = "5678";
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            //Forma 1
            Estudiante loginvacio = new Estudiante();

            //Estudiante loginEstudiante = new Estudiante(1, txtNombre.Text, "Arroyo", "Redes", txtPassword.Text);
            foreach (var login in nuevoEstudiante)
            {
                if (txtNombre.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Faltan llenar campos.", "No se puede ingresar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                {
                    if (loginvacio.Nombre == login.Nombre && loginvacio.Password == login.Password)
                    {
                        Principal cambioFormulario = new Principal();
                        cambioFormulario.user = txtNombre.Text;
                        cambioFormulario.Show();
                        Hide();
                        break;
                    }
                    else
                    {
                        txtNombre.Clear();
                        txtPassword.Clear();
                        txtNombre.Focus();
                        MessageBox.Show("Datos Ingresados Incorectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
            }


            //Forma 2
            //if(txtNombre.Text == "Christian" && txtPassword.Text == "1234")
            //{
            //    Principal cambioFormulario = new Principal();
            //    cambioFormulario.user = txtNombre.Text;
            //    cambioFormulario.Show();
            //    Hide();
            //}

            //Forma 3
            //if (txtNombre.Text == estudiante1.Nombre && txtPassword.Text == estudiante1.Password ||
            //    txtNombre.Text == estudiante2.Nombre && txtPassword.Text == estudiante2.Password)
            //{
            //    Principal cambioFormulario = new Principal();
            //    cambioFormulario.user = txtNombre.Text;
            //    cambioFormulario.Show();
            //    Hide();
            //}
        }
    }
}
