Public Class Frm_BorrarPedidos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Sql As String

        Dim PROCESO As String

        Sql = "SP_BORRA_PEDIDOS '" & 60 & "','" & "01" & "'"
        PROCESO = TmpInsertDatos(Sql)
        If PROCESO = True Then

        End If

    End Sub
End Class