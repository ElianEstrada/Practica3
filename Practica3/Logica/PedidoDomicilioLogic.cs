using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PedidoDomicilioLogic
    {

        PedidoDomicilioDA pedidoDomicilioDA = new PedidoDomicilioDA();

        public bool add_PedidoDomicilio(int idPedido, string hora, string fecha, string direccion, long cliente, string empleado, string repartidor, int factura)
        {
            return pedidoDomicilioDA.add_PedidoDomicilio(idPedido, String.Format("{0:HH:mm:ss}", hora), String.Format("{0:yyyy-MM-dd}", fecha), direccion, cliente, arreglarEmpleados(empleado), arreglarEmpleados(repartidor), factura);
        }

        public long arreglarEmpleados(string empleado)
        {
            string[] cuiJefe = empleado.Split(',');
            return long.Parse(cuiJefe[0]);
        }
    }
}
