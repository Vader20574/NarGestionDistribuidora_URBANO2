Public Class FrmReporteCliente_3
    Private Tb_ClienteDisponible As New DataTable

    Private Tb_ClienteModSelec As New DataTable

    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable


    Private Tb_DistritoDisponible As New DataTable
    Private Tb_DistritoModSelec As New DataTable


    Dim ACTIVOCLIENTE As Int16


    Dim Sql As String
    Dim RUTA As String
    Dim rand As Integer




    Private Sub FrmReporteCliente_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Tb_ClienteDisponible = TmpListarDatos("SP_LISTAR_CLIENTE_DEPMAEST_J  '" & codempresa & "','" & 0 & "'")
        Tb_ClienteModSelec = TmpListarDatos("SP_LISTAR_CLIENTE_DEPMAEST   '" & 257 & "','" & 0 & "'")

        Tb_RutaDisponible = TmpListarDatos("SP_LISTAR_VENDEDOR '" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("SP_LISTAR_VENDEDOR '" & 4566 & "'")


        '  Tb_DistritoDisponible = TmpListarDatos("Nsp_select_distrito 'Peru','14','127'")
        Tb_DistritoModSelec = TmpListarDatos("Nsp_select_distrito 'Peru','14','24'")


        CAyuda.CargarDataCombo(cbopais, "Nsp_sel_Pais '" & codempresa & "'", "Codigo", "Descripcion")
        If Not cbopais.SelectedValue Is Nothing Then
            CAyuda.CargarDataCombo(cdepa, "sele_depa '" & cbopais.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")
        End If



        CargarModulo()

        ValorRan()


    End Sub


    Private Sub CargarModulo()
        LstDisp.DataSource = Tb_ClienteDisponible
        LstDisp.ValueMember = "CODCLIENTE"
        LstDisp.DisplayMember = "DATOADJUNTO"

        LstSelec.DataSource = Tb_ClienteModSelec
        LstSelec.ValueMember = "CODCLIENTE"
        LstSelec.DisplayMember = "DATOADJUNTO"


        LstDispRuta.DataSource = Tb_RutaDisponible
        LstDispRuta.ValueMember = "Codigo"
        LstDispRuta.DisplayMember = "Descripcion"

        LstSelecRuta.DataSource = Tb_RutaModSelec
        LstSelecRuta.ValueMember = "Codigo"
        LstSelecRuta.DisplayMember = "Descripcion"


        'LstDispDistrito.DataSource = Tb_DistritoDisponible
        'LstDispDistrito.ValueMember = "Codigo"
        'LstDispDistrito.DisplayMember = "Descripcion"

        LstSelecDistrito.DataSource = Tb_DistritoModSelec
        LstSelecDistrito.ValueMember = "Codigo"
        LstSelecDistrito.DisplayMember = "Descripcion"


    End Sub

    Private Sub PasarUno()

        If Tb_ClienteDisponible.Rows.Count > 0 Then

            Dim FILA As DataRow = Tb_ClienteModSelec.NewRow
            FILA("CODCLIENTE") = LstDisp.SelectedValue.ToString.Trim
            FILA("DATOADJUNTO") = LstDisp.Text.Trim
            Tb_ClienteModSelec.Rows.Add(FILA)

            For F As Integer = 0 To Tb_ClienteDisponible.Rows.Count - 1
                If LstDisp.SelectedValue.ToString.Trim = Tb_ClienteDisponible.Rows(F)("CODCLIENTE").ToString.Trim Then
                    Tb_ClienteDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next

        End If


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




    Private Sub BtnPasaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno.Click
        PasarUno()
    End Sub

    Private Sub BtnPasaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo.Click
        PasarTodo()
    End Sub

    Private Sub PasarTodo()

        For F As Integer = 0 To Tb_ClienteDisponible.Rows.Count - 1
            Dim FILA As DataRow = Tb_ClienteModSelec.NewRow
            FILA("CODCLIENTE") = Tb_ClienteDisponible.Rows(F)("CODCLIENTE").ToString.Trim
            FILA("DATOADJUNTO") = Tb_ClienteDisponible.Rows(F)("DATOADJUNTO").ToString.Trim
            Tb_ClienteModSelec.Rows.Add(FILA)
        Next
        Tb_ClienteDisponible.Rows.Clear()
    End Sub

    Private Sub BtnQuitaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno.Click
        QuitarUno()
    End Sub

    Private Sub QuitarUno()
        If Tb_ClienteModSelec.Rows.Count > 0 Then
            Dim FILA As DataRow = Tb_ClienteDisponible.NewRow
            FILA("CODCLIENTE") = LstSelec.SelectedValue.ToString.Trim
            FILA("DATOADJUNTO") = LstSelec.Text.Trim
            Tb_ClienteDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1
                If LstSelec.SelectedValue.ToString.Trim = Tb_ClienteModSelec.Rows(F)("CODCLIENTE").ToString.Trim Then
                    Tb_ClienteModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub


    Private Sub BtnQuitaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo.Click
        QuitarTodo()
    End Sub

    Private Sub QuitarTodo()

        For F As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1
            Dim FILA As DataRow = Tb_ClienteDisponible.NewRow
            FILA("CODCLIENTE") = Tb_ClienteModSelec.Rows(F)("CODCLIENTE").ToString.Trim
            FILA("DATOADJUNTO") = Tb_ClienteModSelec.Rows(F)("DATOADJUNTO").ToString.Trim
            Tb_ClienteDisponible.Rows.Add(FILA)
        Next
        Tb_ClienteModSelec.Rows.Clear()

    End Sub



    Private Sub BtnPasaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno_Ruta.Click
        PasarUno_Ruta()


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

    Private Sub LstSelecRuta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstSelecRuta.SelectedIndexChanged

    End Sub

    Private Sub BtnPasaUno_Distrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno_Distrito.Click
        PasarUno_Distrito()
    End Sub

    Private Sub BtnPasaTodo_Distrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo_Distrito.Click
        PasarTodo_Distrito()
    End Sub

    Private Sub BtnQuitaUno_Distrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno_Distrito.Click
        QuitarUno_Distrito()
    End Sub

    Private Sub BtnQuitaTodo_Distrito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo_Distrito.Click
        QuitarTodo_Distrito()
    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click

        Sql = "DELETE  FROM TMP_RUTA "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_CLIENTE_REPORTE "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_DISTRITO  "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "NSP_INSERT_TMP_CLIENTE_REPORTE1 '" & codempresa & "',''"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_VENDE "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "NSP_INSERT_TMP_RUTA1 '" & codempresa & "',''"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "NSP_INSERT_TMP_DISTRITO3 '" & codempresa & "',''"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "SP_INSERT_TMP_TOTCREDBASXCLI '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_VENDEDOR '" & codempresa & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        Sql = "NSP_INSERT_TMP_VTAPROM5 '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        'Dim formTotLetrasDoc As String
        'formTotLetrasDoc = FACT_TotalLetras(lbltotal.Text, "NUEVOS SOLES")
        'StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString), "NUEVOS SOLES")

        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Reporte_Cartera_Cliente2.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
            crRpt.set_StoredProcParam(2, 2)
            crRpt.set_StoredProcParam(3, rand)

            'crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            'crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            'crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            'crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")

            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub rbActivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbActivo.CheckedChanged
        If Me.rbActivo.Checked = True Then
            ACTIVOCLIENTE = 1
        End If
    End Sub

    Private Sub rbInactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInactivo.CheckedChanged
        If Me.rbInactivo.Checked = True Then
            ACTIVOCLIENTE = 0
        End If
    End Sub

    Private Sub cbopais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopais.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cdepa, "sele_depa '" & cbopais.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")
        Catch x As Exception
        End Try
    End Sub

    Private Sub cdepa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdepa.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cciud, "Nsp_select_Ciudad_combo2 '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "'", "Codigo", "Descripcion")
        Catch x As Exception
        End Try
    End Sub

    Private Sub cciud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cciud.SelectedIndexChanged
        Try
            'CAyuda.CargarDataCombo(cdistrito, "Nsp_select_distrito '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "','" & cciud.SelectedValue.ToString & "'", "Codigo", "Descripcion")
            Tb_DistritoDisponible = TmpListarDatos("Nsp_select_distrito '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "','" & cciud.SelectedValue.ToString & "'")
            LstDispDistrito.DataSource = Tb_DistritoDisponible
            LstDispDistrito.ValueMember = "Codigo"
            LstDispDistrito.DisplayMember = "Descripcion"

            Tb_DistritoModSelec.Rows.Clear()


        Catch x As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        Sql = "DELETE  FROM TMP_RUTA "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_CLIENTE_REPORTE "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_DISTRITO  "
        If TmpInsertDatos(Sql) = True Then
        End If


        For i As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_CLIENTE_REPORTE '" & codempresa & "','" & Tb_ClienteModSelec.Rows(i)("CODCLIENTE").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_RUTA '" & codempresa & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        For i As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_DISTRITO '" & codempresa & "','" & Tb_DistritoModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next


        'Dim formTotLetrasDoc As String
        'formTotLetrasDoc = FACT_TotalLetras(lbltotal.Text, "NUEVOS SOLES")
        ' StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString), "NUEVOS SOLES")

        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Reporte_Cartera_Cliente.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
            crRpt.set_StoredProcParam(2, 1)

            'crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            'crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            'crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            'crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")

            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class