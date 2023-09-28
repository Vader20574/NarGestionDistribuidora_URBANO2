Imports System.Data.Odbc
Imports CapaNegocio
Imports Common.Services
Imports Servicios.Implementacion

Public Class FrmActOrdenDespacho
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnConsultar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardaUno As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGuardaTodos As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnAgregarDoc As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarDoc As System.Windows.Forms.Button
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblTotalNroDoc As System.Windows.Forms.Label
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents GrpOD As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAgreOD As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarOD As System.Windows.Forms.Button
    Friend WithEvents BtnBuscOD As System.Windows.Forms.Button
    Friend WithEvents TxtOD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgCabeceraOrden As System.Windows.Forms.DataGrid
    Friend WithEvents TablaEstiloCabecera As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ORDEN_DESPACHO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtTotalOD As System.Windows.Forms.TextBox
    Friend WithEvents GridDespacho As System.Windows.Forms.DataGrid
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PnlOD As System.Windows.Forms.Panel
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtAyu As System.Windows.Forms.TextBox
    Friend WithEvents TxtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents TxtHoraDesp As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecDesp As System.Windows.Forms.TextBox
    Friend WithEvents TxtVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOrderDesp As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActOrdenDespacho))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.BtnGuardaUno = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardaTodos = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAgregarDoc = New System.Windows.Forms.Button()
        Me.BtnQuitarDoc = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblTotalNroDoc = New System.Windows.Forms.Label()
        Me.GrpOD = New System.Windows.Forms.GroupBox()
        Me.BtnAgreOD = New System.Windows.Forms.Button()
        Me.BtnQuitarOD = New System.Windows.Forms.Button()
        Me.BtnBuscOD = New System.Windows.Forms.Button()
        Me.TxtOD = New System.Windows.Forms.TextBox()
        Me.dgCabeceraOrden = New System.Windows.Forms.DataGrid()
        Me.TablaEstiloCabecera = New System.Windows.Forms.DataGridTableStyle()
        Me.ORDEN_DESPACHO = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTotalOD = New System.Windows.Forms.TextBox()
        Me.GridDespacho = New System.Windows.Forms.DataGrid()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlOD = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAyu = New System.Windows.Forms.TextBox()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.TxtHoraDesp = New System.Windows.Forms.TextBox()
        Me.TxtFecDesp = New System.Windows.Forms.TextBox()
        Me.TxtVehiculo = New System.Windows.Forms.TextBox()
        Me.TxtDestino = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrderDesp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNREPORTE = New System.Windows.Forms.Button()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpOD.SuspendLayout()
        CType(Me.dgCabeceraOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDespacho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOD.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnConsultar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardaUno)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.BtnGuardaTodos)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnAgregarDoc)
        Me.GroupBox1.Controls.Add(Me.BtnQuitarDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(906, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 311)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 4
        Me.Button1.ImageList = Me.ImageList2
        Me.Button1.Location = New System.Drawing.Point(6, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 25)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Restablecer"
        Me.Button1.Visible = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        Me.ImageList2.Images.SetKeyName(3, "")
        Me.ImageList2.Images.SetKeyName(4, "")
        Me.ImageList2.Images.SetKeyName(5, "")
        Me.ImageList2.Images.SetKeyName(6, "")
        Me.ImageList2.Images.SetKeyName(7, "")
        Me.ImageList2.Images.SetKeyName(8, "")
        Me.ImageList2.Images.SetKeyName(9, "")
        Me.ImageList2.Images.SetKeyName(10, "")
        Me.ImageList2.Images.SetKeyName(11, "")
        Me.ImageList2.Images.SetKeyName(12, "")
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConsultar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConsultar.ImageIndex = 5
        Me.BtnConsultar.ImageList = Me.ImageList2
        Me.BtnConsultar.Location = New System.Drawing.Point(13, 158)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(97, 25)
        Me.BtnConsultar.TabIndex = 3
        Me.BtnConsultar.Text = "   &Consultar"
        '
        'BtnGuardaUno
        '
        Me.BtnGuardaUno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardaUno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardaUno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardaUno.ImageIndex = 1
        Me.BtnGuardaUno.ImageList = Me.ImageList2
        Me.BtnGuardaUno.Location = New System.Drawing.Point(13, 99)
        Me.BtnGuardaUno.Name = "BtnGuardaUno"
        Me.BtnGuardaUno.Size = New System.Drawing.Size(97, 58)
        Me.BtnGuardaUno.TabIndex = 2
        Me.BtnGuardaUno.Text = "  &Actualizar        _   la  OD seleccionada"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.ImageIndex = 0
        Me.BtnNuevo.ImageList = Me.ImageList2
        Me.BtnNuevo.Location = New System.Drawing.Point(12, 14)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(97, 25)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo"
        '
        'BtnGuardaTodos
        '
        Me.BtnGuardaTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardaTodos.Enabled = False
        Me.BtnGuardaTodos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardaTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardaTodos.ImageIndex = 1
        Me.BtnGuardaTodos.ImageList = Me.ImageList2
        Me.BtnGuardaTodos.Location = New System.Drawing.Point(12, 40)
        Me.BtnGuardaTodos.Name = "BtnGuardaTodos"
        Me.BtnGuardaTodos.Size = New System.Drawing.Size(97, 58)
        Me.BtnGuardaTodos.TabIndex = 1
        Me.BtnGuardaTodos.Text = "  &Actualizar        _   de  Todas las  OD"
        '
        'btnmodificar
        '
        Me.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodificar.Enabled = False
        Me.btnmodificar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.ImageIndex = 2
        Me.btnmodificar.ImageList = Me.ImageList2
        Me.btnmodificar.Location = New System.Drawing.Point(148, 184)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(97, 25)
        Me.btnmodificar.TabIndex = 5
        Me.btnmodificar.Text = "   &Modificar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList2
        Me.BtnCancelar.Location = New System.Drawing.Point(14, 219)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(97, 25)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "  &Cancelar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.ImageIndex = 4
        Me.BtnSalir.ImageList = Me.ImageList2
        Me.BtnSalir.Location = New System.Drawing.Point(14, 245)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(97, 25)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "&Salir"
        '
        'BtnAgregarDoc
        '
        Me.BtnAgregarDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregarDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarDoc.ImageIndex = 12
        Me.BtnAgregarDoc.ImageList = Me.ImageList2
        Me.BtnAgregarDoc.Location = New System.Drawing.Point(148, 210)
        Me.BtnAgregarDoc.Name = "BtnAgregarDoc"
        Me.BtnAgregarDoc.Size = New System.Drawing.Size(97, 34)
        Me.BtnAgregarDoc.TabIndex = 7
        Me.BtnAgregarDoc.Text = "      &Agregar _     _     Documento"
        '
        'BtnQuitarDoc
        '
        Me.BtnQuitarDoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuitarDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitarDoc.ImageIndex = 12
        Me.BtnQuitarDoc.ImageList = Me.ImageList2
        Me.BtnQuitarDoc.Location = New System.Drawing.Point(14, 184)
        Me.BtnQuitarDoc.Name = "BtnQuitarDoc"
        Me.BtnQuitarDoc.Size = New System.Drawing.Size(97, 34)
        Me.BtnQuitarDoc.TabIndex = 4
        Me.BtnQuitarDoc.Text = "     &Anular     _       _     Documento"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 114)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'LblTotalNroDoc
        '
        Me.LblTotalNroDoc.AutoSize = True
        Me.LblTotalNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalNroDoc.Location = New System.Drawing.Point(650, 384)
        Me.LblTotalNroDoc.Name = "LblTotalNroDoc"
        Me.LblTotalNroDoc.Size = New System.Drawing.Size(147, 13)
        Me.LblTotalNroDoc.TabIndex = 7
        Me.LblTotalNroDoc.Text = "Total de Documentos : 0"
        '
        'GrpOD
        '
        Me.GrpOD.Controls.Add(Me.BtnAgreOD)
        Me.GrpOD.Controls.Add(Me.BtnQuitarOD)
        Me.GrpOD.Controls.Add(Me.BtnBuscOD)
        Me.GrpOD.Controls.Add(Me.TxtOD)
        Me.GrpOD.Controls.Add(Me.dgCabeceraOrden)
        Me.GrpOD.Controls.Add(Me.Label4)
        Me.GrpOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpOD.Location = New System.Drawing.Point(12, 332)
        Me.GrpOD.Name = "GrpOD"
        Me.GrpOD.Size = New System.Drawing.Size(592, 138)
        Me.GrpOD.TabIndex = 4
        Me.GrpOD.TabStop = False
        Me.GrpOD.Text = "Orden De Despacho"
        '
        'BtnAgreOD
        '
        Me.BtnAgreOD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgreOD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgreOD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgreOD.ImageIndex = 12
        Me.BtnAgreOD.ImageList = Me.ImageList2
        Me.BtnAgreOD.Location = New System.Drawing.Point(274, 58)
        Me.BtnAgreOD.Name = "BtnAgreOD"
        Me.BtnAgreOD.Size = New System.Drawing.Size(97, 34)
        Me.BtnAgreOD.TabIndex = 4
        Me.BtnAgreOD.Text = "      &Agregar _     _     Orden Desp"
        '
        'BtnQuitarOD
        '
        Me.BtnQuitarOD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuitarOD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarOD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitarOD.ImageIndex = 12
        Me.BtnQuitarOD.ImageList = Me.ImageList2
        Me.BtnQuitarOD.Location = New System.Drawing.Point(402, 58)
        Me.BtnQuitarOD.Name = "BtnQuitarOD"
        Me.BtnQuitarOD.Size = New System.Drawing.Size(97, 34)
        Me.BtnQuitarOD.TabIndex = 5
        Me.BtnQuitarOD.Text = "     &Quitar     _       _    Orden Desp"
        '
        'BtnBuscOD
        '
        Me.BtnBuscOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscOD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscOD.ImageIndex = 5
        Me.BtnBuscOD.ImageList = Me.ImageList1
        Me.BtnBuscOD.Location = New System.Drawing.Point(510, 20)
        Me.BtnBuscOD.Name = "BtnBuscOD"
        Me.BtnBuscOD.Size = New System.Drawing.Size(78, 26)
        Me.BtnBuscOD.TabIndex = 3
        Me.BtnBuscOD.Text = "[Buscar]"
        Me.BtnBuscOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtOD
        '
        Me.TxtOD.Enabled = False
        Me.TxtOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOD.Location = New System.Drawing.Point(408, 22)
        Me.TxtOD.Name = "TxtOD"
        Me.TxtOD.Size = New System.Drawing.Size(100, 22)
        Me.TxtOD.TabIndex = 1
        '
        'dgCabeceraOrden
        '
        Me.dgCabeceraOrden.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.dgCabeceraOrden.BackColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.BackgroundColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.CaptionBackColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.CaptionFont = New System.Drawing.Font("Verdana", 10.0!)
        Me.dgCabeceraOrden.CaptionForeColor = System.Drawing.Color.Navy
        Me.dgCabeceraOrden.CaptionText = "Ordenes de Despacho"
        Me.dgCabeceraOrden.DataMember = ""
        Me.dgCabeceraOrden.ForeColor = System.Drawing.Color.Black
        Me.dgCabeceraOrden.GridLineColor = System.Drawing.Color.Black
        Me.dgCabeceraOrden.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgCabeceraOrden.HeaderBackColor = System.Drawing.Color.Silver
        Me.dgCabeceraOrden.HeaderForeColor = System.Drawing.Color.Black
        Me.dgCabeceraOrden.LinkColor = System.Drawing.Color.Navy
        Me.dgCabeceraOrden.Location = New System.Drawing.Point(8, 20)
        Me.dgCabeceraOrden.Name = "dgCabeceraOrden"
        Me.dgCabeceraOrden.ParentRowsBackColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCabeceraOrden.ReadOnly = True
        Me.dgCabeceraOrden.SelectionBackColor = System.Drawing.Color.Navy
        Me.dgCabeceraOrden.SelectionForeColor = System.Drawing.Color.White
        Me.dgCabeceraOrden.Size = New System.Drawing.Size(254, 110)
        Me.dgCabeceraOrden.TabIndex = 0
        Me.dgCabeceraOrden.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloCabecera})
        '
        'TablaEstiloCabecera
        '
        Me.TablaEstiloCabecera.DataGrid = Me.dgCabeceraOrden
        Me.TablaEstiloCabecera.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ORDEN_DESPACHO, Me.FECHA})
        Me.TablaEstiloCabecera.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloCabecera.ReadOnly = True
        '
        'ORDEN_DESPACHO
        '
        Me.ORDEN_DESPACHO.Format = ""
        Me.ORDEN_DESPACHO.FormatInfo = Nothing
        Me.ORDEN_DESPACHO.HeaderText = "Orden Despacho"
        Me.ORDEN_DESPACHO.Width = 120
        '
        'FECHA
        '
        Me.FECHA.Format = "dd/MM/yyyy"
        Me.FECHA.FormatInfo = Nothing
        Me.FECHA.HeaderText = "Fecha"
        Me.FECHA.Width = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "#OrdenDe Despacho : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTotalOD
        '
        Me.TxtTotalOD.BackColor = System.Drawing.Color.White
        Me.TxtTotalOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalOD.Location = New System.Drawing.Point(672, 338)
        Me.TxtTotalOD.Name = "TxtTotalOD"
        Me.TxtTotalOD.ReadOnly = True
        Me.TxtTotalOD.Size = New System.Drawing.Size(122, 26)
        Me.TxtTotalOD.TabIndex = 6
        Me.TxtTotalOD.Text = "0.00"
        Me.TxtTotalOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GridDespacho
        '
        Me.GridDespacho.CaptionText = "                                       ==============[Doble Click]  ó  [ENTER] --" &
    ">Para   Anular =============="
        Me.GridDespacho.DataMember = ""
        Me.GridDespacho.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridDespacho.Location = New System.Drawing.Point(14, 134)
        Me.GridDespacho.Name = "GridDespacho"
        Me.GridDespacho.ReadOnly = True
        Me.GridDespacho.Size = New System.Drawing.Size(870, 194)
        Me.GridDespacho.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(652, 408)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Total de Clientes : 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total :"
        '
        'PnlOD
        '
        Me.PnlOD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlOD.Controls.Add(Me.BtnBuscar)
        Me.PnlOD.Controls.Add(Me.txtRuta)
        Me.PnlOD.Controls.Add(Me.Label6)
        Me.PnlOD.Controls.Add(Me.TxtAyu)
        Me.PnlOD.Controls.Add(Me.TxtResponsable)
        Me.PnlOD.Controls.Add(Me.TxtHoraDesp)
        Me.PnlOD.Controls.Add(Me.TxtFecDesp)
        Me.PnlOD.Controls.Add(Me.TxtVehiculo)
        Me.PnlOD.Controls.Add(Me.TxtDestino)
        Me.PnlOD.Controls.Add(Me.Label13)
        Me.PnlOD.Controls.Add(Me.Label12)
        Me.PnlOD.Controls.Add(Me.Label8)
        Me.PnlOD.Controls.Add(Me.Label5)
        Me.PnlOD.Controls.Add(Me.Label10)
        Me.PnlOD.Controls.Add(Me.Label3)
        Me.PnlOD.Controls.Add(Me.txtOrderDesp)
        Me.PnlOD.Controls.Add(Me.Label1)
        Me.PnlOD.Location = New System.Drawing.Point(122, 12)
        Me.PnlOD.Name = "PnlOD"
        Me.PnlOD.Size = New System.Drawing.Size(762, 116)
        Me.PnlOD.TabIndex = 1
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.ImageIndex = 5
        Me.BtnBuscar.ImageList = Me.ImageList1
        Me.BtnBuscar.Location = New System.Drawing.Point(252, 6)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(78, 26)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "[Buscar]"
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBuscar.Visible = False
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.Color.White
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(56, 84)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(246, 20)
        Me.txtRuta.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ruta: "
        '
        'TxtAyu
        '
        Me.TxtAyu.BackColor = System.Drawing.Color.White
        Me.TxtAyu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAyu.Location = New System.Drawing.Point(372, 84)
        Me.TxtAyu.Name = "TxtAyu"
        Me.TxtAyu.Size = New System.Drawing.Size(220, 20)
        Me.TxtAyu.TabIndex = 15
        '
        'TxtResponsable
        '
        Me.TxtResponsable.BackColor = System.Drawing.Color.White
        Me.TxtResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResponsable.Location = New System.Drawing.Point(372, 62)
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.Size = New System.Drawing.Size(220, 20)
        Me.TxtResponsable.TabIndex = 11
        '
        'TxtHoraDesp
        '
        Me.TxtHoraDesp.BackColor = System.Drawing.Color.White
        Me.TxtHoraDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraDesp.Location = New System.Drawing.Point(520, 38)
        Me.TxtHoraDesp.Name = "TxtHoraDesp"
        Me.TxtHoraDesp.ReadOnly = True
        Me.TxtHoraDesp.Size = New System.Drawing.Size(72, 20)
        Me.TxtHoraDesp.TabIndex = 7
        '
        'TxtFecDesp
        '
        Me.TxtFecDesp.BackColor = System.Drawing.Color.White
        Me.TxtFecDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecDesp.Location = New System.Drawing.Point(372, 38)
        Me.TxtFecDesp.Name = "TxtFecDesp"
        Me.TxtFecDesp.ReadOnly = True
        Me.TxtFecDesp.Size = New System.Drawing.Size(72, 20)
        Me.TxtFecDesp.TabIndex = 5
        '
        'TxtVehiculo
        '
        Me.TxtVehiculo.BackColor = System.Drawing.Color.White
        Me.TxtVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVehiculo.Location = New System.Drawing.Point(56, 62)
        Me.TxtVehiculo.Name = "TxtVehiculo"
        Me.TxtVehiculo.ReadOnly = True
        Me.TxtVehiculo.Size = New System.Drawing.Size(198, 20)
        Me.TxtVehiculo.TabIndex = 10
        '
        'TxtDestino
        '
        Me.TxtDestino.BackColor = System.Drawing.Color.White
        Me.TxtDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDestino.Location = New System.Drawing.Point(56, 38)
        Me.TxtDestino.Name = "TxtDestino"
        Me.TxtDestino.ReadOnly = True
        Me.TxtDestino.Size = New System.Drawing.Size(198, 20)
        Me.TxtDestino.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(314, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Ayudante : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(296, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Responsable :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Vehiculo :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Destino :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(456, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Hora Salida: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Despacho : "
        '
        'txtOrderDesp
        '
        Me.txtOrderDesp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderDesp.Location = New System.Drawing.Point(150, 8)
        Me.txtOrderDesp.Name = "txtOrderDesp"
        Me.txtOrderDesp.Size = New System.Drawing.Size(100, 22)
        Me.txtOrderDesp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "#OrdenDe Despacho : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 11
        Me.BTNREPORTE.ImageList = Me.ImageList2
        Me.BTNREPORTE.Location = New System.Drawing.Point(822, 404)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(97, 25)
        Me.BTNREPORTE.TabIndex = 9
        Me.BTNREPORTE.Text = "  &Reporte"
        Me.BTNREPORTE.Visible = False
        '
        'BtnAnular
        '
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.ImageIndex = 3
        Me.BtnAnular.ImageList = Me.ImageList2
        Me.BtnAnular.Location = New System.Drawing.Point(822, 432)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(97, 25)
        Me.BtnAnular.TabIndex = 10
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.Visible = False
        '
        'FrmActOrdenDespacho
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1348, 520)
        Me.Controls.Add(Me.LblTotalNroDoc)
        Me.Controls.Add(Me.TxtTotalOD)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNREPORTE)
        Me.Controls.Add(Me.BtnAnular)
        Me.Controls.Add(Me.GrpOD)
        Me.Controls.Add(Me.GridDespacho)
        Me.Controls.Add(Me.PnlOD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmActOrdenDespacho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualiza Orden  de Despacho"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpOD.ResumeLayout(False)
        Me.GrpOD.PerformLayout()
        CType(Me.dgCabeceraOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDespacho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOD.ResumeLayout(False)
        Me.PnlOD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "FIELDS "
    Private TABLE_DESPACHO As New DataTable
    Dim Ayuda As New ClsAyuda
    'Dim ClsDa As New clsdatos_JHON
    'Dim ClsInter As New ClsInterface
    Public TabCabOrden As New DataTable
    Private CODTIPODESP As String = "2"
    Dim dt_tabla As New DataTable

    Dim rand As Integer

    Dim GUIAC As String
    Dim GUIAD As String


    Dim nro_pedido As String

#End Region
#Region "FUNCIONES FORM"
    Private Sub CARGAR_NRODESPACHO()
        Dim TABLECAB As New DataTable
        'VNroDespacho = dgCabeceraOrden.Item(Me.dgCabeceraOrden.CurrentRowIndex, 0)
        TABLECAB = TmpListarDatos("SP_TRAER_ORDENDESPACHO   '" & codempresa & "','" & VNroDespacho & "','" & GUIAC & "'")
        If TABLECAB.Rows.Count = 0 Then
            Exit Sub
        End If
        txtOrderDesp.Text = VNroDespacho
        TxtDestino.Text = TABLECAB.Rows(0)("DESTINO")
        TxtVehiculo.Text = TABLECAB.Rows(0)("CODVEHICULO")
        TxtFecDesp.Text = TABLECAB.Rows(0)("FECDESPACHO")
        TxtHoraDesp.Text = TABLECAB.Rows(0)("HORADESPACHO")
        TxtResponsable.Text = TABLECAB.Rows(0)("RESPONSABLE")
        TxtAyu.Text = TABLECAB.Rows(0)("AYUDANTE")

        Cargar_Ruta("", 0)

        'Me.dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)

        'TABLE_DESPACHO = TmpListarDatos("NSP_TRAER_CONSOLIDADOS_CLIENTE   '" & codempresa & "' , '" & VNroDespacho & "','" & CODTIPODESP & "' ")

        TABLE_DESPACHO = TmpListarDatos("SP_CARGAR_DOCUMENTOS_ORDENDESPACHO   '" & codempresa & "' , '" & VNroDespacho & "','" & VCorrelInv & "' ")
        GridDespacho.DataSource = TABLE_DESPACHO
        FORMATO_GRID_DETALLE()
        Dim TABtmpGuiaInterna As New DataTable
        TABtmpGuiaInterna = TmpListarDatos("OBTIENE_TOTALES_TMPGUIAINTERNA_PROC   '" & codempresa & "','" & VCorrelInv & "','" & txtOrderDesp.Text & "'")
        If TABtmpGuiaInterna.Rows.Count > 0 Then
            TxtTotalOD.Text = FormatoMonto(CDbl(TABtmpGuiaInterna.Rows(0)("TOTBAS")), DECIRESU)
            LblTotalNroDoc.Text = "Total de Documentos : " & TABLE_DESPACHO.Rows.Count
        Else
            TxtTotalOD.Text = "0.00"
            LblTotalNroDoc.Text = "Total de Documentos : 0"
        End If


        TABtmpGuiaInterna = TmpListarDatos("SP_OBTENER_CANTCLIENTES   '" & codempresa & "','" & VCorrelInv & "','" & txtOrderDesp.Text & "'")
        If TABtmpGuiaInterna.Rows.Count > 0 Then
            Label16.Text = "Total de Clientes : " & TABtmpGuiaInterna.Rows(0)("CANTCLI").ToString
        Else
            Label16.Text = "Total de Clientes : 0"
        End If







    End Sub
    Private Sub Cargar_Ruta(ByVal CDRUTA As String, ByVal VAR As Int32)
        dt_tabla = TmpListarDatos("SP_CARGA_RUTA  '" & codempresa & "', '" & VNroDespacho & "','" & CDRUTA & "'," & VAR & " ")
        If dt_tabla.Rows.Count <> 0 Then
            txtRuta.Text = dt_tabla.Rows(0)(0)
        Else
            txtRuta.Text = String.Empty
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean

        Const SYS_KEYDOWN As Integer = &H100
        Const SYSTEM_KEY As Integer = &H104
        If ((MSG.Msg = SYS_KEYDOWN) Or (MSG.Msg = SYSTEM_KEY)) Then
            Select Case KeyData
                Case Keys.Enter
                    If GridDespacho.Focus = True Then
                        If TABLE_DESPACHO.Rows.Count > 0 Then
                            VNroDoc = GridDespacho.Item(GridDespacho.CurrentRowIndex, 8)
                            VCdTipoDoc = GridDespacho.Item(GridDespacho.CurrentRowIndex, 1).ToString.Trim
                            VCodRuta = GridDespacho.Item(GridDespacho.CurrentRowIndex, 9).ToString.Trim
                            VPtoLLegada = GridDespacho.Item(GridDespacho.CurrentRowIndex, 10).ToString.Trim
                            VCodTiPrecioClie = GridDespacho.Item(GridDespacho.CurrentRowIndex, 11).ToString.Trim
                            VCodDep = GridDespacho.Item(GridDespacho.CurrentRowIndex, 12).ToString.Trim
                            nroguia = txtOrderDesp.Text


                            Dim tipopre As String

                            Dim codAlmacen As String

                            Dim FrmEditFact As New FrmActualizarFact
                            FrmEditFact.TIPOPRE = GridDespacho.Item(GridDespacho.CurrentRowIndex, 11).ToString.Trim
                            tipopre = GridDespacho.Item(GridDespacho.CurrentRowIndex, 11).ToString.Trim
                            codAlmacen = GridDespacho.Item(GridDespacho.CurrentRowIndex, 13).ToString.Trim
                            FrmEditFact.CODALMACENX = GridDespacho.Item(GridDespacho.CurrentRowIndex, 13).ToString.Trim
                            FrmEditFact.TIPOPAGO = GridDespacho.Item(GridDespacho.CurrentRowIndex, 14).ToString.Trim
                            FrmEditFact.NROGUIA = txtOrderDesp.Text
                            FrmEditFact.FECHA = CDate(GridDespacho.Item(GridDespacho.CurrentRowIndex, 0).ToString.Trim)

                            Dim dt_numpedido As DataTable
                            dt_numpedido = TmpListarDatos("SP_EXTRAER_NROPEDIDO  '" & codempresa & "','" & txtOrderDesp.Text & "','" & VNroDoc & "','" & VCdTipoDoc & "','" & GUIAD & "'")
                            If dt_numpedido.Rows.Count > 0 Then
                                nro_pedido = dt_numpedido.Rows(0)(0).ToString
                            End If
                            FrmEditFact.ShowDialog()

                            If FrmEditFact.DEVOLVER = False Then
                                Exit Function
                            End If

                            MsgBox("SE AGREGAR EL DOCUMENTO A LA ORDEN DE VENTA NRO " & txtOrderDesp.Text, MsgBoxStyle.Information, "NAR SISTEMAS SAC")
                            Dim TABGuiaInterna As New DataTable
                            TABGuiaInterna = TmpListarDatos("SP_VerificarDocEnGuiaInterna  '" & codempresa & "','" & VNroDoc & "','" & VCdTipoDoc & "'")
                            If TABGuiaInterna.Rows.Count > 0 Then
                                MsgBox("NO SE PUEDE AGREGAR EL DOCUMENTO" & vbNewLine & "EL DOCUMENTO YA ESTA REGISTRADO EN LA ORDEN DE VENTA NRO " & TABGuiaInterna.Rows(0)(0), MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC ")
                                Exit Function
                            End If
                            TABGuiaInterna = TmpListarDatos("SP_VerificarDocEnTMP_GuiaInterna  '" & codempresa & "','" & VNroDoc & "','" & VCdTipoDoc & "','" & VCorrelInv & "'")
                            If TABGuiaInterna.Rows.Count > 0 Then
                                MsgBox("NO SE PUEDE AGREGAR EL DOCUMENTO" & vbNewLine & "EL DOCUMENTO YA ESTA REGISTRADO EN LA ORDEN DE VENTA NRO " & TABGuiaInterna.Rows(0)(0), MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC ")
                                Exit Function
                            End If
                            If CAyuda.Ejecutar("SP_AgregarDocEnTMP_GUIAINTERNADET2", codempresa, VCorrelInv, VNroDespacho, VNroDoc, VCdTipoDoc, VFecDespacho, VCodRuta, tipopre, codAlmacen, nro_pedido) > 0 Then

                                'If TIPODESC = False Then
                                '    'CAyuda.Ejecutar("SP_UPD_VENTADET_DESC", codempresa, CStr(VCorrelInv), VCdTipoDoc, VNroDoc, NROPTOVTA, CodUsuario)

                                '    'CAyuda.Ejecutar("SP_UPDVCDES", VNroDoc, VCdTipoDoc)
                                '    If GridDespacho.Item(GridDespacho.CurrentRowIndex, 14).ToString.Trim = "01" Then
                                '        If CAyuda.Ejecutar("SP_PORCDESC2", VNroDoc, VCdTipoDoc) > 0 Then

                                '        End If
                                '    End If

                                'End If

                                CARGAR_NRODESPACHO()
                                CargarGridCabecera()
                            End If
                            CARGAR_NRODESPACHO()
                        End If
                    End If
                Case Keys.F3
                    If GridDespacho.Focus = True Then
                        If TABLE_DESPACHO.Rows.Count > 0 Then
                            Dim Sender As Object = Nothing
                            Dim e As EventArgs = Nothing
                            BtnQuitarDoc_Click(Sender, e)
                        End If
                    End If
            End Select
        End If
    End Function
    Private Sub FORMATO_GRID_DETALLE()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_DESPACHO.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "FECDOCUM"
            .HeaderText = "Fecha"
            .Format = "dd/MM/yyyy"
            .Width = 100
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CODTIPODOC"
            .HeaderText = "Codtipodoc"
            .Width = 0
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DSTIPODOC"
            .HeaderText = "Tipo Doc"
            .Width = 100
        End With

        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "NRODOCU"
            .HeaderText = "Nro. Doc."
            .Format = "0##-#######"
            .Width = 100
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "CODCLIENTE"
            .HeaderText = "Codcliente"
            .Width = 0
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "DESCLIENTE"
            .HeaderText = "Cliente"
            .Width = 250
        End With
        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "DSTIPOPAGO"
            .HeaderText = "Cond. Pago"
            .Width = 120
        End With
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "TOTBAS"
            .HeaderText = "Importe"
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
            .Width = 75
        End With
        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "NRODOCFACT"
            .HeaderText = "NroFact"
            .Width = 0
        End With
        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "CODRUTA"
            .HeaderText = "CODRUTA"
            .Width = 50
        End With
        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "PTOLLEGADA"
            .HeaderText = "PTOLLEGADA"
            .Width = 0
        End With
        Dim Column12 As New DataGridTextBoxColumn
        With Column12
            .MappingName = "CODTIPOPRE"
            .HeaderText = "CODTIPOPRE"
            .Width = 0
        End With
        Dim Column13 As New DataGridTextBoxColumn
        With Column13
            .MappingName = "CODDEP"
            .HeaderText = "CODDEP"
            .Width = 0
        End With

        Dim Column14 As New DataGridTextBoxColumn
        With Column14
            .MappingName = "CODALMACEN"
            .HeaderText = "CODALMACEN"
            .Width = 0
        End With


        Dim Column15 As New DataGridTextBoxColumn
        With Column15
            .MappingName = "CODTIPOPAGO"
            .HeaderText = "CODTIPOPAGO"
            .Width = 0
        End With


        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15})
        GridDespacho.TableStyles.Clear()
        GridDespacho.TableStyles.Add(TableStyle1)


    End Sub
    Sub CancelarTodo()
        Me.TabCabOrden.Rows.Clear()
        Me.dgCabeceraOrden.DataSource = TabCabOrden
        GridDespacho.DataSource = Nothing
        CANCELAR()

    End Sub
    Public Sub LlenarGrid(ByVal NRODESPACHO As String)
        If TabCabOrden.Rows.Count > 0 Then
            For ContY As Integer = 0 To TabCabOrden.Rows.Count - 1
                If TabCabOrden.Rows(ContY)("NRODESPACHO").ToString.Trim = NRODESPACHO.Trim Then
                    Exit Sub
                End If
            Next
        End If
        Conecta("SELECT FECDOCUM FROM ORDEN_DESPACHO WHERE NRORDEN_DESPACHO='" & NRODESPACHO.Trim & "' AND CODEMPRESA='" & codempresa.Trim & "'", "DTR")
        Dim filaCab As DataRow = TabCabOrden.NewRow
        filaCab(0) = VNroDespacho
        filaCab(1) = VFecDespacho
        TabCabOrden.Rows.Add(filaCab)
        TabCabOrden.AcceptChanges()
        dgCabeceraOrden.DataSource = TabCabOrden
        TablaEstiloCabecera.MappingName = TabCabOrden.TableName
        TablaEstiloCabecera.GridColumnStyles(0).MappingName = "ORDEN_DESPACHO"
        TablaEstiloCabecera.GridColumnStyles(1).MappingName = "FECHA"
        dgCabeceraOrden.TableStyles.Add(TablaEstiloCabecera)
    End Sub
    Sub BtnCancelar_Click(ByVal sender, ByVal e)
        Dim o As Object
        For Each o In Me.PnlOD.Controls
            If TypeOf o Is Label Then
                If o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle Then
                    o.text = ""
                End If
            End If
        Next
    End Sub
    Sub EnviarDatos()
        Dim Frm As New FrmEditarDocumento_enOrdenDespacho
        Frm.ShowDialog()
        If Frm.DEVOLVER = False Then
            Exit Sub
        End If
        TABLE_DESPACHO = TmpListarDatos("NSP_TRAER_CONSOLIDADOS_CLIENTE   '" & codempresa & "' , '" & txtOrderDesp.Text & "' ")
        GridDespacho.DataSource = TABLE_DESPACHO
        FORMATO_GRID_DETALLE()
        CANCELAR()
    End Sub
    Private Sub LimpiarCajaTxt(ByVal Ctrl As Control)
        Dim Obj As Control
        For Each Obj In Ctrl.Controls
            If TypeOf Obj Is TextBox Then
                Obj.Text = ""
            End If
        Next


    End Sub
    Private Sub LimpiarTemporal()
        TmpInsertDatos("DELETE  FROM  TMP_GUIAINTERNADET  WHERE  CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelInv & "'")
        VCodCliente = ""
        VCodDep = ""
        LblTotalNroDoc.Text = "Total de Documentos : 0"
        TABLE_DESPACHO.Rows.Clear()
        TabCabOrden.Rows.Clear()
    End Sub
    Private Sub HabilitaBtn(ByVal valor As Boolean)
        BtnNuevo.Enabled = valor
        BtnConsultar.Enabled = valor
        GrpOD.Enabled = Not valor
        PnlOD.Enabled = Not valor
        GridDespacho.Enabled = Not valor
        BtnGuardaTodos.Enabled = Not valor
        BtnGuardaUno.Enabled = Not valor
        BtnAnular.Enabled = Not valor
        BtnAgregarDoc.Enabled = Not valor
        BtnQuitarDoc.Enabled = Not valor

    End Sub
    Private Sub CargarGridCabecera()
        TabCabOrden = TmpListarDatos("SELECT  NRODESPACHO,FECDOCUM  FROM  TMP_GUIAINTERNADET  WHERE  CORRNBR='" & VCorrelInv & "' AND CODEMPRESA='" & codempresa & " ' AND ESTADO<>'A' GROUP  BY  NRODESPACHO,FECDOCUM")
        dgCabeceraOrden.DataSource = TabCabOrden
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TabCabOrden.TableName()
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "NRODESPACHO"
            .HeaderText = "ORDEN DE VENTA"
            .Width = 120
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "FECDOCUM"
            .HeaderText = "FECHA"
            .Width = 75
            .Format = "dd/MM/yyyy"
        End With
        dgCabeceraOrden.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2})
        dgCabeceraOrden.TableStyles.Add(TableStyle1)


    End Sub


#End Region


    Dim apiService As IApiService = New ApiService()

    Private Sub FrmActOrdenDespacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CANCELAR()
        VDescTotbas = 0


    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub GridDespacho_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDespacho.DoubleClick
        'Conecta("SELECT ORDEN_ACTUALIZADO FROM ORDEN_DESPACHO WHERE CODEMPRESA='" & codempresa & "' AND NRORDEN_DESPACHO ='" & GridDespacho(GridDespacho.CurrentRowIndex, 10).ToString.Trim & "'", "T1")
        'If ds.Tables("T1").Rows(0)(0) Then
        '    MsgBox("Esta planilla ya se ha confirmado. Ya no se puede actualizar.", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'EnviarDatos()

    End Sub

    Private Sub txtOrderDesp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrderDesp.KeyDown
        If e.KeyCode = Keys.Enter Then
            LlenarGrid(txtOrderDesp.Text.Trim)
        End If
    End Sub

    Private Sub dgCabeceraOrden_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCabeceraOrden.CurrentCellChanged
        Try
            VNroDespacho = dgCabeceraOrden.Item(Me.dgCabeceraOrden.CurrentRowIndex, 0)
            VFecDespacho = dgCabeceraOrden.Item(Me.dgCabeceraOrden.CurrentRowIndex, 1)

            CARGAR_NRODESPACHO()

        Catch ex As Exception

        End Try
    End Sub
    Sub CANCELAR()
        LimpiarCajaTxt(GrpOD)
        LimpiarCajaTxt(PnlOD)
        LimpiarTemporal()
        BtnBuscar.Visible = False
        btnmodificar.Enabled = False
        TabCabOrden.Rows.Clear()
        TxtTotalOD.Text = "0.00"
        HabilitaBtn(True)
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click


        CANCELAR()


    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnGuardaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardaUno.Click

        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = CDate(TxtFecDesp.Text).Year
        MES = CDate(TxtFecDesp.Text).Month

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

        If MsgBox("ESTA SEGURO DE ACTUALIZAR TODAS LAS ORDENES DE DESPACHO...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim FECHAANU As String
            Dim TMP_DOCANU As DataTable
            TMP_DOCANU = TmpListarDatos("SP_DOC_ANULADOS  '" & codempresa & "','" & VCorrelInv & "'")
            If TMP_DOCANU.Rows.Count > 0 Then
                For X As Integer = 0 To TMP_DOCANU.Rows.Count - 1
                    TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT  '" & codempresa & "','" & 1 & "','" & VCorrelInv & "','" & TMP_DOCANU.Rows(X)("NRODOCFACT").ToString & "','" & CDate(TMP_DOCANU.Rows(X)("FECDOCUM")) & "'")
                    TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE  '" & codempresa & "','" & 1 & "','" & VCorrelInv & "','" & TMP_DOCANU.Rows(X)("NRODOCFACT").ToString & "'")
                    TmpInsertDatos("SP_ELIMINAR_VENTAXCOBRAR  '" & TMP_DOCANU.Rows(X)("NRODOCFACT").ToString & "','" & TMP_DOCANU.Rows(X)("CODTIPODOC").ToString & "'")
                    FECHAANU = CDate(TMP_DOCANU.Rows(X)("FECDOCUM"))




                    If EMIELECTRONIC = True Then
                        If TMP_DOCANU.Rows(X)("CODTIPODOC").ToString.Trim = "01" Or TMP_DOCANU.Rows(X)("CODTIPODOC").ToString.Trim = "03" Then

                            Dim LETRADOC As String = ""

                            If TMP_DOCANU.Rows(X)("CODTIPODOC").ToString.Trim = "01" Then
                                LETRADOC = "F"
                            End If
                            If TMP_DOCANU.Rows(X)("CODTIPODOC").ToString.Trim = "03" Then
                                LETRADOC = "B"
                            End If
                            If TMP_DOCANU.Rows(X)("CODTIPODOC").ToString.Trim = "06" Then
                                LETRADOC = "F"
                            End If

                            Dim SERIE2 As String
                            Dim FormatNroDoc As String
                            FormatNroDoc = Format(CDbl(TMP_DOCANU.Rows(X)("NRODOCFACT").ToString), "0##-########")
                            Dim NUMSERIE As String
                            NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                            SERIE2 = LETRADOC + NUMSERIE

                            Dim NRODOCSIN As String
                            NRODOCSIN = CStr(Microsoft.VisualBasic.Right(TMP_DOCANU.Rows(X)("NRODOCFACT").ToString, 8))
                            Dim NRODOCFINAL As String
                            NRODOCFINAL = SERIE2 + "-" + NRODOCSIN

                            Dim gestordetipoNegocio As New GestorDeFacturacionElectronica
                            gestordetipoNegocio.AnularFE(SERIE2, NRODOCSIN, TMP_DOCANU.Rows(X)("CODTIPODOC").ToString.Trim)

                            If SERIE2 = "F008" Or SERIE2 = "F009" Or SERIE2 = "F011" Or SERIE2 = "F012" Then
                                AnularFactKIM(SERIE2, NRODOCSIN, TMP_DOCANU.Rows(X)("CODTIPODOC").ToString.Trim)
                            End If

                        End If
                    End If

                Next
            End If

            Dim TMP_DOCACT As DataTable
            TMP_DOCACT = TmpListarDatos("SP_DOC_ACT  '" & codempresa & "','" & VCorrelInv & "'")
            If TMP_DOCACT.Rows.Count > 0 Then
                For X As Integer = 0 To TMP_DOCACT.Rows.Count - 1
                    TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT  '" & codempresa & "','" & 0 & "','" & VCorrelInv & "','" & TMP_DOCACT.Rows(X)("NRODOCU").ToString & "','" & CDate(FECHAANU) & "'")
                    TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE_FACT  '" & codempresa & "','" & 1 & "','" & VCorrelInv & "','" & TMP_DOCACT.Rows(X)("NRODOCU").ToString & "'")
                Next
            End If

            Try
                If MsgBox("ESTA SEGURO DE ACTUALIZAR LA ORDEN DE DESPACHO SELECCIONADA...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If TabCabOrden.Rows.Count = 0 Then
                        If TmpInsertDatos("SP_ConfirActualizaGuiaInternaJ  '" & codempresa & "','" & VCorrelInv & "','" & txtOrderDesp.Text & "','1','Z','" & TxtResponsable.Text & "','" & TxtAyu.Text & "','" & GUIAC & "','" & GUIAD & "'") Then
                            If CAyuda.Ejecutar("SP_ELI_ODTMP_GUIAINTERNADET", codempresa, VCorrelInv, VNroDespacho) > 0 Then
                                CARGAR_NRODESPACHO()
                                CargarGridCabecera()
                            End If
                        End If

                    Else
                        If TmpInsertDatos("SP_ConfirActualizaGuiaInternaJ  '" & codempresa & "','" & VCorrelInv & "','" & VNroDespacho & "','1','T','" & TxtResponsable.Text & "','" & TxtAyu.Text & "','" & GUIAC & "','" & GUIAD & "'") Then
                            MsgBox("La Orden de Despacho  Nro " & dgCabeceraOrden(dgCabeceraOrden.CurrentRowIndex, 0).ToString.Trim & " ha sido  actualizado para crear su planilla...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                            If CAyuda.Ejecutar("SP_ELI_ODTMP_GUIAINTERNADET", codempresa, VCorrelInv, VNroDespacho) > 0 Then
                                CARGAR_NRODESPACHO()
                                CargarGridCabecera()
                                If TabCabOrden.Rows.Count > 0 Then
                                    dgCabeceraOrden.CurrentRowIndex = TabCabOrden.Rows.Count - 1
                                    dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)
                                End If
                                If TabCabOrden.Rows.Count = 0 Then
                                    CANCELAR()
                                End If
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception

            End Try

            If TabCabOrden.Rows.Count = 0 Then
                MsgBox("La Ordenes de Despacho han sido actualizados para crear sus planillas...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                CANCELAR()
            End If
        End If

    End Sub

    Private Async Sub AnularFactKIM(ByVal serie As String, ByVal nume As String, ByVal codtipodoc As String)
        Dim url As String
        url = System.Configuration.ConfigurationManager.AppSettings("url").ToString()
        Dim response = Await Me.apiService.PostAsync(url, "api", "/AnularDocKim/" & serie & "/" & nume & "/" & codtipodoc, "")
    End Sub


    Private Sub BtnGuardaTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardaTodos.Click

        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = CDate(TxtFecDesp.Text).Year
        MES = CDate(TxtFecDesp.Text).Month

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

        If MsgBox("ESTA SEGURO DE ACTUALIZAR TODAS LAS ORDENES DE DESPACHO...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim TMP_DOCANU As DataTable
            TMP_DOCANU = TmpListarDatos("SP_DOC_ANULADOS  '" & codempresa & "','" & VCorrelInv & "'")
            If TMP_DOCANU.Rows.Count > 0 Then
                For X As Integer = 0 To TMP_DOCANU.Rows.Count - 1
                    TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT  '" & codempresa & "','" & 1 & "','" & VCorrelInv & "','" & TMP_DOCANU.Rows(X)("NRODOCFACT").ToString & "','" & CDate(TMP_DOCANU.Rows(X)("FECDOCUM")) & "'")

                    TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE  '" & codempresa & "','" & 1 & "','" & VCorrelInv & "','" & TMP_DOCANU.Rows(X)("NRODOCFACT").ToString & "'")

                    TmpInsertDatos("SP_ELIMINAR_VENTAXCOBRAR  '" & TMP_DOCANU.Rows(X)("NRODOCFACT").ToString & "','" & TMP_DOCANU.Rows(X)("CODTIPODOC").ToString & "'")

                Next
            End If


            Dim TMP_DOCACT As DataTable
            TMP_DOCACT = TmpListarDatos("SP_DOC_ACT  '" & codempresa & "','" & VCorrelInv & "'")
            If TMP_DOCACT.Rows.Count > 0 Then
                For X As Integer = 0 To TMP_DOCACT.Rows.Count - 1
                    TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT  '" & codempresa & "','" & 0 & "','" & VCorrelInv & "','" & TMP_DOCACT.Rows(X)("NRODOCU").ToString & "','" & CDate(TMP_DOCANU.Rows(X)("FECDOCUM")) & "'")
                    TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE_FACT  '" & codempresa & "','" & 1 & "','" & VCorrelInv & "','" & TMP_DOCACT.Rows(X)("NRODOCU").ToString & "'")
                Next
            End If


            Try
                If MsgBox("ESTA SEGURO DE ACTUALIZAR LA ORDEN DE DESPACHO SELECCIONADA...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If TabCabOrden.Rows.Count = 0 Then
                        If TmpInsertDatos("SP_ConfirActualizaGuiaInternaJ  '" & codempresa & "','" & VCorrelInv & "','" & txtOrderDesp.Text & "','1','Z','" & TxtResponsable.Text & "','" & TxtAyu.Text & "','" & GUIAC & "','" & GUIAD & "'") Then
                            If CAyuda.Ejecutar("SP_ELI_ODTMP_GUIAINTERNADET", codempresa, VCorrelInv, VNroDespacho) > 0 Then
                                CARGAR_NRODESPACHO()
                                CargarGridCabecera()
                            End If
                        End If
                    Else
                        If TmpInsertDatos("SP_ConfirActualizaGuiaInternaJ  '" & codempresa & "','" & VCorrelInv & "','" & VNroDespacho & "','1','T','" & TxtResponsable.Text & "','" & TxtAyu.Text & "','" & GUIAC & "','" & GUIAD & "'") Then
                            MsgBox("La Orden de Despacho  Nro " & dgCabeceraOrden(dgCabeceraOrden.CurrentRowIndex, 0).ToString.Trim & " ha sido  actualizado para crear su planilla...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                            If CAyuda.Ejecutar("SP_ELI_ODTMP_GUIAINTERNADET", codempresa, VCorrelInv, VNroDespacho) > 0 Then
                                CARGAR_NRODESPACHO()
                                CargarGridCabecera()
                                If TabCabOrden.Rows.Count > 0 Then
                                    dgCabeceraOrden.CurrentRowIndex = TabCabOrden.Rows.Count - 1
                                    dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)
                                End If
                                If TabCabOrden.Rows.Count = 0 Then
                                    CANCELAR()
                                End If
                            End If
                        End If

                    End If
                End If
            Catch ex As Exception
            End Try

            If TabCabOrden.Rows.Count = 0 Then
                MsgBox("La Ordenes de Despacho han sido actualizados para crear sus planillas...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                CANCELAR()
            End If
        End If

    End Sub
    Private Sub BtnQuitarOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarOD.Click
        If TabCabOrden.Rows.Count > 0 Then
            If CAyuda.Ejecutar("SP_ELI_ODTMP_GUIAINTERNADET", codempresa, VCorrelInv, dgCabeceraOrden(dgCabeceraOrden.CurrentRowIndex, 0).ToString.Trim) > 0 Then
                CARGAR_NRODESPACHO()
                CargarGridCabecera()
                If TabCabOrden.Rows.Count > 0 Then
                    dgCabeceraOrden.CurrentRowIndex = TabCabOrden.Rows.Count - 1
                    dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)
                End If
            End If
        End If

    End Sub

    Private Sub BtnBuscOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscOD.Click

        Dim o As New FrmBusquedaDeOrdenDespacho
        o.TIPO = "F"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If

        txtOrderDesp.Text = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        VNroDespacho = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        VFecDespacho = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 0)
        GUIAC = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 4)
        GUIAD = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 5)

        Dim VentaC, VentD As String
        Dim MesAct, Anio As String
        MesAct = Format(VFecDespacho, "MM")
        Anio = Format(VFecDespacho, "yyyy")

        VentaC = "VENTC" & Anio & MesAct
        VentD = "VENTD" & Anio & MesAct

        Dim dt_doc As DataTable

        If VERIFICA_HISTORICOVENT(VentaC) = True Then
            dt_doc = TmpListarDatos("SP_VENTACAB   '" & codempresa & "','" & VNroDespacho & "','" & VentaC & "',1")
            If dt_doc.Rows.Count > 0 Then
                For x As Integer = 0 To dt_doc.Rows.Count - 1
                    CAyuda.Ejecutar("NSP_ACTIVAR_DOC_ANUL", codempresa, VNroDespacho, dt_doc.Rows(x)("NRODOCU").ToString, dt_doc.Rows(x)("CODTIPODOC").ToString, VentaC, VentD, 1)
                Next
            End If
        End If

        dt_doc = TmpListarDatos("SP_VENTACAB   '" & codempresa & "','" & VNroDespacho & "','" & VentaC & "',0")
        If dt_doc.Rows.Count > 0 Then
            For x As Integer = 0 To dt_doc.Rows.Count - 1
                CAyuda.Ejecutar("NSP_ACTIVAR_DOC_ANUL", codempresa, VNroDespacho, dt_doc.Rows(x)("NRODOCU").ToString, dt_doc.Rows(x)("CODTIPODOC").ToString, VentaC, VentD, 0)
            Next
        End If

        dt_doc = TmpListarDatos("NSP_ANUL_DOCACT   '" & codempresa & "','" & VNroDespacho & "','" & VentaC & "'")
        If dt_doc.Rows.Count > 0 Then
            For x As Integer = 0 To dt_doc.Rows.Count - 1
                CAyuda.Ejecutar("NSP_ANUL_DOCACT2", codempresa, VNroDespacho, dt_doc.Rows(x)("NRODOCU").ToString, dt_doc.Rows(x)("CODTIPODOC").ToString, VentaC, VentD)

                '/*** FACTURACION ELECTRONICA *****************************************************************
                If EMIELECTRONIC = True Then
                    Dim LETRADOC As String = ""
                    If dt_doc.Rows(x)("CODTIPODOC").ToString.Trim = "01" Then
                        LETRADOC = "F"
                    End If
                    If dt_doc.Rows(x)("CODTIPODOC").ToString.Trim = "03" Then
                        LETRADOC = "B"
                    End If
                    If dt_doc.Rows(x)("CODTIPODOC").ToString.Trim = "06" Then
                        LETRADOC = "F"
                    End If
                    Dim VNroDocumento As String

                    VNroDocumento = dt_doc.Rows(x)("NRODOCU").ToString().Trim

                    Dim SERIE2 As String
                    Dim FormatNroDoc As String
                    FormatNroDoc = Format(CDbl(VNroDocumento), "0##-########")
                    Dim NUMSERIE As String
                    NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)

                    SERIE2 = LETRADOC + NUMSERIE

                    Dim NRODOCSIN As String
                    NRODOCSIN = CStr(Microsoft.VisualBasic.Right(VNroDocumento, 8))
                    Dim NRODOCFINAL As String
                    NRODOCFINAL = SERIE2 + "-" + NRODOCSIN

                    Dim gestordetipoNegocio As New GestorDeFacturacionElectronica
                    gestordetipoNegocio.AnularFE(SERIE2, NRODOCSIN, dt_doc.Rows(x)("CODTIPODOC").ToString.Trim)

                End If
                '/********************************************************************

            Next
        End If

        CAyuda.Ejecutar("SP_CARGADETALLE_GUIAINTERNADET_PROC", codempresa, VCorrelInv, VNroDespacho, 1, GUIAD)
        CARGAR_NRODESPACHO()
        CargarGridCabecera()
        If TabCabOrden.Rows.Count <> 0 Then
            dgCabeceraOrden.CurrentRowIndex = TabCabOrden.Rows.Count - 1
            dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)
        End If

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




    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        LimpiarCajaTxt(GrpOD)
        LimpiarCajaTxt(PnlOD)
        LimpiarTemporal()
        BtnBuscar.Visible = False
        TabCabOrden.Rows.Clear()
        TxtTotalOD.Text = "0.00"

        HabilitaBtn(False)
        BtnGuardaTodos.Enabled = False

    End Sub

    Private Sub BtnAgregarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregarDoc.Click
        If TABLE_DESPACHO.Rows.Count > 0 Then
            'Dim FrmBDoc As New FrmConsultarFacturac2
            Dim FrmBDoc As New FrmListarFactSinOrdenVta
            FrmBDoc.ShowDialog()
            If FrmBDoc.DEVOLVER = False Then
                Exit Sub
            End If
            VCdTipoDoc = Trim(FrmBDoc.DtgDoc.Item(FrmBDoc.DtgDoc.CurrentRowIndex, 0).ToString())
            VNroDoc = Trim(FrmBDoc.DtgDoc.Item(FrmBDoc.DtgDoc.CurrentRowIndex, 2).ToString())
            If Trim(FrmBDoc.DtgDoc.Item(FrmBDoc.DtgDoc.CurrentRowIndex, 7).ToString()) = "A" Then
                MsgBox("EL DOCUMENTO ESTA ANULADO...NO SE PUEDE AGREGAR ", MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC ")
                Exit Sub
            End If
            If MsgBox("ESTA SEGURO DE AGREGAR EL DOCUMENTO A LA ORDEN DE DESPACHO NRO " & txtOrderDesp.Text, MsgBoxStyle.YesNo, "NAR SISTEMAS SAC") = MsgBoxResult.Yes Then
                Dim TABGuiaInterna As New DataTable
                TABGuiaInterna = TmpListarDatos("SP_VerificarDocEnGuiaInterna  '" & codempresa & "','" & VNroDoc & "','" & VCdTipoDoc & "'")
                If TABGuiaInterna.Rows.Count > 0 Then
                    MsgBox("NO SE PUEDE AGREGAR EL DOCUMENTO" & vbNewLine & "EL DOCUMENTO YA ESTA REGISTRADO EN LA ORDEN DE DESPACHO NRO " & TABGuiaInterna.Rows(0)(0), MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC ")
                    Exit Sub
                End If
                TABGuiaInterna = TmpListarDatos("SP_VerificarDocEnTMP_GuiaInterna  '" & codempresa & "','" & VNroDoc & "','" & VCdTipoDoc & "','" & VCorrelInv & "'")
                If TABGuiaInterna.Rows.Count > 0 Then
                    MsgBox("NO SE PUEDE AGREGAR EL DOCUMENTO" & vbNewLine & "EL DOCUMENTO YA ESTA REGISTRADO EN LA ORDEN DE DESPACHO NRO " & TABGuiaInterna.Rows(0)(0), MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC ")
                    Exit Sub
                End If
                If CAyuda.Ejecutar("SP_AgregarDocEnTMP_GUIAINTERNADET", codempresa, VCorrelInv, VNroDespacho, VNroDoc, VCdTipoDoc, VFecDespacho) > 0 Then
                    CARGAR_NRODESPACHO()
                    CargarGridCabecera()
                End If
            End If
        End If
    End Sub
    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub BtnQuitarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarDoc.Click


        Dim FECHA As Date

        If TABLE_DESPACHO.Rows.Count > 0 Then
            VNroDoc = GridDespacho.Item(GridDespacho.CurrentRowIndex, 8)
            VCdTipoDoc = GridDespacho.Item(GridDespacho.CurrentRowIndex, 1).ToString.Trim
            VCodCliente = GridDespacho.Item(GridDespacho.CurrentRowIndex, 12).ToString.Trim
            FECHA = GridDespacho.Item(GridDespacho.CurrentRowIndex, 0).ToString.Trim()

            Dim VentaC, VentD As String
            Dim MesAct, Anio As String
            MesAct = Format(FECHA, "MM")
            Anio = Format(FECHA, "yyyy")

            VentaC = "VENTC" & Anio & MesAct
            VentD = "VENTD" & Anio & MesAct

            Dim TMP_DOCACT As DataTable
            TMP_DOCACT = TmpListarDatos("SP_DOC_ACT2  '" & codempresa & "','" & VCorrelInv & "','" & VNroDoc & "','" & VCdTipoDoc & "','" & VentaC & "'")

            If TMP_DOCACT.Rows.Count > 0 Then

                'If CAyuda.Ejecutar("SP_DELETE_FACT", codempresa, VCorrelInv, VNroDoc) > 0 Then
                '    MsgBox("SE ANULO CORRECTAMENTE EL DOCUMENTO .. ", MsgBoxStyle.Information, "")
                '    CARGAR_NRODESPACHO()
                '    CargarGridCabecera()
                'End If

                Dim FrmMsj As New FrmMotivoAnula
                FrmMsj.ShowDialog()

                If CAyuda.Ejecutar("ANULAR_DOCUMENTO_EN_FACTURACION_PROC", codempresa, VCdTipoDoc, VNroDoc, VCodCliente, VCdTipoAnula, VCdLiquidador, VCdRepartidor, VCdTipoRechazo, VObserv, CStr(VDescTotbas), VentaC, VentD) > 0 Then
                    CAyuda.Ejecutar("SP_ANULDOC_TMP_GUIAINTERNADET", codempresa, VCorrelInv, VNroDoc, VCdTipoDoc)
                    MsgBox("SE ANULO CORRECTAMENTE EL DOCUMENTO .. ", MsgBoxStyle.Information, "")
                    CARGAR_NRODESPACHO()
                    CargarGridCabecera()
                End If

                Exit Sub
            End If

            If MsgBox("ESTA SEGURO DE ELIMINAR EL DOCUMENTO..", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                Dim FrmMsj As New FrmMotivoAnula
                FrmMsj.ShowDialog()


                If CAyuda.Ejecutar("ANULAR_DOCUMENTO_EN_FACTURACION_PROC", codempresa, VCdTipoDoc, VNroDoc, VCodCliente, VCdTipoAnula, VCdLiquidador, VCdRepartidor, VCdTipoRechazo, VObserv, CStr(VDescTotbas), VentaC, VentD) > 0 Then
                    CAyuda.Ejecutar("SP_ANULDOC_TMP_GUIAINTERNADET", codempresa, VCorrelInv, VNroDoc, VCdTipoDoc)
                    MsgBox("SE ANULO CORRECTAMENTE EL DOCUMENTO .. ", MsgBoxStyle.Information, "")
                    CARGAR_NRODESPACHO()
                    CargarGridCabecera()
                End If


            End If
        End If

    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        GridDespacho.Enabled = True
    End Sub

    Private Sub BtnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConsultar.Click
        BtnBuscar.Visible = True
        PnlOD.Enabled = True
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim o As New FrmBusquedaDeOrdenDespacho
        o.TIPO = "T"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        txtOrderDesp.Text = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        VNroDespacho = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 1)
        VFecDespacho = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 0)
        GUIAC = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 4)
        GUIAD = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 5)

        CAyuda.Ejecutar("SP_CARGADETALLE_GUIAINTERNADET_PROC", codempresa, VCorrelInv, VNroDespacho, 1, GUIAD)
        CARGAR_NRODESPACHO()
        CargarGridCabecera()
        If TabCabOrden.Rows.Count <> 0 Then
            dgCabeceraOrden.CurrentRowIndex = TabCabOrden.Rows.Count - 1
            dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)
        End If
    End Sub

    Private Sub BtnAgreOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgreOD.Click
        If TxtOD.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        VNroDespacho = TxtOD.Text
        CAyuda.Ejecutar("SP_CARGADETALLE_GUIAINTERNADET_PROC", codempresa, VCorrelInv, VNroDespacho, 1)
        CARGAR_NRODESPACHO()
        CargarGridCabecera()
        If TabCabOrden.Rows.Count <> 0 Then
            dgCabeceraOrden.CurrentRowIndex = TabCabOrden.Rows.Count - 1
            dgCabeceraOrden.Select(Me.dgCabeceraOrden.CurrentRowIndex)
        End If
    End Sub

    Private Sub TxtOD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOD.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAgreOD_Click(sender, e)
        End If
    End Sub

    Private Sub GridDespacho_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDespacho.Click

        If Me.dgCabeceraOrden.VisibleRowCount <> 0 Then
            Cargar_Ruta(Convert.ToString(Me.GridDespacho.Item(Me.dgCabeceraOrden.CurrentRowIndex, 9)), 1)
        End If
    End Sub

    Private Sub GridDespacho_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridDespacho.Navigate

    End Sub

    Private Sub BTNREPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNREPORTE.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fr As New Form1
        fr.Show()

    End Sub

    Private Sub GridDespacho_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles GridDespacho.DragDrop

    End Sub

    Private Sub TxtOD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOD.TextChanged

    End Sub
End Class
