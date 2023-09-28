<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptVentasSunat2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptVentasSunat2))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnizpass = New System.Windows.Forms.Button
        Me.btndpass = New System.Windows.Forms.Button
        Me.btnipass = New System.Windows.Forms.Button
        Me.btndtodo = New System.Windows.Forms.Button
        Me.lb2 = New System.Windows.Forms.ListBox
        Me.TipoDocEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lb1 = New System.Windows.Forms.ListBox
        Me.TipoDocEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnconsul = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbvendedor = New System.Windows.Forms.ComboBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LstSelecDistrito = New System.Windows.Forms.ListBox
        Me.LstDispDistrito = New System.Windows.Forms.ListBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        CType(Me.TipoDocEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDocEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnizpass)
        Me.GroupBox2.Controls.Add(Me.btndpass)
        Me.GroupBox2.Controls.Add(Me.btnipass)
        Me.GroupBox2.Controls.Add(Me.btndtodo)
        Me.GroupBox2.Controls.Add(Me.lb2)
        Me.GroupBox2.Controls.Add(Me.lb1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(708, 246)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documentos"
        '
        'btnizpass
        '
        Me.btnizpass.Location = New System.Drawing.Point(319, 165)
        Me.btnizpass.Name = "btnizpass"
        Me.btnizpass.Size = New System.Drawing.Size(59, 23)
        Me.btnizpass.TabIndex = 1
        Me.btnizpass.Text = "<<"
        Me.btnizpass.UseVisualStyleBackColor = True
        '
        'btndpass
        '
        Me.btndpass.Location = New System.Drawing.Point(319, 85)
        Me.btndpass.Name = "btndpass"
        Me.btndpass.Size = New System.Drawing.Size(59, 23)
        Me.btndpass.TabIndex = 1
        Me.btndpass.Text = ">"
        Me.btndpass.UseVisualStyleBackColor = True
        '
        'btnipass
        '
        Me.btnipass.Location = New System.Drawing.Point(319, 126)
        Me.btnipass.Name = "btnipass"
        Me.btnipass.Size = New System.Drawing.Size(59, 23)
        Me.btnipass.TabIndex = 1
        Me.btnipass.Text = "<"
        Me.btnipass.UseVisualStyleBackColor = True
        '
        'btndtodo
        '
        Me.btndtodo.Location = New System.Drawing.Point(319, 46)
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
        Me.lb2.Location = New System.Drawing.Point(386, 15)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(304, 212)
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
        Me.lb1.Location = New System.Drawing.Point(10, 19)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(302, 212)
        Me.lb1.TabIndex = 0
        Me.lb1.ValueMember = "CODIGO"
        '
        'TipoDocEBindingSource
        '
        Me.TipoDocEBindingSource.DataSource = GetType(NarGestionDistribuidora.TipoDocE)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfin)
        Me.GroupBox1.Controls.Add(Me.dtpinicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(300, 13)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(110, 20)
        Me.dtpfin.TabIndex = 1
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(86, 13)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(118, 20)
        Me.dtpinicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'btnconsul
        '
        Me.btnconsul.Location = New System.Drawing.Point(293, 644)
        Me.btnconsul.Name = "btnconsul"
        Me.btnconsul.Size = New System.Drawing.Size(120, 40)
        Me.btnconsul.TabIndex = 5
        Me.btnconsul.Text = "Consultar"
        Me.btnconsul.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(80, 720)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Vendedor :"
        '
        'cmbvendedor
        '
        Me.cmbvendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvendedor.FormattingEnabled = True
        Me.cmbvendedor.Location = New System.Drawing.Point(142, 317)
        Me.cmbvendedor.Name = "cmbvendedor"
        Me.cmbvendedor.Size = New System.Drawing.Size(238, 21)
        Me.cmbvendedor.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.ImageIndex = 10
        Me.Button6.Location = New System.Drawing.Point(334, 494)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 32)
        Me.Button6.TabIndex = 76
        Me.Button6.Text = "<<"
        '
        'Button7
        '
        Me.Button7.ImageIndex = 8
        Me.Button7.Location = New System.Drawing.Point(334, 454)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 32)
        Me.Button7.TabIndex = 75
        Me.Button7.Text = "<"
        '
        'Button8
        '
        Me.Button8.ImageIndex = 9
        Me.Button8.Location = New System.Drawing.Point(334, 414)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 32)
        Me.Button8.TabIndex = 74
        Me.Button8.Text = ">>"
        '
        'Button9
        '
        Me.Button9.ImageIndex = 7
        Me.Button9.Location = New System.Drawing.Point(334, 374)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 32)
        Me.Button9.TabIndex = 73
        Me.Button9.Text = ">"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Cliente Dep Seleccionados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Cliente Dep Disponibles"
        '
        'LstSelecDistrito
        '
        Me.LstSelecDistrito.Location = New System.Drawing.Point(398, 372)
        Me.LstSelecDistrito.Name = "LstSelecDistrito"
        Me.LstSelecDistrito.Size = New System.Drawing.Size(310, 238)
        Me.LstSelecDistrito.TabIndex = 70
        '
        'LstDispDistrito
        '
        Me.LstDispDistrito.Location = New System.Drawing.Point(22, 372)
        Me.LstDispDistrito.Name = "LstDispDistrito"
        Me.LstDispDistrito.Size = New System.Drawing.Size(302, 238)
        Me.LstDispDistrito.TabIndex = 69
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(53, 644)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox1.TabIndex = 78
        Me.CheckBox1.Text = "Doc Masivo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmRptVentasSunat2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 759)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LstSelecDistrito)
        Me.Controls.Add(Me.LstDispDistrito)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnconsul)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmbvendedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Name = "frmRptVentasSunat2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Venta Sunat (Anulados)"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TipoDocEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDocEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnconsul As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents lb2 As System.Windows.Forms.ListBox
    Friend WithEvents lb1 As System.Windows.Forms.ListBox
    Friend WithEvents btndtodo As System.Windows.Forms.Button
    Friend WithEvents btnizpass As System.Windows.Forms.Button
    Friend WithEvents btndpass As System.Windows.Forms.Button
    Friend WithEvents btnipass As System.Windows.Forms.Button
    Friend WithEvents TipoDocEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TipoDocEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbvendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LstSelecDistrito As System.Windows.Forms.ListBox
    Friend WithEvents LstDispDistrito As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
