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
    public partial class Reporte4_ChefPlatillo : Form
    {

        EmpleadoLogic empleado = new EmpleadoLogic();

        public Reporte4_ChefPlatillo()
        {
            InitializeComponent();
            llenarTabla(empleado.repoert4());
        }


        public void llenarTabla(LinkedList<Entidad.Empleado> empleados)
        {

            dgvReporte4.Rows.Clear();

            foreach (var item in empleados)
            {

                dgvReporte4.Rows.Add(
                    item.Entregas,
                    item.cui,
                    item.nombre,
                    item.apellido
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
