namespace Practica3
{
    partial class Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.pEmpleado = new System.Windows.Forms.Panel();
            this.gbRegistroEmpleado = new System.Windows.Forms.GroupBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.cbRepartidor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEmpledoPedido = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCuiCliente = new System.Windows.Forms.ComboBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraPedido = new System.Windows.Forms.DateTimePicker();
            this.cbPlatillos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgregarPlatillo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platillos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pEmpleado.SuspendLayout();
            this.gbRegistroEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pEmpleado
            // 
            this.pEmpleado.Controls.Add(this.gbRegistroEmpleado);
            this.pEmpleado.Controls.Add(this.dgvPedidos);
            this.pEmpleado.Controls.Add(this.label1);
            this.pEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pEmpleado.Location = new System.Drawing.Point(0, 0);
            this.pEmpleado.Name = "pEmpleado";
            this.pEmpleado.Size = new System.Drawing.Size(1106, 614);
            this.pEmpleado.TabIndex = 5;
            // 
            // gbRegistroEmpleado
            // 
            this.gbRegistroEmpleado.Controls.Add(this.cbBebidas);
            this.gbRegistroEmpleado.Controls.Add(this.label15);
            this.gbRegistroEmpleado.Controls.Add(this.txtCantidad);
            this.gbRegistroEmpleado.Controls.Add(this.label14);
            this.gbRegistroEmpleado.Controls.Add(this.textBox2);
            this.gbRegistroEmpleado.Controls.Add(this.label13);
            this.gbRegistroEmpleado.Controls.Add(this.btnAgregarPlatillo);
            this.gbRegistroEmpleado.Controls.Add(this.cbPlatillos);
            this.gbRegistroEmpleado.Controls.Add(this.label12);
            this.gbRegistroEmpleado.Controls.Add(this.dtpHoraPedido);
            this.gbRegistroEmpleado.Controls.Add(this.dtpFechaPedido);
            this.gbRegistroEmpleado.Controls.Add(this.label11);
            this.gbRegistroEmpleado.Controls.Add(this.txtNit);
            this.gbRegistroEmpleado.Controls.Add(this.label10);
            this.gbRegistroEmpleado.Controls.Add(this.cbCuiCliente);
            this.gbRegistroEmpleado.Controls.Add(this.btnAgregarPedido);
            this.gbRegistroEmpleado.Controls.Add(this.cbRepartidor);
            this.gbRegistroEmpleado.Controls.Add(this.label9);
            this.gbRegistroEmpleado.Controls.Add(this.cbEmpledoPedido);
            this.gbRegistroEmpleado.Controls.Add(this.label8);
            this.gbRegistroEmpleado.Controls.Add(this.label7);
            this.gbRegistroEmpleado.Controls.Add(this.txtDireccion);
            this.gbRegistroEmpleado.Controls.Add(this.label6);
            this.gbRegistroEmpleado.Controls.Add(this.txtTelefono);
            this.gbRegistroEmpleado.Controls.Add(this.label5);
            this.gbRegistroEmpleado.Controls.Add(this.txtApellido);
            this.gbRegistroEmpleado.Controls.Add(this.label4);
            this.gbRegistroEmpleado.Controls.Add(this.txtNombre);
            this.gbRegistroEmpleado.Controls.Add(this.label3);
            this.gbRegistroEmpleado.Controls.Add(this.label2);
            this.gbRegistroEmpleado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistroEmpleado.ForeColor = System.Drawing.Color.White;
            this.gbRegistroEmpleado.Location = new System.Drawing.Point(12, 77);
            this.gbRegistroEmpleado.Name = "gbRegistroEmpleado";
            this.gbRegistroEmpleado.Size = new System.Drawing.Size(1082, 272);
            this.gbRegistroEmpleado.TabIndex = 3;
            this.gbRegistroEmpleado.TabStop = false;
            this.gbRegistroEmpleado.Text = "Cantidad:";
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.Location = new System.Drawing.Point(455, 231);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(168, 35);
            this.btnAgregarPedido.TabIndex = 16;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            // 
            // cbRepartidor
            // 
            this.cbRepartidor.FormattingEnabled = true;
            this.cbRepartidor.Location = new System.Drawing.Point(793, 186);
            this.cbRepartidor.Name = "cbRepartidor";
            this.cbRepartidor.Size = new System.Drawing.Size(198, 23);
            this.cbRepartidor.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(707, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Repartidor:";
            // 
            // cbEmpledoPedido
            // 
            this.cbEmpledoPedido.FormattingEnabled = true;
            this.cbEmpledoPedido.Location = new System.Drawing.Point(465, 186);
            this.cbEmpledoPedido.Name = "cbEmpledoPedido";
            this.cbEmpledoPedido.Size = new System.Drawing.Size(172, 23);
            this.cbEmpledoPedido.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Empleados:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hora del Pedido:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(702, 82);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(334, 22);
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dirección de Entrega:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(364, 82);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 22);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(112, 85);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(165, 22);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(891, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(817, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "CUI:";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombreEmpleado,
            this.direccion,
            this.apellidoEmpleado,
            this.telefono,
            this.sueldo,
            this.tipo,
            this.platillos});
            this.dgvPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 389);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1106, 225);
            this.dgvPedidos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedidos a Domicilio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 22);
            this.panel1.TabIndex = 6;
            // 
            // cbCuiCliente
            // 
            this.cbCuiCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCuiCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCuiCliente.FormattingEnabled = true;
            this.cbCuiCliente.Location = new System.Drawing.Point(393, 34);
            this.cbCuiCliente.Name = "cbCuiCliente";
            this.cbCuiCliente.Size = new System.Drawing.Size(172, 23);
            this.cbCuiCliente.TabIndex = 17;
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(642, 35);
            this.txtNit.MaxLength = 7;
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(144, 22);
            this.txtNit.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(595, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "NIT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(290, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha del Pedido:";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.CustomFormat = "";
            this.dtpFechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPedido.Location = new System.Drawing.Point(423, 131);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFechaPedido.Size = new System.Drawing.Size(111, 22);
            this.dtpFechaPedido.TabIndex = 22;
            this.dtpFechaPedido.Value = new System.DateTime(2020, 5, 9, 16, 7, 19, 0);
            this.dtpFechaPedido.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpHoraPedido
            // 
            this.dtpHoraPedido.CustomFormat = "";
            this.dtpHoraPedido.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraPedido.Location = new System.Drawing.Point(146, 131);
            this.dtpHoraPedido.Name = "dtpHoraPedido";
            this.dtpHoraPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpHoraPedido.ShowUpDown = true;
            this.dtpHoraPedido.Size = new System.Drawing.Size(111, 22);
            this.dtpHoraPedido.TabIndex = 23;
            this.dtpHoraPedido.Value = new System.DateTime(2020, 5, 9, 16, 8, 4, 0);
            // 
            // cbPlatillos
            // 
            this.cbPlatillos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPlatillos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPlatillos.FormattingEnabled = true;
            this.cbPlatillos.Location = new System.Drawing.Point(835, 131);
            this.cbPlatillos.Name = "cbPlatillos";
            this.cbPlatillos.Size = new System.Drawing.Size(198, 23);
            this.cbPlatillos.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(764, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Platillos:";
            // 
            // btnAgregarPlatillo
            // 
            this.btnAgregarPlatillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarPlatillo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPlatillo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPlatillo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPlatillo.Image")));
            this.btnAgregarPlatillo.Location = new System.Drawing.Point(1039, 129);
            this.btnAgregarPlatillo.Name = "btnAgregarPlatillo";
            this.btnAgregarPlatillo.Size = new System.Drawing.Size(31, 29);
            this.btnAgregarPlatillo.TabIndex = 26;
            this.btnAgregarPlatillo.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 35);
            this.textBox2.MaxLength = 7;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 22);
            this.textBox2.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Número de Pedido:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(629, 131);
            this.txtCantidad.MaxLength = 8;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(129, 22);
            this.txtCantidad.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(549, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "Cantidad:";
            // 
            // cbBebidas
            // 
            this.cbBebidas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBebidas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Location = new System.Drawing.Point(137, 187);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(172, 23);
            this.cbBebidas.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(47, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 19);
            this.label15.TabIndex = 31;
            this.label15.Text = "Bebidas:";
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "Número Pedido";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.Frozen = true;
            this.nombreEmpleado.HeaderText = "Cliente";
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.ReadOnly = true;
            this.nombreEmpleado.Width = 120;
            // 
            // direccion
            // 
            this.direccion.Frozen = true;
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 272;
            // 
            // apellidoEmpleado
            // 
            this.apellidoEmpleado.Frozen = true;
            this.apellidoEmpleado.HeaderText = "Fecha";
            this.apellidoEmpleado.Name = "apellidoEmpleado";
            this.apellidoEmpleado.ReadOnly = true;
            this.apellidoEmpleado.Width = 120;
            // 
            // telefono
            // 
            this.telefono.Frozen = true;
            this.telefono.HeaderText = "Hora";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // sueldo
            // 
            this.sueldo.Frozen = true;
            this.sueldo.HeaderText = "Empleado";
            this.sueldo.Name = "sueldo";
            this.sueldo.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.Frozen = true;
            this.tipo.HeaderText = "Repartidor";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // platillos
            // 
            this.platillos.Frozen = true;
            this.platillos.HeaderText = "Ver Platillos";
            this.platillos.Name = "platillos";
            this.platillos.ReadOnly = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1106, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pEmpleado);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.pEmpleado.ResumeLayout(false);
            this.pEmpleado.PerformLayout();
            this.gbRegistroEmpleado.ResumeLayout(false);
            this.gbRegistroEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pEmpleado;
        private System.Windows.Forms.GroupBox gbRegistroEmpleado;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.ComboBox cbRepartidor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEmpledoPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCuiCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpHoraPedido;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregarPlatillo;
        private System.Windows.Forms.ComboBox cbPlatillos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewButtonColumn platillos;
    }
}