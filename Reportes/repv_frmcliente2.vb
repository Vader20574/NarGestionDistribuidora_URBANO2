Public Class repv_frmcliente2
    Inherits System.Windows.Forms.Form
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CRT As AxCrystal.AxCrystalReport
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstcod2 As System.Windows.Forms.ListBox
    Friend WithEvents lstcod1 As System.Windows.Forms.ListBox
    Friend WithEvents lstclie2 As System.Windows.Forms.ListBox
    Friend WithEvents lstclie1 As System.Windows.Forms.ListBox
    Friend WithEvents cboptovta As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnQuitaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents LstSelecRuta As System.Windows.Forms.ListBox
    Friend WithEvents LstDispRuta As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnQuitaTodo_Distrito As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno_Distrito As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo_Distrito As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno_Distrito As System.Windows.Forms.Button
    Friend WithEvents LstSelecDistrito As System.Windows.Forms.ListBox
    Friend WithEvents LstDispDistrito As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repv_frmcliente2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstclie2 = New System.Windows.Forms.ListBox
        Me.lstclie1 = New System.Windows.Forms.ListBox
        Me.txtfiltro = New System.Windows.Forms.TextBox
        Me.cbomoneda = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboptovta = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.CRT = New AxCrystal.AxCrystalReport
        Me.lstcod2 = New System.Windows.Forms.ListBox
        Me.lstcod1 = New System.Windows.Forms.ListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnQuitaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnQuitaUno_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaUno_Ruta = New System.Windows.Forms.Button
        Me.LstSelecRuta = New System.Windows.Forms.ListBox
        Me.LstDispRuta = New System.Windows.Forms.ListBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.BtnQuitaTodo_Distrito = New System.Windows.Forms.Button
        Me.BtnQuitaUno_Distrito = New System.Windows.Forms.Button
        Me.BtnPasaTodo_Distrito = New System.Windows.Forms.Button
        Me.BtnPasaUno_Distrito = New System.Windows.Forms.Button
        Me.LstSelecDistrito = New System.Windows.Forms.ListBox
        Me.LstDispDistrito = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lstclie2)
        Me.GroupBox1.Controls.Add(Me.lstclie1)
        Me.GroupBox1.Location = New System.Drawing.Point(813, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 392)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Clientes para Busqueda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Clientes en General"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(332, 138)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 25)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = ">"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 25)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "<<"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(332, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 25)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = ">>"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(332, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<"
        '
        'lstclie2
        '
        Me.lstclie2.HorizontalScrollbar = True
        Me.lstclie2.Location = New System.Drawing.Point(402, 42)
        Me.lstclie2.Name = "lstclie2"
        Me.lstclie2.ScrollAlwaysVisible = True
        Me.lstclie2.Size = New System.Drawing.Size(303, 264)
        Me.lstclie2.TabIndex = 12
        '
        'lstclie1
        '
        Me.lstclie1.HorizontalScrollbar = True
        Me.lstclie1.Location = New System.Drawing.Point(15, 44)
        Me.lstclie1.Name = "lstclie1"
        Me.lstclie1.ScrollAlwaysVisible = True
        Me.lstclie1.Size = New System.Drawing.Size(303, 264)
        Me.lstclie1.TabIndex = 11
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(762, 584)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(272, 21)
        Me.txtfiltro.TabIndex = 23
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.Location = New System.Drawing.Point(828, 616)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(206, 21)
        Me.cbomoneda.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(767, 620)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Moneda : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfecha2)
        Me.GroupBox2.Controls.Add(Me.dtpfecha1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(193, 431)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 55)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas a Consultar"
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha2.Location = New System.Drawing.Point(224, 22)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(93, 21)
        Me.dtpfecha2.TabIndex = 3
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha1.Location = New System.Drawing.Point(59, 22)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(93, 21)
        Me.dtpfecha1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Al : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del : "
        '
        'cboptovta
        '
        Me.cboptovta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboptovta.Location = New System.Drawing.Point(847, 655)
        Me.cboptovta.Name = "cboptovta"
        Me.cboptovta.Size = New System.Drawing.Size(206, 21)
        Me.cboptovta.TabIndex = 18
        Me.cboptovta.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(751, 657)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Punto de Venta :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(754, 708)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Procesando Reporte......"
        Me.Label7.Visible = False
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(385, 513)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(176, 25)
        Me.btncancelar.TabIndex = 9
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(201, 513)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(176, 25)
        Me.btnaceptar.TabIndex = 8
        Me.btnaceptar.Text = "&Aceptar "
        '
        'CRT
        '
        Me.CRT.Enabled = True
        Me.CRT.Location = New System.Drawing.Point(620, 497)
        Me.CRT.Name = "CRT"
        Me.CRT.OcxState = CType(resources.GetObject("CRT.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CRT.Size = New System.Drawing.Size(28, 28)
        Me.CRT.TabIndex = 10
        '
        'lstcod2
        '
        Me.lstcod2.Location = New System.Drawing.Point(813, 122)
        Me.lstcod2.Name = "lstcod2"
        Me.lstcod2.Size = New System.Drawing.Size(157, 82)
        Me.lstcod2.TabIndex = 18
        '
        'lstcod1
        '
        Me.lstcod1.Location = New System.Drawing.Point(813, 14)
        Me.lstcod1.Name = "lstcod1"
        Me.lstcod1.Size = New System.Drawing.Size(157, 82)
        Me.lstcod1.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Rutas Seleccionados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Rutas Disponibles"
        '
        'BtnQuitaTodo_Ruta
        '
        Me.BtnQuitaTodo_Ruta.ImageIndex = 10
        Me.BtnQuitaTodo_Ruta.Location = New System.Drawing.Point(354, 144)
        Me.BtnQuitaTodo_Ruta.Name = "BtnQuitaTodo_Ruta"
        Me.BtnQuitaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo_Ruta.TabIndex = 57
        Me.BtnQuitaTodo_Ruta.Text = "<<"
        '
        'BtnQuitaUno_Ruta
        '
        Me.BtnQuitaUno_Ruta.ImageIndex = 8
        Me.BtnQuitaUno_Ruta.Location = New System.Drawing.Point(354, 104)
        Me.BtnQuitaUno_Ruta.Name = "BtnQuitaUno_Ruta"
        Me.BtnQuitaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno_Ruta.TabIndex = 56
        Me.BtnQuitaUno_Ruta.Text = "<"
        '
        'BtnPasaTodo_Ruta
        '
        Me.BtnPasaTodo_Ruta.ImageIndex = 9
        Me.BtnPasaTodo_Ruta.Location = New System.Drawing.Point(354, 64)
        Me.BtnPasaTodo_Ruta.Name = "BtnPasaTodo_Ruta"
        Me.BtnPasaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo_Ruta.TabIndex = 55
        Me.BtnPasaTodo_Ruta.Text = ">>"
        '
        'BtnPasaUno_Ruta
        '
        Me.BtnPasaUno_Ruta.ImageIndex = 7
        Me.BtnPasaUno_Ruta.Location = New System.Drawing.Point(354, 24)
        Me.BtnPasaUno_Ruta.Name = "BtnPasaUno_Ruta"
        Me.BtnPasaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno_Ruta.TabIndex = 54
        Me.BtnPasaUno_Ruta.Text = ">"
        '
        'LstSelecRuta
        '
        Me.LstSelecRuta.Location = New System.Drawing.Point(418, 20)
        Me.LstSelecRuta.Name = "LstSelecRuta"
        Me.LstSelecRuta.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecRuta.TabIndex = 53
        '
        'LstDispRuta
        '
        Me.LstDispRuta.Location = New System.Drawing.Point(42, 20)
        Me.LstDispRuta.Name = "LstDispRuta"
        Me.LstDispRuta.Size = New System.Drawing.Size(302, 160)
        Me.LstDispRuta.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(415, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Categoria Seleccionados"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Categoria Disponibles"
        '
        'BtnQuitaTodo_Distrito
        '
        Me.BtnQuitaTodo_Distrito.ImageIndex = 10
        Me.BtnQuitaTodo_Distrito.Location = New System.Drawing.Point(354, 358)
        Me.BtnQuitaTodo_Distrito.Name = "BtnQuitaTodo_Distrito"
        Me.BtnQuitaTodo_Distrito.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo_Distrito.TabIndex = 65
        Me.BtnQuitaTodo_Distrito.Text = "<<"
        '
        'BtnQuitaUno_Distrito
        '
        Me.BtnQuitaUno_Distrito.ImageIndex = 8
        Me.BtnQuitaUno_Distrito.Location = New System.Drawing.Point(354, 318)
        Me.BtnQuitaUno_Distrito.Name = "BtnQuitaUno_Distrito"
        Me.BtnQuitaUno_Distrito.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno_Distrito.TabIndex = 64
        Me.BtnQuitaUno_Distrito.Text = "<"
        '
        'BtnPasaTodo_Distrito
        '
        Me.BtnPasaTodo_Distrito.ImageIndex = 9
        Me.BtnPasaTodo_Distrito.Location = New System.Drawing.Point(354, 278)
        Me.BtnPasaTodo_Distrito.Name = "BtnPasaTodo_Distrito"
        Me.BtnPasaTodo_Distrito.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo_Distrito.TabIndex = 63
        Me.BtnPasaTodo_Distrito.Text = ">>"
        '
        'BtnPasaUno_Distrito
        '
        Me.BtnPasaUno_Distrito.ImageIndex = 7
        Me.BtnPasaUno_Distrito.Location = New System.Drawing.Point(354, 238)
        Me.BtnPasaUno_Distrito.Name = "BtnPasaUno_Distrito"
        Me.BtnPasaUno_Distrito.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno_Distrito.TabIndex = 62
        Me.BtnPasaUno_Distrito.Text = ">"
        '
        'LstSelecDistrito
        '
        Me.LstSelecDistrito.Location = New System.Drawing.Point(418, 235)
        Me.LstSelecDistrito.Name = "LstSelecDistrito"
        Me.LstSelecDistrito.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecDistrito.TabIndex = 61
        '
        'LstDispDistrito
        '
        Me.LstDispDistrito.Location = New System.Drawing.Point(42, 235)
        Me.LstDispDistrito.Name = "LstDispDistrito"
        Me.LstDispDistrito.Size = New System.Drawing.Size(302, 160)
        Me.LstDispDistrito.TabIndex = 60
        '
        'repv_frmcliente2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(747, 560)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnQuitaTodo_Distrito)
        Me.Controls.Add(Me.BtnQuitaUno_Distrito)
        Me.Controls.Add(Me.BtnPasaTodo_Distrito)
        Me.Controls.Add(Me.BtnPasaUno_Distrito)
        Me.Controls.Add(Me.LstSelecDistrito)
        Me.Controls.Add(Me.LstDispDistrito)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbomoneda)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnQuitaTodo_Ruta)
        Me.Controls.Add(Me.BtnQuitaUno_Ruta)
        Me.Controls.Add(Me.BtnPasaTodo_Ruta)
        Me.Controls.Add(Me.BtnPasaUno_Ruta)
        Me.Controls.Add(Me.LstSelecRuta)
        Me.Controls.Add(Me.LstDispRuta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CRT)
        Me.Controls.Add(Me.lstcod2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstcod1)
        Me.Controls.Add(Me.cboptovta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "repv_frmcliente2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas por Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable


    Private Tb_DistritoDisponible As New DataTable
    Private Tb_DistritoModSelec As New DataTable

    Private Sub repv_frmcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call datacombo()
        Call cargadatos1()
        cboptovta.SelectedValue = Environment.MachineName.Trim
        cbomoneda.SelectedValue = CDMONBASE
        dtpfecha1.Value = Now.Date
        dtpfecha2.Value = Now.Date


        Tb_RutaDisponible = TmpListarDatos("Nsp_Sele_Ruta_filtro '','','" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("Nsp_Sele_Ruta_filtro '','','" & 454 & "'")


        Tb_DistritoDisponible = TmpListarDatos("SP_LISTAR_LINEA  '" & codempresa & "'")
        Tb_DistritoModSelec = TmpListarDatos("SP_LISTAR_LINEA  '" & 454 & "'")


        CargarModulo()




    End Sub



    Private Sub CargarModulo()


        LstDispRuta.DataSource = Tb_RutaDisponible
        LstDispRuta.ValueMember = "Codigo"
        LstDispRuta.DisplayMember = "Descripcion"

        LstSelecRuta.DataSource = Tb_RutaModSelec
        LstSelecRuta.ValueMember = "Codigo"
        LstSelecRuta.DisplayMember = "Descripcion"


        LstDispDistrito.DataSource = Tb_DistritoDisponible
        LstDispDistrito.ValueMember = "Codigo"
        LstDispDistrito.DisplayMember = "Descripcion"

        LstSelecDistrito.DataSource = Tb_DistritoModSelec
        LstSelecDistrito.ValueMember = "Codigo"
        LstSelecDistrito.DisplayMember = "Descripcion"


    End Sub

    Private Sub BtnPasaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno_Ruta.Click
        PasarUno_Ruta()


    End Sub

    Private Sub BtnPasaTodo_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo_Ruta.Click
        PasarTodo_Ruta()
    End Sub

    Private Sub BtnQuitaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno_Ruta.Click
        QuitarUno_Ruta()
    End Sub

    Private Sub BtnQuitaTodo_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo_Ruta.Click
        QuitarTodo_Ruta()
    End Sub

  
    Private Sub BtnPasaTodo_Distrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo_Distrito.Click
        PasarTodo_Distrito()
    End Sub

    Private Sub BtnQuitaUno_Distrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno_Distrito.Click
        QuitarUno_Distrito()
    End Sub

    Private Sub BtnQuitaTodo_Distrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo_Distrito.Click
        QuitarTodo_Distrito()
    End Sub



    Private Sub PasarUno_Distrito()
        If Tb_DistritoDisponible.Rows.Count > 0 Then

            Dim FILA As DataRow = Tb_DistritoModSelec.NewRow
            FILA("Codigo") = LstDispDistrito.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstDispDistrito.Text.Trim
            Tb_DistritoModSelec.Rows.Add(FILA)

            For F As Integer = 0 To Tb_DistritoDisponible.Rows.Count - 1
                If LstDispDistrito.SelectedValue.ToString.Trim = Tb_DistritoDisponible.Rows(F)("Codigo").ToString.Trim Then
                    Tb_DistritoDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub PasarTodo_Distrito()

        For F As Integer = 0 To Tb_DistritoDisponible.Rows.Count - 1
            Dim FILA As DataRow = Tb_DistritoModSelec.NewRow
            FILA("Codigo") = Tb_DistritoDisponible.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_DistritoDisponible.Rows(F)("Descripcion").ToString.Trim
            Tb_DistritoModSelec.Rows.Add(FILA)
        Next
        Tb_DistritoDisponible.Rows.Clear()
    End Sub


    Private Sub QuitarUno_Distrito()
        If Tb_DistritoModSelec.Rows.Count > 0 Then
            Dim FILA As DataRow = Tb_DistritoDisponible.NewRow
            FILA("Codigo") = LstSelecDistrito.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstSelecDistrito.Text.Trim
            Tb_DistritoDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
                If LstSelecDistrito.SelectedValue.ToString.Trim = Tb_DistritoModSelec.Rows(F)("Codigo").ToString.Trim Then
                    Tb_DistritoModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub QuitarTodo_Distrito()

        For F As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Dim FILA As DataRow = Tb_DistritoDisponible.NewRow
            FILA("Codigo") = Tb_DistritoModSelec.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_DistritoModSelec.Rows(F)("Descripcion").ToString.Trim
            Tb_DistritoDisponible.Rows.Add(FILA)
        Next
        Tb_DistritoModSelec.Rows.Clear()

    End Sub


    Private Sub PasarUno_Ruta()
        If Tb_RutaDisponible.Rows.Count > 0 Then

            Dim FILA As DataRow = Tb_RutaModSelec.NewRow
            FILA("Codigo") = LstDispRuta.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstDispRuta.Text.Trim
            Tb_RutaModSelec.Rows.Add(FILA)

            For F As Integer = 0 To Tb_RutaDisponible.Rows.Count - 1
                If LstDispRuta.SelectedValue.ToString.Trim = Tb_RutaDisponible.Rows(F)("Codigo").ToString.Trim Then
                    Tb_RutaDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub PasarTodo_Ruta()

        For F As Integer = 0 To Tb_RutaDisponible.Rows.Count - 1
            Dim FILA As DataRow = Tb_RutaModSelec.NewRow
            FILA("Codigo") = Tb_RutaDisponible.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_RutaDisponible.Rows(F)("Descripcion").ToString.Trim
            Tb_RutaModSelec.Rows.Add(FILA)
        Next
        Tb_RutaDisponible.Rows.Clear()
    End Sub


    Private Sub QuitarUno_Ruta()
        If Tb_RutaModSelec.Rows.Count > 0 Then
            Dim FILA As DataRow = Tb_RutaDisponible.NewRow
            FILA("Codigo") = LstSelecRuta.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstSelecRuta.Text.Trim
            Tb_RutaDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
                If LstSelecRuta.SelectedValue.ToString.Trim = Tb_RutaModSelec.Rows(F)("Codigo").ToString.Trim Then
                    Tb_RutaModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub QuitarTodo_Ruta()

        For F As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Dim FILA As DataRow = Tb_RutaDisponible.NewRow
            FILA("Codigo") = Tb_RutaModSelec.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_RutaModSelec.Rows(F)("Descripcion").ToString.Trim
            Tb_RutaDisponible.Rows.Add(FILA)
        Next
        Tb_RutaModSelec.Rows.Clear()

    End Sub





    Sub datacombo()
        Try
            Dim dt As New DataTable
            dt = TmpListarDatos("SP_SELE_TIENDAPTOVTA '" & codempresa & "'")
            Dim dr As DataRow
            dr = dt.NewRow
            dr.Item(0) = ""
            dr.Item(1) = ">> TODOS <<"
            dt.Rows.InsertAt(dr, 0)

            'Me.cboptovta.DataSource = ""
            CAyuda.CargarDataCombo(cboptovta, "SP_SELE_TIENDAPTOVTA '" & codempresa & "'", "CODIGO", "NROPTOVTA")
            CAyuda.CargarDataCombo(cbomoneda, "nsp_sele_monefac '" & codempresa & "'", "Codigo", "Moneda")
        Catch ex As Exception
        End Try
    End Sub
    Sub cargadatos1()
        lstclie1.Items.Clear()
        lstcod1.Items.Clear()
        lstclie2.Items.Clear()
        lstcod2.Items.Clear()
        'Try
        '    Dim ds As New DataSet, i As Int32
        '    ds = TmpListarDataset("sp_select_clientesreport '" & codempresa & "'")
        '    For i = 0 To ds.Tables(0).Rows.Count - 1
        '        lstclie1.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
        '    Next

        '    ds.Dispose()
        '    ds = TmpListarDataset("sp_select_clientesreport '" & codempresa & "'")
        '    For i = 0 To ds.Tables(0).Rows.Count - 1
        '        lstcod1.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
        '    Next
        '    lstclie2.Items.Clear()
        '    lstcod2.Items.Clear()
        'Catch ex As Exception
        'End Try
    End Sub
    Sub cargadatos2()
        lstclie1.Items.Clear()
        lstcod1.Items.Clear()
        lstclie2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("sp_select_clientesreport '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstclie2.Items.Add(Trim(ds.Tables(0).Rows(i)(1)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("sp_select_clientesreport '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod2.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, lstclie1.DoubleClick
        Try
            If lstclie1.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Cliente", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lstclie2.Items.Add(lstclie1.Items(lstclie1.SelectedIndex))
            lstcod2.Items.Add(lstcod1.Items(lstclie1.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstclie1.SelectedIndex
            lstclie1.Items.RemoveAt(removeitem)
            lstcod1.Items.RemoveAt(removeitem)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, lstclie2.DoubleClick
        Try

            If lstclie1.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Cliente", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lstclie1.Items.Add(lstclie2.Items(lstclie2.SelectedIndex))
            lstcod1.Items.Add(lstcod2.Items(lstclie2.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstclie2.SelectedIndex
            lstclie2.Items.RemoveAt(removeitem)
            lstcod2.Items.RemoveAt(removeitem)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cargadatos2()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cargadatos1()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click






        'If lstclie2.Items.Count <= 0 Then
        '    MessageBox.Show("Selecione un Punto de Venta para realizar el reporte", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        Label7.Visible = True
        Label7.Refresh()

        Label7.Text = "Procesando Reportes.."
        Label7.Refresh()
        Label7.Text = "Procesando Reportes....."
        Label7.Refresh()
        Label7.Text = "Procesando Reportes........"
        Label7.Refresh()
        Label7.Text = "Procesando Reportes..........."
        Label7.Refresh()

        Dim FECHA1, FECHA2 As String
        FECHA1 = dtpfecha1.Value.Date
        FECHA2 = dtpfecha2.Value.Date
        Call GENERAREPORTECLIENTES(FECHA1, FECHA2)

    End Sub
    Sub GENERAREPORTECLIENTES(ByVal FECHA1 As String, ByVal FECHA2 As String)




        If CDate(FECHA1) > CDate(FECHA2) Then
            MessageBox.Show("Rango de Fechas Incorrecta", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim SQL1 As String


        SQL1 = "DELETE  FROM TMP_RUTA "
        If TmpInsertDatos(SQL1) = True Then
        End If

        For x As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            SQL1 = "NSP_INSERT_TMP_RUTA '" & codempresa & "','" & Tb_RutaModSelec.Rows(x)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(SQL1) = True Then
            End If
        Next


      
        SQL1 = "DELETE  FROM TMP_DISTRITO  "
        If TmpInsertDatos(SQL1) = True Then
        End If

        For x As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            SQL1 = "NSP_INSERT_TMP_DISTRITO2 '" & codempresa & "','" & Tb_DistritoModSelec.Rows(x)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(SQL1) = True Then
            End If
        Next

        Dim fecini As String

        Dim mesact, anio, TABLAD, TABLAC As String
        Dim i As Integer
        Dim meses As Integer
        Dim ds As New DataSet
        Dim SQL, F1, F2, FM As String
        F1 = Format(CDate(FECHA1), "dd/MM/yyyy")
        F2 = Format(CDate(FECHA2), "dd/MM/yyyy")
        TmpInsertDatos("SP_ELIMINAYCREA_TMP_REPORTCLIENTE")
        fecini = FECHA1
        meses = Val(DateDiff(DateInterval.Month, CDate(fecini), CDate(FECHA2)))
        Dim CDMONEDA, NROPTOVTA, DESPTOVTA As String
        NROPTOVTA = ""
        DESPTOVTA = ""

        CDMONEDA = cbomoneda.SelectedValue.ToString

        Dim FILTRO As String = ""
        If Me.lstclie1.Items.Count > 0 Then
            For i = 0 To lstcod2.Items.Count - 1
                If i = lstcod2.Items.Count - 1 Then
                    FILTRO = FILTRO + "'" & lstcod2.Items(i) & "'"
                Else
                    FILTRO = FILTRO + "'" & lstcod2.Items(i) & "',"
                End If

                Label7.Text = "Procesando Reportes.."
                Label7.Refresh()
                Label7.Text = "Procesando Reportes....."
                Label7.Refresh()
                Label7.Text = "Procesando Reportes........"
                Label7.Refresh()
                Label7.Text = "Procesando Reportes..........."
                Label7.Refresh()
            Next
        End If




        '            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
        '" SELECT '01/' + CAST(MONTH(v.FECDOCUM) AS VARCHAR(20)) + '/' + CAST(year(v.FECDOCUM) AS VARCHAR(20)) " & _
        '"  , C.CODCLIENTE,'Cliente'=case WHEN C.razonsocial is null or ltrim(rtrim(C.razonsocial))=''  " & _
        '"		Then ltrim(rtrim(C.paterno))+' '+ltrim(rtrim(materno))+','+ltrim(rtrim(C.nombres)) " & _
        '"		when ltrim(rtrim(C.razonsocial))<>'' then ltrim(rtrim(C.razonsocial)) end " & _
        '"		,sum(TOTBAS),year(v.FECDOCUM),'MES'=case when " & _
        '"			month(v.FECDOCUM)=1 then  'ENERO' WHEN " & _
        '"			month(v.FECDOCUM)=2 then  'FEBRERO' WHEN " & _
        '"			month(v.FECDOCUM)=3 then  'MARZO' WHEN " & _
        '"			month(v.FECDOCUM)=4 then  'ABRIL' WHEN " & _
        '"			month(v.FECDOCUM)=5 then  'MAYO' WHEN " & _
        '"			month(v.FECDOCUM)=6 then  'JUNIO' WHEN " & _
        '"			month(v.FECDOCUM)=7 then  'JULIO' WHEN " & _
        '"			month(v.FECDOCUM)=8 then  'AGOSTO' WHEN " & _
        '"			month(v.FECDOCUM)=9 then  'SETIEMBRE' WHEN " & _
        '"			month(v.FECDOCUM)=10 then 'OCTUBRE' WHEN " & _
        '"			month(v.FECDOCUM)=11 then 'NOVIEMBRE' WHEN " & _
        '"			month(v.FECDOCUM)=12 then 'DICIEMBRE' END " & _
        '"	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from ventacab v,cliente c where v.codcliente=c.codcliente and " & _
        '"	 v.FECDOCUM between '" & F1 & "' and '" & F2 & "'" & _
        '"	GROUP BY C.CODCLIENTE,c.paterno,c.nombres, " & _
        '"	c.nombres,c.razonsocial,v.FECDOCUM,c.materno "


        '            TmpInsertDatos(SQL)




        CAyuda.Ejecutar("SP_VENTA_CLIENTE_XRUTA", codempresa, F1, F2)



        Label7.Text = "Procesando Reportes.."
        Label7.Refresh()
        Label7.Text = "Procesando Reportes....."
        Label7.Refresh()
        Label7.Text = "Procesando Reportes........"
        Label7.Refresh()
        Label7.Text = "Procesando Reportes..........."
        Label7.Refresh()



        'If Trim(CDMONEDA) = "D" Then

        '    If Me.lstclie1.Items.Count = 0 Then
        '        SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
        '            " SELECT '01/' + CAST(MONTH(v.FECDOCUM) AS VARCHAR(20))+ '/' + CAST(year(v.FECDOCUM) AS VARCHAR(20)) " & _
        '            "  , C.CODCLIENTE,'Cliente'=case WHEN C.razonsocial is null or ltrim(rtrim(C.razonsocial))=''  " & _
        '            "		Then ltrim(rtrim(C.paterno))+' '+ltrim(rtrim(materno))+','+ltrim(rtrim(C.nombres)) " & _
        '            "		when ltrim(rtrim(C.razonsocial))<>'' then ltrim(rtrim(C.razonsocial)) end " & _
        '            "		,sum(TOTEXT),year(v.FECDOCUM),'MES'=case when " & _
        '            "			month(v.FECDOCUM)=1 then  'ENERO' WHEN " & _
        '            "			month(v.FECDOCUM)=2 then  'FEBRERO' WHEN " & _
        '            "			month(v.FECDOCUM)=3 then  'MARZO' WHEN " & _
        '            "			month(v.FECDOCUM)=4 then  'ABRIL' WHEN " & _
        '            "			month(v.FECDOCUM)=5 then  'MAYO' WHEN " & _
        '            "			month(v.FECDOCUM)=6 then  'JUNIO' WHEN " & _
        '            "			month(v.FECDOCUM)=7 then  'JULIO' WHEN " & _
        '            "			month(v.FECDOCUM)=8 then  'AGOSTO' WHEN " & _
        '            "			month(v.FECDOCUM)=9 then  'SETIEMBRE' WHEN " & _
        '            "			month(v.FECDOCUM)=10 then 'OCTUBRE' WHEN " & _
        '            "			month(v.FECDOCUM)=11 then 'NOVIEMBRE' WHEN " & _
        '            "			month(v.FECDOCUM)=12 then 'DICIEMBRE' END " & _
        '            "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from ventacab v,cliente c where v.codcliente=c.codcliente and " & _
        '            "	 v.FECDOCUM between '" & F1 & "' and '" & F2 & "'" & _
        '            "	GROUP BY C.CODCLIENTE,c.paterno,c.nombres, " & _
        '            "	c.nombres,c.razonsocial,v.FECDOCUM,c.materno "

        '    Else
        '        SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
        '            " SELECT '01/' + CAST(MONTH(v.FECDOCUM) AS VARCHAR(20))+ '/' + CAST(year(v.FECDOCUM) AS VARCHAR(20)) " & _
        '            "  , C.CODCLIENTE,'Cliente'=case WHEN C.razonsocial is null or ltrim(rtrim(C.razonsocial))=''  " & _
        '            "		Then ltrim(rtrim(C.paterno))+' '+ltrim(rtrim(materno))+','+ltrim(rtrim(C.nombres)) " & _
        '            "		when ltrim(rtrim(C.razonsocial))<>'' then ltrim(rtrim(C.razonsocial)) end " & _
        '            "		,sum(TOTEXT),year(v.FECDOCUM),'MES'=case when " & _
        '            "			month(v.FECDOCUM)=1 then  'ENERO' WHEN " & _
        '            "			month(v.FECDOCUM)=2 then  'FEBRERO' WHEN " & _
        '            "			month(v.FECDOCUM)=3 then  'MARZO' WHEN " & _
        '            "			month(v.FECDOCUM)=4 then  'ABRIL' WHEN " & _
        '            "			month(v.FECDOCUM)=5 then  'MAYO' WHEN " & _
        '            "			month(v.FECDOCUM)=6 then  'JUNIO' WHEN " & _
        '            "			month(v.FECDOCUM)=7 then  'JULIO' WHEN " & _
        '            "			month(v.FECDOCUM)=8 then  'AGOSTO' WHEN " & _
        '            "			month(v.FECDOCUM)=9 then  'SETIEMBRE' WHEN " & _
        '            "			month(v.FECDOCUM)=10 then 'OCTUBRE' WHEN " & _
        '            "			month(v.FECDOCUM)=11 then 'NOVIEMBRE' WHEN " & _
        '            "			month(v.FECDOCUM)=12 then 'DICIEMBRE' END " & _
        '            "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from ventacab v,cliente c where v.codcliente=c.codcliente and " & _
        '            "	 v.FECDOCUM between '" & F1 & "' and '" & F2 & "' AND V.CODDEP IN (" & FILTRO & ") " & _
        '            "	GROUP BY C.CODCLIENTE,c.paterno,c.nombres, " & _
        '            "	c.nombres,c.razonsocial,v.FECDOCUM,c.materno "
        '    End If

        '    TmpInsertDatos(SQL)
        'End If


        For i = 0 To meses
            mesact = Format(DateAdd("m", i, fecini), "MM")
            anio = Format(DateAdd("m", i, fecini), "yyyy")
            'Nombre de las tablas a Consultar
            TABLAD = "VENTD" & anio & mesact
            TABLAC = "VENTC" & anio & mesact
            FM = "01/" & mesact & "/" & anio
            Try
                'PASO ACUMULADOS DE INFORMACION PASADA (IMPORTEMOS DATA)

                ds = TmpListarDataset("VERIFICA_HISTORICOVENT '" & TABLAC & "','" & codempresa & "'")
                If ds.Tables(0).Rows.Count > 0 Then


                    'PASO ACUMULADOS DE HISTORICOS

                    'SQL = "INSERT TMP_COMPARATIVOVENTAS(CODPRODUCTO,PRODUCTO,MES,AÑO,VENTAS,FECHAMES,PTOVENTA,DESPTOVTA) " & _
                    '        " SELECT  P.CODPRODUCTO,P.DESPRODUCTO,'" & MES(mesact) & "','" & anio & "',SUM(cantidad),'" & FM & "',NROPTOVTA,DESPTOVTA FROM " & TABLAD & " VD ,ARTICULO A, PRODUCTO P" & "  WHERE VD.CODARTI=A.CODARTI AND A.CODPRODUCTO=P.CODPRODUCTO AND " & _
                    '        " VD.NROPTOVTA in (" & FILTRO & ") and datepart(mm,FECDOCUM)=" & mesact & " and datepart(yyyy,FECDOCUM)=" & anio & " GROUP BY NROPTOVTA,DESPTOVTA,P.CODPRODUCTO,P.DESPRODUCTO "

                    If Trim(CDMONEDA) = "S" Then

                        If Me.lstclie1.Items.Count = 0 Then

                            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
     " SELECT '01/' + CAST(MONTH(v.FECDOCUM) AS VARCHAR(20))+ '/'+ CAST(year(v.FECDOCUM) AS VARCHAR(20)) " & _
     "  , C.CODCLIENTE,'Cliente'=case WHEN C.razonsocial is null or ltrim(rtrim(C.razonsocial))=''  " & _
     "		Then ltrim(rtrim(C.paterno))+' '+ltrim(rtrim(materno))+','+ltrim(rtrim(C.nombres)) " & _
     "		when ltrim(rtrim(C.razonsocial))<>'' then ltrim(rtrim(C.razonsocial)) end " & _
     "		,sum(TOTBAS),year(v.FECDOCUM),'MES'=case when " & _
     "			month(v.FECDOCUM)=1 then  'ENERO' WHEN " & _
     "			month(v.FECDOCUM)=2 then  'FEBRERO' WHEN " & _
     "			month(v.FECDOCUM)=3 then  'MARZO' WHEN " & _
     "			month(v.FECDOCUM)=4 then  'ABRIL' WHEN " & _
     "			month(v.FECDOCUM)=5 then  'MAYO' WHEN " & _
     "			month(v.FECDOCUM)=6 then  'JUNIO' WHEN " & _
     "			month(v.FECDOCUM)=7 then  'JULIO' WHEN " & _
     "			month(v.FECDOCUM)=8 then  'AGOSTO' WHEN " & _
     "			month(v.FECDOCUM)=9 then  'SETIEMBRE' WHEN " & _
     "			month(v.FECDOCUM)=10 then 'OCTUBRE' WHEN " & _
     "			month(v.FECDOCUM)=11 then 'NOVIEMBRE' WHEN " & _
     "			month(v.FECDOCUM)=12 then 'DICIEMBRE' END " & _
     "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from " & TABLAC & " v,cliente c where v.codcliente=c.codcliente and " & _
     "	 v.FECDOCUM between '" & F1 & "' and '" & F2 & "'" & _
     "	GROUP BY C.CODCLIENTE,c.paterno,c.nombres, " & _
     "	c.nombres,c.razonsocial,v.FECDOCUM,c.materno "
                        Else
                            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                                 " SELECT '01/' + CAST(MONTH(v.FECDOCUM) AS VARCHAR(20))+ '/'+ CAST(year(v.FECDOCUM) AS VARCHAR(20)) " & _
                                 "  , C.CODCLIENTE,'Cliente'=case WHEN C.razonsocial is null or ltrim(rtrim(C.razonsocial))=''  " & _
                                 "		Then ltrim(rtrim(C.paterno))+' '+ltrim(rtrim(materno))+','+ltrim(rtrim(C.nombres)) " & _
                                 "		when ltrim(rtrim(C.razonsocial))<>'' then ltrim(rtrim(C.razonsocial)) end " & _
                                 "		,sum(TOTBAS),year(v.FECDOCUM),'MES'=case when " & _
                                 "			month(v.FECDOCUM)=1 then  'ENERO' WHEN " & _
                                 "			month(v.FECDOCUM)=2 then  'FEBRERO' WHEN " & _
                                 "			month(v.FECDOCUM)=3 then  'MARZO' WHEN " & _
                                 "			month(v.FECDOCUM)=4 then  'ABRIL' WHEN " & _
                                 "			month(v.FECDOCUM)=5 then  'MAYO' WHEN " & _
                                 "			month(v.FECDOCUM)=6 then  'JUNIO' WHEN " & _
                                 "			month(v.FECDOCUM)=7 then  'JULIO' WHEN " & _
                                 "			month(v.FECDOCUM)=8 then  'AGOSTO' WHEN " & _
                                 "			month(v.FECDOCUM)=9 then  'SETIEMBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=10 then 'OCTUBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=11 then 'NOVIEMBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=12 then 'DICIEMBRE' END " & _
                                 "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from " & TABLAC & " v,cliente c where v.codcliente=c.codcliente and " & _
                                 "	 v.FECDOCUM between '" & F1 & "' and '" & F2 & "' AND V.CODDEP IN (" & FILTRO & ") " & _
                                 "	GROUP BY C.CODCLIENTE,c.paterno,c.nombres, " & _
                                 "	c.nombres,c.razonsocial,v.FECDOCUM,c.materno "
                        End If

                        Label7.Text = "Procesando Reportes.."
                        Label7.Refresh()
                        Label7.Text = "Procesando Reportes....."
                        Label7.Refresh()
                        Label7.Text = "Procesando Reportes........"
                        Label7.Refresh()
                        Label7.Text = "Comprobando Informacion..........."
                        Label7.Refresh()
                        TmpInsertDatos(SQL)
                    End If


                    If Trim(CDMONEDA) = "D" Then

                        If Me.lstclie1.Items.Count = 0 Then
                            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                                 " SELECT '01/' + CAST(MONTH(v.FECDOCUM) AS VARCHAR(20))+ '/'+ CAST(year(v.FECDOCUM) AS VARCHAR(20)) " & _
                                 "  , C.CODCLIENTE,'Cliente'=case WHEN C.razonsocial is null or ltrim(rtrim(C.razonsocial))=''  " & _
                                 "		Then ltrim(rtrim(C.paterno))+' '+ltrim(rtrim(materno))+','+ltrim(rtrim(C.nombres)) " & _
                                 "		when ltrim(rtrim(C.razonsocial))<>'' then ltrim(rtrim(C.razonsocial)) end " & _
                                 "		,sum(TOTEXT),year(v.FECDOCUM),'MES'=case when " & _
                                 "			month(v.FECDOCUM)=1 then  'ENERO' WHEN " & _
                                 "			month(v.FECDOCUM)=2 then  'FEBRERO' WHEN " & _
                                 "			month(v.FECDOCUM)=3 then  'MARZO' WHEN " & _
                                 "			month(v.FECDOCUM)=4 then  'ABRIL' WHEN " & _
                                 "			month(v.FECDOCUM)=5 then  'MAYO' WHEN " & _
                                 "			month(v.FECDOCUM)=6 then  'JUNIO' WHEN " & _
                                 "			month(v.FECDOCUM)=7 then  'JULIO' WHEN " & _
                                 "			month(v.FECDOCUM)=8 then  'AGOSTO' WHEN " & _
                                 "			month(v.FECDOCUM)=9 then  'SETIEMBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=10 then 'OCTUBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=11 then 'NOVIEMBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=12 then 'DICIEMBRE' END " & _
                                 "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from " & TABLAC & " v,cliente c where v.codcliente=c.codcliente and " & _
                                 "	 v.FECDOCUM between '" & F1 & "' and '" & F2 & "'" & _
                                 "	GROUP BY C.CODCLIENTE,c.paterno,c.nombres, " & _
                                 "	c.nombres,c.razonsocial,v.FECDOCUM,c.materno "

                        Else
                            SQL = " INSERT TMP_REPORTCLIENTE(MESDIAAÑO,CODCLIENTE, DESCLIENTE,TOTAL, AÑO, MES,MONEDA,NROPTOVTA,DESPTOVTA) " & _
                                 " SELECT '01/' + CAST(MONTH(v.FECDOCUM) AS VARCHAR(20))+ '/'+ CAST(year(v.FECDOCUM) AS VARCHAR(20)) " & _
                                 "  , C.CODCLIENTE,'Cliente'=case WHEN C.razonsocial is null or ltrim(rtrim(C.razonsocial))=''  " & _
                                 "		Then ltrim(rtrim(C.paterno))+' '+ltrim(rtrim(materno))+','+ltrim(rtrim(C.nombres)) " & _
                                 "		when ltrim(rtrim(C.razonsocial))<>'' then ltrim(rtrim(C.razonsocial)) end " & _
                                 "		,sum(TOTEXT),year(v.FECDOCUM),'MES'=case when " & _
                                 "			month(v.FECDOCUM)=1 then  'ENERO' WHEN " & _
                                 "			month(v.FECDOCUM)=2 then  'FEBRERO' WHEN " & _
                                 "			month(v.FECDOCUM)=3 then  'MARZO' WHEN " & _
                                 "			month(v.FECDOCUM)=4 then  'ABRIL' WHEN " & _
                                 "			month(v.FECDOCUM)=5 then  'MAYO' WHEN " & _
                                 "			month(v.FECDOCUM)=6 then  'JUNIO' WHEN " & _
                                 "			month(v.FECDOCUM)=7 then  'JULIO' WHEN " & _
                                 "			month(v.FECDOCUM)=8 then  'AGOSTO' WHEN " & _
                                 "			month(v.FECDOCUM)=9 then  'SETIEMBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=10 then 'OCTUBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=11 then 'NOVIEMBRE' WHEN " & _
                                 "			month(v.FECDOCUM)=12 then 'DICIEMBRE' END " & _
                                 "	,'" & CDMONEDA & "','" & NROPTOVTA & "','" & DESPTOVTA & "' from " & TABLAC & " v,cliente c where v.codcliente=c.codcliente and " & _
                                 "	 v.FECDOCUM between '" & F1 & "' and '" & F2 & "' AND V.CODDEP IN (" & FILTRO & ") " & _
                                 "	GROUP BY C.CODCLIENTE,c.paterno,c.nombres, " & _
                                 "	c.nombres,c.razonsocial,v.FECDOCUM,c.materno "
                        End If

                        Label7.Text = "Procesando Reportes.."
                        Label7.Refresh()
                        Label7.Text = "Procesando Reportes....."
                        Label7.Refresh()
                        Label7.Text = "Procesando Reportes........"
                        Label7.Refresh()
                        Label7.Text = "Comprobando Informacion..........."
                        Label7.Refresh()

                        TmpInsertDatos(SQL)
                    End If

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '            Debug.WriteLine(TABLAC) : Debug.WriteLine(TABLAD)
        Next
        Call imprimereport()
        Label7.Visible = False
    End Sub
    Sub imprimereport()
        Try
            With CRT
                .ReportFileName = RutaRptInv + CType("Rpt_ventasxcliente.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(1, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(4, "Usuario='" & DesUsuario & "'")
                .set_Formulas(3, "Fini='" & dtpfecha1.Value.ToShortDateString & "'")
                .set_Formulas(2, "FHasta='" & dtpfecha2.Value.ToShortDateString & "'")
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .WindowShowExportBtn = True
                .WindowShowPrintBtn = True
                .WindowShowPrintSetupBtn = True
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function MES(ByVal NUMMES As String) As String
        MES = ""
        Select Case NUMMES
            Case Is = "01"
                MES = "ENERO"
            Case Is = "02"
                MES = "FEBRERO"
            Case Is = "03"
                MES = "MARZO"
            Case Is = "04"
                MES = "ABRIL"
            Case Is = "05"
                MES = "MAYO"
            Case Is = "06"
                MES = "JUNIO"
            Case Is = "07"
                MES = "JULIO"
            Case Is = "08"
                MES = "AGOSTO"
            Case Is = "09"
                MES = "SEPTIEMBRE"
            Case Is = "10"
                MES = "OCTUBRE"
            Case Is = "11"
                MES = "NOVIEMBRE"
            Case Is = "12"
                MES = "DICIEMBRE"
        End Select
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label7.Width = Label7.Width + 1
        Label7.Refresh()
        If Label7.Width = 394 Then
            Label7.Width = 0
        End If
        Label7.Refresh()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtfiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfiltro.TextChanged
        lstclie1.Items.Clear()
        lstcod1.Items.Clear()

        Try
            Dim dv As New DataView
            ds = TmpListarDataset("sp_select_clientesreport '" & codempresa & "'")
            dv = ds.Tables(0).DefaultView

            dv.RowFilter = "Cliente like '" & txtfiltro.Text.Trim & "*'"
            For Each dr As DataRow In dv.ToTable().Rows
                lstclie1.Items.Add(Trim(dr.Item(1).ToString))
                lstcod1.Items.Add(Trim(dr.Item(0).ToString))
            Next

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnPasaUno_Distrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno_Distrito.Click
        PasarUno_Distrito()
    End Sub
End Class
