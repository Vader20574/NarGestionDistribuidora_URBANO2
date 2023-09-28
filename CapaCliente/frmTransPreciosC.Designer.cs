namespace CapaCliente
{
    partial class frmTransPreciosC
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnsele = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1091, 312);
            this.dataGridView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnsele
            // 
            this.btnsele.Location = new System.Drawing.Point(569, 9);
            this.btnsele.Name = "btnsele";
            this.btnsele.Size = new System.Drawing.Size(43, 23);
            this.btnsele.TabIndex = 21;
            this.btnsele.Text = "....";
            this.btnsele.UseVisualStyleBackColor = true;
            this.btnsele.Click += new System.EventHandler(this.btnsele_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Ruta Excel :";
            // 
            // txtruta
            // 
            this.txtruta.Enabled = false;
            this.txtruta.Location = new System.Drawing.Point(111, 12);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(437, 20);
            this.txtruta.TabIndex = 19;
            // 
            // frmTransPreciosC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 441);
            this.Controls.Add(this.btnsele);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "frmTransPreciosC";
            this.Text = "Importar Precios";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button btnsele;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtruta;
    }
}