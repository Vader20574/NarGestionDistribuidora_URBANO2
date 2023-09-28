


Public Class FrmReporteCobranzaXCli

    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)

    Dim ListaR, ListaR2 As New List(Of ReporteVentaE)

    Dim ListaRpt As New List(Of ReporteVentaE)
    Dim i As Int32
    Dim fechaini, fechahas As Date
    Dim rand As Integer

    Dim rand2 As Integer

    Dim dtrpt As New DataTable
    Dim CodVend As String = ""

    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String

    Dim TAB_DETALLE As DataTable

    Dim strconsul As String = ""


    Private Sub FrmReporteCobranza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As New DataTable

        Dim dt2 As New DataTable
        dt2 = CAyuda.ListarDatos("NSP_Select_Listado_Usuario2", codempresa, CodUsuario).Tables(0)
        Dim CodVend As String
        CodVend = dt2.Rows(0)(0)

        dt = CAyuda.ListarDatos("sp_listvendedor2", codempresa, CodVend).Tables(0)
        ListaV = LLenar(dt)
        lbvende1.DataSource = ListaV


        dt = CAyuda.ListarDatos("NSP_LISTAR_RUTA", codempresa, "%").Tables(0)
        ListaR = LLenar2(dt)
        lbruta1.DataSource = ListaR

        Me.dtpinicio.Value = Format(vFechaActual, "dd/MM/yyyy")
        Me.dtpfin.Value = Format(vFechaActual, "dd/MM/yyyy")

        '  CAyuda.CargarDataCombo(comboRuta, "NSP_LISTAR_RUTA '" & codempresa & "' ,'%' ", "CODIGO", "DESCRIPCION")


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



    Private Function LLenar2(ByVal dt As DataTable) As List(Of ReporteVentaE)
        Dim lista As New List(Of ReporteVentaE)
        For Each dr As DataRow In dt.Rows
            Dim o As New ReporteVentaE
            o.CODIGO = dr.Item(1).ToString
            o.DESCRIPCION = dr.Item(2).ToString
            lista.Add(o)
        Next
        Return lista
    End Function

    Private Sub btnpasdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasdet.Click
        For k As Integer = 0 To ListaV.Count - 1
            ListaV2.Add(ListaV.Item(k))
        Next
        ListaV.Clear()
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
                Me.lbruta1.DataSource = Nothing
                Me.lbruta2.DataSource = Nothing
                Me.lbruta1.DataSource = ListaR
                Me.lbruta2.DataSource = ListaR2
        End Select
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
        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))
        Next
        ListaV2.Clear()
        Actualizar(1)
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click


        If TextBox1.Text = "" Then
            MsgBox("TIENE Q INGRESAR UN CLIENTE")
            TextBox1.Focus()
            Exit Sub
        End If


        Dim Sql As String
        Sql = "DELETE  FROM TMP_VENDEDOR  "
        If TmpInsertDatos(Sql) = True Then
        End If

        strconsul = ""


        'For i As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1

        'Next

        ValorRan()

        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))

            Sql = "NSP_INSERT_TMP_VENDEDOR_REPORTE '" & codempresa & "','" & ListaV2.Item(k).CODIGO.ToString & "','" & rand & "'"
            If TmpInsertDatos(Sql) = True Then
            End If


            If strconsul.Length = 0 Then
                strconsul = "" & ListaV2.Item(k).DESCRIPCION.ToString & ""
            Else
                strconsul = strconsul & "," & ListaV2.Item(k).DESCRIPCION.ToString & ""
            End If

        Next



        For k As Integer = 0 To ListaR2.Count - 1
            ListaR.Add(ListaR2.Item(k))

            Sql = "NSP_INSERT_TMP_RUTA_REPORTE '" & codempresa & "','" & ListaR2.Item(k).CODIGO.ToString & "','" & rand & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next


        CargarGridDet()
        FormatoGridDet()

    End Sub


    Private Function VERIFICA_HISTORICOVENT(ByVal StrHistorico As String) As Boolean
        Try
            Dim StrSql As String
            Dim rs As New DataTable
            StrSql = " EXEC   VERIFICA_HISTORICOVENT    '" & StrHistorico & "','" & codempresa & "'"
            rs = TmpListarDatos(StrSql)

            If rs.Rows.Count = 0 Then
                VERIFICA_HISTORICOVENT = False
            Else
                VERIFICA_HISTORICOVENT = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " VERIFICA_HISTORICOVENT")
        End Try

    End Function



    Private Sub CargarGridDet()
        '  TAB_DETALLE = TmpListarDatos("SP_RPT_COBRANZA   '" & codempresa & "','" & VCorrelVta & "'")

        'If CheckBox2.Checked = False Then
        '    TAB_DETALLE = TmpListarDatos("SP_INSERT_COBRANZAXCLI '" & codempresa & "','" & dtpinicio.Value.ToString("dd/MM/yyyy") & "','" & Me.dtpfin.Value.ToString("dd/MM/yyyy") & "','" & comboRuta.SelectedValue & "','" & rand & "'")
        '    dgDetalleCobranza.DataSource = TAB_DETALLE
        'Else

        '    TAB_DETALLE = TmpListarDatos("SP_INSERT_COBRANZA2 '" & codempresa & "','" & dtpinicio.Value.ToString("dd/MM/yyyy") & "','" & Me.dtpfin.Value.ToString("dd/MM/yyyy") & "','" & comboRuta.SelectedValue & "','" & rand & "'")
        '    dgDetalleCobranza.DataSource = TAB_DETALLE
        'End If




        TmpInsertDatos("DELETE FROM TB_COBRANZA  WHERE CORREL='" & rand & "'")


        'Dim FechaIni, FechaFin As String
        'FechaIni = Format(CDate(dtpinicio.Value), "dd/MM/yyyy")
        'FechaFin = Format(CDate(dtpfin.Value), "dd/MM/yyyy")


        'nromeses = DateDiff("m", FechaIni, FechaFin)

        'For i As Integer = 0 To nromeses

        '    NomTablaC = "VENTC" & Format(DateAdd("m", i, FechaIni), "yyyyMM")
        '    NomTablaD = "VENTD" & Format(DateAdd("m", i, FechaIni), "yyyyMM")

        '    If VERIFICA_HISTORICOVENT(NomTablaC) = True Then
        '        TmpInsertDatos("SP_INSERT_COBRANZAXCLI '" & codempresa & "','" & dtpinicio.Value.ToString("dd/MM/yyyy") & "','" & Me.dtpfin.Value.ToString("dd/MM/yyyy") & "','" & comboRuta.SelectedValue & "','" & rand & "','" & TextBox1.Text & "','" & NomTablaC & "'")
        '    End If
        'Next

        TmpInsertDatos("SP_INSERT_COBRANZAXCLI '" & codempresa & "','" & dtpinicio.Value.ToString("dd/MM/yyyy") & "','" & Me.dtpfin.Value.ToString("dd/MM/yyyy") & "','" & comboRuta.SelectedValue & "','" & rand & "','" & TextBox1.Text & "',''")


        TAB_DETALLE = TmpListarDatos("SP_SELECT_COBRANZA '" & codempresa & "','" & rand & "'")
        dgDetalleCobranza.DataSource = TAB_DETALLE



    End Sub








    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Function ValorRanRuta() As Integer
        Dim rd As New Random
        rand2 = rd.Next() * 0.5
        Return rand2
    End Function


    Private Sub FormatoGridDet()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_DETALLE.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1

            .MappingName = "FECDOCUM"
            .HeaderText = "Fecha"
            .NullText = ""
            .Width = 75
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2

            .MappingName = "NRODOCU"
            .HeaderText = "Documento"

            .NullText = ""
            .Width = 75
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3

            .MappingName = "NOMBREDEP"
            .HeaderText = "Cliente"

            .NullText = ""
            .Width = 75
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4

            .MappingName = "PLAZO"
            .HeaderText = "Dias"

            .NullText = ""
            .Width = 75
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5

            .MappingName = "TOTCREDBAS"
            .HeaderText = "Total"

            .Alignment = HorizontalAlignment.Right
            .NullText = "0.00"
            .Width = 75
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6

            .MappingName = "PAGCREDBAS"
            .HeaderText = "Saldo"

            .Alignment = HorizontalAlignment.Right
            .NullText = "0.00"

            .Width = 75
        End With
        Dim Column7 As New DataGridTextBoxColumn
        With Column7

            .MappingName = "DIRECCIONDEP"
            .HeaderText = "Direccion"

            .NullText = ""
            .Width = 75
        End With

        Dim Column8 As New DataGridTextBoxColumn
        With Column8

            .MappingName = "CODCLIENTEPRI"
            .HeaderText = "ClientePr"


            .NullText = ""
            .Width = 100
        End With

        dgDetalleCobranza.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8})
        dgDetalleCobranza.TableStyles.Add(TableStyle1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If CheckBox4.Checked = True Then


            Try
                With AxCrystalReport1
                    .ReportFileName = RutaRptInv & "Rep_CobranzaXclientepr2.rpt"
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

                    .set_StoredProcParam(0, rand)
                    '.set_StoredProcParam(2, dtpfin.Value.ToString("dd/MM/yyyy"))


                    '.set_Formulas(0, "Empresa='" & strconsul & "'")

                    'If CheckBox1.Checked = False Then

                    '    .set_Formulas(0, "Empresa='" & strconsul & "'")
                    'Else

                    '    .set_Formulas(0, "Empresa='" & "Todos los vendedores" & "'")

                    'End If



                    '.set_Formulas(1, "Usuario='" & DesUsuario & "'")

                    '.set_StoredProcParam("@FECHAH", dtpfin.Value)
                    '.set_StoredProcParam(3, Me.comboRuta.SelectedValue)


                    .WindowState = Crystal.WindowStateConstants.crptMaximized
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Exit Sub


        End If







        If CheckBox3.Checked = True Then

            Try
                With AxCrystalReport1
                    .ReportFileName = RutaRptInv & "Rep_CobranzaXclientepr.rpt"
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

                    .set_StoredProcParam(0, rand)
                    '.set_StoredProcParam(2, dtpfin.Value.ToString("dd/MM/yyyy"))


                    '.set_Formulas(0, "Empresa='" & strconsul & "'")

                    'If CheckBox1.Checked = False Then

                    '    .set_Formulas(0, "Empresa='" & strconsul & "'")
                    'Else

                    '    .set_Formulas(0, "Empresa='" & "Todos los vendedores" & "'")

                    'End If



                    '.set_Formulas(1, "Usuario='" & DesUsuario & "'")

                    '.set_StoredProcParam("@FECHAH", dtpfin.Value)
                    '.set_StoredProcParam(3, Me.comboRuta.SelectedValue)


                    .WindowState = Crystal.WindowStateConstants.crptMaximized
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Exit Sub


        End If



        If CheckBox2.Checked = True Then

            Try
                With AxCrystalReport1
                    .ReportFileName = RutaRptInv & "Rpt_Cobranza2.rpt"
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                    .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                    .set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                    .set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                    .set_Formulas(4, "Proveedor='" & Me.comboRuta.Text & "'")
                    '.set_Formulas(5, "Tipo='" & Me.comboRuta.Text & "'")

                    '   TAB_DETALLE = TmpListarDatos("SP_RPT_COBRANZA '" & codempresa & "','" & dtpinicio.Value.ToString("dd/MM/yyyy") & "','" & Me.dtpfin.Value.ToString("dd/MM/yyyy") & "','" & comboRuta.SelectedValue & "'")

                    .set_StoredProcParam(0, codempresa)


                    .set_StoredProcParam(1, rand)
                    '.set_StoredProcParam(2, dtpfin.Value.ToString("dd/MM/yyyy"))


                    .set_Formulas(0, "Empresa='" & strconsul & "'")

                    If CheckBox1.Checked = False Then

                        .set_Formulas(0, "Empresa='" & strconsul & "'")
                    Else

                        .set_Formulas(0, "Empresa='" & "Todos los vendedores" & "'")

                    End If



                    .set_Formulas(1, "Usuario='" & DesUsuario & "'")

                    '.set_StoredProcParam("@FECHAH", dtpfin.Value)
                    '.set_StoredProcParam(3, Me.comboRuta.SelectedValue)


                    .WindowState = Crystal.WindowStateConstants.crptMaximized
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Exit Sub


        End If





        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Cobranza.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                .set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                .set_Formulas(4, "Proveedor='" & "" & "'")
                '.set_Formulas(5, "Tipo='" & Me.comboRuta.Text & "'")

                '   TAB_DETALLE = TmpListarDatos("SP_RPT_COBRANZA '" & codempresa & "','" & dtpinicio.Value.ToString("dd/MM/yyyy") & "','" & Me.dtpfin.Value.ToString("dd/MM/yyyy") & "','" & comboRuta.SelectedValue & "'")

                .set_StoredProcParam(0, codempresa)


                .set_StoredProcParam(1, rand)
                '.set_StoredProcParam(2, dtpfin.Value.ToString("dd/MM/yyyy"))


                .set_Formulas(0, "Empresa='" & strconsul & "'")

                If CheckBox1.Checked = False Then

                    .set_Formulas(0, "Empresa='" & strconsul & "'")
                Else

                    .set_Formulas(0, "Empresa='" & "Todos los vendedores" & "'")

                End If



                .set_Formulas(1, "Usuario='" & DesUsuario & "'")

                '.set_StoredProcParam("@FECHAH", dtpfin.Value)
                '.set_StoredProcParam(3, Me.comboRuta.SelectedValue)


                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos("DELETE FROM TB_COBRANZA  WHERE CORREL='" & rand & "' AND CODEMPRESA ='" & codempresa & "'")



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        For k As Integer = 0 To ListaR.Count - 1
            ListaR2.Add(ListaR.Item(k))
        Next
        ListaR.Clear()
        Actualizar(2)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        i = Me.lbruta1.SelectedIndex
        If i < 0 Then Exit Sub
        ListaR2.Add(ListaR.Item(i))
        ListaR.RemoveAt(i)
        Actualizar(2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        i = Me.lbruta2.SelectedIndex
        If i < 0 Then Exit Sub
        ListaR.Add(ListaR2.Item(i))
        ListaR2.RemoveAt(i)
        Actualizar(2)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For k As Integer = 0 To ListaR2.Count - 1
            ListaR.Add(ListaR2.Item(k))
        Next
        ListaR2.Clear()
        Actualizar(2)
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim sql As String


        TmpInsertDatos("DELETE FROM TMP_VTAPROM3")
        TmpInsertDatos("DELETE FROM TMP_VTASUMTOTBAS")
        TmpInsertDatos("DELETE FROM TMP_VTASUMPORCE")

        TAB_DETALLE = TmpListarDatos("SP_SELECTXCLIENTE '" & codempresa & "'")

        If TAB_DETALLE.Rows.Count > 0 Then
            For X As Integer = 0 To TAB_DETALLE.Rows.Count - 1
                sql = "NSP_INSERT_TMP_VTAPROM4 '" & codempresa & "','" & TAB_DETALLE.Rows(X)(0).ToString & "','" & TAB_DETALLE.Rows(X)(1).ToString & "'"
                If TmpInsertDatos(sql) = True Then
                End If

                sql = "NSP_INSERT_TMP_VTASUMTOTBAS '" & codempresa & "','" & TAB_DETALLE.Rows(X)(0).ToString & "','" & TAB_DETALLE.Rows(X)(1).ToString & "'"
                If TmpInsertDatos(sql) = True Then
                End If

                sql = "NSP_INSERT_TMP_VTASUMPORCE '" & codempresa & "','" & TAB_DETALLE.Rows(X)(0).ToString & "','" & TAB_DETALLE.Rows(X)(1).ToString & "'"
                If TmpInsertDatos(sql) = True Then
                End If
            Next
        End If

        sql = "SP_INSERT_TABLA_VP_DPP '" & 1234 & "','" & codempresa & "'"
        If TmpInsertDatos(sql) = True Then
            MsgBox("Se actualizo Correctamente")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class