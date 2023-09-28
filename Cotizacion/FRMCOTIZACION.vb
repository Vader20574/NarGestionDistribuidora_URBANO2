Imports System.Data.SqlClient
Public Class FRMCOTIZACION
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents lbltipodoc As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbovendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnreimprimir As System.Windows.Forms.Button
    Friend WithEvents btnanular As System.Windows.Forms.Button
    Friend WithEvents btndsctototal As System.Windows.Forms.Button
    Friend WithEvents btndsctoitem As System.Windows.Forms.Button
    Friend WithEvents btncheque As System.Windows.Forms.Button
    Friend WithEvents btncredito As System.Windows.Forms.Button
    Friend WithEvents btntarjeta As System.Windows.Forms.Button
    Friend WithEvents btnefectivo As System.Windows.Forms.Button
    Friend WithEvents txtcodclie As System.Windows.Forms.TextBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents dtpfechadoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbloperador As System.Windows.Forms.Label
    Friend WithEvents lblcambio As System.Windows.Forms.Label
    Friend WithEvents LBLSIMBOLOCAMBIO As System.Windows.Forms.Label
    Friend WithEvents btnvale As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnufacdirec As System.Windows.Forms.MenuItem
    Friend WithEvents mnufactguia As System.Windows.Forms.MenuItem
    Friend WithEvents lbltotalletras As System.Windows.Forms.Label
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXTSERIEDOC As System.Windows.Forms.TextBox
    Friend WithEvents TXTNUMERODOC As System.Windows.Forms.TextBox
    Friend WithEvents CHKIGV As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents btngeneranuevo As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents btnBusCli As System.Windows.Forms.Button
    Friend WithEvents CboPagador As System.Windows.Forms.ComboBox
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents LblPagador As System.Windows.Forms.Label
    Friend WithEvents CTRLCANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodarticulo As System.Windows.Forms.TextBox
    Friend WithEvents cbPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents btneliitem As System.Windows.Forms.Button
    Friend WithEvents btnactuitem As System.Windows.Forms.Button
    Friend WithEvents btnnueitem As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscArt As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CTRLPRECIO As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CTRLDESC As AxMiControl.AxCtrlNumber
    Friend WithEvents CTRLTOTAL As AxMiControl.AxCtrlNumber
    Friend WithEvents CTRLSUBTOTAL As AxMiControl.AxCtrlNumber
    Friend WithEvents CTRLIGV As AxMiControl.AxCtrlNumber
    Friend WithEvents rbboleta As System.Windows.Forms.RadioButton
    Friend WithEvents rbfactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbnotap As System.Windows.Forms.RadioButton
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtpercp As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbtipodoc As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMCOTIZACION))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnBusCli = New System.Windows.Forms.Button
        Me.txtcodclie = New System.Windows.Forms.TextBox
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.txtcliente = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.lbltipodoc = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpfechadoc = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbltotalletras = New System.Windows.Forms.Label
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.lbloperador = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbovendedor = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblcambio = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnConsultar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btngeneranuevo = New System.Windows.Forms.Button
        Me.btnreimprimir = New System.Windows.Forms.Button
        Me.btnanular = New System.Windows.Forms.Button
        Me.btnefectivo = New System.Windows.Forms.Button
        Me.btndsctototal = New System.Windows.Forms.Button
        Me.btndsctoitem = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnvale = New System.Windows.Forms.Button
        Me.btncredito = New System.Windows.Forms.Button
        Me.btncheque = New System.Windows.Forms.Button
        Me.btntarjeta = New System.Windows.Forms.Button
        Me.LBLSIMBOLOCAMBIO = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnufacdirec = New System.Windows.Forms.MenuItem
        Me.mnufactguia = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.Label11 = New System.Windows.Forms.Label
        Me.TXTSERIEDOC = New System.Windows.Forms.TextBox
        Me.TXTNUMERODOC = New System.Windows.Forms.TextBox
        Me.CHKIGV = New System.Windows.Forms.CheckBox
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblEstado = New System.Windows.Forms.Label
        Me.cbTipoPrecio = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.LblPagador = New System.Windows.Forms.Label
        Me.CboPagador = New System.Windows.Forms.ComboBox
        Me.CTRLCANTIDAD = New System.Windows.Forms.TextBox
        Me.txttipo = New System.Windows.Forms.TextBox
        Me.txtcodarticulo = New System.Windows.Forms.TextBox
        Me.cbPresentacion = New System.Windows.Forms.ComboBox
        Me.btneliitem = New System.Windows.Forms.Button
        Me.btnactuitem = New System.Windows.Forms.Button
        Me.btnnueitem = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.BtnBuscArt = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.CTRLPRECIO = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtTOTAL = New System.Windows.Forms.TextBox
        Me.TxtDESC = New System.Windows.Forms.TextBox
        Me.TxtSUBTOTAL = New System.Windows.Forms.TextBox
        Me.TxtIGV = New System.Windows.Forms.TextBox
        Me.LBLSIMBOLO2 = New System.Windows.Forms.Label
        Me.LBLSIMBOLO4 = New System.Windows.Forms.Label
        Me.lblsimbolo = New System.Windows.Forms.Label
        Me.lblsubtotal = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.LBLIGV = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtpercp = New System.Windows.Forms.TextBox
        Me.CTRLDESC = New AxMiControl.AxCtrlNumber
        Me.CTRLTOTAL = New AxMiControl.AxCtrlNumber
        Me.CTRLSUBTOTAL = New AxMiControl.AxCtrlNumber
        Me.CTRLIGV = New AxMiControl.AxCtrlNumber
        Me.gbtipodoc = New System.Windows.Forms.GroupBox
        Me.rbboleta = New System.Windows.Forms.RadioButton
        Me.rbfactura = New System.Windows.Forms.RadioButton
        Me.rbnotap = New System.Windows.Forms.RadioButton
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CTRLDESC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTRLTOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTRLSUBTOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CTRLIGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbtipodoc.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "N° Doc :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Cod. Cliente :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apell. o R.S. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Direccion :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "R.U.C : "
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
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
        'btnBusCli
        '
        Me.btnBusCli.ImageIndex = 5
        Me.btnBusCli.ImageList = Me.ImageList1
        Me.btnBusCli.Location = New System.Drawing.Point(272, 62)
        Me.btnBusCli.Name = "btnBusCli"
        Me.btnBusCli.Size = New System.Drawing.Size(33, 23)
        Me.btnBusCli.TabIndex = 15
        Me.btnBusCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcodclie
        '
        Me.txtcodclie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodclie.Location = New System.Drawing.Point(190, 63)
        Me.txtcodclie.MaxLength = 20
        Me.txtcodclie.Name = "txtcodclie"
        Me.txtcodclie.Size = New System.Drawing.Size(81, 21)
        Me.txtcodclie.TabIndex = 14
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(345, 63)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(98, 21)
        Me.txtruc.TabIndex = 16
        '
        'txtcliente
        '
        Me.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcliente.Location = New System.Drawing.Point(190, 86)
        Me.txtcliente.MaxLength = 150
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(335, 21)
        Me.txtcliente.TabIndex = 20
        '
        'txtdireccion
        '
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Location = New System.Drawing.Point(190, 110)
        Me.txtdireccion.MaxLength = 40
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(335, 21)
        Me.txtdireccion.TabIndex = 24
        '
        'lbltipodoc
        '
        Me.lbltipodoc.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipodoc.Location = New System.Drawing.Point(369, 29)
        Me.lbltipodoc.Name = "lbltipodoc"
        Me.lbltipodoc.Size = New System.Drawing.Size(285, 31)
        Me.lbltipodoc.TabIndex = 6
        Me.lbltipodoc.Text = "BOLETA"
        Me.lbltipodoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label9.Location = New System.Drawing.Point(545, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fecha Doc. :  "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpfechadoc
        '
        Me.dtpfechadoc.Enabled = False
        Me.dtpfechadoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechadoc.Location = New System.Drawing.Point(619, 63)
        Me.dtpfechadoc.Name = "dtpfechadoc"
        Me.dtpfechadoc.Size = New System.Drawing.Size(86, 21)
        Me.dtpfechadoc.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltotalletras)
        Me.GroupBox2.Controls.Add(Me.Grid1)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(802, 220)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'lbltotalletras
        '
        Me.lbltotalletras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalletras.ForeColor = System.Drawing.Color.Blue
        Me.lbltotalletras.Location = New System.Drawing.Point(11, 240)
        Me.lbltotalletras.Name = "lbltotalletras"
        Me.lbltotalletras.Size = New System.Drawing.Size(738, 17)
        Me.lbltotalletras.TabIndex = 3
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
        Me.Grid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(3, 17)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(796, 200)
        Me.Grid1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(44, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "SOLO PARA EL REPORTE"
        Me.Button4.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(127, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Operador : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'lbloperador
        '
        Me.lbloperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbloperador.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloperador.Location = New System.Drawing.Point(190, 17)
        Me.lbloperador.Name = "lbloperador"
        Me.lbloperador.Size = New System.Drawing.Size(135, 19)
        Me.lbloperador.TabIndex = 5
        Me.lbloperador.Text = "USUARIO PTOVENTA"
        Me.lbloperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbloperador.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label14.Location = New System.Drawing.Point(554, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Vendedor : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbovendedor
        '
        Me.cbovendedor.BackColor = System.Drawing.Color.White
        Me.cbovendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovendedor.Enabled = False
        Me.cbovendedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovendedor.Location = New System.Drawing.Point(619, 85)
        Me.cbovendedor.Name = "cbovendedor"
        Me.cbovendedor.Size = New System.Drawing.Size(190, 22)
        Me.cbovendedor.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(784, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "03:42:58 P.M."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(657, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 15)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "T.C. : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcambio
        '
        Me.lblcambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcambio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio.Location = New System.Drawing.Point(728, 4)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(52, 18)
        Me.lblcambio.TabIndex = 1
        Me.lblcambio.Text = "3.45"
        Me.lblcambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnConsultar)
        Me.GroupBox4.Controls.Add(Me.btnsalir)
        Me.GroupBox4.Controls.Add(Me.btncancelar)
        Me.GroupBox4.Controls.Add(Me.btngeneranuevo)
        Me.GroupBox4.Controls.Add(Me.btnreimprimir)
        Me.GroupBox4.Controls.Add(Me.btnanular)
        Me.GroupBox4.Controls.Add(Me.btnefectivo)
        Me.GroupBox4.Controls.Add(Me.btndsctototal)
        Me.GroupBox4.Controls.Add(Me.btndsctoitem)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.btnvale)
        Me.GroupBox4.Controls.Add(Me.btncredito)
        Me.GroupBox4.Controls.Add(Me.btncheque)
        Me.GroupBox4.Controls.Add(Me.btntarjeta)
        Me.GroupBox4.Location = New System.Drawing.Point(815, 67)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(118, 192)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(9, 73)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(102, 26)
        Me.BtnConsultar.TabIndex = 5
        Me.BtnConsultar.Text = "&Consultar"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(9, 127)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(102, 26)
        Me.btnsalir.TabIndex = 9
        Me.btnsalir.Text = "&Salir"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(9, 100)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(102, 26)
        Me.btncancelar.TabIndex = 7
        Me.btncancelar.Text = "&Cancelar "
        '
        'btngeneranuevo
        '
        Me.btngeneranuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngeneranuevo.Location = New System.Drawing.Point(9, 154)
        Me.btngeneranuevo.Name = "btngeneranuevo"
        Me.btngeneranuevo.Size = New System.Drawing.Size(102, 26)
        Me.btngeneranuevo.TabIndex = 11
        Me.btngeneranuevo.Text = "G&enera Nuevo"
        Me.btngeneranuevo.Visible = False
        '
        'btnreimprimir
        '
        Me.btnreimprimir.Location = New System.Drawing.Point(9, 46)
        Me.btnreimprimir.Name = "btnreimprimir"
        Me.btnreimprimir.Size = New System.Drawing.Size(102, 26)
        Me.btnreimprimir.TabIndex = 3
        Me.btnreimprimir.Text = "&Reimprimir"
        '
        'btnanular
        '
        Me.btnanular.Location = New System.Drawing.Point(132, 226)
        Me.btnanular.Name = "btnanular"
        Me.btnanular.Size = New System.Drawing.Size(102, 26)
        Me.btnanular.TabIndex = 13
        Me.btnanular.Text = "&Anular"
        Me.btnanular.Visible = False
        '
        'btnefectivo
        '
        Me.btnefectivo.Location = New System.Drawing.Point(9, 18)
        Me.btnefectivo.Name = "btnefectivo"
        Me.btnefectivo.Size = New System.Drawing.Size(102, 26)
        Me.btnefectivo.TabIndex = 0
        Me.btnefectivo.Text = "Guardar (F7)"
        '
        'btndsctototal
        '
        Me.btndsctototal.Location = New System.Drawing.Point(132, 195)
        Me.btndsctototal.Name = "btndsctototal"
        Me.btndsctototal.Size = New System.Drawing.Size(102, 26)
        Me.btndsctototal.TabIndex = 12
        Me.btndsctototal.Text = "Dscto al &Total"
        Me.btndsctototal.Visible = False
        '
        'btndsctoitem
        '
        Me.btndsctoitem.Location = New System.Drawing.Point(132, 169)
        Me.btndsctoitem.Name = "btndsctoitem"
        Me.btndsctoitem.Size = New System.Drawing.Size(102, 26)
        Me.btndsctoitem.TabIndex = 10
        Me.btndsctoitem.Text = "Dscto x &Item"
        Me.btndsctoitem.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(132, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 35)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Editar Numero (F12)"
        Me.Button3.Visible = False
        '
        'btnvale
        '
        Me.btnvale.Location = New System.Drawing.Point(132, 108)
        Me.btnvale.Name = "btnvale"
        Me.btnvale.Size = New System.Drawing.Size(102, 26)
        Me.btnvale.TabIndex = 6
        Me.btnvale.Text = "  Vale      (F11)"
        Me.btnvale.Visible = False
        '
        'btncredito
        '
        Me.btncredito.Location = New System.Drawing.Point(132, 82)
        Me.btncredito.Name = "btncredito"
        Me.btncredito.Size = New System.Drawing.Size(102, 26)
        Me.btncredito.TabIndex = 4
        Me.btncredito.Text = "Credito    (F10)"
        Me.btncredito.Visible = False
        '
        'btncheque
        '
        Me.btncheque.Location = New System.Drawing.Point(132, 56)
        Me.btncheque.Name = "btncheque"
        Me.btncheque.Size = New System.Drawing.Size(102, 26)
        Me.btncheque.TabIndex = 2
        Me.btncheque.Text = "Cheque   (F9)"
        Me.btncheque.Visible = False
        '
        'btntarjeta
        '
        Me.btntarjeta.Location = New System.Drawing.Point(132, 30)
        Me.btntarjeta.Name = "btntarjeta"
        Me.btntarjeta.Size = New System.Drawing.Size(102, 26)
        Me.btntarjeta.TabIndex = 1
        Me.btntarjeta.Text = "Tarjeta  (F8)"
        Me.btntarjeta.Visible = False
        '
        'LBLSIMBOLOCAMBIO
        '
        Me.LBLSIMBOLOCAMBIO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLOCAMBIO.Location = New System.Drawing.Point(709, 5)
        Me.LBLSIMBOLOCAMBIO.Name = "LBLSIMBOLOCAMBIO"
        Me.LBLSIMBOLOCAMBIO.Size = New System.Drawing.Size(17, 20)
        Me.LBLSIMBOLOCAMBIO.TabIndex = 3
        Me.LBLSIMBOLOCAMBIO.Text = "$"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.DefaultItem = True
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MdiList = True
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnufacdirec, Me.mnufactguia, Me.MenuItem4, Me.MenuItem3, Me.MenuItem2, Me.MenuItem5})
        Me.MenuItem1.Text = "Procesos"
        Me.MenuItem1.Visible = False
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
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7})
        Me.MenuItem6.Text = "Opcion"
        Me.MenuItem6.Visible = False
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.MenuItem7.Text = "NotaPedido"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(232, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "-"
        '
        'TXTSERIEDOC
        '
        Me.TXTSERIEDOC.BackColor = System.Drawing.Color.White
        Me.TXTSERIEDOC.Enabled = False
        Me.TXTSERIEDOC.Location = New System.Drawing.Point(190, 39)
        Me.TXTSERIEDOC.Name = "TXTSERIEDOC"
        Me.TXTSERIEDOC.Size = New System.Drawing.Size(43, 21)
        Me.TXTSERIEDOC.TabIndex = 9
        Me.TXTSERIEDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTNUMERODOC
        '
        Me.TXTNUMERODOC.BackColor = System.Drawing.Color.White
        Me.TXTNUMERODOC.Enabled = False
        Me.TXTNUMERODOC.Location = New System.Drawing.Point(245, 39)
        Me.TXTNUMERODOC.MaxLength = 7
        Me.TXTNUMERODOC.Name = "TXTNUMERODOC"
        Me.TXTNUMERODOC.Size = New System.Drawing.Size(80, 21)
        Me.TXTNUMERODOC.TabIndex = 11
        Me.TXTNUMERODOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CHKIGV
        '
        Me.CHKIGV.Checked = True
        Me.CHKIGV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKIGV.Location = New System.Drawing.Point(773, 25)
        Me.CHKIGV.Name = "CHKIGV"
        Me.CHKIGV.Size = New System.Drawing.Size(93, 20)
        Me.CHKIGV.TabIndex = 7
        Me.CHKIGV.Text = "Aplicar IGV"
        Me.CHKIGV.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BtnBuscar.ImageIndex = 5
        Me.BtnBuscar.ImageList = Me.ImageList1
        Me.BtnBuscar.Location = New System.Drawing.Point(326, 38)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(35, 23)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LblEstado
        '
        Me.LblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblEstado.Location = New System.Drawing.Point(2, 458)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(11, 15)
        Me.LblEstado.TabIndex = 39
        Me.LblEstado.Visible = False
        '
        'cbTipoPrecio
        '
        Me.cbTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPrecio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoPrecio.Location = New System.Drawing.Point(288, -3)
        Me.cbTipoPrecio.Name = "cbTipoPrecio"
        Me.cbTipoPrecio.Size = New System.Drawing.Size(209, 22)
        Me.cbTipoPrecio.TabIndex = 29
        Me.cbTipoPrecio.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label20.Location = New System.Drawing.Point(120, 138)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Tipo Precio :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'LblPagador
        '
        Me.LblPagador.AutoSize = True
        Me.LblPagador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LblPagador.Location = New System.Drawing.Point(561, 112)
        Me.LblPagador.Name = "LblPagador"
        Me.LblPagador.Size = New System.Drawing.Size(56, 13)
        Me.LblPagador.TabIndex = 25
        Me.LblPagador.Text = "Pagador : "
        Me.LblPagador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblPagador.Visible = False
        '
        'CboPagador
        '
        Me.CboPagador.BackColor = System.Drawing.Color.White
        Me.CboPagador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPagador.Enabled = False
        Me.CboPagador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPagador.Location = New System.Drawing.Point(619, 109)
        Me.CboPagador.Name = "CboPagador"
        Me.CboPagador.Size = New System.Drawing.Size(190, 22)
        Me.CboPagador.TabIndex = 27
        Me.CboPagador.Visible = False
        '
        'CTRLCANTIDAD
        '
        Me.CTRLCANTIDAD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTRLCANTIDAD.Location = New System.Drawing.Point(377, 55)
        Me.CTRLCANTIDAD.Name = "CTRLCANTIDAD"
        Me.CTRLCANTIDAD.Size = New System.Drawing.Size(60, 21)
        Me.CTRLCANTIDAD.TabIndex = 10
        Me.CTRLCANTIDAD.Text = "0.00"
        Me.CTRLCANTIDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttipo
        '
        Me.txttipo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttipo.Location = New System.Drawing.Point(74, 85)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(75, 21)
        Me.txttipo.TabIndex = 13
        Me.txttipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttipo.Visible = False
        '
        'txtcodarticulo
        '
        Me.txtcodarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodarticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodarticulo.Location = New System.Drawing.Point(99, 22)
        Me.txtcodarticulo.Name = "txtcodarticulo"
        Me.txtcodarticulo.Size = New System.Drawing.Size(89, 21)
        Me.txtcodarticulo.TabIndex = 2
        '
        'cbPresentacion
        '
        Me.cbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPresentacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPresentacion.ItemHeight = 13
        Me.cbPresentacion.Location = New System.Drawing.Point(98, 55)
        Me.cbPresentacion.Name = "cbPresentacion"
        Me.cbPresentacion.Size = New System.Drawing.Size(185, 21)
        Me.cbPresentacion.TabIndex = 8
        '
        'btneliitem
        '
        Me.btneliitem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliitem.Location = New System.Drawing.Point(608, 40)
        Me.btneliitem.Name = "btneliitem"
        Me.btneliitem.Size = New System.Drawing.Size(32, 17)
        Me.btneliitem.TabIndex = 5
        Me.btneliitem.Text = "Elimina"
        Me.btneliitem.Visible = False
        '
        'btnactuitem
        '
        Me.btnactuitem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnactuitem.Location = New System.Drawing.Point(612, 15)
        Me.btnactuitem.Name = "btnactuitem"
        Me.btnactuitem.Size = New System.Drawing.Size(26, 17)
        Me.btnactuitem.TabIndex = 0
        Me.btnactuitem.Text = "actualiza"
        Me.btnactuitem.Visible = False
        '
        'btnnueitem
        '
        Me.btnnueitem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnueitem.Location = New System.Drawing.Point(649, 9)
        Me.btnnueitem.Name = "btnnueitem"
        Me.btnnueitem.Size = New System.Drawing.Size(21, 52)
        Me.btnnueitem.TabIndex = 6
        Me.btnnueitem.Text = "Nuevo"
        Me.btnnueitem.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(466, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Precio : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Cantidad : "
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Enabled = False
        Me.txtdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(241, 22)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(330, 21)
        Me.txtdescripcion.TabIndex = 4
        '
        'BtnBuscArt
        '
        Me.BtnBuscArt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscArt.ImageIndex = 5
        Me.BtnBuscArt.ImageList = Me.ImageList1
        Me.BtnBuscArt.Location = New System.Drawing.Point(191, 21)
        Me.BtnBuscArt.Name = "BtnBuscArt"
        Me.BtnBuscArt.Size = New System.Drawing.Size(44, 23)
        Me.BtnBuscArt.TabIndex = 3
        Me.BtnBuscArt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Articulo : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "N Bultos :"
        Me.Label17.Visible = False
        '
        'CTRLPRECIO
        '
        Me.CTRLPRECIO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTRLPRECIO.Location = New System.Drawing.Point(512, 55)
        Me.CTRLPRECIO.Name = "CTRLPRECIO"
        Me.CTRLPRECIO.Size = New System.Drawing.Size(60, 21)
        Me.CTRLPRECIO.TabIndex = 11
        Me.CTRLPRECIO.Text = "0.00"
        Me.CTRLPRECIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 59)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(76, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Presentación :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CTRLCANTIDAD)
        Me.GroupBox1.Controls.Add(Me.txttipo)
        Me.GroupBox1.Controls.Add(Me.txtcodarticulo)
        Me.GroupBox1.Controls.Add(Me.cbPresentacion)
        Me.GroupBox1.Controls.Add(Me.btneliitem)
        Me.GroupBox1.Controls.Add(Me.btnactuitem)
        Me.GroupBox1.Controls.Add(Me.btnnueitem)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.BtnBuscArt)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.CTRLPRECIO)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.cbTipoPrecio)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 96)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'TxtTOTAL
        '
        Me.TxtTOTAL.BackColor = System.Drawing.Color.White
        Me.TxtTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTOTAL.Location = New System.Drawing.Point(913, 8)
        Me.TxtTOTAL.Name = "TxtTOTAL"
        Me.TxtTOTAL.Size = New System.Drawing.Size(95, 26)
        Me.TxtTOTAL.TabIndex = 9
        Me.TxtTOTAL.Text = "0.00"
        Me.TxtTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDESC
        '
        Me.TxtDESC.BackColor = System.Drawing.Color.White
        Me.TxtDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDESC.Location = New System.Drawing.Point(516, 11)
        Me.TxtDESC.Name = "TxtDESC"
        Me.TxtDESC.Size = New System.Drawing.Size(95, 26)
        Me.TxtDESC.TabIndex = 6
        Me.TxtDESC.Text = "0.00"
        Me.TxtDESC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSUBTOTAL
        '
        Me.TxtSUBTOTAL.BackColor = System.Drawing.Color.White
        Me.TxtSUBTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSUBTOTAL.Location = New System.Drawing.Point(152, 11)
        Me.TxtSUBTOTAL.Name = "TxtSUBTOTAL"
        Me.TxtSUBTOTAL.Size = New System.Drawing.Size(95, 26)
        Me.TxtSUBTOTAL.TabIndex = 2
        Me.TxtSUBTOTAL.Text = "0.00"
        Me.TxtSUBTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIGV
        '
        Me.TxtIGV.BackColor = System.Drawing.Color.White
        Me.TxtIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIGV.Location = New System.Drawing.Point(322, 11)
        Me.TxtIGV.Name = "TxtIGV"
        Me.TxtIGV.Size = New System.Drawing.Size(95, 26)
        Me.TxtIGV.TabIndex = 4
        Me.TxtIGV.Text = "0.00"
        Me.TxtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLSIMBOLO2
        '
        Me.LBLSIMBOLO2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO2.Location = New System.Drawing.Point(342, 14)
        Me.LBLSIMBOLO2.Name = "LBLSIMBOLO2"
        Me.LBLSIMBOLO2.Size = New System.Drawing.Size(32, 21)
        Me.LBLSIMBOLO2.TabIndex = 5
        Me.LBLSIMBOLO2.Text = "S/."
        '
        'LBLSIMBOLO4
        '
        Me.LBLSIMBOLO4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO4.Location = New System.Drawing.Point(884, 12)
        Me.LBLSIMBOLO4.Name = "LBLSIMBOLO4"
        Me.LBLSIMBOLO4.Size = New System.Drawing.Size(31, 19)
        Me.LBLSIMBOLO4.TabIndex = 10
        Me.LBLSIMBOLO4.Text = "S/."
        '
        'lblsimbolo
        '
        Me.lblsimbolo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsimbolo.Location = New System.Drawing.Point(121, 14)
        Me.lblsimbolo.Name = "lblsimbolo"
        Me.lblsimbolo.Size = New System.Drawing.Size(28, 21)
        Me.lblsimbolo.TabIndex = 1
        Me.lblsimbolo.Text = "S/. :"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(18, 14)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(119, 21)
        Me.lblsubtotal.TabIndex = 0
        Me.lblsubtotal.Text = "SUB TOTAL."
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(435, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 22)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "DESC % "
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(819, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 19)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "TOTAL"
        '
        'LBLIGV
        '
        Me.LBLIGV.AllowDrop = True
        Me.LBLIGV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIGV.Location = New System.Drawing.Point(272, 13)
        Me.LBLIGV.Name = "LBLIGV"
        Me.LBLIGV.Size = New System.Drawing.Size(51, 22)
        Me.LBLIGV.TabIndex = 3
        Me.LBLIGV.Text = "IGV  "
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
        Me.GroupBox3.Location = New System.Drawing.Point(10, 459)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1031, 60)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.AllowDrop = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(640, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 22)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "IPERCEP  "
        '
        'txtpercp
        '
        Me.txtpercp.BackColor = System.Drawing.Color.White
        Me.txtpercp.Enabled = False
        Me.txtpercp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpercp.Location = New System.Drawing.Point(718, 10)
        Me.txtpercp.Name = "txtpercp"
        Me.txtpercp.Size = New System.Drawing.Size(95, 26)
        Me.txtpercp.TabIndex = 43
        Me.txtpercp.Text = "0.00"
        Me.txtpercp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CTRLDESC
        '
        Me.CTRLDESC.Enabled = True
        Me.CTRLDESC.Location = New System.Drawing.Point(977, 299)
        Me.CTRLDESC.Name = "CTRLDESC"
        Me.CTRLDESC.OcxState = CType(resources.GetObject("CTRLDESC.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CTRLDESC.Size = New System.Drawing.Size(115, 25)
        Me.CTRLDESC.TabIndex = 34
        '
        'CTRLTOTAL
        '
        Me.CTRLTOTAL.Enabled = True
        Me.CTRLTOTAL.Location = New System.Drawing.Point(977, 329)
        Me.CTRLTOTAL.Name = "CTRLTOTAL"
        Me.CTRLTOTAL.OcxState = CType(resources.GetObject("CTRLTOTAL.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CTRLTOTAL.Size = New System.Drawing.Size(115, 25)
        Me.CTRLTOTAL.TabIndex = 35
        Me.CTRLTOTAL.Visible = False
        '
        'CTRLSUBTOTAL
        '
        Me.CTRLSUBTOTAL.Enabled = True
        Me.CTRLSUBTOTAL.Location = New System.Drawing.Point(977, 357)
        Me.CTRLSUBTOTAL.Name = "CTRLSUBTOTAL"
        Me.CTRLSUBTOTAL.OcxState = CType(resources.GetObject("CTRLSUBTOTAL.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CTRLSUBTOTAL.Size = New System.Drawing.Size(115, 25)
        Me.CTRLSUBTOTAL.TabIndex = 36
        Me.CTRLSUBTOTAL.Visible = False
        '
        'CTRLIGV
        '
        Me.CTRLIGV.Enabled = True
        Me.CTRLIGV.Location = New System.Drawing.Point(977, 389)
        Me.CTRLIGV.Name = "CTRLIGV"
        Me.CTRLIGV.OcxState = CType(resources.GetObject("CTRLIGV.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CTRLIGV.Size = New System.Drawing.Size(115, 25)
        Me.CTRLIGV.TabIndex = 37
        Me.CTRLIGV.Visible = False
        '
        'gbtipodoc
        '
        Me.gbtipodoc.Controls.Add(Me.rbboleta)
        Me.gbtipodoc.Controls.Add(Me.rbfactura)
        Me.gbtipodoc.Controls.Add(Me.rbnotap)
        Me.gbtipodoc.Location = New System.Drawing.Point(617, 139)
        Me.gbtipodoc.Name = "gbtipodoc"
        Me.gbtipodoc.Size = New System.Drawing.Size(190, 95)
        Me.gbtipodoc.TabIndex = 31
        Me.gbtipodoc.TabStop = False
        Me.gbtipodoc.Text = "Tipo Documento :"
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
        Me.rbfactura.Location = New System.Drawing.Point(16, 40)
        Me.rbfactura.Name = "rbfactura"
        Me.rbfactura.Size = New System.Drawing.Size(104, 24)
        Me.rbfactura.TabIndex = 1
        Me.rbfactura.Text = "Factura"
        '
        'rbnotap
        '
        Me.rbnotap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnotap.Location = New System.Drawing.Point(16, 64)
        Me.rbnotap.Name = "rbnotap"
        Me.rbnotap.Size = New System.Drawing.Size(104, 24)
        Me.rbnotap.TabIndex = 2
        Me.rbnotap.Text = "Nota Pedido"
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(588, 27)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 40
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 26)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Guardar "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(205, 536)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 26)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Refrescar"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(364, -1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(285, 31)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "COTIZACION"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRMCOTIZACION
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1286, 578)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbtipodoc)
        Me.Controls.Add(Me.CTRLIGV)
        Me.Controls.Add(Me.CTRLSUBTOTAL)
        Me.Controls.Add(Me.CTRLTOTAL)
        Me.Controls.Add(Me.CTRLDESC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CboPagador)
        Me.Controls.Add(Me.TXTNUMERODOC)
        Me.Controls.Add(Me.TXTSERIEDOC)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.txtruc)
        Me.Controls.Add(Me.txtcodclie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LblPagador)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpfechadoc)
        Me.Controls.Add(Me.LblEstado)
        Me.Controls.Add(Me.lbltipodoc)
        Me.Controls.Add(Me.cbovendedor)
        Me.Controls.Add(Me.CHKIGV)
        Me.Controls.Add(Me.LBLSIMBOLOCAMBIO)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblcambio)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbloperador)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.btnBusCli)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "FRMCOTIZACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CTRLDESC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTRLTOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTRLSUBTOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CTRLIGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbtipodoc.ResumeLayout(False)
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "Variables  Form"
    Dim flagfac As Boolean
    Dim FLAGNUMGUIA As Boolean = False
    Dim IGVFAC As Double
    Dim dni As String
    Public VIE1 As New FACT_ZONPTOVTA
    Dim tmonto As Double
    Dim oknopide As Boolean
    Dim flagclie As Boolean = True
    Dim MontoBoleta As Double
    Dim Ayuda As New ClsAyuda
    'Dim ClsDa As New clsdatos_JHON
    'Dim ClsInter As New ClsInterface
    Public VarCodPresentacion As String = String.Empty
    Public VarTipoDoc As String
    Public ConfirGuardar As Boolean = False
    Public LimiteItems As Integer = 0
    Private TMP_VENTADET As New DataTable
    Private TMP_PRESENTACION As New DataTable
    Private Consul_var As Boolean
    Private ActEventCombo As Boolean
    Dim SW As Boolean
#End Region

#Region "Funciones del Formulario"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        If ((MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM)) Then
            Select Case KeyData
                Case Keys.F3
                    If TMP_VENTADET.Rows.Count > 0 Then
                        If Grid1.Focus = True And Consul_var = False Then
                            elimina_item()
                        End If
                    End If
                Case Keys.F2
                    If Grid1.Focus = True And Consul_var = False Then
                        Modificar_item()
                    End If
                Case Keys.F7
                    btnefectivo.PerformClick()
            End Select
        End If
    End Function
    Private Sub BuscarDocumento()
        Dim FrmDoc As New FrmConsultarCotizacion
        FrmDoc.ShowDialog()
        If FrmDoc.DEVOLVER = False Then
            Exit Sub
        End If

        Dim xCodDoc As String, xMoneda As String
        Dim TblDoc As New DataTable
        With CType(FrmDoc.VentaCabEBindingSource.Current, VentaCabE)
            VCdTipoDoc = RTrim(.CODTIPODOC)
            VNroDoc = .NRODOCU
            TablaDet = .VENTACAB.Replace("VENTC", "VENTD")
            'Conecta("SELECT * FROM VENTACAB WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND NRODOCU = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA & "'", "x")
            'If ds.Tables("x").Rows.Count = 1 Then
            '    Tabla = "VENTACAB"
            '    TablaDet = "VENTADET"
            'Else
            '    Conecta("SELECT * FROM HISTOVENTAS ORDER BY VENTCAB DESC", "x")
            '    Dim Tu As Long
            '    For Tu = 0 To ds.Tables("x").Rows.Count - 1
            '        Tabla = Trim(ds.Tables("x").Rows(Tu).Item("VENTCAB").ToString())

            '        Conecta("SELECT * FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND NRODOCU = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA & "'", "x")
            '        If ds.Tables("x").Rows.Count = 1 Then Exit For
            '    Next
            '    TablaDet = "VENTD" + Mid(Tabla, 6, 6)
            'End If

            TblDoc = CAyuda.ListarDatos("USP_CONSULTAR_DOCUMENTO", VCdTipoDoc, VNroDoc, NROPTOVTA, .CODCLIENTE, codempresa, .VENTACAB).Tables(0)
            If TblDoc.Rows.Count = 1 Then
                With TblDoc
                    TXTSERIEDOC.Text = NROPTOVTA
                    TXTNUMERODOC.Text = Strings.Right(Trim(.Rows(0).Item("NRODOCU").ToString()), 7)
                    txtcodclie.Text = Trim(.Rows(0).Item("CODCLIENTE").ToString())
                    Dim Ruc As String
                    Ruc = Len(Trim(.Rows(0).Item("RUCCLIENTE").ToString()))
                    If Ruc = DigitosRuc Then
                        Label5.Text = "R.U.C :"
                        txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
                    Else
                        Label5.Text = "DNI :"
                        txtruc.Text = Trim(.Rows(0).Item("RUCCLIENTE").ToString())
                    End If
                    txtcliente.Text = Trim(.Rows(0).Item("DESCLIENTE").ToString())
                    txtdireccion.Text = Trim(.Rows(0).Item("DIRCLIENTE").ToString())
                    'Factura.cbomoneda.SelectedValue = Trim(.Rows(0).Item("CODMON").ToString())
                    dtpfechadoc.Value = Format(.Rows(0).Item("FECDOCUM"), "dd/MM/yyyy")
                    cbovendedor.SelectedValue = Trim(.Rows(0).Item("CODVEND").ToString())
                    'txtnotapesada.Text = Trim(.Rows(0).Item("NPESADA").ToString())
                    'txtnroguias.Text = Trim(.Rows(0).Item("NROGUIA").ToString())
                    lbloperador.Text = Trim(.Rows(0).Item("CDUSUARIO").ToString())
                    TxtSUBTOTAL.Text = .Rows(0).Item("SUBTOTAL")
                    TxtIGV.Text = .Rows(0).Item("IGV")
                    TxtDESC.Text = .Rows(0).Item("DSCTO")
                    TxtTOTAL.Text = .Rows(0).Item("TOTAL")
                    LblEstado.Text = Trim(.Rows(0).Item("ESTADO").ToString())
                    REM Si el Documento Esta Anulado
                    If Trim(.Rows(0).Item("ESTADO").ToString()) = "A" Then
                        btnanular.Enabled = False
                        btngeneranuevo.Enabled = False
                        btnreimprimir.Enabled = False
                    Else
                        btnanular.Enabled = True
                        btngeneranuevo.Enabled = True
                        btnreimprimir.Enabled = True
                    End If
                End With
            End If
            'FACT_Cargagriddetalledirecto(Grid1, "USP_LISTAR_DETALLE_DOCUMENTO '" & .Item(.CurrentRowIndex, 0) & "','" & .Item(.CurrentRowIndex, 2) & "','" & NROPTOVTA & "','" & codempresa & "'")
            CAyuda.Ejecutar("SP_CARGAR_DOCUMENTO_COTIZACION", codempresa, VCdTipoDoc, VNroDoc, VCorrelVta, Format(Date.Now, "dd/MM/yyyy"))
            CargarGridFact()
            FormatoGridDetVta()

            TblDoc = Nothing
            xCodDoc = .CODTIPODOC
            xMoneda = .CODMON

            Consul_var = True
            gbtipodoc.Enabled = False
            Select Case VCdTipoDoc
                Case CDBOLETA
                    rbboleta.Checked = True
                Case CDFACTURA
                    rbfactura.Checked = True
                Case CDNTAPEDIDO
                    rbnotap.Checked = True
            End Select

            ConfigDocumento()

            If xMoneda = "S" Then
                lblsimbolo.Text = "S/."
                LBLSIMBOLO2.Text = "S/."
                LBLSIMBOLO4.Text = "S/."
            Else
                lblsimbolo.Text = "$"
                LBLSIMBOLO2.Text = "$"
                LBLSIMBOLO4.Text = "$"
            End If

            'lblsimbolo.Visible = True
            'LBLSIMBOLO2.Visible = True
            LBLSIMBOLO4.Visible = True
            'lblsubtotal.Visible = True
            'LBLIGV.Visible = True
            'TxtSUBTOTAL.Visible = True
            'TxtIGV.Visible = True

            'Factura.btnbus.Enabled = False
            txtcodclie.Enabled = False
            txtruc.Enabled = False
            txtcliente.Enabled = False
            txtdireccion.Enabled = False
            'Factura.cbomoneda.Enabled = False
            dtpfechadoc.Enabled = False
            cbovendedor.Enabled = False
            'txtnotapesada.Enabled = False
            GroupBox1.Enabled = False
            btnefectivo.Enabled = False
            btntarjeta.Enabled = False
            btncheque.Enabled = False
            btncredito.Enabled = False
            btnvale.Enabled = False
            Button3.Enabled = False
            btndsctoitem.Enabled = False
            btndsctototal.Enabled = False
        End With

    End Sub
    Private Sub INSERT_TMP_DETALLE()

        If CTRLCANTIDAD.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR LA CANTIDAD...", MsgBoxStyle.Exclamation, "")
            CTRLCANTIDAD.Focus()
            Exit Sub
        End If
        If CTRLCANTIDAD.Text.Trim = "." Then
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

        Dim dt_stk As New DataTable
        Dim stkPE, stkAct, factor, totpt, stkPedPt As Integer
        Dim msgst, desp As String
        dt_stk = CAyuda.ListarDatos("SP_CALCULA_STOCK_FACT", cbPresentacion.SelectedValue, CInt(CTRLCANTIDAD.Text), codempresa.Trim, CDZONA.Trim, txtcodarticulo.Text.Trim).Tables(0)

        stkPE = CInt(dt_stk.Rows(0)(1))
        stkAct = dt_stk.Rows(0)(2)
        factor = dt_stk.Rows(0)(0)
        stkPedPt = dt_stk.Rows(0)(3)
        desp = dt_stk.Rows(0)(4)
        totpt = stkAct Mod factor

        If CInt(CTRLCANTIDAD.Text.Trim) > stkPedPt Then
            If stkPedPt <> 0 Then
                If totpt > 0 Then
                    msgst = "- NO HAY STOCK SUFICIENTE, EN EL ALMACEN SOLO QUEDA :" & vbNewLine & "- " & stkPedPt & " " & cbPresentacion.Text & " y " & totpt & " " & desp
                Else
                    msgst = "- NO HAY STOCK SUFICIENTE, EN EL ALMACEN SOLO QUEDA :" & vbNewLine & "- " & stkPedPt & " " & cbPresentacion.Text & ""
                End If
            Else
                If totpt > 0 Then
                    msgst = "- NO HAY STOCK SUFICIENTE, EN EL ALMACEN SOLO QUEDA :" & vbNewLine & "- " & totpt & " " & desp
                Else
                    msgst = "- NO HAY STOCK EN EL ALMACEN "
                End If
            End If
            MessageBox.Show(msgst, "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            If MessageBox.Show("- DESEA AGREGAR EL ARTICULO AL DOCUMENTO DE TODO MODOS?.", "NARSISTEMAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
        End If







        Dim Item As Integer = TMP_VENTADET.Rows.Count + 1
        If VItemDoc < Item Then
            MsgBox("EL NUMERO DE FILAS ESCEDE AL NUMERO ESTABLECIDO EN  CONFIG..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        'Dim TbVerifCombo As DataTable
        'TbVerifCombo = CAyuda.ListarDatos("NSP_VERIFICAR_COMBO", codempresa, txtcodarticulo.Text).Tables(0)
        'If TbVerifCombo.Rows.Count > 0 Then

        'Dim Tblistarticomb As DataTable
        'Tblistarticomb = CAyuda.ListarDatos("NSP_LISTA_ARTICULOSCOMBO", codempresa, txtcodarticulo.Text).Tables(0)

        'For x As Integer = 0 To Tblistarticomb.Rows.Count - 1
        '    Dim codpresent As String
        '    Dim Tbpresent As DataTable
        '    Tbpresent = CAyuda.ListarDatos("NSP_BUSQ_PRESEN", codempresa, Tblistarticomb.Rows(x)("MNPRESENT").ToString).Tables(0)
        '    codpresent = Tbpresent.Rows(0)("codpres").ToString
        '    Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADET", codempresa, Tblistarticomb.Rows(x)("codarti").ToString, codpresent, Tblistarticomb.Rows(x)("MNPRESENT").ToString, Tblistarticomb.Rows(x)("cantidad").ToString, CDbl(CTRLPRECIO.Text), CDbl(CTRLPRECIO.Text), VDescTotbas, CodUsuario, NROPTOVTA, VCorrelVta, "", cbTipoPrecio.SelectedValue, CDZONA, CHECKPROMO)

        'Next
        '        Tabla = Trim(ds.Tables("x").Rows(Tu).Item("VENTCAB").ToString())

        '        Conecta("SELECT * FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND NRODOCU = " & VNroDoc & " AND NROPTOVTA = '" & NROPTOVTA & "'", "x")
        '        If ds.Tables("x").Rows.Count = 1 Then Exit For
        '    Next


        'End If








        Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADETFD", codempresa, txtcodarticulo.Text, cbPresentacion.SelectedValue, cbPresentacion.Text, CTRLCANTIDAD.Text, CDbl(CTRLPRECIO.Text), CDbl(CTRLPRECIO.Text), VDescTotbas, CodUsuario, NROPTOVTA, VCorrelVta, "", cbTipoPrecio.SelectedValue, CDZONA, CHECKPROMO)
        CargarGridFact()
        FormatoGridDetVta()
        LimpiarCjaTxtDet()
        txtcodarticulo.Focus()

    End Sub
    Private Sub LimpiarVar()
        VCorrelVta = 0
        VRuc = ""
        VClieDep = ""
        VUsarNotaPedido = False
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
    Private Sub CargarGridFact()
        TMP_VENTADET = TmpListarDatos("sp_sele_TMP_VENTADETFD  '" & VCorrelVta & "','" & codempresa & "'")
        Grid1.DataSource = TMP_VENTADET
        If TMP_VENTADET.Rows.Count > 0 Then

            Dim TABLE_VTA As New DataTable
            TABLE_VTA = TmpListarDatos("OBTIENE_TOTALES_FACTURACION_PROCFD  '" & codempresa & "','" & VCorrelVta & "'")
            TxtTOTAL.Text = FormatoMonto(TABLE_VTA.Rows(0)("TOTBAS"), DECIRESU)
            TxtSUBTOTAL.Text = FormatoMonto(TABLE_VTA.Rows(0)("SUBTOTBAS"), DECIRESU)
            TxtIGV.Text = FormatoMonto(TABLE_VTA.Rows(0)("IGVBAS"), DECIRESU)


            Dim TABLE_VERIPER As New DataTable
            TABLE_VERIPER = TmpListarDatos("SP_VERIFIC_PERCEP  '" & codempresa & "','" & VCdTipoDoc & "'")

            If TABLE_VERIPER.Rows.Count > 0 Then
                If CInt(TABLE_VERIPER.Rows(0)(0)) = -1 Then
                    Dim precepclien As Double
                    Dim TABLE_VTA3 As New DataTable
                    TABLE_VTA3 = TmpListarDatos("SP_BUSQ_PERCECLIDEP  '" & codempresa & "','" & txtcodclie.Text & "'")
                    precepclien = FormatoMonto(TABLE_VTA3.Rows(0)(0), DECIRESU)

                    If VCdTipoDoc = "03" Then
                        Dim TABLE_VTA2 As New DataTable
                        TABLE_VTA2 = TmpListarDatos("SP_MONTOPERCEPCIONB_FD  '" & codempresa & "','" & VCorrelVta & "'," & precepclien)
                        txtpercp.Text = FormatoMonto(TABLE_VTA2.Rows(0)(0), DECIRESU)
                        TxtTOTAL.Text = FormatoMonto(TABLE_VTA2.Rows(0)(1), DECIRESU)
                    End If

                    If VCdTipoDoc = "01" Then
                        Dim TABLE_VTA2 As New DataTable
                        TABLE_VTA2 = TmpListarDatos("SP_MONTOPERCEPCIONF_FD  '" & codempresa & "','" & VCorrelVta & "'," & precepclien)
                        txtpercp.Text = FormatoMonto(TABLE_VTA2.Rows(0)(0), DECIRESU)
                        TxtTOTAL.Text = FormatoMonto(TABLE_VTA2.Rows(0)(1), DECIRESU)
                    End If

                Else
                    txtpercp.Text = 0.0
                End If


            End If







        Else

            TxtTOTAL.Text = "0.00"
            TxtSUBTOTAL.Text = "0.00"
            TxtIGV.Text = "0.00"


            txtpercp.Text = "0.00"

        End If







    End Sub
    Private Sub IniciarConfigFact()
        If FACT_EDITPRECIO = True Then
            CTRLPRECIO.Enabled = True
        Else
            CTRLPRECIO.Enabled = False
        End If
        If VEEIDTFECHA = True Then
            dtpfechadoc.Enabled = True
        Else
            dtpfechadoc.Enabled = False
        End If
    End Sub
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

            Label5.Visible = False
            txtruc.Visible = False

        ElseIf VCdTipoDoc = CDFACTURA Then
            lbltipodoc.Text = "FACTURA"
            TxtIGV.Visible = True
            TxtSUBTOTAL.Visible = True
            lblsubtotal.Visible = True
            LBLIGV.Visible = True
            lblsimbolo.Visible = True
            LBLSIMBOLO2.Visible = True
            VItemDoc = ITEMDEFACT

            Label5.Visible = True
            txtruc.Visible = True

        ElseIf VCdTipoDoc = CDNTAPEDIDO Then
            lbltipodoc.Text = "NOTA DE PEDIDO"
            TxtIGV.Visible = False
            TxtSUBTOTAL.Visible = False
            lblsubtotal.Visible = False
            LBLIGV.Visible = False
            lblsimbolo.Visible = False
            LBLSIMBOLO2.Visible = False
            VItemDoc = ITEMDENTAPEDIDO

            Label5.Visible = False
            txtruc.Visible = False

        End If
    End Sub
    Sub cargadatos()
        CAyuda.CargarDataCombo(cbovendedor, "SP_ListVendedor '" & codempresa & "'", "CODVEND", "DSVEND")
        CAyuda.CargarDataCombo(cbTipoPrecio, "NSP_Select_Listado_TipoPrecio '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(CboPagador, "SP_Listar_CLIDEP '" & codempresa & "'", "CODDEP", "DATOADJUNTO")
        If cbovendedor.Text = "" Then
            MessageBox.Show("NO HAY VENDEDOR PARA ESTE PUNTO DE VENTA VERIFIQUE", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If
    End Sub
    Sub inicia_variables()
        lbloperador.Text = CodUsuario
        dtpfechadoc.Value = Format(vFechaActual, "dd/MM/yyyy")
        Call CARGAPERMISOSUSUARIO(CodUsuario)
    End Sub
    Private Sub cinfigcliente()
        Try
            Dim ds As New DataSet



            If VCodCliente.Trim = "" Then
                flagclie = False
                Exit Sub
            End If
            valclientevarios()
            ds.Dispose()
            TIPODOC()
            ds = CAyuda.ListarDatos("NSP_SELE_clienteFac", codempresa, VClieDep, 0, NROPTOVTA.Trim)
            If ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("El cliente Pagador no tiene Vendedor Asociado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            cbovendedor.SelectedValue = ds.Tables(0).Rows(0)(5)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub validacliente()
        Dim clie As String
        Dim sql As String
        sql = "NSP_SELE_clienteFac '" & codempresa & "','" & VCodCliente & "',0,'" & NROPTOVTA.Trim & "'"
        ds = CAyuda.ListarDatos(sql)
        If ds.Tables(0).Rows.Count = 0 Then
            txtruc.Text = ""
            txtcliente.Text = ""
            txtdireccion.Text = ""
            MsgBox("El Cliente No existe", MsgBoxStyle.Information)
            flagclie = False
            Exit Sub
        Else
            flagclie = True
        End If
        Try
            Me.txtcodclie.Text = ds.Tables(0).Rows(0)(0)
            Me.txtruc.Text = ds.Tables(0).Rows(0)("Documento")
            clie = ds.Tables(0).Rows(0)(1)
            'txtcliente.Text = clie
            'txtdireccion.Text = ds.Tables(0).Rows(0)(2)
            dni = ds.Tables(0).Rows(0)(7)
            VCodCliente = txtcodclie.Text
            VClieDep = txtcodclie.Text

            'TIPO = ds.Tables(0).Rows(0)(4)
            'If TIPO = "DNI" Then
            '    txtruc.Text = ds.Tables(0).Rows(0)(7)
            'End If
            'If TIPO = "RUC" Then
            '    txtruc.Text = ds.Tables(0).Rows(0)(3)
            'End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub valclientevarios()
        If VClieDep = txtcodclie.Text.Trim Then
            txtcliente.Text = ""
            txtdireccion.Text = ""
            txtruc.Focus()
        End If
    End Sub
    Sub tipodocumento()
        '  flagfac = True

        If flagfac = False Then
            lbltipodoc.Text = "BOLETA"
            IGVFAC = 0
            LBLIGV.Visible = False
            TxtIGV.Visible = False
            lblsubtotal.Visible = False
            TxtSUBTOTAL.Visible = False
            VCdTipoDoc = CDBOLETA
            lblsimbolo.Visible = False
            LBLSIMBOLO2.Visible = False
            Label5.Text = "DNI"
        Else
            Dim status As Boolean
            If Trim(txtruc.Text) <> "" Then
                status = FACT_GValidaRUC(Trim(txtruc.Text))
                If status = False Then
                    Exit Sub
                End If
            End If
            lbltipodoc.Text = "FACTURA"
            VCdTipoDoc = CDFACTURA
            IGVFAC = 0
            LBLIGV.Visible = True
            Label5.Text = "RUC."
            'CTRLIGV.Visible = True
            lblsubtotal.Visible = True
            'CTRLSUBTOTAL.Visible = True
            lblsimbolo.Visible = True
            LBLSIMBOLO2.Visible = True
            TxtSUBTOTAL.Visible = True
            TxtIGV.Visible = True
        End If
    End Sub
    Sub MUESTRAARTICULO()
        Try
            Dim DS As New DataSet
            'cbPresentacion.Items.Clear()
            'ListBox1.Items.Clear()
            If VCodArti <> "" Then
                txtcodarticulo.Text = VCodArti
            End If

            'If VarCodPresentacion.Trim.Length = 0 Then

            'End If

            'DS = CAyuda.ListarDatos("NSP_ARTICULOPRECIOFAC_ARTICULO '" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & VarCodPresentacion.Trim & "'")
            DS = CAyuda.ListarDatos("SP_VAL_ARTICULO", codempresa, CDZONA, txtcodarticulo.Text.Trim)
            If DS.Tables(0).Rows.Count <= 0 Then
                MessageBox.Show("Articulo No existe Verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtcodarticulo.Text = ""
                Me.CTRLCANTIDAD.Text = ""
                Me.txtdescripcion.Text = ""
                Me.CTRLPRECIO.Text = FACT_GFormatodeNumero(0)
                VCodArti = ""
                Me.txtcodarticulo.Focus()
                Exit Sub
            Else
                txtdescripcion.Text = DS.Tables(0).Rows(0)(1)

                TMP_PRESENTACION = TmpListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT  '" & codempresa & "','" & txtcodarticulo.Text & "','" & CDTIPOPRE1 & "', " & IIf(PPPUNTOVENTA = True, 1, 0) & " , " & IIf(PPFUERZVENTA = True, 1, 0) & "")

                cbPresentacion.DataSource = TMP_PRESENTACION
                cbPresentacion.ValueMember = "CODPRES"
                cbPresentacion.DisplayMember = "DESPRES"
                ActEventCombo = True
                Dim sender As Object = Nothing
                Dim e As EventArgs = Nothing
                cbPresentacion_SelectedIndexChanged(sender, e)
                cbPresentacion.Focus()

            End If

            'If Me.txtcodarticulo.Text.Trim.Length > 0 Then
            '    Dim TablaComboPresent As New DataTable
            '    TablaComboPresent = CAyuda.ListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT", codempresa, txtcodarticulo.Text.Trim, Me.cbTipoPrecio.SelectedValue.ToString.Trim).Tables(0)
            '    Me.cbPresentacion.DisplayMember = "DESPRES"
            '    Me.cbPresentacion.ValueMember = "CODPRES"
            '    Me.cbPresentacion.DataSource = TablaComboPresent
            '    Me.cbPresentacion.SelectedValue = VarCodPresentacion
            'End If

            'If FACT_CONFIGGRID = "01" Then
            '    Me.txtcodarticulo.Text = DS.Tables(0).Rows(0)(0)
            '    Me.txtdescripcion.Text = DS.Tables(0).Rows(0)(1)
            '    'Me.cbPresentacion.Items.Add(DS.Tables(0).Rows(0)(2))
            '    'Me.ListBox1.Items.Add(DS.Tables(0).Rows(0)(6))
            '    'Me.CTRLPRECIO.Text = FACT_GFormatodeNumero(DS.Tables(0).Rows(0)(3))
            '    'Me.cbPresentacion.Visible = False
            '    'Me.lblunidadventa.Visible = False
            '    'Me.cbounidadventa.Enabled = False
            '    'Me.ListBox1.Enabled = False
            'End If
            'If FACT_CONFIGGRID = "10" Then
            '    Me.txtcodarticulo.Text = DS.Tables(0).Rows(0)(0)
            '    Me.txtdescripcion.Text = DS.Tables(0).Rows(0)(1)
            '    'Me.cbPresentacion.Items.Add(DS.Tables(0).Rows(0)(2))
            '    'Me.ListBox1.Items.Add(DS.Tables(0).Rows(0)(6))

            'End If
            'If FACT_CONFIGGRID = "11" Then
            '    Me.txtcodarticulo.Text = DS.Tables(0).Rows(0)(0)
            '    Me.txtdescripcion.Text = DS.Tables(0).Rows(0)(1)
            '    ' Me.cbPresentacion.Items.Add(DS.Tables(0).Rows(0)(2))
            '    'Me.ListBox1.Items.Add(DS.Tables(0).Rows(0)(7))
            '    'Me.cbPresentacion.Items.Add(DS.Tables(0).Rows(0)(4))
            '    'Me.ListBox1.Items.Add(DS.Tables(0).Rows(0)(8))

            'End If
            'Me.cbPresentacion.SelectedIndex = 0
            'Me.ListBox1.SelectedIndex = 0
            VCodArti = ""
            Me.txttipo.Focus()
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            Me.txtcodarticulo.Text = ""
            Me.CTRLCANTIDAD.Text = ""
            Me.txtdescripcion.Text = ""
            Me.CTRLCANTIDAD.Focus()
        End Try
    End Sub
    Sub configuracionfacturacion()
        CTRLPRECIO.Enabled = FACT_EDITPRECIO
    End Sub

    Sub actuadetalle()
        FACT_Cargagriddetalledirecto(Grid1, "sp_sele_TMP_VENTADET2 " & VCorrelVta & ",'" & codempresa & "'")
        Call CALCULO(False)
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
                u = IIf(s = "2", "DOS", IIf(s = "3", "TRES", IIf(s = "4", "CUATRO", _
                    IIf(s = "5", "CINCO", IIf(s = "6", "SEIS", IIf(s = "7", "SIETE", _
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

    Sub BORRA_TEMPORALES()
        TmpInsertDatos("LIMPIA_TMP_VENTA " & VCorrelVta & "")
    End Sub
    Sub LIMPIA_DATOSDOC()
        Me.txtcodarticulo.Text = ""
        Me.txtdescripcion.Text = ""
        Me.CTRLCANTIDAD.Focus()
        Me.CTRLCANTIDAD.Text = FACT_GFormatodeNumero(0)
        Me.CTRLPRECIO.Text = FACT_GFormatodeNumero(0)
        Me.txttipo.Text = ""
    End Sub
    Private Sub LimpiarCjaTxtDet()
        txtcodarticulo.Text = ""
        txtdescripcion.Text = ""
        CTRLCANTIDAD.Text = "0"
        CTRLPRECIO.Text = "0.00"



        cbPresentacion.DataSource = Nothing
    End Sub
    Private Sub BuscarCliente(ByVal Var As Integer)
        Dim TAB_CLIE As New DataTable
        TAB_CLIE = TmpListarDatos("SP_SelectClienteFact   '" & codempresa & "','" & Me.txtcodclie.Text.Trim & "', '" & VRuc & "','" & 0 & "'")
        If TAB_CLIE.Rows.Count > 0 Then
            txtcodclie.Text = TAB_CLIE.Rows(0)("CODCLIENTE").ToString.Trim
            txtcliente.Text = TAB_CLIE.Rows(0)("DATOADJUNTO").ToString.Trim
            txtdireccion.Text = TAB_CLIE.Rows(0)("DIRECCION").ToString.Trim
            txtruc.Text = TAB_CLIE.Rows(0)("RUC").ToString.Trim
            VRuc = TAB_CLIE.Rows(0)("RUC").ToString.Trim
            VClieDep = TAB_CLIE.Rows(0)("CODDEP").ToString.Trim
            CboPagador.SelectedValue = TAB_CLIE.Rows(0)("CODDEP").ToString.Trim

            If VClieDep = "" Then
                CboPagador.Visible = False
                LblPagador.Visible = False
            Else
                CboPagador.Visible = True
                LblPagador.Visible = True
            End If
            GenerarNroDocCot()
            ConfigDocumento()
        Else

            If Var = 1 Then
                txtruc.Text = Me.txtcodclie.Text.Trim
                GenerarNroDocCot()
                ConfigDocumento()
                txtcliente.Focus()
            Else
                txtcliente.Text = String.Empty
                txtdireccion.Text = String.Empty
                txtruc.Text = String.Empty
                VRuc = String.Empty
                VClieDep = String.Empty
                CboPagador.Visible = False
                LblPagador.Visible = False
            End If
        End If

    End Sub
#End Region

#Region "RESTRICCIONES-KEYPRESS"

    Private Sub CajaTexto_SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtruc.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CTRLPRECIO_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles CTRLPRECIO.Invalidated

    End Sub
    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CTRLPRECIO.KeyPress
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
#End Region


    Private Sub FRMFACTURACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LimpiarVar()

            If TIPO_PTOVTA = 1 Then
                'btnefectivo.Visible = False
                btncheque.Visible = False
                btntarjeta.Visible = False
                btnvale.Visible = False
                btncredito.Visible = False
                Button3.Visible = False
                btndsctoitem.Visible = False
                btndsctototal.Visible = False
                'btnanular.Visible = False
                'btnreimprimir.Visible = False
            End If

            'Dim CLSINTER As New ClsInterface
            Dim TABLA As New DataTable
            TABLA = CAyuda.ListarDatos("SP_OBT_CONFIG ", codempresa).Tables(0)
            DigitosRuc = CAyuda.ValidaNullsInteger(TABLA.Rows(0)(0))
            MontoBoleta = CAyuda.ValidaNullsInteger(TABLA.Rows(0)(1))
            DigitosDNI = CAyuda.ValidaNullsInteger(TABLA.Rows(0)(2))
            Me.txtruc.MaxLength = DigitosRuc
            Call inicia_variables()
            Call cargadatos()
            Call OBTENERCORRELATIVO()
            '------------------------------------------------------------------
            GenerarNroDocCot()
            ConfigDocumento()
            CargarGridFact()
            FormatoGridDetVta()
            IniciarConfigFact()
            cbovendedor.SelectedValue = CodUsuario



            Button1.Enabled = True

            Button2.Enabled = True

        Catch ex As Exception
            Me.txtcodclie.Focus()
        End Try

        'Conecta("SELECT CAMBFECFACT FROM CONFIGVTA WHERE CODEMPRESA = '" & codempresa.Trim & "'", "DST6")
        'VarAux = ds.Tables("DST6").Rows(0)(0)
        'Me.dtpfechadoc.Enabled = VarAux

        ''Conecta("SELECT * FROM VENDEDOR WHERE CODVEND = '" & CodUsuario & "' AND CODEMPRESA = '" & codempresa & "'", "TabVend")
        ''If ds.Tables("TabVend").Rows.Count > 0 Then
        ''    'Me.lbCodVended.Text = ds.Tables("TabVend").Rows(0)("CODVEND")
        ''    'Me.lbVendedor.Text = ds.Tables("TabVend").Rows(0)("DSVEND")
        ''    Me.txtcodclie.Focus()
        ''Else
        ''    MsgBox("El usuario no está registrado como vendedor !, se cerrará la ventana.", MsgBoxStyle.Information)
        ''    End
        ''End If

        rbboleta.Checked = True



        If CHECKCLIPTOVTA = True Then

            txtcodclie.ReadOnly = False
            txtcodclie.Text = CLIENTEPTOVTA
            btnBusCli.Enabled = True

        Else

            txtcodclie.ReadOnly = True
            txtcodclie.Text = CLIENTEPTOVTA
            btnBusCli.Enabled = False

        End If


        Me.txtcodclie.Focus()



    End Sub
    Private Sub txtcodarticulo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodarticulo.KeyDown
        If e.KeyCode = Keys.F2 Then
            BtnBuscArt_Click(sender, e)
        End If
    End Sub
    Private Sub txtcodarticulo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodarticulo.KeyPress
        'Dim status As Boolean
        'status = VERIFICA_PTOVTA()
        'If status = False Then
        '    Exit Sub
        'End If

        If FACT_GUIA = False Then
            Dim Keyascii As Short = CShort(Asc(e.KeyChar))
            If Keyascii = 13 Then
                If txtcodarticulo.Text.Trim.Length <> 0 Then
                    Call MUESTRAARTICULO()

                End If
            End If
        End If
    End Sub
    Private Sub btndsctoitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndsctoitem.Click
        Dim status As Boolean
        status = validanumerodoc(Val(VNroDoc), txtruc.Text)
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

            'FACT_totalitem = Val(Grid1.Item(Grid1.CurrentRowIndex, 5)) * Val(Grid1.Item(Grid1.CurrentRowIndex, 4))
            'Dim frmx As New frmdescitem
            '**********************************************************************
            'FACT_monedabase = Trim(Me.cbomoneda.SelectedValue)
            '**********************************************************************
            'VCdTipoDoc = FACT_CDTIPODOC
            VItemDoc = Grid1.Item(Grid1.CurrentRowIndex, 0)
            VCodArti = Grid1.Item(Grid1.CurrentRowIndex, 1)
            VCantidad = Grid1.Item(Grid1.CurrentRowIndex, 4)
            VPrecioVta = Grid1.Item(Grid1.CurrentRowIndex, 5)
            VFecDocum = Grid1.Item(Grid1.CurrentRowIndex, 10)
            'FACT_xTIPOMEDIDA = Grid1.Item(Grid1.CurrentRowIndex, 9)
            'FACT_xCODEMPRESA = CodEmpresa
            'frmx.ShowDialog()
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
                sql = "sp_sele_TMP_VENTADET2 "
                ds = CAyuda.ListarDatos(sql, VCorrelVta, codempresa)
                CTRLDESC.CtlText = FACT_GFormatodeNumero(VDescTotbas).ToString
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
                Else
                    TOT = CDbl(TOT) - ((CDbl(CTRLDESC.CtlText) / 100) * TOT)
                    SUBT = TOT
                    IGV = 0
                End If

                Me.CTRLTOTAL.CtlText = TOT
                Me.CTRLSUBTOTAL.CtlText = SUBT
                Me.CTRLIGV.CtlText = IGV
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
                ds = CAyuda.ListarDatos(sql)
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
                        SUBT = CDbl(TOT) - CDbl(IGV)
                    Else
                        TOT = CDbl(TOT) - ((CDbl(CTRLDESC.CtlText) / 100) * TOT)
                        SUBT = TOT
                        IGV = 0
                    End If

                    Me.CTRLTOTAL.CtlText = TOT
                    Me.CTRLSUBTOTAL.CtlText = SUBT
                    Me.CTRLIGV.CtlText = IGV
                    VTotBas = CTRLTOTAL.CtlText
                End If
            End If

            Dim tmoneda As String = ""
            If Trim(FACT_CDMONEDA) = "S" Then tmoneda = "Nuevos Soles"
            If Trim(FACT_CDMONEDA) = "D" Then tmoneda = "Dolares "
            Me.lbltotalletras.Text = StrConv(FACT_TotalLetras(CTRLTOTAL.CtlText, tmoneda), 3)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btndsctototal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndsctototal.Click
        Dim status As Boolean

        status = validanumerodoc(Val(VNroDoc), txtruc.Text)
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
        sql = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
        ds = CAyuda.ListarDatos(sql)
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
        DS = CAyuda.ListarDatos(SQL)
        FACT_SIMBOLOMON = DS.Tables(0).Rows(0)(0)
        lblsimbolo.Text = FACT_SIMBOLOMON
        LBLSIMBOLO2.Text = FACT_SIMBOLOMON
        LBLSIMBOLO4.Text = FACT_SIMBOLOMON
        DS = Nothing
        SQL = "select simbolo from moneda where codmon=(select CDMONEXTR from configsis where COD_EMPRESA='" & codempresa & "')"
        DS = CAyuda.ListarDatos(SQL)
        FACT_SIMBOLOMONEXTR = DS.Tables(0).Rows(0)(0)
        LBLSIMBOLOCAMBIO.Text = FACT_SIMBOLOMONEXTR
        DS = Nothing
        SQL = "SP_CAMBIODELDIA '" & codempresa & "'"
        DS = CAyuda.ListarDatos(SQL)
        VCambioVta = DS.Tables(0).Rows(0)(0)
        lblcambio.Text = FACT_GFormatodeNumero(CDbl(VCambioVta))


    End Sub
    Function VERIFICAMONTOBOLETA() As Boolean
        If CTRLTOTAL.CtlText > MontoBoleta Then
            If Len(txtruc.Text) <> DigitosDNI Or txtcliente.Text = "" Or txtdireccion.Text = "" Then
                MsgBox("Complete el Numero de DNI, Nombre y direccion", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                txtruc.Focus()
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function
    Private Sub btnefectivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnefectivo.Click

        If rbboleta.Checked = True Then
            If TxtTOTAL.Text > PREC_BOLETA Then
                MsgBox("PRECIO BOLETA SOBRESALE")
                Exit Sub
            End If
        End If

        If rbfactura.Checked = True Then
            If TxtTOTAL.Text > PREC_FACTURA Then
                MsgBox("PRECIO FACTURA SOBRESALE")
                Exit Sub
            End If
        End If

        If rbnotap.Checked = True Then
            If TxtTOTAL.Text > PREC_NOTAPEDIDO Then
                MsgBox("PRECIO NOTA PEDIDO SOBRESALE")
                Exit Sub
            End If
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
            If TxtTOTAL.Text > CDbl(TABLE_VALIDARM.Rows(0)(0).ToString) Then
                MsgBox("El total es mayor al monto por documento")
                Exit Sub

            End If
        End If

        If txtcodclie.Text.Trim.Length = 0 Then
            MsgBox("NO INGRESO EL CODIGO DEL CLIENTE")
        Else
            VClieDep = txtcodclie.Text.Trim
        End If











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
            If CDbl(TxtTOTAL.Text) <= 0 Then
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


            SQL = "sp_sele_TMP_VENTADETFD " & VCorrelVta & ",'" & codempresa & "'"
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



            ' obtengo el numero de documentos a generar
            VCodCliente = txtcodclie.Text
            VDescliente = txtcliente.Text
            VDireccion = txtdireccion.Text
            VDescTotbas = TxtDESC.Text
            VTotBas = TxtTOTAL.Text
            VTotExt = CDbl(TxtTOTAL.Text) / CDbl(lblcambio.Text)
            VRuc = Trim(txtruc.Text)
            If VCdTipoDoc = CDFACTURA Then
                status = FACT_GValidaRUC(Trim(txtruc.Text))
                If status = False Then
                    Exit Sub
                End If
            End If





            If ACTIVACAJA = True Then
                Dim fechadocum As Date
                fechadocum = Format(CAyuda.ListarDatos("SP_DATE_HOUR").Tables(0).Rows(0)(0), "dd/MM/yyyy")
                If GRABAEFECTIVOS(VCdPagEfectivo, fechadocum) = True Then
                    'CAyuda.Ejecutar("NSP_ACTUALIZAR_STOCK_FACT", codempresa.Trim, CInt(CTRLCANTIDAD.Text.Trim))
                End If




                Call IMPRIMEDOCUMENTO(VNroDoc)

                Dim SQL2 As String
                Dim PROCESO As Boolean

                If rbfactura.Checked = True Then
                    SQL2 = "INSERT_TB_CLIENTEF '" & txtruc.Text & "','" & txtcliente.Text & "','" & txtdireccion.Text & "'"
                    PROCESO = TmpInsertDatos(SQL2)
                End If




                CANCELAR()




                'Reimprimiendo el Archivo
                ' Dim Numero As Long
                'Numero = Strings.Right(Val(Me.TXTSERIEDOC.Text.Trim + Me.TXTNUMERODOC.Text.Trim), 8)


            Else
                'Dim frmx As New frmpagoefectivo
                'frmx.estado = True
                'frmx.VIE = Me
                'frmx.ShowDialog()
            End If

            MsgBox("- Se Guardo con exito.", MsgBoxStyle.Information, "NARSISTEMAS")

            btnefectivo.Enabled = True

        Catch ex As Exception
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
            Dim cmd2 As New SqlCommand("Nsp_grabadocumento_COTIZACION", cn2)
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
            cmd2.Parameters.AddWithValue("@TOTBAS", CDec(TxtTOTAL.Text)).SqlDbType = SqlDbType.Decimal
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
                MsgBox(ex.Message)
                MsgBox(ex.ToString)

            End Try



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



        'IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
        TmpInsertDatos("SP_REGISTRA_AUDITORIA '','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy") & "','" & CodUsuario & "','" & codempresa & "'")

    End Function
    Private Function verificamonto(ByVal monto As Double) As Boolean
        tmonto = Double.Parse(CAyuda.ListarDatos("sp_obt_montoboleta").Tables(0).Rows(0)(0))
        If monto > tmonto Then
            If dni <> "" Then
                Label5.Text = "DNI"
                txtruc.Text = dni
                oknopide = True
                Return True
            Else
                Label5.Text = "DNI"
                MsgBox("Ingrese DNI", MsgBoxStyle.Information)
                txtruc.Focus()
                oknopide = True
                Return False
            End If
        Else
            oknopide = False
            Return True
        End If

    End Function
    Private Sub btntarjeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntarjeta.Click
        Dim status As Boolean

        status = validanumerodoc(Val(VNroDoc), txtruc.Text)
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
        'status = verificanotapesada(txtnotapesada.Text)
        'If status = False Then
        '    Exit Sub
        'End If
        'FACT_PRINCIALTER = lblprincipal.Text
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Dim status As Boolean
        'If Trim(txtruc.Text) <> "" Then

        'End If
        VCodCliente = txtcodclie.Text
        VRuc = Trim(txtruc.Text)
        VDescliente = txtcliente.Text
        VDireccion = txtdireccion.Text
        VDescTotbas = CTRLDESC.CtlText
        VTotBas = CTRLTOTAL.CtlText
        VTotExt = CDbl(CTRLTOTAL.CtlText) / CDbl(lblcambio.Text)

        Dim permiso As Boolean
        If lbltipodoc.Text = "BOLETA" Then
            permiso = VERIFICAMONTOBOLETA()
        Else
            status = FACT_GValidaRUC(Trim(txtruc.Text))
            If status = False Then
                Exit Sub
            End If
            permiso = True
        End If
        If permiso = True Then
            'Dim frmx As New frmpagotarjeta
            'frmx.VIE = Me
            'frmx.estado = True
            'frmx.ShowDialog()
            cbovendedor.Enabled = True
        End If
    End Sub
    Private Sub btncheque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheque.Click
        Dim status As Boolean
        status = validanumerodoc(Val(VNroDoc), txtruc.Text)
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



        'FACT_PRINCIALTER = lblprincipal.Text
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        VCodCliente = txtcodclie.Text
        VRuc = Trim(txtruc.Text)
        VDescliente = txtcliente.Text
        VDireccion = txtdireccion.Text
        VDescTotbas = CTRLDESC.CtlText
        VTotBas = CTRLTOTAL.CtlText
        VTotExt = CDbl(CTRLTOTAL.CtlText) / CDbl(lblcambio.Text)
        'If lblprincipal.Text = "" Then
        '    lblprincipal.Text = txtcodclie.Text
        '    VClieDep = lblprincipal.Text
        'End If

        Dim permiso As Boolean
        If lbltipodoc.Text = "BOLETA" Then
            permiso = VERIFICAMONTOBOLETA()
        Else
            status = FACT_GValidaRUC(Trim(txtruc.Text))
            If status = False Then
                Exit Sub
            End If
            permiso = True
        End If
        If permiso = True Then
            'Dim frmx As New FRMPAGOCHEQUE
            'frmx.VIE = Me
            'frmx.estado = True
            'frmx.ShowDialog()
            cbovendedor.Enabled = True
        End If
    End Sub
    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Try
            If FACT_mensaje_cancelar() = True Then
                Call CANCELAR()

                Me.btnefectivo.Enabled = True
            End If
        Catch ex As Exception
        End Try
        Consul_var = False
        GroupBox1.Visible = True
        gbtipodoc.Enabled = True
    End Sub
    Public Sub CANCELAR()
        Try
            Dim SQL As String
            SQL = "DELETE FROM TMP_VENTADETFD WHERE CDUSUARIO = '" & CodUsuario & "' AND CORRNBR = " & VCorrelVta & " and CODEMPRESA= '" & codempresa & "'"
            TmpInsertDatos(SQL)


            If CHECKCLIPTOVTA = True Then
                Me.txtcodclie.Text = ""

            Else


            End If



            Me.txtruc.Text = ""
            Me.txtcliente.Text = ""
            Me.txtdireccion.Text = ""
            Me.dtpfechadoc.Value = Format(vFechaActual, "dd/MM/yyyy")
            VCodCliente = ""
            VClieDep = ""
            ConfigDocumento()
            cbovendedor.SelectedText = CodUsuario
            VCodVended = cbovendedor.SelectedValue.ToString
            'Call cargadatos()
            CargarGridFact()
            Call editnum(False)
            lbltotalletras.Text = ""
            'txtnotapesada.Text = ""
            'txtnroguias.Text = ""
            SW = True
            Jostin = False
            txtcodclie.Focus()
            ESTADOS(True)
            'Me.cbovendedor.Enabled = True
            Me.GroupBox1.Enabled = True
            Me.BtnBuscar.Visible = False
            'Me.txtnotapesada.Enabled = True

            Me.btntarjeta.Enabled = True
            Me.btncheque.Enabled = True
            Me.btncredito.Enabled = True
            Me.btnvale.Enabled = True
            Me.Button3.Enabled = True
            Me.btndsctoitem.Enabled = True
            Me.btndsctototal.Enabled = True
            Me.btngeneranuevo.Enabled = True
            Me.btnanular.Enabled = True
            Me.btnreimprimir.Enabled = True
            Me.lbltipodoc.Text = "BOLETA"
            Tabla = ""
            TablaDet = ""
            VRuc = ""
            LimpiarCjaTxtDet()
            LimpiarVar()
            OBTENERCORRELATIVO()
            GenerarNroDocCot()
            ConfigDocumento()
            CargarGridFact()
            FormatoGridDetVta()
            'rbboleta.Checked = True

        Catch ex As Exception

        End Try

    End Sub
    Private Sub cbovendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbovendedor.SelectedIndexChanged
        VCodVended = Trim(cbovendedor.SelectedValue.ToString())
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
    '    MIDS = CAyuda.ListarDatos("CONFIGGRID '" & NroPtovta & "','" & CodEmpresa & "'")
    '    FACT_CONFIGGRID = MIDS.Tables(0).Rows(0)(0)
    'End Sub
    Sub elimina_item(Optional ByVal var As Boolean = False)
        Try
            Dim sql As String
            sql = "SP_DELETE_ITEM_TMPVENTADETFD " & VCorrelVta & "," & Grid1.Item(Grid1.CurrentRowIndex, 0) & ",'" & codempresa & "','" & NROPTOVTA & "'"
            TmpInsertDatos(sql)
            CargarGridFact()
            FormatoGridDetVta()
            If var = False Then
                LimpiarCjaTxtDet()
                txtcodarticulo.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btncredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncredito.Click
        Dim status As Boolean
        'If Me.CboPagador.Items.Count > 0 Then
        '    Me.lblprincipal.Text = Me.CboPagador.SelectedValue
        'End If

        status = validanumerodoc(Val(VNroDoc), txtruc.Text)
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

        'FACT_PRINCIALTER = lblprincipal.Text
        Dim VALIDA As Boolean
        VALIDA = VALIDACLIE()
        If VALIDA = False Then
            Exit Sub
        End If

        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim ds As New DataSet
        Dim sql As String = ""
        'sql = "verifica_saldo_creditoclie '" & lblprincipal.Text & "'," & CTRLTOTAL.CtlText & ""
        ds = CAyuda.ListarDatos(sql)
        If ds.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Cliente no Cuenta con Credito para el Monto del documento", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        VCodCliente = txtcodclie.Text

        VDescliente = txtcliente.Text
        VDireccion = txtdireccion.Text
        VDescTotbas = CTRLDESC.CtlText
        VTotBas = CTRLTOTAL.CtlText
        VTotExt = CDbl(CTRLTOTAL.CtlText) / CDbl(lblcambio.Text)
        VRuc = Trim(txtruc.Text)

        Dim permiso As Boolean
        If lbltipodoc.Text = "BOLETA" Then
            permiso = VERIFICAMONTOBOLETA()
        Else
            status = FACT_GValidaRUC(Trim(txtruc.Text))
            If status = False Then
                Exit Sub
            End If
            permiso = True
        End If
        If permiso = True Then
            'Dim frmx As New frmpagocredito
            'frmx.VIE = Me
            'frmx.estado = True
            'frmx.ShowDialog()
            cbovendedor.Enabled = True
        End If
    End Sub
    Private Sub btnvale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvale.Click
        Dim status As Boolean
        status = validanumerodoc(Val(VNroDoc), txtruc.Text)
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

        'FACT_PRINCIALTER = lblprincipal.Text
        If CDbl(CTRLTOTAL.CtlText) <= 0 Then
            MessageBox.Show("El monto del Documento es Cero verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim permiso As Boolean
        If lbltipodoc.Text = "BOLETA" Then
            permiso = VERIFICAMONTOBOLETA()
        Else
            status = FACT_GValidaRUC(Trim(txtruc.Text))
            If status = False Then
                Exit Sub
            End If
            permiso = True
        End If
        If permiso = True Then
            'Dim frmx As New frmpagovale
            'frmx.VIE = Me
            'frmx.estado = True
            'frmx.ShowDialog()
            cbovendedor.Enabled = True
        End If
    End Sub
    Private Sub txtcodclie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodclie.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    BuscarCliente(0)

        'End If
    End Sub
    Private Sub verfinumdoc()
        Dim sql, tipdoc As String

        If lbltipodoc.Text = "BOLETA" Then tipdoc = "03" Else tipdoc = "01"
        sql = "select nrodocu from ventacab where nrodocu=" & VNroDoc & " and codtipodoc='" & tipdoc & "'"
        ds = CAyuda.ListarDatos(sql)
        If ds.Tables(0).Rows.Count > 0 Then
            MsgBox("El numero del documento ya existe ingrese otro", MsgBoxStyle.Information)
            TXTNUMERODOC.Focus()
        End If
    End Sub
    Private Sub BuscaTxtRuc_ENTER()
        Dim sql As String
        Call TIPODOC()
        Call verfinumdoc()
        '''''Call VENTANATIPOCLIENTE()
        'lblprincipal.Text = VClieDep
        sql = "NSP_SELE_clienteFac '" & codempresa & "','" & VClieDep & "',0,'" & NROPTOVTA.Trim & "'"
        ds = CAyuda.ListarDatos(sql)
        If ds.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("El cliente Pagador no tiene Vendedor Asociado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Me.txtruc.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        If flagfac Then
            Conecta("SELECT CODCLIENTE, RAZONSOCIAL, DIRECCION FROM CLIENTE WHERE ESTADO = 0 AND RUC ='" & txtruc.Text.Trim & "'".Trim, "TabCli")
        Else
            Conecta("SELECT CODCLIENTE, PATERNO, MATERNO, NOMBRES, RAZONSOCIAL, DIRECCION FROM CLIENTE WHERE ESTADO = 0 AND DNI = '" & txtruc.Text.Trim & "'", "Tabcli")
        End If
        If ds.Tables("TabCli").Rows.Count > 0 Then
            If flagfac Then
                Try
                    Me.txtcodclie.Text = ds.Tables("TabCli").Rows(0)(0)
                    Me.txtcliente.Text = ds.Tables("TabCli").Rows(0)(1)
                    Me.txtdireccion.Text = ds.Tables("TabCli").Rows(0)(2)
                Catch ex As Exception
                End Try
            Else
                Try
                    Me.txtcodclie.Text = ds.Tables("TabCli").Rows(0)(0)
                    Me.txtcliente.Text = ds.Tables("TabCli").Rows(0)(1).ToString.Trim + " " + ds.Tables("TabCli").Rows(0)(2).ToString.Trim + " " + ds.Tables("TabCli").Rows(0)(3).ToString.Trim
                    Me.txtdireccion.Text = ds.Tables("TabCli").Rows(0)(5)
                Catch ex As Exception

                End Try
            End If
        Else
            '' TRAER NUEVO CLIENTE
            Me.txtcodclie.Text = String.Empty
            Me.txtcliente.Text = String.Empty
            Me.txtdireccion.Text = String.Empty
            Me.txtcodclie.Text = Me.txtruc.Text
            Me.txtcliente.Focus()
        End If
        Me.txtcliente.Focus()
    End Sub
    Private Sub VENTANATIPOCLIENTE()
        'Dim frmx As New frmtipoclieFACT
        'frmx.VIE2 = Me
        'frmx.cond = 1
        ''''frmx.cond = 0
        'frmx.ShowDialog()
        'txtcliente.Focus()

    End Sub
    Sub TIPODOC()

        If Len(txtruc.Text.Trim) = DigitosRuc Then
            flagfac = True

            'Me.cbTipoDoc.SelectedIndex = 0

        ElseIf Len(txtruc.Text.Trim) = DigitosDNI Or Len(txtruc.Text.Trim) = 0 Then
            'Me.cbTipoDoc.SelectedIndex = 1
            flagfac = False
        Else
            MsgBox("Ingrese correctamente los datos", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
            txtruc.SelectAll()
            txtruc.Focus()
            Exit Sub
        End If

        Call tipodocumento()
        If fact_editnumero = False Then
            txtruc.Focus()
        End If
        ' txtcliente.Focus()
    End Sub
    Private Sub txtcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdireccion.Focus()
        End If
        'MsgBox(Asc(e.KeyChar))

    End Sub
    Private Sub txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbovendedor.Enabled = True Then
                cbovendedor.Focus()
            Else
                txtcodarticulo.Focus()

            End If
        End If
    End Sub
    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        'frmx.VIE = Me
        'frmx.estado = True
        'frmx.ShowDialog()
    End Sub
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Function VALIDACLIE() As Boolean
        Try
            If Trim(txtcodclie.Text) = "" Or Trim(txtcliente.Text) = "" Then
                MessageBox.Show("Complete los datos del cliente para realizar el proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                VALIDACLIE = False
            Else
                VALIDACLIE = True
            End If
        Catch ex As Exception
        End Try
    End Function
    Private Sub btnrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        Call OBTENERCORRELATIVO()
        'Dim frmx As New FRMRESTORESTRANS
        'frmx.VIE = Me
        'frmx.estado = True
        'frmx.ShowDialog()
    End Sub
    Private Sub mnufacdirec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnufacdirec.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
        'BTNGUIAS.Visible = False
        flagfac = False
        mnufacdirec.Checked = True
        mnufactguia.Checked = False
        Me.Text = "Facturacion Directa"
        FACT_GUIA = False
        txtruc.Text = ""
        txtcodclie.Text = ""
        txtcliente.Text = ""
        txtdireccion.Text = ""
        txtcodarticulo.Text = ""

        Call tipodocumento()
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

        'BTNGUIAS.Visible = True
        flagfac = True
        mnufacdirec.Checked = False
        mnufactguia.Checked = True
        Me.Text = "Facturacion GUIA Directa"
        FACT_GUIA = True
        txtruc.Text = ""
        txtcodclie.Text = ""
        txtcliente.Text = ""
        txtdireccion.Text = ""
        txtcodarticulo.Text = ""

        Call OBTENERCORRELATIVO()
        Call cargadatos()
        Call actuadetalle()
        Call tipodocumento()
        Dim DS As New DataSet
        'Dim SQL As String
        'SQL = "SP_NUMERODOC '" & NROPTOVTA & "','12345678912'"
        DS = CAyuda.ListarDatos("SP_NUMERODOC", NROPTOVTA, "12345678912", codempresa)
        VNroDoc = DS.Tables(0).Rows(0)(1)
        TXTSERIEDOC.Text = DS.Tables(0).Rows(0)(2) 'solo seria format
        TXTNUMERODOC.Text = DS.Tables(0).Rows(0)(3) 'solo numero format
    End Sub
    Private Sub FRMFACTURACION_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        mnufacdirec.Checked = True
    End Sub
    Private Sub ESTADOS(ByVal VALOR As Boolean)
        txtcodclie.Enabled = VALOR
        txtcliente.Enabled = VALOR
        txtruc.Enabled = VALOR
        txtdireccion.Enabled = VALOR
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
        TmpInsertDatos("DELETE FROM TMP_VENTADET WHERE CDUSUARIO = '" & CodUsuario & "' AND CORRNBR = " & VCorrelVta & "")
        'tmp_borra_saldos()
        'ClsInter = Nothing
        SW = False
        Jostin = False
        'Hijo = False
        'ClsDa = Nothing
    End Sub
    Public Sub IMPRIMEDOCUMENTO(ByVal VCorrelVta As Long)
        'Try

        'Catch ex As Exception

        'End Try

        '  If VCdTipoDoc = CDFACTURA Then

        With crRpt
            .set_StoredProcParam(0, codempresa)
            .set_StoredProcParam(1, VCdTipoDoc)
            .set_StoredProcParam(2, CStr(VNroDoc))
            .set_StoredProcParam(3, Format(CDate(Me.dtpfechadoc.Value), "dd/MM/yyyy"))
            .set_Formulas(1, "formTotLetras='" & meTotalLetras(CDbl(TxtTOTAL.Text) - CDbl(txtpercp.Text), "Nuevos Soles") & "'")
            .set_Formulas(2, "formnundoc='" & CStr(VNroDoc) & "'")
            .ReportFileName = rutareporte + CType("Rpt_Factura_Cotizacion.rpt", String)
            .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            .Destination = Crystal.DestinationConstants.crptToWindow
            .Action = 1
            .Reset()
            Exit Sub
        End With

        'End If
        '    If VCdTipoDoc = CDBOLETA Then
        '        With crRpt
        '            .set_StoredProcParam(0, codempresa)
        '            .set_StoredProcParam(1, VCdTipoDoc)
        '            .set_StoredProcParam(2, CStr(VNroDoc))
        '            .set_StoredProcParam(3, Format(CDate(Me.dtpfechadoc.Value), "dd/MM/yyyy"))
        '            .set_Formulas(1, "formTotLetras='" & meTotalLetras(CDbl(TxtTOTAL.Text) - CDbl(txtpercp.Text), "Nuevos Soles") & "'")
        '            .set_Formulas(2, "formnundoc='" & CStr(VNroDoc) & "'")
        '            .ReportFileName = rutareporte + CType("Rpt_Boleta.rpt", String)
        '            .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
        '            .Destination = Crystal.DestinationConstants.crptToWindow
        '            .Action = 1
        '            .Reset()
        '            Exit Sub
        '        End With
        '    End If
        '    If VCdTipoDoc = CDNTAPEDIDO Then
        '        With crRpt
        '            .set_StoredProcParam(0, codempresa)
        '            .set_StoredProcParam(1, VCdTipoDoc)
        '            .set_StoredProcParam(2, CStr(VNroDoc))
        '            .set_StoredProcParam(3, Format(CDate(Me.dtpfechadoc.Value), "dd/MM/yyyy"))
        '            .set_Formulas(1, "formTotLetras='" & meTotalLetras(CDbl(TxtTOTAL.Text) - CDbl(txtpercp.Text), "Nuevos Soles") & "'")
        '            .set_Formulas(2, "formnundoc='" & CStr(VNroDoc) & "'")

        '            .ReportFileName = rutareporte + CType("Rpt_NotaPedido.rpt", String)
        '            .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
        '            .Destination = Crystal.DestinationConstants.crptToWindow
        '            .Action = 1
        '            .Reset()
        '            Exit Sub
        '        End With
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
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
        'frmx.dia_fin = ""
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
        With crRpt()
            .ReportFileName = rutareporte + CType("CIERREX.rpt", String)
            .ReportTitle = "Cierre X"
            .Action = 1
            .Reset()
        End With

    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        'MsgBox(status.ToString)
        If status = False Then
            Exit Sub
        End If
        'Dim frmx As New frmcierreptovta
        'frmx.ShowDialog()
    End Sub
    Private Sub btnanular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanular.Click
        Dim SQL As String
        Dim TblTabla As New DataTable
        Dim TblVtaxCobrar As New DataTable

        If Len(CStr(VNroDoc)) = 0 Then
            MsgBox("No Existe el Nro de Documento Para Anular en el Sistema" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Exit Sub
        End If

        If MsgBox("Desea Anular el Documento Actual" + Chr(13) + "Confirme", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            'Ahora Buscamos el Nro de Documento en la Tabla Ventas x Cobrar
            TblVtaxCobrar = CAyuda.ListarDatos("USP_BUSCAR_NRODOC_VENTA_X_COBRAR", VCdTipoDoc, VNroDoc, codempresa).Tables(0)

            'Si Existe en el Nro de Documento en La Tabla VentaxCobrar
            If TblVtaxCobrar.Rows.Count = 1 Then
                With TblVtaxCobrar
                    'Preguntas si es al Credito
                    If .Rows(0).Item("PAGCREDBAS") = 0 And .Rows(0).Item("PAGCREDEXT") = 0 Then
                        Conecta("SELECT NROGUIA FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND NRODOCU = " & VNroDoc & "", "x")
                        Dim VarNroGuia As String = Trim(ds.Tables("x").Rows(0).Item("NROGUIA").ToString())
                        SQL = "USP_ANULAR_DOCUMENTO '" & Tabla.Trim & "','" & TablaDet.Trim & "','" & VNroDoc & "','" & NROPTOVTA & "','" & codempresa & "','" & VCdTipoDoc & "'," & CAyuda.ValidaNullsInteger(VarNroGuia) & ""
                        If TmpInsertDatos(SQL) = True Then
                            MsgBox("El Documento Actual Fue Anulado Correctamente" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                            Call CANCELAR()
                        Else
                            MsgBox("Error Al Anular El Documento Actual Consulte Por Favor" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                            Exit Sub
                        End If
                    Else
                        MsgBox("El Nro de Documento Registra Pagos Consulte" + Chr(13) + "A su Proveedor", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
                    End If
                End With
            Else
                Conecta("SELECT NROGUIA FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND NRODOCU = " & VNroDoc & "", "x")
                Dim VarNroGuia As String = Trim(ds.Tables("x").Rows(0).Item("NROGUIA").ToString())
                SQL = "USP_ANULAR_DOCUMENTO '" & Tabla.Trim & "','" & TablaDet.Trim & "','" & VNroDoc & "','" & NROPTOVTA & "','" & codempresa & "','" & VCdTipoDoc & "','" & Val(VarNroGuia.Trim) & "'"
                If TmpInsertDatos(SQL) = True Then
                    MsgBox("El Documento Actual Fue Anulado Correctamente" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                    Call CANCELAR()
                Else
                    MsgBox("Error Al Anular El Documento Actual Consulte Por Favor" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub btnreimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreimprimir.Click
        If TXTNUMERODOC.Enabled = False Or TXTNUMERODOC.Text.Trim.Length = 0 Then
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
        Dim status As Boolean
        status = VERIFICA_PTOVTA()
        If status = False Then
            Exit Sub
        End If
    End Sub


    Sub BOTONES_PRESIONADOS(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        '*********************F2*********************AYUDA ARTICULO
        If e.KeyCode = Keys.F2 Then
            'Button2_Click(sender, e)
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
            btnBusCli_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
            BuscarCliente(1)
            If txtcliente.Text.Trim.Length = 0 Then
                txtcliente.Focus()
            Else
                txtcodarticulo.Focus()
            End If
        End If

    End Sub

    Private Sub txtcliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcliente.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub txtdireccion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdireccion.KeyDown
        BOTONES_PRESIONADOS(sender, e)
    End Sub
    Private Sub txtnotapesada_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
        ds = CAyuda.ListarDatos(SQL)
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
            TXTSERIEDOC.Enabled = estado
            TXTNUMERODOC.Enabled = estado
            FACT_EDITPRECIO = estado
            TXTNUMERODOC.Focus()
            FLAGNUMGUIA = True
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
                DS = CAyuda.ListarDatos(SQL)
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
            'txtnumero.Text = n
        End If
    End Sub


    'Public Function verificaprecio(ByVal precio As Double) As Boolean
    '    'primero verifico con q precio lo voy a comparar si es con medida o con unidad
    '    Dim ds As New DataSet
    '    Dim sql As String
    '    Dim min, max As Double

    '    If ListBox1.SelectedIndex = 0 Then  'unidad mayor
    '        sql = "SELECT MINPREMED,MAXPRECIOMED FROM preciart where CODTIPOPRE='" & FACT_CDTIPOPRE1 & "' and  CODARTI='" & Trim(txtcodarticulo.Text) & "'"
    '        ds = CAyuda.ListarDatos(sql)
    '        min = ds.Tables(0).Rows(0)(0)
    '        max = ds.Tables(0).Rows(0)(1)
    '        If min = 0 And max = 0 Then
    '            ' si ambos estan en cero lo dejo pasar
    '            verificaprecio = True
    '            Exit Function
    '        Else
    '            ' verifo el rango
    '            If precio >= min And precio <= max Then
    '                'correcto pasa
    '                verificaprecio = True
    '                Exit Function
    '            Else
    '                MessageBox.Show("El Precio de Venta Ingresado no se encuentra establecido entre el rango de precio codificado verifique!!!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                verificaprecio = False
    '                Exit Function
    '            End If
    '        End If
    '    End If
    '    ds.Dispose()
    '    If ListBox1.SelectedIndex = 1 Then 'unidad menor
    '        sql = "SELECT MINPREUNI,MAXPREUNI FROM preciart where CODTIPOPRE='" & FACT_CDTIPOPRE1 & "' and  CODARTI='" & Trim(txtcodarticulo.Text) & "'"
    '        ds = CAyuda.ListarDatos(sql)
    '        min = ds.Tables(0).Rows(0)(0)
    '        max = ds.Tables(0).Rows(0)(1)
    '        If min = 0 And max = 0 Then
    '            ' si ambos estan en cero lo dejo pasar
    '            verificaprecio = True
    '            Exit Function
    '        Else
    '            ' verifo el rango
    '            If precio >= min And precio <= max Then
    '                'correcto pasa
    '                verificaprecio = True
    '                Exit Function
    '            Else
    '                MessageBox.Show("El Precio de Venta Ingresado no se encuentra establecido entre el rango de precio codificado verifique!!!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                verificaprecio = False
    '                Exit Function
    '            End If
    '        End If
    '    End If
    'End Function



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
            CTRLIGV.CtlText = FACT_GFormatodeNumero(CTRLIGV.CtlText)
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
        If txttipo.Text = "" Then
            txttipo.Text = 0
        End If
    End Sub
    Private Sub txttipo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttipo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txttipo.Text = "" Then
                txttipo.Text = "0.0"
            End If
            CTRLPRECIO.Focus()
        End If
    End Sub
    Private Sub txtnotapesada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtcodarticulo.Focus()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label15.Text = Format(Fecha_Actual, "hh:mm:ss tt")
    End Sub
    Private Sub TXTNUMERODOC_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTNUMERODOC.LostFocus
        'txtnumero.Text = TXTSERIEDOC.Text + TXTNUMERODOC.Text
    End Sub
    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        Me.BtnBuscar.Visible = True
        Me.TXTNUMERODOC.Text = String.Empty
        Me.TXTNUMERODOC.Enabled = True
        Me.TXTNUMERODOC.Focus()
    End Sub
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        'Dim ConsDocumento As New FrmConsultarFacturac2
        'ConsDocumento.Factura = Me
        'ConsDocumento.ShowDialog()
        ''Verificando el Estado de la Factura
        BuscarDocumento()

        If Me.LblEstado.Text = "A" Then
            MsgBox("El Documento Que Consulto Fue Anulado" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Me.LblEstado.Text = ""
        End If
    End Sub
    Private Sub txtcodclie_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodclie.LostFocus
        'Call cinfigcliente()
        VClieDep = txtcodclie.Text.Trim
    End Sub
    Private Sub txtruc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtruc.GotFocus
        ''''Call cinfigcliente()
    End Sub

    Private Sub cbTipoPrecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoPrecio.SelectedIndexChanged
        If Me.txtcodclie.Text.Trim.Length > 0 Then
            If Me.txtcodarticulo.Text.Trim.Length > 0 And txtdescripcion.Text.Trim.Length > 0 Then
                Dim TablaComboPresent As New DataTable
                CDTIPOPRE1 = Me.cbTipoPrecio.SelectedValue.ToString.Trim
                TablaComboPresent = CAyuda.ListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT", codempresa, txtcodarticulo.Text.Trim, Me.cbTipoPrecio.SelectedValue.ToString.Trim).Tables(0)
                Me.cbPresentacion.DisplayMember = "DESPRES"
                Me.cbPresentacion.ValueMember = "CODPRES"
                Me.cbPresentacion.DataSource = TablaComboPresent
            End If
        End If
    End Sub

    Private Sub BtnBuscArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscArt.Click
        Dim FrmArt As New FrmListarArticuloFact
        FrmArt.ShowDialog()
        If FrmArt.DEVOLVER = False Then
            Exit Sub
        End If
        txtcodarticulo.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 0)
        txtdescripcion.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 1)
        'vcdAlmacen = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 2)
        Carga_Presentacion()
        ActEventCombo = True
        cbPresentacion_SelectedIndexChanged(sender, e)
        cbPresentacion.Focus()

    End Sub

    Private Sub Carga_Presentacion()
        TMP_PRESENTACION = TmpListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT  '" & codempresa & "','" & txtcodarticulo.Text.Trim & "','" & CDTIPOPRE1 & "', " & IIf(PPPUNTOVENTA = True, 1, 0) & ", " & IIf(PPFUERZVENTA = True, 1, 0) & "")

        cbPresentacion.DataSource = TMP_PRESENTACION
        cbPresentacion.ValueMember = "CODPRES"
        cbPresentacion.DisplayMember = "DESPRES"
    End Sub

    Private Sub btnBusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusCli.Click
        Dim FrmCli As New FrmBuscarClieDepen
        FrmCli.ShowDialog()
        If FrmCli.DEVOLVER = False Then
            Exit Sub
        End If
        txtcodclie.Text = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 0)
        BuscarCliente(0)
        Me.txtcodarticulo.Focus()
    End Sub



    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If VUsarNotaPedido = True Then
            VUsarNotaPedido = False
        Else
            VUsarNotaPedido = True
        End If
        GenerarNroDocCot()
        ConfigDocumento()
    End Sub
    Private Sub cbPresentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPresentacion.SelectedIndexChanged
        If TMP_PRESENTACION.Rows.Count > 0 And ActEventCombo = True And txtcodarticulo.Text.Trim.Length <> 0 Then
            Dim TBPREC As New DataTable
            TBPREC = TmpListarDatos("SP_BUSC_PRECIOARTFACT   '" & codempresa & "','" & cbPresentacion.SelectedValue & "','" & CDTIPOPRE1 & "','" & txtcodarticulo.Text & "','" & txtcodclie.Text & "'")
            VPrecio = TBPREC.Rows(0)("PRECIO")
            VPrecioVta = TBPREC.Rows(0)("PRECIOVTA")
            CTRLPRECIO.Text = FormatoMonto(VPrecioVta, DECIRESU)
            CTRLCANTIDAD.Focus()
        End If
    End Sub

    Private Sub cbPresentacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbPresentacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CTRLCANTIDAD.Focus()
        End If
    End Sub

    Private Sub CTRLCANTIDAD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CTRLCANTIDAD.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CTRLPRECIO.Enabled = True Then
                CTRLPRECIO.Focus()
            Else
                INSERT_TMP_DETALLE()
            End If
        End If
    End Sub
    Private Sub CTRLPRECIO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CTRLPRECIO.KeyDown
        If e.KeyCode = Keys.Enter Then
            INSERT_TMP_DETALLE()
        End If
    End Sub
    Private Sub txtcodarticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodarticulo.Click
        LimpiarCjaTxtDet()
    End Sub

    Private Sub txtruc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtruc.KeyDown

        If e.KeyCode = Keys.F1 Then
            If VUsarNotaPedido = True Then
                VUsarNotaPedido = False
            Else
                VUsarNotaPedido = True
            End If
            GenerarNroDocCot()
            ConfigDocumento()
        End If


        If e.KeyCode = Keys.Enter Then
            If rbfactura.Checked = True Then
                Dim TBPREC As New DataTable
                TBPREC = TmpListarDatos("SP_BUSQUEDA_TB_CLIENTEF   '" & txtruc.Text & "'")
                If TBPREC.Rows.Count > 0 Then
                    txtcliente.Text = TBPREC.Rows(0)("RAZON_SOCIAL")
                    txtdireccion.Text = TBPREC.Rows(0)("DIRECCION")
                Else
                    txtcliente.Text = ""
                    txtdireccion.Text = ""
                End If

            End If

        End If


    End Sub

    Private Sub TXTSERIEDOC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTSERIEDOC.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If Me.txtcodclie.Text.Trim.Length = 0 Then
        '        BuscarCliente()
        '        Me.txtcodarticulo.Focus()
        '    End If
        'End If
    End Sub

    Private Sub rbboleta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbboleta.CheckedChanged
        If Me.rbboleta.Checked = True Then
            If Consul_var = False Then
                VCdTipoDoc = CDBOLETA
                GenerarNroDocCot(True)
                ConfigDocumento()
                CargarGridFact()
            End If
        End If
    End Sub

    Private Sub rbfactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfactura.CheckedChanged
        If Me.rbfactura.Checked = True Then
            If Consul_var = False Then
                VCdTipoDoc = CDFACTURA
                GenerarNroDocCot(True)
                ConfigDocumento()
                CargarGridFact()
            End If
        End If
    End Sub

    Private Sub rbnotap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnotap.CheckedChanged
        If Me.rbnotap.Checked = True Then
            If Consul_var = False Then
                VCdTipoDoc = CDNTAPEDIDO
                GenerarNroDocCot(True)
                ConfigDocumento()
                CargarGridFact()
            End If
        End If
    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        If Consul_var = False Then
            Modificar_item()
        End If
    End Sub
    Private Sub Modificar_item()
        Try
            txtcodarticulo.Text = Me.Grid1.Item(Me.Grid1.CurrentRowIndex, 1)
            Carga_Presentacion()
            Me.txtdescripcion.Text = Me.Grid1.Item(Me.Grid1.CurrentRowIndex, 2)
            cbPresentacion.Text = Me.Grid1.Item(Me.Grid1.CurrentRowIndex, 3)
            CTRLCANTIDAD.Text = CDbl(Me.Grid1.Item(Me.Grid1.CurrentRowIndex, 4))
            CTRLPRECIO.Text = CDbl(Me.Grid1.Item(Me.Grid1.CurrentRowIndex, 5))

            Me.elimina_item(True)
            'LimpiarCjaTxtDet()
            Me.CTRLCANTIDAD.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CTRLPRECIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTRLPRECIO.TextChanged

    End Sub

    Private Sub CTRLCANTIDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CTRLCANTIDAD.KeyPress


        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Then
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

    Private Sub CTRLCANTIDAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTRLCANTIDAD.TextChanged

    End Sub

    Private Sub TxtDESC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDESC.TextChanged

    End Sub

    Private Sub TxtTOTAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTOTAL.TextChanged

    End Sub

    Private Sub txtcodclie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodclie.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click





        Ayuda.Ejecutar("SP_INSERT_TMP_VENTADET2_FD", VCorrelVta, NROPTOVTA)


        Dim SQL As String
        SQL = "DELETE FROM TMP_VENTADETFD WHERE CDUSUARIO = '" & CodUsuario & "' AND CORRNBR = " & VCorrelVta & " and CODEMPRESA= '" & codempresa & "'"
        TmpInsertDatos(SQL)


        TMP_VENTADET = TmpListarDatos("sp_sele_TMP_VENTADET_FD  '" & VCorrelVta & "','" & codempresa & "'")
        Grid1.DataSource = TMP_VENTADET

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Ayuda.Ejecutar("SP_INSERT_TMP_VENTADETFD", VCorrelVta, NROPTOVTA)




        TMP_VENTADET = TmpListarDatos("sp_sele_TMP_VENTADETFD  '" & VCorrelVta & "','" & codempresa & "'")
        Grid1.DataSource = TMP_VENTADET


    End Sub

    Private Sub txtruc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtruc.TextChanged

    End Sub

    Private Sub CTRLPRECIO_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles CTRLPRECIO.Resize

    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub
End Class
