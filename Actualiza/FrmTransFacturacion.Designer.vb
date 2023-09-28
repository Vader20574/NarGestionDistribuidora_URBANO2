<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransFacturacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grid1 = New System.Windows.Forms.DataGrid()
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTboleta = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNroDoc1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnAnular = New System.Windows.Forms.Button()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(229, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Procesos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Registro Promociones        DobleClik o Enter para Seleccionar"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(1, 129)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(1151, 254)
        Me.grid1.TabIndex = 16
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(153, 29)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(118, 20)
        Me.DtFechaIni.TabIndex = 18
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(331, 29)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(118, 20)
        Me.DtFechaFin.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(543, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 35)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Agregar Facturar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(933, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Total Boleta :"
        '
        'lblTboleta
        '
        Me.lblTboleta.AutoSize = True
        Me.lblTboleta.Location = New System.Drawing.Point(1009, 395)
        Me.lblTboleta.Name = "lblTboleta"
        Me.lblTboleta.Size = New System.Drawing.Size(39, 13)
        Me.lblTboleta.TabIndex = 22
        Me.lblTboleta.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1009, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(933, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Total Factura :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1009, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(963, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Total  :"
        '
        'txtNroDoc1
        '
        Me.txtNroDoc1.Location = New System.Drawing.Point(957, 98)
        Me.txtNroDoc1.Name = "txtNroDoc1"
        Me.txtNroDoc1.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDoc1.TabIndex = 28
        Me.txtNroDoc1.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1059, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 30)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.Location = New System.Drawing.Point(733, 99)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(144, 21)
        Me.cbTipoDoc.TabIndex = 27
        Me.cbTipoDoc.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(883, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nro. Doc :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(657, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Tipo Doc. :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(727, 39)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Eliminar Documento"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(906, 21)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(103, 41)
        Me.btnAnular.TabIndex = 33
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'FrmTransFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 473)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtNroDoc1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbTipoDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTboleta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DtFechaFin)
        Me.Controls.Add(Me.DtFechaIni)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmTransFacturacion"
        Me.Text = "Transferencia Facturacion Colgate"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTboleta As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNroDoc1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnAnular As Button
End Class
