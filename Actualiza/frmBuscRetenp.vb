Public Class frmBuscRetenp
    Public dt As New DataTable
    Dim data As New DataTable
    Public Var As Boolean
    Private Sub dgblista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgblista.DoubleClick
        If Me.dgblista.CurrentRow.Index < 0 Then Exit Sub

        If Var = False Then
            dt = CAyuda.ListarDatos("SP_SELEC_RETENCPRO", codempresa, Me.dgblista.Item("CODIGO", Me.dgblista.CurrentRow.Index).Value.ToString(), 0).Tables(0)
        Else
            dt = CAyuda.ListarDatos("SP_SELEC_PERCEPROV", codempresa, Me.dgblista.Item("CODIGO", Me.dgblista.CurrentRow.Index).Value.ToString(), 0).Tables(0)
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmBuscRetenp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Var = False Then
            dt = CAyuda.ListarDatos("SP_SELEC_RETENCPRO", codempresa, "", 1).Tables(0)
        Else
            dt = CAyuda.ListarDatos("SP_SELEC_PERCEPROV", codempresa, "", 1).Tables(0)

        End If

        Me.dgblista.DataSource = dt
    End Sub
End Class