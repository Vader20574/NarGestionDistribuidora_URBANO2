<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportePedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportePedido))
        Me.btnReporte = New System.Windows.Forms.Button
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cdistrito = New System.Windows.Forms.ComboBox
        Me.cmbruta = New System.Windows.Forms.ComboBox
        Me.cdepa = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.cmbvendedor = New System.Windows.Forms.ComboBox
        Me.cciud = New System.Windows.Forms.ComboBox
        Me.cbopais = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(312, 253)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(123, 30)
        Me.btnReporte.TabIndex = 45
        Me.btnReporte.Text = "Reporte"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(531, 662)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfin)
        Me.GroupBox1.Controls.Add(Me.dtpinicio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 40)
        Me.GroupBox1.TabIndex = 61
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Hasta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Desde :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cdistrito)
        Me.GroupBox2.Controls.Add(Me.cmbruta)
        Me.GroupBox2.Controls.Add(Me.cdepa)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.cmbvendedor)
        Me.GroupBox2.Controls.Add(Me.cciud)
        Me.GroupBox2.Controls.Add(Me.cbopais)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 176)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'cdistrito
        '
        Me.cdistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdistrito.Location = New System.Drawing.Point(130, 143)
        Me.cdistrito.Name = "cdistrito"
        Me.cdistrito.Size = New System.Drawing.Size(264, 21)
        Me.cdistrito.TabIndex = 71
        '
        'cmbruta
        '
        Me.cmbruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbruta.FormattingEnabled = True
        Me.cmbruta.Location = New System.Drawing.Point(130, 43)
        Me.cmbruta.Name = "cmbruta"
        Me.cmbruta.Size = New System.Drawing.Size(264, 21)
        Me.cmbruta.TabIndex = 4
        '
        'cdepa
        '
        Me.cdepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdepa.Location = New System.Drawing.Point(130, 93)
        Me.cdepa.Name = "cdepa"
        Me.cdepa.Size = New System.Drawing.Size(264, 21)
        Me.cdepa.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Vendedor :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(40, 97)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 13)
        Me.Label36.TabIndex = 66
        Me.Label36.Text = "Departamento :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ruta :"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(75, 147)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(45, 13)
        Me.Label37.TabIndex = 70
        Me.Label37.Text = "Distrito :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbvendedor
        '
        Me.cmbvendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbvendedor.FormattingEnabled = True
        Me.cmbvendedor.Location = New System.Drawing.Point(130, 18)
        Me.cmbvendedor.Name = "cmbvendedor"
        Me.cmbvendedor.Size = New System.Drawing.Size(264, 21)
        Me.cmbvendedor.TabIndex = 0
        '
        'cciud
        '
        Me.cciud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cciud.Location = New System.Drawing.Point(130, 118)
        Me.cciud.Name = "cciud"
        Me.cciud.Size = New System.Drawing.Size(264, 21)
        Me.cciud.TabIndex = 69
        '
        'cbopais
        '
        Me.cbopais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopais.Location = New System.Drawing.Point(130, 68)
        Me.cbopais.Name = "cbopais"
        Me.cbopais.Size = New System.Drawing.Size(264, 21)
        Me.cbopais.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Provincia :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(85, 72)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(35, 13)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "País :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmReportePedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 321)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.btnReporte)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmReportePedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Cartera Cliente"
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbruta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbvendedor As System.Windows.Forms.ComboBox
    Friend WithEvents cdistrito As System.Windows.Forms.ComboBox
    Friend WithEvents cdepa As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cciud As System.Windows.Forms.ComboBox
    Friend WithEvents cbopais As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
