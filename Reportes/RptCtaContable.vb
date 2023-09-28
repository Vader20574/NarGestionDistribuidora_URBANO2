Public Class RptCtaContable

    Private Tb_ClienteDisponible As New DataTable

    Private Tb_ClienteModSelec As New DataTable


    Private Tb_RutaDisponible As New DataTable

    Private Tb_RutaModSelec As New DataTable

    Dim rand As Integer

    Private Tb_DistritoDisponible As New DataTable

    Private Tb_DistritoModSelec As New DataTable



    Private Sub RptCtaContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Tb_ClienteDisponible = TmpListarDatos("SP_LISTAR_CAJA  '" & codempresa & "'")
        Tb_ClienteModSelec = TmpListarDatos("SP_LISTAR_CAJA   '" & 257 & "'")

        Tb_DistritoDisponible = TmpListarDatos("NSP_Select_Listado_CATEGORIA_CTACONTABLE_2  '" & codempresa & "'")
        Tb_DistritoModSelec = TmpListarDatos("NSP_Select_Listado_CATEGORIA_CTACONTABLE_2   '" & 257 & "'")


        CargarModulo()


        ValorRan()


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






    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function



    Private Sub CargarModulo()
        LstDisp.DataSource = Tb_ClienteDisponible
        LstDisp.ValueMember = "CODCAJA"
        LstDisp.DisplayMember = "DESC1CAJA"

        LstSelec.DataSource = Tb_ClienteModSelec
        LstSelec.ValueMember = "CODCAJA"
        LstSelec.DisplayMember = "DESC1CAJA"

        LstDispDistrito.DataSource = Tb_DistritoDisponible
        LstDispDistrito.ValueMember = "Codigo"
        LstDispDistrito.DisplayMember = "Descripcion"

        LstSelecDistrito.DataSource = Tb_DistritoModSelec
        LstSelecDistrito.ValueMember = "Codigo"
        LstSelecDistrito.DisplayMember = "Descripcion"



      


        Tb_RutaModSelec = TmpListarDatos("NSP_Select_Listado_SUBCTACONTABLE_3   '" & 257 & "','" & "0" & "'")


        LstSelecRuta.DataSource = Tb_RutaModSelec
        LstSelecRuta.ValueMember = "Codigo"
        LstSelecRuta.DisplayMember = "Descripcion"





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






    Private Sub BtnPasaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno.Click
        PasarUno()
    End Sub




    Private Sub PasarUno()

        If Tb_ClienteDisponible.Rows.Count > 0 Then

            Dim FILA As DataRow = Tb_ClienteModSelec.NewRow
            FILA("CODCAJA") = LstDisp.SelectedValue.ToString.Trim
            FILA("DESC1CAJA") = LstDisp.Text.Trim
            Tb_ClienteModSelec.Rows.Add(FILA)

            For F As Integer = 0 To Tb_ClienteDisponible.Rows.Count - 1
                If LstDisp.SelectedValue.ToString.Trim = Tb_ClienteDisponible.Rows(F)("CODCAJA").ToString.Trim Then
                    Tb_ClienteDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next

        End If


    End Sub


    Private Sub PasarTodo()

        For F As Integer = 0 To Tb_ClienteDisponible.Rows.Count - 1
            Dim FILA As DataRow = Tb_ClienteModSelec.NewRow
            FILA("CODCAJA") = Tb_ClienteDisponible.Rows(F)("CODCAJA").ToString.Trim
            FILA("DESC1CAJA") = Tb_ClienteDisponible.Rows(F)("DESC1CAJA").ToString.Trim
            Tb_ClienteModSelec.Rows.Add(FILA)
        Next
        Tb_ClienteDisponible.Rows.Clear()
    End Sub


    Private Sub QuitarUno()
        If Tb_ClienteModSelec.Rows.Count > 0 Then
            Dim FILA As DataRow = Tb_ClienteDisponible.NewRow
            FILA("CODCAJA") = LstSelec.SelectedValue.ToString.Trim
            FILA("DESC1CAJA") = LstSelec.Text.Trim
            Tb_ClienteDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1
                If LstSelec.SelectedValue.ToString.Trim = Tb_ClienteModSelec.Rows(F)("CODCAJA").ToString.Trim Then
                    Tb_ClienteModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub QuitarTodo()

        For F As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1
            Dim FILA As DataRow = Tb_ClienteDisponible.NewRow
            FILA("CODCAJA") = Tb_ClienteModSelec.Rows(F)("CODCAJA").ToString.Trim
            FILA("DESC1CAJA") = Tb_ClienteModSelec.Rows(F)("DESC1CAJA").ToString.Trim
            Tb_ClienteDisponible.Rows.Add(FILA)
        Next
        Tb_ClienteModSelec.Rows.Clear()

    End Sub






    Private Sub BtnPasaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo.Click
        PasarTodo()
    End Sub

    Private Sub BtnQuitaUno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno.Click
        QuitarUno()
    End Sub

    Private Sub BtnQuitaTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo.Click
        QuitarTodo()
    End Sub

    Private Sub cbCuentaContable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCuentaContable.SelectedIndexChanged

        '  CAyuda.CargarDataCombo(cbSubCuentaContable, "NSP_Select_Listado_SUBCTACONTABLE_2  '" & codempresa & "','" & cbCuentaContable.SelectedValue.ToString & "'", "Código", "Descripción")



        'Tb_RutaDisponible = TmpListarDatos("NSP_Select_Listado_SUBCTACONTABLE_3 '" & codempresa & "','" & cbCuentaContable.SelectedValue.ToString & "'")
        'LstDispRuta.DataSource = Tb_RutaDisponible
        'LstDispRuta.ValueMember = "Codigo"
        'LstDispRuta.DisplayMember = "Descripcion"








    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PasarUno_Ruta()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PasarTodo_Ruta()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        QuitarUno_Ruta()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        QuitarTodo_Ruta()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        'Try
        '    With AxCrystalReport1
        '        .ReportFileName = RutaRptInv & "Rpt_DcumentosAnulados.rpt"
        '        .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
        '        .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
        '        .set_Formulas(1, "Usuario='" & DesUsuario & "'")
        '        .set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
        '        .set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
        '        .set_Formulas(4, "Distrito='" & cmbdistrito.Text & "'")
        '        .set_Formulas(5, "Ruta='" & cmbruta.Text & "'")
        '        .set_StoredProcParam(0, rand)
        '        .WindowState = Crystal.WindowStateConstants.crptMaximized
        '        .Destination = Crystal.DestinationConstants.crptToWindow
        '        .Action = 1
        '        .Reset()
        '    End With
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Dim SQL As String
        Sql = "DELETE  FROM TMP_CAJA "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_SUBCUENTA "
        If TmpInsertDatos(Sql) = True Then
        End If



        For i As Integer = 0 To Tb_ClienteModSelec.Rows.Count - 1
            SQL = "NSP_INSERT_TMP_CAJA '" & codempresa & "','" & Tb_ClienteModSelec.Rows(i)("CODCAJA").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            SQL = "NSP_INSERT_TMP_SUBCUENTA '" & codempresa & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next








        Dim VAR1 As String = ""
        Dim TB_BUSQCLIDEP As DataTable

        TB_BUSQCLIDEP = TmpListarDatos("MENOR_FECHA_CAJAMOVI '" & codempresa & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then
            VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
        End If




        CAyuda.Ejecutar("SP_INSER_TTMP_FLUJOCAJA_3", VAR1, String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy"), "0", "0", rand, "0")

        CAyuda.Ejecutar("SP_MODIFIC_SALDO_FLUJOCAJA", rand)



        CAyuda.Ejecutar("INS_TMP_FLUJOCAJA_3", rand, String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy"), String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy"))




        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "ReporteCtaContable.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Caja='" & "0" & "'")
                .set_Formulas(1, "Empresa='" & DesEmpresa & "'")


                .set_Formulas(2, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                .set_Formulas(3, "Fechaini='" & dtpinicio.Value.ToShortDateString & "'")
                '.set_Formulas(4, "TipoOpera='" & "0" & "'")

                '.set_Formulas(5, "TipoProveedor='" & Me.cbCuentaContable.Text & "'")
                .set_Formulas(6, "usuario='" & DesUsuario & "'")
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

    Sub PROCESO()
        Dim Sql As String
        Sql = "DELETE  FROM TMP_CUENTAS "
        If TmpInsertDatos(Sql) = True Then
        End If



        For i As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_CUENTAS '" & codempresa & "','" & Tb_DistritoModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next




        Tb_RutaDisponible = TmpListarDatos("NSP_Select_Listado_SUBCTACONTABLE_3 '" & codempresa & "','0'")
        LstDispRuta.DataSource = Tb_RutaDisponible
        LstDispRuta.ValueMember = "Codigo"
        LstDispRuta.DisplayMember = "Descripcion"


    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        PasarUno_Distrito()

        PROCESO()



    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PasarTodo_Distrito()

        PROCESO()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        QuitarUno_Distrito()
        PROCESO()


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        QuitarTodo_Distrito()

        PROCESO()

    End Sub


    Private Sub LstSelecDistrito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstSelecDistrito.SelectedIndexChanged
      

    End Sub
End Class