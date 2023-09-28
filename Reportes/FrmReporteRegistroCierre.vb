Public Class FrmReporteRegistroCierre

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