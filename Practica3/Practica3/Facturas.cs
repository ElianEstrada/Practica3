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
    public partial class Facturas : Form
    {

        FacturaLogic factura = new FacturaLogic();
        PedidoDomicilioLogic pedidoDomicilio = new PedidoDomicilioLogic();
        PlatilloLogic platillo = new PlatilloLogic();
        Entidad.Pedido pedido1;
        List<Entidad.PlatilloPedido> platillos;

        public Facturas(string nit, string nombre, string direccion, DateTime fecha, DateTime hora, double total, Entidad.Pedido pedido, List<Entidad.PlatilloPedido> platilloPedidos)
        {
            InitializeComponent();
            txtNit.Text = nit;
            txtNombre.Text = nombre;
            txtDireccion.Text = direccion;
            dtpFechaPedido.Value = fecha;
            dtpHoraPedido.Value = hora;
            txtTotalFactura.Text = total.ToString();
            pedido1 = pedido;
            platillos = platilloPedidos;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (factura.agregarFactura(int.Parse(txtNumeroFactura.Text), txtSerieFactura.Text, txtDireccion.Text, dtpHoraPedido.Text, dtpFechaPedido.Text, double.Parse(txtTotalFactura.Text)))
            {
                MessageBox.Show("Factura Agregada Con exito");
                if(pedidoDomicilio.add_PedidoDomicilio(pedido1.idPedido, pedido1.hora, dtpFechaPedido.Text, txtDireccion.Text, pedido1.cuicliente, pedido1.empleado, pedido1.repartidor, int.Parse(txtNumeroFactura.Text)))
                {
                    MessageBox.Show("Pedido Agregado");
                    foreach (var item in platillos)
                    {
                        if(platillo.add_PlatilloPedido(item.cantidad, item.subTotal, item.bebida, item.pedido, item.platillo))
                        {
                            
                        }
                    }
                }
            }

            Pedido.platilloPedidos.Clear();
            Pedido.total = 0;
            Pedido.platillosAgregados = 0;
            Pedido pedido = new Pedido();
            this.Close();
            pedido.Show();
        }
    }
}
