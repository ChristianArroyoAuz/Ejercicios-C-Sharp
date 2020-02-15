using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ap_escuela
{
    class AlumnoDAL
    {

       public static int Agregar(Alumno pAlumno)
       {
           int retorno = 0;
           using (SqlConnection Conn = BDComun.ObtnerCOnexion())
           { 
           SqlCommand Comando=new SqlCommand(string.Format("Insert Into Alumnos (Nombre, Apellido, Direccion, Fecha_nacimiento) values ('{0}', '{1}','{2}','{3}')",
               pAlumno.Nombre, pAlumno.Apellido, pAlumno.Direccion, pAlumno.Fecha_Nac),Conn);

           retorno = Comando.ExecuteNonQuery();
           Conn.Close();
           
           }
           return retorno;       
       }


       public static List<Alumno> BuscarAlumnos(String pNombre, String pApellido)
       {

           List<Alumno> Lista = new List<Alumno>();
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {
               SqlCommand comando = new SqlCommand(string.Format(
                   "Select Id, Nombre,  Apellido, Direccion, Fecha_nacimiento from Alumnos where Nombre like '%{0}%' or Apellido like '%{1}%'", pNombre, pApellido), conexion);

               SqlDataReader reader = comando.ExecuteReader();

               while (reader.Read())
               {
                   Alumno pAlumno = new Alumno();
                   pAlumno.Id = reader.GetInt64(0);
                   pAlumno.Nombre = reader.GetString(1);
                   pAlumno.Apellido = reader.GetString(2);
                   pAlumno.Direccion = reader.GetString(3);
                   pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

                   Lista.Add(pAlumno);

               }
               conexion.Close();
               return Lista;

           }

       }



       public static Alumno ObtenerAlumno(Int64 pId)
       {

           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {

               Alumno pAlumno = new Alumno();
               SqlCommand comando = new SqlCommand(string.Format(
                   "Select Id, Nombre,  Apellido, Direccion, Fecha_nacimiento from Alumnos where Id={0}",pId), conexion);

               SqlDataReader reader = comando.ExecuteReader();

               while (reader.Read())
               {
                   pAlumno.Id = reader.GetInt64(0);
                   pAlumno.Nombre = reader.GetString(1);
                   pAlumno.Apellido = reader.GetString(2);
                   pAlumno.Direccion = reader.GetString(3);
                   pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

                   

               }
               conexion.Close();
               return pAlumno;

           }

       }



       public static int Modificar(Alumno pAlumno)
       {
           int retorno = 0;
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {
               SqlCommand comando = new SqlCommand(string.Format("Update Alumnos set Nombre='{0}', Apellido='{1}', Direccion='{2}', Fecha_Nacimiento='{3}' where Id={4}",
                   pAlumno.Nombre, pAlumno.Apellido, pAlumno.Direccion, pAlumno.Fecha_Nac, pAlumno.Id), conexion);

               retorno = comando.ExecuteNonQuery();
               conexion.Close();
           }
           return retorno;
       
       }


       public static int Eliminar(Int64 pId)
       {
           int retorno = 0;
           using (SqlConnection conexion = BDComun.ObtnerCOnexion())
           {

               SqlCommand comando = new SqlCommand(string.Format("Delete from Alumnos where Id={0}", pId), conexion);
               retorno = comando.ExecuteNonQuery();
               conexion.Close();
           }
           return retorno;
       
       }





    }
}
