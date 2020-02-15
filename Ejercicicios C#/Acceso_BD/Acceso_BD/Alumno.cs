using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Acceso_BD
{
    class Alumno
    {
        SqlConnection miConexion;

        public void conectar()
        {
            miConexion = new SqlConnection("Data Source=CHRISTIAN_ARROY\\SQLEXPRESS;Initial Catalog=EPN;Integrated Security=True");
            miConexion.Open();
        }

        public void desconectar()
        {
            miConexion.Close();
        }

        public void ejecutarSQL(string query)
        {
            SqlCommand miComando = new SqlCommand(query, this.miConexion);
            int filasAfectadas = miComando.ExecuteNonQuery();
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Operacion Exitosa");
            }
            else
            {
                MessageBox.Show("No se ha realizado la operacion");
            }
        }

        public void actualizarGrid(DataGridView dgv, string query)
        {
            //Conectar a la base
            this.conectar();
            //Crear Data Set
            System.Data.DataSet miDatSet = new System.Data.DataSet();
            //CrearAdaptador de Datos
            SqlDataAdapter MiDataAtapter = new SqlDataAdapter(query, miConexion);
            //Lenar Data Set
            MiDataAtapter.Fill(miDatSet, "Alumno");
            //Asigno los valores adecuados alas propiedades del DataGridView
            dgv.DataSource = miDatSet;
            dgv.DataMember = "Alumno";
            //Desconectar
            this.desconectar();
        }
    }
}