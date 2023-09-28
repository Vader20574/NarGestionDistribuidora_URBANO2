namespace GenbetaDevLinqToExcel
{
    partial class FrmImportarExcel
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsele = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnsele
            // 
            this.btnsele.Location = new System.Drawing.Point(459, 21);
            this.btnsele.Name = "btnsele";
            this.btnsele.Size = new System.Drawing.Size(43, 23);
            this.btnsele.TabIndex = 10;
            this.btnsele.Text = "...";
            this.btnsele.UseVisualStyleBackColor = true;
            this.btnsele.Click += new System.EventHandler(this.btnsele_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Ruta Excel :";
            // 
            // txtruta
            // 
            this.txtruta.Enabled = false;
            this.txtruta.Location = new System.Drawing.Point(96, 22);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(357, 20);
            this.txtruta.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 366);
            this.Controls.Add(this.btnsele);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FrmImportarExcel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnsele;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

