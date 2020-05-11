using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class PedidoDomicilioDA
    {

        Conexion conexion = new Conexion();
        SqlCommand cmd;

        public bool add_PedidoDomicilio(int idPedido, string hora, string fecha, string direccion, long cliente, long empleado, long repartidor, int factura)
        {

            try
            {

                cmd = new SqlCommand("add_PedidoDomicilio", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idPedido", idPedido);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@direccionEntrega", direccion);
                cmd.Parameters.AddWithValue("@cliente", cliente);
                cmd.Parameters.AddWithValue("@empleado", empleado);
                cmd.Parameters.AddWithValue("@repartidor", repartidor);
                cmd.Parameters.AddWithValue("@factura", factura);

                SqlDataReader reader = cmd.ExecuteReader();

                int filas = reader.RecordsAffected;

                if(filas != 0)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                return false;
            }

            return false;
        }

    }
}
