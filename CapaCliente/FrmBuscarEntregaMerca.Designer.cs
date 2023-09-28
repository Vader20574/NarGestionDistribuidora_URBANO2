
namespace CapaCliente
{
    partial class FrmBuscarEntregaMerca
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(8, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 177);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Descripcion";
            this.Column8.HeaderText = "Descripcion";
            this.Column8.Name = "Column8";
            // 
            // RadioButton2
            // 
            this.RadioButton2.Location = new System.Drawing.Point(416, 24);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(88, 16);
            this.RadioButton2.TabIndex = 12;
            this.RadioButton2.Text = "Descripcion";
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
            // txtdato
            // 
            this.txtdato.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdato.Location = new System.Drawing.Point(72, 22);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(208, 21);
            this.txtdato.TabIndex = 0;
            this.txtdato.TextChanged += new System.EventHandler(this.txtdato_TextChanged);
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
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Location = new System.Drawing.Point(4, 3);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 56);
            this.GroupBox1.TabIndex = 18;
            this.GroupBox1.TabStop = false;
            // 
            // FrmBuscarEntregaMerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 265);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmBuscarEntregaMerca";
            this.Text = "FrmBuscar Entrega";
            this.Load += new System.EventHandler(this.FrmBuscarCatABCprod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.TextBox txtdato;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}