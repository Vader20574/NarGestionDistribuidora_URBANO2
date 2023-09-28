Public Class FrmActFactNew
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TXTNUMERODOC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CboPagador As System.Windows.Forms.ComboBox
    Friend WithEvents CHKIGV As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpfechadoc As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents btncheque As System.Windows.Forms.Button
    Friend WithEvents btntarjeta As System.Windows.Forms.Button
    Friend WithEvents lbloperador As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltotalletras As System.Windows.Forms.Label
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents CRTDOC As AxCrystal.AxCrystalReport
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents lbltipodoc As System.Windows.Forms.Label
    Friend WithEvents LBLSIMBOLOCAMBIO As System.Windows.Forms.Label
    Friend WithEvents CboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
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
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtcodclie As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents cbovendedor As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents lblcambio As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents btnBusCli As System.Windows.Forms.Button
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
    Friend WithEvents TXTSERIEDOC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmActFactNew))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TXTNUMERODOC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.CboPagador = New System.Windows.Forms.ComboBox
        Me.CHKIGV = New System.Windows.Forms.CheckBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpfechadoc = New System.Windows.Forms.DateTimePicker
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnConsultar = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btngeneranuevo = New System.Windows.Forms.Button
        Me.btnreimprimir = New System.Windows.Forms.Button
        Me.btnanular = New System.Windows.Forms.Button
        Me.btndsctototal = New System.Windows.Forms.Button
        Me.btndsctoitem = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnvale = New System.Windows.Forms.Button
        Me.btncheque = New System.Windows.Forms.Button
        Me.btntarjeta = New System.Windows.Forms.Button
        Me.BtnGrabar = New System.Windows.Forms.Button
        Me.lbloperador = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbltotalletras = New System.Windows.Forms.Label
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.CRTDOC = New AxCrystal.AxCrystalReport
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.lbltipodoc = New System.Windows.Forms.Label
        Me.LBLSIMBOLOCAMBIO = New System.Windows.Forms.Label
        Me.CboMoneda = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
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
        Me.txtcliente = New System.Windows.Forms.TextBox
        Me.txtcodclie = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.cbovendedor = New System.Windows.Forms.ComboBox
        Me.cbTipoPrecio = New System.Windows.Forms.ComboBox
        Me.lblcambio = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.LblHora = New System.Windows.Forms.Label
        Me.btnBusCli = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CTRLCANTIDAD = New System.Windows.Forms.TextBox
        Me.txttipo = New System.Windows.Forms.TextBox
        Me.txtcodarticulo = New System.Windows.Forms.TextBox
        Me.cbPresentacion = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btneliitem = New System.Windows.Forms.Button
        Me.btnactuitem = New System.Windows.Forms.Button
        Me.btnnueitem = New System.Windows.Forms.Button
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.BtnBuscArt = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.CTRLPRECIO = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TXTSERIEDOC = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRTDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(320, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 188
        Me.Label5.Text = "R.U.C : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label9.Location = New System.Drawing.Point(582, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 16)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "Fecha Documento :  "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TXTNUMERODOC
        '
        Me.TXTNUMERODOC.BackColor = System.Drawing.Color.White
        Me.TXTNUMERODOC.Enabled = False
        Me.TXTNUMERODOC.Location = New System.Drawing.Point(252, 26)
        Me.TXTNUMERODOC.MaxLength = 7
        Me.TXTNUMERODOC.Name = "TXTNUMERODOC"
        Me.TXTNUMERODOC.Size = New System.Drawing.Size(80, 20)
        Me.TXTNUMERODOC.TabIndex = 213
        Me.TXTNUMERODOC.Text = ""
        Me.TXTNUMERODOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 187
        Me.Label4.Text = "Direccion :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Apell. o R.S. :"
        '
        'txtdireccion
        '
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Location = New System.Drawing.Point(204, 98)
        Me.txtdireccion.MaxLength = 40
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(370, 20)
        Me.txtdireccion.TabIndex = 195
        Me.txtdireccion.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label20.Location = New System.Drawing.Point(586, 124)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 16)
        Me.Label20.TabIndex = 215
        Me.Label20.Text = "Tipo Precio :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label10.Location = New System.Drawing.Point(599, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 219
        Me.Label10.Text = "Moneda : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label14.Location = New System.Drawing.Point(591, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 16)
        Me.Label14.TabIndex = 203
        Me.Label14.Text = "Vendedor : "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(143, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 201
        Me.Label12.Text = "Operador : "
        Me.Label12.Visible = False
        '
        'CboPagador
        '
        Me.CboPagador.BackColor = System.Drawing.Color.White
        Me.CboPagador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPagador.Enabled = False
        Me.CboPagador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPagador.Location = New System.Drawing.Point(658, 73)
        Me.CboPagador.Name = "CboPagador"
        Me.CboPagador.Size = New System.Drawing.Size(170, 22)
        Me.CboPagador.TabIndex = 218
        '
        'CHKIGV
        '
        Me.CHKIGV.Checked = True
        Me.CHKIGV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKIGV.Location = New System.Drawing.Point(736, 26)
        Me.CHKIGV.Name = "CHKIGV"
        Me.CHKIGV.Size = New System.Drawing.Size(93, 20)
        Me.CHKIGV.TabIndex = 214
        Me.CHKIGV.Text = "Aplicar IGV"
        Me.CHKIGV.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 189
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(246, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 17)
        Me.Label11.TabIndex = 211
        Me.Label11.Text = "-"
        '
        'dtpfechadoc
        '
        Me.dtpfechadoc.Enabled = False
        Me.dtpfechadoc.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfechadoc.Location = New System.Drawing.Point(688, 50)
        Me.dtpfechadoc.Name = "dtpfechadoc"
        Me.dtpfechadoc.Size = New System.Drawing.Size(86, 20)
        Me.dtpfechadoc.TabIndex = 199
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
        Me.GroupBox4.Controls.Add(Me.btncheque)
        Me.GroupBox4.Controls.Add(Me.btntarjeta)
        Me.GroupBox4.Controls.Add(Me.BtnGrabar)
        Me.GroupBox4.Location = New System.Drawing.Point(766, 244)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 114)
        Me.GroupBox4.TabIndex = 208
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
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.ImageIndex = 12
        Me.btnsalir.ImageList = Me.ImageList1
        Me.btnsalir.Location = New System.Drawing.Point(6, 74)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(124, 26)
        Me.btnsalir.TabIndex = 12
        Me.btnsalir.Text = "&Salir"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(18, 130)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(102, 26)
        Me.btncancelar.TabIndex = 11
        Me.btncancelar.Text = "&Cancelar "
        Me.btncancelar.Visible = False
        '
        'btngeneranuevo
        '
        Me.btngeneranuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngeneranuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btngeneranuevo.ImageIndex = 2
        Me.btngeneranuevo.ImageList = Me.ImageList1
        Me.btngeneranuevo.Location = New System.Drawing.Point(6, 44)
        Me.btngeneranuevo.Name = "btngeneranuevo"
        Me.btngeneranuevo.Size = New System.Drawing.Size(124, 26)
        Me.btngeneranuevo.TabIndex = 10
        Me.btngeneranuevo.Text = "Modificar Cliente"
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
        Me.Button3.Location = New System.Drawing.Point(12, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 35)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "Editar Numero (F12)"
        '
        'btnvale
        '
        Me.btnvale.Location = New System.Drawing.Point(18, 156)
        Me.btnvale.Name = "btnvale"
        Me.btnvale.Size = New System.Drawing.Size(102, 26)
        Me.btnvale.TabIndex = 69
        Me.btnvale.Text = "  Vale      (F11)"
        '
        'btncheque
        '
        Me.btncheque.Location = New System.Drawing.Point(154, 70)
        Me.btncheque.Name = "btncheque"
        Me.btncheque.Size = New System.Drawing.Size(102, 26)
        Me.btncheque.TabIndex = 3
        Me.btncheque.Text = "Cheque   (F9)"
        '
        'btntarjeta
        '
        Me.btntarjeta.Location = New System.Drawing.Point(154, 44)
        Me.btntarjeta.Name = "btntarjeta"
        Me.btntarjeta.Size = New System.Drawing.Size(102, 26)
        Me.btntarjeta.TabIndex = 1
        Me.btntarjeta.Text = "Tarjeta  (F8)"
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Enabled = False
        Me.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGrabar.ImageIndex = 1
        Me.BtnGrabar.ImageList = Me.ImageList1
        Me.BtnGrabar.Location = New System.Drawing.Point(6, 16)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(125, 26)
        Me.BtnGrabar.TabIndex = 0
        Me.BtnGrabar.Text = "&Grabar"
        '
        'lbloperador
        '
        Me.lbloperador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbloperador.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloperador.Location = New System.Drawing.Point(204, 3)
        Me.lbloperador.Name = "lbloperador"
        Me.lbloperador.Size = New System.Drawing.Size(135, 19)
        Me.lbloperador.TabIndex = 202
        Me.lbloperador.Text = "CodUsuario PTOVENTA"
        Me.lbloperador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbloperador.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltotalletras)
        Me.GroupBox2.Controls.Add(Me.Grid1)
        Me.GroupBox2.Controls.Add(Me.CRTDOC)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 234)
        Me.GroupBox2.TabIndex = 200
        Me.GroupBox2.TabStop = False
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
        Me.CRTDOC.ContainingControl = Me
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
        Me.BtnBuscar.Location = New System.Drawing.Point(340, 25)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(35, 23)
        Me.BtnBuscar.TabIndex = 192
        Me.BtnBuscar.Visible = False
        '
        'lbltipodoc
        '
        Me.lbltipodoc.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipodoc.Location = New System.Drawing.Point(366, 12)
        Me.lbltipodoc.Name = "lbltipodoc"
        Me.lbltipodoc.Size = New System.Drawing.Size(307, 31)
        Me.lbltipodoc.TabIndex = 197
        Me.lbltipodoc.Text = "BOLETA"
        Me.lbltipodoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLSIMBOLOCAMBIO
        '
        Me.LBLSIMBOLOCAMBIO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLOCAMBIO.Location = New System.Drawing.Point(686, 4)
        Me.LBLSIMBOLOCAMBIO.Name = "LBLSIMBOLOCAMBIO"
        Me.LBLSIMBOLOCAMBIO.Size = New System.Drawing.Size(17, 20)
        Me.LBLSIMBOLOCAMBIO.TabIndex = 210
        Me.LBLSIMBOLOCAMBIO.Text = "$"
        '
        'CboMoneda
        '
        Me.CboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMoneda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMoneda.Location = New System.Drawing.Point(658, 148)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(170, 22)
        Me.CboMoneda.TabIndex = 220
        Me.CboMoneda.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label13.Location = New System.Drawing.Point(598, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 16)
        Me.Label13.TabIndex = 217
        Me.Label13.Text = "Pagador : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
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
        Me.GroupBox3.Location = New System.Drawing.Point(4, 452)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(878, 50)
        Me.GroupBox3.TabIndex = 209
        Me.GroupBox3.TabStop = False
        '
        'TxtTOTAL
        '
        Me.TxtTOTAL.BackColor = System.Drawing.Color.White
        Me.TxtTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTOTAL.Location = New System.Drawing.Point(771, 15)
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
        Me.TxtDESC.Location = New System.Drawing.Point(552, 15)
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
        Me.TxtSUBTOTAL.Location = New System.Drawing.Point(145, 15)
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
        Me.TxtIGV.Location = New System.Drawing.Point(354, 15)
        Me.TxtIGV.Name = "TxtIGV"
        Me.TxtIGV.Size = New System.Drawing.Size(95, 26)
        Me.TxtIGV.TabIndex = 69
        Me.TxtIGV.Text = "0.00"
        Me.TxtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLSIMBOLO2
        '
        Me.LBLSIMBOLO2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO2.Location = New System.Drawing.Point(328, 18)
        Me.LBLSIMBOLO2.Name = "LBLSIMBOLO2"
        Me.LBLSIMBOLO2.Size = New System.Drawing.Size(32, 21)
        Me.LBLSIMBOLO2.TabIndex = 66
        Me.LBLSIMBOLO2.Text = "S/."
        '
        'LBLSIMBOLO4
        '
        Me.LBLSIMBOLO4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO4.Location = New System.Drawing.Point(743, 19)
        Me.LBLSIMBOLO4.Name = "LBLSIMBOLO4"
        Me.LBLSIMBOLO4.Size = New System.Drawing.Size(31, 19)
        Me.LBLSIMBOLO4.TabIndex = 68
        Me.LBLSIMBOLO4.Text = "S/."
        '
        'lblsimbolo
        '
        Me.lblsimbolo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsimbolo.Location = New System.Drawing.Point(121, 18)
        Me.lblsimbolo.Name = "lblsimbolo"
        Me.lblsimbolo.Size = New System.Drawing.Size(32, 21)
        Me.lblsimbolo.TabIndex = 65
        Me.lblsimbolo.Text = "S/."
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(18, 18)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(119, 21)
        Me.lblsubtotal.TabIndex = 0
        Me.lblsubtotal.Text = "SUB TOTAL."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(481, 17)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 22)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "DESC % "
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(676, 19)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 19)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "TOTAL"
        '
        'LBLIGV
        '
        Me.LBLIGV.AllowDrop = True
        Me.LBLIGV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIGV.Location = New System.Drawing.Point(290, 17)
        Me.LBLIGV.Name = "LBLIGV"
        Me.LBLIGV.Size = New System.Drawing.Size(51, 22)
        Me.LBLIGV.TabIndex = 2
        Me.LBLIGV.Text = "IGV  "
        '
        'txtcliente
        '
        Me.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcliente.Location = New System.Drawing.Point(204, 74)
        Me.txtcliente.MaxLength = 150
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(252, 20)
        Me.txtcliente.TabIndex = 194
        Me.txtcliente.Text = ""
        '
        'txtcodclie
        '
        Me.txtcodclie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodclie.Location = New System.Drawing.Point(204, 50)
        Me.txtcodclie.MaxLength = 20
        Me.txtcodclie.Name = "txtcodclie"
        Me.txtcodclie.Size = New System.Drawing.Size(81, 20)
        Me.txtcodclie.TabIndex = 191
        Me.txtcodclie.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Cod. Cliente :"
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(360, 50)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(98, 20)
        Me.txtruc.TabIndex = 193
        Me.txtruc.Text = ""
        '
        'cbovendedor
        '
        Me.cbovendedor.BackColor = System.Drawing.Color.White
        Me.cbovendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovendedor.Enabled = False
        Me.cbovendedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovendedor.Location = New System.Drawing.Point(658, 97)
        Me.cbovendedor.Name = "cbovendedor"
        Me.cbovendedor.Size = New System.Drawing.Size(170, 22)
        Me.cbovendedor.TabIndex = 204
        '
        'cbTipoPrecio
        '
        Me.cbTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPrecio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoPrecio.Location = New System.Drawing.Point(658, 120)
        Me.cbTipoPrecio.Name = "cbTipoPrecio"
        Me.cbTipoPrecio.Size = New System.Drawing.Size(170, 22)
        Me.cbTipoPrecio.TabIndex = 216
        Me.cbTipoPrecio.Visible = False
        '
        'lblcambio
        '
        Me.lblcambio.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.lblcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcambio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio.Location = New System.Drawing.Point(708, 5)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(52, 15)
        Me.lblcambio.TabIndex = 207
        Me.lblcambio.Text = "3.45"
        Me.lblcambio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(636, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 15)
        Me.Label16.TabIndex = 206
        Me.Label16.Text = "T.C. : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHora
        '
        Me.LblHora.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHora.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(764, 5)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(115, 15)
        Me.LblHora.TabIndex = 205
        Me.LblHora.Text = "03:42:58 P.M."
        Me.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusCli
        '
        Me.btnBusCli.ImageIndex = 5
        Me.btnBusCli.ImageList = Me.ImageList1
        Me.btnBusCli.Location = New System.Drawing.Point(286, 49)
        Me.btnBusCli.Name = "btnBusCli"
        Me.btnBusCli.Size = New System.Drawing.Size(33, 23)
        Me.btnBusCli.TabIndex = 190
        Me.btnBusCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox1.Location = New System.Drawing.Point(10, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 83)
        Me.GroupBox1.TabIndex = 196
        Me.GroupBox1.TabStop = False
        '
        'CTRLCANTIDAD
        '
        Me.CTRLCANTIDAD.Location = New System.Drawing.Point(368, 54)
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
        Me.txttipo.Text = ""
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
        Me.txtcodarticulo.Text = ""
        '
        'cbPresentacion
        '
        Me.cbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPresentacion.Location = New System.Drawing.Point(88, 54)
        Me.cbPresentacion.Name = "cbPresentacion"
        Me.cbPresentacion.Size = New System.Drawing.Size(185, 21)
        Me.cbPresentacion.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(446, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 16)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Precio : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
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
        Me.txtdescripcion.Text = ""
        '
        'BtnBuscArt
        '
        Me.BtnBuscArt.Enabled = False
        Me.BtnBuscArt.ImageIndex = 5
        Me.BtnBuscArt.ImageList = Me.ImageList1
        Me.BtnBuscArt.Location = New System.Drawing.Point(184, 16)
        Me.BtnBuscArt.Name = "BtnBuscArt"
        Me.BtnBuscArt.Size = New System.Drawing.Size(33, 23)
        Me.BtnBuscArt.TabIndex = 43
        Me.BtnBuscArt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Articulo : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 16)
        Me.Label17.TabIndex = 86
        Me.Label17.Text = "N Bultos :"
        Me.Label17.Visible = False
        '
        'CTRLPRECIO
        '
        Me.CTRLPRECIO.Location = New System.Drawing.Point(494, 54)
        Me.CTRLPRECIO.Name = "CTRLPRECIO"
        Me.CTRLPRECIO.Size = New System.Drawing.Size(60, 20)
        Me.CTRLPRECIO.TabIndex = 89
        Me.CTRLPRECIO.Text = "0"
        Me.CTRLPRECIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 16)
        Me.Label22.TabIndex = 88
        Me.Label22.Text = "Presentación :"
        '
        'TXTSERIEDOC
        '
        Me.TXTSERIEDOC.BackColor = System.Drawing.Color.White
        Me.TXTSERIEDOC.Enabled = False
        Me.TXTSERIEDOC.Location = New System.Drawing.Point(204, 26)
        Me.TXTSERIEDOC.Name = "TXTSERIEDOC"
        Me.TXTSERIEDOC.Size = New System.Drawing.Size(43, 20)
        Me.TXTSERIEDOC.TabIndex = 212
        Me.TXTSERIEDOC.Text = ""
        Me.TXTSERIEDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "N° Doc :"
        '
        'FrmActFactNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(920, 514)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TXTNUMERODOC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.txtcodclie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtruc)
        Me.Controls.Add(Me.TXTSERIEDOC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.CboPagador)
        Me.Controls.Add(Me.CHKIGV)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dtpfechadoc)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lbloperador)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.lbltipodoc)
        Me.Controls.Add(Me.LBLSIMBOLOCAMBIO)
        Me.Controls.Add(Me.CboMoneda)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cbovendedor)
        Me.Controls.Add(Me.cbTipoPrecio)
        Me.Controls.Add(Me.lblcambio)
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.btnBusCli)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmActFactNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizacion de Facturacion"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRTDOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Funciones de Form"

    Private Sub CargarGridFactServ()
        TMP_VENTADET = TmpListarDatos("sp_SelecTMP_VENTADETSERV  '" & VCorrelVta & "','" & codempresa & "'")
        Grid1.DataSource = TMP_VENTADET
        If TMP_VENTADET.Rows.Count > 0 Then
            Dim TABLE_VTA As New DataTable
            TABLE_VTA = TmpListarDatos("OBTIENE_TOTALES_FACTSERV_PROC  '" & codempresa & "','" & VCorrelVta & "'")
            TxtTOTAL.Text = FormatoMonto(TABLE_VTA.Rows(0)("TOTAL"), DECIRESU)
            TxtSUBTOTAL.Text = FormatoMonto(TABLE_VTA.Rows(0)("SUBTOTAL"), DECIRESU)
            TxtIGV.Text = FormatoMonto(TABLE_VTA.Rows(0)("IGV"), DECIRESU)
        End If

    End Sub
    Private Sub FormatoGridDetVtaServ()
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
            .MappingName = "DESCRIPCION"
            .HeaderText = "DESCRIPCION"
            .NullText = ""
            .Width = 500
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "CANTIDAD"
            .HeaderText = "CANTIDAD"
            .NullText = ""
            .Format = GMascaraDec(DECICANT)
            .Width = 60
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "PRECIO"
            .HeaderText = "PRECIO"
            .NullText = ""
            .Format = GMascaraDec(DECIPREC)
            .Width = 60
        End With

        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "TOTAL"
            .HeaderText = "TOTAL"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Width = 60
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5})
        Grid1.TableStyles.Clear()
        Grid1.TableStyles.Add(TableStyle1)

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
            VItemDoc = ITEMDENTAPEDIDO
        End If
    End Sub
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
        If CAyuda.Ejecutar("TMP_VENTADETInsProc", codempresa, VCorrelVta, txtcodarticulo.Text, CboMoneda.SelectedValue, CDZONA, "", txtdescripcion.Text, CTRLCANTIDAD.Text, CTRLPRECIO.Text, CTRLPRECIO.Text, dtpfechadoc.Value, Format(CDate(dtpfechadoc.Value), "dd/MM/yyyy"), CodUsuario, False, VCambioVta, False, False, 0, 0, "", cbPresentacion.SelectedValue, cbPresentacion.Text) > 0 Then
            CargarGridFact()
            FormatoGridDetVta()
            LimpiarCjaTxtDet()
            txtcodarticulo.Focus()
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
            Dim TABLE_VTA As New DataTable
            TABLE_VTA = TmpListarDatos("OBTIENE_TOTALES_FACTURACION_PROC  '" & codempresa & "','" & VCorrelVta & "'")
            TxtTOTAL.Text = FormatoMonto(TABLE_VTA.Rows(0)("TOTBAS"), DECIRESU)
            TxtSUBTOTAL.Text = FormatoMonto(TABLE_VTA.Rows(0)("SUBTOTBAS"), DECIRESU)
            TxtIGV.Text = FormatoMonto(TABLE_VTA.Rows(0)("IGVBAS"), DECIRESU)

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

    Public FECHA As Date

    Private Sub BuscarDocumento()

        'Dim FrmBDoc As New FrmConsultarFacturac2
        'FrmBDoc.ShowDialog()
        'If FrmBDoc.DEVOLVER = False Then
        '    Exit Sub
        'End If
        'VCdTipoDoc = Trim(FrmBDoc.DtgDoc.Item(FrmBDoc.DtgDoc.CurrentRowIndex, 0).ToString())
        'VNroDoc = Trim(FrmBDoc.DtgDoc.Item(FrmBDoc.DtgDoc.CurrentRowIndex, 2).ToString())
        ' ConfigDocumento()

        Dim VentaC, VentD As String
        Dim MesAct, Anio As String
        MesAct = Format(FECHA, "MM")
        Anio = Format(FECHA, "yyyy")

        VentaC = "VENTC" & Anio & MesAct
        VentD = "VENTD" & Anio & MesAct

        Dim TABCAB As New DataTable

        TABCAB = TmpListarDatos("VENTACABSelProc  '" & codempresa & "', '" & VCdTipoDoc & "','" & VNroDoc & "','" & VentaC & "' ")

        If TABCAB.Rows.Count > 0 Then

            txtcodclie.Text = TABCAB.Rows(0)("CODCLIENTE")
            txtcliente.Text = TABCAB.Rows(0)("DESCLIENTE")
            txtruc.Text = TABCAB.Rows(0)("RUCCLIENTE")
            VRuc = TABCAB.Rows(0)("RUCCLIENTE")
            txtdireccion.Text = TABCAB.Rows(0)("DIRCLIENTE")
            VCodDep = TABCAB.Rows(0)("CODDEP")
            CboPagador.SelectedValue = VCodDep
            'TmpListarDatos("CARGADETALLE_PARA_NUEVOTICKET_PROC  '" & codempresa & "','" & VCorrelVta & "','" & VCdTipoDoc & "' , '" & VNroDoc & "'")
            TmpListarDatos("CARGADETALLE_PARA_NUEVOTICKET_PROC  '" & codempresa & "','" & VCorrelVta & "','" & VCdTipoDoc & "' , '" & VNroDoc & "' ,'" & VentD & "'")

            CargarGridFact()
            FormatoGridDetVta()
            ConfigDocumento()
        Else
            TABCAB = TmpListarDatos("SP_SelecVENTACABSERV  '" & codempresa & "','" & VCdTipoDoc & "','" & VNroDoc & "'")
            If TABCAB.Rows.Count > 0 Then
                txtcodclie.Text = TABCAB.Rows(0)("CODCLIENTE")
                txtruc.Text = TABCAB.Rows(0)("RUCCLIENTE")
                txtcliente.Text = TABCAB.Rows(0)("DESCLIENTE")
                txtdireccion.Text = TABCAB.Rows(0)("DIRCLIENTE")
                CboPagador.SelectedValue = TABCAB.Rows(0)("CODDEP")
                dtpfechadoc.Value = TABCAB.Rows(0)("FECDOCUM")
                TmpInsertDatos("SP_TraerDOCUMENTOSERV_Fact  '" & codempresa & "','" & VCdTipoDoc & "','" & VNroDoc & "','" & VCorrelVta & "'")
                CargarGridFactServ()
                FormatoGridDetVtaServ()
            End If
        End If

    End Sub
    Private Sub HabilitarCtrl(ByVal valor As Boolean, ByVal Control As Control)
        Dim obj As Object
        For Each obj In Control.Controls
            If TypeOf obj Is TextBox Then
                obj.enabled = valor
            End If
            If TypeOf obj Is ComboBox Then
                obj.enabled = valor
            End If
        Next
        Grid1.Enabled = valor

    End Sub
    Private Sub elimina_item()
        Try
            Dim sql As String
            sql = "SP_DELETE_ITEM_TMPVENTADET " & VCorrelVta & "," & Grid1.Item(Grid1.CurrentRowIndex, 0) & ""
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


#End Region


    Private Sub FrmActFactNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IniciarDatos()
        'GenerarNroDoc()
        'ConfigDocumento()
        BuscarDocumento()
        ConfigDocumento()
        HabilitarCtrl(False, Me)
        HabilitarCtrl(False, GroupBox1)


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
        TMP_PRESENTACION = TmpListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT  '" & codempresa & "','" & txtcodarticulo.Text & "','" & CDTIPOPRE1 & "'")
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
        If VClieDep.Trim.Length = 0 Then
            CboPagador.SelectedIndex = -1
            CboPagador.SelectedIndex = -1
        Else
            CboPagador.SelectedValue = VClieDep
        End If

        If txtruc.Text.Trim <> "" Then
            GenerarNroDoc()
            ConfigDocumento()
        End If

    End Sub

    Private Sub cbPresentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPresentacion.SelectedIndexChanged
        If TMP_PRESENTACION.Rows.Count > 0 And ActEventCombo = True Then
            Dim TBPREC As New DataTable
            TBPREC = TmpListarDatos("SP_BUSC_PRECIOARTFACT   '" & codempresa & "','" & cbPresentacion.SelectedValue & "','" & CDTIPOPRE1 & "','" & txtcodarticulo.Text & "','" & txtcodclie.Text & "'")
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
        txtcodclie.Enabled = True
        btnBusCli.Enabled = True
        txtruc.Enabled = True
        txtcliente.Enabled = True
        txtdireccion.Enabled = True
        BtnGrabar.Enabled = True

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()

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
    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
    End Sub
    Private Sub CTRLCANTIDAD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CTRLCANTIDAD.TextChanged
    End Sub
    Private Sub CTRLCANTIDAD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CTRLCANTIDAD.KeyDown
        If e.KeyCode = Keys.Enter Then
            CTRLPRECIO.Focus()
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
            GenerarNroDoc()
            ConfigDocumento()
        End If
        If e.KeyCode = Keys.F1 Then
            If VUsarNotaPedido = True Then
                VUsarNotaPedido = False
            Else
                VUsarNotaPedido = True
            End If
            GenerarNroDoc()
            ConfigDocumento()
        End If

    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        VCodCliente = txtcodclie.Text
        VRuc = txtruc.Text
        VDescliente = txtcliente.Text
        VDireccion = txtdireccion.Text
        VClieDep = IIf(IsNothing(CboPagador.SelectedValue), "", CboPagador.SelectedValue)
        DEVOLVER = True
        Me.Close()

    End Sub
End Class
