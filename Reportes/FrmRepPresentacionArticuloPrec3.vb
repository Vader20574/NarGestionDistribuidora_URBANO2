Public Class FrmRepPresentacionArticuloPrec3

    Dim ACT_EVENTOS As Integer


    Dim MstrFechaIni As String
    Dim MstrFechaFin As String
    Dim MstrFechaFinRec As String
    Dim CierreIgual As Boolean = False
    Dim CadenaCateg As String = ""
    Dim Todo_Cate As Int16

    Private Tb_Categ2 As New DataTable

    Dim almacen1 As String

    Dim rand As Integer



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

            meses = Val(DateDiff("m", CDate(MstrFechaIni), CDate(MstrFechaFin)))
            ''SELECCIONO INVENTARIO INICIAL - INGRESOS -  SALIDAS
            Fecinicial = Format(CDate(MstrFechaIni), "dd/MM/yyyy 00:00:00")
            Fecfinal = Format(CDate(MstrFechaFin), "dd/MM/yyyy 23:59:00")

            TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','MOVIDET',0,'" & rand & "'")

            ''SELECCIONO LAS VENTAS
            For i As Integer = 0 To meses
                MesAct = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "MM")
                Anio = Format(DateAdd("m", i, CDate(MstrFechaIni).AddDays(1)), "yyyy")
                VentaC = "VENTC" & Anio & MesAct
                VentD = "VENTD" & Anio & MesAct
                MoviD = "MOVID" & Anio & MesAct
                MoviC = "MOVIC" & Anio & MesAct


                If TmpListarDatos("VERIFICA_HISTORICOMOVI '" & codempresa & "','" & MoviC & "'").Rows.Count <> 0 Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_INGSAL '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & MoviD & "',1,'" & rand & "'")
                End If

                If VERIFICA_HISTORICOVENT(VentaC) = True Then
                    TmpInsertDatos("KARDEX_GENERAL_REPORT_FALTANTES_VENTAS '" & codempresa & "','" & Fecinicial & "','" & Fecfinal & "','" & almacen1 & "','" & CadenaCateg & "'," & Todo_Cate & ",'" & fechaCierre & "','" & VentD & "','" & VentaC & "','" & rand & "'")
                End If
            Next

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





    Private Sub FrmRepPresentacionArticuloPrec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(cbolinea, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")
        cbolinea.SelectedIndex = 0
        CAyuda.CargarDataCombo(cboAlmacen, "Nsp_select_Almacen  '" & codempresa & "'", "codigo", "descripcion")

        MostrarSubCategoria()

        ValorRan()



        DtFechaIni.Value = Date.Now.AddDays(-1)
        DtFechaFin.Value = Date.Now




        'Dim dt2 As New DataTable

        'dt2 = CAyuda.ListarDatos("SELEC_CIERRE_MES", codempresa).Tables(0)
        'Dim AÑO As String
        'Dim MES As String
        'AÑO = dt2.Rows(0)(0)
        'MES = dt2.Rows(0)(1)


        'Dim Fecharf As Date

        'Dim Table_Correlativo2 As DataTable
        'Table_Correlativo2 = CAyuda.ListarDatos("SP_EXTRADIA", AÑO, MES).Tables(0)
        'DtFechaIni.Value = CDate(Table_Correlativo2.Rows(0)(0).ToString)


        'Fecharf = DateAdd("d", +1, DtFechaIni.Value)

        'DtFechaIni.Value = Fecharf


    End Sub

    Private Sub MostrarSubCategoria()
        Dim TABLE_SUBCAT As DataTable

        TABLE_SUBCAT = TmpListarDatos("SP_SELECT_SUBLINEAxLINEA '" & codempresa.Trim & "' ,'" & cbolinea.SelectedValue & "'")
        cbosublinea.DataSource = TABLE_SUBCAT
        cbosublinea.ValueMember = "CODSUBLINEA"
        cbosublinea.DisplayMember = "DESSUBLINEA"

    End Sub

    Private Sub cbosublinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosublinea.SelectedIndexChanged

    End Sub

    Private Sub cbolinea_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbolinea.Click
        ACT_EVENTOS = 1
    End Sub

    Private Sub INSERTCIERREALDIA(ByVal FechaCierre As Date)

        If Todo_Cate = 1 Then
            TmpInsertDatos("INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS )  " & _
                          "SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,CIERRE_MES_INVENTARIO.ARTICULO,CIERRE_MES_INVENTARIO.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0 " & _
                          "FROM CIERRE_MES_INVENTARIO,ARTICULO WHERE CIERRE_MES_INVENTARIO.ARTICULO=ARTICULO.CODARTI AND ARTICULO.FORMU = 0 AND CIERRE_MES_INVENTARIO.ALMACEN ='" & Trim(almacen1) & "'  AND FECHA='" & FechaCierre & "'")
        Else
            TmpInsertDatos(" INSERT INTO TMP_KARDEX (CORREL,CODEMPRESA,CDALMA, CDG01, CDARTI, STOCKINI, STOCKREC, COMPRAS, INGAJUSTE, INGTRANSF, INGOTROS,VENTAS, SALAJUSTE, SALTRANSF, SALOTROS ) " & _
                             " SELECT '" & rand & "','" & codempresa & "',ALMACEN,ARTICULO.CODLINEA,CIERRE_MES_INVENTARIO.ARTICULO,CIERRE_MES_INVENTARIO.STOCK AS STKINICIO,0,0,0,0,0,0,0,0,0 " & _
                             " FROM CIERRE_MES_INVENTARIO,ARTICULO WHERE  ARTICULO.FORMU = 0  AND  CIERRE_MES_INVENTARIO.ARTICULO=ARTICULO.CODARTI AND ARTICULO.CODLINEA IN(" & CadenaCateg & ")  AND CIERRE_MES_INVENTARIO.ALMACEN ='" & Trim(almacen1) & "'  AND FECHA='" & Format(FechaCierre, "dd/MM/yyyy") & "'")
        End If

    End Sub



    Private Sub cbolinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbolinea.SelectedIndexChanged
        If ACT_EVENTOS = 1 Then
            MostrarSubCategoria()
        End If


    End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CheckBox4.Checked = True Or CheckBox5.Checked = True Then
            Tb_Categ2 = TmpListarDatos("SELECT  CODLINEA,DESLINEA  FROM LINEA  WHERE   CODEMPRESA='" & codempresa & "'")

            CadenaCateg = ""
            For a As Integer = 0 To Tb_Categ2.Rows.Count - 1
                If CadenaCateg = "" Then
                    CadenaCateg = Trim(Tb_Categ2.Rows(a)("CODLINEA"))
                Else
                    CadenaCateg = CadenaCateg & "," & Trim(Tb_Categ2.Rows(a)("CODLINEA"))
                End If
            Next
        Else
            CadenaCateg = cbolinea.SelectedValue.ToString
        End If

        Dim Sql As String
        Sql = "SP_INS_TMP_TIPO_DOC '" & codempresa & "','" & rand & "'"
        If TmpInsertDatos(Sql) = True Then
        End If





        '/*********************************************************************************************/

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


        almacen1 = cboAlmacen.SelectedValue.ToString

        Procesar_Saldo(FECHCIERRE)








        Dim p1 As Integer = 0
        Dim p2 As Integer = 0

        If CheckBox4.Checked = True Then

            Try
                'Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                crRpt.ReportFileName = rutareporte & "Rpt_Presentacion_Articulo_precio3.rpt"
                crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                crRpt.set_StoredProcParam(0, codempresa)
                crRpt.set_StoredProcParam(1, cbolinea.SelectedValue)


                crRpt.set_StoredProcParam(2, "0")



                crRpt.set_StoredProcParam(3, 1)
                crRpt.set_StoredProcParam(4, cboAlmacen.SelectedValue)
                crRpt.set_StoredProcParam(5, rand)

                'crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
                'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                crRpt.Destination = Crystal.DestinationConstants.crptToWindow
                crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                crRpt.Action = 1
                crRpt.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Exit Sub


        End If




        If CheckBox5.Checked = True Then


            Try
                ' Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                crRpt.ReportFileName = rutareporte & "Rpt_Presentacion_Articulo_precio2_1.rpt"
                crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                crRpt.set_StoredProcParam(0, codempresa)
                crRpt.set_StoredProcParam(1, cbolinea.SelectedValue)


                crRpt.set_StoredProcParam(2, "0")



                crRpt.set_StoredProcParam(3, 1)
                crRpt.set_StoredProcParam(4, "A")
                crRpt.set_StoredProcParam(5, "B")
                crRpt.set_StoredProcParam(6, cboAlmacen.SelectedValue)
                crRpt.set_StoredProcParam(7, rand)

                'crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
                'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                crRpt.Destination = Crystal.DestinationConstants.crptToWindow
                crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                crRpt.Action = 1
                crRpt.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Exit Sub


        End If






        If CheckBox3.Checked = False Then


            Try
                'Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                crRpt.ReportFileName = rutareporte & "Rpt_Presentacion_Articulo_precio9.rpt"
                crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                crRpt.set_StoredProcParam(0, codempresa)
                crRpt.set_StoredProcParam(1, cbolinea.SelectedValue)



                If CheckBox2.Checked = True Then
                    crRpt.set_StoredProcParam(2, "0")
                Else
                    crRpt.set_StoredProcParam(2, cbosublinea.SelectedValue)
                End If


                crRpt.set_StoredProcParam(3, CInt(CheckBox1.Checked()))

                crRpt.set_StoredProcParam(4, cboAlmacen.SelectedValue)

                crRpt.set_StoredProcParam(5, rand)

                'crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
                'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                crRpt.Destination = Crystal.DestinationConstants.crptToWindow
                crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                crRpt.Action = 1
                crRpt.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else

            Try
                ' Dim dt As New DataTable
                dt = M_Cabecera_R(CodUsuario, codempresa)
                crRpt.ReportFileName = rutareporte & "Rpt_Presentacion_Articulo_precio2.rpt"
                crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                crRpt.set_StoredProcParam(0, codempresa)
                crRpt.set_StoredProcParam(1, cbolinea.SelectedValue)

                If CheckBox2.Checked = True Then
                    crRpt.set_StoredProcParam(2, "0")
                Else
                    crRpt.set_StoredProcParam(2, cbosublinea.SelectedValue)
                End If


                crRpt.set_StoredProcParam(3, CInt(CheckBox1.Checked()))
                'crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
                'crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
                crRpt.Destination = Crystal.DestinationConstants.crptToWindow
                crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
                crRpt.Action = 1
                crRpt.Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If











    End Sub
    Private Function SelectFechCiere(ByVal fecha As Date, ByVal HizoCierre As Boolean, ByVal StrAlmacen As String) As DataTable

        Dim dt As New DataTable
        If HizoCierre = True Then
            'dt = TmpListarDatos("select * from resukdx where fecha='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select *  from CIERRE_MES_INVENTARIO where fecha=('" & Format(fecha, "dd/MM/yyyy") & "') AND ALMACEN ='" & StrAlmacen & "'")
        Else
            'dt = TmpListarDatos("SELECT max (fechA) AS FECHA from resukdx where fechA <= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
            dt = TmpListarDatos("select max (fechA) AS Fecha from CIERRE_MES_INVENTARIO where fecha <='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")
        End If

        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("Fecha") Is DBNull.Value Then
                'dt = TmpListarDatos("SELECT mIN (fechA) AS FECHa from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'  AND ALMACEN ='" & StrAlmacen & "'")
                dt = TmpListarDatos("select mIN (fechA)  AS Fecha from CIERRE_MES_INVENTARIO where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "'")

            End If
        Else
            '  dt = TmpListarDatos("SELECT distinct FECHA=max(fecha) from resukdx where fechA >= '" & Format(fecha, "dd/MM/yyyy") & "'   AND ALMACEN ='" & StrAlmacen & "'  group by CODARTI")

            dt = TmpListarDatos("select max(fecha)  AS Fecha from CIERRE_MES_INVENTARIO where fechA >='" & Format(fecha, "dd/MM/yyyy") & "' AND ALMACEN ='" & StrAlmacen & "' group by articulo ")

        End If

        Return dt

    End Function

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged

    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class