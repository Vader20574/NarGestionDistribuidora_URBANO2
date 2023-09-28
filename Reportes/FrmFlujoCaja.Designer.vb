<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFlujoCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFlujoCaja))
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.btnconsul = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbSubCuentaContable = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbCuentaContable = New System.Windows.Forms.ComboBox
        Me.cbTipoMovimiento = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Caja = New System.Windows.Forms.Label
        Me.cmbcaja = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cksubcta = New System.Windows.Forms.CheckBox
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(382, 127)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 14
        '
        'btnconsul
        '
        Me.btnconsul.Location = New System.Drawing.Point(347, 231)
        Me.btnconsul.Name = "btnconsul"
        Me.btnconsul.Size = New System.Drawing.Size(75, 23)
        Me.btnconsul.TabIndex = 13
        Me.btnconsul.Text = "Consultar"
        Me.btnconsul.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cksubcta)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbSubCuentaContable)
        Me.GroupBox2.Controls.Add(Me.AxCrystalReport1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cbCuentaContable)
        Me.GroupBox2.Controls.Add(Me.cbTipoMovimiento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Caja)
        Me.GroupBox2.Controls.Add(Me.cmbcaja)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 161)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Sub Cuenta Contable : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSubCuentaContable
        '
        Me.cbSubCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbSubCuentaContable.Location = New System.Drawing.Point(130, 98)
        Me.cbSubCuentaContable.Name = "cbSubCuentaContable"
        Me.cbSubCuentaContable.Size = New System.Drawing.Size(238, 21)
        Me.cbSubCuentaContable.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(34, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 18)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Cuenta Contable : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCuentaContable
        '
        Me.cbCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbCuentaContable.Location = New System.Drawing.Point(130, 71)
        Me.cbCuentaContable.Name = "cbCuentaContable"
        Me.cbCuentaContable.Size = New System.Drawing.Size(238, 21)
        Me.cbCuentaContable.TabIndex = 25
        '
        'cbTipoMovimiento
        '
        Me.cbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoMovimiento.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO", "TODOS"})
        Me.cbTipoMovimiento.Location = New System.Drawing.Point(130, 44)
        Me.cbTipoMovimiento.Name = "cbTipoMovimiento"
        Me.cbTipoMovimiento.Size = New System.Drawing.Size(238, 21)
        Me.cbTipoMovimiento.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipo Ope :"
        '
        'Caja
        '
        Me.Caja.AutoSize = True
        Me.Caja.Location = New System.Drawing.Point(94, 21)
        Me.Caja.Name = "Caja"
        Me.Caja.Size = New System.Drawing.Size(34, 13)
        Me.Caja.TabIndex = 5
        Me.Caja.Text = "Caja :"
        '
        'cmbcaja
        '
        Me.cmbcaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcaja.FormattingEnabled = True
        Me.cmbcaja.Location = New System.Drawing.Point(130, 17)
        Me.cmbcaja.MaxDropDownItems = 15
        Me.cmbcaja.Name = "cmbcaja"
        Me.cmbcaja.Size = New System.Drawing.Size(238, 21)
        Me.cmbcaja.TabIndex = 0
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
        Me.GroupBox1.TabIndex = 11
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
        'Cksubcta
        '
        Me.Cksubcta.AutoSize = True
        Me.Cksubcta.Location = New System.Drawing.Point(130, 125)
        Me.Cksubcta.Name = "Cksubcta"
        Me.Cksubcta.Size = New System.Drawing.Size(177, 17)
        Me.Cksubcta.TabIndex = 29
        Me.Cksubcta.Text = "Todo las sub cuentas contables"
        Me.Cksubcta.UseVisualStyleBackColor = True
        '
        'FrmFlujoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 287)
        Me.Controls.Add(Me.btnconsul)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmFlujoCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Flujo de Caja"
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents btnconsul As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Caja As System.Windows.Forms.Label
    Friend WithEvents cmbcaja As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbSubCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents Cksubcta As System.Windows.Forms.CheckBox
End Class
