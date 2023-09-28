<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanillaDescOrden
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillaDescOrden))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblTotalAcuenta = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAGregarOD = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtOrderDesp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BtnConsult = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GrpCabecera = New System.Windows.Forms.GroupBox()
        Me.LBLSIMBOLOCAMBIO = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCobrador = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lbCobrador = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRestante = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblRuc = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblRazonSoc = New System.Windows.Forms.Label()
        Me.BtnBusDoc = New System.Windows.Forms.Button()
        Me.LblNroDoc = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblFechaDoc = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblDsTipoDoc = New System.Windows.Forms.Label()
        Me.dgvdetalle = New System.Windows.Forms.DataGridView()
        Me.FECDOCUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPODOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NRODOCUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCLIENTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTCREDBASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTCREDEXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGCREDBASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGCREDEXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDOBASDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDOEXTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIDEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCUENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanillaOrdenDetEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNumPlanilla = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LblTotalDescAutorizado = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LblDiferencia = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCabecera.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaOrdenDetEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(177, 4)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(514, 38)
        Me.LblTitulo.TabIndex = 48
        Me.LblTitulo.Text = "PLANILLA DE DESCUENTO DE ORDEN DE DESPACHO"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTotalAcuenta
        '
        Me.LblTotalAcuenta.BackColor = System.Drawing.Color.White
        Me.LblTotalAcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalAcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAcuenta.Location = New System.Drawing.Point(728, 477)
        Me.LblTotalAcuenta.Name = "LblTotalAcuenta"
        Me.LblTotalAcuenta.Size = New System.Drawing.Size(125, 23)
        Me.LblTotalAcuenta.TabIndex = 57
        Me.LblTotalAcuenta.Text = "0.00"
        Me.LblTotalAcuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel2.Location = New System.Drawing.Point(126, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 36)
        Me.Panel2.TabIndex = 52
        '
        'btnAGregarOD
        '
        Me.btnAGregarOD.Location = New System.Drawing.Point(578, 8)
        Me.btnAGregarOD.Name = "btnAGregarOD"
        Me.btnAGregarOD.Size = New System.Drawing.Size(180, 46)
        Me.btnAGregarOD.TabIndex = 4
        Me.btnAGregarOD.Text = "A&gregar Orden de Despacho"
        Me.btnAGregarOD.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Location = New System.Drawing.Point(226, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 7
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(182, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Hora : "
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(64, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha : "
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.ImageIndex = 5
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(244, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 26)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "[Buscar]"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'txtOrderDesp
        '
        Me.txtOrderDesp.Location = New System.Drawing.Point(138, 7)
        Me.txtOrderDesp.Name = "txtOrderDesp"
        Me.txtOrderDesp.ReadOnly = True
        Me.txtOrderDesp.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderDesp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "#Planilla de Orden Desp. :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BtnConsult)
        Me.GroupBox2.Location = New System.Drawing.Point(810, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(108, 187)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(8, 17)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(94, 30)
        Me.BTNNUEVO.TabIndex = 0
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(8, 50)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(94, 30)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(8, 83)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(94, 30)
        Me.BTNCANCELAR.TabIndex = 3
        Me.BTNCANCELAR.TabStop = False
        Me.BTNCANCELAR.Text = "     &Cancelar"
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(8, 116)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(94, 30)
        Me.btnreporte.TabIndex = 4
        Me.btnreporte.TabStop = False
        Me.btnreporte.Text = "&Reporte"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(8, 149)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(94, 30)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "  &Salir"
        '
        'BtnConsult
        '
        Me.BtnConsult.Location = New System.Drawing.Point(114, 84)
        Me.BtnConsult.Name = "BtnConsult"
        Me.BtnConsult.Size = New System.Drawing.Size(80, 30)
        Me.BtnConsult.TabIndex = 2
        Me.BtnConsult.Text = "&Consultar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(576, 479)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 20)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Descuento Total: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'GrpCabecera
        '
        Me.GrpCabecera.Controls.Add(Me.LBLSIMBOLOCAMBIO)
        Me.GrpCabecera.Controls.Add(Me.Label21)
        Me.GrpCabecera.Controls.Add(Me.Label17)
        Me.GrpCabecera.Controls.Add(Me.txtCobrador)
        Me.GrpCabecera.Controls.Add(Me.dtpFecha)
        Me.GrpCabecera.Controls.Add(Me.lbCobrador)
        Me.GrpCabecera.Controls.Add(Me.Label18)
        Me.GrpCabecera.Controls.Add(Me.LblHora)
        Me.GrpCabecera.Controls.Add(Me.LblFecha)
        Me.GrpCabecera.Controls.Add(Me.LblCambio)
        Me.GrpCabecera.Controls.Add(Me.Label19)
        Me.GrpCabecera.Controls.Add(Me.Label20)
        Me.GrpCabecera.Location = New System.Drawing.Point(120, 39)
        Me.GrpCabecera.Name = "GrpCabecera"
        Me.GrpCabecera.Size = New System.Drawing.Size(670, 102)
        Me.GrpCabecera.TabIndex = 51
        Me.GrpCabecera.TabStop = False
        '
        'LBLSIMBOLOCAMBIO
        '
        Me.LBLSIMBOLOCAMBIO.AutoSize = True
        Me.LBLSIMBOLOCAMBIO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSIMBOLOCAMBIO.Location = New System.Drawing.Point(466, 16)
        Me.LBLSIMBOLOCAMBIO.Name = "LBLSIMBOLOCAMBIO"
        Me.LBLSIMBOLOCAMBIO.Size = New System.Drawing.Size(14, 15)
        Me.LBLSIMBOLOCAMBIO.TabIndex = 4
        Me.LBLSIMBOLOCAMBIO.Text = "$"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(429, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 15)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "T.C. : "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(394, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "Moneda :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'txtCobrador
        '
        Me.txtCobrador.Enabled = False
        Me.txtCobrador.Location = New System.Drawing.Point(76, 16)
        Me.txtCobrador.Name = "txtCobrador"
        Me.txtCobrador.Size = New System.Drawing.Size(100, 20)
        Me.txtCobrador.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(284, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'lbCobrador
        '
        Me.lbCobrador.BackColor = System.Drawing.Color.White
        Me.lbCobrador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCobrador.Location = New System.Drawing.Point(76, 40)
        Me.lbCobrador.Name = "lbCobrador"
        Me.lbCobrador.Size = New System.Drawing.Size(296, 22)
        Me.lbCobrador.TabIndex = 9
        Me.lbCobrador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(238, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Fecha :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.Location = New System.Drawing.Point(506, 43)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(81, 16)
        Me.LblHora.TabIndex = 11
        Me.LblHora.Text = "11:58 a.m. "
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(426, 43)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(86, 16)
        Me.LblFecha.TabIndex = 10
        Me.LblFecha.Text = "30/07/2010 "
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCambio.Location = New System.Drawing.Point(476, 16)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(76, 16)
        Me.LblCambio.TabIndex = 5
        Me.LblCambio.Text = "T.C. 2.800"
        Me.LblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(-2, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "CodCobrador :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 44)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Cobrador :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblRestante)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtdescuento)
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
        Me.Panel1.Location = New System.Drawing.Point(10, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 84)
        Me.Panel1.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(382, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Saldo Pend. :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRestante
        '
        Me.lblRestante.BackColor = System.Drawing.Color.White
        Me.lblRestante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRestante.Location = New System.Drawing.Point(460, 56)
        Me.lblRestante.Name = "lblRestante"
        Me.lblRestante.Size = New System.Drawing.Size(92, 23)
        Me.lblRestante.TabIndex = 15
        Me.lblRestante.Text = "0.00"
        Me.lblRestante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(576, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Total Acuenta:"
        Me.Label12.Visible = False
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(278, 57)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(96, 20)
        Me.txtdescuento.TabIndex = 13
        Me.txtdescuento.Text = "0.00"
        Me.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(211, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Descuento :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(420, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "RUC:"
        '
        'LblRuc
        '
        Me.LblRuc.BackColor = System.Drawing.Color.White
        Me.LblRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRuc.Location = New System.Drawing.Point(452, 30)
        Me.LblRuc.Name = "LblRuc"
        Me.LblRuc.Size = New System.Drawing.Size(100, 23)
        Me.LblRuc.TabIndex = 7
        Me.LblRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Direccion:"
        Me.Label5.Visible = False
        '
        'lblDireccion
        '
        Me.lblDireccion.BackColor = System.Drawing.Color.White
        Me.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDireccion.Location = New System.Drawing.Point(232, 114)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(448, 23)
        Me.lblDireccion.TabIndex = 18
        Me.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDireccion.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nomb/Raz Soc.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(34, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Monto Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(104, 56)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRazonSoc
        '
        Me.lblRazonSoc.BackColor = System.Drawing.Color.White
        Me.lblRazonSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRazonSoc.Location = New System.Drawing.Point(104, 30)
        Me.lblRazonSoc.Name = "lblRazonSoc"
        Me.lblRazonSoc.Size = New System.Drawing.Size(312, 23)
        Me.lblRazonSoc.TabIndex = 6
        Me.lblRazonSoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBusDoc
        '
        Me.BtnBusDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBusDoc.ImageIndex = 5
        Me.BtnBusDoc.ImageList = Me.ImageList1
        Me.BtnBusDoc.Location = New System.Drawing.Point(208, 1)
        Me.BtnBusDoc.Name = "BtnBusDoc"
        Me.BtnBusDoc.Size = New System.Drawing.Size(74, 30)
        Me.BtnBusDoc.TabIndex = 2
        Me.BtnBusDoc.Text = "[Buscar]"
        Me.BtnBusDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBusDoc.Visible = False
        '
        'LblNroDoc
        '
        Me.LblNroDoc.BackColor = System.Drawing.Color.White
        Me.LblNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroDoc.Location = New System.Drawing.Point(104, 5)
        Me.LblNroDoc.Name = "LblNroDoc"
        Me.LblNroDoc.Size = New System.Drawing.Size(100, 23)
        Me.LblNroDoc.TabIndex = 1
        Me.LblNroDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nro Documento.: "
        '
        'LblFechaDoc
        '
        Me.LblFechaDoc.BackColor = System.Drawing.Color.White
        Me.LblFechaDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFechaDoc.Location = New System.Drawing.Point(362, 5)
        Me.LblFechaDoc.Name = "LblFechaDoc"
        Me.LblFechaDoc.Size = New System.Drawing.Size(100, 23)
        Me.LblFechaDoc.TabIndex = 4
        Me.LblFechaDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(294, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Fecha Doc.:"
        '
        'LblDsTipoDoc
        '
        Me.LblDsTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDsTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDsTipoDoc.Location = New System.Drawing.Point(572, 8)
        Me.LblDsTipoDoc.Name = "LblDsTipoDoc"
        Me.LblDsTipoDoc.Size = New System.Drawing.Size(186, 64)
        Me.LblDsTipoDoc.TabIndex = 9
        Me.LblDsTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvdetalle
        '
        Me.dgvdetalle.AllowUserToAddRows = False
        Me.dgvdetalle.AllowUserToDeleteRows = False
        Me.dgvdetalle.AllowUserToResizeRows = False
        Me.dgvdetalle.AutoGenerateColumns = False
        Me.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FECDOCUMDataGridViewTextBoxColumn, Me.TIPODOC, Me.NRODOCUDataGridViewTextBoxColumn, Me.CODCLIENTEDataGridViewTextBoxColumn, Me.DESCLIENTEDataGridViewTextBoxColumn, Me.ESTADO, Me.TOTCREDBASDataGridViewTextBoxColumn, Me.TOTCREDEXTDataGridViewTextBoxColumn, Me.PAGCREDBASDataGridViewTextBoxColumn, Me.PAGCREDEXTDataGridViewTextBoxColumn, Me.SALDOBASDataGridViewTextBoxColumn, Me.SALDOEXTDataGridViewTextBoxColumn, Me.CLIDEPDataGridViewTextBoxColumn, Me.DESCUENTO, Me.DataGridViewTextBoxColumn4})
        Me.dgvdetalle.DataSource = Me.PlanillaOrdenDetEBindingSource
        Me.dgvdetalle.Location = New System.Drawing.Point(12, 233)
        Me.dgvdetalle.Name = "dgvdetalle"
        Me.dgvdetalle.ReadOnly = True
        Me.dgvdetalle.RowTemplate.Height = 24
        Me.dgvdetalle.Size = New System.Drawing.Size(1120, 238)
        Me.dgvdetalle.TabIndex = 59
        '
        'FECDOCUMDataGridViewTextBoxColumn
        '
        Me.FECDOCUMDataGridViewTextBoxColumn.DataPropertyName = "FECDOCUM"
        Me.FECDOCUMDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FECDOCUMDataGridViewTextBoxColumn.Name = "FECDOCUMDataGridViewTextBoxColumn"
        Me.FECDOCUMDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECDOCUMDataGridViewTextBoxColumn.Width = 120
        '
        'TIPODOC
        '
        Me.TIPODOC.DataPropertyName = "TIPODOC"
        Me.TIPODOC.HeaderText = "Tipo Doc."
        Me.TIPODOC.Name = "TIPODOC"
        Me.TIPODOC.ReadOnly = True
        '
        'NRODOCUDataGridViewTextBoxColumn
        '
        Me.NRODOCUDataGridViewTextBoxColumn.DataPropertyName = "NRODOCU"
        Me.NRODOCUDataGridViewTextBoxColumn.HeaderText = "Nro Doc."
        Me.NRODOCUDataGridViewTextBoxColumn.Name = "NRODOCUDataGridViewTextBoxColumn"
        Me.NRODOCUDataGridViewTextBoxColumn.ReadOnly = True
        Me.NRODOCUDataGridViewTextBoxColumn.Width = 120
        '
        'CODCLIENTEDataGridViewTextBoxColumn
        '
        Me.CODCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CODCLIENTE"
        Me.CODCLIENTEDataGridViewTextBoxColumn.HeaderText = "CODCLIENTE"
        Me.CODCLIENTEDataGridViewTextBoxColumn.Name = "CODCLIENTEDataGridViewTextBoxColumn"
        Me.CODCLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CODCLIENTEDataGridViewTextBoxColumn.Visible = False
        '
        'DESCLIENTEDataGridViewTextBoxColumn
        '
        Me.DESCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "DESCLIENTE"
        Me.DESCLIENTEDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.DESCLIENTEDataGridViewTextBoxColumn.Name = "DESCLIENTEDataGridViewTextBoxColumn"
        Me.DESCLIENTEDataGridViewTextBoxColumn.ReadOnly = True
        Me.DESCLIENTEDataGridViewTextBoxColumn.Width = 180
        '
        'ESTADO
        '
        Me.ESTADO.DataPropertyName = "ESTADO"
        Me.ESTADO.FillWeight = 120.0!
        Me.ESTADO.HeaderText = "Estado"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 130
        '
        'TOTCREDBASDataGridViewTextBoxColumn
        '
        Me.TOTCREDBASDataGridViewTextBoxColumn.DataPropertyName = "TOTCREDBAS"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.TOTCREDBASDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TOTCREDBASDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.TOTCREDBASDataGridViewTextBoxColumn.Name = "TOTCREDBASDataGridViewTextBoxColumn"
        Me.TOTCREDBASDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTCREDBASDataGridViewTextBoxColumn.Width = 80
        '
        'TOTCREDEXTDataGridViewTextBoxColumn
        '
        Me.TOTCREDEXTDataGridViewTextBoxColumn.DataPropertyName = "TOTCREDEXT"
        Me.TOTCREDEXTDataGridViewTextBoxColumn.HeaderText = "TOTCREDEXT"
        Me.TOTCREDEXTDataGridViewTextBoxColumn.Name = "TOTCREDEXTDataGridViewTextBoxColumn"
        Me.TOTCREDEXTDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOTCREDEXTDataGridViewTextBoxColumn.Visible = False
        '
        'PAGCREDBASDataGridViewTextBoxColumn
        '
        Me.PAGCREDBASDataGridViewTextBoxColumn.DataPropertyName = "PAGCREDBAS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.PAGCREDBASDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.PAGCREDBASDataGridViewTextBoxColumn.HeaderText = "A Cuenta."
        Me.PAGCREDBASDataGridViewTextBoxColumn.Name = "PAGCREDBASDataGridViewTextBoxColumn"
        Me.PAGCREDBASDataGridViewTextBoxColumn.ReadOnly = True
        Me.PAGCREDBASDataGridViewTextBoxColumn.Width = 80
        '
        'PAGCREDEXTDataGridViewTextBoxColumn
        '
        Me.PAGCREDEXTDataGridViewTextBoxColumn.DataPropertyName = "PAGCREDEXT"
        Me.PAGCREDEXTDataGridViewTextBoxColumn.HeaderText = "PAGCREDEXT"
        Me.PAGCREDEXTDataGridViewTextBoxColumn.Name = "PAGCREDEXTDataGridViewTextBoxColumn"
        Me.PAGCREDEXTDataGridViewTextBoxColumn.ReadOnly = True
        Me.PAGCREDEXTDataGridViewTextBoxColumn.Visible = False
        '
        'SALDOBASDataGridViewTextBoxColumn
        '
        Me.SALDOBASDataGridViewTextBoxColumn.DataPropertyName = "SALDOBAS"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.SALDOBASDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SALDOBASDataGridViewTextBoxColumn.HeaderText = "Por Pagar"
        Me.SALDOBASDataGridViewTextBoxColumn.Name = "SALDOBASDataGridViewTextBoxColumn"
        Me.SALDOBASDataGridViewTextBoxColumn.ReadOnly = True
        Me.SALDOBASDataGridViewTextBoxColumn.Width = 85
        '
        'SALDOEXTDataGridViewTextBoxColumn
        '
        Me.SALDOEXTDataGridViewTextBoxColumn.DataPropertyName = "SALDOEXT"
        Me.SALDOEXTDataGridViewTextBoxColumn.HeaderText = "SALDOEXT"
        Me.SALDOEXTDataGridViewTextBoxColumn.Name = "SALDOEXTDataGridViewTextBoxColumn"
        Me.SALDOEXTDataGridViewTextBoxColumn.ReadOnly = True
        Me.SALDOEXTDataGridViewTextBoxColumn.Visible = False
        '
        'CLIDEPDataGridViewTextBoxColumn
        '
        Me.CLIDEPDataGridViewTextBoxColumn.DataPropertyName = "CLIDEP"
        Me.CLIDEPDataGridViewTextBoxColumn.HeaderText = "CLIDEP"
        Me.CLIDEPDataGridViewTextBoxColumn.Name = "CLIDEPDataGridViewTextBoxColumn"
        Me.CLIDEPDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIDEPDataGridViewTextBoxColumn.Visible = False
        '
        'DESCUENTO
        '
        Me.DESCUENTO.DataPropertyName = "DESCUENTO"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.DESCUENTO.DefaultCellStyle = DataGridViewCellStyle4
        Me.DESCUENTO.HeaderText = "Descuento"
        Me.DESCUENTO.Name = "DESCUENTO"
        Me.DESCUENTO.ReadOnly = True
        Me.DESCUENTO.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DESC_AUTORIZADO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Desc Autorizado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'PlanillaOrdenDetEBindingSource
        '
        Me.PlanillaOrdenDetEBindingSource.DataSource = GetType(NarGestionDistribuidora.PlanillaOrdenDetE)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TIPODOC"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TIPODOC"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TIPODOC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo Doc."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TIPODOC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo Doc."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'txtNumPlanilla
        '
        Me.txtNumPlanilla.Location = New System.Drawing.Point(799, 13)
        Me.txtNumPlanilla.Name = "txtNumPlanilla"
        Me.txtNumPlanilla.ReadOnly = True
        Me.txtNumPlanilla.Size = New System.Drawing.Size(100, 20)
        Me.txtNumPlanilla.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(529, 503)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(198, 20)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Descuento Autorizado: "
        '
        'LblTotalDescAutorizado
        '
        Me.LblTotalDescAutorizado.BackColor = System.Drawing.Color.White
        Me.LblTotalDescAutorizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalDescAutorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDescAutorizado.Location = New System.Drawing.Point(728, 502)
        Me.LblTotalDescAutorizado.Name = "LblTotalDescAutorizado"
        Me.LblTotalDescAutorizado.Size = New System.Drawing.Size(125, 23)
        Me.LblTotalDescAutorizado.TabIndex = 62
        Me.LblTotalDescAutorizado.Text = "0.00"
        Me.LblTotalDescAutorizado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(624, 528)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 20)
        Me.Label23.TabIndex = 63
        Me.Label23.Text = "Diferencia: "
        '
        'LblDiferencia
        '
        Me.LblDiferencia.BackColor = System.Drawing.Color.White
        Me.LblDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiferencia.Location = New System.Drawing.Point(728, 527)
        Me.LblDiferencia.Name = "LblDiferencia"
        Me.LblDiferencia.Size = New System.Drawing.Size(125, 23)
        Me.LblDiferencia.TabIndex = 64
        Me.LblDiferencia.Text = "0.00"
        Me.LblDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TIPODOC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo Doc."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TIPODOC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tipo Doc."
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TIPODOC"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo Doc."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'frmPlanillaDescOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 563)
        Me.Controls.Add(Me.LblDiferencia)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.LblTotalDescAutorizado)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtNumPlanilla)
        Me.Controls.Add(Me.dgvdetalle)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LblTotalAcuenta)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GrpCabecera)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPlanillaDescOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Descuento de Orden de Despacho"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCabecera.ResumeLayout(False)
        Me.GrpCabecera.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaOrdenDetEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents LblTotalAcuenta As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAGregarOD As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Protected WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtOrderDesp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BtnConsult As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GrpCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents LBLSIMBOLOCAMBIO As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCobrador As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbCobrador As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents LblCambio As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblRestante As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dgvdetalle As System.Windows.Forms.DataGridView
    Friend WithEvents PlanillaOrdenDetEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODTIPODOCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents txtNumPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LblTotalDescAutorizado As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LblDiferencia As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECDOCUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPODOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRODOCUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODCLIENTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCLIENTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTCREDBASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTCREDEXTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAGCREDBASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAGCREDEXTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDOBASDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALDOEXTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIDEPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCUENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
