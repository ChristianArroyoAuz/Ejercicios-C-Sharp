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

namespace Acceso_BD
{
    public partial class EPN_DB : Form
    {
        Alumno manipularDatos = new Alumno();

        public EPN_DB()
        {
            InitializeComponent();
        }

        private void EPN_DB_Load(object sender, EventArgs e)
        {
            Alumno nuevo = new Alumno();
            nuevo.actualizarGrid(dataGridView_Alumno, "select * from Alumno");
        }

        private void boton_Guardar_Click(object sender, EventArgs e)
        {
            manipularDatos.conectar();
            string consulta = "insert into Alumno (Codigo, Nombrre, Apellido, Edad) values('" + txt_Codigo.Text + "','" + txt_Nombre.Text + "','" + txt_Apellido.Text + "','" + txt_Edad.Text + "');";
            manipularDatos.ejecutarSQL(consulta);
            manipularDatos.actualizarGrid(dataGridView_Alumno, "select * from Alumno");
            manipularDatos.desconectar();
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
