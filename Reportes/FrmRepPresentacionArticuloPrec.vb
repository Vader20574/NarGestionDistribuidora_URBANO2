Public Class FrmRepPresentacionArticuloPrec

    Dim ACT_EVENTOS As Integer

    Private Sub FrmRepPresentacionArticuloPrec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(cbolinea, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")
        cbolinea.SelectedIndex = 0

        MostrarSubCategoria()

    End Sub

    Private Sub MostrarSubCategoria()
        Dim TABLE_SUBCAT As DataTable

        TABLE_SUBCAT = TmpListarDatos("SP_SELECT_SUBLINEAxLINEA '" & codempresa.Trim & "' ,'" & cbolinea.SelectedValue & "'")
        cbosublinea.DataSource = TABLE_SUBCAT
        cbosublinea.ValueMember = "CODSUBLINEA"
        cbosublinea.DisplayMember = "DESSUBLINEA"

    End Sub

    Private Sub cbosublinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosublinea.SelectedIndexChanged
       
    End Sub

    Private Sub cbolinea_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbolinea.Click
        ACT_EVENTOS = 1
    End Sub

    Private Sub cbolinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbolinea.SelectedIndexChanged
        If ACT_EVENTOS = 1 Then
            MostrarSubCategoria()
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p1 As Integer = 0
        Dim p2 As Integer = 0



        If CheckBox4.Checked = True Then


            Try
                Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                crRpt.ReportFileName = rutareporte & "Rpt_Presentacion_Articulo_precio3.rpt"
                crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                crRpt.set_StoredProcParam(0, codempresa)
                crRpt.set_StoredProcParam(1, cbolinea.SelectedValue)


                crRpt.set_StoredProcParam(2, "0")



                crRpt.set_StoredProcParam(3, 1)
                'crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
                'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                crRpt.Destination = Crystal.DestinationConstants.crptToWindow
                crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                crRpt.Action = 1
                crRpt.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Exit Sub


        End If




        If CheckBox5.Checked = True Then


            Try
                Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                crRpt.ReportFileName = rutareporte & "Rpt_Presentacion_Articulo_precio2_1.rpt"
                crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                crRpt.set_StoredProcParam(0, codempresa)
                crRpt.set_StoredProcParam(1, cbolinea.SelectedValue)


                crRpt.set_StoredProcParam(2, "0")



                crRpt.set_StoredProcParam(3, 1)
                crRpt.set_StoredProcParam(4, "A")
                crRpt.set_StoredProcParam(5, "B")

                'crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
                'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                crRpt.Destination = Crystal.DestinationConstants.crptToWindow
                crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                crRpt.Action = 1
                crRpt.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Exit Sub


        End If






        If CheckBox3.Checked = False Then


            Try
                Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                crRpt.ReportFileName = rutareporte & "Rpt_Presentacion_Articulo_precio.rpt"
                crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                crRpt.set_StoredProcParam(0, codempresa)
                crRpt.set_StoredProcParam(1, cbolinea.SelectedValue)

                If CheckBox2.Checked = True Then
                    crRpt.set_StoredProcParam(2, "0")
                Else
                    crRpt.set_StoredProcParam(2, cbosublinea.SelectedValue)
                End If


                crRpt.set_StoredProcParam(3, CInt(CheckBox1.Checked()))
                'crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
                'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                crRpt.Destination = Crystal.DestinationConstants.crptToWindow
                crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                crRpt.Action = 1
                crRpt.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else

            Try
                Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                crRpt.ReportFileName = rutareporte & "Rpt_Presentacion_Articulo_precio2.rpt"
                crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                crRpt.set_StoredProcParam(0, codempresa)
                crRpt.set_StoredProcParam(1, cbolinea.SelectedValue)

                If CheckBox2.Checked = True Then
                    crRpt.set_StoredProcParam(2, "0")
                Else
                    crRpt.set_StoredProcParam(2, cbosublinea.SelectedValue)
                End If


                crRpt.set_StoredProcParam(3, CInt(CheckBox1.Checked()))
                'crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
                'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                crRpt.Destination = Crystal.DestinationConstants.crptToWindow
                crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                crRpt.Action = 1
                crRpt.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If











    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class