namespace CapaCliente
{
    partial class FrmPedidoxVendedor
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnpassizt = new System.Windows.Forms.Button();
            this.btnpassiz = new System.Windows.Forms.Button();
            this.btnpasde = new System.Windows.Forms.Button();
            this.btnpasdet = new System.Windows.Forms.Button();
            this.lbvende2 = new System.Windows.Forms.ListBox();
            this.lbvende1 = new System.Windows.Forms.ListBox();
            this.dtpfechaH = new System.Windows.Forms.DateTimePicker();
            this.dtpfechaD = new System.Windows.Forms.DateTimePicker();
            this.Label17 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnpassizt);
            this.GroupBox2.Controls.Add(this.btnpassiz);
            this.GroupBox2.Controls.Add(this.btnpasde);
            this.GroupBox2.Controls.Add(this.btnpasdet);
            this.GroupBox2.Controls.Add(this.lbvende2);
            this.GroupBox2.Controls.Add(this.lbvende1);
            this.GroupBox2.Location = new System.Drawing.Point(48, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(657, 280);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Vendedores";
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // btnpassizt
            // 
            this.btnpassizt.Location = new System.Drawing.Point(295, 135);
            this.btnpassizt.Name = "btnpassizt";
            this.btnpassizt.Size = new System.Drawing.Size(65, 23);
            this.btnpassizt.TabIndex = 1;
            this.btnpassizt.Text = "<<";
            this.btnpassizt.UseVisualStyleBackColor = true;
            this.btnpassizt.Click += new System.EventHandler(this.btnpassizt_Click);
            // 
            // btnpassiz
            // 
            this.btnpassiz.Location = new System.Drawing.Point(295, 100);
            this.btnpassiz.Name = "btnpassiz";
            this.btnpassiz.Size = new System.Drawing.Size(65, 23);
            this.btnpassiz.TabIndex = 1;
            this.btnpassiz.Text = "<";
            this.btnpassiz.UseVisualStyleBackColor = true;
            this.btnpassiz.Click += new System.EventHandler(this.btnpassiz_Click);
            // 
            // btnpasde
            // 
            this.btnpasde.Location = new System.Drawing.Point(295, 65);
            this.btnpasde.Name = "btnpasde";
            this.btnpasde.Size = new System.Drawing.Size(65, 23);
            this.btnpasde.TabIndex = 1;
            this.btnpasde.Text = ">";
            this.btnpasde.UseVisualStyleBackColor = true;
            this.btnpasde.Click += new System.EventHandler(this.btnpasde_Click);
            // 
            // btnpasdet
            // 
            this.btnpasdet.Location = new System.Drawing.Point(295, 30);
            this.btnpasdet.Name = "btnpasdet";
            this.btnpasdet.Size = new System.Drawing.Size(65, 23);
            this.btnpasdet.TabIndex = 1;
            this.btnpasdet.Text = ">>";
            this.btnpasdet.UseVisualStyleBackColor = true;
            this.btnpasdet.Click += new System.EventHandler(this.btnpasdet_Click);
            // 
            // lbvende2
            // 
            this.lbvende2.FormattingEnabled = true;
            this.lbvende2.Location = new System.Drawing.Point(377, 19);
            this.lbvende2.Name = "lbvende2";
            this.lbvende2.Size = new System.Drawing.Size(260, 238);
            this.lbvende2.TabIndex = 0;
            // 
            // lbvende1
            // 
            this.lbvende1.FormattingEnabled = true;
            this.lbvende1.Location = new System.Drawing.Point(17, 19);
            this.lbvende1.Name = "lbvende1";
            this.lbvende1.Size = new System.Drawing.Size(252, 238);
            this.lbvende1.TabIndex = 0;
            // 
            // dtpfechaH
            // 
            this.dtpfechaH.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaH.Location = new System.Drawing.Point(408, 318);
            this.dtpfechaH.Name = "dtpfechaH";
            this.dtpfechaH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpfechaH.Size = new System.Drawing.Size(82, 20);
            this.dtpfechaH.TabIndex = 16;
            // 
            // dtpfechaD
            // 
            this.dtpfechaD.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaD.Location = new System.Drawing.Point(305, 318);
            this.dtpfechaD.Name = "dtpfechaD";
            this.dtpfechaD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpfechaD.Size = new System.Drawing.Size(82, 20);
            this.dtpfechaD.TabIndex = 15;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(237, 321);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(50, 13);
            this.Label17.TabIndex = 14;
            this.Label17.Text = "Fecha :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 548);
            this.Controls.Add(this.dtpfechaH);
            this.Controls.Add(this.dtpfechaD);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Reporte Pedido por Vendedor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnpassizt;
        internal System.Windows.Forms.Button btnpassiz;
        internal System.Windows.Forms.Button btnpasde;
        internal System.Windows.Forms.Button btnpasdet;
        internal System.Windows.Forms.ListBox lbvende2;
        internal System.Windows.Forms.ListBox lbvende1;
        internal System.Windows.Forms.DateTimePicker dtpfechaH;
        internal System.Windows.Forms.DateTimePicker dtpfechaD;
        internal System.Windows.Forms.Label Label17;
    }
}