
namespace CapaCliente
{
    partial class FrmCargarCatABCprod
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
            this.btnsele.Location = new System.Drawing.Point(563, 6);
            this.btnsele.Name = "btnsele";
            this.btnsele.Size = new System.Drawing.Size(49, 23);
            this.btnsele.TabIndex = 26;
            this.btnsele.Text = "....";
            this.btnsele.UseVisualStyleBackColor = true;
            this.btnsele.Click += new System.EventHandler(this.btnsele_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Ruta Excel :";
            // 
            // txtruta
            // 
            this.txtruta.Enabled = false;
            this.txtruta.Location = new System.Drawing.Point(105, 9);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(443, 20);
            this.txtruta.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(570, 312);
            this.dataGridView1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmCargarCatABCprod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 425);
            this.Controls.Add(this.btnsele);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FrmCargarCatABCprod";
            this.Text = "Cargar Categorización ABC productos";
            this.Load += new System.EventHandler(this.FrmCargarCatABCprod_Load);
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