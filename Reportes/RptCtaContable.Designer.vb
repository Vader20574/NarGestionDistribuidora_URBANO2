<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptCtaContable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptCtaContable))
        Me.BtnQuitaTodo = New System.Windows.Forms.Button
        Me.BtnQuitaUno = New System.Windows.Forms.Button
        Me.BtnPasaTodo = New System.Windows.Forms.Button
        Me.BtnPasaUno = New System.Windows.Forms.Button
        Me.LblTitSelec = New System.Windows.Forms.Label
        Me.LblTitDisp = New System.Windows.Forms.Label
        Me.LstSelec = New System.Windows.Forms.ListBox
        Me.LstDisp = New System.Windows.Forms.ListBox
        Me.cbCuentaContable = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LstSelecRuta = New System.Windows.Forms.ListBox
        Me.LstDispRuta = New System.Windows.Forms.ListBox
        Me.cbSubCuentaContable = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LstSelecDistrito = New System.Windows.Forms.ListBox
        Me.LstDispDistrito = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnQuitaTodo
        '
        Me.BtnQuitaTodo.ImageIndex = 10
        Me.BtnQuitaTodo.Location = New System.Drawing.Point(315, 224)
        Me.BtnQuitaTodo.Name = "BtnQuitaTodo"
        Me.BtnQuitaTodo.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo.TabIndex = 23
        Me.BtnQuitaTodo.Text = "<<"
        '
        'BtnQuitaUno
        '
        Me.BtnQuitaUno.ImageIndex = 8
        Me.BtnQuitaUno.Location = New System.Drawing.Point(315, 184)
        Me.BtnQuitaUno.Name = "BtnQuitaUno"
        Me.BtnQuitaUno.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno.TabIndex = 22
        Me.BtnQuitaUno.Text = "<"
        '
        'BtnPasaTodo
        '
        Me.BtnPasaTodo.ImageIndex = 9
        Me.BtnPasaTodo.Location = New System.Drawing.Point(315, 144)
        Me.BtnPasaTodo.Name = "BtnPasaTodo"
        Me.BtnPasaTodo.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo.TabIndex = 21
        Me.BtnPasaTodo.Text = ">>"
        '
        'BtnPasaUno
        '
        Me.BtnPasaUno.ImageIndex = 7
        Me.BtnPasaUno.Location = New System.Drawing.Point(315, 104)
        Me.BtnPasaUno.Name = "BtnPasaUno"
        Me.BtnPasaUno.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno.TabIndex = 20
        Me.BtnPasaUno.Text = ">"
        '
        'LblTitSelec
        '
        Me.LblTitSelec.AutoSize = True
        Me.LblTitSelec.Location = New System.Drawing.Point(376, 86)
        Me.LblTitSelec.Name = "LblTitSelec"
        Me.LblTitSelec.Size = New System.Drawing.Size(101, 13)
        Me.LblTitSelec.TabIndex = 19
        Me.LblTitSelec.Text = "Caja Seleccionados"
        '
        'LblTitDisp
        '
        Me.LblTitDisp.AutoSize = True
        Me.LblTitDisp.Location = New System.Drawing.Point(13, 88)
        Me.LblTitDisp.Name = "LblTitDisp"
        Me.LblTitDisp.Size = New System.Drawing.Size(85, 13)
        Me.LblTitDisp.TabIndex = 18
        Me.LblTitDisp.Text = "Caja Disponibles"
        '
        'LstSelec
        '
        Me.LstSelec.Location = New System.Drawing.Point(379, 102)
        Me.LstSelec.Name = "LstSelec"
        Me.LstSelec.Size = New System.Drawing.Size(310, 160)
        Me.LstSelec.TabIndex = 17
        '
        'LstDisp
        '
        Me.LstDisp.Location = New System.Drawing.Point(8, 104)
        Me.LstDisp.Name = "LstDisp"
        Me.LstDisp.Size = New System.Drawing.Size(302, 160)
        Me.LstDisp.TabIndex = 16
        '
        'cbCuentaContable
        '
        Me.cbCuentaContable.FormattingEnabled = True
        Me.cbCuentaContable.Location = New System.Drawing.Point(695, 263)
        Me.cbCuentaContable.Name = "cbCuentaContable"
        Me.cbCuentaContable.Size = New System.Drawing.Size(227, 21)
        Me.cbCuentaContable.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.ImageIndex = 10
        Me.Button1.Location = New System.Drawing.Point(326, 591)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 32)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "<<"
        '
        'Button2
        '
        Me.Button2.ImageIndex = 8
        Me.Button2.Location = New System.Drawing.Point(326, 551)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 32)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "<"
        '
        'Button3
        '
        Me.Button3.ImageIndex = 9
        Me.Button3.Location = New System.Drawing.Point(326, 511)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 32)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = ">>"
        '
        'Button4
        '
        Me.Button4.ImageIndex = 7
        Me.Button4.Location = New System.Drawing.Point(326, 471)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 32)
        Me.Button4.TabIndex = 29
        Me.Button4.Text = ">"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Sub Cta Contable Seleccionados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 452)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Sub Cta Contable Disponibles"
        '
        'LstSelecRuta
        '
        Me.LstSelecRuta.Location = New System.Drawing.Point(389, 469)
        Me.LstSelecRuta.Name = "LstSelecRuta"
        Me.LstSelecRuta.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecRuta.TabIndex = 26
        '
        'LstDispRuta
        '
        Me.LstDispRuta.Location = New System.Drawing.Point(15, 469)
        Me.LstDispRuta.Name = "LstDispRuta"
        Me.LstDispRuta.Size = New System.Drawing.Size(302, 160)
        Me.LstDispRuta.TabIndex = 25
        '
        'cbSubCuentaContable
        '
        Me.cbSubCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbSubCuentaContable.Location = New System.Drawing.Point(563, 290)
        Me.cbSubCuentaContable.Name = "cbSubCuentaContable"
        Me.cbSubCuentaContable.Size = New System.Drawing.Size(238, 21)
        Me.cbSubCuentaContable.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfin)
        Me.GroupBox1.Controls.Add(Me.dtpinicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(154, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 40)
        Me.GroupBox1.TabIndex = 34
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
        Me.dtpinicio.Location = New System.Drawing.Point(86, 13)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(118, 20)
        Me.dtpinicio.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(245, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Desde :"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(271, 651)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(159, 33)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Procesar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(526, 523)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 36
        '
        'Button6
        '
        Me.Button6.ImageIndex = 10
        Me.Button6.Location = New System.Drawing.Point(322, 412)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 32)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "<<"
        '
        'Button7
        '
        Me.Button7.ImageIndex = 8
        Me.Button7.Location = New System.Drawing.Point(322, 372)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 32)
        Me.Button7.TabIndex = 43
        Me.Button7.Text = "<"
        '
        'Button8
        '
        Me.Button8.ImageIndex = 9
        Me.Button8.Location = New System.Drawing.Point(322, 332)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 32)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = ">>"
        '
        'Button9
        '
        Me.Button9.ImageIndex = 7
        Me.Button9.Location = New System.Drawing.Point(322, 292)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 32)
        Me.Button9.TabIndex = 41
        Me.Button9.Text = ">"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(388, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Cta Contable Seleccionados"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Cta Contable Disponibles"
        '
        'LstSelecDistrito
        '
        Me.LstSelecDistrito.Location = New System.Drawing.Point(386, 290)
        Me.LstSelecDistrito.Name = "LstSelecDistrito"
        Me.LstSelecDistrito.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecDistrito.TabIndex = 38
        '
        'LstDispDistrito
        '
        Me.LstDispDistrito.Location = New System.Drawing.Point(10, 290)
        Me.LstDispDistrito.Name = "LstDispDistrito"
        Me.LstDispDistrito.Size = New System.Drawing.Size(302, 160)
        Me.LstDispDistrito.TabIndex = 37
        '
        'RptCtaContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 696)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LstSelecDistrito)
        Me.Controls.Add(Me.LstDispDistrito)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbSubCuentaContable)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LstSelecRuta)
        Me.Controls.Add(Me.LstDispRuta)
        Me.Controls.Add(Me.cbCuentaContable)
        Me.Controls.Add(Me.BtnQuitaTodo)
        Me.Controls.Add(Me.BtnQuitaUno)
        Me.Controls.Add(Me.BtnPasaTodo)
        Me.Controls.Add(Me.BtnPasaUno)
        Me.Controls.Add(Me.LblTitSelec)
        Me.Controls.Add(Me.LblTitDisp)
        Me.Controls.Add(Me.LstSelec)
        Me.Controls.Add(Me.LstDisp)
        Me.Name = "RptCtaContable"
        Me.Text = "RptCtaContable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnQuitaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno As System.Windows.Forms.Button
    Friend WithEvents LblTitSelec As System.Windows.Forms.Label
    Friend WithEvents LblTitDisp As System.Windows.Forms.Label
    Friend WithEvents LstSelec As System.Windows.Forms.ListBox
    Friend WithEvents LstDisp As System.Windows.Forms.ListBox
    Friend WithEvents cbCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LstSelecRuta As System.Windows.Forms.ListBox
    Friend WithEvents LstDispRuta As System.Windows.Forms.ListBox
    Friend WithEvents cbSubCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LstSelecDistrito As System.Windows.Forms.ListBox
    Friend WithEvents LstDispDistrito As System.Windows.Forms.ListBox
End Class
