Imports System.Transactions
Imports Servicios.Implementacion
Imports Servicios.Interfaces.Factura
Imports Servicios.Interfaces.Facturacion.VentaDet.Peticiones
Imports Servicios.Interfaces.FacturaElectronica.Peticiones

Public Class FrmEnviarFE



    Private TABLE_PEDIDOS_FACTURAR As New DataTable
    Private CORRELATIVO As String
    Private NRODOCUMENTO As String
    Private CODZONA As String
    Private NomMaq As String
    Private STRNROPTOVTA As String
    Dim TABLE_CABECERA_PEDI As New DataTable
    Dim TABLE_DETALLE_PEDI As New DataTable
    '-------------------------------------------------------
    Private NROBOLETA As Integer
    Private NROFACTURA As Integer
    Private NRONOTA_PEDIDO As Integer
    Private CONTBOL As Integer
    Private CONTFACT As Integer
    Private CONTNTAPE As Integer
    Private ITEMFACT As Integer
    Private ITEMBOL As Integer
    Private ITEMNTAPED As Integer
    '-------------------------------------------------------
    Private TABLE_DETALLE_VERIFI As New DataTable
    Private NROMAXIMO As Integer
    Private NROMINIMO As Integer
    Public TablaARTI_FZAVENTA As New DataTable
    Private TABLE_CONSOLCLIE As New DataTable
    Dim GUIAD As String
    Dim GUIAC As String

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
    Dim listaDesc As New List(Of DescDdocum)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''FACTURACION ELECTRONICA ENVIO BASE''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        '''''''''''''''''''''''''''''''''''''''''''''
        ''''''''''''''''''''''''''''''''''''''''''''' 

        If EMIELECTRONIC = True Then

            Dim fecha As String
            Dim fecha_venc As String
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
                    CODTIPOPAGO = Table_VC.Rows(Y)("CODTIPOPAGO").ToString()
                    VDireccion = Table_VC.Rows(Y)("direccion").ToString()
                    IGV = CDbl(Table_VC.Rows(Y)("IGVBAS").ToString())
                    SUBTOTAL = CDbl(Table_VC.Rows(Y)("SUBTOTBAS").ToString())
                    PERCEP = CDbl(Table_VC.Rows(Y)("IPERCEP").ToString())
                    EMAIL = Table_VC.Rows(Y)("EMAIL").ToString()
                    DNI = Table_VC.Rows(Y)("DNI").ToString()
                    CodVend = Table_VC.Rows(Y)("CODVEND").ToString()
                    fecha_venc = Table_VC.Rows(Y)("FECVENC").ToString()


                    Dim StrSql As String
                    StrSql = "SELECT VENTADET.ITEM,VENTADET.CODARTI, VENTADET.DESARTI, VENTADET.preciovta, " &
                             "  VENTADET.CANTIDAD,  VENTADET.SUBTOTBAS, '01' AS TIPOPRE," &
                                   "  VENTADET.TOTBAS, VENTADET.IGVBAS,(VENTADET.SUBTOTBAS/VENTADET.CANTIDAD) AS PRECSINIGV," &
                                   "   VENTADET.MONTODESCBAS ,VENTADET.PORCENDESC,PRESENTACION.desumedSunat AS CODFACELEC,ARTICULO.codimpuesto " &
                             " FROM ARTICULO INNER JOIN VENTADET ON ARTICULO.CODARTI = VENTADET.CODARTI" &
                              " INNER JOIN IMPUESTO ON ARTICULO.CODIMPUESTO = IMPUESTO.CODIMPUESTO AND ARTICULO.CODEMPRESA=IMPUESTO.CODEMPRESA" &
                          "  INNER JOIN PRESENTACION ON PRESENTACION.codpres = VENTADET.CODPRES" &
                        " WHERE CONVERT(decimal(20,4),VENTADET.NRODOCU) = " & CDbl(VNroDoc) & " AND VENTADET.CODTIPODOC  = " & CStr(TipoDoc) & " ORDER BY VENTADET.ITEM "

                    Dim Tabla_Tmp As DataTable
                    Tabla_Tmp = TmpListarDatos(StrSql)

                    listaP.Clear()
                    If Tabla_Tmp.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp.Rows.Count - 1
                            Dim o As New NuevaVentaDet
                            o.CODARTI = Tabla_Tmp.Rows(x)("CODARTI")
                            o.DESARTI = Tabla_Tmp.Rows(x)("DESARTI")
                            o.CODFACELEC = Tabla_Tmp.Rows(x)("CODFACELEC")
                            o.PRECIO = Tabla_Tmp.Rows(x)("preciovta")
                            o.MONTODESCBAS = Tabla_Tmp.Rows(x)("MONTODESCBAS")
                            o.CANTIDAD = Tabla_Tmp.Rows(x)("CANTIDAD")
                            o.IGVBAS = Tabla_Tmp.Rows(x)("IGVBAS")
                            o.ITEM = Tabla_Tmp.Rows(x)("ITEM")
                            o.TIPO_IGV = IIf((Tabla_Tmp.Rows(x)("codimpuesto")) = "IGV", "IGV", "INA")
                            listaP.Add(o)
                        Next
                    End If


                    StrSql = "select codarti,item ,(preciovta - (TOTBAS/CANTIDAD)) as Prod_Desct_Ddocumento from VENTADET" &
                        " WHERE CONVERT(decimal(20,4),NRODOCU) = " & CDbl(VNroDoc) & " AND CODTIPODOC  = " & CStr(TipoDoc) & " and MONTODESCBAS > 0"

                    Dim Tabla_Tmp2 As DataTable
                    Tabla_Tmp2 = TmpListarDatos(StrSql)

                    listaDesc.Clear()
                    If Tabla_Tmp2.Rows.Count > 0 Then
                        For x As Integer = 0 To Tabla_Tmp2.Rows.Count - 1
                            Dim o As New DescDdocum
                            o.codarti = Tabla_Tmp2.Rows(x)("codarti")
                            o.item = Tabla_Tmp2.Rows(x)("item")
                            o.prod_desct = Tabla_Tmp2.Rows(x)("Prod_Desct_Ddocumento")
                            listaDesc.Add(o)
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


                        If FACTPTOVTA = True Then
                            If NOSERIE = SERIE Then

                            Else
                                GoTo IR
                            End If
                        End If


                        If FACTLINEA = True Then
                            GoTo IR
                        End If

                        If FACTSUBEMP = True Then
                            GoTo IR
                        End If

IR:

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

                            If CODTIPOPAGO = "01" Then
                                nuevohdocumento.Forma_pago = "CONTADO"
                                nuevohdocumento.total_credito = 0

                            End If

                            If CODTIPOPAGO = "06" Then
                                nuevohdocumento.Forma_pago = "CREDITO"
                                nuevohdocumento.total_credito = Totalbas
                            End If



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

                                    For d As Integer = 0 To Me.listaDesc.Count - 1
                                        If listaP.Item(x).CODARTI.ToString = listaDesc.Item(d).codarti.ToString Then
                                            If CInt(listaP.Item(x).ITEM) = CInt(listaDesc.Item(d).item) Then
                                                nuevoddocumento.prod_desct = listaDesc.Item(d).prod_desct.ToString
                                                Exit For
                                            End If
                                        End If
                                    Next


                                    If listaP.Item(x).PRECIO.ToString() = "0.0100" Then
                                        If listaP.Item(x).TIPO_IGV = "IGV" Then
                                            nuevoddocumento.igv = Math.Round((1.18 - 1) * (listaP.Item(x).CANTIDAD * listaP.Item(x).PRECIO / 1.18), 6)
                                            nuevoddocumento.tipo_igv = "IGV"
                                        Else
                                            nuevoddocumento.igv = 0
                                            nuevoddocumento.tipo_igv = "INA"
                                        End If
                                    Else
                                        nuevoddocumento.igv = listaP.Item(x).IGVBAS
                                        nuevoddocumento.tipo_igv = listaP.Item(x).TIPO_IGV
                                    End If

                                    nuevoddocumento.percepcion = PERCEP
                                    nuevoddocumento.codi_cab = CODCAB
                                    nuevoddocumento.obse = "AAAAA"
                                    nuevoddocumento.codigo_sunat = " "
                                    nuevoddocumento.codigo_gsi = " "
                                    gestordefacturacionelectronica.CrearDdocumento(nuevoddocumento)
                                Next
                                gestordefacturacionelectronica.ModificarEstado(SERIE, NRODOCSIN)



                                If CODTIPOPAGO = "06" Then

                                    Dim nuevocdocumento As New NuevaCDocumento
                                    nuevocdocumento.cred_codi = 1
                                    nuevocdocumento.codi_cab = CODCAB
                                    nuevocdocumento.num_cuota = 1
                                    nuevocdocumento.monto_cuota = Totalbas
                                    nuevocdocumento.fecha_vence = Format(CDate(fecha_venc), "dd/MM/yyyy")
                                    gestordefacturacionelectronica.CrearCDocumento(nuevocdocumento)
                                End If

                                scope.Complete()





                            End Using

                        Catch ex As Exception
                            MsgBox("- REVISE LA FACTURACION ELECTRONICA, HAY ALGUNA FALLA ." & ex.Message, MsgBoxStyle.Information, "NARSISTEMAS")
                            Exit Sub
                        End Try
                        CAyuda.Ejecutar("SP_UDPDATE_CABCODHAS2", VNroDoc, TipoDoc, "", 1, SERIE, NRODOCSIN)


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

    Private Sub FrmEnviarFE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DtFechaDoc.Value = Format(vFechaActual, "dd/MM/yyyy")


    End Sub
End Class