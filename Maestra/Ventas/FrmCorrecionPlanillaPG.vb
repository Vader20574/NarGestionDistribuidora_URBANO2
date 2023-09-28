Public Class FrmCorrecionPlanillaPG

    Private Sub txtNroPlanilla_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroPlanilla.KeyPress

        If Asc(e.KeyChar) = 13 Then


            Dim TAB_COBRANZAC As New DataTable
            TAB_COBRANZAC = TmpListarDatos("PLANILLA_PAGOPROVEEDOR  '" & codempresa & "','" & txtNroPlanilla.Text.Trim & "','" & ComboBox1.SelectedValue & "'")

            If TAB_COBRANZAC.Rows.Count > 0 Then
              
                cbProvee.SelectedValue = TAB_COBRANZAC.Rows(0)("CODPROVEEDOR")

                dtpinicio.Value = Format(CDate(TAB_COBRANZAC.Rows(0)("FECHAPAGO")), "dd/MM/yyyy")

                txtImporte.Text = TAB_COBRANZAC.Rows(0)("TOTALBAS")
                'dtpFechaReg.Value = TAB_COBRANZAC.Rows(0)("fecha")

                Dim TablaFuerzaVenta As New DataTable
                Conecta("SP_RPT_COMPEN_PLAN_ORDEN2 '" & codempresa & "','" & txtNroPlanilla.Text.Trim & "'", "DTG")
                TablaFuerzaVenta = ds.Tables("DTG")
                Me.grid1.DataSource = TablaFuerzaVenta




            Else
                MsgBox("NO Hay datos")
            End If






        End If


    End Sub

    Private Sub TXTUSUARIO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroPlanilla.TextChanged

    End Sub

    Private Sub FrmCorrecionPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dt As New DataTable

        CAyuda.CargarDataCombo(ComboBox1, "LISTAR_PLANILLAS2 ", "CODIGO", "NOMBRE")

        CAyuda.CargarDataCombo(cbCaja, "SelecCAJA '" & codempresa & "'", "Código", "Descripción")




        CAyuda.CargarDataCombo(cbCuentaContable, "NSP_Select_Listado_CATEGORIA_CTACONTABLE  '" & codempresa & "'", "Código", "Descripción")

        CAyuda.CargarDataCombo(cbProvee, "SP_ListPROVEEDOR  '" & codempresa & "'", "Código", "Descripción")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)







    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim RptaTrans As Boolean
        RptaTrans = CAyuda.Ejecutar("SP_UPD_PAGOSCAB", codempresa, txtNroPlanilla.Text, dtpinicio.Value.ToShortDateString, cbProvee.SelectedValue)
        'sql = "NSP_upd_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.text.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.txtBanca.text & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
        If RptaTrans Then
            MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If

        txtNroPlanilla.Text = ""


        txtImporte.Text = ""

        dtpinicio.Value = Date.Now


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim TablaFuerzaVenta As New DataTable
        Conecta("SP_RPT_COMPEN_PLAN_ORDEN2 '01','78001338'", "DTG")
        TablaFuerzaVenta = ds.Tables("DTG")
        Me.grid1.DataSource = TablaFuerzaVenta

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick





        Dim TB_01 As DataTable
        TB_01 = TmpListarDatos("SP_CODSUBCTACONTABLE '" & codempresa & "','" & grid1(grid1.CurrentRowIndex, 3) & "'")

        If TB_01.Rows.Count > 0 Then
            cbCuentaContable.SelectedValue = TB_01.Rows(0)("CODLINEA")
        End If


        cbSubCuentaContable.SelectedValue = grid1(grid1.CurrentRowIndex, 3)





        TextBox1.Text = grid1(grid1.CurrentRowIndex, 0)


        TextBox2.Text = grid1(grid1.CurrentRowIndex, 1)


        cbCaja.SelectedValue = grid1(grid1.CurrentRowIndex, 2)




        TextBox5.Text = grid1(grid1.CurrentRowIndex, 4)

        dtpFechaReg.Value = grid1(grid1.CurrentRowIndex, 5)



    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim RptaTrans As Boolean
        RptaTrans = CAyuda.Ejecutar("Sp_update_CAJAMOVI", codempresa, TextBox2.Text, cbSubCuentaContable.SelectedValue, TextBox1.Text, dtpFechaReg.Value.ToShortDateString, cbCaja.SelectedValue)
        'sql = "NSP_upd_VENDEDOR '" & tvendedor.Text & "','" & tcodigo.Text & "','" & CodEmpresa & "','" & txtctaBanca.text.ToString & "','" & cciudad.SelectedValue.ToString & "'," & tcuotat.Text & "," & tcuotas.Text & "," & tcuotad.Text & ",'" & Microsoft.VisualBasic.DateValue(Now) & "','" & CodUsuario & "','" & Me.cptoventa.SelectedValue.ToString & "','" & Me.txtBanca.text & "','" & Me.cbZonaVenta.SelectedValue & "','" & Me.cbRuta.SelectedValue & "'"
        If RptaTrans Then
            TextBox1.Text = ""
            TextBox2.Text = ""

            TextBox5.Text = ""

            dtpFechaReg.Value = Date.Now

            Dim TablaFuerzaVenta As New DataTable
            Conecta("SP_RPT_COMPEN_PLAN_ORDEN2 '" & codempresa & "','" & txtNroPlanilla.Text.Trim & "'", "DTG")
            TablaFuerzaVenta = ds.Tables("DTG")
            Me.grid1.DataSource = TablaFuerzaVenta



            MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If


    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub cbSubCuentaContable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSubCuentaContable.SelectedIndexChanged

    End Sub

    Private Sub cbCuentaContable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCuentaContable.SelectedIndexChanged

        CAyuda.CargarDataCombo(cbSubCuentaContable, "NSP_Select_Listado_SUBCTACONTABLE  '" & codempresa & "','" & cbCuentaContable.SelectedValue.ToString & "'", "Código", "Descripción")


    End Sub

    Private Sub txtImporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporte.TextChanged

    End Sub
End Class