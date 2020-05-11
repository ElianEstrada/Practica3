using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class FacturaDA
    {

        Conexion conexion = new Conexion();
        SqlCommand cmd;

        public bool add_Factura(int idFactura, string serieFactura, string direccionEntrega, string hora, string fecha, double total)
        {

            try
            {

                cmd = new SqlCommand("add_Factura", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idFactura", idFactura);
                cmd.Parameters.AddWithValue("@serieFactura", serieFactura);
                cmd.Parameters.AddWithValue("@direccionEntrega", direccionEntrega);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@total", total);

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
