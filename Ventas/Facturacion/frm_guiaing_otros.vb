Imports System.Drawing.Font
Imports System.Data.SqlClient
Public Class frm_guiaing_otros
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
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tmovimiento As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TOBS As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ctipodoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tcodproveedor As System.Windows.Forms.TextBox
    Friend WithEvents tproveedor As System.Windows.Forms.TextBox
    Friend WithEvents btnproveedor As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents calmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tdoc1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tdoc2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfvenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tneto As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ttara As System.Windows.Forms.TextBox
    Friend WithEvents tbruto As System.Windows.Forms.TextBox
    Friend WithEvents tmarca As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdesarticulo As System.Windows.Forms.TextBox
    Friend WithEvents btnarticulo As System.Windows.Forms.Button
    Friend WithEvents tarticulo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    'Friend WithEvents Ds_diferencia_de_reportes1 As mantenimiento.Ds_diferencia_de_reportes
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ttotal As System.Windows.Forms.TextBox
    Friend WithEvents ltotal As System.Windows.Forms.Label
    Friend WithEvents tcosto As System.Windows.Forms.TextBox
    Friend WithEvents lcosto As System.Windows.Forms.Label
    Friend WithEvents ltara As System.Windows.Forms.Label
    Friend WithEvents lbruto As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ctipoprecio As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tumedida As System.Windows.Forms.ComboBox
    Friend WithEvents lttara As System.Windows.Forms.Label
    Friend WithEvents ltbruto As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    'Friend WithEvents DsInventInicial1 As mantenimiento.DsInventInicial
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcambio As System.Windows.Forms.NumericUpDown
    Friend WithEvents ctipocred As System.Windows.Forms.ComboBox
    Friend WithEvents lproveedor As System.Windows.Forms.Label
    Friend WithEvents lcodprov As System.Windows.Forms.Label
    Friend WithEvents ltcred As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents timportacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tlote As System.Windows.Forms.TextBox
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TREF As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboref As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents timport2 As System.Windows.Forms.TextBox
    Friend WithEvents timports As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtDocRef1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents BTNANULAR As System.Windows.Forms.Button
    Friend WithEvents lblnrolote As System.Windows.Forms.Label
    Friend WithEvents txtnrolote As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_guiaing_otros))
        Me.grid1 = New System.Windows.Forms.DataGrid
        'Me.DsInventInicial1 = New mantenimiento.DsInventInicial
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        'Me.Ds_diferencia_de_reportes1 = New mantenimiento.Ds_diferencia_de_reportes
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tmovimiento = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TOBS = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lttara = New System.Windows.Forms.Label
        Me.ltbruto = New System.Windows.Forms.Label
        Me.totneto = New System.Windows.Forms.TextBox
        Me.totbruto = New System.Windows.Forms.TextBox
        Me.tottotal = New System.Windows.Forms.TextBox
        Me.tottara = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDocRef1 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.cboref = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.TREF = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.ctipoprecio = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ctipodoc = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tdoc1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.tdoc2 = New System.Windows.Forms.TextBox
        Me.calmacen = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tcodproveedor = New System.Windows.Forms.TextBox
        Me.lproveedor = New System.Windows.Forms.Label
        Me.tproveedor = New System.Windows.Forms.TextBox
        Me.btnproveedor = New System.Windows.Forms.Button
        Me.lcodprov = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.timportacion = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.BTNREPORTE = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNANULAR = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.tlote = New System.Windows.Forms.TextBox
        Me.ctipocred = New System.Windows.Forms.ComboBox
        Me.ltcred = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtnrolote = New System.Windows.Forms.TextBox
        Me.timport2 = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.tumedida = New System.Windows.Forms.ComboBox
        Me.tcosto = New System.Windows.Forms.TextBox
        Me.lcosto = New System.Windows.Forms.Label
        Me.ttotal = New System.Windows.Forms.TextBox
        Me.ltotal = New System.Windows.Forms.Label
        Me.dtpfvenc = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        Me.tneto = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.ttara = New System.Windows.Forms.TextBox
        Me.ltara = New System.Windows.Forms.Label
        Me.tbruto = New System.Windows.Forms.TextBox
        Me.lbruto = New System.Windows.Forms.Label
        Me.tmarca = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtdesarticulo = New System.Windows.Forms.TextBox
        Me.btnarticulo = New System.Windows.Forms.Button
        Me.tarticulo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.timports = New System.Windows.Forms.TextBox
        Me.lblnrolote = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtcambio = New System.Windows.Forms.NumericUpDown
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.DsInventInicial1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Ds_diferencia_de_reportes1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtcambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.CaptionText = "Registro de Items                                                         [Enter]" & _
        " Modificar - [F3] Eliminar Registro"
        Me.grid1.DataMember = "ds_inventini"
        'Me.grid1.DataSource = Me.DsInventInicial1
        Me.grid1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(16, 200)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(888, 216)
        Me.grid1.TabIndex = 63
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1, Me.DataGridTableStyle2})
        '
        'DsInventInicial1
        '
        'Me.DsInventInicial1.DataSetName = "DsInventInicial"
        'Me.DsInventInicial1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn25})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Dsdifreporte"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Id"
        Me.DataGridTextBoxColumn1.MappingName = "codlinea"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 45
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Código"
        Me.DataGridTextBoxColumn2.MappingName = "idarticulo"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Marca"
        Me.DataGridTextBoxColumn3.MappingName = "codalmacen"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Mercaderia"
        Me.DataGridTextBoxColumn4.MappingName = "desarti"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 280
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Tipo Bulto"
        Me.DataGridTextBoxColumn6.MappingName = "codumed"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 50
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridTextBoxColumn5.MappingName = "ingresos"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Peso Bruto(kg) ."
        Me.DataGridTextBoxColumn7.MappingName = "salidas"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 85
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Tara(kg) ."
        Me.DataGridTextBoxColumn8.MappingName = "ventas"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Peso Neto ."
        Me.DataGridTextBoxColumn9.MappingName = "dev"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 85
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Costo ."
        Me.DataGridTextBoxColumn18.MappingName = "costo"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.ReadOnly = True
        Me.DataGridTextBoxColumn18.Width = 75
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.MappingName = "total"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.ReadOnly = True
        Me.DataGridTextBoxColumn20.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "fecha"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.MappingName = "lote"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.ReadOnly = True
        Me.DataGridTextBoxColumn23.Width = 0
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Nro Import/Compra"
        Me.DataGridTextBoxColumn25.MappingName = "nroimport2"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.ReadOnly = True
        Me.DataGridTextBoxColumn25.Width = 110
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.grid1
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn26})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ds_inventini"
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Id"
        Me.DataGridTextBoxColumn11.MappingName = "iditem"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 50
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Código"
        Me.DataGridTextBoxColumn12.MappingName = "codigo"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 90
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Marca"
        Me.DataGridTextBoxColumn13.MappingName = "marca"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.ReadOnly = True
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Mercaderia"
        Me.DataGridTextBoxColumn14.MappingName = "descripcion"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 260
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Tipo Bulto"
        Me.DataGridTextBoxColumn16.MappingName = "umedida"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.ReadOnly = True
        Me.DataGridTextBoxColumn16.Width = 80
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Cantidad ."
        Me.DataGridTextBoxColumn15.MappingName = "cantidad"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.ReadOnly = True
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Peso Neto ."
        Me.DataGridTextBoxColumn17.MappingName = "costo"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.ReadOnly = True
        Me.DataGridTextBoxColumn17.Width = 90
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Precio ."
        Me.DataGridTextBoxColumn19.MappingName = "igv"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.ReadOnly = True
        Me.DataGridTextBoxColumn19.Width = 90
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.MappingName = "total"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.ReadOnly = True
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn22.MappingName = "fecha"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.ReadOnly = True
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Nro Import/Compra"
        Me.DataGridTextBoxColumn24.MappingName = "lote"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.ReadOnly = True
        Me.DataGridTextBoxColumn24.Width = 0
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Nro Import/Compra"
        Me.DataGridTextBoxColumn26.MappingName = "nroimport2"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.ReadOnly = True
        Me.DataGridTextBoxColumn26.Width = 110
        '
        'Ds_diferencia_de_reportes1
        '
        'Me.Ds_diferencia_de_reportes1.DataSetName = "Ds_diferencia_de_reportes"
        'Me.Ds_diferencia_de_reportes1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(480, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 17)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "Fecha Documento :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(510, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 17)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Nro de Movimiento :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmovimiento
        '
        Me.tmovimiento.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tmovimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tmovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmovimiento.Location = New System.Drawing.Point(638, 14)
        Me.tmovimiento.Name = "tmovimiento"
        Me.tmovimiento.ReadOnly = True
        Me.tmovimiento.Size = New System.Drawing.Size(116, 21)
        Me.tmovimiento.TabIndex = 72
        Me.tmovimiento.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(712, 320)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 17)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Observ :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Visible = False
        '
        'TOBS
        '
        Me.TOBS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TOBS.Location = New System.Drawing.Point(904, 216)
        Me.TOBS.MaxLength = 200
        Me.TOBS.Multiline = True
        Me.TOBS.Name = "TOBS"
        Me.TOBS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TOBS.Size = New System.Drawing.Size(72, 192)
        Me.TOBS.TabIndex = 64
        Me.TOBS.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(904, 224)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 17)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Observaciones :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.lttara)
        Me.GroupBox4.Controls.Add(Me.ltbruto)
        Me.GroupBox4.Controls.Add(Me.totneto)
        Me.GroupBox4.Controls.Add(Me.totbruto)
        Me.GroupBox4.Controls.Add(Me.tottotal)
        Me.GroupBox4.Controls.Add(Me.tottara)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 520)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(944, 40)
        Me.GroupBox4.TabIndex = 74
        Me.GroupBox4.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(761, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 17)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Total  :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(519, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Total Neto(kg) :"
        '
        'lttara
        '
        Me.lttara.AutoSize = True
        Me.lttara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lttara.Location = New System.Drawing.Point(289, 14)
        Me.lttara.Name = "lttara"
        Me.lttara.Size = New System.Drawing.Size(84, 17)
        Me.lttara.TabIndex = 19
        Me.lttara.Text = "Total Tara(kg) :"
        '
        'ltbruto
        '
        Me.ltbruto.AutoSize = True
        Me.ltbruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltbruto.Location = New System.Drawing.Point(60, 14)
        Me.ltbruto.Name = "ltbruto"
        Me.ltbruto.Size = New System.Drawing.Size(91, 17)
        Me.ltbruto.TabIndex = 17
        Me.ltbruto.Text = "Total Bruto (kg) :"
        '
        'totneto
        '
        Me.totneto.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.totneto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.totneto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totneto.Location = New System.Drawing.Point(608, 12)
        Me.totneto.Name = "totneto"
        Me.totneto.ReadOnly = True
        Me.totneto.Size = New System.Drawing.Size(97, 21)
        Me.totneto.TabIndex = 20
        Me.totneto.Text = "0.00"
        Me.totneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'totbruto
        '
        Me.totbruto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.totbruto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totbruto.Location = New System.Drawing.Point(152, 12)
        Me.totbruto.Name = "totbruto"
        Me.totbruto.ReadOnly = True
        Me.totbruto.Size = New System.Drawing.Size(97, 21)
        Me.totbruto.TabIndex = 16
        Me.totbruto.Text = "0.00"
        Me.totbruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tottotal
        '
        Me.tottotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tottotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tottotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tottotal.Location = New System.Drawing.Point(808, 12)
        Me.tottotal.Name = "tottotal"
        Me.tottotal.ReadOnly = True
        Me.tottotal.Size = New System.Drawing.Size(97, 21)
        Me.tottotal.TabIndex = 22
        Me.tottotal.Text = "0.00"
        Me.tottotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tottara
        '
        Me.tottara.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tottara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tottara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tottara.Location = New System.Drawing.Point(376, 12)
        Me.tottara.Name = "tottara"
        Me.tottara.ReadOnly = True
        Me.tottara.Size = New System.Drawing.Size(97, 21)
        Me.tottara.TabIndex = 18
        Me.tottara.Text = "0.00"
        Me.tottara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDocRef1)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.cboref)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.TREF)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.ctipoprecio)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ctipodoc)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tdoc1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tdoc2)
        Me.GroupBox2.Controls.Add(Me.calmacen)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 190)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Ingreso"
        '
        'TxtDocRef1
        '
        Me.TxtDocRef1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDocRef1.Location = New System.Drawing.Point(149, 155)
        Me.TxtDocRef1.MaxLength = 3
        Me.TxtDocRef1.Name = "TxtDocRef1"
        Me.TxtDocRef1.Size = New System.Drawing.Size(48, 21)
        Me.TxtDocRef1.TabIndex = 67
        Me.TxtDocRef1.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(199, 160)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(9, 17)
        Me.Label26.TabIndex = 68
        Me.Label26.Text = "-"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboref
        '
        Me.cboref.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboref.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboref.Location = New System.Drawing.Point(149, 133)
        Me.cboref.Name = "cboref"
        Me.cboref.Size = New System.Drawing.Size(267, 21)
        Me.cboref.TabIndex = 65
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(11, 135)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(128, 17)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "Tipo de Doc Referencia :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TREF
        '
        Me.TREF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TREF.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TREF.Location = New System.Drawing.Point(211, 156)
        Me.TREF.MaxLength = 10
        Me.TREF.Name = "TREF"
        Me.TREF.Size = New System.Drawing.Size(101, 21)
        Me.TREF.TabIndex = 64
        Me.TREF.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 158)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(124, 17)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "Nro Doc de Referencia :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(149, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(267, 21)
        Me.ComboBox1.TabIndex = 61
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(88, 224)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 17)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "Moneda :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Visible = False
        '
        'ctipoprecio
        '
        Me.ctipoprecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipoprecio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipoprecio.Location = New System.Drawing.Point(0, 224)
        Me.ctipoprecio.Name = "ctipoprecio"
        Me.ctipoprecio.Size = New System.Drawing.Size(267, 21)
        Me.ctipoprecio.TabIndex = 54
        Me.ctipoprecio.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Tipo de Ingreso :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ctipodoc
        '
        Me.ctipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipodoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipodoc.Location = New System.Drawing.Point(149, 87)
        Me.ctipodoc.Name = "ctipodoc"
        Me.ctipodoc.Size = New System.Drawing.Size(267, 21)
        Me.ctipodoc.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 17)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Tipo de Documento :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro de Documento :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tdoc1
        '
        Me.tdoc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdoc1.Location = New System.Drawing.Point(149, 110)
        Me.tdoc1.MaxLength = 3
        Me.tdoc1.Name = "tdoc1"
        Me.tdoc1.Size = New System.Drawing.Size(48, 21)
        Me.tdoc1.TabIndex = 3
        Me.tdoc1.Text = ""
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.ImageIndex = 5
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(312, 157)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 62
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(199, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(9, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "-"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tdoc2
        '
        Me.tdoc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdoc2.Location = New System.Drawing.Point(211, 110)
        Me.tdoc2.MaxLength = 7
        Me.tdoc2.Name = "tdoc2"
        Me.tdoc2.Size = New System.Drawing.Size(101, 21)
        Me.tdoc2.TabIndex = 4
        Me.tdoc2.Text = ""
        '
        'calmacen
        '
        Me.calmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.calmacen.Location = New System.Drawing.Point(149, 18)
        Me.calmacen.Name = "calmacen"
        Me.calmacen.Size = New System.Drawing.Size(267, 21)
        Me.calmacen.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(80, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Almacén :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(149, 41)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(267, 21)
        Me.ComboBox2.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Pto Venta :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcodproveedor
        '
        Me.tcodproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodproveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcodproveedor.Location = New System.Drawing.Point(104, 22)
        Me.tcodproveedor.Name = "tcodproveedor"
        Me.tcodproveedor.Size = New System.Drawing.Size(116, 21)
        Me.tcodproveedor.TabIndex = 6
        Me.tcodproveedor.Text = ""
        '
        'lproveedor
        '
        Me.lproveedor.AutoSize = True
        Me.lproveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lproveedor.Location = New System.Drawing.Point(36, 48)
        Me.lproveedor.Name = "lproveedor"
        Me.lproveedor.Size = New System.Drawing.Size(62, 17)
        Me.lproveedor.TabIndex = 2
        Me.lproveedor.Text = "Proveedor :"
        Me.lproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tproveedor
        '
        Me.tproveedor.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tproveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tproveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tproveedor.Location = New System.Drawing.Point(104, 46)
        Me.tproveedor.Name = "tproveedor"
        Me.tproveedor.ReadOnly = True
        Me.tproveedor.Size = New System.Drawing.Size(267, 21)
        Me.tproveedor.TabIndex = 8
        Me.tproveedor.Text = ""
        '
        'btnproveedor
        '
        Me.btnproveedor.ImageIndex = 5
        Me.btnproveedor.ImageList = Me.ImageList1
        Me.btnproveedor.Location = New System.Drawing.Point(221, 22)
        Me.btnproveedor.Name = "btnproveedor"
        Me.btnproveedor.Size = New System.Drawing.Size(32, 23)
        Me.btnproveedor.TabIndex = 7
        Me.btnproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lcodprov
        '
        Me.lcodprov.AutoSize = True
        Me.lcodprov.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcodprov.Location = New System.Drawing.Point(52, 24)
        Me.lcodprov.Name = "lcodprov"
        Me.lcodprov.Size = New System.Drawing.Size(46, 17)
        Me.lcodprov.TabIndex = 1
        Me.lcodprov.Text = "Codigo :"
        Me.lcodprov.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Importación Nro :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.ImageIndex = 5
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(221, 72)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 23)
        Me.Button2.TabIndex = 59
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'timportacion
        '
        Me.timportacion.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.timportacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.timportacion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timportacion.Location = New System.Drawing.Point(104, 72)
        Me.timportacion.Name = "timportacion"
        Me.timportacion.ReadOnly = True
        Me.timportacion.Size = New System.Drawing.Size(120, 21)
        Me.timportacion.TabIndex = 58
        Me.timportacion.Text = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(258, 76)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(118, 16)
        Me.CheckBox1.TabIndex = 56
        Me.CheckBox1.Text = "Con  Importación "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.BTNREPORTE)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.BTNANULAR)
        Me.GroupBox1.Location = New System.Drawing.Point(862, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 208)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'btnmodificar
        '
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.ImageIndex = 2
        Me.btnmodificar.ImageList = Me.ImageList1
        Me.btnmodificar.Location = New System.Drawing.Point(10, 40)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(84, 23)
        Me.btnmodificar.TabIndex = 11
        Me.btnmodificar.Text = "&Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 11
        Me.BTNREPORTE.ImageList = Me.ImageList1
        Me.BTNREPORTE.Location = New System.Drawing.Point(11, 160)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(83, 23)
        Me.BTNREPORTE.TabIndex = 6
        Me.BTNREPORTE.Text = "&Reporte"
        Me.BTNREPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(11, 88)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(11, 184)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(11, 112)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(11, 16)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(83, 23)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(11, 64)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNANULAR
        '
        Me.BTNANULAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNANULAR.ImageIndex = 12
        Me.BTNANULAR.ImageList = Me.ImageList1
        Me.BTNANULAR.Location = New System.Drawing.Point(11, 136)
        Me.BTNANULAR.Name = "BTNANULAR"
        Me.BTNANULAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNANULAR.TabIndex = 2
        Me.BTNANULAR.Text = "&Anular"
        Me.BTNANULAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.CheckBox1)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.tlote)
        Me.GroupBox5.Controls.Add(Me.ctipocred)
        Me.GroupBox5.Controls.Add(Me.ltcred)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.timportacion)
        Me.GroupBox5.Controls.Add(Me.lcodprov)
        Me.GroupBox5.Controls.Add(Me.btnproveedor)
        Me.GroupBox5.Controls.Add(Me.tproveedor)
        Me.GroupBox5.Controls.Add(Me.lproveedor)
        Me.GroupBox5.Controls.Add(Me.tcodproveedor)
        Me.GroupBox5.Location = New System.Drawing.Point(464, 64)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(384, 134)
        Me.GroupBox5.TabIndex = 70
        Me.GroupBox5.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 17)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Nro Lote :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlote
        '
        Me.tlote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tlote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlote.Location = New System.Drawing.Point(104, 96)
        Me.tlote.Name = "tlote"
        Me.tlote.Size = New System.Drawing.Size(112, 21)
        Me.tlote.TabIndex = 64
        Me.tlote.Text = ""
        '
        'ctipocred
        '
        Me.ctipocred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipocred.Location = New System.Drawing.Point(132, 160)
        Me.ctipocred.Name = "ctipocred"
        Me.ctipocred.Size = New System.Drawing.Size(240, 21)
        Me.ctipocred.TabIndex = 59
        Me.ctipocred.Visible = False
        '
        'ltcred
        '
        Me.ltcred.AutoSize = True
        Me.ltcred.Location = New System.Drawing.Point(32, 168)
        Me.ltcred.Name = "ltcred"
        Me.ltcred.Size = New System.Drawing.Size(88, 17)
        Me.ltcred.TabIndex = 60
        Me.ltcred.Text = "Tipo de Crédito :"
        Me.ltcred.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ltcred.Visible = False
        '
        'Button1
        '
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(756, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 67
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtnrolote)
        Me.GroupBox3.Controls.Add(Me.timport2)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.tumedida)
        Me.GroupBox3.Controls.Add(Me.tcosto)
        Me.GroupBox3.Controls.Add(Me.lcosto)
        Me.GroupBox3.Controls.Add(Me.ttotal)
        Me.GroupBox3.Controls.Add(Me.ltotal)
        Me.GroupBox3.Controls.Add(Me.dtpfvenc)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.tneto)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.ttara)
        Me.GroupBox3.Controls.Add(Me.ltara)
        Me.GroupBox3.Controls.Add(Me.tbruto)
        Me.GroupBox3.Controls.Add(Me.lbruto)
        Me.GroupBox3.Controls.Add(Me.tmarca)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtcantidad)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtdesarticulo)
        Me.GroupBox3.Controls.Add(Me.btnarticulo)
        Me.GroupBox3.Controls.Add(Me.tarticulo)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.timports)
        Me.GroupBox3.Controls.Add(Me.lblnrolote)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 416)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(944, 104)
        Me.GroupBox3.TabIndex = 65
        Me.GroupBox3.TabStop = False
        '
        'txtnrolote
        '
        Me.txtnrolote.Location = New System.Drawing.Point(416, 72)
        Me.txtnrolote.Name = "txtnrolote"
        Me.txtnrolote.ReadOnly = True
        Me.txtnrolote.Size = New System.Drawing.Size(88, 21)
        Me.txtnrolote.TabIndex = 43
        Me.txtnrolote.Text = ""
        Me.txtnrolote.Visible = False
        '
        'timport2
        '
        Me.timport2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.timport2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.timport2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timport2.Location = New System.Drawing.Point(80, 72)
        Me.timport2.Name = "timport2"
        Me.timport2.ReadOnly = True
        Me.timport2.Size = New System.Drawing.Size(120, 21)
        Me.timport2.TabIndex = 42
        Me.timport2.Text = ""
        Me.timport2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(10, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 17)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "Nro Import :"
        '
        'tumedida
        '
        Me.tumedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tumedida.DropDownWidth = 160
        Me.tumedida.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tumedida.Location = New System.Drawing.Point(160, 45)
        Me.tumedida.Name = "tumedida"
        Me.tumedida.Size = New System.Drawing.Size(160, 21)
        Me.tumedida.TabIndex = 39
        '
        'tcosto
        '
        Me.tcosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcosto.Location = New System.Drawing.Point(584, 70)
        Me.tcosto.Name = "tcosto"
        Me.tcosto.Size = New System.Drawing.Size(96, 21)
        Me.tcosto.TabIndex = 37
        Me.tcosto.Text = "0"
        Me.tcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tcosto.Visible = False
        '
        'lcosto
        '
        Me.lcosto.AutoSize = True
        Me.lcosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lcosto.Location = New System.Drawing.Point(542, 72)
        Me.lcosto.Name = "lcosto"
        Me.lcosto.Size = New System.Drawing.Size(36, 17)
        Me.lcosto.TabIndex = 38
        Me.lcosto.Text = "Costo:"
        Me.lcosto.Visible = False
        '
        'ttotal
        '
        Me.ttotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ttotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ttotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotal.Location = New System.Drawing.Point(832, 70)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.ReadOnly = True
        Me.ttotal.Size = New System.Drawing.Size(96, 21)
        Me.ttotal.TabIndex = 35
        Me.ttotal.Text = "0"
        Me.ttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttotal.Visible = False
        '
        'ltotal
        '
        Me.ltotal.AutoSize = True
        Me.ltotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltotal.Location = New System.Drawing.Point(792, 72)
        Me.ltotal.Name = "ltotal"
        Me.ltotal.Size = New System.Drawing.Size(37, 17)
        Me.ltotal.TabIndex = 36
        Me.ltotal.Text = "Total :"
        Me.ltotal.Visible = False
        '
        'dtpfvenc
        '
        Me.dtpfvenc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfvenc.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfvenc.Location = New System.Drawing.Point(832, 20)
        Me.dtpfvenc.Name = "dtpfvenc"
        Me.dtpfvenc.Size = New System.Drawing.Size(96, 21)
        Me.dtpfvenc.TabIndex = 10
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(760, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 17)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Fecha Venc :"
        '
        'tneto
        '
        Me.tneto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tneto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tneto.Location = New System.Drawing.Point(832, 45)
        Me.tneto.Name = "tneto"
        Me.tneto.Size = New System.Drawing.Size(96, 21)
        Me.tneto.TabIndex = 13
        Me.tneto.Text = "0"
        Me.tneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(746, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 17)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Peso Neto(kg) :"
        '
        'ttara
        '
        Me.ttara.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ttara.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ttara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttara.Location = New System.Drawing.Point(584, 45)
        Me.ttara.Name = "ttara"
        Me.ttara.ReadOnly = True
        Me.ttara.Size = New System.Drawing.Size(96, 21)
        Me.ttara.TabIndex = 31
        Me.ttara.Text = "0"
        Me.ttara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ltara
        '
        Me.ltara.AutoSize = True
        Me.ltara.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltara.Location = New System.Drawing.Point(520, 47)
        Me.ltara.Name = "ltara"
        Me.ltara.Size = New System.Drawing.Size(58, 17)
        Me.ltara.TabIndex = 30
        Me.ltara.Text = "Tara (kg) :"
        '
        'tbruto
        '
        Me.tbruto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbruto.Location = New System.Drawing.Point(416, 45)
        Me.tbruto.Name = "tbruto"
        Me.tbruto.Size = New System.Drawing.Size(88, 21)
        Me.tbruto.TabIndex = 12
        Me.tbruto.Text = "0"
        Me.tbruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbruto
        '
        Me.lbruto.AutoSize = True
        Me.lbruto.Location = New System.Drawing.Point(328, 47)
        Me.lbruto.Name = "lbruto"
        Me.lbruto.Size = New System.Drawing.Size(86, 17)
        Me.lbruto.TabIndex = 28
        Me.lbruto.Text = "Peso Bruto(kg) :"
        '
        'tmarca
        '
        Me.tmarca.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tmarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tmarca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmarca.Location = New System.Drawing.Point(584, 20)
        Me.tmarca.Name = "tmarca"
        Me.tmarca.ReadOnly = True
        Me.tmarca.Size = New System.Drawing.Size(144, 21)
        Me.tmarca.TabIndex = 27
        Me.tmarca.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(536, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Marca :"
        '
        'txtcantidad
        '
        Me.txtcantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcantidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(80, 45)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(72, 21)
        Me.txtcantidad.TabIndex = 11
        Me.txtcantidad.Text = "0"
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Cantidad :"
        '
        'txtdesarticulo
        '
        Me.txtdesarticulo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtdesarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesarticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesarticulo.Location = New System.Drawing.Point(208, 20)
        Me.txtdesarticulo.Name = "txtdesarticulo"
        Me.txtdesarticulo.ReadOnly = True
        Me.txtdesarticulo.Size = New System.Drawing.Size(328, 21)
        Me.txtdesarticulo.TabIndex = 14
        Me.txtdesarticulo.Text = ""
        '
        'btnarticulo
        '
        Me.btnarticulo.ImageIndex = 5
        Me.btnarticulo.ImageList = Me.ImageList1
        Me.btnarticulo.Location = New System.Drawing.Point(176, 19)
        Me.btnarticulo.Name = "btnarticulo"
        Me.btnarticulo.Size = New System.Drawing.Size(32, 23)
        Me.btnarticulo.TabIndex = 9
        Me.btnarticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tarticulo
        '
        Me.tarticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tarticulo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tarticulo.Location = New System.Drawing.Point(80, 20)
        Me.tarticulo.Name = "tarticulo"
        Me.tarticulo.Size = New System.Drawing.Size(96, 21)
        Me.tarticulo.TabIndex = 8
        Me.tarticulo.Text = ""
        Me.tarticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(27, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Articulo :"
        '
        'timports
        '
        Me.timports.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.timports.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timports.Location = New System.Drawing.Point(200, 72)
        Me.timports.Name = "timports"
        Me.timports.ReadOnly = True
        Me.timports.Size = New System.Drawing.Size(128, 21)
        Me.timports.TabIndex = 41
        Me.timports.Text = ""
        Me.timports.Visible = False
        '
        'lblnrolote
        '
        Me.lblnrolote.AutoSize = True
        Me.lblnrolote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnrolote.Location = New System.Drawing.Point(336, 72)
        Me.lblnrolote.Name = "lblnrolote"
        Me.lblnrolote.Size = New System.Drawing.Size(51, 17)
        Me.lblnrolote.TabIndex = 1
        Me.lblnrolote.Text = "Nro Lote:"
        Me.lblnrolote.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(712, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 17)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "T.C :"
        '
        'txtcambio
        '
        Me.txtcambio.DecimalPlaces = 3
        Me.txtcambio.Location = New System.Drawing.Point(752, 40)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.Size = New System.Drawing.Size(64, 21)
        Me.txtcambio.TabIndex = 78
        Me.txtcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfecha.Location = New System.Drawing.Point(584, 40)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(96, 21)
        Me.dtpfecha.TabIndex = 79
        '
        'frm_guiaing_otros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(978, 568)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tmovimiento)
        Me.Controls.Add(Me.TOBS)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtcambio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grid1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(984, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(984, 600)
        Me.Name = "frm_guiaing_otros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ingresos de Mercaderia"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.DsInventInicial1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ds_diferencia_de_reportes1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.txtcambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public strmarcaing, strtaraimp, estadotransfer As String, arrmedidaing As New ArrayList
    Public bomedidaing, boumedidaing, boestimp As Boolean, shmedidaing, shumedida As Short, correl As String
    Public Destinos As Boolean
    Dim sw As Boolean = False
    Dim CONT As Integer = 0
    Public INICIA As Int16 = 0
    Public Nro_Importacion As String
    Dim valor As Boolean, codmed, CODINGXTRANS, ComIng, IngProcMon, IngAjuste As String
    Dim CONTACOMBO As Integer = 0
    'Dim ObjInter As New ClsInterface
    'Dim ObjJhon As New clsdatos_JHON
    Public OrgMerca As String
    Private Ds_diferencia_de_reportes1 As New DataSet
    Private DsInventInicial1 As New DataSet

    Private Sub BTNCLIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproveedor.Click
        If (bomedidaing = True And boumedidaing = False) Or (bomedidaing = True And boumedidaing = True) Then
            If Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count > 0 Then
                If MessageBox.Show("Tiene mercaderia ingresada con un determinado Proveedor, si cambia el Proveedor tendra que sacarse la mercaderia ingresada ¿Desea realizar esta operación?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    TmpInsertDatos("delete from tmp_movidet where cdcompra='" & correl & "' and codempresa='" & codempresa & "' and cdalmacen='" & calmacen.SelectedValue.ToString & "' and inout=1")
                    Me.Ds_diferencia_de_reportes1.Clear()
                    Me.grid1.Refresh()
                    CONT = 0
                    txtcantidad.Text = 0
                    tbruto.Text = 0
                    ttara.Text = 0
                    tneto.Text = 0
                    tcosto.Text = 0
                    ttotal.Text = 0
                    tarticulo.Text = ""
                    txtdesarticulo.Text = ""
                    tmarca.Text = ""
                Else
                    Exit Sub
                End If
            End If

        ElseIf bomedidaing = False And boumedidaing = True Then
            If Me.DsInventInicial1.Tables(0).Rows.Count > 0 Then
                If MessageBox.Show("Tiene mercaderia ingresada con un determinado Proveedor, si cambia el Proveedor tendra que sacarse la mercaderia ingresada ¿Desea realizar esta operación?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    TmpInsertDatos("delete from tmp_movidet where cdcompra='" & correl & "' and codempresa='" & codempresa & "' and cdalmacen='" & calmacen.SelectedValue.ToString & "' and inout=1")
                    Me.DsInventInicial1.Clear()
                    Me.grid1.Refresh()
                    CONT = 0
                    txtcantidad.Text = 0
                    tbruto.Text = 0
                    ttara.Text = 0
                    tneto.Text = 0
                    tcosto.Text = 0
                    ttotal.Text = 0
                    tarticulo.Text = ""
                    txtdesarticulo.Text = ""
                    tmarca.Text = ""
                Else
                    Exit Sub
                End If
            End If
        End If

        INICIAS = False
        tdoc1.Focus()
        Dim men As New frm_gridproveedor
        men.boingresoprov = True
        men.vie = Me
        men.ShowDialog()
    End Sub
    Public forma As Short
    Public Sub btnarticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnarticulo.Click
        Call Limpia()

        If Trim(ComboBox1.SelectedValue) = IngProcMon Or Trim(Me.ComboBox1.SelectedValue) = IngAjuste Then
            'Dim oBjetoArtiProcMondongo As New FrmArticulosProcMondongo
            ''oBjetoArtiProcMondongo
            'oBjetoArtiProcMondongo.ObjSalMerca = Me
            'oBjetoArtiProcMondongo.ShowDialog()
        Else
            If Button2.Enabled = True Then
                If Me.timportacion.Text.Trim = "" Then
                    MessageBox.Show("Escoja primero la Importación a Ingresar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Button2_Click(sender, e)
                    Exit Sub
                End If
            End If

            If tproveedor.Visible = False Then
                forma = 0
            ElseIf Me.CheckBox1.Checked = True Then
                forma = 1
            Else
                forma = 2
            End If

            INICIAS = False

            Dim men As New frm_grid_articulo_otro

            men.boingresoart = True
            men.vie = Me
            men.ShowDialog()
        End If

        If Len(Me.tarticulo.Text.Trim) = 0 Then
            Me.tarticulo.Focus()
        Else
            Me.txtcantidad.Focus()
        End If
    End Sub

    Public Sub modelo_grilla()
        If (bomedidaing = True And boumedidaing = False) Or (bomedidaing = True And boumedidaing = True) Then
            'Me.grid1.DataSource = Me.Ds_diferencia_de_reportes1.Dsdifreporte
            lbruto.Visible = True
            tbruto.Visible = True
            ltara.Visible = True
            ttara.Visible = True
            ltbruto.Visible = True
            totbruto.Visible = True
            lttara.Visible = True
            tottara.Visible = True
            Me.DataGridTextBoxColumn7.Width = 80
            Me.DataGridTextBoxColumn8.Width = 0
            Me.DataGridTextBoxColumn7.HeaderText = "Peso Bruto(kg)"
            Me.DataGridTextBoxColumn8.HeaderText = "Tara(Kg)"

        ElseIf bomedidaing = False And boumedidaing = True Then
            'Me.grid1.DataSource = Me.DsInventInicial1.ds_inventini
            lbruto.Visible = False
            tbruto.Visible = False
            ltara.Visible = False
            ttara.Visible = False
            ltbruto.Visible = False
            totbruto.Visible = False
            lttara.Visible = False
            tottara.Visible = False
            Me.DataGridTextBoxColumn7.Width = 0
            Me.DataGridTextBoxColumn8.Width = 0
            Me.DataGridTextBoxColumn18.Width = 0
            Me.DataGridTextBoxColumn20.Width = 0
            Me.DataGridTextBoxColumn7.HeaderText = ""
            Me.DataGridTextBoxColumn8.HeaderText = ""
            Me.DataGridTextBoxColumn18.HeaderText = ""
            Me.DataGridTextBoxColumn20.HeaderText = ""

        ElseIf bomedidaing = False And boumedidaing = False Then
            MessageBox.Show("No tiene configurado las Ventas por Medida y UMedida en la Configuración de Inventarios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub
    Private Sub Config_Inventario()
        Dim Tabla As DataTable
        Tabla = CAyuda.ListarDatos("USP_CONFIGINV", codempresa.Trim).Tables(0)
        If Tabla.Rows.Count > 0 Then
            With Tabla.Rows(0)
                CODINGXTRANS = Trim(.Item("CDINGTRANSF").ToString())
                ComIng = Trim(.Item("CODIGO_DOCUMENTO_INGRESO").ToString())
                IngresoxImportacion = Trim(.Item("CDINGIMP").ToString())
                IngProcMon = Trim(.Item("ING_X_PROC_MOND").ToString())
                IngAjuste = Trim(.Item("INGRESO_X_AJUSTE").ToString())
            End With
        End If

        Tabla.Dispose()
        Tabla = Nothing
    End Sub
    Private Sub Carga_Combos()
        CAyuda.CargarDataCombo(ctipodoc, "nsp_sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(cboref, "nsp_sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        'CAyuda.CargarDataCombo(combobox1, "Nsp_Sele_tipomovi '" & CodEmpresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(Me.ComboBox1, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(calmacen, "Nsp_select_Almacen '" & codempresa & "'", "codigo", "descripcion")
        CAyuda.CargarDataCombo(ComboBox2, "Nsp_Sele_tdaptoventa '" & codempresa & "','',''", "NROPTOVTA", "DESPTOVTA")
        CAyuda.CargarDataCombo(ctipoprecio, "nsp_sele_moneda '" & codempresa & "'", "codmon", "dsmoneda")
        CAyuda.CargarDataCombo(ctipocred, "Nsp_sel_TipCredF '" & codempresa & "'", "Codigo", "Descripcion")
    End Sub
    Dim mbase As String, incpeso, incbulto As Double
    Private Sub frm_guiaingmercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TmpInsertDatos("DELETE FROM TMP_MOVIDET WHERE MAQUINA = '" & NROPTOVTA & "' AND CodUsuario = '" & CodUsuario & "'")
        Call Carga_Combos()
        Call Config_Inventario()
        Conecta("select cdmonbase from configsis where cod_empresa='" & codempresa & "'", "codmon")
        If ds.Tables("codmon").Rows.Count > 0 Then
            mbase = Trim(ds.Tables("codmon").Rows(0)(0))
        End If

        Call tcambio()

        Conecta("select medida,umedida,porincpeso,incbulto from configinv where codempresa='" & codempresa & "'", "llena")
        If ds.Tables("llena").Rows.Count > 0 Then
            bomedidaing = ds.Tables("llena").Rows(0)(0)
            boumedidaing = ds.Tables("llena").Rows(0)(1)
            incpeso = ds.Tables("llena").Rows(0)(2)
            incbulto = ds.Tables("llena").Rows(0)(3)

            If bomedidaing = True Then
                shmedidaing = 1
            Else
                shmedidaing = 0
            End If

            If boumedidaing = True Then
                shumedida = 1
            Else
                shumedida = 0
            End If

        Else
            MessageBox.Show("No tiene configurado las Ventas por Medida y UMedida en la Configuración de Inventarios", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        modelo_grilla()

        boestimp = True
        Bloqueatextbox(Me)
        Me.BTNGUARDAR.Enabled = False
        Me.BTNELIMINAR.Enabled = False
        Me.BTNCANCELAR.Enabled = False
        btnmodificar.Enabled = False
        btnarticulo.Enabled = False
        btnproveedor.Enabled = False
        Me.dtpfvenc.Enabled = False
        Me.dtpfecha.Enabled = False
        Me.Button2.Enabled = False
        Me.ComboBox1.Focus()
        calmacen_SelectedIndexChanged(sender, e)
        verifica_valorizado()
        verifica()
        calmacen.SelectedValue = CDZONA
        Me.ctipodoc.SelectedValue = ComIng
        sw = True
        Me.ctipoprecio.SelectedIndex = 1
        Call ComboBox1_SelectedIndexChanged(sender, e)
        cboref.SelectedValue = ComIng
    End Sub
    Private Sub tdoc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdoc1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdoc2.Focus()
        End If
    End Sub
    Private Sub tdoc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdoc2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            INICIAS = True
            cboref.Focus()
        End If
    End Sub
    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtcantidad.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            If IsNumeric(txtcantidad.Text) Then
                tumedida.Focus()
            Else
                MsgBox("No se admiten caracteres en espacios numericos", MsgBoxStyle.Exclamation, "NAR SISTEMAS")

                txtcantidad.Text = 0
                Me.txtcantidad.Focus()
                Me.txtcantidad.SelectAll()
            End If
            'tumedida.Focus()
        End If

    End Sub
    Private Sub tumedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tumedida.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tumedida.Focus()
            If valor = True Then
                Me.ttara.Text = Val(strtaraimp * Me.txtcantidad.Text).ToString("###0.00")
                Me.tbruto.Focus()
                Me.tbruto.SelectAll()
            Else
                Me.tbruto.Text = 0
                Me.tneto.Focus()
                Me.tneto.SelectAll()
            End If
        End If
    End Sub
    Private Sub tbruto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbruto.KeyPress
        Try
            Dim Keyascii As Short = CShort(Asc(e.KeyChar))
            Keyascii = CShort(NumerosDecimales(Keyascii))
            If Keyascii = 0 Then
                e.Handled = True
                MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tbruto.Focus()
            End If

            If Asc(e.KeyChar) = 13 Then
                Me.tneto.Text = Val(Me.tbruto.Text - Me.ttara.Text).ToString("###0.00")
                Me.tneto.Focus()
                Me.tneto.SelectAll()
            End If
        Catch x As Exception
        End Try
    End Sub
    Sub Llena_temp()
        Try
            Dim sql As String
            Dim PROCESO As Boolean

            If Me.tcodproveedor.Text.Trim = "" Or Me.tproveedor.Text.Trim = "" Then
                MessageBox.Show("Ingrese el Proveedor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tcodproveedor.Focus()
                Exit Sub
            ElseIf tdoc1.Text.Trim = "" Or tdoc2.Text = "" Then
                MessageBox.Show("Ingrese el Nro de Documento para poder seguir con el proceso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tdoc1.Focus()
                Exit Sub
            ElseIf tarticulo.Text.Trim = "" Then
                MessageBox.Show("Ingrese el articulo para poder seguir con el proceso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tarticulo.Focus()
                Exit Sub
            ElseIf txtcantidad.Text.Trim = "" Then
                MessageBox.Show("Ingrese la cantidad para poder seguir con el proceso", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtcantidad.Focus()
                Exit Sub
            End If


            If Val(tneto.Text) < 0 Then
                MessageBox.Show("No puede ingresar una cantidad menor a 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tneto.Focus()
                Me.tneto.SelectAll()
                Exit Sub
            End If

            'Me.tbruto.Text = Val(Val(Me.tneto.Text) + Val(Me.ttara.Text)).ToString("###0.00")
            'If Me.txtcantidad.Text.Trim = "" Or Me.txtcantidad.Text = "0" Then
            '    MessageBox.Show("No puedo ingresar 0 o Espacios en Blanco en Cantidad", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            If timportacion.Text.Trim <> "" Then
                Conecta("select saldont,saldobultos,bultos,pesoneto from saldos_importacion where nroimportacion=" & Strings.Left(Me.timportacion.Text.Trim, 6) + Strings.Right(Me.timportacion.Text, 4) & " and codarti='" & Me.tarticulo.Text.Trim & "' and cdalmacen is null", "busca")

                If ds.Tables("busca").Rows.Count > 0 Then
                    'If tneto.Text > Val(ds.Tables("busca").Rows(0)(0) + (Val(incpeso / 100) * ds.Tables("busca").Rows(0)(3))) Then
                    '    MessageBox.Show("El Peso Neto no puede ser mayor al que se tiene en Stock", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    tneto.Focus()
                    '    tneto.SelectAll()
                    '    Exit Sub
                    'End If

                    'If txtcantidad.Text > Val(ds.Tables("busca").Rows(0)(1) + incbulto) Then
                    '    MessageBox.Show("La Cantidad de Bultos no puede ser mayor al que se tiene en Stock", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '    txtcantidad.Focus()
                    '    txtcantidad.SelectAll()
                    '    Exit Sub
                    'End If
                End If
            End If


            If boestimp = True Then
                Dim NroImportacion As Long
                'NroImportacion = Val(Mid(Me.timport2.Text.Trim, 1, 6) + Mid(Me.timport2.Text.Trim, 8, 4))
                NroImportacion = Val(Me.timports.Text.Trim)
                Conecta("SELECT * FROM TMP_MOVIDET WHERE CDARTICULO = '" & Me.tarticulo.Text.Trim & "' AND CORRNBR = " & Me.tmovimiento.Text.Trim & " AND INOUT = 1 AND NROIMPORTACION = " & NroImportacion & " AND LOTE = '" & Me.tlote.Text.Trim & "'", "pa")
                If ds.Tables("pa").Rows.Count > 0 Then
                    MessageBox.Show("El Item ya Fue Ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call Limpia()
                    Me.tarticulo.Focus()
                    Exit Sub
                End If

                CONT += 1
                If Me.timports.Visible = True Then
                    If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                        If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                            If Trim(Me.ComboBox1.SelectedValue) = "09" Then
                                'Nro_Importacion = timport2.Text
                                Dim pos As Integer
                                pos = CInt(Nro_Importacion)
                                Dim j As String
                                j = CStr(CStr(pos) + CStr(Date.Now.Year.ToString))
                                'Conecta("SELECT max(cast(LEFT(CAST(NROIMPORTACION AS VARCHAR),LEN(CAST(NROIMPORTACION AS VARCHAR))-4)as integer))+1 AS e   FROM MOVIDET  where cast(LEN(CAST(NROIMPORTACION AS VARCHAR))as integer)>3", "DataSet")
                                'If ds.Tables("DataSet").Rows.Count = 1 Then

                                '    Nro_Importacion = CStr(ds.Tables("DataSet").Rows(0).Item(0))
                                '    If CInt(Len(Nro_Importacion)) = 1 Then
                                '        Nro_Importacion = "00" & Nro_Importacion & Date.Now.Year.ToString
                                '    ElseIf CInt(Len(Nro_Importacion)) = 2 Then
                                '        Nro_Importacion = "0" & Nro_Importacion & Date.Now.Year.ToString
                                '    Else
                                '        Nro_Importacion = Nro_Importacion & Date.Now.Year.ToString
                                '    End If
                                '    'MsgBox(Nro_Importacion.ToString)
                                'End If
                                sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & CDbl(tcosto.Text.Trim) & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & ",'" & j.ToString.ToUpper & "','" & timport2.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                            Else
                                sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & CDbl(tcosto.Text.Trim) & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & ",'" & timports.Text.Trim.ToUpper & "','" & timport2.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                            End If


                        Else
                            sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & CDbl(tcosto.Text.Trim) & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & ",'" & timports.Text.Trim.ToUpper & "','" & timport2.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                        End If
                    Else
                        If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                            sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & (CDbl(tcosto.Text.Trim) / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * tneto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & timports.Text.Trim.ToUpper & "','" & timport2.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                        Else
                            sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & (CDbl(tcosto.Text.Trim) * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * txtcambio.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & timports.Text.Trim.ToUpper & "','" & timport2.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                        End If
                    End If
                Else
                    If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                        If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                            sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & CDbl(tcosto.Text.Trim) & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & ",'" & Me.timportacion.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                        Else
                            sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & CDbl(tcosto.Text.Trim) & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & ",'" & Me.timportacion.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                        End If
                    Else
                        If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                            sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & (CDbl(tcosto.Text.Trim) / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * tneto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & Me.timportacion.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                        Else
                            sql = "TMP_MOVIDETInsProc " & Me.tmovimiento.Text.Trim & ",'" & calmacen.SelectedValue.ToString & "','" & ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & txtcantidad.Text & "," & (CDbl(tcosto.Text.Trim) * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','1','0','" & CodUsuario & "',0,'" & correl & "'," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & strtaraimp & "','" & codmed & "'," & (tcosto.Text * txtcambio.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & Me.timportacion.Text.Trim.ToUpper & "','" & Me.tlote.Text.Trim & "','" & NROPTOVTA & "'"
                        End If
                    End If
                End If

                PROCESO = TmpInsertDatos(sql)
            ElseIf boestimp = False Then
                'If timportacion.Text.Trim <> "" Then
                '    conecta1("select saldont from saldos_importacion where nroimportacion=" & Strings.Left(Me.timportacion.Text.Trim, 6) + Strings.Right(Me.timportacion.Text, 4) & " and codarti='" & Me.tarticulo.Text.Trim & "' AND CDALMACEN IS NULL", "busca")

                '    If ds.Tables("busca").Rows.Count > 0 Then
                '        If tneto.Text > Val(ds.Tables("busca").Rows(0)(0)) Then
                '            MessageBox.Show("No puede ingresar una cantidad mayor al que se tiene en Stock", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '            Exit Sub
                '        End If
                '    End If
                'End If
                If Me.timports.Visible = True Then
                    If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                        If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                            sql = "TMP_MOVIDETUpdProc '" & calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',1," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & ",'" & codmed & "','" & txtnrolote.Text & "','" & Me.timports.Text.Trim & "','" & CodUsuario & "','" & NROPTOVTA & "'"
                        Else
                            sql = "TMP_MOVIDETUpdProc '" & calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',1," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & ",'" & codmed & "','" & txtnrolote.Text & "','" & Me.timports.Text.Trim & "','" & CodUsuario & "','" & NROPTOVTA & "'"
                        End If
                    Else
                        If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                            sql = "TMP_MOVIDETUpdProc '" & calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',1," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & codmed & "','" & txtnrolote.Text & "','" & Me.timports.Text.Trim & "','" & CodUsuario & "','" & NROPTOVTA & "'"
                        Else
                            sql = "TMP_MOVIDETUpdProc '" & calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',1," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & codmed & "','" & txtnrolote.Text & "','" & Me.timports.Text.Trim & "','" & CodUsuario & "','" & NROPTOVTA & "'"
                        End If

                    End If
                Else
                    If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                        If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                            sql = "TMP_MOVIDETUpdProc '" & calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',1," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & ",'" & codmed & "','" & tlote.Text & "','" & timportacion.Text.Trim.ToUpper & "','" & CodUsuario & "','" & NROPTOVTA & "'"
                        Else
                            sql = "TMP_MOVIDETUpdProc '" & calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',1," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & ",'" & codmed & "','" & tlote.Text & "','" & timportacion.Text.Trim.ToUpper & "','" & CodUsuario & "','" & NROPTOVTA & "'"
                        End If
                    Else
                        If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                            sql = "TMP_MOVIDETUpdProc '" & calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',1," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text / txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * tneto.Text / txtcambio.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & codmed & "','" & tlote.Text & "','" & timportacion.Text.Trim.ToUpper & "','" & CodUsuario & "','" & NROPTOVTA & "'"
                        Else
                            sql = "TMP_MOVIDETUpdProc '" & calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tarticulo.Text & "'," & Me.txtcantidad.Text & "," & Me.tbruto.Text & "," & Me.ttara.Text & "," & Me.tneto.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfvenc.Value), "MM/dd/yy") & "','" & codempresa & "','" & correl & "',1," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text) & "," & tcosto.Text & "," & (tcosto.Text * txtcambio.Text * tneto.Text) & "," & (tcosto.Text * tneto.Text) & ",'" & codmed & "','" & tlote.Text & "','" & timportacion.Text.Trim.ToUpper & "','" & CodUsuario & "','" & NROPTOVTA & "'"
                        End If

                    End If
                End If

                PROCESO = TmpInsertDatos(sql)

            End If

            Call cargagrilla()
            Call Limpia()
            Me.tarticulo.Focus()

        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Private Sub tneto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tneto.KeyPress
        Try
            Dim Keyascii As Short = CShort(Asc(e.KeyChar))
            Keyascii = CShort(NumerosDecimales(Keyascii))
            If Keyascii = 0 Then
                e.Handled = True
                MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.tneto.Focus()
            End If

            If Asc(e.KeyChar) = 13 Then

                tbruto.Text = (Val(tneto.Text) + Val(ttara.Text)).ToString("###0.00")
                If valorizado = True Then
                    tcosto.Focus()
                    tcosto.SelectAll()
                Else
                    Call Llena_temp()
                End If
            End If


        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Public INICIAS As Boolean
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Try
            flag = 0
            Me.CheckBox1.Enabled = True
            Me.CheckBox1.Checked = False
            INICIAS = False
            elimina()

            Me.Button1.Enabled = False
            TOBS.Enabled = True
            Me.BTNCANCELAR.Enabled = True
            Me.BTNGUARDAR.Enabled = True
            Me.BTNNUEVO.Enabled = False
            Me.BTNELIMINAR.Enabled = False
            Me.btnmodificar.Enabled = False
            Me.grid1.Enabled = True
            Me.dtpfecha.Enabled = True
            tmovimiento.Text = ""
            desbloqueatextbox(Me)
            btnarticulo.Enabled = True
            btnproveedor.Enabled = True
            Me.dtpfvenc.Enabled = True
            Me.timportacion.ReadOnly = True
            Me.timports.ReadOnly = True
            Me.timport2.ReadOnly = True

            sololectura()
            'Me.CheckBox1.Enabled = True
            Conecta("select correlguia from tmp_correlguia where codempresa='" & codempresa & "' and tipo='INGRESO'", "correl")
            If ds.Tables("correl").Rows.Count = 0 Then
                correl = 1
                TmpInsertDatos("insert into tmp_correlguia values('" & correl & "','" & codempresa & "','INGRESO')")
            Else
                correl = Val(ds.Tables("correl").Rows(ds.Tables("correl").Rows.Count - 1)(0) + 1)
                TmpInsertDatos("update tmp_correlguia set correlguia='" & correl & "' where codempresa='" & codempresa & "' AND TIPO='INGRESO'")
            End If

            CONT = 0
            verifica_valorizado()
            verifica()

            If Me.CheckBox1.Checked = True Then
                Me.Button2.Enabled = True
            Else
                Me.Button2.Enabled = False
            End If

            Me.calmacen.Focus()
            tlote.ReadOnly = False
            tlote.Enabled = True
            Call calmacen_SelectedIndexChanged(sender, e)
            Call ComboBox1_SelectedIndexChanged(sender, e)
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try

    End Sub
    Sub cargagrilla()
        If bomedidaing = True And boumedidaing = False Then
            Me.Ds_diferencia_de_reportes1.Clear()
            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',0,'" & correl & "',1,0,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',0,'" & correl & "',1,0,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa")
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',0,'" & correl & "',1,1,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',0,'" & correl & "',1,1,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa")
                End If

            End If
            'oda.Fill(Me.Ds_diferencia_de_reportes1.Dsdifreporte)
            Dim a1, a2, a3 As Double
            'If Me.Ds_diferencia_de_reportes1.Dsdifreporte.Rows.Count > 0 Then
            '    calmacen.Enabled = False
            '    ComboBox1.Enabled = False
            'Else
            '    calmacen.Enabled = True
            '    ComboBox1.Enabled = True
            'End If

            'CONT = Me.Ds_diferencia_de_reportes1.Dsdifreporte.Rows.Count
            'For i = 0 To Me.Ds_diferencia_de_reportes1.Dsdifreporte.Rows.Count - 1
            '    a1 += Val(Me.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(4))
            '    a2 += Val(Me.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(5))
            '    a3 += Val(Me.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(11))
            'Next
            Me.totbruto.Text = a1.ToString("###0.00")
            Me.tottara.Text = a2.ToString("###0.00")
            Me.totneto.Text = Val(a1 - a2).ToString("###0.00")
            Me.tottotal.Text = a3.ToString("###0.00")

        ElseIf bomedidaing = False And boumedidaing = True Then


            Me.DsInventInicial1.Clear()

            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',1,'" & correl & "',1,0,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa1")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',1,'" & correl & "',1,0,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa1")
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',1,'" & correl & "',1,1,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa1")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',1,'" & correl & "',1,1,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa1")
                End If

            End If

            'oda.Fill(Me.DsInventInicial1.ds_inventini)
            'CONT = Me.DsInventInicial1.ds_inventini.Rows.Count
            'Me.grid1.DataSource = Me.DsInventInicial1.ds_inventini


        ElseIf bomedidaing = True And boumedidaing = True Then


            Me.Ds_diferencia_de_reportes1.Clear()

            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',0,'" & correl & "',1,0,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',0,'" & correl & "',1,0,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa")
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',0,'" & correl & "',1,1,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa")
                Else
                    Conecta("SP_SELE_TMP_MOVIDET '" & codempresa & "',0,'" & correl & "',1,1,'" & Me.calmacen.SelectedValue.ToString & "','" & NROPTOVTA & "','" & CodUsuario & "'", "pa")
                End If

            End If

            'oda.Fill(Me.Ds_diferencia_de_reportes1.Dsdifreporte)
            'Me.grid1.DataSource = Me.Ds_diferencia_de_reportes1.Dsdifreporte


            'If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then

            '    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
            '        conecta("SP_SELE_TMP_MOVIDET_2 '" & CodEmpresa & "','" & correl & "',1,0,'" & Me.calmacen.SelectedValue.ToString & "'", "pa")
            '    Else
            '        conecta("SP_SELE_TMP_MOVIDET_2 '" & CodEmpresa & "','" & correl & "',1,0,'" & Me.calmacen.SelectedValue.ToString & "'", "pa")
            '    End If
            'Else
            '    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
            '        conecta("SP_SELE_TMP_MOVIDET_2 '" & CodEmpresa & "','" & correl & "',1,1,'" & Me.calmacen.SelectedValue.ToString & "'", "pa")
            '    Else
            '        conecta("SP_SELE_TMP_MOVIDET_2 '" & CodEmpresa & "','" & correl & "',1,1,'" & Me.calmacen.SelectedValue.ToString & "'", "pa")
            '    End If

            'End If


            'oda.Fill(Me.Ds_diferencia_de_reportes1.Dsdifreporte)

            ' Me.grid1.DataSource = Me.Ds_diferencia_de_reportes1.Dsdifreporte

            CONT = Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count


            Dim i, a1, a2, a3 As Double
            For i = 0 To Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count - 1
                a1 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(4))
                a2 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(5))
                a3 += Val(Me.Ds_diferencia_de_reportes1.Tables(0).Rows(i)(11))
            Next
            Me.totbruto.Text = a1.ToString("###0.00")
            Me.tottara.Text = a2.ToString("###0.00")
            Me.totneto.Text = Val(a1 - a2).ToString("###0.00")
            Me.tottotal.Text = a3.ToString("###0.00")

        End If


    End Sub
    Dim i As Int16
    Private Sub grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.Click
        Try
            'Dim clsinter As New ClsInterface
            tumedida.Items.Clear()
            arrmedidaing.Clear()
            'Dim N As Integer
            'N = Me.BindingContext(Me.DsInventInicial1.ds_inventini).Position
            tarticulo.Text = grid1.Item(grid1.CurrentRowIndex, 1)
            Me.tmarca.Text = grid1.Item(grid1.CurrentRowIndex, 2)
            txtdesarticulo.Text = grid1.Item(grid1.CurrentRowIndex, 3)
            Me.txtcantidad.Text = Val(grid1.Item(grid1.CurrentRowIndex, 5))
            'Me.txtnrolote.Text = grid1.Item(grid1.CurrentRowIndex, 14)
            If (bomedidaing = True And boumedidaing = False) Or (bomedidaing = True And boumedidaing = True) Then

                tbruto.Text = CDbl(grid1.Item(grid1.CurrentRowIndex, 6))
                ttara.Text = CDbl(grid1.Item(grid1.CurrentRowIndex, 7))
                tneto.Text = CDbl(grid1.Item(grid1.CurrentRowIndex, 8))
                Me.tcosto.Text = CDbl(grid1.Item(grid1.CurrentRowIndex, 9))
                ttotal.Text = CDbl(grid1.Item(grid1.CurrentRowIndex, 10))
                Me.dtpfvenc.Value = (grid1.Item(grid1.CurrentRowIndex, 11))
                Me.timports.Text = CAyuda.ValidaNullSTring(grid1.Item(grid1.CurrentRowIndex, 12))
                Me.timport2.Text = CAyuda.ValidaNullSTring(grid1.Item(grid1.CurrentRowIndex, 13))

                Conecta("NSP_SELEC_medidas '" & codempresa & "','" & tarticulo.Text.Trim & "',0", "llena")
                If ds.Tables("llena").Rows.Count > 0 Then
                    For i = 0 To ds.Tables("llena").Rows.Count - 1
                        arrmedidaing.Add(Trim(ds.Tables("llena").Rows(i)(0)))
                        tumedida.Items.Add(Trim(ds.Tables("llena").Rows(i)(1)))
                        strtaraimp = Trim(ds.Tables("llena").Rows(0)(2))
                    Next
                End If

            ElseIf bomedidaing = False And boumedidaing = True Then

                tneto.Text = CDbl(grid1.Item(grid1.CurrentRowIndex, 6))
                Me.tcosto.Text = CDbl(grid1.Item(grid1.CurrentRowIndex, 7))
                ttotal.Text = CDbl(grid1.Item(grid1.CurrentRowIndex, 8))
                Me.dtpfvenc.Value = (grid1.Item(grid1.CurrentRowIndex, 9))
                Me.timports.Text = CAyuda.ValidaNullSTring(grid1.Item(grid1.CurrentRowIndex, 10))
                Me.timport2.Text = CAyuda.ValidaNullSTring(grid1.Item(grid1.CurrentRowIndex, 11))
                tumedida.Items.Add(grid1.Item(grid1.CurrentRowIndex, 4))

                Conecta("NSP_SELEC_medidas '" & codempresa & "','" & tarticulo.Text.Trim & "',1", "llena")
                If ds.Tables("llena").Rows.Count > 0 Then
                    arrmedidaing.Add(Trim(ds.Tables("llena").Rows(0)(0)))
                    tumedida.Items.Add(Trim(ds.Tables("llena").Rows(0)(1)))
                    strtaraimp = Trim(ds.Tables("llena").Rows(0)(2))
                End If
            End If

            tumedida.Text = grid1.Item(grid1.CurrentRowIndex, 4)
            'Me.txtnrolote.Text = grid1.Item(grid1.TableStyles(1).ToString, 23)
            'txtcantidad.Focus()
            If Trim(Me.ComboBox1.SelectedValue) = "09" Then
                Me.lblnrolote.Visible = True
                Me.txtnrolote.Visible = True
                Conecta("SP_BUSCA_LOTE '" & codempresa & "',1,'119','" & tarticulo.Text.Trim & "','" & timports.Text.Trim & "'", "CANASTA")
                If ds.Tables("CANASTA").Rows.Count > 0 Then
                    Me.txtnrolote.Text = ds.Tables("CANASTA").Rows(0)("P")
                End If
            Else
                Me.lblnrolote.Visible = False
                Me.txtnrolote.Visible = False
            End If
            txtcantidad.SelectAll()
            boestimp = False

        Catch x As Exception
            MsgBox(x.Message.ToString)
        End Try
    End Sub
    Private Sub tarticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tarticulo.KeyPress

    End Sub
    Sub Limpia()
        tarticulo.Text = Nothing
        timports.Text = Nothing
        timport2.Text = Nothing
        txtdesarticulo.Text = Nothing
        tmarca.Text = Nothing
        dtpfvenc.Value = Now
        txtcantidad.Text = 0
        tumedida.Items.Clear()
        tbruto.Text = 0
        ttara.Text = 0
        tneto.Text = 0
        tcosto.Text = 0
        ttotal.Text = 0
    End Sub
    Private Sub grid1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grid1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtcantidad.Focus()
        End If
        'Try
        '    Dim sql As String
        '    Dim PROCESO As Boolean

        '    If Asc(e.KeyChar) = 114 Then

        '        conecta("SELECT cdcompra,corrnbr FROM TMP_moviDET WHERE codempresa='" & CodEmpresa & "' and cdcompra='" & correl & "' and inout=1 order by corrnbr", "paz")
        '        If ds.Tables("paz").Rows.Count = 0 Then
        '            calmacen.Enabled = True
        '            ComboBox1.Enabled = True
        '            Exit Sub
        '        End If


        '        If MessageBox.Show("Desea eliminar el Registro Seleccionado", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '            sql = "nsp_dele_TMP_moviDET " & grid1.Item(grid1.CurrentRowIndex, 0) & ",'" & correl & "','" & CodEmpresa & "',1"
        '            PROCESO = delete_store_aux(sql)

        '            Dim l As Integer
        '            conecta("SELECT cdcompra,corrnbr FROM TMP_moviDET WHERE codempresa='" & CodEmpresa & "' and cdcompra='" & correl & "' and inout=1 order by corrnbr", "pa")
        '            'CONT -= 1
        '            For l = 0 To ds.Tables("pa").Rows.Count - 1
        '                TmpInsertDatos("update tmp_movidet set corrnbr=" & Val(l + 1) & " where cdcompra='" & Trim(ds.Tables("pa").Rows(l)(0)) & "' and corrnbr='" & Trim(ds.Tables("pa").Rows(l)(1)) & "' and inout=1")
        '            Next

        '            cargagrilla()
        '        End If

        '    End If

        'Catch x As Exception

        'End Try

    End Sub

    Private Sub ttara_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ttara.TextChanged
        Try

            Me.tneto.Text = Val(Me.tbruto.Text - Me.ttara.Text).ToString("###0.00")
            Me.tneto.Focus()
            Me.tneto.SelectAll()
        Catch x As Exception
        End Try
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        sw = False
        Me.Close()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Me.Button1.Enabled = True
        TOBS.Enabled = False
        BTNNUEVO.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNCANCELAR.Enabled = False
        Button2.Enabled = False

        Bloqueatextbox(Me)
        btnarticulo.Enabled = False
        btnproveedor.Enabled = False
        Me.dtpfvenc.Enabled = False
        Me.dtpfecha.Enabled = False
        sololectura()
    End Sub

    Sub sololectura()
        Me.tproveedor.ReadOnly = True
        Me.tmovimiento.ReadOnly = True
        Me.txtdesarticulo.ReadOnly = True
        Me.tumedida.Enabled = True
        Me.tmarca.ReadOnly = True
        Me.ttara.ReadOnly = True
        Me.totbruto.ReadOnly = True
        Me.tottara.ReadOnly = True
        Me.totneto.ReadOnly = True
        Me.tottotal.ReadOnly = True
        ttotal.ReadOnly = True

        limpiatextbox(Me)
        Me.Ds_diferencia_de_reportes1.Clear()
        Me.DsInventInicial1.Clear()
        Me.grid1.Refresh()
        Me.totbruto.Text = 0
        Me.tottara.Text = 0
        Me.tottotal.Text = 0
        Me.tcosto.Text = 0
        Me.ttotal.Text = 0
        Me.totneto.Text = 0
        Me.txtcantidad.Text = 0
        Me.tbruto.Text = 0
        Me.ttara.Text = 0
        Me.tneto.Text = 0
    End Sub

    Dim flag As Integer, ia As Integer

    Sub INSERTA(ByVal SQL As String)

        If condicion = True Then  ' cuando son ingresos q no son por importacion
            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yyyy") & "','" & Me.ctipoprecio.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & ",'" & Me.txtcambio.Text & "',0,0," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString & "','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString & "'"
                    '''''If ctipocred.Visible = True Then
                    '''''    TmpInsertDatos("nsp_ins_compras_cred '" & tmovimiento.Text.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & ctipoprecio.SelectedValue.ToString & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(FECHAVENC), "MM/dd/yy") & "','" & Me.ctipocred.SelectedValue.ToString & "'," & GFormatodeNumero(Me.tottotal.Text) & "," & GFormatodeNumero(Me.tottotal.Text / txtcambio.Text) & ",0,0,'" & CodUsuario & "','" & CodEmpresa & "'")
                    '''''End If
                Else
                    SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yyyy") & "','" & Me.ctipoprecio.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'" & Me.txtcambio.Text & "',0,0," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString & "','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString & "'"
                    '''''If ctipocred.Visible = True Then
                    '''''    TmpInsertDatos("nsp_ins_compras_cred '" & tmovimiento.Text.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & ctipoprecio.SelectedValue.ToString & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Me.ctipocred.SelectedValue.ToString & "'," & GFormatodeNumero(Me.tottotal.Text) & "," & GFormatodeNumero((Me.tottotal.Text * txtcambio.Text)) & ",0,0,'" & CodUsuario & "','" & CodEmpresa & "'")
                    '''''End If
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yyyy") & "','" & Me.ctipoprecio.SelectedValue.ToString & "'," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'" & Me.txtcambio.Text & "',0,0," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString & "','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString & "'"
                    '''''If ctipocred.Visible = True Then
                    '''''    TmpInsertDatos("nsp_ins_compras_cred '" & tmovimiento.Text.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & ctipoprecio.SelectedValue.ToString & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Me.ctipocred.SelectedValue.ToString & "'," & GFormatodeNumero(Me.tottotal.Text / txtcambio.Text) & "," & GFormatodeNumero(Me.tottotal.Text) & ",0,0,'" & CodUsuario & "','" & CodEmpresa & "'")
                    '''''End If
                Else
                    SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yyyy") & "','" & Me.ctipoprecio.SelectedValue.ToString & "'," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'" & Me.txtcambio.Text & "',0,0," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'',0,0,'" & CodUsuario & "','" & codempresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString & "','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString & "'"
                    '''''If ctipocred.Visible = True Then
                    '''''    TmpInsertDatos("nsp_ins_compras_cred '" & tmovimiento.Text.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & ctipoprecio.SelectedValue.ToString & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Me.ctipocred.SelectedValue.ToString & "'," & GFormatodeNumero(Me.tottotal.Text * txtcambio.Text) & "," & GFormatodeNumero(Me.tottotal.Text) & ",0,0,'" & CodUsuario & "','" & CodEmpresa & "'")
                    '''''End If
                End If
            End If

        Else ' cuando son ingresos por importacion

            If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "'," & Me.tmovimiento.Text.Trim & ",'" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yyyy") & "','" & Me.ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.txtcambio.Text.Trim & "',0,0," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'',0,0,'" & CodUsuario & "','" & codempresa.Trim & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString.Trim & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "','" & Me.timportacion.Text.Trim & "','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString.Trim & "'"
                    ''''''If ctipocred.Visible = True Then
                    ''''''    TmpInsertDatos("nsp_ins_compras_cred '" & tmovimiento.Text.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & ctipoprecio.SelectedValue.ToString & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Me.ctipocred.SelectedValue.ToString & "'," & GFormatodeNumero(Me.tottotal.Text) & "," & GFormatodeNumero(Me.tottotal.Text / txtcambio.Text) & ",0,0,'" & CodUsuario & "','" & CodEmpresa & "'")
                    ''''''End If
                Else
                    SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "'," & Me.tmovimiento.Text.Trim & ",'" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yyyy") & "','" & Me.ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.txtcambio.Text.Trim & "',0,0," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'',0,0,'" & CodUsuario & "','" & codempresa.Trim & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString.Trim & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "','" & Me.timportacion.Text.Trim & "','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString.Trim & "'"
                    'SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & Me.ctipoprecio.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'" & Me.txtcambio.Text & "',0,0," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'',0,0,'" & Variables_jhon.CodUsuario & "','" & CodEmpresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','" & Me.timportacion.Text & "','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString & "','','" & TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString & "'"
                    '''''If ctipocred.Visible = True Then
                    '''''    TmpInsertDatos("nsp_ins_compras_cred '" & tmovimiento.Text.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & ctipoprecio.SelectedValue.ToString & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Me.ctipocred.SelectedValue.ToString & "'," & GFormatodeNumero(Me.tottotal.Text) & "," & GFormatodeNumero((Me.tottotal.Text * txtcambio.Text)) & ",0,0,'" & CodUsuario & "','" & CodEmpresa & "'")
                    '''''End If
                End If
            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                    SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "'," & Me.tmovimiento.Text.Trim & ",'" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yyyy") & "','" & Me.ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.txtcambio.Text.Trim & "',0,0," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'',0,0,'" & CodUsuario & "','" & codempresa.Trim & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString.Trim & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "','" & Me.timportacion.Text.Trim & "','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString.Trim & "'"
                    'SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & Me.ctipoprecio.SelectedValue.ToString & "'," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'" & Me.txtcambio.Text & "',0,0," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'',0,0,'" & Variables_jhon.CodUsuario & "','" & CodEmpresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','" & Me.timportacion.Text & "','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString & "','','" & TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString & "'"
                    ''''''If ctipocred.Visible = True Then
                    ''''''    TmpInsertDatos("nsp_ins_compras_cred '" & tmovimiento.Text.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & ctipoprecio.SelectedValue.ToString & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Me.ctipocred.SelectedValue.ToString & "'," & GFormatodeNumero(Me.tottotal.Text / txtcambio.Text) & "," & GFormatodeNumero(Me.tottotal.Text) & ",0,0,'" & CodUsuario & "','" & CodEmpresa & "'")
                    ''''''End If
                Else
                    SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "'," & Me.tmovimiento.Text.Trim & ",'" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yyyy") & "','" & Me.ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.txtcambio.Text.Trim & "',0,0," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'',0,0,'" & CodUsuario & "','" & codempresa.Trim & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString.Trim & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "','" & Me.timportacion.Text.Trim & "','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString.Trim & "'"
                    'SQL = "nsp_ins_MOVICAB1 '" & Me.calmacen.SelectedValue.ToString & "','" & Me.ComboBox1.SelectedValue.ToString & "'," & Me.tmovimiento.Text & ",'" & Me.tcodproveedor.Text & "','" & Me.ctipodoc.SelectedValue.ToString & "',1,'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "','" & Format(Microsoft.VisualBasic.DateValue(Now), "MM/dd/yy") & "','" & Me.ctipoprecio.SelectedValue.ToString & "'," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'" & Me.txtcambio.Text & "',0,0," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'',0,0,'" & Variables_jhon.CodUsuario & "','" & CodEmpresa & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & calmacen.SelectedValue.ToString & "'," & shmedidaing & "," & shumedida & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "','" & Me.timportacion.Text & "','" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString & "','','" & TREF.Text.Trim.ToUpper & "','" & Me.cboref.SelectedValue.ToString & "'"
                    '''''If ctipocred.Visible = True Then
                    '''''    TmpInsertDatos("nsp_ins_compras_cred '" & tmovimiento.Text.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & ctipoprecio.SelectedValue.ToString & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "','" & Me.ctipocred.SelectedValue.ToString & "'," & GFormatodeNumero(Me.tottotal.Text * txtcambio.Text) & "," & GFormatodeNumero(Me.tottotal.Text) & ",0,0,'" & CodUsuario & "','" & CodEmpresa & "'")
                    '''''End If
                End If
            End If

        End If

        If TmpInsertDatos(SQL) = True Then
            Call BOTONES(True, False, False, False, False)
            Bloqueatextbox(Me)
            Me.grid1.Enabled = False
        End If
        If Destinos = True Then
            TmpInsertDatos("update movicab set tabla=1 where nromovi='" & Me.tmovimiento.Text.Trim & "'")
        End If
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        If Me.DsInventInicial1.Tables(0).Rows.Count = 0 And Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Falta ingresar información", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Me.tcodproveedor.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Proveedor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tdoc1.Text.Trim = "" Or tdoc2.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Nro de documento", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.tlote.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Nro de Lote !!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Button1.Enabled = True
        Me.dtpfecha.Enabled = False
        BTNNUEVO.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNELIMINAR.Enabled = False
        TOBS.Enabled = False
        Dim SQL As String = ""
        Dim PROCESO As Boolean
        Call formatotextbox(Me)



        If flag = 0 Then
            If Me.CheckBox1.Checked = False Then
                Me.timportacion.Text = Me.tmovimiento.Text.Trim
            End If

            'determino el tipo de moneda a utilizar y comparo con el confiGvta
            'solo inserto compras y ingreso a compras cred
            'GRABO EN MOVICAB
            INSERTA(SQL)
            TmpInsertDatos("UPDATE TIPOMOVI SET CORRELATIVO = CORRELATIVO + 1 WHERE CODEMPRESA = '" & codempresa.Trim & "' AND CDTIPOMOV = '" & Trim(Me.ComboBox1.SelectedValue.ToString()) & "'")

        Else ' parte para modificar
            If condicion = True Then
                If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                        SQL = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString.Trim & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen.SelectedValue.ToString.Trim & "',1,'" & ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.txtcambio.Text.Trim & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & "," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString.Trim & "'"
                    Else
                        SQL = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString.Trim & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen.SelectedValue.ToString.Trim & "',1,'" & ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.txtcambio.Text.Trim & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & "," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString.Trim & "'"
                        'sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & CodEmpresa & "','" & Me.calmacen.SelectedValue.ToString & "',1,'" & ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'" & Me.tlote.Text & "','" & Me.ComboBox2.SelectedValue.ToString & "','','','" & TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString & "'"
                    End If
                Else
                    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                        SQL = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString.Trim & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen.SelectedValue.ToString.Trim & "',1,'" & ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.txtcambio.Text.Trim & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & "," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString.Trim & "'"
                        'sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & CodEmpresa & "','" & Me.calmacen.SelectedValue.ToString & "',1,'" & ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'" & Me.tlote.Text & "','" & Me.ComboBox2.SelectedValue.ToString & "','','','" & TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString & "'"
                    Else
                        SQL = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString.Trim & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen.SelectedValue.ToString.Trim & "',1,'" & ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.txtcambio.Text.Trim & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & "," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString.Trim & "'"
                        'sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & CodEmpresa & "','" & Me.calmacen.SelectedValue.ToString & "',1,'" & ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'" & Me.tlote.Text & "','" & Me.ComboBox2.SelectedValue.ToString & "','','','" & TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString & "'"
                    End If
                End If

            Else
                If Trim(ctipoprecio.SelectedValue.ToString) = mbase Then
                    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                        SQL = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString.Trim & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen.SelectedValue.ToString.Trim & "',1,'" & ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.txtcambio.Text.Trim & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & "," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString.Trim & "'"
                        'sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & CodEmpresa & "','" & Me.calmacen.SelectedValue.ToString & "',1,'" & ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & ",'" & Me.tlote.Text & "','" & Me.ComboBox2.SelectedValue.ToString & "','" & timportacion.Text & "','','" & TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString & "'"
                    Else
                        SQL = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString.Trim & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen.SelectedValue.ToString.Trim & "',1,'" & ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.txtcambio.Text.Trim & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & "," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString.Trim & "'"
                        'sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & CodEmpresa & "','" & Me.calmacen.SelectedValue.ToString & "',1,'" & ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & ",'" & Me.tlote.Text & "','" & Me.ComboBox2.SelectedValue.ToString & "','" & timportacion.Text & "','','" & TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString & "'"
                    End If
                Else
                    If Trim(ctipoprecio.SelectedValue.ToString) = "S" Then
                        SQL = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString.Trim & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen.SelectedValue.ToString.Trim & "',1,'" & ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.txtcambio.Text.Trim & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & "," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString.Trim & "'"
                        'sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & CodEmpresa & "','" & Me.calmacen.SelectedValue.ToString & "',1,'" & ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text / txtcambio.Text) & "," & Me.tottotal.Text & ",'" & Me.tlote.Text & "','" & Me.ComboBox2.SelectedValue.ToString & "','" & timportacion.Text & "','','" & TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString & "'"
                    Else
                        SQL = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString.Trim & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString.Trim & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yyyy") & "'," & Me.totbruto.Text.Trim & "," & Me.tottara.Text.Trim & "," & Me.totneto.Text.Trim & ",'" & Me.TOBS.Text.Trim.Trim & "','" & Me.ComboBox1.SelectedValue.ToString.Trim & "','" & Me.tmovimiento.Text.Trim & "','" & codempresa & "','" & Me.calmacen.SelectedValue.ToString.Trim & "',1,'" & ctipoprecio.SelectedValue.ToString.Trim & "'," & Me.txtcambio.Text.Trim & "," & cred & ",'" & ctipocred.SelectedValue.ToString.Trim & "'," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & "," & Me.tottotal.Text.Trim & "," & (Me.tottotal.Text.Trim / txtcambio.Text.Trim) & ",'" & Me.tlote.Text.Trim & "','" & Me.ComboBox2.SelectedValue.ToString.Trim & "','','','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString.Trim & "'"
                        'sql = "NSP_UPD_movicab '" & calmacen.SelectedValue.ToString & "','" & Me.tcodproveedor.Text.Trim & "','" & Me.ctipodoc.SelectedValue.ToString & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "','" & Format(Me.dtpfecha.Value, "MM/dd/yy hh:mm:ss tt") & "'," & Me.totbruto.Text & "," & Me.tottara.Text & "," & Me.totneto.Text & ",'" & Me.TOBS.Text.Trim & "','" & Me.ComboBox1.SelectedValue.ToString & "','" & Me.tmovimiento.Text.Trim & "','" & CodEmpresa & "','" & Me.calmacen.SelectedValue.ToString & "',1,'" & ctipoprecio.SelectedValue.ToString & "'," & Me.txtcambio.Text & "," & cred & ",'" & ctipocred.SelectedValue.ToString & "'," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & "," & (Me.tottotal.Text * txtcambio.Text) & "," & Me.tottotal.Text & ",'" & Me.tlote.Text & "','" & Me.ComboBox2.SelectedValue.ToString & "','" & timportacion.Text & "','','" & TREF.Text.Trim.ToUpper & "','" & cboref.SelectedValue.ToString & "'"
                    End If
                End If

            End If

            If TmpInsertDatos(SQL) = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & tmovimiento.Text & "','UPDATE','GUIAINGOTROS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Call BOTONES(True, False, False, False, False)
                Bloqueatextbox(Me)
                Me.grid1.Enabled = False
            End If
        End If

        ''DEVUELVE DETALLE DE MOVIDET (QUITA DE SLADOS DE IMPORTACION LO INGRSADO)
        If flag = 1 Then
            SQL = "USP_QUITAR_MOVIDET '" & Trim(Me.calmacen.SelectedValue.ToString()) & "','" & Trim(Me.ComboBox1.SelectedValue.ToString()) & "'," & Me.tmovimiento.Text.Trim & ",'" & codempresa.Trim & "'"
            TmpInsertDatos(SQL)
        End If

        ''ACTUALIZAR DE TMP_MOVIDET A SALDOS DE IMPORTACION
        SQL = "USP_SUMAR_TMP_MOVIDET '" & Trim(Me.calmacen.SelectedValue.ToString()) & "','" & Trim(Me.ComboBox1.SelectedValue.ToString()) & "'," & Me.tmovimiento.Text.Trim & ",'" & codempresa.Trim & "','" & Me.tlote.Text.Trim & "'"
        TmpInsertDatos(SQL)

        ''ELIMINO DETALLE
        TmpInsertDatos("delete from movidet where nromovi='" & Me.tmovimiento.Text & "' and codempresa='" & codempresa & "' and cdtipomov='" & Me.ComboBox1.SelectedValue.ToString.Trim & "' and inout=1")

        If Me.CheckBox1.Checked = True Then
            SQL = "NSP_ins_movidet '" & correl & "','" & codempresa & "'," & Me.tmovimiento.Text.Trim & ",'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "',1," & CType(Strings.Left(Me.timportacion.Text.Trim, 6) + Strings.Right(Me.timportacion.Text.Trim, 4), String) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & tlote.Text & "','" & CodUsuario & "'"
        Else
            SQL = "NSP_ins_movidet '" & correl & "','" & codempresa & "'," & Me.tmovimiento.Text.Trim & ",'" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "',1," & Val(CType(Me.tdoc1.Text.Trim, String) + CType(Me.tdoc2.Text.Trim, String)) & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yyyy") & "','" & tlote.Text & "','" & CodUsuario & "'"
        End If

        PROCESO = TmpInsertDatos(SQL)

        If PROCESO = True Then
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & tmovimiento.Text & "','INSERT DET','GUIAINGOTROS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
        End If

        If Trim(ComboBox1.SelectedValue.ToString()) = CODINGXTRANS Then
            'Dim CLSINTER As New ClsInterface
            CAyuda.Ejecutar("SP_UPD_ESTADO_TRANSF", calmacen.SelectedValue, TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim)
        End If
        'Call elimina()
        'ELIMINO DETALLE
        'Dim cdpunto As String = ""
        'If ComboBox2.Items.Count > 0 Then
        '    cdpunto = calmacen.SelectedValue.ToString
        'End If
        'TmpInsertDatos("delete from tmp_SALD_IMPORTACION_2 WHERE CDALMACEN='" & calmacen.SelectedValue.ToString & "' AND NROPTOVTA='" & cdpunto & "' AND NROMOV='" & tmovimiento.Text.Trim & "'")
        'TmpInsertDatos("delete from movidet where nromovi='" & Me.tmovimiento.Text & "' and codempresa='" & CodEmpresa & "' and cdtipomov='" & Me.ComboBox1.SelectedValue.ToString.Trim & "' and inout=1")
        CONT = 0

        BTNCANCELAR.Enabled = False
    End Sub

    Public ordenn As String
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal ANULAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNELIMINAR.Enabled = ELIMINAR
        BTNANULAR.Enabled = ANULAR
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BTNNUEVO.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNCANCELAR.Enabled = False
        Bloqueatextbox(Me)
        btnarticulo.Enabled = False
        btnproveedor.Enabled = False
        Me.dtpfvenc.Enabled = False
        Me.dtpfecha.Enabled = False
        sololectura()

        elimina()

        Dim men As New frm_guiaingreso
        men.boingresoguiaing = True
        men.vie = Me
        men.ShowDialog()
        If tmovimiento.Text.Trim <> "" Then
            'Dim clsinter As New ClsInterface
            Dim tabla As New DataTable
            tabla = CAyuda.ListarDatos("SP_VERF_EST_SALIDA", tmovimiento.Text.Trim, ComboBox1.SelectedValue, tdoc1.Text.Trim & "-" & tdoc2.Text.Trim, calmacen.SelectedValue.TRIM).Tables(0)
            If tabla.Rows.Count > 0 Then
                If tabla.Rows(0)(0) = "1" Then
                    MsgBox("El documento tiene el estado de anulado, Gracias...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                    Call BOTONES(True, False, False, False, False)
                    Bloqueatextbox(Me)
                    Me.grid1.Enabled = False
                End If
            End If
        End If
    End Sub

    Public Sub llenaproveedor()
        Conecta("select codproveedor,desproveedor,ruc,direccion from proveedor where codempresa='" & codempresa & "'and estado=0 and codproveedor='" & Me.tcodproveedor.Text.Trim & "'", "pa")
        If ds.Tables("pa").Rows.Count > 0 Then
            tcodproveedor.Text = Trim(ds.Tables("pa").Rows(0)(0))
            tproveedor.Text = Trim(ds.Tables("pa").Rows(0)(1))
        Else
            MessageBox.Show("Proveedor no Encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.tcodproveedor.Focus()
            Me.tcodproveedor.SelectAll()
        End If
    End Sub

    Private Sub tcodproveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodproveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llenaproveedor()
        End If
    End Sub


    Private Sub frm_guiaingmercaderia_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        sw = False
        INICIAS = False
        elimina()

    End Sub

    Private Sub elimina()
        Try
            Dim cdpunto As String = ""
            If ComboBox2.Items.Count > 0 Then
                cdpunto = calmacen.SelectedValue.ToString
            End If
            'TmpInsertDatos("DELETE FROM TMP_MOVIDET WHERE CDCOMPRA='" & correl & "' and codempresa='" & CodEmpresa & "' and inout=1")
            'TmpInsertDatos("delete from tmp_SALD_IMPORTACION_2 WHERE CDALMACEN='" & calmacen.SelectedValue.ToString & "' AND NROPTOVTA='" & cdpunto & "' AND NROMOV='" & tmovimiento.Text.Trim & "'")
            TmpInsertDatos("delete from tmp_SALD_IMPORTACION_2 WHERE CDALMACEN='" & calmacen.SelectedValue.ToString & "' AND NROPTOVTA='" & cdpunto & "' AND NROMOV='" & tmovimiento.Text.Trim & "'")
            TmpInsertDatos("DELETE FROM TMP_MOVIDET WHERE CDCOMPRA='" & correl & "' and codempresa='" & codempresa & "' and inout=1")
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Try


            Dim sw As Boolean
            sw = False
            If MessageBox.Show("¿Desea eliminar el presente registro?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If Trim(Me.ComboBox1.SelectedValue) = "09" Then
                    sw = True
                Else
                    Conecta("SELECT * FROM MOVIDET WHERE LOTE = '" & Me.tlote.Text.Trim & "' AND INOUT = 0 ", "x")
                    'Conecta("SELECT * FROM MOVIDET WHERE LOTE = '508' and cdtipomov='09'AND INOUT = 0", "x")
                    If ds.Tables("x").Rows.Count > 0 Then
                        MsgBox("No se Puede Eliminar Por que hay Articulos que" + Chr(13) + "Tienen ya Movimientos", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
                        Exit Sub
                    End If
                End If

                Dim SQL As String, NroDocRef As String
                NroDocRef = Me.TxtDocRef1.Text.Trim + "-" + Me.TREF.Text.Trim
                'Flat = insert_store("SP_ANULADOC_INGRESO '" & tlote.Text.Trim & "','" & ComboBox1.SelectedValue & "'," & tmovimiento.Text.Trim & ",'" & tdoc1.Text.Trim & "-" & tdoc2.Text.Trim & "'")

                TmpInsertDatos("delete from  movidet where cdcompra='" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "' and codempresa='" & codempresa & "' and inout=1")
                TmpInsertDatos("delete from tmp_SALD_IMPORTACION_2 WHERE CDALMACEN='" & calmacen.SelectedValue.ToString & "' AND NROPTOVTA='" & ComboBox2.SelectedValue.ToString & "' AND NROMOV='" & tmovimiento.Text.Trim & "'")
                TmpInsertDatos("delete from movicab where nrodoc='" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "' and nromovi='" & Me.tmovimiento.Text.Trim & "' and inout=1")
                TmpInsertDatos("UPDATE TRANSFERCAB SET ESTADO = 0 WHERE NRODOCREF = '" & NroDocRef.Trim & "'")
                SQL = "USP_ELIMINAR_ARTICULOS_SALDOS_IMPORTACION " & Me.tmovimiento.Text.Trim & ",'" & Trim(Me.calmacen.SelectedValue.ToString()) & "','" & Me.tlote.Text.Trim & "'"
                TmpInsertDatos(SQL)
                If CREDITO = True Then
                    Dim pa As String
                    pa = CType(Strings.Left(tdoc1.Text, 3), String) + CType(Strings.Right("0000000" + CType(tdoc2.Text.Trim, String), 7), String)
                    TmpInsertDatos("update ntacredcab set estado='' where nrontacred=" & pa & " and codempresa='" & codempresa & "'")
                End If


                If (bomedidaing = True And boumedidaing = False) Or (bomedidaing = True And boumedidaing = True) Then

                    For ia = 0 To Me.Ds_diferencia_de_reportes1.Tables(0).Rows.Count - 1

                        'conecta("select pesoneto,saldont,bultos,saldobultos,frecibo from saldos_importacion where nroimportacion=" & grid1.Item(ia, 12) & " and codarti='" & grid1.Item(ia, 1) & "' and cdalmacen is null", "llena")
                        'If ds.Tables("LLENA").Rows.Count > 0 Then
                        '    TmpInsertDatos("UPDATE SALDOS_IMPORTACION SET SALDOBULTOS=" & Val(ds.Tables("llena").Rows(0)(3) + grid1.Item(ia, 4)) & ",SALDONT=" & Val(ds.Tables("llena").Rows(0)(1) + grid1.Item(ia, 8)) & " where codarti='" & grid1.Item(ia, 1) & "' and nroimportacion=" & grid1.Item(ia, 12) & " and cdalmacen is null")
                        '    TmpInsertDatos("DELETE FROM SALDOS_IMPORTACION WHERE nroimportacion=" & grid1.Item(ia, 12) & " AND codarti='" & grid1.Item(ia, 1) & "' AND CDALMACEN='" & Me.calmacen.SelectedValue.ToString & "' AND NROPTOVTA='" & ComboBox2.SelectedValue.ToString & "' and nromov='" & Me.tmovimiento.Text & "'")
                        'End If
                        TmpInsertDatos("NSP_ins_borra_artidat '" & correl & "','" & codempresa & "','" & Me.tmovimiento.Text & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "',1," & grid1.Item(ia, 12) & "")
                    Next

                ElseIf bomedidaing = False And boumedidaing = True Then
                    For ia = 0 To Me.DsInventInicial1.Tables(0).Rows.Count - 1

                        'conecta("select pesoneto,saldont,bultos,saldobultos,frecibo from saldos_importacion where nroimportacion=" & grid1.Item(grid1.CurrentRowIndex, 10) & " and codarti='" & grid1.Item(ia, 1) & "' and cdalmacen is null", "llena")

                        'If ds.Tables("LLENA").Rows.Count > 0 Then
                        '    TmpInsertDatos("UPDATE SALDOS_IMPORTACION SET SALDOBULTOS=" & Val(ds.Tables("llena").Rows(0)(3) + grid1.Item(ia, 4)) & ",SALDONT=" & Val(ds.Tables("llena").Rows(0)(1) + grid1.Item(ia, 6)) & " where codarti='" & grid1.Item(ia, 1) & "' and nroimportacion=" & grid1.Item(ia, 10) & " and cdalmacen is null")
                        '    TmpInsertDatos("DELETE FROM SALDOS_IMPORTACION WHERE nroimportacion=" & grid1.Item(ia, 10) & " AND codarti='" & grid1.Item(ia, 1) & "' AND CDALMACEN='" & Me.calmacen.SelectedValue.ToString & "' AND NROPTOVTA='" & ComboBox2.SelectedValue.ToString & "' and nromov='" & Me.tmovimiento.Text & "'")
                        'End If

                        TmpInsertDatos("NSP_ins_borra_artidat '" & correl & "','" & codempresa & "','" & Me.tmovimiento.Text & "','" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "',1," & grid1.Item(ia, 10) & "")
                    Next
                End If
                If sw = True Then
                    Me.Button1.Enabled = True
                    TOBS.Enabled = False
                    BTNNUEVO.Enabled = True
                    BTNGUARDAR.Enabled = False
                    BTNCANCELAR.Enabled = False
                    Button2.Enabled = False

                    Bloqueatextbox(Me)
                    btnarticulo.Enabled = False
                    btnproveedor.Enabled = False
                    Me.dtpfvenc.Enabled = False
                    Me.dtpfecha.Enabled = False
                    sololectura()
                    BTNELIMINAR.Enabled = False
                    BTNNUEVO.Enabled = True
                    BTNGUARDAR.Enabled = False
                    BTNCANCELAR.Enabled = False
                    Bloqueatextbox(Me)
                    btnarticulo.Enabled = False
                    btnproveedor.Enabled = False
                    Me.dtpfvenc.Enabled = False
                    sololectura()
                End If
            End If
        Catch ex As Exception
            MsgBox("El registro ya fue eliminado de la data..", MsgBoxStyle.Information, "NAR SISTEMAS")
            Me.DsInventInicial1.Tables(0).Rows.Clear()
        End Try
    End Sub

    Private Sub ctipodoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipodoc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdoc1.Focus()
        End If
    End Sub

    Private Sub calmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles calmacen.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ComboBox2.Focus()
        End If
    End Sub
    Private Sub tarticulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tarticulo.KeyDown
        If e.KeyCode = Keys.F2 Then
            Call btnarticulo_Click(sender, e)

        ElseIf e.KeyCode = Keys.Enter Then
            If Len(Me.tarticulo.Text.Trim) = 0 Then
                btnarticulo_Click(sender, e)
                Exit Sub
            End If

            If Me.tdoc1.Text.Trim = "" Or Me.tdoc2.Text.Trim = "" Then
                MessageBox.Show("Ingrese el Número del Documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tdoc1.Focus()
                Me.tdoc1.SelectAll()
                Exit Sub
            Else
                Me.tdoc1.Text = Format(Val(Me.tdoc1.Text.Trim), "000")
                Me.tdoc2.Text = Format(Val(Me.tdoc2.Text.Trim), "0000000")
            End If

            Me.txtcantidad.Focus()

            Conecta("select c.codarti,c.desarti,u.desmed,u.codmed,m.desmarca,c.codmarca,p.tara,p.despres from articulo c,medida u,marcas m,presentacion p where c.codmed=u.codmed and c.codmarca=m.codmarca and c.codpres=p.codpres and c.codempresa='" & codempresa & "' and c.estado=0 and u.estado=0 and m.estado=0 and c.codarti='" & tarticulo.Text.Trim & "'", "pa")

            If ds.Tables("pa").Rows.Count > 0 Then
                tarticulo.Text = Trim(ds.Tables("pa").Rows(0)(0))
                txtdesarticulo.Text = Trim(ds.Tables("pa").Rows(0)(1))
                tumedida.Text = Trim(ds.Tables("pa").Rows(0)(7))
                arrmedidaing.Add(Trim(ds.Tables("pa").Rows(0)(3)))
                tmarca.Text = Trim(ds.Tables("pa").Rows(0)(4))
                MARCA = Trim(ds.Tables("pa").Rows(0)(5))
                ttara.Text = Trim(ds.Tables("pa").Rows(0)(6))
                txtcantidad.Focus()
                txtcantidad.SelectAll()
            Else
                MessageBox.Show("No existen artículos encontrados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tarticulo.Focus()
                Me.tarticulo.SelectAll()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub tcodproveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tcodproveedor.KeyDown
        If e.KeyCode = Keys.F2 Then
            Dim men As New frm_gridproveedor
            men.vie = Me
            men.ShowDialog()
        End If

    End Sub

    Private Sub tdoc2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdoc2.LostFocus
        Try
            If INICIAS = False Then
                INICIAS = True
                Exit Sub
            End If

            'If Me.tcodproveedor.Text.Trim = "" Then
            '    INICIAS = False
            '    MessageBox.Show("Ingrese el Proveedor", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'Else
            '    INICIAS = True
            'End If

            If tdoc2.Text.Trim = "" Then
                MessageBox.Show("Ingrese el Nro de Documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tdoc2.Focus()
                INICIAS = True
                Exit Sub
            Else
                Me.tdoc2.Text = Strings.Right("0000000" + Me.tdoc2.Text.Trim, 7)
                INICIAS = True
            End If


            Conecta("select cdalmacen from movicab where cdtipodoc='" & Me.ctipodoc.SelectedValue.ToString & "' and cdalmacen='" & Me.calmacen.SelectedValue & "' and nrodoc='" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "'  and codempresa='" & codempresa & "' and inout=1", "valida")
            If ds.Tables("valida").Rows.Count > 0 Then
                MessageBox.Show("Nro de Documento ya ingresado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.tdoc2.Text = ""
                Me.tdoc2.Focus()
                Exit Sub
            End If

        Catch x As Exception
        End Try
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        flag = 1
        desbloqueatextbox(Me)
        Me.ComboBox1.Enabled = False
        Me.ctipodoc.Enabled = False
        Me.CheckBox1.Enabled = False
        Me.tlote.Enabled = False
        Me.ComboBox2.Enabled = False
        Me.cboref.Enabled = False
        btnproveedor.Enabled = True
        dtpfecha.Enabled = True
        grid1.Enabled = True
        grid1.ReadOnly = False
        btnarticulo.Enabled = True
        Me.TOBS.Enabled = True
        BTNNUEVO.Enabled = False
        btnmodificar.Enabled = False
        BTNCANCELAR.Enabled = True
        BTNGUARDAR.Enabled = True
        BTNELIMINAR.Enabled = False
        timportacion.ReadOnly = True
        Me.tproveedor.ReadOnly = True
        Me.timport2.ReadOnly = True
        Me.timports.ReadOnly = True

        tdoc1.ReadOnly = True
        tdoc2.ReadOnly = True
        calmacen.Enabled = False
        Me.tmovimiento.ReadOnly = True
        Me.txtdesarticulo.ReadOnly = True
        Me.tmarca.ReadOnly = True
        Me.ttara.ReadOnly = True
        Me.totbruto.ReadOnly = True
        Me.tottara.ReadOnly = True
        Me.totneto.ReadOnly = True
        Me.tottotal.ReadOnly = True
        ttotal.ReadOnly = True
        tlote.Enabled = True
        If Me.CheckBox1.Checked = True Then
            Button2.Enabled = False
            btnproveedor.Enabled = False
            tcodproveedor.ReadOnly = True
        End If
    End Sub
    Public valorizado As Boolean
    Sub verifica_valorizado()
        Try

            'If Me.Button2.Enabled = False Then
            '    Me.DataGridTextBoxColumn23.Width = 100
            '    Me.DataGridTextBoxColumn24.Width = 100
            '    Me.DataGridTextBoxColumn23.HeaderText = "Nro Import/Compra"
            '    Me.DataGridTextBoxColumn24.HeaderText = "Nro Import/Compra"
            'Else
            '    Me.DataGridTextBoxColumn23.Width = 0
            '    Me.DataGridTextBoxColumn24.Width = 0
            '    Me.DataGridTextBoxColumn23.HeaderText = "Nro Import/Compra"
            '    Me.DataGridTextBoxColumn24.HeaderText = "Nro Import/Compra"
            'End If

            Conecta("select valor,provee,pagocred,usumult from tipomovi where cdtipomov='" & Me.ComboBox1.SelectedValue.ToString & "' and estado=0  and codempresa='" & codempresa & "' and inout=1", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                If ds.Tables("llena").Rows(0)(0) = True Then
                    lcosto.Visible = True
                    tcosto.Visible = True
                    ltotal.Visible = True
                    ttotal.Visible = True
                    tottotal.Visible = True
                    Label18.Visible = True
                    Me.DataGridTextBoxColumn18.Width = 75
                    Me.DataGridTextBoxColumn20.Width = 0
                    Me.DataGridTextBoxColumn18.HeaderText = "Costo ."
                    Me.DataGridTextBoxColumn20.HeaderText = "Total ."
                    Me.DataGridTextBoxColumn19.Width = 90
                    Me.DataGridTextBoxColumn21.Width = 90
                    Me.DataGridTextBoxColumn19.HeaderText = "Precio ."
                    Me.DataGridTextBoxColumn21.HeaderText = "Total ."
                    ctipoprecio.Visible = True
                    Label19.Visible = True
                    valorizado = True
                Else
                    lcosto.Visible = False
                    tcosto.Visible = False
                    ltotal.Visible = False
                    ttotal.Visible = False
                    tottotal.Visible = False

                    Me.DataGridTextBoxColumn18.Width = 0
                    Me.DataGridTextBoxColumn20.Width = 0
                    Me.DataGridTextBoxColumn18.HeaderText = ""
                    Me.DataGridTextBoxColumn20.HeaderText = ""
                    Me.DataGridTextBoxColumn19.Width = 0
                    Me.DataGridTextBoxColumn21.Width = 0
                    Me.DataGridTextBoxColumn18.HeaderText = ""
                    Me.DataGridTextBoxColumn20.HeaderText = ""
                    ctipoprecio.Visible = False
                    Label19.Visible = False
                    valorizado = False
                End If
                Me.grid1.Refresh()

                If ds.Tables("llena").Rows(0)(1) = True Then
                    Me.lcodprov.Visible = True
                    Me.lproveedor.Visible = True
                    Me.tcodproveedor.Visible = True
                    Me.tproveedor.Visible = True
                    Me.btnproveedor.Visible = True
                    Me.tcodproveedor.Text = ""
                    Me.tproveedor.Text = ""
                Else
                    Me.lcodprov.Visible = False
                    Me.lproveedor.Visible = False
                    Me.tcodproveedor.Visible = False
                    Me.tproveedor.Visible = False
                    Me.btnproveedor.Visible = False
                    Me.tcodproveedor.Text = "HAL"
                End If

                If ds.Tables("llena").Rows(0)(2) = True Then
                    Me.ltcred.Visible = True
                    Me.ctipocred.Visible = True
                    cred = 1
                Else
                    Me.ltcred.Visible = False
                    Me.ctipocred.Visible = False
                    cred = 0
                End If

                If tcodproveedor.Text.Trim <> "" Then
                    llenaproveedor()
                End If

            End If
        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub

    Public cred As Short, condicion As Boolean = False
    Dim IngresoxImportacion As String
    Sub verifica()

        Conecta("SELECT CDINGTRANSF,CDINGIMP,CDINGCRED,CDINGCOMP FROM CONFIGINV WHERE CODEMPRESA='" & codempresa & "'", "LLENA")

        If ds.Tables("LLENA").Rows.Count > 0 Then
            If Trim(Me.ComboBox1.SelectedValue.ToString) = Trim(ds.Tables("llena").Rows(0)(3)) Then
                condicion = False
                Me.CheckBox1.Enabled = True
                Me.CheckBox1.Checked = True
                Me.Button2.Enabled = True
                timportacion.ReadOnly = True
                Me.CheckBox1.Text = "Con Compra Local"
                Me.Label3.Text = "Nro Compra :"

            ElseIf Trim(Me.ComboBox1.SelectedValue.ToString) = Trim(ds.Tables("llena").Rows(0)(1)) Then
                condicion = False
                Me.CheckBox1.Enabled = True
                Me.CheckBox1.Checked = True
                Me.Button2.Enabled = True
                timportacion.ReadOnly = True
                Me.CheckBox1.Text = "Con Importación"
                Me.Label3.Text = "Nro Importación :"
            Else
                condicion = True
                Me.CheckBox1.Enabled = False
                Me.CheckBox1.Checked = False
                Me.Button2.Enabled = False
                timportacion.ReadOnly = True
            End If

            'If Trim(Me.ComboBox1.SelectedValue.ToString) = Trim(ds.Tables("llena").Rows(0)(1)) Then
            '    condicion = True
            '    Me.CheckBox1.Enabled = True
            '    Me.CheckBox1.Checked = True
            '    Me.Button2.Enabled = True
            '    timportacion.ReadOnly = True
            'Else
            '    condicion = True
            '    Me.CheckBox1.Enabled = True
            '    Me.CheckBox1.Checked = False
            '    Me.Button2.Enabled = True
            '    timportacion.ReadOnly = True
            'End If



        Else
            MessageBox.Show("Falta configurar los Tipos de Ingreso para la Empresa Seleccionada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            condicion = False
            Me.CheckBox1.Enabled = True
            Me.Button2.Enabled = True
            timportacion.ReadOnly = True
        End If

        If Trim(Me.ComboBox1.SelectedValue.ToString) = Trim(ds.Tables("llena").Rows(0)(2)) Then
            GroupBox3.Enabled = False
            'Button3.Enabled = True
            CREDITO = True
        Else
            GroupBox3.Enabled = True
            Button3.Enabled = False
            CREDITO = False
        End If


        If Me.Button2.Enabled = False Then
            Me.DataGridTextBoxColumn25.Width = 115
            Me.DataGridTextBoxColumn26.Width = 115
            Me.DataGridTextBoxColumn25.HeaderText = "Nro Import/Compra"
            Me.DataGridTextBoxColumn26.HeaderText = "Nro Import/Compra"
            Label24.Visible = True
            timports.Visible = True
            timport2.Visible = True
            timportacion.Text = ""
        Else
            Me.DataGridTextBoxColumn25.Width = 0
            Me.DataGridTextBoxColumn26.Width = 0
            Me.DataGridTextBoxColumn25.HeaderText = "Nro Import/Compra"
            Me.DataGridTextBoxColumn26.HeaderText = "Nro Import/Compra"
            Label24.Visible = True
            timport2.Visible = True
            timports.Visible = True
        End If
    End Sub
    Dim CREDITO As Boolean = False
    Friend WithEvents tottara As System.Windows.Forms.TextBox
    Friend WithEvents tottotal As System.Windows.Forms.TextBox
    Friend WithEvents totbruto As System.Windows.Forms.TextBox
    Friend WithEvents totneto As System.Windows.Forms.TextBox
    Private Sub tumedida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tumedida.SelectedIndexChanged
        Conecta("select codumed from umedida where codumed='" & Trim(arrmedidaing.Item(tumedida.SelectedIndex)) & "' and desumed='" & Me.tumedida.Text.Trim.ToUpper & "'", "cuenta")
        If ds.Tables("cuenta").Rows.Count > 0 Then
            ttara.Text = 0
            valor = False 'false cuando se escoge unidades de medida
        Else
            valor = True  'false cuando se escoge medidas
        End If
        codmed = arrmedidaing.Item(Me.tumedida.SelectedIndex)
    End Sub
    Private Sub tcosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcosto.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tcosto.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            If ttotal.Text = "0" Or ttotal.Text.Trim = "" Then
                ttotal.Text = Val(tcosto.Text * tneto.Text).ToString("###0.00000")
            Else
                Call Llena_temp()
            End If
        End If
    End Sub
    Private Sub dtpfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tcambio()
    End Sub
    Sub tcambio()
        Conecta("select tventa from cambio where fecha='" & Me.dtpfecha.Value.ToShortDateString & "' and codempresa='" & codempresa & "'", "tcambio")
        If ds.Tables("tcambio").Rows.Count = 0 Then
            Conecta("select tventa from cambio where codempresa='" & codempresa & "' order by fecha desc", "tcambio2")
            If ds.Tables("tcambio2").Rows.Count > 0 Then
                Me.txtcambio.Text = ds.Tables("tcambio2").Rows(0)(0)
            End If
        Else
            Me.txtcambio.Text = ds.Tables("tcambio").Rows(0)(0)
        End If
    End Sub

    Private Sub ctipoprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipoprecio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If tcodproveedor.ReadOnly = False And tcodproveedor.Visible = True Then
                Me.tcodproveedor.Focus()
                Me.tcodproveedor.SelectAll()
            Else
                If Me.Button2.Enabled = True Then
                    Button2.Focus()
                Else
                    tlote.Focus()
                    tlote.SelectAll()
                End If
            End If

        End If
    End Sub

    Private Sub ctipoprecio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctipoprecio.SelectedIndexChanged
        cargagrilla()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Button2.Enabled = True
            tcodproveedor.ReadOnly = True
            btnproveedor.Enabled = False
        Else
            Button2.Enabled = False
            timportacion.Text = ""
            tcodproveedor.ReadOnly = False
            btnproveedor.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim men As New frm_gridimp_ingresos
        men.vie = Me
        men.ShowDialog()

        If Len(Me.timportacion.Text.Trim) = 0 Then
            Me.timportacion.Focus()
        Else
            Me.tlote.Focus()
        End If
    End Sub

    Private Sub combobox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If ctipocred.Visible = True Then
                ctipocred.Focus()
            Else
                btnarticulo.Focus()
            End If
        End If
    End Sub

    Private Sub ctipocred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ctipocred.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnarticulo.Focus()
        End If
    End Sub

    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Trim(ComboBox1.SelectedValue.ToString()) = CODINGXTRANS Then
            Dim objFRMINGXTRANSFER As New FRMINGXTRANSFER
            objFRMINGXTRANSFER.objfrming_otros = Me
            objFRMINGXTRANSFER.ShowDialog()
            TREF.Focus()
        Else
            TmpInsertDatos("DELETE FROM TMP_MOVIDET WHERE CDCOMPRA='" & correl & "' AND CODEMPRESA='" & codempresa & "'")

            Dim men As New frm_gridnotacred
            men.vie = Me
            men.ShowDialog()
        End If

    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call ComboBox1_SelectedIndexChanged(sender, e)
            ctipodoc.Focus()
            If ComboBox1.SelectedValue = CODINGXTRANS Then
                Button3.Enabled = True
            End If
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If sw = True Then
            verifica_valorizado()
            verifica()
            If Trim(ComboBox1.SelectedValue.ToString()) = CODINGXTRANS Then
                Button3.Enabled = True
            End If
            Conecta("select correlativo from tipomovi where codempresa='" & codempresa & "' and cdtipomov='" & Me.ComboBox1.SelectedValue.ToString & "'", "indice")
            If ds.Tables("indice").Rows.Count > 0 Then
                Me.tmovimiento.Text = Trim(ds.Tables("indice").Rows(0)(0))
            End If
        End If
    End Sub
    Private Sub ComboBox2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.ComboBox1.Focus()
        End If
    End Sub
    Private Sub tlote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tlote.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Len(Me.tlote.Text.Trim) = 0 Then
                MsgBox("Ingrese Un Lote Por Favor Para el Ingreso de Mercderia" + Chr(13) + "Gracias ..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
                Me.tlote.Focus()
            Else
                Me.tarticulo.Focus()
            End If
        End If
    End Sub
    Private Sub TREF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TREF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CREDITO = True Then
                If Me.TREF.Text.Trim = "" Then
                    Button3_Click(sender, e)
                Else
                    Try
                        Conecta("nsp_select_nta_credito '" & codempresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.dtpfecha.Value), "MM/dd/yy") & "','','" & Val(Strings.Right("000" + CType(Me.tdoc1.Text.Trim, String), 3) + Strings.Right("000000" + CType(Me.tdoc2.Text.Trim, String), 6)) & "',0,'" & Me.calmacen.SelectedValue.ToString & "'", "llena")

                        If ds.Tables("LLENA").Rows.Count > 0 Then
                            ctipodoc.SelectedValue = Trim(ds.Tables("LLENA").Rows(0)(0))


                            ctipoprecio.SelectedValue = Trim(ds.Tables("LLENA").Rows(0)(4))
                            txtcambio.Text = Trim(ds.Tables("LLENA").Rows(0)(5))


                            If bomedidaing = True And boumedidaing = False Then
                                Ds_diferencia_de_reportes1.Clear()

                                Conecta("NSP_SELECT_NTACRED '" & codempresa & "','" & Trim(ds.Tables("LLENA").Rows(0)(2)) & "',0", "LLENA")
                                oda.Fill(Ds_diferencia_de_reportes1.Tables(0))
                                grid1.Refresh()

                            ElseIf bomedidaing = False And boumedidaing = True Then

                                DsInventInicial1.Clear()

                                Conecta("NSP_SELECT_NTACRED '" & codempresa & "','" & Trim(ds.Tables("LLENA").Rows(0)(2)) & "',1", "LLENA")
                                oda.Fill(DsInventInicial1.Tables(0))
                                grid1.Refresh()


                            ElseIf bomedidaing = True And boumedidaing = True Then

                                Ds_diferencia_de_reportes1.Clear()

                                Conecta("NSP_SELECT_NTACRED '" & codempresa & "','" & Trim(ds.Tables("LLENA").Rows(0)(2)) & "',0", "LLENA")
                                oda.Fill(Ds_diferencia_de_reportes1.Tables(0))
                                grid1.Refresh()

                            End If

                        Else
                            MessageBox.Show("0 Registros Encontrados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If



                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End If

            If Me.ctipoprecio.Visible = True Then
                Me.ctipoprecio.Focus()
            Else
                If Button2.Enabled = True Then
                    Button2.Focus()
                Else
                    tlote.Focus()
                    tlote.SelectAll()
                End If
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '''''''''''''VERIFICA SI EXISTE SALIDA PARA EL INGRESO A GENERAR''''''''''''''''''''''''''''''''''''
            '''''''''''''EN CASO DE NO HABER NO PERMITIRA GENERAR EL INGRESO POR TRANSFERENCIA''''''''''''''''''
            If Trim(ComboBox1.SelectedValue.ToString()) = CODINGXTRANS Then
                'Dim CLSDAT As New clsdatos_JHON
                'Dim CLSINTER As New ClsInterface
                Dim RESP As Boolean = False
                Dim ESTADO As String
                Dim tabla As DataTable
                tabla = CAyuda.ListarDatos("SP_VERF_ESTADO_TRANSF", calmacen.SelectedValue, TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim).Tables(0)
                If tabla.Rows.Count > 0 Then
                    ESTADO = tabla.Rows(0)(0)
                    If ESTADO = "0" Then
                        TmpInsertDatos("SP_INSERT_SALIDA_TRANSF_TMP_MOVI '" & calmacen.SelectedValue & "','" & TxtDocRef1.Text.Trim + "-" + TREF.Text.Trim & "','" & CodUsuario & "','" & CODINGXTRANS & "','" & correl & "'," & Me.tmovimiento.Text.Trim & ",'" & NROPTOVTA & "'")
                        cargagrilla()
                    Else
                        MsgBox("El ingreso para este almacen ya fue realizado, Gracias..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                    End If
                Else
                    MsgBox("No existe salida para este documento de ingreso, Verifique el almacen,y el numero de documento de referencia", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                End If

                tabla = Nothing
                'CLSDAT = Nothing
                'CLSINTER = Nothing
                ctipoprecio.Focus()
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''
        End If
    End Sub
    Public Sub calmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calmacen.SelectedIndexChanged
        If CONTACOMBO > 2 Then
            Dim cdalmacen As String = ""
            If calmacen.SelectedValue.ToString <> "" Then
                cdalmacen = calmacen.SelectedValue.ToString
            End If
            CAyuda.CargarDataCombo(Me.ComboBox2, "nsp_escoge_alm_ptoventa '" & codempresa & "','" & cdalmacen & "'", "nro", "des")
            tdoc1.Text = calmacen.SelectedValue.ToString
        End If
        CONTACOMBO += 1
    End Sub
    Private Sub cboref_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboref.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtDocRef1.Focus()
            TxtDocRef1.SelectAll()
        End If
    End Sub
    Private Sub TxtDocRef1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDocRef1.LostFocus
        TxtDocRef1.Text = Strings.Right("000" + TxtDocRef1.Text.Trim, 3)
    End Sub
    Private Sub TREF_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TREF.LostFocus
        TREF.Text = Strings.Right("0000000" + TREF.Text.Trim, 7)
    End Sub
    Private Sub frm_guiaing_otros_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        sw = False
    End Sub
    Private Sub TxtDocRef1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDocRef1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TREF.Focus()
        End If
    End Sub
    Private Sub tdoc1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdoc1.LostFocus
        tdoc1.Text = Strings.Right("000" & tdoc1.Text.Trim, 3)
    End Sub
    Dim o, x As Integer
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNANULAR.Click
        If MessageBox.Show("¿Desea Anular el presente documento?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Dim Flat As Boolean
            Flat = TmpInsertDatos("SP_ANULADOCS_SALIDAS '" & tlote.Text.Trim & "','" & ComboBox1.SelectedValue & "'," & tmovimiento.Text.Trim & ",'" & tdoc1.Text.Trim & "-" & tdoc2.Text.Trim & "','" & codempresa & "'")

            If Flat = True Then
                'TmpInsertDatos("delete from salidasvssaldos where nromovsal='" & Me.tmovimiento.Text.Trim & "' and codempresa='" & CodEmpresa & "'")
                TmpInsertDatos("UPDATE  movidet SET estado='1' where cdcompra='" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "' and codempresa='" & codempresa & "' and inout=1")
                TmpInsertDatos("UPDATE  movicab SET estado='1' where nrodoc='" & CType(Me.tdoc1.Text.Trim, String) + "-" + CType(Me.tdoc2.Text.Trim, String) & "' and nromovi=" & Me.tmovimiento.Text.Trim & "AND CODEMPRESA = '" & codempresa & "' and inout=1")
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & tmovimiento.Text & "','ANULAR','GUIAING_OTROS','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")

                BTNNUEVO.Enabled = True
                BTNGUARDAR.Enabled = False
                btnmodificar.Enabled = False
                BTNCANCELAR.Enabled = False
                Bloqueatextbox(Me)
                btnarticulo.Enabled = False
                btnproveedor.Enabled = False
                Me.dtpfvenc.Enabled = False
                sololectura()
            End If
        End If
    End Sub

    Private Sub tlote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlote.TextChanged

    End Sub

    Private Sub ctipodoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ctipodoc.SelectedIndexChanged

    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
    Private Sub grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grid1.KeyDown
        Try
            Dim sql As String
            Dim PROCESO As Boolean

            If e.KeyCode = Keys.F3 Then

                Conecta("SELECT cdcompra,corrnbr FROM TMP_moviDET WHERE codempresa='" & codempresa & "' and cdcompra='" & correl & "' and inout=1 order by corrnbr", "paz")
                If ds.Tables("paz").Rows.Count = 0 Then
                    calmacen.Enabled = True
                    ComboBox1.Enabled = True
                    Exit Sub
                End If


                If MessageBox.Show("Desea eliminar el Registro Seleccionado", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    sql = "nsp_dele_TMP_moviDET " & grid1.Item(grid1.CurrentRowIndex, 0) & "," & correl & ",'" & codempresa & "',1,'" & Trim(Me.ComboBox1.SelectedValue.ToString()) & "','" & CodUsuario & "','" & NROPTOVTA & "','" & Trim(Me.grid1.Item(grid1.CurrentRowIndex, 1).ToString()) & "'"
                    PROCESO = TmpInsertDatos(sql)

                    'Dim l As Integer
                    'Conecta("SELECT cdcompra,corrnbr FROM TMP_moviDET WHERE codempresa='" & CodEmpresa & "' and cdcompra='" & correl & "' and inout=1 order by corrnbr", "pa")
                    ''CONT -= 1
                    'For l = 0 To ds.Tables("pa").Rows.Count - 1
                    '    TmpInsertDatos("update tmp_movidet set corrnbr=" & Val(l + 1) & " where cdcompra='" & Trim(ds.Tables("pa").Rows(l)(0)) & "' and corrnbr='" & Trim(ds.Tables("pa").Rows(l)(1)) & "' and inout=1")
                    'Next

                    cargagrilla()
                End If

            End If

        Catch x As Exception

        End Try

    End Sub
    Private Sub tlote_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tlote.LostFocus
        If Len(Me.tlote.Text.Trim) = 0 Then
            MsgBox("Ingrese Un Lote Por Favor Para el Ingreso de Mercderia" + Chr(13) + "Gracias ..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C")
            Me.tlote.Focus()
        Else
            Me.tarticulo.Focus()
        End If
    End Sub

    Private Sub tneto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tneto.TextChanged

    End Sub

    Private Sub tcosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tcosto.TextChanged

    End Sub

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub timport2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timport2.TextChanged


    End Sub

    Private Sub timport2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles timport2.KeyPress
        If Asc(e.KeyChar) = 13 Then

        End If
    End Sub

    Private Sub tdoc2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdoc2.TextChanged

    End Sub

    Private Sub tmovimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmovimiento.TextChanged

    End Sub
End Class
