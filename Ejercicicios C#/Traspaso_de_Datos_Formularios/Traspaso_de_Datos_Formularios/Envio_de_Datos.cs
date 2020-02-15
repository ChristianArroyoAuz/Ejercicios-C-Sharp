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
    public partial class Envio_de_Datos : Form
    {
        List<Usuario> envioDatos_Ingreso = new List<Usuario>();
        List<Usuario> envioDatos_Actualizar = new List<Usuario>();
        List<Usuario> envioDatos_Eliminar = new List<Usuario>();
        public string nombre_Boton;

         public Envio_de_Datos(List<Usuario> recibirLista_Ingreso, List<Usuario> recibirLista_Actualizar, List<Usuario> recibirLista_Eliminar)
        {
            InitializeComponent();
             envioDatos_Ingreso = recibirLista_Ingreso;
             envioDatos_Actualizar = recibirLista_Actualizar;
             envioDatos_Eliminar = recibirLista_Eliminar;
         }

        private void Envio_de_Datos_Load(object sender, EventArgs e)
        {
            boton_Guardar.Text = nombre_Boton;
            if (nombre_Boton == "GUARDAR")
            {
                etiqueta_Estado.Text = "Nuevo";
            }
            if (nombre_Boton == "ACTUALIZAR")
            {
                foreach (Usuario item in envioDatos_Actualizar)
                {
                    txt_Id.Text = item.Id.ToString();
                    txt_Login.Text = item.Login;
                    txt_Password.Text = item.Password;
                    txt_Edad.Text = item.Edad.ToString();
                }
                etiqueta_Estado.Text = "Actualizando";
            }
            if (nombre_Boton == "ELIMINAR")
            {
                foreach (Usuario item in envioDatos_Eliminar)
                {
                    txt_Id.Text = item.Id.ToString();
                    txt_Login.Text = item.Login;
                    txt_Password.Text = item.Password;
                    txt_Edad.Text = item.Edad.ToString();
                }
                etiqueta_Estado.Text = "Eliminando";
            }
        }

        private void boton_Guardar_Click(object sender, EventArgs e)
        {
            if (nombre_Boton == "GUARDAR")
            {
                boton_Guardar.Text = "GUARDAR";
                Usuario nuevoUsuario = new Usuario(Convert.ToInt32(txt_Id.Text), txt_Login.Text, txt_Password.Text, Convert.ToInt32(txt_Edad.Text));
                envioDatos_Ingreso.Add(nuevoUsuario);
                Recepcion_de_Datos cambioFormulario = new Recepcion_de_Datos(envioDatos_Ingreso, envioDatos_Actualizar, envioDatos_Eliminar);
                Hide();
                cambioFormulario.ShowDialog();
            }
            if (nombre_Boton == "ACTUALIZAR")
            {
                boton_Guardar.Text = "ACTUALIZAR";
                Usuario nuevoUsuario = new Usuario(Convert.ToInt32(txt_Id.Text), txt_Login.Text, txt_Password.Text, Convert.ToInt32(txt_Edad.Text));
                envioDatos_Ingreso.Add(nuevoUsuario);
                Recepcion_de_Datos cambioFormulario = new Recepcion_de_Datos(envioDatos_Ingreso, envioDatos_Actualizar, envioDatos_Eliminar);
                Hide();
                cambioFormulario.ShowDialog();

            }
            if (nombre_Boton == "ELIMINAR")
            {
                DialogResult resultado = MessageBox.Show("Eliminar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    Recepcion_de_Datos cambioFormulario = new Recepcion_de_Datos(envioDatos_Ingreso, envioDatos_Actualizar, envioDatos_Eliminar);
                    Hide();
                    cambioFormulario.ShowDialog();
                }
                else
                {
                    Usuario nuevoUsuario = new Usuario(Convert.ToInt32(txt_Id.Text), txt_Login.Text, txt_Password.Text, Convert.ToInt32(txt_Edad.Text));
                    envioDatos_Ingreso.Add(nuevoUsuario);
                    Recepcion_de_Datos cambioFormulario = new Recepcion_de_Datos(envioDatos_Ingreso, envioDatos_Actualizar, envioDatos_Eliminar);
                    Hide();
                    cambioFormulario.ShowDialog();
                }
            }
        }

        private void Envio_de_Datos_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
