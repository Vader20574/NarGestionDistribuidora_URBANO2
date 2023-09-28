<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteCobranzaXCli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteCobranzaXCli))
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.comboRuta = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnpassizt = New System.Windows.Forms.Button
        Me.btnpassiz = New System.Windows.Forms.Button
        Me.btnpasde = New System.Windows.Forms.Button
        Me.btnpasdet = New System.Windows.Forms.Button
        Me.lbvende2 = New System.Windows.Forms.ListBox
        Me.lbvende1 = New System.Windows.Forms.ListBox
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.dgDetalleCobranza = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.lbruta2 = New System.Windows.Forms.ListBox
        Me.lbruta1 = New System.Windows.Forms.ListBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetalleCobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(756, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Ruta :"
        Me.Label3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfin)
        Me.GroupBox1.Controls.Add(Me.dtpinicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 40)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(300, 13)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(110, 20)
        Me.dtpfin.TabIndex = 1
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(96, 14)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(118, 20)
        Me.dtpinicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'comboRuta
        '
        Me.comboRuta.FormattingEnabled = True
        Me.comboRuta.Location = New System.Drawing.Point(782, 284)
        Me.comboRuta.Name = "comboRuta"
        Me.comboRuta.Size = New System.Drawing.Size(157, 21)
        Me.comboRuta.TabIndex = 14
        Me.comboRuta.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnpassizt)
        Me.GroupBox2.Controls.Add(Me.btnpassiz)
        Me.GroupBox2.Controls.Add(Me.btnpasde)
        Me.GroupBox2.Controls.Add(Me.btnpasdet)
        Me.GroupBox2.Controls.Add(Me.lbvende2)
        Me.GroupBox2.Controls.Add(Me.lbvende1)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(759, 214)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendedores"
        '
        'btnpassizt
        '
        Me.btnpassizt.Location = New System.Drawing.Point(344, 127)
        Me.btnpassizt.Name = "btnpassizt"
        Me.btnpassizt.Size = New System.Drawing.Size(65, 23)
        Me.btnpassizt.TabIndex = 1
        Me.btnpassizt.Text = "<<"
        Me.btnpassizt.UseVisualStyleBackColor = True
        '
        'btnpassiz
        '
        Me.btnpassiz.Location = New System.Drawing.Point(344, 92)
        Me.btnpassiz.Name = "btnpassiz"
        Me.btnpassiz.Size = New System.Drawing.Size(65, 23)
        Me.btnpassiz.TabIndex = 1
        Me.btnpassiz.Text = "<"
        Me.btnpassiz.UseVisualStyleBackColor = True
        '
        'btnpasde
        '
        Me.btnpasde.Location = New System.Drawing.Point(344, 57)
        Me.btnpasde.Name = "btnpasde"
        Me.btnpasde.Size = New System.Drawing.Size(65, 23)
        Me.btnpasde.TabIndex = 1
        Me.btnpasde.Text = ">"
        Me.btnpasde.UseVisualStyleBackColor = True
        '
        'btnpasdet
        '
        Me.btnpasdet.Location = New System.Drawing.Point(344, 22)
        Me.btnpasdet.Name = "btnpasdet"
        Me.btnpasdet.Size = New System.Drawing.Size(65, 23)
        Me.btnpasdet.TabIndex = 1
        Me.btnpasdet.Text = ">>"
        Me.btnpasdet.UseVisualStyleBackColor = True
        '
        'lbvende2
        '
        Me.lbvende2.FormattingEnabled = True
        Me.lbvende2.Location = New System.Drawing.Point(422, 19)
        Me.lbvende2.Name = "lbvende2"
        Me.lbvende2.Size = New System.Drawing.Size(321, 186)
        Me.lbvende2.TabIndex = 0
        '
        'lbvende1
        '
        Me.lbvende1.FormattingEnabled = True
        Me.lbvende1.Location = New System.Drawing.Point(18, 19)
        Me.lbvende1.Name = "lbvende1"
        Me.lbvende1.Size = New System.Drawing.Size(314, 186)
        Me.lbvende1.TabIndex = 0
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(181, 528)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(162, 20)
        Me.btnConsultar.TabIndex = 20
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dgDetalleCobranza
        '
        Me.dgDetalleCobranza.DataMember = ""
        Me.dgDetalleCobranza.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetalleCobranza.Location = New System.Drawing.Point(32, 554)
        Me.dgDetalleCobranza.Name = "dgDetalleCobranza"
        Me.dgDetalleCobranza.ReadOnly = True
        Me.dgDetalleCobranza.RowHeadersVisible = False
        Me.dgDetalleCobranza.Size = New System.Drawing.Size(728, 188)
        Me.dgDetalleCobranza.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(501, 530)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 20)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(773, 188)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.lbruta2)
        Me.GroupBox3.Controls.Add(Me.lbruta1)
        Me.GroupBox3.Location = New System.Drawing.Point(33, 308)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(759, 214)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ruta"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(343, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(343, 117)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(343, 82)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = ">"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(343, 47)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 23)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = ">>"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lbruta2
        '
        Me.lbruta2.FormattingEnabled = True
        Me.lbruta2.Location = New System.Drawing.Point(422, 22)
        Me.lbruta2.Name = "lbruta2"
        Me.lbruta2.Size = New System.Drawing.Size(321, 186)
        Me.lbruta2.TabIndex = 0
        '
        'lbruta1
        '
        Me.lbruta1.FormattingEnabled = True
        Me.lbruta1.Location = New System.Drawing.Point(18, 19)
        Me.lbruta1.Name = "lbruta1"
        Me.lbruta1.Size = New System.Drawing.Size(314, 186)
        Me.lbruta1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(537, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.Text = "Todo los vendedores"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(537, 46)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox2.TabIndex = 26
        Me.CheckBox2.Text = "Saldo menores de 0"
        Me.CheckBox2.UseVisualStyleBackColor = True
        Me.CheckBox2.Visible = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(681, 46)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox3.TabIndex = 27
        Me.CheckBox3.Text = "Por Cliente Principal"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(537, 69)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(181, 17)
        Me.CheckBox4.TabIndex = 28
        Me.CheckBox4.Text = "Por Cliente Principal Consolidado"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(681, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 26)
        Me.Button6.TabIndex = 30
        Me.Button6.Text = "Actualizar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(69, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Cliente Principal"
        '
        'FrmReporteCobranzaXCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 750)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgDetalleCobranza)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.comboRuta)
        Me.Name = "FrmReporteCobranzaXCli"
        Me.Text = "Reporte de Cobranza x Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDetalleCobranza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comboRuta As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnpassizt As System.Windows.Forms.Button
    Friend WithEvents btnpassiz As System.Windows.Forms.Button
    Friend WithEvents btnpasde As System.Windows.Forms.Button
    Friend WithEvents btnpasdet As System.Windows.Forms.Button
    Friend WithEvents lbvende2 As System.Windows.Forms.ListBox
    Friend WithEvents lbvende1 As System.Windows.Forms.ListBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dgDetalleCobranza As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lbruta2 As System.Windows.Forms.ListBox
    Friend WithEvents lbruta1 As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
