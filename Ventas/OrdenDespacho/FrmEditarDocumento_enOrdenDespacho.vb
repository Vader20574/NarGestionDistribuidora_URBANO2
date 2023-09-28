Imports System.Data.SqlClient

Public Class FrmEditarDocumento_enOrdenDespacho
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbTipoPAgo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TablaEstiloDetDocu As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ITEM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CODARTI As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DSARTI As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CODPRES As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESPRES As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CANTIDAD As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PRECIOVTA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TOTBAS As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TOTEXT As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnGenera As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarDoc As System.Windows.Forms.Button
    Friend WithEvents gArticulos As System.Windows.Forms.GroupBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbcliente As System.Windows.Forms.Label
    Friend WithEvents BtnArticulos As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbTOTAL As System.Windows.Forms.Label
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents txtcodarticulo As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtcodclie As System.Windows.Forms.TextBox
    Friend WithEvents Txtruc As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents DtFechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTSERIEDOC As System.Windows.Forms.TextBox
    Friend WithEvents TXTNUMERODOC As System.Windows.Forms.TextBox
    Friend WithEvents lbltipodoc As System.Windows.Forms.Label
    Friend WithEvents CTRLIGV As System.Windows.Forms.Label
    Friend WithEvents CTRLSUBTOTAL As System.Windows.Forms.Label
    Friend WithEvents lblsubtotal As System.Windows.Forms.Label
    Friend WithEvents LBLIGV As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEditarDocumento_enOrdenDespacho))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DtFechaDoc = New System.Windows.Forms.DateTimePicker
        Me.Txtruc = New System.Windows.Forms.TextBox
        Me.txtcodclie = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Txtcliente = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbltipodoc = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXTSERIEDOC = New System.Windows.Forms.TextBox
        Me.TXTNUMERODOC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbTipoPAgo = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.BtnQuitarDoc = New System.Windows.Forms.Button
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.TablaEstiloDetDocu = New System.Windows.Forms.DataGridTableStyle
        Me.ITEM = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CODARTI = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DSARTI = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CODPRES = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESPRES = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CANTIDAD = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PRECIOVTA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TOTBAS = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TOTEXT = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnGenera = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.gArticulos = New System.Windows.Forms.GroupBox
        Me.TxtPrecio = New System.Windows.Forms.TextBox
        Me.txtdescripcion = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbPresentacion = New System.Windows.Forms.ComboBox
        Me.txtcodarticulo = New System.Windows.Forms.TextBox
        Me.lbcliente = New System.Windows.Forms.Label
        Me.BtnArticulos = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label9 = New System.Windows.Forms.Label
        Me.CTRLSUBTOTAL = New System.Windows.Forms.Label
        Me.lblsubtotal = New System.Windows.Forms.Label
        Me.LBLIGV = New System.Windows.Forms.Label
        Me.CTRLIGV = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lbTOTAL = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gArticulos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DtFechaDoc)
        Me.Panel1.Controls.Add(Me.Txtruc)
        Me.Panel1.Controls.Add(Me.txtcodclie)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.Txtcliente)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lbltipodoc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TXTSERIEDOC)
        Me.Panel1.Controls.Add(Me.TXTNUMERODOC)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cbTipoPAgo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(124, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(714, 124)
        Me.Panel1.TabIndex = 2
        '
        'DtFechaDoc
        '
        Me.DtFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFechaDoc.Location = New System.Drawing.Point(598, 14)
        Me.DtFechaDoc.Name = "DtFechaDoc"
        Me.DtFechaDoc.Size = New System.Drawing.Size(88, 20)
        Me.DtFechaDoc.TabIndex = 67
        '
        'Txtruc
        '
        Me.Txtruc.BackColor = System.Drawing.Color.White
        Me.Txtruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtruc.Location = New System.Drawing.Point(242, 44)
        Me.Txtruc.Name = "Txtruc"
        Me.Txtruc.ReadOnly = True
        Me.Txtruc.Size = New System.Drawing.Size(86, 20)
        Me.Txtruc.TabIndex = 66
        Me.Txtruc.Text = ""
        '
        'txtcodclie
        '
        Me.txtcodclie.BackColor = System.Drawing.Color.White
        Me.txtcodclie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodclie.Location = New System.Drawing.Point(88, 42)
        Me.txtcodclie.Name = "txtcodclie"
        Me.txtcodclie.ReadOnly = True
        Me.txtcodclie.Size = New System.Drawing.Size(86, 20)
        Me.txtcodclie.TabIndex = 65
        Me.txtcodclie.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Codigo : "
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(86, 94)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(372, 20)
        Me.txtDireccion.TabIndex = 63
        Me.txtDireccion.Text = ""
        '
        'Txtcliente
        '
        Me.Txtcliente.BackColor = System.Drawing.Color.White
        Me.Txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcliente.Location = New System.Drawing.Point(88, 68)
        Me.Txtcliente.Name = "Txtcliente"
        Me.Txtcliente.ReadOnly = True
        Me.Txtcliente.Size = New System.Drawing.Size(246, 20)
        Me.Txtcliente.TabIndex = 62
        Me.Txtcliente.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(206, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "RUC:"
        '
        'lbltipodoc
        '
        Me.lbltipodoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltipodoc.Location = New System.Drawing.Point(268, 6)
        Me.lbltipodoc.Name = "lbltipodoc"
        Me.lbltipodoc.Size = New System.Drawing.Size(248, 34)
        Me.lbltipodoc.TabIndex = 46
        Me.lbltipodoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Apell./Raz Soc.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(534, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Fecha Doc.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Direccion:"
        '
        'TXTSERIEDOC
        '
        Me.TXTSERIEDOC.BackColor = System.Drawing.Color.White
        Me.TXTSERIEDOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSERIEDOC.Location = New System.Drawing.Point(98, 4)
        Me.TXTSERIEDOC.Name = "TXTSERIEDOC"
        Me.TXTSERIEDOC.ReadOnly = True
        Me.TXTSERIEDOC.Size = New System.Drawing.Size(42, 20)
        Me.TXTSERIEDOC.TabIndex = 65
        Me.TXTSERIEDOC.Text = ""
        Me.TXTSERIEDOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTNUMERODOC
        '
        Me.TXTNUMERODOC.BackColor = System.Drawing.Color.White
        Me.TXTNUMERODOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNUMERODOC.Location = New System.Drawing.Point(146, 4)
        Me.TXTNUMERODOC.Name = "TXTNUMERODOC"
        Me.TXTNUMERODOC.ReadOnly = True
        Me.TXTNUMERODOC.Size = New System.Drawing.Size(64, 20)
        Me.TXTNUMERODOC.TabIndex = 65
        Me.TXTNUMERODOC.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nro Documento.: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(134, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 27)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "-"
        '
        'cbTipoPAgo
        '
        Me.cbTipoPAgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoPAgo.Location = New System.Drawing.Point(424, 66)
        Me.cbTipoPAgo.Name = "cbTipoPAgo"
        Me.cbTipoPAgo.Size = New System.Drawing.Size(162, 21)
        Me.cbTipoPAgo.TabIndex = 55
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(358, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 16)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Tipo Pago :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnQuitarDoc
        '
        Me.BtnQuitarDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarDoc.Location = New System.Drawing.Point(16, 150)
        Me.BtnQuitarDoc.Name = "BtnQuitarDoc"
        Me.BtnQuitarDoc.Size = New System.Drawing.Size(82, 48)
        Me.BtnQuitarDoc.TabIndex = 51
        Me.BtnQuitarDoc.Text = "Anular Documento"
        '
        'Grid1
        '
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(10, 232)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(794, 162)
        Me.Grid1.TabIndex = 3
        Me.Grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloDetDocu})
        '
        'TablaEstiloDetDocu
        '
        Me.TablaEstiloDetDocu.DataGrid = Me.Grid1
        Me.TablaEstiloDetDocu.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ITEM, Me.CODARTI, Me.DSARTI, Me.CODPRES, Me.DESPRES, Me.CANTIDAD, Me.PRECIOVTA, Me.TOTBAS, Me.TOTEXT})
        Me.TablaEstiloDetDocu.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloDetDocu.MappingName = ""
        Me.TablaEstiloDetDocu.ReadOnly = True
        '
        'ITEM
        '
        Me.ITEM.Format = ""
        Me.ITEM.FormatInfo = Nothing
        Me.ITEM.HeaderText = "Item"
        Me.ITEM.MappingName = ""
        Me.ITEM.Width = 50
        '
        'CODARTI
        '
        Me.CODARTI.Format = ""
        Me.CODARTI.FormatInfo = Nothing
        Me.CODARTI.MappingName = ""
        Me.CODARTI.Width = 0
        '
        'DSARTI
        '
        Me.DSARTI.Format = ""
        Me.DSARTI.FormatInfo = Nothing
        Me.DSARTI.HeaderText = "Artículo"
        Me.DSARTI.MappingName = ""
        Me.DSARTI.Width = 240
        '
        'CODPRES
        '
        Me.CODPRES.Format = ""
        Me.CODPRES.FormatInfo = Nothing
        Me.CODPRES.MappingName = ""
        Me.CODPRES.Width = 0
        '
        'DESPRES
        '
        Me.DESPRES.Format = ""
        Me.DESPRES.FormatInfo = Nothing
        Me.DESPRES.HeaderText = "Presentación"
        Me.DESPRES.MappingName = ""
        Me.DESPRES.Width = 240
        '
        'CANTIDAD
        '
        Me.CANTIDAD.Format = ""
        Me.CANTIDAD.FormatInfo = Nothing
        Me.CANTIDAD.HeaderText = "Cantidad"
        Me.CANTIDAD.MappingName = ""
        Me.CANTIDAD.Width = 75
        '
        'PRECIOVTA
        '
        Me.PRECIOVTA.Format = ""
        Me.PRECIOVTA.FormatInfo = Nothing
        Me.PRECIOVTA.HeaderText = "Precio"
        Me.PRECIOVTA.MappingName = ""
        Me.PRECIOVTA.Width = 75
        '
        'TOTBAS
        '
        Me.TOTBAS.Format = ""
        Me.TOTBAS.FormatInfo = Nothing
        Me.TOTBAS.HeaderText = "Total"
        Me.TOTBAS.MappingName = ""
        Me.TOTBAS.Width = 75
        '
        'TOTEXT
        '
        Me.TOTEXT.Format = ""
        Me.TOTEXT.FormatInfo = Nothing
        Me.TOTEXT.MappingName = ""
        Me.TOTEXT.Width = 0
        '
        'btnGenera
        '
        Me.btnGenera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenera.Location = New System.Drawing.Point(14, 32)
        Me.btnGenera.Name = "btnGenera"
        Me.btnGenera.Size = New System.Drawing.Size(82, 48)
        Me.btnGenera.TabIndex = 59
        Me.btnGenera.Text = "Generar Nuevo Documento"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(14, 208)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(82, 48)
        Me.btnSalir.TabIndex = 61
        Me.btnSalir.Text = "Salir"
        '
        'gArticulos
        '
        Me.gArticulos.Controls.Add(Me.TxtPrecio)
        Me.gArticulos.Controls.Add(Me.txtdescripcion)
        Me.gArticulos.Controls.Add(Me.txtCantidad)
        Me.gArticulos.Controls.Add(Me.Label6)
        Me.gArticulos.Controls.Add(Me.Label3)
        Me.gArticulos.Controls.Add(Me.cbPresentacion)
        Me.gArticulos.Controls.Add(Me.txtcodarticulo)
        Me.gArticulos.Controls.Add(Me.lbcliente)
        Me.gArticulos.Controls.Add(Me.BtnArticulos)
        Me.gArticulos.Controls.Add(Me.Label9)
        Me.gArticulos.Enabled = False
        Me.gArticulos.Location = New System.Drawing.Point(10, 138)
        Me.gArticulos.Name = "gArticulos"
        Me.gArticulos.Size = New System.Drawing.Size(630, 76)
        Me.gArticulos.TabIndex = 62
        Me.gArticulos.TabStop = False
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(478, 40)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(90, 20)
        Me.TxtPrecio.TabIndex = 18
        Me.TxtPrecio.Text = ""
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Location = New System.Drawing.Point(212, 14)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(402, 22)
        Me.txtdescripcion.TabIndex = 17
        Me.txtdescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(338, 40)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(72, 20)
        Me.txtCantidad.TabIndex = 8
        Me.txtCantidad.Text = ""
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(286, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Cantidad :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(422, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Precio :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPresentacion
        '
        Me.cbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPresentacion.Location = New System.Drawing.Point(80, 40)
        Me.cbPresentacion.Name = "cbPresentacion"
        Me.cbPresentacion.Size = New System.Drawing.Size(184, 21)
        Me.cbPresentacion.TabIndex = 4
        '
        'txtcodarticulo
        '
        Me.txtcodarticulo.Location = New System.Drawing.Point(82, 14)
        Me.txtcodarticulo.Name = "txtcodarticulo"
        Me.txtcodarticulo.Size = New System.Drawing.Size(92, 20)
        Me.txtcodarticulo.TabIndex = 2
        Me.txtcodarticulo.Text = ""
        '
        'lbcliente
        '
        Me.lbcliente.Location = New System.Drawing.Point(24, 16)
        Me.lbcliente.Name = "lbcliente"
        Me.lbcliente.Size = New System.Drawing.Size(56, 18)
        Me.lbcliente.TabIndex = 3
        Me.lbcliente.Text = "Artículo :"
        Me.lbcliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnArticulos
        '
        Me.BtnArticulos.ImageIndex = 5
        Me.BtnArticulos.ImageList = Me.ImageList1
        Me.BtnArticulos.Location = New System.Drawing.Point(176, 12)
        Me.BtnArticulos.Name = "BtnArticulos"
        Me.BtnArticulos.Size = New System.Drawing.Size(30, 24)
        Me.BtnArticulos.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Presentación :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CTRLSUBTOTAL
        '
        Me.CTRLSUBTOTAL.BackColor = System.Drawing.SystemColors.Control
        Me.CTRLSUBTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTRLSUBTOTAL.Location = New System.Drawing.Point(128, 398)
        Me.CTRLSUBTOTAL.Name = "CTRLSUBTOTAL"
        Me.CTRLSUBTOTAL.Size = New System.Drawing.Size(128, 30)
        Me.CTRLSUBTOTAL.TabIndex = 63
        Me.CTRLSUBTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblsubtotal
        '
        Me.lblsubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubtotal.Location = New System.Drawing.Point(10, 398)
        Me.lblsubtotal.Name = "lblsubtotal"
        Me.lblsubtotal.Size = New System.Drawing.Size(118, 28)
        Me.lblsubtotal.TabIndex = 64
        Me.lblsubtotal.Text = "SubTotal :"
        Me.lblsubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBLIGV
        '
        Me.LBLIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIGV.Location = New System.Drawing.Point(280, 400)
        Me.LBLIGV.Name = "LBLIGV"
        Me.LBLIGV.Size = New System.Drawing.Size(124, 28)
        Me.LBLIGV.TabIndex = 66
        Me.LBLIGV.Text = "IGV :"
        Me.LBLIGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CTRLIGV
        '
        Me.CTRLIGV.BackColor = System.Drawing.SystemColors.Control
        Me.CTRLIGV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CTRLIGV.Location = New System.Drawing.Point(404, 398)
        Me.CTRLIGV.Name = "CTRLIGV"
        Me.CTRLIGV.Size = New System.Drawing.Size(132, 30)
        Me.CTRLIGV.TabIndex = 65
        Me.CTRLIGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(556, 400)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 28)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Total :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbTOTAL
        '
        Me.lbTOTAL.BackColor = System.Drawing.SystemColors.Control
        Me.lbTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTOTAL.Location = New System.Drawing.Point(670, 398)
        Me.lbTOTAL.Name = "lbTOTAL"
        Me.lbTOTAL.Size = New System.Drawing.Size(132, 30)
        Me.lbTOTAL.TabIndex = 67
        Me.lbTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Location = New System.Drawing.Point(14, 90)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(82, 48)
        Me.BtnGuardar.TabIndex = 69
        Me.BtnGuardar.Text = "Guardar Documento "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(110, 118)
        Me.Panel3.TabIndex = 70
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnGenera)
        Me.GroupBox1.Controls.Add(Me.BtnQuitarDoc)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Location = New System.Drawing.Point(846, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 278)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        '
        'FrmEditarDocumento_enOrdenDespacho
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(962, 432)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lbTOTAL)
        Me.Controls.Add(Me.LBLIGV)
        Me.Controls.Add(Me.CTRLIGV)
        Me.Controls.Add(Me.lblsubtotal)
        Me.Controls.Add(Me.CTRLSUBTOTAL)
        Me.Controls.Add(Me.gArticulos)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEditarDocumento_enOrdenDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Documento de Venta"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gArticulos.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Public FrmActPEd As FrmActulizar_Orden_Despacho
    Public VarTipoDoc As String
    Public VarNumDocu As String
    Public TablaTempDetDocu As New DataTable
    'Public Obj As New ClsInterface
    'Dim Ayuda As New ClsAyuda
    'Dim ClsDa As New clsdatos_JHON
    'Dim ClsInter As New ClsInterface
    Public VarNumOrdenDespacho As String
    Public CODCLIENTE As String
    Public NRO_DESPACHO As String
    Public VarCodTipoPago As String
    Private TMP_VENTADET As New DataTable
    Public DEVOLVER As Boolean
    Private TMP_PRESENTACION As New DataTable
    Private ActEventCombo As Boolean



#End Region


#Region "Funciones Form"

    Sub elimina_item()
        Try
            Dim sql As String
            sql = "SP_DELETE_ITEM_TMPVENTADET " & VCorrelVta & "," & Grid1.Item(Grid1.CurrentRowIndex, 0) & "," & codempresa & "," & NROPTOVTA & ""
            TmpInsertDatos(sql)
            CargarGridFact()
            FormatoGridDetVta()
            LimpiarCjaTxtDet()
            txtcodarticulo.Focus()
        Catch ex As Exception
        End Try
    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        If ((MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM)) Then
            Select Case KeyData
                Case Keys.F3
                    If TMP_VENTADET.Rows.Count > 0 Then
                        If Grid1.Focus = True Then
                            elimina_item()
                        End If
                    End If

            End Select
        End If
    End Function
    Public Function GRABAEFECTIVOS(ByVal CODTIDOC As String, ByVal NRODOCUM As String, ByVal CODTIPOPAGO As String, ByVal fechadocum As Date, ByVal TOTBAS As Double, ByVal PORCENDESC As Double, ByVal CODIGOCLIE As String, ByVal DESCLIE As String, ByVal CLIERUC As String, ByVal DIRECC As String, ByVal CODDEP As String, ByVal NRODESPACHO As String) As Boolean

        Dim AFEC As Integer
        Try
            Dim cn2 As New SqlConnection(STRCN)
            If cn2.State = ConnectionState.Open Then
                cn2.Close()
            End If
            cn2.Open()
            Dim cmd2 As New SqlCommand("Nsp_grabadocumento", cn2)
            cmd2.CommandType = CommandType.StoredProcedure
            cmd2.Parameters("@NRODEGUIAS").Value = CStr(NRODESPACHO)
            cmd2.Parameters("@NPESADA").Value = CStr("")
            cmd2.Parameters("@Eigv").Value = CStr("True")
            cmd2.Parameters("@actualizocorrelativo").Value = CStr("False")
            cmd2.Parameters("@NUMEROTRANS").Value = CInt(0)
            cmd2.Parameters("@CODDEP").Value = CStr(CODDEP)
            cmd2.Parameters("@CODTIPOPAGO").Value = CODTIPOPAGO.Trim
            cmd2.Parameters("@CODTIPODOC").Value = CStr(CODTIDOC)
            cmd2.Parameters("@NRODOCU").Value = CStr(NRODOCUM)
            cmd2.Parameters("@codmon").Value = CStr(CDMONBASE)
            cmd2.Parameters("@CAMBIO").Value = CDec(VCambioVta)
            cmd2.Parameters("@codvend").Value = CStr(CodUsuario)
            cmd2.Parameters("@FECDOCUM").Value = CDate(fechadocum)
            cmd2.Parameters("@TOTBAS").Value = CDec(TOTBAS)
            cmd2.Parameters("@PORCENDESC1").Value = CDec(PORCENDESC)
            cmd2.Parameters("@TOTVUELTOBAS").Value = CDec(0)
            cmd2.Parameters("@TOTCASHBAS").Value = CDec(0)
            cmd2.Parameters("@TOTCASHEXT").Value = CDec(0)
            cmd2.Parameters("@codcliente").Value = CStr(CODIGOCLIE)
            cmd2.Parameters("@RUCCLIENTE").Value = CStr(CLIERUC)
            cmd2.Parameters("@DESCLIENTE").Value = CStr(DESCLIE)
            cmd2.Parameters("@DIRCLIENTE").Value = CStr(DIRECC)
            cmd2.Parameters("@CodUsuario").Value = CStr(CodUsuario)
            cmd2.Parameters("@CODEMPRESA").Value = CStr(codempresa)
            cmd2.Parameters("@MONEDABASE").Value = CStr(CDMONBASE)
            cmd2.Parameters("@NROPTOVTA").Value = CStr(NROPTOVTA)
            cmd2.Parameters("@CORRELATIVO").Value = CInt(VCorrelVta)
           

            Try
                AFEC = cmd2.ExecuteNonQuery()
                ''MsgBox("se grabo ...")
                cn2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'IMPRIMEDOCUMENTO(VNroDoc) 'IMPRIME DOCUMENTO
        'insert_store("SP_REGISTRA_AUDITORIA '" & txtnroguias.Text & "','INSERT','FACTURACION','" & Format(System.DateTime.Now, "MM/dd/yyyy") & "','" & CodUsuario & "','" & codempresa & "'")
        'Dim obj As New ClsInterface        Try
        'obj.gGrabarReg("INSERT_CLI_POST_VTA", codempresa, VarTipoDoc.Trim, TXTNUMERODOC.Text.Trim)
   
    End Function



    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress, TxtPrecio.KeyPress
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

    Private Sub ConfigDocumento()
        Dim Doc() As String
        Doc = CStr(Format(VNroDoc, "0##-#######")).Split("-")
        TXTSERIEDOC.Text = Doc.GetValue(0)
        TXTNUMERODOC.Text = Doc.GetValue(1)
        If VCdTipoDoc = CDBOLETA Then
            lbltipodoc.Text = "BOLETA"
            CTRLIGV.Visible = False
            CTRLSUBTOTAL.Visible = False
            lblsubtotal.Visible = False
            LBLIGV.Visible = False
            VItemDoc = ITEMDEBOLETA

        ElseIf VCdTipoDoc = CDFACTURA Then
            lbltipodoc.Text = "FACTURA"
            CTRLIGV.Visible = True
            CTRLSUBTOTAL.Visible = True
            lblsubtotal.Visible = True
            LBLIGV.Visible = True
            VItemDoc = ITEMDEFACT

        ElseIf VCdTipoDoc = CDNTAPEDIDO Then
            lbltipodoc.Text = "NOTA DE PEDIDO"
            CTRLIGV.Visible = False
            CTRLSUBTOTAL.Visible = False
            lblsubtotal.Visible = False
            LBLIGV.Visible = False
            VItemDoc = ITEMDENTAPEDIDO
        End If
    End Sub

    Private Sub LimpiarCjaTxtDet()
        txtcodarticulo.Text = ""
        txtdescripcion.Text = ""
        txtCantidad.Text = "0"
        TxtPrecio.Text = "0"

    End Sub
    Private Sub INSERT_TMP_DETALLE()
        Dim Item As Integer = TMP_VENTADET.Rows.Count + 1
        If VItemDoc < Item Then
            MsgBox("EL NUMERO DE FILAS ESCEDE AL NUMERO ESTABLECIDO EN  CONFIG..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        CAyuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADET", codempresa, Item, txtcodarticulo.Text, vcdAlmacen, cbPresentacion.SelectedValue, cbPresentacion.Text, txtCantidad.Text, VPrecioVta, VDescTotbas, CodUsuario, NROPTOVTA, VCorrelVta, "")
    End Sub

    Private Sub FormatoGridDetVta()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_VENTADET.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "ITEM"
            .HeaderText = "ITEM"
            .NullText = ""
            .Width = 35
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CODIGO"
            .HeaderText = "CODIGO"
            .NullText = ""
            .Width = 75
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DESCRIPCION"
            .HeaderText = "DESCRIPCION"
            .NullText = ""
            .Width = 250
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "DESPRES"
            .HeaderText = "PRESENTACION"
            .NullText = ""
            .Width = 120
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "CANTIDAD"
            .HeaderText = "CANTIDAD"
            .NullText = ""
            .Format = GMascaraDec(DECICANT)
            .Width = 60
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "PRECIO"
            .HeaderText = "PRECIO"
            .NullText = ""
            .Format = GMascaraDec(DECIPREC)
            .Width = 60
        End With

        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "TOTAL"
            .HeaderText = "TOTAL"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Width = 60
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "DESCTO"
            .HeaderText = "DESCTO"
            .NullText = ""
            .Format = GMascaraDec(DECIRESU)
            .Width = 60
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        Grid1.TableStyles.Clear()
        Grid1.TableStyles.Add(TableStyle1)

    End Sub
    Private Sub CargarGridFact()
        TMP_VENTADET = TmpListarDatos("sp_sele_TMP_VENTADET  '" & VCorrelVta & "','" & codempresa & "'")
        Grid1.DataSource = TMP_VENTADET
        If TMP_VENTADET.Rows.Count > 0 Then
            Dim TABLE_VTA As New DataTable
            TABLE_VTA = TmpListarDatos("OBTIENE_TOTALES_FACTURACION_PROC  '" & codempresa & "','" & VCorrelVta & "'")
            lbTOTAL.Text = TABLE_VTA.Rows(0)("TOTBAS")
            CTRLSUBTOTAL.Text = TABLE_VTA.Rows(0)("SUBTOTBAS")
            CTRLIGV.Text = TABLE_VTA.Rows(0)("IGVBAS")
        End If

    End Sub

#End Region

    Private Sub FrmEditarDocumento_enOrdenDespacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conecta("SELECT  * FROM TIPO_PAGO  WHERE CODEMPRESA='" & codempresa & "'  AND CODTIPOPAGO='" & VCdPagEfectivo & "' OR CODTIPOPAGO='" & VCdPagCredito & "'", "TABL")
        Me.cbTipoPAgo.DataSource = ds.Tables("TABL")
        Me.cbTipoPAgo.ValueMember = "CODTIPOPAGO"
        Me.cbTipoPAgo.DisplayMember = "DSTIPOPAGO"

        Dim TABLE_DOC As New DataTable
        TABLE_DOC = CAyuda.ListarDatos("SP_CARGAR_DOCUMENTOFACT", codempresa, VCdTipoDoc, VNroDoc, VCorrelVta, Format(Date.Now, "dd/MM/yyyy")).Tables(0)
        If TABLE_DOC.Rows.Count = 0 Then
            Exit Sub
        End If
        txtcodclie.Text = TABLE_DOC.Rows(0)("CODCLIENTE")
        Txtruc.Text = TABLE_DOC.Rows(0)("RUCCLIENTE")
        Txtcliente.Text = TABLE_DOC.Rows(0)("DESCLIENTE")
        txtDireccion.Text = TABLE_DOC.Rows(0)("DIRCLIENTE")
        DtFechaDoc.Value = TABLE_DOC.Rows(0)("FECDOCUM")
        VCodDep = TABLE_DOC.Rows(0)("CODDEP")
        cbTipoPAgo.SelectedValue = TABLE_DOC.Rows(0)("CODTIPOPAGO")
        ConfigDocumento()
        CargarGridFact()
        FormatoGridDetVta()

      

    End Sub
    Private Sub ListarItems()
        TablaTempDetDocu = CAyuda.ListarDatos("NSP_TRAER_DET_DOC_VENTA", codempresa, VarTipoDoc, VarNumDocu.Trim).Tables(0)
        TablaEstiloDetDocu.MappingName = TablaTempDetDocu.TableName
        TablaEstiloDetDocu.GridColumnStyles(0).MappingName = "ITEM"
        TablaEstiloDetDocu.GridColumnStyles(1).MappingName = "CODARTI"
        TablaEstiloDetDocu.GridColumnStyles(2).MappingName = "DESARTI"
        TablaEstiloDetDocu.GridColumnStyles(3).MappingName = "CODPRES"
        TablaEstiloDetDocu.GridColumnStyles(4).MappingName = "DESPRES"
        TablaEstiloDetDocu.GridColumnStyles(5).MappingName = "CANTIDAD"
        TablaEstiloDetDocu.GridColumnStyles(6).MappingName = "PRECIOVTA"
        TablaEstiloDetDocu.GridColumnStyles(7).MappingName = "TOTBAS"
        TablaEstiloDetDocu.GridColumnStyles(8).MappingName = "TOTEXT"
        'Me.dgListaDocumentos.TableStyles.Add(TablaEstiloDetDocu)
        'dgListaDocumentos.DataSource = TablaTempDetDocu
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnQuitarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarDoc.Click
        Dim SQL, TABLACAB, TABLADET As String
        Dim VarNroGuia As String = ""
        TABLACAB = "VENTACAB"
        TABLADET = "VENTADET"

        Dim FrmAnul As New FrmMotivoAnula
        FrmAnul.ShowDialog()

        CAyuda.Ejecutar("SP_ANULAR_DOCFACT_OD", codempresa, VCdTipoDoc, VNroDoc)
        SQL = "USP_ANULAR_DOCUMENTO '" & TABLACAB & "','" & TABLADET & "','" & VNroDoc & "','" & NROPTOVTA & "','" & codempresa & "','" & VCdTipoDoc & "','" & Val(VarNroGuia.Trim) & "','" & VCdTipoAnula & "','" & VObserv & "'"
        If TmpInsertDatos(SQL) = True Then
            MsgBox("El Documento Actual Fue Anulado Correctamente" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
            DEVOLVER = True
            Me.Close()
        Else
            MsgBox("Error Al Anular El Documento Actual Consulte Por Favor" + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
            Exit Sub
        End If
    End Sub

    Private Sub btnGenera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenera.Click
        GenerarNroDoc()
        ConfigDocumento()
        TmpInsertDatos("UPDATE  TMP_VENTADET  SET FECDOCUM='" & Format(Date.Now, "dd/MM/yyyy") & "', FECPROCESO='" & Format(Date.Now, "dd/MM/yyyy") & "'  WHERE  CODEMPRESA='" & codempresa & "' AND  CORRNBR='" & VCorrelVta & "' ")
        gArticulos.Enabled = True
        BtnGuardar.Enabled = True
        btnGenera.Enabled = False
        BtnQuitarDoc.Enabled = False

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArticulos.Click
        Dim FrmArt As New FrmListarArticuloFact
        FrmArt.ShowDialog()
        If FrmArt.DEVOLVER = False Then
            Exit Sub
        End If

        txtcodarticulo.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 0)
        txtdescripcion.Text = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 1)
        VcdAlmacen = FrmArt.GridArt.Item(FrmArt.GridArt.CurrentRowIndex, 2)
        TMP_PRESENTACION = TmpListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT  '" & codempresa & "','" & txtcodarticulo.Text & "','" & CDTIPOPRE1 & "'")
        cbPresentacion.DataSource = TMP_PRESENTACION
        cbPresentacion.ValueMember = "CODPRES"
        cbPresentacion.DisplayMember = "DESPRES"
        ActEventCombo = True
        cbPresentacion_SelectedIndexChanged(sender, e)
        cbPresentacion.Focus()

    End Sub






    Public Function TraeDsctoMonto(ByVal VarCodigo As String, ByVal VarDsctoVenta As Double) As Double
        '' EN LA TABLA TIPO_DSCTO_FINANCIERO
        Conecta("SELECT CODSUBLINEA FROM ARTICULO WHERE CODARTI ='" & VarCodigo.Trim & "' AND CODEMPRESA='" & codempresa & "'", "TAB1")
        Dim VarSubLinea As String
        VarSubLinea = ds.Tables("TAB1").Rows(0)(0).ToString.Trim
        Dim TablaDatosDsctos As New DataTable
        TablaDatosDsctos = CAyuda.ListarDatos("NSP_TRAER_DSCTO_MONTO", codempresa.Trim, VarSubLinea.Trim, VarDsctoVenta).Tables(0)
        If TablaDatosDsctos.Rows.Count > 0 Then
            TraeDsctoMonto = (VarDsctoVenta * CDbl(TablaDatosDsctos.Rows(0)("MONTOPORC"))) / 100
        Else
            TraeDsctoMonto = 0
        End If
    End Function
    Public Function TraerDsctoCondVenta(ByVal VarCodigo As String, ByVal VarVenta As Double) As Double
        Conecta("SELECT CODSUBLINEA, SOLOEFECTIVO FROM ARTICULO WHERE CODARTI ='" & VarCodigo.Trim & "' AND CODEMPRESA='" & codempresa & "'", "TAB1")
        Dim VarSubLinea As String
        VarSubLinea = ds.Tables("TAB1").Rows(0)(0).ToString.Trim
        Dim TablaDatosDsctos As New DataTable
        TablaDatosDsctos = CAyuda.ListarDatos("NSP_TRAER_DSCTO_COND_PAGO", codempresa.Trim, VarSubLinea.Trim).Tables(0)
        If TablaDatosDsctos.Rows.Count > 0 Then
            If Now.ToShortDateString > CDate(TablaDatosDsctos.Rows(0)("FECHA_INI")).ToShortDateString And Now.ToShortDateString < CDate(TablaDatosDsctos.Rows(0)("FECHA_FIN")).ToShortDateString Then
                If CBool(ds.Tables("TAB1").Rows(0)(1)) Then
                    TraerDsctoCondVenta = (VarVenta * CDbl(TablaDatosDsctos.Rows(0)("MONTO_EFECTIVO"))) / 100
                Else
                    If Me.cbTipoPAgo.SelectedValue.ToString.Trim = "01" Then
                        TraerDsctoCondVenta = (VarVenta * CDbl(TablaDatosDsctos.Rows(0)("MONTO_EFECTIVO"))) / 100
                    ElseIf Me.cbTipoPAgo.SelectedValue.ToString.Trim = "06" Then
                        TraerDsctoCondVenta = (VarVenta * CDbl(TablaDatosDsctos.Rows(0)("MONTO_CREDITO"))) / 100
                    End If
                End If
            Else
                TraerDsctoCondVenta = 0
            End If
        Else
            TraerDsctoCondVenta = 0
        End If
    End Function



    Private Sub txtCantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPrecio.Focus()

        End If
    End Sub

    Private Sub TxtPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPrecio.TextChanged

    End Sub

    Private Sub TxtPrecio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPrecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            INSERT_TMP_DETALLE()
            CargarGridFact()
            FormatoGridDetVta()
            LimpiarCjaTxtDet()
            txtcodarticulo.Focus()
        End If
    End Sub


    Private Sub cbPresentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPresentacion.SelectedIndexChanged
        If TMP_PRESENTACION.Rows.Count > 0 And ActEventCombo = True Then
            Dim TBPREC As New DataTable
            TBPREC = TmpListarDatos("SP_BUSC_PRECIOARTFACT   '" & codempresa & "','" & cbPresentacion.SelectedValue & "','" & CDTIPOPRE1 & "','" & txtcodarticulo.Text & "','" & txtcodclie.Text & "'")
            VPrecio = TBPREC.Rows(0)("PRECIO")
            VPrecioVta = TBPREC.Rows(0)("PRECIOVTA")
            TxtPrecio.Text = FormatoMonto(VPrecioVta, DECIRESU)
        End If

    End Sub

    Private Sub Txtruc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtruc.TextChanged
        If Txtruc.Text.Trim.Length = 11 Then
            VRuc = Txtruc.Text.Trim
            ConfigDocumento()
        End If
    End Sub

    Private Sub cbPresentacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPresentacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCantidad.Focus()

        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        CAyuda.Ejecutar("SP_INS_GUIAINTDETdeTMP_VTADET", codempresa, VCdTipoDoc, VNroDoc, txtcodclie.Text, Txtcliente.Text, Txtruc.Text, txtDireccion.Text, VPtoLLegada, VCodRuta, CodUsuario, cbTipoPAgo.SelectedValue, VCodTiPrecioClie, VCodDep, 0, VCorrelVta, VNroDespacho, NROPTOVTA)
        GRABAEFECTIVOS(VCdTipoDoc, VNroDoc, cbTipoPAgo.SelectedValue, DtFechaDoc.Value, lbTOTAL.Text, VPorcenDesc, txtcodclie.Text, Txtcliente.Text, Txtruc.Text, txtDireccion.Text, VCodDep, VNroDespacho)
        DEVOLVER = True
        Me.Close()
    End Sub
    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub
End Class
