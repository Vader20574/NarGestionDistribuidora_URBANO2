
Public Class frmRptVentas2
    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)
    Dim ListaRpt As New List(Of ReporteVentaE)
    Dim i As Int32
    Dim fechaini, fechahas As Date
    Dim rand As Integer
    Dim dtrpt As New DataTable
    Dim CodVend As String = ""

    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String



    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable

    Dim TAB_DETALLE As DataTable



    Private Sub frmRptVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        'dt = CAyuda.ListarDatos("NSP_LISTA_FUERZA_VTA", codempresa).Tables(0)
        dt = CAyuda.ListarDatos("NSP_LISTA_FUERZA_VTA", codempresa).Tables(0)
        Dim dr As DataRow
        dr = dt.NewRow
        dr.Item(0) = ""
        dr.Item(1) = "<< TODOS >>"
        dt.Rows.InsertAt(dr, 0)

        Me.cmbfuerza.DataSource = dt
        Me.cmbfuerza.DisplayMember = "DESCRIPCION"
        Me.cmbfuerza.ValueMember = "CODIGO"

        'CAyuda.CargarDataCombo(Me.cmbfuerza, "NSP_LISTA_FUERZA_VTA " & "'" & codempresa & "'", "CODIGO", "DESCRIPCION")

        'ListaF = LLenar(dt)
        'lbfuerza1.DataSource = ListaF

        dt = New DataTable
        dt = CAyuda.ListarDatos("NSP_LISTAR_RUTA_1", codempresa).Tables(0)
        dr = dt.NewRow
        dr.Item(0) = ""
        dr.Item(1) = "<< TODOS >>"
        dt.Rows.InsertAt(dr, 0)

        Me.cmbruta.DataSource = dt
        Me.cmbruta.DisplayMember = "DESCRIPCION"
        Me.cmbruta.ValueMember = "CODIGO"


        'dt = CAyuda.ListarDatos("NSP_LISTAR_RUTA_1", codempresa).Tables(0)
        'CAyuda.CargarDataCombo(Me.cmbruta, "NSP_LISTAR_RUTA_1 " & "'" & codempresa & "'", "CODIGO", "DESCRIPCION")
        'ListaR = LLenar(dt)
        'lbruta1.DataSource = ListaR


        Dim dt2 As New DataTable
        dt2 = CAyuda.ListarDatos("NSP_Select_Listado_Usuario2", codempresa, CodUsuario).Tables(0)
        Dim CodVend As String
        CodVend = dt2.Rows(0)(0)
        dt = CAyuda.ListarDatos("sp_listvendedor2", codempresa, CodVend).Tables(0)
        ListaV = LLenar(dt)
        lbvende1.DataSource = ListaV

        ValorRan()


        Tb_RutaDisponible = TmpListarDatos("Nsp_Sele_RUTA '','','" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("Nsp_Sele_RUTA '','','" & 254 & "'")

        CargarModulo()





    End Sub


    Private Sub CargarModulo()

        LstDispRuta.DataSource = Tb_RutaDisponible
        LstDispRuta.ValueMember = "Codigo"
        LstDispRuta.DisplayMember = "Descripcion"

        LstSelecRuta.DataSource = Tb_RutaModSelec
        LstSelecRuta.ValueMember = "Codigo"
        LstSelecRuta.DisplayMember = "Descripcion"


    End Sub



    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function
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

    Private Sub btnpasdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasdet.Click
        For k As Integer = 0 To ListaV.Count - 1
            ListaV2.Add(ListaV.Item(k))
        Next
        ListaV.Clear()
        Actualizar(1)
    End Sub

    Private Sub btnpassizt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpassizt.Click
        For k As Integer = 0 To ListaV2.Count - 1
            ListaV.Add(ListaV2.Item(k))
        Next
        ListaV2.Clear()
        Actualizar(1)
    End Sub

    Sub Up_Fechas()
        fechaini = String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy")
        fechahas = String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy")
        nromeses = DateDiff("m", fechaini, fechahas)
    End Sub


    Private Sub btnmostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrar.Click



        Dim Sql As String

        Sql = "DELETE  FROM TMP_RUTA7 WHERE CORREL='" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If


        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_RUTA7 '" & rand & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next







        If Not fechaini <= fechahas And fechaini >= fechahas Then
            MsgBox("- Fechas fuera de Rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If


        CAyuda.Ejecutar("SP_RPT_VENT_DEL", rand)

        For a As Integer = 0 To Me.ListaV2.Count - 1
            CAyuda.Ejecutar("SP_RPT_VENT_CONDI", rand, "CODVEND", ListaV2.Item(a).CODIGO)
        Next
        ListaRpt.Clear()

        Up_Fechas()



        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_EX WHERE CORREL='" + rand.ToString + "'")
        For i = 0 To Nromeses

            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 1)
            End If
        Next
        CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 0)

        dtrpt = New DataTable
        dtrpt = CAyuda.ListarDatos("SP_RPT_SELECT_VENTAS_EX2", rand, codempresa, Me.cmbfuerza.SelectedValue.ToString, Me.cmbruta.SelectedValue.ToString, fechaini, fechahas).Tables(0)
        dgvcategoria.DataSource = dtrpt

        Reporte("Rpt_AvanceVentas.rpt")



        Dim TB_BUSQCLIDEP As DataTable

        TB_BUSQCLIDEP = TmpListarDatos("SP_TOTALVENTA '" & rand & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then
            Label5.Text = TB_BUSQCLIDEP.Rows(0)(0).ToString()
        End If




    End Sub




    Private Sub Llenar_Grid(ByVal o As Object)
        Me.dgvcategoria.DataSource = Nothing
        Me.dgvcategoria.DataSource = o
    End Sub

    Private Sub cmbruta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbruta.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbruta.SelectedIndex = -1

        End If
    End Sub

    Private Sub cmbfuerza_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbfuerza.KeyDown
        If e.KeyCode = Keys.Delete Then
            Me.cmbfuerza.SelectedIndex = -1
        End If
    End Sub

    Private Sub frmRptVentas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        CAyuda.Ejecutar("SP_CLEAN_RPT", rand)
    End Sub

    Private Sub DetallePorDocToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetallePorDocToolStripMenuItem.Click
        Up_Fechas()
        TmpInsertDatos("DELETE FROM TMP_RPT_VENTAS_REPORTE WHERE CORREL=" + rand.ToString)

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.ListarDatos("SP_RPT_VENT", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 1)
            End If
        Next
        CAyuda.ListarDatos("SP_RPT_VENT", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 0)
        Reporte("Rpt_Ventas_Detalle_doc.rpt")
    End Sub

    Sub Reporte(ByVal rpt As String)

        Dim var1, var2 As String
        If cmbfuerza.SelectedIndex = -1 Then
            var1 = "Todos"
        Else
            var1 = cmbfuerza.Text
        End If

        If cmbruta.SelectedIndex = -1 Then
            var2 = "Todos"
        Else
            var2 = cmbruta.Text
        End If
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & rpt
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & fechaini.ToShortDateString & "'")
                .set_Formulas(3, "FechaH='" & fechahas.ToShortDateString & "'")
                .set_Formulas(4, "Fuerza='" & var1 & "'")
                .set_Formulas(5, "Ruta='" & var2 & "'")
                .set_StoredProcParam(0, rand.ToString())
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DetalladoPorProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetalladoPorProductosToolStripMenuItem.Click
        Up_Fechas()
        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_PRODUCTO WHERE CORREL=" + rand.ToString)

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_PROD", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 1)
            End If
        Next

        CAyuda.Ejecutar("SP_RPT_VENT_PROD", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 0)
        Reporte("Rpt_Ventas_Detalle_producto.rpt")

    End Sub

    Private Sub EfectividadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EfectividadToolStripMenuItem.Click
        Up_Fechas()
        TmpInsertDatos("DELETE FROM TMP_RPT_REPO_EFECTIVID WHERE CORREL=" + rand.ToString)

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_EFECTIVIDAD", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 1)
            End If
        Next

        CAyuda.Ejecutar("SP_RPT_VENT_EFECTIVIDAD", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 0)
        Reporte("Rpt_Ventas_efectividad.rpt")
    End Sub

    Private Sub dgvcategoria_DataBindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvcategoria.DataBindingComplete
        If Me.dgvcategoria.Rows.Count = 0 Then
            Me.ContextMenuStrip1.Enabled = False
        Else
            Me.ContextMenuStrip1.Enabled = True

        End If
    End Sub

    Private Sub dgvcategoria_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvcategoria.CellContentClick

    End Sub

    Private Sub BtnPasaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno_Ruta.Click
        PasarUno_Ruta()
    End Sub


    Private Sub PasarUno_Ruta()
        If Tb_RutaDisponible.Rows.Count > 0 Then

            Dim FILA As DataRow = Tb_RutaModSelec.NewRow
            FILA("Codigo") = LstDispRuta.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstDispRuta.Text.Trim
            Tb_RutaModSelec.Rows.Add(FILA)

            For F As Integer = 0 To Tb_RutaDisponible.Rows.Count - 1
                If LstDispRuta.SelectedValue.ToString.Trim = Tb_RutaDisponible.Rows(F)("Codigo").ToString.Trim Then
                    Tb_RutaDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub PasarTodo_Ruta()

        For F As Integer = 0 To Tb_RutaDisponible.Rows.Count - 1
            Dim FILA As DataRow = Tb_RutaModSelec.NewRow
            FILA("Codigo") = Tb_RutaDisponible.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_RutaDisponible.Rows(F)("Descripcion").ToString.Trim
            Tb_RutaModSelec.Rows.Add(FILA)
        Next
        Tb_RutaDisponible.Rows.Clear()
    End Sub


    Private Sub QuitarUno_Ruta()
        If Tb_RutaModSelec.Rows.Count > 0 Then
            Dim FILA As DataRow = Tb_RutaDisponible.NewRow
            FILA("Codigo") = LstSelecRuta.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstSelecRuta.Text.Trim
            Tb_RutaDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
                If LstSelecRuta.SelectedValue.ToString.Trim = Tb_RutaModSelec.Rows(F)("Codigo").ToString.Trim Then
                    Tb_RutaModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub QuitarTodo_Ruta()

        For F As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Dim FILA As DataRow = Tb_RutaDisponible.NewRow
            FILA("Codigo") = Tb_RutaModSelec.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_RutaModSelec.Rows(F)("Descripcion").ToString.Trim
            Tb_RutaDisponible.Rows.Add(FILA)
        Next
        Tb_RutaModSelec.Rows.Clear()

    End Sub




    Private Sub BtnPasaTodo_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo_Ruta.Click
        PasarTodo_Ruta()
    End Sub

    Private Sub BtnQuitaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno_Ruta.Click
        QuitarUno_Ruta()
    End Sub

    Private Sub BtnQuitaTodo_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo_Ruta.Click
        QuitarTodo_Ruta()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Sql As String

        Sql = "DELETE  FROM TMP_RUTA7 WHERE CORREL='" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If


        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_RUTA7 '" & rand & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next







        If Not fechaini <= fechahas And fechaini >= fechahas Then
            MsgBox("- Fechas fuera de Rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If


        CAyuda.Ejecutar("SP_RPT_VENT_DEL", rand)

        For a As Integer = 0 To Me.ListaV2.Count - 1
            CAyuda.Ejecutar("SP_RPT_VENT_CONDI", rand, "CODVEND", ListaV2.Item(a).CODIGO)
        Next
        ListaRpt.Clear()

        Up_Fechas()



        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_EX WHERE CORREL='" + rand.ToString + "'")
        For i = 0 To nromeses

            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 1)
            End If
        Next
        CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 0)

        dtrpt = New DataTable
        dtrpt = CAyuda.ListarDatos("SP_RPT_SELECT_VENTAS_EX2", rand, codempresa, Me.cmbfuerza.SelectedValue.ToString, Me.cmbruta.SelectedValue.ToString, fechaini, fechahas).Tables(0)
        dgvcategoria.DataSource = dtrpt

        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")

        TAB_DETALLE = TmpListarDatos("NSP_ANALISIS_PLANILLA '" & codempresa & "','" & rand & "','" & fechaini & "','" & fechahas & "'")
        TAB_DETALLE = TmpListarDatos("SP_INSERT_COBRANZA_V '" & codempresa & "','" & "01/01/2000" & "','" & Me.dtpfin.Value.ToString("dd/MM/yyyy") & "','" & "" & "','" & rand & "'")

        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Cuadre_Ventas6.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & fechaini.ToShortDateString & "'")
                .set_Formulas(3, "FechaH='" & fechahas.ToShortDateString & "'")

                .set_StoredProcParam(0, rand)
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