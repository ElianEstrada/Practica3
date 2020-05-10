using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class PlatilloPedido
    {

        public int idPlatilloPedido { get; set; }
        public int pedido { get; set; }
        public string platillo { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public double subTotal { get; set; }
        public string bebida { get; set; }
    }
}
