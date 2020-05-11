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
    public partial class Reporte5_Facturacion : Form
    {

        FacturaLogic factura = new FacturaLogic();
        public Reporte5_Facturacion()
        {
            InitializeComponent();
        }

        public void llenarTabla(LinkedList<Entidad.Factura> factura)
        {

            dgvReporte5.Rows.Clear();

            try
            {

                foreach (var item in factura)
                {

                    dgvReporte5.Rows.Add(
                        item.idFactura,
                        String.Format("{0:c}", item.total)
                        );

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("No Hay facturas en esa fecha");
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTabla(factura.reporte5(cbTipo.SelectedItem.ToString(), dtpFecha.Value));
        }
    }
}
