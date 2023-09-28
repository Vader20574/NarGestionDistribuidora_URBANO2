Imports System.Data
Imports vb = Microsoft.VisualBasic

Imports System.Data.SqlClient
Imports Servicios.Interfaces.FacturaElectronica.Peticiones
Imports Servicios.Implementacion
Imports Servicios.Interfaces.Factura

Public Class FrmNotaCredito
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbreferncia As System.Windows.Forms.ComboBox
    Friend WithEvents txtcodcli As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnrorefe As System.Windows.Forms.TextBox
    Friend WithEvents btnnotcred As System.Windows.Forms.Button
    Friend WithEvents btnreferncia As System.Windows.Forms.Button
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents cmboperador As System.Windows.Forms.ComboBox
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtgnotcred As System.Windows.Forms.DataGrid
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lbligv As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents txtcambio As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents txtdevolver As System.Windows.Forms.TextBox
    Friend WithEvents txtnronotcred As System.Windows.Forms.TextBox
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rdbdinero As System.Windows.Forms.RadioButton
    Friend WithEvents rdbprodu As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents grid2 As System.Windows.Forms.DataGrid
    Friend WithEvents btnconsulta As System.Windows.Forms.Button
    Friend WithEvents txtcorre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtpto As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TXTNOMPAGADOR As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TxtObservServ As System.Windows.Forms.TextBox
    Friend WithEvents TxtMontoInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CHKIGV As System.Windows.Forms.CheckBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents LBLSIMBOLO4 As System.Windows.Forms.Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbTipoNotaCred As ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotaCredito))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnronotcred = New System.Windows.Forms.TextBox()
        Me.cmbreferncia = New System.Windows.Forms.ComboBox()
        Me.txtcodcli = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnrorefe = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnnotcred = New System.Windows.Forms.Button()
        Me.btnreferncia = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtruc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmboperador = New System.Windows.Forms.ComboBox()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grid2 = New System.Windows.Forms.DataGrid()
        Me.dtgnotcred = New System.Windows.Forms.DataGrid()
        Me.txtcorre = New System.Windows.Forms.TextBox()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnconsulta = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LBLSIMBOLO4 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbligv = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblsubtotal = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcambio = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtObservServ = New System.Windows.Forms.TextBox()
        Me.txtdevolver = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.crRpt = New AxCrystal.AxCrystalReport()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rdbdinero = New System.Windows.Forms.RadioButton()
        Me.rdbprodu = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CbMoneda = New System.Windows.Forms.ComboBox()
        Me.cmbTipoNotaCred = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CHKIGV = New System.Windows.Forms.CheckBox()
        Me.TxtMontoInicial = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXTNOMPAGADOR = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtpto = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgnotcred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota de Credito Nro :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Referencia :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "IdCliente :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cliente :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Dirección :"
        '
        'txtnronotcred
        '
        Me.txtnronotcred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnronotcred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnronotcred.Location = New System.Drawing.Point(344, 16)
        Me.txtnronotcred.Name = "txtnronotcred"
        Me.txtnronotcred.Size = New System.Drawing.Size(112, 21)
        Me.txtnronotcred.TabIndex = 4
        Me.txtnronotcred.Text = "TEXTBOX1"
        Me.txtnronotcred.Visible = False
        '
        'cmbreferncia
        '
        Me.cmbreferncia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreferncia.Location = New System.Drawing.Point(144, 72)
        Me.cmbreferncia.Name = "cmbreferncia"
        Me.cmbreferncia.Size = New System.Drawing.Size(160, 21)
        Me.cmbreferncia.TabIndex = 9
        '
        'txtcodcli
        '
        Me.txtcodcli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodcli.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodcli.Location = New System.Drawing.Point(144, 96)
        Me.txtcodcli.Name = "txtcodcli"
        Me.txtcodcli.Size = New System.Drawing.Size(88, 21)
        Me.txtcodcli.TabIndex = 17
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(144, 120)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(328, 21)
        Me.txtnombre.TabIndex = 24
        Me.txtnombre.Text = "TEXTBOX3"
        '
        'txtdireccion
        '
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(144, 144)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(328, 21)
        Me.txtdireccion.TabIndex = 28
        Me.txtdireccion.Text = "TEXTBOX4"
        '
        'txtnrorefe
        '
        Me.txtnrorefe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnrorefe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnrorefe.Location = New System.Drawing.Point(304, 72)
        Me.txtnrorefe.MaxLength = 3
        Me.txtnrorefe.Name = "txtnrorefe"
        Me.txtnrorefe.Size = New System.Drawing.Size(38, 21)
        Me.txtnrorefe.TabIndex = 10
        Me.txtnrorefe.Text = "TEXTBOX5"
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
        Me.ImageList1.Images.SetKeyName(14, "")
        '
        'btnnotcred
        '
        Me.btnnotcred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnotcred.ImageIndex = 5
        Me.btnnotcred.ImageList = Me.ImageList1
        Me.btnnotcred.Location = New System.Drawing.Point(272, 16)
        Me.btnnotcred.Name = "btnnotcred"
        Me.btnnotcred.Size = New System.Drawing.Size(40, 23)
        Me.btnnotcred.TabIndex = 3
        '
        'btnreferncia
        '
        Me.btnreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreferncia.ImageIndex = 5
        Me.btnreferncia.ImageList = Me.ImageList1
        Me.btnreferncia.Location = New System.Drawing.Point(448, 72)
        Me.btnreferncia.Name = "btnreferncia"
        Me.btnreferncia.Size = New System.Drawing.Size(40, 23)
        Me.btnreferncia.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(312, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "R.U.C."
        '
        'txtruc
        '
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruc.Location = New System.Drawing.Point(360, 96)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.ReadOnly = True
        Me.txtruc.Size = New System.Drawing.Size(112, 21)
        Me.txtruc.TabIndex = 20
        Me.txtruc.Text = "TEXTBOX6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(488, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha Doc :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(494, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Vendedor :"
        '
        'cmboperador
        '
        Me.cmboperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboperador.Enabled = False
        Me.cmboperador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboperador.Location = New System.Drawing.Point(560, 144)
        Me.cmboperador.Name = "cmboperador"
        Me.cmboperador.Size = New System.Drawing.Size(216, 21)
        Me.cmboperador.TabIndex = 30
        '
        'dtpfecha
        '
        Me.dtpfecha.Enabled = False
        Me.dtpfecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(560, 120)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(97, 21)
        Me.dtpfecha.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grid2)
        Me.GroupBox1.Controls.Add(Me.dtgnotcred)
        Me.GroupBox1.Controls.Add(Me.txtcorre)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 159)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'grid2
        '
        Me.grid2.CaptionText = "Detalle por Documentos"
        Me.grid2.DataMember = ""
        Me.grid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid2.Location = New System.Drawing.Point(16, 20)
        Me.grid2.Name = "grid2"
        Me.grid2.ReadOnly = True
        Me.grid2.Size = New System.Drawing.Size(812, 164)
        Me.grid2.TabIndex = 1
        '
        'dtgnotcred
        '
        Me.dtgnotcred.CaptionText = "Detalle por Documentos"
        Me.dtgnotcred.DataMember = ""
        Me.dtgnotcred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgnotcred.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgnotcred.Location = New System.Drawing.Point(16, 21)
        Me.dtgnotcred.Name = "dtgnotcred"
        Me.dtgnotcred.ReadOnly = True
        Me.dtgnotcred.Size = New System.Drawing.Size(768, 165)
        Me.dtgnotcred.TabIndex = 0
        '
        'txtcorre
        '
        Me.txtcorre.Location = New System.Drawing.Point(456, 48)
        Me.txtcorre.Name = "txtcorre"
        Me.txtcorre.Size = New System.Drawing.Size(128, 21)
        Me.txtcorre.TabIndex = 2
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(13, 23)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(84, 23)
        Me.BTNNUEVO.TabIndex = 0
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btnconsulta)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(824, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 318)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'Button4
        '
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageIndex = 14
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(14, 276)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "&Editar Nº"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(13, 246)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "&Eliminar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnconsulta
        '
        Me.btnconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconsulta.ImageIndex = 11
        Me.btnconsulta.ImageList = Me.ImageList1
        Me.btnconsulta.Location = New System.Drawing.Point(13, 213)
        Me.btnconsulta.Name = "btnconsulta"
        Me.btnconsulta.Size = New System.Drawing.Size(84, 23)
        Me.btnconsulta.TabIndex = 7
        Me.btnconsulta.Text = "&Reporte"
        Me.btnconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 12
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(13, 118)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(84, 23)
        Me.btnreporte.TabIndex = 4
        Me.btnreporte.Text = "&Imprimir"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(13, 151)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(84, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(13, 183)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(84, 23)
        Me.BTNCERRAR.TabIndex = 6
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 13
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(13, 84)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(84, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Anular"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(13, 54)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(84, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(13, 85)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(84, 23)
        Me.BTNMODIFICAR.TabIndex = 3
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNMODIFICAR.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sub Total :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LBLSIMBOLO4)
        Me.GroupBox3.Controls.Add(Me.lbltotal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.lbligv)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblsubtotal)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(304, 480)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 54)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'LBLSIMBOLO4
        '
        Me.LBLSIMBOLO4.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLO4.Location = New System.Drawing.Point(376, 24)
        Me.LBLSIMBOLO4.Name = "LBLSIMBOLO4"
        Me.LBLSIMBOLO4.Size = New System.Drawing.Size(30, 16)
        Me.LBLSIMBOLO4.TabIndex = 50
        Me.LBLSIMBOLO4.Text = "S/"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.White
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(408, 20)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(88, 24)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "0.00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(344, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Total  "
        '
        'lbligv
        '
        Me.lbligv.BackColor = System.Drawing.Color.White
        Me.lbligv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbligv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbligv.Location = New System.Drawing.Point(240, 20)
        Me.lbligv.Name = "lbligv"
        Me.lbligv.Size = New System.Drawing.Size(88, 24)
        Me.lbligv.TabIndex = 3
        Me.lbligv.Text = "0.00"
        Me.lbligv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(192, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "I.G.V. :"
        '
        'lblsubtotal
        '
        Me.lblsubtotal.BackColor = System.Drawing.Color.White
        Me.lblsubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblsubtotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(88, 20)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(88, 24)
        Me.lblsubtotal.TabIndex = 1
        Me.lblsubtotal.Text = "0.00"
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(481, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Tipo Cambio :"
        '
        'txtcambio
        '
        Me.txtcambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcambio.Location = New System.Drawing.Point(560, 96)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.ReadOnly = True
        Me.txtcambio.Size = New System.Drawing.Size(96, 21)
        Me.txtcambio.TabIndex = 22
        Me.txtcambio.Text = "TEXTBOX7"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TxtObservServ)
        Me.GroupBox4.Controls.Add(Me.txtdevolver)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.btnActualizar)
        Me.GroupBox4.Controls.Add(Me.crRpt)
        Me.GroupBox4.Location = New System.Drawing.Point(304, 408)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(512, 72)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(50, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Observacion:"
        '
        'TxtObservServ
        '
        Me.TxtObservServ.Location = New System.Drawing.Point(122, 44)
        Me.TxtObservServ.Name = "TxtObservServ"
        Me.TxtObservServ.Size = New System.Drawing.Size(380, 21)
        Me.TxtObservServ.TabIndex = 5
        '
        'txtdevolver
        '
        Me.txtdevolver.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdevolver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdevolver.Location = New System.Drawing.Point(124, 16)
        Me.txtdevolver.Name = "txtdevolver"
        Me.txtdevolver.Size = New System.Drawing.Size(112, 21)
        Me.txtdevolver.TabIndex = 2
        Me.txtdevolver.Text = "TEXTBOX2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Cantidad A Devolver :"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(426, 14)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(72, 24)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.Visible = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(24, 16)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(496, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Pto. Venta :"
        Me.Label9.Visible = False
        '
        'txtnumero
        '
        Me.txtnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnumero.Location = New System.Drawing.Point(360, 72)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(88, 21)
        Me.txtnumero.TabIndex = 12
        Me.txtnumero.Text = "TEXTBOX1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(344, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "-"
        '
        'rdbdinero
        '
        Me.rdbdinero.Location = New System.Drawing.Point(240, 48)
        Me.rdbdinero.Name = "rdbdinero"
        Me.rdbdinero.Size = New System.Drawing.Size(61, 16)
        Me.rdbdinero.TabIndex = 7
        Me.rdbdinero.Text = "Dinero"
        Me.rdbdinero.Visible = False
        '
        'rdbprodu
        '
        Me.rdbprodu.Checked = True
        Me.rdbprodu.Location = New System.Drawing.Point(152, 48)
        Me.rdbprodu.Name = "rdbprodu"
        Me.rdbprodu.Size = New System.Drawing.Size(72, 16)
        Me.rdbprodu.TabIndex = 6
        Me.rdbprodu.TabStop = True
        Me.rdbprodu.Text = "Producto"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(38, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Tipo Nota Crèdito :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.CbMoneda)
        Me.GroupBox6.Controls.Add(Me.cmbTipoNotaCred)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.CHKIGV)
        Me.GroupBox6.Controls.Add(Me.TxtMontoInicial)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.TXTNOMPAGADOR)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.TextBox1)
        Me.GroupBox6.Controls.Add(Me.txtpto)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.txtcambio)
        Me.GroupBox6.Controls.Add(Me.dtpfecha)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.cmboperador)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txtnronotcred)
        Me.GroupBox6.Controls.Add(Me.cmbreferncia)
        Me.GroupBox6.Controls.Add(Me.txtcodcli)
        Me.GroupBox6.Controls.Add(Me.txtnombre)
        Me.GroupBox6.Controls.Add(Me.txtdireccion)
        Me.GroupBox6.Controls.Add(Me.txtnrorefe)
        Me.GroupBox6.Controls.Add(Me.btnnotcred)
        Me.GroupBox6.Controls.Add(Me.btnreferncia)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.txtruc)
        Me.GroupBox6.Controls.Add(Me.txtnumero)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.rdbdinero)
        Me.GroupBox6.Controls.Add(Me.rdbprodu)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(800, 231)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(38, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 13)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Tipo Nota Credito :"
        '
        'CbMoneda
        '
        Me.CbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbMoneda.Enabled = False
        Me.CbMoneda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbMoneda.Location = New System.Drawing.Point(559, 75)
        Me.CbMoneda.Name = "CbMoneda"
        Me.CbMoneda.Size = New System.Drawing.Size(217, 22)
        Me.CbMoneda.TabIndex = 49
        '
        'cmbTipoNotaCred
        '
        Me.cmbTipoNotaCred.FormattingEnabled = True
        Me.cmbTipoNotaCred.Location = New System.Drawing.Point(144, 194)
        Me.cmbTipoNotaCred.Name = "cmbTipoNotaCred"
        Me.cmbTipoNotaCred.Size = New System.Drawing.Size(246, 21)
        Me.cmbTipoNotaCred.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(501, 77)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Moneda :"
        '
        'CHKIGV
        '
        Me.CHKIGV.Checked = True
        Me.CHKIGV.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKIGV.Location = New System.Drawing.Point(683, 23)
        Me.CHKIGV.Name = "CHKIGV"
        Me.CHKIGV.Size = New System.Drawing.Size(93, 20)
        Me.CHKIGV.TabIndex = 8
        Me.CHKIGV.Text = "Aplicar IGV"
        Me.CHKIGV.Visible = False
        '
        'TxtMontoInicial
        '
        Me.TxtMontoInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMontoInicial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMontoInicial.Location = New System.Drawing.Point(560, 168)
        Me.TxtMontoInicial.Name = "TxtMontoInicial"
        Me.TxtMontoInicial.ReadOnly = True
        Me.TxtMontoInicial.Size = New System.Drawing.Size(96, 21)
        Me.TxtMontoInicial.TabIndex = 34
        Me.TxtMontoInicial.Text = "TEXTBOX7"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(482, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Monto Inicial :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(80, 168)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Pagador :"
        '
        'TXTNOMPAGADOR
        '
        Me.TXTNOMPAGADOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNOMPAGADOR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMPAGADOR.Location = New System.Drawing.Point(144, 168)
        Me.TXTNOMPAGADOR.Name = "TXTNOMPAGADOR"
        Me.TXTNOMPAGADOR.ReadOnly = True
        Me.TXTNOMPAGADOR.Size = New System.Drawing.Size(216, 21)
        Me.TXTNOMPAGADOR.TabIndex = 32
        Me.TXTNOMPAGADOR.Text = "TXT"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(200, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(72, 21)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(48, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtpto
        '
        Me.txtpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtpto.Enabled = False
        Me.txtpto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpto.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtpto.Location = New System.Drawing.Point(560, 49)
        Me.txtpto.Name = "txtpto"
        Me.txtpto.Size = New System.Drawing.Size(178, 21)
        Me.txtpto.TabIndex = 15
        Me.txtpto.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(605, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(16, 424)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(264, 72)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo"
        Me.ColumnHeader2.Width = 65
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nro Doc"
        Me.ColumnHeader3.Width = 155
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(16, 400)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(208, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Documentos de la Nota de Crèdito"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(72, 504)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Eliminar Documento"
        '
        'FrmNotaCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(936, 529)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(952, 568)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(950, 566)
        Me.Name = "FrmNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de Credito Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgnotcred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AObjBus As New ClsAyuda
    Public ATblCli As New DataTable
    Public ATblNotCred As New DataTable
    Public ATblNotDine As New DataTable
    Public ATblNotCredDet As New DataTable
    Dim ATblCodCorr As New DataTable
    Dim ATblDetNot As New DataTable
    Public ADblCORRELATIVO As Double
    Public AMonBasdoc As String
    Dim AIntResp As Integer
    Dim ABoolHistorico As Boolean
    Dim ADateFechaProcesoNotCred As Date
    Dim Almacennotcred, estadonotcred, CDCLIENTEDEP As String
    Dim ADBlEstadoNotCred As String
    Public codigopagador As String
    Public activa As Integer

    Dim dt_data As New DataTable
    Dim IDCODIGO, TipDocNtaCred As String


    Dim IGV As Double
    Dim SUBTOTAL As Double
    Dim PERCEP As Double
    Dim TIPO_IGV As String
    Dim EMAIL As String
    Dim DNI As String
    Dim LETRADOC As String
    Dim SERIE As String
    Dim NRODOCSIN As String
    Dim NRODOCFINAL As String
    Dim nrodocref As String
    Dim tipodocref As String

    Dim NUMSERIE2 As String
    Dim NUMSERIE As String

    Dim FormatNroDoc2 As String
    Dim SERIE2 As String
    Dim NRODOCFINAL2 As String
    Dim NRODOCSIN2 As String


    Sub LLENA()
        Dim i As Short
        Dim numeror As String
        Dim cargar As Integer

        For i = 0 To Me.ListView1.Items.Count - 1
            numeror = Me.ListView1.Items(0).SubItems(2).Text
            If IDCODIGO = numeror Then
                cargar = 1
            End If
        Next
        If cargar = 0 Then
            TipDocNtaCred = Me.cmbreferncia.SelectedValue.ToString
            ATblCli = AObjBus.ListarDatos("NSP_SELECT_LISTAVENTACABNOTCRED", TipDocNtaCred.ToString(), IDCODIGO, codempresa.ToString(), Tabla).Tables(0)

            If ATblCli.Rows.Count = 0 Then
                MessageBox.Show("No existen relaciones entre la venta y el vendedor para efectuar la operación. Verifique que el documento tenga un vendedor que existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            txtnrorefe.Text = Format(CDbl(Mid(ATblCli.Rows(0)("NRODOCU"), 1, Len(Trim(ATblCli.Rows(0)("NRODOCU"))) - 8)), "000")
            txtnumero.Text = Mid(ATblCli.Rows(0)("NRODOCU"), Len(Trim(ATblCli.Rows(0)("NRODOCU"))) + 1 - 8, 8)


            Dim m As New ListViewItem
            m.SubItems.Add(Me.cmbreferncia.SelectedValue.ToString())
            m.SubItems.Add(ATblCli.Rows(0)("NRODOCU"))
            Me.ListView1.Items.Add(m)

            txtcodcli.Text = GValidarNulos(ATblCli.Rows(0)("CODCLIENTE"))
            txtruc.Text = GValidarNulos(ATblCli.Rows(0)("RUCCLIENTE"))
            txtnombre.Text = GValidarNulos(ATblCli.Rows(0)("DESCLIENTE"))
            txtdireccion.Text = GValidarNulos(ATblCli.Rows(0)("DIRCLIENTE"))
            cmboperador.SelectedValue = GValidarNulos(ATblCli.Rows(0)("CODVEND"))
            txtpto.SelectedValue = GValidarNulos(ATblCli.Rows(0)("NROPTOVTA"))
            dtpfecha.Value = GValidarNulos(ATblCli.Rows(0)("FECDOCUM"))
            Almacennotcred = GValidarNulos(ATblCli.Rows(0)("CDZONA"))
            estadonotcred = IIf(vb.IsDBNull(ATblCli.Rows(0)("ESTADO")), "", ATblCli.Rows(0)("ESTADO"))
            ADateFechaProcesoNotCred = GValidarNulos(ATblCli.Rows(0)("FECPROCESO"))
            CDCLIENTEDEP = GValidarNulos(ATblCli.Rows(0)("CODDEP"))

            If GValidarNulos(ATblCli.Rows(0)("CODMON")).ToString.Trim = "S" Then
                TxtMontoInicial.Text = GValidarNulos(ATblCli.Rows(0)("TOTBAS"))
                Me.LBLSIMBOLO4.Text = FACT_SIMBOLOMON
            End If
            If GValidarNulos(ATblCli.Rows(0)("CODMON")).ToString.Trim = "D" Then
                TxtMontoInicial.Text = GValidarNulos(ATblCli.Rows(0)("TOTEXT"))
                Me.LBLSIMBOLO4.Text = FACT_SIMBOLOMONEXTR
            End If


            CbMoneda.SelectedValue = GValidarNulos(ATblCli.Rows(0)("CODMON"))

            Dim dt_data As New DataTable
            dt_data = CAyuda.ListarDatos("nspselclie", CDCLIENTEDEP, codempresa).Tables(0)
            'conecta1("nspselclie '" & CDCLIENTEDEP & "','" & Variables.CODEMP & "'", "clie")
            If dt_data.Rows.Count > 0 Then
                Me.TXTNOMPAGADOR.Text = dt_data.Rows(0)(0)
            End If
            Dim DETTABLA As String
            If Tabla = "VENTACAB" Then
                DETTABLA = "VENTADET"
            Else
                DETTABLA = "VENTD" + Strings.Right(Tabla, 6)
            End If


            CAyuda.Ejecutar("NSP_INS_TMP_NTACREDDET", ADblCORRELATIVO, TipDocNtaCred.ToString(), CDbl(ATblCli.Rows(0)("NRODOCU")), DETTABLA, codempresa)


            'Guarda("NSP_INS_TMP_NTACREDDET " & ADblCORRELATIVO & ",'" & TipDocNtaCred.ToString() & "','" & CDbl(ATblCli.Rows(0)("NRODOCU")) & "','" & DETTABLA & "','" & codempresa & "'")


            Me.ListView1.Items(Me.ListView1.Items.Count - 1).Selected = True
            Me.ListView1.Items(Me.ListView1.Items.Count - 1).Focused = True

            If rdbprodu.Checked = True Then
                ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET_varios", ADblCORRELATIVO, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim, codempresa).Tables(0)
            Else
                ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET_varios", ADblCORRELATIVO, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim).Tables(0)
            End If
            dtgnotcred.DataSource = ATblDetNot
            AMonBasdoc = GValidarNulos(ATblCli.Rows(0)("CODMON"))
            txtpto.Text = NROPTOVTA.ToString.Trim
            txtcambio.Text = VCambioVta
            rdbprodu.Enabled = False
            rdbdinero.Enabled = False

        End If
        cargar = 0


    End Sub
    Private Sub btnreferncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreferncia.Click
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









            CAyuda.Ejecutar("NSP_SELECT_LISTADOCUMENTOSNOTACRED_J", Me.cmbreferncia.SelectedValue.ToString, IDCODIGO)

            Conecta("SELECT * FROM TMPVENTANTACREDCONS", "LLENA")
                If ds.Tables("LLENA").Rows.Count > 0 Then

                    IDCODIGO = GValidarNulos(ds.Tables("llena").Rows(0)(0))
                    Tabla = GValidarNulos(ds.Tables("llena").Rows(0)(1))
                    AboolCargarValor = True
                    LLENA()
                Else
                    MessageBox.Show("No existe el documento ingresado. Verifique!!", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtnrorefe.Focus()
                    Me.txtnrorefe.SelectAll()
                    Exit Sub
                End If


        Catch x As Exception
            '  MessageBox.Show(x.Message)
        End Try
    End Sub

    Private Sub FrmNotaCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarFormularios(Me)

        AObjBus.CargarDataCombo(Me.txtpto, "Nsp_Sele_tdaptoventa '" & codempresa & "','',''", "NROPTOVTA", "DESPTOVTA")
        CAyuda.CargarDataCombo(CbMoneda, "Nsl_selec_moneda '" & codempresa & "'", "Codigo", "Descripcion")
        AObjBus.GCargaDataCombo(cmbreferncia, AObjBus.ListarDatos("NSP_SELECT_LISTATIPODOCNTACRE", codempresa.ToString()).Tables(0), "Código", "Descripción")
        AObjBus.GCargaDataCombo(cmboperador, AObjBus.ListarDatos("Nsp_Sele_Vendedores", codempresa.ToString()).Tables(0), "Codigo", "Descripcion")
        TipDocNtaCred = cmbreferncia.SelectedValue.ToString()
        ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET", ADblCORRELATIVO).Tables(0)
        dtgnotcred.DataSource = ATblDetNot


        AObjBus.GCargaDataCombo(cmbTipoNotaCred, AObjBus.ListarDatos("Nsp_Sele_TipoNotaCred", codempresa.ToString()).Tables(0), "Codigo", "Descripcion")



        FormatGrid()
        txtcambio.Text = VCambioVta
        txtpto.SelectedValue = NROPTOVTA.ToString.Trim          ''''AStrNomPtoVta
        txtnronotcred.ReadOnly = True
        btnnotcred.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNMODIFICAR.Enabled = True
        BTNELIMINAR.Enabled = True
        ATblNotDine = AObjBus.ListarDatos("NSP_SELECT_LISTADONOTCREDDETDINE", 0, codempresa.ToString()).Tables(0)
        grid2.DataSource = ATblNotDine
        FormatGrid2()
        grid2.Visible = False
        txtnombre.Enabled = False
        txtnumero.Enabled = False
        btnreferncia.Enabled = False
        cmbreferncia.Enabled = False
        txtnrorefe.Enabled = False
        txtnumero.Enabled = False
        txtcodcli.Enabled = False
        Button1.Enabled = False

        txtdevolver.ReadOnly = False
        dtgnotcred.Enabled = False

        dtpfecha.Value = Format(vFechaActual, "dd/MM/yyyy")


        FACT_SIMBOLOMON = "S/"
        FACT_SIMBOLOMONEXTR = "$"

        txtnronotcred.Focus()

    End Sub
    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = ATblDetNot.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Item"
            .MappingName = "Item_"
            .Width = 30
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Código"
            .MappingName = "CDARTI"
            .Width = 80
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "Descripción"
            .MappingName = "DSARTI"
            .Width = 200
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "U_Med"
            .MappingName = "coduMED"
            .Width = 50
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "Cantidad"
            .MappingName = "Cantidad_"
            .Width = 100
            .Format = GMascaraDec(2)
            .Alignment = HorizontalAlignment.Right
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "Precio"
            .MappingName = "Precio_"
            .Width = 55
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(2)
        End With
        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "Total"
            .MappingName = "TOTBAS"
            .Width = 60
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(2)
        End With

        '''Dim grdColStyle9 As New DataGridTextBoxColumn
        '' With grdColStyle9
        ''.HeaderText = "Nro.Bultos"
        ''.MappingName = "DESCANTIPO"
        ''.Width = 65
        ''.Alignment = HorizontalAlignment.Right
        ''End With

        Dim grdColStyle10 As New DataGridTextBoxColumn
        With grdColStyle10
            .HeaderText = "Descuento"
            .MappingName = "MONTODESCBAS"
            .Width = 65
            .Alignment = HorizontalAlignment.Right
        End With
        Dim grdColStyle11 As New DataGridTextBoxColumn
        With grdColStyle11
            .HeaderText = "Devolver"
            .MappingName = "CANTIDAD_DEV"
            .Width = 70
            .Format = GMascaraDec(2)
            .Alignment = HorizontalAlignment.Right
        End With
        'Dim grdColStyle12 As New DataGridTextBoxColumn
        'With grdColStyle12
        '    .HeaderText = "Devolver Bulto"
        '    .MappingName = "Bulto_DEV"
        '    .Width = 70
        '    .Format = GFormatodeNumero(0)
        '    .Alignment = HorizontalAlignment.Right
        'End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5, grdColStyle7, grdColStyle8, grdColStyle10, grdColStyle11})
        dtgnotcred.TableStyles.Add(grdTableStyle1)
        ''grdColStyle9,
    End Sub
    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Try
            Dim b As Double  ', c
            b = dtgnotcred.Item(dtgnotcred.CurrentRowIndex, 4)
            'c = dtgnotcred.Item(dtgnotcred.CurrentRowIndex, 7)

            If txtdevolver.Text.Trim <> "" Then
                If rdbprodu.Checked = True Then
                    If CDbl(txtdevolver.Text) > CDbl(b) Then
                        MsgBox("La Cantidad a Devolver No es Válida. ", 0, "Nota de Credito")
                        txtdevolver.Focus()
                        Exit Sub
                    End If

                    'If CDbl(TXTBULTO.Text) > CDbl(c) Then
                    '    MsgBox("EL Nro Bulto a Devolver No es Válida. ", 0, "Nota de Credito")
                    '    TXTBULTO.Focus()
                    '    Exit Sub
                    'End If

                Else
                    ''If CDbl(txtdevolver.Text) > CDbl(dtgnotcred.Item(dtgnotcred.CurrentRowIndex, 6)) Then
                    '' MsgBox("La Cantidad a Devolver No es Válida. ", 0, "Nota de Credito")
                    ''txtdevolver.Focus()
                    ''Exit Sub
                    '''End If

                End If
                With dtgnotcred
                    If rdbprodu.Checked = True Then
                        AObjBus.Ejecutar("NSP_Upd_TMP_NTACRED_varios", .Item(.CurrentRowIndex, 0), .Item(.CurrentRowIndex, 1), CSng(txtdevolver.Text), .Item(.CurrentRowIndex, 5), VCambioVta, ADblCORRELATIVO, ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim.ToUpper, ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim.ToUpper, codempresa.Trim, CbMoneda.SelectedValue)
                    Else
                        AObjBus.Ejecutar("NSP_Upd_TMP_NTACRED_DINERO_varios", .Item(.CurrentRowIndex, 0), .Item(.CurrentRowIndex, 1), CSng(txtdevolver.Text), .Item(.CurrentRowIndex, 5), VCambioVta, ADblCORRELATIVO, ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim.ToUpper, ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim.ToUpper, codempresa)
                    End If
                    ATblDetNot.Clear()
                    ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET_varios", ADblCORRELATIVO, ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim.ToUpper, ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim.ToUpper).Tables(0)
                    dtgnotcred.DataSource = ATblDetNot
                    Call ActualizaTotales(ADblCORRELATIVO, AMonBasdoc)
                    txtdevolver.Text = "0.00"
                    Me.TxtObservServ.Text.Trim()
                End With
            End If
        Catch
        End Try
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message,
                                    ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If dtgnotcred.Focus = True Then
                        txtdevolver.Text = ""
                        'TXTBULTO.Text = ""
                        txtdevolver.Focus()
                    End If
            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub txtdevolver_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdevolver.KeyPress
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

            MONTOCIGV = ((txtdevolver.Text) / VALORIGV)
            lblsubtotal.Text = Format(MONTOCIGV, "#######0.00")
            lbligv.Text = Format(MONTOCIGV * (VALORIGV - 1), "#######0.00")
            lbltotal.Text = Format(CDbl(lblsubtotal.Text) + CDbl(lbligv.Text), "#######0.00")

        End If


        ''Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))
        'If Keyascii = 0 Then
        '    e.Handled = True
        '    TXTBULTO.Focus()
        'End If

        If Keyascii = 13 Then
            btnActualizar_Click(sender, e)
        End If

    End Sub
    Private Sub ActualizaTotales(ByVal lngCORRELATIVO As Long, ByVal strCodigoMoneda As String)
        Dim TblTot As New DataTable
        TblTot = AObjBus.ListarDatos("NSP_SELCT_OBTOTALES_NOTACRED_VENT", lngCORRELATIVO, AMonBasdoc, codempresa).Tables(0)

        'lblSimbMon.Caption = IIf(strCodigoMoneda = GstrCodMonedaBase, GstrSimbMonedaBase, GstrSimbMonedaExtr)
        lblsubtotal.Text = GMascaraDec_D(CSng(TblTot.Rows(0)(2)))
        lbligv.Text = GMascaraDec_D(CSng(TblTot.Rows(0)(1)))
        lbltotal.Text = GMascaraDec_D(CSng(TblTot.Rows(0)(0)))
        lbltotal.Refresh()
        lbligv.Refresh()
        lblsubtotal.Refresh()

    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

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

        Dim ADblNumero As Double
        Try
            If AObjBus.ListarDatos("NSP_SELECT_BUSCADOCNOTCRED1", Trim(txtnronotcred.Text), codempresa.ToString(), cmbreferncia.SelectedValue).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("El Numero de Nota de Credito ya Existe Verifique o Ingrese otro Numero", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question)
                txtnronotcred.Focus()
                Exit Sub
            End If
            activa = 0

            If CSng(lbltotal.Text) = 0 Then
                MsgBox("Total Nota Credito Mayor a Cero ", MsgBoxStyle.Critical, "Nota de Credito")
                ' dtgnotcred.Focus()
                Exit Sub
            End If

            ADblNumero = CDbl(txtnrorefe.Text.Trim & txtnumero.Text.Trim)
            VCdTipoDoc = "07"


            If cmbreferncia.SelectedValue = "01" Then
                LETRADOC = "F"
            End If
            If cmbreferncia.SelectedValue = "03" Then
                LETRADOC = "B"
            End If
            If cmbreferncia.SelectedValue = "06" Then
                LETRADOC = "P"
            End If

            Dim NUMSERIE2 As String
            NUMSERIE2 = txtnrorefe.Text.Trim
            SERIE2 = LETRADOC + NUMSERIE2
            NRODOCSIN2 = CStr(Microsoft.VisualBasic.Right(txtnumero.Text, 8))
            NRODOCFINAL2 = SERIE2 + "-" + NRODOCSIN2

            If rdbprodu.Checked = True Then

                If CbMoneda.SelectedValue.ToString.Trim = "S" Then
                    AIntResp = AObjBus.Ejecutar("NSP_INS_NOTACREDITO_J", ADblCORRELATIVO, txtnronotcred.Text, VCdTipoDoc, ADblNumero, AMonBasdoc, txtcambio.Text, Almacennotcred.ToString(), cmboperador.SelectedValue.ToString(), GValidarNulos(estadonotcred.ToString()), dtpfecha.Value, ADateFechaProcesoNotCred, GMascaraDec_D(CDbl(lbltotal.Text)), GMascaraDec_D(CDbl(lbltotal.Text) / CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(lblsubtotal.Text)), GMascaraDec_D(CDbl(lblsubtotal.Text) / CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(lbligv.Text)), GMascaraDec_D(CDbl(lbligv.Text) / CDbl(txtcambio.Text)), txtcodcli.Text, txtruc.Text, txtnombre.Text, txtdireccion.Text, CodUsuario.ToString, NROPTOVTA.ToString.Trim, codempresa, "P", CDCLIENTEDEP, TxtObservServ.Text, cmbTipoNotaCred.SelectedValue, cmbreferncia.SelectedValue, LETRADOC & TextBox1.Text, TextBox2.Text, NRODOCFINAL2)
                End If
                If CbMoneda.SelectedValue.ToString.Trim = "D" Then
                    AIntResp = AObjBus.Ejecutar("NSP_INS_NOTACREDITO_J", ADblCORRELATIVO, txtnronotcred.Text, VCdTipoDoc, ADblNumero, AMonBasdoc, txtcambio.Text, Almacennotcred.ToString(), cmboperador.SelectedValue.ToString(), GValidarNulos(estadonotcred.ToString()), dtpfecha.Value, ADateFechaProcesoNotCred, GMascaraDec_D(CDbl(lbltotal.Text) * CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(lbltotal.Text)), GMascaraDec_D(CDbl(lblsubtotal.Text) * CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(lblsubtotal.Text)), GMascaraDec_D(CDbl(lbligv.Text) * CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(lbligv.Text)), txtcodcli.Text, txtruc.Text, txtnombre.Text, txtdireccion.Text, CodUsuario.ToString, NROPTOVTA.ToString.Trim, codempresa, "P", CDCLIENTEDEP, TxtObservServ.Text, cmbTipoNotaCred.SelectedValue, cmbreferncia.SelectedValue, LETRADOC & TextBox1.Text, TextBox2.Text, NRODOCFINAL2)
                End If
                'If GRABAEFECTIVOS(VCdPagEfectivo, dtpfecha.Value) = True Then
                '    'CAyuda.Ejecutar("NSP_ACTUALIZAR_STOCK_FACT", codempresa.Trim, CInt(CTRLCANTIDAD.Text.Trim))
                'End If
            Else
                ''''GRABAR EN  TABLA NTACREDCABSER --- SERVICIO
                AIntResp = AObjBus.Ejecutar("NSP_INS_NOTACREDITO_J", ADblCORRELATIVO, txtnronotcred.Text, VCdTipoDoc, ADblNumero, AMonBasdoc, txtcambio.Text, Almacennotcred.ToString(), cmboperador.SelectedValue.ToString(), GValidarNulos(estadonotcred.ToString()), dtpfecha.Value, ADateFechaProcesoNotCred, GMascaraDec_D(CDbl(lbltotal.Text)), GMascaraDec_D(CDbl(lbltotal.Text) / CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(lblsubtotal.Text)), GMascaraDec_D(CDbl(lblsubtotal.Text) / CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(lbligv.Text)), GMascaraDec_D(CDbl(lbligv.Text) / CDbl(txtcambio.Text)), txtcodcli.Text, txtruc.Text, txtnombre.Text, txtdireccion.Text, CodUsuario.ToString, NROPTOVTA.ToString, codempresa, "D", CDCLIENTEDEP, TxtObservServ.Text, cmbTipoNotaCred.SelectedValue, cmbreferncia.SelectedValue, LETRADOC & TextBox1.Text, TextBox2.Text)
                'AIntResp = AObjBus.gGrabarReg("NSP_ins_NTACREDCABSER", txtnronotcred.Text, cmbreferncia.SelectedValue.ToString(), ADblNumero, AMonBasdoc, txtcambio.Text, cmboperador.SelectedValue.ToString(), dtpfecha.Value, GFormatodeNumero(CDbl(lbltotal.Text)), GFormatodeNumero(CDbl(lbltotal.Text) / CDbl(txtcambio.Text)), GFormatodeNumero(CDbl(lblsubtotal.Text)), GFormatodeNumero(CDbl(lblsubtotal.Text) / CDbl(txtcambio.Text)), GFormatodeNumero(CDbl(lbligv.Text)), GFormatodeNumero(CDbl(lbligv.Text) / CDbl(txtcambio.Text)), txtcodcli.Text, txtruc.Text, txtnombre.Text, txtdireccion.Text, Variables.usuario.ToString, NROPTOVTA.Trim, codempresa, TxtObservServ.Text.Trim, "C", CDCLIENTEDEP)
                'If GRABAEFECTIVOS(VCdPagEfectivo, dtpfecha.Value) = True Then
                '    'CAyuda.Ejecutar("NSP_ACTUALIZAR_STOCK_FACT", codempresa.Trim, CInt(CTRLCANTIDAD.Text.Trim))
                'End If

            End If




            '''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''
            '''''FACTURACION ELECTRONICA ENVIO BASE''''''
            '''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''''''''''''''''''''''''''''''''''

            If EMIELECTRONIC = True Then
                If cmbreferncia.SelectedValue.Trim = "01" Or cmbreferncia.SelectedValue.Trim = "03" Then

                    Dim TipoDoc As String
                    TipoDoc = VCdTipoDoc
                    VRuc = txtruc.Text
                    VCodCliente = txtcodcli.Text
                    VNroDoc = txtnronotcred.Text

                    IGV = CDbl(lbligv.Text)
                    SUBTOTAL = CDbl(lblsubtotal.Text)
                    PERCEP = 0

                    If IGV > 0 Then
                        TIPO_IGV = "SI"
                    Else
                        TIPO_IGV = "NO"
                    End If

                    Dim Table_VC2 As New DataTable
                    Table_VC2 = TmpListarDatos("SP_SELECT_EMAIL_CLIENTE_NC   '" & VCdTipoDoc & "','" & VNroDoc & "'")
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

                    Dim FormatNroDoc As String
                    FormatNroDoc = Format(VNroDoc, "0##-########")


                    NUMSERIE = TextBox1.Text.Trim
                    SERIE = LETRADOC + NUMSERIE
                    NRODOCSIN = CStr(Microsoft.VisualBasic.Right(VNroDoc, 8))
                    NRODOCFINAL = SERIE + "-" + NRODOCSIN



                    'FormatNroDoc2 = Format(VNroDoc, "0##-########")

                    NUMSERIE2 = txtnrorefe.Text.Trim
                    SERIE2 = LETRADOC + NUMSERIE2
                    NRODOCSIN2 = CStr(Microsoft.VisualBasic.Right(txtnumero.Text, 8))
                    NRODOCFINAL2 = SERIE2 + "-" + NRODOCSIN2


                    Dim dblTOTINAFECTO As Double
                    Dim TABLA_INAFECTO As New DataTable
                    TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO_NC  '" & TipoDoc & "','" & VNroDoc & "'  ")

                    If TABLA_INAFECTO.Rows.Count > 0 Then
                        dblTOTINAFECTO = CDbl(FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString)
                    End If


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
                    nuevohdocumento.codi_moti = cmbTipoNotaCred.SelectedValue
                    nuevohdocumento.motivo = cmbTipoNotaCred.Text.ToString
                    nuevohdocumento.doc_refe = NRODOCFINAL2
                    nuevohdocumento.ValorResumen = 0.0
                    nuevohdocumento.ValorHash = ""
                    nuevohdocumento.DarBaja = 0
                    nuevohdocumento.MotivoBaja = ""
                    nuevohdocumento.ProcesarBaja = 0
                    nuevohdocumento.Grabado = SUBTOTAL - dblTOTINAFECTO
                    nuevohdocumento.IGV = IGV
                    nuevohdocumento.Total = lbltotal.Text
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

                    Dim StrSql As String
                    StrSql = "SELECT TMP_NTACREDDET.ITEM,TMP_NTACREDDET.CDARTI, TMP_NTACREDDET.DSARTI, TMP_NTACREDDET.PRECIO, " &
                             "  TMP_NTACREDDET.CANTIDAD,  TMP_NTACREDDET.SUBTOTBAS,  '01' AS TIPOPRE," &
                                   " TMP_NTACREDDET.TOTBAS, TMP_NTACREDDET.IGVBAS,(TMP_NTACREDDET.SUBTOTBAS/TMP_NTACREDDET.CANTIDAD) AS PRECSINIGV," &
                                   "  TMP_NTACREDDET.MONTODESCBAS ,TMP_NTACREDDET.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC  " &
                             " FROM ARTICULO INNER JOIN TMP_NTACREDDET ON ARTICULO.CODARTI = TMP_NTACREDDET.CDARTI" &
                              " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                          " INNER JOIN PRESENTACION ON PRESENTACION.codpres = TMP_NTACREDDET.CODPRES" &
                        "  WHERE TMP_NTACREDDET.CORRNBR = " & CInt(ADblCORRELATIVO) & "  AND CANTIDAD_DEV > 0  ORDER BY TMP_NTACREDDET.ITEM  "

                    Dim Tabla_Tmp As DataTable
                    Tabla_Tmp = TmpListarDatos(StrSql)

                    If Tabla_Tmp.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp.Rows.Count - 1
                            Dim nuevoddocumento As New NuevaDDocumento
                            nuevoddocumento.id = 1
                            nuevoddocumento.prod_codi = Tabla_Tmp.Rows(x)("CDARTI")
                            nuevoddocumento.prod_descr = Tabla_Tmp.Rows(x)("DSARTI")
                            nuevoddocumento.prod_unid = Tabla_Tmp.Rows(x)("CODFACELEC")
                            nuevoddocumento.prod_precio = Tabla_Tmp.Rows(x)("PRECIO")
                            nuevoddocumento.prod_desct = Tabla_Tmp.Rows(x)("MONTODESCBAS")
                            nuevoddocumento.prod_cant = Tabla_Tmp.Rows(x)("CANTIDAD")
                            nuevoddocumento.igv = Tabla_Tmp.Rows(x)("IGVBAS")
                            nuevoddocumento.percepcion = PERCEP
                            nuevoddocumento.codi_cab = CODCAB
                            nuevoddocumento.tipo_igv = IIf(CDbl(Tabla_Tmp.Rows(x)("IGVBAS")) <> 0, "IGV", "INA")
                            nuevoddocumento.obse = "AAAAA"
                            gestordefacturacionelectronica.CrearDdocumento(nuevoddocumento)
                        Next
                    End If

                    gestordefacturacionelectronica.ModificarEstado(SERIE, NRODOCSIN)


                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''' VERIFICO SI SE ENVIO A SUNAT O CORRECTAMENTE '''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                End If
            End If




            ' AObjBus.Ejecutar("sp_modificar_num_credito", codempresa, CStr(NROPTOVTA))

            If AIntResp <> 0 Then
                If MessageBox.Show("¿ Desea Imprimir el Documento ?", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'insert_store("SP_REGISTRA_AUDITORIA '" & txtnronotcred.Text & "','INSERT','NOTACREDITO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & Variables.usuario & "','" & codempresa & "'")
                    AObjBus.Ejecutar("SP_REGISTRA_AUDITORIA", txtnronotcred.Text.Trim, "INSERT", "NOTACREDITO", Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt"), CodUsuario, codempresa)
                    GeneraReporte(txtnronotcred.Text)
                End If
                MessageBox.Show("Registro Grabado", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarFormularios(Me)
                ATblDetNot.Clear()
                lbligv.Text = "0.00"
                lblsubtotal.Text = "0.00"
                lbltotal.Text = "0.00"
                txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString.Trim, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
                BTNGUARDAR.Enabled = False
                BTNMODIFICAR.Enabled = True
                BTNELIMINAR.Enabled = True
                BTNNUEVO.Enabled = True
                txtnombre.Enabled = False
                txtnumero.Enabled = False
                txtnrorefe.Enabled = False
                btnreferncia.Enabled = False
                txtnronotcred.ReadOnly = True
                cmbreferncia.Enabled = False
                btnnotcred.Enabled = True
                dtgnotcred.Enabled = False
                txtcodcli.Enabled = False
                Button1.Enabled = False
                txtpto.Text = NROPTOVTA.ToString.Trim
                txtcambio.Text = VCambioVta
                txtpto.Enabled = False
                cmboperador.Enabled = False
                Me.ListView1.Items.Clear()
            Else
                MsgBox("Error Durante Esta Operacion", MsgBoxStyle.Critical, "Aviso")
            End If
        Catch
            MessageBox.Show("Falta Ingresar Algunos Datos Verifique", "informacion", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Exit Sub
        End Try

    End Sub



    Private Function GRABAEFECTIVOS(ByVal CODTIPOPAGO As String, ByVal fechadocum As Date) As Boolean

        Dim AFEC As Integer


        Try
            'TmpInsertDatos("sp_grabadocumento  '" & CStr(VIE.txtnroguias.Text) & "','" & CStr(VIE.txtnotapesada.Text) & "','" & CStr(VIE.CHKIGV.Checked) & "','" & CStr(fact_editnumero) & "','" & CInt(FACT_NUMEROTRANSACCION) & "','" & CStr(FACT_clieprincipal) & "','" & CODTIPOPAGO.Trim & "','" & CStr(VCdTipoDoc) & "','" & CStr(VNroDoc) & "','" & CStr(FACT_CDMONEDA) & "','" & CDec(LBLcambio.Text) & "','" & CStr(FACT_codvendedor) & "','" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "','" & CDec(IIf(CDMONBASE = FACT_CDMONEDA, VIE.CTRLTOTAL.CtlText, VIE.CTRLTOTAL.CtlText * LBLcambio.Text)) & "','" & CDec(FACT_pordescuento) & "','" & CDec(IIf(CDMONBASE = FACT_CDMONEDA, ctrlvuelto.CtlText, ctrlvuelto.CtlText * LBLcambio.Text)) & "','" & CDec(ctrlefectivobas.CtlText) & "' ,'" & CDec(ctrlefectivoextr.CtlText) & "','" & CStr(FACT_codcliente) & "','" & CStr(FACT_RUCCLIENTE) & "','" & CStr(FACT_DESCLIENTE) & "','" & CStr(FACT_DIRCLIENTE) & "','" & CStr(CodUsuario) & "','" & CStr(CodEmpresa) & "' ,'" & CStr(FACT_CDMONEDA) & "','" & CStr(NROPTOVTA) & "','" & CInt(VCorrelVta) & "' ")


            Dim cn2 As New SqlConnection(STRCN)
            If cn2.State = ConnectionState.Open Then
                cn2.Close()
            End If
            cn2.Open()
            Dim cmd2 As New SqlCommand("Nsp_grabadocumento", cn2)
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
            cmd2.Parameters.AddWithValue("@CAMBIO", CDec(txtcambio.Text)).SqlDbType = SqlDbType.Decimal
            cmd2.Parameters.AddWithValue("@codvend", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
            cmd2.Parameters.AddWithValue("@FECDOCUM", fechadocum).SqlDbType = SqlDbType.DateTime
            cmd2.Parameters.AddWithValue("@TOTBAS", CDec(lbltotal.Text)).SqlDbType = SqlDbType.Decimal
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
            Try
                AFEC = cmd2.ExecuteNonQuery()
                MsgBox("- Se Guardo con exito.", MsgBoxStyle.Information, "NARSISTEMAS")
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





    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        LimpiarFormularios(Me)
        ADBlEstadoNotCred = "MODI"
        ATblDetNot.Clear()
        lbligv.Text = "0.00"
        lblsubtotal.Text = "0.00"
        lbltotal.Text = "0.00"
        txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString.Trim, codempresa).Tables(0).Rows(0)(0)
        BTNNUEVO.Enabled = True
        BTNMODIFICAR.Enabled = True
        BTNELIMINAR.Enabled = True
        BTNGUARDAR.Enabled = False
        btnnotcred.Enabled = False
        btnreferncia.Enabled = False
        cmbreferncia.Enabled = False
        txtnrorefe.Enabled = False
        txtdevolver.ReadOnly = False
        'TXTBULTO.ReadOnly = False
        txtnumero.Enabled = False
        txtnrorefe.Enabled = False
        ' txtnronotcred.ReadOnly = True
        ATblNotCredDet.Clear()
        ATblNotDine.Clear()
        grid2.Visible = False
        dtgnotcred.Visible = True
        txtcodcli.Enabled = False
        Button1.Enabled = False
        ADblCORRELATIVO = AObjBus.ListarDatos("ObtenerCorrelativoProcUtil", CodUsuario.ToString()).Tables(0).Rows(0)(0)
        ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET", ADblCORRELATIVO).Tables(0)
        dtgnotcred.DataSource = ATblDetNot
        rdbprodu.Enabled = True
        rdbdinero.Enabled = True
        btnnotcred.Enabled = True
        dtgnotcred.Enabled = False
        txtpto.Enabled = False
        cmboperador.Enabled = False
        Me.ListView1.Items.Clear()
        Me.TextBox1.ReadOnly = True
        Me.TextBox2.ReadOnly = True

    End Sub
    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        ADBlEstadoNotCred = "MODI"
        txtnronotcred.ReadOnly = False
        btnnotcred.Enabled = False
        btnreferncia.Enabled = True
        cmbreferncia.Enabled = True
        txtnrorefe.Enabled = True
        txtdevolver.ReadOnly = False
        txtnumero.Enabled = True
        txtnronotcred.Focus()
        dtpfecha.Enabled = True
        txtnronotcred.Focus()
        dtgnotcred.Enabled = True
        BTNMODIFICAR.Enabled = False
        BTNELIMINAR.Enabled = False
        BTNNUEVO.Enabled = False
        BTNGUARDAR.Enabled = True

    End Sub
    Private Sub btnnotcred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnotcred.Click


        txtnronotcred.Focus()
        Dim formu As New FrmBusNotaCredito
        formu.ShowDialog()

        Try
            activa = 2

            If AboolCargarValor Then
                ADblCORRELATIVO = formu.IDCODIGO

                ATblNotCred = AObjBus.ListarDatos("NSP_SELECT_LISTAVENTACABNOTCRED_varios", formu.IDCODIGO, codempresa.ToString(), formu.IDOCREF).Tables(0)
                tipodocref = ATblNotCred.Rows(0)("CDTIPODOCREF")
                cmbreferncia.SelectedValue = tipodocref
                nrodocref = ATblNotCred.Rows(0)("NRODOCU")

                txtnronotcred.Text = ATblNotCred.Rows(0)(0)

                Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
                Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)
                Me.ListView1.Items.Clear()
                'select nrontacred,tipo,cdcliente,descliente,ruccliente,dircliente,cambio,ptovta,fecdocum,cdvended,subtotbas,igvbas,subtotext
                If Trim(ATblNotCred.Rows(0)(1)) = "P" Then
                    Me.rdbprodu.Checked = True
                Else
                    Me.rdbdinero.Checked = True
                End If

                txtcodcli.Text = ATblNotCred.Rows(0)(2)
                txtnombre.Text = ATblNotCred.Rows(0)(3)
                txtruc.Text = ATblNotCred.Rows(0)(4)
                txtdireccion.Text = ATblNotCred.Rows(0)(5)
                txtcambio.Text = FormatoMonto(ATblNotCred.Rows(0)(6), DECIRESU)
                Me.txtpto.SelectedValue = ATblNotCred.Rows(0)(7)
                Me.dtpfecha.Value = ATblNotCred.Rows(0)(8)
                cmboperador.SelectedValue = ATblNotCred.Rows(0)(9)

                lblsubtotal.Text = FormatoMonto(ATblNotCred.Rows(0)(10), DECIRESU)
                lbligv.Text = FormatoMonto(ATblNotCred.Rows(0)(11), DECIRESU)
                lbltotal.Text = FormatoMonto(ATblNotCred.Rows(0)(12), DECIRESU)
                CDCLIENTEDEP = ATblNotCred.Rows(0)(13)

                ' txtdevolver.Text = FormatoMonto(ATblNotCred.Rows(0)("TOT"), DECIRESU)
                TxtObservServ.Text = ATblNotCred.Rows(0)("obsv")

                txtnrorefe.Text = Format(CDbl(Mid(ATblNotCred.Rows(0)("NRODOCU"), 1, Len(Trim(ATblNotCred.Rows(0)("NRODOCU"))) - 8)), "000")
                txtnumero.Text = Mid(ATblNotCred.Rows(0)("NRODOCU"), Len(Trim(ATblNotCred.Rows(0)("NRODOCU"))) + 1 - 8, 8)

                CbMoneda.SelectedValue = ATblNotCred.Rows(0)("CDMONEDA")


                If ATblNotCred.Rows(0)("CDMONEDA").ToString.Trim = "S" Then
                    Me.LBLSIMBOLO4.Text = FACT_SIMBOLOMON
                End If

                If ATblNotCred.Rows(0)("CDMONEDA").ToString.Trim = "D" Then
                    Me.LBLSIMBOLO4.Text = FACT_SIMBOLOMONEXTR

                End If

                'conecta1("nspselclie '" & CDCLIENTEDEP & "','" & Variables.CODEMP & "'", "clie")
                dt_data = New DataTable
                dt_data = CAyuda.ListarDatos("nspselclie", CDCLIENTEDEP, codempresa).Tables(0)

                If dt_data.Rows.Count > 0 Then
                    Me.TXTNOMPAGADOR.Text = dt_data.Rows(0)(0)
                End If

                rdbprodu.Enabled = False
                rdbdinero.Enabled = False

                BTNMODIFICAR.Enabled = True
                BTNELIMINAR.Enabled = True
                BTNGUARDAR.Enabled = False
                BTNNUEVO.Enabled = False


                'CAyuda.Ejecutar("NOTA_CRED_ATEMP  ", formu.IDCODIGO, codempresa)

                dt_data = New DataTable
                dt_data = CAyuda.ListarDatos("SP_NTCRED", formu.IDCODIGO, codempresa).Tables(0)


                ' conecta2("SELECT CODTIPODOC,NRODOCU FROM NTACREDET WHERE NRONTACRED=" & formu.IDCODIGO & " AND CODEMPRESA='" & Variables.CODEMP & "'", "DETALLE")
                If dt_data.Rows.Count > 0 Then
                    For O As Int32 = 0 To dt_data.Rows.Count - 1
                        Dim M As New ListViewItem
                        M.SubItems.Add(Trim(dt_data.Rows(O)(0)))
                        M.SubItems.Add(Trim(dt_data.Rows(O)(1)))
                        Me.ListView1.Items.Add(M)
                    Next
                End If

                Me.ListView1.Items(Me.ListView1.Items.Count - 1).Selected = True
                Me.ListView1.Items(Me.ListView1.Items.Count - 1).Focused = True
                ListView1_SelectedIndexChanged(sender, e)

                dtgnotcred.Enabled = True
                grid2.Enabled = True
                Me.GroupBox1.Enabled = True

                txtdevolver.Enabled = False
                ' TXTBULTO.Enabled = False
                If rdbprodu.Checked = True Then
                    ATblNotCredDet = AObjBus.ListarDatos("NSP_SELECT_LISTADONOTCREDDET", formu.IDCODIGO, codempresa.ToString(), nrodocref, tipodocref).Tables(0)
                    dtgnotcred.DataSource = ATblNotCredDet
                    dtgnotcred.Refresh()
                    grid2.Visible = False
                    dtgnotcred.Visible = True


                    If ATblNotCred.Rows(0)("ESTADO") = "A" Then
                        BTNELIMINAR.Enabled = False
                        MessageBox.Show("¡ DOCUMENTO ANULADO................ !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If ATblNotCred.Rows(0)("ESTADO") = "G" Then
                            BTNELIMINAR.Enabled = False
                            MessageBox.Show("¡ DOCUMENTO GENERADO........ !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            'If AObjBus.ListarDatos("NSP_SELECT_BUSCA_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 1).Tables(0).Rows.Count = 0 Then
                            '    BTNELIMINAR.Enabled = False
                            '    MessageBox.Show("¡ DOCUMENTO GENERADO CANCELADO EN CUENTAS POR COBRAR !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            'Else
                            BTNELIMINAR.Enabled = True
                            'End If

                        End If
                    End If
                    FormatGrid1()
                Else
                    ATblNotDine = AObjBus.ListarDatos("NSP_SELECT_LISTADONOTCREDDETDINE", formu.IDCODIGO, codempresa.ToString()).Tables(0)
                    grid2.DataSource = ATblNotDine
                    grid2.Refresh()
                    grid2.Visible = True
                    dtgnotcred.Visible = False
                    If ATblNotCred.Rows(0)("ESTADO") = "A" Then
                        BTNELIMINAR.Enabled = False
                        MessageBox.Show("¡ DOCUMENTO ANULADO................ !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If ATblNotCred.Rows(0)("ESTADO") = "G" Then
                            BTNELIMINAR.Enabled = False
                            MessageBox.Show("¡ DOCUMENTO GENERADO........ !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            If AObjBus.ListarDatos("NSP_SELECT_BUSCA_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 1).Tables(0).Rows.Count = 0 Then
                                BTNELIMINAR.Enabled = False
                                MessageBox.Show("¡ DOCUMENTO GENERADO CANCELADO EN CUENTAS POR COBRAR !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Else
                                BTNELIMINAR.Enabled = True
                            End If
                        End If
                    End If
                End If


            End If

        Catch
        End Try
        AboolCargarValor = False
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    Sub FormatGrid1()
        Dim grdTableStyle2 As New DataGridTableStyle
        With grdTableStyle2
            .MappingName = ATblNotCredDet.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Item"
            .MappingName = "Item_"
            .Width = 80
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Código"
            .MappingName = "CDARTI"
            .Width = 100
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "Descripción"
            .MappingName = "DSARTI"
            .Width = 450
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "U_Med"
            .MappingName = "coduMED"
            .Width = 100
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "Cantidad"
            .MappingName = "Cantidad_"
            .Width = 100
            .Format = GMascaraDec(2)
            .Alignment = HorizontalAlignment.Right
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "Precio"
            .MappingName = "Precio_"
            .Width = 100
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(2)
        End With
        Dim grdColStyle9 As New DataGridTextBoxColumn
        With grdColStyle9
            .HeaderText = "Total"
            .MappingName = "TOTBAS"
            .Width = 70
            .Format = GMascaraDec(2)
            .Alignment = HorizontalAlignment.Right
        End With
        grdTableStyle2.GridColumnStyles.AddRange _
                  (New DataGridColumnStyle() _
                  {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5, grdColStyle7, grdColStyle9})
        dtgnotcred.TableStyles.Add(grdTableStyle2)
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
    Private Sub txtnronotcred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnronotcred.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Try
                If ADBlEstadoNotCred = "MODI" Then
                    ATblNotCred = AObjBus.ListarDatos("NSP_SELECT_LISTANTACRED", CDbl(txtnronotcred.Text), codempresa.ToString()).Tables(0)
                    If ATblNotCred.Rows.Count > 0 Then
                        txtnronotcred.Text = ATblNotCred.Rows(0)(0)
                        cmbreferncia.SelectedValue = ATblNotCred.Rows(0)(1)
                        txtnrorefe.Text = Format(CDbl(Mid(ATblNotCred.Rows(0)(2), 1, Len(Trim(ATblNotCred.Rows(0)(2))) - 7)), "000")
                        txtnumero.Text = Mid(ATblNotCred.Rows(0)(2), Len(Trim(ATblNotCred.Rows(0)(2))) + 1 - 7, 7)
                        txtcodcli.Text = ATblNotCred.Rows(0)(17)
                        txtruc.Text = ATblNotCred.Rows(0)(18)
                        txtnombre.Text = ATblNotCred.Rows(0)(19)
                        txtdireccion.Text = ATblNotCred.Rows(0)(20)
                        cmboperador.SelectedValue = ATblNotCred.Rows(0)(6)
                        ' dtpfecha.Value = ATblNotCred.Rows(0)(8)
                        txtcambio.Text = GMascaraDec_D(ATblNotCred.Rows(0)(4))
                        lblsubtotal.Text = GMascaraDec_D(ATblNotCred.Rows(0)(13))
                        lbligv.Text = GMascaraDec_D(ATblNotCred.Rows(0)(15))
                        lbltotal.Text = GMascaraDec_D(ATblNotCred.Rows(0)(11))
                        ATblNotCredDet = AObjBus.ListarDatos("NSP_SELECT_LISTADONOTCREDDET", CDbl(txtnronotcred.Text), codempresa.ToString()).Tables(0)
                        dtgnotcred.DataSource = ATblNotCredDet
                        dtgnotcred.Refresh()
                        FormatGrid1()
                    Else
                        LimpiarFormularios(Me)
                        ATblDetNot.Clear()
                        lbligv.Text = "0.00"
                        lblsubtotal.Text = "0.00"
                        lbltotal.Text = "0.00"
                        ATblNotCredDet.Clear()
                        txtnronotcred.Focus()
                    End If
                ElseIf ADBlEstadoNotCred = "NUE" Then
                    If AObjBus.ListarDatos("NSP_SELECT_BUSCADOCNOTCRED1", Trim(txtnronotcred.Text), codempresa.ToString()).Tables(0).Rows.Count > 0 Then
                        MessageBox.Show("El Numero de Nota de Credito ya Existe Verifique o Ingrese otro Numero", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question)
                        txtnronotcred.Focus()
                        Exit Sub
                    End If
                    rdbprodu.Focus()
                End If
            Catch

            End Try
        End If
    End Sub
    Private Sub txtnrorefe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnrorefe.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then

            txtnumero.Focus()
        End If
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        GeneraReporte(txtnronotcred.Text)
    End Sub

    Sub GeneraReporte(ByVal ADblNtaCred As Double)
        Dim StrMonLet As String
        Try
            If rdbdinero.Checked = True Then
                crRpt.ReportFileName = rutareporte & "RptNtaCredServC.rpt"
            Else
                crRpt.ReportFileName = rutareporte & "Rpt_NotaCreditoClienteArt.rpt"
            End If
            If CbMoneda.SelectedValue.ToString.Trim = "S" Then
                StrMonLet = FACT_TotalLetras(CDbl(lbltotal.Text), "SOLES")
            Else
                StrMonLet = FACT_TotalLetras(CDbl(lbltotal.Text), "DOLARES")
            End If

            crRpt.WindowShowExportBtn = True
            crRpt.WindowShowPrintBtn = True
            crRpt.WindowShowPrintSetupBtn = True
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, "07")
            crRpt.set_StoredProcParam(2, txtnronotcred.Text)
            crRpt.set_StoredProcParam(3, CStr(dtpfecha.Value))

            crRpt.set_Formulas(0, "formTotLetras=stringvar strmonlet; strmonlet:='" & StrMonLet.Trim & "'")


            If EMIELECTRONIC = True Then

                If cmbreferncia.SelectedValue = "01" Then
                    LETRADOC = "F"
                End If
                If cmbreferncia.SelectedValue = "03" Then
                    LETRADOC = "B"
                End If
                If cmbreferncia.SelectedValue = "06" Then
                    LETRADOC = "P"
                End If


                crRpt.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & LETRADOC & TextBox1.Text & "-" & TextBox2.Text & "'")
            Else
                crRpt.set_Formulas(1, "formnundoc=stringvar strnumdoc; strnumdoc:='" & "NC " & Format(CDbl(txtnronotcred.Text), "0##-#######") & "'")
            End If


            ''crRpt.ReportFileName = rutareporte + CType("Rpt_Factura.rpt", String)
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow

            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch
            MessageBox.Show("Configure Una Impresora !!!", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Public Function meTotalLetras(ByVal nume As Double, ByVal TMONEDA As String) As String
        '------------------------------------
        '  nume    : Cifra (incluye decimales)
        '  TMONEDA : Texto que debe indicar la moneda ("SOLES","Dolares")
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
                u = IIf(s = "2", "DOS", IIf(s = "3", "TRES", IIf(s = "4", "CUATRO",
                    IIf(s = "5", "CINCO", IIf(s = "6", "SEIS", IIf(s = "7", "SIETE",
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

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        'If ATblNotCredDet.Rows.Count <> 0 Then
        '    If MessageBox.Show("¿Deseas Aular El Domuneto ?", "Información", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '        AObjBus.gGrabarReg("NSP_upd_NTACREDCAB", txtnronotcred.Text, codempresa)
        '        AObjBus.gGrabarReg("NSP_DEL_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 1)
        '        BTNCANCELAR_Click(sender, e)
        '        Exit Sub
        '    End If
        'End If
        'If ATblNotDine.Rows.Count <> 0 Then


        Dim Proceso As String
        Proceso = "ANULNTACREDCONTABL"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If


        If txtnronotcred.Text.Trim.Length = 0 Then
            Exit Sub
        End If



        If MessageBox.Show("¿Deseas Aular El Domuneto ?", "Información", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            AObjBus.Ejecutar("NSP_upd_NTACREDCAB", txtnronotcred.Text, codempresa, nrodocref, cmbreferncia.SelectedValue.Trim)
            AObjBus.Ejecutar("NSP_DEL_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 1, nrodocref)
            AObjBus.Ejecutar("SP_REGISTRA_AUDITORIA", txtnronotcred.Text, "ANULAR", "NOTACRED", Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt"), CodUsuario, codempresa)



            If EMIELECTRONIC = True Then
                Dim LETRADOC As String = ""

                If cmbreferncia.SelectedValue.Trim = "01" Then
                    LETRADOC = "F"
                End If
                If cmbreferncia.SelectedValue.Trim = "03" Then
                    LETRADOC = "B"
                End If
                If cmbreferncia.SelectedValue.Trim = "06" Then
                    LETRADOC = "F"
                End If

                Dim SERIE2 As String
                Dim FormatNroDoc As String
                FormatNroDoc = Format(CDbl(txtnronotcred.Text), "0##-########")
                Dim NUMSERIE As String
                NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                SERIE2 = LETRADOC + NUMSERIE

                Dim NRODOCSIN As String
                NRODOCSIN = CStr(Microsoft.VisualBasic.Right(txtnronotcred.Text, 8))
                Dim NRODOCFINAL As String
                NRODOCFINAL = SERIE2 + "-" + NRODOCSIN

                Dim gestordefacturacionelectronica As IGestorDeFacturacionElectronica = New GestorDeFacturacionElectronica()
                gestordefacturacionelectronica.AnularFE(SERIE2, NRODOCSIN, "07")

            End If











            MsgBox("El documento ha sido anulado", MsgBoxStyle.Information)

            BTNCANCELAR_Click(sender, e)
            'Exit Sub
        End If


        'End If
    End Sub

    Private Sub cmbreferncia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreferncia.SelectedIndexChanged

        Dim AStrCod As String
        ATblCodCorr.Clear()
        ATblCodCorr = AObjBus.ListarDatos("NSP_SELECT_CORRELATIVOS", NROPTOVTA.ToString.Trim, codempresa).Tables(0)
        AStrCod = cmbreferncia.SelectedValue.ToString

        If AStrCod = Trim(CDFACTURA) Then
            txtnrorefe.Text = Format(CDbl(Mid(Trim(ATblCodCorr.Rows(0)("NROTICKFAC")), 1, Len(Trim(ATblCodCorr.Rows(0)("NROTICKFAC"))) - 8)), "000")
            txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
            Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
            Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)


        End If
        If AStrCod = Trim(CDBOLETA) Then
            txtnrorefe.Text = Format(CDbl(Mid(Trim(ATblCodCorr.Rows(0)("NROTICKBOL")), 1, Len(Trim(ATblCodCorr.Rows(0)("NROTICKBOL"))) - 8)), "000")
            txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
            Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
            Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)


        End If

        If AStrCod = Trim(CDNTACREDP) Then
            txtnrorefe.Text = Format(CDbl(Mid(Trim(ATblCodCorr.Rows(0)("NROTICKET")), 1, Len(Trim(ATblCodCorr.Rows(0)("NROTICKET"))) - 8)), "000")
        End If


    End Sub


    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))

        Dim ADblNumero As Double
        Try

            ABoolHistorico = False
            If Keyascii = 13 Then
                If txtnumero.Text.Trim.Length <> 8 Then
                    txtnumero.Text = Strings.Right("00000000" + CType(txtnumero.Text, String), 8)
                End If

                ADblNumero = CDbl(txtnrorefe.Text.Trim & txtnumero.Text.Trim)
                IDCODIGO = ADblNumero
                Dim i As Short
                Dim numeror As String
                Dim cargar As Integer

                For i = 0 To Me.ListView1.Items.Count - 1
                    numeror = Me.ListView1.Items(0).SubItems(2).Text
                    If IDCODIGO = numeror Then
                        cargar = 1
                    End If
                Next


                If cargar = 0 Then

                    CAyuda.Ejecutar("NSP_SELECT_LISTADOCUMENTOSNOTACRED_J", Me.cmbreferncia.SelectedValue.ToString, Val(Strings.Left(Me.txtnrorefe.Text.Trim, 3) + Strings.Right(Me.txtnumero.Text.Trim, 8)))

                    Conecta("SELECT * FROM TMPVENTANTACREDCONS", "LLENA")
                    If ds.Tables("LLENA").Rows.Count > 0 Then

                        IDCODIGO = GValidarNulos(ds.Tables("llena").Rows(0)(0))
                        Tabla = GValidarNulos(ds.Tables("llena").Rows(0)(1))
                        AboolCargarValor = True
                        LLENA()
                    Else
                        MessageBox.Show("No existe el documento ingresado. Verifique!!", "Informaciòn", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtnrorefe.Focus()
                        Me.txtnrorefe.SelectAll()
                        Exit Sub
                    End If
                End If
                cargar = 0
            End If
        Catch
        End Try

    End Sub
    Sub FormatGrid2()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = ATblNotDine.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Item"
            .MappingName = "Item_"
            .Width = 30
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Código"
            .MappingName = "CDARTI"
            .Width = 80
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "Descripción"
            .MappingName = "DSARTI"
            .Width = 350
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "Cantidad"
            .MappingName = "Cantidad"
            .Width = 150
            .Format = GMascaraDec(2)
            .Alignment = HorizontalAlignment.Right
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "Total"
            .MappingName = "TOTBAS"
            .Width = 150
            .Format = GMascaraDec(2)
            .Alignment = HorizontalAlignment.Right
        End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        ''grdTableStyle1.GridColumnStyles.AddRange() _
        ''    (New DataGridColumnStyle() _
        ''    {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle5})
        ''grid2.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub rdbprodu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbprodu.CheckedChanged
        Label10.Text = "Cantidad A Devolver :"
        'TXTBULTO.Enabled = True
        'TXTBULTO.Visible = True
        'Label17.Visible = True
    End Sub

    Private Sub rdbdinero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbdinero.CheckedChanged
        Label10.Text = "Dinero A Devolver :"
        'TXTBULTO.Enabled = False
        'TXTBULTO.Visible = False
        'Label17.Visible = False
    End Sub


    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        activa = 0

        ADBlEstadoNotCred = "NUE"
        LimpiarFormularios(Me)
        ATblDetNot.Clear()
        lbligv.Text = "0.00"
        lblsubtotal.Text = "0.00"
        lbltotal.Text = "0.00"
        txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString, codempresa, cmbreferncia.SelectedValue).Tables(0).Rows(0)(0)
        Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
        Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)

        Dim dt As New DataTable
        Dim i As Integer
        While (i = 0)
            If AObjBus.ListarDatos("NSP_SELECT_BUSCADOCNOTCRED1", Trim(txtnronotcred.Text), codempresa.ToString(), cmbreferncia.SelectedValue).Tables(0).Rows.Count > 0 Then
                AObjBus.Ejecutar("sp_modificar_num_credito", codempresa.ToString(), Me.txtpto.SelectedValue.ToString)
                txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString.Trim).Tables(0).Rows(0)(0)
                Me.TextBox2.Text = Strings.Right("0000000" + CType(txtnronotcred.Text, String), 8)
                Me.TextBox1.Text = Strings.Right("000" + Strings.Left(CType(txtnronotcred.Text, String), Len(CType(txtnronotcred.Text, String)) - 8), 3)

            Else
                i = 1
            End If
        End While

        btnnotcred.Enabled = False
        BTNMODIFICAR.Enabled = False
        BTNELIMINAR.Enabled = False
        BTNGUARDAR.Enabled = True
        txtpto.Text = NROPTOVTA.ToString.Trim
        txtcambio.Text = VCambioVta
        rdbprodu.Enabled = True
        rdbdinero.Enabled = True
        txtnombre.Enabled = True
        txtnumero.Enabled = True
        btnreferncia.Enabled = True
        BTNNUEVO.Enabled = False
        dtgnotcred.Enabled = True
        txtnrorefe.Enabled = True
        dtpfecha.Enabled = True
        txtcodcli.Enabled = True
        Button1.Enabled = True
        cmbreferncia.Enabled = True
        txtnronotcred.ReadOnly = False
        txtdevolver.Enabled = True
        'TXTBULTO.Enabled = True

        ADblCORRELATIVO = AObjBus.ListarDatos("ObtenerCorrelativoProcUtil", CodUsuario).Tables(0).Rows(0)(0)

    End Sub

    Private Sub rdbdinero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdbdinero.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cmbreferncia.Focus()
        End If

    End Sub

    Private Sub rdbprodu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdbprodu.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cmbreferncia.Focus()
        End If
    End Sub

    Private Sub cmbreferncia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbreferncia.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtnrorefe.Focus()
        End If
    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            If rdbprodu.Checked = True Then
                ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET_varios", ADblCORRELATIVO, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim, codempresa).Tables(0)
            Else
                ATblDetNot = AObjBus.ListarDatos("NSP_SEL_LISTATMPNTACREDDET_varios", ADblCORRELATIVO, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim, codempresa).Tables(0)
            End If

            dtgnotcred.DataSource = ATblDetNot
            AMonBasdoc = ATblCli.Rows(0)("CODMON")
            txtpto.Text = NROPTOVTA
            txtcambio.Text = VCambioVta
            rdbprodu.Enabled = False
            rdbdinero.Enabled = False

        Catch x As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtcodcli.Focus()
        Dim FRMX As New frm_gridclie1
        FRMX.vie2 = Me
        FRMX.bol = 3
        FRMX.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If MessageBox.Show("¿Desea anular el registro seleccionado?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'CAYUDA.("delete from TMP_NTACREDDET where corrnbr=" & ADblCORRELATIVO & " and codtipodoc='" & Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim & "' and nrodocu='" & Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim & "'")
                CAyuda.Ejecutar("SP_DEL_NTCRED", ADblCORRELATIVO, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(1).Text.Trim, Me.ListView1.Items(Me.ListView1.FocusedItem.Index).SubItems(2).Text.Trim)

                btnActualizar_Click(sender, e)
                Me.ListView1.Items.RemoveAt(Me.ListView1.FocusedItem.Index)
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtnrorefe_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnrorefe.LostFocus
        txtnrorefe.Text = Strings.Right("000" + CType(txtnrorefe.Text, String), 3)
    End Sub

    Private Sub txtnumero_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumero.LostFocus
        txtnumero.Text = Strings.Right("0000000" + CType(txtnumero.Text, String), 7)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtnronotcred.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        If MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Informaciòn", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            CAyuda.Ejecutar("nsp_del_notacred", codempresa, txtnronotcred.Text.Trim)
            MessageBox.Show("Registro eliminado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CAyuda.Ejecutar("SP_REGISTRA_AUDITORIA", txtnronotcred.Text, "DELETE", "NOTACRED", Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt"), CodUsuario, codempresa)
            LimpiarFormularios(Me)
            ATblDetNot.Clear()
            lbligv.Text = "0.00"
            lblsubtotal.Text = "0.00"
            lbltotal.Text = "0.00"
            BTNCANCELAR_Click(sender, e)
            Me.ListView1.Items.Clear()
            Me.dtgnotcred.Refresh()
            Me.grid2.Refresh()
        End If
    End Sub

    Private Sub txtnumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumero.TextChanged

    End Sub

    Private Sub btnconsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsulta.Click
        If txtnronotcred.Text.Trim.Length = 0 Then
            MsgBox("- Seleccione un Documento.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        GeneraReporte(txtnronotcred.Text)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If activa = 1 Then
            Me.txtnronotcred.Text = CInt(Me.TextBox1.Text) & Microsoft.VisualBasic.Right("000000000000000000" & Me.TextBox2.Text, 7)

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If activa <> 2 Then
            Me.TextBox1.ReadOnly = False
            Me.TextBox2.ReadOnly = False
            Me.TextBox1.Enabled = True
            Me.TextBox2.Enabled = True
            activa = 1
        End If

    End Sub

    Private Sub txtdevolver_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdevolver.KeyUp

    End Sub

    Private Sub grid2_Navigate(sender As Object, ne As NavigateEventArgs) Handles grid2.Navigate

    End Sub

    Private Sub txtdevolver_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdevolver.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbMoneda.SelectedIndexChanged

        'If Not CbMoneda.SelectedValue Is Nothing Then
        '    If CbMoneda.SelectedValue = CDMONBASE Then
        '        Me.LBLSIMBOLO4.Text = FACT_SIMBOLOMON
        '    Else
        '        Me.LBLSIMBOLO4.Text = FACT_SIMBOLOMONEXTR
        '    End If
        'End If


    End Sub
End Class
