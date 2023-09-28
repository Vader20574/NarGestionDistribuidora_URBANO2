Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Drawing.Font
Imports System.IO
Public Class FRMGUIADIRECTA
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TXTTIMER As System.Windows.Forms.TextBox
    Friend WithEvents cbotipopago As System.Windows.Forms.ComboBox
    Friend WithEvents cbotipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtdesarticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtcodarticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtnumeroguia As System.Windows.Forms.TextBox
    Friend WithEvents txtcodcliente As System.Windows.Forms.TextBox
    Friend WithEvents cbovendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbotipopre As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodmoneda3 As System.Windows.Forms.Label
    Friend WithEvents txtnumoc As System.Windows.Forms.TextBox
    Friend WithEvents txtruc As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtdescliente As System.Windows.Forms.TextBox
    Friend WithEvents txtsubt As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents txttot As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtcambio As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents calmacen As System.Windows.Forms.ComboBox
    'Friend WithEvents DsInventInicial1 As mantenimiento.DsInventInicial
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnarticulo As System.Windows.Forms.Button
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNCLIENTE As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    'Friend WithEvents Ds_gridclie21 As mantenimiento.ds_gridclie2
    Friend WithEvents cbounidadventa As System.Windows.Forms.ComboBox
    Friend WithEvents lblunidadventa As System.Windows.Forms.Label
    Friend WithEvents btnobsitem As System.Windows.Forms.Button
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbalmllegada As System.Windows.Forms.ComboBox
    Friend WithEvents btnobs As System.Windows.Forms.Button
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtboleta As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtpto As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtigvart As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TXTBULTO As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TXTLOTE As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents LBL2 As System.Windows.Forms.Label
    Friend WithEvents LBL3 As System.Windows.Forms.Label
    Friend WithEvents LBL1 As System.Windows.Forms.Label
    Friend WithEvents LBLIGV As System.Windows.Forms.Label
    Friend WithEvents lblmoneda As System.Windows.Forms.Label
    Friend WithEvents TxtMedida As System.Windows.Forms.TextBox
    Friend WithEvents txtnumeroguia2 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtnumoc1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtPesBru As System.Windows.Forms.TextBox
    Friend WithEvents BtnTransferencia As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cbTipoPresent As System.Windows.Forms.ComboBox
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents txtOrdenDesp As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTraslado As System.Windows.Forms.RadioButton
    Friend WithEvents rbDespacho As System.Windows.Forms.RadioButton
    Friend WithEvents Label28 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMGUIADIRECTA))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rbTraslado = New System.Windows.Forms.RadioButton
        Me.rbDespacho = New System.Windows.Forms.RadioButton
        Me.txtOrdenDesp = New System.Windows.Forms.TextBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbomoneda = New System.Windows.Forms.ComboBox
        Me.BtnTransferencia = New System.Windows.Forms.Button
        Me.txtnumoc1 = New System.Windows.Forms.TextBox
        Me.lblmoneda = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.txtpto = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtboleta = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.cmbalmllegada = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.calmacen = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cbotipopre = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cbovendedor = New System.Windows.Forms.ComboBox
        Me.txtnumoc = New System.Windows.Forms.TextBox
        Me.cbotipodoc = New System.Windows.Forms.ComboBox
        Me.BTNCLIENTE = New System.Windows.Forms.Button
        Me.cbotipopago = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtruc = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txtdescliente = New System.Windows.Forms.TextBox
        Me.txtcodcliente = New System.Windows.Forms.TextBox
        Me.txtnumeroguia = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnumeroguia2 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtigv = New System.Windows.Forms.TextBox
        Me.txtsubt = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblcodmoneda3 = New System.Windows.Forms.Label
        Me.txttot = New System.Windows.Forms.TextBox
        Me.LBL2 = New System.Windows.Forms.Label
        Me.LBL3 = New System.Windows.Forms.Label
        Me.LBL1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Rpt1 = New AxCrystal.AxCrystalReport
        Me.Label27 = New System.Windows.Forms.Label
        Me.cbTipoPresent = New System.Windows.Forms.ComboBox
        Me.TxtPesBru = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.TXTLOTE = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TXTBULTO = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnobsitem = New System.Windows.Forms.Button
        Me.cbounidadventa = New System.Windows.Forms.ComboBox
        Me.lblunidadventa = New System.Windows.Forms.Label
        Me.txtprecio = New System.Windows.Forms.TextBox
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtdesarticulo = New System.Windows.Forms.TextBox
        Me.btnarticulo = New System.Windows.Forms.Button
        Me.txtcodarticulo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtigvart = New System.Windows.Forms.TextBox
        Me.txtcambio = New System.Windows.Forms.TextBox
        Me.TXTTIMER = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.LBLIGV = New System.Windows.Forms.Label
        Me.TxtMedida = New System.Windows.Forms.TextBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.BTNREPORTE = New System.Windows.Forms.Button
        Me.btnobs = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.txtOrdenDesp)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(824, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 217)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbTraslado)
        Me.GroupBox5.Controls.Add(Me.rbDespacho)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 152)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(206, 43)
        Me.GroupBox5.TabIndex = 53
        Me.GroupBox5.TabStop = False
        '
        'rbTraslado
        '
        Me.rbTraslado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTraslado.Location = New System.Drawing.Point(89, 18)
        Me.rbTraslado.Name = "rbTraslado"
        Me.rbTraslado.Size = New System.Drawing.Size(92, 16)
        Me.rbTraslado.TabIndex = 3
        Me.rbTraslado.Text = "NroTraslado"
        '
        'rbDespacho
        '
        Me.rbDespacho.Checked = True
        Me.rbDespacho.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDespacho.Location = New System.Drawing.Point(22, 17)
        Me.rbDespacho.Name = "rbDespacho"
        Me.rbDespacho.Size = New System.Drawing.Size(68, 19)
        Me.rbDespacho.TabIndex = 2
        Me.rbDespacho.TabStop = True
        Me.rbDespacho.Text = "NroDespacho"
        '
        'txtOrdenDesp
        '
        Me.txtOrdenDesp.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrdenDesp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOrdenDesp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenDesp.Location = New System.Drawing.Point(12, 190)
        Me.txtOrdenDesp.Name = "txtOrdenDesp"
        Me.txtOrdenDesp.Size = New System.Drawing.Size(96, 21)
        Me.txtOrdenDesp.TabIndex = 71
        Me.txtOrdenDesp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(12, 76)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(91, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(13, 102)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(91, 23)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "C&errar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(12, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(91, 23)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(12, 48)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(91, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 4
        Me.Button2.Location = New System.Drawing.Point(15, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "E&ditar Nro Guia"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(981, 87)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(91, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "Anular"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNELIMINAR.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbomoneda)
        Me.GroupBox2.Controls.Add(Me.BtnTransferencia)
        Me.GroupBox2.Controls.Add(Me.txtnumoc1)
        Me.GroupBox2.Controls.Add(Me.lblmoneda)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.txtpto)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtboleta)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.crRpt)
        Me.GroupBox2.Controls.Add(Me.cmbalmllegada)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.calmacen)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cbotipopre)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cbovendedor)
        Me.GroupBox2.Controls.Add(Me.txtnumoc)
        Me.GroupBox2.Controls.Add(Me.cbotipodoc)
        Me.GroupBox2.Controls.Add(Me.BTNCLIENTE)
        Me.GroupBox2.Controls.Add(Me.cbotipopago)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtruc)
        Me.GroupBox2.Controls.Add(Me.txtdireccion)
        Me.GroupBox2.Controls.Add(Me.txtdescliente)
        Me.GroupBox2.Controls.Add(Me.txtcodcliente)
        Me.GroupBox2.Controls.Add(Me.txtnumeroguia)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtnumeroguia2)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 192)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomoneda.Location = New System.Drawing.Point(528, 160)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(224, 22)
        Me.cbomoneda.TabIndex = 56
        Me.cbomoneda.Visible = False
        '
        'BtnTransferencia
        '
        Me.BtnTransferencia.Enabled = False
        Me.BtnTransferencia.ImageIndex = 5
        Me.BtnTransferencia.ImageList = Me.ImageList1
        Me.BtnTransferencia.Location = New System.Drawing.Point(720, 64)
        Me.BtnTransferencia.Name = "BtnTransferencia"
        Me.BtnTransferencia.Size = New System.Drawing.Size(32, 23)
        Me.BtnTransferencia.TabIndex = 70
        Me.BtnTransferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTransferencia.Visible = False
        '
        'txtnumoc1
        '
        Me.txtnumoc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnumoc1.Location = New System.Drawing.Point(528, 64)
        Me.txtnumoc1.MaxLength = 3
        Me.txtnumoc1.Name = "txtnumoc1"
        Me.txtnumoc1.Size = New System.Drawing.Size(48, 21)
        Me.txtnumoc1.TabIndex = 69
        Me.txtnumoc1.Visible = False
        '
        'lblmoneda
        '
        Me.lblmoneda.AutoSize = True
        Me.lblmoneda.Location = New System.Drawing.Point(471, 164)
        Me.lblmoneda.Name = "lblmoneda"
        Me.lblmoneda.Size = New System.Drawing.Size(52, 13)
        Me.lblmoneda.TabIndex = 55
        Me.lblmoneda.Text = "Moneda :"
        Me.lblmoneda.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(296, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 24)
        Me.CheckBox1.TabIndex = 48
        Me.CheckBox1.Text = "Editar Codigo"
        Me.CheckBox1.Visible = False
        '
        'txtpto
        '
        Me.txtpto.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtpto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpto.Location = New System.Drawing.Point(528, 16)
        Me.txtpto.Name = "txtpto"
        Me.txtpto.ReadOnly = True
        Me.txtpto.Size = New System.Drawing.Size(192, 21)
        Me.txtpto.TabIndex = 47
        Me.txtpto.Text = "TextBox1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(450, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Punto Venta :"
        '
        'txtboleta
        '
        Me.txtboleta.Location = New System.Drawing.Point(118, 160)
        Me.txtboleta.Name = "txtboleta"
        Me.txtboleta.Size = New System.Drawing.Size(130, 21)
        Me.txtboleta.TabIndex = 45
        Me.txtboleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtboleta.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(29, 160)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Boleta Pesada :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(430, 34)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 43
        Me.crRpt.Visible = False
        '
        'cmbalmllegada
        '
        Me.cmbalmllegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbalmllegada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbalmllegada.Location = New System.Drawing.Point(528, 136)
        Me.cmbalmllegada.Name = "cmbalmllegada"
        Me.cmbalmllegada.Size = New System.Drawing.Size(224, 22)
        Me.cmbalmllegada.TabIndex = 42
        Me.cmbalmllegada.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(426, 136)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Almacen Llegada :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Visible = False
        '
        'Button1
        '
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(240, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calmacen
        '
        Me.calmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.calmacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calmacen.Location = New System.Drawing.Point(528, 112)
        Me.calmacen.Name = "calmacen"
        Me.calmacen.Size = New System.Drawing.Size(224, 22)
        Me.calmacen.TabIndex = 36
        Me.calmacen.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(434, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Almacen Salida :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'cbotipopre
        '
        Me.cbotipopre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipopre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipopre.Location = New System.Drawing.Point(118, 136)
        Me.cbotipopre.Name = "cbotipopre"
        Me.cbotipopre.Size = New System.Drawing.Size(292, 22)
        Me.cbotipopre.TabIndex = 33
        Me.cbotipopre.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(44, 136)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Tipo Precio : "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Visible = False
        '
        'cbovendedor
        '
        Me.cbovendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbovendedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovendedor.Location = New System.Drawing.Point(528, 88)
        Me.cbovendedor.Name = "cbovendedor"
        Me.cbovendedor.Size = New System.Drawing.Size(224, 22)
        Me.cbovendedor.TabIndex = 31
        Me.cbovendedor.Visible = False
        '
        'txtnumoc
        '
        Me.txtnumoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnumoc.Location = New System.Drawing.Point(584, 64)
        Me.txtnumoc.MaxLength = 7
        Me.txtnumoc.Name = "txtnumoc"
        Me.txtnumoc.Size = New System.Drawing.Size(135, 21)
        Me.txtnumoc.TabIndex = 30
        Me.txtnumoc.Visible = False
        '
        'cbotipodoc
        '
        Me.cbotipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipodoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipodoc.Location = New System.Drawing.Point(118, 112)
        Me.cbotipodoc.Name = "cbotipodoc"
        Me.cbotipodoc.Size = New System.Drawing.Size(292, 22)
        Me.cbotipodoc.TabIndex = 29
        Me.cbotipodoc.Visible = False
        '
        'BTNCLIENTE
        '
        Me.BTNCLIENTE.ImageIndex = 5
        Me.BTNCLIENTE.ImageList = Me.ImageList1
        Me.BTNCLIENTE.Location = New System.Drawing.Point(240, 40)
        Me.BTNCLIENTE.Name = "BTNCLIENTE"
        Me.BTNCLIENTE.Size = New System.Drawing.Size(32, 23)
        Me.BTNCLIENTE.TabIndex = 28
        Me.BTNCLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNCLIENTE.Visible = False
        '
        'cbotipopago
        '
        Me.cbotipopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipopago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipopago.Location = New System.Drawing.Point(530, 224)
        Me.cbotipopago.Name = "cbotipopago"
        Me.cbotipopago.Size = New System.Drawing.Size(224, 22)
        Me.cbotipopago.TabIndex = 24
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(528, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(91, 21)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(478, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Fecha : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(430, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Num Referencia :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(462, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Vendedor : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Caracteristica :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'txtruc
        '
        Me.txtruc.BackColor = System.Drawing.SystemColors.Window
        Me.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtruc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruc.Location = New System.Drawing.Point(312, 40)
        Me.txtruc.Name = "txtruc"
        Me.txtruc.Size = New System.Drawing.Size(96, 21)
        Me.txtruc.TabIndex = 10
        Me.txtruc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtruc.Visible = False
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(118, 88)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ReadOnly = True
        Me.txtdireccion.Size = New System.Drawing.Size(290, 21)
        Me.txtdireccion.TabIndex = 9
        Me.txtdireccion.Visible = False
        '
        'txtdescliente
        '
        Me.txtdescliente.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtdescliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescliente.Location = New System.Drawing.Point(118, 64)
        Me.txtdescliente.Name = "txtdescliente"
        Me.txtdescliente.ReadOnly = True
        Me.txtdescliente.Size = New System.Drawing.Size(290, 21)
        Me.txtdescliente.TabIndex = 40
        Me.txtdescliente.Visible = False
        '
        'txtcodcliente
        '
        Me.txtcodcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodcliente.Location = New System.Drawing.Point(118, 40)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(122, 21)
        Me.txtcodcliente.TabIndex = 7
        Me.txtcodcliente.Visible = False
        '
        'txtnumeroguia
        '
        Me.txtnumeroguia.Location = New System.Drawing.Point(168, 16)
        Me.txtnumeroguia.MaxLength = 7
        Me.txtnumeroguia.Name = "txtnumeroguia"
        Me.txtnumeroguia.ReadOnly = True
        Me.txtnumeroguia.Size = New System.Drawing.Size(72, 21)
        Me.txtnumeroguia.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(277, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ruc : "
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Forma de Pago : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Direccion : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apell o Rs. :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod Cliente :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro de Guia :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtnumeroguia2
        '
        Me.txtnumeroguia2.Location = New System.Drawing.Point(118, 16)
        Me.txtnumeroguia2.MaxLength = 3
        Me.txtnumeroguia2.Name = "txtnumeroguia2"
        Me.txtnumeroguia2.ReadOnly = True
        Me.txtnumeroguia2.Size = New System.Drawing.Size(40, 21)
        Me.txtnumeroguia2.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(160, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(11, 13)
        Me.Label24.TabIndex = 55
        Me.Label24.Text = "-"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(576, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(11, 13)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "-"
        Me.Label25.Visible = False
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionText = "Registro de Items                                           F2=AYUDA             " & _
            "                  F3=ELIMINAR"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(8, 192)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(800, 192)
        Me.grid1.TabIndex = 12
        Me.grid1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtigv)
        Me.GroupBox4.Controls.Add(Me.txtsubt)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.lblcodmoneda3)
        Me.GroupBox4.Controls.Add(Me.txttot)
        Me.GroupBox4.Controls.Add(Me.LBL2)
        Me.GroupBox4.Controls.Add(Me.LBL3)
        Me.GroupBox4.Controls.Add(Me.LBL1)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 480)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(776, 47)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        '
        'txtigv
        '
        Me.txtigv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtigv.Location = New System.Drawing.Point(368, 16)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.ReadOnly = True
        Me.txtigv.Size = New System.Drawing.Size(111, 21)
        Me.txtigv.TabIndex = 38
        Me.txtigv.Text = "0.00"
        Me.txtigv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsubt
        '
        Me.txtsubt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubt.Location = New System.Drawing.Point(136, 16)
        Me.txtsubt.Name = "txtsubt"
        Me.txtsubt.ReadOnly = True
        Me.txtsubt.Size = New System.Drawing.Size(112, 21)
        Me.txtsubt.TabIndex = 37
        Me.txtsubt.Text = "0.00"
        Me.txtsubt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Sub Total : "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(296, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "I.G.V. "
        '
        'lblcodmoneda3
        '
        Me.lblcodmoneda3.AutoSize = True
        Me.lblcodmoneda3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodmoneda3.Location = New System.Drawing.Point(551, 20)
        Me.lblcodmoneda3.Name = "lblcodmoneda3"
        Me.lblcodmoneda3.Size = New System.Drawing.Size(48, 13)
        Me.lblcodmoneda3.TabIndex = 27
        Me.lblcodmoneda3.Text = "Total  : "
        '
        'txttot
        '
        Me.txttot.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttot.Location = New System.Drawing.Point(632, 16)
        Me.txttot.Name = "txttot"
        Me.txttot.ReadOnly = True
        Me.txttot.Size = New System.Drawing.Size(111, 21)
        Me.txttot.TabIndex = 38
        Me.txttot.Text = "0.00"
        Me.txttot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBL2
        '
        Me.LBL2.AutoSize = True
        Me.LBL2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL2.Location = New System.Drawing.Point(336, 20)
        Me.LBL2.Name = "LBL2"
        Me.LBL2.Size = New System.Drawing.Size(29, 13)
        Me.LBL2.TabIndex = 27
        Me.LBL2.Text = "S/. :"
        '
        'LBL3
        '
        Me.LBL3.AutoSize = True
        Me.LBL3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL3.Location = New System.Drawing.Point(600, 20)
        Me.LBL3.Name = "LBL3"
        Me.LBL3.Size = New System.Drawing.Size(29, 13)
        Me.LBL3.TabIndex = 27
        Me.LBL3.Text = "S/. :"
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL1.Location = New System.Drawing.Point(104, 20)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(29, 13)
        Me.LBL1.TabIndex = 27
        Me.LBL1.Text = "S/. :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rpt1)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.cbTipoPresent)
        Me.GroupBox3.Controls.Add(Me.TxtPesBru)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.TXTLOTE)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.TXTBULTO)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.btnobsitem)
        Me.GroupBox3.Controls.Add(Me.cbounidadventa)
        Me.GroupBox3.Controls.Add(Me.lblunidadventa)
        Me.GroupBox3.Controls.Add(Me.txtprecio)
        Me.GroupBox3.Controls.Add(Me.txtcantidad)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtdesarticulo)
        Me.GroupBox3.Controls.Add(Me.btnarticulo)
        Me.GroupBox3.Controls.Add(Me.txtcodarticulo)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 384)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 96)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(742, 55)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 52
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(10, 42)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 13)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Presentación :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTipoPresent
        '
        Me.cbTipoPresent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPresent.Location = New System.Drawing.Point(88, 40)
        Me.cbTipoPresent.Name = "cbTipoPresent"
        Me.cbTipoPresent.Size = New System.Drawing.Size(184, 21)
        Me.cbTipoPresent.TabIndex = 44
        '
        'TxtPesBru
        '
        Me.TxtPesBru.Enabled = False
        Me.TxtPesBru.Location = New System.Drawing.Point(572, 68)
        Me.TxtPesBru.Name = "TxtPesBru"
        Me.TxtPesBru.Size = New System.Drawing.Size(88, 21)
        Me.TxtPesBru.TabIndex = 43
        Me.TxtPesBru.Text = "0"
        Me.TxtPesBru.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(505, 70)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 13)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "Peso Bruto : "
        '
        'TXTLOTE
        '
        Me.TXTLOTE.Location = New System.Drawing.Point(708, 13)
        Me.TXTLOTE.Name = "TXTLOTE"
        Me.TXTLOTE.Size = New System.Drawing.Size(58, 21)
        Me.TXTLOTE.TabIndex = 41
        Me.TXTLOTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXTLOTE.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(644, 15)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 13)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Nro. Lote :"
        Me.Label23.Visible = False
        '
        'TXTBULTO
        '
        Me.TXTBULTO.Enabled = False
        Me.TXTBULTO.Location = New System.Drawing.Point(88, 68)
        Me.TXTBULTO.Name = "TXTBULTO"
        Me.TXTBULTO.Size = New System.Drawing.Size(88, 21)
        Me.TXTBULTO.TabIndex = 39
        Me.TXTBULTO.Text = "0"
        Me.TXTBULTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(27, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Nro.Bulto :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnobsitem
        '
        Me.btnobsitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnobsitem.ImageIndex = 5
        Me.btnobsitem.ImageList = Me.ImageList1
        Me.btnobsitem.Location = New System.Drawing.Point(605, 40)
        Me.btnobsitem.Name = "btnobsitem"
        Me.btnobsitem.Size = New System.Drawing.Size(145, 24)
        Me.btnobsitem.TabIndex = 37
        Me.btnobsitem.Text = "     &Observaciones  Item"
        '
        'cbounidadventa
        '
        Me.cbounidadventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbounidadventa.Location = New System.Drawing.Point(613, 96)
        Me.cbounidadventa.Name = "cbounidadventa"
        Me.cbounidadventa.Size = New System.Drawing.Size(137, 21)
        Me.cbounidadventa.TabIndex = 28
        '
        'lblunidadventa
        '
        Me.lblunidadventa.AutoSize = True
        Me.lblunidadventa.Location = New System.Drawing.Point(496, 102)
        Me.lblunidadventa.Name = "lblunidadventa"
        Me.lblunidadventa.Size = New System.Drawing.Size(69, 13)
        Me.lblunidadventa.TabIndex = 27
        Me.lblunidadventa.Text = "Peso Bruto : "
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(248, 68)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.ReadOnly = True
        Me.txtprecio.Size = New System.Drawing.Size(88, 21)
        Me.txtprecio.TabIndex = 24
        Me.txtprecio.Text = "0"
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(411, 66)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(88, 21)
        Me.txtcantidad.TabIndex = 23
        Me.txtcantidad.Text = "0"
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(202, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Precio :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(345, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Peso Neto : "
        '
        'txtdesarticulo
        '
        Me.txtdesarticulo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtdesarticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesarticulo.Location = New System.Drawing.Point(212, 13)
        Me.txtdesarticulo.Name = "txtdesarticulo"
        Me.txtdesarticulo.ReadOnly = True
        Me.txtdesarticulo.Size = New System.Drawing.Size(423, 21)
        Me.txtdesarticulo.TabIndex = 14
        '
        'btnarticulo
        '
        Me.btnarticulo.ImageIndex = 5
        Me.btnarticulo.ImageList = Me.ImageList1
        Me.btnarticulo.Location = New System.Drawing.Point(177, 12)
        Me.btnarticulo.Name = "btnarticulo"
        Me.btnarticulo.Size = New System.Drawing.Size(35, 23)
        Me.btnarticulo.TabIndex = 12
        Me.btnarticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcodarticulo
        '
        Me.txtcodarticulo.Location = New System.Drawing.Point(88, 13)
        Me.txtcodarticulo.Name = "txtcodarticulo"
        Me.txtcodarticulo.Size = New System.Drawing.Size(88, 21)
        Me.txtcodarticulo.TabIndex = 7
        Me.txtcodarticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Articulo :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(343, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(57, 13)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Cantidad :"
        '
        'txtigvart
        '
        Me.txtigvart.Location = New System.Drawing.Point(824, 389)
        Me.txtigvart.Name = "txtigvart"
        Me.txtigvart.Size = New System.Drawing.Size(64, 21)
        Me.txtigvart.TabIndex = 48
        Me.txtigvart.Text = "TextBox1"
        Me.txtigvart.Visible = False
        '
        'txtcambio
        '
        Me.txtcambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcambio.HideSelection = False
        Me.txtcambio.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtcambio.Location = New System.Drawing.Point(879, 364)
        Me.txtcambio.Multiline = True
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.ReadOnly = True
        Me.txtcambio.Size = New System.Drawing.Size(48, 20)
        Me.txtcambio.TabIndex = 34
        Me.txtcambio.Text = "0.000"
        Me.txtcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTTIMER
        '
        Me.TXTTIMER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTIMER.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTIMER.HideSelection = False
        Me.TXTTIMER.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TXTTIMER.Location = New System.Drawing.Point(850, 328)
        Me.TXTTIMER.Multiline = True
        Me.TXTTIMER.Name = "TXTTIMER"
        Me.TXTTIMER.ReadOnly = True
        Me.TXTTIMER.Size = New System.Drawing.Size(84, 21)
        Me.TXTTIMER.TabIndex = 23
        Me.TXTTIMER.Text = "12:00:00 AM"
        Me.TXTTIMER.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(839, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "T.C :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 576)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(816, 160)
        Me.DataGrid1.TabIndex = 38
        '
        'LBLIGV
        '
        Me.LBLIGV.Location = New System.Drawing.Point(828, 413)
        Me.LBLIGV.Name = "LBLIGV"
        Me.LBLIGV.Size = New System.Drawing.Size(100, 16)
        Me.LBLIGV.TabIndex = 49
        Me.LBLIGV.Text = "Label25"
        Me.LBLIGV.Visible = False
        '
        'TxtMedida
        '
        Me.TxtMedida.Location = New System.Drawing.Point(824, 504)
        Me.TxtMedida.Name = "TxtMedida"
        Me.TxtMedida.Size = New System.Drawing.Size(112, 21)
        Me.TxtMedida.TabIndex = 50
        Me.TxtMedida.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(840, 432)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(88, 95)
        Me.ListBox1.TabIndex = 51
        '
        'Button3
        '
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 5
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(824, 289)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 23)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "&Consultar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 13
        Me.BTNREPORTE.ImageList = Me.ImageList1
        Me.BTNREPORTE.Location = New System.Drawing.Point(837, 231)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(91, 23)
        Me.BTNREPORTE.TabIndex = 6
        Me.BTNREPORTE.Text = "&Imprimir"
        Me.BTNREPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnobs
        '
        Me.btnobs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnobs.ImageIndex = 5
        Me.btnobs.ImageList = Me.ImageList1
        Me.btnobs.Location = New System.Drawing.Point(824, 260)
        Me.btnobs.Name = "btnobs"
        Me.btnobs.Size = New System.Drawing.Size(110, 23)
        Me.btnobs.TabIndex = 8
        Me.btnobs.Text = "&Observaciones"
        Me.btnobs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMGUIADIRECTA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1114, 536)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BTNREPORTE)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TxtMedida)
        Me.Controls.Add(Me.TXTTIMER)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcambio)
        Me.Controls.Add(Me.txtigvart)
        Me.Controls.Add(Me.LBLIGV)
        Me.Controls.Add(Me.btnobs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMGUIADIRECTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GUIA DIRECTA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    '*************************************************************************************
    'Variables 
    Dim flag1 As Boolean
    Dim FLAG As Integer
    'Dim COJ As New ClsInterface
    Public EstaDocGuiaDir As Boolean
    Public obsGuiaDir, importa, moviant, ASTRNROIMPORTACION As String
    Dim CodArtGuiaDir As String
    Public EstadoDocGuiaDir As String
    Public VarGenSal As Boolean
    Public ConsTipoMed, ADblOp As Integer
    Public ADblCorrela As Double
    Dim PROCESO As Boolean
    Dim tipocodigo As String
    Dim SW As Boolean
    Public moneda As String = CDMONBASE
    'Public CAyuda As New ClsInterface
    Public domp, distp, provp, domd, x, distd, provd, dest, obv, codtransp, desctransp, ructransp, brevete, marca, placa, nrocert, Chofer, Nombre As String, fechatras As Date, DepP As String, DepP2 As String, LicConduc As String
    Public tbldet As New DataTable
    Dim miLetra As Font
    Dim WithEvents PrintDocumento As New PrintDocument
    Dim ABoolValorCombo As Boolean
    Dim ImprimeControl As New PrintPreviewControl
    Dim TblCabGuia As New DataTable
    Dim TblDetGuia As New DataTable
    Dim ABOOLEDITPRECIO As Boolean
    Dim ATblAyuda As New DataTable
    Dim CODGUIATRANSF As String
    Dim CODSALTRANS As String
    Dim TablaComboPresent As New DataTable
    Dim VentaTrans As Boolean
    'Dim Ayuda As New ClsAyuda
    'Dim ObjAyu As New ClsAyuda
    'Dim ClsInter As New ClsInterface
    '*************************************************************************************
    Private Sub FRMGUIADIRECTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CODGUIATRANSF = Trim(CAyuda.ValidaNullSTring(CAyuda.ListarDatos("SP_LIST_CONFIGVTA").Tables(0).Rows(0)(0)).ToString())
            CDGUIAVTA = Trim(CAyuda.ValidaNullSTring(CAyuda.ListarDatos("SP_LIST_CONFIGVTA").Tables(0).Rows(0)(1)).ToString())
            Dim TABLA As DataTable
            TABLA = CAyuda.ListarDatos("SP_LIST_COD_MOV_SAL_ENT").Tables(0)
            CODSALTRANS = TABLA.Rows(0)(1)
            ADblOp = 0
            valoriza = False
            codtransp = 0
            est = True

            fechatras = Now
            Call cargadatos()
            flag1 = True
            tcambio()
            SW = True
            BLOQUEA(False, True)
            BTNGUARDAR.Enabled = False
            BTNELIMINAR.Enabled = False
            'BTNREPORTE.Enabled = False
            cbounidadventa.Visible = False
            lblunidadventa.Visible = False
            cbomoneda.Visible = False
            Call ConfigInventario()
            txtpto.Text = NROPTOVTA.ToString.Trim
            If valoriza = True Then
                FormatGridValor()
            Else
                FormatGrid()
            End If

            VERIFICATIPOPRECIO()
            Button1.Focus()
            cbomoneda.SelectedIndex = 1
            cbomoneda.SelectedIndex = 0
            CargarMoneda()
            ABOOLEDITPRECIO = CAyuda.ListarDatos("NSP_SELECT_BUSCA_EDITA_PRECIO", NROPTOVTA.ToString.Trim, codempresa).Tables(0).Rows(0)(0)
            cargacliente()
            cbomoneda.SelectedValue = CDMONBASE

            'Me.Label16.Text = "Ruc :"
            'Me.calmacen.SelectedValue = CDZONA
            'If Me.calmacen.SelectedValue = Nothing Then
            '    MsgBox("Configure Punto de Venta ", MsgBoxStyle.Exclamation)
            '    Exit Sub
            'End If
        Catch
        End Try



        cmbalmllegada.Visible = False
        BtnTransferencia.Visible = False
        Label19.Visible = False

    End Sub
    Private Sub cargacliente()
        VCodCliente = CAyuda.ListarDatos("sp_verif_clien_varios").Tables(0).Rows(0)(0)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                  ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                'Case Keys.Enter
                '    If grid1.Focus = True Then
                '        Try

                '            CodArtGuiaDir = grid1.Item(grid1.CurrentRowIndex, 1)
                '            txtcodarticulo.Text = grid1.Item(grid1.CurrentRowIndex, 1)
                '            txtcantidad.Text = grid1.Item(grid1.CurrentRowIndex, 4)
                '            conecta("SELECT C.nroitem as iditem,C.CODARTIculo as codigo,a.desarti as descripcion,c.CODMEDIDA  as umedida,C.CANTIDAD,C.TOTEXT as costo,C.TOTBAS as total,C.IGVBAS as igv ,precio,obs FROM TMP_GUIADET C,ARTICULO A WHERE C.CODARTICULO=A.CODARTI AND codarticulo='" & Me.txtcodarticulo.Text & "' AND  c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "' and c.estado=0 and a.estado=0 and C.NROGUIA='" & correl & "' and C.nroitem='" & grid1.Item(grid1.CurrentRowIndex, 0) & "' order by C.NROitem", "pa")
                '            conecta1("select cdmonbase from configsis where cod_empresa='" & codempresa & "'", "mon")
                '            If ds.Tables("mon").Rows.Count > 0 Then

                '                monbas = Trim(ds.Tables("mon").Rows(0)(0))

                '                If Trim(ds.Tables("mon").Rows(0)(0)) = moneda Then

                '                    txtprecio.Text = Trim(ds.Tables("pa").Rows(0)(8))
                '                Else
                '                    txtprecio.Text = Trim(ds.Tables("pa").Rows(0)(8)) * Me.txtcambio.Text
                '                End If
                '            End If


                '            If ds.Tables("pa").Rows.Count > 0 Then
                '                cbounidadventa.Enabled = True
                '                txtcodarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                '                txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(2))
                '                ListBox1.SelectedItem = ds.Tables("pa").Rows(0)("umedida")
                '                cbounidadventa.SelectedIndex = ListBox1.SelectedIndex
                '                txtprecio.Text = Trim(ds.Tables("pa").Rows(0)(8))
                '                igv = Trim(ds.Tables("pa").Rows(0)(7))
                '                obsGuiaDir = Trim(ds.Tables("pa").Rows(0)("obs"))
                '                txtcantidad.Focus()
                '                txtcantidad.SelectAll()
                '                est = False
                '            End If

                '        Catch x As Exception
                '        End Try
                '    End If
            Case Keys.F3
                    If grid1.Focus = True Then
                        Try
                            Dim sql As String
                            Dim PROCESO As Boolean
                            Call elimina_item()

                            Conecta("SELECT NROGUIA,NROITEM FROM TMP_GUIADET WHERE codempresa='" & codempresa & "' and NROGUIA='" & correl & "' order by NROITEM", "paz")
                            If ds.Tables("paz").Rows.Count = 0 Then
                                Exit Function
                            End If


                            If MessageBox.Show("Desea eliminar el Registro Seleccionado", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                sql = "nsp_dele_TMP_guiaDET " & grid1.Item(grid1.CurrentRowIndex, 0) & ",'" & correl & "','" & codempresa & "'"
                                PROCESO = TmpInsertDatos(sql)


                                Conecta("SELECT nroguia,nroitem FROM TMP_guiaDET WHERE codempresa='" & codempresa & "' and nroguia='" & correl & "' order by nroitem", "pa")
                                CONT -= 1
                                For l = 0 To ds.Tables("pa").Rows.Count - 1
                                    TmpInsertDatos("update tmp_guiadet set nroitem=" & Val(l + 1) & " where nroguia='" & Trim(ds.Tables("pa").Rows(l)(0)) & "' and nroitem='" & Trim(ds.Tables("pa").Rows(l)(1)) & "'")
                                Next

                                cargagrilla()
                                est = True
                            End If


                        Catch x As Exception

                        End Try
                    End If
            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TXTTIMER.Text = Date.Now.ToLongTimeString
    End Sub

    Public costoext, igv As Double, medida As String, est As Boolean

    Sub cargadatos()
        Try
            CAyuda.CargarDataCombo(cbomoneda, "nsp_sele_moneda '" & codempresa & "'", "codmon", "dsmoneda")
            CAyuda.CargarDataCombo(cbotipopago, "Nsp_Sel_Tipo_Pago '" & codempresa & "'", "Codigo", "Descripcion")

            CAyuda.CargarDataCombo(calmacen, "Nsp_select_AlmacenPtovta '" & codempresa & "','" & NROPTOVTA.ToString.Trim & "'", "codigo", "descripcion")
            CAyuda.CargarDataCombo(cmbalmllegada, "Nsp_select_Almacen '" & codempresa & "'", "codigo", "descripcion")
            CAyuda.CargarDataCombo(cbotipodoc, "nsp_sel_tipoguia '" & codempresa & "'", "codguia", "desguia")
            CAyuda.CargarDataCombo(cbovendedor, "sp_sele_vendedor '" & codempresa & "','" & NROPTOVTA & "'", "Codigo", "Vendedor")
            'CAyuda.CargarDataCombo(cbotipopre, "NSP_Sele_TipoPre '" & codempresa & "'", "codtipopre", "dstipopre")
            Dim dtcom As New DataTable
            dtcom = CAyuda.ListarDatos("NSP_Sele_TipoPre", codempresa).Tables(0)
            cbotipopre.ValueMember = "codtipopre"
            cbotipopre.DisplayMember = "dstipopre"
            cbotipopre.DataSource = dtcom
            codtipopre = cbotipopre.SelectedValue.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarticulo.Click
        Try
            If txtcodcliente.Text = "" Then
                MessageBox.Show("Selecione un Cliente", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If TIPOVENTA = False Then
                If TXTLOTE.Text = "" And Me.TXTLOTE.Visible = True Then
                    MessageBox.Show("Ingrese Un Numero de Lote", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.TXTLOTE.Focus()
                    Exit Sub
                End If
            End If
            est = True
            '  calmacen.Enabled = Tr

            Dim frmx As New FRMARTICULOGUIA
            frmx.Guia = Me
            'frmx.AFrmGuiaDir = Me
            frmx.txtdato.Focus()
            frmx.ShowDialog()
            txtcodarticulo.Text = VCodArti
            Prod_Presentacion()
            VERIFICAARTICULO()
            txtcantidad.Focus()
        Catch
        End Try
    End Sub
    Private Sub Prod_Presentacion()
        Dim TabArt As New DataTable

        TabArt = TmpListarDatos("SELECT  CODARTI,DESARTI FROM ARTICULO  WHERE CODEMPRESA='" & codempresa & "'  AND CODARTI='" & VCodArti.Trim & "'")
        txtdesarticulo.Text = TabArt.Rows(0)("DESARTI")
        TablaComboPresent = CAyuda.ListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT", codempresa, VCodArti.Trim, cbotipopre.SelectedValue.ToString).Tables(0)
        cbTipoPresent.DataSource = TablaComboPresent
        cbTipoPresent.DisplayMember = "DESPRES"
        cbTipoPresent.ValueMember = "CODPRES"
        VentaTrans = True

        Dim Sender As Object = Nothing
        Dim e As EventArgs = Nothing
        cbTipoPresent_SelectedIndexChanged(Sender, e)
    End Sub
    Private Sub VERIFICAARTICULO()
        'Dim ClsInter As New ClsInterface
        If VCodArti <> "" Then
            txtcodarticulo.Text = VCodArti
        End If
        'ds = CAyuda.ListarDatos("NSP_ARTICULOPRECIOFAC_ARTICULO '" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & cbTipoPresent.SelectedValue & "'")
        'If ds.Tables(0).Rows.Count <= 0 Then
        '    MessageBox.Show("Articulo No existe Verifique", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txtcodarticulo.Text = ""
        '    VCodArti = ""
        '    Exit Sub
        'Else
            If CDMONBASE.Trim = FACT_CDMONEDA.Trim Then
                If FACT_CODMONARTI.Trim = CDMONBASE.Trim Then
                    txtprecio.Text = VPrecioVta
                Else
                    txtprecio.Text = VPrecioVta * txtcambio.Text
                End If
            Else
                If FACT_CODMONARTI.Trim = CDMONBASE.Trim Then
                    txtprecio.Text = VPrecioVta / txtcambio.Text
                Else
                    txtprecio.Text = VPrecioVta
                End If
            End If

            txtdesarticulo.Text = ds.Tables(0).Rows(0)(1)
            If VCodArti.Trim = "" Then
                VCodArti = Me.txtcodarticulo.Text.Trim
                Me.TxtMedida.Text = CAyuda.ListarDatos("USP_BUSCAR_CODIGO_MEDIDA", VCodArti, codempresa.Trim).Tables(0).Rows(0).Item("CODUMED")
            End If
            txtigvart.Text = CAyuda.ValidaNullsInteger(CAyuda.ListarDatos("SP_LISTAR_IGV_X_ARTICUCO", VCodArti, codempresa).Tables(0).Rows(0)(0))
            TXTBULTO.Focus()
            VCodArti = ""
        'End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCLIENTE.Click
        Dim frmx As New frm_gridclie
        frmx.AFrmGuiaDir = Me
        frmx.ShowDialog()
        txtcodcliente.Focus()
        'CAyuda.CargarDataCombo(cbovendedor, "Nsp_SELECT_VENDEDORXCLIENTE '" & codempresa & "','" & txtcodcliente.Text & "','" & PtoVta & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(cbovendedor, "sp_sele_vendedor '" & codempresa & "','" & NROPTOVTA & "'", "Codigo", "Vendedor")
        '*********************************************************************************
        Dim TblVendedor As New DataTable
        TblVendedor = CAyuda.ListarDatos("USP_CLIENTE_VENDEDOR   ", txtcodcliente.Text, codempresa, NROPTOVTA.ToString.Trim).Tables(0)
        If TblVendedor.Rows.Count > 0 Then
            Dim xCodVen As String
            xCodVen = Trim(TblVendedor.Rows(0).Item("CODVEND").ToString())
            Me.cbovendedor.SelectedValue = xCodVen

        End If
        TblVendedor = Nothing
        '*********************************************************************************
        valclientevarios()
    End Sub
    Private Sub valclientevarios()
        If VCodCliente = txtcodcliente.Text Then
            txtdescliente.Text = ""
            txtdireccion.Text = ""
            txtdescliente.ReadOnly = False
            txtdireccion.ReadOnly = False
            txtruc.ReadOnly = False
            txtruc.Focus()
        End If
    End Sub
    Sub bloqueacombos()
        cbotipodoc.Enabled = False
        cbotipopre.Enabled = False
        '  cbovendedor.Enabled = False
        cbotipopago.Enabled = False
    End Sub
    Sub desbloqueacombos()
        cbotipodoc.Enabled = True
        cbotipopre.Enabled = True
        ' cbovendedor.Enabled = True
        cbotipopago.Enabled = True
    End Sub
    Sub tcambio()
        Conecta("select tventa from cambio where fecha='" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yy") & "' and codempresa='" & codempresa & "'", "tcambio")
        If ds.Tables("tcambio").Rows.Count = 0 Then
            Conecta("select tventa from cambio where codempresa='" & codempresa & "' order by fecha", "tcambio2")
            If ds.Tables("tcambio2").Rows.Count > 0 Then
                Me.txtcambio.Text = ds.Tables("tcambio2").Rows(0)(0)
            End If
        Else
            Me.txtcambio.Text = ds.Tables("tcambio").Rows(0)(0)
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        tcambio()
    End Sub
    'Dim Inter As New ClsInterface
    Public Sub llenacliente()
        Conecta("select codcliente,paterno,materno,nombres,razonsocial,ruc,direccion,dni from cliente where (codempresa='" & codempresa & "' and estado=0 and codcliente='" & Me.txtcodcliente.Text & "') ", "pa")


        If ds.Tables("pa").Rows.Count > 0 Then
            Dim RucGuia As String
            RucGuia = ""
            RucGuia = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0).Item("ruc"))

            If Trim(ds.Tables("pa").Rows(0)(4)) = "" Then
                txtdescliente.Text = Trim(ds.Tables("pa").Rows(0)(1)) + " " + Trim(ds.Tables("pa").Rows(0)(2)) + ", " + Trim(ds.Tables("pa").Rows(0)(3))
            Else
                txtdescliente.Text = Trim(ds.Tables("pa").Rows(0)(4))
            End If

            If Len(RucGuia.Trim) = 0 Then
                Me.txtruc.Text = Trim(ds.Tables("pa").Rows(0)("dni"))
                Me.Label6.Text = "Dni :"
            Else
                Me.txtruc.Text = Trim(ds.Tables("pa").Rows(0)(5))
                Me.Label6.Text = "Ruc :"
            End If
            txtdireccion.Text = Trim(ds.Tables("pa").Rows(0)(6))
            'CAyuda.CargarDataCombo(cbovendedor, "Nsp_SELECT_VENDEDORXCLIENTE '" & codempresa & "','" & txtcodcliente.Text & "','" & PtoVta & "'", "Codigo", "Descripcion")
            CAyuda.CargarDataCombo(cbovendedor, "sp_sele_vendedor '" & codempresa & "','" & NROPTOVTA & "'", "Codigo", "Vendedor")
            '*********************************************************************************
            Dim TblVendedor As New DataTable
            TblVendedor = CAyuda.ListarDatos("USP_CLIENTE_VENDEDOR   ", txtcodcliente.Text, codempresa, NROPTOVTA.ToString.Trim).Tables(0)
            If TblVendedor.Rows.Count > 0 Then
                Dim xCodVen As String
                xCodVen = Trim(TblVendedor.Rows(0).Item("CODVEND").ToString())
                Me.cbovendedor.SelectedValue = xCodVen

            End If
            TblVendedor = Nothing
            '*********************************************************************************
            cbotipodoc.Focus()
        Else
            MessageBox.Show("Cliente no Encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtdescliente.Text = ""
            txtruc.Text = ""
            txtdireccion.Text = ""
            txtcodcliente.Focus()
            txtcodcliente.SelectAll()
            Exit Sub
        End If
    End Sub
    Private Sub txtcodcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodcliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llenacliente()
            valclientevarios()
            Me.BtnTransferencia.Visible = True
        End If
    End Sub

    Dim CONT As Integer = 0
    Public monval As Boolean
    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Not IsNumeric(txtcantidad.Text) Then
            TxtPesBru.Text = "0.00"
            MsgBox("No se admiten puntos(.) antes del número", MsgBoxStyle.Exclamation)
            TxtPesBru.Focus()
            Exit Sub
        End If
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            Me.txtcantidad.Focus()
        End If
    End Sub

    Sub cargagrilla()
        Dim ATBlTotal As New DataTable
        Try
            tbldet.Clear()
            If valoriza = False Then
                If monval = True Then
                    Conecta("SELECT C.nroitem as iditem,C.CODARTIculo as codigo,a.desarti as descripcion,c.CODMEDIDA as umedida,C.CANTIDAD,TIPOMEDIDA,NROLOTE,BULTO,PESOBRUTO FROM TMP_GUIADET C,ARTICULO A WHERE C.CODARTICULO = A.CODARTI AND c.codempresa = '" & codempresa & "' and a.codempresa='" & codempresa & "'  and a.estado = 0 and C.NROGUIA = " & correl & " order by C.NROITEM", "pa")
                Else
                    Conecta("SELECT C.nroitem as iditem,C.CODARTIculo as codigo,a.desarti as descripcion,c.CODMEDIDA as umedida,C.CANTIDAD,TIPOMEDIDA,NROLOTE,BULTO,PESOBRUTO FROM TMP_GUIADET C,ARTICULO A WHERE C.CODARTICULO = A.CODARTI AND c.codempresa = '" & codempresa & "' and a.codempresa='" & codempresa & "'  and a.estado = 0 and C.NROGUIA = " & correl & " order by c.NROITEM", "pa")
                End If

                'oda.Fill(ds)

                tbldet = ds.Tables(0)

                Me.grid1.DataSource = tbldet
                Me.grid1.Refresh()

                Me.txttot.Text = "0.00"
                Me.txtigv.Text = "0.00"
                Me.txtsubt.Text = "0.00"

            Else
                If monval = True Then
                    Conecta("SELECT C.nroitem as iditem,C.CODARTIculo as codigo,a.desarti as descripcion,c.CODMEDIDA  as umedida,C.CANTIDAD,C.precio as Precio,C.TOTBAS,C.IGVBAS ,C.SUBTBAS as total,TIPOMEDIDA,NROLOTE,BULTO,PESOBRUTO FROM TMP_GUIADET C,ARTICULO A WHERE C.CODARTICULO=A.CODARTI AND  c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "'  and a.estado=0 and C.NROGUIA=" & correl & " order by C.NROitem", "pa")
                Else
                    Conecta("SELECT C.nroitem as iditem,C.CODARTIculo as codigo,a.desarti as descripcion,c.CODMEDIDA as umedida,C.CANTIDAD,C.precio as Precio,C.TOTEXT,C.IGBEXT,C.SUBTEXT as total,TIPOMEDIDA ,NROLOTE,BULTO,PESOBRUTO FROM TMP_GUIADET C,ARTICULO A WHERE C.CODARTICULO=A.CODARTI  AND c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "'   and a.estado=0 and C.NROGUIA=" & correl & " order by c.NROITEM", "pa")
                End If
                'oda.Fill(tbldet)
                tbldet = ds.Tables(0)
                Me.grid1.DataSource = tbldet

                If monval = True Then
                    Conecta("SELECT C.nroitem as iditem,C.CODARTIculo as codigo,a.desarti as descripcion,c.CODMEDIDA  as umedida,C.CANTIDAD,C.precio as Precio,C.TOTBAS,C.IGVBAS ,C.SUBTBAS as total,TIPOMEDIDA,NROLOTE,BULTO,PESOBRUTO FROM TMP_GUIADET C,ARTICULO A WHERE C.CODARTICULO=A.CODARTI AND  c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "'  and a.estado=0 and C.NROGUIA=" & correl & " order by C.NROitem", "pa")
                Else
                    Conecta("SELECT C.nroitem as iditem,C.CODARTIculo as codigo,a.desarti as descripcion,c.CODMEDIDA as umedida,C.CANTIDAD,C.precio as Precio,C.TOTEXT,C.IGBEXT,C.SUBTEXT as total,TIPOMEDIDA ,NROLOTE,BULTO,PESOBRUTO FROM TMP_GUIADET C,ARTICULO A WHERE C.CODARTICULO=A.CODARTI  AND c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "'   and a.estado=0 and C.NROGUIA=" & correl & " order by c.NROITEM", "pa")
                End If

                'oda.Fill(ATBlTotal)
                ATBlTotal = ds.Tables(0)

                Dim a1, a2 As Double
                Dim I As New Integer
                CONT = ATBlTotal.Rows.Count
                For I = 0 To ATBlTotal.Rows.Count - 1
                    ' MsgBox(Val(tbldet.Rows(I)(6)))
                    a1 += Val(ATBlTotal.Rows(I)(6))
                    a2 += Val(ATBlTotal.Rows(I)(7))
                Next

                Me.txttot.Text = a1.ToString("###0.00")
                Me.txtigv.Text = a2.ToString("###0.00")
                Me.txtsubt.Text = Val(a1 - a2).ToString("###0.00")

            End If

            txtcodarticulo.Text = ""
            txtdesarticulo.Text = ""
            TXTBULTO.Text = ""
            txtcantidad.Text = 0
            txtprecio.Text = 0
            Me.TxtMedida.Text = ""

        Catch X As Exception
            MsgBox(X.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    'Dim monbas As String
    Private Sub txtcodarticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodarticulo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                If Trim(txtcodarticulo.Text) = "" Then
                    MessageBox.Show("Ingrese el Codigo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtcodarticulo.Focus()
                    Exit Sub
                Else
                    VERIFICAARTICULO()
                End If

                'Dim MIDS As New DataSet
                'MIDS = QUERY("CONFIGGRID '" & nroptovta & "','" & codempresa & "'")
                'CONFIGGRID = MIDS.Tables(0).Rows(0)(0)

                'cbounidadventa.Items.Clear()
                'ListBox1.Items.Clear()
                'conecta("select valorizado,TIPOVENTA from tipo_guia where codguia='" & cbotipodoc.SelectedValue.ToString & "' and codempresa='" & codempresa & "' and estado=0", "VTA")
                'If ds.Tables("vta").Rows.Count > 0 Then
                '    If ds.Tables("VTA").Rows(0)(1) = True Then
                '        ds = QUERY("NSP_ARTICULOPRECIOGUIA_ARTICULO'" & txtcodarticulo.Text & "','" & nroptovta & "','" & codempresa & "','" & cbotipopre.SelectedValue & "'")
                '    Else
                '        ds = QUERY("NSP_ARTICULOCOSTOFAC_ARTICULO '" & txtcodarticulo.Text & "','" & nroptovta & "','" & codempresa & "','" & calmacen.SelectedValue & "'")
                '    End If
                'Else
                '    MessageBox.Show("No existen registros encontrados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    txtcodarticulo.Focus()
                '    Exit Sub
                'End If
                'If ds.Tables(0).Rows.Count > 0 Then
                '    If CONFIGGRID = "01" Then
                '        txtcodarticulo.Text = ds.Tables(0).Rows(0)(0)
                '        txtdesarticulo.Text = ds.Tables(0).Rows(0)(1)
                '        cbounidadventa.Items.Add(ds.Tables(0).Rows(0)(2))
                '        ListBox1.Items.Add(ds.Tables(0).Rows(0)(6))
                '        txtprecio.Text = ds.Tables(0).Rows(0)(3)
                '        txtigvart.Text = ds.Tables(0).Rows(0)("IGV")
                '        ListBox1.SelectedIndex = 0
                '        cbounidadventa.SelectedIndex = ListBox1.SelectedIndex
                '        ConsTipoMed = 1
                '        cbounidadventa.Visible = False
                '        lblunidadventa.Visible = False
                '        cbounidadventa.Enabled = False
                '        ListBox1.Enabled = False


                '    End If
                '    If CONFIGGRID = "10" Then
                '        txtcodarticulo.Text = ds.Tables(0).Rows(0)(0)
                '        txtdesarticulo.Text = ds.Tables(0).Rows(0)(1)
                '        cbounidadventa.Items.Add(ds.Tables(0).Rows(0)(2))
                '        ListBox1.Items.Add(ds.Tables(0).Rows(0)(6))
                '        txtprecio.Text = ds.Tables(0).Rows(0)(4)
                '        txtigvart.Text = ds.Tables(0).Rows(0)("IGV")
                '        ListBox1.SelectedIndex = 0
                '        cbounidadventa.SelectedIndex = ListBox1.SelectedIndex
                '        ConsTipoMed = 0
                '        cbounidadventa.Visible = False
                '        lblunidadventa.Visible = False
                '        cbounidadventa.Enabled = False
                '        ListBox1.Enabled = False
                '    End If

                '    If CONFIGGRID = "11" Then

                '        txtcodarticulo.Text = ds.Tables(0).Rows(0)(0)
                '        txtdesarticulo.Text = ds.Tables(0).Rows(0)(1)
                '        cbounidadventa.Items.Add(ds.Tables(0).Rows(0)(2))
                '        ListBox1.Items.Add(ds.Tables(0).Rows(0)(7))
                '        cbounidadventa.Items.Add(ds.Tables(0).Rows(0)(4))
                '        ListBox1.Items.Add(ds.Tables(0).Rows(0)(8))
                '        txtprecio.Text = ds.Tables(0).Rows(0)(3)
                '        txtigvart.Text = ds.Tables(0).Rows(0)("IGV")
                '        ListBox1.SelectedItem = ds.Tables(0).Rows(0)(2)
                '        ListBox1.SelectedIndex = 0
                '        ConsTipoMed = IIf(ListBox1.SelectedIndex = 0, 0, 1)
                '        cbounidadventa.SelectedIndex = ListBox1.SelectedIndex
                '        cbounidadventa.Visible = True
                '        lblunidadventa.Visible = True
                '        cbounidadventa.Enabled = True
                '        ListBox1.Enabled = False

                '    End If
                '    cbounidadventa.Enabled = True
                '    txtcantidad.Focus()
                '    txtcantidad.SelectAll()
                'Else
                '    MessageBox.Show("No existen registros encontrados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    txtcodarticulo.Focus()
                '    Exit Sub
                'End If
            Catch x As Exception
                MessageBox.Show(x.Message)
            End Try

        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        txtnumeroguia.Enabled = True
        HABILITARCONTROLES()
        CONT = 0
        BTNNUEVO.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNREPORTE.Enabled = False
        txtnumoc.ReadOnly = False

        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub

        TmpInsertDatos("DELETE FROM TMP_GUIADET WHERE CODEMPRESA='" & codempresa & "' AND NROGUIA=" & txtnumeroguia2.Text + txtnumeroguia.Text & "")

        If FLAG = 0 Then
            Call limpia()
            txtsubt.Text = "0.00"
            txtigv.Text = "0.00"
            txttot.Text = "0.00"
            Call BOTONES(True, False, False, False)
            btnobs.Enabled = False
            BLOQUEA(False, True)
        Else
            Call BOTONES(True, False, True, True)
            BTNELIMINAR.Enabled = True
        End If

        'Call bloqueatextbox(Me)
        btnarticulo.Enabled = False
        txtnumeroguia.Text = ""
        txtnumeroguia2.Text = ""
        cargagrilla()
        Me.grid1.Refresh()
        BTNCANCELAR.Enabled = False
        tbldet.Clear()
        txtprecio.ReadOnly = True
        Me.Label6.Text = "Ruc :"
        Me.BtnTransferencia.Enabled = False
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNELIMINAR.Enabled = ELIMINAR

    End Sub

    Dim l As Integer, items As Boolean = True
    Public correl As String = "0"
    Public INICIA As Int16 = 0
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        PROCESO1 = "Nuevo"
        'BTNREPORTE.Enabled = False
        valoriza_tipo()
        If TIPOVENTA = False Then
            cbotipopre.Visible = False
            Label18.Visible = False
        Else
            cbotipopre.Visible = True
            Label18.Visible = True
        End If
        If VarGenSal = False Then
            cmbalmllegada.Visible = False
            Label19.Visible = False
        Else
            cmbalmllegada.Visible = True
            Label19.Visible = True
        End If
        Conecta("select codmon from tipopre where codtipopre='" & Me.cbotipopre.SelectedValue.ToString & "' and codempresa='" & codempresa & "' and estado=0", "id")
        If ds.Tables("id").Rows.Count > 0 Then
            moneda = Trim(ds.Tables("id").Rows(0)(0))
        End If
        HABILITARCONTROLES()
        txtcodcliente.ReadOnly = False
        txtcodcliente.Focus()
        tbldet.Clear()
        INICIA = 1
        CONT = 0

        BLOQUEA(True, False)


        limpia()
        txtnumeroguia.Text = CAyuda.ListarDatos("OBTIENE_CORRELATIVO_GUIA_PROC", NROPTOVTA).Tables(0).Rows(0)(0)
        txtnumeroguia2.Text = Strings.Left(Strings.Right("000" + txtnumeroguia.Text, 10), 3)
        txtnumeroguia.Text = Strings.Right("000" + txtnumeroguia.Text, 7)
        txtnumeroguia.Enabled = False
        txtnumeroguia2.Enabled = False
        'Dim sql As String
        'Dim i As Integer
        'While (i = 0)
        '    If CAyuda.ListarDatos("sp_verif_num_guia", txtnumeroguia2.Text + txtnumeroguia.Text).Tables(0).Rows.Count > 0 Then
        '        sql = "sp_modificar_correlativo '" & NROPTOVTA & "'"
        '        TmpInsertDatos(sql)
        '        txtnumeroguia.Text = CAyuda.ListarDatos("OBTIENE_CORRELATIVO_GUIA_PROC", NROPTOVTA).Tables(0).Rows(0)(0)
        '        txtnumeroguia2.Text = Strings.Left(Strings.Right("000" + txtnumeroguia.Text, 10), 3)
        '        txtnumeroguia.Text = Strings.Right("000" + txtnumeroguia.Text, 7)

        '    Else
        '        i = 1
        '    End If
        'End While


        Conecta("select correlguia from tmp_correlguia where codempresa='" & codempresa & "' AND TIPO='GUIA'", "correl")
        If ds.Tables("correl").Rows.Count = 0 Then
            correl = 1
            TmpInsertDatos("insert into tmp_correlguia values('" & correl & "','" & codempresa & "','GUIA')")
        Else
            correl = Val(ds.Tables("correl").Rows(ds.Tables("correl").Rows.Count - 1)(0) + 1)
            TmpInsertDatos("update tmp_correlguia set correlguia='" & correl & "' where codempresa='" & codempresa & "' AND TIPO='GUIA'")
        End If

        'Me.DsInventInicial1.Clear()
        Me.grid1.Refresh()
        ADblCorrela = CAyuda.ListarDatos("ObtenerCorrelativoProcUtil", CodUsuario).Tables(0).Rows(0)(0)
        If ABOOLEDITPRECIO Then
            txtprecio.ReadOnly = False
        Else
            txtprecio.ReadOnly = True
        End If
        Me.Label6.Text = "Ruc :"
        Me.BtnTransferencia.Enabled = True

        txtOrdenDesp.Text = ""





        cmbalmllegada.Visible = False
        BtnTransferencia.Visible = False
        Label19.Visible = False




    End Sub

    Sub limpia()
        'limpiatextbox(Me)
        Me.txtnumeroguia2.Text = ""
        Me.txtnumeroguia.Text = ""
        Me.txtcodcliente.Text = ""
        Me.txtruc.Text = ""
        Me.txtdescliente.Text = ""
        Me.txtdireccion.Text = ""
        Me.txtnumoc.Text = ""
        Me.txtnumoc1.Text = ""
        Me.txtcodarticulo.Text = ""
        Me.TXTLOTE.Text = ""
        Me.txtdesarticulo.Text = ""
        'Me.tumedida.Text = ""
        Me.txtcantidad.Text = "0"
        Me.txtprecio.Text = "0"
        Me.TXTBULTO.Text = "0"
        Me.txtsubt.Text = "0.00"
        Me.txtigv.Text = "0.00"
        Me.txttot.Text = "0.00"
        'Me.DsInventInicial1.Clear()
        Me.grid1.Refresh()
        Me.txtcodcliente.Focus()
        Me.txtboleta.Text = ""


        domp = ""
        distp = ""
        provp = ""
        domd = ""
        distd = ""
        provd = ""
        dest = ""
        obv = ""
        codtransp = ""
        desctransp = ""
        ructransp = ""
        brevete = ""
        marca = ""
        placa = ""
        nrocert = ""
        fechatras = Now

    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DateTimePicker1.Value.Year
        MES = DateTimePicker1.Value.Month

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

        Dim SQL As String
        Dim PROCESO As Boolean
        Call formatotextbox(Me)

        'If tbldet.Rows.Count <> 0 Then

        If txtnumeroguia.Text = "" Or txtnumeroguia2.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If codtransp.Trim = "" Then
            MsgBox("Ingrese el Transaportista Por Favor para La Guia Directa" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            'codtransp = "05"
            Exit Sub
        End If

        If Chofer.Trim = "" Then
            MsgBox("Ingrese el Chofer Por Favor para La Guia Directa" + Chr(13) + "Gracias ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Exit Sub
        End If
        If domd.Trim = "" Then
            'MessageBox.Show("Ingrese el Domicilio de Destino", Desempresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
        End If

        'If txtnumoc.Text.Trim = "" Or txtnumoc1.Text = "" Then
        '    MessageBox.Show("Ingrese el Nro DE Referencia", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If

        If ABoolValorCombo = False Then
            If txtboleta.Text = "" Then
                MessageBox.Show("Ingrese la Boleta Pesada", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Else
        End If

        If CAyuda.ListarDatos("sp_verif_num_guia", txtnumeroguia2.Text + txtnumeroguia.Text).Tables(0).Rows.Count > 0 Then
            MsgBox("El Numero de guia ya existe Verifique", MsgBoxStyle.Information)
            Exit Sub
        End If


        '  NroGuiaDir = txtnumeroguia2.Text + txtnumeroguia.Text.Trim


        If CheckBox1.Checked = False Then
            NroGuiaDir = CAyuda.ListarDatos("OBTIENE_CORRELATIVO_GUIA_PROC", NROPTOVTA.ToString.Trim).Tables(0).Rows(0)(0)
        Else
            tipocodigo = "manual"
            NroGuiaDir = txtnumeroguia2.Text + txtnumeroguia.Text.Trim
        End If

        If txtOrdenDesp.Text.Trim = "" Then
            MsgBox("Ingrese un numero de despacho", MsgBoxStyle.Information)
            txtOrdenDesp.Focus()
            Exit Sub
        End If


        Dim Y As Integer
        If rbDespacho.Checked = True Then
            Y = 1
        Else
            Y = 0
        End If


        SQL = "NSP_ins_guiacab '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "dd/MM/yyyy") & "'," & Val(Me.txttot.Text * Me.txtcambio.Text).ToString("###0.00") & "," & Val(Me.txttot.Text).ToString("###0.00") & "," & Val(Me.txtigv.Text * Me.txtcambio.Text).ToString("###0.00") & "," & Val(Me.txtigv.Text).ToString("###0.00") & "," & Val(Me.txtsubt.Text * Me.txtcambio.Text).ToString("###0.00") & "," & Val(Me.txtsubt.Text).ToString("###0.00") & ",'" & txtnumoc1.Text & "-" & txtnumoc.Text & "','','" & NroGuiaDir & "',0,'" & codtransp & "','" & cbotipopago.SelectedValue.ToString & "','" & nrocert & "','" & ructransp & "','" & marca & "','" & Format(Microsoft.VisualBasic.DateValue(fechatras), "dd/MM/yyyy") & "','" & obv & "','" & placa & "','" & brevete & "','" & dest & "','" & domd & "','" & domp & "','" & Chofer & "','" & Format(Microsoft.VisualBasic.DateValue(fechatras), "dd/MM/yyyy") & "'," & Me.txtcambio.Text & ",'" & moneda & "','" & Me.cbotipopre.SelectedValue.ToString & "','" & "" & "','" & CodUsuario & "','" & Me.txtcodcliente.Text & "','" & Me.cbotipopago.SelectedValue.ToString & "','" & Me.calmacen.SelectedValue.ToString & "','" & codempresa & "','" & Me.distp & "','" & Me.provp & "','" & Me.distd & "','" & Me.provd & "','" & Me.cbotipodoc.SelectedValue.ToString & "','" & NROPTOVTA.ToString.Trim & "','" & cmbalmllegada.SelectedValue.ToString() & "','" & "PENDIENTE" & "','" & txtboleta.Text & "','" & importa & "','" & 0 & "','" & moviant & "'," & ADblOp & ",'" & txtnumoc1.Text & "-" & txtnumoc.Text & "','" & tipocodigo & "','" & x & "','" & txtdescliente.Text.Trim & "','" & txtdireccion.Text.Trim & "','" & txtOrdenDesp.Text & "','" & DepP & "','" & DepP2 & "','" & LicConduc & "'," & Y
        PROCESO = TmpInsertDatos(SQL)

        If MessageBox.Show("¿ Desea Imprimir el Documento ?", "Informacion", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            If rbDespacho.Checked = True Then
                imprimir_Despacho()
            End If


            If rbTraslado.Checked = True Then
                imprimir_traslado()
            End If

        End If


        '/*******************************************************************************************/



        'If FLAG = 0 Then

        '    Dim NroVueltas As Integer
        '    Dim inicio As Integer

        '    NroVueltas = Format(Math.Ceiling(tbldet.Rows.Count / ITEMDEGUIA), "00.0")

        '    For inicio = 1 To NroVueltas
        '        If CheckBox1.Checked = False Then
        '            NroGuiaDir = CAyuda.ListarDatos("OBTIENE_CORRELATIVO_GUIA_PROC", NROPTOVTA.ToString.Trim).Tables(0).Rows(0)(0)
        '        Else
        '            tipocodigo = "manual"
        '            NroGuiaDir = txtnumeroguia2.Text + txtnumeroguia.Text.Trim
        '        End If
        '        Dim vendedor As String
        '        If cbovendedor.Items.Count > 0 Then
        '            vendedor = cbovendedor.SelectedValue
        '        Else
        '            vendedor = "s/v"
        '        End If
        '        If monval = True Then
        '            SQL = "NSP_ins_guiacab '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "'," & Val(Me.txttot.Text * Me.txtcambio.Text).ToString("###0.00") & "," & Val(Me.txttot.Text).ToString("###0.00") & "," & Val(Me.txtigv.Text * Me.txtcambio.Text).ToString("###0.00") & "," & Val(Me.txtigv.Text).ToString("###0.00") & "," & Val(Me.txtsubt.Text * Me.txtcambio.Text).ToString("###0.00") & "," & Val(Me.txtsubt.Text).ToString("###0.00") & ",'" & txtnumoc1.Text & "-" & txtnumoc.Text & "','','" & NroGuiaDir & "',0,'" & codtransp & "','" & cbotipopago.SelectedValue.ToString & "','" & nrocert & "','" & ructransp & "','" & marca & "','" & Format(Microsoft.VisualBasic.DateValue(fechatras), "dd/MM/yy") & "','" & obv & "','" & placa & "','" & brevete & "','" & dest & "','" & domd & "','" & domp & "','" & desctransp & "','" & Format(Microsoft.VisualBasic.DateValue(fechatras), "MM/dd/yy") & "'," & Me.txtcambio.Text & ",'" & moneda & "','" & Me.cbotipopre.SelectedValue.ToString & "','" & vendedor & "','" & CodUsuario & "','" & Me.txtcodcliente.Text & "','" & Me.cbotipopago.SelectedValue.ToString & "','" & Me.calmacen.SelectedValue.ToString & "','" & codempresa & "','" & Me.distp & "','" & Me.provp & "','" & Me.distd & "','" & Me.provd & "','" & Me.cbotipodoc.SelectedValue.ToString & "','" & NROPTOVTA.ToString.Trim & "','" & cmbalmllegada.SelectedValue.ToString() & "','" & "PENDIENTE" & "','" & txtboleta.Text & "','" & importa & "','" & 0 & "','" & moviant & "'," & ADblOp & ",'" & txtnumoc1.Text & "-" & txtnumoc.Text & "','" & tipocodigo & "','" & txtruc.Text.Trim & "','" & txtdescliente.Text.Trim & "','" & txtdireccion.Text.Trim & "'," & NroMovi & ""
        '        Else
        '            SQL = "NSP_ins_guiacab '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "'," & Val(Me.txttot.Text).ToString("###0.00") & "," & Val(Me.txttot.Text / Me.txtcambio.Text).ToString("###0.00") & "," & Val(Me.txtigv.Text).ToString("###0.00") & "," & Val(Me.txtigv.Text / Me.txtcambio.Text).ToString("###0.00") & "," & Val(Me.txtsubt.Text).ToString("###0.00") & "," & Val(Me.txtsubt.Text / Me.txtcambio.Text).ToString("###0.00") & ",'" & txtnumoc1.Text & "-" & txtnumoc.Text & "','','" & NroGuiaDir & "',0,'" & codtransp & "','" & cbotipopago.SelectedValue.ToString & "','" & nrocert & "','" & ructransp & "','" & marca & "','" & Format(Microsoft.VisualBasic.DateValue(fechatras), "dd/MM/yy") & "','" & obv & "','" & placa & "','" & brevete & "','" & dest & "','" & domd & "','" & domp & "','" & desctransp & "','" & Format(Microsoft.VisualBasic.DateValue(fechatras), "MM/dd/yy") & "'," & Me.txtcambio.Text & ",'" & moneda & "','" & Me.cbotipopre.SelectedValue.ToString & "','" & Me.cbovendedor.SelectedValue.ToString & "','" & CodUsuario & "','" & Me.txtcodcliente.Text & "','" & Me.cbotipopago.SelectedValue.ToString & "','" & Me.calmacen.SelectedValue.ToString & "','" & codempresa & "','" & Me.distp & "','" & Me.provp & "','" & Me.distd & "','" & Me.provd & "','" & Me.cbotipodoc.SelectedValue.ToString & "','" & NROPTOVTA.ToString.Trim & "','" & cmbalmllegada.SelectedValue.ToString() & "','" & "PENDIENTE" & "','" & txtboleta.Text & "','" & importa & "','" & 0 & "','" & moviant & "'," & ADblOp & ",'" & txtnumoc1.Text & "-" & txtnumoc.Text & "','" & tipocodigo & "','" & txtruc.Text.Trim & "','" & txtdescliente.Text.Trim & "','" & txtdireccion.Text.Trim & "'," & NroMovi & ""
        '        End If

        '        PROCESO = TmpInsertDatos(SQL)

        '        If PROCESO = False Then
        '            MessageBox.Show("Error Durante El Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Exit Sub
        '        Else
        '            cbomoneda.Enabled = True
        '            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtnumeroguia2.Text + "-" + txtnumeroguia.Text & "','INSERT','GUIADIRECTA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")

        '        End If
        '        If TIPOVENTA = True Then
        '            CAyuda.Ejecutar("NSP_INS_SALDOS", ADblCorrela, CInt(GstrItemGuia), NroGuiaDir, codempresa, NROPTOVTA.ToString.Trim, calmacen.SelectedValue.ToString())
        '        Else
        '            CAyuda.Ejecutar("NSP_INS_SALDOS_COSTO", ADblCorrela, CInt(GstrItemGuia), NroGuiaDir, codempresa, NROPTOVTA.ToString.Trim, calmacen.SelectedValue.ToString())
        '        End If
        '        SQL = "NSP_ins_guiadet '" & NroGuiaDir & "','" & codempresa & "','" & correl & "'," & CInt(GstrItemGuia) & ",'" & txtnumoc1.Text & "-" & txtnumoc.Text & "','" & CodUsuario & "'," & 0 & ",'" & importa & "','" & moviant & "'," & ADblOp & ""
        '        PROCESO = TmpInsertDatos(SQL)

        '        If MessageBox.Show("¿ Desea Imprimir el Documento ?", "Informacion", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '            GeneraReporte(NroGuiaDir)
        '        End If
        '    Next

        '    'modificado las siguientes lineas
        '    ''''If PROCESO = True Then
        '    ''''    MessageBox.Show("Registro Guardado Correctamente !!!", Desempresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    ''''    If cbotipodoc.SelectedValue = CODGUIATRANSF.Trim Then ''SI ES GUIA DE TRANSFERENCIA
        '    ''''        Dim resultado As Boolean
        '    ''''        Dim INGRESO As Boolean
        '    ''''        Dim CLSINTER As New clsdatos_JHON
        '    ''''        resultado = CLSINTER.insert_store("SP_REGISTRA_SALIDA_TRANSFERENCIA " & txtnumeroguia2.Text + txtnumeroguia.Text & ",'" & CODSALTRANS & "'") ''REGISTRA LA TRANSFERENCIA
        '    ''''        If resultado = False Then
        '    ''''            MsgBox("No se pudo registro la transferencia", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        '    ''''        End If
        '    ''''    End If

        '    If Trim(cbotipodoc.SelectedValue.ToString()) = CODGUIATRANSF.Trim Then
        '        'Dim ClsDatos As New clsdatos_JHON

        '        SQL = "USP_ACTUALIZAR_ESTADO_TRANSFER " & NroMovi & "," & NroGuiaDir & ",'" & Trim(Me.calmacen.SelectedValue.ToString()) & "','" & Codigo_SalidaxTransferencia & "','" & codempresa.Trim & "'"
        '        If TmpInsertDatos(SQL) = False Then
        '            MsgBox("No se pudo Actualizar el Estado Transfer de Movidet", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        '            'Else 'modificado las dos siguientes lineas
        '            'SQL = "SP_REGISTRA_SALIDA_TRANSFERENCIA " & NroMovi & ",'" & CODSALTRANS.Trim & "'"
        '            'ClsDatos.insert_store(SQL)
        '        End If
        '        'ClsDatos = Nothing
        '    End If

        Call BOTONES(True, False, False, False)
        '    tcambio()
        '    ' bloqueatextbox(Me)
        '    Me.grid1.Enabled = False
        '    Me.DateTimePicker1.Enabled = False
        '    BLOQUEA(False, True)
        'End If



        '/*******************************************************************************************/


        'End If
        CONT = 0
        txtnumeroguia.Enabled = True
        txtnumeroguia2.Enabled = True
        BTNCANCELAR.Enabled = False
        Me.BtnTransferencia.Enabled = False
        If PROCESO = False Then Exit Sub

        'Else
        'MessageBox.Show("Ingresa Valores al Detalle", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Exit Sub
        'End If



        'Me.DsInventInicial1.Clear()
        Me.grid1.Refresh()
    End Sub

    Sub BLOQUEA(ByVal P As Boolean, ByVal P1 As Boolean)
        txtcodcliente.Enabled = P
        txtcodarticulo.Enabled = P
        txtcantidad.Enabled = P
        txtboleta.Enabled = P

        btnarticulo.Enabled = P

        BTNCLIENTE.Enabled = P
        BTNGUARDAR.Enabled = P
        BTNCANCELAR.Enabled = P
        BTNELIMINAR.Enabled = P1
        BTNNUEVO.Enabled = P1

        Button1.Enabled = P1
        btnobs.Enabled = P
        cbotipodoc.Enabled = P
        cbotipopre.Enabled = P
        Me.DateTimePicker1.Enabled = P
        Me.txtnumoc.Enabled = P
        Me.txtnumoc1.Enabled = P
        'cmoneda.Enabled = P
        'cbovendedor.Enabled = P
        cbotipopago.Enabled = P
        'calmacen.Enabled = P
        grid1.Enabled = P
        cmbalmllegada.Enabled = P
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        INICIA = 0
        Dim men As New frm_gridguia
        men.Establecer_Almacen = True
        men.AFrmGuiaDir = Me

        men.ShowDialog(Me)

        PROCESO1 = "MODIFICACION"

        If EstaDocGuiaDir Then
            BOTONES(True, False, False, False)
            BTNCANCELAR.Enabled = True
            MessageBox.Show("GUIA ANULADA.........................!", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EstaDocGuiaDir = False
            BTNREPORTE.Enabled = False
        End If
        BTNREPORTE.Enabled = True
    End Sub
    Dim xNroGuia As String
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MessageBox.Show("¿Desea Anular el Registro Seleccionado?", "NAR SISTEMAS S.A.C", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            xNroGuia = Val(NROPTOVTA) & Format(Val(Me.txtnumeroguia.Text.Trim), "0000000")
            Conecta("SELECT * FROM GUIACAB WHERE NROGUIA = " & CInt(xNroGuia.Trim) & " AND PTOVTA = '" & NROPTOVTA & "' AND CODEMPRESA = '" & codempresa.Trim & "'", "x")

            If Trim(ds.Tables("x").Rows(0).Item("ESTADODOC").ToString()) = "ATENDIDO" Then
                MsgBox("El Documento Esta Facturado y No se Puede Anular" + Chr(13) + "Consulte a Su Proveedor", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
                Exit Sub
            Else
                tbldet.Clear()

                TmpInsertDatos("update guiacab set estado=1 where codempresa='" & codempresa & "' and nroguia=" & txtnumeroguia2.Text + Me.txtnumeroguia.Text.Trim & "")
                TmpInsertDatos("update guiadet set estado=1 where codempresa='" & codempresa & "' and nroguia=" & txtnumeroguia2.Text + Me.txtnumeroguia.Text.Trim & "")

                TmpInsertDatos("delete from tmp_guiadet where codempresa='" & codempresa & "' and nroguia=" & txtnumeroguia2.Text + Me.txtnumeroguia.Text & "")

                'Me.DsInventInicial1.Clear()
                Me.grid1.Refresh()
                MessageBox.Show("Registro Anulado Correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtnumeroguia2.Text + txtnumeroguia.Text & "','DELETE','GUIADIRECTA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Call limpia()
            End If
        End If
    End Sub

    Private Sub FRMGUIADIRECTA_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            'ClsInter = Nothing
            TmpInsertDatos("delete from tmp_guiadet where codempresa='" & codempresa & "' and nroguia='" & txtnumeroguia2.Text + Me.txtnumeroguia.Text & "'")
            'Reos = 0
        Catch x As Exception
        End Try
    End Sub
    Dim valoriza As Boolean
    Public TIPOVENTA As Boolean

    Public Sub valoriza_tipo()
        Try
            Conecta("select valorizado,TIPOVENTA ,GENERASALIDA from tipo_guia where codguia='" & Me.cbotipodoc.SelectedValue.ToString & "' and codempresa='" & codempresa & "' and estado=0", "id")
            If ds.Tables("id").Rows.Count > 0 Then
                If ds.Tables("id").Rows(0)(0) = False Then
                    valoriza = False
                    TIPOVENTA = ds.Tables("id").Rows(0)(1)
                    VarGenSal = ds.Tables("id").Rows(0)(2)
                    Label14.Visible = False
                    Me.txtprecio.Visible = False
                    Me.GroupBox4.Visible = False

                    Me.cbovendedor.Visible = False
                    Me.cbotipopago.Visible = False
                    Me.cbotipopre.Visible = False
                    Label18.Visible = False
                    Label8.Visible = False
                    Label5.Visible = False
                    'TXTLOTE.Visible = True
                    'Label23.Visible = True
                    cargagrilla()
                    FormatGrid()

                Else
                    valoriza = True
                    TIPOVENTA = ds.Tables("id").Rows(0)(1)
                    VarGenSal = ds.Tables("id").Rows(0)(2)
                    Label14.Visible = True
                    Me.txtprecio.Visible = True
                    Me.GroupBox4.Visible = True
                    Me.cbovendedor.Visible = True
                    Me.cbotipopago.Visible = True
                    Me.cbotipopre.Visible = True
                    Label18.Visible = True
                    Label8.Visible = True
                    Label5.Visible = True
                    'TXTLOTE.Visible = False
                    'Label23.Visible = False
                    cargagrilla()
                    FormatGridValor()
                End If


            End If
        Catch
        End Try
    End Sub
    Private Sub cbotipodoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipodoc.SelectedIndexChanged
        Try
            If Trim(Me.cbotipodoc.SelectedValue.ToString()) = CODGUIATRANSF Then
                Me.BtnTransferencia.Visible = True
            Else
                Me.BtnTransferencia.Visible = False
            End If

            If Me.cbotipodoc.SelectedIndex = 0 Then
                Reos = 0
                Me.TXTLOTE.Text = ""
            Else
                Reos = 1
            End If

            Call valoriza_tipo()

            If TIPOVENTA = False Then
                cbotipopre.Visible = False
                lblmoneda.Visible = False
                Label18.Visible = False
                Label20.Visible = False
                txtboleta.Visible = False
                cbomoneda.Visible = False
                ABoolValorCombo = True
                ADblOp = 1
            Else
                lblmoneda.Visible = True
                cbomoneda.Visible = True
                cbotipopre.Visible = True
                Label18.Visible = True
                Label20.Visible = True
                txtboleta.Visible = True
                ABoolValorCombo = False
                ADblOp = 0
            End If
            If VarGenSal = False Then
                cmbalmllegada.Visible = False
                Label19.Visible = False
            Else
                cmbalmllegada.Visible = True
                Label19.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbotipopre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipopre.SelectedIndexChanged
        CargarMoneda()
    End Sub
    Private Sub OBTDATOSARTI()
        Dim ds As New DataSet
        If CONFIGGRID = "11" Then
            If cbounidadventa.SelectedIndex = 0 Then
                'ListBox1.SelectedIndex = 0

                Conecta("select valorizado,TIPOVENTA from tipo_guia where codguia='" & cbotipodoc.SelectedValue.ToString & "' and codempresa='" & codempresa & "' and estado=0", "VTA")
                TIPOVENTA = ds.Tables("vta").Rows(0)(1)
                If TIPOVENTA Then
                    ds = CAyuda.ListarDatos("NSP_ARTICULOPRECIOGUIA_ARTICULO_UNIMED'" & Me.TxtMedida.Text.Trim & "','','" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & cbotipopre.SelectedValue & "'")
                Else
                    ds = CAyuda.ListarDatos("NSP_ARTICULOCOSTOFAC_ARTICULO_UNIMED '" & Me.TxtMedida.Text.Trim & "','','" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & calmacen.SelectedValue & "'")
                End If
                txtcodarticulo.Text = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(0))
                'txtdesarticulo.Text = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(1))
                'cbounidadventa.Text = DS.Tables(0).Rows(0)(2)
                'txtprecio.Text = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(3))
                txtigvart.Text = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)("IGV"))
                'ListBox1.SelectedItem = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(7))

            End If
            If cbounidadventa.SelectedIndex = 1 Then
                'ListBox1.SelectedIndex = 1
                If TIPOVENTA Then
                    ds = CAyuda.ListarDatos("NSP_ARTICULOPRECIOGUIA_ARTICULO_UNIMED'','" & Me.TxtMedida.Text.Trim & "','" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & cbotipopre.SelectedValue & "'")
                Else
                    ds = CAyuda.ListarDatos("NSP_ARTICULOCOSTOFAC_ARTICULO_UNIMED '','" & Me.TxtMedida.Text.Trim & "','" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & calmacen.SelectedValue & "'")
                End If
                txtcodarticulo.Text = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(0))
                'txtdesarticulo.Text = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(1))
                'cbounidadventa.Text = DS.Tables(0).Rows(0)(2)
                txtigvart.Text = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)("IGV"))
                'txtprecio.Text = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(5))
                'ListBox1.SelectedItem = CAyuda.ValidaNullSTring(ds.Tables(0).Rows(0)(8))
            End If
            ConsTipoMed = 0 'IIf(ListBox1.SelectedIndex = 0, 0, 1)
        Else
            If TIPOVENTA Then
                ds = CAyuda.ListarDatos("NSP_ARTICULOPRECIOGUIA_ARTICULO'" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & cbotipopre.SelectedValue & "' ")
            Else
                ds = CAyuda.ListarDatos("NSP_ARTICULOCOSTOFAC_ARTICULO '" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & calmacen.SelectedValue & "'")
            End If
        End If
    End Sub
    Private Sub cbounidadventa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbounidadventa.SelectedIndexChanged
        OBTDATOSARTI()
    End Sub
    Sub IngresaVaolGrilla()

        Dim ADblValorIgv As Double
        'Dim CLSINTER As New ClsInterface
        If cbotipodoc.SelectedValue = CODGUIATRANSF.Trim Then
            'ASTRNROIMPORTACION = xASTRNROIMPORTACION
            'Dim tabla As New DataTable
            'tabla = CLSINTER.ListarDatos("SP_OBT_NUM_IMPORT", Me.txtcodarticulo.Text.Trim, Me.TXTLOTE.Text.Trim).Tables(0)
            'If tabla.Rows.Count > 0 Then
            'ASTRNROIMPORTACION = tabla.Rows(0)(0)
            'Else
            'MsgBox("Revise el numero de lote ", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            'Exit Sub
            'End If

        End If

        If Me.txtcantidad.Text.Trim = "" Or Me.txtcantidad.Text = "0" Then
            MessageBox.Show("No puedo ingresar 0 o Espacios en Blanco en Cantidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Me.txtcodarticulo.Text.Trim = "" Then
            MessageBox.Show("No puedo ingresar Un Codigo en Balnco", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CodArtGuiaDir <> Trim(txtcodarticulo.Text) Then
            Conecta("select valorizado,TIPOVENTA , GENERASALIDA from tipo_guia where codguia='" & cbotipodoc.SelectedValue.ToString & "' and codempresa='" & codempresa & "' and estado=0", "VTA")
            If ds.Tables("vta").Rows.Count > 0 Then
                If ds.Tables("VTA").Rows(0)(2) = True Then
                    If calmacen.SelectedValue = cmbalmllegada.SelectedValue Then
                        MessageBox.Show("El Almacen Salida No Puede Ser Igual Almacen Llegada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                End If
                ''08-05
                If ds.Tables("VTA").Rows(0)(1) = True Then
                    ds = CAyuda.ListarDatos("NSP_ARTICULOPRECIOGUIA_ARTICULO'" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & cbotipopre.SelectedValue & "'")
                Else
                    ds = CAyuda.ListarDatos("NSP_ARTICULOCOSTOFAC_ARTICULO '" & txtcodarticulo.Text & "','" & NROPTOVTA & "','" & codempresa & "','" & calmacen.SelectedValue & "','" & TXTLOTE.Text & "','" & ASTRNROIMPORTACION & "'")
                End If
            Else
                MessageBox.Show("No existen registros encontrados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtcodarticulo.Focus()
                Exit Sub
            End If

            ''''If ds.Tables(0).Rows.Count = 0 Then
            ''''    MessageBox.Show("El Articulo No Tiene Saldo con este Lote ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ''''    Me.TXTLOTE.Text = ""
            ''''    Me.txtcodarticulo.Text = ""
            ''''    Me.txtdesarticulo.Text = ""
            ''''    Me.TXTBULTO.Text = "0"
            ''''    Me.txtcantidad.Text = "0"
            ''''    Me.TxtPesBru.Text = "0"
            ''''    Me.txtcodarticulo.Focus()
            ''''    Exit Sub
            ''''End If
            est = True
        End If

        Dim xMed As String
        xMed = Me.TxtMedida.Text.Trim

        If est = True Then
            CONT += 1
            ADblValorIgv = Val(txtigvart.Text)
            igv = Val(txtigvart.Text) / 100

            If monval = True Then
                Call INSERT_TMP_DETALLE(correl, ADblValorIgv, xMed.Trim, Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), " MM/dd/yy"), txtcantidad.Text, txtprecio.Text, txtcodarticulo.Text, CONT, calmacen.SelectedValue.ToString, (Val(txtcantidad.Text) * Val(txtprecio.Text)) - ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv), ((Val(txtcantidad.Text) * Val(txtprecio.Text)) - ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv)) / VCambioVta, (Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv, ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv) / VCambioVta, Val(txtcantidad.Text) * Val(GValidarVacios(txtprecio.Text)), (Val(txtcantidad.Text) * Val(txtprecio.Text)) / VCambioVta, xMed, codempresa, obsGuiaDir, ConsTipoMed, CDbl(Me.TxtPesBru.Text.Trim))
            Else
                Call INSERT_TMP_DETALLE(correl, ADblValorIgv, xMed.Trim, Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy"), txtcantidad.Text, txtprecio.Text, txtcodarticulo.Text, CONT, calmacen.SelectedValue.ToString, ((Val(txtcantidad.Text) * Val(txtprecio.Text)) - ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv)) * VCambioVta, (Val(txtcantidad.Text) * Val(txtprecio.Text)) - ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv), ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv) * VCambioVta, Val(txtcantidad.Text) * Val(txtprecio.Text) * igv, (Val(txtcantidad.Text) * Val(GValidarVacios(txtprecio.Text))) * VCambioVta, Val(txtcantidad.Text) * Val(txtprecio.Text), xMed, codempresa, obsGuiaDir, ConsTipoMed, CDbl(Me.TxtPesBru.Text.Trim))
            End If

            Call cargagrilla()

        ElseIf est = False Then
            Call elimina_item()
            ADblValorIgv = Val(txtigvart.Text)
            igv = Val(txtigvart.Text) / 100
            If monval = True Then
                Call INSERT_TMP_DETALLE(correl, ADblValorIgv, Me.TxtMedida.Text.Trim, Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy"), txtcantidad.Text, txtprecio.Text, txtcodarticulo.Text, grid1.Item(grid1.CurrentRowIndex, 0), calmacen.SelectedValue.ToString, (Val(txtcantidad.Text) * Val(txtprecio.Text)) - ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv), ((Val(txtcantidad.Text) * Val(txtprecio.Text)) - ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv)) / VCambioVta, (Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv, ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv) / VCambioVta, Val(txtcantidad.Text) * Val(txtprecio.Text), (Val(txtcantidad.Text) * Val(txtprecio.Text)) / VCambioVta, xMed.Trim, codempresa, obsGuiaDir, 0, CDbl(Me.TxtPesBru.Text.Trim))
            Else
                Call INSERT_TMP_DETALLE(correl, ADblValorIgv, Me.TxtMedida.Text.Trim, Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy"), txtcantidad.Text, txtprecio.Text, txtcodarticulo.Text, grid1.Item(grid1.CurrentRowIndex, 0), calmacen.SelectedValue.ToString, ((Val(txtcantidad.Text) * Val(txtprecio.Text)) - ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv)) * VCambioVta, (Val(txtcantidad.Text) * Val(txtprecio.Text)) - ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv), ((Val(txtcantidad.Text) * Val(txtprecio.Text)) * igv) * VCambioVta, Val(txtcantidad.Text) * Val(txtprecio.Text) * igv, (Val(txtcantidad.Text) * Val(txtprecio.Text)) * VCambioVta, Val(txtcantidad.Text) * Val(txtprecio.Text), xMed.Trim, codempresa, obsGuiaDir, 0, CDbl(Me.TxtPesBru.Text.Trim))
            End If
            Call cargagrilla()
            cmbalmllegada.Enabled = False
            est = True
        End If
        obsGuiaDir = ""
        Call DESABILITARCONTROLES()
        Me.TxtPesBru.Text = "0"
        Me.TXTLOTE.Text = ""
        Me.txtcodarticulo.Focus()
    End Sub

    Private Sub cbounidadventa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbounidadventa.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'If GValidarVacios(txtlote.Text) = 0 Then
            '    MessageBox.Show("Ingrese el Numero de Lote", Desempresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            'conecta("select nroimport,nromovi from movicab where nrolote='" & Me.txtlote.Text & "' and inout=1 and cdalmacen='" & calmacen.SelectedValue.ToString & "'", "ubica")
            'If ds.Tables("ubica").Rows.Count = 0 Then
            '    MessageBox.Show("No existe el lote ingresado... Verifique !!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'Else
            '    importa = ds.Tables("ubica").Rows(0)(0)
            '    moviant = ds.Tables("ubica").Rows(0)(1)
            'End If
            IngresaVaolGrilla()

            cbounidadventa.Enabled = False
            txtcodarticulo.Focus()

        End If
    End Sub
    Sub FormatGridValor()
        Try
            Dim grdTableStyle1 As New DataGridTableStyle
            With grdTableStyle1
                .AlternatingBackColor = Color.GhostWhite
                .MappingName = tbldet.TableName
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
                .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End With
            Dim grdColStyle1 As New DataGridTextBoxColumn
            With grdColStyle1
                .HeaderText = "ITEM"
                .MappingName = "iditem"
                .Width = 60
            End With

            Dim grdColStyle2 As New DataGridTextBoxColumn
            With grdColStyle2
                .HeaderText = "CODIGO"
                .MappingName = "codigo"
                .Width = 80
            End With

            Dim grdColStyle3 As New DataGridTextBoxColumn
            With grdColStyle3
                .HeaderText = "ARTICULO"
                .MappingName = "descripcion"
                .Width = 300
            End With

            Dim grdColStyle4 As New DataGridTextBoxColumn
            With grdColStyle4
                .HeaderText = "MEDIDA"
                .MappingName = "umedida"
                .Width = 60
            End With
            Dim grdColStyle5 As New DataGridTextBoxColumn
            With grdColStyle5
                .HeaderText = "CANTIDAD"
                .MappingName = "CANTIDAD"
                .Width = 80
            End With
            Dim grdColStyle6 As New DataGridTextBoxColumn
            With grdColStyle6
                .HeaderText = "PRECIO"
                .MappingName = "Precio"
                .Width = 80
                .Format = FACT_GFormatodeNumero(0)
            End With
            Dim grdColStyle7 As New DataGridTextBoxColumn
            With grdColStyle7
                .HeaderText = "TOTAL"
                .MappingName = "TOTBAS"
                .Width = 80
            End With
            Dim grdColStyle8 As New DataGridTextBoxColumn
            With grdColStyle8
                .HeaderText = "TIPO"
                .MappingName = "TIPOMEDIDA"
                .Width = 0

            End With
            Dim grdColStyle9 As New DataGridTextBoxColumn
            With grdColStyle9
                .HeaderText = "LOTE"
                .MappingName = "NROLOTE"
                .Width = 0

            End With
            Dim grdColStyle10 As New DataGridTextBoxColumn
            With grdColStyle10
                .HeaderText = "NROBULTO"
                .MappingName = "BULTO"
                .Width = 80
            End With
            grdTableStyle1.GridColumnStyles.AddRange _
                (New DataGridColumnStyle() _
                {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8, grdColStyle9, grdColStyle10})
            grid1.TableStyles.Add(grdTableStyle1)
        Catch
        End Try
    End Sub

    Sub FormatGrid()
        Try
            Dim grdTableStyle1 As New DataGridTableStyle
            With grdTableStyle1
                .AlternatingBackColor = Color.GhostWhite
                .MappingName = tbldet.TableName
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
                .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End With
            Dim grdColStyle1 As New DataGridTextBoxColumn
            With grdColStyle1
                .HeaderText = "ITEM"
                .MappingName = "iditem"
                .Width = 60
            End With

            Dim grdColStyle2 As New DataGridTextBoxColumn
            With grdColStyle2
                .HeaderText = "CODIGO"
                .MappingName = "codigo"
                .Width = 100
            End With

            Dim grdColStyle3 As New DataGridTextBoxColumn
            With grdColStyle3
                .HeaderText = "ARTICULO"
                .MappingName = "descripcion"
                .Width = 300
            End With

            Dim grdColStyle4 As New DataGridTextBoxColumn
            With grdColStyle4
                .HeaderText = "MEDIDA"
                .MappingName = "umedida"
                .Width = 60
            End With
            Dim grdColStyle5 As New DataGridTextBoxColumn
            With grdColStyle5
                .HeaderText = "CANTIDAD"
                .MappingName = "CANTIDAD"
                .Width = 90
            End With
            Dim grdColStyle6 As New DataGridTextBoxColumn
            With grdColStyle6
                .HeaderText = "TIPO"
                .MappingName = "TIPOMEDIDA"
                .Width = 0
            End With
            Dim grdColStyle7 As New DataGridTextBoxColumn
            With grdColStyle7
                .HeaderText = "LOTE"
                .MappingName = "NROLOTE"
                .Width = 50
            End With

            Dim grdColStyle8 As New DataGridTextBoxColumn
            With grdColStyle8
                .HeaderText = "NROBULTO"
                .MappingName = "BULTO"
                .Width = 80
            End With

            Dim grdColStyle9 As New DataGridTextBoxColumn
            With grdColStyle9
                .HeaderText = "PESO BRUTO"
                .MappingName = "PESOBRUTO"
                .Width = 80
            End With

            grdTableStyle1.GridColumnStyles.AddRange _
                (New DataGridColumnStyle() _
                {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5, grdColStyle6, grdColStyle7, grdColStyle8, grdColStyle9})
            grid1.TableStyles.Add(grdTableStyle1)
        Catch
        End Try
    End Sub


    Private Sub txtcodarticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodarticulo.KeyDown
        If txtcodarticulo.Text = "" Then
            If e.KeyCode = Keys.F2 Then
                Button10_Click(sender, e)
            End If
        End If
    End Sub
    Sub DESABILITARCONTROLES()
        cbotipodoc.Enabled = False
        cbotipopre.Enabled = False
        cbotipopago.Enabled = False
        'calmacen.Enabled = False
        cmbalmllegada.Enabled = False

    End Sub
    Sub HABILITARCONTROLES()
        cbotipodoc.Enabled = True
        cbotipopre.Enabled = True
        cbotipopago.Enabled = True
        'calmacen.Enabled = True
        cmbalmllegada.Enabled = True

    End Sub

    Private Sub txtcodcliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodcliente.KeyDown
        If e.KeyCode = Keys.F2 Then
            Button12_Click(sender, e)
        End If

    End Sub

    Private Sub txtnumeroguia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnumeroguia.KeyDown
        If e.KeyCode = Keys.F2 Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub cbotipodoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotipodoc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbotipopre.Visible = True Then
                'If valoriza = False Then
                'cbotipopre.Focus()
                'Else
                '   DateTimePicker1.Focus()
                '  End If
                cbotipopre.Focus()
            Else

                DateTimePicker1.Focus()
            End If
        End If
    End Sub

    Private Sub cbotipopre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotipopre.KeyPress
        If Asc(e.KeyChar) = 13 Then

            txtboleta.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnumoc1.Focus()
        End If
    End Sub

    Private Sub txtnumoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumoc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If valoriza = True Then
                cbotipopago.Focus()
            Else
                cmbalmllegada.Focus()
            End If
        End If
    End Sub

    Private Sub cbovendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbovendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            calmacen.Focus()
        End If
    End Sub

    Private Sub cbotipopago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotipopago.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcodarticulo.Focus()
        End If
    End Sub

    Private Sub calmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles calmacen.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcodarticulo.Focus()
        End If
    End Sub



    Sub VERIFICATIPOPRECIO()
        Conecta("select valorizado,TIPOVENTA from tipo_guia where codguia='" & Me.cbotipodoc.SelectedValue.ToString & "' and codempresa='" & codempresa & "' and estado=0", "id")
        If ds.Tables("id").Rows(0)(1) = False Then
            cbotipopre.Visible = False
            Label18.Visible = False
        Else
            cbotipopre.Visible = True
            Label18.Visible = True
        End If
    End Sub


    Private Sub btnobsitem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnobsitem.Click
        Dim men As New FrmObsItem
        men.AFrmGuiaDir = Me
        men.txtobsitem.Text = obsGuiaDir
        men.txtobsitem.Focus()
        men.ShowDialog(Me)
        cbounidadventa.Focus()
    End Sub

    Private Sub BTNREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNREPORTE.Click
        'If txtnumeroguia2.Text.Trim.ToString = "" Then
        '    MessageBox.Show("Debe de ingresar el numero de guia para poder efectuar el reporte..!", "NAR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtnumeroguia2.Focus()
        '    txtnumeroguia2.SelectAll()
        'ElseIf txtnumeroguia.Text.Trim.ToString = "" Then
        '    MessageBox.Show("Debe de ingresar el numero de guia para poder efectuar el reporte..!", "NAR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtnumeroguia.Focus()
        '    txtnumeroguia.SelectAll()
        'Else
        '    GeneraReporte(txtnumeroguia2.Text + txtnumeroguia.Text)
        'End If




        If txtOrdenDesp.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL NUMERO DE ORDEN DE DESPACHO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            txtOrdenDesp.Focus()
            Exit Sub
        End If
        'CargarReporte()

        '------------------------------------



        If rbDespacho.Checked = True Then
            imprimir_Despacho()
        End If


        If rbTraslado.Checked = True Then
            imprimir_traslado()
        End If










    End Sub




    Sub imprimir_Despacho()

        Dim ORDENDESPACHO As String
        ORDENDESPACHO = txtOrdenDesp.Text
        Try
            Rpt1.WindowShowExportBtn = True
            Rpt1.WindowShowPrintBtn = True
            Rpt1.WindowShowPrintSetupBtn = True
            Rpt1.set_StoredProcParam(0, codempresa)
            Rpt1.set_StoredProcParam(1, ORDENDESPACHO)
            Rpt1.set_StoredProcParam(2, 1)

            Rpt1.ReportFileName = rutareporte + CType("Rpt_Consolidado_Producto_2.rpt", String)
            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            Rpt1.set_Formulas(0, "CertIns='" & nrocert & "'")
            Rpt1.set_Formulas(1, "Ddep='" & DepP2 & "'")
            Rpt1.set_Formulas(2, "Ddirec='" & domd & "'")
            Rpt1.set_Formulas(3, "Ddistrito='" & provd & "'")

            Rpt1.set_Formulas(4, "Dprov='" & distd & "'")
            Rpt1.set_Formulas(5, "FechaEmi1='" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "'")
            Rpt1.set_Formulas(6, "Lic.Conducir='" & LicConduc & "'")
            Rpt1.set_Formulas(7, "PDnomrz='" & dest & "'")

            Rpt1.set_Formulas(8, "PDruc='" & x & "'")
            Rpt1.set_Formulas(9, "Pdep='" & DepP & "'")
            Rpt1.set_Formulas(10, "Pdirec='" & domp & "'")
            Rpt1.set_Formulas(11, "Pdto='" & provd & "'")

            Rpt1.set_Formulas(12, "Pprov='" & provp & "'")
            Rpt1.set_Formulas(13, "UVeh='" & placa & "'")
            Rpt1.set_Formulas(14, "fechaEmi2='" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "'")


            'If ChkPorPantalla.CheckState = CheckState.Unchecked Then
            '    Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
            'Else
            '    Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            'End If

            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt1.Action = 1
            Rpt1.Reset()



            'TmpListarDatos("NSP_UPDATE_IMPCONSOL_ORDEN_DESPACHO   'Rpt_Consolidado_Producto" & codempresa & "' , '" & txtOrdenDesp.Text.Trim & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub






    Sub imprimir_traslado()

        Dim ORDENDESPACHO As String
        ORDENDESPACHO = txtOrdenDesp.Text
        Try
            Rpt1.WindowShowExportBtn = True
            Rpt1.WindowShowPrintBtn = True
            Rpt1.WindowShowPrintSetupBtn = True
            'Rpt1.set_StoredProcParam(0, codempresa)
            'Rpt1.set_StoredProcParam(1, ORDENDESPACHO)
            'Rpt1.set_StoredProcParam(2, 1)

            Rpt1.set_StoredProcParam(0, codempresa)
            Rpt1.set_StoredProcParam(1, txtOrdenDesp.Text.Trim)
            Rpt1.set_StoredProcParam(2, "006")
            Rpt1.set_StoredProcParam(3, " ")
            Rpt1.set_StoredProcParam(4, " ")




            Rpt1.ReportFileName = rutareporte + CType("Rpt_Produccion_Inventario_Guia.rpt", String)
            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            Rpt1.set_Formulas(0, "CertIns='" & nrocert & "'")
            Rpt1.set_Formulas(1, "Ddep='" & DepP2 & "'")
            Rpt1.set_Formulas(2, "Ddirec='" & domd & "'")
            Rpt1.set_Formulas(3, "Ddistrito='" & provd & "'")

            Rpt1.set_Formulas(4, "Dprov='" & distd & "'")
            Rpt1.set_Formulas(5, "FechaEmi1='" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "'")
            Rpt1.set_Formulas(6, "Lic.Conducir='" & LicConduc & "'")
            Rpt1.set_Formulas(7, "PDnomrz='" & dest & "'")

            Rpt1.set_Formulas(8, "PDruc='" & x & "'")
            Rpt1.set_Formulas(9, "Pdep='" & DepP & "'")
            Rpt1.set_Formulas(10, "Pdirec='" & domp & "'")
            Rpt1.set_Formulas(11, "Pdto='" & provd & "'")

            Rpt1.set_Formulas(12, "Pprov='" & provp & "'")
            Rpt1.set_Formulas(13, "UVeh='" & placa & "'")
            Rpt1.set_Formulas(14, "fechaEmi2='" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "'")





            'If ChkPorPantalla.CheckState = CheckState.Unchecked Then
            '    Rpt1.Destination = Crystal.DestinationConstants.crptToPrinter
            'Else
            '    Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            'End If

            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt1.Action = 1
            Rpt1.Reset()



            'TmpListarDatos("NSP_UPDATE_IMPCONSOL_ORDEN_DESPACHO   'Rpt_Consolidado_Producto" & codempresa & "' , '" & txtOrdenDesp.Text.Trim & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub









    Private Sub btnobs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnobs.Click
        'If txtcodcliente.Text = "" Then
        '    MsgBox("Elija el cliente Primero", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        Dim men As New frmObsGuia
        men.AFrmGuiaDir = Me
        men.tdomd.Focus()
        men.ShowDialog(Me)



        BTNGUARDAR.Focus()
    End Sub
    Sub GeneraReporte(ByVal ADblNroguia As Double)
        Try
            crRpt.ReportFileName = rutareporte & "RptguiaDir.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, ADblNroguia)
            crRpt.WindowShowPrintBtn = True
            crRpt.WindowShowExportBtn = True
            crRpt.WindowShowPrintSetupBtn = True
            crRpt.WindowShowSearchBtn = True
            ' crRpt.Destination = Crystal.DestinationConstants.crptToPrinter
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch
            MessageBox.Show("Configure Una Impresora !!!", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Sub sp_sube_tmp_saldos_importacion(ByVal Codarticulo As String, ByVal LOTE As String, ByVal IMPORTACION As Double)
        Dim sql As String
        ATblAyuda = CAyuda.ListarDatos("sp_sube_tmp_saldos_importacion_GUIA1", Codarticulo, ADblCorrela, NROPTOVTA, LOTE, IMPORTACION).Tables(0)
        If ATblAyuda.Rows.Count > 0 Then
            sql = "sp_sube_tmp_saldos_importacion_GUIA '" & Trim(Codarticulo) & "'," & ADblCorrela & ",'" & NROPTOVTA & "','" & LOTE & "'," & IMPORTACION & ""
            FACT_Cargagrid(DataGrid1, sql)
        Else
            'MessageBox.Show("
        End If
    End Sub
    Sub INSERT_TMP_DETALLE(ByVal correl As Double, ByVal igv As Double, ByVal LIST As String, ByVal FECHA As String, ByVal CANTIDAD As Double, ByVal PRECIO As Double, ByVal CODARTI As String, ByVal NROITEM As Double, ByVal ALMACEN As String, ByVal SUBTBAS As Double, ByVal SUBTEXT As Double, ByVal IGVBAS As Double, ByVal IGVEXT As Double, ByVal TOTBAS As Double, ByVal TOTEXT As Double, ByVal MEDIDA As String, ByVal EMPRESA As String, ByVal OBS As String, ByVal TipoMed As Integer, ByVal xPesoBruto As Double)
        Try
            Dim status As Boolean
            Dim SQL As String
            Dim NITEM As Integer
            Dim ADBLNROLOTE As String = ""

            Dim FECHARECIB As String = ""
            Dim TxtCan As Double
            Dim TxtCanB As Double = 0
            Dim ADblPrecio As Double
            Dim ADblSubTotBas, ADblSubTotExt, ADblIgvBas, ADblIgvExt, ADblTotalBas, ADblTotalExt As Double

            If TIPOVENTA = False Then
                Call sp_sube_tmp_saldos_importacion(txtcodarticulo.Text, TXTLOTE.Text, ASTRNROIMPORTACION)
            Else
                Call sp_sube_tmp_saldos_importacion1(txtcodarticulo.Text)
            End If
            'Dim N, I, AINTI As Integer
            Dim totcantidad As Double 'Dim NTOTALDOCUM As Double
            Dim TotCantidadB As Double = 0
            'Dim IT As Integer
            'Dim tot, j, MONTOITEMTAR, ADBLSUMAAYUDA As Double
            Dim TotB As Double = 0
            Dim SALDO As Double
            'Dim SaldoB As Double
            'Dim tot2 As Double
            'Dim NITE As Integer
            Dim ADblCosBas, ADblCosExt As Double
            Dim columna As Integer = 4 ' espefico por donde descontar por bulto o por bruto
            Dim nimportacion As Long ' numero de importacion
            TxtCan = CDbl(txtcantidad.Text)
            TxtCanB = CDbl(Me.TXTBULTO.Text.Trim)

            totcantidad = TxtCan ' optengo la cantidad 
            TotCantidadB = TxtCanB

            If CONFIGGRID = "01" Then
                If ListBox1.SelectedIndex = 0 Then columna = 5 'unidad mayor
            ElseIf CONFIGGRID = "10" Then
                'If ListBox1.SelectedIndex = 0 Then columna = 3 'unidad mayor
            Else
                'If ListBox1.SelectedIndex = 0 Then columna = 3 'unidad mayor
                'If ListBox1.SelectedIndex = 1 Then columna = 5 'unidad menor

            End If

            If TIPOVENTA = False Then
                SQL = "SP_UPDATE_TMP_saldos_importacion1 '" & txtcodarticulo.Text & "'," & nimportacion & ", " & columna & "," & SALDO & "," & ADblCorrela & ",'" & NROPTOVTA & "','" & FECHARECIB & "','" & TXTLOTE.Text & "'"
                TmpInsertDatos(SQL)
                Call sp_sube_tmp_saldos_importacion(txtcodarticulo.Text, TXTLOTE.Text, ASTRNROIMPORTACION)
            Else
                SQL = "SP_UPDATE_TMP_saldos_importacion '" & txtcodarticulo.Text & "'," & nimportacion & ", " & columna & "," & SALDO & "," & ADblCorrela & ",'" & NROPTOVTA & "','" & FECHARECIB & "'"
                TmpInsertDatos(SQL)
                Call sp_sube_tmp_saldos_importacion1(txtcodarticulo.Text)
            End If
            If ABoolValorCombo = True Then
                If monval = True Then
                    ADblPrecio = ADblCosBas
                Else
                    ADblPrecio = ADblCosExt
                End If
            Else
                ADblPrecio = Val(txtprecio.Text)
            End If
            If monval = True Then
                ADblSubTotBas = (totcantidad * ADblPrecio) / (1 + (igv / 100))
                ADblSubTotExt = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) / VCambioVta
                ADblIgvBas = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)
                ADblIgvExt = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)) / VCambioVta
                ADblTotalBas = totcantidad * ADblPrecio
                ADblTotalExt = (totcantidad * ADblPrecio) / VCambioVta
            Else
                ADblSubTotBas = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) * VCambioVta
                ADblSubTotExt = ((totcantidad * ADblPrecio) / (1 + (igv / 100)))
                ADblIgvBas = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)) * VCambioVta
                ADblIgvExt = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100))
                ADblTotalBas = (totcantidad * ADblPrecio) * VCambioVta
                ADblTotalExt = (totcantidad * ADblPrecio)
            End If
            NITEM = CDbl(CAyuda.ListarDatos("NSP_SELECT_ITEM_TMPGUIADET", correl).Tables(0).Rows(0)(0)) + 1
            If cbotipodoc.SelectedValue = CDGUIAVTA Then
                If est = False Then
                    SQL = "NSP_UPD_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NROITEM & ",'" & CDZONA & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & ADBLNROLOTE & ""
                Else
                    SQL = "NSP_ins_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NITEM & ",'" & CDZONA & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & TipoMed & "," & nimportacion & ",'" & "','" & NROPTOVTA.ToString.Trim & "'," & 0 & "," & 0 & ",'" & Me.TXTLOTE.Text.Trim & "','" & TotCantidadB & "'," & xPesoBruto & ""
                End If
            Else
                If est = False Then
                    SQL = "NSP_UPD_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NROITEM & ",'" & ALMACEN & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & ADBLNROLOTE & ""
                Else
                    SQL = "NSP_ins_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NITEM & ",'" & ALMACEN & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & TipoMed & "," & nimportacion & ",'" & "','" & NROPTOVTA.ToString.Trim & "'," & 0 & "," & 0 & ",'" & Me.TXTLOTE.Text.Trim & "','" & TotCantidadB & "'," & xPesoBruto & ""
                End If
            End If



            PROCESO = TmpInsertDatos(SQL)
            If PROCESO = True Then
                cbomoneda.Enabled = False
            End If
            'status = insert(totcantidad, 0)
            SQL = "SP_insert_TMP_saldosimportacion_negativos '" & txtcodarticulo.Text & "','" & NROPTOVTA & "'," & txtcantidad.Text & "," & ADblCorrela & "," & columna & "," & CONT & ""
            status = TmpInsertDatos(SQL)


            '            While tot <= totcantidad

            '                Try
            '                    If TIPOVENTA = False Then
            '                        For AINTI = 0 To ATblAyuda.Rows.Count - 1
            '                            ADBLSUMAAYUDA = ADBLSUMAAYUDA + Val(DataGrid1.Item(AINTI, columna))
            '                        Next
            '                        If ADBLSUMAAYUDA < Val(txtcantidad.Text) Then
            '                            MessageBox.Show("La Cantidad Excede al stock Verifique ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Question)
            '                            txtcantidad.Focus()
            '                            Exit Sub
            '                        End If
            '                    End If
            '                    tot = tot + DataGrid1.Item(j, columna + 1)
            '                    TotB = TotB + DataGrid1.Item(j, 3)
            '                    'Dim DT As String = Format(DataGrid1.Item(j, 9), "MM/dd/yyyy hh:mm:ss tt")
            '                    'IF DT="" THEN DT=Format(Date.Now.ToShortDateString, MM/dd/yyyy hh:mm:ss tt")ELSE Format(DataGrid1.Item(j, 9), "MM/dd/yyyy hh:mm:ss tt")
            '                    FECHARECIB = Format(COJ.ValidaNullsFecha(DataGrid1.Item(j, 9)), "MM/dd/yyyy hh:mm:ss tt")
            '                    MONTOITEMTAR = DataGrid1.Item(j, columna)
            '                    nimportacion = DataGrid1.Item(j, 1)
            '                    ADblCosBas = DataGrid1.Item(j, 7)
            '                    ADblCosExt = DataGrid1.Item(j, 8)
            '                    ADBLNROLOTE = CDbl(DataGrid1.Item(j, 10))
            '                    'MsgBox(tot)
            '                    IT = j + 1
            '                Catch ex As Exception
            '                    ' CUANDO YA NO HAY EN SALDOS_IMPORTACION COMIENZO EL INGRESO DE SALDOS NEGATIVOS
            '                    '    MessageBox.Show("La Cantidad es Mayor al Monto Verifique", FACT_strempresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '                    '   Exit Sub
            '                    ADBLNROLOTE = 0
            '                    NITEM = CDbl(CAyuda.ListarDatos("NSP_SELECT_ITEM_TMPGUIADET", correl).Tables(0).Rows(0)(0)) + 1
            '                    If ABoolValorCombo = True Then
            '                        If monval = True Then
            '                            ADblPrecio = ADblCosBas
            '                        Else
            '                            ADblPrecio = ADblCosExt
            '                        End If
            '                    Else
            '                        ADblPrecio = Val(txtprecio.Text)
            '                    End If
            '                    If monval = True Then
            '                        ADblSubTotBas = (totcantidad * ADblPrecio) / (1 + (igv / 100))
            '                        ADblSubTotExt = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) / VCambioVta
            '                        ADblIgvBas = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)
            '                        ADblIgvExt = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)) / VCambioVta
            '                        ADblTotalBas = totcantidad * ADblPrecio
            '                        ADblTotalExt = (totcantidad * ADblPrecio) / VCambioVta
            '                    Else
            '                        ADblSubTotBas = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) * VCambioVta
            '                        ADblSubTotExt = ((totcantidad * ADblPrecio) / (1 + (igv / 100)))
            '                        ADblIgvBas = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)) * VCambioVta
            '                        ADblIgvExt = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100))
            '                        ADblTotalBas = (totcantidad * ADblPrecio) * VCambioVta
            '                        ADblTotalExt = (totcantidad * ADblPrecio)
            '                    End If

            '                    If cbotipodoc.SelectedValue = FACT_CDGUIAVTA Then
            '                        If est = False Then
            '                            SQL = "NSP_UPD_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NROITEM & ",'" & CDZONA & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & ADBLNROLOTE & ""
            '                        Else
            '                            SQL = "NSP_ins_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NITEM & ",'" & CDZONA & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & TipoMed & "," & nimportacion & ",'" & "','" & AStrNomPtoVta & "'," & 0 & "," & 0 & ",'" & Me.TXTLOTE.Text.Trim & "','" & TotB & "'," & xPesoBruto & ""
            '                        End If
            '                    Else
            '                        If est = False Then
            '                            SQL = "NSP_UPD_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NROITEM & ",'" & ALMACEN & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & ADBLNROLOTE & ""
            '                        Else
            '                            SQL = "NSP_ins_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NITEM & ",'" & ALMACEN & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & TipoMed & "," & nimportacion & ",'" & "','" & AStrNomPtoVta & "'," & 0 & "," & 0 & ",'" & Me.TXTLOTE.Text.Trim & "','" & TotB & "'," & xPesoBruto & ""
            '                        End If
            '                    End If



            '                    PROCESO = insert_store_aux(SQL)
            '                    If PROCESO = True Then
            '                        cbomoneda.Enabled = False
            '                    End If
            '                    'status = insert(totcantidad, 0)
            '                    SQL = "SP_insert_TMP_saldosimportacion_negativos '" & txtcodarticulo.Text & "','" & nroptovta & "'," & txtcantidad.Text & "," & ADblCorrela & "," & columna & "," & CONT & ""
            '                    status = FACT_Procesa(SQL)
            '                    Exit Sub
            '                End Try
            '                If CDbl(tot) >= CDbl(totcantidad) Then ' el monto completo 
            '                    If tot <> 0 Then
            '                        SALDO = tot - totcantidad
            '                        NITEM = CDbl(CAyuda.ListarDatos("NSP_SELECT_ITEM_TMPGUIADET", correl).Tables(0).Rows(0)(0)) + 1
            '                        If est = False Then
            '                            CAyuda.Ejecutar("NSP_ins_TMP_DELETESALDOS", NROITEM, txtcodarticulo.Text, nimportacion, totcantidad, FECHARECIB, ADblCorrela)
            '                        Else
            '                            CAyuda.Ejecutar("NSP_ins_TMP_DELETESALDOS", NITEM, txtcodarticulo.Text, nimportacion, totcantidad, FECHARECIB, ADblCorrela)
            '                        End If
            '                        If TIPOVENTA = False Then
            '                            SQL = "SP_UPDATE_TMP_saldos_importacion1 '" & txtcodarticulo.Text & "'," & nimportacion & ", " & columna & "," & SALDO & "," & ADblCorrela & ",'" & nroptovta & "','" & FECHARECIB & "','" & TXTLOTE.Text & "'"
            '                            TmpInsertDatos(SQL)
            '                            Call sp_sube_tmp_saldos_importacion(txtcodarticulo.Text, TXTLOTE.Text, ASTRNROIMPORTACION)
            '                        Else
            '                            SQL = "SP_UPDATE_TMP_saldos_importacion '" & txtcodarticulo.Text & "'," & nimportacion & ", " & columna & "," & SALDO & "," & ADblCorrela & ",'" & nroptovta & "','" & FECHARECIB & "'"
            '                            TmpInsertDatos(SQL)
            '                            Call sp_sube_tmp_saldos_importacion1(txtcodarticulo.Text)
            '                        End If
            '                        GoTo GRABAUNAVUELTA
            '                    End If
            '                Else
            'SIGUEGRABANDO:
            '                    If tot <> 0 Then
            '                        NITEM = CDbl(CAyuda.ListarDatos("NSP_SELECT_ITEM_TMPGUIADET", correl).Tables(0).Rows(0)(0)) + 1

            '                        SALDO = tot - totcantidad

            '                        If SALDO < 0 Then SALDO = 0
            '                        If TotB <> 0 Then
            '                            SaldoB = TotB - TotCantidadB
            '                        Else
            '                            SaldoB = TotCantidadB
            '                        End If

            '                        If TIPOVENTA = False Then
            '                            SQL = "SP_UPDATE_TMP_saldos_importacion1 '" & txtcodarticulo.Text & "'," & nimportacion & ", " & columna & "," & SALDO & "," & ADblCorrela & ",'" & nroptovta & "','" & FECHARECIB & "','" & TXTLOTE.Text & "'"
            '                            TmpInsertDatos(SQL)
            '                            Call sp_sube_tmp_saldos_importacion(txtcodarticulo.Text, TXTLOTE.Text, ASTRNROIMPORTACION)
            '                        Else
            '                            SQL = "SP_UPDATE_TMP_saldos_importacion '" & txtcodarticulo.Text & "'," & nimportacion & ", " & columna & "," & SALDO & "," & ADblCorrela & ",'" & nroptovta & "','" & FECHARECIB & "'"
            '                            TmpInsertDatos(SQL)
            '                            Call sp_sube_tmp_saldos_importacion1(txtcodarticulo.Text)
            '                        End If
            '                        Dim diferencia As Double
            '                        Dim DiferenciaB As Double

            '                        diferencia = tot - totcantidad
            '                        DiferenciaB = TotB - TotCantidadB

            '                        If diferencia < 0 Then diferencia = diferencia * -1
            '                        If DiferenciaB < 0 Then DiferenciaB = DiferenciaB * -1

            '                        TxtCan = diferencia
            '                        TxtCanB = DiferenciaB

            '                        If ABoolValorCombo = True Then
            '                            If monval = True Then
            '                                ADblPrecio = ADblCosBas
            '                            Else
            '                                ADblPrecio = ADblCosExt
            '                            End If
            '                        Else
            '                            ADblPrecio = Val(txtprecio.Text)
            '                        End If

            '                        If monval = True Then
            '                            ADblSubTotBas = (tot * ADblPrecio) / (1 + (igv / 100))
            '                            ADblSubTotExt = ((tot * ADblPrecio) / (1 + (igv / 100))) / VCambioVta
            '                            ADblIgvBas = ((tot * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)
            '                            ADblIgvExt = (((tot * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)) / VCambioVta
            '                            ADblTotalBas = tot * ADblPrecio
            '                            ADblTotalExt = (tot * ADblPrecio) / VCambioVta
            '                        Else
            '                            ADblSubTotBas = ((tot * ADblPrecio) / (1 + (igv / 100))) * VCambioVta
            '                            ADblSubTotExt = ((tot * ADblPrecio) / (1 + (igv / 100)))
            '                            ADblIgvBas = (((tot * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)) * VCambioVta
            '                            ADblIgvExt = (((tot * ADblPrecio) / (1 + (igv / 100))) * (igv / 100))
            '                            ADblTotalBas = (tot * ADblPrecio) * VCambioVta
            '                            ADblTotalExt = (tot * ADblPrecio)
            '                        End If
            '                        If cbotipodoc.SelectedValue = FACT_CDGUIAVTA Then
            '                            If est = False Then
            '                                SQL = "NSP_UPD_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & tot & "," & ADblPrecio & ",'" & CODARTI & "'," & NROITEM & ",'" & CDZONA & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & ADBLNROLOTE & ""
            '                                CAyuda.Ejecutar("NSP_ins_TMP_DELETESALDOS", NROITEM, txtcodarticulo.Text, nimportacion, tot, FECHARECIB, ADblCorrela)
            '                            Else
            '                                CAyuda.Ejecutar("NSP_ins_TMP_DELETESALDOS", NITEM, txtcodarticulo.Text, nimportacion, tot, FECHARECIB, ADblCorrela)
            '                                '7777
            '                                SQL = "NSP_ins_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & tot & "," & ADblPrecio & ",'" & CODARTI & "'," & NITEM & ",'" & CDZONA & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & TipoMed & "," & nimportacion & ",'" & FECHARECIB & "','" & AStrNomPtoVta & "'," & ADblCosBas & "," & ADblCosExt & ",'" & ADBLNROLOTE & "','" & TotB & "'," & xPesoBruto & ""
            '                            End If
            '                        Else
            '                            If est = False Then
            '                                SQL = "NSP_UPD_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & tot & "," & ADblPrecio & ",'" & CODARTI & "'," & NROITEM & ",'" & ALMACEN & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & ADBLNROLOTE & ""
            '                                CAyuda.Ejecutar("NSP_ins_TMP_DELETESALDOS", NROITEM, txtcodarticulo.Text, nimportacion, tot, FECHARECIB, ADblCorrela)
            '                            Else
            '                                CAyuda.Ejecutar("NSP_ins_TMP_DELETESALDOS", NITEM, txtcodarticulo.Text, nimportacion, tot, FECHARECIB, ADblCorrela)
            '                                SQL = "NSP_ins_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & tot & "," & ADblPrecio & ",'" & CODARTI & "'," & NITEM & ",'" & ALMACEN & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & TipoMed & "," & nimportacion & ",'" & FECHARECIB & "','" & AStrNomPtoVta & "'," & ADblCosBas & "," & ADblCosExt & ",'" & ADBLNROLOTE & "','" & TotB & "'," & xPesoBruto & ""
            '                            End If
            '                        End If

            '                        PROCESO = insert_store_aux(SQL)
            '                        'j = j + 1
            '                        GoTo SIGUIENTE
            '                    End If
            '                End If
            'GRABAUNAVUELTA:
            '                If tot <> 0 Then
            '                    'status = insert(totcantidad, nimportacion)
            '                    If ABoolValorCombo = True Then
            '                        If monval = True Then
            '                            ADblPrecio = ADblCosBas
            '                        Else
            '                            ADblPrecio = ADblCosExt
            '                        End If
            '                    Else
            '                        ADblPrecio = Val(txtprecio.Text)
            '                    End If
            '                    If monval = True Then
            '                        ADblSubTotBas = (totcantidad * ADblPrecio) / (1 + (igv / 100))
            '                        ADblSubTotExt = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) / VCambioVta
            '                        ADblIgvBas = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)
            '                        ADblIgvExt = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)) / VCambioVta
            '                        ADblTotalBas = totcantidad * ADblPrecio
            '                        ADblTotalExt = (totcantidad * ADblPrecio) / VCambioVta
            '                    Else
            '                        ADblSubTotBas = ((totcantidad * ADblPrecio) / (1 + (igv / 100))) * VCambioVta
            '                        ADblSubTotExt = ((totcantidad * ADblPrecio) / (1 + (igv / 100)))
            '                        ADblIgvBas = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100)) * VCambioVta
            '                        ADblIgvExt = (((totcantidad * ADblPrecio) / (1 + (igv / 100))) * (igv / 100))
            '                        ADblTotalBas = (totcantidad * ADblPrecio) * VCambioVta
            '                        ADblTotalExt = (totcantidad * ADblPrecio)
            '                    End If

            '                    NITEM = CDbl(CAyuda.ListarDatos("NSP_SELECT_ITEM_TMPGUIADET", correl).Tables(0).Rows(0)(0)) + 1
            '                    If cbotipodoc.SelectedValue = FACT_CDGUIAVTA Then
            '                        If est = False Then
            '                            SQL = "NSP_UPD_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NROITEM & ",'" & CDZONA & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & ADBLNROLOTE & ""
            '                        Else
            '                            SQL = "NSP_ins_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NITEM & ",'" & CDZONA & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & TipoMed & "," & nimportacion & ",'" & FECHARECIB & "','" & AStrNomPtoVta & "'," & ADblCosBas & "," & ADblCosExt & "," & ADBLNROLOTE & ",'" & TotCantidadB & "'," & xPesoBruto & ""
            '                        End If
            '                    Else
            '                        If est = False Then
            '                            SQL = "NSP_UPD_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NROITEM & ",'" & ALMACEN & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & ADBLNROLOTE & ""
            '                        Else
            '                            SQL = "NSP_ins_TMP_GUIADET '" & correl & "'," & igv & ",'" & LIST & "','" & FECHA & "'," & totcantidad & "," & ADblPrecio & ",'" & CODARTI & "'," & NITEM & ",'" & ALMACEN & "'," & ADblSubTotBas & "," & ADblSubTotExt & "," & ADblIgvBas & "," & ADblIgvExt & "," & ADblTotalBas & "," & ADblTotalExt & ",'" & MEDIDA & "','" & EMPRESA & "','" & OBS & "'," & TipoMed & "," & nimportacion & ",'" & FECHARECIB & "','" & AStrNomPtoVta & "'," & ADblCosBas & "," & ADblCosExt & "," & ADBLNROLOTE & ",'" & TotCantidadB & "'," & xPesoBruto & ""
            '                        End If
            '                    End If

            '                    PROCESO = insert_store_aux(SQL)
            '                    'Call LIMPIA_DATOSDOC()
            '                    ' GoTo SIGUEGRABANDO
            '                    '  Call INICIACONTROLNUMBER()
            '                    '  CTRLPRECIO.CtlText = FACT_GFormatodeNumero(0)
            '                    ' CTRLCANTIDAD.CtlText = FACT_GFormatodeNumero(0)
            '                    Exit While
            '                End If
            'SIGUIENTE:
            '                tot2 = tot
            '                tot = 0
            '                MONTOITEMTAR = 0
            '                If CDbl(SALDO) = 0 Then
            '                    j = j + 1
            '                Else
            '                    If CDbl(SALDO) > CDbl(TxtCan) Then
            '                        j = j - 1
            '                    End If
            '                    If j = -1 Then j = 0
            '                End If
            '                '------------------------------------------------------------------------------
            '                totcantidad = CDbl(TxtCan)
            '                TotCantidadB = CDbl(TxtCanB)
            '            End While
            '         Call LIMPIA_DATOSDOC()
            '        CTRLPRECIO.CtlText = FACT_GFormatodeNumero(0)
            '       CTRLCANTIDAD.CtlText = FACT_GFormatodeNumero(0)
        Catch ex As Exception
        End Try
    End Sub

    Sub elimina_item()
        Try
            'Dim FECHARECIB As String
            Dim sql As String
            'Dim CDARTI, NROIMPORTACION, TIPOM, CANTIDAD As String
            Dim TIPOM As String
            Dim ATblImp As New DataTable
            Dim i
            'CDARTI = Trim(grid1.Item(grid1.CurrentRowIndex, 1))
            'NROIMPORTACION = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 1))
            If ABoolValorCombo = True Then
                TIPOM = Trim(grid1.Item(grid1.CurrentRowIndex, 5))
            Else
                TIPOM = Trim(grid1.Item(grid1.CurrentRowIndex, 7))
            End If
            'CANTIDAD = Trim(grid1.Item(grid1.CurrentRowIndex, 4))
            'FECHARECIB = Format(DataGrid1.Item(DataGrid1.CurrentRowIndex, 9), "MM/dd/yyyy")
            CAyuda.Ejecutar("NSP_DEL_TMP_SALDOS_NEGATIVOS", ADblCorrela, CDbl(grid1.Item(grid1.CurrentRowIndex, 0)))
            ATblImp = CAyuda.ListarDatos("NSP_SELECT_TMP_DELETESALDOS", ADblCorrela, CDbl(grid1.Item(grid1.CurrentRowIndex, 0))).Tables(0)
            For i = 0 To ATblImp.Rows.Count - 1
                sql = "SP_UPDATE_TMP_saldos_importacion2 '" & ATblImp.Rows(i)("CODARTI") & "'," & ATblImp.Rows(i)("NROIMPORTACION") & "," & TIPOM & "," & ATblImp.Rows(i)("BULTOS") & "," & ADblCorrela & ",'" & NROPTOVTA & "','" & ATblImp.Rows(i)("FRECIBO") & "'"
                TmpInsertDatos(sql)
                CAyuda.Ejecutar("NSP_DEL_TMP_DELETESALDOS", ADblCorrela, CDbl(grid1.Item(grid1.CurrentRowIndex, 0)))
            Next
            If TIPOVENTA = False Then
                Call sp_sube_tmp_saldos_importacion(grid1.Item(grid1.CurrentRowIndex, 1), grid1.Item(grid1.CurrentRowIndex, 6), ASTRNROIMPORTACION)
            Else
                Call sp_sube_tmp_saldos_importacion1(txtcodarticulo.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub CargarMoneda()
        'conecta("select codmon from tipopre where codtipopre='" & Me.cbotipopre.SelectedValue.ToString() & "' and codempresa='" & codempresa & "' and estado=0", "id")
        'If ds.Tables("id").Rows.Count > 0 Then
        '    moneda = Trim(ds.Tables("id").Rows(0)(0))
        'End If
        moneda = FACT_CDMONEDA.Trim

        Conecta("select cdmonbase,porcenigv from configsis where cod_empresa='" & codempresa & "'", "mon")
        If ds.Tables("mon").Rows.Count > 0 Then

            If Trim(ds.Tables("mon").Rows(0)(0)) = moneda.Trim Then
                monval = True
            Else
                monval = False
            End If
            LBLIGV.Text = ds.Tables("mon").Rows(0)(1)
            cargagrilla()
        End If
    End Sub

    Private Sub txtlote_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTLOTE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcodarticulo.Focus()
        End If
    End Sub

    Private Sub cmbalmllegada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbalmllegada.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TXTLOTE.Focus()
        End If
    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            Me.txtprecio.Focus()
        End If
        If Keyascii = 13 Then
            If cbounidadventa.Visible = False Then
                If GValidarVacios(txtprecio.Text) <> 0 Then
                    'IngresaVaolGrilla()
                    txtcantidad.Focus()
                End If
            Else
                cbounidadventa.Focus()
            End If
        End If
    End Sub

    Private Sub txtboleta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboleta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbomoneda.Focus()
        End If
    End Sub
    Private Sub TXTBULTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTBULTO.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))

        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            Me.TXTBULTO.Focus()
        End If
        If Keyascii = 13 Then
            If cbounidadventa.Visible = False Then
                If txtprecio.Enabled = False Then
                    'IngresaVaolGrilla()
                    txtcodarticulo.Focus()
                Else
                    If txtprecio.Visible = True Then
                        If Len(Me.TXTBULTO.Text.Trim) = 0 Then
                            Me.TXTBULTO.Text = "0"
                        End If
                        txtprecio.Focus()
                    Else
                        'IngresaVaolGrilla()
                        txtcantidad.Focus()
                    End If
                End If
            Else
                If ABOOLEDITPRECIO Then
                    txtcantidad.Focus()
                Else
                    cbounidadventa.Focus()
                End If
            End If
        End If
    End Sub
    Sub sp_sube_tmp_saldos_importacion1(ByVal Codarticulo As String)
        Dim sql As String
        sql = "sp_sube_tmp_saldos_importacion '" & Trim(Codarticulo) & "'," & ADblCorrela & ",'" & NROPTOVTA & "'"
        'FACT_Cargagrid(DataGrid1, sql)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtnumeroguia.Enabled = True
            txtnumeroguia.ReadOnly = False
            ' txtnumeroguia2.Enabled = True
            ' txtnumeroguia2.ReadOnly = False
        Else
            txtnumeroguia.Text = CAyuda.ListarDatos("OBTIENE_CORRELATIVO_GUIA_PROC", NROPTOVTA.ToString.Trim).Tables(0).Rows(0)(0)
            txtnumeroguia2.Text = Strings.Left(Strings.Right("000" + txtnumeroguia.Text, 10), 3)
            txtnumeroguia.Text = Strings.Right("000" + txtnumeroguia.Text, 7)
            txtnumeroguia.ReadOnly = True
            txtnumeroguia.Enabled = False
            txtnumeroguia2.ReadOnly = True
            txtnumeroguia2.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked = False Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtcodcliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodcliente.TextChanged

    End Sub

    Private Sub txtdescliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescliente.TextChanged

    End Sub

    Private Sub txtdescliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdireccion.Focus()
        End If
    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged

    End Sub

    Private Sub txtdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbotipodoc.Focus()
        End If
    End Sub

    Private Sub txtruc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtruc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtdescliente.Focus()
        End If
    End Sub

    Private Sub txtnumeroguia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumeroguia.TextChanged

    End Sub

    Private Sub txtnumeroguia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumeroguia.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnumeroguia.Text = Strings.Right("0000000" & txtnumeroguia.Text, 7)
            If CAyuda.ListarDatos("sp_verif_num_guia", txtnumeroguia2.Text + txtnumeroguia.Text).Tables(0).Rows.Count > 0 Then
                MsgBox("El Numero de guia ya existe Verifique", MsgBoxStyle.Information)
                Exit Sub
            End If
            txtcodcliente.Focus()
        End If
    End Sub

    Private Sub cbomoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomoneda.SelectedIndexChanged
        If SW = True Then
            FACT_CDMONEDA = cbomoneda.SelectedValue
            CargarMoneda()
            SIMBOLOS()
        End If
    End Sub
    Sub SIMBOLOS()

        Dim DS As New DataSet
        DS = CAyuda.ListarDatos("SP_SIMB_MONE", Trim(FACT_CDMONEDA))
        FACT_SIMBOLOMON = DS.Tables(0).Rows(0)(0)
        LBL1.Text = FACT_SIMBOLOMON
        LBL2.Text = FACT_SIMBOLOMON
        LBL3.Text = FACT_SIMBOLOMON

        DS = Nothing
        'SQL = "select simbolo from moneda where codmon=(select CDMONEXTR from configsis where COD_EMPRESA='" & codempresa & "')"
        DS = CAyuda.ListarDatos("SP_SIM_EXT", codempresa.Trim)
        FACT_SIMBOLOMONEXTR = DS.Tables(0).Rows(0)(0)

        DS = Nothing
        DS = CAyuda.ListarDatos("SP_CAMBIODELDIA", codempresa.Trim)
        VCambioVta = DS.Tables(0).Rows(0)(0)
        txtcambio.Text = FACT_GFormatodeNumero(CDbl(VCambioVta))
    End Sub
    Private Sub cbomoneda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbomoneda.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If SW = True Then
                FACT_CDMONEDA = cbomoneda.SelectedValue
                CargarMoneda()
                SIMBOLOS()
            End If
            DateTimePicker1.Focus()
        End If
    End Sub
    Private Sub txtnumeroguia2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumeroguia2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnumeroguia2.Text = Strings.Right("000" & txtnumeroguia2.Text, 3)
        End If
    End Sub
    Private Sub txtnumoc1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumoc1.LostFocus
        txtnumoc1.Text = Strings.Right("000" & txtnumoc1.Text.Trim, 3)
    End Sub
    Private Sub txtnumoc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumoc1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtnumoc.Focus()
        End If
    End Sub
    Private Sub txtnumoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumoc.LostFocus
        txtnumoc.Text = Strings.Right("0000000" & txtnumoc.Text.Trim, 7)
    End Sub
    Private Sub TxtPesBru_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPesBru.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Call IngresaVaolGrilla()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Private Sub txtcantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Dim PesoBruto As Double = 0
            'Dim Tara As Double = 0
            'Dim TblTara As New DataTable

            'TblTara = CAyuda.ListarDatos("USP_PRESENTACION_ARTI", Me.txtcodarticulo.Text.Trim).Tables(0)
            'If TblTara.Rows.Count = 1 Then
            '    With TblTara
            '        Tara = CDbl(.Rows(0).Item("TARA"))
            '        PesoBruto = CDbl(Me.txtcantidad.Text.Trim) + (CDbl(Me.TXTBULTO.Text.Trim) * Tara)
            '        Me.TxtPesBru.Text = PesoBruto
            '    End With
            'End If
            'TblTara.Dispose()
            'TblTara = Nothing
            Try
                Call IngresaVaolGrilla()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'Me.TxtPesBru.Focus()
        End If


    End Sub
    Private Sub TxtPesBru_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPesBru.KeyPress
        If Not IsNumeric(TxtPesBru.Text) Then
            TxtPesBru.Text = "0.00"
            MsgBox("No se admiten puntos(.) antes del número", MsgBoxStyle.Exclamation)
            TxtPesBru.Focus()
            Exit Sub
        End If
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            Me.txtcantidad.Focus()
        End If
    End Sub
    Private Sub BtnTransferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTransferencia.Click
        ' CAyuda.CargarDataCombo(calmacen, "Nsp_select_AlmacenPtovta '" & codempresa & "','" & PtoVta & "'", "codigo", "descripcion")
        'Dim ObjTransFer As New FrmConsultar_SalidaxTransferencia
        'ObjTransFer.ObjetoGuia = Me
        'ObjTransFer.ShowDialog()


    End Sub
    Private Sub txtnumoc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnumoc1.KeyDown
        If e.KeyCode = Keys.F2 Then
            If Me.BtnTransferencia.Visible = True Then
                Call BtnTransferencia_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub ConfigInventario()
        Dim TblConfigInv As New DataTable
        TblConfigInv = CAyuda.ListarDatos("USP_CONFING_INVENTARIO", codempresa.Trim).Tables(0)
        If TblConfigInv.Rows.Count > 0 Then
            With TblConfigInv
                Codigo_SalidaxTransferencia = Trim(.Rows(0).Item("CDSALTRANSF").ToString())
            End With
        End If
        TblConfigInv.Dispose()
        TblConfigInv = Nothing
    End Sub

    Private Sub txtnumoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnumoc.KeyDown
        If e.KeyCode = Keys.F2 Then
            BtnTransferencia_Click(sender, e)
        End If
    End Sub


    Private Sub cbTipoPresent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoPresent.SelectedIndexChanged
        If VentaTrans = True Then
            If TablaComboPresent.Rows.Count > 0 Then
                Dim TabPrecio As New DataTable
                TabPrecio = CAyuda.ListarDatos("SP_BUSC_PRECIOARTFACT", codempresa, Me.cbTipoPresent.SelectedValue.ToString, cbotipopre.SelectedValue.ToString, VCodArti.Trim, txtcodcliente.Text).Tables(0)
                Me.txtprecio.Text = Format(CDbl(TabPrecio.Rows(0)("PRECIOVTA")), "#######0.00")
                txtcantidad.Focus()
            End If
        End If
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub TxtPesBru_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPesBru.TextChanged

    End Sub

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try
            Dim FRMX As New frmgridguia
            FRMX.ShowDialog()
            mostrar()

            btnobs.Enabled = True
            'Call BOTONES(True, False, True, True, True)
            'TXTCODPAIS.ReadOnly = True
        Catch ex As Exception
            MsgBox("no se encontro ninguna fila seleccionada...", MsgBoxStyle.Information, "Nar Gestion")
        End Try

    End Sub

    Public Sub mostrar()
        'TXTCODPAIS.Text = VAR1
        'TXTDESPAIS.Text = VAR2

        If VAR1.Trim = "" Then
            MsgBox("La variable esta vacio ")
        End If



        Dim TabPrecio As New DataTable
        TabPrecio = CAyuda.ListarDatos("SP_BUSC_GUIACAB", codempresa, VAR1).Tables(0)

        If TabPrecio.Rows.Count > 0 Then

            domp = TabPrecio.Rows(0)("do_partida").ToString
            distp = TabPrecio.Rows(0)("distritod").ToString
            provp = TabPrecio.Rows(0)("provinciap").ToString
            domd = TabPrecio.Rows(0)("do_destino").ToString
            distd = TabPrecio.Rows(0)("distritod").ToString
            provd = TabPrecio.Rows(0)("provinciad").ToString
            dest = TabPrecio.Rows(0)("destinatario").ToString
            obv = TabPrecio.Rows(0)("observacion").ToString
            codtransp = TabPrecio.Rows(0)("codtranspor").ToString
            desctransp = TabPrecio.Rows(0)("codtranspor").ToString
            ructransp = TabPrecio.Rows(0)("codtranspor").ToString
            brevete = TabPrecio.Rows(0)("codtranspor").ToString
            marca = TabPrecio.Rows(0)("marca").ToString
            placa = TabPrecio.Rows(0)("placa").ToString
            nrocert = TabPrecio.Rows(0)("NRO_INSCR").ToString
            fechatras = TabPrecio.Rows(0)("fec_initrans").ToString
            Chofer = TabPrecio.Rows(0)("DESCONDUCTOR").ToString
            x = TabPrecio.Rows(0)("RUCCLIENTE").ToString
            DepP = TabPrecio.Rows(0)("depP").ToString
            DepP2 = TabPrecio.Rows(0)("depD").ToString
            LicConduc = TabPrecio.Rows(0)("LicConduc").ToString
            txtOrdenDesp.Text = TabPrecio.Rows(0)("NROMOVI").ToString


            txtnumeroguia.Text = TabPrecio.Rows(0)("NROGUIA").ToString
            txtnumeroguia2.Text = Strings.Left(Strings.Right("000" + txtnumeroguia.Text, 10), 3)
            txtnumeroguia.Text = Strings.Right("000" + txtnumeroguia.Text, 7)


            If TabPrecio.Rows(0)("afact").ToString = "True" Then
                rbDespacho.Checked = True
            Else
                rbTraslado.Checked = True
            End If


        End If





    End Sub



    Private Sub txtOrdenDesp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrdenDesp.TextChanged

    End Sub



    Private Sub rbDespacho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDespacho.CheckedChanged

    End Sub



End Class


