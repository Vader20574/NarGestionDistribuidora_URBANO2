Imports System.IO
Imports System.IO.Compression.FileSystem
Imports Ionic.Zip
Imports Ionic.BZip2
Imports System.IO.Compression
Imports CapaCliente

Public Class FrmTranferirProtisa

    Dim TABLE_ORDENDESPACHO As DataTable
    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""

    Dim rand As Integer
    Dim Todo_Cate As Int16
    Dim FECHA_1 As String
    Dim FechaIni, FechaFin As String


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WINKEYdOWN As Integer = &H100
        Const WINKEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WINKEYdOWN) Or (MSG.Msg = WINKEYSYSTEM)) Then
            Select Case (KeyData)
                Case Keys.Enter
                    If grid1.Focus = True Then
                        If TABLE_ORDENDESPACHO.Rows.Count > 0 Then
                            If grid1.CurrentCell.ColumnNumber = 8 Or grid1.CurrentCell.ColumnNumber = 7 Then
                                If grid1.CurrentRowIndex > -1 Then
                                    Dim FrmOpciones As New FrmModificarVentas
                                    FrmOpciones.NRODOCU = grid1.Item(grid1.CurrentRowIndex, 1).ToString.Trim
                                    FrmOpciones.CODTIPODOC = grid1.Item(grid1.CurrentRowIndex, 2).ToString.Trim
                                    FrmOpciones.ITEM = grid1.Item(grid1.CurrentRowIndex, 5).ToString.Trim
                                    FrmOpciones.ARTICULO = grid1.Item(grid1.CurrentRowIndex, 6).ToString.Trim
                                    FrmOpciones.PRECIO = grid1.Item(grid1.CurrentRowIndex, 8).ToString.Trim
                                    FrmOpciones.CANTIDAD = grid1.Item(grid1.CurrentRowIndex, 7).ToString.Trim
                                    FrmOpciones.DESCUENTO = grid1.Item(grid1.CurrentRowIndex, 11).ToString.Trim
                                    FrmOpciones.ShowDialog()
                                    If FrmOpciones.DEVOLVER = True Then
                                        'For i As Integer = 0 To TABLE_ORDENDESPACHO.Rows.Count - 1
                                        '    If TABLE_ORDENDESPACHO.Rows(i)("CORRNBR").ToString.Trim = grid1.Item(grid1.CurrentRowIndex, 1).ToString.Trim _
                                        '    And TABLE_ORDENDESPACHO.Rows(i)("NRONTACRED").ToString.Trim = grid1.Item(grid1.CurrentRowIndex, 2).ToString.Trim Then
                                        '        ''''''''''''''''''CAMBIAR EL ESTADO DE NTA CRED
                                        '        'Select Case FrmOpciones.Opcion
                                        '        '    Case 1
                                        '        '        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "NO"
                                        '        '    Case 2
                                        '        '        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "SI"
                                        '        '    Case 3
                                        '        '        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "EN PROCESO"
                                        '        'End Select
                                        '        'RecalcularMonto()
                                        '    End If
                                        'Next

                                        TABLE_ORDENDESPACHO = TmpListarDatos("SP_SELECT_VENTAS  '" & codempresa & "'")
                                        grid1.DataSource = TABLE_ORDENDESPACHO
                                    End If
                                End If
                            End If

                        End If
                    End If


            End Select
        End If



    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim meses As Integer
        Dim Fecinicial As String = ""
        Dim Fecfinal As String = ""
        Dim MesAct, Anio As String
        Dim VentaC As String = ""
        Dim VentD As String = ""
        Dim MoviD As String
        Dim MoviC As String



        'Dim dia As String
        'Dim mes As String
        'Dim año As String

        'dia = Format(CDate(DtFechaIni.Value), "dd")
        'mes = Format(CDate(DtFechaIni.Value), "MM")
        'año = Format(CDate(DtFechaIni.Value), "yyyy")

        'FechaIni = "01/" & mes & "/" & año

        FechaIni = Format(CDate(DtFechaIni.Value).AddDays(-30), "dd/MM/yyyy")


        FechaFin = Format(CDate(DtFechaIni.Value), "dd/MM/yyyy")




        TmpInsertDatos("DELETE FROM TMP_VENTAS")

        meses = Val(DateDiff("m", Format(CDate(FechaIni), "dd/MM/yyyy"), CDate(FechaFin)))

        ''SELECCIONO LAS VENTAS
        For i As Integer = 0 To meses
            MesAct = Format(DateAdd("m", i, CDate(FechaIni)), "MM")
            Anio = Format(DateAdd("m", i, CDate(FechaIni)), "yyyy")
            VentaC = "VENTC" & Anio & MesAct
            VentD = "VENTD" & Anio & MesAct
            MoviD = "MOVID" & Anio & MesAct
            MoviC = "MOVIC" & Anio & MesAct

            If VERIFICA_HISTORICOVENT(VentaC) = True Then
                TmpInsertDatos("SP_INSERT_VENTACAB '" & codempresa & "','" & FechaIni & "','" & FechaFin & "','" & VentD & "','" & VentaC & "',1")
            End If
        Next

        TmpInsertDatos("SP_INSERT_VENTACAB '" & codempresa & "','" & FechaIni & "','" & FechaFin & "','" & VentD & "','" & VentaC & "',0")


        TmpInsertDatos("DELETE FROM TMP_Devoluciones")

        meses = Val(DateDiff("m", Format(CDate(FechaIni), "dd/MM/yyyy"), CDate(FechaFin)))

        ''SELECCIONO LAS VENTAS
        For i As Integer = 0 To meses
            MesAct = Format(DateAdd("m", i, CDate(FechaIni)), "MM")
            Anio = Format(DateAdd("m", i, CDate(FechaIni)), "yyyy")
            VentaC = "VENTC" & Anio & MesAct
            VentD = "VENTD" & Anio & MesAct
            MoviD = "MOVID" & Anio & MesAct
            MoviC = "MOVIC" & Anio & MesAct

            If VERIFICA_HISTORICOVENT(VentaC) = True Then
                TmpInsertDatos("SP_INSERT_TMP_DEVOLUCIONES '" & codempresa & "','" & FechaIni & "','" & FechaFin & "','" & VentD & "','" & VentaC & "',1")
            End If
        Next

        TmpInsertDatos("SP_INSERT_TMP_DEVOLUCIONES '" & codempresa & "','" & FechaIni & "','" & FechaFin & "','" & VentD & "','" & VentaC & "',0")



        TABLE_ORDENDESPACHO = TmpListarDatos("SP_SELECT_VENTAS  '" & codempresa & "'")
        grid1.DataSource = TABLE_ORDENDESPACHO


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If CAyuda.Ejecutar("SP_DELETE_TABLAS", codempresa) > 0 Then
        End If

        'If CAyuda.Ejecutar("SP_INSERT_TMP_MOROSIDAD ", codempresa) > 0 Then
        'End If

        'TmpInsertDatos("DELETE FROM TMP_DOCXVEND")

        'Dim meses As Integer
        'Dim Fecinicial As String = ""
        'Dim Fecfinal As String = ""

        'Dim MesAct, Anio As String
        'Dim VentaC, VentD, MoviD, MoviC As String
        'Dim Table_Productos1 As DataTable
        'Dim nrodoc As String
        'Dim tipodoc As String
        'Dim fecha As Date

        'Table_Productos1 = CAyuda.ListarDatos("SP_RECORRE_DOCS", codempresa).Tables(0)

        'For i As Integer = 0 To Table_Productos1.Rows.Count - 1

        '    nrodoc = Table_Productos1.Rows(i)(0)
        '    tipodoc = Table_Productos1.Rows(i)(1)
        '    fecha = Table_Productos1.Rows(i)(2)

        '    MesAct = Format(DateAdd("m", 0, fecha), "MM")
        '    Anio = Format(DateAdd("m", 0, fecha), "yyyy")
        '    VentaC = "VENTC" & Anio & MesAct
        '    VentD = "VENTD" & Anio & MesAct
        '    MoviD = "MOVID" & Anio & MesAct
        '    MoviC = "MOVIC" & Anio & MesAct

        '    If VERIFICA_HISTORICOVENT(VentaC) = True Then
        '        TmpInsertDatos("SP_BUSCAR_CODVEND '" & nrodoc & "','" & tipodoc & "','" & VentaC & "',1")
        '    End If
        '    TmpInsertDatos("SP_BUSCAR_CODVEND '" & nrodoc & "','" & tipodoc & "','',0")

        'Next

        'If CAyuda.Ejecutar("SP_INSERT_MOROSIDAD", codempresa) > 0 Then
        'End If



        'Dim FechaIni, FechaFin As String
        'FechaIni = Format(CDate(DtFechaIni.Value), "dd/MM/yyyy")
        'FechaFin = Format(CDate(DtFechaIni.Value), "dd/MM/yyyy")



        If CAyuda.Ejecutar("SP_CURSOR_INSERT_CLIENTE", codempresa) > 0 Then
        End If

        'If CAyuda.Ejecutar("CUR_ARTIPROVEE", codempresa) > 0 Then
        'End If



        If CAyuda.Ejecutar("SP_INSERT_DEVOLUCIONES ", codempresa) > 0 Then
        End If

        If CAyuda.Ejecutar("SP_CURSOR_INSERT_VENDEDORES", codempresa) > 0 Then
        End If

        If CAyuda.Ejecutar("SP_CURSOR_INSERT_MOTIVODEVOLUCION ", codempresa) > 0 Then
        End If


        TmpInsertDatos("Delete from TMP_STOCK ")

        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        'Dim Table_Productos As New DataTable
        'Table_Productos = CAyuda.ListarDatos("SP_SELECT_TMP_VENTAS", codempresa).Tables(0)

        'If Table_Productos.Rows.Count > 0 Then
        '    For x As Integer = 0 To Table_Productos.Rows.Count - 1
        '        CadenaCateg = Table_Productos.Rows(x)(0).ToString


        Dim Table_Correlativo As New DataTable

        Table_Correlativo = CAyuda.ListarDatos("Nsp_select_Almacen1", codempresa).Tables(0)
        CadenaCateg = "002"


        If Table_Correlativo.Rows.Count > 0 Then
            For i As Integer = 0 To Table_Correlativo.Rows.Count - 1
                CierreIgual = False
                Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

                dt = SelectFechCiere(Fech, False, Table_Correlativo.Rows(i)(1).ToString)
                FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
                Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
                Fecharf = DateAdd("d", -1, DtFechaIni.Value)

                MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
                MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
                fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

                Procesar_Saldo(FECHCIERRE, Table_Correlativo.Rows(i)(1).ToString)

                If CAyuda.Ejecutar("INSERT_STOCK", Table_Correlativo.Rows(i)(1).ToString, rand) > 0 Then
                End If
            Next
        End If


        If CAyuda.Ejecutar("SP_CURSOR_INSERT_PRODUCTO", codempresa) > 0 Then
        End If
        '    Next
        'End If

        If CAyuda.Ejecutar("SP_CURSOR_INSERT_STOCK", codempresa) > 0 Then

        End If

        If CAyuda.Ejecutar("SP_INSERT_VENTAS", codempresa) > 0 Then
        End If

        Dim Codfecha As String
        Codfecha = Format(DtFechaIni.Value, "dd/MM/yyyy")

        If CAyuda.Ejecutar("sp_verficar_fecha", Codfecha) > 0 Then
        End If

        If CAyuda.Ejecutar("sp_verficar_fecha_2", FechaIni, FechaFin) > 0 Then
        End If

        If CAyuda.Ejecutar("Sp_Insert_HistoClientes", Codfecha) > 0 Then
        End If

        If CAyuda.Ejecutar("Sp_Insert_HistoDevoluciones", Codfecha) > 0 Then
        End If

        If CAyuda.Ejecutar("Sp_Insert_HistoMotivoDevolucion", Codfecha) > 0 Then
        End If

        If CAyuda.Ejecutar("Sp_Insert_HistoProductos", Codfecha) > 0 Then
        End If

        If CAyuda.Ejecutar("Sp_Insert_HistoStock", Codfecha) > 0 Then
        End If

        If CAyuda.Ejecutar("Sp_Insert_HistoVendedores", Codfecha) > 0 Then
        End If

        If CAyuda.Ejecutar("Sp_Insert_HistoMorosidad", Codfecha) > 0 Then
        End If

        If CAyuda.Ejecutar("Sp_Insert_HistoVenta", Codfecha) > 0 Then
        End If

        Generar_archivos()


        MsgBox("SE HIZO LA TRANSFERENCIA CON EXITO...", MsgBoxStyle.Information, "NARSISTEMAS S.A.C.")



    End Sub








    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        TmpInsertDatos("Delete from TMP_STOCK ")

        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        Dim Table_Productos As New DataTable
        Table_Productos = CAyuda.ListarDatos("SP_SELECT_TMP_VENTAS", codempresa).Tables(0)

        If Table_Productos.Rows.Count > 0 Then
            For x As Integer = 0 To Table_Productos.Rows.Count - 1
                CadenaCateg = Table_Productos.Rows(x)(0).ToString
                Dim Table_Correlativo As New DataTable

                Table_Correlativo = CAyuda.ListarDatos("SP_RECORRER_ALMSTK", Table_Productos.Rows(x)(0).ToString).Tables(0)

                If Table_Correlativo.Rows.Count > 0 Then
                    For i As Integer = 0 To Table_Correlativo.Rows.Count - 1
                        CierreIgual = False
                        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

                        dt = SelectFechCiere(Fech, False, Table_Correlativo.Rows(i)(0).ToString)
                        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
                        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
                        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

                        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
                        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
                        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

                        Procesar_Saldo(FECHCIERRE, Table_Correlativo.Rows(i)(0).ToString)
                        If CAyuda.Ejecutar("INSERT_STOCK", Table_Correlativo.Rows(i)(0).ToString, rand) > 0 Then

                        End If
                    Next
                End If
            Next
        End If

        If CAyuda.Ejecutar("SP_CURSOR_INSERT_STOCK", codempresa) > 0 Then

        End If

    End Sub

    Private Function SelectFechCiere(ByVal fecha As Date, ByVal HizoCierre As Boolean, ByVal StrAlmacen As String) As DataTable

        Dim dt As New DataTable
        If HizoCierre = True Then
            'dt = TmpListarDatos("select * from resukdx where fecha='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select *  from Cierre_Inv_protisa where fecha=('" & Format(fecha, "dd/MM/yyyy") & "') AND ALMACEN ='" & StrAlmacen & "'")
        Else
            'dt = TmpListarDatos("SELECT max (fechA) AS FECHA from resukdx where fechA <= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select max (fechA) AS Fecha from Cierre_Inv_protisa where fecha <='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
        End If

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("Fecha") Is DBNull.Value Then
                'dt = TmpListarDatos("SELECT mIN (fechA) AS FECHa from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
                dt = TmpListarDatos("select mIN (fechA)  AS Fecha from Cierre_Inv_protisa where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")

            End If
        Else
            '  dt = TmpListarDatos("SELECT distinct FECHA=max(fecha) from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'   AND ALMACEN ='" & StrAlmacen & "'  group by CODARTI")

            dt = TmpListarDatos("select max(fecha)  AS Fecha from Cierre_Inv_protisa where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "' group by articulo ")

        End If

        Return dt
    End Function



    Sub Procesar_Saldo(ByVal fechaCierre As String, ByVal CDALMACEN As String)
        Dim meses As Integer
        Dim Fecinicial, Fecfinal As String
        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String

        TmpInsertDatos("Delete from TMp_kardex WHERE CORREL =" & rand)


        If CierreIgual = True Then
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")

            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaIni.Value))

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_NXARTI1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")


                End If
            Next

        Else

            meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
            ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSALXARTICULO1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0,'" & rand & "'")

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
                Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct

                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSALXARTICULO1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1,'" & rand & "'")

                End If
                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTASXARTICULO1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "','" & VentaC & "','" & rand & "'")


                End If
            Next

            ''SELECCIONO LOS INGRESOS Y SALIDAS DEL RANGO DEL KARDEX
            MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
            MstrFechaFin = Format(DtFechaIni.Value, "dd/MM/yyyy")

            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")
            '' SELECCIONO LAS VENTAS
            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaIni.Value))

            ''Registros del Histórico
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentD = "VENTD" & Anio & MesAct
                VentaC = "VENTC" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSALXARTI1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")

                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_NXARTI1 '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & CDALMACEN & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next
        End If



        'TmpInsertDatos("UPDATE TMp_kardex SET SALDOFIN=0,COMPRASF=0,INGAJUSTEF=0,INGTRANSFF=0,INGOTROSF=0,VENTASF=0,SALAJUSTEF=0,SALTRANSFF=0,SALOTROSF=0,SALDOFINF=0 WHERE SALDOFIN IS NULL AND CODEMPRESA='" & codempresa & "'")

        If CierreIgual = True Then
            INSERTCIERREALDIA(MstrFechaFinRec, CDALMACEN)
            MstrFechaIni = Format(Me.DtFechaIni.Value, "dd/MM/yyyy")
        Else
            'INSERTO SALDO INICIAL
            INSERTCIERREALDIA(fechaCierre, CDALMACEN)
        End If

        TmpInsertDatos("DELETE FROM TMP_SUMKARDEX2 WHERE CORREL = '" & rand & "'")
        TmpInsertDatos("INSERT INTO TMP_SUMKARDEX2 (CORREL,CDALMA,CDG01,CDARTI,STOCKINI,STOCKREC,COMPRAS,INGAJUSTE,INGTRANSF, INGOTROS,VENTAS,SALAJUSTE,SALTRANSF,SALOTROS,SALDOFIN, COMPRASF,INGAJUSTEF,INGTRANSFF, INGOTROSF,VENTASF,SALAJUSTEF,SALTRANSFF,SALOTROSF,SALDOFINF)" & "select  " & rand & ",cdalma,cdg01,cdarti,sum(stockini) as stockini,0 as stockrec,sum(compras)as compras, sum(INGAJUSTE) as IngAjuste,sum(INGTRANSF) as INGTransf,sum(INGOTROS) as INGotros, sum(VENTAS) as Ventas,sum(SALAJUSTE)as Salajuste,sum(SALTRANSF) as Saltransf, sum(sALOTROS) as Salotros,0 AS SALDOFIN, sum(comprasf)as comprasF,  sum(INGAJUSTEf) as IngAjusteF,sum(INGTRANSFF) as INGTransfF,sum(INGOTROSF) as INGotrosF, sum(VENTASF) as VentasF,sum(SALAJUSTEF)as SalajusteF,sum(SALTRANSFF) as SaltransfF, sum(SalotrosF) As SalotrosF ,0 AS SALDOFINF from TMp_kardex WHERE CORREL= " & rand & "  group by cdalma,cdarti,CDG01")
        TmpInsertDatos("DELETE FROM KARDEX_TMP WHERE CORREL='" & rand & "'")
        'TmpInsertDatos("INSERT INTO KARDEX_TMP (CDALMA,DSALMA,CDARTI,DSARTI,CDG01,DSG01,SALDOFIN,CANTINGRC,CANTINGRO,CANTSALIV,CANTSALIO,COSTO)  SELECT T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA , SUM(T.STOCKINI- T.VENTASF- T.SALAJUSTEF - T.SALTRANSFF - T.SALOTROSF + T.COMPRASF + T.INGAJUSTEF + T.INGTRANSFF + T.INGOTROSF) AS SALDOINIF, SUM(T.COMPRAS) AS COMPRAS,SUM(T.INGAJUSTE + T.INGTRANSF + T.INGOTROS) AS INGOTROS,SUM(T.VENTAS) AS VENTAS, SUM(T.SALAJUSTE + T.SALTRANSF + T.SALOTROS) As SALOTROS,AR.COSTOBAS FROM TMP_SUMKARDEX2 T   INNER  JOIN LINEA G ON T.CDG01 = G.CODLINEA  AND G.CODEMPRESA='" & codempresa & "' INNER JOIN  ARTICULO AR  ON T.CDARTI=AR.CODARTI  AND AR.CODEMPRESA='" & codempresa & "' INNER JOIN  ALMACEN A  ON  T.CDALMA = A.CODALMACEN  AND A.CODEMPRESA='" & codempresa & "' GROUP BY T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA,AR.COSTOBAS")

        'TmpInsertDatos("SP_INS_KARDEX_TMPXARTI '" & codempresa & "','" & rand & "','" & CadenaCateg & "'")
        TmpInsertDatos("SP_INS_KARDEX_TMP '" & codempresa & "','" & rand & "'")

    End Sub



    Private Function VERIFICA_HISTORICOVENT(ByVal StrHistorico As String) As Boolean
        Try
            Dim StrSql As String
            Dim rs As New DataTable
            StrSql = " EXEC   VERIFICA_HISTORICOVENT    '" & StrHistorico & "','" & codempresa & "'"
            rs = TmpListarDatos(StrSql)

            If rs.Rows.Count = 0 Then
                VERIFICA_HISTORICOVENT = False
            Else
                VERIFICA_HISTORICOVENT = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " VERIFICA_HISTORICOVENT")
        End Try

    End Function

    Private Sub INSERTCIERREALDIA(ByVal FechaCierre As Date, ByVal ALMACEN As String)

        TmpInsertDatos(" INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS ) " &
                         " SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,Cierre_Inv_protisa.ARTICULO,Cierre_Inv_protisa.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0  " &
                         "FROM Cierre_Inv_protisa INNER JOIN ARTICULO ON Cierre_Inv_protisa.ARTICULO=ARTICULO.CODARTI " &
                         "WHERE  ARTICULO.FORMU = 0 AND Cierre_Inv_protisa.ALMACEN ='" & Trim(ALMACEN) & "'  AND FECHA='" & Format(FechaCierre, "dd/MM/yyyy") & "'")

    End Sub


    Private Sub FrmTranferirProtisa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValorRan()


        Dim dt2 As New DataTable

        dt2 = CAyuda.ListarDatos("SELEC_CIERRE_MES", codempresa).Tables(0)
        Dim AÑO As String
        Dim MES As String
        AÑO = dt2.Rows(0)(0)
        MES = dt2.Rows(0)(1)

        Dim Fecharf As Date

        Dim Table_Correlativo2 As DataTable
        Table_Correlativo2 = CAyuda.ListarDatos("SP_EXTRADIA", AÑO, MES).Tables(0)
        DtFechaInicial.Value = CDate(Table_Correlativo2.Rows(0)(0).ToString)

        Fecharf = DateAdd("d", +1, DtFechaInicial.Value)

        DtFechaInicial.Value = Fecharf

    End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim CODTIPODOC As String
        Dim NRODOC As String
        Dim ITEM As String

        NRODOC = grid1.Item(grid1.CurrentRowIndex, 1)
        CODTIPODOC = grid1.Item(grid1.CurrentRowIndex, 2)
        ITEM = grid1.Item(grid1.CurrentRowIndex, 5)

        If CAyuda.Ejecutar("SP_DELETE_TMP_VENTAS", NRODOC, CODTIPODOC, ITEM) > 0 Then

        End If

        TABLE_ORDENDESPACHO = TmpListarDatos("SP_SELECT_VENTAS  '" & codempresa & "'")
        grid1.DataSource = TABLE_ORDENDESPACHO

    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim FrmOpciones As New FrmAgregarVentas
        FrmOpciones.fecha = Format(CDate(DtFechaIni.Value), "dd/MM/yyyy")
        FrmOpciones.ShowDialog()

        If FrmOpciones.DEVOLVER = True Then
            TABLE_ORDENDESPACHO = TmpListarDatos("SP_SELECT_VENTAS  '" & codempresa & "'")
            grid1.DataSource = TABLE_ORDENDESPACHO
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim o As New FrmBusquedaDeOrdenDespacho7
        o.TIPO = "F"
        o.ShowDialog()
        If o.DEVOLVER = False Then
            Exit Sub
        End If
        FECHA_1 = o.GridOrdenDesp.Item(o.GridOrdenDesp.CurrentRowIndex, 0)

        TABLE_ORDENDESPACHO = TmpListarDatos("SP_SELECT_VENTATRANSFERIDOS  '" & FECHA_1 & "'")
        grid1.DataSource = TABLE_ORDENDESPACHO



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        TABLE_ORDENDESPACHO = TmpListarDatos("SP_SELECT_VENTATRANSFERIDOS  '10/05/2010'")
        grid1.DataSource = TABLE_ORDENDESPACHO


    End Sub


    Function ARMA_CADENA(Cadena As String, LONGITUD As Integer) As String
        Dim LONG_FALTA As Integer
        Dim BLANCOS As String
        BLANCOS = Space(150)
        If Len(Trim(Cadena)) < LONGITUD Then
            LONG_FALTA = LONGITUD - Len(Trim(Cadena))
            ARMA_CADENA = Trim(Cadena) & Mid(BLANCOS, 1, LONG_FALTA)
        Else
            ARMA_CADENA = Mid(Trim(Cadena), 1, LONGITUD)
        End If
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Generar_archivos()
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim frm As New FrmDocAnulados()
        frm.codlinea = "002"
        frm.Show()
    End Sub

    Sub Generar_archivos()

        Dim CodigoDistribuidor As String
        Dim CodigoCliente As String
        Dim NombreCliente As String
        Dim RUC As String
        Dim DNI As String
        Dim Giro As String
        Dim TipoNegocio As String
        Dim Zona As String
        Dim Modulo As String
        Dim Distrito As String
        Dim CodigoVendedor As String
        Dim DiaVisita As String
        Dim Status As String
        Dim CodCorporativo As String
        Dim Mercado As String


        Dim Codfecha As String
        Codfecha = Format(DtFechaIni.Value, "dd/MM/yyyy")


        Dim Table_SelectProd As DataTable
        Dim TEXTO As String = String.Empty
        Table_SelectProd = CAyuda.ListarDatos("SP_SELECT_HISTOCLIENTE", Codfecha).Tables(0)

        Dim Nombre1 As String
        Dim CodigoDistribuidora As String
        Dim InfoAcumulada As String
        Dim Año As String
        Dim Mes As String
        Dim Dia As String
        Dim NombreFinal As String

        Nombre1 = "KIMBERLYPE"
        CodigoDistribuidora = "210143"
        InfoAcumulada = "6"
        Año = Format(CDate(DtFechaIni.Value), "yyyy")
        Mes = Format(CDate(DtFechaIni.Value), "MM")
        Dia = Format(CDate(DtFechaIni.Value), "dd")

        NombreFinal = Nombre1 & "_" & CodigoDistribuidora + "_" & Año & InfoAcumulada & Mes & Dia

        Dim Direc As String
        ''Direc = Application.StartupPath

        Direc = "d:\iv.validata\data"
        'My.Computer.FileSystem.CreateDirectory(Direc)

        ''My.Computer.FileSystem.CreateDirectory(Direc & "\" & NombreFinal)
        Dim path As String
        ''path = (Direc & "\" & NombreFinal)
        path = Direc
        Dim fs1 As FileStream = File.Create(path & "\" & "clientes.csv")
        fs1.Close()

        Dim objStreamWriter1 As StreamWriter
        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter1 = New StreamWriter(path & "\" & "clientes.csv")
        objStreamWriter1.Flush()
        'objStreamWriter1.WriteLine("CodigoDistribuidor|CodigoCliente|NombreCliente|RUC|DNI|Giro|TipoNegocio|Zona|Modulo|Distrito|CodigoVendedor|DiaVisita|Status|CodCorporativo|Mercado")
        ''objStreamWriter1.WriteLine("CodigoDistribuidor|CodigoCliente|NombreCliente|RUC|DNI|Giro|TipoNegocio|Zona|Modulo|Distrito|CodigoVendedor|DiaVisita|Status|CodCorporativo|Mercado")

        If Table_SelectProd.Rows.Count > 0 Then
            For i As Integer = 0 To Table_SelectProd.Rows.Count - 1
                CodigoDistribuidor = "HUACHO.01.121314"
                CodigoCliente = Table_SelectProd.Rows(i)("CodigoCliente").ToString()
                NombreCliente = Table_SelectProd.Rows(i)("NombreCliente").ToString()
                RUC = Table_SelectProd.Rows(i)("RUC").ToString()
                DNI = Table_SelectProd.Rows(i)("DNI").ToString()
                Giro = Table_SelectProd.Rows(i)("Giro").ToString()
                TipoNegocio = Table_SelectProd.Rows(i)("TipoNegocio").ToString()
                Zona = Table_SelectProd.Rows(i)("Zona").ToString()
                Modulo = Table_SelectProd.Rows(i)("Modulo").ToString()
                Distrito = Table_SelectProd.Rows(i)("Distrito").ToString()
                CodigoVendedor = Table_SelectProd.Rows(i)("CodigoVendedor").ToString()
                DiaVisita = Table_SelectProd.Rows(i)("DiaVisita").ToString()
                Status = Table_SelectProd.Rows(i)("Status").ToString()
                CodCorporativo = Table_SelectProd.Rows(i)("CodCorporativo").ToString()
                Mercado = Table_SelectProd.Rows(i)("Mercado").ToString()

                TEXTO = "" & ARMA_CADENA(CodigoDistribuidor, 30) & "|" & ARMA_CADENA(CodigoCliente, 10) & "|" & ARMA_CADENA(NombreCliente, 100) & "|" & ARMA_CADENA(RUC, 20) & "|" & ARMA_CADENA(DNI, 20) & "|" & ARMA_CADENA(Giro, 30) & "|" & ARMA_CADENA(TipoNegocio, 40) & "|" & ARMA_CADENA(Zona, 20) & "|" & ARMA_CADENA(Modulo, 8) & "|" & ARMA_CADENA(Distrito, 50) & "|" & ARMA_CADENA(CodigoVendedor, 10) & "|" & ARMA_CADENA(DiaVisita, 20) & "|" & ARMA_CADENA(Status, 30) & "|" & ARMA_CADENA(CodCorporativo, 150) & "|" & ARMA_CADENA(Mercado, 150)

                objStreamWriter1.WriteLine(TEXTO)
            Next
        End If
        objStreamWriter1.Close()


        Dim CodigoProducto As String
        Dim NombreProducto As String
        Dim Proveedor As String
        Dim Grupo As String
        Dim SubGrupo1 As String
        Dim SubGrupo2 As String
        Dim SubGrupo3 As String
        Dim SubGrupo4 As String
        Dim SubGrupo5 As String
        Dim Peso As String
        Dim PrecioCompra As String
        Dim PrecioSugerido As String
        Dim PrecioPromedio As String

        Dim objStreamWriter2 As StreamWriter
        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter2 = New StreamWriter(path & "\" & "productos.csv")
        objStreamWriter2.Flush()
        ''objStreamWriter2.WriteLine("CodigoDistribuidor|CodigoProducto|NombreProducto|Proveedor|Grupo|SubGrupo1|SubGrupo2|SubGrupo3|SubGrupo4|SubGrupo5|Peso|PrecioCompra|PrecioSugerido|PrecioPromedio")

        Table_SelectProd = CAyuda.ListarDatos("SP_SELECT_HISTOPRODUCTOS", Codfecha).Tables(0)

        If Table_SelectProd.Rows.Count > 0 Then
            For i As Integer = 0 To Table_SelectProd.Rows.Count - 1
                CodigoDistribuidor = "HUACHO.01.121314"
                CodigoProducto = Table_SelectProd.Rows(i)("CodigoProducto").ToString()
                NombreProducto = Table_SelectProd.Rows(i)("NombreProducto").ToString()
                Proveedor = Table_SelectProd.Rows(i)("Proveedor").ToString()
                Grupo = Table_SelectProd.Rows(i)("Grupo").ToString()
                SubGrupo1 = Table_SelectProd.Rows(i)("SubGrupo1").ToString()
                SubGrupo2 = Table_SelectProd.Rows(i)("SubGrupo2").ToString()
                SubGrupo3 = Table_SelectProd.Rows(i)("SubGrupo3").ToString()
                SubGrupo4 = Table_SelectProd.Rows(i)("SubGrupo4").ToString()
                SubGrupo5 = Table_SelectProd.Rows(i)("SubGrupo5").ToString()
                Peso = Table_SelectProd.Rows(i)("Peso").ToString()
                PrecioCompra = Table_SelectProd.Rows(i)("PrecioCompra").ToString()
                PrecioSugerido = Table_SelectProd.Rows(i)("PrecioSugerido").ToString()
                PrecioPromedio = Table_SelectProd.Rows(i)("PrecioPromedio").ToString()
                TEXTO = "" & ARMA_CADENA(CodigoDistribuidor, 30) & "|" & ARMA_CADENA(CodigoProducto, 10) & "|" & ARMA_CADENA(NombreProducto, 100) & "|" & ARMA_CADENA(Proveedor, 50) & "|" & ARMA_CADENA(Grupo, 25) & "|" & ARMA_CADENA(SubGrupo1, 25) & "|" & ARMA_CADENA(SubGrupo2, 25) & "|" & ARMA_CADENA(SubGrupo3, 25) & "|" & ARMA_CADENA(SubGrupo4, 25) & "|" & ARMA_CADENA(SubGrupo5, 25) & "|" & Peso & "|" & PrecioCompra & "|" & PrecioSugerido & "|" & PrecioPromedio
                objStreamWriter2.WriteLine(TEXTO)
            Next
        End If
        objStreamWriter2.Close()

        Dim NombreVendedor As String
        Dim Exclusivo As String
        Dim VendedorPadre As String
        Dim CodigoSupervisor As String
        Dim CodigoMesa As String

        Dim objStreamWriter3 As StreamWriter
        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter3 = New StreamWriter(path & "\" & "vendedores.csv")
        objStreamWriter3.Flush()
        ''objStreamWriter3.WriteLine("CodigoDistribuidor|CodigoVendedor|NombreVendedor|Exclusivo|VendedorPadre|CodigoSupervisor|CodigoMesa")

        Table_SelectProd = CAyuda.ListarDatos("SP_SELECT_VENDEDORES", "01").Tables(0)

        If Table_SelectProd.Rows.Count > 0 Then
            For i As Integer = 0 To Table_SelectProd.Rows.Count - 1
                CodigoDistribuidor = "HUACHO.01.121314"
                CodigoVendedor = Table_SelectProd.Rows(i)("CodigoVendedor").ToString()
                NombreVendedor = Table_SelectProd.Rows(i)("NombreVendedor").ToString()
                Exclusivo = Table_SelectProd.Rows(i)("Exclusivo").ToString()
                VendedorPadre = Table_SelectProd.Rows(i)("VendedorPadre").ToString()
                CodigoSupervisor = Table_SelectProd.Rows(i)("CodigoSupervisor").ToString()
                CodigoMesa = Table_SelectProd.Rows(i)("CodigoMesa").ToString()

                TEXTO = "" & ARMA_CADENA(CodigoDistribuidor, 30) & "|" & ARMA_CADENA(CodigoVendedor, 10) & "|" & ARMA_CADENA(NombreVendedor, 100) & "|" & ARMA_CADENA(Exclusivo, 10) & "|" & ARMA_CADENA(VendedorPadre, 10) & "|" & ARMA_CADENA(CodigoSupervisor, 10) & "|" & ARMA_CADENA(CodigoMesa, 10)

                objStreamWriter3.WriteLine(TEXTO)
            Next
        End If
        objStreamWriter3.Close()


        Dim VentasID As String
        Dim NroFactura As String
        Dim Fecha As String
        Dim NumeroItem As String
        Dim Cantidad As String
        Dim PrecioSinIGV As String
        Dim PrecioTotal As String
        Dim Descuento As String
        Dim IndicCombo As String
        Dim CodCombo As String
        Dim CodigoPromocion As String
        Dim CantidadDevuelta As String

        Dim objStreamWriter4 As StreamWriter
        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter4 = New StreamWriter(path & "\" & "ventas.csv")
        objStreamWriter4.Flush()
        ''objStreamWriter4.WriteLine("CodigoDistribuidor| VentasID| NroFactura| Fecha| CodigoCliente| NumeroItem| CodigoProducto| Cantidad| PrecioSinIGV| PrecioTotal| Descuento| IndicCombo| CodCombo| CodigoPromocion| CodigoVendedor| CantidadDevuelta")

        Table_SelectProd = CAyuda.ListarDatos("SP_SELECT_HISTOVENTAS", "01").Tables(0)

        If Table_SelectProd.Rows.Count > 0 Then
            For i As Integer = 0 To Table_SelectProd.Rows.Count - 1
                CodigoDistribuidor = "HUACHO.01.121314"
                VentasID = Table_SelectProd.Rows(i)("VentasID").ToString()
                NroFactura = Table_SelectProd.Rows(i)("NroFactura").ToString()
                Fecha = Table_SelectProd.Rows(i)("Fecha").ToString()
                CodigoCliente = Table_SelectProd.Rows(i)("CodigoCliente").ToString()
                NumeroItem = Table_SelectProd.Rows(i)("NumeroItem").ToString()
                CodigoProducto = Table_SelectProd.Rows(i)("CodigoProducto").ToString()
                Cantidad = Table_SelectProd.Rows(i)("Cantidad").ToString()
                PrecioSinIGV = Table_SelectProd.Rows(i)("PrecioSinIGV").ToString()
                PrecioTotal = Table_SelectProd.Rows(i)("PrecioTotal").ToString()
                Descuento = Table_SelectProd.Rows(i)("Descuento").ToString()
                IndicCombo = Table_SelectProd.Rows(i)("IndicCombo").ToString()
                CodCombo = Table_SelectProd.Rows(i)("CodCombo").ToString()
                CodigoPromocion = Table_SelectProd.Rows(i)("CodigoPromocion").ToString()
                CodigoVendedor = Table_SelectProd.Rows(i)("CodigoVendedor").ToString()
                CantidadDevuelta = Table_SelectProd.Rows(i)("CantidadDevuelta").ToString()

                TEXTO = "" & ARMA_CADENA(CodigoDistribuidor, 30) & "|" & ARMA_CADENA(VentasID, 10) & "|" & ARMA_CADENA(NroFactura, 20) & "|" & CDate(Fecha).ToString("yyyy-MM-dd") & "|" & ARMA_CADENA(CodigoCliente, 20) & "|" & ARMA_CADENA(NumeroItem, 5) & "|" & ARMA_CADENA(CodigoProducto, 10) & "|" & Cantidad & "|" & PrecioSinIGV & "|" & PrecioTotal & "|" & Descuento & "|" & ARMA_CADENA(IndicCombo, 1) & "|" & ARMA_CADENA(CodCombo, 10) & "|" & ARMA_CADENA(CodigoPromocion, 10) & "|" & ARMA_CADENA(CodigoVendedor, 10) & "|" & CantidadDevuelta

                objStreamWriter4.WriteLine(TEXTO)
            Next
        End If
        objStreamWriter4.Close()


        Dim CodigoAlmacen As String
        Dim NombreAlmacen As String
        Dim CodigoProveedor As String
        Dim StockEnUnidadDeConsumo As String
        Dim UnidadDeMedidaDeConsumo As String
        Dim StockEnUnidadDeCompra As String
        Dim UnidadDeMedidadDeCompra As String

        Dim objStreamWriter5 As StreamWriter
        objStreamWriter5 = New StreamWriter(path & "\" & "stock.csv")
        objStreamWriter5.Flush()
        ''objStreamWriter5.WriteLine("CodigoDistribuidor| CodigoAlmacen| NombreAlmacen| CodigoProveedor| Proveedor| CodigoProducto| StockEnUnidadDeConsumo| UnidadDeMedidaDeConsumo| StockEnUnidadDeCompra| UnidadDeMedidadDeCompra| Fecha")

        Table_SelectProd = CAyuda.ListarDatos("sp_select_HistoStock", Codfecha).Tables(0)

        If Table_SelectProd.Rows.Count > 0 Then
            For i As Integer = 0 To Table_SelectProd.Rows.Count - 1
                CodigoDistribuidor = "HUACHO.01.121314"
                CodigoAlmacen = Table_SelectProd.Rows(i)("CodigoAlmacen").ToString()
                NombreAlmacen = Table_SelectProd.Rows(i)("NombreAlmacen").ToString()
                CodigoProveedor = Table_SelectProd.Rows(i)("CodigoProveedor").ToString()
                Proveedor = Table_SelectProd.Rows(i)("Proveedor").ToString()
                CodigoProducto = Table_SelectProd.Rows(i)("CodigoProducto").ToString()
                StockEnUnidadDeConsumo = Table_SelectProd.Rows(i)("StockEnUnidadDeConsumo").ToString()
                UnidadDeMedidaDeConsumo = Table_SelectProd.Rows(i)("UnidadDeMedidaDeConsumo").ToString()
                StockEnUnidadDeCompra = Table_SelectProd.Rows(i)("StockEnUnidadDeCompra").ToString()
                UnidadDeMedidadDeCompra = Table_SelectProd.Rows(i)("UnidadDeMedidadDeCompra").ToString()


                TEXTO = "" & ARMA_CADENA(CodigoDistribuidor, 30) & "|" & ARMA_CADENA(CodigoAlmacen, 10) & "|" & ARMA_CADENA(NombreAlmacen, 100) & "|" & ARMA_CADENA(CodigoProveedor, 20) & "|" & ARMA_CADENA(Proveedor, 100) & "|" & ARMA_CADENA(CodigoProducto, 10) & "|" & StockEnUnidadDeConsumo & "|" & ARMA_CADENA(UnidadDeMedidaDeConsumo, 10) & "|" & StockEnUnidadDeCompra & "|" & ARMA_CADENA(UnidadDeMedidadDeCompra, 10)

                objStreamWriter5.WriteLine(TEXTO)
            Next
        End If
        objStreamWriter5.Close()

        Dim DevolucionID As String
        Dim CodigoMotivo As String
        Dim Monto As String
        Dim MontoTotal As String

        Dim objStreamWriter6 As StreamWriter
        objStreamWriter6 = New StreamWriter(path & "\" & "devoluciones.csv")
        objStreamWriter6.Flush()
        ''objStreamWriter6.WriteLine("CodigoDistribuidor| DevolucionID| NroFactura| Fecha| CodigoCliente| NumeroItem| CodigoProducto| Cantidad| CodigoMotivo| Monto| MontoTotal| CodigoVendedor")

        Table_SelectProd = CAyuda.ListarDatos("sp_select_Devoluciones", "01").Tables(0)

        If Table_SelectProd.Rows.Count > 0 Then
            For i As Integer = 0 To Table_SelectProd.Rows.Count - 1
                CodigoDistribuidor = "HUACHO.01.121314"
                DevolucionID = Table_SelectProd.Rows(i)("DevolucionID").ToString()
                NroFactura = Table_SelectProd.Rows(i)("NroFactura").ToString()
                Fecha = Table_SelectProd.Rows(i)("Fecha").ToString()
                CodigoCliente = Table_SelectProd.Rows(i)("CodigoCliente").ToString()
                NumeroItem = Table_SelectProd.Rows(i)("NumeroItem").ToString()
                CodigoProducto = Table_SelectProd.Rows(i)("CodigoProducto").ToString()
                Cantidad = Table_SelectProd.Rows(i)("Cantidad").ToString()
                CodigoMotivo = Table_SelectProd.Rows(i)("CodigoMotivo").ToString()
                Monto = Table_SelectProd.Rows(i)("Monto").ToString()
                MontoTotal = Table_SelectProd.Rows(i)("MontoTotal").ToString()
                CodigoVendedor = Table_SelectProd.Rows(i)("CodigoVendedor").ToString()
                TEXTO = "" & ARMA_CADENA(CodigoDistribuidor, 30) & "|" & ARMA_CADENA(DevolucionID, 10) & "|" & ARMA_CADENA(NroFactura, 20) & "|" & CDate(Fecha).ToString("yyyy-MM-dd") & "|" & ARMA_CADENA(CodigoCliente, 20) & "|" & ARMA_CADENA(NumeroItem, 5) & "|" & ARMA_CADENA(CodigoProducto, 10) & "|" & Cantidad & "|" & ARMA_CADENA(CodigoMotivo, 3) & "|" & Monto & "|" & MontoTotal & "|" & ARMA_CADENA(CodigoVendedor, 10)

                objStreamWriter6.WriteLine(TEXTO)
            Next
        End If
        objStreamWriter6.Close()

        Dim DescripcionMotivo As String

        Dim objStreamWriter7 As StreamWriter
        objStreamWriter7 = New StreamWriter(path & "\" & "motivodevolucion.csv")
        objStreamWriter7.Flush()
        ''objStreamWriter7.WriteLine("CodigoDistribuidor|CodigoMotivo|DescripcionMotivo")

        Table_SelectProd = CAyuda.ListarDatos("sp_select_MotivoDevolucion", Codfecha).Tables(0)

        If Table_SelectProd.Rows.Count > 0 Then
            For i As Integer = 0 To Table_SelectProd.Rows.Count - 1
                CodigoDistribuidor = "HUACHO.01.121314"
                CodigoMotivo = Table_SelectProd.Rows(i)("CodigoMotivo").ToString()
                DescripcionMotivo = Table_SelectProd.Rows(i)("DescripcionMotivo").ToString()

                TEXTO = "" & ARMA_CADENA(CodigoDistribuidor, 30) & "|" & ARMA_CADENA(CodigoMotivo, 3) & "|" & ARMA_CADENA(DescripcionMotivo, 50)

                objStreamWriter7.WriteLine(TEXTO)
            Next
        End If
        objStreamWriter7.Close()




        Dim FechaDoc As String
        Dim TipoPago As String
        Dim NomTipoPago As String
        Dim Montopagado As String
        Dim FechaVencimiento As String
        Dim EsAnulador As String


        Dim objStreamWriter8 As StreamWriter
        objStreamWriter8 = New StreamWriter(path & "\" & "morosidad.csv")
        objStreamWriter8.Flush()
        ''objStreamWriter8.WriteLine("CodigoDistribuidor| NroFactura| FechaDoc| CodigoCliente| TipoPago| NomTipoPago| Montopagado| MontoTotal| FechaVencimiento| CodigoVendedor| EsAnulador| Fecha")

        Table_SelectProd = CAyuda.ListarDatos("sp_select_HistoMorosidad", Codfecha).Tables(0)

        If Table_SelectProd.Rows.Count > 0 Then
            For i As Integer = 0 To Table_SelectProd.Rows.Count - 1
                CodigoDistribuidor = "HUACHO.01.121314"
                NroFactura = Table_SelectProd.Rows(i)("NroFactura").ToString()
                FechaDoc = Table_SelectProd.Rows(i)("FechaDoc").ToString()
                CodigoCliente = Table_SelectProd.Rows(i)("CodigoCliente").ToString()
                TipoPago = Table_SelectProd.Rows(i)("TipoPago").ToString()
                NomTipoPago = Table_SelectProd.Rows(i)("NomTipoPago").ToString()
                Montopagado = Table_SelectProd.Rows(i)("Montopagado").ToString()
                MontoTotal = Table_SelectProd.Rows(i)("MontoTotal").ToString()
                FechaVencimiento = Table_SelectProd.Rows(i)("FechaVencimiento").ToString()
                CodigoVendedor = Table_SelectProd.Rows(i)("CodigoVendedor").ToString()
                EsAnulador = Table_SelectProd.Rows(i)("EsAnulador").ToString()
                Fecha = Table_SelectProd.Rows(i)("Fecha").ToString()


                TEXTO = "" & ARMA_CADENA(CodigoDistribuidor, 30) & "|" & ARMA_CADENA(NroFactura, 20) & "|" & FechaDoc & "|" & ARMA_CADENA(CodigoCliente, 20) & "|" & ARMA_CADENA(TipoPago, 5) & "|" & ARMA_CADENA(NomTipoPago, 20) & "|" & Montopagado & "|" & MontoTotal & "|" & FechaVencimiento & "|" & ARMA_CADENA(CodigoVendedor, 10) & "|" & ARMA_CADENA(EsAnulador, 50) & "|" & CDate(Fecha).ToString("yyyy-MM-dd")
                objStreamWriter8.WriteLine(TEXTO)
            Next
        End If
        objStreamWriter8.Close()




        Dim dir As String
        dir = "d:\iv.validata\data"

        Dim startPath As String = dir
        Dim zipPath As String = dir & ".zip"

        System.IO.File.Delete(zipPath)
        Compression.ZipFile.CreateFromDirectory(startPath, zipPath)


    End Sub




End Class