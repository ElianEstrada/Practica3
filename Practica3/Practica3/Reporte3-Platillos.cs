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
    public partial class Reporte3_Platillos : Form
    {

        PlatilloLogic platillo = new PlatilloLogic();

        public Reporte3_Platillos()
        {
            InitializeComponent();
        }

        public void llenarTabla(LinkedList<Entidad.Platillo> platillos)
        {

            dgvReporte3.Rows.Clear();

            foreach (var item in platillos)
            {

                dgvReporte3.Rows.Add(
                    item.idPlatillo,
                    item.nombre,
                    String.Format("{0:c}", item.precio)
                    );

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTabla(platillo.reporte3((cbVersion.SelectedIndex + 1).ToString()));
        }
    }
}
