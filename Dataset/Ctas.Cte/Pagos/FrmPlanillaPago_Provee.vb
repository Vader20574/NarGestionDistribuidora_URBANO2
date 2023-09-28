Public Class FrmPlanillaPago_Provee
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
    Friend WithEvents DgCompCred As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents LblNroDoc As System.Windows.Forms.Label
    Friend WithEvents LblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents TxtAcuenta As System.Windows.Forms.TextBox
    Friend WithEvents LblCodtipodoc As System.Windows.Forms.Label
    Friend WithEvents TxtTotalPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LblTotalDeuda As System.Windows.Forms.Label
    Friend WithEvents TxtCodProvee As System.Windows.Forms.TextBox
    Friend WithEvents LblRuc As System.Windows.Forms.Label
    Friend WithEvents LblSaldo As System.Windows.Forms.Label
    Friend WithEvents LblPercep As System.Windows.Forms.Label
    Friend WithEvents BtnBusProvee As System.Windows.Forms.Button
    Friend WithEvents LblDesProvee As System.Windows.Forms.Label
    Friend WithEvents DtFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtNroPago As System.Windows.Forms.TextBox
    Friend WithEvents TxtInteresletra As System.Windows.Forms.TextBox
    Friend WithEvents Lblprovee As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblFechaDoc As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblTotalPercep As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblTotalInteres As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblTotalAcuenta As System.Windows.Forms.Label
    Friend WithEvents btnBuscaPlanilla As System.Windows.Forms.Button
    Friend WithEvents txtNumPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlanillaPago_Provee))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LblFechaDoc = New System.Windows.Forms.Label
        Me.TxtInteresletra = New System.Windows.Forms.TextBox
        Me.LblSaldo = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Lblprovee = New System.Windows.Forms.Label
        Me.LblNroDoc = New System.Windows.Forms.Label
        Me.LblTipoDoc = New System.Windows.Forms.Label
        Me.TxtAcuenta = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblCodtipodoc = New System.Windows.Forms.Label
        Me.LblPercep = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DgCompCred = New System.Windows.Forms.DataGrid
        Me.TxtTotalPagado = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblTotalDeuda = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblDesProvee = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtCodProvee = New System.Windows.Forms.TextBox
        Me.LblRuc = New System.Windows.Forms.Label
        Me.BtnBusProvee = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.DtFechaPago = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtNroPago = New System.Windows.Forms.TextBox
        Me.LblTotalPercep = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblTotalInteres = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.LblTotalAcuenta = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnBuscaPlanilla = New System.Windows.Forms.Button
        Me.txtNumPlanilla = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgCompCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblFechaDoc)
        Me.GroupBox1.Controls.Add(Me.TxtInteresletra)
        Me.GroupBox1.Controls.Add(Me.LblSaldo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Lblprovee)
        Me.GroupBox1.Controls.Add(Me.LblNroDoc)
        Me.GroupBox1.Controls.Add(Me.LblTipoDoc)
        Me.GroupBox1.Controls.Add(Me.TxtAcuenta)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblCodtipodoc)
        Me.GroupBox1.Controls.Add(Me.LblPercep)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LblFechaDoc
        '
        Me.LblFechaDoc.BackColor = System.Drawing.Color.White
        Me.LblFechaDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFechaDoc.Location = New System.Drawing.Point(450, 10)
        Me.LblFechaDoc.Name = "LblFechaDoc"
        Me.LblFechaDoc.Size = New System.Drawing.Size(100, 20)
        Me.LblFechaDoc.TabIndex = 177
        Me.LblFechaDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtInteresletra
        '
        Me.TxtInteresletra.BackColor = System.Drawing.Color.White
        Me.TxtInteresletra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInteresletra.Location = New System.Drawing.Point(270, 64)
        Me.TxtInteresletra.Name = "TxtInteresletra"
        Me.TxtInteresletra.Size = New System.Drawing.Size(70, 20)
        Me.TxtInteresletra.TabIndex = 175
        Me.TxtInteresletra.Text = "0.00"
        Me.TxtInteresletra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblSaldo
        '
        Me.LblSaldo.BackColor = System.Drawing.Color.White
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaldo.Location = New System.Drawing.Point(630, 36)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(70, 20)
        Me.LblSaldo.TabIndex = 173
        Me.LblSaldo.Text = "0.00"
        Me.LblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(560, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 172
        Me.Label18.Text = "Saldo Pagar : "
        '
        'Lblprovee
        '
        Me.Lblprovee.BackColor = System.Drawing.Color.White
        Me.Lblprovee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lblprovee.Location = New System.Drawing.Point(270, 36)
        Me.Lblprovee.Name = "Lblprovee"
        Me.Lblprovee.Size = New System.Drawing.Size(254, 20)
        Me.Lblprovee.TabIndex = 170
        Me.Lblprovee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNroDoc
        '
        Me.LblNroDoc.BackColor = System.Drawing.Color.White
        Me.LblNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroDoc.Location = New System.Drawing.Point(96, 36)
        Me.LblNroDoc.Name = "LblNroDoc"
        Me.LblNroDoc.Size = New System.Drawing.Size(78, 20)
        Me.LblNroDoc.TabIndex = 168
        Me.LblNroDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTipoDoc
        '
        Me.LblTipoDoc.BackColor = System.Drawing.Color.White
        Me.LblTipoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTipoDoc.Location = New System.Drawing.Point(142, 10)
        Me.LblTipoDoc.Name = "LblTipoDoc"
        Me.LblTipoDoc.Size = New System.Drawing.Size(190, 20)
        Me.LblTipoDoc.TabIndex = 167
        Me.LblTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtAcuenta
        '
        Me.TxtAcuenta.BackColor = System.Drawing.Color.White
        Me.TxtAcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAcuenta.Location = New System.Drawing.Point(630, 66)
        Me.TxtAcuenta.Name = "TxtAcuenta"
        Me.TxtAcuenta.Size = New System.Drawing.Size(70, 20)
        Me.TxtAcuenta.TabIndex = 165
        Me.TxtAcuenta.Text = "0.00"
        Me.TxtAcuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Nro Documento : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(576, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "ACuenta : "
        '
        'LblCodtipodoc
        '
        Me.LblCodtipodoc.BackColor = System.Drawing.Color.White
        Me.LblCodtipodoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCodtipodoc.Location = New System.Drawing.Point(96, 10)
        Me.LblCodtipodoc.Name = "LblCodtipodoc"
        Me.LblCodtipodoc.Size = New System.Drawing.Size(43, 20)
        Me.LblCodtipodoc.TabIndex = 168
        Me.LblCodtipodoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPercep
        '
        Me.LblPercep.BackColor = System.Drawing.Color.White
        Me.LblPercep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPercep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPercep.Location = New System.Drawing.Point(96, 64)
        Me.LblPercep.Name = "LblPercep"
        Me.LblPercep.Size = New System.Drawing.Size(70, 20)
        Me.LblPercep.TabIndex = 173
        Me.LblPercep.Text = "0.00"
        Me.LblPercep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 13)
        Me.Label21.TabIndex = 172
        Me.Label21.Text = "Percepcion : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(208, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 171
        Me.Label17.Text = "Proveedor : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Tipo Documento : "
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(200, 68)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(71, 13)
        Me.Label22.TabIndex = 174
        Me.Label22.Text = "Interes letra : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(378, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 178
        Me.Label2.Text = "Fecha Doc. : "
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 166
        Me.PictureBox1.TabStop = False
        '
        'DgCompCred
        '
        Me.DgCompCred.CaptionText = "               Para  Seleccinar= [Enter]  ó  Doble Click"
        Me.DgCompCred.DataMember = ""
        Me.DgCompCred.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgCompCred.Location = New System.Drawing.Point(12, 206)
        Me.DgCompCred.Name = "DgCompCred"
        Me.DgCompCred.ReadOnly = True
        Me.DgCompCred.Size = New System.Drawing.Size(762, 220)
        Me.DgCompCred.TabIndex = 4
        '
        'TxtTotalPagado
        '
        Me.TxtTotalPagado.BackColor = System.Drawing.Color.White
        Me.TxtTotalPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalPagado.Location = New System.Drawing.Point(670, 432)
        Me.TxtTotalPagado.Name = "TxtTotalPagado"
        Me.TxtTotalPagado.ReadOnly = True
        Me.TxtTotalPagado.Size = New System.Drawing.Size(100, 22)
        Me.TxtTotalPagado.TabIndex = 158
        Me.TxtTotalPagado.Text = "0.00"
        Me.TxtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox3.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox3.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox3.Location = New System.Drawing.Point(780, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 264)
        Me.GroupBox3.TabIndex = 162
        Me.GroupBox3.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.ImageIndex = 0
        Me.btnNuevo.ImageList = Me.ImageList1
        Me.btnNuevo.Location = New System.Drawing.Point(8, 24)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 28)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.Text = "Nuevo"
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageIndex = 11
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(8, 147)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 28)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "     &Imprimir Pago"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(8, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 28)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "&Anular"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 5
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(8, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "    &Consultar"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(8, 55)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(102, 28)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Pagar"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(8, 179)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(102, 28)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCERRAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 13
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(8, 211)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(102, 28)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "Salir"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(582, 436)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 16)
        Me.Label14.TabIndex = 171
        Me.Label14.Text = "Total Pago : "
        '
        'LblTotalDeuda
        '
        Me.LblTotalDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDeuda.Location = New System.Drawing.Point(456, 88)
        Me.LblTotalDeuda.Name = "LblTotalDeuda"
        Me.LblTotalDeuda.Size = New System.Drawing.Size(140, 26)
        Me.LblTotalDeuda.TabIndex = 183
        Me.LblTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 16)
        Me.Label8.TabIndex = 182
        Me.Label8.Text = "Total Saldo Pagar : "
        '
        'LblDesProvee
        '
        Me.LblDesProvee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDesProvee.Location = New System.Drawing.Point(356, 62)
        Me.LblDesProvee.Name = "LblDesProvee"
        Me.LblDesProvee.Size = New System.Drawing.Size(294, 20)
        Me.LblDesProvee.TabIndex = 180
        Me.LblDesProvee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(164, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 179
        Me.Label13.Text = "R.U.C. : "
        '
        'TxtCodProvee
        '
        Me.TxtCodProvee.Location = New System.Drawing.Point(212, 62)
        Me.TxtCodProvee.Name = "TxtCodProvee"
        Me.TxtCodProvee.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodProvee.TabIndex = 178
        '
        'LblRuc
        '
        Me.LblRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRuc.Location = New System.Drawing.Point(210, 90)
        Me.LblRuc.Name = "LblRuc"
        Me.LblRuc.Size = New System.Drawing.Size(104, 20)
        Me.LblRuc.TabIndex = 177
        Me.LblRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBusProvee
        '
        Me.BtnBusProvee.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBusProvee.ImageIndex = 5
        Me.BtnBusProvee.ImageList = Me.ImageList1
        Me.BtnBusProvee.Location = New System.Drawing.Point(316, 60)
        Me.BtnBusProvee.Name = "BtnBusProvee"
        Me.BtnBusProvee.Size = New System.Drawing.Size(34, 26)
        Me.BtnBusProvee.TabIndex = 176
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(126, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 175
        Me.Label11.Text = "Cod Proveedor : "
        '
        'DtFechaPago
        '
        Me.DtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaPago.Location = New System.Drawing.Point(470, 34)
        Me.DtFechaPago.Name = "DtFechaPago"
        Me.DtFechaPago.Size = New System.Drawing.Size(90, 20)
        Me.DtFechaPago.TabIndex = 174
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 173
        Me.Label9.Text = "Fecha Pago : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 172
        Me.Label7.Text = "Nro Pago : "
        '
        'TxtNroPago
        '
        Me.TxtNroPago.BackColor = System.Drawing.Color.White
        Me.TxtNroPago.Enabled = False
        Me.TxtNroPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNroPago.Location = New System.Drawing.Point(212, 34)
        Me.TxtNroPago.Name = "TxtNroPago"
        Me.TxtNroPago.ReadOnly = True
        Me.TxtNroPago.Size = New System.Drawing.Size(106, 20)
        Me.TxtNroPago.TabIndex = 181
        Me.TxtNroPago.Text = "1"
        '
        'LblTotalPercep
        '
        Me.LblTotalPercep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPercep.Location = New System.Drawing.Point(306, 434)
        Me.LblTotalPercep.Name = "LblTotalPercep"
        Me.LblTotalPercep.Size = New System.Drawing.Size(84, 20)
        Me.LblTotalPercep.TabIndex = 187
        Me.LblTotalPercep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(198, 436)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "Total Percepcion : "
        '
        'LblTotalInteres
        '
        Me.LblTotalInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalInteres.Location = New System.Drawing.Point(486, 434)
        Me.LblTotalInteres.Name = "LblTotalInteres"
        Me.LblTotalInteres.Size = New System.Drawing.Size(84, 20)
        Me.LblTotalInteres.TabIndex = 189
        Me.LblTotalInteres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(396, 436)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 188
        Me.Label10.Text = "Total Interes : "
        '
        'LblTotalAcuenta
        '
        Me.LblTotalAcuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAcuenta.Location = New System.Drawing.Point(102, 434)
        Me.LblTotalAcuenta.Name = "LblTotalAcuenta"
        Me.LblTotalAcuenta.Size = New System.Drawing.Size(84, 20)
        Me.LblTotalAcuenta.TabIndex = 191
        Me.LblTotalAcuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 436)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 190
        Me.Label15.Text = "Total Acuenta : "
        '
        'btnBuscaPlanilla
        '
        Me.btnBuscaPlanilla.Enabled = False
        Me.btnBuscaPlanilla.ImageIndex = 5
        Me.btnBuscaPlanilla.ImageList = Me.ImageList1
        Me.btnBuscaPlanilla.Location = New System.Drawing.Point(464, 6)
        Me.btnBuscaPlanilla.Name = "btnBuscaPlanilla"
        Me.btnBuscaPlanilla.Size = New System.Drawing.Size(34, 26)
        Me.btnBuscaPlanilla.TabIndex = 193
        '
        'txtNumPlanilla
        '
        Me.txtNumPlanilla.Enabled = False
        Me.txtNumPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumPlanilla.Location = New System.Drawing.Point(292, 6)
        Me.txtNumPlanilla.Name = "txtNumPlanilla"
        Me.txtNumPlanilla.Size = New System.Drawing.Size(170, 26)
        Me.txtNumPlanilla.TabIndex = 192
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 11
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(788, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 28)
        Me.Button1.TabIndex = 194
        Me.Button1.Text = "     &Imprimir Pago"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(717, 23)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 195
        '
        'FrmPlanillaPago_Provee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1192, 607)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBuscaPlanilla)
        Me.Controls.Add(Me.txtNumPlanilla)
        Me.Controls.Add(Me.LblRuc)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCodProvee)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNroPago)
        Me.Controls.Add(Me.TxtTotalPagado)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblTotalInteres)
        Me.Controls.Add(Me.LblTotalPercep)
        Me.Controls.Add(Me.LblTotalDeuda)
        Me.Controls.Add(Me.LblDesProvee)
        Me.Controls.Add(Me.BtnBusProvee)
        Me.Controls.Add(Me.DtFechaPago)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DgCompCred)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblTotalAcuenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPlanillaPago_Provee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago a Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgCompCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Funciones de Form"
    Private Sub CargarGrid()

        Try
            TB_COMPRASCRED.Clear()
            TB_COMPRASCRED = TmpListarDatos("ListarTMP_PAGOSDETxCorrel  '" & codempresa & "','" & VCorrelInv & "'")
            DgCompCred.DataSource = TB_COMPRASCRED

            Dim TAB_TOTALMONTO As New DataTable
            Dim VTotPago, VTotDeuda, VTotAcuenta, VTotInteres, VTotPercep, VTotCredito, VTotSaldoPagado As Double
            TAB_TOTALMONTO = TmpListarDatos("SELECT  ISNULL(SUM(PAGCREDBAS),0)  AS PAGCREDBAS, ISNULL(SUM(SALDODISPBAS),0) AS SALDODISPBAS  ,  ISNULL(SUM(TOTCREDBAS),0) AS TOTCREDBAS ,ISNULL(SUM(PERCEPCION),0) AS PERCEPCION  , ISNULL(SUM(INTERESBAS),0) AS INTERESBAS  FROM TMP_PAGOSDET  WHERE CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelInv & "'")
            VTotAcuenta = FormatoMonto(CDbl(TAB_TOTALMONTO.Rows(0)("PAGCREDBAS")), DECIRESU)
            VTotInteres = FormatoMonto(CDbl(TAB_TOTALMONTO.Rows(0)("INTERESBAS")), DECIRESU)
            VTotPercep = FormatoMonto(CDbl(TAB_TOTALMONTO.Rows(0)("PERCEPCION")), DECIRESU)
            VTotCredito = FormatoMonto(CDbl(TAB_TOTALMONTO.Rows(0)("TOTCREDBAS")), DECIRESU)
            VTotSaldoPagado = FormatoMonto(CDbl(TAB_TOTALMONTO.Rows(0)("SALDODISPBAS")), DECIRESU)
            VTotPago = VTotAcuenta + VTotInteres + VTotPercep
            VTotDeuda = VTotCredito - (VTotSaldoPagado + VTotAcuenta)
            LblTotalAcuenta.Text = VTotAcuenta
            LblTotalInteres.Text = VTotInteres
            LblTotalPercep.Text = VTotPercep
            TxtTotalPagado.Text = VTotPago
            LblTotalDeuda.Text = VTotDeuda


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargarCuentaProvee() '
        CAyuda.Ejecutar("SP_InsTMP_PAGOSDETxProc", codempresa, VCorrelInv, TxtCodProvee.Text)
        CargarGrid()
        FormatoGrid()
    End Sub
    Private Sub Agregar()
        If LblCodtipodoc.Text.Trim = "" Then
            MsgBox("FALTA SELECCIONAR FILA...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If LblNroDoc.Text.Trim = "" Then
            MsgBox("FALTA SELECCIONAR FILA...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TxtAcuenta.Text.Trim = "" Then
            MsgBox("FALTA INDICAR EL ACUENTA..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If CDbl(LblSaldo.Text) < CDbl(TxtAcuenta.Text) Then
            MsgBox("EL ACUENTA NO PUEDE SER MAYOR AL IMPORTE...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        Dim CODTIPODOC As String
        Dim NUMERODOC As String
        CODTIPODOC = LblCodtipodoc.Text
        NUMERODOC = LblNroDoc.Text
        For i As Integer = 0 To TB_COMPRASCRED.Rows.Count - 1
            If TB_COMPRASCRED.Rows(i)("TIPODOCU") = CODTIPODOC And TB_COMPRASCRED.Rows(i)("NRODOCUM") = NUMERODOC Then
                TB_COMPRASCRED.Rows(i)("ACUENTA") = CDbl(TxtAcuenta.Text)
                Exit For
            End If
        Next
        TxtTotalPagado.Text = "0.00"
        For a As Integer = 0 To TB_COMPRASCRED.Rows.Count - 1
            TxtTotalPagado.Text = Format(CDbl(TxtTotalPagado.Text) + CDbl(TB_COMPRASCRED.Rows(a)("ACUENTA")), "#######0.00")
        Next

        LblCodtipodoc.Text = ""
        LblTipoDoc.Text = ""
        LblNroDoc.Text = ""
        'DtFecDoc.Value = Date.Now
        LblSaldo.Text = "0.00"
        TxtAcuenta.Text = "0.00"
        DgCompCred.Focus()




    End Sub
    Private Sub CargarCombos()
        'Call CargadataCombos(CboProveedor, "Nsp_sel_Proveedor2 '" & codempresa & "'", "codproveedor", "desproveedor")
    End Sub
    Private Sub EnviarDatos()
        If TB_COMPRASCRED.Rows.Count = 0 Then
            Exit Sub
        End If
        LblFechaDoc.Text = Format(CDate(DgCompCred.Item(DgCompCred.CurrentRowIndex, 0)), "dd/MM/yyyy")
        Lblprovee.Text = LblDesProvee.Text
        LblCodtipodoc.Text = DgCompCred.Item(DgCompCred.CurrentRowIndex, 1)
        LblTipoDoc.Text = DgCompCred.Item(DgCompCred.CurrentRowIndex, 2)
        LblNroDoc.Text = DgCompCred.Item(DgCompCred.CurrentRowIndex, 3)
        LblSaldo.Text = FormatoMonto(CDbl(DgCompCred.Item(DgCompCred.CurrentRowIndex, 7)), DECIRESU)
        TxtAcuenta.Text = FormatoMonto(CDbl(DgCompCred.Item(DgCompCred.CurrentRowIndex, 8)), DECIRESU)
        LblPercep.Text = FormatoMonto(CDbl(DgCompCred.Item(DgCompCred.CurrentRowIndex, 9)), DECIRESU)
        TxtInteresletra.Text = FormatoMonto(CDbl(DgCompCred.Item(DgCompCred.CurrentRowIndex, 10)), DECIRESU)
        If CDbl(TxtAcuenta.Text) = 0 Then
            TxtAcuenta.Text = CDbl(LblSaldo.Text)
        End If
        TxtAcuenta.Focus()

    End Sub
    Private Sub FormatoGrid()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TB_COMPRASCRED.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "FECDOCU"
            .HeaderText = "Fecha"
            .Format = "dd/MM/yyyy"
            .Width = 75
        End With

        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODTIPODOC"
            .HeaderText = "TIPODOCU"
            .Width = 0
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "DSTIPODOC"
            .HeaderText = "Documento"
            .Width = 120
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "NRODOCU"
            .HeaderText = "Nro Docum"
            .Width = 75
        End With
        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "CODPROVEEDOR"
            .HeaderText = "CodProveedor"
            .Width = 0
        End With
        'Dim column6 As New DataGridTextBoxColumn
        'With column6
        '    .MappingName = "DESPROVEEDOR"
        '    .HeaderText = "Desproveedor"
        '    .Width = 0
        'End With
        Dim Columm13 As New DataGridBoolColumn
        With Columm13
            .MappingName = "ACTPERCEP"
            .HeaderText = "Percepcion Boll"
            .Alignment = HorizontalAlignment.Center
            .Width = 50
        End With
        Dim column7 As New DataGridTextBoxColumn
        With column7
            .MappingName = "TOTCREDBAS"
            .HeaderText = "Importe"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = "######0.00"
        End With

        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "SALDOPAGBAS"
            .HeaderText = "Saldo Pagar"
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
            .Width = 75
        End With

        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "PAGCREDBAS"
            .HeaderText = "Acuenta"
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
            .Width = 75
        End With
        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "PERCEPCION"
            .HeaderText = "Percepcion"
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
            .Width = 75
        End With
        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "INTERESBAS"
            .HeaderText = "Interes Letra"
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
            .Width = 75
        End With
        Dim Column12 As New DataGridTextBoxColumn
        With Column12
            .MappingName = "ESTADO"
            .HeaderText = "Estado"
            .Width = 100
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5})
        TableStyle1.GridColumnStyles.AddRange(New DataGridBoolColumn() {Columm13})
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column7, Column8, Column9, Column10, Column11, Column12})
        DgCompCred.TableStyles.Clear()
        DgCompCred.TableStyles.Add(TableStyle1)

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If DgCompCred.Focus = True Then
                        EnviarDatos()
                    End If
            End Select
        End If
    End Function


#End Region
#Region "Variables Form"
    Private TB_COMPRASCRED As New DataTable



#End Region


    Private Sub FrmPlanillaPago_Provee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombos()
        BTNCANCELAR_Click(sender, e)
        TxtAcuenta.Enabled = False
    End Sub

    Private Sub DgCompCred_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgCompCred.DoubleClick
        If Me.DgCompCred.CurrentRowIndex > -1 Then
            EnviarDatos()
        End If
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'GrpProvee.Enabled = True
        BTNCANCELAR.Enabled = True
        'BTNNUEVO.Enabled = False
        BTNGUARDAR.Enabled = True
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        TB_COMPRASCRED.Rows.Clear()
        'BTNCANCELAR.Enabled = False
        'BTNGUARDAR.Enabled = False
        TxtNroPago.Text = TmpListarDatos("SELECT ISNULL(MAX(NROPAGO),0)+1  FROM   PAGOSCAB  WHERE CODEMPRESA='" & codempresa & "'").Rows(0)(0)

        BtnBusProvee.Enabled = False

        btnBuscaPlanilla.Enabled = False

    End Sub

    Private Sub TxtAcuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAcuenta.KeyDown
        If e.KeyCode = Keys.Enter Then

            If TxtInteresletra.Text.Trim = "" Then
                TxtInteresletra.Text = "0.00"
            End If
            If CDbl(TxtAcuenta.Text) = 0 Then
                MsgBox("EL ACUENTA NO PUEDER SER CERO..", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If
            If CDbl(TxtAcuenta.Text) > CDbl(LblSaldo.Text) Then
                MsgBox("EL ACUENTA NO PUEDER SER MAYOR AL SALDO A PAGAR..", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            CAyuda.Ejecutar("UpdateTMP_PAGOSDETxProc", codempresa, VCorrelInv, LblCodtipodoc.Text, LblNroDoc.Text, CDbl(TxtAcuenta.Text), FormatoMonto(CDbl(TxtAcuenta.Text) / VCambioCompra, DECIRESU), CDbl(TxtInteresletra.Text))
            CargarGrid()
            FormatoGrid()

            LblCodtipodoc.Text = ""
            LblTipoDoc.Text = ""
            LblNroDoc.Text = ""
            Lblprovee.Text = ""
            LblPercep.Text = "0.00"
            TxtInteresletra.Text = "0.00"
            TxtAcuenta.Text = "0.00"

        End If
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click




        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DtFechaPago.Value.Year
        MES = DtFechaPago.Value.Month

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







        If TxtNroPago.Text.Trim = "" Then
            Exit Sub
        End If
        'Dim FrmPlla As New FrmCompensarPago
        'FrmPlla.lbNumPlanilla.Text = TxtNroPago.Text
        'FrmPlla.lblMontoCompensar.Text = TxtTotalPagado.Text
        'FrmPlla.ShowDialog()
        'If FrmPlla.DEVOLVER = False Then
        '    Exit Sub
        'End If

        'For ContA As Integer = 0 To FrmPlla.TablaTemp.Rows.Count - 1
        '    CAyuda.Ejecutar("NSP_INSERT_DOC_COMP_PCOBROS", txtNumPlanilla.Text, Format(CDate(dtpFecha.Value), "dd/MM/yyyy"), txtCobrador.Text, CDbl(lblTotalCobrado.Text.Trim), FrmComp.TablaTemp.Rows(ContA)("TIPO").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim)
        'Next

        Dim FrmComp As New FrmCompensar
        FrmComp.lbNumPlanilla.Text = TxtNroPago.Text
        FrmComp.lblMontoCompensar.Text = CDbl(TxtTotalPagado.Text)
        FrmComp.ShowDialog()
        If FrmComp.DEVOLVER = False Then
            Exit Sub
        End If

        For ContA As Integer = 0 To FrmComp.TablaTemp.Rows.Count - 1
            CAyuda.Ejecutar("NSP_INSERT_DOC_COMP_PCOBROS", TxtNroPago.Text, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, "", 0, FrmComp.TablaTemp.Rows(ContA)("TIPO").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim)

            If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, 2, FrmComp.TablaTemp.Rows(ContA)("TIPOC").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, "", CodUsuario.Trim, FrmComp.TablaTemp.Rows(ContA)("CUENTAC").ToString.Trim, "", "", "", "", FrmComp.TablaTemp.Rows(ContA)("BServi").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("PTributario").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("RucADQ").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("RucProve").ToString.Trim) <> 0 Then

            End If


        Next

        CAyuda.Ejecutar("GrabarPagosProvee", codempresa, Format(CDate(DtFechaPago.Value), "dd/MM/yyyy"), TxtCodProvee.Text.Trim, CDMONBASE, VCambioCompra, CDbl(TxtTotalPagado.Text), FormatoMonto(CDbl(TxtTotalPagado.Text) / VCambioCompra, DECIRESU), CodUsuario, CodUsuario, "", VCorrelInv)
        MsgBox("SE GUARDO EL PAGO CORRECTAMENTE..", MsgBoxStyle.Information, "")

        BTNCANCELAR_Click(sender, e)


    End Sub

    Private Sub BtnBusProvee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusProvee.Click
        Dim Frmbusc As New FrmBuscarProveedor
        Frmbusc.ShowDialog()
        If Frmbusc.DEVOLVER = False Then
            Exit Sub
        End If
        TxtCodProvee.Text = Frmbusc.DgProveedor.Item(Frmbusc.DgProveedor.CurrentRowIndex, 0)
        LblDesProvee.Text = Frmbusc.DgProveedor.Item(Frmbusc.DgProveedor.CurrentRowIndex, 1)
        LblRuc.Text = Frmbusc.DgProveedor.Item(Frmbusc.DgProveedor.CurrentRowIndex, 2)
        CargarCuentaProvee()

    End Sub

    Private Sub TxtCodProvee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodProvee.TextChanged

    End Sub

    Private Sub TxtCodProvee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodProvee.KeyDown
        If e.KeyCode = Keys.Enter Then
            CargarCuentaProvee()


        End If
    End Sub

    Private Sub TxtInteresletra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtInteresletra.TextChanged

    End Sub

    Private Sub TxtInteresletra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtInteresletra.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtAcuenta.Focus()

        End If
    End Sub


    Private Sub DgCompCred_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgCompCred.MouseEnter

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim frmr As New frmRptPlanOrdenD
        frmr.tipo = 5
        frmr.ShowDialog()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TxtNroPago.Text.Trim = "" Then
            Exit Sub
        End If
   

        Dim Proceso As String
        Proceso = "ANULPAGOPROVEE"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If


        If TmpInsertDatos("PLANILLA_PAGOCANULAR  '" & codempresa & "','" & txtNumPlanilla.Text.Trim & "'") = True Then
            'TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT  '" & codempresa & "','" & 1 & "','" & CORREL & "','" & cbAlmacen.SelectedValue.ToString.Trim & "'  ")
            MsgBox("EL DOCUMENTO  HA SIDO ANULADO CORRECTAMENTE..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

        Else
            MsgBox("ERROR EN LA ANULACION ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        End If


        If TmpInsertDatos("SP_UPDATE_PROVECANC  '" & codempresa & "','" & VCorrelInv & "'") = True Then
            'TmpInsertDatos("NSP_ACTUALIZAR_ARTIDAT  '" & codempresa & "','" & 1 & "','" & CORREL & "','" & cbAlmacen.SelectedValue.ToString.Trim & "'  ")
        End If





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        'If TAB_DETALLE.Rows.Count > 0 Then
        '    If MsgBox("TIENE UNA OPERACION PENDIENTE .DESEA CANCELAR LA OPERACION DE TODAS MANERAS...", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        'End If
        'TmpInsertDatos("DELETE  FROM TMP_PLANILLA_VTAXCOBRAR    WHERE CODEMPRESA='" & codempresa & "'  AND CORRNBR='" & VCorrelVta & "'")
        'CargarGridDet()
        'FormatoGridDet()
        'LimpiarDatos()



        btnBuscaPlanilla.Enabled = True
        txtNumPlanilla.Enabled = True

        TxtAcuenta.Enabled = False

    End Sub

    Private Sub TxtAcuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAcuenta.KeyPress

    End Sub

    Private Sub TxtAcuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAcuenta.TextChanged

    End Sub

    Private Sub DgCompCred_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgCompCred.Navigate

    End Sub

    Private Sub btnBuscaPlanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscaPlanilla.Click

        Dim FrmBusc As New FrmBuscPlanillaPago
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        If CStr(FrmBusc.DgPlanilla.Item(FrmBusc.DgPlanilla.CurrentRowIndex, 5)) = "A" Then
            MsgBox("LA PLANILLA ESTA ANULADA..!", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        txtNumPlanilla.Text = FrmBusc.DgPlanilla.Item(FrmBusc.DgPlanilla.CurrentRowIndex, 0)

        BuscarPagoC()
        BuscarPagoD()



    End Sub

    Private Sub BuscarPagoD()
        TmpInsertDatos("SP_InsTMP_PAGOSDETxProc_2  '" & codempresa & "','" & txtNumPlanilla.Text & "','" & VCorrelInv & "'")
        CargarGrid()
        FormatoGrid()

    End Sub



    Private Sub BuscarPagoC()

        Dim TAB_COBRANZAC As New DataTable
        TAB_COBRANZAC = TmpListarDatos("PLANILLA_PAGOCselecxProc  '" & codempresa & "','" & txtNumPlanilla.Text.Trim & "'")
        TxtCodProvee.Text = TAB_COBRANZAC.Rows(0)("CODPROVEEDOR")
        LblDesProvee.Text = TAB_COBRANZAC.Rows(0)("DESPROVEEDOR").ToString
        DtFechaPago.Value = Format(CDate(TAB_COBRANZAC.Rows(0)("FECHAPAGO")), "dd/MM/yyyy")

        LblRuc.Text = TAB_COBRANZAC.Rows(0)("RUC").ToString
        LblTotalDeuda.Text = TAB_COBRANZAC.Rows(0)("TOTALBAS").ToString


    End Sub


    Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click


        TxtNroPago.Text = TmpListarDatos("SELECT ISNULL(MAX(NROPAGO),0)+1  FROM   PAGOSCAB  WHERE CODEMPRESA='" & codempresa & "'").Rows(0)(0)
        TB_COMPRASCRED.Rows.Clear()

        btnBuscaPlanilla.Enabled = False
        txtNumPlanilla.Enabled = False

        BtnBusProvee.Enabled = True

        'cbTipoDoc.Enabled = True : txtNroDoc.Enabled = True : TxtAcuenta.Enabled = True
        'Me.btnCompensar.Enabled = True ': Me.btnGuardar.Enabled = True
        'Me.txtCobrador.Text = String.Empty : Me.txtDeuda.Text = String.Empty : Me.txtDsCliente.Text = String.Empty
        'TxtAcuenta.Text = String.Empty : txtSaldo.Text = String.Empty : lbCobrador.Text = String.Empty
        'TraerPlanilla()
        'Me.txtCobrador.Focus()
        'BTNCANCELAR_Click(sender, e)
        'LblTitulo.Visible = True
        'GrpCabecera.Enabled = True

        'Call botones(False, True, False, True, True)
        'HABILTAR(True)
        TxtAcuenta.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "RptPagoProveeTodo.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, TxtCodProvee.Text)
                .set_StoredProcParam(1, codempresa)

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class
