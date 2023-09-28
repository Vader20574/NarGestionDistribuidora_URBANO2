Public Class FrmFlujoCaja



    Dim rand As Integer
    Dim fechaini, fechahas As Date
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String




    Private Sub FrmFlujoCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Conecta("SELECT CODCAJA, DESC1CAJA, DESC2CAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "'", "DS1")
        Me.cmbcaja.ValueMember = "CODCAJA"
        Me.cmbcaja.DisplayMember = "DESC1CAJA"
        Me.cmbcaja.DataSource = ds.Tables("DS1")

        cbTipoMovimiento.SelectedIndex = 0

       
        CAyuda.CargarDataCombo(cbCuentaContable, "NSP_Select_Listado_CATEGORIA_CTACONTABLE  '" & codempresa & "'", "Código", "Descripción")



        ValorRan()


    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub btnconsul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsul.Click


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

        Dim VAR1 As String = ""
        Dim TB_BUSQCLIDEP As DataTable

        TB_BUSQCLIDEP = TmpListarDatos("MENOR_FECHA_CAJAMOVI '" & codempresa & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then
            VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
        End If



        If Cksubcta.Checked = True Then
            CAyuda.Ejecutar("SP_INSER_TTMP_FLUJOCAJA2", VAR1, String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy"), Me.cmbcaja.SelectedValue.ToString(), Me.cbTipoMovimiento.SelectedIndex + 1, rand, cbSubCuentaContable.SelectedValue.ToString)

            CAyuda.Ejecutar("SP_MODIFIC_SALDO_FLUJOCAJA", rand)



        Else
            CAyuda.Ejecutar("SP_INSER_TTMP_FLUJOCAJA", VAR1, String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy"), Me.cmbcaja.SelectedValue.ToString(), Me.cbTipoMovimiento.SelectedIndex + 1, rand, cbSubCuentaContable.SelectedValue.ToString)

            CAyuda.Ejecutar("SP_MODIFIC_SALDO_FLUJOCAJA", rand)


        End If

        CAyuda.Ejecutar("INS_TMP_FLUJOCAJA_2", rand, String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy"), String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy"))




        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_ReporteFlujoCaja.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Caja='" & cmbcaja.Text & "'")
                .set_Formulas(1, "Empresa='" & DesEmpresa & "'")


                .set_Formulas(2, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                .set_Formulas(3, "Fechaini='" & dtpinicio.Value.ToShortDateString & "'")
                .set_Formulas(4, "TipoOpera='" & Me.cbTipoMovimiento.Text & "'")

                .set_Formulas(5, "TipoProveedor='" & Me.cbCuentaContable.Text & "'")
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

    Private Sub cbCuentaContable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCuentaContable.SelectedIndexChanged

        CAyuda.CargarDataCombo(cbSubCuentaContable, "NSP_Select_Listado_SUBCTACONTABLE_2  '" & codempresa & "','" & cbCuentaContable.SelectedValue.ToString & "'", "Código", "Descripción")



    End Sub
End Class