Public Class REPV_FRMCONSOLIDADXPROD
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
    Friend WithEvents CRT As AxCrystal.AxCrystalReport
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstalma1 As System.Windows.Forms.ListBox
    Friend WithEvents lstalma2 As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lstcod2 As System.Windows.Forms.ListBox
    Friend WithEvents lstcod1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REPV_FRMCONSOLIDADXPROD))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lstalma2 = New System.Windows.Forms.ListBox
        Me.lstalma1 = New System.Windows.Forms.ListBox
        Me.CRT = New AxCrystal.AxCrystalReport
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpfecha2 = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstcod2 = New System.Windows.Forms.ListBox
        Me.lstcod1 = New System.Windows.Forms.ListBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lstalma2)
        Me.GroupBox1.Controls.Add(Me.lstalma1)
        Me.GroupBox1.Controls.Add(Me.CRT)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 286)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Almacen"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(306, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = ">"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(306, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "<<"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(306, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = ">>"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(306, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "<"
        '
        'lstalma2
        '
        Me.lstalma2.HorizontalScrollbar = True
        Me.lstalma2.Location = New System.Drawing.Point(371, 21)
        Me.lstalma2.Name = "lstalma2"
        Me.lstalma2.ScrollAlwaysVisible = True
        Me.lstalma2.Size = New System.Drawing.Size(274, 251)
        Me.lstalma2.TabIndex = 12
        '
        'lstalma1
        '
        Me.lstalma1.HorizontalScrollbar = True
        Me.lstalma1.Location = New System.Drawing.Point(13, 20)
        Me.lstalma1.Name = "lstalma1"
        Me.lstalma1.ScrollAlwaysVisible = True
        Me.lstalma1.Size = New System.Drawing.Size(279, 251)
        Me.lstalma1.TabIndex = 11
        '
        'CRT
        '
        Me.CRT.Enabled = True
        Me.CRT.Location = New System.Drawing.Point(186, 2)
        Me.CRT.Name = "CRT"
        Me.CRT.OcxState = CType(resources.GetObject("CRT.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CRT.Size = New System.Drawing.Size(28, 28)
        Me.CRT.TabIndex = 10
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(518, 313)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(143, 25)
        Me.btncancelar.TabIndex = 9
        Me.btncancelar.Text = "&Cancelar"
        '
        'btnaceptar
        '
        Me.btnaceptar.Location = New System.Drawing.Point(359, 313)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(143, 25)
        Me.btnaceptar.TabIndex = 8
        Me.btnaceptar.Text = "&Aceptar "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpfecha2)
        Me.GroupBox2.Controls.Add(Me.dtpfecha1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 51)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas a Consultar"
        '
        'dtpfecha2
        '
        Me.dtpfecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha2.Location = New System.Drawing.Point(197, 21)
        Me.dtpfecha2.Name = "dtpfecha2"
        Me.dtpfecha2.Size = New System.Drawing.Size(95, 21)
        Me.dtpfecha2.TabIndex = 3
        '
        'dtpfecha1
        '
        Me.dtpfecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha1.Location = New System.Drawing.Point(49, 21)
        Me.dtpfecha1.Name = "dtpfecha1"
        Me.dtpfecha1.Size = New System.Drawing.Size(101, 21)
        Me.dtpfecha1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Al : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del : "
        '
        'lstcod2
        '
        Me.lstcod2.Location = New System.Drawing.Point(35, 145)
        Me.lstcod2.Name = "lstcod2"
        Me.lstcod2.Size = New System.Drawing.Size(116, 30)
        Me.lstcod2.TabIndex = 14
        '
        'lstcod1
        '
        Me.lstcod1.Location = New System.Drawing.Point(35, 47)
        Me.lstcod1.Name = "lstcod1"
        Me.lstcod1.Size = New System.Drawing.Size(116, 43)
        Me.lstcod1.TabIndex = 13
        '
        'REPV_FRMCONSOLIDADXPROD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(693, 350)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstcod2)
        Me.Controls.Add(Me.lstcod1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "REPV_FRMCONSOLIDADXPROD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Consolidado por Producto "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.CRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub REPV_FRMCONSOLIDADXPROD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call cargadatos1()
        dtpfecha1.Value = Now.Date
        dtpfecha2.Value = Now.Date
    End Sub
    Sub cargadatos1()
        lstalma1.Items.Clear()
        lstcod1.Items.Clear()
        lstalma2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("sp_almacenesdes '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstalma1.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("sp_almacenescod  '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod1.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
            lstalma2.Items.Clear()
            lstcod2.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Sub cargadatos2()
        lstalma1.Items.Clear()
        lstcod1.Items.Clear()
        lstalma2.Items.Clear()
        lstcod2.Items.Clear()
        Try
            Dim ds As New DataSet, i As Int32
            ds = TmpListarDataset("sp_almacenesdes '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstalma2.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
            ds.Dispose()
            ds = TmpListarDataset("sp_almacenescod '" & codempresa & "'")
            For i = 0 To ds.Tables(0).Rows.Count - 1
                lstcod2.Items.Add(Trim(ds.Tables(0).Rows(i)(0)))
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click, lstalma1.DoubleClick
        Try
            If lstalma1.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Almacen", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            lstalma2.Items.Add(lstalma1.Items(lstalma1.SelectedIndex))
            lstcod2.Items.Add(lstcod1.Items(lstalma1.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstalma1.SelectedIndex
            lstalma1.Items.RemoveAt(removeitem)
            lstcod1.Items.RemoveAt(removeitem)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstalma2.DoubleClick, Button1.Click
        Try
            If lstalma2.SelectedIndex = -1 Then
                MessageBox.Show("Selecione un Almacen", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            lstalma1.Items.Add(lstalma2.Items(lstalma2.SelectedIndex))
            lstcod1.Items.Add(lstcod2.Items(lstalma2.SelectedIndex))
            Dim removeitem As Integer
            removeitem = lstalma2.SelectedIndex
            lstalma2.Items.RemoveAt(removeitem)
            lstcod2.Items.RemoveAt(removeitem)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cargadatos2()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cargadatos1()
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If lstalma2.Items.Count = 0 Then
            MessageBox.Show("Selecione un Almacen para realizar el reporte", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim FECHA1, FECHA2 As String
        FECHA1 = dtpfecha1.Value.Date
        FECHA2 = dtpfecha2.Value.Date
        Call CONSOLIDADOXPRODUCTO(FECHA1, FECHA2)
    End Sub
    Sub CONSOLIDADOXPRODUCTO(ByVal FECHA1 As String, ByVal FECHA2 As String)
        If CDate(FECHA1) > CDate(FECHA2) Then
            MessageBox.Show("Rango de Fechas Incorrecta", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        Dim fecini As String
        Dim mesact, anio, TABLAD, TABLAC As String
        Dim i As Integer
        Dim meses As Integer
        Dim ds As New DataSet
        Dim SQL, F1, F2 As String
        F1 = Format(CDate(FECHA1), "dd/MM/yyyy")
        F2 = Format(CDate(FECHA2), "dd/MM/yyyy")
        SQL = "sp_eliminaycrea_TMP_CONSOLIDADOXPRODUCTO"
        TmpInsertDatos(SQL)
        fecini = FECHA1
        meses = Val(DateDiff(DateInterval.Month, CDate(fecini), CDate(FECHA2)))
        Dim FILTRO As String = ""
        For i = 0 To lstcod2.Items.Count - 1
            If i = lstcod2.Items.Count - 1 Then
                FILTRO = FILTRO + "'" & lstcod2.Items(i) & "'"
            Else
                FILTRO = FILTRO + "'" & lstcod2.Items(i) & "',"
            End If
        Next
        Debug.WriteLine(FILTRO)
        SQL = " INSERT TMP_CONSOLIDADOXPRODUCTO (PRODUCTO,ALMACEN,TOTAL,fechade,fechahasta ) " & _
                          " SELECT L.DESLINEA AS PRODUCTO,AL.DESALMACEN,SUM(SUBTOTBAS) AS TOTAL,'" & F1 & "','" & F2 & "' from  ventadet VD,ARTICULO A,LINEA L, ALMACEN AL WHERE " & _
                          " VD.CODARTI=A.CODARTI AND " & _
                          " A.CODLINEA=L.CODLINEA AND " & _
                          " AL.CODALMACEN=VD.CODALMACEN and vd.codalmacen in (" & FILTRO & ") " & _
                          " AND FECPROCESO BETWEEN '" & F1 & "' AND '" & F2 & "' GROUP BY  L.DESLINEA,AL.DESALMACEN "
        TmpInsertDatos(SQL)
        For i = 0 To meses
            mesact = Format(DateAdd("m", i, fecini), "MM")
            anio = Format(DateAdd("m", i, fecini), "yyyy")
            'Nombre de las tablas a Consultar
            TABLAD = "VENTD" & anio & mesact
            TABLAC = "VENTC" & anio & mesact
            Try
                ds = TmpListarDataset("VERIFICA_HISTORICOVENT '" & TABLAC & "','" & codempresa & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    SQL = " INSERT TMP_CONSOLIDADOXPRODUCTO (PRODUCTO,ALMACEN,TOTAL,fechade,fechahasta ) " & _
                          " SELECT L.DESLINEA AS PRODUCTO,AL.DESALMACEN,SUM(SUBTOTBAS) AS TOTAL,'" & F1 & "','" & F2 & "' from  " & TABLAD & " VD,ARTICULO A,LINEA L, ALMACEN AL WHERE " & _
                          " VD.CODARTI=A.CODARTI AND " & _
                            " A.CODLINEA=L.CODLINEA AND " & _
                          " AL.CODALMACEN=VD.CODALMACEN and vd.codalmacen in (" & FILTRO & ") " & _
                          " AND FECPROCESO BETWEEN '" & F1 & "' AND '" & F2 & "' GROUP BY  L.DESLINEA,AL.DESALMACEN "
                    TmpInsertDatos(SQL)
                End If
            Catch ex As Exception
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
                .set_Formulas(4, "Usuario='" & DesUsuario & "'")
                .ReportFileName = rutareporte + CType("RPTCONSOLIDADOXPRODUCTO.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class
