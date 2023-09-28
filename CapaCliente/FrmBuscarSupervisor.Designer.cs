
namespace CapaCliente
{
    partial class FrmBuscarSupervisor
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
            this.DgvSupervisor = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.CODLINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESLINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPOPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrofac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrobol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrofacRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrobolRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDESE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GIEF = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GIEB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSupervisor)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvSupervisor
            // 
            this.DgvSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSupervisor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODLINEA,
            this.CODEMPRESA,
            this.DESLINEA,
            this.CODTIPOPROD,
            this.nrofac,
            this.nrobol,
            this.nrofacRef,
            this.nrobolRef,
            this.EDESE,
            this.GIEF,
            this.GIEB});
            this.DgvSupervisor.Location = new System.Drawing.Point(12, 106);
            this.DgvSupervisor.Name = "DgvSupervisor";
            this.DgvSupervisor.Size = new System.Drawing.Size(873, 125);
            this.DgvSupervisor.TabIndex = 6;
            this.DgvSupervisor.DoubleClick += new System.EventHandler(this.DgvSupervisor_DoubleClick);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Controls.Add(this.RadioButton1);
            this.GroupBox1.Controls.Add(this.RadioButton2);
            this.GroupBox1.Location = new System.Drawing.Point(67, 44);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(516, 56);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
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
            this.RadioButton2.Text = "Descripcion";
            // 
            // CODLINEA
            // 
            this.CODLINEA.DataPropertyName = "CODSUPERV";
            this.CODLINEA.HeaderText = "Codigo";
            this.CODLINEA.Name = "CODLINEA";
            this.CODLINEA.Width = 70;
            // 
            // CODEMPRESA
            // 
            this.CODEMPRESA.DataPropertyName = "CODEMPRESA";
            this.CODEMPRESA.HeaderText = "CODEMPRESA";
            this.CODEMPRESA.Name = "CODEMPRESA";
            this.CODEMPRESA.Visible = false;
            // 
            // DESLINEA
            // 
            this.DESLINEA.DataPropertyName = "DSSUPERV";
            this.DESLINEA.HeaderText = "Descripcion";
            this.DESLINEA.Name = "DESLINEA";
            // 
            // CODTIPOPROD
            // 
            this.CODTIPOPROD.DataPropertyName = "DIRECCION";
            this.CODTIPOPROD.HeaderText = "Direccion";
            this.CODTIPOPROD.Name = "CODTIPOPROD";
            // 
            // nrofac
            // 
            this.nrofac.DataPropertyName = "nrofac";
            this.nrofac.HeaderText = "NroFactura";
            this.nrofac.Name = "nrofac";
            // 
            // nrobol
            // 
            this.nrobol.DataPropertyName = "nrobol";
            this.nrobol.HeaderText = "NroBoleta";
            this.nrobol.Name = "nrobol";
            // 
            // nrofacRef
            // 
            this.nrofacRef.DataPropertyName = "nrofacRef";
            this.nrofacRef.HeaderText = "NroFactura2";
            this.nrofacRef.Name = "nrofacRef";
            // 
            // nrobolRef
            // 
            this.nrobolRef.DataPropertyName = "nrobolRef";
            this.nrobolRef.HeaderText = "NroBoleta2";
            this.nrobolRef.Name = "nrobolRef";
            // 
            // EDESE
            // 
            this.EDESE.DataPropertyName = "EDESE";
            this.EDESE.HeaderText = "EDESE";
            this.EDESE.Name = "EDESE";
            this.EDESE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EDESE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GIEF
            // 
            this.GIEF.DataPropertyName = "GIEF";
            this.GIEF.HeaderText = "GIEF";
            this.GIEF.Name = "GIEF";
            this.GIEF.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GIEF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GIEB
            // 
            this.GIEB.DataPropertyName = "GIEB";
            this.GIEB.HeaderText = "GIEB";
            this.GIEB.Name = "GIEB";
            this.GIEB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GIEB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmBuscarSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.DgvSupervisor);
            this.Name = "FrmBuscarSupervisor";
            this.Text = "FrmBuscarSupervisor";
            this.Load += new System.EventHandler(this.FrmBuscarSupervisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSupervisor)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSupervisor;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtdato;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODLINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESLINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPOPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofac;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrobol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrofacRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrobolRef;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EDESE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GIEF;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GIEB;
    }
}