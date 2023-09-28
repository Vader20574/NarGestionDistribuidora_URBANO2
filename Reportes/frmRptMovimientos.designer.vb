<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptMovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptMovimientos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnizpass = New System.Windows.Forms.Button
        Me.btndpass = New System.Windows.Forms.Button
        Me.btnipass = New System.Windows.Forms.Button
        Me.btndtodo = New System.Windows.Forms.Button
        Me.lb2 = New System.Windows.Forms.ListBox
        Me.TipoDocEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb1 = New System.Windows.Forms.ListBox
        Me.TipoDocEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.cmbalmacen = New System.Windows.Forms.ComboBox
        Me.cmbmovi = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpfinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TipoDocEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDocEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.AxCrystalReport1)
        Me.GroupBox1.Controls.Add(Me.btnsalir)
        Me.GroupBox1.Controls.Add(Me.btnaceptar)
        Me.GroupBox1.Controls.Add(Me.cmbalmacen)
        Me.GroupBox1.Controls.Add(Me.cmbmovi)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 385)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnizpass)
        Me.GroupBox3.Controls.Add(Me.btndpass)
        Me.GroupBox3.Controls.Add(Me.btnipass)
        Me.GroupBox3.Controls.Add(Me.btndtodo)
        Me.GroupBox3.Controls.Add(Me.lb2)
        Me.GroupBox3.Controls.Add(Me.lb1)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 196)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Documentos"
        '
        'btnizpass
        '
        Me.btnizpass.Location = New System.Drawing.Point(192, 137)
        Me.btnizpass.Name = "btnizpass"
        Me.btnizpass.Size = New System.Drawing.Size(59, 23)
        Me.btnizpass.TabIndex = 1
        Me.btnizpass.Text = "<<"
        Me.btnizpass.UseVisualStyleBackColor = True
        '
        'btndpass
        '
        Me.btndpass.Location = New System.Drawing.Point(192, 73)
        Me.btndpass.Name = "btndpass"
        Me.btndpass.Size = New System.Drawing.Size(59, 23)
        Me.btndpass.TabIndex = 1
        Me.btndpass.Text = ">"
        Me.btndpass.UseVisualStyleBackColor = True
        '
        'btnipass
        '
        Me.btnipass.Location = New System.Drawing.Point(192, 106)
        Me.btnipass.Name = "btnipass"
        Me.btnipass.Size = New System.Drawing.Size(59, 23)
        Me.btnipass.TabIndex = 1
        Me.btnipass.Text = "<"
        Me.btnipass.UseVisualStyleBackColor = True
        '
        'btndtodo
        '
        Me.btndtodo.Location = New System.Drawing.Point(192, 42)
        Me.btndtodo.Name = "btndtodo"
        Me.btndtodo.Size = New System.Drawing.Size(59, 23)
        Me.btndtodo.TabIndex = 1
        Me.btndtodo.Text = ">>"
        Me.btndtodo.UseVisualStyleBackColor = True
        '
        'lb2
        '
        Me.lb2.DataSource = Me.TipoDocEBindingSource1
        Me.lb2.DisplayMember = "TIPODOCUMENTO"
        Me.lb2.FormattingEnabled = True
        Me.lb2.Location = New System.Drawing.Point(257, 19)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(168, 160)
        Me.lb2.TabIndex = 0
        Me.lb2.ValueMember = "CODIGO"
        '
        'TipoDocEBindingSource1
        '
        Me.TipoDocEBindingSource1.DataSource = GetType(NarGestionDistribuidora.TipoDocE)
        '
        'lb1
        '
        Me.lb1.DataSource = Me.TipoDocEBindingSource
        Me.lb1.DisplayMember = "TIPODOCUMENTO"
        Me.lb1.FormattingEnabled = True
        Me.lb1.Location = New System.Drawing.Point(18, 19)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(168, 160)
        Me.lb1.TabIndex = 0
        Me.lb1.ValueMember = "CODIGO"
        '
        'TipoDocEBindingSource
        '
        Me.TipoDocEBindingSource.DataSource = GetType(NarGestionDistribuidora.TipoDocE)
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(290, 408)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 4
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(229, 352)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(108, 352)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnaceptar.TabIndex = 3
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'cmbalmacen
        '
        Me.cmbalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbalmacen.FormattingEnabled = True
        Me.cmbalmacen.Location = New System.Drawing.Point(166, 310)
        Me.cmbalmacen.Name = "cmbalmacen"
        Me.cmbalmacen.Size = New System.Drawing.Size(217, 21)
        Me.cmbalmacen.TabIndex = 2
        '
        'cmbmovi
        '
        Me.cmbmovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmovi.FormattingEnabled = True
        Me.cmbmovi.Items.AddRange(New Object() {"INGRESOS", "SALIDAS"})
        Me.cmbmovi.Location = New System.Drawing.Point(147, 71)
        Me.cmbmovi.Name = "cmbmovi"
        Me.cmbmovi.Size = New System.Drawing.Size(217, 21)
        Me.cmbmovi.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Almacen :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Movimientos :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfin)
        Me.GroupBox2.Controls.Add(Me.dtpfinicio)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 46)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha"
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(304, 13)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(97, 20)
        Me.dtpfin.TabIndex = 1
        '
        'dtpfinicio
        '
        Me.dtpfinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfinicio.Location = New System.Drawing.Point(90, 17)
        Me.dtpfinicio.Name = "dtpfinicio"
        Me.dtpfinicio.Size = New System.Drawing.Size(97, 20)
        Me.dtpfinicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'frmRptMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRptMovimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Movimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TipoDocEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDocEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents cmbalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmovi As System.Windows.Forms.ComboBox
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnizpass As System.Windows.Forms.Button
    Friend WithEvents btndpass As System.Windows.Forms.Button
    Friend WithEvents btnipass As System.Windows.Forms.Button
    Friend WithEvents btndtodo As System.Windows.Forms.Button
    Friend WithEvents lb2 As System.Windows.Forms.ListBox
    Friend WithEvents lb1 As System.Windows.Forms.ListBox
    Friend WithEvents TipoDocEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TipoDocEBindingSource As System.Windows.Forms.BindingSource
End Class
