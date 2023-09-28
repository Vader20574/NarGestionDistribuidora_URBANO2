Public Class FrmMensague
    Public ALMACEN As String
    Public ESTADO As Boolean

    Public FRM As FrmCargarPedido_a_Camion

    Private Sub FrmMensague_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = "ESTA SELECCIONANDO EL " & ALMACEN

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FRM.PROCESO()
        ESTADO = True
        Me.Close()

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ESTADO = False
        Me.Close()
    End Sub
End Class