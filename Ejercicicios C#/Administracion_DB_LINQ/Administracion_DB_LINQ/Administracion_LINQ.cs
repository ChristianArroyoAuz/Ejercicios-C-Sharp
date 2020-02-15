using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Administracion_DB_LINQ
{
    public partial class Administracion_LINQ : Form
    {
        List<Usuario> lista = new List<Usuario>();
        public Administracion_LINQ()
        {
            InitializeComponent();
        }

        private void boton_Guardar_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario();
            nuevo.Id = Convert.ToInt32(txt_Id.Text);
            nuevo.Nombre = txt_Nombre.Text;
            nuevo.Login = txt_Login.Text;
            nuevo.Password = txt_Password.Text;
            if (UsuarioDAO.insertar(nuevo) > 0)
            {
                MessageBox.Show("Usuario ingresado con Exitos...");
                Administracion_LINQ_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error...");
            }
        }

        private void boton_Actualizar_Click(object sender, EventArgs e)
        {
            foreach(Usuario item in lista_Usuarios.SelectedItems)
            {
                int id_seleccionado = item.Id;
                string nombre_Seleccionado = item.Nombre;
                string login_seleccionado = item.Login;
                string password_Seleccionado = item.Password;
                Usuario actualizar = new Usuario();
                actualizar.Id = id_seleccionado;
                actualizar.Nombre = nombre_Seleccionado;
                actualizar.Login = login_seleccionado;
                actualizar.Password = password_Seleccionado;
                UsuarioDAO.actualizar(actualizar);
            }
            Administracion_LINQ_Load(sender, e);
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            foreach (Usuario item in lista_Usuarios.SelectedItems)
            {
                int id_Seleccionado = item.Id;
                Usuario eliminar = new Usuario();
                eliminar.Id = id_Seleccionado;
                UsuarioDAO.eliminar(eliminar);
            }
            Administracion_LINQ_Load(sender, e);
        }

        private void Administracion_LINQ_Load(object sender, EventArgs e)
        {
            lista_Usuarios.Items.Clear();
            lista = UsuarioDAO.obtenerUsuarios();
            foreach (var item in lista)
            {
                lista_Usuarios.Items.Add(item);
            }
        }
    }
}
