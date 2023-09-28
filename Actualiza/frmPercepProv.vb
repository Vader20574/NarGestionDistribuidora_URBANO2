Public Class frmPercepProv
    Dim Lista As New List(Of RetencProvDetE)
    Dim total As Decimal
    Dim Nrodoc As String




    Public MENU_ As String = ""

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData
            Case Keys.F3
                If Me.dgvlista.Focused = True Then
                    Dim i = Me.dgvlista.RowCount
                    If i > 0 Then
                        Lista.RemoveAt(dgvlista.CurrentRow.Index)
                        Calcula_Total()
                    End If
                End If
        End Select

    End Function
    Private Sub Calcula_Total()
        Me.dgvlista.DataSource = Nothing
        Me.dgvlista.DataSource = Lista
        total = 0
        For x As Integer = 0 To Lista.Count - 1
            total = total + Lista.Item(x).IMPORTERETENIDO
        Next
        Me.lbltotal.Text = total.ToString("c")
    End Sub
    Private Sub frmPercepProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblcambio.Text = FACT_GFormatodeNumero(CDbl(VCambioVta))
        CAyuda.CargarDataCombo(Me.cmbdocu, "NSP_SELECT_LISTATIPODOC  '" & codempresa & "'", "Código", "Descripción")
        Bloqueo(False)

        Me.dtpfecha.Value = Format(vFechaActual, "dd/MM/yyyy")
        Me.dtpfechaemi.Value = Format(vFechaActual, "dd/MM/yyyy")



        If MENU_ = "Comprobante de Percepcion del Proveedor C" Then
            Me.btnnuevo.Enabled = False
            Me.btnanular.Enabled = False
        End If

    End Sub
    Sub Bloqueo(ByVal var As Boolean, Optional ByVal val As Boolean = False)
        Me.btnnuevo.Enabled = Not var
        Me.btnguardar.Enabled = var
        Me.btncancelar.Enabled = var
        Me.btnsalir.Enabled = Not var
        btnanular.Enabled = Not var

        Me.btnbuscar.Enabled = var
        Me.panel1.Enabled = var
        Me.panel2.Enabled = var




    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click

        Bloqueo(True)
        Limpiar(False)
    End Sub
    Sub Limpiar(ByVal var As Boolean)

        txtserie.Clear()
        txtmontop.Clear()
        txtcorrel.Clear()
        txtimporte.Clear()

        If var = False Then
            txtserienum2.Clear()
            lblcodproveedor.Text = ""
            txtproveedor.Clear()
            lblruc.Text = ""
            lbldireccion.Text = ""
            txtserienum.Clear()
            lbltotal.Text = "0.00"
            Lista.Clear()
            dgvlista.DataSource = Nothing
        End If
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If lblcodproveedor.Text.Trim.Length = 0 Then
            MsgBox("- Seleccione un Proveedor.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        If Lista.Count = 0 Then
            MsgBox("- No hay Documentos Ingresados.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        Dim codigo = 0
        If Integer.TryParse(txtserienum.Text, codigo) = False Then
            Me.txtserienum.SelectAll()
            txtserienum.Focus()
            Exit Sub
        End If

        If CAyuda.ListarDatos("SP_EXIST_PERCEPPROV", codempresa, txtserienum.Text.Trim).Tables(0).Rows.Count > 0 Then
            MsgBox("- El comprobante ya fue Registrado.", MsgBoxStyle.Information, "NARSISTEMAS")
            Me.txtserienum.SelectAll()
            Me.txtserienum.Focus()
            Exit Sub
        End If


        codigo = CStr(txtserienum.Text) & CStr(Me.txtserienum2.Text)

        Dim totalext As Decimal
        Dim var = True
        For Each i As RetencProvDetE In Lista
            CAyuda.Ejecutar("SP_REG_PERCEPPROV_DET", codempresa, codigo, i.TIPODOC.CODIGO, i.SERIE, i.SERIE & i.CORRELATIVO, i.FECHAEMISION, Trim(FACT_CDMONEDA), "", i.MONTOPAGO, i.MONTOPEXT, i.IMPORTERETENIDO, i.IMPORTEREEXT, var)
            totalext = totalext + i.IMPORTEREEXT
            var = False
        Next
        If CAyuda.Ejecutar("SP_REG_PRECEP_PROCAB", codempresa, codigo, Trim(FACT_CDMONEDA), CDbl(Me.lblcambio.Text), "", dtpfecha.Value.ToShortDateString, FECHAPROC, total, totalext, lblcodproveedor.Text.Trim, lblruc.Text.Trim, txtproveedor.Text.Trim, lbldireccion.Text.Trim, CodUsuario, DBNull.Value, "99") <> 0 Then
            MsgBox("- Se Registro con exito.", MsgBoxStyle.Information, "NARSISTEMAS")
            Bloqueo(False)
            Limpiar(False)
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Bloqueo(False)
        Limpiar(False)
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim frmb As New FrmConsProv
        frmb.objPercepProv = Me
        frmb.ShowDialog()
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
            If String.IsNullOrEmpty(txtserie.Text) = True Then
                Me.txtserie.SelectAll()
                Me.txtserie.Focus()
                Exit Sub
            End If
            If String.IsNullOrEmpty(txtcorrel.Text) = True Then
                Me.txtcorrel.SelectAll()
                Me.txtcorrel.Focus()
                Exit Sub
            End If

            Dim d As New RetencProvDetE
            Dim t As New TipoDocE

            t.TIPODOCUMENTO = Me.cmbdocu.Text
            t.CODIGO = Me.cmbdocu.SelectedValue.ToString
            d.TIPODOC = t
            d.FECHAEMISION = Me.dtpfechaemi.Value.ToShortDateString
            d.SERIE = Me.txtserie.Text
            d.MONTOPAGO = monto
            d.MONTOPEXT = d.MONTOPAGO / Convert.ToDecimal(lblcambio.Text)
            d.CORRELATIVO = txtcorrel.Text
            d.IMPORTERETENIDO = importe
            d.IMPORTEREEXT = d.IMPORTERETENIDO / Convert.ToDecimal(lblcambio.Text)
            Lista.Add(d)
            Calcula_Total()


            Limpiar(True)
            Me.txtserie.Focus()
        End If
    End Sub

    Private Sub txtserie_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtserie.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtserie.Text = "000" & txtserie.Text
            txtserie.Text = Mid(txtserie.Text, txtserie.Text.Trim.Length - 2)
            Me.txtmontop.Focus()

        End If
    End Sub

    Private Sub txtcorrel_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcorrel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcorrel.Text = "0000000" & txtcorrel.Text
            txtcorrel.Text = Mid(txtcorrel.Text, txtcorrel.Text.Trim.Length - 5)

            If Lista.Exists(AddressOf Validar) Then
                MsgBox("- El Documento ya fue Ingresado.", MsgBoxStyle.Information, "NARSISTEMAS")
                txtcorrel.Text = ""
                txtcorrel.Focus()
            Else
                Me.txtimporte.Focus()
            End If
        End If
    End Sub
    Private Function Validar(ByVal o As RetencProvDetE) As Boolean
        If Me.txtserie.Text.Trim = o.SERIE And Me.txtcorrel.Text.Trim = o.CORRELATIVO Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub txtmontop_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtmontop.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtcorrel.Focus()
        End If
    End Sub

    Private Sub btnconsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsulta.Click
        Dim nro As Double
        Dim ser1() As String
        Dim frmb As New frmBuscRetenp
        frmb.Var = True
        If frmb.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lblcodproveedor.Text = frmb.dt.Rows(0)("CDPROVEE").ToString
            txtproveedor.Text = frmb.dt.Rows(0)("DESPROVEE").ToString
            lblruc.Text = frmb.dt.Rows(0)("RUCPROVEE").ToString
            lbldireccion.Text = frmb.dt.Rows(0)("DIRPROVEE").ToString
            Nrodoc = frmb.dt.Rows(0)("NRONTARETEN").ToString
            nro = CType(Nrodoc, Integer)
            ser1 = CStr(Format(nro, "0##-######")).Split("-")
            txtserienum.Text = ser1(0)
            txtserienum2.Text = ser1(1)
            dtpfecha.Value = frmb.dt.Rows(0)("FECDOCUM").ToString



            If frmb.dt.Rows(0)("ESTADO").ToString.Trim = "A" Then
                MsgBox("EL DOCUMENTO YA ESTA ANULADO ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                btnanular.Enabled = False
            Else
                btnanular.Enabled = True
            End If


            'Dim dt As New DataTable
            'dt = CAyuda.ListarDatos("SP_SELECT_DET_PERCEPROV", codempresa, Nrodoc).Tables(0)
            'Lista.Clear()
            'For Each dr As DataRow In dt.Rows
            '    Dim d As New RetencProvDetE
            '    Dim t As New TipoDocE

            '    t.TIPODOCUMENTO = dt.Rows(0)("DSTIPODOC").ToString
            '    t.CODIGO = ""
            '    d.TIPODOC = t
            '    d.FECHAEMISION = CDate(dt.Rows(0)("FECDOCUM"))
            '    d.SERIE = dt.Rows(0)("SERIE").ToString
            '    d.MONTOPAGO = dt.Rows(0)("MONTOPAGBAS").ToString
            '    d.MONTOPEXT = 0
            '    d.CORRELATIVO = dt.Rows(0)("NRODOCU").ToString
            '    d.IMPORTERETENIDO = dt.Rows(0)("MONTORETBAS").ToString
            '    d.IMPORTEREEXT = 0
            '    Lista.Add(d)
            'Next




            Dim t_consulta As DataTable
            t_consulta = TmpListarDatos("NSP_SELECT_PERCEPPROVDET '" & codempresa & "','" & Nrodoc & "'")
            Lista.Clear()
            For Each dr2 As DataRow In t_consulta.Rows
                Dim d As New RetencProvDetE
                Dim t As New TipoDocE
                t.TIPODOCUMENTO = dr2.Item(1).ToString
                t.CODIGO = dr2.Item(0).ToString
                d.TIPODOC = t
                d.FECHAEMISION = dr2.Item(4).ToString
                d.SERIE = dr2.Item(2).ToString
                d.MONTOPAGO = dr2.Item(7).ToString
                d.MONTOPEXT = dr2.Item(8).ToString
                d.CORRELATIVO = dr2.Item(3).ToString
                d.IMPORTERETENIDO = dr2.Item(9).ToString
                d.IMPORTEREEXT = dr2.Item(10).ToString
                Lista.Add(d)
            Next

            Calcula_Total()
        End If

        If MENU_ = "Comprobante de Percepcion del Proveedor C" Then
            Me.btnnuevo.Enabled = False
            Me.btnanular.Enabled = False
        End If


    End Sub

    Private Sub btnanular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanular.Click
        If MsgBox("Desea Anular Este Registro que Selecciono.?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            If CAyuda.Ejecutar("SP_PERCEPRO_ANUL", codempresa, Nrodoc, vFechaActual) <> 0 Then
                MsgBox("-El documento se anulo con exito.")
                Bloqueo(False)
                Limpiar(False)
            End If
        End If
    End Sub

    Private Sub txtserienum_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtserienum.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtserienum.Text = "000" & txtserienum.Text
            txtserienum.Text = Mid(txtserienum.Text, txtserienum.Text.Trim.Length - 2)
            Me.txtserienum2.Focus()

        End If
    End Sub

    Private Sub txtserienum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtserienum.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtserienum2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtserienum2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtserienum2.Text = "0000000" & txtserienum2.Text
            txtserienum2.Text = Mid(txtserienum2.Text, txtserienum2.Text.Trim.Length - 5)
            Me.txtserie.Focus()
        End If
    End Sub

    Private Sub txtserienum2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtserienum2.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtserie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtserie.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmontop_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmontop.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcorrel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcorrel.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtimporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtimporte.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtserienum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtserienum.TextChanged

    End Sub

    Private Sub txtimporte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtimporte.TextChanged

    End Sub
End Class