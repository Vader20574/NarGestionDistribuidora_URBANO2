Public Class repv_consolidado
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
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBOPTOVTA As System.Windows.Forms.ComboBox
    Friend WithEvents CRT As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(repv_consolidado))
        Me.Label1 = New System.Windows.Forms.Label
        Me.CBOPTOVTA = New System.Windows.Forms.ComboBox
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CRT = New AxCrystal.AxCrystalReport
        Me.GroupBox2.SuspendLayout()
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(50, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Punto de Venta:"
        '
        'CBOPTOVTA
        '
        Me.CBOPTOVTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBOPTOVTA.Location = New System.Drawing.Point(154, 27)
        Me.CBOPTOVTA.Name = "CBOPTOVTA"
        Me.CBOPTOVTA.Size = New System.Drawing.Size(192, 21)
        Me.CBOPTOVTA.TabIndex = 1
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(260, 115)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(148, 25)
        Me.btncancelar.TabIndex = 12
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(103, 115)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(148, 25)
        Me.btnaceptar.TabIndex = 11
        Me.btnaceptar.Text = "&Aceptar "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfecha2)
        Me.GroupBox2.Controls.Add(Me.dtpfecha1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CBOPTOVTA)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 95)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas a Consultar"
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfecha2.Location = New System.Drawing.Point(246, 59)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(112, 21)
        Me.dtpfecha2.TabIndex = 3
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfecha1.Location = New System.Drawing.Point(70, 59)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(114, 21)
        Me.dtpfecha1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(214, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Al : "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(38, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Del : "
        '
        'CRT
        '
        Me.CRT.Enabled = True
        Me.CRT.Location = New System.Drawing.Point(135, 200)
        Me.CRT.Name = "CRT"
        Me.CRT.OcxState = CType(resources.GetObject("CRT.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CRT.Size = New System.Drawing.Size(28, 28)
        Me.CRT.TabIndex = 13
        '
        'repv_consolidado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(428, 143)
        Me.Controls.Add(Me.CRT)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(436, 177)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(436, 177)
        Me.Name = "repv_consolidado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidado"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub repv_consolidado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargadatos1()
        dtpfecha1.Value = Now.Date
        dtpfecha2.Value = Now.Date
    End Sub

    Sub cargadatos1()
        Try
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_SELE_TIENDAPTOVTA", codempresa).Tables(0)
            CBOPTOVTA.DataSource = dt
            CBOPTOVTA.DisplayMember = "NROPTOVTA"
            CBOPTOVTA.ValueMember = "CODIGO"
            CBOPTOVTA.SelectedValue = Environment.MachineName
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim FECHA1, FECHA2 As String
        FECHA1 = dtpfecha1.Value.Date
        FECHA2 = dtpfecha2.Value.Date
        Call CONSOLIDADO(FECHA1, FECHA2)
    End Sub
    Sub CONSOLIDADO(ByVal FECHA1 As String, ByVal FECHA2 As String)
        If CDate(FECHA1) > CDate(FECHA2) Then
            MessageBox.Show("Rango de Fechas Incorrecta", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim fecini As String
        Dim mesact, anio, TABLAD, TABLAC As String
        Dim i As Integer
        Dim meses As Integer
        Dim ds As New DataSet
        Dim SQL, F1, F2, FM As String
        F1 = Format(CDate(FECHA1), "dd/MM/yyyy")
        F2 = Format(CDate(FECHA2), "dd/MM/yyyy")
        SQL = "SP_ELIMINAYCREA_TMP_COMPARATIVOVENTAS"
        TmpInsertDatos(SQL)
        fecini = FECHA1
        meses = Val(DateDiff(DateInterval.Month, CDate(fecini), CDate(FECHA2)))

        Dim FILTRO As String
        FILTRO = CBOPTOVTA.Text


        TmpInsertDatos(SQL)

        For i = 0 To meses
            mesact = Format(DateAdd("m", i, fecini), "MM")
            anio = Format(DateAdd("m", i, fecini), "yyyy")
            'Nombre de las tablas a Consultar
            TABLAD = "VENTD" & anio & mesact
            TABLAC = "VENTC" & anio & mesact
            FM = "01/" & mesact & "/" & anio
            Try
                'PASO ACUMULADOS DE INFORMACION PASADA (IMPORTEMOS DATA)

                ds = TmpListarDataset("VERIFICA_HISTORICOVENT '" & TABLAC & "','" & codempresa & "'")

                ' paso diarios
                SQL = "INSERT TMP_COMPARATIVOVENTAS(CODPRODUCTO,PRODUCTO,MES,AÑO,VENTAS,FECHAMES,PTOVENTA,DESPTOVTA) " & _
                                " SELECT  L.CODLINEA,L.DESLINEA,'" & MES(mesact) & "','" & anio & "',SUM(cantidad),'" & FM & "',NROPTOVTA,NROPTOVTA FROM VENTADET VD ,ARTICULO A, LINEA L" & "  WHERE VD.CODARTI=A.CODARTI AND A.CODLINEA=L.CODLINEA " & _
                        " AND  VD.NROPTOVTA in ('" & FILTRO & "') and datepart(mm,FECPROCESO)=" & mesact & " and datepart(yyyy,FECPROCESO)=" & anio & " GROUP BY NROPTOVTA,L.CODLINEA,L.DESLINEA "


                If ds.Tables(0).Rows.Count > 0 Then

                    'PASO ACUMULADOS DE HISTORICOS

                    SQL = "INSERT TMP_COMPARATIVOVENTAS(CODPRODUCTO,PRODUCTO,MES,AÑO,VENTAS,FECHAMES,PTOVENTA,DESPTOVTA) " & _
                            " SELECT  L.CODLINEA,L.DESLINEA,'" & MES(mesact) & "','" & anio & "',SUM(cantidad),'" & FM & "',NROPTOVTA,NROPTOVTA FROM " & TABLAD & " VD ,ARTICULO A, LINEA L" & "  WHERE VD.CODARTI=A.CODARTI AND A.CODLINEA=L.CODLINEA AND " & _
                            " VD.NROPTOVTA in ('" & FILTRO & "') and datepart(mm,FECPROCESO)=" & mesact & " and datepart(yyyy,FECPROCESO)=" & anio & " GROUP BY NROPTOVTA,L.CODLINEA,L.DESLINEA "
                    TmpInsertDatos(SQL)

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'Debug.WriteLine(TABLAC) : Debug.WriteLine(TABLAD)
        Next
        Call imprimereport()
    End Sub
    Sub imprimereport()
        Try
            With CRT
                .WindowShowExportBtn = True
                .WindowShowPrintBtn = True
                .WindowShowPrintSetupBtn = True
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(5, "Usuario='" & DesUsuario & "'")
                .ReportFileName = rutareporte + CType("CONSOLIDADO.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
        End Try
    End Sub
    Function MES(ByVal NUMMES As String) As String
        MES = ""
        Select Case NUMMES
            Case Is = "01"
                MES = "ENERO"
            Case Is = "02"
                MES = "FEBRERO"
            Case Is = "03"
                MES = "MARZO"
            Case Is = "04"
                MES = "ABRIL"
            Case Is = "05"
                MES = "MAYO"
            Case Is = "06"
                MES = "JUNIO"
            Case Is = "07"
                MES = "JULIO"
            Case Is = "08"
                MES = "AGOSTO"
            Case Is = "09"
                MES = "SEPTIEMBRE"
            Case Is = "10"
                MES = "OCTUBRE"
            Case Is = "11"
                MES = "NOVIEMBRE"
            Case Is = "12"
                MES = "DICIEMBRE"
        End Select
    End Function

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class
