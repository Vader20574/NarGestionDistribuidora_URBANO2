Imports CapaCliente

Public Class FrmTransFacturacion
    Dim TABLE_ORDENDESPACHO As DataTable
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim FechaIni, FechaFin As String
        FechaIni = Format(CDate(DtFechaIni.Value), "dd/MM/yyyy")
        FechaFin = Format(CDate(DtFechaFin.Value), "dd/MM/yyyy")
        nromeses = DateDiff("m", FechaIni, FechaFin)

        TABLE_ORDENDESPACHO = TmpListarDatos("SP_SELECT_FACTURAS_COLGATE  '" & FechaIni & "','" & FechaFin & "','049'")
        grid1.DataSource = TABLE_ORDENDESPACHO

        Dim TABLE_TOTALDOC As DataTable
        TABLE_TOTALDOC = TmpListarDatos("SP_TOTAL_FACTURAS  '03'")
        If TABLE_TOTALDOC.Rows.Count > 0 Then
            lblTboleta.Text = TABLE_TOTALDOC.Rows(0)(0).ToString
        End If

        Dim TABLE_TOTALDOC2 As DataTable
        TABLE_TOTALDOC2 = TmpListarDatos("SP_TOTAL_FACTURAS  '01'")
        If TABLE_TOTALDOC.Rows.Count > 0 Then
            Label3.Text = TABLE_TOTALDOC2.Rows(0)(0).ToString
        End If

        Dim TABLE_TOTALDOC3 As DataTable
        TABLE_TOTALDOC3 = TmpListarDatos("SP_TOTAL_FACTURAS_TODO  '01'")
        If TABLE_TOTALDOC.Rows.Count > 0 Then
            Label5.Text = TABLE_TOTALDOC3.Rows(0)(0).ToString
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

    Private Sub FrmTransFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(cbTipoDoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim FRMPAIS As New FRMFACTURACIONP
        FRMPAIS.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim TablaDircli As DataTable
        TablaDircli = CAyuda.ListarDatos("SP_VALIDAR_VENTACABP", codempresa.Trim, cbTipoDoc.SelectedValue, Me.txtNroDoc1.Text).Tables(0)

        If TablaDircli.Rows.Count > 0 Then
            TmpInsertDatos("SP_DELETE_VENTACABP  '" & codempresa & "','" & cbTipoDoc.SelectedValue & "','" & Me.txtNroDoc1.Text & "'")
            MsgBox("Se Elimino")
        End If



    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim frm As New FrmDocAnulados()
        frm.codlinea = "001"
        frm.Show()




    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged


        If CheckBox1.Checked = True Then
            Label7.Visible = True
            cbTipoDoc.Visible = True
            Label2.Visible = True
            txtNroDoc1.Visible = True
            Button3.Visible = True
        End If

        If CheckBox1.Checked = False Then
            Label7.Visible = False
            cbTipoDoc.Visible = False
            Label2.Visible = False
            txtNroDoc1.Visible = False
            Button3.Visible = False
        End If

    End Sub
End Class