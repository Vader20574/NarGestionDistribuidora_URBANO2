<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptCompraSu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptCompraSu))
        Me.btnconsul = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbdocu = New System.Windows.Forms.ComboBox
        Me.cmbproveedor = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnconsul
        '
        Me.btnconsul.Location = New System.Drawing.Point(378, 149)
        Me.btnconsul.Name = "btnconsul"
        Me.btnconsul.Size = New System.Drawing.Size(75, 23)
        Me.btnconsul.TabIndex = 8
        Me.btnconsul.Text = "Consultar"
        Me.btnconsul.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbdocu)
        Me.GroupBox2.Controls.Add(Me.cmbproveedor)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 80)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Documento :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Proveedor :"
        '
        'cmbdocu
        '
        Me.cmbdocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdocu.FormattingEnabled = True
        Me.cmbdocu.Location = New System.Drawing.Point(130, 45)
        Me.cmbdocu.Name = "cmbdocu"
        Me.cmbdocu.Size = New System.Drawing.Size(238, 21)
        Me.cmbdocu.Sorted = True
        Me.cmbdocu.TabIndex = 6
        '
        'cmbproveedor
        '
        Me.cmbproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbproveedor.FormattingEnabled = True
        Me.cmbproveedor.Location = New System.Drawing.Point(130, 17)
        Me.cmbproveedor.MaxDropDownItems = 15
        Me.cmbproveedor.Name = "cmbproveedor"
        Me.cmbproveedor.Size = New System.Drawing.Size(238, 21)
        Me.cmbproveedor.TabIndex = 0
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
        Me.GroupBox1.TabIndex = 6
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
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(230, 149)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 9
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(32, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(238, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 10
        '
        'frmRptCompraSu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 183)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.btnconsul)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmRptCompraSu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Compras"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnconsul As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbdocu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
