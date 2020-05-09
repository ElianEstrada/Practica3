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
    public partial class Empleado : Form
    {
        EmpleadoLogic empleado = new EmpleadoLogic();

        public Empleado()
        {
            InitializeComponent();
            llenarTipo(empleado.tiposEmpleado(), cbTipoEmpleado);
        }


        public void llenarTipo(List<Entidad.TipoEmpleado> tipos, ComboBox comboBox)
        {

            List<String> tipoEmpleado = new List<string>();

            foreach (var item in tipos)
            {
                tipoEmpleado.Add(item.idEmpleado + "." + item.Nombre);
            }

            comboBox.Items.AddRange(tipoEmpleado.ToArray());

        }

    }
}
