<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArreglos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtNroDoc1 = New System.Windows.Forms.TextBox()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtnroDespacho = New System.Windows.Forms.TextBox()
        Me.txtestado1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtNroDoc2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTipoDoc2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNroDoc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DtFechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNroDespacho2 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNroguia = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNroDoc1
        '
        Me.txtNroDoc1.Location = New System.Drawing.Point(350, 30)
        Me.txtNroDoc1.Name = "txtNroDoc1"
        Me.txtNroDoc1.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDoc1.TabIndex = 5
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.Location = New System.Drawing.Point(105, 30)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(144, 21)
        Me.cbTipoDoc.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(263, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nro. Doc 1.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(29, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Doc. :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(470, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Anular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtnroDespacho
        '
        Me.txtnroDespacho.Location = New System.Drawing.Point(153, 291)
        Me.txtnroDespacho.Name = "txtnroDespacho"
        Me.txtnroDespacho.Size = New System.Drawing.Size(96, 20)
        Me.txtnroDespacho.TabIndex = 12
        Me.txtnroDespacho.Visible = False
        '
        'txtestado1
        '
        Me.txtestado1.Location = New System.Drawing.Point(314, 291)
        Me.txtestado1.Name = "txtestado1"
        Me.txtestado1.Size = New System.Drawing.Size(96, 20)
        Me.txtestado1.TabIndex = 13
        Me.txtestado1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(433, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 49)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Regresar Despacho a Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(60, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 14)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nro Despacho:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(255, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 14)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Estado :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(235, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 18)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "F=Falta Actualizar"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(489, 117)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 20)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(397, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 14)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Nro Despacho:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(597, 102)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 62)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Regresar Generar Doc.Contables Anterior"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'txtNroDoc2
        '
        Me.txtNroDoc2.Location = New System.Drawing.Point(350, 51)
        Me.txtNroDoc2.Name = "txtNroDoc2"
        Me.txtNroDoc2.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDoc2.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(263, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Nro. Doc 2:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTipoDoc2
        '
        Me.cbTipoDoc2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc2.Location = New System.Drawing.Point(120, 218)
        Me.cbTipoDoc2.Name = "cbTipoDoc2"
        Me.cbTipoDoc2.Size = New System.Drawing.Size(144, 21)
        Me.cbTipoDoc2.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(32, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Tipo Doc. :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(348, 219)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDoc.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(277, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 14)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Nro. Doc :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Location = New System.Drawing.Point(525, 220)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(144, 21)
        Me.cboAlmacen.TabIndex = 27
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(675, 214)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 30)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Procesar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(439, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Almacen :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 27)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "* Anular Documentos por rango"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(40, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(177, 31)
        Me.Label12.TabIndex = 31
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(36, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(192, 33)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "* Modificar el Almacen del Documento "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtFechaDoc
        '
        Me.DtFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaDoc.Location = New System.Drawing.Point(294, 37)
        Me.DtFechaDoc.Name = "DtFechaDoc"
        Me.DtFechaDoc.Size = New System.Drawing.Size(96, 20)
        Me.DtFechaDoc.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(221, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Fecha Doc : "
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(412, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 49)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Modificar la Fecha de la Guia"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtNroDespacho2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.DtFechaDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 342)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 85)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cambiar Fecha Guia"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(17, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 14)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Nro Despacho:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNroDespacho2
        '
        Me.txtNroDespacho2.Location = New System.Drawing.Point(110, 34)
        Me.txtNroDespacho2.Name = "txtNroDespacho2"
        Me.txtNroDespacho2.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDespacho2.TabIndex = 36
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(193, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(103, 62)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Regresar Generar Doc.Contables "
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(-7, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 14)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Nro Despacho:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(85, 37)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(96, 20)
        Me.TextBox2.TabIndex = 37
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 92)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "* Regresar Generar Doc.Contables"
        '
        'txtNroguia
        '
        Me.txtNroguia.Location = New System.Drawing.Point(74, 28)
        Me.txtNroguia.Name = "txtNroguia"
        Me.txtNroguia.Size = New System.Drawing.Size(201, 20)
        Me.txtNroguia.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(24, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Nroguia"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(299, 23)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(162, 29)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "enviar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtNroguia)
        Me.GroupBox3.Location = New System.Drawing.Point(46, 462)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 68)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Enviar Facturacion Electronica"
        '
        'FrmArreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 582)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cboAlmacen)
        Me.Controls.Add(Me.txtNroDoc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbTipoDoc2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNroDoc2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtestado1)
        Me.Controls.Add(Me.txtnroDespacho)
        Me.Controls.Add(Me.txtNroDoc1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbTipoDoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "FrmArreglos"
        Me.Text = "FrmArreglos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNroDoc1 As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtnroDespacho As System.Windows.Forms.TextBox
    Friend WithEvents txtestado1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtNroDoc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DtFechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNroDespacho2 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNroguia As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
