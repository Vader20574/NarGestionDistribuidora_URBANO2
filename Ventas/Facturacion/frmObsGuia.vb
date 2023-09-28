Public Class frmObsGuia
    Inherits System.Windows.Forms.Form
    Private CodVehiculo As String
    Private Ruc As Boolean
    Private Valor As Boolean




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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents tnrocert As System.Windows.Forms.TextBox
    Friend WithEvents tbrevete As System.Windows.Forms.TextBox
    Friend WithEvents trucchofer As System.Windows.Forms.TextBox
    Friend WithEvents tCboCodVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents tobs As System.Windows.Forms.TextBox
    Friend WithEvents dtpfechatras As System.Windows.Forms.DateTimePicker
    Friend WithEvents tdestinatario As System.Windows.Forms.TextBox
    Friend WithEvents tdomd As System.Windows.Forms.TextBox
    Friend WithEvents tdomp As System.Windows.Forms.TextBox
    Friend WithEvents btnPtollegada As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tprovinciap As System.Windows.Forms.ComboBox
    Friend WithEvents tdistritop As System.Windows.Forms.ComboBox
    Friend WithEvents tprovinciad As System.Windows.Forms.ComboBox
    Friend WithEvents tdistritod As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDesEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtPlaca As System.Windows.Forms.TextBox
    Friend WithEvents txt_Conductor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents truc As System.Windows.Forms.TextBox
    Friend WithEvents txtdepP2 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtdepP As System.Windows.Forms.TextBox
    Friend WithEvents txt_LicConducir As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmObsGuia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.truc = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tobs = New System.Windows.Forms.TextBox
        Me.dtpfechatras = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.tdestinatario = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtPlaca = New System.Windows.Forms.TextBox
        Me.txt_LicConducir = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tnrocert = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtmarca = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.tbrevete = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.trucchofer = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button10 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tCboCodVehiculo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDesEmpresa = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtdepP2 = New System.Windows.Forms.TextBox
        Me.tdistritod = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.tprovinciad = New System.Windows.Forms.ComboBox
        Me.btnPtollegada = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tdomd = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tdistritop = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.tprovinciap = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tdomp = New System.Windows.Forms.TextBox
        Me.txtdepP = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_Conductor = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.truc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tobs)
        Me.GroupBox1.Controls.Add(Me.dtpfechatras)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tdestinatario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(731, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Ruc : "
        '
        'truc
        '
        Me.truc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.truc.Location = New System.Drawing.Point(77, 80)
        Me.truc.Name = "truc"
        Me.truc.Size = New System.Drawing.Size(168, 21)
        Me.truc.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(434, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Observaciones :    (Máx 200 carácteres)"
        '
        'tobs
        '
        Me.tobs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tobs.Location = New System.Drawing.Point(431, 37)
        Me.tobs.MaxLength = 200
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tobs.Size = New System.Drawing.Size(274, 57)
        Me.tobs.TabIndex = 9
        '
        'dtpfechatras
        '
        Me.dtpfechatras.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechatras.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechatras.Location = New System.Drawing.Point(176, 58)
        Me.dtpfechatras.Name = "dtpfechatras"
        Me.dtpfechatras.Size = New System.Drawing.Size(101, 21)
        Me.dtpfechatras.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Fecha de Inicio de Traslado : "
        '
        'tdestinatario
        '
        Me.tdestinatario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdestinatario.Location = New System.Drawing.Point(97, 33)
        Me.tdestinatario.Name = "tdestinatario"
        Me.tdestinatario.Size = New System.Drawing.Size(305, 21)
        Me.tdestinatario.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Destinatario : "
        '
        'btncancelar
        '
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(588, 401)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(137, 25)
        Me.btncancelar.TabIndex = 17
        Me.btncancelar.Text = "Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(435, 401)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(140, 24)
        Me.btnaceptar.TabIndex = 16
        Me.btnaceptar.Text = "Aceptar "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtPlaca)
        Me.GroupBox4.Controls.Add(Me.txt_LicConducir)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.tnrocert)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtmarca)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.tbrevete)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.trucchofer)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Button10)
        Me.GroupBox4.Controls.Add(Me.tCboCodVehiculo)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtDesEmpresa)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 257)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(732, 133)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del vehiculo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(431, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Lic. Conductor : "
        '
        'txtPlaca
        '
        Me.txtPlaca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.Location = New System.Drawing.Point(83, 51)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.ReadOnly = True
        Me.txtPlaca.Size = New System.Drawing.Size(126, 21)
        Me.txtPlaca.TabIndex = 32
        '
        'txt_LicConducir
        '
        Me.txt_LicConducir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LicConducir.Location = New System.Drawing.Point(525, 105)
        Me.txt_LicConducir.Name = "txt_LicConducir"
        Me.txt_LicConducir.Size = New System.Drawing.Size(91, 21)
        Me.txt_LicConducir.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Placa : "
        '
        'tnrocert
        '
        Me.tnrocert.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnrocert.Location = New System.Drawing.Point(526, 78)
        Me.tnrocert.Name = "tnrocert"
        Me.tnrocert.ReadOnly = True
        Me.tnrocert.Size = New System.Drawing.Size(126, 21)
        Me.tnrocert.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(402, 81)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Nº Certif. Incripción :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtmarca
        '
        Me.txtmarca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.Location = New System.Drawing.Point(525, 54)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.ReadOnly = True
        Me.txtmarca.Size = New System.Drawing.Size(126, 21)
        Me.txtmarca.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(472, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Marca : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbrevete
        '
        Me.tbrevete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbrevete.Location = New System.Drawing.Point(84, 100)
        Me.tbrevete.Name = "tbrevete"
        Me.tbrevete.ReadOnly = True
        Me.tbrevete.Size = New System.Drawing.Size(142, 21)
        Me.tbrevete.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(28, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Brevete :"
        '
        'trucchofer
        '
        Me.trucchofer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trucchofer.Location = New System.Drawing.Point(85, 72)
        Me.trucchofer.Name = "trucchofer"
        Me.trucchofer.ReadOnly = True
        Me.trucchofer.Size = New System.Drawing.Size(141, 21)
        Me.trucchofer.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(39, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "RUC :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.ImageIndex = 5
        Me.Button10.ImageList = Me.ImageList1
        Me.Button10.Location = New System.Drawing.Point(368, 21)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(41, 23)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "..."
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'tCboCodVehiculo
        '
        Me.tCboCodVehiculo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCboCodVehiculo.Location = New System.Drawing.Point(85, 22)
        Me.tCboCodVehiculo.Name = "tCboCodVehiculo"
        Me.tCboCodVehiculo.Size = New System.Drawing.Size(68, 21)
        Me.tCboCodVehiculo.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Codigo : "
        '
        'txtDesEmpresa
        '
        Me.txtDesEmpresa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesEmpresa.Location = New System.Drawing.Point(164, 22)
        Me.txtDesEmpresa.Name = "txtDesEmpresa"
        Me.txtDesEmpresa.Size = New System.Drawing.Size(200, 21)
        Me.txtDesEmpresa.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 401)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Conductor : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtdepP2)
        Me.GroupBox3.Controls.Add(Me.tdistritod)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.tprovinciad)
        Me.GroupBox3.Controls.Add(Me.btnPtollegada)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.tdomd)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(382, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(365, 133)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Destino"
        '
        'txtdepP2
        '
        Me.txtdepP2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdepP2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepP2.Location = New System.Drawing.Point(72, 50)
        Me.txtdepP2.Name = "txtdepP2"
        Me.txtdepP2.Size = New System.Drawing.Size(223, 21)
        Me.txtdepP2.TabIndex = 36
        '
        'tdistritod
        '
        Me.tdistritod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tdistritod.Location = New System.Drawing.Point(71, 101)
        Me.tdistritod.Name = "tdistritod"
        Me.tdistritod.Size = New System.Drawing.Size(252, 21)
        Me.tdistritod.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(-3, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 13)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "Departamento :"
        '
        'tprovinciad
        '
        Me.tprovinciad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tprovinciad.Location = New System.Drawing.Point(72, 74)
        Me.tprovinciad.Name = "tprovinciad"
        Me.tprovinciad.Size = New System.Drawing.Size(251, 21)
        Me.tprovinciad.TabIndex = 13
        '
        'btnPtollegada
        '
        Me.btnPtollegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPtollegada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPtollegada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPtollegada.ImageIndex = 5
        Me.btnPtollegada.ImageList = Me.ImageList1
        Me.btnPtollegada.Location = New System.Drawing.Point(320, 24)
        Me.btnPtollegada.Name = "btnPtollegada"
        Me.btnPtollegada.Size = New System.Drawing.Size(41, 23)
        Me.btnPtollegada.TabIndex = 12
        Me.btnPtollegada.Text = "..."
        Me.btnPtollegada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Provincia :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Distrito : "
        '
        'tdomd
        '
        Me.tdomd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdomd.Location = New System.Drawing.Point(70, 24)
        Me.tdomd.Name = "tdomd"
        Me.tdomd.Size = New System.Drawing.Size(248, 21)
        Me.tdomd.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Domicilio :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tdistritop)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.tprovinciap)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tdomp)
        Me.GroupBox2.Controls.Add(Me.txtdepP)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 132)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Partida"
        '
        'tdistritop
        '
        Me.tdistritop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tdistritop.Location = New System.Drawing.Point(85, 105)
        Me.tdistritop.Name = "tdistritop"
        Me.tdistritop.Size = New System.Drawing.Size(251, 21)
        Me.tdistritop.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(-3, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Departamento :"
        '
        'tprovinciap
        '
        Me.tprovinciap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tprovinciap.Location = New System.Drawing.Point(86, 77)
        Me.tprovinciap.Name = "tprovinciap"
        Me.tprovinciap.Size = New System.Drawing.Size(249, 21)
        Me.tprovinciap.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Distrito :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cuidad :"
        '
        'tdomp
        '
        Me.tdomp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdomp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdomp.Location = New System.Drawing.Point(85, 21)
        Me.tdomp.Name = "tdomp"
        Me.tdomp.Size = New System.Drawing.Size(246, 21)
        Me.tdomp.TabIndex = 1
        '
        'txtdepP
        '
        Me.txtdepP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdepP.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepP.Location = New System.Drawing.Point(83, 49)
        Me.txtdepP.Name = "txtdepP"
        Me.txtdepP.Size = New System.Drawing.Size(246, 21)
        Me.txtdepP.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Domicilio :"
        '
        'txt_Conductor
        '
        Me.txt_Conductor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Conductor.Location = New System.Drawing.Point(93, 396)
        Me.txt_Conductor.Name = "txt_Conductor"
        Me.txt_Conductor.Size = New System.Drawing.Size(200, 21)
        Me.txt_Conductor.TabIndex = 33
        '
        'frmObsGuia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(755, 436)
        Me.Controls.Add(Me.txt_Conductor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label14)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmObsGuia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observaciones de la Guia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public AFrmGuiaDir As New FRMGUIADIRECTA
    'Public AObjBus As New ClsInterface
    Dim CONTADOR As Integer = 0
    Dim Ayuda As New ClsAyuda
    'Dim Ruc As Boolean
    '  Public AFrmObsGuiDir As New FrmPtoLlegada

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Dim o As New FrmBusqueda_Vehiculo
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        CodVehiculo = o.DatagridVehiculo.Item(o.FilaSelec, 0).ToString.Trim
        CargarDatosVehiculo()

    End Sub



    Private Sub CargarDatosVehiculo()
        Dim TABLE_BUS As New DataTable
        TABLE_BUS = TmpListarDatos("NSP_TRAER_VEHICULOXCOD  '" & codempresa & "','" & CodVehiculo & "'")
        If TABLE_BUS.Rows.Count > 0 Then
            tCboCodVehiculo.Text = TABLE_BUS.Rows(0)("CODVEHI").ToString.Trim
            txtDesEmpresa.Text = TABLE_BUS.Rows(0)("DESVEHI").ToString.Trim
            txtPlaca.Text = TABLE_BUS.Rows(0)("PLACA").ToString.Trim
            tnrocert.Text = TABLE_BUS.Rows(0)("CERTIFICADO").ToString.Trim
            txtmarca.Text = TABLE_BUS.Rows(0)("MARCA").ToString.Trim
        End If
    End Sub




    Public Sub bloquea()
        Bloqueatextbox(Me)
        Me.dtpfechatras.Enabled = False
    End Sub

    Public Sub desbloquea()
        desbloqueatextbox(Me)
    End Sub

    Private Sub frmObsGuia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CAyuda.CargarDataCombo(tprovinciap, "Nsp_select_Ciudad_combo2 'Peru','14'", "codigo", "descripcion")
        CAyuda.CargarDataCombo(tdistritop, "Nsp_select_distrito 'Peru','14','127'", "codigo", "descripcion")


        CAyuda.CargarDataCombo(tprovinciad, "Nsp_select_Ciudad_combo2 'Peru','14'", "codigo", "descripcion")
        CAyuda.CargarDataCombo(tdistritod, "Nsp_select_distrito 'Peru','14','127'", "codigo", "descripcion")



        If AFrmGuiaDir.INICIA = 0 Then
            bloquea()

        Else
            desbloquea()
            Me.txtDesEmpresa.ReadOnly = True
            Me.trucchofer.ReadOnly = True
            Me.tbrevete.ReadOnly = True
            'Me.cboplaca.ReadOnly = True
            Me.tnrocert.ReadOnly = True

        End If
        Me.tCboCodVehiculo.Text = "0"


        Me.tdomp.Text = AFrmGuiaDir.domp
        Me.tdistritop.Text = AFrmGuiaDir.distp
        Me.tprovinciap.Text = AFrmGuiaDir.provp
        Me.tdomd.Text = AFrmGuiaDir.domd
        Me.tdistritod.Text = AFrmGuiaDir.distd
        Me.tprovinciad.Text = AFrmGuiaDir.provd
        Me.tdestinatario.Text = AFrmGuiaDir.dest
        Me.tobs.Text = AFrmGuiaDir.obv
        Me.tCboCodVehiculo.Text = AFrmGuiaDir.codtransp
        Me.txtDesEmpresa.Text = AFrmGuiaDir.desctransp
        Me.trucchofer.Text = AFrmGuiaDir.ructransp
        Me.tbrevete.Text = AFrmGuiaDir.brevete
        Me.txtmarca.Text = AFrmGuiaDir.marca
        Me.txtPlaca.Text = AFrmGuiaDir.placa
        Me.tnrocert.Text = AFrmGuiaDir.nrocert
        Me.dtpfechatras.Value = AFrmGuiaDir.fechatras
        Me.txt_Conductor.Text = AFrmGuiaDir.Chofer
        Me.truc.Text = AFrmGuiaDir.x
        Me.txtdepP.Text = AFrmGuiaDir.DepP
        Me.txtdepP2.Text = AFrmGuiaDir.DepP2
        Me.txt_LicConducir.Text = AFrmGuiaDir.LicConduc






        'dessastrozo
        If Me.tCboCodVehiculo.Text.Trim <> "" Then

            'CAyuda.CargarDataCombo(cboconductor, "sp_obt_conductor_empresa '" & Me.tCboCodVehiculo.Text & "'", "brevete", "conductor")
            'cboconductor.SelectedValue = AFrmGuiaDir.x
            'tbrevete.Text = cboconductor.SelectedValue
            'CAyuda.CargarDataCombo(Me.cboplaca, "USP_LISTAR_PLACA '" & Me.tCboCodVehiculo.Text & "'", "CODTRANSPOR", "PLACA")
            'Dim TblPlaca As New DataTable
            'TblPlaca = CAyuda.ListarDatos("USP_LISTAR_MARCA", Me.cboplaca.Text.Trim).Tables(0)
            'Me.txtmarca.Text = TblPlaca.Rows(0).Item("MARCA")

        End If

        '''''''conecta("select codtranspor,destranspor,ruc from transportista where (codempresa='" & CodEmpresa & "' and estado=0 and codtranspor='" & tcodchofer.Text & "') ", "pa")

        '''''''If ds.Tables("pa").Rows.Count > 0 Then
        '''''''    tcodchofer.Text = Trim(ds.Tables("pa").Rows(0)(0))
        '''''''    txtDesEmpresa.Text = Trim(ds.Tables("pa").Rows(0)(1))
        '''''''    trucchofer.Text = Trim(ds.Tables("pa").Rows(0)(2))
        '''''''    Me.tbrevete.Focus()
        '''''''    Me.tbrevete.SelectAll()
        '''''''End If
        '''''''tmarca_SelectedIndexChanged(sender, e)




        'Dim ATBLDIR As New DataTable
        'ATBLDIR = CAyuda.ListarDatos("NSP_SELECT_BUSCA_DIERCCION", NROPTOVTA, codempresa).Tables(0)
        'tdomp.Text = ATBLDIR.Rows(0)("DIRPTOVTA")
        'tprovinciap.SelectedValue = ATBLDIR.Rows(0)("CODCIUDAD")
        'tdistritop.SelectedValue = ATBLDIR.Rows(0)("CodDis")
        'tdomp.Focus()
        'tdomp.SelectAll()
        'Dim TABLE2 As New DataTable
        'TABLE2 = CAyuda.ListarDatos("SP_OBT_CIUDAD_DISTRITO", AFrmGuiaDir.txtcodcliente.Text).Tables(0)
        'tprovinciad.SelectedValue = TABLE2.Rows(0)(1)
        'tdistritod.SelectedValue = TABLE2.Rows(0)(0)

        If PROCESO1 = "MODIFICACION" Then
            Try
                'Dim TABLE3 As New DataTable
                'TABLE3 = CAyuda.ListarDatos("SP_OBT_DATOS_GUIA_CONDUCTOR", AFrmGuiaDir.txtnumeroguia.Text).Tables(0)
                'tCboCodVehiculo.Text = TABLE3.Rows(0)(0)
                'CAyuda.CargarDataCombo(cboconductor, "sp_obt_conductor_empresa '" & tCboCodVehiculo.Text.Trim & "'", "brevete", "conductor")
                'txtDesEmpresa.Text = TABLE3.Rows(0)(1)
                'cboconductor.SelectedValue = TABLE3.Rows(0)(5)
                'CAyuda.CargarDataCombo(cboplaca, "sp_obt_vehi_conduc '" & cboconductor.SelectedValue & "'", "marca", "placa")
                'trucchofer.Text = TABLE3.Rows(0)(2)
                'cboplaca.Text = TABLE3.Rows(0)(3)
                'txtmarca.Text = TABLE3.Rows(0)(4)
                'tbrevete.Text = TABLE3.Rows(0)(5)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Function ValidarCamposAguardar() As Boolean
        If truc.Text.Trim <> "" Then
            Call FACT_GValidaRUC(Me.truc.Text)
            If Ruc = False Then
                Valor = False
            End If
        End If
        Return Valor
    End Function





    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        Dim ValidaCampos As Boolean
        'Call formatotextbox(Me)
        ValidaCampos = FACT_GValidaRUC(Me.truc.Text)
        If ValidaCampos = False Then
            Exit Sub
        End If


        If AFrmGuiaDir.INICIA = 1 Then
            AFrmGuiaDir.domp = Me.tdomp.Text
            AFrmGuiaDir.distp = Me.tdistritop.Text
            AFrmGuiaDir.provp = Me.tprovinciap.Text
            AFrmGuiaDir.domd = Me.tdomd.Text
            AFrmGuiaDir.distd = Me.tdistritod.Text
            AFrmGuiaDir.provd = Me.tprovinciad.Text
            AFrmGuiaDir.dest = Me.tdestinatario.Text
            AFrmGuiaDir.obv = Me.tobs.Text.Trim
            AFrmGuiaDir.codtransp = Me.tCboCodVehiculo.Text
            AFrmGuiaDir.desctransp = Me.txtDesEmpresa.Text
            AFrmGuiaDir.ructransp = Me.trucchofer.Text
            AFrmGuiaDir.brevete = Me.tbrevete.Text
            AFrmGuiaDir.marca = Me.txtmarca.Text
            AFrmGuiaDir.placa = Me.txtPlaca.Text
            AFrmGuiaDir.nrocert = Me.tnrocert.Text
            AFrmGuiaDir.fechatras = Me.dtpfechatras.Value
            AFrmGuiaDir.Chofer = Me.txt_Conductor.Text
            AFrmGuiaDir.x = Me.truc.Text
            AFrmGuiaDir.DepP = Me.txtdepP.Text
            AFrmGuiaDir.DepP2 = Me.txtdepP2.Text
            AFrmGuiaDir.LicConduc = Me.txt_LicConducir.Text

        End If
        Me.Close()
    End Sub

    Private Sub tcodchofer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tCboCodVehiculo.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If Me.tCboCodVehiculo.Text.Trim = "" Then
                Dim men As New frm_transportista
                men.AFrmGuiaDir = Me
                men.ShowDialog(Me)
            Else

                Conecta("select codtranspor,destranspor,ruc from transportista where (codempresa='" & codempresa & "' and estado=0 and codtranspor='" & tCboCodVehiculo.Text & "') ", "pa")

                If ds.Tables("pa").Rows.Count > 0 Then
                    tCboCodVehiculo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                    txtDesEmpresa.Text = Trim(ds.Tables("pa").Rows(0)(1))
                    trucchofer.Text = Trim(ds.Tables("pa").Rows(0)(2))
                    'Me.tbrevete.Focus()
                    'Me.tbrevete.SelectAll()
                    'CAyuda.CargarDataCombo(cboconductor, "sp_obt_conductor_empresa '" & tCboCodVehiculo.Text.Trim & "'", "brevete", "conductor")

                Else
                    MessageBox.Show("No existen registros encontrados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.tCboCodVehiculo.Focus()
                    Me.tCboCodVehiculo.SelectAll()
                End If
            End If
        End If
    End Sub

    Private Sub tdomp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdomp.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tprovinciap.Focus()
            Me.tprovinciap.SelectAll()
        End If
    End Sub

    Private Sub tdistritop_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdistritop.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdomd.Focus()
            Me.tdomd.SelectAll()
        End If
    End Sub

    Private Sub tprovinciap_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tprovinciap.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdistritop.Focus()
            Me.tdistritop.SelectAll()
        End If
    End Sub

    Private Sub tdomd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdomd.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tprovinciad.Focus()
            Me.tprovinciad.SelectAll()
        End If
    End Sub

    Private Sub tdistritod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdistritod.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdestinatario.Focus()
            Me.tdestinatario.SelectAll()
        End If
    End Sub

    Private Sub tprovinciad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tprovinciad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdistritod.Focus()
            Me.tdistritod.SelectAll()

        End If
    End Sub

    Private Sub tdestinatario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdestinatario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.dtpfechatras.Focus()
        End If
    End Sub

    Private Sub dtpfechatras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfechatras.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tobs.Focus()
            Me.tobs.SelectAll()
        End If
    End Sub

    Private Sub tobs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tobs.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tCboCodVehiculo.Focus()
            Me.tCboCodVehiculo.SelectAll()
        End If
    End Sub

    Private Sub tbrevete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbrevete.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'Me.cboplaca.Focus()
            'Me.cboplaca.SelectAll()
        End If
    End Sub

    Private Sub tmarca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.btnaceptar.Focus()
        End If
    End Sub

    Private Sub tplaca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tnrocert.Focus()
            Me.tnrocert.SelectAll()
        End If
    End Sub

    Private Sub tnrocert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnrocert.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.btnaceptar.Focus()
        End If
    End Sub

    Private Sub btnPtollegada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPtollegada.Click
        'Dim men As New FrmPtoLlegada
        'men.AFrmObsGuiDir = Me
        'men.ShowDialog(Me)
    End Sub


    Private Sub tprovinciap_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tprovinciap.SelectedIndexChanged
        Try

            CAyuda.CargarDataCombo(tdistritop, "Nsp_select_distrito 'Peru','14','" & tprovinciap.SelectedValue.ToString & "'", "codigo", "descripcion")

        Catch x As Exception
        End Try
    End Sub

    Private Sub tprovinciad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tprovinciad.SelectedIndexChanged
        Try

            CAyuda.CargarDataCombo(tdistritod, "Nsp_select_distrito 'Peru','14','" & tprovinciad.SelectedValue.ToString & "'", "codigo", "descripcion")

        Catch x As Exception
        End Try
    End Sub

    Private Sub frmObsGuia_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        tdomp.Focus()


    End Sub

    Private Sub tmarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' txtmarca.Text = cboplaca.SelectedValue
            'Dim ATblVehi As New DataTable
            'If AFrmGuiaDir.INICIA = 0 Then
            '    If tmarca.SelectedValue.ToString() <> "System.Data.DataRowView" Then
            '        Me.tmarca.SelectedValue = AFrmGuiaDir.marca
            '        ATblVehi = AObjBus.ListarDatos("NSP_SELECT_LISTA_VEHICULO", tmarca.SelectedValue.ToString(), codempresa).Tables(0)
            '        tplaca.Text = ATblVehi.Rows(0)("PLACA")
            '        tnrocert.Text = ATblVehi.Rows(0)("CERTIFICADO")
            '    End If
            'Else
            '    If tmarca.SelectedValue.ToString() <> "System.Data.DataRowView" Then
            '        ATblVehi = AObjBus.ListarDatos("NSP_SELECT_LISTA_VEHICULO", tmarca.SelectedValue.ToString(), codempresa).Tables(0)
            '        tplaca.Text = ATblVehi.Rows(0)("PLACA")
            '        tnrocert.Text = ATblVehi.Rows(0)("CERTIFICADO")
            '    End If

            'End If
        Catch
        End Try
    End Sub
    Private Sub tcodchofer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tCboCodVehiculo.KeyDown
        If e.KeyCode = Keys.F2 Then
            Button10_Click(sender, e)
        End If
    End Sub
    Private Sub cboconductor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If CONTADOR > 2 Then
        ' ''If Aux = True Then
        ' ''    CAyuda.CargarDataCombo(cboplaca, "sp_obt_vehi_conduc '" & cboconductor.SelectedValue & "'", "marca", "placa")
        ' ''    tbrevete.Text = cboconductor.SelectedValue
        ' ''End If
        'CONTADOR = CONTADOR + 1
    End Sub
    Private Sub cboconductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'Me.cboplaca.Focus()
        End If
    End Sub
    Dim Aux As Boolean
    Private Sub cboconductor_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Aux = True
    End Sub

    Private Sub frmObsGuia_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Aux = False
    End Sub

    Private Sub tdistritop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdistritop.SelectedIndexChanged

    End Sub

    Private Sub tdistritod_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdistritod.SelectedIndexChanged

    End Sub
End Class
