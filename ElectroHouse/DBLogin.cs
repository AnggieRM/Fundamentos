using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ElectroHouse
{
    internal class DBLogin
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=User001;Initial Catalog=dbtest;Data Source=LAPTOP-31D55N99");
            conexion.Open();
            return conexion;
        }

    }
}
