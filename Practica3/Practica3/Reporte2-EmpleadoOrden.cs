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
    public partial class Reporte2_EmpleadoOrden : Form
    {

        EmpleadoLogic empleados = new EmpleadoLogic();

        public Reporte2_EmpleadoOrden()
        {
            InitializeComponent();
            llenarTabla(empleados.repoert2());
        }

        public void llenarTabla(LinkedList<Entidad.Empleado> empleados)
        {

            dgvReporte2.Rows.Clear();

            foreach (var item in empleados)
            {

                dgvReporte2.Rows.Add(
                    item.Entregas,
                    item.nombre,
                    item.apellido,
                    String.Format("{0:c}", item.sueldo)
                    );

            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
