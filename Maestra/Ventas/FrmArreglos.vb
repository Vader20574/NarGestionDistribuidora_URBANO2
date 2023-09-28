Imports System.Transactions
Imports Servicios.Implementacion
Imports Servicios.Interfaces.Factura
Imports Servicios.Interfaces.Facturacion.VentaDet.Peticiones
Imports Servicios.Interfaces.FacturaElectronica.Peticiones

Public Class FrmArreglos

    Private Sub FrmArreglos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        CargaCombo()


    End Sub

    Private Sub CargaCombo()
        'Conecta("SELECT T.[CODTIPODOC], T.[DSTIPODOC] FROM TIPODOC T WHERE T.[CODEMPRESA]='" & codempresa & "'", "d")
        'Dim TablaTemp As New DataTable
        'TablaTemp = ds.Tables("d")
        'Me.cbTipoDoc.DisplayMember = "DSTIPODOC"
        'Me.cbTipoDoc.ValueMember = "CODTIPODOC"
        'Me.cbTipoDoc.DataSource = TablaTemp



        CAyuda.CargarDataCombo(cbTipoDoc, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")

        CAyuda.CargarDataCombo(cbTipoDoc2, "ListarCOMPROBANTESxProc '" & codempresa & "','1'", "CODTIPODOC", "DSTIPODOC")


        CAyuda.CargarDataCombo(cboAlmacen, "Nsp_select_Almacen  '" & codempresa & "'", "codigo", "descripcion")



    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        '***NORMAL ***************************************************************************************/

        Dim TablaDircli As DataTable
        Dim TB_VALIDAR_FINMES As DataTable
        Dim TB_VALIDAR_VENTAXCOBRAR As DataTable

        TablaDircli = CAyuda.ListarDatos("SP_RECORRER_VENTACAB", codempresa.Trim, cbTipoDoc.SelectedValue, Me.txtNroDoc1.Text, Me.txtNroDoc2.Text, "").Tables(0)

        Dim MES As String
        Dim AÑO As String

        If TablaDircli.Rows.Count > 0 Then
            For ContB As Integer = 0 To TablaDircli.Rows.Count - 1

                AÑO = TablaDircli.Rows(ContB)("AÑO")
                MES = TablaDircli.Rows(ContB)("MES")

                TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

                If TB_VALIDAR_FINMES.Rows.Count > 0 Then

                Else
                    MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & MES & " ESTA DESACTIVADO EN CIERRE DE MES")
                    Exit Sub
                End If

                TB_VALIDAR_VENTAXCOBRAR = TmpListarDatos("SP_VALIDAR_VENTAXCOBRAR '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "'")
                If TB_VALIDAR_VENTAXCOBRAR.Rows.Count > 0 Then
                    MsgBox("EL DOCUMENTO " & cbTipoDoc.Text & "  NRO " & TablaDircli.Rows(ContB)("NRODOCU") & " NO SE PUEDE ANULAR POR QUE REGISTRA PAGOS")
                Else

                    Dim Sql As String
                    Sql = "update_cab_anu '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "','" & "" & "','" & "" & "'"
                    If TmpInsertDatos(Sql) = True Then
                        TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT2  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("FECDOCUM") & "'")

                        TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE2  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "'")

                        TmpInsertDatos("SP_ELIMINAR_VENTAXCOBRAR  '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "'")


                        If EMIELECTRONIC = True Then

                            If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "01" Or TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "03" Then

                                Dim LETRADOC As String = ""

                                If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "01" Then
                                    LETRADOC = "F"
                                End If
                                If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "03" Then
                                    LETRADOC = "B"
                                End If
                                If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "06" Then
                                    LETRADOC = "F"
                                End If

                                Dim SERIE2 As String
                                Dim FormatNroDoc As String
                                FormatNroDoc = Format(CDbl(TablaDircli.Rows(ContB)("NRODOCU").ToString), "0##-########")
                                Dim NUMSERIE As String
                                NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                                SERIE2 = LETRADOC + NUMSERIE

                                Dim NRODOCSIN As String
                                NRODOCSIN = CStr(Microsoft.VisualBasic.Right(TablaDircli.Rows(ContB)("NRODOCU").ToString, 8))
                                Dim NRODOCFINAL As String
                                NRODOCFINAL = SERIE2 + "-" + NRODOCSIN

                                Dim gestordetipoNegocio As New GestorDeFacturacionElectronica
                                gestordetipoNegocio.AnularFE(SERIE2, NRODOCSIN, TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim)

                            End If
                        End If




                    End If
                End If
            Next

        End If




        '***VERIFICA TABLAS DE HISTOVENTA ***************************************************************************************/
        Dim dt_tabla As DataTable
        dt_tabla = CAyuda.ListarDatos("SP_LISTA_HISTO_VENTAS", codempresa).Tables(0)
        For Each dr As DataRow In dt_tabla.Rows



            TablaDircli = CAyuda.ListarDatos("SP_RECORRER_VENTACAB", codempresa.Trim, cbTipoDoc.SelectedValue, Me.txtNroDoc1.Text, Me.txtNroDoc2.Text, dr.Item(0).ToString).Tables(0)


            If TablaDircli.Rows.Count > 0 Then
                For ContB As Integer = 0 To TablaDircli.Rows.Count - 1

                    AÑO = TablaDircli.Rows(ContB)("AÑO")
                    MES = TablaDircli.Rows(ContB)("MES")

                    TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

                    If TB_VALIDAR_FINMES.Rows.Count > 0 Then

                    Else
                        MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & MES & " ESTA DESACTIVADO EN CIERRE DE MES")
                        Exit Sub
                    End If

                    TB_VALIDAR_VENTAXCOBRAR = TmpListarDatos("SP_VALIDAR_VENTAXCOBRAR '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "'")
                    If TB_VALIDAR_VENTAXCOBRAR.Rows.Count > 0 Then
                        MsgBox("EL DOCUMENTO " & cbTipoDoc.Text & "  NRO " & TablaDircli.Rows(ContB)("NRODOCU") & " NO SE PUEDE ANULAR POR QUE REGISTRA PAGOS")
                    Else

                        Dim Sql As String
                        Sql = "update_cab_anu '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "','" & dr.Item(0).ToString & "','" & "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6) & "'"
                        If TmpInsertDatos(Sql) = True Then

                            Dim Tabla1 As DataTable
                            Tabla1 = CAyuda.ListarDatos("SP_EXTRAR_ALMVENTADET", codempresa.Trim, TablaDircli.Rows(ContB)("CODTIPODOC"), TablaDircli.Rows(ContB)("NRODOCU"), "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6)).Tables(0)
                            Dim codalmacen As String
                            codalmacen = Tabla1.Rows(0)(0).ToString
                            TmpInsertDatos("SP_INSERT_TMP_VENTADET3  '" & codempresa & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6) & "'")
                            TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT2_HISTO  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & codalmacen & "','" & TablaDircli.Rows(ContB)("FECDOCUM") & "'")
                            TmpInsertDatos("SP_INSERT_TMP_VENTACAB3  '" & codempresa & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & dr.Item(0).ToString & "'")
                            TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE2_HISTO  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & codalmacen & "'")
                            TmpInsertDatos("SP_ELIMINAR_VENTAXCOBRAR  '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "'")




                            If EMIELECTRONIC = True Then

                                If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "01" Or TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "03" Then

                                    Dim LETRADOC As String = ""

                                    If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "01" Then
                                        LETRADOC = "F"
                                    End If
                                    If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "03" Then
                                        LETRADOC = "B"
                                    End If
                                    If TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim = "06" Then
                                        LETRADOC = "F"
                                    End If

                                    Dim SERIE2 As String
                                    Dim FormatNroDoc As String
                                    FormatNroDoc = Format(CDbl(TablaDircli.Rows(ContB)("NRODOCU").ToString), "0##-########")
                                    Dim NUMSERIE As String
                                    NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                                    SERIE2 = LETRADOC + NUMSERIE

                                    Dim NRODOCSIN As String
                                    NRODOCSIN = CStr(Microsoft.VisualBasic.Right(TablaDircli.Rows(ContB)("NRODOCU").ToString, 8))
                                    Dim NRODOCFINAL As String
                                    NRODOCFINAL = SERIE2 + "-" + NRODOCSIN

                                    Dim gestordetipoNegocio As New GestorDeFacturacionElectronica
                                    gestordetipoNegocio.AnularFE(SERIE2, NRODOCSIN, TablaDircli.Rows(ContB)("CODTIPODOC").ToString.Trim)

                                End If
                            End If

                        End If

                    End If

                Next

            End If
        Next

        MsgBox("SE ACTUALIZO")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        Dim Proceso As String
        Proceso = "REGREDESPACT"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If




        Dim Sql2 As String

        Sql2 = "upda_est_GUIAINTERNACAB '" & codempresa & "','" & txtnroDespacho.Text & "','" & Me.txtestado1.Text & "'"
        If TmpInsertDatos(Sql2) = True Then
            MsgBox("SE ACTUALIZO")
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        '***NORMAL ***************************************************************************************/
        Dim TablaDircli As DataTable
        Dim TB_VALIDAR_FINMES As DataTable
        Dim TB_VALIDAR_VENTAXCOBRAR As DataTable

        Dim AÑO As String
        Dim MES As String

        TablaDircli = CAyuda.ListarDatos("SP_SELECT_DOCVENTACAB", codempresa.Trim, TextBox1.Text, "").Tables(0)

        If TablaDircli.Rows.Count > 0 Then
            For ContB As Integer = 0 To TablaDircli.Rows.Count - 1
                AÑO = TablaDircli.Rows(ContB)("AÑO")
                MES = TablaDircli.Rows(ContB)("MES")

                TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

                If TB_VALIDAR_FINMES.Rows.Count > 0 Then

                Else
                    MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & MES & " ESTA DESACTIVADO EN CIERRE DE MES")
                    Exit Sub
                End If

                TB_VALIDAR_VENTAXCOBRAR = TmpListarDatos("SP_VALIDAR_VENTAXCOBRAR '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "'")
                If TB_VALIDAR_VENTAXCOBRAR.Rows.Count > 0 Then
                    MsgBox("EL DOCUMENTO " & cbTipoDoc.Text & "  NRO " & TablaDircli.Rows(ContB)("NRODOCU") & " NO SE PUEDE ANULAR POR QUE REGISTRA PAGOS")
                Else

                    Dim Sql As String
                    Sql = "update_cab_anu '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "','" & "" & "','" & "" & "'"
                    If TmpInsertDatos(Sql) = True Then
                        TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT2  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("FECDOCUM") & "'")

                        TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE2  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "'")

                        TmpInsertDatos("SP_ELIMINAR_VENTAXCOBRAR  '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "'")

                    End If
                End If

            Next

            Dim Sql2 As String
            Dim dt_guias As DataTable

            dt_guias = CAyuda.ListarDatos("SP_LISTA_HISTO_GUIAINTERNAS", codempresa).Tables(0)
            For x As Integer = 0 To dt_guias.Rows.Count - 1
                Sql2 = "SP_REGRESAR_GCONTABLES '" & TextBox1.Text & "','" & dt_guias.Rows(x)(0).ToString & "'"
                If TmpInsertDatos(Sql2) = True Then
                    MsgBox("SE ACTUALIZO")
                    Exit For
                    Exit Sub
                End If
            Next

            Sql2 = "SP_REGRESAR_GCONTABLES '" & TextBox1.Text & "',''"
            If TmpInsertDatos(Sql2) = True Then
                MsgBox("SE ACTUALIZO")
                Exit Sub
            End If

        End If






        '***VERIFICA TABLAS DE HISTOVENTA ***************************************************************************************/
        Dim dt_tabla As DataTable
        dt_tabla = CAyuda.ListarDatos("SP_LISTA_HISTO_VENTAS", codempresa).Tables(0)
        For Each dr As DataRow In dt_tabla.Rows

            TablaDircli = CAyuda.ListarDatos("SP_SELECT_DOCVENTACAB", codempresa.Trim, TextBox1.Text, dr.Item(0).ToString).Tables(0)

            If TablaDircli.Rows.Count > 0 Then
                For ContB As Integer = 0 To TablaDircli.Rows.Count - 1
                    AÑO = TablaDircli.Rows(ContB)("AÑO")
                    MES = TablaDircli.Rows(ContB)("MES")

                    TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

                    If TB_VALIDAR_FINMES.Rows.Count > 0 Then

                    Else
                        MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & MES & " ESTA DESACTIVADO EN CIERRE DE MES")
                        Exit Sub
                    End If


                    TB_VALIDAR_VENTAXCOBRAR = TmpListarDatos("SP_VALIDAR_VENTAXCOBRAR '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "'")
                    If TB_VALIDAR_VENTAXCOBRAR.Rows.Count > 0 Then
                        MsgBox("EL DOCUMENTO " & cbTipoDoc.Text & "  NRO " & TablaDircli.Rows(ContB)("NRODOCU") & " NO SE PUEDE ANULAR POR QUE REGISTRA PAGOS")
                    Else

                        Dim Sql As String
                        Sql = "update_cab_anu '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & codempresa & "','" & dr.Item(0).ToString & "','" & "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6) & "'"
                        If TmpInsertDatos(Sql) = True Then

                            Dim Tabla1 As DataTable
                            Tabla1 = CAyuda.ListarDatos("SP_EXTRAR_ALMVENTADET", codempresa.Trim, TablaDircli.Rows(ContB)("CODTIPODOC"), TablaDircli.Rows(ContB)("NRODOCU"), "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6)).Tables(0)
                            Dim codalmacen As String
                            codalmacen = Tabla1.Rows(0)(0).ToString
                            TmpInsertDatos("SP_INSERT_TMP_VENTADET3  '" & codempresa & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6) & "'")
                            TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT2_HISTO  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & codalmacen & "','" & TablaDircli.Rows(ContB)("FECDOCUM") & "'")
                            TmpInsertDatos("SP_INSERT_TMP_VENTACAB3  '" & codempresa & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & dr.Item(0).ToString & "'")
                            TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE2_HISTO  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & codalmacen & "'")
                            TmpInsertDatos("SP_ELIMINAR_VENTAXCOBRAR  '" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "'")
                        End If

                    End If


                Next

                Dim Sql2 As String
                Sql2 = "SP_REGRESAR_GCONTABLES '" & TextBox1.Text & "'"
                If TmpInsertDatos(Sql2) = True Then
                    MsgBox("SE ACTUALIZO")
                End If
            End If




        Next




    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        '***NORMAL ***************************************************************************************/

        Dim TablaDircli As DataTable
        Dim TB_VALIDAR_FINMES As DataTable
        Dim TB_VERIF_ALM As DataTable

        TablaDircli = CAyuda.ListarDatos("SP_RECORRER_VENTACAB", codempresa.Trim, cbTipoDoc2.SelectedValue, Me.txtNroDoc.Text, Me.txtNroDoc.Text, "").Tables(0)

        Dim MES As String
        Dim AÑO As String

        If TablaDircli.Rows.Count > 0 Then
            For ContB As Integer = 0 To TablaDircli.Rows.Count - 1

                AÑO = TablaDircli.Rows(ContB)("AÑO")
                MES = TablaDircli.Rows(ContB)("MES")

                TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

                If TB_VALIDAR_FINMES.Rows.Count > 0 Then

                Else
                    MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & MES & " ESTA DESACTIVADO EN CIERRE DE MES")
                    Exit Sub
                End If


                Dim SERIE As String
                SERIE = Microsoft.VisualBasic.Left(txtNroDoc.Text, 2)
                TB_VERIF_ALM = CAyuda.ListarDatos("SP_VERIFICAR_AlmacenXSerie", SERIE, cboAlmacen.SelectedValue).Tables(0)

                If TB_VERIF_ALM.Rows.Count = 0 Then
                    MsgBox("NO EXITE SERIE O ESTA MAL RELACIONADO CON EL ALMACEN")
                    Exit Sub
                End If


                TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT2  '" & codempresa & "','" & 1 & "','" & cbTipoDoc2.SelectedValue & "','" & Me.txtNroDoc.Text & "','" & TablaDircli.Rows(ContB)("FECDOCUM") & "'")

                TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE2  '" & codempresa & "','" & 1 & "','" & cbTipoDoc2.SelectedValue & "','" & Me.txtNroDoc.Text & "'")

                Dim Sql2 As String
                Sql2 = "UPD_ALMACEN '" & txtNroDoc.Text & "','" & cbTipoDoc2.SelectedValue.ToString & "','" & cboAlmacen.SelectedValue.ToString & "',''"
                If TmpInsertDatos(Sql2) = True Then

                End If

                TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT2  '" & codempresa & "','" & 0 & "','" & cbTipoDoc2.SelectedValue & "','" & Me.txtNroDoc.Text & "','" & TablaDircli.Rows(ContB)("FECDOCUM") & "'")

                TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE2  '" & codempresa & "','" & 0 & "','" & cbTipoDoc2.SelectedValue & "','" & Me.txtNroDoc.Text & "'")

            Next
        End If


        '***VERIFICA TABLAS DE HISTOVENTA ***************************************************************************************/
        Dim dt_tabla As DataTable
        dt_tabla = CAyuda.ListarDatos("SP_LISTA_HISTO_VENTAS", codempresa).Tables(0)
        For Each dr As DataRow In dt_tabla.Rows

            TablaDircli = CAyuda.ListarDatos("SP_RECORRER_VENTACAB", codempresa.Trim, cbTipoDoc2.SelectedValue, Me.txtNroDoc.Text, Me.txtNroDoc.Text, dr.Item(0).ToString).Tables(0)

            If TablaDircli.Rows.Count > 0 Then
                For ContB As Integer = 0 To TablaDircli.Rows.Count - 1
                    AÑO = TablaDircli.Rows(ContB)("AÑO")
                    MES = TablaDircli.Rows(ContB)("MES")

                    TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

                    If TB_VALIDAR_FINMES.Rows.Count > 0 Then

                    Else
                        MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & MES & " ESTA DESACTIVADO EN CIERRE DE MES")
                        Exit Sub
                    End If

                    Dim SERIE As String
                    SERIE = Microsoft.VisualBasic.Left(txtNroDoc.Text, 2)
                    TB_VERIF_ALM = CAyuda.ListarDatos("SP_VERIFICAR_AlmacenXSerie", SERIE, cboAlmacen.SelectedValue).Tables(0)

                    If TB_VERIF_ALM.Rows.Count = 0 Then
                        MsgBox("NO EXITE SERIE O ESTA MAL RELACIONADO CON EL ALMACEN")
                        Exit Sub
                    End If



                    Dim Tabla1 As DataTable
                    Tabla1 = CAyuda.ListarDatos("SP_EXTRAR_ALMVENTADET", codempresa.Trim, TablaDircli.Rows(ContB)("CODTIPODOC"), TablaDircli.Rows(ContB)("NRODOCU"), "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6)).Tables(0)
                    Dim codalmacen As String
                    codalmacen = Tabla1.Rows(0)(0).ToString
                    TmpInsertDatos("SP_INSERT_TMP_VENTADET3  '" & codempresa & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6) & "'")
                    TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT2_HISTO  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & codalmacen & "','" & TablaDircli.Rows(ContB)("FECDOCUM") & "'")
                    TmpInsertDatos("SP_INSERT_TMP_VENTACAB3  '" & codempresa & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & dr.Item(0).ToString & "'")
                    TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE2_HISTO  '" & codempresa & "','" & 1 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & codalmacen & "'")



                    TmpInsertDatos("SP_INSERT_TMP_VENTADET3  '" & codempresa & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6) & "'")
                    TmpInsertDatos("NSP_ACTUALIZA_STOCK_FACTACT2_HISTO  '" & codempresa & "','" & 0 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & codalmacen & "','" & TablaDircli.Rows(ContB)("FECDOCUM") & "'")
                    TmpInsertDatos("SP_INSERT_TMP_VENTACAB3  '" & codempresa & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & dr.Item(0).ToString & "'")
                    TmpInsertDatos("NSP_ACTUALIZA_SALDO_CLIENTE2_HISTO  '" & codempresa & "','" & 0 & "','" & TablaDircli.Rows(ContB)("CODTIPODOC") & "','" & TablaDircli.Rows(ContB)("NRODOCU") & "','" & codalmacen & "'")



                    Dim Sql2 As String
                    Sql2 = "UPD_ALMACEN '" & txtNroDoc.Text & "','" & cbTipoDoc2.SelectedValue.ToString & "','" & cboAlmacen.SelectedValue.ToString & "','" & "VENTD" & Microsoft.VisualBasic.Right(dr.Item(0).ToString, 6) & "'"
                    If TmpInsertDatos(Sql2) = True Then
                    End If



                Next

            End If

        Next

        MsgBox("SE ACTUALIZO")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim Sql2 As String
        Sql2 = "upda_FECH_GUIAINTERNACAB '" & codempresa & "','" & txtNroDespacho2.Text & "','" & Format(CDate(DtFechaDoc.Value), "dd/MM/yyyy") & "'"
        If TmpInsertDatos(Sql2) = True Then
            MsgBox("SE ACTUALIZO")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim Sql2 As String
        Sql2 = "SP_REGRESAR_DOCUMENTOCONTABLE '" & TextBox2.Text & "'"
        If TmpInsertDatos(Sql2) = True Then
            MsgBox("SE REGRESO... NO TE OLVIDES DE REGRESAR LOS NUMEROS DE DOCUMENTOS")
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click



        Dim SERIE As String
        Dim NRODOCSIN As String
        Dim NRODOCFINAL As String
        Dim LETRADOC As String
        Dim CLIE_DOCU As String



        Dim DNI As String
        Dim IGV As Double
        Dim EMAIL As String
        Dim SUBTOTAL As Double
        Dim PERCEP As Double
        Dim TIPO_IGV As String


        Dim listaP As New List(Of NuevaVentaDet)


        If EMIELECTRONIC = True Then

            Dim fecha As String
            Dim Totalbas As Double
            Dim CODTIPOPAGO As String
            Dim CodVend As String

            Dim Table_VC As New DataTable
            Table_VC = TmpListarDatos("SP_DOCUMENTO_FALTAN_ENVIAR_2   '" & codempresa & "','" & txtNroguia.Text & "'")

            If Table_VC.Rows.Count > 0 Then
                For Y As Integer = 0 To Table_VC.Rows.Count - 1

                    TipoDoc = Table_VC.Rows(Y)("CODTIPODOC").ToString()
                    VNroDoc = Table_VC.Rows(Y)("NRODOCU").ToString()
                    IGV = CDbl(Table_VC.Rows(Y)("IGVBAS").ToString())
                    fecha = Table_VC.Rows(Y)("FECDOCUM").ToString()
                    VRuc = Table_VC.Rows(Y)("RUCCLIENTE").ToString()
                    VCodCliente = Table_VC.Rows(Y)("CODCLIENTE").ToString()
                    VDescliente = Table_VC.Rows(Y)("DESCLIENTE").ToString()
                    Totalbas = CDbl(Table_VC.Rows(Y)("TOTBAS").ToString())
                    CODTIPOPAGO = CDbl(Table_VC.Rows(Y)("CODTIPOPAGO").ToString())
                    VDireccion = Table_VC.Rows(Y)("direccion").ToString()
                    IGV = CDbl(Table_VC.Rows(Y)("IGVBAS").ToString())
                    SUBTOTAL = CDbl(Table_VC.Rows(Y)("SUBTOTBAS").ToString())
                    PERCEP = CDbl(Table_VC.Rows(Y)("IPERCEP").ToString())
                    EMAIL = Table_VC.Rows(Y)("EMAIL").ToString()
                    DNI = Table_VC.Rows(Y)("DNI").ToString()
                    CodVend = Table_VC.Rows(Y)("CODVEND").ToString()



                    Dim StrSql As String
                    StrSql = "SELECT VENTD202001.ITEM,VENTD202001.CODARTI, VENTD202001.DESARTI, VENTD202001.PRECIO, " &
                             "  VENTD202001.CANTIDAD,  VENTD202001.SUBTOTBAS, '01' AS TIPOPRE," &
                                   "  VENTD202001.TOTBAS, VENTD202001.IGVBAS,(VENTD202001.SUBTOTBAS/VENTD202001.CANTIDAD) AS PRECSINIGV," &
                                   "   VENTD202001.MONTODESCBAS ,VENTD202001.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC " &
                             " FROM ARTICULO INNER JOIN VENTD202001 ON ARTICULO.CODARTI = VENTD202001.CODARTI" &
                              " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                          "  INNER JOIN PRESENTACION ON PRESENTACION.codpres = VENTD202001.CODPRES" &
                        " WHERE VENTD202001.NRODOCU = " & CInt(VNroDoc) & " AND VENTD202001.CODTIPODOC  = " & CStr(TipoDoc) & " ORDER BY VENTD202001.ITEM "

                    Dim Tabla_Tmp As DataTable
                    Tabla_Tmp = TmpListarDatos(StrSql)

                    listaP.Clear()
                    If Tabla_Tmp.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp.Rows.Count - 1
                            Dim o As New NuevaVentaDet
                            o.CODARTI = Tabla_Tmp.Rows(x)("CODARTI")
                            o.DESARTI = Tabla_Tmp.Rows(x)("DESARTI")
                            o.CODFACELEC = Tabla_Tmp.Rows(x)("CODFACELEC")
                            o.PRECIO = Tabla_Tmp.Rows(x)("PRECIO")
                            o.MONTODESCBAS = Tabla_Tmp.Rows(x)("MONTODESCBAS")
                            o.CANTIDAD = Tabla_Tmp.Rows(x)("CANTIDAD")
                            o.IGVBAS = Tabla_Tmp.Rows(x)("IGVBAS")
                            o.TIPO_IGV = IIf(CDbl(Tabla_Tmp.Rows(x)("IGVBAS")) <> 0, "IGV", "INA")
                            listaP.Add(o)
                        Next
                    End If


                    If TipoDoc.Trim = "01" Or TipoDoc.Trim = "03" Then



                        If IGV > 0 Then
                            TIPO_IGV = "SI"
                        Else
                            TIPO_IGV = "NO"
                        End If

                        'Dim Table_VC2 As New DataTable
                        'Table_VC2 = TmpListarDatos("SP_SELECT_EMAIL_CLIENTE   '" & CStr(TABLE_CONSOLCLIE.Rows(i)("CODTIPODOC").ToString) & "','" & CStr(TABLE_CONSOLCLIE.Rows(i)("NRODOCFACT").ToString) & "'")
                        'If Table_VC2.Rows.Count > 0 Then
                        '    EMAIL = Table_VC2.Rows(0)("EMAIL").ToString()
                        '    DNI = Table_VC2.Rows(0)("DNI").ToString()
                        If VCodCliente = "888" Then
                            DNI = "88888888"
                        End If
                        'End If



                        If TipoDoc.Trim = "01" Then
                            LETRADOC = "F"
                            CLIE_DOCU = CStr(VRuc.Trim)
                        End If
                        If TipoDoc.Trim = "03" Then
                            LETRADOC = "B"
                            CLIE_DOCU = DNI
                            If CLIE_DOCU.Length = 0 Then
                                CLIE_DOCU = "99999999"
                            End If
                        End If

                        Dim FormatNroDoc As String
                        FormatNroDoc = Format(VNroDoc, "0##-########")
                        Dim NUMSERIE As String
                        NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)
                        SERIE = LETRADOC + NUMSERIE
                        NRODOCSIN = CStr(Microsoft.VisualBasic.Right(VNroDoc, 8))
                        NRODOCFINAL = SERIE + "-" + NRODOCSIN

                        Dim dblTOTINAFECTO As Double
                        Dim TABLA_INAFECTO As New DataTable
                        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTOHISTO  '" & TipoDoc & "','" & VNroDoc & "'  ")

                        If TABLA_INAFECTO.Rows.Count > 0 Then
                            dblTOTINAFECTO = CDbl(FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString)
                        End If



                        If NOSERIE = SERIE Then


                        Else
                            Try

                                Dim gestordefacturacionelectronica As IGestorDeFacturacionElectronica = New GestorDeFacturacionElectronica()
                                Dim nuevohdocumento As New NuevaHdocumento

                                nuevohdocumento.codi_cab = 1
                                nuevohdocumento.esta_pod = 1
                                nuevohdocumento.codi_caja = CStr(NROPTOVTA)
                                nuevohdocumento.comp = TipoDoc
                                nuevohdocumento.serie = SERIE
                                nuevohdocumento.nume = NRODOCSIN
                                nuevohdocumento.fecha = Format(CDate(fecha), "dd/MM/yyyy")
                                nuevohdocumento.codi_vend = CodVend
                                nuevohdocumento.clie_docu = CLIE_DOCU
                                nuevohdocumento.clie_nomb = VDescliente
                                nuevohdocumento.clie_dire = VDireccion
                                nuevohdocumento.clie_email = EMAIL
                                nuevohdocumento.clie_celu = ""
                                nuevohdocumento.dire_entr = ""
                                nuevohdocumento.ubig_entr = UBIGUEO
                                nuevohdocumento.mone_codi = "PEN"
                                nuevohdocumento.LLEVAigv = TIPO_IGV
                                nuevohdocumento.desc_globa = ""
                                nuevohdocumento.obse = ""
                                nuevohdocumento.guia = ""
                                nuevohdocumento.placa = ""
                                nuevohdocumento.dire_part = ""
                                nuevohdocumento.ubig_part = ""
                                nuevohdocumento.ubig_lleg = ""
                                nuevohdocumento.cod_Ubigeo = ""
                                nuevohdocumento.tipo_trans = ""
                                nuevohdocumento.peso_kg = 0.0
                                nuevohdocumento.trans_publ_ruc = ""
                                nuevohdocumento.trans_publ_razon = ""
                                nuevohdocumento.trans_priv_placa = ""
                                nuevohdocumento.trans_priv_marca = ""
                                nuevohdocumento.trans_priv_const = ""
                                nuevohdocumento.trans_priv_lice = ""
                                nuevohdocumento.codi_moti = ""
                                nuevohdocumento.motivo = ""
                                nuevohdocumento.doc_refe = ""
                                nuevohdocumento.ValorResumen = 0.0
                                nuevohdocumento.ValorHash = ""
                                nuevohdocumento.DarBaja = 0
                                nuevohdocumento.MotivoBaja = ""
                                nuevohdocumento.ProcesarBaja = 0
                                nuevohdocumento.Grabado = SUBTOTAL - dblTOTINAFECTO
                                nuevohdocumento.IGV = IGV
                                nuevohdocumento.Total = Totalbas
                                nuevohdocumento.dire_lleg = ""
                                nuevohdocumento.Guia_trans = ""
                                nuevohdocumento.Envio_xml = 0
                                nuevohdocumento.Clie_tipo = IIf(CStr(VRuc.Trim) <> "", 6, 1)
                                nuevohdocumento.Fact_guia = "NO"
                                nuevohdocumento.Exonerado = 0
                                nuevohdocumento.Inafecto = dblTOTINAFECTO
                                nuevohdocumento.percepcion = PERCEP
                                nuevohdocumento.Codigo_local = CODLOCAL
                                nuevohdocumento.hora = Now.ToString("HH:mm:ss")

                                Using scope As TransactionScope = New TransactionScope()

                                    Dim CODCAB As Integer
                                    CODCAB = gestordefacturacionelectronica.CrearHdocumento(nuevohdocumento).codi_cab

                                    For x As Integer = 0 To listaP.Count - 1
                                        Dim nuevoddocumento As New NuevaDDocumento
                                        nuevoddocumento.id = 1
                                        nuevoddocumento.prod_codi = listaP.Item(x).CODARTI.ToString
                                        nuevoddocumento.prod_descr = listaP.Item(x).DESARTI.ToString
                                        nuevoddocumento.prod_unid = listaP.Item(x).CODFACELEC.ToString
                                        nuevoddocumento.prod_precio = listaP.Item(x).PRECIO
                                        nuevoddocumento.prod_desct = listaP.Item(x).MONTODESCBAS
                                        nuevoddocumento.prod_cant = listaP.Item(x).CANTIDAD
                                        nuevoddocumento.igv = listaP.Item(x).IGVBAS
                                        nuevoddocumento.percepcion = PERCEP
                                        nuevoddocumento.codi_cab = CODCAB
                                        nuevoddocumento.tipo_igv = listaP.Item(x).TIPO_IGV
                                        nuevoddocumento.obse = "AAAAA"
                                        nuevoddocumento.codigo_sunat = " "
                                        nuevoddocumento.codigo_gsi = " "
                                        gestordefacturacionelectronica.CrearDdocumento(nuevoddocumento)
                                    Next
                                    gestordefacturacionelectronica.ModificarEstado(SERIE, NRODOCSIN)
                                    scope.Complete()
                                End Using

                            Catch ex As Exception
                                MsgBox("- REVISE LA FACTURACION ELECTRONICA, HAY ALGUNA FALLA ." & ex.Message, MsgBoxStyle.Information, "NARSISTEMAS")
                                Exit Sub
                            End Try
                            CAyuda.Ejecutar("SP_UDPDATE_CABCODHAS_2", VNroDoc, TipoDoc, "", 1, SERIE, NRODOCSIN)
                        End If
                    End If

                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''' VERIFICO SI SE ENVIO A SUNAT O CORRECTAMENTE '''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Next
            End If
        End If


        MsgBox("SE ENVIARON TODOS LOS DOCUMENTOS")


    End Sub
End Class