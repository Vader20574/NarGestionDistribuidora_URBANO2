
namespace CapaCliente
{
    partial class FrmSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupervisor));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.btnBusqSupervisor = new System.Windows.Forms.Button();
            this.DgvSupervrxVend = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODSUPERVISOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DSVEND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCorrelBol = new System.Windows.Forms.TextBox();
            this.txtCorrelFact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorrelBolRef = new System.Windows.Forms.TextBox();
            this.txtCorrelFactRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkGIEF = new System.Windows.Forms.CheckBox();
            this.chkEDESE = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGIEB = new System.Windows.Forms.CheckBox();
            this.txtCorrelNp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorrelNpRef = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSupervrxVend)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(122, 14);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(192, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Supervisor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Supervisor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vendedor:";
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(122, 42);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(191, 20);
            this.txtSupervisor.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(121, 66);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(193, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // cboVendedor
            // 
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(78, 12);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(245, 21);
            this.cboVendedor.TabIndex = 7;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.button1);
            this.GroupBox2.Controls.Add(this.BTNNUEVO);
            this.GroupBox2.Controls.Add(this.BTNCERRAR);
            this.GroupBox2.Controls.Add(this.BTNMODIFICAR);
            this.GroupBox2.Controls.Add(this.BTNELIMINAR);
            this.GroupBox2.Controls.Add(this.BTNGUARDAR);
            this.GroupBox2.Location = new System.Drawing.Point(551, 32);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(125, 267);
            this.GroupBox2.TabIndex = 63;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mantenimiento ";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(14, 19);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(90, 45);
            this.BTNNUEVO.TabIndex = 7;
            this.BTNNUEVO.Text = "Nuevo";
            this.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVO.UseVisualStyleBackColor = true;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // BTNCERRAR
            // 
            this.BTNCERRAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCERRAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNCERRAR.Image")));
            this.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCERRAR.Location = new System.Drawing.Point(15, 329);
            this.BTNCERRAR.Name = "BTNCERRAR";
            this.BTNCERRAR.Size = new System.Drawing.Size(90, 45);
            this.BTNCERRAR.TabIndex = 6;
            this.BTNCERRAR.Text = "&Cerrar";
            this.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNMODIFICAR.Image")));
            this.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMODIFICAR.Location = new System.Drawing.Point(15, 107);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(90, 45);
            this.BTNMODIFICAR.TabIndex = 2;
            this.BTNMODIFICAR.Text = "&Modificar";
            this.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNELIMINAR.Image")));
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(14, 152);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(90, 45);
            this.BTNELIMINAR.TabIndex = 3;
            this.BTNELIMINAR.Text = "&Eliminar";
            this.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNGUARDAR.Image")));
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(15, 63);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(90, 45);
            this.BTNGUARDAR.TabIndex = 1;
            this.BTNGUARDAR.Text = "&Guardar";
            this.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // btnBusqSupervisor
            // 
            this.btnBusqSupervisor.ImageIndex = 5;
            this.btnBusqSupervisor.Location = new System.Drawing.Point(320, 14);
            this.btnBusqSupervisor.Name = "btnBusqSupervisor";
            this.btnBusqSupervisor.Size = new System.Drawing.Size(30, 22);
            this.btnBusqSupervisor.TabIndex = 64;
            this.btnBusqSupervisor.Click += new System.EventHandler(this.btnBusqSupervisor_Click);
            // 
            // DgvSupervrxVend
            // 
            this.DgvSupervrxVend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSupervrxVend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CODEMPRESA,
            this.CODSUPERVISOR,
            this.codigo,
            this.DSVEND});
            this.DgvSupervrxVend.Location = new System.Drawing.Point(15, 46);
            this.DgvSupervrxVend.Name = "DgvSupervrxVend";
            this.DgvSupervrxVend.Size = new System.Drawing.Size(409, 125);
            this.DgvSupervrxVend.TabIndex = 65;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // CODEMPRESA
            // 
            this.CODEMPRESA.DataPropertyName = "Codempresa";
            this.CODEMPRESA.HeaderText = "CODEMPRESA";
            this.CODEMPRESA.Name = "CODEMPRESA";
            this.CODEMPRESA.Visible = false;
            // 
            // CODSUPERVISOR
            // 
            this.CODSUPERVISOR.DataPropertyName = "Codsupervisor";
            this.CODSUPERVISOR.HeaderText = "CODSUPERVISOR";
            this.CODSUPERVISOR.Name = "CODSUPERVISOR";
            this.CODSUPERVISOR.Visible = false;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "Codvendedor";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.Width = 70;
            // 
            // DSVEND
            // 
            this.DSVEND.DataPropertyName = "Dsvend";
            this.DSVEND.HeaderText = "DESCRIPCION";
            this.DSVEND.Name = "DSVEND";
            this.DSVEND.Width = 280;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(440, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 26);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(440, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 26);
            this.btnAgregar.TabIndex = 66;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DgvSupervrxVend);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.cboVendedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 202);
            this.panel1.TabIndex = 68;
            // 
            // txtCorrelBol
            // 
            this.txtCorrelBol.Location = new System.Drawing.Point(208, 140);
            this.txtCorrelBol.Name = "txtCorrelBol";
            this.txtCorrelBol.Size = new System.Drawing.Size(105, 20);
            this.txtCorrelBol.TabIndex = 72;
            // 
            // txtCorrelFact
            // 
            this.txtCorrelFact.Location = new System.Drawing.Point(208, 117);
            this.txtCorrelFact.Name = "txtCorrelFact";
            this.txtCorrelFact.Size = new System.Drawing.Size(105, 20);
            this.txtCorrelFact.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Correlativo Boleta   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Correlativo Factura :";
            // 
            // txtCorrelBolRef
            // 
            this.txtCorrelBolRef.Location = new System.Drawing.Point(209, 215);
            this.txtCorrelBolRef.Name = "txtCorrelBolRef";
            this.txtCorrelBolRef.Size = new System.Drawing.Size(105, 20);
            this.txtCorrelBolRef.TabIndex = 76;
            // 
            // txtCorrelFactRef
            // 
            this.txtCorrelFactRef.Location = new System.Drawing.Point(209, 190);
            this.txtCorrelFactRef.Name = "txtCorrelFactRef";
            this.txtCorrelFactRef.Size = new System.Drawing.Size(105, 20);
            this.txtCorrelFactRef.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Correlativo Boleta Refacturacion   :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Correlativo Factura Refacturacion  :";
            // 
            // chkGIEF
            // 
            this.chkGIEF.AutoSize = true;
            this.chkGIEF.Location = new System.Drawing.Point(20, 42);
            this.chkGIEF.Name = "chkGIEF";
            this.chkGIEF.Size = new System.Drawing.Size(214, 17);
            this.chkGIEF.TabIndex = 3;
            this.chkGIEF.Text = "Genera Informacion Electronica Factura";
            this.chkGIEF.UseVisualStyleBackColor = true;
            this.chkGIEF.CheckedChanged += new System.EventHandler(this.chkNGIE_CheckedChanged);
            // 
            // chkEDESE
            // 
            this.chkEDESE.AutoSize = true;
            this.chkEDESE.Location = new System.Drawing.Point(20, 19);
            this.chkEDESE.Name = "chkEDESE";
            this.chkEDESE.Size = new System.Drawing.Size(261, 17);
            this.chkEDESE.TabIndex = 2;
            this.chkEDESE.Text = "Envia Documentos Electronicos Servidor Externo ";
            this.chkEDESE.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGIEB);
            this.groupBox1.Controls.Add(this.chkGIEF);
            this.groupBox1.Controls.Add(this.chkEDESE);
            this.groupBox1.Location = new System.Drawing.Point(18, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 95);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            // 
            // chkGIEB
            // 
            this.chkGIEB.AutoSize = true;
            this.chkGIEB.Location = new System.Drawing.Point(20, 65);
            this.chkGIEB.Name = "chkGIEB";
            this.chkGIEB.Size = new System.Drawing.Size(208, 17);
            this.chkGIEB.TabIndex = 4;
            this.chkGIEB.Text = "Genera Informacion Electronica Boleta";
            this.chkGIEB.UseVisualStyleBackColor = true;
            // 
            // txtCorrelNp
            // 
            this.txtCorrelNp.Location = new System.Drawing.Point(208, 163);
            this.txtCorrelNp.Name = "txtCorrelNp";
            this.txtCorrelNp.Size = new System.Drawing.Size(105, 20);
            this.txtCorrelNp.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Correlativo Nota Pedido :";
            // 
            // txtCorrelNpRef
            // 
            this.txtCorrelNpRef.Location = new System.Drawing.Point(209, 240);
            this.txtCorrelNpRef.Name = "txtCorrelNpRef";
            this.txtCorrelNpRef.Size = new System.Drawing.Size(105, 20);
            this.txtCorrelNpRef.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Correlativo Nota Pedido Refacturacion ";
            // 
            // FrmSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 597);
            this.Controls.Add(this.txtCorrelNpRef);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCorrelNp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCorrelBolRef);
            this.Controls.Add(this.txtCorrelFactRef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorrelBol);
            this.Controls.Add(this.txtCorrelFact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBusqSupervisor);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtSupervisor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSupervisor";
            this.Text = "FrmSupervisor";
            this.Load += new System.EventHandler(this.FrmSupervisor_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSupervrxVend)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSupervisor;
        public System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cboVendedor;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNNUEVO;
        internal System.Windows.Forms.Button BTNCERRAR;
        internal System.Windows.Forms.Button BTNMODIFICAR;
        internal System.Windows.Forms.Button BTNELIMINAR;
        internal System.Windows.Forms.Button BTNGUARDAR;
        internal System.Windows.Forms.Button btnBusqSupervisor;
        public System.Windows.Forms.DataGridView DgvSupervrxVend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODSUPERVISOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSVEND;
        public System.Windows.Forms.TextBox txtCorrelBol;
        public System.Windows.Forms.TextBox txtCorrelFact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCorrelBolRef;
        public System.Windows.Forms.TextBox txtCorrelFactRef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.CheckBox chkGIEF;
        public System.Windows.Forms.CheckBox chkEDESE;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox chkGIEB;
        internal System.Windows.Forms.TextBox txtCorrelNp;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtCorrelNpRef;
        private System.Windows.Forms.Label label10;
    }
}