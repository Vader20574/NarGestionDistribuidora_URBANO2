<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendedoresComision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendedoresComision))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnpassizt = New System.Windows.Forms.Button
        Me.btnpassiz = New System.Windows.Forms.Button
        Me.btnpasde = New System.Windows.Forms.Button
        Me.btnpasdet = New System.Windows.Forms.Button
        Me.lbvende2 = New System.Windows.Forms.ListBox
        Me.lbvende1 = New System.Windows.Forms.ListBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnmostrar = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnpassizt)
        Me.GroupBox2.Controls.Add(Me.btnpassiz)
        Me.GroupBox2.Controls.Add(Me.btnpasde)
        Me.GroupBox2.Controls.Add(Me.btnpasdet)
        Me.GroupBox2.Controls.Add(Me.lbvende2)
        Me.GroupBox2.Controls.Add(Me.lbvende1)
        Me.GroupBox2.Location = New System.Drawing.Point(92, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 214)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendedores"
        '
        'btnpassizt
        '
        Me.btnpassizt.Location = New System.Drawing.Point(246, 135)
        Me.btnpassizt.Name = "btnpassizt"
        Me.btnpassizt.Size = New System.Drawing.Size(65, 23)
        Me.btnpassizt.TabIndex = 1
        Me.btnpassizt.Text = "<<"
        Me.btnpassizt.UseVisualStyleBackColor = True
        '
        'btnpassiz
        '
        Me.btnpassiz.Location = New System.Drawing.Point(246, 100)
        Me.btnpassiz.Name = "btnpassiz"
        Me.btnpassiz.Size = New System.Drawing.Size(65, 23)
        Me.btnpassiz.TabIndex = 1
        Me.btnpassiz.Text = "<"
        Me.btnpassiz.UseVisualStyleBackColor = True
        '
        'btnpasde
        '
        Me.btnpasde.Location = New System.Drawing.Point(246, 65)
        Me.btnpasde.Name = "btnpasde"
        Me.btnpasde.Size = New System.Drawing.Size(65, 23)
        Me.btnpasde.TabIndex = 1
        Me.btnpasde.Text = ">"
        Me.btnpasde.UseVisualStyleBackColor = True
        '
        'btnpasdet
        '
        Me.btnpasdet.Location = New System.Drawing.Point(246, 30)
        Me.btnpasdet.Name = "btnpasdet"
        Me.btnpasdet.Size = New System.Drawing.Size(65, 23)
        Me.btnpasdet.TabIndex = 1
        Me.btnpasdet.Text = ">>"
        Me.btnpasdet.UseVisualStyleBackColor = True
        '
        'lbvende2
        '
        Me.lbvende2.FormattingEnabled = True
        Me.lbvende2.Location = New System.Drawing.Point(328, 19)
        Me.lbvende2.Name = "lbvende2"
        Me.lbvende2.Size = New System.Drawing.Size(208, 186)
        Me.lbvende2.TabIndex = 0
        '
        'lbvende1
        '
        Me.lbvende1.FormattingEnabled = True
        Me.lbvende1.Location = New System.Drawing.Point(17, 19)
        Me.lbvende1.Name = "lbvende1"
        Me.lbvende1.Size = New System.Drawing.Size(208, 186)
        Me.lbvende1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfin)
        Me.GroupBox1.Controls.Add(Me.dtpinicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(316, 12)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(110, 20)
        Me.dtpfin.TabIndex = 1
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(98, 12)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(110, 20)
        Me.dtpinicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(207, 313)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(119, 23)
        Me.btnmostrar.TabIndex = 5
        Me.btnmostrar.Text = "Con Comision"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(656, 28)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(707, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Mostrar por articulo"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(429, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Sin Comision"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmVendedoresComision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 348)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmVendedoresComision"
        Me.Text = "FrmVendedoresComision"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnpassizt As System.Windows.Forms.Button
    Friend WithEvents btnpassiz As System.Windows.Forms.Button
    Friend WithEvents btnpasde As System.Windows.Forms.Button
    Friend WithEvents btnpasdet As System.Windows.Forms.Button
    Friend WithEvents lbvende2 As System.Windows.Forms.ListBox
    Friend WithEvents lbvende1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnmostrar As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
