Public Class FR_CONFINGINVENT
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
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DtcIngtransF As System.Windows.Forms.ComboBox
    Friend WithEvents dtcnotcredesp As System.Windows.Forms.ComboBox
    Friend WithEvents DtcSalNotCred As System.Windows.Forms.ComboBox
    Friend WithEvents DtcSalTransF As System.Windows.Forms.ComboBox
    Friend WithEvents DtcIngFormula As System.Windows.Forms.ComboBox
    Friend WithEvents DtcIngComp As System.Windows.Forms.ComboBox
    Friend WithEvents DtcSalDescForm As System.Windows.Forms.ComboBox
    Friend WithEvents DtcDocAjusSal As System.Windows.Forms.ComboBox
    Friend WithEvents DtcSalajuste As System.Windows.Forms.ComboBox
    Friend WithEvents DtcDocAjusIng As System.Windows.Forms.ComboBox
    Friend WithEvents DtcIngajuste As System.Windows.Forms.ComboBox
    Friend WithEvents DtcSalTransforma As System.Windows.Forms.ComboBox
    Friend WithEvents DtcIngrTransforma As System.Windows.Forms.ComboBox
    Friend WithEvents tnrosemana As System.Windows.Forms.TextBox
    Friend WithEvents tdecimalesresultado As System.Windows.Forms.TextBox
    Friend WithEvents tdecimalesprecio As System.Windows.Forms.TextBox
    Friend WithEvents tdecimalescosto As System.Windows.Forms.TextBox
    Friend WithEvents tdecimalescant As System.Windows.Forms.TextBox
    Friend WithEvents tnroinv As System.Windows.Forms.TextBox
    Friend WithEvents tnromovi As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents cboalmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cingimportacion As System.Windows.Forms.ComboBox
    Friend WithEvents cingcredito As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tincbulto As System.Windows.Forms.TextBox
    Friend WithEvents tincpeso As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNumOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtCostos As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbotransubcam As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cboIngTransSubcam As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TxtCodSer As System.Windows.Forms.TextBox
    Friend WithEvents CboDocIng As System.Windows.Forms.ComboBox
    Friend WithEvents CboDocSal As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CboCodIngProcMon As System.Windows.Forms.ComboBox
    Friend WithEvents CboCodIngAjuste As System.Windows.Forms.ComboBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TxtPorcenPercep As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FR_CONFINGINVENT))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BTNCERRAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TxtPorcenPercep = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CboCodIngAjuste = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.CboCodIngProcMon = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CboDocSal = New System.Windows.Forms.ComboBox()
        Me.CboDocIng = New System.Windows.Forms.ComboBox()
        Me.TxtCodSer = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tincbulto = New System.Windows.Forms.TextBox()
        Me.tincpeso = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cingcredito = New System.Windows.Forms.ComboBox()
        Me.cingimportacion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboalmacen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DtcDocAjusSal = New System.Windows.Forms.ComboBox()
        Me.DtcSalajuste = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DtcDocAjusIng = New System.Windows.Forms.ComboBox()
        Me.DtcIngajuste = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.DtcSalDescForm = New System.Windows.Forms.ComboBox()
        Me.tnrosemana = New System.Windows.Forms.TextBox()
        Me.tdecimalesresultado = New System.Windows.Forms.TextBox()
        Me.tdecimalesprecio = New System.Windows.Forms.TextBox()
        Me.tdecimalescosto = New System.Windows.Forms.TextBox()
        Me.tdecimalescant = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.DtcIngtransF = New System.Windows.Forms.ComboBox()
        Me.dtcnotcredesp = New System.Windows.Forms.ComboBox()
        Me.DtcSalNotCred = New System.Windows.Forms.ComboBox()
        Me.DtcSalTransF = New System.Windows.Forms.ComboBox()
        Me.DtcIngFormula = New System.Windows.Forms.ComboBox()
        Me.DtcIngComp = New System.Windows.Forms.ComboBox()
        Me.tnroinv = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tnromovi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumOrden = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCostos = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbotransubcam = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboIngTransSubcam = New System.Windows.Forms.ComboBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DtcSalTransforma = New System.Windows.Forms.ComboBox()
        Me.DtcIngrTransforma = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(768, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(121, 144)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(19, 80)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCANCELAR.TabIndex = 30
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(19, 107)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCERRAR.TabIndex = 31
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(19, 24)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNMODIFICAR.TabIndex = 28
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(19, 52)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(82, 24)
        Me.BTNGUARDAR.TabIndex = 29
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.TxtPorcenPercep)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.CboCodIngAjuste)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.CboCodIngProcMon)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Controls.Add(Me.CboDocSal)
        Me.GroupBox1.Controls.Add(Me.CboDocIng)
        Me.GroupBox1.Controls.Add(Me.TxtCodSer)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.tincbulto)
        Me.GroupBox1.Controls.Add(Me.tincpeso)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cingcredito)
        Me.GroupBox1.Controls.Add(Me.cingimportacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboalmacen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.DtcSalDescForm)
        Me.GroupBox1.Controls.Add(Me.tnrosemana)
        Me.GroupBox1.Controls.Add(Me.tdecimalesresultado)
        Me.GroupBox1.Controls.Add(Me.tdecimalesprecio)
        Me.GroupBox1.Controls.Add(Me.tdecimalescosto)
        Me.GroupBox1.Controls.Add(Me.tdecimalescant)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.DtcIngtransF)
        Me.GroupBox1.Controls.Add(Me.dtcnotcredesp)
        Me.GroupBox1.Controls.Add(Me.DtcSalNotCred)
        Me.GroupBox1.Controls.Add(Me.DtcSalTransF)
        Me.GroupBox1.Controls.Add(Me.DtcIngFormula)
        Me.GroupBox1.Controls.Add(Me.DtcIngComp)
        Me.GroupBox1.Controls.Add(Me.tnroinv)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tnromovi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNumOrden)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtCostos)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cbotransubcam)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cboIngTransSubcam)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 552)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(759, 317)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(18, 13)
        Me.Label41.TabIndex = 87
        Me.Label41.Text = "%"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtPorcenPercep
        '
        Me.TxtPorcenPercep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPorcenPercep.Location = New System.Drawing.Point(700, 315)
        Me.TxtPorcenPercep.MaxLength = 5
        Me.TxtPorcenPercep.Name = "TxtPorcenPercep"
        Me.TxtPorcenPercep.Size = New System.Drawing.Size(51, 21)
        Me.TxtPorcenPercep.TabIndex = 85
        Me.TxtPorcenPercep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(536, 316)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(156, 26)
        Me.Label42.TabIndex = 86
        Me.Label42.Text = "Porcentaje de Percepcion :"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboCodIngAjuste
        '
        Me.CboCodIngAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCodIngAjuste.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCodIngAjuste.Location = New System.Drawing.Point(656, 362)
        Me.CboCodIngAjuste.Name = "CboCodIngAjuste"
        Me.CboCodIngAjuste.Size = New System.Drawing.Size(211, 22)
        Me.CboCodIngAjuste.TabIndex = 84
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(502, 365)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(145, 13)
        Me.Label40.TabIndex = 83
        Me.Label40.Text = "Codigo de Ingreso x Ajuste :"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboCodIngProcMon
        '
        Me.CboCodIngProcMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCodIngProcMon.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCodIngProcMon.Location = New System.Drawing.Point(656, 388)
        Me.CboCodIngProcMon.Name = "CboCodIngProcMon"
        Me.CboCodIngProcMon.Size = New System.Drawing.Size(211, 22)
        Me.CboCodIngProcMon.TabIndex = 82
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(438, 391)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(205, 13)
        Me.Label39.TabIndex = 81
        Me.Label39.Text = "Codigo de Ingreso x Proceso Mondongo :"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(52, 388)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(165, 13)
        Me.Label38.TabIndex = 80
        Me.Label38.Text = "Codigo de Documento de Salida :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(42, 364)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(174, 13)
        Me.Label37.TabIndex = 79
        Me.Label37.Text = "Codigo de Documento de Ingreso :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CboDocSal
        '
        Me.CboDocSal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDocSal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDocSal.Location = New System.Drawing.Point(227, 387)
        Me.CboDocSal.Name = "CboDocSal"
        Me.CboDocSal.Size = New System.Drawing.Size(211, 22)
        Me.CboDocSal.TabIndex = 78
        '
        'CboDocIng
        '
        Me.CboDocIng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDocIng.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDocIng.Location = New System.Drawing.Point(227, 361)
        Me.CboDocIng.Name = "CboDocIng"
        Me.CboDocIng.Size = New System.Drawing.Size(211, 22)
        Me.CboDocIng.TabIndex = 77
        '
        'TxtCodSer
        '
        Me.TxtCodSer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSer.Location = New System.Drawing.Point(698, 288)
        Me.TxtCodSer.MaxLength = 9
        Me.TxtCodSer.Name = "TxtCodSer"
        Me.TxtCodSer.Size = New System.Drawing.Size(51, 21)
        Me.TxtCodSer.TabIndex = 76
        Me.TxtCodSer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(547, 290)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(163, 17)
        Me.Label36.TabIndex = 75
        Me.Label36.Text = "Codigo General de Servicios :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(750, 264)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "Bultos"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(757, 238)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 13)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "%"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tincbulto
        '
        Me.tincbulto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tincbulto.Location = New System.Drawing.Point(698, 261)
        Me.tincbulto.MaxLength = 9
        Me.tincbulto.Name = "tincbulto"
        Me.tincbulto.Size = New System.Drawing.Size(51, 21)
        Me.tincbulto.TabIndex = 69
        Me.tincbulto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tincpeso
        '
        Me.tincpeso.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tincpeso.Location = New System.Drawing.Point(698, 236)
        Me.tincpeso.MaxLength = 5
        Me.tincpeso.Name = "tincpeso"
        Me.tincpeso.Size = New System.Drawing.Size(51, 21)
        Me.tincpeso.TabIndex = 68
        Me.tincpeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(531, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 26)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Incr. de Ingreso de Almacen :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(534, 237)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 26)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "Incr. de Ingreso Almacen :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Código Ing por Nota de Crédito :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cingcredito
        '
        Me.cingcredito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cingcredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cingcredito.Location = New System.Drawing.Point(226, 162)
        Me.cingcredito.Name = "cingcredito"
        Me.cingcredito.Size = New System.Drawing.Size(211, 22)
        Me.cingcredito.TabIndex = 66
        '
        'cingimportacion
        '
        Me.cingimportacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cingimportacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cingimportacion.Location = New System.Drawing.Point(226, 138)
        Me.cingimportacion.Name = "cingimportacion"
        Me.cingimportacion.Size = New System.Drawing.Size(211, 22)
        Me.cingimportacion.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Código Ing por Importación :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboalmacen
        '
        Me.cboalmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboalmacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboalmacen.Location = New System.Drawing.Point(226, 282)
        Me.cboalmacen.Name = "cboalmacen"
        Me.cboalmacen.Size = New System.Drawing.Size(211, 22)
        Me.cboalmacen.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Almacén :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 420)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(694, 122)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Toma de Inventario"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 21)
        Me.DateTimePicker1.TabIndex = 23
        Me.DateTimePicker1.Value = New Date(2006, 1, 10, 15, 12, 57, 991)
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(224, 15)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 13)
        Me.Label35.TabIndex = 21
        Me.Label35.Text = "Fecha Inventario :"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DtcDocAjusSal)
        Me.GroupBox6.Controls.Add(Me.DtcSalajuste)
        Me.GroupBox6.Controls.Add(Me.Label33)
        Me.GroupBox6.Controls.Add(Me.Label34)
        Me.GroupBox6.Location = New System.Drawing.Point(349, 36)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(327, 80)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Egresos"
        '
        'DtcDocAjusSal
        '
        Me.DtcDocAjusSal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcDocAjusSal.ItemHeight = 13
        Me.DtcDocAjusSal.Location = New System.Drawing.Point(97, 49)
        Me.DtcDocAjusSal.Name = "DtcDocAjusSal"
        Me.DtcDocAjusSal.Size = New System.Drawing.Size(214, 21)
        Me.DtcDocAjusSal.TabIndex = 27
        '
        'DtcSalajuste
        '
        Me.DtcSalajuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcSalajuste.ItemHeight = 13
        Me.DtcSalajuste.Location = New System.Drawing.Point(97, 25)
        Me.DtcSalajuste.Name = "DtcSalajuste"
        Me.DtcSalajuste.Size = New System.Drawing.Size(214, 21)
        Me.DtcSalajuste.TabIndex = 26
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(12, 51)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(81, 13)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "T. Documento :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(10, 27)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 13)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Salida Ajuste :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DtcDocAjusIng)
        Me.GroupBox5.Controls.Add(Me.DtcIngajuste)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Location = New System.Drawing.Point(15, 37)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(327, 80)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ingresos"
        '
        'DtcDocAjusIng
        '
        Me.DtcDocAjusIng.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcDocAjusIng.ItemHeight = 13
        Me.DtcDocAjusIng.Location = New System.Drawing.Point(97, 49)
        Me.DtcDocAjusIng.Name = "DtcDocAjusIng"
        Me.DtcDocAjusIng.Size = New System.Drawing.Size(214, 21)
        Me.DtcDocAjusIng.TabIndex = 25
        '
        'DtcIngajuste
        '
        Me.DtcIngajuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcIngajuste.ItemHeight = 13
        Me.DtcIngajuste.Location = New System.Drawing.Point(97, 25)
        Me.DtcIngajuste.Name = "DtcIngajuste"
        Me.DtcIngajuste.Size = New System.Drawing.Size(214, 21)
        Me.DtcIngajuste.TabIndex = 24
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(12, 51)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(81, 13)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "T. Documento :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(10, 27)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(85, 13)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "Ingreso Ajuste :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtcSalDescForm
        '
        Me.DtcSalDescForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcSalDescForm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcSalDescForm.Location = New System.Drawing.Point(226, 234)
        Me.DtcSalDescForm.Name = "DtcSalDescForm"
        Me.DtcSalDescForm.Size = New System.Drawing.Size(211, 22)
        Me.DtcSalDescForm.TabIndex = 8
        '
        'tnrosemana
        '
        Me.tnrosemana.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnrosemana.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnrosemana.Location = New System.Drawing.Point(592, 43)
        Me.tnrosemana.MaxLength = 4
        Me.tnrosemana.Name = "tnrosemana"
        Me.tnrosemana.Size = New System.Drawing.Size(98, 21)
        Me.tnrosemana.TabIndex = 11
        Me.tnrosemana.Visible = False
        '
        'tdecimalesresultado
        '
        Me.tdecimalesresultado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdecimalesresultado.Location = New System.Drawing.Point(698, 212)
        Me.tdecimalesresultado.MaxLength = 9
        Me.tdecimalesresultado.Name = "tdecimalesresultado"
        Me.tdecimalesresultado.Size = New System.Drawing.Size(51, 21)
        Me.tdecimalesresultado.TabIndex = 15
        Me.tdecimalesresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tdecimalesprecio
        '
        Me.tdecimalesprecio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdecimalesprecio.Location = New System.Drawing.Point(698, 188)
        Me.tdecimalesprecio.MaxLength = 5
        Me.tdecimalesprecio.Name = "tdecimalesprecio"
        Me.tdecimalesprecio.Size = New System.Drawing.Size(51, 21)
        Me.tdecimalesprecio.TabIndex = 14
        Me.tdecimalesprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tdecimalescosto
        '
        Me.tdecimalescosto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdecimalescosto.Location = New System.Drawing.Point(698, 164)
        Me.tdecimalescosto.MaxLength = 9
        Me.tdecimalescosto.Name = "tdecimalescosto"
        Me.tdecimalescosto.Size = New System.Drawing.Size(51, 21)
        Me.tdecimalescosto.TabIndex = 13
        Me.tdecimalescosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tdecimalescant
        '
        Me.tdecimalescant.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdecimalescant.Location = New System.Drawing.Point(697, 140)
        Me.tdecimalescant.MaxLength = 9
        Me.tdecimalescant.Name = "tdecimalescant"
        Me.tdecimalescant.Size = New System.Drawing.Size(51, 21)
        Me.tdecimalescant.TabIndex = 12
        Me.tdecimalescant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(569, 215)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(117, 13)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "Decimales Resultados :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(594, 191)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(93, 13)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Decimales Precio :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(581, 143)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(107, 13)
        Me.Label27.TabIndex = 53
        Me.Label27.Text = "Decimales Cantidad :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(596, 167)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(92, 13)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "Decimales Costo :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DtcIngtransF
        '
        Me.DtcIngtransF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcIngtransF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcIngtransF.Location = New System.Drawing.Point(226, 66)
        Me.DtcIngtransF.Name = "DtcIngtransF"
        Me.DtcIngtransF.Size = New System.Drawing.Size(211, 22)
        Me.DtcIngtransF.TabIndex = 3
        '
        'dtcnotcredesp
        '
        Me.dtcnotcredesp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dtcnotcredesp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtcnotcredesp.Location = New System.Drawing.Point(226, 258)
        Me.dtcnotcredesp.Name = "dtcnotcredesp"
        Me.dtcnotcredesp.Size = New System.Drawing.Size(211, 22)
        Me.dtcnotcredesp.TabIndex = 9
        '
        'DtcSalNotCred
        '
        Me.DtcSalNotCred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcSalNotCred.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcSalNotCred.Location = New System.Drawing.Point(226, 210)
        Me.DtcSalNotCred.Name = "DtcSalNotCred"
        Me.DtcSalNotCred.Size = New System.Drawing.Size(211, 22)
        Me.DtcSalNotCred.TabIndex = 7
        '
        'DtcSalTransF
        '
        Me.DtcSalTransF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcSalTransF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcSalTransF.Location = New System.Drawing.Point(226, 186)
        Me.DtcSalTransF.Name = "DtcSalTransF"
        Me.DtcSalTransF.Size = New System.Drawing.Size(211, 22)
        Me.DtcSalTransF.TabIndex = 6
        '
        'DtcIngFormula
        '
        Me.DtcIngFormula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcIngFormula.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcIngFormula.Location = New System.Drawing.Point(226, 114)
        Me.DtcIngFormula.Name = "DtcIngFormula"
        Me.DtcIngFormula.Size = New System.Drawing.Size(211, 22)
        Me.DtcIngFormula.TabIndex = 5
        '
        'DtcIngComp
        '
        Me.DtcIngComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcIngComp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcIngComp.Location = New System.Drawing.Point(226, 90)
        Me.DtcIngComp.Name = "DtcIngComp"
        Me.DtcIngComp.Size = New System.Drawing.Size(211, 22)
        Me.DtcIngComp.TabIndex = 4
        '
        'tnroinv
        '
        Me.tnroinv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnroinv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnroinv.Location = New System.Drawing.Point(226, 42)
        Me.tnroinv.MaxLength = 9
        Me.tnroinv.Name = "tnroinv"
        Me.tnroinv.Size = New System.Drawing.Size(91, 21)
        Me.tnroinv.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(48, 236)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(167, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Código Salida Descarga Fórmula :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(424, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(253, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Nro de Semanas de Venta Para Busqueda Pedidos :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Código Salida Nota de Crédito :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(104, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Cod ing por Compras :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(139, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Nro Inv Inicial :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Código Ing de Transferencias :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(106, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Código Ing Fórmulas :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Código Salida de Transferencia :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cód Salida Nota de Cred Especial :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tnromovi
        '
        Me.tnromovi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tnromovi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tnromovi.Location = New System.Drawing.Point(226, 18)
        Me.tnromovi.MaxLength = 9
        Me.tnromovi.Name = "tnromovi"
        Me.tnromovi.Size = New System.Drawing.Size(91, 21)
        Me.tnromovi.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Movimiento General :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNumOrden
        '
        Me.txtNumOrden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumOrden.Location = New System.Drawing.Point(696, 114)
        Me.txtNumOrden.MaxLength = 9
        Me.txtNumOrden.Name = "txtNumOrden"
        Me.txtNumOrden.Size = New System.Drawing.Size(51, 21)
        Me.txtNumOrden.TabIndex = 12
        Me.txtNumOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(611, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Num. Compra :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostos
        '
        Me.txtCostos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostos.Location = New System.Drawing.Point(696, 91)
        Me.txtCostos.MaxLength = 9
        Me.txtCostos.Name = "txtCostos"
        Me.txtCostos.Size = New System.Drawing.Size(51, 21)
        Me.txtCostos.TabIndex = 12
        Me.txtCostos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(590, 92)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(103, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Correlativo Costos :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbotransubcam
        '
        Me.cbotransubcam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotransubcam.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotransubcam.Location = New System.Drawing.Point(227, 308)
        Me.cbotransubcam.Name = "cbotransubcam"
        Me.cbotransubcam.Size = New System.Drawing.Size(211, 22)
        Me.cbotransubcam.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(18, 309)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(198, 13)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "Cód Salida Transferencia a Subcamara :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 335)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(207, 13)
        Me.Label21.TabIndex = 63
        Me.Label21.Text = "Cód Ingreso Transferencia a Subcamara :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboIngTransSubcam
        '
        Me.cboIngTransSubcam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIngTransSubcam.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIngTransSubcam.Location = New System.Drawing.Point(227, 334)
        Me.cboIngTransSubcam.Name = "cboIngTransSubcam"
        Me.cboIngTransSubcam.Size = New System.Drawing.Size(211, 22)
        Me.cboIngTransSubcam.TabIndex = 10
        '
        'CheckBox3
        '
        Me.CheckBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(688, 648)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(176, 20)
        Me.CheckBox3.TabIndex = 18
        Me.CheckBox3.Text = "Inventario Físico "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtcSalTransforma)
        Me.GroupBox3.Controls.Add(Me.DtcIngrTransforma)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(240, 664)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(695, 87)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transformaciones"
        '
        'DtcSalTransforma
        '
        Me.DtcSalTransforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcSalTransforma.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcSalTransforma.Items.AddRange(New Object() {"001"})
        Me.DtcSalTransforma.Location = New System.Drawing.Point(331, 50)
        Me.DtcSalTransforma.Name = "DtcSalTransforma"
        Me.DtcSalTransforma.Size = New System.Drawing.Size(315, 21)
        Me.DtcSalTransforma.TabIndex = 22
        '
        'DtcIngrTransforma
        '
        Me.DtcIngrTransforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DtcIngrTransforma.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtcIngrTransforma.Items.AddRange(New Object() {"001"})
        Me.DtcIngrTransforma.Location = New System.Drawing.Point(331, 26)
        Me.DtcIngrTransforma.Name = "DtcIngrTransforma"
        Me.DtcIngrTransforma.Size = New System.Drawing.Size(315, 21)
        Me.DtcIngrTransforma.TabIndex = 21
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(171, 52)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(145, 13)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "Código Sal. Transformación :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(171, 28)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(148, 13)
        Me.Label30.TabIndex = 16
        Me.Label30.Text = "Código Ingr.Transformación :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(46, 50)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(91, 21)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.Text = "Al fin del Día"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(46, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(91, 21)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "En Línea"
        '
        'CheckBox2
        '
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(464, 648)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(176, 20)
        Me.CheckBox2.TabIndex = 17
        Me.CheckBox2.Text = "Trabajar con Stock Negativo"
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(280, 648)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(230, 20)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Activar Transformación"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.ComboBox2)
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Controls.Add(Me.Label24)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Location = New System.Drawing.Point(24, 600)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(865, 55)
        Me.GroupBox7.TabIndex = 75
        Me.GroupBox7.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(579, 20)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(266, 22)
        Me.ComboBox2.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(135, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(266, 22)
        Me.ComboBox1.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(435, 22)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(127, 18)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "&Ingreso de Mercaderia :"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(12, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(127, 18)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "&Ingreso de Mercaderia :"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(10, 2)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 15)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "   &Economato : "
        '
        'FR_CONFINGINVENT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(902, 601)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(918, 640)
        Me.MinimizeBox = False
        Me.Name = "FR_CONFINGINVENT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Inventarios"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boest As Boolean
    Dim sinstockneg, sinacttransf, sindesclintrans, sininvfis As Single

    Sub bloquea(ByVal b As Boolean)

        Me.CheckBox1.Enabled = b
        Me.CheckBox2.Enabled = b
        Me.CheckBox3.Enabled = b
        Me.RadioButton1.Enabled = b
        Me.RadioButton1.Enabled = b

        Me.DtcIngrTransforma.Enabled = b
        Me.DtcSalTransforma.Enabled = b
        Me.DateTimePicker1.Enabled = b
        Me.DtcIngajuste.Enabled = b
        Me.DtcDocAjusIng.Enabled = b
        Me.DtcSalajuste.Enabled = b
        Me.DtcDocAjusSal.Enabled = b

    End Sub
    Private Sub FR_CONFINGINVENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Call bloqueatextbox(Me)
        Call BOTONES(False, True)
        bloquea(False)
        Call cargadatos()
        Me.BTNCANCELAR.Enabled = False

        Conecta("SELECT NROMOVI,NROINVINI,stockneg,DECICANT,DECICOST,DECIPREC,DECIRESU,invfis,FECHA_INV,NROFECH,ACTIVATRANSFORM,DESCLINTRANSFOR,cdalmacen,CDINGTRANSF,CDINGCOMP,CDINGAJUSTOCK,CDINGCARGFORMU,CDSALTRANSF,CDSALAJUSTOCK,CDSALDESCFORMU,CDSALNTACRED,CDSALNTACREDESP,CDINGTRANSFoRM,CDSALTRANSFORM,CDTIPDOCINGAJUS,CDTIPDOCSALAJUS,CDINGIMP,CDINGCRED,PORINCPESO,INCBULTO,NROCOMPRA,CORRELCOSTOS,CDSALTRANSSUBCAM,CDINGTRANSSUBCAM,CODSERVICIOS,CODIGO_DOCUMENTO_INGRESO,CODIGO_DOCUMENTO_SALIDA,INGRESO_X_AJUSTE,ING_X_PROC_MOND,PORCENPERCEP   FROM CONFIGINV  WHERE CODEMPRESA='" & codempresa & "' and estado=0", "PA")

        If ds.Tables("PA").Rows.Count > 0 Then
            Me.tnromovi.Text = Trim(ds.Tables("pa").Rows(0)(0))
            Me.tnroinv.Text = Trim(ds.Tables("pa").Rows(0)(1))

            If Trim(ds.Tables("pa").Rows(0)(2)) = True Then
                Me.CheckBox2.Checked = True
            Else
                Me.CheckBox2.Checked = False
            End If

            Me.tdecimalescant.Text = Trim(ds.Tables("pa").Rows(0)(3))
            Me.tdecimalescosto.Text = Trim(ds.Tables("pa").Rows(0)(4))
            Me.tdecimalesprecio.Text = Trim(ds.Tables("pa").Rows(0)(5))
            Me.tdecimalesresultado.Text = Trim(ds.Tables("pa").Rows(0)(6))

            If Trim(ds.Tables("pa").Rows(0)(7)) = True Then
                Me.CheckBox3.Checked = True
            Else
                Me.CheckBox3.Checked = False
            End If

            Me.DateTimePicker1.Value = Trim(ds.Tables("pa").Rows(0)(8))
            Me.tnrosemana.Text = Trim(ds.Tables("pa").Rows(0)(9))

            If Trim(ds.Tables("pa").Rows(0)(10)) = True Then
                Me.CheckBox1.Checked = True
            Else
                Me.CheckBox1.Checked = False
            End If

            If Trim(ds.Tables("pa").Rows(0)(11)) = True Then
                Me.RadioButton1.Checked = True
            Else
                Me.RadioButton1.Checked = False
            End If

            cboalmacen.SelectedValue = Trim(ds.Tables("pa").Rows(0)(12))
            DtcIngtransF.SelectedValue = Trim(ds.Tables("pa").Rows(0)(13))
            DtcIngComp.SelectedValue = Trim(ds.Tables("pa").Rows(0)(14))
            DtcIngajuste.SelectedValue = Trim(ds.Tables("pa").Rows(0)(15))
            DtcIngFormula.SelectedValue = Trim(ds.Tables("pa").Rows(0)(16))
            DtcSalTransF.SelectedValue = Trim(ds.Tables("pa").Rows(0)(17))
            DtcSalajuste.SelectedValue = Trim(ds.Tables("pa").Rows(0)(18))
            DtcSalDescForm.SelectedValue = Trim(ds.Tables("pa").Rows(0)(19))
            DtcSalNotCred.SelectedValue = Trim(ds.Tables("pa").Rows(0)(20))
            dtcnotcredesp.SelectedValue = Trim(ds.Tables("pa").Rows(0)(21))
            DtcIngrTransforma.SelectedValue = Trim(ds.Tables("pa").Rows(0)(22))
            DtcSalTransforma.SelectedValue = Trim(ds.Tables("pa").Rows(0)(23))
            DtcDocAjusIng.SelectedValue = Trim(ds.Tables("pa").Rows(0)(24))
            DtcDocAjusSal.SelectedValue = Trim(ds.Tables("pa").Rows(0)(25))
            cingimportacion.SelectedValue = Trim(ds.Tables("pa").Rows(0)(26))
            cingcredito.SelectedValue = Trim(ds.Tables("pa").Rows(0)(27))
            Me.tincpeso.Text = Trim(ds.Tables("pa").Rows(0)(28))
            Me.tincbulto.Text = Trim(ds.Tables("pa").Rows(0)(29))
            Me.txtNumOrden.Text = Trim(ds.Tables("pa").Rows(0)(30))
            Me.txtCostos.Text = CAyuda.ValidaNulls(ds.Tables("pa").Rows(0)(31))
            cbotransubcam.SelectedValue = Trim(ds.Tables("pa").Rows(0)(32))
            cboIngTransSubcam.SelectedValue = Trim(ds.Tables("pa").Rows(0)(33))
            Me.TxtCodSer.Text = Trim(ds.Tables("pa").Rows(0).Item("CODSERVICIOS").ToString())
            Me.CboDocIng.SelectedValue = ds.Tables("pa").Rows(0).Item("CODIGO_DOCUMENTO_INGRESO")
            Me.CboDocSal.SelectedValue = ds.Tables("pa").Rows(0).Item("CODIGO_DOCUMENTO_SALIDA")
            Me.CboCodIngAjuste.SelectedValue = ds.Tables("pa").Rows(0).Item("INGRESO_X_AJUSTE")
            Me.CboCodIngProcMon.SelectedValue = ds.Tables("pa").Rows(0).Item("ING_X_PROC_MOND")
            TxtPorcenPercep.Text = ds.Tables("pa").Rows(0).Item("PORCENPERCEP")

            boest = True
        Else
            boest = False
        End If


    End Sub
    Sub cargadatos()
        CAyuda.CargarDataCombo(DtcDocAjusIng, "Nsp_Sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(cboalmacen, "Nsp_Select_almacen '" & codempresa & "'", "codigo", "descripcion")
        CAyuda.CargarDataCombo(DtcDocAjusSal, "Nsp_Sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(DtcIngtransF, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(DtcIngComp, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")

        CAyuda.CargarDataCombo(cingimportacion, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cingcredito, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")

        CAyuda.CargarDataCombo(DtcIngFormula, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(DtcSalTransF, "Nsp_Sele_tipomovisal '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(DtcSalNotCred, "Nsp_Sele_tipomovisal '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(DtcSalDescForm, "Nsp_Sele_tipomovisal '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(DtcIngrTransforma, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(DtcSalTransforma, "Nsp_Sele_tipomovisal '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(DtcIngajuste, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(DtcSalajuste, "Nsp_Sele_tipomovisal '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(dtcnotcredesp, "Nsp_Sele_tipomovisal '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cbotransubcam, "Nsp_Sele_tipomovisal '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cboIngTransSubcam, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(CboDocIng, "nsp_sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(CboDocSal, "nsp_sele_tipodoc '" & codempresa & "'", "Codigo", "Descripcion")
        CAyuda.CargarDataCombo(CboCodIngAjuste, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(CboCodIngProcMon, "Nsp_Sele_tipomovi '" & codempresa & "'", "Código", "Descripción")
    End Sub


    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Dim FLAG As Integer
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        bloquea(False)
        If FLAG = 0 Then
            Call Limpiatextbox(Me)
        End If

        Call BOTONES(False, True)
        Call Bloqueatextbox(Me)
        BTNCANCELAR.Enabled = False
    End Sub


    Sub BOTONES(ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean)
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked = True Then
            sinstockneg = 1
        Else
            sinstockneg = 0
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            sinacttransf = 1
        Else
            sinacttransf = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            sindesclintrans = 1
        Else
            sindesclintrans = 0
        End If
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        bloquea(True)
        Call BOTONES(True, False)
        BTNCANCELAR.Enabled = True
        FLAG = 1
        tnromovi.Focus()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim sql As String
        Dim PROCESO As Boolean
        Call formatotextbox(Me)

        If tnromovi.Text = "" Or tnroinv.Text = "" Or Me.DtcDocAjusIng.Text = "" Or Me.DtcDocAjusSal.Text = "" Or Me.DtcIngajuste.Text = "" Or Me.DtcIngComp.Text = "" Or Me.DtcIngFormula.Text = "" Or Me.DtcIngtransF.Text = "" Or Me.dtcnotcredesp.Text = "" Or Me.DtcSalajuste.Text = "" Or Me.DtcSalDescForm.Text = "" Or Me.DtcSalNotCred.Text = "" Or Me.DtcSalTransF.Text = "" Or Me.txtCostos.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If TxtPorcenPercep.Text.Trim = "" Then
            TxtPorcenPercep.Text = "0.00"
        End If

        If boest = False Then
            sql = "NSP_ins_CONFIGINV " & tnromovi.Text & "," & Me.tnroinv.Text & ",'" & Me.DtcIngtransF.SelectedValue.ToString & "','" & Me.DtcIngComp.SelectedValue.ToString & "','" & Me.DtcIngajuste.SelectedValue.ToString & "','" & Me.DtcIngFormula.SelectedValue.ToString & "','" & Me.DtcSalTransF.SelectedValue.ToString & "','" & Me.DtcSalajuste.SelectedValue.ToString & "','" & Me.DtcSalDescForm.SelectedValue.ToString & "'," & Me.sinstockneg & "," & Me.tdecimalescant.Text & "," & Me.tdecimalescosto.Text & "," & Me.tdecimalesprecio.Text & "," & Me.tdecimalesresultado.Text & ",'" & Me.DtcSalNotCred.SelectedValue.ToString & "'," & Me.sininvfis & ",'" & Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value) & "','" & Me.DtcDocAjusIng.SelectedValue.ToString & "','" & Me.DtcDocAjusSal.SelectedValue.ToString & "'," & Me.tnrosemana.Text & "," & Me.sinacttransf & "," & Me.sindesclintrans & ",'" & Me.DtcIngrTransforma.SelectedValue.ToString & "','" & Me.DtcSalTransforma.SelectedValue.ToString & "','" & Me.cboalmacen.SelectedValue.ToString & "','" & Me.dtcnotcredesp.SelectedValue.ToString & "','" & codempresa & "','" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cingimportacion.SelectedValue.ToString & "','" & Me.cingcredito.SelectedValue.ToString & "'," & Me.tincpeso.Text & "," & Me.tincbulto.Text & "," & Integer.Parse(Me.txtNumOrden.Text.Trim) & "," & txtCostos.Text.Trim & ",'" & cbotransubcam.SelectedValue & "','" & cboIngTransSubcam.SelectedValue & "'"
            If TmpInsertDatos(sql) = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA 'INSERT','INSERT','CONFIGVENT','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                bloquea(False)
                Bloqueatextbox(Me)
            End If

        Else
            sql = "NSP_UPD_CONFIGINV " & tnromovi.Text & "," & Me.tnroinv.Text & ",'" & Me.DtcIngtransF.SelectedValue.ToString & "','" & Me.DtcIngComp.SelectedValue.ToString & "','" & Me.DtcIngajuste.SelectedValue.ToString & "','" & Me.DtcIngFormula.SelectedValue.ToString & "','" & Me.DtcSalTransF.SelectedValue.ToString & "','" & Me.DtcSalajuste.SelectedValue.ToString & "','" & Me.DtcSalDescForm.SelectedValue.ToString & "'," & Me.sinstockneg & "," & Me.tdecimalescant.Text & "," & Me.tdecimalescosto.Text & "," & Me.tdecimalesprecio.Text & "," & Me.tdecimalesresultado.Text & ",'" & Me.DtcSalNotCred.SelectedValue.ToString & "'," & Me.sininvfis & ",'" & Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value) & "','" & Me.DtcDocAjusIng.SelectedValue.ToString & "','" & Me.DtcDocAjusSal.SelectedValue.ToString & "'," & Me.tnrosemana.Text & "," & Me.sinacttransf & "," & Me.sindesclintrans & ",'" & Me.DtcIngrTransforma.Text & "','" & Me.DtcSalTransforma.Text & "','" & Me.cboalmacen.SelectedValue.ToString & "','" & Me.dtcnotcredesp.SelectedValue.ToString & "','" & codempresa & "','" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cingimportacion.SelectedValue.ToString & "','" & Me.cingcredito.SelectedValue.ToString & "'," & Me.tincpeso.Text & "," & Me.tincbulto.Text & "," & Integer.Parse(Me.txtNumOrden.Text.Trim) & "," & txtCostos.Text.Trim & ",'" & cbotransubcam.SelectedValue & "','" & cboIngTransSubcam.SelectedValue & "','" & Me.TxtCodSer.Text.Trim & "','" & Trim(Me.CboDocIng.SelectedValue.ToString()) & "','" & Trim(Me.CboDocSal.SelectedValue.ToString()) & "','" & Trim(Me.CboCodIngAjuste.SelectedValue.ToString()) & "','" & Trim(Me.CboCodIngProcMon.SelectedValue.ToString()) & "','" & CDbl(TxtPorcenPercep.Text) & "'"

            If TmpInsertDatos(sql) = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA 'UPDATE','UPDATE','CONFIGVENT','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                bloquea(False)
                Bloqueatextbox(Me)
            End If
        End If

        BOTONES(False, True)

        bloquea(False)
        Bloqueatextbox(Me)
        If PROCESO = False Then Exit Sub
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If Me.CheckBox3.Checked = True Then
            sininvfis = 1
        Else
            sininvfis = 0
        End If
    End Sub

    Private Sub tnromovi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnromovi.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tnroinv.Focus()
            Me.tnroinv.SelectAll()
        End If
    End Sub

    Private Sub tnroinv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnroinv.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcIngtransF.Focus()
        End If
    End Sub

    Private Sub DtcIngtransF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcIngtransF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcIngComp.Focus()
        End If
    End Sub

    Private Sub DtcIngComp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcIngComp.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcIngFormula.Focus()
        End If
    End Sub

    Private Sub DtcIngFormula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcIngFormula.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cingimportacion.Focus()
        End If
    End Sub

    Private Sub DtcSalTransF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcSalTransF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcSalNotCred.Focus()
        End If
    End Sub

    Private Sub DtcSalNotCred_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcSalNotCred.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcSalDescForm.Focus()
        End If
    End Sub

    Private Sub DtcSalDescForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcSalDescForm.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.dtcnotcredesp.Focus()
        End If
    End Sub

    Private Sub dtcnotcredesp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtcnotcredesp.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cboalmacen.Focus()
        End If
    End Sub

    Private Sub cboalmacen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboalmacen.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cbotransubcam.Focus()
            Me.cbotransubcam.SelectAll()
        End If
    End Sub

    Private Sub tnrosemana_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tnrosemana.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tnrosemana.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.txtCostos.Focus()
            Me.txtCostos.SelectAll()
        End If
    End Sub

    Private Sub tdecimalescant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdecimalescant.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tdecimalescant.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tdecimalescosto.Focus()
            Me.tdecimalescosto.SelectAll()
        End If
    End Sub

    Private Sub tdecimalescosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdecimalescosto.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tdecimalescosto.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tdecimalesprecio.Focus()
            Me.tdecimalesprecio.SelectAll()
        End If
    End Sub

    Private Sub tdecimalesprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdecimalesprecio.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tdecimalesprecio.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tdecimalesresultado.Focus()
            Me.tdecimalesresultado.SelectAll()
        End If
    End Sub

    Private Sub tdecimalesresultado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdecimalesresultado.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tdecimalesresultado.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tincpeso.Focus()
            Me.tincpeso.SelectAll()
        End If
    End Sub

    Private Sub CheckBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CheckBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.CheckBox2.Focus()
        End If
    End Sub

    Private Sub CheckBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CheckBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.RadioButton1.Focus()
        End If
    End Sub


    Private Sub RadioButton1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.RadioButton2.Focus()
        End If
    End Sub

    Private Sub RadioButton2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RadioButton2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcIngrTransforma.Focus()
        End If
    End Sub

    Private Sub DtcIngrTransforma_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcIngrTransforma.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcSalTransforma.Focus()
        End If
    End Sub

    Private Sub DtcSalTransforma_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcSalTransforma.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcIngajuste.Focus()
        End If
    End Sub

    Private Sub DtcIngajuste_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcIngajuste.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcDocAjusIng.Focus()
        End If
    End Sub

    Private Sub DtcDocAjusIng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcDocAjusIng.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcSalajuste.Focus()
        End If
    End Sub

    Private Sub DtcSalajuste_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcSalajuste.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DtcDocAjusSal.Focus()
        End If
    End Sub

    Private Sub DtcDocAjusSal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtcDocAjusSal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub cingimportacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cingimportacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cingcredito.Focus()
        End If
    End Sub

    Private Sub cingcredito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cingcredito.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DtcSalTransF.Focus()
        End If
    End Sub

    Private Sub tincpeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tincpeso.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tincpeso.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tincbulto.Focus()
            Me.tincbulto.SelectAll()
        End If
    End Sub

    Private Sub tincbulto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tincbulto.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tincpeso.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.CheckBox1.Focus()
        End If
    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub txtNumOrden_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumOrden.KeyPress
        If Asc(e.KeyChar) = 13 Then
            tdecimalescant.Focus()
            tdecimalescant.SelectAll()
        End If
    End Sub

    Private Sub tnrosemana_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tnrosemana.TextChanged

    End Sub

    Private Sub txtCostos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostos.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.txtNumOrden.Focus()
            Me.txtNumOrden.SelectAll()
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cboalmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboalmacen.SelectedIndexChanged

    End Sub

    Private Sub dtcnotcredesp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtcnotcredesp.SelectedIndexChanged

    End Sub

    Private Sub cbotransubcam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotransubcam.SelectedIndexChanged

    End Sub

    Private Sub cbotransubcam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbotransubcam.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.cboIngTransSubcam.Focus()
        End If

    End Sub

    Private Sub cboIngTransSubcam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIngTransSubcam.SelectedIndexChanged

    End Sub

    Private Sub cboIngTransSubcam_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboIngTransSubcam.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.CboDocIng.Focus()
        End If

    End Sub

    Private Sub CboDocSal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboDocSal.SelectedIndexChanged

    End Sub

    Private Sub CboDocSal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboDocSal.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.tnrosemana.Focus()
        End If

    End Sub

End Class


