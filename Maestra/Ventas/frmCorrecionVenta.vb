Public Class frmCorrecionVenta

    Private Sub txtNroPlanilla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroPlanilla.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Dim TAB_COBRANZAC As New DataTable
            TAB_COBRANZAC = TmpListarDatos("SP_SELEC_GUIAINTERNACAB  '" & codempresa & "','" & txtNroPlanilla.Text.Trim & "'")

            If TAB_COBRANZAC.Rows.Count > 0 Then
       
                dtpinicio.Value = Format(CDate(TAB_COBRANZAC.Rows(0)("FECDESPACHO")), "dd/MM/yyyy")

               
            Else
                MsgBox("NO Hay datos")
            End If
        End If






    End Sub

    Private Sub txtNroPlanilla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroPlanilla.TextChanged




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim RptaTrans As Boolean
        RptaTrans = CAyuda.Ejecutar("SP_UPDATE_GUIAINTERNACAB", codempresa, txtNroPlanilla.Text, dtpinicio.Value.ToShortDateString)
        'sql = "NSP_upd_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.text.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.txtBanca.text & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
        If RptaTrans Then
            MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If


        dtpinicio.Value = Date.Now

    End Sub
End Class