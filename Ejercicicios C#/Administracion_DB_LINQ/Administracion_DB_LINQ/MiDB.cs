using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Administracion_DB_LINQ
{
    class MiDB
    {

        public static SqlConnection obtenerConexion()
        {
            SqlConnection con = new SqlConnection("Data Source=CHRISTIAN_ARROY\\SQLEXPRESS;Initial Catalog=EPN_LINQ;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
