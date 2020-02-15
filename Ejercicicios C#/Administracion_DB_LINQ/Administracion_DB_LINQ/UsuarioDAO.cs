using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Administracion_DB_LINQ
{
    class UsuarioDAO
    {
        public static int insertar(Usuario usuarioINS)
        {
            SqlConnection con = MiDB.obtenerConexion();
            string consulta = "insert into Usuarios values (" + "'" + usuarioINS.Id + "',"
                                                              + "'" + usuarioINS.Nombre + "',"
                                                              + "'" + usuarioINS.Login + "',"
                                                              + "'" + usuarioINS.Password + "');";
            SqlCommand comando = new SqlCommand(consulta, con);
            return comando.ExecuteNonQuery();
        }

        public static int eliminar(Usuario usuarioEliminar)
        {
            SqlConnection con = MiDB.obtenerConexion();
            string consulta_Eliminar = "Delete from Usuarios where Id = " + Convert.ToString(usuarioEliminar.Id) + ";";
            SqlCommand comando = new SqlCommand(consulta_Eliminar, con);
            return comando.ExecuteNonQuery();
        }

        public static int actualizar(Usuario usuarioActualizar)
        {
            SqlConnection con = MiDB.obtenerConexion();
            
            string consulta_Actualizar_Id = "Update Usuarios set ID =" + "'" + usuarioActualizar.Id + "'" + "where Id =" + usuarioActualizar.Id + ";";
            string consulta_Actualizar_Nombre = "Update Usuarios set Nombre =" + "'" + usuarioActualizar.Nombre + "'" + "where Id =" + usuarioActualizar.Id + ";";
            string consulta_Actualizar_Login = "Update Usuarios set Login =" + "'" + usuarioActualizar.Login + "'" + "where Id =" + usuarioActualizar.Id + ";";
            string consulta_Actualizar_Password = "Update Usuarios set Password =" + "'" + usuarioActualizar.Password + "'" + "where Id =" + usuarioActualizar.Id + ";";
            
            SqlCommand comando_Id = new SqlCommand(consulta_Actualizar_Id, con);
            SqlCommand comando_Nombre = new SqlCommand(consulta_Actualizar_Nombre, con);
            SqlCommand comando_Login = new SqlCommand(consulta_Actualizar_Login, con);
            SqlCommand comando_Password = new SqlCommand(consulta_Actualizar_Password, con);
            return comando_Id.ExecuteNonQuery();
            return comando_Nombre.ExecuteNonQuery();
            return comando_Login.ExecuteNonQuery();
            return comando_Password.ExecuteNonQuery();
        }

        public static List<Usuario> obtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection con = MiDB.obtenerConexion();
            SqlCommand comando = new SqlCommand("select * from Usuarios", con);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Usuario auxUser = new Usuario();
                    auxUser.Id = reader.GetInt32(0);
                    auxUser.Nombre = reader.GetString(1);
                    auxUser.Login = reader.GetString(2);
                    auxUser.Password = reader.GetString(3);
                    usuarios.Add(auxUser);
                }
            }
            return usuarios;
        }
    }
}
