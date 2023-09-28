Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        TmpInsertDatos("SP_PROCEDURE_RESTABLECER  '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "'")


    End Sub
End Class