Public Class FrmMantAccesos

    Private Sub FrmMantAccesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CAyuda.CargarDataCombo(cmbnivel, "NSP_Select_Listado_Nivel  '" & codempresa & "'", "Código", "Descripción")



        CAyuda.CargarDataCombo(cb_modulos, "SP_MODULOS '" & codempresa & "'", "Codigo", "Descripcion")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim dt As New DataTable
        dt = CAyuda.ListarDatos("SP_BUS_ACCESO", codempresa, cmbnivel.SelectedValue, cb_modulos.SelectedValue).Tables(0)
        If dt.Rows.Count > 0 Then
            MsgBox("El acceso ya existe.", MsgBoxStyle.Information, "Aviso")
            Exit Sub
        End If

        CAyuda.Ejecutar("SP_INSERT_ACCESO", codempresa, cmbnivel.SelectedValue, cb_modulos.SelectedValue)
    End Sub

    Private Sub cmbnivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnivel.SelectedIndexChanged

    End Sub
End Class