<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepPresentacionArticuloPrec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepPresentacionArticuloPrec))
        Me.cbosublinea = New System.Windows.Forms.ComboBox
        Me.cbolinea = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbosublinea
        '
        Me.cbosublinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosublinea.ItemHeight = 13
        Me.cbosublinea.Location = New System.Drawing.Point(134, 56)
        Me.cbosublinea.Name = "cbosublinea"
        Me.cbosublinea.Size = New System.Drawing.Size(282, 21)
        Me.cbosublinea.TabIndex = 27
        '
        'cbolinea
        '
        Me.cbolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolinea.ItemHeight = 13
        Me.cbolinea.Location = New System.Drawing.Point(134, 29)
        Me.cbolinea.Name = "cbolinea"
        Me.cbolinea.Size = New System.Drawing.Size(282, 21)
        Me.cbolinea.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(76, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Categoria :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(52, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Sub Categoria :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 35)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(477, 22)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 29
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(382, 118)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 17)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "Todos Articulo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(382, 158)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox2.TabIndex = 31
        Me.CheckBox2.Text = "Todos Subcategorias"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(382, 181)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox3.TabIndex = 32
        Me.CheckBox3.Text = "Presentacion Mayor"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(382, 237)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox4.TabIndex = 33
        Me.CheckBox4.Text = "Distribucion todos"
        Me.CheckBox4.UseVisualStyleBackColor = True
        Me.CheckBox4.Visible = False
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(382, 260)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox5.TabIndex = 34
        Me.CheckBox5.Text = "Distribucion Mayor"
        Me.CheckBox5.UseVisualStyleBackColor = True
        Me.CheckBox5.Visible = False
        '
        'FrmRepPresentacionArticuloPrec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 312)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbosublinea)
        Me.Controls.Add(Me.cbolinea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label18)
        Me.Name = "FrmRepPresentacionArticuloPrec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Presentacion y Articulo Precios"
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbosublinea As System.Windows.Forms.ComboBox
    Friend WithEvents cbolinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
End Class
