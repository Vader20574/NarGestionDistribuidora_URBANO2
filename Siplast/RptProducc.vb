Public Class RptProducc

    Dim rand As Integer
    Dim dtrpt As New DataTable
    Dim CodVend As String = ""

    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String

    Dim TAB_DETALLE As DataTable

    Dim fechaini, fechahas As Date

    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)

    Dim i As Integer
    Private Sub RptAnalisisCobro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'CargaCombo()
        ValorRan()



        Dim dt As New DataTable

        dt = CAyuda.ListarDatos("LISTAR_MAQUINA").Tables(0)
        ListaV = LLenar(dt)
        lbvende1.DataSource = ListaV

    End Sub
    Private Function LLenar(ByVal dt As DataTable) As List(Of ReporteVentaE)
        Dim lista As New List(Of ReporteVentaE)
        For Each dr As DataRow In dt.Rows
            Dim o As New ReporteVentaE
            o.CODIGO = dr.Item(0).ToString
            o.DESCRIPCION = dr.Item(1).ToString
            lista.Add(o)
        Next
        Return lista
    End Function

    Private Sub CargaCombo()
        'Conecta("SELECT T.[CODTIPODOC], T.[DSTIPODOC] FROM TIPODOC T WHERE T.[CODEMPRESA]='" & codempresa & "'", "d")
        'Dim TablaTemp As New DataTable
        'TablaTemp = ds.Tables("d")
        'Me.cbTipoDoc.DisplayMember = "DSTIPODOC"
        'Me.cbTipoDoc.ValueMember = "CODTIPODOC"
        'Me.cbTipoDoc.DataSource = TablaTemp




    End Sub

    Private Sub txtNroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)



    End Sub

    Private Sub txtNroDoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub




    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub FormatoGridDet()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_DETALLE.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1

            .MappingName = "Fecha"
            .HeaderText = "FECHA"
            .NullText = ""
            .Width = 75
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2

            .MappingName = "TPLANILLA"
            .HeaderText = "TIPO PLLA"

            .NullText = ""
            .Width = 150
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3

            .MappingName = "NROPLANILLA"
            .HeaderText = "PLLA"

            .NullText = ""
            .Width = 75
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4

            .MappingName = "IMPORTE"
            .HeaderText = "IMPORTE"

            .NullText = ""
            .Width = 75
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5

            .MappingName = "NOMCOBRADOR"
            .HeaderText = "COBRADOR"

            .Alignment = HorizontalAlignment.Right
            .NullText = ""
            .Width = 250
        End With

        dgDetalleCobranza.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5})
        dgDetalleCobranza.TableStyles.Add(TableStyle1)

    End Sub





    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FormatoGridDet()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        FormatoGridDet()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim SQL As String
        SQL = "DELETE_TMP_MAQUINA "
        If TmpInsertDatos(SQL) = True Then
        End If



        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))

            SQL = "INSERT_TMP_MAQUINA '" & ListaV2.Item(k).CODIGO.ToString & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next



        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")


        TAB_DETALLE = TmpListarDatos("NSP_INSERT_PRODUCCION '" & codempresa & "','" & rand & "','" & fechaini & "','" & fechahas & "'")
        dgDetalleCobranza.DataSource = TAB_DETALLE


        Reporte()
       




    End Sub



    Sub Reporte()
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "RptProduccionFiltro.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"


                .set_StoredProcParam(0, rand)


                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos("DELETE FROM TMP_ORDEN_COMPRA  WHERE CORREL='" & rand & "'")

    End Sub



    Sub Reporte2()
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_AnalisisPlanilla2.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"


                .set_StoredProcParam(0, rand)


                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos("DELETE FROM TMP_ANALIS_PLANILLA  WHERE CORREL='" & rand & "'")

    End Sub


    Private Sub btnpasdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasdet.Click
        For k As Integer = 0 To ListaV.Count - 1
            ListaV2.Add(ListaV.Item(k))
        Next
        ListaV.Clear()
        Actualizar(1)
    End Sub

    Private Sub btnpasde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasde.Click
        i = Me.lbvende1.SelectedIndex
        If i < 0 Then Exit Sub
        ListaV2.Add(ListaV.Item(i))
        ListaV.RemoveAt(i)
        Actualizar(1)
    End Sub

    Private Sub btnpassiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpassiz.Click
        i = Me.lbvende2.SelectedIndex
        If i < 0 Then Exit Sub
        ListaV.Add(ListaV2.Item(i))
        ListaV2.RemoveAt(i)
        Actualizar(1)
    End Sub

    Private Sub btnpassizt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpassizt.Click
        i = Me.lbvende2.SelectedIndex
        If i < 0 Then Exit Sub
        ListaV.Add(ListaV2.Item(i))
        ListaV2.RemoveAt(i)
        Actualizar(1)
    End Sub


    Private Sub Actualizar(ByVal a As Int16)
        Select Case a
            Case 0
                'Me.lbfuerza1.DataSource = Nothing
                'Me.lbfuerza2.DataSource = Nothing
                'Me.lbfuerza1.DataSource = ListaF
                'Me.lbfuerza2.DataSource = ListaF2
            Case 1
                Me.lbvende1.DataSource = Nothing
                Me.lbvende2.DataSource = Nothing
                Me.lbvende1.DataSource = ListaV
                Me.lbvende2.DataSource = ListaV2
            Case 2

        End Select
    End Sub

End Class