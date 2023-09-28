Public Class FrmVerificacionStock

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            Dim RptaTrans As Boolean
            RptaTrans = CAyuda.Ejecutar("NSP_INS_VERIFICAR_STOCK", codempresa, "SI", CodUsuario)
            If RptaTrans Then
                MsgBox("SE GUARDO")
            End If
        End If


        If RadioButton2.Checked = True Then
            Dim RptaTrans As Boolean
            RptaTrans = CAyuda.Ejecutar("NSP_INS_VERIFICAR_STOCK", codempresa, "NO", CodUsuario)
            If RptaTrans Then
                MsgBox("SE GUARDO")
            End If
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub FrmVerificacionStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tablaV As New DataTable
        tablaV = TmpListarDatos("NSP_SELECT_ESTADOV  '" & codempresa & "'")
        If tablaV.Rows.Count > 0 Then
            If tablaV.Rows(0)(0) = "SI" Then
                RadioButton1.Checked = True
            Else
                RadioButton2.Checked = True
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Verific_stock.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
               
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