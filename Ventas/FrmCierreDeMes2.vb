Public Class FrmCierreDeMes2
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Chk7 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCierreDeMes2))
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
        Me.GrpCierre.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(98, 35)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(148, 39)
        Me.BtnAceptar.TabIndex = 49
        Me.BtnAceptar.Text = "Iniciar Cierre de Dia"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(334, 22)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "CIERRE DE DIA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 37)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(445, 35)
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
        Me.BtnSalir.Location = New System.Drawing.Point(445, 64)
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
        Me.Button2.Location = New System.Drawing.Point(571, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 70)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCierreDeMes2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(334, 132)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DtAño)
        Me.Controls.Add(Me.GrpCierre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCierreDeMes2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre De Dia"
        Me.GrpCierre.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim HabiEvent As Boolean
    Dim TableCierre As New DataTable


    Private FrmCMes4 As FrmCierreDeMes2


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
        ''Conecta("SELECT * FROM VENDEDOR WHERE CODVEND = '" & CodUsuario & "' AND CODEMPRESA = '" & codempresa & "'", "TabVend")
        ''If ds.Tables("TabVend").Rows.Count > 0 Then
        ''    ' Me.LblUsuario.Text = ds.Tables("TabVend").Rows(0)("DSVEND")
        ''Else
        ''    MsgBox("El CodUsuario no está registrado como vendedor !, se cerrará la ventana.", MsgBoxStyle.Information)
        ''    End
        ''End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click


        Dim TABLE_GUIACT As New DataTable
        TABLE_GUIACT = TmpListarDatos("SP_VERIFICAR_GUIACTUALIZADO  '" & codempresa & "'")
        If TABLE_GUIACT.Rows.Count > 0 Then
            MsgBox("TIENE Q GENERAR O ACTUALIZAR LAS ORDENES DE DESPACHO Q FALTAN PARA HACER EL CIERRE!!!...")
            Exit Sub
        End If



        If CAyuda.Ejecutar("SP_LIMPIAR_TABLAS", codempresa) > 0 Then
        End If

        Dim TABLE_MESES As New DataTable
        Dim TABLE_VALIDAFINMES As New DataTable
        Dim TABLE_FECHA As New DataTable
        TABLE_FECHA = TmpListarDatos("NSP_AGRUP_FECHA  '" & codempresa & "'")
        Dim NROMESES As Integer
        NROMESES = DateDiff("m", FECHA_INV, Date.Now)

        If TABLE_FECHA.Rows.Count > 0 Then

            TABLE_VALIDAFINMES = TmpListarDatos("SELECT    UPPER(PTOCIERREFINDIA)   FROM CONFIGSIS     WHERE  COD_EMPRESA='" & codempresa & "'")
            If Environment.MachineName = TABLE_VALIDAFINMES.Rows(0)(0).ToString.Trim Then
                'CIERRE DE MES PARA LAS SALIDAS DE VENTAS

                Dim FechaProcesoCab, FechaProcesoDet As String
                TABLE_MESES = TmpListarDatos("NSP_LISTAR_MESES_VTA  '" & codempresa & "'")
                If TABLE_MESES.Rows.Count > 0 Then
                    For cab As Integer = 0 To TABLE_MESES.Rows.Count - 1

                        Dim MES As String
                        MES = "00" & TABLE_MESES.Rows(cab)("MES").ToString.Trim
                        MES = Mid(MES, MES.Length - 1)

                        FechaProcesoCab = "VENTC" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & MES
                        FechaProcesoDet = "VENTD" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & MES
                        If TmpListarDatos("VERIFICA_HISTORICOVENT     '" & FechaProcesoCab.Trim & "','" & codempresa.Trim & "'  ").Rows.Count = 0 Then
                            TmpInsertDatos("CREA_TABLA_VENTAHIST    '" & codempresa & "','" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "' ")
                        End If
                        If TmpInsertDatos("INSERTAR_HISTORICO    '" & codempresa & "','" & MES & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "'   ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ") = True Then
                            TmpInsertDatos("ELIMINAR_REG_VENTC_VENTADET   '" & codempresa & "','" & MES & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "'")
                        End If
                    Next
                End If
                '----------------------------------------------------------------
                'CIERRE DE MES PARA MOVIMIENTOS DE ALMACEN
                '----------------------------------------------------------------
                TABLE_MESES = TmpListarDatos("NSP_LISTAR_MESES_MOV  '" & codempresa & "'")
                If TABLE_MESES.Rows.Count > 0 Then
                    For cab As Integer = 0 To TABLE_MESES.Rows.Count - 1

                        Dim MES As String
                        MES = "00" & TABLE_MESES.Rows(cab)("MES").ToString.Trim
                        MES = Mid(MES, MES.Length - 1)

                        FechaProcesoCab = "MOVIC" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & MES
                        FechaProcesoDet = "MOVID" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & MES
                        If TmpListarDatos("VERIFICA_HISTORICOMOVI   '" & codempresa & "','" & FechaProcesoCab.Trim & "'  ").Rows.Count = 0 Then
                            TmpInsertDatos("CREA_TABLA_MOVIHIST    '" & codempresa & "','" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "' ")
                        End If
                        If TmpInsertDatos("INSERTAR_HISTORICO_MOVI    '" & codempresa & "','" & MES & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "'   ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ") = True Then
                            TmpInsertDatos("ELIMINAR_REG_MOVICAB_MOVIDET   '" & codempresa & "','" & MES & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "' ")
                        End If
                    Next
                End If
                '----------------------------------------------------------------
                'CIERRE DE MES PARA GUIAINTERNA 
                '----------------------------------------------------------------
                TABLE_MESES = TmpListarDatos("NSP_LISTAR_MESES_GUIA  '" & codempresa & "'")
                If TABLE_MESES.Rows.Count > 0 Then
                    For cab As Integer = 0 To TABLE_MESES.Rows.Count - 1

                        Dim MES As String
                        MES = "00" & TABLE_MESES.Rows(cab)("MES").ToString.Trim
                        MES = Mid(MES, MES.Length - 1)

                        FechaProcesoCab = "GUIAC" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & MES
                        FechaProcesoDet = "GUIAD" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & MES
                        If TmpListarDatos("VERIFICA_HISTOGUIAINTERNA   '" & codempresa & "','" & FechaProcesoCab.Trim & "'  ").Rows.Count = 0 Then
                            TmpInsertDatos("CREA_TABLA_GUIAHIST    '" & codempresa & "','" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "' ")
                        End If
                        If TmpInsertDatos("INSERTAR_HISTORICO_GUIA    '" & codempresa & "','" & MES & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "'   ,'" & FechaProcesoCab.Trim & "','" & FechaProcesoDet.Trim & "'  ") = True Then
                            TmpInsertDatos("ELIMINAR_REG_GUIAINTERNACAB_GUIAINTERNADET   '" & codempresa & "','" & MES & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "' ")
                        End If
                    Next
                End If

                '----------------------------------------------------------------
                'CIERRE DE VENTA POR COBRAR
                '----------------------------------------------------------------
                TABLE_MESES = TmpListarDatos("NSP_LISTAR_ANUAL_VENTAXCOBRAR  '" & codempresa & "'")
                If TABLE_MESES.Rows.Count > 0 Then
                    For cab As Integer = 0 To TABLE_MESES.Rows.Count - 1
                        FechaProcesoCab = "VTAXCOBRAR" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim
                        If TmpListarDatos("VERIFICA_HISTOVENTAXCOBRARS   '" & codempresa & "','" & FechaProcesoCab.Trim & "'").Rows.Count = 0 Then
                            TmpInsertDatos("CREA_TABLA_VENTAXCOBRARHIST    '" & codempresa & "','" & FechaProcesoCab.Trim & "'")
                        End If
                        If TmpInsertDatos("INSERTAR_HISTORICO_VTAXCOBRAR    '" & codempresa & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "','" & FechaProcesoCab.Trim & "'") = True Then
                            TmpInsertDatos("ELIMINAR_REG_VENTAXCOBRAR   '" & codempresa & "','" & TABLE_MESES.Rows(cab)("AÑO").ToString.Trim & "' ")
                        End If
                    Next
                End If

                MsgBox("SE HIZO EL CIERRE CON EXITO...", MsgBoxStyle.Information, "NARSISTEMAS S.A.C.")

            Else
                MsgBox("Este punto venta no esta configurado para cierre de dia....", MsgBoxStyle.Information, "NarSistemas SAC.")
            End If

        Else
            MsgBox("NO TIENE DATA PARA HACER EL CIERRE...", MsgBoxStyle.Exclamation, "NARSISTEMAS S.A.C.")
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
        GrpCierre.Enabled = False

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
        If TableCierre.Rows.Count > 0 Then
            If CAyuda.Ejecutar("SP_INSFINMES", codempresa, Format(CDate(DtAño.Value), "yyyy")) > 0 Then
                Limpiar()
                MsgBox("SE GUARDO CORRECTAMENTE EL REGISTRO ...", MsgBoxStyle.Information, "")
            End If
        Else
            MsgBox("NO HAY DATOS A GUARDAR..", MsgBoxStyle.Exclamation, "")
        End If
    End Sub

    Private Sub DtAño_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtAño.ValueChanged
        Limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim TABLE_MESES As DataTable

        Dim TABLE_DOCS As DataTable


        Dim NOMBRETABLA As String

        Dim AÑO As String
        Dim TABLA As String

        TABLE_MESES = TmpListarDatos("SP_SELECT_HISTOVENTAS2  '" & codempresa & "'")
        If TABLE_MESES.Rows.Count > 0 Then
            For cab As Integer = 0 To TABLE_MESES.Rows.Count - 1
                NOMBRETABLA = TABLE_MESES.Rows(cab)("VENTCAB").ToString.Trim
                'AÑO = TABLE_MESES.Rows(cab)("año").ToString.Trim
                TABLE_DOCS = TmpListarDatos("SP_SELECT_tabla  '" & NOMBRETABLA & "'")

                If CAyuda.Ejecutar("UPDATE_VTAXCOBRAR", "01") > 0 Then
                End If
                'TABLA = "VTAXCOBRAR" & AÑO
                'For X As Integer = 0 To TABLE_DOCS.Rows.Count - 1
                '    If CAyuda.Ejecutar("sp_update_ventaxcobrar_2", TABLE_DOCS.Rows(X)("nrodocu").ToString.Trim, TABLE_DOCS.Rows(X)("codtipodoc").ToString.Trim, TABLE_DOCS.Rows(X)("codvend").ToString.Trim, 1, TABLA) > 0 Then
                '    End If
                'Next
            Next
        End If






    End Sub
End Class
