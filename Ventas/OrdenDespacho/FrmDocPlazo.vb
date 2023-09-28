Public Class FrmDocPlazo
    Dim dt As New DataTable

    Public X As String


    Private Sub FrmDocPlazo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt = CAyuda.ListarDatos("SP_LISTA_DOC_PED", X).Tables(0)
        Me.dgdata.DataSource = dt

    End Sub
End Class