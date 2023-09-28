namespace CapaCliente
{
    partial class FrmBuscClientePrincipalC
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rbruc = new System.Windows.Forms.RadioButton();
            this.rbdireccion = new System.Windows.Forms.RadioButton();
            this.rbdescripcion = new System.Windows.Forms.RadioButton();
            this.rbcodigo = new System.Windows.Forms.RadioButton();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.DGridCli = new System.Windows.Forms.DataGridView();
            this.CODCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATOADJUNTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridCli)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbruc);
            this.GroupBox1.Controls.Add(this.rbdireccion);
            this.GroupBox1.Controls.Add(this.rbdescripcion);
            this.GroupBox1.Controls.Add(this.rbcodigo);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(704, 42);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            // 
            // rbruc
            // 
            this.rbruc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbruc.Location = new System.Drawing.Point(604, 20);
            this.rbruc.Name = "rbruc";
            this.rbruc.Size = new System.Drawing.Size(66, 20);
            this.rbruc.TabIndex = 9;
            this.rbruc.Text = "Ruc";
            // 
            // rbdireccion
            // 
            this.rbdireccion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdireccion.Location = new System.Drawing.Point(528, 20);
            this.rbdireccion.Name = "rbdireccion";
            this.rbdireccion.Size = new System.Drawing.Size(68, 19);
            this.rbdireccion.TabIndex = 8;
            this.rbdireccion.Text = "Direccion";
            // 
            // rbdescripcion
            // 
            this.rbdescripcion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdescripcion.Location = new System.Drawing.Point(434, 20);
            this.rbdescripcion.Name = "rbdescripcion";
            this.rbdescripcion.Size = new System.Drawing.Size(88, 20);
            this.rbdescripcion.TabIndex = 7;
            this.rbdescripcion.Text = "Descripcion";
            // 
            // rbcodigo
            // 
            this.rbcodigo.Checked = true;
            this.rbcodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcodigo.Location = new System.Drawing.Point(360, 18);
            this.rbcodigo.Name = "rbcodigo";
            this.rbcodigo.Size = new System.Drawing.Size(68, 19);
            this.rbcodigo.TabIndex = 6;
            this.rbcodigo.TabStop = true;
            this.rbcodigo.Text = "Codigo";
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(48, 14);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(264, 20);
            this.txtdato.TabIndex = 0;
            this.txtdato.TextChanged += new System.EventHandler(this.txtdato_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Dato : ";
            // 
            // DGridCli
            // 
            this.DGridCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODCLIENTE,
            this.DATOADJUNTO,
            this.DIRECCION,
            this.RUC});
            this.DGridCli.Location = new System.Drawing.Point(27, 77);
            this.DGridCli.Name = "DGridCli";
            this.DGridCli.Size = new System.Drawing.Size(777, 442);
            this.DGridCli.TabIndex = 7;
            this.DGridCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridCli_CellContentClick);
            this.DGridCli.DoubleClick += new System.EventHandler(this.DGridCli_DoubleClick);
            // 
            // CODCLIENTE
            // 
            this.CODCLIENTE.DataPropertyName = "CODCLIENTE";
            this.CODCLIENTE.HeaderText = "CODIGO";
            this.CODCLIENTE.Name = "CODCLIENTE";
            this.CODCLIENTE.Width = 75;
            // 
            // DATOADJUNTO
            // 
            this.DATOADJUNTO.DataPropertyName = "DATOADJUNTO";
            this.DATOADJUNTO.HeaderText = "DESCRIPCION";
            this.DATOADJUNTO.Name = "DATOADJUNTO";
            this.DATOADJUNTO.Width = 300;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "DIRECCION";
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.Width = 250;
            // 
            // RUC
            // 
            this.RUC.DataPropertyName = "RUC";
            this.RUC.HeaderText = "RUC";
            this.RUC.Name = "RUC";
            this.RUC.Width = 75;
            // 
            // FrmBuscClientePrincipalC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 544);
            this.Controls.Add(this.DGridCli);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmBuscClientePrincipalC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Cliente Principal";
            this.Load += new System.EventHandler(this.FrmBuscClientePrincipalC_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rbruc;
        internal System.Windows.Forms.RadioButton rbdireccion;
        internal System.Windows.Forms.RadioButton rbdescripcion;
        internal System.Windows.Forms.RadioButton rbcodigo;
        internal System.Windows.Forms.TextBox txtdato;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridView DGridCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATOADJUNTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUC;
    }
}