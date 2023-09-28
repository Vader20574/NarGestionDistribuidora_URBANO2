Public Class frmPorcDesXefec

    Private Sub frmPorcDesXefec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(cbolinea, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim Tmp_DESC As DataTable
        Tmp_DESC = TmpListarDatos("ZP_LISTART_DEC  '" & cbolinea.SelectedValue & "'")
        DataGrid1.DataSource = Tmp_DESC




        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Rpt_PorcentDesc.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_StoredProcParam(0, cbolinea.SelectedValue)
            'crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
            'crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            'crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            'crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            'crRpt.set_Formulas(0, "Empresa='" & codempresa & "'")
            'crRpt.set_Formulas(1, "Usuario='" & DesUsuario & "'")

            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim Tmp_DESC As DataTable
        Tmp_DESC = TmpListarDatos("ZP_LISTART_DEC2  '" & cbolinea.SelectedValue & "'")
        DataGrid1.DataSource = Tmp_DESC




        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Rpt_PorcentDescTodo.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_StoredProcParam(0, cbolinea.SelectedValue)
            'crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
            'crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            'crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            'crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            'crRpt.set_Formulas(0, "Empresa='" & codempresa & "'")
            'crRpt.set_Formulas(1, "Usuario='" & DesUsuario & "'")

            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class