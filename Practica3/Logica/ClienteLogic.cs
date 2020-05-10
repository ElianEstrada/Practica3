﻿using Acceso_Datos;
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

    }
}
