Public Class FrmActualizarSaldoDisponible

    Private Sub FrmActualizarSaldoDisponible_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim clienteDep As String

        Dim TablaClienteDep As New DataTable

        Conecta("sp_select_clientedep    '" & codempresa & "'", "D")
        TablaClienteDep = ds.Tables("D")



        For A As Integer = 0 To TablaClienteDep.Rows.Count - 1
            clienteDep = TablaClienteDep.Rows(A)("codcliente")

            Dim total As Double
            Dim SaldoDisponible As Double

            Dim clienteprincipal As String

            Conecta("SP_BUSC_CLIEPRINCIPAL_CODDEP    '" & codempresa & "','" & clienteDep & "'", "D")

            Dim TablaTemp As New DataTable
            TablaTemp = ds.Tables("D")

            If TablaTemp.Rows.Count > 0 Then

                total = Format(CDbl(TablaTemp.Rows(0)("mtolimcred")), "#######0.00")
                clienteprincipal = TablaTemp.Rows(0)("codigo")

                Dim TAB_DETALLE As DataTable
                TAB_DETALLE = TmpListarDatos("SP_SELECT_COBRANZAXCLIENTE '" & codempresa & "','" & clienteprincipal & "'")

                Dim lineaUtilidad As Double
                If TAB_DETALLE.Rows.Count > 0 Then

                    lineaUtilidad = TAB_DETALLE.Rows(0)(0).ToString

                Else
                    lineaUtilidad = 0
                End If

                SaldoDisponible = Format(CDbl(total) - CDbl(lineaUtilidad), "#######0.00")
                Conecta("SP_UPDATE_SALDODISPONIBLE    '" & codempresa & "','" & clienteprincipal & "','" & SaldoDisponible & "'", "D")
            End If

        Next


        MsgBox("SE ACTUALIZO")




    End Sub
End Class