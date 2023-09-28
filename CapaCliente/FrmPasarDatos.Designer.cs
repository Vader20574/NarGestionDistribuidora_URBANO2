namespace CapaCliente
{
    partial class FrmPasarDatos
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
            this.btnPasar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPasar
            // 
            this.btnPasar.Location = new System.Drawing.Point(109, 42);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(195, 62);
            this.btnPasar.TabIndex = 0;
            this.btnPasar.Text = "Pasar";
            this.btnPasar.UseVisualStyleBackColor = true;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);
            // 
            // FrmPasarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 144);
            this.Controls.Add(this.btnPasar);
            this.Name = "FrmPasarDatos";
            this.Text = "FrmPasarDatos";
            this.Load += new System.EventHandler(this.FrmPasarDatos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPasar;
    }
}