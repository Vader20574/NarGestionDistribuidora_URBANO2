namespace CapaCliente
{
    partial class FrmCierreInvGloria
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
            this.btnsele = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsele
            // 
            this.btnsele.Location = new System.Drawing.Point(578, 22);
            this.btnsele.Name = "btnsele";
            this.btnsele.Size = new System.Drawing.Size(43, 23);
            this.btnsele.TabIndex = 13;
            this.btnsele.Text = "...";
            this.btnsele.UseVisualStyleBackColor = true;
            this.btnsele.Click += new System.EventHandler(this.btnsele_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(135, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Ruta Excel :";
            // 
            // txtruta
            // 
            this.txtruta.Enabled = false;
            this.txtruta.Location = new System.Drawing.Point(214, 23);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(357, 20);
            this.txtruta.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 238);
            this.dataGridView1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmCierreInvGloria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsele);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtruta);
            this.Name = "FrmCierreInvGloria";
            this.Text = "FrmCierreInvGloria";
            this.Load += new System.EventHandler(this.FrmCierreInvGloria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnsele;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}