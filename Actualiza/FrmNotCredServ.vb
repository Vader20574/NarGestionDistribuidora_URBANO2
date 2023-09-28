Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmNotCredServ
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
    Friend WithEvents txtcambio As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmboperador As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents btnnotcred As System.Windows.Forms.Button
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents cmbreferncia As System.Windows.Forms.ComboBox
    Friend WithEvents txtnronotcred As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnrorefe As System.Windows.Forms.TextBox
    Friend WithEvents btnreferncia As System.Windows.Forms.Button
    Friend WithEvents txtobs As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtreferncia As System.Windows.Forms.TextBox
    Friend WithEvents cmbmoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtreferncia1 As System.Windows.Forms.TextBox
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpuntovta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTCODPAGADOR As System.Windows.Forms.TextBox
    Friend WithEvents BTNREFERENCIA As System.Windows.Forms.Button
    Friend WithEvents TXTNOMPAGADOR As System.Windows.Forms.TextBox
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmNotCredServ))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtcambio = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.cmboperador = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.btnnotcred = New System.Windows.Forms.Button
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.cmbreferncia = New System.Windows.Forms.ComboBox
        Me.txtnronotcred = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnrorefe = New System.Windows.Forms.TextBox
        Me.btnreferncia = New System.Windows.Forms.Button
        Me.txtobs = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtigv = New System.Windows.Forms.TextBox
        Me.txtsubtotal = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnEditar = New System.Windows.Forms.Button
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtreferncia = New System.Windows.Forms.TextBox
        Me.cmbmoneda = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtreferncia1 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.txtpuntovta = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TXTCODPAGADOR = New System.Windows.Forms.TextBox
        Me.BTNREFERENCIA = New System.Windows.Forms.Button
        Me.TXTNOMPAGADOR = New System.Windows.Forms.TextBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtcambio
        '
        Me.txtcambio.Enabled = False
        Me.txtcambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcambio.Location = New System.Drawing.Point(600, 48)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.ReadOnly = True
        Me.txtcambio.Size = New System.Drawing.Size(80, 21)
        Me.txtcambio.TabIndex = 12
        Me.txtcambio.Text = "TextBox7"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(520, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 17)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Tipo Cambio :"
        '
        'dtpfecha
        '
        Me.dtpfecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfecha.Location = New System.Drawing.Point(360, 24)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(128, 21)
        Me.dtpfecha.TabIndex = 4
        '
        'cmboperador
        '
        Me.cmboperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboperador.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboperador.Location = New System.Drawing.Point(360, 48)
        Me.cmboperador.Name = "cmboperador"
        Me.cmboperador.Size = New System.Drawing.Size(129, 21)
        Me.cmboperador.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(296, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Operador"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fecha Doc."
        '
        'txtruc
        '
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruc.Location = New System.Drawing.Point(120, 40)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.ReadOnly = True
        Me.txtruc.Size = New System.Drawing.Size(128, 21)
        Me.txtruc.TabIndex = 4
        Me.txtruc.Text = "TEXTBOX6"
        '
        'btnnotcred
        '
        Me.btnnotcred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnotcred.ImageIndex = 5
        Me.btnnotcred.ImageList = Me.ImageList1
        Me.btnnotcred.Location = New System.Drawing.Point(224, 24)
        Me.btnnotcred.Name = "btnnotcred"
        Me.btnnotcred.Size = New System.Drawing.Size(40, 23)
        Me.btnnotcred.TabIndex = 2
        '
        'txtdireccion
        '
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(120, 88)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(288, 21)
        Me.txtdireccion.TabIndex = 8
        Me.txtdireccion.Text = "TEXTBOX4"
        '
        'cmbreferncia
        '
        Me.cmbreferncia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreferncia.Location = New System.Drawing.Point(128, 48)
        Me.cmbreferncia.Name = "cmbreferncia"
        Me.cmbreferncia.Size = New System.Drawing.Size(137, 21)
        Me.cmbreferncia.TabIndex = 8
        '
        'txtnronotcred
        '
        Me.txtnronotcred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnronotcred.Location = New System.Drawing.Point(128, 24)
        Me.txtnronotcred.Name = "txtnronotcred"
        Me.txtnronotcred.Size = New System.Drawing.Size(95, 21)
        Me.txtnronotcred.TabIndex = 1
        Me.txtnronotcred.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cód. Pagador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tipo Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota de Credito Nro."
        '
        'txtnrorefe
        '
        Me.txtnrorefe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnrorefe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnrorefe.Location = New System.Drawing.Point(120, 16)
        Me.txtnrorefe.Name = "txtnrorefe"
        Me.txtnrorefe.Size = New System.Drawing.Size(96, 21)
        Me.txtnrorefe.TabIndex = 1
        Me.txtnrorefe.Text = "TEXTBOX5"
        '
        'btnreferncia
        '
        Me.btnreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreferncia.ImageIndex = 5
        Me.btnreferncia.ImageList = Me.ImageList1
        Me.btnreferncia.Location = New System.Drawing.Point(216, 16)
        Me.btnreferncia.Name = "btnreferncia"
        Me.btnreferncia.Size = New System.Drawing.Size(40, 23)
        Me.btnreferncia.TabIndex = 2
        '
        'txtobs
        '
        Me.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtobs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobs.Location = New System.Drawing.Point(16, 240)
        Me.txtobs.Multiline = True
        Me.txtobs.Name = "txtobs"
        Me.txtobs.Size = New System.Drawing.Size(640, 184)
        Me.txtobs.TabIndex = 21
        Me.txtobs.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txttotal)
        Me.GroupBox3.Controls.Add(Me.txtigv)
        Me.GroupBox3.Controls.Add(Me.txtsubtotal)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 432)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 48)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(528, 16)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(96, 21)
        Me.txttotal.TabIndex = 3
        Me.txttotal.Text = "0.00"
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtigv
        '
        Me.txtigv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigv.Location = New System.Drawing.Point(304, 16)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(96, 21)
        Me.txtigv.TabIndex = 2
        Me.txtigv.Text = "0.00"
        Me.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubtotal.Location = New System.Drawing.Point(96, 16)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(96, 21)
        Me.txtsubtotal.TabIndex = 0
        Me.txtsubtotal.Text = "0.00"
        Me.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(464, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 19)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Total   S/."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(248, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "I.G.V."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Sub Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnEditar)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(688, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 210)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'BtnEditar
        '
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.ImageIndex = 12
        Me.BtnEditar.ImageList = Me.ImageList1
        Me.BtnEditar.Location = New System.Drawing.Point(24, 183)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(72, 23)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "&Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(24, 99)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(72, 23)
        Me.btnreporte.TabIndex = 4
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(24, 127)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(24, 156)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNCERRAR.TabIndex = 6
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(24, 46)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNMODIFICAR.TabIndex = 2
        Me.BTNMODIFICAR.Text = "&Consultar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(24, 74)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(24, 19)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNGUARDAR.TabIndex = 0
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(24, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(72, 23)
        Me.BTNNUEVO.TabIndex = 1
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNNUEVO.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(120, 64)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ReadOnly = True
        Me.txtnombre.Size = New System.Drawing.Size(288, 21)
        Me.txtnombre.TabIndex = 6
        Me.txtnombre.Text = "TXT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Razón Social"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(296, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Referencia"
        '
        'txtreferncia
        '
        Me.txtreferncia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreferncia.Location = New System.Drawing.Point(360, 72)
        Me.txtreferncia.MaxLength = 4
        Me.txtreferncia.Name = "txtreferncia"
        Me.txtreferncia.Size = New System.Drawing.Size(40, 21)
        Me.txtreferncia.TabIndex = 15
        Me.txtreferncia.Text = "TEXTBOX5"
        '
        'cmbmoneda
        '
        Me.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmoneda.Location = New System.Drawing.Point(128, 72)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Size = New System.Drawing.Size(137, 21)
        Me.cmbmoneda.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 17)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Moneda"
        '
        'txtreferncia1
        '
        Me.txtreferncia1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreferncia1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreferncia1.Location = New System.Drawing.Point(408, 72)
        Me.txtreferncia1.MaxLength = 8
        Me.txtreferncia1.Name = "txtreferncia1"
        Me.txtreferncia1.Size = New System.Drawing.Size(80, 21)
        Me.txtreferncia1.TabIndex = 17
        Me.txtreferncia1.Text = "TEXTBOX5"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(400, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 22)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "-"
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(656, 464)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 24
        '
        'txtpuntovta
        '
        Me.txtpuntovta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpuntovta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpuntovta.Location = New System.Drawing.Point(600, 24)
        Me.txtpuntovta.Name = "txtpuntovta"
        Me.txtpuntovta.ReadOnly = True
        Me.txtpuntovta.Size = New System.Drawing.Size(128, 21)
        Me.txtpuntovta.TabIndex = 6
        Me.txtpuntovta.Text = "TEXTBOX6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(520, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Punto Venta :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtruc)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.txtnrorefe)
        Me.GroupBox1.Controls.Add(Me.btnreferncia)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 120)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Razón Social"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(36, 17)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "R.U.C."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Cód. Cliente"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(50, 17)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Dirección"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXTCODPAGADOR)
        Me.GroupBox4.Controls.Add(Me.BTNREFERENCIA)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TXTNOMPAGADOR)
        Me.GroupBox4.Location = New System.Drawing.Point(448, 104)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(384, 104)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        '
        'TXTCODPAGADOR
        '
        Me.TXTCODPAGADOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCODPAGADOR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCODPAGADOR.Location = New System.Drawing.Point(88, 21)
        Me.TXTCODPAGADOR.Name = "TXTCODPAGADOR"
        Me.TXTCODPAGADOR.Size = New System.Drawing.Size(96, 21)
        Me.TXTCODPAGADOR.TabIndex = 1
        Me.TXTCODPAGADOR.Text = "TEXTBOX5"
        '
        'BTNREFERENCIA
        '
        Me.BTNREFERENCIA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREFERENCIA.ImageIndex = 5
        Me.BTNREFERENCIA.ImageList = Me.ImageList1
        Me.BTNREFERENCIA.Location = New System.Drawing.Point(184, 21)
        Me.BTNREFERENCIA.Name = "BTNREFERENCIA"
        Me.BTNREFERENCIA.Size = New System.Drawing.Size(40, 23)
        Me.BTNREFERENCIA.TabIndex = 2
        '
        'TXTNOMPAGADOR
        '
        Me.TXTNOMPAGADOR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTNOMPAGADOR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMPAGADOR.Location = New System.Drawing.Point(88, 56)
        Me.TXTNOMPAGADOR.Name = "TXTNOMPAGADOR"
        Me.TXTNOMPAGADOR.ReadOnly = True
        Me.TXTNOMPAGADOR.Size = New System.Drawing.Size(288, 21)
        Me.TXTNOMPAGADOR.TabIndex = 4
        Me.TXTNOMPAGADOR.Text = "TXT"
        '
        'FrmNotCredServ
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(842, 489)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtpuntovta)
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
        Me.MaximumSize = New System.Drawing.Size(848, 521)
        Me.MinimumSize = New System.Drawing.Size(848, 521)
        Me.Name = "FrmNotCredServ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota Credito Cliente Servicio"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public AObjBus As New ClsAyuda
    Public ATblCli As New DataTable
    Public AIntResp As Integer
    Public ASngImpuesto As Single
    Public ATblNotCred As New DataTable
    Private EDITARNOTACRED As Boolean

#Region "RESTRICCIONES KEYPRESS"
    Private Sub CajaTexto_SoloNumero_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


    End Sub


#End Region


    Private Sub FrmNotCredServ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarFormularios(Me)
        AObjBus.GCargaDataCombo(cmbreferncia, AObjBus.ListarDatos("NSP_SELECT_LISTATIPODOCNTACRE", codempresa.ToString()).Tables(0), "Código", "Descripción")
        AObjBus.GCargaDataCombo(cmboperador, AObjBus.ListarDatos("Nsp_Sele_Vendedores", codempresa.ToString()).Tables(0), "Codigo", "Descripcion")
        AObjBus.GCargaDataCombo(cmbmoneda, AObjBus.ListarDatos("NSP_Select_Listado_Moneda", codempresa.ToString()).Tables(0), "Código", "Descripción")
        txtcambio.Text = VCambioVta
        txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString, codempresa).Tables(0).Rows(0)(0)
        txtnronotcred.ReadOnly = True
        btnnotcred.Enabled = False
        BTNGUARDAR.Enabled = False
        txtobs.Text = ""
        txtigv.Text = "0.00"
        txtsubtotal.Text = "0.00"
        txttotal.Text = "0.00"
        txtpuntovta.Text = NROPTOVTA
    End Sub

    Private Sub btnreferncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreferncia.Click
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
        txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString).Tables(0).Rows(0)(0)
        BTNMODIFICAR.Enabled = True
        BTNGUARDAR.Enabled = False
        btnnotcred.Enabled = False
        btnreferncia.Enabled = True
        cmbreferncia.Enabled = True
        txtnrorefe.Enabled = True
        txtcambio.Text = VCambioVta
        desbloqueatextos(Me)
        txtnronotcred.ReadOnly = True
        txtpuntovta.Text = NROPTOVTA
        txtpuntovta.ReadOnly = True
        EDITARNOTACRED = False

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
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            txtsubtotal.Focus()
        End If
        If Keyascii = 13 Then
            ASngImpuesto = AObjBus.ListarDatos("NSP_SELECT_IGV", codempresa).Tables(0).Rows(0)(0)
            txtigv.Text = GMascaraDec_D(CDbl(GVDATOVACIO(txtsubtotal.Text)) * (GValidarNulos(ASngImpuesto) / 100))
            txtigv.Focus()
            txtigv.SelectAll()
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

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim CadNumdoc As String
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
        If TmpListarDatos("NSP_VERIF_NTACREDSERV  '" & codempresa & "','" & CInt(txtnronotcred.Text.Trim) & "'").Rows.Count > 0 Then
            MsgBox("Ya existe el Nro de Nota De Credito en los registros grabados..." + (txtnronotcred.Text.Trim), MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        CadNumdoc = CInt(txtreferncia.Text & txtreferncia1.Text)


        AIntResp = AObjBus.Ejecutar("NSP_ins_NTACREDCABSER", txtnronotcred.Text, cmbreferncia.SelectedValue.ToString(), CadNumdoc, cmbmoneda.SelectedValue.ToString(), txtcambio.Text, cmboperador.SelectedValue.ToString(), dtpfecha.Value, GMascaraDec_D(GVDATOVACIO(txttotal.Text)), GMascaraDec_D(CDbl(GVDATOVACIO(txttotal.Text)) / CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(GVDATOVACIO(txtsubtotal.Text))), GMascaraDec_D(CDbl(GVDATOVACIO(txtsubtotal.Text)) / CDbl(txtcambio.Text)), GMascaraDec_D(CDbl(GVDATOVACIO(txtigv.Text))), GMascaraDec_D(CDbl(GVDATOVACIO(txtigv.Text)) / CDbl(txtcambio.Text)), txtnrorefe.Text, txtruc.Text, txtnombre.Text, txtdireccion.Text, CodUsuario.ToString, NROPTOVTA.ToString, codempresa, txtobs.Text, "C", TXTCODPAGADOR.Text)
        If AIntResp <> 0 Then
            GeneraReporte(txtnronotcred.Text)
            MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarFormularios(Me)
            txtigv.Text = "0.00"
            txtsubtotal.Text = "0.00"
            txttotal.Text = "0.00"
            txtnronotcred.Text = AObjBus.ListarDatos("NSP_SELECT_OBTIENECORRELATIVONTACRED", NROPTOVTA.ToString).Tables(0).Rows(0)(0)
            BTNGUARDAR.Enabled = False
            BTNMODIFICAR.Enabled = True
            txtcambio.Text = VCambioVta
            txtpuntovta.Text = NROPTOVTA
            txtpuntovta.ReadOnly = True
        Else
            MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
        End If

    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        txtnronotcred.ReadOnly = False
        txtnronotcred.Text = ""
        btnnotcred.Enabled = True
        btnreferncia.Enabled = False
        cmbreferncia.Enabled = False
        txtnrorefe.Enabled = False
        txtpuntovta.Text = NROPTOVTA
    End Sub

    Private Sub btnnotcred_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnnotcred.Click
        Dim formu As New FrmBusqNotCredServ
        formu.ShowDialog()
        Try
            If AboolCargarValor Then
                ATblNotCred = AObjBus.ListarDatos("NSP_SELECT_LISTANTACREDSERV", formu.IDCODIGO, codempresa.ToString(), "C").Tables(0)

                txtnronotcred.Text = ATblNotCred.Rows(0)(0)
                cmbreferncia.SelectedValue = ATblNotCred.Rows(0)(1)
                txtreferncia.Text = vb.Left(ATblNotCred.Rows(0)(2), 4)
                txtreferncia1.Text = vb.Mid(ATblNotCred.Rows(0)(2), 6)

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
                    MessageBox.Show("¡ DOCUMENTO ANULADO............. !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If NTACRED_INS_CUENTA_CLIE = True Then
                        If AObjBus.ListarDatos("NSP_SELECT_BUSCA_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 1).Tables(0).Rows.Count = 0 Then
                            MessageBox.Show("¡ DOCUMENTO GENERADO CANCELADO EN CUENTAS POR COBRAR !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            BTNELIMINAR.Enabled = False
                        Else
                            BTNELIMINAR.Enabled = True
                        End If
                    Else
                        BTNELIMINAR.Enabled = True
                    End If
                End If
            End If
        Catch
        End Try
        AboolCargarValor = False
    End Sub

    Private Sub txtnrorefe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnrorefe.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Try
                ATblCli = AObjBus.ListarDatos("NSP_SELE_clienteFac", codempresa.ToString(), txtnrorefe.Text, 0, NROPTOVTA).Tables(0)
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
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 13 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If EDITARNOTACRED = True Then
            If Asc(e.KeyChar) = 13 Then
                cmbreferncia.Focus()
            End If
            Exit Sub
        End If

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

        If Keyascii = 0 Then
            e.Handled = True
            txtreferncia.Focus()
        End If
        If Keyascii = 13 Then
            txtreferncia1.Focus()
        End If

    End Sub

    Private Sub txtreferncia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtreferncia.LostFocus
        txtreferncia.Text = Format(CDbl(GVDATOVACIO(txtreferncia.Text)), "000")
    End Sub

    Private Sub txtreferncia1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtreferncia1.LostFocus
        Dim CadNumdoc As String
        Dim Tblrs As DataTable
        txtreferncia1.Text = Format(CDbl(GVDATOVACIO(txtreferncia1.Text)), "0000000")
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
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(AObjBus.SoloNumeros(Keyascii))

        If Keyascii = 0 Then
            e.Handled = True
            txtreferncia1.Focus()
        End If
        If Keyascii = 13 Then
            txtnrorefe.Focus()
        End If
    End Sub
    Sub GeneraReporte(ByVal ADblNtaCred As Double)
        Try
            crRpt.ReportFileName = rutareporte & "RptNtaCredServ.rpt"
            crRpt.set_StoredProcParam(0, ADblNtaCred)
            crRpt.set_StoredProcParam(1, codempresa)
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
        If txtnronotcred.Text.Trim.Length = 0 Then
            MsgBox("- Seleccione un Documento.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        GeneraReporte(txtnronotcred.Text)
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If MessageBox.Show("¿Deseas Anular El Domuneto ?", "Información", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            AObjBus.Ejecutar("NSP_upd_NTACREDCABSER", txtnronotcred.Text, codempresa)
            AObjBus.Ejecutar("NSP_DEL_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 1)
            BTNCANCELAR_Click(sender, e)
        End If
        txtpuntovta.Text = NROPTOVTA
        txtpuntovta.ReadOnly = True

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
                'txtdireccion.Text = ATblCli.Rows(0)(2)
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
                ATblCli = AObjBus.ListarDatos("NSP_SELE_clienteFac", codempresa.ToString(), TXTCODPAGADOR.Text).Tables(0)
                If ATblCli.Rows.Count > 0 Then
                    TXTCODPAGADOR.Text = ATblCli.Rows(0)(0)
                    TXTNOMPAGADOR.Text = ATblCli.Rows(0)(1)
                    BTNGUARDAR.Enabled = True
                    BTNMODIFICAR.Enabled = False
                    txtobs.Focus()
                Else
                    TXTNOMPAGADOR.Text = ""
                    MsgBox("No existe el Cliente", MsgBoxStyle.Critical, "Aviso")
                End If
            Catch
            End Try
        End If
    End Sub

    Private Sub TXTCODPAGADOR_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTCODPAGADOR.KeyUp
        If e.KeyCode = Keys.F2 Then
            BTNREFERENCIA_Click(sender, e)
        End If
    End Sub

    Private Sub FrmNotCredServ_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        cmbreferncia.Focus()
    End Sub

    Private Sub cmbreferncia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbreferncia.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cmbmoneda.Focus()
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
            cmboperador.Focus()
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

    Private Sub txtnrorefe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnrorefe.TextChanged

    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        txtnronotcred.ReadOnly = False
        EDITARNOTACRED = True
    End Sub
End Class
