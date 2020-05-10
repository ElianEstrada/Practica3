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

    }
}
