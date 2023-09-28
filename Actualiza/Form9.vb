Imports System.Data.SqlClient

Public Class Form9
    Dim Ayuda As New ClsAyuda
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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


        Dim NRODOCU As Double = 0
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
            Dim StrTipodoc As String = ""
            Dim SQL As String = ""
            Dim VENTC As String = ""
            Dim VENTD As String = ""
            Dim AÑO As String = ""
            Dim MES As String = ""

            Dim codArticulo As String
            Dim codPresentacion As String = ""
            Dim desPresentacion As String
            Dim cantidad As String
            Dim Precio As Double

            Dim CODTIPOPAGO As String = ""
            Dim FECDOCUM1 As Date
            Dim CODVENDEDOR As String = ""
            Dim TOTBAS As Double
            Dim CODCLIENTDEP As String = ""
            Dim RUCCLIENTE As String = ""
            Dim DESCLIENTE As String = ""
            Dim DIRCLIENTE As String = ""

            Dim NRODOC As String
            Dim TIPODOC1 As String = ""
            Dim CODCLIENTPRI As String = ""

            Dim DOCANT As String

            DOCANT = ""

            da.Fill(ds)

            '/********validar documentos

            Dim NRODOCVAL As String
            Dim TIPODOCVAL As String

            If ds.Rows.Count > 0 Then
                For Each dt As DataRow In ds.Rows
                    TIPODOCVAL = ValidaNullSTring(dt.Item(1))
                    NRODOCVAL = ValidaNullSTring(dt.Item(2))

                    Dim TABLE1 As New DataTable
                    TABLE1 = TmpListarDatos("NSP_BUSCAR_FACTURACIONPROTISA  '" & codempresa & "','" & NRODOCVAL & "','" & TIPODOCVAL & "','" & VCorrelVta & "'")
                    If TABLE1.Rows.Count > 0 Then
                        MsgBox("EL DOCUMENTO YA EXISTE NRO " & NRODOCVAL & " TIPO " & TIPODOCVAL & " REVISE! ")
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

                    Dim DESPRES As String = ""
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
                    TIPODOC1 = dt.Item(1)

                    Dim dt_TABLA3 As New DataTable
                    dt_TABLA3 = CAyuda.ListarDatos("SP_SELECT_CLIENTE2", CODCLIENTDEP).Tables(0)
                    If dt_TABLA3.Rows.Count > 0 Then
                        RUCCLIENTE = dt_TABLA3.Rows(0)(0).ToString
                        DESCLIENTE = dt_TABLA3.Rows(0)(1).ToString
                        DIRCLIENTE = dt_TABLA3.Rows(0)(2).ToString
                    End If

                    Dim dt_TABLA4 As New DataTable
                    dt_TABLA4 = CAyuda.ListarDatos("SP_CODCLIDEP", CODCLIENTDEP).Tables(0)
                    If dt_TABLA4.Rows.Count > 0 Then
                        CODCLIENTPRI = dt_TABLA4.Rows(0)(0).ToString
                    Else
                        MsgBox("CODCLIENTE NO EXISTE")
                    End If


                    Ayuda.Ejecutar("NSP_INSERT_FILA_TMP_VENTADETFD1", codempresa, codArticulo, desPresentacion, DESPRES, cantidad, Precio, Precio, 0, CodUsuario, NROPTOVTA, VCorrelVta, "", 0, CDZONA, CHECKPROMO)


                    Dim cn2 As New SqlConnection(STRCN)
                    If cn2.State = ConnectionState.Open Then
                        cn2.Close()
                    End If
                    cn2.Open()
                    Dim cmd2 As New SqlCommand("Nsp_grabadocumento_protisa", cn2)
                    cmd2.CommandType = CommandType.StoredProcedure

                    cmd2.Parameters.AddWithValue("@NRODEGUIAS", CStr("")).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@NPESADA", CStr("")).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@Eigv", "True").SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@actualizocorrelativo", CStr(fact_editnumero)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@NUMEROTRANS", CInt(FACT_NUMEROTRANSACCION)).SqlDbType = SqlDbType.Int
                    cmd2.Parameters.AddWithValue("@CODDEP", CStr(CODCLIENTPRI)).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@CODTIPOPAGO", CODTIPOPAGO.Trim).SqlDbType = SqlDbType.VarChar
                    cmd2.Parameters.AddWithValue("@CODTIPODOC", CStr(TIPODOC1)).SqlDbType = SqlDbType.VarChar
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
                MsgBox("Transferencia Realizada con Exito... " + Chr(13) + "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
            End If

        Catch ex As Exception
            MsgBox("No se encontro un libro válido en la ubicación especificada. " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub


End Class