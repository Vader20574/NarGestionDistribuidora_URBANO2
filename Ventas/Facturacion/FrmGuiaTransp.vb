Public Class FrmGuiaTransp
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
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BTNCLIENTE As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents txtsubt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblcodmoneda3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnobsitem As System.Windows.Forms.Button
    Friend WithEvents cbounidadventa As System.Windows.Forms.ComboBox
    Friend WithEvents lblunidadventa As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdesarticulo As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtdescliente As System.Windows.Forms.TextBox
    Friend WithEvents txtcodcliente As System.Windows.Forms.TextBox
    Friend WithEvents txtnumeroguia As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TXTTIMER As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtcambio As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnobs As System.Windows.Forms.Button
    Friend WithEvents cbotipopre As System.Windows.Forms.ComboBox
    Friend WithEvents cbotipopago As System.Windows.Forms.ComboBox
    Friend WithEvents calmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtpeso As System.Windows.Forms.TextBox
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents DTGGUITRAN As System.Windows.Forms.DataGrid
    Friend WithEvents BtnBuscaGuiaTran As System.Windows.Forms.Button
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents txtpto As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtnumeroguia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txttot As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmGuiaTransp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BTNREPORTE = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.btnobs = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtpto = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.calmacen = New System.Windows.Forms.ComboBox
        Me.cbotipopago = New System.Windows.Forms.ComboBox
        Me.cbotipopre = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.BtnBuscaGuiaTran = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.BTNCLIENTE = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtigv = New System.Windows.Forms.TextBox
        Me.txtsubt = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblcodmoneda3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtdescliente = New System.Windows.Forms.TextBox
        Me.txtcodcliente = New System.Windows.Forms.TextBox
        Me.txtnumeroguia = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.txtnumeroguia2 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtcambio = New System.Windows.Forms.TextBox
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txttot = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtpeso = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnobsitem = New System.Windows.Forms.Button
        Me.cbounidadventa = New System.Windows.Forms.ComboBox
        Me.lblunidadventa = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtdesarticulo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.DTGGUITRAN = New System.Windows.Forms.DataGrid
        Me.TXTTIMER = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DTGGUITRAN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BTNREPORTE)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.btnobs)
        Me.GroupBox1.Location = New System.Drawing.Point(752, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 272)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 14
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(16, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 23)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "&Eliminar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 13
        Me.BTNREPORTE.ImageList = Me.ImageList1
        Me.BTNREPORTE.Location = New System.Drawing.Point(16, 144)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(80, 23)
        Me.BTNREPORTE.TabIndex = 6
        Me.BTNREPORTE.Text = "&Imprimir"
        Me.BTNREPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(16, 80)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(80, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(16, 176)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(80, 23)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "C&errar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(16, 112)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(80, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "Anular"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(16, 16)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(80, 23)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(16, 48)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(80, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnobs
        '
        Me.btnobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnobs.ImageIndex = 5
        Me.btnobs.ImageList = Me.ImageList1
        Me.btnobs.Location = New System.Drawing.Point(8, 208)
        Me.btnobs.Name = "btnobs"
        Me.btnobs.Size = New System.Drawing.Size(101, 23)
        Me.btnobs.TabIndex = 40
        Me.btnobs.Text = "&Observaciones"
        Me.btnobs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtpto)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.calmacen)
        Me.GroupBox2.Controls.Add(Me.cbotipopago)
        Me.GroupBox2.Controls.Add(Me.cbotipopre)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.BtnBuscaGuiaTran)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.BTNCLIENTE)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtruc)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
        Me.GroupBox2.Controls.Add(Me.txtdescliente)
        Me.GroupBox2.Controls.Add(Me.txtcodcliente)
        Me.GroupBox2.Controls.Add(Me.txtnumeroguia)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.txtnumeroguia2)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 152)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(136, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(8, 17)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "-"
        '
        'txtpto
        '
        Me.txtpto.Location = New System.Drawing.Point(512, 16)
        Me.txtpto.Name = "txtpto"
        Me.txtpto.ReadOnly = True
        Me.txtpto.Size = New System.Drawing.Size(152, 21)
        Me.txtpto.TabIndex = 49
        Me.txtpto.Text = "TextBox1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(432, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 17)
        Me.Label21.TabIndex = 48
        Me.Label21.Text = "Punto Venta :"
        '
        'calmacen
        '
        Me.calmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.calmacen.Enabled = False
        Me.calmacen.Location = New System.Drawing.Point(512, 120)
        Me.calmacen.Name = "calmacen"
        Me.calmacen.Size = New System.Drawing.Size(216, 21)
        Me.calmacen.TabIndex = 46
        '
        'cbotipopago
        '
        Me.cbotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipopago.Location = New System.Drawing.Point(512, 88)
        Me.cbotipopago.Name = "cbotipopago"
        Me.cbotipopago.Size = New System.Drawing.Size(216, 21)
        Me.cbotipopago.TabIndex = 45
        '
        'cbotipopre
        '
        Me.cbotipopre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipopre.Location = New System.Drawing.Point(96, 120)
        Me.cbotipopre.Name = "cbotipopre"
        Me.cbotipopre.Size = New System.Drawing.Size(292, 21)
        Me.cbotipopre.TabIndex = 44
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(512, 64)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(136, 21)
        Me.DateTimePicker2.TabIndex = 43
        '
        'BtnBuscaGuiaTran
        '
        Me.BtnBuscaGuiaTran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscaGuiaTran.ImageIndex = 5
        Me.BtnBuscaGuiaTran.ImageList = Me.ImageList1
        Me.BtnBuscaGuiaTran.Location = New System.Drawing.Point(224, 16)
        Me.BtnBuscaGuiaTran.Name = "BtnBuscaGuiaTran"
        Me.BtnBuscaGuiaTran.Size = New System.Drawing.Size(41, 23)
        Me.BtnBuscaGuiaTran.TabIndex = 39
        Me.BtnBuscaGuiaTran.Text = "..."
        Me.BtnBuscaGuiaTran.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(416, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 17)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Almacen Salida :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(35, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 17)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Moneda : "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCLIENTE
        '
        Me.BTNCLIENTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCLIENTE.ImageIndex = 5
        Me.BTNCLIENTE.ImageList = Me.ImageList1
        Me.BTNCLIENTE.Location = New System.Drawing.Point(224, 40)
        Me.BTNCLIENTE.Name = "BTNCLIENTE"
        Me.BTNCLIENTE.Size = New System.Drawing.Size(41, 23)
        Me.BTNCLIENTE.TabIndex = 28
        Me.BTNCLIENTE.Text = "..."
        Me.BTNCLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtigv)
        Me.GroupBox4.Controls.Add(Me.txtsubt)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.lblcodmoneda3)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 448)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(744, 47)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'txtigv
        '
        Me.txtigv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigv.Location = New System.Drawing.Point(343, 16)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.ReadOnly = True
        Me.txtigv.Size = New System.Drawing.Size(111, 21)
        Me.txtigv.TabIndex = 38
        Me.txtigv.Text = "0.00"
        Me.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsubt
        '
        Me.txtsubt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubt.Location = New System.Drawing.Point(98, 19)
        Me.txtsubt.Name = "txtsubt"
        Me.txtsubt.ReadOnly = True
        Me.txtsubt.Size = New System.Drawing.Size(112, 21)
        Me.txtsubt.TabIndex = 37
        Me.txtsubt.Text = "0.00"
        Me.txtsubt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 17)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Sub Total : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(295, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "I.G.V. "
        '
        'lblcodmoneda3
        '
        Me.lblcodmoneda3.AutoSize = True
        Me.lblcodmoneda3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodmoneda3.Location = New System.Drawing.Point(556, 19)
        Me.lblcodmoneda3.Name = "lblcodmoneda3"
        Me.lblcodmoneda3.Size = New System.Drawing.Size(47, 17)
        Me.lblcodmoneda3.TabIndex = 27
        Me.lblcodmoneda3.Text = "Total  : "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(512, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(134, 21)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(416, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Fecha Emision : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(408, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Fecha Ini. Trasl. : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtruc
        '
        Me.txtruc.Location = New System.Drawing.Point(297, 40)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.ReadOnly = True
        Me.txtruc.Size = New System.Drawing.Size(99, 21)
        Me.txtruc.TabIndex = 10
        Me.txtruc.Text = ""
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(100, 88)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(300, 21)
        Me.txtdireccion.TabIndex = 9
        Me.txtdireccion.Text = ""
        '
        'txtdescliente
        '
        Me.txtdescliente.Location = New System.Drawing.Point(100, 64)
        Me.txtdescliente.Name = "txtdescliente"
        Me.txtdescliente.ReadOnly = True
        Me.txtdescliente.Size = New System.Drawing.Size(300, 21)
        Me.txtdescliente.TabIndex = 8
        Me.txtdescliente.Text = ""
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(100, 40)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(124, 21)
        Me.txtcodcliente.TabIndex = 7
        Me.txtcodcliente.Text = ""
        '
        'txtnumeroguia
        '
        Me.txtnumeroguia.Location = New System.Drawing.Point(144, 16)
        Me.txtnumeroguia.MaxLength = 7
        Me.txtnumeroguia.Name = "txtnumeroguia"
        Me.txtnumeroguia.ReadOnly = True
        Me.txtnumeroguia.Size = New System.Drawing.Size(80, 21)
        Me.txtnumeroguia.TabIndex = 6
        Me.txtnumeroguia.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(265, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ruc : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(408, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Forma de Pago : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apell o Rs. :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod Cliente :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro de Guia :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(84, 239)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(103, 56)
        Me.ListBox1.TabIndex = 40
        Me.ListBox1.Visible = False
        '
        'txtnumeroguia2
        '
        Me.txtnumeroguia2.Location = New System.Drawing.Point(100, 16)
        Me.txtnumeroguia2.MaxLength = 3
        Me.txtnumeroguia2.Name = "txtnumeroguia2"
        Me.txtnumeroguia2.ReadOnly = True
        Me.txtnumeroguia2.Size = New System.Drawing.Size(38, 21)
        Me.txtnumeroguia2.TabIndex = 6
        Me.txtnumeroguia2.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(760, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "T.C :"
        '
        'txtcambio
        '
        Me.txtcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcambio.HideSelection = False
        Me.txtcambio.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtcambio.Location = New System.Drawing.Point(792, 336)
        Me.txtcambio.Multiline = True
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.ReadOnly = True
        Me.txtcambio.Size = New System.Drawing.Size(48, 20)
        Me.txtcambio.TabIndex = 39
        Me.txtcambio.Text = "0.000"
        Me.txtcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(920, 152)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 47
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttot)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtmonto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtpeso)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.btnobsitem)
        Me.GroupBox3.Controls.Add(Me.cbounidadventa)
        Me.GroupBox3.Controls.Add(Me.lblunidadventa)
        Me.GroupBox3.Controls.Add(Me.txtcantidad)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtdesarticulo)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(736, 78)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'txttot
        '
        Me.txttot.Location = New System.Drawing.Point(664, 48)
        Me.txttot.Name = "txttot"
        Me.txttot.ReadOnly = True
        Me.txttot.Size = New System.Drawing.Size(64, 21)
        Me.txttot.TabIndex = 46
        Me.txttot.Text = "0"
        Me.txttot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(616, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 17)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Total : "
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(536, 45)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(64, 21)
        Me.txtmonto.TabIndex = 44
        Me.txtmonto.Text = "0"
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(488, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Precio : "
        '
        'txtpeso
        '
        Me.txtpeso.Location = New System.Drawing.Point(192, 45)
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.Size = New System.Drawing.Size(48, 21)
        Me.txtpeso.TabIndex = 42
        Me.txtpeso.Text = "0"
        Me.txtpeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Peso : "
        '
        'btnobsitem
        '
        Me.btnobsitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnobsitem.ImageIndex = 5
        Me.btnobsitem.ImageList = Me.ImageList1
        Me.btnobsitem.Location = New System.Drawing.Point(552, 18)
        Me.btnobsitem.Name = "btnobsitem"
        Me.btnobsitem.Size = New System.Drawing.Size(152, 24)
        Me.btnobsitem.TabIndex = 40
        Me.btnobsitem.Text = "O&bservaciones  Item"
        '
        'cbounidadventa
        '
        Me.cbounidadventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbounidadventa.Location = New System.Drawing.Point(352, 45)
        Me.cbounidadventa.Name = "cbounidadventa"
        Me.cbounidadventa.Size = New System.Drawing.Size(120, 21)
        Me.cbounidadventa.TabIndex = 28
        '
        'lblunidadventa
        '
        Me.lblunidadventa.AutoSize = True
        Me.lblunidadventa.Location = New System.Drawing.Point(256, 47)
        Me.lblunidadventa.Name = "lblunidadventa"
        Me.lblunidadventa.Size = New System.Drawing.Size(98, 17)
        Me.lblunidadventa.TabIndex = 27
        Me.lblunidadventa.Text = "Unidad de Venta : "
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(80, 45)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(48, 21)
        Me.txtcantidad.TabIndex = 23
        Me.txtcantidad.Text = "0"
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Cantidad : "
        '
        'txtdesarticulo
        '
        Me.txtdesarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesarticulo.Location = New System.Drawing.Point(80, 20)
        Me.txtdesarticulo.Name = "txtdesarticulo"
        Me.txtdesarticulo.Size = New System.Drawing.Size(440, 21)
        Me.txtdesarticulo.TabIndex = 14
        Me.txtdesarticulo.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Descripcion :"
        '
        'DTGGUITRAN
        '
        Me.DTGGUITRAN.BackgroundColor = System.Drawing.Color.Gray
        Me.DTGGUITRAN.CaptionText = "Registro de Items                                              ENTER=MODIFICAR   " & _
        "      F3=ELIMINAR"
        Me.DTGGUITRAN.DataMember = ""
        Me.DTGGUITRAN.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGGUITRAN.Location = New System.Drawing.Point(8, 168)
        Me.DTGGUITRAN.Name = "DTGGUITRAN"
        Me.DTGGUITRAN.ReadOnly = True
        Me.DTGGUITRAN.Size = New System.Drawing.Size(728, 168)
        Me.DTGGUITRAN.TabIndex = 12
        '
        'TXTTIMER
        '
        Me.TXTTIMER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTIMER.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTIMER.HideSelection = False
        Me.TXTTIMER.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TXTTIMER.Location = New System.Drawing.Point(768, 296)
        Me.TXTTIMER.Multiline = True
        Me.TXTTIMER.Name = "TXTTIMER"
        Me.TXTTIMER.ReadOnly = True
        Me.TXTTIMER.Size = New System.Drawing.Size(84, 21)
        Me.TXTTIMER.TabIndex = 38
        Me.TXTTIMER.Text = "12:00:00 AM"
        Me.TXTTIMER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmGuiaTransp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(882, 432)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TXTTIMER)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcambio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DTGGUITRAN)
        Me.Controls.Add(Me.crRpt)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGuiaTransp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Guia Transportista"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DTGGUITRAN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AIntValor As Integer
    'Public AObjBus As New ClsInterface
    Public AStrDomP, AStrDistP, x, AStrProvP, AStrDomD, AStrDistD, AStrObsGuiaTran, AStrProvD, AStrRemi, AStrRucRemi, AStrDniRemi, AStrDestina, AStrRucDestina, AStrDniDestina, AStrObvs, AStrCodtransp, AStrDesctransp, AStrRuctransp, AStrBrevete, AStrMarca, AStrPlaca, AStrNrocert, AStrConfigVeh As String, fechatras As Date
    Public AStrEmpresaSubCont, AStrRucEmpSubCont As String
    Public ADblCorrela As Double
    Public AIntResp As Integer
    Public ATblDet As New DataTable
    Public AIntConsTipoMed As Integer
    Public ABoolEstado, ABoolMod, ABoolGrab, ABoolObs As Boolean
    Public AStrEstadoDoc As String
    Public ABoolEstadoDoc As Boolean

    Private Sub BTNCLIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCLIENTE.Click
        Dim AForm As New frm_gridclie
        AIntValor = 1
        AForm.AFrmGuiaTrans = Me
        AForm.ShowDialog()
        txtcodcliente.Focus()

    End Sub
    Private Sub btnobs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnobs.Click
        Dim men As New FrmObsGuiaTrans
        men.AFrmGuiaTrans = Me
        men.tdomd.Focus()
        men.ShowDialog(Me)
    End Sub
    Private Sub FrmGuiaTransp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cargadatos()
            txtcambio.Text = CAyuda.ListarDatos("NSP_SELCT_SELECIONACAMBIO", CDMONBASE).Tables(0).Rows(0)(3)
            BLOQUEA(False, True)
            BTNGUARDAR.Enabled = False
            BTNELIMINAR.Enabled = False
            BTNREPORTE.Enabled = False
            ABoolGrab = False
            txtpto.Text = NROPTOVTA.ToString.Trim
        Catch
        End Try
    End Sub
    Sub cargadatos()
        Try
            CAyuda.CargarDataCombo(cbotipopago, "Nsp_Sel_Tipo_Pago  '" & codempresa & "'", "Codigo", "Descripcion")
            CAyuda.CargarDataCombo(cbotipopre, "NSP_Select_Listado_Moneda  '" & codempresa & "'", "Código", "Descripción")
            CAyuda.CargarDataCombo(calmacen, "Nsp_select_AlmacenPtovta   '" & codempresa & "','" & NROPTOVTA & "'", "codigo", "descripcion")
            'AObjBus.GCargaDataCombo(cbounidadventa, CAyuda.ListarDatos("NSP_SELECT_LISTAUNIONMEDIDA").Tables(0), "CODUMED", "DESUMED")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Try
            HABILITARCONTROLES()
            txtcodcliente.ReadOnly = False
            txtcodcliente.Focus()
            BLOQUEA(True, False)
            ABoolMod = True
            ABoolObs = True
            limpia()
            txtnumeroguia.Text = CAyuda.ListarDatos("NSP_SELECT_OBTIENE_CORRELATIVO_GUIATRAN", NROPTOVTA.ToString.Trim, codempresa).Tables(0).Rows(0)(0)
            txtnumeroguia2.Text = Strings.Left(Strings.Right("000" & txtnumeroguia.Text, 10), 3)
            txtnumeroguia.Text = Strings.Right(txtnumeroguia.Text, 7)
            txtnumeroguia.Enabled = False
            txtnumeroguia2.Enabled = False
            cargadatos()
            ADblCorrela = CAyuda.ListarDatos("ObtenerCorrelativoProcUtil", CodUsuario).Tables(0).Rows(0)(0)
            ATblDet = CAyuda.ListarDatos("NSP_SELECT_LISTAGUIATRAN", ADblCorrela, codempresa).Tables(0)
            DTGGUITRAN.DataSource = ATblDet
            FormatGrid()
            ABoolEstado = True
            cbotipopre.SelectedIndex = 1
        Catch
        End Try
    End Sub
    Sub DESABILITARCONTROLES()
        cbotipopre.Enabled = False
        cbotipopago.Enabled = False
        'calmacen.Enabled = False
    End Sub
    Sub HABILITARCONTROLES()
        cbotipopre.Enabled = True
        cbotipopago.Enabled = True
        'calmacen.Enabled = True
    End Sub
    Sub BLOQUEA(ByVal P As Boolean, ByVal P1 As Boolean)
        txtcodcliente.Enabled = P
        txtcantidad.Enabled = P
        txtdesarticulo.Enabled = P
        BTNCLIENTE.Enabled = P
        BTNGUARDAR.Enabled = P
        BTNCANCELAR.Enabled = P
        BTNELIMINAR.Enabled = P1
        BTNNUEVO.Enabled = P1
        txtpeso.Enabled = P
        txtmonto.Enabled = P
        BtnBuscaGuiaTran.Enabled = P1
        btnobs.Enabled = P
        cbotipopre.Enabled = P
        DateTimePicker1.Enabled = P
        DateTimePicker2.Enabled = P
        cbotipopago.Enabled = P
        'calmacen.Enabled = P
        DTGGUITRAN.Enabled = P
    End Sub
    Sub limpia()
        'limpiatextbox(Me)
        Me.txtnumeroguia.Text = ""
        Me.txtnumeroguia.Text = ""
        Me.txtcodcliente.Text = ""
        Me.txtruc.Text = ""
        Me.txtdescliente.Text = ""
        Me.txtdireccion.Text = ""
        Me.txtmonto.Text = "0"
        Me.txtpeso.Text = "0"
        Me.txtdesarticulo.Text = ""
        Me.txtcantidad.Text = "0"
        Me.txtsubt.Text = "0.00"
        Me.txtigv.Text = "0.00"
        Me.txttot.Text = "0.00"
        Me.DTGGUITRAN.Refresh()
        Me.txtcodcliente.Focus()
        AStrDomP = ""
        AStrDistP = ""
        AStrProvP = ""
        AStrDomD = ""
        AStrDistD = ""
        AStrProvD = ""
        AStrDestina = ""
        AStrRucDestina = ""
        AStrDniDestina = ""
        AStrRemi = ""
        AStrRucRemi = ""
        AStrDniRemi = ""
        AStrObvs = ""
        AStrCodtransp = ""
        AStrDesctransp = ""
        AStrRuctransp = ""
        AStrBrevete = ""
        AStrMarca = ""
        AStrPlaca = ""
        AStrObsGuiaTran = ""
        AStrNrocert = ""
        AStrConfigVeh = ""
        AStrEmpresaSubCont = ""
        AStrRucEmpSubCont = ""
    End Sub
    Sub FormatGrid()
        Try
            Dim grdTableStyle1 As New DataGridTableStyle
            With grdTableStyle1
                .AlternatingBackColor = Color.GhostWhite
                .MappingName = ATblDet.TableName
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            Dim grdColStyle1 As New DataGridTextBoxColumn
            With grdColStyle1
                .HeaderText = "Item"
                .MappingName = "iditem"
                .Width = 50
            End With

            Dim grdColStyle2 As New DataGridTextBoxColumn
            With grdColStyle2
                .HeaderText = "Descripción"
                .MappingName = "descripcion"
                .Width = 300
            End With

            Dim grdColStyle3 As New DataGridTextBoxColumn
            With grdColStyle3
                .HeaderText = "Cantidad_"
                .MappingName = "CANTIDAD"
                .Width = 90
                .Format = FACT_GFormatodeNumero(0)
            End With

            Dim grdColStyle4 As New DataGridTextBoxColumn
            With grdColStyle4
                .HeaderText = "Peso_"
                .MappingName = "peso"
                .Width = 90
                .Format = FACT_GFormatodeNumero(0)
            End With
            Dim grdColStyle5 As New DataGridTextBoxColumn
            With grdColStyle5
                .HeaderText = "Medida"
                .MappingName = "umedida"
                .Width = 90
            End With
            Dim grdColStyle6 As New DataGridTextBoxColumn
            With grdColStyle6
                .HeaderText = "Precio"
                .MappingName = "TOTBAS"
                .Width = 90
                .Format = FACT_GFormatodeNumero(0)
            End With
            grdTableStyle1.GridColumnStyles.AddRange _
                (New DataGridColumnStyle() _
                {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5, grdColStyle6})
            DTGGUITRAN.TableStyles.Add(grdTableStyle1)
        Catch
        End Try
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        If MessageBox.Show("Seguro de Cancelar el Proceso", DesEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            txtnumeroguia.Enabled = True
            txtnumeroguia2.Enabled = True
            HABILITARCONTROLES()
            BTNNUEVO.Enabled = True
            BTNGUARDAR.Enabled = False
            BTNREPORTE.Enabled = False
            CAyuda.Ejecutar("NSP_DEL_GUIATRANS", ADblCorrela, codempresa)
            Call limpia()
            txtsubt.Text = "0.00"
            txtigv.Text = "0.00"
            txttot.Text = "0.00"
            BOTONES(True, False, False, False)
            btnobs.Enabled = False
            BLOQUEA(False, True)
            txtnumeroguia.Text = ""
            txtnumeroguia2.Text = ""
            ATblDet.Clear()
            ABoolEstado = True
            ABoolMod = True
        End If

    End Sub
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNELIMINAR.Enabled = ELIMINAR
    End Sub
    Private Sub txtdesarticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesarticulo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcantidad.Focus()
        End If
    End Sub
    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            Me.txtcantidad.Focus()
        End If

        If Keyascii = 13 Then
            txtpeso.Focus()
        End If
    End Sub
    Private Sub txtpeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpeso.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            Me.txtpeso.Focus()
        End If

        If Keyascii = 13 Then
            cbounidadventa.Focus()
        End If
    End Sub
    Private Sub cbounidadventa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbounidadventa.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtmonto.Focus()
        End If
    End Sub
    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonto.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Dim ADblTotBas, ADblTotExt, ADblIgvBas, ADbIgvExt, ADblSubTotBas, ADblSubTotExt As Double
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            Me.txtmonto.Focus()
        End If

        If Keyascii = 13 Then
            If Trim(txtdesarticulo.Text) = "" Then
                MessageBox.Show("Ingrese Una Descripcion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdesarticulo.Focus()
                Exit Sub
            End If
            'If CSng(GVDATOVACIO(txtcantidad.Text)) = 0 Then
            '    MessageBox.Show("Ingrese Una Cantidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    txtcantidad.Focus()
            '    Exit Sub
            'End If
            If CSng(GVDATOVACIO(txtpeso.Text)) = 0 Then
                MessageBox.Show("Ingrese Un Peso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpeso.Focus()
                Exit Sub
            End If
            If CSng(GVDATOVACIO(txtmonto.Text)) = 0 Then
                MessageBox.Show("Ingrese Un Monto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtmonto.Focus()
                Exit Sub
            End If
            If cbotipopre.SelectedValue = CDMONBASE Then
                ADblTotBas = CSng(txtmonto.Text)
                ADblTotExt = CSng(txtmonto.Text) / CSng(txtcambio.Text)
                ADblIgvBas = 0
                ADbIgvExt = 0
                ADblSubTotBas = ADblTotBas - ADblIgvBas
                ADblSubTotExt = ADblTotExt - ADbIgvExt
            Else
                ADblTotBas = CSng(txtmonto.Text) * CSng(txtcambio.Text)
                ADblTotExt = CSng(txtmonto.Text)
                ADblIgvBas = 0
                ADbIgvExt = 0
                ADblSubTotBas = ADblTotBas - ADblIgvBas
                ADblSubTotExt = ADblTotExt - ADbIgvExt
            End If
            If ABoolGrab = True Then
                AIntResp = CAyuda.Ejecutar("NSP_upd_TMP_GUIATRANDET", CDbl(ADblCorrela), txtnumeroguia2.Text & txtnumeroguia.Text, DTGGUITRAN.Item(DTGGUITRAN.CurrentRowIndex, 0), codempresa, txtdesarticulo.Text, cbounidadventa.SelectedValue, CSng(txtcantidad.Text), CSng(txtpeso.Text), ADblTotBas, ADblTotExt, ADblIgvBas, ADbIgvExt, ADblSubTotBas, ADblSubTotExt, AStrObsGuiaTran)
                ABoolGrab = False
            Else
                AIntResp = CAyuda.Ejecutar("NSP_ins_TMPGUIATRANDET", CDbl(ADblCorrela), txtnumeroguia2.Text & txtnumeroguia.Text, 0, Me.DateTimePicker1.Value, txtdesarticulo.Text, cbounidadventa.SelectedValue, CSng(txtcantidad.Text), CSng(txtpeso.Text), ADblTotBas, ADblTotExt, ADblIgvBas, ADbIgvExt, ADblSubTotBas, ADblSubTotExt, codempresa.ToString(), AStrObsGuiaTran, "S", "PENDIENTE")
            End If

            ATblDet = CAyuda.ListarDatos("NSP_SELECT_LISTAGUIATRAN", ADblCorrela, codempresa).Tables(0)
            DTGGUITRAN.DataSource = ATblDet

            Dim ADblA1, ADblA2 As Double
            Dim AIntI As New Integer
            Dim ADblCont As Double
            ADblCont = ATblDet.Rows.Count
            For AIntI = 0 To ATblDet.Rows.Count - 1
                ADblA1 += Val(ATblDet.Rows(AIntI)(6))
                ADblA2 += Val(ATblDet.Rows(AIntI)(8))
            Next

            Me.txttot.Text = ADblA1.ToString("###0.00")
            Me.txtigv.Text = ADblA2.ToString("###0.00")
            Me.txtsubt.Text = Val(ADblA1 - ADblA2).ToString("###0.00")

            Me.txtmonto.Text = "0"
            Me.txtpeso.Text = "0"
            Me.txtdesarticulo.Text = ""
            Me.txtcantidad.Text = "0"
            Me.txtdesarticulo.Focus()
            cbotipopre.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            '   calmacen.Enabled = False
            cbotipopago.Enabled = False
        End If

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                  ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If DTGGUITRAN.Focus = True Then
                        Try
                            txtdesarticulo.Text = DTGGUITRAN.Item(DTGGUITRAN.CurrentRowIndex, 1)
                            txtcantidad.Text = DTGGUITRAN.Item(DTGGUITRAN.CurrentRowIndex, 2)
                            txtpeso.Text = DTGGUITRAN.Item(DTGGUITRAN.CurrentRowIndex, 3)
                            cbounidadventa.SelectedValue = DTGGUITRAN.Item(DTGGUITRAN.CurrentRowIndex, 4)
                            txtmonto.Text = DTGGUITRAN.Item(DTGGUITRAN.CurrentRowIndex, 5)
                            AStrObsGuiaTran = ""
                            AStrObsGuiaTran = CAyuda.ListarDatos("NSP_SELECT_LISTATMPGUIATRANCPARAM", codempresa, ADblCorrela, DTGGUITRAN.Item(DTGGUITRAN.CurrentRowIndex, 0)).Tables(0).Rows(0)("obs")
                            ABoolGrab = True
                            txtdesarticulo.Focus()

                        Catch x As Exception
                        End Try
                    End If
                Case Keys.F3
                    If DTGGUITRAN.Focus = True Then
                        Try
                            CAyuda.Ejecutar("NSP_del_TMP_GUIATRANDET", ADblCorrela, codempresa, DTGGUITRAN.Item(DTGGUITRAN.CurrentRowIndex, 0))
                            ATblDet = CAyuda.ListarDatos("NSP_SELECT_LISTAGUIATRAN", ADblCorrela, codempresa).Tables(0)
                            DTGGUITRAN.DataSource = ATblDet

                            Dim ADblA1, ADblA2 As Double
                            Dim AIntI As New Integer
                            Dim ADblCont As Double
                            ADblCont = ATblDet.Rows.Count
                            For AIntI = 0 To ATblDet.Rows.Count - 1
                                ADblA1 += Val(ATblDet.Rows(AIntI)(6))
                                ADblA2 += Val(ATblDet.Rows(AIntI)(8))
                            Next

                            Me.txttot.Text = ADblA1.ToString("###0.00")
                            Me.txtigv.Text = ADblA2.ToString("###0.00")
                            Me.txtsubt.Text = Val(ADblA1 - ADblA2).ToString("###0.00")

                        Catch x As Exception

                        End Try
                    End If
            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click


        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DateTimePicker1.Value.Year
        MES = DateTimePicker1.Value.Month


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









        Dim ADblNroGuiaTran As Double
        Dim ADblTotBas, ADblTotExt, ADblIgvBas, ADbIgvExt, ADblSubTotBas, ADblSubTotExt As Double

        If cbotipopre.SelectedValue = cdmonbase Then
            ADblTotBas = CSng(txttot.Text)
            ADblTotExt = CSng(txttot.Text) / CSng(txtcambio.Text)
            ADblIgvBas = CSng(txtigv.Text)
            ADbIgvExt = CSng(txtigv.Text) / CSng(txtcambio.Text)
            ADblSubTotBas = ADblTotBas - ADblIgvBas
            ADblSubTotExt = ADblTotExt - ADbIgvExt
        Else
            ADblTotBas = CSng(txttot.Text) * CSng(txtcambio.Text)
            ADblTotExt = CSng(txttot.Text)
            ADblIgvBas = CSng(txtigv.Text) * CSng(txtcambio.Text)
            ADbIgvExt = CSng(txtigv.Text)
            ADblSubTotBas = ADblTotBas - ADblIgvBas
            ADblSubTotExt = ADblTotExt - ADbIgvExt
        End If

        If ATblDet.Rows.Count <> 0 Then
            If txtnumeroguia.Text = "" And txtnumeroguia2.Text = "" Then
                MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If AStrCodtransp = "" Then
                MessageBox.Show("INGRESE CODIGO TRANSPORTISTA", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim AIntNroVueltas As Integer
            Dim AIntInicio As Integer
            AIntNroVueltas = Format(Math.Ceiling(ATblDet.Rows.Count / GstrItemGuia), "00.0")
            For AIntInicio = 1 To AIntNroVueltas
                ADblNroGuiaTran = CAyuda.ListarDatos("NSP_SELECT_OBTIENE_CORRELATIVO_GUIATRAN", NROPTOVTA.ToString.Trim, codempresa).Tables(0).Rows(0)(0)
                AIntResp = CAyuda.Ejecutar("NSP_ins_GUIATRANCAB", ADblNroGuiaTran, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value, ADblTotExt, ADblTotBas, ADbIgvExt, ADblIgvBas, ADblSubTotExt, ADblSubTotBas, cbotipopre.SelectedValue, cbotipopago.SelectedValue, calmacen.SelectedValue, txtcodcliente.Text, AStrDomP, AStrDistP, AStrProvP, AStrDomD, AStrProvD, AStrDistD, AStrRemi, AStrRucRemi, AStrDniRemi, AStrDestina, AStrRucDestina, AStrDniDestina, AStrCodtransp, AStrRuctransp, AStrDesctransp, AStrBrevete, AStrMarca, AStrPlaca, AStrNrocert, AStrConfigVeh, AStrEmpresaSubCont, AStrRucEmpSubCont, AStrObvs, txtcambio.Text, cbotipopre.SelectedValue, CodUsuario, codempresa, "PENDIENTE", NROPTOVTA.ToString.Trim, CSng(GstrItemGuia), ADblCorrela)
                If AIntResp = 0 Then
                    MessageBox.Show("Error durante la Operacion", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                GeneraReporte(ADblNroGuiaTran)
            Next
            MessageBox.Show("Registro Guardado Correctamente !!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtnumeroguia2.Text & txtnumeroguia.Text & "','INSERT','GUIATRANSPORT','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Call BOTONES(True, False, False, False)
            Me.DTGGUITRAN.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
            BLOQUEA(False, True)
            ABoolMod = True
        End If
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    Private Sub BtnBuscaGuiaTran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscaGuiaTran.Click
        Dim AForm As New frm_gridguia
        AIntValor = 1
        AForm.Establecer_Almacen = False
        ABoolMod = False
        ABoolObs = False
        ABoolEstado = False
        AForm.AFrmGuiaTran = Me
        AForm.ShowDialog(Me)

        If ABoolEstadoDoc Then
            BOTONES(True, False, False, False)
            BTNCANCELAR.Enabled = True
            MessageBox.Show("GUIA TRANSPORTISTA ANULADA.........................!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ABoolEstadoDoc = False
            BTNREPORTE.Enabled = True
        End If
        BTNREPORTE.Enabled = True
    End Sub
    Private Sub btnobsitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnobsitem.Click
        Dim men As New FrmObsItem
        AIntValor = 1

        men.AFrmGuiaTran = Me
        men.txtobsitem.Text = AStrObsGuiaTran
        men.txtobsitem.Focus()
        men.ShowDialog(Me)
        cbounidadventa.Focus()
    End Sub

    Private Sub BTNREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNREPORTE.Click
        GeneraReporte(txtnumeroguia2.Text & txtnumeroguia.Text)
    End Sub
    Sub GeneraReporte(ByVal Nroguia As Double)
        Try
            crRpt.ReportFileName = rutareporte & "Rrptguitran.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, Nroguia)
            crRpt.set_StoredProcParam(1, codempresa)
            crRpt.WindowShowPrintBtn = True
            crRpt.WindowShowExportBtn = True
            crRpt.WindowShowPrintSetupBtn = True
            crRpt.WindowShowSearchBtn = True
            crRpt.Destination = Crystal.DestinationConstants.crptToPrinter
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch
            MessageBox.Show("Configure Una Impresora !!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If Trim(AStrEstadoDoc) = "CANCELADO" Then
            MessageBox.Show("! El Documento No Puede Ser Anulado pq Esta Cancelado!", "Información", MessageBoxButtons.OK)
            Exit Sub
        End If
        If MessageBox.Show("¿Desea Anular el Registro Seleccionado?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            ATblDet.Clear()
            AIntResp = CAyuda.Ejecutar("NSP_DEL_GUIATRAN", txtnumeroguia2.Text & txtnumeroguia.Text, codempresa)
            Me.DTGGUITRAN.Refresh()
            If AIntResp <> 0 Then
                MessageBox.Show("Registro Anulado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtnumeroguia2.Text & txtnumeroguia.Text & "','DELETE','GUIATRANSPORT','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                limpia()
            End If
        End If
    End Sub


    Private Sub txtcodcliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodcliente.KeyDown
        If e.KeyCode = Keys.F2 Then
            BTNCLIENTE_Click(sender, e)
        End If
        If e.KeyCode = Keys.Enter Then
            Try
                ds.Clear()
                Conecta("select C.codcliente as codigo,paterno as apellidop,materno as apellidom,nombres as nombre,razonsocial as razon,ruc as ruc ,datoadjunto,direccion from cliente C,CLIENTE_PTOVTA CP where (C.codcliente=CP.codcliente AND CP.NROPTOVTA='" & NROPTOVTA.ToString.Trim & "' AND C.codempresa='" & codempresa & "' and estado=0 and C.codcliente like '" & Me.txtcodcliente.Text.Trim & "%')", "pa")
                oda.Fill(ds)
                ' Me.DataGrid1.DataSource = ds.Tables(0)

                Me.txtruc.Text = ds.Tables(0).Rows(0)(5).ToString
                Me.txtdescliente.Text = ds.Tables(0).Rows(0)(6).ToString
                Me.txtdireccion.Text = ds.Tables(0).Rows(0)(7).ToString
                Me.cbotipopre.Focus()

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtcodcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodcliente.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))

        If Keyascii = 13 Then
            ' cbotipopre.Focus()
        End If
    End Sub

    Private Sub cbotipopre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotipopre.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))

        If Keyascii = 13 Then
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))

        If Keyascii = 13 Then
            DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker2.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))

        If Keyascii = 13 Then
            cbotipopago.Focus()
        End If
    End Sub

    Private Sub cbotipopago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotipopago.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))

        If Keyascii = 13 Then
            txtdesarticulo.Focus()
        End If
    End Sub

    Private Sub txtmonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmonto.TextChanged

    End Sub

    Private Sub DTGGUITRAN_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DTGGUITRAN.Navigate

    End Sub

    Private Sub txtcodcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodcliente.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim numero As Integer = CInt(txtnumeroguia2.Text & txtnumeroguia.Text)
        Try
            AIntResp = CAyuda.Ejecutar("sp_Eliminar_guiaTrans", numero, codempresa)

            If AIntResp = 0 Then

                MessageBox.Show("No se puede eliminar porque la guia esta anulada", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            Else
                MessageBox.Show("Se elimino correctamente", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("No se puede eliminar porque la guia esta anulada", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

End Class
