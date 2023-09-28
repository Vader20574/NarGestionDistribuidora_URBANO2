Imports System.Data
Imports Servicios.Implementacion
Imports Servicios.Interfaces.Factura
Imports Servicios.Interfaces.FacturaElectronica.Peticiones
Imports vb = Microsoft.VisualBasic
Public Class FrmNotaDebito
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
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtreferncia1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtreferncia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtobs As System.Windows.Forms.TextBox
    Friend WithEvents txtcambio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnrorefe As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnronotcred As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbmoneda As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmboperador As System.Windows.Forms.ComboBox
    Friend WithEvents btnreferncia As System.Windows.Forms.Button
    Friend WithEvents btnnotcred As System.Windows.Forms.Button
    Friend WithEvents cmbreferncia As System.Windows.Forms.ComboBox
    Friend WithEvents txtptovta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BTNREFERENCIA As System.Windows.Forms.Button
    Friend WithEvents TXTCODPAGADOR As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMPAGADOR As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbTipoNotaDev As ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotaDebito))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.crRpt = New AxCrystal.AxCrystalReport()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtreferncia1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtreferncia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtobs = New System.Windows.Forms.TextBox()
        Me.txtcambio = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnrorefe = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnronotcred = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbmoneda = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtigv = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.cmboperador = New System.Windows.Forms.ComboBox()
        Me.btnreferncia = New System.Windows.Forms.Button()
        Me.btnnotcred = New System.Windows.Forms.Button()
        Me.cmbreferncia = New System.Windows.Forms.ComboBox()
        Me.txtptovta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbTipoNotaDev = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXTCODPAGADOR = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXTNOMPAGADOR = New System.Windows.Forms.TextBox()
        Me.BTNREFERENCIA = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(664, 496)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(426, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 18)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "-"
        '
        'txtreferncia1
        '
        Me.txtreferncia1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferncia1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreferncia1.Location = New System.Drawing.Point(440, 54)
        Me.txtreferncia1.MaxLength = 8
        Me.txtreferncia1.Name = "txtreferncia1"
        Me.txtreferncia1.Size = New System.Drawing.Size(72, 21)
        Me.txtreferncia1.TabIndex = 10
        Me.txtreferncia1.Text = "TEXTBOX5"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(80, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Moneda :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtreferncia
        '
        Me.txtreferncia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreferncia.Location = New System.Drawing.Point(384, 54)
        Me.txtreferncia.MaxLength = 4
        Me.txtreferncia.Name = "txtreferncia"
        Me.txtreferncia.Size = New System.Drawing.Size(40, 21)
        Me.txtreferncia.TabIndex = 8
        Me.txtreferncia.Text = "TEXTBOX5"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(328, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Nro Doc :"
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(105, 48)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(351, 21)
        Me.txtnombre.TabIndex = 3
        Me.txtnombre.Text = "TXT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Razón Social :"
        '
        'txtobs
        '
        Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobs.Location = New System.Drawing.Point(16, 248)
        Me.txtobs.MaxLength = 100
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobs.Size = New System.Drawing.Size(680, 216)
        Me.txtobs.TabIndex = 24
        '
        'txtcambio
        '
        Me.txtcambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcambio.Location = New System.Drawing.Point(648, 104)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.ReadOnly = True
        Me.txtcambio.Size = New System.Drawing.Size(104, 21)
        Me.txtcambio.TabIndex = 22
        Me.txtcambio.Text = "TextBox7"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(568, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Tipo Cambio :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Operador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(578, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha Doc :"
        '
        'txtruc
        '
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruc.Location = New System.Drawing.Point(105, 96)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.ReadOnly = True
        Me.txtruc.Size = New System.Drawing.Size(128, 21)
        Me.txtruc.TabIndex = 8
        Me.txtruc.Text = "TEXTBOX6"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(65, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "RUC :"
        '
        'txtnrorefe
        '
        Me.txtnrorefe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnrorefe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnrorefe.Location = New System.Drawing.Point(105, 24)
        Me.txtnrorefe.Name = "txtnrorefe"
        Me.txtnrorefe.ReadOnly = True
        Me.txtnrorefe.Size = New System.Drawing.Size(96, 21)
        Me.txtnrorefe.TabIndex = 1
        Me.txtnrorefe.Text = "TEXTBOX5"
        '
        'txtdireccion
        '
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(105, 72)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(351, 21)
        Me.txtdireccion.TabIndex = 6
        Me.txtdireccion.Text = "TEXTBOX4"
        '
        'txtnronotcred
        '
        Me.txtnronotcred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnronotcred.Location = New System.Drawing.Point(424, 16)
        Me.txtnronotcred.Name = "txtnronotcred"
        Me.txtnronotcred.Size = New System.Drawing.Size(95, 21)
        Me.txtnronotcred.TabIndex = 0
        Me.txtnronotcred.Text = "TextBox1"
        Me.txtnronotcred.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dirección :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CódCliente :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo Documento :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nota de Credito Nro :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbmoneda
        '
        Me.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmoneda.Enabled = False
        Me.cmbmoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmoneda.Location = New System.Drawing.Point(136, 80)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Size = New System.Drawing.Size(176, 21)
        Me.cmbmoneda.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(712, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 264)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 12
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(19, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "&Editar Nº"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(20, 139)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(83, 23)
        Me.btnreporte.TabIndex = 4
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(20, 168)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(20, 197)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNCERRAR.TabIndex = 6
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(20, 81)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNMODIFICAR.TabIndex = 2
        Me.BTNMODIFICAR.Text = "&Consultar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(20, 110)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.Text = "&Anular"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(20, 52)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(20, 23)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(83, 23)
        Me.BTNNUEVO.TabIndex = 0
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttotal)
        Me.GroupBox3.Controls.Add(Me.txtigv)
        Me.GroupBox3.Controls.Add(Me.txtsubtotal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 472)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 48)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(528, 16)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(96, 21)
        Me.txttotal.TabIndex = 5
        Me.txttotal.Text = "0.00"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtigv
        '
        Me.txtigv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigv.Location = New System.Drawing.Point(328, 16)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(96, 21)
        Me.txtigv.TabIndex = 3
        Me.txtigv.Text = "0.00"
        Me.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotal.Location = New System.Drawing.Point(136, 16)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(96, 21)
        Me.txtsubtotal.TabIndex = 1
        Me.txtsubtotal.Text = "0.00"
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(464, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Total   S/ :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(280, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "I.G.V. :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sub Total :"
        '
        'dtpfecha
        '
        Me.dtpfecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(648, 54)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(104, 21)
        Me.dtpfecha.TabIndex = 13
        '
        'cmboperador
        '
        Me.cmboperador.Enabled = False
        Me.cmboperador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboperador.Location = New System.Drawing.Point(384, 80)
        Me.cmboperador.Name = "cmboperador"
        Me.cmboperador.Size = New System.Drawing.Size(160, 21)
        Me.cmboperador.TabIndex = 17
        '
        'btnreferncia
        '
        Me.btnreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreferncia.ImageIndex = 5
        Me.btnreferncia.ImageList = Me.ImageList1
        Me.btnreferncia.Location = New System.Drawing.Point(201, 56)
        Me.btnreferncia.Name = "btnreferncia"
        Me.btnreferncia.Size = New System.Drawing.Size(8, 8)
        Me.btnreferncia.TabIndex = 4
        '
        'btnnotcred
        '
        Me.btnnotcred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnotcred.ImageIndex = 5
        Me.btnnotcred.ImageList = Me.ImageList1
        Me.btnnotcred.Location = New System.Drawing.Point(264, 29)
        Me.btnnotcred.Name = "btnnotcred"
        Me.btnnotcred.Size = New System.Drawing.Size(40, 23)
        Me.btnnotcred.TabIndex = 2
        '
        'cmbreferncia
        '
        Me.cmbreferncia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreferncia.Location = New System.Drawing.Point(136, 54)
        Me.cmbreferncia.Name = "cmbreferncia"
        Me.cmbreferncia.Size = New System.Drawing.Size(176, 21)
        Me.cmbreferncia.TabIndex = 6
        '
        'txtptovta
        '
        Me.txtptovta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtptovta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptovta.Location = New System.Drawing.Point(648, 80)
        Me.txtptovta.Name = "txtptovta"
        Me.txtptovta.ReadOnly = True
        Me.txtptovta.Size = New System.Drawing.Size(176, 21)
        Me.txtptovta.TabIndex = 19
        Me.txtptovta.Text = "TEXTBOX6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(569, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Punto Venta :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtnrorefe)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Controls.Add(Me.btnreferncia)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 128)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.cmbTipoNotaDev)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TXTCODPAGADOR)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TXTNOMPAGADOR)
        Me.GroupBox4.Controls.Add(Me.BTNREFERENCIA)
        Me.GroupBox4.Location = New System.Drawing.Point(496, 131)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(336, 101)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 13)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Tipo Nota Debito :"
        '
        'cmbTipoNotaDev
        '
        Me.cmbTipoNotaDev.FormattingEnabled = True
        Me.cmbTipoNotaDev.Location = New System.Drawing.Point(109, 17)
        Me.cmbTipoNotaDev.Name = "cmbTipoNotaDev"
        Me.cmbTipoNotaDev.Size = New System.Drawing.Size(210, 21)
        Me.cmbTipoNotaDev.TabIndex = 54
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "CodPagador :"
        '
        'TXTCODPAGADOR
        '
        Me.TXTCODPAGADOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCODPAGADOR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCODPAGADOR.Location = New System.Drawing.Point(96, 44)
        Me.TXTCODPAGADOR.Name = "TXTCODPAGADOR"
        Me.TXTCODPAGADOR.ReadOnly = True
        Me.TXTCODPAGADOR.Size = New System.Drawing.Size(96, 21)
        Me.TXTCODPAGADOR.TabIndex = 1
        Me.TXTCODPAGADOR.Text = "TEXTBOX5"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 70)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Razón Social :"
        '
        'TXTNOMPAGADOR
        '
        Me.TXTNOMPAGADOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNOMPAGADOR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMPAGADOR.Location = New System.Drawing.Point(96, 68)
        Me.TXTNOMPAGADOR.Name = "TXTNOMPAGADOR"
        Me.TXTNOMPAGADOR.ReadOnly = True
        Me.TXTNOMPAGADOR.Size = New System.Drawing.Size(216, 21)
        Me.TXTNOMPAGADOR.TabIndex = 4
        Me.TXTNOMPAGADOR.Text = "TXT"
        '
        'BTNREFERENCIA
        '
        Me.BTNREFERENCIA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREFERENCIA.ImageIndex = 5
        Me.BTNREFERENCIA.ImageList = Me.ImageList1
        Me.BTNREFERENCIA.Location = New System.Drawing.Point(160, 32)
        Me.BTNREFERENCIA.Name = "BTNREFERENCIA"
        Me.BTNREFERENCIA.Size = New System.Drawing.Size(8, 8)
        Me.BTNREFERENCIA.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(512, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(192, 32)
        Me.TextBox2.MaxLength = 8
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(72, 21)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(136, 32)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(40, 21)
        Me.TextBox1.TabIndex = 3
        '
        'FrmNotaDebito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(840, 520)
        Me.Controls.Add(Me.txtptovta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtreferncia1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtreferncia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtobs)
        Me.Controls.Add(Me.txtcambio)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnronotcred)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.cmbmoneda)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.cmboperador)
        Me.Controls.Add(Me.btnnotcred)
        Me.Controls.Add(Me.cmbreferncia)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(856, 559)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(856, 559)
        Me.Name = "FrmNotaDebito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Nota Debito"
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public AObjBus As New ClsAyuda
    Public ATblCli As New DataTable
    Public AIntResp As Integer
    Public ASngImpuesto As Single
    Public ATblNotCred As New DataTable
    Public AIntValor As Integer
    Public busqueda As Integer
    Public activa As Integer


    Dim IDCODIGO, TipDocNtaCred As String
    Dim LETRADOC As String


    Sub LLENA()
        Dim i As Short
        Dim numeror As String
        Dim cargar As Integer


        If cargar = 0 Then
            TipDocNtaCred = Me.cmbreferncia.SelectedValue.ToString
            ATblCli = AObjBus.ListarDatos("NSP_SELECT_LISTAVENTACABNOTCRED", TipDocNtaCred.ToString(), IDCODIGO, codempresa.ToString(), Tabla).Tables(0)

            If ATblCli.Rows.Count = 0 Then
                MessageBox.Show("No existen relaciones entre la venta y el vendedor para efectuar la operación. Verifique que el documento tenga un vendedor que existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            txtreferncia.Text = Format(CDbl(Mid(ATblCli.Rows(0)("NRODOCU"), 1, Len(Trim(ATblCli.Rows(0)("NRODOCU"))) - 8)), "000")
            txtreferncia1.Text = Mid(ATblCli.Rows(0)("NRODOCU"), Len(Trim(ATblCli.Rows(0)("NRODOCU"))) + 1 - 8, 8)




            'Dim m As New ListViewItem
            'm.SubItems.Add(Me.cmbreferncia.SelectedValue.ToString())
            'm.SubItems.Add(ATblCli.Rows(0)("NRODOCU"))
            'Me.ListView1.Items.Add(m)

            txtnrorefe.Text = GValidarNulos(ATblCli.Rows(0)("CODCLIENTE"))
            txtruc.Text = GValidarNulos(ATblCli.Rows(0)("RUCCLIENTE"))
            txtnombre.Text = GValidarNulos(ATblCli.Rows(0)("DESCLIENTE"))
            txtdireccion.Text = GValidarNulos(ATblCli.Rows(0)("DIRCLIENTE"))
            cmboperador.SelectedValue = GValidarNulos(ATblCli.Rows(0)("CODVEND"))
            txtptovta.Text = GValidarNulos(ATblCli.Rows(0)("NROPTOVTA"))
            dtpfecha.Value = GValidarNulos(ATblCli.Rows(0)("FECDOCUM"))

            'Almacennotcred = GValidarNulos(ATblCli.Rows(0)("CDZONA"))
            'estadonotcred = IIf(vb.IsDBNull(ATblCli.Rows(0)("ESTADO")), "", ATblCli.Rows(0)("ESTADO"))
            'ADateFechaProcesoNotCred = GValidarNulos(ATblCli.Rows(0)("FECPROCESO"))
            'CDCLIENTEDEP = GValidarNulos(ATblCli.Rows(0)("CODDEP"))

            'Dim dt_data As New DataTable
            'dt_data = CAyuda.ListarDatos("nspselclie", CDCLIENTEDEP, codempresa).Tables(0)
            'conecta1("nspselclie '" & CDCLIENTEDEP & "','" & Variables.CODEMP & "'", "clie")
            'If dt_data.Rows.Count > 0 Then
            '    Me.TXTNOMPAGADOR.Text = dt_data.Rows(0)(0)
            'End If
            'Dim DETTABLA As String
            'If Tabla = "VENTACAB" Then
            '    DETTABLA = "VENTADET"
            'Else
            '    DETTABLA = "VENTD" + Strings.Right(Tabla, 6)
            'End If


            'CAyuda.Ejecutar("NSP_INS_TMP_NTACREDDET", ADblCORRELATIVO, TipDocNtaCred.ToString(), CDbl(ATblCli.Rows(0)("NRODOCU")), DETTABLA, codempresa)


            'Guarda("NSP_INS_TMP_NTACREDDET " & ADblCORRELATIVO & ",'" & TipDocNtaCred.ToString() & "','" & CDbl(ATblCli.Rows(0)("NRODOCU")) & "','" & DETTABLA & "','" & codempresa & "'")


            'Me.ListView1.Items(Me.ListView1.Items.Count - 1).Selected = True
            'Me.ListView1.Items(Me.ListView1.Items.Count - 1).Focused = True

            'If rdbprodu.Checked = True Then
            '    ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET_varios", ADblCORRELATIVO, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim).Tables(0)
            'Else
            '    ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET_varios", ADblCORRELATIVO, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim).Tables(0)
            'End If

            'dtgnotcred.DataSource = ATblDetNot
            'AMonBasdoc = GValidarNulos(ATblCli.Rows(0)("CODMON"))
            '  TEXTBOX6.Text = NROPTOVTA.ToString.Trim
            txtcambio.Text = VCambioVta
            'rdbprodu.Enabled = False
            'rdbdinero.Enabled = False

        End If
        cargar = 0


    End Sub



    Private Sub FrmNotaDebito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LimpiarFormularios(Me)
            AObjBus.GCargaDataCombo(cmbreferncia, AObjBus.ListarDatos("NSP_SELECT_LISTATIPODOCNTACRE", codempresa.ToString()).Tables(0), "Código", "Descripción")
            AObjBus.GCargaDataCombo(cmboperador, AObjBus.ListarDatos("Nsp_Sele_Vendedores", codempresa.ToString()).Tables(0), "Codigo", "Descripcion")
            AObjBus.GCargaDataCombo(cmbmoneda, AObjBus.ListarDatos("NSP_Select_Listado_Moneda", codempresa.ToString()).Tables(0), "Código", "Descripción")
            txtcambio.Text = VCambioVta
            txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTADEBITO", NROPTOVTA.ToString, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
            Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 7)
            Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 7), 3)
            AObjBus.GCargaDataCombo(cmbTipoNotaDev, AObjBus.ListarDatos("Nsp_Sele_TipoNotaDev", codempresa.ToString()).Tables(0), "Codigo", "Descripcion")



            txtnronotcred.ReadOnly = True
            btnnotcred.Enabled = False
            BTNGUARDAR.Enabled = False
            txtobs.Text = ""
            txtigv.Text = "0.00"
            txtsubtotal.Text = "0.00"
            txttotal.Text = "0.00"
            txtptovta.Text = NROPTOVTA
            txtptovta.ReadOnly = True
            Me.cmbreferncia.Enabled = False
            Me.txtreferncia1.Enabled = False
            Me.txtreferncia.Enabled = False
            Me.dtpfecha.Enabled = False
            Me.txtobs.Enabled = False

            dtpfecha.Value = Format(vFechaActual, "dd/MM/yyyy")



        Catch x As Exception
            MessageBox.Show("Correlativo Mal configurado !! ..vaya a la configuraciòn de punto de venta y verifique !!", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End Try
    End Sub

    Private Sub btnreferncia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreferncia.Click
        Dim formu As New FrmBusqCliente
        formu.ShowDialog()
        Try
            If AboolCargarValor Then
                ATblCli = AObjBus.ListarDatos("NSP_SELE_clienteFac", codempresa.ToString(), formu.IDCODIGO, 0, NROPTOVTA).Tables(0)
                txtnrorefe.Text = ATblCli.Rows(0)(0)
                txtruc.Text = ATblCli.Rows(0)(3)
                txtnombre.Text = ATblCli.Rows(0)(1)
                'txtrazonsocial.Text = ATblCli.Rows(0)(2)
                txtdireccion.Text = ATblCli.Rows(0)(2)
                BTNGUARDAR.Enabled = True
                BTNMODIFICAR.Enabled = False
            End If
        Catch
        End Try
        AboolCargarValor = False
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        LimpiarFormularios(Me)
        txtobs.Text = ""
        txtigv.Text = "0.00"
        txtsubtotal.Text = "0.00"
        txttotal.Text = "0.00"
        txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTADEBITO", NROPTOVTA.ToString).Tables(0).Rows(0)(0)
        BTNMODIFICAR.Enabled = True
        BTNGUARDAR.Enabled = False
        btnnotcred.Enabled = False
        txtcambio.Text = VCambioVta
        txtptovta.Text = NROPTOVTA
        Me.cmbreferncia.Enabled = False
        Me.txtreferncia1.Enabled = False
        Me.txtreferncia.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.txtobs.Enabled = False
    End Sub

    Private Sub txtigv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtigv.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            txtigv.Focus()
        End If
        If Keyascii = 13 Then
            txttotal.Text = GMascaraDec_D(CDbl(GVDATOVACIO(txtsubtotal.Text)) + CDbl(GVDATOVACIO(txtigv.Text)))
            txttotal.Focus()
        End If
    End Sub


    Private Sub txtsubtotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsubtotal.KeyPress
        'Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        'Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))
        'If Keyascii = 0 Then
        '    e.Handled = True
        '    txtsubtotal.Focus()
        'End If
        'If Keyascii = 13 Then
        '    ASngImpuesto = AObjBus.ListarDatos("NSP_SELECT_IGV", codempresa).Tables(0).Rows(0)(0)
        '    txtigv.Text = GMascaraDec_D(CDbl(GVDATOVACIO(txtsubtotal.Text)) * (GValidarNulos(ASngImpuesto) / 100))
        '    txtigv.Focus()
        '    txtigv.SelectAll()
        'End If

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        'Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))
        ''If Keyascii = 0 Then
        ''    e.Handled = True
        ''    txtdevolver.Focus()
        ''End If
        Dim MONTOCIGV, VALORIGV As Double
        If Keyascii = 13 Then
            'If rdbdinero.Checked = True Then
            '  btnActualizar_Click(sender, e)
            'Else
            'TXTBULTO.Focus()
            'End If

            VALORIGV = ((PORCIGV / 100) + 1)

            MONTOCIGV = ((txtsubtotal.Text) / VALORIGV)
            txtsubtotal.Text = Format(MONTOCIGV, "#######0.00")
            txtigv.Text = Format(MONTOCIGV * (VALORIGV - 1), "#######0.00")
            txttotal.Text = Format(CDbl(txtsubtotal.Text) + CDbl(txtigv.Text), "#######0.00")

        End If


    End Sub

    Private Sub txttotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttotal.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            txttotal.Focus()
        End If
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub


    Private Sub BTNGUARDAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String

        AÑO = dtpfecha.Value.Year
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

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If
        '************************************************************************************************

        Dim CadNumdoc As String

        ATblNotCred = AObjBus.ListarDatos("sp_Buscar_NRONTACRED_X_CODIGO", txtnronotcred.Text, cmbreferncia.SelectedValue.ToString).Tables(0)
        If ATblNotCred.Rows.Count > 0 Then
            MsgBox("El numero de Nota de Debito ya existe..digite otro numero o congigure el numero", MsgBoxStyle.Information, "Nar Gestion")
            Exit Sub
        End If
        If Trim(txtobs.Text) = "" Then
            MsgBox("Ingrese Un detalle", MsgBoxStyle.Critical, "Nota de Credito")
            Exit Sub
        End If
        If CSng(GVDATOVACIO(txttotal.Text)) = 0 Then
            MsgBox("Total Nota Credito Mayor a Cero ", MsgBoxStyle.Critical, "Nota de Credito")
            Exit Sub
        End If
        If CSng(GVDATOVACIO(txtsubtotal.Text)) = 0 Then
            MsgBox("Total Nota Credito Mayor a Cero ", MsgBoxStyle.Critical, "Nota de Credito")
            Exit Sub
        End If
        If (GVDATOVACIO(txtreferncia.Text) = 0) Then
            MsgBox("Ingrese Nro. Documento", MsgBoxStyle.Critical, "Nota de Credito")
            txtreferncia.Focus()
            Exit Sub
        End If
        If (GVDATOVACIO(txtreferncia1.Text) = 0) Then
            MsgBox("Ingrese Nro. Documento", MsgBoxStyle.Critical, "Nota de Credito")
            txtreferncia1.Focus()
            Exit Sub
        End If


        If cmbreferncia.SelectedValue = "01" Then
            LETRADOC = "F"
        End If
        If cmbreferncia.SelectedValue = "03" Then
            LETRADOC = "B"
        End If
        If cmbreferncia.SelectedValue = "06" Then
            LETRADOC = "P"
        End If

        CadNumdoc = LETRADOC & txtreferncia.Text & "-" & txtreferncia1.Text
        VCdTipoDoc = "08"

        AIntResp = AObjBus.Ejecutar("NSP_ins_NTACREDCABSER", txtnronotcred.Text, VCdTipoDoc, CStr(CInt(txtreferncia.Text)) & txtreferncia1.Text, cmbmoneda.SelectedValue.ToString(), txtcambio.Text, cmboperador.SelectedValue.ToString(), dtpfecha.Value, GMascaraDec_D(GVDATOVACIO(txttotal.Text)), GMascaraDec_D(CDbl(GVDATOVACIO(txttotal.Text)) / CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(GVDATOVACIO(txtsubtotal.Text))), GMascaraDec_D(CDbl(GVDATOVACIO(txtsubtotal.Text)) / CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(GVDATOVACIO(txtigv.Text))), GMascaraDec_D(CDbl(GVDATOVACIO(txtigv.Text)) / CDbl(txtcambio.Text)), txtnrorefe.Text, txtruc.Text, txtnombre.Text, txtdireccion.Text, CodUsuario.ToString, NROPTOVTA.ToString, codempresa, txtobs.Text, "D", TXTCODPAGADOR.Text, cmbreferncia.SelectedValue.ToString, LETRADOC & TextBox1.Text, TextBox2.Text, CadNumdoc)
        'AObjBus.Ejecutar("sp_modificar_NUMERO_DEBITO", NROPTOVTA.ToString)

        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''FACTURACION ELECTRONICA ENVIO BASE''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''

        Dim IGV As Double
        Dim SUBTOTAL As Double
        Dim PERCEP As Double
        Dim TIPO_IGV As String
        Dim EMAIL As String
        Dim DNI As String

        Dim SERIE As String
        Dim NRODOCSIN As String = ""
        Dim NRODOCFINAL As String

        If EMIELECTRONIC = True Then
            If cmbreferncia.SelectedValue.Trim = "01" Or cmbreferncia.SelectedValue.Trim = "03" Then

                Dim TipoDoc As String
                TipoDoc = VCdTipoDoc
                VRuc = txtruc.Text
                VCodCliente = txtnrorefe.Text
                VNroDoc = txtnronotcred.Text

                IGV = CDbl(txtigv.Text)
                SUBTOTAL = CDbl(txtsubtotal.Text)
                PERCEP = 0

                If IGV > 0 Then
                    TIPO_IGV = "SI"
                Else
                    TIPO_IGV = "NO"
                End If

                Dim Table_VC2 As New DataTable
                Table_VC2 = TmpListarDatos("SP_SELECT_EMAIL_CLIENTE_ND   '" & VCdTipoDoc & "','" & VNroDoc & "'")
                If Table_VC2.Rows.Count > 0 Then
                    EMAIL = Table_VC2.Rows(0)("EMAIL").ToString()
                    DNI = Table_VC2.Rows(0)("DNI").ToString()
                    If VCodCliente = "888" Then
                        DNI = "88888888"
                    End If
                End If

                TipoDoc = VCdTipoDoc

                If cmbreferncia.SelectedValue = "01" Then
                    LETRADOC = "F"
                End If
                If cmbreferncia.SelectedValue = "03" Then
                    LETRADOC = "B"
                End If
                If cmbreferncia.SelectedValue = "06" Then
                    LETRADOC = "P"
                End If

                ' Dim FormatNroDoc As String
                '  FormatNroDoc = Format(VNroDoc, "0##-########")
                Dim NUMSERIE As String
                NUMSERIE = TextBox1.Text.Trim
                SERIE = LETRADOC + NUMSERIE
                ' NRODOCSIN = CStr(Microsoft.VisualBasic.Right(VNroDoc, 8))
                If Len(VNroDoc) = 8 Then
                    NRODOCSIN = "0" + CStr(Microsoft.VisualBasic.Right(VNroDoc, 7))
                End If

                ' NRODOCSIN = FormatNroDoc
                NRODOCFINAL = SERIE + "-" + NRODOCSIN

                Dim FormatNroDoc2 As String
                Dim SERIE2 As String
                Dim NRODOCFINAL2 As String
                Dim NRODOCSIN2 As String
                Dim NUMSERIE2 As String

                NUMSERIE2 = txtreferncia.Text.Trim
                SERIE2 = LETRADOC + NUMSERIE2
                NRODOCSIN2 = CStr(Microsoft.VisualBasic.Right(txtreferncia1.Text, 8))
                NRODOCFINAL2 = SERIE2 + "-" + NRODOCSIN2

                Dim dblTOTINAFECTO As Double
                'Dim TABLA_INAFECTO As New DataTable
                'TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO_NC  '" & TipoDoc & "','" & VNroDoc & "'  ")

                'If TABLA_INAFECTO.Rows.Count > 0 Then
                dblTOTINAFECTO = 0
                'End If

                Dim gestordefacturacionelectronica As IGestorDeFacturacionElectronica = New GestorDeFacturacionElectronica()

                Dim nuevohdocumento As New NuevaHdocumento

                nuevohdocumento.codi_cab = 0
                nuevohdocumento.esta_pod = 1
                nuevohdocumento.codi_caja = CStr(NROPTOVTA)
                nuevohdocumento.comp = VCdTipoDoc
                nuevohdocumento.serie = SERIE
                nuevohdocumento.nume = NRODOCSIN
                nuevohdocumento.fecha = Format(CDate(dtpfecha.Value), "dd/MM/yyyy")
                nuevohdocumento.codi_vend = cmboperador.SelectedValue
                nuevohdocumento.clie_docu = IIf(CStr(VRuc.Trim) <> "", CStr(VRuc.Trim), DNI)
                nuevohdocumento.clie_nomb = txtnombre.Text
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
                nuevohdocumento.codi_moti = cmbTipoNotaDev.SelectedValue
                nuevohdocumento.motivo = cmbTipoNotaDev.Text.ToString
                nuevohdocumento.doc_refe = NRODOCFINAL2
                nuevohdocumento.ValorResumen = 0.0
                nuevohdocumento.ValorHash = ""
                nuevohdocumento.DarBaja = 0
                nuevohdocumento.MotivoBaja = ""
                nuevohdocumento.ProcesarBaja = 0
                nuevohdocumento.Grabado = SUBTOTAL - dblTOTINAFECTO
                nuevohdocumento.IGV = IGV
                nuevohdocumento.Total = txttotal.Text
                nuevohdocumento.dire_lleg = ""
                nuevohdocumento.Guia_trans = ""
                nuevohdocumento.Envio_xml = 0
                nuevohdocumento.Clie_tipo = IIf(CStr(VRuc.Trim) <> "", 6, 1)
                nuevohdocumento.Fact_guia = "NO"
                nuevohdocumento.Exonerado = 0
                nuevohdocumento.Inafecto = dblTOTINAFECTO
                nuevohdocumento.percepcion = 0
                Dim CODCAB As Integer
                CODCAB = gestordefacturacionelectronica.CrearHdocumento(nuevohdocumento).codi_cab

                'Dim StrSql As String
                'StrSql = "SELECT TMP_NTACREDDET.ITEM,TMP_NTACREDDET.CDARTI, TMP_NTACREDDET.DSARTI, TMP_NTACREDDET.PRECIO, " &
                '                 "  TMP_NTACREDDET.CANTIDAD,  TMP_NTACREDDET.SUBTOTBAS,  '01' AS TIPOPRE," &
                '                       " TMP_NTACREDDET.TOTBAS, TMP_NTACREDDET.IGVBAS,(TMP_NTACREDDET.SUBTOTBAS/TMP_NTACREDDET.CANTIDAD) AS PRECSINIGV," &
                '                       "  TMP_NTACREDDET.MONTODESCBAS ,TMP_NTACREDDET.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC  " &
                '                 " FROM ARTICULO INNER JOIN TMP_NTACREDDET ON ARTICULO.CODARTI = TMP_NTACREDDET.CDARTI" &
                '                  " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                '              " INNER JOIN PRESENTACION ON PRESENTACION.codpres = TMP_NTACREDDET.CODPRES" &
                '            "  WHERE TMP_NTACREDDET.CORRNBR = " & CInt(ADblCORRELATIVO) & "  AND CANTIDAD_DEV > 0  ORDER BY TMP_NTACREDDET.ITEM  "
                'Dim Tabla_Tmp As DataTable
                'Tabla_Tmp = TmpListarDatos(StrSql)

                Dim nuevoddocumento As New NuevaDDocumento
                nuevoddocumento.id = 1
                nuevoddocumento.prod_codi = "001099"
                nuevoddocumento.prod_descr = "nota debito"
                nuevoddocumento.prod_unid = "NIU"
                nuevoddocumento.prod_precio = 0
                nuevoddocumento.prod_desct = 0
                nuevoddocumento.prod_cant = 1
                nuevoddocumento.igv = CDbl(txtigv.Text)
                nuevoddocumento.percepcion = 0
                nuevoddocumento.codi_cab = CODCAB
                nuevoddocumento.tipo_igv = IIf(CDbl(txtigv.Text) <> 0, "IGV", "INA")
                nuevoddocumento.obse = "nota debito"
                gestordefacturacionelectronica.CrearDdocumento(nuevoddocumento)

                gestordefacturacionelectronica.ModificarEstado(SERIE, NRODOCSIN)

            End If
        End If

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''' VERIFICO SI SE ENVIO A SUNAT O CORRECTAMENTE '''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''





        If AIntResp <> 0 Then

            If MessageBox.Show("Registro Grabado ¿Desea imprimir reporte?", DesEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                GeneraReporte(txtnronotcred.Text)
            End If
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtnronotcred.Text & "','INSERT','NOTADEBITO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            LimpiarFormularios(Me)
            txtigv.Text = "0.00"
            txtsubtotal.Text = "0.00"
            txttotal.Text = "0.00"
            txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
            BTNGUARDAR.Enabled = False
            BTNMODIFICAR.Enabled = True
            txtcambio.Text = VCambioVta
            txtptovta.Text = NROPTOVTA
            txtptovta.ReadOnly = True
        Else
            MsgBox("Error Durante Esta Operacion", MsgBoxStyle.Critical, "Aviso")
        End If
        Me.cmbreferncia.Enabled = False
        Me.txtreferncia1.Enabled = False
        Me.txtreferncia.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.txtobs.Enabled = False

    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click


        txtnronotcred.ReadOnly = False
        txtnronotcred.Text = ""
        btnnotcred.Enabled = True
        btnreferncia.Enabled = False
        cmbreferncia.Enabled = False
        txtnrorefe.Enabled = False
        txtptovta.Text = NROPTOVTA
        txtptovta.ReadOnly = True
        Me.txtobs.ReadOnly = True
        activa = 2



    End Sub

    Private Sub btnnotcred_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnotcred.Click
        Dim formu As New FrmBusqNotCredServ
        Me.dtpfecha.Enabled = False
        AIntValor = 1
        formu.AFrmNotDeb = Me
        formu.ShowDialog()
        Try
            activa = 2

            If AboolCargarValor Then
                ATblNotCred = AObjBus.ListarDatos("NSP_SELECT_LISTANTACREDSERV", formu.IDCODIGO, codempresa.ToString(), "D", formu.IDOCREF).Tables(0)
                VCdTipoDoc = ATblNotCred.Rows(0)("CDTIPODOC2")
                cmbreferncia.SelectedValue = VCdTipoDoc
                txtnronotcred.Text = ATblNotCred.Rows(0)(0)
                Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
                Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)


                'txtreferncia.Text = vb.Left(ATblNotCred.Rows(0)(2), 3)
                'txtreferncia1.Text = vb.Right(ATblNotCred.Rows(0)(2), 7)

                txtreferncia.Text = Format(CDbl(Mid(ATblNotCred.Rows(0)("NROREFE"), 1, Len(Trim(ATblNotCred.Rows(0)("NROREFE"))) - 8)), "000")
                txtreferncia1.Text = Mid(ATblNotCred.Rows(0)("NROREFE"), Len(Trim(ATblNotCred.Rows(0)("NROREFE"))) + 1 - 8, 8)

                cmbmoneda.SelectedValue = ATblNotCred.Rows(0)(3)
                txtcambio.Text = GMascaraDec_D(ATblNotCred.Rows(0)(4))
                cmboperador.SelectedValue = ATblNotCred.Rows(0)(5)
                dtpfecha.Value = ATblNotCred.Rows(0)(6)
                txttotal.Text = GMascaraDec_D(ATblNotCred.Rows(0)(7))
                txtsubtotal.Text = GMascaraDec_D(ATblNotCred.Rows(0)(9))
                txtigv.Text = GMascaraDec_D(ATblNotCred.Rows(0)(11))
                txtnrorefe.Text = ATblNotCred.Rows(0)(13)
                txtruc.Text = ATblNotCred.Rows(0)(14)
                txtnombre.Text = ATblNotCred.Rows(0)(15)
                txtdireccion.Text = ATblNotCred.Rows(0)(16)
                txtobs.Text = ATblNotCred.Rows(0)(22)




                bloqueatextos(Me)

                If Trim(ATblNotCred.Rows(0)("ESTADO")) = "A" Then
                    BTNELIMINAR.Enabled = False
                    MessageBox.Show("¡ DOCUMENTO ANULADO................... !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Else
                    'If AObjBus.ListarDatos("NSP_SELECT_BUSCA_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 2).Tables(0).Rows.Count = 0 Then
                    '    MessageBox.Show("¡ DOCUMENTO GENERADO CANCELADO EN CUENTAS POR COBRAR !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    '    BTNELIMINAR.Enabled = False
                    'Else
                    BTNELIMINAR.Enabled = True
                    'End If
                End If

            End If
        Catch
        End Try

        AboolCargarValor = False
        busqueda = 1

        If Me.cmbreferncia.SelectedValue Is Nothing Then
            MsgBox("- No hay Tipo de Documento Disponible.")
        Else
            TmpInsertDatos("NSP_SELECT_LISTADOCUMENTOS_BUSQUEDA '" & Me.cmbreferncia.SelectedValue.ToString & "','" & Val(Strings.Left(Me.txtreferncia.Text.Trim, 3) + Strings.Right(Me.txtreferncia1.Text.Trim, 7)) & "'")
        End If

        Conecta("SELECT * FROM TMPVENTACONS", "LLENA")
        If ds.Tables("LLENA").Rows.Count > 0 Then
            Me.TXTCODPAGADOR.Text = GValidarNulos(ds.Tables("llena").Rows(0)(7))

            Conecta("nspselclie '" & TXTCODPAGADOR.Text & "','" & codempresa & "'", "clie")
            If ds.Tables("clie").Rows.Count > 0 Then
                Me.TXTNOMPAGADOR.Text = ds.Tables("clie").Rows(0)(0)
            End If
        End If

    End Sub

    Private Sub txtnrorefe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnrorefe.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Try
                ATblCli = AObjBus.ListarDatos("NSP_SELE_clienteFac", codempresa.ToString(), txtnrorefe.Text).Tables(0)
                If ATblCli.Rows.Count > 0 Then
                    txtnrorefe.Text = ATblCli.Rows(0)(0)
                    txtruc.Text = ATblCli.Rows(0)(4)
                    txtnombre.Text = ATblCli.Rows(0)(1)
                    'txtrazonsocial.Text = ATblCli.Rows(0)(2)
                    txtdireccion.Text = ATblCli.Rows(0)(3)
                    BTNGUARDAR.Enabled = True
                    BTNMODIFICAR.Enabled = False
                    TXTCODPAGADOR.Focus()
                Else
                    txtnombre.Text = ""
                    txtruc.Text = ""
                    ' txtrazonsocial.Text = ""
                    txtdireccion.Text = ""
                    MsgBox("No existe el Cliente", MsgBoxStyle.Critical, "Aviso")
                End If
            Catch
            End Try
        End If
    End Sub

    Private Sub txtnronotcred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnronotcred.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Try
                ATblNotCred = AObjBus.ListarDatos("NSP_SELECT_LISTANTACREDSERV", CDbl(txtnronotcred.Text), codempresa.ToString(), "C").Tables(0)
                If ATblNotCred.Rows.Count > 0 Then
                    txtnronotcred.Text = ATblNotCred.Rows(0)(0)
                    cmbreferncia.SelectedValue = ATblNotCred.Rows(0)(1)
                    txtreferncia.Text = ATblNotCred.Rows(0)(2)
                    cmbmoneda.SelectedValue = ATblNotCred.Rows(0)(3)
                    txtcambio.Text = GMascaraDec_D(ATblNotCred.Rows(0)(4))
                    cmboperador.SelectedValue = ATblNotCred.Rows(0)(5)
                    dtpfecha.Value = ATblNotCred.Rows(0)(6)
                    txttotal.Text = GMascaraDec_D(ATblNotCred.Rows(0)(7))
                    txtsubtotal.Text = GMascaraDec_D(ATblNotCred.Rows(0)(9))
                    txtigv.Text = GMascaraDec_D(ATblNotCred.Rows(0)(11))
                    txtnrorefe.Text = ATblNotCred.Rows(0)(13)
                    txtruc.Text = ATblNotCred.Rows(0)(14)
                    txtnombre.Text = ATblNotCred.Rows(0)(15)

                    txtdireccion.Text = ATblNotCred.Rows(0)(16)
                    txtobs.Text = ATblNotCred.Rows(0)(22)
                Else
                    LimpiarFormularios(Me)
                    txtobs.Text = ""
                    txtigv.Text = "0.00"
                    txtsubtotal.Text = "0.00"
                    txttotal.Text = "0.00"
                End If
            Catch
            End Try
        End If

    End Sub

    Private Sub txtnronotcred_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnronotcred.KeyUp
        If e.KeyCode = Keys.F2 Then
            btnnotcred_Click(sender, e)
        End If
    End Sub

    Private Sub txtnrorefe_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnrorefe.KeyUp
        If e.KeyCode = Keys.F2 Then
            btnreferncia_Click(sender, e)
        End If
    End Sub

    Private Sub txtreferncia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreferncia.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))
        If Asc(e.KeyChar) = 13 Then
            Me.txtreferncia1.Focus()
            Me.txtreferncia1.SelectAll()
        End If
    End Sub

    Private Sub txtreferncia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtreferncia.LostFocus
        If IsNumeric(txtreferncia.Text) Then
            txtreferncia.Text = Format(CDbl(GVDATOVACIO(txtreferncia.Text)), "000")
        Else
            ' MsgBox("Error al Convertir una cadena de carateres a integer", MsgBoxStyle.Critical, "ADMINISTRADOR NARSISTEMAS")
            'txtreferncia.Focus()
            ' txtreferncia.Clear()
        End If

    End Sub

    Private Sub txtreferncia1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtreferncia1.LostFocus
        Dim CadNumdoc As String
        Dim Tblrs As DataTable
        txtreferncia1.Text = Format(CDbl(GVDATOVACIO(txtreferncia1.Text)), "00000000")
        CadNumdoc = txtreferncia.Text & "-" & txtreferncia1.Text
        Tblrs = AObjBus.ListarDatos("NSP_SELECT_VALIDAD_NRO_DOCUMENTO", cmbreferncia.SelectedValue.ToString(), codempresa.ToString(), CadNumdoc).Tables(0)
        If BTNMODIFICAR.Enabled = False Then
            If Tblrs.Rows.Count > 0 Then
                MsgBox("Nro De Documento Ya Existe", 0, "Ingreso Almacen")
                txtreferncia1.Text = ""
                txtreferncia1.Focus()
            End If
        End If
    End Sub

    Private Sub txtreferncia1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreferncia1.KeyPress
        Try
            Dim Keyascii As Short = CShort(Asc(e.KeyChar))
            Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))

            If Keyascii = 0 Then
                e.Handled = True
                txtreferncia1.Focus()
            End If

            If Keyascii = 13 Then
                Me.dtpfecha.Focus()
            End If

            If Asc(e.KeyChar) = 13 Then

                TmpInsertDatos("NSP_SELECT_LISTADOCUMENTOS_J '" & Me.cmbreferncia.SelectedValue.ToString & "','" & Val(Strings.Left(Me.txtreferncia.Text.Trim, 3) + Strings.Right(Me.txtreferncia1.Text.Trim, 8)) & "'," & VCorrelVta & "")

                Conecta("SELECT * FROM TMPVENTACONS WHERE CORREL=" & VCorrelVta & "", "LLENA")
                If ds.Tables("LLENA").Rows.Count > 0 Then
                    Me.cmbmoneda.SelectedValue = GValidarNulos(ds.Tables("llena").Rows(0)(0))
                    Me.cmboperador.SelectedValue = GValidarNulos(ds.Tables("llena").Rows(0)(1))
                    Me.txtptovta.Text = GValidarNulos(ds.Tables("llena").Rows(0)(2))
                    Me.txtnrorefe.Text = GValidarNulos(ds.Tables("llena").Rows(0)(3))
                    Me.txtnombre.Text = GValidarNulos(ds.Tables("llena").Rows(0)(4))
                    Me.txtdireccion.Text = GValidarNulos(ds.Tables("llena").Rows(0)(5))
                    Me.txtruc.Text = GValidarNulos(ds.Tables("llena").Rows(0)(6))
                    Me.TXTCODPAGADOR.Text = GValidarNulos(ds.Tables("llena").Rows(0)(7))

                    Conecta("nspselclie '" & TXTCODPAGADOR.Text & "','" & codempresa & "'", "clie")
                    If ds.Tables("clie").Rows.Count > 0 Then
                        Me.TXTNOMPAGADOR.Text = ds.Tables("clie").Rows(0)(0)
                    End If
                    Conecta("select * from   VENTACAB  where nrodocu= '" & Val(Strings.Left(Me.txtreferncia.Text.Trim, 3) + Strings.Right(Me.txtreferncia1.Text.Trim, 7)) & "' ", "TIPOCAMBIO")
                    If ds.Tables("TIPOCAMBIO").Rows.Count > 0 Then
                        Me.txtcambio.Text = ds.Tables("TIPOCAMBIO").Rows(0)("CAMBIO")
                    End If
                    Me.txtcambio.Enabled = True
                Else
                    MessageBox.Show("No existe el documento ingresado. Verifique!!", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtreferncia1.Focus()
                    Me.txtreferncia1.SelectAll()
                    Exit Sub
                End If
                Me.dtpfecha.Focus()

            End If



        Catch x As Exception
            MessageBox.Show("No existe el documento ingresado. Verifique!!", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtreferncia1.Focus()
            Me.txtreferncia1.SelectAll()
        End Try

    End Sub
    Sub GeneraReporte(ByVal ADblNtaCred As Double)
        Try
            crRpt.ReportFileName = rutareporte & "RptDebitoServ.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, ADblNtaCred)
            crRpt.set_StoredProcParam(1, codempresa)

            If EMIELECTRONIC = True Then
                crRpt.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & "F" & TextBox1.Text & "-" & TextBox2.Text & "'")
            Else
                crRpt.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & TextBox1.Text & "-" & TextBox2.Text & "'")
            End If



            crRpt.WindowShowPrintBtn = True
            crRpt.WindowShowExportBtn = True
            crRpt.WindowShowPrintSetupBtn = True
            crRpt.WindowShowSearchBtn = True
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch
            MessageBox.Show("Configure Una Impresora !!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub btnreporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        GeneraReporte(txtnronotcred.Text)
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click


        Dim Proceso As String
        Proceso = "ANULNTADEBCONTABL"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If

        If MessageBox.Show("¿Deseas Aular El Domuneto ?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            AObjBus.Ejecutar("NSP_upd_NTACREDCABSER", txtnronotcred.Text, codempresa, cmbreferncia.SelectedValue)
            AObjBus.Ejecutar("NSP_DEL_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 2, CStr(CInt(txtreferncia.Text)) & txtreferncia1.Text)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtnronotcred.Text & "','DELETE','NOTADEBITO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")

            If EMIELECTRONIC = True Then
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

                Dim gestordefacturacionelectronica As IGestorDeFacturacionElectronica = New GestorDeFacturacionElectronica()
                gestordefacturacionelectronica.AnularFE(LETRADOC + TextBox1.Text, TextBox2.Text, "08")

            End If

            MsgBox("El documento ha sido anulado", MsgBoxStyle.Information)

            BTNCANCELAR_Click(sender, e)

        End If

        txtptovta.Text = NROPTOVTA
        txtptovta.ReadOnly = True

    End Sub

    Private Sub BTNREFERENCIA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNREFERENCIA.Click
        Dim formu As New FrmBusqCliente
        formu.ShowDialog()
        Try
            If AboolCargarValor Then
                ATblCli = AObjBus.ListarDatos("NSP_SELE_clienteFac", codempresa.ToString(), formu.IDCODIGO, 0, NROPTOVTA).Tables(0)
                TXTCODPAGADOR.Text = ATblCli.Rows(0)(0)
                'txtruc.Text = ATblCli.Rows(0)(3)
                TXTNOMPAGADOR.Text = ATblCli.Rows(0)(1)
                'txtrazonsocial.Text = ATblCli.Rows(0)(2)
                ' txtdireccion.Text = ATblCli.Rows(0)(2)
                BTNGUARDAR.Enabled = True
                BTNMODIFICAR.Enabled = False
            End If
        Catch
        End Try
        AboolCargarValor = False
    End Sub

    Private Sub TXTCODPAGADOR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCODPAGADOR.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Try
                ATblCli = AObjBus.ListarDatos("NSP_SELE_clienteFac", codempresa.ToString(), txtnrorefe.Text).Tables(0)
                If ATblCli.Rows.Count > 0 Then
                    TXTCODPAGADOR.Text = ATblCli.Rows(0)(0)
                    TXTNOMPAGADOR.Text = ATblCli.Rows(0)(1)
                    BTNGUARDAR.Enabled = True
                    BTNMODIFICAR.Enabled = False
                    txtobs.Focus()
                Else
                    txtnombre.Text = ""
                    MsgBox("No existe el Cliente", MsgBoxStyle.Critical, "Aviso")
                    TXTCODPAGADOR.Focus()
                End If
            Catch
            End Try
        End If
    End Sub

    Private Sub FrmNotaDebito_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        cmbreferncia.Focus()
    End Sub

    Private Sub cmbreferncia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbreferncia.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Me.txtreferncia.Focus()
            Me.txtreferncia.SelectAll()
        End If
    End Sub


    Private Sub cmbmoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbmoneda.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            dtpfecha.Focus()
        End If
    End Sub

    Private Sub dtpfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfecha.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Me.txtcambio.Focus()
            Me.txtcambio.SelectAll()
        End If
    End Sub

    Private Sub cmboperador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmboperador.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtreferncia.Focus()
        End If
    End Sub

    Private Sub txtobs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtobs.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtsubtotal.Focus()
        End If
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        activa = 0

        LimpiarFormularios(Me)
        BTNGUARDAR.Enabled = True
        Me.cmbreferncia.Enabled = True
        Me.txtreferncia1.Enabled = True
        Me.txtreferncia.Enabled = True
        Me.dtpfecha.Enabled = True
        Me.txtobs.Enabled = True
        desbloqueatextos(Me)
        Me.GroupBox1.Enabled = False
        Me.GroupBox4.Enabled = False

        Me.txtptovta.Enabled = False
        Me.txtcambio.Enabled = False
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False

        txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTADEBITO", NROPTOVTA.ToString, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
        Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
        Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)

        txtobs.Text = ""
        txtigv.Text = "0.00"
        txtsubtotal.Text = "0.00"
        txttotal.Text = "0.00"
        txtptovta.Text = NROPTOVTA
        txtcambio.Text = VCambioVta

        Dim dt As New DataTable
        Dim i As Integer

        While (i = 0)
            dt = AObjBus.ListarDatos("sp_Buscar_NRONTACRED_X_CODIGO", txtnronotcred.Text, codempresa, cmbreferncia.SelectedValue).Tables(0)
            AObjBus.Ejecutar("sp_modificar_NUMERO_DEBITO", NROPTOVTA.ToString, codempresa)
            txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTADEBITO", NROPTOVTA.ToString, codempresa).Tables(0).Rows(0)(0)
            Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
            Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)
            If dt.Rows.Count > 0 Then
                i = 0
            Else
                i = 1
            End If

        End While

    End Sub
    Private Sub txtcambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcambio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtobs.Focus()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If activa <> 2 Then
            Me.TextBox1.ReadOnly = False
            Me.TextBox2.ReadOnly = False
            Me.TextBox1.Enabled = True
            Me.TextBox2.Enabled = True
            activa = 1
        End If


    End Sub
    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If activa = 1 Then
            Me.txtnronotcred.Text = CInt(Me.TextBox1.Text) & Microsoft.VisualBasic.Right("000000000" & Me.TextBox2.Text, 8)
        End If
    End Sub

    Private Sub txtreferncia1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreferncia1.TextChanged

    End Sub

    Private Sub txtsubtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsubtotal.TextChanged

    End Sub

    Private Sub cmbreferncia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreferncia.SelectedIndexChanged


        Dim AStrCod As String
        AStrCod = cmbreferncia.SelectedValue.ToString

        If AStrCod = Trim(CDFACTURA) Then

            txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTADEBITO", NROPTOVTA.ToString, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
            Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
            Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)

        End If

        If AStrCod = Trim(CDBOLETA) Then
            txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTADEBITO", NROPTOVTA.ToString, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
            Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
            Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)

        End If

    End Sub

    Private Sub txtreferncia_TextChanged(sender As Object, e As EventArgs) Handles txtreferncia.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If EMIELECTRONIC = True Then
                Dim FrmBus As New FrmBuscarDocVentasNC
                FrmBus.DATACODTIPODOC = cmbreferncia.SelectedValue.ToString.Trim
                FrmBus.ShowDialog()
                If FrmBus.DEVOLVER = False Then
                    Exit Sub
                End If
                IDCODIGO = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 2)
            Else
                Dim FrmBus As New FrmBuscarDocVentas
                FrmBus.DATACODTIPODOC = cmbreferncia.SelectedValue.ToString.Trim
                FrmBus.ShowDialog()
                If FrmBus.DEVOLVER = False Then
                    Exit Sub
                End If
                IDCODIGO = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 2)
            End If



            'txtnumero.Focus()
            'Dim formu As New FrmBusqNotCred
            ''formu.VIE = Me
            'TipDocNtaCred = cmbreferncia.SelectedValue
            'formu.ShowDialog()

            'txtnumero.Focus()
            'Dim formu As New FrmBusqNotCred
            'formu.VIE = Me
            'IDCODIGO = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 2)
            'formu.ShowDialog()




            'If AboolCargarValor Then

            'LLENA()
            'AboolCargarValor = False
            '' End If




            ' IDCODIGO = TipDocNtaCred
            'Tabla = "VENTACAB"
            'AboolCargarValor = True
            'LLENA()



            txtreferncia.Text = Format(CDbl(Mid(IDCODIGO, 1, Len(Trim(IDCODIGO)) - 8)), "000")
            txtreferncia1.Text = Mid(IDCODIGO, Len(Trim(IDCODIGO)) + 1 - 8, 8)



            TmpInsertDatos("NSP_SELECT_LISTADOCUMENTOS_J '" & Me.cmbreferncia.SelectedValue.ToString & "','" & Val(Strings.Left(Me.txtreferncia.Text.Trim, 3) + Strings.Right(Me.txtreferncia1.Text.Trim, 8)) & "'," & VCorrelVta & "")

            Conecta("SELECT * FROM TMPVENTACONS WHERE CORREL=" & VCorrelVta & "", "LLENA")
            If ds.Tables("LLENA").Rows.Count > 0 Then
                Me.cmbmoneda.SelectedValue = GValidarNulos(ds.Tables("llena").Rows(0)(0))
                Me.cmboperador.SelectedValue = GValidarNulos(ds.Tables("llena").Rows(0)(1))
                Me.txtptovta.Text = GValidarNulos(ds.Tables("llena").Rows(0)(2))
                Me.txtnrorefe.Text = GValidarNulos(ds.Tables("llena").Rows(0)(3))
                Me.txtnombre.Text = GValidarNulos(ds.Tables("llena").Rows(0)(4))
                Me.txtdireccion.Text = GValidarNulos(ds.Tables("llena").Rows(0)(5))
                Me.txtruc.Text = GValidarNulos(ds.Tables("llena").Rows(0)(6))
                Me.TXTCODPAGADOR.Text = GValidarNulos(ds.Tables("llena").Rows(0)(7))

                Conecta("nspselclie '" & TXTCODPAGADOR.Text & "','" & codempresa & "'", "clie")
                If ds.Tables("clie").Rows.Count > 0 Then
                    Me.TXTNOMPAGADOR.Text = ds.Tables("clie").Rows(0)(0)
                End If
                Conecta("select * from   VENTACAB  where nrodocu= '" & Val(Strings.Left(Me.txtreferncia.Text.Trim, 3) + Strings.Right(Me.txtreferncia1.Text.Trim, 7)) & "' ", "TIPOCAMBIO")
                If ds.Tables("TIPOCAMBIO").Rows.Count > 0 Then
                    Me.txtcambio.Text = ds.Tables("TIPOCAMBIO").Rows(0)("CAMBIO")
                End If
                Me.txtcambio.Enabled = True
            Else
                MessageBox.Show("No existe el documento ingresado. Verifique!!", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtreferncia1.Focus()
                Me.txtreferncia1.SelectAll()
                Exit Sub
            End If
            Me.dtpfecha.Focus()











        Catch x As Exception
            '  MessageBox.Show(x.Message)
        End Try
    End Sub
End Class
