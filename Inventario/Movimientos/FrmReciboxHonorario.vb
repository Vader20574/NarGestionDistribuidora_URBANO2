Public Class FrmReciboxHonorario
    Dim FLAG As Integer

    Public MENU_ As String


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub


    Sub LIMPIAR()
        txtCodGirador.Text = ""
        txtGirador.Text = ""
        txtRuc.Text = ""
        dtFecha.Value = ""
        cboPeriodo.SelectedIndex = Date.Now.Month - 1

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim TABLE_BUSQTIPCREDF As New DataTable
        TABLE_BUSQTIPCREDF = TmpListarDatos("SP_BUSCRECIBO  '" & txtCodGirador.Text & "'  ")

        If TABLE_BUSQTIPCREDF.Rows.Count > 0 Then
            MsgBox("YA EXISTE ESE CODIGO  ")
        End If


        If TmpInsertDatos("NSP_INS_RECIBOXHONO  '" & txtCodGirador.Text & "','" & txtGirador.Text & "','" & txtRuc.Text & "','" & Format(dtFecha.Value, "dd/MM/yyyy") & "','" & txtEjercicio.Text & "','" & cboPeriodo.Text & "' ,'" & txtconcepto.Text & "'," & CDbl(txtTotalHonorario.Text) & "," & CDbl(txtRetenImpNeto.Text) & "," & CDbl(txtTotalNeto.Text) & "") = True Then

            MsgBox("SE GUARDO CORRECTAMENTE  ")


        End If



    End Sub




    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtConcepto_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub FrmReciboxHonorario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboPeriodo.Items.Add("ENERO")
        cboPeriodo.Items.Add("FEBRERO")
        cboPeriodo.Items.Add("MARZO")
        cboPeriodo.Items.Add("ABRIL")
        cboPeriodo.Items.Add("MAYO")
        cboPeriodo.Items.Add("JUNIO")
        cboPeriodo.Items.Add("JULIO")
        cboPeriodo.Items.Add("AGOSTO")
        cboPeriodo.Items.Add("SEPTIEMBRE")
        cboPeriodo.Items.Add("OCTUBRE")
        cboPeriodo.Items.Add("NOVIEMBRE")
        cboPeriodo.Items.Add("DICIEMBRE")
        cboPeriodo.SelectedIndex = Date.Now.Month - 1


        Call Bloqueatextbox(Me)



        Call BOTONES(True, False, False, False, True)



        If MENU_ = "Recibo por Honorarios C" Then
            BTNNUEVO.Enabled = False

            BTNMODIFICAR.Enabled = False
            BTNELIMINAR.Enabled = False
        End If


    End Sub

    Private Sub txtTotalHonorario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalHonorario.KeyPress

        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If


    End Sub

    Private Sub txtTotalHonorario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalHonorario.TextChanged

        If txtTotalHonorario.Text.Length = 0 Then
            txtTotalHonorario.Text = 0
        End If


        If txtRetenImpNeto.Text.Length = 0 Then
            txtRetenImpNeto.Text = 0
        End If

        txtTotalNeto.Text = CDbl(txtTotalHonorario.Text) - CDbl(txtRetenImpNeto.Text)


    End Sub

    Private Sub txtRetenImpNeto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetenImpNeto.KeyPress
        If  Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRetenImpNeto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRetenImpNeto.TextChanged
        If txtTotalHonorario.Text.Length = 0 Then
            txtTotalHonorario.Text = 0
        End If


        If txtRetenImpNeto.Text.Length = 0 Then
            txtRetenImpNeto.Text = 0
        End If

        txtTotalNeto.Text = CDbl(txtTotalHonorario.Text) - CDbl(txtRetenImpNeto.Text)

    End Sub

    Private Sub txtTotalNeto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotalNeto.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTotalNeto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalNeto.TextChanged

    End Sub

    Private Sub BtnBusMovi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim TABLE_DESPACHO As DataTable
        TABLE_DESPACHO = TmpListarDatos("SP_SELECT_RECIBO  ")


        Dim frmBusdoc As New frmBuscaDocumentoHor
        frmBusdoc.dt_data = TABLE_DESPACHO
        frmBusdoc.ShowDialog()



        If frmBusdoc.valor = False Then
            Exit Sub
        End If


        Dim codtipodoc As String
        codtipodoc = frmBusdoc.griddata.Item(frmBusdoc.griddata.CurrentRowIndex, 0).ToString.Trim


        Dim TABLE_BUSQTIPCREDF As New DataTable
        TABLE_BUSQTIPCREDF = TmpListarDatos("SP_SELECT_RECIBOX  '" & codtipodoc & "'  ")

        If TABLE_BUSQTIPCREDF.Rows.Count > 0 Then
            ' MsgBox("YA EXISTE ESE CODIGO  ")
            txtCodGirador.Text = TABLE_BUSQTIPCREDF.Rows(0)("COD_RECIBO")
            txtGirador.Text = TABLE_BUSQTIPCREDF.Rows(0)("GIRADOR_RECIBO")
            txtRuc.Text = TABLE_BUSQTIPCREDF.Rows(0)("RUC")
            dtFecha.Value = TABLE_BUSQTIPCREDF.Rows(0)("FECHA")
            txtEjercicio.Text = TABLE_BUSQTIPCREDF.Rows(0)("EJERCICIO")
            cboPeriodo.Text = TABLE_BUSQTIPCREDF.Rows(0)("PERIODO")
            txtconcepto.Text = TABLE_BUSQTIPCREDF.Rows(0)("CONCEPTO")
            txtTotalHonorario.Text = TABLE_BUSQTIPCREDF.Rows(0)("TOTAL")
            txtRetenImpNeto.Text = TABLE_BUSQTIPCREDF.Rows(0)("RETENCION")
            txtTotalNeto.Text = TABLE_BUSQTIPCREDF.Rows(0)("TOTAL_NETO")
        End If

        Call BOTONES(True, False, True, True, True)


        If MENU_ = "Recibo por Honorarios C" Then
            BTNNUEVO.Enabled = False


            BTNMODIFICAR.Enabled = False
            BTNELIMINAR.Enabled = False
        End If

    End Sub

    Private Sub BTNGUARDAR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        If FLAG = 0 Then

            Dim TABLE_BUSQTIPCREDF As New DataTable
            TABLE_BUSQTIPCREDF = TmpListarDatos("SP_BUSCRECIBO  '" & txtCodGirador.Text & "'  ")

            If TABLE_BUSQTIPCREDF.Rows.Count > 0 Then
                MsgBox("YA EXISTE ESE CODIGO  ")
            End If


            If TmpInsertDatos("NSP_INS_RECIBOXHONO  '" & txtCodGirador.Text & "','" & txtGirador.Text & "','" & txtRuc.Text & "','" & Format(dtFecha.Value, "dd/MM/yyyy") & "','" & txtEjercicio.Text & "','" & cboPeriodo.Text & "' ,'" & txtConcepto.Text & "'," & CDbl(txtTotalHonorario.Text) & "," & CDbl(txtRetenImpNeto.Text) & "," & CDbl(txtTotalNeto.Text) & "") = True Then

                MsgBox("SE GUARDO CORRECTAMENTE  ")


            End If




        End If


        If FLAG = 1 Then

            If TmpInsertDatos("NSP_UPD_RECIBOXHONO   '" & txtCodGirador.Text & "','" & txtGirador.Text & "','" & txtRuc.Text & "','" & Format(dtFecha.Value, "dd/MM/yyyy") & "','" & txtEjercicio.Text & "','" & cboPeriodo.Text & "' ,'" & txtConcepto.Text & "'," & CDbl(txtTotalHonorario.Text) & "," & CDbl(txtRetenImpNeto.Text) & "," & CDbl(txtTotalNeto.Text) & "") = True Then

                MsgBox("SE MODIFICO CORRECTAMENTE  ")


            End If



        End If







        Call BOTONES(True, False, False, False, True)

        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
        BTNNUEVO.Focus()


    End Sub

    Private Sub BTNNUEVO_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click

        Call BOTONES(False, True, False, False, False)
        'LIMPIAR()

        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        FLAG = 0

    End Sub


    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call BOTONES(False, True, False, False, True)
        Call desbloqueatextbox(Me)
        FLAG = 1
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then

            Dim PROCESO As Boolean
            Dim sql As String
            sql = "NSP_DEL_RECIBOXHONO  '" & txtCodGirador.Text & "'"
            PROCESO = TmpInsertDatos(sql)
        
            If PROCESO = False Then
                Exit Sub
            Else
                MsgBox("SE ELIMINO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            End If
            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)
            Call Limpiatextbox(Me)

        End If
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Exit Sub
    End Sub
End Class