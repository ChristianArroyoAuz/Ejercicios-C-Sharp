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
    public partial class Registro_Usuarios : Form
    {
        private DB.MyDB baseDatos;
        public string de_login_registro;
        public string de_administrador_registro;
        public string de_administrador_modificar;
        public string de_user_modificar;
        public string de_user_modificar_nombre;
        string verificacionUser;
        bool ocultar;
        int identicadorUser;
        int id_Borrar;

        public Registro_Usuarios()
        {
            InitializeComponent();
        }

        public void verificarUser()
        {
            var consultaUsuario = from Usuarios in this.baseDatos.Usuarios
                                  where Usuarios.LoginUser == txtUser.Text
                                  select (String)Usuarios.LoginUser;
            foreach (var usu in consultaUsuario)
            {
                verificacionUser = usu;
                break;
            }

            if (txtUser.Text == verificacionUser)
            {
                MessageBox.Show("El nombre de usuario:" + " " + verificacionUser + " " + "ya existe.","ALERTA");
                txtUser.Focus();
            }
            else
            {
                txtContraseña.Focus();
            }
        }

        private void cargarIdentificador()
        {
            var consulta = (from Usuarios in this.baseDatos.Usuarios
                            where Usuarios.Id > 0
                            orderby Usuarios.Id descending
                            select (int)Usuarios.Id).Take(1);
            foreach (var identificador in consulta)
            {
                identicadorUser = identificador;
            }
        }

        private void limpiar()
        {
            txtNombre.Text = "Ingrese sus Nombres";
            txtApellido.Text = "Ingrese sus Apellidos";
            txtUser.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtPais.Clear();
            comboBoxDia.Text = "Dia";
            comboBoxMes.Text = "Mes";
            comboBoxAño.Text = "Año";
            comboBoxSexo.Text = "Escoja su Sexo";
        }

        private void User_Admin()
        {
            if (de_login_registro == "login_registro")
            {
                Text = "REGISTRAR USUARIO";
                groupBox_Condiciones.Visible = true;
                dataGridView_Datos.Visible = false;
                botonEliminar.Visible = false;
                botonRegistrase.Text = "Registrarse";
            }
            if (de_administrador_registro == "administrador_registro")
            {
                Text = "REGISTAR USUARIO";
                groupBox_Condiciones.Visible = false;
                dataGridView_Datos.Visible = false;
                botonEliminar.Visible = false;
                botonRegistrase.Text = "Registar";
            }
            if (de_administrador_modificar == "administrador_modificar")
            {
                Text = "MODIFICAR USUARIO";
                label10.Text = "MODIFICAR CUENTA EXISTENTE.";
                groupBox_Condiciones.Visible = false;
                dataGridView_Datos.Visible = true;
                botonEliminar.Visible = true;
                botonRegistrase.Text = "Actualizar";
            }
            if (de_user_modificar == "user_modificar")
            {
                Text = "MODIFICAR DATOS";
                label10.Text = "MODIFICAR TU CUENTA.";
                groupBox_Condiciones.Visible = false;
                dataGridView_Datos.Visible = true;
                botonEliminar.Visible = false;
                botonRegistrase.Text = "Actualizar";
            }
        }

        private void Cargar_Datos()
        {
            if (de_user_modificar == "user_modificar")
            {
                var consultaDatos = from Usuarios in this.baseDatos.Usuarios
                                    where Usuarios.LoginUser == de_user_modificar_nombre
                                    orderby Usuarios.Id ascending
                                    select new
                                    {
                                        ID = Usuarios.Id,
                                        LOGIN = Usuarios.LoginUser,
                                        NOMBRE = Usuarios.Nombre,
                                        APELLIDO = Usuarios.Apellido,
                                        CONTRASEÑA = Usuarios.Contraseña,
                                        EMAIL = Usuarios.eMail,
                                        TELEFONO = Usuarios.Telefono.ToString(),
                                        PAIS = Usuarios.Pais,
                                        FECHA = Usuarios.Fecha,
                                        SEXO = Usuarios.Sexo
                                    };
                dataGridView_Datos.DataSource = consultaDatos.ToList();
            }
            else
            {
                var consultaDatos = from Usuarios in this.baseDatos.Usuarios
                                    where Usuarios.Id > 1
                                    orderby Usuarios.Id ascending
                                    select new
                                    {
                                        ID = Usuarios.Id,
                                        LOGIN = Usuarios.LoginUser,
                                        NOMBRE = Usuarios.Nombre,
                                        APELLIDO = Usuarios.Apellido,
                                        CONTRASEÑA = Usuarios.Contraseña,
                                        EMAIL = Usuarios.eMail,
                                        TELEFONO = Usuarios.Telefono.ToString(),
                                        PAIS = Usuarios.Pais,
                                        FECHA = Usuarios.Fecha,
                                        SEXO = Usuarios.Sexo
                                    };
                dataGridView_Datos.DataSource = consultaDatos.ToList();
            }
        }

        private void Cargar_Datos_Modificados()
        {
            if (de_user_modificar == "user_modificar")
            {
                var consultaDatos = from Usuarios in this.baseDatos.Usuarios
                                    where Usuarios.LoginUser == txtUser.Text
                                    orderby Usuarios.Id ascending
                                    select new
                                    {
                                        ID = Usuarios.Id,
                                        LOGIN = Usuarios.LoginUser,
                                        NOMBRE = Usuarios.Nombre,
                                        APELLIDO = Usuarios.Apellido,
                                        CONTRASEÑA = Usuarios.Contraseña,
                                        EMAIL = Usuarios.eMail,
                                        TELEFONO = Usuarios.Telefono.ToString(),
                                        PAIS = Usuarios.Pais,
                                        FECHA = Usuarios.Fecha,
                                        SEXO = Usuarios.Sexo
                                    };
                dataGridView_Datos.DataSource = consultaDatos.ToList();
            }
        }

        private void Guardar_Datos()
        {
            DB.Tabla_Usuario datos = new DB.Tabla_Usuario();
            datos.LoginUser = txtUser.Text;
            datos.Nombre = txtNombre.Text;
            datos.Apellido = txtApellido.Text;
            datos.Contraseña = txtContraseña.Text;
            datos.eMail = txtCorreo.Text;
            datos.Telefono = Convert.ToInt32(txtTelefono.Text);
            datos.Pais = txtPais.Text;
            datos.Fecha = comboBoxDia.SelectedItem + "/" + comboBoxMes.SelectedItem + "/" + comboBoxAño.SelectedItem;
            datos.Sexo = Convert.ToString(comboBoxSexo.SelectedItem);
            datos.Id = identicadorUser + 1;
            baseDatos.Usuarios.InsertOnSubmit(datos);
            baseDatos.SubmitChanges();
        }

        private void activarElementos()
        {
            Form pestañas = (Form)this.MdiParent;
            MenuStrip ms = (MenuStrip)pestañas.Controls["MenuBar"];
            ToolStripMenuItem activarU = (ToolStripMenuItem)ms.Items["botonUsuarios"];
            ToolStripMenuItem activarM = (ToolStripMenuItem)ms.Items["botonMapas"];
            ToolStripMenuItem activarA = (ToolStripMenuItem)ms.Items["botonAdmistrar"];
            activarU.Enabled = true;
            activarM.Enabled = true;
            activarA.Enabled = true;
            ((Form)this.MdiParent).Controls["botonSimular"].Visible = true;
            ((Form)this.MdiParent).Controls["etiquetaNombre"].Visible = true;
            ((Form)this.MdiParent).Controls["botonAyuda"].Visible = true;
            ((Form)this.MdiParent).Controls["botonVolver_Login"].Visible = true;
            ((Form)this.MdiParent).Controls["botonSalir"].Visible = true;
            ((Form)this.MdiParent).Controls["botonCambiar_Mapa"].Visible = true;
            ((Form)this.MdiParent).Controls["f_BoardBox"].Visible = true;
        }

        private void Registro_Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (de_login_registro == "login_registro")
                {
                    if (ocultar == true)
                    {
                        Hide();
                    }
                    else
                    {
                        DialogResult cerrar = MessageBox.Show("Seguro desea Cerrar??", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (cerrar == DialogResult.Yes)
                        {
                            System.Environment.Exit(9);
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }
                if (de_administrador_registro == "administrador_registro" || de_administrador_modificar == "administrador_modificar" || de_user_modificar == "user_modificar")
                {
                    activarElementos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha Ocurrido un Error.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Environment.Exit(9);
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
            txtApellido.Focus();
        }

        private void botonRegistrase_Click(object sender, EventArgs e)
        {
            if (de_administrador_registro == "administrador_registro")
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtUser.Text == "" || txtContraseña.Text == "" ||
                txtConfirmarContraseña.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || comboBoxDia.Text == "Dia" ||
                comboBoxMes.Text == "Mes" || comboBoxAño.Text == "Año" || comboBoxSexo.Text == "Escoja su Sexo")
                {
                    MessageBox.Show("Debe Leenar todos los Campos.", "Advertencia");
                }
                else
                {
                    Guardar_Datos();
                    MessageBox.Show("Usuario Registrado con Exito.", "AVISO");
                    activarElementos();
                    Hide();
                }
            }
            if (de_administrador_modificar == "administrador_modificar")
            {
                baseDatos.ExecuteCommand("Update Usuarios set LoginUser ="+"'"+txtUser.Text+"'"+"where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Nombre =" + "'" + txtNombre.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Apellido =" + "'" + txtApellido.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Contraseña =" + "'" + txtContraseña.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set eMail =" + "'" + txtCorreo.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Telefono =" + "'" + Convert.ToInt32(txtTelefono.Text) +"'"+ "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Pais =" + "'" + txtPais.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Fecha =" + "'" + comboBoxDia.SelectedItem + "/" + comboBoxMes.SelectedItem + "/" + comboBoxAño.SelectedItem + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Sexo =" + "'" + comboBoxSexo.SelectedItem + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.SubmitChanges();
                Cargar_Datos();
            }
            if (de_login_registro == "login_registro")
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtUser.Text == "" || txtContraseña.Text == "" ||
                txtConfirmarContraseña.Text == "" || txtCorreo.Text == "" || txtTelefono.Text == "" || comboBoxDia.Text == "Dia" ||
                comboBoxMes.Text == "Mes" || comboBoxAño.Text == "Año" || comboBoxSexo.Text == "Escoja su Sexo")
                {
                    MessageBox.Show("Debe Leenar todos los Campos.", "Advertencia");
                }
                if (checkBoxCondiciones.Checked == false)
                {
                    MessageBox.Show("Debe aceptar las Condiciones de uso.", "Advertencia");
                }
                else
                {
                    Guardar_Datos();
                    Ruta_Corta.Administrador cambioFormulario = new Ruta_Corta.Administrador();
                    cambioFormulario.de_registro_a_user = "registro_a_user";
                    cambioFormulario.recibirNombre = txtUser.Text;
                    ocultar = true;
                    Hide();
                    cambioFormulario.Show();
                }
            }
            if (de_user_modificar == "user_modificar")
            {
                baseDatos.ExecuteCommand("Update Usuarios set LoginUser =" + "'" + txtUser.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Nombre =" + "'" + txtNombre.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Apellido =" + "'" + txtApellido.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Contraseña =" + "'" + txtContraseña.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set eMail =" + "'" + txtCorreo.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Telefono =" + "'" + Convert.ToInt32(txtTelefono.Text) + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Pais =" + "'" + txtPais.Text + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Fecha =" + "'" + comboBoxDia.SelectedItem + "/" + comboBoxMes.SelectedItem + "/" + comboBoxAño.SelectedItem + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.ExecuteCommand("Update Usuarios set Sexo =" + "'" + comboBoxSexo.SelectedItem + "'" + "where Id =" + Convert.ToString(id_Borrar) + ";");
                baseDatos.SubmitChanges();
                Cargar_Datos_Modificados();
            }
        }

        private void Registro_Usuarios_Load(object sender, EventArgs e)
        {
            baseDatos = new DB.MyDB();
            cargarIdentificador();
            Cargar_Datos();
            User_Admin();
            limpiar();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (de_administrador_registro == "administrador_registro" || de_login_registro == "login_registro")
            {
                verificarUser();
            }
        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            if(txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                txtCorreo.Focus();
            }
            else
            {
                MessageBox.Show("Las Contraseñas no Coinciden", "Advertencia");
                txtConfirmarContraseña.Focus();
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            baseDatos.ExecuteCommand("Delete from Usuarios where Id = " + Convert.ToString(id_Borrar) + ";");
            baseDatos.SubmitChanges();
            Cargar_Datos();
        }

        private void dataGridView_Datos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (de_administrador_modificar == "administrador_modificar" || de_user_modificar == "user_modificar")
            {
                txtUser.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtApellido.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtContraseña.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtConfirmarContraseña.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCorreo.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTelefono.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPais.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[7].Value.ToString();
                comboBoxSexo.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[9].Value.ToString();
                id_Borrar = Convert.ToInt32(dataGridView_Datos.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            else
            {
                limpiar();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                txtNombre.Focus();
                return;
            }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                txtPais.Focus();
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                txtApellido.Focus();
                return;
            }
        }
    }
}