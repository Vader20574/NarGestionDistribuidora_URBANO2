Public Class ptoventa
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label25 As Label
    Friend WithEvents tnotadebB As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tntacredB As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tresponsable As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtPrePlanilla As TextBox
    Friend WithEvents CheckPromociones As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtClienteVarios As TextBox
    Friend WithEvents ChkClieVarios As CheckBox
    Friend WithEvents tpedido2 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ttickbol2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPlanilla04 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPlanilla03 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPlanilla02 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPlanilla01 As TextBox
    Friend WithEvents ttickfac2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkptoventa As CheckBox
    Friend WithEvents chkfuerzaventa As CheckBox
    Friend WithEvents CheckFecha As CheckBox
    Friend WithEvents CheckPrecio As CheckBox
    Friend WithEvents txtGuiTran As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tnotadeb As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tntacred As TextBox
    Friend WithEvents tpedido As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ttickbol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ttickfac As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents tterminal As TextBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cprecio2 As ComboBox
    Friend WithEvents cprecio1 As ComboBox
    Friend WithEvents txtctaBanca As ComboBox
    Friend WithEvents label As Label
    Friend WithEvents tserie As TextBox
    Friend WithEvents txtNumGuia As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tptoventa As TextBox
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ptoventa))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tptoventa = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNumGuia = New System.Windows.Forms.TextBox()
        Me.tserie = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.txtctaBanca = New System.Windows.Forms.ComboBox()
        Me.cprecio1 = New System.Windows.Forms.ComboBox()
        Me.cprecio2 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.tterminal = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ttickfac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ttickbol = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tpedido = New System.Windows.Forms.TextBox()
        Me.tntacred = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tnotadeb = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGuiTran = New System.Windows.Forms.TextBox()
        Me.CheckPrecio = New System.Windows.Forms.CheckBox()
        Me.CheckFecha = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkfuerzaventa = New System.Windows.Forms.CheckBox()
        Me.chkptoventa = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ttickfac2 = New System.Windows.Forms.TextBox()
        Me.txtPlanilla01 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPlanilla02 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPlanilla03 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPlanilla04 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ttickbol2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tpedido2 = New System.Windows.Forms.TextBox()
        Me.ChkClieVarios = New System.Windows.Forms.CheckBox()
        Me.txtClienteVarios = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CheckPromociones = New System.Windows.Forms.CheckBox()
        Me.txtPrePlanilla = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tresponsable = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tntacredB = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tnotadebB = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(720, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 224)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(23, 154)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 23)
        Me.btnreporte.TabIndex = 5
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(23, 127)
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
        Me.BTNCERRAR.Location = New System.Drawing.Point(23, 181)
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
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(23, 73)
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
        Me.BTNELIMINAR.Location = New System.Drawing.Point(23, 100)
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
        Me.BTNNUEVO.Location = New System.Drawing.Point(23, 19)
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
        Me.BTNGUARDAR.Location = New System.Drawing.Point(23, 46)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.ItemSize = New System.Drawing.Size(250, 18)
        Me.TabControl1.Location = New System.Drawing.Point(16, 6)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(698, 456)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'tptoventa
        '
        Me.tptoventa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tptoventa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tptoventa.Location = New System.Drawing.Point(140, 18)
        Me.tptoventa.MaxLength = 16
        Me.tptoventa.Name = "tptoventa"
        Me.tptoventa.Size = New System.Drawing.Size(168, 21)
        Me.tptoventa.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(56, 274)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Numero Guia :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumGuia
        '
        Me.txtNumGuia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumGuia.Location = New System.Drawing.Point(140, 272)
        Me.txtNumGuia.MaxLength = 10
        Me.txtNumGuia.Name = "txtNumGuia"
        Me.txtNumGuia.Size = New System.Drawing.Size(112, 21)
        Me.txtNumGuia.TabIndex = 22
        Me.txtNumGuia.Text = "0"
        Me.txtNumGuia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tserie
        '
        Me.tserie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tserie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tserie.Location = New System.Drawing.Point(140, 44)
        Me.tserie.MaxLength = 16
        Me.tserie.Name = "tserie"
        Me.tserie.Size = New System.Drawing.Size(168, 21)
        Me.tserie.TabIndex = 6
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(56, 144)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(75, 13)
        Me.label.TabIndex = 11
        Me.label.Text = "Tipo Precio 1 :"
        Me.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtctaBanca
        '
        Me.txtctaBanca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtctaBanca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtctaBanca.ItemHeight = 13
        Me.txtctaBanca.Location = New System.Drawing.Point(140, 116)
        Me.txtctaBanca.Name = "txtctaBanca"
        Me.txtctaBanca.Size = New System.Drawing.Size(243, 21)
        Me.txtctaBanca.TabIndex = 10
        '
        'cprecio1
        '
        Me.cprecio1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cprecio1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cprecio1.ItemHeight = 13
        Me.cprecio1.Location = New System.Drawing.Point(140, 142)
        Me.cprecio1.Name = "cprecio1"
        Me.cprecio1.Size = New System.Drawing.Size(243, 21)
        Me.cprecio1.TabIndex = 12
        '
        'cprecio2
        '
        Me.cprecio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cprecio2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cprecio2.ItemHeight = 13
        Me.cprecio2.Location = New System.Drawing.Point(140, 168)
        Me.cprecio2.Name = "cprecio2"
        Me.cprecio2.Size = New System.Drawing.Size(243, 21)
        Me.cprecio2.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(78, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Terminal :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(96, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Zona :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nro Serie :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro Tienda Pto Venta :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(308, 16)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tterminal
        '
        Me.tterminal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tterminal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tterminal.Location = New System.Drawing.Point(140, 70)
        Me.tterminal.MaxLength = 25
        Me.tterminal.Name = "tterminal"
        Me.tterminal.Size = New System.Drawing.Size(168, 21)
        Me.tterminal.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(56, 170)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(75, 13)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Tipo Precio 2 :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttickfac
        '
        Me.ttickfac.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttickfac.Location = New System.Drawing.Point(140, 194)
        Me.ttickfac.MaxLength = 10
        Me.ttickfac.Name = "ttickfac"
        Me.ttickfac.Size = New System.Drawing.Size(112, 21)
        Me.ttickfac.TabIndex = 16
        Me.ttickfac.Text = "0"
        Me.ttickfac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Numero Boleta :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Numero Factura :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttickbol
        '
        Me.ttickbol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttickbol.Location = New System.Drawing.Point(140, 220)
        Me.ttickbol.MaxLength = 10
        Me.ttickbol.Name = "ttickbol"
        Me.ttickbol.Size = New System.Drawing.Size(112, 21)
        Me.ttickbol.TabIndex = 18
        Me.ttickbol.Text = "0"
        Me.ttickbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Numero Nota Pedido :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tpedido
        '
        Me.tpedido.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpedido.Location = New System.Drawing.Point(140, 246)
        Me.tpedido.MaxLength = 10
        Me.tpedido.Name = "tpedido"
        Me.tpedido.Size = New System.Drawing.Size(112, 21)
        Me.tpedido.TabIndex = 20
        Me.tpedido.Text = "0"
        Me.tpedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tntacred
        '
        Me.tntacred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tntacred.Location = New System.Drawing.Point(140, 298)
        Me.tntacred.MaxLength = 10
        Me.tntacred.Name = "tntacred"
        Me.tntacred.Size = New System.Drawing.Size(112, 21)
        Me.tntacred.TabIndex = 24
        Me.tntacred.Text = "0"
        Me.tntacred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(11, 298)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(123, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Nro Nota Cred Factura :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tnotadeb
        '
        Me.tnotadeb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnotadeb.Location = New System.Drawing.Point(140, 348)
        Me.tnotadeb.MaxLength = 10
        Me.tnotadeb.Name = "tnotadeb"
        Me.tnotadeb.Size = New System.Drawing.Size(112, 21)
        Me.tnotadeb.TabIndex = 26
        Me.tnotadeb.Text = "0"
        Me.tnotadeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 351)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Nro Nota Deb Factura :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(20, 397)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(520, 28)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = resources.GetString("Label18.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(253, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Numero Guia Transp :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGuiTran
        '
        Me.txtGuiTran.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuiTran.Location = New System.Drawing.Point(375, 365)
        Me.txtGuiTran.MaxLength = 10
        Me.txtGuiTran.Name = "txtGuiTran"
        Me.txtGuiTran.Size = New System.Drawing.Size(112, 21)
        Me.txtGuiTran.TabIndex = 29
        Me.txtGuiTran.Text = "0"
        Me.txtGuiTran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckPrecio
        '
        Me.CheckPrecio.Location = New System.Drawing.Point(458, 9)
        Me.CheckPrecio.Name = "CheckPrecio"
        Me.CheckPrecio.Size = New System.Drawing.Size(178, 43)
        Me.CheckPrecio.TabIndex = 0
        Me.CheckPrecio.Text = "Edita Precio en Facturacion y Pedidos"
        '
        'CheckFecha
        '
        Me.CheckFecha.Location = New System.Drawing.Point(458, 55)
        Me.CheckFecha.Name = "CheckFecha"
        Me.CheckFecha.Size = New System.Drawing.Size(158, 16)
        Me.CheckFecha.TabIndex = 4
        Me.CheckFecha.Text = "Edita Fecha en Facturacion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkptoventa)
        Me.GroupBox1.Controls.Add(Me.chkfuerzaventa)
        Me.GroupBox1.Location = New System.Drawing.Point(265, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 87)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modo Presentaciòn"
        '
        'chkfuerzaventa
        '
        Me.chkfuerzaventa.Location = New System.Drawing.Point(20, 54)
        Me.chkfuerzaventa.Name = "chkfuerzaventa"
        Me.chkfuerzaventa.Size = New System.Drawing.Size(116, 16)
        Me.chkfuerzaventa.TabIndex = 1
        Me.chkfuerzaventa.Text = "Fuerza Venta"
        '
        'chkptoventa
        '
        Me.chkptoventa.Location = New System.Drawing.Point(20, 36)
        Me.chkptoventa.Name = "chkptoventa"
        Me.chkptoventa.Size = New System.Drawing.Size(116, 16)
        Me.chkptoventa.TabIndex = 0
        Me.chkptoventa.Text = "Punto de Venta"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(431, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Numero Factura 2  :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttickfac2
        '
        Me.ttickfac2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttickfac2.Location = New System.Drawing.Point(536, 112)
        Me.ttickfac2.MaxLength = 10
        Me.ttickfac2.Name = "ttickfac2"
        Me.ttickfac2.Size = New System.Drawing.Size(112, 21)
        Me.ttickfac2.TabIndex = 32
        Me.ttickfac2.Text = "0"
        Me.ttickfac2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPlanilla01
        '
        Me.txtPlanilla01.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanilla01.Location = New System.Drawing.Point(535, 185)
        Me.txtPlanilla01.MaxLength = 10
        Me.txtPlanilla01.Name = "txtPlanilla01"
        Me.txtPlanilla01.Size = New System.Drawing.Size(112, 21)
        Me.txtPlanilla01.TabIndex = 34
        Me.txtPlanilla01.Text = "0"
        Me.txtPlanilla01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(445, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Nro Planilla 01 :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPlanilla02
        '
        Me.txtPlanilla02.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanilla02.Location = New System.Drawing.Point(535, 211)
        Me.txtPlanilla02.MaxLength = 10
        Me.txtPlanilla02.Name = "txtPlanilla02"
        Me.txtPlanilla02.Size = New System.Drawing.Size(112, 21)
        Me.txtPlanilla02.TabIndex = 36
        Me.txtPlanilla02.Text = "0"
        Me.txtPlanilla02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(447, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Nro Planilla 02 :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(448, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Nro Planilla 03 :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPlanilla03
        '
        Me.txtPlanilla03.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanilla03.Location = New System.Drawing.Point(535, 237)
        Me.txtPlanilla03.MaxLength = 10
        Me.txtPlanilla03.Name = "txtPlanilla03"
        Me.txtPlanilla03.Size = New System.Drawing.Size(112, 21)
        Me.txtPlanilla03.TabIndex = 38
        Me.txtPlanilla03.Text = "0"
        Me.txtPlanilla03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(448, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Nro Planilla 04 :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPlanilla04
        '
        Me.txtPlanilla04.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlanilla04.Location = New System.Drawing.Point(535, 260)
        Me.txtPlanilla04.MaxLength = 10
        Me.txtPlanilla04.Name = "txtPlanilla04"
        Me.txtPlanilla04.Size = New System.Drawing.Size(112, 21)
        Me.txtPlanilla04.TabIndex = 40
        Me.txtPlanilla04.Text = "0"
        Me.txtPlanilla04.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(438, 138)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Numero Boleta 2  :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ttickbol2
        '
        Me.ttickbol2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttickbol2.Location = New System.Drawing.Point(536, 135)
        Me.ttickbol2.MaxLength = 10
        Me.ttickbol2.Name = "ttickbol2"
        Me.ttickbol2.Size = New System.Drawing.Size(112, 21)
        Me.ttickbol2.TabIndex = 42
        Me.ttickbol2.Text = "0"
        Me.ttickbol2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(413, 159)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Numero Nota Pedido 2 :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tpedido2
        '
        Me.tpedido2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpedido2.Location = New System.Drawing.Point(536, 156)
        Me.tpedido2.MaxLength = 10
        Me.tpedido2.Name = "tpedido2"
        Me.tpedido2.Size = New System.Drawing.Size(112, 21)
        Me.tpedido2.TabIndex = 44
        Me.tpedido2.Text = "0"
        Me.tpedido2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkClieVarios
        '
        Me.ChkClieVarios.Location = New System.Drawing.Point(536, 361)
        Me.ChkClieVarios.Name = "ChkClieVarios"
        Me.ChkClieVarios.Size = New System.Drawing.Size(116, 16)
        Me.ChkClieVarios.TabIndex = 45
        Me.ChkClieVarios.Text = "Cliente Varios"
        '
        'txtClienteVarios
        '
        Me.txtClienteVarios.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteVarios.Location = New System.Drawing.Point(536, 318)
        Me.txtClienteVarios.MaxLength = 10
        Me.txtClienteVarios.Name = "txtClienteVarios"
        Me.txtClienteVarios.Size = New System.Drawing.Size(112, 21)
        Me.txtClienteVarios.TabIndex = 47
        Me.txtClienteVarios.Text = "0"
        Me.txtClienteVarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(455, 326)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Cliente Varios :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckPromociones
        '
        Me.CheckPromociones.Location = New System.Drawing.Point(458, 77)
        Me.CheckPromociones.Name = "CheckPromociones"
        Me.CheckPromociones.Size = New System.Drawing.Size(211, 29)
        Me.CheckPromociones.TabIndex = 48
        Me.CheckPromociones.Text = "Activar Promociones en Facturacion"
        '
        'txtPrePlanilla
        '
        Me.txtPrePlanilla.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrePlanilla.Location = New System.Drawing.Point(535, 287)
        Me.txtPrePlanilla.MaxLength = 10
        Me.txtPrePlanilla.Name = "txtPrePlanilla"
        Me.txtPrePlanilla.Size = New System.Drawing.Size(112, 21)
        Me.txtPrePlanilla.TabIndex = 49
        Me.txtPrePlanilla.Text = "0"
        Me.txtPrePlanilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(448, 295)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 13)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Nro PrePlanilla :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tresponsable
        '
        Me.tresponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tresponsable.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tresponsable.Location = New System.Drawing.Point(140, 92)
        Me.tresponsable.MaxLength = 10000
        Me.tresponsable.Name = "tresponsable"
        Me.tresponsable.Size = New System.Drawing.Size(274, 21)
        Me.tresponsable.TabIndex = 51
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(58, 94)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(75, 13)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "Responsable :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tntacredB
        '
        Me.tntacredB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tntacredB.Location = New System.Drawing.Point(140, 323)
        Me.tntacredB.MaxLength = 10
        Me.tntacredB.Name = "tntacredB"
        Me.tntacredB.Size = New System.Drawing.Size(112, 21)
        Me.tntacredB.TabIndex = 57
        Me.tntacredB.Text = "0"
        Me.tntacredB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(17, 327)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 13)
        Me.Label24.TabIndex = 58
        Me.Label24.Text = "Nro Nota Cred Boleta:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.tnotadebB)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.tntacredB)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.tresponsable)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txtPrePlanilla)
        Me.TabPage1.Controls.Add(Me.CheckPromociones)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.txtClienteVarios)
        Me.TabPage1.Controls.Add(Me.ChkClieVarios)
        Me.TabPage1.Controls.Add(Me.tpedido2)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.ttickbol2)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtPlanilla04)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtPlanilla03)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtPlanilla02)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtPlanilla01)
        Me.TabPage1.Controls.Add(Me.ttickfac2)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.CheckFecha)
        Me.TabPage1.Controls.Add(Me.CheckPrecio)
        Me.TabPage1.Controls.Add(Me.txtGuiTran)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.tnotadeb)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.tntacred)
        Me.TabPage1.Controls.Add(Me.tpedido)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.ttickbol)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ttickfac)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.tterminal)
        Me.TabPage1.Controls.Add(Me.btnbuscar)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.cprecio2)
        Me.TabPage1.Controls.Add(Me.cprecio1)
        Me.TabPage1.Controls.Add(Me.txtctaBanca)
        Me.TabPage1.Controls.Add(Me.label)
        Me.TabPage1.Controls.Add(Me.tserie)
        Me.TabPage1.Controls.Add(Me.txtNumGuia)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.tptoventa)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(690, 430)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        '
        'tnotadebB
        '
        Me.tnotadebB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnotadebB.Location = New System.Drawing.Point(140, 371)
        Me.tnotadebB.MaxLength = 10
        Me.tnotadebB.Name = "tnotadebB"
        Me.tnotadebB.Size = New System.Drawing.Size(112, 21)
        Me.tnotadebB.TabIndex = 59
        Me.tnotadebB.Text = "0"
        Me.tnotadebB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(21, 377)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 13)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Nro Nota Deb Boleta:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ptoventa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.BTNCERRAR
        Me.ClientSize = New System.Drawing.Size(984, 455)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "ptoventa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Puntos de Venta"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim FLAG As Integer
    Dim GrsConfigPto As DataTable
    Dim epwcierre, efac, ebol, eptoactivo, eimp, esalto, esalv, eclave, eclavedoc, ecierre, egaveta, ecantprod, eeditprecio, edisplay, eimpuesto, eticketimp, edocimp, enotcred As Single



    Sub cargadatos()
        Try
            CAyuda.CargarDataCombo(cprecio1, "Nsp_Sele_tipopre '" & codempresa & "'", "codtipopre", "dstipopre")
            CAyuda.CargarDataCombo(cprecio2, "Nsp_Sele_tipopre '" & codempresa & "'", "codtipopre", "dstipopre")
            CAyuda.CargarDataCombo(txtctaBanca, "Nsp_Select_Zona '" & codempresa & "'", "codzona", "deszona")

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

        If FLAG = 0 Then
            Call Limpiatextbox(Me)
            Call BOTONES(True, False, False, False, True)
        Else
            Call BOTONES(True, False, True, True, True)
        End If

        limpia()
        Call bloquea(True, False)
        BTNCANCELAR.Enabled = False
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR
    End Sub


    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            If Len(Me.tptoventa.Text.Trim) = 0 Then
                MsgBox("No Selecciono Ningun Registro Para Eliminar" & Chr(13) & "Intente de Nuevo Por Favor", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If


            Dim PROCESO As Boolean
            Dim sql As String
            sql = "nsp_dele_ptoventa '" & tptoventa.Text & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = False Then Exit Sub
            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)


            limpia()
            Call Limpiatextbox(Me)
            tptoventa.Text = ""


        End If


    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call bloquea(False, True)
        tptoventa.Enabled = False
        Call BOTONES(False, True, False, False, True)
        FLAG = 1
        BTNCANCELAR.Enabled = True
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click


        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call bloquea(False, True)
        Call BOTONES(False, True, False, False, False)
        FLAG = 0
        limpia()
        BTNCANCELAR.Enabled = True
        tptoventa.Enabled = True
        tptoventa.Focus()

        tptoventa.Text = ""


    End Sub


    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        If tntacred.Text.Trim.Length < 8 And tntacred.Text.Trim.Length > 1 Then
            MessageBox.Show("El correlativo para nota de crèdito como mínimo debe tener 8 dígitos. 7 de correlativo y uno o tres para la serie. Si no desea ingresar un correlativo de Nota de Crédito para este Punto de Venta ponga 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If tnotadeb.Text.Trim.Length < 8 And tnotadeb.Text.Trim.Length > 1 Then
            MessageBox.Show("El correlativo para nota de dèbito como mínimo debe tener 8 dígitos. 7 de correlativo y uno o tres para la serie. Si no desea ingresar un correlativo de Nota de Débito para este Punto de Venta ponga 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If ttickfac.Text.Trim.Length < 8 And ttickfac.Text.Trim.Length > 1 Then
            MessageBox.Show("El correlativo para el Ticket Factura como mínimo debe tener 8 dígitos. 7 de correlativo y uno o tres para la serie. Si no desea ingresar un correlativo de Ticket Factura para este Punto de Venta ponga 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If ttickbol.Text.Trim.Length < 8 And ttickbol.Text.Trim.Length > 1 Then
            MessageBox.Show("El correlativo para el Ticket Boleta como mínimo debe tener 8 dígitos. 7 de correlativo y uno o tres para la serie. Si no desea ingresar un correlativo de Ticket Boleta para este Punto de Venta ponga 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim sql As String
        Call formatotextbox(Me)

        If ttickfac.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Ticket de Factura Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf ttickbol.Text.Trim = "" Then
            MessageBox.Show("Ingrese el ticket de la Boleta Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tpedido.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Nro de Pedido Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tntacred.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Nro de Nota de Crédito Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf Me.tnotadeb.Text.Trim = "" Then
            MessageBox.Show("Ingrese el Nro de Nota de Débito Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        If FLAG = 0 Then

            If TmpListarDatos("select * from PTOVTA where codempresa='" & codempresa.Trim & "' and nroptovta='" & tptoventa.Text & "'").Rows.Count > 0 Then
                MsgBox("EL PTOVTA YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If


            sql = "NSP_ins_PTOVENTA '" & tptoventa.Text & "','" & tserie.Text & "','" & tterminal.Text & "','" & txtctaBanca.SelectedValue.ToString & "','" & cprecio1.SelectedValue.ToString & "','" & cprecio2.SelectedValue.ToString & "'," &
                   Me.ttickfac.Text & "," & Me.ttickbol.Text & "," & tpedido.Text & "," & txtNumGuia.Text & "," & tntacred.Text & "," & tnotadeb.Text & "," & txtGuiTran.Text & ",'" & codempresa.Trim & "'," & IIf(CheckPrecio.Checked = True, 1, 0) & "," & IIf(CheckFecha.Checked = True, 1, 0) & "," & IIf(Me.chkptoventa.Checked = True, 1, 0) & "," & IIf(Me.chkfuerzaventa.Checked = True, 1, 0) & "," & ttickfac2.Text & "," & txtPlanilla01.Text & "," & txtPlanilla02.Text & "," & txtPlanilla03.Text & "," & txtPlanilla04.Text & "," & ttickbol2.Text & "," & tpedido2.Text & "," & txtClienteVarios.Text & "," & IIf(ChkClieVarios.Checked = True, 1, 0) & "," & IIf(CheckPromociones.Checked = True, 1, 0) & "," & txtPrePlanilla.Text & ",'" & tresponsable.Text & "','" & tntacredB.Text & "','" & tnotadebB.Text & "'"
            If TmpInsertDatos(sql) = True Then
                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)
                bloquea(True, False)
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            End If
        End If


        If FLAG = 1 Then
            sql = "NSP_upd_PTOVENTA '" & tptoventa.Text & "','" & tserie.Text & "','" & tterminal.Text & "','" & txtctaBanca.SelectedValue.ToString & "','" & cprecio1.SelectedValue.ToString & "','" & cprecio2.SelectedValue.ToString & "'," &
                   Me.ttickfac.Text & "," & Me.ttickbol.Text & "," & tpedido.Text & "," & txtNumGuia.Text & "," & tntacred.Text & "," & tnotadeb.Text & "," & txtGuiTran.Text & ",'" & codempresa.Trim & "'," & IIf(CheckPrecio.Checked = True, 1, 0) & "," & IIf(CheckFecha.Checked = True, 1, 0) & ", " & IIf(Me.chkptoventa.Checked = True, 1, 0) & "," & IIf(Me.chkfuerzaventa.Checked = True, 1, 0) & "," & ttickfac2.Text & "," & txtPlanilla01.Text & "," & txtPlanilla02.Text & "," & txtPlanilla03.Text & "," & txtPlanilla04.Text & "," & ttickbol2.Text & "," & tpedido2.Text & "," & txtClienteVarios.Text & "," & IIf(ChkClieVarios.Checked = True, 1, 0) & "," & IIf(CheckPromociones.Checked = True, 1, 0) & "," & txtPrePlanilla.Text & ",'" & tresponsable.Text & "','" & tntacredB.Text & "','" & tnotadebB.Text & "'"
            If TmpInsertDatos(sql) = True Then
                Call BOTONES(True, False, False, False, True)
                Bloqueatextbox(Me)
                bloquea(True, False)
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

            End If
        End If

        tptoventa.Enabled = False
        BTNCANCELAR.Enabled = False

        limpia()
        Call Limpiatextbox(Me)
        tptoventa.Text = ""


        MessageBox.Show("SE REINICIARA EL SISTEMA PARA QUE LOS CAMBIOS TENGAN EFECTO", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End


    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        Call BOTONES(True, False, True, True, True)
        tptoventa.Enabled = False
        bloquea(True, False)

        'Dim FRMX As New FRM_GRIDPTOVTA
        'FRMX.vie = Me
        'FRMX.ShowDialog()
        Dim FRMX As New FrmListarPtovta
        FRMX.ShowDialog()
        tptoventa.Text = FRMX.DgArticulo.Item(FRMX.DgArticulo.CurrentRowIndex, 0)
        GrsConfigPto = CAyuda.ListarDatos("NSP_SELECT_LISTAPTOVTA", codempresa.ToString(), tptoventa.Text).Tables(0)
        asigna_campos()

    End Sub


    Dim v1, v2 As Int16

    Private Sub ptoventa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        v1 = 0
        v2 = 0


        Call BOTONES(True, False, False, False, True)
        Call cargadatos()
        GrsConfigPto = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGPTOVTA1", codempresa.ToString()).Tables(0)
        asigna_campos()
        BTNCANCELAR.Enabled = False
        bloquea(True, False)

        limpia()
        Call Limpiatextbox(Me)
        tptoventa.Text = ""

    End Sub

    Sub bloquea(ByVal p As Boolean, ByVal p1 As Boolean)

        tserie.ReadOnly = p
        tterminal.ReadOnly = p
        tptoventa.ReadOnly = p
        tresponsable.ReadOnly = p

        txtctaBanca.Enabled = p1
        cprecio1.Enabled = p1
        cprecio2.Enabled = p1

        ttickfac.ReadOnly = p
        ttickbol.ReadOnly = p

        tntacred.ReadOnly = p
        tnotadeb.ReadOnly = p
        tpedido.ReadOnly = p
        txtNumGuia.ReadOnly = p
        txtGuiTran.ReadOnly = p


        ttickfac2.ReadOnly = p
        ttickbol2.ReadOnly = p
        tpedido2.ReadOnly = p
        txtPlanilla01.ReadOnly = p
        txtPlanilla02.ReadOnly = p
        txtPlanilla03.ReadOnly = p
        txtPlanilla04.ReadOnly = p
        txtClienteVarios.ReadOnly = p
        txtPrePlanilla.ReadOnly = p

        CheckPrecio.Enabled = p1
        CheckFecha.Enabled = p1
        chkptoventa.Enabled = p1
        chkfuerzaventa.Enabled = p1

        ChkClieVarios.Enabled = p1
        CheckPromociones.Enabled = p1

    End Sub

    Sub limpia()

        tptoventa.Text = ""
        tserie.Text = ""
        tterminal.Text = ""
        ttickfac.Text = "0"
        ttickbol.Text = "0"
        tntacred.Text = "0"
        tpedido.Text = "0"
        txtNumGuia.Text = "0"
        tnotadeb.Text = "0"
        txtGuiTran.Text = "0"
        tresponsable.Text = ""

        Me.chkptoventa.Checked = False
        Me.chkfuerzaventa.Checked = False

        Me.CheckPrecio.Checked = False
        Me.CheckFecha.Checked = False

        ttickfac2.Text = "0"
        ttickbol2.Text = "0"
        tpedido2.Text = "0"
        txtPlanilla01.Text = "0"
        txtPlanilla02.Text = "0"
        txtPlanilla03.Text = "0"
        txtPlanilla04.Text = "0"
        txtClienteVarios.Text = "0"

        txtPrePlanilla.Text = "0"
        ChkClieVarios.Checked = False
        CheckPromociones.Checked = False

        tnotadebB.Text = "0"
        tntacredB.Text = "0"

    End Sub

    Private Sub tptoventa_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            tserie.Focus()
            tserie.SelectAll()
        End If
    End Sub


    Private Sub tserie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tserie.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tterminal.Focus()
            tterminal.SelectAll()
        End If
    End Sub

    Private Sub tterminal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tterminal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtctaBanca.Focus()
        End If
    End Sub

    Private Sub czona_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtctaBanca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cprecio1.Focus()
        End If
    End Sub

    Private Sub cprecio1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cprecio1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cprecio2.Focus()
        End If
    End Sub


    Private Sub cprecio2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cprecio2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.ttickfac.Focus()
            Me.ttickfac.SelectAll()
        End If
    End Sub

    Private Sub ttickfac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ttickfac.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ttickfac.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.ttickbol.Focus()
            Me.ttickbol.SelectAll()
        End If
    End Sub

    Private Sub ttickbol_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ttickbol.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ttickbol.Focus()
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.tpedido.Focus()
            Me.tpedido.SelectAll()
        End If


    End Sub

    Private Sub tntacred_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tntacred.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tntacred.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tnotadeb.Focus()
            Me.tnotadeb.SelectAll()
        End If
    End Sub

    Private Sub tpedido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tpedido.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tpedido.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            txtNumGuia.Focus()
            txtNumGuia.SelectAll()
        End If

    End Sub

    Private Sub trutadoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub tnotadeb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnotadeb.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tnotadeb.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.txtGuiTran.Focus()
            Me.txtGuiTran.SelectAll()
        End If

    End Sub
    Private Sub asigna_campos()
        Try
            If GrsConfigPto.Rows.Count <> 0 Then
                tptoventa.Text = GrsConfigPto.Rows(0)("NROPTOVTA")
                tserie.Text = GrsConfigPto.Rows(0)("NROSERIE")
                tterminal.Text = GrsConfigPto.Rows(0)("TERMINAL")
                txtctaBanca.SelectedValue = GrsConfigPto.Rows(0)("CDZONA")
                cprecio1.SelectedValue = GrsConfigPto.Rows(0)("CDTIPOPRE1")
                cprecio2.SelectedValue = GrsConfigPto.Rows(0)("CDTIPOPRE2")
                ttickfac.Text = GrsConfigPto.Rows(0)("NROTICKFAC")
                ttickbol.Text = GrsConfigPto.Rows(0)("NROTICKBOL")
                tpedido.Text = GrsConfigPto.Rows(0)("NROPEDIDO")
                txtNumGuia.Text = GrsConfigPto.Rows(0)("NROGUIA")
                tntacred.Text = GrsConfigPto.Rows(0)("NRONTACRED")
                tnotadeb.Text = GrsConfigPto.Rows(0)("NRONTADEBI")
                txtGuiTran.Text = GrsConfigPto.Rows(0)("NROGUIATRAN")
                CheckPrecio.Checked = GrsConfigPto.Rows(0)("EDITPRECIO")
                CheckFecha.Checked = GrsConfigPto.Rows(0)("EDITFECHA")
                Me.chkptoventa.Checked = GrsConfigPto.Rows(0)("CPTOVENTA")
                Me.chkfuerzaventa.Checked = GrsConfigPto.Rows(0)("CFUERZAVENT")


                ttickfac2.Text = GrsConfigPto.Rows(0)("NROTICKFAC2")
                txtPlanilla01.Text = GrsConfigPto.Rows(0)("NROPLANILLA01")
                txtPlanilla02.Text = GrsConfigPto.Rows(0)("NROPLANILLA02")
                txtPlanilla03.Text = GrsConfigPto.Rows(0)("NROPLANILLA03")
                txtPlanilla04.Text = GrsConfigPto.Rows(0)("NROPLANILLA04")

                ttickbol2.Text = GrsConfigPto.Rows(0)("NROTICKBOL2")
                tpedido2.Text = GrsConfigPto.Rows(0)("NROPEDIDO2")

                txtClienteVarios.Text = GrsConfigPto.Rows(0)("CLIENTEVARIOS")
                ChkClieVarios.Checked = GrsConfigPto.Rows(0)("CHECKCLIE")
                CheckPromociones.Checked = GrsConfigPto.Rows(0)("CHECKPROMO")

                txtPrePlanilla.Text = GrsConfigPto.Rows(0)("NROPREPLANILLA")
                tresponsable.Text = GrsConfigPto.Rows(0)("RESPONABLE")

                tntacredB.Text = GrsConfigPto.Rows(0)("NRONTACREDB")
                tnotadebB.Text = GrsConfigPto.Rows(0)("NRONTADEBITB")


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tptoventa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub tptoventa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tptoventa.TextChanged

    End Sub

    Private Sub ttickbol_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ttickbol.TextChanged

    End Sub

    Private Sub tpedido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tpedido.TextChanged

    End Sub

    Private Sub tntacred_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tntacred.TextChanged

    End Sub

    Private Sub tnotadeb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tnotadeb.TextChanged

    End Sub

    Private Sub txtGuiTran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuiTran.TextChanged

    End Sub

    Private Sub txtGuiTran_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGuiTran.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtGuiTran.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub txtNumGuia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumGuia.TextChanged

    End Sub

    Private Sub txtNumGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumGuia.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtNumGuia.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tntacred.Focus()
            Me.tntacred.SelectAll()
        End If
    End Sub

    Private Sub tptoventa_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tptoventa.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tserie.Focus()
        End If
    End Sub

    Private Sub tserie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tserie.TextChanged

    End Sub

    Private Sub CheckFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckFecha.CheckedChanged

    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click

    End Sub
End Class

