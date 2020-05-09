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

    }
}
