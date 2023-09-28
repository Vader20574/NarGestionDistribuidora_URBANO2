namespace CapaCliente
{
    partial class FrmSubEmpresaXLinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubEmpresaXLinea));
            this.label1 = new System.Windows.Forms.Label();
            this.cboSubEmpresa = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkGIDS = new System.Windows.Forms.CheckBox();
            this.cbolinea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sub Empresa  :";
            // 
            // cboSubEmpresa
            // 
            this.cboSubEmpresa.FormattingEnabled = true;
            this.cboSubEmpresa.Location = new System.Drawing.Point(109, 24);
            this.cboSubEmpresa.Name = "cboSubEmpresa";
            this.cboSubEmpresa.Size = new System.Drawing.Size(227, 21);
            this.cboSubEmpresa.TabIndex = 2;
            this.cboSubEmpresa.SelectedIndexChanged += new System.EventHandler(this.cboSubEmpresa_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.chkGIDS);
            this.panel1.Controls.Add(this.cbolinea);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 362);
            this.panel1.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(489, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 26);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(489, 107);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 26);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Id});
            this.dataGridView1.Location = new System.Drawing.Point(9, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 247);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "empresa";
            this.Column1.HeaderText = "Empresa";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "deslinea";
            this.Column2.HeaderText = "Linea";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GIDS";
            this.Column3.HeaderText = "Doc-Imp-Separado";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // chkGIDS
            // 
            this.chkGIDS.AutoSize = true;
            this.chkGIDS.Location = new System.Drawing.Point(71, 56);
            this.chkGIDS.Name = "chkGIDS";
            this.chkGIDS.Size = new System.Drawing.Size(213, 17);
            this.chkGIDS.TabIndex = 8;
            this.chkGIDS.Text = "Genera e Imprime  Documento Separdo";
            this.chkGIDS.UseVisualStyleBackColor = true;
            // 
            // cbolinea
            // 
            this.cbolinea.FormattingEnabled = true;
            this.cbolinea.Items.AddRange(new object[] {
            "GLORIA",
            "PROTISA",
            "SIST PLAST",
            "H&U",
            "ALICORP",
            "HARINA",
            "COLGATE"});
            this.cbolinea.Location = new System.Drawing.Point(71, 16);
            this.cbolinea.Name = "cbolinea";
            this.cbolinea.Size = new System.Drawing.Size(327, 21);
            this.cbolinea.TabIndex = 7;
            this.cbolinea.SelectedIndexChanged += new System.EventHandler(this.cbolinea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Linea  :";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.button3);
            this.GroupBox2.Controls.Add(this.BTNCERRAR);
            this.GroupBox2.Controls.Add(this.BTNMODIFICAR);
            this.GroupBox2.Controls.Add(this.BTNGUARDAR);
            this.GroupBox2.Location = new System.Drawing.Point(628, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(125, 165);
            this.GroupBox2.TabIndex = 62;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mantenimiento ";
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(6, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 45);
            this.button3.TabIndex = 8;
            this.button3.Text = "&Cerrar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.BTNMODIFICAR.Location = new System.Drawing.Point(6, 63);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(90, 45);
            this.BTNMODIFICAR.TabIndex = 2;
            this.BTNMODIFICAR.Text = "&Modificar";
            this.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNGUARDAR.Image")));
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(6, 19);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(90, 45);
            this.BTNGUARDAR.TabIndex = 1;
            this.BTNGUARDAR.Text = "&Guardar";
            this.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNELIMINAR.Image")));
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(643, 290);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(90, 45);
            this.BTNELIMINAR.TabIndex = 3;
            this.BTNELIMINAR.Text = "&Eliminar";
            this.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNELIMINAR.Visible = false;
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(643, 341);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(90, 45);
            this.BTNNUEVO.TabIndex = 7;
            this.BTNNUEVO.Text = "Nuevo";
            this.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVO.UseVisualStyleBackColor = true;
            this.BTNNUEVO.Visible = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // FrmSubEmpresaXLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSubEmpresa);
            this.Name = "FrmSubEmpresaXLinea";
            this.Text = "Mantenimiento de Relacion Sub Empresa - Linea";
            this.Load += new System.EventHandler(this.FrmSubEmpresaXLinea_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSubEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkGIDS;
        private System.Windows.Forms.ComboBox cbolinea;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTNNUEVO;
        internal System.Windows.Forms.Button BTNCERRAR;
        internal System.Windows.Forms.Button BTNMODIFICAR;
        internal System.Windows.Forms.Button BTNELIMINAR;
        internal System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}