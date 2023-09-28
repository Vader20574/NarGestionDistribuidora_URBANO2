Public Class frmReporteLineasCredito

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        TmpInsertDatos("NSP_INSERT_LINEA_CRED '" & codempresa & "','" & rand & "'")

        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Reporte_Lineas_Credito.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                '.set_Formulas(2, "FechaIni='" & dtpinicio.Value.ToShortDateString & "'")
                '.set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
                '.set_Formulas(4, "Distrito='" & cmbdistrito.Text & "'")
                '.set_Formulas(5, "Ruta='" & cmbruta.Text & "'")
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

    Private Sub frmReporteLineasCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()
    End Sub
    Dim rand As Integer
    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


End Class