



Public Class FrmVendedoresComision
    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)
    Dim i As Int32
    Dim rand As Integer
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String
    Dim fechaini, fechahas As Date


    Private Sub FrmVendedoresComision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable

        dt = CAyuda.ListarDatos("sp_listvendedor", codempresa).Tables(0)
        ListaV = LLenar(dt)
        lbvende1.DataSource = ListaV

        ValorRan()

    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
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

    Private Sub btnmostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrar.Click

        CAyuda.Ejecutar("SP_RPT_VENT_DEL", rand)

        For a As Integer = 0 To Me.ListaV2.Count - 1
            CAyuda.Ejecutar("SP_RPT_VENT_CONDI", rand, "CODVEND", ListaV2.Item(a).CODIGO)
        Next

        Up_Fechas()
        CAyuda.Ejecutar("SP_INSERT_SUBLINEASXVENDEDOR", rand, fechaini.ToShortDateString, fechahas.ToShortDateString)

        CAyuda.Ejecutar("SP_INS_TMP_CUOTAS", rand, fechaini.ToShortDateString, fechahas.ToShortDateString)


        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_EX WHERE CORREL='" + rand.ToString + "'")

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 1)
            End If
            CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 0)
        Next


        Up_Fechas()
        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_PRODUCTO WHERE CORREL=" + rand.ToString)
        TmpInsertDatos("DELETE FROM TMP_PROD_COMISION WHERE CORREL=" + rand.ToString)

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_PROD_COMISION", rand, codempresa, 0, fechaini, fechahas, 0, 0, NomTablaC, NomTablaD, 1)
            End If
        Next

        CAyuda.Ejecutar("SP_RPT_VENT_PROD_COMISION", rand, codempresa, 0, fechaini, fechahas, 0, 0, NomTablaC, NomTablaD, 0)



        CAyuda.Ejecutar("SP_COMISIONVENTAS", rand)

        Dim cantdias As Integer
        Dim Tabla As DataTable
        Tabla = CAyuda.ListarDatos("SP_EXTRAER_DIASINDOMINGOS", fechaini.ToShortDateString, fechahas.ToShortDateString).Tables(0)
        If Tabla.Rows.Count Then
            cantdias = Tabla.Rows(0)(0).ToString + 1
        End If


        Dim ultimo_dia_mes As Integer
        Dim Tabla1 As DataTable
        Tabla1 = CAyuda.ListarDatos("SP_ULTIMODIAMES", fechaini.ToShortDateString).Tables(0)
        If Tabla.Rows.Count Then
            ultimo_dia_mes = Tabla1.Rows(0)(0).ToString
        End If



        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_VendedoresComision.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                '.set_Formulas(2, "FechaIni='" & fechaini.ToShortDateString & "'")
                '.set_Formulas(3, "FechaH='" & fechahas.ToShortDateString & "'")

                .set_StoredProcParam(0, rand)
                .set_StoredProcParam(1, cantdias)
                .set_StoredProcParam(2, ultimo_dia_mes)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Sub Up_Fechas()
        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")
        nromeses = DateDiff("m", fechaini, fechahas)
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CAyuda.Ejecutar("SP_RPT_VENT_DEL", rand)

        For a As Integer = 0 To Me.ListaV2.Count - 1
            CAyuda.Ejecutar("SP_RPT_VENT_CONDI", rand, "CODVEND", ListaV2.Item(a).CODIGO)
        Next

        Up_Fechas()
        CAyuda.Ejecutar("SP_INSERT_SUBLINEASXVENDEDOR_XPROD", rand, fechaini.ToShortDateString, fechahas.ToShortDateString)

        CAyuda.Ejecutar("SP_INS_TMP_CUOTASXPROD", rand, fechaini.ToShortDateString, fechahas.ToShortDateString)


        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_EX WHERE CORREL='" + rand.ToString + "'")

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_EX_XPROD", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 1)
            End If
            CAyuda.Ejecutar("SP_RPT_VENT_EX_XPROD", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 0)
        Next


        Up_Fechas()
        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_PRODUCTO WHERE CORREL=" + rand.ToString)

        TmpInsertDatos("DELETE FROM TMP_PROD_COMISION WHERE CORREL=" + rand.ToString)

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_PROD_COMISION", rand, codempresa, 0, fechaini, fechahas, 0, 0, NomTablaC, NomTablaD, 1)
            End If
        Next

        CAyuda.Ejecutar("SP_RPT_VENT_PROD_COMISION", rand, codempresa, 0, fechaini, fechahas, 0, 0, NomTablaC, NomTablaD, 0)


        CAyuda.Ejecutar("SP_COMISIONVENTASXPROD", rand)

        Dim cantdias As Integer
        Dim Tabla As DataTable
        Tabla = CAyuda.ListarDatos("SP_EXTRAER_DIASINDOMINGOS", fechaini.ToShortDateString, fechahas.ToShortDateString).Tables(0)
        If Tabla.Rows.Count Then

            cantdias = Tabla.Rows(0)(0).ToString + 1

        End If


        Dim cantdias_total As Integer = 0
        Dim cantdias_hoy As Integer
        Dim Tabla1 As DataTable
        Tabla1 = CAyuda.ListarDatos("SP_EXTRAER_DIASINDOMINGOS", fechaini.ToShortDateString, vFechaActual).Tables(0)
        If Tabla.Rows.Count Then
            cantdias_hoy = Tabla1.Rows(0)(0).ToString + 1
        End If



        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_VendedoresComisionxProd.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                '.set_Formulas(2, "FechaIni='" & fechaini.ToShortDateString & "'")
                '.set_Formulas(3, "FechaH='" & fechahas.ToShortDateString & "'")

                .set_StoredProcParam(0, rand)
                .set_StoredProcParam(1, cantdias)
                .set_StoredProcParam(2, cantdias_hoy)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        CAyuda.Ejecutar("SP_RPT_VENT_DEL", rand)

        For a As Integer = 0 To Me.ListaV2.Count - 1
            CAyuda.Ejecutar("SP_RPT_VENT_CONDI", rand, "CODVEND", ListaV2.Item(a).CODIGO)
        Next

        Up_Fechas()
        CAyuda.Ejecutar("SP_INSERT_SUBLINEASXVENDEDOR", rand, fechaini.ToShortDateString, fechahas.ToShortDateString)

        CAyuda.Ejecutar("SP_INS_TMP_CUOTAS", rand, fechaini.ToShortDateString, fechahas.ToShortDateString)


        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_EX WHERE CORREL='" + rand.ToString + "'")

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 1)
            End If
            CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 0)
        Next


        Up_Fechas()
        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_PRODUCTO WHERE CORREL=" + rand.ToString)
        TmpInsertDatos("DELETE FROM TMP_PROD_COMISION WHERE CORREL=" + rand.ToString)

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_PROD_COMISION", rand, codempresa, 0, fechaini, fechahas, 0, 0, NomTablaC, NomTablaD, 1)
            End If
        Next

        CAyuda.Ejecutar("SP_RPT_VENT_PROD_COMISION", rand, codempresa, 0, fechaini, fechahas, 0, 0, NomTablaC, NomTablaD, 0)



        CAyuda.Ejecutar("SP_COMISIONVENTAS", rand)

        Dim cantdias As Integer
        Dim Tabla As DataTable
        Tabla = CAyuda.ListarDatos("SP_EXTRAER_DIASINDOMINGOS", fechaini.ToShortDateString, fechahas.ToShortDateString).Tables(0)
        If Tabla.Rows.Count Then
            cantdias = Tabla.Rows(0)(0).ToString + 1
        End If


        Dim ultimo_dia_mes As Integer
        Dim Tabla1 As DataTable
        Tabla1 = CAyuda.ListarDatos("SP_ULTIMODIAMES", fechaini.ToShortDateString).Tables(0)
        If Tabla.Rows.Count Then
            ultimo_dia_mes = Tabla1.Rows(0)(0).ToString
        End If



        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_VendedoresComisionSin.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                '.set_Formulas(2, "FechaIni='" & fechaini.ToShortDateString & "'")
                '.set_Formulas(3, "FechaH='" & fechahas.ToShortDateString & "'")

                .set_StoredProcParam(0, rand)
                .set_StoredProcParam(1, cantdias)
                .set_StoredProcParam(2, ultimo_dia_mes)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class