<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ventas_xvendedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ventas_xvendedor))
        Me.Button1 = New System.Windows.Forms.Button
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.txtruta = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(539, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 37)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvlista
        '
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Location = New System.Drawing.Point(22, 205)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.Size = New System.Drawing.Size(791, 187)
        Me.dgvlista.TabIndex = 30
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(139, 142)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(216, 20)
        Me.TextBox6.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 32
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 20)
        Me.TextBox2.TabIndex = 33
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(139, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 20)
        Me.TextBox3.TabIndex = 34
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(139, 90)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(216, 20)
        Me.TextBox4.TabIndex = 35
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(139, 116)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(216, 20)
        Me.TextBox5.TabIndex = 36
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(539, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 37)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Reporte Vendedor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(416, 96)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 39
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(139, 168)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(216, 20)
        Me.TextBox7.TabIndex = 40
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(539, 145)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 43)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Excel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(466, 1)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(261, 20)
        Me.txtruta.TabIndex = 44
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo de Texto (*.csv)|*.csv"
        Me.OpenFileDialog1.Title = "Seleccionar el Archivo Cvs"
        '
        'Frm_Ventas_xvendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 430)
        Me.Controls.Add(Me.txtruta)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_Ventas_xvendedor"
        Me.Text = "Form1"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
