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
    public class EmpleadoDA
    {

        Conexion conexion = new Conexion();
        SqlCommand cmd;

        public List<TipoEmpleado> tipoEmpleados()
        {
            List<TipoEmpleado> tipo = new List<TipoEmpleado>();

            try
            {

                cmd = new SqlCommand("show_TipoEmpleado", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    TipoEmpleado tipoEmpleado = new TipoEmpleado();

                    tipoEmpleado.idEmpleado = int.Parse(reader[0].ToString());
                    tipoEmpleado.Nombre = reader[1].ToString();

                    tipo.Add(tipoEmpleado);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return tipo;
        }



    }
}
