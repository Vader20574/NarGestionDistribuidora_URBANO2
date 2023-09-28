namespace CapaCliente.Maestra.BusquedaInv
{
    partial class FrmGridPromocionSubCat
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
            this.Label2 = new System.Windows.Forms.Label();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.rbdescripcion = new System.Windows.Forms.RadioButton();
            this.rbcodigo = new System.Windows.Forms.RadioButton();
            this.dgvpromodesoles = new System.Windows.Forms.DataGridView();
            this.CODPROMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESPROMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_PROMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODZONA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODLINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODSUBLINEA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODPRESVTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESCALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESDE_SOLES_ART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTA_SOLES_ART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLES_ART_VTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODARTI_PROMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODPRESPROM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_ARTI_PROMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOCK_PROMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEC_INI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEC_FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpromodesoles)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtdato);
            this.GroupBox1.Controls.Add(this.rbdescripcion);
            this.GroupBox1.Controls.Add(this.rbcodigo);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(522, 46);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(28, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Dato : ";
            // 
            // txtdato
            // 
            this.txtdato.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdato.Location = new System.Drawing.Point(84, 16);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(230, 21);
            this.txtdato.TabIndex = 10;
            this.txtdato.TextChanged += new System.EventHandler(this.txtdato_TextChanged);
            // 
            // rbdescripcion
            // 
            this.rbdescripcion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdescripcion.Location = new System.Drawing.Point(414, 22);
            this.rbdescripcion.Name = "rbdescripcion";
            this.rbdescripcion.Size = new System.Drawing.Size(80, 16);
            this.rbdescripcion.TabIndex = 9;
            this.rbdescripcion.Text = "Descripcion";
            // 
            // rbcodigo
            // 
            this.rbcodigo.Checked = true;
            this.rbcodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcodigo.Location = new System.Drawing.Point(342, 20);
            this.rbcodigo.Name = "rbcodigo";
            this.rbcodigo.Size = new System.Drawing.Size(68, 19);
            this.rbcodigo.TabIndex = 8;
            this.rbcodigo.TabStop = true;
            this.rbcodigo.Text = "Codigo";
            // 
            // dgvpromodesoles
            // 
            this.dgvpromodesoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpromodesoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODPROMO,
            this.DESPROMO,
            this.PRECIO_PROMO,
            this.CODEMPRESA,
            this.CODZONA,
            this.CODLINEA,
            this.CODSUBLINEA,
            this.CODPRESVTA,
            this.ESCALA,
            this.DESDE_SOLES_ART,
            this.HASTA_SOLES_ART,
            this.SOLES_ART_VTA,
            this.CODARTI_PROMO,
            this.CODPRESPROM,
            this.CANT_ARTI_PROMO,
            this.STOCK_PROMO,
            this.FEC_INI,
            this.FEC_FIN,
            this.activar});
            this.dgvpromodesoles.Location = new System.Drawing.Point(42, 75);
            this.dgvpromodesoles.Name = "dgvpromodesoles";
            this.dgvpromodesoles.Size = new System.Drawing.Size(475, 233);
            this.dgvpromodesoles.TabIndex = 15;
            this.dgvpromodesoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpromodesoles_CellContentClick);
            this.dgvpromodesoles.DoubleClick += new System.EventHandler(this.dgvpromodesoles_DoubleClick);
            // 
            // CODPROMO
            // 
            this.CODPROMO.DataPropertyName = "CODPROMO";
            this.CODPROMO.HeaderText = "CODIGO";
            this.CODPROMO.Name = "CODPROMO";
            // 
            // DESPROMO
            // 
            this.DESPROMO.DataPropertyName = "DESPROMO";
            this.DESPROMO.HeaderText = "DESCRIPCION";
            this.DESPROMO.Name = "DESPROMO";
            // 
            // PRECIO_PROMO
            // 
            this.PRECIO_PROMO.DataPropertyName = "PRECIO_PROMO";
            this.PRECIO_PROMO.HeaderText = "PRECIO";
            this.PRECIO_PROMO.Name = "PRECIO_PROMO";
            // 
            // CODEMPRESA
            // 
            this.CODEMPRESA.DataPropertyName = "CODEMPRESA";
            this.CODEMPRESA.HeaderText = "CODEMPRESA";
            this.CODEMPRESA.Name = "CODEMPRESA";
            this.CODEMPRESA.Visible = false;
            // 
            // CODZONA
            // 
            this.CODZONA.DataPropertyName = "CODZONA";
            this.CODZONA.HeaderText = "CODZONA";
            this.CODZONA.Name = "CODZONA";
            this.CODZONA.Visible = false;
            // 
            // CODLINEA
            // 
            this.CODLINEA.DataPropertyName = "CODLINEA";
            this.CODLINEA.HeaderText = "CODLINEA";
            this.CODLINEA.Name = "CODLINEA";
            this.CODLINEA.Visible = false;
            // 
            // CODSUBLINEA
            // 
            this.CODSUBLINEA.DataPropertyName = "CODSUBLINEA";
            this.CODSUBLINEA.HeaderText = "CODSUBLINEA";
            this.CODSUBLINEA.Name = "CODSUBLINEA";
            // 
            // CODPRESVTA
            // 
            this.CODPRESVTA.DataPropertyName = "CODPRESVTA";
            this.CODPRESVTA.HeaderText = "CODPRESVTA";
            this.CODPRESVTA.Name = "CODPRESVTA";
            this.CODPRESVTA.Visible = false;
            // 
            // ESCALA
            // 
            this.ESCALA.DataPropertyName = "ESCALA";
            this.ESCALA.HeaderText = "ESCALA";
            this.ESCALA.Name = "ESCALA";
            this.ESCALA.Visible = false;
            // 
            // DESDE_SOLES_ART
            // 
            this.DESDE_SOLES_ART.DataPropertyName = "DESDE_SOLES_ART";
            this.DESDE_SOLES_ART.HeaderText = "DESDE_SOLES_ART";
            this.DESDE_SOLES_ART.Name = "DESDE_SOLES_ART";
            this.DESDE_SOLES_ART.Visible = false;
            // 
            // HASTA_SOLES_ART
            // 
            this.HASTA_SOLES_ART.DataPropertyName = "HASTA_SOLES_ART";
            this.HASTA_SOLES_ART.HeaderText = "HASTA_SOLES_ART";
            this.HASTA_SOLES_ART.Name = "HASTA_SOLES_ART";
            this.HASTA_SOLES_ART.Visible = false;
            // 
            // SOLES_ART_VTA
            // 
            this.SOLES_ART_VTA.DataPropertyName = "SOLES_ART_VTA";
            this.SOLES_ART_VTA.HeaderText = "SOLES_ART_VTA";
            this.SOLES_ART_VTA.Name = "SOLES_ART_VTA";
            this.SOLES_ART_VTA.Visible = false;
            // 
            // CODARTI_PROMO
            // 
            this.CODARTI_PROMO.DataPropertyName = "CODARTI_PROMO";
            this.CODARTI_PROMO.HeaderText = "CODARTI_PROMO";
            this.CODARTI_PROMO.Name = "CODARTI_PROMO";
            this.CODARTI_PROMO.Visible = false;
            // 
            // CODPRESPROM
            // 
            this.CODPRESPROM.DataPropertyName = "CODPRESPROM";
            this.CODPRESPROM.HeaderText = "CODPRESPROM";
            this.CODPRESPROM.Name = "CODPRESPROM";
            this.CODPRESPROM.Visible = false;
            // 
            // CANT_ARTI_PROMO
            // 
            this.CANT_ARTI_PROMO.DataPropertyName = "CANT_ARTI_PROMO";
            this.CANT_ARTI_PROMO.HeaderText = "CANT_ARTI_PROMO";
            this.CANT_ARTI_PROMO.Name = "CANT_ARTI_PROMO";
            this.CANT_ARTI_PROMO.Visible = false;
            // 
            // STOCK_PROMO
            // 
            this.STOCK_PROMO.DataPropertyName = "STOCK_PROMO";
            this.STOCK_PROMO.HeaderText = "STOCK_PROMO";
            this.STOCK_PROMO.Name = "STOCK_PROMO";
            this.STOCK_PROMO.Visible = false;
            // 
            // FEC_INI
            // 
            this.FEC_INI.DataPropertyName = "FEC_INI";
            this.FEC_INI.HeaderText = "FEC_INI";
            this.FEC_INI.Name = "FEC_INI";
            this.FEC_INI.Visible = false;
            // 
            // FEC_FIN
            // 
            this.FEC_FIN.DataPropertyName = "FEC_FIN";
            this.FEC_FIN.HeaderText = "FEC_FIN";
            this.FEC_FIN.Name = "FEC_FIN";
            this.FEC_FIN.Visible = false;
            // 
            // activar
            // 
            this.activar.DataPropertyName = "activar";
            this.activar.HeaderText = "activar";
            this.activar.Name = "activar";
            this.activar.Visible = false;
            // 
            // FrmGridPromocionSubCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 331);
            this.Controls.Add(this.dgvpromodesoles);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmGridPromocionSubCat";
            this.Text = "FrmGridPromocion";
            this.Load += new System.EventHandler(this.FrmGridPromocion_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpromodesoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtdato;
        internal System.Windows.Forms.RadioButton rbdescripcion;
        internal System.Windows.Forms.RadioButton rbcodigo;
        private System.Windows.Forms.DataGridView dgvpromodesoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPROMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESPROMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_PROMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODZONA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODLINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODSUBLINEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPRESVTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESCALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESDE_SOLES_ART;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASTA_SOLES_ART;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLES_ART_VTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODARTI_PROMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPRESPROM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_ARTI_PROMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOCK_PROMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEC_INI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEC_FIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn activar;
    }
}