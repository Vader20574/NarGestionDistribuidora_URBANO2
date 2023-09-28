<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActivacionPedido
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbAnulado = New System.Windows.Forms.RadioButton
        Me.rbTerminado = New System.Windows.Forms.RadioButton
        Me.rbPendiente = New System.Windows.Forms.RadioButton
        Me.txtNroDoc1 = New System.Windows.Forms.TextBox
        Me.txtNroDoc2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAnulado)
        Me.GroupBox1.Controls.Add(Me.rbTerminado)
        Me.GroupBox1.Controls.Add(Me.rbPendiente)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado"
        '
        'rbAnulado
        '
        Me.rbAnulado.AutoSize = True
        Me.rbAnulado.Location = New System.Drawing.Point(21, 78)
        Me.rbAnulado.Name = "rbAnulado"
        Me.rbAnulado.Size = New System.Drawing.Size(64, 17)
        Me.rbAnulado.TabIndex = 2
        Me.rbAnulado.TabStop = True
        Me.rbAnulado.Text = "Anulado"
        Me.rbAnulado.UseVisualStyleBackColor = True
        '
        'rbTerminado
        '
        Me.rbTerminado.AutoSize = True
        Me.rbTerminado.Location = New System.Drawing.Point(21, 55)
        Me.rbTerminado.Name = "rbTerminado"
        Me.rbTerminado.Size = New System.Drawing.Size(75, 17)
        Me.rbTerminado.TabIndex = 1
        Me.rbTerminado.TabStop = True
        Me.rbTerminado.Text = "Terminado"
        Me.rbTerminado.UseVisualStyleBackColor = True
        '
        'rbPendiente
        '
        Me.rbPendiente.AutoSize = True
        Me.rbPendiente.Location = New System.Drawing.Point(21, 32)
        Me.rbPendiente.Name = "rbPendiente"
        Me.rbPendiente.Size = New System.Drawing.Size(73, 17)
        Me.rbPendiente.TabIndex = 0
        Me.rbPendiente.TabStop = True
        Me.rbPendiente.Text = "Pendiente"
        Me.rbPendiente.UseVisualStyleBackColor = True
        '
        'txtNroDoc1
        '
        Me.txtNroDoc1.Location = New System.Drawing.Point(114, 54)
        Me.txtNroDoc1.Name = "txtNroDoc1"
        Me.txtNroDoc1.Size = New System.Drawing.Size(127, 20)
        Me.txtNroDoc1.TabIndex = 1
        '
        'txtNroDoc2
        '
        Me.txtNroDoc2.Location = New System.Drawing.Point(114, 80)
        Me.txtNroDoc2.Name = "txtNroDoc2"
        Me.txtNroDoc2.Size = New System.Drawing.Size(127, 20)
        Me.txtNroDoc2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Procesar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nro Pedido Inicial :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nro Pedido Final  :"
        '
        'FrmActivacionPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNroDoc2)
        Me.Controls.Add(Me.txtNroDoc1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmActivacionPedido"
        Me.Text = "FrmActivacionPedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbAnulado As System.Windows.Forms.RadioButton
    Friend WithEvents rbTerminado As System.Windows.Forms.RadioButton
    Friend WithEvents rbPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents txtNroDoc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNroDoc2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
