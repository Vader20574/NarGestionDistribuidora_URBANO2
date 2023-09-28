namespace CapaCliente
{
    partial class FrmBuscarAnulados
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
            this.DgvDocAnulados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRODOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPODOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtdato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocAnulados)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvDocAnulados
            // 
            this.DgvDocAnulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDocAnulados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NRODOCU,
            this.CODTIPODOC});
            this.DgvDocAnulados.Location = new System.Drawing.Point(29, 102);
            this.DgvDocAnulados.Name = "DgvDocAnulados";
            this.DgvDocAnulados.Size = new System.Drawing.Size(538, 125);
            this.DgvDocAnulados.TabIndex = 7;
            this.DgvDocAnulados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDocAnulados_CellContentClick);
            this.DgvDocAnulados.DoubleClick += new System.EventHandler(this.DgvLinea_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // NRODOCU
            // 
            this.NRODOCU.DataPropertyName = "NRODOCU";
            this.NRODOCU.HeaderText = "NRODOCU";
            this.NRODOCU.Name = "NRODOCU";
            this.NRODOCU.Width = 70;
            // 
            // CODTIPODOC
            // 
            this.CODTIPODOC.DataPropertyName = "CODTIPODOC";
            this.CODTIPODOC.HeaderText = "CODTIPODOC";
            this.CODTIPODOC.Name = "CODTIPODOC";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cmbTipoDoc);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Location = new System.Drawing.Point(29, 29);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(538, 56);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(315, 22);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(133, 21);
            this.cmbTipoDoc.TabIndex = 8;
            this.cmbTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TipoDoc";
            this.label2.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(4, 24);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Dato : ";
            // 
            // txtdato
            // 
            this.txtdato.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdato.Location = new System.Drawing.Point(44, 22);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(208, 21);
            this.txtdato.TabIndex = 0;
            this.txtdato.TextChanged += new System.EventHandler(this.txtdato_TextChanged);
            this.txtdato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdato_KeyDown);
            this.txtdato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdato_KeyPress);
            // 
            // FrmBuscarAnulados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 294);
            this.Controls.Add(this.DgvDocAnulados);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmBuscarAnulados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Documentos Anulados";
            this.Load += new System.EventHandler(this.FrmBuscarAnulados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDocAnulados)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDocAnulados;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRODOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPODOC;
    }
}