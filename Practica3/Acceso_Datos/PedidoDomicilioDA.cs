using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidad;

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
                    aplicarBono(repartidor);
                    return true;
                }

            }
            catch (Exception e)
            {
                return false;
            }

            return false;
        }

        public LinkedList<Pedido> listaPedidos()
        {
            LinkedList<Pedido> pedidos = new LinkedList<Pedido>();

            try
            {

                cmd = new SqlCommand("show_Pedidos", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pedido pedido = new Pedido();
                    pedido.idPedido = int.Parse(reader[0].ToString());
                    pedido.hora = reader[1].ToString();
                    pedido.fecha = reader[2].ToString();
                    pedido.direccion = reader[3].ToString();
                    pedido.cliente = reader[4].ToString();
                    pedido.empleado = reader[5].ToString();
                    pedido.repartidor = reader[6].ToString();
                    pedido.factura = int.Parse(reader[7].ToString());
                    pedido.total = double.Parse(reader[8].ToString());

                    pedidos.AddLast(pedido);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return pedidos;
        }

        public bool aplicarBono(long cui)
        {

            try
            {

                cmd = new SqlCommand("aplicarBono", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cui", cui);

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
