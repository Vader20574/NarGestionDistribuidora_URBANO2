<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNroDoc2 = New System.Windows.Forms.TextBox()
        Me.txtNroDoc1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 27)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "* Anular Documentos por rango"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(256, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Nro. Doc 2:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNroDoc2
        '
        Me.txtNroDoc2.Location = New System.Drawing.Point(343, 74)
        Me.txtNroDoc2.Name = "txtNroDoc2"
        Me.txtNroDoc2.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDoc2.TabIndex = 44
        '
        'txtNroDoc1
        '
        Me.txtNroDoc1.Location = New System.Drawing.Point(343, 53)
        Me.txtNroDoc1.Name = "txtNroDoc1"
        Me.txtNroDoc1.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDoc1.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(463, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Anular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.Location = New System.Drawing.Point(98, 53)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(144, 21)
        Me.cbTipoDoc.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(256, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nro. Doc 1.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Tipo Doc. :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 147)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNroDoc2)
        Me.Controls.Add(Me.txtNroDoc1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbTipoDoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form11"
        Me.Text = "Anulacion Facturacion electronica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNroDoc2 As TextBox
    Friend WithEvents txtNroDoc1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbTipoDoc As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
