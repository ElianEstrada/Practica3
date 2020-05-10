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
    public class PlatilloDA
    {

        Conexion conexion = new Conexion();
        SqlCommand cmd;

        public LinkedList<Platillo> listaPlatillos()
        {
            LinkedList<Platillo> platillos = new LinkedList<Platillo>();

            try
            {

                cmd = new SqlCommand("show_platillos", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Platillo platillo = new Platillo();

                    platillo.idPlatillo = int.Parse(reader[0].ToString());
                    platillo.nombre = reader[1].ToString();
                    platillo.precio = double.Parse(reader[2].ToString());

                    platillos.AddLast(platillo);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return platillos;
        }

        public LinkedList<Bebida> listaBebidas()
        {
            LinkedList<Bebida> bebidas = new LinkedList<Bebida>();

            try
            {

                cmd = new SqlCommand("show_bebidas", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bebida bebida = new Bebida();

                    bebida.idBebida = int.Parse(reader[0].ToString());
                    bebida.nombre = reader[1].ToString();

                    bebidas.AddLast(bebida);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return bebidas;
        }

        public double precioPlatillo (int idPlatillo)
        {

            try
            {

                cmd = new SqlCommand("searchPlatillo", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idPlatillo", idPlatillo);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return double.Parse(reader[2].ToString());
                }

            }
            catch (Exception e)
            {
                return 0;
            }

            return 0;

        }

    }
}
