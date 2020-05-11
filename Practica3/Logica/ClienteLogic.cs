using Acceso_Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClienteLogic
    {

        ClienteDA clienteDA = new ClienteDA();

        public LinkedList<Cliente> listaClientes()
        {
            return clienteDA.listaClientes();
        }

        public bool add_Cliente(long cui, string nombre, string apellido, int celular, string nit)
        {
            if (!existeCliente(cui))
            {
                return clienteDA.addCliente(cui, nombre, apellido, celular, nit);
            }
            else
            {
                return false;
            }
        }

        public bool existeCliente(long cui)
        {
            return clienteDA.existeCliente(cui);
        }

    }
}
