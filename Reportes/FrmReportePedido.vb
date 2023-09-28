Public Class FrmReportePedido
    Private Tb_ClienteDisponible As New DataTable

    Private Tb_ClienteModSelec As New DataTable

    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable


    Private Tb_DistritoDisponible As New DataTable
    Private Tb_DistritoModSelec As New DataTable


    Dim ACTIVOCLIENTE As Int16


    Dim Sql As String
    Dim RUTA As String


    Dim ListaV, ListaV2 As New List(Of ReporteVentaE)
    Dim i As Int32


    Dim rand As Integer


    Private Sub FrmReporteCliente_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim dt As New DataTable
        Dim dr As DataRow
        dt = CAyuda.ListarDatos("sp_listvendedor", codempresa).Tables(0)
        dr = dt.NewRow()
        dr.Item(0) = ""
        dr.Item(1) = "<< TODOS >>"
        dt.Rows.InsertAt(dr, 0)
        Me.cmbvendedor.DataSource = dt
        Me.cmbvendedor.DisplayMember = "DSVEND"
        Me.cmbvendedor.ValueMember = "CODVEND"

        dt = New DataTable
        dt = CAyuda.ListarDatos("NSP_LISTAR_RUTA_1", codempresa).Tables(0)
        dr = dt.NewRow()
        dr.Item(0) = ""
        dr.Item(1) = "<< TODOS >>"
        dt.Rows.InsertAt(dr, 0)
        Me.cmbruta.DataSource = dt
        Me.cmbruta.DisplayMember = "DESCRIPCION"
        Me.cmbruta.ValueMember = "CODIGO"

      

        ValorRan()


        CAyuda.CargarDataCombo(cbopais, "Nsp_sel_Pais '" & codempresa & "'", "Codigo", "Descripcion")




    End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Function LLenar(ByVal dt As DataTable) As List(Of ReporteVentaE)
        Dim lista As New List(Of ReporteVentaE)
        For Each dr As DataRow In dt.Rows
            Dim o As New ReporteVentaE
            o.CODIGO = dr.Item(0).ToString
            o.DESCRIPCION = dr.Item(1).ToString
            lista.Add(o)
        Next
        Return lista
    End Function





 

    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporte.Click





        'Dim formTotLetrasDoc As String
        'formTotLetrasDoc = FACT_TotalLetras(lbltotal.Text, "NUEVOS SOLES")
        ' StrMonLet = FACT_TotalLetras(CDbl(Table_Busq.Rows(0)("TOTBAS").ToString), "NUEVOS SOLES")

        CAyuda.Ejecutar("SP_INSERT_TMP_PEDIDO", codempresa, rand, String.Format(Me.dtpinicio.Value.ToShortDateString, "dd/MM/yyyy"), String.Format(Me.dtpfin.Value.ToShortDateString, "dd/MM/yyyy"), cmbvendedor.SelectedValue.ToString, cdistrito.SelectedValue.ToString, cmbruta.SelectedValue.ToString)


        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Rpt_Pedido.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_Formulas(0, "Caja='" & cmbvendedor.Text & "'")
            crRpt.set_Formulas(1, "Distrito='" & cdistrito.Text & "'")
            crRpt.set_Formulas(2, "Empresa='" & DesEmpresa & "'")
            crRpt.set_Formulas(3, "FechaH='" & dtpfin.Value.ToShortDateString & "'")
            crRpt.set_Formulas(4, "Fechaini='" & dtpinicio.Value.ToShortDateString & "'")
            crRpt.set_Formulas(5, "TipoOpera='" & cmbruta.Text & "'")
            crRpt.set_Formulas(6, "usuario='" & DesUsuario & "'")





            crRpt.set_StoredProcParam(0, rand)
            'crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
            'crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            'crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            'crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            'crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")

            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

  


   
    Private Sub cciud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

   


    Private Sub cbopais_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cdepa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cdepa_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdepa.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cciud, "Nsp_select_Ciudad_combo2 '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "'", "Codigo", "Descripcion")
        Catch x As Exception
        End Try
    End Sub

    Private Sub cciud_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cciud.SelectedIndexChanged

        Try
            CAyuda.CargarDataCombo(cdistrito, "Nsp_select_distrito_J '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "','" & cciud.SelectedValue.ToString & "'", "Codigo", "Descripcion")
        Catch x As Exception
        End Try



        'Try
        '    Dim dr As DataRow
        '    Dim dt As DataTable
        '    dt = New DataTable
        '    dt = CAyuda.ListarDatos("Nsp_select_distrito '" & cbopais.SelectedValue.ToString & "','" & cdepa.SelectedValue.ToString & "','" & cciud.SelectedValue.ToString & "'").Tables(0)
        '    dr = dt.NewRow()
        '    dr.Item(0) = "0"
        '    dr.Item(1) = "<< TODOS >>"
        '    dt.Rows.InsertAt(dr, 0)
        '    Me.cdistrito.DataSource = dt
        '    Me.cdistrito.DisplayMember = "DESCRIPCION"
        '    Me.cdistrito.ValueMember = "CODIGO"


        'Catch x As Exception
        'End Try
    End Sub

    Private Sub cdistrito_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cdistrito.SelectedIndexChanged




    End Sub

    Private Sub cbopais_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopais.SelectedIndexChanged
        Try
            CAyuda.CargarDataCombo(cdepa, "sele_depa '" & cbopais.SelectedValue.ToString & "','" & codempresa & "'", "iddepa", "depa")
        Catch x As Exception
        End Try

    End Sub
End Class