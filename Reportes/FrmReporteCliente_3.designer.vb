<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteCliente_3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteCliente_3))
        Me.BtnQuitaTodo = New System.Windows.Forms.Button
        Me.BtnQuitaUno = New System.Windows.Forms.Button
        Me.BtnPasaTodo = New System.Windows.Forms.Button
        Me.BtnPasaUno = New System.Windows.Forms.Button
        Me.LblTitSelec = New System.Windows.Forms.Label
        Me.LblTitDisp = New System.Windows.Forms.Label
        Me.LstSelec = New System.Windows.Forms.ListBox
        Me.LstDisp = New System.Windows.Forms.ListBox
        Me.BtnQuitaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnQuitaUno_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaUno_Ruta = New System.Windows.Forms.Button
        Me.LstSelecRuta = New System.Windows.Forms.ListBox
        Me.LstDispRuta = New System.Windows.Forms.ListBox
        Me.BtnQuitaTodo_Distrito = New System.Windows.Forms.Button
        Me.BtnQuitaUno_Distrito = New System.Windows.Forms.Button
        Me.BtnPasaTodo_Distrito = New System.Windows.Forms.Button
        Me.BtnPasaUno_Distrito = New System.Windows.Forms.Button
        Me.LstSelecDistrito = New System.Windows.Forms.ListBox
        Me.LstDispDistrito = New System.Windows.Forms.ListBox
        Me.btnReporte = New System.Windows.Forms.Button
        Me.rbInactivo = New System.Windows.Forms.RadioButton
        Me.rbActivo = New System.Windows.Forms.RadioButton
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cdepa = New System.Windows.Forms.ComboBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.cciud = New System.Windows.Forms.ComboBox
        Me.cbopais = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnQuitaTodo
        '
        Me.BtnQuitaTodo.ImageIndex = 10
        Me.BtnQuitaTodo.Location = New System.Drawing.Point(1062, 149)
        Me.BtnQuitaTodo.Name = "BtnQuitaTodo"
        Me.BtnQuitaTodo.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo.TabIndex = 15
        Me.BtnQuitaTodo.Text = "<<"
        '
        'BtnQuitaUno
        '
        Me.BtnQuitaUno.ImageIndex = 8
        Me.BtnQuitaUno.Location = New System.Drawing.Point(1062, 109)
        Me.BtnQuitaUno.Name = "BtnQuitaUno"
        Me.BtnQuitaUno.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno.TabIndex = 14
        Me.BtnQuitaUno.Text = "<"
        '
        'BtnPasaTodo
        '
        Me.BtnPasaTodo.ImageIndex = 9
        Me.BtnPasaTodo.Location = New System.Drawing.Point(1062, 69)
        Me.BtnPasaTodo.Name = "BtnPasaTodo"
        Me.BtnPasaTodo.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo.TabIndex = 13
        Me.BtnPasaTodo.Text = ">>"
        '
        'BtnPasaUno
        '
        Me.BtnPasaUno.ImageIndex = 7
        Me.BtnPasaUno.Location = New System.Drawing.Point(1062, 29)
        Me.BtnPasaUno.Name = "BtnPasaUno"
        Me.BtnPasaUno.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno.TabIndex = 12
        Me.BtnPasaUno.Text = ">"
        '
        'LblTitSelec
        '
        Me.LblTitSelec.AutoSize = True
        Me.LblTitSelec.Location = New System.Drawing.Point(1128, 11)
        Me.LblTitSelec.Name = "LblTitSelec"
        Me.LblTitSelec.Size = New System.Drawing.Size(117, 13)
        Me.LblTitSelec.TabIndex = 11
        Me.LblTitSelec.Text = "Clientes Seleccionados"
        '
        'LblTitDisp
        '
        Me.LblTitDisp.AutoSize = True
        Me.LblTitDisp.Location = New System.Drawing.Point(772, 11)
        Me.LblTitDisp.Name = "LblTitDisp"
        Me.LblTitDisp.Size = New System.Drawing.Size(144, 13)
        Me.LblTitDisp.TabIndex = 10
        Me.LblTitDisp.Text = "Clientes Principal Disponibles"
        '
        'LstSelec
        '
        Me.LstSelec.Location = New System.Drawing.Point(1126, 27)
        Me.LstSelec.Name = "LstSelec"
        Me.LstSelec.Size = New System.Drawing.Size(310, 160)
        Me.LstSelec.TabIndex = 9
        '
        'LstDisp
        '
        Me.LstDisp.Location = New System.Drawing.Point(750, 27)
        Me.LstDisp.Name = "LstDisp"
        Me.LstDisp.Size = New System.Drawing.Size(302, 160)
        Me.LstDisp.TabIndex = 8
        '
        'BtnQuitaTodo_Ruta
        '
        Me.BtnQuitaTodo_Ruta.ImageIndex = 10
        Me.BtnQuitaTodo_Ruta.Location = New System.Drawing.Point(322, 184)
        Me.BtnQuitaTodo_Ruta.Name = "BtnQuitaTodo_Ruta"
        Me.BtnQuitaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo_Ruta.TabIndex = 21
        Me.BtnQuitaTodo_Ruta.Text = "<<"
        '
        'BtnQuitaUno_Ruta
        '
        Me.BtnQuitaUno_Ruta.ImageIndex = 8
        Me.BtnQuitaUno_Ruta.Location = New System.Drawing.Point(322, 144)
        Me.BtnQuitaUno_Ruta.Name = "BtnQuitaUno_Ruta"
        Me.BtnQuitaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno_Ruta.TabIndex = 20
        Me.BtnQuitaUno_Ruta.Text = "<"
        '
        'BtnPasaTodo_Ruta
        '
        Me.BtnPasaTodo_Ruta.ImageIndex = 9
        Me.BtnPasaTodo_Ruta.Location = New System.Drawing.Point(322, 104)
        Me.BtnPasaTodo_Ruta.Name = "BtnPasaTodo_Ruta"
        Me.BtnPasaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo_Ruta.TabIndex = 19
        Me.BtnPasaTodo_Ruta.Text = ">>"
        '
        'BtnPasaUno_Ruta
        '
        Me.BtnPasaUno_Ruta.ImageIndex = 7
        Me.BtnPasaUno_Ruta.Location = New System.Drawing.Point(322, 64)
        Me.BtnPasaUno_Ruta.Name = "BtnPasaUno_Ruta"
        Me.BtnPasaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno_Ruta.TabIndex = 18
        Me.BtnPasaUno_Ruta.Text = ">"
        '
        'LstSelecRuta
        '
        Me.LstSelecRuta.Location = New System.Drawing.Point(386, 60)
        Me.LstSelecRuta.Name = "LstSelecRuta"
        Me.LstSelecRuta.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecRuta.TabIndex = 17
        '
        'LstDispRuta
        '
        Me.LstDispRuta.Location = New System.Drawing.Point(10, 60)
        Me.LstDispRuta.Name = "LstDispRuta"
        Me.LstDispRuta.Size = New System.Drawing.Size(302, 160)
        Me.LstDispRuta.TabIndex = 16
        '
        'BtnQuitaTodo_Distrito
        '
        Me.BtnQuitaTodo_Distrito.ImageIndex = 10
        Me.BtnQuitaTodo_Distrito.Location = New System.Drawing.Point(1087, 422)
        Me.BtnQuitaTodo_Distrito.Name = "BtnQuitaTodo_Distrito"
        Me.BtnQuitaTodo_Distrito.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo_Distrito.TabIndex = 27
        Me.BtnQuitaTodo_Distrito.Text = "<<"
        '
        'BtnQuitaUno_Distrito
        '
        Me.BtnQuitaUno_Distrito.ImageIndex = 8
        Me.BtnQuitaUno_Distrito.Location = New System.Drawing.Point(1087, 382)
        Me.BtnQuitaUno_Distrito.Name = "BtnQuitaUno_Distrito"
        Me.BtnQuitaUno_Distrito.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno_Distrito.TabIndex = 26
        Me.BtnQuitaUno_Distrito.Text = "<"
        '
        'BtnPasaTodo_Distrito
        '
        Me.BtnPasaTodo_Distrito.ImageIndex = 9
        Me.BtnPasaTodo_Distrito.Location = New System.Drawing.Point(1087, 342)
        Me.BtnPasaTodo_Distrito.Name = "BtnPasaTodo_Distrito"
        Me.BtnPasaTodo_Distrito.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo_Distrito.TabIndex = 25
        Me.BtnPasaTodo_Distrito.Text = ">>"
        '
        'BtnPasaUno_Distrito
        '
        Me.BtnPasaUno_Distrito.ImageIndex = 7
        Me.BtnPasaUno_Distrito.Location = New System.Drawing.Point(1087, 302)
        Me.BtnPasaUno_Distrito.Name = "BtnPasaUno_Distrito"
        Me.BtnPasaUno_Distrito.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno_Distrito.TabIndex = 24
        Me.BtnPasaUno_Distrito.Text = ">"
        '
        'LstSelecDistrito
        '
        Me.LstSelecDistrito.Location = New System.Drawing.Point(1151, 299)
        Me.LstSelecDistrito.Name = "LstSelecDistrito"
        Me.LstSelecDistrito.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecDistrito.TabIndex = 23
        '
        'LstDispDistrito
        '
        Me.LstDispDistrito.Location = New System.Drawing.Point(775, 299)
        Me.LstDispDistrito.Name = "LstDispDistrito"
        Me.LstDispDistrito.Size = New System.Drawing.Size(302, 160)
        Me.LstDispDistrito.TabIndex = 22
        '
        'btnReporte
        '
        Me.btnReporte.Location = New System.Drawing.Point(306, 304)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(123, 30)
        Me.btnReporte.TabIndex = 45
        Me.btnReporte.Text = "Reporte "
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'rbInactivo
        '
        Me.rbInactivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbInactivo.Location = New System.Drawing.Point(391, 254)
        Me.rbInactivo.Name = "rbInactivo"
        Me.rbInactivo.Size = New System.Drawing.Size(95, 16)
        Me.rbInactivo.TabIndex = 48
        Me.rbInactivo.Text = "Inactivo"
        '
        'rbActivo
        '
        Me.rbActivo.Checked = True
        Me.rbActivo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbActivo.Location = New System.Drawing.Point(181, 254)
        Me.rbActivo.Name = "rbActivo"
        Me.rbActivo.Size = New System.Drawing.Size(68, 19)
        Me.rbActivo.TabIndex = 47
        Me.rbActivo.TabStop = True
        Me.rbActivo.Text = "Activo"
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(1307, 516)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Vendedor Disponibles"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Vendedor Seleccionados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(777, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Distrito Del Cliente Dependiente Disponibles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1148, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Distrito Seleccionados"
        '
        'cdepa
        '
        Me.cdepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdepa.Location = New System.Drawing.Point(863, 230)
        Me.cdepa.Name = "cdepa"
        Me.cdepa.Size = New System.Drawing.Size(197, 21)
        Me.cdepa.TabIndex = 57
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(771, 232)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 13)
        Me.Label36.TabIndex = 56
        Me.Label36.Text = "Departamento :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cciud
        '
        Me.cciud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cciud.Location = New System.Drawing.Point(863, 255)
        Me.cciud.Name = "cciud"
        Me.cciud.Size = New System.Drawing.Size(197, 21)
        Me.cciud.TabIndex = 59
        '
        'cbopais
        '
        Me.cbopais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopais.Location = New System.Drawing.Point(863, 207)
        Me.cbopais.Name = "cbopais"
        Me.cbopais.Size = New System.Drawing.Size(197, 21)
        Me.cbopais.TabIndex = 55
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(822, 209)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(35, 13)
        Me.Label29.TabIndex = 54
        Me.Label29.Text = "País :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(797, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Provincia :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1151, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 30)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Reporte Falta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmReporteCliente_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 365)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cdepa)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.cciud)
        Me.Controls.Add(Me.cbopais)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.rbInactivo)
        Me.Controls.Add(Me.rbActivo)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.BtnQuitaTodo_Distrito)
        Me.Controls.Add(Me.BtnQuitaUno_Distrito)
        Me.Controls.Add(Me.BtnPasaTodo_Distrito)
        Me.Controls.Add(Me.BtnPasaUno_Distrito)
        Me.Controls.Add(Me.LstSelecDistrito)
        Me.Controls.Add(Me.LstDispDistrito)
        Me.Controls.Add(Me.BtnQuitaTodo_Ruta)
        Me.Controls.Add(Me.BtnQuitaUno_Ruta)
        Me.Controls.Add(Me.BtnPasaTodo_Ruta)
        Me.Controls.Add(Me.BtnPasaUno_Ruta)
        Me.Controls.Add(Me.LstSelecRuta)
        Me.Controls.Add(Me.LstDispRuta)
        Me.Controls.Add(Me.BtnQuitaTodo)
        Me.Controls.Add(Me.BtnQuitaUno)
        Me.Controls.Add(Me.BtnPasaTodo)
        Me.Controls.Add(Me.BtnPasaUno)
        Me.Controls.Add(Me.LblTitSelec)
        Me.Controls.Add(Me.LblTitDisp)
        Me.Controls.Add(Me.LstSelec)
        Me.Controls.Add(Me.LstDisp)
        Me.MaximizeBox = False
        Me.Name = "FrmReporteCliente_3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Cartera Cliente"
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnQuitaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents LstSelecRuta As System.Windows.Forms.ListBox
    Friend WithEvents LstDispRuta As System.Windows.Forms.ListBox
    Friend WithEvents BtnQuitaTodo_Distrito As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno_Distrito As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo_Distrito As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno_Distrito As System.Windows.Forms.Button
    Friend WithEvents LstSelecDistrito As System.Windows.Forms.ListBox
    Friend WithEvents LstDispDistrito As System.Windows.Forms.ListBox
    Friend WithEvents btnReporte As System.Windows.Forms.Button
    Friend WithEvents rbInactivo As System.Windows.Forms.RadioButton
    Friend WithEvents rbActivo As System.Windows.Forms.RadioButton
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cdepa As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cciud As System.Windows.Forms.ComboBox
    Friend WithEvents cbopais As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
