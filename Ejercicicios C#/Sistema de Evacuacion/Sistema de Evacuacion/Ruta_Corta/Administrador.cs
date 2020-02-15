using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Evacuacion.Ruta_Corta
{
    public partial class Administrador : System.Windows.Forms.Form
    {
        readonly Ruta_Corta.Engine m_Engine = new Ruta_Corta.Engine();
        string FILEDIALOGFILTER = "Map files(*.map;*.txt)|*.map;*.txt";
        string FILEDIALOGDIR = "maps";
        string directorioArchivo;
        string cerrar_cuenta;
        public string recibirNombre;
        public string de_login_a_administrador;
        public string de_login_a_user;
        public string de_registro_a_user;
        private DB.MyDB baseDatos;
        public Random r = new Random();

        public Administrador()
        {
            InitializeComponent();
            m_Engine.Result += OnEngineResult;
        }

        private void Cargar_Mapa()
        {
            string[] dirs = Directory.GetFiles(@"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Maps\", "*.txt");
            int cantidad = dirs.Length;
            int x = r.Next(1, cantidad + 1);
            string Mapa = @"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Maps\Ruta_"+x.ToString()+".txt";
            string Imagen = @"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Imagenes\Ruta_"+x.ToString()+".jpg";
            var serializer = new Ruta_Corta.TxtMatrixSerializer();
            var matrix = serializer.Deserialize(Mapa);
            if (matrix == null) return;
            f_BoardBox.Matrix = matrix;
            f_BoardBox.BackgroundImage = Image.FromFile(Imagen);
        }

        private void Color_Fondo()
        {
            MdiClient chld;
            foreach (Control ctrl in this.Controls)
            {
                try
                {
                    chld = (MdiClient)ctrl;
                    chld.BackColor = this.BackColor;
                }
                catch (InvalidCastException)
                {
                }
            }
        }

        private void Administrador_Usuario()
        {
            if(de_login_a_administrador == "login_administrador")
            {
                Text = "Administrador";
                botonAdmistrar.Visible = false;
            }
            if (de_login_a_user == "login_user" || de_registro_a_user == "registro_a_user")
            {
                Text = "Usuario";
                botonMapas.Visible = false;
                botonAdmistrar.Visible = true;
                botonUsuarios.Visible = false;
            }
        }

        private void Ocultar()
        {
            etiquetaNombre.Visible = false;
            botonSimular.Visible = false;
            botonCambiar_Mapa.Visible = false;
            botonAyuda.Visible = false;
            botonVolver_Login.Visible = false;
            botonSalir.Visible = false;
            f_BoardBox.Visible = false;
            f_BoardBox_2.Visible = false;
            botonUsuarios.Enabled = false;
            botonMapas.Enabled = false;
            botonAdmistrar.Enabled = false;
        }

        public void OnEngineResult(object sender, Ruta_Corta.ResultEventArgs e)
        {
            if (e == null) return;
            f_BoardBox.Matrix.ClearWay();
            f_BoardBox_2.Matrix.ClearWay();
            if (e.Path != null) f_BoardBox.Matrix.SetAll(e.Path, Ruta_Corta.CellType.Negro);
            if (e.Path != null) f_BoardBox_2.Matrix.SetAll(e.Path, Ruta_Corta.CellType.Negro);
            f_BoardBox.Invalidate();
            f_BoardBox_2.Invalidate();
            System.Windows.Forms.Application.DoEvents();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            f_BoardBox.Visible = false;
            f_BoardBox_2.Visible = true;
            OpenFileDialog dialogoAbrirArchivo = new OpenFileDialog();
            dialogoAbrirArchivo.Filter = "Imagen *.JPG|*.jpg|*.PNG|*.png|*.JPEG|*.jpeg";
            dialogoAbrirArchivo.Title = "Seleccione una imagen";
            if (dialogoAbrirArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directorioArchivo = dialogoAbrirArchivo.FileName;
                f_BoardBox_2.BackgroundImage = Image.FromFile(directorioArchivo);
            }
            f_BoardBox_2.MatrixSize_2= new System.Drawing.Size(56, 29);
            f_BoardBox_2.MatrixSize_2 = new System.Drawing.Size(57, 30);
        }

        private void botonAbrir_Click(object sender, EventArgs e)
        {
            f_BoardBox.Visible = true;
            f_BoardBox_2.Visible = false;
            using (var dialog = new System.Windows.Forms.OpenFileDialog())
            {
                string defaultdir = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, FILEDIALOGDIR);
                if (System.IO.Directory.Exists(defaultdir))
                    dialog.InitialDirectory = defaultdir;
                dialog.Filter = FILEDIALOGFILTER;
                if (dialog.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;
                var serializer = new Ruta_Corta.TxtMatrixSerializer();
                var matrix = serializer.Deserialize(dialog.FileName);
                if (matrix == null) return;
                string[] dirs = Directory.GetFiles(@"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Maps\", "*.txt");
                int cantidad = dirs.Length;
                for (int i = 0; i < cantidad + 1; i++)
                {
                    if (dialog.FileName == @"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Maps\Ruta_"+i+".txt")
                    {
                        string Imagen = @"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Imagenes\Ruta_"+i+".jpg";
                        f_BoardBox.Matrix = matrix;
                        f_BoardBox.BackgroundImage = Image.FromFile(Imagen);
                    }
                }
            }
        }

        private void botonGrabar_Click(object sender, EventArgs e)
        {
            f_BoardBox_2.Visible = false;
            f_BoardBox.Visible = true;
            if (f_BoardBox.Matrix == null) return;
            using (var dialog = new System.Windows.Forms.SaveFileDialog())
            {
                string defaultdir = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, FILEDIALOGDIR);
                if (System.IO.Directory.Exists(defaultdir))
                    dialog.InitialDirectory = defaultdir;

                dialog.Filter = FILEDIALOGFILTER;
                if (dialog.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;
                var serializer = new Ruta_Corta.TxtMatrixSerializer();
                serializer.Serialize(dialog.FileName, f_BoardBox.Matrix);
            }
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            etiquetaNombre.Text = "Bienvenido" + " " + recibirNombre.ToString()+".";
            Cargar_Mapa();
            Color_Fondo();
            Administrador_Usuario();
            baseDatos = new DB.MyDB();
            f_BoardBox_2.Visible = false;
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            Ocultar();
            Administraciones.Registro_Usuarios cambioFormulario = new Administraciones.Registro_Usuarios();
            cambioFormulario.MdiParent = this;
            cambioFormulario.de_administrador_registro = "administrador_registro";
            cambioFormulario.Show();
            cambioFormulario.MinimizeBox = false;
            cambioFormulario.MaximizeBox = false;
            cambioFormulario.WindowState = FormWindowState.Minimized;
            cambioFormulario.WindowState = FormWindowState.Maximized;
        }

        private void botonSimular_Click(object sender, EventArgs e)
        {
            if (f_BoardBox.Visible == true && f_BoardBox_2.Visible == false)
            {
                if (!Ruta_Corta.Matrix.IsValid(f_BoardBox.Matrix)) return;
                f_BoardBox.Matrix.ClearWay();
                f_BoardBox.Invalidate();
                m_Engine.Matrix = f_BoardBox.Matrix;
                m_Engine.BeginProcessing();
            }
            if (f_BoardBox.Visible == false && f_BoardBox_2.Visible == true)
            {
                if (!Ruta_Corta.Matrix.IsValid(f_BoardBox_2.Matrix)) return;
                f_BoardBox_2.Matrix.ClearWay();
                f_BoardBox.Invalidate();
                m_Engine.Matrix = f_BoardBox_2.Matrix;
                m_Engine.BeginProcessing();
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            Ocultar();
            Administraciones.Registro_Usuarios cambioFormulario = new Administraciones.Registro_Usuarios();
            cambioFormulario.MdiParent = this;
            cambioFormulario.de_administrador_modificar = "administrador_modificar";
            cambioFormulario.Show();
            cambioFormulario.MinimizeBox = false;
            cambioFormulario.MaximizeBox = false;
            cambioFormulario.WindowState = FormWindowState.Minimized;
            cambioFormulario.WindowState = FormWindowState.Maximized;
        }

        private void botonModificar_Usuario_Click(object sender, EventArgs e)
        {
            Ocultar();
            Administraciones.Registro_Usuarios cambioFormulario = new Administraciones.Registro_Usuarios();
            cambioFormulario.MdiParent = this;
            cambioFormulario.de_user_modificar = "user_modificar";
            cambioFormulario.de_user_modificar_nombre = recibirNombre;
            cambioFormulario.Show();
            cambioFormulario.MinimizeBox = false;
            cambioFormulario.MaximizeBox = false;
            cambioFormulario.WindowState = FormWindowState.Minimized;
            cambioFormulario.WindowState = FormWindowState.Maximized;
        }

        private void botonCerrar_Cuenta_Click(object sender, EventArgs e)
        {
            DialogResult cancelarCuenta = MessageBox.Show("Seguro desea Cerrar la cuenta?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cancelarCuenta == DialogResult.Yes)
            {
                baseDatos.ExecuteCommand("Delete from Usuarios where LoginUser ="+"'"+recibirNombre+"'"+ ";");
                baseDatos.SubmitChanges();
                cerrar_cuenta = "Cerrar Cuenta";
                System.Environment.Exit(9);
            }
            else
            {
                return;
            }
        }

        private void Administrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (cerrar_cuenta == "Volver al Login")
                {
                    Hide();
                }
                else
                {
                    if (cerrar_cuenta == "Cerrar Cuenta")
                    {
                        Close();
                    }
                    else
                    {
                        DialogResult cerrar = MessageBox.Show("Seguro desea Cerrar?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (cerrar == DialogResult.Yes)
                        {
                            try
                            {
                                System.Environment.Exit(9);
                            }
                            catch (Exception)
                            {
                                System.Environment.Exit(9);
                            }
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha Ocurrido un Error.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Environment.Exit(1);
            }
        }

        private void botonSalir_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Salir = new System.Windows.Forms.ToolTip();
            ToolTip_Salir.SetToolTip(this.botonSalir, "Salir de la Aplicación.");
        }

        private void botonVolver_Login_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Volver_Login = new System.Windows.Forms.ToolTip();
            ToolTip_Volver_Login.SetToolTip(this.botonVolver_Login, "Volver al Login.");
        }

        private void botonAyuda_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Ayuda = new System.Windows.Forms.ToolTip();
            ToolTip_Ayuda.SetToolTip(this.botonAyuda, "Ayuda sobre la Aplicación.");
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void botonVolver_Login_Click(object sender, EventArgs e)
        {
            DialogResult cerrar = MessageBox.Show("Seguro desea Volver al Modulo Principal?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cerrar == DialogResult.Yes)
            {
                Administraciones.Sistema_de_Evacuacion cambioFormulario = new Administraciones.Sistema_de_Evacuacion();
                cambioFormulario.Show();
                cerrar_cuenta = "Volver al Login";
                Hide();
            }
            else
            {
                return;
            }
        }

        private void botonSimular_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Simular = new System.Windows.Forms.ToolTip();
            ToolTip_Simular.SetToolTip(this.botonSimular, "Buscar Ruta.");
        }

        private void botonAyuda_Click(object sender, EventArgs e)
        {
            if (de_login_a_administrador == "login_administrador")
            {
                MessageBox.Show("Bienvenido al Centro de Ayuda." + "\n" +
                                "1)Usuarios: Campo usado para la Administracion de los Usuarios (CRUD)." + "\n" +
                                "1.1)Registrar Nuevo Usuario: Lugar donde el Administrador podra agregar a nuevos usuarios, llenando los campos respectivos." + "\n" +
                                "1.2)Modificar Usuario Existente: Lugar donde el Administrador podra Eliminar y monidifcar los datos de un usuarios existente." + "\n" +
                                "2)Mapas: Campo usado para la Administracion de los mapas y rutas." + "\n" +
                                "2.1)Nuevo: Nos permitira crear un nuevo mapa para la simulacion; aqui tendremos que seleccionar una imagen para crear el mapa." + "\n" +
                                "2.2)Abrir: Nos permitira abrir un mapa existente en la base de datos." + "\n" +
                                "2.3)Grabar: Nos permite guardar un nuevo mapa o actualizar un mapa existente.","AYUDA.");
            }
            if (de_login_a_user == "login_user" || de_registro_a_user == "registro_a_user")
            {
                MessageBox.Show("Bienvenido al Centro de Ayuda." + "\n" +
                                "1) Administrar: Campo usado para la Administracion de los datos de usuario." + "\n" +
                                "1.1) Modificar: Permite al usuario modificar sus propios datos." + "\n" +
                                "1.2) Cerrar cuenta: Permite al usuario eliminar su cuenta de la base de datos.", "AYUDA.");
            }
        }

        private void botonCambiar_Mapa_Click(object sender, EventArgs e)
        {
            Cargar_Mapa();
        }

        private void botonCambiar_Mapa_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Cambiar = new System.Windows.Forms.ToolTip();
            ToolTip_Cambiar.SetToolTip(this.botonCambiar_Mapa, "Cambiar Mapa Aleatoriamente.");
        }

        private void botonModificar_Mapa_Click(object sender, EventArgs e)
        {
            using (var dialog = new System.Windows.Forms.OpenFileDialog())
            {
                string defaultdir = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, FILEDIALOGDIR);
                if (System.IO.Directory.Exists(defaultdir))
                    dialog.InitialDirectory = defaultdir;
                dialog.Filter = FILEDIALOGFILTER;
                if (dialog.ShowDialog(this) != System.Windows.Forms.DialogResult.OK) return;
                var serializer = new Ruta_Corta.TxtMatrixSerializer();
                var matrix = serializer.Deserialize(dialog.FileName);
                if (matrix == null) return;
                string[] dirs = Directory.GetFiles(@"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Maps\", "*.txt");
                int cantidad = dirs.Length;
                for (int i = 0; i < cantidad + 1; i++)
                {
                    if (dialog.FileName == @"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Maps\Ruta_" + i + ".txt")
                    {
                        f_BoardBox.Visible = false;
                        f_BoardBox_2.Visible = true;
                        string Imagen = @"C:\Users\usuario\Desktop\Sistema de Evacuacion\Sistema de Evacuacion\Imagenes\Ruta_" + i + ".jpg";
                        f_BoardBox_2.Matrix = matrix;
                        f_BoardBox_2.BackgroundImage = Image.FromFile(Imagen);
                    }
                }
            }
        }
    }
}