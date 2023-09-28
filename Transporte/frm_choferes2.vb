'Imports AxShockwaveFlashObjects
Imports System.Data.SqlClient
Public Class frm_choferes2
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
    Friend WithEvents cciudad As System.Windows.Forms.ComboBox
    Friend WithEvents tvendedor As System.Windows.Forms.TextBox
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
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtctaBanca As System.Windows.Forms.TextBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents txt_trailer As System.Windows.Forms.TextBox
    Friend WithEvents txt_chofer As System.Windows.Forms.TextBox
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Dt_FechaReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_puntoPart As System.Windows.Forms.TextBox
    Friend WithEvents dt_fechaf As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_fechai As System.Windows.Forms.DateTimePicker
    Friend WithEvents cdistritoP As System.Windows.Forms.ComboBox
    Friend WithEvents cdepaP As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cciudP As System.Windows.Forms.ComboBox
    Friend WithEvents cbopaisP As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cdistritoL As System.Windows.Forms.ComboBox
    Friend WithEvents cdepaL As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cciudL As System.Windows.Forms.ComboBox
    Friend WithEvents cbopaisL As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPllegada As System.Windows.Forms.TextBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents ga_ultima As System.Windows.Forms.TextBox
    Friend WithEvents kr_total As System.Windows.Forms.TextBox
    Friend WithEvents KRsinCarga As System.Windows.Forms.TextBox
    Friend WithEvents KRCargador As System.Windows.Forms.TextBox
    Friend WithEvents txtCondPago As System.Windows.Forms.TextBox
    Friend WithEvents txtGuiaRemiR As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtGuiaRemiT As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_precPact As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_prodTrans As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txt_carretera As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtDistinario As System.Windows.Forms.TextBox
    Friend WithEvents btnBusq As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents btnBusqCliente As System.Windows.Forms.Button
    Friend WithEvents btnBusqCarreteras As System.Windows.Forms.Button
    Friend WithEvents btnBusqTrailer As System.Windows.Forms.Button
    Friend WithEvents btnBusqChofer As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_Cliente As System.Windows.Forms.Label
    Friend WithEvents lbl_Chofer As System.Windows.Forms.Label
    Friend WithEvents lbl_carretera As System.Windows.Forms.Label
    Friend WithEvents lbl_trailer As System.Windows.Forms.Label
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_choferes2))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtctaBanca = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtLineaCred = New System.Windows.Forms.TextBox
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
        Me.cciudad = New System.Windows.Forms.ComboBox
        Me.tvendedor = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgCuotasLinea = New System.Windows.Forms.DataGrid
        Me.cbRuta = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.cbFuerzaVenta = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
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
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btnBusqCarreteras = New System.Windows.Forms.Button
        Me.btnBusqTrailer = New System.Windows.Forms.Button
        Me.btnBusqChofer = New System.Windows.Forms.Button
        Me.btnBusqCliente = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.txt_Codigo = New System.Windows.Forms.TextBox
        Me.btnBusq = New System.Windows.Forms.Button
        Me.Label50 = New System.Windows.Forms.Label
        Me.txtDistinario = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.txt_carretera = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.cdistritoL = New System.Windows.Forms.ComboBox
        Me.cdepaL = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.cciudL = New System.Windows.Forms.ComboBox
        Me.cbopaisL = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtPllegada = New System.Windows.Forms.TextBox
        Me.cdistritoP = New System.Windows.Forms.ComboBox
        Me.cdepaP = New System.Windows.Forms.ComboBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.cciudP = New System.Windows.Forms.ComboBox
        Me.cbopaisP = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_puntoPart = New System.Windows.Forms.TextBox
        Me.dt_fechaf = New System.Windows.Forms.DateTimePicker
        Me.dt_fechai = New System.Windows.Forms.DateTimePicker
        Me.txt_trailer = New System.Windows.Forms.TextBox
        Me.txt_chofer = New System.Windows.Forms.TextBox
        Me.txt_cliente = New System.Windows.Forms.TextBox
        Me.Dt_FechaReg = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.ga_ultima = New System.Windows.Forms.TextBox
        Me.kr_total = New System.Windows.Forms.TextBox
        Me.KRsinCarga = New System.Windows.Forms.TextBox
        Me.KRCargador = New System.Windows.Forms.TextBox
        Me.txtCondPago = New System.Windows.Forms.TextBox
        Me.txtGuiaRemiR = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtGuiaRemiT = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txt_precPact = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txt_prodTrans = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.lbl_Cliente = New System.Windows.Forms.Label
        Me.lbl_Chofer = New System.Windows.Forms.Label
        Me.lbl_trailer = New System.Windows.Forms.Label
        Me.lbl_carretera = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgCuotasLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(836, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 259)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 3
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(13, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "&Eliminar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(14, 155)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 23)
        Me.btnreporte.TabIndex = 14
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(14, 128)
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
        Me.BTNCERRAR.Location = New System.Drawing.Point(14, 182)
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
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(1357, 131)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNELIMINAR.TabIndex = 12
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1646, 203)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Licencia :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtctaBanca
        '
        Me.txtctaBanca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtctaBanca.Location = New System.Drawing.Point(1704, 198)
        Me.txtctaBanca.MaxLength = 150
        Me.txtctaBanca.Name = "txtctaBanca"
        Me.txtctaBanca.Size = New System.Drawing.Size(113, 21)
        Me.txtctaBanca.TabIndex = 79
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1421, 198)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Permiso ntc :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLineaCred
        '
        Me.txtLineaCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLineaCred.Location = New System.Drawing.Point(1495, 195)
        Me.txtLineaCred.MaxLength = 150
        Me.txtLineaCred.Name = "txtLineaCred"
        Me.txtLineaCred.Size = New System.Drawing.Size(113, 21)
        Me.txtLineaCred.TabIndex = 77
        '
        'TxtNropedido
        '
        Me.TxtNropedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNropedido.Location = New System.Drawing.Point(1705, 166)
        Me.TxtNropedido.MaxLength = 150
        Me.TxtNropedido.Name = "TxtNropedido"
        Me.TxtNropedido.Size = New System.Drawing.Size(113, 21)
        Me.TxtNropedido.TabIndex = 75
        Me.TxtNropedido.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1637, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Telefono 2 : "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(1781, 114)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 24)
        Me.CheckBox1.TabIndex = 73
        Me.CheckBox1.Text = "Activo"
        '
        'dtpFechaReg
        '
        Me.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReg.Location = New System.Drawing.Point(1495, 165)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(87, 21)
        Me.dtpFechaReg.TabIndex = 71
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Location = New System.Drawing.Point(1381, 242)
        Me.txtTelefono.MaxLength = 150
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(113, 21)
        Me.txtTelefono.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1637, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Telefono 1 :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDirec
        '
        Me.txtDirec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDirec.Location = New System.Drawing.Point(1493, 90)
        Me.txtDirec.MaxLength = 150
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(357, 21)
        Me.txtDirec.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1434, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Dirección :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1425, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Fecha Reg. :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDNI
        '
        Me.txtDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDNI.Location = New System.Drawing.Point(1494, 139)
        Me.txtDNI.MaxLength = 150
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(113, 21)
        Me.txtDNI.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1450, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "D.N.I. :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cciudad
        '
        Me.cciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cciudad.Location = New System.Drawing.Point(1494, 114)
        Me.cciudad.Name = "cciudad"
        Me.cciudad.Size = New System.Drawing.Size(211, 21)
        Me.cciudad.TabIndex = 3
        '
        'tvendedor
        '
        Me.tvendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tvendedor.Location = New System.Drawing.Point(1494, 66)
        Me.tvendedor.MaxLength = 150
        Me.tvendedor.Name = "tvendedor"
        Me.tvendedor.Size = New System.Drawing.Size(357, 21)
        Me.tvendedor.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1423, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Descripcion :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1435, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Provincia :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcodigo
        '
        Me.tcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodigo.Location = New System.Drawing.Point(1494, 43)
        Me.tcodigo.MaxLength = 4
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(100, 21)
        Me.tcodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1445, 45)
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
        Me.btnbuscar.Location = New System.Drawing.Point(1597, 42)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 18
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgCuotasLinea)
        Me.GroupBox3.Controls.Add(Me.cbRuta)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnAgregar)
        Me.GroupBox3.Controls.Add(Me.btnQuitar)
        Me.GroupBox3.Location = New System.Drawing.Point(631, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(403, 169)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
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
        'cbFuerzaVenta
        '
        Me.cbFuerzaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFuerzaVenta.Location = New System.Drawing.Point(706, 282)
        Me.cbFuerzaVenta.Name = "cbFuerzaVenta"
        Me.cbFuerzaVenta.Size = New System.Drawing.Size(243, 21)
        Me.cbFuerzaVenta.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(628, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Fuerza Venta :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbZonaVenta
        '
        Me.cbZonaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbZonaVenta.Location = New System.Drawing.Point(706, 185)
        Me.cbZonaVenta.Name = "cbZonaVenta"
        Me.cbZonaVenta.Size = New System.Drawing.Size(47, 21)
        Me.cbZonaVenta.TabIndex = 52
        Me.cbZonaVenta.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(703, 157)
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
        Me.TabControl1.Size = New System.Drawing.Size(85, 350)
        Me.TabControl1.TabIndex = 22
        Me.TabControl1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ckActivar)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.cbZonaVenta)
        Me.TabPage1.Controls.Add(Me.cbFuerzaVenta)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(77, 324)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ckActivar
        '
        Me.ckActivar.Location = New System.Drawing.Point(706, 221)
        Me.ckActivar.Name = "ckActivar"
        Me.ckActivar.Size = New System.Drawing.Size(66, 24)
        Me.ckActivar.TabIndex = 74
        Me.ckActivar.Text = "Tienda"
        Me.ckActivar.Visible = False
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
        Me.TabPage2.Size = New System.Drawing.Size(77, 324)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Location = New System.Drawing.Point(8, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(822, 589)
        Me.TabControl2.TabIndex = 81
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lbl_carretera)
        Me.TabPage4.Controls.Add(Me.lbl_trailer)
        Me.TabPage4.Controls.Add(Me.lbl_Chofer)
        Me.TabPage4.Controls.Add(Me.lbl_Cliente)
        Me.TabPage4.Controls.Add(Me.btnBusqCarreteras)
        Me.TabPage4.Controls.Add(Me.btnBusqTrailer)
        Me.TabPage4.Controls.Add(Me.btnBusqChofer)
        Me.TabPage4.Controls.Add(Me.btnBusqCliente)
        Me.TabPage4.Controls.Add(Me.Label32)
        Me.TabPage4.Controls.Add(Me.txt_Codigo)
        Me.TabPage4.Controls.Add(Me.btnBusq)
        Me.TabPage4.Controls.Add(Me.Label50)
        Me.TabPage4.Controls.Add(Me.txtDistinario)
        Me.TabPage4.Controls.Add(Me.Label44)
        Me.TabPage4.Controls.Add(Me.txt_carretera)
        Me.TabPage4.Controls.Add(Me.Label43)
        Me.TabPage4.Controls.Add(Me.Label42)
        Me.TabPage4.Controls.Add(Me.Label41)
        Me.TabPage4.Controls.Add(Me.Label40)
        Me.TabPage4.Controls.Add(Me.Label35)
        Me.TabPage4.Controls.Add(Me.Label34)
        Me.TabPage4.Controls.Add(Me.Label33)
        Me.TabPage4.Controls.Add(Me.cdistritoL)
        Me.TabPage4.Controls.Add(Me.cdepaL)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.cciudL)
        Me.TabPage4.Controls.Add(Me.cbopaisL)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.txtPllegada)
        Me.TabPage4.Controls.Add(Me.cdistritoP)
        Me.TabPage4.Controls.Add(Me.cdepaP)
        Me.TabPage4.Controls.Add(Me.Label36)
        Me.TabPage4.Controls.Add(Me.Label37)
        Me.TabPage4.Controls.Add(Me.cciudP)
        Me.TabPage4.Controls.Add(Me.cbopaisP)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.txt_puntoPart)
        Me.TabPage4.Controls.Add(Me.dt_fechaf)
        Me.TabPage4.Controls.Add(Me.dt_fechai)
        Me.TabPage4.Controls.Add(Me.txt_trailer)
        Me.TabPage4.Controls.Add(Me.txt_chofer)
        Me.TabPage4.Controls.Add(Me.txt_cliente)
        Me.TabPage4.Controls.Add(Me.Dt_FechaReg)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(814, 563)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnBusqCarreteras
        '
        Me.btnBusqCarreteras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusqCarreteras.ImageIndex = 5
        Me.btnBusqCarreteras.ImageList = Me.ImageList1
        Me.btnBusqCarreteras.Location = New System.Drawing.Point(257, 162)
        Me.btnBusqCarreteras.Name = "btnBusqCarreteras"
        Me.btnBusqCarreteras.Size = New System.Drawing.Size(41, 23)
        Me.btnBusqCarreteras.TabIndex = 117
        Me.btnBusqCarreteras.Text = "..."
        Me.btnBusqCarreteras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusqTrailer
        '
        Me.btnBusqTrailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusqTrailer.ImageIndex = 5
        Me.btnBusqTrailer.ImageList = Me.ImageList1
        Me.btnBusqTrailer.Location = New System.Drawing.Point(257, 129)
        Me.btnBusqTrailer.Name = "btnBusqTrailer"
        Me.btnBusqTrailer.Size = New System.Drawing.Size(41, 23)
        Me.btnBusqTrailer.TabIndex = 116
        Me.btnBusqTrailer.Text = "..."
        Me.btnBusqTrailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusqChofer
        '
        Me.btnBusqChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusqChofer.ImageIndex = 5
        Me.btnBusqChofer.ImageList = Me.ImageList1
        Me.btnBusqChofer.Location = New System.Drawing.Point(257, 95)
        Me.btnBusqChofer.Name = "btnBusqChofer"
        Me.btnBusqChofer.Size = New System.Drawing.Size(41, 23)
        Me.btnBusqChofer.TabIndex = 115
        Me.btnBusqChofer.Text = "..."
        Me.btnBusqChofer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnBusqCliente
        '
        Me.btnBusqCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBusqCliente.ImageIndex = 5
        Me.btnBusqCliente.ImageList = Me.ImageList1
        Me.btnBusqCliente.Location = New System.Drawing.Point(257, 65)
        Me.btnBusqCliente.Name = "btnBusqCliente"
        Me.btnBusqCliente.Size = New System.Drawing.Size(41, 23)
        Me.btnBusqCliente.TabIndex = 114
        Me.btnBusqCliente.Text = "..."
        Me.btnBusqCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(73, 19)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(47, 13)
        Me.Label32.TabIndex = 113
        Me.Label32.Text = "Codigo :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(125, 16)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(108, 21)
        Me.txt_Codigo.TabIndex = 112
        '
        'btnBusq
        '
        Me.btnBusq.ImageIndex = 5
        Me.btnBusq.ImageList = Me.ImageList1
        Me.btnBusq.Location = New System.Drawing.Point(257, 14)
        Me.btnBusq.Name = "btnBusq"
        Me.btnBusq.Size = New System.Drawing.Size(32, 23)
        Me.btnBusq.TabIndex = 111
        Me.btnBusq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(39, 383)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(69, 13)
        Me.Label50.TabIndex = 110
        Me.Label50.Text = "Destinatario:"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDistinario
        '
        Me.txtDistinario.Location = New System.Drawing.Point(125, 380)
        Me.txtDistinario.Name = "txtDistinario"
        Me.txtDistinario.Size = New System.Drawing.Size(394, 21)
        Me.txtDistinario.TabIndex = 109
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(17, 161)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(100, 13)
        Me.Label44.TabIndex = 108
        Me.Label44.Text = "Vehiculo Carretera:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_carretera
        '
        Me.txt_carretera.Location = New System.Drawing.Point(128, 153)
        Me.txt_carretera.Name = "txt_carretera"
        Me.txt_carretera.Size = New System.Drawing.Size(108, 21)
        Me.txt_carretera.TabIndex = 107
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(39, 412)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(75, 13)
        Me.Label43.TabIndex = 106
        Me.Label43.Text = "Punto Llegada"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(29, 255)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(79, 13)
        Me.Label42.TabIndex = 105
        Me.Label42.Text = "Punto Partida :"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(32, 226)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(75, 13)
        Me.Label41.TabIndex = 103
        Me.Label41.Text = "Fecha Cierre :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(32, 201)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(75, 13)
        Me.Label40.TabIndex = 102
        Me.Label40.Text = "Fecha Inicio. :"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(36, 134)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(83, 13)
        Me.Label35.TabIndex = 101
        Me.Label35.Text = "Vehiculo Trailer:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(72, 102)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 13)
        Me.Label34.TabIndex = 100
        Me.Label34.Text = "Chofer :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(73, 75)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 13)
        Me.Label33.TabIndex = 99
        Me.Label33.Text = "Cliente :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cdistritoL
        '
        Me.cdistritoL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdistritoL.Location = New System.Drawing.Point(125, 515)
        Me.cdistritoL.Name = "cdistritoL"
        Me.cdistritoL.Size = New System.Drawing.Size(197, 21)
        Me.cdistritoL.TabIndex = 97
        '
        'cdepaL
        '
        Me.cdepaL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdepaL.Location = New System.Drawing.Point(125, 465)
        Me.cdepaL.Name = "cdepaL"
        Me.cdepaL.Size = New System.Drawing.Size(197, 21)
        Me.cdepaL.TabIndex = 93
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(33, 467)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 13)
        Me.Label23.TabIndex = 92
        Me.Label23.Text = "Departamento :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(68, 517)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(48, 13)
        Me.Label24.TabIndex = 96
        Me.Label24.Text = "Distrito :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cciudL
        '
        Me.cciudL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cciudL.Location = New System.Drawing.Point(125, 490)
        Me.cciudL.Name = "cciudL"
        Me.cciudL.Size = New System.Drawing.Size(197, 21)
        Me.cciudL.TabIndex = 95
        '
        'cbopaisL
        '
        Me.cbopaisL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopaisL.Location = New System.Drawing.Point(125, 442)
        Me.cbopaisL.Name = "cbopaisL"
        Me.cbopaisL.Size = New System.Drawing.Size(197, 21)
        Me.cbopaisL.TabIndex = 91
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(84, 444)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(33, 13)
        Me.Label25.TabIndex = 90
        Me.Label25.Text = "País :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(59, 492)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(57, 13)
        Me.Label26.TabIndex = 94
        Me.Label26.Text = "Provincia :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPllegada
        '
        Me.txtPllegada.Location = New System.Drawing.Point(125, 404)
        Me.txtPllegada.Name = "txtPllegada"
        Me.txtPllegada.Size = New System.Drawing.Size(394, 21)
        Me.txtPllegada.TabIndex = 89
        '
        'cdistritoP
        '
        Me.cdistritoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdistritoP.Location = New System.Drawing.Point(125, 353)
        Me.cdistritoP.Name = "cdistritoP"
        Me.cdistritoP.Size = New System.Drawing.Size(197, 21)
        Me.cdistritoP.TabIndex = 88
        '
        'cdepaP
        '
        Me.cdepaP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdepaP.Location = New System.Drawing.Point(125, 303)
        Me.cdepaP.Name = "cdepaP"
        Me.cdepaP.Size = New System.Drawing.Size(197, 21)
        Me.cdepaP.TabIndex = 84
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(33, 305)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(83, 13)
        Me.Label36.TabIndex = 83
        Me.Label36.Text = "Departamento :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(68, 355)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 13)
        Me.Label37.TabIndex = 87
        Me.Label37.Text = "Distrito :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cciudP
        '
        Me.cciudP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cciudP.Location = New System.Drawing.Point(125, 328)
        Me.cciudP.Name = "cciudP"
        Me.cciudP.Size = New System.Drawing.Size(197, 21)
        Me.cciudP.TabIndex = 86
        '
        'cbopaisP
        '
        Me.cbopaisP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopaisP.Location = New System.Drawing.Point(125, 280)
        Me.cbopaisP.Name = "cbopaisP"
        Me.cbopaisP.Size = New System.Drawing.Size(197, 21)
        Me.cbopaisP.TabIndex = 82
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(84, 282)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 13)
        Me.Label29.TabIndex = 81
        Me.Label29.Text = "País :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(59, 330)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Provincia :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_puntoPart
        '
        Me.txt_puntoPart.Location = New System.Drawing.Point(125, 255)
        Me.txt_puntoPart.Name = "txt_puntoPart"
        Me.txt_puntoPart.Size = New System.Drawing.Size(394, 21)
        Me.txt_puntoPart.TabIndex = 80
        '
        'dt_fechaf
        '
        Me.dt_fechaf.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fechaf.Location = New System.Drawing.Point(128, 220)
        Me.dt_fechaf.Name = "dt_fechaf"
        Me.dt_fechaf.Size = New System.Drawing.Size(87, 21)
        Me.dt_fechaf.TabIndex = 79
        '
        'dt_fechai
        '
        Me.dt_fechai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fechai.Location = New System.Drawing.Point(128, 193)
        Me.dt_fechai.Name = "dt_fechai"
        Me.dt_fechai.Size = New System.Drawing.Size(87, 21)
        Me.dt_fechai.TabIndex = 78
        '
        'txt_trailer
        '
        Me.txt_trailer.Location = New System.Drawing.Point(128, 126)
        Me.txt_trailer.Name = "txt_trailer"
        Me.txt_trailer.Size = New System.Drawing.Size(108, 21)
        Me.txt_trailer.TabIndex = 77
        '
        'txt_chofer
        '
        Me.txt_chofer.Location = New System.Drawing.Point(128, 97)
        Me.txt_chofer.Name = "txt_chofer"
        Me.txt_chofer.Size = New System.Drawing.Size(108, 21)
        Me.txt_chofer.TabIndex = 76
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(125, 67)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(108, 21)
        Me.txt_cliente.TabIndex = 75
        '
        'Dt_FechaReg
        '
        Me.Dt_FechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dt_FechaReg.Location = New System.Drawing.Point(125, 43)
        Me.Dt_FechaReg.Name = "Dt_FechaReg"
        Me.Dt_FechaReg.Size = New System.Drawing.Size(87, 21)
        Me.Dt_FechaReg.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(51, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Fecha Reg. :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label49)
        Me.TabPage5.Controls.Add(Me.Label48)
        Me.TabPage5.Controls.Add(Me.Label47)
        Me.TabPage5.Controls.Add(Me.Label46)
        Me.TabPage5.Controls.Add(Me.Label45)
        Me.TabPage5.Controls.Add(Me.ga_ultima)
        Me.TabPage5.Controls.Add(Me.kr_total)
        Me.TabPage5.Controls.Add(Me.KRsinCarga)
        Me.TabPage5.Controls.Add(Me.KRCargador)
        Me.TabPage5.Controls.Add(Me.txtCondPago)
        Me.TabPage5.Controls.Add(Me.txtGuiaRemiR)
        Me.TabPage5.Controls.Add(Me.Label31)
        Me.TabPage5.Controls.Add(Me.txtGuiaRemiT)
        Me.TabPage5.Controls.Add(Me.Label30)
        Me.TabPage5.Controls.Add(Me.txt_precPact)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.txt_prodTrans)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(814, 563)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(89, 351)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(92, 13)
        Me.Label49.TabIndex = 92
        Me.Label49.Text = "Galones Utilizado:"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(87, 321)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(94, 13)
        Me.Label48.TabIndex = 91
        Me.Label48.Text = "K.recorrido Total :"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(64, 278)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(117, 13)
        Me.Label47.TabIndex = 90
        Me.Label47.Text = "k.Recorrido sin Carga :"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(63, 255)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(118, 13)
        Me.Label46.TabIndex = 89
        Me.Label46.Text = "K.Recorrido Cargado. :"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(114, 199)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(67, 13)
        Me.Label45.TabIndex = 88
        Me.Label45.Text = "Cond.Pago :"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ga_ultima
        '
        Me.ga_ultima.Location = New System.Drawing.Point(187, 348)
        Me.ga_ultima.Name = "ga_ultima"
        Me.ga_ultima.Size = New System.Drawing.Size(344, 21)
        Me.ga_ultima.TabIndex = 87
        '
        'kr_total
        '
        Me.kr_total.Location = New System.Drawing.Point(187, 318)
        Me.kr_total.Name = "kr_total"
        Me.kr_total.Size = New System.Drawing.Size(344, 21)
        Me.kr_total.TabIndex = 86
        '
        'KRsinCarga
        '
        Me.KRsinCarga.Location = New System.Drawing.Point(187, 279)
        Me.KRsinCarga.Name = "KRsinCarga"
        Me.KRsinCarga.Size = New System.Drawing.Size(344, 21)
        Me.KRsinCarga.TabIndex = 85
        '
        'KRCargador
        '
        Me.KRCargador.Location = New System.Drawing.Point(187, 255)
        Me.KRCargador.Name = "KRCargador"
        Me.KRCargador.Size = New System.Drawing.Size(344, 21)
        Me.KRCargador.TabIndex = 84
        '
        'txtCondPago
        '
        Me.txtCondPago.Location = New System.Drawing.Point(187, 191)
        Me.txtCondPago.Name = "txtCondPago"
        Me.txtCondPago.Size = New System.Drawing.Size(344, 21)
        Me.txtCondPago.TabIndex = 83
        '
        'txtGuiaRemiR
        '
        Me.txtGuiaRemiR.Location = New System.Drawing.Point(187, 159)
        Me.txtGuiaRemiR.Name = "txtGuiaRemiR"
        Me.txtGuiaRemiR.Size = New System.Drawing.Size(344, 21)
        Me.txtGuiaRemiR.TabIndex = 82
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(34, 159)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(147, 13)
        Me.Label31.TabIndex = 81
        Me.Label31.Text = "Guia de Remision Remitente :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGuiaRemiT
        '
        Me.txtGuiaRemiT.Location = New System.Drawing.Point(187, 132)
        Me.txtGuiaRemiT.Name = "txtGuiaRemiT"
        Me.txtGuiaRemiT.Size = New System.Drawing.Size(344, 21)
        Me.txtGuiaRemiT.TabIndex = 80
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 130)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(165, 13)
        Me.Label30.TabIndex = 79
        Me.Label30.Text = "Guia de Remision Transportable :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_precPact
        '
        Me.txt_precPact.Location = New System.Drawing.Point(187, 47)
        Me.txt_precPact.Name = "txt_precPact"
        Me.txt_precPact.Size = New System.Drawing.Size(344, 21)
        Me.txt_precPact.TabIndex = 78
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(96, 55)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(85, 13)
        Me.Label28.TabIndex = 77
        Me.Label28.Text = "Precio Pactado :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(59, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(122, 13)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "ProductoTransportado :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_prodTrans
        '
        Me.txt_prodTrans.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txt_prodTrans.Location = New System.Drawing.Point(187, 10)
        Me.txt_prodTrans.Name = "txt_prodTrans"
        Me.txt_prodTrans.Size = New System.Drawing.Size(344, 21)
        Me.txt_prodTrans.TabIndex = 75
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(1093, 476)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(56, 21)
        Me.TextBox9.TabIndex = 0
        Me.TextBox9.Visible = False
        '
        'Label38
        '
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Location = New System.Drawing.Point(1103, 512)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(190, 20)
        Me.Label38.TabIndex = 7
        Me.Label38.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(959, 516)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(79, 13)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "SubCategoria :"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label39.Visible = False
        '
        'Button13
        '
        Me.Button13.ImageIndex = 5
        Me.Button13.ImageList = Me.ImageList1
        Me.Button13.Location = New System.Drawing.Point(1043, 474)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(44, 23)
        Me.Button13.TabIndex = 1
        Me.Button13.Visible = False
        '
        'Button1
        '
        Me.Button1.ImageIndex = 5
        Me.Button1.Location = New System.Drawing.Point(1299, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(1043, 512)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(56, 21)
        Me.TextBox6.TabIndex = 0
        Me.TextBox6.Visible = False
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Location = New System.Drawing.Point(1103, 532)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(190, 20)
        Me.Label22.TabIndex = 7
        Me.Label22.Visible = False
        '
        'lbl_Cliente
        '
        Me.lbl_Cliente.AutoSize = True
        Me.lbl_Cliente.Location = New System.Drawing.Point(304, 70)
        Me.lbl_Cliente.Name = "lbl_Cliente"
        Me.lbl_Cliente.Size = New System.Drawing.Size(169, 13)
        Me.lbl_Cliente.TabIndex = 118
        Me.lbl_Cliente.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.lbl_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Chofer
        '
        Me.lbl_Chofer.AutoSize = True
        Me.lbl_Chofer.Location = New System.Drawing.Point(304, 99)
        Me.lbl_Chofer.Name = "lbl_Chofer"
        Me.lbl_Chofer.Size = New System.Drawing.Size(175, 13)
        Me.lbl_Chofer.TabIndex = 119
        Me.lbl_Chofer.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.lbl_Chofer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_trailer
        '
        Me.lbl_trailer.AutoSize = True
        Me.lbl_trailer.Location = New System.Drawing.Point(304, 134)
        Me.lbl_trailer.Name = "lbl_trailer"
        Me.lbl_trailer.Size = New System.Drawing.Size(175, 13)
        Me.lbl_trailer.TabIndex = 120
        Me.lbl_trailer.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.lbl_trailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_carretera
        '
        Me.lbl_carretera.AutoSize = True
        Me.lbl_carretera.Location = New System.Drawing.Point(304, 167)
        Me.lbl_carretera.Name = "lbl_carretera"
        Me.lbl_carretera.Size = New System.Drawing.Size(175, 13)
        Me.lbl_carretera.TabIndex = 121
        Me.lbl_carretera.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.lbl_carretera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_choferes2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.BTNCERRAR
        Me.ClientSize = New System.Drawing.Size(995, 613)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.txtctaBanca)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtLineaCred)
        Me.Controls.Add(Me.TxtNropedido)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.dtpFechaReg)
        Me.Controls.Add(Me.tcodigo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDirec)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tvendedor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cciudad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.TextBox9)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_choferes2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Orden Servicio Propio"
        Me.GroupBox2.ResumeLayout(False)
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
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

        CAyuda.CargarDataCombo(cbopaisP, "Nsp_sel_Pais '" & codempresa & "'", "Codigo", "Descripcion")

        If Not cbopaisP.SelectedValue Is Nothing Then
            CAyuda.CargarDataCombo(cdepaP, "sele_depa '" & cbopaisP.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")

        End If


        CAyuda.CargarDataCombo(cbopaisL, "Nsp_sel_Pais '" & codempresa & "'", "Codigo", "Descripcion")

        If Not cbopaisL.SelectedValue Is Nothing Then
            CAyuda.CargarDataCombo(cdepaL, "sele_depa '" & cbopaisL.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")
        End If

    End Sub
    Sub bloquea(ByVal p As Boolean, ByVal p1 As Boolean)




        txt_Codigo.ReadOnly = p
        Dt_FechaReg.Enabled = p1
        txt_cliente.ReadOnly = p
        txt_chofer.ReadOnly = p
        txt_trailer.ReadOnly = p
        txt_carretera.ReadOnly = p
        dt_fechai.Enabled = p1
        dt_fechaf.Enabled = p1
        txt_puntoPart.ReadOnly = p
        cbopaisP.Enabled = p1
        cdepaP.Enabled = p1
        cciudP.Enabled = p1
        cdistritoP.Enabled = p1
        txtDistinario.ReadOnly = p
        txtPllegada.ReadOnly = p
        cbopaisL.Enabled = p1
        cdepaL.Enabled = p1
        cciudL.Enabled = p1
        cdistritoL.Enabled = p1
        txt_prodTrans.ReadOnly = p
        txt_precPact.ReadOnly = p
        txtGuiaRemiT.ReadOnly = p
        txtGuiaRemiR.ReadOnly = p
        txtCondPago.ReadOnly = p
        KRCargador.ReadOnly = p
        KRsinCarga.ReadOnly = p
        kr_total.ReadOnly = p
        ga_ultima.ReadOnly = p




        btnBusqCliente.Enabled = p1
        btnBusqChofer.Enabled = p1
        btnBusqTrailer.Enabled = p1
        btnBusqCarreteras.Enabled = p1


    End Sub
    Sub INICIALIZA()

        txt_Codigo.Text = ""
        Dt_FechaReg.Value = Date.Now
        txt_cliente.Text = ""
        txt_chofer.Text = ""
        txt_trailer.Text = ""
        txt_carretera.Text = ""
        dt_fechai.Value = Date.Now
        dt_fechaf.Value = Date.Now
        txt_puntoPart.Text = ""

        txtDistinario.Text = ""
        txtPllegada.Text = ""

        txt_prodTrans.Text = ""
        txt_precPact.Text = ""
        txtGuiaRemiT.Text = ""
        txtGuiaRemiR.Text = ""
        txtCondPago.Text = ""
        KRCargador.Text = ""
        KRsinCarga.Text = ""
        kr_total.Text = ""
        ga_ultima.Text = ""

    End Sub

    Sub cargadatos()
        Try
            CAyuda.CargarDataCombo(cciudad, "Nsp_Sele_Ciudad_ '" & codempresa.Trim & "'", "codciudad", "desciudad")
            'CAyuda.CargarDataCombo(txtctaBanca, "Nsp_Select_Zona '" & codempresa.Trim & "'", "codzona", "deszona")
            'CAyuda.CargarDataCombo(cptoventa, "Nsp_Sele_tdaptoventa '" & CodEmpresa & "','',''", "NROPTOVTA", "DESPTOVTA")
            'CAyuda.CargarDataCombo(cbLinea, "Nsp_sel_linea '" & CodEmpresa & "'", "codlinea", "deslinea")
            CAyuda.CargarDataCombo(cbFuerzaVenta, "SELECT * FROM FUERZAVENTA where codempresa ='" & codempresa.Trim & "'", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(cbZonaVenta, "SELECT * FROM ZONAVENTA where codempresa ='" & codempresa.Trim & "'", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(cbRuta, "SELECT * FROM RUTA where codempresa ='" & codempresa.Trim & "'", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(cbolinea, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")


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
        btnBusq.Enabled = BUSCAR

    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then

            If tcodigo.Text.Trim.Length = 0 Then
                MsgBox("Falta seleccionar un vendedor.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            'Conecta("SELECT CODCLIENTE FROM CLIENTE WHERE CODVEND='" & tcodigo.Text.Trim & "' AND CODEMPRESA = '" & codempresa & "'", "VERIFICA")
            'If ds.Tables("VERIFICA").Rows.Count > 0 Then
            '    MessageBox.Show("No puede eliminar al Vendedor ya que tiene Registros Relacionados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            Dim PROCESO As Boolean
            Dim sql As String
            sql = "nsp_dele_CHOFERES '" & tcodigo.Text & "','" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = False Then Exit Sub
            'Eliminar_Nextel()
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


        'TablaCuotaslineaVendedor = CAyuda.ListarDatos("NSP_SELECT_RUTA_VENDEDOR", codempresa.Trim, "xxxxxxxxxxxx", "%").Tables(0)
        'TablaEstiloCuotaLinea.MappingName = TablaCuotaslineaVendedor.TableName
        'TablaEstiloCuotaLinea.GridColumnStyles(0).MappingName = "CODRUTA"
        'TablaEstiloCuotaLinea.GridColumnStyles(1).MappingName = "DESCRIPCION"
        'dgCuotasLinea.TableStyles.Add(TablaEstiloCuotaLinea)
        'dgCuotasLinea.DataSource = TablaCuotaslineaVendedor

        ACT_EVENTOS = 1


    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Call formatotextbox(Me)



        If Me.txt_cliente.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar la cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_cliente.Focus()
            Exit Sub
        End If


        If Me.txt_chofer.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar la chofer", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_chofer.Focus()
            Exit Sub
        End If

        If Me.txt_trailer.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar trailer", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_trailer.Focus()
            Exit Sub
        End If

        If Me.txt_carretera.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar carretera", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_carretera.Focus()
            Exit Sub
        End If





        If Me.txt_puntoPart.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar punto de partida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_puntoPart.Focus()
            Exit Sub
        End If

        If Me.txtDistinario.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar Distinatario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDistinario.Focus()
            Exit Sub
        End If

        If Me.txtPllegada.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar Punto de llegada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPllegada.Focus()
            Exit Sub
        End If

        If Me.txt_prodTrans.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar Producto transporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_prodTrans.Focus()
            Exit Sub
        End If



        If Me.cdepaP.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar departamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cdepaP.Focus()
            Exit Sub
        End If



        If Me.cciudP.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar ciudad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cciudP.Focus()
            Exit Sub
        End If



        If Me.cdistritoP.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar distrito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cdistritoP.Focus()
            Exit Sub
        End If







        If Me.cdepaL.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar departamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cdepaL.Focus()
            Exit Sub
        End If



        If Me.cciudL.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar ciudad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cciudL.Focus()
            Exit Sub
        End If



        If Me.cdistritoL.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar distrito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cdistritoL.Focus()
            Exit Sub
        End If


        If Me.cdepaP.Text.Trim = "" Then
            MessageBox.Show("Falta ingresar departamento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cdepaP.Focus()
            Exit Sub
        End If






        If INTFLAGVEND = 0 Then
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_VERIFI_ID_SERVICIO_PROPIO", tcodigo.Text.Trim).Tables(0)
            If dt.Rows.Count > 0 Then
                MsgBox("El código ya existe.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            'sql = "NSP_ins_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.SelectedValue.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.cbFuerzaVenta.SelectedValue & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
            Dim RptaTrans As Boolean

            RptaTrans = CAyuda.Ejecutar("NSP_ins_TB_SERVICIO_PROPIO", Dt_FechaReg.Value.ToShortDateString, txt_cliente.Text, txt_chofer.Text, txt_trailer.Text, txt_carretera.Text, dt_fechai.Value.ToShortDateString, dt_fechaf.Value.ToShortDateString, txt_puntoPart.Text, cbopaisP.SelectedValue, cdepaP.SelectedValue, cciudP.SelectedValue, cdistritoP.SelectedValue, txtDistinario.Text, txtPllegada.Text, cbopaisL.SelectedValue, cdepaL.SelectedValue, cciudL.SelectedValue, cdistritoL.SelectedValue, txt_prodTrans.Text, txt_precPact.Text, txtGuiaRemiT.Text, txtGuiaRemiR.Text, txtCondPago.Text, KRCargador.Text, KRsinCarga.Text, kr_total.Text, ga_ultima.Text)
            If RptaTrans Then
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")


                'CAyuda.ListarDatos("NSP_DELETE_RUTA_VENDEDOR", codempresa, tcodigo.Text.Trim)
                'For cont1 As Integer = 0 To Me.TablaCuotaslineaVendedor.Rows.Count - 1
                '    CAyuda.Ejecutar("NSP_INSERT_RUTA_VENDEDOR", codempresa, tcodigo.Text.Trim, TablaCuotaslineaVendedor.Rows(cont1)(0))
                'Next
                'Guardar_Nextel()

                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)

                Bloqueatextbox(Me)
                Call bloquea(True, False)
            End If
        End If


        If INTFLAGVEND = 1 Then
            Dim RptaTrans As Boolean
            RptaTrans = CAyuda.Ejecutar("NSP_UPD_TB_SERVICIO_PROPIO", CInt(txt_Codigo.Text.Trim), Dt_FechaReg.Value.ToShortDateString, txt_cliente.Text, txt_chofer.Text, txt_trailer.Text, txt_carretera.Text, dt_fechai.Value.ToShortDateString, dt_fechaf.Value.ToShortDateString, txt_puntoPart.Text, cbopaisP.SelectedValue, cdepaP.SelectedValue, cciudP.SelectedValue, cdistritoP.SelectedValue, txtDistinario.Text, txtPllegada.Text, cbopaisL.SelectedValue, cdepaL.SelectedValue, cciudL.SelectedValue, cdistritoL.SelectedValue, txt_prodTrans.Text, txt_precPact.Text, txtGuiaRemiT.Text, txtGuiaRemiR.Text, txtCondPago.Text, KRCargador.Text, KRsinCarga.Text, kr_total.Text, ga_ultima.Text)
            'sql = "NSP_upd_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.SelectedValue.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.cbFuerzaVenta.SelectedValue & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
            If RptaTrans Then
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")



                'CAyuda.ListarDatos("NSP_DELETE_RUTA_VENDEDOR", codempresa, tcodigo.Text.Trim)
                'For cont1 As Integer = 0 To Me.TablaCuotaslineaVendedor.Rows.Count - 1
                '    CAyuda.Ejecutar("NSP_INSERT_RUTA_VENDEDOR", codempresa, tcodigo.Text.Trim, TablaCuotaslineaVendedor.Rows(cont1)(0))
                'Next
                'Guardar_Nextel()


                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)

                Bloqueatextbox(Me)
                Call bloquea(True, False)
            End If
        End If



        'Limp_Grid()
        'Me.TablaCuotaslineaVendedor.Rows.Clear()
        'Me.dgCuotasLinea.DataSource = TablaCuotaslineaVendedor

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

    Private Sub czona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

            crRpt.ReportFileName = rutareporte & "Reporte_ServicioPropio.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            'crRpt.set_StoredProcParam(0, codempresa)
            'crRpt.set_Formulas(1, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            'crRpt.set_Formulas(0, "Usuario='" & dt.Rows(0)(1).ToString & "'")
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

    Private Sub czona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub txtLineaCred_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLineaCred.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub cdepa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdepaP.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cciudP, "Nsp_select_Ciudad_combo2 '" & cbopaisP.SelectedValue.ToString & "','" & cdepaP.SelectedValue.ToString & "'", "Codigo", "Descripcion")

        Catch x As Exception
        End Try
    End Sub

    Private Sub cciud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cciudP.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cdistritoP, "Nsp_select_distrito '" & cbopaisP.SelectedValue.ToString & "','" & cdepaP.SelectedValue.ToString & "','" & cciudP.SelectedValue.ToString & "'", "Codigo", "Descripcion")
        Catch x As Exception
        End Try
    End Sub

    Private Sub cdistrito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdistritoP.SelectedIndexChanged

    End Sub

    Private Sub cbopaisP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopaisP.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cdepaP, "sele_depa '" & cbopaisP.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")
        Catch x As Exception
        End Try
    End Sub

    Private Sub cbopaisL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopaisL.SelectedIndexChanged

        Try
            CAyuda.CargarDataCombo(cdepaL, "sele_depa '" & cbopaisL.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")
        Catch x As Exception
        End Try


    End Sub

    Private Sub cdepaL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdepaL.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cciudL, "Nsp_select_Ciudad_combo2 '" & cbopaisL.SelectedValue.ToString & "','" & cdepaL.SelectedValue.ToString & "'", "Codigo", "Descripcion")

        Catch x As Exception
        End Try
    End Sub

    Private Sub cciudL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cciudL.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cdistritoL, "Nsp_select_distrito '" & cbopaisP.SelectedValue.ToString & "','" & cdepaP.SelectedValue.ToString & "','" & cciudP.SelectedValue.ToString & "'", "Codigo", "Descripcion")
        Catch x As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusq.Click

        Call BOTONES(True, False, True, True, True)
        Call Bloqueatextbox(Me)

        Dim FRMX As New FRM_GRIDSV
        FRMX.vie = Me
        FRMX.bol = True
        FRMX.ShowDialog()

        tcodigo.ReadOnly = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqCliente.Click
        Dim FrmBusClie As New FrmBuscClientePrincipalTrans
        FrmBusClie.ShowDialog()
        If FrmBusClie.DEVOLVER = False Then
            Exit Sub
        End If
        txt_cliente.Text = FrmBusClie.GridCli.Item(FrmBusClie.GridCli.CurrentRowIndex, 0)
        lbl_Cliente.Text = FrmBusClie.GridCli.Item(FrmBusClie.GridCli.CurrentRowIndex, 1)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqChofer.Click
        Dim FRMX As New FRM_GRIDCHO
        FRMX.vie1 = Me
        FRMX.bol = False
        FRMX.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqTrailer.Click
        Dim FRMX As New FRM_GRIDvehi
        FRMX.vie1 = Me
        FRMX.bol = False
        FRMX.ShowDialog()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusqCarreteras.Click
        Dim FRMX As New FRM_GRIDCarre
        FRMX.vie1 = Me
        FRMX.bol = False
        FRMX.ShowDialog()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then

            If txt_Codigo.Text.Trim.Length = 0 Then
                MsgBox("Falta seleccionar un SERVICIO_PROPIO  .", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            'Conecta("SELECT CODCLIENTE FROM CLIENTE WHERE CODVEND='" & tcodigo.Text.Trim & "' AND CODEMPRESA = '" & codempresa & "'", "VERIFICA")
            'If ds.Tables("VERIFICA").Rows.Count > 0 Then
            '    MessageBox.Show("No puede eliminar al Vendedor ya que tiene Registros Relacionados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            Dim PROCESO As Boolean
            Dim sql As String
            sql = "nsp_dele_SERVICIO_PROPIO '" & txt_Codigo.Text & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = False Then Exit Sub
            'Eliminar_Nextel()
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

    Private Sub txt_precPact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precPact.KeyPress
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

    Private Sub txt_precPact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_precPact.TextChanged

    End Sub

    Private Sub KRCargador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles KRCargador.KeyPress
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

    Private Sub KRCargador_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KRCargador.TextChanged

    End Sub

    Private Sub KRsinCarga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles KRsinCarga.KeyPress
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

    Private Sub KRsinCarga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KRsinCarga.TextChanged

    End Sub

    Private Sub kr_total_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kr_total.KeyPress
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

    Private Sub kr_total_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kr_total.TextChanged

    End Sub

    Private Sub ga_ultima_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ga_ultima.KeyPress
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

    Private Sub ga_ultima_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ga_ultima.TextChanged

    End Sub

    Private Sub cdistritoL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdistritoL.SelectedIndexChanged

    End Sub

    Private Sub lbl_Chofer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Chofer.Click

    End Sub
End Class
