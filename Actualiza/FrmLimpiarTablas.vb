Public Class FrmLimpiarTablas


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CAyuda.Ejecutar("SP_LIMPIAR_TABLAS", codempresa) > 0 Then
        End If
        MsgBox("SE LIMPIO CORRECTAMENTE", MsgBoxStyle.Information, "")

    End Sub
End Class