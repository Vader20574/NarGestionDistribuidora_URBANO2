Public Class frmEstadoInv7

    Dim lista1 As New List(Of Items)
    Dim lista2 As New List(Of Items)

    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""
    Dim Todo_Cate As Int16


    Dim almacen1 As String

    Dim rand As Integer


    Private Sub frmEstadoInv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ValorRan()

        Dim il As New List(Of Items)
        il.Add(New Items(0, "LINEA"))
        il.Add(New Items(1, "SUB-LINEA"))
        il.Add(New Items(2, "PROVEEDOR"))


        Me.cmblista.DataSource = il
        cmblista.DisplayMember = "CADENA"
        cmblista.ValueMember = "CODIGO"

        Dim dt As New DataTable
        dt = TmpListarDatos("select codalmacen,desalmacen from almacen where codempresa='01'")
        For Each dr As DataRow In dt.Rows
            ItemsBindingSource2.Add(New Items(dr.Item(0), dr.Item(1)))
        Next

        ItemsBindingSource1.DataSource = lista2
        ItemsBindingSource.DataSource = lista1




        'Dim date1 As String
        'Dim date2 As String

        'date1 = Date.Now.AddDays(-1)
        'date2 = Date.Now


        DtFechaIni.Value = Date.Now.AddDays(-1)
        DtFechaFin.Value = Date.Now


        Dim dt2 As New DataTable

        dt2 = CAyuda.ListarDatos("SELEC_CIERRE_MES", codempresa).Tables(0)
        Dim AÑO As String
        Dim MES As String
        AÑO = dt2.Rows(0)(0)
        MES = dt2.Rows(0)(1)


        Dim Fecharf As Date

        Dim Table_Correlativo2 As DataTable
        Table_Correlativo2 = CAyuda.ListarDatos("SP_EXTRADIA", AÑO, MES).Tables(0)
        DtFechaIni.Value = CDate(Table_Correlativo2.Rows(0)(0).ToString)


        Fecharf = DateAdd("d", +1, DtFechaIni.Value)

        DtFechaIni.Value = Fecharf



    End Sub




    'Sub Procesar_Saldo(ByVal fechaCierre As String)
    '    Dim meses As Integer
    '    Dim Fecinicial, Fecfinal As String
    '    Dim MesAct, Anio As String
    '    Dim VentaC, VentD, MoviD, MoviC As String

    '    TmpInsertDatos("Delete from TMp_kardex")


    '    If CierreIgual = True Then
    '        Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
    '        Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")
    '        TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0")

    '        meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

    '        ''SELECCIONO LAS VENTAS
    '        For i As Integer = 0 To meses
    '            MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
    '            Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
    '            VentaC = "VENTC" & Anio & MesAct
    '            VentD = "VENTD" & Anio & MesAct
    '            MoviD = "MOVID" & Anio & MesAct
    '            MoviC = "MOVIC" & Anio & MesAct

    '            If VERIFICA_HISTORICOVENT(VentaC) = True Then
    '                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & MoviC & "','" & codempresa & "'").Rows.Count <> 0 Then
    '                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1")
    '                End If
    '                TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "'")
    '            End If
    '        Next

    '    Else

    '        meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
    '        ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
    '        Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
    '        Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

    '        TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0")

    '        ''SELECCIONO LAS VENTAS
    '        For i As Integer = 0 To meses
    '            MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
    '            Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
    '            VentaC = "VENTC" & Anio & MesAct
    '            VentD = "VENTD" & Anio & MesAct
    '            MoviD = "MOVID" & Anio & MesAct
    '            MoviC = "MOVIC" & Anio & MesAct


    '            If VERIFICA_HISTORICOVENT(VentaC) = True Then
    '                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & MoviC & "','" & codempresa & "'").Rows.Count <> 0 Then
    '                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1")
    '                End If
    '                TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTAS '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "'")
    '            End If
    '        Next


    '        ''SELECCIONO LOS INGRESOS Y SALIDAS DEL RANGO DEL KARDEX
    '        MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
    '        MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy")

    '        Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
    '        Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")


    '        TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0")
    '        '' SELECCIONO LAS VENTAS
    '        meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

    '        ''Registros del Histórico
    '        For i As Integer = 0 To meses
    '            MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
    '            Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
    '            VentD = "VENTD" & Anio & MesAct
    '            VentaC = "VENTC" & Anio & MesAct
    '            MoviD = "MOVID" & Anio & MesAct
    '            MoviC = "MOVIC" & Anio & MesAct

    '            If VERIFICA_HISTORICOVENT(VentaC) = True Then
    '                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & MoviC & "','" & codempresa & "'").Rows.Count <> 0 Then
    '                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1")
    '                End If
    '                TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" &almacen1& "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "'")
    '            End If
    '        Next
    '    End If

    '    'TmpInsertDatos("UPDATE TMp_kardex SET SALDOFIN=0,COMPRASF=0,INGAJUSTEF=0,INGTRANSFF=0,INGOTROSF=0,VENTASF=0,SALAJUSTEF=0,SALTRANSFF=0,SALOTROSF=0,SALDOFINF=0 WHERE SALDOFIN IS NULL AND CODEMPRESA='" & codempresa & "'")

    '    If CierreIgual = True Then
    '        INSERTCIERREALDIA(MstrFechaFinRec)
    '        MstrFechaIni = Format(Me.DtFechaIni.Value, "dd/MM/yyyy")
    '    Else
    '        'INSERTO SALDO INICIAL
    '        INSERTCIERREALDIA(fechaCierre)
    '    End If


    '    TmpInsertDatos("DELETE FROM TMP_SUMKARDEX2")
    '    TmpInsertDatos("INSERT INTO TMP_SUMKARDEX2 (CDALMA,CDG01,CDARTI,STOCKINI,STOCKREC,COMPRAS,INGAJUSTE,INGTRANSF, INGOTROS,VENTAS,SALAJUSTE,SALTRANSF,SALOTROS,SALDOFIN, COMPRASF,INGAJUSTEF,INGTRANSFF, INGOTROSF,VENTASF,SALAJUSTEF,SALTRANSFF,SALOTROSF,SALDOFINF) select cdalma,cdg01,cdarti,sum(stockini) as stockini,0 as stockrec,sum(compras)as compras, sum(INGAJUSTE) as IngAjuste,sum(INGTRANSF) as INGTransf,sum(INGOTROS) as INGotros, sum(VENTAS) as Ventas,sum(SALAJUSTE)as Salajuste,sum(SALTRANSF) as Saltransf, sum(sALOTROS) as Salotros,0 AS SALDOFIN, sum(comprasf)as comprasF,  sum(INGAJUSTEf) as IngAjusteF,sum(INGTRANSFF) as INGTransfF,sum(INGOTROSF) as INGotrosF, sum(VENTASF) as VentasF,sum(SALAJUSTEF)as SalajusteF,sum(SALTRANSFF) as SaltransfF, sum(SalotrosF) As SalotrosF ,0 AS SALDOFINF from TMp_kardex  group by cdalma,cdarti,CDG01")
    '    TmpInsertDatos("DELETE FROM KARDEX_TMP")
    '    'TmpInsertDatos("INSERT INTO KARDEX_TMP (CDALMA,DSALMA,CDARTI,DSARTI,CDG01,DSG01,SALDOFIN,CANTINGRC,CANTINGRO,CANTSALIV,CANTSALIO,COSTO)  SELECT T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA , SUM(T.STOCKINI- T.VENTASF- T.SALAJUSTEF - T.SALTRANSFF - T.SALOTROSF + T.COMPRASF + T.INGAJUSTEF + T.INGTRANSFF + T.INGOTROSF) AS SALDOINIF, SUM(T.COMPRAS) AS COMPRAS,SUM(T.INGAJUSTE + T.INGTRANSF + T.INGOTROS) AS INGOTROS,SUM(T.VENTAS) AS VENTAS, SUM(T.SALAJUSTE + T.SALTRANSF + T.SALOTROS) As SALOTROS,AR.COSTOBAS FROM TMP_SUMKARDEX2 T   INNER  JOIN LINEA G ON T.CDG01 = G.CODLINEA  AND G.CODEMPRESA='" & codempresa & "' INNER JOIN  ARTICULO AR  ON T.CDARTI=AR.CODARTI  AND AR.CODEMPRESA='" & codempresa & "' INNER JOIN  ALMACEN A  ON  T.CDALMA = A.CODALMACEN  AND A.CODEMPRESA='" & codempresa & "' GROUP BY T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA,AR.COSTOBAS")
    '    TmpInsertDatos("SP_INS_KARDEX_TMP '" & codempresa & "'")




    'End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function



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


    Private Sub INSERTCIERREALDIA(ByVal FechaCierre As Date)
        If Todo_Cate = 1 Then
            TmpInsertDatos("INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS )  SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,RESUKDX.CODARTI,SALDO AS STKINICIO,0,0,0,0,0,0,0,0,0  FROM RESUKDX,ARTICULO WHERE RESUKDX.CODARTI=ARTICULO.CODARTI AND ARTICULO.FORMU = 0 AND RESUKDX.ALMACEN ='" & Trim(almacen1) & "'  AND FECHA='" & FechaCierre & "'")
        Else
            TmpInsertDatos(" INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS ) " & _
                             " SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,RESUKDX.CODARTI,SALDO AS STKINICIO,0,0,0,0,0,0,0,0,0 " & _
                             " FROM RESUKDX,ARTICULO WHERE  ARTICULO.FORMU = 0  AND  RESUKDX.CODARTI=ARTICULO.CODARTI AND ARTICULO.CODLINEA IN(" & CadenaCateg & ")  AND RESUKDX.ALMACEN ='" & Trim(almacen1) & "'  AND FECHA='" & Format(FechaCierre, "dd/MM/yyyy") & "'")
        End If





    End Sub

    Sub Procesar_Saldo(ByVal fechaCierre As String)
        Dim meses As Integer
        Dim Fecinicial, Fecfinal As String
        Dim MesAct, Anio As String
        Dim VentaC, VentD, MoviD, MoviC As String

        TmpInsertDatos("Delete from TMp_kardex where correl=" & rand)


        If CierreIgual = True Then
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")
            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0,'" & rand & "'")

            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")
                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next

        Else

            'meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
            ' ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
            'Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            'Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            ''TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSALJ '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0,'" & rand & "'")

            ' ''SELECCIONO LAS VENTAS
            'For i As Integer = 0 To meses
            '    MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
            '    Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
            '    VentaC = "VENTC" & Anio & MesAct
            '    VentD = "VENTD" & Anio & MesAct
            '    MoviD = "MOVID" & Anio & MesAct
            '    MoviC = "MOVIC" & Anio & MesAct


            '    If VERIFICA_HISTORICOVENT(VentaC) = True Then
            '        If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & MoviC & "','" & codempresa & "'").Rows.Count <> 0 Then
            '            TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1,'" & rand & "'")
            '        End If

            '        TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTAS '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "','" & VentaC & "','" & rand & "'")

            '    End If
            'Next


            ''SELECCIONO LOS INGRESOS Y SALIDAS DEL RANGO DEL KARDEX
            MstrFechaIni = Format(DtFechaIni.Value, "dd/MM/yyyy")
            MstrFechaFin = Format(DtFechaFin.Value, "dd/MM/yyyy")

            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")


            TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'MOVIDET',0 ,'" & rand & "'")
            '' SELECCIONO LAS VENTAS
            meses = Val(DateDiff("m", Format(DtFechaIni.Value, "dd/MM/yyyy"), DtFechaFin.Value))

            ''Registros del Histórico
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, DtFechaIni.Value), "MM")
                Anio = Format(DateAdd("m", i, DtFechaIni.Value), "yyyy")
                VentD = "VENTD" & Anio & MesAct
                VentaC = "VENTC" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & MoviD & "',1,'" & rand & "'")

                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_SALDO_VENTAS_N '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1.ToString & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next
        End If

        'TmpInsertDatos("UPDATE TMp_kardex SET SALDOFIN=0,COMPRASF=0,INGAJUSTEF=0,INGTRANSFF=0,INGOTROSF=0,VENTASF=0,SALAJUSTEF=0,SALTRANSFF=0,SALOTROSF=0,SALDOFINF=0 WHERE SALDOFIN IS NULL AND CODEMPRESA='" & codempresa & "'")

        If CierreIgual = True Then
            INSERTCIERREALDIA(MstrFechaFinRec)
            MstrFechaIni = Format(Me.DtFechaIni.Value, "dd/MM/yyyy")
        Else
            'INSERTO SALDO INICIAL
            INSERTCIERREALDIA(fechaCierre)
        End If




        TmpInsertDatos("DELETE FROM TMP_SUMKARDEX2 WHERE CORREL = '" & rand & "'")
        TmpInsertDatos("INSERT INTO TMP_SUMKARDEX2 (CORREL,CDALMA,CDG01,CDARTI,STOCKINI,STOCKREC,COMPRAS,INGAJUSTE,INGTRANSF, INGOTROS,VENTAS,SALAJUSTE,SALTRANSF,SALOTROS,SALDOFIN, COMPRASF,INGAJUSTEF,INGTRANSFF, INGOTROSF,VENTASF,SALAJUSTEF,SALTRANSFF,SALOTROSF,SALDOFINF)" & "select  " & rand & ",cdalma,cdg01,cdarti,sum(stockini) as stockini,0 as stockrec,sum(compras)as compras, sum(INGAJUSTE) as IngAjuste,sum(INGTRANSF) as INGTransf,sum(INGOTROS) as INGotros, sum(VENTAS) as Ventas,sum(SALAJUSTE)as Salajuste,sum(SALTRANSF) as Saltransf, sum(sALOTROS) as Salotros,0 AS SALDOFIN, sum(comprasf)as comprasF,  sum(INGAJUSTEf) as IngAjusteF,sum(INGTRANSFF) as INGTransfF,sum(INGOTROSF) as INGotrosF, sum(VENTASF) as VentasF,sum(SALAJUSTEF)as SalajusteF,sum(SALTRANSFF) as SaltransfF, sum(SalotrosF) As SalotrosF ,0 AS SALDOFINF from TMp_kardex WHERE CORREL= " & rand & "  group by cdalma,cdarti,CDG01")
        TmpInsertDatos("DELETE FROM KARDEX_TMP WHERE CORREL='" & rand & "'")
        'TmpInsertDatos("INSERT INTO KARDEX_TMP (CDALMA,DSALMA,CDARTI,DSARTI,CDG01,DSG01,SALDOFIN,CANTINGRC,CANTINGRO,CANTSALIV,CANTSALIO,COSTO)  SELECT T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA , SUM(T.STOCKINI- T.VENTASF- T.SALAJUSTEF - T.SALTRANSFF - T.SALOTROSF + T.COMPRASF + T.INGAJUSTEF + T.INGTRANSFF + T.INGOTROSF) AS SALDOINIF, SUM(T.COMPRAS) AS COMPRAS,SUM(T.INGAJUSTE + T.INGTRANSF + T.INGOTROS) AS INGOTROS,SUM(T.VENTAS) AS VENTAS, SUM(T.SALAJUSTE + T.SALTRANSF + T.SALOTROS) As SALOTROS,AR.COSTOBAS FROM TMP_SUMKARDEX2 T   INNER  JOIN LINEA G ON T.CDG01 = G.CODLINEA  AND G.CODEMPRESA='" & codempresa & "' INNER JOIN  ARTICULO AR  ON T.CDARTI=AR.CODARTI  AND AR.CODEMPRESA='" & codempresa & "' INNER JOIN  ALMACEN A  ON  T.CDALMA = A.CODALMACEN  AND A.CODEMPRESA='" & codempresa & "' GROUP BY T.CDALMA ,A.DESALMACEN,T.CDARTI,AR.DESARTI,T.CDG01,G.DESLINEA,AR.COSTOBAS")
        TmpInsertDatos("SP_INS_KARDEX_TMPJ '" & codempresa & "','" & rand & "'")



    End Sub

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        Dim stralmacen As String = ""
        Dim strconsul As String = ""

        Dim linea, almacen As Integer
        Dim stk As Integer
        Dim orden As Integer

        If ItemsBindingSource1.Count = 0 Or ItemsBindingSource3.Count = 0 Then
            MsgBox("No hay items disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        linea = IIf(ItemsBindingSource.Count = 0, 1, 0)
        almacen = IIf(ItemsBindingSource2.Count = 0, 1, 0)

        Dim Sql As String

        Sql = "DELETE  FROM TMP_DISTRITO WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_LINEA  WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If


        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If




        If linea = 0 Then
            For Each var As Items In ItemsBindingSource1.List
                If strconsul.Length = 0 Then
                    strconsul = "'" & var.Codigo.Trim & "'"
                Else
                    strconsul = strconsul & ",'" & var.Codigo.Trim & "'"
                End If

                Sql = "NSP_INSERT_TMP_LINEA '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If
            Next
        End If



        CadenaCateg = ""


        For Each var As Items In ItemsBindingSource1.List
            If CadenaCateg.Length = 0 Then
                CadenaCateg = var.Codigo.Trim

            Else
                CadenaCateg = CadenaCateg & "," & var.Codigo.Trim
            End If

        Next


        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List
                If stralmacen.Length = 0 Then
                    stralmacen = "'" & var.Codigo.Trim & "'"
                    almacen1 = var.Codigo.Trim
                Else
                    stralmacen = stralmacen & ",'" & var.Codigo.Trim & "'"
                    almacen1 = almacen1 & "," & var.Codigo.Trim

                End If

                Sql = "NSP_INSERT_TMP_DISTRITO '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If
            Next
        End If


        If rbtodos.Checked Or rbstkfisico.Checked Then
            stk = 1
        Else
            stk = 0
        End If

        If rbcodigo.Checked = True Then
            orden = 0
        Else
            orden = 1
        End If

        '/*********************************************************************************************/

        Dim fechahas As String
        fechahas = Format(vFechaActual, "dd/MM/yyyy")



        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        CierreIgual = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

        dt = SelectFechCiere(Fech, False, almacen1)
        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

        Procesar_Saldo(FECHCIERRE)


        Try

            CAyuda.Ejecutar("SP_INSERT_TMP_FECHAING", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS2", codempresa, rand)

            CAyuda.Ejecutar("SP_INSERT_TMP_UTILIDAD2", codempresa, fechahas, rand)
            CAyuda.Ejecutar("sp_rpt_stock_articulo_almacen_categoria", stralmacen, almacen.ToString, strconsul.ToString, linea.ToString, cmblista.SelectedValue.ToString, orden, stk.ToString, codempresa, rand)
            With Rpt1
                If cmblista.SelectedIndex = 0 Then
                    If rbstkfisico.Checked = False Then
                        .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacen1.rpt", String)

                    Else
                        '.ReportFileName = RutaRptInv + "\Reportes\rptStockArticulosAlmacen11.rpt"
                    End If
                ElseIf cmblista.SelectedIndex = 1 Then
                    If rbstkfisico.Checked = False Then

                        .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacen2.rpt", String)
                    Else
                        '.ReportFileName = RutaRptInv + "rptStockArticulosAlmacen22.rpt"
                    End If
                Else
                    If rbstkfisico.Checked = False Then
                        .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacen3.rpt", String)
                    Else
                        '.ReportFileName = RutaRptInv + "\Reportes\rptStockArticulosAlmacen33.rpt"
                    End If
                End If



                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                .set_StoredProcParam(1, rand)
                If rbcodigo.Checked = True Then
                    .set_SortFields(0, "+{INVENTARIO.CODARTI}")
                Else
                    .set_SortFields(0, "+{INVENTARIO.DESARTI}")
                End If

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function SelectFechCiere(ByVal fecha As Date, ByVal HizoCierre As Boolean, ByVal StrAlmacen As String) As DataTable
        Dim dt As New DataTable
        If HizoCierre = True Then
            dt = TmpListarDatos("select * from resukdx where fecha='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
        Else
            dt = TmpListarDatos("SELECT max (fechA) AS FECHA from resukdx where fechA <= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
        End If

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("Fecha") Is DBNull.Value Then
                dt = TmpListarDatos("SELECT mIN (fechA) AS FECHa from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
            End If
        Else
            dt = TmpListarDatos("SELECT distinct FECHA=max(fecha) from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'   AND ALMACEN ='" & StrAlmacen & "'  group by CODARTI")
        End If

        Return dt
    End Function


    Public Class Items
        Sub New()

        End Sub
        Sub New(ByVal _codigo As String, ByVal _cadena As String)
            Codigo = _codigo
            Cadena = _cadena
        End Sub

        Private mCodigo As String
        Public Property Codigo() As String
            Get
                Return mCodigo
            End Get
            Set(ByVal value As String)
                mCodigo = value
            End Set
        End Property

        Private mCadena As String
        Public Property Cadena() As String
            Get
                Return mCadena
            End Get
            Set(ByVal value As String)
                mCadena = value
            End Set
        End Property


    End Class
    Sub CargarLista(ByVal i As Integer)

        lista1.Clear()
        lista2.Clear()
        Dim dt As New DataTable
        Select Case i
            Case 0
                dt = TmpListarDatos("SELECT CODLINEA,DESLINEA FROM LINEA WHERE CODEMPRESA='" & codempresa & "' ORDER BY DESLINEA")
            Case 1
                dt = TmpListarDatos("SELECT CODSUBLINEA,DESSUBLINEA FROM SUBLINEA WHERE CODEMPRESA='" & codempresa & "' ORDER BY DESSUBLINEA")
            Case 2
                dt = TmpListarDatos("SELECT CODPROVEEDOR,DESPROVEEDOR FROM PROVEEDOR WHERE CODEMPRESA='" & codempresa & "' ORDER BY DESPROVEEDOR")
        End Select


        For Each dr As DataRow In dt.Rows
            lista1.Add(New Items(dr.Item(0).ToString, dr.Item(1).ToString))
        Next

    End Sub

    Private Sub cmblista_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblista.SelectionChangeCommitted

    End Sub

    Private Sub btnpasde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpass.Click
        If lista1.Count = 0 Then Exit Sub

        lista2.Add(lista1.Item(lblista1.SelectedIndex))
        lista1.RemoveAt(lblista1.SelectedIndex)

        Cargar()

    End Sub

    Private Sub btnreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreg.Click
        If lista2.Count = 0 Then Exit Sub

        lista1.Add(lista2.Item(lblista2.SelectedIndex))
        lista2.RemoveAt(lblista2.SelectedIndex)

        Cargar()

    End Sub

    Private Sub btnpastodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpastodo.Click
        If lista1.Count = 0 Then Exit Sub
        lista2.AddRange(lista1)
        lista1.Clear()
        Cargar()
    End Sub

    Private Sub btnregtodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregtodo.Click
        If lista2.Count = 0 Then Exit Sub
        lista1.AddRange(lista2)
        lista2.Clear()
        Cargar()
    End Sub

    Private Sub Cargar()

        ItemsBindingSource1.ResetBindings(False)
        ItemsBindingSource.ResetBindings(False)
    End Sub

    Private Sub btnpasstodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasstodo.Click
        For Each i As Items In ItemsBindingSource2.List
            ItemsBindingSource3.Add(i)
        Next
        ItemsBindingSource2.Clear()
    End Sub

    Private Sub btnpas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpas.Click
        If ItemsBindingSource2.Current Is Nothing Then Exit Sub
        ItemsBindingSource3.Add(ItemsBindingSource2.Current)
        ItemsBindingSource2.RemoveCurrent()
    End Sub

    Private Sub btnregre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregre.Click
        If ItemsBindingSource3.Current Is Nothing Then Exit Sub
        ItemsBindingSource2.Add(ItemsBindingSource3.Current)
        ItemsBindingSource3.RemoveCurrent()
    End Sub

    Private Sub btnregretodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregretodo.Click
        For Each i As Items In ItemsBindingSource3.List
            ItemsBindingSource2.Add(i)
        Next
        ItemsBindingSource3.Clear()
    End Sub

    Private Sub cmblista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblista.SelectedIndexChanged
        If cmblista.SelectedValue Is Nothing Then Exit Sub
        Select Case CInt(cmblista.SelectedIndex)
            Case 0
                CargarLista(0)
            Case 1
                CargarLista(1)
            Case 2
                CargarLista(2)
        End Select
        Cargar()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim stralmacen As String = ""
        Dim strconsul As String = ""
        Dim linea, almacen As Integer
        Dim stk As Integer
        Dim orden As Integer
        Dim Sql As String

        Sql = "DELETE  FROM TMP_DISTRITO WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_LINEA  WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If


        If ItemsBindingSource1.Count = 0 Or ItemsBindingSource3.Count = 0 Then
            MsgBox("No hay items disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If


        linea = IIf(ItemsBindingSource.Count = 0, 1, 0)
        almacen = IIf(ItemsBindingSource2.Count = 0, 1, 0)


        If linea = 0 Then

            For Each var As Items In ItemsBindingSource1.List
                If strconsul.Length = 0 Then
                    strconsul = "'" & var.Codigo.Trim & "'"
                Else
                    strconsul = strconsul & ",'" & var.Codigo.Trim & "'"
                End If

                Sql = "NSP_INSERT_TMP_LINEA '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If

            Next
        End If

        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List
                If stralmacen.Length = 0 Then
                    stralmacen = "'" & var.Codigo.Trim & "'"
                    almacen1 = var.Codigo.Trim
                Else
                    stralmacen = stralmacen & ",'" & var.Codigo.Trim & "'"
                    almacen1 = almacen1 & "," & var.Codigo.Trim
                End If
            Next
        End If



        If rbtodos.Checked Or rbstkfisico.Checked Then
            stk = 1
        Else
            stk = 0
        End If

        If rbcodigo.Checked = True Then
            orden = 0
        Else
            orden = 1
        End If

        CadenaCateg = ""

        For Each var As Items In ItemsBindingSource1.List
            If CadenaCateg.Length = 0 Then
                CadenaCateg = var.Codigo.Trim

            Else
                CadenaCateg = CadenaCateg & "," & var.Codigo.Trim
            End If
        Next



        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        CierreIgual = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

        dt = SelectFechCiere(Fech, False, almacen1)
        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

        Procesar_Saldo(FECHCIERRE)

        Try

            CAyuda.Ejecutar("SP_INSERT_TMP_FECHAING", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS2", codempresa, rand)

            CAyuda.Ejecutar("sp_rpt_stock_articulo_almacen_categoria_1", stralmacen, almacen.ToString, strconsul.ToString, linea.ToString, cmblista.SelectedValue.ToString, orden, stk.ToString, codempresa, rand)

            With Rpt1

                .ReportFileName = RutaRptInv & CType("Reporte_Invertario2.rpt", String)

                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                'If rbcodigo.Checked = True Then
                '    .set_SortFields(0, "+{INVENTARIO.CODARTI}")
                'Else
                '    .set_SortFields(0, "+{INVENTARIO.DESARTI}")
                'End If

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim stralmacen As String = ""
        Dim strconsul As String = ""
        Dim linea, almacen As Integer
        Dim stk As Integer
        Dim orden As Integer
        Dim Sql As String

        Sql = "DELETE  FROM TMP_DISTRITO WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_LINEA  WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If



        If ItemsBindingSource1.Count = 0 Or ItemsBindingSource3.Count = 0 Then
            MsgBox("No hay items disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        linea = IIf(ItemsBindingSource.Count = 0, 1, 0)
        almacen = IIf(ItemsBindingSource2.Count = 0, 1, 0)

        If linea = 0 Then
            For Each var As Items In ItemsBindingSource1.List
                If strconsul.Length = 0 Then
                    strconsul = "'" & var.Codigo.Trim & "'"
                Else
                    strconsul = strconsul & ",'" & var.Codigo.Trim & "'"
                End If

                Sql = "NSP_INSERT_TMP_LINEA '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If

            Next
        End If




        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List
                If stralmacen.Length = 0 Then
                    stralmacen = "'" & var.Codigo.Trim & "'"
                    almacen1 = var.Codigo.Trim
                Else
                    stralmacen = stralmacen & ",'" & var.Codigo.Trim & "'"
                    almacen1 = almacen1 & "," & var.Codigo.Trim

                End If
            Next
        End If


        If rbtodos.Checked Or rbstkfisico.Checked Then
            stk = 1
        Else
            stk = 0
        End If

        If rbcodigo.Checked = True Then
            orden = 0
        Else
            orden = 1
        End If


        CadenaCateg = ""


        For Each var As Items In ItemsBindingSource1.List
            If CadenaCateg.Length = 0 Then
                CadenaCateg = var.Codigo.Trim

            Else
                CadenaCateg = CadenaCateg & "," & var.Codigo.Trim
            End If
        Next

        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        CierreIgual = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

        dt = SelectFechCiere(Fech, False, almacen1)
        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

        Procesar_Saldo(FECHCIERRE)


        Try

            CAyuda.Ejecutar("SP_INSERT_TMP_FECHAING", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS2", codempresa, rand)


            CAyuda.Ejecutar("sp_rpt_stock_articulo_almacen_categoria_3", stralmacen, almacen.ToString, strconsul.ToString, linea.ToString, cmblista.SelectedValue.ToString, orden, stk.ToString, codempresa, rand)
            With Rpt1
                .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacen_stk.rpt", String)



                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                If rbcodigo.Checked = True Then
                    .set_SortFields(0, "+{INVENTARIO.CODARTI}")
                Else
                    .set_SortFields(0, "+{INVENTARIO.DESARTI}")
                End If

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        Dim stralmacen As String = ""
        Dim strconsul As String = ""
        Dim linea, almacen As Integer
        Dim stk As Integer
        Dim orden As Integer

        If ItemsBindingSource1.Count = 0 Or ItemsBindingSource3.Count = 0 Then
            MsgBox("No hay items disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        'linea = IIf(ItemsBindingSource.Count = 0, 1, 0)
        'almacen = IIf(ItemsBindingSource2.Count = 0, 1, 0)

        Dim Sql As String



        Sql = "DELETE  FROM TMP_DISTRITO  "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_LINEA  "
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If


        If linea = 0 Then
            For Each var As Items In ItemsBindingSource1.List
                If strconsul.Length = 0 Then
                    strconsul = "'" & var.Codigo.Trim & "'"
                Else
                    strconsul = strconsul & ",'" & var.Codigo.Trim & "'"
                End If

                Sql = "NSP_INSERT_TMP_LINEA '" & codempresa & "','" & var.Codigo.Trim & "'"
                If TmpInsertDatos(Sql) = True Then
                End If


            Next
        End If




        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List
                If stralmacen.Length = 0 Then
                    stralmacen = "'" & var.Codigo.Trim & "'"
                    almacen1 = var.Codigo.Trim
                Else
                    stralmacen = stralmacen & ",'" & var.Codigo.Trim & "'"
                    almacen1 = almacen1 & "," & var.Codigo.Trim

                End If

                Sql = "NSP_INSERT_TMP_DISTRITO '" & codempresa & "','" & var.Codigo.Trim & "'"
                If TmpInsertDatos(Sql) = True Then
                End If

            Next

        End If



        If rbtodos.Checked Or rbstkfisico.Checked Then
            stk = 1
        Else
            stk = 0
        End If

        If rbcodigo.Checked = True Then
            orden = 0
        Else
            orden = 1
        End If

        Dim fechahas As String
        fechahas = Format(vFechaActual, "dd/MM/yyyy")




        '/*********************************************************************************************/

        CadenaCateg = ""

        If linea = 0 Then
            For Each var As Items In ItemsBindingSource1.List
                If CadenaCateg.Length = 0 Then
                    CadenaCateg = var.Codigo.Trim
                Else
                    CadenaCateg = CadenaCateg & "," & var.Codigo.Trim
                End If
            Next
        End If


        Sql = "SP_DEL_KARDEX_TMP3 '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        ' Dim fechahas As String

        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List

                almacen1 = var.Codigo.Trim
                fechahas = Format(vFechaActual, "dd/MM/yyyy")

                Dim Fechari As Date, Fecharf As Date
                Dim fecini As Date

                Dim dt As New DataTable
                Dim Fech As Date, FECHCIERRE As String

                CierreIgual = False
                Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

                dt = SelectFechCiere(Fech, False, almacen1)
                FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
                Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
                Fecharf = DateAdd("d", -1, DtFechaIni.Value)

                MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
                MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
                fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

                Procesar_Saldo(FECHCIERRE)


                Sql = "SP_INS_KARDEX_TMP3 '" & almacen1 & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If

            Next
        End If







        'If almacen = 0 Then
        '    For Each var As Items In ItemsBindingSource3.List

        '        almacen1 = var.Codigo.Trim
        '        Sql = "SP_INS_KARDEX_TMP3 '" & almacen1 & "','" & rand & "'"
        '        If TmpInsertDatos(Sql) = True Then
        '        End If
        '    Next
        'End If



        Try
            ' CAyuda.Ejecutar("SP_INSERT_TMP_UTILIDAD2", codempresa, fechahas)


            CAyuda.Ejecutar("sp_rpt_stock_articulo_almacen_categoria4", stralmacen, almacen.ToString, strconsul.ToString, linea.ToString, cmblista.SelectedValue.ToString, orden, stk.ToString, codempresa, rand)
            With Rpt1
                If cmblista.SelectedIndex = 0 Then
                    If rbstkfisico.Checked = False Then
                        .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacen1_1.rpt", String)

                    Else
                        '.ReportFileName = RutaRptInv + "\Reportes\rptStockArticulosAlmacen11.rpt"
                    End If
                ElseIf cmblista.SelectedIndex = 1 Then
                    If rbstkfisico.Checked = False Then

                        .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacen2.rpt", String)
                    Else
                        '.ReportFileName = RutaRptInv + "rptStockArticulosAlmacen22.rpt"
                    End If
                Else
                    If rbstkfisico.Checked = False Then
                        .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacen3.rpt", String)
                    Else
                        '.ReportFileName = RutaRptInv + "\Reportes\rptStockArticulosAlmacen33.rpt"
                    End If
                End If



                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                If rbcodigo.Checked = True Then
                    .set_SortFields(0, "+{INVENTARIO.CODARTI}")
                Else
                    .set_SortFields(0, "+{INVENTARIO.DESARTI}")
                End If

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim stralmacen As String = ""
        Dim strconsul As String = ""
        Dim linea, almacen As Integer
        Dim stk As Integer
        Dim orden As Integer

        Dim Sql As String

        Sql = "DELETE  FROM TMP_DISTRITO WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_LINEA  WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If



        If ItemsBindingSource1.Count = 0 Or ItemsBindingSource3.Count = 0 Then
            MsgBox("No hay items disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        linea = IIf(ItemsBindingSource.Count = 0, 1, 0)
        almacen = IIf(ItemsBindingSource2.Count = 0, 1, 0)

        If linea = 0 Then
            For Each var As Items In ItemsBindingSource1.List
                If strconsul.Length = 0 Then
                    strconsul = "'" & var.Codigo.Trim & "'"
                Else
                    strconsul = strconsul & ",'" & var.Codigo.Trim & "'"
                End If

                Sql = "NSP_INSERT_TMP_LINEA '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If


            Next
        End If

        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List
                If stralmacen.Length = 0 Then
                    stralmacen = "'" & var.Codigo.Trim & "'"
                    almacen1 = var.Codigo.Trim
                Else
                    stralmacen = stralmacen & ",'" & var.Codigo.Trim & "'"
                    almacen1 = almacen1 & "," & var.Codigo.Trim

                End If
            Next
        End If


        If rbtodos.Checked Or rbstkfisico.Checked Then
            stk = 1
        Else
            stk = 0
        End If

        If rbcodigo.Checked = True Then
            orden = 0
        Else
            orden = 1
        End If


        CadenaCateg = ""


        For Each var As Items In ItemsBindingSource1.List
            If CadenaCateg.Length = 0 Then
                CadenaCateg = var.Codigo.Trim

            Else
                CadenaCateg = CadenaCateg & "," & var.Codigo.Trim
            End If

        Next










        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        CierreIgual = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

        dt = SelectFechCiere(Fech, False, almacen1)
        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

        Procesar_Saldo(FECHCIERRE)



        Try

            CAyuda.Ejecutar("SP_INSERT_TMP_FECHAING", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS2", codempresa, rand)



            CAyuda.Ejecutar("sp_rpt_stock_articulo_almacen_categoria_3", stralmacen, almacen.ToString, strconsul.ToString, linea.ToString, cmblista.SelectedValue.ToString, orden, 1, codempresa, rand)
            With Rpt1
                .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacen_Distrib.rpt", String)



                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                If rbcodigo.Checked = True Then
                    .set_SortFields(0, "+{INVENTARIO.CODARTI}")
                Else
                    .set_SortFields(0, "+{INVENTARIO.DESARTI}")
                End If

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub lbalmacen2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbalmacen2.SelectedIndexChanged

    End Sub

    Private Sub rbtodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtodos.CheckedChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim stralmacen As String = ""
        Dim strconsul As String = ""
        Dim linea, almacen As Integer
        Dim stk As Integer
        Dim orden As Integer

        If ItemsBindingSource1.Count = 0 Or ItemsBindingSource3.Count = 0 Then
            MsgBox("No hay items disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        linea = IIf(ItemsBindingSource.Count = 0, 1, 0)
        almacen = IIf(ItemsBindingSource2.Count = 0, 1, 0)

        Dim Sql As String

        Sql = "DELETE  FROM TMP_DISTRITO WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_LINEA  WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If


        If linea = 0 Then
            For Each var As Items In ItemsBindingSource1.List
                If strconsul.Length = 0 Then
                    strconsul = "'" & var.Codigo.Trim & "'"
                Else
                    strconsul = strconsul & ",'" & var.Codigo.Trim & "'"
                End If

                Sql = "NSP_INSERT_TMP_LINEA '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If

            Next
        End If



        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List
                If stralmacen.Length = 0 Then
                    stralmacen = "'" & var.Codigo.Trim & "'"
                    almacen1 = var.Codigo.Trim
                Else
                    stralmacen = stralmacen & ",'" & var.Codigo.Trim & "'"
                    almacen1 = almacen1 & "," & var.Codigo.Trim

                End If

                Sql = "NSP_INSERT_TMP_DISTRITO '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If
            Next
        End If



        If rbtodos.Checked Or rbstkfisico.Checked Then
            stk = 1
        Else
            stk = 0
        End If

        If rbcodigo.Checked = True Then
            orden = 0
        Else
            orden = 1
        End If

        Dim fechahas As String
        fechahas = Format(vFechaActual, "dd/MM/yyyy")



        CadenaCateg = ""


        For Each var As Items In ItemsBindingSource1.List
            If CadenaCateg.Length = 0 Then
                CadenaCateg = var.Codigo.Trim

            Else
                CadenaCateg = CadenaCateg & "," & var.Codigo.Trim
            End If

        Next



        Dim Fechari As Date, Fecharf As Date
        Dim fecini As Date

        Dim dt As New DataTable
        Dim Fech As Date, FECHCIERRE As String

        CierreIgual = False
        Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

        dt = SelectFechCiere(Fech, False, almacen1)
        FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
        Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
        Fecharf = DateAdd("d", -1, DtFechaIni.Value)

        MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
        MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
        fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

        Procesar_Saldo(FECHCIERRE)



        Try

            CAyuda.Ejecutar("SP_INSERT_TMP_FECHAING", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS2", codempresa, rand)

            CAyuda.Ejecutar("SP_INSERT_TMP_UTILIDAD2", codempresa, fechahas, rand)
            CAyuda.Ejecutar("sp_rpt_stock_articulo_almacen_categoria", stralmacen, almacen.ToString, strconsul.ToString, linea.ToString, cmblista.SelectedValue.ToString, orden, stk.ToString, codempresa, rand)
            With Rpt1
                If cmblista.SelectedIndex = 0 Then
                    If rbstkfisico.Checked = False Then
                        .ReportFileName = RutaRptInv & CType("rptStockArticulosAlmacenCero.rpt", String)

                    Else
                        '.ReportFileName = RutaRptInv + "\Reportes\rptStockArticulosAlmacen11.rpt"
                    End If

                End If



                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                If rbcodigo.Checked = True Then
                    .set_SortFields(0, "+{INVENTARIO.CODARTI}")
                Else
                    .set_SortFields(0, "+{INVENTARIO.DESARTI}")
                End If

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim stralmacen As String = ""
        Dim strconsul As String = ""
        Dim linea, almacen As Integer
        Dim stk As Integer
        Dim orden As Integer

        If ItemsBindingSource1.Count = 0 Or ItemsBindingSource3.Count = 0 Then
            MsgBox("No hay items disponibles.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If

        linea = IIf(ItemsBindingSource.Count = 0, 1, 0)
        almacen = IIf(ItemsBindingSource2.Count = 0, 1, 0)


        Dim Sql As String

        Sql = "DELETE  FROM TMP_DISTRITO WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "DELETE  FROM TMP_LINEA  WHERE CORREL = '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If


        If linea = 0 Then
            For Each var As Items In ItemsBindingSource1.List
                If strconsul.Length = 0 Then
                    strconsul = "'" & var.Codigo.Trim & "'"
                Else
                    strconsul = strconsul & ",'" & var.Codigo.Trim & "'"
                End If

                Sql = "NSP_INSERT_TMP_LINEA '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If


            Next
        End If

        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List
                If stralmacen.Length = 0 Then
                    stralmacen = "'" & var.Codigo.Trim & "'"
                    almacen1 = var.Codigo.Trim
                Else
                    stralmacen = stralmacen & ",'" & var.Codigo.Trim & "'"
                    almacen1 = almacen1 & "," & var.Codigo.Trim

                End If

                Sql = "NSP_INSERT_TMP_DISTRITO '" & codempresa & "','" & var.Codigo.Trim & "','" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If
            Next
        End If

        CadenaCateg = ""

        For Each var As Items In ItemsBindingSource1.List
            If CadenaCateg.Length = 0 Then
                CadenaCateg = var.Codigo.Trim

            Else
                CadenaCateg = CadenaCateg & "," & var.Codigo.Trim
            End If

        Next


        Sql = "SP_DEL_KARDEX_TMP3 '" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If

        Dim fechahas As String

        If almacen = 0 Then
            For Each var As Items In ItemsBindingSource3.List

                almacen1 = var.Codigo.Trim
                fechahas = Format(vFechaActual, "dd/MM/yyyy")

                Dim Fechari As Date, Fecharf As Date
                Dim fecini As Date

                Dim dt As New DataTable
                Dim Fech As Date, FECHCIERRE As String

                CierreIgual = False
                Fech = DateAdd("d", -1 * DtFechaIni.Value.Day, DtFechaIni.Value)

                dt = SelectFechCiere(Fech, False, almacen1)
                FECHCIERRE = Date.Parse(IIf(dt.Rows(0)("Fecha") Is DBNull.Value, "01/01/2010", dt.Rows(0)("Fecha")))
                Fechari = DateAdd("d", 1, CDate(FECHCIERRE))
                Fecharf = DateAdd("d", -1, DtFechaIni.Value)

                MstrFechaIni = Format(Fechari, "dd/MM/yyyy")
                MstrFechaFin = Format(Fecharf, "dd/MM/yyyy")
                fecini = Format(DtFechaIni.Value, "dd/MM/yyyy")

                Procesar_Saldo(FECHCIERRE)


                Sql = "SP_INS_KARDEX_TMP3 '" & almacen1 & "' ,'" & rand & "'"
                If TmpInsertDatos(Sql) = True Then
                End If

            Next
        End If





        If rbtodos.Checked Or rbstkfisico.Checked Then
            stk = 1
        Else
            stk = 0
        End If

        If rbcodigo.Checked = True Then
            orden = 0
        Else
            orden = 1
        End If

        fechahas = Format(vFechaActual, "dd/MM/yyyy")


        Try

            CAyuda.Ejecutar("SP_INSERT_TMP_FECHAING", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS", codempresa, rand)
            CAyuda.Ejecutar("NSP_INSERT_TMP_UCOSTOBAS2", codempresa, rand)

            ' CAyuda.Ejecutar("SP_INSERT_TMP_UTILIDAD2", codempresa, fechahas)


            CAyuda.Ejecutar("sp_rpt_stock_articulo_almacen_categoria4", stralmacen, almacen.ToString, strconsul.ToString, linea.ToString, cmblista.SelectedValue.ToString, orden, stk.ToString, codempresa, rand)
            With Rpt1

                .ReportFileName = RutaRptInv & CType("Rep_Almacen.rpt", String)


                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                '.set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                '.set_Formulas(1, "Usuario='" & DesUsuario & "'")
                '.set_StoredProcParam(0, codempresa)
                'If rbcodigo.Checked = True Then
                '    .set_SortFields(0, "+{INVENTARIO.CODARTI}")
                'Else
                '    .set_SortFields(0, "+{INVENTARIO.DESARTI}")
                'End If

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class