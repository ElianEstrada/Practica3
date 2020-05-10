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
    public partial class Tabla_de_Platillos : Form
    {
        //Pedido pedido = new Pedido();
        public Tabla_de_Platillos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            this.Close();
            pedido.Show();
        }
    }
}
