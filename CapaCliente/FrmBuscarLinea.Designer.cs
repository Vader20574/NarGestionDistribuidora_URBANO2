namespace CapaCliente
{
    partial class FrmBuscarLinea
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.DgvLinea = new System.Windows.Forms.DataGridView();
            this.CODLINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESLINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPOPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORRELATIVO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLinea)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Location = new System.Drawing.Point(64, 11);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(516, 56);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, -2);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "F1 [Filtrar]";
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
            this.txtdato.TextChanged += new System.EventHandler(this.txtdato_TextChanged);
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
            this.RadioButton2.Text = "Categoria";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvLinea
            // 
            this.DgvLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLinea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODLINEA,
            this.DESLINEA,
            this.CODTIPOPROD,
            this.CORRELATIVO,
            this.ESTADO,
            this.EMPRESA});
            this.DgvLinea.Location = new System.Drawing.Point(64, 100);
            this.DgvLinea.Name = "DgvLinea";
            this.DgvLinea.Size = new System.Drawing.Size(538, 125);
            this.DgvLinea.TabIndex = 5;
            this.DgvLinea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLinea_CellContentClick);
            this.DgvLinea.DoubleClick += new System.EventHandler(this.DgvLinea_DoubleClick);
            // 
            // CODLINEA
            // 
            this.CODLINEA.DataPropertyName = "CODLINEA";
            this.CODLINEA.HeaderText = "CODIGO";
            this.CODLINEA.Name = "CODLINEA";
            this.CODLINEA.Width = 70;
            // 
            // DESLINEA
            // 
            this.DESLINEA.DataPropertyName = "DESLINEA";
            this.DESLINEA.HeaderText = "DESCRIPCION";
            this.DESLINEA.Name = "DESLINEA";
            // 
            // CODTIPOPROD
            // 
            this.CODTIPOPROD.DataPropertyName = "CODTIPOPROD";
            this.CODTIPOPROD.HeaderText = "CODTIPOPROD";
            this.CODTIPOPROD.Name = "CODTIPOPROD";
            this.CODTIPOPROD.Visible = false;
            // 
            // CORRELATIVO
            // 
            this.CORRELATIVO.DataPropertyName = "CORRELATIVO";
            this.CORRELATIVO.HeaderText = "CORRELATIVO";
            this.CORRELATIVO.Name = "CORRELATIVO";
            this.CORRELATIVO.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Visible = false;
            this.ESTADO.Width = 5;
            // 
            // EMPRESA
            // 
            this.EMPRESA.DataPropertyName = "CODEMPRESA";
            this.EMPRESA.HeaderText = "EMPRESA";
            this.EMPRESA.Name = "EMPRESA";
            this.EMPRESA.Visible = false;
            this.EMPRESA.Width = 5;
            // 
            // FrmBuscarLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 315);
            this.Controls.Add(this.DgvLinea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmBuscarLinea";
            this.Text = "FrmBuscarLinea";
            this.Load += new System.EventHandler(this.FrmBuscarLinea_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLinea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtdato;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODLINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESLINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPOPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORRELATIVO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
    }
}