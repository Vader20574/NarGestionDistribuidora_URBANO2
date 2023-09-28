Imports System.Data.SqlClient
Public Class frmExportaNex

    Private Sub btnprecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprecios.Click
        If MessageBox.Show("Desea exportar la tabla completa?", DesEmpresa, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Control(Me, False)
            Dim hilo2 As New Threading.Thread(AddressOf Precios)
            hilo2.Start()
        End If
    End Sub


    Public Sub Precios()



        Try
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_UPD_NEXT_PRECIOS", codempresa, VCODNEXTEL).Tables(0)
            CAyuda.Ejecutar(2, "SP_N_DELETE_ALL_PRESENTACION", VCODNEXTEL)

            Dim cnx As New SqlConnection(STRCN2)




            cnx.Open()

         
          


            Dim bullkdata As New SqlBulkCopy(cnx)
            bullkdata.BulkCopyTimeout = 50000
            bullkdata.DestinationTableName = "TBL_PRESENTACION"
            bullkdata.WriteToServer(dt)
            bullkdata.Close()
            cnx.Close()
            MsgBox("Se importo todos los precios.")
        Catch ex As Exception
            MsgBox("Hubo un problema al exportar." & vbNewLine & ex.Message, MsgBoxStyle.Information, DesEmpresa)
        End Try
        Me.Cursor = Cursors.Default
        Control(Me, True)
    End Sub
    Public Sub Clientes()



        Try

            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_LIST_CLIENTES_NEXTEL", codempresa, VCODNEXTEL).Tables(0)
            CAyuda.Ejecutar(2, "SP_N_DELETE_ALL_CLIENTES", VCODNEXTEL)

            Dim cnx As New SqlConnection(STRCN2)
            cnx.Open()
            Dim bullkdata As New SqlBulkCopy(cnx)
            bullkdata.BulkCopyTimeout = 50000
            bullkdata.DestinationTableName = "TBL_CLIENTE"
            bullkdata.WriteToServer(dt)
            bullkdata.Close()
            cnx.Close()

            MsgBox("Se importo todos los clientes.")

        Catch ex As Exception
            MsgBox("Hubo un problema al exportar." & vbNewLine & ex.Message, MsgBoxStyle.Information, DesEmpresa)
        End Try
        Me.Cursor = Cursors.Default
        Control(Me, True)

    End Sub



    Private Sub btnclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclientes.Click
        If MessageBox.Show("Desea exportar la tabla completa?", DesEmpresa, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Control(Me, False)
            Dim hilo3 As New Threading.Thread(AddressOf Clientes)
            hilo3.Start()
        End If
    End Sub

    Private Sub btnproductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproductos.Click
        If MessageBox.Show("Desea exportar la tabla completa?", DesEmpresa, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Control(Me, False)
            Dim hilo1 As New Threading.Thread(AddressOf Articulos)
            hilo1.Start()


        End If
    End Sub

    Public Sub Articulos()

        Try
            Dim dt As New DataTable
            vcdAlmacen = TmpListarDatos("select top 1 cdalmacen from almazon where codempresa='" & codempresa & "' and cdzona='" & CDZONA & "'").Rows(0)(0)

            dt = CAyuda.ListarDatos("SP_LIST_ARTICULOS_NEXTEL", codempresa, vcdAlmacen.Trim, VCODNEXTEL).Tables(0)

            CAyuda.Ejecutar(2, "SP_N_DELETE_ALL_PRODUCTOS", VCODNEXTEL)

            Dim cnx As New SqlConnection(STRCN2)
            cnx.Open()
            Dim bullkdata As New SqlBulkCopy(cnx)
            bullkdata.BulkCopyTimeout = 50000
            bullkdata.DestinationTableName = "TBL_PRODUCTO"
            bullkdata.WriteToServer(dt)
            bullkdata.Close()
            cnx.Close()

            MsgBox("Se importo todos los Articulos.")

        Catch ex As Exception
            MsgBox("Hubo un problema al exportar." & vbNewLine & ex.Message, MsgBoxStyle.Information, DesEmpresa)
        End Try

        Me.Cursor = Cursors.Default
        Control(Me, True)
    End Sub

    Private Sub btnvended_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvended.Click
        If MessageBox.Show("Desea exportar la tabla completa?", DesEmpresa, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Control(Me, False)
            Dim hilo4 As New Threading.Thread(AddressOf Vendedor)
            hilo4.Start()
        End If
    End Sub
    Public Sub Vendedor()


        Try

            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_LIST_VENDEDOR_NEXTEL", codempresa, VCODNEXTEL).Tables(0)
            CAyuda.Ejecutar(2, "SP_N_DELETE_ALL_VENDEDOR", VCODNEXTEL)

            Dim cnx As New SqlConnection(STRCN2)
            cnx.Open()
            Dim bullkdata As New SqlBulkCopy(cnx)
            bullkdata.BulkCopyTimeout = 50000
            bullkdata.DestinationTableName = "TBL_VENDEDOR"
            bullkdata.WriteToServer(dt)
            bullkdata.Close()
            cnx.Close()

            MsgBox("Se importo todos los vendedores.")

        Catch ex As Exception
            MsgBox("Hubo un problema al exportar." & vbNewLine & ex.Message, MsgBoxStyle.Information, DesEmpresa)
        End Try
        Me.Cursor = Cursors.Default
        Control(Me, True)

    End Sub

    Private Sub btnpago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpago.Click
        If MessageBox.Show("Desea exportar la tabla completa?", DesEmpresa, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Control(Me, False)
            Dim hilo5 As New Threading.Thread(AddressOf FormaPago)
            hilo5.Start()
        End If
    End Sub

    Public Sub FormaPago()

        Try
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_LIST_TIPOPAGO_NEXTEL", codempresa, VCODNEXTEL).Tables(0)

            CAyuda.Ejecutar(2, "SP_N_DELETE_ALL_FORMAPAGO", VCODNEXTEL)

            Dim cnx As New SqlConnection(STRCN2)
            cnx.Open()
            Dim bullkdata As New SqlBulkCopy(cnx)
            bullkdata.BulkCopyTimeout = 50000
            bullkdata.DestinationTableName = "TBL_FORMA_PAGO"
            bullkdata.WriteToServer(dt)
            bullkdata.Close()
            cnx.Close()

            MsgBox("Se importo todos los registros.")

        Catch ex As Exception
            MsgBox("Hubo un problema al exportar." & vbNewLine & ex.Message, MsgBoxStyle.Information, DesEmpresa)
        End Try
        Me.Cursor = Cursors.Default
        Control(Me, True)

    End Sub

    Private Sub btnbancos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbancos.Click
        If MessageBox.Show("Desea exportar la tabla completa?", DesEmpresa, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Control(Me, False)
            Dim hilo7 As New Threading.Thread(AddressOf Bancos)
            hilo7.Start()
        End If
    End Sub

    Public Sub Bancos()
     

        Try
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_LIST_BANCOS_NEXTEL", codempresa, VCODNEXTEL.Trim).Tables(0)

            CAyuda.Ejecutar(2, "SP_N_DELETE_ALL_BANCOS", VCODNEXTEL)

            Dim cnx As New SqlConnection(STRCN2)
            cnx.Open()
            Dim bullkdata As New SqlBulkCopy(cnx)
            bullkdata.BulkCopyTimeout = 50000
            bullkdata.DestinationTableName = "tbl_bancos"
            bullkdata.WriteToServer(dt)
            bullkdata.Close()
            cnx.Close()

            MsgBox("Se importo todos los registros.")

        Catch ex As Exception
            MsgBox("Hubo un problema al exportar." & vbNewLine & ex.Message, MsgBoxStyle.Information, DesEmpresa)
        End Try
        Me.Cursor = Cursors.Default
        Control(Me, True)

    End Sub

    Private Sub btndeudas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeudas.Click
        If MessageBox.Show("Desea exportar la tabla completa?", DesEmpresa, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Control(Me, False)
            Dim hilo6 As New Threading.Thread(AddressOf DeudasCli)
            hilo6.Start()
        End If

    End Sub

    Public Sub DeudasCli()


        Try
            Dim dt As New DataTable
            dt = CAyuda.ListarDatos("SP_LIST_DEUDAS_NEXTEL", codempresa, VCODNEXTEL.Trim).Tables(0)
            CAyuda.Ejecutar(2, "SP_N_DELETE_ALL_DEUDAS", VCODNEXTEL)

            Dim cnx As New SqlConnection(STRCN2)
            cnx.Open()
            Dim bullkdata As New SqlBulkCopy(cnx)
            bullkdata.BulkCopyTimeout = 50000
            bullkdata.DestinationTableName = "DEUDA_CLIENTES"
            bullkdata.WriteToServer(dt)
            bullkdata.Close()
            cnx.Close()

            MsgBox("Se importo todos los registros.")

        Catch ex As Exception
            MsgBox("Hubo un problema al exportar." & vbNewLine & ex.Message, MsgBoxStyle.Information, DesEmpresa)
        End Try
        Me.Cursor = Cursors.Default
        Control(Me, True)

    End Sub

    Private Sub frmExportaNex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Sub Control(ByVal f As Form, ByVal var As Boolean)
        For Each c As Control In f.Controls
            If TypeOf c Is Button Then
                c.Enabled = var
            End If
        Next
    End Sub
End Class