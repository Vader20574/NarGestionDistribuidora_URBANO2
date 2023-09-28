Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports Servicios.Implementacion
Imports Servicios.Interfaces.Factura
Imports Servicios.Interfaces.FacturaElectronica.Peticiones
Imports Servicios.Interfaces.Facturacion
Imports System.Transactions
Imports Servicios.Interfaces.Facturacion.VentaDet.Peticiones

Public Class FrmActualizarFact
    Inherits System.Windows.Forms.Form

    Dim Ayuda As New ClsAyuda
    Public TIPOPRE As String
    Public TIPOPAGO As String
    Public NROGUIA As String
    Public FECHA As Date


    Friend WithEvents gbtipodoc As System.Windows.Forms.GroupBox
    Friend WithEvents rbboleta As System.Windows.Forms.RadioButton
    Friend WithEvents rbfactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbnotap As System.Windows.Forms.RadioButton
    Public CODALMACEN As String
    Public Consul_var As Boolean = True

    Dim DNI As String
    Dim IGV As Double
    Dim EMAIL As String
    Dim SUBTOTAL As Double
    Dim PERCEP As Double
    Dim TIPO_IGV As String
    Dim LETRADOC As String
    Dim SERIE As String
    Dim NUMSERIE As String
    Dim NRODOCSIN As String
    Dim NRODOCFINAL As String
    Dim CLIE_DOCU As String
    Dim listaP As New List(Of NuevaVentaDet)
    Dim listaDesc As New List(Of DescDdocum)
    Dim VNroDoc_ant As String
    Dim VCdTipoDoc_ant As String
    Dim VentaC, VentD As String

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
    Friend WithEvents TXTSERIEDOC As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents CboPagador As System.Windows.Forms.ComboBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtcodclie As System.Windows.Forms.TextBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CHKIGV As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CTRLCANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodarticulo As System.Windows.Forms.TextBox
    Friend WithEvents cbPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btneliitem As System.Windows.Forms.Button
    Friend WithEvents btnactuitem As System.Windows.Forms.Button
    Friend WithEvents btnnueitem As System.Windows.Forms.Button
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscArt As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CTRLPRECIO As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnBusCli As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpfechadoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbltipodoc As System.Windows.Forms.Label
    Friend WithEvents LBLSIMBOLOCAMBIO As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btngeneranuevo As System.Windows.Forms.Button
    Friend WithEvents btnreimprimir As System.Windows.Forms.Button
    Friend WithEvents btnanular As System.Windows.Forms.Button
    Friend WithEvents btndsctototal As System.Windows.Forms.Button
    Friend WithEvents btndsctoitem As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnvale As System.Windows.Forms.Button
    Friend WithEvents btncredito As System.Windows.Forms.Button
    Friend WithEvents btncheque As System.Windows.Forms.Button
    Friend WithEvents btntarjeta As System.Windows.Forms.Button
    Friend WithEvents btnefectivo As System.Windows.Forms.Button
    Friend WithEvents cbTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents cbovendedor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents TxtDESC As System.Windows.Forms.TextBox
    Friend WithEvents TxtSUBTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents TxtIGV As System.Windows.Forms.TextBox
    Friend WithEvents LBLSIMBOLO2 As System.Windows.Forms.Label
    Friend WithEvents LBLSIMBOLO4 As System.Windows.Forms.Label
    Friend WithEvents lblsimbolo As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LBLIGV As System.Windows.Forms.Label
    Friend WithEvents lblcambio As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbloperador As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltotalletras As System.Windows.Forms.Label
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents CRTDOC As AxCrystal.AxCrystalReport
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TXTNUMERODOC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents CboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtpercp As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizarFact))
        Me.TXTSERIEDOC = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.CboPagador = New System.Windows.Forms.ComboBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtcodclie = New System.Windows.Forms.TextBox()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CHKIGV = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CTRLCANTIDAD = New System.Windows.Forms.TextBox()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.txtcodarticulo = New System.Windows.Forms.TextBox()
        Me.cbPresentacion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btneliitem = New System.Windows.Forms.Button()
        Me.btnactuitem = New System.Windows.Forms.Button()
        Me.btnnueitem = New System.Windows.Forms.Button()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.BtnBuscArt = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CTRLPRECIO = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnBusCli = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpfechadoc = New System.Windows.Forms.DateTimePicker()
        Me.lbltipodoc = New System.Windows.Forms.Label()
        Me.LBLSIMBOLOCAMBIO = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btngeneranuevo = New System.Windows.Forms.Button()
        Me.btnreimprimir = New System.Windows.Forms.Button()
        Me.btnanular = New System.Windows.Forms.Button()
        Me.btndsctototal = New System.Windows.Forms.Button()
        Me.btndsctoitem = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnvale = New System.Windows.Forms.Button()
        Me.btncredito = New System.Windows.Forms.Button()
        Me.btncheque = New System.Windows.Forms.Button()
        Me.btntarjeta = New System.Windows.Forms.Button()
        Me.btnefectivo = New System.Windows.Forms.Button()
        Me.cbTipoPrecio = New System.Windows.Forms.ComboBox()
        Me.cbovendedor = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtpercp = New System.Windows.Forms.TextBox()
        Me.TxtTOTAL = New System.Windows.Forms.TextBox()
        Me.TxtDESC = New System.Windows.Forms.TextBox()
        Me.TxtSUBTOTAL = New System.Windows.Forms.TextBox()
        Me.TxtIGV = New System.Windows.Forms.TextBox()
        Me.LBLSIMBOLO2 = New System.Windows.Forms.Label()
        Me.LBLSIMBOLO4 = New System.Windows.Forms.Label()
        Me.lblsimbolo = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LBLIGV = New System.Windows.Forms.Label()
        Me.lblcambio = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.lbloperador = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltotalletras = New System.Windows.Forms.Label()
        Me.Grid1 = New System.Windows.Forms.DataGrid()
        Me.CRTDOC = New AxCrystal.AxCrystalReport()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TXTNUMERODOC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CboMoneda = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbtipodoc = New System.Windows.Forms.GroupBox()
        Me.rbboleta = New System.Windows.Forms.RadioButton()
        Me.rbfactura = New System.Windows.Forms.RadioButton()
        Me.rbnotap = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRTDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbtipodoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTSERIEDOC
        '
        Me.TXTSERIEDOC.BackColor = System.Drawing.Color.White
        Me.TXTSERIEDOC.Enabled = False
        Me.TXTSERIEDOC.Location = New System.Drawing.Point(186, 28)
        Me.TXTSERIEDOC.Name = "TXTSERIEDOC"
        Me.TXTSERIEDOC.Size = New System.Drawing.Size(43, 20)
        Me.TXTSERIEDOC.TabIndex = 173
        Me.TXTSERIEDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdireccion
        '
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Location = New System.Drawing.Point(186, 100)
        Me.txtdireccion.MaxLength = 40
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(370, 20)
        Me.txtdireccion.TabIndex = 153
        '
        'CboPagador
        '
        Me.CboPagador.BackColor = System.Drawing.Color.White
        Me.CboPagador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPagador.Enabled = False
        Me.CboPagador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPagador.Location = New System.Drawing.Point(654, 72)
        Me.CboPagador.Name = "CboPagador"
        Me.CboPagador.Size = New System.Drawing.Size(170, 22)
        Me.CboPagador.TabIndex = 181
        '
        'txtcliente
        '
        Me.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcliente.Location = New System.Drawing.Point(186, 74)
        Me.txtcliente.MaxLength = 150
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(252, 20)
        Me.txtcliente.TabIndex = 152
        '
        'txtcodclie
        '
        Me.txtcodclie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodclie.Location = New System.Drawing.Point(186, 52)
        Me.txtcodclie.MaxLength = 20
        Me.txtcodclie.Name = "txtcodclie"
        Me.txtcodclie.Size = New System.Drawing.Size(81, 20)
        Me.txtcodclie.TabIndex = 149
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(342, 52)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(98, 20)
        Me.txtruc.TabIndex = 151
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label13.Location = New System.Drawing.Point(595, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 180
        Me.Label13.Text = "Pagador : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CHKIGV
        '
        Me.CHKIGV.Checked = True
        Me.CHKIGV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKIGV.Location = New System.Drawing.Point(736, 26)
        Me.CHKIGV.Name = "CHKIGV"
        Me.CHKIGV.Size = New System.Drawing.Size(93, 20)
        Me.CHKIGV.TabIndex = 175
        Me.CHKIGV.Text = "Aplicar IGV"
        Me.CHKIGV.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CTRLCANTIDAD)
        Me.GroupBox1.Controls.Add(Me.txttipo)
        Me.GroupBox1.Controls.Add(Me.txtcodarticulo)
        Me.GroupBox1.Controls.Add(Me.cbPresentacion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btneliitem)
        Me.GroupBox1.Controls.Add(Me.btnactuitem)
        Me.GroupBox1.Controls.Add(Me.btnnueitem)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.BtnBuscArt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.CTRLPRECIO)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 76)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        '
        'CTRLCANTIDAD
        '
        Me.CTRLCANTIDAD.Location = New System.Drawing.Point(360, 46)
        Me.CTRLCANTIDAD.Name = "CTRLCANTIDAD"
        Me.CTRLCANTIDAD.Size = New System.Drawing.Size(60, 20)
        Me.CTRLCANTIDAD.TabIndex = 89
        Me.CTRLCANTIDAD.Text = "0"
        Me.CTRLCANTIDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(74, 83)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(75, 20)
        Me.txttipo.TabIndex = 87
        Me.txttipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttipo.Visible = False
        '
        'txtcodarticulo
        '
        Me.txtcodarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodarticulo.Location = New System.Drawing.Point(88, 16)
        Me.txtcodarticulo.Name = "txtcodarticulo"
        Me.txtcodarticulo.Size = New System.Drawing.Size(89, 20)
        Me.txtcodarticulo.TabIndex = 62
        '
        'cbPresentacion
        '
        Me.cbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPresentacion.Location = New System.Drawing.Point(88, 46)
        Me.cbPresentacion.Name = "cbPresentacion"
        Me.cbPresentacion.Size = New System.Drawing.Size(185, 21)
        Me.cbPresentacion.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(440, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Precio : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Cantidad : "
        '
        'btneliitem
        '
        Me.btneliitem.Location = New System.Drawing.Point(608, 40)
        Me.btneliitem.Name = "btneliitem"
        Me.btneliitem.Size = New System.Drawing.Size(32, 17)
        Me.btneliitem.TabIndex = 51
        Me.btneliitem.Text = "Elimina"
        Me.btneliitem.Visible = False
        '
        'btnactuitem
        '
        Me.btnactuitem.Location = New System.Drawing.Point(612, 15)
        Me.btnactuitem.Name = "btnactuitem"
        Me.btnactuitem.Size = New System.Drawing.Size(26, 17)
        Me.btnactuitem.TabIndex = 50
        Me.btnactuitem.Text = "actualiza"
        Me.btnactuitem.Visible = False
        '
        'btnnueitem
        '
        Me.btnnueitem.Location = New System.Drawing.Point(649, 9)
        Me.btnnueitem.Name = "btnnueitem"
        Me.btnnueitem.Size = New System.Drawing.Size(21, 52)
        Me.btnnueitem.TabIndex = 49
        Me.btnnueitem.Text = "Nuevo"
        Me.btnnueitem.Visible = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Location = New System.Drawing.Point(224, 16)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(330, 20)
        Me.txtdescripcion.TabIndex = 44
        '
        'BtnBuscArt
        '
        Me.BtnBuscArt.ImageIndex = 5
        Me.BtnBuscArt.ImageList = Me.ImageList1
        Me.BtnBuscArt.Location = New System.Drawing.Point(176, 15)
        Me.BtnBuscArt.Name = "BtnBuscArt"
        Me.BtnBuscArt.Size = New System.Drawing.Size(33, 23)
        Me.BtnBuscArt.TabIndex = 43
        Me.BtnBuscArt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Articulo : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "N Bultos :"
        Me.Label17.Visible = False
        '
        'CTRLPRECIO
        '
        Me.CTRLPRECIO.Location = New System.Drawing.Point(496, 46)
        Me.CTRLPRECIO.Name = "CTRLPRECIO"
        Me.CTRLPRECIO.Size = New System.Drawing.Size(60, 20)
        Me.CTRLPRECIO.TabIndex = 89
        Me.CTRLPRECIO.Text = "0"
        Me.CTRLPRECIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(4, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 88
        Me.Label22.Text = "Presentación :"
        '
        'btnBusCli
        '
        Me.btnBusCli.ImageIndex = 5
        Me.btnBusCli.ImageList = Me.ImageList1
        Me.btnBusCli.Location = New System.Drawing.Point(268, 51)
        Me.btnBusCli.Name = "btnBusCli"
        Me.btnBusCli.Size = New System.Drawing.Size(33, 23)
        Me.btnBusCli.TabIndex = 148
        Me.btnBusCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Cod. Cliente :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "N° Doc :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 146
        Me.Label5.Text = "R.U.C : "
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 147
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(228, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 17)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label20.Location = New System.Drawing.Point(836, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 178
        Me.Label20.Text = "Tipo Precio :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label9.Location = New System.Drawing.Point(582, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Fecha Documento :  "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpfechadoc
        '
        Me.dtpfechadoc.Enabled = False
        Me.dtpfechadoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechadoc.Location = New System.Drawing.Point(688, 48)
        Me.dtpfechadoc.Name = "dtpfechadoc"
        Me.dtpfechadoc.Size = New System.Drawing.Size(90, 20)
        Me.dtpfechadoc.TabIndex = 157
        '
        'lbltipodoc
        '
        Me.lbltipodoc.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipodoc.Location = New System.Drawing.Point(366, 14)
        Me.lbltipodoc.Name = "lbltipodoc"
        Me.lbltipodoc.Size = New System.Drawing.Size(307, 31)
        Me.lbltipodoc.TabIndex = 155
        Me.lbltipodoc.Text = "BOLETA"
        Me.lbltipodoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLSIMBOLOCAMBIO
        '
        Me.LBLSIMBOLOCAMBIO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLOCAMBIO.Location = New System.Drawing.Point(692, 6)
        Me.LBLSIMBOLOCAMBIO.Name = "LBLSIMBOLOCAMBIO"
        Me.LBLSIMBOLOCAMBIO.Size = New System.Drawing.Size(17, 20)
        Me.LBLSIMBOLOCAMBIO.TabIndex = 168
        Me.LBLSIMBOLOCAMBIO.Text = "$"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnConsultar)
        Me.GroupBox4.Controls.Add(Me.btnsalir)
        Me.GroupBox4.Controls.Add(Me.btncancelar)
        Me.GroupBox4.Controls.Add(Me.btngeneranuevo)
        Me.GroupBox4.Controls.Add(Me.btnreimprimir)
        Me.GroupBox4.Controls.Add(Me.btnanular)
        Me.GroupBox4.Controls.Add(Me.btndsctototal)
        Me.GroupBox4.Controls.Add(Me.btndsctoitem)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.btnvale)
        Me.GroupBox4.Controls.Add(Me.btncredito)
        Me.GroupBox4.Controls.Add(Me.btncheque)
        Me.GroupBox4.Controls.Add(Me.btntarjeta)
        Me.GroupBox4.Controls.Add(Me.btnefectivo)
        Me.GroupBox4.Location = New System.Drawing.Point(760, 218)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(122, 168)
        Me.GroupBox4.TabIndex = 166
        Me.GroupBox4.TabStop = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(136, 304)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(102, 26)
        Me.BtnConsultar.TabIndex = 71
        Me.BtnConsultar.Text = "&Consultar"
        Me.BtnConsultar.Visible = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(8, 122)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(102, 26)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "&Salir"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(134, 96)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(102, 26)
        Me.btncancelar.TabIndex = 11
        Me.btncancelar.Text = "&Cancelar "
        Me.btncancelar.Visible = False
        '
        'btngeneranuevo
        '
        Me.btngeneranuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngeneranuevo.Location = New System.Drawing.Point(8, 92)
        Me.btngeneranuevo.Name = "btngeneranuevo"
        Me.btngeneranuevo.Size = New System.Drawing.Size(102, 26)
        Me.btngeneranuevo.TabIndex = 10
        Me.btngeneranuevo.Text = "G&enera Nuevo"
        '
        'btnreimprimir
        '
        Me.btnreimprimir.Location = New System.Drawing.Point(136, 272)
        Me.btnreimprimir.Name = "btnreimprimir"
        Me.btnreimprimir.Size = New System.Drawing.Size(102, 26)
        Me.btnreimprimir.TabIndex = 9
        Me.btnreimprimir.Text = "&Reimprimir"
        Me.btnreimprimir.Visible = False
        '
        'btnanular
        '
        Me.btnanular.Location = New System.Drawing.Point(136, 248)
        Me.btnanular.Name = "btnanular"
        Me.btnanular.Size = New System.Drawing.Size(102, 26)
        Me.btnanular.TabIndex = 8
        Me.btnanular.Text = "&Anular"
        Me.btnanular.Visible = False
        '
        'btndsctototal
        '
        Me.btndsctototal.Location = New System.Drawing.Point(136, 216)
        Me.btndsctototal.Name = "btndsctototal"
        Me.btndsctototal.Size = New System.Drawing.Size(102, 26)
        Me.btndsctototal.TabIndex = 7
        Me.btndsctototal.Text = "Dscto al &Total"
        Me.btndsctototal.Visible = False
        '
        'btndsctoitem
        '
        Me.btndsctoitem.Location = New System.Drawing.Point(136, 192)
        Me.btndsctoitem.Name = "btndsctoitem"
        Me.btndsctoitem.Size = New System.Drawing.Size(102, 26)
        Me.btndsctoitem.TabIndex = 6
        Me.btndsctoitem.Text = "Dscto x &Item"
        Me.btndsctoitem.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(132, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 35)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "Editar Numero (F12)"
        '
        'btnvale
        '
        Me.btnvale.Location = New System.Drawing.Point(132, 122)
        Me.btnvale.Name = "btnvale"
        Me.btnvale.Size = New System.Drawing.Size(102, 26)
        Me.btnvale.TabIndex = 69
        Me.btnvale.Text = "  Vale      (F11)"
        '
        'btncredito
        '
        Me.btncredito.Location = New System.Drawing.Point(9, 42)
        Me.btncredito.Name = "btncredito"
        Me.btncredito.Size = New System.Drawing.Size(102, 26)
        Me.btncredito.TabIndex = 2
        Me.btncredito.Text = "Credito    (F10)"
        '
        'btncheque
        '
        Me.btncheque.Location = New System.Drawing.Point(134, 70)
        Me.btncheque.Name = "btncheque"
        Me.btncheque.Size = New System.Drawing.Size(102, 26)
        Me.btncheque.TabIndex = 3
        Me.btncheque.Text = "Cheque   (F9)"
        '
        'btntarjeta
        '
        Me.btntarjeta.Location = New System.Drawing.Point(134, 44)
        Me.btntarjeta.Name = "btntarjeta"
        Me.btntarjeta.Size = New System.Drawing.Size(102, 26)
        Me.btntarjeta.TabIndex = 1
        Me.btntarjeta.Text = "Tarjeta  (F8)"
        '
        'btnefectivo
        '
        Me.btnefectivo.Location = New System.Drawing.Point(9, 16)
        Me.btnefectivo.Name = "btnefectivo"
        Me.btnefectivo.Size = New System.Drawing.Size(102, 26)
        Me.btnefectivo.TabIndex = 0
        Me.btnefectivo.Text = "Efectivo (F7)"
        '
        'cbTipoPrecio
        '
        Me.cbTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPrecio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoPrecio.Location = New System.Drawing.Point(907, 76)
        Me.cbTipoPrecio.Name = "cbTipoPrecio"
        Me.cbTipoPrecio.Size = New System.Drawing.Size(170, 22)
        Me.cbTipoPrecio.TabIndex = 179
        Me.cbTipoPrecio.Visible = False
        '
        'cbovendedor
        '
        Me.cbovendedor.BackColor = System.Drawing.Color.White
        Me.cbovendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovendedor.Enabled = False
        Me.cbovendedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovendedor.Location = New System.Drawing.Point(654, 98)
        Me.cbovendedor.Name = "cbovendedor"
        Me.cbovendedor.Size = New System.Drawing.Size(170, 22)
        Me.cbovendedor.TabIndex = 162
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtpercp)
        Me.GroupBox3.Controls.Add(Me.TxtTOTAL)
        Me.GroupBox3.Controls.Add(Me.TxtDESC)
        Me.GroupBox3.Controls.Add(Me.TxtSUBTOTAL)
        Me.GroupBox3.Controls.Add(Me.TxtIGV)
        Me.GroupBox3.Controls.Add(Me.LBLSIMBOLO2)
        Me.GroupBox3.Controls.Add(Me.LBLSIMBOLO4)
        Me.GroupBox3.Controls.Add(Me.lblsimbolo)
        Me.GroupBox3.Controls.Add(Me.lblsubtotal)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.LBLIGV)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 454)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(929, 50)
        Me.GroupBox3.TabIndex = 167
        Me.GroupBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.AllowDrop = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(571, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 22)
        Me.Label18.TabIndex = 185
        Me.Label18.Text = "IPERCEP  "
        '
        'txtpercp
        '
        Me.txtpercp.BackColor = System.Drawing.Color.White
        Me.txtpercp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpercp.Location = New System.Drawing.Point(621, 14)
        Me.txtpercp.Name = "txtpercp"
        Me.txtpercp.Size = New System.Drawing.Size(95, 26)
        Me.txtpercp.TabIndex = 184
        Me.txtpercp.Text = "0.00"
        Me.txtpercp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTOTAL
        '
        Me.TxtTOTAL.BackColor = System.Drawing.Color.White
        Me.TxtTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTOTAL.Location = New System.Drawing.Point(817, 14)
        Me.TxtTOTAL.Name = "TxtTOTAL"
        Me.TxtTOTAL.Size = New System.Drawing.Size(95, 26)
        Me.TxtTOTAL.TabIndex = 72
        Me.TxtTOTAL.Text = "0.00"
        Me.TxtTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDESC
        '
        Me.TxtDESC.BackColor = System.Drawing.Color.White
        Me.TxtDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDESC.Location = New System.Drawing.Point(469, 14)
        Me.TxtDESC.Name = "TxtDESC"
        Me.TxtDESC.Size = New System.Drawing.Size(95, 26)
        Me.TxtDESC.TabIndex = 71
        Me.TxtDESC.Text = "0.00"
        Me.TxtDESC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSUBTOTAL
        '
        Me.TxtSUBTOTAL.BackColor = System.Drawing.Color.White
        Me.TxtSUBTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSUBTOTAL.Location = New System.Drawing.Point(135, 14)
        Me.TxtSUBTOTAL.Name = "TxtSUBTOTAL"
        Me.TxtSUBTOTAL.Size = New System.Drawing.Size(95, 26)
        Me.TxtSUBTOTAL.TabIndex = 70
        Me.TxtSUBTOTAL.Text = "0.00"
        Me.TxtSUBTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIGV
        '
        Me.TxtIGV.BackColor = System.Drawing.Color.White
        Me.TxtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIGV.Location = New System.Drawing.Point(300, 14)
        Me.TxtIGV.Name = "TxtIGV"
        Me.TxtIGV.Size = New System.Drawing.Size(95, 26)
        Me.TxtIGV.TabIndex = 69
        Me.TxtIGV.Text = "0.00"
        Me.TxtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLSIMBOLO2
        '
        Me.LBLSIMBOLO2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO2.Location = New System.Drawing.Point(274, 17)
        Me.LBLSIMBOLO2.Name = "LBLSIMBOLO2"
        Me.LBLSIMBOLO2.Size = New System.Drawing.Size(32, 21)
        Me.LBLSIMBOLO2.TabIndex = 66
        Me.LBLSIMBOLO2.Text = "S/."
        '
        'LBLSIMBOLO4
        '
        Me.LBLSIMBOLO4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO4.Location = New System.Drawing.Point(789, 18)
        Me.LBLSIMBOLO4.Name = "LBLSIMBOLO4"
        Me.LBLSIMBOLO4.Size = New System.Drawing.Size(31, 19)
        Me.LBLSIMBOLO4.TabIndex = 68
        Me.LBLSIMBOLO4.Text = "S/."
        '
        'lblsimbolo
        '
        Me.lblsimbolo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsimbolo.Location = New System.Drawing.Point(111, 17)
        Me.lblsimbolo.Name = "lblsimbolo"
        Me.lblsimbolo.Size = New System.Drawing.Size(32, 21)
        Me.lblsimbolo.TabIndex = 65
        Me.lblsimbolo.Text = "S/."
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(8, 17)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(119, 21)
        Me.lblsubtotal.TabIndex = 0
        Me.lblsubtotal.Text = "SUB TOTAL."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(397, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 19)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "DESC % "
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(722, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 19)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "TOTAL"
        '
        'LBLIGV
        '
        Me.LBLIGV.AllowDrop = True
        Me.LBLIGV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIGV.Location = New System.Drawing.Point(236, 16)
        Me.LBLIGV.Name = "LBLIGV"
        Me.LBLIGV.Size = New System.Drawing.Size(51, 22)
        Me.LBLIGV.TabIndex = 2
        Me.LBLIGV.Text = "IGV  "
        '
        'lblcambio
        '
        Me.lblcambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcambio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio.Location = New System.Drawing.Point(708, 6)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(52, 15)
        Me.lblcambio.TabIndex = 165
        Me.lblcambio.Text = "3.45"
        Me.lblcambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(640, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 15)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "T.C. : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHora
        '
        Me.LblHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHora.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(764, 6)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(115, 15)
        Me.LblHora.TabIndex = 163
        Me.LblHora.Text = "03:42:58 P.M."
        Me.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbloperador
        '
        Me.lbloperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbloperador.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloperador.Location = New System.Drawing.Point(186, 5)
        Me.lbloperador.Name = "lbloperador"
        Me.lbloperador.Size = New System.Drawing.Size(135, 19)
        Me.lbloperador.TabIndex = 160
        Me.lbloperador.Text = "CodUsuario PTOVENTA"
        Me.lbloperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbloperador.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltotalletras)
        Me.GroupBox2.Controls.Add(Me.Grid1)
        Me.GroupBox2.Controls.Add(Me.CRTDOC)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 250)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        '
        'lbltotalletras
        '
        Me.lbltotalletras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalletras.ForeColor = System.Drawing.Color.Blue
        Me.lbltotalletras.Location = New System.Drawing.Point(8, 224)
        Me.lbltotalletras.Name = "lbltotalletras"
        Me.lbltotalletras.Size = New System.Drawing.Size(728, 17)
        Me.lbltotalletras.TabIndex = 62
        Me.lbltotalletras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.White
        Me.Grid1.CaptionBackColor = System.Drawing.Color.Silver
        Me.Grid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.CaptionForeColor = System.Drawing.Color.Black
        Me.Grid1.CaptionText = "Ayuda Articulos [F2],Eliminar Item [F3]"
        Me.Grid1.DataMember = ""
        Me.Grid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(8, 8)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(730, 216)
        Me.Grid1.TabIndex = 48
        '
        'CRTDOC
        '
        Me.CRTDOC.Enabled = True
        Me.CRTDOC.Location = New System.Drawing.Point(124, 82)
        Me.CRTDOC.Name = "CRTDOC"
        Me.CRTDOC.OcxState = CType(resources.GetObject("CRTDOC.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CRTDOC.Size = New System.Drawing.Size(28, 28)
        Me.CRTDOC.TabIndex = 72
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BtnBuscar.ImageIndex = 5
        Me.BtnBuscar.ImageList = Me.ImageList1
        Me.BtnBuscar.Location = New System.Drawing.Point(322, 27)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(35, 23)
        Me.BtnBuscar.TabIndex = 150
        Me.BtnBuscar.Visible = False
        '
        'TXTNUMERODOC
        '
        Me.TXTNUMERODOC.BackColor = System.Drawing.Color.White
        Me.TXTNUMERODOC.Enabled = False
        Me.TXTNUMERODOC.Location = New System.Drawing.Point(242, 28)
        Me.TXTNUMERODOC.MaxLength = 7
        Me.TXTNUMERODOC.Name = "TXTNUMERODOC"
        Me.TXTNUMERODOC.Size = New System.Drawing.Size(80, 20)
        Me.TXTNUMERODOC.TabIndex = 174
        Me.TXTNUMERODOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Direccion :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Apell. o R.S. :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label14.Location = New System.Drawing.Point(588, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 161
        Me.Label14.Text = "Vendedor : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(128, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 159
        Me.Label12.Text = "Operador : "
        Me.Label12.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CboMoneda
        '
        Me.CboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMoneda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMoneda.Location = New System.Drawing.Point(907, 104)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(170, 22)
        Me.CboMoneda.TabIndex = 183
        Me.CboMoneda.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label10.Location = New System.Drawing.Point(849, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 182
        Me.Label10.Text = "Moneda : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'gbtipodoc
        '
        Me.gbtipodoc.Controls.Add(Me.rbboleta)
        Me.gbtipodoc.Controls.Add(Me.rbfactura)
        Me.gbtipodoc.Controls.Add(Me.rbnotap)
        Me.gbtipodoc.Location = New System.Drawing.Point(613, 126)
        Me.gbtipodoc.Name = "gbtipodoc"
        Me.gbtipodoc.Size = New System.Drawing.Size(190, 80)
        Me.gbtipodoc.TabIndex = 184
        Me.gbtipodoc.TabStop = False
        Me.gbtipodoc.Text = "Tipo Documento :"
        Me.gbtipodoc.Visible = False
        '
        'rbboleta
        '
        Me.rbboleta.Checked = True
        Me.rbboleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbboleta.Location = New System.Drawing.Point(16, 16)
        Me.rbboleta.Name = "rbboleta"
        Me.rbboleta.Size = New System.Drawing.Size(104, 24)
        Me.rbboleta.TabIndex = 0
        Me.rbboleta.TabStop = True
        Me.rbboleta.Text = "Boleta"
        '
        'rbfactura
        '
        Me.rbfactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbfactura.Location = New System.Drawing.Point(16, 38)
        Me.rbfactura.Name = "rbfactura"
        Me.rbfactura.Size = New System.Drawing.Size(104, 24)
        Me.rbfactura.TabIndex = 1
        Me.rbfactura.Text = "Factura"
        '
        'rbnotap
        '
        Me.rbnotap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnotap.Location = New System.Drawing.Point(16, 60)
        Me.rbnotap.Name = "rbnotap"
        Me.rbnotap.Size = New System.Drawing.Size(104, 24)
        Me.rbnotap.TabIndex = 2
        Me.rbnotap.Text = "Nota Pedido"
        '
        'FrmActualizarFact
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1123, 598)
        Me.Controls.Add(Me.gbtipodoc)
        Me.Controls.Add(Me.TXTSERIEDOC)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.txtcodclie)
        Me.Controls.Add(Me.txtruc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTNUMERODOC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CboPagador)
        Me.Controls.Add(Me.CHKIGV)
        Me.Controls.Add(Me.btnBusCli)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpfechadoc)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cbovendedor)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblcambio)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.lbloperador)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.lbltipodoc)
        Me.Controls.Add(Me.LBLSIMBOLOCAMBIO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbTipoPrecio)
        Me.Controls.Add(Me.CboMoneda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmActualizarFact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ActualizarFact"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRTDOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbtipodoc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "Funciones de Form"
    Private Sub ConfigDocumento()
        Dim Doc() As String
        Doc = CStr(Format(VNroDoc, "0##-#######")).Split("-")
        TXTSERIEDOC.Text = Doc.GetValue(0)
        TXTNUMERODOC.Text = Doc.GetValue(1)

        If VCdTipoDoc = CDBOLETA Then
            lbltipodoc.Text = "BOLETA"
            TxtIGV.Visible = False
            TxtSUBTOTAL.Visible = False
            lblsubtotal.Visible = False
            LBLIGV.Visible = False
            lblsimbolo.Visible = False
            LBLSIMBOLO2.Visible = False
            VItemDoc = ITEMDEBOLETA

        ElseIf VCdTipoDoc = CDFACTURA Then
            lbltipodoc.Text = "FACTURA"
            TxtIGV.Visible = True
            TxtSUBTOTAL.Visible = True
            lblsubtotal.Visible = True
            LBLIGV.Visible = True
            lblsimbolo.Visible = True
            LBLSIMBOLO2.Visible = True
            VItemDoc = ITEMDEFACT

        ElseIf VCdTipoDoc = CDNTAPEDIDO Then
            lbltipodoc.Text = "NOTA DE PEDIDO"
            TxtIGV.Visible = False
            TxtSUBTOTAL.Visible = False
            lblsubtotal.Visible = False
            LBLIGV.Visible = False
            lblsimbolo.Visible = False
            LBLSIMBOLO2.Visible = False
            VItemDoc = ITEMDENOTACRED
            VUsarNotaPedido = True
        End If

        If FACT_EDITPRECIO = True Then
            CTRLPRECIO.Enabled = True
        Else
            CTRLPRECIO.Enabled = False
        End If
    End Sub




    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function





    Private Sub INSERT_TMP_DETALLE()
        If CTRLCANTIDAD.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR LA CANTIDAD...", MsgBoxStyle.Exclamation, "")
            CTRLCANTIDAD.Focus()
            Exit Sub
        End If
        If CDbl(CTRLCANTIDAD.Text) = 0 Then
            MsgBox("LA CANTIDAD NO PUEDE SER CERO...", MsgBoxStyle.Exclamation, "")
            CTRLCANTIDAD.Focus()
            Exit Sub
        End If
        If CTRLPRECIO.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL PRECIO...", MsgBoxStyle.Exclamation, "")
            CTRLPRECIO.Focus()
            Exit Sub
        End If
        If CDbl(CTRLPRECIO.Text) = 0 Then
            MsgBox("EL PRECIO NO PUEDE SER CERO...", MsgBoxStyle.Exclamation, "")
            CTRLPRECIO.Focus()
            Exit Sub
        End If

        Dim Item As Integer = TMP_VENTADET.Rows.Count + 1
        If VItemDoc < Item Then
            MsgBox("EL NUMERO DE FILAS ESCEDE AL NUMERO ESTABLECIDO EN  CONFIG..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        'If CAyuda.Ejecutar("TMP_VENTADETInsProcJ", codempresa, VCorrelVta, txtcodarticulo.Text, CboMoneda.SelectedValue, CDZONA, "", txtdescripcion.Text, CTRLCANTIDAD.Text, CTRLPRECIO.Text, CTRLPRECIO.Text, dtpfechadoc.Value, Format(CDate(dtpfechadoc.Value), "dd/MM/yyyy"), CodUsuario, False, VCambioVta, False, False, 0, 0, "", cbPresentacion.SelectedValue, cbPresentacion.Text, CODALMACEN) > 0 Then

        'End If

        If TIPODESC = False Then
            If TIPOPAGO = "01" Then
                If Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADET4", codempresa, txtcodarticulo.Text, cbPresentacion.SelectedValue, cbPresentacion.Text, CTRLCANTIDAD.Text, CDbl(CTRLPRECIO.Text), CDbl(CTRLPRECIO.Text), VDescTotbas, CodUsuario, NROPTOVTA, VCorrelVta, NROGUIA, TIPOPRE, CDZONA, CHECKPROMO, CODALMACENX, dtpfechadoc.Value, txtcodclie.Text.ToString()) Then
                    CargarGridFact()
                    FormatoGridDetVta()
                    LimpiarCjaTxtDet()
                    txtcodarticulo.Focus()
                End If
            End If

            If TIPOPAGO = "06" Then
                If Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADET3", codempresa, txtcodarticulo.Text, cbPresentacion.SelectedValue, cbPresentacion.Text, CTRLCANTIDAD.Text, CDbl(CTRLPRECIO.Text), CDbl(CTRLPRECIO.Text), VDescTotbas, CodUsuario, NROPTOVTA, VCorrelVta, NROGUIA, TIPOPRE, CDZONA, CHECKPROMO, CODALMACENX, dtpfechadoc.Value, txtcodclie.Text.ToString()) Then
                    CargarGridFact()
                    FormatoGridDetVta()
                    LimpiarCjaTxtDet()
                    txtcodarticulo.Focus()
                End If
            End If
        Else
            If Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADET3", codempresa, txtcodarticulo.Text, cbPresentacion.SelectedValue, cbPresentacion.Text, CTRLCANTIDAD.Text, CDbl(CTRLPRECIO.Text), CDbl(CTRLPRECIO.Text), VDescTotbas, CodUsuario, NROPTOVTA, VCorrelVta, NROGUIA, TIPOPRE, CDZONA, CHECKPROMO, CODALMACENX, dtpfechadoc.Value) Then
                CargarGridFact()
                FormatoGridDetVta()
                LimpiarCjaTxtDet()
                txtcodarticulo.Focus()
            End If

        End If

    End Sub
    Private Sub IniciarDatos()
        lblcambio.Text = FormatoMonto(CDbl(VCambioVta), DECIRESU)

        CAyuda.CargarDataCombo(CboMoneda, "ProLisMon  '" & codempresa & "'", "codmon", "dsmoneda")
        CAyuda.CargarDataCombo(CboPagador, "SP_LISTAR_CLIENTE_DEPMAEST   '" & codempresa & "','1'", "CODCLIENTE", "DATOADJUNTO")
        CAyuda.CargarDataCombo(cbovendedor, "SP_ListVendedor  '" & codempresa & "'", "CODVEND", "DSVEND")
        cbovendedor.SelectedValue = CodUsuario
        CboMoneda.SelectedValue = CDMONBASE

    End Sub
    Private Sub CargarGridFact()
        TMP_VENTADET = TmpListarDatos("sp_sele_TMP_VENTADET  '" & VCorrelVta & "','" & codempresa & "'")
        Grid1.DataSource = TMP_VENTADET
        If TMP_VENTADET.Rows.Count > 0 Then
            CODALMACEN = TMP_VENTADET.Rows(0)("CODALMACEN").ToString
            Dim TABLE_VTA As New DataTable
            TABLE_VTA = TmpListarDatos("OBTIENE_TOTALES_FACTURACION_PROC  '" & codempresa & "','" & VCorrelVta & "'")
            TxtTOTAL.Text = FormatoMonto(TABLE_VTA.Rows(0)("TOTBAS"), DECIRESU)
            TxtSUBTOTAL.Text = FormatoMonto(TABLE_VTA.Rows(0)("SUBTOTBAS"), DECIRESU)
            TxtIGV.Text = FormatoMonto(TABLE_VTA.Rows(0)("IGVBAS"), DECIRESU)

            Dim TABLE_VERIPER As New DataTable
            TABLE_VERIPER = TmpListarDatos("SP_VERIFIC_PERCEP2  '" & codempresa & "','" & VCdTipoDoc & "'")

            If TABLE_VERIPER.Rows.Count > 0 Then
                If CInt(TABLE_VERIPER.Rows(0)(0)) = -1 Then
                    Dim precepclien As Double
                    Dim TABLE_VTA3 As New DataTable
                    TABLE_VTA3 = TmpListarDatos("SP_BUSQ_PERCECLIDEP  '" & codempresa & "','" & txtcodclie.Text & "'")
                    precepclien = FormatoMonto(TABLE_VTA3.Rows(0)(0), DECIRESU)


                    If VCdTipoDoc = "03" Then
                        Dim TABLE_VTA2 As New DataTable
                        TABLE_VTA2 = TmpListarDatos("SP_MONTOPERCEPCIONB  '" & codempresa & "','" & VCorrelVta & "'," & precepclien)
                        txtpercp.Text = FormatoMonto(TABLE_VTA2.Rows(0)(0), DECIRESU)
                        TxtTOTAL.Text = FormatoMonto(TABLE_VTA2.Rows(0)(1), DECIRESU)
                    End If

                    If VCdTipoDoc = "01" Then
                        Dim TABLE_VTA2 As New DataTable
                        TABLE_VTA2 = TmpListarDatos("SP_MONTOPERCEPCIONF  '" & codempresa & "','" & VCorrelVta & "'," & precepclien)
                        txtpercp.Text = FormatoMonto(TABLE_VTA2.Rows(0)(0), DECIRESU)
                        TxtTOTAL.Text = FormatoMonto(TABLE_VTA2.Rows(0)(1), DECIRESU)
                    End If




                End If
            End If






        End If

    End Sub
    Private Sub FormatoGridDetVta()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_VENTADET.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "ITEM"
            .HeaderText = "ITEM"
            .NullText = ""
            .Width = 35
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CODIGO"
            .HeaderText = "CODIGO"
            .NullText = ""
            .Width = 75
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DESCRIPCION"
            .HeaderText = "DESCRIPCION"
            .NullText = ""
            .Width = 250
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "DESPRES"
            .HeaderText = "PRESENTACION"
            .NullText = ""
            .Width = 120
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "CANTIDAD"
            .HeaderText = "CANTIDAD"
            .NullText = ""
            .Format = GMascaraDec(DECICANT)
            .Width = 60
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "PRECIO"
            .HeaderText = "PRECIO"
            .NullText = ""
            .Format = GMascaraDec(DECIPREC)
            .Width = 60
        End With

        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "TOTAL"
            .HeaderText = "TOTAL"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Width = 60
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "DESCTO"
            .HeaderText = "DESCTO"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Width = 60
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        Grid1.TableStyles.Clear()
        Grid1.TableStyles.Add(TableStyle1)

    End Sub
    Private Sub LimpiarCjaTxtDet()
        txtcodarticulo.Text = ""
        txtdescripcion.Text = ""
        CTRLCANTIDAD.Text = "0"
        CTRLPRECIO.Text = "0"

    End Sub
    Private Sub BuscarDocumento()

        'Dim FrmBDoc As New FrmConsultarFacturac2
        'FrmBDoc.ShowDialog()
        'If FrmBDoc.DEVOLVER = False Then
        '    Exit Sub
        'End If
        'VCdTipoDoc = Trim(FrmBDoc.DtgDoc.Item(FrmBDoc.DtgDoc.CurrentRowIndex, 0).ToString())
        'VNroDoc = Trim(FrmBDoc.DtgDoc.Item(FrmBDoc.DtgDoc.CurrentRowIndex, 2).ToString())
        ' ConfigDocumento()


        Dim MesAct, Anio As String
        MesAct = Format(FECHA, "MM")
        Anio = Format(FECHA, "yyyy")

        VentaC = "VENTC" & Anio & MesAct
        VentD = "VENTD" & Anio & MesAct

        Dim CODVENDEDOR As String
        Dim TABCAB As New DataTable


        If FACTPTOVTA = True Then


            TABCAB = TmpListarDatos("VENTACABSelProc  '" & codempresa & "', '" & VCdTipoDoc & "','" & VNroDoc & "','" & VentaC & "' ")

            If TABCAB.Rows.Count > 0 Then
                txtcodclie.Text = TABCAB.Rows(0)("CODCLIENTE")
                txtcliente.Text = TABCAB.Rows(0)("DESCLIENTE")
                txtruc.Text = TABCAB.Rows(0)("RUCCLIENTE")
                VRuc = TABCAB.Rows(0)("RUCCLIENTE")
                txtdireccion.Text = TABCAB.Rows(0)("DIRCLIENTE")
                VCodDep = TABCAB.Rows(0)("CODDEP")

                CODVENDEDOR = TABCAB.Rows(0)("CODVEND")
                CboPagador.SelectedValue = VCodDep
                cbovendedor.SelectedValue = CODVENDEDOR
                dtpfechadoc.Value = CDate(TABCAB.Rows(0)("FECDOCUM"))

            End If

        End If


        If FACTLINEA = True Then

            TABCAB = TmpListarDatos("VENTACABSelProcXLinea  '" & codempresa & "', '" & VCdTipoDoc & "','" & VNroDoc & "','" & VentaC & "' ")

            If TABCAB.Rows.Count > 0 Then
                txtcodclie.Text = TABCAB.Rows(0)("CODCLIENTE")
                txtcliente.Text = TABCAB.Rows(0)("DESCLIENTE")
                txtruc.Text = TABCAB.Rows(0)("RUCCLIENTE")
                VRuc = TABCAB.Rows(0)("RUCCLIENTE")
                txtdireccion.Text = TABCAB.Rows(0)("DIRCLIENTE")
                VCodDep = TABCAB.Rows(0)("CODDEP")

                CODVENDEDOR = TABCAB.Rows(0)("CODVEND")
                CboPagador.SelectedValue = VCodDep
                cbovendedor.SelectedValue = CODVENDEDOR
                dtpfechadoc.Value = CDate(TABCAB.Rows(0)("FECDOCUM"))
                CodLinea = TABCAB.Rows(0)("CODLINEA")
            End If

        End If


        If FACTSUBEMP = True Then

            TABCAB = TmpListarDatos("VENTACABSelProcXSubEmpresa  '" & codempresa & "', '" & VCdTipoDoc & "','" & VNroDoc & "','" & VentaC & "' ")

            If TABCAB.Rows.Count > 0 Then
                txtcodclie.Text = TABCAB.Rows(0)("CODCLIENTE")
                txtcliente.Text = TABCAB.Rows(0)("DESCLIENTE")
                txtruc.Text = TABCAB.Rows(0)("RUCCLIENTE")
                VRuc = TABCAB.Rows(0)("RUCCLIENTE")
                txtdireccion.Text = TABCAB.Rows(0)("DIRCLIENTE")
                VCodDep = TABCAB.Rows(0)("CODDEP")

                CODVENDEDOR = TABCAB.Rows(0)("CODVEND")
                CboPagador.SelectedValue = VCodDep
                cbovendedor.SelectedValue = CODVENDEDOR
                dtpfechadoc.Value = CDate(TABCAB.Rows(0)("FECDOCUM"))
                CodSubEmpresa = TABCAB.Rows(0)("Id")
                CodSupervisor = TABCAB.Rows(0)("CODSUPERVISOR")


            End If
        End If


        VNroDoc_ant = VNroDoc
        VCdTipoDoc_ant = VCdTipoDoc

        TmpListarDatos("CARGADETALLE_PARA_NUEVOTICKET_PROC  '" & codempresa & "','" & VCorrelVta & "','" & VCdTipoDoc & "' , '" & VNroDoc & "' ,'" & VentD & "'")



        CargarGridFact()
        FormatoGridDetVta()

        ConfigDocumento()


        Supervisor = False
        'VERIFICAR SI REALMENTE EL DOCUMENTO Q SE VA ACTUALIZAR TIENE UNA SERIE DE SUPERVISOR
        If FACTSUBEMP = True Then
            Dim TABSERIESUPERV As New DataTable
            TABSERIESUPERV = TmpListarDatos("SP_SERIE_SUPERVISOR  '" & VCdTipoDoc & "','" & CodSupervisor & "'")
            Dim VNroDocSuperv As Double
            If TABSERIESUPERV.Rows.Count > 0 Then
                For x As Integer = 0 To TABSERIESUPERV.Rows.Count - 1

                    VNroDocSuperv = TABSERIESUPERV.Rows(x)("NRODOC")
                    Dim NroDocSuperv() As String
                    Dim SerieDocSuperv As String
                    NroDocSuperv = CStr(Format(VNroDocSuperv, "0##-#######")).Split("-")
                    SerieDocSuperv = NroDocSuperv.GetValue(0)
                    If TXTSERIEDOC.Text = SerieDocSuperv Then
                        Supervisor = True
                        Exit For
                    Else
                        Supervisor = False
                    End If

                Next
            Else
                Supervisor = False
            End If

        End If

    End Sub



    Private Function VERIFICA_HISTORICOVENT(ByVal StrHistorico As String) As Boolean
        Try
            Dim StrSql As String
            Dim rs As New DataTable
            StrSql = " EXEC   VERIFICA_HISTORICOVENT    '" & StrHistorico & "','" & codempresa & "'"
            rs = TmpListarDatos(StrSql)

            If rs.Rows.Count = 0 Then
                VERIFICA_HISTORICOVENT = False
            Else
                VERIFICA_HISTORICOVENT = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " VERIFICA_HISTORICOVENT")
        End Try

    End Function



    Private Sub HabilitarCtrl(ByVal valor As Boolean, ByVal Control As Control)
        Dim obj As Object
        For Each obj In Control.Controls
            If TypeOf obj Is TextBox Then
                obj.enabled = valor
            End If
        Next
        Grid1.Enabled = valor

    End Sub
    Private Sub elimina_item()
        Try
            Dim sql As String
            sql = "SP_DELETE_ITEM_TMPVENTADET " & VCorrelVta & "," & Grid1.Item(Grid1.CurrentRowIndex, 0) & ",'" & codempresa & "','" & NROPTOVTA & "'"


            TmpInsertDatos(sql)
            CargarGridFact()
            FormatoGridDetVta()
            LimpiarCjaTxtDet()
            txtcodarticulo.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean

        Const WD_SYSTEM As Integer = &H100
        Const WD_KEYDOWN As Integer = &H104
        If ((MSG.Msg = WD_SYSTEM) Or (MSG.Msg = WD_KEYDOWN)) Then
            Select Case KeyData
                Case Keys.F3
                    If Grid1.Focus = True Then
                        If TMP_VENTADET.Rows.Count > 0 Then
                            elimina_item()
                        End If
                    End If
            End Select


        End If




    End Function
#End Region

#Region "Variables del Form "
    Private TMP_PRESENTACION As New DataTable
    Private ActEventCombo As Boolean
    Private TMP_VENTADET As New DataTable
    Private EstadoDoc As String
    Public DEVOLVER As Boolean

    Public CODALMACENX As String

    Dim rand As Integer
    Dim CodLinea As String
    Dim CodSubEmpresa As String
    Dim CodSupervisor As String
    Dim Supervisor As Boolean
#End Region



    Private Sub FrmActualizarFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'ValorRan()

        VUsarNotaPedido = False

        IniciarDatos()
        'GenerarNroDoc()
        'ConfigDocumento()
        BuscarDocumento()

        'ConfigDocumento()
        HabilitarCtrl(False, Me)
        HabilitarCtrl(False, GroupBox1)

        GroupBox1.Enabled = False

        ' dtpfechadoc.Value = Format(vFechaActual, "dd/MM/yyyy")

        VDescTotbas = 0

    End Sub

    Private Sub BtnBuscArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscArt.Click

        If FACTPTOVTA = True Then
            Dim FrmArt As New FrmListarArticuloFact
            FrmArt.ShowDialog()
            If FrmArt.DEVOLVER = False Then
                Exit Sub
            End If
            txtcodarticulo.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 0)
            txtdescripcion.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 1)
        End If

        If FACTLINEA = True Then
            Dim FrmArt As New FrmListarArticuloReFactxLinea
            FrmArt.codlinea = CodLinea
            FrmArt.ShowDialog()
            If FrmArt.DEVOLVER = False Then
                Exit Sub
            End If

            txtcodarticulo.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 0)
            txtdescripcion.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 1)
        End If

        If FACTSUBEMP = True Then
            Dim FrmArt As New FrmListarArticuloReFactxSubEmp
            FrmArt.codsubempresa = CodSubEmpresa
            FrmArt.ShowDialog()
            If FrmArt.DEVOLVER = False Then
                Exit Sub
            End If

            txtcodarticulo.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 0)
            txtdescripcion.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 1)
        End If




        'vcdAlmacen = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 2)
        TMP_PRESENTACION = TmpListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT  '" & codempresa & "','" & txtcodarticulo.Text & "','" & VCodTiPrecioClie & "', " & IIf(PPPUNTOVENTA = True, 1, 0) & " , " & IIf(PPFUERZVENTA = True, 1, 0) & "")
        cbPresentacion.DataSource = TMP_PRESENTACION
        cbPresentacion.ValueMember = "CODPRES"
        cbPresentacion.DisplayMember = "DESPRES"
        ActEventCombo = True
        cbPresentacion_SelectedIndexChanged(sender, e)
        cbPresentacion.Focus()

    End Sub

    Private Sub btnBusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusCli.Click
        Dim FrmCli As New FrmListarClientesFact
        FrmCli.ShowDialog()
        If FrmCli.DEVOLVER = False Then
            Exit Sub
        End If
        txtcodclie.Text = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 0)
        txtcliente.Text = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 1)
        txtdireccion.Text = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 2)
        txtruc.Text = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 3)
        VRuc = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 3)
        VClieDep = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 4)
        CboPagador.SelectedValue = VClieDep
        If txtruc.Text.Trim <> "" Then
            GenerarNroDoc_2()
            ConfigDocumento()
        End If

    End Sub

    Private Sub cbPresentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPresentacion.SelectedIndexChanged
        If TMP_PRESENTACION.Rows.Count > 0 And ActEventCombo = True Then
            Dim TBPREC As New DataTable
            TBPREC = TmpListarDatos("SP_BUSC_PRECIOARTFACT   '" & codempresa & "','" & cbPresentacion.SelectedValue & "','" & VCodTiPrecioClie & "','" & txtcodarticulo.Text & "','" & txtcodclie.Text & "'")
            VPrecio = TBPREC.Rows(0)("PRECIO")
            VPrecioVta = TBPREC.Rows(0)("PRECIOVTA")
            CTRLPRECIO.Text = FormatoMonto(VPrecioVta, DECIRESU)
        End If
    End Sub

    Private Sub CTRLPRECIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTRLPRECIO.TextChanged

    End Sub

    Private Sub CTRLPRECIO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CTRLPRECIO.KeyDown
        If e.KeyCode = Keys.Enter Then
            INSERT_TMP_DETALLE()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblHora.Text = Date.Now.ToLongTimeString

    End Sub

    Private Sub btngeneranuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngeneranuevo.Click
        GenerarNroDoc_2()
        ConfigDocumento()

        HabilitarCtrl(True, Me)
        HabilitarCtrl(True, GroupBox1)
        GroupBox1.Enabled = True

        If FACT_EDITPRECIO = True Then
            CTRLPRECIO.Enabled = True
        Else
            CTRLPRECIO.Enabled = False
        End If


        If TIPODESC = False Then
            If TIPOPAGO = "01" Then

                btncredito.Enabled = False
            End If
            If TIPOPAGO = "06" Then
                btnefectivo.Enabled = False

            End If
        End If



    End Sub



    Public Sub GenerarNroDoc_2(Optional ByVal rb As Boolean = False)
        'If rb = False Then
        If VUsarNotaPedido = True Then
            VCdTipoDoc = CDNTAPEDIDO
        Else
            If VRuc.Trim = "" Then
                VCdTipoDoc = CDBOLETA
            Else
                VCdTipoDoc = CDFACTURA
            End If
        End If
        'End If

        Dim dt As DataTable

        If FACTPTOVTA = True Then
            dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
        End If

        If FACTLINEA = True Then

            If VCdTipoDoc = "06" Then
                dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
                GoTo IR
            End If

            Dim dt_linea As DataTable
            dt_linea = TmpListarDatos("nsp_buscar_LineaCorreDoc  '" & CodLinea & "'")

            If dt_linea.Rows.Count > 0 Then
                dt = TmpListarDatos("NSP_BUSCAR_NRODOCxLinea  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "','" & CodLinea & "'")
            Else
                dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
            End If

        End If


        If FACTSUBEMP = True Then

            If (Supervisor = False) Then
                dt = TmpListarDatos("NSP_BUSCAR_NRODOCxSubEmpresa  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "','" & CodSubEmpresa & "'")

            End If

            If (Supervisor = True) Then
                dt = TmpListarDatos("NSP_BUSCAR_NRODOCxSupervisor  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "','" & CodSupervisor & "'")
            End If



            'If VCdTipoDoc = "06" Then
            '    dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
            '    GoTo IR
            'End If

            'Dim dt_linea As DataTable
            'dt_linea = TmpListarDatos("nsp_buscar_LineaCorreDoc  '" & CodLinea & "'")

            'If dt_linea.Rows.Count > 0 Then
            '    dt = TmpListarDatos("NSP_BUSCAR_NRODOCxLinea  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "','" & CodLinea & "'")
            'Else
            '    dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
            'End If

        End If




IR:
        If dt.Rows.Count > 0 Then
            VNroDoc = dt.Rows(0)(0)
        Else
            MsgBox("Falta Configurar el PtoVta...", MsgBoxStyle.Exclamation, "")
            End
        End If

    End Sub




    Public Sub GenerarNroDoc3(Optional ByVal rb As Boolean = False)


        If rb = False Then
            If VUsarNotaPedido = True Then
                VCdTipoDoc = CDNTAPEDIDO
            Else
                If VRuc = "" Then
                    VCdTipoDoc = CDBOLETA
                Else
                    VCdTipoDoc = CDFACTURA
                End If
            End If
        End If


        Dim dt As DataTable

        If FACTPTOVTA = True Then

            dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
            If dt.Rows.Count > 0 Then
                VNroDoc = dt.Rows(0)(0)
            Else
                MsgBox("Falta Configurar el PtoVta...", MsgBoxStyle.Exclamation, "")
                End
            End If
        End If



        If FACTLINEA = True Then

            If VCdTipoDoc = "06" Then
                dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
                GoTo IR
            End If

            Dim dt_linea As DataTable
            dt_linea = TmpListarDatos("nsp_buscar_LineaCorreDoc  '" & CodLinea & "'")

            If dt_linea.Rows.Count > 0 Then
                dt = TmpListarDatos("NSP_BUSCAR_NRODOCxLinea  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "','" & CodLinea & "'")
            Else
                dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
            End If

        End If


        If FACTSUBEMP = True Then


            dt = TmpListarDatos("NSP_BUSCAR_NRODOCxSubEmpresa  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "','" & CodSubEmpresa & "'")


            'If VCdTipoDoc = "06" Then
            '    dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
            '    GoTo IR
            'End If

            'Dim dt_linea As DataTable
            'dt_linea = TmpListarDatos("nsp_buscar_LineaCorreDoc  '" & CodLinea & "'")

            'If dt_linea.Rows.Count > 0 Then
            '    dt = TmpListarDatos("NSP_BUSCAR_NRODOCxLinea  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "','" & CodLinea & "'")
            'Else
            '    dt = TmpListarDatos("NSP_BUSCAR_NRODOC_2  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
            'End If

        End If




IR:
        If dt.Rows.Count > 0 Then
            VNroDoc = dt.Rows(0)(0)
        Else
            MsgBox("Falta Configurar el PtoVta...", MsgBoxStyle.Exclamation, "")
            End
        End If





    End Sub




    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()

    End Sub

    Private Sub btnefectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnefectivo.Click

        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = dtpfechadoc.Value.Year
        MES = dtpfechadoc.Value.Month

        Select Case MES
            Case 1
                DESMES = "ENERO"
            Case 2
                DESMES = "FEBRERO"
            Case 3
                DESMES = "MARZO"
            Case 4
                DESMES = "ABRIL"
            Case 5
                DESMES = "MAYO"
            Case 6
                DESMES = "JUNIO"
            Case 7
                DESMES = "JULIO"
            Case 8
                DESMES = "AGOSTO"
            Case 9
                DESMES = "SETIEMBRE"
            Case 10
                DESMES = "OCTUBRE"
            Case 11
                DESMES = "NOVIEMBRE"
            Case 12
                DESMES = "DECIEMBRE"
        End Select

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If
        '************************************************************************************************

        Dim TABLE1 As New DataTable
        TABLE1 = TmpListarDatos("NSP_BUSCAR_FACTURACION  '" & codempresa & "','" & VNroDoc & "','" & VCdTipoDoc & "','" & rand & "'")
        If TABLE1.Rows.Count > 0 Then

            Dim DOC As String = ""

            If VCdTipoDoc.Trim = "01" Then
                DOC = "Factura"
            End If

            If VCdTipoDoc.Trim = "03" Then
                DOC = "Boleta"
            End If

            If VCdTipoDoc.Trim = "06" Then
                DOC = "Nota Pedido"
            End If

            MsgBox("El Documento " & DOC & " " & VNroDoc & " ya existe")
            Exit Sub
        End If


        If Grid1.Enabled = True Then

            If FACTPTOVTA = True Then

                If CAyuda.Ejecutar("Nsp_grabadocumentoJ", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, VCdPagEfectivo, VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN) > 0 Then
                    GoTo IR
                End If

            End If

            If FACTLINEA = True Then

                If VCdTipoDoc = "06" Then
                    If CAyuda.Ejecutar("Nsp_grabadocumentoJ", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, VCdPagEfectivo, VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN) > 0 Then
                        GoTo IR2
                    End If
                End If

                Dim dt_linea As DataTable
                dt_linea = TmpListarDatos("nsp_buscar_LineaCorreDoc  '" & CodLinea & "'")

                If dt_linea.Rows.Count > 0 Then
                    If CAyuda.Ejecutar("Nsp_grabadocumentoJxLinea", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, VCdPagEfectivo, VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN, CodLinea) > 0 Then

                        Dim TABLINEA_ENVIA As New DataTable
                        TABLINEA_ENVIA = TmpListarDatos("sp_LineaCorreDoc_EnviaElect  '" & CodLinea & "'")
                        If TABLINEA_ENVIA.Rows.Count > 0 Then
                            GoTo IR
                        Else
                            GoTo IR2
                        End If

                    End If
                Else
                    If CAyuda.Ejecutar("Nsp_grabadocumentoJ", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, VCdPagEfectivo, VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN) > 0 Then
                        GoTo IR
                    End If
                End If

            End If



            If FACTSUBEMP = True Then

                If (Supervisor = False) Then
                    If CAyuda.Ejecutar("Nsp_grabadocumentoJxSubEmpresa", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, VCdPagEfectivo, VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN, CodSubEmpresa) > 0 Then

                    End If

                    Dim dt_validar_fe As DataTable
                    dt_validar_fe = TmpListarDatos("nsp_validar_ef_todo  '" & CodSubEmpresa & "'")
                    If dt_validar_fe.Rows.Count > 0 Then
                        GoTo IR
                    End If

                    dt_validar_fe = TmpListarDatos("nsp_validar_ef_soloFact  '" & CodSubEmpresa & "'")
                    If dt_validar_fe.Rows.Count > 0 Then
                        GoTo IR
                    End If

                    GoTo IR2

                End If


                If (Supervisor = True) Then
                    If CAyuda.Ejecutar("Nsp_grabadocumentoJxSupervisor", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, VCdPagEfectivo, VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN, CodSupervisor) > 0 Then

                    End If

                    GoTo IR2
                End If

            End If





                '''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''
                '''''FACTURACION ELECTRONICA ENVIO BASE''''''
                '''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''
IR:

            If EMIELECTRONIC = True Then


                Dim TipoDoc As String
                TipoDoc = VCdTipoDoc
                VRuc = txtruc.Text
                VCodCliente = txtcodclie.Text
                VNroDoc = VNroDoc


                If TipoDoc.Trim = "01" Or TipoDoc.Trim = "03" Then

                    Dim StrSql As String
                    StrSql = "SELECT TMP_VENTADET.ITEM,TMP_VENTADET.CODARTI, TMP_VENTADET.DESARTI, TMP_VENTADET.preciovta, " &
                                     "  TMP_VENTADET.CANTIDAD,  TMP_VENTADET.SUBTOTBAS, '01' AS TIPOPRE," &
                                           "  TMP_VENTADET.TOTBAS, TMP_VENTADET.IGVBAS,(TMP_VENTADET.SUBTOTBAS/TMP_VENTADET.CANTIDAD) AS PRECSINIGV," &
                                           "   TMP_VENTADET.MONTODESCBAS ,TMP_VENTADET.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC,ARTICULO.codimpuesto " &
                                     " FROM ARTICULO INNER JOIN TMP_VENTADET ON ARTICULO.CODARTI = TMP_VENTADET.CODARTI" &
                                      " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                                  "  INNER JOIN PRESENTACION ON PRESENTACION.codpres = TMP_VENTADET.CODPRES" &
                                " WHERE TMP_VENTADET.CORRNBR = " & CInt(VCorrelVta) & " ORDER BY TMP_VENTADET.ITEM "

                    Dim Tabla_Tmp As DataTable
                    Tabla_Tmp = TmpListarDatos(StrSql)

                    listaP.Clear()
                    If Tabla_Tmp.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp.Rows.Count - 1
                            Dim o As New NuevaVentaDet
                            o.CODARTI = Tabla_Tmp.Rows(x)("CODARTI")
                            o.DESARTI = Tabla_Tmp.Rows(x)("DESARTI")
                            o.CODFACELEC = Tabla_Tmp.Rows(x)("CODFACELEC")
                            o.PRECIO = Tabla_Tmp.Rows(x)("preciovta")
                            o.MONTODESCBAS = Tabla_Tmp.Rows(x)("MONTODESCBAS")
                            o.CANTIDAD = Tabla_Tmp.Rows(x)("CANTIDAD")
                            o.IGVBAS = Tabla_Tmp.Rows(x)("IGVBAS")
                            o.ITEM = Tabla_Tmp.Rows(x)("ITEM")
                            o.TIPO_IGV = IIf(Tabla_Tmp.Rows(x)("codimpuesto") = "IGV", "IGV", "INA")
                            listaP.Add(o)
                        Next
                    End If


                    StrSql = "select codarti,item ,(preciovta - (TOTBAS/CANTIDAD)) as Prod_Desct_Ddocumento from TMP_VENTADET" &
                            " WHERE  CORRNBR = " & CInt(VCorrelVta) & "  and MONTODESCBAS > 0"

                    Dim Tabla_Tmp2 As DataTable
                    Tabla_Tmp2 = TmpListarDatos(StrSql)

                    listaDesc.Clear()
                    If Tabla_Tmp2.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp2.Rows.Count - 1
                            Dim o As New DescDdocum
                            o.codarti = Tabla_Tmp2.Rows(x)("codarti")
                            o.item = Tabla_Tmp2.Rows(x)("item")
                            o.prod_desct = Tabla_Tmp2.Rows(x)("Prod_Desct_Ddocumento")
                            listaDesc.Add(o)
                        Next
                    End If





                    CAyuda.Ejecutar("SP_DELETE_TMP_VENTADET", CodUsuario, CInt(VCorrelVta))


                    Dim Table_VC3 As New DataTable
                    Table_VC3 = TmpListarDatos("SP_SELECT_VENTACAB   '" & VCdTipoDoc & "','" & VNroDoc & "'")
                    If Table_VC3.Rows.Count > 0 Then
                        PERCEP = 0
                        IGV = CDbl(Table_VC3.Rows(0)("IGVBAS").ToString())
                        SUBTOTAL = CDbl(Table_VC3.Rows(0)("SUBTOTBAS").ToString())
                        PERCEP = CDbl(Table_VC3.Rows(0)("IPERCEP").ToString())
                    End If

                    If IGV > 0 Then
                        TIPO_IGV = "SI"
                    Else
                        TIPO_IGV = "NO"
                    End If

                    Dim Table_VC2 As New DataTable
                    Table_VC2 = TmpListarDatos("SP_SELECT_EMAIL_CLIENTE   '" & VCdTipoDoc & "','" & VNroDoc & "'")
                    If Table_VC2.Rows.Count > 0 Then
                        EMAIL = Table_VC2.Rows(0)("EMAIL").ToString()
                        DNI = Table_VC2.Rows(0)("DNI").ToString()
                        If VCodCliente = "888" Then
                            DNI = "88888888"
                        End If
                    End If

                    TipoDoc = VCdTipoDoc

                    If TipoDoc.Trim = "01" Then
                        LETRADOC = "F"
                        CLIE_DOCU = CStr(VRuc.Trim)
                    End If
                    If TipoDoc.Trim = "03" Then
                        LETRADOC = "B"
                        CLIE_DOCU = DNI
                        If CLIE_DOCU.Length = 0 Then
                            CLIE_DOCU = "99999999"
                        End If
                    End If

                    Dim FormatNroDoc As String
                    FormatNroDoc = Format(VNroDoc, "0##-########")
                    Dim NUMSERIE As String
                    NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                    SERIE = LETRADOC + NUMSERIE
                    NRODOCSIN = CStr(Microsoft.VisualBasic.Right(VNroDoc, 8))
                    NRODOCFINAL = SERIE + "-" + NRODOCSIN

                    Dim dblTOTINAFECTO As Double
                    Dim TABLA_INAFECTO As New DataTable
                    TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO  '" & TipoDoc & "','" & VNroDoc & "'  ")

                    If TABLA_INAFECTO.Rows.Count > 0 Then
                        dblTOTINAFECTO = CDbl(FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString)
                    End If



                    Try

                        Dim gestordefacturacionelectronica As IGestorDeFacturacionElectronica = New GestorDeFacturacionElectronica()
                        Dim nuevohdocumento As New NuevaHdocumento

                        nuevohdocumento.codi_cab = 0
                        nuevohdocumento.esta_pod = 1
                        nuevohdocumento.codi_caja = CStr(NROPTOVTA)
                        nuevohdocumento.comp = VCdTipoDoc
                        nuevohdocumento.serie = SERIE
                        nuevohdocumento.nume = NRODOCSIN
                        nuevohdocumento.fecha = Format(CDate(dtpfechadoc.Value), "dd/MM/yyyy")
                        nuevohdocumento.codi_vend = cbovendedor.SelectedValue
                        nuevohdocumento.clie_docu = CLIE_DOCU
                        nuevohdocumento.clie_nomb = txtcliente.Text
                        nuevohdocumento.clie_dire = txtdireccion.Text
                        nuevohdocumento.clie_email = EMAIL
                        nuevohdocumento.clie_celu = ""
                        nuevohdocumento.dire_entr = ""
                        nuevohdocumento.ubig_entr = UBIGUEO
                        nuevohdocumento.mone_codi = "PEN"
                        nuevohdocumento.LLEVAigv = TIPO_IGV
                        nuevohdocumento.desc_globa = ""
                        nuevohdocumento.obse = ""
                        nuevohdocumento.guia = ""
                        nuevohdocumento.placa = ""
                        nuevohdocumento.dire_part = ""
                        nuevohdocumento.ubig_part = ""
                        nuevohdocumento.ubig_lleg = ""
                        nuevohdocumento.cod_Ubigeo = ""
                        nuevohdocumento.tipo_trans = ""
                        nuevohdocumento.peso_kg = 0.0
                        nuevohdocumento.trans_publ_ruc = ""
                        nuevohdocumento.trans_publ_razon = ""
                        nuevohdocumento.trans_priv_placa = ""
                        nuevohdocumento.trans_priv_marca = ""
                        nuevohdocumento.trans_priv_const = ""
                        nuevohdocumento.trans_priv_lice = ""
                        nuevohdocumento.codi_moti = ""
                        nuevohdocumento.motivo = ""
                        nuevohdocumento.doc_refe = ""
                        nuevohdocumento.ValorResumen = 0.0
                        nuevohdocumento.ValorHash = ""
                        nuevohdocumento.DarBaja = 0
                        nuevohdocumento.MotivoBaja = ""
                        nuevohdocumento.ProcesarBaja = 0
                        nuevohdocumento.Grabado = SUBTOTAL - dblTOTINAFECTO
                        nuevohdocumento.IGV = IGV
                        nuevohdocumento.Total = TxtTOTAL.Text
                        nuevohdocumento.dire_lleg = ""
                        nuevohdocumento.Guia_trans = ""
                        nuevohdocumento.Envio_xml = 0
                        nuevohdocumento.Clie_tipo = IIf(CStr(VRuc.Trim) <> "", 6, 1)
                        nuevohdocumento.Fact_guia = "NO"
                        nuevohdocumento.Exonerado = 0
                        nuevohdocumento.Inafecto = dblTOTINAFECTO
                        nuevohdocumento.percepcion = PERCEP
                        nuevohdocumento.Codigo_local = CODLOCAL
                        nuevohdocumento.hora = Now.ToString("HH:mm:ss")
                        nuevohdocumento.Forma_pago = "CONTADO"
                        nuevohdocumento.total_credito = 0







                        Using scope As TransactionScope = New TransactionScope()

                            Dim CODCAB As Integer
                            CODCAB = gestordefacturacionelectronica.CrearHdocumento(nuevohdocumento).codi_cab

                            For x As Integer = 0 To Me.listaP.Count - 1
                                Dim nuevoddocumento As New NuevaDDocumento
                                nuevoddocumento.id = 1
                                nuevoddocumento.prod_codi = listaP.Item(x).CODARTI.ToString
                                nuevoddocumento.prod_descr = listaP.Item(x).DESARTI.ToString
                                nuevoddocumento.prod_unid = listaP.Item(x).CODFACELEC.ToString
                                nuevoddocumento.prod_precio = listaP.Item(x).PRECIO
                                nuevoddocumento.prod_desct = listaP.Item(x).MONTODESCBAS
                                nuevoddocumento.prod_cant = listaP.Item(x).CANTIDAD

                                For d As Integer = 0 To Me.listaDesc.Count - 1
                                    If listaP.Item(x).CODARTI.ToString = listaDesc.Item(d).codarti.ToString Then
                                        If CInt(listaP.Item(x).ITEM) = CInt(listaDesc.Item(d).item) Then
                                            nuevoddocumento.prod_desct = listaDesc.Item(d).prod_desct.ToString
                                            Exit For
                                        End If
                                    End If
                                Next

                                If listaP.Item(x).PRECIO.ToString() = "0.0100" Then
                                    If listaP.Item(x).TIPO_IGV = "IGV" Then
                                        nuevoddocumento.igv = Math.Round((1.18 - 1) * (listaP.Item(x).CANTIDAD * listaP.Item(x).PRECIO / 1.18), 6)
                                        nuevoddocumento.tipo_igv = "IGV"
                                    Else
                                        nuevoddocumento.igv = 0
                                        nuevoddocumento.tipo_igv = "INA"
                                    End If
                                Else
                                    nuevoddocumento.igv = listaP.Item(x).IGVBAS
                                    nuevoddocumento.tipo_igv = listaP.Item(x).TIPO_IGV
                                End If

                                nuevoddocumento.percepcion = PERCEP
                                nuevoddocumento.codi_cab = CODCAB
                                nuevoddocumento.obse = "AAAAA"
                                gestordefacturacionelectronica.CrearDdocumento(nuevoddocumento)
                            Next
                            gestordefacturacionelectronica.ModificarEstado(SERIE, NRODOCSIN)
                            scope.Complete()
                        End Using
                    Catch ex As Exception
                        MsgBox("- REVISE LA FACTURACION ELECTRONICA, HAY ALGUNA FALLA ." & ex.Message, MsgBoxStyle.Information, "NARSISTEMAS")
                        Exit Sub
                    End Try


                    CAyuda.Ejecutar("SP_UDPDATE_CABCODHAS", VNroDoc, TipoDoc, "", 1, SERIE, NRODOCSIN)


                End If
            End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''' VERIFICO SI SE ENVIO A SUNAT O CORRECTAMENTE '''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

IR2:
            If CAyuda.Ejecutar("SP_UPDATE_DOCREFACT", codempresa, VCdTipoDoc_ant, VNroDoc_ant, VCdTipoDoc, VNroDoc, VentaC) > 0 Then
            End If
        End If

        MsgBox("EL DOCUMENTO SE GUARDO CORRECTAMENTE", MsgBoxStyle.Information, "")

        ' TmpInsertDatos("NSP_ACTUALIZA_ARTIDAT_MOV_TMP_VENTADET  '" & codempresa & "','" & 1 & "','0','','" & CODALMACEN & "' ,'" & rand & "'")
        DEVOLVER = True
        Me.Close()

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click

    End Sub

    Private Sub lbltipodoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltipodoc.Click

    End Sub

    Private Sub btnanular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanular.Click
        If MsgBox("ESTA SEGURO DE ELIMINAR EL DOCUMENTO..", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If CAyuda.Ejecutar("ANULAR_DOCUMENTO_EN_FACTURACION_PROC", codempresa, VCdTipoDoc, VNroDoc, txtcodclie.Text) > 0 Then
                CAyuda.Ejecutar("SP_ANULDOC_TMP_GUIAINTERNADET", codempresa, VCorrelInv, VNroDoc, VCdTipoDoc)
                MsgBox("SE ELIMINO CORRECTAMENTE EL DOCUMENTO .. ", MsgBoxStyle.Information, "")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btncredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncredito.Click

        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = dtpfechadoc.Value.Year
        MES = dtpfechadoc.Value.Month

        Select Case MES
            Case 1
                DESMES = "ENERO"
            Case 2
                DESMES = "FEBRERO"
            Case 3
                DESMES = "MARZO"
            Case 4
                DESMES = "ABRIL"
            Case 5
                DESMES = "MAYO"
            Case 6
                DESMES = "JUNIO"
            Case 7
                DESMES = "JULIO"
            Case 8
                DESMES = "AGOSTO"
            Case 9
                DESMES = "SETIEMBRE"
            Case 10
                DESMES = "OCTUBRE"
            Case 11
                DESMES = "NOVIEMBRE"
            Case 12
                DESMES = "DECIEMBRE"
        End Select

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If


        '************************************************************************************************
        Dim TABLE1 As New DataTable
        TABLE1 = TmpListarDatos("NSP_BUSCAR_FACTURACION  '" & codempresa & "','" & VNroDoc & "','" & VCdTipoDoc & "','" & rand & "'")
        If TABLE1.Rows.Count > 0 Then
            Dim DOC As String = ""

            If VCdTipoDoc.Trim = "01" Then
                DOC = "Factura"
            End If

            If VCdTipoDoc.Trim = "03" Then
                DOC = "Boleta"
            End If

            If VCdTipoDoc.Trim = "06" Then
                DOC = "Nota Pedido"
            End If

            MsgBox("El Documento " & DOC & " " & VNroDoc & " ya existe")
            Exit Sub
        End If

        If Grid1.Enabled = True Then


            If FACTPTOVTA = True Then

                If CAyuda.Ejecutar("Nsp_grabadocumentoJ", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, "06", VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN) > 0 Then
                    GoTo IR
                End If

            End If

            If FACTLINEA = True Then
                If VCdTipoDoc = "06" Then
                    If CAyuda.Ejecutar("Nsp_grabadocumentoJ", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, "06", VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN) > 0 Then
                        GoTo IR2
                    End If
                End If

                Dim dt_linea As DataTable
                dt_linea = TmpListarDatos("nsp_buscar_LineaCorreDoc  '" & CodLinea & "'")

                If dt_linea.Rows.Count > 0 Then
                    If CAyuda.Ejecutar("Nsp_grabadocumentoJxLinea", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, "06", VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN, CodLinea) > 0 Then

                        Dim TABLINEA_ENVIA As New DataTable
                        TABLINEA_ENVIA = TmpListarDatos("sp_LineaCorreDoc_EnviaElect  '" & CodLinea & "'")
                        If TABLINEA_ENVIA.Rows.Count > 0 Then
                            GoTo IR
                        Else
                            GoTo IR2
                        End If

                    End If
                Else
                    If CAyuda.Ejecutar("Nsp_grabadocumentoJ", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, "06", VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN) > 0 Then
                        GoTo IR
                    End If
                End If

            End If

            'If FACTSUBEMP = True Then

            '    If CAyuda.Ejecutar("Nsp_grabadocumentoJxSubEmpresa", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, "06", VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN, CodSubEmpresa) > 0 Then

            '    End If

            '    Dim dt_validar_fe As DataTable
            '    dt_validar_fe = TmpListarDatos("nsp_validar_ef  '" & CodSubEmpresa & "'")
            '    If dt_validar_fe.Rows.Count > 0 Then
            '        GoTo IR
            '    Else
            '        GoTo IR2
            '    End If
            'End If



            If FACTSUBEMP = True Then

                If (Supervisor = False) Then

                    If CAyuda.Ejecutar("Nsp_grabadocumentoJxSubEmpresa", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, "06", VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN, CodSubEmpresa) > 0 Then

                    End If

                    Dim dt_validar_fe As DataTable
                    dt_validar_fe = TmpListarDatos("nsp_validar_ef_todo  '" & CodSubEmpresa & "'")
                    If dt_validar_fe.Rows.Count > 0 Then
                        GoTo IR
                    End If

                    dt_validar_fe = TmpListarDatos("nsp_validar_ef_soloFact  '" & CodSubEmpresa & "'")
                    If dt_validar_fe.Rows.Count > 0 Then
                        GoTo IR
                    End If

                    GoTo IR2

                End If



                If (Supervisor = True) Then

                    If CAyuda.Ejecutar("Nsp_grabadocumentoJxSupervisor", NROGUIA, "", "True", VCorrelVta, 0, CboPagador.SelectedValue, "06", VCdTipoDoc, VNroDoc, CboMoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, TxtTOTAL.Text, VPorcenDesc, 0, TxtTOTAL.Text, 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, CboMoneda.SelectedValue, NROPTOVTA, VCorrelVta, CODALMACEN, CodSupervisor) > 0 Then

                    End If


                    GoTo IR2
                End If



            End If








            '''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''
            '''''FACTURACION ELECTRONICA ENVIO BASE''''''
            '''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''
IR:

            If EMIELECTRONIC = True Then


                Dim TipoDoc As String
                TipoDoc = VCdTipoDoc
                VRuc = txtruc.Text
                VCodCliente = txtcodclie.Text
                VNroDoc = VNroDoc


                If TipoDoc.Trim = "01" Or TipoDoc.Trim = "03" Then

                    Dim StrSql As String
                    StrSql = "SELECT TMP_VENTADET.ITEM,TMP_VENTADET.CODARTI, TMP_VENTADET.DESARTI, TMP_VENTADET.preciovta, " &
                                 "  TMP_VENTADET.CANTIDAD,  TMP_VENTADET.SUBTOTBAS, '01' AS TIPOPRE," &
                                       "  TMP_VENTADET.TOTBAS, TMP_VENTADET.IGVBAS,(TMP_VENTADET.SUBTOTBAS/TMP_VENTADET.CANTIDAD) AS PRECSINIGV," &
                                       "   TMP_VENTADET.MONTODESCBAS ,TMP_VENTADET.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC,ARTICULO.codimpuesto " &
                                 " FROM ARTICULO INNER JOIN TMP_VENTADET ON ARTICULO.CODARTI = TMP_VENTADET.CODARTI" &
                                  " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                              "  INNER JOIN PRESENTACION ON PRESENTACION.codpres = TMP_VENTADET.CODPRES" &
                            " WHERE TMP_VENTADET.CORRNBR = " & CInt(VCorrelVta) & " ORDER BY TMP_VENTADET.ITEM "

                    Dim Tabla_Tmp As DataTable
                    Tabla_Tmp = TmpListarDatos(StrSql)

                    listaP.Clear()
                    If Tabla_Tmp.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp.Rows.Count - 1
                            Dim o As New NuevaVentaDet
                            o.CODARTI = Tabla_Tmp.Rows(x)("CODARTI")
                            o.DESARTI = Tabla_Tmp.Rows(x)("DESARTI")
                            o.CODFACELEC = Tabla_Tmp.Rows(x)("CODFACELEC")
                            o.PRECIO = Tabla_Tmp.Rows(x)("preciovta")
                            o.MONTODESCBAS = Tabla_Tmp.Rows(x)("MONTODESCBAS")
                            o.CANTIDAD = Tabla_Tmp.Rows(x)("CANTIDAD")
                            o.IGVBAS = Tabla_Tmp.Rows(x)("IGVBAS")
                            o.ITEM = Tabla_Tmp.Rows(x)("ITEM")
                            o.TIPO_IGV = IIf(Tabla_Tmp.Rows(x)("codimpuesto") = "IGV", "IGV", "INA")
                            listaP.Add(o)
                        Next
                    End If




                    StrSql = "select codarti,item ,(preciovta - (TOTBAS/CANTIDAD)) as Prod_Desct_Ddocumento from TMP_VENTADET" &
                        " WHERE  CORRNBR = " & CInt(VCorrelVta) & "  and MONTODESCBAS > 0"

                    Dim Tabla_Tmp2 As DataTable
                    Tabla_Tmp2 = TmpListarDatos(StrSql)

                    listaDesc.Clear()
                    If Tabla_Tmp2.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp2.Rows.Count - 1
                            Dim o As New DescDdocum
                            o.codarti = Tabla_Tmp2.Rows(x)("codarti")
                            o.item = Tabla_Tmp2.Rows(x)("item")
                            o.prod_desct = Tabla_Tmp2.Rows(x)("Prod_Desct_Ddocumento")
                            listaDesc.Add(o)
                        Next
                    End If





                    CAyuda.Ejecutar("SP_DELETE_TMP_VENTADET", CodUsuario, CInt(VCorrelVta))


                    Dim Table_VC3 As New DataTable
                    Table_VC3 = TmpListarDatos("SP_SELECT_VENTACAB   '" & VCdTipoDoc & "','" & VNroDoc & "'")
                    If Table_VC3.Rows.Count > 0 Then
                        PERCEP = 0
                        IGV = CDbl(Table_VC3.Rows(0)("IGVBAS").ToString())
                        SUBTOTAL = CDbl(Table_VC3.Rows(0)("SUBTOTBAS").ToString())
                        PERCEP = CDbl(Table_VC3.Rows(0)("IPERCEP").ToString())
                    End If

                    If IGV > 0 Then
                        TIPO_IGV = "SI"
                    Else
                        TIPO_IGV = "NO"
                    End If

                    Dim Table_VC2 As New DataTable
                    Table_VC2 = TmpListarDatos("SP_SELECT_EMAIL_CLIENTE   '" & VCdTipoDoc & "','" & VNroDoc & "'")
                    If Table_VC2.Rows.Count > 0 Then
                        EMAIL = Table_VC2.Rows(0)("EMAIL").ToString()
                        DNI = Table_VC2.Rows(0)("DNI").ToString()
                        If VCodCliente = "888" Then
                            DNI = "88888888"
                        End If
                    End If

                    TipoDoc = VCdTipoDoc

                    If TipoDoc.Trim = "01" Then
                        LETRADOC = "F"
                        CLIE_DOCU = CStr(VRuc.Trim)
                    End If
                    If TipoDoc.Trim = "03" Then
                        LETRADOC = "B"
                        CLIE_DOCU = DNI
                        If CLIE_DOCU.Length = 0 Then
                            CLIE_DOCU = "99999999"
                        End If
                    End If

                    Dim FormatNroDoc As String
                    FormatNroDoc = Format(VNroDoc, "0##-########")
                    Dim NUMSERIE As String
                    NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                    SERIE = LETRADOC + NUMSERIE
                    NRODOCSIN = CStr(Microsoft.VisualBasic.Right(VNroDoc, 8))
                    NRODOCFINAL = SERIE + "-" + NRODOCSIN

                    Dim dblTOTINAFECTO As Double
                    Dim TABLA_INAFECTO As New DataTable
                    TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO  '" & TipoDoc & "','" & VNroDoc & "'  ")

                    If TABLA_INAFECTO.Rows.Count > 0 Then
                        dblTOTINAFECTO = CDbl(FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString)
                    End If

                    Dim NroDiasCred As Integer
                    Dim TableDiasCred As New DataTable
                    TableDiasCred = TmpListarDatos("sp_extrar_nrodias_credito   '" & txtcodclie.Text & "'")
                    If TableDiasCred.Rows.Count > 0 Then
                        NroDiasCred = TableDiasCred.Rows(0)("NRDIAS").ToString()
                    End If



                    Try

                            Dim gestordefacturacionelectronica As IGestorDeFacturacionElectronica = New GestorDeFacturacionElectronica()
                            Dim nuevohdocumento As New NuevaHdocumento

                            nuevohdocumento.codi_cab = 0
                            nuevohdocumento.esta_pod = 1
                            nuevohdocumento.codi_caja = CStr(NROPTOVTA)
                            nuevohdocumento.comp = VCdTipoDoc
                            nuevohdocumento.serie = SERIE
                            nuevohdocumento.nume = NRODOCSIN
                            nuevohdocumento.fecha = Format(CDate(dtpfechadoc.Value), "dd/MM/yyyy")
                            nuevohdocumento.codi_vend = cbovendedor.SelectedValue
                            nuevohdocumento.clie_docu = CLIE_DOCU
                            nuevohdocumento.clie_nomb = txtcliente.Text
                            nuevohdocumento.clie_dire = txtdireccion.Text
                            nuevohdocumento.clie_email = EMAIL
                            nuevohdocumento.clie_celu = ""
                            nuevohdocumento.dire_entr = ""
                            nuevohdocumento.ubig_entr = UBIGUEO
                            nuevohdocumento.mone_codi = "PEN"
                            nuevohdocumento.LLEVAigv = TIPO_IGV
                            nuevohdocumento.desc_globa = ""
                            nuevohdocumento.obse = ""
                            nuevohdocumento.guia = ""
                            nuevohdocumento.placa = ""
                            nuevohdocumento.dire_part = ""
                            nuevohdocumento.ubig_part = ""
                            nuevohdocumento.ubig_lleg = ""
                            nuevohdocumento.cod_Ubigeo = ""
                            nuevohdocumento.tipo_trans = ""
                            nuevohdocumento.peso_kg = 0.0
                            nuevohdocumento.trans_publ_ruc = ""
                            nuevohdocumento.trans_publ_razon = ""
                            nuevohdocumento.trans_priv_placa = ""
                            nuevohdocumento.trans_priv_marca = ""
                            nuevohdocumento.trans_priv_const = ""
                            nuevohdocumento.trans_priv_lice = ""
                            nuevohdocumento.codi_moti = ""
                            nuevohdocumento.motivo = ""
                            nuevohdocumento.doc_refe = ""
                            nuevohdocumento.ValorResumen = 0.0
                            nuevohdocumento.ValorHash = ""
                            nuevohdocumento.DarBaja = 0
                            nuevohdocumento.MotivoBaja = ""
                            nuevohdocumento.ProcesarBaja = 0
                        nuevohdocumento.Grabado = SUBTOTAL - dblTOTINAFECTO
                        nuevohdocumento.IGV = IGV
                            nuevohdocumento.Total = TxtTOTAL.Text
                            nuevohdocumento.dire_lleg = ""
                            nuevohdocumento.Guia_trans = ""
                            nuevohdocumento.Envio_xml = 0
                            nuevohdocumento.Clie_tipo = IIf(CStr(VRuc.Trim) <> "", 6, 1)
                            nuevohdocumento.Fact_guia = "NO"
                            nuevohdocumento.Exonerado = 0
                            nuevohdocumento.Inafecto = dblTOTINAFECTO
                            nuevohdocumento.percepcion = PERCEP
                            nuevohdocumento.Codigo_local = CODLOCAL
                            nuevohdocumento.hora = Now.ToString("HH:mm:ss")
                            nuevohdocumento.Forma_pago = "CREDITO"
                            nuevohdocumento.total_credito = TxtTOTAL.Text





                            Using scope As TransactionScope = New TransactionScope()

                                Dim CODCAB As Integer
                                CODCAB = gestordefacturacionelectronica.CrearHdocumento(nuevohdocumento).codi_cab


                            Dim nuevocdocumento As New NuevaCDocumento
                            nuevocdocumento.cred_codi = 1
                            nuevocdocumento.codi_cab = CODCAB
                            nuevocdocumento.num_cuota = 1
                            nuevocdocumento.monto_cuota = TxtTOTAL.Text
                            nuevocdocumento.fecha_vence = Format(CDate(dtpfechadoc.Value.Date.AddDays(NroDiasCred)), "dd/MM/yyyy")
                            gestordefacturacionelectronica.CrearCDocumento(nuevocdocumento)




                            For x As Integer = 0 To Me.listaP.Count - 1
                                Dim nuevoddocumento As New NuevaDDocumento
                                nuevoddocumento.id = 1
                                nuevoddocumento.prod_codi = listaP.Item(x).CODARTI.ToString
                                nuevoddocumento.prod_descr = listaP.Item(x).DESARTI.ToString
                                nuevoddocumento.prod_unid = listaP.Item(x).CODFACELEC.ToString
                                nuevoddocumento.prod_precio = listaP.Item(x).PRECIO
                                nuevoddocumento.prod_desct = listaP.Item(x).MONTODESCBAS
                                nuevoddocumento.prod_cant = listaP.Item(x).CANTIDAD


                                For d As Integer = 0 To Me.listaDesc.Count - 1
                                    If listaP.Item(x).CODARTI.ToString = listaDesc.Item(d).codarti.ToString Then
                                        If CInt(listaP.Item(x).ITEM) = CInt(listaDesc.Item(d).item) Then
                                            nuevoddocumento.prod_desct = listaDesc.Item(d).prod_desct.ToString
                                            Exit For
                                        End If
                                    End If
                                Next


                                If listaP.Item(x).PRECIO.ToString() = "0.0100" Then
                                    If listaP.Item(x).TIPO_IGV = "IGV" Then
                                        nuevoddocumento.igv = Math.Round((1.18 - 1) * (listaP.Item(x).CANTIDAD * listaP.Item(x).PRECIO / 1.18), 6)
                                        nuevoddocumento.tipo_igv = "IGV"
                                    Else
                                        nuevoddocumento.igv = 0
                                        nuevoddocumento.tipo_igv = "INA"
                                    End If
                                Else
                                    nuevoddocumento.igv = listaP.Item(x).IGVBAS
                                    nuevoddocumento.tipo_igv = listaP.Item(x).TIPO_IGV
                                End If

                                nuevoddocumento.percepcion = PERCEP
                                nuevoddocumento.codi_cab = CODCAB
                                nuevoddocumento.obse = "AAAAA"
                                gestordefacturacionelectronica.CrearDdocumento(nuevoddocumento)
                            Next
                            gestordefacturacionelectronica.ModificarEstado(SERIE, NRODOCSIN)
                                scope.Complete()
                            End Using
                        Catch ex As Exception
                            MsgBox("- REVISE LA FACTURACION ELECTRONICA, HAY ALGUNA FALLA ." & ex.Message, MsgBoxStyle.Information, "NARSISTEMAS")
                            Exit Sub
                        End Try

                        CAyuda.Ejecutar("SP_UDPDATE_CABCODHAS", VNroDoc, TipoDoc, "", 1, SERIE, NRODOCSIN)

                    End If
                End If

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''' VERIFICO SI SE ENVIO A SUNAT O CORRECTAMENTE '''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


IR2:
            If CAyuda.Ejecutar("SP_UPDATE_DOCREFACT", codempresa, VCdTipoDoc_ant, VNroDoc_ant, VCdTipoDoc, VNroDoc, VentaC) > 0 Then
            End If
        End If

        MsgBox("EL DOCUMENTO SE GUARDO CORRECTAMENTE", MsgBoxStyle.Information, "")

        ' TmpInsertDatos("NSP_ACTUALIZA_ARTIDAT_MOV_TMP_VENTADET  '" & codempresa & "','" & 1 & "','0','','" & CODALMACEN & "' ,'" & rand & "'")
        DEVOLVER = True
        Me.Close()

    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click

    End Sub

    Private Sub CTRLCANTIDAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTRLCANTIDAD.TextChanged

    End Sub

    Private Sub CTRLCANTIDAD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CTRLCANTIDAD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CTRLPRECIO.Enabled = True Then
                CTRLPRECIO.Focus()
            Else
                INSERT_TMP_DETALLE()
            End If

        End If
    End Sub

    Private Sub cbPresentacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPresentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            CTRLCANTIDAD.Focus()

        End If
    End Sub

    Private Sub CTRLPRECIO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CTRLPRECIO.KeyPress, CTRLCANTIDAD.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtruc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtruc.TextChanged

    End Sub

    Private Sub txtruc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtruc.KeyDown
        If e.KeyCode = Keys.Enter Then
            VRuc = txtruc.Text.Trim

            GenerarNroDoc3()
            ConfigDocumento()
            CargarGridFact()
            FormatoGridDetVta()


        End If
        If e.KeyCode = Keys.F1 Then
            If VUsarNotaPedido = True Then
                VUsarNotaPedido = False
            Else
                VUsarNotaPedido = True
            End If
            GenerarNroDoc3()
            ConfigDocumento()
            CargarGridFact()
            FormatoGridDetVta()

        End If

    End Sub

    Private Sub CTRLCANTIDAD_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CTRLCANTIDAD.StyleChanged

    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    'Private Sub rbboleta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbboleta.CheckedChanged
    '    If Me.rbboleta.Checked = True Then
    '        If Consul_var = False Then
    '            VCdTipoDoc = CDBOLETA
    '            GenerarNroDoc(True)
    '            ConfigDocumento()
    '            CargarGridFact()
    '        End If
    '    End If
    'End Sub

    'Private Sub rbfactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfactura.CheckedChanged
    '    If Me.rbfactura.Checked = True Then
    '        If Consul_var = False Then
    '            VCdTipoDoc = CDFACTURA
    '            GenerarNroDoc(True)
    '            ConfigDocumento()
    '            CargarGridFact()
    '        End If
    '    End If
    'End Sub

    'Private Sub rbnotap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnotap.CheckedChanged
    '    If Me.rbnotap.Checked = True Then
    '        If Consul_var = False Then
    '            VCdTipoDoc = CDNTAPEDIDO
    '            GenerarNroDoc(True)
    '            ConfigDocumento()
    '            CargarGridFact()
    '        End If
    '    End If
    'End Sub

    Private Sub rbboleta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbboleta.CheckedChanged

    End Sub

    Private Sub rbfactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfactura.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TXTNUMERODOC_TextChanged(sender As Object, e As EventArgs) Handles TXTNUMERODOC.TextChanged

    End Sub
End Class
