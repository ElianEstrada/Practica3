using Acceso_Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmpleadoLogic
    {

        EmpleadoDA empleadoDA = new EmpleadoDA();

        public List<TipoEmpleado> tiposEmpleado()
        {
            return empleadoDA.tipoEmpleados();
        }

        public LinkedList<Empleado> jefes()
        {
            return empleadoDA.listaJefes();
        }

        public LinkedList<Empleado> listaEmpleados()
        {
            return empleadoDA.listaEmpleado();
        }

        public LinkedList<Empleado> listaChefs()
        {
            return empleadoDA.listaChefs();
        }

        public bool addEmpleado(long cui, string nombre, string apellido, int telefono, string direccion, double sueldo, int? bono, string jefe, string tipo)
        {
            if(arreglarTipo(tipo) == 1)
            {
                if (!empleadoDA.existeCuisine())
                {
                    return empleadoDA.addEmpleado(cui, nombre, apellido, telefono, direccion, sueldo, bono, null, arreglarTipo(tipo));
                }
            }
            else
            {
                return empleadoDA.addEmpleado(cui, nombre, apellido, telefono, direccion, sueldo, bono, arreglarEmpleados(jefe), arreglarTipo(tipo));
            }

            return false;
        }

        public bool addChefPlatillo(int cantidad, string chef, string platillo)
        {
            return empleadoDA.add_ChefPlatillo(cantidad, arreglarEmpleados(chef), arreglarIdPlatillo(platillo));
        }

        public long arreglarEmpleados(string empleado)
        {
            string[] cuiJefe = empleado.Split(',');
            return long.Parse(cuiJefe[0]);
        }

        public int arreglarTipo(string tipo)
        {
            string[] idTipo = tipo.Split('.');
            return int.Parse(idTipo[0]);
        }

        public int arreglarIdPlatillo(string idplatillo)
        {
            string[] idTipo = idplatillo.Split('.');
            return int.Parse(idTipo[1]);
        }

    }
}
