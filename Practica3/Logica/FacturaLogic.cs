using Acceso_Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FacturaLogic
    {

        FacturaDA facturaDA = new FacturaDA();

        public bool agregarFactura(int idFactura, string serie, string direccion, string hora, DateTime fecha, double total)
        {
            return facturaDA.add_Factura(idFactura, serie, direccion, String.Format("{0:HH:mm:ss}", hora), String.Format("{0:yyyy-MM-dd}", fecha), total);
        }

        public LinkedList<Factura> listaFactura()
        {
            return facturaDA.listaFacturas();
        }

    }
}
