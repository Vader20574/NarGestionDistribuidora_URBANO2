Public Class FrmNuevaNotaCredito
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
    Friend WithEvents CboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BtnBusTipoDoc As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents BtnBusDoc As System.Windows.Forms.Button
    Friend WithEvents TxtDoc1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDoc2 As System.Windows.Forms.TextBox
    Friend WithEvents LblNroProc As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblRUC As System.Windows.Forms.Label
    Friend WithEvents LblRazonSocial As System.Windows.Forms.Label
    Friend WithEvents LblMontoDoc As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnBusCli As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents TxtObserv As System.Windows.Forms.TextBox
    Friend WithEvents TxtNotaCred2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNotaCred1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblcodvend As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblSaldo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevaNotaCredito))
        Me.TxtNotaCred2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboTipoDoc = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnBusTipoDoc = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtImporte = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblSaldo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtObserv = New System.Windows.Forms.TextBox
        Me.TxtCodCliente = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblRUC = New System.Windows.Forms.Label
        Me.LblRazonSocial = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.LblDireccion = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblMontoDoc = New System.Windows.Forms.Label
        Me.BtnBusDoc = New System.Windows.Forms.Button
        Me.TxtDoc1 = New System.Windows.Forms.TextBox
        Me.TxtDoc2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.BtnBusCli = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TxtNotaCred1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.LblNroProc = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblcodvend = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNotaCred2
        '
        Me.TxtNotaCred2.Location = New System.Drawing.Point(540, 24)
        Me.TxtNotaCred2.Name = "TxtNotaCred2"
        Me.TxtNotaCred2.Size = New System.Drawing.Size(76, 20)
        Me.TxtNotaCred2.TabIndex = 5
        Me.TxtNotaCred2.Text = "0000000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(496, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota Credito"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboTipoDoc
        '
        Me.CboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDoc.Location = New System.Drawing.Point(86, 6)
        Me.CboTipoDoc.Name = "CboTipoDoc"
        Me.CboTipoDoc.Size = New System.Drawing.Size(206, 21)
        Me.CboTipoDoc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TipoDoc: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'BtnBusTipoDoc
        '
        Me.BtnBusTipoDoc.ImageIndex = 5
        Me.BtnBusTipoDoc.ImageList = Me.ImageList1
        Me.BtnBusTipoDoc.Location = New System.Drawing.Point(296, 4)
        Me.BtnBusTipoDoc.Name = "BtnBusTipoDoc"
        Me.BtnBusTipoDoc.Size = New System.Drawing.Size(30, 24)
        Me.BtnBusTipoDoc.TabIndex = 2
        Me.BtnBusTipoDoc.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Importe: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(56, 34)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(74, 20)
        Me.TxtImporte.TabIndex = 4
        Me.TxtImporte.Text = "0.00"
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Saldo: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblSaldo
        '
        Me.LblSaldo.BackColor = System.Drawing.Color.White
        Me.LblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSaldo.Location = New System.Drawing.Point(56, 6)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(76, 23)
        Me.LblSaldo.TabIndex = 1
        Me.LblSaldo.Text = "0.00"
        Me.LblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Motivo:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtObserv
        '
        Me.TxtObserv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObserv.Location = New System.Drawing.Point(192, 8)
        Me.TxtObserv.MaxLength = 100
        Me.TxtObserv.Multiline = True
        Me.TxtObserv.Name = "TxtObserv"
        Me.TxtObserv.Size = New System.Drawing.Size(290, 48)
        Me.TxtObserv.TabIndex = 5
        '
        'TxtCodCliente
        '
        Me.TxtCodCliente.Location = New System.Drawing.Point(86, 28)
        Me.TxtCodCliente.Name = "TxtCodCliente"
        Me.TxtCodCliente.Size = New System.Drawing.Size(84, 20)
        Me.TxtCodCliente.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ruc: "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRUC
        '
        Me.lblRUC.BackColor = System.Drawing.Color.White
        Me.lblRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRUC.Location = New System.Drawing.Point(242, 28)
        Me.lblRUC.Name = "lblRUC"
        Me.lblRUC.Size = New System.Drawing.Size(86, 23)
        Me.lblRUC.TabIndex = 12
        Me.lblRUC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblRazonSocial
        '
        Me.LblRazonSocial.BackColor = System.Drawing.Color.White
        Me.LblRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRazonSocial.Location = New System.Drawing.Point(88, 52)
        Me.LblRazonSocial.Name = "LblRazonSocial"
        Me.LblRazonSocial.Size = New System.Drawing.Size(330, 23)
        Me.LblRazonSocial.TabIndex = 14
        Me.LblRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtImporte)
        Me.Panel1.Controls.Add(Me.TxtObserv)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LblSaldo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(204, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(492, 68)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.LblDireccion)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.LblMontoDoc)
        Me.Panel2.Controls.Add(Me.BtnBusDoc)
        Me.Panel2.Controls.Add(Me.TxtDoc1)
        Me.Panel2.Controls.Add(Me.TxtDoc2)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.BtnBusCli)
        Me.Panel2.Controls.Add(Me.LblRazonSocial)
        Me.Panel2.Controls.Add(Me.lblRUC)
        Me.Panel2.Controls.Add(Me.TxtCodCliente)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.CboTipoDoc)
        Me.Panel2.Controls.Add(Me.BtnBusTipoDoc)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(114, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(582, 114)
        Me.Panel2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(466, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDireccion
        '
        Me.LblDireccion.BackColor = System.Drawing.Color.White
        Me.LblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDireccion.Location = New System.Drawing.Point(88, 80)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(330, 23)
        Me.LblDireccion.TabIndex = 16
        Me.LblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Direccion :"
        '
        'LblMontoDoc
        '
        Me.LblMontoDoc.BackColor = System.Drawing.Color.White
        Me.LblMontoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoDoc.Location = New System.Drawing.Point(472, 82)
        Me.LblMontoDoc.Name = "LblMontoDoc"
        Me.LblMontoDoc.Size = New System.Drawing.Size(80, 23)
        Me.LblMontoDoc.TabIndex = 18
        Me.LblMontoDoc.Text = "0.00"
        Me.LblMontoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnBusDoc
        '
        Me.BtnBusDoc.ImageIndex = 5
        Me.BtnBusDoc.ImageList = Me.ImageList1
        Me.BtnBusDoc.Location = New System.Drawing.Point(536, 4)
        Me.BtnBusDoc.Name = "BtnBusDoc"
        Me.BtnBusDoc.Size = New System.Drawing.Size(30, 24)
        Me.BtnBusDoc.TabIndex = 7
        '
        'TxtDoc1
        '
        Me.TxtDoc1.Location = New System.Drawing.Point(400, 6)
        Me.TxtDoc1.Name = "TxtDoc1"
        Me.TxtDoc1.Size = New System.Drawing.Size(36, 20)
        Me.TxtDoc1.TabIndex = 4
        Me.TxtDoc1.Text = "000"
        Me.TxtDoc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDoc2
        '
        Me.TxtDoc2.Location = New System.Drawing.Point(456, 6)
        Me.TxtDoc2.Name = "TxtDoc2"
        Me.TxtDoc2.Size = New System.Drawing.Size(76, 20)
        Me.TxtDoc2.TabIndex = 6
        Me.TxtDoc2.Text = "0000000"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(438, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 29)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "-"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBusCli
        '
        Me.BtnBusCli.ImageIndex = 5
        Me.BtnBusCli.ImageList = Me.ImageList1
        Me.BtnBusCli.Location = New System.Drawing.Point(174, 28)
        Me.BtnBusCli.Name = "BtnBusCli"
        Me.BtnBusCli.Size = New System.Drawing.Size(30, 24)
        Me.BtnBusCli.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(352, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "N° Doc :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Apell. o R.S. :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Cod. Cliente :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(430, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Monto: "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'TxtNotaCred1
        '
        Me.TxtNotaCred1.Location = New System.Drawing.Point(484, 24)
        Me.TxtNotaCred1.Name = "TxtNotaCred1"
        Me.TxtNotaCred1.Size = New System.Drawing.Size(36, 20)
        Me.TxtNotaCred1.TabIndex = 3
        Me.TxtNotaCred1.Text = "000"
        Me.TxtNotaCred1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(522, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 29)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "-"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnGuardar
        '
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.ImageIndex = 1
        Me.BtnGuardar.ImageList = Me.ImageList1
        Me.BtnGuardar.Location = New System.Drawing.Point(14, 56)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(90, 30)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "&Guardar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(14, 104)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.ImageIndex = 0
        Me.BtnNuevo.ImageList = Me.ImageList1
        Me.BtnNuevo.Location = New System.Drawing.Point(14, 12)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(90, 30)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo"
        '
        'Button5
        '
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.ImageIndex = 13
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(14, 148)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 30)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "&Salir"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.BtnNuevo)
        Me.Panel3.Controls.Add(Me.BtnGuardar)
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Location = New System.Drawing.Point(704, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(116, 190)
        Me.Panel3.TabIndex = 9
        '
        'LblNroProc
        '
        Me.LblNroProc.BackColor = System.Drawing.Color.AliceBlue
        Me.LblNroProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroProc.Location = New System.Drawing.Point(186, 24)
        Me.LblNroProc.Name = "LblNroProc"
        Me.LblNroProc.Size = New System.Drawing.Size(80, 23)
        Me.LblNroProc.TabIndex = 2
        Me.LblNroProc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nro Orden :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 60)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Usted podra crear una nota de credito para que sea aprobado  por otro usuario de " & _
            "mas nivel en el Proceso"
        '
        'lblcodvend
        '
        Me.lblcodvend.BackColor = System.Drawing.Color.White
        Me.lblcodvend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodvend.Location = New System.Drawing.Point(651, 1)
        Me.lblcodvend.Name = "lblcodvend"
        Me.lblcodvend.Size = New System.Drawing.Size(86, 23)
        Me.lblcodvend.TabIndex = 49
        Me.lblcodvend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha
        '
        Me.dtpfecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(651, 26)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(104, 21)
        Me.dtpfecha.TabIndex = 50
        '
        'FrmNuevaNotaCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(828, 250)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.lblcodvend)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblNroProc)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TxtNotaCred1)
        Me.Controls.Add(Me.TxtNotaCred2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmNuevaNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crea  Nueva NotaCredito"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "FIELDS"
    Public AObjBus As New ClsAyuda
    Private ADblCORRELATIVO As Double
    Private CODDEPENDIENTE As String = ""

#End Region

#Region "FUNCIONES"

    Public Function BUSCAR_DOCUMENTO(ByVal NRODOCUMENTO As String, ByVal CDTIPODOC As String) As DataTable
        Dim TABLE_DOC As New DataTable
        If TmpListarDatos("SELECT  *  FROM VENTACAB   WHERE  NRODOCU='" & NRODOCUMENTO.Trim & "' AND CODTIPODOC='" & CDTIPODOC.Trim & "' AND CODEMPRESA='" & codempresa & "' ").Rows.Count > 0 Then
            TABLE_DOC = TmpListarDatos("SELECT  *  FROM VENTACAB   WHERE  NRODOCU='" & NRODOCUMENTO.Trim & "' AND CODTIPODOC='" & CDTIPODOC.Trim & "' AND CODEMPRESA='" & codempresa & "'")
            Return TABLE_DOC
            Exit Function
        Else
            Dim dtHistorico As New DataTable
            dtHistorico = TmpListarDatos("SELECT   VENTCAB  FROM  HISTOVENTAS  WHERE  CODEMPRESA='" & codempresa & "' ")
            If dtHistorico.Rows.Count > 0 Then
                For i As Integer = 0 To dtHistorico.Rows.Count - 1
                    If TmpListarDatos("SELECT  *  FROM " & dtHistorico.Rows(i)("VENTCAB").ToString.Trim & "  WHERE  NRODOCU='" & NRODOCUMENTO.Trim & "' AND CODTIPODOC='" & CDTIPODOC.Trim & "'AND CODEMPRESA='" & codempresa & "'").Rows.Count > 0 Then
                        TABLE_DOC = TmpListarDatos("SELECT  *  FROM " & dtHistorico.Rows(i)("VENTCAB").ToString.Trim & "  WHERE  NRODOCU='" & NRODOCUMENTO.Trim & "' AND CODTIPODOC='" & CDTIPODOC.Trim & "' AND CODEMPRESA='" & codempresa & "' ")
                        Return TABLE_DOC
                        Exit Function
                    End If
                Next
            End If
        End If
        TABLE_DOC = TmpListarDatos("SELECT  *  FROM VENTACAB   WHERE  NRODOCU='" & NRODOCUMENTO.Trim & "' AND CODTIPODOC='" & CDTIPODOC.Trim & "' AND CODEMPRESA='" & codempresa & "'")
        Return TABLE_DOC

    End Function






    Private Sub Limpiar()
        Dim ctrl As Control
        For Each ctrl In Me.Controls
            If TypeOf ctrl Is Panel Then
                Dim a As Object
                For Each a In ctrl.Controls
                    If TypeOf a Is TextBox Then
                        a.Text = ""
                    ElseIf TypeOf a Is Label Then
                        If a.BorderStyle = BorderStyle.FixedSingle Then
                            a.Text = ""
                        End If
                    End If
                Next
            ElseIf TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
        Next
        TxtNotaCred1.Text = "000"
        TxtNotaCred2.Text = "0000000"
        TxtDoc1.Text = "000"
        TxtDoc2.Text = "0000000"
        LblMontoDoc.Text = "0.00"
        LblSaldo.Text = "0.00"
        TxtImporte.Text = "0.00"
    End Sub
    Private Sub Cancelar()
        Panel2.Enabled = False
        Panel1.Enabled = False
        Limpiar()
    End Sub

    Private Sub Nuevo()
        ADblCORRELATIVO = AObjBus.ListarDatos("NSP_CREAR_NRO_PREPLANTACRED", codempresa).Tables(0).Rows(0)("NROORDEN")
        LblNroProc.Text = ADblCORRELATIVO
        Panel2.Enabled = True
        Panel1.Enabled = True
        Limpiar()
    End Sub

    Sub CargarCombos()
        ' ''Conecta("SELECT T.[CODTIPODOC], T.[DSTIPODOC] FROM TIPODOC T WHERE T.[CODEMPRESA]='" & codempresa & "'", "d")
        ' ''Dim TablaTemp As New DataTable
        ' ''TablaTemp = ds.Tables("d")


        '' ''CboTipoDoc.DataSource = TmpListarDatos("NSP_SELE_TIPODOC_NTACRED  '" & codempresa & "' ")
        '' ''CboTipoDoc.ValueMember = "Codigo"
        '' ''CboTipoDoc.DisplayMember = "Descripcion"

        ' ''Me.CboTipoDoc.DisplayMember = "DSTIPODOC"
        ' ''Me.CboTipoDoc.ValueMember = "CODTIPODOC"
        ' ''Me.CboTipoDoc.DataSource = TablaTemp


        CAyuda.CargarDataCombo(CboTipoDoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")



    End Sub
#End Region

#Region "RESTRICCIONES-KEYPRESS"

    Private Sub CajaTexto_SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDoc1.KeyPress, TxtDoc2.KeyPress, TxtNotaCred1.KeyPress, TxtNotaCred2.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
#End Region





    Private Sub FrmNuevaNotaCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombos()
        Cancelar()

    End Sub

    Private Sub BtnBusTipoDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusTipoDoc.Click
        Dim frmBuscar As New FrmBuscarTipoDoc2
        frmBuscar.ShowDialog()
        If frmBuscar.DEVOLVER = False Then
            Exit Sub
        End If
        CboTipoDoc.SelectedValue = frmBuscar.DataGridTipoDoc.Item(frmBuscar.DataGridTipoDoc.CurrentRowIndex, 0)
    End Sub


    Private Sub BtnBusDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusDoc.Click
        Dim num, ini As String
        Dim fin As String

        Dim FrmBus As New FrmBuscarDocVentas
        FrmBus.DATACODTIPODOC = CboTipoDoc.SelectedValue.ToString.Trim
        FrmBus.ShowDialog()
        If FrmBus.DEVOLVER = False Then
            Exit Sub
        End If
        num = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 2).ToString.Trim

        'num = "123456789"
        ini = "00000" & Mid(num, 1, num.Length - 7).Trim
        fin = "00000" & Mid(num, num.Length - 6, num.Length).Trim
        TxtDoc1.Text = Mid(ini, ini.Length - 2, ini.Length).Trim
        TxtDoc2.Text = Mid(fin, fin.Length - 6, fin.Length).Trim

        Dim TABLEBUSCDOC As New DataTable
        TABLEBUSCDOC = BUSCAR_DOCUMENTO(CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim), CboTipoDoc.SelectedValue)
        If TABLEBUSCDOC.Rows.Count > 0 Then
            TxtCodCliente.Text = TABLEBUSCDOC.Rows(0)("CODCLIENTE").ToString.Trim
            lblRUC.Text = TABLEBUSCDOC.Rows(0)("RUCCLIENTE").ToString.Trim
            LblRazonSocial.Text = TABLEBUSCDOC.Rows(0)("DESCLIENTE").ToString.Trim

            Label5.Text = TABLEBUSCDOC.Rows(0)("CODTIPOPAGO").ToString.Trim
            LblDireccion.Text = TABLEBUSCDOC.Rows(0)("DIRCLIENTE").ToString.Trim
            LblMontoDoc.Text = Format(CDbl(TABLEBUSCDOC.Rows(0)("TOTBAS").ToString.Trim), "#######0.00")
            CODDEPENDIENTE = TABLEBUSCDOC.Rows(0)("CODDEP").ToString.Trim
            lblcodvend.Text = TABLEBUSCDOC.Rows(0)("CODVEND").ToString.Trim
            dtpfecha.Value = CDate(TABLEBUSCDOC.Rows(0)("FECDOCUM").ToString.Trim)



            Dim MONTOSALD As Double = 0
            MONTOSALD = Format(CDbl(TmpListarDatos("NSP_VERIF_DOCUM_NTACREDSERV  '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ").Rows(0)(0).ToString.Trim), "#######0.00")

            Dim TB_TMP_NTACREDCABSER As DataTable

            TB_TMP_NTACREDCABSER = TmpListarDatos("SP_BUSCAR_TMP_NTACREDCABSER '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ")
            If TB_TMP_NTACREDCABSER.Rows.Count > 0 Then
                MsgBox("El Documento esta en estado de PROCESO dale SI o NO en el formulario PrePlanilla de aprobación")
                TxtImporte.Enabled = False
            Else
                TxtImporte.Enabled = True
            End If

            LblSaldo.Text = Format(CDbl(LblMontoDoc.Text) - MONTOSALD, "#######0.00")
            TxtImporte.Focus()

        Else
            MsgBox("NO EXISTE EL NUMERO DE DOCUMENTO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub


    Private Sub BtnBusCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusCli.Click
        Dim frm As New FrmBusquedaDeCliente
        frm.ShowDialog()
        If frm.DEVOLVER = False Then
            Exit Sub
        End If

        Dim FrmBus As New FrmBuscarDocVentas

        FrmBus.DATACODCLIENTE = frm.Grid1.Item(frm.Grid1.CurrentRowIndex, 0).ToString.Trim
        FrmBus.ShowDialog()
        If FrmBus.DEVOLVER = False Then
            Exit Sub
        End If
        CboTipoDoc.SelectedValue = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 0)
        Dim NumeroDoc As String
        NumeroDoc = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 2).ToString.Trim

        TxtDoc1.Text = Mid(CStr("000" + NumeroDoc), CStr("000" + NumeroDoc).Length - 9, 3)
        TxtDoc2.Text = Mid(NumeroDoc, NumeroDoc.Length - 6, NumeroDoc.Length)


        Dim TABLEBUSCDOC As New DataTable
        TABLEBUSCDOC = BUSCAR_DOCUMENTO(CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim), CboTipoDoc.SelectedValue)
        If TABLEBUSCDOC.Rows.Count > 0 Then
            TxtCodCliente.Text = TABLEBUSCDOC.Rows(0)("CODCLIENTE").ToString.Trim
            lblRUC.Text = TABLEBUSCDOC.Rows(0)("RUCCLIENTE").ToString.Trim
            LblRazonSocial.Text = TABLEBUSCDOC.Rows(0)("DESCLIENTE").ToString.Trim
            LblDireccion.Text = TABLEBUSCDOC.Rows(0)("DIRCLIENTE").ToString.Trim
            LblMontoDoc.Text = Format(CDbl(TABLEBUSCDOC.Rows(0)("TOTBAS").ToString.Trim), "#######0.00")
            CODDEPENDIENTE = TABLEBUSCDOC.Rows(0)("CODDEP").ToString.Trim

            Dim MONTOSALD As Double = 0
            MONTOSALD = Format(CDbl(TmpListarDatos("NSP_VERIF_DOCUM_NTACREDSERV  '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ").Rows(0)(0).ToString.Trim), "#######0.00")

            Dim TB_TMP_NTACREDCABSER As DataTable
            TB_TMP_NTACREDCABSER = TmpListarDatos("SP_BUSCAR_TMP_NTACREDCABSER '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ")
            If TB_TMP_NTACREDCABSER.Rows.Count > 0 Then
                MsgBox("El Documento esta en estado de PROCESO dale SI o NO en el formulario PrePlanilla de aprobación")
                TxtImporte.Enabled = False
            Else
                TxtImporte.Enabled = True
            End If


            LblSaldo.Text = Format(CDbl(LblMontoDoc.Text) - MONTOSALD, "#######0.00")
            TxtImporte.Focus()

        Else
            MsgBox("NO EXISTE EL NUMERO DE DOCUMENTO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        End If



    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Nuevo()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click







        If CDbl(LblSaldo.Text) = 0 Then
            MsgBox("NO SE PUEDE GUARDAR LA NOTA DE CREDITO DEL DOCUMENTO  PORQUE EL SALDO ES CERO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If
        If TxtCodCliente.Text.Trim.Length = 0 Then
            MsgBox("SELECCIONE UN CLIENTE.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        If CInt(TxtNotaCred1.Text) = 0 Or CInt(TxtNotaCred2.Text) = 0 Then
            MsgBox("NRO DE NOTA DE CREDITO NO VALIDO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If
        If TmpListarDatos("NSP_VERIF_NTACREDSERV  '" & codempresa & "','" & CInt(TxtNotaCred1.Text.Trim & TxtNotaCred2.Text.Trim) & "'").Rows.Count > 0 Then
            MsgBox("YA EXISTE EL NUMERO DE NOTA DE CREDITO..." + (TxtNotaCred1.Text.Trim & TxtNotaCred2.Text.Trim), MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If

        If CDbl(LblSaldo.Text) < CDbl(TxtImporte.Text) Then
            MsgBox("EL IMPORTE NO PUEDE SER MAYOR  AL SALDO DEL DOCUMENTO..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If
        If MULT_NTACRED_X_NROREF = False Then
            If TmpListarDatos("NSP_VERIF_NROREFER_NTACREDSER  '" & codempresa & "','" & CboTipoDoc.SelectedValue.ToString() & "' ,'" & CStr(CStr(CInt(TxtDoc1.Text)) & TxtDoc2.Text) & "' ").Rows.Count > 0 Then
                MsgBox("EL DOCUMENTO DE REFERENCIA  YA TIENE UNA NOTA DE CREDITO..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If
        End If


        Dim AIntResp As Integer
        Dim Totbas, TotExt, SubTotBas, SubTotExt, IgvBas, IgvExt As String

        Totbas = Format(CDbl(TxtImporte.Text), "#######0.00")
        TotExt = Format(CDbl(CDbl(Totbas) / VCambioVta), "#######0.00")
        SubTotBas = Format(CDbl(CDbl(Totbas) / 1.19), "#######0.00")
        SubTotExt = Format(CDbl(CDbl(SubTotBas) / VCambioVta), "#######0.00")
        IgvBas = Format(CDbl(CDbl(SubTotBas) * 0.19), "#######0.00")
        IgvExt = Format(CDbl(CDbl(IgvBas) / VCambioVta), "#######0.00")

        AIntResp = AObjBus.Ejecutar("NSP_ins_TMP_NTACREDCABSER", CStr(CInt(TxtNotaCred1.Text) _
        & TxtNotaCred2.Text.Trim), CboTipoDoc.SelectedValue.ToString(), _
        CStr(CStr(CInt(TxtDoc1.Text)) & TxtDoc2.Text), "S", 2.98, CodUsuario.Trim, _
        Date.Now, GMascaraDec_D(CDbl(Totbas)), GMascaraDec_D(CDbl(TotExt)), _
        GMascaraDec_D(CDbl(SubTotBas)), GMascaraDec_D(CDbl(SubTotExt)), _
        GMascaraDec_D(CDbl(IgvBas)), GMascaraDec_D(CDbl(IgvExt)), _
        TxtCodCliente.Text, lblRUC.Text, LblRazonSocial.Text, LblDireccion.Text, _
        CodUsuario.ToString, NROPTOVTA.Trim, codempresa, TxtObserv.Text, _
        "C", CODDEPENDIENTE, ADblCORRELATIVO, 0, Label5.Text, lblcodvend.Text, Format(CDate(dtpfecha.Value), "dd/MM/yyyy"))

        MsgBox("SE GUARDO  LA ORDEN DE NOTA DE CREDITO.." & vbNewLine & "ORDEN NRO " & ADblCORRELATIVO, MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        Cancelar()
    End Sub
    Private Sub TxtDoc1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc1.TextChanged

    End Sub

    Private Sub TxtNotaCred1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNotaCred1.TextChanged

    End Sub

    Private Sub TxtNotaCred1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNotaCred1.KeyDown, TxtDoc1.KeyDown
        Dim Cadena As String
        If e.KeyCode = Keys.Enter Then
            Cadena = "000000" & CType(sender, Object).text
            CType(sender, Object).text = Mid(Cadena, Cadena.Length - 2, Cadena.Length)
            If CType(sender, Object).name = "TxtNotaCred1" Then
                TxtNotaCred2.Focus()
            ElseIf CType(sender, Object).name = "TxtDoc1" Then
                TxtDoc2.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNotaCred1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNotaCred1.Click, TxtDoc1.Click, TxtDoc2.Click, TxtNotaCred2.Click
        CType(sender, Object).select(0, CType(sender, Object).GetType.ToString.Length)
    End Sub

    Private Sub TxtNotaCred2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNotaCred2.TextChanged

    End Sub

    Private Sub TxtNotaCred2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNotaCred2.KeyDown, TxtDoc2.KeyDown
        Dim Cadena As String
        If e.KeyCode = Keys.Enter Then
            Cadena = "000000" & CType(sender, Object).text
            CType(sender, Object).text = Mid(Cadena, Cadena.Length - 6, Cadena.Length)
            If CType(sender, Object).name = "TxtDoc2" Then
                Dim TABLEBUSCDOC As New DataTable
                TABLEBUSCDOC = BUSCAR_DOCUMENTO(CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim), CboTipoDoc.SelectedValue)
                If TABLEBUSCDOC.Rows.Count > 0 Then
                    TxtCodCliente.Text = TABLEBUSCDOC.Rows(0)("CODCLIENTE").ToString.Trim
                    lblRUC.Text = TABLEBUSCDOC.Rows(0)("RUCCLIENTE").ToString.Trim
                    LblRazonSocial.Text = TABLEBUSCDOC.Rows(0)("DESCLIENTE").ToString.Trim
                    LblDireccion.Text = TABLEBUSCDOC.Rows(0)("DIRCLIENTE").ToString.Trim
                    Label5.Text = TABLEBUSCDOC.Rows(0)("CODTIPOPAGO").ToString.Trim
                    LblMontoDoc.Text = Format(CDbl(TABLEBUSCDOC.Rows(0)("TOTBAS").ToString.Trim), "#######0.00")
                    CODDEPENDIENTE = TABLEBUSCDOC.Rows(0)("CODDEP").ToString.Trim
                    Dim MONTOSALD As Double = 0
                    MONTOSALD = Format(CDbl(TmpListarDatos("NSP_VERIF_DOCUM_NTACREDSERV  '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ").Rows(0)(0).ToString.Trim), "#######0.00")

                    '     MONTOSALD = Format(CDbl(TmpListarDatos("SP_BuscarDocPendienteDeCliente  '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ").Rows(0)(0).ToString.Trim), "#######0.00")


                    Dim TB_BUSQVENTA_X_COBRA As DataTable

                    TB_BUSQVENTA_X_COBRA = TmpListarDatos("SP_BUSCAR_VENTA_X_COBRAR '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ")
                    If TB_BUSQVENTA_X_COBRA.Rows.Count = 0 Then
                        LblSaldo.Text = 0
                        TxtImporte.Enabled = False
                        MsgBox("El Documento ya sido cancelado")
                        Exit Sub
                    End If


                    Dim TB_TMP_NTACREDCABSER As DataTable

                    TB_TMP_NTACREDCABSER = TmpListarDatos("SP_BUSCAR_TMP_NTACREDCABSER '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ")
                    If TB_TMP_NTACREDCABSER.Rows.Count > 0 Then
                        MsgBox("El Documento esta en estado de PROCESO dale SI o NO en el formulario PrePlanilla de aprobación")
                        TxtImporte.Enabled = False
                    Else
                        TxtImporte.Enabled = True
                    End If


                    LblSaldo.Text = Format(CDbl(LblMontoDoc.Text) - MONTOSALD, "#######0.00")
                    TxtImporte.Focus()




                Else
                    MsgBox("NO EXISTE EL NUMERO DE DOCUMENTO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                End If
            ElseIf CType(sender, Object).name = "TxtNotaCred2" Then
                CboTipoDoc.Focus()
            End If

        End If
    End Sub


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Cancelar()

    End Sub

    Private Sub TxtDoc2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDoc2.TextChanged

    End Sub

    Private Sub CboTipoDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipoDoc.SelectedIndexChanged

    End Sub

    Private Sub CboTipoDoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CboTipoDoc.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDoc1.Focus()
        End If
    End Sub

    Private Sub TxtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtImporte.KeyPress

        If Char.IsControl(CType(e.KeyChar, Char)) Then
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

    Private Sub TxtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtImporte.TextChanged

    End Sub

    Private Sub TxtImporte_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtImporte.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtImporte.Text = Format(CDbl(TxtImporte.Text), "#######0.00")
            TxtObserv.Focus()
        End If
    End Sub

    Private Sub TxtCodCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodCliente.TextChanged

    End Sub

    Private Sub TxtCodCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim FrmBus As New FrmBuscarDocVentas
            FrmBus.DATACODCLIENTE = TxtCodCliente.Text.Trim
            FrmBus.ShowDialog()
            If FrmBus.DEVOLVER = False Then
                Exit Sub
            End If

            CboTipoDoc.SelectedValue = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 0)
            Dim NumeroDoc As String
            NumeroDoc = FrmBus.DtgDoc.Item(FrmBus.DtgDoc.CurrentRowIndex, 2).ToString.Trim

            TxtDoc1.Text = Mid(CStr("000" + NumeroDoc), CStr("000" + NumeroDoc).Length - 9, 3)
            TxtDoc2.Text = Mid(NumeroDoc, NumeroDoc.Length - 6, NumeroDoc.Length)


            Dim TABLEBUSCDOC As New DataTable
            TABLEBUSCDOC = BUSCAR_DOCUMENTO(CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim), CboTipoDoc.SelectedValue)
            If TABLEBUSCDOC.Rows.Count > 0 Then
                TxtCodCliente.Text = TABLEBUSCDOC.Rows(0)("CODCLIENTE").ToString.Trim
                lblRUC.Text = TABLEBUSCDOC.Rows(0)("RUCCLIENTE").ToString.Trim
                LblRazonSocial.Text = TABLEBUSCDOC.Rows(0)("DESCLIENTE").ToString.Trim
                LblDireccion.Text = TABLEBUSCDOC.Rows(0)("DIRCLIENTE").ToString.Trim
                LblMontoDoc.Text = Format(CDbl(TABLEBUSCDOC.Rows(0)("TOTBAS").ToString.Trim), "#######0.00")
                CODDEPENDIENTE = TABLEBUSCDOC.Rows(0)("CODDEP").ToString.Trim

                Dim MONTOSALD As Double = 0
                MONTOSALD = Format(CDbl(TmpListarDatos("NSP_VERIF_DOCUM_NTACREDSERV  '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ").Rows(0)(0).ToString.Trim), "#######0.00")

                Dim TB_TMP_NTACREDCABSER As DataTable

                TB_TMP_NTACREDCABSER = TmpListarDatos("SP_BUSCAR_TMP_NTACREDCABSER '" & codempresa & "','" & CInt(TxtDoc1.Text.Trim + TxtDoc2.Text.Trim) & "','" & CboTipoDoc.SelectedValue & "' ")
                If TB_TMP_NTACREDCABSER.Rows.Count > 0 Then
                    MsgBox("El Documento esta en estado de PROCESO dale SI o NO en el formulario PrePlanilla de aprobación")
                    TxtImporte.Enabled = False
                Else
                    TxtImporte.Enabled = True
                End If

                LblSaldo.Text = Format(CDbl(LblMontoDoc.Text) - MONTOSALD, "#######0.00")
                TxtImporte.Focus()

            Else
                MsgBox("NO EXISTE EL NUMERO DE DOCUMENTO...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            End If
        End If
    End Sub
End Class
