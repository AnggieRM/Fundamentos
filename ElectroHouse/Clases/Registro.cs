using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroHouse.Clases
{
    internal class Registro
    {
        public Registro() { }
        public static int AgregarUsuario(Login usuario)
        {
            int retorna = 0;

            using (SqlConnection conexion= DBLogin.ObtenerConexion())
            {
                string query = "insert into datos (usuario, contrasenia) values  ('"+usuario.usuario+"' , '"+usuario.contrasenia+"') ";
                SqlCommand command = new SqlCommand(query,conexion);
                retorna = command.ExecuteNonQuery();
 
            }

            return retorna;
        }
    }
}
