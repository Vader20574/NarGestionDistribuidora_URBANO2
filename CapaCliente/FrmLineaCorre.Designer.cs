namespace CapaCliente
{
    partial class FrmLineaCorre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLineaCorre));
            this.txtnrobolref = new System.Windows.Forms.TextBox();
            this.txtnrofacref = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEnviarElect = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.btnBusqPromo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbolinea = new System.Windows.Forms.ComboBox();
            this.txtnrofac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnrobol = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnrobolref
            // 
            this.txtnrobolref.Location = new System.Drawing.Point(108, 118);
            this.txtnrobolref.Name = "txtnrobolref";
            this.txtnrobolref.Size = new System.Drawing.Size(149, 20);
            this.txtnrobolref.TabIndex = 3;
            // 
            // txtnrofacref
            // 
            this.txtnrofacref.Location = new System.Drawing.Point(108, 141);
            this.txtnrofacref.Name = "txtnrofacref";
            this.txtnrofacref.Size = new System.Drawing.Size(149, 20);
            this.txtnrofacref.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero Boleta 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero Factura 2:";
            // 
            // chkEnviarElect
            // 
            this.chkEnviarElect.AutoSize = true;
            this.chkEnviarElect.Location = new System.Drawing.Point(108, 167);
            this.chkEnviarElect.Name = "chkEnviarElect";
            this.chkEnviarElect.Size = new System.Drawing.Size(112, 17);
            this.chkEnviarElect.TabIndex = 10;
            this.chkEnviarElect.Text = "Enviar Electronico";
            this.chkEnviarElect.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.button1);
            this.GroupBox2.Controls.Add(this.BTNNUEVO);
            this.GroupBox2.Controls.Add(this.BTNCERRAR);
            this.GroupBox2.Controls.Add(this.BTNMODIFICAR);
            this.GroupBox2.Controls.Add(this.BTNELIMINAR);
            this.GroupBox2.Controls.Add(this.BTNGUARDAR);
            this.GroupBox2.Location = new System.Drawing.Point(348, 31);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(125, 267);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mantenimiento ";
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(15, 19);
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
            // btnBusqPromo
            // 
            this.btnBusqPromo.ImageIndex = 5;
            this.btnBusqPromo.Location = new System.Drawing.Point(186, 21);
            this.btnBusqPromo.Name = "btnBusqPromo";
            this.btnBusqPromo.Size = new System.Drawing.Size(30, 22);
            this.btnBusqPromo.TabIndex = 20;
            this.btnBusqPromo.Click += new System.EventHandler(this.btnBusqPromo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbolinea);
            this.groupBox1.Controls.Add(this.txtnrofac);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBusqPromo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkEnviarElect);
            this.groupBox1.Controls.Add(this.txtnrobol);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtnrofacref);
            this.groupBox1.Controls.Add(this.txtnrobolref);
            this.groupBox1.Location = new System.Drawing.Point(40, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 221);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbolinea
            // 
            this.cbolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbolinea.ItemHeight = 13;
            this.cbolinea.Location = new System.Drawing.Point(108, 43);
            this.cbolinea.Name = "cbolinea";
            this.cbolinea.Size = new System.Drawing.Size(188, 21);
            this.cbolinea.TabIndex = 26;
            // 
            // txtnrofac
            // 
            this.txtnrofac.BackColor = System.Drawing.Color.White;
            this.txtnrofac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnrofac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtnrofac.Location = new System.Drawing.Point(108, 92);
            this.txtnrofac.Name = "txtnrofac";
            this.txtnrofac.Size = new System.Drawing.Size(149, 20);
            this.txtnrofac.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Linea:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Numero Factura:";
            // 
            // txtnrobol
            // 
            this.txtnrobol.BackColor = System.Drawing.Color.White;
            this.txtnrobol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnrobol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtnrobol.Location = new System.Drawing.Point(108, 68);
            this.txtnrobol.Name = "txtnrobol";
            this.txtnrobol.Size = new System.Drawing.Size(149, 20);
            this.txtnrobol.TabIndex = 18;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtId.Location = new System.Drawing.Point(108, 21);
            this.txtId.MaxLength = 4;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(72, 20);
            this.txtId.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numero Boleta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Id :";
            // 
            // FrmLineaCorre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 325);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Name = "FrmLineaCorre";
            this.Text = "FrmLineaCorre";
            this.Load += new System.EventHandler(this.FrmLineaCorre_Load);
            this.GroupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button BTNNUEVO;
        internal System.Windows.Forms.Button BTNCERRAR;
        internal System.Windows.Forms.Button BTNMODIFICAR;
        internal System.Windows.Forms.Button BTNELIMINAR;
        internal System.Windows.Forms.Button BTNGUARDAR;
        internal System.Windows.Forms.Button btnBusqPromo;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtnrobol;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtnrobolref;
        internal System.Windows.Forms.TextBox txtnrofacref;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox chkEnviarElect;
        internal System.Windows.Forms.TextBox txtnrofac;
        internal System.Windows.Forms.ComboBox cbolinea;
        internal System.Windows.Forms.Button button1;
    }
}