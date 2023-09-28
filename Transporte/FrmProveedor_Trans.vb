Imports System.Data
Imports vb = Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class FrmProveedor_trans

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbCuidad As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents CmbPais As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtRuc As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodProv As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdbNac As System.Windows.Forms.RadioButton
    Friend WithEvents RdbExt As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ImgMenu As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcelconta As System.Windows.Forms.TextBox
    Friend WithEvents txttelconta As System.Windows.Forms.TextBox
    Friend WithEvents txtdirconta As System.Windows.Forms.TextBox
    Friend WithEvents txtcontacto As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcelu As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtobs As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtWeb As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnModificar As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents TXTCORREOCONTA As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtNomCom As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CboDomiCiliado As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CboTipoProv As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedor_trans))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CboTipoProv = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cbFormaPago = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.CboDomiCiliado = New System.Windows.Forms.ComboBox
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.TxtNomCom = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtWeb = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtcelu = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbCuidad = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.CmbPais = New System.Windows.Forms.ComboBox
        Me.TxtTelefono = New System.Windows.Forms.TextBox
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.TxtRuc = New System.Windows.Forms.TextBox
        Me.TxtCodProv = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdbNac = New System.Windows.Forms.RadioButton
        Me.RdbExt = New System.Windows.Forms.RadioButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtobs = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TXTCORREOCONTA = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtcelconta = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txttelconta = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdirconta = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtcontacto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ImgMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnreporte = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.BtnModificar = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ImageList = Me.ImgMenu
        Me.TabControl1.ItemSize = New System.Drawing.Size(160, 19)
        Me.TabControl1.Location = New System.Drawing.Point(7, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 409)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(464, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Proveedor"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.CboTipoProv)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.cbFormaPago)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.CboDomiCiliado)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.TxtNomCom)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtWeb)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtcelu)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbCuidad)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.CmbPais)
        Me.GroupBox2.Controls.Add(Me.TxtTelefono)
        Me.GroupBox2.Controls.Add(Me.TxtDireccion)
        Me.GroupBox2.Controls.Add(Me.TxtRuc)
        Me.GroupBox2.Controls.Add(Me.TxtCodProv)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 318)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "v"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(267, 171)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 24)
        Me.CheckBox1.TabIndex = 74
        Me.CheckBox1.Text = "Activo"
        '
        'CboTipoProv
        '
        Me.CboTipoProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoProv.Location = New System.Drawing.Point(120, 288)
        Me.CboTipoProv.Name = "CboTipoProv"
        Me.CboTipoProv.Size = New System.Drawing.Size(180, 21)
        Me.CboTipoProv.TabIndex = 67
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(46, 288)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "Tipo :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbFormaPago
        '
        Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPago.Location = New System.Drawing.Point(120, 264)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(180, 21)
        Me.cbFormaPago.TabIndex = 65
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(46, 265)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Forma Pago :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(282, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "[F2]  BUSCAR"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CboDomiCiliado
        '
        Me.CboDomiCiliado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDomiCiliado.Enabled = False
        Me.CboDomiCiliado.ItemHeight = 13
        Me.CboDomiCiliado.Items.AddRange(New Object() {"No Domiciliado", "Domiciliado"})
        Me.CboDomiCiliado.Location = New System.Drawing.Point(120, 240)
        Me.CboDomiCiliado.Name = "CboDomiCiliado"
        Me.CboDomiCiliado.Size = New System.Drawing.Size(180, 21)
        Me.CboDomiCiliado.TabIndex = 7
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Location = New System.Drawing.Point(120, 49)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(272, 21)
        Me.TxtNombre.TabIndex = 3
        '
        'TxtNomCom
        '
        Me.TxtNomCom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNomCom.Location = New System.Drawing.Point(120, 72)
        Me.TxtNomCom.Name = "TxtNomCom"
        Me.TxtNomCom.Size = New System.Drawing.Size(272, 21)
        Me.TxtNomCom.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(14, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Nombre Comercial :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(84, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Web :"
        '
        'TxtWeb
        '
        Me.TxtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtWeb.Location = New System.Drawing.Point(120, 216)
        Me.TxtWeb.MaxLength = 500
        Me.TxtWeb.Name = "TxtWeb"
        Me.TxtWeb.Size = New System.Drawing.Size(272, 21)
        Me.TxtWeb.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(88, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Fax :"
        '
        'txtcelu
        '
        Me.txtcelu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcelu.Location = New System.Drawing.Point(120, 192)
        Me.txtcelu.MaxLength = 18
        Me.txtcelu.Name = "txtcelu"
        Me.txtcelu.Size = New System.Drawing.Size(121, 21)
        Me.txtcelu.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(62, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Teléfono :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Ciudad :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(86, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "País :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Dirección :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "RUC :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Nombre/Razon Social :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Código :"
        '
        'CmbCuidad
        '
        Me.CmbCuidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCuidad.ItemHeight = 13
        Me.CmbCuidad.Location = New System.Drawing.Point(312, 144)
        Me.CmbCuidad.Name = "CmbCuidad"
        Me.CmbCuidad.Size = New System.Drawing.Size(121, 21)
        Me.CmbCuidad.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageIndex = 5
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(244, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmbPais
        '
        Me.CmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPais.ItemHeight = 13
        Me.CmbPais.Location = New System.Drawing.Point(120, 144)
        Me.CmbPais.Name = "CmbPais"
        Me.CmbPais.Size = New System.Drawing.Size(121, 21)
        Me.CmbPais.TabIndex = 6
        '
        'TxtTelefono
        '
        Me.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTelefono.Location = New System.Drawing.Point(120, 168)
        Me.TxtTelefono.MaxLength = 18
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(121, 21)
        Me.TxtTelefono.TabIndex = 8
        '
        'TxtDireccion
        '
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Location = New System.Drawing.Point(120, 120)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(272, 21)
        Me.TxtDireccion.TabIndex = 5
        '
        'TxtRuc
        '
        Me.TxtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRuc.Location = New System.Drawing.Point(120, 96)
        Me.TxtRuc.MaxLength = 11
        Me.TxtRuc.Name = "TxtRuc"
        Me.TxtRuc.Size = New System.Drawing.Size(121, 21)
        Me.TxtRuc.TabIndex = 4
        '
        'TxtCodProv
        '
        Me.TxtCodProv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodProv.Location = New System.Drawing.Point(120, 24)
        Me.TxtCodProv.Name = "TxtCodProv"
        Me.TxtCodProv.Size = New System.Drawing.Size(120, 21)
        Me.TxtCodProv.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(48, 242)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Domiciliado :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbNac)
        Me.GroupBox1.Controls.Add(Me.RdbExt)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 48)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo De Proveedor"
        '
        'RdbNac
        '
        Me.RdbNac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbNac.Location = New System.Drawing.Point(136, 24)
        Me.RdbNac.Name = "RdbNac"
        Me.RdbNac.Size = New System.Drawing.Size(80, 16)
        Me.RdbNac.TabIndex = 29
        Me.RdbNac.Text = "Nacional"
        '
        'RdbExt
        '
        Me.RdbExt.Checked = True
        Me.RdbExt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbExt.Location = New System.Drawing.Point(32, 24)
        Me.RdbExt.Name = "RdbExt"
        Me.RdbExt.Size = New System.Drawing.Size(80, 16)
        Me.RdbExt.TabIndex = 28
        Me.RdbExt.TabStop = True
        Me.RdbExt.Text = "Extranjero"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.ImageIndex = 7
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(464, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contacto"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtobs)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 160)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(432, 176)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Observación"
        '
        'txtobs
        '
        Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs.Location = New System.Drawing.Point(16, 21)
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobs.Size = New System.Drawing.Size(400, 147)
        Me.txtobs.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXTCORREOCONTA)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtcelconta)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txttelconta)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtdirconta)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtcontacto)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 144)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'TXTCORREOCONTA
        '
        Me.TXTCORREOCONTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCORREOCONTA.Location = New System.Drawing.Point(88, 110)
        Me.TXTCORREOCONTA.Name = "TXTCORREOCONTA"
        Me.TXTCORREOCONTA.Size = New System.Drawing.Size(328, 21)
        Me.TXTCORREOCONTA.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Correo Elect. :"
        '
        'txtcelconta
        '
        Me.txtcelconta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcelconta.Location = New System.Drawing.Point(88, 87)
        Me.txtcelconta.Name = "txtcelconta"
        Me.txtcelconta.Size = New System.Drawing.Size(120, 21)
        Me.txtcelconta.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Celular :"
        '
        'txttelconta
        '
        Me.txttelconta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttelconta.Location = New System.Drawing.Point(88, 64)
        Me.txttelconta.Name = "txttelconta"
        Me.txttelconta.Size = New System.Drawing.Size(120, 21)
        Me.txttelconta.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Teléfono :"
        '
        'txtdirconta
        '
        Me.txtdirconta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdirconta.Location = New System.Drawing.Point(88, 40)
        Me.txtdirconta.Name = "txtdirconta"
        Me.txtdirconta.Size = New System.Drawing.Size(320, 21)
        Me.txtdirconta.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Dirección :"
        '
        'txtcontacto
        '
        Me.txtcontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontacto.Location = New System.Drawing.Point(88, 16)
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(320, 21)
        Me.txtcontacto.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Contacto : "
        '
        'ImgMenu
        '
        Me.ImgMenu.ImageStream = CType(resources.GetObject("ImgMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgMenu.Images.SetKeyName(0, "")
        Me.ImgMenu.Images.SetKeyName(1, "")
        Me.ImgMenu.Images.SetKeyName(2, "")
        Me.ImgMenu.Images.SetKeyName(3, "")
        Me.ImgMenu.Images.SetKeyName(4, "")
        Me.ImgMenu.Images.SetKeyName(5, "")
        Me.ImgMenu.Images.SetKeyName(6, "")
        Me.ImgMenu.Images.SetKeyName(7, "")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox3.Controls.Add(Me.btncancelar)
        Me.GroupBox3.Controls.Add(Me.btnreporte)
        Me.GroupBox3.Controls.Add(Me.BtnModificar)
        Me.GroupBox3.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox3.Controls.Add(Me.BtnNuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(485, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 216)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mantenimiento"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(9, 130)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(96, 23)
        Me.BTNCERRAR.TabIndex = 21
        Me.BTNCERRAR.Text = "&Salir"
        '
        'btncancelar
        '
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.ImageIndex = 6
        Me.btncancelar.ImageList = Me.ImageList1
        Me.btncancelar.Location = New System.Drawing.Point(9, 102)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(96, 23)
        Me.btncancelar.TabIndex = 20
        Me.btncancelar.Text = "    &Cancelar"
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(9, 158)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(96, 23)
        Me.btnreporte.TabIndex = 22
        Me.btnreporte.Text = "    &Reporte"
        '
        'btnEliminar
        '
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.ImageIndex = 3
        Me.btnEliminar.ImageList = Me.ImageList1
        Me.btnEliminar.Location = New System.Drawing.Point(603, 280)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(45, 23)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "  &Eliminar"
        '
        'BtnModificar
        '
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.ImageIndex = 2
        Me.BtnModificar.ImageList = Me.ImageList1
        Me.BtnModificar.Location = New System.Drawing.Point(8, 73)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(96, 23)
        Me.BtnModificar.TabIndex = 18
        Me.BtnModificar.Text = "    &Modificar"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(8, 45)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(96, 23)
        Me.BTNGUARDAR.TabIndex = 17
        Me.BTNGUARDAR.Text = "&Grabar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.ImageIndex = 0
        Me.BtnNuevo.ImageList = Me.ImageList1
        Me.BtnNuevo.Location = New System.Drawing.Point(8, 17)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(96, 23)
        Me.BtnNuevo.TabIndex = 16
        Me.BtnNuevo.Text = "&Nuevo"
        '
        'FrmProveedor_trans
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(602, 428)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(608, 456)
        Me.MinimumSize = New System.Drawing.Size(608, 456)
        Me.Name = "FrmProveedor_trans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Proveedor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Fields Form"
    Private ValidaDatos As Boolean
    Private AIntvalor, AIntTipoProve As Integer
    Private AIntResp As Integer
    Private ABoolAgregar As Boolean
    'Private ATblImprov As New DataTable
    Public GrecibeUbicacion As Object
    Public GrecibeColumnaID As String
    Public GrecibeColumnaOpcional As String
    Public GrecibeColumnaOpcional2 As String
    Public ABoolPb_editar As Boolean
    Public pb_agregar As Boolean

#End Region

    Private Sub FrmProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        limpiar()
        CAyuda.CargarDataCombo(CmbPais, "NSP_Select_Pais", "Código", "Descripción")
        CAyuda.CargarDataCombo(CmbCuidad, "NSP_Select_Cuidad  '" & CmbPais.SelectedValue.ToString() & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cbFormaPago, "NSP_LISTAR_TIPOPAGO  '" & codempresa & "','%' ", "CODTIPOPAGO", "DSTIPOPAGO")
        CAyuda.CargarDataCombo(CboTipoProv, "SELECT  CODEMPRESA,CDTIPOPROV,DSTIPOPROV  FROM TIPOPROVEE  WHERE  CODEMPRESA='" & codempresa & "'", "CDTIPOPROV", "DSTIPOPROV")

        pb_agregar = True
        ValidaDatos = False
        Call BOTONES(True, False, False, False, True)
        AIntvalor = 0
        GroupBox1.Enabled = False
        bloquea()
    End Sub
    Sub limpiar()
        TxtCodProv.Text = ""
        TxtDireccion.Text = ""
        TxtDireccion.Text = ""
        TxtNombre.Text = ""
        TxtRuc.Text = ""
        TxtTelefono.Text = ""
        TxtWeb.Text = ""
        txtcelconta.Text = ""
        txtdirconta.Text = ""
        txttelconta.Text = ""
        txtcontacto.Text = ""
        txtcelu.Text = ""
        txtobs.Text = ""
        TXTCORREOCONTA.Text = ""
        Me.TxtNomCom.Text = ""
    End Sub
    Private Sub CmbPais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPais.SelectedIndexChanged
        'AObjBus.GCargaDataCombo(CmbCuidad, AObjBus.ListarDatos("NSP_Select_Cuidad", CmbPais.SelectedValue.ToString()).Tables(0), "Código", "Descripción")
        CAyuda.CargarDataCombo(Me.CmbCuidad, "nsp_select_ciudad_final '" & Me.CmbPais.SelectedValue.ToString & "'", "codciudad", "desciudad")
    End Sub
    Private Sub RdbExt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbExt.CheckedChanged
        If RdbExt.Checked = True Then
            CAyuda.CargarDataCombo(CmbPais, "NSP_Select_Pais", "Código", "Descripción")
            CmbPais.Enabled = True
            AIntTipoProve = 1
            TxtCodProv.Focus()
        End If
    End Sub
    Private Sub RdbNac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdbNac.CheckedChanged
        Dim CodPaisEmp As String
        If RdbNac.Checked = True Then
            CodPaisEmp = CAyuda.ListarDatos("NSP_Select_MuestraCodPais", codempresa).Tables(0).Rows(0)(0)
            '  AObjBus.GCargaDataCombo(CmbCuidad, AObjBus.ListarDatos("NSP_Select_Cuidad", CodPaisEmp.ToString).Tables(0), "Código", "Descripción")
            CmbPais.SelectedValue = CodPaisEmp
            CmbPais.Enabled = False
            AIntTipoProve = 2
            TxtCodProv.Focus()
        End If
    End Sub
    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Desbloquea()
        GroupBox1.Enabled = True
        limpiar()
        pb_agregar = True
        desbloqueatextos(Me)
        Me.CboDomiCiliado.SelectedIndex = 0
        Me.CboDomiCiliado.Enabled = True
        Call BOTONES(False, True, False, False, False)
        btnBuscar.Enabled = False
        TxtCodProv.Focus()
        CheckBox1.Checked = False
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BtnNuevo.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BtnModificar.Enabled = MODIFICAR
        btnEliminar.Enabled = ELIMINAR
        btnBuscar.Enabled = BUSCAR
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Call BOTONES(True, False, False, False, True)
        GroupBox1.Enabled = False
        bloquea()
        Me.CboDomiCiliado.Enabled = False
        btnBuscar.Enabled = True
        Call limpiar()
        Me.TxtCodProv.Focus()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim ConsProv As New FrmConsProv_Trans
        ConsProv.ObjProv = Me
        ConsProv.ShowDialog()
        Call BOTONES(True, False, True, True, True)
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If Trim(TxtCodProv.Text) = "" Then
            MessageBox.Show("¿ INGRESE UN CODIGO PROVEEDOR ?", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtCodProv.Focus()
            Exit Sub
        End If

        If Trim(TxtNombre.Text) = "" Then
            MessageBox.Show("¿ INGRESE UN NOMBRE O RAZON SOCIAL AL PROVEEDOR ?", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Question)
            TxtNombre.Focus()
            Exit Sub
        End If

        If Trim(CmbCuidad.Text) = "" Then
            MessageBox.Show("¿ INGRESE LA CIUDAD DEL PROVEEDOR ?", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Question)
            CmbCuidad.Focus()
            Exit Sub
        End If
        If RdbNac.Checked = True Then
            If Me.TxtRuc.Text.Trim <> "" Then
                If FACT_GValidaRUC(TxtRuc.Text) = False Then
                    Exit Sub
                End If
            End If
        End If
        TxtNombre.Text = Replace(TxtNombre.Text, "'", "´")
        Me.TxtNomCom.Text = Replace(Me.TxtNomCom.Text, "'", "´")
        'AIntvalor = AObjBus.ListarDatos("NSP_Select_VerficaCodigoProveedor", TxtCodProv.Text).Tables(0).Rows.Count
        AIntvalor = CAyuda.ListarDatos("NSP_Select_VerficaProveedor_Trans", TxtCodProv.Text, TxtRuc.Text.Trim, codempresa).Tables(0).Rows.Count
        If pb_agregar = True Then

            If AIntvalor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim SQL As String


                SQL = "NSP_ins_PROVEEDOR_Trans '" & txtobs.Text & "','" & txtcelconta.Text & "','" & txttelconta.Text & "','" & txtdirconta.Text & _
                "','" & txtcontacto.Text & "','" & txtcelu.Text & "','" & TxtTelefono.Text & "','" & TxtRuc.Text & "','" & TxtDireccion.Text & "','" & TxtNombre.Text & "','" & TxtCodProv.Text & "','" & CmbCuidad.SelectedValue.ToString() & "','" & IIf(IsNothing(CboTipoProv.SelectedValue), "", CboTipoProv.SelectedValue) & "','" & codempresa.ToString() & "','" & TxtWeb.Text & "','" & TXTCORREOCONTA.Text & "','" & Me.TxtNomCom.Text.Trim & "','" & CboDomiCiliado.SelectedIndex & "','" & cbFormaPago.SelectedValue & "'," & Activo
                'AIntResp = AObjBus.gGrabarReg("NSP_ins_PROVEEDOR", txtobs.Text, txtcelconta.Text, txttelconta.Text, txtdirconta.Text, _
                'txtcontacto.Text, txtcelu.Text, TxtTelefono.Text, TxtRuc.Text, TxtDireccion.Text, TxtNombre.Text, TxtCodProv.Text, CmbCuidad.SelectedValue.ToString(), AIntTipoProve.ToString(), codempresa.ToString(), TxtWeb.Text, TXTCORREOCONTA.Text, Me.TxtNomCom.Text.Trim, CboDomiCiliado.SelectedIndex)
                If TmpInsertDatos(SQL) = True Then
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TxtCodProv.Text & "','INSERT','PROVEEDOR','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                End If
                'If AIntResp = 1 Then
                '    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    insert_store("SP_REGISTRA_AUDITORIA '" & TxtCodProv.Text & "','INSERT','PROVEEDOR','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "'")
                'End If
            End If
        Else
            Dim SQL As String
            SQL = "NSP_upd_PROVEEDOR_Trans '" & txtobs.Text & "','" & txtcelconta.Text & "','" & txttelconta.Text & "','" & txtdirconta.Text & _
            "','" & txtcontacto.Text & "','" & txtcelu.Text & "','" & TxtTelefono.Text & "','" & TxtRuc.Text & "','" & TxtDireccion.Text & "','" & TxtNombre.Text & "','" & TxtCodProv.Text & "','" & CmbCuidad.SelectedValue.ToString() & "','" & IIf(IsNothing(CboTipoProv.SelectedValue), "", CboTipoProv.SelectedValue) & "','" & TxtWeb.Text & "','" & TXTCORREOCONTA.Text & "','" & Me.TxtNomCom.Text.Trim & "','" & CboDomiCiliado.SelectedIndex & "','" & codempresa & "','" & cbFormaPago.SelectedValue & "'," & Activo
            'AIntResp = AObjBus.gGrabarReg("NSP_ins_PROVEEDOR", txtobs.Text, txtcelconta.Text, txttelconta.Text, txtdirconta.Text, _
            'txtcontacto.Text, txtcelu.Text, TxtTelefono.Text, TxtRuc.Text, TxtDireccion.Text, TxtNombre.Text, TxtCodProv.Text, CmbCuidad.SelectedValue.ToString(), AIntTipoProve.ToString(), codempresa.ToString(), TxtWeb.Text, TXTCORREOCONTA.Text, Me.TxtNomCom.Text.Trim, CboDomiCiliado.SelectedIndex)
            If TmpInsertDatos(SQL) = True Then
                MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TxtCodProv.Text & "','INSERT','PROVEEDOR','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            End If
            'AIntResp = AObjBus.gGrabarReg("NSP_upd_PROVEEDOR", txtobs.Text, txtcelconta.Text, txttelconta.Text, txtdirconta.Text, _
            '    txtcontacto.Text, txtcelu.Text, TxtTelefono.Text, TxtRuc.Text, TxtDireccion.Text, TxtNombre.Text, TxtCodProv.Text, CmbCuidad.SelectedValue, AIntTipoProve, TxtWeb.Text, TXTCORREOCONTA.Text, Me.TxtNomCom.Text.Trim, CboDomiCiliado.SelectedIndex)
            'If AIntResp = 1 Then
            '    insert_store("SP_REGISTRA_AUDITORIA '" & TxtCodProv.Text & "','UPDATE','PROVEEDOR','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "'")
            '    MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        End If

        Call BOTONES(True, False, False, False, True)

        GroupBox1.Enabled = False
        bloquea()
        btnBuscar.Enabled = True
        Call limpiar()
        Me.CboDomiCiliado.SelectedIndex = 0
        Me.CboDomiCiliado.Enabled = False
        Me.TxtCodProv.Focus()
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        If Len(Me.TxtCodProv.Text.Trim) = 0 Then
            MsgBox("No Hay Ningun Proveedor Para Modificar" + Chr(13) + "Consulte un Proveedor para Modificar", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Me.TxtCodProv.Focus()
            Exit Sub
        End If

        Desbloquea()
        GroupBox1.Enabled = True
        ABoolAgregar = False
        pb_agregar = False
        Call BOTONES(False, True, False, False, True)
        Me.btnBuscar.Enabled = False
        TxtCodProv.ReadOnly = True
        TxtNombre.SelectAll()
        Me.CboDomiCiliado.Enabled = True
        TxtNombre.Focus()
    End Sub
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        If Len(Me.TxtCodProv.Text.Trim) = 0 Then
            MsgBox("No Hay Ningun Proveedor Para Eliminar" + Chr(13) + "Consulte un Proveedor para Modificar", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Me.TxtCodProv.Focus()
            Exit Sub
        End If

        If Trim(TxtCodProv.Text) = "HAL" Then
            MessageBox.Show("¡ NO SE PUEDE ELIMINAR ESTE PROVEEDOR PORQUE ES UN PROVEEDOR PREDETERMINADO ! ", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Exit Sub
        End If

        If CAyuda.ListarDatos("SP_VERF_EXIST_PROVEEDOR", TxtCodProv.Text.Trim, codempresa).Tables(0).Rows.Count > 0 Then
            MsgBox("No se puede Eliminar por estar relacionado con Documentos", MsgBoxStyle.Information, "Nar Sistemas S.A.C.")
            Exit Sub
        End If

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            AIntResp = CAyuda.Ejecutar("NSP_del_PROVEEDOR", TxtCodProv.Text, 1, codempresa)
        End If

        If AIntResp = 1 Then
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TxtCodProv.Text & "','DELETE','PROVEEDOR','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            MessageBox.Show("Registro Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        bloqueatextos(Me)
        BOTONES(True, False, False, False, True)
        limpiar()
    End Sub
    Private Sub TxtCodProv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodProv.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            AIntvalor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoProveedor", TxtCodProv.Text).Tables(0).Rows.Count
            If TxtCodProv.Text = "" Then
                MessageBox.Show("Ingrese un Codigo", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If AIntvalor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            TxtNombre.Focus()
        End If
    End Sub
    Sub bloquea()
        TxtCodProv.ReadOnly = True
        TxtDireccion.ReadOnly = True
        TxtDireccion.ReadOnly = True
        TxtNombre.ReadOnly = True
        TxtRuc.ReadOnly = True
        TxtTelefono.ReadOnly = True
        txtcelconta.ReadOnly = True
        txtdirconta.ReadOnly = True
        txttelconta.ReadOnly = True
        txtcontacto.ReadOnly = True
        txtcelu.ReadOnly = True
        txtobs.ReadOnly = True
        CmbPais.Enabled = False
        CmbCuidad.Enabled = False
        TxtWeb.ReadOnly = True
        TXTCORREOCONTA.ReadOnly = True
        Me.TxtNomCom.ReadOnly = True
    End Sub
    Sub Desbloquea()
        TxtCodProv.ReadOnly = False
        TxtDireccion.ReadOnly = False
        TxtDireccion.ReadOnly = False
        TxtNombre.ReadOnly = False
        TxtRuc.ReadOnly = False
        TxtTelefono.ReadOnly = False
        TxtWeb.ReadOnly = False
        txtcelconta.ReadOnly = False
        txtdirconta.ReadOnly = False
        txttelconta.ReadOnly = False
        txtcontacto.ReadOnly = False
        txtcelu.ReadOnly = False
        txtobs.ReadOnly = False
        CmbPais.Enabled = True
        CmbCuidad.Enabled = True
        TXTCORREOCONTA.ReadOnly = False
        Me.TxtNomCom.ReadOnly = False
    End Sub
    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            Me.TxtNomCom.Focus()
        End If
    End Sub
    Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            If CmbPais.Enabled = True Then
                CmbPais.Focus()
            Else
                CmbCuidad.Focus()
            End If
        End If
    End Sub
    Private Sub CmbCuidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbCuidad.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            TxtTelefono.Focus()
        End If
    End Sub
    Private Sub CmbPais_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPais.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            CmbCuidad.Focus()
        End If
    End Sub
    Private Sub TxtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txtcelu.Focus()
        End If
    End Sub
    Private Sub txtcelu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcelu.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            TxtWeb.Focus()
        End If
    End Sub
    Private Sub TxtRuc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRuc.KeyPress

        Call GBloqueaCaracter(Asc(e.KeyChar))
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If

        If Keyascii = 13 Then
            TxtDireccion.Focus()
        End If


    End Sub
    Private Sub txtcontacto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontacto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txtdirconta.Focus()
        End If

    End Sub
    Private Sub txtdirconta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdirconta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txttelconta.Focus()
        End If
    End Sub
    Private Sub txttelconta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelconta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txtcelconta.Focus()
        End If
    End Sub
    Private Sub txtcelconta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcelconta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            TXTCORREOCONTA.Focus()
        End If
    End Sub
    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Dim AFrm As New FrmReportProvee
        AFrm.ShowDialog(Me)
    End Sub
    Private Sub TxtNomCom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNomCom.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            Me.TxtRuc.Focus()
        End If
    End Sub
    Private Sub TxtWeb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWeb.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CboDomiCiliado.Focus()
        End If
    End Sub
    Private Sub TxtCodProv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodProv.KeyDown
        If e.KeyCode = Keys.F2 Then
            If Me.btnBuscar.Enabled = True Then
                Call btnBuscar_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub FrmProveedor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.Activate()
        Me.TxtCodProv.Focus()
    End Sub

    Private Sub TxtCodProv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodProv.TextChanged

    End Sub

    Private Sub TxtCodProv_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodProv.StyleChanged

    End Sub

    Private Sub FrmProveedor_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter

    End Sub

    Private Sub txtcelu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcelu.TextChanged

    End Sub

    Private Sub TxtWeb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWeb.TextChanged

    End Sub

    Private Sub CboDomiCiliado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDomiCiliado.SelectedIndexChanged

    End Sub

    Private Sub CboDomiCiliado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboDomiCiliado.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cbFormaPago.Focus()
        End If
    End Sub

    Private Sub cbFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormaPago.SelectedIndexChanged

    End Sub

    Private Sub cbFormaPago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbFormaPago.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CboTipoProv.Focus()
        End If
    End Sub

    Private Sub CboTipoProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoProv.SelectedIndexChanged

    End Sub

    Private Sub CboTipoProv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboTipoProv.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.BTNGUARDAR.Focus()
        End If


    End Sub

    Private Sub txttelconta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelconta.TextChanged

    End Sub

    Private Sub txtcelconta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcelconta.TextChanged

    End Sub

    Private Sub TXTCORREOCONTA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTCORREOCONTA.TextChanged

    End Sub

    Private Sub TXTCORREOCONTA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCORREOCONTA.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txtobs.Focus()
        End If
    End Sub

    Private Sub txtcontacto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontacto.TextChanged

    End Sub

    Private Sub TxtRuc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRuc.TextChanged


    End Sub

    Private Sub TxtRuc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtRuc.KeyDown

    End Sub

    Dim Activo As Integer
   
   
    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Activo = 1
        Else
            Activo = 0
        End If
    End Sub

End Class
