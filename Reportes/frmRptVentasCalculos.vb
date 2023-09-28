
Imports CapaCliente.Reportes

Public Class frmRptVentasCalculos
    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)
    Dim ListaRpt As New List(Of ReporteVentaE)
    Dim i As Int32
    Dim fechaini, fechahas As Date
    Dim rand As Integer
    Dim dtrpt As New DataTable
    Dim CodVend As String = ""

    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String
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
        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")
        nromeses = DateDiff("m", fechaini, fechahas)
    End Sub


    Private Sub btnmostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrar.Click
        Up_Fechas()

        If fechaini > fechahas Then
            MsgBox("- Fechas fuera de Rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If


        CAyuda.Ejecutar("SP_RPT_VENT_DEL", rand)

        For a As Integer = 0 To Me.ListaV2.Count - 1
            CAyuda.Ejecutar("SP_RPT_VENT_CONDI", rand, "CODVEND", ListaV2.Item(a).CODIGO)
        Next
        ListaRpt.Clear()


        TmpInsertDatos("DELETE FROM TMP_RPT_VENT_EX WHERE CORREL='" + rand.ToString + "'")
        For i = 0 To nromeses

            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")

            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 1)
            End If
            CAyuda.Ejecutar("SP_RPT_VENT_EX", rand, codempresa, fechaini.ToShortDateString, fechahas.ToShortDateString, NomTablaD, NomTablaC, 0)
        Next

        dtrpt = New DataTable
        dtrpt = CAyuda.ListarDatos("SP_RPT_SELECT_VENTAS_EXCAL", rand, codempresa, Me.cmbfuerza.SelectedValue.ToString, Me.cmbruta.SelectedValue.ToString, fechaini, fechahas).Tables(0)

        For Each dr As DataRow In dtrpt.Rows()
            Dim o As New ReporteVentaE
            o.CODIGO = dr.Item(0).ToString()
            o.CODSUBLINE = ""
            o.DESCRIPCION = dr.Item(1).ToString()
            o.TOTAL = CType(dr.Item(2), Decimal)
            o.MONTOCUOTA = CType(dr.Item(3), Decimal)
            o.CUOTA = CType(dr.Item(4), Decimal)
            ListaRpt.Add(o)
        Next

        ReporteVentaEBindingSource.DataSource = ListaRpt
        ReporteVentaEBindingSource.ResetBindings(False)

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

        CAyuda.ListarDatos("FN_UFECHA_ARTI_HIST_12", codempresa)
        CAyuda.ListarDatos("UPD_COST_ARTICULO", codempresa)

        Dim frmreporteventasdetalle As New FrmRpt_Ventas_Calculos(DesEmpresa, DesUsuario, fechaini.ToShortDateString, fechahas.ToShortDateString, var1, var2, rand)
        frmreporteventasdetalle.ShowDialog()





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
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                '.set_Formulas(2, "FechaIni='" & fechaini.ToShortDateString & "'")
                '.set_Formulas(3, "FechaH='" & fechahas.ToShortDateString & "'")
                '.set_Formulas(4, "Fuerza='" & var1 & "'")
                '.set_Formulas(5, "Ruta='" & var2 & "'")
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

    Sub Reporte2(ByVal rpt As String)
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
        CAyuda.Ejecutar("ASP_INS_VENTA_DETAL_PRODUC", rand)


        Dim FrmVentasProductos As New Frm_Ventas_xvendedor
        FrmVentasProductos.RAN = rand
        FrmVentasProductos.fechaini = fechaini.ToString
        FrmVentasProductos.fechahas = fechahas.ToString
        FrmVentasProductos.Show()


    End Sub

    Private Sub EfectividadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EfectividadToolStripMenuItem.Click


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

        CAyuda.Ejecutar("ASP_INSERT_VENT_PROD", rand)




        'Reporte("Reporte_Venta_Todo_EXE.rpt")
        Dim FrmVentasProductos As New Frm_Ventas_Productos
        FrmVentasProductos.RAN = rand
        FrmVentasProductos.fechaini = fechaini.ToString
        FrmVentasProductos.fechahas = fechahas.ToString
        FrmVentasProductos.Show()


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

    Private Sub DeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeToolStripMenuItem.Click
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
        Reporte2("Rpt_Ventas_efectividad.rpt")

    End Sub

    Private Sub EfectividadPorVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EfectividadPorVendedorToolStripMenuItem.Click

        Up_Fechas()
        TmpInsertDatos("DELETE FROM TMP_RPT_REPO_EFECTIVID WHERE CORREL=" + rand.ToString)

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_VENT_EFECTIVIDAD_VEND", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 1)
            End If
        Next

        CAyuda.Ejecutar("SP_RPT_VENT_EFECTIVIDAD_VEND", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 0)

        CAyuda.Ejecutar("SP_INSERT_VENT_EFECTIVIDAD_VEND", rand)



        ''Reporte2("Rpt_Ventas_efectividad.rpt")
        Dim FrmVentasProductos As New Frm_Ventas_EfectVend
        FrmVentasProductos.RAN = rand
        FrmVentasProductos.fechaini = fechaini.ToString
        FrmVentasProductos.fechahas = fechahas.ToString
        FrmVentasProductos.Show()


    End Sub

    Private Sub DetallePorDocTodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetallePorDocTodosToolStripMenuItem.Click
        Up_Fechas()
        TmpInsertDatos("DELETE FROM TMP_RPT_VENTAS_REPORTE WHERE CORREL=" + rand.ToString)

        For i = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.ListarDatos("SP_RPT_VENT_TODOS", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 1)
            End If
        Next
        CAyuda.ListarDatos("SP_RPT_VENT_TODOS", rand, codempresa, dgvcategoria.Item(0, dgvcategoria.CurrentRow.Index).Value.ToString(), fechaini, fechahas, Me.cmbruta.SelectedValue.ToString, Me.cmbfuerza.SelectedValue.ToString, NomTablaC, NomTablaD, 0)


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

        CAyuda.ListarDatos("FN_UFECHA_ARTI_HIST_12", codempresa)
        CAyuda.ListarDatos("UPD_COST_ARTICULO", codempresa)

        Dim frmreporteventasdetalle As New FrmRpt_Ventas_Calculos(DesEmpresa, DesUsuario, fechaini.ToShortDateString, fechahas.ToShortDateString, var1, var2, rand)
        frmreporteventasdetalle.ShowDialog()



    End Sub
End Class