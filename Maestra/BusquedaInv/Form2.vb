Imports System.IO

Public Class Form2
    Dim ruta As String
    Dim listaP As New List(Of TransPrecios)
    Private Sub btnsele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsele.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.ruta = Me.OpenFileDialog1.FileName.ToString
            Me.txtruta.Text = ruta

            Try
                listaP.Clear()
                Dim excel() As String = File.ReadAllLines(ruta.Trim)

                Dim linea() As String

                Dim TipoP As New List(Of String)


                For a As Integer = 0 To excel.Length - 1
                    linea = Split(excel(a), ",")

                    If a >= 1 Then
                        TipoP.Add(linea(0))
                        TipoP.Add(linea(1))
                        TipoP.Add(linea(2))
                        TipoP.Add(linea(3))

                        If CAyuda.Ejecutar("sp_insert_ARTIPRESENT_2", linea(0), linea(1), linea(2), CInt(linea(3))) = 0 Then
                            MsgBox("- Los Precios no se Importaron." & vbNewLine & "- Intentelo Nuevamente.", MsgBoxStyle.Information, "NARSISTEMAS")
                            Exit Sub
                        End If

                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("- Verifique que el archivo no este en uso y/o" & vbNewLine & " el archivo contenga el formato indicado.", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click
        If MessageBox.Show("- Desea Importar los Precios ?.", "NARSISTEMAS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If listaP.Count = 0 Then
                MsgBox("- No hay Precios a Transferir." & vbNewLine & "Verifique la fuente de origen (Excel).", MsgBoxStyle.Information, "NARSISTEMAS")
                Exit Sub
            End If

            If MessageBox.Show("- Esta seguro de Actualizar los Precios ?.", "NARSISTEMAS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    For i As Integer = 0 To Me.listaP.Count - 1
                        For x As Integer = 0 To Me.listaP.Item(i).PRECIO.Count - 1
                            Dim CodPrecio As String
                            CodPrecio = "000" & CInt(listaP.Item(i).PRECIO(x).CODIGO)
                            CodPrecio = Mid(CodPrecio, CodPrecio.Length - 2)

                            Dim CODIGO_ARTI As String
                            CODIGO_ARTI = Val(listaP.Item(i).CODARTICULO.ToString)

                            Dim TB_BUSQCLIDEP As System.Data.DataTable

                            TB_BUSQCLIDEP = TmpListarDatos("BUSQ_ARTICULO '" & codempresa & "','" & CODIGO_ARTI & "'")
                            If TB_BUSQCLIDEP.Rows.Count > 0 Then
                                VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
                            End If



                            If CAyuda.Ejecutar("SP_TRANS_PRECIOS", codempresa, listaP.Item(i).CODPRESENTACION, CodPrecio, listaP.Item(i).PRECIO(x).PRECIO, VAR1) = 0 Then
                                MsgBox("- Los Precios no se Importaron." & vbNewLine & "- Intentelo Nuevamente.", MsgBoxStyle.Information, "NARSISTEMAS")
                                Exit Sub
                            End If
                        Next
                    Next

                    MsgBox("- Los Precios se Importaron con Exito.", MsgBoxStyle.Information, "NARSISTEMAS")
                    btnactualizar.Enabled = False
                Catch ex As Exception
                    MsgBox("- Los Precios no se Importaron." & vbNewLine & "- Intentelo Nuevamente.", MsgBoxStyle.Information, "NARSISTEMAS")
                End Try
            End If

        End If
    End Sub
End Class