using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class ListaDeFacturas : Form
    {
        FacturaLogic factura = new FacturaLogic();
        double contador = 0;
        public ListaDeFacturas()
        {
            InitializeComponent();
            llenarFactura(factura.listaFactura());
            lblDineroTotal.Text = String.Format("{0:c}", contador);
        }

        public void llenarFactura(LinkedList<Factura> facturas)
        {
            lblTotalFacturas.Text = facturas.Count.ToString();
            dgvFacturas.Rows.Clear();

            foreach (var item in facturas)
            {
                contador += item.total;
                dgvFacturas.Rows.Add(
                    item.idFactura,
                    item.serie,
                    item.direccion,
                    String.Format("{0:yyyy-MM-dd}", item.fecha),
                    String.Format("{0:HH:mm:ss}", item.hora),
                    item.nit,
                    item.cliente,
                    String.Format("{0:c}", item.total)
                    );
            }

        }

    }
}
