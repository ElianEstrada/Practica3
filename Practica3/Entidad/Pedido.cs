using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Pedido
    {

        public int idPedido { get; set; }
        public string hora { get; set; }
        public string fecha { get; set; }
        public string direccion { get; set; }
        public string cliente { get; set; }
        public string empleado { get; set; }
        public string  repartidor { get; set; }
        public int factura { get; set; }

    }
}
