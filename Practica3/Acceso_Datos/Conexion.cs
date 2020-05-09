using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class Conexion
    {


        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-R1QU47N;Initial Catalog=Practica3;Integrated Security=True");

        public SqlConnection abrirConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
                connection.Open();
            }

            return connection;
        }

        public SqlConnection cerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }

            return connection;
        }

    }
}
