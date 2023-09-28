Public Class frmTransAlmacen

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim TMP_ALMACEN As DataTable
        Dim TMP_ARTICULO As DataTable

        TMP_ALMACEN = TmpListarDatos("SP_SELECT_ALMACEN_02 '" & codempresa & "'")
        If TMP_ALMACEN.Rows.Count > 0 Then
            For x As Integer = 0 To TMP_ALMACEN.Rows.Count - 1
                TMP_ARTICULO = TmpListarDatos("SP_SELECT_ARTICULO_02 '" & codempresa & "'")
                If TMP_ARTICULO.Rows.Count > 0 Then
                    For x2 As Integer = 0 To TMP_ARTICULO.Rows.Count - 1

                        If CAyuda.Ejecutar("SP_INSERT_PORALMACEN_ARTIDAT", codempresa, TMP_ALMACEN.Rows(x)(1).ToString, TMP_ARTICULO.Rows(x2)(1).ToString) = 0 Then
                      
                        End If

                    Next
                End If
            Next
            MsgBox("- Los Almacenes por ariculo ya se ingresaron." & vbNewLine & "-Mensaje", MsgBoxStyle.Information, "NARSISTEMAS")


        End If











    End Sub
End Class