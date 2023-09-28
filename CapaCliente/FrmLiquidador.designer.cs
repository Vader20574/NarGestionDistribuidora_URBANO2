
namespace CapaCliente
{
    partial class FrmLiquidador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiquidador));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.btnBusqPromo = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.button1);
            this.GroupBox2.Controls.Add(this.BTNNUEVO);
            this.GroupBox2.Controls.Add(this.BTNCERRAR);
            this.GroupBox2.Controls.Add(this.BTNMODIFICAR);
            this.GroupBox2.Controls.Add(this.BTNELIMINAR);
            this.GroupBox2.Controls.Add(this.BTNGUARDAR);
            this.GroupBox2.Location = new System.Drawing.Point(307, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(125, 267);
            this.GroupBox2.TabIndex = 62;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mantenimiento ";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Cerrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(14, 19);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(90, 45);
            this.BTNNUEVO.TabIndex = 7;
            this.BTNNUEVO.Text = "Nuevo";
            this.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVO.UseVisualStyleBackColor = true;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // BTNCERRAR
            // 
            this.BTNCERRAR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCERRAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNCERRAR.Image")));
            this.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCERRAR.Location = new System.Drawing.Point(15, 329);
            this.BTNCERRAR.Name = "BTNCERRAR";
            this.BTNCERRAR.Size = new System.Drawing.Size(90, 45);
            this.BTNCERRAR.TabIndex = 6;
            this.BTNCERRAR.Text = "&Cerrar";
            this.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTNMODIFICAR
            // 
            this.BTNMODIFICAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNMODIFICAR.Image")));
            this.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMODIFICAR.Location = new System.Drawing.Point(15, 107);
            this.BTNMODIFICAR.Name = "BTNMODIFICAR";
            this.BTNMODIFICAR.Size = new System.Drawing.Size(90, 45);
            this.BTNMODIFICAR.TabIndex = 2;
            this.BTNMODIFICAR.Text = "&Modificar";
            this.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNMODIFICAR.Click += new System.EventHandler(this.BTNMODIFICAR_Click);
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNELIMINAR.Image")));
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(14, 152);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(90, 45);
            this.BTNELIMINAR.TabIndex = 3;
            this.BTNELIMINAR.Text = "&Eliminar";
            this.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNGUARDAR.Image")));
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(15, 63);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(90, 45);
            this.BTNGUARDAR.TabIndex = 1;
            this.BTNGUARDAR.Text = "&Guardar";
            this.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // btnBusqPromo
            // 
            this.btnBusqPromo.ImageIndex = 5;
            this.btnBusqPromo.Location = new System.Drawing.Point(212, 42);
            this.btnBusqPromo.Name = "btnBusqPromo";
            this.btnBusqPromo.Size = new System.Drawing.Size(30, 22);
            this.btnBusqPromo.TabIndex = 67;
            this.btnBusqPromo.Click += new System.EventHandler(this.btnBusqPromo_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(100, 70);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 20);
            this.txtDescripcion.TabIndex = 66;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(105, 20);
            this.txtCodigo.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Descripcion :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Codigo :";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(100, 103);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 68;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmLiquidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 311);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.btnBusqPromo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox2);
            this.Name = "FrmLiquidador";
            this.Text = "Mantenimiento de Liquidador";
            this.Load += new System.EventHandler(this.FrmCatABCprod_Load);
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNNUEVO;
        internal System.Windows.Forms.Button BTNCERRAR;
        internal System.Windows.Forms.Button BTNMODIFICAR;
        internal System.Windows.Forms.Button BTNELIMINAR;
        internal System.Windows.Forms.Button BTNGUARDAR;
        internal System.Windows.Forms.Button btnBusqPromo;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.CheckBox chkEstado;
    }
}