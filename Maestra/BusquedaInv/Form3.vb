Imports System.IO




Public Class Form3
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

                        If CAyuda.Ejecutar("Nsp_inst_presentacion_2", linea(0), linea(1), linea(2), linea(3), linea(4), linea(5), linea(6), linea(7), Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt"), linea(9), linea(10)) = 0 Then
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

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click

    End Sub
End Class