Public Class frmRetencProv
    Dim lista As New List(Of RetencProvDetE)
    Dim Total As Decimal
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        'Dim frmb As New FrmConsProv
        'frmb.objIngOPer = Me
        'frmb.ShowDialog()
    End Sub

    Private Sub txtimporte_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtimporte.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim monto, importe As Decimal
            If Decimal.TryParse(Me.txtmontop.Text, monto) = False Then
                Me.txtmontop.SelectAll()
                Me.txtmontop.Focus()
                Exit Sub
            End If
            If Decimal.TryParse(Me.txtimporte.Text, importe) = False Then
                Me.txtimporte.SelectAll()
                Me.txtimporte.Focus()
                Exit Sub
            End If

            Dim d As New RetencProvDetE
            Dim t As New TipoDocE

            t.TIPODOCUMENTO = Me.cmbdocu.Text
            t.CODIGO = Me.cmbdocu.SelectedValue.ToString
            d.TIPODOC = t
            d.FECHAEMISION = Me.dtpfecha.Value.ToShortDateString
            d.SERIE = Me.txtserie.Text
            d.MONTOPAGO = monto
            d.MONTOPEXT = d.MONTOPAGO / Convert.ToDecimal(lblcambio.Text)
            d.CORRELATIVO = txtcorrel.Text
            d.IMPORTERETENIDO = importe
            d.IMPORTEREEXT = d.IMPORTERETENIDO / Convert.ToDecimal(lblcambio.Text)
            lista.Add(d)
            Calcula_Total()

       
        End If
    End Sub
    Sub Limpiar(ByVal var As Boolean)

        txtserie.Clear()
        txtmontop.Clear()
        txtcorrel.Clear()
        txtimporte.Clear()
 
        If var = False Then
            lblcodproveedor.Text = ""
            txtproveedor.Clear()
            lblruc.Text = ""
            lbldireccion.Text = ""
            txtserienum.Clear()

            lista.Clear()
            dgvlista.DataSource = Nothing
        End If
    End Sub


    Private Sub Calcula_Total()
        Me.dgvlista.DataSource = lista
        Total = 0
        For x As Integer = 0 To lista.Count - 1
            Total = Total + lista.Item(x).IMPORTERETENIDO
        Next
        Me.lbltotal.Text = Total.ToString("c")
    End Sub

    Private Sub frmRetencProv_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.lblcambio.Text = FACT_GFormatodeNumero(CDbl(VCambioVta))
        CAyuda.CargarDataCombo(Me.cmbdocu, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        Bloqueo(False)
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        Dim totalbase, totalext As Decimal
        For Each i As RetencProvDetE In lista
            CAyuda.Ejecutar("SP_REG_RETENPRODET", codempresa, txtserienum.Text.Trim, i.TIPODOC.CODIGO, i.SERIE, i.SERIE.ToString & i.CORRELATIVO, i.FECHAEMISION, Trim(FACT_CDMONEDA), "", i.MONTOPAGO, i.MONTOPEXT, i.IMPORTERETENIDO, i.IMPORTEREEXT)
            totalbase = totalbase + i.IMPORTERETENIDO
            totalext = totalext + i.IMPORTEREEXT
        Next
        If CAyuda.Ejecutar("SP_REG_RETPROCAB", codempresa, txtserienum.Text.Trim, Trim(FACT_CDMONEDA), CDbl(Me.lblcambio.Text), "", dtpfecha.Value.ToShortDateString, FECHAPROC, totalbase, totalext, lblcodproveedor.Text.Trim, lblruc.Text.Trim, txtproveedor.Text.Trim, lbldireccion.Text.Trim, CodUsuario, DBNull.Value) <> 0 Then
            MsgBox("- SE GUARDO CON EXITO.", MsgBoxStyle.Information, "NARSISTEMAS")
            Bloqueo(False)
        End If

    End Sub


    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
     

        Bloqueo(True)
    End Sub
    Sub Bloqueo(ByVal var As Boolean)
        Me.btnnuevo.Enabled = Not var
        Me.btnguardar.Enabled = var
        Me.btncancelar.Enabled = var
        Me.btnsalir.Enabled = Not var


        Me.btnbuscar.Enabled = var
        Me.panel1.Enabled = var
        Me.panel2.Enabled = var


    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Bloqueo(False)
    End Sub
End Class