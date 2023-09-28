Public Class FrmCierreDeMes
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DtAño As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrpCierre As System.Windows.Forms.GroupBox
    Friend WithEvents Chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk6 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk4 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk12 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk11 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk10 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk9 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk8 As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Chk7 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCierreDeMes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.GrpCierre = New System.Windows.Forms.GroupBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.Chk3 = New System.Windows.Forms.CheckBox()
        Me.Chk4 = New System.Windows.Forms.CheckBox()
        Me.Chk5 = New System.Windows.Forms.CheckBox()
        Me.Chk6 = New System.Windows.Forms.CheckBox()
        Me.Chk7 = New System.Windows.Forms.CheckBox()
        Me.Chk8 = New System.Windows.Forms.CheckBox()
        Me.Chk10 = New System.Windows.Forms.CheckBox()
        Me.Chk11 = New System.Windows.Forms.CheckBox()
        Me.Chk12 = New System.Windows.Forms.CheckBox()
        Me.Chk9 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtAño = New System.Windows.Forms.DateTimePicker()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCierre.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 118)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Con este formulario  se cerrara las ventas y las compras del mes."
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(716, 210)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(122, 38)
        Me.BtnAceptar.TabIndex = 49
        Me.BtnAceptar.Text = "Iniciar Cierre de Mes"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(632, 22)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "CIERRE DE MES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(716, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 38)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Cancelar"
        '
        'Chk1
        '
        Me.Chk1.Location = New System.Drawing.Point(10, 12)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(104, 24)
        Me.Chk1.TabIndex = 56
        Me.Chk1.Text = "Enero"
        '
        'GrpCierre
        '
        Me.GrpCierre.Controls.Add(Me.Chk2)
        Me.GrpCierre.Controls.Add(Me.Chk3)
        Me.GrpCierre.Controls.Add(Me.Chk4)
        Me.GrpCierre.Controls.Add(Me.Chk5)
        Me.GrpCierre.Controls.Add(Me.Chk6)
        Me.GrpCierre.Controls.Add(Me.Chk7)
        Me.GrpCierre.Controls.Add(Me.Chk8)
        Me.GrpCierre.Controls.Add(Me.Chk10)
        Me.GrpCierre.Controls.Add(Me.Chk11)
        Me.GrpCierre.Controls.Add(Me.Chk1)
        Me.GrpCierre.Controls.Add(Me.Chk12)
        Me.GrpCierre.Controls.Add(Me.Chk9)
        Me.GrpCierre.Enabled = False
        Me.GrpCierre.Location = New System.Drawing.Point(8, 180)
        Me.GrpCierre.Name = "GrpCierre"
        Me.GrpCierre.Size = New System.Drawing.Size(366, 118)
        Me.GrpCierre.TabIndex = 57
        Me.GrpCierre.TabStop = False
        '
        'Chk2
        '
        Me.Chk2.Location = New System.Drawing.Point(10, 38)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(104, 24)
        Me.Chk2.TabIndex = 68
        Me.Chk2.Text = "Febrero"
        '
        'Chk3
        '
        Me.Chk3.Location = New System.Drawing.Point(10, 64)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(104, 24)
        Me.Chk3.TabIndex = 67
        Me.Chk3.Text = "Marzo"
        '
        'Chk4
        '
        Me.Chk4.Location = New System.Drawing.Point(10, 88)
        Me.Chk4.Name = "Chk4"
        Me.Chk4.Size = New System.Drawing.Size(104, 24)
        Me.Chk4.TabIndex = 66
        Me.Chk4.Text = "Abrir"
        '
        'Chk5
        '
        Me.Chk5.Location = New System.Drawing.Point(134, 14)
        Me.Chk5.Name = "Chk5"
        Me.Chk5.Size = New System.Drawing.Size(104, 24)
        Me.Chk5.TabIndex = 65
        Me.Chk5.Text = "Mayo"
        '
        'Chk6
        '
        Me.Chk6.Location = New System.Drawing.Point(134, 38)
        Me.Chk6.Name = "Chk6"
        Me.Chk6.Size = New System.Drawing.Size(104, 24)
        Me.Chk6.TabIndex = 64
        Me.Chk6.Text = "Junio"
        '
        'Chk7
        '
        Me.Chk7.Location = New System.Drawing.Point(134, 62)
        Me.Chk7.Name = "Chk7"
        Me.Chk7.Size = New System.Drawing.Size(104, 24)
        Me.Chk7.TabIndex = 63
        Me.Chk7.Text = "Julio"
        '
        'Chk8
        '
        Me.Chk8.Location = New System.Drawing.Point(134, 88)
        Me.Chk8.Name = "Chk8"
        Me.Chk8.Size = New System.Drawing.Size(104, 24)
        Me.Chk8.TabIndex = 62
        Me.Chk8.Text = "Agosto"
        '
        'Chk10
        '
        Me.Chk10.Location = New System.Drawing.Point(254, 38)
        Me.Chk10.Name = "Chk10"
        Me.Chk10.Size = New System.Drawing.Size(104, 24)
        Me.Chk10.TabIndex = 60
        Me.Chk10.Text = "Octubre"
        '
        'Chk11
        '
        Me.Chk11.Location = New System.Drawing.Point(254, 64)
        Me.Chk11.Name = "Chk11"
        Me.Chk11.Size = New System.Drawing.Size(104, 24)
        Me.Chk11.TabIndex = 59
        Me.Chk11.Text = "Noviembre"
        '
        'Chk12
        '
        Me.Chk12.Location = New System.Drawing.Point(254, 88)
        Me.Chk12.Name = "Chk12"
        Me.Chk12.Size = New System.Drawing.Size(104, 24)
        Me.Chk12.TabIndex = 57
        Me.Chk12.Text = "Diciembre"
        '
        'Chk9
        '
        Me.Chk9.Location = New System.Drawing.Point(254, 14)
        Me.Chk9.Name = "Chk9"
        Me.Chk9.Size = New System.Drawing.Size(104, 24)
        Me.Chk9.TabIndex = 61
        Me.Chk9.Text = "Septiembre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Año:"
        '
        'DtAño
        '
        Me.DtAño.CustomFormat = "yyyy"
        Me.DtAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtAño.Location = New System.Drawing.Point(50, 150)
        Me.DtAño.Name = "DtAño"
        Me.DtAño.ShowUpDown = True
        Me.DtAño.Size = New System.Drawing.Size(66, 20)
        Me.DtAño.TabIndex = 60
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.ImageIndex = 5
        Me.BtnBuscar.ImageList = Me.ImageList1
        Me.BtnBuscar.Location = New System.Drawing.Point(126, 150)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(118, 23)
        Me.BtnBuscar.TabIndex = 61
        Me.BtnBuscar.Text = "Buscar Cierre  "
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
        '
        'BtnGuardar
        '
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.ImageIndex = 1
        Me.BtnGuardar.ImageList = Me.ImageList1
        Me.BtnGuardar.Location = New System.Drawing.Point(262, 38)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(110, 23)
        Me.BtnGuardar.TabIndex = 62
        Me.BtnGuardar.Text = "Guardar"
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.ImageIndex = 12
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(262, 66)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 23)
        Me.BtnSalir.TabIndex = 63
        Me.BtnSalir.Text = "Salir"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 1
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(676, 154)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 45)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Reportes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfin)
        Me.GroupBox1.Controls.Add(Me.dtpinicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(662, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 80)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(86, 39)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(118, 20)
        Me.dtpfin.TabIndex = 1
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(86, 13)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(118, 20)
        Me.dtpinicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Desde :"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(676, 244)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 66
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(686, 287)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaIni.TabIndex = 68
        Me.DtFechaIni.Visible = False
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(693, 321)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaFin.TabIndex = 71
        Me.DtFechaFin.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(653, 325)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(44, 13)
        Me.Label32.TabIndex = 70
        Me.Label32.Text = "Hasta : "
        Me.Label32.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(643, 290)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 13)
        Me.Label35.TabIndex = 69
        Me.Label35.Text = "Desde :"
        Me.Label35.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 115)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "check= se puede facturar ese mes pero no se hizo cierre de stock ese mes"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(411, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 210)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "sin check= no se puede facturar ese mes pero si ese mes es menor a la fecha actua" &
    "l significa q ya se hiso un cierre de stock de ese mes"
        '
        'FrmCierreDeMes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 379)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtFechaIni)
        Me.Controls.Add(Me.DtFechaFin)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DtAño)
        Me.Controls.Add(Me.GrpCierre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCierreDeMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre De Mes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCierre.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim HabiEvent As Boolean
    Dim TableCierre As New DataTable


    Dim año As String
    Dim mes As String
    Dim rand As Integer


    Dim Todo_Cate As Int16
    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""




    Private Sub Limpiar()

        Dim ctrl As Object
        For Each ctrl In GrpCierre.Controls
            If TypeOf ctrl Is CheckBox Then
                ctrl.Checked = False
            End If
        Next
        GrpCierre.Enabled = False
        TableCierre.Rows.Clear()

    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function
    Private Sub FrmCierreDeMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Conecta("SELECT * FROM VENDEDOR WHERE CODVEND = '" & CodUsuario & "' AND CODEMPRESA = '" & codempresa & "'", "TabVend")
        ''If ds.Tables("TabVend").Rows.Count > 0 Then
        ''    ' Me.LblUsuario.Text = ds.Tables("TabVend").Rows(0)("DSVEND")
        ''Else
        ''    MsgBox("El CodUsuario no está registrado como vendedor !, se cerrará la ventana.", MsgBoxStyle.Information)
        ''    End
        ''End If


        ValorRan()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim TABLE_MESES As New DataTable
        Dim TABLE_VALIDAFINMES As New DataTable
        Dim TABLE_FECHA As New DataTable
        TABLE_FECHA = TmpListarDatos("NSP_AGRUP_FECHA  '" & codempresa & "'")
        Dim NROMESES As Integer
        NROMESES = DateDiff("m", FECHA_INV, Date.Now)

        If TABLE_FECHA.Rows.Count > 0 Then

            TABLE_VALIDAFINMES = TmpListarDatos("SELECT    PTOCIERREFINDIA   FROM CONFIGSIS     WHERE  COD_EMPRESA='" & codempresa & "'")
            If NROPTOVTA.Trim = TABLE_VALIDAFINMES.Rows(0)(0).ToString.Trim Then
                'CIERRE DE MES PARA LAS SALIDAS DE VENTAS
                Dim FechaProcesoCab, FechaProcesoDet As String
                TABLE_MESES = TmpListarDatos("NSP_LISTAR_MESES_VTA  '" & codempresa & "'")
                If TABLE_MESES.Rows.Count > 0 Then
                    For cab As Integer = 0 To TABLE_MESES.Rows.Count - 1
                        FechaProcesoCab = "VENTC" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & TABLE_MESES.Rows(cab)("MES").ToString.Trim
                        FechaProcesoDet = "VENTD" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & TABLE_MESES.Rows(cab)("MES").ToString.Trim
                        If TmpListarDatos("VERIFICA_HISTORICOVENT     '" & codempresa & "','" & FechaProcesoCab.Trim & "'  ").Rows.Count = 0 Then
                            TmpInsertDatos("CREA_TABLA_VENTAHIST    '" & codempresa & "','" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "' ")
                        End If
                        If TmpInsertDatos("INSERTAR_HISTORICO    '" & codempresa & "','" & TABLE_MESES.Rows(cab)("MES").ToString.Trim & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "'   ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ") = True Then
                            TmpInsertDatos("ELIMINAR_REG_VENTC_VENTADET   '" & TABLE_MESES.Rows(cab)("MES").ToString.Trim & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "' ")
                        End If
                    Next
                End If
                '----------------------------------------------------------------
                'CIERRE DE MES PARA MOVIMIENTOS DE ALMACEN
                '----------------------------------------------------------------
                TABLE_MESES = TmpListarDatos("NSP_LISTAR_MESES_MOV  '" & codempresa & "'")
                If TABLE_MESES.Rows.Count > 0 Then
                    For cab As Integer = 0 To TABLE_MESES.Rows.Count - 1
                        FechaProcesoCab = "MOVIC" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & TABLE_MESES.Rows(cab)("MES").ToString.Trim
                        FechaProcesoDet = "MOVID" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & TABLE_MESES.Rows(cab)("MES").ToString.Trim
                        If TmpListarDatos("VERIFICA_HISTORICOMOVI   '" & codempresa & "','" & FechaProcesoCab.Trim & "'  ").Rows.Count = 0 Then
                            TmpInsertDatos("CREA_TABLA_MOVIHIST    '" & codempresa & "','" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "' ")
                        End If
                        If TmpInsertDatos("INSERTAR_HISTORICO_MOVI    '" & codempresa & "','" & TABLE_MESES.Rows(cab)("MES").ToString.Trim & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "'   ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ") = True Then
                            TmpInsertDatos("ELIMINAR_REG_MOVICAB_MOVIDET   '" & TABLE_MESES.Rows(cab)("MES").ToString.Trim & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "' ")
                        End If
                    Next
                End If
            Else
                MsgBox("No hay datos para  realizar el Cierre de Mes....", MsgBoxStyle.Information, "NarSistemas SAC.")
            End If
            Dim FECHAPROC As DateTime
            FECHAPROC = "01/" & Month(FECHA_INV) & "/" & Year(FECHA_INV)
            For mes As Integer = 0 To NROMESES - 1
                TmpInsertDatos("NSP_RECALCULOSTOCK_MES  '" & codempresa & "','" & Format(FECHAPROC, "dd/MM/yyyy") & "'")
                FECHAPROC = FECHAPROC.AddMonths(1)
            Next

            If TmpInsertDatos("SP_CIERRE_FIN_MES  '" & codempresa & "','" & NROPTOVTA & "'") = True Then
                Dim o As New frmMensajes
                o.txtMensaje.Text = "Se finalizo con éxito el CIERRE de MES ...  "
                o.ShowDialog()
                Me.Close()
            Else
                Dim o As New frmMensajes
                o.txtMensaje.Text = "No se pudo finalizar la operacion.. "
                o.ShowDialog()
                Me.Close()
            End If

        Else
            MsgBox("ESTE PUNTO DE VENTA NO ESTA HABILITADO PARA HACER CIERRE  DE MES...", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
        End If

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        HabiEvent = False
        If CAyuda.Ejecutar("SP_INSTMP_FINMES", codempresa, CodUsuario, Format(CDate(DtAño.Value), "yyyy")) > 0 Then

            TableCierre = TmpListarDatos("SP_SELECTMP_FINMES  '" & codempresa & "','" & Format(CDate(DtAño.Value), "yyyy") & "'")
            If TableCierre.Rows.Count > 0 Then
                For i As Integer = 0 To TableCierre.Rows.Count - 1
                    Dim ctrl As Object
                    For Each ctrl In GrpCierre.Controls
                        If TypeOf ctrl Is CheckBox Then
                            If ctrl.Name = "Chk" & CInt(TableCierre.Rows(i)("MES")) Then
                                ctrl.Checked = TableCierre.Rows(i)("ACTIVO")
                            End If
                        End If
                    Next
                Next
            End If
        End If
        HabiEvent = True
        GrpCierre.Enabled = True

    End Sub

    Private Sub Chk1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk1.CheckedChanged, Chk2.CheckedChanged, Chk3.CheckedChanged, Chk4.CheckedChanged, Chk5.CheckedChanged, Chk6.CheckedChanged, Chk7.CheckedChanged, Chk8.CheckedChanged, Chk9.CheckedChanged, Chk10.CheckedChanged, Chk11.CheckedChanged, Chk12.CheckedChanged
        If HabiEvent = True Then
            Try
                CAyuda.Ejecutar("SP_UPDATETMP_FINMES", codempresa, Format(CDate(DtAño.Value), "yyyy"), CInt(Mid(CType(sender, Control).Name, 4)), CType(sender, Object).CheckState)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click

        Dim Proceso As String
        Proceso = "MODICIERREMES"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim TABLE_PROC As New DataTable
            TABLE_PROC = TmpListarDatos("SELECT DSPROCESO FROM PROCESOS WHERE CDPROCESO='" & Proceso & "' AND CODEMPRESA='" & codempresa & "'")
            Dim FrmPer As New FrmIngresaUsuClave
            If TABLE_PROC.Rows.Count = 0 Then
                FrmPer.LblProceso.Text = "NO EXISTE EL PROCESO"
            Else
                FrmPer.LblProceso.Text = CStr(TABLE_PROC.Rows(0)(0)).Trim
            End If
            FrmPer.Proceso = Proceso
            FrmPer.ShowDialog()
            If FrmPer.DEVOLVER = False Then
                Exit Sub
            End If
        End If

        If TableCierre.Rows.Count > 0 Then
            If CAyuda.Ejecutar("SP_INSFINMES", codempresa, Format(CDate(DtAño.Value), "yyyy"), Environment.MachineName) > 0 Then
                Limpiar()
                'MsgBox("SE GUARDO CORRECTAMENTE EL REGISTRO ...", MsgBoxStyle.Information, "")
            End If

            Dim SQL As String
            SQL = "DELETE_CIERRE_MES_INVENTARIO '" & Format(CDate(DtAño.Value), "yyyy") & "'"
            If TmpInsertDatos(SQL) = True Then
            End If

            SQL = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
            If TmpInsertDatos(SQL) = True Then
            End If

            Dim Table_Recorrer As New DataTable

            Table_Recorrer = CAyuda.ListarDatos("SP_RECORRER_CIERRE_MES", codempresa, Format(CDate(DtAño.Value), "yyyy")).Tables(0)

            For x As Integer = 0 To Table_Recorrer.Rows.Count - 1
                año = Table_Recorrer.Rows(x)(0).ToString
                mes = Table_Recorrer.Rows(x)(1).ToString

                Dim Table_Correlativo2 As DataTable
                Table_Correlativo2 = CAyuda.ListarDatos("SP_EXTRADIA", año, mes).Tables(0)
                DtFechaIni.Value = "01/" & mes & "/" & año
                DtFechaFin.Value = CDate(Table_Correlativo2.Rows(0)(0).ToString)

                Dim Tb_Categ1 As DataTable
                Tb_Categ1 = TmpListarDatos("SELECT  CODLINEA,DESLINEA  FROM LINEA  WHERE   CODEMPRESA='" & codempresa & "'")

                CadenaCateg = ""
                For a As Integer = 0 To Tb_Categ1.Rows.Count - 1
                    If CadenaCateg = "" Then
                        CadenaCateg = Trim(Tb_Categ1.Rows(a)("CODLINEA"))
                    Else
                        CadenaCateg = CadenaCateg & "," & Trim(Tb_Categ1.Rows(a)("CODLINEA"))
                    End If
                Next

                Todo_Cate = 0

                Dim Fechari As Date, Fecharf As Date
                Dim fecini As Date

                Dim dt As New DataTable
                Dim Fech As Date, FECHCIERRE As String

                Dim Table_Correlativo As New DataTable

                Table_Correlativo = CAyuda.ListarDatos("SP_RECORRER_ALMACENES", codempresa).Tables(0)

                If Table_Correlativo.Rows.Count > 0 Then
                    For i As Integer = 0 To Table_Correlativo.Rows.Count - 1
                        CierreIgual = False
                        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

                        dt = SelectFechCiere(Fech, False, Table_Correlativo.Rows(i)(1).ToString)
                        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
                        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
                        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

                        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
                        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
                        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

                        Procesar_Saldo(FECHCIERRE, Table_Correlativo.Rows(i)(1).ToString)
                        'If CAyuda.Ejecutar("UP_ARTIDAT", Me.txtcodarticulo.Text, Table_Correlativo.Rows(i)(0).ToString, rand) > 0 Then

                        'End If
                    Next

                    TmpInsertDatos("DELETE FROM  TMp_kardex  WHERE CORREL=" & rand)
                    TmpInsertDatos("DELETE FROM  TMP_SUMKARDEX2  WHERE CORREL=" & rand)
                    TmpInsertDatos("DELETE FROM  KARDEX_TMP  WHERE CORREL=" & rand)


                End If
            Next

        Else
            MsgBox("NO HAY DATOS A GUARDAR..", MsgBoxStyle.Exclamation, "")
        End If

        MsgBox("SE GUARDO CORRECTAMENTE EL REGISTRO ...", MsgBoxStyle.Information, "")

    End Sub



    Sub Procesar_Saldo(ByVal fechaCierre As String, ByVal CDALMACEN As String)
        Dim meses As Integer
        Dim Fecinicial, Fecfinal As String
        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String

        TmpInsertDatos("Delete from TMp_kardex WHERE CORREL =" & rand)

        If CierreIgual = True Then
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")

            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "',0,'" & rand & "'")
                End If

            Next
        Else

            meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
            ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0,'" & rand & "'")

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
                Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1,'" & rand & "'")
                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTAS '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next


            ''SELECCIONO LOS INGRESOS Y SALIDAS DEL RANGO DEL KARDEX
            MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
            MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy")

            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")


            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")
            '' SELECCIONO LAS VENTAS
            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''Registros del Histórico
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentD = "VENTD" & Anio & MesAct
                VentaC = "VENTC" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next

        End If

        'TmpInsertDatos("UPDATE TMp_kardex SET SALDOFIN=0,COMPRASF=0,INGAJUSTEF=0,INGTRANSFF=0,INGOTROSF=0,VENTASF=0,SALAJUSTEF=0,SALTRANSFF=0,SALOTROSF=0,SALDOFINF=0 WHERE SALDOFIN IS NULL AND CODEMPRESA='" & codempresa & "'")

        If CierreIgual = True Then
            INSERTCIERREALDIA(MstrFechaFinRec, CDALMACEN)
            MstrFechaIni = Format(Me.DtFechaIni.Value, "dd/MM/yyyy")
        Else
            'INSERTO SALDO INICIAL
            INSERTCIERREALDIA(fechaCierre, CDALMACEN)
        End If

        TmpInsertDatos("DELETE FROM TMP_SUMKARDEX2 WHERE CORREL = '" & rand & "'")
        TmpInsertDatos("INSERT INTO TMP_SUMKARDEX2 (CORREL,CDALMA,CDG01,CDARTI,STOCKINI,STOCKREC,COMPRAS,INGAJUSTE,INGTRANSF, INGOTROS,VENTAS,SALAJUSTE,SALTRANSF,SALOTROS,SALDOFIN, COMPRASF,INGAJUSTEF,INGTRANSFF, INGOTROSF,VENTASF,SALAJUSTEF,SALTRANSFF,SALOTROSF,SALDOFINF)" & "select  " & rand & ",cdalma,cdg01,cdarti,sum(stockini) as stockini,0 as stockrec,sum(compras)as compras, sum(INGAJUSTE) as IngAjuste,sum(INGTRANSF) as INGTransf,sum(INGOTROS) as INGotros, sum(VENTAS) as Ventas,sum(SALAJUSTE)as Salajuste,sum(SALTRANSF) as Saltransf, sum(sALOTROS) as Salotros,0 AS SALDOFIN, sum(comprasf)as comprasF,  sum(INGAJUSTEf) as IngAjusteF,sum(INGTRANSFF) as INGTransfF,sum(INGOTROSF) as INGotrosF, sum(VENTASF) as VentasF,sum(SALAJUSTEF)as SalajusteF,sum(SALTRANSFF) as SaltransfF, sum(SalotrosF) As SalotrosF ,0 AS SALDOFINF from TMp_kardex WHERE CORREL= " & rand & "  group by cdalma,cdarti,CDG01")
        TmpInsertDatos("DELETE FROM KARDEX_TMP WHERE CORREL='" & rand & "'")
        'TmpInsertDatos("INSERT INTO KARDEX_TMP (CDALMA,DSALMA,CDARTI,DSARTI,CDG01,DSG01,SALDOFIN,CANTINGRC,CANTINGRO,CANTSALIV,CANTSALIO,COSTO)  SELECT T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA , SUM(T.STOCKINI- T.VENTASF- T.SALAJUSTEF - T.SALTRANSFF - T.SALOTROSF + T.COMPRASF + T.INGAJUSTEF + T.INGTRANSFF + T.INGOTROSF) AS SALDOINIF, SUM(T.COMPRAS) AS COMPRAS,SUM(T.INGAJUSTE + T.INGTRANSF + T.INGOTROS) AS INGOTROS,SUM(T.VENTAS) AS VENTAS, SUM(T.SALAJUSTE + T.SALTRANSF + T.SALOTROS) As SALOTROS,AR.COSTOBAS FROM TMP_SUMKARDEX2 T   INNER  JOIN LINEA G ON T.CDG01 = G.CODLINEA  AND G.CODEMPRESA='" & codempresa & "' INNER JOIN  ARTICULO AR  ON T.CDARTI=AR.CODARTI  AND AR.CODEMPRESA='" & codempresa & "' INNER JOIN  ALMACEN A  ON  T.CDALMA = A.CODALMACEN  AND A.CODEMPRESA='" & codempresa & "' GROUP BY T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA,AR.COSTOBAS")
        TmpInsertDatos("SP_INS_KARDEX_TMP '" & codempresa & "','" & rand & "'")
        TmpInsertDatos("INS_CIERRE_MES_INVENTARIO '" & año & "','" & mes & "','" & rand & "'")

    End Sub
    Private Sub INSERTCIERREALDIA(ByVal FechaCierre As Date, ByVal ALMACEN As String)

        If Todo_Cate = 1 Then
            TmpInsertDatos("INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS )  " & _
                          "SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,CIERRE_MES_INVENTARIO.ARTICULO,CIERRE_MES_INVENTARIO.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0 " & _
                          "FROM CIERRE_MES_INVENTARIO,ARTICULO WHERE CIERRE_MES_INVENTARIO.ARTICULO=ARTICULO.CODARTI AND ARTICULO.FORMU = 0 AND CIERRE_MES_INVENTARIO.ALMACEN ='" & Trim(ALMACEN) & "'  AND FECHA='" & FechaCierre & "'")
        Else
            TmpInsertDatos(" INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS ) " & _
                             " SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,CIERRE_MES_INVENTARIO.ARTICULO,CIERRE_MES_INVENTARIO.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0 " & _
                             " FROM CIERRE_MES_INVENTARIO,ARTICULO WHERE  ARTICULO.FORMU = 0  AND  CIERRE_MES_INVENTARIO.ARTICULO=ARTICULO.CODARTI AND ARTICULO.CODLINEA IN(" & CadenaCateg & ")  AND CIERRE_MES_INVENTARIO.ALMACEN ='" & Trim(ALMACEN) & "'  AND FECHA='" & Format(FechaCierre, "dd/MM/yyyy") & "'")
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


    Private Function SelectFechCiere(ByVal fecha As Date, ByVal HizoCierre As Boolean, ByVal StrAlmacen As String) As DataTable

        Dim dt As New DataTable
        If HizoCierre = True Then
            'dt = TmpListarDatos("select * from resukdx where fecha='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select *  from CIERRE_MES_INVENTARIO where fecha=('" & Format(fecha, "dd/MM/yyyy") & "') AND ALMACEN ='" & StrAlmacen & "'")
        Else
            'dt = TmpListarDatos("SELECT max (fechA) AS FECHA from resukdx where fechA <= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select max (fechA) AS Fecha from CIERRE_MES_INVENTARIO where fecha <='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
        End If

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("Fecha") Is DBNull.Value Then
                'dt = TmpListarDatos("SELECT mIN (fechA) AS FECHa from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
                dt = TmpListarDatos("select mIN (fechA)  AS Fecha from CIERRE_MES_INVENTARIO where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")

            End If
        Else
            '  dt = TmpListarDatos("SELECT distinct FECHA=max(fecha) from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'   AND ALMACEN ='" & StrAlmacen & "'  group by CODARTI")

            dt = TmpListarDatos("select max(fecha)  AS Fecha from CIERRE_MES_INVENTARIO where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "' group by articulo ")

        End If

        Return dt

    End Function







    Private Sub DtAño_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtAño.ValueChanged
        Limpiar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim fechaini, fechahas As String
        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")


        If CAyuda.Ejecutar("SP_INSERT_TMP_FINMES3", codempresa, fechaini, fechahas) > 0 Then

        End If





        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Cierre_Mes.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_StoredProcParam(0, "01")
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
