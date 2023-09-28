Public Class FormDocClientesBorrados
    public nrodoc As String


    Private Sub FormDocClientesBorrados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TAB_CLIENTE As DataTable
        TAB_CLIENTE = TmpListarDatos("SP_ListDocClientesBorrados  '" & codempresa & "','" & nrodoc & "'")
        GridVend.DataSource = TAB_CLIENTE



    End Sub
End Class