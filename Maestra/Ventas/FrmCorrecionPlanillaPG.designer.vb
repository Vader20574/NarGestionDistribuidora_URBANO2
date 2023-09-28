<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorrecionPlanillaPG
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtNroPlanilla = New System.Windows.Forms.TextBox
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpFechaReg = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbCaja = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbSubCuentaContable = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbCuentaContable = New System.Windows.Forms.ComboBox
        Me.cbProvee = New System.Windows.Forms.ComboBox
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(437, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Visible = False
        '
        'txtNroPlanilla
        '
        Me.txtNroPlanilla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroPlanilla.Location = New System.Drawing.Point(155, 39)
        Me.txtNroPlanilla.Name = "txtNroPlanilla"
        Me.txtNroPlanilla.Size = New System.Drawing.Size(137, 20)
        Me.txtNroPlanilla.TabIndex = 12
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(157, 67)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(118, 20)
        Me.dtpinicio.TabIndex = 13
        '
        'txtImporte
        '
        Me.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporte.Enabled = False
        Me.txtImporte.Location = New System.Drawing.Point(155, 121)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(137, 20)
        Me.txtImporte.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(355, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "TipoPlanilla : "
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(76, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "NroPlanilla : "
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(76, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Proveedor : "
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(89, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Importe : "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(407, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 50)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(93, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 21)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Fecha : "
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(155, 272)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(137, 20)
        Me.TextBox1.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(155, 298)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 20)
        Me.TextBox2.TabIndex = 26
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Registro Promociones        DobleClik o Enter para Seleccionar"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(63, 161)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(524, 101)
        Me.grid1.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(426, 308)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 50)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Modificar Destalle"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Location = New System.Drawing.Point(155, 404)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(137, 20)
        Me.TextBox5.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(83, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 21)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "NroPlanilla : "
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(83, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 21)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Numero : "
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(83, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 21)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Caja : "
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(83, 407)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 21)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Monto : "
        '
        'dtpFechaReg
        '
        Me.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReg.Location = New System.Drawing.Point(155, 432)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(87, 20)
        Me.dtpFechaReg.TabIndex = 72
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(83, 431)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 21)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Fecha : "
        '
        'cbCaja
        '
        Me.cbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCaja.ItemHeight = 13
        Me.cbCaja.Location = New System.Drawing.Point(153, 324)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(211, 21)
        Me.cbCaja.TabIndex = 75
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 381)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 18)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Sub Cuenta Contable : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSubCuentaContable
        '
        Me.cbSubCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbSubCuentaContable.Location = New System.Drawing.Point(153, 378)
        Me.cbSubCuentaContable.Name = "cbSubCuentaContable"
        Me.cbSubCuentaContable.Size = New System.Drawing.Size(211, 21)
        Me.cbSubCuentaContable.TabIndex = 76
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(5, 353)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 18)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Cuenta Contable : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCuentaContable
        '
        Me.cbCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbCuentaContable.Location = New System.Drawing.Point(153, 351)
        Me.cbCuentaContable.Name = "cbCuentaContable"
        Me.cbCuentaContable.Size = New System.Drawing.Size(211, 21)
        Me.cbCuentaContable.TabIndex = 78
        '
        'cbProvee
        '
        Me.cbProvee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvee.ItemHeight = 13
        Me.cbProvee.Location = New System.Drawing.Point(155, 93)
        Me.cbProvee.Name = "cbProvee"
        Me.cbProvee.Size = New System.Drawing.Size(224, 21)
        Me.cbProvee.TabIndex = 80
        '
        'FrmCorrecionPlanillaPG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 515)
        Me.Controls.Add(Me.cbProvee)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbCuentaContable)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbSubCuentaContable)
        Me.Controls.Add(Me.cbCaja)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpFechaReg)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.dtpinicio)
        Me.Controls.Add(Me.txtNroPlanilla)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "FrmCorrecionPlanillaPG"
        Me.Text = "Correcion Planilla Pago Proveedor"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbSubCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents cbProvee As System.Windows.Forms.ComboBox
End Class
