

Public Class FrmActualizarPassword
    Private valor As Integer
    Private Resp As Integer
    Private agregar As Boolean
    Private ValidaDatos As Boolean


    Private Sub BTNACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click

        If TXTPASSWORD1.Text = TXTPASSWORD2.Text Then
            Resp = CAyuda.Ejecutar("NSP_upd_USUARIO2", CodUsuario, TXTPASSWORD1.Text, codempresa)
            If Resp = 1 Then
                MessageBox.Show("Registro Actualizado Correctamente", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Error DuranTe Esta Operacion", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            End If
        Else
            MsgBox("Los Password no son iguales ", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
        End If


    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub
End Class