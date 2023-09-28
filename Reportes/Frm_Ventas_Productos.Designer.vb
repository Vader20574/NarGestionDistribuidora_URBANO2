<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ventas_Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ventas_Productos))
        Me.Button1 = New System.Windows.Forms.Button
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.txtruta = New System.Windows.Forms.TextBox
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(881, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 37)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(906, 162)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(216, 20)
        Me.TextBox6.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(906, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 32
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(906, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(216, 20)
        Me.TextBox2.TabIndex = 33
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(906, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(216, 20)
        Me.TextBox3.TabIndex = 34
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(906, 105)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(216, 20)
        Me.TextBox4.TabIndex = 35
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(906, 131)
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
        Me.Button2.Text = "Reporte Todo"
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
        Me.TextBox7.Location = New System.Drawing.Point(1154, 132)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(261, 20)
        Me.TextBox7.TabIndex = 40
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(539, 151)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 43)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Excel"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo de Texto (*.csv)|*.csv"
        Me.OpenFileDialog1.Title = "Seleccionar el Archivo Cvs"
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlista.Location = New System.Drawing.Point(12, 205)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.Size = New System.Drawing.Size(845, 293)
        Me.dgvlista.TabIndex = 42
        '
        'txtruta
        '
        Me.txtruta.Location = New System.Drawing.Point(479, 44)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(261, 20)
        Me.txtruta.TabIndex = 43
        '
        'Frm_Ventas_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 430)
        Me.Controls.Add(Me.txtruta)
        Me.Controls.Add(Me.dgvlista)
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
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_Ventas_Productos"
        Me.Text = "Form1"
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
End Class
