Public Class FrmTrasladoDeMercaderia8
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents tarticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtdesarticulo As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnarticulo As System.Windows.Forms.Button
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents axcrt2 As AxCrystal.AxCrystalReport
    Friend WithEvents LblSubtotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tmovimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LblIGV As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ctipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents CboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents calmacenOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEjercicio As System.Windows.Forms.TextBox
    Friend WithEvents GrpIngresaDetalle As System.Windows.Forms.GroupBox
    Friend WithEvents PanelDatoGeneral As System.Windows.Forms.Panel
    Friend WithEvents TxtDoc1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDoc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbAlmacenDestino As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcendesc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DtGridDetalle As System.Windows.Forms.DataGrid
    Friend WithEvents LblValorVenta As System.Windows.Forms.Label
    Friend WithEvents ChkFlete As System.Windows.Forms.CheckBox
    Friend WithEvents txtFlete As System.Windows.Forms.TextBox
    Friend WithEvents BtnBusMovi As System.Windows.Forms.Button
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents LblFormaPag As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblCostAnt As System.Windows.Forms.Label
    Friend WithEvents ChkPercep As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDetrac As System.Windows.Forms.CheckBox
    Friend WithEvents TxtPercep As System.Windows.Forms.TextBox
    Friend WithEvents TxtDetrac As System.Windows.Forms.TextBox
    Friend WithEvents BtnMasDato As System.Windows.Forms.Button
    Friend WithEvents dtpfechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblValorVentaNIGV As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents LblValorVentaIGV As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTrasladoDeMercaderia))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GrpIngresaDetalle = New System.Windows.Forms.GroupBox
        Me.LblCostAnt = New System.Windows.Forms.Label
        Me.txtPorcendesc = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbPresentacion = New System.Windows.Forms.ComboBox
        Me.tarticulo = New System.Windows.Forms.TextBox
        Me.txtdesarticulo = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtCosto = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnarticulo = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.calmacenOrigen = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNREPORTE = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BtnMasDato = New System.Windows.Forms.Button
        Me.axcrt2 = New AxCrystal.AxCrystalReport
        Me.LblSubtotal = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tmovimiento = New System.Windows.Forms.TextBox
        Me.BtnBusMovi = New System.Windows.Forms.Button
        Me.DtGridDetalle = New System.Windows.Forms.DataGrid
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.LblIGV = New System.Windows.Forms.Label
        Me.PanelDatoGeneral = New System.Windows.Forms.Panel
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtEjercicio = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbotipo = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtDoc1 = New System.Windows.Forms.TextBox
        Me.TxtDoc2 = New System.Windows.Forms.TextBox
        Me.CboMoneda = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.ctipodoc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbProveedor = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbAlmacenDestino = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblFormaPag = New System.Windows.Forms.Label
        Me.CboFormaPago = New System.Windows.Forms.ComboBox
        Me.dtpfechaRecepcion = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtDesc = New System.Windows.Forms.TextBox
        Me.LblValorVenta = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.ChkFlete = New System.Windows.Forms.CheckBox
        Me.txtFlete = New System.Windows.Forms.TextBox
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.TxtPercep = New System.Windows.Forms.TextBox
        Me.ChkPercep = New System.Windows.Forms.CheckBox
        Me.TxtDetrac = New System.Windows.Forms.TextBox
        Me.ChkDetrac = New System.Windows.Forms.CheckBox
        Me.LblValorVentaNIGV = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.LblValorVentaIGV = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.GrpIngresaDetalle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.axcrt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DtGridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatoGeneral.SuspendLayout()
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
        Me.ImageList1.Images.SetKeyName(12, "")
        '
        'GrpIngresaDetalle
        '
        Me.GrpIngresaDetalle.Controls.Add(Me.LblCostAnt)
        Me.GrpIngresaDetalle.Controls.Add(Me.txtPorcendesc)
        Me.GrpIngresaDetalle.Controls.Add(Me.Label7)
        Me.GrpIngresaDetalle.Controls.Add(Me.cbPresentacion)
        Me.GrpIngresaDetalle.Controls.Add(Me.tarticulo)
        Me.GrpIngresaDetalle.Controls.Add(Me.txtdesarticulo)
        Me.GrpIngresaDetalle.Controls.Add(Me.txtcantidad)
        Me.GrpIngresaDetalle.Controls.Add(Me.Label23)
        Me.GrpIngresaDetalle.Controls.Add(Me.txtCosto)
        Me.GrpIngresaDetalle.Controls.Add(Me.Label16)
        Me.GrpIngresaDetalle.Controls.Add(Me.Label20)
        Me.GrpIngresaDetalle.Controls.Add(Me.btnarticulo)
        Me.GrpIngresaDetalle.Controls.Add(Me.Label10)
        Me.GrpIngresaDetalle.Controls.Add(Me.Label14)
        Me.GrpIngresaDetalle.Enabled = False
        Me.GrpIngresaDetalle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpIngresaDetalle.Location = New System.Drawing.Point(16, 402)
        Me.GrpIngresaDetalle.Name = "GrpIngresaDetalle"
        Me.GrpIngresaDetalle.Size = New System.Drawing.Size(648, 71)
        Me.GrpIngresaDetalle.TabIndex = 8
        Me.GrpIngresaDetalle.TabStop = False
        '
        'LblCostAnt
        '
        Me.LblCostAnt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LblCostAnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCostAnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostAnt.Location = New System.Drawing.Point(576, 17)
        Me.LblCostAnt.Name = "LblCostAnt"
        Me.LblCostAnt.Size = New System.Drawing.Size(60, 21)
        Me.LblCostAnt.TabIndex = 5
        Me.LblCostAnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPorcendesc
        '
        Me.txtPorcendesc.BackColor = System.Drawing.SystemColors.Window
        Me.txtPorcendesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPorcendesc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcendesc.Location = New System.Drawing.Point(574, 41)
        Me.txtPorcendesc.Name = "txtPorcendesc"
        Me.txtPorcendesc.Size = New System.Drawing.Size(44, 21)
        Me.txtPorcendesc.TabIndex = 13
        Me.txtPorcendesc.Text = "0"
        Me.txtPorcendesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Presentac :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPresentacion
        '
        Me.cbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPresentacion.Location = New System.Drawing.Point(62, 41)
        Me.cbPresentacion.Name = "cbPresentacion"
        Me.cbPresentacion.Size = New System.Drawing.Size(154, 21)
        Me.cbPresentacion.TabIndex = 7
        '
        'tarticulo
        '
        Me.tarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tarticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarticulo.Location = New System.Drawing.Point(52, 17)
        Me.tarticulo.Name = "tarticulo"
        Me.tarticulo.ReadOnly = True
        Me.tarticulo.Size = New System.Drawing.Size(112, 21)
        Me.tarticulo.TabIndex = 1
        Me.tarticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdesarticulo
        '
        Me.txtdesarticulo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtdesarticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtdesarticulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesarticulo.Location = New System.Drawing.Point(196, 17)
        Me.txtdesarticulo.Name = "txtdesarticulo"
        Me.txtdesarticulo.Size = New System.Drawing.Size(312, 21)
        Me.txtdesarticulo.TabIndex = 3
        Me.txtdesarticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtcantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(279, 43)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.ReadOnly = True
        Me.txtcantidad.Size = New System.Drawing.Size(68, 21)
        Me.txtcantidad.TabIndex = 9
        Me.txtcantidad.Text = "0"
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(216, 43)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 13)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Cant.Pres:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCosto
        '
        Me.txtCosto.BackColor = System.Drawing.SystemColors.Window
        Me.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Location = New System.Drawing.Point(402, 41)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(72, 21)
        Me.txtCosto.TabIndex = 11
        Me.txtCosto.Text = "0"
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(362, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Costo :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Articulo :"
        '
        'btnarticulo
        '
        Me.btnarticulo.Enabled = False
        Me.btnarticulo.ImageIndex = 5
        Me.btnarticulo.ImageList = Me.ImageList1
        Me.btnarticulo.Location = New System.Drawing.Point(164, 17)
        Me.btnarticulo.Name = "btnarticulo"
        Me.btnarticulo.Size = New System.Drawing.Size(30, 21)
        Me.btnarticulo.TabIndex = 2
        Me.btnarticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(518, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Desc% : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(522, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "CostoAnt:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calmacenOrigen
        '
        Me.calmacenOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.calmacenOrigen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calmacenOrigen.Location = New System.Drawing.Point(516, 88)
        Me.calmacenOrigen.Name = "calmacenOrigen"
        Me.calmacenOrigen.Size = New System.Drawing.Size(246, 22)
        Me.calmacenOrigen.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(422, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Almacen Origen :  "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotal
        '
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(792, 531)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(100, 29)
        Me.LblTotal.TabIndex = 23
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(792, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 154
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNREPORTE)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BtnMasDato)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 198)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(886, 38)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(124, 8)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(96, 25)
        Me.BTNNUEVO.TabIndex = 1
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGUARDAR.Enabled = False
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(236, 8)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(96, 25)
        Me.BTNGUARDAR.TabIndex = 2
        Me.BTNGUARDAR.Text = "  &Guardar"
        '
        'btnmodificar
        '
        Me.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodificar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.ImageIndex = 2
        Me.btnmodificar.ImageList = Me.ImageList1
        Me.btnmodificar.Location = New System.Drawing.Point(348, 8)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 25)
        Me.btnmodificar.TabIndex = 3
        Me.btnmodificar.Text = "   &Modificar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(462, 8)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(97, 25)
        Me.BTNELIMINAR.TabIndex = 4
        Me.BTNELIMINAR.Text = "Anular"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCELAR.Enabled = False
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(574, 8)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(95, 25)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "  &Cancelar"
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 11
        Me.BTNREPORTE.ImageList = Me.ImageList1
        Me.BTNREPORTE.Location = New System.Drawing.Point(680, 8)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(93, 25)
        Me.BTNREPORTE.TabIndex = 6
        Me.BTNREPORTE.Text = "  &Reporte"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCERRAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(788, 8)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(91, 25)
        Me.BTNCERRAR.TabIndex = 7
        Me.BTNCERRAR.Text = "&Salir"
        '
        'BtnMasDato
        '
        Me.BtnMasDato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMasDato.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMasDato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMasDato.ImageIndex = 12
        Me.BtnMasDato.ImageList = Me.ImageList1
        Me.BtnMasDato.Location = New System.Drawing.Point(12, 8)
        Me.BtnMasDato.Name = "BtnMasDato"
        Me.BtnMasDato.Size = New System.Drawing.Size(97, 25)
        Me.BtnMasDato.TabIndex = 0
        Me.BtnMasDato.Text = "Mas Datos"
        '
        'axcrt2
        '
        Me.axcrt2.Enabled = True
        Me.axcrt2.Location = New System.Drawing.Point(1030, 129)
        Me.axcrt2.Name = "axcrt2"
        Me.axcrt2.OcxState = CType(resources.GetObject("axcrt2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axcrt2.Size = New System.Drawing.Size(28, 28)
        Me.axcrt2.TabIndex = 6
        '
        'LblSubtotal
        '
        Me.LblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubtotal.Location = New System.Drawing.Point(350, 531)
        Me.LblSubtotal.Name = "LblSubtotal"
        Me.LblSubtotal.Size = New System.Drawing.Size(100, 29)
        Me.LblSubtotal.TabIndex = 19
        Me.LblSubtotal.Text = "0.00"
        Me.LblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.tmovimiento)
        Me.GroupBox6.Controls.Add(Me.BtnBusMovi)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(438, 40)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nro de Movimiento :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmovimiento
        '
        Me.tmovimiento.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tmovimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tmovimiento.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmovimiento.Location = New System.Drawing.Point(178, 13)
        Me.tmovimiento.Name = "tmovimiento"
        Me.tmovimiento.ReadOnly = True
        Me.tmovimiento.Size = New System.Drawing.Size(194, 27)
        Me.tmovimiento.TabIndex = 2
        Me.tmovimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnBusMovi
        '
        Me.BtnBusMovi.ImageIndex = 5
        Me.BtnBusMovi.ImageList = Me.ImageList1
        Me.BtnBusMovi.Location = New System.Drawing.Point(380, 10)
        Me.BtnBusMovi.Name = "BtnBusMovi"
        Me.BtnBusMovi.Size = New System.Drawing.Size(38, 28)
        Me.BtnBusMovi.TabIndex = 1
        Me.BtnBusMovi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtGridDetalle
        '
        Me.DtGridDetalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DtGridDetalle.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.DtGridDetalle.CaptionForeColor = System.Drawing.Color.Navy
        Me.DtGridDetalle.CaptionText = "[ENTER]  MODIFICAR ITEM                 [F3]  ELIMINAR ITEM"
        Me.DtGridDetalle.DataMember = ""
        Me.DtGridDetalle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtGridDetalle.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtGridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtGridDetalle.Location = New System.Drawing.Point(16, 238)
        Me.DtGridDetalle.Name = "DtGridDetalle"
        Me.DtGridDetalle.ReadOnly = True
        Me.DtGridDetalle.Size = New System.Drawing.Size(1075, 154)
        Me.DtGridDetalle.TabIndex = 5
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(712, 533)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 16)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "TOTAL: S/."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(510, 533)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 16)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "IGV: S/."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(240, 533)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 16)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "SUBTOTAL: S/."
        '
        'LblIGV
        '
        Me.LblIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIGV.Location = New System.Drawing.Point(568, 531)
        Me.LblIGV.Name = "LblIGV"
        Me.LblIGV.Size = New System.Drawing.Size(100, 29)
        Me.LblIGV.TabIndex = 21
        Me.LblIGV.Text = "0.00"
        Me.LblIGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelDatoGeneral
        '
        Me.PanelDatoGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDatoGeneral.Controls.Add(Me.cboPeriodo)
        Me.PanelDatoGeneral.Controls.Add(Me.Label22)
        Me.PanelDatoGeneral.Controls.Add(Me.txtEjercicio)
        Me.PanelDatoGeneral.Controls.Add(Me.Label4)
        Me.PanelDatoGeneral.Controls.Add(Me.Label2)
        Me.PanelDatoGeneral.Controls.Add(Me.cbotipo)
        Me.PanelDatoGeneral.Controls.Add(Me.Label9)
        Me.PanelDatoGeneral.Controls.Add(Me.Label15)
        Me.PanelDatoGeneral.Controls.Add(Me.TxtDoc1)
        Me.PanelDatoGeneral.Controls.Add(Me.TxtDoc2)
        Me.PanelDatoGeneral.Controls.Add(Me.CboMoneda)
        Me.PanelDatoGeneral.Controls.Add(Me.Label19)
        Me.PanelDatoGeneral.Controls.Add(Me.CheckBox1)
        Me.PanelDatoGeneral.Controls.Add(Me.dtpfecha)
        Me.PanelDatoGeneral.Controls.Add(Me.calmacenOrigen)
        Me.PanelDatoGeneral.Controls.Add(Me.Label6)
        Me.PanelDatoGeneral.Controls.Add(Me.Label17)
        Me.PanelDatoGeneral.Controls.Add(Me.ctipodoc)
        Me.PanelDatoGeneral.Controls.Add(Me.Label5)
        Me.PanelDatoGeneral.Controls.Add(Me.cbProveedor)
        Me.PanelDatoGeneral.Controls.Add(Me.Label12)
        Me.PanelDatoGeneral.Controls.Add(Me.cbAlmacenDestino)
        Me.PanelDatoGeneral.Controls.Add(Me.Label11)
        Me.PanelDatoGeneral.Controls.Add(Me.LblFormaPag)
        Me.PanelDatoGeneral.Controls.Add(Me.CboFormaPago)
        Me.PanelDatoGeneral.Controls.Add(Me.dtpfechaRecepcion)
        Me.PanelDatoGeneral.Controls.Add(Me.Label13)
        Me.PanelDatoGeneral.Enabled = False
        Me.PanelDatoGeneral.Location = New System.Drawing.Point(16, 48)
        Me.PanelDatoGeneral.Name = "PanelDatoGeneral"
        Me.PanelDatoGeneral.Size = New System.Drawing.Size(770, 148)
        Me.PanelDatoGeneral.TabIndex = 3
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(618, 62)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(136, 21)
        Me.cboPeriodo.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(564, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Periodo: "
        '
        'txtEjercicio
        '
        Me.txtEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEjercicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjercicio.Location = New System.Drawing.Point(516, 62)
        Me.txtEjercicio.MaxLength = 7
        Me.txtEjercicio.Name = "txtEjercicio"
        Me.txtEjercicio.Size = New System.Drawing.Size(40, 20)
        Me.txtEjercicio.TabIndex = 16
        Me.txtEjercicio.Text = "2010"
        Me.txtEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(452, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Ejercicio: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo Movimiento: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipo.Location = New System.Drawing.Point(110, 7)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(246, 22)
        Me.cbotipo.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(396, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Nro de Documento :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(570, 10)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "-"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDoc1
        '
        Me.TxtDoc1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDoc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc1.Location = New System.Drawing.Point(527, 8)
        Me.TxtDoc1.MaxLength = 3
        Me.TxtDoc1.Name = "TxtDoc1"
        Me.TxtDoc1.Size = New System.Drawing.Size(40, 20)
        Me.TxtDoc1.TabIndex = 3
        Me.TxtDoc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDoc2
        '
        Me.TxtDoc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDoc2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDoc2.Location = New System.Drawing.Point(583, 8)
        Me.TxtDoc2.MaxLength = 7
        Me.TxtDoc2.Name = "TxtDoc2"
        Me.TxtDoc2.Size = New System.Drawing.Size(69, 20)
        Me.TxtDoc2.TabIndex = 5
        Me.TxtDoc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CboMoneda
        '
        Me.CboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMoneda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMoneda.Location = New System.Drawing.Point(110, 91)
        Me.CboMoneda.Name = "CboMoneda"
        Me.CboMoneda.Size = New System.Drawing.Size(246, 22)
        Me.CboMoneda.TabIndex = 24
        Me.CboMoneda.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(46, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 14)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Moneda : "
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label19.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(660, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 24)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Incluido  IGV"
        Me.CheckBox1.Visible = False
        '
        'dtpfecha
        '
        Me.dtpfecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(516, 35)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(402, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Fecha Documento :"
        '
        'ctipodoc
        '
        Me.ctipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipodoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipodoc.Location = New System.Drawing.Point(110, 64)
        Me.ctipodoc.Name = "ctipodoc"
        Me.ctipodoc.Size = New System.Drawing.Size(246, 22)
        Me.ctipodoc.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 14)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Documento : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbProveedor
        '
        Me.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.Location = New System.Drawing.Point(110, 36)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(246, 22)
        Me.cbProveedor.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 39)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Proveedor: "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbAlmacenDestino
        '
        Me.cbAlmacenDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAlmacenDestino.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlmacenDestino.Location = New System.Drawing.Point(516, 114)
        Me.cbAlmacenDestino.Name = "cbAlmacenDestino"
        Me.cbAlmacenDestino.Size = New System.Drawing.Size(238, 22)
        Me.cbAlmacenDestino.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(410, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 14)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Almacen Destino: "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFormaPag
        '
        Me.LblFormaPag.AutoSize = True
        Me.LblFormaPag.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFormaPag.Location = New System.Drawing.Point(10, 122)
        Me.LblFormaPag.Name = "LblFormaPag"
        Me.LblFormaPag.Size = New System.Drawing.Size(95, 14)
        Me.LblFormaPag.TabIndex = 25
        Me.LblFormaPag.Text = "Forma de Pago: "
        Me.LblFormaPag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboFormaPago
        '
        Me.CboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormaPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFormaPago.Location = New System.Drawing.Point(110, 119)
        Me.CboFormaPago.Name = "CboFormaPago"
        Me.CboFormaPago.Size = New System.Drawing.Size(238, 22)
        Me.CboFormaPago.TabIndex = 26
        '
        'dtpfechaRecepcion
        '
        Me.dtpfechaRecepcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaRecepcion.Location = New System.Drawing.Point(674, 35)
        Me.dtpfechaRecepcion.Name = "dtpfechaRecepcion"
        Me.dtpfechaRecepcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpfechaRecepcion.Size = New System.Drawing.Size(80, 20)
        Me.dtpfechaRecepcion.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(612, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "F.Recep:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datos Generales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 533)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "DESC.%"
        '
        'TxtDesc
        '
        Me.TxtDesc.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDesc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(142, 529)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(68, 27)
        Me.TxtDesc.TabIndex = 17
        Me.TxtDesc.Text = "0"
        Me.TxtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblValorVenta
        '
        Me.LblValorVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValorVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValorVenta.Location = New System.Drawing.Point(886, 450)
        Me.LblValorVenta.Name = "LblValorVenta"
        Me.LblValorVenta.Size = New System.Drawing.Size(100, 23)
        Me.LblValorVenta.TabIndex = 7
        Me.LblValorVenta.Text = "0.00"
        Me.LblValorVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(740, 455)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(140, 16)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "VALOR VENTA: S/."
        '
        'ChkFlete
        '
        Me.ChkFlete.Location = New System.Drawing.Point(776, 476)
        Me.ChkFlete.Name = "ChkFlete"
        Me.ChkFlete.Size = New System.Drawing.Size(56, 24)
        Me.ChkFlete.TabIndex = 10
        Me.ChkFlete.Text = "Flete"
        Me.ChkFlete.Visible = False
        '
        'txtFlete
        '
        Me.txtFlete.BackColor = System.Drawing.SystemColors.Window
        Me.txtFlete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFlete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlete.Location = New System.Drawing.Point(780, 500)
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(36, 21)
        Me.txtFlete.TabIndex = 13
        Me.txtFlete.Text = "0"
        Me.txtFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFlete.Visible = False
        '
        'LblTitulo
        '
        Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(470, 6)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(316, 40)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "NUEVO TRASLADO"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTitulo.Visible = False
        '
        'TxtPercep
        '
        Me.TxtPercep.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPercep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPercep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPercep.Location = New System.Drawing.Point(922, 476)
        Me.TxtPercep.Name = "TxtPercep"
        Me.TxtPercep.Size = New System.Drawing.Size(64, 21)
        Me.TxtPercep.TabIndex = 12
        Me.TxtPercep.Text = "0"
        Me.TxtPercep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtPercep.Visible = False
        '
        'ChkPercep
        '
        Me.ChkPercep.Location = New System.Drawing.Point(838, 476)
        Me.ChkPercep.Name = "ChkPercep"
        Me.ChkPercep.Size = New System.Drawing.Size(82, 24)
        Me.ChkPercep.TabIndex = 11
        Me.ChkPercep.Text = "Percepcion"
        '
        'TxtDetrac
        '
        Me.TxtDetrac.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDetrac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDetrac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDetrac.Location = New System.Drawing.Point(922, 500)
        Me.TxtDetrac.Name = "TxtDetrac"
        Me.TxtDetrac.Size = New System.Drawing.Size(64, 21)
        Me.TxtDetrac.TabIndex = 15
        Me.TxtDetrac.Text = "0"
        Me.TxtDetrac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDetrac.Visible = False
        '
        'ChkDetrac
        '
        Me.ChkDetrac.Location = New System.Drawing.Point(838, 500)
        Me.ChkDetrac.Name = "ChkDetrac"
        Me.ChkDetrac.Size = New System.Drawing.Size(82, 24)
        Me.ChkDetrac.TabIndex = 14
        Me.ChkDetrac.Text = "Detraccion"
        '
        'LblValorVentaNIGV
        '
        Me.LblValorVentaNIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValorVentaNIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValorVentaNIGV.Location = New System.Drawing.Point(886, 421)
        Me.LblValorVentaNIGV.Name = "LblValorVentaNIGV"
        Me.LblValorVentaNIGV.Size = New System.Drawing.Size(100, 23)
        Me.LblValorVentaNIGV.TabIndex = 162
        Me.LblValorVentaNIGV.Text = "0.00"
        Me.LblValorVentaNIGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(696, 428)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(184, 16)
        Me.Label28.TabIndex = 161
        Me.Label28.Text = "VALOR VENTA NIGV : S/."
        '
        'LblValorVentaIGV
        '
        Me.LblValorVentaIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblValorVentaIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValorVentaIGV.Location = New System.Drawing.Point(886, 392)
        Me.LblValorVentaIGV.Name = "LblValorVentaIGV"
        Me.LblValorVentaIGV.Size = New System.Drawing.Size(100, 23)
        Me.LblValorVentaIGV.TabIndex = 160
        Me.LblValorVentaIGV.Text = "0.00"
        Me.LblValorVentaIGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(707, 399)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(173, 16)
        Me.Label18.TabIndex = 159
        Me.Label18.Text = "VALOR VENTA IGV : S/."
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(810, 590)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaIni.TabIndex = 163
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(820, 628)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaFin.TabIndex = 166
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(770, 628)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 13)
        Me.Label32.TabIndex = 165
        Me.Label32.Text = "Hasta : "
        Me.Label32.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(766, 594)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 13)
        Me.Label35.TabIndex = 164
        Me.Label35.Text = "Desde :"
        Me.Label35.Visible = False
        '
        'FrmTrasladoDeMercaderia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1365, 684)
        Me.Controls.Add(Me.DtFechaIni)
        Me.Controls.Add(Me.DtFechaFin)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.LblValorVentaNIGV)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.LblValorVentaIGV)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtDetrac)
        Me.Controls.Add(Me.TxtPercep)
        Me.Controls.Add(Me.txtFlete)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ChkDetrac)
        Me.Controls.Add(Me.ChkPercep)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.ChkFlete)
        Me.Controls.Add(Me.LblValorVenta)
        Me.Controls.Add(Me.PanelDatoGeneral)
        Me.Controls.Add(Me.GrpIngresaDetalle)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.axcrt2)
        Me.Controls.Add(Me.LblSubtotal)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.DtGridDetalle)
        Me.Controls.Add(Me.LblIGV)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmTrasladoDeMercaderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traslado De Mercaderia"
        Me.GrpIngresaDetalle.ResumeLayout(False)
        Me.GrpIngresaDetalle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.axcrt2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DtGridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatoGeneral.ResumeLayout(False)
        Me.PanelDatoGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "VARIABLES"
    'Private Obj As New ClsInterface
    Private Clsayu As New ClsAyuda
    Private CORREL As Integer
    Private TABLE_DETALLE As New DataTable
    Private OBS As String = ""
    Public AUTORIZANTE As String = ""
    Public RESPONSABLE As String = ""
    Public DATOTRANS As String = ""
    Private ITEMMODIF As Boolean
    Private MODIFICAR As Boolean
    Private TRANS As Boolean
    Dim MoviCab, Movidet As String




    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""
    Friend WithEvents ckPercepcion2 As System.Windows.Forms.CheckBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ckNPTienda As System.Windows.Forms.CheckBox
    Dim Todo_Cate As Int16
    Dim rand As Integer


#End Region

#Region "RESTRICCIONES-KEYPRESS"

    Private Sub CajaTexto_SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDoc1.KeyPress, TxtDoc2.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress, TxtDesc.KeyPress, txtCosto.KeyPress, txtPorcendesc.KeyPress, txtFlete.KeyPress
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

#Region "FUNCIONES"


    Private Sub HabilitaBotones(ByVal Valor As Boolean)
        BtnMasDato.Enabled = Valor
        BTNNUEVO.Enabled = Not Valor
        BTNGUARDAR.Enabled = Valor
        btnmodificar.Enabled = Not Valor
        BTNELIMINAR.Enabled = Not Valor
    End Sub


    Private Sub BUSCOSTOANTERIO_X_PRESENT()
        ' BUSQUEDA  DE COSTO ANTERIOR  POR PRENSENTACION 
        Dim TABLE_COSTUND As New DataTable
        Dim TABLE_CANT_PRESENT As New DataTable
        Dim CostoBase, CantPresent As Double
        TABLE_COSTUND = TmpListarDatos("NSP_BUSCAR_ARTI_EN_ALMAC   '" & codempresa & "','" & tarticulo.Text.Trim & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "'")
        TABLE_CANT_PRESENT = TmpListarDatos("Nsp_sele_factorxpresentacion  '" & cbPresentacion.SelectedValue.ToString.Trim & "','" & codempresa & "'")
        CostoBase = TABLE_COSTUND.Rows(0)("COSTBASEU").ToString.Trim
        If TABLE_CANT_PRESENT.Rows.Count > 0 Then
            CantPresent = TABLE_CANT_PRESENT.Rows(0)("FACTOR").ToString.Trim
        Else
            MsgBox("- EL ARTICULO NO TIENE PRESENTACI�N.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        LblCostAnt.Text = Format((CostoBase * CantPresent), "#######0.00")

    End Sub


    Private Sub ActTipoMovimiento()
        Dim TABLE_TIPO As New DataTable
        TABLE_TIPO = TmpListarDatos("NSP_BUSC_TIPOMOVI_X_COD  '" & codempresa & "','" & IIf(IsNothing(cbotipo.SelectedValue), "", cbotipo.SelectedValue) & "'")


        If TABLE_TIPO.Rows.Count > 0 Then
            If (TABLE_TIPO.Rows(0)("PROVEE").ToString.Trim) = True Then
                cbProveedor.Enabled = True
            Else
                cbProveedor.Enabled = False
            End If

            If (TABLE_TIPO.Rows(0)("trans_origen").ToString.Trim) = True Then
                cbAlmacenDestino.Enabled = True
            Else
                cbAlmacenDestino.Enabled = False
                cbAlmacenDestino.SelectedValue = (TABLE_TIPO.Rows(0)("cod_almacen_destino").ToString.Trim)
            End If

            If (TABLE_TIPO.Rows(0)("PAGOCRED").ToString.Trim) = True Then
                CboFormaPago.Visible = True
                LblFormaPag.Visible = True
            Else
                CboFormaPago.Visible = False
                LblFormaPag.Visible = False
            End If

            If (TABLE_TIPO.Rows(0)("VALOR").ToString.Trim) = True Then
                Label16.Visible = True
                txtCosto.Visible = True
                Label10.Visible = True
                txtPorcendesc.Visible = True
                Label8.Visible = True
                TxtDesc.Visible = True
                Label21.Visible = True
                LblSubtotal.Visible = True
                Label25.Visible = True
                LblIGV.Visible = True
                Label27.Visible = True
                LblTotal.Visible = True
                Label24.Visible = True
                LblValorVenta.Visible = True
            Else
                Label16.Visible = False
                txtCosto.Visible = False
                Label10.Visible = False
                txtPorcendesc.Visible = False
                Label8.Visible = False
                TxtDesc.Visible = False
                Label21.Visible = False
                LblSubtotal.Visible = False
                Label25.Visible = False
                LblIGV.Visible = False
                Label27.Visible = False
                LblTotal.Visible = False
                Label24.Visible = False
                LblValorVenta.Visible = False

            End If


            TRANS = (TABLE_TIPO.Rows(0)("TRANS").ToString.Trim)

            If (TABLE_TIPO.Rows(0)("trans_destino").ToString.Trim) = True Then
                cbAlmacenDestino.Enabled = True
            Else
                cbAlmacenDestino.Enabled = False
                cbAlmacenDestino.SelectedValue = (TABLE_TIPO.Rows(0)("cod_almacen_destino").ToString.Trim)
            End If

            If (TABLE_TIPO.Rows(0)("trans_origen").ToString.Trim) = True Then
                calmacenOrigen.Enabled = True
            Else
                calmacenOrigen.Enabled = False
                calmacenOrigen.SelectedValue = (TABLE_TIPO.Rows(0)("cod_almacen_origen").ToString.Trim)
            End If





        End If
    End Sub
    Private Sub FormatoGrid()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_DETALLE.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 9.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim Datacolum1 As New DataGridTextBoxColumn
        With Datacolum1
            .MappingName = "ITEM"
            .HeaderText = "ITEM"
            .NullText = ""
            .Width = 25
        End With
        Dim Datacolum2 As New DataGridTextBoxColumn
        With Datacolum2
            .MappingName = "CDARTICULO"
            .HeaderText = "CODIGO"
            .NullText = ""
            .Width = 50
        End With
        Dim Datacolum3 As New DataGridTextBoxColumn
        With Datacolum3
            .MappingName = "DESARTI"
            .HeaderText = "DESCRIPCION"
            .NullText = ""
            .Width = 250
        End With
        Dim Datacolum4 As New DataGridTextBoxColumn
        With Datacolum4
            .MappingName = "CODPRES"
            .HeaderText = "CODPRES"
            .NullText = ""
            .Width = 0
        End With
        Dim Datacolum5 As New DataGridTextBoxColumn
        With Datacolum5
            .MappingName = "DESPRES"
            .HeaderText = "PRESENTACION"
            .NullText = ""
            .Width = 150
        End With
        Dim Datacolum6 As New DataGridTextBoxColumn
        With Datacolum6
            .MappingName = "CANTIDAD"
            .HeaderText = "CANTIDAD"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .NullText = 0
            .Format = "#######0.00"

        End With
        Dim Datacolum7 As New DataGridTextBoxColumn
        With Datacolum7
            .MappingName = "COSTOBAS"
            .HeaderText = "COSTO"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .NullText = 0
            .Format = "#######0.00"
        End With
        Dim Datacolum8 As New DataGridTextBoxColumn
        With Datacolum8
            .MappingName = "VALOR_VENTA"
            .HeaderText = "IMPORTE"
            .Alignment = HorizontalAlignment.Right
            .Width = 75
            .NullText = 0
            .Format = "#######0.00"
        End With
        Dim Datacolum9 As New DataGridTextBoxColumn
        With Datacolum9
            .MappingName = "IGV"
            .HeaderText = "IGV"
            .Width = 75
            .NullText = 0
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
        End With

        Dim Datacolum10 As New DataGridTextBoxColumn
        With Datacolum10
            .MappingName = "MONTODESCBAS"
            .HeaderText = "DESC"
            .Width = 75
            .NullText = 0
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
        End With

        Dim Datacolum11 As New DataGridTextBoxColumn
        With Datacolum11
            .MappingName = "SUBTOTBAS"
            .HeaderText = "VALOR VENTA"
            .Width = 100
            .Alignment = HorizontalAlignment.Right
            .NullText = 0
            .Format = "#######0.00"
        End With
        DtGridDetalle.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Datacolum1, Datacolum2, Datacolum3, Datacolum4, Datacolum5, Datacolum6, Datacolum7, Datacolum8, Datacolum9, Datacolum10, Datacolum11})
        DtGridDetalle.TableStyles.Add(TableStyle1)


    End Sub


    Private Sub CargarGridDetalle()

        TABLE_DETALLE = TmpListarDatos("NSP_TRAER_TMP_MOVIDET   '" & codempresa & "','" & CORREL & "'")
        DtGridDetalle.DataSource = TABLE_DETALLE
        Dim PORCDESC, VALORVENTA, SUBTOTAL, IGVTOTAL, VALORVENTAIGV, VALORVENTANIGV As Double
        For i As Integer = 0 To TABLE_DETALLE.Rows.Count - 1
            SUBTOTAL = CDbl(TABLE_DETALLE.Rows(i)("SUBTOTBAS")) + SUBTOTAL
            VALORVENTA = CDbl(TABLE_DETALLE.Rows(i)("SUBTOTBAS")) + VALORVENTA
            IGVTOTAL = CDbl(TABLE_DETALLE.Rows(i)("PORCIGV")) + IGVTOTAL

            Dim ESTADO_IGV As String
            Dim TB_IGV_ARTICULO As DataTable
            TB_IGV_ARTICULO = TmpListarDatos("NSP_IGV_ARTICULO '" & codempresa & "','" & TABLE_DETALLE.Rows(i)("CDARTICULO") & "'")

            If TB_IGV_ARTICULO.Rows.Count > 0 Then
                ESTADO_IGV = TB_IGV_ARTICULO.Rows(0)(0).ToString()
                If ESTADO_IGV = "IGV" Then
                    VALORVENTAIGV = CDbl(TABLE_DETALLE.Rows(i)("SUBTOTBAS")) + VALORVENTAIGV

                Else
                    VALORVENTANIGV = CDbl(TABLE_DETALLE.Rows(i)("SUBTOTBAS")) + VALORVENTANIGV
                End If
            End If

        Next


        If TABLE_DETALLE.Rows.Count > 0 Then

            LblValorVentaIGV.Text = Format(VALORVENTAIGV, "#######0.00")
            LblValorVentaNIGV.Text = Format(VALORVENTANIGV, "#######0.00")

            LblValorVenta.Text = Format(VALORVENTA, "#######0.00")
            LblSubtotal.Text = Format(SUBTOTAL, "#######0.00")
            ' LblIGV.Text = Format((SUBTOTAL * (PORCIGV) / 100), "#######0.00")
            LblIGV.Text = Format(IGVTOTAL, "#######0.00")

            LblTotal.Text = Format(CDbl(LblSubtotal.Text) + CDbl(LblIGV.Text), "#######0.00")
            PORCDESC = CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)
            If CDbl((PORCDESC * 100)) = 0 Then
                TxtDesc.Text = Format(0, "#######0.00")
            Else
                TxtDesc.Text = Format(CDbl((PORCDESC * 100) / CDbl(LblValorVenta.Text)), "#######0.00")
            End If
            cbAlmacenDestino.Enabled = False
        Else
            LblValorVenta.Text = Format(0, "#######0.00")
            LblSubtotal.Text = Format(0, "#######0.00")
            LblIGV.Text = Format(0, "#######0.00")
            LblTotal.Text = Format(0, "#######0.00")
            PORCDESC = Format(0, "#######0.00")
            TxtDesc.Text = Format(0, "#######0.00")
            cbAlmacenDestino.Enabled = True
        End If

        'BTNGUARDAR.Enabled = True
    End Sub

    Private Sub TRAER_NROMOV()
        Dim dt As DataTable
        If IsNothing(cbotipo.SelectedValue) Then
            cbotipo.SelectedIndex = 0
        End If
        dt = CAyuda.ListarDatos("sp_select_movi", codempresa, cbotipo.SelectedValue.ToString()).Tables(0)
        If dt.Rows.Count > 0 Then
            Me.tmovimiento.Text = dt.Rows(0)(0)
        Else
            MessageBox.Show("- SELECCIONE UN TIPO DE MOVIMIENTO.", "NARSISTEMAS", MessageBoxButtons.OK)

        End If


    End Sub

    Private Sub OBTENERCORRELATIVO()
        Dim SQL As String
        Dim DS As New DataSet
        SQL = "ObtenerCorrelInventario '" & CodUsuario & "'"
        DS = TmpListarDataset(SQL)
        CORREL = DS.Tables(0).Rows(0)(0)
    End Sub
    Private Sub Cargacombos()
        CAyuda.CargarDataCombo(Me.calmacenOrigen, "USP_LLENAR_ALMACEN   '" & codempresa & "'", "Codigo", "Descripcion")

        CAyuda.CargarDataCombo(Me.cbAlmacenDestino, "USP_LLENAR_ALMACEN   '" & codempresa & "'", "Codigo", "Descripcion")
        'CAyuda.CargarDataCombo(ctipodocRef, "nsp_sele_tipodoc '" & CodEmpresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(cbProveedor, "Nsp_sel_Proveedor2 '" & codempresa & "'", "codproveedor", "desproveedor")

        'CAyuda.CargarDataCombo(cbotipo, "Nsp_Sele_tipomovi '" & CodEmpresa & "'", "C�digo", "Descripci�n")
        CAyuda.CargarDataCombo(cbotipo, "SelecTIPOMOVIxUserId '" & codempresa & "','" & CodUsuario & "','2' ", "C�digo", "Descripci�n")

        '--------CargarDocumento por TipoDe movimiento ----------
        '  CAyuda.CargarDataCombo(ctipodoc, "nsp_sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(ctipodoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")


        'CAyuda.CargarDataCombo(ctipodoc, "SelecTIPODOCxTipoMov '" & codempresa & "','" & IIf(IsNothing(cbotipo.SelectedValue), "", cbotipo.SelectedValue) & "'", "Codigo", "Descripcion")

        'CAyuda.CargarDataCombo(cbopunto, "Nsp_Sele_tdaptoventa2 '" & CodEmpresa & "'", "nroptovta1", "desptovta1")
        CAyuda.CargarDataCombo(CboFormaPago, "Nsp_sel_TipCredF '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(CboMoneda, "Nsl_selec_moneda '" & codempresa & "'", "Codigo", "Descripcion")

        cboPeriodo.Items.Add("ENERO")
        cboPeriodo.Items.Add("FEBRERO")
        cboPeriodo.Items.Add("MARZO")
        cboPeriodo.Items.Add("ABRIL")
        cboPeriodo.Items.Add("MAYO")
        cboPeriodo.Items.Add("JUNIO")
        cboPeriodo.Items.Add("JULIO")
        cboPeriodo.Items.Add("AGOSTO")
        cboPeriodo.Items.Add("SEPTIEMBRE")
        cboPeriodo.Items.Add("OCTUBRE")
        cboPeriodo.Items.Add("NOVIEMBRE")
        cboPeriodo.Items.Add("DICIEMBRE")
        cboPeriodo.SelectedIndex = Date.Now.Month - 1

    End Sub

    Private Sub Habilitar(ByVal valor As Boolean)
        GrpIngresaDetalle.Enabled = valor
        PanelDatoGeneral.Enabled = valor
        btnarticulo.Enabled = valor
        BTNGUARDAR.Enabled = valor
        BTNCANCELAR.Enabled = valor
        LblTitulo.Visible = valor
        DtGridDetalle.Enabled = valor

    End Sub
    Private Sub LIMPIAR()
        TxtDoc1.Text = ""
        TxtDoc2.Text = ""
        tarticulo.Text = ""
        txtcantidad.Text = "0"
        txtCosto.Text = "0"
        txtEjercicio.Text = Date.Now.Year
        txtPorcendesc.Text = "0"
        TxtPercep.Text = "0.00"
        txtFlete.Text = "0.00"
        TxtDetrac.Text = "0.00"
        LblValorVentaIGV.Text = "0.00"

        CORREL = 0
        MODIFICAR = False
        TABLE_DETALLE.Rows.Clear()
        CargarGridDetalle()
        calmacenOrigen.Enabled = True
        cbotipo.Enabled = True
        cbProveedor.Enabled = True
        ctipodoc.Enabled = True
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WIN_KEYDOWN As Integer = &H100
        Const WIN_KEYSYSTEM As Integer = &H104
        If (MSG.Msg = WIN_KEYDOWN) Or (MSG.Msg = WIN_KEYSYSTEM) Then
            Select Case KeyData
                Case Keys.F3
                    If TABLE_DETALLE.Rows.Count > 0 Then
                        If DtGridDetalle.Focus = True Then
                            TmpInsertDatos("NSP_ELIM_ITEM_TMPMOVIDET  '" & codempresa & "','" & CORREL & "','" & DtGridDetalle.Item(DtGridDetalle.CurrentRowIndex, 0) & "'")
                            CargarGridDetalle()
                        End If
                    End If
                Case Keys.Enter
                    If TABLE_DETALLE.Rows.Count > 0 Then
                        If DtGridDetalle.Focus = True Then

                            tarticulo.Text = DtGridDetalle.Item(DtGridDetalle.CurrentRowIndex, 1)
                            Dim TablaComboPresent As New DataTable
                            TablaComboPresent = CAyuda.ListarDatos("NSP_LISTAR_PRESENT_ARTI_2", codempresa, tarticulo.Text.Trim, "").Tables(0)
                            Me.cbPresentacion.DisplayMember = "DESPRES"
                            Me.cbPresentacion.ValueMember = "CODPRES"
                            Me.cbPresentacion.DataSource = TablaComboPresent

                            txtdesarticulo.Text = DtGridDetalle.Item(DtGridDetalle.CurrentRowIndex, 2)
                            cbPresentacion.SelectedValue = DtGridDetalle.Item(DtGridDetalle.CurrentRowIndex, 3)
                            txtcantidad.Text = Format(CDbl(DtGridDetalle.Item(DtGridDetalle.CurrentRowIndex, 5)), "#######0.00")
                            txtCosto.Text = Format(CDbl(DtGridDetalle.Item(DtGridDetalle.CurrentRowIndex, 6)), "#######0.00")
                            txtPorcendesc.Text = Format(CDbl(DtGridDetalle.Item(DtGridDetalle.CurrentRowIndex, 8)), "#######0.00")
                            ITEMMODIF = True
                        End If
                    End If
            End Select

        End If

    End Function
#End Region
    Public MENU_ As String


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub FrmIngresoDeMercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()

        Cargacombos()

        Call BOTONES(True, False, False, False, True)





        Me.dtpfecha.Value = Format(vFechaActual, "dd/MM/yyyy")
        Me.dtpfechaRecepcion.Value = Format(vFechaActual, "dd/MM/yyyy")


        If MENU_ = "Movimiento de Traslado C" Then
            BTNNUEVO.Enabled = False
        End If



        Dim dt2 As New DataTable

        dt2 = CAyuda.ListarDatos("SELEC_CIERRE_MES", codempresa).Tables(0)
        Dim A�O As String
        Dim MES As String
        A�O = dt2.Rows(0)(0)
        MES = dt2.Rows(0)(1)


        Dim Fecharf As Date

        Dim Table_Correlativo2 As DataTable
        Table_Correlativo2 = CAyuda.ListarDatos("SP_EXTRADIA", A�O, MES).Tables(0)
        DtFechaIni.Value = CDate(Table_Correlativo2.Rows(0)(0).ToString)

        Fecharf = DateAdd("d", +1, DtFechaIni.Value)

        DtFechaIni.Value = Fecharf
        DtFechaFin.Value = CType(CAyuda.ListarDatos("SP_FECHA_AUMENTO_DIAS", CANT_DIAS_ADE).Tables(0).Rows(0)(0), Date)

        BtnMasDato.Enabled = False
        BTNNUEVO.Enabled = False
        BTNGUARDAR.Enabled = False
        btnmodificar.Enabled = False
        BTNELIMINAR.Enabled = False


    End Sub
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        btnmodificar.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        BtnBusMovi.Enabled = BUSCAR
    End Sub



    Sub Procesar_Saldo(ByVal fechaCierre As String, ByVal CDALMACEN As String)
        Dim meses As Integer
        Dim Fecinicial, Fecfinal As String
        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String

        TmpInsertDatos("Delete from TMp_kardex WHERE CORREL =" & rand)


        If CierreIgual = True Then
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")

            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "'")
                End If
            Next

        Else

            meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
            ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            'TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0,'" & rand & "'")

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
                Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct



                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1")
                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTAS '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "'")
                End If
            Next

            ''SELECCIONO LOS INGRESOS Y SALIDAS DEL RANGO DEL KARDEX
            MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
            MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy")

            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")
            '' SELECCIONO LAS VENTAS
            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''Registros del Hist�rico
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentD = "VENTD" & Anio & MesAct
                VentaC = "VENTC" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next
        End If

        'TmpInsertDatos("UPDATE TMp_kardex SET SALDOFIN=0,COMPRASF=0,INGAJUSTEF=0,INGTRANSFF=0,INGOTROSF=0,VENTASF=0,SALAJUSTEF=0,SALTRANSFF=0,SALOTROSF=0,SALDOFINF=0 WHERE SALDOFIN IS NULL AND CODEMPRESA='" & codempresa & "'")

        If CierreIgual = True Then
            INSERTCIERREALDIA(MstrFechaFinRec, CDALMACEN)
            MstrFechaIni = Format(Me.DtFechaIni.Value, "dd/MM/yyyy")
        Else
            'INSERTO SALDO INICIAL
            INSERTCIERREALDIA(fechaCierre, CDALMACEN)
        End If

        TmpInsertDatos("DELETE FROM TMP_SUMKARDEX2 WHERE CORREL = '" & rand & "'")
        TmpInsertDatos("INSERT INTO TMP_SUMKARDEX2 (CORREL,CDALMA,CDG01,CDARTI,STOCKINI,STOCKREC,COMPRAS,INGAJUSTE,INGTRANSF, INGOTROS,VENTAS,SALAJUSTE,SALTRANSF,SALOTROS,SALDOFIN, COMPRASF,INGAJUSTEF,INGTRANSFF, INGOTROSF,VENTASF,SALAJUSTEF,SALTRANSFF,SALOTROSF,SALDOFINF)" & "select  " & rand & ",cdalma,cdg01,cdarti,sum(stockini) as stockini,0 as stockrec,sum(compras)as compras, sum(INGAJUSTE) as IngAjuste,sum(INGTRANSF) as INGTransf,sum(INGOTROS) as INGotros, sum(VENTAS) as Ventas,sum(SALAJUSTE)as Salajuste,sum(SALTRANSF) as Saltransf, sum(sALOTROS) as Salotros,0 AS SALDOFIN, sum(comprasf)as comprasF,  sum(INGAJUSTEf) as IngAjusteF,sum(INGTRANSFF) as INGTransfF,sum(INGOTROSF) as INGotrosF, sum(VENTASF) as VentasF,sum(SALAJUSTEF)as SalajusteF,sum(SALTRANSFF) as SaltransfF, sum(SalotrosF) As SalotrosF ,0 AS SALDOFINF from TMp_kardex WHERE CORREL= " & rand & "  group by cdalma,cdarti,CDG01")
        TmpInsertDatos("DELETE FROM KARDEX_TMP WHERE CORREL='" & rand & "'")
        'TmpInsertDatos("INSERT INTO KARDEX_TMP (CDALMA,DSALMA,CDARTI,DSARTI,CDG01,DSG01,SALDOFIN,CANTINGRC,CANTINGRO,CANTSALIV,CANTSALIO,COSTO)  SELECT T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA , SUM(T.STOCKINI- T.VENTASF- T.SALAJUSTEF - T.SALTRANSFF - T.SALOTROSF + T.COMPRASF + T.INGAJUSTEF + T.INGTRANSFF + T.INGOTROSF) AS SALDOINIF, SUM(T.COMPRAS) AS COMPRAS,SUM(T.INGAJUSTE + T.INGTRANSF + T.INGOTROS) AS INGOTROS,SUM(T.VENTAS) AS VENTAS, SUM(T.SALAJUSTE + T.SALTRANSF + T.SALOTROS) As SALOTROS,AR.COSTOBAS FROM TMP_SUMKARDEX2 T   INNER  JOIN LINEA G ON T.CDG01 = G.CODLINEA  AND G.CODEMPRESA='" & codempresa & "' INNER JOIN  ARTICULO AR  ON T.CDARTI=AR.CODARTI  AND AR.CODEMPRESA='" & codempresa & "' INNER JOIN  ALMACEN A  ON  T.CDALMA = A.CODALMACEN  AND A.CODEMPRESA='" & codempresa & "' GROUP BY T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA,AR.COSTOBAS")

        TmpInsertDatos("SP_INS_KARDEX_TMPXARTI '" & codempresa & "','" & rand & "','" & tarticulo.Text & "'")


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

    Private Sub INSERTCIERREALDIA(ByVal FechaCierre As Date, ByVal ALMACEN As String)
        'If Todo_Cate = 1 Then
        '    TmpInsertDatos("INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS )  " & _
        '                  "SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,CIERRE_MES_INVENTARIO.ARTICULO,CIERRE_MES_INVENTARIO.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0 " & _
        '                  "FROM CIERRE_MES_INVENTARIO,ARTICULO WHERE CIERRE_MES_INVENTARIO.ARTICULO=ARTICULO.CODARTI AND ARTICULO.FORMU = 0 AND CIERRE_MES_INVENTARIO.ALMACEN ='" & Trim(ALMACEN) & "'  AND FECHA='" & FechaCierre & "'")
        'Else
        '    TmpInsertDatos(" INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS ) " & _
        '                     " SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,CIERRE_MES_INVENTARIO.ARTICULO,CIERRE_MES_INVENTARIO.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0 " & _
        '                     " FROM CIERRE_MES_INVENTARIO,ARTICULO WHERE  ARTICULO.FORMU = 0  AND  CIERRE_MES_INVENTARIO.ARTICULO=ARTICULO.CODARTI AND ARTICULO.CODLINEA IN(" & CadenaCateg & ")  AND CIERRE_MES_INVENTARIO.ALMACEN ='" & Trim(ALMACEN) & "'  AND FECHA='" & Format(FechaCierre, "dd/MM/yyyy") & "'")
        'End If
    End Sub





    Private Sub btnarticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarticulo.Click


        If cbAlmacenDestino.Enabled = True Then
            If cbAlmacenDestino.SelectedValue.ToString.Trim = calmacenOrigen.SelectedValue.ToString.Trim Then
                MsgBox("EL ALMACEN ORIGEN NO PUEDE SER IGUAL AL ALMACEN DESTINO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If
        End If

        Dim TABLEART As DataTable
        TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_MERC  '" & codempresa & "','" & CDZONA & "','" & 0 & "','" & Trim(calmacenOrigen.SelectedValue) & "'")
        If TABLEART.Rows.Count > 0 Then
            'Dim ConsArticulo As New FrmArticuloTrasladoBusq
            'ConsArticulo.CDALMACEN = Trim(calmacenOrigen.SelectedValue)
            'ConsArticulo.Ingreso = Me
            'ConsArticulo.ShowDialog()
        Else
            MsgBox("EL ALMACEN NO TIENE ARTICULOS")
            Exit Sub
        End If




        Dim TablaComboPresent As New DataTable
        TablaComboPresent = CAyuda.ListarDatos("NSP_LISTAR_PRESENT_ARTI_INV", codempresa, tarticulo.Text.Trim).Tables(0)
        If TablaComboPresent.Rows.Count = 0 Then
            Exit Sub
        End If
        Me.cbPresentacion.DisplayMember = "DESPRES"
        Me.cbPresentacion.ValueMember = "CODPRES"
        Me.cbPresentacion.DataSource = TablaComboPresent
        If Len(Me.tarticulo.Text.Trim) > 0 Then
            Me.cbPresentacion.Focus()
        End If
        'kathy = True
        BUSCOSTOANTERIO_X_PRESENT()
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Habilitar(True)
        LIMPIAR()
        OBTENERCORRELATIVO()
        TRAER_NROMOV()
        CargarGridDetalle()
        FormatoGrid()
        ActTipoMovimiento()
        Call BOTONES(False, True, False, False, False)
        Limp_Persepcion()
    End Sub


    Private Sub txtCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPorcendesc.Focus()
        End If
    End Sub
    Private Sub txtCosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCosto.TextChanged
    End Sub

    Private Sub cbotipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotipo.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.calmacenOrigen.Focus()
        End If

    End Sub
    Private Sub cbotipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipo.SelectedIndexChanged
        If PanelDatoGeneral.Enabled = True Then
            TRAER_NROMOV()
            ActTipoMovimiento()
            'CAyuda.CargarDataCombo(ctipodoc, "SelecTIPODOCxTipoMov '" & codempresa & "','" & CStr(cbotipo.SelectedValue).Trim & "'", "Codigo", "Descripcion")
            'CAyuda.CargarDataCombo(calmacen, "SelecALMACENxTipoMov   '" & codempresa & "','" & CStr(cbotipo.SelectedValue).Trim & "'", "Codigo", "Descripcion")
        End If
    End Sub

    Private Sub txtcantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCosto.Visible = True Then
                txtCosto.Focus()
            Else
                Agregar_Item()
            End If

        End If
    End Sub
    Private Sub txtPorcendesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPorcendesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Agregar_Item()
        End If
    End Sub

    Private Sub Agregar_Item()
        Dim OPC_TRANSC As Integer = 1

        If TxtDoc1.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL NUMERO DE DOCUMENTO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            TxtDoc1.Focus()
            Exit Sub
        End If
        If TxtDoc2.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL NUMERO DE DOCUMENTO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            TxtDoc2.Focus()
            Exit Sub
        End If

        If tarticulo.Text = "" Then
            MsgBox("Falta Ingresar el codigo del Articulo...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            tarticulo.Focus()
            Exit Sub
        End If
        If txtcantidad.Text = "" Then
            MsgBox("Falta Ingresar la Cantidad...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            txtcantidad.Focus()
            Exit Sub
        End If


        If CInt(txtcantidad.Text) = 0 Then
            MsgBox("la cantidad tiene q ser mayor a cero", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
            txtcantidad.Focus()
            Exit Sub
        End If


        If txtCosto.Text = "" Then
            MsgBox("Falta Ingresar el costo...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            txtCosto.Focus()
            Exit Sub
        End If

        If txtPorcendesc.Text = "" Then
            MsgBox("Falta Ingresar el Porcentaje de Descuento ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            txtPorcendesc.Focus()
            Exit Sub
        End If


        If IsNothing(cbPresentacion.SelectedValue) = True Then
            MsgBox("ESCOJA LA PRESENTACION DEL ARTICULO..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If cbAlmacenDestino.Enabled = True Then
            If calmacenOrigen.SelectedValue = cbAlmacenDestino.SelectedValue Then
                MsgBox("EL ALMACEN DESTINO NO PUEDE SER IGUAL AL ALMACEN ORIGEN", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
                cbAlmacenDestino.Focus()
                Exit Sub
            End If
        End If

        If TmpListarDatos("NSP_VERIF_ITEM_TMPMOVIDET  '" & codempresa & "','" & CORREL & "','" & tarticulo.Text.Trim & "','" & cbPresentacion.SelectedValue.ToString.Trim & "'").Rows.Count > 0 Then
            If ITEMMODIF = True Then
                OPC_TRANSC = 0
                ITEMMODIF = False
            Else
                'MsgBox("EL ARTICULO YA FUE INGRESADO....", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                ITEMMODIF = False
                ' Exit Sub
            End If
        End If

        '/*************************************************************************************************

        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        ' CadenaCateg = Tabla.Rows(0)("codlinea").ToString
        CadenaCateg = tarticulo.Text.Trim
        Dim Table_Correlativo As New DataTable
        Table_Correlativo = CAyuda.ListarDatos("SP_RECORRER_ALMSTK2", tarticulo.Text.Trim, calmacenOrigen.SelectedValue).Tables(0)

        If Table_Correlativo.Rows.Count > 0 Then
            For i As Integer = 0 To Table_Correlativo.Rows.Count - 1
                CierreIgual = False
                Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

                dt = SelectFechCiere(Fech, False, Table_Correlativo.Rows(i)(0).ToString)
                FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
                Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
                Fecharf = DateAdd("d", -1, DtFechaIni.Value)

                MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
                MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
                fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")
                Procesar_Saldo(FECHCIERRE, Table_Correlativo.Rows(i)(0).ToString)


                Dim stock As Integer
                Dim Table_Correlativo2 As New DataTable
                Table_Correlativo2 = CAyuda.ListarDatos("sp_select_stock", Me.tarticulo.Text.Trim, Table_Correlativo.Rows(i)(0).ToString, rand).Tables(0)


                stock = Table_Correlativo2.Rows(0)(0).ToString()

                Dim Table_Correlativo3 As New DataTable

                Dim equivalencia As Integer

                Dim cantidad As Integer

                Table_Correlativo3 = CAyuda.ListarDatos("sp_select_equivalencia", Me.tarticulo.Text.Trim, cbPresentacion.SelectedValue.ToString).Tables(0)


                equivalencia = Table_Correlativo3.Rows(0)(0).ToString()
                cantidad = (CInt(txtcantidad.Text) * equivalencia)


                If (stock - cantidad) < 0 Then
                    MsgBox("No tiene stock")
                    Exit Sub
                End If

            Next
        End If

        '/*************************************************************************************************

        Dim SUBTBAS, SUBTEXT, PORCDESC, MONTODESCBAS, MONTODESCEXT As Double
        Dim COSTOBAS, COSTOEXT, IGVBAS As Double
        COSTOBAS = Format(CDbl(txtCosto.Text), "#######0.00")
        COSTOEXT = Format(COSTOBAS / VCambioCompra, "#######0.00")
        PORCDESC = CDbl(txtPorcendesc.Text)
        MONTODESCBAS = (CDbl(txtcantidad.Text) * CDbl(txtCosto.Text)) * (PORCDESC / 100)
        MONTODESCEXT = Format(MONTODESCBAS / VCambioCompra, "#######0.00")

        Dim TB_IGV_ARTICULO As DataTable
        Dim ESTADO_IGV As String
        Dim VALOR_IGV As Double

        TB_IGV_ARTICULO = TmpListarDatos("NSP_IGV_ARTICULO '" & codempresa & "','" & tarticulo.Text.Trim & "'")

        If TB_IGV_ARTICULO.Rows.Count > 0 Then
            ESTADO_IGV = TB_IGV_ARTICULO.Rows(0)(0).ToString()
            If ESTADO_IGV = "IGV" Then

                Dim TB_IGV_ARTICULOV As DataTable
                TB_IGV_ARTICULOV = TmpListarDatos("NSP_IGV_IMPUESTO '" & codempresa & "','" & tarticulo.Text.Trim & "'")
                If TB_IGV_ARTICULOV.Rows.Count > 0 Then
                    VALOR_IGV = Format(CDbl(TB_IGV_ARTICULOV.Rows(0)(0).ToString()), "#######0.00")
                End If

                SUBTBAS = Format((CDbl(txtcantidad.Text) * CDbl(txtCosto.Text) / VALOR_IGV), "#######0.00") - MONTODESCBAS
                SUBTEXT = Format((SUBTBAS / VCambioCompra) / VALOR_IGV, "#######0.00")
                IGVBAS = Format((VALOR_IGV - 1) * SUBTBAS, "#######0.00")

            Else

                VALOR_IGV = 1

                SUBTBAS = Format((CDbl(txtcantidad.Text) * CDbl(txtCosto.Text) / VALOR_IGV), "#######0.00") - MONTODESCBAS
                SUBTEXT = Format((SUBTBAS / VCambioCompra) / VALOR_IGV, "#######0.00")
                IGVBAS = Format((VALOR_IGV - 1) * SUBTBAS, "#######0.00")
            End If
        End If

        TmpInsertDatos("NSP_INSERT_TMP_MOVIDET  '" & codempresa & "','" & CORREL & "' ,'" & cbAlmacenDestino.SelectedValue.ToString.Trim & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & tmovimiento.Text.Trim & "','" & TABLE_DETALLE.Rows.Count + 1 & "' ,'" & tarticulo.Text.Trim & "','" & cbPresentacion.SelectedValue.ToString.Trim & "','" & txtcantidad.Text & "','" & COSTOBAS & "','" & COSTOEXT & "','" & SUBTBAS & "','" & SUBTEXT & "' ,'" & PORCDESC & "','" & MONTODESCBAS & "','" & MONTODESCEXT & "','" & Format(dtpfecha.Value, "dd/MM/yyyy hh:mm:ss") & "','" & 1 & "','" & CodUsuario & "','" & OPC_TRANSC & "','" & IGVBAS & "'")
        '/*************************************************************************************************

        CargarGridDetalle()
        txtcantidad.Text = "0"
        txtCosto.Text = "0"
        txtPorcendesc.Text = "0"
        tarticulo.Focus()



    End Sub

    Private Function SelectFechCiere(ByVal fecha As Date, ByVal HizoCierre As Boolean, ByVal StrAlmacen As String) As DataTable

        Dim dt As New DataTable
        If HizoCierre = True Then
            'dt = TmpListarDatos("select * from resukdx where fecha='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select *  from CIERRE_MES_INVENTARIO where fecha=('" & Format(fecha, "dd/MM/yyyy") & "') AND ALMACEN ='" & StrAlmacen & "'")
        Else
            'dt = TmpListarDatos("SELECT max (fechA) AS FECHA from resukdx where fechA <= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select max (fechA) AS Fecha from CIERRE_MES_INVENTARIO where fecha <='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")


        End If

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("Fecha") Is DBNull.Value Then
                'dt = TmpListarDatos("SELECT mIN (fechA) AS FECHa from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
                dt = TmpListarDatos("select mIN (fechA)  AS Fecha from CIERRE_MES_INVENTARIO where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")

            End If
        Else
            '  dt = TmpListarDatos("SELECT distinct FECHA=max(fecha) from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'   AND ALMACEN ='" & StrAlmacen & "'  group by CODARTI")

            dt = TmpListarDatos("select max(fecha)  AS Fecha from CIERRE_MES_INVENTARIO where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "' group by articulo ")

        End If

        Return dt

    End Function




    Private Sub tarticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tarticulo.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnarticulo_Click(sender, e)
        End If

    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMasDato.Click


        Dim Frm As New FrmDatosTraslado
        Frm.TxtAutorizado.Text = AUTORIZANTE
        Frm.CboProveedor.Text = RESPONSABLE
        Frm.TxtDatos.Text = DATOTRANS
        Frm.ShowDialog()
        If Frm.DEVOLVER = False Then
            Exit Sub
        End If
        AUTORIZANTE = Frm.TxtAutorizado.Text.Trim
        RESPONSABLE = Frm.CboProveedor.Text.Trim
        DATOTRANS = Frm.TxtDatos.Text.Trim
        If Frm.TxtMontoFlete.Text.Trim <> "" Then
            If CDbl(Frm.TxtMontoFlete.Text) <> 0 Then
                ChkFlete.Checked = True
                txtFlete.Text = CDbl(Frm.TxtMontoFlete.Text)
            End If
        End If
    End Sub


    Private Sub ChkFlete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFlete.CheckedChanged
        If ChkFlete.CheckState = CheckState.Checked Then
            txtFlete.Visible = True
        Else
            txtFlete.Visible = False
        End If

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click


        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim A�O As String
        Dim MES As String
        Dim DESMES As String = ""

        A�O = dtpfecha.Value.Year
        MES = dtpfecha.Value.Month

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

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & A�O & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL A�O " & A�O & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If
        '************************************************************************************************


        If TABLE_DETALLE.Rows.Count = 0 Then
            MsgBox("FALTA INGRESAR EL DETALLE..", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
            tarticulo.Focus()
            Exit Sub
        End If
        If cbAlmacenDestino.Enabled = True Then
            If calmacenOrigen.SelectedValue = cbAlmacenDestino.SelectedValue Then
                MsgBox("EL ALMACEN DESTINO NO PUEDE SER IGUAL AL ALMACEN ORIGEN", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
                cbAlmacenDestino.Focus()
                Exit Sub
            End If
        End If

        If ChkPercep.CheckState = CheckState.Checked Then
            If TxtPercep.Text.Trim = "" Then
                MsgBox("FALTA INGRESAR EL MONTO DE LA PERCEPCION", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
                Exit Sub
            End If
            If CDbl(TxtPercep.Text) = 0 Then
                MsgBox("FALTA INGRESAR EL MONTO DE LA PERCEPCION", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
                Exit Sub
            End If
        End If

        Dim CRED As Integer
        If CboFormaPago.Visible = False Then
            CRED = 0
            CboFormaPago.SelectedValue = TmpListarDatos("NSP_TRAER_PAGO_EFECT  '" & codempresa & "'").Rows(0)("TIPCREDFAC").ToString.Trim
        Else
            Dim TABLE_BUSQTIPCREDF As New DataTable
            TABLE_BUSQTIPCREDF = TmpListarDatos("NSP_BUSQUEDA_TIPCREDF_X_COD  '" & CboFormaPago.SelectedValue.ToString.Trim & "','" & codempresa & "'  ")
            If CInt(TABLE_BUSQTIPCREDF.Rows(0)("NRDIAS").ToString) > 0 Then
                CRED = 1
            Else
                CRED = 0
            End If
        End If


        If MODIFICAR = False Then

            If TmpListarDatos("NSP_BUSCAR_DOCUMEN_MOVICAB  '" & codempresa & "','" & IIf(cbProveedor.Enabled = True, cbProveedor.SelectedValue.ToString.Trim, "") & "' ,'" & cbotipo.SelectedValue.ToString.Trim & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ").Rows.Count > 0 Then
                MsgBox("YA EXISTE ESTE DOCUMENTO REGISTRADO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            'If TmpInsertDatos("NSP_GRABAR_MOVIMIENTO_MERCADERIA  '" & codempresa & "','" & tmovimiento.Text.Trim & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & IIf(cbProveedor.Enabled = True, cbProveedor.SelectedValue.ToString.Trim, "") & "','" & ctipodoc.SelectedValue.ToString.Trim & "','" & 2 & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ,'" & Format(dtpfecha.Value, "dd/MM/yyyy hh:mm:ss") & "','" & CboMoneda.SelectedValue.ToString.Trim & "','" & LblSubtotal.Text & "','" & Format(CDbl(LblSubtotal.Text) / VCambioCompra, "#######0.00") & "','" & VCambioCompra & "','" & LblIGV.Text & "','" & Format(CDbl(LblIGV.Text) / VCambioCompra, "#######0.00") & "','" & LblTotal.Text & "','" & Format(CDbl(LblTotal.Text) / VCambioCompra, "#######0.00") & "', '" & TxtDesc.Text.Trim & "','" & Format((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)), "#######0.00") & "','" & Format(((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)) / VCambioCompra), "#######0.00") & "' ,'" & IIf(cbAlmacenDestino.Enabled = True, calmacenOrigen.SelectedValue.ToString.Trim, "") & "','" & CodUsuario & "','" & cboPeriodo.Text & "','" & txtEjercicio.Text.Trim & "','" & OBS & "','" & IIf(cbAlmacenDestino.Enabled = True, cbAlmacenDestino.SelectedValue.ToString.Trim, "") & "' ,'" & CRED & "','" & CboFormaPago.SelectedValue.ToString.Trim & "','" & NROPTOVTA & "','" & CDbl(txtFlete.Text) & "','" & CORREL & "' ,'" & IIf(TRANS = True, 1, 0) & "','" & CDbl(TxtPercep.Text) & "','" & CDbl(TxtDetrac.Text) & "','" & dtpfechaRecepcion.Value.ToShortDateString & "','" & 2 & "'") = True Then
            '    If cbProveedor.Enabled = True Then
            '        If CboFormaPago.Visible = True Then
            '            CAyuda.Ejecutar("Ins_COMPRA_X_PAGARxProc", codempresa, ctipodoc.SelectedValue, (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text), CboMoneda.SelectedValue, cbProveedor.SelectedValue, CDbl(LblTotal.Text), CDbl(LblTotal.Text) / VCambioCompra, Format(Date.Now, "dd/MM/yyyy"), CboFormaPago.SelectedValue, "", CodUsuario, CDbl(TxtPercep.Text))
            '        End If
            '    End If
            '    TmpInsertDatos("NSP_INS_OBS_TRANS_MERC  '" & codempresa & "','" & tmovimiento.Text.Trim & "','" & cbotipo.SelectedValue.ToString & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "','" & 1 & "','" & AUTORIZANTE & "','" & RESPONSABLE & "','" & DATOTRANS & "'")

            '    TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT  '" & codempresa & "','" & 1 & "','" & CORREL & "','" & cbAlmacenDestino.SelectedValue.ToString.Trim & "' ,'" & tmovimiento.Text.Trim & "'")
            '    TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT  '" & codempresa & "','" & 0 & "','" & CORREL & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "' ,'" & tmovimiento.Text.Trim & "'")


            '    'TmpInsertDatos("NSP_BUSCAR_ART_RESUKDX  '" & codempresa & "','" & CORREL & "'")
            '    MsgBox("SE GUARDO CORRECTAMENTE  ... EL DOCUMENTO " & vbNewLine & "NROMOVIMIENTO: " & tmovimiento.Text)
            '    LIMPIAR()
            '    Limp_Persepcion()
            '    Habilitar(False)
            '    Call BOTONES(True, False, False, False, True)

            'End If





            '--------------------------------INGRESO------------------------------------
            If TmpInsertDatos("NSP_GRABAR_MOVIMIENTO_MERCADERIA  '" & codempresa & "','" & tmovimiento.Text.Trim & "','" & cbAlmacenDestino.SelectedValue.ToString.Trim & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & IIf(cbProveedor.Enabled = True, cbProveedor.SelectedValue.ToString.Trim, "") & "','" & ctipodoc.SelectedValue.ToString.Trim & "','" & 1 & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ,'" & Format(dtpfecha.Value, "dd/MM/yyyy") & "','" & CboMoneda.SelectedValue.ToString.Trim & "','" & LblSubtotal.Text & "','" & Format(CDbl(LblSubtotal.Text) / VCambioCompra, "#######0.00") & "','" & VCambioCompra & "','" & LblIGV.Text & "','" & Format(CDbl(LblIGV.Text) / VCambioCompra, "#######0.00") & "','" & LblTotal.Text & "','" & Format(CDbl(LblTotal.Text) / VCambioCompra, "#######0.00") & "', '" & TxtDesc.Text.Trim & "','" & Format((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)), "#######0.00") & "','" & Format(((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)) / VCambioCompra), "#######0.00") & "' ,'" & calmacenOrigen.SelectedValue.ToString.Trim & "','" & CodUsuario & "','" & cboPeriodo.Text & "','" & txtEjercicio.Text.Trim & "','" & OBS & "','" & IIf(cbAlmacenDestino.Enabled = True, cbAlmacenDestino.SelectedValue.ToString.Trim, "") & "' ,'" & CRED & "','" & CboFormaPago.SelectedValue.ToString.Trim & "','" & NROPTOVTA & "','" & CDbl(txtFlete.Text) & "','" & CORREL & "' ,'" & IIf(TRANS = True, 1, 0) & "','" & CDbl(TxtPercep.Text) & "','" & CDbl(TxtDetrac.Text) & "','" & dtpfechaRecepcion.Value.ToShortDateString & "','" & 2 & "'") = True Then
                If cbProveedor.Enabled = True Then
                    If CboFormaPago.Visible = True Then
                        'CAyuda.Ejecutar("Ins_COMPRA_X_PAGARxProc", codempresa, ctipodoc.SelectedValue, (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text), CboMoneda.SelectedValue, cbProveedor.SelectedValue, CDbl(LblTotal.Text), CDbl(LblTotal.Text) / VCambioCompra, Format(Date.Now, "dd/MM/yyyy"), CboFormaPago.SelectedValue, "", CodUsuario, CDbl(TxtPercep.Text))
                    End If
                End If
                TmpInsertDatos("NSP_INS_OBS_TRANS_MERC  '" & codempresa & "','" & tmovimiento.Text.Trim & "','" & cbotipo.SelectedValue.ToString & "','" & cbAlmacenDestino.SelectedValue.ToString.Trim & "','" & 1 & "','" & AUTORIZANTE & "','" & RESPONSABLE & "','" & DATOTRANS & "'")

                '---se actualiza el stock de ingreso y salida
                TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT_TRASLADO  '" & codempresa & "','" & 1 & "','" & CORREL & "','" & cbAlmacenDestino.SelectedValue.ToString.Trim & "','" & tmovimiento.Text.Trim & "','" & Format(dtpfecha.Value, "dd/MM/yyyy") & "'")
                TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT_TRASLADO  '" & codempresa & "','" & 0 & "','" & CORREL & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "','" & tmovimiento.Text.Trim & "','" & Format(dtpfecha.Value, "dd/MM/yyyy") & "'")


                'TmpInsertDatos("NSP_BUSCAR_ART_RESUKDX  '" & codempresa & "','" & CORREL & "'")


                ' ''MsgBox("SE GUARDO CORRECTAMENTE  ... EL DOCUMENTO " & vbNewLine & "NROMOVIMIENTO: " & tmovimiento.Text)
                ' ''LIMPIAR()
                ' ''Limp_Persepcion()
                ' ''Habilitar(False)
                ' ''Call BOTONES(True, False, False, False, True)

            End If
            '-------------------------------------------------------------------------------------------------------

            TRAER_NROMOV()

            '--------------------------------SALIDA------------------------------------
            If TmpInsertDatos("NSP_GRABAR_MOVIMIENTO_MERCADERIA  '" & codempresa & "','" & tmovimiento.Text.Trim & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & IIf(cbProveedor.Enabled = True, cbProveedor.SelectedValue.ToString.Trim, "") & "','" & ctipodoc.SelectedValue.ToString.Trim & "','" & 0 & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ,'" & Format(dtpfecha.Value, "dd/MM/yyyy") & "','" & CboMoneda.SelectedValue.ToString.Trim & "','" & LblSubtotal.Text & "','" & Format(CDbl(LblSubtotal.Text) / VCambioCompra, "#######0.00") & "','" & VCambioCompra & "','" & LblIGV.Text & "','" & Format(CDbl(LblIGV.Text) / VCambioCompra, "#######0.00") & "','" & LblTotal.Text & "','" & Format(CDbl(LblTotal.Text) / VCambioCompra, "#######0.00") & "', '" & TxtDesc.Text.Trim & "','" & Format((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)), "#######0.00") & "','" & Format(((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)) / VCambioCompra), "#######0.00") & "' ,'" & cbAlmacenDestino.SelectedValue.ToString.Trim & "','" & CodUsuario & "','" & cboPeriodo.Text & "','" & txtEjercicio.Text.Trim & "','" & OBS & "','" & IIf(calmacenOrigen.Enabled = True, calmacenOrigen.SelectedValue.ToString.Trim, "") & "' ,'" & CRED & "','" & CboFormaPago.SelectedValue.ToString.Trim & "','" & NROPTOVTA & "','" & CDbl(txtFlete.Text) & "','" & CORREL & "' ,'" & IIf(TRANS = True, 1, 0) & "','" & CDbl(TxtPercep.Text) & "','" & CDbl(TxtDetrac.Text) & "','" & dtpfechaRecepcion.Text & "','" & 2 & "'") = True Then
                'TmpInsertDatos("NSP_INS_OBS_TRANS_MERC  '" & codempresa & "','" & tmovimiento.Text.Trim & "','" & cbotipo.SelectedValue.ToString & "','" & cbAlmacen.SelectedValue.ToString.Trim & "','" & 1 & "','" & AUTORIZANTE & "','" & RESPONSABLE & "','" & DATOTRANS & "'")
                'TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT  '" & codempresa & "','" & 0 & "','" & CORREL & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "' ,'" & tmovimiento.Text.Trim & "'")

                If cbProveedor.Enabled = True Then
                    If CboFormaPago.Visible = True Then

                        If cbotipo.SelectedValue.ToString.Trim = "07" Then
                            ' CAyuda.Ejecutar("Ins_COMPRA_X_PAGARxProc", codempresa, ctipodoc.SelectedValue, (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text), CboMoneda.SelectedValue, cbProveedor.SelectedValue, -CDbl(LblTotal.Text), CDbl(LblTotal.Text) / VCambioCompra, Format(Date.Now, "dd/MM/yyyy"), CboFormaPago.SelectedValue, "", CodUsuario, CDbl(TxtPercep.Text))
                        Else
                            '  CAyuda.Ejecutar("Ins_COMPRA_X_PAGARxProc", codempresa, ctipodoc.SelectedValue, (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text), CboMoneda.SelectedValue, cbProveedor.SelectedValue, CDbl(LblTotal.Text), CDbl(LblTotal.Text) / VCambioCompra, Format(Date.Now, "dd/MM/yyyy"), CboFormaPago.SelectedValue, "", CodUsuario, CDbl(TxtPercep.Text))

                        End If

                    End If
                End If

                ''MsgBox("SE GUARDO CORRECTAMENTE  ... EL DOCUMENTO " & vbNewLine & "NROMOVIMIENTO: " & tmovimiento.Text)
                ''LIMPIAR()
                ''Habilitar(False)
                ''Limp_Persepcion()
                ''HabilitaBotones(False)
            End If
            '-------------------------------------------------------------------------------------------------------


            MsgBox("SE GUARDO CORRECTAMENTE  ... EL DOCUMENTO " & vbNewLine & " NROMOVIMIENTO: " & (CInt(tmovimiento.Text) - 1) & " NROMOVIMIENTO: " & CInt(tmovimiento.Text))
            LIMPIAR()
            Limp_Persepcion()
            Habilitar(False)
            Call BOTONES(True, False, False, False, True)


        Else
            If TmpInsertDatos("NSP_ACTUALIZA_ARTIDAT_MOV_TRAS   '" & codempresa & "','" & 1 & "' ,'" & tmovimiento.Text.Trim & "' ,'" & cbotipo.SelectedValue.ToString.Trim & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "'") Then
                If TmpInsertDatos("NSP_ACTUALIZA_ARTIDAT_MOV_TRAS   '" & codempresa & "','" & 0 & "' ,'" & tmovimiento.Text.Trim & "' ,'" & cbotipo.SelectedValue.ToString.Trim & "','" & cbAlmacenDestino.SelectedValue.ToString.Trim & "'") Then
                End If

                If TmpInsertDatos("NSP_MODIFICA_MOVIMIENTO_MERCADERIA  '" & codempresa & "','" & tmovimiento.Text.Trim & "','" & cbAlmacenDestino.SelectedValue.ToString.Trim & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & cbProveedor.SelectedValue.ToString.Trim & "','" & ctipodoc.SelectedValue.ToString.Trim & "','" & 1 & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ,'" & Format(dtpfecha.Value, "dd/MM/yyyy hh:mm:ss") & "','" & CboMoneda.SelectedValue.ToString.Trim & "','" & LblSubtotal.Text & "','" & Format(CDbl(LblSubtotal.Text) / VCambioCompra, "#######0.00") & "','" & VCambioCompra & "','" & LblIGV.Text & "','" & Format(CDbl(LblIGV.Text) / VCambioCompra, "#######0.00") & "','" & LblTotal.Text & "','" & Format(CDbl(LblTotal.Text) / VCambioCompra, "#######0.00") & "', '" & TxtDesc.Text.Trim & "','" & Format((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)), "#######0.00") & "','" & Format(((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)) / VCambioCompra), "#######0.00") & "' ,'" & IIf(cbAlmacenDestino.Enabled = True, calmacenOrigen.SelectedValue.ToString.Trim, "") & "','" & CodUsuario & "','" & cboPeriodo.Text & "','" & txtEjercicio.Text.Trim & "','" & OBS & "','" & IIf(cbAlmacenDestino.Enabled = True, cbAlmacenDestino.SelectedValue.ToString.Trim, "") & "' ,'" & CRED & "','" & CboFormaPago.SelectedValue.ToString.Trim & "','" & NROPTOVTA & "','" & CDbl(txtFlete.Text) & "','" & CORREL & "' ,'" & IIf(TRANS = True, 1, 0) & "','" & CDbl(TxtPercep.Text) & "','" & CDbl(TxtDetrac.Text) & "','" & Me.dtpfechaRecepcion.Value.ToShortDateString & "','" & MoviCab & "','" & Movidet & "'") = True Then
                    If TmpInsertDatos("NSP_MODIFICA_MOVIMIENTO_MERCADERIA  '" & codempresa & "','" & CInt((tmovimiento.Text.Trim) + 1) & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & cbProveedor.SelectedValue.ToString.Trim & "','" & ctipodoc.SelectedValue.ToString.Trim & "','" & 0 & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ,'" & Format(dtpfecha.Value, "dd/MM/yyyy hh:mm:ss") & "','" & CboMoneda.SelectedValue.ToString.Trim & "','" & LblSubtotal.Text & "','" & Format(CDbl(LblSubtotal.Text) / VCambioCompra, "#######0.00") & "','" & VCambioCompra & "','" & LblIGV.Text & "','" & Format(CDbl(LblIGV.Text) / VCambioCompra, "#######0.00") & "','" & LblTotal.Text & "','" & Format(CDbl(LblTotal.Text) / VCambioCompra, "#######0.00") & "', '" & TxtDesc.Text.Trim & "','" & Format((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)), "#######0.00") & "','" & Format(((CDbl(LblValorVenta.Text) - CDbl(LblSubtotal.Text)) / VCambioCompra), "#######0.00") & "' ,'" & IIf(cbAlmacenDestino.Enabled = True, calmacenOrigen.SelectedValue.ToString.Trim, "") & "','" & CodUsuario & "','" & cboPeriodo.Text & "','" & txtEjercicio.Text.Trim & "','" & OBS & "','" & IIf(cbAlmacenDestino.Enabled = True, cbAlmacenDestino.SelectedValue.ToString.Trim, "") & "' ,'" & CRED & "','" & CboFormaPago.SelectedValue.ToString.Trim & "','" & NROPTOVTA & "','" & CDbl(txtFlete.Text) & "','" & CORREL & "' ,'" & IIf(TRANS = True, 1, 0) & "','" & CDbl(TxtPercep.Text) & "','" & CDbl(TxtDetrac.Text) & "','" & Me.dtpfechaRecepcion.Value.ToShortDateString & "','" & MoviCab & "','" & Movidet & "'") = True Then
                        TmpInsertDatos("NSP_INS_OBS_TRANS_MERC  '" & codempresa & "','" & tmovimiento.Text.Trim & "','" & cbotipo.SelectedValue.ToString & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "','" & 1 & "','" & AUTORIZANTE & "','" & RESPONSABLE & "','" & DATOTRANS & "'")
                        TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT_TRASLADO  '" & codempresa & "','" & 1 & "','" & CORREL & "','" & cbAlmacenDestino.SelectedValue.ToString.Trim & "' ,'" & tmovimiento.Text.Trim & "','" & Format(dtpfecha.Value, "dd/MM/yyyy") & "'")
                        TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT_TRASLADO  '" & codempresa & "','" & 0 & "','" & CORREL & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "' ,'" & tmovimiento.Text.Trim & "','" & Format(dtpfecha.Value, "dd/MM/yyyy") & "'")

                        MsgBox("SE GUARDO CORRECTAMENTE  ... EL DOCUMENTO " & vbNewLine & " NROMOVIMIENTO: " & tmovimiento.Text & " NROMOVIMIENTO: " & (CInt(tmovimiento.Text) + 1))
                        LIMPIAR()
                        Limp_Persepcion()
                        Habilitar(False)
                        Call BOTONES(True, False, False, False, True)
                    Else

                        MsgBox("ERROR  MODIFICANDO  ... EL DOCUMENTO " & vbNewLine & "NROMOVIMIENTO: " & tmovimiento.Text, MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
                    End If




                Else
                    MsgBox("ERROR  MODIFICANDO  ... EL DOCUMENTO " & vbNewLine & "NROMOVIMIENTO: " & tmovimiento.Text, MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
                End If




            Else
                MsgBox("ERROR  AL QUERER MODIFICAR STOCK ..", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
            End If
        End If
    End Sub

    Private Sub TxtDoc1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc1.TextChanged

    End Sub

    Private Sub TxtDoc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDoc1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDoc1.Text = "000" & TxtDoc1.Text.Trim
            TxtDoc1.Text = Mid(TxtDoc1.Text, TxtDoc1.Text.Length - 2)
            TxtDoc2.Focus()
        End If
    End Sub

    Private Sub TxtDoc2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc2.TextChanged

    End Sub

    Private Sub TxtDoc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDoc2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDoc2.Text = "0000000" & TxtDoc2.Text.Trim
            TxtDoc2.Text = Mid(TxtDoc2.Text, TxtDoc2.Text.Length - 6)
            dtpfecha.Focus()
            If TmpListarDatos("NSP_BUSCAR_DOCUMEN_MOVICAB  '" & codempresa & "','" & IIf(cbProveedor.Enabled = True, cbProveedor.SelectedValue.ToString.Trim, "") & "' ,'" & cbotipo.SelectedValue.ToString.Trim & "','" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "' ").Rows.Count > 0 Then
                MsgBox("YA EXISTE ESTE DOCUMENTO REGISTRADO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusMovi.Click
        Try

            If MENU_ = "Movimiento de Traslado C" Then
            Else
                Habilitar(False)
                Call BOTONES(True, False, True, True, True)

            End If


            Dim FRMBUSC As New FrmConsultarMovimientoMercaderia
            FRMBUSC.INOUT = 2
            FRMBUSC.ShowDialog()
            If FRMBUSC.DEVOLVER = False Then
                Exit Sub
            End If




            'If CAyuda.Valida_Solo_Lectura(CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).FECDOCUM) = True Then
            '    'MsgBox("EL DOCUMENTO HA SIDO ANULADO....", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            '    ' Exit Sub
            'End If


            If CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).ESTADO.Trim = "A" Then
                MsgBox("EL DOCUMENTO HA SIDO ANULADO....", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            'If CAyuda.Valida_Solo_Lectura(CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).FECDOCUM) = True Then
            '    btnmodificar.Enabled = False
            '    BTNELIMINAR.Enabled = False
            'Else
            '    btnmodificar.Enabled = True
            '    BTNELIMINAR.Enabled = True
            'End If

            'tmovimiento.Text = CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).Nromovi.ToString
            'calmacenOrigen.SelectedValue = CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).CDALMACEN.Trim
            'cbotipo.SelectedValue = CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).CDTIPOMOV.Trim


            Dim NUMERODOC As String
            NUMERODOC = CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).NRODOC.ToString

            OBTENERCORRELATIVO()
            Dim TABLE_CAB As New DataTable
            Dim DOC As String
            ActTipoMovimiento()

            MoviCab = CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).TABLACAB
            MoviDet = CType(FRMBUSC.MoviCabEBindingSource.Current, MoviCabE).TABLADET

            TABLE_CAB = TmpListarDatos("NSP_TRAER_MOVIMIENTO_MERC_TRASLADO  '" & codempresa & "','" & NUMERODOC & "','" & IIf(IsNothing(cbotipo.SelectedValue), "", cbotipo.SelectedValue) & "','" & 2 & "','" & CORREL & "','" & MoviCab & "','" & Movidet & "'")

            If TABLE_CAB.Rows.Count = 0 Then
                MsgBox("NO HAY DATOS REGISTRADOS DEL NRO DE MOVIMIENTO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Else

                tmovimiento.Text = TABLE_CAB.Rows(0)("NROMOVI").ToString.Trim


                cbAlmacenDestino.SelectedValue = TABLE_CAB.Rows(0)("CDALMACEN").ToString.Trim
                calmacenOrigen.SelectedValue = TABLE_CAB.Rows(1)("CDALMACEN").ToString.Trim


                txtEjercicio.Text = TABLE_CAB.Rows(0)("EJERCICIO").ToString.Trim
                cboPeriodo.Text = TABLE_CAB.Rows(0)("PERIODO").ToString.Trim



                cbotipo.SelectedValue = TABLE_CAB.Rows(0)("CDTIPOMOV").ToString.Trim

                cbProveedor.SelectedValue = TABLE_CAB.Rows(0)("CDPROVEE").ToString.Trim
                ctipodoc.SelectedValue = TABLE_CAB.Rows(0)("CDTIPODOC").ToString.Trim
                CboMoneda.SelectedValue = TABLE_CAB.Rows(0)("CDMONEDA").ToString.Trim
                DOC = "000000000" & TABLE_CAB.Rows(0)("NRODOC").ToString.Trim
                TxtDoc1.Text = Mid(DOC, DOC.Length - 9, 3)
                TxtDoc2.Text = Mid(DOC, DOC.Length - 6, DOC.Length)
                Limp_Persepcion()
                If CDbl(IIf(TABLE_CAB.Rows(0)("PERCEPCION") Is DBNull.Value, 0, TABLE_CAB.Rows(0)("PERCEPCION"))) > 0 Then
                    ChkPercep.Checked = True
                    TxtPercep.Text = (Format(CDbl(TABLE_CAB.Rows(0)("PERCEPCION")), "#######0.00"))
                End If
                If CDbl(IIf(TABLE_CAB.Rows(0)("DETRACCION") Is DBNull.Value, 0, TABLE_CAB.Rows(0)("DETRACCION"))) > 0 Then
                    ChkDetrac.Checked = True
                    TxtDetrac.Text = (Format(CDbl(TABLE_CAB.Rows(0)("DETRACCION")), "#######0.00"))
                End If


                dtpfecha.Value = TABLE_CAB.Rows(0)("FECDOCUM")
                dtpfechaRecepcion.Value = TABLE_CAB.Rows(0)("FECHARECEPC")


                CargarGridDetalle()
                FormatoGrid()

                'BTNGUARDAR.Enabled = False

                ' HabilitaBotones(False)


                BtnMasDato.Enabled = False
                BTNNUEVO.Enabled = False
                BTNGUARDAR.Enabled = False
                btnmodificar.Enabled = False
                BTNELIMINAR.Enabled = False



            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Limp_Persepcion()
        ChkPercep.Checked = False
        ChkDetrac.Checked = False

        TxtPercep.Text = "0.00"
        TxtDetrac.Text = "0.00"
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Habilitar(False)
        LIMPIAR()
        Call BOTONES(True, False, False, False, True)

    End Sub

    Private Sub cbPresentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPresentacion.SelectedIndexChanged
        Try
            If cbAlmacenDestino.SelectedIndex <> -1 Then
                BUSCOSTOANTERIO_X_PRESENT()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbPresentacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPresentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcantidad.Focus()
        End If
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        If tmovimiento.Text.Trim = "" Then
            Exit Sub
        End If

        Dim Proceso As String
        Proceso = "MODSALIDA"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim TABLE_PROC As New DataTable
            TABLE_PROC = TmpListarDatos("SELECT DSPROCESO FROM PROCESOS WHERE CDPROCESO='" & Proceso & "' AND CODEMPRESA='" & codempresa & "'")
            Dim FrmPer As New FrmIngresaUsuClave
            If TABLE_PROC.Rows.Count = 0 Then
                FrmPer.LblProceso.Text = "NO EXISTE EL PROCESO"
            Else
                FrmPer.LblProceso.Text = CStr(TABLE_PROC.Rows(0)(0)).Trim
            End If
            FrmPer.Proceso = Proceso
            FrmPer.ShowDialog()
            If FrmPer.DEVOLVER = False Then
                Exit Sub
            End If
        End If


        Habilitar(True)
        MODIFICAR = True
        calmacenOrigen.Enabled = False
        cbotipo.Enabled = False
        cbProveedor.Enabled = False
        ctipodoc.Enabled = False
        LblTitulo.Visible = True

        Call BOTONES(False, True, False, False, True)

    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If tmovimiento.Text.Trim = "" Then
            Exit Sub
        End If
        Dim Proceso As String
        Proceso = "ANULTRASLADO"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If
        If TxtDoc1.Text.Trim = "" And TxtDoc2.Text.Trim = "" Then
            Exit Sub
        End If

        'If TmpInsertDatos("NSP_ANULAR_INGRESO_MERCADERIA2  '" & (CStr(CInt(TxtDoc1.Text)) + TxtDoc2.Text) & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & ctipodoc.SelectedValue.ToString.Trim & "','" & codempresa & "','" & MoviCab & "','" & Movidet & "'") = True Then
        '    'TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT  '" & codempresa & "','" & 0 & "','" & CORREL & "','" & calmacen.SelectedValue.ToString.Trim & "'  ")
        '    MsgBox("EL DOCUMENTO  HA SIDO ANULADO CORRECTAMENTE..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        '    BOTONES(True, False, False, False, True)

        'Else
        '    MsgBox("ERROR EN LA ANULACION ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        'End If




        If TmpInsertDatos("NSP_ANULAR_INGRESO_MERCADERIA  '" & tmovimiento.Text.Trim & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & (CStr(CInt(TxtDoc1.Text)) & TxtDoc2.Text.Trim) & "','" & ctipodoc.SelectedValue.ToString.Trim & "','" & codempresa & "','" & MoviCab & "','" & Movidet & "'") = True Then
            'TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT  '" & codempresa & "','" & 0 & "','" & CORREL & "','" & calmacen.SelectedValue.ToString.Trim & "'  ")
            TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT_TRASLADO  '" & codempresa & "','" & 0 & "','" & CORREL & "','" & cbAlmacenDestino.SelectedValue.ToString.Trim & "' ,'" & tmovimiento.Text.Trim & "','" & Format(dtpfecha.Value, "dd/MM/yyyy") & "'")



            MsgBox("EL DOCUMENTO  HA SIDO ANULADO " & tmovimiento.Text.Trim, MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            BOTONES(True, False, False, False, True)

        Else
            MsgBox("ERROR EN LA ANULACION ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        End If


        If TmpInsertDatos("NSP_ANULAR_INGRESO_MERCADERIA  '" & (CInt(tmovimiento.Text.Trim) + 1) & "','" & cbotipo.SelectedValue.ToString.Trim & "','" & (CStr(CInt(TxtDoc1.Text)) & TxtDoc2.Text.Trim) & "','" & ctipodoc.SelectedValue.ToString.Trim & "','" & codempresa & "','" & MoviCab & "','" & Movidet & "'") = True Then
            'TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT  '" & codempresa & "','" & 0 & "','" & CORREL & "','" & calmacen.SelectedValue.ToString.Trim & "'  ")

            TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT_TRASLADO  '" & codempresa & "','" & 1 & "','" & CORREL & "','" & calmacenOrigen.SelectedValue.ToString.Trim & "' ,'" & tmovimiento.Text.Trim & "','" & Format(dtpfecha.Value, "dd/MM/yyyy") & "'")

            MsgBox("EL DOCUMENTO  HA SIDO ANULADO " & (CInt(tmovimiento.Text.Trim) + 1), MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            BOTONES(True, False, False, False, True)

        Else
            MsgBox("ERROR EN LA ANULACION ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        End If



    End Sub

    Private Sub BTNREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNREPORTE.Click
        If tmovimiento.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        'With axcrt2
        '    Dim dt As New DataTable
        '    dt = M_Cabecera_R(CodUsuario, codempresa)
        '    .set_Formulas(1, "AlmacenD='" & cbAlmacenDestino.Text.ToString & "'")
        '    .set_Formulas(2, "AlmacenI='" & calmacenOrigen.Text.ToString & "'")
        '    .set_Formulas(3, "Documento='" & ctipodoc.Text.ToString & "'")
        '    .set_Formulas(4, "FormaPago='" & CboFormaPago.Text.ToString & "'")
        '    .set_Formulas(7, "Usuario='" & dt.Rows(0)(1).ToString & "'")


        '    .set_StoredProcParam(0, codempresa)
        '    .set_StoredProcParam(1, tmovimiento.Text.Trim)
        '    .set_StoredProcParam(2, cbotipo.SelectedValue.ToString.Trim)
        '    .set_StoredProcParam(3, " ")
        '    .set_StoredProcParam(4, " ")

        '    .WindowShowExportBtn = True
        '    .WindowShowPrintBtn = True
        '    .WindowShowPrintSetupBtn = True
        '    .ReportFileName = rutareporte + CType("Rpt_Traslado_Inventario.rpt", String)
        '    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
        '    .Destination = Crystal.DestinationConstants.crptToWindow
        '    .WindowState = Crystal.WindowStateConstants.crptMaximized
        '    .Action = 1
        '    .Reset()
        'End With





        With axcrt2
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)

            .set_Formulas(1, "Almacen='" & cbAlmacenDestino.Text.ToString & "'")
            .set_Formulas(2, "Documento='" & ctipodoc.Text.ToString & "'")
            .set_Formulas(3, "FormaPago='" & CboFormaPago.Text.ToString & "'")
            .set_Formulas(7, "Usuario='" & dt.Rows(0)(1).ToString & "'")

            .set_Formulas(5, "MOV='" & "INGRESO" & "'")



            .set_Formulas(8, "VALORVENTA='" & LblValorVenta.Text & "'")
            .set_Formulas(9, "DESC='" & TxtDesc.Text & "'")
            .set_Formulas(10, "SUBTOTAL='" & LblSubtotal.Text & "'")
            .set_Formulas(11, "IGV='" & LblIGV.Text & "'")
            .set_Formulas(12, "TOTAL='" & LblTotal.Text & "'")



            .set_StoredProcParam(0, codempresa)
            .set_StoredProcParam(1, tmovimiento.Text.Trim)
            .set_StoredProcParam(2, cbotipo.SelectedValue.ToString.Trim)
            .set_StoredProcParam(3, MoviCab.ToString)
            .set_StoredProcParam(4, Movidet.ToString)

            .WindowShowExportBtn = True
            .WindowShowPrintBtn = True
            .WindowShowPrintSetupBtn = True
            .ReportFileName = rutareporte + CType("Rpt_Produccion_Inventario.rpt", String)
            .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            .Destination = Crystal.DestinationConstants.crptToWindow
            .WindowState = Crystal.WindowStateConstants.crptMaximized
            .Action = 1
            .Reset()
        End With




        With axcrt2
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)


            .set_Formulas(1, "Almacen='" & calmacenOrigen.Text.ToString & "'")
            .set_Formulas(2, "Documento='" & ctipodoc.Text.ToString & "'")
            .set_Formulas(3, "FormaPago='" & CboFormaPago.Text.ToString & "'")
            .set_Formulas(7, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            .set_Formulas(5, "MOV='" & "SALIDA" & "'")


            .set_StoredProcParam(0, codempresa)
            .set_StoredProcParam(1, (CInt(tmovimiento.Text.Trim) + 1))
            .set_StoredProcParam(2, cbotipo.SelectedValue.ToString.Trim)
            .set_StoredProcParam(3, MoviCab.ToString)
            .set_StoredProcParam(4, Movidet.ToString)

            .set_Formulas(8, "VALORVENTA='" & LblValorVenta.Text & "'")
            .set_Formulas(9, "DESC='" & TxtDesc.Text & "'")
            .set_Formulas(10, "SUBTOTAL='" & LblSubtotal.Text & "'")
            .set_Formulas(11, "IGV='" & LblIGV.Text & "'")
            .set_Formulas(12, "TOTAL='" & LblTotal.Text & "'")

            .WindowShowExportBtn = True
            .WindowShowPrintBtn = True
            .WindowShowPrintSetupBtn = True
            .ReportFileName = rutareporte + CType("Rpt_Produccion_Inventario.rpt", String)
            .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            .Destination = Crystal.DestinationConstants.crptToWindow
            .WindowState = Crystal.WindowStateConstants.crptMaximized
            .Action = 1
            .Reset()
        End With








    End Sub

    Private Sub TxtDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesc.TextChanged

    End Sub

    Private Sub TxtDesc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesc.KeyUp

    End Sub

    Private Sub TxtDesc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesc.KeyDown

        If e.KeyCode = Keys.Enter Then
            'CAyuda.Ejecutar("DescTotTMP_MOVIDET_xProc", CORREL, CDbl(TxtDesc.Text), VCambioCompra, codempresa)
            'CargarGridDetalle()
            Dim DESC As Double
            DESC = CDbl(LblValorVenta.Text) * (TxtDesc.Text / 100)
            LblSubtotal.Text = Format(CDbl(CDbl(LblValorVenta.Text) - DESC), "#######0.00")

            Dim DESC_IGV As Double
            DESC_IGV = CDbl(LblIGV.Text) * (TxtDesc.Text / 100)
            LblIGV.Text = Format(CDbl(CDbl(LblIGV.Text) - DESC_IGV), "#######0.00")

            LblTotal.Text = Format(CDbl(LblSubtotal.Text) + CDbl(LblIGV.Text), "#######0.00")
        End If

    End Sub

    Private Sub ChkPercep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPercep.CheckedChanged
        If ChkPercep.CheckState = CheckState.Checked Then
            TxtPercep.Visible = True
        Else
            TxtPercep.Visible = False
        End If

    End Sub

    Private Sub ChkDetrac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkDetrac.CheckedChanged
        If ChkDetrac.CheckState = CheckState.Checked Then
            TxtDetrac.Visible = True
        Else
            TxtDetrac.Visible = False
        End If
    End Sub



    Private Sub txtPorcendesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorcendesc.TextChanged

    End Sub

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub DtGridDetalle_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DtGridDetalle.Navigate

    End Sub

    Private Sub calmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles calmacenOrigen.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If cbProveedor.Enabled = True Then
                Me.cbProveedor.Focus()
            Else
                Me.ctipodoc.Focus()
            End If

        End If

    End Sub

    Private Sub calmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calmacenOrigen.SelectedIndexChanged

    End Sub

    Private Sub ctipodoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipodoc.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.TxtDoc1.Focus()
        End If

    End Sub

    Private Sub ctipodoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctipodoc.SelectedIndexChanged

    End Sub

    Private Sub cbProveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbProveedor.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.ctipodoc.Focus()
        End If

    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedIndexChanged

    End Sub

    Private Sub CboMoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboMoneda.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.TxtDoc1.Focus()
        End If


    End Sub

    Private Sub CboMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMoneda.SelectedIndexChanged

    End Sub

    Private Sub dtpfecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpfecha.KeyDown

        If e.KeyCode = Keys.Enter Then
            dtpfechaRecepcion.Focus()
        End If

    End Sub

    Private Sub dtpfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfecha.KeyPress


    End Sub

    Private Sub dtpfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfecha.ValueChanged

    End Sub

    Private Sub dtpfechaRecepcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpfechaRecepcion.KeyDown

        If e.KeyCode = Keys.Enter Then
            txtEjercicio.Focus()
        End If

    End Sub

    Private Sub dtpfechaRecepcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfechaRecepcion.KeyPress

    End Sub

    Private Sub dtpfechaRecepcion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfechaRecepcion.ValueChanged

    End Sub

    Private Sub txtEjercicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEjercicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboPeriodo.Focus()
        End If
    End Sub

    Private Sub txtEjercicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEjercicio.KeyPress



    End Sub

    Private Sub txtEjercicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEjercicio.TextChanged

    End Sub

    Private Sub cboPeriodo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPeriodo.KeyDown

        If e.KeyCode = Keys.Enter Then
            CboFormaPago.Focus()
        End If


    End Sub

    Private Sub cboPeriodo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboPeriodo.KeyPress




    End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged

    End Sub
End Class
