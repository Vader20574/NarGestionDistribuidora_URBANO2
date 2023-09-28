Public Class FrmPlanillaOrdenVta
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAGregarOD As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtOrderDesp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents GridDespacho As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LblTotalMonto As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BtnConsult As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblPAGCRED As System.Windows.Forms.Label
    Friend WithEvents LblTotalAcuenta As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtAcuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblRuc As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblRazonSoc As System.Windows.Forms.Label
    Friend WithEvents BtnBusDoc As System.Windows.Forms.Button
    Friend WithEvents LblNroDoc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblFechaDoc As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblDsTipoDoc As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtNumPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GrpCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCobrador As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbCobrador As System.Windows.Forms.Label
    Friend WithEvents btnCobrador As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblCambio As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlanillaOrdenVta))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAGregarOD = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtOrderDesp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.GridDespacho = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LblTotalMonto = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BtnConsult = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblPAGCRED = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtAcuenta = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblRuc = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblRazonSoc = New System.Windows.Forms.Label
        Me.BtnBusDoc = New System.Windows.Forms.Button
        Me.LblNroDoc = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblFechaDoc = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblDsTipoDoc = New System.Windows.Forms.Label
        Me.LblTotalAcuenta = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.txtNumPlanilla = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.GrpCabecera = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCobrador = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.lbCobrador = New System.Windows.Forms.Label
        Me.btnCobrador = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.LblHora = New System.Windows.Forms.Label
        Me.LblFecha = New System.Windows.Forms.Label
        Me.LblCambio = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        CType(Me.GridDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCabecera.SuspendLayout()
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnAGregarOD)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnBuscar)
        Me.Panel2.Controls.Add(Me.txtOrderDesp)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(10, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 39)
        Me.Panel2.TabIndex = 49
        '
        'btnAGregarOD
        '
        Me.btnAGregarOD.ImageList = Me.ImageList1
        Me.btnAGregarOD.Location = New System.Drawing.Point(694, 9)
        Me.btnAGregarOD.Name = "btnAGregarOD"
        Me.btnAGregarOD.Size = New System.Drawing.Size(216, 53)
        Me.btnAGregarOD.TabIndex = 45
        Me.btnAGregarOD.Text = "A&gregar Orden de Despacho"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(326, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 26)
        Me.Label9.TabIndex = 44
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(274, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 17)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Hora : "
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(146, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 26)
        Me.Label6.TabIndex = 42
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Fecha : "
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.ImageIndex = 5
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(271, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 30)
        Me.btnBuscar.TabIndex = 40
        Me.btnBuscar.Text = "[Buscar]"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOrderDesp
        '
        Me.txtOrderDesp.Location = New System.Drawing.Point(142, 7)
        Me.txtOrderDesp.Name = "txtOrderDesp"
        Me.txtOrderDesp.Size = New System.Drawing.Size(120, 22)
        Me.txtOrderDesp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "#Orden de Venta : "
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridDespacho
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'GridDespacho
        '
        Me.GridDespacho.CaptionText = "                                       ==============[Doble Click]  ó  [ENTER] --" & _
            ">Para   Modificar =============="
        Me.GridDespacho.DataMember = ""
        Me.GridDespacho.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridDespacho.Location = New System.Drawing.Point(7, 295)
        Me.GridDespacho.Name = "GridDespacho"
        Me.GridDespacho.ReadOnly = True
        Me.GridDespacho.Size = New System.Drawing.Size(1056, 257)
        Me.GridDespacho.TabIndex = 47
        Me.GridDespacho.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "dd/MM/yyyy"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 80
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "CodtipoDoc"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Tipo Doc."
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 110
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Nro Doc."
        Me.DataGridTextBoxColumn1.NullText = ""
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Estado"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CODCLIENTE"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Descripcion"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 250
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "CODTIPOPAGO"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Cond. Pago"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn10.Format = "#######0.00"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Importe"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 55
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = "#######0.00"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Acuenta__"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 55
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn12.Format = "#######0.00"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Por Pagar"
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "CODDEP"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'LblTotalMonto
        '
        Me.LblTotalMonto.BackColor = System.Drawing.Color.White
        Me.LblTotalMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalMonto.Location = New System.Drawing.Point(482, 557)
        Me.LblTotalMonto.Name = "LblTotalMonto"
        Me.LblTotalMonto.Size = New System.Drawing.Size(77, 27)
        Me.LblTotalMonto.TabIndex = 51
        Me.LblTotalMonto.Text = "0.00"
        Me.LblTotalMonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblTotalMonto.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BtnConsult)
        Me.GroupBox2.Location = New System.Drawing.Point(934, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 233)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(10, 23)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(112, 35)
        Me.BTNNUEVO.TabIndex = 501
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(10, 58)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(112, 34)
        Me.BTNGUARDAR.TabIndex = 502
        Me.BTNGUARDAR.Text = "&Guardar"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(10, 92)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(112, 35)
        Me.BTNCANCELAR.TabIndex = 28
        Me.BTNCANCELAR.TabStop = False
        Me.BTNCANCELAR.Text = "     &Cancelar"
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(10, 127)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(112, 35)
        Me.btnreporte.TabIndex = 500
        Me.btnreporte.TabStop = False
        Me.btnreporte.Text = "&Reporte"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(10, 162)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(112, 34)
        Me.BTNCERRAR.TabIndex = 500
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "  &Salir"
        '
        'BtnConsult
        '
        Me.BtnConsult.ImageList = Me.ImageList1
        Me.BtnConsult.Location = New System.Drawing.Point(142, 97)
        Me.BtnConsult.Name = "BtnConsult"
        Me.BtnConsult.Size = New System.Drawing.Size(96, 35)
        Me.BtnConsult.TabIndex = 51
        Me.BtnConsult.Text = "&Consultar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblPAGCRED)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxtAcuenta)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LblRuc)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblDireccion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.lblRazonSoc)
        Me.Panel1.Controls.Add(Me.BtnBusDoc)
        Me.Panel1.Controls.Add(Me.LblNroDoc)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblFechaDoc)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.LblDsTipoDoc)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(10, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 125)
        Me.Panel1.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(454, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 17)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Pago restante :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPAGCRED
        '
        Me.lblPAGCRED.BackColor = System.Drawing.Color.White
        Me.lblPAGCRED.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPAGCRED.Location = New System.Drawing.Point(552, 92)
        Me.lblPAGCRED.Name = "lblPAGCRED"
        Me.lblPAGCRED.Size = New System.Drawing.Size(110, 27)
        Me.lblPAGCRED.TabIndex = 59
        Me.lblPAGCRED.Text = "0.00"
        Me.lblPAGCRED.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(691, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Total Acuenta:"
        Me.Label12.Visible = False
        '
        'TxtAcuenta
        '
        Me.TxtAcuenta.Location = New System.Drawing.Point(317, 93)
        Me.TxtAcuenta.Name = "TxtAcuenta"
        Me.TxtAcuenta.Size = New System.Drawing.Size(115, 22)
        Me.TxtAcuenta.TabIndex = 56
        Me.TxtAcuenta.Text = "0.00"
        Me.TxtAcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(257, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 17)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Acuenta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(504, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "RUC:"
        '
        'LblRuc
        '
        Me.LblRuc.BackColor = System.Drawing.Color.White
        Me.LblRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRuc.Location = New System.Drawing.Point(542, 35)
        Me.LblRuc.Name = "LblRuc"
        Me.LblRuc.Size = New System.Drawing.Size(120, 26)
        Me.LblRuc.TabIndex = 49
        Me.LblRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Direccion:"
        '
        'lblDireccion
        '
        Me.lblDireccion.BackColor = System.Drawing.Color.White
        Me.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDireccion.Location = New System.Drawing.Point(125, 63)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(537, 27)
        Me.lblDireccion.TabIndex = 47
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Nomb/Raz Soc.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Monto Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(125, 92)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 27)
        Me.lblTotal.TabIndex = 43
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRazonSoc
        '
        Me.lblRazonSoc.BackColor = System.Drawing.Color.White
        Me.lblRazonSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRazonSoc.Location = New System.Drawing.Point(125, 35)
        Me.lblRazonSoc.Name = "lblRazonSoc"
        Me.lblRazonSoc.Size = New System.Drawing.Size(374, 26)
        Me.lblRazonSoc.TabIndex = 42
        Me.lblRazonSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBusDoc
        '
        Me.BtnBusDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBusDoc.ImageIndex = 5
        Me.BtnBusDoc.ImageList = Me.ImageList1
        Me.BtnBusDoc.Location = New System.Drawing.Point(250, 0)
        Me.BtnBusDoc.Name = "BtnBusDoc"
        Me.BtnBusDoc.Size = New System.Drawing.Size(88, 35)
        Me.BtnBusDoc.TabIndex = 41
        Me.BtnBusDoc.Text = "[Buscar]"
        Me.BtnBusDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblNroDoc
        '
        Me.LblNroDoc.BackColor = System.Drawing.Color.White
        Me.LblNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroDoc.Location = New System.Drawing.Point(125, 5)
        Me.LblNroDoc.Name = "LblNroDoc"
        Me.LblNroDoc.Size = New System.Drawing.Size(120, 26)
        Me.LblNroDoc.TabIndex = 5
        Me.LblNroDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nro Documento.: "
        '
        'LblFechaDoc
        '
        Me.LblFechaDoc.BackColor = System.Drawing.Color.White
        Me.LblFechaDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFechaDoc.Location = New System.Drawing.Point(434, 5)
        Me.LblFechaDoc.Name = "LblFechaDoc"
        Me.LblFechaDoc.Size = New System.Drawing.Size(120, 26)
        Me.LblFechaDoc.TabIndex = 49
        Me.LblFechaDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(353, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Fecha Doc.:"
        '
        'LblDsTipoDoc
        '
        Me.LblDsTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDsTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDsTipoDoc.Location = New System.Drawing.Point(722, 9)
        Me.LblDsTipoDoc.Name = "LblDsTipoDoc"
        Me.LblDsTipoDoc.Size = New System.Drawing.Size(188, 74)
        Me.LblDsTipoDoc.TabIndex = 46
        Me.LblDsTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotalAcuenta
        '
        Me.LblTotalAcuenta.BackColor = System.Drawing.Color.White
        Me.LblTotalAcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalAcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAcuenta.Location = New System.Drawing.Point(893, 554)
        Me.LblTotalAcuenta.Name = "LblTotalAcuenta"
        Me.LblTotalAcuenta.Size = New System.Drawing.Size(139, 30)
        Me.LblTotalAcuenta.TabIndex = 58
        Me.LblTotalAcuenta.Text = "0.00"
        Me.LblTotalAcuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(696, 560)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(155, 20)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Total Cobranza : "
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(254, 5)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(530, 43)
        Me.LblTitulo.TabIndex = 62
        Me.LblTitulo.Text = "NUEVA PLANILLA DE ORDEN DE VENTA"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTitulo.Visible = False
        '
        'txtNumPlanilla
        '
        Me.txtNumPlanilla.Enabled = False
        Me.txtNumPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPlanilla.Location = New System.Drawing.Point(944, 14)
        Me.txtNumPlanilla.Name = "txtNumPlanilla"
        Me.txtNumPlanilla.Size = New System.Drawing.Size(114, 30)
        Me.txtNumPlanilla.TabIndex = 61
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(826, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 20)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Nro Planilla : "
        '
        'GrpCabecera
        '
        Me.GrpCabecera.Controls.Add(Me.Label17)
        Me.GrpCabecera.Controls.Add(Me.txtCobrador)
        Me.GrpCabecera.Controls.Add(Me.dtpFecha)
        Me.GrpCabecera.Controls.Add(Me.lbCobrador)
        Me.GrpCabecera.Controls.Add(Me.btnCobrador)
        Me.GrpCabecera.Controls.Add(Me.Label18)
        Me.GrpCabecera.Controls.Add(Me.LblHora)
        Me.GrpCabecera.Controls.Add(Me.LblFecha)
        Me.GrpCabecera.Controls.Add(Me.LblCambio)
        Me.GrpCabecera.Controls.Add(Me.Label19)
        Me.GrpCabecera.Controls.Add(Me.Label20)
        Me.GrpCabecera.Controls.Add(Me.Panel2)
        Me.GrpCabecera.Location = New System.Drawing.Point(137, 44)
        Me.GrpCabecera.Name = "GrpCabecera"
        Me.GrpCabecera.Size = New System.Drawing.Size(741, 118)
        Me.GrpCabecera.TabIndex = 63
        Me.GrpCabecera.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(473, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 17)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Moneda :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'txtCobrador
        '
        Me.txtCobrador.Location = New System.Drawing.Point(91, 18)
        Me.txtCobrador.Name = "txtCobrador"
        Me.txtCobrador.Size = New System.Drawing.Size(120, 22)
        Me.txtCobrador.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(341, 18)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(108, 22)
        Me.dtpFecha.TabIndex = 7
        '
        'lbCobrador
        '
        Me.lbCobrador.BackColor = System.Drawing.Color.White
        Me.lbCobrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCobrador.Location = New System.Drawing.Point(91, 46)
        Me.lbCobrador.Name = "lbCobrador"
        Me.lbCobrador.Size = New System.Drawing.Size(355, 26)
        Me.lbCobrador.TabIndex = 18
        Me.lbCobrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCobrador
        '
        Me.btnCobrador.ImageIndex = 5
        Me.btnCobrador.ImageList = Me.ImageList1
        Me.btnCobrador.Location = New System.Drawing.Point(214, 17)
        Me.btnCobrador.Name = "btnCobrador"
        Me.btnCobrador.Size = New System.Drawing.Size(33, 27)
        Me.btnCobrador.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(286, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Fecha :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(607, 48)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(102, 20)
        Me.LblHora.TabIndex = 23
        Me.LblHora.Text = "11:58 a.m. "
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(511, 48)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(107, 20)
        Me.LblFecha.TabIndex = 22
        Me.LblFecha.Text = "30/07/2010 "
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambio.Location = New System.Drawing.Point(571, 20)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(94, 20)
        Me.LblCambio.TabIndex = 25
        Me.LblCambio.Text = "T.C. 2.800"
        Me.LblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(-2, 21)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "CodCobrador :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(19, 50)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 17)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "Cobrador :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmPlanillaOrdenVta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1101, 594)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.txtNumPlanilla)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GridDespacho)
        Me.Controls.Add(Me.LblTotalMonto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblTotalAcuenta)
        Me.Controls.Add(Me.GrpCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPlanillaOrdenVta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla Orden Venta"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCabecera.ResumeLayout(False)
        Me.GrpCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



#Region "FIELDS "
    Public TABLE_DESPACHO As New DataTable
    'Dim Ayuda As New ClsAyuda
    'Dim ClsDa As New clsdatos_JHON
    'Dim ClsInter As New ClsInterface
    Private VarTipoPago As String
    Private VarCodCliente As String
    Private VarCodVendedor As String
    Public TablaARTI_FZAVENTA As New DataTable
    Public VProcesoGuardar As Boolean
    ' TablaARTI_FZAVENTA.Columns.Add("CDARTI")
    'TablaARTI_FZAVENTA.Columns.Add("CODPRES")
    Private EstadoCobro As String

    Dim GUIAD As String

    Dim GUIAC As String

#End Region

#Region "FUNCIONES"
    Private Sub LimpiarDatos()
        LblTitulo.Visible = False


    End Sub
    Private Sub LIMPIAR_CAJA_TEXTO()
        Dim ctrl As Object

        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Panel Then
                Dim a As Object
                For Each a In ctrl.controls
                    If TypeOf a Is TextBox Then
                        a.text = ""
                    ElseIf TypeOf a Is Label Then
                        If a.borderStyle = System.Windows.Forms.BorderStyle.FixedSingle Then
                            a.text = ""
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Sub INGRESAR_ACUENTA(ByVal CODTIPODOC As String, ByVal NRODOCU As String, ByVal ACUENTA As Double, ByVal TempVarTipoPago As String)
        For i As Integer = 0 To TABLE_DESPACHO.Rows.Count - 1
            If TABLE_DESPACHO.Rows(i)("CODTIPODOC").ToString.Trim = CODTIPODOC And TABLE_DESPACHO.Rows(i)("NRODOCU").ToString.Trim = NRODOCU Then
                Dim pagbas, pagext, saldobas, saldoext As Double

                pagbas = CDbl(TxtAcuenta.Text)
                pagext = CDbl(TxtAcuenta.Text) / CDbl(LblCambio.Text)
                saldobas = CDbl(TABLE_DESPACHO.Rows(i)("TOTBAS")) - CDbl(TxtAcuenta.Text)
                saldoext = saldobas / CDbl(LblCambio.Text)

                TABLE_DESPACHO.Rows(i)("ACUENTA") = Format(CDbl(ACUENTA), "#######0.00")

                EstadoCobro = CAyuda.ListarDatos("SP_CALCULA_EST_PLANI", codempresa, CODTIPODOC.Trim, NRODOCU.Trim, pagbas).Tables(0).Rows(0)(0).ToString
                If saldobas = 0 Then
                    EstadoCobro = "CANCELADO"
                End If

                If TempVarTipoPago.Trim.Length > 0 Then
                    TABLE_DESPACHO.Rows(i)("CODTIPOPAGO") = TempVarTipoPago
                    Conecta("SELECT DSTIPOPAGO FROM TIPO_PAGO   WHERE   CODTIPOPAGO='" & TempVarTipoPago.Trim & "' AND CODEMPRESA = '" & codempresa.Trim & "'", "DSRT")
                    TABLE_DESPACHO.Rows(i)("DSTIPOPAGO") = ds.Tables("DSRT").Rows(0)("DSTIPOPAGO")
                    CAyuda.Ejecutar("SP_UPD_DET_PLANORDEN", codempresa, VCorrelVta, pagbas, pagext, saldobas, saldoext, TempVarTipoPago.Trim, ds.Tables("DSRT").Rows(0)("DSTIPOPAGO").ToString, NRODOCU, EstadoCobro, CODTIPODOC)
                Else
                    CAyuda.Ejecutar("SP_UPD_DET_PLANORDEN", codempresa, VCorrelVta, pagbas, pagext, saldobas, saldoext, "", "", NRODOCU, EstadoCobro, CODTIPODOC)
                End If
                'Conecta("SELECT PAGCREDBAS FROM VENTA_X_COBRAR WHERE CDTIPODOCUM='" & CODTIPODOC.Trim & "' AND NRODOCU='" & NRODOCU.Trim & "' AND CODEMPRESA='" & codempresa.Trim & "'", "TAB_AUX")
                'If ds.Tables("TAB_AUX").Rows.Count > 0 Then
                '    TABLE_DESPACHO.Rows(i)("PAGCREDBAS") = CDbl(ds.Tables("TAB_AUX").Rows(0)(0)) - ACUENTA
                'Else
                '    TABLE_DESPACHO.Rows(i)("PAGCREDBAS") = Format(CDbl(TABLE_DESPACHO.Rows(i)("PAGCREDBAS") - TABLE_DESPACHO.Rows(i)("ACUENTA")), "#######0.00")
                'End If
                CANCELAR()
                Exit For
            End If
        Next
        LLenarGrid_Edt()
        LblTotalMonto.Text = "0.0"
        LblTotalAcuenta.Text = "0.0"
        For a As Integer = 0 To TABLE_DESPACHO.Rows.Count - 1
            LblTotalMonto.Text = CDbl(LblTotalMonto.Text) + CDbl(TABLE_DESPACHO.Rows(a)("TOTBAS").ToString)
            LblTotalAcuenta.Text = CDbl(LblTotalAcuenta.Text) + CDbl(TABLE_DESPACHO.Rows(a)("ACUENTA").ToString)
        Next


        LblTotalMonto.Text = Format(CDbl(LblTotalMonto.Text), "#######0.00")
        LblTotalAcuenta.Text = Format(CDbl(LblTotalAcuenta.Text), "#######0.00")

    End Sub

    Private Sub LLenarGrid_Edt()
        TABLE_DESPACHO = CAyuda.ListarDatos("SP_LIS_DETPLAN", codempresa, txtOrderDesp.Text.Trim, VCorrelVta).Tables(0)
        GridDespacho.DataSource = Nothing
        GridDespacho.DataSource = TABLE_DESPACHO
    End Sub


    Sub CancelarTodo()
        Panel1.Enabled = False
        GridDespacho.DataSource = Nothing
        txtOrderDesp.Text = String.Empty
        CANCELAR()
        LblTitulo.Visible = False
    End Sub


    Sub LlenarGrid(ByVal NRODESPACHO As String)

        TABLE_DESPACHO = TmpListarDatos("NSP_TRAER_CONSOLIDADOS_CLIENTE2   '" & codempresa & "' , '" & NRODESPACHO & "','" & VCorrelVta & "','" & GUIAD & "'")
        GridDespacho.DataSource = TABLE_DESPACHO

        DataGridTableStyle1.MappingName = TABLE_DESPACHO.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "FECDOCUM"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "CODTIPODOC"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "DSTIPODOC"
        DataGridTableStyle1.GridColumnStyles(3).MappingName = "NRODOCU"
        DataGridTableStyle1.GridColumnStyles(4).MappingName = "ESTADO"
        DataGridTableStyle1.GridColumnStyles(5).MappingName = "CODCLIENTE"
        DataGridTableStyle1.GridColumnStyles(6).MappingName = "DESCLIENTE"
        DataGridTableStyle1.GridColumnStyles(7).MappingName = "CODTIPOPAGO"
        DataGridTableStyle1.GridColumnStyles(8).MappingName = "DSTIPOPAGO"
        DataGridTableStyle1.GridColumnStyles(9).MappingName = "TOTBAS" 'importe - totbas
        DataGridTableStyle1.GridColumnStyles(10).MappingName = "ACUENTA" ' acuenta 
        DataGridTableStyle1.GridColumnStyles(11).MappingName = "SALDOBAS" ' por pagar SALDOBAS
        DataGridTableStyle1.GridColumnStyles(12).MappingName = "CODDEP"
        GridDespacho.TableStyles.Add(DataGridTableStyle1)

    End Sub





    Sub CANCELAR()
        Dim o As Object
        For Each o In Me.Panel1.Controls
            If TypeOf o Is Label Then
                If o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle Then
                    o.text = ""
                End If
            End If
            If TypeOf o Is TextBox Then
                o.text = "0.00"
            End If
        Next

    End Sub

    Sub EnviarDatos(ByVal CODTIPODOC As String, ByVal NRODOCU As String, ByVal DSTIPODOC As String, ByVal ACUENTA As Double, ByVal RESTOPAGO As Double)
        Try
            Dim TABLE_FACT As New DataTable
            TABLE_FACT = TmpListarDatos("NSP_BUSCAR_FACTURACION   '" & codempresa & "','" & NRODOCU & "' ,'" & CODTIPODOC & "','" & rand & "'")
            If TABLE_FACT.Rows.Count = 0 Then
                TABLE_FACT = TmpListarDatos("SP_SelecVENTACABSERV   '" & codempresa & "','" & CODTIPODOC & "' ,'" & NRODOCU & "'  ")
            End If
            Select Case TABLE_FACT.Rows(0)("ESTADO").ToString.Trim
                Case "A"
                    MsgBox("El Documento Que Consulto Fue Anulado" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
                    Exit Sub
                Case "C"
                    MsgBox("El Documento Que Consulto ya ha sido cancelado" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                    Me.TxtAcuenta.Enabled = False
                Case ""
                    Me.TxtAcuenta.Enabled = True
            End Select
            Dim NroIni As String  '//   - 7 
            Dim NroFin As String  ' los 7 ultimos
            VNroDoc = TABLE_FACT.Rows(0)("NRODOCU").ToString.Trim
            NroIni = Mid(TABLE_FACT.Rows(0)("NRODOCU").ToString.Trim, 1, TABLE_FACT.Rows(0)("NRODOCU").ToString.Trim.Length - 7)
            NroFin = Microsoft.VisualBasic.Right(TABLE_FACT.Rows(0)("NRODOCU").ToString.Trim, 7)
            LblNroDoc.Text = Microsoft.VisualBasic.Right("0000" & NroIni, 3) & "-" & NroFin
            lblRazonSoc.Text = TABLE_FACT.Rows(0)("DESCLIENTE").ToString.Trim
            LblRuc.Text = TABLE_FACT.Rows(0)("RUCCLIENTE").ToString.Trim
            lblDireccion.Text = TABLE_FACT.Rows(0)("DIRCLIENTE").ToString.Trim
            lblTotal.Text = Format(CDbl(TABLE_FACT.Rows(0)("TOTBAS").ToString.Trim), "#######0.00")
            Me.lblPAGCRED.Text = Format(CDbl(RESTOPAGO), "#######0.00")
            LblDsTipoDoc.Text = DSTIPODOC
            VarTipoPago = TABLE_FACT.Rows(0)("CODTIPOPAGO").ToString.Trim
            VarCodCliente = IIf(TABLE_FACT.Rows(0)("CODDEP").ToString.Trim = "", TABLE_FACT.Rows(0)("CODCLIENTE").ToString.Trim, TABLE_FACT.Rows(0)("CODDEP").ToString.Trim)
            VCodDep = IIf(TABLE_FACT.Rows(0)("CODDEP").ToString.Trim = "", TABLE_FACT.Rows(0)("CODCLIENTE").ToString.Trim, TABLE_FACT.Rows(0)("CODDEP").ToString.Trim)
            VarCodVendedor = TABLE_FACT.Rows(0)("CODVEND").ToString.Trim
            VCdTipoDoc = CODTIPODOC
            LblFechaDoc.Text = Format(CDate(TABLE_FACT.Rows(0)("FECDOCUM").ToString.Trim), "dd/MM/yyyy")
            TxtAcuenta.Text = Format(CDbl(TABLE_FACT.Rows(0)("TOTBAS").ToString.Trim), "#######0.00")
            TxtAcuenta.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean

        Const SYS_KEYDOWN As Integer = &H100
        Const SYSTEM_KEY As Integer = &H104
        If ((MSG.Msg = SYS_KEYDOWN) Or (MSG.Msg = SYSTEM_KEY)) Then
            Select Case KeyData
                Case Keys.Enter
                    If GridDespacho.Focus = True Then
                        VCodDep = GridDespacho.Item(GridDespacho.CurrentRowIndex, 12).ToString.Trim
                        EnviarDatos(GridDespacho.Item(GridDespacho.CurrentRowIndex, 1).ToString.Trim, GridDespacho.Item(GridDespacho.CurrentRowIndex, 3).ToString.Trim, GridDespacho.Item(GridDespacho.CurrentRowIndex, 2).ToString.Trim, CDbl(GridDespacho.Item(GridDespacho.CurrentRowIndex, 10).ToString.Trim), CDbl(GridDespacho(GridDespacho.CurrentRowIndex, 11).ToString.Trim))

                    End If
            End Select
        End If
    End Function

#End Region
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        Dim o As New FrmBuscOrdenVenta
        o.TIPO = "T"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        txtOrderDesp.Text = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        dtpFecha.Value = Format(CDate(o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 0)), "dd/MM/yyyy")
        GUIAC = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 4)
        GUIAD = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 5)

        LlenarGrid(txtOrderDesp.Text.Trim)

        For i As Integer = 0 To TABLE_DESPACHO.Rows.Count - 1
            If TABLE_DESPACHO.Rows(i)("NRODOCU").ToString.Trim() = "180189889" Then
                MsgBox("aaa")
            End If

            EnviarDatos(TABLE_DESPACHO.Rows(i)("CODTIPODOC").ToString.Trim(), TABLE_DESPACHO.Rows(i)("NRODOCU").ToString.Trim(), TABLE_DESPACHO.Rows(i)("DSTIPOPAGO").ToString.Trim(), TABLE_DESPACHO.Rows(i)("ACUENTA").ToString.Trim(), TABLE_DESPACHO.Rows(i)("SALDOBAS").ToString.Trim())
            Procesar()
        Next



        Panel1.Enabled = True
        BtnBusDoc.Enabled = True

    End Sub

    Sub Procesar()
        If Me.lblTotal.Text.Trim.Length = 0 Then
            MsgBox("Escoga un documento a procesar", MsgBoxStyle.Information)
            Exit Sub
        End If
        If CDbl(Me.TxtAcuenta.Text.Trim) > CDbl(Me.lblTotal.Text.Trim) Then
            MsgBox("El monto a cuenta no puede superar el importe a pagar", MsgBoxStyle.Information)
            Exit Sub
        End If
        If CDbl(Me.TxtAcuenta.Text) < CDbl(Me.lblTotal.Text.Trim) And (VarTipoPago.Trim) = VCdPagEfectivo Then
            If VCodDep.Trim = "" Then
                MsgBox("EL CLIENTE  NO ESTA REGISTRADO...", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            '' SI ES A CONTADO Y EL MONTO A CUENTA ES MENOR AL IMPORTE TOTAL
            Dim Rpta As String
            Rpta = MsgBox("El importe a cuenta es Menor al importe Total del Doc.Vta. " + vbCrLf + "Es necesario modificar la condicion de pago a CRÉDITO, ¿ Desea hacer el cambio ?", MsgBoxStyle.YesNo).ToString
            If Rpta.Equals("Yes") Then
                '' SE ACEPTA CAMBIAR EL TIPO DE PAGO A CREDITO
                Conecta("SELECT CODTIPOPAGO FROM CLIENTE WHERE CODCLIENTE = '" & VCodDep & "' AND CODEMPRESA ='" & codempresa.Trim & "'", "DS4")
                If ds.Tables("DS4").Rows.Count = 0 Then
                    MsgBox("- El cliente ha sido dado de baja." & vbNewLine & " Revisar Existencia.", MsgBoxStyle.Information, "Narsistemas")
                    Exit Sub
                End If
                Dim VarCurrentTipoPago As String
                VarCurrentTipoPago = ds.Tables("DS4").Rows(0)(0)
                If CDbl(VarCurrentTipoPago) = 1 Then
                    '' EL CLIENTE SOLO TIENE EFECTIVO
                    'MsgBox("El Cliente solo tiene disponible Ventas en Efectivo," + vbCrLf + " Asigne el Crédito por fuerza de venta en la pantalla de Mantenimiento de Clientes.")
                    'Exit Sub
                    LLenaGridFuerzaX_Cliente("")
                Else
                    '' EL CLIENTE TIENE POSIBILIDAD DE TIPO PAGO A CREDITO
                    LLenaGridFuerzaX_Cliente(VCdPagCredito)
                End If
            Else
                Exit Sub
            End If

        Else
            If (VarTipoPago.Trim) = VCdPagCredito Then
                LLenaGridFuerzaX_Cliente("")
            Else
                LLenaGridFuerzaX_Cliente("")
            End If
            'INGRESAR_ACUENTA(CdTipoDocu, xNroDocum, CDbl(TxtAcuenta.Text), "")
        End If
    End Sub



    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub TxtAcuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAcuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.lblTotal.Text.Trim.Length = 0 Then
                MsgBox("Escoga un documento a procesar", MsgBoxStyle.Information)
                Exit Sub
            End If
            If CDbl(Me.TxtAcuenta.Text.Trim) > CDbl(Me.lblTotal.Text.Trim) Then
                MsgBox("El monto a cuenta no puede superar el importe a pagar", MsgBoxStyle.Information)
                Exit Sub
            End If
            If CDbl(Me.TxtAcuenta.Text) < CDbl(Me.lblTotal.Text.Trim) And (VarTipoPago.Trim) = VCdPagEfectivo Then
                If VCodDep.Trim = "" Then
                    MsgBox("EL CLIENTE  NO ESTA REGISTRADO...", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                '' SI ES A CONTADO Y EL MONTO A CUENTA ES MENOR AL IMPORTE TOTAL
                Dim Rpta As String
                Rpta = MsgBox("El importe a cuenta es Menor al importe Total del Doc.Vta. " + vbCrLf + "Es necesario modificar la condicion de pago a CRÉDITO, ¿ Desea hacer el cambio ?", MsgBoxStyle.YesNo).ToString
                If Rpta.Equals("Yes") Then
                    '' SE ACEPTA CAMBIAR EL TIPO DE PAGO A CREDITO
                    Conecta("SELECT CODTIPOPAGO FROM CLIENTE WHERE CODCLIENTE = '" & VCodDep & "' AND CODEMPRESA ='" & codempresa.Trim & "'", "DS4")
                    If ds.Tables("DS4").Rows.Count = 0 Then
                        MsgBox("- El cliente ha sido dado de baja." & vbNewLine & " Revisar Existencia.", MsgBoxStyle.Information, "Narsistemas")
                        Exit Sub
                    End If
                    Dim VarCurrentTipoPago As String
                    VarCurrentTipoPago = ds.Tables("DS4").Rows(0)(0)
                    If CDbl(VarCurrentTipoPago) = 1 Then
                        '' EL CLIENTE SOLO TIENE EFECTIVO
                        'MsgBox("El Cliente solo tiene disponible Ventas en Efectivo," + vbCrLf + " Asigne el Crédito por fuerza de venta en la pantalla de Mantenimiento de Clientes.")
                        'Exit Sub
                        LLenaGridFuerzaX_Cliente("")
                    Else
                        '' EL CLIENTE TIENE POSIBILIDAD DE TIPO PAGO A CREDITO
                        LLenaGridFuerzaX_Cliente(VCdPagCredito)
                    End If
                Else
                    Exit Sub
                End If

            Else
                If (VarTipoPago.Trim) = VCdPagCredito Then
                    LLenaGridFuerzaX_Cliente("")
                Else
                    LLenaGridFuerzaX_Cliente("")
                End If
                'INGRESAR_ACUENTA(CdTipoDocu, xNroDocum, CDbl(TxtAcuenta.Text), "")
            End If
        End If
    End Sub

    Private Sub LLenaGridFuerzaX_Cliente(ByVal TempVarTipoPag As String)
        Try

            Conecta("SELECT * FROM GUIAINTERNADET WHERE CODTIPODOC='" & VCdTipoDoc & "' AND NRODOCFACT='" & VNroDoc & "' AND CODEMPRESA='" & codempresa.Trim & "'", "TAB_ARTI")
            Dim VarTablaArtiV As New DataTable
            VarTablaArtiV = ds.Tables("TAB_ARTI")
            For ContAr As Integer = 0 To TablaARTI_FZAVENTA.Rows.Count - 1
                If ContAr > TablaARTI_FZAVENTA.Rows.Count - 1 Then
                    Exit For
                End If
                If TablaARTI_FZAVENTA.Rows(ContAr)("CODTIPODOC").ToString.Trim = VCdTipoDoc And TablaARTI_FZAVENTA.Rows(ContAr)("NRODOCFACT").ToString.Trim = VNroDoc Then
                    TablaARTI_FZAVENTA.Rows.RemoveAt(ContAr)
                    ContAr -= 1
                End If
            Next
            '''' RECORRE LA TABLA ARTICULOS VENDIDOS
            For Cont1 As Integer = 0 To VarTablaArtiV.Rows.Count - 1
                Conecta("SELECT * FROM ARTICULO WHERE CODARTI = '" & VarTablaArtiV.Rows(Cont1)("CODARTI").ToString.Trim & "' AND CODEMPRESA ='" & codempresa.Trim & "'", "TabDatArti")
                Dim TempLinea, TempSubLinea As String
                TempLinea = ds.Tables("TabDatArti").Rows(0)("CODLINEA")
                TempSubLinea = ds.Tables("TabDatArti").Rows(0)("CODSUBLINEA")
                Dim TAB_TAB As New DataTable
                If VarCodCliente.Trim <> CLIENTEPTOVTA.Trim Then
                    'SE EXTRAE LA FZA DE VTA EN FUNCION A SUBLINA Y CLIENTE
                    TAB_TAB = CAyuda.ListarDatos("NSP_LSITAR_FUERZA_ARTICULO_CLIENTE", codempresa.Trim, TempLinea.Trim, TempSubLinea.Trim, VarCodCliente.Trim).Tables(0)
                    '''' LISTA DE ARICULOS Y FUERZA DE VENTA 
                    If TablaARTI_FZAVENTA.Rows.Count > 0 Then
                        Dim tFila As DataRow = TablaARTI_FZAVENTA.NewRow
                        tFila("FZAVENTA") = TAB_TAB.Rows(0)("CODFZAVTA").ToString.Trim
                        tFila("CODTIPODOC") = VCdTipoDoc
                        tFila("NRODOC") = VNroDoc
                        tFila("CODCLIE") = VarCodCliente.Trim
                        tFila("IMPORTETOT") = CDbl(VarTablaArtiV.Rows(Cont1)("TOTBAS").ToString.Trim)
                        ''''''''''''''''''''' AQUI ESTA EL PROBLEMA
                        tFila("IMPORTEPAG") = (CDbl(Me.lblPAGCRED.Text.Trim) * CDbl(Me.TxtAcuenta.Text.Trim)) / CDbl(Me.lblPAGCRED.Text.Trim)
                        'tFila("IMPORTE") = Format(CDbl(Me.TxtAcuenta.Text.Trim), "#######0.00")
                        TablaARTI_FZAVENTA.Rows.Add(tFila)
                    Else
                        For ContU As Integer = 0 To TablaARTI_FZAVENTA.Rows.Count - 1

                            If TablaARTI_FZAVENTA.Rows(ContU)("FZAVENTA").ToString.Trim = TAB_TAB.Rows(0)("CODFZAVTA").ToString.Trim And TablaARTI_FZAVENTA.Rows(ContU)("CODCLIE").ToString.Trim = VarCodCliente.Trim And TablaARTI_FZAVENTA.Rows(ContU)("CODTIPODOC").ToString.Trim = VCdTipoDoc And TablaARTI_FZAVENTA.Rows(ContU)("NRODOC").ToString.Trim = VNroDoc Then
                                TablaARTI_FZAVENTA.Rows(ContU)("IMPORTETOT") = CDbl(TablaARTI_FZAVENTA.Rows(ContU)("IMPORTETOT")) + CDbl(VarTablaArtiV.Rows(Cont1)("TOTBAS").ToString.Trim)
                                TablaARTI_FZAVENTA.Rows(ContU)("IMPORTEPAG") = CDbl(TablaARTI_FZAVENTA.Rows(ContU)("IMPORTEPAG")) + ((CDbl(VarTablaArtiV.Rows(Cont1)("TOTBAS").ToString.Trim) * CDbl(Me.TxtAcuenta.Text.Trim)) / CDbl(Me.lblPAGCRED.Text.Trim))
                                Exit For
                            End If
                            If ContU = TablaARTI_FZAVENTA.Rows.Count - 1 Then
                                Dim tFila As DataRow = TablaARTI_FZAVENTA.NewRow
                                tFila("FZAVENTA") = TAB_TAB.Rows(0)("CODFZAVTA").ToString.Trim
                                tFila("CODTIPODOC") = VCdTipoDoc
                                tFila("NRODOC") = VNroDoc
                                tFila("CODCLIE") = VarCodCliente.Trim
                                tFila("IMPORTETOT") = CDbl(VarTablaArtiV.Rows(Cont1)("TOTBAS").ToString.Trim)
                                'tFila("IMPORTEPAG") = (CDbl(VarTablaArtiV.Rows(Cont1)("TOTBAS").ToString.Trim) * CDbl(Me.TxtAcuenta.Text.Trim)) / CDbl(Me.lblPAGCRED.Text.Trim)
                                tFila("IMPORTEPAG") = (CDbl(Me.lblPAGCRED.Text.Trim) * CDbl(Me.TxtAcuenta.Text.Trim)) / CDbl(Me.lblPAGCRED.Text.Trim)
                                'tFila("IMPORTE") = Format(CDbl(Me.TxtAcuenta.Text.Trim), "#######0.00")
                                TablaARTI_FZAVENTA.Rows.Add(tFila)
                                Exit For
                            End If
                        Next
                    End If
                End If

            Next

            If VarCodCliente.Trim <> CLIENTEPTOVTA.Trim Then

                ''''' HASTA ACA LA TABLA DE FZA DE VENTA  CON CLIENTES ESTA LLENO
                '''''''''''''''''  LA TABLA FUERZA VENTA CON IMPORTE''''''''''''''''''''''''''''
                If TablaARTI_FZAVENTA.Rows.Count > 0 Then
                    For Count4 As Integer = 0 To TablaARTI_FZAVENTA.Rows.Count - 1
                        Conecta("SELECT DESCRIPCION FROM FUERZAVENTA WHERE CODIGO='" & TablaARTI_FZAVENTA.Rows(Count4)("FZAVENTA").ToString.Trim & "' AND CODEMPRESA='" & codempresa.Trim & "'", "TABFZA")
                        Dim VarDescFzaVta As String
                        VarDescFzaVta = ds.Tables("TABFZA").Rows(0)("DESCRIPCION").ToString.Trim
                        Conecta("SELECT CREDITO_F, SALDO_CREDF FROM CLIE_FUERZA WHERE CODEMPRESA='" & codempresa.Trim & "' AND CODFUERZA='" & TablaARTI_FZAVENTA.Rows(Count4)("FZAVENTA").ToString.Trim & "' AND CODCLIE='" & VarCodCliente.Trim & "'", "DSFV")
                        '''''' REVISAR LINEA DE CREDITO FUERZA POR FUERZA '''''''
                        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                        If ds.Tables("DSFV").Rows.Count = 0 Then
                            MsgBox("En necesario habilitar la fuerza de venta [" & VarDescFzaVta.Trim & "] para este cliente.", MsgBoxStyle.Information)
                            Exit Sub
                        Else
                            If CDbl(ds.Tables("DSFV").Rows(0)("SALDO_CREDF").ToString.Trim) < CDbl(Me.TxtAcuenta.Text.Trim) Then
                                MsgBox("Es necesario incrementar el crédito para la fuerza de venta [" & VarDescFzaVta.Trim & "]", MsgBoxStyle.Information)
                                Exit Sub
                            End If
                        End If
                        If Count4 = TablaARTI_FZAVENTA.Rows.Count - 1 Then
                            INGRESAR_ACUENTA(VCdTipoDoc, VNroDoc, CDbl(TxtAcuenta.Text), TempVarTipoPag)
                        End If
                    Next
                Else
                    INGRESAR_ACUENTA(VCdTipoDoc, VNroDoc, CDbl(TxtAcuenta.Text), VCdPagEfectivo)

                End If

            Else

                INGRESAR_ACUENTA(VCdTipoDoc, VNroDoc, CDbl(TxtAcuenta.Text), VCdPagEfectivo)

            End If



        Catch ex As Exception
            MsgBox("Revisa las sublinea y linea de las fuerzas de venta a las que pertence este cliente", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub GridDespacho_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridDespacho.Navigate

    End Sub

    Private Sub GridDespacho_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDespacho.DoubleClick
        'EnviarDatos(GridDespacho.Item(GridDespacho.CurrentRowIndex, 1).ToString.Trim, GridDespacho.Item(GridDespacho.CurrentRowIndex, 3).ToString.Trim, GridDespacho.Item(GridDespacho.CurrentRowIndex, 2).ToString.Trim, CDbl(GridDespacho.Item(GridDespacho.CurrentRowIndex, 10).ToString.Trim))
        EnviarDatos(GridDespacho.Item(GridDespacho.CurrentRowIndex, 1).ToString.Trim, GridDespacho.Item(GridDespacho.CurrentRowIndex, 3).ToString.Trim, GridDespacho.Item(GridDespacho.CurrentRowIndex, 2).ToString.Trim, CDbl(GridDespacho.Item(GridDespacho.CurrentRowIndex, 10).ToString.Trim), CDbl(GridDespacho(GridDespacho.CurrentRowIndex, 11).ToString.Trim))
    End Sub


    Dim rand As Integer

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function
    Private Sub FrmPlanillaOrdenVta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TablaARTI_FZAVENTA.Columns.Add("FZAVENTA")
        TablaARTI_FZAVENTA.Columns.Add("CODTIPODOC")
        TablaARTI_FZAVENTA.Columns.Add("NRODOC")
        TablaARTI_FZAVENTA.Columns.Add("CODCLIE")
        TablaARTI_FZAVENTA.Columns.Add("IMPORTETOT")
        TablaARTI_FZAVENTA.Columns.Add("IMPORTEPAG")
        Me.LblCambio.Text = FACT_GFormatodeNumero(CDbl(VCambioVta))
        CancelarTodo()

        Call BOTONES(True, False, False, False, False)
        dtpFecha.Value = Format(vFechaActual, "dd/MM/yyyy")
        Me.LblFecha.Text = Format(vFechaActual, "dd/MM/yyyy")



        ValorRan()

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click




        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = dtpFecha.Value.Year
        MES = dtpFecha.Value.Month

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
        '***********************************************************************************************
        Dim DT_VERIFICAR_PLANILLA As DataTable
        DT_VERIFICAR_PLANILLA = TmpListarDatos("NSP_VERIFICAR_PLANILLA '" & codempresa & "','" & txtNumPlanilla.Text & "'")

        If DT_VERIFICAR_PLANILLA.Rows.Count > 0 Then
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL NUMERO DE PLANILLA " & txtNumPlanilla.Text & " YA EXISTE")
            Exit Sub
        End If
        '************************************************************************************************

        If LblTitulo.Visible = False Then
            MsgBox("ESTA ACTIVO EL MODO CONSULTA PARA DESACTIVAR DEBE CANCELAR LA OPERACION..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If txtCobrador.Text.Trim = "" Then
            MsgBox("FALTA INDICAR EL COBRADOR", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If
        If LblTotalAcuenta.Text.Trim = "" Then
            MsgBox("FALTA INDICAR LOS ACUENTAS DE MONTO A COMPENSAR...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        If LblTitulo.Visible = False Then
            MsgBox("ESTA ACTIVO EL MODO CONSULTA PARA DESACTIVAR DEBE CANCELAR LA OPERACION..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        'If CDbl(LblTotalAcuenta.Text) = 0 Then
        '    MsgBox("NO HAY MONTO A CONPENSAR...", MsgBoxStyle.Exclamation, "")
        '    Exit Sub
        'End If
        If txtOrderDesp.Text.Trim.Length = 0 Then
            MsgBox("FALTA INGRESAR LA ORDEN ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        ' txtNumPlanilla.Text = TmpListarDatos("SELECT  NROCOBRANZA FROM  CONFIGSIS  WHERE COD_EMPRESA='" & codempresa & "'").Rows(0)("NROCOBRANZA")
        Dim FrmComp As New FrmCompensar
        FrmComp.lbNumPlanilla.Text = txtNumPlanilla.Text
        FrmComp.lblMontoCompensar.Text = CDbl(LblTotalAcuenta.Text)
        FrmComp.ShowDialog()
        If FrmComp.DEVOLVER = False Then
            Exit Sub
        End If

        ' txtNumPlanilla.Text = TmpListarDatos("SELECT  NROCOBRANZA FROM  CONFIGSIS  WHERE COD_EMPRESA='" & codempresa & "'").Rows(0)("NROCOBRANZA")
        For ContA As Integer = 0 To FrmComp.TablaTemp.Rows.Count - 1
            CAyuda.Ejecutar("NSP_INSERT_DOC_COMP_PCOBROS", txtNumPlanilla.Text, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, txtCobrador.Text, CDbl(LblTotalAcuenta.Text.Trim), FrmComp.TablaTemp.Rows(ContA)("TIPO").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim)

            If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, 1, FrmComp.TablaTemp.Rows(ContA)("TIPOC").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, "", CodUsuario.Trim, FrmComp.TablaTemp.Rows(ContA)("CUENTAC").ToString.Trim, "", "", "", "", FrmComp.TablaTemp.Rows(ContA)("BServi").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("PTributario").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("RucADQ").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("RucProve").ToString.Trim) <> 0 Then

            End If

            'If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, 1, FrmComp.TablaTemp.Rows(ContA)("TIPOC").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, "", CodUsuario.Trim, FrmComp.TablaTemp.Rows(ContA)("CUENTAC").ToString.Trim, "", "", "", "") <> 0 Then

            'End If

        Next


        '****VERIFICAR VENTA X COBRAR*******************************************************************************************
        Dim DT_VERIFICAR_PLANILLA2 As DataTable
        DT_VERIFICAR_PLANILLA2 = TmpListarDatos("NSP_VERIFICAR_TMP_PLANILLA_VTAXCOBRAR '" & VCorrelVta & "'")

        If DT_VERIFICAR_PLANILLA2.Rows.Count = 0 Then
            MsgBox("NO SE PUEDE GUARDAR LA PLANILLA YA Q LA TABLA TEMPORAL A SIDO BORRADO SALGA DEL FORMULARIO Y VUELVE HACERLO")
            Exit Sub
        End If
        '************************************************************************************************



        If TmpInsertDatos("SP_INSPLANILLA_VTAXCOBRAR   '" & codempresa & "','" & txtCobrador.Text & "','" & CDMONBASE & "','" & Format(CDate(dtpFecha.Value), "dd/MM/yyyy") & "','" & CDbl(LblTotalAcuenta.Text) & "','" & CDbl(LblTotalAcuenta.Text) / VCambioVta & "','" & CodUsuario & "','" & VCambioVta & "','" & EstadoCobro & "','','" & VCorrelVta & "','" & txtNumPlanilla.Text & "','" & "003" & "','" & txtOrderDesp.Text & "'") = True Then
            MsgBox("SE GRABO LA PLANILLA DE COBRANZA" & vbNewLine & "NRO" & txtNumPlanilla.Text)
            TmpInsertDatos("DELETE  FROM TMP_PLANILLA_VTAXCOBRAR    WHERE CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")

            If GUIAC = "" Then
                TmpInsertDatos("UPDATE    GUIAINTERNACAB  SET  ESTADO='Z' WHERE  CODEMPRESA='" & codempresa & "'  AND CODTIPODESP='2' AND NRODESPACHO='" & txtOrderDesp.Text.Trim & "'")
            Else
                TmpInsertDatos("UPDATE    " & GUIAC & "  SET  ESTADO='Z' WHERE  CODEMPRESA='" & codempresa & "'  AND CODTIPODESP='2' AND NRODESPACHO='" & txtOrderDesp.Text.Trim & "'")
            End If

            LIMPIAR_CAJA_TEXTO()
            TABLE_DESPACHO.Rows.Clear()

            'CargarGridDet()
            'FormatoGridDet()
            LimpiarDatos()

            If TmpInsertDatos("NSP_AUMENTAR_CORREL_PLANILLA   '" & NROPTOVTA & "','" & codempresa & "','03','" & txtNumPlanilla.Text & "'") = True Then

            End If
        End If

        MessageBox.Show("NRO DE PLANILLA : " & Me.txtNumPlanilla.Text.Trim, "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call BOTONES(True, False, False, False, False)
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click

        Call BOTONES(True, False, False, False, False)

        LIMPIAR_CAJA_TEXTO()
        TABLE_DESPACHO.Rows.Clear()
        CancelarTodo()
        BtnBusDoc.Enabled = False
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click

        LIMPIAR_CAJA_TEXTO()
        TABLE_DESPACHO.Rows.Clear()

        txtNumPlanilla.Text = TmpListarDatos("SELECT nroplanilla03 FROM PTOVTA  WHERE CODEMPRESA='" & codempresa & "' and NROPTOVTA ='" & NROPTOVTA & "'").Rows(0)("nroplanilla03")

        LblTitulo.Visible = True

        txtOrderDesp.Clear()

        Call BOTONES(False, True, True, True, False)


    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal BUSCAR1 As Boolean, ByVal BUSCAR2 As Boolean, ByVal BUSCAR3 As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        btnCobrador.Enabled = BUSCAR1
        btnBuscar.Enabled = BUSCAR2
        BtnBusDoc.Enabled = BUSCAR3
    End Sub



    Private Sub btnAGregarOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAGregarOD.Click
        '' aqui se seleccioa un orden de despacho
    End Sub

    Private Sub GridDespacho_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDespacho.CurrentCellChanged

    End Sub

    Private Sub btnCobrador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrador.Click
        Dim FrmCob As New FrmBuscCobrador
        FrmCob.ShowDialog()
        If FrmCob.DEVOLVER = False Then
            Exit Sub
        End If
        txtCobrador.Text = FrmCob.DgCobrador.Item(FrmCob.DgCobrador.CurrentRowIndex, 0)
        lbCobrador.Text = FrmCob.DgCobrador.Item(FrmCob.DgCobrador.CurrentRowIndex, 1)

    End Sub

    Private Sub BtnBusDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusDoc.Click
  
        Dim codtipodoc, nrodoc, dstipodo As String
        Dim acuent, restop As Double
        Dim frmBusdoc As New frmBuscaDocumentoVenta
        frmBusdoc.dt_data = TABLE_DESPACHO
        frmBusdoc.ShowDialog()

        If frmBusdoc.Valor = False Then
            Exit Sub
        End If
        codtipodoc = frmBusdoc.griddata.Item(frmBusdoc.griddata.CurrentRowIndex, 2).ToString.Trim
        nrodoc = frmBusdoc.griddata.Item(frmBusdoc.griddata.CurrentRowIndex, 1).ToString.Trim
        dstipodo = frmBusdoc.griddata.Item(frmBusdoc.griddata.CurrentRowIndex, 3).ToString.Trim
        acuent = frmBusdoc.griddata.Item(frmBusdoc.griddata.CurrentRowIndex, 4).ToString.Trim
        restop = frmBusdoc.griddata.Item(frmBusdoc.griddata.CurrentRowIndex, 5).ToString.Trim




        EnviarDatos(codtipodoc, nrodoc, dstipodo, acuent, restop)


    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Dim frmr As New frmRptPlanOrdenD
        frmr.tipo = 3
        frmr.ShowDialog()
    End Sub

    Private Sub TxtAcuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAcuenta.TextChanged

    End Sub
End Class
