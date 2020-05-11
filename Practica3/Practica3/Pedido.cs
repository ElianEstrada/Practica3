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

        Tabla_de_Platillos tablaPlatillos = new Tabla_de_Platillos();
        static List<PlatilloPedido> platilloPedidos = new List<PlatilloPedido>();
        EmpleadoLogic empleado = new EmpleadoLogic();
        PlatilloLogic platillo = new PlatilloLogic();
        ClienteLogic cliente = new ClienteLogic();
        int totalPedido = 0;
        static int platillosAgregados = 0;
        static double total = 0;
        static int idFactura = 0;

        public Pedido()
        {
            InitializeComponent();
            dtpHoraPedido.Value = DateTime.Now;
            lblPlatillos.Text = platillosAgregados.ToString();
            lblTotalPedido.Text = total.ToString();
            lblTotalPedidos.Text = totalPedido.ToString();
            llenarPlatillo(platillo.listaPlatillos(), cbPlatillos);
            llenarEmpleados(empleado.listaEmpleados(), cbEmpledoPedido, cbRepartidor);
            llenarBebidas(platillo.listaBebidas(), cbBebidas);
            llenarClientes(cliente.listaClientes(), cbCuiCliente);
            llenarChefs(empleado.listaChefs(), cbChef);
        }

        public Pedido(string hola)
        {

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
                clientes.Add(item.cui.ToString());
            }

            comboBox.Items.AddRange(clientes.ToArray());

        }

        public void llenarChefs(LinkedList<Entidad.Empleado> listaChefs, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> chefs = new List<string>();

            foreach (var item in listaChefs)
            {
                chefs.Add(item.cui + ", " + item.nombre);
            }

            comboBox.Items.AddRange(chefs.ToArray());
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

            if(txtIdPedido.Text != "" && cbBebidas.Text != "" && txtCantidad.Text != "" && cbPlatillos.Text != "" && cbChef.Text != "")
            {
                platillo.pedido = int.Parse(txtIdPedido.Text);
                platillo.platillo = cbPlatillos.Text;
                platillo.precio = this.platillo.precioPlatillo(platillo.platillo);
                platillo.bebida = cbBebidas.Text;
                platillo.cantidad = int.Parse(txtCantidad.Text);
                platillo.cuiChef = cbChef.Text;
                platillo.subTotal = platillo.precio * platillo.cantidad;
                total += platillo.subTotal;
                platilloPedidos.Add(platillo);
                platillosAgregados++;
                MessageBox.Show("Platillo Agregado");
                lblPlatillos.Text = platillosAgregados.ToString();
                lblTotalPedido.Text = total.ToString();

            }
            else
            {
                MessageBox.Show("Por favor Completar los campos de [Bebidas], [Cantidad], [Platillos], [chef] y [Número Pedido]");
            }
        }

        public void llenartablaPlatillos(List<PlatilloPedido> platilloPedidos, DataGridView dataGridView)
        {
            List<string> chefs = new List<string>();
            dataGridView.Rows.Clear();

            foreach (var item in platilloPedidos)
            {
                string[] chef = item.cuiChef.Split(',');

                dataGridView.Rows.Add(
                    item.pedido,
                    item.platillo,
                    item.precio,
                    item.cantidad,
                    chef[1],
                    item.subTotal
                );

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenartablaPlatillos(platilloPedidos, tablaPlatillos.dgvPlatillos);
            tablaPlatillos.Show();
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas(txtNit.Text, txtNombre.Text, txtDireccion.Text, dtpFechaPedido.Value, dtpHoraPedido.Value, total);
            facturas.Show();
        }

        private void cbCuiCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in cliente.listaClientes())
            {
                if(item.cui == long.Parse(cbCuiCliente.Text))
                {
                    txtNombre.Text = item.nombre;
                    txtApellido.Text = item.apellido;
                    txtNit.Text = item.nit;
                    txtTelefono.Text = item.telefono.ToString();
                }
            }
        }
    }
}
