Public Class FrmDetalleCompra
    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable

    Private Tb_DistritoDisponible As New DataTable
    Private Tb_DistritoModSelec As New DataTable

    Dim Sql As String

    Dim rand As Integer
    Dim fechaini, fechahas As Date
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub FrmDetalleCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Tb_RutaDisponible = TmpListarDatos("NSP_Select_Listado_Linea2 '" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("NSP_Select_Listado_Linea2 '" & 254 & "'")


        Tb_DistritoDisponible = TmpListarDatos("NSP_Select_Listado_almacen '" & codempresa & "'")
        Tb_DistritoModSelec = TmpListarDatos("NSP_Select_Listado_almacen '" & 254 & "'")

        CargarModulo()


        ValorRan()


    End Sub



    Private Sub CargarModulo()
      
        LstDispRuta.DataSource = Tb_RutaDisponible
        LstDispRuta.ValueMember = "Codigo"
        LstDispRuta.DisplayMember = "Descripcion"

        LstSelecRuta.DataSource = Tb_RutaModSelec
        LstSelecRuta.ValueMember = "Codigo"
        LstSelecRuta.DisplayMember = "Descripcion"




        LstDispDistrito.DataSource = Tb_DistritoDisponible
        LstDispDistrito.ValueMember = "Codigo"
        LstDispDistrito.DisplayMember = "Descripcion"

        LstSelecDistrito.DataSource = Tb_DistritoModSelec
        LstSelecDistrito.ValueMember = "Codigo"
        LstSelecDistrito.DisplayMember = "Descripcion"

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



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        QuitarUno_Distrito()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PasarTodo_Distrito()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        QuitarTodo_Distrito()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim fechaini, fechahas As Date

        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")

        Sql = "DELETE  FROM TMP_ALMACEN "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_CATEGORIA "
        If TmpInsertDatos(Sql) = True Then
        End If

        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_CATEGORIA '" & codempresa & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        For i As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_ALMACEN '" & codempresa & "','" & Tb_DistritoModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        TmpInsertDatos("DELETE FROM TMP_DETALLE_COMPRA  WHERE CORREL='" & rand & "'")

        nromeses = DateDiff("m", fechaini, fechahas)

        For i As Integer = 0 To nromeses
            NomTablaC = "MOVIC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "MOVID" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("SP_VERIFICA_HISTOMOVI", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("NSP_LLENAR_DETCOMPRA", codempresa, fechaini, fechahas, rand, NomTablaC, NomTablaD)
            End If
        Next


        CAyuda.Ejecutar("NSP_LLENAR_DETCOMPRA", codempresa, fechaini, fechahas, rand, "", "")


        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Reporte_Detalle_Compra.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, rand)
            'crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
            'crRpt.set_StoredProcParam(2, 2)

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