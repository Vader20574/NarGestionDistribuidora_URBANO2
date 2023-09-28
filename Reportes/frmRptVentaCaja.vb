Public Class frmRptVentaCaja
    Dim NomTablaC, NomTablaD As String
    Dim fechaini, fechafin As String
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click

        Dim meses As Integer

        If CDate(dtpinicio.Value.ToShortDateString) > CDate(dtpfin.Value.ToShortDateString) Then
            MsgBox("Fecha fuera de Rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        fechaini = dtpinicio.Value.ToShortDateString & " 00:00:00"
        fechafin = dtpfin.Value.ToShortDateString & " 23:59:00"

        TmpInsertDatos("DELETE FROM TMP_CUADRE_VENTAS WHERE CODEMP='" & codempresa & "'")
        meses = DateDiff(DateInterval.Month, dtpinicio.Value, dtpfin.Value)
        For i As Integer = 0 To meses

            NomTablaC = "VENTC" & Format(DateAdd("m", i, dtpinicio.Value), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, dtpinicio.Value), "yyyyMM")

            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_HISTORICO_VENTAS_CAJA", codempresa, fechaini, fechafin, NomTablaC)
            End If
        Next

        CAyuda.Ejecutar("SP_HISTORICO_VENTAS_CAJA", codempresa, fechaini, fechafin, "")


        TmpInsertDatos("DELETE FROM TMP_SUB_ORDEN_PLANILLA WHERE CORREL='" & rand & "'")
        meses = DateDiff(DateInterval.Month, dtpinicio.Value, dtpfin.Value)
        For i As Integer = 0 To meses

            NomTablaC = "VENTC" & Format(DateAdd("m", i, dtpinicio.Value), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, dtpinicio.Value), "yyyyMM")

            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_INS_SUB_ORDEN_PLANILLA", codempresa, fechaini, fechafin, rand, NomTablaC)
            End If
        Next
        CAyuda.Ejecutar("SP_INS_SUB_ORDEN_PLANILLA", codempresa, fechaini, fechafin, rand, "")

        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Cuadre_Ventas.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                .set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                .set_Formulas(3, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                .set_StoredProcParam(1, dtpinicio.Value.ToShortDateString)
                .set_StoredProcParam(2, dtpfin.Value.ToShortDateString)
                .set_StoredProcParam(3, rand)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub frmRptVentaCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()
    End Sub

    Dim rand As Integer
    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function



End Class