<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnviarFE
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DtFechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroguia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "enviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DtFechaDoc
        '
        Me.DtFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaDoc.Location = New System.Drawing.Point(450, 12)
        Me.DtFechaDoc.Name = "DtFechaDoc"
        Me.DtFechaDoc.Size = New System.Drawing.Size(96, 20)
        Me.DtFechaDoc.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Doc : "
        '
        'txtNroguia
        '
        Me.txtNroguia.Location = New System.Drawing.Point(209, 77)
        Me.txtNroguia.Name = "txtNroguia"
        Me.txtNroguia.Size = New System.Drawing.Size(201, 20)
        Me.txtNroguia.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(159, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nroguia"
        '
        'FrmEnviarFE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 302)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNroguia)
        Me.Controls.Add(Me.DtFechaDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmEnviarFE"
        Me.Text = "FrmEnviarFE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DtFechaDoc As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNroguia As TextBox
    Friend WithEvents Label1 As Label
End Class
