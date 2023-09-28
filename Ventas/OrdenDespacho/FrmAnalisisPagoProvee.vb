Public Class FrmAnalisisPagoProvee


    Dim rand As Integer
    Private Sub FrmAnalisisPagoProvee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CargaCombo()
        ValorRan()

    End Sub


    Private Sub CargaCombo()
        'Conecta("SELECT T.[CODTIPODOC], T.[DSTIPODOC] FROM TIPODOC T WHERE T.[CODEMPRESA]='" & codempresa & "'", "d")
        'Dim TablaTemp As New DataTable
        'TablaTemp = ds.Tables("d")
        'Me.cbTipoDoc.DisplayMember = "DSTIPODOC"
        'Me.cbTipoDoc.ValueMember = "CODTIPODOC"
        'Me.cbTipoDoc.DataSource = TablaTemp



        CAyuda.CargarDataCombo(cbTipoDoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")

        CAyuda.CargarDataCombo(cbProveedor, "Nsp_sel_Proveedor2 '" & codempresa & "'", "codproveedor", "desproveedor")

    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Reporte()
    End Sub
    Sub Reporte()
        Try
            With Rpt1
                .ReportFileName = RutaRptInv & "RptAnaPllaPagoXDoc.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

                .set_StoredProcParam(0, TextBox1.Text)
                .set_StoredProcParam(1, cbTipoDoc.SelectedValue)
                .set_StoredProcParam(2, cbProveedor.SelectedValue)

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos("DELETE FROM TMP_ANALIS_PLANILLA  WHERE CORREL='" & rand & "'")

    End Sub

End Class