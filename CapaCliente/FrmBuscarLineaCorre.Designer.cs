namespace CapaCliente
{
    partial class FrmBuscarLineaCorre
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column7,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(777, 177);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Location = new System.Drawing.Point(31, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 56);
            this.GroupBox1.TabIndex = 14;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "CodEmpresa";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Deslinea";
            this.Column8.HeaderText = "Linea";
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
            // Column5
            // 
            this.Column5.DataPropertyName = "nrofacref";
            this.Column5.HeaderText = "NroFactura2";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "nrobolRef";
            this.Column6.HeaderText = "NroBoleta2";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "EnviaElect";
            this.Column9.HeaderText = "Envio Electronico";
            this.Column9.Name = "Column9";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "LineaCodlinea";
            this.Column7.HeaderText = "LineaCodlinea";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Codempresa";
            this.Column2.HeaderText = "Codempresa";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // FrmBuscarLineaCorre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 271);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmBuscarLineaCorre";
            this.Text = "FrmBuscarLineaCorre";
            this.Load += new System.EventHandler(this.FrmBuscarLineaCorre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtdato;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}