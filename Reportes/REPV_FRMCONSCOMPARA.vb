Public Class REPV_FRMCONSCOMPARA
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
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CRT As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(REPV_FRMCONSCOMPARA))
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CRT = New AxCrystal.AxCrystalReport
        Me.GroupBox2.SuspendLayout()
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(204, 68)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(140, 23)
        Me.btncancelar.TabIndex = 2
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(58, 68)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(140, 23)
        Me.btnaceptar.TabIndex = 1
        Me.btnaceptar.Text = "&Aceptar "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfecha2)
        Me.GroupBox2.Controls.Add(Me.dtpfecha1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 52)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas a Consultar"
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfecha2.Location = New System.Drawing.Point(234, 20)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(112, 21)
        Me.dtpfecha2.TabIndex = 2
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpfecha1.Location = New System.Drawing.Point(71, 20)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(112, 21)
        Me.dtpfecha1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Al : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del : "
        '
        'CRT
        '
        Me.CRT.Enabled = True
        Me.CRT.Location = New System.Drawing.Point(14, 131)
        Me.CRT.Name = "CRT"
        Me.CRT.OcxState = CType(resources.GetObject("CRT.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CRT.Size = New System.Drawing.Size(28, 28)
        Me.CRT.TabIndex = 13
        '
        'REPV_FRMCONSCOMPARA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(410, 94)
        Me.Controls.Add(Me.CRT)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(416, 137)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(416, 123)
        Me.Name = "REPV_FRMCONSCOMPARA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidado Comparativo por Año"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Dim FECHA1, FECHA2 As String
        FECHA1 = dtpfecha1.Value.Date
        FECHA2 = dtpfecha2.Value.Date
        TmpInsertDatos("SP_ELIMINARYCREA_TMP_ACUMULADOVENTAS")
        CONSOLIDADOCOMPARATIVO(FECHA1, FECHA2)
    End Sub
    Sub CONSOLIDADOCOMPARATIVO(ByVal FECHA1 As String, ByVal FECHA2 As String)
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
        SQL = "sp_eliminaycrea_TMP_CONSOLIDADOXPRODUCTO"
        TmpInsertDatos(SQL)
        fecini = FECHA1
        meses = Val(DateDiff(DateInterval.Month, CDate(fecini), CDate(FECHA2)))
        mesact = Format(DateAdd("m", i, fecini), "MM")
        anio = Format(DateAdd("m", i, fecini), "yyyy")



        For i = 0 To meses
            mesact = Format(DateAdd("m", i, fecini), "MM")
            anio = Format(DateAdd("m", i, fecini), "yyyy")
            'Nombre de las tablas a Consultar
            TABLAD = "VENTD" & anio & mesact
            TABLAC = "VENTC" & anio & mesact
            FM = "01/" & mesact & "/" & anio
            Try


                'and datepart(mm,FECPROCESO)=" & mesact & " and datepart(yyyy,FECPROCESO)=" & anio & "
                'PASO ACUMULADOS DE INFORMACION PASADA (IMPORTEMOS DATA)
                SQL = "INSERT TMP_ACUMULADOVENTAS(MES,AÑO,VENTAS,FECHAMES) " & _
                " SELECT MES,AÑO,VENTAS,'" & FM & "' FROM ACUMULADOVENTAS WHERE MES= '" & MES(mesact) & "' AND AÑO='" & anio & "'"
                TmpInsertDatos(SQL)


                ds = TmpListarDataset("VERIFICA_HISTORICOVENT '" & TABLAC & "','" & codempresa & "'")
                If ds.Tables(0).Rows.Count > 0 Then

                    'PASO ACUMULADOS DE HISTORICOS
                    SQL = "INSERT TMP_ACUMULADOVENTAS(MES,AÑO,VENTAS,FECHAMES) " & _
                    " SELECT '" & MES(mesact) & "','" & anio & "',SUM(TOTBAS),'" & FM & "' FROM " & TABLAC & " where DatePart(mm, FECPROCESO) = " & mesact & "  And DatePart(yyyy, FECPROCESO) = " & anio & ""
                    'WHERE FECPROCESO BETWEEN '" & F1 & "' AND '" & F2 & "'"
                    TmpInsertDatos(SQL)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Debug.WriteLine(TABLAC) : Debug.WriteLine(TABLAD)
        Next
        Call imprimereport()
    End Sub
    Sub imprimereport()
        Try
            With CRT
                .WindowShowExportBtn = True
                .WindowShowPrintBtn = True
                .WindowShowPrintSetupBtn = True
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(6, "Usuario='" & DesUsuario & "'")
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .ReportFileName = rutareporte + CType("RPTCOMPARAVENTA.rpt", String)
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
