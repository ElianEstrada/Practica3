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

        public LinkedList<Factura> listaFacturas()
        {
            LinkedList<Factura> facturas = new LinkedList<Factura>();

            try
            {

                cmd = new SqlCommand("show_Factura", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Factura factura = new Factura();

                    factura.idFactura = int.Parse(reader[0].ToString());
                    factura.serie = reader[1].ToString();
                    factura.direccion = reader[2].ToString();
                    factura.hora = reader[3].ToString();
                    factura.fecha = reader[4].ToString();
                    factura.nit = reader[5].ToString();
                    factura.cliente = reader[6].ToString();
                    factura.total = double.Parse(reader[7].ToString());

                    facturas.AddLast(factura);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return facturas;
        }


        public LinkedList<Factura> reporte5(string tipo, string fecha)
        {
            LinkedList<Factura> facturas = new LinkedList<Factura>();

            try
            {

                cmd = new SqlCommand("facturacion" + tipo, conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha", fecha);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Factura factura = new Factura();

                    factura.idFactura = int.Parse(reader[0].ToString());
                    factura.total = double.Parse(reader[1].ToString());

                    facturas.AddLast(factura);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return facturas;
        }

    }
}
