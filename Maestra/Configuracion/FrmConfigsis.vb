Public Class FrmConfigSis
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmbase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ImageLis2 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents txtmext As System.Windows.Forms.TextBox
    Friend WithEvents dtproceso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdecant As System.Windows.Forms.TextBox
    Friend WithEvents txtdecost As System.Windows.Forms.TextBox
    Friend WithEvents txtdecpre As System.Windows.Forms.TextBox
    Friend WithEvents txtdectot As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents cboptovta As System.Windows.Forms.ComboBox
    Friend WithEvents chbuni As System.Windows.Forms.CheckBox
    Friend WithEvents chbsal As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cboempresa As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkActivaDup As System.Windows.Forms.CheckBox
    Friend WithEvents chkPgocaja As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioNotaPedido As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtPorcDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents lblAlm As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPrecioNPTienda As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtMargenMinDesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdDescDoc As System.Windows.Forms.RadioButton
    Friend WithEvents rdOrdDesc As System.Windows.Forms.RadioButton
    Friend WithEvents txtDiasCStck As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTipoOperacion As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoDomicilioF As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecioBoleta As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtRutaArchivo As System.Windows.Forms.TextBox
    Friend WithEvents chkEmelec As System.Windows.Forms.CheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtResolucion As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtConsulta As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCodHash As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtUbigueo As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt_nroImp As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txtMargenMinDescPlan As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents txtNumPedido As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents txtNoSerie As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents txtNroClieDep As TextBox
    Friend WithEvents txtCodLocal As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents txtNroCliePri As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txtDiasAdelantado As TextBox
    Friend WithEvents chkFacLinea As CheckBox
    Friend WithEvents chkFacSubEmp As CheckBox
    Friend WithEvents chkFacPtovta As CheckBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txtTiempoEnviar As TextBox
    Friend WithEvents txtUltimaCargaClient As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtUltimaCargaProd As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtUltimaCargaTipopre As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents chkFacSuperVisorHU As CheckBox
    Friend WithEvents chkFacSubEmpHU As CheckBox
    Friend WithEvents txtlimpcred As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigSis))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmbase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmext = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtproceso = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdecant = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdecost = New System.Windows.Forms.TextBox()
        Me.txtdecpre = New System.Windows.Forms.TextBox()
        Me.txtdectot = New System.Windows.Forms.TextBox()
        Me.txtigv = New System.Windows.Forms.TextBox()
        Me.cboptovta = New System.Windows.Forms.ComboBox()
        Me.chbuni = New System.Windows.Forms.CheckBox()
        Me.chbsal = New System.Windows.Forms.CheckBox()
        Me.ImageLis2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grid1 = New System.Windows.Forms.DataGrid()
        Me.cboempresa = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtUltimaCargaTipopre = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txtUltimaCargaProd = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtUltimaCargaClient = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtTiempoEnviar = New System.Windows.Forms.TextBox()
        Me.chkFacPtovta = New System.Windows.Forms.CheckBox()
        Me.chkFacSubEmp = New System.Windows.Forms.CheckBox()
        Me.chkFacLinea = New System.Windows.Forms.CheckBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtNroCliePri = New System.Windows.Forms.TextBox()
        Me.txtCodLocal = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtNroClieDep = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtNoSerie = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtNumPedido = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_nroImp = New System.Windows.Forms.TextBox()
        Me.txtMargenMinDescPlan = New System.Windows.Forms.TextBox()
        Me.txtUbigueo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtCodHash = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtConsulta = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtResolucion = New System.Windows.Forms.TextBox()
        Me.chkEmelec = New System.Windows.Forms.CheckBox()
        Me.txtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCodigoDomicilioF = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTipoOperacion = New System.Windows.Forms.TextBox()
        Me.txtDiasCStck = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.rdDescDoc = New System.Windows.Forms.RadioButton()
        Me.rdOrdDesc = New System.Windows.Forms.RadioButton()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtMargenMinDesc = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCotizacion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPrecioNPTienda = New System.Windows.Forms.TextBox()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.lblAlm = New System.Windows.Forms.Label()
        Me.TxtPorcDesc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPrecioNotaPedido = New System.Windows.Forms.TextBox()
        Me.txtPrecioFactura = New System.Windows.Forms.TextBox()
        Me.txtPrecioBoleta = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chkActivaDup = New System.Windows.Forms.CheckBox()
        Me.chkPgocaja = New System.Windows.Forms.CheckBox()
        Me.txtlimpcred = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDiasAdelantado = New System.Windows.Forms.TextBox()
        Me.chkFacSubEmpHU = New System.Windows.Forms.CheckBox()
        Me.chkFacSuperVisorHU = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cod Moneda Base :"
        '
        'txtmbase
        '
        Me.txtmbase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmbase.Location = New System.Drawing.Point(152, 18)
        Me.txtmbase.MaxLength = 1
        Me.txtmbase.Name = "txtmbase"
        Me.txtmbase.Size = New System.Drawing.Size(40, 21)
        Me.txtmbase.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cod Moneda Extranjera :"
        '
        'txtmext
        '
        Me.txtmext.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmext.Location = New System.Drawing.Point(152, 42)
        Me.txtmext.MaxLength = 2
        Me.txtmext.Name = "txtmext"
        Me.txtmext.Size = New System.Drawing.Size(40, 21)
        Me.txtmext.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de Proceso : "
        '
        'dtproceso
        '
        Me.dtproceso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtproceso.Location = New System.Drawing.Point(152, 66)
        Me.dtproceso.Name = "dtproceso"
        Me.dtproceso.Size = New System.Drawing.Size(128, 21)
        Me.dtproceso.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Decimales Cantidad :"
        '
        'txtdecant
        '
        Me.txtdecant.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdecant.Location = New System.Drawing.Point(152, 128)
        Me.txtdecant.MaxLength = 2
        Me.txtdecant.Name = "txtdecant"
        Me.txtdecant.Size = New System.Drawing.Size(40, 21)
        Me.txtdecant.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Decimales Costo :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Decimales Precio :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Decimales Totales :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(213, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "IGV :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Cierre Fin de Dia :"
        '
        'txtdecost
        '
        Me.txtdecost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdecost.Location = New System.Drawing.Point(152, 152)
        Me.txtdecost.MaxLength = 2
        Me.txtdecost.Name = "txtdecost"
        Me.txtdecost.Size = New System.Drawing.Size(40, 21)
        Me.txtdecost.TabIndex = 13
        '
        'txtdecpre
        '
        Me.txtdecpre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdecpre.Location = New System.Drawing.Point(152, 176)
        Me.txtdecpre.MaxLength = 2
        Me.txtdecpre.Name = "txtdecpre"
        Me.txtdecpre.Size = New System.Drawing.Size(40, 21)
        Me.txtdecpre.TabIndex = 16
        '
        'txtdectot
        '
        Me.txtdectot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdectot.Location = New System.Drawing.Point(152, 200)
        Me.txtdectot.MaxLength = 2
        Me.txtdectot.Name = "txtdectot"
        Me.txtdectot.Size = New System.Drawing.Size(40, 21)
        Me.txtdectot.TabIndex = 19
        '
        'txtigv
        '
        Me.txtigv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtigv.Location = New System.Drawing.Point(264, 200)
        Me.txtigv.MaxLength = 2
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(40, 21)
        Me.txtigv.TabIndex = 22
        '
        'cboptovta
        '
        Me.cboptovta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboptovta.Location = New System.Drawing.Point(152, 274)
        Me.cboptovta.Name = "cboptovta"
        Me.cboptovta.Size = New System.Drawing.Size(232, 21)
        Me.cboptovta.TabIndex = 27
        '
        'chbuni
        '
        Me.chbuni.Location = New System.Drawing.Point(216, 16)
        Me.chbuni.Name = "chbuni"
        Me.chbuni.Size = New System.Drawing.Size(136, 16)
        Me.chbuni.TabIndex = 0
        Me.chbuni.Text = "UNICNROFACBOL"
        Me.chbuni.Visible = False
        '
        'chbsal
        '
        Me.chbsal.Location = New System.Drawing.Point(216, 40)
        Me.chbsal.Name = "chbsal"
        Me.chbsal.Size = New System.Drawing.Size(88, 16)
        Me.chbsal.TabIndex = 3
        Me.chbsal.Text = "SALIDAIMP"
        '
        'ImageLis2
        '
        Me.ImageLis2.ImageStream = CType(resources.GetObject("ImageLis2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageLis2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageLis2.Images.SetKeyName(0, "")
        Me.ImageLis2.Images.SetKeyName(1, "")
        Me.ImageLis2.Images.SetKeyName(2, "")
        Me.ImageLis2.Images.SetKeyName(3, "")
        Me.ImageLis2.Images.SetKeyName(4, "")
        Me.ImageLis2.Images.SetKeyName(5, "")
        Me.ImageLis2.Images.SetKeyName(6, "")
        Me.ImageLis2.Images.SetKeyName(7, "")
        Me.ImageLis2.Images.SetKeyName(8, "")
        Me.ImageLis2.Images.SetKeyName(9, "")
        Me.ImageLis2.Images.SetKeyName(10, "")
        Me.ImageLis2.Images.SetKeyName(11, "")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(646, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 216)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageLis2
        Me.btnreporte.Location = New System.Drawing.Point(17, 185)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(79, 23)
        Me.btnreporte.TabIndex = 6
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageLis2
        Me.BTNCANCELAR.Location = New System.Drawing.Point(17, 130)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNCANCELAR.TabIndex = 4
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageLis2
        Me.BTNCERRAR.Location = New System.Drawing.Point(17, 157)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNCERRAR.TabIndex = 5
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageLis2
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(17, 75)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNMODIFICAR.TabIndex = 2
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageLis2
        Me.BTNELIMINAR.Location = New System.Drawing.Point(17, 104)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageLis2
        Me.BTNNUEVO.Location = New System.Drawing.Point(17, 19)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(79, 23)
        Me.BTNNUEVO.TabIndex = 0
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageLis2
        Me.BTNGUARDAR.Location = New System.Drawing.Point(17, 47)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(88, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Empresa :"
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Ivory
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(408, 270)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(10, 18)
        Me.grid1.TabIndex = 25
        Me.grid1.Visible = False
        '
        'cboempresa
        '
        Me.cboempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboempresa.Location = New System.Drawing.Point(152, 250)
        Me.cboempresa.Name = "cboempresa"
        Me.cboempresa.Size = New System.Drawing.Size(232, 21)
        Me.cboempresa.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFacSuperVisorHU)
        Me.GroupBox2.Controls.Add(Me.chkFacSubEmpHU)
        Me.GroupBox2.Controls.Add(Me.txtUltimaCargaTipopre)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.txtUltimaCargaProd)
        Me.GroupBox2.Controls.Add(Me.Label43)
        Me.GroupBox2.Controls.Add(Me.txtUltimaCargaClient)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.txtTiempoEnviar)
        Me.GroupBox2.Controls.Add(Me.chkFacPtovta)
        Me.GroupBox2.Controls.Add(Me.chkFacSubEmp)
        Me.GroupBox2.Controls.Add(Me.chkFacLinea)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.txtNroCliePri)
        Me.GroupBox2.Controls.Add(Me.txtCodLocal)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.txtNroClieDep)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.txtNoSerie)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.txtNumPedido)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txt_nroImp)
        Me.GroupBox2.Controls.Add(Me.txtMargenMinDescPlan)
        Me.GroupBox2.Controls.Add(Me.txtUbigueo)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtCorreo)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txtCodHash)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txtConsulta)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtResolucion)
        Me.GroupBox2.Controls.Add(Me.chkEmelec)
        Me.GroupBox2.Controls.Add(Me.txtRutaArchivo)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtCodigoDomicilioF)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtTipoOperacion)
        Me.GroupBox2.Controls.Add(Me.txtDiasCStck)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.txtMargenMinDesc)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtCotizacion)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtPrecioNPTienda)
        Me.GroupBox2.Controls.Add(Me.cboAlmacen)
        Me.GroupBox2.Controls.Add(Me.lblAlm)
        Me.GroupBox2.Controls.Add(Me.TxtPorcDesc)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtPrecioNotaPedido)
        Me.GroupBox2.Controls.Add(Me.txtPrecioFactura)
        Me.GroupBox2.Controls.Add(Me.txtPrecioBoleta)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.grid1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboempresa)
        Me.GroupBox2.Controls.Add(Me.chbsal)
        Me.GroupBox2.Controls.Add(Me.chbuni)
        Me.GroupBox2.Controls.Add(Me.cboptovta)
        Me.GroupBox2.Controls.Add(Me.txtigv)
        Me.GroupBox2.Controls.Add(Me.txtdectot)
        Me.GroupBox2.Controls.Add(Me.txtdecpre)
        Me.GroupBox2.Controls.Add(Me.txtdecost)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtdecant)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtproceso)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtmext)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtmbase)
        Me.GroupBox2.Controls.Add(Me.chkActivaDup)
        Me.GroupBox2.Controls.Add(Me.chkPgocaja)
        Me.GroupBox2.Controls.Add(Me.txtlimpcred)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 697)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtUltimaCargaTipopre
        '
        Me.txtUltimaCargaTipopre.Location = New System.Drawing.Point(444, 105)
        Me.txtUltimaCargaTipopre.Name = "txtUltimaCargaTipopre"
        Me.txtUltimaCargaTipopre.Size = New System.Drawing.Size(174, 21)
        Me.txtUltimaCargaTipopre.TabIndex = 130
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(316, 109)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(125, 13)
        Me.Label44.TabIndex = 129
        Me.Label44.Text = "Ultima fecha Tipo Precio:"
        '
        'txtUltimaCargaProd
        '
        Me.txtUltimaCargaProd.Location = New System.Drawing.Point(444, 81)
        Me.txtUltimaCargaProd.Name = "txtUltimaCargaProd"
        Me.txtUltimaCargaProd.Size = New System.Drawing.Size(174, 21)
        Me.txtUltimaCargaProd.TabIndex = 128
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(291, 85)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(152, 13)
        Me.Label43.TabIndex = 127
        Me.Label43.Text = "Ultima fecha Cargar Producto:"
        '
        'txtUltimaCargaClient
        '
        Me.txtUltimaCargaClient.Location = New System.Drawing.Point(444, 57)
        Me.txtUltimaCargaClient.Name = "txtUltimaCargaClient"
        Me.txtUltimaCargaClient.Size = New System.Drawing.Size(174, 21)
        Me.txtUltimaCargaClient.TabIndex = 126
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(299, 61)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(142, 13)
        Me.Label42.TabIndex = 125
        Me.Label42.Text = "Ultima fecha Cargar Cliente:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(321, 30)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(81, 13)
        Me.Label41.TabIndex = 124
        Me.Label41.Text = "Tiempo Enviar :"
        '
        'txtTiempoEnviar
        '
        Me.txtTiempoEnviar.Location = New System.Drawing.Point(408, 29)
        Me.txtTiempoEnviar.Name = "txtTiempoEnviar"
        Me.txtTiempoEnviar.Size = New System.Drawing.Size(103, 21)
        Me.txtTiempoEnviar.TabIndex = 123
        '
        'chkFacPtovta
        '
        Me.chkFacPtovta.Location = New System.Drawing.Point(315, 194)
        Me.chkFacPtovta.Name = "chkFacPtovta"
        Me.chkFacPtovta.Size = New System.Drawing.Size(229, 16)
        Me.chkFacPtovta.TabIndex = 122
        Me.chkFacPtovta.Text = "FACTURACION POR PTOVTA"
        '
        'chkFacSubEmp
        '
        Me.chkFacSubEmp.Location = New System.Drawing.Point(315, 227)
        Me.chkFacSubEmp.Name = "chkFacSubEmp"
        Me.chkFacSubEmp.Size = New System.Drawing.Size(229, 16)
        Me.chkFacSubEmp.TabIndex = 121
        Me.chkFacSubEmp.Text = "FACTURACION POR SUB EMPRESA"
        '
        'chkFacLinea
        '
        Me.chkFacLinea.Location = New System.Drawing.Point(315, 210)
        Me.chkFacLinea.Name = "chkFacLinea"
        Me.chkFacLinea.Size = New System.Drawing.Size(229, 16)
        Me.chkFacLinea.TabIndex = 120
        Me.chkFacLinea.Text = "FACTURACION POR LINEA"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(358, 407)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(89, 13)
        Me.Label40.TabIndex = 119
        Me.Label40.Text = "Dias Adelantado:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(315, 355)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(60, 13)
        Me.Label39.TabIndex = 118
        Me.Label39.Text = "Nro CliePri:"
        '
        'txtNroCliePri
        '
        Me.txtNroCliePri.Location = New System.Drawing.Point(377, 352)
        Me.txtNroCliePri.Name = "txtNroCliePri"
        Me.txtNroCliePri.Size = New System.Drawing.Size(133, 21)
        Me.txtNroCliePri.TabIndex = 117
        '
        'txtCodLocal
        '
        Me.txtCodLocal.Location = New System.Drawing.Point(384, 431)
        Me.txtCodLocal.Name = "txtCodLocal"
        Me.txtCodLocal.Size = New System.Drawing.Size(132, 21)
        Me.txtCodLocal.TabIndex = 116
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(321, 434)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(57, 13)
        Me.Label37.TabIndex = 115
        Me.Label37.Text = "Cod Local:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(309, 381)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(67, 13)
        Me.Label36.TabIndex = 114
        Me.Label36.Text = "Nro ClieDep:"
        '
        'txtNroClieDep
        '
        Me.txtNroClieDep.Location = New System.Drawing.Point(378, 378)
        Me.txtNroClieDep.Name = "txtNroClieDep"
        Me.txtNroClieDep.Size = New System.Drawing.Size(133, 21)
        Me.txtNroClieDep.TabIndex = 113
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(324, 665)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(51, 13)
        Me.Label35.TabIndex = 112
        Me.Label35.Text = "No Serie:"
        '
        'txtNoSerie
        '
        Me.txtNoSerie.Location = New System.Drawing.Point(377, 662)
        Me.txtNoSerie.Name = "txtNoSerie"
        Me.txtNoSerie.Size = New System.Drawing.Size(133, 21)
        Me.txtNoSerie.TabIndex = 111
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(2, 670)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(123, 13)
        Me.Label34.TabIndex = 110
        Me.Label34.Text = "Margen Min Descuento :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(128, 667)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 21)
        Me.TextBox2.TabIndex = 109
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(300, 306)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(66, 13)
        Me.Label33.TabIndex = 108
        Me.Label33.Text = "Nro Pedido :"
        '
        'txtNumPedido
        '
        Me.txtNumPedido.AcceptsReturn = True
        Me.txtNumPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumPedido.Location = New System.Drawing.Point(372, 303)
        Me.txtNumPedido.MaxLength = 350
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(114, 21)
        Me.txtNumPedido.TabIndex = 107
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(2, 538)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(146, 13)
        Me.Label32.TabIndex = 106
        Me.Label32.Text = "Margen Min Plan Descuento :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(328, 330)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(46, 13)
        Me.Label29.TabIndex = 104
        Me.Label29.Text = "NroImp:"
        '
        'txt_nroImp
        '
        Me.txt_nroImp.Location = New System.Drawing.Point(377, 327)
        Me.txt_nroImp.Name = "txt_nroImp"
        Me.txt_nroImp.Size = New System.Drawing.Size(133, 21)
        Me.txt_nroImp.TabIndex = 103
        '
        'txtMargenMinDescPlan
        '
        Me.txtMargenMinDescPlan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMargenMinDescPlan.Location = New System.Drawing.Point(148, 534)
        Me.txtMargenMinDescPlan.Name = "txtMargenMinDescPlan"
        Me.txtMargenMinDescPlan.Size = New System.Drawing.Size(112, 21)
        Me.txtMargenMinDescPlan.TabIndex = 105
        '
        'txtUbigueo
        '
        Me.txtUbigueo.Location = New System.Drawing.Point(378, 612)
        Me.txtUbigueo.Name = "txtUbigueo"
        Me.txtUbigueo.Size = New System.Drawing.Size(133, 21)
        Me.txtUbigueo.TabIndex = 102
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(324, 616)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 13)
        Me.Label30.TabIndex = 101
        Me.Label30.Text = "Ubigueo:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(330, 639)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(44, 13)
        Me.Label28.TabIndex = 99
        Me.Label28.Text = "Correo:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(377, 636)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(133, 21)
        Me.txtCorreo.TabIndex = 98
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(317, 592)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 13)
        Me.Label27.TabIndex = 97
        Me.Label27.Text = "Cod Hash:"
        '
        'txtCodHash
        '
        Me.txtCodHash.Location = New System.Drawing.Point(377, 588)
        Me.txtCodHash.Name = "txtCodHash"
        Me.txtCodHash.Size = New System.Drawing.Size(133, 21)
        Me.txtCodHash.TabIndex = 96
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(317, 571)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 13)
        Me.Label26.TabIndex = 95
        Me.Label26.Text = "Consultar:"
        '
        'txtConsulta
        '
        Me.txtConsulta.Location = New System.Drawing.Point(377, 565)
        Me.txtConsulta.Name = "txtConsulta"
        Me.txtConsulta.Size = New System.Drawing.Size(133, 21)
        Me.txtConsulta.TabIndex = 94
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(312, 545)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 93
        Me.Label25.Text = "Resolucion:"
        '
        'txtResolucion
        '
        Me.txtResolucion.Location = New System.Drawing.Point(377, 541)
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(133, 21)
        Me.txtResolucion.TabIndex = 92
        '
        'chkEmelec
        '
        Me.chkEmelec.Location = New System.Drawing.Point(318, 176)
        Me.chkEmelec.Name = "chkEmelec"
        Me.chkEmelec.Size = New System.Drawing.Size(144, 16)
        Me.chkEmelec.TabIndex = 91
        Me.chkEmelec.Text = "EMISOR ELECTRONICO"
        '
        'txtRutaArchivo
        '
        Me.txtRutaArchivo.Location = New System.Drawing.Point(377, 514)
        Me.txtRutaArchivo.Name = "txtRutaArchivo"
        Me.txtRutaArchivo.Size = New System.Drawing.Size(134, 21)
        Me.txtRutaArchivo.TabIndex = 90
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(340, 517)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 13)
        Me.Label24.TabIndex = 89
        Me.Label24.Text = "Ruta:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(258, 490)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(116, 13)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = "Codigo Domicilio Fiscal:"
        '
        'txtCodigoDomicilioF
        '
        Me.txtCodigoDomicilioF.Location = New System.Drawing.Point(377, 487)
        Me.txtCodigoDomicilioF.Name = "txtCodigoDomicilioF"
        Me.txtCodigoDomicilioF.Size = New System.Drawing.Size(134, 21)
        Me.txtCodigoDomicilioF.TabIndex = 87
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(278, 460)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 13)
        Me.Label22.TabIndex = 86
        Me.Label22.Text = "Tipo de Operacion:"
        '
        'txtTipoOperacion
        '
        Me.txtTipoOperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoOperacion.Location = New System.Drawing.Point(378, 457)
        Me.txtTipoOperacion.Name = "txtTipoOperacion"
        Me.txtTipoOperacion.Size = New System.Drawing.Size(112, 21)
        Me.txtTipoOperacion.TabIndex = 85
        Me.txtTipoOperacion.Text = "RE"
        '
        'txtDiasCStck
        '
        Me.txtDiasCStck.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDiasCStck.Location = New System.Drawing.Point(211, 637)
        Me.txtDiasCStck.MaxLength = 2
        Me.txtDiasCStck.Name = "txtDiasCStck"
        Me.txtDiasCStck.Size = New System.Drawing.Size(116, 21)
        Me.txtDiasCStck.TabIndex = 84
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(2, 640)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(203, 13)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "Dias Adelantados para calcular el stock  :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.rdDescDoc)
        Me.GroupBox3.Controls.Add(Me.rdOrdDesc)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 561)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(206, 72)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo Descuento"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(-47, -11)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(123, 13)
        Me.Label31.TabIndex = 106
        Me.Label31.Text = "Margen Min Descuento :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdDescDoc
        '
        Me.rdDescDoc.AutoSize = True
        Me.rdDescDoc.Location = New System.Drawing.Point(25, 20)
        Me.rdDescDoc.Name = "rdDescDoc"
        Me.rdDescDoc.Size = New System.Drawing.Size(174, 17)
        Me.rdDescDoc.TabIndex = 81
        Me.rdDescDoc.TabStop = True
        Me.rdDescDoc.Text = "Descuento en Orden Despacho"
        Me.rdDescDoc.UseVisualStyleBackColor = True
        '
        'rdOrdDesc
        '
        Me.rdOrdDesc.AutoSize = True
        Me.rdOrdDesc.Location = New System.Drawing.Point(25, 44)
        Me.rdOrdDesc.Name = "rdOrdDesc"
        Me.rdOrdDesc.Size = New System.Drawing.Size(137, 17)
        Me.rdOrdDesc.TabIndex = 82
        Me.rdOrdDesc.TabStop = True
        Me.rdOrdDesc.Text = "Generar Doc.Contables"
        Me.rdOrdDesc.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(2, 515)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(123, 13)
        Me.Label38.TabIndex = 80
        Me.Label38.Text = "Margen Min Descuento :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMargenMinDesc
        '
        Me.txtMargenMinDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMargenMinDesc.Location = New System.Drawing.Point(129, 512)
        Me.txtMargenMinDesc.Name = "txtMargenMinDesc"
        Me.txtMargenMinDesc.Size = New System.Drawing.Size(112, 21)
        Me.txtMargenMinDesc.TabIndex = 79
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(45, 488)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Nro Cotizacion"
        '
        'txtCotizacion
        '
        Me.txtCotizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCotizacion.Location = New System.Drawing.Point(128, 485)
        Me.txtCotizacion.MaxLength = 350
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.Size = New System.Drawing.Size(152, 21)
        Me.txtCotizacion.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(59, 466)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "NP Tienda"
        '
        'txtPrecioNPTienda
        '
        Me.txtPrecioNPTienda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecioNPTienda.Location = New System.Drawing.Point(128, 458)
        Me.txtPrecioNPTienda.MaxLength = 350
        Me.txtPrecioNPTienda.Name = "txtPrecioNPTienda"
        Me.txtPrecioNPTienda.Size = New System.Drawing.Size(152, 21)
        Me.txtPrecioNPTienda.TabIndex = 43
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.ItemHeight = 13
        Me.cboAlmacen.Location = New System.Drawing.Point(75, 431)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(238, 21)
        Me.cboAlmacen.TabIndex = 42
        '
        'lblAlm
        '
        Me.lblAlm.AutoSize = True
        Me.lblAlm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAlm.Location = New System.Drawing.Point(2, 434)
        Me.lblAlm.Name = "lblAlm"
        Me.lblAlm.Size = New System.Drawing.Size(71, 13)
        Me.lblAlm.TabIndex = 41
        Me.lblAlm.Text = "Almacen BM :"
        '
        'TxtPorcDesc
        '
        Me.TxtPorcDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPorcDesc.Location = New System.Drawing.Point(200, 404)
        Me.TxtPorcDesc.MaxLength = 350
        Me.TxtPorcDesc.Name = "TxtPorcDesc"
        Me.TxtPorcDesc.Size = New System.Drawing.Size(152, 21)
        Me.TxtPorcDesc.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 407)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(179, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "% Dsto en Rpte Conso.Descuento :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 382)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Precio Nota de Pedido :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(54, 360)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Precio Factura :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(61, 333)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Precio Boleta :"
        '
        'txtPrecioNotaPedido
        '
        Me.txtPrecioNotaPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecioNotaPedido.Location = New System.Drawing.Point(152, 379)
        Me.txtPrecioNotaPedido.MaxLength = 350
        Me.txtPrecioNotaPedido.Name = "txtPrecioNotaPedido"
        Me.txtPrecioNotaPedido.Size = New System.Drawing.Size(152, 21)
        Me.txtPrecioNotaPedido.TabIndex = 35
        '
        'txtPrecioFactura
        '
        Me.txtPrecioFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecioFactura.Location = New System.Drawing.Point(152, 352)
        Me.txtPrecioFactura.MaxLength = 350
        Me.txtPrecioFactura.Name = "txtPrecioFactura"
        Me.txtPrecioFactura.Size = New System.Drawing.Size(152, 21)
        Me.txtPrecioFactura.TabIndex = 34
        '
        'txtPrecioBoleta
        '
        Me.txtPrecioBoleta.AcceptsReturn = True
        Me.txtPrecioBoleta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecioBoleta.Location = New System.Drawing.Point(152, 325)
        Me.txtPrecioBoleta.MaxLength = 350
        Me.txtPrecioBoleta.Name = "txtPrecioBoleta"
        Me.txtPrecioBoleta.Size = New System.Drawing.Size(152, 21)
        Me.txtPrecioBoleta.TabIndex = 33
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(233, 223)
        Me.TextBox1.MaxLength = 359
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 21)
        Me.TextBox1.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(40, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(187, 13)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Coeficiente de Evaluacion de Pedido :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Fecha de Proceso x PtoVta"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(152, 96)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 21)
        Me.DateTimePicker1.TabIndex = 9
        Me.DateTimePicker1.Value = New Date(2008, 1, 29, 0, 0, 0, 0)
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(216, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 32)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Generar Código Automático para el Cliente"
        '
        'chkActivaDup
        '
        Me.chkActivaDup.Location = New System.Drawing.Point(216, 158)
        Me.chkActivaDup.Name = "chkActivaDup"
        Me.chkActivaDup.Size = New System.Drawing.Size(144, 16)
        Me.chkActivaDup.TabIndex = 17
        Me.chkActivaDup.Text = "ACTIVA BD ALTERNO"
        '
        'chkPgocaja
        '
        Me.chkPgocaja.Location = New System.Drawing.Point(216, 182)
        Me.chkPgocaja.Name = "chkPgocaja"
        Me.chkPgocaja.Size = New System.Drawing.Size(144, 16)
        Me.chkPgocaja.TabIndex = 20
        Me.chkPgocaja.Text = "PAGO EN CAJA"
        '
        'txtlimpcred
        '
        Me.txtlimpcred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtlimpcred.Location = New System.Drawing.Point(152, 298)
        Me.txtlimpcred.MaxLength = 2
        Me.txtlimpcred.Name = "txtlimpcred"
        Me.txtlimpcred.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtlimpcred.Size = New System.Drawing.Size(40, 21)
        Me.txtlimpcred.TabIndex = 29
        Me.txtlimpcred.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(62, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Limite Credito :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(200, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Dia(s)"
        '
        'txtDiasAdelantado
        '
        Me.txtDiasAdelantado.Location = New System.Drawing.Point(458, 416)
        Me.txtDiasAdelantado.Name = "txtDiasAdelantado"
        Me.txtDiasAdelantado.Size = New System.Drawing.Size(67, 21)
        Me.txtDiasAdelantado.TabIndex = 120
        '
        'chkFacSubEmpHU
        '
        Me.chkFacSubEmpHU.Location = New System.Drawing.Point(397, 247)
        Me.chkFacSubEmpHU.Name = "chkFacSubEmpHU"
        Me.chkFacSubEmpHU.Size = New System.Drawing.Size(229, 16)
        Me.chkFacSubEmpHU.TabIndex = 131
        Me.chkFacSubEmpHU.Text = "FACTURACION POR SUB EMPRESA HU"
        '
        'chkFacSuperVisorHU
        '
        Me.chkFacSuperVisorHU.Location = New System.Drawing.Point(397, 269)
        Me.chkFacSuperVisorHU.Name = "chkFacSuperVisorHU"
        Me.chkFacSuperVisorHU.Size = New System.Drawing.Size(229, 16)
        Me.chkFacSuperVisorHU.TabIndex = 132
        Me.chkFacSuperVisorHU.Text = "FACTURACION POR SUPERVISOR HU"
        '
        'FrmConfigSis
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(784, 721)
        Me.Controls.Add(Me.txtDiasAdelantado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 760)
        Me.MinimumSize = New System.Drawing.Size(800, 678)
        Me.Name = "FrmConfigSis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Configuracion del Sistema"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Funciones form"
    Sub cargadatos()
        'Call Cargagrid(grid1, "Nsp_select_configSis", cboempresa.SelectedValue)
        grid1.DataSource = CAyuda.ListarDatos("Nsp_select_configSis", cboempresa.SelectedValue).Tables(0)
    End Sub

    Sub Carga()
        cargadatos()
        Dim r As Integer
        r = 0
        VAR1 = grid1.Item(r, 0)
        VAR2 = grid1.Item(r, 1)
        VAR3 = grid1.Item(r, 2)
        VAR4 = grid1.Item(r, 3)
        VAR5 = grid1.Item(r, 4)
        VAR6 = grid1.Item(r, 5)
        VAR7 = grid1.Item(r, 6)
        VAR8 = grid1.Item(r, 7)
        VAR9 = grid1.Item(r, 8)

        If VAR9 = True Then
            chbuni.CheckState = CheckState.Checked
        End If
        If VAR9 = False Then
            chbuni.CheckState = CheckState.Unchecked
        End If
        VAR10 = grid1.Item(r, 9)
        VAR11 = grid1.Item(r, 10)
        VAR12 = grid1.Item(r, 11)
        VAR13 = grid1.Item(r, 12)
        VAR14 = grid1.Item(r, 13)
        VAR15 = grid1.Item(r, 16)
        VAR17 = grid1.Item(r, 17)
        VAR18 = grid1.Item(r, 18)
        VAR19 = grid1.Item(r, 19)
        VAR20 = grid1.Item(r, 20)
        VAR21 = grid1.Item(r, 21)
        VAR22 = grid1.Item(r, 22)
        VAR23 = grid1.Item(r, 23)
        VAR24 = grid1.Item(r, 24)
        VAR26 = grid1.Item(r, 26)
        VAR27 = grid1.Item(r, 27)
        VAR28 = grid1.Item(r, 28)
        VAR29 = grid1.Item(r, 29)
        VAR30 = grid1.Item(r, 31)
        VAR31 = grid1.Item(r, 32)
        VAR32 = grid1.Item(r, 33)
        VAR33 = grid1.Item(r, 34)
        VAR34 = grid1.Item(r, 35)
        VAR35 = grid1.Item(r, 36)
        VAR36 = grid1.Item(r, 37)
        VAR37 = grid1.Item(r, 38)
        VAR38 = grid1.Item(r, 39)
        VAR39 = grid1.Item(r, 40)
        VAR40 = grid1.Item(r, 41)
        VAR41 = grid1.Item(r, 45)
        VAR42 = grid1.Item(r, 46)
        VAR43 = grid1.Item(r, 47)
        VAR44 = grid1.Item(r, 48)



        ' VAR27TALMA = grid1.Item(r, 27)

        If CBool(grid1.Item(r, 25)) = True Then
            rdDescDoc.Checked = True
        Else
            rdOrdDesc.Checked = True
        End If

        If CBool(grid1.Item(r, 14)) = True Then
            chkActivaDup.Checked = True
        Else
            chkActivaDup.Checked = False
        End If

        If CBool(grid1.Item(r, 15)) = True Then
            chkPgocaja.Checked = True
        Else
            chkPgocaja.Checked = False
        End If

        If CBool(grid1.Item(r, 30)) = True Then
            chkEmelec.Checked = True
        Else
            chkEmelec.Checked = False
        End If

        If VAR12 = True Then
            chbsal.CheckState = CheckState.Checked
        End If

        If VAR14 = True Then
            Me.CheckBox1.Checked = True
        Else
            Me.CheckBox1.Checked = False
        End If

        If VAR12 = False Then
            chbsal.CheckState = CheckState.Unchecked
        End If

        If CBool(grid1.Item(r, 42)) = True Then
            chkFacPtovta.Checked = True
        Else
            chkFacPtovta.Checked = False
        End If

        If CBool(grid1.Item(r, 43)) = True Then
            chkFacLinea.Checked = True
        Else
            chkFacLinea.Checked = False
        End If


        If CBool(grid1.Item(r, 44)) = True Then
            chkFacSubEmp.Checked = True
        Else
            chkFacSubEmp.Checked = False
        End If

        If CBool(grid1.Item(r, 49)) = True Then
            chkFacSubEmpHU.Checked = True
        Else
            chkFacSubEmpHU.Checked = False
        End If

        If CBool(grid1.Item(r, 50)) = True Then
            chkFacSuperVisorHU.Checked = True
        Else
            chkFacSuperVisorHU.Checked = False
        End If

        mostrar()

    End Sub

#End Region

    Private flag As Integer
    Private flag2 As Boolean


    Private TIPODESC As Integer


    Private Sub FrmConfigSis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtproceso.Enabled = False
        Call Bloqueatextbox(Me)
        Call BOTONES(True, False, True, False)
        CAyuda.CargarDataCombo(cboptovta, "Nsp_select_ptovta", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(cboempresa, "Nsp_select_empresa", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(cboAlmacen, "Nsp_select_Almacen  '" & codempresa & "'", "codigo", "descripcion")
        Carga()
        Conecta("BUSCA_FECHA '" & codempresa & "','" & NROPTOVTA & "'", "X")
        Me.DateTimePicker1.Value = Format(ds.Tables("X").Rows(0)(0), "dd/MM/yyyy")
        Me.DateTimePicker1.Enabled = False
        flag2 = True


        'cboAlmacen.SelectedValue = VAR27TALMA


    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False)
        flag = 0
        Me.DateTimePicker1.Enabled = True
        Me.dtproceso.Enabled = True
    End Sub
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call BOTONES(True, False, True, False)
        Call Bloqueatextbox(Me)
        Me.dtproceso.Enabled = False
        Me.DateTimePicker1.Enabled = False
    End Sub



    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim PROCESO As Boolean
        Dim sql As String
        sql = "Nsp_delete_ConfigSis '" & codempresa & "','" & Date.Parse(dtproceso.Text) & "','" & CodUsuario & "'"
        PROCESO = TmpInsertDatos(sql)
        If PROCESO = False Then
            Exit Sub
        Else
            TmpInsertDatos("SP_REGISTRA_AUDITORIA 'codempresa','DELETE','CONFIGSIS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "'")
        End If
        BOTONES(True, False, True, False)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
    End Sub

    Public Sub mostrar()
        txtmbase.Text = VAR1
        txtmext.Text = VAR2
        dtproceso.Value = Format(CDate(VAR3), "dd/MM/yyyy")
        txtdecant.Text = VAR4
        txtdecost.Text = VAR5
        txtdecpre.Text = VAR6
        txtdectot.Text = VAR7
        txtigv.Text = VAR8
        cboempresa.Text = VAR10
        cboptovta.Text = VAR11
        Me.txtlimpcred.Text = VAR15
        Me.TextBox1.Text = VAR17

        Me.txtPrecioBoleta.Text = VAR18
        Me.txtPrecioFactura.Text = VAR19
        Me.txtPrecioNotaPedido.Text = VAR20

        TxtPorcDesc.Text = VAR21
        txtPrecioNPTienda.Text = VAR22
        txtCotizacion.Text = VAR23

        txtMargenMinDesc.Text = VAR24
        txtDiasCStck.Text = VAR26
        txtTipoOperacion.Text = VAR27
        txtCodigoDomicilioF.Text = VAR28
        txtRutaArchivo.Text = VAR29
        txtResolucion.Text = VAR30
        txtConsulta.Text = VAR31

        txt_nroImp.Text = VAR32
        txtMargenMinDescPlan.Text = VAR33
        txtNumPedido.Text = VAR34
        txtNoSerie.Text = VAR35
        txtNroClieDep.Text = VAR36
        txtCodLocal.Text = VAR37
        txtNroCliePri.Text = VAR38
        cboAlmacen.SelectedValue = VAR39
        txtDiasAdelantado.Text = VAR40
        txtTiempoEnviar.Text = VAR41
        txtUltimaCargaClient.Text = VAR42
        txtUltimaCargaProd.Text = VAR43
        txtUltimaCargaTipopre.Text = VAR44

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Dim sql As String = ""
        Dim fechasys As String
        Dim PROCESO As Boolean
        Dim j As Integer
        Dim l As Integer
        Dim k As Integer
        Dim h As Integer
        Dim f As Integer
        Dim factptovta As Integer
        Dim factptolinea As Integer
        Dim factptosubemp As Integer

        Dim factptosubempHU As Integer
        Dim factptosupervHU As Integer

        Call formatotextbox(Me)
        Dim fecha As String
        fechasys = dtproceso.Value.Date
        fechasys = Format(CDate(fechasys), "dd/mm/yyyy")
        If chbuni.Checked = True Then
            j = 1
        End If
        If chbuni.Checked = False Then
            j = 0
        End If
        If chbsal.Checked = True Then
            l = 1
        End If
        If chbsal.Checked = False Then
            l = 0
        End If
        If Me.chkActivaDup.Checked = True Then
            k = 1
        Else
            k = 0
        End If

        If Me.chkPgocaja.Checked = True Then
            h = 1
        Else
            h = 0
        End If

        If Me.chkEmelec.Checked = True Then
            f = 1
        Else
            f = 0
        End If

        If Me.chkFacPtovta.Checked = True Then
            factptovta = 1
        Else
            factptovta = 0
        End If

        If Me.chkFacLinea.Checked = True Then
            factptolinea = 1
        Else
            factptolinea = 0
        End If

        If Me.chkFacSubEmp.Checked = True Then
            factptosubemp = 1
        Else
            factptosubemp = 0
        End If

        If Me.chkFacSubEmpHU.Checked = True Then
            factptosubempHU = 1
        Else
            factptosubempHU = 0
        End If

        If Me.chkFacSuperVisorHU.Checked = True Then
            factptosupervHU = 1
        Else
            factptosupervHU = 0
        End If



        If txtmbase.Text = "" Or txtmext.Text = "" Or txtdecant.Text = "" Or txtdecost.Text = "" Or txtdecpre.Text = "" Or txtdectot.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If




        If flag = 0 Then
            sql = "Nsp_inst_ConfigSis '" & txtmbase.Text & "','" & txtmext.Text & "','" & Format(Me.dtproceso.Value, "dd/MM/yy") &
                "'," & Decimal.Parse(txtdecant.Text) & "," & Decimal.Parse(txtdecost.Text) & "," & Decimal.Parse(txtdecpre.Text) &
                "," & Decimal.Parse(txtdectot.Text) & "," & Decimal.Parse(txtigv.Text) & "," & j & ",'" & cboempresa.Text & "','" &
                cboptovta.Text & "'," & l & ",'" & cboempresa.SelectedValue & "','" & CodUsuario & "'," & clie & ", " & k & "," & h &
                "," & CInt(txtlimpcred.Text) & "," & CDbl(TextBox1.Text) & "," & CDbl(txtPrecioBoleta.Text) & "," & CDbl(txtPrecioFactura.Text) &
                "," & CDbl(txtPrecioNotaPedido.Text) & "," & CDbl(TxtPorcDesc.Text) & ",'" & cboAlmacen.SelectedValue.ToString & "'," & CDbl(txtPrecioNPTienda.Text) & "," &
                CInt(txtCotizacion.Text) & "," & CDbl(txtMargenMinDesc.Text) & "," & TIPODESC & "," & CInt(txtDiasCStck.Text) & ",'" & txtTipoOperacion.Text & "','" & txtCodigoDomicilioF.Text &
                "','" & txtRutaArchivo.Text & "','" & f & "','" & txtResolucion.Text & "','" & txtConsulta.Text & "','" & txtCodHash.Text & "','" & txtUbigueo.Text & "','" & txtCorreo.Text & "','" &
                txtMargenMinDescPlan.Text & "','" & txtNumPedido.Text & "','" & txtNoSerie.Text & "'," & txtNroClieDep.Text & ",'" & txtCodLocal.Text & "'," & txtNroCliePri.Text & "," &
                txtDiasAdelantado.Text & "," & factptovta & "," & factptolinea & "," & factptosubemp

            MessageBox.Show("SE REINICIARA EL SISTEMA PARA QUE LOS CAMBIOS TENGAN EFECTO", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA 'INSERT','INSERT','CONFIGSIS','" & Format(System.DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            End
        End If

        If flag = 1 Then

            Try
                sql = "Nsp_upd_ConfigSis '" & txtmbase.Text & "','" & txtmext.Text & "','" & Format(Me.dtproceso.Value, "dd/MM/yy") &
                    "'," & Decimal.Parse(txtdecant.Text) & "," & Decimal.Parse(txtdecost.Text) & "," & Decimal.Parse(txtdecpre.Text) &
                    "," & Decimal.Parse(txtdectot.Text) & "," & Decimal.Parse(txtigv.Text) & "," & j & ",'" & cboempresa.Text & "','" &
                    cboptovta.Text & "'," & l & ",'" & cboempresa.SelectedValue & "','" & CodUsuario & "'," & clie & "," & k & "," & h & "," &
                    CInt(txtlimpcred.Text) & "," & CDbl(TextBox1.Text) & "," & CDbl(txtPrecioBoleta.Text) & "," & CDbl(txtPrecioFactura.Text) & "," &
                    CDbl(txtPrecioNotaPedido.Text) & "," & CDbl(TxtPorcDesc.Text) & ",'" & cboAlmacen.SelectedValue.ToString & "'," & CDbl(txtPrecioNPTienda.Text) & "," &
                    CInt(txtCotizacion.Text) & "," & CDbl(txtMargenMinDesc.Text) & "," & TIPODESC & "," & CInt(txtDiasCStck.Text) & ",'" & txtTipoOperacion.Text & "','" &
                    txtCodigoDomicilioF.Text & "','" & txtRutaArchivo.Text & "','" & f & "','" & txtResolucion.Text & "','" & txtConsulta.Text & "','" & txtCodHash.Text &
                    "','" & txtUbigueo.Text & "','" & txtCorreo.Text & "','" & txt_nroImp.Text & "','" & txtMargenMinDescPlan.Text & "','" & txtNumPedido.Text & "','" &
                    txtNoSerie.Text & "'," & txtNroClieDep.Text & ",'" & txtCodLocal.Text & "'," &
                    txtNroCliePri.Text & "," & txtDiasAdelantado.Text & "," & factptovta & "," & factptolinea & "," & factptosubemp & "," & txtTiempoEnviar.Text & ",'" &
                    txtUltimaCargaClient.Text & "','" & txtUltimaCargaProd.Text & "','" & txtUltimaCargaTipopre.Text & "'," & factptosubempHU & "," & factptosupervHU & ""
                PROCESO = TmpInsertDatos(sql)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            PROCESO = TmpInsertDatos(sql)
            'Guarda("update ptovta set fecproceso='" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "' where nroptovta='" & PtoVta & "'")
            TmpInsertDatos("SP_REGISTRA_AUDITORIA 'UPDATE','UPDATE','CONFIGSIS','" & Format(System.DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            MessageBox.Show("SE REINICIARA EL SISTEMA PARA QUE LOS CAMBIOS TENGAN EFECTO", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End If


        fecha = Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
        TmpInsertDatos("FECHA_UPDATE '" & Venta.ToString & "','" & fecha.ToString & "'")
        If PROCESO = False Then Exit Sub
        Call BOTONES(True, False, True, False)
        Carga()
        Me.dtproceso.Enabled = False
        Me.DateTimePicker1.Enabled = False
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False)
        flag = 1
        Me.dtproceso.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Dim frmx As New FrmVistaConfigSis
        frmx.Show()
    End Sub

    Dim clie As Single
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            clie = 1
        Else
            clie = 0
        End If
    End Sub

    Private Sub cboempresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboempresa.SelectedIndexChanged
        If Me.cboempresa.SelectedIndex <> -1 And flag2 = True Then
            Carga()
        End If

    End Sub

    Private Sub chkPgocaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPgocaja.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdDescDoc.CheckedChanged
        If rdDescDoc.Checked = True Then
            TIPODESC = 1
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdOrdDesc.CheckedChanged
        If rdOrdDesc.Checked = True Then
            TIPODESC = 0
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub chkFacSubEmp_CheckedChanged(sender As Object, e As EventArgs) Handles chkFacSubEmp.CheckedChanged

    End Sub
End Class
