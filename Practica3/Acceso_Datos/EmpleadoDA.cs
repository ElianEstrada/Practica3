using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

        public LinkedList<Empleado> listaJefes()
        {
            LinkedList<Empleado> jefes = new LinkedList<Empleado>();

            try
            {

                cmd = new SqlCommand("show_jefes", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();
                    empleado.cui = long.Parse(reader[0].ToString());
                    empleado.nombre = reader[1].ToString();
                    empleado.tipoEmpleado = reader[10].ToString();

                    jefes.AddLast(empleado);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return jefes;
        }


        public LinkedList<Empleado> listaEmpleado()
        {
            LinkedList<Empleado> empleados = new LinkedList<Empleado>();

            try
            {

                cmd = new SqlCommand("show_Empleado", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.cui = long.Parse(reader[0].ToString());
                    empleado.nombre = reader[1].ToString();
                    empleado.apellido = reader[2].ToString();
                    empleado.telefono = int.Parse(reader[3].ToString());
                    empleado.direccion = reader[4].ToString();
                    empleado.sueldo = double.Parse(reader[5].ToString());
                    empleado.jefe = reader[6].ToString();
                    empleado.tipoEmpleado = reader[7].ToString();

                    empleados.AddLast(empleado);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return empleados;
        }

        public LinkedList<Empleado> listaChefs()
        {
            LinkedList<Empleado> chefs = new LinkedList<Empleado>();

            try
            {

                cmd = new SqlCommand("show_Chef", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Empleado chef = new Empleado();

                    chef.cui = long.Parse(reader[0].ToString());
                    chef.nombre = reader[1].ToString();
                    chef.apellido = reader[2].ToString();
                    chef.telefono = int.Parse(reader[3].ToString());
                    chef.direccion = reader[4].ToString();
                    chef.sueldo = double.Parse(reader[5].ToString());
                    chef.jefe = reader[6].ToString();
                    chef.tipoEmpleado = reader[7].ToString();

                    chefs.AddLast(chef);
                }

            }
            catch (Exception e)
            {
                return null;
            }

            return chefs;
        }

        public bool addEmpleado(long cui, string nombre, string apellido, int telefono, string direccion, double sueldo, int? bono, long? jefe, int tipo)
        {

            try
            {

                cmd = new SqlCommand("add_Empleado", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cui", cui);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@sueldo", sueldo);
                if(bono != null)
                {
                    cmd.Parameters.AddWithValue("@bono", bono);
                }
                else
                {
                    cmd.Parameters.Add("@bono", SqlDbType.Int).Value = SqlInt32.Null;
                }
                if(jefe != null)
                {
                    cmd.Parameters.AddWithValue("@jefe", jefe);
                }
                else
                {
                    cmd.Parameters.Add("@jefe", SqlDbType.Decimal).Value = SqlDecimal.Null;
                }
                cmd.Parameters.AddWithValue("@tipo", tipo);

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

        public bool existeCuisine()
        {

            try
            {

                cmd = new SqlCommand("existeCuisine", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

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


        public bool add_ChefPlatillo(int cantidad, long chef, int platillo)
        {

            try
            {

                if(!existePlatilloChef(chef, platillo)){

                    cmd = new SqlCommand("ChefPlatillo", conexion.abrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@chef", chef);
                    cmd.Parameters.AddWithValue("@platillo", platillo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    int filas = reader.RecordsAffected;

                    if (filas != 0)
                    {
                        return true;
                    }
                }
                else
                {
                    cmd = new SqlCommand("modificarCantidad", conexion.abrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@cui", chef);
                    cmd.Parameters.AddWithValue("@platillo", platillo);

                    SqlDataReader reader = cmd.ExecuteReader();

                    int filas = reader.RecordsAffected;

                    if(filas != 0)
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
       

        public bool existePlatilloChef(long cui, int platillo)
        {

            try
            {

                cmd = new SqlCommand("existePlatilloChef", conexion.abrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cui", cui);
                cmd.Parameters.AddWithValue("@idPlatillo", platillo);

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



    }
}
