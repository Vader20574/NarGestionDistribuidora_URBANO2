<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteRemo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteRemo))
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Button4 = New System.Windows.Forms.Button
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtEjercicio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(231, 109)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 63
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(43, 109)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(156, 34)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "Reporte"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(192, 42)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(136, 21)
        Me.cboPeriodo.TabIndex = 61
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(138, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "Periodo: "
        '
        'txtEjercicio
        '
        Me.txtEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEjercicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjercicio.Location = New System.Drawing.Point(90, 42)
        Me.txtEjercicio.MaxLength = 7
        Me.txtEjercicio.Name = "txtEjercicio"
        Me.txtEjercicio.Size = New System.Drawing.Size(40, 20)
        Me.txtEjercicio.TabIndex = 59
        Me.txtEjercicio.Text = "2010"
        Me.txtEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Ejercicio: "
        '
        'FrmReporteRemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 262)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtEjercicio)
        Me.Controls.Add(Me.Label10)
        Me.Name = "FrmReporteRemo"
        Me.Text = "FrmReporteRemo"
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEjercicio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
