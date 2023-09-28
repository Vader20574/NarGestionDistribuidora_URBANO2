Public Class FrmActulizar_Orden_Despacho
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
    Friend WithEvents GridDespacho As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOrderDesp As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BtnConsult As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgCabeceraOrden As System.Windows.Forms.DataGrid
    Friend WithEvents TablaEstiloCabecera As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ORDEN_DESPACHO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnActualizarSeleccionada As System.Windows.Forms.Button
    Friend WithEvents btnActualizaragregadas As System.Windows.Forms.Button
    Friend WithEvents LblTotalNroDoc As System.Windows.Forms.Label
    Friend WithEvents GrpOD As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PnlOD As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtDestino As System.Windows.Forms.TextBox
    Friend WithEvents TxtVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents TxtHoraDesp As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecDesp As System.Windows.Forms.TextBox
    Friend WithEvents TxtAyu As System.Windows.Forms.TextBox
    Friend WithEvents TxtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents LblTotalDoc As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActulizar_Orden_Despacho))
        Me.GridDespacho = New System.Windows.Forms.DataGrid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnConsult = New System.Windows.Forms.Button
        Me.PnlOD = New System.Windows.Forms.Panel
        Me.txtRuta = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtAyu = New System.Windows.Forms.TextBox
        Me.TxtResponsable = New System.Windows.Forms.TextBox
        Me.TxtHoraDesp = New System.Windows.Forms.TextBox
        Me.TxtFecDesp = New System.Windows.Forms.TextBox
        Me.TxtVehiculo = New System.Windows.Forms.TextBox
        Me.TxtDestino = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtOrderDesp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnActualizaragregadas = New System.Windows.Forms.Button
        Me.BtnActualizarSeleccionada = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.dgCabeceraOrden = New System.Windows.Forms.DataGrid
        Me.TablaEstiloCabecera = New System.Windows.Forms.DataGridTableStyle
        Me.ORDEN_DESPACHO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.FECHA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.LblTotalNroDoc = New System.Windows.Forms.Label
        Me.GrpOD = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblTotalDoc = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.GridDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOD.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgCabeceraOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpOD.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridDespacho
        '
        Me.GridDespacho.CaptionText = "                                       ==============[Doble Click]  ó  [ENTER] --" & _
            ">Para   Anular =============="
        Me.GridDespacho.DataMember = ""
        Me.GridDespacho.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridDespacho.Location = New System.Drawing.Point(10, 150)
        Me.GridDespacho.Name = "GridDespacho"
        Me.GridDespacho.ReadOnly = True
        Me.GridDespacho.Size = New System.Drawing.Size(828, 224)
        Me.GridDespacho.TabIndex = 0
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
        'BtnConsult
        '
        Me.BtnConsult.ImageList = Me.ImageList1
        Me.BtnConsult.Location = New System.Drawing.Point(12, 339)
        Me.BtnConsult.Name = "BtnConsult"
        Me.BtnConsult.Size = New System.Drawing.Size(98, 42)
        Me.BtnConsult.TabIndex = 51
        Me.BtnConsult.Text = "&Consultar"
        '
        'PnlOD
        '
        Me.PnlOD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlOD.Controls.Add(Me.txtRuta)
        Me.PnlOD.Controls.Add(Me.Label6)
        Me.PnlOD.Controls.Add(Me.TxtAyu)
        Me.PnlOD.Controls.Add(Me.TxtResponsable)
        Me.PnlOD.Controls.Add(Me.TxtHoraDesp)
        Me.PnlOD.Controls.Add(Me.TxtFecDesp)
        Me.PnlOD.Controls.Add(Me.TxtVehiculo)
        Me.PnlOD.Controls.Add(Me.TxtDestino)
        Me.PnlOD.Controls.Add(Me.Label13)
        Me.PnlOD.Controls.Add(Me.Label12)
        Me.PnlOD.Controls.Add(Me.Label8)
        Me.PnlOD.Controls.Add(Me.Label5)
        Me.PnlOD.Controls.Add(Me.Label10)
        Me.PnlOD.Controls.Add(Me.Label3)
        Me.PnlOD.Controls.Add(Me.btnBuscar)
        Me.PnlOD.Controls.Add(Me.txtOrderDesp)
        Me.PnlOD.Controls.Add(Me.Label1)
        Me.PnlOD.Location = New System.Drawing.Point(139, 9)
        Me.PnlOD.Name = "PnlOD"
        Me.PnlOD.Size = New System.Drawing.Size(723, 134)
        Me.PnlOD.TabIndex = 2
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.Color.White
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(67, 99)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(295, 23)
        Me.txtRuta.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Ruta: "
        '
        'TxtAyu
        '
        Me.TxtAyu.BackColor = System.Drawing.Color.White
        Me.TxtAyu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAyu.Location = New System.Drawing.Point(446, 97)
        Me.TxtAyu.Name = "TxtAyu"
        Me.TxtAyu.ReadOnly = True
        Me.TxtAyu.Size = New System.Drawing.Size(264, 23)
        Me.TxtAyu.TabIndex = 58
        '
        'TxtResponsable
        '
        Me.TxtResponsable.BackColor = System.Drawing.Color.White
        Me.TxtResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResponsable.Location = New System.Drawing.Point(446, 69)
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.ReadOnly = True
        Me.TxtResponsable.Size = New System.Drawing.Size(264, 23)
        Me.TxtResponsable.TabIndex = 57
        '
        'TxtHoraDesp
        '
        Me.TxtHoraDesp.BackColor = System.Drawing.Color.White
        Me.TxtHoraDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraDesp.Location = New System.Drawing.Point(624, 44)
        Me.TxtHoraDesp.Name = "TxtHoraDesp"
        Me.TxtHoraDesp.ReadOnly = True
        Me.TxtHoraDesp.Size = New System.Drawing.Size(86, 23)
        Me.TxtHoraDesp.TabIndex = 56
        '
        'TxtFecDesp
        '
        Me.TxtFecDesp.BackColor = System.Drawing.Color.White
        Me.TxtFecDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecDesp.Location = New System.Drawing.Point(446, 44)
        Me.TxtFecDesp.Name = "TxtFecDesp"
        Me.TxtFecDesp.ReadOnly = True
        Me.TxtFecDesp.Size = New System.Drawing.Size(87, 23)
        Me.TxtFecDesp.TabIndex = 55
        '
        'TxtVehiculo
        '
        Me.TxtVehiculo.BackColor = System.Drawing.Color.White
        Me.TxtVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVehiculo.Location = New System.Drawing.Point(67, 72)
        Me.TxtVehiculo.Name = "TxtVehiculo"
        Me.TxtVehiculo.ReadOnly = True
        Me.TxtVehiculo.Size = New System.Drawing.Size(238, 23)
        Me.TxtVehiculo.TabIndex = 54
        '
        'TxtDestino
        '
        Me.TxtDestino.BackColor = System.Drawing.Color.White
        Me.TxtDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDestino.Location = New System.Drawing.Point(67, 44)
        Me.TxtDestino.Name = "TxtDestino"
        Me.TxtDestino.ReadOnly = True
        Me.TxtDestino.Size = New System.Drawing.Size(238, 23)
        Me.TxtDestino.TabIndex = 53
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(377, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Ayudante : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(355, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 17)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Responsable :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Vehiculo :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Destino :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(547, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Hora Salida: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Fecha Despacho : "
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.ImageIndex = 5
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(283, 7)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 30)
        Me.btnBuscar.TabIndex = 40
        Me.btnBuscar.Text = "[Buscar]"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOrderDesp
        '
        Me.txtOrderDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderDesp.Location = New System.Drawing.Point(161, 9)
        Me.txtOrderDesp.Name = "txtOrderDesp"
        Me.txtOrderDesp.Size = New System.Drawing.Size(120, 26)
        Me.txtOrderDesp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "#OrdenDespacho : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnActualizaragregadas)
        Me.GroupBox2.Controls.Add(Me.BtnActualizarSeleccionada)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BtnConsult)
        Me.GroupBox2.Location = New System.Drawing.Point(869, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 531)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'btnActualizaragregadas
        '
        Me.btnActualizaragregadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizaragregadas.ImageList = Me.ImageList1
        Me.btnActualizaragregadas.Location = New System.Drawing.Point(10, 106)
        Me.btnActualizaragregadas.Name = "btnActualizaragregadas"
        Me.btnActualizaragregadas.Size = New System.Drawing.Size(105, 90)
        Me.btnActualizaragregadas.TabIndex = 502
        Me.btnActualizaragregadas.Text = "&Confirmar Orden Despacho Agregadas"
        '
        'BtnActualizarSeleccionada
        '
        Me.BtnActualizarSeleccionada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarSeleccionada.ImageList = Me.ImageList1
        Me.BtnActualizarSeleccionada.Location = New System.Drawing.Point(10, 9)
        Me.BtnActualizarSeleccionada.Name = "BtnActualizarSeleccionada"
        Me.BtnActualizarSeleccionada.Size = New System.Drawing.Size(105, 88)
        Me.BtnActualizarSeleccionada.TabIndex = 501
        Me.BtnActualizarSeleccionada.Text = "&Confirmar Orden Despacho Seleccionada"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(12, 385)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(98, 40)
        Me.BTNCANCELAR.TabIndex = 28
        Me.BTNCANCELAR.TabStop = False
        Me.BTNCANCELAR.Text = "     &Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(12, 429)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(98, 42)
        Me.BTNCERRAR.TabIndex = 500
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "  &Salir"
        '
        'dgCabeceraOrden
        '
        Me.dgCabeceraOrden.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgCabeceraOrden.BackColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.BackgroundColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.CaptionBackColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.CaptionFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.dgCabeceraOrden.CaptionForeColor = System.Drawing.Color.Navy
        Me.dgCabeceraOrden.CaptionText = "Ordenes de Despacho"
        Me.dgCabeceraOrden.DataMember = ""
        Me.dgCabeceraOrden.ForeColor = System.Drawing.Color.Black
        Me.dgCabeceraOrden.GridLineColor = System.Drawing.Color.Black
        Me.dgCabeceraOrden.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgCabeceraOrden.HeaderBackColor = System.Drawing.Color.Silver
        Me.dgCabeceraOrden.HeaderForeColor = System.Drawing.Color.Black
        Me.dgCabeceraOrden.LinkColor = System.Drawing.Color.Navy
        Me.dgCabeceraOrden.Location = New System.Drawing.Point(10, 23)
        Me.dgCabeceraOrden.Name = "dgCabeceraOrden"
        Me.dgCabeceraOrden.ParentRowsBackColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCabeceraOrden.ReadOnly = True
        Me.dgCabeceraOrden.SelectionBackColor = System.Drawing.Color.Navy
        Me.dgCabeceraOrden.SelectionForeColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.Size = New System.Drawing.Size(304, 127)
        Me.dgCabeceraOrden.TabIndex = 20
        Me.dgCabeceraOrden.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloCabecera})
        '
        'TablaEstiloCabecera
        '
        Me.TablaEstiloCabecera.DataGrid = Me.dgCabeceraOrden
        Me.TablaEstiloCabecera.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ORDEN_DESPACHO, Me.FECHA})
        Me.TablaEstiloCabecera.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloCabecera.ReadOnly = True
        '
        'ORDEN_DESPACHO
        '
        Me.ORDEN_DESPACHO.Format = ""
        Me.ORDEN_DESPACHO.FormatInfo = Nothing
        Me.ORDEN_DESPACHO.HeaderText = "Orden Despacho"
        Me.ORDEN_DESPACHO.Width = 120
        '
        'FECHA
        '
        Me.FECHA.Format = "dd/MM/yyyy"
        Me.FECHA.FormatInfo = Nothing
        Me.FECHA.HeaderText = "Fecha"
        Me.FECHA.Width = 75
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Location = New System.Drawing.Point(319, 55)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(79, 42)
        Me.btnQuitar.TabIndex = 22
        Me.btnQuitar.Text = "Quitar Orden"
        '
        'LblTotalNroDoc
        '
        Me.LblTotalNroDoc.AutoSize = True
        Me.LblTotalNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalNroDoc.Location = New System.Drawing.Point(418, 383)
        Me.LblTotalNroDoc.Name = "LblTotalNroDoc"
        Me.LblTotalNroDoc.Size = New System.Drawing.Size(186, 17)
        Me.LblTotalNroDoc.TabIndex = 23
        Me.LblTotalNroDoc.Text = "Total de Documentos : 0"
        '
        'GrpOD
        '
        Me.GrpOD.Controls.Add(Me.dgCabeceraOrden)
        Me.GrpOD.Controls.Add(Me.btnQuitar)
        Me.GrpOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpOD.Location = New System.Drawing.Point(10, 376)
        Me.GrpOD.Name = "GrpOD"
        Me.GrpOD.Size = New System.Drawing.Size(403, 164)
        Me.GrpOD.TabIndex = 24
        Me.GrpOD.TabStop = False
        Me.GrpOD.Text = "Orden De Despacho"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(612, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Total :"
        '
        'LblTotalDoc
        '
        Me.LblTotalDoc.BackColor = System.Drawing.Color.White
        Me.LblTotalDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDoc.Location = New System.Drawing.Point(677, 376)
        Me.LblTotalDoc.Name = "LblTotalDoc"
        Me.LblTotalDoc.Size = New System.Drawing.Size(149, 39)
        Me.LblTotalDoc.TabIndex = 43
        Me.LblTotalDoc.Text = "0.00"
        Me.LblTotalDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(420, 411)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 17)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Total de Clientes : 0"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 128)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 127)
        Me.Panel1.TabIndex = 49
        '
        'FrmActulizar_Orden_Despacho
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1084, 478)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblTotalNroDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblTotalDoc)
        Me.Controls.Add(Me.GrpOD)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PnlOD)
        Me.Controls.Add(Me.GridDespacho)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmActulizar_Orden_Despacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Actualización de Orden Despacho"
        CType(Me.GridDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOD.ResumeLayout(False)
        Me.PnlOD.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgCabeceraOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpOD.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "FIELDS "
    Private TABLE_DESPACHO As New DataTable
    'Dim Ayuda As New ClsAyuda
    'Dim ClsDa As New clsdatos_JHON
    'Dim ClsInter As New ClsInterface
    Public TabCabOrden As New DataTable
    Private CODTIPODESP As String = "2"


#End Region

#Region "FUNCIONES FORM"

    Private Sub CARGAR_NRODESPACHO()
        Dim TABLECAB As New DataTable
        VNroDespacho = dgCabeceraOrden(Me.dgCabeceraOrden.CurrentRowIndex, 0)
        TABLECAB = TmpListarDatos("SP_TRAER_ORDENDESPACHO   '" & codempresa & "','" & VNroDespacho & "'")
        If TABLECAB.Rows.Count = 0 Then
            Exit Sub
        End If
        txtOrderDesp.Text = VNroDespacho
        TxtDestino.Text = TABLECAB.Rows(0)("DESTINO")
        TxtVehiculo.Text = TABLECAB.Rows(0)("CODVEHICULO")
        TxtFecDesp.Text = TABLECAB.Rows(0)("FECDESPACHO")
        TxtHoraDesp.Text = TABLECAB.Rows(0)("HORADESPACHO")
        TxtResponsable.Text = TABLECAB.Rows(0)("RESPONSABLE")
        TxtAyu.Text = TABLECAB.Rows(0)("AYUDANTE")

        Me.dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)
        TABLE_DESPACHO = TmpListarDatos("NSP_TRAER_CONSOLIDADOS_CLIENTE   '" & codempresa & "' , '" & VNroDespacho & "','" & CODTIPODESP & "' ")
        GridDespacho.DataSource = TABLE_DESPACHO
        FORMATO_GRID_DETALLE()
        LblTotalNroDoc.Text = "Total de Documentos : " & TABLE_DESPACHO.Rows.Count

    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean

        Const SYS_KEYDOWN As Integer = &H100
        Const SYSTEM_KEY As Integer = &H104
        If ((MSG.Msg = SYS_KEYDOWN) Or (MSG.Msg = SYSTEM_KEY)) Then
            Select Case KeyData
                Case Keys.Enter
                    If GridDespacho.Focus = True Then
                        If TABLE_DESPACHO.Rows.Count > 0 Then
                            VNroDoc = GridDespacho.Item(GridDespacho.CurrentRowIndex, 8)
                            VCdTipoDoc = GridDespacho.Item(GridDespacho.CurrentRowIndex, 1).ToString.Trim
                            VCodRuta = GridDespacho.Item(GridDespacho.CurrentRowIndex, 9).ToString.Trim
                            VPtoLLegada = GridDespacho.Item(GridDespacho.CurrentRowIndex, 10).ToString.Trim
                            VCodTiPrecioClie = GridDespacho.Item(GridDespacho.CurrentRowIndex, 11).ToString.Trim
                            VCodDep = GridDespacho.Item(GridDespacho.CurrentRowIndex, 12).ToString.Trim
                            EnviarDatos()
                            CARGAR_NRODESPACHO()

                        End If
                    End If
            End Select
        End If
    End Function



    Private Sub FORMATO_GRID_DETALLE()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_DESPACHO.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "FECDOCUM"
            .HeaderText = "Fecha"
            .Format = "dd/MM/yyyy"
            .Width = 0
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CODTIPODOC"
            .HeaderText = "Codtipodoc"
            .Width = 0
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DSTIPODOC"
            .HeaderText = "Tipo Doc"
            .Width = 100
        End With

        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "NRODOCU"
            .HeaderText = "Nro. Doc."
            .Format = "0##-#######"
            .Width = 75
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "CODCLIENTE"
            .HeaderText = "Codcliente"
            .Width = 0
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "DESCLIENTE"
            .HeaderText = "Cliente"
            .Width = 250
        End With
        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "DSTIPOPAGO"
            .HeaderText = "Cond. Pago"
            .Width = 120
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "TOTBAS"
            .HeaderText = "Importe"
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
            .Width = 75
        End With
        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "NRODOCFACT"
            .HeaderText = "NroFact"
            .Width = 0
        End With
        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "CODRUTA"
            .HeaderText = "CODRUTA"
            .Width = 0
        End With
        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "PTOLLEGADA"
            .HeaderText = "PTOLLEGADA"
            .Width = 0
        End With
        Dim Column12 As New DataGridTextBoxColumn
        With Column12
            .MappingName = "CODTIPOPRE"
            .HeaderText = "CODTIPOPRE"
            .Width = 0
        End With
        Dim Column13 As New DataGridTextBoxColumn
        With Column13
            .MappingName = "CODDEP"
            .HeaderText = "CODDEP"
            .Width = 0
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13})
        GridDespacho.TableStyles.Clear()
        GridDespacho.TableStyles.Add(TableStyle1)


    End Sub


    Sub CancelarTodo()
        Me.TabCabOrden.Rows.Clear()
        Me.dgCabeceraOrden.DataSource = TabCabOrden
        GridDespacho.DataSource = Nothing
        CANCELAR()

    End Sub


    Public Sub LlenarGrid(ByVal NRODESPACHO As String)
        If TabCabOrden.Rows.Count > 0 Then
            For ContY As Integer = 0 To TabCabOrden.Rows.Count - 1
                If TabCabOrden.Rows(ContY)("ORDEN_DESPACHO").ToString.Trim = NRODESPACHO.Trim Then
                    Exit Sub
                End If
            Next
        End If
        Conecta("SELECT FECDOCUM FROM ORDEN_DESPACHO WHERE NRORDEN_DESPACHO='" & NRODESPACHO.Trim & "' AND CODEMPRESA='" & codempresa.Trim & "'", "DTR")
        Dim filaCab As DataRow = TabCabOrden.NewRow
        filaCab(0) = VNroDespacho
        filaCab(1) = VFecDespacho
        TabCabOrden.Rows.Add(filaCab)
        TabCabOrden.AcceptChanges()
        dgCabeceraOrden.DataSource = TabCabOrden
        TablaEstiloCabecera.MappingName = TabCabOrden.TableName
        TablaEstiloCabecera.GridColumnStyles(0).MappingName = "ORDEN_DESPACHO"
        TablaEstiloCabecera.GridColumnStyles(1).MappingName = "FECHA"
        dgCabeceraOrden.TableStyles.Add(TablaEstiloCabecera)
    End Sub
    Sub CANCELAR()
        Dim o As Object
        For Each o In Me.PnlOD.Controls
            If TypeOf o Is Label Then
                If o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle Then
                    o.text = ""
                End If
            End If
        Next
    End Sub

    Sub EnviarDatos()
        Dim Frm As New FrmEditarDocumento_enOrdenDespacho
        Frm.ShowDialog()
        If Frm.DEVOLVER = False Then
            Exit Sub
        End If
        TABLE_DESPACHO = TmpListarDatos("NSP_TRAER_CONSOLIDADOS_CLIENTE   '" & codempresa & "' , '" & txtOrderDesp.Text & "' ")
        GridDespacho.DataSource = TABLE_DESPACHO
        FORMATO_GRID_DETALLE()
        CANCELAR()
    End Sub


#End Region

    Private Sub FrmActulizar_Orden_Despacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabCabOrden.Columns.Add("ORDEN_DESPACHO")
        TabCabOrden.Columns.Add("FECHA")
        Conecta("SELECT CODTIPOPAGO, DSTIPOPAGO FROM TIPO_PAGO WHERE CODEMPRESA ='" & codempresa & "'", "DS4")

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim o As New FrmBusquedaDeOrdenDespacho
        o.TIPO = "F"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        txtOrderDesp.Text = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        VNroDespacho = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        VFecDespacho = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 0)
        LlenarGrid(txtOrderDesp.Text.Trim)
        dgCabeceraOrden.CurrentRowIndex = TabCabOrden.Rows.Count - 1
        dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)
        If TABLE_DESPACHO.Rows.Count = 0 Then
            CARGAR_NRODESPACHO()
        End If


    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SQL As String
        Dim TblTabla As New DataTable
        Dim TblVtaxCobrar As New DataTable
        Dim Tabla, TablaDet As String
        Tabla = "VENTACAB"
        TablaDet = "VENTADET"

        If Len(VNroDoc) = 0 Then
            MsgBox("No Existe el Nro de Documento Para Anular en el Sistema" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Exit Sub
        End If

        If MsgBox("Desea Anular el Documento Actual" + Chr(13) + "Confirme", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            'Ahora Buscamos el Nro de Documento en la Tabla Ventas x Cobrar
            TblVtaxCobrar = CAyuda.ListarDatos("USP_BUSCAR_NRODOC_VENTA_X_COBRAR", VCdTipoDoc, VNroDoc, codempresa).Tables(0)
            'Si Existe en el Nro de Documento en La Tabla VentaxCobrar
            If TblVtaxCobrar.Rows.Count = 1 Then
                With TblVtaxCobrar
                    'Preguntas si es al Credito
                    If .Rows(0).Item("PAGCREDBAS") = 0 And .Rows(0).Item("PAGCREDEXT") = 0 Then
                        Conecta("SELECT NROGUIA FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND NRODOCU = " & VNroDoc & "", "x")
                        Dim VarNroGuia As String = Trim(ds.Tables("x").Rows(0).Item("NROGUIA").ToString())
                        SQL = "USP_ANULAR_DOCUMENTO '" & Tabla.Trim & "','" & TablaDet.Trim & "','" & VNroDoc & "','" & NROPTOVTA & "','" & codempresa & "','" & VCdTipoDoc & "'," & VarNroGuia & ""
                        If TmpInsertDatos(SQL) = True Then
                            MsgBox("El Documento Actual Fue Anulado Correctamente" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                            Call CANCELAR()
                        Else
                            MsgBox("Error Al Anular El Documento Actual Consulte Por Favor" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                            Exit Sub
                        End If
                    Else
                        MsgBox("El Nro de Documento Registra Pagos Consulte" + Chr(13) + "A su Proveedor", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
                    End If
                End With
            Else
                Conecta("SELECT NROGUIA FROM " & Tabla & " WHERE CODTIPODOC = '" & VCdTipoDoc & "' AND NRODOCU = " & VNroDoc & "", "x")
                Dim VarNroGuia As String = Trim(ds.Tables("x").Rows(0).Item("NROGUIA").ToString())
                SQL = "USP_ANULAR_DOCUMENTO '" & Tabla.Trim & "','" & TablaDet.Trim & "','" & VNroDoc & "','" & NROPTOVTA.Trim & "','" & codempresa & "','" & VCdTipoDoc & "','" & Val(VarNroGuia.Trim) & "'"
                If TmpInsertDatos(SQL) = True Then
                    MsgBox("El Documento Actual Fue Anulado Correctamente" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                    Call CANCELAR()
                    LlenarGrid(txtOrderDesp.Text.Trim)
                Else
                    MsgBox("Error Al Anular El Documento Actual Consulte Por Favor" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub GridDespacho_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridDespacho.Navigate

    End Sub

    Private Sub GridDespacho_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDespacho.DoubleClick
        Conecta("SELECT ORDEN_ACTUALIZADO FROM ORDEN_DESPACHO WHERE CODEMPRESA='" & codempresa & "' AND NRORDEN_DESPACHO ='" & GridDespacho(GridDespacho.CurrentRowIndex, 10).ToString.Trim & "'", "T1")
        If ds.Tables("T1").Rows(0)(0) Then
            MsgBox("Esta planilla ya se ha confirmado. Ya no se puede actualizar.", MsgBoxStyle.Information)
            Exit Sub
        End If
        EnviarDatos()

    End Sub

    Private Sub txtOrderDesp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrderDesp.TextChanged

    End Sub

    Private Sub txtOrderDesp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrderDesp.KeyDown
        If e.KeyCode = Keys.Enter Then
            LlenarGrid(txtOrderDesp.Text.Trim)
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        CancelarTodo()

    End Sub

    Private Sub BtnConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsult.Click
        CANCELAR()
        'BtnBusDoc.Enabled = True

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        For ContT As Integer = 0 To TabCabOrden.Rows.Count - 1
            If TabCabOrden.Rows(ContT)("ORDEN_DESPACHO").ToString.Trim = dgCabeceraOrden(dgCabeceraOrden.CurrentRowIndex, 0).ToString.Trim Then
                TabCabOrden.Rows.RemoveAt(ContT)
                Try
                    dgCabeceraOrden_CurrentCellChanged(sender, e)
                Catch ex As Exception
                End Try
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizarSeleccionada.Click
        Try
            If TmpInsertDatos("NSP_ACUALIZAR_ORDEN_DESPACHO  '" & codempresa & "','" & VNroDespacho & "'") Then
                MsgBox("La Orden de Despacho  Nro " & dgCabeceraOrden(dgCabeceraOrden.CurrentRowIndex, 0).ToString.Trim & " ha sido  actualizado para crear su planilla...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                CARGAR_NRODESPACHO()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgCabeceraOrden_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgCabeceraOrden.Navigate

    End Sub

    Private Sub dgCabeceraOrden_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCabeceraOrden.CurrentCellChanged
        Try
            CARGAR_NRODESPACHO()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizaragregadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizaragregadas.Click
        For ContH As Integer = 0 To TabCabOrden.Rows.Count - 1
            Dim VarBool As Boolean
            VarBool = TmpInsertDatos("NSP_ACUALIZAR_ORDEN_DESPACHO  '" & codempresa & "','" & TabCabOrden.Rows(ContH)("ORDEN_DESPACHO").ToString.Trim & "'")
            If VarBool = False Then
                MsgBox("Hubo problemas para actalizar la Orden de Despacho", MsgBoxStyle.Information)
                Exit Sub
            End If
        Next
        'If TmpInsertDatos("NSP_ACUALIZAR_ORDEN_DESPACHO  '" & codempresa & "','" & txtOrderDesp.Text.Trim & "'") = True Then
        '        MsgBox("La Orden de Despacho  Nro " & txtOrderDesp.Text.Trim & " ha sido  actualizado para crear su planilla...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        If TabCabOrden.Rows.Count > 1 Then
            MsgBox("La Ordenes de Despacho han sido actualizados para crear sus planillas...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        Else
            MsgBox("La Orden de Despacho  Nro " & txtOrderDesp.Text.Trim & " ha sido  actualizado para crear su planilla...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If

        CancelarTodo()
        'End If
    End Sub
End Class
