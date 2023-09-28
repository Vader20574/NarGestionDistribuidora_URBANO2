Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim TAB_CLIENTE As DataTable
        TAB_CLIENTE = TmpListarDatos("SP_ListClientesBorrados  '" & codempresa & "'")
        GridVend.DataSource = TAB_CLIENTE
    End Sub

    Private Sub GridVend_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVend.DoubleClick
        Dim nrodoc As String
        nrodoc = GridVend.Item(GridVend.CurrentRowIndex, 0)

        Dim frmdet As New FormDocClientesBorrados
        frmdet.nrodoc = nrodoc

        frmdet.ShowDialog()

    End Sub

    Private Sub GridVend_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridVend.Navigate

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class