Public Class FrmVentaXCobrar

    Dim rand As Integer


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "RptVentaxCobrar.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, RAND)


                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim PROCESO As Boolean
        Dim Sql As String

        Sql = "SP_UPDATE_VENTA_X_COBRAR '" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "'"
        PROCESO = TmpInsertDatos(Sql)
        If PROCESO = True Then

        End If

    End Sub

    Private Sub FrmVentaXCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()
    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


End Class