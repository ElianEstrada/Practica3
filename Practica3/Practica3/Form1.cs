﻿using System;
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            switch (cbTipoReporte.SelectedIndex)
            {
                case 0:
                    Reporte1_Repartidor reporte1 = new Reporte1_Repartidor();
                    this.Hide();
                    reporte1.Show();
                    break;
                case 1:
                    Reporte2_EmpleadoOrden reporte2 = new Reporte2_EmpleadoOrden();
                    this.Hide();
                    reporte2.Show();
                    break;
                case 2:
                    Reporte3_Platillos reporte3 = new Reporte3_Platillos();
                    this.Hide();
                    reporte3.Show();
                    break;
                case 3:
                    Reporte4_ChefPlatillo reporte4 = new Reporte4_ChefPlatillo();
                    this.Hide();
                    reporte4.Show();
                    break;
                case 4:
                    Reporte5_Facturacion reporte5 = new Reporte5_Facturacion();
                    this.Hide();
                    reporte5.Show();
                    break;
            }
        }
    }
}
