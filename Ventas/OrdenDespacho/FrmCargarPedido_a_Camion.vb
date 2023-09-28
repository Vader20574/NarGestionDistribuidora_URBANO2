

Imports Servicios.Implementacion
Imports Servicios.Interfaces.TmpStockPedido
Imports Servicios.Interfaces.TmpStockPedido.Respuestas

Imports Servicios.Interfaces.Artidat
Imports Servicios.Interfaces.Artidat.Peticiones

Public Class FrmCargarPedido_a_Camion
    Inherits System.Windows.Forms.Form

    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""

    Dim Todo_Cate As Int16
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As Button

    Dim rand As Integer

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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnBusqVehicu As System.Windows.Forms.Button
    Friend WithEvents btnBusqRuta As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblTotalSoles As System.Windows.Forms.Label
    Friend WithEvents LblTotalPeso As System.Windows.Forms.Label
    Friend WithEvents LblCubicaje As System.Windows.Forms.Label
    Friend WithEvents DtFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblCargaUtil As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblDescripVehi As System.Windows.Forms.Label
    Friend WithEvents LblColor As System.Windows.Forms.Label
    Friend WithEvents BtnCargarPedidos As System.Windows.Forms.Button
    Friend WithEvents BtnVerDetalle As System.Windows.Forms.Button
    Friend WithEvents btnVerifiarStock As System.Windows.Forms.Button
    Friend WithEvents BtnGenerarGuia As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DtFechaDespacho As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DtHoraSalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ChkMarcaTodo As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelManteni As System.Windows.Forms.Panel
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBusOrden As System.Windows.Forms.Button
    Friend WithEvents LblOrdenDesp As System.Windows.Forms.Label
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CboCodVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents cboRuta As System.Windows.Forms.ComboBox
    Friend WithEvents TxtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtAyudante As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtDestino As System.Windows.Forms.TextBox
    Friend WithEvents GrDatoCab As System.Windows.Forms.GroupBox
    Friend WithEvents Rpt2 As AxCrystal.AxCrystalReport
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbcalle As System.Windows.Forms.ComboBox
    Friend WithEvents dgpedidos As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents btnvericredito As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargarPedido_a_Camion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtFecIni = New System.Windows.Forms.DateTimePicker()
        Me.DtFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblTotalPeso = New System.Windows.Forms.Label()
        Me.LblCubicaje = New System.Windows.Forms.Label()
        Me.LblTotalSoles = New System.Windows.Forms.Label()
        Me.LblCargaUtil = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblDescripVehi = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblColor = New System.Windows.Forms.Label()
        Me.GrDatoCab = New System.Windows.Forms.GroupBox()
        Me.TxtDestino = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtAyudante = New System.Windows.Forms.TextBox()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.CboCodVehiculo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaDespacho = New System.Windows.Forms.DateTimePicker()
        Me.btnBusqVehicu = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblOrdenDesp = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCargarPedidos = New System.Windows.Forms.Button()
        Me.BtnVerDetalle = New System.Windows.Forms.Button()
        Me.BtnGenerarGuia = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ChkMarcaTodo = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBusqRuta = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbcalle = New System.Windows.Forms.ComboBox()
        Me.cboRuta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelManteni = New System.Windows.Forms.Panel()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Rpt2 = New AxCrystal.AxCrystalReport()
        Me.dgpedidos = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBusOrden = New System.Windows.Forms.Button()
        Me.btnVerifiarStock = New System.Windows.Forms.Button()
        Me.btnvericredito = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.crRpt = New AxCrystal.AxCrystalReport()
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GrDatoCab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelManteni.SuspendLayout()
        CType(Me.Rpt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgpedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vehiculo:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(620, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RUTA : "
        Me.Label2.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(398, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "DESDE :"
        '
        'DtFecIni
        '
        Me.DtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecIni.Location = New System.Drawing.Point(442, 6)
        Me.DtFecIni.Name = "DtFecIni"
        Me.DtFecIni.Size = New System.Drawing.Size(102, 20)
        Me.DtFecIni.TabIndex = 3
        '
        'DtFecFin
        '
        Me.DtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecFin.Location = New System.Drawing.Point(598, 6)
        Me.DtFecFin.Name = "DtFecFin"
        Me.DtFecFin.Size = New System.Drawing.Size(94, 20)
        Me.DtFecFin.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(552, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "HASTA : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Total Peso : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(270, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Cubicaje : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(602, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Total Soles S/.: "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalPeso
        '
        Me.LblTotalPeso.BackColor = System.Drawing.Color.White
        Me.LblTotalPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPeso.Location = New System.Drawing.Point(114, 6)
        Me.LblTotalPeso.Name = "LblTotalPeso"
        Me.LblTotalPeso.Size = New System.Drawing.Size(100, 23)
        Me.LblTotalPeso.TabIndex = 1
        Me.LblTotalPeso.Text = "0.00"
        Me.LblTotalPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCubicaje
        '
        Me.LblCubicaje.BackColor = System.Drawing.Color.White
        Me.LblCubicaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCubicaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCubicaje.Location = New System.Drawing.Point(404, 6)
        Me.LblCubicaje.Name = "LblCubicaje"
        Me.LblCubicaje.Size = New System.Drawing.Size(100, 23)
        Me.LblCubicaje.TabIndex = 3
        Me.LblCubicaje.Text = "0.00"
        Me.LblCubicaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotalSoles
        '
        Me.LblTotalSoles.BackColor = System.Drawing.Color.White
        Me.LblTotalSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalSoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSoles.Location = New System.Drawing.Point(732, 6)
        Me.LblTotalSoles.Name = "LblTotalSoles"
        Me.LblTotalSoles.Size = New System.Drawing.Size(100, 23)
        Me.LblTotalSoles.TabIndex = 5
        Me.LblTotalSoles.Text = "0.00"
        Me.LblTotalSoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblCargaUtil
        '
        Me.LblCargaUtil.BackColor = System.Drawing.Color.White
        Me.LblCargaUtil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCargaUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCargaUtil.Location = New System.Drawing.Point(222, 85)
        Me.LblCargaUtil.Name = "LblCargaUtil"
        Me.LblCargaUtil.Size = New System.Drawing.Size(76, 23)
        Me.LblCargaUtil.TabIndex = 17
        Me.LblCargaUtil.Text = "0.00"
        Me.LblCargaUtil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(166, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Carga util : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDescripVehi
        '
        Me.LblDescripVehi.BackColor = System.Drawing.Color.White
        Me.LblDescripVehi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDescripVehi.Location = New System.Drawing.Point(72, 37)
        Me.LblDescripVehi.Name = "LblDescripVehi"
        Me.LblDescripVehi.Size = New System.Drawing.Size(278, 23)
        Me.LblDescripVehi.TabIndex = 4
        Me.LblDescripVehi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Color : "
        '
        'LblColor
        '
        Me.LblColor.BackColor = System.Drawing.Color.White
        Me.LblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblColor.Location = New System.Drawing.Point(72, 60)
        Me.LblColor.Name = "LblColor"
        Me.LblColor.Size = New System.Drawing.Size(278, 23)
        Me.LblColor.TabIndex = 10
        Me.LblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GrDatoCab
        '
        Me.GrDatoCab.Controls.Add(Me.TxtDestino)
        Me.GrDatoCab.Controls.Add(Me.Label18)
        Me.GrDatoCab.Controls.Add(Me.TxtAyudante)
        Me.GrDatoCab.Controls.Add(Me.TxtResponsable)
        Me.GrDatoCab.Controls.Add(Me.CboCodVehiculo)
        Me.GrDatoCab.Controls.Add(Me.Label6)
        Me.GrDatoCab.Controls.Add(Me.DtHoraSalida)
        Me.GrDatoCab.Controls.Add(Me.DtFechaDespacho)
        Me.GrDatoCab.Controls.Add(Me.Label1)
        Me.GrDatoCab.Controls.Add(Me.LblColor)
        Me.GrDatoCab.Controls.Add(Me.LblDescripVehi)
        Me.GrDatoCab.Controls.Add(Me.btnBusqVehicu)
        Me.GrDatoCab.Controls.Add(Me.LblCargaUtil)
        Me.GrDatoCab.Controls.Add(Me.Label14)
        Me.GrDatoCab.Controls.Add(Me.Label16)
        Me.GrDatoCab.Controls.Add(Me.Label17)
        Me.GrDatoCab.Controls.Add(Me.Label12)
        Me.GrDatoCab.Controls.Add(Me.Label13)
        Me.GrDatoCab.Controls.Add(Me.Label5)
        Me.GrDatoCab.Controls.Add(Me.Label19)
        Me.GrDatoCab.Controls.Add(Me.Label15)
        Me.GrDatoCab.Location = New System.Drawing.Point(116, 32)
        Me.GrDatoCab.Name = "GrDatoCab"
        Me.GrDatoCab.Size = New System.Drawing.Size(892, 110)
        Me.GrDatoCab.TabIndex = 5
        Me.GrDatoCab.TabStop = False
        Me.GrDatoCab.Text = "Datos Generales"
        '
        'TxtDestino
        '
        Me.TxtDestino.Location = New System.Drawing.Point(444, 86)
        Me.TxtDestino.Name = "TxtDestino"
        Me.TxtDestino.Size = New System.Drawing.Size(254, 20)
        Me.TxtDestino.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(394, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Destino : "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtAyudante
        '
        Me.TxtAyudante.Location = New System.Drawing.Point(444, 61)
        Me.TxtAyudante.Name = "TxtAyudante"
        Me.TxtAyudante.Size = New System.Drawing.Size(254, 20)
        Me.TxtAyudante.TabIndex = 11
        '
        'TxtResponsable
        '
        Me.TxtResponsable.Location = New System.Drawing.Point(444, 38)
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.Size = New System.Drawing.Size(254, 20)
        Me.TxtResponsable.TabIndex = 5
        '
        'CboCodVehiculo
        '
        Me.CboCodVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCodVehiculo.Location = New System.Drawing.Point(72, 14)
        Me.CboCodVehiculo.Name = "CboCodVehiculo"
        Me.CboCodVehiculo.Size = New System.Drawing.Size(134, 21)
        Me.CboCodVehiculo.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "0.00"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtHoraSalida
        '
        Me.DtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtHoraSalida.Location = New System.Drawing.Point(792, 61)
        Me.DtHoraSalida.Name = "DtHoraSalida"
        Me.DtHoraSalida.ShowUpDown = True
        Me.DtHoraSalida.Size = New System.Drawing.Size(94, 20)
        Me.DtHoraSalida.TabIndex = 13
        '
        'DtFechaDespacho
        '
        Me.DtFechaDespacho.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaDespacho.Location = New System.Drawing.Point(792, 38)
        Me.DtFechaDespacho.Name = "DtFechaDespacho"
        Me.DtFechaDespacho.Size = New System.Drawing.Size(94, 20)
        Me.DtFechaDespacho.TabIndex = 7
        '
        'btnBusqVehicu
        '
        Me.btnBusqVehicu.ImageIndex = 5
        Me.btnBusqVehicu.ImageList = Me.ImageList1
        Me.btnBusqVehicu.Location = New System.Drawing.Point(208, 11)
        Me.btnBusqVehicu.Name = "btnBusqVehicu"
        Me.btnBusqVehicu.Size = New System.Drawing.Size(34, 26)
        Me.btnBusqVehicu.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(702, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Fecha Despacho :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(726, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Hora Salida :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(366, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Responsable : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(390, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Ayudante : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Cubicaje :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(0, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Descripcion :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblOrdenDesp
        '
        Me.LblOrdenDesp.BackColor = System.Drawing.Color.White
        Me.LblOrdenDesp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblOrdenDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrdenDesp.Location = New System.Drawing.Point(350, 6)
        Me.LblOrdenDesp.Name = "LblOrdenDesp"
        Me.LblOrdenDesp.Size = New System.Drawing.Size(162, 23)
        Me.LblOrdenDesp.TabIndex = 2
        Me.LblOrdenDesp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NRO ORDEN DESPACHO:  "
        '
        'BtnCargarPedidos
        '
        Me.BtnCargarPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargarPedidos.Location = New System.Drawing.Point(698, 4)
        Me.BtnCargarPedidos.Name = "BtnCargarPedidos"
        Me.BtnCargarPedidos.Size = New System.Drawing.Size(98, 24)
        Me.BtnCargarPedidos.TabIndex = 7
        Me.BtnCargarPedidos.Text = "Cargar Pedidos"
        '
        'BtnVerDetalle
        '
        Me.BtnVerDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerDetalle.Location = New System.Drawing.Point(814, 148)
        Me.BtnVerDetalle.Name = "BtnVerDetalle"
        Me.BtnVerDetalle.Size = New System.Drawing.Size(96, 32)
        Me.BtnVerDetalle.TabIndex = 8
        Me.BtnVerDetalle.Text = "<<Ver Detalle>>"
        '
        'BtnGenerarGuia
        '
        Me.BtnGenerarGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerarGuia.Location = New System.Drawing.Point(6, 40)
        Me.BtnGenerarGuia.Name = "BtnGenerarGuia"
        Me.BtnGenerarGuia.Size = New System.Drawing.Size(84, 48)
        Me.BtnGenerarGuia.TabIndex = 1
        Me.BtnGenerarGuia.Text = "Generar  Orden de Despacho"
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(6, 192)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(84, 32)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        '
        'ChkMarcaTodo
        '
        Me.ChkMarcaTodo.Location = New System.Drawing.Point(820, 158)
        Me.ChkMarcaTodo.Name = "ChkMarcaTodo"
        Me.ChkMarcaTodo.Size = New System.Drawing.Size(90, 24)
        Me.ChkMarcaTodo.TabIndex = 9
        Me.ChkMarcaTodo.Text = "Marcar Todo"
        Me.ChkMarcaTodo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblTotalPeso)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.LblCubicaje)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.LblTotalSoles)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(18, 532)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(866, 38)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBusqRuta)
        Me.Panel2.Controls.Add(Me.BtnCargarPedidos)
        Me.Panel2.Controls.Add(Me.DtFecIni)
        Me.Panel2.Controls.Add(Me.DtFecFin)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.cmbcalle)
        Me.Panel2.Location = New System.Drawing.Point(10, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(802, 36)
        Me.Panel2.TabIndex = 7
        '
        'btnBusqRuta
        '
        Me.btnBusqRuta.ImageIndex = 5
        Me.btnBusqRuta.ImageList = Me.ImageList1
        Me.btnBusqRuta.Location = New System.Drawing.Point(336, 4)
        Me.btnBusqRuta.Name = "btnBusqRuta"
        Me.btnBusqRuta.Size = New System.Drawing.Size(34, 26)
        Me.btnBusqRuta.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 8)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "RUTA-CALLE :"
        '
        'cmbcalle
        '
        Me.cmbcalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcalle.Location = New System.Drawing.Point(108, 4)
        Me.cmbcalle.Name = "cmbcalle"
        Me.cmbcalle.Size = New System.Drawing.Size(222, 21)
        Me.cmbcalle.TabIndex = 1
        '
        'cboRuta
        '
        Me.cboRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRuta.Location = New System.Drawing.Point(662, 4)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.Size = New System.Drawing.Size(220, 21)
        Me.cboRuta.TabIndex = 0
        Me.cboRuta.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filtracion de Pedidos"
        '
        'PanelManteni
        '
        Me.PanelManteni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelManteni.Controls.Add(Me.BtnImprimir)
        Me.PanelManteni.Controls.Add(Me.BtnConsultar)
        Me.PanelManteni.Controls.Add(Me.BtnNuevo)
        Me.PanelManteni.Controls.Add(Me.BtnSalir)
        Me.PanelManteni.Controls.Add(Me.BtnGenerarGuia)
        Me.PanelManteni.Controls.Add(Me.BtnCancelar)
        Me.PanelManteni.Location = New System.Drawing.Point(912, 146)
        Me.PanelManteni.Name = "PanelManteni"
        Me.PanelManteni.Size = New System.Drawing.Size(96, 236)
        Me.PanelManteni.TabIndex = 10
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.ImageIndex = 11
        Me.BtnImprimir.ImageList = Me.ImageList1
        Me.BtnImprimir.Location = New System.Drawing.Point(6, 124)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(84, 32)
        Me.BtnImprimir.TabIndex = 3
        Me.BtnImprimir.Text = "Imprimir"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.Location = New System.Drawing.Point(6, 90)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(84, 32)
        Me.BtnConsultar.TabIndex = 2
        Me.BtnConsultar.Text = "Consultar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.ImageIndex = 0
        Me.BtnNuevo.ImageList = Me.ImageList1
        Me.BtnNuevo.Location = New System.Drawing.Point(6, 6)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(84, 32)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(6, 158)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(84, 32)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        '
        'Rpt2
        '
        Me.Rpt2.Enabled = True
        Me.Rpt2.Location = New System.Drawing.Point(890, 531)
        Me.Rpt2.Name = "Rpt2"
        Me.Rpt2.OcxState = CType(resources.GetObject("Rpt2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt2.Size = New System.Drawing.Size(28, 28)
        Me.Rpt2.TabIndex = 14
        '
        'dgpedidos
        '
        Me.dgpedidos.CaptionText = "Pedidos                                               =======================[ENT" &
    "ER]Ver Detalle -------- [F3]Eliminar======================="
        Me.dgpedidos.DataMember = ""
        Me.dgpedidos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgpedidos.Location = New System.Drawing.Point(10, 187)
        Me.dgpedidos.Name = "dgpedidos"
        Me.dgpedidos.ReadOnly = True
        Me.dgpedidos.Size = New System.Drawing.Size(898, 333)
        Me.dgpedidos.TabIndex = 11
        Me.dgpedidos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgpedidos
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Table"
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "# PEDIDO"
        Me.DataGridTextBoxColumn8.MappingName = "NUM_PEDIDO"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.HeaderText = "ORT"
        Me.DataGridBoolColumn1.MappingName = "ORT"
        Me.DataGridBoolColumn1.Width = 50
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "RAZON SOCIAL"
        Me.DataGridTextBoxColumn9.MappingName = "DESCLIENTE"
        Me.DataGridTextBoxColumn9.Width = 240
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = "0.00"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "TOTAL"
        Me.DataGridTextBoxColumn10.MappingName = "TOTAL"
        Me.DataGridTextBoxColumn10.NullText = "0"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "CONDIC. VENTA"
        Me.DataGridTextBoxColumn11.MappingName = "ESTADO"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 120
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "DISTRITO"
        Me.DataGridTextBoxColumn12.MappingName = "DISTRITO"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 130
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn13.Format = "0.00"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "PESO"
        Me.DataGridTextBoxColumn13.MappingName = "PESO"
        Me.DataGridTextBoxColumn13.NullText = "0"
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "RUTA"
        Me.DataGridTextBoxColumn14.MappingName = "RUTA"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 130
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(914, 395)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(930, 503)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(77, 20)
        Me.TextBox1.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 2
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(930, 530)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 40)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Faltante x Pedido"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'btnBusOrden
        '
        Me.btnBusOrden.ImageIndex = 5
        Me.btnBusOrden.ImageList = Me.ImageList1
        Me.btnBusOrden.Location = New System.Drawing.Point(516, 4)
        Me.btnBusOrden.Name = "btnBusOrden"
        Me.btnBusOrden.Size = New System.Drawing.Size(34, 26)
        Me.btnBusOrden.TabIndex = 3
        '
        'btnVerifiarStock
        '
        Me.btnVerifiarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerifiarStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerifiarStock.ImageIndex = 2
        Me.btnVerifiarStock.ImageList = Me.ImageList1
        Me.btnVerifiarStock.Location = New System.Drawing.Point(924, 422)
        Me.btnVerifiarStock.Name = "btnVerifiarStock"
        Me.btnVerifiarStock.Size = New System.Drawing.Size(90, 32)
        Me.btnVerifiarStock.TabIndex = 12
        Me.btnVerifiarStock.Text = "Verificar Stock"
        '
        'btnvericredito
        '
        Me.btnvericredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvericredito.Image = CType(resources.GetObject("btnvericredito.Image"), System.Drawing.Image)
        Me.btnvericredito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnvericredito.Location = New System.Drawing.Point(924, 460)
        Me.btnvericredito.Name = "btnvericredito"
        Me.btnvericredito.Size = New System.Drawing.Size(90, 37)
        Me.btnvericredito.TabIndex = 13
        Me.btnvericredito.Text = "Verificar Credito"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 2
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(1033, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 44)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Verificar Linea Vend"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1014, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 57)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Reporte Temporal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(547, 274)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 53
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Enabled = False
        Me.DtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(1058, 247)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaIni.TabIndex = 54
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Enabled = False
        Me.DtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(1058, 283)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaFin.TabIndex = 57
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(1018, 287)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 13)
        Me.Label32.TabIndex = 56
        Me.Label32.Text = "Hasta : "
        Me.Label32.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(1014, 253)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 13)
        Me.Label35.TabIndex = 55
        Me.Label35.Text = "Desde :"
        Me.Label35.Visible = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1033, 472)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 37)
        Me.Button4.TabIndex = 58
        Me.Button4.Text = "Verificar Distribucion"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.ImageIndex = 2
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(924, 576)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 32)
        Me.Button5.TabIndex = 59
        Me.Button5.Text = "Verificar Promo"
        '
        'FrmCargarPedido_a_Camion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1213, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DtFechaIni)
        Me.Controls.Add(Me.DtFechaFin)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dgpedidos)
        Me.Controls.Add(Me.Rpt2)
        Me.Controls.Add(Me.LblOrdenDesp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelManteni)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrDatoCab)
        Me.Controls.Add(Me.BtnVerDetalle)
        Me.Controls.Add(Me.btnBusOrden)
        Me.Controls.Add(Me.btnVerifiarStock)
        Me.Controls.Add(Me.ChkMarcaTodo)
        Me.Controls.Add(Me.cboRuta)
        Me.Controls.Add(Me.btnvericredito)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargarPedido_a_Camion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Packing  List (Orden Despacho)"
        Me.GrDatoCab.ResumeLayout(False)
        Me.GrDatoCab.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelManteni.ResumeLayout(False)
        CType(Me.Rpt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgpedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "FIELDS"
    Public TABLE_PEDIDO As New DataTable
    Private CodVehiculo As String
    Private CodRuta As String = String.Empty
    Private TABLE_PEDIDOS_CARGADOS As New DataTable
    Private TABLE_PEDIDOS_PROCESADOS As New DataTable
    Private TABLE_CANT_FALTANTE As New DataTable
    Private TABLE_DETALLE_PEDI As New DataTable
    Private TABLE_CABECERA_PEDI As New DataTable
    Private VerifStock As Boolean = False
    Private ActNuevo As Boolean = False
    Private CORREL As Integer
    Private TABLE_PED_CARGS As New DataTable
    Private Table_Ped_SinStock As New DataTable
    Private Table_Ped_ConStock As New DataTable
    Private TMP_GRIDDET As New DataTable
    Public TMP_PEDDELL As New DataTable

    Private Column As DataColumn
    Private fila As DataRow
    Public Dt_calles As New DataTable
    Public Devolver As Boolean
    Public Selecc As Integer ' 1 actual, 2 seleccionados, 3 todos

    Public desbloquerDeuda As Boolean = False

#End Region

#Region "FUNCIONES"

    Private Sub FORMATO_GRIDDET()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_GRIDDET.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "ITEM"
            .HeaderText = "Item"
            .Width = 25
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODALMACEN"
            .HeaderText = "Almacen"
            .NullText = ""
            .Width = 50
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "CODARTI"
            .HeaderText = "Codigo"
            .Width = 75
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "DESARTI"
            .HeaderText = "Descripcion"
            .Width = 200
        End With

        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "UNIDADES"
            .HeaderText = "Unidades"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column6 As New DataGridTextBoxColumn
        With column6
            .MappingName = "PRESPAQ"
            .HeaderText = "Pres. Paq."
            .Width = 120
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column8 As New DataGridTextBoxColumn
        With column8
            .MappingName = "PRESUND"
            .HeaderText = "Pres. Und."
            .Width = 100
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With

        Dim column9 As New DataGridTextBoxColumn
        With column9
            .MappingName = "PRECIO"
            .HeaderText = "Precio Promedio"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column10 As New DataGridTextBoxColumn
        With column10
            .MappingName = "PESO"
            .HeaderText = "Peso Promedio"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column11 As New DataGridTextBoxColumn
        With column11
            .MappingName = "UNDFALTANTE"
            .HeaderText = "Unidades Faltanntes"
            .Width = 75
            .NullText = ""
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With

        'GridPedido.TableStyles.Clear()
        'TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5, column6, column8, column9, column10, column11})
        'GridPedido.TableStyles.Add(TableStyle1)


    End Sub
    Private Sub cargarPed_ConStock()

        Dim NUM_PEDIDO As String
        Table_Ped_ConStock.Clear()
        For i As Integer = 0 To TABLE_PEDIDO.Rows.Count - 1
            If TABLE_PEDIDO.Rows(i)("CARGAR").ToString.Trim = 1 Then
                NUM_PEDIDO = TABLE_PEDIDO.Rows(i)("NUM_PEDIDO").ToString.Trim
                Dim tablecarg As New DataTable
                tablecarg = TmpListarDatos("NSP_BUSCAR_ARTI_PEDVTADET  '" & codempresa & "','" & NUM_PEDIDO & "'")
                If Table_Ped_ConStock.Rows.Count > 0 Then
                    For ins As Integer = 0 To tablecarg.Rows.Count - 1
                        Table_Ped_ConStock.ImportRow(tablecarg.Rows(ins))
                    Next
                Else
                    Table_Ped_ConStock = TmpListarDatos("NSP_BUSCAR_ARTI_PEDVTADET  '" & codempresa & "','" & NUM_PEDIDO & "'")
                End If
            End If
        Next
    End Sub
    Private Sub CargarDatosVehiculo()
        Dim TABLE_BUS As New DataTable
        TABLE_BUS = TmpListarDatos("NSP_TRAER_VEHICULOXCOD  '" & codempresa & "','" & CodVehiculo & "'")
        If TABLE_BUS.Rows.Count > 0 Then
            CboCodVehiculo.SelectedValue = TABLE_BUS.Rows(0)("CODVEHI").ToString.Trim
            LblDescripVehi.Text = TABLE_BUS.Rows(0)("DESVEHI").ToString.Trim
            LblColor.Text = TABLE_BUS.Rows(0)("COLOR").ToString.Trim
            LblCargaUtil.Text = Format(CDbl(TABLE_BUS.Rows(0)("CARGAUTIL").ToString.Trim), "#######0.00")
            Label6.Text = Format(CDbl(TABLE_BUS.Rows(0)("CBKILPET").ToString.Trim), "#######0.00")


        End If

    End Sub
    Private Sub OBTENERCORRELATIVO_INVENTARIO()
        Dim SQL As String
        Dim DS As New DataTable
        SQL = "ObtenerCorrelInventario '" & CodUsuario & "'"
        DS = TmpListarDatos(SQL)
        CORREL = DS.Rows(0)(0)
    End Sub
    Private Sub CargarCombosPikimg()
        CAyuda.CargarDataCombo(CboCodVehiculo, "NSP_LISTA_VEHICULO  '" & codempresa & "'", "codvehi", "nombre")
        CAyuda.CargarDataCombo(cboRuta, "NSP_LISTAR_RUTA_CARGPED  '" & codempresa & "'", "CODIGO", "DESCRIPCION")
    End Sub
    Private Sub Formato_Grilla(ByVal TABLA As DataTable)
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = TABLA.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With

        'Dim grdColStyle1 As New DataGridTextBoxColumn
        'With grdColStyle1
        '    .HeaderText = "CODEMPRESA"
        '    .MappingName = "CODEMPRESA"
        '    .Width = 0
        'End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "NUM_PEDIDO"
            .MappingName = "NUM_PEDIDO"
            .Width = 75
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "COD_CLIENTE"
            .MappingName = "CODCLIENTE"
            .Width = 75
        End With
        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "CLIENTE"
            .MappingName = "DATOADJUNTO"
            .Width = 210
        End With
        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "FECHA"
            .MappingName = "FECHA"
            .Width = 70
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "CODVENDEDOR"
            .MappingName = "CODVENDEDOR"
            .Width = 0
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "VENDEDOR"
            .MappingName = "DSVEND"
            .Width = 110
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "COD_RUTA"
            .MappingName = "COD_RUTA"
            .Width = 0
        End With
        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "RUTA"
            .MappingName = "DESCRIPCION"
            .Width = 180
        End With
        Dim grdColStyle9 As New DataGridTextBoxColumn
        With grdColStyle9
            .HeaderText = "MONTO_TOTAL"
            .MappingName = "MONTO_TOTAL"
            .Width = 50
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
        End With
        Dim grdColStyle10 As New DataGridTextBoxColumn
        With grdColStyle10
            .HeaderText = "PESO"
            .MappingName = "PESO_TOTAL"
            .Width = 50
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
        End With
        Dim grdColStyle11 As New DataGridTextBoxColumn
        With grdColStyle11
            .HeaderText = "CUBICAJE"
            .MappingName = "CUBICAJE_TOTAL"
            .Width = 50
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8, grdColStyle9, grdColStyle10, grdColStyle11})
        'Me.GridPedido.TableStyles.Add(grdTableStyle1)

    End Sub
    Sub CargarDatos_Busqueda()


        TmpInsertDatos("SP_LIMP_TMP_GUIAINTERNADET  '" & codempresa & "','" & CORREL & "'")

        '  Dim TMP_LISTAR_DESPACHO As New DataTable
        Dim TMP_ORDENDESP As New DataTable
        TMP_ORDENDESP = TmpListarDatos("NSP_TRAER_ORDENDESPACHO  '" & codempresa & "', '" & CORREL & "','" & LblOrdenDesp.Text & "'")
        'TMP_GRIDDET = (TmpListarDatos("SELECT  * FROM  TMP_CARGAPEDIDODET WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & CORREL & "'  ORDER BY ITEM  ASC "))
        'GridPedido.DataSource = TMP_GRIDDET

        TmpInsertDatos("SP_LIMP_TEMP_DETAL_PEDIDO  '" & codempresa & "','" & CORREL & "'")
        TmpInsertDatos("SP_INS_TMP_CARGAPEDIDODET_2  '" & codempresa & "','" & CORREL & "'")

        TMP_PEDDELL = CAyuda.ListarDatos("SP_CARGAR_PED_CAB", codempresa, CORREL).Tables(0)
        dgpedidos.DataSource = Nothing
        dgpedidos.DataSource = TMP_PEDDELL

        Dim TMP_MONTO As New DataTable
        TMP_MONTO = TmpListarDatos("SP_ONTENER_MONTO_TMPCARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")
        If TMP_MONTO.Rows.Count > 0 Then
            LblTotalPeso.Text = Format(TMP_MONTO.Rows(0)("PESO"), "0.00")
            LblTotalSoles.Text = Format(TMP_MONTO.Rows(0)("TOTBAS"), "0.00")
            'LblCubicaje.Text = 0.0
        End If
        DtFechaDespacho.Value = CDate(TMP_ORDENDESP.Rows(0)("FECDESPACHO"))
        DtHoraSalida.Value = CDate("01/01/2010" + "  " + TMP_ORDENDESP.Rows(0)("HORADESPACHO"))
        CboCodVehiculo.SelectedValue = TMP_ORDENDESP.Rows(0)("CODVEHICULO")
        TxtResponsable.Text = TMP_ORDENDESP.Rows(0)("RESPONSABLE")
        TxtAyudante.Text = TMP_ORDENDESP.Rows(0)("AYUDANTE")
        TxtDestino.Text = TMP_ORDENDESP.Rows(0)("DESTINO")
        GrDatoCab.Enabled = False

    End Sub
    Sub HABILITAR(ByVal VALOR As Boolean)
        btnBusOrden.Visible = Not VALOR
        BtnConsultar.Enabled = Not VALOR
        BtnNuevo.Enabled = VALOR
    End Sub
    Sub HABILITAR_NUEVO(ByVal VALOR As Boolean)
        BtnNuevo.Enabled = Not VALOR
        BtnConsultar.Enabled = Not VALOR
        btnBusOrden.Visible = Not VALOR
        BtnImprimir.Enabled = Not VALOR
        GrDatoCab.Enabled = VALOR
        Panel2.Enabled = VALOR
        btnVerifiarStock.Enabled = VALOR
        btnvericredito.Enabled = VALOR
    End Sub
    Function GENERAR_ORDEN_DESPACHO() As String
        Dim TablePtoVta As New DataTable
        TablePtoVta = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGVTA", codempresa).Tables(0)
        Return TablePtoVta.Rows(0)("NRODESPACHO").ToString.Trim
    End Function
    Private Sub CARGAPEDIDO_CAB()

    End Sub
    Public Sub CARGARPEDIDOS(Optional ByVal nuevo As Boolean = True)
        'Exit Sub
        'If nuevo = True Then
        If nuevo = True Then
            ' TmpInsertDatos("SP_LIMP_TEMP_DETAL_PEDIDO  '" & codempresa & "','" & CORREL & "'")

            '    For A As Integer = 0 To cmbcalle.Items.Count - 1
            '        TmpInsertDatos("SP_INS_TMP_GUIAINTERNADET   '" & codempresa & "','" & CORREL & "','" & cmbcalle.Items(A).row(0) & "','" & Format(CDate(DtFecIni.Value), "dd/MM/yyyy") & "','" & Format(CDate(DtFecFin.Value), "dd/MM/yyyy") & "', '" & CDZONA & "','" & Format(CDate(DtFechaDespacho.Value), "dd/MM/yyyy") & "'")
            '    Next
            'End If
            'TmpInsertDatos("SP_INS_TMP_GUIAINTERNADET   '" & codempresa & "','" & CORREL & "','" & cboRuta.SelectedValue & "','" & Format(CDate(DtFecIni.Value), "dd/MM/yyyy") & "','" & Format(CDate(DtFecFin.Value), "dd/MM/yyyy") & "', '" & CDZONA & "','" & Format(CDate(DtFechaDespacho.Value), "dd/MM/yyyy") & "'")
            'TmpInsertDatos("SP_INS_TMP_CARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")

            'Dim TMP_PEDIDOS As DataTable
            'TMP_PEDIDOS = (TmpListarDatos("SELECT DISTINCT(NUM_PEDIDO) FROM TMP_GUIAINTERNADET WHERE CORRNBR='" & CORREL & "'  ORDER BY NUM_PEDIDO  ASC "))
            'For i As Integer = 0 To TMP_PEDIDOS.Rows.Count - 1


            '    ' CAyuda.Ejecutar("SP_ORDERNAR_ITEM_TMP_GUIAINTERNADET_T", codempresa, CORREL, TMP_PEDIDOS.Rows(i)(0))
            'Next

            TmpInsertDatos("SP_LIMP_TEMP_DETAL_PEDIDO  '" & codempresa & "','" & CORREL & "'")

            TmpInsertDatos("SP_INS_TMP_CARGAPEDIDODET_2  '" & codempresa & "','" & CORREL & "'")



            TmpInsertDatos("SP_CALCULAR_STOCKFALTANTE  '" & codempresa & "','" & CORREL & "'")
        End If

        TMP_PEDDELL = CAyuda.ListarDatos("SP_CARGAR_PED_CAB", codempresa, CORREL).Tables(0)
        dgpedidos.DataSource = Nothing
        dgpedidos.DataSource = TMP_PEDDELL
        'TMP_GRIDDET = (TmpListarDatos("SELECT  ITEM,CODALMACEN,CODARTI,DESARTI,UNIDADES,PRESPAQ,PRESUND,PRECIO,PESO,UNDFALTANTE  FROM  TMP_CARGAPEDIDODET WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & CORREL & "'  ORDER BY ITEM  ASC "))
        'GridPedido.DataSource = TMP_GRIDDET' TODOS SLOS DE DETALLES DE LOS PEDIDOS

        Dim TMP_MONTO As New DataTable
        TMP_MONTO = TmpListarDatos("SP_ONTENER_MONTO_TMPCARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")
        If TMP_MONTO.Rows.Count > 0 Then
            LblTotalPeso.Text = TMP_MONTO.Rows(0)("PESO")
            LblTotalSoles.Text = TMP_MONTO.Rows(0)("TOTBAS")
        End If
        LblTotalPeso.Text = FormatoMonto(CDbl(LblTotalPeso.Text), DECIRESU)
        LblTotalSoles.Text = FormatoMonto(CDbl(LblTotalSoles.Text), DECIRESU)


        Dim TMP_CUBICAJE As New DataTable
        TMP_CUBICAJE = TmpListarDatos("SP_ONTENER_CUBICAJE_TMPCARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")
        If TMP_CUBICAJE.Rows.Count > 0 Then
            LblCubicaje.Text = TMP_CUBICAJE.Rows(0)("CUBICAJE")
        End If
        LblCubicaje.Text = FormatoMonto(CDbl(LblCubicaje.Text), 5)






    End Sub
    Sub ACTUALIZARCABECERA()

        Dim NoInsertar As Boolean
        Dim CODTIPODOC As String = ""
        Dim NRO_DOCU As String = ""
        Dim TIPO_DOC As String = ""
        Dim COD_CLIENTE As String = ""
        Dim DIRECCION As String = ""
        Dim FilaInser As Integer
        TABLE_CABECERA_PEDI.Rows.Clear()
        For Inst As Integer = 0 To TABLE_DETALLE_PEDI.Rows.Count - 1
            For detall As Integer = 0 To TABLE_CABECERA_PEDI.Rows.Count - 1
                If TABLE_DETALLE_PEDI.Rows(Inst)("CODTIPODOC").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("CODTIPODOC").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("TIPO_DOC").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("TIPO_DOC").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("CODCLIENTE").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("CODCLIENTE").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("DIRECCION").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("DIRECCION").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("NRODOCU").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("NRODOCU").ToString.Trim Then
                    NoInsertar = True
                    GoTo sumar
                End If
            Next
            If NoInsertar = False Then
                FilaInser = TABLE_CABECERA_PEDI.Rows.Count
                Dim FILA As DataRow = TABLE_CABECERA_PEDI.NewRow
                FILA("CODTIPODOC") = TABLE_DETALLE_PEDI.Rows(Inst)("CODTIPODOC").ToString.Trim
                FILA("TIPO_DOC") = TABLE_DETALLE_PEDI.Rows(Inst)("TIPO_DOC").ToString.Trim
                FILA("CODEMPRESA") = TABLE_DETALLE_PEDI.Rows(Inst)("CODEMPRESA").ToString.Trim
                FILA("CODCLIENTE") = TABLE_DETALLE_PEDI.Rows(Inst)("CODCLIENTE").ToString.Trim
                FILA("RUC") = TABLE_DETALLE_PEDI.Rows(Inst)("RUC").ToString.Trim
                FILA("DIRECCION") = TABLE_DETALLE_PEDI.Rows(Inst)("DIRECCION").ToString.Trim
                FILA("DATOADJUNTO") = TABLE_DETALLE_PEDI.Rows(Inst)("DATOADJUNTO").ToString.Trim
                FILA("CODTIPOPAGO") = TABLE_DETALLE_PEDI.Rows(Inst)("CODTIPOPAGO").ToString.Trim
                FILA("DSTIPOPAGO") = TABLE_DETALLE_PEDI.Rows(Inst)("DSTIPOPAGO").ToString.Trim
                FILA("MONTO") = 0.0
                FILA("NROGUIA") = TABLE_DETALLE_PEDI.Rows(Inst)("NROGUIA").ToString.Trim
                FILA("CODARTI") = TABLE_DETALLE_PEDI.Rows(Inst)("CODARTI").ToString.Trim
                FILA("DESARTI") = TABLE_DETALLE_PEDI.Rows(Inst)("DESARTI").ToString.Trim
                FILA("DESPRES") = TABLE_DETALLE_PEDI.Rows(Inst)("DESPRES").ToString.Trim
                FILA("DETALLE") = TABLE_DETALLE_PEDI.Rows(Inst)("DETALLE").ToString.Trim
                FILA("CANTIDAD") = TABLE_DETALLE_PEDI.Rows(Inst)("CANTIDAD").ToString.Trim
                FILA("PRECIO_ART") = TABLE_DETALLE_PEDI.Rows(Inst)("PRECIO_ART").ToString.Trim
                FILA("TOTBAS") = 0.0
                FILA("NRODOCU") = TABLE_DETALLE_PEDI.Rows(Inst)("NRODOCU").ToString.Trim
                TABLE_CABECERA_PEDI.Rows.Add(FILA)
                TABLE_CABECERA_PEDI.AcceptChanges()

                CODTIPODOC = TABLE_DETALLE_PEDI.Rows(Inst)("CODTIPODOC").ToString.Trim
                TIPO_DOC = TABLE_DETALLE_PEDI.Rows(Inst)("TIPO_DOC").ToString.Trim
                COD_CLIENTE = TABLE_DETALLE_PEDI.Rows(Inst)("CODCLIENTE").ToString.Trim
                DIRECCION = TABLE_DETALLE_PEDI.Rows(Inst)("DIRECCION").ToString.Trim
                NRO_DOCU = TABLE_DETALLE_PEDI.Rows(Inst)("NRODOCU").ToString.Trim

            End If
            NoInsertar = False
            For detall As Integer = 0 To TABLE_DETALLE_PEDI.Rows.Count - 1
                If TABLE_DETALLE_PEDI.Rows(detall)("CODTIPODOC").ToString.Trim = CODTIPODOC.Trim _
                And TABLE_DETALLE_PEDI.Rows(detall)("TIPO_DOC").ToString.Trim = TIPO_DOC _
                And TABLE_DETALLE_PEDI.Rows(detall)("CODCLIENTE").ToString.Trim = COD_CLIENTE _
                And TABLE_DETALLE_PEDI.Rows(detall)("DIRECCION").ToString.Trim = DIRECCION _
                And TABLE_DETALLE_PEDI.Rows(detall)("NRODOCU").ToString.Trim = NRO_DOCU Then
                    TABLE_CABECERA_PEDI.Rows(FilaInser)("TOTBAS") = CDbl(TABLE_CABECERA_PEDI.Rows(FilaInser)("TOTBAS").ToString.Trim) + CDbl(TABLE_DETALLE_PEDI.Rows(detall)("TOTBAS").ToString.Trim)
                    TABLE_CABECERA_PEDI.AcceptChanges()
                End If
            Next
sumar:
            NoInsertar = False

        Next


    End Sub
    Sub ActualizarGrid()
        LblTotalSoles.Text = Format(CDbl(0), "#######0.00")
        LblTotalPeso.Text = Format(CDbl(0), "#######0.00")
        LblCubicaje.Text = Format(CDbl(0), "#######0.00")
        For i As Integer = 0 To TABLE_PEDIDO.Rows.Count - 1
            If TABLE_PEDIDO.Rows(i)("Cargar") = 1 Then
                LblTotalSoles.Text = Format(CDbl(LblTotalSoles.Text) + CDbl(TABLE_PEDIDO.Rows(i)("TOTBAS").ToString), "#######0.00")
                LblTotalPeso.Text = Format(CDbl(LblTotalPeso.Text) + CDbl(TABLE_PEDIDO.Rows(i)("TOTALPESO").ToString), "#######0.00")
                LblCubicaje.Text = Format(CDbl(LblCubicaje.Text) + CDbl(TABLE_PEDIDO.Rows(i)("TOTALCUBICAJE").ToString), "#######0.00")
            End If
        Next

        'GridPedido.DataSource = TABLE_PEDIDO
        'DataGridTableStyle1.MappingName = TABLE_PEDIDO.TableName
        'DataGridTableStyle1.GridColumnStyles(0).MappingName = "NUM_PEDIDO"
        'DataGridTableStyle1.GridColumnStyles(1).MappingName = "NOMCLI"
        'DataGridTableStyle1.GridColumnStyles(2).MappingName = "FECHA"
        'DataGridTableStyle1.GridColumnStyles(3).MappingName = "DSVEND"
        'DataGridTableStyle1.GridColumnStyles(4).MappingName = "DESCRIPCION"
        'DataGridTableStyle1.GridColumnStyles(5).MappingName = "TOTALPESO"
        'DataGridTableStyle1.GridColumnStyles(6).MappingName = "TOTALCUBICAJE"
        'DataGridTableStyle1.GridColumnStyles(7).MappingName = "TOTBAS"
        'DataGridTableStyle1.GridColumnStyles(8).MappingName = "Cargar"
        'Me.GridPedido.TableStyles.Add(DataGridTableStyle1)

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        If TMP_PEDDELL.Rows.Count = 0 Then
            Exit Function
        End If

        Const Wd_KeyDown As Integer = &H100
        Const Wd_SysKeyDown As Integer = &H104
        If ((MSG.Msg = Wd_KeyDown) Or (MSG.Msg = Wd_SysKeyDown)) Then
            Select Case (KeyData)

                '        If ActNuevo = True Then

                '            'If Me.GridPedido.CurrentRowIndex < 0 Then
                '            '    Exit Function
                '            'End If
                '            'If TABLE_PEDIDO.Rows(GridPedido.CurrentRowIndex)("Cargar") = 0 Then
                '            '    TABLE_PEDIDO.Rows(GridPedido.CurrentRowIndex)("Cargar") = 1
                '            'Else
                '            '    TABLE_PEDIDO.Rows(GridPedido.CurrentRowIndex)("Cargar") = 0
                '            'End If
                '            'LblTotalSoles.Text = 0.0
                '            'LblTotalPeso.Text = 0.0
                '            'LblCubicaje.Text = 0.0
                '            'For i As Integer = 0 To TABLE_PEDIDO.Rows.Count - 1
                '            '    If TABLE_PEDIDO.Rows(i)("Cargar") = 1 Then
                '            '        LblTotalSoles.Text = Format(CDbl(LblTotalSoles.Text) + CDbl(TABLE_PEDIDO.Rows(i)("TOTBAS").ToString), "#######0.00")
                '            '        LblTotalPeso.Text = Format(CDbl(LblTotalPeso.Text) + CDbl(TABLE_PEDIDO.Rows(i)("TOTALPESO").ToString), "#######0.00")
                '            '        LblCubicaje.Text = Format(CDbl(LblCubicaje.Text) + CDbl(TABLE_PEDIDO.Rows(i)("TOTALCUBICAJE").ToString), "#######0.00")
                '            '    End If
                '            'Next
                '            'If CDbl(LblTotalSoles.Text) = 0 Then
                '            '    LblTotalSoles.Text = Format(CDbl(0), "#######0.00")
                '            'End If
                '            'If CDbl(LblTotalPeso.Text) = 0 Then
                '            '    LblTotalPeso.Text = Format(CDbl(0), "#######0.00")
                '            'End If
                '            'If CDbl(LblCubicaje.Text) = 0 Then
                '            '    LblCubicaje.Text = Format(CDbl(0), "#######0.00")
                '            'End If
                '            ''GridPedido.DataSource = TABLE_PEDIDO
                '            'DataGridTableStyle1.MappingName = TABLE_PEDIDO.TableName
                '            'DataGridTableStyle1.GridColumnStyles(0).MappingName = "NUM_PEDIDO"
                '            'DataGridTableStyle1.GridColumnStyles(1).MappingName = "NOMCLI"
                '            'DataGridTableStyle1.GridColumnStyles(2).MappingName = "FECHA"
                '            'DataGridTableStyle1.GridColumnStyles(3).MappingName = "DSVEND"
                '            'DataGridTableStyle1.GridColumnStyles(4).MappingName = "DESCRIPCION"
                '            'DataGridTableStyle1.GridColumnStyles(5).MappingName = "TOTALPESO"
                '            'DataGridTableStyle1.GridColumnStyles(6).MappingName = "TOTALCUBICAJE"
                '            'DataGridTableStyle1.GridColumnStyles(7).MappingName = "TOTBAS"
                '            'DataGridTableStyle1.GridColumnStyles(8).MappingName = "Cargar"
                '            'Me.GridPedido.TableStyles.Add(DataGridTableStyle1)
                '        End If
                '    End If
                'Case Keys.Enter '---Ver Detalle 
                '    Dim sender As Object
                '    Dim e As EventArgs
                '    If GridPedido.Focus = True Then
                '        BtnVerDetalle_Click(sender, e)
                '    End If
                'Case Keys.F3  'Para Eliminar
                '    If TMP_GRIDDET.Rows.Count > 0 Then
                '        If GridPedido.Focus = True Then
                '            TmpInsertDatos("SP_ELI_TMP_GUIAINTERNADET  '" & codempresa & "','" & CORREL & "','" & GridPedido.Item(GridPedido.CurrentRowIndex, 2) & "'")
                '            TmpInsertDatos("SP_INS_TMP_CARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")
                '            TMP_GRIDDET = (TmpListarDatos("SELECT  * FROM  TMP_CARGAPEDIDODET WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & CORREL & "'  ORDER BY ITEM  ASC "))
                '            GridPedido.DataSource = TMP_GRIDDET
                '            Dim TMP_MONTO As New DataTable
                '            TMP_MONTO = TmpListarDatos("SP_ONTENER_MONTO_TMPCARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")
                '            If TMP_MONTO.Rows.Count > 0 Then
                '                LblTotalPeso.Text = TMP_MONTO.Rows(0)("PESO")
                '                LblTotalSoles.Text = TMP_MONTO.Rows(0)("TOTBAS")

                '            End If
                '            LblTotalPeso.Text = FormatoMonto(CDbl(LblTotalPeso.Text), DECIRESU)
                '            LblTotalSoles.Text = FormatoMonto(CDbl(LblTotalSoles.Text), DECIRESU)


                '            FORMATO_GRIDDET()
                '        End If

                Case Keys.F3
                    If Me.dgpedidos.Focus = True Then
                        TmpInsertDatos("SP_ELI_TMP_GUIAINTERNADET  '" & codempresa & "','" & CORREL & "','" & dgpedidos.Item(dgpedidos.CurrentRowIndex, 0) & "'")
                        CARGARPEDIDOS(False)
                    End If
                Case Keys.Enter
                    BtnVerDetalle.PerformClick()
            End Select

        End If
    End Function
    Sub LIMPIAR()
        dgpedidos.DataSource = Nothing
        LblTotalPeso.Text = "0.00"
        LblCubicaje.Text = "0.00"
        LblTotalSoles.Text = "0.00"
        LblCargaUtil.Text = "0.00"
        TxtResponsable.Text = ""
        TxtAyudante.Text = ""
        TxtDestino.Text = ""

        'LblVehiculo.Text = ""
        LblDescripVehi.Text = ""
        LblOrdenDesp.Text = ""
        LblColor.Text = ""
        'lbRuta.Text = ""
        DtFecIni.Value = Date.Now
        DtFecFin.Value = Date.Now
        DtFechaDespacho.Value = Date.Now
        DtHoraSalida.Value = Date.Now
        ChkMarcaTodo.CheckState = CheckState.Unchecked
        TmpInsertDatos("SP_LIMPIA_TEMPORALES_CARGPED  '" & codempresa & "','" & CORREL & "'")
        'GrDatoCab.Enabled = True
        TMP_PEDDELL.Rows.Clear()

    End Sub

#End Region

    Private Sub Cargar_Calle()
        Me.Column = New DataColumn
        Me.Column.DataType = Type.GetType("System.String")
        Me.Column.ColumnName = "Codigo"
        Dt_calles.Columns.Add(Column)

        Me.Column = New DataColumn
        Me.Column.DataType = Type.GetType("System.String")
        Me.Column.ColumnName = "Descripcion"
        Dt_calles.Columns.Add(Column)

    End Sub

    Private Sub FrmCargarPedido_a_Camion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim CODVEHICULO As New DataColumn
        Dim CODCLIENTE As New DataColumn
        Dim CODRUTA As New DataColumn
        Dim CODPRESENTACION As New DataColumn
        Dim CODARTICULO As New DataColumn
        Dim CANTIDAD As New DataColumn

        TABLE_PEDIDOS_CARGADOS.Columns.Add(CODVEHICULO)
        TABLE_PEDIDOS_CARGADOS.Columns.Add(CODCLIENTE)
        TABLE_PEDIDOS_CARGADOS.Columns.Add(CODRUTA)
        TABLE_PEDIDOS_CARGADOS.Columns.Add(CODPRESENTACION)
        TABLE_PEDIDOS_CARGADOS.Columns.Add(CODARTICULO)
        TABLE_PEDIDOS_CARGADOS.Columns.Add(CANTIDAD)

        TABLE_CANT_FALTANTE.Columns.Add("NROPEDIDO")
        TABLE_CANT_FALTANTE.Columns.Add("VENDEDOR")
        TABLE_CANT_FALTANTE.Columns.Add("CODART")
        TABLE_CANT_FALTANTE.Columns.Add("DESCRIPCION")
        TABLE_CANT_FALTANTE.Columns.Add("CANT_PEDIDA")
        TABLE_CANT_FALTANTE.Columns.Add("PRESENTACION")
        TABLE_CANT_FALTANTE.Columns.Add("CANT_FALTANTE")
        TABLE_CANT_FALTANTE.Columns.Add("PROCESAR")

        ObtenerPtoVta(Environment.MachineName.Trim)
        CargarCombosPikimg()
        HABILITAR_NUEVO(False)
        OBTENERCORRELATIVO_INVENTARIO()
        Cargar_Calle()
        TmpInsertDatos("SP_LIMPIA_TEMPORALES_CARGPED  '" & codempresa & "','" & CORREL & "'")

        Me.DtFechaDespacho.Value = Format(vFechaActual, "dd/MM/yyyy")

        CAyuda.CargarDataCombo(ComboBox1, "Nsp_select_Almacen  '" & codempresa & "'", "codigo", "descripcion")

        DtFechaDespacho.Value = Format(vFechaActual, "dd/MM/yyyy")
        DtFecIni.Value = Format(vFechaActual, "dd/MM/yyyy")
        DtFecFin.Value = Format(vFechaActual, "dd/MM/yyyy")

        ' ----------------------------------------------------------
        DtFechaIni.Value = vFechaActual.AddDays(-1)
        DtFechaFin.Value = CType(CAyuda.ListarDatos("SP_FECHA_AUMENTO_DIAS", CANT_DIAS_ADE).Tables(0).Rows(0)(0), Date)

        Dim dt2 As New DataTable
        dt2 = CAyuda.ListarDatos("SELEC_CIERRE_MES", codempresa).Tables(0)
        Dim AÑO As String
        Dim MES As String
        AÑO = dt2.Rows(0)(0)
        MES = dt2.Rows(0)(1)

        Dim Fecharf As Date

        Dim Table_Correlativo2 As DataTable
        Table_Correlativo2 = CAyuda.ListarDatos("SP_EXTRADIA", AÑO, MES).Tables(0)
        DtFechaIni.Value = CDate(Table_Correlativo2.Rows(0)(0).ToString)

        Fecharf = DateAdd("d", +1, DtFechaIni.Value)

        DtFechaIni.Value = Fecharf

    End Sub


    Sub CALC_STOK()

        Dim gestordeArtidat As IGestorDeArtidat = New GestorDeArtidat()
        Dim gestordetmpstockped As IGestorDeTmpStockPedido = New GestorDeTmpStockPedido()

        Dim listastockpedreg As List(Of TmpStockPedidoRegistrado) = New List(Of TmpStockPedidoRegistrado)()
        listastockpedreg = gestordetmpstockped.Listar(codempresa, CORREL)

        Dim stk_act As Integer
        For Each s As TmpStockPedidoRegistrado In listastockpedreg
            stk_act = gestordetmpstockped.Extraer_Stock(s.CODARTI, ComboBox1.SelectedValue, rand)
            Dim artidatact As ArtidatActualizar = New ArtidatActualizar()
            artidatact.CODARTI = s.CODARTI
            artidatact.CODALMACEN = ComboBox1.SelectedValue
            artidatact.STKACTU = stk_act
            gestordeArtidat.Actualizar(artidatact)

            If stk_act < 0 Then
                stk_act = 0
            End If
            gestordetmpstockped.UPDATE_TMP_STOCKPEDIDO(codempresa, CORREL, s.CODARTI, Convert.ToDecimal(stk_act))
        Next

    End Sub





    Private Sub btnBusqVehicu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqVehicu.Click
        Dim o As New FrmBusqueda_Vehiculo
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        CodVehiculo = o.DatagridVehiculo.Item(o.FilaSelec, 0).ToString.Trim
        CargarDatosVehiculo()
    End Sub

    Private Sub BtnBusqCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim o As New FrmBusquClientPedido
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        TABLE_PEDIDO = CAyuda.ListarDatos("NSP_TRAER_PEDIDO", codempresa).Tables(0)
        TABLE_PEDIDO.Columns.Add("Cargar")

        For i As Integer = 0 To TABLE_PEDIDO.Rows.Count - 1
            TABLE_PEDIDO.Rows(i)("Cargar") = 0
        Next

        'GridPedido.DataSource = TABLE_PEDIDO
        'DataGridTableStyle1.MappingName = TABLE_PEDIDO.TableName
        'DataGridTableStyle1.GridColumnStyles(0).MappingName = "NUM_PEDIDO"
        'DataGridTableStyle1.GridColumnStyles(1).MappingName = "DATOADJUNTO"
        'DataGridTableStyle1.GridColumnStyles(2).MappingName = "FECHA"
        'DataGridTableStyle1.GridColumnStyles(3).MappingName = "DSVEND"
        'DataGridTableStyle1.GridColumnStyles(4).MappingName = "DESCRIPCION"
        'DataGridTableStyle1.GridColumnStyles(5).MappingName = "Cargar"
        'Me.GridPedido.TableStyles.Add(DataGridTableStyle1)

    End Sub

    Private Sub btnBusqRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqRuta.Click
        Dim o As New FrmBusquedaRuta
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If

        '' '' ''Dim va As Boolean
        '' '' ''If o.FullItem = True Then
        '' '' ''    For Each dr As DataRow In o.TMP_RUTA.Rows
        '' '' ''        Me.fila = Me.Dt_calles.NewRow
        '' '' ''        fila(0) = dr.Item(0).ToString()
        '' '' ''        fila(1) = dr.Item(1).ToString
        '' '' ''        va = False
        '' '' ''        For Each dr1 As DataRow In Dt_calles.Rows
        '' '' ''            If dr1.Item(0).ToString = fila.Item(0).ToString Then
        '' '' ''                va = True
        '' '' ''            End If
        '' '' ''        Next
        '' '' ''        If va = False Then
        '' '' ''            Dt_calles.Rows.Add(fila)
        '' '' ''        End If
        '' '' ''    Next
        '' '' ''Else

        '' '' ''    Me.fila = Me.Dt_calles.NewRow
        '' '' ''    fila(0) = o.DgRuta.Item(o.FilaSeleccion, 0).ToString
        '' '' ''    fila(1) = o.DgRuta.Item(o.FilaSeleccion, 1).ToString
        '' '' ''    For x As Integer = 0 To Dt_calles.Rows.Count - 1
        '' '' ''        If Dt_calles.Rows.Item(x)(0) = fila(0) Then
        '' '' ''            MsgBox("- Ya existe la Ruta.", MsgBoxStyle.Information, "NARSISTEMAS")
        '' '' ''            Exit Sub
        '' '' ''        End If
        '' '' ''    Next
        '' '' ''    Dt_calles.Rows.Add(fila)
        '' '' ''End If

        cmbcalle.DataSource = Nothing
        cmbcalle.DisplayMember = "Descripcion"
        cmbcalle.ValueMember = "Codigo"

        cmbcalle.DataSource = o.Tb_RutaModSelec

        'CodRuta = o.DgRuta.Item(o.FilaSeleccion, 0).ToString
        'cboRuta.SelectedValue = o.DgRuta.Item(o.FilaSeleccion, 0).ToString
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To TABLE_PEDIDO.Rows.Count - 1


        Next
    End Sub

    Private Sub ORDENAR_Pedido()
        Dim TMP_PEDIDOS As DataTable
        TMP_PEDIDOS = (TmpListarDatos("SELECT DISTINCT(NUM_PEDIDO) FROM TMP_GUIAINTERNADET_T WHERE CORRNBR='" & CORREL & "'  ORDER BY NUM_PEDIDO  ASC "))
        For i As Integer = 0 To TMP_PEDIDOS.Rows.Count - 1
            CAyuda.Ejecutar("SP_ORDERNAR_ITEM_TMP_GUIAINTERNADET_T", codempresa, CORREL, TMP_PEDIDOS.Rows(i)(0))
        Next
    End Sub

    Private Sub BtnCargarPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargarPedidos.Click
        Devolver = False
        If cmbcalle.Items.Count = 0 Then
            MsgBox("- AGREGUE RUTAS .", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        Carga_Pedido()
        ORDENAR_Pedido()

        Dim frmpe As New frmAddOrden
        frmpe.obj = Me
        frmpe.Correl = Me.CORREL
        frmpe.ShowDialog()

        Select Case Selecc
            Case 1
                For Each drt As DataRow In TMP_PEDDELL.Rows
                    If CDbl(drt.Item(0)) = CDbl(frmpe.dglista.Item(frmpe.dglista.CurrentRowIndex, 0)) Then
                        MsgBox("-EL PEDIDO YA EXISTE.", MsgBoxStyle.Information, "NARSISTEMAS")
                        Exit Sub
                    End If
                Next
                CAyuda.Ejecutar("SP_INS_TMP_GUITAINTERNADET_PASA", codempresa, CORREL, CDbl(frmpe.dglista.Item(frmpe.dglista.CurrentRowIndex, 0)), 1)
            Case 2
                For a As Integer = 0 To frmpe.dt.Rows.Count - 1

                    If frmpe.dglista.IsSelected(a) = True Then
                        CAyuda.Ejecutar("SP_INS_TMP_GUITAINTERNADET_PASA", codempresa, CORREL, CDbl(frmpe.dglista.Item(a, 0)), 1)
                    End If
                Next
            Case 3
                CAyuda.Ejecutar("SP_INS_TMP_GUITAINTERNADET_PASA", codempresa, CORREL, 0, 0) ' pasar todo
        End Select

        Dim StrSql As String
        Dim rs As New DataTable
        StrSql = " select  COUNT(DISTINCT CODCLIENTE) from TMP_GUIAINTERNADET where CORRNBR=   '" & CORREL & "'"
        rs = TmpListarDatos(StrSql)
        If rs.Rows.Count > 0 Then
            MsgBox("ESTA ORDEN DE DESPACHO SE ATENDERA A " & rs.Rows(0)(0).ToString & " CLIENTES")
        End If

        If Devolver = True Then
            CARGARPEDIDOS(True)
        End If

    End Sub

    Private Sub Carga_Pedido()
        CAyuda.Ejecutar("SP_DELT_BUSC_PEDI", codempresa, CORREL)
        For A As Integer = 0 To cmbcalle.Items.Count - 1
            If cmbcalle.Items(A).row(0).ToString = "101" Then
                Dim x As String
                x = ""
            End If
            TmpInsertDatos("SP_INS_TMP_GUIAINTERNADET_T   '" & codempresa & "','" & CORREL & "','" & cmbcalle.Items(A).row(0) & "','" & Format(CDate(DtFecIni.Value), "dd/MM/yyyy") & "','" & Format(CDate(DtFecFin.Value), "dd/MM/yyyy") & "', '" & CDZONA & "','" & Format(CDate(DtFechaDespacho.Value), "dd/MM/yyyy") & "'")
        Next
    End Sub

    Private Sub BtnVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TMP_GRIDDET.Rows.Count > 0 Then
            Try
                Dim NUM_PEDIDO As String = ""
                'NUM_PEDIDO = GridPedido.Item(GridPedido.CurrentRowIndex, 0)
                If NUM_PEDIDO.Trim = "" Then
                    MsgBox("Debe escojer un Pedido  a  buscar ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                    Exit Sub
                End If
                Dim o As New FrmBusqueda_Detalle_Pedido
                o.CORREL = CORREL
                'o.CODARTI = GridPedido.Item(GridPedido.CurrentRowIndex, 2)
                o.ShowDialog()
                TmpInsertDatos("SP_INS_TMP_CARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")
                TmpInsertDatos("SP_CALCULAR_STOCKFALTANTE  '" & codempresa & "','" & CORREL & "'")

                TMP_GRIDDET = (TmpListarDatos("SELECT  * FROM  TMP_CARGAPEDIDODET WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & CORREL & "'  ORDER BY ITEM  ASC "))
                'GridPedido.DataSource = TMP_GRIDDET

                Dim TMP_MONTO As New DataTable
                TMP_MONTO = TmpListarDatos("SP_ONTENER_MONTO_TMPCARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")
                If TMP_MONTO.Rows.Count > 0 Then
                    LblTotalPeso.Text = TMP_MONTO.Rows(0)("PESO")
                    LblTotalSoles.Text = TMP_MONTO.Rows(0)("TOTBAS")

                End If
                LblTotalPeso.Text = FormatoMonto(CDbl(LblTotalPeso.Text), DECIRESU)
                LblTotalSoles.Text = FormatoMonto(CDbl(LblTotalSoles.Text), DECIRESU)

                FORMATO_GRIDDET()
            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub Verifica_Stock()



        'CAyuda.Ejecutar("SP_CALC_STOK", CORREL, codempresa, CDZONA, ComboBox1.SelectedValue, rand)

        CALC_STOK()


        Dim TABLE_STOCKPED_FALTANTE As New DataTable
        TABLE_STOCKPED_FALTANTE = TmpListarDatos("NSP_LISTARTMP_STOCKPED_FALTANTE_2  '" & codempresa & "','" & CORREL & "'")

        If TABLE_STOCKPED_FALTANTE.Rows.Count > 0 Then


            Dim O As New Frmbusqueda_Stock_Faltante_pedido
            O.FrmPedCarg = Me
            O.TABLE_MOSTRAR_PEDIDO_FALTANTE = TABLE_STOCKPED_FALTANTE
            O.ShowDialog()
            Table_Ped_SinStock = O.Table_Ped_SinStock

        Else
            MsgBox("Hay stock suficiente para este pedido.. ", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If



    End Sub

    Private Sub btnVerifiarStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'Exit Sub
        VerifStock = True
        '------DECLARACION DE VARIABLES --------------
        '--------AGREGAR COLUMNAS------------------
        '-----------------AGREGAR ESTILO A GRID ----------
        'DataGridTableStyle1.SelectionBackColor = Color.Red
        'Me.GridPedido.TableStyles.Add(DataGridTableStyle1)
        TABLE_CANT_FALTANTE.Clear()

        '---------------COMENZAR EL PROCESO DE VERIFICACION ---------
        OBTENERCORRELATIVO_INVENTARIO()
        '-----------INSERTAR  TODOS LOS  PEDIDOS   AL TEMPORAL CON STOCK UNIDADES
        For i As Integer = 0 To TABLE_PEDIDO.Rows.Count - 1
            If TABLE_PEDIDO.Rows(i)("Cargar").ToString = 1 Then ''''''VERIFICAR IF ESTA ACTIVADO EL REGISTRO
                TmpInsertDatos("NSP_INS_TMP_STOCKPEDIDO     '" & CORREL & "','" & codempresa & "','" & TABLE_PEDIDO.Rows(i)("NUM_PEDIDO").ToString & "'  ")
            End If
        Next
        Dim TABLE_TMPSTCKPED As New DataTable
        Dim TABLE_TMPSTCKPED2 As New DataTable
        Dim TABLE_ARTIDAT As New DataTable
        Dim TABLE_PEDCARGS As New DataTable
        TABLE_TMPSTCKPED = TmpListarDatos("NSP_LISTAR_TMP_STOCKPEDIDO2  '" & codempresa & "','" & CORREL & "'")
        TABLE_TMPSTCKPED2 = TmpListarDatos("NSP_LISTAR_TMP_STOCKPEDIDO  '" & codempresa & "','" & CORREL & "'")
        Dim STOCKDISP As Double
        Dim CODART_CARG As String
        Dim STOCKPEGCARG, STOCKARTIDAT As Double
        Dim TABLE_STKDISP As New DataTable
        For i As Integer = 0 To TABLE_TMPSTCKPED.Rows.Count - 1
            CODART_CARG = TABLE_TMPSTCKPED.Rows(i)("CODARTI").ToString.Trim
            '----------LISTO LOS PEDIDOS QUE ESTAN CARGADOS A CAMION PERO NO FACTURADOS 
            TABLE_PEDCARGS = TmpListarDatos("NSP_LIST_STOCK_PEDCARGDS   '" & codempresa & "','" & CODART_CARG & "' ")
            If TABLE_PEDCARGS.Rows.Count = 0 Then
                STOCKPEGCARG = 0
            Else
                STOCKPEGCARG = CDbl(TABLE_PEDCARGS.Rows(0)("STOCK_PED_UND").ToString.Trim)
            End If
            '----------LISTO LOS STOCKS DEL ARTIDAT
            TABLE_ARTIDAT = TmpListarDatos("NSP_STOCK_ARTI_TIP_ALMAC  '" & codempresa & "','" & CODART_CARG & "','" & 0 & "'")
            'STOCK DISPONIBLE
            If TABLE_ARTIDAT.Rows.Count = 0 Then
                STOCKARTIDAT = 0
            Else
                STOCKARTIDAT = CDbl(TABLE_ARTIDAT.Rows(0)("STKACTU").ToString.Trim)
            End If
            STOCKDISP = STOCKARTIDAT - STOCKPEGCARG
            If STOCKDISP < 0 Then
                STOCKDISP = 0
            End If
            For a As Integer = 0 To TABLE_TMPSTCKPED2.Rows.Count - 1
                If TABLE_TMPSTCKPED2.Rows(a)("CODARTI").ToString.Trim = CODART_CARG Then
                    TABLE_STKDISP = TmpListarDatos("NSP_UPDATE_TMP_STOCKPEDIDO   '" & codempresa & "','" & CORREL & "','" & CODART_CARG & "','" & STOCKDISP & "'")
                    If TABLE_STKDISP.Rows.Count > 0 Then
                        STOCKDISP = CDbl(TABLE_STKDISP.Rows(0)(0).ToString)
                    Else
                        MsgBox("OCURRIO UN ERROR EN LA CONSULTA..")
                    End If
                End If
            Next
        Next
        Dim TABLE_STOCKPED_FALTANTE As New DataTable
        TABLE_STOCKPED_FALTANTE = TmpListarDatos("NSP_LISTARTMP_STOCKPED_FALTANTE  '" & codempresa & "','" & CORREL & "'")
        If TABLE_STOCKPED_FALTANTE.Rows.Count > 0 Then
            Dim O As New Frmbusqueda_Stock_Faltante_pedido
            O.FrmPedCarg = Me
            O.TABLE_MOSTRAR_PEDIDO_FALTANTE = TABLE_STOCKPED_FALTANTE
            O.ShowDialog()
            Table_Ped_SinStock = O.Table_Ped_SinStock
            cargarPed_ConStock()

            'Table_Ped_ConStock = O.Table_Ped_ConStock
        Else
            'DataGridTableStyle1.SelectionBackColor = Color.Green
            'Me.GridPedido.TableStyles.Add(DataGridTableStyle1)
            MsgBox("Hay stock suficiente para este pedido.. ", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If

    End Sub


    Public Sub PROCESO()

        If TMP_PEDDELL.Rows.Count = 0 Then
            MsgBox("- NO HAY PEDIDOS.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If



        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DtFechaDespacho.Value.Year
        MES = DtFechaDespacho.Value.Month

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

        If CDbl(Label6.Text) >= CDbl(LblCubicaje.Text) And CDbl(LblCargaUtil.Text) >= CDbl(LblTotalPeso.Text) Then
        Else
            MsgBox("Los Pesos Exceden la Carga del Vehiculo", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        '''/****************VERIFICAR CREDITO*****************************************************************************/
        'Dim dt2 As DataTable
        'CAyuda.Ejecutar("SP_CANT_PROMO", codempresa, CORREL)
        'dt2 = CAyuda.ListarDatos("SP_PROMO_TOTAL", CORREL, Format(DtFecIni.Value, "dd/MM/yyyy")).Tables(0)
        'If (dt2.Rows.Count > 0) Then
        '    MsgBox("TIENE PROMOCIONES Q EXCEDEN EL STOCK")
        '    Exit Sub
        'End If





        ''/****************VERIFICAR CREDITO*****************************************************************************/
        If desbloquerDeuda = False Then
            Dim TABLE_CREDITO As DataTable
            TABLE_CREDITO = CAyuda.ListarDatos("SP_CALCUL_CREDITO_PED", codempresa, CORREL, VCdPagCredito, LIMCREDITO, COEFICIENT).Tables(0)
            Dim SALDOCRED As Double
            Dim TOTAL As Double
            Dim CODCLIENTE As String
            Dim NUM_PEDIDO As String
            If TABLE_CREDITO.Rows.Count > 0 Then
                For X As Integer = 0 To TABLE_CREDITO.Rows.Count - 1
                    SALDOCRED = CDbl(TABLE_CREDITO.Rows(X)(4).ToString)
                    TOTAL = CDbl(TABLE_CREDITO.Rows(X)(1).ToString)
                    CODCLIENTE = CStr(TABLE_CREDITO.Rows(X)(2).ToString)
                    NUM_PEDIDO = CStr(TABLE_CREDITO.Rows(X)(0).ToString)

                    Dim TABLE_SUM As DataTable
                    TABLE_SUM = CAyuda.ListarDatos("SP_SUMA_PEDIDOS_PASAR", codempresa, CORREL, CODCLIENTE, NUM_PEDIDO).Tables(0)
                    Dim SUMAPEDIDOS As Double
                    If TABLE_SUM.Rows.Count > 0 Then
                        SUMAPEDIDOS = CDbl(TABLE_SUM.Rows(0)(0).ToString)
                    Else
                        SUMAPEDIDOS = 0
                    End If

                    If SALDOCRED < SUMAPEDIDOS Then
                        MsgBox("EL SALDO DE CREDITO DISPONIBLE ES MENOR AL IMPORTE DE PEDIDO ")
                        Exit Sub
                    End If
                Next
            End If
        End If

        ''/**********************************************************************************************************/



        ''/****************VERIFICAR STOCK*****************************************************************************/

        CAyuda.Ejecutar("SP_CLEAR_STK_PEDIDO", CORREL, codempresa)
        For a As Integer = 0 To TMP_PEDDELL.Rows.Count - 1
            CAyuda.Ejecutar("NSP_INS_TMP_STOCKPEDIDO", CORREL, codempresa, TMP_PEDDELL.Rows(a)(0))
        Next

        ValorRan()

        Dim Tb_Categ1 As DataTable
        'Tb_Categ1 = TmpListarDatos("SELECT  CODLINEA,DESLINEA  FROM LINEA  WHERE   CODEMPRESA='" & codempresa & "'")

        Tb_Categ1 = TmpListarDatos("select DISTINCT ART.CODLINEA from  TMP_STOCKPEDIDO TMPSTKPED
                                   INNER JOIN ARTICULO ART ON ART.CODARTI=TMPSTKPED.CODARTI
                                   WHERE TMPSTKPED.CODEMPRESA='" & codempresa & "' AND TMPSTKPED.CORREL='" & CORREL & "'")


        CadenaCateg = ""
        For a As Integer = 0 To Tb_Categ1.Rows.Count - 1
            If CadenaCateg = "" Then
                CadenaCateg = Trim(Tb_Categ1.Rows(a)("CODLINEA"))
            Else
                CadenaCateg = CadenaCateg & "," & Trim(Tb_Categ1.Rows(a)("CODLINEA"))
            End If
        Next

        Dim Sql As String
        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        Dim almacen As String
        almacen = ComboBox1.SelectedValue.ToString

        CierreIgual = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

        dt = SelectFechCiere(Fech, False, almacen)
        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

        Procesar_Saldo(FECHCIERRE, almacen)


        'CAyuda.Ejecutar("SP_CALC_STOK", CORREL, codempresa, CDZONA, ComboBox1.SelectedValue, rand)

        CALC_STOK()

        TmpInsertDatos("DELETE FROM  TMp_kardex  WHERE CORREL=" & rand)
        TmpInsertDatos("DELETE FROM  TMP_SUMKARDEX2  WHERE CORREL=" & rand)
        TmpInsertDatos("DELETE FROM  KARDEX_TMP  WHERE CORREL=" & rand)



        Dim TABLE_STOCKPED_FALTANTE As New DataTable
        TABLE_STOCKPED_FALTANTE = TmpListarDatos("NSP_LISTARTMP_STOCKPED_FALTANTE_2  '" & codempresa & "','" & CORREL & "'")

        If TABLE_STOCKPED_FALTANTE.Rows.Count > 0 Then
            Dim O As New Frmbusqueda_Stock_Faltante_pedido
            O.FrmPedCarg = Me
            O.TABLE_MOSTRAR_PEDIDO_FALTANTE = TABLE_STOCKPED_FALTANTE
            O.ShowDialog()
            Table_Ped_SinStock = O.Table_Ped_SinStock

            Dim tablaV As New DataTable
            tablaV = TmpListarDatos("NSP_SELECT_ESTADOV  '" & codempresa & "'")
            If tablaV.Rows.Count > 0 Then
                If tablaV.Rows(0)(0) = "SI" Then
                    If MsgBox("NO HAY STOCK SUFICIENTE EN EL ALMACEN ..DESEA REALIZAR EL DESPACHE AHORA..?", MsgBoxStyle.YesNo, "NARSISTEMAS S.A.C.") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                Else
                    If MsgBox("NO HAY STOCK SUFICIENTE EN EL ALMACEN") Then
                        Exit Sub
                    End If
                End If
            End If

        Else
            MsgBox("Hay stock suficiente para este pedido.. ", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If

        ''/**********************************************************************************************************/

        Dim TABLE_PROVEE As DataTable
        TABLE_PROVEE = CAyuda.ListarDatos("sp_ListaProveeDespa", codempresa, CORREL).Tables(0)
        Dim CODPROVEE As String

        If TABLE_PROVEE.Rows.Count > 0 Then
            For X As Integer = 0 To TABLE_PROVEE.Rows.Count - 1
                CODPROVEE = CStr(TABLE_PROVEE.Rows(X)(0).ToString)
                Dim TABLE_PROVEESUMSAL As DataTable
                TABLE_PROVEESUMSAL = CAyuda.ListarDatos("SP_SUMA_SALDO_PROVEE", codempresa, CODPROVEE).Tables(0)

                If TABLE_PROVEESUMSAL.Rows.Count > 0 Then

                    Dim TABLE_PROVEELINEA As DataTable
                    TABLE_PROVEELINEA = CAyuda.ListarDatos("SP_PROVEE_LINEA", codempresa, CODPROVEE).Tables(0)

                    If TABLE_PROVEELINEA.Rows.Count > 0 Then
                        Dim TABLE_SUMPEDPROVEE As DataTable
                        TABLE_SUMPEDPROVEE = CAyuda.ListarDatos("SP_SUM_PEDIDOSXPROVEE", codempresa, CORREL, CODPROVEE).Tables(0)

                        If TABLE_SUMPEDPROVEE.Rows.Count > 0 Then
                            If CDbl(TABLE_PROVEELINEA.Rows(0)(0).ToString) <= (CDbl(TABLE_PROVEESUMSAL.Rows(0)(1).ToString) + CDbl(TABLE_SUMPEDPROVEE.Rows(0)(0).ToString)) Then
                                MsgBox("VENDEDOR EXECEDE LINEA DE CREDITO")
                                Exit Sub
                            End If

                        End If
                    End If
                End If

            Next

        End If

        Dim TableDetalle As New DataTable
        Dim TABLE_DETGUIA As New DataTable
        Dim ORDENDESPACHO As String
        ''Dim FECDOCUM As String
        ''Dim FECDESPACHO As String
        ''Dim HORADESPACHO As String
        'Dim ModifCabecera As Boolean = True
        ''Dim Modificado As Boolean

        ORDENDESPACHO = GENERAR_ORDEN_DESPACHO()


        If FACTPTOVTA = True Or FACTLINEA = True Then

            TmpInsertDatos("CUR_PARTIR_PEDIDO   '" & CORREL & "'")
            TmpInsertDatos("CUR_INS_PEDIDO  '" & CORREL & "'")
            TmpInsertDatos("SP_INS_GUIAINTERNADETX  '" & CORREL & "','" & ORDENDESPACHO & "'")

        End If


        If FACTSUBEMP = True Then

            TmpInsertDatos("CUR_SEPARADO_PEDIDO   '" & CORREL & "'")
            TmpInsertDatos("CUR_JUNTOS_PEDIDO   '" & CORREL & "'")
            TmpInsertDatos("CUR_INS_PEDIDO_X  '" & CORREL & "'")
            TmpInsertDatos("CUR_ELI_PEDIDO_ANT   '" & CORREL & "'")
            TmpInsertDatos("SP_INS_GUIAINTERNADETX  '" & CORREL & "','" & ORDENDESPACHO & "'")

        End If



        If GrDatoCab.Enabled = True Then
            If TmpListarDatos("SELECT  NRODESPACHO FROM  GUIAINTERNACAB  WHERE  CODEMPRESA='" & codempresa & "' AND  NRODESPACHO='" & ORDENDESPACHO & "'").Rows.Count > 0 Then
                MsgBox("YA EXISTE EL NRO DE ORDEN DE DESPACHO..VERIFIQUE PTOVTA", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            TmpInsertDatos("NSP_INSERT_ORDEN_DESPACHO   '" & codempresa & "','" & Format(CDate(DtFechaDespacho.Value), "dd/MM/yyyy") & "','" & Format(CDate(DtHoraSalida.Value), "hh:mm:ss  tt") & "','" & CboCodVehiculo.SelectedValue & "','" & TxtResponsable.Text & "','" & TxtAyudante.Text & "','" & TxtDestino.Text & "' ,'" & CodUsuario & "','" & CORREL & "','" & NROPTOVTA & "','" & ComboBox1.SelectedValue & "'")
            MsgBox("Se Guardo el NroOrden de Despacho :" & ORDENDESPACHO)
        Else
            TmpInsertDatos("NSP_UPDATE_ORDEN_DESPACHO   '" & codempresa & "','" & CORREL & "','" & LblOrdenDesp.Text & "','" & ComboBox1.SelectedValue & "'")
            MsgBox("Se Modifico el NroOrden de Despacho :" & LblOrdenDesp.Text)
            GrDatoCab.Enabled = False
        End If

        ''''''---------------------------------------------------------
        TMP_PEDDELL.Rows.Clear()
        dgpedidos.DataSource = Nothing
        TABLE_CABECERA_PEDI.Rows.Clear()
        TABLE_CANT_FALTANTE.Rows.Clear()
        TABLE_DETALLE_PEDI.Rows.Clear()
        TABLE_DETGUIA.Rows.Clear()
        TABLE_PEDIDO.Rows.Clear()
        TMP_GRIDDET.Rows.Clear()
        TABLE_PEDIDOS_CARGADOS.Rows.Clear()
        TABLE_PEDIDOS_PROCESADOS.Rows.Clear()
        TableDetalle.Rows.Clear()

        HABILITAR_NUEVO(False)
        LIMPIAR()
        CboCodVehiculo.SelectedIndex = -1
    End Sub

    Public Sub BtnGenerarGuia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerarGuia.Click

        FrmMensague.ALMACEN = ComboBox1.Text
        FrmMensague.FRM = Me
        FrmMensague.Show()

    End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click

        TmpInsertDatos("SP_LIMPIA_TEMPORALES_CARGPED  '" & codempresa & "','" & CORREL & "'")

        Me.Close()
    End Sub
    Private Sub ChkMarcaTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMarcaTodo.CheckedChanged
        For i As Integer = 0 To TABLE_PEDIDO.Rows.Count - 1
            If ChkMarcaTodo.CheckState = CheckState.Checked Then
                TABLE_PEDIDO.Rows(i)("Cargar") = 1
            Else
                TABLE_PEDIDO.Rows(i)("Cargar") = 0
            End If
        Next
        ActualizarGrid()
    End Sub
    Private Sub GridPedido_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)
    End Sub
    Private Sub GridPedido_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BtnVerDetalle_Click(sender, e)
    End Sub

    Private Sub btnBusOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusOrden.Click
        ActNuevo = False
        Dim o As New FrmBusquedaDeOrdenDespacho
        o.TIPO = "C"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        LblOrdenDesp.Text = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        CargarDatos_Busqueda()


    End Sub


    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        GrDatoCab.Enabled = True
    End Sub


    Sub CargarReporte()
        If TmpInsertDatos("NSP_INS_TMP_REPORTCONSOLPROD  '" & codempresa & "','" & LblOrdenDesp.Text.Trim & "'") = False Then
            MsgBox("ERROR EN LA CONSULTA..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        End If

    End Sub



    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        If Me.TMP_PEDDELL.Rows.Count = 0 Then
            MsgBox("- SELECCIONE UNA ORDEN DE DESPACHO.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        Dim ORDENDESPACHO As String
        ORDENDESPACHO = LblOrdenDesp.Text
        'CargarReporte()

        Try
            Rpt2.WindowShowExportBtn = True
            Rpt2.WindowShowPrintBtn = True
            Rpt2.WindowShowPrintSetupBtn = True
            Rpt2.set_StoredProcParam(0, codempresa)
            Rpt2.set_StoredProcParam(1, ORDENDESPACHO)
            Rpt2.set_StoredProcParam(2, "1")
            Rpt2.ReportFileName = rutareporte + CType("Rpt_Consolidado_Producto.rpt", String)
            Rpt2.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            Rpt2.Destination = Crystal.DestinationConstants.crptToWindow
            Rpt2.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt2.Action = 1
            Rpt2.Reset()

        Catch ex As Exception
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

        Dim Table_01 As DataTable
        Table_01 = CAyuda.ListarDatos("SP_LISTA_DESPACHO_FALTA", codempresa, CORREL).Tables(0)
        If Table_01.Rows.Count > 0 Then
            MsgBox("FALTA GENERAR DOCUMENTOS")
            Me.Close()
        End If

        HABILITAR_NUEVO(True)
        LblOrdenDesp.Text = GENERAR_ORDEN_DESPACHO()
        ActNuevo = True
        LIMPIAR()

        DtFechaDespacho.Value = Format(vFechaActual, "dd/MM/yyyy")
        DtFecIni.Value = Format(vFechaActual, "dd/MM/yyyy")
        DtFecFin.Value = Format(vFechaActual, "dd/MM/yyyy")


        Me.CboCodVehiculo.Focus()
    End Sub



    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        HABILITAR_NUEVO(False)
        LIMPIAR()
        CboCodVehiculo.SelectedIndex = -1
    End Sub

    Private Sub CboCodVehiculo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCodVehiculo.SelectedIndexChanged
        If CboCodVehiculo.SelectedIndex > -1 Then
            CodVehiculo = CboCodVehiculo.SelectedValue.ToString.Trim
            CargarDatosVehiculo()
        End If
    End Sub

    Private Sub CboCodVehiculo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboCodVehiculo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cboRuta.Focus()
        End If
    End Sub

    Private Sub cboRuta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRuta.SelectedIndexChanged

    End Sub

    Private Sub cboRuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboRuta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtFecIni.Focus()
        End If
    End Sub

    Private Sub DtFecFin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtFecFin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.BtnCargarPedidos.Focus()
        End If
    End Sub

    Private Sub DtFecIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtFecIni.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtFecFin.Focus()
        End If
    End Sub

    Private Sub DtFecFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtFecFin.ValueChanged

    End Sub


    Private Sub BtnCargarPedidos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BtnCargarPedidos.KeyPress
        If Asc(e.KeyChar) = 32 Then
            '        MsgBox(Asc(e.KeyChar).ToString)
            'CARGARPEDIDOS()
        End If
    End Sub

    Private Sub GridPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgpedidos_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgpedidos.Navigate

    End Sub

    Private Sub dgpedidos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgpedidos.DoubleClick

        If TMP_PEDDELL.Rows.Count > 0 Then
            Try
                Dim NUM_PEDIDO As String
                NUM_PEDIDO = dgpedidos.Item(dgpedidos.CurrentRowIndex, 0)
                If NUM_PEDIDO.Trim = "" Then
                    MsgBox("Debe escojer un Pedido  a  buscar ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                    Exit Sub
                End If

                Dim frmdet As New frmDetallePedido
                frmdet.corre = CORREL
                frmdet.pedido = CDec(NUM_PEDIDO)
                frmdet.ShowDialog()

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub BtnVerDetalle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerDetalle.Click

        If TMP_PEDDELL.Rows.Count = 0 Then
            MsgBox("- NO HAY PEDIDOS.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        dgpedidos_DoubleClick(sender, e)
    End Sub

    Private Sub btnvericredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvericredito.Click


        If TMP_PEDDELL.Rows.Count = 0 Then
            MsgBox("- NO HAY PEDIDOS.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        Dim frmcred As New frmValCredito
        frmcred.frm = Me
        frmcred.CORREL = Me.CORREL
        frmcred.ShowDialog()
        'LIMCREDITO

    End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub btnVerifiarStock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifiarStock.Click


        ''/****************VERIFICAR STOCK*****************************************************************************/

        If TMP_PEDDELL.Rows.Count = 0 Then
            MsgBox("- NO HAY PEDIDOS.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        CAyuda.Ejecutar("SP_CLEAR_STK_PEDIDO", CORREL, codempresa)

        For a As Integer = 0 To TMP_PEDDELL.Rows.Count - 1
            CAyuda.Ejecutar("NSP_INS_TMP_STOCKPEDIDO", CORREL, codempresa, TMP_PEDDELL.Rows(a)(0))
        Next

        ValorRan()

        Dim Tb_Categ1 As DataTable
        'Tb_Categ1 = TmpListarDatos("SELECT  CODLINEA,DESLINEA  FROM LINEA  WHERE   CODEMPRESA='" & codempresa & "'")


        Tb_Categ1 = TmpListarDatos("select DISTINCT ART.CODLINEA from  TMP_STOCKPEDIDO TMPSTKPED
                                   INNER JOIN ARTICULO ART ON ART.CODARTI=TMPSTKPED.CODARTI
                                   WHERE TMPSTKPED.CODEMPRESA='" & codempresa & "' AND TMPSTKPED.CORREL='" & CORREL & "'")




        CadenaCateg = ""
        For a As Integer = 0 To Tb_Categ1.Rows.Count - 1
            If CadenaCateg = "" Then
                CadenaCateg = Trim(Tb_Categ1.Rows(a)("CODLINEA"))
            Else
                CadenaCateg = CadenaCateg & "," & Trim(Tb_Categ1.Rows(a)("CODLINEA"))
            End If
        Next

        Dim Sql As String
        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        Dim almacen As String
        almacen = ComboBox1.SelectedValue.ToString

        CierreIgual = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

        dt = SelectFechCiere(Fech, False, almacen)
        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

        Procesar_Saldo(FECHCIERRE, almacen)
        Verifica_Stock()

        TmpInsertDatos("DELETE FROM  TMp_kardex  WHERE CORREL=" & rand)
        TmpInsertDatos("DELETE FROM  TMP_SUMKARDEX2  WHERE CORREL=" & rand)
        TmpInsertDatos("DELETE FROM  KARDEX_TMP  WHERE CORREL=" & rand)

        ''/**********************************************************************************************************/



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



    Sub Procesar_Saldo(ByVal fechaCierre As String, ByVal CDALMACEN As String)
        Dim meses As Integer
        Dim Fecinicial, Fecfinal As String
        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String

        TmpInsertDatos("Delete from TMp_kardex where correl=" & rand)

        If CierreIgual = True Then
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")
            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL_CP'" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "','" & CORREL & "'")

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
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL_CP'" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "','" & CORREL & "'")

                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next

        Else

            'esto estaba desabilitado'
            meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
            ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0,'" & rand & "'")

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
                Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct



                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1,'" & rand & "'")

                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTAS '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next


            ''SELECCIONO LOS INGRESOS Y SALIDAS DEL RANGO DEL KARDEX
            MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
            MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy")

            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")


            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL_CP'" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "','" & CORREL & "'")


            '' SELECCIONO LAS VENTAS
            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''Registros del Histórico
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentD = "VENTD" & Anio & MesAct
                VentaC = "VENTC" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL_CP'" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "','" & CORREL & "'")
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

        TmpInsertDatos("SP_INS_KARDEX_TMPCP '" & codempresa & "','" & rand & "','" & CORREL & "'")


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


        TmpInsertDatos(" INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS ) " &
                         " SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,CIERRE_MES_INVENTARIO.ARTICULO,CIERRE_MES_INVENTARIO.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0  " &
                         "FROM CIERRE_MES_INVENTARIO INNER JOIN ARTICULO ON CIERRE_MES_INVENTARIO.ARTICULO=ARTICULO.CODARTI INNER JOIN TMP_STOCKPEDIDO ON TMP_STOCKPEDIDO.CODARTI=ARTICULO.CODARTI " &
                         "WHERE  ARTICULO.FORMU = 0 AND CIERRE_MES_INVENTARIO.ALMACEN ='" & Trim(ALMACEN) & "'  AND FECHA='" & Format(FechaCierre, "dd/MM/yyyy") & "' AND TMP_STOCKPEDIDO.correl='" & CORREL & "'")


    End Sub






    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("INGRESE CODIGO DE ARTICULO")
            Exit Sub
        End If


        Dim frmdet As New frmDetallePedido2
        frmdet.corre = CORREL
        frmdet.pedido = TextBox1.Text
        frmdet.ShowDialog()

        'Dim TMP_MONTO As New DataTable
        'TMP_MONTO = TmpListarDatos("SP_ONTENER_MONTO_TMPCARGAPEDIDODET  '" & codempresa & "','" & CORREL & "'")
        'If TMP_MONTO.Rows.Count > 0 Then
        '    LblTotalPeso.Text = TMP_MONTO.Rows(0)("PESO")
        '    LblTotalSoles.Text = TMP_MONTO.Rows(0)("TOTBAS")

        'End If
        'LblTotalPeso.Text = FormatoMonto(CDbl(LblTotalPeso.Text), DECIRESU)
        'LblTotalSoles.Text = FormatoMonto(CDbl(LblTotalSoles.Text), DECIRESU)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmdet As New Frmbusqueda_Provee_linea
        frmdet.CORREL = CORREL
        frmdet.ShowDialog()




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Try
            Dim dt As New DataTable
            '' dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Rpt_Consolidado_Producto2.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, CORREL)


            'crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            'crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            'crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            'crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")

            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim frmcred As New frmDistribucion
        frmcred.correlx = Me.CORREL
        frmcred.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click




        Dim frmcred As New FrmValPromo
        frmcred.CORREL = Me.CORREL
        frmcred.fecha = Format(DtFecIni.Value, "dd/MM/yyyy")
        frmcred.ShowDialog()


    End Sub
End Class

