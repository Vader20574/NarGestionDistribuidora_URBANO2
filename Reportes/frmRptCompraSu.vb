Public Class frmRptCompraSu
    Dim rand As Integer
    Dim fechaini, fechahas As Date
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String
    Private Sub frmRptCompraSu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValorRan()

        Dim dt As New DataTable



        dt = CAyuda.ListarDatos("USP_CONSULTAR_PROVEEDORJ", "", "", codempresa).Tables(0)
        Me.cmbproveedor.DataSource = dt
        Me.cmbproveedor.DisplayMember = "DESPROVEEDOR"
        Me.cmbproveedor.ValueMember = "CODPROVEEDOR"

        'Dim dt2 As New DataTable
        'dt2 = New DataTable
        'dt2 = CAyuda.ListarDatos("ListarCOMPROBANTESxProcJ", codempresa, "1").Tables(0)
        'Me.cmbdocu.DataSource = dt2
        'Me.cmbdocu.DisplayMember = "DSTIPODOC"
        'Me.cmbdocu.ValueMember = "CODTIPODOC"


        CAyuda.CargarDataCombo(cmbdocu, "ListarCOMPROBANTESxProcJ '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")
        CAyuda.CargarDataCombo(ComboBox1, "ListarCOMPROBANTESxProcJ '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")


    End Sub
    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub btnconsul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsul.Click
        TmpInsertDatos("DELETE FROM TMP_RPT_REPOR_SUNA  WHERE CORREL='" & rand & "'")

        fechaini = String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy")
        fechahas = String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy")
        nromeses = DateDiff("m", fechaini, fechahas)

        For i As Integer = 0 To nromeses

            NomTablaC = "MOVIC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "MOVID" & Format(DateAdd("m", i, fechaini), "yyyyMM")

            If CAyuda.ListarDatos("SP_VERIFICA_HISTOMOVI", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                CAyuda.Ejecutar("SP_RPT_COMP_SU", rand, codempresa, Me.cmbproveedor.SelectedValue.ToString(), Me.cmbdocu.SelectedValue.ToString(), Me.dtpinicio.Value, Me.dtpfin.Value, VCODINGCOMP, NomTablaC, NomTablaD, 1)
            End If
        Next

        CAyuda.Ejecutar("SP_RPT_COMP_SU", rand, codempresa, Me.cmbproveedor.SelectedValue.ToString(), Me.cmbdocu.SelectedValue.ToString(), String.Format(dtpinicio.Value, "DD/MM/YYYY"), String.Format(Me.dtpfin.Value, "DD/MM/YYYY"), VCODINGCOMP, NomTablaC, NomTablaD, 0)

        MsgBox(ComboBox1.SelectedValue)


        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_Compra_Sunar.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                .set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                .set_Formulas(4, "Proveedor='" & Me.cmbproveedor.Text & "'")
                .set_Formulas(5, "Tipo='" & Me.cmbdocu.Text & "'")
                .set_StoredProcParam(0, rand)
                .set_StoredProcParam(1, cmbdocu.SelectedValue)
                .set_StoredProcParam(2, cmbproveedor.SelectedValue)

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

    Private Sub cmbproveedor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproveedor.SelectedIndexChanged

    End Sub

    Private Sub cmbdocu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdocu.SelectedIndexChanged

    End Sub
End Class