namespace CapaCliente.Maestra.BusquedaInv
{
    partial class FrmBuscArticuloxZona
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
            this.rbdescripcion = new System.Windows.Forms.RadioButton();
            this.rbcodigo = new System.Windows.Forms.RadioButton();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.rbdescripcion);
            this.GroupBox1.Controls.Add(this.rbcodigo);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(675, 40);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            // 
            // rbdescripcion
            // 
            this.rbdescripcion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdescripcion.Location = new System.Drawing.Point(570, 14);
            this.rbdescripcion.Name = "rbdescripcion";
            this.rbdescripcion.Size = new System.Drawing.Size(80, 16);
            this.rbdescripcion.TabIndex = 11;
            this.rbdescripcion.Text = "Descripcion";
            // 
            // rbcodigo
            // 
            this.rbcodigo.Checked = true;
            this.rbcodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcodigo.Location = new System.Drawing.Point(498, 12);
            this.rbcodigo.Name = "rbcodigo";
            this.rbcodigo.Size = new System.Drawing.Size(68, 19);
            this.rbcodigo.TabIndex = 10;
            this.rbcodigo.TabStop = true;
            this.rbcodigo.Text = "Codigo";
            // 
            // txtdato
            // 
            this.txtdato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdato.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdato.Location = new System.Drawing.Point(43, 14);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(339, 20);
            this.txtdato.TabIndex = 0;
            this.txtdato.TextChanged += new System.EventHandler(this.txtdato_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(39, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Dato : ";
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvArticulo.Location = new System.Drawing.Point(12, 69);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.Size = new System.Drawing.Size(675, 369);
            this.dgvArticulo.TabIndex = 4;
            this.dgvArticulo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulo_CellContentClick);
            this.dgvArticulo.DoubleClick += new System.EventHandler(this.dgvArticulo_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CODARTI";
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DESARTI";
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DESARTI2";
            this.Column3.HeaderText = "DESARTI2";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // FrmBuscArticuloxZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmBuscArticuloxZona";
            this.Text = "FrmBuscArticuloxZona";
            this.Load += new System.EventHandler(this.FrmBuscArticuloxZona_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton rbdescripcion;
        internal System.Windows.Forms.RadioButton rbcodigo;
        internal System.Windows.Forms.TextBox txtdato;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridView dgvArticulo;
    }
}