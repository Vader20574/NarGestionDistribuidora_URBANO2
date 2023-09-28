namespace CapaCliente
{
   public partial class FrmDocAnulados
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
            this.components = new System.ComponentModel.Container();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnBuscarDocAnulados = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(82, 70);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(138, 20);
            this.txtNroDoc.TabIndex = 1;
            this.txtNroDoc.TextChanged += new System.EventHandler(this.txtNroDoc_TextChanged);
            this.txtNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDoc_KeyPress);
            this.txtNroDoc.Validating += new System.ComponentModel.CancelEventHandler(this.txtNroDoc_Validating);
            this.txtNroDoc.Validated += new System.EventHandler(this.txtNroDoc_Validated);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(82, 96);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(133, 21);
            this.cmbTipoDoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NroDoc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TipoDoc :";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BTNCANCELAR);
            this.GroupBox1.Controls.Add(this.BTNCERRAR);
            this.GroupBox1.Controls.Add(this.BTNMODIFICAR);
            this.GroupBox1.Controls.Add(this.BTNELIMINAR);
            this.GroupBox1.Controls.Add(this.BTNNUEVO);
            this.GroupBox1.Controls.Add(this.BTNGUARDAR);
            this.GroupBox1.Location = new System.Drawing.Point(508, 15);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(100, 188);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Mantenimiento ";
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCELAR.ImageIndex = 6;
            this.BTNCANCELAR.Location = new System.Drawing.Point(14, 123);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(75, 23);
            this.BTNCANCELAR.TabIndex = 5;
            this.BTNCANCELAR.Text = "&Cancelar";
            this.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // BTNCERRAR
            // 
            this.BTNCERRAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCERRAR.ImageIndex = 4;
            this.BTNCERRAR.Location = new System.Drawing.Point(14, 150);
            this.BTNCERRAR.Name = "BTNCERRAR";
            this.BTNCERRAR.Size = new System.Drawing.Size(75, 23);
            this.BTNCERRAR.TabIndex = 4;
            this.BTNCERRAR.Text = "&Cerrar";
            this.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNCERRAR.Click += new System.EventHandler(this.BTNCERRAR_Click);
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMODIFICAR.ImageIndex = 2;
            this.BTNMODIFICAR.Location = new System.Drawing.Point(14, 69);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.BTNMODIFICAR.TabIndex = 3;
            this.BTNMODIFICAR.Text = "&Modificar";
            this.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.ImageIndex = 3;
            this.BTNELIMINAR.Location = new System.Drawing.Point(14, 96);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.BTNELIMINAR.TabIndex = 2;
            this.BTNELIMINAR.Text = "&Eliminar";
            this.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.ImageIndex = 0;
            this.BTNNUEVO.Location = new System.Drawing.Point(14, 15);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(75, 23);
            this.BTNNUEVO.TabIndex = 10;
            this.BTNNUEVO.Text = "&Nuevo";
            this.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.ImageIndex = 1;
            this.BTNGUARDAR.Location = new System.Drawing.Point(14, 42);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.BTNGUARDAR.TabIndex = 1;
            this.BTNGUARDAR.Text = "&Guardar";
            this.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCod);
            this.groupBox2.Controls.Add(this.btnBuscarDocAnulados);
            this.groupBox2.Controls.Add(this.txtNroDoc);
            this.groupBox2.Controls.Add(this.cmbTipoDoc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(67, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 186);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo :";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(82, 43);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(138, 20);
            this.txtCod.TabIndex = 6;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // btnBuscarDocAnulados
            // 
            this.btnBuscarDocAnulados.Location = new System.Drawing.Point(226, 40);
            this.btnBuscarDocAnulados.Name = "btnBuscarDocAnulados";
            this.btnBuscarDocAnulados.Size = new System.Drawing.Size(37, 23);
            this.btnBuscarDocAnulados.TabIndex = 5;
            this.btnBuscarDocAnulados.Text = "...";
            this.btnBuscarDocAnulados.UseVisualStyleBackColor = true;
            this.btnBuscarDocAnulados.Click += new System.EventHandler(this.btnBuscarDocAnulados_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmDocAnulados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "FrmDocAnulados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Anulados";
            this.Load += new System.EventHandler(this.FrmDocAnulados_Load);
            this.GroupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TextBox txtNroDoc;
        internal System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button BTNCANCELAR;
        internal System.Windows.Forms.Button BTNCERRAR;
        internal System.Windows.Forms.Button BTNMODIFICAR;
        internal System.Windows.Forms.Button BTNELIMINAR;
        internal System.Windows.Forms.Button BTNNUEVO;
        internal System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarDocAnulados;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}