Public Class FrmReporteCompra


    Dim rand As Integer
    Dim fechaini, fechahas As Date
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String

    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)
    Dim i As Int32


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtEjercicio.Text = Date.Now.Year


        CAyuda.CargarDataCombo(cmbdocu, "ListarCOMPROBANTESxProcJ '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")



        Dim dt2 As New DataTable

        dt2 = CAyuda.ListarDatos("ListarCOMPROBANTESxProcJ2", codempresa, 1).Tables(0)
        ListaV = LLenar(dt2)
        lbvende1.DataSource = ListaV



        Dim dt As New DataTable



        dt = CAyuda.ListarDatos("USP_CONSULTAR_PROVEEDORJ", "", "", codempresa).Tables(0)
        Me.cmbproveedor.DataSource = dt
        Me.cmbproveedor.DisplayMember = "DESPROVEEDOR"
        Me.cmbproveedor.ValueMember = "CODPROVEEDOR"
        ValorRan()



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
                'Me.lbruta1.DataSource = Nothing
                'Me.lbruta2.DataSource = Nothing
                'Me.lbruta1.DataSource = ListaR
                'Me.lbruta2.DataSource = ListaR2
        End Select
    End Sub




    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")

        If fechaini > fechahas Then
            MsgBox("Fecha fuera de Rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        If ListaV2.Count = 0 Then
            MsgBox("No hay documentos disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        TmpInsertDatos("DELETE FROM tmp_docu_reporte  WHERE CORREL='" & rand & "'")

        Dim Sql As String
        For k As Integer = 0 To ListaV2.Count - 1
            'ListaV.Add(ListaV2.Item(k))
            Sql = "NSP_INSERT_TMP_DOCU_REPORTE '" & codempresa & "','" & ListaV2.Item(k).CODIGO.ToString & "','" & rand & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        TmpInsertDatos("DELETE FROM TMP_RPT_REPOR_SUNA  WHERE CORREL='" & rand & "'")

        If RbFecha1.Checked = True Then

            nromeses = DateDiff("m", fechaini, fechahas)

            For i As Integer = 0 To nromeses
                NomTablaC = "MOVIC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
                NomTablaD = "MOVID" & Format(DateAdd("m", i, fechaini), "yyyyMM")
                If CAyuda.ListarDatos("SP_VERIFICA_HISTOMOVI", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                    CAyuda.Ejecutar("SP_RPT_COMP_SU", rand, codempresa, Me.cmbproveedor.SelectedValue.ToString(), "", fechaini, fechahas, VCODINGCOMP, NomTablaC, NomTablaD, 1)
                End If
            Next

            CAyuda.Ejecutar("SP_RPT_COMP_SU", rand, codempresa, Me.cmbproveedor.SelectedValue.ToString(), "", fechaini, fechahas, VCODINGCOMP, NomTablaC, NomTablaD, 0)

            Try
                With AxCrystalReport1
                    .ReportFileName = RutaRptInv & "Rpt_Compra_Sunar.rpt"
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                    .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                    .set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                    .set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                    .set_Formulas(4, "Proveedor='" & Me.cmbproveedor.Text & "'")
                    .set_Formulas(5, "Tipo='" & Me.cmbdocu.Text & "'")
                    .set_StoredProcParam(0, rand)
                    .set_StoredProcParam(1, cmbdocu.SelectedValue)
                    .set_StoredProcParam(2, cmbproveedor.SelectedValue)

                    .WindowState = Crystal.WindowStateConstants.crptMaximized
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If RbFecha2.Checked = True Then
            Dim MES As String = ""

            Select Case cboPeriodo.Text
                Case "ENERO"
                    MES = "01"
                Case "FEBRERO"
                    MES = "02"
                Case "MARZO"
                    MES = "03"
                Case "ABRIL"
                    MES = "04"
                Case "MAYO"
                    MES = "05"
                Case "JUNIO"
                    MES = "06"
                Case "JULIO"
                    MES = "07"
                Case "AGOSTO"
                    MES = "08"
                Case "SEPTIEMBRE"
                    MES = "09"
                Case "OCTUBRE"
                    MES = "10"
                Case "NOVIEMBRE"
                    MES = "11"
                Case "DICIEMBRE"
                    MES = "12"
            End Select


            NomTablaC = "MOVIC" & txtEjercicio.Text & MES
            NomTablaD = "MOVID" & txtEjercicio.Text & MES
                If CAyuda.ListarDatos("SP_VERIFICA_HISTOMOVI", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                    CAyuda.Ejecutar("SP_RPT_COMP_SU_2", rand, codempresa, Me.cmbproveedor.SelectedValue.ToString(), "", txtEjercicio.Text, cboPeriodo.Text, VCODINGCOMP, NomTablaC, NomTablaD, 1)
                End If


            CAyuda.Ejecutar("SP_RPT_COMP_SU_2", rand, codempresa, Me.cmbproveedor.SelectedValue.ToString(), "", txtEjercicio.Text, cboPeriodo.Text, VCODINGCOMP, NomTablaC, NomTablaD, 0)


            Try
                With AxCrystalReport1
                    .ReportFileName = RutaRptInv & "Rpt_Compra_Sunar2.rpt"
                    .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                    .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                    .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                    .set_Formulas(2, "FechaIni='" & txtEjercicio.Text & "'")
                    .set_Formulas(3, "FechaH='" & cboPeriodo.Text & "'")
                    .set_Formulas(4, "Proveedor='" & Me.cmbproveedor.Text & "'")
                    .set_Formulas(5, "Tipo='" & Me.cmbdocu.Text & "'")
                    .set_StoredProcParam(0, rand)
                    .set_StoredProcParam(1, cmbdocu.SelectedValue)
                    .set_StoredProcParam(2, cmbproveedor.SelectedValue)

                    .WindowState = Crystal.WindowStateConstants.crptMaximized
                    .Destination = Crystal.DestinationConstants.crptToWindow
                    .Action = 1
                    .Reset()
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If


        TmpInsertDatos("DELETE FROM TMP_RPT_REPOR_SUNA  WHERE CORREL='" & rand & "'")
        TmpInsertDatos("DELETE FROM tmp_docu_reporte  WHERE CORREL='" & rand & "'")
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
        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))
        Next
        ListaV2.Clear()
        Actualizar(1)
    End Sub
End Class