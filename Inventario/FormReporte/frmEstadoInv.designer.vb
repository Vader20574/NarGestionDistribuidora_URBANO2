<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoInv
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadoInv))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnregtodo = New System.Windows.Forms.Button
        Me.btnreg = New System.Windows.Forms.Button
        Me.btnpass = New System.Windows.Forms.Button
        Me.btnpastodo = New System.Windows.Forms.Button
        Me.lblista2 = New System.Windows.Forms.ListBox
        Me.ItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblista1 = New System.Windows.Forms.ListBox
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmblista = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnregretodo = New System.Windows.Forms.Button
        Me.btnregre = New System.Windows.Forms.Button
        Me.btnpas = New System.Windows.Forms.Button
        Me.btnpasstodo = New System.Windows.Forms.Button
        Me.lbalmacen2 = New System.Windows.Forms.ListBox
        Me.ItemsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbalmacen = New System.Windows.Forms.ListBox
        Me.ItemsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btngenerar = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbstktodos = New System.Windows.Forms.RadioButton
        Me.rbstkfisico = New System.Windows.Forms.RadioButton
        Me.rbstkmin = New System.Windows.Forms.RadioButton
        Me.rbtodos = New System.Windows.Forms.RadioButton
        Me.Rpt1 = New AxCrystal.AxCrystalReport
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ItemsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnregtodo)
        Me.GroupBox1.Controls.Add(Me.btnreg)
        Me.GroupBox1.Controls.Add(Me.btnpass)
        Me.GroupBox1.Controls.Add(Me.btnpastodo)
        Me.GroupBox1.Controls.Add(Me.lblista2)
        Me.GroupBox1.Controls.Add(Me.lblista1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecciona Familia"
        '
        'btnregtodo
        '
        Me.btnregtodo.Location = New System.Drawing.Point(193, 177)
        Me.btnregtodo.Name = "btnregtodo"
        Me.btnregtodo.Size = New System.Drawing.Size(65, 23)
        Me.btnregtodo.TabIndex = 4
        Me.btnregtodo.Text = "<<"
        Me.btnregtodo.UseVisualStyleBackColor = True
        '
        'btnreg
        '
        Me.btnreg.Location = New System.Drawing.Point(193, 142)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(65, 23)
        Me.btnreg.TabIndex = 5
        Me.btnreg.Text = "<"
        Me.btnreg.UseVisualStyleBackColor = True
        '
        'btnpass
        '
        Me.btnpass.Location = New System.Drawing.Point(193, 107)
        Me.btnpass.Name = "btnpass"
        Me.btnpass.Size = New System.Drawing.Size(65, 23)
        Me.btnpass.TabIndex = 2
        Me.btnpass.Text = ">"
        Me.btnpass.UseVisualStyleBackColor = True
        '
        'btnpastodo
        '
        Me.btnpastodo.Location = New System.Drawing.Point(193, 72)
        Me.btnpastodo.Name = "btnpastodo"
        Me.btnpastodo.Size = New System.Drawing.Size(65, 23)
        Me.btnpastodo.TabIndex = 3
        Me.btnpastodo.Text = ">>"
        Me.btnpastodo.UseVisualStyleBackColor = True
        '
        'lblista2
        '
        Me.lblista2.DataSource = Me.ItemsBindingSource1
        Me.lblista2.DisplayMember = "Cadena"
        Me.lblista2.FormattingEnabled = True
        Me.lblista2.Location = New System.Drawing.Point(267, 17)
        Me.lblista2.Name = "lblista2"
        Me.lblista2.Size = New System.Drawing.Size(165, 199)
        Me.lblista2.TabIndex = 1
        Me.lblista2.ValueMember = "Codigo"
        '
        'ItemsBindingSource1
        '
        Me.ItemsBindingSource1.DataSource = GetType(NarGestionDistribuidora.frmEstadoInv.Items)
        '
        'lblista1
        '
        Me.lblista1.DataSource = Me.ItemsBindingSource
        Me.lblista1.DisplayMember = "Cadena"
        Me.lblista1.FormattingEnabled = True
        Me.lblista1.Location = New System.Drawing.Point(19, 17)
        Me.lblista1.Name = "lblista1"
        Me.lblista1.Size = New System.Drawing.Size(165, 199)
        Me.lblista1.TabIndex = 1
        Me.lblista1.ValueMember = "Codigo"
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataSource = GetType(NarGestionDistribuidora.frmEstadoInv.Items)
        '
        'cmblista
        '
        Me.cmblista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblista.FormattingEnabled = True
        Me.cmblista.Location = New System.Drawing.Point(625, 4)
        Me.cmblista.Name = "cmblista"
        Me.cmblista.Size = New System.Drawing.Size(193, 21)
        Me.cmblista.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnregretodo)
        Me.GroupBox2.Controls.Add(Me.btnregre)
        Me.GroupBox2.Controls.Add(Me.btnpas)
        Me.GroupBox2.Controls.Add(Me.btnpasstodo)
        Me.GroupBox2.Controls.Add(Me.lbalmacen2)
        Me.GroupBox2.Controls.Add(Me.lbalmacen)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 204)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selecciona Almacen"
        '
        'btnregretodo
        '
        Me.btnregretodo.Location = New System.Drawing.Point(193, 150)
        Me.btnregretodo.Name = "btnregretodo"
        Me.btnregretodo.Size = New System.Drawing.Size(65, 23)
        Me.btnregretodo.TabIndex = 4
        Me.btnregretodo.Text = "<<"
        Me.btnregretodo.UseVisualStyleBackColor = True
        '
        'btnregre
        '
        Me.btnregre.Location = New System.Drawing.Point(193, 115)
        Me.btnregre.Name = "btnregre"
        Me.btnregre.Size = New System.Drawing.Size(65, 23)
        Me.btnregre.TabIndex = 5
        Me.btnregre.Text = "<"
        Me.btnregre.UseVisualStyleBackColor = True
        '
        'btnpas
        '
        Me.btnpas.Location = New System.Drawing.Point(193, 80)
        Me.btnpas.Name = "btnpas"
        Me.btnpas.Size = New System.Drawing.Size(65, 23)
        Me.btnpas.TabIndex = 2
        Me.btnpas.Text = ">"
        Me.btnpas.UseVisualStyleBackColor = True
        '
        'btnpasstodo
        '
        Me.btnpasstodo.Location = New System.Drawing.Point(193, 45)
        Me.btnpasstodo.Name = "btnpasstodo"
        Me.btnpasstodo.Size = New System.Drawing.Size(65, 23)
        Me.btnpasstodo.TabIndex = 3
        Me.btnpasstodo.Text = ">>"
        Me.btnpasstodo.UseVisualStyleBackColor = True
        '
        'lbalmacen2
        '
        Me.lbalmacen2.DataSource = Me.ItemsBindingSource3
        Me.lbalmacen2.DisplayMember = "Cadena"
        Me.lbalmacen2.FormattingEnabled = True
        Me.lbalmacen2.Location = New System.Drawing.Point(267, 29)
        Me.lbalmacen2.Name = "lbalmacen2"
        Me.lbalmacen2.Size = New System.Drawing.Size(165, 160)
        Me.lbalmacen2.TabIndex = 1
        Me.lbalmacen2.ValueMember = "Codigo"
        '
        'ItemsBindingSource3
        '
        Me.ItemsBindingSource3.DataSource = GetType(NarGestionDistribuidora.frmEstadoInv.Items)
        '
        'lbalmacen
        '
        Me.lbalmacen.DataSource = Me.ItemsBindingSource2
        Me.lbalmacen.DisplayMember = "Cadena"
        Me.lbalmacen.FormattingEnabled = True
        Me.lbalmacen.Location = New System.Drawing.Point(19, 29)
        Me.lbalmacen.Name = "lbalmacen"
        Me.lbalmacen.Size = New System.Drawing.Size(165, 160)
        Me.lbalmacen.TabIndex = 1
        Me.lbalmacen.ValueMember = "Codigo"
        '
        'ItemsBindingSource2
        '
        Me.ItemsBindingSource2.DataSource = GetType(NarGestionDistribuidora.frmEstadoInv.Items)
        '
        'btngenerar
        '
        Me.btngenerar.Location = New System.Drawing.Point(501, 59)
        Me.btngenerar.Name = "btngenerar"
        Me.btngenerar.Size = New System.Drawing.Size(84, 23)
        Me.btngenerar.TabIndex = 1
        Me.btngenerar.Text = "Generar"
        Me.btngenerar.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(501, 97)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(84, 23)
        Me.btncancel.TabIndex = 1
        Me.btncancel.Text = "Cancelar"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbstktodos)
        Me.GroupBox3.Controls.Add(Me.rbstkfisico)
        Me.GroupBox3.Controls.Add(Me.rbstkmin)
        Me.GroupBox3.Controls.Add(Me.rbtodos)
        Me.GroupBox3.Location = New System.Drawing.Point(625, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 95)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock :"
        '
        'rbstktodos
        '
        Me.rbstktodos.AutoSize = True
        Me.rbstktodos.Location = New System.Drawing.Point(14, 94)
        Me.rbstktodos.Name = "rbstktodos"
        Me.rbstktodos.Size = New System.Drawing.Size(102, 17)
        Me.rbstktodos.TabIndex = 0
        Me.rbstktodos.Text = "Stock Todos los"
        Me.rbstktodos.UseVisualStyleBackColor = True
        Me.rbstktodos.Visible = False
        '
        'rbstkfisico
        '
        Me.rbstkfisico.AutoSize = True
        Me.rbstkfisico.Location = New System.Drawing.Point(14, 69)
        Me.rbstkfisico.Name = "rbstkfisico"
        Me.rbstkfisico.Size = New System.Drawing.Size(83, 17)
        Me.rbstkfisico.TabIndex = 0
        Me.rbstkfisico.Text = "Stock Fisico"
        Me.rbstkfisico.UseVisualStyleBackColor = True
        Me.rbstkfisico.Visible = False
        '
        'rbstkmin
        '
        Me.rbstkmin.AutoSize = True
        Me.rbstkmin.Location = New System.Drawing.Point(14, 44)
        Me.rbstkmin.Name = "rbstkmin"
        Me.rbstkmin.Size = New System.Drawing.Size(106, 17)
        Me.rbstkmin.TabIndex = 0
        Me.rbstkmin.Text = "Menor Stock Min"
        Me.rbstkmin.UseVisualStyleBackColor = True
        '
        'rbtodos
        '
        Me.rbtodos.AutoSize = True
        Me.rbtodos.Checked = True
        Me.rbtodos.Location = New System.Drawing.Point(14, 19)
        Me.rbtodos.Name = "rbtodos"
        Me.rbtodos.Size = New System.Drawing.Size(55, 17)
        Me.rbtodos.TabIndex = 0
        Me.rbtodos.TabStop = True
        Me.rbtodos.Text = "Todos"
        Me.rbtodos.UseVisualStyleBackColor = True
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(616, 405)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbcodigo)
        Me.GroupBox4.Controls.Add(Me.rbdescripcion)
        Me.GroupBox4.Location = New System.Drawing.Point(625, 129)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(146, 72)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ordena Articulo por :"
        '
        'rbcodigo
        '
        Me.rbcodigo.AutoSize = True
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(14, 20)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(58, 17)
        Me.rbcodigo.TabIndex = 0
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        Me.rbcodigo.UseVisualStyleBackColor = True
        '
        'rbdescripcion
        '
        Me.rbdescripcion.AutoSize = True
        Me.rbdescripcion.Location = New System.Drawing.Point(14, 45)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(81, 17)
        Me.rbdescripcion.TabIndex = 0
        Me.rbdescripcion.Text = "Descripcion"
        Me.rbdescripcion.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(501, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 57)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Reporte X Mayor Presentacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(501, 189)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 57)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Reporte X Stock"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(501, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 49)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Reporte Todo Almacen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(501, 253)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 49)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Reporte de distribucion"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(501, 314)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 49)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Mostrar Articulo sin Precio"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(501, 369)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 70)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Reporte Multialmacenes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Enabled = False
        Me.DtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(61, 456)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaIni.TabIndex = 11
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(61, 485)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaFin.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 489)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Hasta : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Desde :"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(313, 454)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 70)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Valoracion X Linea"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(407, 454)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 70)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = "Valoracion X SubLinea"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(501, 454)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 70)
        Me.Button9.TabIndex = 17
        Me.Button9.Text = "Ventas x Almacen x Categoria"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'frmEstadoInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 546)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.DtFechaIni)
        Me.Controls.Add(Me.DtFechaFin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Rpt1)
        Me.Controls.Add(Me.cmblista)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btngenerar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmEstadoInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ghfs"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ItemsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmblista As System.Windows.Forms.ComboBox
    Friend WithEvents lblista2 As System.Windows.Forms.ListBox
    Friend WithEvents lblista1 As System.Windows.Forms.ListBox
    Friend WithEvents btnregtodo As System.Windows.Forms.Button
    Friend WithEvents btnreg As System.Windows.Forms.Button
    Friend WithEvents btnpass As System.Windows.Forms.Button
    Friend WithEvents btnpastodo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnregretodo As System.Windows.Forms.Button
    Friend WithEvents btnregre As System.Windows.Forms.Button
    Friend WithEvents btnpas As System.Windows.Forms.Button
    Friend WithEvents btnpasstodo As System.Windows.Forms.Button
    Friend WithEvents lbalmacen2 As System.Windows.Forms.ListBox
    Friend WithEvents lbalmacen As System.Windows.Forms.ListBox
    Friend WithEvents btngenerar As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents ItemsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ItemsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents rbstktodos As System.Windows.Forms.RadioButton
    Friend WithEvents rbstkmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbtodos As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbstkfisico As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
