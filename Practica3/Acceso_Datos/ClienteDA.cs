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
    public class ClienteDA
    {

        Conexion conexion = new Conexion();
        SqlCommand cmd;

        public LinkedList<Cliente> listaClientes()
        {
            LinkedList<Cliente> clientes = new LinkedList<Cliente>();

            try
            {

                cmd = new SqlCommand("show_clientes", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.cui = long.Parse(reader[0].ToString());
                    cliente.nombre = reader[1].ToString();
                    cliente.apellido = reader[2].ToString();
                    cliente.telefono = int.Parse(reader[4].ToString());
                    cliente.nit = reader[5].ToString();

                    clientes.AddLast(cliente);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return clientes;
        }

        public bool existeCliente(long cui)
        {

            try
            {

                cmd = new SqlCommand("existeCliente", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cuiCliente", cui);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
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

        public bool addCliente(long cui, string nombre, string apellido, int celular, string nit)
        {

            try
            {

                if (!existeCliente(cui))
                {
                    cmd = new SqlCommand("add_cliente", conexion.abrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cui", cui);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@celular", celular);
                    cmd.Parameters.AddWithValue("@nit", nit);

                    SqlDataReader reader = cmd.ExecuteReader();

                    int filas = reader.RecordsAffected;

                    if (filas != 0)
                    {
                        return true;
                    }
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
