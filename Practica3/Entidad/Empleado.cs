using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empleado
    {

        public long cui { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public double sueldo { get; set; }
        public int bono { get; set; }
        public string jefe { get; set; }
        public string tipoEmpleado { get; set; }
        public int Entregas { get; set; }

    }
}
