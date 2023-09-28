Public Class FrmDocumContable_Pago
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEjercicio As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents BtnBuscProvee As System.Windows.Forms.Button
    Friend WithEvents TxtCodProvee As System.Windows.Forms.TextBox
    Friend WithEvents LblDesProvee As System.Windows.Forms.Label
    Friend WithEvents LblRuc As System.Windows.Forms.Label
    Friend WithEvents TxtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents DtFechaDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtObs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents PicBuscDoc As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBuscDoc As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDocumContable_Pago))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PicBuscDoc = New System.Windows.Forms.PictureBox
        Me.LblRuc = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.LblDesProvee = New System.Windows.Forms.Label
        Me.BtnBuscDoc = New System.Windows.Forms.Button
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtEjercicio = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TxtNroDoc = New System.Windows.Forms.TextBox
        Me.DtFechaDoc = New System.Windows.Forms.DateTimePicker
        Me.BtnBuscProvee = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TxtCodProvee = New System.Windows.Forms.TextBox
        Me.CboTipoDoc = New System.Windows.Forms.ComboBox
        Me.TxtObs = New System.Windows.Forms.TextBox
        Me.TxtMonto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lbl1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNREPORTE = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PicBuscDoc)
        Me.GroupBox1.Controls.Add(Me.LblRuc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LblDesProvee)
        Me.GroupBox1.Controls.Add(Me.BtnBuscDoc)
        Me.GroupBox1.Controls.Add(Me.cboPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtEjercicio)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxtNroDoc)
        Me.GroupBox1.Controls.Add(Me.DtFechaDoc)
        Me.GroupBox1.Controls.Add(Me.BtnBuscProvee)
        Me.GroupBox1.Controls.Add(Me.TxtCodProvee)
        Me.GroupBox1.Controls.Add(Me.CboTipoDoc)
        Me.GroupBox1.Controls.Add(Me.TxtObs)
        Me.GroupBox1.Controls.Add(Me.TxtMonto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lbl1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PicBuscDoc
        '
        Me.PicBuscDoc.Image = CType(resources.GetObject("PicBuscDoc.Image"), System.Drawing.Image)
        Me.PicBuscDoc.Location = New System.Drawing.Point(680, 150)
        Me.PicBuscDoc.Name = "PicBuscDoc"
        Me.PicBuscDoc.Size = New System.Drawing.Size(32, 32)
        Me.PicBuscDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicBuscDoc.TabIndex = 202
        Me.PicBuscDoc.TabStop = False
        '
        'LblRuc
        '
        Me.LblRuc.BackColor = System.Drawing.Color.White
        Me.LblRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblRuc.Location = New System.Drawing.Point(370, 48)
        Me.LblRuc.Name = "LblRuc"
        Me.LblRuc.Size = New System.Drawing.Size(116, 20)
        Me.LblRuc.TabIndex = 2
        Me.LblRuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 200
        Me.Label8.Text = "R.U.C.: "
        '
        'LblDesProvee
        '
        Me.LblDesProvee.BackColor = System.Drawing.Color.White
        Me.LblDesProvee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblDesProvee.Location = New System.Drawing.Point(160, 72)
        Me.LblDesProvee.Name = "LblDesProvee"
        Me.LblDesProvee.Size = New System.Drawing.Size(326, 20)
        Me.LblDesProvee.TabIndex = 3
        Me.LblDesProvee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBuscDoc
        '
        Me.BtnBuscDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscDoc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBuscDoc.ImageIndex = 5
        Me.BtnBuscDoc.Location = New System.Drawing.Point(648, 146)
        Me.BtnBuscDoc.Name = "BtnBuscDoc"
        Me.BtnBuscDoc.Size = New System.Drawing.Size(96, 74)
        Me.BtnBuscDoc.TabIndex = 10
        Me.BtnBuscDoc.Text = "BUSCAR DOCUMENTO"
        Me.BtnBuscDoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(378, 146)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(170, 21)
        Me.cboPeriodo.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(332, 150)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 16)
        Me.Label22.TabIndex = 195
        Me.Label22.Text = "Periodo: "
        '
        'txtEjercicio
        '
        Me.txtEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEjercicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjercicio.Location = New System.Drawing.Point(378, 122)
        Me.txtEjercicio.MaxLength = 7
        Me.txtEjercicio.Name = "txtEjercicio"
        Me.txtEjercicio.Size = New System.Drawing.Size(40, 20)
        Me.txtEjercicio.TabIndex = 7
        Me.txtEjercicio.Text = "2010"
        Me.txtEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(328, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 193
        Me.Label16.Text = "Ejercicio: "
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(644, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 167
        Me.PictureBox1.TabStop = False
        '
        'TxtNroDoc
        '
        Me.TxtNroDoc.Location = New System.Drawing.Point(158, 124)
        Me.TxtNroDoc.Name = "TxtNroDoc"
        Me.TxtNroDoc.Size = New System.Drawing.Size(92, 20)
        Me.TxtNroDoc.TabIndex = 5
        Me.TxtNroDoc.Text = ""
        '
        'DtFechaDoc
        '
        Me.DtFechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFechaDoc.Location = New System.Drawing.Point(160, 98)
        Me.DtFechaDoc.Name = "DtFechaDoc"
        Me.DtFechaDoc.Size = New System.Drawing.Size(90, 20)
        Me.DtFechaDoc.TabIndex = 4
        '
        'BtnBuscProvee
        '
        Me.BtnBuscProvee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscProvee.ImageIndex = 5
        Me.BtnBuscProvee.ImageList = Me.ImageList1
        Me.BtnBuscProvee.Location = New System.Drawing.Point(268, 42)
        Me.BtnBuscProvee.Name = "BtnBuscProvee"
        Me.BtnBuscProvee.Size = New System.Drawing.Size(30, 23)
        Me.BtnBuscProvee.TabIndex = 10
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TxtCodProvee
        '
        Me.TxtCodProvee.Location = New System.Drawing.Point(160, 44)
        Me.TxtCodProvee.Name = "TxtCodProvee"
        Me.TxtCodProvee.Size = New System.Drawing.Size(106, 20)
        Me.TxtCodProvee.TabIndex = 1
        Me.TxtCodProvee.Text = ""
        '
        'CboTipoDoc
        '
        Me.CboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoDoc.Location = New System.Drawing.Point(160, 14)
        Me.CboTipoDoc.Name = "CboTipoDoc"
        Me.CboTipoDoc.Size = New System.Drawing.Size(228, 21)
        Me.CboTipoDoc.TabIndex = 0
        '
        'TxtObs
        '
        Me.TxtObs.Location = New System.Drawing.Point(158, 176)
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.Size = New System.Drawing.Size(424, 50)
        Me.TxtObs.TabIndex = 9
        Me.TxtObs.Text = ""
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(158, 150)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(76, 20)
        Me.TxtMonto.TabIndex = 6
        Me.TxtMonto.Text = "0.00"
        Me.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Obs. : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nro Documento : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Doc.: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Proveedor : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Documento Contable : "
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(82, 76)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(80, 16)
        Me.Lbl1.TabIndex = 199
        Me.Lbl1.Text = "Razon Social : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monto : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Controls.Add(Me.btnmodificar)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNREPORTE)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 254)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(774, 38)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(6, 8)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(96, 25)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGUARDAR.Enabled = False
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(118, 8)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(96, 25)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "  &Guardar"
        '
        'btnmodificar
        '
        Me.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodificar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.ImageIndex = 2
        Me.btnmodificar.ImageList = Me.ImageList1
        Me.btnmodificar.Location = New System.Drawing.Point(230, 8)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(96, 25)
        Me.btnmodificar.TabIndex = 11
        Me.btnmodificar.Text = "   &Modificar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(344, 8)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(97, 25)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "Anular"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCELAR.Enabled = False
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(456, 8)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(95, 25)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "  &Cancelar"
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 11
        Me.BTNREPORTE.ImageList = Me.ImageList1
        Me.BTNREPORTE.Location = New System.Drawing.Point(562, 8)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(93, 25)
        Me.BTNREPORTE.TabIndex = 6
        Me.BTNREPORTE.Text = "  &Reporte"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCERRAR.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(670, 8)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(91, 25)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Salir"
        '
        'FrmDocumContable_Pago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(790, 308)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDocumContable_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documento Contable de Pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Funciones"

    Private Sub LIMPIAR()
        TxtObs.Text = ""
        cboPeriodo.SelectedIndex = Date.Now.Month - 1
        txtEjercicio.Text = Date.Now.Year
        TxtMonto.Text = "0.00"
        TxtNroDoc.Text = ""
        DtFechaDoc.Value = Date.Now
        LblDesProvee.Text = ""
        LblRuc.Text = ""
        TxtCodProvee.Text = ""





    End Sub


    Private Sub HabilitaBotones(ByVal Valor As Boolean)
        BtnBuscDoc.Enabled = Not Valor
        PicBuscDoc.Enabled = Not Valor
        BTNNUEVO.Enabled = Not Valor
        BTNGUARDAR.Enabled = Valor
        BTNCANCELAR.Enabled = Valor
        btnmodificar.Enabled = Not Valor
        BTNELIMINAR.Enabled = Not Valor

        CboTipoDoc.Enabled = Valor
        BtnBuscProvee.Enabled = Valor
        TxtCodProvee.Enabled = Valor
        DtFechaDoc.Enabled = Valor
        TxtNroDoc.Enabled = Valor
        TxtMonto.Enabled = Valor
        cboPeriodo.Enabled = Valor
        txtEjercicio.Enabled = Valor
        TxtObs.Enabled = Valor



    End Sub

    Private Sub CargarCombos()

        CboTipoDoc.DataSource = TmpListarDatos("SELECT  CODTIPODOC,DSTIPODOC FROM TIPODOC  WHERE  CODEMPRESA='" & codempresa & "'  AND  CONTABLE=1  ORDER BY DSTIPODOC ASC ")
        CboTipoDoc.DisplayMember = "DSTIPODOC"
        CboTipoDoc.ValueMember = "CODTIPODOC"


        cboPeriodo.Items.Add("ENERO")
        cboPeriodo.Items.Add("FEBRERO")
        cboPeriodo.Items.Add("MARZO")
        cboPeriodo.Items.Add("ABRIL")
        cboPeriodo.Items.Add("MAYO")
        cboPeriodo.Items.Add("JUNIO")
        cboPeriodo.Items.Add("JULIO")
        cboPeriodo.Items.Add("AGOSTO")
        cboPeriodo.Items.Add("SEPTIEMBRE")
        cboPeriodo.Items.Add("OCTUBRE")
        cboPeriodo.Items.Add("NOVIEMBRE")
        cboPeriodo.Items.Add("DICIEMBRE")
        cboPeriodo.SelectedIndex = Date.Now.Month - 1

    End Sub
#End Region


    Private Sub FrmDocumContable_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombos()
        HabilitaBotones(False)

    End Sub

    Private Sub BtnBuscProvee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscProvee.Click
        Dim Frmbusc As New FrmBuscarProveedor
        Frmbusc.ShowDialog()
        If Frmbusc.DEVOLVER = False Then
            Exit Sub
        End If
        TxtCodProvee.Text = Frmbusc.DgProveedor.Item(Frmbusc.DgProveedor.CurrentRowIndex, 0)
        LblDesProvee.Text = Frmbusc.DgProveedor.Item(Frmbusc.DgProveedor.CurrentRowIndex, 1)
        LblRuc.Text = Frmbusc.DgProveedor.Item(Frmbusc.DgProveedor.CurrentRowIndex, 2)
        TxtNroDoc.Focus()
    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        HabilitaBotones(True)
        LIMPIAR()
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        HabilitaBotones(False)
        LIMPIAR()
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If IsNothing(CboTipoDoc.SelectedValue) = True Then
            MsgBox("FALTA INDICAR EL TIPO DE DOCUMENTO..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TxtNroDoc.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL NRO DE DOCUMENTO..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TxtCodProvee.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR PROVEEDOR..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TxtMonto.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL MONTO..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If CDbl(TxtMonto.Text) = 0 Then
            MsgBox("EL MONTO NO PUEDE SER CERO ...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If CAyuda.Ejecutar("InsDOCUMCONTABLExProc", codempresa, CboTipoDoc.SelectedValue, CDbl(TxtNroDoc.Text), Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy"), TxtCodProvee.Text, CDbl(TxtMonto.Text), FormatoMonto((CDbl(TxtMonto.Text) / VCambioCompra), DECIRESU), txtEjercicio.Text, cboPeriodo.Text, TxtObs.Text) > 0 Then
            MsgBox("SE GUARDO CORRECTAMENTE EL DOCUMENTO.. ", MsgBoxStyle.Information, "")
            LIMPIAR()
            HabilitaBotones(False)
        End If

    End Sub
    Private Sub TxtCodProvee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodProvee.TextChanged
    End Sub
    Private Sub TxtCodProvee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCodProvee.Click
        TxtCodProvee.Text = ""
        LblDesProvee.Text = ""
        LblRuc.Text = ""

    End Sub

    Private Sub BtnBuscDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscDoc.Click
        Dim VEstado As String

        Dim FrmBusc As New FrmBusqDocumContable
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        VEstado = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 11)
        If VEstado.Trim = "A" Then
            MsgBox("EL DOCUMENTO SE ENCUENTRA ANULADO ...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        CboTipoDoc.SelectedValue = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 0)
        TxtCodProvee.Text = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 4)
        LblDesProvee.Text = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 5)
        LblRuc.Text = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 6)
        DtFechaDoc.Value = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 3)
        TxtNroDoc.Text = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 2)
        txtEjercicio.Text = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 8)
        TxtMonto.Text = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 7)
        cboPeriodo.Text = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 9)
        TxtObs.Text = FrmBusc.DtgDocum.Item(FrmBusc.DtgDocum.CurrentRowIndex, 10)




    End Sub

    Private Sub PicBuscDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicBuscDoc.Click
        BtnBuscDoc_Click(sender, e)

    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If IsNothing(CboTipoDoc.SelectedValue) = True Then
            MsgBox("FALTA INDICAR EL TIPO DE DOCUMENTO..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TxtNroDoc.Text.Trim = "" Then
            MsgBox("FALTA INDICAR EL NRO DE DOCUMENTO..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If MsgBox("ESTA SEGURO DE ANULAR EL DOCUMENTO..", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        If CAyuda.Ejecutar("AnulaDOCUMCONTABLExProc", codempresa, CboTipoDoc.SelectedValue, TxtNroDoc.Text) > 0 Then
            MsgBox("SE ANULO CORRECTAMENTE ... ", MsgBoxStyle.Information, "")
            HabilitaBotones(False)
            LIMPIAR()
        End If

    End Sub
End Class
