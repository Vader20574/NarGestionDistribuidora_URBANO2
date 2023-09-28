Public Class FrmCreditoXCliente
    Dim rand As Integer



    Dim fechaini, fechahas As Date
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String


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



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click





        TmpInsertDatos("DELETE FROM TMP_VENTAX  WHERE CORREL='" & rand & "'")


        Dim FechaIni, FechaFin As String
        FechaIni = Format(CDate(dtpinicio.Value), "dd/MM/yyyy")
        FechaFin = Format(CDate(dtpfin.Value), "dd/MM/yyyy")


        nromeses = DateDiff("m", FechaIni, FechaFin)

        For i As Integer = 0 To nromeses

            NomTablaC = "VENTC" & Format(DateAdd("m", i, FechaIni), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, FechaIni), "yyyyMM")

            If VERIFICA_HISTORICOVENT(NomTablaC) = True Then
                TmpInsertDatos("NSP_DIASCRED  '" & codempresa & "','" & TextBox1.Text & "','" & dtpinicio.Value.ToShortDateString & "','" & dtpfin.Value.ToShortDateString & "','" & rand & "','" & NomTablaC & "','" & NomTablaD & "'")
            End If
        Next

        TmpInsertDatos("NSP_DIASCRED  '" & codempresa & "','" & TextBox1.Text & "','" & dtpinicio.Value.ToShortDateString & "','" & dtpfin.Value.ToShortDateString & "','" & rand & "','',''")







        '  CAyuda.Ejecutar("NSP_DIASCRED", codempresa, TextBox1.Text, dtpinicio.Value.ToShortDateString, dtpfin.Value.ToShortDateString, rand)




        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rep_DiasCred.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                ' .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
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

    Private Sub FrmCreditoXCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()
    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Dim TB_BUSQCLIDEP As DataTable

            TB_BUSQCLIDEP = TmpListarDatos("SP_CLIENTE_DESCRIP '" & codempresa & "','" & TextBox1.Text & "'")
            If TB_BUSQCLIDEP.Rows.Count > 0 Then
                VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
                TextBox2.Text = VAR1
            End If
        End If


    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class