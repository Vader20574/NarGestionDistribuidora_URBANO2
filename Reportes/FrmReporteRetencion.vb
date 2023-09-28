Public Class FrmReporteRetencion
    Dim rand As Integer
    Dim dtrpt As New DataTable
    Dim CodVend As String = ""

    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String

    Dim TAB_DETALLE As DataTable

    Dim TAB_DETALLE2 As DataTable

    Dim fechaini, fechahas As Date

    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)

    Dim i As Integer

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")


        If ckDetalle.Checked = True Then
            TAB_DETALLE = TmpListarDatos("SP_INS_TMP_RETENEMIPROVDET2 '" & rand & "','" & fechaini & "','" & fechahas & "'")
            Reporte2()


        Else
            TAB_DETALLE = TmpListarDatos("SP_INS_TMP_RETENEMIPROVCAB '" & rand & "','" & fechaini & "','" & fechahas & "'")
            Reporte()
        End If









    End Sub

    Sub Reporte()
  
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Reporte_Reten_Fecha.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
           
                .set_StoredProcParam(0, rand)


                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos("DELETE FROM TMP_RETENEMIPROVCAB  WHERE CORREL='" & rand & "'")

    End Sub


    Sub Reporte2()

        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "RptRetencionDetalle.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

                .set_StoredProcParam(0, rand)


                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos("DELETE FROM TMP_RETENEMIPROVCAB  WHERE CORREL='" & rand & "'")

    End Sub





    Private Sub FrmReporteRetencion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()

    End Sub
End Class