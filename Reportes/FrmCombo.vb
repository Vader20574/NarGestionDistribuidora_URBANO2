Public Class FrmCombo

    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable




    Private Sub FrmCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CAyuda.CargarDataCombo(cbCombo, "NSP_LISTA_COMBO '" & codempresa & "'", "CODCOMBO", "DESCOMBO")


        Tb_RutaDisponible = TmpListarDatos("Nsp_Sele_vendedor_filtro '" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("Nsp_Sele_vendedor_filtro '" & 254 & "'")
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




    Private Sub btnpasdet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
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

        Dim SQL1 As String
        SQL1 = "DELETE  FROM TMP_RUTA "
        If TmpInsertDatos(SQL1) = True Then
        End If

        For x As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            SQL1 = "NSP_INSERT_TMP_VEND '" & codempresa & "','" & Tb_RutaModSelec.Rows(x)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(SQL1) = True Then
            End If
        Next

        Dim fechaini, fechahas As String

        fechaini = String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy")
        fechahas = String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy")


        Dim Sql As String

        Sql = "NSP_INSERT_REPORTE '" & codempresa & "','" & fechaini & "','" & fechahas & "','" & cbCombo.SelectedValue & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        'Dim formTotLetrasDoc As String
        'formTotLetrasDoc = FACT_TotalLetras(lbltotal.Text, "NUEVOS SOLES")
        ' StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString), "NUEVOS SOLES")

        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Reporte_Combo.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_StoredProcParam(0, codempresa)
            'crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
            'crRpt.set_StoredProcParam(2, 2)

            'crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            'crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            'crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")

            crRpt.set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
            crRpt.set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")





            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub
End Class