Public Class FrmCierreDeMesInv2
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
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
    Friend WithEvents DtFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Chk7 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCierreDeMesInv2))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Chk1 = New System.Windows.Forms.CheckBox
        Me.GrpCierre = New System.Windows.Forms.GroupBox
        Me.Chk2 = New System.Windows.Forms.CheckBox
        Me.Chk3 = New System.Windows.Forms.CheckBox
        Me.Chk4 = New System.Windows.Forms.CheckBox
        Me.Chk5 = New System.Windows.Forms.CheckBox
        Me.Chk6 = New System.Windows.Forms.CheckBox
        Me.Chk7 = New System.Windows.Forms.CheckBox
        Me.Chk8 = New System.Windows.Forms.CheckBox
        Me.Chk10 = New System.Windows.Forms.CheckBox
        Me.Chk11 = New System.Windows.Forms.CheckBox
        Me.Chk12 = New System.Windows.Forms.CheckBox
        Me.Chk9 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DtAño = New System.Windows.Forms.DateTimePicker
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DtFechaIni = New System.Windows.Forms.DateTimePicker
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCierre.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(641, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 136)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Con este formulario  se cerrara las ventas y las compras del mes."
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(734, 322)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(830, 59)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(147, 44)
        Me.BtnAceptar.TabIndex = 49
        Me.BtnAceptar.Text = "Iniciar Cierre de Mes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(830, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 44)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Cancelar"
        '
        'Chk1
        '
        Me.Chk1.Location = New System.Drawing.Point(12, 14)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(125, 28)
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
        Me.GrpCierre.Location = New System.Drawing.Point(706, 200)
        Me.GrpCierre.Name = "GrpCierre"
        Me.GrpCierre.Size = New System.Drawing.Size(439, 136)
        Me.GrpCierre.TabIndex = 57
        Me.GrpCierre.TabStop = False
        '
        'Chk2
        '
        Me.Chk2.Location = New System.Drawing.Point(12, 44)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(125, 28)
        Me.Chk2.TabIndex = 68
        Me.Chk2.Text = "Febrero"
        '
        'Chk3
        '
        Me.Chk3.Location = New System.Drawing.Point(12, 74)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(125, 28)
        Me.Chk3.TabIndex = 67
        Me.Chk3.Text = "Marzo"
        '
        'Chk4
        '
        Me.Chk4.Location = New System.Drawing.Point(12, 102)
        Me.Chk4.Name = "Chk4"
        Me.Chk4.Size = New System.Drawing.Size(125, 27)
        Me.Chk4.TabIndex = 66
        Me.Chk4.Text = "Abrir"
        '
        'Chk5
        '
        Me.Chk5.Location = New System.Drawing.Point(161, 16)
        Me.Chk5.Name = "Chk5"
        Me.Chk5.Size = New System.Drawing.Size(125, 28)
        Me.Chk5.TabIndex = 65
        Me.Chk5.Text = "Mayo"
        '
        'Chk6
        '
        Me.Chk6.Location = New System.Drawing.Point(161, 44)
        Me.Chk6.Name = "Chk6"
        Me.Chk6.Size = New System.Drawing.Size(125, 28)
        Me.Chk6.TabIndex = 64
        Me.Chk6.Text = "Junio"
        '
        'Chk7
        '
        Me.Chk7.Location = New System.Drawing.Point(161, 72)
        Me.Chk7.Name = "Chk7"
        Me.Chk7.Size = New System.Drawing.Size(125, 27)
        Me.Chk7.TabIndex = 63
        Me.Chk7.Text = "Julio"
        '
        'Chk8
        '
        Me.Chk8.Location = New System.Drawing.Point(161, 102)
        Me.Chk8.Name = "Chk8"
        Me.Chk8.Size = New System.Drawing.Size(125, 27)
        Me.Chk8.TabIndex = 62
        Me.Chk8.Text = "Agosto"
        '
        'Chk10
        '
        Me.Chk10.Location = New System.Drawing.Point(305, 44)
        Me.Chk10.Name = "Chk10"
        Me.Chk10.Size = New System.Drawing.Size(125, 28)
        Me.Chk10.TabIndex = 60
        Me.Chk10.Text = "Octubre"
        '
        'Chk11
        '
        Me.Chk11.Location = New System.Drawing.Point(305, 74)
        Me.Chk11.Name = "Chk11"
        Me.Chk11.Size = New System.Drawing.Size(125, 28)
        Me.Chk11.TabIndex = 59
        Me.Chk11.Text = "Noviembre"
        '
        'Chk12
        '
        Me.Chk12.Location = New System.Drawing.Point(305, 102)
        Me.Chk12.Name = "Chk12"
        Me.Chk12.Size = New System.Drawing.Size(125, 27)
        Me.Chk12.TabIndex = 57
        Me.Chk12.Text = "Diciembre"
        '
        'Chk9
        '
        Me.Chk9.Location = New System.Drawing.Point(305, 16)
        Me.Chk9.Name = "Chk9"
        Me.Chk9.Size = New System.Drawing.Size(125, 28)
        Me.Chk9.TabIndex = 61
        Me.Chk9.Text = "Septiembre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(744, 465)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Año:"
        '
        'DtAño
        '
        Me.DtAño.CustomFormat = "yyyy"
        Me.DtAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtAño.Location = New System.Drawing.Point(787, 460)
        Me.DtAño.Name = "DtAño"
        Me.DtAño.ShowUpDown = True
        Me.DtAño.Size = New System.Drawing.Size(79, 22)
        Me.DtAño.TabIndex = 60
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscar.ImageIndex = 5
        Me.BtnBuscar.ImageList = Me.ImageList1
        Me.BtnBuscar.Location = New System.Drawing.Point(878, 460)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(142, 27)
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
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.ImageIndex = 12
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(647, 180)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(132, 27)
        Me.BtnSalir.TabIndex = 63
        Me.BtnSalir.Text = "Salir"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DtFechaIni
        '
        Me.DtFechaIni.Enabled = False
        Me.DtFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaIni.Location = New System.Drawing.Point(223, 142)
        Me.DtFechaIni.Name = "DtFechaIni"
        Me.DtFechaIni.Size = New System.Drawing.Size(120, 23)
        Me.DtFechaIni.TabIndex = 64
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Enabled = False
        Me.DtFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(274, 222)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(120, 23)
        Me.DtFechaFin.TabIndex = 67
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Enabled = False
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(226, 226)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(57, 17)
        Me.Label32.TabIndex = 66
        Me.Label32.Text = "Hasta : "
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Enabled = False
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(170, 147)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(57, 17)
        Me.Label35.TabIndex = 65
        Me.Label35.Text = "Desde :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(111, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(283, 72)
        Me.Button2.TabIndex = 68
        Me.Button2.Text = "ACTUALIZAR STOCK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCierreDeMesInv2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(515, 220)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DtFechaIni)
        Me.Controls.Add(Me.DtFechaFin)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DtAño)
        Me.Controls.Add(Me.GrpCierre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCierreDeMesInv2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Stock Artidat"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCierre.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim HabiEvent As Boolean
    Dim TableCierre As New DataTable


    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""
    Friend WithEvents ckPercepcion2 As System.Windows.Forms.CheckBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ckNPTienda As System.Windows.Forms.CheckBox
    Dim Todo_Cate As Int16

    Dim rand As Integer



    Dim año As String
    Dim mes As String


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

    Private Sub FrmCierreDeMes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Conecta("SELECT * FROM VENDEDOR WHERE CODVEND = '" & CodUsuario & "' AND CODEMPRESA = '" & codempresa & "'", "TabVend")
        'If ds.Tables("TabVend").Rows.Count > 0 Then
        '    ' Me.LblUsuario.Text = ds.Tables("TabVend").Rows(0)("DSVEND")
        'Else
        '    MsgBox("El CodUsuario no está registrado como vendedor !, se cerrará la ventana.", MsgBoxStyle.Information)
        '    End
        'End If


        DtFechaIni.Value = vFechaActual.AddDays(-1)
        DtFechaFin.Value = CType(CAyuda.ListarDatos("SP_FECHA_AUMENTO_DIAS", CANT_DIAS_ADE).Tables(0).Rows(0)(0), Date)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click









    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        HabiEvent = False
        If CAyuda.Ejecutar("SP_INSTMP_FINMESINV", codempresa, CodUsuario, Format(CDate(DtAño.Value), "yyyy")) > 0 Then

            TableCierre = TmpListarDatos("SP_SELECTMP_FINMESINV  '" & codempresa & "','" & Format(CDate(DtAño.Value), "yyyy") & "'")
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
                CAyuda.Ejecutar("SP_UPDATETMP_FINMESINV", codempresa, Format(CDate(DtAño.Value), "yyyy"), CInt(Mid(CType(sender, Control).Name, 4)), CType(sender, Object).CheckState)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim SQL As String
        SQL = "DELETE_CIERRE_MES_INVENTARIO2 '" & Format(CDate(DtAño.Value), "yyyy") & "'"
        If TmpInsertDatos(SQL) = True Then
        End If

        DtFechaIni.Value = Date.Now.AddDays(-1)
        DtFechaFin.Value = Date.Now

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
        TmpInsertDatos("INS_CIERRE_MES_INVENTARIO2 '" & año & "','" & mes & "','" & rand & "'")



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

        ValorRan()

        Dim SQL As String
        SQL = "DELETE_CIERRE_MES_INVENTARIO2 '" & Format(CDate(DtAño.Value), "yyyy") & "'"
        If TmpInsertDatos(SQL) = True Then
        End If



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

        SQL = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(SQL) = True Then
        End If


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
                ' MsgBox("SE GUARDO CORRECTAMENTE EL REGISTRO ...", MsgBoxStyle.Information, "")
            Next
        End If

        SQL = "SP_ACTUALIZAR_STOCKARTI '" & codempresa & "'"
        If TmpInsertDatos(SQL) = True Then
        End If

        TmpInsertDatos("DELETE FROM  TMp_kardex  WHERE CORREL=" & rand)
        TmpInsertDatos("DELETE FROM  TMP_SUMKARDEX2  WHERE CORREL=" & rand)
        TmpInsertDatos("DELETE FROM  KARDEX_TMP  WHERE CORREL=" & rand)



        MsgBox("SE GUARDO CORRECTAMENTE EL REGISTRO ...", MsgBoxStyle.Information, "")

    End Sub
End Class
