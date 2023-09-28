Public Class FrmObsGuiaTrans
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tobs As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tdomp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPtollegada As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tdomd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tbrevete As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tchofer As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents trucchofer As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tcodchofer As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtrucremi As System.Windows.Forms.TextBox
    Friend WithEvents txtremite As System.Windows.Forms.TextBox
    Friend WithEvents btntransporte As System.Windows.Forms.Button
    Friend WithEvents txtdniremi As System.Windows.Forms.TextBox
    Friend WithEvents txtdnidestina As System.Windows.Forms.TextBox
    Friend WithEvents txtrucdesti As System.Windows.Forms.TextBox
    Friend WithEvents txtdestinatario As System.Windows.Forms.TextBox
    Friend WithEvents txtconfveh As System.Windows.Forms.TextBox
    Friend WithEvents txtnrocert As System.Windows.Forms.TextBox
    Friend WithEvents txtrucsubcont As System.Windows.Forms.TextBox
    Friend WithEvents txtsubcont As System.Windows.Forms.TextBox
    Friend WithEvents tprovinciap As System.Windows.Forms.ComboBox
    Friend WithEvents tdistritop As System.Windows.Forms.ComboBox
    Friend WithEvents tprovinciad As System.Windows.Forms.ComboBox
    Friend WithEvents tdistritod As System.Windows.Forms.ComboBox
    Friend WithEvents CboConductor As System.Windows.Forms.ComboBox
    Friend WithEvents cboplaca As System.Windows.Forms.ComboBox
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmObsGuiaTrans))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtdniremi = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtrucremi = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtremite = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tobs = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.tdistritop = New System.Windows.Forms.ComboBox
        Me.tprovinciap = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tdomp = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.tdistritod = New System.Windows.Forms.ComboBox
        Me.tprovinciad = New System.Windows.Forms.ComboBox
        Me.btnPtollegada = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tdomd = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CboConductor = New System.Windows.Forms.ComboBox
        Me.tbrevete = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.tchofer = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.trucchofer = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btntransporte = New System.Windows.Forms.Button
        Me.tcodchofer = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboplaca = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtmarca = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtnrocert = New System.Windows.Forms.TextBox
        Me.txtconfveh = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtdnidestina = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtrucdesti = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtdestinatario = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtrucsubcont = New System.Windows.Forms.TextBox
        Me.txtsubcont = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdniremi)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtrucremi)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtremite)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 137)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Remitente"
        '
        'txtdniremi
        '
        Me.txtdniremi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdniremi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdniremi.Location = New System.Drawing.Point(97, 96)
        Me.txtdniremi.Name = "txtdniremi"
        Me.txtdniremi.Size = New System.Drawing.Size(136, 21)
        Me.txtdniremi.TabIndex = 11
        Me.txtdniremi.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "TIPO y D.N.I. :"
        '
        'txtrucremi
        '
        Me.txtrucremi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrucremi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrucremi.Location = New System.Drawing.Point(97, 72)
        Me.txtrucremi.Name = "txtrucremi"
        Me.txtrucremi.Size = New System.Drawing.Size(136, 21)
        Me.txtrucremi.TabIndex = 9
        Me.txtrucremi.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "R.U.C. :"
        '
        'txtremite
        '
        Me.txtremite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtremite.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremite.Location = New System.Drawing.Point(8, 48)
        Me.txtremite.Name = "txtremite"
        Me.txtremite.Size = New System.Drawing.Size(328, 21)
        Me.txtremite.TabIndex = 7
        Me.txtremite.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 17)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "APE. Y NOM. /DENOMINACION/RAZON SOCIAL :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Observaciones :    (Máx 200 carácteres)"
        '
        'tobs
        '
        Me.tobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tobs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tobs.Location = New System.Drawing.Point(439, 33)
        Me.tobs.MaxLength = 200
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tobs.Size = New System.Drawing.Size(274, 57)
        Me.tobs.TabIndex = 9
        Me.tobs.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tdistritop)
        Me.GroupBox2.Controls.Add(Me.tprovinciap)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tdomp)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(357, 104)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Partida"
        '
        'tdistritop
        '
        Me.tdistritop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tdistritop.Location = New System.Drawing.Point(84, 70)
        Me.tdistritop.Name = "tdistritop"
        Me.tdistritop.Size = New System.Drawing.Size(253, 21)
        Me.tdistritop.TabIndex = 6
        '
        'tprovinciap
        '
        Me.tprovinciap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tprovinciap.Location = New System.Drawing.Point(85, 45)
        Me.tprovinciap.Name = "tprovinciap"
        Me.tprovinciap.Size = New System.Drawing.Size(251, 21)
        Me.tprovinciap.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Provincia :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Distrito : "
        '
        'tdomp
        '
        Me.tdomp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdomp.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdomp.Location = New System.Drawing.Point(85, 21)
        Me.tdomp.Name = "tdomp"
        Me.tdomp.Size = New System.Drawing.Size(251, 21)
        Me.tdomp.TabIndex = 1
        Me.tdomp.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Domicilio :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tdistritod)
        Me.GroupBox3.Controls.Add(Me.tprovinciad)
        Me.GroupBox3.Controls.Add(Me.btnPtollegada)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.tdomd)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(377, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(365, 104)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Destino"
        '
        'tdistritod
        '
        Me.tdistritod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tdistritod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdistritod.Location = New System.Drawing.Point(69, 72)
        Me.tdistritod.Name = "tdistritod"
        Me.tdistritod.Size = New System.Drawing.Size(251, 21)
        Me.tdistritod.TabIndex = 14
        '
        'tprovinciad
        '
        Me.tprovinciad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tprovinciad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tprovinciad.Location = New System.Drawing.Point(70, 48)
        Me.tprovinciad.Name = "tprovinciad"
        Me.tprovinciad.Size = New System.Drawing.Size(250, 21)
        Me.tprovinciad.TabIndex = 13
        '
        'btnPtollegada
        '
        Me.btnPtollegada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPtollegada.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPtollegada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPtollegada.ImageIndex = 5
        Me.btnPtollegada.ImageList = Me.ImageList1
        Me.btnPtollegada.Location = New System.Drawing.Point(320, 24)
        Me.btnPtollegada.Name = "btnPtollegada"
        Me.btnPtollegada.Size = New System.Drawing.Size(41, 23)
        Me.btnPtollegada.TabIndex = 12
        Me.btnPtollegada.Text = "..."
        Me.btnPtollegada.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Provincia :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Distrito : "
        '
        'tdomd
        '
        Me.tdomd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdomd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdomd.Location = New System.Drawing.Point(70, 24)
        Me.tdomd.Name = "tdomd"
        Me.tdomd.Size = New System.Drawing.Size(248, 21)
        Me.tdomd.TabIndex = 4
        Me.tdomd.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Domicilio :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CboConductor)
        Me.GroupBox4.Controls.Add(Me.tbrevete)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.tchofer)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.trucchofer)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.btntransporte)
        Me.GroupBox4.Controls.Add(Me.tcodchofer)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cboplaca)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtmarca)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtnrocert)
        Me.GroupBox4.Controls.Add(Me.txtconfveh)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(733, 133)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Transportista"
        '
        'CboConductor
        '
        Me.CboConductor.Location = New System.Drawing.Point(85, 48)
        Me.CboConductor.Name = "CboConductor"
        Me.CboConductor.Size = New System.Drawing.Size(280, 21)
        Me.CboConductor.TabIndex = 25
        '
        'tbrevete
        '
        Me.tbrevete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbrevete.Location = New System.Drawing.Point(86, 72)
        Me.tbrevete.Name = "tbrevete"
        Me.tbrevete.ReadOnly = True
        Me.tbrevete.Size = New System.Drawing.Size(103, 21)
        Me.tbrevete.TabIndex = 12
        Me.tbrevete.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Brevete :"
        '
        'tchofer
        '
        Me.tchofer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tchofer.Location = New System.Drawing.Point(240, 24)
        Me.tchofer.Name = "tchofer"
        Me.tchofer.ReadOnly = True
        Me.tchofer.Size = New System.Drawing.Size(208, 21)
        Me.tchofer.TabIndex = 22
        Me.tchofer.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 17)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Conductor : "
        '
        'trucchofer
        '
        Me.trucchofer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trucchofer.Location = New System.Drawing.Point(86, 96)
        Me.trucchofer.Name = "trucchofer"
        Me.trucchofer.ReadOnly = True
        Me.trucchofer.Size = New System.Drawing.Size(104, 21)
        Me.trucchofer.TabIndex = 19
        Me.trucchofer.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "RUC :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btntransporte
        '
        Me.btntransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntransporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntransporte.ImageIndex = 5
        Me.btntransporte.ImageList = Me.ImageList1
        Me.btntransporte.Location = New System.Drawing.Point(197, 21)
        Me.btntransporte.Name = "btntransporte"
        Me.btntransporte.Size = New System.Drawing.Size(41, 23)
        Me.btntransporte.TabIndex = 11
        Me.btntransporte.Text = "..."
        Me.btntransporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcodchofer
        '
        Me.tcodchofer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcodchofer.Location = New System.Drawing.Point(85, 22)
        Me.tcodchofer.Name = "tcodchofer"
        Me.tcodchofer.Size = New System.Drawing.Size(113, 21)
        Me.tcodchofer.TabIndex = 10
        Me.tcodchofer.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Codigo : "
        '
        'cboplaca
        '
        Me.cboplaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboplaca.Location = New System.Drawing.Point(528, 24)
        Me.cboplaca.Name = "cboplaca"
        Me.cboplaca.Size = New System.Drawing.Size(160, 21)
        Me.cboplaca.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(480, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 17)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Marca : "
        '
        'txtmarca
        '
        Me.txtmarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmarca.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.Location = New System.Drawing.Point(528, 48)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.ReadOnly = True
        Me.txtmarca.Size = New System.Drawing.Size(160, 21)
        Me.txtmarca.TabIndex = 15
        Me.txtmarca.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(472, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 17)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Placa : "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(408, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 17)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Nº Certif. Incripción :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtnrocert
        '
        Me.txtnrocert.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnrocert.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnrocert.Location = New System.Drawing.Point(528, 72)
        Me.txtnrocert.Name = "txtnrocert"
        Me.txtnrocert.ReadOnly = True
        Me.txtnrocert.Size = New System.Drawing.Size(160, 21)
        Me.txtnrocert.TabIndex = 31
        Me.txtnrocert.Text = ""
        '
        'txtconfveh
        '
        Me.txtconfveh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtconfveh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfveh.Location = New System.Drawing.Point(528, 96)
        Me.txtconfveh.Name = "txtconfveh"
        Me.txtconfveh.ReadOnly = True
        Me.txtconfveh.Size = New System.Drawing.Size(160, 21)
        Me.txtconfveh.TabIndex = 36
        Me.txtconfveh.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(408, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 17)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Config. Vehicular :"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnaceptar
        '
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar.Location = New System.Drawing.Point(440, 520)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(140, 24)
        Me.btnaceptar.TabIndex = 22
        Me.btnaceptar.Text = "Aceptar "
        '
        'btncancelar
        '
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.Location = New System.Drawing.Point(600, 520)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(137, 25)
        Me.btncancelar.TabIndex = 23
        Me.btncancelar.Text = "Cancelar"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtdnidestina)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtrucdesti)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtdestinatario)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(379, 118)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(365, 137)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Datos Destinatario"
        '
        'txtdnidestina
        '
        Me.txtdnidestina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdnidestina.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdnidestina.Location = New System.Drawing.Point(97, 96)
        Me.txtdnidestina.Name = "txtdnidestina"
        Me.txtdnidestina.Size = New System.Drawing.Size(136, 21)
        Me.txtdnidestina.TabIndex = 11
        Me.txtdnidestina.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "TIPO y D.N.I. :"
        '
        'txtrucdesti
        '
        Me.txtrucdesti.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrucdesti.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrucdesti.Location = New System.Drawing.Point(97, 72)
        Me.txtrucdesti.Name = "txtrucdesti"
        Me.txtrucdesti.Size = New System.Drawing.Size(136, 21)
        Me.txtrucdesti.TabIndex = 9
        Me.txtrucdesti.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(41, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(43, 17)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "R.U.C. :"
        '
        'txtdestinatario
        '
        Me.txtdestinatario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdestinatario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestinatario.Location = New System.Drawing.Point(8, 48)
        Me.txtdestinatario.Name = "txtdestinatario"
        Me.txtdestinatario.Size = New System.Drawing.Size(328, 21)
        Me.txtdestinatario.TabIndex = 7
        Me.txtdestinatario.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(249, 17)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "APE. Y NOM. /DENOMINACION/RAZON SOCIAL :"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Controls.Add(Me.txtrucsubcont)
        Me.GroupBox7.Controls.Add(Me.txtsubcont)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.tobs)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(8, 408)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(736, 104)
        Me.GroupBox7.TabIndex = 26
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Datos Empresa SubContratada"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(43, 17)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "R.U.C. :"
        '
        'txtrucsubcont
        '
        Me.txtrucsubcont.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtrucsubcont.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrucsubcont.Location = New System.Drawing.Point(72, 67)
        Me.txtrucsubcont.Name = "txtrucsubcont"
        Me.txtrucsubcont.Size = New System.Drawing.Size(136, 21)
        Me.txtrucsubcont.TabIndex = 12
        Me.txtrucsubcont.Text = ""
        '
        'txtsubcont
        '
        Me.txtsubcont.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsubcont.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubcont.Location = New System.Drawing.Point(16, 40)
        Me.txtsubcont.Name = "txtsubcont"
        Me.txtsubcont.Size = New System.Drawing.Size(360, 21)
        Me.txtsubcont.TabIndex = 11
        Me.txtsubcont.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(249, 17)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "APE. Y NOM. /DENOMINACION/RAZON SOCIAL :"
        '
        'FrmObsGuiaTrans
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(755, 558)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.btncancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmObsGuiaTrans"
        Me.Text = "Observaciones Guia Transportista"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AFrmGuiaTrans As New FrmGuiaTransp

    Public AIntValor As Integer
    'Public AObjBus As New ClsInterface

    Private Sub FrmObsGuiaTrans_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim dtp As New DataTable
            dtp = CAyuda.ListarDatos("NSP_SELECT_LISTA_PROVINCIA", codempresa).Tables(0)
            tprovinciap.ValueMember = "CODCIUDAD"
            tprovinciap.DisplayMember = "DESCIUDAD"
            tprovinciap.DataSource = dtp
       
            tprovinciad.ValueMember = "CODCIUDAD"
            tprovinciad.DisplayMember = "DESCIUDAD"
            tprovinciad.DataSource = dtp
         
            'CAyuda.CargarDataCombo(tprovinciap, "NSP_SELECT_LISTA_PROVINCIA" & " '" & codempresa & "'", "CODCIUDAD", "DESCIUDAD")
            'CAyuda.CargarDataCombo(tprovinciad, "NSP_SELECT_LISTA_PROVINCIA", "CODCIUDAD", "DESCIUDAD")

        If AFrmGuiaTrans.ABoolEstado = True Then
            txtremite.Text = AFrmGuiaTrans.txtdescliente.Text
            txtrucremi.Text = AFrmGuiaTrans.txtruc.Text
            Dim ATBLDIR As New DataTable
                ATBLDIR = CAyuda.ListarDatos("NSP_SELECT_BUSCA_DIERCCION", NROPTOVTA, codempresa).Tables(0)
            Me.tdomp.Text = ATBLDIR.Rows(0)("DIRPTOVTA")
            Me.tprovinciap.SelectedValue = ATBLDIR.Rows(0)("CODCIUDAD")
            Me.tdistritop.SelectedValue = ATBLDIR.Rows(0)("CodDis")
                tdomd.Text = CAyuda.ValidaNullSTring(CAyuda.ListarDatos("NSP_SELECT_BUSCA_DIRCLIENTE", GValidarVacios(AFrmGuiaTrans.txtcodcliente.Text), codempresa).Tables(0).Rows(0)(0))
            tdomp.Focus()
        Else

            llenar()
        End If
        If AFrmGuiaTrans.ABoolMod = False Then
            Bloqueatextbox(Me)
            btnPtollegada.Enabled = False
            btntransporte.Enabled = False
        Else
            btnPtollegada.Enabled = True
            btntransporte.Enabled = True
        End If

        '*******************************************************************************************
        If Me.tcodchofer.Text.Trim <> "" Then
                CAyuda.CargarDataCombo(CboConductor, "sp_obt_conductor_empresa '" & Me.tcodchofer.Text & "'", "brevete", "conductor")
            CboConductor.SelectedValue = AFrmGuiaTrans.x
            tbrevete.Text = CboConductor.SelectedValue
                CAyuda.CargarDataCombo(Me.cboplaca, "USP_LISTAR_PLACA '" & Me.tcodchofer.Text & "'", "CODTRANSPOR", "PLACA")
            Dim TblPlaca As New DataTable
                TblPlaca = CAyuda.ListarDatos("USP_LISTAR_MARCA", Me.cboplaca.Text.Trim).Tables(0)
            Me.txtmarca.Text = TblPlaca.Rows(0).Item("MARCA")
            End If

        Catch ex As Exception

        End Try
    End Sub
    Dim Ayuda As New ClsAyuda
    Private Sub btntransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntransporte.Click
        Dim men As New frm_transportista
        AIntValor = 1
        men.AFrmGuiaTrans = Me
        men.v = True
        men.ShowDialog(Me)
        'AObjBus.GCargaDataCombo(Me.cboplaca, CAyuda.ListarDatos("NSP_SELECT_LISTA_TRANSPORTISTA_VEHICULO", tcodchofer.Text, codempresa).Tables(0), "CODIGO", "DESCRIPCION")
        tcodchofer.Focus()
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        AFrmGuiaTrans.x = Me.tbrevete.Text.Trim
        AFrmGuiaTrans.AStrDomP = Me.tdomp.Text
        AFrmGuiaTrans.AStrDomD = Me.tdomd.Text
        AFrmGuiaTrans.AStrDistP = Me.tdistritop.Text
        AFrmGuiaTrans.AStrProvP = Me.tprovinciap.Text
        AFrmGuiaTrans.AStrDistD = Me.tdistritod.Text
        AFrmGuiaTrans.AStrProvD = Me.tprovinciad.Text
        AFrmGuiaTrans.AStrRemi = Me.txtremite.Text
        AFrmGuiaTrans.AStrRucRemi = Me.txtrucremi.Text
        AFrmGuiaTrans.AStrDniRemi = Me.txtdniremi.Text
        AFrmGuiaTrans.AStrDestina = Me.txtdestinatario.Text
        AFrmGuiaTrans.AStrRucDestina = Me.txtrucdesti.Text
        AFrmGuiaTrans.AStrDniDestina = Me.txtdnidestina.Text
        AFrmGuiaTrans.AStrCodtransp = Me.tcodchofer.Text
        AFrmGuiaTrans.AStrDesctransp = Me.tchofer.Text
        AFrmGuiaTrans.AStrRuctransp = Me.trucchofer.Text
        AFrmGuiaTrans.AStrBrevete = Me.tbrevete.Text
        AFrmGuiaTrans.AStrMarca = Me.cboplaca.SelectedValue
        If AFrmGuiaTrans.AStrMarca = Nothing Then
            AFrmGuiaTrans.AStrMarca = ""
        End If
        AFrmGuiaTrans.AStrPlaca = Me.cboplaca.Text
        AFrmGuiaTrans.AStrNrocert = Me.txtnrocert.Text
        AFrmGuiaTrans.AStrConfigVeh = Me.txtconfveh.Text
        AFrmGuiaTrans.AStrEmpresaSubCont = Me.txtsubcont.Text
        AFrmGuiaTrans.AStrRucEmpSubCont = Me.txtrucsubcont.Text
        AFrmGuiaTrans.AStrObvs = Me.tobs.Text.Trim
        AFrmGuiaTrans.ABoolEstado = False
        Me.Close()

    End Sub
    Sub llenar()
        Me.tdomp.Text = AFrmGuiaTrans.AStrDomP
        Me.tdomd.Text = AFrmGuiaTrans.AStrDomD
        Me.tdistritop.Text = AFrmGuiaTrans.AStrDistP
        Me.tprovinciap.Text = AFrmGuiaTrans.AStrProvP
        Me.tdistritod.Text = AFrmGuiaTrans.AStrDistD
        Me.tprovinciad.Text = AFrmGuiaTrans.AStrProvD
        Me.txtremite.Text = AFrmGuiaTrans.AStrRemi
        Me.txtrucremi.Text = AFrmGuiaTrans.AStrRucRemi
        Me.txtdniremi.Text = AFrmGuiaTrans.AStrDniRemi
        Me.txtdestinatario.Text = AFrmGuiaTrans.AStrDestina
        Me.txtrucdesti.Text = AFrmGuiaTrans.AStrRucDestina
        Me.txtdnidestina.Text = AFrmGuiaTrans.AStrDniDestina
        Me.tcodchofer.Text = AFrmGuiaTrans.AStrCodtransp
        'AObjBus.GCargaDataCombo(txtmarca, CAyuda.ListarDatos("NSP_SELECT_LISTA_TRANSPORTISTA_VEHICULO", tcodchofer.Text, codempresa).Tables(0), "CODIGO", "DESCRIPCION")
        Me.tchofer.Text = AFrmGuiaTrans.AStrDesctransp
        Me.trucchofer.Text = AFrmGuiaTrans.AStrRuctransp
        Me.tbrevete.Text = AFrmGuiaTrans.AStrBrevete
        Me.txtmarca.Text = AFrmGuiaTrans.AStrMarca
        Me.cboplaca.Text = AFrmGuiaTrans.AStrPlaca
        Me.txtnrocert.Text = AFrmGuiaTrans.AStrNrocert
        Me.txtconfveh.Text = AFrmGuiaTrans.AStrConfigVeh
        Me.txtsubcont.Text = AFrmGuiaTrans.AStrEmpresaSubCont
        Me.txtrucsubcont.Text = AFrmGuiaTrans.AStrRucEmpSubCont
        Me.tobs.Text = AFrmGuiaTrans.AStrObvs
    End Sub
    Private Sub btncancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
    Private Sub btnPtollegada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPtollegada.Click
        'Dim men As New FrmPtoLlegada
        'AIntValor = 1
        'men.AFrmObsGuiTran = Me
        'men.ShowDialog(Me)
    End Sub
    Private Sub tdomd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdomd.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tprovinciad.Focus()
        End If
    End Sub
    Private Sub tdistritop_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdistritop.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tdomd.Focus()
        End If
    End Sub
    Private Sub tprovinciap_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tprovinciap.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tdistritop.Focus()
        End If
    End Sub
    Private Sub tdomp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdomp.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tprovinciap.Focus()
        End If
    End Sub
    Private Sub tdistritod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdistritod.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtremite.Focus()
        End If
    End Sub
    Private Sub tprovinciad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tprovinciad.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tdistritod.Focus()
        End If
    End Sub
    Private Sub txtremite_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtremite.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtrucremi.Focus()
        End If
    End Sub

    Private Sub txtrucremi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrucremi.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdniremi.Focus()
        End If
    End Sub

    Private Sub txtdniremi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdniremi.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdestinatario.Focus()
        End If
    End Sub

    Private Sub txtdestinatario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdestinatario.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtrucdesti.Focus()
        End If
    End Sub

    Private Sub txtrucdesti_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrucdesti.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdnidestina.Focus()
        End If
    End Sub

    Private Sub txtdnidestina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdnidestina.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tcodchofer.Focus()
        End If
    End Sub

    Private Sub tcodchofer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodchofer.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tbrevete.Focus()
        End If
    End Sub

    Private Sub tbrevete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbrevete.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtmarca.Focus()
        End If
    End Sub


    Private Sub txtmarca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboplaca.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cboplaca.Focus()
        End If
    End Sub

    Private Sub txtpalca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmarca.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtnrocert.Focus()
        End If
    End Sub

    Private Sub txtnrocert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnrocert.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtconfveh.Focus()
        End If
    End Sub

    Private Sub txtconfveh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtconfveh.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtsubcont.Focus()
        End If
    End Sub

    Private Sub txtsubcont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsubcont.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtrucsubcont.Focus()
        End If
    End Sub

    Private Sub txtrucsubcont_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrucsubcont.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            tobs.Focus()
        End If
    End Sub

    Private Sub tprovinciap_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tprovinciap.SelectedIndexChanged
        Try
            '  MsgBox(tprovinciap.SelectedValue)
            If tprovinciap.SelectedValue <> "System.Data.DataRowView" Then
                CAyuda.CargarDataCombo(tdistritop, "NSP_SELECT_LISTA_DISTRITO  '" & tprovinciap.SelectedValue.ToString() & "'," & "'" & codempresa & "'", "coddis", "DESCRIPCION")
            End If
        Catch
        End Try
    End Sub

    Private Sub tprovinciad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tprovinciad.SelectedIndexChanged
        Try
            '  MsgBox(tprovinciap.SelectedValue)
            If tprovinciad.SelectedValue.ToString() <> "System.Data.DataRowView" Then
                CAyuda.CargarDataCombo(tdistritod, "NSP_SELECT_LISTA_DISTRITO  '" & tprovinciad.SelectedValue.ToString() & "'," & "'" & codempresa & "'", "coddis", "DESCRIPCION")
            End If
        Catch
        End Try
    End Sub

    Private Sub FrmObsGuiaTrans_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        tprovinciap.Focus()
    End Sub

    Private Sub txtmarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboplaca.SelectedIndexChanged
        Try
            Dim ATblVehi As New DataTable
            If AFrmGuiaTrans.ABoolEstado = False Then
                If cboplaca.SelectedValue.ToString() <> "System.Data.DataRowView" Then
                    Me.cboplaca.SelectedValue = AFrmGuiaTrans.AStrMarca
                    ATblVehi = CAyuda.ListarDatos("NSP_SELECT_LISTA_VEHICULO", cboplaca.SelectedValue.ToString(), codempresa).Tables(0)
                    cboplaca.Text = ATblVehi.Rows(0)("PLACA")
                    txtnrocert.Text = ATblVehi.Rows(0)("CERTIFICADO")
                End If
            Else
                If cboplaca.SelectedValue.ToString() <> "System.Data.DataRowView" Then
                    ATblVehi = CAyuda.ListarDatos("NSP_SELECT_LISTA_VEHICULO", cboplaca.SelectedValue.ToString(), codempresa).Tables(0)
                    cboplaca.Text = ATblVehi.Rows(0)("PLACA")
                    txtnrocert.Text = ATblVehi.Rows(0)("CERTIFICADO")
                End If

            End If
        Catch
        End Try
    End Sub

    Private Sub tcodchofer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tcodchofer.KeyDown
        If e.KeyCode = Keys.F2 Then
            btntransporte_Click(sender, e)
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub CboConductor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboConductor.SelectedIndexChanged
        If aux = True Then
            CAyuda.CargarDataCombo(cboplaca, "sp_obt_vehi_conduc '" & CboConductor.SelectedValue & "'", "marca", "placa")
            tbrevete.Text = CboConductor.SelectedValue
        End If
    End Sub
    Dim aux As Boolean
    Private Sub CboConductor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboConductor.Click
        aux = True
    End Sub
    Private Sub FrmObsGuiaTrans_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        aux = False
    End Sub
End Class
