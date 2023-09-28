Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmConfigVta
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ChecPuntosBonus As System.Windows.Forms.CheckBox
    Friend WithEvents CheckActProm As System.Windows.Forms.CheckBox
    Friend WithEvents txtidimpisc As System.Windows.Forms.TextBox
    Friend WithEvents txtidimpigv As System.Windows.Forms.TextBox
    Friend WithEvents txtcdbal As System.Windows.Forms.TextBox
    Friend WithEvents txtrecibo As System.Windows.Forms.TextBox
    Friend WithEvents txtcobranza As System.Windows.Forms.TextBox
    Friend WithEvents txtpago As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumCumProm As System.Windows.Forms.TextBox
    Friend WithEvents TxtMonTickProm As System.Windows.Forms.TextBox
    Friend WithEvents CMBTICKET As System.Windows.Forms.ComboBox
    Friend WithEvents CMBFACTURA As System.Windows.Forms.ComboBox
    Friend WithEvents CMBBOLETA As System.Windows.Forms.ComboBox
    Friend WithEvents CMBNOTCRED As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbonotadeb As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmboperador As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNroitemFact As System.Windows.Forms.TextBox
    Friend WithEvents txtNroitemGuia As System.Windows.Forms.TextBox
    Friend WithEvents txtNroitemNotCred As System.Windows.Forms.TextBox
    Friend WithEvents txtNroitemBol As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCodclienteVarios As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtMontoBoleta As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TXTDIGIDNI As System.Windows.Forms.TextBox
    Friend WithEvents TXTDIGIRUC As System.Windows.Forms.TextBox
    Friend WithEvents TxtUit As System.Windows.Forms.TextBox
    Friend WithEvents UIT As System.Windows.Forms.Label
    Friend WithEvents ChkDescargaAlmacen As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtVigenciaPedido As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ckFecVarFact As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmbcredito As System.Windows.Forms.ComboBox
    Friend WithEvents cmbefectivo As System.Windows.Forms.ComboBox
    Friend WithEvents txtcodnextel As System.Windows.Forms.TextBox
    Friend WithEvents cmbpercep As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cmbretencion As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtFacturaM As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtBoletaM As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtNotaPedM As System.Windows.Forms.TextBox
    Friend WithEvents txtArtiTransp As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigVta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChecPuntosBonus = New System.Windows.Forms.CheckBox()
        Me.CheckActProm = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtidimpisc = New System.Windows.Forms.TextBox()
        Me.txtidimpigv = New System.Windows.Forms.TextBox()
        Me.txtcdbal = New System.Windows.Forms.TextBox()
        Me.txtrecibo = New System.Windows.Forms.TextBox()
        Me.txtcobranza = New System.Windows.Forms.TextBox()
        Me.txtpago = New System.Windows.Forms.TextBox()
        Me.TxtNumCumProm = New System.Windows.Forms.TextBox()
        Me.TxtMonTickProm = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnreporte = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.CMBTICKET = New System.Windows.Forms.ComboBox()
        Me.CMBFACTURA = New System.Windows.Forms.ComboBox()
        Me.CMBBOLETA = New System.Windows.Forms.ComboBox()
        Me.CMBNOTCRED = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbcredito = New System.Windows.Forms.ComboBox()
        Me.cmbefectivo = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.txtcodnextel = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ckFecVarFact = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtVigenciaPedido = New System.Windows.Forms.TextBox()
        Me.ChkDescargaAlmacen = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtMontoBoleta = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCodclienteVarios = New System.Windows.Forms.TextBox()
        Me.cmbpercep = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmbretencion = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cmboperador = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbonotadeb = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNroitemFact = New System.Windows.Forms.TextBox()
        Me.txtNroitemGuia = New System.Windows.Forms.TextBox()
        Me.txtNroitemNotCred = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNroitemBol = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TXTDIGIDNI = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TXTDIGIRUC = New System.Windows.Forms.TextBox()
        Me.UIT = New System.Windows.Forms.Label()
        Me.TxtUit = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtFacturaM = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtBoletaM = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtNotaPedM = New System.Windows.Forms.TextBox()
        Me.txtArtiTransp = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código IGV :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código ISC :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Código Ticket :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Código Factura :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(66, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Código Boleta :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Código NtaCred :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 290)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Dígito Balanza :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Nro Recibo Pendiente :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(66, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Nro Cobranza :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Nro Recibo Proveedor :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChecPuntosBonus
        '
        Me.ChecPuntosBonus.Location = New System.Drawing.Point(35, 618)
        Me.ChecPuntosBonus.Name = "ChecPuntosBonus"
        Me.ChecPuntosBonus.Size = New System.Drawing.Size(136, 16)
        Me.ChecPuntosBonus.TabIndex = 68
        Me.ChecPuntosBonus.Text = "Activar Puntos Bonus"
        Me.ChecPuntosBonus.Visible = False
        '
        'CheckActProm
        '
        Me.CheckActProm.Location = New System.Drawing.Point(177, 620)
        Me.CheckActProm.Name = "CheckActProm"
        Me.CheckActProm.Size = New System.Drawing.Size(168, 16)
        Me.CheckActProm.TabIndex = 69
        Me.CheckActProm.Text = "Activar Promocion Cupones"
        Me.CheckActProm.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 410)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Monto Ticket Promoción :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 386)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 13)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Nro Cupones Promoción :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtidimpisc
        '
        Me.txtidimpisc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidimpisc.Location = New System.Drawing.Point(152, 48)
        Me.txtidimpisc.Name = "txtidimpisc"
        Me.txtidimpisc.Size = New System.Drawing.Size(112, 21)
        Me.txtidimpisc.TabIndex = 3
        '
        'txtidimpigv
        '
        Me.txtidimpigv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtidimpigv.Location = New System.Drawing.Point(152, 24)
        Me.txtidimpigv.Name = "txtidimpigv"
        Me.txtidimpigv.Size = New System.Drawing.Size(112, 21)
        Me.txtidimpigv.TabIndex = 1
        '
        'txtcdbal
        '
        Me.txtcdbal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcdbal.Location = New System.Drawing.Point(152, 288)
        Me.txtcdbal.Name = "txtcdbal"
        Me.txtcdbal.Size = New System.Drawing.Size(112, 21)
        Me.txtcdbal.TabIndex = 23
        '
        'txtrecibo
        '
        Me.txtrecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrecibo.Location = New System.Drawing.Point(152, 312)
        Me.txtrecibo.Name = "txtrecibo"
        Me.txtrecibo.Size = New System.Drawing.Size(112, 21)
        Me.txtrecibo.TabIndex = 26
        '
        'txtcobranza
        '
        Me.txtcobranza.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcobranza.Location = New System.Drawing.Point(152, 336)
        Me.txtcobranza.Name = "txtcobranza"
        Me.txtcobranza.Size = New System.Drawing.Size(112, 21)
        Me.txtcobranza.TabIndex = 30
        '
        'txtpago
        '
        Me.txtpago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpago.Location = New System.Drawing.Point(152, 360)
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Size = New System.Drawing.Size(112, 21)
        Me.txtpago.TabIndex = 34
        '
        'TxtNumCumProm
        '
        Me.TxtNumCumProm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNumCumProm.Location = New System.Drawing.Point(152, 384)
        Me.TxtNumCumProm.Name = "TxtNumCumProm"
        Me.TxtNumCumProm.Size = New System.Drawing.Size(112, 21)
        Me.TxtNumCumProm.TabIndex = 39
        '
        'TxtMonTickProm
        '
        Me.TxtMonTickProm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMonTickProm.Location = New System.Drawing.Point(152, 408)
        Me.TxtMonTickProm.Name = "TxtMonTickProm"
        Me.TxtMonTickProm.Size = New System.Drawing.Size(112, 21)
        Me.TxtMonTickProm.TabIndex = 44
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
        Me.btnreporte.Location = New System.Drawing.Point(448, 192)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(88, 26)
        Me.btnreporte.TabIndex = 21
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(352, 336)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNELIMINAR.TabIndex = 1
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNELIMINAR.Visible = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(448, 102)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(88, 28)
        Me.BTNCANCELAR.TabIndex = 10
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(448, 132)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(88, 28)
        Me.BTNCERRAR.TabIndex = 13
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(448, 42)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(88, 28)
        Me.BTNMODIFICAR.TabIndex = 4
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(448, 162)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(88, 28)
        Me.BTNNUEVO.TabIndex = 18
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNNUEVO.Visible = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(448, 72)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(88, 28)
        Me.BTNGUARDAR.TabIndex = 7
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CMBTICKET
        '
        Me.CMBTICKET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBTICKET.Location = New System.Drawing.Point(152, 72)
        Me.CMBTICKET.Name = "CMBTICKET"
        Me.CMBTICKET.Size = New System.Drawing.Size(216, 21)
        Me.CMBTICKET.TabIndex = 6
        '
        'CMBFACTURA
        '
        Me.CMBFACTURA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBFACTURA.Location = New System.Drawing.Point(152, 96)
        Me.CMBFACTURA.Name = "CMBFACTURA"
        Me.CMBFACTURA.Size = New System.Drawing.Size(216, 21)
        Me.CMBFACTURA.TabIndex = 9
        '
        'CMBBOLETA
        '
        Me.CMBBOLETA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBBOLETA.Location = New System.Drawing.Point(152, 120)
        Me.CMBBOLETA.Name = "CMBBOLETA"
        Me.CMBBOLETA.Size = New System.Drawing.Size(216, 21)
        Me.CMBBOLETA.TabIndex = 12
        '
        'CMBNOTCRED
        '
        Me.CMBNOTCRED.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBNOTCRED.Location = New System.Drawing.Point(152, 144)
        Me.CMBNOTCRED.Name = "CMBNOTCRED"
        Me.CMBNOTCRED.Size = New System.Drawing.Size(216, 21)
        Me.CMBNOTCRED.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.txtcodnextel)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.ckFecVarFact)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtVigenciaPedido)
        Me.GroupBox1.Controls.Add(Me.ChkDescargaAlmacen)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtMontoBoleta)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtCodclienteVarios)
        Me.GroupBox1.Controls.Add(Me.cmbpercep)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.Controls.Add(Me.cmbretencion)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.cmboperador)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbonotadeb)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtidimpisc)
        Me.GroupBox1.Controls.Add(Me.txtidimpigv)
        Me.GroupBox1.Controls.Add(Me.txtcdbal)
        Me.GroupBox1.Controls.Add(Me.txtrecibo)
        Me.GroupBox1.Controls.Add(Me.txtcobranza)
        Me.GroupBox1.Controls.Add(Me.txtpago)
        Me.GroupBox1.Controls.Add(Me.TxtNumCumProm)
        Me.GroupBox1.Controls.Add(Me.TxtMonTickProm)
        Me.GroupBox1.Controls.Add(Me.CMBTICKET)
        Me.GroupBox1.Controls.Add(Me.CMBFACTURA)
        Me.GroupBox1.Controls.Add(Me.CMBBOLETA)
        Me.GroupBox1.Controls.Add(Me.CMBNOTCRED)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ChecPuntosBonus)
        Me.GroupBox1.Controls.Add(Me.CheckActProm)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtNroitemFact)
        Me.GroupBox1.Controls.Add(Me.txtNroitemGuia)
        Me.GroupBox1.Controls.Add(Me.txtNroitemNotCred)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtNroitemBol)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TXTDIGIDNI)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.TXTDIGIRUC)
        Me.GroupBox1.Controls.Add(Me.UIT)
        Me.GroupBox1.Controls.Add(Me.TxtUit)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(546, 649)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.cmbcredito)
        Me.GroupBox2.Controls.Add(Me.cmbefectivo)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Location = New System.Drawing.Point(315, 508)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 78)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(12, 46)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 13)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Efectivo :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbcredito
        '
        Me.cmbcredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcredito.Location = New System.Drawing.Point(66, 22)
        Me.cmbcredito.Name = "cmbcredito"
        Me.cmbcredito.Size = New System.Drawing.Size(130, 21)
        Me.cmbcredito.TabIndex = 1
        '
        'cmbefectivo
        '
        Me.cmbefectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbefectivo.Location = New System.Drawing.Point(66, 44)
        Me.cmbefectivo.Name = "cmbefectivo"
        Me.cmbefectivo.Size = New System.Drawing.Size(130, 21)
        Me.cmbefectivo.TabIndex = 3
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Credito :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(349, 494)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(146, 16)
        Me.CheckBox1.TabIndex = 54
        Me.CheckBox1.Text = "Activar Precio Sin IGV"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(294, 292)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(115, 13)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "Nro Planilla Cobranza :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(314, 268)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 13)
        Me.Label28.TabIndex = 63
        Me.Label28.Text = "Nro Orden Venta :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(32, 578)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(114, 13)
        Me.Label27.TabIndex = 61
        Me.Label27.Text = "Nro Orden Despacho :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox5
        '
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Location = New System.Drawing.Point(415, 290)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(112, 21)
        Me.TextBox5.TabIndex = 66
        '
        'txtcodnextel
        '
        Me.txtcodnextel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodnextel.Location = New System.Drawing.Point(152, 264)
        Me.txtcodnextel.Name = "txtcodnextel"
        Me.txtcodnextel.Size = New System.Drawing.Size(112, 21)
        Me.txtcodnextel.TabIndex = 64
        '
        'TextBox4
        '
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Location = New System.Drawing.Point(415, 265)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 21)
        Me.TextBox4.TabIndex = 64
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Location = New System.Drawing.Point(152, 576)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(112, 21)
        Me.TextBox3.TabIndex = 62
        '
        'ckFecVarFact
        '
        Me.ckFecVarFact.Location = New System.Drawing.Point(349, 470)
        Me.ckFecVarFact.Name = "ckFecVarFact"
        Me.ckFecVarFact.Size = New System.Drawing.Size(146, 16)
        Me.ckFecVarFact.TabIndex = 51
        Me.ckFecVarFact.Text = "Editar Fecha Facturación"
        Me.ckFecVarFact.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Location = New System.Drawing.Point(415, 315)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 21)
        Me.TextBox2.TabIndex = 25
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(303, 316)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(106, 13)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "Venta Tienda Simp. :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(415, 340)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(112, 21)
        Me.TextBox1.TabIndex = 29
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(281, 340)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 13)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Nro.Doc. Reprocesados :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(490, 243)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 13)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "dias."
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(321, 364)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Vigencia Pedido :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVigenciaPedido
        '
        Me.txtVigenciaPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVigenciaPedido.Location = New System.Drawing.Point(415, 365)
        Me.txtVigenciaPedido.Name = "txtVigenciaPedido"
        Me.txtVigenciaPedido.Size = New System.Drawing.Size(80, 21)
        Me.txtVigenciaPedido.TabIndex = 33
        Me.txtVigenciaPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkDescargaAlmacen
        '
        Me.ChkDescargaAlmacen.Enabled = False
        Me.ChkDescargaAlmacen.Location = New System.Drawing.Point(343, 620)
        Me.ChkDescargaAlmacen.Name = "ChkDescargaAlmacen"
        Me.ChkDescargaAlmacen.Size = New System.Drawing.Size(168, 16)
        Me.ChkDescargaAlmacen.TabIndex = 70
        Me.ChkDescargaAlmacen.Text = "Activar Desacarg a Almacen"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(69, 554)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Monto Boleta :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoBoleta
        '
        Me.txtMontoBoleta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMontoBoleta.Location = New System.Drawing.Point(152, 552)
        Me.txtMontoBoleta.Name = "txtMontoBoleta"
        Me.txtMontoBoleta.Size = New System.Drawing.Size(112, 21)
        Me.txtMontoBoleta.TabIndex = 60
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(26, 530)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 13)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Codigo Clientes Varios :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodclienteVarios
        '
        Me.txtCodclienteVarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodclienteVarios.Location = New System.Drawing.Point(152, 528)
        Me.txtCodclienteVarios.Name = "txtCodclienteVarios"
        Me.txtCodclienteVarios.Size = New System.Drawing.Size(112, 21)
        Me.txtCodclienteVarios.TabIndex = 58
        '
        'cmbpercep
        '
        Me.cmbpercep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpercep.Location = New System.Drawing.Point(152, 240)
        Me.cmbpercep.Name = "cmbpercep"
        Me.cmbpercep.Size = New System.Drawing.Size(216, 21)
        Me.cmbpercep.TabIndex = 20
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(65, 266)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(81, 13)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Codigo Nextel :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(44, 242)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(102, 13)
        Me.Label33.TabIndex = 19
        Me.Label33.Text = "Codigo Percepsion :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbretencion
        '
        Me.cmbretencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbretencion.Location = New System.Drawing.Point(152, 216)
        Me.cmbretencion.Name = "cmbretencion"
        Me.cmbretencion.Size = New System.Drawing.Size(216, 21)
        Me.cmbretencion.TabIndex = 20
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(48, 218)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(98, 13)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "Codigo Retencion :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmboperador
        '
        Me.cmboperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboperador.Location = New System.Drawing.Point(152, 192)
        Me.cmboperador.Name = "cmboperador"
        Me.cmboperador.Size = New System.Drawing.Size(216, 21)
        Me.cmboperador.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 194)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Vendedor para Empleados :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbonotadeb
        '
        Me.cbonotadeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbonotadeb.Location = New System.Drawing.Point(152, 168)
        Me.cbonotadeb.Name = "cbonotadeb"
        Me.cbonotadeb.Size = New System.Drawing.Size(216, 21)
        Me.cbonotadeb.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(60, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Código NtaDeb :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 434)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Nro Item de Factura :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 458)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 13)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "Nro Item de Nota Ped. :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 482)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 13)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Nro Item  de Nota Credito :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNroitemFact
        '
        Me.txtNroitemFact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroitemFact.Location = New System.Drawing.Point(152, 432)
        Me.txtNroitemFact.Name = "txtNroitemFact"
        Me.txtNroitemFact.Size = New System.Drawing.Size(112, 21)
        Me.txtNroitemFact.TabIndex = 48
        '
        'txtNroitemGuia
        '
        Me.txtNroitemGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroitemGuia.Location = New System.Drawing.Point(152, 456)
        Me.txtNroitemGuia.Name = "txtNroitemGuia"
        Me.txtNroitemGuia.Size = New System.Drawing.Size(112, 21)
        Me.txtNroitemGuia.TabIndex = 50
        '
        'txtNroitemNotCred
        '
        Me.txtNroitemNotCred.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroitemNotCred.Location = New System.Drawing.Point(152, 480)
        Me.txtNroitemNotCred.Name = "txtNroitemNotCred"
        Me.txtNroitemNotCred.Size = New System.Drawing.Size(112, 21)
        Me.txtNroitemNotCred.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(42, 506)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Nro Item de Boleta :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNroitemBol
        '
        Me.txtNroitemBol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNroitemBol.Location = New System.Drawing.Point(152, 504)
        Me.txtNroitemBol.Name = "txtNroitemBol"
        Me.txtNroitemBol.Size = New System.Drawing.Size(112, 21)
        Me.txtNroitemBol.TabIndex = 56
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(342, 412)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Digitos DNI :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTDIGIDNI
        '
        Me.TXTDIGIDNI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDIGIDNI.Location = New System.Drawing.Point(415, 415)
        Me.TXTDIGIDNI.Name = "TXTDIGIDNI"
        Me.TXTDIGIDNI.Size = New System.Drawing.Size(112, 21)
        Me.TXTDIGIDNI.TabIndex = 43
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(339, 388)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 13)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Digitos RUC :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTDIGIRUC
        '
        Me.TXTDIGIRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTDIGIRUC.Location = New System.Drawing.Point(415, 390)
        Me.TXTDIGIRUC.Name = "TXTDIGIRUC"
        Me.TXTDIGIRUC.Size = New System.Drawing.Size(112, 21)
        Me.TXTDIGIRUC.TabIndex = 38
        '
        'UIT
        '
        Me.UIT.AutoSize = True
        Me.UIT.Location = New System.Drawing.Point(378, 436)
        Me.UIT.Name = "UIT"
        Me.UIT.Size = New System.Drawing.Size(31, 13)
        Me.UIT.TabIndex = 45
        Me.UIT.Text = "UIT :"
        Me.UIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtUit
        '
        Me.TxtUit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUit.Location = New System.Drawing.Point(415, 440)
        Me.TxtUit.Name = "TxtUit"
        Me.TxtUit.Size = New System.Drawing.Size(112, 21)
        Me.TxtUit.TabIndex = 46
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(58, 657)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 13)
        Me.Label35.TabIndex = 71
        Me.Label35.Text = "Monto Factura :"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFacturaM
        '
        Me.txtFacturaM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFacturaM.Location = New System.Drawing.Point(156, 655)
        Me.txtFacturaM.Name = "txtFacturaM"
        Me.txtFacturaM.Size = New System.Drawing.Size(112, 21)
        Me.txtFacturaM.TabIndex = 72
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(58, 684)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 13)
        Me.Label36.TabIndex = 73
        Me.Label36.Text = "Monto Boleta :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBoletaM
        '
        Me.txtBoletaM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBoletaM.Location = New System.Drawing.Point(156, 682)
        Me.txtBoletaM.Name = "txtBoletaM"
        Me.txtBoletaM.Size = New System.Drawing.Size(112, 21)
        Me.txtBoletaM.TabIndex = 74
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(58, 711)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(58, 13)
        Me.Label37.TabIndex = 75
        Me.Label37.Text = "Nota Ped :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNotaPedM
        '
        Me.txtNotaPedM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaPedM.Location = New System.Drawing.Point(156, 709)
        Me.txtNotaPedM.Name = "txtNotaPedM"
        Me.txtNotaPedM.Size = New System.Drawing.Size(112, 21)
        Me.txtNotaPedM.TabIndex = 76
        '
        'txtArtiTransp
        '
        Me.txtArtiTransp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArtiTransp.Location = New System.Drawing.Point(407, 657)
        Me.txtArtiTransp.Name = "txtArtiTransp"
        Me.txtArtiTransp.Size = New System.Drawing.Size(112, 21)
        Me.txtArtiTransp.TabIndex = 77
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(285, 661)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(119, 13)
        Me.Label38.TabIndex = 78
        Me.Label38.Text = "Articulo de transporte :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConfigVta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(564, 741)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtArtiTransp)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txtNotaPedM)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtBoletaM)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFacturaM)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConfigVta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim ABoolPb_editar As Boolean = True
    Dim GrsConfigVta As DataTable
    Dim AIntResp As Integer

    Private Sub FrmConfigVta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarFormularios(Me)
        CAyuda.CargarDataCombo(CMBFACTURA, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(CMBTICKET, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cmbretencion, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cmbpercep, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(CMBBOLETA, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(CMBNOTCRED, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cbonotadeb, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cmboperador, "Nsp_Sele_Vendedores  '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(cmbcredito, "NSP_Select_Listado_TipoPago  '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cmbefectivo, "NSP_Select_Listado_TipoPago  '" & codempresa & "'", "Código", "Descripción")


        Me.CMBBOLETA.Enabled = False
        Me.CMBFACTURA.Enabled = False
        Me.CMBNOTCRED.Enabled = False
        Me.CMBTICKET.Enabled = False
        cmbcredito.Enabled = False
        cmbefectivo.Enabled = False
        Me.cmboperador.Enabled = False
        Me.cbonotadeb.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
        Me.TextBox5.Enabled = False

        If CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGVTA", codempresa.ToString()).Tables.Count > 0 Then
            GrsConfigVta = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGVTA", codempresa.ToString()).Tables(0)
            asigna_campos()
            botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
                    BTNCERRAR, True, False, True, True, True, True, True)
            bloqueatextos(Me)
            'gHabilitarReg(Me, False)
            CheckActProm.Enabled = False
            ChecPuntosBonus.Enabled = False
            ckFecVarFact.Enabled = False
            CheckBox1.Enabled = False
        Else

            botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
             BTNCERRAR, True, False, True, True, True, True, True)
            Me.txtidimpigv.Focus()
            ABoolPb_editar = True
        End If
    End Sub

    Private Sub txtrecibo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrecibo.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtrecibo.Focus()
        End If

        If Keyascii = 13 Then
            txtcobranza.Focus()
        End If
    End Sub

    Private Sub txtcobranza_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcobranza.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcobranza.Focus()
        End If

        If Keyascii = 13 Then
            txtpago.Focus()
        End If
    End Sub

    Private Sub txtpago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpago.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpago.Focus()
        End If

        If Keyascii = 13 Then
            TxtNumCumProm.Focus()
        End If
    End Sub

    Private Sub TxtMonTickProm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonTickProm.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMonTickProm.Focus()
        End If
        If Keyascii = 13 Then
            txtNroitemFact.Focus()
        End If

    End Sub

    Private Sub TxtNumCumProm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumCumProm.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtNumCumProm.Focus()
        End If
        If Keyascii = 13 Then
            TxtMonTickProm.Focus()
        End If
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If ValidaDatos() Then
            If ABoolPb_editar Then
                AIntResp = CAyuda.Ejecutar("NSP_ins_CONFIGVTA", 0, 0, txtidimpigv.Text, txtidimpisc.Text, 1, 1, 0, 0, 0, 0, CMBTICKET.SelectedValue, CMBFACTURA.SelectedValue, CMBBOLETA.SelectedValue, CMBNOTCRED.SelectedValue,
                                   txtcdbal.Text, txtrecibo.Text, txtcobranza.Text, txtpago.Text, CheckActProm.CheckState, TxtNumCumProm.Text, TxtMonTickProm.Text, ChecPuntosBonus.CheckState, codempresa.ToString(),
                                   Me.cbonotadeb.SelectedValue.ToString, Me.cmboperador.SelectedValue.ToString, Trim(txtNroitemFact.Text), Trim(txtNroitemGuia.Text), Trim(txtNroitemNotCred.Text), Trim(txtNroitemBol.Text),
                                   txtCodclienteVarios.Text.Trim, txtMontoBoleta.Text.Trim, TXTDIGIRUC.Text.Trim, TXTDIGIDNI.Text.Trim, TxtUit.Text.Trim, IIf(Me.ChkDescargaAlmacen.Checked = True, 1, 0), txtVigenciaPedido.Text.Trim,
                                   IIf(Me.ckFecVarFact.Checked = True, 1, 0), Me.TextBox3.Text, Me.TextBox4.Text, Me.TextBox5.Text, IIf(Me.CheckBox1.Checked = True, 1, 0), cmbefectivo.SelectedValue.ToString, cmbcredito.SelectedValue.ToString, cmbretencion.SelectedValue.ToString, cmbpercep.SelectedValue.ToString, txtcodnextel.Text, txtFacturaM.Text, txtBoletaM.Text, txtNotaPedM.Text, Me.txtArtiTransp.Text)
                If AIntResp = 1 Then
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA 'INSERT','INSERT','CONFIGVTA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MessageBox.Show("Error Durante el Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                AIntResp = CAyuda.Ejecutar("sp_Upd_ConfigVta", 0, 0, txtidimpigv.Text, txtidimpisc.Text, 1, 1, 0, 0, 0, 0, CMBTICKET.SelectedValue, CMBFACTURA.SelectedValue, CMBBOLETA.SelectedValue, CMBNOTCRED.SelectedValue,
                                                txtcdbal.Text, txtrecibo.Text, txtcobranza.Text, txtpago.Text, IIf(CheckActProm.Checked = True, 1, 0), TxtMonTickProm.Text, TxtNumCumProm.Text, IIf(ChecPuntosBonus.Checked = True, 1, 0),
                                                Me.cbonotadeb.SelectedValue.ToString, Me.cmboperador.SelectedValue.ToString, Trim(txtNroitemFact.Text), Trim(txtNroitemGuia.Text), Trim(txtNroitemNotCred.Text), Trim(txtNroitemBol.Text),
                                                txtCodclienteVarios.Text.Trim, txtMontoBoleta.Text.Trim, TXTDIGIRUC.Text.Trim, TXTDIGIDNI.Text.Trim, TxtUit.Text.Trim, IIf(Me.ChkDescargaAlmacen.Checked = True, 1, 0), txtVigenciaPedido.Text.Trim,
                                                IIf(Me.ckFecVarFact.Checked = True, 1, 0), Me.TextBox3.Text, Me.TextBox4.Text, Me.TextBox5.Text, codempresa.ToString(), IIf(Me.CheckBox1.Checked = True, 1, 0), cmbefectivo.SelectedValue.ToString, cmbcredito.SelectedValue.ToString, cmbretencion.SelectedValue.ToString, cmbpercep.SelectedValue.ToString, txtcodnextel.Text, txtNroitemGuia.Text, CInt(txtFacturaM.Text), CInt(txtBoletaM.Text), CInt(txtNotaPedM.Text), Me.txtArtiTransp.Text)
                If AIntResp = 1 Then
                    MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA 'UPDATE','UPDATE','CONFIGVTA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MessageBox.Show("Error Durante el Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        Me.cmboperador.Enabled = False
        Me.CMBBOLETA.Enabled = False
        Me.CMBFACTURA.Enabled = False
        Me.CMBNOTCRED.Enabled = False
        Me.CMBTICKET.Enabled = False
        Me.cbonotadeb.Enabled = False
        Me.ChkDescargaAlmacen.Enabled = False
        MessageBox.Show("Se saldrá del Sistema para que los cambios tengan efecto....", DesEmpresa, 0, MessageBoxIcon.Information)
        End
    End Sub
    Private Function ValidaDatos() As Boolean
        ValidaDatos = False
        If GVDATO(txtidimpigv.Text) = "" Then
            MessageBox.Show("Falta Ingresar un Valor", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox "Ingrese impuesto", vbExclamation, "Configuración"
            txtidimpigv.Focus()
            Exit Function
        End If
        If GVDATO(txtidimpisc.Text) = "" Then
            MessageBox.Show("Falta Ingresar un Valor", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox "Ingrese nombre de impuesto", vbExclamation, "Configuración"
            txtidimpisc.Focus()
            Exit Function
        End If

        If txtFacturaM.Text.Length = 0 Then
            txtFacturaM.Text = "0"

        End If

        If txtBoletaM.Text.Length = 0 Then
            txtBoletaM.Text = "0"

        End If

        If txtNotaPedM.Text.Length = 0 Then
            txtNotaPedM.Text = "0"

        End If




        ValidaDatos = True
    End Function

    Private Sub BTNMODIFICAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Me.CMBBOLETA.Enabled = True
        Me.cmboperador.Enabled = True
        Me.CMBFACTURA.Enabled = True
        Me.CMBNOTCRED.Enabled = True
        Me.CMBTICKET.Enabled = True
        Me.cbonotadeb.Enabled = True
        cmbcredito.Enabled = True
        cmbefectivo.Enabled = True
        'gHabilitarReg(Me, True)
        ABoolPb_editar = False
        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
        BTNCERRAR, True, True, False, True, True, True, True)
        desbloqueatextos(Me)
        Me.CheckActProm.Enabled = True
        Me.ChecPuntosBonus.Enabled = True
        Me.ckFecVarFact.Enabled = True
        Me.ChkDescargaAlmacen.Enabled = True
        Me.CheckBox1.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
        Me.TextBox5.Enabled = True
        Me.txtidimpigv.Focus()
    End Sub


    Private Sub txtidimpigv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtidimpigv.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtidimpisc.Focus()
        End If
    End Sub


    Private Sub Txtcdntacred_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtcdbal.Focus()
        End If
    End Sub

    Private Sub txtcdbal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcdbal.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtrecibo.Focus()
        End If
    End Sub

    Private Sub asigna_campos()
        Try
            If GrsConfigVta.Rows.Count <> 0 Then
                txtidimpigv.Text = GrsConfigVta.Rows(0)(2)
                txtidimpisc.Text = GrsConfigVta.Rows(0)(3)
                CMBTICKET.SelectedValue = GrsConfigVta.Rows(0)(11)
                CMBFACTURA.SelectedValue = GrsConfigVta.Rows(0)(12)
                CMBBOLETA.SelectedValue = GrsConfigVta.Rows(0)(13)
                CMBNOTCRED.SelectedValue = GrsConfigVta.Rows(0)(15)
                txtcdbal.Text = GrsConfigVta.Rows(0)("CDBALANZA")
                txtrecibo.Text = GrsConfigVta.Rows(0)("NRORECPEND")
                txtcobranza.Text = GrsConfigVta.Rows(0)(21)
                txtpago.Text = GrsConfigVta.Rows(0)(22)
                CheckActProm.Checked = GrsConfigVta.Rows(0)("IMPCUPONES")
                ChecPuntosBonus.Checked = GrsConfigVta.Rows(0)("ACTBONUS")
                TxtNumCumProm.Text = GrsConfigVta.Rows(0)("NUM_CUPON")
                TxtMonTickProm.Text = GrsConfigVta.Rows(0)("MONTO_CUPON")
                Me.cbonotadeb.SelectedValue = GrsConfigVta.Rows(0)("CDNTADEBITO")
                Me.cmboperador.SelectedValue = GrsConfigVta.Rows(0)("codvend")
                txtNroitemFact.Text = GrsConfigVta.Rows(0)("ITEMDEFACT")
                txtNroitemGuia.Text = GrsConfigVta.Rows(0)("ITEMDEGUIA")
                txtNroitemNotCred.Text = GrsConfigVta.Rows(0)("ITEMDENOTACRED")
                txtNroitemBol.Text = GrsConfigVta.Rows(0)("ITEMDEBOLETA")
                Me.txtCodclienteVarios.Text = GrsConfigVta.Rows(0)("CODCLIVARIOS")
                Me.txtMontoBoleta.Text = GrsConfigVta.Rows(0)("montoboleta")
                Me.TXTDIGIRUC.Text = GrsConfigVta.Rows(0)("DIGITOSRUC")
                Me.TXTDIGIDNI.Text = GrsConfigVta.Rows(0)("DIGITOSDNI")
                Me.TxtUit.Text = GrsConfigVta.Rows(0)("UIT")
                Me.ChkDescargaAlmacen.Checked = GrsConfigVta.Rows(0).Item("DESCARGA_ALMACEN")
                Me.ckFecVarFact.Checked = GrsConfigVta.Rows(0)("CAMBFECFACT")
                Me.txtVigenciaPedido.Text = GrsConfigVta.Rows(0)("DURACION_PEDIDO")
                Me.TextBox3.Text = GrsConfigVta.Rows(0)("NRODESPACHO")
                Me.TextBox4.Text = GrsConfigVta.Rows(0)("NROVENTA")
                Me.TextBox5.Text = GrsConfigVta.Rows(0)("NROCOBRANZA")
                Me.CheckBox1.Checked = GrsConfigVta.Rows(0).Item("PRECIO_CONIGV")
                Me.cmbcredito.SelectedValue = GrsConfigVta.Rows(0)("CDPAGCREDITO")
                Me.cmbefectivo.SelectedValue = GrsConfigVta.Rows(0)("CDPAGEFECTIVO")
                Me.cmbretencion.SelectedValue = GrsConfigVta.Rows(0)("CODRETENCION")
                Me.cmbpercep.SelectedValue = GrsConfigVta.Rows(0)("CODPERCEPCION")
                Me.txtcodnextel.Text = GrsConfigVta.Rows(0)("CODNEXTEL")
                Me.txtArtiTransp.Text = GrsConfigVta.Rows(0)("CODARTISERV")




                txtFacturaM.Text = GrsConfigVta.Rows(0)("MONTFACTURA")
                txtBoletaM.Text = GrsConfigVta.Rows(0)("MONTBOLETA")
                txtNotaPedM.Text = GrsConfigVta.Rows(0)("MONTNTACREDP")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub CheckActProm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckActProm.CheckedChanged
        If CheckActProm.Checked = True Then
            TxtNumCumProm.Enabled = True
            TxtMonTickProm.Enabled = True
        Else
            TxtNumCumProm.Enabled = False
            TxtMonTickProm.Enabled = False
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        GrsConfigVta = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGVTA", codempresa.ToString()).Tables(0)
        asigna_campos()
        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
           BTNCERRAR, True, False, True, True, True, True, True)
        bloqueatextos(Me)
        CheckActProm.Enabled = False
        ChecPuntosBonus.Enabled = False
        CheckBox1.Enabled = False
        'gHabilitarReg(Me, False)

        Me.cmboperador.Enabled = False
        Me.CMBBOLETA.Enabled = False
        Me.CMBFACTURA.Enabled = False
        Me.CMBNOTCRED.Enabled = False
        Me.CMBTICKET.Enabled = False
        Me.cbonotadeb.Enabled = False
        cmbcredito.Enabled = False
        cmbefectivo.Enabled = False
    End Sub


    Private Sub txtidimpisc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtidimpisc.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            CMBTICKET.Focus()
        End If
    End Sub

    Private Sub CMBTICKET_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBTICKET.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            CMBFACTURA.Focus()
        End If
    End Sub

    Private Sub CMBFACTURA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBFACTURA.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            CMBBOLETA.Focus()
        End If
    End Sub

    Private Sub CMBBOLETA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBBOLETA.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            CMBNOTCRED.Focus()
        End If
    End Sub

    Private Sub CMBNOTCRED_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBNOTCRED.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cbonotadeb.Focus()
        End If
    End Sub


    Private Sub cbonotadeb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbonotadeb.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmboperador.Focus()
        End If
    End Sub

    Private Sub cmboperador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmboperador.KeyPress, cmbretencion.KeyPress, cmbpercep.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtcdbal.Focus()
        End If
    End Sub

    Private Sub TxtMonTickProm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMonTickProm.TextChanged

    End Sub

    Private Sub cmboperador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboperador.SelectedIndexChanged, cmbretencion.SelectedIndexChanged, cmbpercep.SelectedIndexChanged

    End Sub

    Private Sub txtNroitemFact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroitemFact.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtNroitemGuia.Focus()
        End If
    End Sub

    Private Sub txtNroitemGuia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroitemGuia.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtNroitemNotCred.Focus()
        End If
    End Sub

    Private Sub txtNroitemNotCred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroitemNotCred.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtNroitemBol.Focus()
        End If
    End Sub

    Private Sub txtNroitemBol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroitemBol.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtCodclienteVarios.Focus()
        End If
    End Sub

    Private Sub txtMontoBoleta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoBoleta.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub txtCodclienteVarios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodclienteVarios.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtMontoBoleta.Focus()
        End If
    End Sub

    Private Sub TXTDIGIRUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTDIGIRUC.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TXTDIGIDNI.Focus()
        End If
    End Sub

    Private Sub TXTDIGIDNI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTDIGIDNI.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtUit.Focus()
        End If
    End Sub

    Private Sub TxtUit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUit.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub txtpago_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpago.TextChanged

    End Sub

    Private Sub TXTDIGIRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTDIGIRUC.TextChanged

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click

    End Sub

    Private Sub txtNroitemFact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroitemFact.TextChanged

    End Sub

    Private Sub TxtNumCumProm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumCumProm.TextChanged

    End Sub

    Private Sub txtMontoBoleta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoBoleta.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged, txtcodnextel.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress, txtcodnextel.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TextBox2.Focus()
        End If


    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFacturaM.TextChanged

    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click

    End Sub
End Class
