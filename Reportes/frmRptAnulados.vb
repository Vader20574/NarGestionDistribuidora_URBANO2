Public Class frmRptAnulados
    Dim rand As Integer
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String
    Dim fechaini, fechahas As Date

    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable




    Private Sub frmRptAnulados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim dr As DataRow

        Dim dt2 As New DataTable
        dt2 = CAyuda.ListarDatos("NSP_Select_Listado_Usuario2", codempresa, CodUsuario).Tables(0)
        Dim CodVend As String
        CodVend = dt2.Rows(0)(0)

 

        dt = CAyuda.ListarDatos("sp_listvendedor2", codempresa, CodVend).Tables(0)
        dr = dt.NewRow()
        dr.Item(0) = ""
        dr.Item(1) = "<< TODOS >>"
        dt.Rows.InsertAt(dr, 0)
        Me.cmbvendedor.DataSource = dt
        Me.cmbvendedor.DisplayMember = "DSVEND"
        Me.cmbvendedor.ValueMember = "CODVEND"

        dt = New DataTable
        dt = CAyuda.ListarDatos("NSP_LISTAR_RUTA_1", codempresa).Tables(0)
        dr = dt.NewRow()
        dr.Item(0) = ""
        dr.Item(1) = "<< TODOS >>"
        dt.Rows.InsertAt(dr, 0)
        Me.cmbruta.DataSource = dt
        Me.cmbruta.DisplayMember = "DESCRIPCION"
        Me.cmbruta.ValueMember = "CODIGO"

        dt = New DataTable
        dt = CAyuda.ListarDatos("Nsp_select_distrito", "Peru", "14", "127").Tables(0)
        dr = dt.NewRow()
        dr.Item(0) = 0
        dr.Item(1) = "<< TODOS >>"
        dt.Rows.InsertAt(dr, 0)
        Me.cmbdistrito.DataSource = dt
        Me.cmbdistrito.DisplayMember = "DESCRIPCION"
        Me.cmbdistrito.ValueMember = "CODIGO"

        ValorRan()



        Tb_RutaDisponible = TmpListarDatos("SP_LISTAR_TIPOANULFACT '" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("SP_LISTAR_TIPOANULFACT '" & 4566 & "'")

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
    Sub Up_Fechas()
        fechaini = Format(Me.dtpinicio.Value, "dd/MM/yyyy")
        fechahas = Format(Me.dtpfin.Value, "dd/MM/yyyy")
        nromeses = DateDiff("m", fechaini, fechahas)
    End Sub

    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click

        Up_Fechas()

        Dim Sql As String

        Sql = "DELETE  FROM tmp_tipoanulacion "
        If TmpInsertDatos(Sql) = True Then
        End If


        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_tmp_tipoanulacion '" & codempresa & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "','" & rand & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next






        If fechaini > fechahas Then
            MsgBox("Fechas fuera de rango.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        TmpInsertDatos(String.Format("DELETE FROM TMP_RPT_DOCUM_ANUL WHERE CORREL={0}", rand))
        For i As Integer = 0 To nromeses
            NomTablaC = "VENTC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            If CAyuda.ListarDatos("VERIFICA_HISTORICOVENT", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_DOCUM_ANULADOS", rand, codempresa, Format(dtpinicio.Value, "dd/MM/yyyy"), Format(dtpfin.Value, "dd/MM/yyyy"), cmbvendedor.SelectedValue.ToString(), cmbruta.SelectedValue.ToString(), cmbdistrito.SelectedValue.ToString(), NomTablaC, 1)
            End If
        Next

        CAyuda.Ejecutar("SP_RPT_DOCUM_ANULADOS", rand, codempresa, Format(dtpinicio.Value, "dd/MM/yyyy"), Format(dtpfin.Value, "dd/MM/yyyy"), cmbvendedor.SelectedValue.ToString(), cmbruta.SelectedValue.ToString(), cmbdistrito.SelectedValue.ToString(), NomTablaC, 0)
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_DcumentosAnulados.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                .set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                .set_Formulas(4, "Distrito='" & cmbdistrito.Text & "'")
                .set_Formulas(5, "Ruta='" & cmbruta.Text & "'")
                .set_StoredProcParam(0, rand)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos(String.Format("DELETE FROM TMP_RPT_DOCUM_ANUL WHERE CORREL={0}", rand))
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


End Class