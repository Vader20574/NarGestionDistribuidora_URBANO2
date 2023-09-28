<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportaNex
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
        Me.btnprecios = New System.Windows.Forms.Button
        Me.btnproductos = New System.Windows.Forms.Button
        Me.btnclientes = New System.Windows.Forms.Button
        Me.btnvended = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnpago = New System.Windows.Forms.Button
        Me.btnbancos = New System.Windows.Forms.Button
        Me.btndeudas = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnprecios
        '
        Me.btnprecios.Location = New System.Drawing.Point(109, 99)
        Me.btnprecios.Name = "btnprecios"
        Me.btnprecios.Size = New System.Drawing.Size(131, 23)
        Me.btnprecios.TabIndex = 0
        Me.btnprecios.Text = "Exportar Precios"
        Me.btnprecios.UseVisualStyleBackColor = True
        '
        'btnproductos
        '
        Me.btnproductos.Location = New System.Drawing.Point(109, 12)
        Me.btnproductos.Name = "btnproductos"
        Me.btnproductos.Size = New System.Drawing.Size(131, 23)
        Me.btnproductos.TabIndex = 0
        Me.btnproductos.Text = "Exportar Productos"
        Me.btnproductos.UseVisualStyleBackColor = True
        '
        'btnclientes
        '
        Me.btnclientes.Location = New System.Drawing.Point(109, 70)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(131, 23)
        Me.btnclientes.TabIndex = 0
        Me.btnclientes.Text = "Exportar Clientes"
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'btnvended
        '
        Me.btnvended.Location = New System.Drawing.Point(109, 41)
        Me.btnvended.Name = "btnvended"
        Me.btnvended.Size = New System.Drawing.Size(131, 23)
        Me.btnvended.TabIndex = 0
        Me.btnvended.Text = "Exportar Vendedores"
        Me.btnvended.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(25, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nota : La exportación de datos borrara todos los registros de la tabla externa se" & _
            "leccionada de Nextel."
        '
        'btnpago
        '
        Me.btnpago.Location = New System.Drawing.Point(109, 128)
        Me.btnpago.Name = "btnpago"
        Me.btnpago.Size = New System.Drawing.Size(131, 23)
        Me.btnpago.TabIndex = 0
        Me.btnpago.Text = "Exportar Forma Pago"
        Me.btnpago.UseVisualStyleBackColor = True
        '
        'btnbancos
        '
        Me.btnbancos.Location = New System.Drawing.Point(109, 157)
        Me.btnbancos.Name = "btnbancos"
        Me.btnbancos.Size = New System.Drawing.Size(131, 23)
        Me.btnbancos.TabIndex = 0
        Me.btnbancos.Text = "Exportar Bancos"
        Me.btnbancos.UseVisualStyleBackColor = True
        '
        'btndeudas
        '
        Me.btndeudas.Location = New System.Drawing.Point(109, 186)
        Me.btndeudas.Name = "btndeudas"
        Me.btndeudas.Size = New System.Drawing.Size(131, 23)
        Me.btndeudas.TabIndex = 0
        Me.btndeudas.Text = "Exportar Deudas"
        Me.btndeudas.UseVisualStyleBackColor = True
        '
        'frmExportaNex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 272)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnvended)
        Me.Controls.Add(Me.btnclientes)
        Me.Controls.Add(Me.btnproductos)
        Me.Controls.Add(Me.btndeudas)
        Me.Controls.Add(Me.btnbancos)
        Me.Controls.Add(Me.btnpago)
        Me.Controls.Add(Me.btnprecios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmExportaNex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Data a Nextel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnprecios As System.Windows.Forms.Button
    Friend WithEvents btnproductos As System.Windows.Forms.Button
    Friend WithEvents btnclientes As System.Windows.Forms.Button
    Friend WithEvents btnvended As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnpago As System.Windows.Forms.Button
    Friend WithEvents btnbancos As System.Windows.Forms.Button
    Friend WithEvents btndeudas As System.Windows.Forms.Button
End Class
