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
    public partial class Pedido : Form
    {

        List<PlatilloPedido> platilloPedidos = new List<PlatilloPedido>();
        EmpleadoLogic empleado = new EmpleadoLogic();
        PlatilloLogic platillo = new PlatilloLogic();
        ClienteLogic cliente = new ClienteLogic();
        int platillosAgregados = 0;

        public Pedido()
        {
            InitializeComponent();
            dtpHoraPedido.Value = DateTime.Now;
            lblPlatillos.Text = platillosAgregados.ToString();
            llenarPlatillo(platillo.listaPlatillos(), cbPlatillos);
            llenarEmpleados(empleado.listaEmpleados(), cbEmpledoPedido, cbRepartidor);
            llenarBebidas(platillo.listaBebidas(), cbBebidas);
            llenarClientes(cliente.listaClientes(), cbCuiCliente);
        }

        public void llenarPlatillo(LinkedList<Platillo> listaPlatillos, ComboBox comboBox)
        {
            List<string> platillos = new List<string>();
            comboBox.Items.Clear();

            foreach (var item in listaPlatillos)
            {
                platillos.Add(item.nombre + "." + item.idPlatillo);
            }

            comboBox.Items.AddRange(platillos.ToArray());

        }

        public void llenarEmpleados(LinkedList<Entidad.Empleado> listaEmpleados, ComboBox comboBox, ComboBox comboBox2)
        {

            List<string> empleados = new List<string>();
            List<string> repartidores = new List<string>();
            comboBox.Items.Clear();
            comboBox2.Items.Clear();

            foreach (var item in listaEmpleados)
            {
                if(item.tipoEmpleado.Equals("Tomador de Pedidos"))
                {
                    empleados.Add(item.cui + ", " + item.nombre);
                }else if (item.tipoEmpleado.Equals("Repartidor"))
                {
                    repartidores.Add(item.cui + ", " + item.nombre);
                }
            }

            comboBox.Items.AddRange(empleados.ToArray());
            comboBox2.Items.AddRange(repartidores.ToArray());

        }

        public void llenarBebidas(LinkedList<Bebida> listaBebidas, ComboBox comboBox)
        {

            comboBox.Items.Clear();
            List<string> bebidas = new List<string>();

            foreach (var item in listaBebidas)
            {
                bebidas.Add(item.nombre + "." + item.idBebida);
            }

            comboBox.Items.AddRange(bebidas.ToArray());

        }

        public void llenarClientes(LinkedList<Cliente> listaClientes, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> clientes = new List<string>();

            foreach (var item in listaClientes)
            {
                clientes.Add(item.cui + ", " + item.nombre);
            }

            comboBox.Items.AddRange(clientes.ToArray());

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
                platillosAgregados++;
                MessageBox.Show("Platillo Agregado");
                lblPlatillos.Text = platillosAgregados.ToString();

            }
            else
            {
                MessageBox.Show("Por favor Completar los campos de [Bebidas], [Cantidad], [Platillos] y [Número Pedido]");
            }
        }
    }
}
