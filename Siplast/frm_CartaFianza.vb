'Imports AxShockwaveFlashObjects
Imports System.Data.SqlClient
Public Class frm_CartaFianza
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
    Friend WithEvents cciudad As System.Windows.Forms.ComboBox
    Friend WithEvents txtPTuco As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTurno As System.Windows.Forms.TextBox
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPTotalBobina As System.Windows.Forms.TextBox
    Friend WithEvents txtTPaquete As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaReg As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
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
    Friend WithEvents txtMerma As System.Windows.Forms.TextBox
    Friend WithEvents ckActivar As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtctaBanca As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCodTurno As System.Windows.Forms.TextBox
    Friend WithEvents txt_Importe As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtMaquina As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ctipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LblCostAnt As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cbPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents tarticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtdesarticulo As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnarticulo As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtPTotalProducido As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodProducion As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtConoRb As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtPromoPaq As System.Windows.Forms.TextBox
    Friend WithEvents txtPesoManga As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Txt_Diferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtPesoBolsaT As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtPesoStandarP As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Txt_merma As System.Windows.Forms.TextBox
    Friend WithEvents txtCodBobina1 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtocurrencias As System.Windows.Forms.TextBox
    Friend WithEvents txtdeperfecto As System.Windows.Forms.TextBox
    Friend WithEvents txt_Muestra As System.Windows.Forms.TextBox
    Friend WithEvents txt_Hora As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents dtpfechaRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtCodBobina2 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CartaFianza))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.dtpFechaVenc = New System.Windows.Forms.DateTimePicker
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtCodBobina2 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.dtpfechaRecepcion = New System.Windows.Forms.DateTimePicker
        Me.Label38 = New System.Windows.Forms.Label
        Me.txt_Muestra = New System.Windows.Forms.TextBox
        Me.txt_Hora = New System.Windows.Forms.TextBox
        Me.dgCuotaLinea = New System.Windows.Forms.DataGrid
        Me.txtCodProducion = New System.Windows.Forms.TextBox
        Me.cbAlmacen = New System.Windows.Forms.ComboBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.LblCostAnt = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.cbPresentacion = New System.Windows.Forms.ComboBox
        Me.tarticulo = New System.Windows.Forms.TextBox
        Me.txtdesarticulo = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.btnarticulo = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.ctipodoc = New System.Windows.Forms.ComboBox
        Me.txt_Importe = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtMaquina = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCodTurno = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtpFechaReg = New System.Windows.Forms.DateTimePicker
        Me.txtPTotalBobina = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTurno = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtLote = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtocurrencias = New System.Windows.Forms.TextBox
        Me.txtdeperfecto = New System.Windows.Forms.TextBox
        Me.txtCodBobina1 = New System.Windows.Forms.TextBox
        Me.Txt_merma = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Txt_Diferencia = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtPesoBolsaT = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtPesoStandarP = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtPromoPaq = New System.Windows.Forms.TextBox
        Me.txtPesoManga = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtConoRb = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtMerma = New System.Windows.Forms.TextBox
        Me.txtTPaquete = New System.Windows.Forms.TextBox
        Me.txtPTotalProducido = New System.Windows.Forms.TextBox
        Me.txtPTuco = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtctaBanca = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtNropedido = New System.Windows.Forms.TextBox
        Me.cciudad = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgCuotasLinea = New System.Windows.Forms.DataGrid
        Me.TablaEstiloCuotaLinea = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.btnAñadir = New System.Windows.Forms.Button
        Me.BtnQuitarCuota = New System.Windows.Forms.Button
        Me.lbLinea = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtLinea = New System.Windows.Forms.TextBox
        Me.btnBuscarLinea = New System.Windows.Forms.Button
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgCuotasLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(979, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(102, 218)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'Button3
        '
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(12, 98)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "&Eliminar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnreporte.Location = New System.Drawing.Point(12, 147)
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
        Me.BTNCANCELAR.Location = New System.Drawing.Point(12, 120)
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
        Me.BTNCERRAR.Location = New System.Drawing.Point(12, 174)
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
        Me.BTNELIMINAR.Location = New System.Drawing.Point(712, 131)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNELIMINAR.TabIndex = 12
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.dtpFechaVenc)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.txtCodBobina2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.dtpfechaRecepcion)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.txt_Muestra)
        Me.GroupBox1.Controls.Add(Me.txt_Hora)
        Me.GroupBox1.Controls.Add(Me.dgCuotaLinea)
        Me.GroupBox1.Controls.Add(Me.txtCodProducion)
        Me.GroupBox1.Controls.Add(Me.cbAlmacen)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.LblCostAnt)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.cbPresentacion)
        Me.GroupBox1.Controls.Add(Me.tarticulo)
        Me.GroupBox1.Controls.Add(Me.txtdesarticulo)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.btnarticulo)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.ctipodoc)
        Me.GroupBox1.Controls.Add(Me.txt_Importe)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtMaquina)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCodTurno)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaReg)
        Me.GroupBox1.Controls.Add(Me.txtPTotalBobina)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTurno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1104, 572)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(267, 171)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(103, 13)
        Me.Label43.TabIndex = 142
        Me.Label43.Text = "Fecha Vencimiento :"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaVenc
        '
        Me.dtpFechaVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVenc.Location = New System.Drawing.Point(374, 166)
        Me.dtpFechaVenc.Name = "dtpFechaVenc"
        Me.dtpFechaVenc.Size = New System.Drawing.Size(87, 21)
        Me.dtpFechaVenc.TabIndex = 141
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(47, 146)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(56, 13)
        Me.Label41.TabIndex = 138
        Me.Label41.Text = "Comision :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodBobina2
        '
        Me.txtCodBobina2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodBobina2.Location = New System.Drawing.Point(106, 144)
        Me.txtCodBobina2.MaxLength = 1000
        Me.txtCodBobina2.Name = "txtCodBobina2"
        Me.txtCodBobina2.Size = New System.Drawing.Size(98, 21)
        Me.txtCodBobina2.TabIndex = 137
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(225, 222)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 26)
        Me.Button4.TabIndex = 135
        Me.Button4.Text = "Añadir"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(225, 256)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 26)
        Me.Button5.TabIndex = 136
        Me.Button5.Text = "Quitar"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(986, 234)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(50, 13)
        Me.Label40.TabIndex = 133
        Me.Label40.Text = "Muestra:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(37, 248)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(49, 13)
        Me.Label39.TabIndex = 132
        Me.Label39.Text = "Importe:"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpfechaRecepcion
        '
        Me.dtpfechaRecepcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaRecepcion.Location = New System.Drawing.Point(88, 222)
        Me.dtpfechaRecepcion.Name = "dtpfechaRecepcion"
        Me.dtpfechaRecepcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpfechaRecepcion.Size = New System.Drawing.Size(80, 20)
        Me.dtpfechaRecepcion.TabIndex = 131
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(45, 225)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 13)
        Me.Label38.TabIndex = 130
        Me.Label38.Text = "Fecha:"
        '
        'txt_Muestra
        '
        Me.txt_Muestra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Muestra.Location = New System.Drawing.Point(1043, 229)
        Me.txt_Muestra.MaxLength = 150
        Me.txt_Muestra.Name = "txt_Muestra"
        Me.txt_Muestra.Size = New System.Drawing.Size(86, 21)
        Me.txt_Muestra.TabIndex = 128
        '
        'txt_Hora
        '
        Me.txt_Hora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Hora.Location = New System.Drawing.Point(88, 245)
        Me.txt_Hora.MaxLength = 150
        Me.txt_Hora.Name = "txt_Hora"
        Me.txt_Hora.Size = New System.Drawing.Size(86, 21)
        Me.txt_Hora.TabIndex = 127
        '
        'dgCuotaLinea
        '
        Me.dgCuotaLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCuotaLinea.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgCuotaLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCuotaLinea.DataMember = ""
        Me.dgCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotaLinea.Location = New System.Drawing.Point(34, 286)
        Me.dgCuotaLinea.Name = "dgCuotaLinea"
        Me.dgCuotaLinea.ReadOnly = True
        Me.dgCuotaLinea.Size = New System.Drawing.Size(457, 115)
        Me.dgCuotaLinea.TabIndex = 5
        '
        'txtCodProducion
        '
        Me.txtCodProducion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodProducion.Location = New System.Drawing.Point(487, 24)
        Me.txtCodProducion.MaxLength = 4
        Me.txtCodProducion.Name = "txtCodProducion"
        Me.txtCodProducion.Size = New System.Drawing.Size(100, 21)
        Me.txtCodProducion.TabIndex = 106
        Me.txtCodProducion.Visible = False
        '
        'cbAlmacen
        '
        Me.cbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAlmacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAlmacen.Location = New System.Drawing.Point(984, 417)
        Me.cbAlmacen.Name = "cbAlmacen"
        Me.cbAlmacen.Size = New System.Drawing.Size(238, 22)
        Me.cbAlmacen.TabIndex = 102
        Me.cbAlmacen.Visible = False
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(259, 8)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(85, 30)
        Me.btnbuscar.TabIndex = 18
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(917, 420)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 14)
        Me.Label28.TabIndex = 101
        Me.Label28.Text = "Almacen: "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label28.Visible = False
        '
        'LblCostAnt
        '
        Me.LblCostAnt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LblCostAnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCostAnt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCostAnt.Location = New System.Drawing.Point(589, 423)
        Me.LblCostAnt.Name = "LblCostAnt"
        Me.LblCostAnt.Size = New System.Drawing.Size(60, 21)
        Me.LblCostAnt.TabIndex = 96
        Me.LblCostAnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(-9, 452)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 97
        Me.Label24.Text = "Presentac :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPresentacion
        '
        Me.cbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPresentacion.Location = New System.Drawing.Point(51, 450)
        Me.cbPresentacion.Name = "cbPresentacion"
        Me.cbPresentacion.Size = New System.Drawing.Size(154, 21)
        Me.cbPresentacion.TabIndex = 98
        '
        'tarticulo
        '
        Me.tarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tarticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarticulo.Location = New System.Drawing.Point(41, 426)
        Me.tarticulo.Name = "tarticulo"
        Me.tarticulo.ReadOnly = True
        Me.tarticulo.Size = New System.Drawing.Size(112, 21)
        Me.tarticulo.TabIndex = 92
        Me.tarticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdesarticulo
        '
        Me.txtdesarticulo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtdesarticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtdesarticulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesarticulo.Location = New System.Drawing.Point(185, 426)
        Me.txtdesarticulo.Name = "txtdesarticulo"
        Me.txtdesarticulo.Size = New System.Drawing.Size(312, 21)
        Me.txtdesarticulo.TabIndex = 94
        Me.txtdesarticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtcantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(281, 450)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.ReadOnly = True
        Me.txtcantidad.Size = New System.Drawing.Size(68, 21)
        Me.txtcantidad.TabIndex = 100
        Me.txtcantidad.Text = "0"
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(205, 452)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 13)
        Me.Label25.TabIndex = 99
        Me.Label25.Text = "Cant.Bobina:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(-8, 428)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 13)
        Me.Label26.TabIndex = 91
        Me.Label26.Text = "Articulo :"
        '
        'btnarticulo
        '
        Me.btnarticulo.ImageIndex = 5
        Me.btnarticulo.ImageList = Me.ImageList1
        Me.btnarticulo.Location = New System.Drawing.Point(159, 420)
        Me.btnarticulo.Name = "btnarticulo"
        Me.btnarticulo.Size = New System.Drawing.Size(30, 21)
        Me.btnarticulo.TabIndex = 93
        Me.btnarticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(511, 428)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 13)
        Me.Label27.TabIndex = 95
        Me.Label27.Text = "Peso Empaque:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(48, 99)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 13)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "Moneda :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctipodoc
        '
        Me.ctipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipodoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipodoc.Location = New System.Drawing.Point(105, 94)
        Me.ctipodoc.Name = "ctipodoc"
        Me.ctipodoc.Size = New System.Drawing.Size(246, 22)
        Me.ctipodoc.TabIndex = 89
        '
        'txt_Importe
        '
        Me.txt_Importe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Importe.Location = New System.Drawing.Point(105, 120)
        Me.txt_Importe.MaxLength = 1000
        Me.txt_Importe.Name = "txt_Importe"
        Me.txt_Importe.Size = New System.Drawing.Size(100, 21)
        Me.txt_Importe.TabIndex = 88
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(51, 123)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(52, 13)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "Importe :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(59, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 13)
        Me.Label21.TabIndex = 86
        Me.Label21.Text = "Banco :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMaquina
        '
        Me.txtMaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaquina.Location = New System.Drawing.Point(105, 69)
        Me.txtMaquina.MaxLength = 15
        Me.txtMaquina.Name = "txtMaquina"
        Me.txtMaquina.Size = New System.Drawing.Size(100, 21)
        Me.txtMaquina.TabIndex = 85
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 5
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(996, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 23)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "..."
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(263, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Beneficiario :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodTurno
        '
        Me.txtCodTurno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodTurno.Location = New System.Drawing.Point(335, 40)
        Me.txtCodTurno.MaxLength = 30
        Me.txtCodTurno.Name = "txtCodTurno"
        Me.txtCodTurno.Size = New System.Drawing.Size(291, 21)
        Me.txtCodTurno.TabIndex = 82
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(995, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 23)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFechaReg
        '
        Me.dtpFechaReg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReg.Location = New System.Drawing.Point(374, 137)
        Me.dtpFechaReg.Name = "dtpFechaReg"
        Me.dtpFechaReg.Size = New System.Drawing.Size(87, 21)
        Me.dtpFechaReg.TabIndex = 71
        '
        'txtPTotalBobina
        '
        Me.txtPTotalBobina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPTotalBobina.Location = New System.Drawing.Point(105, 168)
        Me.txtPTotalBobina.MaxLength = 150
        Me.txtPTotalBobina.Name = "txtPTotalBobina"
        Me.txtPTotalBobina.Size = New System.Drawing.Size(99, 21)
        Me.txtPTotalBobina.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Total Gastos Anual :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(294, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Fecha Fianza :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTurno
        '
        Me.txtTurno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTurno.Location = New System.Drawing.Point(104, 42)
        Me.txtTurno.MaxLength = 15
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Size = New System.Drawing.Size(100, 21)
        Me.txtTurno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N°C Fianza :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(1255, 547)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(35, 13)
        Me.Label42.TabIndex = 140
        Me.Label42.Text = "Lote :"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLote
        '
        Me.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLote.Location = New System.Drawing.Point(1295, 544)
        Me.txtLote.MaxLength = 11
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(77, 21)
        Me.txtLote.TabIndex = 139
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(1530, 326)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 13)
        Me.Label37.TabIndex = 126
        Me.Label37.Text = "Ocurrencia"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(1514, 270)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 13)
        Me.Label36.TabIndex = 125
        Me.Label36.Text = "Desperfecto"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(1514, 215)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(75, 13)
        Me.Label35.TabIndex = 124
        Me.Label35.Text = "Codigo Bobina"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtocurrencias
        '
        Me.txtocurrencias.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtocurrencias.Location = New System.Drawing.Point(1394, 342)
        Me.txtocurrencias.Multiline = True
        Me.txtocurrencias.Name = "txtocurrencias"
        Me.txtocurrencias.Size = New System.Drawing.Size(368, 45)
        Me.txtocurrencias.TabIndex = 123
        '
        'txtdeperfecto
        '
        Me.txtdeperfecto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdeperfecto.Location = New System.Drawing.Point(1394, 286)
        Me.txtdeperfecto.Multiline = True
        Me.txtdeperfecto.Name = "txtdeperfecto"
        Me.txtdeperfecto.Size = New System.Drawing.Size(368, 45)
        Me.txtdeperfecto.TabIndex = 122
        '
        'txtCodBobina1
        '
        Me.txtCodBobina1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBobina1.Location = New System.Drawing.Point(1394, 226)
        Me.txtCodBobina1.Multiline = True
        Me.txtCodBobina1.Name = "txtCodBobina1"
        Me.txtCodBobina1.Size = New System.Drawing.Size(368, 45)
        Me.txtCodBobina1.TabIndex = 121
        '
        'Txt_merma
        '
        Me.Txt_merma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_merma.Location = New System.Drawing.Point(1295, 520)
        Me.Txt_merma.MaxLength = 150
        Me.Txt_merma.Name = "Txt_merma"
        Me.Txt_merma.Size = New System.Drawing.Size(77, 21)
        Me.Txt_merma.TabIndex = 120
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(1231, 526)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(60, 13)
        Me.Label34.TabIndex = 119
        Me.Label34.Text = "% Merma :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txt_Diferencia
        '
        Me.Txt_Diferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Diferencia.Location = New System.Drawing.Point(1295, 497)
        Me.Txt_Diferencia.MaxLength = 150
        Me.Txt_Diferencia.Name = "Txt_Diferencia"
        Me.Txt_Diferencia.Size = New System.Drawing.Size(77, 21)
        Me.Txt_Diferencia.TabIndex = 118
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(1209, 501)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(83, 13)
        Me.Label33.TabIndex = 117
        Me.Label33.Text = "Diferencia(KG) :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPesoBolsaT
        '
        Me.txtPesoBolsaT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoBolsaT.Location = New System.Drawing.Point(1370, 473)
        Me.txtPesoBolsaT.MaxLength = 150
        Me.txtPesoBolsaT.Name = "txtPesoBolsaT"
        Me.txtPesoBolsaT.Size = New System.Drawing.Size(86, 21)
        Me.txtPesoBolsaT.TabIndex = 116
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(1122, 478)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(245, 13)
        Me.Label32.TabIndex = 115
        Me.Label32.Text = "Peso Bolsa Terminado( sin cono y empaque)(KG) :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPesoStandarP
        '
        Me.txtPesoStandarP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoStandarP.Location = New System.Drawing.Point(1295, 452)
        Me.txtPesoStandarP.MaxLength = 150
        Me.txtPesoStandarP.Name = "txtPesoStandarP"
        Me.txtPesoStandarP.Size = New System.Drawing.Size(77, 21)
        Me.txtPesoStandarP.TabIndex = 114
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(1149, 457)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(142, 13)
        Me.Label31.TabIndex = 113
        Me.Label31.Text = "Peso Standar Paquete(KG) :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(1158, 423)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(134, 13)
        Me.Label30.TabIndex = 112
        Me.Label30.Text = "Peso Promo Paquete(KG) :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPromoPaq
        '
        Me.txtPromoPaq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPromoPaq.Location = New System.Drawing.Point(1295, 420)
        Me.txtPromoPaq.MaxLength = 150
        Me.txtPromoPaq.Name = "txtPromoPaq"
        Me.txtPromoPaq.ReadOnly = True
        Me.txtPromoPaq.Size = New System.Drawing.Size(77, 21)
        Me.txtPromoPaq.TabIndex = 111
        '
        'txtPesoManga
        '
        Me.txtPesoManga.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPesoManga.Location = New System.Drawing.Point(1295, 392)
        Me.txtPesoManga.MaxLength = 150
        Me.txtPesoManga.Name = "txtPesoManga"
        Me.txtPesoManga.ReadOnly = True
        Me.txtPesoManga.Size = New System.Drawing.Size(77, 21)
        Me.txtPesoManga.TabIndex = 110
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1198, 396)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 13)
        Me.Label15.TabIndex = 109
        Me.Label15.Text = "Peso Manga(KG) :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1155, 371)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Peso Cono Rollobolsa(KG) :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConoRb
        '
        Me.txtConoRb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConoRb.Location = New System.Drawing.Point(1295, 367)
        Me.txtConoRb.MaxLength = 150
        Me.txtConoRb.Name = "txtConoRb"
        Me.txtConoRb.Size = New System.Drawing.Size(77, 21)
        Me.txtConoRb.TabIndex = 107
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1222, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "Merma (KG) :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1205, 317)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Peso Tuco (KG) :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(1125, 264)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(167, 13)
        Me.Label29.TabIndex = 103
        Me.Label29.Text = "Peso Total Producido Terminado :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMerma
        '
        Me.txtMerma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMerma.Location = New System.Drawing.Point(1295, 339)
        Me.txtMerma.MaxLength = 150
        Me.txtMerma.Name = "txtMerma"
        Me.txtMerma.Size = New System.Drawing.Size(77, 21)
        Me.txtMerma.TabIndex = 77
        '
        'txtTPaquete
        '
        Me.txtTPaquete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTPaquete.Location = New System.Drawing.Point(1295, 285)
        Me.txtTPaquete.MaxLength = 150
        Me.txtTPaquete.Name = "txtTPaquete"
        Me.txtTPaquete.Size = New System.Drawing.Size(77, 21)
        Me.txtTPaquete.TabIndex = 69
        '
        'txtPTotalProducido
        '
        Me.txtPTotalProducido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPTotalProducido.Location = New System.Drawing.Point(1295, 259)
        Me.txtPTotalProducido.MaxLength = 150
        Me.txtPTotalProducido.Name = "txtPTotalProducido"
        Me.txtPTotalProducido.Size = New System.Drawing.Size(77, 21)
        Me.txtPTotalProducido.TabIndex = 63
        '
        'txtPTuco
        '
        Me.txtPTuco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPTuco.Location = New System.Drawing.Point(1295, 312)
        Me.txtPTuco.MaxLength = 150
        Me.txtPTuco.Name = "txtPTuco"
        Me.txtPTuco.Size = New System.Drawing.Size(77, 21)
        Me.txtPTuco.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1180, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Paquete (Und) :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(929, 308)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 24)
        Me.CheckBox1.TabIndex = 73
        Me.CheckBox1.Text = "Activo"
        Me.CheckBox1.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(438, 575)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 13)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Licencia :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'txtctaBanca
        '
        Me.txtctaBanca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtctaBanca.Location = New System.Drawing.Point(548, 570)
        Me.txtctaBanca.MaxLength = 150
        Me.txtctaBanca.Name = "txtctaBanca"
        Me.txtctaBanca.Size = New System.Drawing.Size(61, 21)
        Me.txtctaBanca.TabIndex = 79
        Me.txtctaBanca.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(213, 570)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Permiso ntc :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Visible = False
        '
        'TxtNropedido
        '
        Me.TxtNropedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNropedido.Location = New System.Drawing.Point(340, 575)
        Me.TxtNropedido.MaxLength = 150
        Me.TxtNropedido.Name = "TxtNropedido"
        Me.TxtNropedido.Size = New System.Drawing.Size(61, 21)
        Me.TxtNropedido.TabIndex = 75
        Me.TxtNropedido.Text = "0"
        Me.TxtNropedido.Visible = False
        '
        'cciudad
        '
        Me.cciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cciudad.Location = New System.Drawing.Point(605, 581)
        Me.cciudad.Name = "cciudad"
        Me.cciudad.Size = New System.Drawing.Size(159, 21)
        Me.cciudad.TabIndex = 3
        Me.cciudad.Visible = False
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
        'frm_CartaFianza
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.BTNCERRAR
        Me.ClientSize = New System.Drawing.Size(1091, 449)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.txtctaBanca)
        Me.Controls.Add(Me.cciudad)
        Me.Controls.Add(Me.TxtNropedido)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtPTotalProducido)
        Me.Controls.Add(Me.txtPesoStandarP)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtPesoBolsaT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txtPTuco)
        Me.Controls.Add(Me.txtPromoPaq)
        Me.Controls.Add(Me.Txt_Diferencia)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txtPesoManga)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtTPaquete)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Txt_merma)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCodBobina1)
        Me.Controls.Add(Me.txtMerma)
        Me.Controls.Add(Me.txtConoRb)
        Me.Controls.Add(Me.txtdeperfecto)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtocurrencias)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_CartaFianza"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Carta Fianza"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public Sub FORMATO_GRID2()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TablaCuotasLinea.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODPRODUCC"
            .HeaderText = "CODPRODUCC"
            .Width = 0
        End With


        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "FECHA"
            .HeaderText = "FECHA"
            .Width = 100
        End With

        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "HORA"
            .HeaderText = "IMPORTE"
            .Width = 100
        End With

        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "MUESTRA"
            .HeaderText = "MUESTRA"
            .Width = 0
        End With
        dgCuotaLinea.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4})
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


        CAyuda.CargarDataCombo(ctipodoc, "Nsl_selec_moneda '" & codempresa & "'", "Codigo", "Descripcion")

        CAyuda.CargarDataCombo(Me.cbAlmacen, "USP_LLENAR_ALMACEN   '" & codempresa & "'", "Codigo", "Descripcion")

        cbAlmacen.SelectedIndex = 1


    End Sub
    Sub bloquea(ByVal p As Boolean, ByVal p1 As Boolean)



        Button1.Enabled = p1
        Button2.Enabled = p1


        Button4.Enabled = p1
        Button5.Enabled = p1

        btnarticulo.Enabled = p1



        txtTurno.ReadOnly = p
        txtPTuco.ReadOnly = p
        txtPTotalBobina.ReadOnly = p
        txtMerma.ReadOnly = p


        txtctaBanca.Enabled = p1
        cbFuerzaVenta.Enabled = p1
        cbZonaVenta.Enabled = p1
        cciudad.Enabled = p1
        dtpFechaReg.Enabled = p1
        CheckBox1.Enabled = p1

        txtPTotalProducido.ReadOnly = p
        txtTPaquete.ReadOnly = p
        TxtNropedido.ReadOnly = p

        GroupBox5.Enabled = p1





        txtPesoManga.ReadOnly = p1
        txtPromoPaq.ReadOnly = p1
        txtPesoStandarP.ReadOnly = p1
        txtPesoBolsaT.ReadOnly = p1
        Txt_Diferencia.ReadOnly = p1
        Txt_merma.ReadOnly = p1


    End Sub
    Sub INICIALIZA()
        txtTurno.Text = ""
        txtPTuco.Text = ""
        txtPTotalBobina.Text = ""
        txtPTotalProducido.Text = ""
        txtTPaquete.Text = ""
        dtpFechaReg.Value = Date.Now
        TxtNropedido.Text = ""


        txtConoRb.Text = ""
        txtPesoManga.Text = ""
        txtPromoPaq.Text = ""
        txtPesoStandarP.Text = ""
        txtPesoBolsaT.Text = ""
        Txt_Diferencia.Text = ""
        Txt_merma.Text = ""






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


            Call BOTONES(True, False, False, False, True)
        Else
            Call BOTONES(True, False, False, False, True)
        End If
        Call Limpiatextbox(Me)
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

            If txtTurno.Text.Trim.Length = 0 Then
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
            sql = "nsp_dele_CHOFERES '" & txtTurno.Text & "','" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & codempresa & "'"
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
        txtTurno.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        INTFLAGVEND = 1
        txtPTuco.Focus()
        txtPTuco.SelectAll()
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

        'txtCodTurno.ReadOnly = True
        'txtTurno.ReadOnly = True

        'txtCodMaq.ReadOnly = True
        'txtMaquina.ReadOnly = True

        txtcantidad.Text = 0
        txtPTotalProducido.Text = 0
        txtTPaquete.Text = 0
        txtPTuco.Text = 0
        txtMerma.Text = 0
        txtConoRb.Text = 0
        txtPromoPaq.Text = 0
        txtPesoStandarP.Text = 0
        txtPesoBolsaT.Text = 0
        Txt_Diferencia.Text = 0
        Txt_merma.Text = 0
        txtLote.Text = 0
        txtPesoManga.Text = 0



        INTFLAGVEND = 0
        txtTurno.Focus()
        BTNCANCELAR.Enabled = True
        ckActivar.Checked = False


        TablaCuotaslineaVendedor = CAyuda.ListarDatos("NSP_SELECT_RUTA_VENDEDOR", codempresa.Trim, "xxxxxxxxxxxx", "%").Tables(0)
        TablaEstiloCuotaLinea.MappingName = TablaCuotaslineaVendedor.TableName
        TablaEstiloCuotaLinea.GridColumnStyles(0).MappingName = "CODRUTA"
        TablaEstiloCuotaLinea.GridColumnStyles(1).MappingName = "DESCRIPCION"
        dgCuotasLinea.TableStyles.Add(TablaEstiloCuotaLinea)
        dgCuotasLinea.DataSource = TablaCuotaslineaVendedor

        ACT_EVENTOS = 1


        ValorRan()




        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_MUESTREO", 1111111111111111).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID2()

    End Sub
    Dim rand As Integer


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function



    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Call formatotextbox(Me)

        If txtcantidad.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR CANTIDAD PRODUCTO", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
            Exit Sub
        End If

        If txtcantidad.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR CANTIDAD PRODUCTO", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
            Exit Sub
        End If





        If INTFLAGVEND = 0 Then
            ' ''Dim dt As New DataTable
            ' ''dt = CAyuda.ListarDatos("SP_VERIFI_ID_CHOFERES", txtTurno.Text.Trim).Tables(0)
            ' ''If dt.Rows.Count > 0 Then
            ' ''    MsgBox("El código ya existe.", MsgBoxStyle.Information, "Aviso")
            ' ''    Exit Sub
            ' ''End If
            'sql = "NSP_ins_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.SelectedValue.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.cbFuerzaVenta.SelectedValue & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
            Dim RptaTrans As Boolean
            RptaTrans = CAyuda.Ejecutar("NSP_ins_CAJA_FIANZA", codempresa, dtpFechaReg.Value.ToShortDateString, txtTurno.Text.Trim, txtCodTurno.Text.Trim, txtMaquina.Text.Trim, txt_Importe.Text.Trim, ctipodoc.SelectedValue.ToString, tarticulo.Text, txtdesarticulo.Text, LblCostAnt.Text, dtpFechaVenc.Value.ToShortDateString, CInt(txtcantidad.Text), CDbl(txtPTotalBobina.Text), CDbl(txtPTotalProducido.Text), CInt(txtTPaquete.Text), CDbl(txtPTuco.Text), CDbl(txtMerma.Text), CDbl(txtConoRb.Text), CDbl(txtPesoManga.Text), CDbl(txtPromoPaq.Text), CDbl(txtPesoStandarP.Text), CDbl(txtPesoBolsaT.Text), CDbl(Txt_Diferencia.Text), CDbl(Txt_merma.Text), txtCodBobina1.Text, txtdeperfecto.Text, txtocurrencias.Text, txtCodBobina2.Text, txtLote.Text)
            If RptaTrans Then

                Dim TABLE_CODMAX As DataTable

                TABLE_CODMAX = TmpListarDatos("SP_SELECT_CAJA_FIANZA '" & codempresa.Trim & "'")
                Dim CODPRODUCCION As Integer
                If TABLE_CODMAX.Rows.Count > 0 Then
                    CODPRODUCCION = TABLE_CODMAX.Rows(0)(0).ToString
                End If



                Dim RptaTrans1 As Boolean
                RptaTrans1 = CAyuda.Ejecutar("INSERT_FECHA_COBRO", rand, CODPRODUCCION)
                If RptaTrans1 Then

                End If

                MsgBox("SE GUARDO CORRECTAMENTE  ... EL REGISTRO: " & CODPRODUCCION)



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
            RptaTrans = CAyuda.Ejecutar("NSP_UPD_CAJA_FIANZA", txtCodProducion.Text, codempresa, dtpFechaReg.Value.ToShortDateString, txtTurno.Text.Trim, txtCodTurno.Text.Trim, txtMaquina.Text.Trim, txt_Importe.Text.Trim, ctipodoc.SelectedValue.ToString, tarticulo.Text, txtdesarticulo.Text, LblCostAnt.Text, dtpFechaVenc.Value.ToShortDateString, CInt(txtcantidad.Text), CDbl(txtPTotalBobina.Text), CDbl(txtPTotalProducido.Text), CInt(txtTPaquete.Text), CDbl(txtPTuco.Text), CDbl(txtMerma.Text), CDbl(txtConoRb.Text), CDbl(txtPesoManga.Text), CDbl(txtPromoPaq.Text), CDbl(txtPesoStandarP.Text), CDbl(txtPesoBolsaT.Text), CDbl(Txt_Diferencia.Text), CDbl(Txt_merma.Text), txtCodBobina1.Text, txtdeperfecto.Text, txtocurrencias.Text, txtCodBobina2.Text, txtLote.Text)
            'sql = "NSP_upd_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.SelectedValue.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.cbFuerzaVenta.SelectedValue & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
            If RptaTrans Then
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

                Dim RptaTrans1 As Boolean
                RptaTrans1 = CAyuda.Ejecutar("INSERT_FECHA_COBRO", rand, txtCodProducion.Text)
                If RptaTrans1 Then

                End If


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

        txtMerma.Text = ""
        ckActivar.Checked = False



    End Sub

    Sub Eliminar_Nextel()
        Try
            If ACTIVABD = True Then
                CAyuda.Ejecutar(2, "SP_DEL_VENDEDOR", VCODNEXTEL.Trim, txtTurno.Text.Trim)

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
                CAyuda.Ejecutar(2, "SP_N_INS_VENDEDOR", VCODNEXTEL.Trim, txtTurno.Text.Trim, txtPTuco.Text, "", "1234", "0")
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

        Dim FRMX As New FRM_GRIDFIANZA
        FRMX.vie = Me
        FRMX.bol = True
        FRMX.ShowDialog()

        txtTurno.ReadOnly = True


        ValorRan()

        Dim RptaTrans1 As Boolean
        RptaTrans1 = CAyuda.Ejecutar("INSERT_TMP_FECHA_COBRO", rand, txtCodProducion.Text)
        If RptaTrans1 Then

        End If

        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_MUESTREO", rand).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID2()


    End Sub

    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTurno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtPTuco.Focus()
            Me.txtPTuco.SelectAll()
        End If
    End Sub

    Private Sub tvendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTuco.KeyPress
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


    Private Sub cciudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cciudad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtPTotalProducido.Focus()
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
    Private Sub tcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTurno.KeyDown
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

        If txtTurno.Text.Trim = "" Then
            MsgBox("Falta el Codigo del Vendedor..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If Me.TablaCuotasLinea.Rows.Count = 0 Then
            If Me.txtCuota.Text.Trim.Length > 0 Then
                CAyuda.Ejecutar("NSP_INSERT_CUOTAXLINEA_VEND", codempresa, txtTurno.Text.Trim, cbolinea.SelectedValue, cbosublinea.SelectedValue, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, txtTurno.Text.Trim.Trim).Tables(0)
                Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                'FORMATO_GRID()
            End If

        Else
            If Me.txtCuota.Text.Trim.Length > 0 Then
                For cont1 As Integer = 0 To TablaCuotasLinea.Rows.Count - 1
                    If TablaCuotasLinea.Rows(cont1)("CODLINEA").ToString.Trim = Me.txtLinea.Text.Trim Then
                        CAyuda.Ejecutar("NSP_UPDATE_CUOTAXLINEA_VEND", codempresa, txtTurno.Text.Trim, cbolinea.SelectedValue, cbosublinea.SelectedValue, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, txtTurno.Text.Trim.Trim).Tables(0)
                        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                        'FORMATO_GRID()
                        Exit For
                    End If
                    If cont1 = TablaCuotasLinea.Rows.Count - 1 Then
                        CAyuda.Ejecutar("NSP_INSERT_CUOTAXLINEA_VEND", codempresa, txtTurno.Text.Trim, cbolinea.SelectedValue, cbosublinea.SelectedValue, txtCuota.Text.Trim, dtpFecha1.Value.ToShortDateString, dtpFecha2.Value.ToShortDateString)
                        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, txtTurno.Text.Trim.Trim).Tables(0)
                        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
                        'FORMATO_GRID()
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


        If txtTurno.Text.Trim = "" Then
            MsgBox("Falta el Codigo del Vendedor..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TablaCuotasLinea.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar la cuota de la SubCategoria [ " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_CUOTAXLINEA_VEND", codempresa, txtTurno.Text.Trim.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 1).ToString.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim)
            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, txtTurno.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            'FORMATO_GRID()
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

            crRpt.ReportFileName = rutareporte & "RpFianza.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, txtCodProducion.Text)
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

    Private Sub tcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTurno.TextChanged
        If Me.txtTurno.Text.Trim.Length > 0 Then
            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CUOTA_LINEA", codempresa, txtTurno.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        End If
    End Sub




    Private Sub txtDirec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTotalBobina.KeyPress

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



    Private Sub cciudad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cciudad.SelectedIndexChanged

    End Sub

    Private Sub txtPTotalProducido_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPTotalProducido.RightToLeftChanged

    End Sub



    Private Sub txtDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTotalProducido.KeyPress

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



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FRMX As New frmgridturno
        FRMX.ShowDialog()
        mostrart()
        'Call BOTONES(True, False, True, True, True)
        'txtcodmedida.ReadOnly = True
    End Sub


    Public Sub mostrarm()
        txt_Importe.Text = VAR1
        txtMaquina.Text = VAR2


    End Sub

    Public Sub mostrart()
        txtCodTurno.Text = VAR1
        txtTurno.Text = VAR2


    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim FRMX As New frmgridmaquinas
        FRMX.ShowDialog()
        mostrarm()
    End Sub



    Private Sub btnarticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarticulo.Click
        Dim TABLEART As DataTable
        TABLEART = TmpListarDatos("SP_LISTA_ARTICULO_MERC  '" & codempresa & "','" & CDZONA & "','" & 0 & "','" & Trim(cbAlmacen.SelectedValue) & "'")
        If TABLEART.Rows.Count > 0 Then
            Dim ConsArticulo As New FrmListarArticuloMercaderiaP
            ConsArticulo.CDALMACEN = Trim(cbAlmacen.SelectedValue)
            ConsArticulo.Ingreso = Me
            ConsArticulo.ShowDialog()
        Else
            MsgBox("EL ALMACEN NO TIENE ARTICULOS")
            Exit Sub
        End If



        Dim TablaComboPresent As New DataTable
        TablaComboPresent = CAyuda.ListarDatos("NSP_LISTAR_PRESENT_ARTI_INV", codempresa, tarticulo.Text.Trim).Tables(0)
        If TablaComboPresent.Rows.Count = 0 Then
            Exit Sub
        End If
        Me.cbPresentacion.DisplayMember = "DESPRES"
        Me.cbPresentacion.ValueMember = "CODPRES"
        Me.cbPresentacion.DataSource = TablaComboPresent

        If Len(Me.tarticulo.Text.Trim) > 0 Then
            Me.cbPresentacion.Focus()
        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim PROCESO As Boolean
        Dim sql As String
        sql = "nsp_DELE_CAJA_FIANZA '" & txtCodProducion.Text & "','" & codempresa & "'"
        PROCESO = TmpInsertDatos(sql)

        If PROCESO = False Then
            Exit Sub
        Else
            MsgBox("SE ELIMINO CORRECTAMENTE EL  REGISTRO...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If


        BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)


        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_MUESTREO", 1111111111).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID2()



    End Sub

    Private Sub txtPTuco_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPTuco.TextChanged

       

    End Sub

    Private Sub txtMerma_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMerma.KeyPress
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


    Private Sub txtMerma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMerma.TextChanged
      


    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
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

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub txtTPaquete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTPaquete.KeyPress
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

    Private Sub txtTPaquete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTPaquete.TextChanged

       

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesoBolsaT.TextChanged
        
    End Sub

    Private Sub txtConoRb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConoRb.TextChanged

      

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtPesoStandarP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesoStandarP.TextChanged

    End Sub

    Private Sub txtPesoManga_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesoManga.TextChanged


       


    End Sub

    Private Sub txtPTotalProducido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPTotalProducido.TextChanged

    

    End Sub

    Private Sub Txt_Diferencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Diferencia.TextChanged



    End Sub

    Private Sub txtPromoPaq_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPromoPaq.TextChanged

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
     
        CAyuda.Ejecutar("NSP_INSERT_TMP_MUESTREO", rand, Me.dtpfechaRecepcion.Value.ToShortDateString, txt_Hora.Text, txt_Muestra.Text)
        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_MUESTREO", rand).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID2()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
     
        If TablaCuotasLinea.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el muestreo " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_TMP_MUESTREO", Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim)

            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_MUESTREO", rand).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID2()

        End If

    End Sub

    Private Sub txtdeperfecto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdeperfecto.TextChanged

    End Sub

    Private Sub txt_Muestra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Muestra.KeyPress
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

    Private Sub txt_Muestra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Muestra.TextChanged

    End Sub

    Private Sub Txt_merma_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_merma.TextChanged

    End Sub

    Private Sub txtPTotalBobina_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPTotalBobina.TextChanged

    End Sub

    Private Sub txtCodBobina2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodBobina2.KeyPress
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

    Private Sub txtCodBobina2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodBobina2.TextChanged

    End Sub

    Private Sub txt_Importe_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Importe.KeyPress
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

    Private Sub txt_Importe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Importe.TextChanged

    End Sub

    Private Sub txt_Hora_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Hora.KeyPress
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

    Private Sub txt_Hora_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Hora.TextChanged

    End Sub
End Class
