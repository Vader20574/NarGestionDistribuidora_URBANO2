Public Class FrmNotaDebitoProvee
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEjercicio As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtObs As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtmoneda As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtcambio As System.Windows.Forms.TextBox
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCodProvee As System.Windows.Forms.TextBox
    Friend WithEvents TxtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents btnnotcred As System.Windows.Forms.Button
    Friend WithEvents btnreferncia As System.Windows.Forms.Button
    Friend WithEvents Txtruc As System.Windows.Forms.TextBox
    Friend WithEvents TxtNroRef As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtNtaDeb1 As System.Windows.Forms.TextBox
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents TxtNtaDeb2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotaDebitoProvee))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.Button2 = New System.Windows.Forms.Button
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnCerrar = New System.Windows.Forms.Button
        Me.BtnAnular = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnNuevo = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.TxtIgv = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtSubTotal = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtEjercicio = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtObs = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtmoneda = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtNtaDeb1 = New System.Windows.Forms.TextBox
        Me.txtcambio = New System.Windows.Forms.TextBox
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtCodProvee = New System.Windows.Forms.TextBox
        Me.TxtProveedor = New System.Windows.Forms.TextBox
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.btnnotcred = New System.Windows.Forms.Button
        Me.btnreferncia = New System.Windows.Forms.Button
        Me.Txtruc = New System.Windows.Forms.TextBox
        Me.TxtNroRef = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtNtaDeb2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tipo"
        Me.ColumnHeader2.Width = 65
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(56, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 24)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Eliminar Documento"
        Me.Button2.Visible = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nro Doc"
        Me.ColumnHeader3.Width = 155
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 244)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 13)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Dinero A Devolver :"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(22, 318)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(208, 16)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Documentos de la Nota de Cr�dito"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnImprimir)
        Me.GroupBox2.Controls.Add(Me.BtnCancelar)
        Me.GroupBox2.Controls.Add(Me.BtnCerrar)
        Me.GroupBox2.Controls.Add(Me.BtnAnular)
        Me.GroupBox2.Controls.Add(Me.BtnGuardar)
        Me.GroupBox2.Controls.Add(Me.BtnNuevo)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(646, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 234)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'BtnImprimir
        '
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.ImageIndex = 12
        Me.BtnImprimir.ImageList = Me.ImageList1
        Me.BtnImprimir.Location = New System.Drawing.Point(14, 109)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(84, 23)
        Me.BtnImprimir.TabIndex = 6
        Me.BtnImprimir.Text = "     &Imprimir"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 6
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(13, 135)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(84, 23)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "      &Cancelar"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.ImageIndex = 14
        Me.BtnCerrar.ImageList = Me.ImageList1
        Me.BtnCerrar.Location = New System.Drawing.Point(13, 164)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(84, 23)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "  &Cerrar"
        '
        'BtnAnular
        '
        Me.BtnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnular.ImageIndex = 3
        Me.BtnAnular.ImageList = Me.ImageList1
        Me.BtnAnular.Location = New System.Drawing.Point(13, 81)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(84, 23)
        Me.BtnAnular.TabIndex = 2
        Me.BtnAnular.Text = "   &Anular"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.ImageIndex = 1
        Me.BtnGuardar.ImageList = Me.ImageList1
        Me.BtnGuardar.Location = New System.Drawing.Point(13, 52)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(84, 23)
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.Text = "     &Guardar"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.ImageIndex = 0
        Me.BtnNuevo.ImageList = Me.ImageList1
        Me.BtnNuevo.Location = New System.Drawing.Point(13, 23)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(84, 23)
        Me.BtnNuevo.TabIndex = 10
        Me.BtnNuevo.Text = "    &Nuevo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtTotal)
        Me.GroupBox3.Controls.Add(Me.TxtIgv)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 54)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        '
        'TxtTotal
        '
        Me.TxtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(416, 20)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(86, 21)
        Me.TxtTotal.TabIndex = 33
        Me.TxtTotal.Text = "0.00"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtIgv
        '
        Me.TxtIgv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtIgv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIgv.Location = New System.Drawing.Point(236, 20)
        Me.TxtIgv.Name = "TxtIgv"
        Me.TxtIgv.Size = New System.Drawing.Size(86, 21)
        Me.TxtIgv.TabIndex = 32
        Me.TxtIgv.Text = "0.00"
        Me.TxtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(344, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Total   S/. :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(192, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "I.G.V. :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Sub Total :"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSubTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubTotal.Location = New System.Drawing.Point(86, 20)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(86, 21)
        Me.TxtSubTotal.TabIndex = 31
        Me.TxtSubTotal.Text = "0.00"
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(22, 342)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(224, 72)
        Me.ListView1.TabIndex = 68
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(660, 264)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 64
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cboPeriodo)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.txtEjercicio)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.TxtObs)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.txtmoneda)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.TxtNtaDeb1)
        Me.GroupBox6.Controls.Add(Me.txtcambio)
        Me.GroupBox6.Controls.Add(Me.dtpfecha)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.TxtCodProvee)
        Me.GroupBox6.Controls.Add(Me.TxtProveedor)
        Me.GroupBox6.Controls.Add(Me.TxtDireccion)
        Me.GroupBox6.Controls.Add(Me.btnnotcred)
        Me.GroupBox6.Controls.Add(Me.btnreferncia)
        Me.GroupBox6.Controls.Add(Me.Txtruc)
        Me.GroupBox6.Controls.Add(Me.TxtNroRef)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.TxtNtaDeb2)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Location = New System.Drawing.Point(4, 10)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(638, 232)
        Me.GroupBox6.TabIndex = 67
        Me.GroupBox6.TabStop = False
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(198, 72)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(110, 21)
        Me.cboPeriodo.TabIndex = 192
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(148, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 13)
        Me.Label22.TabIndex = 191
        Me.Label22.Text = "Periodo: "
        '
        'txtEjercicio
        '
        Me.txtEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEjercicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjercicio.Location = New System.Drawing.Point(92, 74)
        Me.txtEjercicio.MaxLength = 7
        Me.txtEjercicio.Name = "txtEjercicio"
        Me.txtEjercicio.Size = New System.Drawing.Size(40, 20)
        Me.txtEjercicio.TabIndex = 190
        Me.txtEjercicio.Text = "2010"
        Me.txtEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 16)
        Me.Label16.TabIndex = 189
        Me.Label16.Text = "Ejercicio : "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Observacion :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtObs
        '
        Me.TxtObs.Location = New System.Drawing.Point(92, 180)
        Me.TxtObs.MaxLength = 100
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.Size = New System.Drawing.Size(334, 38)
        Me.TxtObs.TabIndex = 65
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(528, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 113)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'txtmoneda
        '
        Me.txtmoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmoneda.Location = New System.Drawing.Point(528, 204)
        Me.txtmoneda.Name = "txtmoneda"
        Me.txtmoneda.ReadOnly = True
        Me.txtmoneda.Size = New System.Drawing.Size(98, 21)
        Me.txtmoneda.TabIndex = 46
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(448, 206)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 13)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "Tipo Moneda :"
        '
        'TxtNtaDeb1
        '
        Me.TxtNtaDeb1.AcceptsReturn = True
        Me.TxtNtaDeb1.Location = New System.Drawing.Point(92, 20)
        Me.TxtNtaDeb1.MaxLength = 3
        Me.TxtNtaDeb1.Name = "TxtNtaDeb1"
        Me.TxtNtaDeb1.Size = New System.Drawing.Size(32, 20)
        Me.TxtNtaDeb1.TabIndex = 41
        Me.TxtNtaDeb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcambio
        '
        Me.txtcambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcambio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcambio.Location = New System.Drawing.Point(528, 154)
        Me.txtcambio.Name = "txtcambio"
        Me.txtcambio.ReadOnly = True
        Me.txtcambio.Size = New System.Drawing.Size(96, 21)
        Me.txtcambio.TabIndex = 29
        Me.txtcambio.Text = "0.00"
        '
        'dtpfecha
        '
        Me.dtpfecha.Enabled = False
        Me.dtpfecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(528, 180)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(97, 21)
        Me.dtpfecha.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(450, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Tipo Cambio :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(460, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Fecha Doc :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Referencia :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IdProveedor :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Direcci�n :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCodProvee
        '
        Me.TxtCodProvee.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodProvee.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodProvee.Location = New System.Drawing.Point(92, 102)
        Me.TxtCodProvee.Name = "TxtCodProvee"
        Me.TxtCodProvee.ReadOnly = True
        Me.TxtCodProvee.Size = New System.Drawing.Size(104, 21)
        Me.TxtCodProvee.TabIndex = 12
        '
        'TxtProveedor
        '
        Me.TxtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtProveedor.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProveedor.Location = New System.Drawing.Point(92, 128)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.ReadOnly = True
        Me.TxtProveedor.Size = New System.Drawing.Size(332, 21)
        Me.TxtProveedor.TabIndex = 13
        '
        'TxtDireccion
        '
        Me.TxtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDireccion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(92, 154)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(332, 21)
        Me.TxtDireccion.TabIndex = 14
        '
        'btnnotcred
        '
        Me.btnnotcred.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnotcred.ImageIndex = 5
        Me.btnnotcred.ImageList = Me.ImageList1
        Me.btnnotcred.Location = New System.Drawing.Point(210, 18)
        Me.btnnotcred.Name = "btnnotcred"
        Me.btnnotcred.Size = New System.Drawing.Size(40, 23)
        Me.btnnotcred.TabIndex = 16
        '
        'btnreferncia
        '
        Me.btnreferncia.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreferncia.ImageIndex = 5
        Me.btnreferncia.ImageList = Me.ImageList1
        Me.btnreferncia.Location = New System.Drawing.Point(202, 101)
        Me.btnreferncia.Name = "btnreferncia"
        Me.btnreferncia.Size = New System.Drawing.Size(36, 23)
        Me.btnreferncia.TabIndex = 17
        '
        'Txtruc
        '
        Me.Txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtruc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtruc.Location = New System.Drawing.Point(318, 102)
        Me.Txtruc.Name = "Txtruc"
        Me.Txtruc.ReadOnly = True
        Me.Txtruc.Size = New System.Drawing.Size(108, 21)
        Me.Txtruc.TabIndex = 19
        '
        'TxtNroRef
        '
        Me.TxtNroRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNroRef.Location = New System.Drawing.Point(88, 47)
        Me.TxtNroRef.Name = "TxtNroRef"
        Me.TxtNroRef.Size = New System.Drawing.Size(214, 20)
        Me.TxtNroRef.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Proveedor :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtNtaDeb2
        '
        Me.TxtNtaDeb2.Location = New System.Drawing.Point(140, 20)
        Me.TxtNtaDeb2.MaxLength = 7
        Me.TxtNtaDeb2.Name = "TxtNtaDeb2"
        Me.TxtNtaDeb2.Size = New System.Drawing.Size(68, 20)
        Me.TxtNtaDeb2.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(128, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 16)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(278, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "R.U.C."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota Debito N� :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(715, 259)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 71
        '
        'FrmNotaDebitoProvee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1001, 476)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmNotaDebitoProvee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nota de Debito a Proveedor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables de Form"
    Private VNroNotaDeb As String
    Private ActEvntCmb As Boolean

    Public AObjBus As New ClsAyuda


#End Region
    Public MENU_ As String
#Region "Funcion del Form"

    Private Sub CargarData()
        'CargadataCombos(cmbreferncia, "ListarTIPODOC_PARA_NTACRED  '" & codempresa & "'", "CODTIPODOC", "DSTIPODOC")


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

    End Sub
    Private Sub CapturarNroNotaDeb()

        If TxtNtaDeb1.Text.Trim = "" Then
            TxtNtaDeb1.Text = "000"
        End If

        If TxtNtaDeb2.Text.Trim = "" Then
            TxtNtaDeb2.Text = "0000000"
        End If
        VNroNotaDeb = CStr(CInt(TxtNtaDeb1.Text)) + TxtNtaDeb2.Text


    End Sub

    Private Sub HabilitaBotones(ByVal valor As Boolean)
        BtnNuevo.Enabled = valor
        BtnAnular.Enabled = valor
        BtnImprimir.Enabled = valor
        BtnGuardar.Enabled = Not valor
        BtnCancelar.Enabled = Not valor

    End Sub
    Private Sub LimpiarForm()
        TxtNtaDeb1.Text = ""
        TxtNtaDeb2.Text = ""
        'TxtCodRef.Text = ""
        TxtNroRef.Text = ""
        TxtCodProvee.Text = ""
        Txtruc.Text = ""
        TxtProveedor.Text = ""
        TxtDireccion.Text = ""
        TxtObs.Text = ""
        TxtSubTotal.Text = "0.00"
        TxtIgv.Text = "0.00"
        TxtTotal.Text = "0.00"
        txtcambio.Text = VCambioCompra.ToString
        dtpfecha.Value = Date.Now
        txtmoneda.Text = CDMONBASE
        txtEjercicio.Text = CDate(Date.Now).Year.ToString
        cboPeriodo.SelectedIndex = Date.Now.Month - 1


    End Sub
    Private Sub HabilitarCajas(ByVal valor As Boolean)
        btnnotcred.Visible = valor
        TxtNtaDeb1.Enabled = Not valor
        TxtNtaDeb2.Enabled = Not valor
        'cmbreferncia.Enabled = Not valor
        'TxtCodRef.Enabled = Not valor
        TxtNroRef.Enabled = Not valor
        TxtCodProvee.Enabled = Not valor
        Txtruc.Enabled = Not valor
        TxtProveedor.Enabled = Not valor
        TxtDireccion.Enabled = Not valor
        TxtObs.Enabled = Not valor
        TxtSubTotal.Enabled = Not valor
        TxtIgv.Enabled = Not valor
        TxtTotal.Enabled = Not valor
        dtpfecha.Enabled = Not valor
        btnreferncia.Enabled = Not valor


    End Sub

#End Region


#Region "EVENTO KEYS-PRESS"

    Private Sub KeyPres_SoloNumero(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNtaDeb1.KeyPress, TxtNtaDeb2.KeyPress
        If IsNumeric(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If

    End Sub
    Private Sub KeyPres_SoloMonto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSubTotal.KeyPress, TxtIgv.KeyPress, TxtTotal.KeyPress
        Dim Cadena As String
        If IsNumeric(e.KeyChar) = False And Asc(e.KeyChar) <> 8 Then
            If CStr(e.KeyChar) = "." Then
                Cadena = CType(sender, Control).Text.Trim
                For i As Integer = 1 To Cadena.Length
                    If Mid(Cadena, i, 1) = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            End If
        End If




    End Sub


#End Region





    Private Sub TxtNtaCred_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNtaDeb1.TextChanged

    End Sub

    Private Sub TxtNtaCred_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNtaDeb1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Cadena As String
            Cadena = "0000" & TxtNtaDeb1.Text.Trim
            TxtNtaDeb1.Text = Mid(Cadena, Cadena.Length - 2, Cadena.Length)
            TxtNtaDeb2.Focus()
        End If

    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub



    Private Sub FrmNotaDebitoProvee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarData()
        LimpiarForm()
        ActEvntCmb = True
        cmbreferncia_SelectedIndexChanged(sender, e)
        HabilitaBotones(True)
        HabilitarCajas(True)

        Me.dtpfecha.Value = Format(vFechaActual, "dd/MM/yyyy")



        If MENU_ = "Nota de Debito x Dinero del Proveedor C" Then
            BtnNuevo.Enabled = False
            BtnAnular.Enabled = False
        End If


    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        LimpiarForm()
        HabilitaBotones(False)
        HabilitarCajas(False)
        TxtNtaDeb1.Focus()

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click


        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim A�O As String
        Dim MES As String
        Dim DESMES As String = ""

        A�O = dtpfecha.Value.Year
        MES = dtpfecha.Value.Month

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

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & A�O & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL A�O " & A�O & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub

        End If
        '************************************************************************************************




        CapturarNroNotaDeb()
        If VNroNotaDeb = "" Then
            MsgBox("FALTA INGRESAR EL NRO DE NOTA DE CREDITO", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If CInt(TxtNtaDeb1.Text) = 0 Then
            MsgBox("FALTA INGRESAR EL NRO DE SERIE DE NOTA DE CREDITO", MsgBoxStyle.Exclamation, "")
            TxtNtaDeb1.Focus()
            Exit Sub
        End If


        If CInt(TxtNtaDeb2.Text) = 0 Then
            MsgBox("FALTA INGRESAR EL NRO DE DOC DE NOTA DE CREDITO", MsgBoxStyle.Exclamation, "")
            TxtNtaDeb2.Focus()
            Exit Sub
        End If



        If CDbl(VNroNotaDeb) = 0 Then
            MsgBox("FALTA INGRESAR EL NRO DE NOTA DE CREDITO", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TxtNroRef.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR EL NRO DOCUMENTO DE REFERENCIA", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TxtSubTotal.Text.Trim = "" Or TxtIgv.Text.Trim = "" Or TxtTotal.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR MONTO DE NOTA DE CREDITO", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If CDbl(TxtSubTotal.Text) = 0 Or CDbl(TxtIgv.Text) = 0 Or CDbl(TxtTotal.Text) = 0 Then
            MsgBox("FALTA INGRESAR MONTO DE NOTA DE CREDITO", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        'If VTotbas < CDbl(TxtTotal.Text) Then
        '    MsgBox("EL TOTAL EXCEDE AL SALDO DEL DOCUMENTO DE REFERENCIA..", MsgBoxStyle.Exclamation, "")
        '    Exit Sub
        'End If


        If TmpListarDatos("SelecNTADEBITOCOMCABxNRO  '" & codempresa & "','" & VNroNotaDeb & "'").Rows.Count > 0 Then
            MsgBox("YA EXISTE ESTE NUMERO DE NOTA DE CREDITO...", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If CAyuda.Ejecutar("InsNTADEBITOCOMPRASxProc", codempresa, VNroNotaDeb, "D", "09", TxtNroRef.Text, txtmoneda.Text, txtcambio.Text, Format(dtpfecha.Value, "dd/MM/yyyy"), CDbl(TxtTotal.Text), FormatoMonto(CDbl(TxtTotal.Text) / CDbl(txtcambio.Text), CInt(DECIRESU)), CDbl(TxtSubTotal.Text), FormatoMonto(CDbl(TxtSubTotal.Text) / CDbl(txtcambio.Text), CInt(DECIRESU)), CDbl(TxtIgv.Text), FormatoMonto(CDbl(TxtIgv.Text) / CDbl(txtcambio.Text), CInt(DECIRESU)), TxtCodProvee.Text, TxtProveedor.Text, Txtruc.Text, TxtDireccion.Text, CodUsuario, TxtObs.Text, txtEjercicio.Text, cboPeriodo.Text) > 1 Then
            MsgBox("SE GUARDO CORRECTAMENTE..", MsgBoxStyle.Information, "")
            LimpiarForm()
            HabilitaBotones(True)
            HabilitarCajas(True)
        End If

    End Sub



    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click



        Dim Proceso As String
        Proceso = "ANULNTADEBPROVEE"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If




        HabilitaBotones(True)



        CapturarNroNotaDeb()

        Dim TABLE_BUSQPAGOPROV As New DataTable
        TABLE_BUSQPAGOPROV = TmpListarDatos("NSP_BUSQUEDA_PAGO_PROVEE  '" & VNroNotaDeb & "','" & "09" & "'  ")
        If CInt(TABLE_BUSQPAGOPROV.Rows(0)("NROPAGO").ToString) = 0 Then

        Else
            MsgBox("Tiene Planilla de Pago a Proveedor nro " & TABLE_BUSQPAGOPROV.Rows(0)("NROPAGO").ToString, MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
            Exit Sub
        End If


        If VNroNotaDeb = "" Then
            MsgBox("FALTA INGRESAR EL NRO DE NOTA DE CREDITO", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If


        If MessageBox.Show("�Deseas Aular El Domuneto ?", "Informaci�n", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            AObjBus.Ejecutar("NSP_upd_NTADEBITOCOMCAB", VNroNotaDeb, codempresa)
            AObjBus.Ejecutar("NSP_DEL_NOTACREDITO_VENTAXPAGAR", codempresa, VNroNotaDeb, 2)
            'AObjBus.Ejecutar("SP_REGISTRA_AUDITORIA", VNroNotaCred, "ANULAR", "NOTACRED", Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt"), CodUsuario, codempresa)
            BtnCancelar_Click(sender, e)
            'Exit Sub
        End If


    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        LimpiarForm()
        HabilitaBotones(True)
        HabilitarCajas(True)

    End Sub


    Private Sub TxtSubTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSubTotal.TextChanged

    End Sub

    Private Sub TxtSubTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSubTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtSubTotal.Text.Trim = "" Then
                Exit Sub
            End If
            TxtSubTotal.Text = FormatoMonto(CDbl(TxtSubTotal.Text), CInt(DECIRESU))
            TxtIgv.Text = FormatoMonto(CDbl(TxtSubTotal.Text) * CDbl((CDbl(PORCIGV) / 100)), CInt(DECIRESU))
            TxtIgv.Focus()

        End If
    End Sub
    Private Sub TxtIgv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIgv.TextChanged
    End Sub
    Private Sub TxtIgv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtIgv.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtSubTotal.Text.Trim = "" Then
                Exit Sub
            End If
            If TxtIgv.Text.Trim = "" Then
                Exit Sub
            End If
            TxtTotal.Text = FormatoMonto(CDbl(TxtSubTotal.Text) + CDbl(TxtIgv.Text), CInt(DECIRESU))
            TxtTotal.Focus()
        End If
    End Sub
    Private Sub TxtNtaCred2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNtaDeb2.TextChanged


    End Sub

    Private Sub TxtNtaCred2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNtaDeb2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Cadena As String
            Cadena = "0000000" & TxtNtaDeb2.Text.Trim
            TxtNtaDeb2.Text = Mid(Cadena, Cadena.Length - 6, Cadena.Length)

            TxtNroRef.Focus()

        End If
    End Sub

    Private Sub cmbreferncia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If ActEvntCmb = True Then
            'TxtCodRef.Text = IIf(IsNothing(cmbreferncia.SelectedValue), "", cmbreferncia.SelectedValue)

        End If

    End Sub

    Private Sub btnreferncia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreferncia.Click
        Dim FrmBusc As New FrmBuscarProveedor
        'VCdTipoDoc = IIf(IsNothing(cmbreferncia.SelectedValue), "", cmbreferncia.SelectedValue)
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        'Dim TAB_COMPRAS As New DataTable
        'TAB_COMPRAS = TmpListarDatos("SelecMOVICABxProc  '" & codempresa & "','" & CStr(FrmBusc.GridCompras.Item(FrmBusc.GridCompras.CurrentRowIndex, 1)).Trim & "','" & CStr(FrmBusc.GridCompras.Item(FrmBusc.GridCompras.CurrentRowIndex, 2)).Trim & "'")

        'cmbreferncia.SelectedValue = CStr(TAB_COMPRAS.Rows(0)("CDTIPODOC")).Trim
        'TxtNroRef.Text = CStr(TAB_COMPRAS.Rows(0)("NRODOC")).Trim
        TxtCodProvee.Text = CStr(FrmBusc.DgProveedor.Item(FrmBusc.DgProveedor.CurrentRowIndex, 0)).Trim
        Txtruc.Text = CStr(FrmBusc.DgProveedor.Item(FrmBusc.DgProveedor.CurrentRowIndex, 1)).Trim
        TxtProveedor.Text = CStr(FrmBusc.DgProveedor.Item(FrmBusc.DgProveedor.CurrentRowIndex, 2)).Trim
        TxtDireccion.Text = CStr(FrmBusc.DgProveedor.Item(FrmBusc.DgProveedor.CurrentRowIndex, 3)).Trim
        'VTotbas = CDbl(TmpListarDatos("ObtenSaldoDocuCom  '" & codempresa & "','" & TxtCodRef.Text.Trim & "','" & TxtNroRef.Text.Trim & "'").Rows(0)(0))
        TxtObs.Focus()

    End Sub

    Private Sub TxtNroRef_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNroRef.TextChanged
        If TxtNroRef.Text.Trim = "" Then
            TxtCodProvee.Text = ""
            Txtruc.Text = ""
            TxtProveedor.Text = ""
            TxtDireccion.Text = ""
        End If
    End Sub

    Private Sub TxtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTotal.TextChanged

    End Sub

    Private Sub TxtTotal_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles TxtTotal.Layout
    End Sub

    Private Sub TxtTotal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTotal.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TxtTotal.Text.Trim = "" Then
                Exit Sub
            End If
            TxtSubTotal.Text = FormatoMonto(CDbl(TxtTotal.Text) / ((CDbl(PORCIGV) / 100) + 1), CInt(DECIRESU))
            TxtIgv.Text = FormatoMonto((CDbl(TxtTotal.Text) / ((CDbl(PORCIGV) / 100) + 1)) * (CDbl(PORCIGV) / 100), CInt(DECIRESU))
        End If
    End Sub
    Private Sub btnnotcred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnotcred.Click
        Dim FrmBus As New FrmBusqNtaDebitoCompra
        FrmBus.ShowDialog()
        If FrmBus.DEVOLVER = False Then
            Exit Sub
        End If


        Dim ATblNotCred As DataTable
        Dim NRONTACRED As String

        ATblNotCred = AObjBus.ListarDatos("NSP_SELECT_NTADEBITOCOMCAB", codempresa.ToString(), FrmBus.GridNtaCred.Item(FrmBus.GridNtaCred.CurrentRowIndex, 0).ToString).Tables(0)

        If ATblNotCred.Rows.Count > 0 Then
            NRONTACRED = ATblNotCred.Rows(0)(1)


            Me.TxtNtaDeb2.Text = Strings.Right("0000000" + CType(NRONTACRED, String), 7)
            Me.TxtNtaDeb1.Text = Strings.Right("000" + Strings.Left(CType(NRONTACRED, String), Len(CType(NRONTACRED, String)) - 7), 3)

            txtEjercicio.Text = ATblNotCred.Rows(0)("EJERCICIO")
            cboPeriodo.SelectedValue = ATblNotCred.Rows(0)("PERIODO")
            'cmbreferncia.SelectedValue = ATblNotCred.Rows(0)("CODTIPODOC")
            TxtNroRef.Text = ATblNotCred.Rows(0)("NROREFE")
            TxtCodProvee.Text = ATblNotCred.Rows(0)("CODPROVEEDOR")


            Txtruc.Text = ATblNotCred.Rows(0)("RUCPROVEEDOR")
            TxtProveedor.Text = ATblNotCred.Rows(0)("DESPROVEEDOR")
            TxtCodProvee.Text = ATblNotCred.Rows(0)("CODPROVEEDOR")
            TxtDireccion.Text = ATblNotCred.Rows(0)("DIRPROVEEDOR")
            TxtObs.Text = ATblNotCred.Rows(0)("OBS")
            TxtSubTotal.Text = ATblNotCred.Rows(0)("SUBTOTBAS")
            TxtIgv.Text = ATblNotCred.Rows(0)("IGVBAS")
            TxtTotal.Text = ATblNotCred.Rows(0)("TOTBAS")


            txtmoneda.Text = ATblNotCred.Rows(0)("CDMONEDA")
            dtpfecha.Value = Format(CDate(ATblNotCred.Rows(0)("FECDOCUM")), "dd/MM/yyyy")
            txtcambio.Text = ATblNotCred.Rows(0)("CAMBIO")

            '  TxtMontoInicial.Text = ""

            If ATblNotCred.Rows(0)("ESTADO") = "A" Then
                BtnAnular.Enabled = False
                MessageBox.Show("� DOCUMENTO ANULADO................ !", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If ATblNotCred.Rows(0)("ESTADO") = "G" Then
                    BtnAnular.Enabled = False
                    MessageBox.Show("� DOCUMENTO GENERADO........ !", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'If AObjBus.ListarDatos("NSP_SELECT_BUSCA_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 1).Tables(0).Rows.Count = 0 Then
                    '    BTNELIMINAR.Enabled = False
                    '    MessageBox.Show("� DOCUMENTO GENERADO CANCELADO EN CUENTAS POR COBRAR !", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    'Else
                    BtnAnular.Enabled = True
                    'End If

                End If
            End If




        End If




        If MENU_ = "Nota de Debito x Dinero del Proveedor C" Then
            BtnNuevo.Enabled = False
            BtnAnular.Enabled = False
        End If




    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click


        CapturarNroNotaDeb()
        If VNroNotaDeb = "" Then
            MsgBox("FALTA INGRESAR EL NRO DE NOTA DE CREDITO", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "RptNtaDebitoCom.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                .set_StoredProcParam(1, VNroNotaDeb)
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
