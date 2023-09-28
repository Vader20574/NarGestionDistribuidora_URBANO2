Public Class FrmMantenimientoPromociones_SubCatT
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
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents cbosublinea As System.Windows.Forms.ComboBox
    Friend WithEvents cbolinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ChkActivar As System.Windows.Forms.CheckBox
    Friend WithEvents cbTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GrpVta As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoPromociones_SubCatT))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
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
        Me.cbosublinea = New System.Windows.Forms.ComboBox
        Me.cbolinea = New System.Windows.Forms.ComboBox
        Me.CboPresentVta = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtProdVtaCant = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.btnBusqPromo = New System.Windows.Forms.Button
        Me.txtPrecio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDescripción = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodPromo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBusqProdVta = New System.Windows.Forms.Button
        Me.txtProdVtaCod = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbProductoVta = New System.Windows.Forms.Label
        Me.dgCuotaLinea = New System.Windows.Forms.DataGrid
        Me.CboTipoPrecio = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnAgregarPresent = New System.Windows.Forms.Button
        Me.btnQuitarPrest = New System.Windows.Forms.Button
        Me.ChkActivar = New System.Windows.Forms.CheckBox
        Me.cbTipoPago = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GrpPromo.SuspendLayout()
        Me.GrpVta.SuspendLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(474, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 202)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(8, 136)
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
        Me.BTNCERRAR.Location = New System.Drawing.Point(8, 166)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Cerrar"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(8, 76)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNMODIFICAR.TabIndex = 3
        Me.BTNMODIFICAR.Text = "&Modificar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(8, 106)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Eliminar"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(8, 16)
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
        Me.BTNGUARDAR.Location = New System.Drawing.Point(8, 46)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(94, 29)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox2.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox2.Controls.Add(Me.btnBusqPromo)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtDescripción)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCodPromo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 419)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CboZona)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtStock)
        Me.GroupBox5.Controls.Add(Me.GrpPromo)
        Me.GroupBox5.Controls.Add(Me.GrpVta)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 124)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(458, 310)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle de Promocion"
        '
        'CboZona
        '
        Me.CboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.txtStock.Location = New System.Drawing.Point(194, 266)
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
        Me.GrpPromo.Location = New System.Drawing.Point(10, 169)
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
        Me.GrpVta.Controls.Add(Me.cbosublinea)
        Me.GrpVta.Controls.Add(Me.cbolinea)
        Me.GrpVta.Controls.Add(Me.CboPresentVta)
        Me.GrpVta.Controls.Add(Me.Label6)
        Me.GrpVta.Controls.Add(Me.Label15)
        Me.GrpVta.Controls.Add(Me.txtProdVtaCant)
        Me.GrpVta.Controls.Add(Me.Label12)
        Me.GrpVta.Controls.Add(Me.Label16)
        Me.GrpVta.Enabled = False
        Me.GrpVta.Location = New System.Drawing.Point(10, 44)
        Me.GrpVta.Name = "GrpVta"
        Me.GrpVta.Size = New System.Drawing.Size(442, 115)
        Me.GrpVta.TabIndex = 12
        Me.GrpVta.TabStop = False
        Me.GrpVta.Text = "Producto Venta"
        '
        'cbosublinea
        '
        Me.cbosublinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosublinea.ItemHeight = 13
        Me.cbosublinea.Location = New System.Drawing.Point(80, 38)
        Me.cbosublinea.Name = "cbosublinea"
        Me.cbosublinea.Size = New System.Drawing.Size(282, 21)
        Me.cbosublinea.TabIndex = 27
        '
        'cbolinea
        '
        Me.cbolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolinea.ItemHeight = 13
        Me.cbolinea.Location = New System.Drawing.Point(80, 12)
        Me.cbolinea.Name = "cbolinea"
        Me.cbolinea.Size = New System.Drawing.Size(282, 21)
        Me.cbolinea.TabIndex = 24
        '
        'CboPresentVta
        '
        Me.CboPresentVta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPresentVta.Location = New System.Drawing.Point(80, 64)
        Me.CboPresentVta.Name = "CboPresentVta"
        Me.CboPresentVta.Size = New System.Drawing.Size(236, 21)
        Me.CboPresentVta.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cantidad :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(20, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Categoria :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProdVtaCant
        '
        Me.txtProdVtaCant.Location = New System.Drawing.Point(80, 88)
        Me.txtProdVtaCant.Name = "txtProdVtaCant"
        Me.txtProdVtaCant.Size = New System.Drawing.Size(68, 20)
        Me.txtProdVtaCant.TabIndex = 11
        Me.txtProdVtaCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(0, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Presentacion :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(-2, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Sub Categoria :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "STOCK PROM. :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(190, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Fec.Fin"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Fec.Inicio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(260, 94)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaFin.TabIndex = 18
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(88, 94)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaIni.TabIndex = 17
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
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(86, 68)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(92, 20)
        Me.txtPrecio.TabIndex = 9
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(18, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.txtCodPromo.Location = New System.Drawing.Point(88, 22)
        Me.txtCodPromo.MaxLength = 12
        Me.txtCodPromo.Name = "txtCodPromo"
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
        'btnBusqProdVta
        '
        Me.btnBusqProdVta.ImageIndex = 5
        Me.btnBusqProdVta.ImageList = Me.ImageList1
        Me.btnBusqProdVta.Location = New System.Drawing.Point(713, 100)
        Me.btnBusqProdVta.Name = "btnBusqProdVta"
        Me.btnBusqProdVta.Size = New System.Drawing.Size(38, 24)
        Me.btnBusqProdVta.TabIndex = 4
        '
        'txtProdVtaCod
        '
        Me.txtProdVtaCod.Location = New System.Drawing.Point(647, 100)
        Me.txtProdVtaCod.Name = "txtProdVtaCod"
        Me.txtProdVtaCod.Size = New System.Drawing.Size(64, 20)
        Me.txtProdVtaCod.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(589, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Producto :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbProductoVta
        '
        Me.lbProductoVta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbProductoVta.Location = New System.Drawing.Point(751, 100)
        Me.lbProductoVta.Name = "lbProductoVta"
        Me.lbProductoVta.Size = New System.Drawing.Size(250, 22)
        Me.lbProductoVta.TabIndex = 7
        '
        'dgCuotaLinea
        '
        Me.dgCuotaLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCuotaLinea.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgCuotaLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCuotaLinea.DataMember = ""
        Me.dgCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotaLinea.Location = New System.Drawing.Point(90, 470)
        Me.dgCuotaLinea.Name = "dgCuotaLinea"
        Me.dgCuotaLinea.ReadOnly = True
        Me.dgCuotaLinea.Size = New System.Drawing.Size(491, 167)
        Me.dgCuotaLinea.TabIndex = 19
        '
        'CboTipoPrecio
        '
        Me.CboTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPrecio.ItemHeight = 13
        Me.CboTipoPrecio.Location = New System.Drawing.Point(166, 443)
        Me.CboTipoPrecio.Name = "CboTipoPrecio"
        Me.CboTipoPrecio.Size = New System.Drawing.Size(236, 21)
        Me.CboTipoPrecio.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(87, 444)
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
        Me.btnAgregarPresent.Location = New System.Drawing.Point(607, 448)
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
        Me.btnQuitarPrest.Location = New System.Drawing.Point(609, 490)
        Me.btnQuitarPrest.Name = "btnQuitarPrest"
        Me.btnQuitarPrest.Size = New System.Drawing.Size(84, 30)
        Me.btnQuitarPrest.TabIndex = 23
        Me.btnQuitarPrest.TabStop = False
        Me.btnQuitarPrest.Text = "&Eliminar"
        '
        'ChkActivar
        '
        Me.ChkActivar.AutoSize = True
        Me.ChkActivar.Location = New System.Drawing.Point(482, 220)
        Me.ChkActivar.Name = "ChkActivar"
        Me.ChkActivar.Size = New System.Drawing.Size(59, 17)
        Me.ChkActivar.TabIndex = 25
        Me.ChkActivar.Text = "Activar"
        Me.ChkActivar.UseVisualStyleBackColor = True
        '
        'cbTipoPago
        '
        Me.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPago.Location = New System.Drawing.Point(850, 423)
        Me.cbTipoPago.Name = "cbTipoPago"
        Me.cbTipoPago.Size = New System.Drawing.Size(202, 21)
        Me.cbTipoPago.TabIndex = 28
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(782, 426)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Tipo Pago :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGrid1
        '
        Me.DataGrid1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(738, 470)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(252, 167)
        Me.DataGrid1.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(1057, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 30)
        Me.Button1.TabIndex = 30
        Me.Button1.TabStop = False
        Me.Button1.Text = "  &Agregar"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(1059, 512)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 30)
        Me.Button3.TabIndex = 31
        Me.Button3.TabStop = False
        Me.Button3.Text = "&Eliminar"
        '
        'FrmMantenimientoPromociones_SubCatT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1286, 760)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cbTipoPago)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.ChkActivar)
        Me.Controls.Add(Me.btnBusqProdVta)
        Me.Controls.Add(Me.txtProdVtaCod)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregarPresent)
        Me.Controls.Add(Me.lbProductoVta)
        Me.Controls.Add(Me.btnQuitarPrest)
        Me.Controls.Add(Me.CboTipoPrecio)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dgCuotaLinea)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMantenimientoPromociones_SubCatT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promociones Sub Categoria Tienda"
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Fields"
    Private INTFLAG_R As Integer

    Dim TablaTipoPrecioPromo As DataTable
    Dim TABLE_SUBCAT As DataTable

#End Region



#Region "Funciones Form"
    Private Sub cargadatos()
        CAyuda.CargarDataCombo(CboZona, "Nsp_Select_Zona  '" & codempresa & "'", "codzona", "deszona")

        CAyuda.CargarDataCombo(CboTipoPrecio, "nsp_sele_tipopre  '" & codempresa & "'", "codtipopre", "dstipopre")

        CAyuda.CargarDataCombo(cbolinea, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")


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


        Me.dtpFechaIni.Value = Format(vFechaActual, "dd/MM/yyyy")

        Me.dtpFechaFin.Value = Format(vFechaActual, "dd/MM/yyyy")


    End Sub

#End Region

    Private Sub FrmMantenimientoPromociones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call cargadatos()
        MostrarSubCategoria()
        TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPrecioXPromocion", codempresa, txtProdPromoCod.Text.Trim, txtCodPromo.Text).Tables(0)
        If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
            Me.dgCuotaLinea.DataSource = TablaTipoPrecioPromo
            FORMATO_GRID()
        End If


        Me.dtpFechaIni.Value = Format(vFechaActual, "dd/MM/yyyy")

        Me.dtpFechaFin.Value = Format(vFechaActual, "dd/MM/yyyy")


        CAyuda.CargarDataCombo(cbTipoPago, "SelectTIPO_PAGO_FinancroxProc  '" & codempresa & "'", "CODTIPOPAGO", "DSTIPOPAGO")

        cbTipoPago.SelectedIndex = 1
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
        Me.btnBusqPromo.Enabled = Not GUARDAR
        Me.dtpFechaIni.Enabled = GUARDAR
        Me.dtpFechaFin.Enabled = GUARDAR
    End Sub

    Private Sub btnBusqPromo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqPromo.Click
        Call BOTONES(True, False, True, True)
        Call Bloqueatextbox(Me)
        Dim FRMX As New FrmGridPromocionSubCatT
        FRMX.vie = Me
        'FRMX.bol = True
        FRMX.ShowDialog()
        txtCodPromo.ReadOnly = True




        TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPrecioXPromocion_SubCatT", codempresa, cbosublinea.SelectedValue.ToString, txtCodPromo.Text).Tables(0)
        If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
            Me.dgCuotaLinea.DataSource = TablaTipoPrecioPromo
            FORMATO_GRID()
        End If


        TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPagoXPromocionSubT", txtCodPromo.Text).Tables(0)
        If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
            Me.DataGrid1.DataSource = TablaTipoPrecioPromo
            FORMATO_GRID2()
        End If



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



    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim ACTIVAR As Integer
        If ChkActivar.Checked = True Then
            ACTIVAR = 1

        Else
            ACTIVAR = 0

        End If


        Dim sql As String
        Call formatotextbox(Me)
        If Not VerificarDatos() Then
            Exit Sub
        End If


        If IsNumeric(txtPrecio.Text) Then
            If CDbl(txtPrecio.Text) <= 0 Then
                MsgBox("el precio de la promocion tiene q ser mayor a cero ejemplo 0.01", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
        Else
            MsgBox("ingrese un precio en la promocion tiene q ser mayor a cero ejemplo 0.01", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        If IsNothing(CboPresentVta.SelectedValue) = True Then
            MsgBox("El articulo de Venta no tiene Presentacion..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If IsNothing(CboPresentProm.SelectedValue) = True Then
            MsgBox("El articulo de Promocion no tiene Presentacion..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If cbTipoPago.Text = "" Then
            MsgBox("No tiene tipo Pago..", MsgBoxStyle.Exclamation, "")
            cbTipoPago.Focus()
            Exit Sub
        End If



        If INTFLAG_R = 0 Then
            sql = "NSP_INSERT_PROMOCIONES_SUBCATT '" & codempresa & "','" & txtCodPromo.Text & "','" & txtDescripción.Text & "'," & Me.txtPrecio.Text & ",'" & cbolinea.SelectedValue.ToString & "','" & cbosublinea.SelectedValue.ToString & "','" & CboPresentVta.SelectedValue & "'," & Me.txtProdVtaCant.Text & ",'" & Me.txtProdPromoCod.Text.Trim & "','" & CboPresentProm.SelectedValue & "'," & Me.txtProfPromoCant.Text.Trim & ", " & Me.txtStock.Text & ", '" & Me.dtpFechaIni.Value.ToShortDateString & "', '" & dtpFechaFin.Value.ToShortDateString & "','" & CboZona.SelectedValue & "'," & ACTIVAR & ",'" & cbTipoPago.SelectedValue.ToString & "'"
            If TmpInsertDatos(sql) = True Then
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")


                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)

                Bloqueatextbox(Me)
                LimpiarData()
                GrpPromo.Enabled = False
                GrpVta.Enabled = False
                CboZona.Enabled = False
            End If
        End If

        If INTFLAG_R = 1 Then
            sql = "NSP_UPDATE_PROMOCIONES_SUBCATT '" & codempresa & "','" & txtCodPromo.Text & "','" & txtDescripción.Text & "'," & Me.txtPrecio.Text & ",'" & cbolinea.SelectedValue.ToString & "','" & cbosublinea.SelectedValue.ToString & "','" & CboPresentVta.SelectedValue & "'," & Me.txtProdVtaCant.Text & ",'" & Me.txtProdPromoCod.Text.Trim & "','" & CboPresentProm.SelectedValue & "'," & Me.txtProfPromoCant.Text.Trim & ", " & Me.txtStock.Text & ", '" & Me.dtpFechaIni.Value.ToShortDateString & "', '" & dtpFechaFin.Value.ToShortDateString & "' ,'" & CboZona.SelectedValue & "'," & ACTIVAR & ",'" & cbTipoPago.SelectedValue.ToString & "'"
            If TmpInsertDatos(sql) = True Then
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

                Call BOTONES(True, False, False, False, True)
                Bloqueatextbox(Me)
                Call Limpiatextbox(Me)
                LimpiarData()
                GrpPromo.Enabled = False
                GrpVta.Enabled = False
                CboZona.Enabled = False

            End If
        End If
        BTNCANCELAR.Enabled = False


    End Sub


    Public Function VerificarDatos() As Boolean
        Dim Obs1 As String = String.Empty, obs2 As String = String.Empty, obs3 As String = String.Empty, obs4 As String = String.Empty, obs5 As String = String.Empty

        If INTFLAG_R = 0 Then
            If Me.txtCodPromo.Text.Trim.Length = 0 Then
                Obs1 = vbCrLf + "-   Ingrese el código."
            Else
                Dim TablaConsulta As New DataTable
                TablaConsulta = CAyuda.ListarDatos("NSP_LISTAR_PROMOCION_SUBCAT", codempresa, Me.txtCodPromo.Text.Trim).Tables(0)
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
        txtCodPromo.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        INTFLAG_R = 1
        txtDescripción.Focus()
        txtDescripción.SelectAll()
        BTNCANCELAR.Enabled = True
        GrpPromo.Enabled = True
        GrpVta.Enabled = True
        CboZona.Enabled = True

        dtpFechaIni.Enabled = True
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
            CboPresentVta.DataSource = TmpListarDatos("SelectPRECIART_PresentxprocSUBCAT '" & codempresa & "','" & cbolinea.SelectedValue.ToString & "','" & cbosublinea.SelectedValue.ToString & "'")
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
            CAyuda.Ejecutar("NSP_DELETE_PROMOCIONES_SUBCATT", codempresa.Trim, txtCodPromo.Text.Trim)
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

    Private Sub dtpFechaIni_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaIni.ValueChanged

    End Sub

    Private Sub dtpFechaIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaIni.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            dtpFechaFin.Focus()
        End If

    End Sub

    Private Sub txtPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrecio.KeyDown

        If e.KeyCode = Keys.Enter Then
            dtpFechaIni.Focus()
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
            CAyuda.Ejecutar("NSP_INSERT_TipoPrecioXPromocionSubCatT", codempresa, cbosublinea.SelectedValue.ToString, CboTipoPrecio.SelectedValue, CboTipoPrecio.Text, txtCodPromo.Text)
            TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPrecioXPromocionSubCatT", codempresa, cbosublinea.SelectedValue.ToString, txtCodPromo.Text).Tables(0)
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
            CAyuda.Ejecutar("NSP_DELETE_TipoPrecioXPromocionSubCatT", codempresa, cbosublinea.SelectedValue.ToString, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 0).ToString.Trim, txtCodPromo.Text)

            TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPrecioXPromocionSubCatT", codempresa, cbosublinea.SelectedValue.ToString, txtCodPromo.Text).Tables(0)

            Me.dgCuotaLinea.DataSource = TablaTipoPrecioPromo
            FORMATO_GRID()

        End If


    End Sub

    Private Sub cbosublinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosublinea.SelectedIndexChanged



        If cbosublinea.Enabled = True Then
            CboPresentVta.DataSource = TmpListarDatos("SelectPRECIART_PresentxprocSUBCAT '" & codempresa & "','" & cbolinea.SelectedValue.ToString & "','" & cbosublinea.SelectedValue.ToString & "'")
            CboPresentVta.DisplayMember = "DESPRES"
            CboPresentVta.ValueMember = "CODPRES"

        End If


    End Sub

    Private Sub MostrarSubCategoria()
        TABLE_SUBCAT = TmpListarDatos("SP_SELECT_SUBLINEAxLINEA '" & codempresa.Trim & "' ,'" & cbolinea.SelectedValue & "'")
        cbosublinea.DataSource = TABLE_SUBCAT
        cbosublinea.ValueMember = "CODSUBLINEA"
        cbosublinea.DisplayMember = "DESSUBLINEA"

    End Sub

    Private Sub cbolinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbolinea.SelectedIndexChanged

        If cbolinea.Enabled = True Then
            MostrarSubCategoria()
        End If


        'If cbolinea.Text.Trim.Length > 0 Then
        '    MostrarSubCategoria()
        'End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtCodPromo.Text.Trim = "" Then
            MsgBox("Falta el Codigo ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        If Me.txtProdPromoCod.Text.Trim.Length > 0 Then
            CAyuda.Ejecutar("NSP_INSERT_TipoPagoXPromocionSubT", txtCodPromo.Text, cbTipoPago.SelectedValue)
            TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPagoXPromocionSubT", txtCodPromo.Text).Tables(0)
            If Me.TablaTipoPrecioPromo.Rows.Count > 0 Then
                Me.DataGrid1.DataSource = TablaTipoPrecioPromo
                FORMATO_GRID2()
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


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
            CAyuda.Ejecutar("NSP_DELETE_TipoPagoXPromocionSubT", txtCodPromo.Text, Me.DataGrid1(Me.DataGrid1.CurrentRowIndex, 1).ToString.Trim)

            TablaTipoPrecioPromo = CAyuda.ListarDatos("NSP_LISTAR_TipoPagoXPromocionSubT", txtCodPromo.Text).Tables(0)
            Me.DataGrid1.DataSource = TablaTipoPrecioPromo
            FORMATO_GRID2()



        End If

    End Sub
End Class
