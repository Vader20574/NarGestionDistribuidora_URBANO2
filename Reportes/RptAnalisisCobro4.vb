Public Class RptAnalisisCobro4

    Dim rand As Integer
    Dim dtrpt As New DataTable
    Dim CodVend As String = ""

    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String

    Dim TAB_DETALLE As DataTable
    Public TipoDoc As String
    Public NroDoc As String

    Private Sub RptAnalisisCobro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        CargaCombo()
        ValorRan()

        cbTipoDoc.SelectedValue = TipoDoc
        txtNroDoc.Text = NroDoc

        Dim Estado As String



        Dim VarCliente As String = String.Empty

        Try
            Dim TablaTemp As New DataTable
            TablaTemp = CAyuda.ListarDatos("NSP_TRAER_CLIENTE_VTA_COBRAR_DOC", TipoDoc, NroDoc, rand).Tables(0)


            If TablaTemp.Rows.Count > 0 Then

                VarCliente = TablaTemp.Rows(0)(0)
                txtDsCliente.Text = VarCliente : txtDeuda.Text = TablaTemp.Rows(0)("TOTCREDBAS")
                txtSaldo.Text = CDbl(TablaTemp.Rows(0)("TOTAL")) - CDbl(TablaTemp.Rows(0)("PAGCREDBAS"))
                txtDsClienteDep.Text = TablaTemp.Rows(0)("CDCLIENTEDEP")
                FechaEmi.Text = TablaTemp.Rows(0)("FECDOCUM")
                FechaVenc.Text = TablaTemp.Rows(0)("VENCIMIENTO")
                FechaCan.Text = TablaTemp.Rows(0)("fproceso")
                Estado = TablaTemp.Rows(0)("ESTADO")
                txtTotal.Text = TablaTemp.Rows(0)("TOTAL")

                If Estado.Trim = "PENDIENTE" Then
                    FechaCan.Text = "0"
                End If

                txtAcuenta.Focus()

                CargarGridDet()
                FormatoGridDet()
            Else
                MsgBox("ESTA ANULADO")
                Exit Sub
            End If



        Catch ex As Exception

        End Try

    End Sub


    Private Sub CargaCombo()
        'Conecta("SELECT T.[CODTIPODOC], T.[DSTIPODOC] FROM TIPODOC T WHERE T.[CODEMPRESA]='" & codempresa & "'", "d")
        'Dim TablaTemp As New DataTable
        'TablaTemp = ds.Tables("d")
        'Me.cbTipoDoc.DisplayMember = "DSTIPODOC"
        'Me.cbTipoDoc.ValueMember = "CODTIPODOC"
        'Me.cbTipoDoc.DataSource = TablaTemp



        CAyuda.CargarDataCombo(cbTipoDoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")


    End Sub




    Private Sub txtNroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress

        Dim Estado As String


        If Asc(e.KeyChar) = 13 Then
            Dim VarCliente As String = String.Empty

            Try


                Dim TablaTemp As New DataTable
                TablaTemp = CAyuda.ListarDatos("NSP_TRAER_CLIENTE_VTA_COBRAR_DOC", TipoDoc, NroDoc, rand).Tables(0)


                If TablaTemp.Rows.Count > 0 Then

                    VarCliente = TablaTemp.Rows(0)(0)
                    txtDsCliente.Text = VarCliente : txtDeuda.Text = TablaTemp.Rows(0)("TOTCREDBAS")
                    txtSaldo.Text = CDbl(TablaTemp.Rows(0)("TOTAL")) - CDbl(TablaTemp.Rows(0)("PAGCREDBAS"))
                    txtDsClienteDep.Text = TablaTemp.Rows(0)("CDCLIENTEDEP")
                    FechaEmi.Text = TablaTemp.Rows(0)("FECDOCUM")
                    FechaVenc.Text = TablaTemp.Rows(0)("VENCIMIENTO")
                    FechaCan.Text = TablaTemp.Rows(0)("fproceso")
                    Estado = TablaTemp.Rows(0)("ESTADO")
                    txtTotal.Text = TablaTemp.Rows(0)("TOTAL")

                    If Estado.Trim = "PENDIENTE" Then
                        FechaCan.Text = "0"
                    End If

                    txtAcuenta.Focus()

                    CargarGridDet()
                    FormatoGridDet()


                    Reporte()
                Else
                    MsgBox("NO HAY DATA O EL DOCUMENTO SE HA ANULADO")
                End If


            Catch ex As Exception

            End Try




        End If


    End Sub

    Private Sub txtNroDoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroDoc.TextChanged

    End Sub

    Sub Reporte()
        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "Rpt_AnalisCobroDoc.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "FCANC='" & FechaCan.Text.ToString & "'")
                .set_Formulas(1, "FEMI='" & FechaEmi.Text.ToString & "'")
                .set_Formulas(2, "FVENC='" & FechaVenc.Text.ToString & "'")
                .set_Formulas(3, "IMPORT='" & Me.txtDeuda.Text & "'")
                .set_Formulas(4, "NOMDEP='" & txtDsClienteDep.Text & "'")
                .set_Formulas(5, "NOMPR='" & txtDsCliente.Text & "'")
                .set_Formulas(6, "NUMDOC='" & txtNroDoc.Text & "'")
                .set_Formulas(7, "SALDO='" & txtSaldo.Text & "'")
                .set_Formulas(8, "TIPODOC='" & cbTipoDoc.Text & "'")


                '.set_Formulas(5, "Tipo='" & Me.comboRuta.Text & "'")

                '   TAB_DETALLE = TmpListarDatos("SP_RPT_COBRANZA '" & codempresa & "','" & dtpinicio.Value.ToString("dd/MM/yyyy") & "','" & Me.dtpfin.Value.ToString("dd/MM/yyyy") & "','" & comboRuta.SelectedValue & "'")


                .set_StoredProcParam(0, rand)
                ' .set_StoredProcParam("@TIPODOC", cbTipoDoc.Text)
                '.set_StoredProcParam(1, rand)


                '.set_StoredProcParam(2, dtpfin.Value.ToString("dd/MM/yyyy"))

                '.set_StoredProcParam("@FECHAD", dtpinicio.Value)
                '.set_StoredProcParam("@FECHAH", dtpfin.Value)
                '.set_StoredProcParam(3, Me.comboRuta.SelectedValue)


                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TmpInsertDatos("DELETE FROM TMP_ANALIS_COMBRO  WHERE CORREL='" & rand & "'")

    End Sub



    Private Sub btnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)








    End Sub



    Private Sub CargarGridDet()
        '  TAB_DETALLE = TmpListarDatos("SP_RPT_COBRANZA   '" & codempresa & "','" & VCorrelVta & "'")

        TAB_DETALLE = TmpListarDatos("NSP_ANALISIS_COBRO_DOC '" & codempresa & "','" & TipoDoc & "','" & NroDoc & "','" & rand & "'")
        dgDetalleCobranza.DataSource = TAB_DETALLE

    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub FormatoGridDet()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_DETALLE.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1

            .MappingName = "Fecha"
            .HeaderText = "FECHA"
            .NullText = ""
            .Width = 75
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2

            .MappingName = "TPLANILLA"
            .HeaderText = "TIPO PLLA"

            .NullText = ""
            .Width = 150
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3

            .MappingName = "NROPLANILLA"
            .HeaderText = "PLLA"

            .NullText = ""
            .Width = 75
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4

            .MappingName = "IMPORTE"
            .HeaderText = "IMPORTE"

            .NullText = ""
            .Width = 75
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5

            .MappingName = "NOMCOBRADOR"
            .HeaderText = "COBRADOR"

            .Alignment = HorizontalAlignment.Right
            .NullText = ""
            .Width = 250
        End With

        dgDetalleCobranza.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5})
        dgDetalleCobranza.TableStyles.Add(TableStyle1)

    End Sub





    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarGridDet()
        FormatoGridDet()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CargarGridDet()
        FormatoGridDet()
    End Sub
End Class