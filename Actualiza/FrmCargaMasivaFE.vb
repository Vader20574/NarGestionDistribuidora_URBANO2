Imports System.Data.SqlClient
Imports System.Transactions
Imports Servicios.Implementacion
Imports Servicios.Interfaces.Factura
Imports Servicios.Interfaces.Facturacion.VentaDet.Peticiones
Imports Servicios.Interfaces.FacturaElectronica.Peticiones

Public Class FrmCargaMasivaFE
    Dim Ayuda As New ClsAyuda
    Dim listaP As New List(Of NuevaVentaDet)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            OpenFileDialog1.DefaultExt = "*.xls"
            OpenFileDialog1.Filter = "Excel | *.xls"
            If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            Else
                TextBox1.Text = OpenFileDialog1.FileName
                CargarExcel(DataGrid1, TextBox1.Text, "VentasSunatDetallado")
                Button2.Enabled = True
            End If
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub CargarExcel(ByVal dgDespacho As DataGrid, ByVal vLibro As String, ByVal vHoja As String)
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & vLibro & ";" & "Extended Properties=""Excel 8.0;HDR=YES"""
        Try
            Dim cn As New OleDb.OleDbConnection(cs) 'cadena de coneccion 

            If Not System.IO.File.Exists(vLibro) Then
                MsgBox("No se encontro un libro válido en la ubicación especificada.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim da As New OleDb.OleDbDataAdapter("Select * from [" & vHoja & "$] WHERE CODEMPRESA='01' ", cs)
            Dim ds As New DataSet

            da.Fill(ds)
            dgDespacho.DataSource = ds.Tables(0)


        Catch ex As Exception
            MsgBox("No se encontro un libro válido en la ubicación especificada. " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Sub OBTENERCORRELATIVO()
        Dim SQL As String
        Dim DS As New DataSet
        SQL = "ObtenerCorrelativoProcUtil '" & CodUsuario & "'"
        DS = TmpListarDataset(SQL)
        VCorrelVta = DS.Tables(0).Rows(0)(0)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        CargarExcel2(TextBox1.Text, "VentasSunatDetallado")
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub





    Public Sub CargarExcel2(ByVal vLibro As String, ByVal vHoja As String)



        OBTENERCORRELATIVO()


        Dim FECDOCUM As Date
        Dim FECPROCESO As Date
        Dim NRODOCU As Double
        Dim Dt_TimeOut As Integer = 500000
        Dim AFEC As Integer

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & vLibro & ";" & "Extended Properties=""Excel 8.0;HDR=YES"""
        Try
            Dim cn As New OleDb.OleDbConnection(cs) 'cadena de coneccion 

            If Not System.IO.File.Exists(vLibro) Then
                MsgBox("No se encontro un libro válido en la ubicación especificada.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim da As New OleDb.OleDbDataAdapter("Select * from [" & vHoja & "$]", cs)
            Dim ds As New DataTable
            Dim StrTipodoc As String
            Dim SQL As String
            Dim VENTC As String
            Dim VENTD As String
            Dim AÑO As String
            Dim MES As String

            Dim codArticulo As String
            Dim codPresentacion As String
            Dim desPresentacion As String
            Dim cantidad As String
            Dim Precio As Double

            Dim CODTIPOPAGO As String
            Dim FECDOCUM1 As Date
            Dim CODVENDEDOR As String
            Dim TOTBAS As Double
            Dim CODCLIENTDEP As String
            Dim RUCCLIENTE As String
            Dim DESCLIENTE As String
            Dim DIRCLIENTE As String

            'Dim NRODOC1 As String
            'Dim TIPODOC1 As String
            Dim CODCLIENTPRI As String

            Dim NRODOC As String
            Dim TIPODOC As String


            da.Fill(ds)

            '/********validar documentos

            Dim NRODOCVAL As String
            Dim TIPODOCVAL As String
            Dim CODCLIENTDEPVAL As String


            If ds.Rows.Count > 0 Then
                For Each dt As DataRow In ds.Rows
                    TIPODOCVAL = ValidaNullSTring(dt.Item(1))
                    NRODOCVAL = ValidaNullSTring(dt.Item(2))
                    CODCLIENTDEPVAL = dt.Item(7)
                    Dim TABLE1 As New DataTable
                    TABLE1 = TmpListarDatos("NSP_BUSCAR_FACTURACION  '" & codempresa & "','" & CInt(NRODOCVAL) & "','" & TIPODOCVAL & "','" & VCorrelVta & "'")
                    If TABLE1.Rows.Count > 0 Then
                        MsgBox("EL DOCUMENTO YA EXISTE NRO " & NRODOCVAL & " TIPO " & TIPODOCVAL & " REVISE! ")
                        Exit Sub
                    End If

                    Dim dt_TABLA4 As New DataTable
                    dt_TABLA4 = CAyuda.ListarDatos("SP_CODCLIDEP", CODCLIENTDEPVAL).Tables(0)
                    If dt_TABLA4.Rows.Count > 0 Then
                        CODCLIENTPRI = dt_TABLA4.Rows(0)(0).ToString
                    Else
                        MsgBox("cliente " & CODCLIENTDEPVAL & " no existe REVISE!")
                        Exit Sub
                    End If


                Next
            End If



            If ds.Rows.Count > 0 Then
                For Each dt As DataRow In ds.Rows


                    NRODOC = ValidaNullSTring(dt.Item(2))

                    If NRODOC = "" Then
                        Exit For
                    End If


                    Dim DESPRES As String
                    Dim dt_TABLA2 As New DataTable
                    dt_TABLA2 = CAyuda.ListarDatos("SP_SELECT_PRESENT", dt.Item(10)).Tables(0)
                    If dt_TABLA2.Rows.Count > 0 Then
                        DESPRES = dt_TABLA2.Rows(0)(0).ToString
                    End If

                    codArticulo = dt.Item(8)
                    desPresentacion = dt.Item(10)
                    cantidad = dt.Item(11)
                    Precio = dt.Item(12)
                    CODTIPOPAGO = dt.Item(3)
                    FECDOCUM1 = CDate(dt.Item(5))
                    CODVENDEDOR = dt.Item(4)
                    TOTBAS = dt.Item(6)
                    CODCLIENTDEP = dt.Item(7)
                    TIPODOC = dt.Item(1)



                    Dim TAB_CLIE As New DataTable
                    TAB_CLIE = TmpListarDatos("SP_SelectClienteFact   '" & codempresa & "','" & CODCLIENTDEP & "', '" & VRuc & "','" & 0 & "'")
                        If TAB_CLIE.Rows.Count > 0 Then
                        DESCLIENTE = TAB_CLIE.Rows(0)("DATOADJUNTO").ToString.Trim
                        DIRCLIENTE = TAB_CLIE.Rows(0)("DIRECCION").ToString.Trim
                        RUCCLIENTE = TAB_CLIE.Rows(0)("RUC").ToString.Trim
                    End If


                    Dim dt_TABLA4 As New DataTable
                    dt_TABLA4 = CAyuda.ListarDatos("SP_CODCLIDEP", CODCLIENTDEP).Tables(0)
                    If dt_TABLA4.Rows.Count > 0 Then
                        CODCLIENTPRI = dt_TABLA4.Rows(0)(0).ToString
                    Else
                        MsgBox("cliente no existe")
                        Exit For
                    End If

                    'If DOCANT = NRODOC1 Then
                    Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADETFD", codempresa, codArticulo, desPresentacion, DESPRES, cantidad, Precio, Precio, 0, CodUsuario, NROPTOVTA, VCorrelVta, "", 0, CDZONA, CHECKPROMO)

                    'End If

                    'If DOCANT = "" Then
                    '    DOCANT = dt.Item(2)
                    'End If

                    'NRODOC1 = ValidaNullSTring(dt.Item(2))

                    'If DOCANT <> NRODOC1 Then

                    Dim cn2 As New SqlConnection(STRCN)
                    If cn2.State = ConnectionState.Open Then
                        cn2.Close()
                    End If
                    cn2.Open()
                    Dim cmd2 As New SqlCommand("Nsp_grabadocumento_CargaMasivaFE", cn2)
                    cmd2.CommandType = CommandType.StoredProcedure

                    cmd2.Parameters.AddWithValue("@NRODEGUIAS", CStr("")).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@NPESADA", CStr("")).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@Eigv", "True").SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@actualizocorrelativo", CStr(fact_editnumero)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@NUMEROTRANS", CInt(FACT_NUMEROTRANSACCION)).SqlDbType = SqlDbType.Int
                    cmd2.Parameters.AddWithValue("@CODDEP", CStr(CODCLIENTPRI)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@CODTIPOPAGO", CODTIPOPAGO.Trim).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@CODTIPODOC", CStr(TIPODOC)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@NRODOCU", CStr(NRODOC)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@codmon", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@CAMBIO", FACT_GFormatodeNumero(CDbl(VCambioVta))).SqlDbType = SqlDbType.Decimal
                    cmd2.Parameters.AddWithValue("@codvend", CODVENDEDOR).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@FECDOCUM", FECDOCUM1).SqlDbType = SqlDbType.DateTime
                    cmd2.Parameters.AddWithValue("@TOTBAS", CDec(TOTBAS)).SqlDbType = SqlDbType.Decimal
                    cmd2.Parameters.AddWithValue("@PORCENDESC1", CDec(0)).SqlDbType = SqlDbType.Decimal
                    cmd2.Parameters.AddWithValue("@TOTVUELTOBAS", CDec("0.00")).SqlDbType = SqlDbType.Decimal
                    cmd2.Parameters.AddWithValue("@TOTCASHBAS", CDec("0.00")).SqlDbType = SqlDbType.Decimal
                    cmd2.Parameters.AddWithValue("@TOTCASHEXT", CDec("0.00")).SqlDbType = SqlDbType.Decimal
                    cmd2.Parameters.AddWithValue("@codcliente", CStr(CODCLIENTDEP)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@RUCCLIENTE", CStr(RUCCLIENTE)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@DESCLIENTE", CStr(DESCLIENTE)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@DIRCLIENTE", CStr(DIRCLIENTE)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@usuario", CStr(CodUsuario)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@CODEMPRESA", CStr(codempresa)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@MONEDABASE", CStr(FACT_CDMONEDA)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@NROPTOVTA", CStr(NROPTOVTA)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@CORRELATIVO", CInt(VCorrelVta)).SqlDbType = SqlDbType.Int
                    cmd2.Parameters.AddWithValue("@POSTPAGO", CBool(True)).SqlDbType = SqlDbType.Bit
                    cmd2.Parameters.AddWithValue("@Hora", 0).SqlDbType = SqlDbType.VarChar
                    cmd2.CommandTimeout = Dt_TimeOut

                    Try
                        AFEC = cmd2.ExecuteNonQuery()
                        cn2.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try

                Next


                ENVIAR_FACTURACION_ELECTRONICA("01")


                MsgBox("Transferencia Realizada con Exito... " + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
            End If

        Catch ex As Exception
            MsgBox("No se encontro un libro válido en la ubicación especificada. " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try






    End Sub



    Sub ENVIAR_FACTURACION_ELECTRONICA(CODEMPRESA As String)
        If EMIELECTRONIC = True Then


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


            Dim TipoDoc As String
            Dim VNroDoc As Double
            Dim fecha As String
            Dim impresora As String



            Dim Totalbas As Double
            Dim CODTIPOPAGO As String
            Dim CodVend As String

            Dim Table_VC As New DataTable

            Table_VC = TmpListarDatos("SP_DOCUMENTO_CARGAMASIVA_FE   '" & CODEMPRESA & "'")

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
                    PERCEP = 0
                    EMAIL = Table_VC.Rows(Y)("EMAIL").ToString()
                    DNI = Table_VC.Rows(Y)("DNI").ToString()
                    CodVend = Table_VC.Rows(Y)("CODVEND").ToString()



                    Dim StrSql As String
                    StrSql = "SELECT VENTADETFE.ITEM,VENTADETFE.CODARTI, VENTADETFE.DESARTI, VENTADETFE.PRECIO, " &
                             "  VENTADETFE.CANTIDAD,  VENTADETFE.SUBTOTBAS, '01' AS TIPOPRE," &
                                   "  VENTADETFE.TOTBAS, VENTADETFE.IGVBAS,(VENTADETFE.SUBTOTBAS/VENTADETFE.CANTIDAD) AS PRECSINIGV," &
                                   "   VENTADETFE.MONTODESCBAS ,VENTADETFE.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC " &
                             " FROM ARTICULO INNER JOIN VENTADETFE ON ARTICULO.CODARTI = VENTADETFE.CODARTI" &
                              " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                          "  INNER JOIN PRESENTACION ON PRESENTACION.codpres = VENTADETFE.CODPRES" &
                        " WHERE  CONVERT(decimal(20,4),VENTADETFE.NRODOCU) = " & CDbl(VNroDoc) & " AND VENTADETFE.CODTIPODOC  = " & CStr(TipoDoc) & " ORDER BY VENTADETFE.ITEM "

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
                        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTOFE  '" & TipoDoc & "','" & VNroDoc & "'  ")

                        If TABLA_INAFECTO.Rows.Count > 0 Then
                            dblTOTINAFECTO = CDbl(FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString)
                        End If

                        If NOSERIE = SERIE Then
                            CAyuda.Ejecutar("SP_UDPDATE_VENTACABFE_NUMDOC", VNroDoc, TipoDoc, "", 1, SERIE, NRODOCSIN)

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
                                nuevohdocumento.fecha = fecha
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
                                nuevohdocumento.Grabado = (SUBTOTAL - dblTOTINAFECTO)
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

                                    For x As Integer = 0 To Me.listaP.Count - 1
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
                            CAyuda.Ejecutar("SP_UDPDATE_VENTACABFE_NUMDOC", VNroDoc, TipoDoc, "", 1, SERIE, NRODOCSIN)
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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ENVIAR_FACTURACION_ELECTRONICA("01")
    End Sub
End Class