Public Class FrmSaldoProveedores

    Private Tb_ClienteDisponible As New DataTable

    Private Tb_ClienteModSelec As New DataTable

    Private Tb_DistritoDisponible As New DataTable

    Private Tb_DistritoModSelec As New DataTable

    Dim rand As Integer



    Private Sub FrmSaldoProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tb_DistritoDisponible = TmpListarDatos("SP_LISTAR_proveedor  '" & codempresa & "'")
        Tb_DistritoModSelec = TmpListarDatos("SP_LISTAR_proveedor   '" & 257 & "'")
        CargarModulo()
    End Sub



    Private Sub CargarModulo()
        'LstDisp.DataSource = Tb_ClienteDisponible
        'LstDisp.ValueMember = "CODCAJA"
        'LstDisp.DisplayMember = "DESC1CAJA"

        'LstSelec.DataSource = Tb_ClienteModSelec
        'LstSelec.ValueMember = "CODCAJA"
        'LstSelec.DisplayMember = "DESC1CAJA"

        LstDispDistrito.DataSource = Tb_DistritoDisponible
        LstDispDistrito.ValueMember = "Codigo"
        LstDispDistrito.DisplayMember = "Descripcion"

        LstSelecDistrito.DataSource = Tb_DistritoModSelec
        LstSelecDistrito.ValueMember = "Codigo"
        LstSelecDistrito.DisplayMember = "Descripcion"

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim Sql As String

        Sql = "DELETE  FROM TMP_PROVEEDOR  "
        If TmpInsertDatos(Sql) = True Then
        End If

        For i As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_PROVEEDOR '" & codempresa & "','" & Tb_DistritoModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next




        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_SaldoProveedor1.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)


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

        Dim Sql As String

        Sql = "DELETE  FROM TMP_PROVEEDOR  "
        If TmpInsertDatos(Sql) = True Then
        End If

        For i As Integer = 0 To Tb_DistritoModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_PROVEEDOR '" & codempresa & "','" & Tb_DistritoModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next




        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_SaldoProveedor2.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)


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