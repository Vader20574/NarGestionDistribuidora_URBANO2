<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.btnactualizar = New System.Windows.Forms.Button
        Me.btnsele = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtruta = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlista.Location = New System.Drawing.Point(-55, 87)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.Size = New System.Drawing.Size(1006, 293)
        Me.dgvlista.TabIndex = 14
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(351, 386)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 13
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btnsele
        '
        Me.btnsele.Location = New System.Drawing.Point(392, 40)
        Me.btnsele.Name = "btnsele"
        Me.btnsele.Size = New System.Drawing.Size(43, 23)
        Me.btnsele.TabIndex = 12
        Me.btnsele.Text = "..."
        Me.btnsele.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-51, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Ruta Excel :"
        '
        'txtruta
        '
        Me.txtruta.Enabled = False
        Me.txtruta.Location = New System.Drawing.Point(29, 41)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(357, 20)
        Me.txtruta.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo de Texto (*.csv)|*.csv"
        Me.OpenFileDialog1.Title = "Seleccionar el Archivo Cvs"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 448)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnsele)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtruta)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents btnsele As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
