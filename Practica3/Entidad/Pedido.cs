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
        public long cuicliente { get; set; }
        public string empleado { get; set; }
        public string  repartidor { get; set; }
        public long empleado2 { get; set; }
        public long repartidor2 { get; set; }
        public int factura { get; set; }
        public double total { get; set; }

        public Pedido(int idPedido, string empleado2, string repartidor2, string hora, long cliente)
        {

            this.idPedido = idPedido;
            this.cuicliente = cliente;
            this.hora = hora;
            this.empleado = empleado2;
            this.repartidor = repartidor2;

        }

        public Pedido()
        {

        }

    }
}
