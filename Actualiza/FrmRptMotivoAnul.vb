Public Class FrmRptMotivoAnul

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_TipoAnulacion.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                '.set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                '.set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                '.set_Formulas(4, "Distrito='" & cmbdistrito.Text & "'")
                '.set_Formulas(5, "Ruta='" & cmbruta.Text & "'")
                .set_StoredProcParam(0, codempresa)
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