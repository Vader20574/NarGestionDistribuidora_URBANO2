Public Class FrmActivacionPedido

    Dim ESTADO As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim TablaDircli As DataTable

        TablaDircli = CAyuda.ListarDatos("SP_RECORRER_PEDIDO", codempresa.Trim, Me.txtNroDoc1.Text, Me.txtNroDoc2.Text).Tables(0)


        If TablaDircli.Rows.Count > 0 Then
            For ContB As Integer = 0 To TablaDircli.Rows.Count - 1


                Dim Sql As String

                Sql = "update_PEDIDO '" & TablaDircli.Rows(ContB)("NUM_PEDIDO") & "','" & ESTADO & "','" & codempresa & "'"
                If TmpInsertDatos(Sql) = True Then
                
                End If

            Next
        End If


        MsgBox("SE ACTUALIZO")


    End Sub

    Private Sub rbPendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPendiente.CheckedChanged
        ESTADO = "P"

    End Sub

    Private Sub rbTerminado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTerminado.CheckedChanged
        ESTADO = "T"

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub rbAnulado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAnulado.CheckedChanged
        ESTADO = "A"

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtNroDoc2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDoc2.TextChanged

    End Sub
End Class