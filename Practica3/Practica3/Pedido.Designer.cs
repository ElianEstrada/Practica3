﻿namespace Practica3
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbChef = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbBebidas = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregarPlatillo = new System.Windows.Forms.Button();
            this.cbPlatillos = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpHoraPedido = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCuiCliente = new System.Windows.Forms.ComboBox();
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPedido = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPlatillos = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotalPedidos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pEmpleado.SuspendLayout();
            this.gbRegistroEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pEmpleado
            // 
            this.pEmpleado.Controls.Add(this.gbRegistroEmpleado);
            this.pEmpleado.Controls.Add(this.dgvPedidos);
            this.pEmpleado.Controls.Add(this.label1);
            this.pEmpleado.Location = new System.Drawing.Point(0, 0);
            this.pEmpleado.Name = "pEmpleado";
            this.pEmpleado.Size = new System.Drawing.Size(1106, 619);
            this.pEmpleado.TabIndex = 5;
            // 
            // gbRegistroEmpleado
            // 
            this.gbRegistroEmpleado.Controls.Add(this.btnSalir);
            this.gbRegistroEmpleado.Controls.Add(this.cbChef);
            this.gbRegistroEmpleado.Controls.Add(this.label18);
            this.gbRegistroEmpleado.Controls.Add(this.btnFacturas);
            this.gbRegistroEmpleado.Controls.Add(this.button1);
            this.gbRegistroEmpleado.Controls.Add(this.cbBebidas);
            this.gbRegistroEmpleado.Controls.Add(this.label15);
            this.gbRegistroEmpleado.Controls.Add(this.txtCantidad);
            this.gbRegistroEmpleado.Controls.Add(this.label14);
            this.gbRegistroEmpleado.Controls.Add(this.txtIdPedido);
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
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(717, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 35);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbChef
            // 
            this.cbChef.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbChef.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbChef.FormattingEnabled = true;
            this.cbChef.Location = new System.Drawing.Point(294, 187);
            this.cbChef.Name = "cbChef";
            this.cbChef.Size = new System.Drawing.Size(172, 23);
            this.cbChef.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(236, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 19);
            this.label18.TabIndex = 35;
            this.label18.Text = "Chefs:";
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturas.Location = new System.Drawing.Point(522, 231);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(168, 35);
            this.btnFacturas.TabIndex = 34;
            this.btnFacturas.Text = "Ver Facturas";
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ver Platillos ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBebidas
            // 
            this.cbBebidas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBebidas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBebidas.FormattingEnabled = true;
            this.cbBebidas.Location = new System.Drawing.Point(89, 185);
            this.cbBebidas.Name = "cbBebidas";
            this.cbBebidas.Size = new System.Drawing.Size(131, 23);
            this.cbBebidas.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 19);
            this.label15.TabIndex = 31;
            this.label15.Text = "Bebidas:";
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
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(171, 35);
            this.txtIdPedido.MaxLength = 7;
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(144, 22);
            this.txtIdPedido.TabIndex = 28;
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
            this.btnAgregarPlatillo.Click += new System.EventHandler(this.btnAgregarPlatillo_Click);
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
            // cbCuiCliente
            // 
            this.cbCuiCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCuiCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCuiCliente.FormattingEnabled = true;
            this.cbCuiCliente.Location = new System.Drawing.Point(393, 34);
            this.cbCuiCliente.Name = "cbCuiCliente";
            this.cbCuiCliente.Size = new System.Drawing.Size(172, 23);
            this.cbCuiCliente.TabIndex = 17;
            this.cbCuiCliente.SelectedIndexChanged += new System.EventHandler(this.cbCuiCliente_SelectedIndexChanged);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPedido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPedido.Location = new System.Drawing.Point(141, 231);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(168, 35);
            this.btnAgregarPedido.TabIndex = 16;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = false;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // cbRepartidor
            // 
            this.cbRepartidor.FormattingEnabled = true;
            this.cbRepartidor.Location = new System.Drawing.Point(867, 185);
            this.cbRepartidor.Name = "cbRepartidor";
            this.cbRepartidor.Size = new System.Drawing.Size(198, 23);
            this.cbRepartidor.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(781, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Repartidor:";
            // 
            // cbEmpledoPedido
            // 
            this.cbEmpledoPedido.FormattingEnabled = true;
            this.cbEmpledoPedido.Location = new System.Drawing.Point(586, 185);
            this.cbEmpledoPedido.Name = "cbEmpledoPedido";
            this.cbEmpledoPedido.Size = new System.Drawing.Size(172, 23);
            this.cbEmpledoPedido.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Empleado:";
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
            this.Column2,
            this.Column1});
            this.dgvPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPedidos.Location = new System.Drawing.Point(0, 394);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1106, 225);
            this.dgvPedidos.TabIndex = 0;
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
            this.direccion.Width = 200;
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
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Factura";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 72;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.panel1.Controls.Add(this.lblTotalPedido);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.lblPlatillos);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lblTotalPedidos);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 32);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTotalPedido
            // 
            this.lblTotalPedido.AutoSize = true;
            this.lblTotalPedido.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedido.ForeColor = System.Drawing.Color.White;
            this.lblTotalPedido.Location = new System.Drawing.Point(548, 5);
            this.lblTotalPedido.Name = "lblTotalPedido";
            this.lblTotalPedido.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPedido.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(453, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Total del Pedido:";
            // 
            // lblPlatillos
            // 
            this.lblPlatillos.AutoSize = true;
            this.lblPlatillos.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatillos.ForeColor = System.Drawing.Color.White;
            this.lblPlatillos.Location = new System.Drawing.Point(328, 6);
            this.lblPlatillos.Name = "lblPlatillos";
            this.lblPlatillos.Size = new System.Drawing.Size(0, 13);
            this.lblPlatillos.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(211, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Platillos Agregados:";
            // 
            // lblTotalPedidos
            // 
            this.lblTotalPedidos.AutoSize = true;
            this.lblTotalPedidos.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPedidos.ForeColor = System.Drawing.Color.White;
            this.lblTotalPedidos.Location = new System.Drawing.Point(112, 6);
            this.lblTotalPedidos.Name = "lblTotalPedidos";
            this.lblTotalPedidos.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPedidos.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Total de Pedidos:";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1106, 649);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pEmpleado);
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.pEmpleado.ResumeLayout(false);
            this.pEmpleado.PerformLayout();
            this.gbRegistroEmpleado.ResumeLayout(false);
            this.gbRegistroEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCuiCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpHoraPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregarPlatillo;
        private System.Windows.Forms.ComboBox cbPlatillos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbBebidas;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbChef;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label lblPlatillos;
        public System.Windows.Forms.Label lblTotalPedido;
        public System.Windows.Forms.Label lblTotalPedidos;
        public System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnSalir;
    }
}