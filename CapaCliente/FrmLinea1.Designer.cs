namespace CapaCliente
{
    partial class FrmLinea1
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCorrelat = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbotipoprod = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNCERRAR = new System.Windows.Forms.Button();
            this.BTNMODIFICAR = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNREPORTE = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.TxtCorrelat);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.cbotipoprod);
            this.GroupBox2.Controls.Add(this.txtdescripcion);
            this.GroupBox2.Controls.Add(this.btnbuscar);
            this.GroupBox2.Controls.Add(this.txtcod);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Location = new System.Drawing.Point(58, 57);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(356, 131);
            this.GroupBox2.TabIndex = 19;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // TxtCorrelat
            // 
            this.TxtCorrelat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCorrelat.BackColor = System.Drawing.Color.White;
            this.TxtCorrelat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCorrelat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorrelat.Location = new System.Drawing.Point(98, 75);
            this.TxtCorrelat.MaxLength = 4;
            this.TxtCorrelat.Name = "TxtCorrelat";
            this.TxtCorrelat.Size = new System.Drawing.Size(90, 21);
            this.TxtCorrelat.TabIndex = 22;
            this.TxtCorrelat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(24, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 13);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Correlativo  : ";
            // 
            // cbotipoprod
            // 
            this.cbotipoprod.Location = new System.Drawing.Point(194, 73);
            this.cbotipoprod.Name = "cbotipoprod";
            this.cbotipoprod.Size = new System.Drawing.Size(121, 21);
            this.cbotipoprod.TabIndex = 19;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.White;
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(96, 48);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(217, 21);
            this.txtdescripcion.TabIndex = 18;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.ImageIndex = 5;
            this.btnbuscar.Location = new System.Drawing.Point(176, 22);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(41, 23);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "...";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.Color.White;
            this.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcod.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(96, 22);
            this.txtcod.MaxLength = 4;
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(72, 21);
            this.txtcod.TabIndex = 15;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(34, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Categoria : ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(48, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Codigo :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(18, 152);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(95, 13);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Tipo de Producto :";
            this.Label4.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.BTNCANCELAR);
            this.GroupBox1.Controls.Add(this.BTNCERRAR);
            this.GroupBox1.Controls.Add(this.BTNMODIFICAR);
            this.GroupBox1.Controls.Add(this.BTNELIMINAR);
            this.GroupBox1.Controls.Add(this.BTNNUEVO);
            this.GroupBox1.Controls.Add(this.BTNGUARDAR);
            this.GroupBox1.Location = new System.Drawing.Point(416, 36);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(100, 188);
            this.GroupBox1.TabIndex = 18;
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
            // BTNREPORTE
            // 
            this.BTNREPORTE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNREPORTE.ImageIndex = 6;
            this.BTNREPORTE.Location = new System.Drawing.Point(296, 135);
            this.BTNREPORTE.Name = "BTNREPORTE";
            this.BTNREPORTE.Size = new System.Drawing.Size(75, 23);
            this.BTNREPORTE.TabIndex = 17;
            this.BTNREPORTE.Text = "&Cancelar";
            this.BTNREPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmLinea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 261);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.BTNREPORTE);
            this.Name = "FrmLinea1";
            this.Text = "Linea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox TxtCorrelat;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbotipoprod;
        internal System.Windows.Forms.TextBox txtdescripcion;
        internal System.Windows.Forms.Button btnbuscar;
        internal System.Windows.Forms.TextBox txtcod;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button BTNCANCELAR;
        internal System.Windows.Forms.Button BTNCERRAR;
        internal System.Windows.Forms.Button BTNMODIFICAR;
        internal System.Windows.Forms.Button BTNELIMINAR;
        internal System.Windows.Forms.Button BTNNUEVO;
        internal System.Windows.Forms.Button BTNGUARDAR;
        internal System.Windows.Forms.Button BTNREPORTE;
    }
}