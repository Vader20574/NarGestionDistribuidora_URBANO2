
Imports System.Data.SqlClient
Imports System.Transactions
Imports System.Data.Odbc
Imports Servicios.Interfaces.Factura
Imports Servicios.Implementacion
Imports Servicios.Interfaces.FacturaElectronica.Peticiones
Imports Servicios.Interfaces.Facturacion
Imports Servicios.Interfaces.Facturacion.Peticiones
Imports Servicios.Interfaces.Facturacion.VentaDet.Peticiones

Public Class FrmFacturacion_Pedidos
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
    Friend WithEvents GridClientes As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarFactura As System.Windows.Forms.Button
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cboVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents BtnTodasGuias As System.Windows.Forms.Button
    Friend WithEvents LblmensajeTipoDoc As System.Windows.Forms.Label
    Friend WithEvents GridCabcera As System.Windows.Forms.DataGrid
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
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblOrdenDesp As System.Windows.Forms.Label
    Friend WithEvents btnBusOrden As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents DtFechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacturacion_Pedidos))
        Me.btnGenerarFactura = New System.Windows.Forms.Button()
        Me.GridClientes = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GridCabcera = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboVendedor = New System.Windows.Forms.ComboBox()
        Me.Rpt1 = New AxCrystal.AxCrystalReport()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtFechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BtnTodasGuias = New System.Windows.Forms.Button()
        Me.LblmensajeTipoDoc = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblOrdenDesp = New System.Windows.Forms.Label()
        Me.btnBusOrden = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCabcera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerarFactura
        '
        Me.btnGenerarFactura.Location = New System.Drawing.Point(4, 8)
        Me.btnGenerarFactura.Name = "btnGenerarFactura"
        Me.btnGenerarFactura.Size = New System.Drawing.Size(94, 36)
        Me.btnGenerarFactura.TabIndex = 0
        Me.btnGenerarFactura.Text = "Generar Documento"
        '
        'GridClientes
        '
        Me.GridClientes.CaptionText = "Clienrtes a Facturar"
        Me.GridClientes.DataMember = ""
        Me.GridClientes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridClientes.Location = New System.Drawing.Point(919, 10)
        Me.GridClientes.Name = "GridClientes"
        Me.GridClientes.ReadOnly = True
        Me.GridClientes.Size = New System.Drawing.Size(512, 204)
        Me.GridClientes.TabIndex = 4
        Me.GridClientes.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.GridClientes.Visible = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridClientes
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'GridCabcera
        '
        Me.GridCabcera.CaptionText = "Clienrtes a Facturar"
        Me.GridCabcera.DataMember = ""
        Me.GridCabcera.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridCabcera.Location = New System.Drawing.Point(8, 152)
        Me.GridCabcera.Name = "GridCabcera"
        Me.GridCabcera.ReadOnly = True
        Me.GridCabcera.Size = New System.Drawing.Size(782, 312)
        Me.GridCabcera.TabIndex = 5
        Me.GridCabcera.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.GridCabcera
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "TIPO DOC."
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 110
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "CodTipoDoc"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = "0##-#######"
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "NroDocu"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 70
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "CodEmpresa"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "CodCliente"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 70
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Dato Adjunto"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 150
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "RUC"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 70
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Direccion"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 150
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "CodTipoPago"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 0
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Tipo Pago"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 70
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn22.Format = "#######0.00"
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Total"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 60
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "NUM_PEDIDO"
        Me.DataGridTextBoxColumn23.Width = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(536, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Usuario : "
        '
        'cboVendedor
        '
        Me.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboVendedor.Enabled = False
        Me.cboVendedor.Location = New System.Drawing.Point(604, 42)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(152, 21)
        Me.cboVendedor.TabIndex = 8
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(6, 114)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(572, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Doc : "
        '
        'DtFechaDoc
        '
        Me.DtFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaDoc.Location = New System.Drawing.Point(648, 10)
        Me.DtFechaDoc.Name = "DtFechaDoc"
        Me.DtFechaDoc.Size = New System.Drawing.Size(96, 20)
        Me.DtFechaDoc.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(4, 92)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 36)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        '
        'BtnTodasGuias
        '
        Me.BtnTodasGuias.Location = New System.Drawing.Point(919, 221)
        Me.BtnTodasGuias.Name = "BtnTodasGuias"
        Me.BtnTodasGuias.Size = New System.Drawing.Size(214, 32)
        Me.BtnTodasGuias.TabIndex = 5
        Me.BtnTodasGuias.Text = "Cargar Todas Ordenes de despacho Pendientes"
        Me.BtnTodasGuias.Visible = False
        '
        'LblmensajeTipoDoc
        '
        Me.LblmensajeTipoDoc.BackColor = System.Drawing.Color.White
        Me.LblmensajeTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblmensajeTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblmensajeTipoDoc.Location = New System.Drawing.Point(12, 108)
        Me.LblmensajeTipoDoc.Name = "LblmensajeTipoDoc"
        Me.LblmensajeTipoDoc.Size = New System.Drawing.Size(776, 30)
        Me.LblmensajeTipoDoc.TabIndex = 2
        Me.LblmensajeTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnAgregar)
        Me.Panel1.Controls.Add(Me.LblOrdenDesp)
        Me.Panel1.Controls.Add(Me.btnBusOrden)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DtFechaDoc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboVendedor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(20, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 76)
        Me.Panel1.TabIndex = 1
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(13, 39)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(214, 32)
        Me.BtnAgregar.TabIndex = 6
        Me.BtnAgregar.Text = "Cargar la Orden de Despacho seleccionado"
        '
        'LblOrdenDesp
        '
        Me.LblOrdenDesp.BackColor = System.Drawing.Color.White
        Me.LblOrdenDesp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblOrdenDesp.Location = New System.Drawing.Point(190, 2)
        Me.LblOrdenDesp.Name = "LblOrdenDesp"
        Me.LblOrdenDesp.Size = New System.Drawing.Size(106, 23)
        Me.LblOrdenDesp.TabIndex = 1
        Me.LblOrdenDesp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBusOrden
        '
        Me.btnBusOrden.ImageIndex = 5
        Me.btnBusOrden.ImageList = Me.ImageList1
        Me.btnBusOrden.Location = New System.Drawing.Point(298, 2)
        Me.btnBusOrden.Name = "btnBusOrden"
        Me.btnBusOrden.Size = New System.Drawing.Size(34, 26)
        Me.btnBusOrden.TabIndex = 2
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "NRO ORDEN DESPACHO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cargar Orden de Despacho"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnGenerarFactura)
        Me.Panel2.Location = New System.Drawing.Point(796, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(106, 138)
        Me.Panel2.TabIndex = 6
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(4, 50)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(94, 36)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.White
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.Location = New System.Drawing.Point(680, 476)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblTotal.Size = New System.Drawing.Size(106, 23)
        Me.LblTotal.TabIndex = 8
        Me.LblTotal.Text = "0.00"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(592, 480)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Monto Total: "
        '
        'FrmFacturacion_Pedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(915, 582)
        Me.Controls.Add(Me.GridCabcera)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTodasGuias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblmensajeTipoDoc)
        Me.Controls.Add(Me.GridClientes)
        Me.Controls.Add(Me.Rpt1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmFacturacion_Pedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion de Pedidos Cargados "
        CType(Me.GridClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCabcera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables"
    Private TABLE_PEDIDOS_FACTURAR As New DataTable
    Private CORRELATIVO As String
    Private NRODOCUMENTO As String
    Private CODZONA As String
    Private NomMaq As String
    Private STRNROPTOVTA As String
    Dim TABLE_CABECERA_PEDI As New DataTable
    Dim TABLE_DETALLE_PEDI As New DataTable
    '-------------------------------------------------------
    Private NROBOLETA As Integer
    Private NROFACTURA As Integer
    Private NRONOTA_PEDIDO As Integer
    Private CONTBOL As Integer
    Private CONTFACT As Integer
    Private CONTNTAPE As Integer
    Private ITEMFACT As Integer
    Private ITEMBOL As Integer
    Private ITEMNTAPED As Integer
    '-------------------------------------------------------
    Private TABLE_DETALLE_VERIFI As New DataTable
    Private NROMAXIMO As Integer
    Private NROMINIMO As Integer
    Public TablaARTI_FZAVENTA As New DataTable
    Private TABLE_CONSOLCLIE As New DataTable
    Dim GUIAD As String
    Dim GUIAC As String

    Dim SERIE As String
    Dim NRODOCSIN As String
    Dim NRODOCFINAL As String
    Dim LETRADOC As String
    Dim CLIE_DOCU As String



    Dim DNI As String
    Dim IGV As Double
    Dim EMAIL As String
    Dim SUBTOTAL As Double
    Dim PERCEP As Double
    Dim TIPO_IGV As String


    Dim listaP As New List(Of NuevaVentaDet)
    Dim listaDesc As New List(Of DescDdocum)

#End Region
#Region "Funciones del Formulario"
    Public Function GRABAEFECTIVOS(ByVal CODTIDOC As String, ByVal NRODOCUM As String, ByVal CODTIPOPAGO As String, ByVal fechadocum As Date, ByVal TOTBAS As Double, ByVal PORCENDESC As Double, ByVal CODIGOCLIE As String, ByVal DESCLIE As String, ByVal CLIERUC As String, ByVal DIRECC As String, ByVal CODDEP As String, ByVal NRODESPACHO As String, ByVal CODVEND As String) As Boolean

        Dim AFEC As Integer
        Try
            Dim cn2 As New SqlConnection(STRCN)
            If cn2.State = ConnectionState.Open Then
                cn2.Close()
            End If
            cn2.Open()
            Dim transaction As SqlTransaction  '//  
            transaction = cn2.BeginTransaction(Data.IsolationLevel.ReadCommitted) '//

            Dim cmd2 As New SqlCommand("Nsp_grabadocumento", cn2)
            cmd2.CommandType = CommandType.StoredProcedure

            cmd2.Parameters.Add("@NRODEGUIAS", SqlDbType.VarChar).Value = CStr(NRODESPACHO)
            cmd2.Parameters.Add("@NPESADA", SqlDbType.VarChar).Value = CStr("")
            cmd2.Parameters.Add("@Eigv", SqlDbType.VarChar).Value = CStr("True")
            cmd2.Parameters.Add("@actualizocorrelativo", SqlDbType.VarChar).Value = CStr("False")
            cmd2.Parameters.Add("@NUMEROTRANS", SqlDbType.Int).Value = CInt(0)
            cmd2.Parameters.Add("@CODDEP", SqlDbType.VarChar).Value = CStr(CODDEP)
            cmd2.Parameters.Add("@CODTIPOPAGO", SqlDbType.VarChar).Value = CODTIPOPAGO.Trim
            cmd2.Parameters.Add("@CODTIPODOC", SqlDbType.VarChar).Value = CStr(CODTIDOC)
            cmd2.Parameters.Add("@NRODOCU", SqlDbType.VarChar).Value = CStr(NRODOCUM)
            cmd2.Parameters.Add("@codmon", SqlDbType.VarChar).Value = CStr(CDMONBASE)
            cmd2.Parameters.Add("@CAMBIO", SqlDbType.Decimal).Value = CDec(VCambioVta)
            cmd2.Parameters.Add("@codvend", SqlDbType.VarChar).Value = CODVEND
            cmd2.Parameters.Add("@FECDOCUM", SqlDbType.DateTime).Value = fechadocum
            cmd2.Parameters.Add("@TOTBAS", SqlDbType.Decimal).Value = CDec(TOTBAS)
            cmd2.Parameters.Add("@PORCENDESC1", SqlDbType.Decimal).Value = CDec(PORCENDESC)
            cmd2.Parameters.Add("@TOTVUELTOBAS", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@TOTCASHBAS", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@TOTCASHEXT", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@codcliente", SqlDbType.VarChar).Value = CStr(CODIGOCLIE)
            cmd2.Parameters.Add("@RUCCLIENTE", SqlDbType.VarChar).Value = CStr(CLIERUC)
            cmd2.Parameters.Add("@DESCLIENTE", SqlDbType.VarChar).Value = CStr(DESCLIE)
            cmd2.Parameters.Add("@DIRCLIENTE", SqlDbType.VarChar).Value = CStr(DIRECC)
            cmd2.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = CStr(CodUsuario)
            cmd2.Parameters.Add("@CODEMPRESA", SqlDbType.VarChar).Value = CStr(codempresa)
            cmd2.Parameters.Add("@MONEDABASE", SqlDbType.VarChar).Value = CStr(CDMONBASE)
            cmd2.Parameters.Add("@NROPTOVTA", SqlDbType.VarChar).Value = CStr(NROPTOVTA)
            cmd2.Parameters.Add("@CORRELATIVO", SqlDbType.Int).Value = CInt(rand)

            cmd2.Parameters.Add("@CDTARJETA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@MONEDATARJ", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTTARJBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@NROTARJETA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@MONEDACHEQUE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@CDBANCO", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROCHEQUE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROCUENTA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTCHEQBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@TOTCREDBAS", SqlDbType.Decimal).Value = CDec(TOTBAS)
            cmd2.Parameters.Add("@CDMONEDACRED", SqlDbType.VarChar).Value = "S"
            cmd2.Parameters.Add("@MONEDAVALE", SqlDbType.Int).Value = CInt(rand)


            cmd2.Parameters.Add("@REFERENCIA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROVALE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTVALEBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@POSTPAGO", SqlDbType.Int).Value = 0

            ', rand, "", "", 0, "", "", "", "", "", 0, TxtTOTAL.Text, CboMoneda.SelectedValue) > 0 Then

            Try

                Dim Dt_TimeOut As Integer = 500000
                cmd2.CommandTimeout = Dt_TimeOut
                cmd2.Transaction = transaction '//
                AFEC = cmd2.ExecuteNonQuery()
                transaction.Commit()   '//

                ''MsgBox("se grabo ...")
                cn2.Close()

                Return True
                'TIPOOPERACION = TblCtaCte.Rows(0)("TIPOOPERACION")
                'DOMICILIOFISCAL = TblCtaCte.Rows(0)("CODDOMFISCAL")
                'RUTAARCHIVO = TblCtaCte.Rows(0)("RUTA_ARCHIVO")

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
        'insert_store("SP_REGISTRA_AUDITORIA '" & txtnroguias.Text & "','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy") & "','" & CodUsuario & "','" & codempresa & "'")
        'Dim obj As New ClsInterface
        Try
            'obj.gGrabarReg("INSERT_CLI_POST_VTA", codempresa, VarTipoDoc.Trim, TXTNUMERODOC.Text.Trim)
        Catch ex As Exception
        End Try
    End Function




    Public Function GRABAEFECTIVOS2(ByVal CODTIDOC As String, ByVal NRODOCUM As String, ByVal CODTIPOPAGO As String, ByVal fechadocum As Date, ByVal TOTBAS As Double, ByVal PORCENDESC As Double, ByVal CODIGOCLIE As String, ByVal DESCLIE As String, ByVal CLIERUC As String, ByVal DIRECC As String, ByVal CODDEP As String, ByVal NRODESPACHO As String, ByVal CODVEND As String, ByVal CODLINEA As String) As Boolean

        Dim AFEC As Integer
        Try
            Dim cn2 As New SqlConnection(STRCN)
            If cn2.State = ConnectionState.Open Then
                cn2.Close()
            End If
            cn2.Open()
            Dim transaction As SqlTransaction  '//  
            transaction = cn2.BeginTransaction(Data.IsolationLevel.ReadCommitted) '//

            Dim cmd2 As New SqlCommand("Nsp_grabadocumentoXLinea", cn2)
            cmd2.CommandType = CommandType.StoredProcedure

            cmd2.Parameters.Add("@NRODEGUIAS", SqlDbType.VarChar).Value = CStr(NRODESPACHO)
            cmd2.Parameters.Add("@NPESADA", SqlDbType.VarChar).Value = CStr("")
            cmd2.Parameters.Add("@Eigv", SqlDbType.VarChar).Value = CStr("True")
            cmd2.Parameters.Add("@actualizocorrelativo", SqlDbType.VarChar).Value = CStr("False")
            cmd2.Parameters.Add("@NUMEROTRANS", SqlDbType.Int).Value = CInt(0)
            cmd2.Parameters.Add("@CODDEP", SqlDbType.VarChar).Value = CStr(CODDEP)
            cmd2.Parameters.Add("@CODTIPOPAGO", SqlDbType.VarChar).Value = CODTIPOPAGO.Trim
            cmd2.Parameters.Add("@CODTIPODOC", SqlDbType.VarChar).Value = CStr(CODTIDOC)
            cmd2.Parameters.Add("@NRODOCU", SqlDbType.VarChar).Value = CStr(NRODOCUM)
            cmd2.Parameters.Add("@codmon", SqlDbType.VarChar).Value = CStr(CDMONBASE)
            cmd2.Parameters.Add("@CAMBIO", SqlDbType.Decimal).Value = CDec(VCambioVta)
            cmd2.Parameters.Add("@codvend", SqlDbType.VarChar).Value = CODVEND
            cmd2.Parameters.Add("@FECDOCUM", SqlDbType.DateTime).Value = fechadocum
            cmd2.Parameters.Add("@TOTBAS", SqlDbType.Decimal).Value = CDec(TOTBAS)
            cmd2.Parameters.Add("@PORCENDESC1", SqlDbType.Decimal).Value = CDec(PORCENDESC)
            cmd2.Parameters.Add("@TOTVUELTOBAS", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@TOTCASHBAS", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@TOTCASHEXT", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@codcliente", SqlDbType.VarChar).Value = CStr(CODIGOCLIE)
            cmd2.Parameters.Add("@RUCCLIENTE", SqlDbType.VarChar).Value = CStr(CLIERUC)
            cmd2.Parameters.Add("@DESCLIENTE", SqlDbType.VarChar).Value = CStr(DESCLIE)
            cmd2.Parameters.Add("@DIRCLIENTE", SqlDbType.VarChar).Value = CStr(DIRECC)
            cmd2.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = CStr(CodUsuario)
            cmd2.Parameters.Add("@CODEMPRESA", SqlDbType.VarChar).Value = CStr(codempresa)
            cmd2.Parameters.Add("@MONEDABASE", SqlDbType.VarChar).Value = CStr(CDMONBASE)
            cmd2.Parameters.Add("@NROPTOVTA", SqlDbType.VarChar).Value = CStr(NROPTOVTA)
            cmd2.Parameters.Add("@CORRELATIVO", SqlDbType.Int).Value = CInt(rand)

            cmd2.Parameters.Add("@CDTARJETA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@MONEDATARJ", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTTARJBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@NROTARJETA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@MONEDACHEQUE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@CDBANCO", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROCHEQUE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROCUENTA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTCHEQBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@TOTCREDBAS", SqlDbType.Decimal).Value = CDec(TOTBAS)
            cmd2.Parameters.Add("@CDMONEDACRED", SqlDbType.VarChar).Value = "S"
            cmd2.Parameters.Add("@MONEDAVALE", SqlDbType.Int).Value = CInt(rand)


            cmd2.Parameters.Add("@REFERENCIA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROVALE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTVALEBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@POSTPAGO", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@CODLINEA", SqlDbType.VarChar).Value = CStr(CODLINEA)
            ', rand, "", "", 0, "", "", "", "", "", 0, TxtTOTAL.Text, CboMoneda.SelectedValue) > 0 Then

            Try

                Dim Dt_TimeOut As Integer = 500000
                cmd2.CommandTimeout = Dt_TimeOut
                cmd2.Transaction = transaction '//
                AFEC = cmd2.ExecuteNonQuery()
                transaction.Commit()   '//

                ''MsgBox("se grabo ...")
                cn2.Close()

                Return True
                'TIPOOPERACION = TblCtaCte.Rows(0)("TIPOOPERACION")
                'DOMICILIOFISCAL = TblCtaCte.Rows(0)("CODDOMFISCAL")
                'RUTAARCHIVO = TblCtaCte.Rows(0)("RUTA_ARCHIVO")

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
        'insert_store("SP_REGISTRA_AUDITORIA '" & txtnroguias.Text & "','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy") & "','" & CodUsuario & "','" & codempresa & "'")
        'Dim obj As New ClsInterface
        Try
            'obj.gGrabarReg("INSERT_CLI_POST_VTA", codempresa, VarTipoDoc.Trim, TXTNUMERODOC.Text.Trim)
        Catch ex As Exception
        End Try
    End Function



    Public Function GRABAEFECTIVOS3(ByVal CODTIDOC As String, ByVal NRODOCUM As String, ByVal CODTIPOPAGO As String, ByVal fechadocum As Date, ByVal TOTBAS As Double, ByVal PORCENDESC As Double, ByVal CODIGOCLIE As String, ByVal DESCLIE As String, ByVal CLIERUC As String, ByVal DIRECC As String, ByVal CODDEP As String, ByVal NRODESPACHO As String, ByVal CODVEND As String, ByVal CODSUBEMPRESA As String) As Boolean

        Dim AFEC As Integer
        Try
            Dim cn2 As New SqlConnection(STRCN)
            If cn2.State = ConnectionState.Open Then
                cn2.Close()
            End If
            cn2.Open()
            Dim transaction As SqlTransaction  '//  
            transaction = cn2.BeginTransaction(Data.IsolationLevel.ReadCommitted) '//

            Dim cmd2 As New SqlCommand("Nsp_grabadocumentoXSubEmpresa", cn2)
            cmd2.CommandType = CommandType.StoredProcedure

            cmd2.Parameters.Add("@NRODEGUIAS", SqlDbType.VarChar).Value = CStr(NRODESPACHO)
            cmd2.Parameters.Add("@NPESADA", SqlDbType.VarChar).Value = CStr("")
            cmd2.Parameters.Add("@Eigv", SqlDbType.VarChar).Value = CStr("True")
            cmd2.Parameters.Add("@actualizocorrelativo", SqlDbType.VarChar).Value = CStr("False")
            cmd2.Parameters.Add("@NUMEROTRANS", SqlDbType.Int).Value = CInt(0)
            cmd2.Parameters.Add("@CODDEP", SqlDbType.VarChar).Value = CStr(CODDEP)
            cmd2.Parameters.Add("@CODTIPOPAGO", SqlDbType.VarChar).Value = CODTIPOPAGO.Trim
            cmd2.Parameters.Add("@CODTIPODOC", SqlDbType.VarChar).Value = CStr(CODTIDOC)
            cmd2.Parameters.Add("@NRODOCU", SqlDbType.VarChar).Value = CStr(NRODOCUM)
            cmd2.Parameters.Add("@codmon", SqlDbType.VarChar).Value = CStr(CDMONBASE)
            cmd2.Parameters.Add("@CAMBIO", SqlDbType.Decimal).Value = CDec(VCambioVta)
            cmd2.Parameters.Add("@codvend", SqlDbType.VarChar).Value = CODVEND
            cmd2.Parameters.Add("@FECDOCUM", SqlDbType.DateTime).Value = fechadocum
            cmd2.Parameters.Add("@TOTBAS", SqlDbType.Decimal).Value = CDec(TOTBAS)
            cmd2.Parameters.Add("@PORCENDESC1", SqlDbType.Decimal).Value = CDec(PORCENDESC)
            cmd2.Parameters.Add("@TOTVUELTOBAS", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@TOTCASHBAS", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@TOTCASHEXT", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@codcliente", SqlDbType.VarChar).Value = CStr(CODIGOCLIE)
            cmd2.Parameters.Add("@RUCCLIENTE", SqlDbType.VarChar).Value = CStr(CLIERUC)
            cmd2.Parameters.Add("@DESCLIENTE", SqlDbType.VarChar).Value = CStr(DESCLIE)
            cmd2.Parameters.Add("@DIRCLIENTE", SqlDbType.VarChar).Value = CStr(DIRECC)
            cmd2.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = CStr(CodUsuario)
            cmd2.Parameters.Add("@CODEMPRESA", SqlDbType.VarChar).Value = CStr(codempresa)
            cmd2.Parameters.Add("@MONEDABASE", SqlDbType.VarChar).Value = CStr(CDMONBASE)
            cmd2.Parameters.Add("@NROPTOVTA", SqlDbType.VarChar).Value = CStr(NROPTOVTA)
            cmd2.Parameters.Add("@CORRELATIVO", SqlDbType.Int).Value = CInt(rand)

            cmd2.Parameters.Add("@CDTARJETA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@MONEDATARJ", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTTARJBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@NROTARJETA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@MONEDACHEQUE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@CDBANCO", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROCHEQUE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROCUENTA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTCHEQBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@TOTCREDBAS", SqlDbType.Decimal).Value = CDec(TOTBAS)
            cmd2.Parameters.Add("@CDMONEDACRED", SqlDbType.VarChar).Value = "S"
            cmd2.Parameters.Add("@MONEDAVALE", SqlDbType.Int).Value = CInt(rand)


            cmd2.Parameters.Add("@REFERENCIA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROVALE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTVALEBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@POSTPAGO", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@CODSUBEMPRESA", SqlDbType.VarChar).Value = CStr(CODSUBEMPRESA)
            ', rand, "", "", 0, "", "", "", "", "", 0, TxtTOTAL.Text, CboMoneda.SelectedValue) > 0 Then

            Try

                Dim Dt_TimeOut As Integer = 500000
                cmd2.CommandTimeout = Dt_TimeOut
                cmd2.Transaction = transaction '//
                AFEC = cmd2.ExecuteNonQuery()
                transaction.Commit()   '//

                ''MsgBox("se grabo ...")
                cn2.Close()

                Return True
                'TIPOOPERACION = TblCtaCte.Rows(0)("TIPOOPERACION")
                'DOMICILIOFISCAL = TblCtaCte.Rows(0)("CODDOMFISCAL")
                'RUTAARCHIVO = TblCtaCte.Rows(0)("RUTA_ARCHIVO")

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
        'insert_store("SP_REGISTRA_AUDITORIA '" & txtnroguias.Text & "','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy") & "','" & CodUsuario & "','" & codempresa & "'")
        'Dim obj As New ClsInterface
        Try
            'obj.gGrabarReg("INSERT_CLI_POST_VTA", codempresa, VarTipoDoc.Trim, TXTNUMERODOC.Text.Trim)
        Catch ex As Exception
        End Try
    End Function




    Public Function GRABAEFECTIVOS4(ByVal CODTIDOC As String, ByVal NRODOCUM As String, ByVal CODTIPOPAGO As String, ByVal fechadocum As Date, ByVal TOTBAS As Double, ByVal PORCENDESC As Double, ByVal CODIGOCLIE As String, ByVal DESCLIE As String, ByVal CLIERUC As String, ByVal DIRECC As String, ByVal CODDEP As String, ByVal NRODESPACHO As String, ByVal CODVEND As String, ByVal CODSUPERVISOR As String) As Boolean

        Dim AFEC As Integer
        Try
            Dim cn2 As New SqlConnection(STRCN)
            If cn2.State = ConnectionState.Open Then
                cn2.Close()
            End If
            cn2.Open()
            Dim transaction As SqlTransaction  '//  
            transaction = cn2.BeginTransaction(Data.IsolationLevel.ReadCommitted) '//

            Dim cmd2 As New SqlCommand("Nsp_grabadocumentoXSupervisor", cn2)
            cmd2.CommandType = CommandType.StoredProcedure

            cmd2.Parameters.Add("@NRODEGUIAS", SqlDbType.VarChar).Value = CStr(NRODESPACHO)
            cmd2.Parameters.Add("@NPESADA", SqlDbType.VarChar).Value = CStr("")
            cmd2.Parameters.Add("@Eigv", SqlDbType.VarChar).Value = CStr("True")
            cmd2.Parameters.Add("@actualizocorrelativo", SqlDbType.VarChar).Value = CStr("False")
            cmd2.Parameters.Add("@NUMEROTRANS", SqlDbType.Int).Value = CInt(0)
            cmd2.Parameters.Add("@CODDEP", SqlDbType.VarChar).Value = CStr(CODDEP)
            cmd2.Parameters.Add("@CODTIPOPAGO", SqlDbType.VarChar).Value = CODTIPOPAGO.Trim
            cmd2.Parameters.Add("@CODTIPODOC", SqlDbType.VarChar).Value = CStr(CODTIDOC)
            cmd2.Parameters.Add("@NRODOCU", SqlDbType.VarChar).Value = CStr(NRODOCUM)
            cmd2.Parameters.Add("@codmon", SqlDbType.VarChar).Value = CStr(CDMONBASE)
            cmd2.Parameters.Add("@CAMBIO", SqlDbType.Decimal).Value = CDec(VCambioVta)
            cmd2.Parameters.Add("@codvend", SqlDbType.VarChar).Value = CODVEND
            cmd2.Parameters.Add("@FECDOCUM", SqlDbType.DateTime).Value = fechadocum
            cmd2.Parameters.Add("@TOTBAS", SqlDbType.Decimal).Value = CDec(TOTBAS)
            cmd2.Parameters.Add("@PORCENDESC1", SqlDbType.Decimal).Value = CDec(PORCENDESC)
            cmd2.Parameters.Add("@TOTVUELTOBAS", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@TOTCASHBAS", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@TOTCASHEXT", SqlDbType.Decimal).Value = CDec(0)
            cmd2.Parameters.Add("@codcliente", SqlDbType.VarChar).Value = CStr(CODIGOCLIE)
            cmd2.Parameters.Add("@RUCCLIENTE", SqlDbType.VarChar).Value = CStr(CLIERUC)
            cmd2.Parameters.Add("@DESCLIENTE", SqlDbType.VarChar).Value = CStr(DESCLIE)
            cmd2.Parameters.Add("@DIRCLIENTE", SqlDbType.VarChar).Value = CStr(DIRECC)
            cmd2.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = CStr(CodUsuario)
            cmd2.Parameters.Add("@CODEMPRESA", SqlDbType.VarChar).Value = CStr(codempresa)
            cmd2.Parameters.Add("@MONEDABASE", SqlDbType.VarChar).Value = CStr(CDMONBASE)
            cmd2.Parameters.Add("@NROPTOVTA", SqlDbType.VarChar).Value = CStr(NROPTOVTA)
            cmd2.Parameters.Add("@CORRELATIVO", SqlDbType.Int).Value = CInt(rand)

            cmd2.Parameters.Add("@CDTARJETA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@MONEDATARJ", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTTARJBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@NROTARJETA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@MONEDACHEQUE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@CDBANCO", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROCHEQUE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROCUENTA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTCHEQBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@TOTCREDBAS", SqlDbType.Decimal).Value = CDec(TOTBAS)
            cmd2.Parameters.Add("@CDMONEDACRED", SqlDbType.VarChar).Value = "S"
            cmd2.Parameters.Add("@MONEDAVALE", SqlDbType.Int).Value = CInt(rand)


            cmd2.Parameters.Add("@REFERENCIA", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@NROVALE", SqlDbType.VarChar).Value = ""
            cmd2.Parameters.Add("@TOTVALEBAS", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@POSTPAGO", SqlDbType.Int).Value = 0
            cmd2.Parameters.Add("@CODSUPERVISOR", SqlDbType.VarChar).Value = CStr(CODSUPERVISOR)
            ', rand, "", "", 0, "", "", "", "", "", 0, TxtTOTAL.Text, CboMoneda.SelectedValue) > 0 Then

            Try

                Dim Dt_TimeOut As Integer = 500000
                cmd2.CommandTimeout = Dt_TimeOut
                cmd2.Transaction = transaction '//
                AFEC = cmd2.ExecuteNonQuery()
                transaction.Commit()   '//

                ''MsgBox("se grabo ...")
                cn2.Close()

                Return True
                'TIPOOPERACION = TblCtaCte.Rows(0)("TIPOOPERACION")
                'DOMICILIOFISCAL = TblCtaCte.Rows(0)("CODDOMFISCAL")
                'RUTAARCHIVO = TblCtaCte.Rows(0)("RUTA_ARCHIVO")

            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
        'insert_store("SP_REGISTRA_AUDITORIA '" & txtnroguias.Text & "','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy") & "','" & CodUsuario & "','" & codempresa & "'")
        'Dim obj As New ClsInterface
        Try
            'obj.gGrabarReg("INSERT_CLI_POST_VTA", codempresa, VarTipoDoc.Trim, TXTNUMERODOC.Text.Trim)
        Catch ex As Exception
        End Try
    End Function



    Private Sub CARGAR_GRID()


        If FACTPTOVTA = True Then
            TABLE_CONSOLCLIE = TmpListarDatos("SP_LISTA_CONSOL_CLIE   '" & codempresa & "','" & rand & "','" & Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy") & "'")
        End If

        If FACTLINEA = True Then
            TABLE_CONSOLCLIE = TmpListarDatos("SP_LISTA_CONSOL_CLIE2   '" & codempresa & "','" & rand & "','" & Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy") & "'")
        End If

        If FACTSUBEMP = True Then
            TABLE_CONSOLCLIE = TmpListarDatos("SP_LISTA_CONSOL_CLIE3   '" & codempresa & "','" & rand & "','" & Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy") & "'")
        End If

        GridCabcera.DataSource = TABLE_CONSOLCLIE

        LblTotal.Text = "0.00"
        For i As Integer = 0 To TABLE_CONSOLCLIE.Rows.Count - 1
            LblTotal.Text = (CDbl(TABLE_CONSOLCLIE.Rows(i)("TOTBAS").ToString.Trim) + CDbl(LblTotal.Text)).ToString("c")
        Next

        Dim TABLE_DOCS As New DataTable
        TABLE_DOCS = TmpListarDatos("SP_BUSCAR_DOCUMENTOS_REPETIDOS   '" & codempresa & "','" & rand & "'")

        If TABLE_DOCS.Rows.Count > 0 Then


            Dim datos As String
            datos = " "
            For VERIFI As Integer = 0 To TABLE_DOCS.Rows.Count - 1

                datos = datos + " tipo Doc: " + TABLE_DOCS.Rows(VERIFI)("DSTIPODOC").ToString.Trim + " Nro Doc: " + TABLE_DOCS.Rows(VERIFI)("NRODOCFACT").ToString() + " Nro Pedido: " + TABLE_DOCS.Rows(VERIFI)("NUM_PEDIDO").ToString() + " Nro Correlativo: " + TABLE_DOCS.Rows(VERIFI)("CORRNBR").ToString() & vbCrLf

            Next


            btnGenerarFactura.Enabled = False
            MessageBox.Show(datos)
        Else
            btnGenerarFactura.Enabled = True
        End If


    End Sub
    Private Sub FORMATO_GRID()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_CONSOLCLIE.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "FECHA"
            .HeaderText = "Fecha"
            .Format = "dd/MM/yyy"
            .Width = 75
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CODTIPODOC"
            .HeaderText = "CODTIPODOC"
            .Width = 0
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DSTIPODOC"
            .HeaderText = "Tipo Doc."
            .Width = 120
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "NRODOCFACT"
            .HeaderText = "Nro. Doc."
            .Width = 100
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "CODCLIENTE"
            .HeaderText = "CODCLIENTE"
            .Width = 0
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "DESCLIENTE"
            .HeaderText = "Descripcion"
            .Width = 250
        End With
        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "CODTIPOPAGO"
            .HeaderText = "CODTIPOPAGO"
            .Width = 0
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "DSTIPOPAGO"
            .HeaderText = "Cond Pago"
            .Width = 100
        End With
        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "TOTBAS"
            .HeaderText = "Importe"
            .Format = GMascaraDec(DECIRESU)
            .Alignment = HorizontalAlignment.Right
            .Width = 75
        End With

        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "NUM_PEDIDO"
            .Alignment = HorizontalAlignment.Right
            .Width = 0
        End With


        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10})
        GridCabcera.TableStyles.Clear()
        GridCabcera.TableStyles.Add(TableStyle1)
    End Sub
#End Region

    Sub INSERT_TABLE_DETALLE_VERIFI(ByVal CODTIPODOC As String, ByVal TIPO_DOC As String,
ByVal CODEMPRESA As String, ByVal CODCLIENTE As String, ByVal RUC As String,
ByVal DIRECCION As String, ByVal DATOADJUNTO As String, ByVal CODTIPOPAGO As String,
ByVal DSTIPOPAGO As String, ByVal MONTO As Double,
ByVal NROGUIA As String, ByVal CODARTI As String, ByVal DESARTI As String,
ByVal DESPRES As String, ByVal DETALLE As String, ByVal CANTIDAD As Double,
ByVal PRECIO_ART As Double, ByVal TOTBAS As Double, ByVal NRODOCU As String)
        Dim FILA As DataRow = TABLE_DETALLE_VERIFI.NewRow
        FILA("CODTIPODOC") = CODTIPODOC
        FILA("TIPO_DOC") = TIPO_DOC
        FILA("CODEMPRESA") = CODEMPRESA
        FILA("CODCLIENTE") = CODCLIENTE
        FILA("RUC") = RUC
        FILA("DIRECCION") = DIRECCION
        FILA("DATOADJUNTO") = DATOADJUNTO
        FILA("CODTIPOPAGO") = CODTIPOPAGO
        FILA("DSTIPOPAGO") = DSTIPOPAGO
        FILA("MONTO") = MONTO
        FILA("NRORDEN_DESPACHO") = NROGUIA
        FILA("CODARTI") = CODARTI
        FILA("DESARTI") = DESARTI
        FILA("DESPRES") = DESPRES
        FILA("DETALLE") = DETALLE
        FILA("CANTIDAD") = CANTIDAD
        FILA("PRECIO_ART") = PRECIO_ART
        FILA("TOTBAS") = TOTBAS
        FILA("NRODOCU") = NRODOCU
        TABLE_DETALLE_VERIFI.Rows.Add(FILA)
        TABLE_DETALLE_VERIFI.AcceptChanges()

    End Sub
    Sub INSERTAR_TABLA2(ByVal FILA_TABLA As DataTable, ByVal indice As Integer)
        '//DECLARACION DE DATOS A INGRESAR 

        Dim CODTIPODOC, TIPO_DOC, CODEMPRESA, CODCLIENTE, RUC, DIRECCION As String
        Dim DATOADJUNTO As String = ""
        Dim CODTIPOPAGO As String = ""
        Dim DSTIPOPAGO As String = ""
        Dim NROGUIA As String = ""
        Dim CODARTI, DESARTI, DESPRES, DETALLE, NRODOCU As String
        Dim CANTIDAD, PRECIO_ART, TOTBAS, MONTO As Double
        NRODOCU = FILA_TABLA.Rows(indice)("NRODOCU").ToString.Trim
        CODTIPODOC = FILA_TABLA.Rows(indice)("CODTIPODOC").ToString.Trim
        TIPO_DOC = FILA_TABLA.Rows(indice)("TIPO_DOC").ToString.Trim
        CODEMPRESA = FILA_TABLA.Rows(indice)("CODEMPRESA").ToString.Trim
        CODCLIENTE = FILA_TABLA.Rows(indice)("CODCLIENTE").ToString.Trim
        RUC = FILA_TABLA.Rows(indice)("RUC").ToString.Trim
        DIRECCION = FILA_TABLA.Rows(indice)("DIRECCION").ToString.Trim
        DATOADJUNTO = FILA_TABLA.Rows(indice)("DATOADJUNTO").ToString.Trim
        CODTIPOPAGO = FILA_TABLA.Rows(indice)("CODTIPOPAGO").ToString.Trim
        NROGUIA = FILA_TABLA.Rows(indice)("NROGUIA").ToString.Trim
        CODARTI = FILA_TABLA.Rows(indice)("CODARTI").ToString.Trim
        DESARTI = FILA_TABLA.Rows(indice)("DESARTI").ToString.Trim
        DESPRES = FILA_TABLA.Rows(indice)("DESPRES").ToString.Trim
        DETALLE = FILA_TABLA.Rows(indice)("DETALLE").ToString.Trim
        CANTIDAD = FILA_TABLA.Rows(indice)("CANTIDAD").ToString.Trim
        PRECIO_ART = FILA_TABLA.Rows(indice)("PRECIO_ART").ToString.Trim
        TOTBAS = FILA_TABLA.Rows(indice)("TOTBAS").ToString.Trim
        MONTO = FILA_TABLA.Rows(indice)("MONTO").ToString.Trim


        '////DECLARAR UNA VARIABLE STATIC PARA QUE ME RESTRINGA EL NUMERO FILAS 
        '////QUE PUEDE ALMACENAR EL DOCUMENTO 
        Dim numFilas As Integer
        Static NROBOLETA As String
        Static NROFACTURA As String
        Static NROPEDIDO As String
        'Dim ITEMDEFACT, ITEMDEBOLETA, ITEMDENTAPEDIDO As Integer
        Dim TABLE_BUSQ_ART As New DataTable
        Dim CONT_NRODOCUMENTO As String
        Dim CONT_NROFILAS As Integer

        If TABLE_DETALLE_VERIFI.Rows.Count = 0 Then
            NROBOLETA = ""
            NROFACTURA = ""
            NROPEDIDO = ""
        End If
        'If CONT_NRODOCUMENTO = "" Then
        'PEDIR EL NUMERO DE DOCUMENTO 
        CONT_NRODOCUMENTO = ObtenerNroDocX(CODTIPODOC.Trim).ToString.Trim
        CONT_NROFILAS = ObtenerNroDeFilas2(CODTIPODOC.Trim).ToString.Trim


        '////REVISAR
        '//TABLE_BUSQ_ART = TmpListarDatos("USP_BUSCAR_ARTICULO_MAESTRA  '" & CODARTI & "','" & CODEMPRESA & "'")

        If CODTIPODOC.Trim = "01" Then
            NRODOCU = NROFACTURA
        ElseIf CODTIPODOC = "03" Then
            NRODOCU = NROBOLETA
        ElseIf CODTIPODOC = "06" Then
            NRODOCU = NROPEDIDO
        End If
        NRODOCU = CONT_NRODOCUMENTO

        Dim existe As Boolean
        For VERIFI As Integer = 0 To TABLE_DETALLE_VERIFI.Rows.Count - 1
            If TABLE_DETALLE_VERIFI.Rows(VERIFI)("CODTIPODOC").ToString.Trim = CODTIPODOC.Trim And TABLE_DETALLE_VERIFI.Rows(VERIFI)("CODCLIENTE").ToString.Trim = CODCLIENTE.Trim And TABLE_DETALLE_VERIFI.Rows(VERIFI)("DIRECCION").ToString.Trim = DIRECCION.Trim Then
                existe = True
                Exit For
            End If

        Next
        If existe = False Then

            If CODTIPODOC.Trim = "01" Then
                If NROFACTURA = "" Then
                    NROFACTURA = CONT_NRODOCUMENTO
                    NRODOCU = CONT_NRODOCUMENTO
                Else
                    NROFACTURA += 1
                    NRODOCU = NROFACTURA
                End If
            ElseIf CODTIPODOC.Trim = "03" Then
                If NROBOLETA = "" Then
                    NROBOLETA = CONT_NRODOCUMENTO
                    NRODOCU = CONT_NRODOCUMENTO
                Else
                    NROBOLETA += 1
                    NRODOCU = NROBOLETA
                End If
            ElseIf CODTIPODOC.Trim = "06" Then
                If NROPEDIDO = "" Then
                    NROPEDIDO = CONT_NRODOCUMENTO
                    NRODOCU = CONT_NRODOCUMENTO
                Else
                    NROPEDIDO += 1
                    NRODOCU = NROPEDIDO
                End If
            End If
        Else

            If CODTIPODOC.Trim = "01" Then
                NRODOCU = NROFACTURA
            ElseIf CODTIPODOC.Trim = "03" Then
                NRODOCU = NROBOLETA
            ElseIf CODTIPODOC.Trim = "06" Then
                NRODOCU = NROPEDIDO
            End If

        End If
        '////////COMENSAR A INSERTAR  
        INSERT_TABLE_DETALLE_VERIFI(CODTIPODOC, TIPO_DOC, CODEMPRESA, CODCLIENTE, RUC, DIRECCION, DATOADJUNTO, CODTIPOPAGO, DSTIPOPAGO, MONTO, NROGUIA, CODARTI, DESARTI, DESPRES, DETALLE, CANTIDAD, PRECIO_ART, TOTBAS, NRODOCU)

        For VERIFI As Integer = 0 To TABLE_DETALLE_VERIFI.Rows.Count - 1

            If TABLE_DETALLE_VERIFI.Rows(VERIFI)("CODTIPODOC").ToString.Trim = CODTIPODOC.Trim Then
                numFilas += 1
                If numFilas = CONT_NROFILAS Then
                    If CODTIPODOC.Trim = "01" Then
                        NROFACTURA += 1
                    ElseIf CODTIPODOC.Trim = "03" Then
                        NROBOLETA += 1
                    ElseIf CODTIPODOC.Trim = "06" Then
                        NROPEDIDO += 1
                    End If

                End If
            End If

        Next

    End Sub
    Sub VERIFICACION_DE_DOCUMENTOS2()

        Dim IndiceArray As Integer
        Dim Borrar_Filas(IndiceArray) As String

        TABLE_DETALLE_VERIFI = TABLE_DETALLE_PEDI.Clone
        '''''''''''TRABAJAR PRIMERO CON EL DETALLE Y LUEGO LOS DATOS LOS PASAS A LA  CABECERA
Regresar:
        IndiceArray = 0
        Array.Clear(Borrar_Filas, 0, Borrar_Filas.Length)

        For ver As Integer = 0 To TABLE_DETALLE_PEDI.Rows.Count - 1

            INSERTAR_TABLA2(TABLE_DETALLE_PEDI, ver)

            TABLE_DETALLE_PEDI.Rows.RemoveAt(ver)
            GoTo Regresar

        Next
        If TABLE_DETALLE_PEDI.Rows.Count > 0 Then
            GoTo Regresar
        End If

        For i As Integer = 0 To TABLE_DETALLE_VERIFI.Rows.Count - 1
            TABLE_DETALLE_PEDI.ImportRow(TABLE_DETALLE_VERIFI.Rows(i))
            TABLE_DETALLE_PEDI.AcceptChanges()
        Next


    End Sub
    Sub CREAR_NRO_DOCUMENTOS()
        Dim TABLE_DOC As New DataTable
        Dim TABLE_ITEM As New DataTable
        Dim CasoDoc As Integer

        Dim CODCLIENTE, CDARTI As String

        TABLE_DOC = TmpListarDatos("SELECT  NROTICKBOL,NROTICKFAC,NROPEDIDO  FROM PTOVTA   WHERE CODEMPRESA='" & codempresa & "'  AND NROPTOVTA='" & NROPTOVTA & "'")
        TABLE_ITEM = TmpListarDatos("SELECT  ITEMDEFACT,ITEMDEBOLETA,ITEMDENTAPEDIDO   FROM  CONFIGVTA  WHERE  CODEMPRESA='" & codempresa & "'  ")
        NROBOLETA = TABLE_DOC.Rows(0)("NROTICKBOL").ToString.Trim
        NROFACTURA = TABLE_DOC.Rows(0)("NROTICKFAC").ToString.Trim
        NRONOTA_PEDIDO = TABLE_DOC.Rows(0)("NROPEDIDO").ToString.Trim
        ITEMFACT = TABLE_ITEM.Rows(0)("ITEMDEFACT").ToString.Trim
        ITEMBOL = TABLE_ITEM.Rows(0)("ITEMDEBOLETA").ToString.Trim
        ITEMNTAPED = TABLE_ITEM.Rows(0)("ITEMDENTAPEDIDO").ToString.Trim

        For i As Integer = 0 To TABLE_DETALLE_PEDI.Rows.Count - 1
            If TABLE_DETALLE_PEDI.Rows(i)("NRODOCU").ToString.Trim = "" Then
                CODCLIENTE = TABLE_DETALLE_PEDI.Rows(i)("CODCLIENTE").ToString.Trim
                For a As Integer = 0 To TABLE_DETALLE_PEDI.Rows.Count - 1
                    If TABLE_DETALLE_PEDI.Rows(a)("CODCLIENTE").ToString.Trim = CODCLIENTE Then
                        CDARTI = TABLE_DETALLE_PEDI.Rows(a)("CODARTI").ToString.Trim
                        CasoDoc = CInt(TmpListarDatos("NSP_RETORNA_CASONRODOC   '" & codempresa & "','" & CODCLIENTE & "','" & CDARTI & "' ").Rows(0)(0).ToString.Trim)
                        Select Case CasoDoc
                            Case 1
                                TABLE_DETALLE_PEDI.Rows(a)("NRODOCU") = NROFACTURA
                                CONTFACT += 1
                                If CONTFACT = ITEMFACT Then
                                    NROFACTURA += 1 : CONTFACT = 0
                                End If
                            Case 2
                                TABLE_DETALLE_PEDI.Rows(a)("NRODOCU") = NROBOLETA
                                CONTBOL += 1
                                If CONTBOL = ITEMBOL Then
                                    NROBOLETA += 1 : CONTBOL = 0
                                End If

                            Case 3
                                TABLE_DETALLE_PEDI.Rows(a)("NRODOCU") = NRONOTA_PEDIDO
                                CONTNTAPE += 1
                                If CONTNTAPE = ITEMNTAPED Then
                                    NRONOTA_PEDIDO += 1 : CONTNTAPE = 0
                                End If
                            Case Else
                                MsgBox("Faltan Datos..", MsgBoxStyle.Information, "NARSISTEMAS  S.A.C.")
                                Exit Sub
                        End Select

                    End If
                Next
                If CONTFACT > 0 Then
                    NROFACTURA += 1 : CONTFACT = 0
                End If
                If CONTBOL > 0 Then
                    NROBOLETA += 1 : CONTBOL = 0
                End If
                If CONTNTAPE > 0 Then
                    NRONOTA_PEDIDO += 1 : CONTNTAPE = 0
                End If

            End If
        Next


    End Sub
    Sub ESCRIBIRMENSAJE()
        HALLARMAX_MINIMO(GridClientes.Item(GridClientes.CurrentRowIndex, 0).ToString.Trim)
        LblmensajeTipoDoc.Text = "  " & GridClientes.Item(GridClientes.CurrentRowIndex, 0).ToString.Trim & ": " & NROMINIMO & "   HASTA   " & NROMAXIMO
    End Sub
    Sub HALLARMAX_MINIMO(ByVal TIPODCUM As String)
        NROMAXIMO = 0
        NROMINIMO = CInt(GridClientes.Item(GridClientes.CurrentRowIndex, 2).ToString.Trim)
        For MAX As Integer = 0 To TABLE_CABECERA_PEDI.Rows.Count - 1
            If TABLE_CABECERA_PEDI.Rows(MAX)("TIPO_DOC") = TIPODCUM Then
                If NROMAXIMO < CInt(TABLE_CABECERA_PEDI.Rows(MAX)("NRODOCU")) Then
                    NROMAXIMO = CInt(TABLE_CABECERA_PEDI.Rows(MAX)("NRODOCU"))
                End If
                If NROMINIMO > CInt(TABLE_CABECERA_PEDI.Rows(MAX)("NRODOCU")) Then
                    NROMINIMO = CInt(TABLE_CABECERA_PEDI.Rows(MAX)("NRODOCU"))
                End If
            End If
        Next
    End Sub

    Sub Actualizar2()
        NROBOLETA = ObtenerNroDocXabrv("BOLETA DE VENTA")
        NROFACTURA = ObtenerNroDocXabrv("FACTURA")
        NRONOTA_PEDIDO = ObtenerNroDocXabrv("NOTA DE PEDIDO")

        For fila As Integer = 0 To TABLE_CABECERA_PEDI.Rows.Count - 1
            If TABLE_CABECERA_PEDI.Rows(fila)("TIPO_DOC") = "BOLETA DE VENTA" Then
                TABLE_CABECERA_PEDI.Rows(fila)("NRODOCU") = NROBOLETA
                NROBOLETA += 1
            ElseIf TABLE_CABECERA_PEDI.Rows(fila)("TIPO_DOC") = "FACTURA" Then
                TABLE_CABECERA_PEDI.Rows(fila)("NRODOCU") = NROFACTURA
                NROFACTURA += 1
            Else
                TABLE_CABECERA_PEDI.Rows(fila)("NRODOCU") = NRONOTA_PEDIDO
                NRONOTA_PEDIDO += 1
            End If
            TABLE_CABECERA_PEDI.AcceptChanges()
        Next

        GridClientes.DataSource = TABLE_CABECERA_PEDI

        DataGridTableStyle2.MappingName = TABLE_CABECERA_PEDI.TableName
        DataGridTableStyle2.GridColumnStyles(0).MappingName = "TIPO_DOC"
        DataGridTableStyle2.GridColumnStyles(1).MappingName = "CODTIPODOC"
        DataGridTableStyle2.GridColumnStyles(2).MappingName = "NRODOCU"
        DataGridTableStyle2.GridColumnStyles(3).MappingName = "CODEMPRESA"
        DataGridTableStyle2.GridColumnStyles(4).MappingName = "CODCLIENTE"
        DataGridTableStyle2.GridColumnStyles(5).MappingName = "DATOADJUNTO"
        DataGridTableStyle2.GridColumnStyles(6).MappingName = "RUC"
        DataGridTableStyle2.GridColumnStyles(7).MappingName = "DIRECCION"
        DataGridTableStyle2.GridColumnStyles(8).MappingName = "CODTIPOPAGO"
        DataGridTableStyle2.GridColumnStyles(9).MappingName = "DSTIPOPAGO"
        DataGridTableStyle2.GridColumnStyles(10).MappingName = "MONTO"
        GridClientes.TableStyles.Add(DataGridTableStyle2)

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const Wd_Keydown As Integer = &H100
        Const Wd_KeySystemDow As Integer = &H104
        If ((MSG.Msg = Wd_Keydown) Or (MSG.Msg = Wd_KeySystemDow)) Then
            Select Case (KeyData)
                Case Keys.Enter
                    If TABLE_CONSOLCLIE.Rows.Count > 0 Then
                        If GridCabcera.Focus = True Then
                            Dim TIPO_DOC, CODTIPODOC, COD_CLIENTE, DIRECCION, NRO_DOCU As String
                            TIPO_DOC = GridCabcera.Item(GridCabcera.CurrentRowIndex, 0).ToString.Trim
                            CODTIPODOC = GridCabcera.Item(GridCabcera.CurrentRowIndex, 1).ToString.Trim
                            COD_CLIENTE = GridCabcera.Item(GridCabcera.CurrentRowIndex, 4).ToString.Trim
                            DIRECCION = GridCabcera.Item(GridCabcera.CurrentRowIndex, 7).ToString.Trim
                            NRO_DOCU = GridCabcera.Item(GridCabcera.CurrentRowIndex, 3).ToString.Trim

                            Dim FrmDoc As New FrmTipoDeDocumento
                            FrmDoc.CODTIPODOC = GridCabcera.Item(GridCabcera.CurrentRowIndex, 1)
                            FrmDoc.ShowDialog()
                            If FrmDoc.DEVOLVER = False Then
                                Exit Function
                            End If
                            If CODTIPODOC.Trim = FrmDoc.CboTipoDoc.SelectedValue.ToString.Trim Then
                                Exit Function
                            End If
                            Dim VarCdTipoDoc As String
                            VarCdTipoDoc = FrmDoc.CboTipoDoc.SelectedValue.ToString.Trim
                            CAyuda.Ejecutar("UpdatDocTMP_GUIAINTERNADETxProc", codempresa, CODTIPODOC, NRO_DOCU, NROPTOVTA, VarCdTipoDoc, rand)
                            CARGAR_GRID()
                            FORMATO_GRID()

                            ''Dim MaxDocumento As Integer
                            ''For i As Integer = 0 To TABLE_CONSOLCLIE.Rows.Count - 1
                            ''    If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = FrmDoc.CboTipoDoc.SelectedValue.ToString.Trim Then
                            ''        If MaxDocumento < CDbl(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT").ToString.Trim) Then
                            ''            MaxDocumento = CDbl(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT").ToString.Trim)
                            ''        End If
                            ''    End If
                            ''Next
                            ''If MaxDocumento = 0 Then
                            ''    MaxDocumento = ObtenerNroDocX(FrmDoc.CboTipoDoc.SelectedValue.ToString.Trim)
                            ''Else
                            ''    MaxDocumento += 1
                            ''End If
                            ''For detall As Integer = 0 To TABLE_CONSOLCLIE.Rows.Count - 1
                            ''    If TABLE_CONSOLCLIE.Rows(detall)("CODTIPODOC").ToString.Trim = CODTIPODOC.Trim _
                            ''    And TABLE_CONSOLCLIE.Rows(detall)("CODCLIENTE").ToString.Trim = COD_CLIENTE _
                            ''         And TABLE_CONSOLCLIE.Rows(detall)("NRODOCFACT").ToString.Trim = NRO_DOCU Then
                            ''        TABLE_CONSOLCLIE.Rows(detall)("CODTIPODOC") = FrmDoc.CboTipoDoc.SelectedValue.ToString.Trim
                            ''        TABLE_CONSOLCLIE.Rows(detall)("DSTIPODOC") = FrmDoc.CboTipoDoc.Text
                            ''        TABLE_CONSOLCLIE.Rows(detall)("NRODOCFACT") = MaxDocumento
                            ''        TABLE_CONSOLCLIE.AcceptChanges()
                            ''    End If
                            ''Next
                            ''FORMATO_GRID()

                        End If

                    End If
            End Select
        End If
    End Function

    Sub ActualizarCabecera()
        Dim NoInsertar As Boolean
        Dim CODTIPODOC As String = ""
        Dim NRO_DOCU As String = ""
        Dim TIPO_DOC As String = ""
        Dim COD_CLIENTE As String = ""
        Dim DIRECCION As String = ""
        Dim FilaInser As Integer
        TABLE_CABECERA_PEDI.Rows.Clear()
        For Inst As Integer = 0 To TABLE_DETALLE_PEDI.Rows.Count - 1
            For detall As Integer = 0 To TABLE_CABECERA_PEDI.Rows.Count - 1
                If TABLE_DETALLE_PEDI.Rows(Inst)("CODTIPODOC").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("CODTIPODOC").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("TIPO_DOC").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("TIPO_DOC").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("CODCLIENTE").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("CODCLIENTE").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("DIRECCION").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("DIRECCION").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("CODDEP").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("CODDEP").ToString.Trim _
                And TABLE_DETALLE_PEDI.Rows(Inst)("NRODOCU").ToString.Trim = TABLE_CABECERA_PEDI.Rows(detall)("NRODOCU").ToString.Trim Then
                    NoInsertar = True
                    GoTo sumar
                End If
            Next
            If NoInsertar = False Then
                FilaInser = TABLE_CABECERA_PEDI.Rows.Count
                Dim FILA As DataRow = TABLE_CABECERA_PEDI.NewRow
                FILA("CODTIPODOC") = TABLE_DETALLE_PEDI.Rows(Inst)("CODTIPODOC").ToString.Trim
                FILA("TIPO_DOC") = TABLE_DETALLE_PEDI.Rows(Inst)("TIPO_DOC").ToString.Trim
                FILA("CODEMPRESA") = TABLE_DETALLE_PEDI.Rows(Inst)("CODEMPRESA").ToString.Trim
                FILA("CODCLIENTE") = TABLE_DETALLE_PEDI.Rows(Inst)("CODCLIENTE").ToString.Trim
                FILA("RUC") = TABLE_DETALLE_PEDI.Rows(Inst)("RUC").ToString.Trim
                FILA("DIRECCION") = TABLE_DETALLE_PEDI.Rows(Inst)("DIRECCION").ToString.Trim
                FILA("DATOADJUNTO") = TABLE_DETALLE_PEDI.Rows(Inst)("DATOADJUNTO").ToString.Trim
                FILA("CODTIPOPAGO") = TABLE_DETALLE_PEDI.Rows(Inst)("CODTIPOPAGO").ToString.Trim
                FILA("DSTIPOPAGO") = TABLE_DETALLE_PEDI.Rows(Inst)("DSTIPOPAGO").ToString.Trim
                FILA("MONTO") = 0.0
                FILA("NRORDEN_DESPACHO") = TABLE_DETALLE_PEDI.Rows(Inst)("NRORDEN_DESPACHO").ToString.Trim
                FILA("CODARTI") = TABLE_DETALLE_PEDI.Rows(Inst)("CODARTI").ToString.Trim
                FILA("DESARTI") = TABLE_DETALLE_PEDI.Rows(Inst)("DESARTI").ToString.Trim
                FILA("DESPRES") = TABLE_DETALLE_PEDI.Rows(Inst)("DESPRES").ToString.Trim
                FILA("DETALLE") = TABLE_DETALLE_PEDI.Rows(Inst)("DETALLE").ToString.Trim
                FILA("CANTIDAD") = TABLE_DETALLE_PEDI.Rows(Inst)("CANTIDAD").ToString.Trim
                FILA("PRECIO_ART") = TABLE_DETALLE_PEDI.Rows(Inst)("PRECIO_ART").ToString.Trim
                FILA("TOTBAS") = 0.0
                FILA("NRODOCU") = CInt(TABLE_DETALLE_PEDI.Rows(Inst)("NRODOCU").ToString.Trim)
                FILA("CODDEP") = TABLE_DETALLE_PEDI.Rows(Inst)("CODDEP").ToString.Trim
                TABLE_CABECERA_PEDI.Rows.Add(FILA)
                TABLE_CABECERA_PEDI.AcceptChanges()

                CODTIPODOC = TABLE_DETALLE_PEDI.Rows(Inst)("CODTIPODOC").ToString.Trim
                TIPO_DOC = TABLE_DETALLE_PEDI.Rows(Inst)("TIPO_DOC").ToString.Trim
                COD_CLIENTE = TABLE_DETALLE_PEDI.Rows(Inst)("CODCLIENTE").ToString.Trim
                DIRECCION = TABLE_DETALLE_PEDI.Rows(Inst)("DIRECCION").ToString.Trim
                NRO_DOCU = TABLE_DETALLE_PEDI.Rows(Inst)("NRODOCU").ToString.Trim

            End If
            NoInsertar = False
            For detall As Integer = 0 To TABLE_DETALLE_PEDI.Rows.Count - 1
                If TABLE_DETALLE_PEDI.Rows(detall)("CODTIPODOC").ToString.Trim = CODTIPODOC.Trim _
                And TABLE_DETALLE_PEDI.Rows(detall)("TIPO_DOC").ToString.Trim = TIPO_DOC _
                And TABLE_DETALLE_PEDI.Rows(detall)("CODCLIENTE").ToString.Trim = COD_CLIENTE _
                And TABLE_DETALLE_PEDI.Rows(detall)("DIRECCION").ToString.Trim = DIRECCION _
                And TABLE_DETALLE_PEDI.Rows(detall)("NRODOCU").ToString.Trim = NRO_DOCU Then
                    TABLE_CABECERA_PEDI.Rows(FilaInser)("TOTBAS") = CDbl(TABLE_CABECERA_PEDI.Rows(FilaInser)("TOTBAS").ToString.Trim) + CDbl(TABLE_DETALLE_PEDI.Rows(detall)("TOTBAS").ToString.Trim)
                    TABLE_CABECERA_PEDI.AcceptChanges()
                End If
            Next
sumar:
            NoInsertar = False

        Next

        GridCabcera.DataSource = TABLE_CABECERA_PEDI
        DataGridTableStyle2.MappingName = TABLE_CABECERA_PEDI.TableName
        DataGridTableStyle2.GridColumnStyles(0).MappingName = "TIPO_DOC"
        DataGridTableStyle2.GridColumnStyles(1).MappingName = "CODTIPODOC"
        DataGridTableStyle2.GridColumnStyles(2).MappingName = "NRODOCU"
        DataGridTableStyle2.GridColumnStyles(3).MappingName = "CODEMPRESA"
        DataGridTableStyle2.GridColumnStyles(4).MappingName = "CODCLIENTE"
        DataGridTableStyle2.GridColumnStyles(5).MappingName = "DATOADJUNTO"
        DataGridTableStyle2.GridColumnStyles(6).MappingName = "RUC"
        DataGridTableStyle2.GridColumnStyles(7).MappingName = "DIRECCION"
        DataGridTableStyle2.GridColumnStyles(8).MappingName = "CODTIPOPAGO"
        DataGridTableStyle2.GridColumnStyles(9).MappingName = "DSTIPOPAGO"
        DataGridTableStyle2.GridColumnStyles(10).MappingName = "TOTBAS"
        GridCabcera.TableStyles.Add(DataGridTableStyle2)

        LblTotal.Text = CDbl(0)

        For i As Integer = 0 To TABLE_CABECERA_PEDI.Rows.Count - 1
            LblTotal.Text = CDbl(TABLE_CABECERA_PEDI.Rows(i)("TOTBAS").ToString.Trim) + CDbl(LblTotal.Text)
        Next
    End Sub
    Sub CargarDataGrid(ByVal NRODESPACHO As String, ByVal TIPO As Integer)

        TABLE_DETALLE_PEDI = TmpListarDatos("NSP_LISTAR_OD_FACT   '" & codempresa & "','" & NRODESPACHO & "'," & TIPO & "  ")

        TABLE_CABECERA_PEDI = New DataTable
        TABLE_CABECERA_PEDI = TABLE_DETALLE_PEDI.Clone

        CREAR_NRO_DOCUMENTOS()

        GridClientes.DataSource = TABLE_DETALLE_PEDI
        DataGridTableStyle1.MappingName = TABLE_DETALLE_PEDI.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "TIPO_DOC"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "CODTIPODOC"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "NRODOCU"
        DataGridTableStyle1.GridColumnStyles(3).MappingName = "CODEMPRESA"
        DataGridTableStyle1.GridColumnStyles(4).MappingName = "CODCLIENTE"
        DataGridTableStyle1.GridColumnStyles(5).MappingName = "DATOADJUNTO"
        DataGridTableStyle1.GridColumnStyles(6).MappingName = "RUC"
        DataGridTableStyle1.GridColumnStyles(7).MappingName = "DIRECCION"
        DataGridTableStyle1.GridColumnStyles(8).MappingName = "CODTIPOPAGO"
        DataGridTableStyle1.GridColumnStyles(9).MappingName = "DSTIPOPAGO"
        DataGridTableStyle1.GridColumnStyles(10).MappingName = "MONTO"
        GridClientes.TableStyles.Add(DataGridTableStyle1)
    End Sub
    Private Sub FrmFacturacion_Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim TMP_PTOVTA As New DataTable
        NomMaq = Environment.MachineName
        TMP_PTOVTA = TmpListarDatos("SELECT  CDZONA,NROPTOVTA   FROM  PTOVTA  WHERE  TERMINAL='" & NomMaq & "' AND CODEMPRESA= '" & codempresa & "'  ")
        CODZONA = TMP_PTOVTA.Rows(0)("CDZONA").ToString.Trim
        STRNROPTOVTA = TMP_PTOVTA.Rows(0)("NROPTOVTA").ToString.Trim
        cboVendedor.Text = CodUsuario
        ObtenerPtoVta(Environment.MachineName.Trim)
        TablaARTI_FZAVENTA.Columns.Add("FZAVENTA")
        TablaARTI_FZAVENTA.Columns.Add("CODCLIE")
        TablaARTI_FZAVENTA.Columns.Add("IMPORTE")
        VCorrelInv = OBTENCORREL_INVENTARIO()
        Me.DtFechaDoc.Value = Format(vFechaActual, "dd/MM/yyyy")

        ValorRan()
    End Sub


    Sub VALIDAR_NULL()
        Dim TABLE_DOCS As New DataTable
        TABLE_DOCS = TmpListarDatos("SP_BUSCAR_DOCUMENTOS_REPETIDOS   '" & codempresa & "','" & rand & "'")

        If TABLE_DOCS.Rows.Count > 0 Then


            Dim datos As String
            datos = " "
            For VERIFI As Integer = 0 To TABLE_DOCS.Rows.Count - 1

                datos = datos + " tipo Doc: " + TABLE_DOCS.Rows(VERIFI)("DSTIPODOC").ToString.Trim + " Nro Doc: " + TABLE_DOCS.Rows(VERIFI)("NRODOCFACT").ToString() + " Nro Pedido: " + TABLE_DOCS.Rows(VERIFI)("NUM_PEDIDO").ToString() + " Nro Correlativo: " + TABLE_DOCS.Rows(VERIFI)("CORRNBR").ToString() & vbCrLf

            Next


            btnGenerarFactura.Enabled = False
            MessageBox.Show(datos)
        Else
            btnGenerarFactura.Enabled = True
        End If

    End Sub



    Private Sub btnGenerarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarFactura.Click

        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DtFechaDoc.Value.Year
        MES = DtFechaDoc.Value.Month

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

        If TABLE_CONSOLCLIE.Rows.Count = 0 Then
            MessageBox.Show("- NO HAY PEDIDOS A GENERAR. AGREGUE PEDIDOS.", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Using tx As New TransactionScope


        'VERIFICAR SI EL DOCUMENTO EXISTE ************************************************************************************************
        'For i As Integer = 0 To TABLE_CONSOLCLIE.Rows.Count - 1
        '    Try
        '        Dim TABLE1 As New DataTable
        '        TABLE1 = TmpListarDatos("NSP_BUSCAR_FACTURACION  '" & codempresa & "','" & CDbl(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT")).ToString & "','" & TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString & "','" & rand & "'")

        '        If TABLE1.Rows.Count > 0 Then

        '            Dim DOC As String = ""

        '            If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = "01" Then
        '                DOC = "Factura"
        '            End If

        '            If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = "03" Then
        '                DOC = "Boleta"
        '            End If

        '            If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = "06" Then
        '                DOC = "Nota Pedido"
        '            End If

        '            MsgBox("El Documento " & DOC & " " & CInt(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT")).ToString & " ya existe")
        '            Exit Sub
        '        End If
        '    Catch ex As Exception
        '        MsgBox("- HAY ALGUNA FALLA EL LA BUSQUEDA DEL DOCUMENTO ." & ex.Message, MsgBoxStyle.Information, "NARSISTEMAS")
        '        Exit Sub
        '    End Try
        'Next

        Dim TABLE1 As New DataTable
        TABLE1 = TmpListarDatos("NSP_BUSCAR_FACTURACIONOK  '" & codempresa & "','" & rand & "'")

        If TABLE1.Rows.Count > 0 Then

            Dim DOC As String = ""

            If TABLE1.Rows(0)("CODTIPODOC").ToString.Trim = "01" Then
                DOC = "Factura"
            End If

            If TABLE1.Rows(0)("CODTIPODOC").ToString.Trim = "03" Then
                DOC = "Boleta"
            End If

            If TABLE1.Rows(0)("CODTIPODOC").ToString.Trim = "06" Then
                DOC = "Nota Pedido"
            End If

            MsgBox("El Documento " & DOC & " " & CDbl(TABLE1.Rows(0)("NRODOCU")).ToString & " ya existe")
            Exit Sub
        End If

        '************************************************************************************************
        'VERIFICA DOCUMENTOS************************************************************************************************


        'VERIFICAR SI VENTA X COBRAR EXISTE ************************************************************************************************

        Dim TABLE2 As New DataTable
        TABLE2 = TmpListarDatos("NSP_BUSCAR_VENTAXCOBRAROK  '" & codempresa & "','" & rand & "'")

        If TABLE2.Rows.Count > 0 Then

            Dim DOC As String = ""

            If TABLE2.Rows(0)("CDTIPODOCUM").ToString.Trim = "01" Then
                DOC = "Factura"
            End If

            If TABLE2.Rows(0)("CDTIPODOCUM").ToString.Trim = "03" Then
                DOC = "Boleta"
            End If

            If TABLE2.Rows(0)("CDTIPODOCUM").ToString.Trim = "06" Then
                DOC = "Nota Pedido"
            End If

            MsgBox("El Documento Venta Por Cobrar " & DOC & " " & CDbl(TABLE2.Rows(0)("NRODOCU")).ToString & " Ya Existe")
            Exit Sub
        End If



        For i As Integer = 0 To TABLE_CONSOLCLIE.Rows.Count - 1

            Try
                If TIPODESC = False Then
                    CAyuda.Ejecutar("SP_INS_TMPVTADETdeTMPGUIAINTDET_DESC_FINAN", codempresa, CStr(rand), TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), CDbl(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT")), NROPTOVTA, CodUsuario)
                Else
                    CAyuda.Ejecutar("SP_INS_TMPVTADETdeTMPGUIAINTDET", codempresa, CStr(rand), TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), CDbl(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT")), NROPTOVTA, CodUsuario)
                End If

                Dim TOTAL As Double

                '---------------------------------------------------------------------------------------------------
                Dim TABLE_VERIPER As New DataTable
                TABLE_VERIPER = TmpListarDatos("SP_VERIFIC_PERCEPG  '" & codempresa & "','" & TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString & "'")
                If TABLE_VERIPER.Rows.Count > 0 Then
                    If CInt(TABLE_VERIPER.Rows(0)(0)) = -1 Then
                        Dim precepclien As Double
                        Dim TABLE_VTA3 As New DataTable
                        TABLE_VTA3 = TmpListarDatos("SP_BUSQ_PERCECLIDEP  '" & codempresa & "','" & TABLE_CONSOLCLIE.Rows(i)("CODCLIENTE").ToString & "'")
                        precepclien = FormatoMonto(TABLE_VTA3.Rows(0)(0), DECIRESU)

                        If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = "03" Then
                            Dim TABLE_VTA2 As New DataTable
                            TABLE_VTA2 = TmpListarDatos("SP_MONTOPERCEPCION2B  '" & codempresa & "','" & CInt(rand) & "'," & precepclien)
                            ' txtpercp.Text = FormatoMonto(TABLE_VTA2.Rows(0)(0), DECIRESU)
                            TOTAL = FormatoMonto(TABLE_VTA2.Rows(0)(1), DECIRESU)
                        End If

                        If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = "01" Then
                            Dim TABLE_VTA2 As New DataTable
                            TABLE_VTA2 = TmpListarDatos("SP_MONTOPERCEPCION2F  '" & codempresa & "','" & CInt(rand) & "'," & precepclien)
                            ' txtpercp.Text = FormatoMonto(TABLE_VTA2.Rows(0)(0), DECIRESU)
                            TOTAL = FormatoMonto(TABLE_VTA2.Rows(0)(1), DECIRESU)
                        End If
                    Else

                        Dim TABLE_VTA2 As New DataTable
                        TABLE_VTA2 = TmpListarDatos("SP_MONTOTOTAL  '" & codempresa & "','" & CInt(rand) & "'")
                        ' txtpercp.Text = FormatoMonto(TABLE_VTA2.Rows(0)(0), DECIRESU)
                        TOTAL = FormatoMonto(TABLE_VTA2.Rows(0)(0), DECIRESU)

                    End If
                End If



                If FACTPTOVTA = True Then


                    If GRABAEFECTIVOS(TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT"), TABLE_CONSOLCLIE.Rows(i)("CODTIPOPAGO"), Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy"), TOTAL, TABLE_CONSOLCLIE.Rows(i)("PORCENDESC"), TABLE_CONSOLCLIE.Rows(i)("CODCLIENTE"), TABLE_CONSOLCLIE.Rows(i)("DESCLIENTE"), TABLE_CONSOLCLIE.Rows(i)("RUC"), TABLE_CONSOLCLIE.Rows(i)("DIRECCION"), TABLE_CONSOLCLIE.Rows(i)("CODDEP"), TABLE_CONSOLCLIE.Rows(i)("NRODESPACHO"), TABLE_CONSOLCLIE.Rows(i)("CODVENDEDOR")) = False Then
                        MsgBox("- REVISE EL PEDIDO, NO SE PUDO GUARDAR EL DOCUMENTO... NRO: " & TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT") & " TIPO: " & TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), MsgBoxStyle.Information, "NARSISTEMAS")
                        Exit Sub
                    End If
                End If

                If FACTLINEA = True Then

                    If GRABAEFECTIVOS2(TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT"), TABLE_CONSOLCLIE.Rows(i)("CODTIPOPAGO"), Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy"), TOTAL, TABLE_CONSOLCLIE.Rows(i)("PORCENDESC"), TABLE_CONSOLCLIE.Rows(i)("CODCLIENTE"), TABLE_CONSOLCLIE.Rows(i)("DESCLIENTE"), TABLE_CONSOLCLIE.Rows(i)("RUC"), TABLE_CONSOLCLIE.Rows(i)("DIRECCION"), TABLE_CONSOLCLIE.Rows(i)("CODDEP"), TABLE_CONSOLCLIE.Rows(i)("NRODESPACHO"), TABLE_CONSOLCLIE.Rows(i)("CODVENDEDOR"), TABLE_CONSOLCLIE.Rows(i)("CODLINEA")) = False Then
                        MsgBox("- REVISE EL PEDIDO, NO SE PUDO GUARDAR EL DOCUMENTO... NRO: " & TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT") & " TIPO: " & TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), MsgBoxStyle.Information, "NARSISTEMAS")
                        Exit Sub
                    End If

                End If



                If FACTSUBEMP = True Then

                    If (CBool(TABLE_CONSOLCLIE.Rows(i)("SUPERVISOR")) = False) Then
                        If GRABAEFECTIVOS3(TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT"), TABLE_CONSOLCLIE.Rows(i)("CODTIPOPAGO"), Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy"), TOTAL, TABLE_CONSOLCLIE.Rows(i)("PORCENDESC"), TABLE_CONSOLCLIE.Rows(i)("CODCLIENTE"), TABLE_CONSOLCLIE.Rows(i)("DESCLIENTE"), TABLE_CONSOLCLIE.Rows(i)("RUC"), TABLE_CONSOLCLIE.Rows(i)("DIRECCION"), TABLE_CONSOLCLIE.Rows(i)("CODDEP"), TABLE_CONSOLCLIE.Rows(i)("NRODESPACHO"), TABLE_CONSOLCLIE.Rows(i)("CODVENDEDOR"), TABLE_CONSOLCLIE.Rows(i)("CODSUBEMPRESA")) = False Then
                            MsgBox("- REVISE EL PEDIDO, NO SE PUDO GUARDAR EL DOCUMENTO... NRO: " & TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT") & " TIPO: " & TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), MsgBoxStyle.Information, "NARSISTEMAS")
                            Exit Sub
                        End If

                    End If

                    If FACTSUPERVHU = True Then
                        If (CBool(TABLE_CONSOLCLIE.Rows(i)("SUPERVISOR")) = True) Then
                            If GRABAEFECTIVOS4(TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT"), TABLE_CONSOLCLIE.Rows(i)("CODTIPOPAGO"), Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy"), TOTAL, TABLE_CONSOLCLIE.Rows(i)("PORCENDESC"), TABLE_CONSOLCLIE.Rows(i)("CODCLIENTE"), TABLE_CONSOLCLIE.Rows(i)("DESCLIENTE"), TABLE_CONSOLCLIE.Rows(i)("RUC"), TABLE_CONSOLCLIE.Rows(i)("DIRECCION"), TABLE_CONSOLCLIE.Rows(i)("CODDEP"), TABLE_CONSOLCLIE.Rows(i)("NRODESPACHO"), TABLE_CONSOLCLIE.Rows(i)("CODVENDEDOR"), TABLE_CONSOLCLIE.Rows(i)("CODSUPERVISOR")) = False Then
                                MsgBox("- REVISE EL PEDIDO, NO SE PUDO GUARDAR EL DOCUMENTO... NRO: " & TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT") & " TIPO: " & TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC"), MsgBoxStyle.Information, "NARSISTEMAS")
                                Exit Sub
                            End If
                        End If
                    End If





                End If




            Catch ex As Exception
                MsgBox("- REVISE EL PEDIDO, HAY ALGUNA FALLA ES PROBABLE Q LAS TABLAS ESTEN LLENAS HAGA UN CIERRE DE DIA  ." & ex.Message, MsgBoxStyle.Information, "NARSISTEMAS")
                Exit Sub
            End Try

        Next

        Try

            CAyuda.Ejecutar("INSERT_GUIAINTERNADET", rand, LblOrdenDesp.Text, GUIAD)
            CAyuda.Ejecutar("SP_ACTUALIZA_GUIAINTCAB", codempresa, LblOrdenDesp.Text, GUIAC)

        Catch ex As Exception
            MsgBox("- HAY UN ERROR A LA HORA DE ACTUALIZAR LA GUIAINTERNADET." & ex.Message, MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End Try



        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''FACTURACION ELECTRONICA ENVIO BASE''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''' 

        If EMIELECTRONIC = True Then

            Dim fecha As String
            Dim fecha_venc As String
            Dim Totalbas As Double
            Dim CODTIPOPAGO As String
            Dim CodVend As String

            Dim Table_VC As New DataTable


            If FACTPTOVTA = True Then
                Table_VC = TmpListarDatos("SP_DOCUMENTO_FALTAN_ENVIAR   '" & codempresa & "','" & LblOrdenDesp.Text & "'")
            End If


            If FACTLINEA = True Then
                Table_VC = TmpListarDatos("SP_DOCUMENTO_FALTAN_ENVIARxlinea   '" & codempresa & "','" & LblOrdenDesp.Text & "'")
            End If

            If FACTSUBEMP = True Then

                Dim dt_validar_fe As DataTable
                'El 1 es el codigo de SubEmpresa
                dt_validar_fe = TmpListarDatos("nsp_validar_ef_todo  '" & 1 & "'")
                If dt_validar_fe.Rows.Count > 0 Then
                    Table_VC = TmpListarDatos("SP_DOCUMENTO_FALTAN_ENVIARxSubEmpresa   '" & codempresa & "','" & LblOrdenDesp.Text & "',1")
                End If
                'El 1 es el codigo de SubEmpresa
                dt_validar_fe = TmpListarDatos("nsp_validar_ef_soloFact  '" & 1 & "'")
                If dt_validar_fe.Rows.Count > 0 Then
                    Table_VC = TmpListarDatos("SP_DOCUMENTO_FALTAN_ENVIARxSubEmpresa   '" & codempresa & "','" & LblOrdenDesp.Text & "',2")
                End If



            End If


            If Table_VC.Rows.Count > 0 Then
                For Y As Integer = 0 To Table_VC.Rows.Count - 1

                    TipoDoc = Table_VC.Rows(Y)("CODTIPODOC").ToString()
                    VNroDoc = Table_VC.Rows(Y)("NRODOCU").ToString()
                    IGV = CDbl(Table_VC.Rows(Y)("IGVBAS").ToString())
                    fecha = Table_VC.Rows(Y)("FECDOCUM").ToString()
                    VRuc = Table_VC.Rows(Y)("RUCCLIENTE").ToString()
                    VCodCliente = Table_VC.Rows(Y)("CODCLIENTE").ToString()
                    VDescliente = Table_VC.Rows(Y)("DESCLIENTE").ToString()
                    Totalbas = CDbl(Table_VC.Rows(Y)("TOTBAS").ToString())
                    CODTIPOPAGO = Table_VC.Rows(Y)("CODTIPOPAGO").ToString()
                    VDireccion = Table_VC.Rows(Y)("direccion").ToString()
                    IGV = CDbl(Table_VC.Rows(Y)("IGVBAS").ToString())
                    SUBTOTAL = CDbl(Table_VC.Rows(Y)("SUBTOTBAS").ToString())
                    PERCEP = CDbl(Table_VC.Rows(Y)("IPERCEP").ToString())
                    EMAIL = Table_VC.Rows(Y)("EMAIL").ToString()
                    DNI = Table_VC.Rows(Y)("DNI").ToString()
                    CodVend = Table_VC.Rows(Y)("CODVEND").ToString()
                    fecha_venc = Table_VC.Rows(Y)("FECVENC").ToString()



                    Dim StrSql As String
                    StrSql = "SELECT VENTADET.ITEM,VENTADET.CODARTI, VENTADET.DESARTI, VENTADET.preciovta, " &
                             "  VENTADET.CANTIDAD,  VENTADET.SUBTOTBAS, '01' AS TIPOPRE," &
                                   "  VENTADET.TOTBAS, VENTADET.IGVBAS,(VENTADET.SUBTOTBAS/VENTADET.CANTIDAD) AS PRECSINIGV," &
                                   "   VENTADET.MONTODESCBAS ,VENTADET.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC,ARTICULO.codimpuesto " &
                             " FROM ARTICULO INNER JOIN VENTADET ON ARTICULO.CODARTI = VENTADET.CODARTI" &
                              " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                          "  INNER JOIN PRESENTACION ON PRESENTACION.codpres = VENTADET.CODPRES" &
                        " WHERE CONVERT(decimal(20,4),VENTADET.NRODOCU) = " & CDbl(VNroDoc) & " AND VENTADET.CODTIPODOC  = " & CStr(TipoDoc) & " ORDER BY VENTADET.ITEM "

                    Dim Tabla_Tmp As DataTable
                    Tabla_Tmp = TmpListarDatos(StrSql)

                    listaP.Clear()
                    If Tabla_Tmp.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp.Rows.Count - 1
                            Dim o As New NuevaVentaDet
                            o.CODARTI = Tabla_Tmp.Rows(x)("CODARTI")
                            o.DESARTI = Tabla_Tmp.Rows(x)("DESARTI")
                            o.CODFACELEC = Tabla_Tmp.Rows(x)("CODFACELEC")
                            o.PRECIO = Tabla_Tmp.Rows(x)("preciovta")
                            o.MONTODESCBAS = Tabla_Tmp.Rows(x)("MONTODESCBAS")
                            o.CANTIDAD = Tabla_Tmp.Rows(x)("CANTIDAD")
                            o.IGVBAS = Tabla_Tmp.Rows(x)("IGVBAS")
                            o.ITEM = Tabla_Tmp.Rows(x)("ITEM")
                            o.TIPO_IGV = IIf((Tabla_Tmp.Rows(x)("codimpuesto")) = "IGV", "IGV", "INA")
                            listaP.Add(o)
                        Next
                    End If


                    StrSql = "select codarti,item ,(preciovta - (TOTBAS/CANTIDAD)) as Prod_Desct_Ddocumento from VENTADET" &
                        " WHERE CONVERT(decimal(20,4),NRODOCU) = " & CDbl(VNroDoc) & " AND CODTIPODOC  = " & CStr(TipoDoc) & " and MONTODESCBAS > 0"

                    Dim Tabla_Tmp2 As DataTable
                    Tabla_Tmp2 = TmpListarDatos(StrSql)

                    listaDesc.Clear()
                    If Tabla_Tmp2.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp2.Rows.Count - 1
                            Dim o As New DescDdocum
                            o.codarti = Tabla_Tmp2.Rows(x)("codarti")
                            o.item = Tabla_Tmp2.Rows(x)("item")
                            o.prod_desct = Tabla_Tmp2.Rows(x)("Prod_Desct_Ddocumento")
                            listaDesc.Add(o)
                        Next
                    End If





                    If TipoDoc.Trim = "01" Or TipoDoc.Trim = "03" Then



                        If IGV > 0 Then
                            TIPO_IGV = "SI"
                        Else
                            TIPO_IGV = "NO"
                        End If

                        'Dim Table_VC2 As New DataTable
                        'Table_VC2 = TmpListarDatos("SP_SELECT_EMAIL_CLIENTE   '" & CStr(TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString) & "','" & CStr(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT").ToString) & "'")
                        'If Table_VC2.Rows.Count > 0 Then
                        '    EMAIL = Table_VC2.Rows(0)("EMAIL").ToString()
                        '    DNI = Table_VC2.Rows(0)("DNI").ToString()
                        If VCodCliente = "888" Then
                            DNI = "88888888"
                        End If
                        'End If



                        If TipoDoc.Trim = "01" Then
                            LETRADOC = "F"
                            CLIE_DOCU = CStr(VRuc.Trim)
                        End If
                        If TipoDoc.Trim = "03" Then
                            LETRADOC = "B"
                            CLIE_DOCU = DNI
                            If CLIE_DOCU.Length = 0 Then
                                CLIE_DOCU = "99999999"
                            End If
                        End If

                        Dim FormatNroDoc As String
                        FormatNroDoc = Format(VNroDoc, "0##-########")
                        Dim NUMSERIE As String
                        NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                        SERIE = LETRADOC + NUMSERIE
                        NRODOCSIN = CStr(Microsoft.VisualBasic.Right(VNroDoc, 8))
                        NRODOCFINAL = SERIE + "-" + NRODOCSIN

                        Dim dblTOTINAFECTO As Double
                        Dim TABLA_INAFECTO As New DataTable
                        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO  '" & TipoDoc & "','" & VNroDoc & "'  ")

                        If TABLA_INAFECTO.Rows.Count > 0 Then
                            dblTOTINAFECTO = CDbl(FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString)
                        End If


                        If FACTPTOVTA = True Then
                            If NOSERIE = SERIE Then

                            Else
                                GoTo IR
                            End If
                        End If


                        If FACTLINEA = True Then
                            GoTo IR
                        End If

                        If FACTSUBEMP = True Then
                            GoTo IR
                        End If

IR:

                            Try

                                Dim gestordefacturacionelectronica As IGestorDeFacturacionElectronica = New GestorDeFacturacionElectronica()
                                Dim nuevohdocumento As New NuevaHdocumento

                                nuevohdocumento.codi_cab = 1
                                nuevohdocumento.esta_pod = 1
                                nuevohdocumento.codi_caja = CStr(NROPTOVTA)
                                nuevohdocumento.comp = TipoDoc
                                nuevohdocumento.serie = SERIE
                                nuevohdocumento.nume = NRODOCSIN
                                nuevohdocumento.fecha = Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy")
                                nuevohdocumento.codi_vend = CodVend
                                nuevohdocumento.clie_docu = CLIE_DOCU
                                nuevohdocumento.clie_nomb = VDescliente
                                nuevohdocumento.clie_dire = VDireccion
                                nuevohdocumento.clie_email = EMAIL
                                nuevohdocumento.clie_celu = ""
                                nuevohdocumento.dire_entr = ""
                                nuevohdocumento.ubig_entr = UBIGUEO
                                nuevohdocumento.mone_codi = "PEN"
                                nuevohdocumento.LLEVAigv = TIPO_IGV
                                nuevohdocumento.desc_globa = ""
                                nuevohdocumento.obse = ""
                                nuevohdocumento.guia = ""
                                nuevohdocumento.placa = ""
                                nuevohdocumento.dire_part = ""
                                nuevohdocumento.ubig_part = ""
                                nuevohdocumento.ubig_lleg = ""
                                nuevohdocumento.cod_Ubigeo = ""
                                nuevohdocumento.tipo_trans = ""
                                nuevohdocumento.peso_kg = 0.0
                                nuevohdocumento.trans_publ_ruc = ""
                                nuevohdocumento.trans_publ_razon = ""
                                nuevohdocumento.trans_priv_placa = ""
                                nuevohdocumento.trans_priv_marca = ""
                                nuevohdocumento.trans_priv_const = ""
                                nuevohdocumento.trans_priv_lice = ""
                                nuevohdocumento.codi_moti = ""
                                nuevohdocumento.motivo = ""
                                nuevohdocumento.doc_refe = ""
                                nuevohdocumento.ValorResumen = 0.0
                                nuevohdocumento.ValorHash = ""
                                nuevohdocumento.DarBaja = 0
                                nuevohdocumento.MotivoBaja = ""
                                nuevohdocumento.ProcesarBaja = 0
                            nuevohdocumento.Grabado = SUBTOTAL - dblTOTINAFECTO
                            nuevohdocumento.IGV = IGV
                            nuevohdocumento.Total = Totalbas
                                nuevohdocumento.dire_lleg = ""
                                nuevohdocumento.Guia_trans = ""
                                nuevohdocumento.Envio_xml = 0
                                nuevohdocumento.Clie_tipo = IIf(CStr(VRuc.Trim) <> "", 6, 1)
                                nuevohdocumento.Fact_guia = "NO"
                                nuevohdocumento.Exonerado = 0
                                nuevohdocumento.Inafecto = dblTOTINAFECTO
                                nuevohdocumento.percepcion = PERCEP
                                nuevohdocumento.Codigo_local = CODLOCAL
                            nuevohdocumento.hora = Now.ToString("HH:mm:ss")

                            If CODTIPOPAGO = "01" Then
                                nuevohdocumento.Forma_pago = "CONTADO"
                                nuevohdocumento.total_credito = 0

                            End If

                            If CODTIPOPAGO = "06" Then
                                nuevohdocumento.Forma_pago = "CREDITO"
                                nuevohdocumento.total_credito = Totalbas
                            End If



                            Using scope As TransactionScope = New TransactionScope()

                                    Dim CODCAB As Integer
                                    CODCAB = gestordefacturacionelectronica.CrearHdocumento(nuevohdocumento).codi_cab

                                    For x As Integer = 0 To Me.listaP.Count - 1
                                        Dim nuevoddocumento As New NuevaDDocumento
                                        nuevoddocumento.id = 1
                                        nuevoddocumento.prod_codi = listaP.Item(x).CODARTI.ToString
                                        nuevoddocumento.prod_descr = listaP.Item(x).DESARTI.ToString
                                        nuevoddocumento.prod_unid = listaP.Item(x).CODFACELEC.ToString
                                        nuevoddocumento.prod_precio = listaP.Item(x).PRECIO
                                        nuevoddocumento.prod_desct = listaP.Item(x).MONTODESCBAS
                                        nuevoddocumento.prod_cant = listaP.Item(x).CANTIDAD

                                        For d As Integer = 0 To Me.listaDesc.Count - 1
                                            If listaP.Item(x).CODARTI.ToString = listaDesc.Item(d).codarti.ToString Then
                                                If CInt(listaP.Item(x).ITEM) = CInt(listaDesc.Item(d).item) Then
                                                    nuevoddocumento.prod_desct = listaDesc.Item(d).prod_desct.ToString
                                                    Exit For
                                                End If
                                            End If
                                        Next


                                        If listaP.Item(x).PRECIO.ToString() = "0.0100" Then
                                            If listaP.Item(x).TIPO_IGV = "IGV" Then
                                                nuevoddocumento.igv = Math.Round((1.18 - 1) * (listaP.Item(x).CANTIDAD * listaP.Item(x).PRECIO / 1.18), 6)
                                                nuevoddocumento.tipo_igv = "IGV"
                                            Else
                                                nuevoddocumento.igv = 0
                                                nuevoddocumento.tipo_igv = "INA"
                                            End If
                                        Else
                                            nuevoddocumento.igv = listaP.Item(x).IGVBAS
                                            nuevoddocumento.tipo_igv = listaP.Item(x).TIPO_IGV
                                        End If

                                        nuevoddocumento.percepcion = PERCEP
                                        nuevoddocumento.codi_cab = CODCAB
                                        nuevoddocumento.obse = "AAAAA"
                                        nuevoddocumento.codigo_sunat = " "
                                        nuevoddocumento.codigo_gsi = " "
                                        gestordefacturacionelectronica.CrearDdocumento(nuevoddocumento)
                                    Next
                                gestordefacturacionelectronica.ModificarEstado(SERIE, NRODOCSIN)



                                If CODTIPOPAGO = "06" Then

                                    Dim nuevocdocumento As New NuevaCDocumento
                                    nuevocdocumento.cred_codi = 1
                                    nuevocdocumento.codi_cab = CODCAB
                                    nuevocdocumento.num_cuota = 1
                                    nuevocdocumento.monto_cuota = Totalbas
                                    nuevocdocumento.fecha_vence = Format(CDate(fecha_venc), "dd/MM/yyyy")
                                    gestordefacturacionelectronica.CrearCDocumento(nuevocdocumento)
                                End If

                                scope.Complete()





                            End Using

                            Catch ex As Exception
                                MsgBox("- REVISE LA FACTURACION ELECTRONICA, HAY ALGUNA FALLA ." & ex.Message, MsgBoxStyle.Information, "NARSISTEMAS")
                                Exit Sub
                            End Try
                            CAyuda.Ejecutar("SP_UDPDATE_CABCODHAS", VNroDoc, TipoDoc, "", 1, SERIE, NRODOCSIN)


                    End If

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''' VERIFICO SI SE ENVIO A SUNAT O CORRECTAMENTE '''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Next
            End If
        End If






        Try
            Dim MinMensFact, MinMensBol, MinMensNotaPed As Double
            Dim MaxMensFact, MaxMensBol, MaxMensNotaPed As Double

            '''''HALLAR MINIMO 
            Dim Documento As String = ""
            Dim Factura2 As String = ""
            Dim Boleta2 As String = ""
            Dim NotaPedido2 As String = ""

            For i As Integer = 0 To TABLE_CONSOLCLIE.Rows.Count - 1
                Documento = TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT").ToString.Trim
                If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = CDFACTURA Then
                    If MaxMensFact < CDbl(Documento) Then
                        MaxMensFact = CDbl(Documento)
                    End If
                End If
                If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = CDBOLETA Then
                    If MaxMensBol < CDbl(Documento) Then
                        MaxMensBol = CDbl(Documento)
                    End If
                End If

                If TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString.Trim = CDNTAPEDIDO Then
                    If MaxMensNotaPed < CDbl(Documento) Then
                        MaxMensNotaPed = CDbl(Documento)
                    End If

                End If

            Next

            For a As Integer = 0 To TABLE_CONSOLCLIE.Rows.Count - 1
                Documento = TABLE_CONSOLCLIE.Rows(a)("NRODOCFACT").ToString.Trim
                If TABLE_CONSOLCLIE.Rows(a)("CODTIPODOC").ToString.Trim = CDFACTURA Then
                    If MinMensFact = 0 Then
                        MinMensFact = CDbl(Documento)
                    End If
                    If MinMensFact > CDbl(Documento) Then
                        MinMensFact = CDbl(Documento)
                    End If
                End If
                If TABLE_CONSOLCLIE.Rows(a)("CODTIPODOC").ToString.Trim = CDBOLETA Then
                    If MinMensBol = 0 Then
                        MinMensBol = CDbl(Documento)
                    End If
                    If MinMensBol > CDbl(Documento) Then
                        MinMensBol = CDbl(Documento)
                    End If
                End If

                If TABLE_CONSOLCLIE.Rows(a)("CODTIPODOC").ToString.Trim = CDNTAPEDIDO Then
                    If MinMensNotaPed = 0 Then
                        MinMensNotaPed = CDbl(Documento)
                    End If
                    If MinMensNotaPed > CDbl(Documento) Then
                        MinMensNotaPed = CDbl(Documento)
                    End If

                End If
            Next

            If MinMensFact > 0 Then
                If MinMensFact = MaxMensFact Then
                    Factura2 = "Factura: " & MinMensFact
                Else
                    Factura2 = "Factura: " & MinMensFact & " - " & MaxMensFact
                End If
            End If

            If MinMensBol > 0 Then
                If MinMensBol = MaxMensBol Then
                    Boleta2 = "Boleta: " & MinMensBol
                Else
                    Boleta2 = "Boleta: " & MinMensBol & " - " & MaxMensBol
                End If
            End If

            If MinMensNotaPed > 0 Then

                If MinMensNotaPed = MaxMensNotaPed Then
                    NotaPedido2 = "Nota de Pedido: " & MinMensNotaPed
                Else
                    NotaPedido2 = "Nota de Pedido: " & MinMensNotaPed & " - " & MaxMensNotaPed
                End If
            End If

            Dim Frm As New FrmDocumentosGenerados
            Frm.TxtDoc.Text = Factura2 & vbNewLine & Boleta2 & vbNewLine & NotaPedido2
            Frm.ShowDialog()

            LblOrdenDesp.Text = String.Empty
            LblTotal.Text = ""
            TABLE_CONSOLCLIE.Rows.Clear()
            TABLE_DETALLE_PEDI.Rows.Clear()
            TABLE_CABECERA_PEDI.Rows.Clear()
            TABLE_DETALLE_VERIFI.Rows.Clear()
            TABLE_PEDIDOS_FACTURAR.Rows.Clear()
            GridCabcera.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnTodasGuias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTodasGuias.Click
        TmpInsertDatos("NSP_CARGAR_ORDENDESPACHO  '" & codempresa & "','" & rand & "','','0'," & GUIAD)
        TmpInsertDatos("SP_INSERTAR_DOCUMENTOS_CONSOLCLIE  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "'")
        CARGAR_GRID()
        FORMATO_GRID()

    End Sub
    Private Sub GridClientes_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridClientes.CurrentCellChanged
        ESCRIBIRMENSAJE()
    End Sub
    Private Sub GridCabcera_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCabcera.DoubleClick
        If TABLE_CONSOLCLIE.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim TABLE_DETALLE As New DataTable

        Dim TIPODOC, CODTIPODOC, CDCLIENTE, CDEMPRESA, NRODOCUMENT, NUM_PEDIDO As String
        TIPODOC = GridCabcera.Item(GridCabcera.CurrentRowIndex, 2).ToString.Trim
        CODTIPODOC = GridCabcera.Item(GridCabcera.CurrentRowIndex, 1).ToString.Trim
        CDEMPRESA = GridCabcera.Item(GridCabcera.CurrentRowIndex, 3).ToString.Trim
        CDCLIENTE = GridCabcera.Item(GridCabcera.CurrentRowIndex, 4).ToString.Trim
        NRODOCUMENT = GridCabcera.Item(GridCabcera.CurrentRowIndex, 3).ToString.Trim
        NUM_PEDIDO = GridCabcera.Item(GridCabcera.CurrentRowIndex, 9).ToString.Trim

        TABLE_DETALLE = CAyuda.ListarDatos("SP_DEL_FAC_PED_ORDEN", codempresa, rand, LblOrdenDesp.Text.Trim, NRODOCUMENT.Trim).Tables(0)

        'TABLE_DETALLE = TABLE_DETALLE_PEDI.Clone
        'For det As Integer = 0 To TABLE_DETALLE_PEDI.Rows.Count - 1
        '    If TABLE_DETALLE_PEDI.Rows(det)("CODTIPODOC").ToString.Trim = CODTIPODOC And TABLE_DETALLE_PEDI.Rows(det)("NRODOCU").ToString.Trim = NRODOCUMENT And TABLE_DETALLE_PEDI.Rows(det)("CODEMPRESA").ToString.Trim = CDEMPRESA And TABLE_DETALLE_PEDI.Rows(det)("CODCLIENTE").ToString.Trim = CDCLIENTE Then
        '        TABLE_DETALLE.ImportRow(TABLE_DETALLE_PEDI.Rows(det))
        '    End If
        'Next
        Dim FrmDet As New frmDetalle_FacuracionPedidos
        FrmDet.CDTIPODOC_BK = CODTIPODOC
        FrmDet.TABLE_DETALLE_FACTURACION = TABLE_DETALLE
        FrmDet.ShowDialog()

        If FrmDet.DEVOLVER = True Then
            CAyuda.Ejecutar("SP_UPD_DOCU_PEDI", codempresa, NROPTOVTA, NRODOCUMENT, FrmDet.CDNTIPODOC, rand, LblOrdenDesp.Text.Trim, NUM_PEDIDO.Trim)

            CARGAR_GRID()
            FORMATO_GRID()

        End If

    End Sub

    Private Sub btnBusOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusOrden.Click
        Dim o As New FrmBusquedaDeOrdenDespacho
        o.TIPO = "C"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        LblOrdenDesp.Text = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)

        GUIAC = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 4)
        GUIAD = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 5)

    End Sub

    Dim rand As Integer

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click


        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DtFechaDoc.Value.Year
        MES = DtFechaDoc.Value.Month

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


        Dim TB_DUPLIVEND As DataTable
        TB_DUPLIVEND = TmpListarDatos("NSP_VERICAR_DUPLIVEND '" & LblOrdenDesp.Text & "'")
        If TB_DUPLIVEND.Rows.Count > 0 Then
            MsgBox("HAY VENDEDORES DUPLICADOS PRIMERO TIENE Q ARREGLAR ESO")
            Exit Sub
        End If





        '//verificar si la linea tiene correlativo
        If FACTPTOVTA = True Then

        Else
            'Dim TABLE_LINEAFACTURAR As DataTable
            'TABLE_LINEAFACTURAR = TmpListarDatos("sp_Lineas_AFacturar   '" & LblOrdenDesp.Text & "'")
            'Dim codlinea As String
            'If TABLE_LINEAFACTURAR.Rows.Count > 0 Then
            '    For i As Integer = 0 To TABLE_LINEAFACTURAR.Rows.Count - 1
            '        codlinea = TABLE_LINEAFACTURAR.Rows(i)("codlinea").ToString()
            '        Dim TABLE_EXISTELINEAFACTURAR As DataTable
            '        TABLE_EXISTELINEAFACTURAR = TmpListarDatos("sp_existe_LineaCorre   '" & codlinea & "'")
            '        If TABLE_EXISTELINEAFACTURAR.Rows.Count = 0 Then
            '            MsgBox("ESTA LINEA " + TABLE_LINEAFACTURAR.Rows(i)("DESLINEA").ToString() + " NO TIENE CORRELATIVO PARA FACTURAR")
            '            Exit Sub
            '        End If
            '    Next
            'End If
        End If




        ValorRan()

        If LblOrdenDesp.Text.Trim = "" Then
            Exit Sub
        End If

        TmpInsertDatos("NSP_CARGAR_ORDENDESPACHO  '" & codempresa & "','" & rand & "','" & LblOrdenDesp.Text & "','1','" & GUIAD & "'")

        TmpInsertDatos("NSP_CAMBIAR_TIPOPAGO  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "'")


        'Dim TAB_VENDFALTAN As DataTable
        'TAB_VENDFALTAN = TmpListarDatos("SELECT_TMP_GUIAINTERNADETXNUMPEDIDO  '" & rand & "','" & "03" & "'")


        'Dim obs2 As String = ""
        'If TAB_VENDFALTAN.Rows.Count > 0 Then

        '    For x1 As Integer = 0 To TAB_VENDFALTAN.Rows.Count - 1
        '        obs2 = obs2 + vbCrLf + " con codigo de Pedido " + CStr(TAB_VENDFALTAN.Rows(x1)("num_pedido")) + " y codigo cliente " + TAB_VENDFALTAN.Rows(x1)("codcliente") + ","
        '    Next

        '    MessageBox.Show("Pedidos Mayores a 4000 no se puede procesar boletas " & obs2, DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If



        Dim TABLE_DETALLE As DataTable
        TABLE_DETALLE = TmpListarDatos("SELECT_TMP_GUIAINTERNADET   '" & rand & "'")

        For i As Integer = 0 To TABLE_DETALLE.Rows.Count - 1

            CAyuda.Ejecutar("DELETE_TMP_PEDIDO_VTA_DET", rand)

            Dim CODTIPODOC As String

            CODTIPODOC = TABLE_DETALLE.Rows(i)("CODTIPODOC")

            Dim MONTO_VERIF As Double

            If CODTIPODOC.Trim = "03" Then
                MONTO_VERIF = PREC_BOLETA
            End If

            If CODTIPODOC.Trim = "06" Then
                MONTO_VERIF = PREC_NOTAPEDIDO
            End If

            If CODTIPODOC.Trim = "01" Then
                MONTO_VERIF = PREC_FACTURA
            End If



            If TABLE_DETALLE.Rows(i)("TOTBAS") > MONTO_VERIF Then
                Dim CANTIDAD As Integer
                Dim PRECIOVTA As Double
                Dim TOTAL As Double
                Dim NUEVOTOTAL As Double = 0.0
                Dim CONTA As Integer = 0

                Dim CODARTI As String
                Dim DESARTI As String

                Dim CODPRES As String
                Dim DESPRES As String

                Dim CDZONA1 As String
                Dim CDTIPOPRE As String
                Dim CODTIPOPAGO As String
                Dim FECDOCUM As String

                CODARTI = TABLE_DETALLE.Rows(i)("CODARTI")
                DESARTI = TABLE_DETALLE.Rows(i)("DESARTI")
                CODPRES = TABLE_DETALLE.Rows(i)("CODPRES")
                DESPRES = TABLE_DETALLE.Rows(i)("DESPRES")
                CDZONA1 = CDZONA
                CDTIPOPRE = TABLE_DETALLE.Rows(i)("CODTIPOPRE")
                CODTIPOPAGO = TABLE_DETALLE.Rows(i)("CODTIPOPAGO")
                FECDOCUM = TABLE_DETALLE.Rows(i)("FECDOCUM")
                CANTIDAD = TABLE_DETALLE.Rows(i)("CANTIDAD")
                PRECIOVTA = TABLE_DETALLE.Rows(i)("PRECIOVTA")

IR:

                CANTIDAD = CANTIDAD - CONTA

                CONTA = 0

                For X As Integer = 1 To CANTIDAD

                    TOTAL = PRECIOVTA * X

                    If TOTAL > MONTO_VERIF Then
                        ' NUEVOTOTAL = TOTAL
                        Exit For
                    End If
                    CONTA = CONTA + 1

                Next



                CAyuda.Ejecutar("InsTMP_PEDIDO_VTA_DETxProc2", codempresa, CODARTI, DESARTI, CONTA, PRECIOVTA, PRECIOVTA, CODPRES, DESPRES, "S", rand, CDZONA, CodUsuario, CDTIPOPRE, CODTIPOPAGO, FECDOCUM)

                If CONTA = CANTIDAD Then
                Else
                    GoTo IR
                End If

                Dim NUM_PEDIDO As String
                Dim CDALMACEN As String
                Dim CODCLIENTE As String
                Dim DESCLIENTE As String
                Dim DIRECCION As String
                Dim RUC As String
                Dim PTOLLEGADA As String
                Dim CODRUTA As String
                Dim CODVENDEDOR As String


                Dim CODDEP As String
                Dim PESO As String
                Dim NRODESPACHO As String

                Dim ID As String



                NUM_PEDIDO = TABLE_DETALLE.Rows(i)("NUM_PEDIDO")
                CDALMACEN = TABLE_DETALLE.Rows(i)("CODALMACEN")
                CODCLIENTE = TABLE_DETALLE.Rows(i)("CODCLIENTE")
                DESCLIENTE = TABLE_DETALLE.Rows(i)("DESCLIENTE")

                DIRECCION = TABLE_DETALLE.Rows(i)("DIRECCION")
                RUC = TABLE_DETALLE.Rows(i)("RUC")
                PTOLLEGADA = TABLE_DETALLE.Rows(i)("PTOLLEGADA")
                CODRUTA = TABLE_DETALLE.Rows(i)("CODRUTA")
                CODVENDEDOR = TABLE_DETALLE.Rows(i)("CODVENDEDOR")
                CODRUTA = TABLE_DETALLE.Rows(i)("CODRUTA")

                CODTIPOPAGO = TABLE_DETALLE.Rows(i)("CODTIPOPAGO")
                CODDEP = TABLE_DETALLE.Rows(i)("CODDEP")

                PESO = TABLE_DETALLE.Rows(i)("PESO")
                NRODESPACHO = TABLE_DETALLE.Rows(i)("NRODESPACHO")

                ID = TABLE_DETALLE.Rows(i)("Id")

                CAyuda.Ejecutar("INSERT_TMP_GUIAINTERNADET", rand, NUM_PEDIDO, CDALMACEN, CODCLIENTE, DESCLIENTE, DIRECCION, RUC, PTOLLEGADA, CODRUTA, CODVENDEDOR, CODTIPOPAGO, CDTIPOPRE, CODDEP, PESO, NRODESPACHO, CODTIPODOC)

                CAyuda.Ejecutar("DELETE_TMP_GUIAINTERNADET", rand, NUM_PEDIDO, CODARTI, ID)

                CAyuda.Ejecutar("SP_ORDENAR", codempresa, rand, NUM_PEDIDO)

            End If

        Next



        If FACTPTOVTA = True Then
            TmpInsertDatos("SP_INSERTAR_DOCUMENTOS_CONSOLCLIE  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "'")
        End If


        If FACTLINEA = True Then

            TmpInsertDatos("SP_INSERT_DOC_CONSOLCLIE_NOTXLINEADOC  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "'")

            Dim codlinea As String
            Dim TABLE_LINEAXDOC As DataTable
            TABLE_LINEAXDOC = TmpListarDatos("SP_LINEACORREXTMPGUIA   '" & codempresa & "','" & rand & "','" & LblOrdenDesp.Text & "'")

            For i As Integer = 0 To TABLE_LINEAXDOC.Rows.Count - 1
                codlinea = TABLE_LINEAXDOC.Rows(i)("LineaCodlinea").ToString()
                TmpInsertDatos("SP_INSERT_DOC_CONSOLCLIE_XLINEADOC  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "','" & codlinea & "'")
            Next

            'Se vuelve a modificar el nrodocumento pero solo en notapedido ya q hubo problemas por la linea de documento
            TmpInsertDatos("NSP_MODIFICAR_NRONTAPEDIDO  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "','06'")

        End If


        If FACTSUBEMP = True Then

            Dim codsubempresa As String
            Dim TABLE_SUBEMPXTMPGUIA As DataTable
            TABLE_SUBEMPXTMPGUIA = TmpListarDatos("SP_SUBEMPRESAXTMPGUIA   '" & codempresa & "','" & rand & "','" & LblOrdenDesp.Text & "'")

            For i As Integer = 0 To TABLE_SUBEMPXTMPGUIA.Rows.Count - 1



                codsubempresa = TABLE_SUBEMPXTMPGUIA.Rows(i)("Id").ToString()



                '***********SUPERVISOR*******************************************
                If FACTSUPERVHU = True Then
                    Dim codsupervisor As String
                    Dim TABLE_SUPERVXTMPGUIA As DataTable
                    TABLE_SUPERVXTMPGUIA = TmpListarDatos("SP_SUPERVISORXTMPGUIA   '" & codempresa & "','" & rand & "','" & LblOrdenDesp.Text & "'")

                    For j As Integer = 0 To TABLE_SUPERVXTMPGUIA.Rows.Count - 1
                        Dim TABLE_SUPERVXTMPGUIAXFACT As DataTable
                        TABLE_SUPERVXTMPGUIAXFACT = TmpListarDatos("SP_SUPERVISORXTMPGUIA_FACTURA   '" & codempresa & "','" & rand & "','" & LblOrdenDesp.Text & "'")
                        For h As Integer = 0 To TABLE_SUPERVXTMPGUIA.Rows.Count - 1

                            codsupervisor = TABLE_SUPERVXTMPGUIA.Rows(j)("Codsuperv").ToString()
                            TmpInsertDatos("SP_INSERT_DOC_CONSOLCLIE_XSUPERVISOR_FACTURA  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "','" & codsubempresa & "','" & codsupervisor & "'")
                            TmpInsertDatos("SP_INSERT_DOC_CONSOLCLIE_XSUPERVISOR_BOLETA  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "','" & codsubempresa & "','" & codsupervisor & "'")
                        Next


                    Next
                End If







                '***********SUBEMPRESA*******************************************

                TmpInsertDatos("SP_INSERT_DOC_CONSOLCLIE_XSUBEMPRESA  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "','" & codsubempresa & "'")





            Next



            'Se vuelve a modificar el nrodocumento pero solo en notapedido ya q hubo problemas por la linea de documento
            'TmpInsertDatos("NSP_MODIFICAR_NRONTAPEDIDO  '" & codempresa & "','" & rand & "','" & NROPTOVTA & "','06'")

        End If


        CARGAR_GRID()
        FORMATO_GRID()

    End Sub

    Private Sub GridCabcera_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridCabcera.Navigate

    End Sub


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click


        TABLE_CABECERA_PEDI.Rows.Clear()
        TABLE_DETALLE_PEDI.Rows.Clear()
        TABLE_DETALLE_VERIFI.Rows.Clear()
        TABLE_PEDIDOS_FACTURAR.Rows.Clear()
        TABLE_CONSOLCLIE.Rows.Clear()
        GridCabcera.DataSource = Nothing
        LblOrdenDesp.Text = ""
        LblTotal.Text = ""


    End Sub


    Private Sub LblOrdenDesp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblOrdenDesp.Click

    End Sub


End Class

