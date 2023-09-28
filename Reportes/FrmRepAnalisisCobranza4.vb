Public Class FrmRepAnalisisCobranza4


    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable
    Dim rand As Integer

    Private Sub FrmRepAnalisisCobranza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Tb_RutaDisponible = TmpListarDatos("Nsp_Sele_COBRADOR '','','" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("Nsp_Sele_COBRADOR '','','" & 254 & "'")

        CargarModulo()

        ValorRan()
    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub CargarModulo()

        LstDispRuta.DataSource = Tb_RutaDisponible
        LstDispRuta.ValueMember = "Codigo"
        LstDispRuta.DisplayMember = "Descripcion"

        LstSelecRuta.DataSource = Tb_RutaModSelec
        LstSelecRuta.ValueMember = "Codigo"
        LstSelecRuta.DisplayMember = "Descripcion"


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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Sql As String

        Sql = "DELETE  FROM TMP_COBRADOR "
        If TmpInsertDatos(Sql) = True Then
        End If


        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_COBRADOR '" & codempresa & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next





        If CheckBox1.Checked = True Then

            Sql = "NSP_ANALISIS_COBRANZA_NC '" & codempresa & "','" & rand & "','" & String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy") & "','" & String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy") & "'"
            If TmpInsertDatos(Sql) = True Then
            End If

        Else

            Sql = "NSP_ANALISIS_COBRANZA '" & codempresa & "','" & rand & "','" & String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy") & "','" & String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy") & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        End If


        Sql = "NPT_INSERT_LIQUI_VEND '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If



    End Sub


    Private Function VERIFICA_HISTORICOVENT(ByVal StrHistorico As String) As Boolean
        Try
            Dim StrSql As String
            Dim rs As New DataTable
            StrSql = " EXEC   VERIFICA_HISTORICOVENT    '" & StrHistorico & "','" & codempresa & "'"
            rs = TmpListarDatos(StrSql)

            If rs.Rows.Count = 0 Then
                VERIFICA_HISTORICOVENT = False
            Else
                VERIFICA_HISTORICOVENT = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " VERIFICA_HISTORICOVENT")
        End Try

    End Function



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reporte.Click


        Dim meses As Integer
        Dim VentaC, VentD, MoviD, MoviC As String
        Dim MesAct, Anio As String



        If TxtDias.Text.Length = 0 Then
            MsgBox("Debe ingresar los dias")
            Exit Sub
        End If



        Dim Sql As String
        Sql = "DELETE  FROM TMP_COBRADOR "
        If TmpInsertDatos(Sql) = True Then
        End If


        Sql = "DELETE  FROM  TMP_PLANLIQUIDACION WHERE CORREL= '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_TMP_COBRADOR '" & codempresa & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next

        If CheckBox1.Checked = True Then
            Sql = "NSP_ANALISIS_COBRANZA_NC '" & codempresa & "','" & rand & "','" & String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy") & "','" & String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy") & "'"
            If TmpInsertDatos(Sql) = True Then
            End If

        Else
            Sql = "NSP_ANALISIS_COBRANZA '" & codempresa & "','" & rand & "','" & String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy") & "','" & String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy") & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        End If



        Sql = "NPT_INSERT_LIQUI_VEND '" & rand & "','" & TxtDias.Text & "',''"
        If TmpInsertDatos(Sql) = True Then
        End If

        Dim fecini As Date
        fecini = DateAdd("d", -CInt(TxtDias.Text), dtpinicio.Value)

        meses = Val(DateDiff("m", Format(fecini, "dd/MM/yyyy"), dtpfin.Value))

        For i As Integer = 0 To meses
            MesAct = Format(DateAdd("m", i, fecini), "MM")
            Anio = Format(DateAdd("m", i, fecini), "yyyy")
            VentaC = "VENTC" & Anio & MesAct
            VentD = "VENTD" & Anio & MesAct
            MoviD = "MOVID" & Anio & MesAct
            MoviC = "MOVIC" & Anio & MesAct

            If VERIFICA_HISTORICOVENT(VentaC) = True Then
                Sql = "NPT_INSERT_LIQUI_VEND '" & rand & "','" & TxtDias.Text & "','" & VentaC & "'"
                If TmpInsertDatos(Sql) = True Then
                End If
            End If
        Next


        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "RptLiquidacionVendedor.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

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