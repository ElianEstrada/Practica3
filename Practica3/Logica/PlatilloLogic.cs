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

        public LinkedList<Bebida> listaBebidas()
        {
            return platilloDA.listaBebidas();
        }

        public double precioPlatillo (string idPlatillo)
        {
            return platilloDA.precioPlatillo(arreglarIdPlatillo(idPlatillo));
        }

        public int arreglarIdPlatillo(string idplatillo)
        {
            string[] idTipo = idplatillo.Split('.');
            return int.Parse(idTipo[1]);
        }
    }
}
