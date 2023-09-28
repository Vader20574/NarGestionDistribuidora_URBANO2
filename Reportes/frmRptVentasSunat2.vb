Public Class frmRptVentasSunat2
    Dim rand As Integer
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String
    Dim fechaini, fechahas As Date

    Private Tb_DistritoDisponible As New DataTable

    Private Tb_DistritoModSelec As New DataTable



    Private Sub frmRptVentasSunat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow
        dt = CAyuda.ListarDatos("sp_listvendedor", codempresa).Tables(0)
        dr = dt.NewRow()
        dr.Item(0) = ""
        dr.Item(1) = "<< TODOS >>"
        dt.Rows.InsertAt(dr, 0)
        Me.cmbvendedor.DataSource = dt
        Me.cmbvendedor.DisplayMember = "DSVEND"
        Me.cmbvendedor.ValueMember = "CODVEND"


        dt = New DataTable
        dt = CAyuda.ListarDatos("NSP_SELECT_LISTATIPODOC", codempresa).Tables(0)
        'dr = dt.NewRow()
        'dr.Item(0) = ""
        'dr.Item(1) = "<< TODOS >>"
        'dt.Rows.InsertAt(dr, 0)
        For Each f As DataRow In dt.Rows
            TipoDocEBindingSource.Add(New TipoDocE(f.Item(0), f.Item(1)))
        Next

        'Me.cmbdocu.DataSource = dt

        'Me.cmbdocu.DisplayMember = "Descripción"
        'Me.cmbdocu.ValueMember = "Código"

        ValorRan()



        Tb_DistritoDisponible = TmpListarDatos("SP_LISTAR_CLIENTE_DEPE  '" & codempresa & "'")
        Tb_DistritoModSelec = TmpListarDatos("SP_LISTAR_CLIENTE_DEPE   '" & 257 & "'")

        CargarModulo()


    End Sub


    Private Sub CargarModulo()

        LstDispDistrito.DataSource = Tb_DistritoDisponible
        LstDispDistrito.ValueMember = "Codigo"
        LstDispDistrito.DisplayMember = "Descripcion"

        LstSelecDistrito.DataSource = Tb_DistritoModSelec
        LstSelecDistrito.ValueMember = "Codigo"
        LstSelecDistrito.DisplayMember = "Descripcion"

    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Sub Up_Fechas()
        fechaini = Me.dtpinicio.Value.ToShortDateString
        fechahas = Me.dtpfin.Value.ToShortDateString
        nromeses = DateDiff("m", fechaini, fechahas)
    End Sub

    Private Sub btnconsul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsul.Click

        Dim Sql As String
        Sql = "DELETE  FROM TMP_CLIENTE_1  "
        If TmpInsertDatos(Sql) = True Then
        End If

        For i As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_CLIENTE_1 '" & codempresa & "','" & Tb_DistritoModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        Dim cadena As String = ""
        If TipoDocEBindingSource1.Count = 0 Then
            MsgBox("No hay documentos.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        Up_Fechas()
        If fechaini > fechahas Then
            MsgBox("Fecha fuera de rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        If TipoDocEBindingSource.Count <> 0 Then
            For Each var As TipoDocE In TipoDocEBindingSource1.List
                If cadena.Trim.Length = 0 Then
                    cadena = "'" & var.CODIGO & "'"
                Else
                    cadena = cadena & ",'" & var.CODIGO & "'"
                End If
            Next
        End If


        TmpInsertDatos("DELETE FROM TMP_RPT_REPOR_SUNA WHERE CORREL=" & rand.ToString)

        For i As Integer = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then

                If CheckBox1.Checked = True Then
                    CAyuda.Ejecutar("SP_RPT_VTA_SUNA_BM3", codempresa, fechaini, fechahas, cmbvendedor.SelectedValue.ToString(), Trim(cadena), PORCIGV, VCdPagCredito, rand, NomTablaC, NomTablaD, 1)
                Else
                    CAyuda.Ejecutar("SP_RPT_VTA_SUNA2", codempresa, fechaini, fechahas, cmbvendedor.SelectedValue.ToString(), Trim(cadena), PORCIGV, VCdPagCredito, rand, NomTablaC, NomTablaD, 1)
                End If

            End If
        Next

        If CheckBox1.Checked = True Then
            CAyuda.Ejecutar("SP_RPT_VTA_SUNA_BM3", codempresa, fechaini, fechahas, cmbvendedor.SelectedValue.ToString(), Trim(cadena), PORCIGV, VCdPagCredito, rand, "VENTACAB", "VENTADET", 0)
        Else
            CAyuda.Ejecutar("SP_RPT_VTA_SUNA2", codempresa, fechaini, fechahas, cmbvendedor.SelectedValue.ToString(), Trim(cadena), PORCIGV, VCdPagCredito, rand, "VENTACAB", "VENTADET", 0)
        End If

       Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Venta_Sunat2.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                .set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                .set_Formulas(4, "Vendedor='" & Me.cmbvendedor.Text & "'")
                '.set_Formulas(5, "Tipo='" & Me.cmbdocu.Text & "'")
                .set_StoredProcParam(0, rand)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos("DELETE FROM TMP_RPT_REPOR_SUNA  WHERE CORREL='" & rand & "'")

    End Sub


    Private Sub btndtodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndtodo.Click
        For Each var As TipoDocE In TipoDocEBindingSource.List
            TipoDocEBindingSource1.Add(var)
        Next
        TipoDocEBindingSource.Clear()
    End Sub

    Private Sub btndpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndpass.Click
        If TipoDocEBindingSource.Count = 0 Then Exit Sub
        TipoDocEBindingSource1.Add(TipoDocEBindingSource.Current)
        TipoDocEBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnipass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnipass.Click
        If TipoDocEBindingSource1.Count = 0 Then Exit Sub
        TipoDocEBindingSource.Add(TipoDocEBindingSource1.Current)
        TipoDocEBindingSource1.RemoveCurrent()
    End Sub

    Private Sub btnizpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnizpass.Click
        For Each var As TipoDocE In TipoDocEBindingSource1.List
            TipoDocEBindingSource.Add(var)
        Next
        TipoDocEBindingSource1.Clear()
    End Sub

    Private Sub lb2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb2.SelectedIndexChanged



    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        PasarUno_Distrito()


    End Sub



    Private Sub PasarUno_Distrito()
        If Tb_DistritoDisponible.Rows.Count > 0 Then

            Dim FILA As DataRow = Tb_DistritoModSelec.NewRow
            FILA("Codigo") = LstDispDistrito.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstDispDistrito.Text.Trim
            Tb_DistritoModSelec.Rows.Add(FILA)

            For F As Integer = 0 To Tb_DistritoDisponible.Rows.Count - 1
                If LstDispDistrito.SelectedValue.ToString.Trim = Tb_DistritoDisponible.Rows(F)("Codigo").ToString.Trim Then
                    Tb_DistritoDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub PasarTodo_Distrito()

        For F As Integer = 0 To Tb_DistritoDisponible.Rows.Count - 1
            Dim FILA As DataRow = Tb_DistritoModSelec.NewRow
            FILA("Codigo") = Tb_DistritoDisponible.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_DistritoDisponible.Rows(F)("Descripcion").ToString.Trim
            Tb_DistritoModSelec.Rows.Add(FILA)
        Next
        Tb_DistritoDisponible.Rows.Clear()
    End Sub


    Private Sub QuitarUno_Distrito()
        If Tb_DistritoModSelec.Rows.Count > 0 Then
            Dim FILA As DataRow = Tb_DistritoDisponible.NewRow
            FILA("Codigo") = LstSelecDistrito.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstSelecDistrito.Text.Trim
            Tb_DistritoDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
                If LstSelecDistrito.SelectedValue.ToString.Trim = Tb_DistritoModSelec.Rows(F)("Codigo").ToString.Trim Then
                    Tb_DistritoModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub QuitarTodo_Distrito()

        For F As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Dim FILA As DataRow = Tb_DistritoDisponible.NewRow
            FILA("Codigo") = Tb_DistritoModSelec.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_DistritoModSelec.Rows(F)("Descripcion").ToString.Trim
            Tb_DistritoDisponible.Rows.Add(FILA)
        Next
        Tb_DistritoModSelec.Rows.Clear()

    End Sub



    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PasarTodo_Distrito()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        QuitarUno_Distrito()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        QuitarTodo_Distrito()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class