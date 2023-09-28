Public Class frmPromocion2
    Dim meses As New List(Of MesesE)
    Private Sub frmPromocion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        meses.Add(New MesesE("01", "Enero"))
        meses.Add(New MesesE("02", "Febrero"))
        meses.Add(New MesesE("03", "Marzo"))
        meses.Add(New MesesE("04", "Abril"))
        meses.Add(New MesesE("05", "Mayo"))
        meses.Add(New MesesE("06", "Junio"))
        meses.Add(New MesesE("07", "Julio"))
        meses.Add(New MesesE("08", "Agosto"))
        meses.Add(New MesesE("09", "Setiembre"))
        meses.Add(New MesesE("10", "Octubre"))
        meses.Add(New MesesE("11", "Noviembre"))
        meses.Add(New MesesE("12", "Diciembre"))

        Me.cmbmes.DataSource = meses
        cmbmes.DisplayMember = "mes"
        cmbmes.ValueMember = "codigo"

        Dim anioi, aniof As Integer
        anioi = 2012
        aniof = vFechaActual.Year + 3

        Do
            cmbanio.Items.Add(anioi)
            anioi += 1
        Loop While anioi <= aniof

        Me.cmbanio.SelectedIndex = 0
    End Sub


    Private Sub btnpromoprod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpromoprod.Click
        Rpt("Rpt_PromocionesT.rpt")
    End Sub

    Sub Rpt(ByVal rpt As String)
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & rpt
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "anio='" & cmbanio.Text & "'")
                .set_Formulas(1, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(2, "mes='" & cmbmes.SelectedItem.ToString & "'")
                .set_Formulas(3, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                .set_StoredProcParam(1, CInt(cmbmes.SelectedValue))
                .set_StoredProcParam(2, cmbanio.Text)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnpromosub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpromosub.Click
        Rpt("Rpt_Promociones_Categ.rpt")
    End Sub
End Class