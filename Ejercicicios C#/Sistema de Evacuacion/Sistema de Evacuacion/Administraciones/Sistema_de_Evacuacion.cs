using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Evacuacion.Administraciones
{
    public partial class Sistema_de_Evacuacion : Form
    {
        public string pasarNombre;
        private DB.MyDB baseDatos;
        string usuario;
        string password;
        string datosAdministradorUsu;
        string datosAdministradosPass;
        string datosAdministradorNom;

        public Sistema_de_Evacuacion()
        {
            InitializeComponent();
        }

        private void consultaDatos()
        {
            var consultaUsuario = from Usuarios in this.baseDatos.Usuarios
                                  where Usuarios.LoginUser == txtUser.Text
                                  where Usuarios.Contraseña == txtPassword.Text
                                  select new
                                  {
                                      USUARIO = (String)Usuarios.LoginUser,
                                      CONTRASEÑA = (String)Usuarios.Contraseña
                                  };
            foreach (var usu in consultaUsuario)
            {
                usuario = usu.USUARIO;
                password = usu.CONTRASEÑA;
                break;
            }
        }

        private void consultaAdministrador()
        {
            var consultaAdministrador = from Usuarios in this.baseDatos.Usuarios
                                        where Usuarios.Contraseña == txtPassword.Text
                                        where Usuarios.LoginUser == txtUser.Text
                                        where Usuarios.Id == 1
                                        select new 
                                        {
                                            USUARIO = (String)Usuarios.LoginUser,
                                            CONTRASEÑA = (String)Usuarios.Contraseña
                                        };
            foreach (var administradorLog in consultaAdministrador)
            {
                datosAdministradorUsu = administradorLog.USUARIO;
                break;
            }
            foreach(var administradorPass in consultaAdministrador)
            {
                datosAdministradosPass = administradorPass.CONTRASEÑA;
                break;
            }

            var consultaAdministradorNombre = from Usuarios in this.baseDatos.Usuarios
                                              where Usuarios.Id == 1
                                              select (String)Usuarios.Nombre;
            foreach (var administradorNombre in consultaAdministradorNombre)
            {
                datosAdministradorNom = administradorNombre;
                break;
            }
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Debe LLenar Todos Los Espacios.", "Advertencia.");
                txtUser.Focus();
            }
            else
            {
                consultaDatos();
                consultaAdministrador();

                if (txtUser.Text == usuario && txtPassword.Text == password)
                {
                    if (usuario == datosAdministradorUsu && password == datosAdministradosPass)
                    {
                        Ruta_Corta.Administrador cambioFormulario = new Ruta_Corta.Administrador();
                        Hide();
                        cambioFormulario.recibirNombre = datosAdministradorNom;
                        cambioFormulario.de_login_a_administrador = "login_administrador";
                        cambioFormulario.ShowDialog();
                    }
                    else
                    {
                        Ruta_Corta.Administrador cambioFormulario = new Ruta_Corta.Administrador();
                        Hide();
                        cambioFormulario.recibirNombre = usuario;
                        cambioFormulario.de_login_a_user = "login_user";
                        cambioFormulario.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("El Usuario no Existe o Datos Incorrectos", "Advertencia");
                }

            }
        }

        private void etiquetaRegistro_Click(object sender, EventArgs e)
        {
            Registro_Usuarios cambioFormulario = new Registro_Usuarios();
            Hide();
            cambioFormulario.de_login_registro = "login_registro";
            cambioFormulario.ShowDialog();
        }

        private void Sistema_de_Evacuacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult cerrar = MessageBox.Show("Seguro desea Cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (cerrar == DialogResult.Yes)
                {
                    System.Environment.Exit(1);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha Ocurrido un Error.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Environment.Exit(1);
            }
        }

        private void Sistema_de_Evacuacion_Load(object sender, EventArgs e)
        {
            baseDatos = new DB.MyDB();
        }

        private void botonInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Evacuación." + "\n" +
                            "Pograma que te ayudara en situaciones de riesgo." + "\n" +
                            "Mediante el uso de este pograma podras encontrar" + "\n" +
                            "la ruta más optima para salir del lugar el cual"  + "\n" +
                            "te encuantras."  + "\n" +
                            "Para ello solo tienes que registrarte o logearte."  + "\n" +
                            "Gracias." + "\n" +
                            "Desarrollado por: Arroyo Christian," + "\n" +
                            "                               Parra Carla," + "\n" +
                            "                               Peñafiel Erik," + "\n" +
                            "                               Tapia David." + "\n" +
                            "                               EPN - 2015.","Infromación");
        }
    }
}