using Entidad;
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
    public partial class Pedido : Form
    {

        List<PlatilloPedido> platilloPedidos = new List<PlatilloPedido>();

        public Pedido()
        {
            InitializeComponent();
            dtpHoraPedido.Value = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPlatillo_Click(object sender, EventArgs e)
        {
            PlatilloPedido platillo = new PlatilloPedido();

            if(txtIdPedido.Text != "" && cbBebidas.Text != "" && txtCantidad.Text != "" && cbPlatillos.Text != "")
            {
                platillo.pedido = int.Parse(txtIdPedido.Text);
                platillo.platillo = cbPlatillos.Text;
                platillo.bebida = cbBebidas.Text;
                platillo.cantidad = int.Parse(txtCantidad.Text);

                platilloPedidos.Add(platillo);

                MessageBox.Show("Platillo Agregado");
            }
            else
            {
                MessageBox.Show("Por favor Completar los campos de [Bebidas], [Cantidad], [Platillos] y [Número Pedido]");
            }
        }
    }
}
