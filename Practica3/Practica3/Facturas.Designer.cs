namespace Practica3
{
    partial class Facturas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPlatillosFactura = new System.Windows.Forms.DataGridView();
            this.gbRegistroEmpleado = new System.Windows.Forms.GroupBox();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpHoraPedido = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSerieFactura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatillosFactura)).BeginInit();
            this.gbRegistroEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 25);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPlatillosFactura);
            this.panel2.Controls.Add(this.gbRegistroEmpleado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 567);
            this.panel2.TabIndex = 1;
            // 
            // dgvPlatillosFactura
            // 
            this.dgvPlatillosFactura.AllowUserToAddRows = false;
            this.dgvPlatillosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatillosFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPlatillosFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPlatillosFactura.Location = new System.Drawing.Point(0, 353);
            this.dgvPlatillosFactura.Name = "dgvPlatillosFactura";
            this.dgvPlatillosFactura.ReadOnly = true;
            this.dgvPlatillosFactura.RowHeadersVisible = false;
            this.dgvPlatillosFactura.Size = new System.Drawing.Size(729, 214);
            this.dgvPlatillosFactura.TabIndex = 5;
            // 
            // gbRegistroEmpleado
            // 
            this.gbRegistroEmpleado.Controls.Add(this.btnGenerarFactura);
            this.gbRegistroEmpleado.Controls.Add(this.txtNumeroFactura);
            this.gbRegistroEmpleado.Controls.Add(this.label13);
            this.gbRegistroEmpleado.Controls.Add(this.dtpHoraPedido);
            this.gbRegistroEmpleado.Controls.Add(this.dtpFechaPedido);
            this.gbRegistroEmpleado.Controls.Add(this.label11);
            this.gbRegistroEmpleado.Controls.Add(this.txtSerieFactura);
            this.gbRegistroEmpleado.Controls.Add(this.label10);
            this.gbRegistroEmpleado.Controls.Add(this.label7);
            this.gbRegistroEmpleado.Controls.Add(this.txtDireccion);
            this.gbRegistroEmpleado.Controls.Add(this.label6);
            this.gbRegistroEmpleado.Controls.Add(this.txtTotalFactura);
            this.gbRegistroEmpleado.Controls.Add(this.label5);
            this.gbRegistroEmpleado.Controls.Add(this.txtNit);
            this.gbRegistroEmpleado.Controls.Add(this.label4);
            this.gbRegistroEmpleado.Controls.Add(this.txtNombre);
            this.gbRegistroEmpleado.Controls.Add(this.label3);
            this.gbRegistroEmpleado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistroEmpleado.ForeColor = System.Drawing.Color.White;
            this.gbRegistroEmpleado.Location = new System.Drawing.Point(12, 64);
            this.gbRegistroEmpleado.Name = "gbRegistroEmpleado";
            this.gbRegistroEmpleado.Size = new System.Drawing.Size(705, 280);
            this.gbRegistroEmpleado.TabIndex = 4;
            this.gbRegistroEmpleado.TabStop = false;
            this.gbRegistroEmpleado.Text = "Agregar Facturas:";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.Location = new System.Drawing.Point(269, 227);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(168, 35);
            this.btnGenerarFactura.TabIndex = 34;
            this.btnGenerarFactura.Text = "Generar Factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(152, 21);
            this.txtNumeroFactura.MaxLength = 7;
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(102, 22);
            this.txtNumeroFactura.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Número de Factura:";
            // 
            // dtpHoraPedido
            // 
            this.dtpHoraPedido.CustomFormat = "";
            this.dtpHoraPedido.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraPedido.Location = new System.Drawing.Point(145, 139);
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
            this.dtpFechaPedido.Location = new System.Drawing.Point(422, 139);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFechaPedido.Size = new System.Drawing.Size(111, 22);
            this.dtpFechaPedido.TabIndex = 22;
            this.dtpFechaPedido.Value = new System.DateTime(2020, 5, 9, 16, 7, 19, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(289, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fecha del Pedido:";
            // 
            // txtSerieFactura
            // 
            this.txtSerieFactura.Location = new System.Drawing.Point(375, 21);
            this.txtSerieFactura.MaxLength = 7;
            this.txtSerieFactura.Name = "txtSerieFactura";
            this.txtSerieFactura.Size = new System.Drawing.Size(117, 22);
            this.txtSerieFactura.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Serie Factura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hora del Pedido:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(179, 98);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(334, 22);
            this.txtDireccion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dirección de Entrega:";
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(179, 183);
            this.txtTotalFactura.MaxLength = 8;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(165, 22);
            this.txtTotalFactura.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total de la Factura:  Q.";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(62, 60);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(93, 22);
            this.txtNit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "NIT:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(249, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Generar Factura";
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "IdPedido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Chef";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "SubTotal";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(729, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatillosFactura)).EndInit();
            this.gbRegistroEmpleado.ResumeLayout(false);
            this.gbRegistroEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRegistroEmpleado;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpHoraPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSerieFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dgvPlatillosFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}