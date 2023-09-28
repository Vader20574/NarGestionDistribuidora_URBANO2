Imports System.Data.SqlClient
Imports System.Transactions
Imports Servicios.Implementacion
Imports Servicios.Interfaces.Factura
Imports Servicios.Interfaces.Facturacion.VentaDet.Peticiones
Imports Servicios.Interfaces.FacturaElectronica.Peticiones

Public Class FrmMantenimientoPromociones2
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProdVtaCant As System.Windows.Forms.TextBox
    Friend WithEvents btnBusqProdVta As System.Windows.Forms.Button
    Friend WithEvents txtProdVtaCod As System.Windows.Forms.TextBox
    Friend WithEvents lbProductoVta As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripción As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPromo As System.Windows.Forms.TextBox
    Friend WithEvents txtProdPromoCod As System.Windows.Forms.TextBox
    Friend WithEvents lbProductoPromo As System.Windows.Forms.Label
    Friend WithEvents txtProfPromoCant As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents btnBusqPromo As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboPresentProm As System.Windows.Forms.ComboBox
    Friend WithEvents CboPresentVta As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CboZona As System.Windows.Forms.ComboBox
    Friend WithEvents GrpPromo As System.Windows.Forms.GroupBox
    Friend WithEvents dgCuotaLinea As System.Windows.Forms.DataGrid
    Friend WithEvents CboTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarPresent As System.Windows.Forms.Button
    Friend WithEvents btnQuitarPrest As System.Windows.Forms.Button
    Friend WithEvents ChkActivar As System.Windows.Forms.CheckBox
    Friend WithEvents cbTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnAgregarTipoPag As System.Windows.Forms.Button
    Friend WithEvents btnQuitarTipoPag As System.Windows.Forms.Button
    Friend WithEvents Dsfinanza1 As NarGestionDistribuidora.dsfinanza
    Friend WithEvents TxtCantDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMinPres As System.Windows.Forms.Label
    Friend WithEvents lblMinPres2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtTotDocE As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtcodclie As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnBusCli As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtDoc1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDoc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtDoc11 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDoc22 As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cbTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents lblAlm As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TxtcodMB As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GrpVta As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoPromociones2))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.lblAlm = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.cbTipoPrecio = New System.Windows.Forms.ComboBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtcliente = New System.Windows.Forms.TextBox
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.TxtDoc11 = New System.Windows.Forms.TextBox
        Me.txtPrecio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtDoc22 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtDoc1 = New System.Windows.Forms.TextBox
        Me.TxtDoc2 = New System.Windows.Forms.TextBox
        Me.txtcodclie = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnBusCli = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtTotDocE = New System.Windows.Forms.TextBox
        Me.cbTipoPago = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblMinPres2 = New System.Windows.Forms.Label
        Me.lblMinPres = New System.Windows.Forms.Label
        Me.TxtCantDoc = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CboZona = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtStock = New System.Windows.Forms.TextBox
        Me.GrpPromo = New System.Windows.Forms.GroupBox
        Me.CboPresentProm = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtProdPromoCod = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbProductoPromo = New System.Windows.Forms.Label
        Me.txtProfPromoCant = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GrpVta = New System.Windows.Forms.GroupBox
        Me.CboPresentVta = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnBusqProdVta = New System.Windows.Forms.Button
        Me.txtProdVtaCod = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbProductoVta = New System.Windows.Forms.Label
        Me.txtProdVtaCant = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnBusqPromo = New System.Windows.Forms.Button
        Me.txtDescripción = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodPromo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dgCuotaLinea = New System.Windows.Forms.DataGrid
        Me.CboTipoPrecio = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnAgregarPresent = New System.Windows.Forms.Button
        Me.btnQuitarPrest = New System.Windows.Forms.Button
        Me.ChkActivar = New System.Windows.Forms.CheckBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnAgregarTipoPag = New System.Windows.Forms.Button
        Me.btnQuitarTipoPag = New System.Windows.Forms.Button
        Me.TxtcodMB = New System.Windows.Forms.TextBox
        Me.Dsfinanza1 = New NarGestionDistribuidora.dsfinanza
        Me.Label29 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GrpPromo.SuspendLayout()
        Me.GrpVta.SuspendLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsfinanza1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(499, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 300)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(10, 134)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(10, 164)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Cerrar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(10, 106)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Eliminar"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(10, 77)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNMODIFICAR.TabIndex = 3
        Me.BTNMODIFICAR.Text = "&Modificar"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(10, 19)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(94, 29)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(10, 48)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.TxtcodMB)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cboAlmacen)
        Me.GroupBox2.Controls.Add(Me.lblAlm)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.cbTipoPrecio)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
        Me.GroupBox2.Controls.Add(Me.txtcliente)
        Me.GroupBox2.Controls.Add(Me.txtruc)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.TxtDoc11)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtDoc22)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.TxtDoc1)
        Me.GroupBox2.Controls.Add(Me.TxtDoc2)
        Me.GroupBox2.Controls.Add(Me.txtcodclie)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.btnBusCli)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cbTipoDoc)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TxtTotDocE)
        Me.GroupBox2.Controls.Add(Me.cbTipoPago)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblMinPres2)
        Me.GroupBox2.Controls.Add(Me.lblMinPres)
        Me.GroupBox2.Controls.Add(Me.TxtCantDoc)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.btnBusqPromo)
        Me.GroupBox2.Controls.Add(Me.txtDescripción)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCodPromo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 421)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(410, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 39)
        Me.Button1.TabIndex = 53
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.Enabled = False
        Me.cboAlmacen.ItemHeight = 13
        Me.cboAlmacen.Location = New System.Drawing.Point(88, 394)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(238, 21)
        Me.cboAlmacen.TabIndex = 38
        '
        'lblAlm
        '
        Me.lblAlm.AutoSize = True
        Me.lblAlm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAlm.Location = New System.Drawing.Point(26, 394)
        Me.lblAlm.Name = "lblAlm"
        Me.lblAlm.Size = New System.Drawing.Size(54, 13)
        Me.lblAlm.TabIndex = 37
        Me.lblAlm.Text = "Almacen :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(189, 356)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(12, 13)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "-"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(248, 127)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(114, 18)
        Me.Label27.TabIndex = 51
        Me.Label27.Text = "TipoPrecio :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTipoPrecio
        '
        Me.cbTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPrecio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoPrecio.Location = New System.Drawing.Point(364, 125)
        Me.cbTipoPrecio.Name = "cbTipoPrecio"
        Me.cbTipoPrecio.Size = New System.Drawing.Size(127, 22)
        Me.cbTipoPrecio.TabIndex = 50
        '
        'txtdireccion
        '
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Location = New System.Drawing.Point(139, 261)
        Me.txtdireccion.MaxLength = 40
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(335, 20)
        Me.txtdireccion.TabIndex = 48
        '
        'txtcliente
        '
        Me.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcliente.Location = New System.Drawing.Point(139, 237)
        Me.txtcliente.MaxLength = 150
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(335, 20)
        Me.txtcliente.TabIndex = 46
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(294, 214)
        Me.txtruc.MaxLength = 20
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(98, 20)
        Me.txtruc.TabIndex = 44
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(76, 263)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 13)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Direccion :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(62, 240)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 13)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Apell. o R.S. :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(255, 217)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 13)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "R.U.C : "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(31, 353)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 13)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "Nro de Doc Final :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDoc11
        '
        Me.TxtDoc11.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDoc11.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc11.Location = New System.Drawing.Point(148, 353)
        Me.TxtDoc11.MaxLength = 3
        Me.TxtDoc11.Name = "TxtDoc11"
        Me.TxtDoc11.Size = New System.Drawing.Size(40, 20)
        Me.TxtDoc11.TabIndex = 42
        Me.TxtDoc11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(289, 151)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(92, 20)
        Me.txtPrecio.TabIndex = 9
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(221, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDoc22
        '
        Me.TxtDoc22.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc22.Location = New System.Drawing.Point(202, 353)
        Me.TxtDoc22.MaxLength = 7
        Me.TxtDoc22.Name = "TxtDoc22"
        Me.TxtDoc22.Size = New System.Drawing.Size(68, 20)
        Me.TxtDoc22.TabIndex = 43
        Me.TxtDoc22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(31, 330)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 13)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Nro de Doc Inicio:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(189, 334)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(12, 13)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "-"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDoc1
        '
        Me.TxtDoc1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDoc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc1.Location = New System.Drawing.Point(148, 327)
        Me.TxtDoc1.MaxLength = 3
        Me.TxtDoc1.Name = "TxtDoc1"
        Me.TxtDoc1.Size = New System.Drawing.Size(40, 20)
        Me.TxtDoc1.TabIndex = 38
        Me.TxtDoc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDoc2
        '
        Me.TxtDoc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc2.Location = New System.Drawing.Point(202, 327)
        Me.TxtDoc2.MaxLength = 7
        Me.TxtDoc2.Name = "TxtDoc2"
        Me.TxtDoc2.Size = New System.Drawing.Size(68, 20)
        Me.TxtDoc2.TabIndex = 40
        Me.TxtDoc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcodclie
        '
        Me.txtcodclie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodclie.Enabled = False
        Me.txtcodclie.Location = New System.Drawing.Point(137, 211)
        Me.txtcodclie.MaxLength = 20
        Me.txtcodclie.Name = "txtcodclie"
        Me.txtcodclie.ReadOnly = True
        Me.txtcodclie.Size = New System.Drawing.Size(81, 20)
        Me.txtcodclie.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(61, 214)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Cod. Cliente :"
        '
        'btnBusCli
        '
        Me.btnBusCli.ImageIndex = 5
        Me.btnBusCli.ImageList = Me.ImageList1
        Me.btnBusCli.Location = New System.Drawing.Point(219, 210)
        Me.btnBusCli.Name = "btnBusCli"
        Me.btnBusCli.Size = New System.Drawing.Size(33, 23)
        Me.btnBusCli.TabIndex = 36
        Me.btnBusCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(64, 182)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 18)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Tipo Doc"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Location = New System.Drawing.Point(138, 183)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(171, 21)
        Me.cbTipoDoc.TabIndex = 30
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(21, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 18)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Total Doc a Emitir :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTotDocE
        '
        Me.TxtTotDocE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotDocE.Location = New System.Drawing.Point(138, 125)
        Me.TxtTotDocE.MaxLength = 50
        Me.TxtTotDocE.Name = "TxtTotDocE"
        Me.TxtTotDocE.Size = New System.Drawing.Size(104, 20)
        Me.TxtTotDocE.TabIndex = 28
        '
        'cbTipoPago
        '
        Me.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPago.Location = New System.Drawing.Point(137, 299)
        Me.cbTipoPago.Name = "cbTipoPago"
        Me.cbTipoPago.Size = New System.Drawing.Size(202, 21)
        Me.cbTipoPago.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(73, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Tipo Pago :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMinPres2
        '
        Me.lblMinPres2.Location = New System.Drawing.Point(248, 103)
        Me.lblMinPres2.Name = "lblMinPres2"
        Me.lblMinPres2.Size = New System.Drawing.Size(22, 18)
        Me.lblMinPres2.TabIndex = 27
        Me.lblMinPres2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMinPres
        '
        Me.lblMinPres.Location = New System.Drawing.Point(248, 74)
        Me.lblMinPres.Name = "lblMinPres"
        Me.lblMinPres.Size = New System.Drawing.Size(22, 18)
        Me.lblMinPres.TabIndex = 26
        Me.lblMinPres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCantDoc
        '
        Me.TxtCantDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCantDoc.Location = New System.Drawing.Point(138, 97)
        Me.TxtCantDoc.MaxLength = 50
        Me.TxtCantDoc.Name = "TxtCantDoc"
        Me.TxtCantDoc.Size = New System.Drawing.Size(104, 20)
        Me.TxtCantDoc.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(38, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Fecha"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(18, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 18)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Cantidad x Doc :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(15, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 18)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Cantidad a Boletear :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(138, 74)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 22
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(110, 155)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha.TabIndex = 17
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CboZona)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtStock)
        Me.GroupBox5.Controls.Add(Me.GrpPromo)
        Me.GroupBox5.Controls.Add(Me.GrpVta)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 516)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(458, 62)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle de Promocion"
        '
        'CboZona
        '
        Me.CboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboZona.Enabled = False
        Me.CboZona.Location = New System.Drawing.Point(90, 18)
        Me.CboZona.Name = "CboZona"
        Me.CboZona.Size = New System.Drawing.Size(236, 21)
        Me.CboZona.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(34, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Almacen : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStock
        '
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(194, 242)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(108, 21)
        Me.txtStock.TabIndex = 15
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GrpPromo
        '
        Me.GrpPromo.Controls.Add(Me.CboPresentProm)
        Me.GrpPromo.Controls.Add(Me.Label7)
        Me.GrpPromo.Controls.Add(Me.Button2)
        Me.GrpPromo.Controls.Add(Me.txtProdPromoCod)
        Me.GrpPromo.Controls.Add(Me.Label8)
        Me.GrpPromo.Controls.Add(Me.lbProductoPromo)
        Me.GrpPromo.Controls.Add(Me.txtProfPromoCant)
        Me.GrpPromo.Controls.Add(Me.Label11)
        Me.GrpPromo.Enabled = False
        Me.GrpPromo.Location = New System.Drawing.Point(10, 144)
        Me.GrpPromo.Name = "GrpPromo"
        Me.GrpPromo.Size = New System.Drawing.Size(442, 98)
        Me.GrpPromo.TabIndex = 13
        Me.GrpPromo.TabStop = False
        Me.GrpPromo.Text = "Producto Promoción"
        '
        'CboPresentProm
        '
        Me.CboPresentProm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPresentProm.Enabled = False
        Me.CboPresentProm.Location = New System.Drawing.Point(80, 48)
        Me.CboPresentProm.Name = "CboPresentProm"
        Me.CboPresentProm.Size = New System.Drawing.Size(236, 21)
        Me.CboPresentProm.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Cantidad :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.ImageIndex = 5
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(146, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 24)
        Me.Button2.TabIndex = 4
        '
        'txtProdPromoCod
        '
        Me.txtProdPromoCod.Location = New System.Drawing.Point(80, 24)
        Me.txtProdPromoCod.Name = "txtProdPromoCod"
        Me.txtProdPromoCod.Size = New System.Drawing.Size(62, 20)
        Me.txtProdPromoCod.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Producto :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbProductoPromo
        '
        Me.lbProductoPromo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProductoPromo.Location = New System.Drawing.Point(184, 24)
        Me.lbProductoPromo.Name = "lbProductoPromo"
        Me.lbProductoPromo.Size = New System.Drawing.Size(248, 22)
        Me.lbProductoPromo.TabIndex = 7
        '
        'txtProfPromoCant
        '
        Me.txtProfPromoCant.Location = New System.Drawing.Point(80, 72)
        Me.txtProfPromoCant.Name = "txtProfPromoCant"
        Me.txtProfPromoCant.Size = New System.Drawing.Size(70, 20)
        Me.txtProfPromoCant.TabIndex = 11
        Me.txtProfPromoCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Presentacion :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrpVta
        '
        Me.GrpVta.Controls.Add(Me.CboPresentVta)
        Me.GrpVta.Controls.Add(Me.Label6)
        Me.GrpVta.Controls.Add(Me.btnBusqProdVta)
        Me.GrpVta.Controls.Add(Me.txtProdVtaCod)
        Me.GrpVta.Controls.Add(Me.Label3)
        Me.GrpVta.Controls.Add(Me.lbProductoVta)
        Me.GrpVta.Controls.Add(Me.txtProdVtaCant)
        Me.GrpVta.Controls.Add(Me.Label12)
        Me.GrpVta.Enabled = False
        Me.GrpVta.Location = New System.Drawing.Point(10, 42)
        Me.GrpVta.Name = "GrpVta"
        Me.GrpVta.Size = New System.Drawing.Size(442, 96)
        Me.GrpVta.TabIndex = 12
        Me.GrpVta.TabStop = False
        Me.GrpVta.Text = "Producto Venta"
        '
        'CboPresentVta
        '
        Me.CboPresentVta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPresentVta.Enabled = False
        Me.CboPresentVta.Location = New System.Drawing.Point(80, 48)
        Me.CboPresentVta.Name = "CboPresentVta"
        Me.CboPresentVta.Size = New System.Drawing.Size(236, 21)
        Me.CboPresentVta.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cantidad :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusqProdVta
        '
        Me.btnBusqProdVta.ImageIndex = 5
        Me.btnBusqProdVta.ImageList = Me.ImageList1
        Me.btnBusqProdVta.Location = New System.Drawing.Point(146, 24)
        Me.btnBusqProdVta.Name = "btnBusqProdVta"
        Me.btnBusqProdVta.Size = New System.Drawing.Size(38, 24)
        Me.btnBusqProdVta.TabIndex = 4
        '
        'txtProdVtaCod
        '
        Me.txtProdVtaCod.Location = New System.Drawing.Point(80, 24)
        Me.txtProdVtaCod.Name = "txtProdVtaCod"
        Me.txtProdVtaCod.Size = New System.Drawing.Size(64, 20)
        Me.txtProdVtaCod.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Producto :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbProductoVta
        '
        Me.lbProductoVta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProductoVta.Location = New System.Drawing.Point(184, 24)
        Me.lbProductoVta.Name = "lbProductoVta"
        Me.lbProductoVta.Size = New System.Drawing.Size(250, 22)
        Me.lbProductoVta.TabIndex = 7
        '
        'txtProdVtaCant
        '
        Me.txtProdVtaCant.Location = New System.Drawing.Point(80, 72)
        Me.txtProdVtaCant.Name = "txtProdVtaCant"
        Me.txtProdVtaCant.Size = New System.Drawing.Size(68, 20)
        Me.txtProdVtaCant.TabIndex = 11
        Me.txtProdVtaCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Presentacion :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "STOCK PROM. :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusqPromo
        '
        Me.btnBusqPromo.ImageIndex = 5
        Me.btnBusqPromo.ImageList = Me.ImageList1
        Me.btnBusqPromo.Location = New System.Drawing.Point(192, 22)
        Me.btnBusqPromo.Name = "btnBusqPromo"
        Me.btnBusqPromo.Size = New System.Drawing.Size(30, 22)
        Me.btnBusqPromo.TabIndex = 16
        '
        'txtDescripción
        '
        Me.txtDescripción.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripción.Location = New System.Drawing.Point(86, 46)
        Me.txtDescripción.MaxLength = 50
        Me.txtDescripción.Name = "txtDescripción"
        Me.txtDescripción.Size = New System.Drawing.Size(266, 20)
        Me.txtDescripción.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripción :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodPromo
        '
        Me.txtCodPromo.Enabled = False
        Me.txtCodPromo.Location = New System.Drawing.Point(88, 22)
        Me.txtCodPromo.MaxLength = 12
        Me.txtCodPromo.Name = "txtCodPromo"
        Me.txtCodPromo.ReadOnly = True
        Me.txtCodPromo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodPromo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(651, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fec.Fin"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(721, 342)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaFin.TabIndex = 18
        '
        'dgCuotaLinea
        '
        Me.dgCuotaLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCuotaLinea.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgCuotaLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCuotaLinea.DataMember = ""
        Me.dgCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotaLinea.Location = New System.Drawing.Point(646, 268)
        Me.dgCuotaLinea.Name = "dgCuotaLinea"
        Me.dgCuotaLinea.ReadOnly = True
        Me.dgCuotaLinea.Size = New System.Drawing.Size(491, 167)
        Me.dgCuotaLinea.TabIndex = 19
        '
        'CboTipoPrecio
        '
        Me.CboTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPrecio.ItemHeight = 13
        Me.CboTipoPrecio.Location = New System.Drawing.Point(708, 193)
        Me.CboTipoPrecio.Name = "CboTipoPrecio"
        Me.CboTipoPrecio.Size = New System.Drawing.Size(236, 21)
        Me.CboTipoPrecio.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(629, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Tipo Precio :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAgregarPresent
        '
        Me.btnAgregarPresent.Image = CType(resources.GetObject("btnAgregarPresent.Image"), System.Drawing.Image)
        Me.btnAgregarPresent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarPresent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgregarPresent.Location = New System.Drawing.Point(675, 157)
        Me.btnAgregarPresent.Name = "btnAgregarPresent"
        Me.btnAgregarPresent.Size = New System.Drawing.Size(84, 30)
        Me.btnAgregarPresent.TabIndex = 22
        Me.btnAgregarPresent.TabStop = False
        Me.btnAgregarPresent.Text = "  &Agregar"
        '
        'btnQuitarPrest
        '
        Me.btnQuitarPrest.Image = CType(resources.GetObject("btnQuitarPrest.Image"), System.Drawing.Image)
        Me.btnQuitarPrest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitarPrest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnQuitarPrest.Location = New System.Drawing.Point(689, 223)
        Me.btnQuitarPrest.Name = "btnQuitarPrest"
        Me.btnQuitarPrest.Size = New System.Drawing.Size(84, 30)
        Me.btnQuitarPrest.TabIndex = 23
        Me.btnQuitarPrest.TabStop = False
        Me.btnQuitarPrest.Text = "&Eliminar"
        '
        'ChkActivar
        '
        Me.ChkActivar.AutoSize = True
        Me.ChkActivar.Location = New System.Drawing.Point(654, 441)
        Me.ChkActivar.Name = "ChkActivar"
        Me.ChkActivar.Size = New System.Drawing.Size(59, 17)
        Me.ChkActivar.TabIndex = 24
        Me.ChkActivar.Text = "Activar"
        Me.ChkActivar.UseVisualStyleBackColor = True
        '
        'DataGrid1
        '
        Me.DataGrid1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(637, 466)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(320, 114)
        Me.DataGrid1.TabIndex = 27
        '
        'btnAgregarTipoPag
        '
        Me.btnAgregarTipoPag.Image = CType(resources.GetObject("btnAgregarTipoPag.Image"), System.Drawing.Image)
        Me.btnAgregarTipoPag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarTipoPag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgregarTipoPag.Location = New System.Drawing.Point(985, 466)
        Me.btnAgregarTipoPag.Name = "btnAgregarTipoPag"
        Me.btnAgregarTipoPag.Size = New System.Drawing.Size(84, 30)
        Me.btnAgregarTipoPag.TabIndex = 28
        Me.btnAgregarTipoPag.TabStop = False
        Me.btnAgregarTipoPag.Text = "  &Agregar"
        '
        'btnQuitarTipoPag
        '
        Me.btnQuitarTipoPag.Image = CType(resources.GetObject("btnQuitarTipoPag.Image"), System.Drawing.Image)
        Me.btnQuitarTipoPag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitarTipoPag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnQuitarTipoPag.Location = New System.Drawing.Point(987, 508)
        Me.btnQuitarTipoPag.Name = "btnQuitarTipoPag"
        Me.btnQuitarTipoPag.Size = New System.Drawing.Size(84, 30)
        Me.btnQuitarTipoPag.TabIndex = 29
        Me.btnQuitarTipoPag.TabStop = False
        Me.btnQuitarTipoPag.Text = "&Eliminar"
        '
        'TxtcodMB
        '
        Me.TxtcodMB.Enabled = False
        Me.TxtcodMB.Location = New System.Drawing.Point(315, 19)
        Me.TxtcodMB.MaxLength = 12
        Me.TxtcodMB.Name = "TxtcodMB"
        Me.TxtcodMB.ReadOnly = True
        Me.TxtcodMB.Size = New System.Drawing.Size(74, 20)
        Me.TxtcodMB.TabIndex = 54
        '
        'Dsfinanza1
        '
        Me.Dsfinanza1.DataSetName = "dsfinanza"
        Me.Dsfinanza1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(233, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 18)
        Me.Label29.TabIndex = 55
        Me.Label29.Text = "NroBoleteo :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmMantenimientoPromociones2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(631, 477)
        Me.Controls.Add(Me.btnAgregarTipoPag)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnQuitarTipoPag)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.ChkActivar)
        Me.Controls.Add(Me.btnAgregarPresent)
        Me.Controls.Add(Me.btnQuitarPrest)
        Me.Controls.Add(Me.CboTipoPrecio)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dgCuotaLinea)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMantenimientoPromociones2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boleteo Masivo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GrpPromo.ResumeLayout(False)
        Me.GrpPromo.PerformLayout()
        Me.GrpVta.ResumeLayout(False)
        Me.GrpVta.PerformLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsfinanza1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Fields"
    Private INTFLAG_R As Integer

    Dim TablaTipoPrecioPromo As DataTable


#End Region

    Dim Ayuda As New ClsAyuda
    Dim CODPRES As String
    Dim zona As String

    Dim Sql As String

    Public CANTDOCI As Integer

    Dim NomTablaC, NomTablaD As String













    Private TABLE_PEDIDOS_FACTURAR As New DataTable
    Private CORRELATIVO As String
    Private NRODOCUMENTO As String
    Private CODZONA As String
    Private NomMaq As String
    Private STRNROPTOVTA As String
    Dim TABLE_CABECERA_PEDI As New DataTable
    Dim TABLE_DETALLE_PEDI As New DataTable
    '-------------------------------------------------------
    Private NROBOLETA As Integer
    Private NROFACTURA As Integer
    Private NRONOTA_PEDIDO As Integer
    Private CONTBOL As Integer
    Private CONTFACT As Integer
    Private CONTNTAPE As Integer
    Private ITEMFACT As Integer
    Private ITEMBOL As Integer
    Private ITEMNTAPED As Integer
    '-------------------------------------------------------
    Private TABLE_DETALLE_VERIFI As New DataTable
    Private NROMAXIMO As Integer
    Private NROMINIMO As Integer
    Public TablaARTI_FZAVENTA As New DataTable
    Private TABLE_CONSOLCLIE As New DataTable
    Dim GUIAD As String
    Dim GUIAC As String

    Dim SERIE As String
    Dim NRODOCSIN As String
    Dim NRODOCFINAL As String
    Dim LETRADOC As String
    Dim CLIE_DOCU As String



    Dim DNI As String
    Dim IGV As Double
    Dim EMAIL As String
    Dim SUBTOTAL As Double
    Dim PERCEP As Double
    Dim TIPO_IGV As String


    Dim listaP As New List(Of NuevaVentaDet)




#Region "Funciones Form"
    Private Sub cargadatos()
        CAyuda.CargarDataCombo(CboZona, "Nsp_Select_Zona  '" & codempresa & "'", "codzona", "deszona")

        CAyuda.CargarDataCombo(CboTipoPrecio, "nsp_sele_tipopre  '" & codempresa & "'", "codtipopre", "dstipopre")

        CAyuda.CargarDataCombo(cbTipoDoc, "SP_LISTAR_DOCUMENTOS  '" & codempresa & "'", "codigo", "Descripcion")


        CAyuda.CargarDataCombo(cbTipoPrecio, "NSP_Select_Listado_TipoPrecio '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cboAlmacen, "select_almaBM  '" & codempresa & "'", "codigo", "descripcion")


    End Sub

    Private Sub LimpiarData()
        txtProdVtaCod.Text = ""
        lbProductoVta.Text = ""
        CboPresentVta.SelectedValue = ""
        txtProdVtaCant.Text = "0"

        txtProdPromoCod.Text = ""
        lbProductoPromo.Text = ""
        CboPresentProm.SelectedValue = ""
        txtProfPromoCant.Text = "0"

        txtStock.Text = "0"

        If TablaTipoPrecioPromo.Rows.Count > 0 Then
            Me.TablaTipoPrecioPromo.Rows.Clear()
            Me.dgCuotaLinea.DataSource = TablaTipoPrecioPromo

        End If


        Me.dtpFecha.Value = Format(vFechaActual, "dd/MM/yyyy")

        Me.dtpFechaFin.Value = Format(vFechaActual, "dd/MM/yyyy")


    End Sub

#End Region


    Private Sub FrmMantenimientoPromociones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call cargadatos()

        TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPrecioXPromocion", codempresa, txtProdPromoCod.Text.Trim, txtCodPromo.Text).Tables(0)
        If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
            Me.dgCuotaLinea.DataSource = TablaTipoPrecioPromo
            FORMATO_GRID()
        End If

        btnBusqPromo.Enabled = False


        Me.dtpFecha.Value = Format(vFechaActual, "dd/MM/yyyy")

        Me.dtpFechaFin.Value = Format(vFechaActual, "dd/MM/yyyy")

        CAyuda.CargarDataCombo(cbTipoPago, "SelectTIPO_PAGO_FinancroxProc  '" & codempresa & "'", "CODTIPOPAGO", "DSTIPOPAGO")


    End Sub





    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnBusqPromo.Enabled = BUSCAR
        btnBusqProdVta.Enabled = BUSCAR
        Button2.Enabled = BUSCAR
    End Sub



    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        '  Me.btnBusqPromo.Enabled = Not GUARDAR
        Me.dtpFecha.Enabled = GUARDAR
        Me.dtpFechaFin.Enabled = GUARDAR
    End Sub

    Private Sub btnBusqPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqPromo.Click

        Dim FRMX As New frmgridarticulo
        FRMX.ShowDialog()
        If FRMX.DEVOLVER = False Then
            Exit Sub
        End If

        txtCodPromo.Text = FRMX.Grid1.Item(FRMX.Grid1.CurrentRowIndex, 0)
        txtDescripción.Text = FRMX.Grid1.Item(FRMX.Grid1.CurrentRowIndex, 1)



        Dim TB_MAXITEM As DataTable
        TB_MAXITEM = TmpListarDatos("sp_Busp_minpres '" & codempresa & "','" & txtCodPromo.Text & "'")
        CODPRES = TB_MAXITEM.Rows(0)(1).ToString
        lblMinPres.Text = TB_MAXITEM.Rows(0)(2).ToString
        lblMinPres2.Text = TB_MAXITEM.Rows(0)(2).ToString

        'TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPrecioXPromocion", codempresa, txtProdVtaCod.Text.Trim, txtCodPromo.Text).Tables(0)
        'If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
        '    Me.dgCuotaLinea.DataSource = TablaTipoPrecioPromo
        '    FORMATO_GRID()
        'End If


        'TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPagoXPromocion", txtCodPromo.Text).Tables(0)
        'If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
        '    Me.DataGrid1.DataSource = TablaTipoPrecioPromo
        '    FORMATO_GRID2()
        'End If




    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        LimpiarData()
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False)
        'Me.dtpFechaIni.Value = Now : dtpFechaFin.Value = Now
        INTFLAG_R = 0
        txtCodPromo.Focus()
        BTNCANCELAR.Enabled = True
        GrpPromo.Enabled = True
        GrpVta.Enabled = True
        CboZona.Enabled = True


        ChkActivar.Checked = False

        btnBusqPromo.Enabled = True

        cboAlmacen.Enabled = False

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click


        'Dim activado As Integer


        'If ChkActivar.Checked = True Then
        '    activado = 1
        'Else
        '    activado = 0
        'End If


        'Dim sql As String
        'Call formatotextbox(Me)
        'If Not VerificarDatos() Then
        '    Exit Sub
        'End If

        'If IsNothing(CboPresentVta.SelectedValue) = True Then
        '    MsgBox("El articulo de Venta no tiene Presentacion..", MsgBoxStyle.Exclamation, "")
        '    Exit Sub
        'End If
        'If IsNothing(CboPresentProm.SelectedValue) = True Then
        '    MsgBox("El articulo de Promocion no tiene Presentacion..", MsgBoxStyle.Exclamation, "")
        '    Exit Sub
        'End If

        'If INTFLAG_R = 0 Then
        '    sql = "NSP_INSERT_PROMOCIONES '" & codempresa & "','" & txtCodPromo.Text & "','" & txtDescripción.Text & "'," & Me.txtPrecio.Text & ",'" & Me.txtProdVtaCod.Text.Trim & "','" & CboPresentVta.SelectedValue & "'," & Me.txtProdVtaCant.Text & ",'" & Me.txtProdPromoCod.Text.Trim & "','" & CboPresentProm.SelectedValue & "'," & Me.txtProfPromoCant.Text.Trim & ", " & Me.txtStock.Text & ", '" & Me.dtpFechaIni.Value.ToShortDateString & "', '" & dtpFechaFin.Value.ToShortDateString & "','" & CboZona.SelectedValue & "'," & activado & ",'" & cbTipoPago.SelectedValue.ToString & "'"
        '    If TmpInsertDatos(sql) = True Then
        '        MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")


        '        Call BOTONES(True, False, False, False, True)
        '        Limpiatextbox(Me)

        '        Bloqueatextbox(Me)
        '        LimpiarData()
        '        GrpPromo.Enabled = False
        '        GrpVta.Enabled = False
        '        CboZona.Enabled = False
        '    End If
        'End If

        'If INTFLAG_R = 1 Then
        '    sql = "NSP_UPDATE_PROMOCIONES '" & codempresa & "','" & txtCodPromo.Text & "','" & txtDescripción.Text & "'," & Me.txtPrecio.Text & ",'" & Me.txtProdVtaCod.Text.Trim & "','" & CboPresentVta.SelectedValue & "'," & Me.txtProdVtaCant.Text & ",'" & Me.txtProdPromoCod.Text.Trim & "','" & CboPresentProm.SelectedValue & "'," & Me.txtProfPromoCant.Text.Trim & ", " & Me.txtStock.Text & ", '" & Me.dtpFechaIni.Value.ToShortDateString & "', '" & dtpFechaFin.Value.ToShortDateString & "' ,'" & CboZona.SelectedValue & "'," & activado & ",'" & cbTipoPago.SelectedValue.ToString & "'"
        '    If TmpInsertDatos(sql) = True Then
        '        MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

        '        Call BOTONES(True, False, False, False, True)
        '        Bloqueatextbox(Me)
        '        Call Limpiatextbox(Me)
        '        LimpiarData()
        '        GrpPromo.Enabled = False
        '        GrpVta.Enabled = False
        '        CboZona.Enabled = False

        '    End If
        'End If


        'BTNCANCELAR.Enabled = False






        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = dtpFecha.Value.Year
        MES = dtpFecha.Value.Month

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

        Dim TB_VALIDAR_FINMES As DataTable

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If


        If txtCodPromo.Text.Length = 0 Then
            MsgBox("falta codigo Prod..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If txtPrecio.Text.Length = 0 Then
            MsgBox("falta precio..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If TxtTotDocE.Text.Length = 0 Then
            MsgBox("falta Total Doc a Emitir ..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If



        TablaTipoPrecioPromo = CAyuda.ListarDatos("sp_almazon_zona", cboAlmacen.SelectedValue.ToString).Tables(0)
        If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
            zona = Me.TablaTipoPrecioPromo.Rows(0)(0)
        End If

        If INTFLAG_R = 0 Then

            Dim DOCP As String
            DOCP = TxtDoc2.Text

            Dim docinicial As Integer = CInt(TxtDoc2.Text)
            Dim CONTA As Integer = CInt(TxtDoc2.Text)
            For ContB As Integer = 0 To CInt(TxtTotDocE.Text) - 1

                TxtDoc2.Text = "00000000" & CONTA
                TxtDoc2.Text = Mid(TxtDoc2.Text, TxtDoc2.Text.Length - 7)


                Dim TABLE1 As New DataTable
                TABLE1 = TmpListarDatos("NSP_BUSCAR_FACTURACION  '" & codempresa & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "','" & cbTipoDoc.SelectedValue & "','" & rand & "'")
                If TABLE1.Rows.Count > 0 Then

                    'Dim DOC As String

                    'If VCdTipoDoc.Trim = "01" Then
                    '    DOC = "Factura"
                    'End If

                    'If VCdTipoDoc.Trim = "03" Then
                    '    DOC = "Boleta"
                    'End If

                    'If VCdTipoDoc.Trim = "06" Then
                    '    DOC = "Nota Pedido"
                    'End If

                    MsgBox("El Documento Boleta  " & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & " ya existe")
                    Exit Sub
                End If

                CONTA = CONTA + 1

            Next


            CONTA = docinicial
            For ContB As Integer = 0 To CInt(TxtTotDocE.Text) - 1

                TxtDoc2.Text = "00000000" & CONTA
                TxtDoc2.Text = Mid(TxtDoc2.Text, TxtDoc2.Text.Length - 7)

                OBTENERCORRELATIVO()

                Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADETBM", codempresa, txtCodPromo.Text, CODPRES, lblMinPres.Text, 1, CDbl(txtPrecio.Text), CDbl(txtPrecio.Text), VDescTotbas, CodUsuario, NROPTOVTA, VCorrelVta, "", cbTipoPrecio.SelectedValue, zona, CHECKPROMO)

                If GRABAEFECTIVOS((CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text)) = True Then
                    'CAyuda.Ejecutar("NSP_ACTUALIZAR_STOCK_FACT", codempresa.Trim, CInt(CTRLCANTIDAD.Text.Trim))
                End If
                CONTA = CONTA + 1
            Next


            Sql = "INS_BOLETEO_MASIVO '" & txtCodPromo.Text & "','" & txtDescripción.Text & "','" & TextBox1.Text & "','" & TxtCantDoc.Text & "','" & TxtTotDocE.Text & "','" & cbTipoPrecio.SelectedValue & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpFecha.Value), "dd/MM/yy") & "','" & txtPrecio.Text & "','" & cbTipoDoc.SelectedValue & "','" & txtcodclie.Text & "','" & txtruc.Text & "','" & txtcliente.Text & "','" & txtdireccion.Text & "','" & cbTipoPago.SelectedValue & "','" & TxtDoc1.Text & "','" & DOCP & "','" & TxtDoc11.Text & "','" & TxtDoc22.Text & "','" & cboAlmacen.SelectedValue & "'"
            If TmpInsertDatos(Sql) = True Then
            End If

        End If




        If INTFLAG_R = 1 Then

            Dim DOCP As String
            DOCP = TxtDoc2.Text

            Dim TB_MAXITEM As DataTable
            TB_MAXITEM = TmpListarDatos("sp_Busp_minpres '" & codempresa & "','" & txtCodPromo.Text & "'")
            CODPRES = TB_MAXITEM.Rows(0)(1).ToString
            lblMinPres.Text = TB_MAXITEM.Rows(0)(2).ToString
            lblMinPres2.Text = TB_MAXITEM.Rows(0)(2).ToString

            Dim docinicial As Integer = CInt(TxtDoc2.Text)
            Dim CONTA As Integer = CInt(TxtDoc2.Text)

            NomTablaC = "VENTC" & Format(DateAdd("m", 0, dtpFecha.Value), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", 0, dtpFecha.Value), "yyyyMM")

            For ContB As Integer = 0 To CInt(CANTDOCI) - 1

                TxtDoc2.Text = "00000000" & CONTA
                TxtDoc2.Text = Mid(TxtDoc2.Text, TxtDoc2.Text.Length - 7)

                Sql = "NSP_BORRAR_DOCUMEN_VENTACAB '" & codempresa & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "','" & cbTipoDoc.SelectedValue & "','" & NomTablaC & "','" & NomTablaD & "'"
                If TmpInsertDatos(Sql) = True Then

                End If

                CONTA = CONTA + 1

                Dim NRODOC As String
                NRODOC = (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text)

                If EMIELECTRONIC = True Then
                    If cbTipoDoc.SelectedValue.ToString.Trim = "01" Or cbTipoDoc.SelectedValue.ToString.Trim = "03" Then

                        Dim LETRADOC As String = ""

                        If cbTipoDoc.SelectedValue.ToString.Trim = "01" Then
                            LETRADOC = "F"
                        End If
                        If cbTipoDoc.SelectedValue.ToString.Trim = "03" Then
                            LETRADOC = "B"
                        End If
                        If cbTipoDoc.SelectedValue.ToString.Trim = "06" Then
                            LETRADOC = "F"
                        End If

                        Dim SERIE2 As String
                        Dim FormatNroDoc As String
                        FormatNroDoc = Format(CDbl(NRODOC), "0##-########")
                        Dim NUMSERIE As String
                        NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                        SERIE2 = LETRADOC + NUMSERIE

                        Dim NRODOCSIN As String
                        NRODOCSIN = CStr(Microsoft.VisualBasic.Right(NRODOC, 8))
                        Dim NRODOCFINAL As String
                        NRODOCFINAL = SERIE2 + "-" + NRODOCSIN

                        Dim gestordetipoNegocio As New GestorDeFacturacionElectronica
                        gestordetipoNegocio.AnularFE(SERIE2, NRODOCSIN, cbTipoDoc.SelectedValue.ToString)

                    End If
                End If
            Next


            CONTA = docinicial
            For ContB As Integer = 0 To CInt(TxtTotDocE.Text) - 1

                TxtDoc2.Text = "00000000" & CONTA
                TxtDoc2.Text = Mid(TxtDoc2.Text, TxtDoc2.Text.Length - 7)

                OBTENERCORRELATIVO()

                Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADETBM", codempresa, txtCodPromo.Text, CODPRES, lblMinPres.Text, 1, CDbl(txtPrecio.Text), CDbl(txtPrecio.Text), VDescTotbas, CodUsuario, NROPTOVTA, VCorrelVta, "", cbTipoPrecio.SelectedValue, zona, CHECKPROMO)

                If GRABAEFECTIVOS((CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text)) = True Then
                    'CAyuda.Ejecutar("NSP_ACTUALIZAR_STOCK_FACT", codempresa.Trim, CInt(CTRLCANTIDAD.Text.Trim))
                End If
                CONTA = CONTA + 1
            Next

            Sql = "UPD_BOLETEO_MASIVO '" & TxtcodMB.Text & "','" & txtCodPromo.Text & "','" & txtDescripción.Text & "','" & TextBox1.Text & "','" & TxtCantDoc.Text & "','" & TxtTotDocE.Text & "','" & cbTipoPrecio.SelectedValue & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpFecha.Value), "dd/MM/yy") & "','" & txtPrecio.Text & "','" & cbTipoDoc.SelectedValue & "','" & txtcodclie.Text & "','" & txtruc.Text & "','" & txtcliente.Text & "','" & txtdireccion.Text & "','" & cbTipoPago.SelectedValue & "','" & TxtDoc1.Text & "','" & DOCP & "','" & TxtDoc11.Text & "','" & TxtDoc22.Text & "','" & cboAlmacen.SelectedValue & "'"
            If TmpInsertDatos(Sql) = True Then

            End If

        End If


        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''FACTURACION ELECTRONICA ENVIO BASE''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''

        If EMIELECTRONIC = True Then

            Dim fecha As String
            Dim Totalbas As Double
            Dim CODTIPOPAGO As String
            Dim CodVend As String

            Dim Table_VC As New DataTable
            Table_VC = TmpListarDatos("SP_DOCUMENTO_FALTAN_ENVIAR_BM   '" & codempresa & "'")

            If Table_VC.Rows.Count > 0 Then
                For Y As Integer = 0 To Table_VC.Rows.Count - 1

                    TipoDoc = Table_VC.Rows(Y)("CODTIPODOC").ToString()
                    VNroDoc = Table_VC.Rows(Y)("NRODOCU").ToString()
                    IGV = CDbl(Table_VC.Rows(Y)("IGVBAS").ToString())
                    fecha = Table_VC.Rows(Y)("FECDOCUM").ToString()
                    VRuc = Table_VC.Rows(Y)("RUCCLIENTE").ToString()
                    VCodCliente = Table_VC.Rows(Y)("CODCLIENTE").ToString()
                    VDescliente = Table_VC.Rows(Y)("DESCLIENTE").ToString()
                    Totalbas = CDbl(Table_VC.Rows(Y)("TOTBAS").ToString())
                    CODTIPOPAGO = CDbl(Table_VC.Rows(Y)("CODTIPOPAGO").ToString())
                    VDireccion = Table_VC.Rows(Y)("direccion").ToString()
                    IGV = CDbl(Table_VC.Rows(Y)("IGVBAS").ToString())
                    SUBTOTAL = CDbl(Table_VC.Rows(Y)("SUBTOTBAS").ToString())
                    PERCEP = CDbl(Table_VC.Rows(Y)("IPERCEP").ToString())
                    EMAIL = Table_VC.Rows(Y)("EMAIL").ToString()
                    DNI = Table_VC.Rows(Y)("DNI").ToString()
                    CodVend = Table_VC.Rows(Y)("CODVEND").ToString()



                    Dim StrSql As String
                    StrSql = "SELECT VENTADET.ITEM,VENTADET.CODARTI, VENTADET.DESARTI, VENTADET.PRECIO, " &
                                 "  VENTADET.CANTIDAD,  VENTADET.SUBTOTBAS, '01' AS TIPOPRE," &
                                       "  VENTADET.TOTBAS, VENTADET.IGVBAS,(VENTADET.SUBTOTBAS/VENTADET.CANTIDAD) AS PRECSINIGV," &
                                       "   VENTADET.MONTODESCBAS ,VENTADET.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC " &
                                 " FROM ARTICULO INNER JOIN VENTADET ON ARTICULO.CODARTI = VENTADET.CODARTI" &
                                  " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                              "  INNER JOIN PRESENTACION ON PRESENTACION.codpres = VENTADET.CODPRES" &
                            " WHERE VENTADET.NRODOCU = " & CInt(VNroDoc) & " AND VENTADET.CODTIPODOC  = " & CStr(TipoDoc) & " ORDER BY VENTADET.ITEM "

                    Dim Tabla_Tmp As DataTable
                    Tabla_Tmp = TmpListarDatos(StrSql)

                    listaP.Clear()
                    If Tabla_Tmp.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp.Rows.Count - 1
                            Dim o As New NuevaVentaDet
                            o.CODARTI = Tabla_Tmp.Rows(x)("CODARTI")
                            o.DESARTI = Tabla_Tmp.Rows(x)("DESARTI")
                            o.CODFACELEC = Tabla_Tmp.Rows(x)("CODFACELEC")
                            o.PRECIO = Tabla_Tmp.Rows(x)("PRECIO")
                            o.MONTODESCBAS = Tabla_Tmp.Rows(x)("MONTODESCBAS")
                            o.CANTIDAD = Tabla_Tmp.Rows(x)("CANTIDAD")
                            o.IGVBAS = Tabla_Tmp.Rows(x)("IGVBAS")
                            o.TIPO_IGV = IIf(CDbl(Tabla_Tmp.Rows(x)("IGVBAS")) <> 0, "IGV", "INA")
                            listaP.Add(o)
                        Next
                    End If


                    If TipoDoc.Trim = "01" Or TipoDoc.Trim = "03" Then



                        If IGV > 0 Then
                            TIPO_IGV = "SI"
                        Else
                            TIPO_IGV = "NO"
                        End If

                        'Dim Table_VC2 As New DataTable
                        'Table_VC2 = TmpListarDatos("SP_SELECT_EMAIL_CLIENTE   '" & CStr(TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString) & "','" & CStr(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT").ToString) & "'")
                        'If Table_VC2.Rows.Count > 0 Then
                        '    EMAIL = Table_VC2.Rows(0)("EMAIL").ToString()
                        '    DNI = Table_VC2.Rows(0)("DNI").ToString()
                        If VCodCliente = "888" Then
                            DNI = "88888888"
                        End If
                        'End If



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



                        If NOSERIE = SERIE Then


                        Else
                            Try

                                Dim gestordefacturacionelectronica As IGestorDeFacturacionElectronica = New GestorDeFacturacionElectronica()
                                Dim nuevohdocumento As New NuevaHdocumento

                                nuevohdocumento.codi_cab = 1
                                nuevohdocumento.esta_pod = 1
                                nuevohdocumento.codi_caja = CStr(NROPTOVTA)
                                nuevohdocumento.comp = TipoDoc
                                nuevohdocumento.serie = SERIE
                                nuevohdocumento.nume = NRODOCSIN
                                nuevohdocumento.fecha = Format(CDate(dtpFecha.Value), "dd/MM/yyyy")
                                nuevohdocumento.codi_vend = CodVend
                                nuevohdocumento.clie_docu = CLIE_DOCU
                                nuevohdocumento.clie_nomb = VDescliente
                                nuevohdocumento.clie_dire = VDireccion
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
                                nuevohdocumento.Total = Totalbas
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
                                        nuevoddocumento.igv = listaP.Item(x).IGVBAS
                                        nuevoddocumento.percepcion = PERCEP
                                        nuevoddocumento.codi_cab = CODCAB
                                        nuevoddocumento.tipo_igv = listaP.Item(x).TIPO_IGV
                                        nuevoddocumento.obse = "AAAAA"
                                        nuevoddocumento.codigo_sunat = " "
                                        nuevoddocumento.codigo_gsi = " "
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
                Next
            End If
        End If










        Call BOTONES(True, False, False, False, True)
        Limpiatextbox(Me)

        Bloqueatextbox(Me)
        LimpiarData()
        GrpPromo.Enabled = False
        GrpVta.Enabled = False
        CboZona.Enabled = False

        btnBusqPromo.Enabled = False

    End Sub
    Dim rand As Integer

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Sub OBTENERCORRELATIVO()
        Dim SQL As String
        Dim DS As New DataSet
        SQL = "ObtenerCorrelativoProcUtil '" & CodUsuario & "'"
        DS = TmpListarDataset(SQL)
        VCorrelVta = DS.Tables(0).Rows(0)(0)
    End Sub



    Private Function GRABAEFECTIVOS(ByVal NRODOCUMENTO As String) As Boolean
        Dim AFEC As Integer
        Try
            'TmpInsertDatos("sp_grabadocumento  '" & CStr(VIE.txtnroguias.Text) & "','" & CStr(VIE.txtnotapesada.Text) & "','" & CStr(VIE.CHKIGV.Checked) & "','" & CStr(fact_editnumero) & "','" & CInt(FACT_NUMEROTRANSACCION) & "','" & CStr(FACT_clieprincipal) & "','" & CODTIPOPAGO.Trim & "','" & CStr(VCdTipoDoc) & "','" & CStr(VNroDoc) & "','" & CStr(FACT_CDMONEDA) & "','" & CDec(LBLcambio.Text) & "','" & CStr(FACT_codvendedor) & "','" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & CDec(IIf(CDMONBASE = FACT_CDMONEDA, VIE.CTRLTOTAL.CtlText, VIE.CTRLTOTAL.CtlText * LBLcambio.Text)) & "','" & CDec(FACT_pordescuento) & "','" & CDec(IIf(CDMONBASE = FACT_CDMONEDA, ctrlvuelto.CtlText, ctrlvuelto.CtlText * LBLcambio.Text)) & "','" & CDec(ctrlefectivobas.CtlText) & "' ,'" & CDec(ctrlefectivoextr.CtlText) & "','" & CStr(FACT_codcliente) & "','" & CStr(FACT_RUCCLIENTE) & "','" & CStr(FACT_DESCLIENTE) & "','" & CStr(FACT_DIRCLIENTE) & "','" & CStr(CodUsuario) & "','" & CStr(CodEmpresa) & "' ,'" & CStr(FACT_CDMONEDA) & "','" & CStr(NROPTOVTA) & "','" & CInt(VCorrelVta) & "' ")


            Dim cn2 As New SqlConnection(STRCN)
            If cn2.State = ConnectionState.Open Then
                cn2.Close()
            End If
            cn2.Open()
            Dim cmd2 As New SqlCommand("Nsp_grabadocumento_BM", cn2)
            cmd2.CommandType = CommandType.StoredProcedure

            cmd2.Parameters.AddWithValue("@NRODEGUIAS", CStr("")).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@NPESADA", CStr("")).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@Eigv", CStr("")).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@actualizocorrelativo", CStr(fact_editnumero)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@NUMEROTRANS", CInt(FACT_NUMEROTRANSACCION)).SqlDbType = SqlDbType.Int
            cmd2.Parameters.AddWithValue("@CODDEP", CStr(VClieDep)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CODTIPOPAGO", cbTipoPago.SelectedValue).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CODTIPODOC", cbTipoDoc.SelectedValue).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@NRODOCU", CStr(NRODOCUMENTO)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@codmon", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CAMBIO", 3.4).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@codvend", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@FECDOCUM", Me.dtpFecha.Value.ToShortDateString).SqlDbType = SqlDbType.DateTime
            cmd2.Parameters.AddWithValue("@TOTBAS", txtPrecio.Text).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@PORCENDESC1", CDec(VDescTotbas)).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@TOTVUELTOBAS", CDec("0.00")).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@TOTCASHBAS", CDec("0.00")).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@TOTCASHEXT", CDec("0.00")).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@codcliente", CStr(txtcodclie.Text)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@RUCCLIENTE", CStr(txtruc.Text)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@DESCLIENTE", CStr(txtcliente.Text)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@DIRCLIENTE", CStr(txtdireccion.Text)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@usuario", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CODEMPRESA", CStr(codempresa)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@MONEDABASE", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@NROPTOVTA", CStr(NROPTOVTA)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@CORRELATIVO", CInt(VCorrelVta)).SqlDbType = SqlDbType.Int
            cmd2.Parameters.AddWithValue("@POSTPAGO", CBool(True)).SqlDbType = SqlDbType.Bit
            cmd2.Parameters.AddWithValue("@Hora", "BM").SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@zona", zona).SqlDbType = SqlDbType.VarChar


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



    End Function





    Public Function VerificarDatos() As Boolean
        Dim Obs1 As String = String.Empty, obs2 As String = String.Empty, obs3 As String = String.Empty, obs4 As String = String.Empty, obs5 As String = String.Empty

        If INTFLAG_R = 0 Then
            If Me.txtCodPromo.Text.Trim.Length = 0 Then
                Obs1 = vbCrLf + "-   Ingrese el código."
            Else
                Dim TablaConsulta As New DataTable
                TablaConsulta = CAyuda.ListarDatos("NSP_LISTAR_PROMOCIONES", codempresa, Me.txtCodPromo.Text.Trim).Tables(0)
                If TablaConsulta.Rows.Count > 0 Then
                    Obs1 = vbCrLf + "-   Este código ya ha sido ingresado."
                End If
            End If
        End If
        If Me.txtDescripción.Text.Trim.Length = 0 Then
            obs2 = vbCrLf + "-   Ingrese la Descripción."
        End If
        If Obs1 <> String.Empty Or obs2 <> String.Empty Then
            MsgBox("Para grabar corrija las siguientes observaciones. :" + vbCrLf + Obs1 + obs2)
            VerificarDatos = False
        Else
            VerificarDatos = True
        End If
    End Function

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        'txtCodPromo.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        INTFLAG_R = 1
        'txtDescripción.Focus()
        'txtDescripción.SelectAll()
        'BTNCANCELAR.Enabled = True
        'GrpPromo.Enabled = True
        'GrpVta.Enabled = True
        'CboZona.Enabled = True

        dtpFecha.Enabled = True
        dtpFechaFin.Enabled = True

    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        If INTFLAG_R = 0 Then
            Call Limpiatextbox(Me)
            LimpiarData()

            Call BOTONES(True, False, False, False, True)
        Else
            Call BOTONES(True, False, False, False, True)
        End If
        GrpPromo.Enabled = False
        GrpVta.Enabled = False
        CboZona.Enabled = False
        Call Bloqueatextbox(Me)
        BTNCANCELAR.Enabled = False
    End Sub

    Private Sub btnBusqProdVta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqProdVta.Click

        Dim FrmArt As New FrmBuscArticuloxZona
        FrmArt.CODZONA = IIf(IsNothing(CboZona.SelectedValue), "", CboZona.SelectedValue)
        FrmArt.DESZONA = IIf(IsNothing(CboZona.Text), "", CboZona.Text)
        FrmArt.ShowDialog()
        If FrmArt.DEVOLVER = False Then
            Exit Sub
        End If
        txtProdVtaCod.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 0)
        lbProductoVta.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 1)
        If txtProdVtaCod.Text.Trim.Length > 0 Then
            CboPresentVta.DataSource = TmpListarDatos("SelectPRECIART_Presentxproc2 '" & codempresa & "','" & txtProdVtaCod.Text.Trim & "'")
            CboPresentVta.DisplayMember = "DESPRES"
            CboPresentVta.ValueMember = "CODPRES"
        End If
        Me.txtProdVtaCant.Focus()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim FrmArt As New FrmBuscArticuloxZona2
        FrmArt.CODZONA = IIf(IsNothing(CboZona.SelectedValue), "", CboZona.SelectedValue)
        FrmArt.DESZONA = IIf(IsNothing(CboZona.Text), "", CboZona.Text)
        FrmArt.ShowDialog()
        If FrmArt.DEVOLVER = False Then
            Exit Sub
        End If
        txtProdPromoCod.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 0)
        lbProductoPromo.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 1)


        If txtProdPromoCod.Text.Trim.Length > 0 Then
            CboPresentProm.DataSource = TmpListarDatos("SelectPRECIART_Presentxproc2  '" & codempresa & "','" & txtProdPromoCod.Text.Trim & "'")
            CboPresentProm.DisplayMember = "DESPRES"
            CboPresentProm.ValueMember = "CODPRES"
            CboPresentProm.Focus()
        End If

        txtProfPromoCant.Focus()


    End Sub

#Region "RESTRICCIONES-KEYPRESS"

    Private Sub CajaTexto_SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress, txtPrecio.KeyPress, txtProdVtaCant.KeyPress, txtProfPromoCant.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Then
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

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        'NSP_DELETE_PROMOCIONES
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el Registro ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then


            Dim docinicial As Integer = CInt(TxtDoc2.Text)
            Dim CONTA As Integer = CInt(TxtDoc2.Text)
            For ContB As Integer = 0 To CInt(TxtTotDocE.Text) - 1

                TxtDoc2.Text = "0000000" & CONTA
                TxtDoc2.Text = Mid(TxtDoc2.Text, TxtDoc2.Text.Length - 6)

                Sql = "NSP_BORRAR_DOCUMEN_VENTACAB '" & codempresa & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "','" & cbTipoDoc.SelectedValue & "'"
                If TmpInsertDatos(Sql) = True Then

                End If

                CONTA = CONTA + 1

            Next


            Sql = "DELETE_BOLETEO_MASIVO '" & TxtcodMB.Text & "'"
            If TmpInsertDatos(Sql) = True Then
            End If


            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)
            Call Limpiatextbox(Me)
            LimpiarData()


            GrpPromo.Enabled = False
            GrpVta.Enabled = False
            CboZona.Enabled = False
        End If
    End Sub





    Private Sub CboPresentVta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPresentVta.SelectedIndexChanged

    End Sub

    Private Sub CboPresentVta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboPresentVta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProdVtaCant.Focus()
        End If
    End Sub

    Private Sub CboPresentProm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPresentProm.SelectedIndexChanged

    End Sub

    Private Sub CboPresentProm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboPresentProm.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProfPromoCant.Focus()
        End If
    End Sub

    Private Sub txtProdVtaCod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdVtaCod.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtProdVtaCod.Text.Trim <> "" Then
                Dim TAB_ARTI As New DataTable
                TAB_ARTI = TmpListarDatos("SelectARTICULOxZonaProc  '" & codempresa & "','" & CboZona.SelectedValue & "' ,'" & txtProdVtaCod.Text.Trim & "'")
                If TAB_ARTI.Rows.Count > 0 Then
                    lbProductoVta.Text = TAB_ARTI.Rows(0)("DESARTI")
                    CboPresentVta.DataSource = TmpListarDatos("SelectPRECIART_Presentxproc2 '" & codempresa & "','" & txtProdVtaCod.Text.Trim & "'")
                    CboPresentVta.DisplayMember = "DESPRES"
                    CboPresentVta.ValueMember = "CODPRES"
                    Me.CboPresentVta.Focus()
                Else
                    MsgBox("No se encontro el articulo porque  no pertenece a la Zona asignada")
                    txtProdVtaCod.Focus()
                End If

            End If

        End If
    End Sub

    Private Sub txtProdPromoCod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdPromoCod.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.KeyCode = Keys.Enter Then
                If txtProdPromoCod.Text.Trim <> "" Then
                    Dim TAB_ARTI As New DataTable
                    TAB_ARTI = TmpListarDatos("SelectARTICULOxZonaProc  '" & codempresa & "','" & CboZona.SelectedValue & "' ,'" & txtProdPromoCod.Text.Trim & "'")
                    If TAB_ARTI.Rows.Count > 0 Then
                        lbProductoPromo.Text = TAB_ARTI.Rows(0)("DESARTI")
                        CboPresentProm.DataSource = TmpListarDatos("SelectPRECIART_Presentxproc2 '" & codempresa & "','" & txtProdPromoCod.Text.Trim & "'")
                        CboPresentProm.DisplayMember = "DESPRES"
                        CboPresentProm.ValueMember = "CODPRES"
                        CboPresentProm.Focus()
                    Else
                        MsgBox("No se encontro el articulo porque  no pertenece a la Zona asignada")
                        txtProdPromoCod.Focus()
                    End If

                End If

            End If


        End If
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()

    End Sub

    Private Sub txtProdVtaCod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdVtaCod.Click
        txtProdVtaCod.Text = ""
        lbProductoVta.Text = ""
        txtProdVtaCant.Text = "0.00"


    End Sub

    Private Sub txtProdPromoCod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProdPromoCod.Click
        txtProdPromoCod.Text = ""
        lbProductoPromo.Text = ""
        txtProfPromoCant.Text = "0.00"



    End Sub

    Private Sub txtProdVtaCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdVtaCod.TextChanged
        If txtProdPromoCod.Text.Trim = "" And txtProdVtaCod.Text.Trim = "" Then
            CboZona.Enabled = True
        Else
            CboZona.Enabled = False
        End If

    End Sub

    Private Sub txtProdPromoCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdPromoCod.TextChanged
        If txtProdPromoCod.Text.Trim = "" And txtProdVtaCod.Text.Trim = "" Then
            CboZona.Enabled = True
        Else
            CboZona.Enabled = False
        End If

    End Sub

    Private Sub txtCodPromo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodPromo.TextChanged

    End Sub

    Private Sub txtCodPromo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPromo.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtDescripción.Focus()
        End If

    End Sub

    Private Sub txtDescripción_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripción.TextChanged

    End Sub

    Private Sub txtDescripción_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripción.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtPrecio.Focus()
        End If

    End Sub

    Private Sub txtPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub dtpFechaIni_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged

    End Sub

    Private Sub dtpFechaIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            dtpFechaFin.Focus()
        End If

    End Sub

    Private Sub txtPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecio.KeyDown

        If e.KeyCode = Keys.Enter Then
            dtpFecha.Focus()
        End If

    End Sub

    Private Sub dtpFechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaFin.ValueChanged

    End Sub

    Private Sub dtpFechaFin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaFin.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            CboZona.Focus()
        End If
    End Sub

    Private Sub CboZona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboZona.SelectedIndexChanged

    End Sub

    Private Sub CboZona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboZona.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtProdVtaCod.Focus()
        End If
    End Sub

    Private Sub txtProdVtaCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProdVtaCod.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            btnBusqProdVta_Click(sender, e)
        End If

    End Sub

    Private Sub txtProdVtaCant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdVtaCant.TextChanged

    End Sub

    Private Sub txtProdVtaCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProdVtaCant.KeyDown


        If e.KeyCode = Keys.Enter Then
            txtProdPromoCod.Focus()
        End If

    End Sub

    Private Sub txtProdPromoCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProdPromoCod.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            btnBusqProdVta_Click(sender, e)
        End If

    End Sub

    Private Sub txtProfPromoCant_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProfPromoCant.TextChanged

    End Sub

    Private Sub txtProfPromoCant_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProfPromoCant.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtStock.Focus()
        End If

    End Sub

    Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.TextChanged

    End Sub

    Private Sub txtStock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStock.KeyDown


        If e.KeyCode = Keys.Enter Then
            BTNGUARDAR.Focus()
        End If

    End Sub

    Private Sub btnAgregarPresent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPresent.Click
        If txtCodPromo.Text.Trim = "" Then
            MsgBox("Falta el Codigo ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        If Me.txtProdPromoCod.Text.Trim.Length > 0 Then
            CAyuda.Ejecutar("NSP_INSERT_TipoPrecioXPromocion", txtCodPromo.Text, txtProdVtaCod.Text.Trim, CboTipoPrecio.SelectedValue, CboTipoPrecio.Text, txtCodPromo.Text)
            TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPrecioXPromocion", codempresa, txtProdVtaCod.Text.Trim, txtCodPromo.Text).Tables(0)
            If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
                Me.dgCuotaLinea.DataSource = TablaTipoPrecioPromo
                FORMATO_GRID()
            End If
        End If

    End Sub


    Public Sub FORMATO_GRID()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TablaTipoPrecioPromo.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODTIPOPRE"
            .HeaderText = "CODTIPOPRE"
            .Width = 100
        End With


        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "DSTIPOPRE"
            .HeaderText = "DSTIPOPRE"
            .Width = 100
        End With


        dgCuotaLinea.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2})
        dgCuotaLinea.TableStyles.Add(TableStyle1)

    End Sub


    Public Sub FORMATO_GRID2()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TablaTipoPrecioPromo.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODPROMO"
            .HeaderText = "CODPROMO"
            .Width = 100
        End With


        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODTIPOPAGO"
            .HeaderText = "CODTIPOPAGO"
            .Width = 100
        End With


        DataGrid1.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2})
        DataGrid1.TableStyles.Add(TableStyle1)

    End Sub


    Private Sub btnQuitarPrest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarPrest.Click



        If txtCodPromo.Text.Trim = "" Then
            MsgBox("Falta el Codigo..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TablaTipoPrecioPromo.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el tipo precio [ " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 1).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_TipoPrecioXPromocion", codempresa, txtProdVtaCod.Text.Trim.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 0).ToString.Trim, txtCodPromo.Text)

            TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPrecioXPromocion", codempresa, txtProdVtaCod.Text.Trim, txtCodPromo.Text).Tables(0)
            If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
                Me.dgCuotaLinea.DataSource = TablaTipoPrecioPromo
                FORMATO_GRID()
            End If


        End If


    End Sub

    Private Sub btnAgregarTipoPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTipoPag.Click

        If txtCodPromo.Text.Trim = "" Then
            MsgBox("Falta el Codigo ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        If Me.txtProdPromoCod.Text.Trim.Length > 0 Then
            CAyuda.Ejecutar("NSP_INSERT_TipoPagoXPromocion", txtCodPromo.Text, cbTipoPago.SelectedValue)
            TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPagoXPromocion", txtCodPromo.Text).Tables(0)
            If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
                Me.DataGrid1.DataSource = TablaTipoPrecioPromo
                FORMATO_GRID2()
            End If
        End If



    End Sub

    Private Sub btnQuitarTipoPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarTipoPag.Click



        If txtCodPromo.Text.Trim = "" Then
            MsgBox("Falta el Codigo..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TablaTipoPrecioPromo.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el tipo pago [ " & Me.DataGrid1(Me.DataGrid1.CurrentRowIndex, 1).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_TipoPagoXPromocion", txtCodPromo.Text, Me.DataGrid1(Me.DataGrid1.CurrentRowIndex, 1).ToString.Trim)

            TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPagoXPromocion", txtCodPromo.Text).Tables(0)
            Me.DataGrid1.DataSource = TablaTipoPrecioPromo
            FORMATO_GRID2()



        End If

    End Sub

    Private Sub btnBusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusCli.Click
        Dim FrmCli As New FrmBuscarClieDepen
        FrmCli.ShowDialog()
        If FrmCli.DEVOLVER = False Then
            Exit Sub
        End If
        txtcodclie.Text = FrmCli.GridCli.Item(FrmCli.GridCli.CurrentRowIndex, 0)

        Dim TAB_CLIE As New DataTable
        TAB_CLIE = TmpListarDatos("SP_SelectClienteFact   '" & codempresa & "','" & Me.txtcodclie.Text.Trim & "', '" & VRuc & "','" & 0 & "'")
        If TAB_CLIE.Rows.Count > 0 Then
            txtcodclie.Text = TAB_CLIE.Rows(0)("CODCLIENTE").ToString.Trim
            txtcliente.Text = TAB_CLIE.Rows(0)("DATOADJUNTO").ToString.Trim
            txtdireccion.Text = TAB_CLIE.Rows(0)("DIRECCION").ToString.Trim
            txtruc.Text = TAB_CLIE.Rows(0)("RUC").ToString.Trim


            VRuc = TAB_CLIE.Rows(0)("RUC").ToString.Trim
            VClieDep = TAB_CLIE.Rows(0)("CODDEP").ToString.Trim
            '   CboPagador.SelectedValue = TAB_CLIE.Rows(0)("CODDEP").ToString.Trim


        End If


    End Sub




    Private Sub TxtDoc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDoc1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDoc1.Text = "000" & TxtDoc1.Text.Trim
            TxtDoc1.Text = Mid(TxtDoc1.Text, TxtDoc1.Text.Length - 2)
            TxtDoc2.Focus()
        End If
    End Sub

    Private Sub TxtDoc1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc1.TextChanged

    End Sub

    Private Sub TxtDoc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDoc2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDoc2.Text = "00000000" & TxtDoc2.Text.Trim
            TxtDoc2.Text = Mid(TxtDoc2.Text, TxtDoc2.Text.Length - 7)

        End If
    End Sub

    Private Sub TxtDoc2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc2.TextChanged

    End Sub

    Private Sub TxtDoc11_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDoc11.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDoc11.Text = "000" & TxtDoc11.Text.Trim
            TxtDoc11.Text = Mid(TxtDoc11.Text, TxtDoc11.Text.Length - 2)
            TxtDoc22.Focus()
        End If
    End Sub

    Private Sub TxtDoc11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc11.TextChanged

    End Sub

    Private Sub TxtDoc22_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDoc22.KeyDown

        If e.KeyCode = Keys.Enter Then

            If TxtTotDocE.Text.Length = 0 Then
                TxtCantDoc.Text = 0
            End If


            TxtDoc22.Text = CInt(TxtDoc2.Text) + CInt(TxtTotDocE.Text) - 1
            TxtDoc22.Text = "00000000" & CInt(TxtDoc22.Text.Trim)
            TxtDoc22.Text = Mid(TxtDoc22.Text, TxtDoc22.Text.Length - 7)
        End If

    End Sub

    Private Sub TxtDoc22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc22.TextChanged

    End Sub

    Private Sub ChkActivar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkActivar.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim FRMX As New FRM_GRIDBM
        FRMX.vie = Me
        FRMX.bol = True
        FRMX.ShowDialog()


        Call BOTONES(True, False, True, True, True)

    End Sub

    Private Sub cbTipoPrecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoPrecio.SelectedIndexChanged

    End Sub
End Class
