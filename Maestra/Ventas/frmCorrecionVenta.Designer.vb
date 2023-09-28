<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorrecionVenta
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
        Me.txtNroPlanilla = New System.Windows.Forms.TextBox
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtNroPlanilla
        '
        Me.txtNroPlanilla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroPlanilla.Location = New System.Drawing.Point(109, 38)
        Me.txtNroPlanilla.Name = "txtNroPlanilla"
        Me.txtNroPlanilla.Size = New System.Drawing.Size(137, 20)
        Me.txtNroPlanilla.TabIndex = 13
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(109, 77)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(118, 20)
        Me.dtpinicio.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(109, 116)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 50)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 21)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "NroPlanilla : "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(54, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Fecha : "
        '
        'frmCorrecionVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 199)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtpinicio)
        Me.Controls.Add(Me.txtNroPlanilla)
        Me.Name = "frmCorrecionVenta"
        Me.Text = "frmCorrecionVenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNroPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
