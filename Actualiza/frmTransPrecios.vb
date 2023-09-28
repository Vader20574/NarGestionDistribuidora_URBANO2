Imports System.IO


Public Class frmTransPrecios
    Dim ruta As String
    Dim listaP As New List(Of TransPrecios)
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

                For a As Integer = 0 To excel.Length - 1
                    linea = Split(excel(a), ",")

                    If a = 0 Then
                        TipoP.Add(linea(6))
                        TipoP.Add(linea(7))
                        TipoP.Add(linea(8))
                        TipoP.Add(linea(9))
                        TipoP.Add(linea(10))
                        TipoP.Add(linea(11))
                        TipoP.Add(linea(12))
                        TipoP.Add(linea(13))
                        TipoP.Add(linea(14))
                        TipoP.Add(linea(15))
                        TipoP.Add(linea(16))
                        TipoP.Add(linea(17))
                        TipoP.Add(linea(18))
                        TipoP.Add(linea(19))

                        TipoP.Add(linea(20))
                        TipoP.Add(linea(21))
                        TipoP.Add(linea(22))
                        TipoP.Add(linea(23))
                        TipoP.Add(linea(24))
                        TipoP.Add(linea(25))
                        TipoP.Add(linea(26))
                        TipoP.Add(linea(27))
                        TipoP.Add(linea(28))
                        TipoP.Add(linea(29))
                        TipoP.Add(linea(30))
                        TipoP.Add(linea(31))
                        TipoP.Add(linea(32))
                        TipoP.Add(linea(33))
                        TipoP.Add(linea(34))
                        TipoP.Add(linea(35))
                        TipoP.Add(linea(36))
                        TipoP.Add(linea(37))
                        TipoP.Add(linea(38))
                        TipoP.Add(linea(39))
                        TipoP.Add(linea(40))
                        TipoP.Add(linea(41))
                        TipoP.Add(linea(42))
                        TipoP.Add(linea(43))
                        TipoP.Add(linea(44))
                        TipoP.Add(linea(45))
                        TipoP.Add(linea(46))
                        TipoP.Add(linea(47))
                        TipoP.Add(linea(48))
                        TipoP.Add(linea(49))
                        TipoP.Add(linea(50))
                        TipoP.Add(linea(51))
                        TipoP.Add(linea(52))
                        TipoP.Add(linea(53))
                        TipoP.Add(linea(54))
                        TipoP.Add(linea(55))

                        TipoP.Add(linea(56))
                        TipoP.Add(linea(57))
                        TipoP.Add(linea(58))
                        TipoP.Add(linea(59))
                        TipoP.Add(linea(60))
                        TipoP.Add(linea(61))
                        TipoP.Add(linea(62))
                        TipoP.Add(linea(63))
                        TipoP.Add(linea(64))
                        TipoP.Add(linea(65))
                        TipoP.Add(linea(66))
                        TipoP.Add(linea(67))
                        TipoP.Add(linea(68))
                        TipoP.Add(linea(69))
                        TipoP.Add(linea(70))
                        TipoP.Add(linea(71))
                        TipoP.Add(linea(72))
                        TipoP.Add(linea(73))
                        TipoP.Add(linea(74))
                        TipoP.Add(linea(75))
                        TipoP.Add(linea(76))
                        TipoP.Add(linea(77))
                        TipoP.Add(linea(78))
                        TipoP.Add(linea(79))
                        TipoP.Add(linea(80))
                        TipoP.Add(linea(81))
                        TipoP.Add(linea(82))
                        TipoP.Add(linea(83))
                        TipoP.Add(linea(84))
                        TipoP.Add(linea(85))
                        TipoP.Add(linea(86))
                        TipoP.Add(linea(87))
                        TipoP.Add(linea(88))
                        TipoP.Add(linea(89))
                        TipoP.Add(linea(90))
                        TipoP.Add(linea(91))
                        TipoP.Add(linea(92))
                        TipoP.Add(linea(93))
                        TipoP.Add(linea(94))
                        TipoP.Add(linea(95))
                        TipoP.Add(linea(96))
                        TipoP.Add(linea(97))
                        TipoP.Add(linea(98))
                        TipoP.Add(linea(99))
                        TipoP.Add(linea(100))
                        TipoP.Add(linea(101))
                        TipoP.Add(linea(102))
                        TipoP.Add(linea(103))
                        TipoP.Add(linea(104))
                        TipoP.Add(linea(105))




                    Else

                        Dim o As New TransPrecios
                        o.CODARTICULO = linea(0)
                        o.CODPRESENTACION = linea(2)
                        o.PRECIO = New List(Of PreciosE)

                        o.PRECIO1 = IIf(Decimal.TryParse(linea(6), precio) = True, precio, 0)
                        o.PRECIO2 = IIf(Decimal.TryParse(linea(7), precio) = True, precio, 0)
                        o.PRECIO3 = IIf(Decimal.TryParse(linea(8), precio) = True, precio, 0)
                        o.PRECIO4 = IIf(Decimal.TryParse(linea(9), precio) = True, precio, 0)
                        o.PRECIO5 = IIf(Decimal.TryParse(linea(10), precio) = True, precio, 0)
                        o.PRECIO6 = IIf(Decimal.TryParse(linea(11), precio) = True, precio, 0)
                        o.PRECIO7 = IIf(Decimal.TryParse(linea(12), precio) = True, precio, 0)
                        o.PRECIO8 = IIf(Decimal.TryParse(linea(13), precio) = True, precio, 0)
                        o.PRECIO9 = IIf(Decimal.TryParse(linea(14), precio) = True, precio, 0)
                        o.PRECIO10 = IIf(Decimal.TryParse(linea(15), precio) = True, precio, 0)
                        o.PRECIO11 = IIf(Decimal.TryParse(linea(16), precio) = True, precio, 0)
                        o.PRECIO12 = IIf(Decimal.TryParse(linea(17), precio) = True, precio, 0)

                        o.PRECIO13 = IIf(Decimal.TryParse(linea(18), precio) = True, precio, 0)
                        o.PRECIO14 = IIf(Decimal.TryParse(linea(19), precio) = True, precio, 0)
                        o.PRECIO15 = IIf(Decimal.TryParse(linea(20), precio) = True, precio, 0)
                        o.PRECIO16 = IIf(Decimal.TryParse(linea(21), precio) = True, precio, 0)
                        o.PRECIO17 = IIf(Decimal.TryParse(linea(22), precio) = True, precio, 0)
                        o.PRECIO18 = IIf(Decimal.TryParse(linea(23), precio) = True, precio, 0)
                        o.PRECIO19 = IIf(Decimal.TryParse(linea(24), precio) = True, precio, 0)
                        o.PRECIO20 = IIf(Decimal.TryParse(linea(25), precio) = True, precio, 0)
                        o.PRECIO21 = IIf(Decimal.TryParse(linea(26), precio) = True, precio, 0)
                        o.PRECIO22 = IIf(Decimal.TryParse(linea(27), precio) = True, precio, 0)
                        o.PRECIO23 = IIf(Decimal.TryParse(linea(28), precio) = True, precio, 0)
                        o.PRECIO24 = IIf(Decimal.TryParse(linea(29), precio) = True, precio, 0)
                        o.PRECIO25 = IIf(Decimal.TryParse(linea(30), precio) = True, precio, 0)
                        o.PRECIO26 = IIf(Decimal.TryParse(linea(31), precio) = True, precio, 0)
                        o.PRECIO27 = IIf(Decimal.TryParse(linea(32), precio) = True, precio, 0)
                        o.PRECIO28 = IIf(Decimal.TryParse(linea(33), precio) = True, precio, 0)
                        o.PRECIO29 = IIf(Decimal.TryParse(linea(34), precio) = True, precio, 0)
                        o.PRECIO30 = IIf(Decimal.TryParse(linea(35), precio) = True, precio, 0)
                        o.PRECIO31 = IIf(Decimal.TryParse(linea(36), precio) = True, precio, 0)
                        o.PRECIO32 = IIf(Decimal.TryParse(linea(37), precio) = True, precio, 0)
                        o.PRECIO33 = IIf(Decimal.TryParse(linea(38), precio) = True, precio, 0)
                        o.PRECIO34 = IIf(Decimal.TryParse(linea(39), precio) = True, precio, 0)
                        o.PRECIO35 = IIf(Decimal.TryParse(linea(40), precio) = True, precio, 0)
                        o.PRECIO36 = IIf(Decimal.TryParse(linea(41), precio) = True, precio, 0)
                        o.PRECIO37 = IIf(Decimal.TryParse(linea(42), precio) = True, precio, 0)
                        o.PRECIO38 = IIf(Decimal.TryParse(linea(43), precio) = True, precio, 0)
                        o.PRECIO39 = IIf(Decimal.TryParse(linea(44), precio) = True, precio, 0)
                        o.PRECIO40 = IIf(Decimal.TryParse(linea(45), precio) = True, precio, 0)
                        o.PRECIO41 = IIf(Decimal.TryParse(linea(46), precio) = True, precio, 0)
                        o.PRECIO42 = IIf(Decimal.TryParse(linea(47), precio) = True, precio, 0)
                        o.PRECIO43 = IIf(Decimal.TryParse(linea(48), precio) = True, precio, 0)
                        o.PRECIO44 = IIf(Decimal.TryParse(linea(49), precio) = True, precio, 0)
                        o.PRECIO45 = IIf(Decimal.TryParse(linea(50), precio) = True, precio, 0)
                        o.PRECIO46 = IIf(Decimal.TryParse(linea(51), precio) = True, precio, 0)
                        o.PRECIO47 = IIf(Decimal.TryParse(linea(52), precio) = True, precio, 0)
                        o.PRECIO48 = IIf(Decimal.TryParse(linea(53), precio) = True, precio, 0)
                        o.PRECIO49 = IIf(Decimal.TryParse(linea(54), precio) = True, precio, 0)
                        o.PRECIO50 = IIf(Decimal.TryParse(linea(55), precio) = True, precio, 0)

                        o.PRECIO51 = IIf(Decimal.TryParse(linea(56), precio) = True, precio, 0)
                        o.PRECIO52 = IIf(Decimal.TryParse(linea(57), precio) = True, precio, 0)
                        o.PRECIO53 = IIf(Decimal.TryParse(linea(58), precio) = True, precio, 0)
                        o.PRECIO54 = IIf(Decimal.TryParse(linea(59), precio) = True, precio, 0)
                        o.PRECIO55 = IIf(Decimal.TryParse(linea(60), precio) = True, precio, 0)
                        o.PRECIO56 = IIf(Decimal.TryParse(linea(61), precio) = True, precio, 0)
                        o.PRECIO57 = IIf(Decimal.TryParse(linea(62), precio) = True, precio, 0)
                        o.PRECIO58 = IIf(Decimal.TryParse(linea(63), precio) = True, precio, 0)
                        o.PRECIO59 = IIf(Decimal.TryParse(linea(64), precio) = True, precio, 0)
                        o.PRECIO60 = IIf(Decimal.TryParse(linea(65), precio) = True, precio, 0)
                        o.PRECIO61 = IIf(Decimal.TryParse(linea(66), precio) = True, precio, 0)
                        o.PRECIO62 = IIf(Decimal.TryParse(linea(67), precio) = True, precio, 0)
                        o.PRECIO63 = IIf(Decimal.TryParse(linea(68), precio) = True, precio, 0)
                        o.PRECIO64 = IIf(Decimal.TryParse(linea(69), precio) = True, precio, 0)
                        o.PRECIO65 = IIf(Decimal.TryParse(linea(70), precio) = True, precio, 0)
                        o.PRECIO66 = IIf(Decimal.TryParse(linea(71), precio) = True, precio, 0)
                        o.PRECIO67 = IIf(Decimal.TryParse(linea(72), precio) = True, precio, 0)
                        o.PRECIO68 = IIf(Decimal.TryParse(linea(73), precio) = True, precio, 0)
                        o.PRECIO69 = IIf(Decimal.TryParse(linea(74), precio) = True, precio, 0)
                        o.PRECIO70 = IIf(Decimal.TryParse(linea(75), precio) = True, precio, 0)
                        o.PRECIO71 = IIf(Decimal.TryParse(linea(76), precio) = True, precio, 0)
                        o.PRECIO72 = IIf(Decimal.TryParse(linea(77), precio) = True, precio, 0)
                        o.PRECIO73 = IIf(Decimal.TryParse(linea(78), precio) = True, precio, 0)
                        o.PRECIO74 = IIf(Decimal.TryParse(linea(79), precio) = True, precio, 0)
                        o.PRECIO75 = IIf(Decimal.TryParse(linea(80), precio) = True, precio, 0)
                        o.PRECIO76 = IIf(Decimal.TryParse(linea(81), precio) = True, precio, 0)
                        o.PRECIO77 = IIf(Decimal.TryParse(linea(82), precio) = True, precio, 0)
                        o.PRECIO78 = IIf(Decimal.TryParse(linea(83), precio) = True, precio, 0)
                        o.PRECIO79 = IIf(Decimal.TryParse(linea(84), precio) = True, precio, 0)
                        o.PRECIO80 = IIf(Decimal.TryParse(linea(85), precio) = True, precio, 0)
                        o.PRECIO81 = IIf(Decimal.TryParse(linea(86), precio) = True, precio, 0)
                        o.PRECIO82 = IIf(Decimal.TryParse(linea(87), precio) = True, precio, 0)
                        o.PRECIO83 = IIf(Decimal.TryParse(linea(88), precio) = True, precio, 0)
                        o.PRECIO84 = IIf(Decimal.TryParse(linea(89), precio) = True, precio, 0)
                        o.PRECIO85 = IIf(Decimal.TryParse(linea(90), precio) = True, precio, 0)
                        o.PRECIO86 = IIf(Decimal.TryParse(linea(91), precio) = True, precio, 0)
                        o.PRECIO87 = IIf(Decimal.TryParse(linea(92), precio) = True, precio, 0)
                        o.PRECIO88 = IIf(Decimal.TryParse(linea(93), precio) = True, precio, 0)
                        o.PRECIO89 = IIf(Decimal.TryParse(linea(94), precio) = True, precio, 0)
                        o.PRECIO90 = IIf(Decimal.TryParse(linea(95), precio) = True, precio, 0)
                        o.PRECIO91 = IIf(Decimal.TryParse(linea(96), precio) = True, precio, 0)
                        o.PRECIO92 = IIf(Decimal.TryParse(linea(97), precio) = True, precio, 0)
                        o.PRECIO93 = IIf(Decimal.TryParse(linea(98), precio) = True, precio, 0)
                        o.PRECIO94 = IIf(Decimal.TryParse(linea(99), precio) = True, precio, 0)
                        o.PRECIO95 = IIf(Decimal.TryParse(linea(100), precio) = True, precio, 0)
                        o.PRECIO96 = IIf(Decimal.TryParse(linea(101), precio) = True, precio, 0)
                        o.PRECIO97 = IIf(Decimal.TryParse(linea(102), precio) = True, precio, 0)
                        o.PRECIO98 = IIf(Decimal.TryParse(linea(103), precio) = True, precio, 0)
                        o.PRECIO99 = IIf(Decimal.TryParse(linea(104), precio) = True, precio, 0)
                        o.PRECIO100 = IIf(Decimal.TryParse(linea(105), precio) = True, precio, 0)




                        For k As Integer = 6 To 105
                            Dim pr As New PreciosE
                            pr.CODIGO = TipoP(k - 6)
                            pr.PRECIO = IIf(Decimal.TryParse(linea(k), precio) = True, precio, 0)
                            o.PRECIO.Add(pr)
                        Next
                        listaP.Add(o)

                    End If
                Next
                Me.dgvlista.DataSource = listaP
            Catch ex As Exception
                MessageBox.Show("- Verifique que el archivo no este en uso y/o" & vbNewLine & " el archivo contenga el formato indicado.", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        End If
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

                            Dim CodPresentaciom As String
                            CodPresentaciom = "000" & CInt(listaP.Item(i).CODPRESENTACION)
                            CodPresentaciom = Mid(CodPresentaciom, CodPresentaciom.Length - 2)

                            Dim CODIGO_ARTI As String
                            CODIGO_ARTI = Val(listaP.Item(i).CODARTICULO.ToString)

                            Dim TB_BUSQCLIDEP As System.Data.DataTable

                            TB_BUSQCLIDEP = TmpListarDatos("BUSQ_ARTICULO '" & codempresa & "','" & CODIGO_ARTI & "'")
                            If TB_BUSQCLIDEP.Rows.Count > 0 Then
                                VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
                            End If

                            If CAyuda.Ejecutar("SP_TRANS_PRECIOS", codempresa, CodPresentaciom, CodPrecio, listaP.Item(i).PRECIO(x).PRECIO, VAR1) = 0 Then
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

    Private Sub frmTransPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        'Dim cPart As Range
        ''Dim cLoc As Range
        'Dim oExcel As Application = CreateObject("Excel.Application")
        'Dim oBook As Microsoft.Office.Interop.Excel.Workbook = oExcel.Workbooks.Open("C:\FORMATO_CAMBIO_PRECIO_LIST_XLS.xls", , False)
        'Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet
        'oSheet = oBook.Worksheets("LISTA_PRECIOS_OK")
        '' To find range in excel and send them to combo box(cboName)

        'Dim linea As String

        'For Each cPart In oSheet.Range("A1:R1")
        '    linea = linea & "," & cPart.Value
        '    With Me.ComboBox1
        '        .Items.Add(cPart.Value)
        '        '.AddItem(cPart.Value)
        '        '.List(.ListCount - 1, 1) = cPart.Offset(0, 1).Value
        '    End With
        'Next cPart


        'oBook.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtruta_TextChanged(sender As Object, e As EventArgs) Handles txtruta.TextChanged

    End Sub

    Private Sub dgvlista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub
End Class