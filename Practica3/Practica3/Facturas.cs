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
        public Facturas(string nit, string nombre, string direccion, DateTime fecha, DateTime hora, double total, Entidad.Pedido pedido)
        {
            InitializeComponent();
            txtNit.Text = nit;
            txtNombre.Text = nombre;
            txtDireccion.Text = direccion;
            dtpFechaPedido.Value = fecha;
            dtpHoraPedido.Value = hora;
            txtTotalFactura.Text = total.ToString();
            Entidad.Pedido pedido1 = pedido;
        }
    }
}
