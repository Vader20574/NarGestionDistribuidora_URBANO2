
Imports System.IO

Imports System.Text

Imports System.Data.OleDb

Public Class FrmPrecioInventario2
    Dim ruta As String


    Dim listaP As New List(Of ArtiComision)


    Private Sub txtCodArt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodArt.KeyPress


        If Asc(e.KeyChar) = 13 Then

            Dim TB_MAXITEM As DataTable

            TB_MAXITEM = TmpListarDatos("sp_Busp_minpres '" & codempresa & "','" & txtCodArt.Text & "'")
            Dim ITEM As Integer = 0


            txtcodpres.Text = TB_MAXITEM.Rows(0)(1).ToString
            txtMinPrec.Text = TB_MAXITEM.Rows(0)(2).ToString

            txtFactor.Text = TB_MAXITEM.Rows(0)(5).ToString

        End If



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodArt.TextChanged




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MessageBox.Show("- Desea Importar los Precios ?.", "NARSISTEMAS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            If listaP.Count = 0 Then
                MsgBox("- No hay Precios a Transferir." & vbNewLine & "Verifique la fuente de origen (Excel).", MsgBoxStyle.Information, "NARSISTEMAS")
                Exit Sub
            End If

            Try
                For i As Integer = 0 To Me.listaP.Count - 1

                    Dim CODIGO_ARTI As String
                    Dim CODALMACEN As String
                    Dim PRECIO As Double
                    Dim FECHA_ING As Date
                    Dim FECHA_FINAL As Date
                    'Dim FECHA_SAL As Date
                    'Dim NRO_ING As String
                    'Dim NRO_SAL As String

                    CODIGO_ARTI = listaP.Item(i).CODARTICULO.ToString
                    CODALMACEN = listaP.Item(i).CDTIPOCOM.ToString
                    PRECIO = CDbl(listaP.Item(i).PORC_COM)
                    FECHA_ING = CDate(listaP.Item(i).FECINI)
                    FECHA_FINAL = CDate(listaP.Item(i).FECFINAL)
                    'FECHA_SAL = CDate(listaP.Item(i).ULTSAL)
                    'NRO_ING = CStr(listaP.Item(i).NROING)
                    'NRO_SAL = CStr(listaP.Item(i).NROSAL)

                    If CODIGO_ARTI.Trim.Length = 0 Then
                        Exit For
                    End If

                    Dim Sql As String
                    Sql = "SP_TRANS_ARTICOMISION '" & codempresa & "','" & CODIGO_ARTI & "','" & CODALMACEN & "','" & PRECIO & "','" & FECHA_ING & "','" & FECHA_FINAL & "'"
                    If TmpInsertDatos(Sql) = True Then
                    End If

                Next

                MsgBox("SE ACTUALIZO")
            Catch ex As Exception
                MsgBox("- Los Precios no se Importaron." & vbNewLine & "- Intentelo Nuevamente.", MsgBoxStyle.Information, "NARSISTEMAS")
            End Try
        End If








    End Sub

    Private Sub FrmPrecioInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Sql As String

        Sql = "SP_DELETE_PRECIOINV '" & codempresa & "','" & Me.txtCodArt.Text & "'"
        If TmpInsertDatos(Sql) = True Then
            MsgBox("SE ELIMINO")
        End If

    End Sub

    Private Sub btnsele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsele.Click

        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.ruta = Me.OpenFileDialog1.FileName.ToString
            Me.txtruta.Text = ruta

            Try
                listaP.Clear()
                Dim excel() As String = File.ReadAllLines(ruta.Trim)
                Dim precio As Decimal
                Dim linea() As String

                Dim TipoP As New List(Of String)

                Dim COD_ALMACEN As String = ""

                For a As Integer = 0 To excel.Length - 1
                    linea = Split(excel(a), ",")

                    If a > 0 Then
                        Dim o As New ArtiComision

                        Dim CodArti As String
                        CodArti = "000000" & CInt(linea(0))
                        CodArti = Mid(CodArti, CodArti.Length - 5)
                        o.CODARTICULO = CodArti

                        Dim CodAlmacen As String
                        CodAlmacen = "00" & CInt(linea(1))
                        CodAlmacen = Mid(CodAlmacen, CodAlmacen.Length - 1)
                        o.CDTIPOCOM = CodAlmacen
                        o.PORC_COM = IIf(Decimal.TryParse(linea(2), precio) = True, precio, 0)
                        o.FECINI = CDate(linea(3))
                        o.FECFINAL = CDate(linea(4))
                        'o.ULTSAL = CDate(linea(4))
                        'o.NROING = linea(5)
                        'o.NROSAL = linea(6)
                        listaP.Add(o)

                    End If

                    If linea(0).Trim.Length = 0 Then
                        Exit For
                    End If

                Next

                Me.dgvlista.DataSource = listaP


            Catch ex As Exception
                MessageBox.Show("- Verifique que el archivo no este en uso y/o" & vbNewLine & " el archivo contenga el formato indicado.", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If

    End Sub
End Class