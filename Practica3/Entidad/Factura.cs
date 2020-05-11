using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Factura
    {

        public int idFactura { get; set; }
        public string serie { get; set; }
        public string direccion { get; set; }
        public string  hora { get; set; }
        public string fecha { get; set; }
        public string nit { get; set; }
        public string cliente { get; set; }
        public double total { get; set; }

    }
}
