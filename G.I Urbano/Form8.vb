
Public Class Form8
    Public TipoDoc As String
    Public NroDoc As String

    Public Producto As String

    Public frm As FrmListarSolicitudServicio
    Public DEVOLVER As Boolean
    Public correl As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'If (TmpInsertDatos("SP_UPD_TMP_NTACREDCABSER  '" & NroDoc & "','" & TipoDoc & "','" & TxtObserv.Text & "'")) = True Then
        '    MsgBox("Se modifico")
        'Else
        '    MsgBox("error")
        'End If
        ''frm.obsv = TxtObserv.Text
        ''DEVOLVER = True

        'For i As Integer = 0 To frm.TABLE_NTACREDSERV.Rows.Count - 1
        '    If frm.TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim = correl _
        '    And frm.TABLE_NTACREDSERV.Rows(i)("NROREFE").ToString.Trim = NroDoc Then
        '        ''''''''''''''''''CAMBIAR EL ESTADO DE NTA CRED
        '        frm.TABLE_NTACREDSERV.Rows(i)("PRODUCTO") = TxtObserv.Text

        '    End If
        'Next
        'Me.Close()







    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtObserv.Text = Producto

    End Sub
End Class