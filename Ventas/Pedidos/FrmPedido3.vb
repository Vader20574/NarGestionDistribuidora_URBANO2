Imports CapaCliente

Public Class FrmPedido3
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
    Friend WithEvents Pedido As System.Windows.Forms.Label
    Friend WithEvents lbcliente As System.Windows.Forms.Label
    Friend WithEvents cbTipoPresent As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumPedido As System.Windows.Forms.TextBox
    Friend WithEvents btnBusVendedor As System.Windows.Forms.Button
    Friend WithEvents btnBusCliente As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha As System.Windows.Forms.Label
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtArticulo As System.Windows.Forms.TextBox
    Friend WithEvents BtnArticulos As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnBusNumPedido As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cbTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblArticulo As System.Windows.Forms.Label
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbTotalPedido As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PanelSaldoCredito As System.Windows.Forms.Panel
    Friend WithEvents lbSaldoCredito As System.Windows.Forms.Label
    Friend WithEvents dgPedido As System.Windows.Forms.DataGrid
    Friend WithEvents TablaEstiloPedido As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODARTI As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESARTI As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CODPRES As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESPRES As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PRECIOART As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CANT As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DSCTO_FINAN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DSCTO_MONTO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TOTFILA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PROMOCION As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lbDescFzaVta As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CboPagador As System.Windows.Forms.ComboBox
    Friend WithEvents CboDireccion As System.Windows.Forms.ComboBox
    Friend WithEvents CboVended As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents lblCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CboTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents GrpCab As System.Windows.Forms.GroupBox
    Friend WithEvents BtnReporte As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnConsulta As System.Windows.Forms.Button
    Friend WithEvents GrDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbSaldoDisponible As System.Windows.Forms.Label
    Friend WithEvents lbLCTotal As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtDescExterno As TextBox
    Friend WithEvents gbtipodoc As GroupBox
    Friend WithEvents rbboleta As RadioButton
    Friend WithEvents rbfactura As RadioButton
    Friend WithEvents rbnotap As RadioButton
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNroDespacho As TextBox
    Friend WithEvents Label17 As Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedido3))
        Me.txtNumPedido = New System.Windows.Forms.TextBox()
        Me.Pedido = New System.Windows.Forms.Label()
        Me.GrpCab = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lbSaldoDisponible = New System.Windows.Forms.Label()
        Me.lbLCTotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CboTipoPrecio = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CboPagador = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.cbTipoPago = New System.Windows.Forms.ComboBox()
        Me.btnBusVendedor = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.TextBox()
        Me.txtRuc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CboVended = New System.Windows.Forms.ComboBox()
        Me.CboDireccion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBusCliente = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelSaldoCredito = New System.Windows.Forms.Panel()
        Me.lbDescFzaVta = New System.Windows.Forms.Label()
        Me.lbSaldoCredito = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBusNumPedido = New System.Windows.Forms.Button()
        Me.GrDetalle = New System.Windows.Forms.GroupBox()
        Me.txtDescExterno = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.TextBox()
        Me.lblArticulo = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipoPresent = New System.Windows.Forms.ComboBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.lbcliente = New System.Windows.Forms.Label()
        Me.BtnArticulos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbTotalPedido = New System.Windows.Forms.Label()
        Me.dgPedido = New System.Windows.Forms.DataGrid()
        Me.TablaEstiloPedido = New System.Windows.Forms.DataGridTableStyle()
        Me.CODARTI = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DESARTI = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.CODPRES = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DESPRES = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.PRECIOART = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.CANT = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DSCTO_FINAN = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DSCTO_MONTO = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.TOTFILA = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.PROMOCION = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnConsulta = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnReporte = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.gbtipodoc = New System.Windows.Forms.GroupBox()
        Me.rbboleta = New System.Windows.Forms.RadioButton()
        Me.rbfactura = New System.Windows.Forms.RadioButton()
        Me.rbnotap = New System.Windows.Forms.RadioButton()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNroDespacho = New System.Windows.Forms.TextBox()
        Me.GrpCab.SuspendLayout()
        Me.PanelSaldoCredito.SuspendLayout()
        Me.GrDetalle.SuspendLayout()
        CType(Me.dgPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbtipodoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumPedido
        '
        Me.txtNumPedido.Enabled = False
        Me.txtNumPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPedido.Location = New System.Drawing.Point(516, 4)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(176, 26)
        Me.txtNumPedido.TabIndex = 2
        '
        'Pedido
        '
        Me.Pedido.AutoSize = True
        Me.Pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pedido.Location = New System.Drawing.Point(387, 8)
        Me.Pedido.Name = "Pedido"
        Me.Pedido.Size = New System.Drawing.Size(125, 20)
        Me.Pedido.TabIndex = 3
        Me.Pedido.Text = "Num. Pedido : "
        Me.Pedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrpCab
        '
        Me.GrpCab.Controls.Add(Me.Label16)
        Me.GrpCab.Controls.Add(Me.ComboBox1)
        Me.GrpCab.Controls.Add(Me.lbSaldoDisponible)
        Me.GrpCab.Controls.Add(Me.lbLCTotal)
        Me.GrpCab.Controls.Add(Me.Label15)
        Me.GrpCab.Controls.Add(Me.CboTipoPrecio)
        Me.GrpCab.Controls.Add(Me.Label14)
        Me.GrpCab.Controls.Add(Me.Label13)
        Me.GrpCab.Controls.Add(Me.CboPagador)
        Me.GrpCab.Controls.Add(Me.btnAgregar)
        Me.GrpCab.Controls.Add(Me.btnQuitar)
        Me.GrpCab.Controls.Add(Me.cbTipoPago)
        Me.GrpCab.Controls.Add(Me.btnBusVendedor)
        Me.GrpCab.Controls.Add(Me.dtpFecha)
        Me.GrpCab.Controls.Add(Me.Label1)
        Me.GrpCab.Controls.Add(Me.Fecha)
        Me.GrpCab.Controls.Add(Me.Label7)
        Me.GrpCab.Controls.Add(Me.Label12)
        Me.GrpCab.Controls.Add(Me.lblCliente)
        Me.GrpCab.Controls.Add(Me.txtRuc)
        Me.GrpCab.Controls.Add(Me.Label11)
        Me.GrpCab.Controls.Add(Me.CboVended)
        Me.GrpCab.Controls.Add(Me.CboDireccion)
        Me.GrpCab.Controls.Add(Me.Label5)
        Me.GrpCab.Controls.Add(Me.txtCodCliente)
        Me.GrpCab.Controls.Add(Me.Label4)
        Me.GrpCab.Controls.Add(Me.btnBusCliente)
        Me.GrpCab.Controls.Add(Me.Label10)
        Me.GrpCab.Enabled = False
        Me.GrpCab.Location = New System.Drawing.Point(142, 46)
        Me.GrpCab.Name = "GrpCab"
        Me.GrpCab.Size = New System.Drawing.Size(762, 171)
        Me.GrpCab.TabIndex = 4
        Me.GrpCab.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 164
        Me.Label16.Text = "Almacen :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(68, 139)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 21)
        Me.ComboBox1.TabIndex = 160
        '
        'lbSaldoDisponible
        '
        Me.lbSaldoDisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaldoDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldoDisponible.Location = New System.Drawing.Point(548, 122)
        Me.lbSaldoDisponible.Name = "lbSaldoDisponible"
        Me.lbSaldoDisponible.Size = New System.Drawing.Size(116, 20)
        Me.lbSaldoDisponible.TabIndex = 163
        Me.lbSaldoDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbLCTotal
        '
        Me.lbLCTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbLCTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLCTotal.Location = New System.Drawing.Point(548, 98)
        Me.lbLCTotal.Name = "lbLCTotal"
        Me.lbLCTotal.Size = New System.Drawing.Size(116, 20)
        Me.lbLCTotal.TabIndex = 162
        Me.lbLCTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(425, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(130, 20)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "Saldo Disponible :"
        '
        'CboTipoPrecio
        '
        Me.CboTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoPrecio.Enabled = False
        Me.CboTipoPrecio.Location = New System.Drawing.Point(504, 38)
        Me.CboTipoPrecio.Name = "CboTipoPrecio"
        Me.CboTipoPrecio.Size = New System.Drawing.Size(202, 21)
        Me.CboTipoPrecio.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(482, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 20)
        Me.Label14.TabIndex = 160
        Me.Label14.Text = "Total LC :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(436, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Tipo Precio :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboPagador
        '
        Me.CboPagador.BackColor = System.Drawing.Color.White
        Me.CboPagador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPagador.Enabled = False
        Me.CboPagador.Location = New System.Drawing.Point(68, 112)
        Me.CboPagador.Name = "CboPagador"
        Me.CboPagador.Size = New System.Drawing.Size(258, 21)
        Me.CboPagador.TabIndex = 18
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(353, 113)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(66, 24)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Visible = False
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Location = New System.Drawing.Point(353, 141)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(66, 24)
        Me.btnQuitar.TabIndex = 11
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.Visible = False
        '
        'cbTipoPago
        '
        Me.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPago.Location = New System.Drawing.Point(504, 62)
        Me.cbTipoPago.Name = "cbTipoPago"
        Me.cbTipoPago.Size = New System.Drawing.Size(202, 21)
        Me.cbTipoPago.TabIndex = 15
        '
        'btnBusVendedor
        '
        Me.btnBusVendedor.ImageIndex = 5
        Me.btnBusVendedor.ImageList = Me.ImageList1
        Me.btnBusVendedor.Location = New System.Drawing.Point(328, 12)
        Me.btnBusVendedor.Name = "btnBusVendedor"
        Me.btnBusVendedor.Size = New System.Drawing.Size(30, 24)
        Me.btnBusVendedor.TabIndex = 2
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
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(504, 14)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(442, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tipo Pago :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Location = New System.Drawing.Point(424, 18)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(82, 13)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "Fecha Pedido : "
        Me.Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Pagador :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(186, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Ruc : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCliente
        '
        Me.lblCliente.BackColor = System.Drawing.Color.White
        Me.lblCliente.Enabled = False
        Me.lblCliente.Location = New System.Drawing.Point(68, 62)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.ReadOnly = True
        Me.lblCliente.Size = New System.Drawing.Size(316, 20)
        Me.lblCliente.TabIndex = 13
        '
        'txtRuc
        '
        Me.txtRuc.BackColor = System.Drawing.Color.White
        Me.txtRuc.Enabled = False
        Me.txtRuc.Location = New System.Drawing.Point(222, 38)
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.ReadOnly = True
        Me.txtRuc.Size = New System.Drawing.Size(94, 20)
        Me.txtRuc.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Apell o Rz :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboVended
        '
        Me.CboVended.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboVended.Location = New System.Drawing.Point(68, 14)
        Me.CboVended.Name = "CboVended"
        Me.CboVended.Size = New System.Drawing.Size(258, 21)
        Me.CboVended.TabIndex = 1
        '
        'CboDireccion
        '
        Me.CboDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDireccion.Enabled = False
        Me.CboDireccion.Location = New System.Drawing.Point(68, 86)
        Me.CboDireccion.Name = "CboDireccion"
        Me.CboDireccion.Size = New System.Drawing.Size(368, 21)
        Me.CboDireccion.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Vendedor :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Location = New System.Drawing.Point(68, 38)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(82, 20)
        Me.txtCodCliente.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CodCliente :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusCliente
        '
        Me.btnBusCliente.ImageIndex = 5
        Me.btnBusCliente.ImageList = Me.ImageList1
        Me.btnBusCliente.Location = New System.Drawing.Point(154, 38)
        Me.btnBusCliente.Name = "btnBusCliente"
        Me.btnBusCliente.Size = New System.Drawing.Size(30, 22)
        Me.btnBusCliente.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Direccion :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelSaldoCredito
        '
        Me.PanelSaldoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSaldoCredito.Controls.Add(Me.lbDescFzaVta)
        Me.PanelSaldoCredito.Controls.Add(Me.lbSaldoCredito)
        Me.PanelSaldoCredito.Controls.Add(Me.Label9)
        Me.PanelSaldoCredito.Location = New System.Drawing.Point(729, 219)
        Me.PanelSaldoCredito.Name = "PanelSaldoCredito"
        Me.PanelSaldoCredito.Size = New System.Drawing.Size(220, 52)
        Me.PanelSaldoCredito.TabIndex = 20
        Me.PanelSaldoCredito.Visible = False
        '
        'lbDescFzaVta
        '
        Me.lbDescFzaVta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDescFzaVta.Location = New System.Drawing.Point(10, 4)
        Me.lbDescFzaVta.Name = "lbDescFzaVta"
        Me.lbDescFzaVta.Size = New System.Drawing.Size(182, 16)
        Me.lbDescFzaVta.TabIndex = 0
        Me.lbDescFzaVta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSaldoCredito
        '
        Me.lbSaldoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaldoCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldoCredito.Location = New System.Drawing.Point(98, 24)
        Me.lbSaldoCredito.Name = "lbSaldoCredito"
        Me.lbSaldoCredito.Size = New System.Drawing.Size(116, 20)
        Me.lbSaldoCredito.TabIndex = 1
        Me.lbSaldoCredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "LC Pedido :"
        '
        'btnBusNumPedido
        '
        Me.btnBusNumPedido.Enabled = False
        Me.btnBusNumPedido.ImageIndex = 5
        Me.btnBusNumPedido.ImageList = Me.ImageList1
        Me.btnBusNumPedido.Location = New System.Drawing.Point(1049, 2)
        Me.btnBusNumPedido.Name = "btnBusNumPedido"
        Me.btnBusNumPedido.Size = New System.Drawing.Size(30, 26)
        Me.btnBusNumPedido.TabIndex = 1
        Me.btnBusNumPedido.Visible = False
        '
        'GrDetalle
        '
        Me.GrDetalle.Controls.Add(Me.txtDescExterno)
        Me.GrDetalle.Controls.Add(Me.Label17)
        Me.GrDetalle.Controls.Add(Me.lbPrecio)
        Me.GrDetalle.Controls.Add(Me.lblArticulo)
        Me.GrDetalle.Controls.Add(Me.txtCantidad)
        Me.GrDetalle.Controls.Add(Me.Label6)
        Me.GrDetalle.Controls.Add(Me.Label2)
        Me.GrDetalle.Controls.Add(Me.cbTipoPresent)
        Me.GrDetalle.Controls.Add(Me.txtArticulo)
        Me.GrDetalle.Controls.Add(Me.lbcliente)
        Me.GrDetalle.Controls.Add(Me.BtnArticulos)
        Me.GrDetalle.Controls.Add(Me.Label3)
        Me.GrDetalle.Enabled = False
        Me.GrDetalle.Location = New System.Drawing.Point(4, 217)
        Me.GrDetalle.Name = "GrDetalle"
        Me.GrDetalle.Size = New System.Drawing.Size(719, 68)
        Me.GrDetalle.TabIndex = 5
        Me.GrDetalle.TabStop = False
        '
        'txtDescExterno
        '
        Me.txtDescExterno.Location = New System.Drawing.Point(527, 42)
        Me.txtDescExterno.Name = "txtDescExterno"
        Me.txtDescExterno.Size = New System.Drawing.Size(66, 20)
        Me.txtDescExterno.TabIndex = 14
        Me.txtDescExterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(449, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Desc Externo :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbPrecio
        '
        Me.lbPrecio.Location = New System.Drawing.Point(646, 42)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(66, 20)
        Me.lbPrecio.TabIndex = 12
        Me.lbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblArticulo
        '
        Me.lblArticulo.BackColor = System.Drawing.Color.White
        Me.lblArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArticulo.Location = New System.Drawing.Point(216, 12)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(358, 22)
        Me.lblArticulo.TabIndex = 3
        Me.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(362, 46)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(66, 20)
        Me.txtCantidad.TabIndex = 9
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cantidad : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Presentación :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTipoPresent
        '
        Me.cbTipoPresent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPresent.Location = New System.Drawing.Point(90, 40)
        Me.cbTipoPresent.Name = "cbTipoPresent"
        Me.cbTipoPresent.Size = New System.Drawing.Size(184, 21)
        Me.cbTipoPresent.TabIndex = 6
        '
        'txtArticulo
        '
        Me.txtArticulo.Location = New System.Drawing.Point(90, 12)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(92, 20)
        Me.txtArticulo.TabIndex = 1
        '
        'lbcliente
        '
        Me.lbcliente.Location = New System.Drawing.Point(30, 14)
        Me.lbcliente.Name = "lbcliente"
        Me.lbcliente.Size = New System.Drawing.Size(56, 18)
        Me.lbcliente.TabIndex = 0
        Me.lbcliente.Text = "Artículo :"
        Me.lbcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnArticulos
        '
        Me.BtnArticulos.ImageIndex = 5
        Me.BtnArticulos.ImageList = Me.ImageList1
        Me.BtnArticulos.Location = New System.Drawing.Point(184, 10)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(30, 24)
        Me.BtnArticulos.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(604, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.ImageIndex = 1
        Me.btnGuardar.ImageList = Me.ImageList1
        Me.btnGuardar.Location = New System.Drawing.Point(6, 13)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 25)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "     &Guardar"
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.ImageIndex = 2
        Me.btnModificar.ImageList = Me.ImageList1
        Me.btnModificar.Location = New System.Drawing.Point(6, 41)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(84, 25)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "     &Modificar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.ImageIndex = 0
        Me.btnNuevo.ImageList = Me.ImageList1
        Me.btnNuevo.Location = New System.Drawing.Point(1107, 120)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(84, 25)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "  &Nuevo"
        Me.btnNuevo.Visible = False
        '
        'btnAnular
        '
        Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnular.ImageIndex = 3
        Me.btnAnular.ImageList = Me.ImageList1
        Me.btnAnular.Location = New System.Drawing.Point(1107, 158)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(84, 25)
        Me.btnAnular.TabIndex = 4
        Me.btnAnular.Text = "  &Anular"
        Me.btnAnular.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(624, 511)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 22)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Total :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTotalPedido
        '
        Me.lbTotalPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTotalPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotalPedido.Location = New System.Drawing.Point(692, 509)
        Me.lbTotalPedido.Name = "lbTotalPedido"
        Me.lbTotalPedido.Size = New System.Drawing.Size(130, 26)
        Me.lbTotalPedido.TabIndex = 9
        Me.lbTotalPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgPedido
        '
        Me.dgPedido.CaptionText = "Modificar = Enter - Eliminar = F3"
        Me.dgPedido.DataMember = ""
        Me.dgPedido.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgPedido.Location = New System.Drawing.Point(6, 290)
        Me.dgPedido.Name = "dgPedido"
        Me.dgPedido.ReadOnly = True
        Me.dgPedido.Size = New System.Drawing.Size(981, 220)
        Me.dgPedido.TabIndex = 7
        Me.dgPedido.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloPedido})
        '
        'TablaEstiloPedido
        '
        Me.TablaEstiloPedido.DataGrid = Me.dgPedido
        Me.TablaEstiloPedido.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODARTI, Me.DESARTI, Me.CODPRES, Me.DESPRES, Me.PRECIOART, Me.CANT, Me.DSCTO_FINAN, Me.DSCTO_MONTO, Me.TOTFILA, Me.PROMOCION})
        Me.TablaEstiloPedido.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'CODARTI
        '
        Me.CODARTI.Format = ""
        Me.CODARTI.FormatInfo = Nothing
        Me.CODARTI.Width = 0
        '
        'DESARTI
        '
        Me.DESARTI.Format = ""
        Me.DESARTI.FormatInfo = Nothing
        Me.DESARTI.HeaderText = "Articulo"
        Me.DESARTI.Width = 180
        '
        'CODPRES
        '
        Me.CODPRES.Format = ""
        Me.CODPRES.FormatInfo = Nothing
        Me.CODPRES.Width = 0
        '
        'DESPRES
        '
        Me.DESPRES.Format = ""
        Me.DESPRES.FormatInfo = Nothing
        Me.DESPRES.HeaderText = "Presentación"
        Me.DESPRES.Width = 90
        '
        'PRECIOART
        '
        Me.PRECIOART.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.PRECIOART.Format = "#####0.00"
        Me.PRECIOART.FormatInfo = Nothing
        Me.PRECIOART.HeaderText = "Precio"
        Me.PRECIOART.Width = 75
        '
        'CANT
        '
        Me.CANT.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.CANT.Format = ""
        Me.CANT.FormatInfo = Nothing
        Me.CANT.HeaderText = "Cantidad"
        Me.CANT.Width = 75
        '
        'DSCTO_FINAN
        '
        Me.DSCTO_FINAN.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DSCTO_FINAN.Format = "#####0.00"
        Me.DSCTO_FINAN.FormatInfo = Nothing
        Me.DSCTO_FINAN.HeaderText = "Dsct.Cond.Vta"
        Me.DSCTO_FINAN.Width = 75
        '
        'DSCTO_MONTO
        '
        Me.DSCTO_MONTO.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DSCTO_MONTO.Format = "#####0.00"
        Me.DSCTO_MONTO.FormatInfo = Nothing
        Me.DSCTO_MONTO.HeaderText = "Dscto.Mono"
        Me.DSCTO_MONTO.Width = 75
        '
        'TOTFILA
        '
        Me.TOTFILA.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.TOTFILA.Format = "#####0.00"
        Me.TOTFILA.FormatInfo = Nothing
        Me.TOTFILA.HeaderText = "Monto Total"
        Me.TOTFILA.Width = 75
        '
        'PROMOCION
        '
        Me.PROMOCION.Format = ""
        Me.PROMOCION.FormatInfo = Nothing
        Me.PROMOCION.Width = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.BtnConsulta)
        Me.GroupBox2.Controls.Add(Me.BtnCancelar)
        Me.GroupBox2.Controls.Add(Me.BtnReporte)
        Me.GroupBox2.Controls.Add(Me.BtnSalir)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(909, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(98, 180)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'BtnConsulta
        '
        Me.BtnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsulta.ImageIndex = 4
        Me.BtnConsulta.ImageList = Me.ImageList1
        Me.BtnConsulta.Location = New System.Drawing.Point(6, 69)
        Me.BtnConsulta.Name = "BtnConsulta"
        Me.BtnConsulta.Size = New System.Drawing.Size(84, 25)
        Me.BtnConsulta.TabIndex = 3
        Me.BtnConsulta.Text = "     &Consulta"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(6, 131)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(84, 25)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "     &Cancelar"
        '
        'BtnReporte
        '
        Me.BtnReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReporte.ImageIndex = 11
        Me.BtnReporte.ImageList = Me.ImageList1
        Me.BtnReporte.Location = New System.Drawing.Point(8, 100)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(84, 25)
        Me.BtnReporte.TabIndex = 5
        Me.BtnReporte.Text = "    &Reporte"
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.ImageIndex = 13
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(6, 156)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(84, 25)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "&Salir"
        '
        'gbtipodoc
        '
        Me.gbtipodoc.Controls.Add(Me.rbboleta)
        Me.gbtipodoc.Controls.Add(Me.rbfactura)
        Me.gbtipodoc.Controls.Add(Me.rbnotap)
        Me.gbtipodoc.Location = New System.Drawing.Point(6, 12)
        Me.gbtipodoc.Name = "gbtipodoc"
        Me.gbtipodoc.Size = New System.Drawing.Size(132, 95)
        Me.gbtipodoc.TabIndex = 160
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
        'txtNumDoc
        '
        Me.txtNumDoc.Enabled = False
        Me.txtNumDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDoc.Location = New System.Drawing.Point(202, 8)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(176, 26)
        Me.txtNumDoc.TabIndex = 161
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(143, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 162
        Me.Label18.Text = "Nro Doc :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(714, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 20)
        Me.Label19.TabIndex = 164
        Me.Label19.Text = "Nro Despacho : "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNroDespacho
        '
        Me.txtNroDespacho.Enabled = False
        Me.txtNroDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDespacho.Location = New System.Drawing.Point(854, 5)
        Me.txtNroDespacho.Name = "txtNroDespacho"
        Me.txtNroDespacho.Size = New System.Drawing.Size(140, 26)
        Me.txtNroDespacho.TabIndex = 163
        '
        'FrmPedido3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1013, 636)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtNroDespacho)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.gbtipodoc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrpCab)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lbTotalPedido)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.PanelSaldoCredito)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgPedido)
        Me.Controls.Add(Me.GrDetalle)
        Me.Controls.Add(Me.btnBusNumPedido)
        Me.Controls.Add(Me.Pedido)
        Me.Controls.Add(Me.txtNumPedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPedido3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Pedido Descuento Externo"
        Me.GrpCab.ResumeLayout(False)
        Me.GrpCab.PerformLayout()
        Me.PanelSaldoCredito.ResumeLayout(False)
        Me.GrDetalle.ResumeLayout(False)
        Me.GrDetalle.PerformLayout()
        CType(Me.dgPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbtipodoc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Fields"
    Public TablaTempPedidos As New DataTable
    Public CodRuta As String
    Public CodTipoPrecio As String = String.Empty
    Private TotMonto As Double
    'Private Obj As New ClsInterface
    'Private ClsAy As New ClsAyuda
    Private EstadoGuarda As Integer = 0
    Public PedidoTerminado As String
    Public VarCodFzaVta As String = String.Empty
    Public VarCodVendedor As String = String.Empty
    Public VarDesVendedor As String = String.Empty
    Private ActEventCombo As Boolean
    Private TMP_VENTADET As New DataTable
    Private TablaComboPresent As New DataTable



#End Region

#Region "Funciones del Formulario"

    Private Sub CargarArticulo()
        If txtCodCliente.Text.Trim = "" Then
            MsgBox("FALTA INDICAR EL  CLIENTE ...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim TabArt As New DataTable
        TabArt = TmpListarDatos("SELECT  CODARTI,DESARTI FROM ARTICULO  WHERE CODEMPRESA='" & codempresa & "'  AND CODARTI='" & txtArticulo.Text & "'")
        lblArticulo.Text = TabArt.Rows(0)("DESARTI")


        TablaComboPresent = CAyuda.ListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT", codempresa, txtArticulo.Text, CodTipoPrecio, IIf(PPPUNTOVENTA = True, 1, 0), IIf(PPFUERZVENTA = True, 1, 0)).Tables(0)
        cbTipoPresent.DataSource = TablaComboPresent
        cbTipoPresent.DisplayMember = "DESPRES"
        cbTipoPresent.ValueMember = "CODPRES"


        ActEventCombo = True
        Dim Sender As Object = Nothing
        Dim e As EventArgs = Nothing
        cbTipoPresent_SelectedIndexChanged(Sender, e)
        txtCantidad.Focus()

    End Sub
    Private Sub CargarDatos()
        CAyuda.CargarDataCombo(CboVended, "SP_ListVendedor  '" & codempresa & "'", "CODVEND", "DSVEND")
        CAyuda.CargarDataCombo(CboTipoPrecio, "nsp_sele_tipopre  '" & codempresa & "'", "codtipopre", "dstipopre")
        CAyuda.CargarDataCombo(cbTipoPago, "SelectTIPO_PAGO_FinancroxProc  '" & codempresa & "'", "CODTIPOPAGO", "DSTIPOPAGO")
        ActEventCombo = True

    End Sub
    Private Sub FORMATO_GRID_TMP_DETALLE()
        dgPedido.TableStyles.Clear()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_VENTADET.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "ITEM"
            .HeaderText = "Item"
            .NullText = ""
            .Width = 25
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CODARTI"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 100
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DESARTI"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 200
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "CODPRES"
            .HeaderText = "CODPRES"
            .NullText = ""
            .Width = 0
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "DESPRES"
            .HeaderText = "Presentacion"
            .NullText = ""
            .Width = 100
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "PRECIOVTA"
            .HeaderText = "Precio"
            .NullText = ""
            .Format = GMascaraDec(DECIPREC)
            .Alignment = HorizontalAlignment.Right
            .Width = 70
        End With
        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "CANTIDAD"
            .HeaderText = "Cantidad"
            .NullText = ""
            .Format = GMascaraDec(DECICANT)
            .Alignment = HorizontalAlignment.Right
            .Width = 70
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "MONTODESCT1"
            .HeaderText = "Dscto Monto_"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Alignment = HorizontalAlignment.Right
            .Width = 70
        End With
        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "MONTODESCT2"
            .HeaderText = "Dscto Financ_"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Alignment = HorizontalAlignment.Right
            .Width = 70
        End With
        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "TOTBAS"
            .HeaderText = "Total_"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Alignment = HorizontalAlignment.Right
            .Width = 70
        End With
        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "DESCEXT"
            .HeaderText = "DESCEXT"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Alignment = HorizontalAlignment.Right
            .Width = 70
        End With
        Dim Column12 As New DataGridTextBoxColumn
        With Column12
            .MappingName = "TDESCEXT"
            .HeaderText = "TDESCEXT"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Alignment = HorizontalAlignment.Right
            .Width = 70
        End With


        TableStyle1.GridColumnStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
        dgPedido.TableStyles.Add(TableStyle1)
    End Sub
    Private Sub CARGAR_GRID_TMP_DETALLE()
        TMP_VENTADET = TmpListarDatos("SelectTMP_PEDIDO_VTA_DETxProc  '" & codempresa & "','" & VCorrelVta & "'")
        dgPedido.DataSource = TMP_VENTADET

        Dim TEMP_ As New DataTable
        TEMP_ = TmpListarDatos("SP_OBTENERMONTO_TMPPEDIDOVTADET  '" & codempresa & "','" & CodUsuario & "','" & VCorrelVta & "'")
        If TEMP_.Rows.Count > 0 Then
            lbTotalPedido.Text = FormatoMonto(TEMP_.Rows(0)("TOTBAS"), DECIRESU)
            If CDbl(lbTotalPedido.Text) = 0 Then
                cbTipoPago.Enabled = True
                BtnCancelar.Enabled = False
            Else
                cbTipoPago.Enabled = False
                BtnCancelar.Enabled = True
            End If
        End If
    End Sub
    Private Sub INSERT_TMP_DETALLE()

        CAyuda.Ejecutar("InsTMP_PEDIDO_VTA_DETxProcEXT", codempresa, txtArticulo.Text, lblArticulo.Text, CDbl(txtCantidad.Text), CDbl(lbPrecio.Text), CDbl(lbPrecio.Text), cbTipoPresent.SelectedValue, cbTipoPresent.Text, CDMONBASE, VCorrelVta, CDZONA, CodUsuario, CboTipoPrecio.SelectedValue, cbTipoPago.SelectedValue, Format(CDate(dtpFecha.Value), "dd/MM/yyyy"), CDbl(txtDescExterno.Text))

    End Sub
    Private Sub CargarDirecciones()
        Dim table As New DataTable
        table = TmpListarDatos("SP_BUSC_CLIPTOLLEGADAxCLIE  '" & codempresa & "','" & txtCodCliente.Text.Trim & "'")
        If table.Rows.Count > 0 Then
            CboDireccion.DataSource = table
            CboDireccion.DisplayMember = "PTOLLEGADA"
            CboDireccion.ValueMember = "CODRUTA"
            GrDetalle.Enabled = True
        Else
            MsgBox("FALTA LA DIRECCION DE ENTREGA .." & vbCrLf & ".VERIFIQUE MAESTRA DE CLIENTE", MsgBoxStyle.Exclamation, "")
            GrDetalle.Enabled = False
        End If

    End Sub


    Private Sub BuscarCliente(ByVal CodCli As String)
        Dim TABCLIENTE As New DataTable
        TABCLIENTE = TmpListarDatos("SELECT  CODCLIENTE,DATOADJUNTO,DIRECCION,RUTA,RUC  FROM  CLIENTE   WHERE CODEMPRESA='" & codempresa & "'  AND  CODCLIENTE='" & CodCli & "'  AND ESTADO=1 ")
        If TABCLIENTE.Rows.Count > 0 Then
            lblCliente.Text = Trim(TABCLIENTE.Rows(0)("DATOADJUNTO"))
            CboDireccion.DataSource = TABCLIENTE
            CboDireccion.DisplayMember = "DIRECCION"
            CboDireccion.ValueMember = "DIRECCION"
            CodRuta = Trim(TABCLIENTE.Rows(0)("RUTA"))
            txtRuc.Text = Trim(TABCLIENTE.Rows(0)("RUC"))

            '-----------------------------------------------------
            '--------------CARGAR CLIENTE PAGADOR
            '-----------------------------------------------------
            Conecta("SP_BUSC_CLIEPRINCIPAL_CODDEP    '" & codempresa & "','" & txtCodCliente.Text.Trim & "'", "D")

            Dim CODCLID As String
            CODCLID = Trim(CAyuda.ValidaNulls(ds.Tables("D").Rows(0)(1)))

            Dim TablaTemp As New DataTable
            TablaTemp = ds.Tables("D")
            CboPagador.DataSource = TablaTemp
            CboPagador.ValueMember = "CODIGO"
            CboPagador.DisplayMember = "DESCRIPCION"

            If TablaTemp.Rows.Count > 0 Then
                CboTipoPrecio.SelectedValue = Trim(TablaTemp.Rows(0)("CODTIPOPRE"))
                CodTipoPrecio = Trim(TablaTemp.Rows(0)("CODTIPOPRE"))
                cbTipoPago.SelectedValue = TablaTemp.Rows(0)("CODTIPOPAGO")

                lbLCTotal.Text = Format(CDbl(TablaTemp.Rows(0)("mtolimcred")), "#######0.00")

                Dim TAB_DETALLE As DataTable
                TAB_DETALLE = TmpListarDatos("SP_SELECT_COBRANZAXCLIENTE '" & codempresa & "','" & CODCLID & "'")

                Dim lineaUtilidad As Double
                If TAB_DETALLE.Rows.Count > 0 Then

                    lineaUtilidad = TAB_DETALLE.Rows(0)(0).ToString

                Else
                    lineaUtilidad = 0
                End If

                lbSaldoDisponible.Text = Format(CDbl(lbLCTotal.Text) - CDbl(lineaUtilidad), "#######0.00")
                Conecta("SP_UPDATE_SALDODISPONIBLE    '" & codempresa & "','" & CboPagador.SelectedValue & "','" & lbSaldoDisponible.Text & "'", "D")

                If TablaTemp.Rows(0)("CODTIPOPAGO") = VCdPagEfectivo Then
                    cbTipoPago.Enabled = False
                Else
                    cbTipoPago.Enabled = True
                End If

            End If

            GrDetalle.Enabled = True
            EvaluarCreditoClienteVendedor()

        Else
            MsgBox("Producto no esta registrado o esta desactivado")

            lblCliente.Text = ""

            txtRuc.Text = ""

        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_DOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        If (MSG.Msg = WD_DOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.F3
                    If TMP_VENTADET.Rows.Count > 0 Then
                        If dgPedido.Focus = True Then
                            Delete_Item()
                        End If

                    End If
                Case Keys.Enter

                    If TMP_VENTADET.Rows.Count > 0 Then
                        If dgPedido.Focus = True Then
                            txtArticulo.Text = dgPedido.Item(dgPedido.CurrentRowIndex, 1)

                            ActEventCombo = False

                            CargarArticulo()



                            cbTipoPresent.SelectedValue = dgPedido.Item(dgPedido.CurrentRowIndex, 3)
                            lbPrecio.Text = dgPedido.Item(dgPedido.CurrentRowIndex, 5)
                            txtCantidad.Text = dgPedido.Item(dgPedido.CurrentRowIndex, 6)
                            Delete_Item()
                            txtCantidad.Focus()


                        End If
                    End If
            End Select
        End If
    End Function

    Private Sub Delete_Item()
        CAyuda.Ejecutar("SP_ELI_TMPPEDIDOVTADET", codempresa, CodUsuario, VCorrelVta, dgPedido.Item(dgPedido.CurrentRowIndex, 0))
        CARGAR_GRID_TMP_DETALLE()
        FORMATO_GRID_TMP_DETALLE()
    End Sub

    Private Sub LimpiarNuevo(Optional ByVal var As Boolean = True)
        txtCodCliente.Text = ""
        txtRuc.Text = ""
        lblCliente.Text = ""
        CboDireccion.Text = ""
        txtArticulo.Text = ""
        lblArticulo.Text = ""
        lbPrecio.Text = 0
        txtCantidad.Text = 0

        txtNumDoc.Text = ""
        txtNumPedido.Text = ""
        txtNroDespacho.Text = ""


        'LblTitulo.Visible = False
        ' Me.dtpFecha.Value = Now
        Me.dtpFecha.Value = Format(vFechaActual, "dd/MM/yyyy")
        CodRuta = String.Empty
        TotMonto = 0.0
        btnBusNumPedido.Enabled = False
        txtNumPedido.Enabled = False

        Me.btnNuevo.Enabled = var
        btnGuardar.Enabled = False
        btnAnular.Enabled = False
        btnModificar.Enabled = False
        BtnCancelar.Enabled = Not var
        BtnReporte.Enabled = False
        GrpCab.Enabled = False
        GrDetalle.Enabled = False
        BtnReporte.Enabled = True



        If FACT_EDITPRECIO = True Then
            lbPrecio.Enabled = True
        Else
            lbPrecio.Enabled = False
        End If

    End Sub
#End Region

    Private Sub FrmPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarDatos()
        LimpiarNuevo()
        Me.btnNuevo.Enabled = True
        dtpFecha.Value = Format(vFechaActual, "dd/MM/yyyy")

        CAyuda.CargarDataCombo(ComboBox1, "Nsp_select_Almacen  '" & codempresa & "'", "codigo", "descripcion")
        BtnReporte.Enabled = True


    End Sub
    Private Function SumaTotal() As Double
        If TablaTempPedidos.Rows.Count = 0 Then
            SumaTotal = 0.0
            Exit Function
        End If
        For ContSum As Integer = 0 To TablaTempPedidos.Rows.Count - 1
            SumaTotal += TablaTempPedidos.Rows(ContSum)("TOTBAS")
        Next
    End Function

    Private Sub btnBusCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusCliente.Click
        Dim ob As New FrmBuscarClieDepen
        ob.ShowDialog()
        If ob.DEVOLVER = False Then
            Exit Sub
        End If


        txtCodCliente.Text = ob.GridCli.Item(ob.GridCli.CurrentRowIndex, 0)
        BuscarCliente(txtCodCliente.Text)

    End Sub

    Private Sub btnBusVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusVendedor.Click
        Dim FrmVend As New FrmBuscVendedor
        FrmVend.ShowDialog()
        CboVended.SelectedValue = FrmVend.GridVend.Item(FrmVend.GridVend.CurrentRowIndex, 0)
        EvaluarCreditoClienteVendedor()
    End Sub

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click
        'If Me.cbTipoPago.SelectedValue.ToString.Trim = VCdPagCredito And Me.PanelSaldoCredito.Visible = False Then
        '    MsgBox("El cliente NO puede hacer el pedido por NO tener crédito, " & vbCrLf & " en la Fuerza de venta del Vendedor", MsgBoxStyle.Information, "NARGEST - Pedidos")
        '    Exit Sub
        'End If
        If CboVended.Text.Trim.Length > 0 Then
            Dim FrmArt As New FrmListarArticuloFact3
            FrmArt.ShowDialog()
            If FrmArt.DEVOLVER = False Then
                Exit Sub
            End If
            ActEventCombo = False
            txtArticulo.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 0)
            CargarArticulo()
        Else
            MsgBox("Escoja un vendedor para listar los articulos de su respectiva Fuerza de venta.", MsgBoxStyle.Information, "Nar Sistemas S.A.C.")
        End If
    End Sub

    Private Sub cbTipoPresent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoPresent.SelectedIndexChanged
        'NSP_LISTAR_PRESENT_ARTI_COMBO
        If ActEventCombo = True And txtArticulo.Text.Trim.Length <> 0 Then
            If TablaComboPresent.Rows.Count > 0 Then
                Dim TabPrecio As New DataTable
                TabPrecio = CAyuda.ListarDatos("SP_BUSC_PRECIOARTFACT", codempresa, Me.cbTipoPresent.SelectedValue.ToString.Trim, CodTipoPrecio, txtArticulo.Text.Trim, txtCodCliente.Text).Tables(0)
                Me.lbPrecio.Text = Format(CDbl(TabPrecio.Rows(0)("PRECIOVTA")), "#######0.00")
                VPrecio = Me.lbPrecio.Text

                txtCantidad.Focus()
            End If
        End If
    End Sub
    Private Function ValidarArticulos_PagoEfectivo() As Boolean

        Conecta("SELECT SOLOEFECTIVO FROM ARTICULO WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODARTI = '" & Me.txtArticulo.Text.Trim & "'", "TABLA1")
        Dim VarSoloEfectivoArt As Boolean
        VarSoloEfectivoArt = ds.Tables("TABLA1").Rows(0)(0)
        If Me.cbTipoPago.SelectedValue.ToString.Trim <> "01" Then
            If VarSoloEfectivoArt Then
                ValidarArticulos_PagoEfectivo = False
            Else
                ValidarArticulos_PagoEfectivo = True
            End If
        Else
            ValidarArticulos_PagoEfectivo = True
        End If
    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Me.txtArticulo.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        'If ValidarArticulos_PagoEfectivo() = False Then
        '    MsgBox("No se puede agregar este artículo, porque la condición de venta de este producto es de SOLO EFECTIVO.", MsgBoxStyle.Information, "Nar Sistemas S.A.C.")
        '    Exit Sub
        'End If

        If IsNothing(cbTipoPresent.SelectedValue) = True Then
            MsgBox("Falta la presentacion  ...", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If lbPrecio.Text.Trim = "" Then
            MsgBox("El Articulo no tiene precio..", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If CDbl(lbPrecio.Text.Trim) = 0 Then
            MsgBox("El Articulo no puede tener precio Cero..", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtCantidad.Text.Trim = "" Then
            MsgBox("El Articulo no tiene cantidad..", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If txtCantidad.Text.Trim = "." Then
            txtCantidad.Text = "0.00"
        End If

        If CDbl(txtCantidad.Text.Trim) = 0 Then
            MsgBox("El Articulo no puede tener cantidad Cero..", MsgBoxStyle.Exclamation)
            Exit Sub
        End If



        'Dim PRECIOMODIF As Double
        'PRECIOMODIF = VPrecio - (VPrecio * (5 / 100))
        'If PRECIOMODIF >= CDbl(lbPrecio.Text) Then
        '    MsgBox("Precio x debajo deL 5 porciento")
        '    Exit Sub
        'End If



        Dim Table_Factor As DataTable
        Dim factor As Integer
        Table_Factor = CAyuda.ListarDatos("NSP_SELECT_FACTPRES", codempresa, cbTipoPresent.SelectedValue.ToString).Tables(0)
        If Table_Factor.Rows.Count > 0 Then
            factor = Table_Factor.Rows(0)(0).ToString
        End If

        Dim cantidad As Integer

        cantidad = factor * CInt(txtCantidad.Text)
        Dim Table_Correl As DataTable

        Table_Correl = CAyuda.ListarDatos("SP_SELEC_ARTIDATXA", Me.txtArticulo.Text, ComboBox1.SelectedValue.ToString, cantidad).Tables(0)

        If Table_Correl.Rows.Count > 0 Then
            If CInt(Table_Correl.Rows(0)(0).ToString) < 0 Then
                MsgBox("ESTE ARTICULO " & Me.txtArticulo.Text & " NO TIENE STOCK EN EL " & ComboBox1.Text)
                Exit Sub
            End If
        End If


        INSERT_TMP_DETALLE()
        CARGAR_GRID_TMP_DETALLE()
        FORMATO_GRID_TMP_DETALLE()
        txtArticulo.Text = ""
        lblArticulo.Text = ""
        lbPrecio.Text = 0
        txtCantidad.Text = 0
        txtDescExterno.Text = 0
        txtArticulo.Focus()

    End Sub
    Public Function TraeDsctoMonto(ByVal VarCodigo As String, ByVal VarDsctoVenta As Double) As Double
        '' EN LA TABLA TIPO_DSCTO_FINANCIERO
        Conecta("SELECT CODSUBLINEA FROM ARTICULO WHERE CODARTI ='" & VarCodigo.Trim & "' AND CODEMPRESA='" & codempresa & "'", "TAB1")
        Dim VarSubLinea As String
        VarSubLinea = ds.Tables("TAB1").Rows(0)(0).ToString.Trim
        Dim TablaDatosDsctos As New DataTable
        TablaDatosDsctos = CAyuda.ListarDatos("NSP_TRAER_DSCTO_MONTO", codempresa.Trim, VarSubLinea.Trim, VarDsctoVenta).Tables(0)
        If TablaDatosDsctos.Rows.Count > 0 Then
            TraeDsctoMonto = (CDbl(TablaDatosDsctos.Rows(0)("MONTOPORC")))
        Else
            TraeDsctoMonto = 0
        End If
    End Function
    Public Function TraerDsctoCondVenta(ByVal VarCodigo As String, ByVal VarVenta As Double) As Double
        Conecta("SELECT CODSUBLINEA, SOLOEFECTIVO FROM ARTICULO WHERE CODARTI ='" & VarCodigo.Trim & "' AND CODEMPRESA='" & codempresa & "'", "TAB1")
        Dim VarSubLinea As String
        VarSubLinea = ds.Tables("TAB1").Rows(0)(0).ToString.Trim
        Dim TablaDatosDsctos As New DataTable
        TablaDatosDsctos = CAyuda.ListarDatos("NSP_TRAER_DSCTO_COND_PAGO", codempresa.Trim, VarSubLinea.Trim).Tables(0)
        If TablaDatosDsctos.Rows.Count > 0 Then
            If CBool(ds.Tables("TAB1").Rows(0)(1)) Then
                TraerDsctoCondVenta = (VarVenta * CDbl(TablaDatosDsctos.Rows(0)("MONTO_EFECTIVO"))) / 100
            Else
                If Me.cbTipoPago.SelectedValue.ToString.Trim = VCdPagEfectivo Then
                    TraerDsctoCondVenta = (CDbl(TablaDatosDsctos.Rows(0)("MONTO_EFECTIVO")))
                ElseIf Me.cbTipoPago.SelectedValue.ToString.Trim = VCdPagCredito Then
                    TraerDsctoCondVenta = (CDbl(TablaDatosDsctos.Rows(0)("MONTO_CREDITO")))
                End If
            End If
        Else
            TraerDsctoCondVenta = 0
        End If
    End Function

    Private Sub Insertando_QuitandoPromociones()
        For ConTXX As Integer = 0 To TablaTempPedidos.Rows.Count - 1
            If ConTXX > TablaTempPedidos.Rows.Count - 1 Then
                Exit For
            End If
            If TablaTempPedidos.Rows(ConTXX)("PROMOCION").ToString.Trim.Length > 0 Then
                TablaTempPedidos.Rows.RemoveAt(ConTXX)
                ConTXX = ConTXX - 1
            End If
        Next
        '' RECORRIENDO LA TABLA PEDIDOS 
        For ContX As Integer = 0 To TablaTempPedidos.Rows.Count - 1
            Dim TablaTempDatosProm As New DataTable
            '' EXTRAYENDO LOS DATOS DEL PRODUCTO PROMOCIÓN X ARTICULO DE VENTA
            TablaTempDatosProm = CAyuda.ListarDatos("NSP_VERIFICAR_PROMOCION", codempresa, TablaTempPedidos.Rows(ContX)("CODARTI").ToString.Trim, Now.ToShortDateString).Tables(0)
            If TablaTempDatosProm.Rows.Count > 0 Then '' SI TIENE PROMOCIÓN ENTRA
                For ContBS As Integer = 0 To TablaTempPedidos.Rows.Count - 1 '' RECORRIDO PARA PROMOCION EXISTENTE
                    If TablaTempPedidos.Rows(ContBS)("CODARTI").ToString.Trim = TablaTempDatosProm.Rows(0)("CODARTI_PROMO").ToString.Trim And TablaTempPedidos.Rows(ContBS)("PROMOCION").ToString.Trim = TablaTempDatosProm.Rows(0)("CODPROMO").ToString.Trim Then
                        'CALCULO DE LA CANTIDAD DE PROMOCION EN BASE A LA CANTIDAD DE ARTICULO VENTA'
                        Dim VarPresentacionVta As String, VarEquival, CantUnidadesVenta As Double
                        VarPresentacionVta = TablaTempPedidos.Rows(ContX)("CODPRES").ToString.Trim
                        VarEquival = CAyuda.ListarDatos("NSP_EXTRAE_EQUIVAL_MONTO", codempresa, TablaTempPedidos.Rows(ContX)("CODARTI").ToString.Trim, VarPresentacionVta, CodTipoPrecio.Trim).Tables(0).Rows(0)("EQUIVALENCIA")
                        CantUnidadesVenta = CDbl(TablaTempPedidos.Rows(ContX)("CANTIDAD")) * VarEquival
                        TablaTempPedidos.Rows(ContBS)("PRECIO_ART") = TablaTempDatosProm.Rows(0)("PRECIO_PROMO")
                        Dim Sobrante As Long
                        Dim PrimCantidad As Double
                        PrimCantidad = TablaTempPedidos.Rows(ContBS)("CANTIDAD")
                        TablaTempPedidos.Rows(ContBS)("CANTIDAD") = Math.DivRem(CLng(CantUnidadesVenta), CLng(TablaTempDatosProm.Rows(0)("CANT_ARTI_VTA")), Sobrante)
                        TablaTempPedidos.Rows(ContBS)("CANTIDAD") = Math.Floor(CDbl(TablaTempPedidos.Rows(ContBS)("CANTIDAD")) * CDbl(TablaTempDatosProm.Rows(0)("CANT_ARTI_PROMO")))
                        TablaTempPedidos.Rows(ContBS)("CANTIDAD") = PrimCantidad + TablaTempPedidos.Rows(ContBS)("CANTIDAD")
                        Exit For
                    ElseIf ContBS = TablaTempPedidos.Rows.Count - 1 Then
                        Dim filaR As DataRow = TablaTempPedidos.NewRow
                        filaR("CODEMPRESA") = codempresa
                        filaR("NUM_PEDIDO") = txtNumPedido.Text.Trim
                        filaR("CODARTI") = TablaTempDatosProm.Rows(0)("CODARTI_PROMO")
                        filaR("DESARTI") = CAyuda.ListarDatos("sp_sele_articulo_cons2", codempresa, TablaTempDatosProm.Rows(0)("CODARTI_PROMO")).Tables(0).Rows(0)(1).ToString.Trim & "(PROMOCIÓN)"


                        Dim TablaX As New DataTable
                        TablaX = CAyuda.ListarDatos("NSP_EXTRAE_PRESENT_PROM", codempresa, TablaTempDatosProm.Rows(0)("CODARTI_PROMO").ToString.Trim, CodTipoPrecio.Trim).Tables(0)
                        Try
                            filaR("CODPRES") = TablaX.Rows(0)("CODPRES").ToString.Trim
                            filaR("DESPRES") = TablaX.Rows(0)("DESPRES").ToString.Trim
                        Catch ex As Exception
                            MsgBox("Al insertar el item de promoción, se produjeron inconvenientes debido a : " + vbCrLf _
                            + "- El item de promoción no tiene ninguna presentación asociada a la lista de precio " + vbCrLf _
                            + "del cliente actual, ¿ Desea Continuar sin el item de promoción ?", MsgBoxStyle.Information)
                            Exit Sub
                        End Try
                        'CALCULO DE LA CANTIDAD DE PROMOCION EN BASE A LA CANTIDAD DE ARTICULO VENTA'
                        Dim VarPresentacionVta As String, VarEquival, CantUnidadesVenta As Double
                        VarPresentacionVta = TablaTempPedidos.Rows(ContX)("CODPRES").ToString.Trim
                        VarEquival = CAyuda.ListarDatos("NSP_EXTRAE_EQUIVAL_MONTO", codempresa, TablaTempPedidos.Rows(ContX)("CODARTI").ToString.Trim, VarPresentacionVta, CodTipoPrecio.Trim).Tables(0).Rows(0)("EQUIVALENCIA")
                        CantUnidadesVenta = CDbl(TablaTempPedidos.Rows(ContX)("CANTIDAD")) * VarEquival
                        filaR("PRECIO_ART") = TablaTempDatosProm.Rows(0)("PRECIO_PROMO")
                        Dim Sobrante As Long
                        filaR("CANTIDAD") = Math.DivRem(CLng(CantUnidadesVenta), CLng(TablaTempDatosProm.Rows(0)("CANT_ARTI_VTA")), Sobrante)
                        filaR("CANTIDAD") = Math.Floor(CDbl(filaR("CANTIDAD")) * CDbl(TablaTempDatosProm.Rows(0)("CANT_ARTI_PROMO")))
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        If TablaTempDatosProm.Rows(0)("STOCK_PROMO") < filaR("CANTIDAD") Then
                            MsgBox("El monto de promocion solo satisface " & (filaR("TOT_FILA") - TablaTempDatosProm.Rows(0)("STOCK_PROMO")).ToString.Trim & " Unidades", MsgBoxStyle.Information)
                        End If
                        filaR("DSCTO_MONTO") = 0.0
                        filaR("DSCTO_FINAN") = 0.0
                        filaR("TOT_FILA") = TablaTempDatosProm.Rows(0)("PRECIO_PROMO")
                        filaR("PROMOCION") = TablaTempDatosProm.Rows(0)("CODPROMO")
                        TablaTempPedidos.Rows.Add(filaR)
                        TablaTempPedidos.AcceptChanges()
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub SumTotMonto()
        If TablaTempPedidos.Rows.Count = 0 Then
            TotMonto = 0.0
            Exit Sub
        End If
        For cont2 As Integer = 0 To TablaTempPedidos.Rows.Count - 1
            TotMonto = TotMonto + CDbl(TablaTempPedidos.Rows(cont2)("TOT_FILA"))
        Next
    End Sub


    Private Function ValidarGuardar() As Boolean
        Dim rpt1 As String = String.Empty, rpt2 As String = String.Empty, rpt3 As String = String.Empty, rpt4 As String = String.Empty
        If Me.txtCodCliente.Text.Trim.Length = 0 Then
            rpt1 = vbCrLf + "-  Ingrese el código del cliente."
        End If
        If CboVended.Text.Trim.Length = 0 Then
            rpt2 = vbCrLf + "-  Ingrese el código de vendedor."
        Else

        End If

        If rpt1 <> String.Empty Or rpt2 <> String.Empty Then
            MsgBox("Para Guardar corrija las siguientes observaciones : " + vbCrLf + rpt1 + rpt2, MsgBoxStyle.Information)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
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

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If

        '************************************************************************************************

        If ValidarGuardar() Then
            Dim VarTipoPago As String
            Dim EstadoGuarda_Msg As Integer
            If Me.cbTipoPago.SelectedValue Is Nothing Then
                VarTipoPago = ""
            Else
                VarTipoPago = cbTipoPago.SelectedValue
            End If
            If TMP_VENTADET.Rows.Count = 0 Then
                MsgBox("- Falta agregar detalles al pedido.", MsgBoxStyle.Information, "NARSISTEMAS")
                Exit Sub
            End If



            Dim TipoDoc As String

            If rbboleta.Checked = True Then
                TipoDoc = "03"
            End If

            If rbfactura.Checked = True Then
                TipoDoc = "01"
            End If

            If rbnotap.Checked = True Then
                TipoDoc = "06"
            End If


            If CInt(TmpListarDatos("SELECT COUNT(*) FROM PEDIDO_VTA_CAB2   WHERE CODEMPRESA='" & codempresa & "' AND NUM_PEDIDO='" & txtNumPedido.Text.Trim & "'").Rows(0)(0)) > 0 Then
                CAyuda.Ejecutar("NSP_UPDATE_MONT_PEDIDO_VTA_CAB2", codempresa, txtNumPedido.Text.Trim, CodUsuario)
            Else
                CAyuda.Ejecutar("NSP_INSERT_PEDIDOVTA_CAB2", codempresa, txtNumPedido.Text.Trim, txtCodCliente.Text.Trim, lblCliente.Text, CboDireccion.Text, CodRuta, CboVended.SelectedValue, dtpFecha.Value, "P", CboDireccion.Text, cbTipoPago.SelectedValue, IIf(CboPagador.SelectedValue Is Nothing, "", CType(CboPagador.SelectedValue, String)), CodUsuario, VCorrelVta, ComboBox1.SelectedValue, TipoDoc, txtNumDoc.Text.ToString(), txtNroDespacho.Text.ToString())
            End If


            If EstadoGuarda_Msg = 1 Then
                MsgBox("El pedido con número :" & txtNumPedido.Text.Trim & " , Se ha creado satisfactoriamente.", MsgBoxStyle.Information)
            ElseIf EstadoGuarda_Msg = 2 Then
                MsgBox("El pedido con número :" & txtNumPedido.Text.Trim & " , Se ha modificado satisfactoriamente.", MsgBoxStyle.Information)
            End If
            TmpInsertDatos("DELETE	FROM  TMP_PEDIDO_VTA_DET  WHERE  CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
            CARGAR_GRID_TMP_DETALLE()
            FORMATO_GRID_TMP_DETALLE()
            LimpiarNuevo(True)

        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        TmpInsertDatos("DELETE	FROM  TMP_PEDIDO_VTA_DET  WHERE  CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
        CARGAR_GRID_TMP_DETALLE()
        FORMATO_GRID_TMP_DETALLE()
        LimpiarNuevo(False)
        txtNumPedido.Text = TmpListarDatos("SELECT ISNULL(NROPEDIDO,0) FROM  VENDEDOR   WHERE  CODEMPRESA='" & codempresa & "'  AND CODVEND='" & IIf(IsNothing(CboVended.SelectedValue), "", CboVended.SelectedValue) & "'").Rows(0)(0).ToString.Trim
        EstadoGuarda = 1
        PedidoTerminado = False
        GrpCab.Enabled = True
        'LblTitulo.Visible = True
        GrDetalle.Enabled = True
        Me.dtpFecha.Enabled = True
        btnGuardar.Enabled = True
        Me.CboVended.Focus()


        btnBusVendedor.Enabled = True
        btnBusCliente.Enabled = True

    End Sub
    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If TMP_VENTADET.Rows.Count > 0 Then
            CAyuda.Ejecutar("SP_ELI_TMPPEDIDOVTADET", codempresa, CodUsuario, dgPedido.Item(dgPedido.CurrentRowIndex, 0))
            CARGAR_GRID_TMP_DETALLE()
            FORMATO_GRID_TMP_DETALLE()
        End If
    End Sub

    Private Sub btnBusNumPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusNumPedido.Click

        Dim fr As New FrmGridPedidosVta3
        fr.vie = Me
        fr.ShowDialog()

        If fr.DEVOLVER = False Then
            Exit Sub
        End If





        If Me.txtNumPedido.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim TablaCabPedido As New DataTable
        If Me.txtNumPedido.Text.Trim.Length = 0 Then
            Me.txtNumPedido.Text = "0"
        End If

        Try
            Dim TablaVerifPedido As New DataTable
            TablaVerifPedido = CAyuda.ListarDatos("NSP_VERIF_PEDIDO_VTA2", codempresa, txtNumPedido.Text.Trim).Tables(0)
            If CInt(TablaVerifPedido.Rows(0)(0)) > 0 Then
                TablaCabPedido = CAyuda.ListarDatos("NSP_TRAER_PEDIDO_VTA2", codempresa, txtNumPedido.Text.Trim, CodUsuario, VCorrelVta).Tables(0)
            Else
                TablaCabPedido = CAyuda.ListarDatos("NSP_TRAER_PEDIDO_VTA", codempresa, txtNumPedido.Text.Trim, CodUsuario, VCorrelVta).Tables(0)
            End If

            If TablaCabPedido.Rows(0)("ESTADO").ToString.Trim = "A" Then
                MsgBox("DOCUMENTO ANULADO..", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            txtCodCliente.Text = TablaCabPedido.Rows(0)("CODCLIENTE").ToString.Trim
            CboVended.SelectedValue = TablaCabPedido.Rows(0)("CODVENDEDOR").ToString.Trim
            CboPagador.SelectedValue = TablaCabPedido.Rows(0)("CODDEP").ToString.Trim
            dtpFecha.Value = TablaCabPedido.Rows(0)("FECPEDIDO")
            If TablaCabPedido.Rows(0)("CODTIPOPAGO").ToString.Trim = "000001" Then
                Me.cbTipoPago.SelectedValue = "01"
            Else
                Me.cbTipoPago.SelectedValue = TablaCabPedido.Rows(0)("CODTIPOPAGO").ToString.Trim

            End If
            CodTipoPrecio = TablaCabPedido.Rows(0)("CODTIPOPRE").ToString.Trim



            BuscarCliente(txtCodCliente.Text.Trim)

        Catch ex As Exception
            MsgBox("PROBLEMAS CON LOS DATOS :" + vbCrLf + ex.Message, MsgBoxStyle.Information)
        End Try
        Me.dtpFecha.Enabled = False
        Me.btnGuardar.Enabled = False
        'TablaTempPedidos = Obj.ListarDatos("NSP_LISTAR_PEDIDO", codempresa, txtNumPedido.Text).Tables(0)
        'CargarGridPed()
        CARGAR_GRID_TMP_DETALLE()
        FORMATO_GRID_TMP_DETALLE()

        cbTipoPago.Enabled = True

        GrpCab.Enabled = True



    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'desbloqueatextbox(Me)
        Conecta("SELECT ESTADO FROM PEDIDO_VTA_CAB WHERE NUM_PEDIDO = " & txtNumPedido.Text, "DD")
        If ds.Tables("DD").Rows.Count > 0 Then
            If ds.Tables("DD").Rows(0)(0).ToString.Trim = "1" Then
                '' 0 ----> Pedido Pendiente
                '' 1 ----> Pedido Con Orden de Despacho
                '' 2 ----> Pedido Anulado
                Conecta("SELECT NRORDEN_DESPACHO	FROM 	ORDEN_DESPACHO_CONSOL_ART	WHERE CODEMPRESA ='" & codempresa.Trim & "'  AND NUM_PEDIDO='" & Me.txtNumPedido.Text.Trim & "'", "DSG")
                If ds.Tables("DSG").Rows.Count > 0 Then
                    MsgBox("Este pedido ya tiene una Orden de Despacho Asignada -" & ds.Tables("DSG").Rows(0)(0).ToString.Trim & " . No puede Modificarse.", MsgBoxStyle.Information)

                Else
                    MsgBox("Este pedido ya tiene una Orden de Despacho Asignada. No puede Modificarse.", MsgBoxStyle.Information)
                End If

                Exit Sub
            End If
        End If
        Dim vObject As Object
        Me.GrDetalle.Enabled = True
        For Each vObject In GrDetalle.Controls
            If TypeOf vObject Is TextBox Then
                vObject.ReadOnly = False
            End If
            If TypeOf vObject Is ComboBox Then
                vObject.Enabled = True
            End If
            If TypeOf vObject Is Label Then
                If vObject.BorderStyle = BorderStyle.FixedSingle Then
                    vObject.Text = String.Empty
                End If
            End If
        Next
        Me.BtnArticulos.Enabled = True
        Me.btnBusCliente.Enabled = False
        Me.btnBusVendedor.Enabled = False
        Me.btnAgregar.Enabled = True
        Me.btnQuitar.Enabled = True
        Me.btnGuardar.Enabled = True
        EstadoGuarda = 2

    End Sub

    Private Sub QuitandoArticulosNO_FV()
        For ContY As Integer = 0 To TablaTempPedidos.Rows.Count - 1
            If ContY > TablaTempPedidos.Rows.Count - 1 Then
                Exit For
            End If
            Conecta("SELECT CODLINEA FROM ARTICULO WHERE CODEMPRESA='" & codempresa & "' AND CODARTI='" & TablaTempPedidos.Rows(ContY)("CODARTI").ToString.Trim & "' AND CODLINEA IN (SELECT CODCATEG FROM FUERZAVENTA_CATEGORIA WHERE CODEMPRESA='" & codempresa & "' AND CODFZAVTA ='" & VarCodFzaVta.Trim & "')", "TAB23")
            If ds.Tables("TAB23").Rows.Count = 0 Then
                TablaTempPedidos.Rows.RemoveAt(ContY)
                TablaTempPedidos.AcceptChanges()
                ContY = ContY - 1
            End If
        Next
        Me.dgPedido.DataSource = TablaTempPedidos
        Insertando_QuitandoPromociones()
        lbTotalPedido.Text = Format(SumaTotal(), "#######0.00")
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If txtCantidad.Text > 0 And lbPrecio.Enabled = False Then
                btnAgregar_Click(sender, e)
            Else
                If txtDescExterno.Enabled = True Then
                    txtDescExterno.Focus()
                Else
                    MsgBox("Ingrese Cantidad Para El Producto... ", MsgBoxStyle.Exclamation)
                    txtCantidad.Focus()
                End If
            End If
        End If


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

    Private Sub txtArticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArticulo.TextChanged

    End Sub

    Private Sub cbDireccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDireccion.SelectedIndexChanged

    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If PedidoTerminado = "P" Then
            If CAyuda.Ejecutar("NSP_ANULA_PEDIDOVTA", codempresa, txtNumPedido.Text.Trim) > 0 Then
                MsgBox("EL pedido ha sido anulado", MsgBoxStyle.Information)
                btnNuevo_Click(sender, e)
            Else
                MsgBox("El pedido no ha sido anulado " & vbCrLf & " Existen Articulos ya Cargados..", MsgBoxStyle.Exclamation)
            End If
        ElseIf PedidoTerminado = "T" Then
            MsgBox("Este pedido ya ha sido terminado y no se puede anular.", MsgBoxStyle.Information)
        ElseIf PedidoTerminado = "A" Then
            MsgBox("Este pedido ya ha sido Anulado.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub FrmPedido_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'Dim frm As MDIMAESTRAS
        'frm = Me.MdiParent
        'frm.VarFrmPEdido = Nothing
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

    Private Sub lbPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)





    End Sub
    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
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

    Private Sub cbTipoPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoPago.SelectedIndexChanged
        If Me.cbTipoPago.SelectedValue.ToString.Trim = "06" Then
            Dim NombreArticulo As String = String.Empty
            EvaluarCreditoClienteVendedor()
            For Cont2 As Integer = 0 To TablaTempPedidos.Rows.Count - 1
                Dim VarCodArti, VarDesArti As String
                VarCodArti = TablaTempPedidos.Rows(Cont2)("CODARTI").ToString.Trim
                VarDesArti = TablaTempPedidos.Rows(Cont2)("DESARTI").ToString.Trim
                Conecta("SELECT SOLOEFECTIVO FROM ARTICULO WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODARTI = '" & VarCodArti.Trim & "'", "TABLA2")
                If CBool(ds.Tables("TABLA2").Rows(0)(0)) Then
                    NombreArticulo = NombreArticulo + ", " + VarDesArti.Trim
                End If

            Next
            If NombreArticulo.Trim.Length > 0 Then
                MsgBox("Hay articulos con condicición de venta SOLO EFECTIVO. NO se puede cambiar la forma de pago sin antes retirar dichos producto. : " & vbCrLf & NombreArticulo, MsgBoxStyle.Information, "Nar Sistemas S.A.C")
                Me.cbTipoPago.SelectedValue = "01"
            End If
        Else
            Me.PanelSaldoCredito.Visible = False
        End If
    End Sub

    Public Function EvaluarCreditoClienteVendedor() As Boolean
        If txtCodCliente.Text.Length = 0 And Me.CboVended.SelectedValue.Trim.Length = 0 Then
            Exit Function
        End If
        Try
            If Me.cbTipoPago.SelectedValue.ToString.Trim = "06" Then
                Dim VarCodFVendedor As String
                Conecta("SELECT COD_FV	FROM VENDEDOR	WHERE	CODVEND='" & CboVended.SelectedValue.Trim & "'	AND	CODEMPRESA='" & codempresa.Trim & "'", "TABG")
                VarCodFVendedor = ds.Tables("TABG").Rows(0)(0)
                Dim VarDescFVendedor As String
                Conecta("SELECT * FROM FUERZAVENTA WHERE CODEMPRESA='" & codempresa.Trim & "' AND CODIGO='" & VarCodFVendedor.Trim & "'", "TABF")
                VarDescFVendedor = ds.Tables("TABF").Rows(0)("DESCRIPCION").ToString.Trim
                'Conecta("SELECT * FROM CLIE_FUERZA WHERE CODEMPRESA ='" & codempresa & "' AND CODCLIE='" & Me.CboPagador.SelectedValue & "'", "TABC")
                'For Contx As Integer = 0 To ds.Tables("TABC").Rows.Count - 1
                '    If ds.Tables("TABC").Rows(Contx)("CODFUERZA").ToString.Trim = VarCodFVendedor.Trim Then
                '        Me.PanelSaldoCredito.Visible = True
                '        Me.lbSaldoCredito.Text = Format(CDbl(ds.Tables("TABC").Rows(Contx)("SALDO_CREDF")), "#######0.00")
                '        Me.lbDescFzaVta.Text = VarDescFVendedor.Trim
                '        Exit For
                '    End If
                '    If Contx = ds.Tables("TABC").Rows.Count - 1 Then
                '        Me.PanelSaldoCredito.Visible = False
                '        MsgBox("-   El cliente no tiene crédito en la fuerza de venta a la que esta asociado el vendedor - " & VarDescFVendedor)
                '    End If
                'Next
            Else
                Me.PanelSaldoCredito.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtVendedor_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            btnBusVendedor_Click(sender, e)
        End If
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodCliente.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnBusCliente_Click(sender, e)
        ElseIf e.KeyCode = Keys.Enter Then
            If txtCodCliente.Text.Trim <> "" Then
                BuscarCliente(txtCodCliente.Text)
            End If
        End If
    End Sub
    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
    End Sub
    Private Sub dtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        'Me.txtVendedor.f()
        'End If
    End Sub

    Private Sub cbDireccion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbTipoPago.Focus()
        End If
    End Sub
    Private Sub cbTipoPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbTipoPago.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtArticulo.Focus()
        End If
    End Sub
    Private Sub txtArticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtArticulo.KeyDown
        If e.KeyCode = Keys.F2 Then
            BtnArticulos_Click(sender, e)
        End If
    End Sub
    Private Sub txtCodCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCliente.TextChanged
    End Sub
    Private Sub LblTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReporte.Click



        Dim VarFrmCentroCostoProm As New CapaDatafirst.Reportes.FrmRpt_DescExt
        VarFrmCentroCostoProm.ShowDialog()

    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If TMP_VENTADET.Rows.Count > 0 Then
            If MsgBox("Esta seguro de cancelar la Operacion..!", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        TmpInsertDatos("DELETE	FROM  TMP_PEDIDO_VTA_DET  WHERE  CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
        CARGAR_GRID_TMP_DETALLE()
        FORMATO_GRID_TMP_DETALLE()
        LimpiarNuevo()


    End Sub
    Private Sub CboVended_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboVended.SelectedIndexChanged
        'If ActEventCombo = True Then
        '    txtNumPedido.Text = TmpListarDatos("SELECT ISNULL(NROPEDIDO,0) FROM  VENDEDOR   WHERE  CODEMPRESA='" & codempresa & "'  AND CODVEND='" & IIf(IsNothing(CboVended.SelectedValue), "", CboVended.SelectedValue) & "'").Rows(0)(0).ToString.Trim
        'End If
    End Sub

    Private Sub BtnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsulta.Click
        If TMP_VENTADET.Rows.Count > 0 Then
            If MsgBox("Esta seguro de cancelar la Operacion..!", MsgBoxStyle.YesNo, "") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        TmpInsertDatos("DELETE	FROM  TMP_PEDIDO_VTA_DET  WHERE  CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
        CARGAR_GRID_TMP_DETALLE()
        FORMATO_GRID_TMP_DETALLE()
        LimpiarNuevo()
        btnBusNumPedido.Enabled = True
        'txtNumPedido.Enabled = True
        btnModificar.Enabled = True
        btnAnular.Enabled = True
        BtnReporte.Enabled = True
        txtNumDoc.Enabled = True
        txtNumDoc.Text = ""
        txtNumPedido.Text = ""
        txtNroDespacho.Text = ""


    End Sub

    Private Sub GrpCab_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpCab.Enter

    End Sub

    Private Sub CboTipoPrecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoPrecio.SelectedIndexChanged

    End Sub

    Private Sub dgPedido_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgPedido.Navigate

    End Sub

    Private Sub lbPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub lbPrecio_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lbPrecio.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnAgregar_Click(sender, e)

        End If

    End Sub

    Private Sub lbPrecio_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPrecio.TextChanged

    End Sub

    Private Sub lbPrecio_RightToLeftChanged(sender As Object, e As EventArgs) Handles lbPrecio.RightToLeftChanged

    End Sub

    Private Sub txtDescExterno_TextChanged(sender As Object, e As EventArgs) Handles txtDescExterno.TextChanged



    End Sub

    Private Sub txtDescExterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescExterno.KeyPress

        If Asc(e.KeyChar) = 13 Then

            lbPrecio.Focus()

        End If


    End Sub

    Private Sub txtNumPedido_TextChanged(sender As Object, e As EventArgs) Handles txtNumPedido.TextChanged

    End Sub

    Private Sub txtNumPedido_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumPedido.KeyDown



    End Sub

    Private Sub txtNumDoc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNumDoc.KeyDown



        If e.KeyCode = Keys.Enter Then

            Dim TipoDoc As String

            If rbboleta.Checked = True Then
                TipoDoc = "03"
            End If

            If rbfactura.Checked = True Then
                TipoDoc = "01"
            End If

            If rbnotap.Checked = True Then
                TipoDoc = "06"
            End If





            Dim TablaNroPedido As New DataTable

            TablaNroPedido = CAyuda.ListarDatos("SP_INSERT_NROPEDIDO", codempresa, txtNumDoc.Text, TipoDoc).Tables(0)
            If TablaNroPedido.Rows.Count > 0 Then
                txtNumPedido.Text = TablaNroPedido.Rows(0)(0).ToString()
                txtNroDespacho.Text = TablaNroPedido.Rows(0)(1).ToString()
            Else
                Exit Sub
            End If




            If Me.txtNumPedido.Text.Trim.Length = 0 Then
                Exit Sub
            End If
            Dim TablaCabPedido As New DataTable
            If Me.txtNumPedido.Text.Trim.Length = 0 Then
                Me.txtNumPedido.Text = "0"
            End If

            Try
                Dim TablaVerifPedido As New DataTable
                TablaVerifPedido = CAyuda.ListarDatos("NSP_VERIF_PEDIDO_VTA2", codempresa, txtNumPedido.Text.Trim).Tables(0)
                If CInt(TablaVerifPedido.Rows(0)(0)) > 0 Then
                    TablaCabPedido = CAyuda.ListarDatos("NSP_TRAER_PEDIDO_VTA2", codempresa, txtNumPedido.Text.Trim, CodUsuario, VCorrelVta).Tables(0)
                Else
                    TablaCabPedido = CAyuda.ListarDatos("NSP_TRAER_PEDIDO_VTA", codempresa, txtNumPedido.Text.Trim, CodUsuario, VCorrelVta).Tables(0)
                End If

                If TablaCabPedido.Rows(0)("ESTADO").ToString.Trim = "A" Then
                    MsgBox("DOCUMENTO ANULADO..", MsgBoxStyle.Exclamation, "")
                    Exit Sub
                End If
                txtCodCliente.Text = TablaCabPedido.Rows(0)("CODCLIENTE").ToString.Trim
                CboVended.SelectedValue = TablaCabPedido.Rows(0)("CODVENDEDOR").ToString.Trim
                CboPagador.SelectedValue = TablaCabPedido.Rows(0)("CODDEP").ToString.Trim
                dtpFecha.Value = TablaCabPedido.Rows(0)("FECPEDIDO")
                If TablaCabPedido.Rows(0)("CODTIPOPAGO").ToString.Trim = "000001" Then
                    Me.cbTipoPago.SelectedValue = "01"
                Else
                    Me.cbTipoPago.SelectedValue = TablaCabPedido.Rows(0)("CODTIPOPAGO").ToString.Trim

                End If
                CodTipoPrecio = TablaCabPedido.Rows(0)("CODTIPOPRE").ToString.Trim



                BuscarCliente(txtCodCliente.Text.Trim)

            Catch ex As Exception
                MsgBox("PROBLEMAS CON LOS DATOS :" + vbCrLf + ex.Message, MsgBoxStyle.Information)
            End Try
            Me.dtpFecha.Enabled = False
            Me.btnGuardar.Enabled = False
            'TablaTempPedidos = Obj.ListarDatos("NSP_LISTAR_PEDIDO", codempresa, txtNumPedido.Text).Tables(0)
            'CargarGridPed()
            CARGAR_GRID_TMP_DETALLE()
            FORMATO_GRID_TMP_DETALLE()

            cbTipoPago.Enabled = True

            GrpCab.Enabled = True







        End If




    End Sub

    Private Sub rbboleta_CheckedChanged(sender As Object, e As EventArgs) Handles rbboleta.CheckedChanged

    End Sub

    Private Sub rbfactura_CheckedChanged(sender As Object, e As EventArgs) Handles rbfactura.CheckedChanged

    End Sub

    Private Sub rbnotap_CheckedChanged(sender As Object, e As EventArgs) Handles rbnotap.CheckedChanged

    End Sub

    Private Sub txtNumDoc_TextChanged(sender As Object, e As EventArgs) Handles txtNumDoc.TextChanged

    End Sub
End Class
