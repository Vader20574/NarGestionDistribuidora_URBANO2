namespace CapaCliente
{
    partial class FrmBuscarSubEmpresa
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
            this.Label3 = new System.Windows.Forms.Label();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPedidoRefact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Location = new System.Drawing.Point(30, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 56);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(32, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Dato : ";
            // 
            // txtdato
            // 
            this.txtdato.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdato.Location = new System.Drawing.Point(72, 22);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(208, 21);
            this.txtdato.TabIndex = 0;
            // 
            // RadioButton1
            // 
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(328, 24);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(64, 16);
            this.RadioButton1.TabIndex = 11;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Código ";
            // 
            // RadioButton2
            // 
            this.RadioButton2.Location = new System.Drawing.Point(416, 24);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(88, 16);
            this.RadioButton2.TabIndex = 12;
            this.RadioButton2.Text = "Linea";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column10,
            this.Column5,
            this.Column6,
            this.NroPedidoRefact,
            this.Column9,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(11, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 177);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Nombre";
            this.Column8.HeaderText = "Nombre";
            this.Column8.Name = "Column8";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nrofac";
            this.Column3.HeaderText = "NroFactura";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "nrobol";
            this.Column4.HeaderText = "NroBoleta";
            this.Column4.Name = "Column4";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "nroped";
            this.Column10.HeaderText = "NroPedido";
            this.Column10.Name = "Column10";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nrofacRef";
            this.Column5.HeaderText = "NroFactura2";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nrobolRef";
            this.Column6.HeaderText = "NroBoleta2";
            this.Column6.Name = "Column6";
            // 
            // NroPedidoRefact
            // 
            this.NroPedidoRefact.DataPropertyName = "nropedRef";
            this.NroPedidoRefact.HeaderText = "NroPedido2";
            this.NroPedidoRefact.Name = "NroPedidoRefact";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "EDESE";
            this.Column9.HeaderText = "EDESE";
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NGIE";
            this.Column2.HeaderText = "NGIE";
            this.Column2.Name = "Column2";
            // 
            // FrmBuscarSubEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 319);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmBuscarSubEmpresa";
            this.Text = "FrmBuscarSubEmpresa";
            this.Load += new System.EventHandler(this.FrmBuscarSubEmpresa_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtdato;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPedidoRefact;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}