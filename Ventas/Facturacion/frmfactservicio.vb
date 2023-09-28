Imports System.Data.SqlClient
Imports CapaNegocio
Imports InterfacesFacturacionElectronica.Factura.Peticiones
Imports Servicios.Implementacion
Imports Servicios.Interfaces.Factura
Imports Servicios.Interfaces.FacturaElectronica.Peticiones

Public Class frmfactservicio
    Inherits System.Windows.Forms.Form

    Dim flagfac As Boolean
    Dim IGVFAC As Double
    Friend WithEvents Grid1 As DataGrid
    Dim SW As Boolean

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
    Dim TABLA_INAFECTO As New DataTable
    Dim CLIE_DOCU As String
    Dim TOTAL As Double

    'Public VIE2 As New FACT_ZONPTOVTA
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtnroguias As System.Windows.Forms.TextBox
    Friend WithEvents TXTNUMERODOC As System.Windows.Forms.TextBox
    Friend WithEvents TXTSERIEDOC As System.Windows.Forms.TextBox
    Friend WithEvents txtnotapesada As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtcodclie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLSIMBOLO3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpfechadoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents CHKIGV As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BTNGUIAS As System.Windows.Forms.Button
    Friend WithEvents lblprincipal As System.Windows.Forms.Label
    Friend WithEvents LBLSIMBOLOCAMBIO As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LBLSIMBOLO2 As System.Windows.Forms.Label
    Friend WithEvents CTRLSUBTOTAL As AxMiControl.AxCtrlNumber
    Friend WithEvents CTRLTOTAL As AxMiControl.AxCtrlNumber
    Friend WithEvents LBLSIMBOLO4 As System.Windows.Forms.Label
    Friend WithEvents lblsimbolo As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents CTRLDESC As AxMiControl.AxCtrlNumber
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LBLIGV As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
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
    Friend WithEvents lblcambio As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbovendedor As System.Windows.Forms.ComboBox
    Friend WithEvents lbloperador As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnufacdirec As System.Windows.Forms.MenuItem
    Friend WithEvents mnufactguia As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltotalletras As System.Windows.Forms.Label
    Friend WithEvents CRTDOC As AxCrystal.AxCrystalReport
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtcodarticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbounidadventa As System.Windows.Forms.ComboBox
    Friend WithEvents lblunidadventa As System.Windows.Forms.Label
    Friend WithEvents btneliitem As System.Windows.Forms.Button
    Friend WithEvents btnactuitem As System.Windows.Forms.Button
    Friend WithEvents btnnueitem As System.Windows.Forms.Button
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnbus As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbltipodoc As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents btnrestaurar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CTRLIGV2 As AxMiControl.AxCtrlNumber
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CTRLCANTIDADSERV As System.Windows.Forms.TextBox
    Friend WithEvents CTRLPRECIO As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfactservicio))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.txtnroguias = New System.Windows.Forms.TextBox()
        Me.TXTNUMERODOC = New System.Windows.Forms.TextBox()
        Me.TXTSERIEDOC = New System.Windows.Forms.TextBox()
        Me.txtnotapesada = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.txtcodclie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLSIMBOLO3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpfechadoc = New System.Windows.Forms.DateTimePicker()
        Me.CHKIGV = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTNGUIAS = New System.Windows.Forms.Button()
        Me.lblprincipal = New System.Windows.Forms.Label()
        Me.LBLSIMBOLOCAMBIO = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CTRLIGV2 = New AxMiControl.AxCtrlNumber()
        Me.LBLSIMBOLO2 = New System.Windows.Forms.Label()
        Me.CTRLSUBTOTAL = New AxMiControl.AxCtrlNumber()
        Me.CTRLTOTAL = New AxMiControl.AxCtrlNumber()
        Me.LBLSIMBOLO4 = New System.Windows.Forms.Label()
        Me.lblsimbolo = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.CTRLDESC = New AxMiControl.AxCtrlNumber()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LBLIGV = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
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
        Me.lblcambio = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbovendedor = New System.Windows.Forms.ComboBox()
        Me.lbloperador = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnufacdirec = New System.Windows.Forms.MenuItem()
        Me.mnufactguia = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Grid1 = New System.Windows.Forms.DataGrid()
        Me.lbltotalletras = New System.Windows.Forms.Label()
        Me.CRTDOC = New AxCrystal.AxCrystalReport()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CTRLCANTIDADSERV = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtcodarticulo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbounidadventa = New System.Windows.Forms.ComboBox()
        Me.lblunidadventa = New System.Windows.Forms.Label()
        Me.btneliitem = New System.Windows.Forms.Button()
        Me.btnactuitem = New System.Windows.Forms.Button()
        Me.btnnueitem = New System.Windows.Forms.Button()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.CTRLPRECIO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnbus = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltipodoc = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnrestaurar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CTRLIGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTRLSUBTOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTRLTOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTRLDESC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRTDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.Silver
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.Black
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(48, 560)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(687, 147)
        Me.DataGrid1.TabIndex = 117
        '
        'txtnroguias
        '
        Me.txtnroguias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnroguias.Location = New System.Drawing.Point(632, 128)
        Me.txtnroguias.MaxLength = 500
        Me.txtnroguias.Name = "txtnroguias"
        Me.txtnroguias.ReadOnly = True
        Me.txtnroguias.Size = New System.Drawing.Size(48, 21)
        Me.txtnroguias.TabIndex = 130
        Me.txtnroguias.Visible = False
        '
        'TXTNUMERODOC
        '
        Me.TXTNUMERODOC.BackColor = System.Drawing.Color.White
        Me.TXTNUMERODOC.Enabled = False
        Me.TXTNUMERODOC.Location = New System.Drawing.Point(257, 33)
        Me.TXTNUMERODOC.Name = "TXTNUMERODOC"
        Me.TXTNUMERODOC.Size = New System.Drawing.Size(89, 21)
        Me.TXTNUMERODOC.TabIndex = 126
        Me.TXTNUMERODOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTSERIEDOC
        '
        Me.TXTSERIEDOC.BackColor = System.Drawing.Color.White
        Me.TXTSERIEDOC.Enabled = False
        Me.TXTSERIEDOC.Location = New System.Drawing.Point(191, 33)
        Me.TXTSERIEDOC.Name = "TXTSERIEDOC"
        Me.TXTSERIEDOC.Size = New System.Drawing.Size(54, 21)
        Me.TXTSERIEDOC.TabIndex = 125
        Me.TXTSERIEDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnotapesada
        '
        Me.txtnotapesada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnotapesada.Location = New System.Drawing.Point(696, 128)
        Me.txtnotapesada.MaxLength = 500
        Me.txtnotapesada.Name = "txtnotapesada"
        Me.txtnotapesada.Size = New System.Drawing.Size(48, 21)
        Me.txtnotapesada.TabIndex = 123
        Me.txtnotapesada.Text = "1"
        Me.txtnotapesada.Visible = False
        '
        'txtdireccion
        '
        Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdireccion.Location = New System.Drawing.Point(188, 106)
        Me.txtdireccion.MaxLength = 200
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(224, 21)
        Me.txtdireccion.TabIndex = 102
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label14.Location = New System.Drawing.Point(413, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Vendedor : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(130, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Operador : "
        '
        'txtcliente
        '
        Me.txtcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcliente.Location = New System.Drawing.Point(188, 84)
        Me.txtcliente.MaxLength = 150
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(224, 21)
        Me.txtcliente.TabIndex = 101
        '
        'txtruc
        '
        Me.txtruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtruc.Location = New System.Drawing.Point(349, 64)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(104, 21)
        Me.txtruc.TabIndex = 100
        '
        'txtnumero
        '
        Me.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnumero.Enabled = False
        Me.txtnumero.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(268, 15)
        Me.txtnumero.Multiline = True
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(109, 15)
        Me.txtnumero.TabIndex = 99
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnumero.Visible = False
        '
        'txtcodclie
        '
        Me.txtcodclie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodclie.Location = New System.Drawing.Point(188, 62)
        Me.txtcodclie.MaxLength = 10
        Me.txtcodclie.Name = "txtcodclie"
        Me.txtcodclie.Size = New System.Drawing.Size(81, 21)
        Me.txtcodclie.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Direccion : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Apell. o R.S. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Cod. Cliente : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "N° Documento : "
        '
        'LBLSIMBOLO3
        '
        Me.LBLSIMBOLO3.AutoSize = True
        Me.LBLSIMBOLO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO3.Location = New System.Drawing.Point(377, 557)
        Me.LBLSIMBOLO3.Name = "LBLSIMBOLO3"
        Me.LBLSIMBOLO3.Size = New System.Drawing.Size(25, 13)
        Me.LBLSIMBOLO3.TabIndex = 118
        Me.LBLSIMBOLO3.Text = "S/."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label9.Location = New System.Drawing.Point(455, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Fecha Doc. :  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "R.U.C : "
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(536, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 29)
        Me.Label18.TabIndex = 129
        Me.Label18.Text = "Nro de Guia :"
        Me.Label18.Visible = False
        '
        'dtpfechadoc
        '
        Me.dtpfechadoc.Enabled = False
        Me.dtpfechadoc.Location = New System.Drawing.Point(528, 62)
        Me.dtpfechadoc.Name = "dtpfechadoc"
        Me.dtpfechadoc.Size = New System.Drawing.Size(207, 21)
        Me.dtpfechadoc.TabIndex = 106
        '
        'CHKIGV
        '
        Me.CHKIGV.Checked = True
        Me.CHKIGV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKIGV.Location = New System.Drawing.Point(744, 39)
        Me.CHKIGV.Name = "CHKIGV"
        Me.CHKIGV.Size = New System.Drawing.Size(93, 20)
        Me.CHKIGV.TabIndex = 127
        Me.CHKIGV.Text = "Aplicar IGV"
        Me.CHKIGV.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(528, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 23)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Nota de Pesada : "
        Me.Label10.Visible = False
        '
        'BTNGUIAS
        '
        Me.BTNGUIAS.Location = New System.Drawing.Point(568, 96)
        Me.BTNGUIAS.Name = "BTNGUIAS"
        Me.BTNGUIAS.Size = New System.Drawing.Size(78, 22)
        Me.BTNGUIAS.TabIndex = 121
        Me.BTNGUIAS.Text = "G&UIAS"
        Me.BTNGUIAS.Visible = False
        '
        'lblprincipal
        '
        Me.lblprincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprincipal.Location = New System.Drawing.Point(488, 88)
        Me.lblprincipal.Name = "lblprincipal"
        Me.lblprincipal.Size = New System.Drawing.Size(186, 20)
        Me.lblprincipal.TabIndex = 120
        Me.lblprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLSIMBOLOCAMBIO
        '
        Me.LBLSIMBOLOCAMBIO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLOCAMBIO.Location = New System.Drawing.Point(643, 20)
        Me.LBLSIMBOLOCAMBIO.Name = "LBLSIMBOLOCAMBIO"
        Me.LBLSIMBOLOCAMBIO.Size = New System.Drawing.Size(17, 20)
        Me.LBLSIMBOLOCAMBIO.TabIndex = 119
        Me.LBLSIMBOLOCAMBIO.Text = "$"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CTRLIGV2)
        Me.GroupBox3.Controls.Add(Me.LBLSIMBOLO2)
        Me.GroupBox3.Controls.Add(Me.CTRLSUBTOTAL)
        Me.GroupBox3.Controls.Add(Me.CTRLTOTAL)
        Me.GroupBox3.Controls.Add(Me.LBLSIMBOLO4)
        Me.GroupBox3.Controls.Add(Me.lblsimbolo)
        Me.GroupBox3.Controls.Add(Me.lblsubtotal)
        Me.GroupBox3.Controls.Add(Me.CTRLDESC)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.LBLIGV)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 432)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(849, 51)
        Me.GroupBox3.TabIndex = 116
        Me.GroupBox3.TabStop = False
        '
        'CTRLIGV2
        '
        Me.CTRLIGV2.Enabled = True
        Me.CTRLIGV2.Location = New System.Drawing.Point(351, 16)
        Me.CTRLIGV2.Name = "CTRLIGV2"
        Me.CTRLIGV2.OcxState = CType(resources.GetObject("CTRLIGV2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CTRLIGV2.Size = New System.Drawing.Size(91, 23)
        Me.CTRLIGV2.TabIndex = 62
        '
        'LBLSIMBOLO2
        '
        Me.LBLSIMBOLO2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO2.Location = New System.Drawing.Point(321, 17)
        Me.LBLSIMBOLO2.Name = "LBLSIMBOLO2"
        Me.LBLSIMBOLO2.Size = New System.Drawing.Size(32, 21)
        Me.LBLSIMBOLO2.TabIndex = 66
        Me.LBLSIMBOLO2.Text = "S/."
        '
        'CTRLSUBTOTAL
        '
        Me.CTRLSUBTOTAL.Enabled = True
        Me.CTRLSUBTOTAL.Location = New System.Drawing.Point(150, 16)
        Me.CTRLSUBTOTAL.Name = "CTRLSUBTOTAL"
        Me.CTRLSUBTOTAL.OcxState = CType(resources.GetObject("CTRLSUBTOTAL.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CTRLSUBTOTAL.Size = New System.Drawing.Size(113, 23)
        Me.CTRLSUBTOTAL.TabIndex = 60
        '
        'CTRLTOTAL
        '
        Me.CTRLTOTAL.Enabled = True
        Me.CTRLTOTAL.Location = New System.Drawing.Point(712, 13)
        Me.CTRLTOTAL.Name = "CTRLTOTAL"
        Me.CTRLTOTAL.OcxState = CType(resources.GetObject("CTRLTOTAL.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CTRLTOTAL.Size = New System.Drawing.Size(111, 24)
        Me.CTRLTOTAL.TabIndex = 64
        '
        'LBLSIMBOLO4
        '
        Me.LBLSIMBOLO4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO4.Location = New System.Drawing.Point(687, 18)
        Me.LBLSIMBOLO4.Name = "LBLSIMBOLO4"
        Me.LBLSIMBOLO4.Size = New System.Drawing.Size(31, 19)
        Me.LBLSIMBOLO4.TabIndex = 68
        Me.LBLSIMBOLO4.Text = "S/."
        '
        'lblsimbolo
        '
        Me.lblsimbolo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsimbolo.Location = New System.Drawing.Point(114, 18)
        Me.lblsimbolo.Name = "lblsimbolo"
        Me.lblsimbolo.Size = New System.Drawing.Size(32, 21)
        Me.lblsimbolo.TabIndex = 65
        Me.lblsimbolo.Text = "S/."
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(11, 18)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(119, 21)
        Me.lblsubtotal.TabIndex = 0
        Me.lblsubtotal.Text = "SUB TOTAL."
        '
        'CTRLDESC
        '
        Me.CTRLDESC.Enabled = True
        Me.CTRLDESC.Location = New System.Drawing.Point(530, 16)
        Me.CTRLDESC.Name = "CTRLDESC"
        Me.CTRLDESC.OcxState = CType(resources.GetObject("CTRLDESC.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CTRLDESC.Size = New System.Drawing.Size(86, 23)
        Me.CTRLDESC.TabIndex = 63
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(454, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 19)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "DESC % "
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(625, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 19)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "TOTAL"
        '
        'LBLIGV
        '
        Me.LBLIGV.AllowDrop = True
        Me.LBLIGV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIGV.Location = New System.Drawing.Point(283, 17)
        Me.LBLIGV.Name = "LBLIGV"
        Me.LBLIGV.Size = New System.Drawing.Size(51, 22)
        Me.LBLIGV.TabIndex = 2
        Me.LBLIGV.Text = "IGV  "
        '
        'GroupBox4
        '
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
        Me.GroupBox4.Location = New System.Drawing.Point(774, 81)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(106, 191)
        Me.GroupBox4.TabIndex = 115
        Me.GroupBox4.TabStop = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(6, 152)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(89, 26)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "&Salir"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(6, 126)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(89, 25)
        Me.btncancelar.TabIndex = 11
        Me.btncancelar.Text = "&Cancelar "
        '
        'btngeneranuevo
        '
        Me.btngeneranuevo.Location = New System.Drawing.Point(6, 94)
        Me.btngeneranuevo.Name = "btngeneranuevo"
        Me.btngeneranuevo.Size = New System.Drawing.Size(89, 31)
        Me.btngeneranuevo.TabIndex = 10
        Me.btngeneranuevo.Text = "G&enera Nuevo"
        '
        'btnreimprimir
        '
        Me.btnreimprimir.Location = New System.Drawing.Point(6, 66)
        Me.btnreimprimir.Name = "btnreimprimir"
        Me.btnreimprimir.Size = New System.Drawing.Size(89, 26)
        Me.btnreimprimir.TabIndex = 9
        Me.btnreimprimir.Text = "&Reimprimir"
        '
        'btnanular
        '
        Me.btnanular.Location = New System.Drawing.Point(6, 40)
        Me.btnanular.Name = "btnanular"
        Me.btnanular.Size = New System.Drawing.Size(89, 26)
        Me.btnanular.TabIndex = 8
        Me.btnanular.Text = "&Anular"
        '
        'btndsctototal
        '
        Me.btndsctototal.Location = New System.Drawing.Point(144, 176)
        Me.btndsctototal.Name = "btndsctototal"
        Me.btndsctototal.Size = New System.Drawing.Size(89, 26)
        Me.btndsctototal.TabIndex = 7
        Me.btndsctototal.Text = "Dscto al &Total"
        '
        'btndsctoitem
        '
        Me.btndsctoitem.Location = New System.Drawing.Point(144, 152)
        Me.btndsctoitem.Name = "btndsctoitem"
        Me.btndsctoitem.Size = New System.Drawing.Size(89, 26)
        Me.btndsctoitem.TabIndex = 6
        Me.btndsctoitem.Text = "Dscto x &Item"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(144, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 35)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "Editar Numero (F12)"
        '
        'btnvale
        '
        Me.btnvale.Location = New System.Drawing.Point(144, 88)
        Me.btnvale.Name = "btnvale"
        Me.btnvale.Size = New System.Drawing.Size(89, 26)
        Me.btnvale.TabIndex = 69
        Me.btnvale.Text = "  Vale      (F11)"
        '
        'btncredito
        '
        Me.btncredito.Location = New System.Drawing.Point(144, 64)
        Me.btncredito.Name = "btncredito"
        Me.btncredito.Size = New System.Drawing.Size(89, 26)
        Me.btncredito.TabIndex = 2
        Me.btncredito.Text = "Credito    (F10)"
        '
        'btncheque
        '
        Me.btncheque.Location = New System.Drawing.Point(144, 40)
        Me.btncheque.Name = "btncheque"
        Me.btncheque.Size = New System.Drawing.Size(89, 26)
        Me.btncheque.TabIndex = 3
        Me.btncheque.Text = "Cheque   (F9)"
        '
        'btntarjeta
        '
        Me.btntarjeta.Location = New System.Drawing.Point(144, 16)
        Me.btntarjeta.Name = "btntarjeta"
        Me.btntarjeta.Size = New System.Drawing.Size(89, 26)
        Me.btntarjeta.TabIndex = 1
        Me.btntarjeta.Text = "Tarjeta  (F8)"
        '
        'btnefectivo
        '
        Me.btnefectivo.Location = New System.Drawing.Point(7, 13)
        Me.btnefectivo.Name = "btnefectivo"
        Me.btnefectivo.Size = New System.Drawing.Size(89, 26)
        Me.btnefectivo.TabIndex = 0
        Me.btnefectivo.Text = "Efectivo (F7)"
        '
        'lblcambio
        '
        Me.lblcambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcambio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio.Location = New System.Drawing.Point(662, 19)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(52, 15)
        Me.lblcambio.TabIndex = 114
        Me.lblcambio.Text = "3.45"
        Me.lblcambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(588, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 15)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "T.C. : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(718, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 15)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "03:42:58 P.M."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbovendedor
        '
        Me.cbovendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovendedor.Location = New System.Drawing.Point(488, 108)
        Me.cbovendedor.Name = "cbovendedor"
        Me.cbovendedor.Size = New System.Drawing.Size(190, 21)
        Me.cbovendedor.TabIndex = 111
        '
        'lbloperador
        '
        Me.lbloperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbloperador.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloperador.Location = New System.Drawing.Point(191, 15)
        Me.lbloperador.Name = "lbloperador"
        Me.lbloperador.Size = New System.Drawing.Size(74, 15)
        Me.lbloperador.TabIndex = 109
        Me.lbloperador.Text = "USUARIO PTOVENTA"
        Me.lbloperador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnufacdirec, Me.mnufactguia, Me.MenuItem4, Me.MenuItem3, Me.MenuItem2, Me.MenuItem5})
        Me.MenuItem1.Text = "Procesos"
        '
        'mnufacdirec
        '
        Me.mnufacdirec.Index = 0
        Me.mnufacdirec.RadioCheck = True
        Me.mnufacdirec.Text = "Facturacion Directa"
        '
        'mnufactguia
        '
        Me.mnufactguia.Index = 1
        Me.mnufactguia.RadioCheck = True
        Me.mnufactguia.Text = "Facturacion Guia"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = "Cierre X"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "Cierre de Pto Venta"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Text = "Fin de Dia"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "usuario_zona"
        Me.MenuItem5.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Grid1)
        Me.GroupBox2.Controls.Add(Me.lbltotalletras)
        Me.GroupBox2.Controls.Add(Me.CRTDOC)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(755, 216)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.White
        Me.Grid1.CaptionBackColor = System.Drawing.Color.Silver
        Me.Grid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.CaptionForeColor = System.Drawing.Color.Black
        Me.Grid1.CaptionText = "Ayuda Articulos [F2],Eliminar Item [F3]"
        Me.Grid1.DataMember = ""
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(3, 17)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(749, 196)
        Me.Grid1.TabIndex = 86
        '
        'lbltotalletras
        '
        Me.lbltotalletras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalletras.ForeColor = System.Drawing.Color.Blue
        Me.lbltotalletras.Location = New System.Drawing.Point(11, 240)
        Me.lbltotalletras.Name = "lbltotalletras"
        Me.lbltotalletras.Size = New System.Drawing.Size(738, 17)
        Me.lbltotalletras.TabIndex = 62
        Me.lbltotalletras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(44, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 23)
        Me.Button4.TabIndex = 85
        Me.Button4.Text = "SOLO PARA EL REPORTE"
        Me.Button4.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(336, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(80, 82)
        Me.ListBox1.TabIndex = 60
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CTRLCANTIDADSERV)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtcodarticulo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbounidadventa)
        Me.GroupBox1.Controls.Add(Me.lblunidadventa)
        Me.GroupBox1.Controls.Add(Me.btneliitem)
        Me.GroupBox1.Controls.Add(Me.btnactuitem)
        Me.GroupBox1.Controls.Add(Me.btnnueitem)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txttipo)
        Me.GroupBox1.Controls.Add(Me.CTRLPRECIO)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 64)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        '
        'CTRLCANTIDADSERV
        '
        Me.CTRLCANTIDADSERV.Location = New System.Drawing.Point(672, 14)
        Me.CTRLCANTIDADSERV.Name = "CTRLCANTIDADSERV"
        Me.CTRLCANTIDADSERV.Size = New System.Drawing.Size(64, 21)
        Me.CTRLCANTIDADSERV.TabIndex = 89
        Me.CTRLCANTIDADSERV.Text = "0.00"
        Me.CTRLCANTIDADSERV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(608, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 13)
        Me.Label20.TabIndex = 88
        Me.Label20.Text = "Cantidad  :"
        '
        'txtcodarticulo
        '
        Me.txtcodarticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodarticulo.Location = New System.Drawing.Point(-792, 16)
        Me.txtcodarticulo.Name = "txtcodarticulo"
        Me.txtcodarticulo.Size = New System.Drawing.Size(102, 21)
        Me.txtcodarticulo.TabIndex = 62
        Me.txtcodarticulo.Text = "SERV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(-672, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Cantidad : "
        '
        'cbounidadventa
        '
        Me.cbounidadventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbounidadventa.Location = New System.Drawing.Point(-368, 38)
        Me.cbounidadventa.Name = "cbounidadventa"
        Me.cbounidadventa.Size = New System.Drawing.Size(135, 21)
        Me.cbounidadventa.TabIndex = 53
        Me.cbounidadventa.Visible = False
        '
        'lblunidadventa
        '
        Me.lblunidadventa.Location = New System.Drawing.Point(-424, 42)
        Me.lblunidadventa.Name = "lblunidadventa"
        Me.lblunidadventa.Size = New System.Drawing.Size(88, 13)
        Me.lblunidadventa.TabIndex = 52
        Me.lblunidadventa.Text = "U Venta :"
        Me.lblunidadventa.Visible = False
        '
        'btneliitem
        '
        Me.btneliitem.Location = New System.Drawing.Point(768, 40)
        Me.btneliitem.Name = "btneliitem"
        Me.btneliitem.Size = New System.Drawing.Size(32, 17)
        Me.btneliitem.TabIndex = 51
        Me.btneliitem.Text = "Elimina"
        Me.btneliitem.Visible = False
        '
        'btnactuitem
        '
        Me.btnactuitem.Location = New System.Drawing.Point(776, 24)
        Me.btnactuitem.Name = "btnactuitem"
        Me.btnactuitem.Size = New System.Drawing.Size(26, 17)
        Me.btnactuitem.TabIndex = 50
        Me.btnactuitem.Text = "actualiza"
        Me.btnactuitem.Visible = False
        '
        'btnnueitem
        '
        Me.btnnueitem.Location = New System.Drawing.Point(792, 40)
        Me.btnnueitem.Name = "btnnueitem"
        Me.btnnueitem.Size = New System.Drawing.Size(21, 16)
        Me.btnnueitem.TabIndex = 49
        Me.btnnueitem.Text = "Nuevo"
        Me.btnnueitem.Visible = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(72, 16)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdescripcion.Size = New System.Drawing.Size(512, 44)
        Me.txtdescripcion.TabIndex = 44
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 5
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(-728, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 23)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "..."
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Servicio :"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(-848, 39)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(89, 15)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "N Bultos :"
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(-792, 38)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(115, 21)
        Me.txttipo.TabIndex = 87
        Me.txttipo.Text = "1"
        Me.txttipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CTRLPRECIO
        '
        Me.CTRLPRECIO.Location = New System.Drawing.Point(672, 38)
        Me.CTRLPRECIO.Name = "CTRLPRECIO"
        Me.CTRLPRECIO.Size = New System.Drawing.Size(64, 21)
        Me.CTRLPRECIO.TabIndex = 89
        Me.CTRLPRECIO.Text = "0.00"
        Me.CTRLPRECIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(626, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Precio : "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(352, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 23)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbus
        '
        Me.btnbus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbus.ImageIndex = 5
        Me.btnbus.ImageList = Me.ImageList1
        Me.btnbus.Location = New System.Drawing.Point(270, 61)
        Me.btnbus.Name = "btnbus"
        Me.btnbus.Size = New System.Drawing.Size(41, 24)
        Me.btnbus.TabIndex = 96
        Me.btnbus.Text = "..."
        Me.btnbus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'lbltipodoc
        '
        Me.lbltipodoc.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipodoc.Location = New System.Drawing.Point(418, 28)
        Me.lbltipodoc.Name = "lbltipodoc"
        Me.lbltipodoc.Size = New System.Drawing.Size(169, 32)
        Me.lbltipodoc.TabIndex = 104
        Me.lbltipodoc.Text = "B0LETA"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(244, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 17)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "-"
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(584, 560)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(86, 26)
        Me.btnsalvar.TabIndex = 92
        Me.btnsalvar.Text = "Salvar    (F4)"
        Me.btnsalvar.Visible = False
        '
        'btnrestaurar
        '
        Me.btnrestaurar.Location = New System.Drawing.Point(490, 560)
        Me.btnrestaurar.Name = "btnrestaurar"
        Me.btnrestaurar.Size = New System.Drawing.Size(86, 26)
        Me.btnrestaurar.TabIndex = 95
        Me.btnrestaurar.Text = "Restaurar (F5)"
        Me.btnrestaurar.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(412, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 15)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Cod Pagador :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(138, 133)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 131
        Me.Label19.Text = "Moneda :"
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.Location = New System.Drawing.Point(188, 128)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(226, 21)
        Me.cbomoneda.TabIndex = 132
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(680, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 23)
        Me.Button5.TabIndex = 133
        Me.Button5.Text = "&Guias"
        '
        'frmfactservicio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(888, 529)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TXTNUMERODOC)
        Me.Controls.Add(Me.TXTSERIEDOC)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.txtruc)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.txtcodclie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLSIMBOLO3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnotapesada)
        Me.Controls.Add(Me.txtnroguias)
        Me.Controls.Add(Me.cbomoneda)
        Me.Controls.Add(Me.dtpfechadoc)
        Me.Controls.Add(Me.CHKIGV)
        Me.Controls.Add(Me.lblprincipal)
        Me.Controls.Add(Me.LBLSIMBOLOCAMBIO)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblcambio)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbovendedor)
        Me.Controls.Add(Me.lbloperador)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnbus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbltipodoc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnrestaurar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BTNGUIAS)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(904, 568)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(904, 568)
        Me.Name = "frmfactservicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion de Servicio"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CTRLIGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTRLSUBTOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTRLTOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTRLDESC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRTDOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private TMP_VENTADET As New DataTable

#End Region
    Private Sub FRMFACTURACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            fact_editnumero = False
            Call inicia_variables()
            Call SIMBOLOS()
            Call configuracionfacturacion()
            Call tipodocumento()
            Call CANCELAR()
            Call tmp_borra_saldos()
            CTRLSUBTOTAL.Enabled = False
            CTRLIGV2.Enabled = False
            CTRLDESC.Enabled = False
            CTRLTOTAL.Enabled = False
            Dim status As Boolean
            status = VERIFICA_PTOVTA()
            If status = False Then
                Exit Sub
            End If

            CTRLCANTIDADSERV.Text = "0.00"
            txtnotapesada.Text = 1
        Catch ex As Exception

        End Try
    End Sub
    Sub cargadatos()
        CAyuda.CargarDataCombo(cbomoneda, "nsp_sele_moneda '" & codempresa & "'", "codmon", "dsmoneda")
        'grid
        FACT_Cargagriddetalledirectoserv(Grid1, "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'")
        'FACT_Cargagriddetalledirecto(Grid1, "sp_sele_TMP_VENTADET " & VCorrelVta & "")
        'combos
        CAyuda.CargarDataCombo(cbovendedor, "sp_sele_vendedor '" & codempresa & "','" & NROPTOVTA.Trim & "'", "Codigo", "Vendedor")

        If cbovendedor.Text = "" Then
            MessageBox.Show("NO HAY VENDEDOR PARA ESTE PUNTO DE VENTA VERIFIQUE", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If

    End Sub
    Sub inicia_variables()
        lbloperador.Text = CodUsuario
        dtpfechadoc.Value = Date.Now
        Call CARGAPERMISOSUSUARIO(CodUsuario)
        If FACT_CONTROLAIGV = False Then
            CHKIGV.Visible = False
            CHKIGV.Checked = True
        Else
            CHKIGV.Visible = True
            CHKIGV.Checked = True
        End If

        'inicia_variables_ptovta()
    End Sub
    Private Sub btnbus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbus.Click
        Dim status As Boolean

        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        'If GUIA = False Then
        'FACT_NVENTANA = 1
        lblprincipal.Text = ""
        txtcodclie.Text = ""
        txtnroguias.Text = ""
        VClieDep = ""
        VCodCliente = ""
        Dim frmx As New frmgridclienteFACT
        frmx.ShowDialog()
        Call buscacliente()
        'cbovendedor.Focus()
        txtnotapesada.Focus()
        Call NUMERODOCUMENTO()
        txtruc.Focus()
        'End If
    End Sub
    Sub NUMERODOCUMENTO()
        Try
            If fact_editnumero = False Then
                Dim DS As New DataSet
                Dim SQL As String
                SQL = "SP_NUMERODOC '" & NROPTOVTA & "','" & Trim(txtruc.Text) & "','" & codempresa & "'"
                DS = TmpListarDataset(SQL)
                txtnumero.Text = DS.Tables(0).Rows(0)(1) 'numero real doc
                TXTSERIEDOC.Text = DS.Tables(0).Rows(0)(2) 'solo seria format
                TXTNUMERODOC.Text = DS.Tables(0).Rows(0)(3) 'solo numero format
                VNroDoc = CDbl(txtnumero.Text)
            End If

        Catch ex As Exception
        End Try
    End Sub
    Sub buscacliente()
        Try
            Dim ds As New DataSet
            Dim clie As String
            Dim sql As String

            If VCodCliente.Trim = "" Then
                Exit Sub
            End If
            sql = "NSP_SELE_clienteFac '" & codempresa & "','" & VCodCliente & "',0,'" & NROPTOVTA.Trim & "'"
            ds = TmpListarDataset(sql)
            If ds.Tables(0).Rows.Count = 0 Then
                txtruc.Text = ""
                txtcliente.Text = ""
                txtdireccion.Text = ""
                Exit Sub
            End If
            txtcodclie.Text = ds.Tables(0).Rows(0)(0)
            clie = ds.Tables(0).Rows(0)(1)
            txtcliente.Text = clie
            txtdireccion.Text = ds.Tables(0).Rows(0)(2)
            Dim TIPO As String
            TIPO = ds.Tables(0).Rows(0)(4)
            If TIPO = "DNI" Then
                txtruc.Text = ""
            End If
            If TIPO = "RUC" Then
                txtruc.Text = ds.Tables(0).Rows(0)(3)
            End If
            ds.Dispose()
            lblprincipal.Text = VClieDep
            If Trim(txtruc.Text) = "" Then flagfac = False
            If Trim(txtruc.Text) <> "" Then flagfac = True
            Call tipodocumento()
            If lblprincipal.Text = "" Then
                lblprincipal.Text = txtcodclie.Text
            End If
            sql = "NSP_SELE_clienteFac '" & codempresa & "','" & VClieDep & "',0,'" & NROPTOVTA.Trim & "'"
            ds = TmpListarDataset(sql)
            If ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("El cliente Pagador no tiene Vendedor Asociado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            cbovendedor.SelectedValue = ds.Tables(0).Rows(0)(5)

            Conecta("nsp_vendempleado '" & Me.txtcodclie.Text.Trim & "','" & codempresa & "'", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                cbovendedor.SelectedValue = ds.Tables(0).Rows(0)(0)
            End If

        Catch ex As Exception
        End Try
    End Sub

    Sub tipodocumento()
        If flagfac = False Then
            lbltipodoc.Text = "BOLETA"
            IGVFAC = 0
            LBLIGV.Visible = False
            CTRLIGV2.Visible = False
            lblsubtotal.Visible = False
            CTRLSUBTOTAL.Visible = False
            VCdTipoDoc = CDBOLETA
            lblsimbolo.Visible = False
            LBLSIMBOLO2.Visible = False
        Else
            lbltipodoc.Text = "FACTURA"
            VCdTipoDoc = CDFACTURA
            IGVFAC = 0
            LBLIGV.Visible = True
            CTRLIGV2.Visible = True
            lblsubtotal.Visible = True
            CTRLSUBTOTAL.Visible = True
            lblsimbolo.Visible = True
            LBLSIMBOLO2.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        If FACT_GUIA = False Then
            Call NUMERODOCUMENTO()
            Dim frmx As New FRMGRIARTICULOFACT
            frmx.vie2 = Me
            frmx.ShowDialog()
            Call MUESTRAARTICULO()
            txttipo.Focus()
        End If
    End Sub

    Sub MUESTRAARTICULO()
        Try
            Dim DS As New DataSet
            cbounidadventa.Items.Clear()
            ListBox1.Items.Clear()
            If VCodArti <> "" Then
                txtcodarticulo.Text = VCodArti
            End If
            DS = TmpListarDataset("NSP_ARTICULOPRECIOFAC_ARTICULO '" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "'")
            If DS.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("Articulo No existe Verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtcodarticulo.Text = ""
                CTRLCANTIDADSERV.Text = FACT_GFormatodeNumero(0)
                'CtrlNBultos.CtlText = FACT_GFormatodeNumero(0)
                CTRLPRECIO.Text = FACT_GFormatodeNumero(0)
                VCodArti = ""
                Exit Sub
            End If
            'If FACT_CONFIGGRID = "01" Then
            '    txtcodarticulo.Text = DS.Tables(0).Rows(0)(0)
            '    'txtdescripcion.Text = DS.Tables(0).Rows(0)(1)
            '    cbounidadventa.Items.Add(DS.Tables(0).Rows(0)(2))
            '    ListBox1.Items.Add(DS.Tables(0).Rows(0)(6))
            '    CTRLPRECIO.CtlText = FACT_GFormatodeNumero(DS.Tables(0).Rows(0)(3))
            '    cbounidadventa.Visible = False
            '    lblunidadventa.Visible = False
            '    cbounidadventa.Enabled = False
            '    ListBox1.Enabled = False
            'End If
            'If FACT_CONFIGGRID = "10" Then
            '    txtcodarticulo.Text = DS.Tables(0).Rows(0)(0)
            '    'txtdescripcion.Text = DS.Tables(0).Rows(0)(1)
            '    cbounidadventa.Items.Add(DS.Tables(0).Rows(0)(2))
            '    ListBox1.Items.Add(DS.Tables(0).Rows(0)(6))
            '    CTRLPRECIO.CtlText = FACT_GFormatodeNumero(DS.Tables(0).Rows(0)(4))
            '    cbounidadventa.Visible = False
            '    lblunidadventa.Visible = False
            '    cbounidadventa.Enabled = False
            '    ListBox1.Enabled = False
            'End If
            'If FACT_CONFIGGRID = "11" Then
            '    txtcodarticulo.Text = DS.Tables(0).Rows(0)(0)
            '    'txtdescripcion.Text = DS.Tables(0).Rows(0)(1)
            '    cbounidadventa.Items.Add(DS.Tables(0).Rows(0)(2))
            '    ListBox1.Items.Add(DS.Tables(0).Rows(0)(7))
            '    cbounidadventa.Items.Add(DS.Tables(0).Rows(0)(4))
            '    ListBox1.Items.Add(DS.Tables(0).Rows(0)(8))
            '    CTRLPRECIO.CtlText = FACT_GFormatodeNumero(DS.Tables(0).Rows(0)(3))
            '    cbounidadventa.Visible = True
            '    lblunidadventa.Visible = True
            '    cbounidadventa.Enabled = True
            '    ListBox1.Enabled = False
            'End If
            cbounidadventa.SelectedIndex = 0
            ListBox1.SelectedIndex = 0
            VCodArti = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtcodarticulo.Text = ""
            CTRLCANTIDADSERV.Text = FACT_GFormatodeNumero(0)
            'CtrlNBultos.CtlText = FACT_GFormatodeNumero(0)
            txtdescripcion.Text = ""
            CTRLPRECIO.Text = FACT_GFormatodeNumero(0)
        End Try
    End Sub
    Sub configuracionfacturacion()
        CTRLPRECIO.Enabled = FACT_EDITPRECIO
    End Sub
    Private Sub cbounidadventa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbounidadventa.SelectedIndexChanged
        If FACT_GUIA = False Then
            Dim DS As New DataSet
            'If FACT_CONFIGGRID = "11" Then
            '    If cbounidadventa.SelectedIndex = 0 Then ' unidad mayor
            '        ListBox1.SelectedIndex = 0
            '        DS = FACT_QUERY("NSP_ARTICULOPRECIOFAC_ARTICULO_UNIMED '" & ListBox1.SelectedItem & "','','" & txtcodarticulo.Text & "','" & NroPtovta & "','" & CodEmpresa & "'")
            '        txtcodarticulo.Text = DS.Tables(0).Rows(0)(0)
            '        txtdescripcion.Text = DS.Tables(0).Rows(0)(1)
            '        CTRLPRECIO.CtlText = FACT_GFormatodeNumero(DS.Tables(0).Rows(0)(3))
            '        ListBox1.SelectedItem = DS.Tables(0).Rows(0)(7)
            '        If cbounidadventa.SelectedIndex = 0 Then FACT_tipom = 0
            '        If cbounidadventa.SelectedIndex = 1 Then FACT_tipom = 1
            '    End If
            '    If cbounidadventa.SelectedIndex = 1 Then ' unidad menor
            '        ListBox1.SelectedIndex = 1
            '        DS = FACT_QUERY("NSP_ARTICULOPRECIOFAC_ARTICULO_UNIMED '','" & ListBox1.SelectedItem & "','" & txtcodarticulo.Text & "','" & NroPtovta & "','" & CodEmpresa & "'")
            '        txtcodarticulo.Text = DS.Tables(0).Rows(0)(0)
            '        txtdescripcion.Text = DS.Tables(0).Rows(0)(1)
            '        CTRLPRECIO.CtlText = FACT_GFormatodeNumero(DS.Tables(0).Rows(0)(5))
            '        ListBox1.SelectedItem = DS.Tables(0).Rows(0)(8)
            '        If cbounidadventa.SelectedIndex = 0 Then FACT_tipom = 0
            '        If cbounidadventa.SelectedIndex = 1 Then FACT_tipom = 1
            '    End If
            'End If


        End If
    End Sub
    Private Sub cbovendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbovendedor.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cbomoneda.Focus()
        End If
    End Sub
    Private Sub txtcodarticulo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodarticulo.KeyDown
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        If FACT_GUIA = False Then
            BOTONES_PRESIONADOS(sender, e)
        End If
    End Sub
    Private Sub txtcodarticulo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodarticulo.KeyPress
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If

        If FACT_GUIA = False Then
            Dim Keyascii As Short = CShort(Asc(e.KeyChar))
            If Keyascii = 13 Then
                Call MUESTRAARTICULO()
                txttipo.Focus()
            End If
        End If
    End Sub
    Sub sp_sube_tmp_saldos_importacion(ByVal Codarticulo As String)
        Dim sql As String
        sql = "sp_sube_tmp_saldos_importacion '" & Trim(Codarticulo) & "'," & VCorrelVta & ",'" & NROPTOVTA & "'"
        FACT_Cargagrid(DataGrid1, sql)
    End Sub
    Sub INSERT_TMP_DETALLE()
        Try
            If Val(CTRLCANTIDADSERV.Text) <= 0 Then
                MessageBox.Show("Cantidad no debe ser 0 ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CTRLPRECIO.Focus()
                Exit Sub
            End If
            Dim status As Boolean
            'status = verificaprecio(CTRLPRECIO.CtlText)
            'If status = False Then
            '    Exit Sub
            'End If
            '            Dim SQL As String
            '            Dim NITEM As Integer
            '            Dim MONTODESCBAS As Double
            '            Dim PORCENDESC As Double
            '            Dim M, D, A, HORA As String
            '            Call sp_sube_tmp_saldos_importacion(txtcodarticulo.Text)
            '            Dim N, I As Integer
            Dim totcantidad As Double = Val(CTRLCANTIDADSERV.Text) 'Dim NTOTALDOCUM As Double
            '            Dim IT As Integer
            '            Dim tot, j, MONTOITEMTAR As Double
            '            Dim SALDO As Double
            '            Dim tot2 As Double
            '            Dim columna As Integer ' espefico por donde descontar por bulto o por bruto
            Dim nimportacion As Long = 0
            Dim costobas As Double = 0, costoext As Double = 0 ' numero de importacion
            Dim nlote As String = ""
            Dim FHORAIMP As String = CType(Date.Now.ToShortDateString, String)
            status = insert(totcantidad, nimportacion, FHORAIMP, costobas, costoext, nlote)
            '            totcantidad = CDbl(CTRLCANTIDAD.CtlText) ' optengo la cantidad 
            '            If FACT_CONFIGGRID = "01" Then columna = 5
            '            If FACT_CONFIGGRID = "10" Then columna = 3

            '            If FACT_CONFIGGRID = "11" Then
            '                If ListBox1.SelectedIndex = 0 Then columna = 3 'unidad mayor
            '                If ListBox1.SelectedIndex = 1 Then columna = 5 'unidad menor
            '            End If


            '            While tot <= totcantidad
            '                Try
            '                    tot = tot + DataGrid1.Item(j, columna)
            '                    MONTOITEMTAR = DataGrid1.Item(j, columna)
            '                    nimportacion = DataGrid1.Item(j, 1)
            '                    costobas = DataGrid1.Item(j, 7)
            '                    costoext = DataGrid1.Item(j, 8)
            '                    FHORAIMP = DataGrid1.Item(j, 9)
            '                    FHORAIMP = Format(CDate(FHORAIMP), "MM/dd/yyyy hh:mm:ss tt")
            '                    nlote = DataGrid1.Item(j, 10)
            '                    'MsgBox(tot)
            '                    IT = j + 1
            '                Catch ex As Exception
            '                    ' CUANDO YA NO HAY EN SALDOS_IMPORTACION COMIENZO EL INGRESO DE SALDOS NEGATIVOS
            '                    '    MessageBox.Show("La Cantidad es Mayor al Monto Verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '                    '   Exit Sub
            '                    status = insert(totcantidad, 0, FHORAIMP, 0, 0, 0)
            '                    Dim NITE As Integer
            '                    SQL = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
            '                    Dim ds As New DataSet
            '                    ds = FACT_QUERY(SQL)
            '                    NITE = ds.Tables(0).Rows.Count
            '                    SQL = "SP_insert_TMP_saldosimportacion_negativos '" & txtcodarticulo.Text & "','" & NroPtovta & "'," & CTRLCANTIDAD.CtlText & "," & VCorrelVta & "," & columna & "," & NITE & ""
            '                    status = FACT_Procesa(SQL)
            '                    Exit Sub
            '                End Try
            '                If CDbl(tot) >= CDbl(totcantidad) Then ' el monto completo 
            '                    If tot <> 0 Then
            '                        SALDO = tot - totcantidad
            '                        SQL = "SP_UPDATE_TMP_saldos_importacion '" & txtcodarticulo.Text & "'," & nimportacion & ", " & columna & "," & SALDO & "," & VCorrelVta & ",'" & NroPtovta & "','" & FHORAIMP & "'"
            '                        Call FACT_Procesa(SQL)
            '                        Call sp_sube_tmp_saldos_importacion(txtcodarticulo.Text)
            '                        GoTo GRABAUNAVUELTA
            '                    End If
            '                Else
            'SIGUEGRABANDO:
            '                    If tot <> 0 Then
            '                        SALDO = tot - totcantidad
            '                        If SALDO < 0 Then SALDO = 0
            '                        SQL = "SP_UPDATE_TMP_saldos_importacion '" & txtcodarticulo.Text & "'," & nimportacion & ", " & columna & "," & SALDO & "," & VCorrelVta & ",'" & NroPtovta & "','" & FHORAIMP & "'"
            '                        Call FACT_Procesa(SQL)
            '                        Call sp_sube_tmp_saldos_importacion(txtcodarticulo.Text)
            '                        Dim diferencia As Double
            '                        diferencia = tot - totcantidad
            '                        If diferencia < 0 Then diferencia = diferencia * -1
            '                        CTRLCANTIDAD.CtlText = diferencia
            '                        status = insert(tot, nimportacion, FHORAIMP, costobas, costoext, nlote)
            '                        'j = j + 1
            '                        GoTo SIGUIENTE
            '                    End If
            '                End If
            'GRABAUNAVUELTA:
            '                If tot <> 0 Then

            '                    Call LIMPIA_DATOSDOC()
            '                    'GoTo SIGUEGRABANDO
            '                    'Call INICIACONTROLNUMBER()
            '                    CTRLPRECIO.CtlText = FACT_GFormatodeNumero(0)
            '                    CTRLCANTIDAD.CtlText = FACT_GFormatodeNumero(0)
            '                    Exit While
            '                End If
            'SIGUIENTE:
            '                tot2 = tot
            '                tot = 0
            '                MONTOITEMTAR = 0
            '                If CDbl(SALDO) = 0 Then
            '                    j = j + 1
            '                Else
            '                    If CDbl(SALDO) > CDbl(CTRLCANTIDAD.CtlText) Then
            '                        j = j - 1
            '                    End If
            '                    If j = -1 Then j = 0
            '                End If
            '                '------------------------------------------------------------------------------
            '                totcantidad = CDbl(CTRLCANTIDAD.CtlText)
            '            End While
            '            Call LIMPIA_DATOSDOC()
            '            CTRLPRECIO.CtlText = FACT_GFormatodeNumero(0)
            '            CTRLCANTIDAD.CtlText = FACT_GFormatodeNumero(0)
        Catch ex As Exception
        End Try
    End Sub

    Function insert(ByVal cantidad As Double, ByVal NROIMPORTACION As Long, ByVal FHORAIMP As String, ByVal COSTOBAS As Double, ByVal COSTOEXT As Double, ByVal nlote As String) As Boolean
        Try
            'If Val(CTRLCANTIDAD.CtlText) <= 0 Then
            'MessageBox.Show("Cantidad no debe ser 0 ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'CTRLPRECIO.Focus()
            'Exit Sub
            'End If
            Dim SQL As String
            Dim NITEM As Integer
            Dim MONTODESCBAS As Double
            Dim PORCENDESC As Double
            'Dim M, D, A, HORA As String
            Dim FECHA As DateTime
            FECHA = Now
            Dim FECHA2, fecha565 As String
            'SQL = "sp_sube_tmp_saldos_importacion '" & Trim(txtcodarticulo.Text) & "'"
            'FACT_Cargagrid(DataGrid1, SQL)
            FECHA2 = Format(FECHA, "dd/MM/yyyy")
            fecha565 = Format(CDate(FHORAIMP), "dd/MM/yyyy")
            MONTODESCBAS = 0
            PORCENDESC = 0
            SQL = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
            Dim ds As New DataSet
            ds = TmpListarDataset(SQL)
            NITEM = ds.Tables(0).Rows.Count + 1
            Dim desmed As String
            desmed = CDbl(txttipo.Text)
            SQL = "SP_INSERT_VTADET_TMPSERV '" & VCdTipoDoc & "'," & txtnumero.Text & "," & NITEM & "," & cantidad & "," & CTRLPRECIO.Text & ",'" & FECHA2 & "','" & CodUsuario & "'," & MONTODESCBAS & "," & PORCENDESC & ",'" & NROPTOVTA & "'," & FACT_tipom & ",'" & codempresa & "'," & VCorrelVta & "," & NROIMPORTACION & ",'" & fecha565 & "'," & COSTOBAS & "," & COSTOEXT & "," & 0 & ",'" & nlote.Trim & "','" & Me.txtdescripcion.Text.Trim & "','" & FACT_CDMONEDA & "'"
            Dim afec As Boolean
            afec = TmpInsertDatos(SQL)
            Call actuadetalle()
        Catch ex As Exception
        End Try

    End Function
    Private Sub cbounidadventa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbounidadventa.KeyPress
        If FACT_GUIA = False Then
            Dim Keyascii As Short = CShort(Asc(e.KeyChar))
            If Keyascii = 13 Then
                If Val(CTRLCANTIDADSERV.Text) <= 0 Then
                    CTRLPRECIO.Focus()
                    Exit Sub
                End If
                Call INSERT_TMP_DETALLE()
                Call LIMPIA_DATOSDOC()
            End If
        End If
    End Sub
    Sub actuadetalle()
        'FACT_Cargagriddetalledirecto(Grid1, "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'")

        TMP_VENTADET = TmpListarDatos("sp_sele_TMP_VENTADET  '" & VCorrelVta & "','" & codempresa & "'")
        Grid1.DataSource = TMP_VENTADET
        FormatoGridDetVta()

        Call CALCULO(True)
        Call FORMATOCONTROLNUMBER()

        'Dim TABLA As New DataTable
        'TABLA = CAyuda.ListarDatos("sp_sele_TMP_VENTADET ", VCorrelVta, codempresa).Tables(0)
        'DataGridView1.DataSource = TABLA

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


    Sub BORRA_TEMPORALES()
        TmpInsertDatos("LIMPIA_TMP_VENTA  " & VCorrelVta & "")
    End Sub
    Sub LIMPIA_DATOSDOC()
        'txtcodarticulo.Text = ""
        'txtdescripcion.Text = ""
        lblunidadventa.Visible = False
        cbounidadventa.Visible = False
        txtcodarticulo.Focus()
        CTRLCANTIDADSERV.Text = FACT_GFormatodeNumero(0)
        CTRLPRECIO.Text = FACT_GFormatodeNumero(0)
        'Me.CtrlNBultos.CtlText = FACT_GFormatodeNumero(0)
        txttipo.Text = ""
    End Sub
    Private Sub btndsctoitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndsctoitem.Click
        Dim status As Boolean
        status = validanumerodoc(Val(txtnumero.Text), txtruc.Text)
        If status = False Then
            Exit Sub
        End If
        If verificaitemdeingreso() = False Then
            Exit Sub
        End If
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Try
            'Dim x As Integer
            VTotBas = Val(Grid1.Item(Grid1.CurrentRowIndex, 5)) * Val(Grid1.Item(Grid1.CurrentRowIndex, 4))
            Dim frmx As New frmdescitem
            VItemDoc = Grid1.Item(Grid1.CurrentRowIndex, 0)
            VCodArti = Grid1.Item(Grid1.CurrentRowIndex, 1)
            VCantidad = Grid1.Item(Grid1.CurrentRowIndex, 4)
            VPrecioVta = Grid1.Item(Grid1.CurrentRowIndex, 5)
            VFecDocum = Grid1.Item(Grid1.CurrentRowIndex, 10)
            VTipoMedida = Grid1.Item(Grid1.CurrentRowIndex, 9)

            frmx.ShowDialog()
            Call actuadetalle()
        Catch ex As Exception
        End Try
    End Sub
    Sub CALCULO(ByVal calculalineas As Boolean)
        Dim N, I As Integer
        Dim ds As New DataSet
        Dim sql As String
        Dim TOT, IGV, SUBT As Double
        Dim nitem As Integer
        Try
            If calculalineas = False Then
                sql = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
                ds = TmpListarDataset(sql)
                CTRLDESC.CtlText = FACT_GFormatodeNumero(VDescTotbas)
                N = ds.Tables(0).Rows.Count - 1
                For I = 0 To N
                    TOT = CDbl(TOT) + CDbl(Grid1.Item(I, 6))
                Next I

                If CHKIGV.Checked = True Then
                    TOT = CDbl(TOT) - ((CDbl(CTRLDESC.CtlText) / 100) * TOT)
                    For I = 0 To N
                        IGV = CDbl(IGV) + CDbl(Grid1.Item(I, 7))
                    Next I
                    SUBT = CDbl(TOT) - IGV
                    'SUBT = CDbl(TOT) / (1 + (CDbl(FACT_PORCIGV) / 100))
                    'IGV = CDbl(SUBT) * (CDbl(FACT_PORCIGV) / 100)
                Else
                    TOT = CDbl(TOT) - ((CDbl(CTRLDESC.CtlText) / 100) * TOT)
                    SUBT = TOT
                    IGV = 0
                End If

                CTRLTOTAL.CtlText = TOT
                CTRLSUBTOTAL.CtlText = SUBT
                CTRLIGV2.CtlText = IGV
                VTotBas = CTRLTOTAL.CtlText
            End If


            If calculalineas = True Then
                If Trim(txtruc.Text) = "" Then
                    nitem = ITEMDEBOLETA
                End If
                If Trim(txtruc.Text) <> "" Then
                    nitem = ITEMDEFACT
                End If
                ds = Nothing
                sql = "select sum(totbas),sum(IGVBAS) from tmp_ventadet where CORRNBR=" & VCorrelVta & " and item between 1 and " & nitem & ""
                ds = TmpListarDataset(sql)
                If ds.Tables(0).Rows.Count > 0 Then
                    Try
                        TOT = ds.Tables(0).Rows(0)(0)
                        IGV = ds.Tables(0).Rows(0)(1)
                    Catch ex As Exception
                        TOT = 0
                        IGV = 0
                    End Try

                    If CHKIGV.Checked = True Then
                        TOT = CDbl(TOT) - ((CDbl(CTRLDESC.CtlText) / 100) * TOT)
                        '                        SUBT = CDbl(TOT) / (1 + (CDbl(FACT_PORCIGV) / 100))
                        '                       IGV = CDbl(SUBT) * (CDbl(FACT_PORCIGV) / 100)
                        SUBT = CDbl(TOT) - CDbl(IGV)
                    Else
                        TOT = CDbl(TOT) - ((CDbl(CTRLDESC.CtlText) / 100) * TOT)
                        SUBT = TOT
                        IGV = 0
                    End If

                    CTRLTOTAL.CtlText = TOT
                    CTRLSUBTOTAL.CtlText = SUBT
                    CTRLIGV2.CtlText = IGV
                    VTotBas = CTRLTOTAL.CtlText
                End If
            End If


            'Dim ds2 As New DataSet
            'sql = "select SUM(IGVBAS) from tmp_ventadet where CORRNBR=" & VCorrelVta & ""
            'ds2 = TmpListarDataset(sql)
            'IGV = ds2.Tables(0).Rows(0)(0)

            'CTRLIGV2.CtlText = IGV


            Dim tmoneda As String = ""
            If Trim(FACT_CDMONEDA) = "S" Then tmoneda = "Nuevos Soles"
            If Trim(FACT_CDMONEDA) = "D" Then tmoneda = "Dolares "
            lbltotalletras.Text = StrConv(FACT_TotalLetras(CTRLTOTAL.CtlText, tmoneda), 3)
            Call FORMATOCONTROLNUMBER()





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub INICIACONTROLNUMBER()
        Try
            CTRLSUBTOTAL.Enteros = 9
            CTRLSUBTOTAL.Decimales = DECIRESU
            CTRLSUBTOTAL.ValorPorDefecto()

            CTRLIGV2.Enteros = 9
            CTRLIGV2.Decimales = DECIRESU
            CTRLIGV2.ValorPorDefecto()

            CTRLDESC.Enteros = 9
            CTRLDESC.Decimales = DECIRESU
            CTRLDESC.ValorPorDefecto()

            CTRLTOTAL.Enteros = 9
            CTRLTOTAL.Decimales = DECIRESU
            CTRLTOTAL.ValorPorDefecto()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CTRLCANTIDAD_KeyPressEvent(ByVal sender As System.Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent)
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If

        CTRLPRECIO.Focus()

        If FACT_GUIA = False Then
            Try
                CTRLCANTIDADSERV.Focus()
                If e.keyAscii = 13 Then
                    If Val(CTRLCANTIDADSERV.Text) <= 0 Then
                        MessageBox.Show("Cantidad no debe ser 0 ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        CTRLCANTIDADSERV.Focus()
                        Exit Sub
                    End If
                    If CTRLPRECIO.Enabled = True Then
                        CTRLPRECIO.Focus()
                    Else
                        If cbounidadventa.Visible = True Then
                            cbounidadventa.Focus()
                        End If
                        If cbounidadventa.Visible = False Then
                            Call INSERT_TMP_DETALLE()
                            Call LIMPIA_DATOSDOC()
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub FORMATOCONTROLNUMBER()
        'CTRLCANTIDADSERV.Enteros = 9
        'CTRLCANTIDADSERV.Decimales = DECIRESU
        ''CTRLCANTIDAD.ValorPorDefecto()

        'CTRLPRECIO.Enteros = 9
        'CTRLPRECIO.Decimales = DECIRESU
        ''CTRLPRECIO.ValorPorDefecto()

        CTRLSUBTOTAL.Enteros = 9
        CTRLSUBTOTAL.Decimales = DECIRESU
        CTRLSUBTOTAL.CtlText = FACT_GFormatodeNumero(CTRLSUBTOTAL.CtlText)

        CTRLIGV2.Enteros = 9
        CTRLIGV2.Decimales = DECIRESU
        CTRLIGV2.CtlText = FACT_GFormatodeNumero(CTRLIGV2.CtlText)

        CTRLDESC.Enteros = 9
        CTRLDESC.Decimales = DECIRESU
        CTRLDESC.CtlText = FACT_GFormatodeNumero(CTRLDESC.CtlText)

        CTRLTOTAL.Enteros = 9
        CTRLTOTAL.Decimales = DECIRESU
        CTRLTOTAL.CtlText = FACT_GFormatodeNumero(CTRLTOTAL.CtlText)
    End Sub
    Private Sub btndsctototal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndsctototal.Click
        Dim status As Boolean

        status = validanumerodoc(Val(txtnumero.Text), txtruc.Text)
        If status = False Then
            Exit Sub
        End If


        If verificaitemdeingreso() = False Then
            Exit Sub
        End If


        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim ds As New DataSet
        Dim sql As String
        sql = "sp_sele_TMP_VENTADET" & VCorrelVta & ",'" & codempresa & "'"
        ds = TmpListarDataset(sql)
        Try
            Dim N, I As Integer
            N = ds.Tables(0).Rows.Count - 1
            Dim TOT As Double
            For I = 0 To N
                TOT = CDbl(TOT) + Val(Grid1.Item(I, 5)) * Val(Grid1.Item(I, 4))
            Next I
            VTotBas = CDbl(TOT)
        Catch ex As Exception
        End Try
        Dim frmx As New FRMDESCTOTAL
        frmx.ShowDialog()
        Call CALCULO(False)
    End Sub
    Sub SIMBOLOS()
        Dim SQL As String
        Dim DS As New DataSet
        SQL = "SELECT SIMBOLO FROM MONEDA WHERE CODMON='" & Trim(FACT_CDMONEDA) & "'"
        DS = TmpListarDataset(SQL)
        FACT_SIMBOLOMON = DS.Tables(0).Rows(0)(0)
        lblsimbolo.Text = FACT_SIMBOLOMON
        LBLSIMBOLO2.Text = FACT_SIMBOLOMON
        LBLSIMBOLO3.Text = FACT_SIMBOLOMON
        LBLSIMBOLO4.Text = FACT_SIMBOLOMON
        DS = Nothing
        SQL = "select simbolo from moneda where codmon=(select CDMONEXTR from configsis where COD_EMPRESA='" & codempresa & "')"
        DS = TmpListarDataset(SQL)
        FACT_SIMBOLOMONEXTR = DS.Tables(0).Rows(0)(0)
        LBLSIMBOLOCAMBIO.Text = FACT_SIMBOLOMONEXTR
        DS = Nothing
        SQL = "SP_CAMBIODELDIA '" & codempresa & "'"
        DS = TmpListarDataset(SQL)
        VCambioVta = DS.Tables(0).Rows(0)(0)
        lblcambio.Text = FACT_GFormatodeNumero(CDbl(VCambioVta))

    End Sub
    Private Sub btnefectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnefectivo.Click

        'Dim status As Boolean
        'pasanumerodoc()
        'status = validanumerodoc(Val(txtnumero.Text), txtruc.Text)
        'If status = False Then
        '    Exit Sub
        'End If
        'If verificaitemdeingreso() = False Then
        '    Exit Sub
        'End If
        'status = VERIFICA_PTOVTA()
        'If status = False Then
        '    Exit Sub
        'End If
        'status = verificanotapesada("SERVICIOS")
        'If status = False Then
        '    Exit Sub
        'End If
        'VClieDep = lblprincipal.Text

        'Try
        '    'Dim status As Boolean
        '    If CDbl(CTRLTOTAL.CtlText) <= 0 Then
        '        MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Sub
        '    End If
        '    If Trim(txtruc.Text) <> "" Then
        '        status = FACT_GValidaRUC(Trim(txtruc.Text))
        '        If status = False Then
        '            Exit Sub
        '        End If
        '    End If

        '    Dim SQL As String
        '    Dim NDOCUMENTO As Integer
        '    Dim DS As New DataSet
        '    Dim N As Integer

        '    SQL = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
        '    DS = TmpListarDataset(SQL)
        '    N = DS.Tables(0).Rows.Count  ' OBTENGO EL NUMERO DEL DETALLE
        '    If txtruc.Text.Trim = "" Then
        '        NDOCUMENTO = Math.Ceiling(N / ITEMDEBOLETA)
        '        If NDOCUMENTO > 1 Then
        '            MessageBox.Show("EL NUMERO DE ITEMS CONFIGURADO PARA LA BOLETA ES " & ITEMDEBOLETA & " ITEMS Y SU DETALLE DE DOCUMENTO TIENE " & N & " ITEMS PASE LOS ITEMS SOBRANTES A UN NUEVO DOCUMENTO ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            Exit Sub
        '        End If
        '    End If

        '    If txtruc.Text.Trim <> "" Then
        '        NDOCUMENTO = Math.Ceiling(N / ITEMDEFACT)
        '        If NDOCUMENTO > 1 Then
        '            MessageBox.Show("EL NUMERO DE ITEMS CONFIGURADO PARA LA FACTURA ES " & ITEMDEFACT & " ITEMS Y SU DETALLE DE DOCUMENTO TIENE " & N & " ITEMS PASE LOS ITEMS SOBRANTES A UN NUEVO DOCUMENTO ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            Exit Sub
        '        End If
        '    End If

        '    ' obtengo el numero de documentos a generar
        '    VCodCliente = txtcodclie.Text
        '    VRuc = Trim(txtruc.Text)
        '    VDescliente = txtcliente.Text
        '    VDireccion = txtdireccion.Text
        '    VPorcenDesc = CTRLDESC.CtlText
        '    VNroDoc = txtnumero.Text
        '    VTotBas = CTRLTOTAL.CtlText
        '    VTotExt = CDbl(CTRLTOTAL.CtlText) / CDbl(lblcambio.Text)
        '    If lblprincipal.Text = "" Then
        '        lblprincipal.Text = txtcodclie.Text
        '        VClieDep = lblprincipal.Text
        '    End If
        '    Dim frmx As New frmpagoefectivo
        '    frmx.estado = False
        '    frmx.VIE2 = Me
        '    frmx.ShowDialog()
        'Catch ex As Exception
        'End Try

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

        If cbovendedor.SelectedValue Is Nothing Then
            MsgBox("no hay vendedores")
            Exit Sub
        End If

        'If rbboleta.Checked = True Then
        '    If TxtTOTAL.Text > PREC_BOLETA Then
        '        MsgBox("PRECIO BOLETA SOBRESALE")
        '        Exit Sub
        '    End If
        'End If

        'If rbfactura.Checked = True Then
        '    If TxtTOTAL.Text > PREC_FACTURA Then
        '        MsgBox("PRECIO FACTURA SOBRESALE")
        '        Exit Sub
        '    End If
        'End If

        'If rbnotap.Checked = True Then
        '    If TxtTOTAL.Text > PREC_NOTAPEDIDO Then
        '        MsgBox("PRECIO NOTA PEDIDO SOBRESALE")
        '        Exit Sub
        '    End If
        'End If

        Dim TABLE1 As New DataTable
        TABLE1 = TmpListarDatos("NSP_BUSCAR_FACTURACION  '" & codempresa & "','" & VNroDoc & "','" & VCdTipoDoc & "','" & VCorrelVta & "'")
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

        '/**********NOTA PEDIDO******************************************************************************************/

        Dim dt_TABLA As New DataTable
        dt_TABLA = CAyuda.ListarDatos("SP_CONFIG_NPTIENDA", codempresa.Trim).Tables(0)
        Dim MONTONP As Double
        If dt_TABLA.Rows.Count > 0 Then

            MONTONP = CDbl(dt_TABLA.Rows(0)(0))
        End If

        Dim dt_TABLA2 As New DataTable
        dt_TABLA2 = CAyuda.ListarDatos("SP_SELECT_TMP_VENTADETFD", CInt(VCorrelVta)).Tables(0)

        If dt_TABLA2.Rows.Count > 0 Then
            For i As Integer = 0 To dt_TABLA2.Rows.Count - 1
                If CStr(VCdTipoDoc) = "01" Or CStr(VCdTipoDoc) = "03" Then
                    If CDbl(dt_TABLA2.Rows(i)(0)) >= MONTONP Then
                        MsgBox("Producto no permitido para este Tipo Doc utilice NP")
                        Exit Sub
                    End If
                End If

            Next
        End If



        '/****************************************************************************************************/
        btnefectivo.Enabled = False

        Dim TABLE_VALIDARM As New DataTable
        TABLE_VALIDARM = TmpListarDatos("SP_VALIDAR_MONTODOC  '" & codempresa & "','" & VCdTipoDoc & "'  ")
        If TABLE_VALIDARM.Rows.Count > 0 Then
            If CDbl(CTRLTOTAL.CtlText) > CDbl(TABLE_VALIDARM.Rows(0)(0).ToString) Then
                MsgBox("El total es mayor al monto por documento")
                Exit Sub
            End If
        End If

        If txtcodclie.Text.Trim.Length = 0 Then
            MsgBox("NO INGRESO EL CODIGO DEL CLIENTE")
            Exit Sub
        Else
            VClieDep = txtcodclie.Text.Trim
        End If

        Dim status As Boolean
        pasanumerodoc()
        If verificaitemdeingreso() = False Then
            Exit Sub
        End If
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If

        'If TIPO_PTOVTA <> 1 Then
        '    status = verificanotapesada(txtnotapesada.Text)
        'End If
        'If status = False Then
        '    Exit Sub
        'End If

        Try
            'Dim status As Boolean
            If CDbl(CTRLTOTAL.CtlText) <= 0 Then
                MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            Dim frm9 As New FrmMsgAvisos
            frm9.lbCuerpo.Text = "Nro. " & Me.TXTSERIEDOC.Text.Trim & "-" & Me.TXTNUMERODOC.Text.Trim
            frm9.ShowDialog()

            If frm9.DEVOLVER = False Then
                Exit Sub
            End If

            If Trim(txtruc.Text) <> "" And lbltipodoc.Text = "FACTURA" Then
                status = FACT_GValidaRUC(Trim(txtruc.Text))
                If status = False Then
                    Exit Sub
                End If
            End If

            Dim SQL As String
            Dim NDOCUMENTO As Integer
            Dim DS As New DataSet
            Dim N As Integer

            SQL = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
            DS = TmpListarDataset(SQL)
            N = DS.Tables(0).Rows.Count  ' OBTENGO EL NUMERO DEL DETALLE
            If txtruc.Text.Trim = "" Then
                NDOCUMENTO = Math.Ceiling(N / TMP_VENTADET.Rows.Count)
                If NDOCUMENTO > 1 Then
                    MessageBox.Show("EL NUMERO DE ITEMS CONFIGURADO PARA LA BOLETA ES " & ITEMDEBOLETA & " ITEMS Y SU DETALLE DE DOCUMENTO TIENE " & N & " ITEMS PASE LOS ITEMS SOBRANTES A UN NUEVO DOCUMENTO ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            If txtruc.Text.Trim <> "" Then
                NDOCUMENTO = Math.Ceiling(N / TMP_VENTADET.Rows.Count)
                If NDOCUMENTO > 1 Then
                    MessageBox.Show("EL NUMERO DE ITEMS CONFIGURADO PARA LA FACTURA ES " & ITEMDEFACT & " ITEMS Y SU DETALLE DE DOCUMENTO TIENE " & N & " ITEMS PASE LOS ITEMS SOBRANTES A UN NUEVO DOCUMENTO ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If


            If CTRLDESC.Text.Length = 0 Then
                CTRLDESC.Text = 0
            End If

            ' obtengo el numero de documentos a generar
            VCodCliente = txtcodclie.Text
            VDescliente = txtcliente.Text
            VDireccion = txtdireccion.Text
            VDescTotbas = CTRLDESC.Text
            VTotBas = CDbl(CTRLTOTAL.CtlText)
            VTotExt = CDbl(CTRLTOTAL.CtlText) / CDbl(lblcambio.Text)
            VRuc = Trim(txtruc.Text)
            If VCdTipoDoc = CDFACTURA Then
                status = FACT_GValidaRUC(Trim(txtruc.Text))
                If status = False Then
                    Exit Sub
                End If
            End If

            If ACTIVACAJA = True Then
                Dim fechadocum As Date
                fechadocum = Format(dtpfechadoc.Value, "dd/MM/yyyy")
                'If GRABAEFECTIVOS(VCdPagEfectivo, fechadocum) = True Then
                '    'CAyuda.Ejecutar("NSP_ACTUALIZAR_STOCK_FACT", codempresa.Trim, CInt(CTRLCANTIDAD.Text.Trim))
                'End If

                If CAyuda.Ejecutar("Nsp_grabadocumentoFT", nroguia, "", "True", VCorrelVta, 0, lblprincipal.Text, VCdPagEfectivo, VCdTipoDoc, VNroDoc, cbomoneda.SelectedValue, VCambioVta, cbovendedor.SelectedValue, dtpfechadoc.Value, CDbl(CTRLTOTAL.CtlText), VPorcenDesc, 0, CDbl(CTRLTOTAL.CtlText), 0, txtcodclie.Text, txtruc.Text, txtcliente.Text, txtdireccion.Text, CodUsuario, codempresa, cbomoneda.SelectedValue, NROPTOVTA, VCorrelVta, "01") > 0 Then
                End If

                '''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''
                '''''FACTURACION ELECTRONICA ENVIO BASE''''''
                '''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''

                Dim LETRADOC As String
                Dim TipoDoc As String
                TipoDoc = VCdTipoDoc
                VRuc = txtruc.Text
                VCodCliente = txtcodclie.Text
                VNroDoc = VNroDoc

                If EMIELECTRONIC = True Then
                    If TipoDoc.Trim = "01" Or TipoDoc.Trim = "03" Then

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
                            CLIE_DOCU = VRuc
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

                        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO  '" & TipoDoc & "','" & VNroDoc & "'  ")

                        If TABLA_INAFECTO.Rows.Count > 0 Then
                            dblTOTINAFECTO = CDbl(FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString)
                        End If

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
                        nuevohdocumento.clie_docu = IIf(CStr(VRuc.Trim) <> "", CStr(VRuc.Trim), DNI)
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
                        nuevohdocumento.ValorResumen = "d"
                        nuevohdocumento.ValorHash = ""
                        nuevohdocumento.DarBaja = 0
                        nuevohdocumento.MotivoBaja = ""
                        nuevohdocumento.ProcesarBaja = 0
                        nuevohdocumento.Grabado = SUBTOTAL - dblTOTINAFECTO
                        nuevohdocumento.IGV = IGV
                        nuevohdocumento.Total = CDbl(CTRLTOTAL.CtlText)
                        nuevohdocumento.dire_lleg = ""
                        nuevohdocumento.Guia_trans = ""
                        nuevohdocumento.Envio_xml = 0
                        nuevohdocumento.Clie_tipo = IIf(CStr(VRuc.Trim) <> "", 6, 1)
                        nuevohdocumento.Fact_guia = "NO"
                        nuevohdocumento.Exonerado = 0
                        nuevohdocumento.Inafecto = dblTOTINAFECTO
                        nuevohdocumento.percepcion = PERCEP


                        Dim CODCAB As Integer
                        CODCAB = gestordefacturacionelectronica.CrearHdocumento(nuevohdocumento).codi_cab

                        Dim StrSql As String
                        StrSql = "SELECT TMP_VENTADET.ITEM,TMP_VENTADET.CODARTI, TMP_VENTADET.DESARTI, TMP_VENTADET.PRECIO, " &
                             "  TMP_VENTADET.CANTIDAD,  TMP_VENTADET.SUBTOTBAS, '01' AS TIPOPRE," &
                                   "  TMP_VENTADET.TOTBAS, TMP_VENTADET.IGVBAS,(TMP_VENTADET.SUBTOTBAS/TMP_VENTADET.CANTIDAD) AS PRECSINIGV," &
                                   "   TMP_VENTADET.MONTODESCBAS ,TMP_VENTADET.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC " &
                             " FROM ARTICULO INNER JOIN TMP_VENTADET ON ARTICULO.CODARTI = TMP_VENTADET.CODARTI" &
                              " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                          "  INNER JOIN PRESENTACION ON PRESENTACION.codpres = TMP_VENTADET.CODPRES" &
                        " WHERE TMP_VENTADET.CORRNBR = " & CInt(VCorrelVta) & " ORDER BY TMP_VENTADET.ITEM "

                        Dim Tabla_Tmp As DataTable
                        Tabla_Tmp = TmpListarDatos(StrSql)

                        If Tabla_Tmp.Rows.Count > 0 Then
                            For x As Integer = 0 To Tabla_Tmp.Rows.Count - 1
                                Dim nuevoddocumento As New NuevaDDocumento
                                nuevoddocumento.id = 1
                                nuevoddocumento.prod_codi = Tabla_Tmp.Rows(x)("CODARTI")
                                nuevoddocumento.prod_descr = Tabla_Tmp.Rows(x)("DESARTI")
                                nuevoddocumento.prod_unid = Tabla_Tmp.Rows(x)("CODFACELEC")
                                nuevoddocumento.prod_precio = Tabla_Tmp.Rows(x)("PRECIO")
                                nuevoddocumento.prod_desct = Tabla_Tmp.Rows(x)("MONTODESCBAS")
                                nuevoddocumento.prod_cant = Tabla_Tmp.Rows(x)("CANTIDAD")
                                nuevoddocumento.igv = Tabla_Tmp.Rows(x)("IGVBAS")
                                nuevoddocumento.percepcion = PERCEP
                                nuevoddocumento.codi_cab = CODCAB
                                nuevoddocumento.tipo_igv = IIf(CDbl(Tabla_Tmp.Rows(x)("IGVBAS")) <> 0, "IGV", "INA")
                                nuevoddocumento.obse = "AAAAA"
                                gestordefacturacionelectronica.CrearDdocumento(nuevoddocumento)
                            Next
                        End If
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        '''''''' VERIFICO SI SE ENVIO A SUNAT O CORRECTAMENTE '''''''''
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                        gestordefacturacionelectronica.ModificarEstado(SERIE, NRODOCSIN)


                    End If
                End If
                CAyuda.Ejecutar("SP_DELETE_TMP_VENTADET", CodUsuario, CInt(VCorrelVta))

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''' VERIFICO SI SE ENVIO A SUNAT O CORRECTAMENTE '''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



                Dim TIPODOCUMENTO As String
                ' Dim LETRADOC As String

                If VCdTipoDoc = "01" Then
                    TIPODOCUMENTO = "FACTURA DE VENTA ELECTRONICA"
                    LETRADOC = "F"
                End If

                If VCdTipoDoc = "03" Then
                    TIPODOCUMENTO = "BOLETA DE VENTA ELECTRONICA"
                    LETRADOC = "B"
                End If

                If VCdTipoDoc = "06" Then
                    TIPODOCUMENTO = "NOTA PEDIDO"
                    LETRADOC = "P"
                End If

                Dim INAFECTO As String

                TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO_HISTO  '" & codempresa.Trim & "','" & VCdTipoDoc.Trim & "','" & VNroDoc & "','" & Format(CDate(dtpfechadoc.Value), "dd/MM/yyyy") & "'")

                If TABLA_INAFECTO.Rows.Count > 0 Then
                    INAFECTO = FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString
                End If

                Dim AFECTO As String
                Dim TABLA_AFECTO As New DataTable
                TABLA_INAFECTO = TmpListarDatos("SP_SUMA_AFECTO_HISTO  '" & codempresa.Trim & "','" & VCdTipoDoc.Trim & "','" & VNroDoc & "','" & Format(CDate(dtpfechadoc.Value), "dd/MM/yyyy") & "'")
                If TABLA_INAFECTO.Rows.Count > 0 Then
                    AFECTO = FACT_GMascara(TABLA_INAFECTO.Rows(0)("AFECTO").ToString.Trim, 2).ToString
                End If


                Dim StrMonLet As String






                If VCdTipoDoc = CDFACTURA.Trim Then
                    StrMonLet = FACT_TotalLetras(CDbl(CDbl(CTRLTOTAL.CtlText)), "SOLES")
                    CRTDOC.WindowShowExportBtn = True
                    CRTDOC.WindowShowPrintBtn = True
                    CRTDOC.WindowShowPrintSetupBtn = True
                    CRTDOC.set_StoredProcParam(0, codempresa)
                    CRTDOC.set_StoredProcParam(1, VCdTipoDoc)
                    CRTDOC.set_StoredProcParam(2, VNroDoc)
                    CRTDOC.set_StoredProcParam(3, CStr(fechadocum))

                    CRTDOC.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                    CRTDOC.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & TIPODOCUMENTO & "'")
                    CRTDOC.set_Formulas(2, "FNombre='" & GHEAD1 & "'")
                    CRTDOC.set_Formulas(3, "FRuc='" & GHEAD3 & "'")
                    CRTDOC.set_Formulas(4, "FDireccion='" & GHEAD4 & "'")
                    CRTDOC.set_Formulas(5, "FUbicacion='" & GHEAD5 & "'")
                    CRTDOC.set_Formulas(6, "FInafecto='" & INAFECTO & "'")
                    CRTDOC.set_Formulas(7, "FGravadas='" & AFECTO & "'")
                    CRTDOC.set_Formulas(8, "FExoneradas='" & 0.0 & "'")
                    CRTDOC.ReportFileName = rutareporte + CType("Rpt_FacturaFE.rpt", String)
                    CRTDOC.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    'If ChkImpresora.CheckState = CheckState.Checked Then
                    '    CRTDOC.Destination = Crystal.DestinationConstants.crptToWindow
                    'Else
                    '    CRTDOC.Destination = Crystal.DestinationConstants.crptToPrinter
                    'End If
                    CRTDOC.Destination = Crystal.DestinationConstants.crptToWindow

                    CRTDOC.WindowState = Crystal.WindowStateConstants.crptMaximized
                    CRTDOC.Action = 1
                    CRTDOC.Reset()
                ElseIf VCdTipoDoc = CDBOLETA.Trim Then
                    StrMonLet = FACT_TotalLetras(CDbl(CTRLTOTAL.CtlText), "SOLES")
                    CRTDOC.WindowShowExportBtn = True
                    CRTDOC.WindowShowPrintBtn = True
                    CRTDOC.WindowShowPrintSetupBtn = True
                    CRTDOC.set_StoredProcParam(0, codempresa)
                    CRTDOC.set_StoredProcParam(1, VCdTipoDoc)
                    CRTDOC.set_StoredProcParam(2, VNroDoc)
                    CRTDOC.set_StoredProcParam(3, CStr(fechadocum))
                    CRTDOC.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                    CRTDOC.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & TIPODOCUMENTO & "'")
                    CRTDOC.set_Formulas(2, "FNombre='" & GHEAD1 & "'")
                    CRTDOC.set_Formulas(3, "FRuc='" & GHEAD3 & "'")
                    CRTDOC.set_Formulas(4, "FDireccion='" & GHEAD4 & "'")
                    CRTDOC.set_Formulas(5, "FUbicacion='" & GHEAD5 & "'")
                    CRTDOC.set_Formulas(6, "FInafecto='" & INAFECTO & "'")
                    CRTDOC.set_Formulas(7, "FGravadas='" & AFECTO & "'")
                    CRTDOC.set_Formulas(8, "FExoneradas='" & 0.0 & "'")

                    CRTDOC.ReportFileName = rutareporte + CType("Rpt_BoletaFE.rpt", String)
                    CRTDOC.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    'If ChkImpresora.CheckState = CheckState.Checked Then
                    '    CRTDOC.Destination = Crystal.DestinationConstants.crptToWindow
                    'Else
                    '    CRTDOC.Destination = Crystal.DestinationConstants.crptToPrinter
                    'End If
                    CRTDOC.Destination = Crystal.DestinationConstants.crptToWindow

                    CRTDOC.WindowState = Crystal.WindowStateConstants.crptMaximized
                    CRTDOC.Action = 1
                    CRTDOC.Reset()
                ElseIf VCdTipoDoc = CDNTAPEDIDO.Trim Then
                    StrMonLet = FACT_TotalLetras(CDbl(CTRLTOTAL.CtlText), "SOLES")
                    CRTDOC.WindowShowExportBtn = True
                    CRTDOC.WindowShowPrintBtn = True
                    CRTDOC.WindowShowPrintSetupBtn = True
                    CRTDOC.set_StoredProcParam(0, codempresa)
                    CRTDOC.set_StoredProcParam(1, VCdTipoDoc)
                    CRTDOC.set_StoredProcParam(2, IMP)
                    CRTDOC.set_StoredProcParam(3, CStr(fechadocum))
                    CRTDOC.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")
                    CRTDOC.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & "NP " & Format(CDbl(VNroDoc), "0##-#######") & "'")
                    CRTDOC.ReportFileName = rutareporte + CType("Rpt_NotaPedido.rpt", String)

                    CRTDOC.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"


                    'If ChkImpresora.CheckState = CheckState.Checked Then
                    '    CRTDOC.Destination = Crystal.DestinationConstants.crptToWindow
                    'Else
                    '    CRTDOC.Destination = Crystal.DestinationConstants.crptToPrinter
                    'End If
                    CRTDOC.Destination = Crystal.DestinationConstants.crptToWindow

                    CRTDOC.WindowState = Crystal.WindowStateConstants.crptMaximized
                    CRTDOC.Action = 1
                    CRTDOC.Reset()
                End If

                CANCELAR()


            Else

            End If

            MsgBox("- Se Guardo con exito.", MsgBoxStyle.Information, "NARSISTEMAS")

            btnefectivo.Enabled = True



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function GRABAEFECTIVOS(ByVal CODTIPOPAGO As String, ByVal fechadocum As Date) As Boolean

        Dim AFEC As Integer
        Try
            'TmpInsertDatos("sp_grabadocumento  '" & CStr(VIE.txtnroguias.Text) & "','" & CStr(VIE.txtnotapesada.Text) & "','" & CStr(VIE.CHKIGV.Checked) & "','" & CStr(fact_editnumero) & "','" & CInt(FACT_NUMEROTRANSACCION) & "','" & CStr(FACT_clieprincipal) & "','" & CODTIPOPAGO.Trim & "','" & CStr(VCdTipoDoc) & "','" & CStr(VNroDoc) & "','" & CStr(FACT_CDMONEDA) & "','" & CDec(LBLcambio.Text) & "','" & CStr(FACT_codvendedor) & "','" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & CDec(IIf(CDMONBASE = FACT_CDMONEDA, VIE.CTRLTOTAL.CtlText, VIE.CTRLTOTAL.CtlText * LBLcambio.Text)) & "','" & CDec(FACT_pordescuento) & "','" & CDec(IIf(CDMONBASE = FACT_CDMONEDA, ctrlvuelto.CtlText, ctrlvuelto.CtlText * LBLcambio.Text)) & "','" & CDec(ctrlefectivobas.CtlText) & "' ,'" & CDec(ctrlefectivoextr.CtlText) & "','" & CStr(FACT_codcliente) & "','" & CStr(FACT_RUCCLIENTE) & "','" & CStr(FACT_DESCLIENTE) & "','" & CStr(FACT_DIRCLIENTE) & "','" & CStr(CodUsuario) & "','" & CStr(CodEmpresa) & "' ,'" & CStr(FACT_CDMONEDA) & "','" & CStr(NROPTOVTA) & "','" & CInt(VCorrelVta) & "' ")
            Dim Dt_TimeOut As Integer = 500000

            Dim cn2 As New SqlConnection(STRCN)
            If cn2.State = ConnectionState.Open Then
                cn2.Close()
            End If

            cn2.Open()
            Dim cmd2 As New SqlCommand("Nsp_grabadocumentoJ", cn2)
            cmd2.CommandType = CommandType.StoredProcedure

            cmd2.Parameters.AddWithValue("@NRODEGUIAS", CStr("")).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@NPESADA", CStr("")).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@Eigv", CStr(CHKIGV.Checked)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@actualizocorrelativo", CStr(fact_editnumero)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@NUMEROTRANS", CInt(FACT_NUMEROTRANSACCION)).SqlDbType = SqlDbType.Int
            cmd2.Parameters.AddWithValue("@CODDEP", CStr(VClieDep)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CODTIPOPAGO", CODTIPOPAGO.Trim).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CODTIPODOC", CStr(VCdTipoDoc)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@NRODOCU", CStr(VNroDoc)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@codmon", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CAMBIO", CDec(lblcambio.Text)).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@codvend", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@FECDOCUM", fechadocum).SqlDbType = SqlDbType.DateTime
            cmd2.Parameters.AddWithValue("@TOTBAS", CDec(CTRLTOTAL.CtlText)).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@PORCENDESC1", CDec(VDescTotbas)).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@TOTVUELTOBAS", CDec("0.00")).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@TOTCASHBAS", CDec("0.00")).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@TOTCASHEXT", CDec("0.00")).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@codcliente", CStr(VCodCliente)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@RUCCLIENTE", CStr(VRuc)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@DESCLIENTE", CStr(VDescliente)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@DIRCLIENTE", CStr(VDireccion)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@usuario", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CODEMPRESA", CStr(codempresa)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@MONEDABASE", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@NROPTOVTA", CStr(NROPTOVTA)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CORRELATIVO", CInt(VCorrelVta)).SqlDbType = SqlDbType.Int
            cmd2.Parameters.AddWithValue("@POSTPAGO", CBool(True)).SqlDbType = SqlDbType.Bit
            cmd2.Parameters.AddWithValue("@Hora", Label15.Text).SqlDbType = SqlDbType.VarChar
            cmd2.CommandTimeout = Dt_TimeOut

            Try

                AFEC = cmd2.ExecuteNonQuery()
                cn2.Close()
                Return True

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        'IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
        TmpInsertDatos("SP_REGISTRA_AUDITORIA '','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy") & "','" & CodUsuario & "','" & codempresa & "'")

    End Function


    Private Sub btntarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntarjeta.Click
        Dim status As Boolean
        txtnotapesada.Text = 1
        status = validanumerodoc(Val(txtnumero.Text), txtruc.Text)
        If status = False Then
            Exit Sub
        End If


        If verificaitemdeingreso() = False Then
            Exit Sub
        End If


        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        status = verificanotapesada(txtnotapesada.Text)
        If status = False Then
            Exit Sub
        End If
        VClieDep = lblprincipal.Text
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Dim status As Boolean
        If Trim(txtruc.Text) <> "" Then
            status = FACT_GValidaRUC(Trim(txtruc.Text))
            If status = False Then
                Exit Sub
            End If
        End If
        VCodCliente = txtcodclie.Text
        VRuc = Trim(txtruc.Text)
        VDescliente = txtcliente.Text
        VDireccion = txtdireccion.Text
        VPorcenDesc = CTRLDESC.CtlText
        VNroDoc = txtnumero.Text
        VTotBas = CTRLTOTAL.CtlText
        VTotExt = CDbl(CTRLTOTAL.CtlText) / CDbl(lblcambio.Text)

        If lblprincipal.Text = "" Then
            lblprincipal.Text = txtcodclie.Text
            VClieDep = lblprincipal.Text

        End If

        'Dim frmx As New frmpagotarjeta
        'frmx.VIE2 = Me
        'frmx.estado = False
        'frmx.ShowDialog()

    End Sub
    Private Sub btncheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheque.Click
        Dim status As Boolean
        txtnotapesada.Text = 1
        status = validanumerodoc(Val(txtnumero.Text), txtruc.Text)
        If status = False Then
            Exit Sub
        End If


        If verificaitemdeingreso() = False Then
            Exit Sub
        End If

        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        status = verificanotapesada(txtnotapesada.Text)
        If status = False Then
            Exit Sub
        End If
        VClieDep = lblprincipal.Text
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Dim status As Boolean
        If Trim(txtruc.Text) <> "" Then
            status = FACT_GValidaRUC(Trim(txtruc.Text))
            If status = False Then
                Exit Sub
            End If
        End If
        VCodCliente = txtcodclie.Text
        VRuc = Trim(txtruc.Text)
        VDescliente = txtcliente.Text
        VDireccion = txtdireccion.Text
        VPorcenDesc = CTRLDESC.CtlText
        VNroDoc = txtnumero.Text
        VTotBas = CTRLTOTAL.CtlText
        VTotExt = CDbl(CTRLTOTAL.CtlText) / CDbl(lblcambio.Text)
        If lblprincipal.Text = "" Then
            lblprincipal.Text = txtcodclie.Text
            VClieDep = lblprincipal.Text
        End If
        'Dim frmx As New FRMPAGOCHEQUE
        'frmx.VIE2 = Me
        'frmx.estado = False
        'frmx.ShowDialog()
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Try


            If FACT_mensaje_cancelar() = True Then
                btngeneranuevo_Click(sender, e)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub CANCELAR()
        Try
            TmpInsertDatos("delete  from tmp_saldos_importacion WHERE CORRNBR =" & VCorrelVta & "")
            Call NUMERODOCUMENTO()
            Call INICIACONTROLNUMBER()
            Call tipodocumento()
            Call tmp_borra_saldos()
            'Call iniciaconfigrid()
            Call OBTENERCORRELATIVO()
            Call cargadatos()
            VCodVended = cbovendedor.SelectedValue.ToString
            Call actuadetalle()
            Call NUEVO()
            Call editnum(False)
            lbltotalletras.Text = ""
            txtnotapesada.Text = ""
            txtnroguias.Text = ""
            cbomoneda.SelectedValue = CDMONBASE
            FACT_CDMONEDA = cbomoneda.SelectedValue
            fact_editnumero = False
            SW = True
            'FACT_codvendedor = cbovendedor.SelectedValue.ToString
        Catch ex As Exception

        End Try

    End Sub
    Public Sub NUEVO()
        Call cargadatos()
        Call configuracionfacturacion()
        Call tipodocumento()
        txtnotapesada.Text = ""
        Call NUMERODOCUMENTO()
        Call INICIACONTROLNUMBER()
        txtcodclie.Focus()
    End Sub

    Private Sub cbovendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbovendedor.SelectedIndexChanged
        VCodVended = cbovendedor.SelectedValue.ToString
    End Sub

    Sub OBTENERCORRELATIVO()
        Dim SQL As String
        Dim DS As New DataSet
        SQL = "ObtenerCorrelativoProcUtil '" & CodUsuario & "'"
        DS = TmpListarDataset(SQL)
        VCorrelVta = DS.Tables(0).Rows(0)(0)
    End Sub

    'Sub iniciaconfigrid()
    '    Dim MIDS As New DataSet
    '    MIDS = FACT_QUERY("CONFIGGRID '" & NroPtovta & "','" & CodEmpresa & "'")
    '    FACT_CONFIGGRID = MIDS.Tables(0).Rows(0)(0)
    'End Sub

    Sub elimina_item()
        Try
            Dim sql As String
            Dim CDARTI, NROIMPORTACION, TIPOM, CANTIDAD As String
            CDARTI = Trim(Grid1.Item(Grid1.CurrentRowIndex, 1))
            ' NROIMPORTACION = Trim(Grid1.Item(Grid1.CurrentRowIndex, 11))
            'Dim FHORAIMP As String
            'FHORAIMP = Trim(Grid1.Item(Grid1.CurrentRowIndex, 12))
            'FHORAIMP = Format(CDate(FHORAIMP), "MM/dd/yyyy hh:mm:ss")

            ' TIPOM = Trim(Grid1.Item(Grid1.CurrentRowIndex, 9))
            'CANTIDAD = Trim(Grid1.Item(Grid1.CurrentRowIndex, 4))
            sql = "SP_DELETE_ITEM_TMPVENTADET " & VCorrelVta & "," & Grid1.Item(Grid1.CurrentRowIndex, 0) & "," & codempresa & "," & NROPTOVTA & ""
            TmpInsertDatos(sql)
            'sql = "SP_UPDATE_TMP_saldos_importacion2 '" & CDARTI & "'," & NROIMPORTACION & "," & TIPOM & "," & CANTIDAD & "," & VCorrelVta & ",'" & NROPTOVTA & "','" & FHORAIMP & "'"
            'TmpInsertDatos(sql)
            Call actuadetalle()
            Call sp_sube_tmp_saldos_importacion(txtcodarticulo.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid1.KeyDown
        If FACT_GUIA = False Then
            If e.KeyCode = Keys.F3 Then
                Call elimina_item()
            End If
        End If
    End Sub
    Private Sub btncredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncredito.Click
        Dim status As Boolean
        txtnotapesada.Text = 1
        'lblprincipal.Text = "noevo pagador"
        status = validanumerodoc(Val(txtnumero.Text), txtruc.Text)
        If status = False Then
            Exit Sub
        End If

        If verificaitemdeingreso() = False Then
            Exit Sub
        End If

        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        status = verificanotapesada(txtnotapesada.Text)
        If status = False Then
            Exit Sub
        End If
        VClieDep = lblprincipal.Text
        Dim VALIDA As Boolean
        VALIDA = VALIDACLIE()
        If VALIDA = False Then
            Exit Sub
        End If
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Dim status As Boolean
        If Trim(txtruc.Text) <> "" Then
            status = FACT_GValidaRUC(Trim(txtruc.Text))
            If status = False Then
                Exit Sub
            End If
        End If
        Dim ds As New DataSet
        Dim sql As String
        sql = "verifica_saldo_creditoclie '" & lblprincipal.Text & "'," & CTRLTOTAL.CtlText & ""
        ds = TmpListarDataset(sql)
        If ds.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Cliente no Cuenta con Credito para el Monto del documento", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        VCodCliente = txtcodclie.Text
        VRuc = Trim(txtruc.Text)
        VDescliente = txtcliente.Text
        VDireccion = txtdireccion.Text
        VPorcenDesc = CTRLDESC.CtlText
        VNroDoc = txtnumero.Text
        VTotBas = CTRLTOTAL.CtlText
        VTotExt = CDbl(CTRLTOTAL.CtlText) / CDbl(lblcambio.Text)
        If lblprincipal.Text = "" Then
            lblprincipal.Text = txtcodclie.Text
            VClieDep = lblprincipal.Text
        End If
        'Dim frmx As New frmpagocredito
        'frmx.VIE2 = Me
        'frmx.estado = False
        'frmx.ShowDialog()
    End Sub
    Private Sub btnvale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvale.Click
        Dim status As Boolean
        txtnotapesada.Text = 1
        status = validanumerodoc(Val(txtnumero.Text), txtruc.Text)
        If status = False Then
            Exit Sub
        End If


        If verificaitemdeingreso() = False Then
            Exit Sub
        End If

        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        status = verificanotapesada(txtnotapesada.Text)
        If status = False Then
            Exit Sub
        End If
        VClieDep = lblprincipal.Text
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Dim frmx As New frmpagovale
        'frmx.VIE2 = Me
        'frmx.estado = False
        'frmx.ShowDialog()
    End Sub
    Private Sub txtcodclie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodclie.KeyPress

        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        If Asc(e.KeyChar) = 13 Then
            'FACT_NVENTANA = 2

            'Dim frmx As New frmtipoclieFACT
            'frmx.VIE3 = Me
            'frmx.cond = 2
            'frmx.ShowDialog()

            txtruc.Focus()
            VCodCliente = txtcodclie.Text
            Call buscacliente()
        End If
    End Sub
    Private Sub txtruc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtruc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call TIPODOC()
        End If
    End Sub
    Sub TIPODOC()
        Dim status As Boolean
        If Trim(txtruc.Text) <> "" Then
            status = FACT_GValidaRUC(Trim(txtruc.Text))
            If status = False Then
                Exit Sub
            End If
        End If
        If Trim(txtruc.Text) = "" Then flagfac = False
        If Trim(txtruc.Text) <> "" Then flagfac = True
        Call tipodocumento()
        Call tipodocumento()
        Call NUMERODOCUMENTO()
        txtcliente.Focus()
    End Sub
    Private Sub txtcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdireccion.Focus()
        End If
    End Sub
    Private Sub txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbovendedor.Focus()
        End If
    End Sub
    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click

        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        VCodCliente = txtcodclie.Text
        VRuc = Trim(txtruc.Text)
        VDescliente = txtcliente.Text
        VDireccion = txtdireccion.Text
        'Dim frmx As New frmsalvatrans
        'frmx.vie2 = Me
        'frmx.estado = False
        'frmx.ShowDialog()
    End Sub
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Function VALIDACLIE() As Boolean
        Try
            If Trim(txtcodclie.Text) = "" Or Trim(txtcliente.Text) = "" Or Trim(lblprincipal.Text) = "" Then
                MessageBox.Show("Complete los datos del cliente para realizar el proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                VALIDACLIE = False
            Else
                VALIDACLIE = True
            End If
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaurar.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        Call OBTENERCORRELATIVO()
        'Dim frmx As New FRMRESTORESTRANS
        'frmx.VIE2 = Me
        'frmx.estado = False
        'frmx.ShowDialog()
    End Sub
    Private Sub mnufacdirec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnufacdirec.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        BTNGUIAS.Visible = False
        flagfac = False
        mnufacdirec.Checked = True
        mnufactguia.Checked = False
        Me.Text = "Facturacion Directa"
        FACT_GUIA = False
        VISTAGUIA(False)
        VISTAFACT(True)
        txtruc.Text = ""
        txtcodclie.Text = ""
        txtcliente.Text = ""
        txtdireccion.Text = ""
        txtcodarticulo.Text = ""
        CTRLCANTIDADSERV.Text = "0.00"
        CTRLPRECIO.Text = FACT_GFormatodeNumero(0)
        Call tipodocumento()
        Call INICIACONTROLNUMBER()
        Call NUMERODOCUMENTO()
        Call OBTENERCORRELATIVO()
        Call cargadatos()
        Call actuadetalle()
        Call tipodocumento()
    End Sub
    Private Sub mnufactguia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnufactguia.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If

        BTNGUIAS.Visible = True
        flagfac = True
        mnufacdirec.Checked = False
        mnufactguia.Checked = True
        Me.Text = "Facturacion GUIA Directa"
        FACT_GUIA = True
        VISTAGUIA(True)
        VISTAFACT(False)
        txtruc.Text = ""
        txtcodclie.Text = ""
        txtcliente.Text = ""
        txtdireccion.Text = ""
        txtcodarticulo.Text = ""
        CTRLCANTIDADSERV.Text = "0.00"
        CTRLPRECIO.Text = FACT_GFormatodeNumero(0)

        Call OBTENERCORRELATIVO()
        Call cargadatos()
        Call actuadetalle()
        Call tipodocumento()
        Dim DS As New DataSet
        Dim SQL As String
        SQL = "SP_NUMERODOC '" & NROPTOVTA & "','12345678912'"
        DS = TmpListarDataset(SQL)
        txtnumero.Text = DS.Tables(0).Rows(0)(1)
        TXTSERIEDOC.Text = DS.Tables(0).Rows(0)(2) 'solo seria format
        TXTNUMERODOC.Text = DS.Tables(0).Rows(0)(3) 'solo numero format
        VNroDoc = CDbl(txtnumero.Text)
    End Sub
    Sub VISTAGUIA(ByVal ESTADO As Boolean)
        GroupBox1.Visible = ESTADO
        btnsalvar.Enabled = ESTADO
        btnrestaurar.Enabled = ESTADO
    End Sub
    Sub VISTAFACT(ByVal ESTADO As Boolean)
        GroupBox1.Visible = ESTADO
        btnsalvar.Enabled = ESTADO
        btnrestaurar.Enabled = ESTADO
    End Sub
    Private Sub FRMFACTURACION_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        mnufacdirec.Checked = True
        txtcodclie.Focus()


    End Sub
    Private Sub BTNGUIAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUIAS.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        If Trim(txtcodclie.Text) = "" Then
            MessageBox.Show("Selecione un Cliente para ver las guias", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Dim frmx As New FRMGUIASFACT
        'frmx.vie6 = Me
        'frmx.estado = False
        'frmx.ShowDialog()
    End Sub
    Private Sub CTRLPRECIO_KeyPressEvent(ByVal sender As System.Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent)
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If

        ' CTRLCANTIDAD.CtlText = 1

        If FACT_GUIA = False Then
            Try
                CTRLPRECIO.Focus()
                If e.keyAscii = 13 Then
                    If CDbl(CTRLPRECIO.Text) <= 0 Then
                        MessageBox.Show("Precio no debe ser 0 ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        CTRLPRECIO.Focus()
                        Exit Sub
                    Else
                        Call INSERT_TMP_DETALLE()
                        Call LIMPIA_DATOSDOC()
                        txttipo.Text = 1
                        txtdescripcion.Text = ""
                        txtdescripcion.Focus()
                        cbomoneda.Enabled = False
                    End If
                End If



            Catch ex As Exception
            End Try
        End If
    End Sub
    Sub tmp_borra_saldos()
        Try
            TmpInsertDatos("delete  from tmp_saldos_importacion WHERE CORRNBR =" & VCorrelVta & "")
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub FRMFACTURACION_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        tmp_borra_saldos()
    End Sub


    Public Sub IMPRIMEDOCUMENTO(ByVal VCorrelVta As Long)
        Try

            If VCdTipoDoc = CDFACTURA Then

                With CRTDOC
                    .set_StoredProcParam(0, codempresa)
                    .set_StoredProcParam(1, VCdTipoDoc)
                    .set_StoredProcParam(2, CStr(VNroDoc))
                    .set_StoredProcParam(3, Format(CDate(Me.dtpfechadoc.Value), "dd/MM/yyyy"))
                    .set_Formulas(1, "formTotLetras='" & meTotalLetras(CDbl(TOTAL), "Soles") & "'")
                    .set_Formulas(2, "formnundoc='" & CStr(VNroDoc) & "'")
                    .ReportFileName = rutareporte + CType("Rpt_FacturaFE.rpt", String)
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                    Exit Sub
                End With

            End If
            If VCdTipoDoc = CDBOLETA Then
                With CRTDOC
                    .set_StoredProcParam(0, codempresa)
                    .set_StoredProcParam(1, VCdTipoDoc)
                    .set_StoredProcParam(2, CStr(VNroDoc))
                    .set_StoredProcParam(3, Format(CDate(Me.dtpfechadoc.Value), "dd/MM/yyyy"))
                    .set_Formulas(1, "formTotLetras='" & meTotalLetras(CDbl(TOTAL), "Soles") & "'")
                    .set_Formulas(2, "formnundoc='" & CStr(VNroDoc) & "'")
                    .ReportFileName = rutareporte + CType("Rpt_BoletaFE.rpt", String)
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                    Exit Sub
                End With
            End If
            If VCdTipoDoc = CDNTAPEDIDO Then
                With CRTDOC
                    .set_StoredProcParam(0, codempresa)
                    .set_StoredProcParam(1, VCdTipoDoc)
                    .set_StoredProcParam(2, CStr(VNroDoc))
                    .set_StoredProcParam(3, Format(CDate(Me.dtpfechadoc.Value), "dd/MM/yyyy"))
                    .set_Formulas(1, "formTotLetras='" & meTotalLetras(CDbl(TOTAL), "Soles") & "'")
                    .set_Formulas(2, "formnundoc='" & CStr(VNroDoc) & "'")

                    .ReportFileName = rutareporte + CType("Rpt_NotaPedido.rpt", String)
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                    Exit Sub
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Function meTotalLetras(ByVal nume As Double, ByVal TMONEDA As String) As String
        '------------------------------------
        '  nume    : Cifra (incluye decimales)
        '  TMONEDA : Texto que debe indicar la moneda ("Nuevos Soles","Dolares")
        '------------------------------------

        Dim c1 As String = String.Empty
        Dim c2 As String = String.Empty
        Dim c3 As String = String.Empty
        Dim c4 As String = String.Empty
        Dim z1 As String = String.Empty
        Dim xdec As String = String.Empty
        Dim xcad_dec As String = String.Empty
        Dim z As String = String.Empty
        Dim s As String = String.Empty
        Dim u As String = String.Empty
        Dim d As String = String.Empty
        Dim c As String = String.Empty
        Dim sys As String = String.Empty
        Dim cifra As String = String.Empty
        Dim xlg As Double
        Dim K, Y, N As Integer
        xlg = 12 - Len(Trim(CStr(Int(nume))))
        z1 = Space(xlg) & Trim(CStr(Int(nume)))
        xdec = Microsoft.VisualBasic.Right(Format(nume - Int(nume), "#0.00"), 2)
        xcad_dec = " Y " + xdec + "/100"

        K = 1
        Y = 10
        N = 3
        Do While K <= 4
            z = Mid(z1, Y, 3)
            s = Mid(z, N, 1)
            If s = "1" Then
                u = "UNO"
                If K = 2 Or K = 3 Then
                    u = "UN"
                End If
            Else
                u = IIf(s = "2", "DOS", IIf(s = "3", "TRES", IIf(s = "4", "CUATRO",
                    IIf(s = "5", "CINCO", IIf(s = "6", "SEIS", IIf(s = "7", "SIETE",
                    IIf(s = "8", "OCHO", IIf(s = "9", "NUEVE", ""))))))))
            End If

            If Mid(z, N - 1, 1) = "1" Then
                If Mid(z, N, 1) = "0" Then
                    d = "DIEZ"
                Else
                    If Mid(z, N, 1) = "1" Then
                        d = "ONCE"
                        u = ""
                    Else
                        If Mid(z, N, 1) = "2" Then
                            d = "DOCE"
                            u = ""
                        Else
                            If Mid(z, N, 1) = "3" Then
                                d = "TRECE"
                                u = ""
                            Else
                                If Mid(z, N, 1) = "4" Then
                                    d = "CATORCE"
                                    u = ""
                                Else
                                    If Mid(z, N, 1) = "5" Then
                                        d = "QUINCE"
                                        u = ""
                                    Else
                                        d = "DIECI"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                If Mid(z, N - 1, 1) = "2" Then
                    If Mid(z, N, 1) = "0" Then
                        d = "VEINTE"
                    Else
                        d = "VEINTE Y "
                    End If
                Else
                    If Mid(z, N - 1, 1) = "3" Then
                        If Mid(z, N, 1) = "0" Then
                            d = "TREINTA"
                        Else
                            d = "TREINTA Y "
                        End If
                    Else
                        If Mid(z, N - 1, 1) = "4" Then
                            If Mid(z, N, 1) = "0" Then
                                d = "CUARENTA"
                            Else
                                d = "CUARENTA Y "
                            End If
                        Else
                            If Mid(z, N - 1, 1) = "5" Then
                                If Mid(z, N, 1) = "0" Then
                                    d = "CINCUENTA"
                                Else
                                    d = "CINCUENTA Y "
                                End If
                            Else
                                If Mid(z, N - 1, 1) = "6" Then
                                    If Mid(z, N, 1) = "0" Then
                                        d = "SESENTA"
                                    Else
                                        d = "SESENTA Y "
                                    End If
                                Else
                                    If Mid(z, N - 1, 1) = "7" Then
                                        If Mid(z, N, 1) = "0" Then
                                            d = "SETENTA"
                                        Else
                                            d = "SETENTA Y "
                                        End If
                                    Else
                                        If Mid(z, N - 1, 1) = "8" Then
                                            If Mid(z, N, 1) = "0" Then
                                                d = "OCHENTA"
                                            Else
                                                d = "OCHENTA Y "
                                            End If
                                        Else
                                            If Mid(z, N - 1, 1) = "9" Then
                                                If Mid(z, N, 1) = "0" Then
                                                    d = "NOVENTA"
                                                Else
                                                    d = "NOVENTA Y "
                                                End If
                                            Else
                                                d = ""
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If Mid(z, N - 2, 1) = "1" Then
                If Mid(z, N - 1, 1) = "0" And Mid(z, N, 1) = "0" Then
                    c = "CIEN"
                Else
                    c = "CIENTO"
                End If
            Else
                If Mid(z, N - 2, 1) = "2" Then
                    c = "DOSCIENTOS"
                Else
                    If Mid(z, N - 2, 1) = "3" Then
                        c = "TRESCIENTOS"
                    Else
                        If Mid(z, N - 2, 1) = "4" Then
                            c = "CUATROCIENTOS"
                        Else
                            If Mid(z, N - 2, 1) = "5" Then
                                c = "QUINIENTOS"
                            Else
                                If Mid(z, N - 2, 1) = "6" Then
                                    c = "SEISCIENTOS"
                                Else
                                    If Mid(z, N - 2, 1) = "7" Then
                                        c = "SETECIENTOS"
                                    Else
                                        If Mid(z, N - 2, 1) = "8" Then
                                            c = "OCHOCIENTOS"
                                        Else
                                            If Mid(z, N - 2, 1) = "9" Then
                                                c = "NOVECIENTOS"
                                            Else
                                                c = ""
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Select Case K
                Case 1
                    c1 = c + " " + d + u
                Case 2
                    c2 = c + " " + d + u
                Case 3
                    c3 = c + " " + d + u
                Case 4
                    c4 = c + " " + d + u
            End Select
            K = K + 1
            Y = Y - 3
        Loop
        If (Len(c4) - 1) <> 0 Then
            If c4 = "UN" Then
                sys = " MILLON "
            Else
                sys = " MILLONES "
            End If
            cifra = c4 + " MIL " + c3 + sys + c2 + " MIL " + c1
        Else
            If (Len(c3) - 1) <> 0 Then
                If c3 = "UN" Then
                    sys = " MILLON "
                Else
                    sys = " MILLONES "
                End If
                cifra = c3 + sys + c2 + " MIL " + c1
            Else
                If (Len(c2) - 1) <> 0 Then
                    cifra = c2 + " MIL " + c1
                Else
                    If Len(c1) <> 0 Then
                        cifra = c1
                    End If
                End If
            End If
        End If
        TMONEDA = " " + TMONEDA

        meTotalLetras = Trim(cifra + xcad_dec + TMONEDA)
    End Function

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim status As Boolean
        status = VERIFICA_CIERRE_PTOVTA()
        If status = False Then
            Exit Sub
        End If

        status = VERIFICA_CIERRE_PTOVTA_TODOS()
        If status = False Then
            'Dim frmz As New FRMPUNTOSXCERRAR
            'frmz.ShowDialog()
            'Exit Sub
        End If
        'Dim frmx As New frmfindia
        'frmx.ShowDialog()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        Dim SQL As String
        SQL = "sp_activa_cierrex '" & codempresa & "','" & NROPTOVTA & "','" & CodUsuario & "'"
        TmpInsertDatos(SQL)
        With CRTDOC()
            .ReportFileName = rutareporte + CType("CIERREX.rpt", String)
            .ReportTitle = "Cierre X"
            .Action = 1
            .Reset()
        End With
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        'Dim frmx As New frmcierreptovta
        'frmx.ShowDialog()


    End Sub
    Private Sub btnanular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanular.Click
        Dim status As Boolean
        ''If verificaitemdeingreso() = False Then
        ''Exit Sub
        ''End If
        ''status = VERIFICA_PTOVTA()
        ''If status = False Then
        '' Exit Sub
        ''End If

        Dim Proceso As String
        Proceso = "ANULARFACTF"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If

        If MsgBox("ESTA SEGURO DE ANULAR EL DOCUMENTO..", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Dim FrmMsj As New FrmMotivoAnula
            FrmMsj.ShowDialog()
            If CAyuda.Ejecutar("ANULAR_DOCUMENTO_EN_FACTURACION_PROC", codempresa, VCdTipoDoc, VNroDoc, VCodCliente, VCdTipoAnula, VObserv, CStr(VDescTotbas)) > 0 Then





                Dim LETRADOC As String = ""

                If VCdTipoDoc.ToString.Trim = "01" Then
                    LETRADOC = "F"
                End If
                If VCdTipoDoc.ToString.Trim = "03" Then
                    LETRADOC = "B"
                End If
                If VCdTipoDoc.ToString.Trim = "06" Then
                    LETRADOC = "F"
                End If

                Dim SERIE2 As String
                Dim FormatNroDoc As String
                FormatNroDoc = Format(VNroDoc, "0##-########")
                Dim NUMSERIE As String
                NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                SERIE2 = LETRADOC + NUMSERIE

                Dim NRODOCSIN As String
                NRODOCSIN = CStr(Microsoft.VisualBasic.Right(VNroDoc, 8))
                Dim NRODOCFINAL As String
                NRODOCFINAL = SERIE2 + "-" + NRODOCSIN

                Dim gestordetipoNegocio As New GestorDeFacturacionElectronica
                gestordetipoNegocio.AnularFE(SERIE2, NRODOCSIN, VCdTipoDoc)

                MsgBox("El documento ha sido anulado", MsgBoxStyle.Information)



            End If
        End If
        CANCELAR()
    End Sub
    Private Sub btnreimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreimprimir.Click
        '' Dim status As Boolean
        '' status = VERIFICA_PTOVTA()
        ''  If status = False Then
        '' Exit Sub
        '' End If

        TOTAL = CTRLTOTAL.CtlText


        If TXTNUMERODOC.Enabled = True Then
            MsgBox("- Ingrese un Documento a Reimprimir.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        'Reimprimiendo el Archivo
        Dim Numero As Long
        Numero = Strings.Right(Val(Me.TXTSERIEDOC.Text.Trim + Me.TXTNUMERODOC.Text.Trim), 8)
        Call IMPRIMEDOCUMENTO(Numero)

    End Sub
    Private Sub btngeneranuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngeneranuevo.Click
        Try

            fact_editnumero = False

            NUMERODOCUMENTO()

            Call inicia_variables()
            Call SIMBOLOS()
            'Call cargadatos()
            Call configuracionfacturacion()
            Call tipodocumento()
            'Call INICIACONTROLNUMBER()
            'Call NUMERODOCUMENTO()
            'Call OBTENERCORRELATIVO()
            Call CANCELAR()
            'FACT_codvendedor = cbovendedor.SelectedValue.ToString
            'Call iniciaconfigrid()
            Call tmp_borra_saldos()
            CTRLSUBTOTAL.Enabled = False
            CTRLIGV2.Enabled = False
            CTRLDESC.Enabled = False
            CTRLTOTAL.Enabled = False


            'CTRLCANTIDAD.Text = 1
            Dim status As Boolean
            status = VERIFICA_PTOVTA()
            If status = False Then
                Exit Sub
            End If

            'If FACT_GUIA = False Then
            '    Call MUESTRAARTICULO()
            '    txttipo.Focus()
            'End If

            CTRLCANTIDADSERV.Text = "0.00"
            'CtrlNBultos.CtlText = "0.00"
            txtnotapesada.Text = 1
        Catch ex As Exception

        End Try
        Me.txtcodclie.Enabled = True
        Me.txtcodclie.Text = ""
        Me.txtcliente.Text = ""
        Me.txtcliente.Enabled = True
        Me.txtruc.Enabled = True
        Me.txtruc.Text = ""
        Me.txtdireccion.Text = ""
        Me.txtdireccion.Enabled = True
        Me.lblprincipal.Text = ""
        Me.txtdescripcion.Text = ""
        Me.txtdescripcion.Enabled = True
        GroupBox1.Enabled = True
        Me.btnbus.Enabled = True
        NUMERODOCUMENTO()
        Me.btnefectivo.Enabled = True
        Me.btntarjeta.Enabled = True
        Me.btncheque.Enabled = True
        Me.btncredito.Enabled = True
        Me.btnvale.Enabled = True
        Me.Button3.Enabled = True
        Me.btndsctoitem.Enabled = True
        Me.btndsctototal.Enabled = True
        Me.btnanular.Enabled = True
        Me.btnreimprimir.Enabled = True


    End Sub
    Private Sub txtnotapesada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnotapesada.TextChanged
        If IsNumeric(txtnotapesada.Text) = False Then
            txtnotapesada.Text = Space(0)
        End If
    End Sub
    Function verificanotapesada(ByVal notapesada As String) As Boolean
        notapesada = Trim(notapesada)
        If notapesada = "" Then
            verificanotapesada = False
            MessageBox.Show("Ingrese el numero de Nota de pesada Correspondiente", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnotapesada.Focus()
            Exit Function
        Else
            verificanotapesada = True
        End If
    End Function
    Sub BOTONES_PRESIONADOS(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        '*********************F2*********************AYUDA ARTICULO
        If e.KeyCode = Keys.F2 Then
            Button2_Click(sender, e)
        End If
        '*********************F3*********************AYUDA CLIENTE
        'If e.KeyCode = Keys.F3 Then
        'btnbus_Click(sender, e)
        'End If
        '*********************F7*********************PAGO EFECTIVO
        If e.KeyCode = Keys.F7 Then
            btnefectivo_Click(sender, e)
        End If
        '*********************F8*********************PAGO TARJETA
        If e.KeyCode = Keys.F8 Then
            btntarjeta_Click(sender, e)
        End If
        '*********************F9*********************CHEQUE
        If e.KeyCode = Keys.F9 Then
            btncheque_Click(sender, e)
        End If
        '*********************F10*********************CREDITO
        If e.KeyCode = Keys.F10 Then
            btncredito_Click(sender, e)
        End If
        '*********************F11*********************VALE
        If e.KeyCode = Keys.F11 Then
            btnvale_Click(sender, e)
        End If
        '*********************F12*********************edita numero doc
        If e.KeyCode = Keys.F12 Then
            Button3_Click(sender, e)
        End If
    End Sub
    Private Sub txtcodclie_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodclie.KeyDown
        'BOTONES_PRESIONADOS(sender, e)
        If e.KeyCode = Keys.F2 Then
            btnbus_Click(sender, e)
        End If


    End Sub
    Private Sub cbounidadventa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbounidadventa.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub txtcliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcliente.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub txtdireccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdireccion.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub txtnotapesada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnotapesada.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub txtruc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtruc.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub FRMFACTURACION_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub cbovendedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbovendedor.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim nitem As Integer
        Dim SQL As String
        Dim ds As New DataSet
        SQL = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
        ds = TmpListarDataset(SQL)
        nitem = ds.Tables(0).Rows.Count
        If nitem > 0 Then
            MessageBox.Show("Para Realizar este proceso Cancele la operacion Actual y Proceda", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim RESPUESTA As DialogResult
        RESPUESTA = (MessageBox.Show("Seguro que Desea Editar el Numero del Documento recuerde que este cambio estara estable hastq presione el boton cancelar", DesEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
        If RESPUESTA = DialogResult.No Then Exit Sub
        Call editnum(True)
    End Sub
    Private Sub TXTNUMERODOC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Sub editnum(ByVal estado As Boolean)
        Try
            TXTNUMERODOC.Enabled = estado
            fact_editnumero = estado
            TXTNUMERODOC.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Function verificaitemdeingreso() As Boolean
        Dim DS As New DataSet
        Try
            If fact_editnumero = True Then
                Dim nitem As Integer
                Dim SQL As String
                SQL = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
                DS = TmpListarDataset(SQL)
                nitem = DS.Tables(0).Rows.Count
                If Trim(txtruc.Text) = "" Then
                    If nitem >= ITEMDEBOLETA Then
                        MessageBox.Show("EXEDE NUMERO DE ITEM EN BOLETAS")
                        verificaitemdeingreso = False
                        Exit Function
                    End If
                End If
                If Trim(txtruc.Text) <> "" Then
                    If nitem >= ITEMDEFACT Then
                        MessageBox.Show("EXEDE NUMERO DE ITEM EN FACTURAS")
                        verificaitemdeingreso = False
                        Exit Function
                    End If
                End If
            End If
            verificaitemdeingreso = True
        Catch ex As Exception
        End Try
    End Function
    Public Sub pasanumerodoc()
        ' esta funcion pasa el numero modificado al numero real
        If fact_editnumero = True Then
            Dim x As String, n As Integer
            x = Trim(TXTSERIEDOC.Text) & Trim(TXTNUMERODOC.Text)
            n = Val(x)
            txtnumero.Text = n
        End If
    End Sub
    Public Function verificaprecio(ByVal precio As Double) As Boolean
        'primero verifico con q precio lo voy a comparar si es con medida o con unidad
        Dim ds As New DataSet
        Dim sql As String
        Dim min, max As Double

        If ListBox1.SelectedIndex = 0 Then  'unidad mayor
            sql = "SELECT MINPREMED,MAXPRECIOMED FROM preciart where CODTIPOPRE='" & CDTIPOPRE1 & "' and  CODARTI='" & Trim(txtcodarticulo.Text) & "'"
            ds = TmpListarDataset(sql)
            min = ds.Tables(0).Rows(0)(0)
            max = ds.Tables(0).Rows(0)(1)
            If min = 0 And max = 0 Then
                ' si ambos estan en cero lo dejo pasar
                verificaprecio = True
                Exit Function
            Else
                ' verifo el rango
                If precio >= min And precio <= max Then
                    'correcto pasa
                    verificaprecio = True
                    Exit Function
                Else
                    MessageBox.Show("El Precio de Venta Ingresado no se encuentra establecido entre el rango de precio codificado verifique!!!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    verificaprecio = False
                    Exit Function
                End If
            End If
        End If
        ds.Dispose()
        If ListBox1.SelectedIndex = 1 Then 'unidad menor
            sql = "SELECT MINPREUNI,MAXPREUNI FROM preciart where CODTIPOPRE='" & CDTIPOPRE1 & "' and  CODARTI='" & Trim(txtcodarticulo.Text) & "'"
            ds = TmpListarDataset(sql)
            min = ds.Tables(0).Rows(0)(0)
            max = ds.Tables(0).Rows(0)(1)
            If min = 0 And max = 0 Then
                ' si ambos estan en cero lo dejo pasar
                verificaprecio = True
                Exit Function
            Else
                ' verifo el rango
                If precio >= min And precio <= max Then
                    'correcto pasa
                    verificaprecio = True
                    Exit Function
                Else
                    MessageBox.Show("El Precio de Venta Ingresado no se encuentra establecido entre el rango de precio codificado verifique!!!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    verificaprecio = False
                    Exit Function
                End If
            End If
        End If
    End Function
    Private Sub CHKIGV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKIGV.CheckedChanged
        Try
            If Val(CTRLTOTAL.CtlText) <= 0 Then
                MessageBox.Show("Total del Documento es Cero", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                CHKIGV.Checked = True
                Exit Sub
            End If
            'If lbltipodoc.Text = "BOLETA" Then
            'MessageBox.Show("Documento no requiere este Proceso Valido para Facturas", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'CHKIGV.Checked = True
            'Exit Sub
            'End If
            CALCULO(False)
            CTRLIGV2.CtlText = FACT_GFormatodeNumero(CTRLIGV2.CtlText)
            CTRLSUBTOTAL.CtlText = FACT_GFormatodeNumero(CTRLSUBTOTAL.CtlText)
            CTRLTOTAL.CtlText = FACT_GFormatodeNumero(CTRLTOTAL.CtlText)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Dim FRMX As New FRMRANKINPRO
        'FRMX.ShowDialog()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'Dim men As New FRMUSUARIOZONA
        'men.ShowDialog()
    End Sub

    Private Sub txttipo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttipo.TextChanged
        If IsNumeric(txttipo.Text) = False Then
            txttipo.Text = "0"
        End If
    End Sub


    Private Sub txttipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttipo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CTRLCANTIDADSERV.Focus()
        End If
    End Sub

    Private Sub txtnotapesada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnotapesada.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcodarticulo.Focus()
        End If
    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CTRLCANTIDADSERV.Focus()
        End If
    End Sub

    Private Sub txtdescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdescripcion.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label15.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub cbomoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbomoneda.KeyPress
        If Asc(e.KeyChar) = 13 Then
            FACT_CDMONEDA = cbomoneda.SelectedValue
            SIMBOLOS()
            txtdescripcion.Focus()
        End If
    End Sub

    Private Sub cbomoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomoneda.SelectedIndexChanged
        If SW = True Then
            FACT_CDMONEDA = cbomoneda.SelectedValue
            SIMBOLOS()
        End If
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub CTRLPRECIO_change(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        Me.txtnroguias.Text = ""
        'If Trim(txtcodclie.Text) = "" Then
        '    MessageBox.Show("Selecione un Cliente para ver las guias", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        'Dim frmx As New FRMGUIASFACT
        'frmx.vie6 = Me
        'frmx.estado = False
        'frmx.ShowDialog()

        If txtnroguias.Text <> "" Then
            VCodCliente = txtcodclie.Text.Trim
            ''''validacliente()
            ''''If flagclie = True Then
            ''''    valclientevarios()
            ''''    FACT_NVENTANA = 2
            ''''    'Dim frmx As New frmtipoclieFACT
            ''''    'frmx.VIE2 = Me
            ''''    'frmx.cond = 1
            ''''    'frmx.ShowDialog()
            ''''    txtruc.Focus()
            ''''Else
            ''''    Exit Sub
            ''''End If
            ''cinfigcliente()
            ESTADOS(False)
            Call TIPODOC()
            btnefectivo.Focus()
            'txtcodclie.Focus()
        End If
    End Sub
    Private Sub ESTADOS(ByVal VALOR As Boolean)
        txtcodclie.Enabled = VALOR
        txtcliente.Enabled = VALOR
        txtruc.Enabled = VALOR
        txtdireccion.Enabled = VALOR
        cbomoneda.Enabled = VALOR
    End Sub

    Private Sub txtruc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtruc.TextChanged

    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub



    Private Sub TXTNUMERODOC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTNUMERODOC.TextChanged

    End Sub

    Private Sub txtcodclie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodclie.TextChanged

    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub



    Private Sub CTRLCANTIDADSERV_KeyPressEvent(ByVal sender As System.Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent)
        If e.keyAscii = 13 Then
            'Me.CtrlNBultos.Focus()
        End If
    End Sub

    Private Sub CTRLCANTIDADSERV_change_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ConsDocumentoServ As New FrmConsFacturacion
        ConsDocumentoServ.FacturaServ = Me
        ConsDocumentoServ.ShowDialog()

        'Verificando el Estado de la Factura
        'If Me.LblEstado.Text = "A" Then
        'MsgBox("El Documento Que Consulto Fue Anulado" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
        'Me.LblEstado.Text = ""
        'End If
    End Sub

    Private Sub CtrlNBultos_change(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CtrlNBultos_KeyPressEvent(ByVal sender As System.Object, ByVal e As AxMiControl.__CtrlNumber_KeyPressEvent)
        If e.keyAscii = 13 Then
            Me.CTRLPRECIO.Focus()
        End If
    End Sub

    Private Sub CTRLPRECIO_ControlAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ControlEventArgs)

    End Sub

    Private Sub CTRLPRECIO_KeyDown(sender As Object, e As KeyEventArgs) Handles CTRLPRECIO.KeyDown

        If e.KeyCode = Keys.Enter Then
            Call INSERT_TMP_DETALLE()
            Call LIMPIA_DATOSDOC()
        End If

    End Sub

    Private Sub CTRLPRECIO_TextChanged(sender As Object, e As EventArgs) Handles CTRLPRECIO.TextChanged
    End Sub

End Class
