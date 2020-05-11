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
        int contador = 0;
        EmpleadoLogic empleado = new EmpleadoLogic();

        public Empleado()
        {
            InitializeComponent();
            llenarTipo(empleado.tiposEmpleado(), cbTipoEmpleado);
            llenarTabla(empleado.listaEmpleados());
            lblRecientes.Text = contador.ToString();
        }


        public void llenarTipo(List<Entidad.TipoEmpleado> tipos, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<String> tipoEmpleado = new List<string>();

            foreach (var item in tipos)
            {
                tipoEmpleado.Add(item.idEmpleado + "." + item.Nombre);
            }

            comboBox.Items.AddRange(tipoEmpleado.ToArray());

        }

        public void llenarJefes(LinkedList<Entidad.Empleado> empleados, ComboBox comboBox, string tipoEmpleado)
        {
            List<string> jefe = new List<string>();
            comboBox.Items.Clear();
            foreach (var item in empleados)
            {
                if(tipoEmpleado.Equals("Segundo Cocinero") || tipoEmpleado.Equals("Tercer Cocinero"))
                {
                    if(item.tipoEmpleado.Equals("Primer Cocinero"))
                    {
                        jefe.Add(item.cui + ", " + item.nombre);
                    }
                }
                else
                {
                    if(!tipoEmpleado.Equals("Chef de Cuisine"))
                    {
                        if (item.tipoEmpleado.Equals("Chef de Cuisine"))
                        {
                            jefe.Add(item.cui + ", " + item.nombre);
                        }
                    }
                }
            }

            comboBox.Items.AddRange(jefe.ToArray());
        }

        public void llenarTabla(LinkedList<Entidad.Empleado> empleados)
        {
            lblTotal.Text = empleados.Count.ToString();
            dgvEmpleados.Rows.Clear();

            foreach (var item in empleados)
            {
                dgvEmpleados.Rows.Add(
                    item.cui,
                    item.nombre, 
                    item.apellido,
                    item.telefono, 
                    item.direccion,
                    item.sueldo,
                    item.jefe, 
                    item.tipoEmpleado
                    );
            }
        }

     
        private void cbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbJefes.Text = "";
            string[] tipoEmpleado = cbTipoEmpleado.SelectedItem.ToString().Split('.');
            llenarJefes(empleado.jefes(), cbJefes, tipoEmpleado[1]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string[] tipoEmpleado = cbTipoEmpleado.SelectedItem.ToString().Split('.');
            if (tipoEmpleado[0].Equals("8"))
            {
                if (empleado.addEmpleado(long.Parse(txtCuiEmpleado.Text), txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text, double.Parse(txtSueldo.Text), 0,
                cbJefes.Text, cbTipoEmpleado.SelectedItem.ToString()))
                {
                    MessageBox.Show("Empleado Registrado Exitosamente");
                    llenarTabla(empleado.listaEmpleados());
                    contador++;
                }
                else
                {
                    MessageBox.Show("No se pudeo registrar el empleado OnO");
                }
            }
            else
            {
                if (empleado.addEmpleado(long.Parse(txtCuiEmpleado.Text), txtNombre.Text, txtApellido.Text, int.Parse(txtTelefono.Text), txtDireccion.Text, double.Parse(txtSueldo.Text), null,
                cbJefes.Text, cbTipoEmpleado.SelectedItem.ToString()))
                {
                    MessageBox.Show("Empleado Registrado Exitosamente");
                    llenarTabla(empleado.listaEmpleados());
                    contador++;
                }
                else
                {
                    MessageBox.Show("No se pudeo registrar el empleado OnO");
                }
            }

            lblRecientes.Text = contador.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
