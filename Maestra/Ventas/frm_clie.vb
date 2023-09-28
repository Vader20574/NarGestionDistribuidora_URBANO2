Imports System.Data.SqlClient
Public Class frm_clie
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tpaterno As System.Windows.Forms.TextBox
    Friend WithEvents tmaterno As System.Windows.Forms.TextBox
    Friend WithEvents tnombre As System.Windows.Forms.TextBox
    Friend WithEvents trazon As System.Windows.Forms.TextBox
    Friend WithEvents ctipoclie As System.Windows.Forms.ComboBox
    Friend WithEvents tdni As System.Windows.Forms.TextBox
    Friend WithEvents truc As System.Windows.Forms.TextBox
    Friend WithEvents tdireccion As System.Windows.Forms.TextBox
    Friend WithEvents ttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtctaBanca As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tctaventa As System.Windows.Forms.TextBox
    Friend WithEvents tctaanticipo As System.Windows.Forms.TextBox
    Friend WithEvents tctaletra As System.Windows.Forms.TextBox
    Friend WithEvents tdescuento As System.Windows.Forms.TextBox
    Friend WithEvents tsaldo As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tmail As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ctipopago As System.Windows.Forms.ComboBox
    Friend WithEvents CmbForPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbmoneda As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbopais As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtcontacto As System.Windows.Forms.TextBox
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txttelefonoc As System.Windows.Forms.TextBox
    Friend WithEvents txtcelularc As System.Windows.Forms.TextBox
    Friend WithEvents txtemailc As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cdepa As System.Windows.Forms.ComboBox
    Friend WithEvents cdistrito As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox

    Friend WithEvents tcredito As System.Windows.Forms.TextBox
    Friend WithEvents cciud As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CboTipoNegocio As System.Windows.Forms.ComboBox
    Friend WithEvents CboTipoprecio As System.Windows.Forms.ComboBox
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents DSDIREC1111 As System.Windows.Forms.ColumnHeader
    Friend WithEvents DSRUTA1111 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CODCLI As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cbFuerzaVta As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TablaEstiloFV As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODFV As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESFV As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LIMITECRE As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SALDO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgMatrizFuerzas As System.Windows.Forms.DataGrid
    Friend WithEvents btnAgregarF As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscDep As System.Windows.Forms.Button
    Friend WithEvents TxtCodDep As System.Windows.Forms.TextBox
    Friend WithEvents TxtRucDep As System.Windows.Forms.TextBox
    Friend WithEvents TxtRzSocialDep As System.Windows.Forms.TextBox
    Friend WithEvents TxtDirecDep As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CboRutaLlegada As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDirecLleg As System.Windows.Forms.TextBox
    Friend WithEvents BtnQuitPtoLleg As System.Windows.Forms.Button
    Friend WithEvents BtnAgregPtoLleg As System.Windows.Forms.Button
    Friend WithEvents GridPtoLleg As System.Windows.Forms.DataGrid
    Friend WithEvents BtnQuitDep As System.Windows.Forms.Button
    Friend WithEvents BtnAgregDep As System.Windows.Forms.Button
    Friend WithEvents GridCliDep As System.Windows.Forms.DataGrid
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents TxtTotSaldoDisp As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cmbdist As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cmbciudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents cmbcalle__ As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcall__ As System.Windows.Forms.ComboBox
    Friend WithEvents CboRutaDep As System.Windows.Forms.ComboBox
    Friend WithEvents ChkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtMPercepcion As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TxtLineaUtilidad As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TxtTotLimCred As System.Windows.Forms.TextBox
    Friend WithEvents ck_Nota_Pedido As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents chkOr As System.Windows.Forms.CheckBox
    Friend WithEvents ck_ort As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents TxtPedidoUtilizado As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents TxtTotSaldoDisp2 As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents TxtDniDep As System.Windows.Forms.TextBox
    Friend WithEvents tnombreD As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents tmaternoM As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents tpaternoD As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CboSegClient As System.Windows.Forms.ComboBox
    Friend WithEvents CboCatClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_No As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Si As System.Windows.Forms.RadioButton
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txt_Cordenadas_Y As System.Windows.Forms.TextBox
    Friend WithEvents txt_Cordenadas_X As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents txtDiasVisita As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents ChkMartes As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLunes As System.Windows.Forms.CheckBox
    Friend WithEvents ChkViernes As System.Windows.Forms.CheckBox
    Friend WithEvents ChkJueves As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMiercoles As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSabado As System.Windows.Forms.CheckBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents ChkActivoClientDep As CheckBox
    Friend WithEvents DataGridBoolColumn3 As DataGridBoolColumn
    Friend WithEvents comboRuta As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_clie))
        Me.tctaventa = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tctaanticipo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tctaletra = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tdescuento = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tsaldo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtctaBanca = New System.Windows.Forms.ComboBox()
        Me.ttelefono = New System.Windows.Forms.TextBox()
        Me.tdireccion = New System.Windows.Forms.TextBox()
        Me.truc = New System.Windows.Forms.TextBox()
        Me.tdni = New System.Windows.Forms.TextBox()
        Me.ctipoclie = New System.Windows.Forms.ComboBox()
        Me.trazon = New System.Windows.Forms.TextBox()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.tmaterno = New System.Windows.Forms.TextBox()
        Me.tpaterno = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.ChkDomingo = New System.Windows.Forms.CheckBox()
        Me.ChkSabado = New System.Windows.Forms.CheckBox()
        Me.ChkViernes = New System.Windows.Forms.CheckBox()
        Me.ChkJueves = New System.Windows.Forms.CheckBox()
        Me.ChkMiercoles = New System.Windows.Forms.CheckBox()
        Me.ChkMartes = New System.Windows.Forms.CheckBox()
        Me.ChkLunes = New System.Windows.Forms.CheckBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txt_Cordenadas_Y = New System.Windows.Forms.TextBox()
        Me.txt_Cordenadas_X = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_No = New System.Windows.Forms.RadioButton()
        Me.rb_Si = New System.Windows.Forms.RadioButton()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.CboSegClient = New System.Windows.Forms.ComboBox()
        Me.CboCatClient = New System.Windows.Forms.ComboBox()
        Me.chkOr = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ChkActivo = New System.Windows.Forms.CheckBox()
        Me.comboRuta = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cdistrito = New System.Windows.Forms.ComboBox()
        Me.cdepa = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtfax = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cciud = New System.Windows.Forms.ComboBox()
        Me.cbopais = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tmail = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CboTipoNegocio = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CboTipoprecio = New System.Windows.Forms.ComboBox()
        Me.cmbcalle__ = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ChkActivoClientDep = New System.Windows.Forms.CheckBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TxtDniDep = New System.Windows.Forms.TextBox()
        Me.ck_ort = New System.Windows.Forms.CheckBox()
        Me.ck_Nota_Pedido = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtMPercepcion = New System.Windows.Forms.TextBox()
        Me.cmbcall__ = New System.Windows.Forms.ComboBox()
        Me.cmbdist = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cmbciudad = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.BtnQuitDep = New System.Windows.Forms.Button()
        Me.TxtCodDep = New System.Windows.Forms.TextBox()
        Me.BtnBuscDep = New System.Windows.Forms.Button()
        Me.TxtRucDep = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtRzSocialDep = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.CboRutaDep = New System.Windows.Forms.ComboBox()
        Me.GridCliDep = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.GridPtoLleg = New System.Windows.Forms.DataGrid()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtDirecDep = New System.Windows.Forms.TextBox()
        Me.BtnAgregDep = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TxtTotSaldoDisp2 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TxtPedidoUtilizado = New System.Windows.Forms.TextBox()
        Me.TxtTotLimCred = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TxtLineaUtilidad = New System.Windows.Forms.TextBox()
        Me.TxtTotSaldoDisp = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbFuerzaVta = New System.Windows.Forms.ComboBox()
        Me.tcredito = New System.Windows.Forms.TextBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregarF = New System.Windows.Forms.Button()
        Me.dgMatrizFuerzas = New System.Windows.Forms.DataGrid()
        Me.TablaEstiloFV = New System.Windows.Forms.DataGridTableStyle()
        Me.CODFV = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DESFV = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.LIMITECRE = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SALDO = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtemailc = New System.Windows.Forms.TextBox()
        Me.txtcelularc = New System.Windows.Forms.TextBox()
        Me.txttelefonoc = New System.Windows.Forms.TextBox()
        Me.txtcontacto = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmbmoneda = New System.Windows.Forms.ComboBox()
        Me.CmbForPago = New System.Windows.Forms.ComboBox()
        Me.ctipopago = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnQuitPtoLleg = New System.Windows.Forms.Button()
        Me.BtnAgregPtoLleg = New System.Windows.Forms.Button()
        Me.CboRutaLlegada = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TxtDirecLleg = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtDiasVisita = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.tnombreD = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.tmaternoM = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.tpaternoD = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rpt1 = New AxCrystal.AxCrystalReport()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GridCliDep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPtoLleg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgMatrizFuerzas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tctaventa
        '
        Me.tctaventa.Location = New System.Drawing.Point(190, 66)
        Me.tctaventa.MaxLength = 15
        Me.tctaventa.Name = "tctaventa"
        Me.tctaventa.Size = New System.Drawing.Size(100, 21)
        Me.tctaventa.TabIndex = 5
        Me.tctaventa.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(119, 66)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Cta Venta :"
        Me.Label21.Visible = False
        '
        'tctaanticipo
        '
        Me.tctaanticipo.Location = New System.Drawing.Point(190, 42)
        Me.tctaanticipo.MaxLength = 15
        Me.tctaanticipo.Name = "tctaanticipo"
        Me.tctaanticipo.Size = New System.Drawing.Size(100, 21)
        Me.tctaanticipo.TabIndex = 3
        Me.tctaanticipo.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(108, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Cta Anticipo :"
        Me.Label20.Visible = False
        '
        'tctaletra
        '
        Me.tctaletra.Location = New System.Drawing.Point(190, 18)
        Me.tctaletra.MaxLength = 15
        Me.tctaletra.Name = "tctaletra"
        Me.tctaletra.Size = New System.Drawing.Size(100, 21)
        Me.tctaletra.TabIndex = 1
        Me.tctaletra.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(123, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Cta Letra :"
        Me.Label19.Visible = False
        '
        'tdescuento
        '
        Me.tdescuento.Location = New System.Drawing.Point(144, 228)
        Me.tdescuento.MaxLength = 8
        Me.tdescuento.Name = "tdescuento"
        Me.tdescuento.Size = New System.Drawing.Size(97, 21)
        Me.tdescuento.TabIndex = 19
        Me.tdescuento.Text = "0"
        Me.tdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(79, 230)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Descuento :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsaldo
        '
        Me.tsaldo.Location = New System.Drawing.Point(109, 84)
        Me.tsaldo.MaxLength = 9
        Me.tsaldo.Name = "tsaldo"
        Me.tsaldo.ReadOnly = True
        Me.tsaldo.Size = New System.Drawing.Size(98, 21)
        Me.tsaldo.TabIndex = 5
        Me.tsaldo.Text = "0.00"
        Me.tsaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Saldo Disponible :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Límite de Crédito :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtctaBanca
        '
        Me.txtctaBanca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtctaBanca.Location = New System.Drawing.Point(344, 209)
        Me.txtctaBanca.Name = "txtctaBanca"
        Me.txtctaBanca.Size = New System.Drawing.Size(197, 21)
        Me.txtctaBanca.TabIndex = 34
        Me.txtctaBanca.Visible = False
        '
        'ttelefono
        '
        Me.ttelefono.Location = New System.Drawing.Point(123, 163)
        Me.ttelefono.MaxLength = 18
        Me.ttelefono.Name = "ttelefono"
        Me.ttelefono.Size = New System.Drawing.Size(100, 21)
        Me.ttelefono.TabIndex = 19
        '
        'tdireccion
        '
        Me.tdireccion.Location = New System.Drawing.Point(123, 139)
        Me.tdireccion.MaxLength = 40
        Me.tdireccion.Name = "tdireccion"
        Me.tdireccion.Size = New System.Drawing.Size(400, 21)
        Me.tdireccion.TabIndex = 18
        '
        'truc
        '
        Me.truc.Location = New System.Drawing.Point(290, 115)
        Me.truc.MaxLength = 18
        Me.truc.Name = "truc"
        Me.truc.Size = New System.Drawing.Size(100, 21)
        Me.truc.TabIndex = 15
        '
        'tdni
        '
        Me.tdni.Location = New System.Drawing.Point(123, 112)
        Me.tdni.MaxLength = 8
        Me.tdni.Name = "tdni"
        Me.tdni.Size = New System.Drawing.Size(100, 21)
        Me.tdni.TabIndex = 13
        '
        'ctipoclie
        '
        Me.ctipoclie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipoclie.Location = New System.Drawing.Point(1066, 398)
        Me.ctipoclie.Name = "ctipoclie"
        Me.ctipoclie.Size = New System.Drawing.Size(123, 21)
        Me.ctipoclie.TabIndex = 7
        Me.ctipoclie.Visible = False
        '
        'trazon
        '
        Me.trazon.Location = New System.Drawing.Point(123, 85)
        Me.trazon.MaxLength = 150
        Me.trazon.Name = "trazon"
        Me.trazon.Size = New System.Drawing.Size(400, 21)
        Me.trazon.TabIndex = 11
        '
        'tnombre
        '
        Me.tnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnombre.Location = New System.Drawing.Point(123, 58)
        Me.tnombre.MaxLength = 30
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(400, 21)
        Me.tnombre.TabIndex = 9
        '
        'tmaterno
        '
        Me.tmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tmaterno.Location = New System.Drawing.Point(378, 32)
        Me.tmaterno.MaxLength = 30
        Me.tmaterno.Name = "tmaterno"
        Me.tmaterno.Size = New System.Drawing.Size(144, 21)
        Me.tmaterno.TabIndex = 7
        '
        'tpaterno
        '
        Me.tpaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tpaterno.Location = New System.Drawing.Point(123, 32)
        Me.tpaterno.MaxLength = 30
        Me.tpaterno.Name = "tpaterno"
        Me.tpaterno.Size = New System.Drawing.Size(144, 21)
        Me.tpaterno.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(56, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Teléfono :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(245, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "RUC :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(341, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Almacen :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(53, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Dirección :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Nombres :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Apell Paterno :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(295, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Apell Materno :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Razón Social :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "DNI :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Provincia :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Cliente :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo Pago :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcodigo
        '
        Me.tcodigo.Location = New System.Drawing.Point(123, 8)
        Me.tcodigo.MaxLength = 8
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(100, 21)
        Me.tcodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(956, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 283)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'Button4
        '
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageIndex = 11
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(15, 237)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "&Reporte2"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 27)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(15, 154)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 23)
        Me.btnreporte.TabIndex = 5
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(15, 127)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCANCELAR.TabIndex = 4
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(15, 181)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCERRAR.TabIndex = 6
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(15, 73)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNMODIFICAR.TabIndex = 2
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(15, 100)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(15, 19)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(82, 23)
        Me.BTNNUEVO.TabIndex = 0
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(15, 46)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.ItemSize = New System.Drawing.Size(120, 18)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(942, 456)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label69)
        Me.TabPage1.Controls.Add(Me.ChkDomingo)
        Me.TabPage1.Controls.Add(Me.ChkSabado)
        Me.TabPage1.Controls.Add(Me.ChkViernes)
        Me.TabPage1.Controls.Add(Me.ChkJueves)
        Me.TabPage1.Controls.Add(Me.ChkMiercoles)
        Me.TabPage1.Controls.Add(Me.ChkMartes)
        Me.TabPage1.Controls.Add(Me.ChkLunes)
        Me.TabPage1.Controls.Add(Me.Label62)
        Me.TabPage1.Controls.Add(Me.Label61)
        Me.TabPage1.Controls.Add(Me.txt_Cordenadas_Y)
        Me.TabPage1.Controls.Add(Me.txt_Cordenadas_X)
        Me.TabPage1.Controls.Add(Me.Label60)
        Me.TabPage1.Controls.Add(Me.txtObservacion)
        Me.TabPage1.Controls.Add(Me.Label59)
        Me.TabPage1.Controls.Add(Me.Label58)
        Me.TabPage1.Controls.Add(Me.txtCantidad)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.Label57)
        Me.TabPage1.Controls.Add(Me.Label56)
        Me.TabPage1.Controls.Add(Me.Label55)
        Me.TabPage1.Controls.Add(Me.CboSegClient)
        Me.TabPage1.Controls.Add(Me.CboCatClient)
        Me.TabPage1.Controls.Add(Me.chkOr)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ChkActivo)
        Me.TabPage1.Controls.Add(Me.comboRuta)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.cdistrito)
        Me.TabPage1.Controls.Add(Me.cdepa)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.Label37)
        Me.TabPage1.Controls.Add(Me.txtfax)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.cciud)
        Me.TabPage1.Controls.Add(Me.cbopais)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.tmail)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.ttelefono)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.btnbuscar)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.tcodigo)
        Me.TabPage1.Controls.Add(Me.txtctaBanca)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.trazon)
        Me.TabPage1.Controls.Add(Me.tdireccion)
        Me.TabPage1.Controls.Add(Me.tdni)
        Me.TabPage1.Controls.Add(Me.tnombre)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.tmaterno)
        Me.TabPage1.Controls.Add(Me.tpaterno)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.truc)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.CboTipoNegocio)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.CboTipoprecio)
        Me.TabPage1.Controls.Add(Me.cmbcalle__)
        Me.TabPage1.Controls.Add(Me.Label44)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(934, 430)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(635, 172)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(72, 13)
        Me.Label69.TabIndex = 79
        Me.Label69.Text = "Día de Visita :"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label69.Visible = False
        '
        'ChkDomingo
        '
        Me.ChkDomingo.AutoSize = True
        Me.ChkDomingo.Location = New System.Drawing.Point(710, 268)
        Me.ChkDomingo.Name = "ChkDomingo"
        Me.ChkDomingo.Size = New System.Drawing.Size(67, 17)
        Me.ChkDomingo.TabIndex = 78
        Me.ChkDomingo.Text = "Domingo"
        Me.ChkDomingo.UseVisualStyleBackColor = True
        '
        'ChkSabado
        '
        Me.ChkSabado.AutoSize = True
        Me.ChkSabado.Location = New System.Drawing.Point(710, 253)
        Me.ChkSabado.Name = "ChkSabado"
        Me.ChkSabado.Size = New System.Drawing.Size(62, 17)
        Me.ChkSabado.TabIndex = 77
        Me.ChkSabado.Text = "Sabado"
        Me.ChkSabado.UseVisualStyleBackColor = True
        '
        'ChkViernes
        '
        Me.ChkViernes.AutoSize = True
        Me.ChkViernes.Location = New System.Drawing.Point(710, 237)
        Me.ChkViernes.Name = "ChkViernes"
        Me.ChkViernes.Size = New System.Drawing.Size(61, 17)
        Me.ChkViernes.TabIndex = 76
        Me.ChkViernes.Text = "Viernes"
        Me.ChkViernes.UseVisualStyleBackColor = True
        '
        'ChkJueves
        '
        Me.ChkJueves.AutoSize = True
        Me.ChkJueves.Location = New System.Drawing.Point(710, 221)
        Me.ChkJueves.Name = "ChkJueves"
        Me.ChkJueves.Size = New System.Drawing.Size(60, 17)
        Me.ChkJueves.TabIndex = 75
        Me.ChkJueves.Text = "Jueves"
        Me.ChkJueves.UseVisualStyleBackColor = True
        '
        'ChkMiercoles
        '
        Me.ChkMiercoles.AutoSize = True
        Me.ChkMiercoles.Location = New System.Drawing.Point(710, 204)
        Me.ChkMiercoles.Name = "ChkMiercoles"
        Me.ChkMiercoles.Size = New System.Drawing.Size(70, 17)
        Me.ChkMiercoles.TabIndex = 74
        Me.ChkMiercoles.Text = "Miercoles"
        Me.ChkMiercoles.UseVisualStyleBackColor = True
        '
        'ChkMartes
        '
        Me.ChkMartes.AutoSize = True
        Me.ChkMartes.Location = New System.Drawing.Point(710, 188)
        Me.ChkMartes.Name = "ChkMartes"
        Me.ChkMartes.Size = New System.Drawing.Size(59, 17)
        Me.ChkMartes.TabIndex = 73
        Me.ChkMartes.Text = "Martes"
        Me.ChkMartes.UseVisualStyleBackColor = True
        '
        'ChkLunes
        '
        Me.ChkLunes.AutoSize = True
        Me.ChkLunes.Location = New System.Drawing.Point(710, 172)
        Me.ChkLunes.Name = "ChkLunes"
        Me.ChkLunes.Size = New System.Drawing.Size(54, 17)
        Me.ChkLunes.TabIndex = 72
        Me.ChkLunes.Text = "Lunes"
        Me.ChkLunes.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(779, 127)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(13, 13)
        Me.Label62.TabIndex = 64
        Me.Label62.Text = "Y"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(726, 127)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(13, 13)
        Me.Label61.TabIndex = 63
        Me.Label61.Text = "X"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Cordenadas_Y
        '
        Me.txt_Cordenadas_Y.Location = New System.Drawing.Point(763, 143)
        Me.txt_Cordenadas_Y.Name = "txt_Cordenadas_Y"
        Me.txt_Cordenadas_Y.Size = New System.Drawing.Size(49, 21)
        Me.txt_Cordenadas_Y.TabIndex = 62
        '
        'txt_Cordenadas_X
        '
        Me.txt_Cordenadas_X.Location = New System.Drawing.Point(710, 143)
        Me.txt_Cordenadas_X.Name = "txt_Cordenadas_X"
        Me.txt_Cordenadas_X.Size = New System.Drawing.Size(49, 21)
        Me.txt_Cordenadas_X.TabIndex = 61
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(635, 146)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(72, 13)
        Me.Label60.TabIndex = 60
        Me.Label60.Text = "Cordenadas :"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(710, 105)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(137, 21)
        Me.txtObservacion.TabIndex = 59
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(633, 108)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(74, 13)
        Me.Label59.TabIndex = 58
        Me.Label59.Text = "Observacion :"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(650, 82)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(57, 13)
        Me.Label58.TabIndex = 57
        Me.Label58.Text = "Cantidad :"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(710, 79)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(137, 21)
        Me.txtCantidad.TabIndex = 56
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_No)
        Me.GroupBox4.Controls.Add(Me.rb_Si)
        Me.GroupBox4.Location = New System.Drawing.Point(705, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(76, 54)
        Me.GroupBox4.TabIndex = 55
        Me.GroupBox4.TabStop = False
        '
        'rb_No
        '
        Me.rb_No.AutoSize = True
        Me.rb_No.Location = New System.Drawing.Point(21, 32)
        Me.rb_No.Name = "rb_No"
        Me.rb_No.Size = New System.Drawing.Size(38, 17)
        Me.rb_No.TabIndex = 1
        Me.rb_No.TabStop = True
        Me.rb_No.Text = "No"
        Me.rb_No.UseVisualStyleBackColor = True
        '
        'rb_Si
        '
        Me.rb_Si.AutoSize = True
        Me.rb_Si.Location = New System.Drawing.Point(21, 11)
        Me.rb_Si.Name = "rb_Si"
        Me.rb_Si.Size = New System.Drawing.Size(33, 17)
        Me.rb_Si.TabIndex = 0
        Me.rb_Si.TabStop = True
        Me.rb_Si.Text = "Si"
        Me.rb_Si.UseVisualStyleBackColor = True
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(628, 29)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(74, 13)
        Me.Label57.TabIndex = 54
        Me.Label57.Text = "#Visicoolers  :"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(351, 343)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(113, 13)
        Me.Label56.TabIndex = 52
        Me.Label56.Text = "Segmento de Cliente :"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(351, 299)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(112, 13)
        Me.Label55.TabIndex = 51
        Me.Label55.Text = "Categoria de Cliente :"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboSegClient
        '
        Me.CboSegClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSegClient.Location = New System.Drawing.Point(354, 361)
        Me.CboSegClient.Name = "CboSegClient"
        Me.CboSegClient.Size = New System.Drawing.Size(197, 21)
        Me.CboSegClient.TabIndex = 50
        '
        'CboCatClient
        '
        Me.CboCatClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCatClient.Location = New System.Drawing.Point(354, 317)
        Me.CboCatClient.Name = "CboCatClient"
        Me.CboCatClient.Size = New System.Drawing.Size(197, 21)
        Me.CboCatClient.TabIndex = 49
        '
        'chkOr
        '
        Me.chkOr.Location = New System.Drawing.Point(534, 114)
        Me.chkOr.Name = "chkOr"
        Me.chkOr.Size = New System.Drawing.Size(91, 18)
        Me.chkOr.TabIndex = 48
        Me.chkOr.Text = "Obs Reparto"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(739, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 31)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Foto 2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(739, 322)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 100)
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(557, 322)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 101)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(557, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 31)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Foto 1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ChkActivo
        '
        Me.ChkActivo.Location = New System.Drawing.Point(418, 115)
        Me.ChkActivo.Name = "ChkActivo"
        Me.ChkActivo.Size = New System.Drawing.Size(91, 18)
        Me.ChkActivo.TabIndex = 43
        Me.ChkActivo.Text = "Activo"
        '
        'comboRuta
        '
        Me.comboRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboRuta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboRuta.ItemHeight = 13
        Me.comboRuta.Location = New System.Drawing.Point(123, 366)
        Me.comboRuta.Name = "comboRuta"
        Me.comboRuta.Size = New System.Drawing.Size(197, 21)
        Me.comboRuta.TabIndex = 40
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(45, 368)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(70, 13)
        Me.Label38.TabIndex = 39
        Me.Label38.Text = "Ruta - Calle :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(48, 401)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(91, 18)
        Me.CheckBox2.TabIndex = 16
        Me.CheckBox2.Text = "Empleado"
        Me.CheckBox2.Visible = False
        '
        'cdistrito
        '
        Me.cdistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdistrito.Location = New System.Drawing.Point(123, 285)
        Me.cdistrito.Name = "cdistrito"
        Me.cdistrito.Size = New System.Drawing.Size(197, 21)
        Me.cdistrito.TabIndex = 32
        '
        'cdepa
        '
        Me.cdepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdepa.Location = New System.Drawing.Point(123, 235)
        Me.cdepa.Name = "cdepa"
        Me.cdepa.Size = New System.Drawing.Size(197, 21)
        Me.cdepa.TabIndex = 28
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(31, 237)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(83, 13)
        Me.Label36.TabIndex = 27
        Me.Label36.Text = "Departamento :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(66, 287)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 13)
        Me.Label37.TabIndex = 31
        Me.Label37.Text = "Distrito :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtfax
        '
        Me.txtfax.Location = New System.Drawing.Point(285, 162)
        Me.txtfax.MaxLength = 20
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(206, 21)
        Me.txtfax.TabIndex = 22
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(243, 164)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(35, 13)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "Fax : "
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Red
        Me.CheckBox1.Location = New System.Drawing.Point(277, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(184, 16)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Cliente con Razón Social"
        Me.CheckBox1.Visible = False
        '
        'cciud
        '
        Me.cciud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cciud.Location = New System.Drawing.Point(123, 260)
        Me.cciud.Name = "cciud"
        Me.cciud.Size = New System.Drawing.Size(197, 21)
        Me.cciud.TabIndex = 30
        '
        'cbopais
        '
        Me.cbopais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbopais.Location = New System.Drawing.Point(123, 212)
        Me.cbopais.Name = "cbopais"
        Me.cbopais.Size = New System.Drawing.Size(197, 21)
        Me.cbopais.TabIndex = 26
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(82, 214)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 13)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "País :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmail
        '
        Me.tmail.Location = New System.Drawing.Point(123, 187)
        Me.tmail.MaxLength = 30
        Me.tmail.Name = "tmail"
        Me.tmail.Size = New System.Drawing.Size(400, 21)
        Me.tmail.TabIndex = 24
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(72, 189)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 13)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "Email :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(227, 7)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(22, 313)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Tipo de Negocio :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboTipoNegocio
        '
        Me.CboTipoNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoNegocio.Location = New System.Drawing.Point(123, 311)
        Me.CboTipoNegocio.Name = "CboTipoNegocio"
        Me.CboTipoNegocio.Size = New System.Drawing.Size(197, 21)
        Me.CboTipoNegocio.TabIndex = 36
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(31, 341)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 13)
        Me.Label23.TabIndex = 37
        Me.Label23.Text = "Lista de Precio :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboTipoprecio
        '
        Me.CboTipoprecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoprecio.Location = New System.Drawing.Point(123, 339)
        Me.CboTipoprecio.Name = "CboTipoprecio"
        Me.CboTipoprecio.Size = New System.Drawing.Size(196, 21)
        Me.CboTipoprecio.TabIndex = 38
        '
        'cmbcalle__
        '
        Me.cmbcalle__.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcalle__.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcalle__.ItemHeight = 13
        Me.cmbcalle__.Location = New System.Drawing.Point(167, 400)
        Me.cmbcalle__.Name = "cmbcalle__"
        Me.cmbcalle__.Size = New System.Drawing.Size(197, 21)
        Me.cmbcalle__.TabIndex = 42
        Me.cmbcalle__.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(123, 402)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(37, 13)
        Me.Label44.TabIndex = 41
        Me.Label44.Text = "Calle :"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label44.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ChkActivoClientDep)
        Me.TabPage4.Controls.Add(Me.Label51)
        Me.TabPage4.Controls.Add(Me.TxtDniDep)
        Me.TabPage4.Controls.Add(Me.ck_ort)
        Me.TabPage4.Controls.Add(Me.ck_Nota_Pedido)
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.Label47)
        Me.TabPage4.Controls.Add(Me.txtMPercepcion)
        Me.TabPage4.Controls.Add(Me.cmbcall__)
        Me.TabPage4.Controls.Add(Me.cmbdist)
        Me.TabPage4.Controls.Add(Me.Label45)
        Me.TabPage4.Controls.Add(Me.cmbciudad)
        Me.TabPage4.Controls.Add(Me.Label46)
        Me.TabPage4.Controls.Add(Me.BtnQuitDep)
        Me.TabPage4.Controls.Add(Me.TxtCodDep)
        Me.TabPage4.Controls.Add(Me.BtnBuscDep)
        Me.TabPage4.Controls.Add(Me.TxtRucDep)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.TxtRzSocialDep)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.CboRutaDep)
        Me.TabPage4.Controls.Add(Me.GridCliDep)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.TxtDirecDep)
        Me.TabPage4.Controls.Add(Me.BtnAgregDep)
        Me.TabPage4.Controls.Add(Me.Label28)
        Me.TabPage4.Controls.Add(Me.Label39)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(934, 430)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Clientes Dependientes"
        '
        'ChkActivoClientDep
        '
        Me.ChkActivoClientDep.Location = New System.Drawing.Point(379, 115)
        Me.ChkActivoClientDep.Name = "ChkActivoClientDep"
        Me.ChkActivoClientDep.Size = New System.Drawing.Size(91, 18)
        Me.ChkActivoClientDep.TabIndex = 52
        Me.ChkActivoClientDep.Text = "Activo"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(288, 35)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(35, 13)
        Me.Label51.TabIndex = 51
        Me.Label51.Text = "DNI : "
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDniDep
        '
        Me.TxtDniDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDniDep.Location = New System.Drawing.Point(326, 31)
        Me.TxtDniDep.MaxLength = 8
        Me.TxtDniDep.Name = "TxtDniDep"
        Me.TxtDniDep.Size = New System.Drawing.Size(119, 21)
        Me.TxtDniDep.TabIndex = 50
        '
        'ck_ort
        '
        Me.ck_ort.Location = New System.Drawing.Point(685, 138)
        Me.ck_ort.Name = "ck_ort"
        Me.ck_ort.Size = New System.Drawing.Size(91, 18)
        Me.ck_ort.TabIndex = 49
        Me.ck_ort.Text = "Obs Reparto"
        '
        'ck_Nota_Pedido
        '
        Me.ck_Nota_Pedido.AutoSize = True
        Me.ck_Nota_Pedido.Location = New System.Drawing.Point(582, 139)
        Me.ck_Nota_Pedido.Name = "ck_Nota_Pedido"
        Me.ck_Nota_Pedido.Size = New System.Drawing.Size(84, 17)
        Me.ck_Nota_Pedido.TabIndex = 22
        Me.ck_Nota_Pedido.Text = "Nota Pedido"
        Me.ck_Nota_Pedido.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(786, 93)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 24)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "&Modificar"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(376, 169)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(69, 13)
        Me.Label47.TabIndex = 20
        Me.Label47.Text = "Percepcion  :"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMPercepcion
        '
        Me.txtMPercepcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMPercepcion.Location = New System.Drawing.Point(453, 166)
        Me.txtMPercepcion.Name = "txtMPercepcion"
        Me.txtMPercepcion.Size = New System.Drawing.Size(153, 21)
        Me.txtMPercepcion.TabIndex = 19
        Me.txtMPercepcion.Text = "0"
        '
        'cmbcall__
        '
        Me.cmbcall__.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcall__.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcall__.ItemHeight = 13
        Me.cmbcall__.Location = New System.Drawing.Point(379, 136)
        Me.cmbcall__.Name = "cmbcall__"
        Me.cmbcall__.Size = New System.Drawing.Size(197, 21)
        Me.cmbcall__.TabIndex = 15
        Me.cmbcall__.Visible = False
        '
        'cmbdist
        '
        Me.cmbdist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdist.Location = New System.Drawing.Point(131, 139)
        Me.cmbdist.Name = "cmbdist"
        Me.cmbdist.Size = New System.Drawing.Size(197, 21)
        Me.cmbdist.TabIndex = 17
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(79, 141)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 13)
        Me.Label45.TabIndex = 16
        Me.Label45.Text = "Distrito :"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbciudad
        '
        Me.cmbciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbciudad.Location = New System.Drawing.Point(130, 112)
        Me.cmbciudad.Name = "cmbciudad"
        Me.cmbciudad.Size = New System.Drawing.Size(197, 21)
        Me.cmbciudad.TabIndex = 14
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(71, 114)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(57, 13)
        Me.Label46.TabIndex = 13
        Me.Label46.Text = "Provincia :"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnQuitDep
        '
        Me.BtnQuitDep.Enabled = False
        Me.BtnQuitDep.Location = New System.Drawing.Point(786, 63)
        Me.BtnQuitDep.Name = "BtnQuitDep"
        Me.BtnQuitDep.Size = New System.Drawing.Size(100, 24)
        Me.BtnQuitDep.TabIndex = 10
        Me.BtnQuitDep.Text = "&Quitar"
        '
        'TxtCodDep
        '
        Me.TxtCodDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodDep.Location = New System.Drawing.Point(394, 6)
        Me.TxtCodDep.Name = "TxtCodDep"
        Me.TxtCodDep.Size = New System.Drawing.Size(130, 21)
        Me.TxtCodDep.TabIndex = 0
        Me.TxtCodDep.Visible = False
        '
        'BtnBuscDep
        '
        Me.BtnBuscDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscDep.ImageIndex = 5
        Me.BtnBuscDep.ImageList = Me.ImageList1
        Me.BtnBuscDep.Location = New System.Drawing.Point(535, 5)
        Me.BtnBuscDep.Name = "BtnBuscDep"
        Me.BtnBuscDep.Size = New System.Drawing.Size(41, 23)
        Me.BtnBuscDep.TabIndex = 1
        Me.BtnBuscDep.Text = "..."
        Me.BtnBuscDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscDep.Visible = False
        '
        'TxtRucDep
        '
        Me.TxtRucDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRucDep.Location = New System.Drawing.Point(131, 33)
        Me.TxtRucDep.MaxLength = 18
        Me.TxtRucDep.Name = "TxtRucDep"
        Me.TxtRucDep.Size = New System.Drawing.Size(119, 21)
        Me.TxtRucDep.TabIndex = 4
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(84, 36)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 13)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "R.U.C. : "
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtRzSocialDep
        '
        Me.TxtRzSocialDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtRzSocialDep.Location = New System.Drawing.Point(131, 60)
        Me.TxtRzSocialDep.MaxLength = 40
        Me.TxtRzSocialDep.Name = "TxtRzSocialDep"
        Me.TxtRzSocialDep.Size = New System.Drawing.Size(328, 21)
        Me.TxtRzSocialDep.TabIndex = 6
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(55, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 13)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Razon Social :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboRutaDep
        '
        Me.CboRutaDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRutaDep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRutaDep.ItemHeight = 13
        Me.CboRutaDep.Location = New System.Drawing.Point(132, 166)
        Me.CboRutaDep.Name = "CboRutaDep"
        Me.CboRutaDep.Size = New System.Drawing.Size(195, 21)
        Me.CboRutaDep.TabIndex = 12
        '
        'GridCliDep
        '
        Me.GridCliDep.CaptionVisible = False
        Me.GridCliDep.DataMember = ""
        Me.GridCliDep.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridCliDep.Location = New System.Drawing.Point(5, 202)
        Me.GridCliDep.Name = "GridCliDep"
        Me.GridCliDep.ReadOnly = True
        Me.GridCliDep.Size = New System.Drawing.Size(922, 195)
        Me.GridCliDep.TabIndex = 18
        Me.GridCliDep.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridCliDep
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridBoolColumn1, Me.DataGridBoolColumn2, Me.DataGridTextBoxColumn5, Me.DataGridBoolColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'GridPtoLleg
        '
        Me.GridPtoLleg.CaptionText = "                 Seleccionar= Enter  ----- Eliminar [F3]"
        Me.GridPtoLleg.DataMember = ""
        Me.GridPtoLleg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridPtoLleg.Location = New System.Drawing.Point(17, 118)
        Me.GridPtoLleg.Name = "GridPtoLleg"
        Me.GridPtoLleg.ReadOnly = True
        Me.GridPtoLleg.Size = New System.Drawing.Size(562, 195)
        Me.GridPtoLleg.TabIndex = 6
        Me.GridPtoLleg.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CodigoOO"
        Me.DataGridTextBoxColumn1.MappingName = "CODCLIENTE"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Dependiente"
        Me.DataGridTextBoxColumn2.MappingName = "DATOADJUNTO"
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Direccion"
        Me.DataGridTextBoxColumn3.MappingName = "DIRECCION"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "ruc"
        Me.DataGridTextBoxColumn4.MappingName = "ruc"
        Me.DataGridTextBoxColumn4.Width = 180
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.HeaderText = "NP"
        Me.DataGridBoolColumn1.MappingName = "NOTAPEDIDO"
        Me.DataGridBoolColumn1.Width = 75
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.MappingName = "ORT"
        Me.DataGridBoolColumn2.NullText = "ORT"
        Me.DataGridBoolColumn2.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "dni"
        Me.DataGridTextBoxColumn5.MappingName = "dni"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridBoolColumn3
        '
        Me.DataGridBoolColumn3.MappingName = "ESTADO"
        Me.DataGridBoolColumn3.NullText = "EST"
        Me.DataGridBoolColumn3.Width = 75
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(57, 167)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 13)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Ruta - Calle :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDirecDep
        '
        Me.TxtDirecDep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDirecDep.Location = New System.Drawing.Point(130, 85)
        Me.TxtDirecDep.Name = "TxtDirecDep"
        Me.TxtDirecDep.Size = New System.Drawing.Size(328, 21)
        Me.TxtDirecDep.TabIndex = 9
        '
        'BtnAgregDep
        '
        Me.BtnAgregDep.Location = New System.Drawing.Point(786, 33)
        Me.BtnAgregDep.Name = "BtnAgregDep"
        Me.BtnAgregDep.Size = New System.Drawing.Size(100, 24)
        Me.BtnAgregDep.TabIndex = 7
        Me.BtnAgregDep.Text = "&Agregar"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(69, 87)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 13)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Direccion  :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(333, 6)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(55, 13)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "CodDep : "
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label39.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label50)
        Me.TabPage2.Controls.Add(Me.TxtTotSaldoDisp2)
        Me.TabPage2.Controls.Add(Me.Label49)
        Me.TabPage2.Controls.Add(Me.TxtPedidoUtilizado)
        Me.TabPage2.Controls.Add(Me.TxtTotLimCred)
        Me.TabPage2.Controls.Add(Me.Label48)
        Me.TabPage2.Controls.Add(Me.TxtLineaUtilidad)
        Me.TabPage2.Controls.Add(Me.TxtTotSaldoDisp)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.txtemailc)
        Me.TabPage2.Controls.Add(Me.txtcelularc)
        Me.TabPage2.Controls.Add(Me.txttelefonoc)
        Me.TabPage2.Controls.Add(Me.txtcontacto)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.Label32)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.cmbmoneda)
        Me.TabPage2.Controls.Add(Me.tdescuento)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.CmbForPago)
        Me.TabPage2.Controls.Add(Me.ctipopago)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Controls.Add(Me.Label43)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(934, 430)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Datos Comerciales"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(312, 211)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(127, 13)
        Me.Label50.TabIndex = 27
        Me.Label50.Text = "Total Saldo Disponible 2 :"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTotSaldoDisp2
        '
        Me.TxtTotSaldoDisp2.Enabled = False
        Me.TxtTotSaldoDisp2.Location = New System.Drawing.Point(445, 208)
        Me.TxtTotSaldoDisp2.MaxLength = 8
        Me.TxtTotSaldoDisp2.Name = "TxtTotSaldoDisp2"
        Me.TxtTotSaldoDisp2.Size = New System.Drawing.Size(97, 21)
        Me.TxtTotSaldoDisp2.TabIndex = 26
        Me.TxtTotSaldoDisp2.Text = "0"
        Me.TxtTotSaldoDisp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(577, 181)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(74, 13)
        Me.Label49.TabIndex = 25
        Me.Label49.Text = "Linea Pedido :"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPedidoUtilizado
        '
        Me.TxtPedidoUtilizado.Enabled = False
        Me.TxtPedidoUtilizado.Location = New System.Drawing.Point(665, 175)
        Me.TxtPedidoUtilizado.MaxLength = 8
        Me.TxtPedidoUtilizado.Name = "TxtPedidoUtilizado"
        Me.TxtPedidoUtilizado.Size = New System.Drawing.Size(97, 21)
        Me.TxtPedidoUtilizado.TabIndex = 24
        Me.TxtPedidoUtilizado.Text = "0"
        Me.TxtPedidoUtilizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotLimCred
        '
        Me.TxtTotLimCred.Enabled = False
        Me.TxtTotLimCred.Location = New System.Drawing.Point(143, 177)
        Me.TxtTotLimCred.MaxLength = 9
        Me.TxtTotLimCred.Name = "TxtTotLimCred"
        Me.TxtTotLimCred.Size = New System.Drawing.Size(97, 21)
        Me.TxtTotLimCred.TabIndex = 23
        Me.TxtTotLimCred.Text = "0"
        Me.TxtTotLimCred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(357, 183)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(82, 13)
        Me.Label48.TabIndex = 22
        Me.Label48.Text = "Linea Utilizada :"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtLineaUtilidad
        '
        Me.TxtLineaUtilidad.Enabled = False
        Me.TxtLineaUtilidad.Location = New System.Drawing.Point(445, 177)
        Me.TxtLineaUtilidad.MaxLength = 8
        Me.TxtLineaUtilidad.Name = "TxtLineaUtilidad"
        Me.TxtLineaUtilidad.Size = New System.Drawing.Size(97, 21)
        Me.TxtLineaUtilidad.TabIndex = 21
        Me.TxtLineaUtilidad.Text = "0"
        Me.TxtLineaUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTotSaldoDisp
        '
        Me.TxtTotSaldoDisp.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTotSaldoDisp.Enabled = False
        Me.TxtTotSaldoDisp.Location = New System.Drawing.Point(143, 202)
        Me.TxtTotSaldoDisp.MaxLength = 9
        Me.TxtTotSaldoDisp.Name = "TxtTotSaldoDisp"
        Me.TxtTotSaldoDisp.Size = New System.Drawing.Size(98, 21)
        Me.TxtTotSaldoDisp.TabIndex = 17
        Me.TxtTotSaldoDisp.Text = "0.00"
        Me.TxtTotSaldoDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.cbFuerzaVta)
        Me.GroupBox3.Controls.Add(Me.tcredito)
        Me.GroupBox3.Controls.Add(Me.tsaldo)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.btnQuitar)
        Me.GroupBox3.Controls.Add(Me.btnAgregarF)
        Me.GroupBox3.Controls.Add(Me.dgMatrizFuerzas)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(585, 155)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fuerzas de Venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fuerza Vta."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbFuerzaVta
        '
        Me.cbFuerzaVta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFuerzaVta.Location = New System.Drawing.Point(75, 24)
        Me.cbFuerzaVta.Name = "cbFuerzaVta"
        Me.cbFuerzaVta.Size = New System.Drawing.Size(145, 21)
        Me.cbFuerzaVta.TabIndex = 1
        '
        'tcredito
        '
        Me.tcredito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcredito.Location = New System.Drawing.Point(109, 65)
        Me.tcredito.Name = "tcredito"
        Me.tcredito.Size = New System.Drawing.Size(100, 21)
        Me.tcredito.TabIndex = 3
        Me.tcredito.Text = "0.00"
        Me.tcredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(116, 120)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 28)
        Me.btnQuitar.TabIndex = 7
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAgregarF
        '
        Me.btnAgregarF.Location = New System.Drawing.Point(37, 120)
        Me.btnAgregarF.Name = "btnAgregarF"
        Me.btnAgregarF.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregarF.TabIndex = 6
        Me.btnAgregarF.Text = "Agregar"
        '
        'dgMatrizFuerzas
        '
        Me.dgMatrizFuerzas.DataMember = ""
        Me.dgMatrizFuerzas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMatrizFuerzas.Location = New System.Drawing.Point(231, 25)
        Me.dgMatrizFuerzas.Name = "dgMatrizFuerzas"
        Me.dgMatrizFuerzas.ReadOnly = True
        Me.dgMatrizFuerzas.Size = New System.Drawing.Size(346, 125)
        Me.dgMatrizFuerzas.TabIndex = 8
        Me.dgMatrizFuerzas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloFV})
        '
        'TablaEstiloFV
        '
        Me.TablaEstiloFV.DataGrid = Me.dgMatrizFuerzas
        Me.TablaEstiloFV.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODFV, Me.DESFV, Me.LIMITECRE, Me.SALDO})
        Me.TablaEstiloFV.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloFV.ReadOnly = True
        '
        'CODFV
        '
        Me.CODFV.Format = ""
        Me.CODFV.FormatInfo = Nothing
        Me.CODFV.Width = 0
        '
        'DESFV
        '
        Me.DESFV.Format = ""
        Me.DESFV.FormatInfo = Nothing
        Me.DESFV.HeaderText = "Fuerza Vta."
        Me.DESFV.Width = 120
        '
        'LIMITECRE
        '
        Me.LIMITECRE.Format = ""
        Me.LIMITECRE.FormatInfo = Nothing
        Me.LIMITECRE.HeaderText = "Límite Crédito"
        Me.LIMITECRE.Width = 75
        '
        'SALDO
        '
        Me.SALDO.Format = ""
        Me.SALDO.FormatInfo = Nothing
        Me.SALDO.HeaderText = "Saldo Disp."
        Me.SALDO.Width = 75
        '
        'txtemailc
        '
        Me.txtemailc.Location = New System.Drawing.Point(144, 79)
        Me.txtemailc.MaxLength = 50
        Me.txtemailc.Name = "txtemailc"
        Me.txtemailc.Size = New System.Drawing.Size(290, 21)
        Me.txtemailc.TabIndex = 7
        '
        'txtcelularc
        '
        Me.txtcelularc.Location = New System.Drawing.Point(144, 55)
        Me.txtcelularc.MaxLength = 20
        Me.txtcelularc.Name = "txtcelularc"
        Me.txtcelularc.Size = New System.Drawing.Size(144, 21)
        Me.txtcelularc.TabIndex = 5
        '
        'txttelefonoc
        '
        Me.txttelefonoc.Location = New System.Drawing.Point(144, 31)
        Me.txttelefonoc.MaxLength = 20
        Me.txttelefonoc.Name = "txttelefonoc"
        Me.txttelefonoc.Size = New System.Drawing.Size(144, 21)
        Me.txttelefonoc.TabIndex = 3
        '
        'txtcontacto
        '
        Me.txtcontacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcontacto.Location = New System.Drawing.Point(144, 7)
        Me.txtcontacto.MaxLength = 80
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(292, 21)
        Me.txtcontacto.TabIndex = 1
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(102, 81)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 13)
        Me.Label31.TabIndex = 6
        Me.Label31.Text = "Email :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(92, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 13)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "Celular  :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(86, 32)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(56, 13)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "Telefono :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(86, 8)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(58, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Contacto :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbmoneda
        '
        Me.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmoneda.ItemHeight = 13
        Me.cmbmoneda.Location = New System.Drawing.Point(143, 151)
        Me.cmbmoneda.Name = "cmbmoneda"
        Me.cmbmoneda.Size = New System.Drawing.Size(192, 21)
        Me.cmbmoneda.TabIndex = 13
        '
        'CmbForPago
        '
        Me.CmbForPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbForPago.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbForPago.ItemHeight = 13
        Me.CmbForPago.Location = New System.Drawing.Point(143, 127)
        Me.CmbForPago.Name = "CmbForPago"
        Me.CmbForPago.Size = New System.Drawing.Size(192, 21)
        Me.CmbForPago.TabIndex = 10
        '
        'ctipopago
        '
        Me.ctipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipopago.Location = New System.Drawing.Point(143, 103)
        Me.ctipopago.Name = "ctipopago"
        Me.ctipopago.Size = New System.Drawing.Size(192, 21)
        Me.ctipopago.TabIndex = 8
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(33, 180)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(106, 13)
        Me.Label42.TabIndex = 14
        Me.Label42.Text = "Total Limite Crédito :"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(20, 206)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(118, 13)
        Me.Label43.TabIndex = 16
        Me.Label43.Text = "Total Saldo Disponible :"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Forma Pago :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(92, 152)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(52, 13)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Moneda :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BtnQuitPtoLleg)
        Me.TabPage3.Controls.Add(Me.GridPtoLleg)
        Me.TabPage3.Controls.Add(Me.BtnAgregPtoLleg)
        Me.TabPage3.Controls.Add(Me.CboRutaLlegada)
        Me.TabPage3.Controls.Add(Me.Label40)
        Me.TabPage3.Controls.Add(Me.TxtDirecLleg)
        Me.TabPage3.Controls.Add(Me.Label41)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(934, 430)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Punto de Llegada"
        '
        'BtnQuitPtoLleg
        '
        Me.BtnQuitPtoLleg.Location = New System.Drawing.Point(484, 69)
        Me.BtnQuitPtoLleg.Name = "BtnQuitPtoLleg"
        Me.BtnQuitPtoLleg.Size = New System.Drawing.Size(100, 24)
        Me.BtnQuitPtoLleg.TabIndex = 5
        Me.BtnQuitPtoLleg.Text = "&Quitar"
        '
        'BtnAgregPtoLleg
        '
        Me.BtnAgregPtoLleg.Location = New System.Drawing.Point(484, 37)
        Me.BtnAgregPtoLleg.Name = "BtnAgregPtoLleg"
        Me.BtnAgregPtoLleg.Size = New System.Drawing.Size(100, 24)
        Me.BtnAgregPtoLleg.TabIndex = 1
        Me.BtnAgregPtoLleg.Text = "&Agregar"
        '
        'CboRutaLlegada
        '
        Me.CboRutaLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRutaLlegada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboRutaLlegada.ItemHeight = 13
        Me.CboRutaLlegada.Location = New System.Drawing.Point(113, 67)
        Me.CboRutaLlegada.Name = "CboRutaLlegada"
        Me.CboRutaLlegada.Size = New System.Drawing.Size(288, 21)
        Me.CboRutaLlegada.TabIndex = 4
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(76, 69)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(37, 13)
        Me.Label40.TabIndex = 3
        Me.Label40.Text = "Ruta :"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDirecLleg
        '
        Me.TxtDirecLleg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDirecLleg.Location = New System.Drawing.Point(112, 41)
        Me.TxtDirecLleg.Name = "TxtDirecLleg"
        Me.TxtDirecLleg.Size = New System.Drawing.Size(358, 21)
        Me.TxtDirecLleg.TabIndex = 2
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(14, 43)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(94, 13)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "Direccion llegada :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(1139, 216)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(162, 13)
        Me.Label68.TabIndex = 71
        Me.Label68.Text = "ejemplo Lunes Martes y Viernes:"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label68.Visible = False
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(1307, 242)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(70, 13)
        Me.Label66.TabIndex = 70
        Me.Label66.Text = "L M M J V S D"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label66.Visible = False
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(1307, 255)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(70, 13)
        Me.Label67.TabIndex = 69
        Me.Label67.Text = "1 0 1 0 1 0 1 "
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label67.Visible = False
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(1304, 206)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(73, 13)
        Me.Label65.TabIndex = 68
        Me.Label65.Text = "L M M J V S D "
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label65.Visible = False
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(1304, 221)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(70, 13)
        Me.Label64.TabIndex = 67
        Me.Label64.Text = "1 1 1 1 1 1 1 "
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label64.Visible = False
        '
        'txtDiasVisita
        '
        Me.txtDiasVisita.Location = New System.Drawing.Point(1247, 286)
        Me.txtDiasVisita.MaxLength = 7
        Me.txtDiasVisita.Name = "txtDiasVisita"
        Me.txtDiasVisita.Size = New System.Drawing.Size(137, 21)
        Me.txtDiasVisita.TabIndex = 66
        Me.txtDiasVisita.Visible = False
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(1175, 294)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(72, 13)
        Me.Label63.TabIndex = 65
        Me.Label63.Text = "Día de Visita :"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label63.Visible = False
        '
        'tnombreD
        '
        Me.tnombreD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnombreD.Location = New System.Drawing.Point(1240, 147)
        Me.tnombreD.MaxLength = 30
        Me.tnombreD.Name = "tnombreD"
        Me.tnombreD.Size = New System.Drawing.Size(144, 21)
        Me.tnombreD.TabIndex = 57
        Me.tnombreD.Visible = False
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(1180, 150)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(56, 13)
        Me.Label54.TabIndex = 56
        Me.Label54.Text = "Nombres :"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label54.Visible = False
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(1157, 125)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(80, 13)
        Me.Label53.TabIndex = 54
        Me.Label53.Text = "Apell Materno :"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label53.Visible = False
        '
        'tmaternoM
        '
        Me.tmaternoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tmaternoM.Location = New System.Drawing.Point(1240, 123)
        Me.tmaternoM.MaxLength = 30
        Me.tmaternoM.Name = "tmaternoM"
        Me.tmaternoM.Size = New System.Drawing.Size(144, 21)
        Me.tmaternoM.TabIndex = 55
        Me.tmaternoM.Visible = False
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(1157, 101)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(78, 13)
        Me.Label52.TabIndex = 52
        Me.Label52.Text = "Apell Paterno :"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label52.Visible = False
        '
        'tpaternoD
        '
        Me.tpaternoD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tpaternoD.Location = New System.Drawing.Point(1240, 97)
        Me.tpaternoD.MaxLength = 30
        Me.tpaternoD.Name = "tpaternoD"
        Me.tpaternoD.Size = New System.Drawing.Size(144, 21)
        Me.tpaternoD.TabIndex = 53
        Me.tpaternoD.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tctaanticipo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tctaletra)
        Me.GroupBox1.Controls.Add(Me.tctaventa)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(653, 359)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(62, 54)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(1139, 316)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 2
        '
        'frm_clie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.BTNCERRAR
        Me.ClientSize = New System.Drawing.Size(1348, 614)
        Me.Controls.Add(Me.tnombreD)
        Me.Controls.Add(Me.ctipoclie)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Rpt1)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tmaternoM)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.tpaternoD)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.txtDiasVisita)
        Me.Controls.Add(Me.Label63)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_clie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Clientes"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.GridCliDep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPtoLleg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgMatrizFuerzas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables Form"
    Dim FLAG, AINTOP As Integer
    Dim pb_agregar As Boolean
    Dim cod As New ArrayList
    Dim correl As Boolean
    Public MontoCred As Double
    Private Ruc As Boolean

    Dim tipopago As String
    Public ASTRCODCLI As String
    Dim clientvarios As String
    Public TablaDircli As New DataTable

    Public dTablaFuerzaVenta As New DataTable
    Private VarEditarFv As Boolean = False
    Private TMP_PTOLLEGAD As New DataTable
    Private TMP_CLIDEP As New DataTable
    Private HabiliTabPages As Boolean

    Dim rutaimagen As String = "" 'Para tener la ruta de la imagen


    Dim rutaimagen2 As String = "" 'Para tener la ruta de la imagen


    Dim COOLER As Integer



#End Region
#Region "Funciones Form"
    Private Function ValidarCamposAguardar() As Boolean
        Dim Valor As Boolean = True

        If cciud.Text = "" Then
            MessageBox.Show("SELECIONE CIUDAD  ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Valor = False
        End If
        If tdni.Text.Trim <> "" Then
            If Len(tdni.Text.Trim) < 8 Then
                MessageBox.Show("complete los digitos para el DNI del cliente  ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Valor = False
            End If

            If Len(tdni.Text.Trim) > 8 Then
                MessageBox.Show("los digitos para el DNI SOBRE PASAN del cliente  ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Valor = False
            End If
        End If
        If truc.Text.Trim <> "" Then
            If Len(truc.Text.Trim) < 11 Then
                MessageBox.Show("complete los digitos para el ruc del cliente  ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Valor = False
            End If
        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'If tcredito.Text.Trim = "" Then
        '    tcredito.Text = 0
        '    Valor = False
        'ElseIf tdescuento.Text.Trim = "" Then
        '    tdescuento.Text = 0
        'End If


        If truc.Text.Trim <> "" Then
            Call FACT_GValidaRUC(Me.truc.Text)
            If Ruc = False Then
                Valor = False
            End If
        End If
        Return Valor

    End Function






    Private Function ValidarCamposAguardarDep() As Boolean
        Dim Valor As Boolean = True

        If TxtDniDep.Text.Trim <> "" Then
            If Len(TxtDniDep.Text.Trim) < 8 Then
                MessageBox.Show("complete los digitos para el DNI del cliente  ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Valor = False
            End If

            If Len(TxtDniDep.Text.Trim) > 8 Then
                MessageBox.Show("los digitos para el DNI SOBRE PASAN del cliente  ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Valor = False
            End If
        End If
        If TxtRucDep.Text.Trim <> "" Then
            If Len(TxtRucDep.Text.Trim) < 11 Then
                MessageBox.Show("complete los digitos para el ruc del cliente  ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Valor = False
            End If
        End If


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'If tcredito.Text.Trim = "" Then
        '    tcredito.Text = 0
        '    Valor = False
        'ElseIf tdescuento.Text.Trim = "" Then
        '    tdescuento.Text = 0
        'End If


        If TxtRucDep.Text.Trim <> "" Then
            Valor = FACT_GValidaRUC(Me.TxtRucDep.Text)
        End If

        Return Valor

    End Function

    Private Sub BuscarCliente()
        'Dim FrmBusClie As New frm_gridclie1
        'FrmBusClie.ShowDialog()
        Dim FrmBusClie As New FrmBuscClientePrincipal
        FrmBusClie.ShowDialog()
        If FrmBusClie.DEVOLVER = False Then
            Exit Sub
        End If
        VAR1 = FrmBusClie.GridCli.Item(FrmBusClie.GridCli.CurrentRowIndex, 0)


        Dim TB_BUSQCLIDEP As DataTable

        TB_BUSQCLIDEP = TmpListarDatos("BUSQ_CLIDEP '" & codempresa & "','" & VAR1 & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then
            VAR1 = TB_BUSQCLIDEP.Rows(0)(1).ToString()
        End If

        Conecta("SP_TraerClienteMaest '" & codempresa & "','" & VAR1 & "','" & CodUsuario & "'", "pa")

        If ds.Tables("pa").Rows.Count > 0 Then
            ASTRCODCLI = VAR1
            tcodigo.Text = VAR1

            tmaterno.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(1)))
            tpaterno.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(2)))
            tnombre.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(3)))
            trazon.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(4)))
            tdni.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(5)))
            tdescuento.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(9)))
            tctaanticipo.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(9)))
            tctaletra.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(10)))
            tctaanticipo.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(11)))
            tctaventa.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(12)))
            ttelefono.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(15)))
            truc.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(16)))
            tdireccion.Text = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(17)))
            ctipopago.SelectedValue = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(18)))
            '   ctipoclie.SelectedValue = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(19)))
            cbopais.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(26))
            cdepa.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(28))
            cciud.SelectedValue = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(20)))
            txtctaBanca.SelectedValue = Trim(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(23)))
            CmbForPago.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(24))
            cmbmoneda.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(25))
            cdistrito.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(27))
            tmail.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(30))
            txtcontacto.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(31))
            txttelefonoc.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(32))
            txtcelularc.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(33))
            txtemailc.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(34))
            txtfax.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("FAXCLIENTE"))
            CboCatClient.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("CodCatCliente"))
            CboSegClient.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("CODSegCliente"))

            COOLER = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("Visicoolers"))

            If COOLER = 1 Then
                rb_Si.Checked = True
            Else
                rb_Si.Checked = False
            End If
            txtCantidad.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("Cantidad"))
            txtObservacion.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("Observacion"))
            txt_Cordenadas_X.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("CoordenadasX"))
            txt_Cordenadas_Y.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("CoordenadasY"))


            txtDiasVisita.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("DiasVisita"))

            Dim lunes As String
            Dim martes As String
            Dim miercoles As String
            Dim jueves As String
            Dim viernes As String
            Dim sabado As String
            Dim domingo As String

            If Mid(txtDiasVisita.Text, 1, 1) = "" Then
                lunes = 0
            Else
                lunes = Mid(txtDiasVisita.Text, 1, 1)
            End If

            If Mid(txtDiasVisita.Text, 2, 1) = "" Then
                martes = 0
            Else
                martes = Mid(txtDiasVisita.Text, 2, 1)
            End If

            If Mid(txtDiasVisita.Text, 3, 1) = "" Then
                miercoles = 0
            Else
                miercoles = Mid(txtDiasVisita.Text, 3, 1)
            End If

            If Mid(txtDiasVisita.Text, 4, 1) = "" Then
                jueves = 0
            Else
                jueves = Mid(txtDiasVisita.Text, 4, 1)
            End If

            If Mid(txtDiasVisita.Text, 5, 1) = "" Then
                viernes = 0
            Else
                viernes = Mid(txtDiasVisita.Text, 5, 1)
            End If

            If Mid(txtDiasVisita.Text, 6, 1) = "" Then
                sabado = 0
            Else
                sabado = Mid(txtDiasVisita.Text, 6, 1)
            End If

            If Mid(txtDiasVisita.Text, 7, 1) = "" Then
                domingo = 0
            Else
                domingo = Mid(txtDiasVisita.Text, 7, 1)
            End If

            If lunes = 1 Then
                ChkLunes.Checked = True
            Else
                ChkLunes.Checked = False
            End If

            If martes = 1 Then
                ChkMartes.Checked = True
            Else
                ChkMartes.Checked = False
            End If

            If miercoles = 1 Then
                ChkMiercoles.Checked = True
            Else
                ChkMiercoles.Checked = False
            End If

            If jueves = 1 Then
                ChkJueves.Checked = True
            Else
                ChkJueves.Checked = False
            End If

            If viernes = 1 Then
                ChkViernes.Checked = True
            Else
                ChkViernes.Checked = False
            End If

            If sabado = 1 Then
                ChkSabado.Checked = True
            Else
                ChkSabado.Checked = False
            End If

            If domingo = 1 Then
                ChkDomingo.Checked = True
            Else
                ChkDomingo.Checked = False
            End If


            TxtTotLimCred.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("MTOLIMCRED"))

            Dim TAB_DETALLE As DataTable
            TAB_DETALLE = TmpListarDatos("SP_SELECT_COBRANZAXCLIENTE '" & codempresa & "','" & tcodigo.Text & "'")

            If TAB_DETALLE.Rows.Count > 0 Then

                TxtLineaUtilidad.Text = TAB_DETALLE.Rows(0)(0).ToString

            Else
                TxtLineaUtilidad.Text = 0
            End If

            TAB_DETALLE = TmpListarDatos("SP_SUMPEDIDO '" & tcodigo.Text & "'")

            If TAB_DETALLE.Rows.Count > 0 Then

                TxtPedidoUtilizado.Text = TAB_DETALLE.Rows(0)(0).ToString

            Else
                TxtPedidoUtilizado.Text = 0
            End If

            ' TxtTotSaldoDisp.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("SALDODISPONIBLE"))

            Me.comboRuta.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("RUTA"))
            CboTipoNegocio.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("TIPONEGOCIO"))
            CboTipoprecio.SelectedValue = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("CODTIPOPRE"))
            ChkActivo.Checked = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("estado"))
            chkOr.Checked = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("ORT"))



            If CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("imagen")) = Nothing Then
            Else
                PictureBox1.Image = Image.FromFile(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("imagen")))
            End If

            If CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("imagen2")) = Nothing Then
            Else
                PictureBox2.Image = Image.FromFile(CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)("imagen2")))
            End If


            dTablaFuerzaVenta = CAyuda.ListarDatos("NSP_LISTAR_CLIE_FUERZA", codempresa, tcodigo.Text.Trim).Tables(0)
            TablaEstiloFV.MappingName = dTablaFuerzaVenta.TableName
            TablaEstiloFV.GridColumnStyles(0).MappingName = "CODFUERZA"
            TablaEstiloFV.GridColumnStyles(1).MappingName = "DESCRIPCION"
            TablaEstiloFV.GridColumnStyles(2).MappingName = "CREDITO_F"
            TablaEstiloFV.GridColumnStyles(3).MappingName = "SALDO_CREDF"
            dgMatrizFuerzas.TableStyles.Add(TablaEstiloFV)
            dgMatrizFuerzas.DataSource = dTablaFuerzaVenta
            tsaldo.ReadOnly = True
            CargarGridCliDep()
            FormatoGridCliDep()
            CargarGridPtoLlegad()
            FormatoGridPtoLlegad()
            If Trim(ds.Tables("pa").Rows(0)(29)) = False Then
                CheckBox2.Checked = False
            Else
                CheckBox2.Checked = True
            End If

        End If


        If truc.Text.Trim = "" Then
            If tnombre.Text.Trim.Length = 0 Then
                tnombre.Text = trazon.Text
                trazon.Text = ""
            End If
        End If


        If truc.Text.Trim = "" Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If


        tcredito.Enabled = False
        tcodigo.ReadOnly = True
        BTNCANCELAR.Enabled = True



    End Sub
    Public Sub CargarGridCliDep()
        TMP_CLIDEP = TmpListarDatos("SP_LISTAR_TMP_CLIENTE_J  '" & codempresa & "','" & tcodigo.Text & "','" & CodUsuario & "'")
        GridCliDep.DataSource = TMP_CLIDEP
    End Sub
    Public Sub FormatoGridCliDep()
        GridCliDep.TableStyles.Clear()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_CLIDEP.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODCLIENTE"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 100

        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DATOADJUNTO"
            .HeaderText = "Dependiente"
            .NullText = ""
            .Width = 200
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DIRECCION"
            .HeaderText = "Direccion"
            .NullText = ""
            .Width = 150
        End With

        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "ruc"
            .HeaderText = "ruc"
            .NullText = ""
            .Width = 100
        End With


        Dim Column5 As New DataGridBoolColumn
        With Column5

            .HeaderText = "NP"
            .MappingName = "NOTAPEDIDO"
            .Width = 50
            .ReadOnly = True
        End With

        Dim Column6 As New DataGridBoolColumn
        With Column6

            .HeaderText = "ORT"
            .MappingName = "ORT"
            .Width = 50
            .ReadOnly = True
        End With


        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "RUTA"
            .HeaderText = "Ruta"
            .NullText = ""
            .Width = 100
        End With

        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "MPERCEP"
            .HeaderText = "PERCEP"
            .NullText = ""
            .Width = 50
        End With

        Dim Column9 As New DataGridBoolColumn
        With Column9
            .MappingName = "ESTADO"
            .HeaderText = "EST"
            .Width = 50
            .ReadOnly = True
        End With


        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "DISTRITO"
            .HeaderText = "Distrito"
            .NullText = ""
            .Width = 100
        End With

        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "dni"
            .HeaderText = "dni"
            .NullText = ""
            .Width = 100
        End With





        TableStyle1.GridColumnStyles.Clear()
        'TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column9, Column6, Column7, Column8})
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column11, Column7, Column8})

        TableStyle1.GridColumnStyles.AddRange(New DataGridBoolColumn() {Column9, Column5, Column6})

        GridCliDep.TableStyles.Add(TableStyle1)




    End Sub
    Public Sub CargarGridPtoLlegad()
        TMP_PTOLLEGAD = TmpListarDatos("SP_LISTAR_TMPCLIPTOLLEGADA   '" & codempresa & "','" & CodUsuario & "'")
        GridPtoLleg.DataSource = TMP_PTOLLEGAD
    End Sub
    Public Sub FormatoGridPtoLlegad()
        GridPtoLleg.TableStyles.Clear()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_PTOLLEGAD.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "ITEM"
            .HeaderText = "Item"
            .NullText = ""
            .Width = 25
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "PTOLLEGADA"
            .HeaderText = "Punto Llegada"
            .NullText = ""
            .Width = 250
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "CODRUTA"
            .HeaderText = "CodRuta"
            .NullText = ""
            .Width = 50
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "DESRUTA"
            .HeaderText = "Ruta"
            .NullText = ""
            .Width = 250
        End With

        TableStyle1.GridColumnStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4})
        GridPtoLleg.TableStyles.Add(TableStyle1)

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean

        Select Case KeyData
            Case Keys.Enter
                If GridPtoLleg.Focus = True Then
                    If TMP_PTOLLEGAD.Rows.Count > 0 Then
                        TxtDirecLleg.Text = GridPtoLleg.Item(GridPtoLleg.CurrentRowIndex, 1)
                        CboRutaLlegada.SelectedValue = GridPtoLleg.Item(GridPtoLleg.CurrentRowIndex, 2)
                    End If
                End If

                If GridCliDep.Focus = True Then

                    If TMP_CLIDEP.Rows.Count > 0 Then
                        If GridCliDep.CurrentCell.ColumnNumber = 7 Then
                            If GridCliDep.CurrentRowIndex > -1 Then
                                Dim FrmOpciones As New FrmOpciones2
                                FrmOpciones.ShowDialog()
                                If FrmOpciones.DEVOLVER = True Then
                                    For i As Integer = 0 To TMP_CLIDEP.Rows.Count - 1
                                        If TMP_CLIDEP.Rows(i)("CODCLIENTE").ToString.Trim = GridCliDep.Item(GridCliDep.CurrentRowIndex, 0).ToString.Trim Then
                                            ''''''''''''''''''CAMBIAR EL ESTADO DE NTA CRED
                                            Select Case FrmOpciones.Opcion
                                                Case 1
                                                    TMP_CLIDEP.Rows(i)("ESTADO") = 0

                                                    CAyuda.Ejecutar("SP_UPDATE_TMP_CLIENTE", codempresa, GridCliDep.Item(GridCliDep.CurrentRowIndex, 0).ToString.Trim, CodUsuario, 0)

                                                Case 2
                                                    TMP_CLIDEP.Rows(i)("ESTADO") = 1

                                                    CAyuda.Ejecutar("SP_UPDATE_TMP_CLIENTE", codempresa, GridCliDep.Item(GridCliDep.CurrentRowIndex, 0).ToString.Trim, CodUsuario, 1)



                                            End Select

                                        End If
                                    Next
                                End If
                            End If
                        End If
                    End If




                End If

            Case Keys.F3
                If GridPtoLleg.Focus = True Then
                    If TMP_PTOLLEGAD.Rows.Count > 0 Then
                        TmpInsertDatos("SP_ELIM_TMPCLIPTOLLEGADA   '" & codempresa & "','" & CodUsuario & "','" & GridPtoLleg.Item(GridPtoLleg.CurrentRowIndex, 0) & "'")
                        CargarGridPtoLlegad()
                        FormatoGridPtoLlegad()
                        Exit Function
                    End If
                End If
                If GridCliDep.Focus = True Then
                    Dim Sender As Object = Nothing
                    Dim e As EventArgs = Nothing
                    BtnQuitDep_Click(Sender, e)
                End If
            Case Keys.Escape
                Me.Close()
        End Select
    End Function

    Private Sub LimpiarTempoCliente()
        TmpInsertDatos("SP_ELI_TEMPO_CLI  '" & codempresa & "','" & CodUsuario & "'")
        TmpInsertDatos("DELETE   FROM TMP_CLIENTE  WHERE   CDUSUARIO='" & CodUsuario & "'  AND CODEMPRESA='" & codempresa & "'")
        CargarGridCliDep()
        FormatoGridCliDep()
        LimpiarFuerzaVenta()
        CargarGridPtoLlegad()
    End Sub

#End Region

    Private Sub frm_clie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'TabControl1.TabPages.RemoveAt(3)
            TabControl1.SelectedIndex = 0

            AINTOP = 0
            Call bloquea(True, False)
            Call BOTONES(True, False, False, False, True)
            Call cargadatos()
            Dim TablaTemp2 As New DataTable
            TablaTemp2 = CAyuda.ListarDatos("SP_OBT_CODCLIVARIOS", codempresa).Tables(0)
            If TablaTemp2.Rows.Count > 0 Then
                clientvarios = TablaTemp2.Rows(0)(0) 'cargamos al codigo del clientes varios 
            End If
            Conecta("select codgenclie from configvta where (codempresa='" & codempresa & "')", "cor")
            If ds.Tables("cor").Rows.Count > 0 Then
                correl = Trim(ds.Tables("cor").Rows(0)(0))
            End If
            Conecta("select codcliente,paterno,materno,nombres from cliente where (razonsocial='' and codempresa='" & codempresa & "' and estado=0)", "clie")
            Conecta("select codcliente,razonsocial from cliente where (razonsocial<>'' and paterno='' and codempresa='" & codempresa & "' and estado=0)", "clie")
            Conecta("select codclie from configsis", "lle")
            If ds.Tables("lle").Rows.Count > 0 Then
                correl = ds.Tables("lle").Rows(0)(0)
            End If
            BTNCANCELAR.Enabled = False

            HabiliTabPages = True
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try

    End Sub
    Sub cargadatos()
        Try
            '  CAyuda.CargarDataCombo(ctipoclie, "nsp_sele_Tipocliente  '" & codempresa & "'", "codtipcli", "dstipoclie")
            'CAyuda.CargarDataCombo(cmbptovta, "Nsp_Sele_tdaptoventa '" & codempresa & "','',''", "NROPTOVTA", "DESPTOVTA")
            CAyuda.CargarDataCombo(cbopais, "Nsp_sel_Pais '" & codempresa & "'", "Codigo", "Descripcion")
            CAyuda.CargarDataCombo(cbFuerzaVta, "NSP_LISTA_FUERZA_VTA '" & codempresa & "'", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(ctipopago, "Nsp_Sele_TipoPago  '" & codempresa & "'", "Código", "Descripción")
            'CAyuda.CargarDataCombo(cciudad, "Nsp_Sele_Ciudad_", "codciudad", "desciudad")
            CAyuda.CargarDataCombo(txtctaBanca, "Nsp_Select_Zona '" & codempresa & "'", "codzona", "deszona")
            CAyuda.CargarDataCombo(cmbmoneda, "NSP_Select_Listado_Moneda  '" & codempresa & "'", "Código", "Descripción")
            'ctipopago.SelectedIndex = 0
            Dim tablaTemp As New DataTable
            tablaTemp = CAyuda.ListarDatos("NSP_Select_MuestraCodPais", codempresa).Tables(0)
            If tablaTemp.Rows.Count > 0 Then
                tipopago = tablaTemp.Rows(0)(1)
            End If
            CAyuda.CargarDataCombo(CmbForPago, "NSP_SELECT_LISTATIPCREDF '" & codempresa & "'", "TIPCREDFAC", "DESCREDFAC")
            CAyuda.CargarDataCombo(CboTipoprecio, "NSP_LISTAR_TIPOPRE '" & codempresa & "'", "CODTIPOPRE", "DSTIPOPRE")
            CAyuda.CargarDataCombo(CboTipoNegocio, "NSP_LISTAR_TIPONEGOCIO '" & codempresa & "' ,'%' ", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(CboRutaDep, "NSP_LISTAR_RUTA '" & codempresa & "' ,'%' ", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(comboRuta, "NSP_LISTAR_RUTA '" & codempresa & "' ,'%' ", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(CboRutaLlegada, "NSP_LISTAR_RUTA '" & codempresa & "' ,'%' ", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(CboCatClient, "NSP_LISTAR_CATEGORIA_CLIENTE '" & codempresa & "' ,'%' ", "CODIGO", "DESCRIPCION")
            CAyuda.CargarDataCombo(CboSegClient, "NSP_LISTAR_SEGMENTO_CLIENTE '" & codempresa & "' ,'%' ", "CODIGO", "DESCRIPCION")





            If Not cbopais.SelectedValue Is Nothing Then
                CAyuda.CargarDataCombo(cdepa, "sele_depa '" & cbopais.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")

            End If
            If ctipopago.SelectedValue = tipopago Then
                Label16.Visible = True
                tcredito.Visible = True
                Label17.Visible = True
                tsaldo.Visible = True
                Label5.Visible = True
                CmbForPago.Visible = True
            Else
                Label16.Visible = False
                tcredito.Visible = False
                Label17.Visible = False
                tsaldo.Visible = False
                Label5.Visible = False
                CmbForPago.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        Me.tcredito.Text = String.Empty
        Me.tsaldo.Text = String.Empty
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        If FLAG = 0 Then
            Call limpia()
            Call BOTONES(True, False, False, False, True)
        Else
            Call limpia()
            Call BOTONES(True, False, False, False, True)
        End If

        LimpiarTempoCliente()

        BTNCANCELAR.Enabled = False
        Call bloquea(True, False)
        AINTOP = 0
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        'BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click


        If MsgBox("ESTA SEGURO DE ELIMINAR EL REGISTRO", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim tablaDependiente As New DataTable
        tablaDependiente = CAyuda.ListarDatos("Nsp_busq_depende_cliente", codempresa, tcodigo.Text).Tables(0)
        If tablaDependiente.Rows.Count > 0 Then
            Dim Dependiente As String
            Dependiente = tablaDependiente.Rows(0)(0)
            MessageBox.Show("Este Cliente es Dependiente del Cliente con codigo " & Dependiente & " primero tiene que eliminar de los dependientes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String
        Dim DT_CANIDAD As DataTable



        Dim DT_DATE As DataTable
        DT_DATE = TmpListarDatos("SP_EXTRAER_AÑO_MES  '" & codempresa & "'")

        ''SELECCIONO LAS VENTAS
        For i As Integer = 0 To DT_DATE.Rows.Count - 1

            MesAct = "00" & DT_DATE.Rows(i)("MES").ToString.Trim
            MesAct = Mid(MesAct, MesAct.Length - 1)

            Anio = DT_DATE.Rows(i)("AÑO")
            VentaC = "VENTC" & Anio & MesAct
            VentD = "VENTD" & Anio & MesAct
            MoviD = "MOVID" & Anio & MesAct
            MoviC = "MOVIC" & Anio & MesAct

            If VERIFICA_HISTORICOVENT(VentaC) = True Then
                DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_CLIENTE_VTA '" & codempresa & "','" & tcodigo.Text & "','" & VentaC & "'")

                If DT_CANIDAD.Rows.Count > 0 Then
                    MsgBox("ESTE CLIENTE NO SE PUEDE BORRAR ESTA EN VENTA")
                    Exit Sub
                End If
            End If

        Next

        DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_CLIENTE_VTA '" & codempresa & "','" & tcodigo.Text & "','0'")
        If DT_CANIDAD.Rows.Count > 0 Then
            MsgBox("ESTE CLIENTE NO SE PUEDE BORRAR ESTA EN VENTA")
            Exit Sub
        End If


        DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_CLIENTE_PEDIDO '" & codempresa & "','" & tcodigo.Text & "'")
        If DT_CANIDAD.Rows.Count > 0 Then
            MsgBox("ESTE CLIENTE NO SE PUEDE BORRAR ESTA EN PEDIDOS")
            Exit Sub
        End If





        Dim sql As String
        sql = "nsp_dele_cliente '" & tcodigo.Text & "','" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & codempresa & "'"
        TmpInsertDatos(sql)
        'BTNCANCELAR_Click(sender, e)
        ''= True Then
        Eliminar_Nextel()
        BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
        limpia()
        LimpiarTempoCliente()

        BTNCANCELAR.Enabled = False
        Call bloquea(False, True)
        AINTOP = 0


    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        AINTOP = 1
        pb_agregar = True
        '        MontoCred = tcredito.Text
        Call bloquea(False, True)
        tcodigo.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        FLAG = 1
        tpaterno.Focus()
        tpaterno.SelectAll()
        BTNCANCELAR.Enabled = True
        CheckBox1_CheckedChanged(sender, e)
        tsaldo.ReadOnly = True

        tcodigo.Enabled = False



        If correl = True Then
            'If Me.CheckBox1.Checked = True Then
            '    trazon.ReadOnly = True
            'Else
            '    tpaterno.ReadOnly = True
            'End If
        End If
        'CAyuda.CargarDataCombo(cvendedor, "Nsp_SELECT_VENDEDORXPTOVTA '" & codempresa & "','" & cmbptovta.SelectedValue.ToString() & "'", "codvend", "dsvend")
        tcredito.Enabled = True

        TxtLineaUtilidad.Enabled = False

        TxtTotSaldoDisp.Enabled = False


        BtnQuitDep.Enabled = False



    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Try
            AINTOP = 1
            Dim RESPUESTA As Boolean
            pb_agregar = True
            RESPUESTA = mensaje_ingreso()
            If RESPUESTA = False Then Exit Sub
            Call limpia()
            Call bloquea(False, True)
            Call BOTONES(False, True, False, False, False)
            FLAG = 0

            CheckBox1.Checked = False
            ck_Nota_Pedido.Checked = False


            'If correl = True Then
            '    tcodigo.ReadOnly = True
            '    tpaterno.Focus()
            'Else
            '    tcodigo.ReadOnly = False
            '    tcodigo.Focus()
            'End If

            LimpiarFuerzaVenta()

            BTNCANCELAR.Enabled = True
            CheckBox1_CheckedChanged(sender, e)
            cargadatos()
            LimpiarTempoCliente()

            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing

            TxtLineaUtilidad.Enabled = False
            TxtTotSaldoDisp.Enabled = False
            BtnQuitDep.Enabled = False

            tcodigo.Focus()

        Catch
        End Try
    End Sub

    Private Sub LimpiarFuerzaVenta()
        dTablaFuerzaVenta = CAyuda.ListarDatos("NSP_LISTAR_CLIE_FUERZA", codempresa, "XXX666").Tables(0)
        TablaEstiloFV.MappingName = dTablaFuerzaVenta.TableName
        TablaEstiloFV.GridColumnStyles(0).MappingName = "CODFUERZA"
        TablaEstiloFV.GridColumnStyles(1).MappingName = "DESCRIPCION"
        TablaEstiloFV.GridColumnStyles(2).MappingName = "CREDITO_F"
        TablaEstiloFV.GridColumnStyles(3).MappingName = "SALDO_CREDF"
        dgMatrizFuerzas.TableStyles.Add(TablaEstiloFV)
        dgMatrizFuerzas.DataSource = dTablaFuerzaVenta
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Try
            Ruc = True
            Dim sql As String
            Dim ValidaCampos As Boolean
            'Call formatotextbox(Me)
            ValidaCampos = ValidarCamposAguardar()
            If ValidaCampos = False Then
                Exit Sub
            End If

            Dim ck_lunes As String
            Dim ck_martes As String
            Dim ck_miercoles As String
            Dim ck_jueves As String
            Dim ck_viernes As String
            Dim ck_sabado As String
            Dim ck_domingo As String

            If ChkLunes.Checked = True Then
                ck_lunes = 1
            Else
                ck_lunes = 0
            End If

            If ChkMartes.Checked = True Then
                ck_martes = 1
            Else
                ck_martes = 0
            End If

            If ChkMiercoles.Checked = True Then
                ck_miercoles = 1
            Else
                ck_miercoles = 0
            End If

            If ChkJueves.Checked = True Then
                ck_jueves = 1
            Else
                ck_jueves = 0
            End If

            If ChkViernes.Checked = True Then
                ck_viernes = 1
            Else
                ck_viernes = 0
            End If

            If ChkSabado.Checked = True Then
                ck_sabado = 1
            Else
                ck_sabado = 0
            End If

            If ChkDomingo.Checked = True Then
                ck_domingo = 1
            Else
                ck_domingo = 0
            End If

            Dim diasvisita As String

            diasvisita = ck_lunes + ck_martes + ck_miercoles + ck_jueves + ck_viernes + ck_sabado + ck_domingo

            trazon.Text = Replace(trazon.Text, "'", "´")

            If tcodigo.Text <> "888" Then
                If tcodigo.Text.Trim.Length < 8 Then
                    MessageBox.Show("El Codigo tiene q tener 8 digistos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tcodigo.Focus()
                    Exit Sub
                End If

                Dim ultimodigito As String
                ultimodigito = Microsoft.VisualBasic.Right(Me.tcodigo.Text, 1)

                If ultimodigito > 0 Then
                    MessageBox.Show("El ultimo digito del codigo de cliente tiene q ser cero", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tcodigo.Focus()
                    Exit Sub
                End If
            End If

            If tcodigo.Text.Trim.Length = 0 Then
                MessageBox.Show("Ingrese el Codigo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tcodigo.Focus()
                Exit Sub
            End If

            If CheckBox1.Checked = True Then
                If trazon.Text.Trim.Length = 0 Then
                    MessageBox.Show("Ingrese la Razón Social", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    trazon.Focus()
                    Exit Sub
                End If

                If truc.Text.Trim.Length = 0 Then
                    MessageBox.Show("Ingrese el Ruc", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    truc.Focus()
                    Exit Sub
                End If
            End If

            If CheckBox1.Checked = False Then
                If tpaterno.Text.Trim.Length = 0 Then
                    MessageBox.Show("Ingrese el Apellido Paterno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tpaterno.Focus()
                    Exit Sub
                End If

                If tmaterno.Text.Trim.Length = 0 Then
                    MessageBox.Show("Ingrese el Apellido Materno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tmaterno.Focus()
                    Exit Sub
                End If

                If tnombre.Text.Trim.Length = 0 Then
                    MessageBox.Show("Ingrese el Nombre", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tnombre.Focus()
                    Exit Sub
                End If

                If tdni.Text.Trim.Length = 0 Then
                    MessageBox.Show("Ingrese el DNI", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    tdni.Focus()
                    Exit Sub
                End If

            End If

            If ctipopago.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione un Tipo Pago", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ctipopago.Focus()
                Exit Sub
            End If

            '  MsgBox(ctipoclie.SelectedText.ToString)
            'If ctipoclie.SelectedValue Is Nothing Then
            '    MessageBox.Show("Seleccione un Tipo de Cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    ctipoclie.Focus()
            '    Exit Sub
            'End If

            'If txtctaBanca.SelectedValue Is Nothing Then
            '    MessageBox.Show("Seleccione una Zona", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    txtctaBanca.Focus()
            '    Exit Sub
            'End If

            If CboRutaDep.SelectedValue Is Nothing Then
                MessageBox.Show("La Ruta ha sido eliminada de la Base de Datos. Elija otra o consulte a su proveedor.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If CboTipoNegocio.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione una Tipo Negocio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CboTipoNegocio.Focus()
                Exit Sub
            End If
            If CboTipoprecio.SelectedValue Is Nothing Then
                MessageBox.Show("Seleccione una Tipo Precio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CboTipoprecio.Focus()
                Exit Sub
            End If

            If TxtTotLimCred.Text.Trim.Length = 0 Then
                TxtTotLimCred.Text = 0
            End If

            If TxtTotSaldoDisp.Text.Trim.Length = 0 Then
                TxtTotSaldoDisp.Text = 0
            End If

            If tdescuento.Text.Trim.Length = 0 Then
                tdescuento.Text = 0
            End If

            If cbopais.SelectedValue = Nothing Then
                MsgBox("Selecione un Pais...", MsgBoxStyle.Exclamation, "")
                cbopais.Focus()
                Exit Sub
            End If

            If cdepa.SelectedValue = Nothing Then
                MsgBox("Selecione un Departamento...", MsgBoxStyle.Exclamation, "")
                cdepa.Focus()
                Exit Sub
            End If

            If cciud.SelectedValue = Nothing Then
                MsgBox("Selecione una Ciudad...", MsgBoxStyle.Exclamation, "")
                cciud.Focus()
                Exit Sub
            End If

            If cdistrito.SelectedValue = Nothing Then
                MsgBox("Selecione un Distrito...", MsgBoxStyle.Exclamation, "")
                cdistrito.Focus()
                Exit Sub
            End If

            If CboTipoNegocio.SelectedValue = Nothing Then
                MsgBox("Selecione un Tipo Negocio...", MsgBoxStyle.Exclamation, "")
                CboTipoNegocio.Focus()
                Exit Sub
            End If

            If CboTipoprecio.SelectedValue = Nothing Then
                MsgBox("Selecione un Tipo Precio...", MsgBoxStyle.Exclamation, "")
                CboTipoprecio.Focus()
                Exit Sub
            End If

            If cmbmoneda.SelectedValue = Nothing Then
                MsgBox("Selecione una Moneda...", MsgBoxStyle.Exclamation, "")
                cmbmoneda.Focus()
                Exit Sub
            End If

            Dim formaPago As String

            If ctipopago.SelectedValue = "06" Then

                If CmbForPago.SelectedValue = Nothing Then
                    MsgBox("Selecione una Forma Pago...", MsgBoxStyle.Exclamation, "")
                    CmbForPago.Focus()
                    Exit Sub
                Else
                    formaPago = CmbForPago.SelectedValue
                End If

            Else
                formaPago = "0"
            End If

            If FLAG = 0 Then
                If Me.tdni.Text.Trim <> "" Then
                    Conecta("select dni from cliente where dni='" & Me.tdni.Text.Trim.ToUpper & "' AND CODEMPRESA = '" & codempresa & "'", "ver")
                    If ds.Tables("ver").Rows.Count > 0 Then
                        MessageBox.Show("Dni ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
                If Me.truc.Text.Trim <> "" Then
                    Conecta("select ruc from cliente where ruc='" & Me.truc.Text.Trim.ToUpper & "' AND CODEMPRESA = '" & codempresa & "'", "ver")
                    If ds.Tables("ver").Rows.Count > 0 Then
                        MessageBox.Show("RUC ya existente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
                If tcodigo.Text.Trim = "" Then
                    MessageBox.Show("Complete el codigo del Cliente Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Conecta("select codcliente from cliente where codcliente='" & Me.tcodigo.Text.Trim.ToUpper & "' AND CODEMPRESA = '" & codempresa & "'", "ver")
                    If ds.Tables("ver").Rows.Count > 0 Then
                        MessageBox.Show("El codigo ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
            End If

            'Conecta("select * from cliente where paterno='" & tpaterno.Text & "' AND materno = '" & tmaterno.Text & "' AND nombres = '" & tnombre.Text & "'", "ver")
            'If ds.Tables("ver").Rows.Count > 0 Then
            '    MessageBox.Show("El nombre y apellidos ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            If FLAG = 0 Then
                Conecta("select * from cliente where DATOADJUNTO='" & tpaterno.Text & " " & tmaterno.Text & " " & tnombre.Text & "' AND TRANS=0", "ver")
                If ds.Tables("ver").Rows.Count > 0 Then
                    MessageBox.Show("El nombre y apellidos ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If Me.cciud.Text.Trim = "" Then
                    sql = "NSP_ins_CLIENTE " & tdescuento.Text & ",'" & tctaletra.Text & "','" & tctaanticipo.Text & "','" & tctaventa.Text & "'," & CDbl(TxtTotSaldoDisp.Text) & "," & CDbl(TxtTotLimCred.Text) & ",'" & ttelefono.Text & "','" & truc.Text & "','" & tdireccion.Text & "','" & tcodigo.Text & "','" & ctipopago.SelectedValue.ToString & "','" & "0" & "','','" & codempresa & "',0,0,0,'" & trazon.Text & "','" & tmaterno.Text & "','" & tpaterno.Text & "','" & tnombre.Text & "','" & "" & "','" & tdni.Text & "','" & tmail.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & CodUsuario & "','" & formaPago & "','" & cmbmoneda.SelectedValue.ToString & "','" & cbopais.SelectedValue.ToString & "','" & txtcontacto.Text & "','" & txttelefonoc.Text & "','" & txtcelularc.Text & "','" & txtemailc.Text & "','" & txtfax.Text & "','" & cdepa.SelectedValue.ToString & "',0," & EMP & ",'" & comboRuta.SelectedValue.ToString & "','" & CboTipoNegocio.SelectedValue.ToString & "','" & CboTipoprecio.SelectedValue.ToString & "'," & ACTIVOCLIENTE & ",'" & rutaimagen & "','" & rutaimagen2 & "','" & ACTIVO_ORT & "','" & CboCatClient.SelectedValue.ToString & "','" & CboSegClient.SelectedValue.ToString & "','" & COOLER & "','" & txtCantidad.Text & "','" & txtObservacion.Text & "','" & txt_Cordenadas_X.Text & "','" & txt_Cordenadas_Y.Text & "','" & diasvisita & "'"
                ElseIf Me.cdistrito.Text.Trim = "" Then
                    sql = "NSP_ins_CLIENTE " & tdescuento.Text & ",'" & tctaletra.Text & "','" & tctaanticipo.Text & "','" & tctaventa.Text & "'," & CDbl(TxtTotSaldoDisp.Text) & "," & CDbl(TxtTotLimCred.Text) & ",'" & ttelefono.Text & "','" & truc.Text & "','" & tdireccion.Text & "','" & tcodigo.Text & "','" & ctipopago.SelectedValue.ToString & "','" & "0" & "','" & cciud.SelectedValue.ToString & "','" & codempresa & "',0,0,0,'" & trazon.Text & "','" & tmaterno.Text & "','" & tpaterno.Text & "','" & tnombre.Text & "','" & "" & "','" & tdni.Text & "','" & tmail.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & CodUsuario & "','" & formaPago & "','" & cmbmoneda.SelectedValue.ToString & "','" & cbopais.SelectedValue.ToString & "','" & txtcontacto.Text & "','" & txttelefonoc.Text & "','" & txtcelularc.Text & "','" & txtemailc.Text & "','" & txtfax.Text & "','" & cdepa.SelectedValue.ToString & "',0," & EMP & ",'" & comboRuta.SelectedValue.ToString & "','" & CboTipoNegocio.SelectedValue.ToString & "','" & CboTipoprecio.SelectedValue.ToString & "'," & ACTIVOCLIENTE & ",'" & rutaimagen & "','" & rutaimagen2 & "','" & ACTIVO_ORT & "','" & CboCatClient.SelectedValue.ToString & "','" & CboSegClient.SelectedValue.ToString & "','" & COOLER & "','" & txtCantidad.Text & "','" & txtObservacion.Text & "','" & txt_Cordenadas_X.Text & "','" & txt_Cordenadas_Y.Text & "','" & diasvisita & "'"
                Else
                    sql = "NSP_ins_CLIENTE " & tdescuento.Text & ",'" & tctaletra.Text & "','" & tctaanticipo.Text & "','" & tctaventa.Text & "'," & CDbl(TxtTotSaldoDisp.Text) & "," & CDbl(TxtTotLimCred.Text) & ",'" & ttelefono.Text & "','" & truc.Text & "','" & tdireccion.Text & "','" & tcodigo.Text & "','" & ctipopago.SelectedValue.ToString & "','" & "0" & "','" & cciud.SelectedValue.ToString & "','" & codempresa & "',0,0,0,'" & trazon.Text & "','" & tmaterno.Text & "','" & tpaterno.Text & "','" & tnombre.Text & "','" & "" & "','" & tdni.Text & "','" & tmail.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & CodUsuario & "','" & formaPago & "','" & cmbmoneda.SelectedValue.ToString & "','" & cbopais.SelectedValue.ToString & "','" & txtcontacto.Text & "','" & txttelefonoc.Text & "','" & txtcelularc.Text & "','" & txtemailc.Text & "','" & txtfax.Text & "','" & cdepa.SelectedValue.ToString & "'," & Me.cdistrito.SelectedValue.ToString & "," & EMP & ",'" & comboRuta.SelectedValue.ToString & "','" & CboTipoNegocio.SelectedValue.ToString & "','" & CboTipoprecio.SelectedValue.ToString & "'," & ACTIVOCLIENTE & ",'" & rutaimagen & "','" & rutaimagen2 & "','" & ACTIVO_ORT & "','" & CboCatClient.SelectedValue.ToString & "','" & CboSegClient.SelectedValue.ToString & "','" & COOLER & "','" & txtCantidad.Text & "','" & txtObservacion.Text & "','" & txt_Cordenadas_X.Text & "','" & txt_Cordenadas_Y.Text & "','" & diasvisita & "'"
                End If
                If TmpInsertDatos(sql) = True Then
                    MsgBox("SE GUARDO CORRECTAMENTE EL REGISTRO", MsgBoxStyle.Information, "")
                    Guardar_Nextel()

                    Call BOTONES(True, False, False, False, True)
                    Limpiatextbox(Me)
                    bloquea(True, False)
                    Dim VarNombre As String = String.Empty
                    Dim VarDoc As String = String.Empty
                    If CheckBox1.Checked Then
                        VarNombre = trazon.Text.Trim
                        VarDoc = truc.Text.Trim
                    Else
                        VarNombre = tpaterno.Text.Trim & " " & tmaterno.Text.Trim & " ," & tnombre.Text.Trim
                        VarDoc = tdni.Text.Trim
                    End If
                    TabControl1.SelectedIndex = 0
                End If
            End If

            If FLAG = 1 Then
                Conecta("select * from cliente where DATOADJUNTO='" & tpaterno.Text & " " & tmaterno.Text & " " & tnombre.Text & "' and codcliente<>'" & tcodigo.Text & "' AND TRANS=0", "ver")
                If ds.Tables("ver").Rows.Count > 0 Then
                    MessageBox.Show("El nombre y apellidos ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                tcodigo.Text = Trim(ASTRCODCLI)
                If Me.cciud.Text.Trim = "" Then
                    sql = "NSP_upd_CLIENTE " & tdescuento.Text & ",'" & tctaletra.Text & "','" & tctaanticipo.Text & "','" & tctaventa.Text & "'," & CDbl(TxtTotSaldoDisp.Text) & "," & CDbl(TxtTotLimCred.Text) & ",'" & ttelefono.Text & "','" & truc.Text & "','" & tdireccion.Text & "','" & tcodigo.Text & "','" & ctipopago.SelectedValue.ToString & "','" & "0" & "','','" & codempresa & "'," & 0 & "," & 0 & "," & 0 & ",'" & trazon.Text & "','" & tmaterno.Text & "','" & tpaterno.Text & "','" & tnombre.Text & "','" & "" & "','" & tdni.Text & "','" & tmail.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & CodUsuario & "','" & formaPago & "','" & cmbmoneda.SelectedValue.ToString() & "','" & cbopais.SelectedValue.ToString & "','" & txtcontacto.Text & "','" & txttelefonoc.Text & "','" & txtcelularc.Text & "','" & txtemailc.Text & "','" & txtfax.Text & "','" & cdepa.SelectedValue.ToString & "',0," & EMP & ",'" & comboRuta.SelectedValue.ToString & "','" & CboTipoNegocio.SelectedValue.ToString & "','" & CboTipoprecio.SelectedValue.ToString & "'," & ACTIVOCLIENTE & ",'" & rutaimagen & "','" & rutaimagen2 & "','" & ACTIVO_ORT & "','" & CboCatClient.SelectedValue.ToString & "','" & CboSegClient.SelectedValue.ToString & "','" & COOLER & "','" & txtCantidad.Text & "','" & txtObservacion.Text & "','" & txt_Cordenadas_X.Text & "','" & txt_Cordenadas_Y.Text & "','" & diasvisita & "'"
                ElseIf Me.cdistrito.Text.Trim = "" Then
                    sql = "NSP_upd_CLIENTE " & tdescuento.Text & ",'" & tctaletra.Text & "','" & tctaanticipo.Text & "','" & tctaventa.Text & "'," & CDbl(TxtTotSaldoDisp.Text) & "," & CDbl(TxtTotLimCred.Text) & ",'" & ttelefono.Text & "','" & truc.Text & "','" & tdireccion.Text & "','" & tcodigo.Text & "','" & ctipopago.SelectedValue.ToString & "','" & "0" & "','" & cciud.SelectedValue.ToString & "','" & codempresa & "',0,0,0,'" & trazon.Text & "','" & tmaterno.Text & "','" & tpaterno.Text & "','" & tnombre.Text & "','" & "" & "','" & tdni.Text & "','" & tmail.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & CodUsuario & "','" & formaPago & "','" & cmbmoneda.SelectedValue.ToString() & "','" & cbopais.SelectedValue.ToString & "','" & txtcontacto.Text & "','" & txttelefonoc.Text & "','" & txtcelularc.Text & "','" & txtemailc.Text & "','" & txtfax.Text & "','" & cdepa.SelectedValue.ToString & "',0," & EMP & ",'" & comboRuta.SelectedValue.ToString & "','" & CboTipoNegocio.SelectedValue.ToString & "','" & CboTipoprecio.SelectedValue.ToString & "'," & ACTIVOCLIENTE & ",'" & rutaimagen & "','" & rutaimagen2 & "','" & ACTIVO_ORT & "','" & CboCatClient.SelectedValue.ToString & "','" & CboSegClient.SelectedValue.ToString & "','" & COOLER & "','" & txtCantidad.Text & "','" & txtObservacion.Text & "','" & txt_Cordenadas_X.Text & "','" & txt_Cordenadas_Y.Text & "','" & diasvisita & "'"
                Else
                    sql = "NSP_upd_CLIENTE " & tdescuento.Text & ",'" & tctaletra.Text & "','" & tctaanticipo.Text & "','" & tctaventa.Text & "'," & CDbl(TxtTotSaldoDisp.Text) & "," & CDbl(TxtTotLimCred.Text) & ",'" & ttelefono.Text & "','" & truc.Text & "','" & tdireccion.Text & "','" & tcodigo.Text & "','" & ctipopago.SelectedValue.ToString & "','" & "0" & "','" & cciud.SelectedValue.ToString & "','" & codempresa & "',0,0,0,'" & trazon.Text & "','" & tmaterno.Text & "','" & tpaterno.Text & "','" & tnombre.Text & "','" & "" & "','" & tdni.Text & "','" & tmail.Text & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & CodUsuario & "','" & formaPago & "','" & cmbmoneda.SelectedValue.ToString() & "','" & cbopais.SelectedValue.ToString & "','" & txtcontacto.Text & "','" & txttelefonoc.Text & "','" & txtcelularc.Text & "','" & txtemailc.Text & "','" & txtfax.Text & "','" & cdepa.SelectedValue.ToString & "'," & Me.cdistrito.SelectedValue.ToString & "," & EMP & ",'" & comboRuta.SelectedValue.ToString & "','" & CboTipoNegocio.SelectedValue.ToString & "','" & CboTipoprecio.SelectedValue.ToString & "'," & ACTIVOCLIENTE & ",'" & rutaimagen & "','" & rutaimagen2 & "','" & ACTIVO_ORT & "','" & CboCatClient.SelectedValue.ToString & "','" & CboSegClient.SelectedValue.ToString & "','" & COOLER & "','" & txtCantidad.Text & "','" & txtObservacion.Text & "','" & txt_Cordenadas_X.Text & "','" & txt_Cordenadas_Y.Text & "','" & diasvisita & "'"
                End If
                TmpInsertDatos("delete from dependienteclie where codcliente='" & tcodigo.Text & "' and empresa='" & codempresa & "'")
                TmpInsertDatos("delete from CLIENTE_PTOVTA where codcliente='" & tcodigo.Text & "' and codempresa='" & codempresa & "'")
                If TmpInsertDatos(sql) = True Then
                    MsgBox("SE MODIFICO CORRECTAMENTE {poju gjud hjuso yhiEL REGISTRO", MsgBoxStyle.Information, "")
                    Guardar_Nextel()

                    Call BOTONES(True, False, False, False, True)
                    bloquea(True, False)
                End If
            End If

            If TablaDircli.Rows.Count > 0 Then
                For ContB As Integer = 0 To TablaDircli.Rows.Count - 1
                    CAyuda.Ejecutar("NSP_ins_CLIDIR", tcodigo.Text.Trim, TablaDircli.Rows(ContB)("DIRCLI"), TablaDircli.Rows(ContB)("CODDIRCLI"), Now, CodUsuario, codempresa, TablaDircli.Rows(ContB)("CODRUTA"), TablaDircli.Rows(ContB)("NOMCLI"), TablaDircli.Rows(ContB)("RUC_DNI"))
                Next
            End If
            CAyuda.Ejecutar("NSP_DELETE_CLI_FUERZA", codempresa, tcodigo.Text.Trim)
            If dTablaFuerzaVenta.Rows.Count > 0 Then
                For ContB As Integer = 0 To dTablaFuerzaVenta.Rows.Count - 1
                    CAyuda.Ejecutar("NSP_INSERT_CLIE_FUERZA", codempresa, tcodigo.Text.Trim, dTablaFuerzaVenta.Rows(ContB)("CODFUERZA"), dTablaFuerzaVenta.Rows(ContB)("CREDITO_F"), dTablaFuerzaVenta.Rows(ContB)("SALDO_CREDF"))
                Next
                Me.tcredito.Text = 0.0
                Me.tsaldo.Text = 0.0
            End If


            BTNCANCELAR.Enabled = False
            AINTOP = 0
            FLAG = 0
            limpia()
            LimpiarTempoCliente()

            TabControl1.SelectedIndex = 0

            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing


            ck_Nota_Pedido.Checked = False


        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Private Sub Eliminar_Nextel()
        Try
            If ACTIVABD = True Then
                For Each dr As DataRow In TMP_CLIDEP.Rows
                    CAyuda.Ejecutar(2, "SP_DELETE_CLIENTE", VCODNEXTEL.Trim, dr.Item(0).ToString)
                Next
            End If
        Catch ex As Exception
            MsgBox("Problema de conexión con Nextel, intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try

    End Sub

    Sub Guardar_Nextel()

        Try



            If ACTIVABD = True Then
                Eliminar_Nextel()

                Dim clidp As New DataTable
                For Each dr As DataRow In TMP_CLIDEP.Rows
                    clidp = CAyuda.ListarDatos("SP_N_D_CLIENTE_DEP", codempresa.Trim, dr.Item(0).ToString).Tables(0)
                    If clidp.Rows.Count <> 0 Then
                        CAyuda.Ejecutar(2, "SP_N_INS_CLIENTE", VCODNEXTEL.Trim, clidp.Rows(0)(0), clidp.Rows(0)(1), clidp.Rows(0)(2), clidp.Rows(0)(3), clidp.Rows(0)(4), clidp.Rows(0)(5), clidp.Rows(0)(6))
                    End If
                Next


            End If
        Catch ex As Exception
            MsgBox("Problema de conexión con Nextel, intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try

    End Sub


    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        If FLAG = 0 Then
            Call limpia()
        End If
        Call BOTONES(True, False, True, False, True)
        Call bloquea(True, False)
        BTNCANCELAR.Enabled = False
        BuscarCliente()



    End Sub

    Dim i As Int32
    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Me.cbocliente.Text = "" Then
        '        Exit Sub
        '    End If

        '    For i = 0 To Me.ListView1.Items.Count - 1
        '        If Me.ListView1.Items(i).SubItems(1).Text = cod.Item(Me.cbocliente.SelectedIndex) Then
        '            MessageBox.Show("El Cliente Seleccionado ya ha sido Ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Exit Sub
        '        End If
        '    Next

        '    Dim m As New ListViewItem
        '    m.SubItems.Add(cod.Item(Me.cbocliente.SelectedIndex))
        '    m.SubItems.Add(Me.cbocliente.Text.Trim.ToUpper)
        '    Me.ListView1.Items.Add(m)

        '    Me.cbocliente.Focus()
        'Catch x As Exception
        '    MessageBox.Show(x.Message)
        'End Try
    End Sub

    Private Sub btnquitacliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Me.ListView1.Items.Count = 0 Then
        '        MessageBox.Show("No existen registros para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If


        '    Me.ListView1.Items.RemoveAt(Me.ListView1.FocusedItem.Index)
        'Catch x As Exception
        '    MessageBox.Show("Seleccione el Registro que desee quitar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
    End Sub

    Private Sub btnquitatodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.ListView1.Items.Count = 0 Then
        '    MessageBox.Show("No existen registros para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        'If MessageBox.Show("¿Desea eliminar todos los Clientes Dependientes?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    Me.ListView1.Items.Clear()
        'End If
    End Sub

    Sub bloquea(ByVal p As Boolean, ByVal p1 As Boolean)

        Dim a As Object

        For Each a In Me.TabControl1.Controls
            If TypeOf a Is TabPage Then
                Dim o As Object
                For Each o In a.controls
                    If TypeOf o Is TextBox Then
                        o.ReadOnly = p
                    End If
                Next
            End If
        Next

        Dim i As Object

        For Each i In Me.TabControl1.Controls
            If TypeOf i Is TabPage Then
                Dim b As Object
                For Each b In i.controls
                    b.Enabled = p1
                Next
            End If
        Next
        btnbuscar.Enabled = Not p1


    End Sub

    Sub limpia()
        Dim a As Object
        For Each a In Me.TabControl1.Controls
            If TypeOf a Is TabPage Then
                Dim o As Object
                For Each o In a.controls
                    If TypeOf o Is TextBox Then

                        o.text = ""


                    End If
                Next

            End If
        Next
        Me.tcredito.Text = "0"
        Me.tdescuento.Text = "0"
        Me.tsaldo.Text = "0"

        ChkActivo.Checked = False


    End Sub


    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress

        Call GBloqueaCaracter(Asc(e.KeyChar))

        If Asc(e.KeyChar) = 13 Then

            If tcodigo.Text.Trim = "" Then
                MessageBox.Show("Complete el codigo del Cliente Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Conecta("select codcliente from cliente where codcliente='" & Me.tcodigo.Text.Trim.ToUpper & "' AND CODEMPRESA = '" & codempresa & "'", "ver")
                If ds.Tables("ver").Rows.Count > 0 Then
                    MessageBox.Show("El codigo ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.tcodigo.Focus()
                    Exit Sub
                End If
            End If




            If CheckBox1.Checked = False Then
                Me.tpaterno.Focus()
                Me.tpaterno.SelectAll()
            End If

            If CheckBox1.Checked = True Then
                Me.trazon.Focus()
                Me.trazon.SelectAll()
            End If

        End If



    End Sub

    Private Sub tpaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tpaterno.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            'Conecta("select codcliente from cliente where (codcliente like '" & Strings.Left(Me.tpaterno.Text.Trim, 1) & "%' and estado=0) order by codcliente", "codigo")
            'If ds.Tables("codigo").Rows.Count = 0 Then
            '    Me.tcodigo.Text = Strings.Left(Me.tpaterno.Text.Trim.ToUpper, 1) + "00001"
            'Else
            '    Me.tcodigo.Text = Strings.Left(Me.tpaterno.Text.Trim.ToUpper, 1) + Strings.Right("00000" + CType(Val(Strings.Right(Trim(ds.Tables("codigo").Rows(ds.Tables("codigo").Rows.Count - 1)(0)), 5) + 1), String), 5)
            'End If
            Me.tmaterno.Focus()
            Me.tmaterno.SelectAll()
        End If
    End Sub

    Private Sub tmaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tmaterno.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            Me.tnombre.Focus()
            Me.tnombre.SelectAll()
        End If
    End Sub

    Private Sub tnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnombre.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            Me.tdni.Focus()
            Me.tdni.SelectAll()
        End If
    End Sub

    Private Sub trazon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles trazon.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            'Conecta("select codcliente from cliente where (codcliente like '" & Strings.Left(Me.trazon.Text.Trim, 1) & "%' and estado=0) order by codcliente", "codigo")
            'If ds.Tables("codigo").Rows.Count = 0 Then
            '    Me.tcodigo.Text = Strings.Left(Me.trazon.Text.Trim.ToUpper, 1) + "00001"
            'Else
            '    Me.tcodigo.Text = Strings.Left(Me.trazon.Text.Trim.ToUpper, 1) + Strings.Right("00000" + CType(Val(Strings.Right(Trim(ds.Tables("codigo").Rows(ds.Tables("codigo").Rows.Count - 1)(0)), 5) + 1), String), 5)
            'End If

            Me.truc.Focus()
            Me.truc.SelectAll()
        End If
    End Sub

    Private Sub tdni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdni.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            Me.tdireccion.Focus()
            Me.tdireccion.SelectAll()
        End If
    End Sub

    Private Sub truc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles truc.KeyPress

        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            Me.tdireccion.Focus()
            Me.tdireccion.SelectAll()
        End If
    End Sub

    Private Sub tdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdireccion.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            Me.ttelefono.Focus()
            Me.ttelefono.SelectAll()
        End If
    End Sub

    Private Sub ttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ttelefono.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            Me.txtfax.Focus()
            Me.txtfax.SelectAll()
        End If
    End Sub
    Private Sub czona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtctaBanca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CboTipoNegocio.Focus()
        End If
    End Sub
    Private Sub tsaldo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tsaldo.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            'Me.tcuotat.Focus()
            'Me.tcuotat.SelectAll()
        End If
    End Sub
    Private Sub tdescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdescuento.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tdescuento.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            cbFuerzaVta.Focus()
            'TabControl1.SelectedIndex = 2
            'TxtDirecDep.Focus()
            'TxtDirecDep.SelectAll()
        End If
    End Sub

    Private Sub tctaletra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tctaletra.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            Me.tctaanticipo.Focus()
            Me.tctaanticipo.SelectAll()
        End If
    End Sub

    Private Sub tctaanticipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tctaanticipo.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        If Asc(e.KeyChar) = 13 Then
            Me.tctaventa.Focus()
            Me.tctaventa.SelectAll()
        End If
    End Sub

    Private Sub tctaventa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tctaventa.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        'If Asc(e.KeyChar) = 13 Then
        '    Me.TabControl1.SelectedIndex = 2
        '    Me.cbocliente.Focus()
        'End If
    End Sub

    Private Sub cbocliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    Me.btnagregar.Focus()
        'End If
    End Sub

    Private Sub tmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tmail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cbopais.Focus()
        End If
    End Sub


    Private Sub ctipopago_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctipopago.Click

        Dim Proceso As String
        Proceso = "MODIFTIPOPAGO"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ctipopago_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctipopago.SelectedIndexChanged

        tipopago = CAyuda.ListarDatos("NSP_Select_MuestraCodPais", codempresa).Tables(0).Rows(0)(1)

        If ctipopago.SelectedValue.ToString() = tipopago Then

            CAyuda.CargarDataCombo(CmbForPago, "NSP_SELECT_LISTATIPCREDF '" & codempresa & "'", "TIPCREDFAC", "DESCREDFAC")
            Label16.Visible = True
            tcredito.Visible = True
            Label17.Visible = True
            tsaldo.Visible = True
            Label5.Visible = True
            CmbForPago.Visible = True
            TxtTotSaldoDisp.Enabled = False
        Else
            Label16.Visible = False
            tcredito.Visible = False
            Label17.Visible = False
            tsaldo.Visible = False
            Label5.Visible = False
            CmbForPago.Visible = False
        End If
    End Sub


    Private Sub cbopais_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbopais.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cdepa.Focus()
        End If
    End Sub

    Private Sub cbopais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopais.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cdepa, "sele_depa '" & cbopais.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")
        Catch x As Exception
        End Try
    End Sub


    Private Sub cciud_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cciud.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cdistrito.Focus()
        End If
    End Sub

    Public Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If tcodigo.ReadOnly = False Then
            tcodigo.Focus()
        End If

        If AINTOP = 1 Then
            If Me.CheckBox1.Checked = True Then
                truc.ReadOnly = False
                trazon.ReadOnly = False
                tpaterno.ReadOnly = True
                tmaterno.ReadOnly = True
                tnombre.ReadOnly = True
                tdni.ReadOnly = True
                trazon.Focus()
                trazon.SelectAll()

                tpaterno.Text = ""
                tmaterno.Text = ""
                tnombre.Text = ""
                tdni.Text = ""

            Else

                truc.Text = ""
                trazon.Text = ""

                truc.ReadOnly = True
                trazon.ReadOnly = True
                tpaterno.ReadOnly = False
                tmaterno.ReadOnly = False
                tnombre.ReadOnly = False
                tdni.ReadOnly = False
                tpaterno.Focus()
                tpaterno.SelectAll()
            End If
        End If
    End Sub

    Private Sub cmbptovta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'CAyuda.CargarDataCombo(cvendedor, "Nsp_SELECT_VENDEDORXPTOVTA '" & codempresa & "','" & cmbptovta.SelectedValue.ToString() & "'", "codvend", "dsvend")
        Catch
        End Try
    End Sub

    Private Sub BTAGREGAPTOVAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Me.cmbptovta.Text = "" Then
        '        MessageBox.Show("¿ INGRES0 PUNTO VENTA ?", "Información", MessageBoxButtons.OK, MessageBoxIcon.Question)
        '        Exit Sub
        '    End If

        '    If Me.cvendedor.Text = "" Then
        '        MessageBox.Show("¿ INGRES0 VENDEDOR ?", "Información", MessageBoxButtons.OK, MessageBoxIcon.Question)
        '        Exit Sub
        '    End If

        '    For i = 0 To Me.ListView3.Items.Count - 1
        '        If tcodigo.Text.Trim <> clientvarios Then
        '            If Me.ListView3.Items(i).SubItems(2).Text.Trim = Trim(Me.cmbptovta.SelectedValue.ToString()) Then
        '                MessageBox.Show("El Punto Venta Seleccionado ya ha sido Ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                Exit Sub
        '            End If
        '        Else
        '            If Me.ListView3.Items(i).SubItems(2).Text.Trim = Trim(Me.cmbptovta.SelectedValue) And Me.ListView3.Items(i).SubItems(3).Text = Me.cvendedor.Text Then
        '                MessageBox.Show("El Punto Venta y el Vendedor ya ha sido Ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                Exit Sub
        '            End If
        '        End If

        '    Next

        '    Dim m As New ListViewItem
        '    m.SubItems.Add(Me.cmbptovta.Text)
        '    m.SubItems.Add(Me.cmbptovta.SelectedValue.ToString())
        '    m.SubItems.Add(Me.cvendedor.Text)
        '    m.SubItems.Add(Me.cvendedor.SelectedValue.ToString())
        '    m.SubItems.Add(Me.tcuotat.Text)
        '    m.SubItems.Add(Me.tcuotas.Text)
        '    m.SubItems.Add(Me.tcuotad.Text)
        '    Me.ListView3.Items.Add(m)
        '    Me.cmbptovta.Focus()
        'Catch x As Exception
        '    MessageBox.Show(x.Message)
        'End Try
    End Sub

    Private Sub BTNQUITARSEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Me.ListView3.Items.Count = 0 Then
        '        MessageBox.Show("No existen registros para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If


        '    Me.ListView3.Items.RemoveAt(Me.ListView3.FocusedItem.Index)
        'Catch x As Exception
        '    MessageBox.Show("Seleccione el Registro que desee quitar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
    End Sub

    Private Sub BTNQUITARTODOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.ListView3.Items.Count = 0 Then
        '    MessageBox.Show("No existen registros para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        'If MessageBox.Show("¿Desea eliminar todos los Clientes Dependientes?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    Me.ListView3.Items.Clear()
        'End If
    End Sub

    Private Sub czona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtctaBanca.SelectedIndexChanged

    End Sub

    Private Sub txtfax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfax.TextChanged
        If IsNumeric(txtfax.Text) = False Then
            txtfax.Text = Space(0)
        End If
    End Sub

    Private Sub txtfax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfax.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tmail.Focus()
            Me.tmail.SelectAll()
        End If
    End Sub

    Private Sub txttelefonoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelefonoc.TextChanged
        If IsNumeric(txttelefonoc.Text) = False Then
            txttelefonoc.Text = Space(0)
        End If
    End Sub

    Private Sub txtcelularc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcelularc.TextChanged
        If IsNumeric(txtcelularc.Text) = False Then
            txtcelularc.Text = Space(0)
        End If
    End Sub
    Private Sub cmbptovta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'cvendedor.Focus()
        End If
    End Sub

    Private Sub cvendedor_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'tcuotat.Focus()
            'tcuotat.SelectAll()
        End If
    End Sub

    Private Sub tcuotat_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        'If Keyascii = 0 Then
        '    e.Handled = True
        '    MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.tcuotat.Focus()
        'End If


        'If Asc(e.KeyChar) = 13 Then
        '    Me.tcuotas.Focus()
        '    Me.tcuotas.SelectAll()
        'End If
    End Sub

    Private Sub tcuotas_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        'If Keyascii = 0 Then
        '    e.Handled = True
        '    MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Me.tcuotas.Focus()
        'End If

        'If Asc(e.KeyChar) = 13 Then
        '    Me.tcuotad.Focus()
        '    Me.tcuotad.SelectAll()
        'End If
    End Sub

    Private Sub tcuotad_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tdescuento.Focus()
        End If


        'If Asc(e.KeyChar) = 13 Then
        '    BTAGREGAPTOVAT_Click(sender, e)
        '    cmbptovta.Focus()
        '    tcuotat.Text = 0
        '    tcuotas.Text = 0
        '    tcuotad.Text = 0
        'End If
    End Sub


    'Private Sub tcuotad_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Trim(tcuotad.Text) = "" Then
    '        tcuotad.Text = 0
    '    End If
    'End Sub

    'Private Sub tcuotas_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Trim(tcuotas.Text) = "" Then
    '        tcuotas.Text = 0
    '    End If
    'End Sub

    'Private Sub tcuotat_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Trim(tcuotat.Text) = "" Then
    '        tcuotat.Text = 0
    '    End If
    'End Sub


    Private Sub cdepa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdepa.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cciud, "Nsp_select_Ciudad_combo2 '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "'", "Codigo", "Descripcion")
            CAyuda.CargarDataCombo(cmbciudad, "Nsp_select_Ciudad_combo2 '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "'", "Codigo", "Descripcion")
        Catch x As Exception
        End Try
    End Sub

    Private Sub cciud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cciud.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cdistrito, "Nsp_select_distrito '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "','" & cciud.SelectedValue.ToString & "'", "Codigo", "Descripcion")
            CAyuda.CargarDataCombo(cmbdist, "Nsp_select_distrito '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "','" & cciud.SelectedValue.ToString & "'", "Codigo", "Descripcion")
        Catch x As Exception
        End Try
    End Sub

    Private Sub cdepa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cdepa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cciud.Focus()
        End If
    End Sub

    Private Sub cdistrito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cdistrito.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtctaBanca.Focus()
        End If
    End Sub

    Dim EMP As Int16
    Dim ACTIVOCLIENTE As Int16

    Dim ACTIVO_ORT As Int16



    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked = True Then
            EMP = 1
        Else
            EMP = 0
        End If
    End Sub

    Private Sub tcredito_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcredito.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tcredito.Focus()
            Exit Sub
        End If

        If Keyascii = 13 Then
            If pb_agregar Then
                tsaldo.Text = tcredito.Text
            Else
                If tcredito.Text > MontoCred Then
                    MontoCred = tcredito.Text - MontoCred
                    tsaldo.Text = Format(tsaldo.Text + MontoCred, "0.00")
                Else
                    If tcredito.Text < MontoCred Then
                        MontoCred = MontoCred - tcredito.Text
                        tsaldo.Text = Format(tsaldo.Text - MontoCred, "0.00")
                    End If
                End If
            End If
            MontoCred = tcredito.Text
            btnAgregarF.Focus()
            'txtcontacto.Focus()
        End If

    End Sub

    Private Sub cvendedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tcuotad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tcuotad_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub tcuotas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tcuotat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ctipopago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipopago.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CmbForPago.Visible = True Then
                CmbForPago.Focus()
            Else
                cmbmoneda.Focus()
            End If
        End If
    End Sub

    Private Sub CmbForPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbForPago.KeyPress

        If Asc(e.KeyChar) = 13 Then
            cmbmoneda.Focus()
        End If

    End Sub

    Private Sub cmbmoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbmoneda.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TxtTotLimCred.Focus()
        End If

    End Sub

    Private Sub tcredito_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcredito.TextChanged


        tsaldo.Text = tcredito.Text

    End Sub

    Private Sub ctipoclie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctipoclie.SelectedIndexChanged

    End Sub


    Private Sub txtcontacto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontacto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txttelefonoc.Focus()
        End If
    End Sub

    Private Sub txttelefonoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefonoc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcelularc.Focus()
        End If
    End Sub

    Private Sub txtcelularc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcelularc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtemailc.Focus()
        End If
    End Sub

    Private Sub tctaventa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tctaventa.TextChanged

    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            Rpt1.ReportFileName = rutareporte & "Rpt_Clientes.rpt"
            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            Rpt1.set_StoredProcParam(0, codempresa)
            Rpt1.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
            Rpt1.set_Formulas(1, "Usuario= '" & dt.Rows(0)(1).ToString & "'")
            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt1.Action = 1
            Rpt1.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If HabiliTabPages = False Then
            Exit Sub
        End If

        If TabControl1.SelectedIndex <> 0 Then
            If tcodigo.Text.Trim = "" Then
                MsgBox("FALTA CODIGO DE CLIENTE..", MsgBoxStyle.Exclamation, "")
                TabControl1.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub CboTipoprecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoprecio.SelectedIndexChanged

    End Sub

    Private Sub CboTipoprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoprecio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TabControl1.SelectedIndex = 1
            Me.ctipopago.Focus()
        End If
    End Sub

    Private Sub CboRuta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CboTipoNegocio.Focus()
        End If
    End Sub

    Private Sub CboTipoNegocio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoNegocio.SelectedIndexChanged

    End Sub

    Private Sub CboTipoNegocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboTipoNegocio.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboTipoprecio.Focus()
        End If
    End Sub

    Private Sub CmbForPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbForPago.SelectedIndexChanged

    End Sub

    Private Sub cmbmoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmoneda.SelectedIndexChanged

    End Sub

    Private Sub txtemailc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemailc.TextChanged

    End Sub

    Private Sub txtemailc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtemailc.KeyDown
        If e.KeyCode = Keys.Enter Then
            ctipopago.Focus()
        End If
    End Sub

    Private Sub tdescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdescuento.TextChanged

    End Sub

    Private Sub btnAgregarF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarF.Click

        If IsNumeric(TxtTotLimCred.Text) = True Then

        Else
            MsgBox("El cliente tiene que tener crédito.", MsgBoxStyle.Information)
            TxtTotLimCred.Focus()
            Exit Sub
        End If


        If IsNumeric(tcredito.Text) = True Then

        Else
            MsgBox("Ingrese Límite de Crédito.", MsgBoxStyle.Information)
            tcredito.Focus()
            Exit Sub
        End If


        Dim MONTO As Double = tsaldo.Text

        If CDbl(tsaldo.Text) > CDbl(TxtTotLimCred.Text) Then
            MsgBox("El Saldo de Fuerza de Venta no puede ser Mayor a Total Limite Crédito.", MsgBoxStyle.Information)

            Exit Sub
        End If


        If VarEditarFv Then
            For ContA As Integer = 0 To dTablaFuerzaVenta.Rows.Count - 1
                If Me.cbFuerzaVta.SelectedValue.ToString.Trim = dTablaFuerzaVenta.Rows(ContA)("CODFUERZA").ToString.Trim Then
                    dTablaFuerzaVenta.Rows(ContA)("CREDITO_F") = tcredito.Text.Trim
                    dTablaFuerzaVenta.Rows(ContA)("SALDO_CREDF") = tsaldo.Text.Trim
                End If
                MONTO = MONTO + dTablaFuerzaVenta.Rows(ContA)("SALDO_CREDF")

                If MONTO >= TxtTotLimCred.Text Then
                    MsgBox("El Saldo de Fuerza de Venta no puede ser Mayor a Total Limite Crédito.", MsgBoxStyle.Information)

                    Exit Sub
                End If
            Next

            dTablaFuerzaVenta.AcceptChanges()
            dgMatrizFuerzas.DataSource = dTablaFuerzaVenta
            VarEditarFv = False
            Me.cbFuerzaVta.Enabled = True

        Else
            For ContA As Integer = 0 To dTablaFuerzaVenta.Rows.Count - 1

                If Me.cbFuerzaVta.SelectedValue.ToString.Trim = dTablaFuerzaVenta.Rows(ContA)("CODFUERZA").ToString.Trim Then
                    MsgBox("Ya Existe Esta Fuerza de Venta.", MsgBoxStyle.Information)

                    Exit Sub
                End If

                MONTO = MONTO + dTablaFuerzaVenta.Rows(ContA)("SALDO_CREDF")

                If MONTO > TxtTotLimCred.Text Then
                    MsgBox("El Saldo de Fuerza de Venta no puede ser Mayor a Total Limite Crédito.", MsgBoxStyle.Information)

                    Exit Sub
                End If

            Next

            If Me.tcredito.Text.Trim.Length = 0 Then
                MsgBox("Se debe de ingresar el monto del crédito para poder agregar.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim FilaFV As DataRow = dTablaFuerzaVenta.NewRow
            FilaFV(0) = Me.cbFuerzaVta.SelectedValue.ToString.Trim
            FilaFV(1) = Me.cbFuerzaVta.Text.Trim
            FilaFV(2) = Me.tcredito.Text.Trim
            FilaFV(3) = tsaldo.Text.Trim
            dTablaFuerzaVenta.Rows.Add(FilaFV)
            dTablaFuerzaVenta.AcceptChanges()
            dgMatrizFuerzas.DataSource = dTablaFuerzaVenta
        End If

        tcredito.Text = "0"


    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim VarCodFv As String

        If dTablaFuerzaVenta.Rows.Count > 0 Then
            If Not dgMatrizFuerzas(dgMatrizFuerzas.CurrentRowIndex, 0).ToString.Trim Is Nothing Then
                'If dgMatrizFuerzas.CurrentRowIndex  Then
                VarCodFv = dgMatrizFuerzas(dgMatrizFuerzas.CurrentRowIndex, 0).ToString.Trim
                For ContA As Integer = 0 To dTablaFuerzaVenta.Rows.Count - 1
                    If dTablaFuerzaVenta.Rows(ContA)("CODFUERZA").ToString.Trim = VarCodFv.Trim Then
                        If CDbl(dTablaFuerzaVenta.Rows(ContA)("CREDITO_F").ToString.Trim) = CDbl(dTablaFuerzaVenta.Rows(ContA)("SALDO_CREDF").ToString.Trim) Then
                            dTablaFuerzaVenta.Rows.RemoveAt(ContA)
                        Else
                            MsgBox("No se puede quitar la Fuerza de venta de este cliente, " & vbCrLf & "su  Límite de crédito sigue en uso.", MsgBoxStyle.Exclamation, "NARGEST / Maestra Clientes")
                            Exit Sub
                        End If
                        Exit For
                    End If
                Next
                Me.dgMatrizFuerzas.DataSource = dTablaFuerzaVenta
                Me.cbFuerzaVta.Enabled = True
                tcredito.Text = String.Empty
                tsaldo.Text = String.Empty
                pb_agregar = True
            End If
        End If

    End Sub

    Private Sub dgMatrizFuerzas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMatrizFuerzas.DoubleClick
        If Not dgMatrizFuerzas(dgMatrizFuerzas.CurrentRowIndex, 0) Is Nothing Then
            Dim VarCodFV As String
            VarCodFV = dgMatrizFuerzas(dgMatrizFuerzas.CurrentRowIndex, 0).ToString.Trim
            For ContF As Integer = 0 To dTablaFuerzaVenta.Rows.Count - 1
                If VarCodFV = dTablaFuerzaVenta.Rows(ContF)("CODFUERZA").ToString.Trim Then
                    Me.cbFuerzaVta.SelectedValue = dTablaFuerzaVenta.Rows(ContF)("CODFUERZA")
                    Me.tcredito.Text = dTablaFuerzaVenta.Rows(ContF)("CREDITO_F")
                    Me.tsaldo.Text = dTablaFuerzaVenta.Rows(ContF)("SALDO_CREDF")
                    VarEditarFv = True
                    MontoCred = dTablaFuerzaVenta.Rows(ContF)("CREDITO_F")
                    Me.cbFuerzaVta.Enabled = False
                    Me.tcredito.Focus()
                End If
            Next
        End If
    End Sub

    Private Sub CboTipoNegocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoNegocio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CboTipoprecio.Focus()
        End If
    End Sub

    Private Sub BtnBuscDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscDep.Click

        Dim FrmDep As New FrmBuscClientDepend
        FrmDep.ShowDialog()
        If FrmDep.DEVOLVER = False Then
            Exit Sub
        End If


        TxtCodDep.Text = FrmDep.GridCli.Item(FrmDep.GridCli.CurrentRowIndex, 0)
        TxtRzSocialDep.Text = FrmDep.GridCli.Item(FrmDep.GridCli.CurrentRowIndex, 1)
        TxtDirecDep.Text = FrmDep.GridCli.Item(FrmDep.GridCli.CurrentRowIndex, 2)
        TxtRucDep.Text = FrmDep.GridCli.Item(FrmDep.GridCli.CurrentRowIndex, 3)

    End Sub


    Private Sub BtnQuitPtoLleg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitPtoLleg.Click
        If TMP_PTOLLEGAD.Rows.Count > 0 Then
            TmpInsertDatos("SP_ELIM_TMPCLIPTOLLEGADA   '" & codempresa & "','" & CodUsuario & "','" & GridPtoLleg.Item(GridPtoLleg.CurrentRowIndex, 0) & "'")
            CargarGridPtoLlegad()
            FormatoGridPtoLlegad()
        End If
    End Sub

    Private Sub BtnAgregDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregDep.Click

        If TxtDniDep.Text.Trim.Length = 0 Then
            If TxtRucDep.Text.Trim.Length = 0 Then
                MessageBox.Show("Ingrese el DNI del clientes dependiente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tdni.Focus()
                Exit Sub
            End If
        End If

        If TxtRucDep.Text.Trim.Length = 0 Then
            If TxtDniDep.Text.Trim.Length = 0 Then
                MessageBox.Show("Ingrese el RUC del clientes dependiente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtRucDep.Focus()
                Exit Sub
            End If
        End If

        If TxtRucDep.Text.Length > 0 Then
            If TxtDniDep.Text.Length > 0 Then
                MsgBox("SI TIENE RUC NO PUEDE TENER DNI", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
        End If

        If TxtDniDep.Text.Length > 0 Then
            If TxtRucDep.Text.Length > 0 Then
                MsgBox("SI TIENE DNI NO PUEDE TENER RUC", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
        End If


        Dim ValidaCampos As Boolean
        'Call formatotextbox(Me)
        ValidaCampos = ValidarCamposAguardarDep()
        If ValidaCampos = False Then
            Exit Sub
        End If



        If TxtCodDep.Text.Trim = tcodigo.Text.Trim Then
            MsgBox("EL CODIGO DEL  CLIENTE DEPENDIENTE NO PUEDE SER IGUAL AL CLIENTE PRINCIPAL..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        'If TxtCodDep.Text.Trim.Length = 0 Then
        '    MsgBox("Ingrese Codigo Dependientes ...", MsgBoxStyle.Exclamation, "")
        '    TxtCodDep.Focus()
        '    Exit Sub
        'End If

        If cmbdist.SelectedValue = Nothing Then
            MsgBox("Tiene que selecionar un Distrito...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        'If TmpListarDatos("SELECT  * FROM CLIENTE  WHERE  CODCLIENTE='" & TxtCodDep.Text & "'  AND CODEMPRESA='" & codempresa & "'").Rows.Count > 0 Then
        '    MsgBox("YA EXISTE EL CODIGO DEL  CLIENTE DEPENDIENTE", MsgBoxStyle.Exclamation, "")
        '    Exit Sub
        'End If

        'If TmpListarDatos("SELECT  * FROM TMP_CLIDEP  WHERE  CODCLIENTE='" & TxtCodDep.Text & "'  AND CODEMPRESA='" & codempresa & "'").Rows.Count > 0 Then
        '    MsgBox("YA EXISTE EL CODIGO DEL  CLIENTE DEPENDIENTE", MsgBoxStyle.Exclamation, "")
        '    Exit Sub
        'End If



        If txtMPercepcion.Text.Length = 0 Then
            txtMPercepcion.Text = "0.0"
        End If


        If TxtRzSocialDep.Text.Length >= 40 Then
            MsgBox("NO PUEDE SER MAYOR A 40")
        End If

        If TxtRucDep.Text.Trim.Length > 0 Then
            Dim Estado_RucDep As Boolean
            Estado_RucDep = FACT_GValidaRUC(Me.TxtRucDep.Text)
            If Estado_RucDep = False Then
                Exit Sub
            End If
        End If

        If Me.TxtRucDep.Text.Trim <> "" Then
            'Conecta("select ruc from cliente where ruc='" & Me.TxtRucDep.Text.Trim.ToUpper & "' AND CODEMPRESA = '" & codempresa & "'", "ver")
            'If ds.Tables("ver").Rows.Count > 0 Then
            '    MessageBox.Show("LA RUC DEL CLIENTE DEPENDIENTE YA EXISTE...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
        End If

        If TxtRzSocialDep.Text.Trim.Length = 0 Then
            MsgBox("Ingrese Razon Social del Dependientes ...", MsgBoxStyle.Exclamation, "")
            TxtRzSocialDep.Focus()
            Exit Sub
        End If









        If FLAG = 0 Then
            Conecta("select * from cliente C INNER JOIN CLIDEP CD ON C.CODCLIENTE=CD.CODCLIENTE where C.DATOADJUNTO='" & TxtRzSocialDep.Text & "'", "ver")
            If ds.Tables("ver").Rows.Count > 0 Then
                MessageBox.Show("YA EXISTE EL RAZON SOCIAL DEL  CLIENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If FLAG = 1 Then
            Conecta("select * from cliente C INNER JOIN CLIDEP CD ON C.CODCLIENTE=CD.CODCLIENTE where C.DATOADJUNTO='" & TxtRzSocialDep.Text & "' and C.codcliente<>'" & TxtCodDep.Text & "'", "ver")
            If ds.Tables("ver").Rows.Count > 0 Then
                MessageBox.Show("YA EXISTE EL RAZON SOCIAL DEL  CLIENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If





        If TmpInsertDatos("SP_INSTMP_CLIDEP   '" & codempresa & "','" & CodUsuario & "','" & tcodigo.Text & "','" & TxtCodDep.Text & "','" & TxtRzSocialDep.Text & "','" & CboRutaDep.SelectedValue & "','" & cmbdist.SelectedValue & "'," & CDbl(txtMPercepcion.Text) & "," & CInt(ck_Nota_Pedido.Checked) & "," & CInt(ck_ort.Checked) & "," & CInt(ChkActivoClientDep.Checked)) Then




            Dim SQL As String
            Dim DS As New DataTable
            Dim CorrelCliedep As Double
            SQL = "SP_CORREL_CLIDEP '" & codempresa & "'"
            DS = TmpListarDatos(SQL)
            CorrelCliedep = DS.Rows(0)(0)




            Dim TB_MAXITEM As DataTable

            TB_MAXITEM = TmpListarDatos("SP_MAX_CLIDEP '" & codempresa & "','" & CodUsuario & "','" & tcodigo.Text & "'")
            Dim ITEM As Integer

            ITEM = TB_MAXITEM.Rows(0)(0).ToString
            'Dim CODIGODEP As String

            'Dim CORREL1 As String

            'CORREL1 = Microsoft.VisualBasic.Left(tcodigo.Text, 4)
            'CODIGODEP = String.Format(CORREL1 & "{0:0000}", ITEM)


            If TmpInsertDatos("SP_UPD_COD_CLIDEP   '" & codempresa & "','" & CodUsuario & "','" & ITEM & "','" & CorrelCliedep & "'," & CInt(ck_Nota_Pedido.Checked) & "," & CInt(ck_ort.Checked) & "," & CInt(ChkActivoClientDep.Checked)) Then

            End If

            If TmpInsertDatos("SP_INSTMP_CLIENTE  '" & codempresa & "','" & CorrelCliedep & "','" & TxtRzSocialDep.Text & "','" & TxtRucDep.Text & "','" & TxtDirecDep.Text & "','" & CboRutaDep.SelectedValue & "','" & tcodigo.Text & "','" & CodUsuario & "','" & cmbciudad.SelectedValue & "','" & cmbdist.SelectedValue & "'," & 0 & ",'" & "0" & "','" & ctipopago.SelectedValue & "','" & CDbl(txtMPercepcion.Text) & "','" & CStr(TxtDniDep.Text) & "','" & CStr(tmaternoM.Text) & "','" & CStr(tpaternoD.Text) & "','" & CStr(tnombreD.Text) & "'," & CInt(ChkActivoClientDep.Checked)) = False Then
                Exit Sub
            End If



            CargarGridCliDep()
            FormatoGridCliDep()
            TxtCodDep.Text = ""
            TxtRucDep.Text = ""
            TxtRzSocialDep.Text = ""
            TxtDirecDep.Text = ""
            TxtDniDep.Text = ""

            TxtCodDep.Focus()
        End If

    End Sub
    Private Sub BtnQuitDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitDep.Click
        If TMP_CLIDEP.Rows.Count > 0 Then
            If TmpInsertDatos("SP_DELETMP_CLIENTE     '" & codempresa & "','" & GridCliDep.Item(GridCliDep.CurrentRowIndex, 0) & "','" & tcodigo.Text & "','" & CodUsuario & "'") = False Then
                Exit Sub
            End If
            TmpInsertDatos("SP_ELI_TMP_CLIDEP   '" & codempresa & "','" & CodUsuario & "','" & GridCliDep.Item(GridCliDep.CurrentRowIndex, 0) & "'")




            TMP_CLIDEP = TmpListarDatos("SP_LISTAR_TMP_CLIDEP_2  '" & codempresa & "','" & tcodigo.Text & "','" & CodUsuario & "'")

            If TMP_CLIDEP.Rows.Count > 0 Then
                For x As Integer = 0 To TMP_CLIDEP.Rows.Count - 1
                    Dim CORREL1 As String
                    Dim CODIGODEP As String
                    Dim CODIGOANTERIOR As String
                    CORREL1 = Microsoft.VisualBasic.Left(tcodigo.Text, 4)
                    CODIGODEP = String.Format(CORREL1 & "{0:0000}", TMP_CLIDEP.Rows(x)(2))
                    CODIGOANTERIOR = TMP_CLIDEP.Rows(x)(4).ToString

                    If TmpInsertDatos("SP_UPD_COD_TMP_CLIENTE   '" & codempresa & "','" & CodUsuario & "','" & tcodigo.Text.ToString & "','" & CODIGOANTERIOR & "','" & CODIGODEP & "'") Then
                    End If


                    Dim ITEM As String
                    ITEM = TMP_CLIDEP.Rows(x)(2).ToString


                    If TmpInsertDatos("SP_UPD_COD_CLIDEP   '" & codempresa & "','" & CodUsuario & "','" & ITEM & "','" & CODIGODEP & "'," & CInt(ck_Nota_Pedido.Checked) & "," & CInt(ck_ort.Checked) & "") Then
                    End If
                Next
            End If







            CargarGridCliDep()
            FormatoGridCliDep()
        End If
    End Sub


    Private Sub TxtCodDep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodDep.TextChanged

    End Sub

    Private Sub TxtCodDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodDep.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.TxtRucDep.Focus()
        End If


    End Sub

    Private Sub tcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcodigo.TextChanged
        If IsNumeric(tcodigo.Text) = False Then
            tcodigo.Text = Space(0)
        End If
    End Sub

    Private Sub TxtRucDep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRucDep.TextChanged
        If IsNumeric(TxtRucDep.Text) = False Then
            TxtRucDep.Text = Space(0)
        End If
    End Sub

    Private Sub TxtRucDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRucDep.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.TxtRzSocialDep.Focus()
        End If

    End Sub

    Private Sub TxtRzSocialDep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRzSocialDep.TextChanged

    End Sub

    Private Sub TxtRzSocialDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRzSocialDep.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtDirecDep.Focus()
        End If
    End Sub

    Private Sub TxtDirecDep_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDirecDep.TextChanged

    End Sub

    Private Sub TxtDirecDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDirecDep.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.CboRutaDep.Focus()
        End If
    End Sub

    Private Sub CboRutaDep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboRutaDep.SelectedIndexChanged

    End Sub

    Private Sub CboRutaDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboRutaDep.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.cmbciudad.Focus()
        End If

    End Sub

    Private Sub cmbdist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdist.SelectedIndexChanged

    End Sub

    Private Sub cmbdist_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbdist.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BtnAgregDep.Focus()
        End If

    End Sub

    Private Sub CboRutaLlegada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboRutaLlegada.SelectedIndexChanged

    End Sub

    Private Sub txtcontacto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontacto.TextChanged

    End Sub

    Private Sub TxtTotLimCred_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtTotSaldoDisp.Text = TxtTotLimCred.Text

        If FLAG = 1 Then

            If TxtTotLimCred.Text = "" Then
                TxtTotLimCred.Text = 0
            End If

            If TxtLineaUtilidad.Text = "" Then
                TxtLineaUtilidad.Text = 0
            End If


            Dim x As Double

            Dim y As Double
            x = CDbl(TxtTotLimCred.Text)
            y = CDbl(TxtLineaUtilidad.Text)


            TxtTotSaldoDisp.Text = x - y

        End If







    End Sub

    Private Sub TxtTotLimCred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)


        If Asc(e.KeyChar) = 13 Then
            tdescuento.Focus()
        End If



    End Sub

    Private Sub TxtTotSaldoDisp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotSaldoDisp.TextChanged

    End Sub

    Private Sub TxtTotSaldoDisp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTotSaldoDisp.KeyPress

        If Asc(e.KeyChar) = 13 Then
            tdescuento.Focus()
        End If

    End Sub

    Private Sub cbFuerzaVta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFuerzaVta.SelectedIndexChanged

    End Sub

    Private Sub cbFuerzaVta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbFuerzaVta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tcredito.Focus()
        End If
    End Sub

    Private Sub TxtDirecLleg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDirecLleg.TextChanged

    End Sub

    Private Sub TxtDirecLleg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDirecLleg.KeyPress

        If Asc(e.KeyChar) = 13 Then
            CboRutaLlegada.Focus()
        End If


    End Sub

    Private Sub CboRutaLlegada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboRutaLlegada.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BtnAgregPtoLleg.Focus()
        End If

    End Sub

    Private Sub cmbciudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbciudad.SelectedIndexChanged

        Try
            CAyuda.CargarDataCombo(cmbdist, "Nsp_select_distrito '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "','" & cmbciudad.SelectedValue.ToString & "'", "Codigo", "Descripcion")
        Catch x As Exception
        End Try

    End Sub

    Private Sub cmbciudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbciudad.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.cmbdist.Focus()
        End If

    End Sub

    Private Sub tcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tcodigo.KeyDown

    End Sub

    Private Sub tdni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdni.TextChanged
        If IsNumeric(tdni.Text) = False Then
            tdni.Text = Space(0)
        End If
    End Sub

    Private Sub truc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles truc.TextChanged
        If IsNumeric(truc.Text) = False Then
            truc.Text = Space(0)
        End If
    End Sub

    Private Sub tsaldo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsaldo.TextChanged

    End Sub

    Private Sub BtnAgregPtoLleg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregPtoLleg.Click

        If TxtDirecLleg.Text.Trim.Length = 0 Then
            MsgBox("Ingrese Direccion llegada ...", MsgBoxStyle.Exclamation, "")
            TxtDirecLleg.Focus()
            Exit Sub
        End If

        If TmpInsertDatos("SP_INSTMP_CLIPTOLLEGADA   '" & codempresa & "','" & CodUsuario & "','" & tcodigo.Text & "','" & TxtDirecLleg.Text & "','" & CboRutaLlegada.SelectedValue & "','" & CboRutaLlegada.Text & "'") = True Then
            TxtDirecLleg.Text = ""
            TxtDirecLleg.Focus()
            CargarGridPtoLlegad()
            FormatoGridPtoLlegad()
        Else
            MsgBox("ERROR EN LA OPERACION..", MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC")
        End If
    End Sub

    Private Sub BtnAgregPtoLleg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BtnAgregPtoLleg.KeyPress

        If Asc(e.KeyChar) = 13 Then
            BtnAgregPtoLleg_Click(sender, e)
        End If

    End Sub

    Private Sub ChkActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkActivo.CheckedChanged

        If Me.ChkActivo.Checked = True Then
            ACTIVOCLIENTE = 1
        Else
            ACTIVOCLIENTE = 0
        End If

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FrmBusClie As New FrmReporteCliente_2
        FrmBusClie.ShowDialog()
    End Sub

    Private Sub cdistrito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdistrito.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Try
            Dim saveImage As New SaveFileDialog 'Este es el SaveFileDialog
            Dim ruta As String = "" 'Para tener la ruta de la imagen

            saveImage.Title = "Guardar imagen como..." 'Título de la ventana
            ' saveImage.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen

            saveImage.Filter = "Imagen JPG (*.jpg)|*.jpg" 'Los formatos en que se guardará la imagen






            If saveImage.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                PictureBox1.Image = Image.FromFile(saveImage.FileName)

                rutaimagen = saveImage.FileName
            End If
        Catch ex As Exception
            MsgBox("Ocurrió el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Try
            Dim saveImage As New SaveFileDialog 'Este es el SaveFileDialog
            Dim ruta As String = "" 'Para tener la ruta de la imagen

            saveImage.Title = "Guardar imagen como..." 'Título de la ventana
            ' saveImage.Filter = "Imagen BMP (*.bmp)|*.bmp|Imagen JPG (*.jpg)|*.jpg|Imagen PNG (*.png)|*.png" 'Los formatos en que se guardará la imagen

            saveImage.Filter = "Imagen JPG (*.jpg)|*.jpg" 'Los formatos en que se guardará la imagen

            If saveImage.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(saveImage.FileName)
                rutaimagen2 = saveImage.FileName
            End If
        Catch ex As Exception
            MsgBox("Ocurrió el siguiente error: " & ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try





    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            Rpt1.ReportFileName = rutareporte & "Reporte_ClienteDepPer.rpt"
            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            Rpt1.set_StoredProcParam(0, codempresa)
            Rpt1.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
            Rpt1.set_Formulas(1, "Usuario= '" & dt.Rows(0)(1).ToString & "'")
            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt1.Action = 1
            Rpt1.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub GridCliDep_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCliDep.DoubleClick

        VAR1 = GridCliDep.Item(GridCliDep.CurrentRowIndex, 0)
        VAR2 = GridCliDep.Item(GridCliDep.CurrentRowIndex, 1)

        TxtCodDep.Text = GridCliDep.Item(GridCliDep.CurrentRowIndex, 0).ToString

        Dim TB_BUSQCLIDEP As DataTable

        TB_BUSQCLIDEP = TmpListarDatos("NSP_LISTA_CLIENTEDEP '" & codempresa & "','" & GridCliDep.Item(GridCliDep.CurrentRowIndex, 0) & "','" & CodUsuario & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then


            VAR1 = TB_BUSQCLIDEP.Rows(0)(1).ToString()
            TxtRucDep.Text = TB_BUSQCLIDEP.Rows(0)(3).ToString()
            TxtRzSocialDep.Text = TB_BUSQCLIDEP.Rows(0)(2).ToString()
            TxtDirecDep.Text = TB_BUSQCLIDEP.Rows(0)(4).ToString()
            cmbciudad.SelectedValue = TB_BUSQCLIDEP.Rows(0)(6).ToString()
            cmbdist.SelectedValue = TB_BUSQCLIDEP.Rows(0)(8).ToString()
            CboRutaDep.SelectedValue = TB_BUSQCLIDEP.Rows(0)(5).ToString()
            txtMPercepcion.Text = TB_BUSQCLIDEP.Rows(0)(9).ToString()
            ck_Nota_Pedido.Checked = CBool(TB_BUSQCLIDEP.Rows(0)(11).ToString)
            ck_ort.Checked = CBool(TB_BUSQCLIDEP.Rows(0)(12).ToString)
            TxtDniDep.Text = TB_BUSQCLIDEP.Rows(0)(13).ToString()
            'ChkActivoClientDep.Checked = CBool(TB_BUSQCLIDEP.Rows(0)(10).ToString)

        End If




    End Sub

    Private Sub GridCliDep_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridCliDep.Navigate

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click





        If TxtRucDep.Text.Length > 0 Then
            If TxtDniDep.Text.Length > 0 Then
                MsgBox("SI TIENE RUC NO PUEDE TENER DNI", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
        End If

        If TxtDniDep.Text.Length > 0 Then
            If TxtRucDep.Text.Length > 0 Then
                MsgBox("SI TIENE DNI NO PUEDE TENER RUC", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
        End If



        If TxtCodDep.Text.Trim = tcodigo.Text.Trim Then
            MsgBox("EL CODIGO DEL  CLIENTE DEPENDIENTE NO PUEDE SER IGUAL AL CLIENTE PRINCIPAL..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If FLAG = 0 Then
            Conecta("select * from cliente C INNER JOIN CLIDEP CD ON C.CODCLIENTE=CD.CODCLIENTE where C.DATOADJUNTO='" & TxtRzSocialDep.Text & "'", "ver")
            If ds.Tables("ver").Rows.Count > 0 Then
                MessageBox.Show("YA EXISTE EL RAZON SOCIAL DEL  CLIENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If FLAG = 1 Then
            Conecta("select * from cliente C INNER JOIN CLIDEP CD ON C.CODCLIENTE=CD.CODCLIENTE where C.DATOADJUNTO='" & TxtRzSocialDep.Text & "' and C.codcliente<>'" & TxtCodDep.Text & "'", "ver")
            If ds.Tables("ver").Rows.Count > 0 Then
                MessageBox.Show("YA EXISTE EL RAZON SOCIAL DEL  CLIENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If







        'If TxtCodDep.Text.Trim.Length = 0 Then
        '    MsgBox("Ingrese Codigo Dependientes ...", MsgBoxStyle.Exclamation, "")
        '    TxtCodDep.Focus()
        '    Exit Sub
        'End If

        If cmbdist.SelectedValue = Nothing Then
            MsgBox("Tiene que selecionar un Distrito...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        'If TmpListarDatos("SELECT  * FROM CLIENTE  WHERE  CODCLIENTE='" & TxtCodDep.Text & "'  AND CODEMPRESA='" & codempresa & "'").Rows.Count > 0 Then
        '    MsgBox("YA EXISTE EL CODIGO DEL  CLIENTE DEPENDIENTE", MsgBoxStyle.Exclamation, "")
        '    Exit Sub
        'End If

        'If TmpListarDatos("SELECT  * FROM TMP_CLIDEP  WHERE  CODCLIENTE='" & TxtCodDep.Text & "'  AND CODEMPRESA='" & codempresa & "'").Rows.Count > 0 Then
        '    MsgBox("YA EXISTE EL CODIGO DEL  CLIENTE DEPENDIENTE", MsgBoxStyle.Exclamation, "")
        '    Exit Sub
        'End If



        If txtMPercepcion.Text.Length = 0 Then
            txtMPercepcion.Text = "0.0"
        End If


        If TxtRzSocialDep.Text.Length >= 40 Then
            MsgBox("NO PUEDE SER MAYOR A 40")
        End If

        If TxtRucDep.Text.Trim.Length > 0 Then
            Dim Estado_RucDep As Boolean
            Estado_RucDep = FACT_GValidaRUC(Me.TxtRucDep.Text)
            If Estado_RucDep = False Then
                Exit Sub
            End If
        End If

        If Me.TxtRucDep.Text.Trim <> "" Then
            'Conecta("select ruc from cliente where ruc='" & Me.TxtRucDep.Text.Trim.ToUpper & "' AND CODEMPRESA = '" & codempresa & "'", "ver")
            'If ds.Tables("ver").Rows.Count > 0 Then
            '    MessageBox.Show("LA RUC DEL CLIENTE DEPENDIENTE YA EXISTE...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
        End If

        If TxtRzSocialDep.Text.Trim.Length = 0 Then
            MsgBox("Ingrese Razon Social del Dependientes ...", MsgBoxStyle.Exclamation, "")
            TxtRzSocialDep.Focus()
            Exit Sub
        End If



        If TmpInsertDatos("SP_UPDTMP_CLIDEP   '" & codempresa & "','" & CodUsuario & "','" & tcodigo.Text & "','" & TxtCodDep.Text & "','" & TxtRzSocialDep.Text & "','" & CboRutaDep.SelectedValue & "','" & cmbdist.SelectedValue & "'," & CDbl(txtMPercepcion.Text) & "," & CInt(ck_Nota_Pedido.Checked) & "," & CInt(ck_ort.Checked) & "," & CInt(ChkActivoClientDep.Checked)) Then
            If TmpInsertDatos("SP_UPDTMP_CLIENTE  '" & codempresa & "','" & TxtCodDep.Text & "','" & TxtRzSocialDep.Text & "','" & TxtRucDep.Text & "','" & TxtDirecDep.Text & "','" & CboRutaDep.SelectedValue & "','" & tcodigo.Text & "','" & CodUsuario & "','" & cmbciudad.SelectedValue & "','" & cmbdist.SelectedValue & "'," & 0 & ",'" & "0" & "','" & ctipopago.SelectedValue & "','" & CDbl(txtMPercepcion.Text) & "','" & TxtDniDep.Text & "','" & tmaternoM.Text & "','" & tpaternoD.Text & "','" & tnombreD.Text & "','" & CInt(ChkActivoClientDep.Checked) & "'") = False Then
                Exit Sub
            End If
        End If


        CargarGridCliDep()
        FormatoGridCliDep()
        TxtCodDep.Text = ""
        TxtRucDep.Text = ""
        TxtRzSocialDep.Text = ""
        TxtDirecDep.Text = ""
        TxtCodDep.Focus()

    End Sub

    Private Sub TxtLineaUtilidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLineaUtilidad.TextChanged


        If IsNumeric(TxtTotLimCred.Text) And IsNumeric(TxtLineaUtilidad.Text) Then
            TxtTotSaldoDisp.Text = CDbl(TxtTotLimCred.Text) - CDbl(TxtLineaUtilidad.Text)

        End If




    End Sub

    Private Sub TxtTotLimCred_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotLimCred.TextChanged

    End Sub

    Private Sub chkOr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOr.CheckedChanged

        If Me.chkOr.Checked = True Then
            ACTIVO_ORT = 1
        Else
            ACTIVO_ORT = 0
        End If

    End Sub

    Private Sub TxtPedidoUtilizado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPedidoUtilizado.TextChanged
        If IsNumeric(TxtTotLimCred.Text) And IsNumeric(TxtLineaUtilidad.Text) And IsNumeric(TxtPedidoUtilizado.Text) Then
            TxtTotSaldoDisp2.Text = CDbl(TxtTotLimCred.Text) - CDbl(TxtLineaUtilidad.Text) - CDbl(TxtPedidoUtilizado.Text)

        End If
    End Sub

    Private Sub TxtRucDNI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDniDep.TextChanged
        If IsNumeric(tdni.Text) = False Then
            tdni.Text = Space(0)
        End If
    End Sub

    Private Sub tnombreD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tnombreD.TextChanged

    End Sub

    Private Sub txtMPercepcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMPercepcion.TextChanged

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








    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Si.CheckedChanged

        If rb_Si.Checked = True Then
            Label58.Visible = True
            Label59.Visible = True
            txtCantidad.Visible = True
            txtObservacion.Visible = True

            COOLER = 1
        End If

        If rb_No.Checked = True Then
            Label58.Visible = False
            Label59.Visible = False
            txtCantidad.Visible = False
            txtObservacion.Visible = False

            COOLER = 0
        End If

    End Sub

    Private Sub Label64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label64.Click

    End Sub

    Private Sub txtDiasVisita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiasVisita.KeyPress
        'Call GBloqueaCaracter(Asc(e.KeyChar))
        'If Asc(e.KeyChar) = 13 Then
        '    Me.txtDiasVisita.Focus()
        '    Me.txtDiasVisita.SelectAll()
        'End If

        'Call GBloqueaCaracter(Asc(e.KeyChar))

        'If Asc(e.KeyChar) = 13 Then
        'End If

        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Then
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

    Private Sub txtDiasVisita_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiasVisita.TextChanged

    End Sub

    Private Sub txtMPercepcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMPercepcion.KeyPress

    End Sub

    Private Sub tpaterno_TextChanged(sender As Object, e As EventArgs) Handles tpaterno.TextChanged

    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub
End Class

