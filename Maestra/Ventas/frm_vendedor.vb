'Imports AxShockwaveFlashObjects
Imports System.Data.SqlClient
Public Class frm_vendedor
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtctaBanca As System.Windows.Forms.ComboBox
    Friend WithEvents cciudad As System.Windows.Forms.ComboBox
    Friend WithEvents tvendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents cbRuta As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbZonaVenta As System.Windows.Forms.ComboBox
    Friend WithEvents cbFuerzaVenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgCuotasLinea As System.Windows.Forms.DataGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents txtDirec As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtNropedido As System.Windows.Forms.TextBox
    Friend WithEvents TablaEstiloCuotaLinea As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbLinea As System.Windows.Forms.Label
    Friend WithEvents btnBuscarLinea As System.Windows.Forms.Button
    Friend WithEvents txtLinea As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dgCuotaLinea As System.Windows.Forms.DataGrid
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarCuota As System.Windows.Forms.Button
    Friend WithEvents cbosublinea As System.Windows.Forms.ComboBox
    Friend WithEvents cbolinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtLineaCred As System.Windows.Forms.TextBox
    Friend WithEvents ckActivar As System.Windows.Forms.CheckBox
    Friend WithEvents CboTipoComision As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_vendedor))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtLineaCred = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgCuotasLinea = New System.Windows.Forms.DataGrid
        Me.TablaEstiloCuotaLinea = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cbRuta = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.TxtNropedido = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.dtpFechaReg = New System.Windows.Forms.DateTimePicker
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDirec = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDNI = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbFuerzaVenta = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtctaBanca = New System.Windows.Forms.ComboBox
        Me.cciudad = New System.Windows.Forms.ComboBox
        Me.tvendedor = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.cbZonaVenta = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.ckActivar = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cbosublinea = New System.Windows.Forms.ComboBox
        Me.cbolinea = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.txtCuota = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dgCuotaLinea = New System.Windows.Forms.DataGrid
        Me.btnAñadir = New System.Windows.Forms.Button
        Me.BtnQuitarCuota = New System.Windows.Forms.Button
        Me.lbLinea = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtLinea = New System.Windows.Forms.TextBox
        Me.btnBuscarLinea = New System.Windows.Forms.Button
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.CboTipoComision = New System.Windows.Forms.ComboBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgCuotasLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(488, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 218)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(12, 157)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 23)
        Me.btnreporte.TabIndex = 14
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(12, 130)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCANCELAR.TabIndex = 13
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(12, 184)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCERRAR.TabIndex = 15
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(12, 76)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNMODIFICAR.TabIndex = 11
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(12, 103)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNELIMINAR.TabIndex = 12
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(12, 22)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(82, 23)
        Me.BTNNUEVO.TabIndex = 9
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(12, 49)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNGUARDAR.TabIndex = 10
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboTipoComision)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtLineaCred)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TxtNropedido)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaReg)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDirec)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbFuerzaVenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtctaBanca)
        Me.GroupBox1.Controls.Add(Me.cciudad)
        Me.GroupBox1.Controls.Add(Me.tvendedor)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 452)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(39, 174)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 13)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Linea Cred :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLineaCred
        '
        Me.txtLineaCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLineaCred.Location = New System.Drawing.Point(105, 171)
        Me.txtLineaCred.MaxLength = 150
        Me.txtLineaCred.Name = "txtLineaCred"
        Me.txtLineaCred.Size = New System.Drawing.Size(113, 21)
        Me.txtLineaCred.TabIndex = 77
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgCuotasLinea)
        Me.GroupBox3.Controls.Add(Me.cbRuta)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Controls.Add(Me.btnQuitar)
        Me.GroupBox3.Location = New System.Drawing.Point(50, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(403, 169)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        '
        'dgCuotasLinea
        '
        Me.dgCuotasLinea.AllowSorting = False
        Me.dgCuotasLinea.CaptionVisible = False
        Me.dgCuotasLinea.DataMember = ""
        Me.dgCuotasLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotasLinea.Location = New System.Drawing.Point(13, 49)
        Me.dgCuotasLinea.Name = "dgCuotasLinea"
        Me.dgCuotasLinea.ReadOnly = True
        Me.dgCuotasLinea.Size = New System.Drawing.Size(314, 112)
        Me.dgCuotasLinea.TabIndex = 56
        Me.dgCuotasLinea.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloCuotaLinea})
        '
        'TablaEstiloCuotaLinea
        '
        Me.TablaEstiloCuotaLinea.DataGrid = Me.dgCuotasLinea
        Me.TablaEstiloCuotaLinea.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.TablaEstiloCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'cbRuta
        '
        Me.cbRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRuta.Location = New System.Drawing.Point(53, 20)
        Me.cbRuta.Name = "cbRuta"
        Me.cbRuta.Size = New System.Drawing.Size(241, 21)
        Me.cbRuta.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Ruta :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(335, 48)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(57, 26)
        Me.btnAgregar.TabIndex = 61
        Me.btnAgregar.Text = "Agregar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(336, 83)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(57, 26)
        Me.btnQuitar.TabIndex = 72
        Me.btnQuitar.Text = "Quitar"
        '
        'TxtNropedido
        '
        Me.TxtNropedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNropedido.Location = New System.Drawing.Point(315, 142)
        Me.TxtNropedido.MaxLength = 150
        Me.TxtNropedido.Name = "TxtNropedido"
        Me.TxtNropedido.Size = New System.Drawing.Size(113, 21)
        Me.TxtNropedido.TabIndex = 75
        Me.TxtNropedido.Text = "0"
        Me.TxtNropedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(247, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "NroPedido : "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(391, 90)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 24)
        Me.CheckBox1.TabIndex = 73
        Me.CheckBox1.Text = "Activo"
        '
        'dtpFechaReg
        '
        Me.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReg.Location = New System.Drawing.Point(105, 141)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(87, 21)
        Me.dtpFechaReg.TabIndex = 71
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(314, 115)
        Me.txtTelefono.MaxLength = 150
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(113, 21)
        Me.txtTelefono.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(256, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Telefono :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDirec
        '
        Me.txtDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDirec.Location = New System.Drawing.Point(103, 66)
        Me.txtDirec.MaxLength = 150
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(357, 21)
        Me.txtDirec.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Dirección :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Fecha Reg. :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDNI
        '
        Me.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDNI.Location = New System.Drawing.Point(104, 115)
        Me.txtDNI.MaxLength = 150
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(113, 21)
        Me.txtDNI.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "D.N.I. :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbFuerzaVenta
        '
        Me.cbFuerzaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFuerzaVenta.Location = New System.Drawing.Point(103, 245)
        Me.cbFuerzaVenta.Name = "cbFuerzaVenta"
        Me.cbFuerzaVenta.Size = New System.Drawing.Size(243, 21)
        Me.cbFuerzaVenta.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Fuerza Venta :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtctaBanca
        '
        Me.txtctaBanca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtctaBanca.Location = New System.Drawing.Point(103, 198)
        Me.txtctaBanca.Name = "txtctaBanca"
        Me.txtctaBanca.Size = New System.Drawing.Size(243, 21)
        Me.txtctaBanca.TabIndex = 4
        '
        'cciudad
        '
        Me.cciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cciudad.Location = New System.Drawing.Point(104, 90)
        Me.cciudad.Name = "cciudad"
        Me.cciudad.Size = New System.Drawing.Size(211, 21)
        Me.cciudad.TabIndex = 3
        '
        'tvendedor
        '
        Me.tvendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tvendedor.Location = New System.Drawing.Point(104, 42)
        Me.tvendedor.MaxLength = 150
        Me.tvendedor.Name = "tvendedor"
        Me.tvendedor.Size = New System.Drawing.Size(357, 21)
        Me.tvendedor.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Zona Almacen: "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Vendedor :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Provincia :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcodigo
        '
        Me.tcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodigo.Location = New System.Drawing.Point(104, 19)
        Me.tcodigo.MaxLength = 4
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(100, 21)
        Me.tcodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(207, 18)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 18
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbZonaVenta
        '
        Me.cbZonaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbZonaVenta.Location = New System.Drawing.Point(500, 348)
        Me.cbZonaVenta.Name = "cbZonaVenta"
        Me.cbZonaVenta.Size = New System.Drawing.Size(47, 21)
        Me.cbZonaVenta.TabIndex = 52
        Me.cbZonaVenta.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(497, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Zona Venta :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(822, 504)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ckActivar)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.cbZonaVenta)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(814, 478)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'ckActivar
        '
        Me.ckActivar.Location = New System.Drawing.Point(500, 384)
        Me.ckActivar.Name = "ckActivar"
        Me.ckActivar.Size = New System.Drawing.Size(66, 24)
        Me.ckActivar.TabIndex = 74
        Me.ckActivar.Text = "Tienda"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.lbLinea)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.txtLinea)
        Me.TabPage2.Controls.Add(Me.btnBuscarLinea)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(814, 442)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cuotas del Vendedor"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbosublinea)
        Me.GroupBox5.Controls.Add(Me.cbolinea)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.dtpFecha2)
        Me.GroupBox5.Controls.Add(Me.dtpFecha1)
        Me.GroupBox5.Controls.Add(Me.txtCuota)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.dgCuotaLinea)
        Me.GroupBox5.Controls.Add(Me.btnAñadir)
        Me.GroupBox5.Controls.Add(Me.BtnQuitarCuota)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 22)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(780, 385)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'cbosublinea
        '
        Me.cbosublinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosublinea.ItemHeight = 13
        Me.cbosublinea.Location = New System.Drawing.Point(96, 39)
        Me.cbosublinea.Name = "cbosublinea"
        Me.cbosublinea.Size = New System.Drawing.Size(282, 21)
        Me.cbosublinea.TabIndex = 23
        '
        'cbolinea
        '
        Me.cbolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbolinea.ItemHeight = 13
        Me.cbolinea.Location = New System.Drawing.Point(96, 12)
        Me.cbolinea.Name = "cbolinea"
        Me.cbolinea.Size = New System.Drawing.Size(282, 21)
        Me.cbolinea.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(38, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Categoria :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(14, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Sub Categoria :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(416, 67)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(90, 21)
        Me.dtpFecha2.TabIndex = 4
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(256, 67)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha1.TabIndex = 3
        '
        'txtCuota
        '
        Me.txtCuota.Location = New System.Drawing.Point(96, 67)
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(56, 21)
        Me.txtCuota.TabIndex = 2
        Me.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(36, 73)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 16)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Cuota :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(358, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Fec. Fin :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(190, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Fec. Inicio :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgCuotaLinea
        '
        Me.dgCuotaLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCuotaLinea.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgCuotaLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCuotaLinea.DataMember = ""
        Me.dgCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotaLinea.Location = New System.Drawing.Point(8, 107)
        Me.dgCuotaLinea.Name = "dgCuotaLinea"
        Me.dgCuotaLinea.ReadOnly = True
        Me.dgCuotaLinea.Size = New System.Drawing.Size(675, 268)
        Me.dgCuotaLinea.TabIndex = 5
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(700, 146)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(70, 26)
        Me.btnAñadir.TabIndex = 7
        Me.btnAñadir.Text = "Añadir"
        '
        'BtnQuitarCuota
        '
        Me.BtnQuitarCuota.Location = New System.Drawing.Point(700, 184)
        Me.BtnQuitarCuota.Name = "BtnQuitarCuota"
        Me.BtnQuitarCuota.Size = New System.Drawing.Size(70, 26)
        Me.BtnQuitarCuota.TabIndex = 8
        Me.BtnQuitarCuota.Text = "Quitar"
        '
        'lbLinea
        '
        Me.lbLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbLinea.Location = New System.Drawing.Point(201, 413)
        Me.lbLinea.Name = "lbLinea"
        Me.lbLinea.Size = New System.Drawing.Size(190, 20)
        Me.lbLinea.TabIndex = 7
        Me.lbLinea.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(57, 417)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "SubCategoria :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'txtLinea
        '
        Me.txtLinea.Location = New System.Drawing.Point(137, 413)
        Me.txtLinea.Name = "txtLinea"
        Me.txtLinea.Size = New System.Drawing.Size(56, 21)
        Me.txtLinea.TabIndex = 0
        Me.txtLinea.Visible = False
        '
        'btnBuscarLinea
        '
        Me.btnBuscarLinea.ImageIndex = 5
        Me.btnBuscarLinea.ImageList = Me.ImageList1
        Me.btnBuscarLinea.Location = New System.Drawing.Point(393, 411)
        Me.btnBuscarLinea.Name = "btnBuscarLinea"
        Me.btnBuscarLinea.Size = New System.Drawing.Size(44, 23)
        Me.btnBuscarLinea.TabIndex = 1
        Me.btnBuscarLinea.Visible = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(598, 0)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 27
        '
        'CboTipoComision
        '
        Me.CboTipoComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoComision.ItemHeight = 13
        Me.CboTipoComision.Location = New System.Drawing.Point(103, 222)
        Me.CboTipoComision.Name = "CboTipoComision"
        Me.CboTipoComision.Size = New System.Drawing.Size(244, 21)
        Me.CboTipoComision.TabIndex = 79
        '
        'Label37
        '
        Me.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label37.Location = New System.Drawing.Point(-26, 222)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(126, 20)
        Me.Label37.TabIndex = 80
        Me.Label37.Text = "Tipo Comisiones :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_vendedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.BTNCERRAR
        Me.ClientSize = New System.Drawing.Size(860, 524)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_vendedor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Vendedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgCuotasLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Private INTFLAGVEND As Integer
    Public TablaCuotaslineaVendedor As New DataTable
    'Private Obj As New ClsInterface
    Private TablaCuotasLinea As New DataTable
    Private ObjAyuda As New ClsAyuda
    Private codlinea As String

    Private ACT_EVENTOS As Integer



    Dim TIPOVEND As Integer

#End Region

#Region "Funciones form"
    Public Sub FORMATO_GRID()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TablaCuotasLinea.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODVENDED"
            .HeaderText = "CODVEND"
            .Width = 50
        End With


        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODLINEA"
            .HeaderText = "CODLINEA"
            .Width = 0
        End With

        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "CODSUBLINEA"
            .HeaderText = "CODSUBLINEA"
            .Width = 0
        End With

        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "DESLINEA"
            .HeaderText = "CATEGORIA"
            .Width = 150
        End With
        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "DESSUBLINEA"
            .HeaderText = "SUBCATEGORIA"
            .Width = 150
        End With
        Dim column6 As New DataGridTextBoxColumn
        With column6
            .MappingName = "MONTOCUOTA"
            .HeaderText = "CUOTA"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column7 As New DataGridTextBoxColumn
        With column7
            .MappingName = "FEC_INI"
            .HeaderText = "FEC_INI"
            .Width = 100
        End With
        Dim column8 As New DataGridTextBoxColumn
        With column8
            .MappingName = "FEC_FIN"
            .HeaderText = "FEC_FIN"
            .Width = 100
        End With
        dgCuotaLinea.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5, column6, column7, column8})
        dgCuotaLinea.TableStyles.Add(TableStyle1)

    End Sub




#End Region


    Private Sub frm_clie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call INICIALIZA()
        Call cargadatos()
        Call bloquea(True, False)
        BTNCANCELAR.Enabled = False
        FORMATO_GRID()
    End Sub
    Sub bloquea(ByVal p As Boolean, ByVal p1 As Boolean)

        tcodigo.ReadOnly = p
        tvendedor.ReadOnly = p
        txtDirec.ReadOnly = p
        txtLineaCred.ReadOnly = p


        txtctaBanca.Enabled = p1
        cbFuerzaVenta.Enabled = p1
        cbZonaVenta.Enabled = p1
        cciudad.Enabled = p1
        dtpFechaReg.Enabled = p1
        CheckBox1.Enabled = p1

        txtDNI.ReadOnly = p
        txtTelefono.ReadOnly = p
        TxtNropedido.ReadOnly = p
        GroupBox5.Enabled = p1

        CboTipoComision.Enabled = p1


    End Sub
    Sub INICIALIZA()
        tcodigo.Text = ""
        tvendedor.Text = ""
        txtDirec.Text = ""
        txtDNI.Text = ""
        txtTelefono.Text = ""
        dtpFechaReg.Value = Date.Now
        TxtNropedido.Text = ""
    End Sub

    Sub cargadatos()
        Try
            CAyuda.CargarDataCombo(cciudad, "Nsp_Sele_Ciudad_ '" & codempresa.Trim & "'", "codciudad", "desciudad")
            CAyuda.CargarDataCombo(txtctaBanca, "Nsp_Select_Zona '" & codempresa.Trim & "'", "codzona", "deszona")
            'CAyuda.CargarDataCombo(cptoventa, "Nsp_Sele_tdaptoventa '" & CodEmpresa & "','',''", "NROPTOVTA", "DESPTOVTA")
            'CAyuda.CargarDataCombo(cbLinea, "Nsp_sel_linea '" & CodEmpresa & "'", "codlinea", "deslinea")
            CAyuda.CargarDataCombo(cbFuerzaVenta, "SELECT * FROM FUERZAVENTA where codempresa ='" & codempresa.Trim & "'", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(cbZonaVenta, "SELECT * FROM ZONAVENTA where codempresa ='" & codempresa.Trim & "'", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(cbRuta, "SELECT * FROM RUTA where codempresa ='" & codempresa.Trim & "'", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(cbolinea, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")
            CAyuda.CargarDataCombo(CboTipoComision, "nsp_sele_tipocomisiones  '" & codempresa & "'", "CDTIPOCOM", "DSTIPOCOM")





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub

        If INTFLAGVEND = 0 Then
            Call Limpiatextbox(Me)

            Call BOTONES(True, False, False, False, True)
        Else
            Call BOTONES(True, False, False, False, True)
        End If
        Limp_Grid()
        Call INICIALIZA()
        Call Bloqueatextbox(Me)
        Call bloquea(True, False)
        BTNCANCELAR.Enabled = False
        ckActivar.Checked = False


    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)

        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        Me.dgCuotasLinea.Enabled = GUARDAR
        Me.btnAgregar.Enabled = GUARDAR
        Me.cbRuta.Enabled = GUARDAR
        btnAñadir.Enabled = GUARDAR
        btnbuscar.Enabled = BUSCAR

    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then

            If tcodigo.Text.Trim.Length = 0 Then
                MsgBox("Falta seleccionar un vendedor.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            Conecta("SELECT CODCLIENTE FROM CLIENTE WHERE CODVEND='" & tcodigo.Text.Trim & "' AND CODEMPRESA = '" & codempresa & "'", "VERIFICA")
            If ds.Tables("VERIFICA").Rows.Count > 0 Then
                MessageBox.Show("No puede eliminar al Vendedor ya que tiene Registros Relacionados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim PROCESO As Boolean
            Dim sql As String
            sql = "nsp_dele_vendedor '" & tcodigo.Text & "','" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = False Then Exit Sub
            Eliminar_Nextel()
            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)
            Call Limpiatextbox(Me)
            Call INICIALIZA()
            Call bloquea(True, False)
            Limp_Grid()
            Me.TablaCuotaslineaVendedor.Rows.Clear()
            Me.dgCuotasLinea.DataSource = TablaCuotaslineaVendedor
            ckActivar.Checked = False
        End If



    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        Call bloquea(False, True)
        tcodigo.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        INTFLAGVEND = 1
        tvendedor.Focus()
        tvendedor.SelectAll()
        BTNCANCELAR.Enabled = True
        ACT_EVENTOS = 1
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call INICIALIZA()
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)
        Call bloquea(False, True)
        INTFLAGVEND = 0
        tcodigo.Focus()
        BTNCANCELAR.Enabled = True
        ckActivar.Checked = False


        TablaCuotaslineaVendedor = CAyuda.ListarDatos("NSP_SELECT_RUTA_VENDEDOR", codempresa.Trim, "xxxxxxxxxxxx", "%").Tables(0)
        TablaEstiloCuotaLinea.MappingName = TablaCuotaslineaVendedor.TableName
        TablaEstiloCuotaLinea.GridColumnStyles(0).MappingName = "CODRUTA"
        TablaEstiloCuotaLinea.GridColumnStyles(1).MappingName = "DESCRIPCION"
        dgCuotasLinea.TableStyles.Add(TablaEstiloCuotaLinea)
        dgCuotasLinea.DataSource = TablaCuotaslineaVendedor

        ACT_EVENTOS = 1


    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Call formatotextbox(Me)

        If Me.cciudad.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar la ciudad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Me.txtctaBanca.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar la Zona", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If Me.TxtNropedido.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar el Numero Pedido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNropedido.Focus()
            Exit Sub
        End If

        If txtLineaCred.Text = "" Then
            txtLineaCred.Text = 0
            'MessageBox.Show("Falta ingresar linea d", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'TxtNropedido.Focus()
            'Exit Sub
        End If


        If tcodigo.Text = "" Or tvendedor.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
            ' ElseIf tcuotad.Text.Trim = "" Then
            'MessageBox.Show("Ingrese la Cuota en Dólares Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
            'ElseIf tcuotat.Text.Trim = "" Then
            'MessageBox.Show("Ingrese la Cuota de toneladas Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
            'ElseIf tcuotas.Text.Trim = "" Then
            'MessageBox.Show("Ingrese la Cuotas en Soles Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
        End If


        If INTFLAGVEND = 0 Then
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_VERIFI_ID_VENDEDOR", tcodigo.Text.Trim).Tables(0)
            If dt.Rows.Count > 0 Then
                MsgBox("El código ya existe.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            'sql = "NSP_ins_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.SelectedValue.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.cbFuerzaVenta.SelectedValue & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
            Dim RptaTrans As Boolean
            RptaTrans = CAyuda.Ejecutar("NSP_ins_VENDEDOR", codempresa, tcodigo.Text.Trim, tvendedor.Text.Trim, txtDNI.Text.Trim, txtTelefono.Text.Trim, dtpFechaReg.Value.ToShortDateString, txtDirec.Text.Trim, txtctaBanca.SelectedValue, cciudad.SelectedValue, TxtNropedido.Text, Me.cbFuerzaVenta.SelectedValue, "", Now, CodUsuario, TxtNropedido.Text, txtLineaCred.Text, TIPOVEND, CheckBox1.Checked, CboTipoComision.SelectedValue)
            If RptaTrans Then
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

                CAyuda.ListarDatos("NSP_DELETE_RUTA_VENDEDOR", codempresa, tcodigo.Text.Trim)
                For cont1 As Integer = 0 To Me.TablaCuotaslineaVendedor.Rows.Count - 1
                    CAyuda.Ejecutar("NSP_INSERT_RUTA_VENDEDOR", codempresa, tcodigo.Text.Trim, TablaCuotaslineaVendedor.Rows(cont1)(0))
                Next
                Guardar_Nextel()
                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)

                Bloqueatextbox(Me)
                Call bloquea(True, False)
            End If
        End If


        If INTFLAGVEND = 1 Then
            Dim RptaTrans As Boolean
            RptaTrans = CAyuda.Ejecutar("NSP_upd_VENDEDOR", codempresa, tcodigo.Text.Trim, tvendedor.Text.Trim, txtDNI.Text.Trim, txtTelefono.Text.Trim, dtpFechaReg.Value.ToShortDateString, txtDirec.Text.Trim, txtctaBanca.SelectedValue, cciudad.SelectedValue, TxtNropedido.Text, Me.cbFuerzaVenta.SelectedValue, "", Now, CodUsuario, TxtNropedido.Text, CDbl(txtLineaCred.Text), TIPOVEND, CheckBox1.Checked, CboTipoComision.SelectedValue)
            'sql = "NSP_upd_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.SelectedValue.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.cbFuerzaVenta.SelectedValue & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
            If RptaTrans Then
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

                CAyuda.ListarDatos("NSP_DELETE_RUTA_VENDEDOR", codempresa, tcodigo.Text.Trim)
                For cont1 As Integer = 0 To Me.TablaCuotaslineaVendedor.Rows.Count - 1
                    CAyuda.Ejecutar("NSP_INSERT_RUTA_VENDEDOR", codempresa, tcodigo.Text.Trim, TablaCuotaslineaVendedor.Rows(cont1)(0))
                Next

                Guardar_Nextel()
                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)

                Bloqueatextbox(Me)
                Call bloquea(True, False)
            End If
        End If



        Limp_Grid()
        Me.TablaCuotaslineaVendedor.Rows.Clear()
        Me.dgCuotasLinea.DataSource = TablaCuotaslineaVendedor
        BTNCANCELAR.Enabled = False
        Call INICIALIZA()

        ACT_EVENTOS = 0

        txtLineaCred.Text = ""
        ckActivar.Checked = False



    End Sub

    Sub Eliminar_Nextel()
        Try
            If ACTIVABD = True Then
                CAyuda.Ejecutar(2, "SP_DEL_VENDEDOR", VCODNEXTEL.Trim, tcodigo.Text.Trim)

            End If
        Catch ex As Exception
            MsgBox("Problema de conexión con Nextel, intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try

    End Sub

    Sub Guardar_Nextel()
        Try
            If CheckBox1.Checked = False Then
                Eliminar_Nextel()
                Exit Sub
            End If

            If ACTIVABD = True Then
                CAyuda.Ejecutar(2, "SP_N_INS_VENDEDOR", VCODNEXTEL.Trim, tcodigo.Text.Trim, tvendedor.Text, "", "1234", "0")
            End If

        Catch ex As Exception
            MsgBox("Problema de conexión con Nextel, intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try


    End Sub




    Private Sub Limp_Grid()
        TablaCuotasLinea.Rows.Clear()
        Me.dgCuotaLinea.DataSource = Nothing
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call BOTONES(True, False, True, True, True)
        Call Bloqueatextbox(Me)

        Dim FRMX As New FRM_GRIDVEND
        FRMX.vie = Me
        FRMX.bol = True
        FRMX.ShowDialog()

        tcodigo.ReadOnly = True

    End Sub

    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tvendedor.Focus()
            Me.tvendedor.SelectAll()
        End If
    End Sub

    Private Sub tvendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tvendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtDirec.Focus()
        End If
    End Sub

    Private Sub cciudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cciudad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtDNI.Focus()
        End If
    End Sub

    Private Sub czona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtctaBanca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cbFuerzaVenta.Focus()
        End If
    End Sub


    Private Sub tcuotat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.tcuotat.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            ' Me.tcuotas.Focus()
            ' Me.tcuotas.SelectAll()
        End If
    End Sub

    Private Sub tcuotas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.tcuotas.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            'Me.tcuotad.Focus()
            'Me.tcuotad.SelectAll()
        End If
    End Sub

    Private Sub tcuotad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.tcuotad.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.BTNGUARDAR.Focus()
        End If
    End Sub
    Private Sub tcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tcodigo.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub cptoventa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'Me.tcuotat.Focus()
            'Me.tcuotat.SelectAll()
        End If
    End Sub

    Private Sub cbLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    TablaCoutaslineaVendedor = Obj.ListarDatos("NSP_SELECT_FAMILIA_VENDEDOR", codempresa.Trim, tcodigo.Text.Trim, Me.cbLinea.SelectedValue.ToString.Trim).Tables(0)
        '    TablaEstiloCuotaLinea.MappingName = TablaCoutaslineaVendedor.TableName
        '    TablaEstiloCuotaLinea.GridColumnStyles(0).MappingName = "CODLINEA"
        '    TablaEstiloCuotaLinea.GridColumnStyles(1).MappingName = "DESLINEA"
        '    TablaEstiloCuotaLinea.GridColumnStyles(2).MappingName = "MONTOCUOTA"
        '    Me.dgCuotasLinea.TableStyles.Add(TablaEstiloCuotaLinea)
        '    Me.dgCuotasLinea.DataSource = TablaCoutaslineaVendedor
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If TablaCuotaslineaVendedor.Rows.Count = 0 Then
            Dim FilaN As DataRow = TablaCuotaslineaVendedor.NewRow
            FilaN(0) = Me.cbRuta.SelectedValue.ToString.Trim
            FilaN(1) = Me.cbRuta.Text.Trim
            TablaCuotaslineaVendedor.Rows.Add(FilaN)
        Else
            For cont1 As Integer = 0 To TablaCuotaslineaVendedor.Rows.Count - 1
                If TablaCuotaslineaVendedor.Rows(cont1)(0).ToString.Trim = Me.cbRuta.SelectedValue.ToString.Trim Then
                    Exit Sub
                End If
                If cont1 = TablaCuotaslineaVendedor.Rows.Count - 1 Then
                    Dim FilaN As DataRow = TablaCuotaslineaVendedor.NewRow
                    FilaN(0) = Me.cbRuta.SelectedValue.ToString.Trim
                    FilaN(1) = Me.cbRuta.Text.Trim
                    TablaCuotaslineaVendedor.Rows.Add(FilaN)
                End If
            Next
        End If
        Me.dgCuotasLinea.DataSource = TablaCuotaslineaVendedor

    End Sub

    Private Sub btnGuardaCuotaLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'MsgBox("Datos Guardados !", MsgBoxStyle.Information)
    End Sub

    Private Sub dgCuotasLinea_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgCuotasLinea.Navigate

    End Sub

    Private Sub dgCuotasLinea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgCuotasLinea.KeyDown

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        For cont1 As Integer = 0 To TablaCuotaslineaVendedor.Rows.Count - 1
            If Me.TablaCuotaslineaVendedor.Rows(cont1)("CODRUTA").ToString.Trim = Me.dgCuotasLinea(Me.dgCuotasLinea.CurrentRowIndex, 0) Then
                TablaCuotaslineaVendedor.Rows.RemoveAt(cont1)
                Me.dgCuotasLinea.DataSource = TablaCuotaslineaVendedor
                Exit For
            End If
        Next
    End Sub

    Private Sub TxtNropedido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNropedido.TextChanged

    End Sub

    Private Sub TxtNropedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNropedido.KeyPress

        If IsNumeric(e.KeyChar) = True Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.txtctaBanca.Focus()
        End If



    End Sub
    Private Sub TxtNropedido_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNropedido.Leave
        If TxtNropedido.Text.Trim = "" Then
            TxtNropedido.Text = "0"
        End If
    End Sub

    Private Sub btnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadir.Click

        If tcodigo.Text.Trim = "" Then
            MsgBox("Falta el Codigo del Vendedor..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If Me.TablaCuotasLinea.Rows.Count = 0 Then
            If Me.txtCuota.Text.Trim.Length > 0 Then
                CAyuda.Ejecutar("NSP_INSERT_CUOTAXLINEA_VEND", codempresa, tcodigo.Text.Trim, cbolinea.SelectedValue, cbosublinea.SelectedValue, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, tcodigo.Text.Trim.Trim).Tables(0)
                Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                FORMATO_GRID()
            End If

        Else
            If Me.txtCuota.Text.Trim.Length > 0 Then
                For cont1 As Integer = 0 To TablaCuotasLinea.Rows.Count - 1
                    If TablaCuotasLinea.Rows(cont1)("CODLINEA").ToString.Trim = Me.txtLinea.Text.Trim Then
                        CAyuda.Ejecutar("NSP_UPDATE_CUOTAXLINEA_VEND", codempresa, tcodigo.Text.Trim, cbolinea.SelectedValue, cbosublinea.SelectedValue, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, tcodigo.Text.Trim.Trim).Tables(0)
                        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                        FORMATO_GRID()
                        Exit For
                    End If
                    If cont1 = TablaCuotasLinea.Rows.Count - 1 Then
                        CAyuda.Ejecutar("NSP_INSERT_CUOTAXLINEA_VEND", codempresa, tcodigo.Text.Trim, cbolinea.SelectedValue, cbosublinea.SelectedValue, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, tcodigo.Text.Trim.Trim).Tables(0)
                        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                        FORMATO_GRID()
                    End If
                Next
            End If
        End If

        Me.txtLinea.Text = String.Empty
        Me.txtCuota.Text = String.Empty
        Me.lbLinea.Text = String.Empty
        Me.dtpFecha1.Value = Now : dtpFecha2.Value = Now

    End Sub


    Private Sub BtnQuitarCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarCuota.Click


        If tcodigo.Text.Trim = "" Then
            MsgBox("Falta el Codigo del Vendedor..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TablaCuotasLinea.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar la cuota de la SubCategoria [ " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_CUOTAXLINEA_VEND", codempresa, tcodigo.Text.Trim.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 1).ToString.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim)
            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, tcodigo.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()
        End If


    End Sub

    Private Sub btnBuscarLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarLinea.Click
        Dim MEN As New FrmGridSubLinea
        MEN.ShowDialog()
        If MEN.DEVOLVER = False Then
            Exit Sub
        End If
        txtLinea.Text = MEN.GridSubCat.Item(MEN.GridSubCat.CurrentRowIndex, 0)
        codlinea = MEN.GridSubCat.Item(MEN.GridSubCat.CurrentRowIndex, 0)
        lbLinea.Text = MEN.GridSubCat.Item(MEN.GridSubCat.CurrentRowIndex, 1)
        Me.txtCuota.Focus()

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Try


            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)

            crRpt.ReportFileName = rutareporte & "RptVendedor.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_Formulas(1, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            crRpt.set_Formulas(0, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized




            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcodigo.TextChanged
        If Me.tcodigo.Text.Trim.Length > 0 Then
            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, tcodigo.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        End If
    End Sub

    Private Sub tvendedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvendedor.TextChanged

    End Sub

    Private Sub txtDirec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDirec.TextChanged

    End Sub

    Private Sub txtDirec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDirec.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.cciudad.Focus()

        End If

    End Sub

    Private Sub cciudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cciudad.SelectedIndexChanged

    End Sub

    Private Sub txtDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNI.TextChanged

    End Sub

    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.txtTelefono.Focus()
        End If

    End Sub

    Private Sub txtTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.dtpFechaReg.Focus()
        End If

    End Sub

    Private Sub dtpFechaReg_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaReg.ValueChanged

    End Sub

    Private Sub dtpFechaReg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaReg.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.TxtNropedido.Focus()
        End If

    End Sub

    Private Sub czona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtctaBanca.SelectedIndexChanged

    End Sub

    Private Sub cbFuerzaVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFuerzaVenta.SelectedIndexChanged

    End Sub

    Private Sub cbFuerzaVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbFuerzaVenta.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.cbZonaVenta.Focus()
        End If

    End Sub

    Private Sub cbZonaVenta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbZonaVenta.SelectedIndexChanged

    End Sub

    Private Sub cbZonaVenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbZonaVenta.KeyPress


        If Asc(e.KeyChar) = 13 Then
            Me.cbRuta.Focus()
        End If

    End Sub

    Private Sub cbRuta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbRuta.SelectedIndexChanged

    End Sub

    Private Sub cbRuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbRuta.KeyPress

        If Asc(e.KeyChar) = 13 Then
            btnAgregar_Click(sender, e)
        End If


    End Sub

    Private Sub txtCuota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuota.TextChanged




    End Sub

    Private Sub txtCuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuota.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.dtpFecha1.Focus()
        End If


    End Sub

    Private Sub dtpFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha1.ValueChanged

    End Sub

    Private Sub dtpFecha1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha1.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.dtpFecha2.Focus()
        End If

    End Sub

    Private Sub dtpFecha2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha2.ValueChanged

    End Sub

    Private Sub dtpFecha2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFecha2.KeyPress

        If Asc(e.KeyChar) = 13 Then
            btnAñadir_Click(sender, e)
        End If

    End Sub

    Private Sub cbolinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbolinea.SelectedIndexChanged

        If ACT_EVENTOS = 1 Then
            MostrarSubCategoria()
        End If

    End Sub


    Private Sub MostrarSubCategoria()
        Dim TABLE_SUBCAT As DataTable

        TABLE_SUBCAT = TmpListarDatos("SP_SELECT_SUBLINEAxLINEA '" & codempresa.Trim & "' ,'" & cbolinea.SelectedValue & "'")
        cbosublinea.DataSource = TABLE_SUBCAT
        cbosublinea.ValueMember = "CODSUBLINEA"
        cbosublinea.DisplayMember = "DESSUBLINEA"

    End Sub

    Private Sub cbosublinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosublinea.SelectedIndexChanged

    End Sub

    Private Sub dgCuotaLinea_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgCuotaLinea.Navigate

    End Sub

    Private Sub ckActivar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckActivar.CheckedChanged

        If ckActivar.Checked = True Then
            TIPOVEND = 1
        Else
            TIPOVEND = 0
        End If



    End Sub
End Class
