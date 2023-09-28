Imports System.Data.SqlClient
Imports System.Data
Public Class frmCierreInventario
    Dim fechaToma As Date
    Dim fCierreult As Date
    Dim FechaP As Date
    Dim fechacierre As Date
    Private Sub frmCierreInventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BackgroundWorker1.IsBusy Then
            MsgBox("Hay un proceso pendiente.")
            e.Cancel = True
        End If
    End Sub
    Private Sub CierreInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False

        Dim dt As New DataTable
        dt = TmpListarDatos(" SELECT CodAlmacen , DeSAlmacen, CdTipo ,Activo FROM Almacen where codempresa='" & codempresa & "' order by 2")
        Me.cmdalmacen.DataSource = dt
        Me.cmdalmacen.DisplayMember = "DeSAlmacen"
        Me.cmdalmacen.ValueMember = "CodAlmacen"

        Me.lblfechaactual.Text = Fecha_Hoy(Fecha_Actual())


        Dim meses As New List(Of MesesE)
        meses.Add(New MesesE("01", "Enero"))
        meses.Add(New MesesE("02", "Febrero"))
        meses.Add(New MesesE("03", "Marzo"))
        meses.Add(New MesesE("04", "Abril"))
        meses.Add(New MesesE("05", "Mayo"))
        meses.Add(New MesesE("06", "Junio"))
        meses.Add(New MesesE("07", "Julio"))
        meses.Add(New MesesE("08", "Agosto"))
        meses.Add(New MesesE("09", "Setiembre"))
        meses.Add(New MesesE("10", "Octubre"))
        meses.Add(New MesesE("11", "Noviembre"))
        meses.Add(New MesesE("12", "Diciembre"))


        Me.cmbmes.DataSource = meses

        FechaP = Fecha_Actual()
        Timer1.Stop()
    End Sub

    Function Fecha_Hoy(ByVal strFecha As Date) As String
        Dim strDia As String = ""
        Dim strMes As String = ""

        Select Case Weekday(strFecha)
            Case 1 : strDia = "Domingo"
            Case 2 : strDia = "Lunes"
            Case 3 : strDia = "Martes"
            Case 4 : strDia = "Miercoles"
            Case 5 : strDia = "Jueves"
            Case 6 : strDia = "Viernes"
            Case 7 : strDia = "Sábado"
        End Select

        Select Case Month(strFecha)
            Case 1 : strMes = "Enero"
            Case 2 : strMes = "Febrero"
            Case 3 : strMes = "Marzo"
            Case 4 : strMes = "Abril"
            Case 5 : strMes = "Mayo"
            Case 6 : strMes = "Junio"
            Case 7 : strMes = "Julio"
            Case 8 : strMes = "Agosto"
            Case 9 : strMes = "Setiembre"
            Case 10 : strMes = "Octubre"
            Case 11 : strMes = "Noviembre"
            Case 12 : strMes = "Diciembre"
        End Select

        Fecha_Hoy = strDia & "," & DateAndTime.Day(strFecha) & " de " & strMes & " del " & Year(strFecha)
    End Function

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If MessageBox.Show("Esta seguro del cierre de Inventario ?", "NARSISTEMAS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If Validar() = False Then
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Timer1.Start()
            Me.btnaceptar.Enabled = False
            Me.btnsalir.Enabled = False
            cmdalmacen.Enabled = False
            cmbmes.Enabled = False
            txtanio.Enabled = False
            lblmensaje.Text = ""
            BackgroundWorker1.RunWorkerAsync()
        End If


    End Sub

    Public Function Validar() As Boolean
        Try
            If txtanio.Text.Trim.Length = 0 Then
                MsgBox("Selecciona el almacen.", MsgBoxStyle.Information, "NARSISTEMAS")
                Return False
            End If


            Dim dt_resu As New DataTable
            dt_resu = TmpListarDatos("SELECT codarti FROM RESUKDX WHERE CODEMPRESA='" & codempresa & "' AND ALMACEN='" & cmdalmacen.SelectedValue.ToString() & "' AND YEAR(FECHA)=" & fechacierre.Year & " AND MONTH(FECHA)=" & CInt(Me.cmbmes.SelectedValue.Codigo))

            If dt_resu.Rows.Count > 0 Then
                MsgBox("Ya se realizo el cierre del inventario " & cmdalmacen.Text, MsgBoxStyle.Information, "NARSISTEMAS")
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox("Falta Ingresar Datos.", MsgBoxStyle.Information, "NARSISTEMAS")
            Return False
        End Try


    End Function

    Public Function Consultar_Movimientos(ByVal cdalmacen As String, ByVal fechainicio As Date, ByVal fechafinal As Date) As Boolean
        Dim MesIni As Integer
        Dim AñoIni As Integer
        Dim MesFin As Integer
        Dim AñoFin As Integer
        Dim NroMes As Integer
        Dim NumeroAño As Integer
        Dim VentC, VentD, MoviC As String
        Dim FechaIni, FechaFin As String

        Dim strFechaIniMes, strFechaFinMes As Date

        TmpInsertDatos("DELETE FROM TMP_CIERRE_RESUKDX WHERE CODEMPRESA='" & codempresa & "'")

        MesIni = Month(fechainicio)
        AñoIni = Year(fechainicio)

        MesFin = Integer.Parse(Me.cmbmes.SelectedValue.Codigo.ToString)
        AñoFin = Integer.Parse(Me.txtanio.Text)


        If AñoIni = AñoFin Then
            NroMes = MesFin - MesIni
        Else
            NroMes = 0
            NumeroAño = AñoFin - AñoIni
            For i As Integer = 0 To NumeroAño
                If i = 1 Then
                    NroMes = NroMes + (12 - MesIni)
                Else
                    If i = NumeroAño Then
                        NroMes = NroMes + MesFin
                    Else
                        NroMes = NroMes + 12
                    End If
                End If

            Next
        End If


        Dim strconsul As String = ""

        Try


            For i As Integer = 0 To NroMes
                strFechaIniMes = DateAdd(DateInterval.Month, i, fechainicio)
                strFechaIniMes = DateAdd(DateInterval.Day, (-1) * DateAndTime.Day(strFechaIniMes) + 1, strFechaIniMes)

                strFechaFinMes = DateAdd(DateInterval.Month, 1, strFechaIniMes)
                strFechaFinMes = DateAdd(DateInterval.Day, -1, strFechaFinMes)

                'strTablaNC = "NCRC" & Format(strFechaFinMes, "yyyyMM")
                'strTablaND = "NCRD" & Format(strFechaFinMes, "yyyyMM")

                FechaIni = Format(strFechaIniMes, "dd/MM/yyyy 00:00:00")
                FechaFin = Format(strFechaFinMes, "dd/MM/yyyy 23:59:00")

                'lblEstado.Caption = "Consultando movimientos -> [INVENTARIO INICIAL]"

                TmpInsertDatos("BORRA_TMPRECALCULO '" & codempresa & "'")

                SeleccinaArtidatResukdk(cdalmacen, DateAdd(DateInterval.Day, -1, CDate(FechaIni)))

                MoviC = "MOVIC" & Format(CDate(FechaFin), "yyyyMM")

                ' INGRESOS
                TmpInsertDatos("LLENA_TMP_RECALCULO1 '" & codempresa & "','" & cdalmacen & "','" & FechaIni & "','" & FechaFin & "','" & MoviC & "'")

                ' SALIDAS
                TmpInsertDatos("LLENA_TMP_RECALCULO2 '" & codempresa & "','" & cdalmacen & "','" & FechaIni & "','" & FechaFin & "','" & MoviC & "'")

                ' VENTAS
                TmpInsertDatos("LLENA_TMP_RECALCULO3 '" & codempresa & "','" & cdalmacen & "','" & FechaIni & "','" & FechaFin & "'")

                VentC = "VENTC" & Format(strFechaFinMes, "yyyyMM")
                VentD = "VENTD" & Format(strFechaFinMes, "yyyyMM")

                If TmpListarDatos("VERIFICA_HISTORICOVENT '" & VentC & "','" & codempresa & "'").Rows.Count > 0 Then
                    TmpInsertDatos("LLENA_TMP_RECALCULO4    '" & codempresa & "','" & cdalmacen & "','" & FechaIni & "','" & FechaFin & "','" & VentD & "'")
                End If

                TmpInsertDatos("GENERA_SALDO_RESUKDX '" & codempresa & "','" & cdalmacen & "','" & Date.Parse(FechaFin).ToShortDateString() & "'")

            Next
            TmpInsertDatos("UPDATE RESUKDX SET SALDO = 0 WHERE SALDO IS NULL AND CODEMPRESA='" & codempresa & "'")
            Return True
        Catch ex As Exception

            Return False
        End Try
  



    End Function

    Private Sub SeleccinaArtidatResukdk(ByVal cdalmacen As String, ByVal fechaini As Date)
        TmpInsertDatos("SELECT_RESUKDX_RECALCULO '" & codempresa & "','" & cdalmacen & "','" & fechaini & "'")

    End Sub

    Private Function FechaInicial() As Date
        Dim Fecha_Inicial As String = ""
        Dim dt As New DataTable

        dt = TmpListarDatos("select min(fecdocum) as FechaIni from movicab where cdalmacen='" & cmdalmacen.SelectedValue.ToString.Trim & "' AND INOUT=1 AND CODEMPRESA='" & codempresa & "'")
        If dt.Rows.Count <> 0 Then
            If Not dt.Rows(0)("FechaIni") Is DBNull.Value Then
                Fecha_Inicial = CDate(dt.Rows(0)("FechaIni"))
            End If
        End If

        dt = New DataTable
        Dim tablac, tablad As String
        dt = TmpListarDatos("SELECT VENTCAB FROM HISTOVENTAS WHERE CODEMPRESA='" & codempresa & "' ORDER BY VENTCAB ")
        If dt.Rows.Count <> 0 Then
            tablac = dt.Rows(0)("VENTCAB").ToString
            tablad = tablac.Replace("VENTC", "VENTD")
            dt = New DataTable
            dt = TmpListarDatos("select min(fecproceso) as FechaIni from " & tablad & " where codalmacen='" & cmdalmacen.SelectedValue.ToString.Trim & "' and codempresa='" & codempresa & "'")
            If dt.Rows.Count <> 0 Then
                If Not dt.Rows(0)("FechaIni") Is DBNull.Value Then
                    If Fecha_Inicial = "" Then
                        Fecha_Inicial = CDate(dt.Rows(0)("FechaIni"))
                    ElseIf CDate(Fecha_Inicial) >= CDate(dt.Rows(0)("FechaIni")) Then
                        Fecha_Inicial = CDate(dt.Rows(0)("FechaIni"))
                    End If
                End If
            End If
        End If

        dt = New DataTable
        dt = TmpListarDatos("select max(fechA) as FechaUltCierre from resukdx where almacen='" & cmdalmacen.SelectedValue.ToString & "' and codempresa='" & codempresa & "'")
        If Not dt.Rows(0)("FechaUltCierre") Is DBNull.Value Then
            If Fecha_Inicial <> "" Then
                Fecha_Inicial = DateAdd(DateInterval.Day, 1, CDate(dt.Rows(0)("FechaUltCierre")))
            End If
        End If

        If Fecha_Inicial = "" Then
            Fecha_Inicial = DateAdd(DateInterval.Day, (-1) * DateAndTime.Day(DateAdd(DateInterval.Month, (-1) * Month(FechaP), FechaP)) + 1, FechaP)
        End If

        Return Fecha_Inicial
    End Function

    Private Sub cmdalmacen_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdalmacen.SelectionChangeCommitted
        UltimoCierre()

        If Month(fechacierre) = 12 Then
            cmbmes.SelectedIndex = 0
            txtanio.Text = Year(fechacierre) + 1
        Else
            cmbmes.SelectedIndex = (Month(fechacierre) - 1) + 1
            txtanio.Text = Year(fechacierre)
        End If

    End Sub

    Sub UltimoCierre()
        Dim dt As New DataTable
        dt = TmpListarDatos("Select Max(fecha) As Fecha From Resukdx Where Almacen = '" & cmdalmacen.SelectedValue.ToString() & "'")
        fechacierre = IIf(dt.Rows(0)(0) Is DBNull.Value, "01/01/2013", dt.Rows(0)(0))
        Me.lblfechacierre.Text = fechacierre.ToShortDateString
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try

            Threading.Thread.Sleep(500)
            If Consultar_Movimientos(Me.cmdalmacen.SelectedValue.ToString.Trim, FechaInicial(), DateAdd("d", (-1) * DateAndTime.Day(FechaP), FechaP)) = False Then
                MsgBox("No se completo el proceso, Intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
            Else
                Me.lblmensaje.Text = "El proceso ha terminado."
            End If

        Catch ex As Exception
            MsgBox("El rango es incorrecto.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try

    End Sub


    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        pbrLoad.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Me.Cursor = Cursors.Default
        Timer1.Stop()
        pbrLoad.Value = 0

        Me.btnaceptar.Enabled = True
        Me.btnsalir.Enabled = True
        cmdalmacen.Enabled = True
        cmbmes.Enabled = True
        txtanio.Enabled = True
        UltimoCierre()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pbrLoad.Value = pbrLoad.Value + 1
        If pbrLoad.Value = 100 Then
            pbrLoad.Value = 0
        End If
    End Sub

    Private Sub txtanio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtanio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class

Public Class MesesE

    Sub New(ByVal Codigo As String, ByVal Mes As String)
        Me.Codigo = Codigo
        Me.Mes = Mes
    End Sub

    Private mCodigo As String
    Public Property Codigo() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal value As String)
            mCodigo = value
        End Set
    End Property


    Private mMes As String
    Public Property Mes() As String
        Get
            Return mMes
        End Get
        Set(ByVal value As String)
            mMes = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Mes.ToString()
    End Function

End Class