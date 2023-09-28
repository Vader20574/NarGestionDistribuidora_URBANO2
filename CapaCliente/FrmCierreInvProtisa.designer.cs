namespace CapaCliente
{
    partial class FrmCierreInvProtisa
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnsele = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 238);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(363, 367);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(84, 54);
            this.btnProcesar.TabIndex = 19;
            this.btnProcesar.Text = "procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnsele
            // 
            this.btnsele.Location = new System.Drawing.Point(602, 30);
            this.btnsele.Name = "btnsele";
            this.btnsele.Size = new System.Drawing.Size(43, 23);
            this.btnsele.TabIndex = 18;
            this.btnsele.Text = "...";
            this.btnsele.UseVisualStyleBackColor = true;
            this.btnsele.Click += new System.EventHandler(this.btnsele_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(159, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Ruta Excel :";
            // 
            // txtruta
            // 
            this.txtruta.Enabled = false;
            this.txtruta.Location = new System.Drawing.Point(239, 31);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(357, 20);
            this.txtruta.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmCierreInvProtisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnsele);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtruta);
            this.Name = "FrmCierreInvProtisa";
            this.Text = "FrmCierreInvProtisa";
            this.Load += new System.EventHandler(this.FrmCierreInvProtisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProcesar;
        internal System.Windows.Forms.Button btnsele;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}