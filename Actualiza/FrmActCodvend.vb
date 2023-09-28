Imports System.IO

Imports System.Text

Imports System.Data.OleDb

Public Class FrmActCodvend
    Dim ruta As String
    Dim listaP As New List(Of TransPrecios3)
    Private Sub btnsele_Click(sender As Object, e As EventArgs) Handles btnsele.Click

        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.ruta = Me.OpenFileDialog1.FileName.ToString
            Me.txtruta.Text = ruta
            ' importarExcel(ruta, "CodVendVentaxCobrar", "")
            Try
                listaP.Clear()
                Dim excel() As String = File.ReadAllLines(ruta.Trim)
                Dim precio As Decimal
                Dim linea() As String

                Dim TipoP As New List(Of String)


                For a As Integer = 0 To excel.Length - 1
                    linea = Split(excel(a), ",")

                    If a = 0 Then
                    Else

                        Dim o As New TransPrecios3
                        o.CODCLIENTE = linea(0)

                        o.TIPODOC = linea(1)
                        o.NRODOC = linea(2)
                        o.CODVEND = linea(3)

                        listaP.Add(o)

                    End If
                Next
                Me.dgvlista.DataSource = listaP
            Catch ex As Exception
                MessageBox.Show("- Verifique que el archivo no este en uso y/o" & vbNewLine & " el archivo contenga el formato indicado.", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If

    End Sub

    Public Function importarExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String)
        Try
            'declarando las variables
            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim DtSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            'declarando variable de conexión
            MyConnection = New System.Data.OleDb.OleDbConnection _
            ("provider=Microsoft.Jet.OLEDB.4.0;" &
            " Data Source='" & ruta & "'; " &
             "Extended Properties='Excel 8.0;HDR=NO'")
            'creando consulta para extraer contenido del archivo de excel y ejecutandola
            MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                ("select * from [" & hoja & "$" & "]", MyConnection)
            MyCommand.TableMappings.Add("Table", "TestTable")
            DtSet = New System.Data.DataSet
            MyCommand.Fill(DtSet)
            'tabla.DataSet = DtSet.
            'ubicando el resultado en el datagridview
            dgvlista.DataSource = DtSet.Tables(0)
            'cerrando conexión
            MyConnection.Close()
        Catch ex As Exception
            'imprimiendo mensaje de error
            MsgBox(ex.ToString)
        End Try
        Return False
    End Function



    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        If MessageBox.Show("- Desea Importar  ?.", "NARSISTEMAS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If listaP.Count = 0 Then
                MsgBox("- No hay data." & vbNewLine & "Verifique la fuente de origen (Excel).", MsgBoxStyle.Information, "NARSISTEMAS")
                Exit Sub
            End If

            If MessageBox.Show("- Esta seguro de Actualizar ?.", "NARSISTEMAS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    For i As Integer = 0 To Me.listaP.Count - 1

                        Dim codCliente As String
                        Dim TipoDoc As String
                        Dim NroDoc As String
                        Dim CodVend As String
                        codCliente = listaP.Item(i).CODCLIENTE.ToString
                        TipoDoc = listaP.Item(i).TIPODOC.ToString
                        NroDoc = listaP.Item(i).NRODOC.ToString
                        CodVend = listaP.Item(i).CODVEND.ToString

                        If CAyuda.Ejecutar("upd_venta_x_cobrar", codCliente, TipoDoc, NroDoc, CodVend) = 0 Then
                        End If

                    Next

                    MsgBox("- Se modificaron los vendedores.", MsgBoxStyle.Information, "NARSISTEMAS")
                    btnactualizar.Enabled = False
                Catch ex As Exception
                    MsgBox("- No se modificaron los vendedores" & vbNewLine & "- Intentelo Nuevamente.", MsgBoxStyle.Information, "NARSISTEMAS")
                End Try
            End If

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtruta_TextChanged(sender As Object, e As EventArgs) Handles txtruta.TextChanged

    End Sub
End Class