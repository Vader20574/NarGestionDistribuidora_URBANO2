namespace CapaCliente
{
    partial class FrmJefeEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJefeEquipo));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombJefe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatoPerso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.dgvJefeEquipo = new System.Windows.Forms.DataGridView();
            this.cbEquipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnreporte = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJefeEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(115, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(158, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombJefe
            // 
            this.txtNombJefe.Location = new System.Drawing.Point(115, 51);
            this.txtNombJefe.Name = "txtNombJefe";
            this.txtNombJefe.Size = new System.Drawing.Size(158, 20);
            this.txtNombJefe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Jefe";
            // 
            // txtDatoPerso
            // 
            this.txtDatoPerso.Location = new System.Drawing.Point(115, 78);
            this.txtDatoPerso.Name = "txtDatoPerso";
            this.txtDatoPerso.Size = new System.Drawing.Size(158, 20);
            this.txtDatoPerso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datos Personales";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.BTNNUEVO);
            this.GroupBox2.Controls.Add(this.BTNCERRAR);
            this.GroupBox2.Controls.Add(this.BTNMODIFICAR);
            this.GroupBox2.Controls.Add(this.BTNELIMINAR);
            this.GroupBox2.Controls.Add(this.BTNGUARDAR);
            this.GroupBox2.Location = new System.Drawing.Point(673, 19);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(125, 260);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mantenimiento ";
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
            this.BTNCERRAR.Location = new System.Drawing.Point(14, 203);
            this.BTNCERRAR.Name = "BTNCERRAR";
            this.BTNCERRAR.Size = new System.Drawing.Size(90, 45);
            this.BTNCERRAR.TabIndex = 6;
            this.BTNCERRAR.Text = "&Cerrar";
            this.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNCERRAR.Click += new System.EventHandler(this.BTNCERRAR_Click);
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
            // dgvJefeEquipo
            // 
            this.dgvJefeEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJefeEquipo.Location = new System.Drawing.Point(21, 198);
            this.dgvJefeEquipo.Name = "dgvJefeEquipo";
            this.dgvJefeEquipo.Size = new System.Drawing.Size(646, 197);
            this.dgvJefeEquipo.TabIndex = 55;
            this.dgvJefeEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipo_CellContentClick);
            this.dgvJefeEquipo.DoubleClick += new System.EventHandler(this.dgvEquipo_DoubleClick);
            // 
            // cbEquipo
            // 
            this.cbEquipo.FormattingEnabled = true;
            this.cbEquipo.Location = new System.Drawing.Point(115, 105);
            this.cbEquipo.Name = "cbEquipo";
            this.cbEquipo.Size = new System.Drawing.Size(223, 21);
            this.cbEquipo.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Equipo";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Location = new System.Drawing.Point(115, 132);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(223, 20);
            this.dtpFechaIni.TabIndex = 60;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(114, 162);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(224, 20);
            this.dtpFin.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Fecha Ini";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Fecha Fin";
            // 
            // btnreporte
            // 
            this.btnreporte.Image = ((System.Drawing.Image)(resources.GetObject("btnreporte.Image")));
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(688, 304);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(90, 45);
            this.btnreporte.TabIndex = 64;
            this.btnreporte.Text = "&Reporte";
            this.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // FrmJefeEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 407);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEquipo);
            this.Controls.Add(this.dgvJefeEquipo);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatoPerso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombJefe);
            this.Controls.Add(this.txtCodigo);
            this.Name = "FrmJefeEquipo";
            this.Text = "Jefe de Equipo";
            this.Load += new System.EventHandler(this.FrmEquipo_Load);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJefeEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombJefe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatoPerso;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button BTNNUEVO;
        internal System.Windows.Forms.Button BTNCERRAR;
        internal System.Windows.Forms.Button BTNMODIFICAR;
        internal System.Windows.Forms.Button BTNELIMINAR;
        internal System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.DataGridView dgvJefeEquipo;
        private System.Windows.Forms.ComboBox cbEquipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button btnreporte;
    }
}