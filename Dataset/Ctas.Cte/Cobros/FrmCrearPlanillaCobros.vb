Public Class FrmCrearPlanillaCobros
    Inherits System.Windows.Forms.Form


    Dim obs2 As String = "*"


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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCobrador As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnCobrador As System.Windows.Forms.Button
    Friend WithEvents lbCobrador As System.Windows.Forms.Label
    Friend WithEvents dgDetalleCobros As System.Windows.Forms.DataGrid
    Friend WithEvents gPlanillaReparto As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents TablaEstilo As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents NUMDOC As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RAZONSOCIAL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents IMPORTE As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ACUENTA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SALDO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TIPODOC As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CODTIPDOC As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCobrado As System.Windows.Forms.Label
    Friend WithEvents txtNumPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnBuscaPlanilla As System.Windows.Forms.Button
    Friend WithEvents btnDoc As System.Windows.Forms.Button
    Friend WithEvents txtAcuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDsCliente As System.Windows.Forms.TextBox
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCompensar As System.Windows.Forms.Button
    Friend WithEvents txtSaldo As System.Windows.Forms.Label
    Friend WithEvents txtDeuda As System.Windows.Forms.TextBox
    Friend WithEvents LblCambio As System.Windows.Forms.Label
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GrpCabecera As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearPlanillaCobros))
        Me.gPlanillaReparto = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtDsCliente = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnDoc = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAcuenta = New System.Windows.Forms.TextBox
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.txtSaldo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDeuda = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTotalCobrado = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgDetalleCobros = New System.Windows.Forms.DataGrid
        Me.TablaEstilo = New System.Windows.Forms.DataGridTableStyle
        Me.CODTIPDOC = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TIPODOC = New System.Windows.Forms.DataGridTextBoxColumn
        Me.NUMDOC = New System.Windows.Forms.DataGridTextBoxColumn
        Me.RAZONSOCIAL = New System.Windows.Forms.DataGridTextBoxColumn
        Me.IMPORTE = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ACUENTA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SALDO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lbCobrador = New System.Windows.Forms.Label
        Me.txtCobrador = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpCabecera = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnCobrador = New System.Windows.Forms.Button
        Me.LblHora = New System.Windows.Forms.Label
        Me.LblFecha = New System.Windows.Forms.Label
        Me.LblCambio = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNumPlanilla = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnAnular = New System.Windows.Forms.Button
        Me.BtnConsultar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnCompensar = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnBuscaPlanilla = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.gPlanillaReparto.SuspendLayout()
        CType(Me.dgDetalleCobros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCabecera.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gPlanillaReparto
        '
        Me.gPlanillaReparto.Controls.Add(Me.TextBox1)
        Me.gPlanillaReparto.Controls.Add(Me.txtDsCliente)
        Me.gPlanillaReparto.Controls.Add(Me.Label11)
        Me.gPlanillaReparto.Controls.Add(Me.btnDoc)
        Me.gPlanillaReparto.Controls.Add(Me.Label9)
        Me.gPlanillaReparto.Controls.Add(Me.txtAcuenta)
        Me.gPlanillaReparto.Controls.Add(Me.txtNroDoc)
        Me.gPlanillaReparto.Controls.Add(Me.cbTipoDoc)
        Me.gPlanillaReparto.Controls.Add(Me.Label6)
        Me.gPlanillaReparto.Controls.Add(Me.Label4)
        Me.gPlanillaReparto.Controls.Add(Me.Label3)
        Me.gPlanillaReparto.Controls.Add(Me.btnQuitar)
        Me.gPlanillaReparto.Controls.Add(Me.btnAgregar)
        Me.gPlanillaReparto.Controls.Add(Me.txtSaldo)
        Me.gPlanillaReparto.Controls.Add(Me.Label7)
        Me.gPlanillaReparto.Controls.Add(Me.txtDeuda)
        Me.gPlanillaReparto.Controls.Add(Me.Label5)
        Me.gPlanillaReparto.Location = New System.Drawing.Point(6, 106)
        Me.gPlanillaReparto.Name = "gPlanillaReparto"
        Me.gPlanillaReparto.Size = New System.Drawing.Size(728, 114)
        Me.gPlanillaReparto.TabIndex = 2
        Me.gPlanillaReparto.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(624, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(82, 20)
        Me.TextBox1.TabIndex = 24
        Me.TextBox1.Text = "0.00"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDsCliente
        '
        Me.txtDsCliente.BackColor = System.Drawing.Color.White
        Me.txtDsCliente.Location = New System.Drawing.Point(84, 44)
        Me.txtDsCliente.Name = "txtDsCliente"
        Me.txtDsCliente.ReadOnly = True
        Me.txtDsCliente.Size = New System.Drawing.Size(298, 20)
        Me.txtDsCliente.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Cliente :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDoc
        '
        Me.btnDoc.ImageIndex = 5
        Me.btnDoc.ImageList = Me.ImageList1
        Me.btnDoc.Location = New System.Drawing.Point(396, 16)
        Me.btnDoc.Name = "btnDoc"
        Me.btnDoc.Size = New System.Drawing.Size(32, 23)
        Me.btnDoc.TabIndex = 20
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
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(10, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(696, 3)
        Me.Label9.TabIndex = 15
        '
        'txtAcuenta
        '
        Me.txtAcuenta.Location = New System.Drawing.Point(82, 72)
        Me.txtAcuenta.Name = "txtAcuenta"
        Me.txtAcuenta.Size = New System.Drawing.Size(80, 20)
        Me.txtAcuenta.TabIndex = 3
        Me.txtAcuenta.Text = "0.00"
        Me.txtAcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Enabled = False
        Me.txtNroDoc.Location = New System.Drawing.Point(296, 18)
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(96, 20)
        Me.txtNroDoc.TabIndex = 1
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.Location = New System.Drawing.Point(84, 18)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(144, 21)
        Me.cbTipoDoc.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pagar :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(242, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nro. Doc.:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Doc. :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(316, 74)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(92, 24)
        Me.btnQuitar.TabIndex = 18
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(198, 70)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(96, 28)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.Visible = False
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.White
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(510, 62)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(134, 30)
        Me.txtSaldo.TabIndex = 23
        Me.txtSaldo.Text = "0.00"
        Me.txtSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(454, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Saldo :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDeuda
        '
        Me.txtDeuda.BackColor = System.Drawing.Color.White
        Me.txtDeuda.Enabled = False
        Me.txtDeuda.Location = New System.Drawing.Point(522, 18)
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.ReadOnly = True
        Me.txtDeuda.Size = New System.Drawing.Size(82, 20)
        Me.txtDeuda.TabIndex = 1
        Me.txtDeuda.Text = "0.00"
        Me.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(446, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Monto Inicial  :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCobrado
        '
        Me.lblTotalCobrado.BackColor = System.Drawing.Color.White
        Me.lblTotalCobrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCobrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCobrado.Location = New System.Drawing.Point(602, 416)
        Me.lblTotalCobrado.Name = "lblTotalCobrado"
        Me.lblTotalCobrado.Size = New System.Drawing.Size(130, 28)
        Me.lblTotalCobrado.TabIndex = 18
        Me.lblTotalCobrado.Text = "0.00"
        Me.lblTotalCobrado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(490, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Total Cobranza: "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgDetalleCobros
        '
        Me.dgDetalleCobros.DataMember = ""
        Me.dgDetalleCobros.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetalleCobros.Location = New System.Drawing.Point(6, 224)
        Me.dgDetalleCobros.Name = "dgDetalleCobros"
        Me.dgDetalleCobros.ReadOnly = True
        Me.dgDetalleCobros.RowHeadersVisible = False
        Me.dgDetalleCobros.Size = New System.Drawing.Size(728, 188)
        Me.dgDetalleCobros.TabIndex = 16
        Me.dgDetalleCobros.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstilo})
        '
        'TablaEstilo
        '
        Me.TablaEstilo.DataGrid = Me.dgDetalleCobros
        Me.TablaEstilo.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODTIPDOC, Me.TIPODOC, Me.NUMDOC, Me.RAZONSOCIAL, Me.IMPORTE, Me.ACUENTA, Me.SALDO})
        Me.TablaEstilo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstilo.ReadOnly = True
        Me.TablaEstilo.RowHeadersVisible = False
        '
        'CODTIPDOC
        '
        Me.CODTIPDOC.Format = ""
        Me.CODTIPDOC.FormatInfo = Nothing
        Me.CODTIPDOC.Width = 0
        '
        'TIPODOC
        '
        Me.TIPODOC.Format = ""
        Me.TIPODOC.FormatInfo = Nothing
        Me.TIPODOC.HeaderText = "Tipo Doc."
        Me.TIPODOC.Width = 75
        '
        'NUMDOC
        '
        Me.NUMDOC.Format = ""
        Me.NUMDOC.FormatInfo = Nothing
        Me.NUMDOC.HeaderText = "Num.Doc."
        Me.NUMDOC.Width = 80
        '
        'RAZONSOCIAL
        '
        Me.RAZONSOCIAL.Format = ""
        Me.RAZONSOCIAL.FormatInfo = Nothing
        Me.RAZONSOCIAL.HeaderText = "Razon Social"
        Me.RAZONSOCIAL.Width = 250
        '
        'IMPORTE
        '
        Me.IMPORTE.Format = ""
        Me.IMPORTE.FormatInfo = Nothing
        Me.IMPORTE.HeaderText = "Importe"
        Me.IMPORTE.Width = 75
        '
        'ACUENTA
        '
        Me.ACUENTA.Format = ""
        Me.ACUENTA.FormatInfo = Nothing
        Me.ACUENTA.HeaderText = "Acuenta"
        Me.ACUENTA.Width = 75
        '
        'SALDO
        '
        Me.SALDO.Format = ""
        Me.SALDO.FormatInfo = Nothing
        Me.SALDO.HeaderText = "Saldo"
        Me.SALDO.Width = 75
        '
        'lbCobrador
        '
        Me.lbCobrador.BackColor = System.Drawing.Color.White
        Me.lbCobrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCobrador.Location = New System.Drawing.Point(76, 40)
        Me.lbCobrador.Name = "lbCobrador"
        Me.lbCobrador.Size = New System.Drawing.Size(296, 22)
        Me.lbCobrador.TabIndex = 18
        Me.lbCobrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCobrador
        '
        Me.txtCobrador.Location = New System.Drawing.Point(76, 16)
        Me.txtCobrador.Name = "txtCobrador"
        Me.txtCobrador.Size = New System.Drawing.Size(100, 20)
        Me.txtCobrador.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(284, 14)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-2, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CodCobrador :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrpCabecera
        '
        Me.GrpCabecera.Controls.Add(Me.Label13)
        Me.GrpCabecera.Controls.Add(Me.txtCobrador)
        Me.GrpCabecera.Controls.Add(Me.dtpFecha)
        Me.GrpCabecera.Controls.Add(Me.lbCobrador)
        Me.GrpCabecera.Controls.Add(Me.btnCobrador)
        Me.GrpCabecera.Controls.Add(Me.Label1)
        Me.GrpCabecera.Controls.Add(Me.LblHora)
        Me.GrpCabecera.Controls.Add(Me.LblFecha)
        Me.GrpCabecera.Controls.Add(Me.LblCambio)
        Me.GrpCabecera.Controls.Add(Me.Label2)
        Me.GrpCabecera.Controls.Add(Me.Label12)
        Me.GrpCabecera.Location = New System.Drawing.Point(116, 36)
        Me.GrpCabecera.Name = "GrpCabecera"
        Me.GrpCabecera.Size = New System.Drawing.Size(618, 70)
        Me.GrpCabecera.TabIndex = 0
        Me.GrpCabecera.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Moneda :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCobrador
        '
        Me.btnCobrador.ImageIndex = 5
        Me.btnCobrador.ImageList = Me.ImageList1
        Me.btnCobrador.Location = New System.Drawing.Point(178, 16)
        Me.btnCobrador.Name = "btnCobrador"
        Me.btnCobrador.Size = New System.Drawing.Size(28, 23)
        Me.btnCobrador.TabIndex = 17
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(506, 44)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(81, 16)
        Me.LblHora.TabIndex = 23
        Me.LblHora.Text = "11:58 a.m. "
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(426, 44)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(86, 16)
        Me.LblFecha.TabIndex = 22
        Me.LblFecha.Text = "30/07/2010 "
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambio.Location = New System.Drawing.Point(476, 16)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(76, 16)
        Me.LblCambio.TabIndex = 25
        Me.LblCambio.Text = "T.C. 2.800"
        Me.LblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Cobrador :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(214, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Num. Planilla :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumPlanilla
        '
        Me.txtNumPlanilla.Enabled = False
        Me.txtNumPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPlanilla.Location = New System.Drawing.Point(312, 8)
        Me.txtNumPlanilla.Name = "txtNumPlanilla"
        Me.txtNumPlanilla.Size = New System.Drawing.Size(170, 26)
        Me.txtNumPlanilla.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BtnImprimir)
        Me.GroupBox2.Controls.Add(Me.BtnCancelar)
        Me.GroupBox2.Controls.Add(Me.BtnAnular)
        Me.GroupBox2.Controls.Add(Me.BtnConsultar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnCompensar)
        Me.GroupBox2.Location = New System.Drawing.Point(744, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 235)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(6, 178)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(94, 30)
        Me.btnreporte.TabIndex = 24
        Me.btnreporte.TabStop = False
        Me.btnreporte.Text = "&Reporte"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.ImageIndex = 11
        Me.BtnImprimir.ImageList = Me.ImageList1
        Me.BtnImprimir.Location = New System.Drawing.Point(138, 134)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(98, 28)
        Me.BtnImprimir.TabIndex = 23
        Me.BtnImprimir.Text = "Imprimir Cobranza"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(4, 116)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 28)
        Me.BtnCancelar.TabIndex = 22
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAnular
        '
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.ImageIndex = 3
        Me.BtnAnular.ImageList = Me.ImageList1
        Me.BtnAnular.Location = New System.Drawing.Point(144, 106)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(98, 28)
        Me.BtnAnular.TabIndex = 21
        Me.BtnAnular.Text = "Anular"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.ImageIndex = 4
        Me.BtnConsultar.ImageList = Me.ImageList1
        Me.BtnConsultar.Location = New System.Drawing.Point(4, 78)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(98, 28)
        Me.BtnConsultar.TabIndex = 20
        Me.BtnConsultar.Text = "Consultar"
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.ImageIndex = 0
        Me.btnNuevo.ImageList = Me.ImageList1
        Me.btnNuevo.Location = New System.Drawing.Point(4, 14)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 28)
        Me.btnNuevo.TabIndex = 19
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnSalir
        '
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.ImageIndex = 12
        Me.btnSalir.ImageList = Me.ImageList1
        Me.btnSalir.Location = New System.Drawing.Point(4, 144)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 28)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        '
        'btnCompensar
        '
        Me.btnCompensar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompensar.ImageIndex = 1
        Me.btnCompensar.ImageList = Me.ImageList1
        Me.btnCompensar.Location = New System.Drawing.Point(4, 42)
        Me.btnCompensar.Name = "btnCompensar"
        Me.btnCompensar.Size = New System.Drawing.Size(98, 28)
        Me.btnCompensar.TabIndex = 19
        Me.btnCompensar.Text = "Cobrar"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(118, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(174, 38)
        Me.LblTitulo.TabIndex = 24
        Me.LblTitulo.Text = "NUEVA PLANILLA DE COBRO"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblTitulo.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnBuscaPlanilla
        '
        Me.btnBuscaPlanilla.Enabled = False
        Me.btnBuscaPlanilla.ImageIndex = 5
        Me.btnBuscaPlanilla.ImageList = Me.ImageList1
        Me.btnBuscaPlanilla.Location = New System.Drawing.Point(484, 8)
        Me.btnBuscaPlanilla.Name = "btnBuscaPlanilla"
        Me.btnBuscaPlanilla.Size = New System.Drawing.Size(34, 26)
        Me.btnBuscaPlanilla.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(727, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 26)
        Me.TextBox2.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(903, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 26)
        Me.Button1.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(646, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "NroPreplanilla :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmCrearPlanillaCobros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1027, 539)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.GrpCabecera)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gPlanillaReparto)
        Me.Controls.Add(Me.btnBuscaPlanilla)
        Me.Controls.Add(Me.txtNumPlanilla)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgDetalleCobros)
        Me.Controls.Add(Me.lblTotalCobrado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCrearPlanillaCobros"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea Planilla Cobros"
        Me.gPlanillaReparto.ResumeLayout(False)
        Me.gPlanillaReparto.PerformLayout()
        CType(Me.dgDetalleCobros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCabecera.ResumeLayout(False)
        Me.GrpCabecera.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Fields"
    'Private Obj As New ClsInterface
    Private TablaDatos As New DataTable
    Public FormRetorno As Boolean = False
    Private TAB_DETALLE As New DataTable
    Private EstadoCobro As String = ""
    Private ModifItem As Boolean



#End Region

#Region "Funciones"

    Private Sub BuscarCobranzaC()
        Dim TAB_COBRANZAC As New DataTable
        TAB_COBRANZAC = TmpListarDatos("PLANILLA_COBRANZACselecxProc  '" & codempresa & "','" & txtNumPlanilla.Text.Trim & "'")
        txtCobrador.Text = TAB_COBRANZAC.Rows(0)("CDCOBRADOR")
        lbCobrador.Text = TAB_COBRANZAC.Rows(0)("NOMCOBRADOR").ToString
        dtpFecha.Value = Format(CDate(TAB_COBRANZAC.Rows(0)("FECHA")), "dd/MM/yyyy")
    End Sub


    Private Sub BuscarCobranzaC_1()
        Dim TAB_COBRANZAC As New DataTable
        TAB_COBRANZAC = TmpListarDatos("PLANILLA_COBRANZACselecxProc_1  '" & codempresa & "','" & TextBox2.Text.Trim & "'")
        txtCobrador.Text = TAB_COBRANZAC.Rows(0)("CDCOBRADOR")
        lbCobrador.Text = TAB_COBRANZAC.Rows(0)("NOMCOBRADOR").ToString
        dtpFecha.Value = Format(CDate(TAB_COBRANZAC.Rows(0)("FECHA")), "dd/MM/yyyy")
    End Sub


    Private Sub BuscarCobranzaD_1()
        TmpInsertDatos("TMP_PLANILLA_VTAXCOBRAR_NuevoProc_1  '" & codempresa & "','" & TextBox2.Text & "','" & VCorrelVta & "'")
        CargarGridDet()
        FormatoGridDet()
    End Sub



    Private Sub BuscarCobranzaD()
        TmpInsertDatos("TMP_PLANILLA_VTAXCOBRAR_NuevoProc  '" & codempresa & "','" & txtNumPlanilla.Text & "','" & VCorrelVta & "'")
        CargarGridDet()
        FormatoGridDet()

    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.F3
                    If TAB_DETALLE.Rows.Count > 0 Then
                        If dgDetalleCobros.Focus = True Then
                            Dim sender As Object = Nothing
                            Dim e As EventArgs = Nothing
                            btnQuitar_Click(sender, e)
                        End If
                    End If
                Case Keys.Enter


                    If TAB_DETALLE.Rows.Count > 0 Then
                        If dgDetalleCobros.Focus = True Then
                            If dgDetalleCobros.CurrentCell.ColumnNumber = 1 Then
                                If dgDetalleCobros.CurrentRowIndex > -1 Then
                                    cbTipoDoc.SelectedValue = dgDetalleCobros.Item(dgDetalleCobros.CurrentRowIndex, 0)
                                    txtNroDoc.Text = dgDetalleCobros.Item(dgDetalleCobros.CurrentRowIndex, 2)
                                    txtDsCliente.Text = dgDetalleCobros.Item(dgDetalleCobros.CurrentRowIndex, 4)
                                    txtDeuda.Text = dgDetalleCobros.Item(dgDetalleCobros.CurrentRowIndex, 6)
                                    txtSaldo.Text = dgDetalleCobros.Item(dgDetalleCobros.CurrentRowIndex, 7)
                                    txtAcuenta.Text = dgDetalleCobros.Item(dgDetalleCobros.CurrentRowIndex, 8)
                                    ModifItem = True
                                End If
                            End If

                        End If
                    End If
            End Select
        End If
    End Function

    Private Sub LimpiarDatos()
        txtCobrador.Text = ""
        lbCobrador.Text = ""
        dtpFecha.Value = Date.Now
        cbTipoDoc.SelectedValue = ""
        txtNroDoc.Text = ""
        txtDsCliente.Text = ""
        txtDeuda.Text = "0.00"
        txtSaldo.Text = "0.00"
        txtAcuenta.Text = "0.00"
        EstadoCobro = ""
        LblTitulo.Visible = False
        VClieDep = ""
        GrpCabecera.Enabled = False
        btnBuscaPlanilla.Enabled = False

        Button1.Enabled = False
        TextBox2.Enabled = False


    End Sub

    Private Sub CargarGridDet()
        TAB_DETALLE = TmpListarDatos("SELECTMP_PLANILLA_VTAXCOBRAR   '" & codempresa & "','" & VCorrelVta & "'")
        dgDetalleCobros.DataSource = TAB_DETALLE
        lblTotalCobrado.Text = FormatoMonto(CDbl(TmpListarDatos("SELECT   ISNULL(SUM(PAGCREDBAS),0.00) AS PAGCREDBAS  FROM   TMP_PLANILLA_VTAXCOBRAR    WHERE CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "' ").Rows(0)("PAGCREDBAS")), DECIRESU)
    End Sub


    Private Sub FormatoGridDet()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_DETALLE.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODTIPODOC"
            .HeaderText = "CODTIPODOC"
            .NullText = ""
            .Width = 0
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DSABRV"
            .HeaderText = "TIPODOC"
            .NullText = ""
            .Width = 25
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "NRODOCU"
            .HeaderText = "NRODOCU"
            .NullText = ""
            .Width = 75
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "CODCLIENTE"
            .HeaderText = "CODCLIENTE"
            .NullText = ""
            .Width = 75
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "DESCLIENTE"
            .HeaderText = "DESCLIENTE"
            .NullText = ""
            .Width = 200
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "FECDOCUM"
            .HeaderText = "FECHA"
            .NullText = ""
            .Format = "dd/MM/yyyy"
            .Width = 75
        End With
        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "TOTCREDBAS"
            .HeaderText = "MONTO INICIAL"
            .Format = GMascaraDec(DECIRESU)
            .NullText = "0.00"
            .Alignment = HorizontalAlignment.Right
            .Width = 75
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "SALDOBAS"
            .HeaderText = "SALDO"
            .Format = GMascaraDec(DECIRESU)
            .Alignment = HorizontalAlignment.Right
            .NullText = "0.00"
            .Width = 75
        End With
        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "PAGCREDBAS"
            .HeaderText = "PAGO"
            .Format = GMascaraDec(DECIRESU)
            .Alignment = HorizontalAlignment.Right
            .NullText = "0.00"
            .Width = 75
        End With
        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "CODDEP"
            .HeaderText = "CODDEP"
            .NullText = ""
            .Width = 0
        End With
        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "ESTADO"
            .HeaderText = "ESTADO"
            .NullText = ""
            .Width = 75
        End With
        dgDetalleCobros.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11})
        dgDetalleCobros.TableStyles.Add(TableStyle1)

    End Sub


#End Region


    Private Sub btnCobrador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrador.Click
        'Dim FRMX As New FRM_GRIDVEND
        'FRMX.vie4 = Me
        'FRMX.bol = True
        'FRMX.ShowDialog()
        ''TraerPlanilla()
        Dim FrmCob As New FrmBuscCobrador
        FrmCob.ShowDialog()
        If FrmCob.DEVOLVER = False Then
            Exit Sub
        End If
        txtCobrador.Text = FrmCob.DgCobrador.Item(FrmCob.DgCobrador.CurrentRowIndex, 0)
        lbCobrador.Text = FrmCob.DgCobrador.Item(FrmCob.DgCobrador.CurrentRowIndex, 1)


    End Sub

    Private Sub FrmCrearPlanillaReparto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombo()
        LblCambio.Text = "T.C." & VCambioVta & " "
        BtnCancelar_Click(sender, e)
        Me.txtNumPlanilla.Focus()


        Call BOTONES(True, False, True, False, False)
        HABILTAR(False)

        Me.dtpFecha.Value = Format(vFechaActual, "dd/MM/yyyy")

        Me.LblFecha.Text = Format(vFechaActual, "dd/MM/yyyy")

    End Sub




    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal BUSCAR1 As Boolean, ByVal BUSCAR2 As Boolean, ByVal BUSCAR3 As Boolean)

        BTNNUEVO.Enabled = NUEVO
        btnCompensar.Enabled = GUARDAR
        BtnConsultar.Enabled = BUSCAR1

        btnCobrador.Enabled = BUSCAR2
        btnDoc.Enabled = BUSCAR3

    End Sub



    Private Sub CargaCombo()
        'Conecta("SELECT T.[CODTIPODOC], T.[DSTIPODOC] FROM TIPODOC T WHERE T.[CODEMPRESA]='" & codempresa & "'", "d")
        'Dim TablaTemp As New DataTable
        'TablaTemp = ds.Tables("d")
        'Me.cbTipoDoc.DisplayMember = "DSTIPODOC"
        'Me.cbTipoDoc.ValueMember = "CODTIPODOC"
        'Me.cbTipoDoc.DataSource = TablaTemp


       
        CAyuda.CargarDataCombo(cbTipoDoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")


    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        'TraerPlanilla()
    End Sub

    Public Sub TraerPlanilla()
        'Dim TablaTemp As New DataTable
        TablaDatos = CAyuda.ListarDatos("NSP_LISTAR_PLANILLA_COBROS", txtNumPlanilla.Text.Trim, codempresa).Tables(0)
        AsignaGrid()
        If TablaDatos.Rows.Count > 0 Then
            cbTipoDoc.Enabled = False : txtNroDoc.Enabled = False : txtAcuenta.Enabled = False
            Me.btnCompensar.Enabled = False ': Me.btnGuardar.Enabled = False
        End If
    End Sub

    Private Sub ActionNew()
        desbloqueatextbox(Me)
        'Limpiatextbox(Me)
        Me.txtNroDoc.Text = String.Empty
        Me.txtAcuenta.Text = String.Empty
        Dim vObject As New Object
        For Each vObject In gPlanillaReparto.Controls
            If TypeOf vObject Is Label Then
                If vObject.BorderStyle = BorderStyle.FixedSingle Then
                    vObject.Text = String.Empty
                End If
            End If
        Next
        AsignaGrid()
        'Me.txtDeuda.ReadOnly = True
        'Me.txtSaldo.ReadOnly = True
        cbTipoDoc.Enabled = True : txtNroDoc.Enabled = True : txtAcuenta.Enabled = True
        Me.btnCompensar.Enabled = False ': Me.btnGuardar.Enabled = True
        txtNroDoc.Focus()
    End Sub
    Private Sub ActionModify()
        AsignaGrid()
        Conecta("SELECT * FROM DOC_COMPENSA_PLANILLA_COBROS WHERE FECHA_TEMP='" & dtpFecha.Value.ToShortDateString & "' AND CDVENDED='" & txtCobrador.Text.Trim & "'", "DD")
        If ds.Tables("DD").Rows.Count > 0 Then
            cbTipoDoc.Enabled = False : txtNroDoc.Enabled = False : txtAcuenta.Enabled = False
            Me.btnCompensar.Enabled = False ': Me.btnGuardar.Enabled = False
        Else
            cbTipoDoc.Enabled = True : txtNroDoc.Enabled = True : txtAcuenta.Enabled = True
            Me.btnCompensar.Enabled = True ': Me.btnGuardar.Enabled = True
        End If

    End Sub

    Private Sub AsignaGrid()
        'TablaEstilo.MappingName = TablaDatos.TableName
        TablaEstilo.GridColumnStyles(0).MappingName = "TIPODOC"
        TablaEstilo.GridColumnStyles(1).MappingName = "DSTIPODOC"
        TablaEstilo.GridColumnStyles(2).MappingName = "NRODOC"
        TablaEstilo.GridColumnStyles(3).MappingName = "CLIENTE"
        TablaEstilo.GridColumnStyles(4).MappingName = "DEUDA"
        TablaEstilo.GridColumnStyles(5).MappingName = "ACUENTA"
        TablaEstilo.GridColumnStyles(6).MappingName = "SALDO"
        dgDetalleCobros.TableStyles.Add(TablaEstilo)
        dgDetalleCobros.DataSource = TablaDatos
        lblTotalCobrado.Text = CalcularTotalCobrado()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If txtNroDoc.Text = "" Then
            MsgBox("FALTA INGRESAR EL NUMERO DE DOCUMENTO..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If IsNothing(cbTipoDoc.SelectedValue) = True Then
            MsgBox("FALTA INDICAR EL TIPO DE DOCUMENTO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        If TextBox1.Text = "0.00" Then
            MsgBox("EL TIPO PAGO NO DEBE 0.00 SELECCIONE EL DOCUMENTO DENUEVO", MsgBoxStyle.Exclamation, "")
            TextBox1.Focus()
            Exit Sub
        End If

        If txtAcuenta.Text = "" Then
            txtAcuenta.Text = "0.00"
        End If


        If CDbl(txtAcuenta.Text) > CDbl(txtSaldo.Text) Then
            MsgBox("EL PAGO NO DEBE SER MAYOR AL SALDO", MsgBoxStyle.Exclamation, "")
            txtAcuenta.Focus()
            Exit Sub
        End If






        If ModifItem = False Then
            If TmpInsertDatos("SP_INSTMP_PLANILLA_VTAXCOBRAR   '" & codempresa & "','" & VCorrelVta & "','" & cbTipoDoc.SelectedValue & "','" & txtNroDoc.Text & "','" & VClieDep & "','" & txtDsCliente.Text & "','" & Format(CDate(dtpFecha.Value), "dd/MM/yyyy") & "','" & CDMONBASE & "','" & CDbl(txtDeuda.Text) & "','" & CDbl(txtDeuda.Text) / VCambioVta & "','" & CDbl(txtSaldo.Text) & "','" & CDbl(txtSaldo.Text) / VCambioVta & "','" & CDbl(txtAcuenta.Text) & "' ,'" & CDbl(txtAcuenta.Text) / VCambioVta & "', '" & VCodCliente & "','" & TextBox1.Text & "'") Then
                CargarGridDet()
                FormatoGridDet()
                txtNroDoc.Text = ""
                txtDeuda.Text = "0.00"
                txtSaldo.Text = "0.00"
                txtDsCliente.Text = ""
                txtAcuenta.Text = "0.00"
                txtNroDoc.Focus()
            End If
        Else
            If TmpInsertDatos("SP_UPDATETMP_PLANILLA_VTAXCOBRAR  '" & codempresa & "' ,'" & VCorrelVta & "','" & cbTipoDoc.SelectedValue & "','" & txtNroDoc.Text & "','" & CDbl(txtSaldo.Text) & "','" & CDbl(txtAcuenta.Text) & "','" & CDbl(txtAcuenta.Text) / VCambioVta & "' ") Then
                CargarGridDet()
                FormatoGridDet()
                txtNroDoc.Text = ""
                txtDeuda.Text = "0.00"
                txtSaldo.Text = "0.00"
                txtDsCliente.Text = ""
                txtAcuenta.Text = "0.00"
                txtNroDoc.Focus()
            End If
        End If



        'ActionAdd()
    End Sub

    Private Sub ActionAdd()
        If Me.txtSaldo.Text.Trim.Length = 0 Then
            MsgBox("No hay datos para agregar", MsgBoxStyle.Information)
            Exit Sub
        End If
        If CDbl(txtSaldo.Text.Trim) = 0 Then
            MsgBox("ESTE DOCUMENTO YA ESTÁ CANCELADO NO SE PUEDE AGREGAR", MsgBoxStyle.Information)
            Exit Sub
        End If
        For contA As Integer = 0 To TablaDatos.Rows.Count - 1
            If TablaDatos.Rows(contA)("TIPODOC").ToString.Trim = Me.cbTipoDoc.SelectedValue.ToString.Trim And TablaDatos.Rows(contA)("NRODOC").ToString.Trim = txtNroDoc.Text.Trim Then
                MsgBox("YA SE HA INGRESADO UNA OPERACIÓN PARA ESTE DOCUMENTO EN ESTA PLANILLA.", MsgBoxStyle.Information)
                LimparDetalleCobro()
                Exit Sub
            End If
        Next
        Dim filaR As DataRow = TablaDatos.NewRow
        filaR(0) = Me.cbTipoDoc.SelectedValue.ToString.Trim
        filaR(1) = Me.cbTipoDoc.Text.Trim
        filaR(2) = Me.txtNroDoc.Text.Trim
        filaR(3) = Me.txtDsCliente.Text.Trim
        filaR(4) = Me.txtDeuda.Text.Trim
        filaR(5) = Me.txtAcuenta.Text.Trim
        filaR(6) = CDbl(Me.txtSaldo.Text.Trim) - CDbl(Me.txtAcuenta.Text.Trim)
        TablaDatos.Rows.Add(filaR)
        TablaDatos.AcceptChanges()
        Me.dgDetalleCobros.DataSource = TablaDatos
        LimparDetalleCobro()
        lblTotalCobrado.Text = CalcularTotalCobrado()
    End Sub
    Private Function CalcularTotalCobrado() As Double
        For ContA As Integer = 0 To TablaDatos.Rows.Count - 1
            CalcularTotalCobrado += CDbl(TablaDatos.Rows(ContA)("ACUENTA"))
        Next
    End Function
    Private Sub LimparDetalleCobro()
        Me.txtNroDoc.Text = String.Empty : Me.txtDeuda.Text = String.Empty
        Me.txtAcuenta.Text = String.Empty : Me.txtSaldo.Text = String.Empty
        Me.txtDsCliente.Text = String.Empty
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If TmpInsertDatos("SP_ELITMP_PLANILLA_VTAXCOBRAR   '" & codempresa & "','" & VCorrelVta & "','" & dgDetalleCobros.Item(dgDetalleCobros.CurrentRowIndex, 0) & "' , '" & dgDetalleCobros.Item(dgDetalleCobros.CurrentRowIndex, 2) & "'") = True Then
            CargarGridDet()
            FormatoGridDet()
            txtNroDoc.Text = ""
            txtDeuda.Text = "0.00"
            txtSaldo.Text = "0.00"
            txtDsCliente.Text = ""
            txtAcuenta.Text = "0.00"
            txtNroDoc.Focus()

        End If
    End Sub

    Private Sub txtCobrador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCobrador.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TraerPlanilla()
        End If
    End Sub

    Private Sub txtAcuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            ActionAdd()
        End If
    End Sub



#Region "RESTRICCIONES-KEYPRESS"

    Private Sub CajaTexto_SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAcuenta.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

#End Region


    Private Sub txtNroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim VarCliente As String = String.Empty

            Try
                Dim TablaTemp As New DataTable
                TablaTemp = CAyuda.ListarDatos("NSP_TRAER_CLIENTE_VTA_COBRAR", codempresa, Me.cbTipoDoc.SelectedValue.ToString.Trim, txtNroDoc.Text.Trim).Tables(0)
                'VarCliente = TablaTemp.Rows(0)(0)
                'txtDsCliente.Text = VarCliente : txtDeuda.Text = TablaTemp.Rows(0)("TOTCREDBAS")
                'txtSaldo.Text = CDbl(TablaTemp.Rows(0)("TOTCREDBAS")) - CDbl(TablaTemp.Rows(0)("PAGCREDBAS"))
                'txtAcuenta.Focus()

                txtNroDoc.Text = TablaTemp.Rows(0)("NRODOCU")
                VCodCliente = TablaTemp.Rows(0)("CDCLIENTE")
                VClieDep = TablaTemp.Rows(0)("CDCLIENTEDEP")
                txtDsCliente.Text = TablaTemp.Rows(0)("DATOADJUNTO")
                txtDeuda.Text = CDbl(TablaTemp.Rows(0)("TOTCREDBAS"))
                txtSaldo.Text = CDbl(TablaTemp.Rows(0)("SALDO"))
                txtAcuenta.Text = txtSaldo.Text
                TextBox1.Text = TablaTemp.Rows(0)("CODTIPOPAGO")

                txtAcuenta.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnCompensar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompensar.Click

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

        If CDbl(lblTotalCobrado.Text) = 0 Then
            MsgBox("NO HAY MONTO A CONPENSAR...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        If txtCobrador.Text.Trim = "" Then
            MsgBox("FALTA INDICAR EL COBRADOR...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If







        Dim BusqCobrar As DataTable
        BusqCobrar = TmpListarDatos("SP_BUSQVTAXCOBRAR   '" & VCorrelVta & "'")

        For x As Integer = 0 To BusqCobrar.Rows.Count - 1

            Dim BusqTablaDoc As DataTable
            BusqTablaDoc = TmpListarDatos("SP_BUSCAR_PLANDOC   '" & codempresa & "','" & VCorrelVta & "','" & BusqCobrar.Rows(x)(0).ToString & "','" & BusqCobrar.Rows(x)(1).ToString & "'")

            If BusqTablaDoc.Rows.Count = 0 Then

                obs2 = obs2 + vbCrLf + " NroDoc : " & BusqCobrar.Rows(x)(0).ToString & " TipoDoc : " & BusqCobrar.Rows(x)(2).ToString

            End If
        Next

        If obs2.Trim.Length = 1 Then

        Else
            MsgBox(obs2, MsgBoxStyle.Information, "No tiene Planilla Orden de Depacho o Orden de Venta")
            Exit Sub
        End If

        Dim FrmComp As New FrmCompensar
        FrmComp.lbNumPlanilla.Text = txtNumPlanilla.Text
        FrmComp.lblMontoCompensar.Text = CDbl(lblTotalCobrado.Text)
        FrmComp.ShowDialog()
        If FrmComp.DEVOLVER = False Then
            Exit Sub
        End If

        For ContA As Integer = 0 To FrmComp.TablaTemp.Rows.Count - 1
            CAyuda.Ejecutar("NSP_INSERT_DOC_COMP_PCOBROS", txtNumPlanilla.Text, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, txtCobrador.Text, CDbl(lblTotalCobrado.Text.Trim), FrmComp.TablaTemp.Rows(ContA)("TIPO").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim)

            If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, 1, FrmComp.TablaTemp.Rows(ContA)("TIPOC").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, "", CodUsuario.Trim, FrmComp.TablaTemp.Rows(ContA)("CUENTAC").ToString.Trim, "", "", "", "", FrmComp.TablaTemp.Rows(ContA)("BServi").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("PTributario").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("RucADQ").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("RucProve").ToString.Trim) <> 0 Then

            End If
        Next






        If TmpInsertDatos("SP_INSPLANILLA_VTAXCOBRAR   '" & codempresa & "','" & txtCobrador.Text & "','" & CDMONBASE & "','" & Format(CDate(dtpFecha.Value), "dd/MM/yyyy") & "','" & CDbl(lblTotalCobrado.Text) & "','" & CDbl(lblTotalCobrado.Text) / VCambioVta & "','" & CodUsuario & "','" & VCambioVta & "','" & EstadoCobro & "','','" & VCorrelVta & "','" & txtNumPlanilla.Text & "','" & "004" & "'") = True Then

            If TextBox2.Text.Length = 0 Then
            Else
                If TmpInsertDatos("nsp_busc_preplan   '" & codempresa & "','" & TextBox2.Text & "','" & txtNumPlanilla.Text & "'") = True Then
                End If

            End If

            MsgBox("SE GRABO LA PLANILLA DE COBRANZA" & vbNewLine & "NRO" & txtNumPlanilla.Text)
            TmpInsertDatos("DELETE  FROM TMP_PLANILLA_VTAXCOBRAR    WHERE CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
            CargarGridDet()
            FormatoGridDet()
            LimpiarDatos()

            If TmpInsertDatos("NSP_AUMENTAR_CORREL_PLANILLA   '" & NROPTOVTA & "','" & codempresa & "','04','" & txtNumPlanilla.Text & "'") = True Then
            End If
        End If

        Call BOTONES(True, False, True, False, False)
        HABILTAR(False)



    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub txtAcuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcuenta.TextChanged

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        txtNumPlanilla.Text = TmpListarDatos("SELECT nroplanilla04 FROM PTOVTA  WHERE CODEMPRESA='" & codempresa & "' and NROPTOVTA ='" & NROPTOVTA & "'").Rows(0)("nroplanilla04")


        cbTipoDoc.Enabled = True : txtNroDoc.Enabled = True : txtAcuenta.Enabled = True
        Me.btnCompensar.Enabled = True ': Me.btnGuardar.Enabled = True
        Me.txtCobrador.Text = String.Empty : Me.txtDeuda.Text = String.Empty : Me.txtDsCliente.Text = String.Empty
        txtAcuenta.Text = String.Empty : txtSaldo.Text = String.Empty : lbCobrador.Text = String.Empty
        TraerPlanilla()
        Me.txtCobrador.Focus()
        BtnCancelar_Click(sender, e)
        LblTitulo.Visible = True
        GrpCabecera.Enabled = True

        Button1.Enabled = True
        TextBox2.Enabled = True

        Call BOTONES(False, True, False, True, True)
        HABILTAR(True)

        '  txtNroDoc.Enabled = False

    End Sub

    Sub HABILTAR(ByVal ESTADO As Boolean)

        cbTipoDoc.Enabled = ESTADO
        txtNroDoc.Enabled = ESTADO
        txtAcuenta.Enabled = ESTADO
    End Sub



    Private Sub btnBuscaPlanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPlanilla.Click
        Dim FrmBusc As New FrmBuscPlanillaCobranza
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        If CStr(FrmBusc.DgPlanilla.Item(FrmBusc.DgPlanilla.CurrentRowIndex, 5)) = "A" Then
            MsgBox("LA PLANILLA ESTA ANULADA..!", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        txtNumPlanilla.Text = FrmBusc.DgPlanilla.Item(FrmBusc.DgPlanilla.CurrentRowIndex, 0)
        BuscarCobranzaC()
        BuscarCobranzaD()


    End Sub

    Private Sub TraerDatos()
        Conecta("SELECT * FROM TMP_PLANILLA_COBROS WHERE NUMPLANILLA =" & txtNumPlanilla.Text.Trim & "  AND CODEMPRESA = '" & codempresa.Trim & "'", "DD2")
        If ds.Tables("DD2").Rows.Count > 0 Then
            Me.dtpFecha.Value = ds.Tables("DD2").Rows(0)("FECHA_TEMP")
            Me.txtCobrador.Text = ds.Tables("DD2").Rows(0)("CDVENDED")
            Conecta("SELECT DSVEND FROM VENDEDOR WHERE CODVEND='" & txtCobrador.Text.Trim & "' AND CODEMPRESA='" & codempresa.Trim & "'", "DD3")
            If ds.Tables("DD3").Rows.Count > 0 Then
                Me.lbCobrador.Text = ds.Tables("DD3").Rows(0)(0)
            End If
            TraerPlanilla()
        End If
    End Sub

    Private Sub gPlanillaReparto_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gPlanillaReparto.Enter

    End Sub

    Private Sub btnDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoc.Click

        If txtCobrador.Text.Trim = "" Then
            MsgBox("FALTA INDICAR EL COBRADOR...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If IsNothing(cbTipoDoc.SelectedValue) = True Then
            MsgBox("FALTA INDICAR EL TIPO DE DOCUMENTO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim FrmBus As New FrmBuscarDocVentas
        FrmBus.DATACODTIPODOC = cbTipoDoc.SelectedValue.ToString.Trim
        FrmBus.ShowDialog()
        If FrmBus.DEVOLVER = False Then
            Exit Sub
        End If
        ModifItem = False
        txtNroDoc.Text = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 2)
        VCodCliente = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 3)
        VClieDep = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 8)
        txtDsCliente.Text = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 4)
        txtDeuda.Text = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 5)
        txtSaldo.Text = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 7)
        txtAcuenta.Text = txtSaldo.Text
        TextBox1.Text = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 9)




        txtAcuenta.Focus()




    End Sub

    Private Sub dgDetalleCobros_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetalleCobros.DoubleClick

    End Sub

    Private Sub txtNroDoc_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNroDoc.RightToLeftChanged

    End Sub

    Private Sub txtNroDoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDoc.TextChanged
        If txtNroDoc.Text.Trim = "" Then
            cbTipoDoc.Enabled = True
        Else
            cbTipoDoc.Enabled = False
        End If


    End Sub

    Private Sub txtAcuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAcuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            'ActionAdd()
            btnAgregar_Click(sender, e)

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblFecha.Text = Format(CDate(Date.Now), "dd/MM/yyyy") & " "
        LblHora.Text = Format(CDate(Date.Now), "hh:mm:ss tt") & " "
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If TAB_DETALLE.Rows.Count > 0 Then
            If MsgBox("DESEA CANCELAR LA OPERACION ...", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        TmpInsertDatos("DELETE  FROM TMP_PLANILLA_VTAXCOBRAR    WHERE CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
        CargarGridDet()
        FormatoGridDet()
        LimpiarDatos()

        Call BOTONES(True, False, True, False, False)

        HABILTAR(False)

    End Sub

    Private Sub txtAcuenta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcuenta.Leave
        If txtAcuenta.Text = "" Then
            txtAcuenta.Text = "0.00"
        End If
    End Sub

    Private Sub txtAcuenta_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAcuenta.MouseLeave
        If txtAcuenta.Text = "" Then
            txtAcuenta.Text = "0.00"
        End If
    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        If TAB_DETALLE.Rows.Count > 0 Then
            If MsgBox("TIENE UNA OPERACION PENDIENTE .DESEA CANCELAR LA OPERACION DE TODAS MANERAS...", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        TmpInsertDatos("DELETE  FROM TMP_PLANILLA_VTAXCOBRAR    WHERE CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
        CargarGridDet()
        FormatoGridDet()
        LimpiarDatos()
        btnBuscaPlanilla.Enabled = True
        txtNumPlanilla.Enabled = True


    End Sub

    Private Sub txtNumPlanilla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumPlanilla.TextChanged

    End Sub

    Private Sub txtNumPlanilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumPlanilla.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtNumPlanilla.Text.Trim.Length > 0 Then
                BuscarCobranzaC()
                BuscarCobranzaD()
            End If
        End If
    End Sub

    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click
        If txtNumPlanilla.Enabled = True Then
            If MsgBox("ESTA SEGURO DE ANULAR LA PLANILLA DE COBRANZA.!", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If TmpInsertDatos("AnulaPLANILLA_COBRANZAxProc  '" & codempresa & "','" & txtNumPlanilla.Text.Trim & "'") = True Then
                    MsgBox("LA ANULACION SE REALIZO CORRECTAMENTE", MsgBoxStyle.Information, "")
                    TmpInsertDatos("DELETE  FROM TMP_PLANILLA_VTAXCOBRAR    WHERE CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
                    CargarGridDet()
                    FormatoGridDet()
                    LimpiarDatos()
                End If
            End If
        End If
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click

        Dim frmr As New frmRptPlanOrdenD
        frmr.tipo = 4
        frmr.ShowDialog()


    End Sub

    Private Sub dgDetalleCobros_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgDetalleCobros.Navigate

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FrmBusc As New FrmBuscPlanillaCobranza2
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        If CStr(FrmBusc.DgPlanilla.Item(FrmBusc.DgPlanilla.CurrentRowIndex, 5)) = "A" Then
            MsgBox("LA PLANILLA ESTA ANULADA..!", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        TextBox2.Text = FrmBusc.DgPlanilla.Item(FrmBusc.DgPlanilla.CurrentRowIndex, 0)
        BuscarCobranzaC_1()
        BuscarCobranzaD_1()
    End Sub

    Private Sub txtDsCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDsCliente.TextChanged

    End Sub

    Private Sub txtDeuda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeuda.TextChanged

    End Sub
End Class
