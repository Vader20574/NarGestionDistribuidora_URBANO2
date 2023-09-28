Imports System.IO

Imports System.Text

Imports System.Data.OleDb

Public Class frmTransPrecios3
    Dim ruta As String
    Dim listaP As New List(Of TransPrecios2)
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


                    Else

                        Dim o As New TransPrecios2
                        o.CODARTICULO = linea(0)

                        o.PB = linea(2)
                        o.PF = linea(3)
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


                        For k As Integer = 6 To 17
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

                            Dim CODIGO_ARTI As String
                            CODIGO_ARTI = Val(listaP.Item(i).CODARTICULO.ToString)

                            Dim TB_BUSQCLIDEP As System.Data.DataTable

                            TB_BUSQCLIDEP = TmpListarDatos("BUSQ_ARTICULO '" & codempresa & "','" & CODIGO_ARTI & "'")
                            If TB_BUSQCLIDEP.Rows.Count > 0 Then
                                VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
                            End If



                            If CAyuda.Ejecutar("SP_TRANS_DESCUENTO", codempresa, CodPrecio, listaP.Item(i).PRECIO(x).PRECIO, VAR1) = 0 Then
                                MsgBox("- Los Precios no se Importaron." & vbNewLine & "- Intentelo Nuevamente.", MsgBoxStyle.Information, "NARSISTEMAS")
                                Exit Sub
                            End If

                            If CAyuda.Ejecutar("SP_UPD_PERCEP_ARTICULO", codempresa, VAR1, listaP.Item(i).PB, listaP.Item(i).PF) = 0 Then
                                MsgBox("- Los percepcion no se Importaron." & vbNewLine & "- Intentelo Nuevamente.", MsgBoxStyle.Information, "NARSISTEMAS")
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
        cboPeriodo.Items.Add("ENERO")
        cboPeriodo.Items.Add("FEBRERO")
        cboPeriodo.Items.Add("MARZO")
        cboPeriodo.Items.Add("ABRIL")
        cboPeriodo.Items.Add("MAYO")
        cboPeriodo.Items.Add("JUNIO")
        cboPeriodo.Items.Add("JULIO")
        cboPeriodo.Items.Add("AGOSTO")
        cboPeriodo.Items.Add("SEPTIEMBRE")
        cboPeriodo.Items.Add("OCTUBRE")
        cboPeriodo.Items.Add("NOVIEMBRE")
        cboPeriodo.Items.Add("DICIEMBRE")
        cboPeriodo.SelectedIndex = Date.Now.Month - 1


        txtEjercicio.Text = Date.Now.Year

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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objStreamWriter As StreamWriter
        Dim x As Long

        'Open the file.
        objStreamWriter = New StreamWriter("C:\Test2.txt", True, _
           Encoding.Unicode)

        'Write out the numbers 1 through 10 on the same line.
        For x = 1 To 10
            objStreamWriter.Write(x)
        Next x

        'Close the file.
        objStreamWriter.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim dt As New DataTable
        Dim objStreamWriter As StreamWriter

        objStreamWriter = New StreamWriter("C:\Text.txt")

        dt = CAyuda.ListarDatos("SP_RPT_VTA_SUNA_V7", "486813983").Tables(0)


        For x As Integer = 0 To dt.Rows.Count - 1
            objStreamWriter.WriteLine("06|" + dt.Rows(x)("RUC").ToString.Trim() + "||" + dt.Rows(x)("ap").ToString.Trim() + "|" + dt.Rows(x)("am").ToString.Trim() + "|" + dt.Rows(x)("nomb").ToString.Trim() + "|" + dt.Rows(x)("SERIE").ToString.Trim() + "|" + dt.Rows(x)("NUMERO").ToString.Trim() + "|" + dt.Rows(x)("FECHA").ToString.Trim() + "|1|0|0|" + dt.Rows(x)("TOTAL").ToString.Trim() + "|1|" + dt.Rows(x)("SERIE").ToString.Trim() + "|" + dt.Rows(x)("NUMERO").ToString.Trim() + "|" + dt.Rows(x)("FECHA").ToString.Trim() + "|" + dt.Rows(x)("TOTAL").ToString.Trim() + "|")
        Next

        'Close the file.
        objStreamWriter.Close()



        'Dim objStreamWriter As StreamWriter

        ''Pass the file path and the file name to the StreamWriter constructor.
        'objStreamWriter = New StreamWriter("C:\Text.txt")

        ''Write a line of text.
        'objStreamWriter.WriteLine("Hello World")

        ''Write a second line of text.
        'objStreamWriter.WriteLine("From the StreamWriter class")

        ''Close the file.
        'objStreamWriter.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Try


            Me.ruta = Me.OpenFileDialog1.FileName.ToString
            Me.txtruta.Text = ruta

            'DataGridView1.DataSource = _
            '                      GetDataExcel("C:2222\PERCEPCION ABRIL 2014.xls", "Recuperado_Hoja1$")



            DataGridView1.DataSource = _
                                  GetDataExcel("C:2222\REMUNERACION.xls", "Recuperado_Hoja1$")

            Dim dt As New DataTable
            dt = GetDataExcel("C:2222\REMUNERACION.xls", "Recuperado_Hoja1$")




            Dim TB_BUSQCLIDEP As DataTable

            TB_BUSQCLIDEP = TmpListarDatos("SP_BUSQUEDA_REMUNERACION '" & txtEjercicio.Text & "','" & cboPeriodo.Text & "'")
            If TB_BUSQCLIDEP.Rows.Count > 0 Then
                Select Case MsgBox("Desea Actualizar ?", MsgBoxStyle.YesNo, "Actualizar")
                    Case MsgBoxResult.Yes

                        If CAyuda.Ejecutar("SP_DELETE_REMUNERACION", txtEjercicio.Text, cboPeriodo.Text) = 0 Then
                        End If

                    Case MsgBoxResult.No
                        Exit Sub
                End Select
            End If




            Dim FECHA As String = ""

            For x As Integer = 0 To dt.Rows.Count - 1

                If dt.Rows(x)("ORDEN").ToString = "" Then
                    Exit Sub
                End If

                If CAyuda.Ejecutar("SP_INSERT_REMUNERACION", dt.Rows(x)("ORDEN").ToString, dt.Rows(x)("CODIGO").ToString, dt.Rows(x)("EDAD").ToString, dt.Rows(x)("APELLIDO_PATERNO").ToString, dt.Rows(x)("APELLIDO_MATERNO").ToString, dt.Rows(x)("NOMBRES").ToString, dt.Rows(x)("FECHA_INICIO").ToString, dt.Rows(x)("FECHA_CESE").ToString, dt.Rows(x)("DIAS").ToString, dt.Rows(x)("MESES").ToString, dt.Rows(x)("CARGO_OCUPACIÓN").ToString, (dt.Rows(x)("ASIGNACION_FAMILIAR1").ToString), CDbl(dt.Rows(x)("SUELDO_BASICO").ToString), CDbl(dt.Rows(x)("ASIGNACION_FAMILIAR2").ToString), dt.Rows(x)("OTROS").ToString, CDbl(dt.Rows(x)("TOTAL_REMUNERACIÓN").ToString), dt.Rows(x)("SNP").ToString, CDbl(dt.Rows(x)("SNP2").ToString), dt.Rows(x)("APF").ToString, CDbl(dt.Rows(x)("APORTE_OBLIGATORIO").ToString), CDbl(dt.Rows(x)("COMISIÓN_SOBRE").ToString), CDbl(dt.Rows(x)("PRIMA_SEGURO").ToString), CDbl(dt.Rows(x)("TOTAL_DESCUENTO").ToString), CDbl(dt.Rows(x)("REMUNERACION_NETA").ToString), CDbl(dt.Rows(x)("SALUD").ToString), CDbl(dt.Rows(x)("TOTAL_APORTES").ToString), txtEjercicio.Text, cboPeriodo.Text) = 0 Then
                    MsgBox("- Los Precios no se Importaron." & vbNewLine & "- Intentelo Nuevamente.", MsgBoxStyle.Information, "NARSISTEMAS")
                    Exit Sub
                End If


            Next




        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Function GetDataExcel(ByVal fileName As String, ByVal source As String) As DataTable

        Try
            'MsgBox(fileName)

            Using cnn As New OleDbConnection( _
                "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                "Extended Properties='Excel 8.0;HDR=Yes';" & _
                "Data Source=" & fileName)

                Dim sql As String = _
                    String.Format("SELECT * FROM [{0}]", source)

                Dim da As New OleDbDataAdapter(sql, cnn)

                Dim dt As New DataTable()

                da.Fill(dt)

                Return dt

            End Using

        Catch ex As Exception
            Throw

        End Try

    End Function


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub
End Class