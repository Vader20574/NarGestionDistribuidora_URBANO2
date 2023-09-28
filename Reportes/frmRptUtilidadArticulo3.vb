Public Class frmRptUtilidadArticulo3


    Private Tb_ClienteDisponible As New DataTable

    Private Tb_ClienteModSelec As New DataTable

    Private Tb_DistritoDisponible As New DataTable

    Private Tb_DistritoModSelec As New DataTable

    Dim rand As Integer


    Private Sub btnpastodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub



    Private Sub btnreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnregtodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnpasstodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnpas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnregre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ItemsBindingSource3.Current Is Nothing Then Exit Sub
        ItemsBindingSource2.Add(ItemsBindingSource3.Current)
        ItemsBindingSource3.RemoveCurrent()
    End Sub

    Private Sub btnregretodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Tb_ClienteDisponible = TmpListarDatos("SP_LISTAR_ALMACEN  '" & codempresa & "'")
        'Tb_ClienteModSelec = TmpListarDatos("SP_LISTAR_ALMACEN   '" & 257 & "'")

        Tb_DistritoDisponible = TmpListarDatos("SP_LISTAR_AlmacenXSerie  '" & codempresa & "'")
        Tb_DistritoModSelec = TmpListarDatos("SP_LISTAR_AlmacenXSerie   '" & 257 & "'")

        CargarModulo()
        ValorRan()




        Dim TABLE_SUBCAT As DataTable

        TABLE_SUBCAT = TmpListarDatos("SP_LISTAR_ALMACEN '" & codempresa.Trim & "'")
        cboAlmacen.DataSource = TABLE_SUBCAT
        cboAlmacen.ValueMember = "CODCAJA"
        cboAlmacen.DisplayMember = "DESC1CAJA"




    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub CargarModulo()
        'LstDisp.DataSource = Tb_ClienteDisponible
        'LstDisp.ValueMember = "CODCAJA"
        'LstDisp.DisplayMember = "DESC1CAJA"

        'LstSelec.DataSource = Tb_ClienteModSelec
        'LstSelec.ValueMember = "CODCAJA"
        'LstSelec.DisplayMember = "DESC1CAJA"

        LstDispDistrito.DataSource = Tb_DistritoDisponible
        LstDispDistrito.ValueMember = "Codigo"
        LstDispDistrito.DisplayMember = "Codigo"

        LstSelecDistrito.DataSource = Tb_DistritoModSelec
        LstSelecDistrito.ValueMember = "Codigo"
        LstSelecDistrito.DisplayMember = "Codigo"












    End Sub


    'Private Sub PasarUno()

    '    If Tb_ClienteDisponible.Rows.Count > 0 Then

    '        Dim FILA As DataRow = Tb_ClienteModSelec.NewRow
    '        FILA("CODCAJA") = LstDisp.SelectedValue.ToString.Trim
    '        FILA("DESC1CAJA") = LstDisp.Text.Trim
    '        Tb_ClienteModSelec.Rows.Add(FILA)

    '        For F As Integer = 0 To Tb_ClienteDisponible.Rows.Count - 1
    '            If LstDisp.SelectedValue.ToString.Trim = Tb_ClienteDisponible.Rows(F)("CODCAJA").ToString.Trim Then
    '                Tb_ClienteDisponible.Rows.RemoveAt(F)
    '                Exit For
    '            End If
    '        Next

    '    End If


    'End Sub


    'Private Sub PasarTodo()

    '    For F As Integer = 0 To Tb_ClienteDisponible.Rows.Count - 1
    '        Dim FILA As DataRow = Tb_ClienteModSelec.NewRow
    '        FILA("CODCAJA") = Tb_ClienteDisponible.Rows(F)("CODCAJA").ToString.Trim
    '        FILA("DESC1CAJA") = Tb_ClienteDisponible.Rows(F)("DESC1CAJA").ToString.Trim
    '        Tb_ClienteModSelec.Rows.Add(FILA)
    '    Next
    '    Tb_ClienteDisponible.Rows.Clear()
    'End Sub


    'Private Sub QuitarUno()
    '    If Tb_ClienteModSelec.Rows.Count > 0 Then
    '        Dim FILA As DataRow = Tb_ClienteDisponible.NewRow
    '        FILA("CODCAJA") = LstSelec.SelectedValue.ToString.Trim
    '        FILA("DESC1CAJA") = LstSelec.Text.Trim
    '        Tb_ClienteDisponible.Rows.Add(FILA)
    '        For F As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1
    '            If LstSelec.SelectedValue.ToString.Trim = Tb_ClienteModSelec.Rows(F)("CODCAJA").ToString.Trim Then
    '                Tb_ClienteModSelec.Rows.RemoveAt(F)
    '                Exit For
    '            End If
    '        Next
    '    End If

    'End Sub

    'Private Sub QuitarTodo()

    '    For F As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1
    '        Dim FILA As DataRow = Tb_ClienteDisponible.NewRow
    '        FILA("CODCAJA") = Tb_ClienteModSelec.Rows(F)("CODCAJA").ToString.Trim
    '        FILA("DESC1CAJA") = Tb_ClienteModSelec.Rows(F)("DESC1CAJA").ToString.Trim
    '        Tb_ClienteDisponible.Rows.Add(FILA)
    '    Next
    '    Tb_ClienteModSelec.Rows.Clear()

    'End Sub






    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        PasarUno_Distrito()

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






    'Private Sub BtnPasaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    PasarUno()
    'End Sub

    'Private Sub BtnPasaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    PasarTodo()
    'End Sub

    'Private Sub BtnQuitaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    QuitarUno()
    'End Sub

    'Private Sub BtnQuitaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    QuitarTodo()
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click







        Dim stralmacen As String = ""
        Dim strconsul As String = ""



        'If ItemsBindingSource1.Count = 0 Or ItemsBindingSource3.Count = 0 Then
        '    MsgBox("No hay items disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
        '    Exit Sub
        'End If

        'linea = IIf(ItemsBindingSource.Count = 0, 1, 0)
        'almacen = IIf(ItemsBindingSource2.Count = 0, 1, 0)

        'If linea = 0 Then
        'For Each var As Items In ItemsBindingSource1.List
        '    If strconsul.Length = 0 Then
        '        strconsul = "'" & var.Codigo.Trim & "'"
        '    Else
        '        strconsul = strconsul & ",'" & var.Codigo.Trim & "'"
        '    End If
        'Next
        'End If







        Dim Sql As String

        Sql = "DELETE  FROM TMP_DISTRITO  "
        If TmpInsertDatos(Sql) = True Then
        End If



        For i As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_VERIALM '" & codempresa & "','" & Tb_DistritoModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        Dim fechaini As String

        Dim fechahas As String

        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")

        Try
            CAyuda.Ejecutar("INS_VERIFALM2", rand, fechaini, fechahas)
            With Rpt1

                .ReportFileName = RutaRptInv & CType("RptVerificacionAlmacen.rpt", String)


                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, rand)

                '.set_SortFields(0, "+{INVENTARIO.CODARTI}")


                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






    End Sub

    Private Sub LstDispDistrito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstDispDistrito.SelectedIndexChanged

    End Sub
End Class