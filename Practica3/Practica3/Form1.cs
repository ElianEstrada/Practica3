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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            this.Hide();
            pedido.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            this.Hide();
            empleado.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
