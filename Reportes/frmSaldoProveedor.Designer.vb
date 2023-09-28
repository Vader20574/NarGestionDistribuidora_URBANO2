<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaldoProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaldoProveedores))
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LstSelecDistrito = New System.Windows.Forms.ListBox
        Me.LstDispDistrito = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.ImageIndex = 10
        Me.Button6.Location = New System.Drawing.Point(325, 160)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 32)
        Me.Button6.TabIndex = 68
        Me.Button6.Text = "<<"
        '
        'Button7
        '
        Me.Button7.ImageIndex = 8
        Me.Button7.Location = New System.Drawing.Point(325, 120)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 32)
        Me.Button7.TabIndex = 67
        Me.Button7.Text = "<"
        '
        'Button8
        '
        Me.Button8.ImageIndex = 9
        Me.Button8.Location = New System.Drawing.Point(325, 80)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 32)
        Me.Button8.TabIndex = 66
        Me.Button8.Text = ">>"
        '
        'Button9
        '
        Me.Button9.ImageIndex = 7
        Me.Button9.Location = New System.Drawing.Point(325, 40)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 32)
        Me.Button9.TabIndex = 65
        Me.Button9.Text = ">"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(391, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Proveedores Seleccionados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Proveedores Disponibles"
        '
        'LstSelecDistrito
        '
        Me.LstSelecDistrito.Location = New System.Drawing.Point(389, 38)
        Me.LstSelecDistrito.Name = "LstSelecDistrito"
        Me.LstSelecDistrito.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecDistrito.TabIndex = 62
        '
        'LstDispDistrito
        '
        Me.LstDispDistrito.Location = New System.Drawing.Point(13, 38)
        Me.LstDispDistrito.Name = "LstDispDistrito"
        Me.LstDispDistrito.Size = New System.Drawing.Size(302, 160)
        Me.LstDispDistrito.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 60)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "REPORTE 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(603, 224)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 196
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(377, 238)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 67)
        Me.Button2.TabIndex = 197
        Me.Button2.Text = "REPORTE 2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmSaldoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 358)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LstSelecDistrito)
        Me.Controls.Add(Me.LstDispDistrito)
        Me.Name = "FrmSaldoProveedores"
        Me.Text = "FrmSaldoProveedores"
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LstSelecDistrito As System.Windows.Forms.ListBox
    Friend WithEvents LstDispDistrito As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
