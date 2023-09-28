Public Class frmarticulos
    Inherits System.Windows.Forms.Form

    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""
    Friend WithEvents ckPercepcion2 As System.Windows.Forms.CheckBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ckNPTienda As System.Windows.Forms.CheckBox
    Dim Todo_Cate As Int16
    Friend WithEvents DgAlmacen As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents btnAgregarCom As System.Windows.Forms.Button
    Friend WithEvents btnQuitarCom As System.Windows.Forms.Button
    Friend WithEvents CboTipoComision As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label41 As Label
    Friend WithEvents cboCatABC As ComboBox
    Friend WithEvents txtCodBarra As TextBox
    Friend WithEvents Label42 As Label

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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnbus As System.Windows.Forms.Button
    Friend WithEvents cboimpuesto As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodarticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblttipoa As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GRIDPROVEEDOR As System.Windows.Forms.DataGrid
    Friend WithEvents frameproveedor As System.Windows.Forms.GroupBox
    Friend WithEvents btnelim As System.Windows.Forms.Button
    Friend WithEvents btnagre As System.Windows.Forms.Button
    Friend WithEvents chkactiprove As System.Windows.Forms.CheckBox
    Friend WithEvents borrarlo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodcompra As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtdescrip As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cboproveedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkfacturar As System.Windows.Forms.CheckBox
    Friend WithEvents ctrlmontocosto As AxMiControl.AxCtrlNumber
    Friend WithEvents cbosublinea As System.Windows.Forms.ComboBox
    Friend WithEvents cbolinea As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtDesArti As System.Windows.Forms.TextBox
    Friend WithEvents TxtDesArti2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarPresent As System.Windows.Forms.Button
    Friend WithEvents txtDescripPresent As System.Windows.Forms.TextBox
    Friend WithEvents btnQuitarPrest As System.Windows.Forms.Button
    Friend WithEvents lblAlm As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents btnAgrAlma As System.Windows.Forms.Button
    Friend WithEvents btnQuitAlma As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtStockMini As System.Windows.Forms.TextBox
    Friend WithEvents TxtStockMax As System.Windows.Forms.TextBox
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtUltimoIngreso As System.Windows.Forms.TextBox
    Friend WithEvents txtUltimaSalida As System.Windows.Forms.TextBox
    Friend WithEvents txtStockActual As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtStockInicio As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents grpPresentacion As System.Windows.Forms.GroupBox
    Friend WithEvents GrpAlmacen As System.Windows.Forms.GroupBox
    Friend WithEvents lblPesoKg As System.Windows.Forms.Label
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboIsc As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ckPagoEfectivo As System.Windows.Forms.CheckBox
    Friend WithEvents ckNotaPedido As System.Windows.Forms.CheckBox
    Friend WithEvents ckRestringVenta As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPreciArt As System.Windows.Forms.TextBox
    Friend WithEvents AxCtrlCubicaje As System.Windows.Forms.TextBox
    Friend WithEvents AxCtrlComision As System.Windows.Forms.TextBox
    Friend WithEvents AxCtrlDescuento As System.Windows.Forms.TextBox
    Friend WithEvents AxCtrtPesoKg As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GrpPresent As System.Windows.Forms.GroupBox
    Friend WithEvents LblArticulo As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents BtnPresent As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CboPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents BtInsPrest As System.Windows.Forms.Button
    Friend WithEvents BtnDeletPresnt As System.Windows.Forms.Button
    Friend WithEvents TxtCodPres As System.Windows.Forms.TextBox
    Friend WithEvents TxtEquiv As System.Windows.Forms.TextBox
    Friend WithEvents DgPresentac As System.Windows.Forms.DataGrid
    Friend WithEvents LblPresent As System.Windows.Forms.Label
    Friend WithEvents CboTipoPrecio As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtMargen As System.Windows.Forms.TextBox
    Friend WithEvents DgPreciart As System.Windows.Forms.DataGrid
    Friend WithEvents ckPercepcion1 As System.Windows.Forms.CheckBox
    Friend WithEvents ckDistribucion As System.Windows.Forms.CheckBox
    Friend WithEvents ckCombo As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents CboTipoPrecio2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarDesc As System.Windows.Forms.Button
    Friend WithEvents btnQuitarDesc As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents LblEquiv As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmarticulos))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cboCatABC = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ckNPTienda = New System.Windows.Forms.CheckBox()
        Me.ckPercepcion2 = New System.Windows.Forms.CheckBox()
        Me.ckCombo = New System.Windows.Forms.CheckBox()
        Me.ckDistribucion = New System.Windows.Forms.CheckBox()
        Me.ckPercepcion1 = New System.Windows.Forms.CheckBox()
        Me.chkfacturar = New System.Windows.Forms.CheckBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.ckNotaPedido = New System.Windows.Forms.CheckBox()
        Me.ckPagoEfectivo = New System.Windows.Forms.CheckBox()
        Me.AxCtrlCubicaje = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CboIsc = New System.Windows.Forms.ComboBox()
        Me.lblPesoKg = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDesArti = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnbus = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDesArti2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodarticulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblttipoa = New System.Windows.Forms.Label()
        Me.cbosublinea = New System.Windows.Forms.ComboBox()
        Me.cbolinea = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cboimpuesto = New System.Windows.Forms.ComboBox()
        Me.AxCtrlComision = New System.Windows.Forms.TextBox()
        Me.AxCtrlDescuento = New System.Windows.Forms.TextBox()
        Me.AxCtrtPesoKg = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DgPresentac = New System.Windows.Forms.DataGrid()
        Me.GrpPresent = New System.Windows.Forms.GroupBox()
        Me.TxtCodPres = New System.Windows.Forms.TextBox()
        Me.BtInsPrest = New System.Windows.Forms.Button()
        Me.BtnDeletPresnt = New System.Windows.Forms.Button()
        Me.LblArticulo = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.BtnPresent = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LblPresent = New System.Windows.Forms.Label()
        Me.TxtEquiv = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.grpPresentacion = New System.Windows.Forms.GroupBox()
        Me.TxtMargen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboTipoPrecio = New System.Windows.Forms.ComboBox()
        Me.CboPresentacion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPreciArt = New System.Windows.Forms.TextBox()
        Me.btnAgregarPresent = New System.Windows.Forms.Button()
        Me.btnQuitarPrest = New System.Windows.Forms.Button()
        Me.ckRestringVenta = New System.Windows.Forms.CheckBox()
        Me.LblEquiv = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DgPreciart = New System.Windows.Forms.DataGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDescripPresent = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgAlmacen = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.GrpAlmacen = New System.Windows.Forms.GroupBox()
        Me.txtStockInicio = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtUltimaSalida = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtUltimoIngreso = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboAlmacen = New System.Windows.Forms.ComboBox()
        Me.TxtStockMini = New System.Windows.Forms.TextBox()
        Me.lblAlm = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtStockMax = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnAgrAlma = New System.Windows.Forms.Button()
        Me.btnQuitAlma = New System.Windows.Forms.Button()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GRIDPROVEEDOR = New System.Windows.Forms.DataGrid()
        Me.frameproveedor = New System.Windows.Forms.GroupBox()
        Me.ctrlmontocosto = New AxMiControl.AxCtrlNumber()
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btnagre = New System.Windows.Forms.Button()
        Me.chkactiprove = New System.Windows.Forms.CheckBox()
        Me.borrarlo = New System.Windows.Forms.TextBox()
        Me.txtcodcompra = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cbomoneda = New System.Windows.Forms.ComboBox()
        Me.txtdescrip = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.btnAgregarDesc = New System.Windows.Forms.Button()
        Me.btnQuitarDesc = New System.Windows.Forms.Button()
        Me.CboTipoPrecio2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarCom = New System.Windows.Forms.Button()
        Me.btnQuitarCom = New System.Windows.Forms.Button()
        Me.CboTipoComision = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGrid2 = New System.Windows.Forms.DataGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCodBarra = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.DgPresentac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpPresent.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.grpPresentacion.SuspendLayout()
        CType(Me.DgPreciart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpAlmacen.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.GRIDPROVEEDOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frameproveedor.SuspendLayout()
        CType(Me.ctrlmontocosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TabControl1
        '
        Me.TabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtCodBarra)
        Me.TabPage1.Controls.Add(Me.Label42)
        Me.TabPage1.Controls.Add(Me.Label41)
        Me.TabPage1.Controls.Add(Me.cboCatABC)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.AxCtrlCubicaje)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CboIsc)
        Me.TabPage1.Controls.Add(Me.lblPesoKg)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.TxtDesArti)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnbus)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TxtDesArti2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtcodarticulo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.lblttipoa)
        Me.TabPage1.Controls.Add(Me.cbosublinea)
        Me.TabPage1.Controls.Add(Me.cbolinea)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.cboimpuesto)
        Me.TabPage1.Controls.Add(Me.AxCtrlComision)
        Me.TabPage1.Controls.Add(Me.AxCtrlDescuento)
        Me.TabPage1.Controls.Add(Me.AxCtrtPesoKg)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label41
        '
        resources.ApplyResources(Me.Label41, "Label41")
        Me.Label41.Name = "Label41"
        '
        'cboCatABC
        '
        Me.cboCatABC.FormattingEnabled = True
        resources.ApplyResources(Me.cboCatABC, "cboCatABC")
        Me.cboCatABC.Name = "cboCatABC"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ckNPTienda)
        Me.Panel1.Controls.Add(Me.ckPercepcion2)
        Me.Panel1.Controls.Add(Me.ckCombo)
        Me.Panel1.Controls.Add(Me.ckDistribucion)
        Me.Panel1.Controls.Add(Me.ckPercepcion1)
        Me.Panel1.Controls.Add(Me.chkfacturar)
        Me.Panel1.Controls.Add(Me.chkEstado)
        Me.Panel1.Controls.Add(Me.ckNotaPedido)
        Me.Panel1.Controls.Add(Me.ckPagoEfectivo)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'ckNPTienda
        '
        resources.ApplyResources(Me.ckNPTienda, "ckNPTienda")
        Me.ckNPTienda.Name = "ckNPTienda"
        '
        'ckPercepcion2
        '
        resources.ApplyResources(Me.ckPercepcion2, "ckPercepcion2")
        Me.ckPercepcion2.Name = "ckPercepcion2"
        '
        'ckCombo
        '
        resources.ApplyResources(Me.ckCombo, "ckCombo")
        Me.ckCombo.Name = "ckCombo"
        '
        'ckDistribucion
        '
        resources.ApplyResources(Me.ckDistribucion, "ckDistribucion")
        Me.ckDistribucion.Name = "ckDistribucion"
        '
        'ckPercepcion1
        '
        resources.ApplyResources(Me.ckPercepcion1, "ckPercepcion1")
        Me.ckPercepcion1.Name = "ckPercepcion1"
        '
        'chkfacturar
        '
        resources.ApplyResources(Me.chkfacturar, "chkfacturar")
        Me.chkfacturar.Name = "chkfacturar"
        '
        'chkEstado
        '
        resources.ApplyResources(Me.chkEstado, "chkEstado")
        Me.chkEstado.Name = "chkEstado"
        '
        'ckNotaPedido
        '
        resources.ApplyResources(Me.ckNotaPedido, "ckNotaPedido")
        Me.ckNotaPedido.Name = "ckNotaPedido"
        '
        'ckPagoEfectivo
        '
        resources.ApplyResources(Me.ckPagoEfectivo, "ckPagoEfectivo")
        Me.ckPagoEfectivo.Name = "ckPagoEfectivo"
        '
        'AxCtrlCubicaje
        '
        resources.ApplyResources(Me.AxCtrlCubicaje, "AxCtrlCubicaje")
        Me.AxCtrlCubicaje.Name = "AxCtrlCubicaje"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'CboIsc
        '
        Me.CboIsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboIsc, "CboIsc")
        Me.CboIsc.Name = "CboIsc"
        '
        'lblPesoKg
        '
        resources.ApplyResources(Me.lblPesoKg, "lblPesoKg")
        Me.lblPesoKg.Name = "lblPesoKg"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'TxtDesArti
        '
        Me.TxtDesArti.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtDesArti, "TxtDesArti")
        Me.TxtDesArti.Name = "TxtDesArti"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnbus
        '
        resources.ApplyResources(Me.btnbus, "btnbus")
        Me.btnbus.ImageList = Me.ImageList1
        Me.btnbus.Name = "btnbus"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'TxtDesArti2
        '
        Me.TxtDesArti2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TxtDesArti2, "TxtDesArti2")
        Me.TxtDesArti2.Name = "TxtDesArti2"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtcodarticulo
        '
        Me.txtcodarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtcodarticulo, "txtcodarticulo")
        Me.txtcodarticulo.Name = "txtcodarticulo"
        Me.txtcodarticulo.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblttipoa
        '
        resources.ApplyResources(Me.lblttipoa, "lblttipoa")
        Me.lblttipoa.Name = "lblttipoa"
        '
        'cbosublinea
        '
        Me.cbosublinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbosublinea, "cbosublinea")
        Me.cbosublinea.Name = "cbosublinea"
        '
        'cbolinea
        '
        Me.cbolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbolinea, "cbolinea")
        Me.cbolinea.Name = "cbolinea"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'cboimpuesto
        '
        Me.cboimpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboimpuesto, "cboimpuesto")
        Me.cboimpuesto.Name = "cboimpuesto"
        '
        'AxCtrlComision
        '
        resources.ApplyResources(Me.AxCtrlComision, "AxCtrlComision")
        Me.AxCtrlComision.Name = "AxCtrlComision"
        '
        'AxCtrlDescuento
        '
        resources.ApplyResources(Me.AxCtrlDescuento, "AxCtrlDescuento")
        Me.AxCtrlDescuento.Name = "AxCtrlDescuento"
        '
        'AxCtrtPesoKg
        '
        resources.ApplyResources(Me.AxCtrtPesoKg, "AxCtrtPesoKg")
        Me.AxCtrtPesoKg.Name = "AxCtrtPesoKg"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DgPresentac)
        Me.TabPage6.Controls.Add(Me.GrpPresent)
        resources.ApplyResources(Me.TabPage6, "TabPage6")
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DgPresentac
        '
        resources.ApplyResources(Me.DgPresentac, "DgPresentac")
        Me.DgPresentac.DataMember = ""
        Me.DgPresentac.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgPresentac.Name = "DgPresentac"
        Me.DgPresentac.ReadOnly = True
        '
        'GrpPresent
        '
        Me.GrpPresent.Controls.Add(Me.TxtCodPres)
        Me.GrpPresent.Controls.Add(Me.BtInsPrest)
        Me.GrpPresent.Controls.Add(Me.BtnDeletPresnt)
        Me.GrpPresent.Controls.Add(Me.LblArticulo)
        Me.GrpPresent.Controls.Add(Me.Label33)
        Me.GrpPresent.Controls.Add(Me.BtnPresent)
        Me.GrpPresent.Controls.Add(Me.Label34)
        Me.GrpPresent.Controls.Add(Me.LblPresent)
        Me.GrpPresent.Controls.Add(Me.TxtEquiv)
        Me.GrpPresent.Controls.Add(Me.Label36)
        resources.ApplyResources(Me.GrpPresent, "GrpPresent")
        Me.GrpPresent.Name = "GrpPresent"
        Me.GrpPresent.TabStop = False
        '
        'TxtCodPres
        '
        resources.ApplyResources(Me.TxtCodPres, "TxtCodPres")
        Me.TxtCodPres.Name = "TxtCodPres"
        '
        'BtInsPrest
        '
        resources.ApplyResources(Me.BtInsPrest, "BtInsPrest")
        Me.BtInsPrest.Name = "BtInsPrest"
        Me.BtInsPrest.TabStop = False
        '
        'BtnDeletPresnt
        '
        resources.ApplyResources(Me.BtnDeletPresnt, "BtnDeletPresnt")
        Me.BtnDeletPresnt.Name = "BtnDeletPresnt"
        Me.BtnDeletPresnt.TabStop = False
        '
        'LblArticulo
        '
        Me.LblArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblArticulo, "LblArticulo")
        Me.LblArticulo.Name = "LblArticulo"
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.Name = "Label33"
        '
        'BtnPresent
        '
        resources.ApplyResources(Me.BtnPresent, "BtnPresent")
        Me.BtnPresent.ImageList = Me.ImageList1
        Me.BtnPresent.Name = "BtnPresent"
        '
        'Label34
        '
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.Name = "Label34"
        '
        'LblPresent
        '
        Me.LblPresent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblPresent, "LblPresent")
        Me.LblPresent.Name = "LblPresent"
        '
        'TxtEquiv
        '
        resources.ApplyResources(Me.TxtEquiv, "TxtEquiv")
        Me.TxtEquiv.Name = "TxtEquiv"
        '
        'Label36
        '
        resources.ApplyResources(Me.Label36, "Label36")
        Me.Label36.Name = "Label36"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.grpPresentacion)
        Me.TabPage3.Controls.Add(Me.DgPreciart)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.txtDescripPresent)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'grpPresentacion
        '
        Me.grpPresentacion.Controls.Add(Me.TxtMargen)
        Me.grpPresentacion.Controls.Add(Me.Label6)
        Me.grpPresentacion.Controls.Add(Me.CboTipoPrecio)
        Me.grpPresentacion.Controls.Add(Me.CboPresentacion)
        Me.grpPresentacion.Controls.Add(Me.Label5)
        Me.grpPresentacion.Controls.Add(Me.Label16)
        Me.grpPresentacion.Controls.Add(Me.txtPreciArt)
        Me.grpPresentacion.Controls.Add(Me.btnAgregarPresent)
        Me.grpPresentacion.Controls.Add(Me.btnQuitarPrest)
        Me.grpPresentacion.Controls.Add(Me.ckRestringVenta)
        Me.grpPresentacion.Controls.Add(Me.LblEquiv)
        Me.grpPresentacion.Controls.Add(Me.Label11)
        Me.grpPresentacion.Controls.Add(Me.Label13)
        Me.grpPresentacion.Controls.Add(Me.Label14)
        resources.ApplyResources(Me.grpPresentacion, "grpPresentacion")
        Me.grpPresentacion.Name = "grpPresentacion"
        Me.grpPresentacion.TabStop = False
        '
        'TxtMargen
        '
        resources.ApplyResources(Me.TxtMargen, "TxtMargen")
        Me.TxtMargen.Name = "TxtMargen"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'CboTipoPrecio
        '
        Me.CboTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboTipoPrecio, "CboTipoPrecio")
        Me.CboTipoPrecio.Name = "CboTipoPrecio"
        '
        'CboPresentacion
        '
        Me.CboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboPresentacion, "CboPresentacion")
        Me.CboPresentacion.Name = "CboPresentacion"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'txtPreciArt
        '
        resources.ApplyResources(Me.txtPreciArt, "txtPreciArt")
        Me.txtPreciArt.Name = "txtPreciArt"
        '
        'btnAgregarPresent
        '
        resources.ApplyResources(Me.btnAgregarPresent, "btnAgregarPresent")
        Me.btnAgregarPresent.Name = "btnAgregarPresent"
        Me.btnAgregarPresent.TabStop = False
        '
        'btnQuitarPrest
        '
        resources.ApplyResources(Me.btnQuitarPrest, "btnQuitarPrest")
        Me.btnQuitarPrest.Name = "btnQuitarPrest"
        Me.btnQuitarPrest.TabStop = False
        '
        'ckRestringVenta
        '
        Me.ckRestringVenta.Checked = True
        Me.ckRestringVenta.CheckState = System.Windows.Forms.CheckState.Checked
        resources.ApplyResources(Me.ckRestringVenta, "ckRestringVenta")
        Me.ckRestringVenta.Name = "ckRestringVenta"
        '
        'LblEquiv
        '
        Me.LblEquiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.LblEquiv, "LblEquiv")
        Me.LblEquiv.Name = "LblEquiv"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'DgPreciart
        '
        resources.ApplyResources(Me.DgPreciart, "DgPreciart")
        Me.DgPreciart.DataMember = ""
        Me.DgPreciart.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgPreciart.Name = "DgPreciart"
        Me.DgPreciart.ReadOnly = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        '
        'txtDescripPresent
        '
        resources.ApplyResources(Me.txtDescripPresent, "txtDescripPresent")
        Me.txtDescripPresent.Name = "txtDescripPresent"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgAlmacen)
        Me.TabPage2.Controls.Add(Me.GrpAlmacen)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DgAlmacen
        '
        resources.ApplyResources(Me.DgAlmacen, "DgAlmacen")
        Me.DgAlmacen.DataMember = ""
        Me.DgAlmacen.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgAlmacen.Name = "DgAlmacen"
        Me.DgAlmacen.ReadOnly = True
        Me.DgAlmacen.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DgAlmacen
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'GrpAlmacen
        '
        Me.GrpAlmacen.Controls.Add(Me.txtStockInicio)
        Me.GrpAlmacen.Controls.Add(Me.Label23)
        Me.GrpAlmacen.Controls.Add(Me.txtStockActual)
        Me.GrpAlmacen.Controls.Add(Me.Label22)
        Me.GrpAlmacen.Controls.Add(Me.txtUltimaSalida)
        Me.GrpAlmacen.Controls.Add(Me.Label21)
        Me.GrpAlmacen.Controls.Add(Me.txtUltimoIngreso)
        Me.GrpAlmacen.Controls.Add(Me.Label20)
        Me.GrpAlmacen.Controls.Add(Me.cboAlmacen)
        Me.GrpAlmacen.Controls.Add(Me.TxtStockMini)
        Me.GrpAlmacen.Controls.Add(Me.lblAlm)
        Me.GrpAlmacen.Controls.Add(Me.Label17)
        Me.GrpAlmacen.Controls.Add(Me.TxtStockMax)
        Me.GrpAlmacen.Controls.Add(Me.Label18)
        Me.GrpAlmacen.Controls.Add(Me.btnAgrAlma)
        Me.GrpAlmacen.Controls.Add(Me.btnQuitAlma)
        Me.GrpAlmacen.Controls.Add(Me.txtUbicacion)
        Me.GrpAlmacen.Controls.Add(Me.Label19)
        resources.ApplyResources(Me.GrpAlmacen, "GrpAlmacen")
        Me.GrpAlmacen.Name = "GrpAlmacen"
        Me.GrpAlmacen.TabStop = False
        '
        'txtStockInicio
        '
        resources.ApplyResources(Me.txtStockInicio, "txtStockInicio")
        Me.txtStockInicio.Name = "txtStockInicio"
        Me.txtStockInicio.ReadOnly = True
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'txtStockActual
        '
        resources.ApplyResources(Me.txtStockActual, "txtStockActual")
        Me.txtStockActual.Name = "txtStockActual"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'txtUltimaSalida
        '
        resources.ApplyResources(Me.txtUltimaSalida, "txtUltimaSalida")
        Me.txtUltimaSalida.Name = "txtUltimaSalida"
        Me.txtUltimaSalida.ReadOnly = True
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'txtUltimoIngreso
        '
        resources.ApplyResources(Me.txtUltimoIngreso, "txtUltimoIngreso")
        Me.txtUltimoIngreso.Name = "txtUltimoIngreso"
        Me.txtUltimoIngreso.ReadOnly = True
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboAlmacen, "cboAlmacen")
        Me.cboAlmacen.Name = "cboAlmacen"
        '
        'TxtStockMini
        '
        resources.ApplyResources(Me.TxtStockMini, "TxtStockMini")
        Me.TxtStockMini.Name = "TxtStockMini"
        '
        'lblAlm
        '
        resources.ApplyResources(Me.lblAlm, "lblAlm")
        Me.lblAlm.Name = "lblAlm"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'TxtStockMax
        '
        resources.ApplyResources(Me.TxtStockMax, "TxtStockMax")
        Me.TxtStockMax.Name = "TxtStockMax"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'btnAgrAlma
        '
        resources.ApplyResources(Me.btnAgrAlma, "btnAgrAlma")
        Me.btnAgrAlma.Name = "btnAgrAlma"
        Me.btnAgrAlma.TabStop = False
        '
        'btnQuitAlma
        '
        resources.ApplyResources(Me.btnQuitAlma, "btnQuitAlma")
        Me.btnQuitAlma.Name = "btnQuitAlma"
        Me.btnQuitAlma.TabStop = False
        '
        'txtUbicacion
        '
        resources.ApplyResources(Me.txtUbicacion, "txtUbicacion")
        Me.txtUbicacion.Name = "txtUbicacion"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GRIDPROVEEDOR)
        Me.TabPage4.Controls.Add(Me.frameproveedor)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GRIDPROVEEDOR
        '
        Me.GRIDPROVEEDOR.BackgroundColor = System.Drawing.Color.Gray
        resources.ApplyResources(Me.GRIDPROVEEDOR, "GRIDPROVEEDOR")
        Me.GRIDPROVEEDOR.DataMember = ""
        Me.GRIDPROVEEDOR.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GRIDPROVEEDOR.Name = "GRIDPROVEEDOR"
        Me.GRIDPROVEEDOR.ReadOnly = True
        '
        'frameproveedor
        '
        Me.frameproveedor.Controls.Add(Me.ctrlmontocosto)
        Me.frameproveedor.Controls.Add(Me.btnelim)
        Me.frameproveedor.Controls.Add(Me.btnagre)
        Me.frameproveedor.Controls.Add(Me.chkactiprove)
        Me.frameproveedor.Controls.Add(Me.borrarlo)
        Me.frameproveedor.Controls.Add(Me.txtcodcompra)
        Me.frameproveedor.Controls.Add(Me.Label31)
        Me.frameproveedor.Controls.Add(Me.cbomoneda)
        Me.frameproveedor.Controls.Add(Me.txtdescrip)
        Me.frameproveedor.Controls.Add(Me.Label28)
        Me.frameproveedor.Controls.Add(Me.cboproveedor)
        Me.frameproveedor.Controls.Add(Me.Label27)
        Me.frameproveedor.Controls.Add(Me.Label9)
        Me.frameproveedor.Controls.Add(Me.Label30)
        resources.ApplyResources(Me.frameproveedor, "frameproveedor")
        Me.frameproveedor.Name = "frameproveedor"
        Me.frameproveedor.TabStop = False
        '
        'ctrlmontocosto
        '
        resources.ApplyResources(Me.ctrlmontocosto, "ctrlmontocosto")
        Me.ctrlmontocosto.Name = "ctrlmontocosto"
        Me.ctrlmontocosto.OcxState = CType(resources.GetObject("ctrlmontocosto.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'btnelim
        '
        resources.ApplyResources(Me.btnelim, "btnelim")
        Me.btnelim.Name = "btnelim"
        '
        'btnagre
        '
        resources.ApplyResources(Me.btnagre, "btnagre")
        Me.btnagre.Name = "btnagre"
        '
        'chkactiprove
        '
        resources.ApplyResources(Me.chkactiprove, "chkactiprove")
        Me.chkactiprove.Name = "chkactiprove"
        '
        'borrarlo
        '
        resources.ApplyResources(Me.borrarlo, "borrarlo")
        Me.borrarlo.Name = "borrarlo"
        '
        'txtcodcompra
        '
        resources.ApplyResources(Me.txtcodcompra, "txtcodcompra")
        Me.txtcodcompra.Name = "txtcodcompra"
        '
        'Label31
        '
        resources.ApplyResources(Me.Label31, "Label31")
        Me.Label31.Name = "Label31"
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbomoneda, "cbomoneda")
        Me.cbomoneda.Name = "cbomoneda"
        '
        'txtdescrip
        '
        resources.ApplyResources(Me.txtdescrip, "txtdescrip")
        Me.txtdescrip.Name = "txtdescrip"
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'cboproveedor
        '
        Me.cboproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboproveedor, "cboproveedor")
        Me.cboproveedor.Name = "cboproveedor"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DataGrid1)
        Me.TabPage5.Controls.Add(Me.btnAgregarDesc)
        Me.TabPage5.Controls.Add(Me.btnQuitarDesc)
        Me.TabPage5.Controls.Add(Me.CboTipoPrecio2)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.Label24)
        Me.TabPage5.Controls.Add(Me.TextBox1)
        resources.ApplyResources(Me.TabPage5, "TabPage5")
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'DataGrid1
        '
        resources.ApplyResources(Me.DataGrid1, "DataGrid1")
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        '
        'btnAgregarDesc
        '
        resources.ApplyResources(Me.btnAgregarDesc, "btnAgregarDesc")
        Me.btnAgregarDesc.Name = "btnAgregarDesc"
        Me.btnAgregarDesc.TabStop = False
        '
        'btnQuitarDesc
        '
        resources.ApplyResources(Me.btnQuitarDesc, "btnQuitarDesc")
        Me.btnQuitarDesc.Name = "btnQuitarDesc"
        Me.btnQuitarDesc.TabStop = False
        '
        'CboTipoPrecio2
        '
        Me.CboTipoPrecio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboTipoPrecio2, "CboTipoPrecio2")
        Me.CboTipoPrecio2.Name = "CboTipoPrecio2"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Label40)
        Me.TabPage7.Controls.Add(Me.Label39)
        Me.TabPage7.Controls.Add(Me.DateTimePicker2)
        Me.TabPage7.Controls.Add(Me.DateTimePicker1)
        Me.TabPage7.Controls.Add(Me.btnAgregarCom)
        Me.TabPage7.Controls.Add(Me.btnQuitarCom)
        Me.TabPage7.Controls.Add(Me.CboTipoComision)
        Me.TabPage7.Controls.Add(Me.Label37)
        Me.TabPage7.Controls.Add(Me.Label38)
        Me.TabPage7.Controls.Add(Me.TextBox2)
        Me.TabPage7.Controls.Add(Me.DataGrid2)
        resources.ApplyResources(Me.TabPage7, "TabPage7")
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label40
        '
        resources.ApplyResources(Me.Label40, "Label40")
        Me.Label40.Name = "Label40"
        '
        'Label39
        '
        resources.ApplyResources(Me.Label39, "Label39")
        Me.Label39.Name = "Label39"
        '
        'DateTimePicker2
        '
        resources.ApplyResources(Me.DateTimePicker2, "DateTimePicker2")
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Name = "DateTimePicker2"
        '
        'DateTimePicker1
        '
        resources.ApplyResources(Me.DateTimePicker1, "DateTimePicker1")
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Name = "DateTimePicker1"
        '
        'btnAgregarCom
        '
        resources.ApplyResources(Me.btnAgregarCom, "btnAgregarCom")
        Me.btnAgregarCom.Name = "btnAgregarCom"
        Me.btnAgregarCom.TabStop = False
        '
        'btnQuitarCom
        '
        resources.ApplyResources(Me.btnQuitarCom, "btnQuitarCom")
        Me.btnQuitarCom.Name = "btnQuitarCom"
        Me.btnQuitarCom.TabStop = False
        '
        'CboTipoComision
        '
        Me.CboTipoComision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboTipoComision, "CboTipoComision")
        Me.CboTipoComision.Name = "CboTipoComision"
        '
        'Label37
        '
        resources.ApplyResources(Me.Label37, "Label37")
        Me.Label37.Name = "Label37"
        '
        'Label38
        '
        resources.ApplyResources(Me.Label38, "Label38")
        Me.Label38.Name = "Label38"
        '
        'TextBox2
        '
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'DataGrid2
        '
        resources.ApplyResources(Me.DataGrid2, "DataGrid2")
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'btnreporte
        '
        resources.ApplyResources(Me.btnreporte, "btnreporte")
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.TabStop = False
        '
        'BTNCANCELAR
        '
        resources.ApplyResources(Me.BTNCANCELAR, "BTNCANCELAR")
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.TabStop = False
        '
        'BTNCERRAR
        '
        resources.ApplyResources(Me.BTNCERRAR, "BTNCERRAR")
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.TabStop = False
        '
        'BTNMODIFICAR
        '
        resources.ApplyResources(Me.BTNMODIFICAR, "BTNMODIFICAR")
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.TabStop = False
        '
        'BTNELIMINAR
        '
        resources.ApplyResources(Me.BTNELIMINAR, "BTNELIMINAR")
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.TabStop = False
        '
        'BTNNUEVO
        '
        resources.ApplyResources(Me.BTNNUEVO, "BTNNUEVO")
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.TabStop = False
        '
        'BTNGUARDAR
        '
        resources.ApplyResources(Me.BTNGUARDAR, "BTNGUARDAR")
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.TabStop = False
        '
        'DtFechaIni
        '
        resources.ApplyResources(Me.DtFechaIni, "DtFechaIni")
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Name = "DtFechaIni"
        '
        'DtFechaFin
        '
        resources.ApplyResources(Me.DtFechaFin, "DtFechaFin")
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Name = "DtFechaFin"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'Label35
        '
        resources.ApplyResources(Me.Label35, "Label35")
        Me.Label35.Name = "Label35"
        '
        'txtCodBarra
        '
        Me.txtCodBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtCodBarra, "txtCodBarra")
        Me.txtCodBarra.Name = "txtCodBarra"
        '
        'Label42
        '
        resources.ApplyResources(Me.Label42, "Label42")
        Me.Label42.Name = "Label42"
        '
        'frmarticulos
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.DtFechaIni)
        Me.Controls.Add(Me.DtFechaFin)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmarticulos"
        Me.ShowInTaskbar = False
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DgPresentac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpPresent.ResumeLayout(False)
        Me.GrpPresent.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.grpPresentacion.ResumeLayout(False)
        Me.grpPresentacion.PerformLayout()
        CType(Me.DgPreciart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpAlmacen.ResumeLayout(False)
        Me.GrpAlmacen.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.GRIDPROVEEDOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frameproveedor.ResumeLayout(False)
        Me.frameproveedor.PerformLayout()
        CType(Me.ctrlmontocosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Fields Form"
    Private miflag As Boolean
    Private FLAG As Integer
    Private tipoproducto As Integer
    Private INGIMPORTADO As Boolean '  ingreso IMPORTACION
    Private ACT_EVENTOS As Integer
    Private Maquina As String
    Private ModifAlma As Boolean
    Private ModifProv As Boolean
    Private ModifPreciart As Boolean
    Private CorrelativoLinea As String
    Private X, z As String
    Private y As String
    Private Elimina As ClsAyuda
    Private TABLE_SUBCAT As New DataTable
    Private Samira As Boolean
    Private Tmp_Present As New DataTable
    Private TMP_PRECIART As New DataTable
    Private TMP_PROVEART As New DataTable
    Private Tmp_DESC As New DataTable
    Private Tmp_Comisiones As New DataTable



#End Region

#Region "Funciones del Formulario"

    Private Sub FormatoGridPreciart()
        Try
            Dim TableStyle1 As New DataGridTableStyle
            With TableStyle1
                .MappingName = TMP_PRECIART.TableName
                .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            End With

            Dim column1 As New DataGridTextBoxColumn
            With column1
                .MappingName = "CDTIPOPRE"
                .HeaderText = "CodTipoPrecio"
                .NullText = ""
                .Width = 50
            End With
            Dim column2 As New DataGridTextBoxColumn
            With column2
                .MappingName = "DSTIPOPRE"
                .HeaderText = "TipoPrecio"
                .NullText = ""
                .Width = 200
            End With

            Dim column3 As New DataGridTextBoxColumn
            With column3
                .MappingName = "CODPRES"
                .HeaderText = "CodPresentacion"
                .NullText = ""
                .Width = 50
            End With

            Dim column4 As New DataGridTextBoxColumn
            With column4
                .MappingName = "DESPRES"
                .HeaderText = "Presentacion"
                .NullText = ""
                .Width = 160
            End With
            Dim column5 As New DataGridTextBoxColumn
            With column5
                .MappingName = "PREBASE"
                .HeaderText = "PrecioBase"
                .NullText = ""
                .Format = "#######0.00"
                .Width = 80
            End With

            Dim column6 As New DataGridTextBoxColumn
            With column6
                .MappingName = "MARGEN"
                .HeaderText = "Margen (%)"
                .NullText = ""
                .Format = "#######0.00"
                .Width = 80
            End With

            Dim column7 As New DataGridBoolColumn
            With column7
                .MappingName = "FACTURAR"
                .HeaderText = "Facturar"
                .NullText = ""
                .Width = 50
            End With

            Dim column8 As New DataGridTextBoxColumn
            With column8
                .MappingName = "EQUIVALENCIA"
                .HeaderText = "Equivalencia"
                .NullText = "#######0.00"
                .Width = 80
            End With


            DgPreciart.TableStyles.Clear()
            TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5, column6, column8})
            TableStyle1.GridColumnStyles.AddRange(New DataGridBoolColumn() {column7})
            DgPreciart.TableStyles.Add(TableStyle1)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub FormatoGridPresent()
        DgPresentac.TableStyles.Clear()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = Tmp_Present.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODPRES"
            .NullText = ""
            .HeaderText = "Codigo"
            .Width = 150
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DESPRES"
            .NullText = ""
            .HeaderText = "Descripcion Presentacion"
            .Width = 300
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "EQUIVALENCIA"
            .NullText = ""
            .Format = "#######0.00"
            .HeaderText = "Equivalencia"
            .Width = 100
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3})
        DgPresentac.TableStyles.Add(TableStyle1)


    End Sub
    Public Sub LIMPIA()
        txtdescrip.Text = ""
        Me.TxtDesArti.Text = ""
        txtcodcompra.Text = ""
        'txtcodalter.Text = ""
        cboproveedor.Text = ""
        txtcodarticulo.Text = ""
        TxtDesArti2.Text = ""
        txtdescrip.Text = ""
        txtcodcompra.Text = ""
        'txtcodalter.Text = ""
        AxCtrlComision.Text = FACT_MASCARA(0, 2)
        AxCtrlCubicaje.Text = FACT_MASCARA(0, 2)
        AxCtrlDescuento.Text = FACT_MASCARA(0, 2)
        AxCtrtPesoKg.Text = FACT_MASCARA(0, 2)

        'Me.GRIDB.DataSource = Nothing
        Me.GRIDPROVEEDOR.DataSource = Nothing
        Me.DgAlmacen.DataSource = Nothing
        Call borra_temporales()
        Call formatocontrolnumber()


    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                             ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If ModifAlma = True Then
                        If DgAlmacen.Focus = True Then
                            cboAlmacen.SelectedValue = DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 0).ToString
                            txtStockActual.Text = FACT_MASCARA(DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 2).ToString, DECICANT)
                            txtStockInicio.Text = FACT_MASCARA(DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 3).ToString, DECICANT)
                            TxtStockMini.Text = FACT_MASCARA(DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 4).ToString, DECICANT)
                            TxtStockMax.Text = FACT_MASCARA(DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 5).ToString, DECICANT)
                            txtUltimoIngreso.Text = DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 6).ToString
                            txtUltimaSalida.Text = DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 7).ToString
                            txtUbicacion.Text = DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 8).ToString
                            ModifAlma = True
                            cboAlmacen.Focus()
                        End If
                        ModifAlma = False
                    End If
                    ModifAlma = False
                    If ModifProv = True Then
                        If TMP_PROVEART.Rows.Count > 0 Then
                            If GRIDPROVEEDOR.Focus = True Then
                                cboproveedor.SelectedValue = GRIDPROVEEDOR.Item(GRIDPROVEEDOR.CurrentRowIndex, 1)
                                txtdescrip.Text = GRIDPROVEEDOR.Item(GRIDPROVEEDOR.CurrentRowIndex, 4)
                                cbomoneda.SelectedValue = GRIDPROVEEDOR.Item(GRIDPROVEEDOR.CurrentRowIndex, 5)
                                txtcodcompra.Text = GRIDPROVEEDOR.Item(GRIDPROVEEDOR.CurrentRowIndex, 3)
                                Me.ctrlmontocosto.CtlText = FACT_MASCARA(GRIDPROVEEDOR.Item(GRIDPROVEEDOR.CurrentRowIndex, 6), DECICOST)
                            End If
                        End If

                    End If
                    If ModifPreciart = False Then
                        If TMP_PRECIART.Rows.Count > 0 Then
                            If DgPreciart.Focus = True Then
                                CboPresentacion.SelectedValue = Trim(DgPreciart.Item(DgPreciart.CurrentRowIndex, 2))
                                CboTipoPrecio.SelectedValue = Trim(DgPreciart.Item(DgPreciart.CurrentRowIndex, 0))
                                txtPreciArt.Text = FormatoMonto(CDbl(DgPreciart.Item(DgPreciart.CurrentRowIndex, 4)), DECIRESU)
                                TxtMargen.Text = FormatoMonto(CDbl(DgPreciart.Item(DgPreciart.CurrentRowIndex, 5)), DECIRESU)
                                ckRestringVenta.Checked = DgPreciart.Item(DgPreciart.CurrentRowIndex, 6)
                                CboPresentacion.Enabled = False
                                CboTipoPrecio.Enabled = False
                                ModifPreciart = True
                                TxtMargen.Focus()
                            End If






                        End If
                    End If

                Case Keys.F3
                    Dim sender As Object = Nothing
                    Dim e As EventArgs = Nothing
                    If ModifAlma = True Then
                        If DgAlmacen.Focus = True Then
                            btnQuitAlma_Click(sender, e)
                        End If
                    End If
                    ModifAlma = False
                    If ModifProv = True Then
                        If GRIDPROVEEDOR.Focus = True Then
                            btnelim_Click(sender, e)
                        End If
                    End If
                    If Tmp_Present.Rows.Count > 0 Then
                        If DgPresentac.Focus = True Then
                            BtnDeletPresnt_Click(sender, e)
                        End If
                    End If

                    If TMP_PRECIART.Rows.Count > 0 Then
                        If DgPreciart.Focus = True Then
                            btnQuitarPrest_Click(sender, e)
                        End If
                    End If

            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub BLOQUEAR_CONTROLES()
        Dim a As Object
        For Each a In Me.TabControl1.Controls
            If TypeOf a Is TabPage Then
                Dim o As Object
                For Each o In a.controls
                    o.enabled = False
                Next
            End If
        Next
    End Sub
    Private Sub DESBLOQUEAR_CONTROLES()
        Dim a As Object
        For Each a In Me.TabControl1.Controls
            If TypeOf a Is TabPage Then
                Dim o As Object
                For Each o In a.controls
                    o.enabled = True
                Next
            End If
        Next
    End Sub
    Private Sub LIMPIAR_CONTROLES()
        Dim a As Object
        For Each a In Me.TabControl1.Controls
            If TypeOf a Is TabPage Then
                Dim o As Object
                For Each o In a.controls
                    If TypeOf o Is TextBox Then
                        o.text = ""
                    ElseIf TypeOf o Is AxMiControl.AxCtrlNumber Then
                        o.ctltext = ""
                    ElseIf TypeOf o Is CheckBox Then
                        o.checked = False
                    End If
                Next
            End If
        Next


        LblArticulo.Text = ""
        LblPresent.Text = ""
        TxtEquiv.Text = 0

        txtPreciArt.Text = 0

        TxtStockMini.Text = 0
        TxtStockMax.Text = 0

        txtUltimoIngreso.Text = ""

        txtUltimaSalida.Text = ""

        txtStockActual.Text = ""
        txtStockInicio.Text = ""

        txtUbicacion.Text = ""

        txtdescrip.Text = ""
        txtcodcompra.Text = ""
        ctrlmontocosto.Text = ""
        chkactiprove.Checked = False
        ckPercepcion1.Checked = False


        ckNPTienda.Checked = False

    End Sub
    Private Sub MostrarSubCategoria()
        TABLE_SUBCAT = TmpListarDatos("SP_SELECT_SUBLINEAxLINEA '" & codempresa.Trim & "' ,'" & cbolinea.SelectedValue & "'")
        cbosublinea.DataSource = TABLE_SUBCAT
        cbosublinea.ValueMember = "CODSUBLINEA"
        cbosublinea.DisplayMember = "DESSUBLINEA"

    End Sub
#End Region

#Region "Function Form"
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        '  BTNELIMINAR.Enabled = ELIMINAR
        btnbus.Enabled = BUSCAR

    End Sub

    Public Sub muestracodigo()
        txtcodarticulo.Text = codgenerado
    End Sub
    Public Sub borra_temporales()
        TmpInsertDatos("sp_limpia_temporales '" & CodUsuario & "','" & Maquina & "'")

        Tmp_Present = TmpListarDatos("ListarTMP_ARTIPRESENTxProc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
        DgPresentac.DataSource = Tmp_Present
        FormatoGridPresent()

        TMP_PRECIART = TmpListarDatos("ListarTMP_PRECIARTxProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "'")
        DgPreciart.DataSource = TMP_PRECIART
        FormatoGridPreciart()


    End Sub
    Public Sub carga_registros()
        Try
            If Trim(txtcodarticulo.Text) = "" Then Exit Sub
            Dim SQL As String
            SQL = "SP_SELE_ARTICULOXCODIGO '" & txtcodarticulo.Text & "'"
            Dim DS As New DataSet
            DS = TmpListarDataset(SQL)
            TxtDesArti2.Text = DS.Tables(0).Rows(0)(1)
            cboimpuesto.Text = DS.Tables(0).Rows(0)(10)
            chkfacturar.Checked = DS.Tables(0).Rows(0)(14)
            Dim UME As String
            UME = DS.Tables(0).Rows(0)(24)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub formatocontrolnumber()
        ctrlmontocosto.Enteros = 9
        ctrlmontocosto.Enteros = 9
        ctrlmontocosto.Decimales = DECIRESU
        ctrlmontocosto.Decimales = DECIRESU
        ctrlmontocosto.CtlText = FACT_GFormatodeNumero(ctrlmontocosto.CtlText)
        ctrlmontocosto.CtlText = FACT_GFormatodeNumero(ctrlmontocosto.CtlText)
    End Sub
    Public Sub iniciacontrolnumber()
        ctrlmontocosto.Enteros = 9

        ctrlmontocosto.Enteros = 9
        ctrlmontocosto.Decimales = DECIRESU
        ctrlmontocosto.Decimales = DECIRESU
        ctrlmontocosto.ValorPorDefecto()
        ctrlmontocosto.ValorPorDefecto()

        AxCtrlCubicaje.Text = "0.00"
        AxCtrlComision.Text = "0.00"
        AxCtrlDescuento.Text = "0.00"
        AxCtrtPesoKg.Text = "0.00"

    End Sub
    Public Sub cargadatos()
        Try
            'linea
            CAyuda.CargarDataCombo(cbolinea, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")
            'sublinea
            'CAyuda.CargarDataCombo(cbosublinea, "NSP_Sele_SubLineaxlinea '" & cbolinea.SelectedValue.ToString & "','" & codempresa & "'", "Codigo", "Descripcion")

            'impuesto
            CAyuda.CargarDataCombo(cboimpuesto, "NSP_Select_Listado_Impuesto '" & codempresa & "'", "Código", "Descripción")
            'ISC
            CAyuda.CargarDataCombo(CboIsc, "NSP_Select_Listado_Impuesto '" & codempresa & "'", "Código", "Descripción")
            'proveedor
            CAyuda.CargarDataCombo(cboproveedor, "NSP_Select_ListaProveedor '" & codempresa & "'", "Código", "Descripción")
            'monedas
            CAyuda.CargarDataCombo(cbomoneda, "NSP_Select_Listado_Moneda '" & codempresa & "'", "Código", "Descripción")
            CAyuda.CargarDataCombo(cboAlmacen, "Nsp_select_Almacen  '" & codempresa & "'", "codigo", "descripcion")
            'FORMA DE PAGO
            'CAyuda.CargarDataCombo(CboFormaPago, "NSP_SELECT_TIPO_PAGO  '" & codempresa & "'", "CODTIPOPAGO", "DSTIPOPAGO")
            CAyuda.CargarDataCombo(CboTipoPrecio, "nsp_sele_tipopre  '" & codempresa & "'", "codtipopre", "dstipopre")

            CAyuda.CargarDataCombo(CboTipoPrecio2, "nsp_sele_tipopre  '" & codempresa & "'", "codtipopre", "dstipopre")

            CAyuda.CargarDataCombo(CboTipoComision, "nsp_sele_tipocomisiones  '" & codempresa & "'", "CDTIPOCOM", "DSTIPOCOM")

            CAyuda.CargarDataCombo(cboCatABC, "nsp_sele_CatABCprod  '" & codempresa & "'", "id", "Descripcion")




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub FormatGrid1()
        Me.GRIDPROVEEDOR.TableStyles.Clear()
        Dim grdTableStyle4 As New DataGridTableStyle
        With grdTableStyle4
            .MappingName = "table"
            .PreferredColumnWidth = 300
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "Codigo Alternativo"
            .MappingName = "codarti"
            .Width = 100
        End With

        Dim grdColStyle6 As New DataGridTextBoxColumn
        With grdColStyle6
            .HeaderText = "Cod_Provedor"
            .MappingName = "codproveedor"
            .Width = 75
        End With

        Dim grdColStyle7 As New DataGridTextBoxColumn
        With grdColStyle7
            .HeaderText = "Descripcion del Proveedor"
            .MappingName = "Nombre"
            .Width = 200
        End With

        Dim grdColStyle8 As New DataGridTextBoxColumn
        With grdColStyle8
            .HeaderText = "Codigo Compra"
            .MappingName = "codigocompra"
            .Width = 100
        End With

        Dim grdColStyle9 As New DataGridTextBoxColumn
        With grdColStyle9
            .HeaderText = "Descripcion"
            .MappingName = "descrip"
            .Width = 150
        End With

        Dim grdColStyle10 As New DataGridTextBoxColumn
        With grdColStyle10
            .HeaderText = "Moneda"
            .MappingName = "codmon"
            .Width = 50
        End With
        Dim grdColStyle11 As New DataGridTextBoxColumn
        With grdColStyle11
            .HeaderText = "Monto Costo"
            .MappingName = "mtocosto"
            .Width = 80
        End With

        grdTableStyle4.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8, grdColStyle9, grdColStyle10, grdColStyle11})
        GRIDPROVEEDOR.TableStyles.Add(grdTableStyle4)
    End Sub

    Private Sub CargarGridArtiDat()
        Dim TABLA_ARTIDAT As New DataTable
        TABLA_ARTIDAT = CAyuda.ListarDatos("sp_obt_tmpArtidatNar", CodUsuario, Maquina).Tables(0)

        DgAlmacen.DataSource = TABLA_ARTIDAT
        Me.DataGridTableStyle2.MappingName = TABLA_ARTIDAT.TableName
        Me.DataGridTableStyle2.GridColumnStyles(0).MappingName = "Codigo"
        Me.DataGridTableStyle2.GridColumnStyles(1).MappingName = "Descripcion"
        Me.DataGridTableStyle2.GridColumnStyles(2).MappingName = "Stock_Actual"
        Me.DataGridTableStyle2.GridColumnStyles(3).MappingName = "Stock_Inicio"
        Me.DataGridTableStyle2.GridColumnStyles(4).MappingName = "Stock_Minimo"
        Me.DataGridTableStyle2.GridColumnStyles(5).MappingName = "Stock_Maximo"
        Me.DataGridTableStyle2.GridColumnStyles(6).MappingName = "Ultimo_Ingreso"
        Me.DataGridTableStyle2.GridColumnStyles(7).MappingName = "Ultima_Salida"
        Me.DataGridTableStyle2.GridColumnStyles(8).MappingName = "Ubicacion"
        DgAlmacen.TableStyles.Add(DataGridTableStyle2)



    End Sub
    Private Sub CargaGridProveedor1()
        TMP_PROVEART = CAyuda.ListarDatos("sp_obt_proveartJ", CodUsuario, Maquina).Tables(0)
        GRIDPROVEEDOR.DataSource = TMP_PROVEART
    End Sub
    Public Sub MostrarAlmacenes()
        TmpInsertDatos("sp_lista_Almacenes '" & Me.txtcodarticulo.Text & "','" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
    End Sub
    Public Sub mostrarproveedor()
        TmpInsertDatos("sp_lista_proveedor '" & Me.txtcodarticulo.Text & "','" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
        CargaGridProveedor1()
    End Sub
    Public Sub mostrar()
        txtcodarticulo.Text = VAR1
        If txtcodarticulo.Text = "" Then BLOQUEAR_CONTROLES()
        If txtcodarticulo.Text <> "" Then DESBLOQUEAR_CONTROLES()
        '  txtdesciud.Text = Variables.VAR2
        '  CBOPAIS.Text = Variables.VAR3
    End Sub
    Public Sub CargaGridCodBarra()
        'GRIDB.DataSource = CAyuda.ListarDatos("sp_obt_tmp_codalterJ", CodUsuario, Maquina, codempresa).Tables(0)
    End Sub
    Private Sub mostrarcodalter()
        TmpInsertDatos("sp_lista_codalter '" & Me.txtcodarticulo.Text & "','" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
        CargaGridCodBarra()
    End Sub
    Public Sub FormatGrid()
        'Me.GRIDB.TableStyles.Clear()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = "table"
            .PreferredColumnWidth = 300
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Codigo Alternativo"
            .MappingName = "codalter"
            .Width = 200
        End With


        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1})
        'GRIDB.TableStyles.Add(grdTableStyle1)
    End Sub
    Private Function FACT_MASCARA(ByVal valor As Double, ByVal nrodecimal As Integer) As String
        FACT_MASCARA = ""
        Select Case nrodecimal
            Case 0
                FACT_MASCARA = Format(valor, "#######0")
            Case 1
                FACT_MASCARA = Format(valor, "#######0.0")
            Case 2
                FACT_MASCARA = Format(valor, "#######0.00")
            Case 3
                FACT_MASCARA = Format(valor, "#######0.000")
            Case 4
                FACT_MASCARA = Format(valor, "#######0.0000")
            Case 5
                FACT_MASCARA = Format(valor, "#######0.00000")
            Case 6
                FACT_MASCARA = Format(valor, "#######0.000000")
            Case 7
                FACT_MASCARA = Format(valor, "#######0.0000000")
            Case 8
                FACT_MASCARA = Format(valor, "#######0.00000000")
        End Select
        Return FACT_MASCARA
    End Function
#End Region


    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Samira = False
        Call LIMPIA()
        Call borra_temporales()
        importado = False
        otros = False
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, True, False)
        FLAG = 0

        'Me.GRIDB.DataSource = Nothing
        Me.GRIDPROVEEDOR.DataSource = Nothing
        mostrarcodalter()
        mostrarproveedor()
        Me.TabControl1.SelectedIndex = 0
        'Call DESBLOQUEA()
        ''''DESBLOQUEAR LOS CONTROLES
        DESBLOQUEAR_CONTROLES()
        ''LIMPIAR CONTROLES
        LIMPIAR_CONTROLES()
        ''DESABILITAR CONTROL
        btnbus.Enabled = False
        'INICIAR LOS CONTROLES
        Call iniciacontrolnumber()
        ACT_EVENTOS = 1



        TxtCodPres.Enabled = False
        TxtEquiv.Enabled = False

        TxtDesArti.Focus()


    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Dim PROCESO As Boolean
        Call FORMATtextoTAB(TabControl1)
        Call formatocontrolnumber()

        Try


            If tipoproducto = 1 Then
            Else
                If txtcodarticulo.Text = "" Or cboimpuesto.Text = "" Then
                    MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If TABLE_SUBCAT.Rows.Count = 0 Then
                MsgBox("Falta escoger SubCategoria del articulo...", MsgBoxStyle.Critical, "NAR SISTEMAS")
                cbolinea.Focus()
                Exit Sub
            End If


            If TxtDesArti.Text = "" Then
                MsgBox("Falta la descripcion del articulo...", MsgBoxStyle.Critical, "NAR SISTEMAS")
                TxtDesArti.Focus()
                Exit Sub
            End If

            If cboCatABC.SelectedValue = Nothing Then
                MsgBox("Seleccione una Categorización ABC", MsgBoxStyle.Critical, "NAR SISTEMAS")
                cboCatABC.Focus()
                Exit Sub
            End If


            If FLAG = 0 Then
                Dim nregistro As Integer
                nregistro = buscaregistro("SELECT CODARTI FROM ARTICULO WHERE CODARTI='" & txtcodarticulo.Text & "' AND CODEMPRESA = '" & codempresa & "'")
                If nregistro = 1 Then
                    MessageBox.Show("El Registro ya Existe Verifique !!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Question)
                    Exit Sub
                End If
                nregistro = buscaregistro("SELECT DESARTI FROM ARTICULO WHERE DESARTI = '" & TxtDesArti.Text & "' AND CODEMPRESA = '" & codempresa & "'")
                If nregistro = 1 Then
                    MessageBox.Show("La Descripcion del Producto ya Existe Verifique !!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Question)
                    TxtDesArti.Focus()
                    Exit Sub
                End If

                Guardar_Nextel()

                If CAyuda.Ejecutar("SP_INSERTA_ARTICULOJ", codempresa.Trim, txtcodarticulo.Text.Trim, TxtDesArti.Text.Trim, TxtDesArti2.Text.Trim, cbolinea.SelectedValue.ToString.Trim, cbosublinea.SelectedValue.ToString.Trim, "", "", "", cboimpuesto.SelectedValue.ToString.Trim, IIf(IsNothing(CboIsc.SelectedValue), "", CboIsc.SelectedValue).ToString(), AxCtrlCubicaje.Text, AxCtrlComision.Text, AxCtrlDescuento.Text, AxCtrtPesoKg.Text, 0, chkfacturar.Checked, 0, chkEstado.Checked, 0, 0, 0, 0, 0, 0, CodUsuario.Trim, Maquina, Me.ckNotaPedido.Checked, Me.ckPagoEfectivo.Checked, Me.ckPercepcion1.Checked, ckDistribucion.Checked, ckCombo.Checked, Me.ckPercepcion2.Checked, ckNPTienda.Checked, cboCatABC.SelectedValue, txtCodBarra.Text) > 0 Then
                    PROCESO = True

                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodarticulo.Text & "','INSERT','ARTICULOLOCAL','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                End If
                'Me.GRIDB.DataSource = Nothing
                Me.GRIDPROVEEDOR.DataSource = Nothing
                'Me.DgPresent.DataSource = Nothing
                Me.DgAlmacen.DataSource = Nothing
                Me.TabControl1.SelectedIndex = 0
            End If

            If FLAG = 1 Then
                Guardar_Nextel()
                If CAyuda.Ejecutar("SP_UPDATE_ARTICULOJ", codempresa.Trim, txtcodarticulo.Text.Trim, TxtDesArti.Text.Trim, TxtDesArti2.Text.Trim, cbolinea.SelectedValue.ToString.Trim, cbosublinea.SelectedValue.ToString.Trim, "", "", "", cboimpuesto.SelectedValue.ToString.Trim, IIf(IsNothing(CboIsc.SelectedValue) = True, "", CboIsc.SelectedValue), AxCtrlCubicaje.Text, AxCtrlComision.Text, AxCtrlDescuento.Text, AxCtrtPesoKg.Text, 0, chkfacturar.CheckState, 0, chkEstado.Checked, CodUsuario.Trim, Maquina, ckNotaPedido.Checked, ckPagoEfectivo.Checked, Me.ckPercepcion1.Checked, ckDistribucion.Checked, ckCombo.Checked, Me.ckPercepcion2.Checked, ckNPTienda.Checked, cboCatABC.SelectedValue, txtCodBarra.Text) > 0 Then
                    PROCESO = True

                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodarticulo.Text & "','UPDATE','ARTICULOLOCAL','" & Format(System.DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")

                End If
                'Me.GRIDB.DataSource = Nothing
                Me.GRIDPROVEEDOR.DataSource = Nothing
                'Me.DgPresent.DataSource = Nothing
                Me.DgAlmacen.DataSource = Nothing
                Me.TabControl1.SelectedIndex = 0

            End If

            If PROCESO = True Then

                MsgBox("Se Guardo correctamente los registros..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

                Call limtextoTAB(TabControl1)
                If PROCESO = False Then Exit Sub
                Call BOTONES(True, False, False, True, True)
                Call carga_registros()

                btnbus.Enabled = True
                Call BLOQUEAR_CONTROLES()
                Call LIMPIAR_CONTROLES()
                chkfacturar.Checked = False
                btnbus.Enabled = True
                Me.txtcodarticulo.Focus()
                Limp_DataGrid()
            End If
            Me.btnbus.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try






    End Sub
    Private Sub Eliminar_Nextel()
        Try
            If ACTIVABD = True Then
                CAyuda.Ejecutar(2, "SP_DELETE_ARTICULO", VCODNEXTEL.Trim, txtcodarticulo.Text.Trim)
                CAyuda.Ejecutar(2, "SP_N_DELETE_PRESENTACION", VCODNEXTEL.Trim, txtcodarticulo.Text.Trim)
            End If
        Catch ex As Exception
            MsgBox("Problema de conexión con Nextel, intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try

    End Sub

    Private Sub Guardar_Nextel()
        Try
            If ACTIVABD = True Then
                Dim stk As Decimal = 0
                Dim tbstock As New DataTable
                If chkEstado.Checked = True Then
                    Eliminar_Nextel()
                    Exit Sub
                End If


                tbstock = TmpListarDatos("select top 1 cdalmacen from almazon where codempresa='" & codempresa & "' and cdzona='" & CDZONA & "'")
                vcdAlmacen = tbstock.Rows(0)(0).ToString.Trim

                tbstock = TmpListarDatos("SELECT STKACTU FROM ARTIDAT WHERE CODEMPRESA='" & codempresa & "' AND CODALMACEN='" & vcdAlmacen.Trim & "' AND CODARTI='" & txtcodarticulo.Text.Trim & "'")
                If tbstock.Rows.Count > 0 Then
                    stk = CDec(tbstock.Rows(0)(0))
                Else
                    stk = 0
                End If

                CAyuda.Ejecutar(2, "SP_N_INS_ARTICULO", VCODNEXTEL.Trim, txtcodarticulo.Text.Trim, TxtDesArti.Text.Trim, TxtDesArti2.Text.Trim, cbolinea.SelectedValue.ToString.Trim, stk)

                CAyuda.Ejecutar(2, "SP_N_DELETE_PRESENTACION", VCODNEXTEL.Trim, txtcodarticulo.Text.Trim)

                CAyuda.Ejecutar(2, "SP_N_INS_TBL_STOCK", VCODNEXTEL.Trim, txtcodarticulo.Text.Trim, 0)


                Dim TMP_TIPOPRE As New DataTable
                Dim codtipoprec As String
                TMP_TIPOPRE = TmpListarDatos("select DISTINCT(CDTIPOPRE) from TMP_PRECIART WHERE CDARTI='" & txtcodarticulo.Text.Trim & "' AND CODEMPRESA='" & codempresa & "'")
                If TMP_TIPOPRE.Rows.Count > 0 Then
                    For cont As Integer = 0 To TMP_TIPOPRE.Rows.Count - 1
                        codtipoprec = TMP_TIPOPRE.Rows(cont)("CDTIPOPRE")
                        Dim Tabla As New DataTable
                        Tabla = CAyuda.ListarDatos("NSP_SELECT_PRESENTACIONXTIPOPRE", codempresa.Trim, CodUsuario, Maquina, codtipoprec).Tables(0)
                        If Tabla.Rows.Count > 0 Then
                            For x As Integer = 0 To Tabla.Rows.Count - 1
                                CAyuda.Ejecutar(2, "SP_N_INS_PRESENTACION", VCODNEXTEL.Trim, txtcodarticulo.Text.Trim, Tabla.Rows(x)("DESPRES"), Tabla.Rows(x)("EQUIVALENCIA"), Tabla.Rows(x)("PREBASE"), Trim(codtipoprec))
                            Next
                        End If
                    Next
                    CAyuda.Ejecutar(2, "SP_NX_UPD_PRES_NULOS", VCODNEXTEL.Trim, txtcodarticulo.Text.Trim)
                End If
            End If
        Catch ex As Exception
            MsgBox("Problema de conexión con Nextel, intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try
    End Sub
    Private Sub Limp_DataGrid()
        TMP_PRECIART.Clear()

        Tmp_Present.Clear()
        'TABLA_ARTIDAT.clear()
        TMP_PROVEART.Clear()
    End Sub
    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        DESBLOQUEAR_CONTROLES()
        txtcodarticulo.ReadOnly = True
        Call BOTONES(False, True, False, True, True)
        FLAG = 1
        TxtDesArti.Enabled = True
        TxtDesArti2.Enabled = True
        btnbus.Enabled = False
        'Call DESBLOQUEA()
        DESBLOQUEAR_CONTROLES()

        Me.TxtDesArti.Focus()

        txtStockActual.Enabled = True



        CboPresentacion.Enabled = True
        CboTipoPrecio.Enabled = True
        txtPreciArt.Enabled = True
        ckRestringVenta.Enabled = True
        TxtMargen.Enabled = True




        TxtCodPres.Enabled = False
        TxtEquiv.Enabled = False

    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click


        Try



            Dim Proceso As String
            Proceso = "ANULPRODUCTO"
            If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
                Dim o As New FrmIngresaUsuClave
                o.Proceso = Proceso
                o.ShowDialog()
                If o.DEVOLVER = False Then
                    Exit Sub
                End If
            End If



            Elimina = New ClsAyuda
            Dim Registro As Long

            If Me.txtcodarticulo.Text.Trim = "" Then
                MessageBox.Show("Seleccione un artículo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'VERIFICA EL MOVIMIENTO PARA EL ARTICULO
            Registro = CAyuda.ListarDatos("USP_VERIFICAR_RELACION_MOVIDET", Me.txtcodarticulo.Text.Trim, codempresa).Tables(0).Rows.Count
            If Registro > 0 Then
                MsgBox("El Articulo no se puede Eliminar Por q Esta Asociado" + Chr(13) + "Gracias", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
                Exit Sub
            End If
            'Else
            '    Registro = Elimina.TraerDataset("USP_VERIFICAR_RELACION_MOVIDETP", Me.txtcodarticulo.Text.Trim).Tables(0).Rows.Count
            '    If Registro > 0 Then
            '        MsgBox("El Articulo no se puede Eliminar Por q Esta Asociado" + Chr(13) + "Gracias", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            '        Exit Sub
            '    Else
            '        Registro = Elimina.TraerDataset("USP_VERIFICAR_RELACION_SALDOS_NEG", Me.txtcodarticulo.Text.Trim).Tables(0).Rows.Count
            '        If Registro > 0 Then
            '            MsgBox("El Articulo no se puede Eliminar Por q Esta Asociado" + Chr(13) + "Gracias", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            '            Exit Sub
            '        End If
            '    End If

            REM -----------------------------------------------------------------------------------------------------------------------------------------------


            Dim sql As String
            'If Microsoft.VisualBasic.IsDBNull(clsInter.ListarDatos("sp_verifica_saldo_articulo", Me.txtcodarticulo.Text.Trim).Tables(0).Rows(0)(0)) Then

            'Else
            '    saldo = Double.Parse(clsInter.ListarDatos("sp_verifica_saldo_articulo", Me.txtcodarticulo.Text.Trim).Tables(0).Rows(0)(0))
            '    If saldo > 0 Then
            '        MsgBo("El Articulo Posee Saldos en Importacion y no puede eliminarse", MsgBoxStyle.Information)
            '        Exit Sub
            '    End If
            'End If



            'VERIFICAR ARTICULO PARA ELIMINAR

            Dim meses As Integer
            Dim MesAct, Anio As String
            Dim VentaC, VentD, MoviD, MoviC As String
            Dim DT_CANIDAD As DataTable

            meses = Val(DateDiff("m", "01/01/2010", DtFechaFin.Value))

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
                    DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_ARTICULO_VTA '" & codempresa & "','" & txtcodarticulo.Text & "','" & VentD & "'")

                    If DT_CANIDAD.Rows.Count > 0 Then
                        MsgBox("ESE ARTICULO NO SE PUEDE BORRAR ESTA EN VENTADET")
                        Exit Sub
                    End If
                End If

                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then

                    DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_ARTICULO_MOVI '" & codempresa & "','" & txtcodarticulo.Text & "','" & MoviD & "'")

                    If DT_CANIDAD.Rows.Count > 0 Then
                        MsgBox("ESE ARTICULO NO SE PUEDE BORRAR ESTA EN MOVIDET")
                        Exit Sub
                    End If
                End If

            Next







            If MsgBox("¿Esta seguro de eliminar el registro?", MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C.") = MsgBoxResult.Yes Then
                sql = "nsp_borra_Articulo '" & codempresa & "','" & Me.txtcodarticulo.Text.Trim & "'"
                Proceso = TmpInsertDatos(sql)
                If Proceso = True Then
                    Eliminar_Nextel()
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodarticulo.Text & "','DELETE','ARTICULOLOCAL','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                    MessageBox.Show("El Articulo se elimino con exito...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' MessageBox.Show("El Articulo se elimino con exito...", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
                BOTONES(True, False, False, False, True)
                LIMPIA()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Samira = False
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call BOTONES(True, False, False, True, True)
        Me.btnbus.Enabled = True
        BLOQUEAR_CONTROLES()
        LIMPIAR_CONTROLES()

        btnbus.Enabled = True
        Call borra_temporales()
        'Me.GRIDB.DataSource = Nothing
        Me.GRIDPROVEEDOR.DataSource = Nothing
        'Me.DgPresent.DataSource = Nothing
        Me.DgAlmacen.DataSource = Nothing
        Call iniciacontrolnumber()
        Me.TabControl1.SelectedIndex = 0
        Me.txtcodarticulo.Focus()
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
        Call borra_temporales()
    End Sub


    Sub Procesar_Saldo(ByVal fechaCierre As String, ByVal CDALMACEN As String)
        Dim meses As Integer
        Dim Fecinicial, Fecfinal As String
        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String

        TmpInsertDatos("Delete from TMp_kardex WHERE CORREL =" & rand)


        If CierreIgual = True Then
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")

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
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_NXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next

        Else

            meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
            ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSALXARTICULO '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0,'" & rand & "'")

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
                Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct

                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSALXARTICULO '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1,'" & rand & "'")

                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTASXARTICULO '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "','" & VentaC & "','" & rand & "'")


                End If
            Next




            ''SELECCIONO LOS INGRESOS Y SALIDAS DEL RANGO DEL KARDEX
            MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
            MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy")

            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")


            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")
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
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")

                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_NXARTI '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")

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

        TmpInsertDatos("SP_INS_KARDEX_TMPXARTI '" & codempresa & "','" & rand & "','" & txtcodarticulo.Text & "'")


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

        TmpInsertDatos(" INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS ) " & _
                         " SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,CIERRE_MES_INVENTARIO.ARTICULO,CIERRE_MES_INVENTARIO.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0  " & _
                         "FROM CIERRE_MES_INVENTARIO INNER JOIN ARTICULO ON CIERRE_MES_INVENTARIO.ARTICULO=ARTICULO.CODARTI " & _
                         "WHERE  ARTICULO.FORMU = 0 AND CIERRE_MES_INVENTARIO.ALMACEN ='" & Trim(ALMACEN) & "'  AND FECHA='" & Format(FechaCierre, "dd/MM/yyyy") & "' AND ARTICULO.CODARTI='" & txtcodarticulo.Text & "'")

    End Sub

    Private Sub frmarticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValorRan()

        BLOQUEAR_CONTROLES()
        LIMPIAR_CONTROLES()
        Call borra_temporales()

        Call BOTONES(True, False, False, False, True)
        btnbus.Enabled = True
        Call iniciacontrolnumber()
        Call cargadatos()
        FormatGrid()
        FormatGrid1()
        Maquina = Environment.MachineName
        btnbus.Enabled = True
        ACT_EVENTOS = 1

        btnbus.Focus()

        DtFechaIni.Value = vFechaActual.AddDays(-1)
        'DtFechaFin.Value = Date.Now
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
    Private Sub btnagre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagre.Click
        Dim STATUS As Boolean
        Dim sql As String

        If Me.txtdescrip.Text.ToString = "" Then
            MsgBox("INGRESE EL ARTICULO PARA EL PROVEEDOR...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        If ctrlmontocosto.CtlText = "" Then
            MsgBox("INGRESE EL COSTO PARA EL PROVEEDOR...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            ctrlmontocosto.Focus()
            Exit Sub
        End If

        If TmpListarDatos("select * from TMP_proveart where codarti='" & txtcodarticulo.Text.Trim & "' and codproveedor='" & Me.cboproveedor.SelectedValue.ToString.Trim & "' AND  CODEMPRESA='" & codempresa & "' AND  maquina='" & Maquina & "' AND  USUARIO='" & CodUsuario & "'").Rows.Count > 0 Then
            MsgBox("EL ARTICULO DEL PROVEEDOR YA ESTA INGRESADO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        sql = "sp_inst_TMP_proveart " & ctrlmontocosto.CtlText & ",'" & txtcodcompra.Text & "','" & txtcodarticulo.Text & "','" & Me.cboproveedor.SelectedValue.ToString.Trim & "','" & cbomoneda.SelectedValue.ToString & "','" & CodUsuario & "','" & Maquina & "','" & Me.txtdescrip.Text & "','" & codempresa & "' , '" & Me.cboproveedor.Text.Trim & "'"
        STATUS = TmpInsertDatos(sql)

        CargaGridProveedor1()
        Me.txtdescrip.Clear()
        ctrlmontocosto.CtlText = ""
        Me.txtcodcompra.Clear()
        Me.cboproveedor.Focus()




        If STATUS = False Then
            MessageBox.Show("Error Provedor resgitrado para el Articulo", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    Private Sub btnelim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnelim.Click
        Dim STATUS As Boolean
        Dim sql As String
        Dim CODPROVEEDOR As String
        Dim X As Integer
        X = GRIDPROVEEDOR.CurrentRowIndex
        CODPROVEEDOR = GRIDPROVEEDOR.Item(X, 1)
        sql = "sp_dele_TMP_proveart '" & txtcodarticulo.Text & "','" & CODPROVEEDOR & "','" & CodUsuario & "','" & Maquina & "','" & codempresa & "'"

        STATUS = TmpInsertDatos(sql)

        CargaGridProveedor1()
        If STATUS = False Then
            Exit Sub
        End If
    End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub btnbus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbus.Click

        Dim FRMX As New frmgridarticulo
        FRMX.ShowDialog()
        If FRMX.DEVOLVER = False Then
            Exit Sub
        End If

        txtcodarticulo.Text = FRMX.Grid1.Item(FRMX.Grid1.CurrentRowIndex, 0)

        ACT_EVENTOS = 0
        Call BOTONES(True, False, True, True, True)
        txtcodarticulo.ReadOnly = True
        Call formatocontrolnumber()
        If txtcodarticulo.Text <> "" Then
            Dim Tabla As New DataTable
            Tabla = CAyuda.ListarDatos("USP_BUSCAR_ARTICULO_MAESTRA", Me.txtcodarticulo.Text, codempresa).Tables(0)
            If Tabla.Rows.Count Then
                Me.txtcodarticulo.Text = Tabla.Rows(0).Item("CODARTI").ToString
                Me.TxtDesArti.Text = Tabla.Rows(0).Item("DESARTI").ToString
                Me.TxtDesArti2.Text = Tabla.Rows(0).Item("DESARTI2").ToString
                Me.cbolinea.SelectedValue = Tabla.Rows(0)("codlinea").ToString
                Me.cboimpuesto.SelectedValue = Tabla.Rows(0)("CODIMPUESTO").ToString
                Me.CboIsc.SelectedValue = Tabla.Rows(0)("ISC").ToString
                Me.AxCtrlCubicaje.Text = CDbl(Tabla.Rows(0)("CUBICAJE").ToString)
                Me.AxCtrlComision.Text = FACT_MASCARA(CDbl(Tabla.Rows(0)("COMISION").ToString), DECICANT)
                Me.AxCtrlDescuento.Text = FACT_MASCARA(CDbl(Tabla.Rows(0)("DESCUENTO").ToString), DECICANT)
                Me.AxCtrtPesoKg.Text = FACT_MASCARA(CDbl(Tabla.Rows(0)("PESO").ToString), DECICANT)
                Me.chkfacturar.Checked = Tabla.Rows(0)("FACTURAR").ToString
                Me.chkEstado.Checked = Tabla.Rows(0)("ESTADO").ToString
                Me.ckNotaPedido.Checked = Tabla.Rows(0)("NTAPEDIDO").ToString
                Me.ckPagoEfectivo.Checked = Tabla.Rows(0)("SOLOEFECTIVO").ToString
                Me.ckPercepcion1.Checked = Tabla.Rows(0)("PERCEP").ToString
                Me.ckDistribucion.Checked = Tabla.Rows(0)("distribucion").ToString
                Me.ckCombo.Checked = Tabla.Rows(0)("COMBO").ToString
                Me.ckPercepcion2.Checked = Tabla.Rows(0)("PERCEPCION2").ToString
                Me.ckNPTienda.Checked = Tabla.Rows(0)("NPTIENDA").ToString
                Me.cboCatABC.SelectedValue = Tabla.Rows(0)("CAT_ABC").ToString
                Me.txtCodBarra.Text = Tabla.Rows(0).Item("CODBARRA").ToString
                'Dim date1 As String
                ''Dim date2 As String
                'date1 = Date.Now

                'TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & date1 & "','" & date1 & "','01,02,03,04','" & cbolinea.SelectedValue & "'," & 0 & ",'MOVIDET',0")
                'TmpInsertDatos("SP_INS_KARDEX_TMP2 '" & codempresa & "'")
                'TmpInsertDatos("UP_ARTIDAT '" & Me.txtcodarticulo.Text & "'")

                Dim Fechari As Date, Fecharf As Date
                Dim fecini As Date

                Dim dt As New DataTable
                Dim Fech As Date, FECHCIERRE As String

                ' CadenaCateg = Tabla.Rows(0)("codlinea").ToString
                CadenaCateg = Tabla.Rows(0)("CODARTI").ToString
                Dim Table_Correlativo As New DataTable

                Table_Correlativo = CAyuda.ListarDatos("SP_RECORRER_ALMSTK", Me.txtcodarticulo.Text).Tables(0)

                If Table_Correlativo.Rows.Count > 0 Then
                    For i As Integer = 0 To Table_Correlativo.Rows.Count - 1
                        CierreIgual = False
                        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

                        dt = SelectFechCiere(Fech, False, Table_Correlativo.Rows(i)(0).ToString)
                        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
                        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
                        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

                        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
                        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
                        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

                        Procesar_Saldo(FECHCIERRE, Table_Correlativo.Rows(i)(0).ToString)
                        If CAyuda.Ejecutar("UP_ARTIDAT", Me.txtcodarticulo.Text, Table_Correlativo.Rows(i)(0).ToString, rand) > 0 Then
                            TmpInsertDatos("DELETE FROM  TMp_kardex  WHERE CORREL=" & rand)
                            TmpInsertDatos("DELETE FROM  TMP_SUMKARDEX2  WHERE CORREL=" & rand)
                            TmpInsertDatos("DELETE FROM  KARDEX_TMP  WHERE CORREL=" & rand)
                        End If
                    Next
                End If

                'TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL4 '" & codempresa & "','" & date1 & "','" & date2 & "','" & almacen1 & "','" & CadenaCateg & "'," & 0 & ",'MOVIDET',0")
                'TmpInsertDatos("SP_INS_KARDEX_TMP2 '" & codempresa & "'")

                mostrarcodalter()
                mostrarproveedor()
                MostrarAlmacenes()
                MostrarSubCategoria()
                Me.cbosublinea.SelectedValue = Tabla.Rows(0)("codsublinea").ToString
                TmpInsertDatos("CargarTempMaestraArtixProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "','" & txtcodarticulo.Text.Trim & "'")
                Tmp_Present = TmpListarDatos("ListarTMP_ARTIPRESENTxProc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
                DgPresentac.DataSource = Tmp_Present
                FormatoGridPresent()

                Tmp_DESC = TmpListarDatos("ListarTMP_ARTIDESCxProc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
                DataGrid1.DataSource = Tmp_DESC
                FormatoGridPresent2()

                TMP_PRECIART = TmpListarDatos("ListarTMP_PRECIARTxProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "'")
                DgPreciart.DataSource = TMP_PRECIART
                FormatoGridPreciart()

                Tmp_Comisiones = TmpListarDatos("ListarTMP_ARTICOMISIONCxProc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
                DataGrid2.DataSource = Tmp_Comisiones
                FormatoGridPresent3()

            End If
        End If




        btnbus.Enabled = True
        If txtcodarticulo.Enabled = True Then
            txtcodarticulo.Focus()
        Else
            TxtDesArti.Focus()
        End If

        BLOQUEAR_CONTROLES()
        btnbus.Enabled = True

        TxtDesArti2.Focus()
        CargaGridProveedor1()
        CargaGridCodBarra()

        CargarGridArtiDat()

        BTNELIMINAR.Enabled = False





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


    Private Sub cboproveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboproveedor.SelectedIndexChanged
        Me.txtdescrip.Text = Me.TxtDesArti.Text
        Me.txtcodcompra.Focus()
    End Sub
    Private Sub txtdescrip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescrip.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Me.txtcodcompra.Focus()
        End If
    End Sub
    Private Sub GRIDPROVEEDOR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GRIDPROVEEDOR.KeyDown
        If e.KeyCode = Keys.F3 Then
            Dim STATUS As Boolean
            Dim sql As String
            Dim CODPROVEEDOR As String
            Dim X As Integer
            X = GRIDPROVEEDOR.CurrentRowIndex
            CODPROVEEDOR = GRIDPROVEEDOR.Item(X, 1)
            sql = "sp_dele_TMP_proveart '" & txtcodarticulo.Text & "','" & CODPROVEEDOR & "','" & CodUsuario & "','" & Maquina & "','" & codempresa & "'"
            STATUS = TmpInsertDatos(sql)
            CargaGridProveedor1()
            If STATUS = False Then
                Exit Sub
            End If
        End If
    End Sub
    Private Sub cbolinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbolinea.SelectedIndexChanged
        'CARGAR EL CODIGO DE  FAMILIA AL CODIGO DE ARTICULO
        REM ------------------------------------------------------------


        If FLAG = 0 Then
            If ACT_EVENTOS = 1 Then
                Try
                    If Samira = False Then
                        Dim Table_Correlativo As New DataTable
                        Table_Correlativo = CAyuda.ListarDatos("BUSCAR_CORREL_LINEA", Me.cbolinea.SelectedValue, codempresa).Tables(0)
                        If Table_Correlativo.Rows.Count > 0 Then

                            CorrelativoLinea = "000" & Table_Correlativo.Rows(0)(0).ToString
                            CorrelativoLinea = Mid(CorrelativoLinea, CorrelativoLinea.Length - 2)
                            Me.txtcodarticulo.Text = CorrelativoLinea





                            Me.txtcodarticulo.Text = Me.cbolinea.SelectedValue + CorrelativoLinea
                        End If
                    End If
                    MostrarSubCategoria()
                Catch ex As Exception
                End Try
            End If
        End If


        If FLAG = 1 Then
            Try
                MostrarSubCategoria()
            Catch ex As Exception
            End Try

        End If



    End Sub
    Private Sub TxtDesArti_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesArti.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtDesArti2.Focus()
        End If
    End Sub
    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Dim GuiReporteArti As New FrmRepArticulo
        GuiReporteArti.ShowDialog()
    End Sub
    Private Sub frmarticulos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.Activate()
        Me.BTNNUEVO.Focus()
    End Sub
    Private Sub txtcodarticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodarticulo.KeyDown
        If e.KeyCode = Keys.F2 Then
            If Me.btnbus.Enabled = True Then
                Call btnbus_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub TxtDesArti_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDesArti.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Me.TxtDesArti2.Focus()
        End If
    End Sub
    Private Sub TxtDesArti2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDesArti2.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Me.cbolinea.Focus()
        End If
    End Sub
    Private Sub cboimpuesto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboimpuesto.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            CboIsc.Focus()
        End If
    End Sub
    Private Sub cbolinea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbolinea.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Try
                If Samira = False Then
                    Dim Table_Correlativo As New DataTable
                    Dim CorrelativoLinea As String
                    Table_Correlativo = CAyuda.ListarDatos("BUSCAR_CORREL_LINEA", Me.cbolinea.SelectedValue, codempresa).Tables(0)
                    If Table_Correlativo.Rows.Count > 0 Then
                        CorrelativoLinea = "00000" & Table_Correlativo.Rows(0)(0).ToString
                        CorrelativoLinea = Mid(CorrelativoLinea, CorrelativoLinea.Length - 4)
                        Me.txtcodarticulo.Text = Me.cbolinea.SelectedValue + CorrelativoLinea
                    End If
                End If
            Catch ex As Exception
            End Try

            Me.cbosublinea.Focus()
        End If
    End Sub
    Private Sub cbosublinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosublinea.SelectedIndexChanged

    End Sub
    Private Sub btnBuscPresent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FRMX As New frmgridpresentacion
        FRMX.FrmAR = Me
        FRMX.ShowDialog()
        txtPreciArt.Focus()
    End Sub
    Private Sub btnAgregarPresent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPresent.Click

        If ModifPreciart = True Then
            TmpInsertDatos("UpdateTMP_PRECIARTxProc   '" & codempresa & "','" & CodUsuario & "','" & Maquina & "','" & Trim(CboPresentacion.SelectedValue) & "','" & Trim(CboTipoPrecio.SelectedValue) & "','" & CDbl(TxtMargen.Text) & "','" & CDbl(txtPreciArt.Text) & "','" & ckRestringVenta.CheckState & "','" & LblEquiv.Text & "'")
            CboPresentacion.Enabled = True
            CboTipoPrecio.Enabled = True
            ModifPreciart = False
        Else

            If TmpListarDatos("SELECT  * FROM  TMP_PRECIART WHERE CDUSUARIO='" & CodUsuario & "' AND MAQUINA='" & Maquina & "' AND CODPRES='" & Trim(CboPresentacion.SelectedValue) & "' AND CDTIPOPRE='" & Trim(CboTipoPrecio.SelectedValue) & "' ").Rows.Count > 0 Then
                MsgBox("EL PRECIO X PRESENTACION YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            TmpInsertDatos("InsTMP_PRECIARTxProc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "','" & Trim(CboPresentacion.SelectedValue) & "','" & Trim(CboTipoPrecio.SelectedValue) & "','" & txtcodarticulo.Text.Trim & "','" & CDbl(txtPreciArt.Text) & "','" & CDbl(txtPreciArt.Text) / VCambioVta & "','0','0','0','0','" & CDbl(TxtMargen.Text) & "','" & ckRestringVenta.CheckState & "','" & LblEquiv.Text & "'")
        End If


        TMP_PRECIART = TmpListarDatos("ListarTMP_PRECIARTxProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "'")
        DgPreciart.DataSource = TMP_PRECIART
        FormatoGridPreciart()
    End Sub

    Private Sub txtCodPresentacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            btnBuscPresent_Click(sender, e)
        End If

    End Sub


    Private Sub btnAgrAlma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgrAlma.Click



        Dim STATUS As Boolean
        Dim sql As String
        If Me.cboAlmacen.Text <> "" Then

            If TmpListarDatos("SELECT * FROM TMP_ARTIDAT WHERE CODARTI='" & txtcodarticulo.Text & "' AND  CODALMACEN='" & cboAlmacen.SelectedValue.ToString & "' AND  MAQUINA='" & Maquina & "' AND CODEMPRESA='" & codempresa & "' AND USUARIO='" & CodUsuario & "' ").Rows.Count > 0 Then
                MsgBox("EL ALMACEN DEL YA ESTA INGRESADO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            sql = "SP_INST_TMP_ARTIDATNAR " & TxtStockMax.Text & ",'" & 0 & "','" & TxtStockMini.Text & "','" & 0 & "','" & txtcodarticulo.Text & "', '" & cboAlmacen.SelectedValue.ToString & "'  ,'" & CodUsuario & "','" & Maquina & "','" & Me.txtUbicacion.Text & "','" & codempresa & "','" & txtStockActual.Text & "'"
            STATUS = TmpInsertDatos(sql)
            CargarGridArtiDat()
            TxtStockMax.Text = FACT_MASCARA(0, DECICANT)
            TxtStockMini.Text = FACT_MASCARA(0, DECICANT)
            txtStockActual.Text = FACT_MASCARA(0, DECICANT)
            txtStockInicio.Text = FACT_MASCARA(0, DECICANT)
            txtUltimoIngreso.Text = ""
            txtUltimaSalida.Text = ""
            txtUbicacion.Text = ""
            cboAlmacen.Focus()
        End If
        If STATUS = False Then
            MessageBox.Show("Almacen resgitrado para el Articulo", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

    End Sub
    Private Sub DgAlmacen_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)



    End Sub
    Private Sub DgAlmacen_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        DgAlmacen.Select(DgAlmacen.CurrentRowIndex)
        ModifAlma = True
    End Sub
    Private Sub cboAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedIndexChanged

    End Sub
    Private Sub cboAlmacen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboAlmacen.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtStockMini.Focus()
            TxtStockMini.Select(0, TxtStockMini.Text.Trim.Length)
        End If
    End Sub

    Private Sub TxtStockMini_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStockMini.KeyPress

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


    Private Sub TxtStockMini_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStockMini.TextChanged

    End Sub



    Private Sub TxtStockMini_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStockMini.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtStockMax.Focus()
            TxtStockMax.Select(0, TxtStockMax.Text.Trim.Length)
        End If
    End Sub

    Private Sub TxtStockMax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStockMax.KeyPress

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
    Private Sub TxtStockMax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStockMax.TextChanged

    End Sub
    Private Sub TxtStockMax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStockMax.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUbicacion.Focus()
            txtUbicacion.Select(0, txtUbicacion.Text.Trim.Length)
        End If

    End Sub
    Private Sub txtUbicacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUbicacion.TextChanged

    End Sub
    Private Sub txtUbicacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUbicacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgrAlma_Click(sender, e)

            TxtStockMax.Text = FACT_MASCARA(0, DECICANT)
            TxtStockMini.Text = FACT_MASCARA(0, DECICANT)
            txtUbicacion.Text = ""
            cboAlmacen.Focus()
        End If
    End Sub
    Private Sub btnQuitAlma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitAlma.Click

        TmpInsertDatos("SP_ELIMI_ARTIDAT  '" & txtcodarticulo.Text.Trim & "', '" & DgAlmacen.Item(DgAlmacen.CurrentRowIndex, 0) & "','" & CodUsuario & "','" & Maquina & "','" & codempresa & "'   ")
        ModifAlma = False
        CargarGridArtiDat()
        TxtStockMax.Text = FACT_MASCARA(0, DECICANT)
        TxtStockMini.Text = FACT_MASCARA(0, DECICANT)
        txtStockActual.Text = FACT_MASCARA(0, DECICANT)
        txtStockInicio.Text = FACT_MASCARA(0, DECICANT)
        txtUltimoIngreso.Text = ""
        txtUltimaSalida.Text = ""
        txtUbicacion.Text = ""
        cboAlmacen.Focus()



    End Sub
    Private Sub ctrlmontocosto_change(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctrlmontocosto.change


    End Sub
    Private Sub ctrlmontocosto_KeyDownEvent(ByVal sender As Object, ByVal e As AxMiControl.__CtrlNumber_KeyDownEvent) Handles ctrlmontocosto.KeyDownEvent
        If e.keyCode = Keys.Enter Then
            Dim ev As EventArgs = Nothing
            btnagre_Click(sender, ev)
        End If
    End Sub
    Private Sub GRIDPROVEEDOR_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GRIDPROVEEDOR.Navigate

    End Sub
    Private Sub GRIDPROVEEDOR_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRIDPROVEEDOR.CurrentCellChanged
        GRIDPROVEEDOR.Select(GRIDPROVEEDOR.CurrentRowIndex)
        ModifProv = True

    End Sub
    Private Sub txtPreciArt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPreciArt.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregarPresent_Click(sender, e)
        End If
    End Sub
    Private Sub CboIsc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboIsc.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.AxCtrlCubicaje.Focus()
        ElseIf e.KeyCode = Keys.Delete Then
            CboIsc.SelectedValue = ""
            CboIsc.Text = ""
        End If
    End Sub
    Private Sub AxCtrlDescuento_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxMiControl.__CtrlNumber_KeyDownEvent)
        If e.keyCode = Keys.Enter Then
            AxCtrtPesoKg.Focus()
        End If
    End Sub
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
    Private Sub btnBusPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FRMX As New FrmBusqTipoPrecio
        FRMX.frm = Me
        FRMX.ShowDialog()
        Me.txtPreciArt.Focus()
    End Sub


    Private Sub txtCodPresentacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub
    Private Sub CajaTexto_EnviarTAB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub AxCtrlCubicaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxCtrlCubicaje.TextChanged
    End Sub
    Private Sub AxCtrlCubicaje_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AxCtrlCubicaje.KeyPress
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
    Private Sub AxCtrlComision_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxCtrlComision.TextChanged

    End Sub
    Private Sub AxCtrlComision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AxCtrlComision.KeyPress
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
    Private Sub AxCtrlDescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxCtrlDescuento.TextChanged

    End Sub
    Private Sub AxCtrlDescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AxCtrlDescuento.KeyPress
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
    Private Sub AxCtrtPesoKg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxCtrtPesoKg.TextChanged

    End Sub
    Private Sub AxCtrtPesoKg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AxCtrtPesoKg.KeyPress
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
    Private Sub CboIsc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboIsc.SelectedIndexChanged

    End Sub
    Private Sub AxCtrlCubicaje_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AxCtrlCubicaje.KeyDown
        If e.KeyCode = Keys.Enter Then
            If AxCtrlCubicaje.Text.Trim = String.Empty Then
                AxCtrlCubicaje.Text = 0
            End If
            AxCtrlCubicaje.Text = FACT_MASCARA(AxCtrlCubicaje.Text, DECICANT)
            AxCtrlComision.Focus()
        End If
    End Sub
    Private Sub AxCtrlComision_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AxCtrlComision.KeyDown
        If e.KeyCode = Keys.Enter Then
            If AxCtrlComision.Text.Trim = String.Empty Then
                AxCtrlComision.Text = 0
            End If
            AxCtrlComision.Text = FACT_MASCARA(AxCtrlComision.Text, DECICANT)
            AxCtrlDescuento.Focus()
        End If
    End Sub
    Private Sub AxCtrtPesoKg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AxCtrtPesoKg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If AxCtrtPesoKg.Text.Trim = String.Empty Then
                AxCtrtPesoKg.Text = 0
            End If
            AxCtrtPesoKg.Text = FACT_MASCARA(AxCtrtPesoKg.Text, DECICANT)
            TabControl1.SelectedIndex = 1
            'txtCodPresentacion.Focus()
        End If
    End Sub
    Private Sub AxCtrlDescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AxCtrlDescuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            If AxCtrlDescuento.Text.Trim = String.Empty Then
                AxCtrlDescuento.Text = 0
            End If
            AxCtrlDescuento.Text = FACT_MASCARA(AxCtrlDescuento.Text, DECICANT)
            AxCtrtPesoKg.Focus()
        End If
    End Sub
    Private Sub cbosublinea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbosublinea.KeyDown
        If e.KeyCode = Keys.Enter Then
            cboimpuesto.Focus()
        End If
    End Sub
    Private Sub AxCtrlCubicaje_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxCtrlCubicaje.Leave
        If AxCtrlCubicaje.Text.Trim = String.Empty Then
            AxCtrlCubicaje.Text = FACT_MASCARA(0, DECICANT)
        End If
    End Sub
    Private Sub AxCtrlComision_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxCtrlComision.Leave
        If AxCtrlComision.Text.Trim = String.Empty Then
            AxCtrlComision.Text = FACT_MASCARA(0, DECICANT)
        End If
    End Sub
    Private Sub AxCtrlDescuento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxCtrlDescuento.Leave
        If AxCtrlDescuento.Text.Trim = String.Empty Then
            AxCtrlDescuento.Text = FACT_MASCARA(0, DECICANT)
        End If
    End Sub
    Private Sub AxCtrtPesoKg_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxCtrtPesoKg.Leave
        If AxCtrtPesoKg.Text.Trim = String.Empty Then
            AxCtrtPesoKg.Text = FACT_MASCARA(0, DECICANT)
        End If
    End Sub
    Private Sub BtInsPrest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtInsPrest.Click
        If TxtCodPres.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        If TmpListarDatos("SELECT  * FROM  TMP_ARTIPRESENT WHERE CDUSUARIO='" & CodUsuario & "'  AND MAQUINA='" & Maquina & "'  AND CODPRES='" & TxtCodPres.Text & "' ").Rows.Count > 0 Then
            MsgBox("LA PRESENTACION YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If



        TmpInsertDatos("InsTMP_ARTIPRESENT_Proc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "','" & txtcodarticulo.Text & "','" & TxtCodPres.Text & "','" & TxtEquiv.Text & "'")
        Tmp_Present = TmpListarDatos("ListarTMP_ARTIPRESENTxProc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
        DgPresentac.DataSource = Tmp_Present
        FormatoGridPresent()
        LblPresent.Text = ""
        TxtCodPres.Text = ""
        TxtEquiv.Text = "0"
        BtnPresent.Focus()



    End Sub
    Private Sub BtnPresent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPresent.Click

        Dim FrmPres As New FrmBusqPresentacion
        FrmPres.ShowDialog()
        If FrmPres.DEVOLVER = False Then
            Exit Sub
        End If
        TxtCodPres.Text = FrmPres.Grid1.Item(FrmPres.Grid1.CurrentRowIndex, 0)
        LblPresent.Text = FrmPres.Grid1.Item(FrmPres.Grid1.CurrentRowIndex, 2)
        TxtEquiv.Text = FrmPres.Grid1.Item(FrmPres.Grid1.CurrentRowIndex, 3)
        TxtEquiv.Focus()


    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        Select Case TabControl1.SelectedIndex
            Case 0


            Case 1
                LblArticulo.Text = TxtDesArti.Text
            Case 2
                If Tmp_Present.Rows.Count > 0 Then
                    CboPresentacion.DataSource = Tmp_Present
                    CboPresentacion.ValueMember = "CODPRES"
                    CboPresentacion.DisplayMember = "DESPRES"
                End If

        End Select

    End Sub

    Private Sub TxtEquiv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEquiv.KeyPress

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
    Private Sub TxtEquiv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtEquiv.TextChanged

    End Sub
    Private Sub TxtEquiv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEquiv.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtInsPrest_Click(sender, e)

        End If
    End Sub
    Private Sub BtnDeletPresnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeletPresnt.Click
        Try
            If Tmp_Present.Rows.Count > 0 Then


                Dim CodPresent As String
                CodPresent = Trim(DgPresentac.Item(DgPresentac.CurrentRowIndex, 0))



                Dim meses As Integer

                Dim MesAct, Anio As String
                Dim VentaC, VentD, MoviD, MoviC As String
                Dim DT_CANIDAD As DataTable

                meses = Val(DateDiff("m", "01/01/2010", DtFechaFin.Value))

                'Dim DT_DATE As DataTable
                'DT_DATE = TmpListarDatos("SP_EXTRAER_AÑO_MES  '" & codempresa & "'")

                '''SELECCIONO LAS VENTAS
                'For i As Integer = 0 To DT_DATE.Rows.Count - 1

                '    MesAct = "00" & DT_DATE.Rows(i)("MES").ToString.Trim
                '    MesAct = Mid(MesAct, MesAct.Length - 1)

                '    Anio = DT_DATE.Rows(i)("AÑO")
                '    VentaC = "VENTC" & Anio & MesAct
                '    VentD = "VENTD" & Anio & MesAct
                '    MoviD = "MOVID" & Anio & MesAct
                '    MoviC = "MOVIC" & Anio & MesAct

                '    If VERIFICA_HISTORICOVENT(VentaC) = True Then
                '        DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_PRESENTACIONES_VTA '" & codempresa & "','" & txtcodarticulo.Text & "','" & CodPresent & "','" & VentD & "'")

                '        If DT_CANIDAD.Rows.Count > 0 Then
                '            MsgBox("ESA PRESENTACION NO SE PUEDE BORRAR ESTA EN VENTA")
                '            Exit Sub
                '        End If
                '    End If

                '    If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then

                '        DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_PRESENTACIONES_MOVI '" & codempresa & "','" & txtcodarticulo.Text & "','" & CodPresent & "','" & MoviD & "'")

                '        If DT_CANIDAD.Rows.Count > 0 Then
                '            MsgBox("ESA PRESENTACION NO SE PUEDE BORRAR ESTA EN MOVI")
                '            Exit Sub
                '        End If
                '    End If

                'Next


                Dim DT_HISTOVENTAS As DataTable
                DT_HISTOVENTAS = TmpListarDatos("SP_EXTRAER_HISTOVENTAS  '" & codempresa & "'")

                For i As Integer = 0 To DT_HISTOVENTAS.Rows.Count - 1
                    VentaC = DT_HISTOVENTAS.Rows(i)(0)
                    If VERIFICA_HISTORICOVENT(VentaC) = True Then
                        VentD = Replace(VentaC, "VENTC", "VENTD")

                        DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_PRESENTACIONES_VTA '" & codempresa & "','" & txtcodarticulo.Text & "','" & CodPresent & "','" & VentD & "'")

                        If DT_CANIDAD.Rows.Count > 0 Then
                            MsgBox("ESA PRESENTACION NO SE PUEDE BORRAR ESTA EN VENTA")
                            Exit Sub
                        End If
                    End If
                Next


                Dim DT_HISTOMOVI As DataTable
                DT_HISTOMOVI = TmpListarDatos("SP_EXTRAER_HISTOMOVIMIENTOS  '" & codempresa & "'")

                For i As Integer = 0 To DT_HISTOMOVI.Rows.Count - 1
                    MoviC = DT_HISTOMOVI.Rows(i)(0)
                    If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                        MoviD = Replace(MoviC, "MOVIC", "MOVID")
                        DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_PRESENTACIONES_MOVI '" & codempresa & "','" & txtcodarticulo.Text & "','" & CodPresent & "','" & MoviD & "'")

                        If DT_CANIDAD.Rows.Count > 0 Then
                            MsgBox("ESA PRESENTACION NO SE PUEDE BORRAR ESTA EN MOVI")
                            Exit Sub
                        End If
                    End If
                Next


                'CASO Q ESTA LAS TABLAS NORMALES

                DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_PRESENTACIONES_VTA '" & codempresa & "','" & txtcodarticulo.Text & "','" & CodPresent & "','" & 0 & "'")
                If DT_CANIDAD.Rows.Count > 0 Then
                    MsgBox("ESA PRESENTACION NO SE PUEDE BORRAR ESTA EN VENTA")
                    Exit Sub
                End If


                DT_CANIDAD = TmpListarDatos("SP_BUSQUEDA_PRESENTACIONES_MOVI '" & codempresa & "','" & txtcodarticulo.Text & "','" & CodPresent & "','" & 0 & "'")
                If DT_CANIDAD.Rows.Count > 0 Then
                    MsgBox("ESA PRESENTACION NO SE PUEDE BORRAR ESTA EN MOVIMIENTO")
                    Exit Sub
                End If




                TmpInsertDatos("EliTMP_ARTIPRESENTxProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "','" & CodPresent & "'")
                Tmp_Present = TmpListarDatos("ListarTMP_ARTIPRESENTxProc   '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
                DgPresentac.DataSource = Tmp_Present
                FormatoGridPresent()
                LblPresent.Text = ""
                TxtCodPres.Text = ""
                TxtEquiv.Text = "0"
                BtnPresent.Focus()

            Else
                MsgBox("No hay regsitro a eliminar..", MsgBoxStyle.Exclamation, DesEmpresa)
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar la fila a eliminar..", MsgBoxStyle.Exclamation, DesEmpresa)
        End Try
    End Sub

    Private Sub CboPresentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboPresentacion.SelectedIndexChanged
        Try
            If Tmp_Present.Rows.Count > 0 Then
                For i As Integer = 0 To Tmp_Present.Rows.Count - 1
                    If Trim(CboPresentacion.SelectedValue) = Trim(Tmp_Present.Rows(i)("CODPRES")) Then
                        LblEquiv.Text = Trim(Tmp_Present.Rows(i)("EQUIVALENCIA"))
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CboTipoPrecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoPrecio.SelectedIndexChanged

    End Sub

    Private Sub CboPresentacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboPresentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            CboTipoPrecio.Focus()
        End If
    End Sub

    Private Sub CboTipoPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboTipoPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtMargen.Focus()
        End If
    End Sub

    Private Sub TxtMargen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMargen.KeyPress

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

    Private Sub TxtMargen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMargen.TextChanged
    End Sub

    Private Sub TxtMargen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMargen.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPreciArt.Focus()
        End If
    End Sub

    Private Sub btnQuitarPrest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarPrest.Click

        If TMP_PRECIART.Rows.Count > 0 Then

            Dim VCodPresent, VCodTipoPre As String
            VCodTipoPre = Trim(DgPreciart.Item(DgPreciart.CurrentRowIndex, 0))
            VCodPresent = Trim(DgPreciart.Item(DgPreciart.CurrentRowIndex, 2))
            TmpInsertDatos("EliTMP_PRECIARTxProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "','" & VCodPresent & "','" & VCodTipoPre & "'")
            TMP_PRECIART = TmpListarDatos("ListarTMP_PRECIARTxProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "'")
            DgPreciart.DataSource = TMP_PRECIART
            FormatoGridPreciart()

        End If


    End Sub

    Private Sub DgPreciart_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgPreciart.Navigate

    End Sub

    Private Sub txtcodcompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodcompra.KeyPress


        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            Me.ctrlmontocosto.Focus()
        End If


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


    Private Sub txtcodcompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodcompra.TextChanged

    End Sub

    Private Sub TxtDesArti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesArti.TextChanged
        txtdescrip.Text = TxtDesArti.Text
    End Sub

    Private Sub txtcodarticulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodarticulo.TextChanged

    End Sub

    Private Sub BTNNUEVO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BTNNUEVO.KeyPress

    End Sub

    Private Sub BTNNUEVO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BTNNUEVO.KeyDown
        If e.KeyCode = Keys.F2 Then
            If Me.btnbus.Enabled = True Then
                Call btnbus_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub BTNCANCELAR_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BTNCANCELAR.KeyDown
        If e.KeyCode = Keys.F2 Then
            If Me.btnbus.Enabled = True Then
                Call btnbus_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnbus_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnbus.KeyDown
        If e.KeyCode = Keys.F2 Then
            If Me.btnbus.Enabled = True Then
                Call btnbus_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txtPreciArt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPreciArt.KeyPress

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

    Private Sub txtPreciArt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPreciArt.TextChanged

    End Sub

    Private Sub txtUltimoIngreso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUltimoIngreso.KeyPress

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

    Private Sub txtUltimoIngreso_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUltimoIngreso.TextChanged

    End Sub

    Private Sub txtStockActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStockActual.KeyPress

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

    Private Sub txtStockActual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStockActual.TextChanged

    End Sub

    Private Sub txtUltimaSalida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUltimaSalida.KeyPress

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

    Private Sub txtUltimaSalida_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUltimaSalida.KeyUp




    End Sub

    Private Sub txtUltimaSalida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUltimaSalida.TextChanged

    End Sub

    Private Sub txtStockInicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStockInicio.KeyPress

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

    Private Sub txtStockInicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStockInicio.TextChanged

    End Sub




    Private Sub txtdescrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescrip.TextChanged

    End Sub

    Private Sub DgPresentac_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgPresentac.Navigate

    End Sub

    Private Sub btnAgregarDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarDesc.Click
        If TextBox1.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        If TmpListarDatos("SELECT  * FROM  TMP_ARTIDESC WHERE CDUSUARIO='" & CodUsuario & "'  AND MAQUINA='" & Maquina & "'  AND CODPRES='" & CboTipoPrecio2.SelectedValue.ToString & "' ").Rows.Count > 0 Then
            MsgBox("EL DESCUENTO YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If



        TmpInsertDatos("InsTMP_ARTIDESC_Proc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "','" & txtcodarticulo.Text & "','" & CboTipoPrecio2.SelectedValue.ToString & "','" & TextBox1.Text & "'")
        Tmp_DESC = TmpListarDatos("ListarTMP_ARTIDESCxProc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
        DataGrid1.DataSource = Tmp_DESC
        FormatoGridPresent2()
        LblPresent.Text = ""
        TxtCodPres.Text = ""
        TxtEquiv.Text = "0"
        BtnPresent.Focus()





    End Sub


    Private Sub FormatoGridPresent2()
        DataGrid1.TableStyles.Clear()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = Tmp_DESC.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODPRES"
            .NullText = ""
            .HeaderText = "Codigo"
            .Width = 150
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DSTIPOPRE"
            .NullText = ""
            .HeaderText = "Descripcion Tipo Precio"
            .Width = 300
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "PORC_DESC"
            .NullText = ""
            .Format = "#######0.00"
            .HeaderText = "% DESC"
            .Width = 100
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3})
        DataGrid1.TableStyles.Add(TableStyle1)


    End Sub

    Private Sub FormatoGridPresent3()
        DataGrid2.TableStyles.Clear()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = Tmp_DESC.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CDTIPOCOM"
            .NullText = ""
            .HeaderText = "Codigo"
            .Width = 150
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DSTIPOCOM"
            .NullText = ""
            .HeaderText = "Descripcion Comision"
            .Width = 300
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "PORC_COM"
            .NullText = ""
            .Format = "#######0.00"
            .HeaderText = "% Comision"
            .Width = 100
        End With


        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "FECINI"
            .NullText = ""
            .HeaderText = "FechaIniciai"
            .Width = 70
        End With

        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "FECFINAL"
            .NullText = ""
            .HeaderText = "FechaFinal"
            .Width = 70
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGrid2.TableStyles.Add(TableStyle1)


    End Sub




    Private Sub btnQuitarDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarDesc.Click
        Try
            If Tmp_Present.Rows.Count > 0 Then
                Dim CodPresent As String
                CodPresent = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0))
                TmpInsertDatos("EliTMP_ARTIDESCxProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "','" & CodPresent & "'")
                Tmp_Present = TmpListarDatos("ListarTMP_ARTIDESCxProc   '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
                DataGrid1.DataSource = Tmp_Present
                FormatoGridPresent2()
                LblPresent.Text = ""
                TxtCodPres.Text = ""
                TxtEquiv.Text = "0"
                BtnPresent.Focus()

            Else
                MsgBox("No hay regsitro a eliminar..", MsgBoxStyle.Exclamation, DesEmpresa)
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar la fila a eliminar..", MsgBoxStyle.Exclamation, DesEmpresa)
        End Try


    End Sub

 
    Private Sub btnAgregarCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarCom.Click


        If TextBox2.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        If TmpListarDatos("SELECT  * FROM  TMP_ARTICOMISION WHERE CDUSUARIO='" & CodUsuario & "'  AND MAQUINA='" & Maquina & "'  AND CDTIPOCOM='" & CboTipoPrecio2.SelectedValue.ToString & "' ").Rows.Count > 0 Then
            MsgBox("EL DESCUENTO YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If



        TmpInsertDatos("InsTMP_ARTICOMISION_Proc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "','" & txtcodarticulo.Text & "','" & CboTipoComision.SelectedValue.ToString & "','" & TextBox2.Text & "','" & DateTimePicker1.Value.ToShortDateString & "','" & DateTimePicker2.Value.ToShortDateString & "'")
        Tmp_Comisiones = TmpListarDatos("ListarTMP_ARTICOMISIONCxProc  '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
        DataGrid2.DataSource = Tmp_Comisiones
        FormatoGridPresent3()
        LblPresent.Text = ""
        TxtCodPres.Text = ""
        TxtEquiv.Text = "0"
        BtnPresent.Focus()





    End Sub

    Private Sub btnQuitarCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarCom.Click
        Try
            If Tmp_Comisiones.Rows.Count > 0 Then
                Dim CodPresent As String
                CodPresent = Trim(DataGrid2.Item(DataGrid2.CurrentRowIndex, 0))
                TmpInsertDatos("EliTMP_ARTICOMISIONxProc  '" & codempresa & "','" & CodUsuario & "','" & Maquina & "','" & CodPresent & "'")
                Tmp_Comisiones = TmpListarDatos("ListarTMP_ARTICOMISIONCxProc   '" & CodUsuario & "','" & Maquina & "','" & codempresa & "'")
                DataGrid2.DataSource = Tmp_Comisiones
                FormatoGridPresent3()
                LblPresent.Text = ""
                TxtCodPres.Text = ""
                TxtEquiv.Text = "0"
                BtnPresent.Focus()

            Else
                MsgBox("No hay regsitro a eliminar..", MsgBoxStyle.Exclamation, DesEmpresa)
            End If
        Catch ex As Exception
            MsgBox("Debe seleccionar la fila a eliminar..", MsgBoxStyle.Exclamation, DesEmpresa)
        End Try
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class
