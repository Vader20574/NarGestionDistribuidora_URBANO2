Public Class frmPlanillaDescOrden
    Dim ListPlanCab As New List(Of PlanillaOrdenE)
    Dim indice As Integer

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim frmbus As New frmBusPlanillaOrden
        frmbus.ShowDialog()
        If frmbus.Devuelve = True Then
            ListPlanCab.Clear()
            Me.txtOrderDesp.Text = frmbus.Nro.ToString


            Dim dtb As DataTable
            Dim oPc As PlanillaOrdenE
            Dim oPcD As PlanillaOrdenDetE


            Dim ORDENDESPACHO As String



            'NomTablaC = "VENTC" & Format(DateAdd("m", i, oPc.Fecha), "yyyyMM")
            ' NomTablaD = "VENTD" & Format(DateAdd("m", i, oPc.Fecha), "yyyyMM")

            dtb = CAyuda.ListarDatos("SP_LIST_PLANIORDEN", codempresa, Me.txtOrderDesp.Text.Trim).Tables(0)
            For Each dt As DataRow In dtb.Rows
                oPc = New PlanillaOrdenE
                oPc.NroPlanilla = CType(txtOrderDesp.Text, Integer)
                oPc.Codempresa = codempresa
                oPc.CDCOBRADOR = dt.Item(0).ToString
                oPc.CODMONEDA = dt.Item(1)
                oPc.Fecha = dt.Item(2)
                oPc.TotalBas = dt.Item(3)
                oPc.TOTALEXT = dt.Item(4)
                oPc.CDUSUARIO = dt.Item(5)
                oPc.CAMBIO = dt.Item(6)
                oPc.ESTADO = dt.Item(7)
                oPc.OBSERVACION = dt.Item(8)

                ORDENDESPACHO = dt.Item(9)


                Dim VentaC, GUIAD As String
                Dim MesAct, Anio As String
                MesAct = Format(oPc.Fecha, "MM")
                Anio = Format(oPc.Fecha, "yyyy")

                VentaC = "VENTC" & Anio & MesAct
                GUIAD = "GUIAD" & Anio & MesAct

                CAyuda.Ejecutar("INSERT_TMP_PORCDESC", ORDENDESPACHO, VentaC, GUIAD, rand)

                If TIPODESC = True Then
                    dtb = CAyuda.ListarDatos("SP_LIST_PLNIORDDET", codempresa, Me.txtOrderDesp.Text.Trim, rand).Tables(0)
                    oPc.DETALLE = New List(Of PlanillaOrdenDetE)

                End If

                If TIPODESC = False Then
                    dtb = CAyuda.ListarDatos("SP_LIST_PLNIORDDET2", codempresa, Me.txtOrderDesp.Text.Trim).Tables(0)
                    oPc.DETALLE = New List(Of PlanillaOrdenDetE)

                End If



                Dim dtipo As DataTable
                For Each dt1 As DataRow In dtb.Rows
                    oPcD = New PlanillaOrdenDetE
                    dtipo = CAyuda.ListarDatos("SP_LIST_TDOCUME", codempresa, CType(dt1.Item(0), String)).Tables(0)
                    Dim ot As New TipoDocE
                    ot.CODIGO = CType(dt1.Item(0), String)
                    ot.TIPODOCUMENTO = dtipo.Rows(0)(0)

                    dtipo = TmpListarDatos("SELECT DSTIPOPAGO FROM TIPO_PAGO WHERE CODEMPRESA='" & codempresa & "' AND CODTIPOPAGO='" & dt1.Item(13).ToString & "'")
                    Dim op As New TipoPagE
                    op.CODTIPOPAGO = dt1.Item(13).ToString
                    op.DSTIPOPAGO = dtipo.Rows(0)(0).ToString

                    oPcD.TIPODOC = ot
                    oPcD.NRODOCU = dt1.Item(1)
                    oPcD.CODCLIENTE = dt1.Item(2)
                    oPcD.DESCLIENTE = dt1.Item(3)
                    oPcD.FECDOCUM = dt1.Item(4)
                    oPcD.TOTCREDBAS = dt1.Item(5)
                    oPcD.TOTCREDEXT = dt1.Item(6)
                    oPcD.SALDOBAS = dt1.Item(7)
                    oPcD.SALDOEXT = dt1.Item(8)
                    oPcD.PAGCREDBAS = dt1.Item(9)
                    oPcD.PAGCREDEXT = dt1.Item(10)
                    oPcD.CLIDEP = dt1.Item(11)
                    oPcD.ESTADO = dt1.Item(12)
                    oPcD.DESCUENTO = dt1.Item(15)
                    oPcD.DESC_AUTORIZADO = dt1.Item(15)
                    oPcD.TIPOPAGO = op

                    oPc.DETALLE.Add(oPcD)

                Next
                ListPlanCab.Add(oPc)
            Next

            dgvdetalle.DataSource = Nothing
            dgvdetalle.DataSource = ListPlanCab.Item(0).DETALLE
            txtCobrador.Text = ListPlanCab.Item(0).CDCOBRADOR
            Dim dtc As DataTable
            dtc = CAyuda.ListarDatos("SP_BUSC_COBRADOR", codempresa, txtCobrador.Text.Trim).Tables(0)
            Me.lbCobrador.Text = IIf(dtc.Rows.Count > 0, dtc.Rows(0)(0).ToString, "")
            dtpFecha.Value = ListPlanCab.Item(0).Fecha
            Limpia(False)
        End If
    End Sub
    Dim descPoderoso As Decimal
    Private Sub dgvdetalle_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvdetalle.DoubleClick
        indice = Me.dgvdetalle.CurrentRow.Index
        Dim Estadod As String = ListPlanCab.Item(0).DETALLE(indice).ESTADO
        'If Estadod.ToUpper.Contains("CANCELADO") = True Then
        '    MsgBox("- El Documento esta Cancelado.", MsgBoxStyle.Information, "NARSISTEMAS")
        '    Exit Sub
        'End If
        'If ListPlanCab.Item(0).DETALLE.Item(indice).DESCUENTO <> 0 Then
        '    MsgBox("- Ya se aplico un Descuento.", MsgBoxStyle.Information, "NARSISTEMAS")

        '    Exit Sub
        'End If

        LblNroDoc.Text = ListPlanCab.Item(0).DETALLE(indice).NRODOCU
        lblRazonSoc.Text = ListPlanCab.Item(0).DETALLE(indice).DESCLIENTE
        LblFechaDoc.Text = ListPlanCab.Item(0).DETALLE(indice).FECDOCUM.ToString

        Dim dtr As DataTable
        dtr = TmpListarDatos("SELECT RUC FROM CLIENTE WHERE CODEMPRESA='" & codempresa & "' AND CODCLIENTE='" & ListPlanCab.Item(0).DETALLE(indice).CODCLIENTE & "'")
        If dtr.Rows.Count > 0 Then
            LblRuc.Text = dtr.Rows(0)(0)
        Else
            LblRuc.Text = ""
        End If


        lblTotal.Text = ListPlanCab.Item(0).DETALLE(indice).TOTCREDBAS.ToString("c")
        lblRestante.Text = ListPlanCab.Item(0).DETALLE(indice).SALDOBAS.ToString("c")
        txtdescuento.Text = ListPlanCab.Item(0).DETALLE(indice).DESCUENTO.ToString("c")

        descPoderoso = (CDbl(txtdescuento.Text) * 1.05)


        LblDsTipoDoc.Text = ListPlanCab.Item(0).DETALLE(indice).TIPODOC.TIPODOCUMENTO


        Panel1.Enabled = True

        txtdescuento.Focus()
    End Sub

    Private Sub txtdescuento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdescuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim estado As String
            Dim descuento As Decimal

            If Decimal.TryParse(Me.txtdescuento.Text, descuento) = False Then
                Me.txtdescuento.SelectAll()
                txtdescuento.Focus()
                Exit Sub
            Else

                'If CType(txtdescuento.Text, Decimal) = 0 Then
                '    MsgBox("- Ingrese un Valor de Descuento.", MsgBoxStyle.Information, "NARSISTEMAS")
                '    Exit Sub
                'End If


            End If

            If CType(txtdescuento.Text, Decimal) > CType(lblRestante.Text, Decimal) Then
                MsgBox("- Ingrese un Valor de Descuento Valido.", MsgBoxStyle.Information, "NARSISTEMAS")
                Me.txtdescuento.SelectAll()
                Me.txtdescuento.Focus()
                Exit Sub
            End If
       

            If CType(lblRestante.Text, Decimal) = CType(txtdescuento.Text, Decimal) Then
                estado = "CANCELADO"
            End If

       


            Dim saldoPend, Resto, RestoExt As Decimal
            descuento = CType(txtdescuento.Text, Decimal)

            If descPoderoso >= descuento Then

            Else
                Dim Proceso As String
                Proceso = "DESCU"
                If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
                    Dim o As New FrmIngresaUsuClave
                    o.Proceso = Proceso
                    o.ShowDialog()
                    If o.DEVOLVER = False Then
                        Exit Sub
                    End If
                End If


            End If


            If CDbl(txtdescuento.Text) <= (MARGENDESC_PORC / 100 * CDbl(lblTotal.Text)) Then
            Else
                MsgBox("Descuento excede a lo autorizado")
                Exit Sub
            End If

            saldoPend = CType(lblRestante.Text, Decimal)
            Resto = saldoPend - descuento
            RestoExt = Resto / CType(LblCambio.Text, Decimal)
            If Resto = 0 Then
                ListPlanCab.Item(0).DETALLE.Item(indice).ESTADO = "CANCELADO"
                ListPlanCab.Item(0).DETALLE.Item(indice).CANCELARD = True

            End If

            ListPlanCab.Item(0).DETALLE.Item(indice).DESCUENTO = descuento
            ListPlanCab.Item(0).DETALLE.Item(indice).SALDOBAS = Resto
            ListPlanCab.Item(0).DETALLE.Item(indice).SALDOEXT = RestoExt

            dgvdetalle.DataSource = Nothing
            dgvdetalle.DataSource = ListPlanCab.Item(0).DETALLE
            Limpia(False)

        End If
    End Sub
    Private Sub Limpia(ByVal var As Boolean)
        If var = True Then
            txtOrderDesp.Text = ""
            txtCobrador.Text = ""
            lbCobrador.Text = ""
            lblTotal.Text = ""
            LblNroDoc.Text = ""
            lblRazonSoc.Text = ""
            LblFechaDoc.Text = ""
            LblRuc.Text = ""
            lblRestante.Text = ""
            txtdescuento.Text = ""
            LblDsTipoDoc.Text = ""
            LblTotalAcuenta.Text = 0
            LblTotalDescAutorizado.Text = 0
            LblDiferencia.Text = 0
        Else
            LblNroDoc.Text = ""
            lblRazonSoc.Text = ""
            LblFechaDoc.Text = ""
            LblRuc.Text = ""
            lblRestante.Text = ""
            txtdescuento.Text = ""
            LblDsTipoDoc.Text = ""
            LblTotalAcuenta.Text = 0
            LblTotalDescAutorizado.Text = 0
            LblDiferencia.Text = 0


            If ListPlanCab.Count <> 0 Then
                ListPlanCab.Item(0).DETALLE.ForEach(AddressOf Sumar_DescuentoAutorizado)
            End If



            If ListPlanCab.Count <> 0 Then
                ListPlanCab.Item(0).DETALLE.ForEach(AddressOf Sumar_Descuento)
            End If



        End If
    End Sub
    Sub Sumar_Descuento(ByVal o As PlanillaOrdenDetE)

        LblTotalAcuenta.Text = (CType(LblTotalAcuenta.Text, Decimal) + o.DESCUENTO).ToString("c")

        LblDiferencia.Text = CType(LblTotalAcuenta.Text, Decimal) - CType(LblTotalDescAutorizado.Text, Decimal)
    End Sub

    Sub Sumar_DescuentoAutorizado(ByVal o As PlanillaOrdenDetE)

        LblTotalDescAutorizado.Text = (CType(LblTotalDescAutorizado.Text, Decimal) + o.DESC_AUTORIZADO).ToString("c")

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click



        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = dtpFecha.Value.Year
        MES = dtpFecha.Value.Month

        Select Case MES
            Case 1
                DESMES = "ENERO"
            Case 2
                DESMES = "FEBRERO"
            Case 3
                DESMES = "MARZO"
            Case 4
                DESMES = "ABRIL"
            Case 5
                DESMES = "MAYO"
            Case 6
                DESMES = "JUNIO"
            Case 7
                DESMES = "JULIO"
            Case 8
                DESMES = "AGOSTO"
            Case 9
                DESMES = "SETIEMBRE"
            Case 10
                DESMES = "OCTUBRE"
            Case 11
                DESMES = "NOVIEMBRE"
            Case 12
                DESMES = "DECIEMBRE"
        End Select

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If

        '***********************************************************************************************
        Dim DT_VERIFICAR_PLANILLA As DataTable
        DT_VERIFICAR_PLANILLA = TmpListarDatos("NSP_VERIFICAR_PLANILLA_DESC '" & codempresa & "','" & txtNumPlanilla.Text & "'")

        If DT_VERIFICAR_PLANILLA.Rows.Count > 0 Then
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL NUMERO DE PLANILLA " & txtNumPlanilla.Text & " YA EXISTE")
            Exit Sub
        End If
        '************************************************************************************************




        If ListPlanCab.Item(0).DETALLE.Count = 0 Then
            MsgBox("No hay detalles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        If LblTotalAcuenta.Text.Trim = "" Then
            MsgBox("FALTA INDICAR LOS ACUENTAS DE MONTO A COMPENSAR...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If
        Dim FrmComp As New FrmCompensar
        FrmComp.lbNumPlanilla.Text = txtNumPlanilla.Text
        FrmComp.lblMontoCompensar.Text = CDbl(LblTotalAcuenta.Text)
        FrmComp.ShowDialog()
        If FrmComp.DEVOLVER = False Then
            Exit Sub
        End If

     
        For ContA As Integer = 0 To FrmComp.TablaTemp.Rows.Count - 1
           CAyuda.Ejecutar("NSP_INSERT_DOC_COMP_PCOBROS", txtNumPlanilla.Text, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, txtCobrador.Text, CDbl(LblTotalAcuenta.Text.Trim), FrmComp.TablaTemp.Rows(ContA)("TIPO").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim)

            If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, 1, FrmComp.TablaTemp.Rows(ContA)("TIPOC").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, "", CodUsuario.Trim, FrmComp.TablaTemp.Rows(ContA)("CUENTAC").ToString.Trim, "", "", "", "", FrmComp.TablaTemp.Rows(ContA)("BServi").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("PTributario").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("RucADQ").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("RucProve").ToString.Trim) <> 0 Then

            End If

            'If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("FECHA").ToString.Trim, 1, FrmComp.TablaTemp.Rows(ContA)("TIPOC").ToString.Trim, FrmComp.TablaTemp.Rows(ContA)("NUMERO").ToString.Trim, CDbl(FrmComp.TablaTemp.Rows(ContA)("MONTO")), FrmComp.TablaTemp.Rows(ContA)("CODCAJA").ToString.Trim, "", CodUsuario.Trim, FrmComp.TablaTemp.Rows(ContA)("CUENTAC").ToString.Trim, "", "", "", "") <> 0 Then

            'End If

        Next

        Dim DescuentoT As Decimal
        For Each c As PlanillaOrdenE In ListPlanCab
            For Each d As PlanillaOrdenDetE In c.DETALLE
                CAyuda.Ejecutar("SP_REG_PLANILLA_DESC_D", codempresa, txtNumPlanilla.Text.Trim, d.TIPODOC.CODIGO, d.TIPOPAGO.CODTIPOPAGO, d.NRODOCU, d.CODCLIENTE, d.DESCLIENTE, d.FECDOCUM, c.CODMONEDA, d.TOTCREDBAS, d.TOTCREDEXT, d.SALDOBAS, d.SALDOEXT, d.PAGCREDBAS, d.PAGCREDEXT, d.DESCUENTO, d.CLIDEP, d.ESTADO, d.CANCELARD, d.DESC_AUTORIZADO)
                DescuentoT = DescuentoT + d.DESCUENTO
            Next
            CAyuda.Ejecutar("SP_REG_PLANILLA_DESC_C", c.Codempresa, txtNumPlanilla.Text.Trim, c.CDCOBRADOR, c.CODMONEDA, c.Fecha, c.TotalBas, c.TOTALEXT, c.CDUSUARIO, c.CAMBIO, c.ESTADO, c.OBSERVACION, DescuentoT, CDbl(LblTotalDescAutorizado.Text), CDbl(LblDiferencia.Text))

        Next

        CAyuda.Ejecutar("NSP_CAMBIAR_ESTADO_pcobranzac", codempresa, txtOrderDesp.Text.Trim)


        MsgBox("SE GRABO LA PLANILLA DE COBRANZA" & vbNewLine & "NRO : " & txtNumPlanilla.Text, MsgBoxStyle.Information, "NARSISTEMAS")


        If TmpInsertDatos("NSP_AUMENTAR_CORREL_PLANILLA   '" & NROPTOVTA & "','" & codempresa & "','02','" & txtNumPlanilla.Text & "'") = True Then

        End If


        If TmpInsertDatos("UP_PLANILLA_COBRANZAC_DESC   '" & txtOrderDesp.Text & "','" & txtNumPlanilla.Text & "','" & CDbl(LblTotalAcuenta.Text) & "'") = True Then

        End If

        ListPlanCab.Clear()
        Me.dgvdetalle.DataSource = ListPlanCab
        Limpia(True)
        Bloquea(False)


    End Sub

    Private Sub frmPlanillaDescOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LblCambio.Text = FACT_GFormatodeNumero(CDbl(VCambioVta))
        Bloquea(False)

        Me.dtpFecha.Value = Format(vFechaActual, "dd/MM/yyyy")
        LblFecha.Text = vFechaActual.ToShortDateString


        ValorRan()


    End Sub

    Dim rand As Integer
    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Bloquea(True)
        ListPlanCab.Clear()
        Me.dgvdetalle.DataSource = ListPlanCab
        Limpia(True)

        txtNumPlanilla.Text = TmpListarDatos("SELECT nroplanilla02 FROM PTOVTA  WHERE CODEMPRESA='" & codempresa & "' and NROPTOVTA ='" & NROPTOVTA & "'").Rows(0)("nroplanilla02")


    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        btnBuscar.Enabled = True
        ListPlanCab.Clear()
        Me.dgvdetalle.DataSource = ListPlanCab
        Limpia(True)
        Bloquea(False)
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub Bloquea(ByVal var As Boolean)
        btnBuscar.Enabled = var
        Me.BTNNUEVO.Enabled = Not var
        Me.BTNGUARDAR.Enabled = var
        Me.BTNCANCELAR.Enabled = var
        Me.BTNCERRAR.Enabled = Not var
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Dim frmr As New frmRptPlanOrdenD
        frmr.tipo = 2
        frmr.ShowDialog()
    End Sub

    Private Sub dgvdetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvdetalle.CellContentClick

    End Sub

    Private Sub txtdescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescuento.KeyPress
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

    Private Sub txtdescuento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescuento.TextChanged

    End Sub

    Private Sub lblRestante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRestante.Click

    End Sub

    Private Sub BtnBusDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusDoc.Click

    End Sub

    Private Sub LblTotalAcuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTotalAcuenta.Click

    End Sub
End Class