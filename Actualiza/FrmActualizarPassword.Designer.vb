<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarPassword
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
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNACEPTAR = New System.Windows.Forms.Button
        Me.TXTPASSWORD2 = New System.Windows.Forms.TextBox
        Me.TXTPASSWORD1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ForeColor = System.Drawing.Color.Black
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.Location = New System.Drawing.Point(320, 47)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(89, 24)
        Me.BTNCANCELAR.TabIndex = 21
        Me.BTNCANCELAR.Text = "Cancelar"
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.Location = New System.Drawing.Point(320, 22)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(88, 21)
        Me.BTNACEPTAR.TabIndex = 20
        Me.BTNACEPTAR.Text = "Aceptar"
        '
        'TXTPASSWORD2
        '
        Me.TXTPASSWORD2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPASSWORD2.Location = New System.Drawing.Point(166, 52)
        Me.TXTPASSWORD2.Name = "TXTPASSWORD2"
        Me.TXTPASSWORD2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASSWORD2.Size = New System.Drawing.Size(137, 20)
        Me.TXTPASSWORD2.TabIndex = 19
        '
        'TXTPASSWORD1
        '
        Me.TXTPASSWORD1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPASSWORD1.Location = New System.Drawing.Point(166, 26)
        Me.TXTPASSWORD1.Name = "TXTPASSWORD1"
        Me.TXTPASSWORD1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPASSWORD1.Size = New System.Drawing.Size(137, 20)
        Me.TXTPASSWORD1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(53, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 14)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Confirmar Password :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(104, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 14)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Password :"
        '
        'FrmActualizarPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 108)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.TXTPASSWORD2)
        Me.Controls.Add(Me.TXTPASSWORD1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmActualizarPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmActualizarPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents TXTPASSWORD2 As System.Windows.Forms.TextBox
    Friend WithEvents TXTPASSWORD1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
