Public Class FrmReporteHono

    Private Sub FrmReporteHono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        cboPeriodo.Items.Add("ENERO")
        cboPeriodo.Items.Add("FEBRERO")
        cboPeriodo.Items.Add("MARZO")
        cboPeriodo.Items.Add("ABRIL")
        cboPeriodo.Items.Add("MAYO")
        cboPeriodo.Items.Add("JUNIO")
        cboPeriodo.Items.Add("JULIO")
        cboPeriodo.Items.Add("AGOSTO")
        cboPeriodo.Items.Add("SEPTIEMBRE")
        cboPeriodo.Items.Add("OCTUBRE")
        cboPeriodo.Items.Add("NOVIEMBRE")
        cboPeriodo.Items.Add("DICIEMBRE")
        cboPeriodo.SelectedIndex = Date.Now.Month - 1




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click




        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "rpthonorario.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            'crRpt.set_Formulas(0, "Caja='" & cmbvendedor.Text & "'")
            'crRpt.set_Formulas(1, "Distrito='" & cdistrito.Text & "'")
            'crRpt.set_Formulas(2, "Empresa='" & DesEmpresa & "'")
            'crRpt.set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
            'crRpt.set_Formulas(4, "Fechaini='" & dtpinicio.Value.ToShortDateString & "'")
            'crRpt.set_Formulas(5, "TipoOpera='" & cmbruta.Text & "'")
            'crRpt.set_Formulas(6, "usuario='" & DesUsuario & "'")



            If CheckBox1.Checked = True Then
                crRpt.set_StoredProcParam(0, 1)
                crRpt.set_StoredProcParam(1, String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy"))
                crRpt.set_StoredProcParam(2, String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy"))
                crRpt.set_StoredProcParam(3, txtEjercicio.Text)
                crRpt.set_StoredProcParam(4, cboPeriodo.Text)

            End If

            If CheckBox2.Checked = True Then
                crRpt.set_StoredProcParam(0, 2)
                crRpt.set_StoredProcParam(1, String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy"))
                crRpt.set_StoredProcParam(2, String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy"))
                crRpt.set_StoredProcParam(3, txtEjercicio.Text)
                crRpt.set_StoredProcParam(4, cboPeriodo.Text)
            End If



            'crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
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