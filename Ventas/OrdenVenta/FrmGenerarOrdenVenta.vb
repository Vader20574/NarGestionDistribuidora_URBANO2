Public Class FrmGenerarOrdenVenta
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
    Friend WithEvents CRTDOC As AxCrystal.AxCrystalReport
    Friend WithEvents DataGridDocumentos As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboPtovta As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblMontoTotal As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents GrCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents DtHoraSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DtFechaVenta As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents CboUsu As System.Windows.Forms.ComboBox
    Friend WithEvents PnlPtoVta As System.Windows.Forms.Panel
    Friend WithEvents BtnBuscOrden As System.Windows.Forms.Button
    Friend WithEvents TxtOrdenVenta As System.Windows.Forms.TextBox
    Friend WithEvents GrPtovta As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents NROPTOVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECINI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECFIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MOSTRAR As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BTNREPORTE1 As System.Windows.Forms.Button
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerarOrdenVenta))
        Me.CRTDOC = New AxCrystal.AxCrystalReport
        Me.DataGridDocumentos = New System.Windows.Forms.DataGrid
        Me.PnlPtoVta = New System.Windows.Forms.Panel
        Me.btnOK = New System.Windows.Forms.Button
        Me.CboPtovta = New System.Windows.Forms.ComboBox
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtOrdenVenta = New System.Windows.Forms.TextBox
        Me.BtnBuscOrden = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DtFechaVenta = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TxtResponsable = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblMontoTotal = New System.Windows.Forms.Label
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BTNREPORTE1 = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BTNREPORTE = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GrCabecera = New System.Windows.Forms.GroupBox
        Me.CboUsu = New System.Windows.Forms.ComboBox
        Me.DtHoraSalida = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.GrPtovta = New System.Windows.Forms.GroupBox
        Me.BtnMostrar = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NROPTOVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECINI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECFIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MOSTRAR = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Rpt1 = New AxCrystal.AxCrystalReport
        CType(Me.CRTDOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPtoVta.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GrCabecera.SuspendLayout()
        Me.GrPtovta.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CRTDOC
        '
        Me.CRTDOC.Enabled = True
        Me.CRTDOC.Location = New System.Drawing.Point(812, 525)
        Me.CRTDOC.Name = "CRTDOC"
        Me.CRTDOC.OcxState = CType(resources.GetObject("CRTDOC.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CRTDOC.Size = New System.Drawing.Size(28, 28)
        Me.CRTDOC.TabIndex = 5
        '
        'DataGridDocumentos
        '
        Me.DataGridDocumentos.DataMember = ""
        Me.DataGridDocumentos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridDocumentos.Location = New System.Drawing.Point(2, 244)
        Me.DataGridDocumentos.Name = "DataGridDocumentos"
        Me.DataGridDocumentos.ReadOnly = True
        Me.DataGridDocumentos.Size = New System.Drawing.Size(935, 238)
        Me.DataGridDocumentos.TabIndex = 8
        '
        'PnlPtoVta
        '
        Me.PnlPtoVta.BackColor = System.Drawing.SystemColors.GrayText
        Me.PnlPtoVta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPtoVta.Controls.Add(Me.btnOK)
        Me.PnlPtoVta.Controls.Add(Me.CboPtovta)
        Me.PnlPtoVta.Controls.Add(Me.DtFechaFin)
        Me.PnlPtoVta.Controls.Add(Me.DtFechaIni)
        Me.PnlPtoVta.Controls.Add(Me.Label4)
        Me.PnlPtoVta.Controls.Add(Me.Label5)
        Me.PnlPtoVta.Controls.Add(Me.Label1)
        Me.PnlPtoVta.Enabled = False
        Me.PnlPtoVta.Location = New System.Drawing.Point(570, 145)
        Me.PnlPtoVta.Name = "PnlPtoVta"
        Me.PnlPtoVta.Size = New System.Drawing.Size(435, 60)
        Me.PnlPtoVta.TabIndex = 9
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnOK.Location = New System.Drawing.Point(326, 6)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(66, 44)
        Me.btnOK.TabIndex = 122
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'CboPtovta
        '
        Me.CboPtovta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPtovta.Location = New System.Drawing.Point(105, 4)
        Me.CboPtovta.Name = "CboPtovta"
        Me.CboPtovta.Size = New System.Drawing.Size(202, 21)
        Me.CboPtovta.TabIndex = 43
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(228, 30)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(92, 20)
        Me.DtFechaFin.TabIndex = 42
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(89, 30)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(92, 20)
        Me.DtFechaIni.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Desde : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nro Ptovta :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Hasta : "
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 511)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "TOTAL: "
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(558, 503)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(174, 36)
        Me.LblTotal.TabIndex = 12
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nro Orden Venta :  "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtOrdenVenta
        '
        Me.TxtOrdenVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdenVenta.Location = New System.Drawing.Point(134, 10)
        Me.TxtOrdenVenta.Name = "TxtOrdenVenta"
        Me.TxtOrdenVenta.Size = New System.Drawing.Size(122, 22)
        Me.TxtOrdenVenta.TabIndex = 15
        '
        'BtnBuscOrden
        '
        Me.BtnBuscOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.BtnBuscOrden.ImageIndex = 5
        Me.BtnBuscOrden.ImageList = Me.ImageList1
        Me.BtnBuscOrden.Location = New System.Drawing.Point(262, 10)
        Me.BtnBuscOrden.Name = "BtnBuscOrden"
        Me.BtnBuscOrden.Size = New System.Drawing.Size(32, 24)
        Me.BtnBuscOrden.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBuscOrden)
        Me.GroupBox2.Controls.Add(Me.TxtOrdenVenta)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 34)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'DtFechaVenta
        '
        Me.DtFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaVenta.Location = New System.Drawing.Point(516, 20)
        Me.DtFechaVenta.Name = "DtFechaVenta"
        Me.DtFechaVenta.Size = New System.Drawing.Size(92, 20)
        Me.DtFechaVenta.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(412, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Fecha orden Venta : "
        '
        'LblTitulo
        '
        Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(139, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(285, 34)
        Me.LblTitulo.TabIndex = 43
        Me.LblTitulo.Text = "NUEVA ORDEN DE VENTA "
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTitulo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'TxtResponsable
        '
        Me.TxtResponsable.Enabled = False
        Me.TxtResponsable.Location = New System.Drawing.Point(94, 44)
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.Size = New System.Drawing.Size(304, 20)
        Me.TxtResponsable.TabIndex = 49
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(14, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 50
        Me.Label17.Text = "Responsable : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Operador : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(94, 68)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(304, 20)
        Me.TxtDireccion.TabIndex = 53
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Direccion : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(641, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Monto Total : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'LblMontoTotal
        '
        Me.LblMontoTotal.BackColor = System.Drawing.Color.White
        Me.LblMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblMontoTotal.Location = New System.Drawing.Point(728, 208)
        Me.LblMontoTotal.Name = "LblMontoTotal"
        Me.LblMontoTotal.Size = New System.Drawing.Size(82, 23)
        Me.LblMontoTotal.TabIndex = 56
        Me.LblMontoTotal.Text = "0.00"
        Me.LblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblMontoTotal.Visible = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        Me.ImageList2.Images.SetKeyName(7, "")
        Me.ImageList2.Images.SetKeyName(8, "")
        Me.ImageList2.Images.SetKeyName(9, "")
        Me.ImageList2.Images.SetKeyName(10, "")
        Me.ImageList2.Images.SetKeyName(11, "")
        Me.ImageList2.Images.SetKeyName(12, "")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTNREPORTE1)
        Me.GroupBox3.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox3.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox3.Controls.Add(Me.btnmodificar)
        Me.GroupBox3.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox3.Controls.Add(Me.BtnCancelar)
        Me.GroupBox3.Controls.Add(Me.BTNREPORTE)
        Me.GroupBox3.Controls.Add(Me.BtnSalir)
        Me.GroupBox3.Location = New System.Drawing.Point(943, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(108, 238)
        Me.GroupBox3.TabIndex = 117
        Me.GroupBox3.TabStop = False
        '
        'BTNREPORTE1
        '
        Me.BTNREPORTE1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTE1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE1.ImageIndex = 11
        Me.BTNREPORTE1.ImageList = Me.ImageList1
        Me.BTNREPORTE1.Location = New System.Drawing.Point(8, 110)
        Me.BTNREPORTE1.Name = "BTNREPORTE1"
        Me.BTNREPORTE1.Size = New System.Drawing.Size(90, 23)
        Me.BTNREPORTE1.TabIndex = 12
        Me.BTNREPORTE1.Text = "  &Reporte"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(8, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(90, 25)
        Me.BTNNUEVO.TabIndex = 10
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
        Me.BTNGUARDAR.Location = New System.Drawing.Point(8, 50)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(90, 25)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "  &Guardar"
        '
        'btnmodificar
        '
        Me.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodificar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.ImageIndex = 2
        Me.btnmodificar.ImageList = Me.ImageList1
        Me.btnmodificar.Location = New System.Drawing.Point(128, 80)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(90, 25)
        Me.btnmodificar.TabIndex = 11
        Me.btnmodificar.Text = "   &Modificar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Enabled = False
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(128, 108)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(90, 25)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "Anular"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(8, 82)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 25)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "  &Cancelar"
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 11
        Me.BTNREPORTE.ImageList = Me.ImageList1
        Me.BTNREPORTE.Location = New System.Drawing.Point(8, 170)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(90, 25)
        Me.BTNREPORTE.TabIndex = 6
        Me.BTNREPORTE.Text = "  &Reporte"
        Me.BTNREPORTE.Visible = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.ImageIndex = 4
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(8, 136)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(90, 25)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "&Salir"
        '
        'GrCabecera
        '
        Me.GrCabecera.Controls.Add(Me.CboUsu)
        Me.GrCabecera.Controls.Add(Me.DtHoraSalida)
        Me.GrCabecera.Controls.Add(Me.Label16)
        Me.GrCabecera.Controls.Add(Me.TxtResponsable)
        Me.GrCabecera.Controls.Add(Me.Label17)
        Me.GrCabecera.Controls.Add(Me.TxtDireccion)
        Me.GrCabecera.Controls.Add(Me.Label9)
        Me.GrCabecera.Controls.Add(Me.DtFechaVenta)
        Me.GrCabecera.Controls.Add(Me.Label2)
        Me.GrCabecera.Controls.Add(Me.Label8)
        Me.GrCabecera.Enabled = False
        Me.GrCabecera.Location = New System.Drawing.Point(122, 42)
        Me.GrCabecera.Name = "GrCabecera"
        Me.GrCabecera.Size = New System.Drawing.Size(626, 90)
        Me.GrCabecera.TabIndex = 118
        Me.GrCabecera.TabStop = False
        '
        'CboUsu
        '
        Me.CboUsu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUsu.Enabled = False
        Me.CboUsu.Location = New System.Drawing.Point(94, 20)
        Me.CboUsu.Name = "CboUsu"
        Me.CboUsu.Size = New System.Drawing.Size(246, 21)
        Me.CboUsu.TabIndex = 57
        '
        'DtHoraSalida
        '
        Me.DtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtHoraSalida.Location = New System.Drawing.Point(516, 42)
        Me.DtHoraSalida.Name = "DtHoraSalida"
        Me.DtHoraSalida.ShowUpDown = True
        Me.DtHoraSalida.Size = New System.Drawing.Size(94, 20)
        Me.DtHoraSalida.TabIndex = 55
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(450, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 56
        Me.Label16.Text = "Hora Salida :"
        '
        'GrPtovta
        '
        Me.GrPtovta.Controls.Add(Me.BtnMostrar)
        Me.GrPtovta.Controls.Add(Me.DataGridView1)
        Me.GrPtovta.Location = New System.Drawing.Point(6, 132)
        Me.GrPtovta.Name = "GrPtovta"
        Me.GrPtovta.Size = New System.Drawing.Size(558, 108)
        Me.GrPtovta.TabIndex = 120
        Me.GrPtovta.TabStop = False
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.Location = New System.Drawing.Point(464, 17)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(60, 56)
        Me.BtnMostrar.TabIndex = 123
        Me.BtnMostrar.Text = "&Mostrar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NROPTOVTA, Me.FECINI, Me.FECFIN, Me.MOSTRAR})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(450, 85)
        Me.DataGridView1.TabIndex = 122
        '
        'NROPTOVTA
        '
        Me.NROPTOVTA.DataPropertyName = "NROPTOVTA"
        Me.NROPTOVTA.HeaderText = "PTOVTA"
        Me.NROPTOVTA.Name = "NROPTOVTA"
        '
        'FECINI
        '
        Me.FECINI.DataPropertyName = "FECINI"
        Me.FECINI.HeaderText = "FECHA INCIO"
        Me.FECINI.Name = "FECINI"
        '
        'FECFIN
        '
        Me.FECFIN.DataPropertyName = "FECFIN"
        Me.FECFIN.HeaderText = "FECHA FIN"
        Me.FECFIN.Name = "FECFIN"
        '
        'MOSTRAR
        '
        Me.MOSTRAR.DataPropertyName = "MOSTRAR"
        Me.MOSTRAR.HeaderText = "MOSTRAR"
        Me.MOSTRAR.Name = "MOSTRAR"
        Me.MOSTRAR.ReadOnly = True
        Me.MOSTRAR.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MOSTRAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(836, 55)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 121
        '
        'FrmGenerarOrdenVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1358, 741)
        Me.Controls.Add(Me.Rpt1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.GrPtovta)
        Me.Controls.Add(Me.GrCabecera)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PnlPtoVta)
        Me.Controls.Add(Me.DataGridDocumentos)
        Me.Controls.Add(Me.CRTDOC)
        Me.Controls.Add(Me.LblMontoTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmGenerarOrdenVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Orden de  Venta"
        CType(Me.CRTDOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPtoVta.ResumeLayout(False)
        Me.PnlPtoVta.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GrCabecera.ResumeLayout(False)
        Me.GrCabecera.PerformLayout()
        Me.GrPtovta.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "VARIABLES"
    Private TABLE_DOC As New DataTable
    Private TABLE_PTOVTADOC As New DataTable
    Private Habilita As Boolean
    Private Modific As Boolean
    Private NombreCaja As Control




#End Region
#Region "FUNCIONES"


    Private Sub LimpiarVariables()
        Modific = False
        TxtDireccion.Text = ""
        TxtOrdenVenta.Text = ""
        LblMontoTotal.Text = "0.00"
        DtFechaIni.Value = Date.Now
        DtFechaFin.Value = Date.Now
        DtFechaVenta.Value = Date.Now
        DtHoraSalida.Value = Date.Now

    End Sub
    Private Sub HabilitaBotones(ByVal valor As Boolean)
        LblTitulo.Visible = valor
        BtnCancelar.Enabled = valor
        BTNGUARDAR.Enabled = valor
        BTNNUEVO.Enabled = Not valor
        btnmodificar.Enabled = Not valor
        GrCabecera.Enabled = valor
        PnlPtoVta.Enabled = valor
        DataGridView1.Enabled = valor
        DataGridDocumentos.Enabled = valor

    End Sub
    Private Sub CargarDocum()
        Try
            For i As Integer = 0 To TABLE_PTOVTADOC.Rows.Count - 1
                If TABLE_PTOVTADOC.Rows(i)("NROPTOVTA").ToString.Trim = CboPtovta.SelectedValue Then
                    MsgBox("YA EXISTE EL PTOVTA INGRESADO...", MsgBoxStyle.Exclamation, "")
                    Exit Sub
                End If
            Next

            CAyuda.Ejecutar("SP_INS_TMPGUIAINTERNADETdeVENTADET ", codempresa, VCorrelInv, CodUsuario, CboPtovta.SelectedValue, Format(CDate(DtFechaIni.Value), "dd/MM/yyyy"), Format(CDate(DtFechaFin.Value), "dd/MM/yyyy"))
            ' CAyuda.Ejecutar("SP_INS_TMPGUIAINTERNADETdeVENTADETSERV ", codempresa, VCorrelInv, CodUsuario, CboPtovta.SelectedValue, Format(CDate(DtFechaIni.Value), "dd/MM/yyyy"), Format(CDate(DtFechaFin.Value), "dd/MM/yyyy"))


            CAyuda.Ejecutar("SP_INS_TMP_PTOVTA_FILTRAR ", codempresa, VCorrelInv, CodUsuario, CboPtovta.Text)

            CargarGrid()
            FormatoGrid()

            If TABLE_DOC.Rows.Count > 0 Then
                CargarPtoVtaDoc()
                'FormatoGridPtoVta()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargarGrid()
        LblTotal.Text = Format(CDbl(0), "#######0.00")

        TABLE_DOC = TmpListarDatos("SP_SELECTMP_GUIAINTERNADET_J'" & codempresa & "','" & VCorrelInv & "','" & CboPtovta.SelectedValue & "'")
        DataGridDocumentos.DataSource = TABLE_DOC
        If TABLE_DOC.Rows.Count > 0 Then
            'DataGridDocumentos.CaptionText = CboPtovta.Text
            Dim TableTotales As New DataTable
            TableTotales = TmpListarDatos("SP_SELECTMP_GUIAINTERNADET_JSUM'" & codempresa & "','" & VCorrelInv & "','" & CboPtovta.SelectedValue & "'")
            DataGridDocumentos.DataSource = TABLE_DOC

            If TableTotales.Rows.Count > 0 Then
                LblTotal.Text = Format(CDbl(TableTotales.Rows(0)("TOTBAS")), "#######0.00")
            End If
        End If
    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_DOC.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "NROPTOVTA"
            .HeaderText = "PTOVTA"  '"Fecha Doc"
            .NullText = ""
            .Alignment = HorizontalAlignment.Center
            .Width = 75
        End With


        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "FECDOCUM"
            .HeaderText = ""  '"Fecha Doc"
            .NullText = ""
            .Format = "dd/MM/yyyy"
            .Alignment = HorizontalAlignment.Right
            .Width = 75
        End With

        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "CODTIPODOC"
            .HeaderText = "Fecha Doc."
            .NullText = ""
            .Alignment = HorizontalAlignment.Right
            .Width = 0
        End With
        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "DSTIPODOC"
            .HeaderText = "Doc."
            .NullText = ""
            .Alignment = HorizontalAlignment.Center
            .Width = 35
        End With
        Dim DataColumn5 As New DataGridTextBoxColumn
        With DataColumn5
            .MappingName = "NRODOCFACT"
            .HeaderText = "Nro Doc."
            .NullText = ""
            .Width = 75
            .Alignment = HorizontalAlignment.Right
        End With
        Dim DataColumn6 As New DataGridTextBoxColumn
        With DataColumn6
            .MappingName = "CODCLIENTE"
            .HeaderText = "Cliente"
            .NullText = ""
            .Width = 0
        End With

        Dim DataColumn7 As New DataGridTextBoxColumn
        With DataColumn7
            .MappingName = "DESCLIENTE"
            .HeaderText = "Cliente"
            .NullText = ""
            .Width = 200
        End With
        Dim DataColumn8 As New DataGridTextBoxColumn
        With DataColumn8
            .MappingName = "CODTIPOPAGO"
            .HeaderText = "CODTIPOPAGO"
            .NullText = ""
            .Width = 0
        End With
        Dim DataColumn9 As New DataGridTextBoxColumn
        With DataColumn9
            .MappingName = "DSTIPOPAGO"
            .HeaderText = "Cond. Pago"
            .NullText = ""
            .Width = 90
        End With

        Dim DataColumn10 As New DataGridTextBoxColumn
        With DataColumn10
            .MappingName = "SUBTOTBAS"
            .HeaderText = "SubTotal |"
            .NullText = ""
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
        End With
        Dim DataColumn11 As New DataGridTextBoxColumn
        With DataColumn11
            .MappingName = "IGVBAS"
            .HeaderText = "IGV |"
            .NullText = ""
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
        End With
        Dim DataColumn12 As New DataGridTextBoxColumn
        With DataColumn12
            .MappingName = "TOTBAS"
            .HeaderText = "Total |"
            .NullText = ""
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
        End With
        Dim DataColumn13 As New DataGridTextBoxColumn
        With DataColumn13
            .MappingName = "CODDEP"
            .HeaderText = "CODDEP"
            .NullText = ""
            .Width = 65
        End With

        Dim DataColumn14 As New DataGridTextBoxColumn
        With DataColumn14
            .MappingName = "IPERCEP"
            .HeaderText = "IPERCEP"
            .NullText = ""
            .Width = 50
        End With

        DataGridDocumentos.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() _
        {DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5, DataColumn6, DataColumn7, DataColumn8, DataColumn9, DataColumn10, DataColumn11, DataColumn12, DataColumn13, DataColumn14})
        DataGridDocumentos.TableStyles.Add(TableStyle1)


    End Sub
    Private Sub LimpiaTemporal()
        TmpInsertDatos("DELETE FROM TMP_GUIAINTERNADET  WHERE CODEMPRESA='" & codempresa & "' AND  CORRNBR='" & VCorrelInv & "'")
        TABLE_PTOVTADOC.Rows.Clear()
    End Sub
    Private Sub CargarPtoVtaDoc()
        Dim FILA As DataRow = TABLE_PTOVTADOC.NewRow
        FILA("NROPTOVTA") = CboPtovta.SelectedValue
        FILA("FECINI") = Format(CDate(DtFechaIni.Value), "dd/MM/yyyy")
        FILA("FECFIN") = Format(CDate(DtFechaFin.Value), "dd/MM/yyyy")

        FILA("MOSTRAR") = True
        TABLE_PTOVTADOC.Rows.Add(FILA)
        DataGridView1.DataSource = TABLE_PTOVTADOC
        '   DataGridView1.DataSource = TABLE_PTOVTADOC



        Dim MontoTot As Double
        For i As Integer = 0 To TABLE_PTOVTADOC.Rows.Count - 1
            MontoTot = MontoTot + TmpListarDatos("SP_OBTENER_TOTALES_TMPGUIAINTERNADET  '" & codempresa & "','" & VCorrelInv & "','" & TABLE_PTOVTADOC.Rows(i)("NROPTOVTA") & "'").Rows(0)("TOTBAS")
        Next
        LblMontoTotal.Text = FormatoMonto(MontoTot, DECIRESU)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        Dim Sender As Object = Nothing
        Dim e As EventArgs = Nothing
        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter


                    If DataGridDocumentos.Focus = True Then
                        If TABLE_DOC.Rows.Count > 0 Then
                            Dim CODCLIE As String
                            Dim FrmTipoPago As New FrmCambioTipoPago
                            FrmTipoPago.CODIGOPAG = DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 6)
                            FrmTipoPago.ShowDialog()
                            If FrmTipoPago.DEVOLVER = False Then
                                Exit Function
                            End If
                            If FrmTipoPago.CODIGOPAG.Trim = VCdPagCredito.Trim Then
                                If DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 4).ToString.Trim = "" Then
                                    Exit Function
                                End If
                                CODCLIE = DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 4).ToString.Trim
                                If DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 11).ToString.Trim <> "" Then
                                    CODCLIE = DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 11).ToString.Trim
                                End If
                                If CODCLIE.Trim = "" Then
                                    MsgBox("FALTA CLIENTE PARA CREDITO..!", MsgBoxStyle.Exclamation, "")
                                    Exit Function
                                End If
                                Dim TABLE_CRED As New DataTable
                                TABLE_CRED = TmpListarDatos("SP_VERIFCREDCLIE_ODVTA   '" & codempresa & "','" & CODCLIE & "','" & DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 3).ToString.Trim & "','" & DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 1).ToString.Trim & "','" & VCorrelInv & "'")
                                If TABLE_CRED.Rows.Count = 0 Then
                                    MsgBox("NO EXISTE CREDITO PARA EL CLIENTE..", MsgBoxStyle.Exclamation, "")
                                    Exit Function
                                End If
                                If CDbl(TABLE_CRED.Rows(0)(0)) < 0 Then
                                    MsgBox("NO HAY SALDO SUFICIENTE PARA DAR CREDITO AL CLIENTE..", MsgBoxStyle.Exclamation, "")
                                    Exit Function
                                End If
                            End If

                            CAyuda.Ejecutar("SP_MODIFITEMTMP_GUIAINTERNADETVTA", codempresa, VCorrelInv, CboPtovta.SelectedValue, DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 1), DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 3), FrmTipoPago.CODIGOPAG)
                            CargarGrid()
                            FormatoGrid()
                        End If
                    End If

                    If NombreCaja.Name <> "DataGridView1" Then
                        Exit Function
                    End If

                    'If DataGridView1.Focus = True Then
                    '    DgPtoVta_Click(Sender, e)
                    '    Exit Function
                    'End If
                    'If DataGridView1.Focus = True Then
                    '    DgPtoVta_Click(Sender, e)
                    '    Exit Function
                    'End If

                Case Keys.F3
                    If DataGridDocumentos.Focus = True Then
                        If TABLE_DOC.Rows.Count > 0 Then
                            If Modific = False Then
                                CAyuda.Ejecutar("SP_ELITEMTMP_GUIAINTERNADETVTA", codempresa, VCorrelInv, CboPtovta.SelectedValue, DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 1), DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 3))
                                CargarGrid()
                                FormatoGrid()
                            Else
                                CAyuda.Ejecutar("SP_ANULITEMTMP_GUIAINTERNADETVTA", codempresa, VCorrelInv, CboPtovta.SelectedValue, DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 1), DataGridDocumentos.Item(DataGridDocumentos.CurrentRowIndex, 3))
                                CargarGrid()
                                FormatoGrid()
                            End If
                        End If
                    End If

            End Select
        End If
    End Function
#End Region

    Private Sub FrmGenerarOrdenVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(CboPtovta, "NSP_LISTAR_PTOVTA  '" & codempresa & "'", "NROPTOVTA", "NROPTOVTA")
        'CAyuda.CargarDataCombo(CboUsuario, "SP_LISTAR_USUARIO  '" & codempresa & "'", "CDUSUARIO", "CodUsuario")
        CboUsu.DataSource = TmpListarDatos("SELECT CDUSUARIO AS codigo , Usuario as Descripcion   FROM Usuario  where  CODEMPRESA='" & codempresa & "'")
        CboUsu.DisplayMember = "Descripcion"
        CboUsu.ValueMember = "codigo"

        Habilita = True
        CboUsu.SelectedValue = CodUsuario
        TABLE_PTOVTADOC.Columns.Add("NROPTOVTA")
        TABLE_PTOVTADOC.Columns.Add("FECINI")
        TABLE_PTOVTADOC.Columns.Add("FECFIN")
        TABLE_PTOVTADOC.Columns.Add("MOSTRAR")

        DtFechaVenta.Value = Format(vFechaActual, "dd/MM/yyyy")

        DtFechaIni.Value = Format(vFechaActual, "dd/MM/yyyy")
        DtFechaFin.Value = Format(vFechaActual, "dd/MM/yyyy")



    End Sub
    Private Sub DtFechaFin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtFechaFin.KeyDown
        If e.KeyCode = Keys.Enter Then
            'CargarDocum()
            'CboPtovta.Focus()
        End If
    End Sub
    Private Sub CboPtovta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboPtovta.KeyDown
        If e.KeyCode = Keys.Enter Then
            DtFechaIni.Focus()
        End If
    End Sub
    Private Sub DtFechaIni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtFechaIni.KeyDown
        If e.KeyCode = Keys.Enter Then
            DtFechaFin.Focus()
        End If
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        LimpiaTemporal()
        CargarGrid()
        FormatoGrid()
        'FormatoGridPtoVta()
        HabilitaBotones(False)
        LimpiarVariables()

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub DtFechaFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFechaFin.ValueChanged
    End Sub


    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click



        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DtFechaVenta.Value.Year
        MES = DtFechaVenta.Value.Month

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


        Dim MesAct, Anio As String
        Dim VFecDespacho As Date

        Dim TB_VALIDAR_FECHA As DataTable
        TB_VALIDAR_FECHA = TmpListarDatos("SP_SELECT_FECHA_TMP_GUIAINTERNADET '" & VCorrelInv & "'")
        If TB_VALIDAR_FECHA.Rows.Count > 0 Then
            VFecDespacho = CDate(TB_VALIDAR_FECHA.Rows(0)(0))
            MesAct = VFecDespacho.Month
            Anio = Format(VFecDespacho, "yyyy")

            If (AÑO = Anio And MES = MesAct) Then
            Else
                MsgBox("EL AÑO Y MES DE LA CABECERA ES DIFERENTE A LA FECHA DEL DETALLE TIENEN Q SER IGUALES")
                DtFechaVenta.Focus()
                Exit Sub
            End If

        End If

        If TABLE_DOC.Rows.Count = 0 Then
            MsgBox("NO HAY DATOS A GUARDAR...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If Modific = False Then
            Dim NroVenta As Double
            NroVenta = TmpListarDatos("SELECT  NROVENTA FROM  CONFIGSIS  WHERE COD_EMPRESA='" & codempresa & "'").Rows(0)(0)
            CAyuda.Ejecutar("NSP_INSERT_ORDEN_VENTA_J", codempresa, Format(CDate(DtFechaVenta.Value), "dd/MM/yyyy"), Format(CDate(DtHoraSalida.Value), "hh:mm:ss tt"), "", TxtResponsable.Text, "", TxtDireccion.Text, CboUsu.SelectedValue, VCorrelInv)
            MsgBox("SE GENERO LA ORDEN DE VENTA " & vbCrLf & "NRO " & NroVenta)
            BtnCancelar_Click(sender, e)
        Else
            CAyuda.Ejecutar("SP_UPDATE_ORDENVTA", codempresa, VCorrelInv, TxtOrdenVenta.Text)
            MsgBox("SE MODIFICO LA ORDEN DE VENTA " & vbCrLf & "NRO " & TxtOrdenVenta.Text)
            BtnCancelar_Click(sender, e)
        End If


    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        HabilitaBotones(True)
        LimpiaTemporal()
        CargarGrid()
        FormatoGrid()
        ' FormatoGridPtoVta()
        LimpiarVariables()
     
        DtFechaVenta.Value = Format(vFechaActual, "dd/MM/yyyy")

        DtFechaIni.Value = Format(vFechaActual, "dd/MM/yyyy")
        DtFechaFin.Value = Format(vFechaActual, "dd/MM/yyyy")


    End Sub

    Private Sub CboUsu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboUsu.SelectedIndexChanged
        If Habilita = True Then
            TxtResponsable.Text = TmpListarDatos("SP_SELECTUSUARIO  '" & codempresa & "','" & CboUsu.SelectedValue & "'").Rows(0)("Usuario")
        End If
    End Sub

    Private Sub BtnBuscOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscOrden.Click
        Dim FrmBusc As New FrmBuscOrdenVentaJ
        FrmBusc.TIPO = "F"
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        If FrmBusc.GridOrdenDesp.Item(FrmBusc.GridOrdenDesp.CurrentRowIndex, 3) = "A" Then
            MsgBox("ESTA ORDEN DE VENTA SE ENCUENTRA AUNLADO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC")
            Exit Sub
        End If

        Dim GUIAD As String

        TxtOrdenVenta.Text = FrmBusc.GridOrdenDesp.Item(FrmBusc.GridOrdenDesp.CurrentRowIndex, 1)
        GUIAD = FrmBusc.GridOrdenDesp.Item(FrmBusc.GridOrdenDesp.CurrentRowIndex, 6)
        'TxtOrdenVenta.Text = FrmBusc.GridOrdenDesp.Item(FrmBusc.GridOrdenDesp.CurrentRowIndex, 1)

        CAyuda.Ejecutar("SP_INSGUIAINTERNADETVTAJ", codempresa, VCorrelInv, TxtOrdenVenta.Text, GUIAD)
        TABLE_PTOVTADOC = TmpListarDatos("SP_GROUPTMP_GUIAINTERNADET_J   '" & codempresa & "','" & VCorrelInv & "','" & TxtOrdenVenta.Text & "'")
        DataGridView1.DataSource = TABLE_PTOVTADOC
        HabilitaBotones(False)
        'DgPtoVta_Click(sender, e)
        BtnCancelar.Enabled = True
        BTNELIMINAR.Enabled = True
        DataGridView1.Enabled = True

    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Modific = True
        HabilitaBotones(True)
    End Sub
    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'QuitarPtovta()
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If TxtOrdenVenta.Text.Trim = "" Then
            Exit Sub
        End If
        If MsgBox("ESTA SEGURO DE ANULAR LA ORDEN DE VENTA " & TxtOrdenVenta.Text.Trim, MsgBoxStyle.YesNo, "NAR SISTEMAS SAC") = MsgBoxResult.Yes Then
            If CAyuda.Ejecutar("SP_ANULAR_ORDENDEVENTA", codempresa, TxtOrdenVenta.Text, VCorrelInv) > 0 Then
                CAyuda.Ejecutar("SP_UPDATE_ORDENVTA", codempresa, VCorrelInv, TxtOrdenVenta.Text)
                MsgBox("SE ANULO CORRECTAMENTE... ", MsgBoxStyle.Information, "NAR SISTEMAS SAC")
                BtnCancelar_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BTNREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNREPORTE.Click
        If TxtOrdenVenta.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        Dim ORDENDESPACHO As String
        ORDENDESPACHO = TxtOrdenVenta.Text

        'CargarReporte()

        Try
            Rpt1.WindowShowExportBtn = True
            Rpt1.WindowShowPrintBtn = True
            Rpt1.WindowShowPrintSetupBtn = True
            Rpt1.set_StoredProcParam(0, codempresa)
            Rpt1.set_StoredProcParam(1, ORDENDESPACHO)
            Rpt1.set_StoredProcParam(2, "2")

            Rpt1.ReportFileName = rutareporte + CType("Rpt_Consolidado_Producto_VTA.rpt", String)
            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt1.Action = 1
            Rpt1.Reset()

        Catch ex As Exception
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub CboPtovta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPtovta.SelectedIndexChanged

    End Sub



    Private Sub DgPtoVta_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub DgPtoVta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        NombreCaja = DataGridView1
    End Sub

    Private Sub CboPtovta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboPtovta.GotFocus
        NombreCaja = CboPtovta
    End Sub

    Private Sub DtFechaIni_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFechaIni.ValueChanged

    End Sub

    Private Sub DtFechaIni_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtFechaIni.GotFocus
        NombreCaja = DtFechaIni
    End Sub

    Private Sub DtFechaFin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtFechaFin.GotFocus
        NombreCaja = DtFechaFin
    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        CargarDocum()
        CboPtovta.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = Me.DataGridView1.Columns(3).Index Then


            Dim chkCelda As DataGridViewCheckBoxCell = DirectCast(Me.DataGridView1.Rows(e.RowIndex).Cells(3), DataGridViewCheckBoxCell)

            If Convert.ToBoolean(chkCelda.Value) = True Then


                chkCelda.Value = False


                DataGridView1.Rows(e.RowIndex).Selected = False
            Else

                chkCelda.Value = True


                DataGridView1.Rows(e.RowIndex).Selected = True

            End If
        End If

    End Sub


    Private Sub BtnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMostrar.Click

        TmpInsertDatos("DELETE FROM TMP_PTOVTA_FILTRAR  WHERE CODEMPRESA='" & codempresa & "' AND  CORRNBR='" & VCorrelInv & "'")


        Dim PUNTOVENTA As String = ""

        If DataGridView1.Rows.Count > 0 Then
            For i As Integer = 0 To DataGridView1.Rows.Count - 1

                If CBool(DataGridView1.Rows(i).Cells(3).Value) = True Then
                    PUNTOVENTA = DataGridView1.Rows(i).Cells(0).Value
                    CAyuda.Ejecutar("SP_INS_TMP_PTOVTA_FILTRAR ", codempresa, VCorrelInv, CodUsuario, PUNTOVENTA)
                End If

                'If DataGridView1.Item("MOSTRAR", DataGridView1.CurrentRow.Index).Value() = Nothing Then
                '    MessageBox.Show("Debe especificar la  tasa de la moneda.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    txtmoneda.Focus()
                '    Exit Sub
                'End If
            Next


            CargarGrid()
            FormatoGrid()


        End If

    End Sub

    Private Sub DataGridDocumentos_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridDocumentos.Navigate

    End Sub

    Private Sub BTNREPORTE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNREPORTE1.Click




        'CargarReporte()

        Try
            Rpt1.WindowShowExportBtn = True
            Rpt1.WindowShowPrintBtn = True
            Rpt1.WindowShowPrintSetupBtn = True
            Rpt1.set_StoredProcParam(0, codempresa)
            Rpt1.set_StoredProcParam(1, VCorrelInv)


            Rpt1.ReportFileName = rutareporte + CType("RptOrdenVenta.rpt", String)
            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt1.Action = 1
            Rpt1.Reset()

        Catch ex As Exception
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
End Class
