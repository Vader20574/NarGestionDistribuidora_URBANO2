Public Class FrmValPromo


	Dim dt As New DataTable
    Public CORREL As Integer
    Public fecha As String


    Private Sub FrmValPromo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CAyuda.Ejecutar("SP_CANT_PROMO", codempresa, CORREL)
        dt = CAyuda.ListarDatos("SP_PROMO_TOTAL", CORREL, fecha).Tables(0)
        Me.DataGridView1.DataSource = dt

    End Sub

End Class