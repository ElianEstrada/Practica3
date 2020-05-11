using Acceso_Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PlatilloLogic
    {

        PlatilloDA platilloDA = new PlatilloDA();

        public LinkedList<Platillo> listaPlatillos()
        {
            return platilloDA.listaPlatillos();
        }

        public LinkedList<Platillo> reporte3(string version)
        {
            return platilloDA.reporte3(version);
        }

        public LinkedList<Bebida> listaBebidas()
        {
            return platilloDA.listaBebidas();
        }

        public double precioPlatillo (string idPlatillo)
        {
            return platilloDA.precioPlatillo(arreglarIdPlatillo(idPlatillo));
        }

        public bool add_PlatilloPedido(int cantidad, double subTotal, string bebida, int pedido, string platillo)
        {
            return platilloDA.add_PedidoPlatillo(cantidad, subTotal, arreglarBebida(bebida), pedido, arreglarIdPlatillo(platillo));
        }

        public int arreglarBebida(string bebida)
        {
            string[] idBebida = bebida.Split('.');
            return int.Parse(idBebida[1]);
        }

        public int arreglarIdPlatillo(string idplatillo)
        {
            string[] idTipo = idplatillo.Split('.');
            return int.Parse(idTipo[1]);
        }

        

    }
}
