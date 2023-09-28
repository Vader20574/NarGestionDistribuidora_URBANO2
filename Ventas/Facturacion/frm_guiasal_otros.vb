Public Class frm_guiasal_otros
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
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tmovimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TOBS As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ctipoprecio As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ctipoing As System.Windows.Forms.ComboBox
    Friend WithEvents ctipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tcodproveedor As System.Windows.Forms.TextBox
    Friend WithEvents tproveedor As System.Windows.Forms.TextBox
    Friend WithEvents btnproveedor As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents calmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tdoc1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tdoc2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tumedida As System.Windows.Forms.ComboBox
    Friend WithEvents lcosto As System.Windows.Forms.Label
    Friend WithEvents ltotal As System.Windows.Forms.Label
    Friend WithEvents tcosto As System.Windows.Forms.TextBox
    Friend WithEvents ttotal As System.Windows.Forms.TextBox
    Friend WithEvents dtpfvenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tneto As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ttara As System.Windows.Forms.TextBox
    Friend WithEvents ltara As System.Windows.Forms.Label
    Friend WithEvents tbruto As System.Windows.Forms.TextBox
    Friend WithEvents lbruto As System.Windows.Forms.Label
    Friend WithEvents tmarca As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdesarticulo As System.Windows.Forms.TextBox
    Friend WithEvents btnarticulo As System.Windows.Forms.Button
    Friend WithEvents tarticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lttara As System.Windows.Forms.Label
    Friend WithEvents ltbruto As System.Windows.Forms.Label
    'Friend WithEvents totneto As System.Windows.Forms.TextBox
    'Friend WithEvents totbruto As System.Windows.Forms.TextBox
    'Friend WithEvents tottotal As System.Windows.Forms.TextBox
    'Friend WithEvents tottara As System.Windows.Forms.TextBox
    Friend WithEvents calmacen2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    'Friend WithEvents DsInventInicial1 As mantenimiento.DsInventInicial
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcambio As System.Windows.Forms.NumericUpDown
    Friend WithEvents lproveedor As System.Windows.Forms.Label
    Friend WithEvents lcodprov As System.Windows.Forms.Label
    Friend WithEvents ctipocred As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TREF As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tlote As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboref As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label25 As System.Windows.Forms.Label
    'Friend WithEvents Ds_diferencia_de_reportes1 As mantenimiento.Ds_diferencia_de_reportes
    Friend WithEvents timports As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents timport2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtDocRef1 As System.Windows.Forms.TextBox
    Friend WithEvents BTNANULAR As System.Windows.Forms.Button
    Friend WithEvents Btn As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_guiasal_otros))
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tmovimiento = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TOBS = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboref = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TREF = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ctipoing = New System.Windows.Forms.ComboBox
        Me.ctipodoc = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tdoc1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tdoc2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.calmacen = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.calmacen2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtDocRef1 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.ctipoprecio = New System.Windows.Forms.ComboBox
        Me.tcodproveedor = New System.Windows.Forms.TextBox
        Me.lproveedor = New System.Windows.Forms.Label
        Me.tproveedor = New System.Windows.Forms.TextBox
        Me.btnproveedor = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lcodprov = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNANULAR = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.BTNREPORTE = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.ctipocred = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Btn = New System.Windows.Forms.Button
        Me.timport2 = New System.Windows.Forms.TextBox
        Me.timports = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.tumedida = New System.Windows.Forms.ComboBox
        Me.lcosto = New System.Windows.Forms.Label
        Me.ltotal = New System.Windows.Forms.Label
        Me.tcosto = New System.Windows.Forms.TextBox
        Me.ttotal = New System.Windows.Forms.TextBox
        Me.dtpfvenc = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.tneto = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.ttara = New System.Windows.Forms.TextBox
        Me.ltara = New System.Windows.Forms.Label
        Me.tbruto = New System.Windows.Forms.TextBox
        Me.lbruto = New System.Windows.Forms.Label
        Me.tmarca = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtdesarticulo = New System.Windows.Forms.TextBox
        Me.btnarticulo = New System.Windows.Forms.Button
        Me.tarticulo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.tlote = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lttara = New System.Windows.Forms.Label
        Me.ltbruto = New System.Windows.Forms.Label
        Me.totneto = New System.Windows.Forms.TextBox
        Me.totbruto = New System.Windows.Forms.TextBox
        Me.tottotal = New System.Windows.Forms.TextBox
        Me.tottara = New System.Windows.Forms.TextBox
        'Me.DsInventInicial1 = New mantenimiento.DsInventInicial
        Me.grid1 = New System.Windows.Forms.DataGrid
        'Me.Ds_diferencia_de_reportes1 = New mantenimiento.Ds_diferencia_de_reportes
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtcambio = New System.Windows.Forms.NumericUpDown
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DsInventInicial1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_diferencia_de_reportes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfecha.Location = New System.Drawing.Point(584, 56)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(88, 21)
        Me.dtpfecha.TabIndex = 89
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(472, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 17)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "Fecha Documento :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(512, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 17)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Nro de Movimiento :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmovimiento
        '
        Me.tmovimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tmovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmovimiento.Location = New System.Drawing.Point(640, 22)
        Me.tmovimiento.Name = "tmovimiento"
        Me.tmovimiento.ReadOnly = True
        Me.tmovimiento.Size = New System.Drawing.Size(116, 21)
        Me.tmovimiento.TabIndex = 86
        Me.tmovimiento.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(794, 312)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 17)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Observ :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TOBS
        '
        Me.TOBS.Location = New System.Drawing.Point(560, 184)
        Me.TOBS.MaxLength = 200
        Me.TOBS.Multiline = True
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TOBS.Size = New System.Drawing.Size(280, 40)
        Me.TOBS.TabIndex = 78
        Me.TOBS.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(464, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 17)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Observaciones :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboref)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TREF)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ctipoing)
        Me.GroupBox2.Controls.Add(Me.ctipodoc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tdoc1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tdoc2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.calmacen)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.calmacen2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtDocRef1)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 216)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Salida"
        '
        'cboref
        '
        Me.cboref.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboref.Location = New System.Drawing.Point(144, 160)
        Me.cboref.Name = "cboref"
        Me.cboref.Size = New System.Drawing.Size(276, 21)
        Me.cboref.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Tipo de Doc Referencia :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TREF
        '
        Me.TREF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TREF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TREF.Location = New System.Drawing.Point(216, 184)
        Me.TREF.MaxLength = 7
        Me.TREF.Name = "TREF"
        Me.TREF.Size = New System.Drawing.Size(116, 21)
        Me.TREF.TabIndex = 66
        Me.TREF.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 186)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(124, 17)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Nro Doc de Referencia :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Tipo de Salida :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctipoing
        '
        Me.ctipoing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipoing.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipoing.Location = New System.Drawing.Point(144, 16)
        Me.ctipoing.Name = "ctipoing"
        Me.ctipoing.Size = New System.Drawing.Size(276, 21)
        Me.ctipoing.TabIndex = 0
        '
        'ctipodoc
        '
        Me.ctipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipodoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipodoc.Location = New System.Drawing.Point(144, 112)
        Me.ctipodoc.Name = "ctipodoc"
        Me.ctipodoc.Size = New System.Drawing.Size(276, 21)
        Me.ctipodoc.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Tipo de Documento :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tdoc1
        '
        Me.tdoc1.BackColor = System.Drawing.SystemColors.Window
        Me.tdoc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdoc1.Location = New System.Drawing.Point(144, 136)
        Me.tdoc1.MaxLength = 3
        Me.tdoc1.Name = "tdoc1"
        Me.tdoc1.ReadOnly = True
        Me.tdoc1.Size = New System.Drawing.Size(48, 21)
        Me.tdoc1.TabIndex = 3
        Me.tdoc1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 19)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "-"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tdoc2
        '
        Me.tdoc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdoc2.Location = New System.Drawing.Point(216, 136)
        Me.tdoc2.MaxLength = 7
        Me.tdoc2.Name = "tdoc2"
        Me.tdoc2.Size = New System.Drawing.Size(112, 21)
        Me.tdoc2.TabIndex = 4
        Me.tdoc2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro de Documento :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calmacen
        '
        Me.calmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.calmacen.Location = New System.Drawing.Point(144, 40)
        Me.calmacen.Name = "calmacen"
        Me.calmacen.Size = New System.Drawing.Size(276, 21)
        Me.calmacen.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Punto de Venta :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calmacen2
        '
        Me.calmacen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.calmacen2.Location = New System.Drawing.Point(144, 64)
        Me.calmacen2.Name = "calmacen2"
        Me.calmacen2.Size = New System.Drawing.Size(276, 21)
        Me.calmacen2.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 17)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Almacén Destino :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(144, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(276, 21)
        Me.ComboBox1.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Almacén Origen :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDocRef1
        '
        Me.TxtDocRef1.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDocRef1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDocRef1.Location = New System.Drawing.Point(144, 184)
        Me.TxtDocRef1.MaxLength = 3
        Me.TxtDocRef1.Name = "TxtDocRef1"
        Me.TxtDocRef1.Size = New System.Drawing.Size(48, 21)
        Me.TxtDocRef1.TabIndex = 3
        Me.TxtDocRef1.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(199, 184)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 19)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "-"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(38, 105)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 17)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Tipo Precio :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Visible = False
        '
        'ctipoprecio
        '
        Me.ctipoprecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipoprecio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipoprecio.Location = New System.Drawing.Point(112, 104)
        Me.ctipoprecio.Name = "ctipoprecio"
        Me.ctipoprecio.Size = New System.Drawing.Size(248, 21)
        Me.ctipoprecio.TabIndex = 54
        '
        'tcodproveedor
        '
        Me.tcodproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodproveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcodproveedor.Location = New System.Drawing.Point(112, 20)
        Me.tcodproveedor.Name = "tcodproveedor"
        Me.tcodproveedor.Size = New System.Drawing.Size(96, 21)
        Me.tcodproveedor.TabIndex = 6
        Me.tcodproveedor.Text = ""
        '
        'lproveedor
        '
        Me.lproveedor.AutoSize = True
        Me.lproveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lproveedor.Location = New System.Drawing.Point(45, 44)
        Me.lproveedor.Name = "lproveedor"
        Me.lproveedor.Size = New System.Drawing.Size(59, 17)
        Me.lproveedor.TabIndex = 2
        Me.lproveedor.Text = "Proveedor:"
        Me.lproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tproveedor
        '
        Me.tproveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tproveedor.Location = New System.Drawing.Point(112, 44)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.ReadOnly = True
        Me.tproveedor.Size = New System.Drawing.Size(248, 21)
        Me.tproveedor.TabIndex = 8
        Me.tproveedor.Text = ""
        '
        'btnproveedor
        '
        Me.btnproveedor.ImageIndex = 5
        Me.btnproveedor.ImageList = Me.ImageList1
        Me.btnproveedor.Location = New System.Drawing.Point(209, 19)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(32, 23)
        Me.btnproveedor.TabIndex = 7
        Me.btnproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lcodprov
        '
        Me.lcodprov.AutoSize = True
        Me.lcodprov.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcodprov.Location = New System.Drawing.Point(47, 20)
        Me.lcodprov.Name = "lcodprov"
        Me.lcodprov.Size = New System.Drawing.Size(57, 17)
        Me.lcodprov.TabIndex = 1
        Me.lcodprov.Text = "Cod Prov :"
        Me.lcodprov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNANULAR)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.BTNREPORTE)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Location = New System.Drawing.Point(848, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 216)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNANULAR
        '
        Me.BTNANULAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNANULAR.ImageIndex = 12
        Me.BTNANULAR.ImageList = Me.ImageList1
        Me.BTNANULAR.Location = New System.Drawing.Point(11, 136)
        Me.BTNANULAR.Name = "BTNANULAR"
        Me.BTNANULAR.Size = New System.Drawing.Size(85, 23)
        Me.BTNANULAR.TabIndex = 20
        Me.BTNANULAR.Text = "&Anular"
        Me.BTNANULAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnmodificar
        '
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.ImageIndex = 2
        Me.btnmodificar.ImageList = Me.ImageList1
        Me.btnmodificar.Location = New System.Drawing.Point(11, 40)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(85, 23)
        Me.btnmodificar.TabIndex = 11
        Me.btnmodificar.Text = "&Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 11
        Me.BTNREPORTE.ImageList = Me.ImageList1
        Me.BTNREPORTE.Location = New System.Drawing.Point(11, 160)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(85, 23)
        Me.BTNREPORTE.TabIndex = 6
        Me.BTNREPORTE.Text = "&Reporte"
        Me.BTNREPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(11, 88)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(85, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(11, 112)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(85, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(11, 18)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(85, 23)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(11, 64)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(85, 23)
        Me.BTNGUARDAR.TabIndex = 19
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(8, 184)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(88, 23)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.ctipocred)
        Me.GroupBox5.Controls.Add(Me.btnproveedor)
        Me.GroupBox5.Controls.Add(Me.tcodproveedor)
        Me.GroupBox5.Controls.Add(Me.tproveedor)
        Me.GroupBox5.Controls.Add(Me.lcodprov)
        Me.GroupBox5.Controls.Add(Me.lproveedor)
        Me.GroupBox5.Controls.Add(Me.ctipoprecio)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Location = New System.Drawing.Point(464, 80)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(376, 104)
        Me.GroupBox5.TabIndex = 84
        Me.GroupBox5.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 17)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Tipo de Crédito :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctipocred
        '
        Me.ctipocred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipocred.Location = New System.Drawing.Point(112, 68)
        Me.ctipocred.Name = "ctipocred"
        Me.ctipocred.Size = New System.Drawing.Size(248, 21)
        Me.ctipocred.TabIndex = 63
        '
        'Button1
        '
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(758, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn)
        Me.GroupBox3.Controls.Add(Me.timport2)
        Me.GroupBox3.Controls.Add(Me.timports)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.tumedida)
        Me.GroupBox3.Controls.Add(Me.lcosto)
        Me.GroupBox3.Controls.Add(Me.ltotal)
        Me.GroupBox3.Controls.Add(Me.tcosto)
        Me.GroupBox3.Controls.Add(Me.ttotal)
        Me.GroupBox3.Controls.Add(Me.dtpfvenc)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.tneto)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.ttara)
        Me.GroupBox3.Controls.Add(Me.ltara)
        Me.GroupBox3.Controls.Add(Me.tbruto)
        Me.GroupBox3.Controls.Add(Me.lbruto)
        Me.GroupBox3.Controls.Add(Me.tmarca)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtcantidad)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtdesarticulo)
        Me.GroupBox3.Controls.Add(Me.btnarticulo)
        Me.GroupBox3.Controls.Add(Me.tarticulo)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.tlote)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 414)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(944, 120)
        Me.GroupBox3.TabIndex = 79
        Me.GroupBox3.TabStop = False
        '
        'Btn
        '
        Me.Btn.Location = New System.Drawing.Point(760, 72)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(176, 32)
        Me.Btn.TabIndex = 65
        Me.Btn.Text = "&Reprocesar Saldos de Punto de Venta"
        Me.Btn.Visible = False
        '
        'timport2
        '
        Me.timport2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.timport2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.timport2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timport2.Location = New System.Drawing.Point(186, 88)
        Me.timport2.Name = "timport2"
        Me.timport2.ReadOnly = True
        Me.timport2.Size = New System.Drawing.Size(152, 21)
        Me.timport2.TabIndex = 64
        Me.timport2.Text = ""
        Me.timport2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'timports
        '
        Me.timports.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.timports.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timports.Location = New System.Drawing.Point(188, 16)
        Me.timports.Name = "timports"
        Me.timports.ReadOnly = True
        Me.timports.Size = New System.Drawing.Size(160, 21)
        Me.timports.TabIndex = 62
        Me.timports.Text = ""
        Me.timports.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(91, 90)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 17)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Nro Importación :"
        '
        'tumedida
        '
        Me.tumedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tumedida.DropDownWidth = 160
        Me.tumedida.Enabled = False
        Me.tumedida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tumedida.Location = New System.Drawing.Point(186, 64)
        Me.tumedida.Name = "tumedida"
        Me.tumedida.Size = New System.Drawing.Size(152, 21)
        Me.tumedida.TabIndex = 13
        '
        'lcosto
        '
        Me.lcosto.AutoSize = True
        Me.lcosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcosto.Location = New System.Drawing.Point(388, 91)
        Me.lcosto.Name = "lcosto"
        Me.lcosto.Size = New System.Drawing.Size(40, 17)
        Me.lcosto.TabIndex = 38
        Me.lcosto.Text = "Costo :"
        Me.lcosto.Visible = False
        '
        'ltotal
        '
        Me.ltotal.AutoSize = True
        Me.ltotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltotal.Location = New System.Drawing.Point(559, 89)
        Me.ltotal.Name = "ltotal"
        Me.ltotal.Size = New System.Drawing.Size(37, 17)
        Me.ltotal.TabIndex = 36
        Me.ltotal.Text = "Total :"
        Me.ltotal.Visible = False
        '
        'tcosto
        '
        Me.tcosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcosto.Location = New System.Drawing.Point(432, 88)
        Me.tcosto.Name = "tcosto"
        Me.tcosto.Size = New System.Drawing.Size(104, 21)
        Me.tcosto.TabIndex = 17
        Me.tcosto.Text = "0"
        Me.tcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tcosto.Visible = False
        '
        'ttotal
        '
        Me.ttotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ttotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ttotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotal.Location = New System.Drawing.Point(600, 88)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.ReadOnly = True
        Me.ttotal.Size = New System.Drawing.Size(144, 21)
        Me.ttotal.TabIndex = 18
        Me.ttotal.Text = "0"
        Me.ttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttotal.Visible = False
        '
        'dtpfvenc
        '
        Me.dtpfvenc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfvenc.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfvenc.Location = New System.Drawing.Point(832, 20)
        Me.dtpfvenc.Name = "dtpfvenc"
        Me.dtpfvenc.Size = New System.Drawing.Size(96, 21)
        Me.dtpfvenc.TabIndex = 11
        Me.dtpfvenc.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(760, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 17)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Fecha Venc :"
        Me.Label22.Visible = False
        '
        'tneto
        '
        Me.tneto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tneto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tneto.Location = New System.Drawing.Point(832, 45)
        Me.tneto.Name = "tneto"
        Me.tneto.Size = New System.Drawing.Size(96, 21)
        Me.tneto.TabIndex = 16
        Me.tneto.Text = "0"
        Me.tneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(746, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 17)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Peso Neto(kg) :"
        '
        'ttara
        '
        Me.ttara.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ttara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ttara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttara.Location = New System.Drawing.Point(599, 64)
        Me.ttara.Name = "ttara"
        Me.ttara.ReadOnly = True
        Me.ttara.Size = New System.Drawing.Size(144, 21)
        Me.ttara.TabIndex = 15
        Me.ttara.Text = "0"
        Me.ttara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ltara
        '
        Me.ltara.AutoSize = True
        Me.ltara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltara.Location = New System.Drawing.Point(539, 65)
        Me.ltara.Name = "ltara"
        Me.ltara.Size = New System.Drawing.Size(58, 17)
        Me.ltara.TabIndex = 30
        Me.ltara.Text = "Tara (kg) :"
        '
        'tbruto
        '
        Me.tbruto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbruto.Location = New System.Drawing.Point(432, 64)
        Me.tbruto.Name = "tbruto"
        Me.tbruto.Size = New System.Drawing.Size(104, 21)
        Me.tbruto.TabIndex = 14
        Me.tbruto.Text = "0"
        Me.tbruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbruto
        '
        Me.lbruto.AutoSize = True
        Me.lbruto.Location = New System.Drawing.Point(344, 66)
        Me.lbruto.Name = "lbruto"
        Me.lbruto.Size = New System.Drawing.Size(86, 17)
        Me.lbruto.TabIndex = 28
        Me.lbruto.Text = "Peso Bruto(kg) :"
        '
        'tmarca
        '
        Me.tmarca.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tmarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tmarca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmarca.Location = New System.Drawing.Point(599, 41)
        Me.tmarca.Name = "tmarca"
        Me.tmarca.ReadOnly = True
        Me.tmarca.Size = New System.Drawing.Size(144, 21)
        Me.tmarca.TabIndex = 10
        Me.tmarca.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(554, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Marca :"
        '
        'txtcantidad
        '
        Me.txtcantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(72, 64)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(80, 21)
        Me.txtcantidad.TabIndex = 12
        Me.txtcantidad.Text = "0"
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Bultos :"
        '
        'txtdesarticulo
        '
        Me.txtdesarticulo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtdesarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesarticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesarticulo.Location = New System.Drawing.Point(186, 41)
        Me.txtdesarticulo.Name = "txtdesarticulo"
        Me.txtdesarticulo.ReadOnly = True
        Me.txtdesarticulo.Size = New System.Drawing.Size(350, 21)
        Me.txtdesarticulo.TabIndex = 9
        Me.txtdesarticulo.Text = ""
        '
        'btnarticulo
        '
        Me.btnarticulo.ImageIndex = 5
        Me.btnarticulo.ImageList = Me.ImageList1
        Me.btnarticulo.Location = New System.Drawing.Point(153, 40)
        Me.btnarticulo.Name = "btnarticulo"
        Me.btnarticulo.Size = New System.Drawing.Size(32, 23)
        Me.btnarticulo.TabIndex = 9
        '
        'tarticulo
        '
        Me.tarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tarticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarticulo.Location = New System.Drawing.Point(72, 40)
        Me.tarticulo.Name = "tarticulo"
        Me.tarticulo.Size = New System.Drawing.Size(80, 21)
        Me.tarticulo.TabIndex = 8
        Me.tarticulo.Text = ""
        Me.tarticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Articulo :"
        '
        'tlote
        '
        Me.tlote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlote.Location = New System.Drawing.Point(72, 16)
        Me.tlote.MaxLength = 20
        Me.tlote.Name = "tlote"
        Me.tlote.Size = New System.Drawing.Size(80, 21)
        Me.tlote.TabIndex = 60
        Me.tlote.Text = ""
        Me.tlote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(36, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 17)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "Lote :"
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 5
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(168, 616)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 20)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "..."
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lttara)
        Me.GroupBox4.Controls.Add(Me.ltbruto)
        Me.GroupBox4.Controls.Add(Me.totneto)
        Me.GroupBox4.Controls.Add(Me.totbruto)
        Me.GroupBox4.Controls.Add(Me.tottotal)
        Me.GroupBox4.Controls.Add(Me.tottara)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 533)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(944, 48)
        Me.GroupBox4.TabIndex = 88
        Me.GroupBox4.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(760, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 17)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Total  :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(513, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Total Neto(kg) :"
        '
        'lttara
        '
        Me.lttara.AutoSize = True
        Me.lttara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lttara.Location = New System.Drawing.Point(281, 20)
        Me.lttara.Name = "lttara"
        Me.lttara.Size = New System.Drawing.Size(84, 17)
        Me.lttara.TabIndex = 19
        Me.lttara.Text = "Total Tara(kg) :"
        '
        'ltbruto
        '
        Me.ltbruto.AutoSize = True
        Me.ltbruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbruto.Location = New System.Drawing.Point(41, 20)
        Me.ltbruto.Name = "ltbruto"
        Me.ltbruto.Size = New System.Drawing.Size(91, 17)
        Me.ltbruto.TabIndex = 17
        Me.ltbruto.Text = "Total Bruto (kg) :"
        '
        'totneto
        '
        Me.totneto.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.totneto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.totneto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totneto.Location = New System.Drawing.Point(608, 18)
        Me.totneto.Name = "totneto"
        Me.totneto.ReadOnly = True
        Me.totneto.Size = New System.Drawing.Size(97, 21)
        Me.totneto.TabIndex = 20
        Me.totneto.Text = "0.00"
        Me.totneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totbruto
        '
        Me.totbruto.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.totbruto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.totbruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totbruto.Location = New System.Drawing.Point(152, 18)
        Me.totbruto.Name = "totbruto"
        Me.totbruto.ReadOnly = True
        Me.totbruto.Size = New System.Drawing.Size(97, 21)
        Me.totbruto.TabIndex = 16
        Me.totbruto.Text = "0.00"
        Me.totbruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tottotal
        '
        Me.tottotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tottotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tottotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tottotal.Location = New System.Drawing.Point(808, 18)
        Me.tottotal.Name = "tottotal"
        Me.tottotal.ReadOnly = True
        Me.tottotal.Size = New System.Drawing.Size(97, 21)
        Me.tottotal.TabIndex = 22
        Me.tottotal.Text = "0.00"
        Me.tottotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tottara
        '
        Me.tottara.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tottara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tottara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tottara.Location = New System.Drawing.Point(376, 18)
        Me.tottara.Name = "tottara"
        Me.tottara.ReadOnly = True
        Me.tottara.Size = New System.Drawing.Size(97, 21)
        Me.tottara.TabIndex = 18
        Me.tottara.Text = "0.00"
        Me.tottara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DsInventInicial1
        '
        Me.DsInventInicial1.DataSetName = "DsInventInicial"
        Me.DsInventInicial1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionText = "Registro de Items                                                         [Enter]" & _
        " Modificar - [F3] Eliminar Registro"
        Me.grid1.DataMember = ""
        Me.grid1.DataSource = Me.Ds_diferencia_de_reportes1.Tables(0)
        Me.grid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(8, 228)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(952, 184)
        Me.grid1.TabIndex = 91
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1, Me.DataGridTableStyle2})
        '
        'Ds_diferencia_de_reportes1
        '
        Me.Ds_diferencia_de_reportes1.DataSetName = "Ds_diferencia_de_reportes"
        Me.Ds_diferencia_de_reportes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn27})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Dsdifreporte"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Id"
        Me.DataGridTextBoxColumn1.MappingName = "codlinea"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 40
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Código"
        Me.DataGridTextBoxColumn2.MappingName = "idarticulo"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridTextBoxColumn3.MappingName = "codalmacen"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Mercaderia"
        Me.DataGridTextBoxColumn4.MappingName = "desarti"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 280
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Tipo Bulto"
        Me.DataGridTextBoxColumn5.MappingName = "codumed"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Cantidad."
        Me.DataGridTextBoxColumn6.MappingName = "ingresos"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 50
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Peso Bruto(KG) ."
        Me.DataGridTextBoxColumn7.MappingName = "salidas"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 85
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "ventas"
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Peso Neto (kg) ."
        Me.DataGridTextBoxColumn9.MappingName = "dev"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 85
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Costo ."
        Me.DataGridTextBoxColumn10.MappingName = "costo"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "total"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "F Venc"
        Me.DataGridTextBoxColumn12.MappingName = "fecha"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Nro Lote"
        Me.DataGridTextBoxColumn23.MappingName = "lote"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.ReadOnly = True
        Me.DataGridTextBoxColumn23.Width = 50
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Nro Import/Compra"
        Me.DataGridTextBoxColumn25.MappingName = "nroimport"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.ReadOnly = True
        Me.DataGridTextBoxColumn25.Width = 0
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "NroImport/NroCompra"
        Me.DataGridTextBoxColumn27.MappingName = "nroimport2"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.ReadOnly = True
        Me.DataGridTextBoxColumn27.Width = 120
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.grid1
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn28})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ds_inventini"
        Me.DataGridTableStyle2.ReadOnly = True
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Id"
        Me.DataGridTextBoxColumn13.MappingName = "iditem"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.ReadOnly = True
        Me.DataGridTextBoxColumn13.Width = 45
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Código"
        Me.DataGridTextBoxColumn14.MappingName = "codigo"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Marca"
        Me.DataGridTextBoxColumn15.MappingName = "marca"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.ReadOnly = True
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Mercaderia"
        Me.DataGridTextBoxColumn16.MappingName = "descripcion"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.ReadOnly = True
        Me.DataGridTextBoxColumn16.Width = 250
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Tipo Bulto"
        Me.DataGridTextBoxColumn17.MappingName = "umedida"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.ReadOnly = True
        Me.DataGridTextBoxColumn17.Width = 80
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Cantidad"
        Me.DataGridTextBoxColumn18.MappingName = "cantidad"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.ReadOnly = True
        Me.DataGridTextBoxColumn18.Width = 50
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Peso Neto (kg) ."
        Me.DataGridTextBoxColumn19.MappingName = "costo"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.ReadOnly = True
        Me.DataGridTextBoxColumn19.Width = 90
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Precio ."
        Me.DataGridTextBoxColumn20.MappingName = "igv"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.ReadOnly = True
        Me.DataGridTextBoxColumn20.Width = 90
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Total ."
        Me.DataGridTextBoxColumn21.MappingName = "total"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.ReadOnly = True
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn22.MappingName = "fecha"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.ReadOnly = True
        Me.DataGridTextBoxColumn22.Width = 85
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Lote"
        Me.DataGridTextBoxColumn24.MappingName = "lote"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.ReadOnly = True
        Me.DataGridTextBoxColumn24.Width = 50
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Nro Import/Compra"
        Me.DataGridTextBoxColumn26.MappingName = "nroimport"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.ReadOnly = True
        Me.DataGridTextBoxColumn26.Width = 120
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "NroImport/Compra"
        Me.DataGridTextBoxColumn28.MappingName = "nroimport2"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.ReadOnly = True
        Me.DataGridTextBoxColumn28.Width = 120
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(712, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 17)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "T.C :"
        '
        'txtcambio
        '
        Me.txtcambio.DecimalPlaces = 3
        Me.txtcambio.Enabled = False
        Me.txtcambio.Location = New System.Drawing.Point(744, 56)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.Size = New System.Drawing.Size(72, 21)
        Me.txtcambio.TabIndex = 93
        Me.txtcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frm_guiasal_otros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(970, 584)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.txtcambio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tmovimiento)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TOBS)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_guiasal_otros"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Salida de Mercadería"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DsInventInicial1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_diferencia_de_reportes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public marca, tara As String, medida As New ArrayList
    Public a1, a2 As Boolean, VA1, VA2 As Short
    Dim CONT As Integer = 0
    Public monval As Boolean
    Public est As Boolean = True
    Public correl As String
    Public INICIA As Int16 = 0
    Dim flag As Integer
    Dim salida As Boolean
    Dim valor As Boolean
    Dim CODSALTRANS, CODSALTRANSUBCAM As String
    Public codmed As String
    'Dim CLSINTER As New ClsInterface
    'Dim CAyuda As New ClsInterface
    Dim e As Integer = 0
    Dim articulo As String
    Dim almacen As String
    Dim nroimportacion As String
    Dim lote As String
    Dim FECHAMAX As Date
    Dim SUBALMACEN As String
    Dim PTOVTA As String
    Dim NROMOVI As Integer
    Dim CANTIDADES As Decimal
    Private COEMPRESA As String = "01"
    Private Ds_diferencia_de_reportes1 As New DataSet
    Private DsInventInicial1 As New DataSet



    Private Sub BTNCLIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproveedor.Click

        If (a1 = True And a2 = False) Or (a1 = True And a2 = True) Then
            If Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count > 0 Then
                If MessageBox.Show("Tiene mercaderia ingresada con un determinado Proveedor, si cambia el Proveedor tendra que sacarse la mercaderia ingresada ¿Desea realizar esta operación?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    TmpInsertDatos("delete from tmp_movidet where cdcompra='" & correl & "' and codempresa='" & codempresa & "' and cdalmacen='" & calmacen.SelectedValue.ToString & "' and inout=0")
                    Me.Ds_diferencia_de_reportes1.Clear()
                    Me.grid1.Refresh()
                    CONT = 0
                    txtcantidad.Text = CStr(0)
                    tbruto.Text = CStr(0)
                    ttara.Text = CStr(0)
                    tneto.Text = CStr(0)
                    tcosto.Text = CStr(0)
                    ttotal.Text = CStr(0)
                    tarticulo.Text = ""
                    txtdesarticulo.Text = ""
                    tmarca.Text = ""
                Else
                    Exit Sub
                End If
            End If

        ElseIf a1 = False And a2 = True Then
            If Me.DsInventInicial1.Tables(0).Rows.Count > 0 Then
                If MessageBox.Show("Tiene mercaderia ingresada con un determinado Proveedor, si cambia el Proveedor tendra que sacarse la mercaderia ingresada ¿Desea realizar esta operación?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    TmpInsertDatos("delete from tmp_movidet where cdcompra='" & correl & "' and codempresa='" & codempresa & "' and cdalmacen='" & calmacen.SelectedValue.ToString & "' and inout=0")
                    Me.DsInventInicial1.Clear()
                    Me.grid1.Refresh()
                    CONT = 0

                    txtcantidad.Text = 0
                    tbruto.Text = 0
                    ttara.Text = 0
                    tneto.Text = 0
                    tcosto.Text = 0
                    ttotal.Text = 0
                    tarticulo.Text = ""
                    txtdesarticulo.Text = ""
                    tmarca.Text = ""
                Else
                    Exit Sub
                End If
            End If

        End If


        INICIAS = False
        tdoc1.Focus()
        Dim men As New frm_gridproveedor
        men.boingresoprov = False
        men.vie2 = Me
        men.ShowDialog()
        If ctipocred.Visible = True Then
            ctipocred.Focus()
        Else
            tarticulo.Focus()
        End If


    End Sub
    Public forma As Short
    Dim timporta, moviant As String
    Private Sub btnarticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarticulo.Click
        'If Me.tdoc1.Text.Trim = "" Or Me.tdoc2.Text.Trim = "" Then
        '    MessageBox.Show("Ingrese el Número del Documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'Else
        '    est = True
        '    Me.tdoc1.Text = Format(Val(Me.tdoc1.Text.Trim), "000")
        '    Me.tdoc2.Text = Format(Val(Me.tdoc2.Text.Trim), "0000000")
        'End If

        If tproveedor.Visible = False Then
            forma = 0
        Else
            forma = 2
        End If

        INICIAS = False
        timports.Text = Nothing
        timport2.Text = Nothing
        Me.txtcantidad.Focus()
        Dim men As New frm_grid_articulo_otro
        men.boingresoart = False
        men.vie2 = Me
        men.ShowDialog()
    End Sub
    Public Sub modelo_grilla()
        If (a1 = True And a2 = False) Or (a1 = True And a2 = True) Then
            Me.grid1.DataSource = Me.Ds_diferencia_de_reportes1.Tables(0)
            lbruto.Visible = True
            tbruto.Visible = True
            ltara.Visible = True
            ttara.Visible = True
            ltbruto.Visible = True
            totbruto.Visible = True
            lttara.Visible = True
            tottara.Visible = True
            Me.DataGridTextBoxColumn7.Width = 80
            Me.DataGridTextBoxColumn8.Width = 0
            Me.DataGridTextBoxColumn7.HeaderText = "Peso Bruto(kg)"
            Me.DataGridTextBoxColumn8.HeaderText = "Tara(Kg)"

        ElseIf a1 = False And a2 = True Then
            Me.grid1.DataSource = Me.DsInventInicial1.Tables(0)
            lbruto.Visible = False
            tbruto.Visible = False
            ltara.Visible = False
            ttara.Visible = False
            ltbruto.Visible = False
            totbruto.Visible = False
            lttara.Visible = False
            tottara.Visible = False
            Me.DataGridTextBoxColumn7.Width = 0
            Me.DataGridTextBoxColumn8.Width = 0
            Me.DataGridTextBoxColumn18.Width = 0
            Me.DataGridTextBoxColumn20.Width = 0
            Me.DataGridTextBoxColumn7.HeaderText = ""
            Me.DataGridTextBoxColumn8.HeaderText = ""
            Me.DataGridTextBoxColumn18.HeaderText = ""
            Me.DataGridTextBoxColumn20.HeaderText = ""

        ElseIf a1 = False And a2 = False Then
            MessageBox.Show("No tiene configurado las Ventas por Medida y UMedida en la Configuración de Inventarios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub
    Dim mbase, ntacred, ComSal As String
    'Dim ObjInter As New ClsInterface
    Private Sub Cargar_Combo()
        CAyuda.CargarDataCombo(ctipodoc, "nsp_sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(cboref, "nsp_sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(ctipoing, "Nsp_Sele_tipomovisal '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(calmacen, "Nsp_select_Almacen '" & codempresa & "'", "codigo", "descripcion")
        CAyuda.CargarDataCombo(calmacen2, "Nsp_select_Almacen '" & codempresa & "'", "codigo", "descripcion")
        CAyuda.CargarDataCombo(ComboBox1, "Nsp_Sele_tdaptoventa '" & codempresa & "','',''", "NROPTOVTA", "DESPTOVTA")
        CAyuda.CargarDataCombo(ctipoprecio, "nsp_sele_moneda '" & codempresa & "'", "codmon", "dsmoneda")
        CAyuda.CargarDataCombo(ctipocred, "Nsp_sel_TipCredF '" & codempresa & "'", "Codigo", "Descripcion")
    End Sub
    Private Sub Config_Inventario()
        Dim Tabla As DataTable
        Tabla = CAyuda.ListarDatos("USP_CONFIGINV", codempresa.Trim).Tables(0)
        If Tabla.Rows.Count > 0 Then
            With Tabla.Rows(0)
                CODSALTRANS = .Item("CDSALTRANSF")
                CODSALTRANSUBCAM = .Item("CDSALTRANSSUBCAM")
                ComSal = Trim(.Item("CODIGO_DOCUMENTO_SALIDA").ToString())
                ntacred = Trim(.Item("CDSALNTACRED").ToString())
            End With
        End If

        Tabla.Dispose()
        Tabla = Nothing
    End Sub
    Private Sub frm_guiaingmercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TmpInsertDatos("DELETE FROM TMP_MOVIDET WHERE MAQUINA = '" & NROPTOVTA & "' AND USUARIO = '" & CodUsuario & "'")
        Call Cargar_Combo()
        Call Config_Inventario()

        Conecta("select cdmonbase from configsis where cod_empresa='" & codempresa & "'", "codmon")
        If ds.Tables("codmon").Rows.Count > 0 Then
            mbase = Trim(ds.Tables("codmon").Rows(0)(0))
        End If
        tcambio()

        Conecta("select medida,umedida from configinv where codempresa='" & codempresa & "'", "llena")
        If ds.Tables("llena").Rows.Count > 0 Then
            a1 = ds.Tables("llena").Rows(0)(0)
            a2 = ds.Tables("llena").Rows(0)(1)

            If a1 = True Then
                VA1 = 1
            Else
                VA1 = 0
            End If

            If a2 = True Then
                VA2 = 1
            Else
                VA2 = 0
            End If

        Else
            MessageBox.Show("No tiene configurado las Ventas por Medida y UMedida en la Configuración de Inventarios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        modelo_grilla()

        Bloqueatextbox(Me)
        Me.BTNGUARDAR.Enabled = False
        Me.BTNELIMINAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False
        btnmodificar.Enabled = False
        btnarticulo.Enabled = False
        btnproveedor.Enabled = False
        Me.dtpfvenc.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.ctipoing.Focus()
        verifica_valorizado()
        ctipoing_SelectedIndexChanged(sender, e)
        Me.ctipoing.SelectedValue = CODSALTRANSUBCAM
        calmacen.SelectedValue = CDZONA
        Me.ctipodoc.SelectedValue = ComSal
        Me.ctipoprecio.SelectedIndex = 1
        Me.TxtDocRef1.ReadOnly = False
        Me.cboref.SelectedValue = ComSal

    End Sub
    Private Sub tdoc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdoc1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdoc2.Focus()
        End If
    End Sub
    Private Sub tdoc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdoc2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            INICIAS = True
            Me.tdoc2.Text = Format(Val(Me.tdoc2.Text.Trim), "0000000")
            cboref.Focus()
        End If
    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números Por Favor ", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtcantidad.Focus()
        End If

        'If Asc(e.KeyChar) = 13 Then
        '    Me.tbruto.Focus()
        'End If

    End Sub

    Private Sub tumedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tumedida.KeyPress

        If Asc(e.KeyChar) = 13 Then
            tumedida.Focus()
            If valor = True Then
                Me.ttara.Text = Val(tara * Me.txtcantidad.Text).ToString("###0.00")
                Me.tbruto.Focus()
                Me.tbruto.SelectAll()
            Else
                Me.tbruto.Text = 0
                Me.tneto.Focus()
                Me.tneto.SelectAll()
            End If
        End If

    End Sub
    Private Sub tbruto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbruto.KeyPress
        Try
            'Dim Keyascii As Short = CShort(Asc(e.KeyChar))
            'Keyascii = CShort(NumerosDecimales(Keyascii))
            'If Keyascii = 0 Then
            '    e.Handled = True
            '    MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Me.tbruto.Focus()
            'End If
            If IsNumeric(CDbl(tbruto.Text)) Then
                If Asc(e.KeyChar) = 13 Then
                    'Me.tneto.Text = Val(Me.tbruto.Text - Me.ttara.Text).ToString("###0.00")
                    Me.tneto.Text = Format(CDbl(Me.tbruto.Text.Trim) - (CDbl(Me.txtcantidad.Text.Trim) * CDbl(Me.ttara.Text.Trim)), "###0.00")
                    Me.tneto.Focus()
                    Me.tneto.SelectAll()
                End If
            Else
                MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbruto.Focus()
            End If


        Catch x As Exception
        End Try
    End Sub
    Sub Llena_temp()
        Try
            Dim sql As String
            Dim PROCESO As Boolean

            If Me.tcodproveedor.Text.Trim = "" Then
                MessageBox.Show("Ingrese el Proveedor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tcodproveedor.Focus()
                Exit Sub
            ElseIf tdoc1.Text.Trim = "" Or tdoc2.Text = "" Then
                MessageBox.Show("Ingrese el Nro de Documento para poder seguir con el proceso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tdoc1.Focus()
                Exit Sub
            ElseIf tarticulo.Text.Trim = "" Then
                MessageBox.Show("Ingrese el articulo para poder seguir con el proceso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tarticulo.Focus()
                Exit Sub
            ElseIf txtcantidad.Text.Trim = "" Then
                MessageBox.Show("Ingrese la cantidad para poder seguir con el proceso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtcantidad.Focus()
                Exit Sub
            End If

            If Val(tneto.Text) < 0 Then
                MessageBox.Show("No puede ingresar una cantidad menor a 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tneto.Focus()
                Me.tneto.SelectAll()
                Exit Sub
            End If


            'Me.tbruto.Text = Val(Val(Me.tneto.Text) + Val(Me.ttara.Text)).ToString("###0.00")

            If tcosto.Text = "Infinito" Then
                tcosto.Text = 0
            End If

            Dim NroImportacion As String
            NroImportacion = Mid(Me.timport2.Text.Trim, 3, 3) + Mid(Me.timport2.Text.Trim, 12, 4)

            If est = True Then
                Conecta("SELECT * FROM TMP_MOVIDET WHERE CDARTICULO = '" & Me.tarticulo.Text.Trim & "' AND LOTE = '" & Me.tlote.Text.Trim & "' AND CORRNBR = " & Me.tmovimiento.Text.Trim & " AND INOUT = 0 AND NROIMPORTACION = " & NroImportacion & "", "pa")
                If ds.Tables("pa").Rows.Count > 0 Then
                    MessageBox.Show("El Item ya Fue Ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call limpia()
                    Me.tlote.Focus()
                    Exit Sub
                End If

                CONT += 1
                If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                        sql = "TMP_MOVIDETInsProc_lote " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ctipoing.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','0','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & tara & "','" & codmed & "'," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & ",'" & tlote.Text.Trim.ToUpper & "','" & NroImportacion & "','" & moviant & "','" & timport2.Text & "','" & NROPTOVTA & "'"
                    Else
                        sql = "TMP_MOVIDETInsProc_lote " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ctipoing.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','0','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & tara & "','" & codmed & "'," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & ",'" & tlote.Text.Trim.ToUpper & "','" & NroImportacion & "','" & moviant & "','" & timport2.Text & "','" & NROPTOVTA & "'"
                    End If
                Else
                    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                        sql = "TMP_MOVIDETInsProc_lote " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ctipoing.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','0','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & tara & "','" & codmed & "'," & (tcosto.Text * tneto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & tlote.Text.Trim.ToUpper & "','" & NroImportacion & "','" & moviant & "','" & timport2.Text & "','" & NROPTOVTA & "'"
                    Else
                        sql = "TMP_MOVIDETInsProc_lote " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ctipoing.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','0','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & tara & "','" & codmed & "'," & (tcosto.Text * txtcambio.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & tlote.Text.Trim.ToUpper & "','" & NroImportacion & "','" & moviant & "','" & timport2.Text & "','" & NROPTOVTA & "'"
                    End If
                End If
                PROCESO = TmpInsertDatos(sql)

            ElseIf est = False Then

                If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                        sql = "TMP_MOVIDETUpdProc_lote '" & calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',0," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & ",'" & codmed & "','" & tlote.Text.Trim.ToUpper & "','" & NroImportacion & "','" & moviant & "','" & timport2.Text & "'," & Item & ",'" & CodUsuario & "','" & NROPTOVTA & "'"
                    Else
                        sql = "TMP_MOVIDETUpdProc_lote '" & calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',0," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & ",'" & codmed & "','" & tlote.Text.Trim.ToUpper & "','" & NroImportacion & "','" & moviant & "','" & timport2.Text & "'," & Item & ",'" & CodUsuario & "','" & NROPTOVTA & "'"
                    End If
                Else
                    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                        sql = "TMP_MOVIDETUpdProc_lote '" & calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',0," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & codmed & "','" & tlote.Text.Trim.ToUpper & "','" & NroImportacion & "','" & moviant & "','" & timport2.Text & "'," & Item & ",'" & CodUsuario & "','" & NROPTOVTA & "'"
                    Else
                        sql = "TMP_MOVIDETUpdProc_lote '" & calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',0," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & codmed & "','" & tlote.Text.Trim.ToUpper & "','" & NroImportacion & "','" & moviant & "','" & timport2.Text & "'," & Item & ",'" & CodUsuario & "','" & NROPTOVTA & "'"
                    End If
                End If
                PROCESO = TmpInsertDatos(sql)
                est = True
            End If

            cargagrilla()
            Call limpia()
            Me.tlote.Focus()

        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub

    Private Sub tneto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tneto.KeyPress
        Try
            Dim Keyascii As Short = CShort(Asc(e.KeyChar))
            Keyascii = CShort(NumerosDecimales(Keyascii))
            If Keyascii = 0 Then
                e.Handled = True
                MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tneto.Focus()
            End If

            If Asc(e.KeyChar) = 13 Then
                'tbruto.Text = (Val(tneto.Text) + Val(ttara.Text)).ToString("###0.00")
                tbruto.Text = Format(CDbl(Me.tneto.Text.Trim) + (CDbl(Me.txtcantidad.Text.Trim) * CDbl(Me.ttara.Text.Trim)), "###0.00")
                If valorizado = True Then
                    tcosto.Focus()
                    tcosto.SelectAll()
                Else
                    Llena_temp()
                End If
            End If

        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Private Sub Combos()
        Me.ctipoing.SelectedIndex = 0
        Me.calmacen.SelectedIndex = 0
        Me.calmacen2.SelectedIndex = 0
        Me.ComboBox1.SelectedIndex = 0
        Me.ctipodoc.SelectedIndex = 0
        Me.cboref.SelectedIndex = 0
    End Sub
    Public INICIAS As Boolean
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Try
            flag = 0
            INICIAS = False
            elimina()
            Me.Button1.Enabled = False
            TOBS.Enabled = True
            Me.BTNCANCELAR.Enabled = True
            Me.BTNGUARDAR.Enabled = True
            Me.BTNNUEVO.Enabled = False
            Me.BTNELIMINAR.Enabled = False
            Me.btnmodificar.Enabled = False
            Me.grid1.Enabled = True
            Me.dtpfecha.Enabled = True
            desbloqueatextbox(Me)
            btnarticulo.Enabled = True
            btnproveedor.Enabled = True
            Me.dtpfvenc.Enabled = True
            sololectura()

            Conecta("select correlguia from tmp_correlguia where codempresa='" & codempresa & "' and tipo='SALIDA'", "correl")
            If ds.Tables("correl").Rows.Count = 0 Then
                correl = 1
                TmpInsertDatos("insert into tmp_correlguia values('" & correl & "','" & codempresa & "','SALIDA')")
            Else
                correl = Val(CType(ds.Tables("correl").Rows(ds.Tables("correl").Rows.Count - 1)(0), Integer) + 1)
                TmpInsertDatos("update tmp_correlguia set correlguia='" & correl & "' where codempresa='" & codempresa & "' AND TIPO='SALIDA'")
            End If

            CONT = 0

            If Me.tcodproveedor.Visible = False Then
                Me.tcodproveedor.Text = "HAL"
            End If
            If flag = 0 Then
                Conecta("select correlativo from tipomovi where codempresa='" & codempresa & "' and cdtipomov='" & Me.ctipoing.SelectedValue.ToString & "'", "indice")
                If ds.Tables("indice").Rows.Count > 0 Then
                    Me.tmovimiento.Text = Trim(ds.Tables("indice").Rows(0)(0))
                ElseIf Me.tmovimiento.Text.Trim = "" Then
                    MessageBox.Show("No existe correlativo para el tipo de Movimiento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            calmacen.SelectedValue = CDZONA
            Me.tdoc1.ReadOnly = True
            Me.TxtDocRef1.ReadOnly = False
            Call calmacen_SelectedIndexChanged(sender, e)
            Me.ctipoing.Focus()
            est = True
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Sub cargagrilla()
        If a1 = True And a2 = False Then
            Me.Ds_diferencia_de_reportes1.Clear()

            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',0,'" & correl & "',0,0,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',0,'" & correl & "',0,0,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',0,'" & correl & "',0,1,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',0,'" & correl & "',0,1,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                End If

            End If


            oda.Fill(Me.Ds_diferencia_de_reportes1.Tables(0))

            Dim i, a1, a2, a3 As Double
            CONT = Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count
            If Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count > 0 Then
                calmacen.Enabled = False
                ctipoing.Enabled = False
            Else
                calmacen.Enabled = True
                ctipoing.Enabled = True
            End If

            For i = 0 To Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count - 1
                a1 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(4))
                a2 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(5))
                a3 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(11))
            Next
            Me.totbruto.Text = a1.ToString("###0.00")
            Me.tottara.Text = a2.ToString("###0.00")
            Me.totneto.Text = Val(a1 - a2).ToString("###0.00")
            Me.tottotal.Text = a3.ToString("###0.00")

        ElseIf a1 = False And a2 = True Then
            Me.DsInventInicial1.Clear()

            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',1,'" & correl & "',0,0,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa1")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',1,'" & correl & "',0,0,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa1")
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',1,'" & correl & "',0,1,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa1")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',1,'" & correl & "',0,1,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa1")
                End If

            End If

            oda.Fill(Me.DsInventInicial1.Tables(0))
            CONT = Me.DsInventInicial1.Tables(0).Rows.Count
            Me.grid1.DataSource = Me.DsInventInicial1.Tables(0)


        ElseIf a1 = True And a2 = True Then

            Me.Ds_diferencia_de_reportes1.Clear()


            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',0,'" & correl & "',0,0,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")

                Else
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',0,'" & correl & "',0,0,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',0,'" & correl & "',0,1,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET_lote '" & codempresa & "',0,'" & correl & "',0,1,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                End If

            End If
            '''''
            Me.Ds_diferencia_de_reportes1.Tables(0).Clear()

            oda.Fill(Me.Ds_diferencia_de_reportes1.Tables(0))
            Me.grid1.DataSource = Me.Ds_diferencia_de_reportes1.Tables(0)


            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET_2_lote '" & codempresa & "','" & correl & "',0,0,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET_2_lote '" & codempresa & "','" & correl & "',0,0,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET_2_lote '" & codempresa & "','" & correl & "',0,1,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET_2_lote '" & codempresa & "','" & correl & "',0,1,'" & Me.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & NROPTOVTA & "'", "pa")
                End If

            End If

            'JJJJJJ
            'Me.Ds_diferencia_de_reportes1.Dsdifreporte.Clear()
            oda.Fill(Me.Ds_diferencia_de_reportes1.Tables(0))


            Me.grid1.DataSource = Me.Ds_diferencia_de_reportes1.Tables(0)

            CONT = Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count

            Dim i, a1, a2, a3 As Double
            For i = 0 To Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count - 1
                a1 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(4))
                a2 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(5))
                a3 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(11))
            Next
            Me.totbruto.Text = a1.ToString("###0.00")
            Me.tottara.Text = a2.ToString("###0.00")
            Me.totneto.Text = Val(a1 - a2).ToString("###0.00")
            Me.tottotal.Text = a3.ToString("###0.00")

        End If


    End Sub

    Sub tcambio()
        Conecta("select tventa from cambio where fecha='" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "' and codempresa='" & codempresa & "'", "tcambio")
        If ds.Tables("tcambio").Rows.Count = 0 Then
            Conecta("select tventa from cambio where codempresa='" & codempresa & "' order by fecha", "tcambio2")
            If ds.Tables("tcambio2").Rows.Count > 0 Then
                Me.txtcambio.Text = ds.Tables("tcambio2").Rows(0)(0)
            End If
        Else
            Me.txtcambio.Text = ds.Tables("tcambio").Rows(0)(0)
        End If
    End Sub
    Dim Item As Integer
    Private Sub Item_Grilla()
        Try
            tumedida.Items.Clear()
            medida.Clear()
            Item = grid1.Item(grid1.CurrentRowIndex, 0)
            tarticulo.Text = grid1.Item(grid1.CurrentRowIndex, 1)
            Me.tmarca.Text = grid1.Item(grid1.CurrentRowIndex, 2)
            txtdesarticulo.Text = grid1.Item(grid1.CurrentRowIndex, 3)
            Me.txtcantidad.Text = grid1.Item(grid1.CurrentRowIndex, 5)


            If (a1 = True And a2 = False) Or (a1 = True And a2 = True) Then

                tbruto.Text = grid1.Item(grid1.CurrentRowIndex, 6)
                ttara.Text = grid1.Item(grid1.CurrentRowIndex, 7)
                tneto.Text = grid1.Item(grid1.CurrentRowIndex, 8)
                Me.tcosto.Text = grid1.Item(grid1.CurrentRowIndex, 9)
                ttotal.Text = grid1.Item(grid1.CurrentRowIndex, 10)
                Me.dtpfvenc.Value = grid1.Item(grid1.CurrentRowIndex, 11)
                Me.tlote.Text = grid1.Item(grid1.CurrentRowIndex, 12)
                'Me.tlote.Text = grid1.Item(grid1.CurrentRowIndex, 13)
                Me.timport2.Text = grid1.Item(grid1.CurrentRowIndex, 14)

                Conecta("NSP_SELEC_medidas '" & codempresa & "','" & tarticulo.Text.Trim & "',0", "llena")
                If ds.Tables("llena").Rows.Count > 0 Then
                    For i = 0 To ds.Tables("llena").Rows.Count - 1
                        medida.Add(Trim(ds.Tables("llena").Rows(i)(0)))
                        tumedida.Items.Add(Trim(ds.Tables("llena").Rows(i)(1)))
                        tara = Trim(ds.Tables("llena").Rows(i)(2))
                    Next
                End If

            ElseIf a1 = False And a2 = True Then

                tneto.Text = grid1.Item(grid1.CurrentRowIndex, 6)
                Me.tcosto.Text = grid1.Item(grid1.CurrentRowIndex, 7)
                ttotal.Text = grid1.Item(grid1.CurrentRowIndex, 8)
                Me.dtpfvenc.Value = grid1.Item(grid1.CurrentRowIndex, 9)
                tumedida.Items.Add(grid1.Item(grid1.CurrentRowIndex, 4))
                Me.tlote.Text = grid1.Item(grid1.CurrentRowIndex, 10)
                Me.timports.Text = grid1.Item(grid1.CurrentRowIndex, 11)
                Me.timport2.Text = grid1.Item(grid1.CurrentRowIndex, 12)

                Conecta("NSP_SELEC_medidas '" & codempresa & "','" & tarticulo.Text.Trim & "',1", "llena")
                If ds.Tables("llena").Rows.Count > 0 Then
                    medida.Add(Trim(ds.Tables("llena").Rows(0)(0)))
                    tumedida.Items.Add(Trim(ds.Tables("llena").Rows(0)(1)))
                    tara = Trim(ds.Tables("llena").Rows(i)(2))
                End If

            End If

            tumedida.Text = grid1.Item(grid1.CurrentRowIndex, 4)

            txtcantidad.Focus()
            txtcantidad.SelectAll()

        Catch x As Exception
        End Try
    End Sub
    Dim i As Int16
    Private Sub tarticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tarticulo.KeyPress

    End Sub

    Sub limpia()
        tarticulo.Text = Nothing
        txtdesarticulo.Text = Nothing
        tmarca.Text = Nothing
        dtpfvenc.Value = Now
        txtcantidad.Text = 0
        timports.Text = Nothing
        timport2.Text = Nothing
        tumedida.Items.Clear()
        tbruto.Text = 0
        ttara.Text = 0
        tneto.Text = 0
        tcosto.Text = 0
        ttotal.Text = 0
        Me.tlote.Text = ""
    End Sub
    Private Sub ttara_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ttara.TextChanged
        Try
            Me.tneto.Text = Val(Me.tbruto.Text - Me.ttara.Text).ToString("###0.00")
            Me.tneto.Focus()
            Me.tneto.SelectAll()
        Catch x As Exception
        End Try
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    Private Sub Limpia_Temporal()
        TmpInsertDatos("DELETE FROM TMP_MOVIDET WHERE CORRNBR = " & IIf(Len(Me.tmovimiento.Text.Trim) = 0, 0, Me.tmovimiento.Text.Trim).ToString() & " AND USUARIO = '" & CodUsuario.ToString() & "' AND INOUT = 0")
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Call Limpia_Temporal()
        Me.Button1.Enabled = True
        TOBS.Enabled = False
        BTNNUEVO.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNCANCELAR.Enabled = False
        Bloqueatextbox(Me)
        btnarticulo.Enabled = False
        btnproveedor.Enabled = False
        Me.dtpfvenc.Enabled = False
        Me.dtpfecha.Enabled = False
        sololectura()
        'Call Combos()
        Me.TxtDocRef1.ReadOnly = False
    End Sub

    Sub sololectura()
        Me.tproveedor.ReadOnly = True
        Me.tmovimiento.ReadOnly = True
        Me.txtdesarticulo.ReadOnly = True
        Me.tumedida.Enabled = False
        Me.tmarca.ReadOnly = True
        Me.ttara.ReadOnly = True
        Me.totbruto.ReadOnly = True
        Me.tottara.ReadOnly = True
        Me.totneto.ReadOnly = True
        Me.tottotal.ReadOnly = True
        Me.timports.ReadOnly = True
        Me.timport2.ReadOnly = True
        ttotal.ReadOnly = True

        Limpiatextbox(Me)
        Me.Ds_diferencia_de_reportes1.Clear()
        Me.DsInventInicial1.Clear()
        Me.grid1.Refresh()
        Me.totbruto.Text = 0
        Me.tottara.Text = 0
        Me.tottotal.Text = 0
        Me.tcosto.Text = 0
        Me.ttotal.Text = 0
        Me.totneto.Text = 0
        Me.txtcantidad.Text = 0
        Me.tbruto.Text = 0
        Me.ttara.Text = 0
        Me.tneto.Text = 0

    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        'Dim clsinter As New clsdatos_JHON
        Dim INGRESO As Boolean = True
        If Me.DsInventInicial1.Tables(0).Rows.Count = 0 And Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Falta ingresar información", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If calmacen.SelectedValue.ToString = calmacen2.SelectedValue.ToString And calmacen2.Visible = True Then
            MessageBox.Show("No puede trasladar Mercaderia a un mismo almacén", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.tcodproveedor.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Proveedor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tdoc1.Text.Trim = "" Or tdoc2.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Nro de documento", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Button1.Enabled = True
        Me.dtpfecha.Enabled = False
        BTNNUEVO.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNELIMINAR.Enabled = False
        TOBS.Enabled = False

        Dim sql As String
        Dim PROCESO As Boolean
        Call formatotextbox(Me)
        Dim dia As Double

        If Me.ctipocred.Visible = True Then
            Conecta("select nrdias from TIPCREDF where cod_empresa='" & codempresa & "' and tipcredfac='" & ctipocred.SelectedValue.ToString & "'", "CALCULA")
            If ds.Tables("calcula").Rows.Count > 0 Then
                dia = ds.Tables("calcula").Rows(0)(0)
            End If
        End If

        If flag = 0 Then
            'determinamos el tipo de precio de acuerdo al configinv
            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    If salida = True Then
                        sql = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',0,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & ctipoprecio.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.txtcambio.Text & ",0,0," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.calmacen2.SelectedValue.ToString & "'," & VA1 & "," & VA2 & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                    Else
                        sql = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',0,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & ctipoprecio.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.txtcambio.Text & ",0,0," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.calmacen2.SelectedValue.ToString & "'," & VA1 & "," & VA2 & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                    End If
                Else
                    If salida = True Then
                        sql = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',0,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & ctipoprecio.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.txtcambio.Text & ",0,0," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.calmacen2.SelectedValue.ToString & "'," & VA1 & "," & VA2 & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                    Else
                        sql = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',0,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & ctipoprecio.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.txtcambio.Text & ",0,0," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.calmacen2.SelectedValue.ToString & "'," & VA1 & "," & VA2 & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                    End If
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    If salida = True Then
                        sql = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',0,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & ctipoprecio.SelectedValue.ToString & "'," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & "," & Me.txtcambio.Text & ",0,0," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.calmacen2.SelectedValue.ToString & "'," & VA1 & "," & VA2 & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                    Else
                        sql = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',0,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & ctipoprecio.SelectedValue.ToString & "'," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & "," & Me.txtcambio.Text & ",0,0," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.calmacen2.SelectedValue.ToString & "'," & VA1 & "," & VA2 & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                    End If
                Else
                    If salida = True Then
                        sql = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',0,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & ctipoprecio.SelectedValue.ToString & "'," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & "," & Me.txtcambio.Text & ",0,0," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.calmacen2.SelectedValue.ToString & "'," & VA1 & "," & VA2 & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                    Else
                        sql = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ctipoing.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',0,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & ctipoprecio.SelectedValue.ToString & "'," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & "," & Me.txtcambio.Text & ",0,0," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.calmacen2.SelectedValue.ToString & "'," & VA1 & "," & VA2 & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                    End If
                End If
            End If

            If TmpInsertDatos(sql) = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & tmovimiento.Text & "','INSERT','GUIASAL_OTROS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Call BOTONES(True, False, False, False, False)
                Bloqueatextbox(Me)
                Me.grid1.Enabled = False
            End If

            TmpInsertDatos("update tipomovi set correlativo = correlativo + 1 where codempresa='" & codempresa & "' and cdtipomov='" & Me.ctipoing.SelectedValue.ToString & "'")

        Else

            TmpInsertDatos("DELETE FROM COMPRASCRED WHERE nroingreso='" & Me.tmovimiento.Text.Trim & "' AND CODEMPRESA='" & codempresa & "'")

            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) & "-" & CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ctipoing.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen2.SelectedValue.ToString & "',0,'" & Me.ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & ",'" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                Else
                    sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) & "-" & CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ctipoing.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen2.SelectedValue.ToString & "',0,'" & Me.ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) & "-" & CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ctipoing.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen2.SelectedValue.ToString & "',0,'" & Me.ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                Else
                    sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) & "-" & CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ctipoing.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen2.SelectedValue.ToString & "',0,'" & Me.ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'" & tmovimiento.Text & "','" & Me.ComboBox1.SelectedValue.ToString & "','','','" & TxtDocRef1.Text & "-" & TREF.Text & "','" & cboref.SelectedValue.ToString & "'"
                End If
            End If

            If TmpInsertDatos(sql) = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & tmovimiento.Text & "','UPDATE','GUIASAL_OTROS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Call BOTONES(True, False, False, False, False)
                Bloqueatextbox(Me)
                Me.grid1.Enabled = False
            End If

            TmpInsertDatos("delete from movidet where nromovi='" & Me.tmovimiento.Text & "' and codempresa='" & codempresa & "' and cdtipomov='" & Me.ctipoing.SelectedValue.ToString & "' and inout=0")

            Conecta("select nromovi,nroimp,bultos,neto,codarti from salidasvssaldos where nromovsal='" & tmovimiento.Text.Trim.ToUpper & "' and codempresa='" & codempresa & "'", "act")
            If ds.Tables("act").Rows.Count > 0 Then
                For o = 0 To ds.Tables("act").Rows.Count - 1
                    Conecta("select saldobultos,saldont from saldos_importacion where nroimportacion=" & Trim(ds.Tables("act").Rows(o)(1)) & " and nromov='" & Trim(ds.Tables("act").Rows(o)(0)) & "' and codarti='" & Trim(ds.Tables("act").Rows(o)(4)) & "'", "ax")
                    If ds.Tables("ax").Rows.Count > 0 Then
                        TmpInsertDatos("update saldos_importacion set saldobultos=" & Val(ds.Tables("ax").Rows(0)(0) + ds.Tables("act").Rows(o)(2)) & ",saldont=" & Val(ds.Tables("ax").Rows(0)(1) + ds.Tables("act").Rows(o)(3)) & " where nroimportacion=" & Trim(ds.Tables("act").Rows(o)(1)) & " and nromov='" & Trim(ds.Tables("act").Rows(o)(0)) & "' and codarti='" & Trim(ds.Tables("act").Rows(o)(4)) & "'")
                    End If
                Next
            End If

            TmpInsertDatos("delete from salidasvssaldos where nromovsal='" & Me.tmovimiento.Text.Trim & "' and codempresa='" & codempresa & "'")

        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''
        sql = "NSP_ins_MOvidet_sal '" & correl & "','" & codempresa & "','" & Me.tmovimiento.Text & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "',0,'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "'"
        PROCESO = TmpInsertDatos(sql)

        If ntacred = Trim(Me.ctipoing.SelectedValue.ToString) Then
            TmpInsertDatos("NSP_ins_comprascred_sal '" & codempresa & "','" & tmovimiento.Text.Trim & "'")
        End If

        '''''''''''''''''''''PREGUNTA DE SI DESEA GENERAR INGRESO A SUB CAMARA''''''''''''''''''''''''''''''''''''''
        If ctipoing.SelectedValue.ToString() = CODSALTRANSUBCAM Then
            Dim preguntar As String
            If flag = 0 Then preguntar = "¿Desea Generar el Ingreso a la SubCamara?" Else preguntar = "¿Desea Modificar en Ingreso a la SubCamara?"
            INGRESO = False
            If MessageBox.Show(preguntar.ToString, "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim resultado As Boolean
                resultado = TmpInsertDatos("SP_CREA_INGRESO_DE_SALIDA " & tmovimiento.Text & ",'" & calmacen.SelectedValue & "','" & ctipoing.SelectedValue & "'," & flag)



                If resultado Then

                    INGRESO = True
                    Conecta("SELECT CDSUBZONA,NROPTOVTA FROM PTOVTA WHERE CDZONA='" & Trim(calmacen.SelectedValue) & "'", "sUBaLMACEN")
                    If ds.Tables("sUBaLMACEN").Rows.Count > 0 Then
                        SUBALMACEN = ds.Tables("sUBaLMACEN").Rows(0)(0)
                        PTOVTA = ds.Tables("sUBaLMACEN").Rows(0)(1)
                    Else
                        SUBALMACEN = ""
                        PTOVTA = ""
                    End If
                    Conecta("select * from movidet where nromovi=" & tmovimiento.Text & " and cdalmacen='" & Trim(calmacen.SelectedValue) & "' and cdtipomov='" & Trim(ctipoing.SelectedValue) & "'", "Movi")
                    Dim CONT As Integer
                    CONT = ds.Tables("Movi").Rows.Count - 1
                    'MsgBox(CONT.ToString)
                    If ds.Tables("Movi").Rows.Count > 0 Then
                        'Me.BindingContext(ds.Tables("Movi")).Position = 0

                        'For n As Integer = 0 To CONT
                        '    'Conecta("SELECT MAX(FECHAVENCIMIENTO) FROM SALDOS_IMPORTACION where codarti='" & articulo.ToString & "' and nroimportacion='" & nroimportacion.ToString & "'", "MAXfECHA")
                        '    'If ds.Tables("MAXfECHA").Rows.Count > 0 Then
                        '    '    FECHAMAX = Format(ds.Tables("MAXfECHA").Rows(0).Item(0), "MM/dd/yyyy")
                        '    '    'PROCEDIMIENTO PARA BUSCAR LA FECHA DE VENCIMIENTO PARA INSETARLOS EN SALDOS DE IMPORTACION

                        '    'End If
                        '    Dim CANTIDADES As Decimal
                        '    articulo = ds.Tables("Movi").Rows(n).Item("cdarticulo")
                        '    lote = ds.Tables("Movi").Rows(n).Item("lote")
                        '    nroimportacion = ds.Tables("Movi").Rows(n).Item("nroimportacion")
                        '    CANTIDADES = ds.Tables("Movi").Rows(n).Item("CANTIDAD")
                        '    'VERIFICO SE ESTA EN LA TABLA SALDOS DE IMPORTACION  PARA INSERTAR Y/0 ACTUALIZAR
                        '    Conecta("select * from saldos_importacion where codarti='" & articulo.ToString & "' and nroimportacion=" & nroimportacion.ToString & " and cdalmacen='" & SUBALMACEN.ToString & "' and nlote=" & lote.ToString, "veRIFICA")
                        '    If ds.Tables("veRIFICA").Rows.Count > 0 Then ' SI EN CASO HAY REGISTRO CON ESOS PARAMETROS LO ACTUALIZAMO 
                        '        clsinter.insert_store("UPDATE SALDOS_IMPORTACION SET SALDOSBULTOS=SALDOSBULTOS+" & CANTIDADES & ",pesoneto=pesoneto+" & ds.Tables("Movi").Rows(n)("tneto") & ",saldont=saldont+" & ds.Tables("Movi").Rows(n)("tneto") & " BULTOS=BULTOS+ " & CANTIDADES & " WHERE codarti='" & articulo.ToString & "' and nroimportacion=" & nroimportacion.ToString & " AND  cdalmacen=" & SUBALMACEN.ToString.Trim & " and nlote=" & lote.ToString & "")

                        '    Else ' CASO COMTRARIO LO INSERTAMOS
                        '        clsinter.insert_store("INSERT INTO SALDOS_IMPORTACION(CODARTI, NROIMPORTACION, BULTOS, SALDOBULTOS, PESONETO, SALDONT, FECHAVENCIMIENTO, COSTOBAS, COSTOEXT, CDALMACEN, NROPTOVTA, FRECIBO,  NROMOV, NLOTE, tipo)" & _
                        '                              "SELECT	CDARTICULO,NROIMPORTACION, CANTIDAD,CANTIDAD,TNETO,TNETO, FECDOCUM, COSTOBAS, COSTOEXT,'" & SUBALMACEN.ToString.Trim & "','" & PTOVTA.ToString.Trim & "','" & Format(dtpfecha.Value, "MM/dd/yyy").ToString & "'," & _
                        '                              tmovimiento.Text.Trim.ToString & ",LOTE,1 FROM MOVIDET where nromovi=" & tmovimiento.Text & " and cdalmacen='" & Trim(calmacen.SelectedValue) & "' and cdtipomov='" & Trim(ctipoing.SelectedValue) & "' AND CDARTICULO='" & articulo.ToString & "'")

                        '    End If
                        'Next


                    End If

                    MsgBox("Ingreso registrado Correctamente", MsgBoxStyle.Information, "NarSistemas")
                Else
                    MsgBox("Ingreso no registrado", MsgBoxStyle.Information, "NarSistemas")
                End If
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''REGISTRA LA SALIDA DE TRANSFERENCIA'''''''''''''''''''''''''''''''''''''''''''
        If ctipoing.SelectedValue = CODSALTRANS Then

            Dim resultado As Boolean
            resultado = TmpInsertDatos("SP_REGISTRA_SALIDA_TRANSFERENCIA " & tmovimiento.Text & ",'" & ctipoing.SelectedValue & "'")
            If resultado Then
                INGRESO = True
            Else
                MsgBox("No se registro la transferencia", MsgBoxStyle.Information, "NarSistemas")
            End If
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim ia, ca As Integer, a, b, az, b1 As Double
        If (a1 = True And a2 = False) Or (a1 = True And a2 = True) Then

            For ia = 0 To Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count - 1

                Conecta("select pesoneto,saldont,bultos,saldobultos,frecibo,nroimportacion,nromov from saldos_importacion where cdalmacen='" & calmacen.SelectedValue.ToString & "' and codarti='" & CAyuda.ValidaNullSTring(grid1.Item(ia, 1)) & "' and nlote = '" & CAyuda.ValidaNullSTring(Me.grid1.Item(ia, 12)) & "' order by frecibo", "llena")
                If ds.Tables("llena").Rows.Count > 0 Then

                    a = CAyuda.ValidaNullsInteger(grid1.Item(ia, 8))
                    b = CAyuda.ValidaNullsInteger(grid1.Item(ia, 5))

                    For ca = 0 To ds.Tables("llena").Rows.Count - 1
                        If (a > Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(1))) Or b > Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(3)))) Then
                            az = Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(1))) - a
                            b1 = Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(3))) - b

                            If az < 0 Then
                                az = 0
                            End If

                            If b1 < 0 Then
                                b1 = 0
                            End If
                            If INGRESO = True Then
                                TmpInsertDatos("UPDATE SALDOS_IMPORTACION SET SALDOBULTOS=" & az & ",SALDONT=" & b1 & " where codarti='" & grid1.Item(ia, 1) & "' and nroimportacion=" & CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(5)) & " and cdalmacen='" & calmacen.SelectedValue.ToString & "' and frecibo='" & Format((ds.Tables("llena").Rows(ca)(4)), "MM/dd/yy") & "'")
                            End If
                            TmpInsertDatos("insert into salidasvssaldos (nromovsal,nromovi,nroimp,bultos,neto,codempresa,codarti) values ('" & tmovimiento.Text.Trim.ToUpper & "','" & CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(6)) & "','" & CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(5)) & "'," & Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(3))) & "," & Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(1))) & ",'" & codempresa & "','" & grid1.Item(ia, 1) & "')")
                            a = a - Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(1)))
                            b = b - Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(3)))

                            If a < 0 Then
                                a = 0
                            End If

                            If b < 0 Then
                                b = 0
                            End If
                        Else
                            If INGRESO = True Then
                                TmpInsertDatos("UPDATE SALDOS_IMPORTACION SET SALDOBULTOS=" & Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(3)) - b) & ",SALDONT=" & Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(1)) - a) & " where codarti='" & grid1.Item(ia, 1) & "' and nroimportacion=" & Trim(ds.Tables("llena").Rows(ca)(5)) & " and cdalmacen='" & calmacen.SelectedValue.ToString & "' and frecibo='" & Format((ds.Tables("llena").Rows(ca)(4)), "MM/dd/yy") & "'")
                            End If
                            TmpInsertDatos("insert into salidasvssaldos (nromovsal,nromovi,nroimp,bultos,neto,codempresa,codarti) values ('" & tmovimiento.Text.Trim.ToUpper & "','" & CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(6)) & "','" & CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(5)) & "'," & CAyuda.ValidaNullsInteger(b) & "," & CAyuda.ValidaNullsInteger(a) & ",'" & codempresa & "','" & CAyuda.ValidaNullSTring(grid1.Item(ia, 1)) & "')")
                            a = 0
                            b = 0
                        End If
                    Next
                End If
            Next
        ElseIf a1 = False And a2 = True Then

            For ia = 0 To Me.DsInventInicial1.Tables(0).Rows.Count - 1
                Conecta("select pesoneto,saldont,bultos,saldobultos,frecibo,nroimportacion,nromov from saldos_importacion where cdalmacen='" & calmacen.SelectedValue.ToString & "' and codarti='" & grid1.Item(ia, 1) & "' order by frecibo", "llena")
                If ds.Tables("llena").Rows.Count > 0 Then

                    a = CAyuda.ValidaNullsInteger(grid1.Item(ia, 6))
                    b = CAyuda.ValidaNullsInteger(grid1.Item(ia, 4))

                    For ca = 0 To ds.Tables("llena").Rows.Count - 1
                        'If a > Val(ds.Tables("llena").Rows(ca)(0)) Then

                        If (a > Val(ds.Tables("llena").Rows(ca)(1)) Or b > Val(ds.Tables("llena").Rows(ca)(3))) Then

                            az = Val(ds.Tables("llena").Rows(ca)(1)) - a
                            b1 = Val(ds.Tables("llena").Rows(ca)(3)) - b

                            If az < 0 Then
                                az = 0
                            End If

                            If b1 < 0 Then
                                b1 = 0
                            End If

                            TmpInsertDatos("UPDATE SALDOS_IMPORTACION SET SALDOBULTOS=" & CAyuda.ValidaNullsInteger(az) & ",SALDONT=" & CAyuda.ValidaNullsInteger(b1) & " where codarti='" & grid1.Item(ia, 1) & "' and nroimportacion=" & CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(5)) & " and cdalmacen='" & calmacen.SelectedValue.ToString & "' and frecibo='" & Format((ds.Tables("llena").Rows(ca)(4)), "MM/dd/yy") & "'")
                            TmpInsertDatos("insert into salidasvssaldos (nromovsal,nromovi,nroimp,bultos,neto,codempresa,codarti) values ('" & tmovimiento.Text.Trim.ToUpper & "','" & ds.Tables("llena").Rows(ca)(6) & "','" & ds.Tables("llena").Rows(ca)(5) & "'," & Val(ds.Tables("llena").Rows(ca)(3)) & "," & Val(ds.Tables("llena").Rows(ca)(1)) & ",'" & codempresa & "','" & grid1.Item(ia, 1) & "')")
                            b = b - Val(ds.Tables("llena").Rows(0)(3))
                            a = a - Val(ds.Tables("llena").Rows(ca)(1))

                            If a < 0 Then
                                a = 0
                            End If

                            If b < 0 Then
                                b = 0
                            End If
                        Else
                            TmpInsertDatos("UPDATE SALDOS_IMPORTACION SET SALDOBULTOS=" & Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(0)(3)) - b) & ",SALDONT=" & Val(CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(1)) - a) & " where codarti='" & grid1.Item(ia, 1) & "' and nroimportacion=" & CAyuda.ValidaNullsInteger(ds.Tables("llena").Rows(ca)(5)) & " and cdalmacen='" & calmacen.SelectedValue.ToString & "' and frecibo='" & Format((ds.Tables("llena").Rows(ca)(4)), "MM/dd/yy") & "'")
                            TmpInsertDatos("insert into salidasvssaldos (nromovsal,nromovi,nroimp,bultos,neto,codemp,codarti) values ('" & tmovimiento.Text.Trim.ToUpper & "','" & ds.Tables("llena").Rows(ca)(6) & "','" & ds.Tables("llena").Rows(ca)(5) & "'," & b & "," & a & ",'" & codempresa & "','" & grid1.Item(ia, 1) & "')")
                            a = 0
                            b = 0
                        End If
                    Next
                End If
            Next
        End If

        Call Limpia_Temporal()
        Call elimina()
        CONT = 0
        BTNCANCELAR.Enabled = False
        Me.TxtDocRef1.ReadOnly = False
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal ANULAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnmodificar.Enabled = MODIFICAR
        BTNANULAR.Enabled = ANULAR
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BTNNUEVO.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNCANCELAR.Enabled = False
        Bloqueatextbox(Me)
        btnarticulo.Enabled = False
        btnproveedor.Enabled = False
        Me.dtpfvenc.Enabled = False
        Me.dtpfecha.Enabled = False
        sololectura()

        elimina()
        Dim men As New frm_guiaingreso
        men.boingresoguiaing = False
        men.vie2 = Me
        men.ShowDialog()
        If tmovimiento.Text.Trim <> "" Then
            If CAyuda.ListarDatos("SP_VERF_EST_SALIDA", tmovimiento.Text.Trim, ctipoing.SelectedValue, tdoc1.Text.Trim & "-" & tdoc2.Text.Trim, calmacen.SelectedValue.TRIM).Tables(0).Rows(0)(0) = 1 Then
                MsgBox("El documento tiene el estado de anulado, Gracias...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                Call BOTONES(True, False, False, False, False)
                Bloqueatextbox(Me)
                Me.grid1.Enabled = False
            End If
        End If
    End Sub

    Public Sub llenaproveedor()
        Conecta("select codproveedor,desproveedor,ruc,direccion from proveedor where codempresa='" & codempresa & "'and estado=0 and codproveedor='" & Me.tcodproveedor.Text.Trim & "'", "pa")
        If ds.Tables("pa").Rows.Count > 0 Then
            tcodproveedor.Text = Trim(ds.Tables("pa").Rows(0)(0))
            tproveedor.Text = Trim(ds.Tables("pa").Rows(0)(1))
            'Me.timportacion.Focus()
        Else
            'MessageBox.Show("Proveedor no Encontrado", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.tcodproveedor.Focus()
            'Me.tcodproveedor.SelectAll()
            tcodproveedor.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(0))
            tproveedor.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(1))

        End If
    End Sub

    Private Sub tcodproveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodproveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then

            If tcodproveedor.Text.Trim = "" Then
                BTNCLIENTE_Click(sender, e)
            Else
                llenaproveedor()
            End If

            If ctipocred.Visible = True Then
                ctipocred.Focus()
            Else
                tarticulo.Focus()
                tarticulo.SelectAll()
            End If
        End If
    End Sub
    Private Sub frm_guiaingmercaderia_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Call Limpia_Temporal()
        INICIAS = False
        elimina()
    End Sub
    Sub elimina()
        Try
            TmpInsertDatos("DELETE FROM TMP_MOVIDET WHERE CORRNBR = " & Val(Me.tmovimiento.Text.Trim) & " AND INOUT = 0")
            'Me.Ds_diferencia_de_reportes1.Dsdifreporte.Clear()
            'Me.DsInventInicial1.ds_inventini.Clear()
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Dim o, x As Integer
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If MessageBox.Show("¿Desea eliminar el presente registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Conecta("SELECT * FROM TRANSFERCAB WHERE MOVIMIENTO = " & Me.tmovimiento.Text.Trim & " AND ESTADO = 1", "x")
            If ds.Tables("x").Rows.Count > 0 Then
                MsgBox("No se Puede Eliminar Este Nro de Salida" + Chr(13) + "Por que Ya Fue Transferido", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
                Exit Sub
            End If
            Conecta("select nromovi,nroimp,bultos,neto,codarti from salidasvssaldos where nromovsal='" & tmovimiento.Text.Trim.ToUpper & "' and codempresa='" & codempresa & "'", "act")
            If ds.Tables("act").Rows.Count > 0 Then
                For o = 0 To ds.Tables("act").Rows.Count - 1
                    Conecta("select saldobultos,saldont from saldos_importacion where nroimportacion=" & Trim(ds.Tables("act").Rows(o)(1)) & " and nromov='" & Trim(ds.Tables("act").Rows(o)(0)) & "' and codarti='" & Trim(ds.Tables("act").Rows(o)(4)) & "'", "ax")
                    If ds.Tables("ax").Rows.Count > 0 Then
                        TmpInsertDatos("update saldos_importacion set saldobultos=" & Val(ds.Tables("ax").Rows(0)(0) + ds.Tables("act").Rows(o)(2)) & ",saldont=" & Val(ds.Tables("ax").Rows(0)(1) + ds.Tables("act").Rows(o)(3)) & " where nroimportacion=" & Trim(ds.Tables("act").Rows(o)(1)) & " and nromov='" & Trim(ds.Tables("act").Rows(o)(0)) & "' and codarti='" & Trim(ds.Tables("act").Rows(o)(4)) & "'")
                    End If
                Next
            End If

            If ctipoing.SelectedValue = CODSALTRANSUBCAM Then
                Conecta("Select nrodoc from movicab where nromovi=" & Me.tmovimiento.Text.Trim & " AND INOUT = 0", "Mvi")
                Conecta("Select * from movicab where nrodoc='" & ds.Tables("Mvi").Rows(0)(0) & "' and inout=1", "Movidet")
                TmpInsertDatos("DELETE FROM MOVIDET WHERE NROMOVI = " & ds.Tables("Movidet").Rows(0)("nromovi") & " AND INOUT = 1")
                TmpInsertDatos("DELETE FROM MOVICAB WHERE NROMOVI = " & ds.Tables("Movidet").Rows(0)("nromovi") & " AND INOUT = 1")
            End If

            TmpInsertDatos("delete from salidasvssaldos where nromovsal='" & Me.tmovimiento.Text.Trim & "' and codempresa='" & codempresa & "'")
            TmpInsertDatos("DELETE FROM MOVIDET WHERE NROMOVI = " & Me.tmovimiento.Text.Trim & " AND INOUT = 0")
            TmpInsertDatos("DELETE FROM MOVICAB WHERE NROMOVI = " & Me.tmovimiento.Text.Trim & " AND INOUT = 0")
            TmpInsertDatos("DELETE FROM TRANSFERCAB WHERE MOVIMIENTO = " & Me.tmovimiento.Text.Trim & "")
            TmpInsertDatos("DELETE FROM TRANSFERDET WHERE MOVIMIENTO = " & Me.tmovimiento.Text.Trim & "")

            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & tmovimiento.Text & "','DELETE','GUIASAL_OTROS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Call Limpia_Temporal()
            Call elimina()
            BTNNUEVO.Enabled = True
            BTNGUARDAR.Enabled = False
            BTNCANCELAR.Enabled = False
            Bloqueatextbox(Me)
            btnarticulo.Enabled = False
            btnproveedor.Enabled = False
            Me.dtpfvenc.Enabled = False
            sololectura()
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNANULAR.Click
        If MessageBox.Show("¿Desea Anular el presente documento?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            Conecta("select nromovi,nroimp,bultos,neto,codarti from salidasvssaldos where nromovsal='" & tmovimiento.Text.Trim.ToUpper & "' and codempresa='" & codempresa & "'", "act")
            If ds.Tables("act").Rows.Count > 0 Then
                For o = 0 To ds.Tables("act").Rows.Count - 1
                    Conecta("select saldobultos,saldont from saldos_importacion where nroimportacion=" & Trim(ds.Tables("act").Rows(o)(1)) & " and nromov='" & Trim(ds.Tables("act").Rows(o)(0)) & "' and codarti='" & Trim(ds.Tables("act").Rows(o)(4)) & "'", "ax")
                    If ds.Tables("ax").Rows.Count > 0 Then
                        TmpInsertDatos("update saldos_importacion set saldobultos=" & Val(ds.Tables("ax").Rows(0)(0) + ds.Tables("act").Rows(o)(2)) & ",saldont=" & Val(ds.Tables("ax").Rows(0)(1) + ds.Tables("act").Rows(o)(3)) & " where nroimportacion=" & Trim(ds.Tables("act").Rows(o)(1)) & " and nromov='" & Trim(ds.Tables("act").Rows(o)(0)) & "' and codarti='" & Trim(ds.Tables("act").Rows(o)(4)) & "'")
                    End If
                Next
            End If
            If ctipoing.SelectedValue = CODSALTRANSUBCAM Then
                Conecta("Select nrodoc from movicab where nromovi=" & Me.tmovimiento.Text.Trim & " AND INOUT = 0", "Mvi")
                Conecta("Select * from movicab where nrodoc='" & ds.Tables("Mvi").Rows(0)(0) & "' and inout=1", "Movidet")
                TmpInsertDatos("update  MOVIDET set estado='1' WHERE NROMOVI = " & ds.Tables("Movidet").Rows(0)("nromovi") & " AND INOUT = 1")
                TmpInsertDatos("update  MOVICAB set estado='1' WHERE NROMOVI = " & ds.Tables("Movidet").Rows(0)("nromovi") & " AND INOUT = 1")
            End If
            'TmpInsertDatos("delete from salidasvssaldos where nromovsal='" & Me.tmovimiento.Text.Trim & "' and codempresa='" & CodEmpresa & "'")
            TmpInsertDatos("UPDATE  movidet SET estado='1' where cdcompra='" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "' and codempresa='" & codempresa & "' and inout=0")
            TmpInsertDatos("UPDATE  movicab SET estado='1' where nrodoc='" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "' and nromovi=" & Me.tmovimiento.Text.Trim & " AND CODEMPRESA = '" & COEMPRESA & "  and inout=0")
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & tmovimiento.Text & "','ANULAR','GUIASAL_OTROS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")

            BTNNUEVO.Enabled = True
            BTNGUARDAR.Enabled = False
            BTNCANCELAR.Enabled = False
            Bloqueatextbox(Me)
            btnarticulo.Enabled = False
            btnproveedor.Enabled = False
            Me.dtpfvenc.Enabled = False
            sololectura()
        End If
    End Sub

    Private Sub ctipoing_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipoing.KeyPress
        If Asc(e.KeyChar) = 13 Then
            calmacen.Focus()
        End If
    End Sub

    Private Sub ctipodoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipodoc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdoc2.Focus()
        End If
    End Sub

    Private Sub calmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles calmacen.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If calmacen2.Visible = True Then
                calmacen2.Focus()
            ElseIf Me.ComboBox1.Visible = True Then
                Me.ComboBox1.Focus()
            Else
                Me.ctipodoc.Focus()
            End If
        End If
    End Sub

    Private Sub tarticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tarticulo.KeyDown
        If e.KeyCode = Keys.F2 Then
            If Me.tdoc1.Text.Trim = "" Or Me.tdoc2.Text.Trim = "" Then
                MessageBox.Show("Ingrese el Número del Documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Me.tdoc1.Text = Format(Val(Me.tdoc1.Text.Trim), "000")
                Me.tdoc2.Text = Format(Val(Me.tdoc2.Text.Trim), "0000000")

            End If


            If tproveedor.Visible = False Then
                forma = 0
            Else
                forma = 2
            End If

            Dim men As New frm_grid_articulo_otro
            men.vie2 = Me
            men.ShowDialog()

        ElseIf e.KeyCode = Keys.Enter Then
            If Len(Me.tarticulo.Text.Trim) = 0 Then
                Call btnarticulo_Click(sender, e)
                Exit Sub
            End If

            If Me.tdoc1.Text.Trim = "" Or Me.tdoc2.Text.Trim = "" Then
                MessageBox.Show("Ingrese el Número del Documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tdoc1.Focus()
                Me.tdoc1.SelectAll()
                Exit Sub
            Else

                Me.tdoc1.Text = Format(Val(Me.tdoc1.Text.Trim), "000")
                Me.tdoc2.Text = Format(Val(Me.tdoc2.Text.Trim), "0000000")
            End If

            Me.txtcantidad.Focus()
            Conecta("select c.codarti,c.desarti,u.desmed,u.codmed,m.desmarca,c.codmarca,p.tara,p.despres from articulo c,medida u,marcas m,presentacion p where c.codmed=u.codmed and c.codmarca=m.codmarca and c.codpres=p.codpres and c.codempresa='" & codempresa & "' and c.estado=0 and u.estado=0 and m.estado=0 and c.codarti='" & tarticulo.Text & "'", "pa")

            If ds.Tables("pa").Rows.Count > 0 Then
                tarticulo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                tumedida.Text = Trim(ds.Tables("pa").Rows(0)(7))
                medida.Add(Trim(ds.Tables("pa").Rows(0)(3)))
                tmarca.Text = Trim(ds.Tables("pa").Rows(0)(4))
                marca = Trim(ds.Tables("pa").Rows(0)(5))
                ttara.Text = Trim(ds.Tables("pa").Rows(0)(6))
                txtcantidad.Focus()
                txtcantidad.SelectAll()
            Else
                MessageBox.Show("No existen artículos encontrados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tarticulo.Focus()
                Me.tarticulo.SelectAll()
                Exit Sub
            End If

        End If
    End Sub

    Private Sub tcodproveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tcodproveedor.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim men As New frm_gridproveedor
            men.vie2 = Me
            men.ShowDialog()
        End If

    End Sub

    Private Sub tdoc2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdoc2.LostFocus
        If INICIAS = False Then
            INICIAS = True
            Exit Sub
        End If

        If tdoc2.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Nro de Documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.tdoc2.Focus()
            INICIAS = True
            Exit Sub
        Else
            Me.tdoc2.Text = Format(Val(Me.tdoc2.Text.Trim), "0000000")
            INICIAS = True
        End If


        Conecta("select cdalmacen from movicab where cdtipodoc='" & Me.ctipodoc.SelectedValue.ToString & "' and cdprovee='" & Me.tcodproveedor.Text.Trim & "' and nrodoc='" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "' and estado=0 and codempresa='" & codempresa & "' and inout=0", "valida")
        If ds.Tables("valida").Rows.Count > 0 Then
            MessageBox.Show("Nro de Documento ya ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.tdoc2.Text = ""
            Me.tdoc1.Focus()
            Exit Sub
        End If
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        flag = 1
        desbloqueatextbox(Me)
        Me.ctipoing.Enabled = False
        btnproveedor.Enabled = True
        dtpfecha.Enabled = True
        grid1.Enabled = True
        grid1.ReadOnly = False
        btnarticulo.Enabled = True
        Me.TOBS.Enabled = True
        BTNNUEVO.Enabled = False
        btnmodificar.Enabled = False
        BTNCANCELAR.Enabled = True
        BTNGUARDAR.Enabled = True
        BTNELIMINAR.Enabled = False

        Me.tproveedor.ReadOnly = True
        Me.tmovimiento.ReadOnly = True
        Me.txtdesarticulo.ReadOnly = True
        Me.tmarca.ReadOnly = True
        Me.ttara.ReadOnly = True
        Me.totbruto.ReadOnly = True
        Me.tottara.ReadOnly = True
        Me.totneto.ReadOnly = True
        Me.tottotal.ReadOnly = True
        ttotal.ReadOnly = True

    End Sub

    Public valorizado As Boolean

    Sub verifica_valorizado()
        Conecta("select valor,provee,pagocred,usumult from tipomovi where cdtipomov='" & Me.ctipoing.SelectedValue.ToString & "' and estado=0  and codempresa='" & codempresa & "'", "llena")

        If ds.Tables("llena").Rows.Count > 0 Then
            If ds.Tables("llena").Rows(0)(0) = True Then
                lcosto.Visible = True
                tcosto.Visible = True
                ltotal.Visible = True
                ttotal.Visible = True
                tottotal.Visible = True
                Label18.Visible = True
                Me.DataGridTextBoxColumn18.Width = 75
                Me.DataGridTextBoxColumn20.Width = 90
                Me.DataGridTextBoxColumn18.HeaderText = "Costo ."
                Me.DataGridTextBoxColumn20.HeaderText = "Total ."
                Me.DataGridTextBoxColumn19.Width = 90
                Me.DataGridTextBoxColumn21.Width = 90
                Me.DataGridTextBoxColumn19.HeaderText = "Precio ."
                Me.DataGridTextBoxColumn21.HeaderText = "Total ."
                ctipoprecio.Visible = True
                Label19.Visible = True
                valorizado = True
            Else
                lcosto.Visible = False
                tcosto.Visible = False
                ltotal.Visible = False
                ttotal.Visible = False
                tottotal.Visible = False
                Label18.Visible = False
                Me.DataGridTextBoxColumn18.Width = 0
                Me.DataGridTextBoxColumn20.Width = 0
                Me.DataGridTextBoxColumn18.HeaderText = ""
                Me.DataGridTextBoxColumn20.HeaderText = ""
                Me.DataGridTextBoxColumn19.Width = 0
                Me.DataGridTextBoxColumn21.Width = 0
                Me.DataGridTextBoxColumn18.HeaderText = ""
                Me.DataGridTextBoxColumn20.HeaderText = ""
                ctipoprecio.Visible = False
                Label19.Visible = False
                valorizado = False
            End If
            Me.grid1.Refresh()

            If ds.Tables("llena").Rows(0)(1) = True Then
                Me.lcodprov.Visible = True
                Me.lproveedor.Visible = True
                Me.tcodproveedor.Visible = True
                Me.tproveedor.Visible = True
                Me.btnproveedor.Visible = True
                Me.tcodproveedor.Text = ""
                Me.tproveedor.Text = ""
            Else
                Me.lcodprov.Visible = False
                Me.lproveedor.Visible = False
                Me.tcodproveedor.Visible = False
                Me.tproveedor.Visible = False
                Me.btnproveedor.Visible = False
                Me.tcodproveedor.Text = "HAL"
            End If

            If Trim(ds.Tables("llena").Rows(0)(2)) = True Then
                Me.Label2.Visible = True
                Me.Label20.Visible = True
                Me.ctipocred.Visible = True
                ComboBox1.Visible = True
                cred = 1
            Else
                Me.Label2.Visible = False
                Me.Label20.Visible = False
                Me.ctipocred.Visible = False
                ComboBox1.Visible = False
                cred = 0
            End If

            If tcodproveedor.Text.Trim <> "" Then
                llenaproveedor()
            End If
        End If
        ctipoing.Focus()

        If tcosto.Text = "Infinito" Then
            tcosto.Text = 0
        End If
    End Sub

    Dim cred As Short, condicion As Boolean = False

    Public Sub ctipoing_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctipoing.SelectedIndexChanged

        Conecta("SELECT CDSALTRANSF FROM CONFIGINV WHERE CODEMPRESA='" & codempresa & "'", "LLENA")

        If ds.Tables("LLENA").Rows.Count > 0 Then
            If Trim(Me.ctipoing.SelectedValue.ToString) = Trim(ds.Tables("llena").Rows(0)(0)) Then
                condicion = True
                'timportacion.ReadOnly = False
                Label9.Text = "Almacén Origen:"
                calmacen2.Visible = True
                salida = True
                Label6.Visible = True
            Else
                condicion = False
                'timportacion.ReadOnly = False
                calmacen2.Visible = False
                Label9.Text = "Almacén :"
                salida = False
                Label6.Visible = False
            End If
        Else
            MessageBox.Show("Falta configurar las Salidas por Transferencias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            condicion = False
            'timportacion.ReadOnly = False
        End If

        Conecta("select correlativo from tipomovi where codempresa='" & codempresa & "' and cdtipomov='" & Me.ctipoing.SelectedValue.ToString & "'", "indice")
        If ds.Tables("indice").Rows.Count > 0 Then
            Me.tmovimiento.Text = Trim(ds.Tables("indice").Rows(0)(0))
        End If
        verifica_valorizado()
    End Sub
    Friend WithEvents tottara As System.Windows.Forms.TextBox
    Friend WithEvents tottotal As System.Windows.Forms.TextBox
    Friend WithEvents totbruto As System.Windows.Forms.TextBox
    Friend WithEvents totneto As System.Windows.Forms.TextBox
    Private Sub tumedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tumedida.SelectedIndexChanged
        Conecta("select codumed from umedida where codumed='" & Trim(medida.Item(tumedida.SelectedIndex)) & "'", "cuenta")
        If ds.Tables("cuenta").Rows.Count > 0 Then
            ttara.Text = 0
            valor = False 'false cuando se escoge unidades de medida
        Else
            valor = True  'false cuando se escoge medidas
        End If

        codmed = medida.Item(Me.tumedida.SelectedIndex)

    End Sub

    Private Sub tcosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcosto.KeyPress
        'Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        'Keyascii = CShort(NumerosDecimales(Keyascii))
        'If Keyascii = 0 Then
        '    e.Handled = True
        '    MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.tcosto.Focus()
        'End If
        'Try
        '    If Asc(e.KeyChar) = Keys.Enter Then
        '        If ttotal.Text = "0" Then

        '            ttotal.Text = Val(tcosto.Text * tneto.Text).ToString("###0.00")
        '            Call Llena_temp()
        '        ElseIf ttotal.Text.Trim = "" Then
        '            ttotal.Text = Val(tcosto.Text * tneto.Text).ToString("###0.00")
        '            Call Llena_temp()
        '        Else
        '            Call Llena_temp()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox("Consulte al Administrador del Sistema", MsgBoxStyle.Information, "Administrador")
        'End Try


    End Sub

    Private Sub dtpfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfecha.ValueChanged
        tcambio()
    End Sub

    Private Sub ctipoprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipoprecio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If tcodproveedor.Visible = True Then
                Me.tcodproveedor.Focus()
                Me.tcodproveedor.SelectAll()
            ElseIf ctipocred.Visible = True Then
                ctipocred.Focus()
            Else
                tarticulo.Focus()
            End If
        End If
    End Sub

    Private Sub ctipoprecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctipoprecio.SelectedIndexChanged
        cargagrilla()
    End Sub

    Private Sub timportacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            tdoc1.Focus()
            tdoc1.SelectAll()
        End If
    End Sub

    Private Sub calmacen2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles calmacen2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ComboBox1.Visible = True Then
                ComboBox1.Focus()
            Else
                ctipodoc.Focus()
            End If
        End If
    End Sub

    Private Sub cptoventa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If ctipocred.Visible = True Then
                Me.ctipocred.Focus()
            Else
                Me.tarticulo.Focus()
                Me.tarticulo.SelectAll()
            End If
        End If
    End Sub


    Private Sub ctipocred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipocred.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tarticulo.Focus()
            Me.tarticulo.SelectAll()
        End If
    End Sub

    Private Sub TREF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TREF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ctipoprecio.Visible = False Then
                'ctipoprecio.Focus()
                Me.tlote.Focus()
            ElseIf tcodproveedor.Visible = True Then
                tcodproveedor.Focus()
            ElseIf ctipocred.Visible = True Then
                ctipocred.Focus()
            Else
                tlote.Focus()
                tlote.SelectAll()
            End If
        End If
    End Sub
    Private Sub calmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calmacen.SelectedIndexChanged
        Try
            Me.tdoc1.Text = calmacen.SelectedValue.ToString()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ctipodoc.Focus()
        End If
    End Sub
    Private Sub cboref_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboref.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtDocRef1.Focus()
            Me.TxtDocRef1.SelectAll()
        End If

    End Sub
    Private Sub tlote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tlote.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tarticulo.Focus()
            tarticulo.SelectAll()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim men As New FRM_LISTA_LOTES_SALIDAS
        'men.INS_FRM_GUISAL = Me
        'men.ShowDialog()
    End Sub
    Private Sub TxtDocRef1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDocRef1.LostFocus
        TxtDocRef1.Text = Format(Val(Me.TxtDocRef1.Text.Trim), "000")
    End Sub
    Private Sub TREF_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TREF.LostFocus
        Me.TREF.Text = Format(Val(Me.TREF.Text.Trim), "0000000")
    End Sub
    Private Sub TxtDocRef1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDocRef1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TREF.Focus()
        End If
    End Sub
    Private Sub tdoc1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdoc1.LostFocus
        Me.tdoc1.Text = Strings.Right("000" + CType(Me.tdoc1.Text.Trim, String), 3)
    End Sub
    Private Sub grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        Try
            Dim sql As String
            Dim PROCESO As Boolean

            If e.KeyCode = Keys.F3 Then

                Conecta("SELECT cdcompra,corrnbr FROM TMP_moviDET WHERE codempresa='" & codempresa & "' and cdcompra='" & correl & "' and inout=0 order by corrnbr", "paz")
                If ds.Tables("paz").Rows.Count = 0 Then
                    calmacen.Enabled = True
                    ctipoing.Enabled = True
                    Exit Sub
                End If


                If MessageBox.Show("Desea eliminar el Registro Seleccionado", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    sql = "nsp_dele_TMP_moviDET " & grid1.Item(grid1.CurrentRowIndex, 0) & "," & Me.tmovimiento.Text.Trim & ",'" & codempresa & "',0,'" & Trim(Me.ctipoing.SelectedValue.ToString()) & "','" & CodUsuario & "','" & NROPTOVTA & "','" & Trim(Me.grid1.Item(grid1.CurrentRowIndex, 1).ToString()) & "'"
                    PROCESO = TmpInsertDatos(sql)
                    cargagrilla()
                    Me.tarticulo.Focus()
                End If

            End If

        Catch x As Exception

        End Try
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Me.grid1.Focus = True Then
                        Try
                            If Me.grid1.CurrentRowIndex <> -1 Then
                                Call Item_Grilla()
                                est = False
                            End If
                        Catch ex As Exception
                        End Try
                    End If
            End Select
        End If
    End Function
    Private Sub grid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.CurrentCellChanged
        Me.grid1.Select(Me.grid1.CurrentRowIndex)
    End Sub
    Private Sub txtcantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            Conecta("select c.codarti,c.desarti,u.desmed,u.codmed,m.desmarca,c.codmarca,p.tara,p.despres from articulo c,medida u,marcas m,presentacion p where c.codmed=u.codmed and c.codmarca=m.codmarca and c.codpres=p.codpres and c.codempresa='" & codempresa & "' and c.estado=0 and u.estado=0 and m.estado=0 and c.codarti='" & tarticulo.Text.Trim & "'", "pa")
            If ds.Tables("pa").Rows.Count > 0 Then
                ttara.Text = Trim(ds.Tables("pa").Rows(0)(6))
            End If
            Me.tbruto.Focus()
        End If
    End Sub

    Private Sub ttotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttotal.TextChanged

    End Sub


    Private Sub Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn.Click
        Dim STATUS As Boolean
        Conecta("SELECT CDSUBZONA,NROPTOVTA FROM PTOVTA WHERE CDZONA='" & CDZONA.Trim.ToString & "'", "sUBaLMACEN")
        If ds.Tables("sUBaLMACEN").Rows.Count > 0 Then
            SUBALMACEN = ds.Tables("sUBaLMACEN").Rows(0)(0)
            PTOVTA = ds.Tables("sUBaLMACEN").Rows(0)(1)
        Else
            SUBALMACEN = ""
            PTOVTA = ""
        End If
        Conecta("select * from movidet where cdalmacen='" & Venta.Trim.ToString & "' and cdtipomov='08'  ORDER BY FECDOCUM ASC", "Movi")
        If ds.Tables("Movi").Rows.Count > 0 Then
            For n As Integer = 0 To ds.Tables("Movi").Rows.Count - 1
                articulo = ds.Tables("Movi").Rows(n).Item("cdarticulo")
                lote = ds.Tables("Movi").Rows(n).Item("lote")
                nroimportacion = ds.Tables("Movi").Rows(n).Item("nroimportacion")
                NROMOVI = ds.Tables("Movi").Rows(n).Item("NROMOVI")
                CANTIDADES = ds.Tables("Movi").Rows(n)("CANTIDAD")
                Conecta("select * from saldos_importacion where codarti='" & articulo.ToString & "' and nroimportacion=" & nroimportacion.ToString & " and cdalmacen='" & SUBALMACEN.ToString & "' and nlote=" & lote.ToString, "veRIFIC")
                If ds.Tables("veRIFIC").Rows.Count > 0 Then
                    STATUS = TmpInsertDatos("UPDATE SALDOS_IMPORTACION SET SALDOBULTOS=SALDOBULTOS+" & CANTIDADES & ",pesoneto=pesoneto+" & ds.Tables("Movi").Rows(n)("tneto") & ",saldont=saldont+" & ds.Tables("Movi").Rows(n)("tneto") & ", BULTOS=BULTOS+ " & CANTIDADES & " WHERE codarti='" & articulo.ToString & "' and nroimportacion=" & nroimportacion.ToString & " AND  cdalmacen=" & SUBALMACEN.ToString.Trim & " and nlote=" & lote.ToString & "")
                    If STATUS = False Then
                        MsgBox("Error al actualizar los datos", MsgBoxStyle.Critical, "NAR SISTEMAS")
                        Exit Sub
                    End If
                Else
                    TmpInsertDatos("INSERT INTO SALDOS_IMPORTACION(CODARTI, NROIMPORTACION, BULTOS, SALDOBULTOS, PESONETO, SALDONT, FECHAVENCIMIENTO, COSTOBAS, COSTOEXT, CDALMACEN, NROPTOVTA, FRECIBO,  NROMOV, NLOTE, tipo)" & _
                                          "SELECT	CDARTICULO,NROIMPORTACION, CANTIDAD,CANTIDAD,TNETO,TNETO, FECDOCUM, COSTOBAS, COSTOEXT,'" & SUBALMACEN.ToString.Trim & "','" & PTOVTA.ToString.Trim & "','" & Format(dtpfecha.Value, "MM/dd/yyy").ToString & "'," & _
                                          NROMOVI.ToString.Trim & ",LOTE,1 FROM MOVIDET where nromovi=" & NROMOVI.ToString & " and cdalmacen='" & Venta.Trim.ToString & "' and cdtipomov='08'AND CDARTICULO='" & articulo.ToString & "'" & "and lote='" & lote.ToString & "'")

                End If
            Next
            MsgBox("Los Datos se guardaron con exito ...!!!", MsgBoxStyle.Exclamation, "NAR SISTEMAS")
        End If
    End Sub

    Private Sub tcosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcosto.TextChanged

    End Sub

    Private Sub tcosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tcosto.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If ttotal.Text = "0" Then

                    ttotal.Text = Val(tcosto.Text * tneto.Text).ToString("###0.00")
                    Llena_temp()
                ElseIf ttotal.Text.Trim = "" Then
                    ttotal.Text = Val(tcosto.Text * tneto.Text).ToString("###0.00")
                    Llena_temp()
                Else
                    Llena_temp()
                End If
            End If
        Catch ex As Exception
            MsgBox("Consulte al Administrador del Sistema", MsgBoxStyle.Information, "Administrador")
        End Try
    End Sub
End Class
