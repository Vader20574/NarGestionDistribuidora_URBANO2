Imports System.Data.SqlClient

Imports System.IO.IsolatedStorage
Imports System.IO
Module ModFunciones

#Region "Function the Connection "
    Public Cn As New SqlConnection(STRCN)
    Public Cn2 As New SqlConnection(STRCN2)
    Public cmb As SqlCommandBuilder
    Public oda As New SqlDataAdapter

    Public TablaReservaciones As DataTable
    Public TipoCambioCompra As Double
    Public TipoCambioVenta As Double
    Public IntAnchoTicket As Integer = 38
    Public GstrLinea1, GstrLinea2, GstrLinea3, GstrLinea4, GstrCadCortaTicket As String
    Public GR_VTAMANUAL As Integer
    Public GstrRUTAPRN As String

    Public ACTIMPCATX, ACTIMPCATZ, ACTIMPSUBX, ACTIMPSUBZ, ACTIMPPRODX, ACTIMPPRODZ, ACTIMPPRESNTX, ACTIMPPRESNTZ, ACTIMPVTAXHORA As Boolean

    ' Public GStrMaquinaReg As String = Environment.MachineName
    Public GHEAD1, GHEAD2, GHEAD3, GHEAD4, GHEAD5, GHEAD6, GHEAD7, GHEAD8, GHEAD9, GHEAD10 As String
    Public GLINES1, GLINES2, GLINES3, GLINES4 As String
    Public GstrFOOT1, GstrFOOT2, GstrFOOT3, GstrFOOT4, GstrFOOT5, GstrFOOT6, GstrFOOT7, GstrFOOT8, GstrFOOT9, GstrFOOT10 As String
    'Public CDTICKET, CDFACTURA, CDBOLETA, CDCONSINTER, IDIMPIGV, IDIMPISC, EMPAQ_PASSWORD As String
    Public CDTICKET, CDCONSINTER, IDIMPIGV, IDIMPISC, EMPAQ_PASSWORD As String

    Public IMPCOMANDA, ENVIO_CORREO, EMPAQ_FILE As Boolean
    Public ENVIOPANTALLACOCINA, PEDIRNOMCLIE As Boolean

    Public GbytImpTickResu, GintSaltaLineas, GbytSalidaImpresion As Boolean
    Public Gdeciprec, GdeciCant, GdeciREsul, MinutosReserva As Integer, HoraReserva As Integer
    Public GPORCENIGV As Double
    Public CodSalonOrig As Integer
    Public VALMESAXMOZO As Boolean
    Public TRANSFERIRVENTAS As Boolean

    ' Public CDMONBASE, CDMONEXTR As String
    Private NumLinea As Integer
    Public GmaquinaRegist As String
    Public ACTIMPESTIK, ACTIIMPMULT, DOCPREIMP, PEDNROCOMANDSALON, TICKETIMP As Boolean
    Public Tabla_Inpresion_Nueva As New DataTable
    Public VContIni, VContFin As Integer
    Dim dsn, uid, pwd As String

    Public Sub IniciarConeccion()
        Dim dsa As New DataSet
        Try
            Dim x As String
            x = Application.StartupPath

            dsa.ReadXml(Application.StartupPath + "\config.xml")
            servidor = Trim(dsa.Tables(0).Rows(0)(0))
            bd = Trim(dsa.Tables(0).Rows(0)(1))
            usuariodb = Trim(dsa.Tables(0).Rows(0)(2))
            rutareporte = Trim(dsa.Tables(0).Rows(0)(4))
            RutaRptInv = Trim(dsa.Tables(0).Rows(0)(5))
            servidor2 = Trim(dsa.Tables(0).Rows(0)("server2"))
            bd2 = Trim(dsa.Tables(0).Rows(0)("bd2"))
            usuariodb2 = Trim(dsa.Tables(0).Rows(0)("usuario2"))
            passworddb2 = Trim(dsa.Tables(0).Rows(0)("password2"))

            dsn = Trim(dsa.Tables(0).Rows(0)("dsn"))
            uid = Trim(dsa.Tables(0).Rows(0)("uid"))
            pwd = Trim(dsa.Tables(0).Rows(0)("pwd"))

            If Trim(dsa.Tables(0).Rows(0)(3)) = "." Then
                passworddb = ""
            Else
                passworddb = Trim(dsa.Tables(0).Rows(0)(3))
            End If


            'Desencriptar()



        Catch X As Exception
            MessageBox.Show("Ruta de Servidor Erronea. Consulte con el administrador del Sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End Try

    End Sub

    'Sub Encriptar()
    '    Dim a As String
    '    Dim b As Integer

    '    a = UCase("301102")
    '    'TextBox2.Text = ""

    '    For b = 1 To Len(a)
    '        TextBox2.Text = TextBox2.Text & "0" & Asc(Mid(a, b, 1))
    '    Next b

    'End Sub


    Sub Desencriptar()
        Dim a As String
        Dim b As Integer

        a = passworddb
        passworddb = ""
        For b = 1 To Len(a) Step 3
            passworddb = passworddb & Chr(Val(Mid(a, b, 3)))
        Next b
        passworddb = passworddb.ToLower()

    End Sub


    Public Sub inicia_cadena()
        cadenac = "DATA SOURCE=" + CType(servidor.Trim, String) + ";INITIAL CATALOG=" + CType(bd, String) + ";USER ID=" + CType(usuariodb, String) + ";PASSWORD=" + CType(passworddb, String)
        'cadenac = "Data Source=" & CType(servidor.Trim, String) & ";Network Library=DBMSSOCN;Initial Catalog=" & CType(bd, String) & ";User ID=" & CType(usuariodb, String) & ";Password=" & CType(passworddb, String) & ";"
        STRCN = cadenac
    End Sub

    Public Sub inicia_cadena2()
        'cadenac = "DATA SOURCE=" + CType(servidor2.Trim, String) + ";INITIAL CATALOG=" + CType(bd2, String) + ";USER ID=" + CType(usuariodb2, String) + ";PASSWORD=" + CType(passworddb2, String)
        'STRCN2 = cadenac
        ' cadenac = "dsn=" + CType(dsn.Trim, String) + ";uid=" + CType(uid.Trim, String) + ";pwd=" + CType(pwd.Trim, String) + ";"
        'STRCN2 = cadenac

        cadenac = "dsn=" + CType(dsn.Trim, String) + ";uid=" + CType(uid.Trim, String) + ";pwd=" + CType(pwd.Trim, String) + ";"
        STRCN2 = cadenac


    End Sub
#End Region

#Region "Functions Globales"

    Public Function SELECT_PERMISO_PROC(ByVal PROCESO As String, ByVal usuario As String) As Boolean
        Dim dataValidar As New DataTable
        dataValidar = TmpListarDatos("SELEC_PERMISOPROC    '" & codempresa & "','" & PROCESO & "','" & usuario & "' ")
        If dataValidar.Rows.Count > 0 Then
            SELECT_PERMISO_PROC = TmpListarDatos("SELEC_PERMISOPROC    '" & codempresa & "','" & PROCESO & "','" & usuario & "' ").Rows(0)(0).ToString.Trim
        Else
            MsgBox("El nivel de este usuario aun no tiene este Proceso", MsgBoxStyle.Information, DesEmpresa)
        End If
    End Function

    Public Function GValidarNulos(ByVal val As Object) As Object
        If Microsoft.VisualBasic.IsDBNull(val) Then
            Return ""
        Else
            Return val
        End If
    End Function

    Public Sub CargagridPedidosNextel(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN2
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView

            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo0 As New DataGridTextBoxColumn
            With ColEStilo0
                .HeaderText = "NMR_CODPEDIDO"
                .MappingName = "NMR_CODPEDIDO"
                .Width = 0
                .ReadOnly = True
            End With

            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "CODEMPRESA"
                .MappingName = "CODEMPRESA"
                .Width = 0
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "CLIENTE"
                .MappingName = "CLIENTE"
                .Width = 250
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "FECHA"
                .MappingName = "FECHA"
                .Width = 70
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "VENDEDOR"
                .MappingName = "VENDEDOR"
                .Width = 250
                .ReadOnly = True
            End With

            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "MONEDA"
                .MappingName = "MONEDA"
                .Width = 70
                .ReadOnly = True
            End With

            Dim ColEStilo6 As New DataGridTextBoxColumn
            With ColEStilo6
                .HeaderText = "FORMAPAGO"
                .MappingName = "FORMAPAGO"
                .Width = 100
                .ReadOnly = True
            End With

            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo0, ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5, ColEStilo6})
            grilla.TableStyles.Add(dgEstiloColumna)

            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Public Sub CargagridDetPedidosNextel(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN2
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView

            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee

            Dim ColEStilo0 As New DataGridTextBoxColumn
            With ColEStilo0
                .HeaderText = "CODIGO"
                .MappingName = "CODIGO"
                .Width = 100
                .ReadOnly = True
            End With


            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "PRODUCTO"
                .MappingName = "PRODUCTO"
                .Width = 200
                .ReadOnly = True
            End With



            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "CANTIDAD"
                .MappingName = "CANTIDAD"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "PRECIO"
                .MappingName = "PRECIO"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "PRESENTACION"
                .MappingName = "PRESENTACION"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "EQUIVALENCIA"
                .MappingName = "EQUIVALENCIA"
                .Width = 0
                .ReadOnly = True
            End With


            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo0, ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5})
            grilla.TableStyles.Add(dgEstiloColumna)

            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Public Function ListarGridPedidosNextel(ByVal store_procedure As String) As DataTable
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN2
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            Dim dt As New DataTable
            DAT.SelectCommand = cmd
            DAT.Fill(dt)

            cn.Close()
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.ToString)
        End Try
    End Function



    Public Sub CargagridEmpresa(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 80
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Razon Social"
                .MappingName = "Razon_Social"
                .Width = 190
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Razon Social Abreviada"
                .MappingName = "Razon_Social_Abr"
                .Width = 190
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "R.U.C"
                .MappingName = "RUC"
                .Width = 90
                .ReadOnly = True
            End With


            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try

    End Sub
    Public Function GVDATO(ByVal IVarDato As Object) As String
        IVarDato = Trim(UCase(CAyuda.ValidaNulls(IVarDato)))
        GVDATO = IVarDato
    End Function
    Public Sub Cargagridmedida(ByVal grilla As DataGrid, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Medida"
                .MappingName = "Medida"
                .Width = 150
                .ReadOnly = True
            End With
            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Factor"
                .MappingName = "Factor"
                .Width = 150
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "desumedSunat"
                .MappingName = "desumedSunat"
                .Width = 150
                .ReadOnly = True
            End With

            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Public Sub CargagridZona(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Descripcion"
                .MappingName = "Descripcion"
                .Width = 250
                .ReadOnly = True
            End With
            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try


    End Sub


    Public Sub CargagridSubLinea(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "CODSUBLINEA"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "SubLinea"
                .MappingName = "DESSUBLINEA"
                .Width = 250
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "CODLINEA"
                .MappingName = "CODLINEA"
                .Width = 0
                .ReadOnly = True
            End With


            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "DESLINEA"
                .MappingName = "DESLINEA"
                .Width = 0
                .ReadOnly = True
            End With

            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try


    End Sub

    Public Sub CargagridIntervalo(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 50
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Descripcion"
                .MappingName = "Descripcion"
                .Width = 250
                .ReadOnly = True
            End With


            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Cant Inicial"
                .MappingName = "CANTINI"
                .Width = 75
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "Cant Final"
                .MappingName = "CANTFIN"
                .Width = 75
                .ReadOnly = True
            End With

            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try


    End Sub


    Public Sub Cargagridalmacen(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Código"
                .MappingName = "Codigo"
                .Width = 50
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Descripción"
                .MappingName = "Descripcion"
                .Width = 165
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridBoolColumn
            With ColEStilo3
                .HeaderText = "Ajuste Stock"
                .MappingName = "Ajuste_en_stock"
                .Width = 70
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "Punto de Venta"
                .MappingName = "Punto_Venta"
                .Width = 160
                .ReadOnly = True
            End With

            Dim ColEStilo5 As New DataGridBoolColumn
            With ColEStilo5
                .HeaderText = "Activo"
                .MappingName = "activo"
                .Width = 50
                .ReadOnly = True
            End With

            Dim ColEStilo6 As New DataGridBoolColumn
            With ColEStilo6
                .HeaderText = "TIPO"
                .MappingName = "TIPO"
                .Width = 0
                .ReadOnly = True
            End With

            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5, ColEStilo6})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Public Sub limtextoTAB(ByVal control As TabControl)
        Dim pag As TabPage
        Dim caja As Control
        For Each pag In control.TabPages
            For Each caja In pag.Controls
                If TypeOf caja Is TextBox Then
                    caja.Text = ""
                End If
            Next
        Next
    End Sub
    Public Function buscaregistro(ByVal sql As String) As Integer
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(sql, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            buscaregistro = DS.Tables("MITABLA").Rows.Count
            cn.Close()
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try

    End Function
    Public Sub FORMATtextoTAB(ByVal Control As TabControl)
        Dim pag As TabPage
        Dim caja As Control
        For Each pag In Control.TabPages
            For Each caja In pag.Controls
                If TypeOf caja Is TextBox Then
                    caja.Text = Trim(StrConv(caja.Text, 3))
                End If
            Next
        Next
    End Sub
    Public Sub CargagridPresentacion(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 80
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Medida"
                .MappingName = "Medida"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Presentacion"
                .MappingName = "Presentacion"
                .Width = 170
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "Factor   ."
                .MappingName = "Factor"
                .Alignment = HorizontalAlignment.Right
                .Width = 80
                .ReadOnly = True
                .Format = FACT_GFormatodeNumero(0)
            End With

            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "Tara   ."
                .MappingName = "Tara"
                .Alignment = HorizontalAlignment.Right
                .Width = 80
                .ReadOnly = True
                .Format = FACT_GFormatodeNumero(0)
            End With


            'Dim ColEStilo6 As New DataGridTextBoxColumn
            'With ColEStilo6
            '    .HeaderText = "DESUMEDSUNAT"
            '    .MappingName = "DESUMEDSUNAT"
            '    .Alignment = HorizontalAlignment.Right
            '    .Width = 80
            '    .ReadOnly = True
            'End With

            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5})

            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Cargagrid(ByVal grilla As Object, ByVal store_procedure As String)
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing

        Catch ex As Exception
        End Try
    End Sub
    Public Function GBloqueaCaracter(ByVal KeyAscii As Integer) As Integer
        'funcion evita que se digiten caracteres invalidos
        If KeyAscii = 39 Or KeyAscii = 124 Then
            GBloqueaCaracter = 0
        Else
            If KeyAscii >= 97 And KeyAscii <= 122 Then
                GBloqueaCaracter = KeyAscii - 32
            Else
                GBloqueaCaracter = KeyAscii
            End If
        End If
    End Function
    Public Sub bloqueatextos(ByVal frm As Form)
        Dim ctrtextbox As Object
        For Each ctrtextbox In frm.Controls
            If TypeOf ctrtextbox Is TextBox Then
                ctrtextbox.ReadOnly = True
            End If

            If TypeOf ctrtextbox Is GroupBox Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrtextbox.CONTROLS
                    If TypeOf OBJTEXT Is TextBox Then
                        OBJTEXT.ReadOnly = True
                    End If
                Next
            End If
        Next

    End Sub
    Sub LimpiarFormularios(ByVal Frm As Form)

        Dim obj As Object
        For Each obj In Frm.Controls
            If TypeOf obj Is TextBox Then obj.text = ""
            If TypeOf obj Is GroupBox Then
                Dim objtext As Object
                For Each objtext In obj.controls
                    If TypeOf objtext Is TextBox Then
                        objtext.text = ""
                    End If
                Next
            End If
        Next
    End Sub
    Public Sub desbloqueatextos(ByVal frm As Form)
        Dim ctrtextbox As Object
        For Each ctrtextbox In frm.Controls
            If TypeOf ctrtextbox Is TextBox Then
                ctrtextbox.ReadOnly = False
            End If

            If TypeOf ctrtextbox Is GroupBox Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrtextbox.CONTROLS
                    If TypeOf OBJTEXT Is TextBox Then
                        OBJTEXT.ReadOnly = False
                    End If
                Next

            End If

        Next
    End Sub
    Sub botones(ByVal btnue As Button, ByVal btgrab As Button,
ByVal btmodi As Button, ByVal btelim As Button, ByVal btcanc As Button,
ByVal btrep As Button, ByVal btsalir As Button, ByVal nue As Boolean,
ByVal grab As Boolean, ByVal modi As Boolean, ByVal elim As Boolean,
ByVal canc As Boolean, ByVal REP As Boolean, ByVal salir As Boolean)
        btnue.Enabled = nue
        btgrab.Enabled = grab
        btmodi.Enabled = modi
        btelim.Enabled = elim
        btcanc.Enabled = canc
        btrep.Enabled = REP
        btsalir.Enabled = salir
    End Sub
    Public Sub Cargagridciudad(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 80
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Ciudad"
                .MappingName = "Ciudad"
                .Width = 210
                .ReadOnly = True
            End With
            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Pais"
                .MappingName = "Pais"
                .Width = 200
                .ReadOnly = True
            End With


            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3})

            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception

        End Try

    End Sub
    Public Sub CargagridTipoProveedores(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Descripcion"
                .MappingName = "Descripcion"
                .Width = 250
                .ReadOnly = True
            End With
            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try


    End Sub


    Public Sub Cargagriddepa(ByVal grilla As DataGrid, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 80
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Departamento"
                .MappingName = "Departamento"
                .Width = 210
                .ReadOnly = True
            End With
            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Pais"
                .MappingName = "Pais"
                .Width = 200
                .ReadOnly = True
            End With


            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3})

            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try
    End Sub



    Public Sub CargagridPais(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "ARTICULO"
                .MappingName = "ARTICULO"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "STOCK"
                .MappingName = "STOCK"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "ALMACEN"
                .MappingName = "ALMACEN"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "MES"
                .MappingName = "MES"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "AÑO"
                .MappingName = "AÑO"
                .Width = 100
                .ReadOnly = True
            End With


            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try


    End Sub


    Public Sub CargagridMovi(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Descripcion"
                .MappingName = "Descripcion"
                .Width = 250
                .ReadOnly = True
            End With
            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try


    End Sub





    Public Sub CargagridGuia(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "NROGUIA"
                .MappingName = "NROGUIA"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "NROMOVI"
                .MappingName = "NROMOVI"
                .Width = 250
                .ReadOnly = True
            End With
            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try


    End Sub







    Public Function mensaje_ingreso() As Boolean

        'respuesta = (MessageBox.Show("Desea Ingresar Un Nuevo Registro", strempresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        'If respuesta = DialogResult.No Then
        'mensaje_ingreso = False
        'Else
        mensaje_ingreso = True
        'End If
    End Function

    Public Sub FACT_CargagridclienteFACT(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Cliente"
                .MappingName = "RazonSocial"
                .Width = 250
                .ReadOnly = True
            End With
            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Direccion"
                .MappingName = "direccion"
                .Width = 250
                .ReadOnly = True
            End With


            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3})
            grilla.TableStyles.Add(dgEstiloColumna)
            'cn.Dispose()
            'cmd.Dispose()
            'cn = Nothing
            'cmd = Nothing
        Catch ex As Exception
        End Try


    End Sub
    Public Sub FACT_Cargagriddetalledirectoserv(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA")
            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "ITEM"
                .MappingName = "ITEM"
                .Width = 60
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = ""
                .MappingName = "Codigo"
                .Width = 0
                .ReadOnly = True
            End With
            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Tipo de Servicio"
                .MappingName = "Descripcion"
                .Width = 450
                .ReadOnly = True
            End With
            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = ""
                .MappingName = "Medida"
                .Width = 0
                .ReadOnly = True
            End With
            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = ""
                .MappingName = "Cantidad"
                .Width = 0
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(0)
            End With
            Dim ColEStilo6 As New DataGridTextBoxColumn
            With ColEStilo6
                .HeaderText = ""
                .MappingName = "Precio"
                .Width = 0
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(0)
            End With
            Dim ColEStilo7 As New DataGridTextBoxColumn
            With ColEStilo7
                .HeaderText = "Total |"
                .MappingName = "Total"
                .Width = 70
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(0)
            End With
            Dim ColEStilo8 As New DataGridTextBoxColumn
            With ColEStilo8
                .HeaderText = "igv"
                .MappingName = "IGV"
                .Width = 0
                .ReadOnly = True
            End With
            Dim ColEStilo9 As New DataGridTextBoxColumn
            With ColEStilo9
                .HeaderText = ""
                .MappingName = "Descto"
                .Width = 0
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(0)
            End With

            Dim ColEStilo10 As New DataGridTextBoxColumn
            With ColEStilo10
                .HeaderText = ""
                .MappingName = "TIPOMEDIDA"
                .Width = 0
                .ReadOnly = True

            End With


            Dim ColEStilo11 As New DataGridTextBoxColumn
            With ColEStilo11
                .HeaderText = ""
                .MappingName = "FECDOCUM"
                .Width = 0
                .ReadOnly = True

            End With
            Dim ColEStilo12 As New DataGridTextBoxColumn
            With ColEStilo12
                .HeaderText = ""
                .MappingName = "NROIMPORTACION"
                .Width = 0
                .ReadOnly = True

            End With
            Dim ColEStilo13 As New DataGridTextBoxColumn
            With ColEStilo13
                .HeaderText = ""
                .MappingName = "frecibo"
                .Width = 0
                .ReadOnly = True

            End With

            Dim ColEStilo14 As New DataGridTextBoxColumn
            With ColEStilo14
                .HeaderText = ""
                .MappingName = "DESCANTIPO"
                .Width = 0
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
            End With



            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5, ColEStilo6, ColEStilo7, ColEStilo8, ColEStilo9, ColEStilo10, ColEStilo11, ColEStilo12, ColEStilo13, ColEStilo14})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try

    End Sub
    Public Function TmpListarDataset(ByVal sql As String) As DataSet
        Try
            If Cn.ConnectionString = String.Empty Then
                Cn.ConnectionString = STRCN
            End If

            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If
            Cn.Open()
            Dim cmd As New SqlCommand(sql, Cn)
            cmd.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataSet
            da.Fill(dt)
            Cn.Close()
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function FACT_mensaje_cancelar() As Boolean
        Dim respuesta As DialogResult
        respuesta = (MessageBox.Show("Seguro de Cancelar el Proceso", DesEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        If respuesta = DialogResult.No Then
            FACT_mensaje_cancelar = False
        Else
            FACT_mensaje_cancelar = True
        End If

    End Function
    Public Sub FACT_Cargagridpagovale(ByVal grilla As DataGrid, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "ITEM"
                .MappingName = "ITEM"
                .Width = 80
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "Referencia"
                .MappingName = "Referencia"
                .Width = 238
                .ReadOnly = True
            End With
            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "CDMONEDA"
                .MappingName = "CDMONEDA"
                .Width = 0
                .ReadOnly = True
            End With
            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "Moneda"
                .MappingName = "Moneda"
                .Width = 80
                .ReadOnly = True
            End With
            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "Total"
                .MappingName = "Total"
                .Width = 90
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Center
                .Format = FACT_GFormatodeNumero(0)
            End With

            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5})
            grilla.TableStyles.Add(dgEstiloColumna)
            'cn.Dispose()
            'cmd.Dispose()
            'cn = Nothing
            'cmd = Nothing
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function VERIFICA_CIERRE_PTOVTA_TODOS() As Boolean
        ' VERIFICO SI UN PUNTO DE VENTA FALTA HACER CIERRE Z 

        Dim DS As New DataSet

        DS = CAyuda.ListarDatos("SP_VERIFICA_CIERRE_PTOVTA_TODOS")
        If DS.Tables(0).Rows.Count > 0 Then
            VERIFICA_CIERRE_PTOVTA_TODOS = False ' FALTAN CERRAR PUNTOS
        Else
            VERIFICA_CIERRE_PTOVTA_TODOS = True ' PUNTOS CERRADOS
        End If

    End Function
    Public Function VERIFICA_CIERRE_PTOVTA() As Boolean
        'VERIFICA SI EL PUNTO DE VENTA PUEDE SER EL FIN DE DIA
        Dim SQL As String
        Dim DS As New DataSet
        Dim MAQUINA As String
        MAQUINA = Environment.MachineName

        SQL = "SP_PUNTOVTACIERRE '" & MAQUINA & "'"
        'MsgBox(MAQUINA)
        DS = TmpListarDataset(SQL)
        If DS.Tables(0).Rows.Count <= 0 Then
            VERIFICA_CIERRE_PTOVTA = False
            MessageBox.Show("Punto de Venta Desactivado Para Fin de Dia", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            VERIFICA_CIERRE_PTOVTA = True
        End If
    End Function
    Public Sub FACT_Cargagridpagotarjeta(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "ITEM"
                .MappingName = "ITEM"
                .Width = 80
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "CDTARJETA"
                .MappingName = "CDTARJETA"
                .Width = 0
                .ReadOnly = True
            End With
            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "Tarjeta"
                .MappingName = "Tarjeta"
                .Width = 238
                .ReadOnly = True
            End With
            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "CDMONEDA"
                .MappingName = "CDMONEDA"
                .Width = 0
                .ReadOnly = True
            End With
            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "Moneda"
                .MappingName = "Moneda"
                .Width = 80
                .ReadOnly = True
            End With
            Dim ColEStilo6 As New DataGridTextBoxColumn
            With ColEStilo6
                .HeaderText = "Total"
                .MappingName = "Total"
                .Width = 90
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Center
                .Format = FACT_GFormatodeNumero(0)
            End With

            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5, ColEStilo6})
            grilla.TableStyles.Add(dgEstiloColumna)
            'cn.Dispose()
            'cmd.Dispose()
            'cn = Nothing
            'cmd = Nothing
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Function VERIFICA_PTOVTA() As Boolean
        'VERIFICA SI SE REALIZO EL CIERRE Z POR EL PUNTO DE MAQUINA
        VERIFICA_PTOVTA = True
        'Exit Function
        'Dim sql1 As String = ""

        'Dim DS As New DataSet
        'sql1 = "SP_VERIFICA_NROPTOVTA '" & NROPTOVTA & "'"

        'DS = CAyuda.ListarDatos(sql1)

        'If DS.Tables(0).Rows.Count > 0 Then
        '    VERIFICA_PTOVTA = False
        '    MessageBox.Show("Ya se Realizo el Cierre de Este Punto", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Else
        '    VERIFICA_PTOVTA = True
        'End If
    End Function
    Public Function validanumerodoc(ByVal numero As Long, ByVal ruc As String) As Boolean
        Try
            Dim ndocumento As Long
            Dim sql As String = ""
            Dim cadenadoc As String = ""
            Dim Tipodoc As String = ""
            Dim cadexis As String = ""
            Dim codtipodoc As String = ""

            Dim ds As New DataSet
            Dim n, i, num, c As Long
            sql = "sp_sele_TMP_VENTADET " & VCorrelVta & ",'" & codempresa & "'"
            ds = TmpListarDataset(sql)
            n = ds.Tables(0).Rows.Count  ' OBTENGO EL NUMERO DEL DETALLE
            ds.Dispose()
            If Trim(ruc) = "" Then
                ndocumento = Math.Ceiling(n / ITEMDEBOLETA)
                Tipodoc = "Boletas "
                codtipodoc = "03"
            End If
            If Trim(ruc) <> "" Then
                ndocumento = Math.Ceiling(n / ITEMDEFACT)
                Tipodoc = "Facturas "
                codtipodoc = "01"
            End If
            ' obtengo el numero de documentos a generar
            num = numero
            For i = 1 To ndocumento
                sql = "select nrodocu from ventacab where nrodocu=" & num & "and codtipodoc='" & codtipodoc & "'"
                ds = TmpListarDataset(sql)

                cadenadoc = cadenadoc + Str(num) + "  , "
                If ds.Tables(0).Rows.Count > 0 Then
                    cadexis = cadexis + Str(num) + " , "
                    c = c + 1
                End If
                num = num + 1
            Next
            If c <> 0 Then
                MessageBox.Show("Se van  generar las Siguientes " & Tipodoc & " con los Numeros " & cadenadoc & " pero ya existen los siguientes numero " & cadexis & " Verifique la Base de Datos se procede a cancelar la Operacion ", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                validanumerodoc = False
            Else
                validanumerodoc = True
            End If
        Catch ex As Exception
        End Try
    End Function
    Public Function FACT_GValidaRUC(ByVal strRuc As String) As Boolean
        Try
            If Trim(Len(Trim(strRuc))) < 11 Then
                MessageBox.Show("Complete los Numeros del Ruc para Completar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                FACT_GValidaRUC = False
                Exit Function
            End If
            Dim intUltimoDigito As Integer
            Dim intDigitoVerifi As Integer
            Dim intVal1 As Integer
            Dim intVal2 As Integer
            Dim intResul As Integer
            Dim intD1 As Integer
            Dim intD2 As Integer
            Dim intD3 As Integer
            Dim intD4 As Integer
            Dim intD5 As Integer
            Dim intD6 As Integer
            Dim intD7 As Integer
            Dim intD8 As Integer
            Dim intD9 As Integer
            Dim intD10 As Integer
            FACT_GValidaRUC = False
            strRuc = Trim(strRuc)
            intUltimoDigito = CInt(Mid(strRuc, Len(strRuc), 1))
            intD10 = CInt(Mid(strRuc, Len(strRuc) - 1, 1))
            intD9 = CInt(Mid(strRuc, Len(strRuc) - 2, 1))
            intD8 = CInt(Mid(strRuc, Len(strRuc) - 3, 1))
            intD7 = CInt(Mid(strRuc, Len(strRuc) - 4, 1))
            intD6 = CInt(Mid(strRuc, Len(strRuc) - 5, 1))
            intD5 = CInt(Mid(strRuc, Len(strRuc) - 6, 1))
            intD4 = CInt(Mid(strRuc, Len(strRuc) - 7, 1))
            intD3 = CInt(Mid(strRuc, Len(strRuc) - 8, 1))
            intD2 = CInt(Mid(strRuc, Len(strRuc) - 9, 1))
            intD1 = CInt(Mid(strRuc, Len(strRuc) - 10, 1))
            intVal1 = 5 * intD1 + 4 * intD2 + 3 * intD3 + 2 * intD4 + 7 * intD5 + 6 * intD6 + 5 * intD7 + 4 * intD8 + 3 * intD9 + 2 * intD10
            intVal2 = intVal1 \ 11
            intResul = 11 - (intVal1 - (intVal2 * 11))
            If intResul = 10 Then
                intDigitoVerifi = 0
            Else
                If intResul = 11 Then
                    intDigitoVerifi = 1
                Else
                    intDigitoVerifi = intResul
                End If
            End If
            If intDigitoVerifi = intUltimoDigito Then
                FACT_GValidaRUC = True
            End If
            If FACT_GValidaRUC = False Then
                MessageBox.Show("Ruc Invalido Verifique para completar el proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
        End Try
    End Function
    Public Sub CARGAPERMISOSUSUARIO(ByVal USUARIO As String)
        USUARIO = Trim(USUARIO)
        Dim Dt1 As New DataTable, SQL As String
        SQL = "SP_PERMISOPROCESO '" & codempresa & "','" & USUARIO & "','CONTROLAIGV'"
        Dt1 = TmpListarDatos(SQL)
        If Dt1.Rows.Count > 0 Then

        End If
        'FACT_CONTROLAIGV = True


    End Sub
    Public Sub FACT_Cargagriddetalledirecto(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cmd.Dispose()
            cn.Dispose()
            cn.Close()
            cmd = Nothing
            cn = Nothing

            grilla.TableStyles.Clear()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
                .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "ITEM"
                .MappingName = "ITEM"
                .Width = 60
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "CODIGO"
                .MappingName = "CODIGO"
                .Width = 80
                .ReadOnly = True
            End With
            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "ARTICULO"
                .MappingName = "DESCRIPCION"
                .Width = 200
                .ReadOnly = True
            End With
            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "PRESENTACION"
                .MappingName = "PRESENTACION"
                .Width = 80
                .ReadOnly = True
            End With
            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "CANTIDAD |"
                .MappingName = "CANTIDAD"
                .Width = 70
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(DECIRESU)
            End With
            Dim ColEStilo6 As New DataGridTextBoxColumn
            With ColEStilo6
                .HeaderText = "PRECIO | "
                .MappingName = "PRECIO"
                .Width = 70
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(DECIRESU)
            End With
            Dim ColEStilo7 As New DataGridTextBoxColumn
            With ColEStilo7
                .HeaderText = "TOTAL |"
                .MappingName = "TOTAL"
                .Width = 70
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(DECIRESU)

            End With
            Dim ColEStilo8 As New DataGridTextBoxColumn
            With ColEStilo8
                .HeaderText = "IGV"
                .MappingName = "IGV"
                .Width = 0
                .ReadOnly = True
                .Format = FACT_GFormatodeNumero(DECIRESU)
            End With
            Dim ColEStilo9 As New DataGridTextBoxColumn
            With ColEStilo9
                .HeaderText = "DESCTO |"
                .MappingName = "DESCTO"
                .Width = 50
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(DECIRESU)
            End With

            Dim ColEStilo10 As New DataGridTextBoxColumn
            With ColEStilo10
                .HeaderText = "TIPOMEDIDA |"
                .MappingName = "TIPOMEDIDA"
                .Width = 0
                .ReadOnly = True

            End With


            Dim ColEStilo11 As New DataGridTextBoxColumn
            With ColEStilo11
                .HeaderText = "FECHADOCUMENTO"
                .MappingName = "FECDOCUM"
                .Width = 0
                .ReadOnly = True

            End With
            Dim ColEStilo12 As New DataGridTextBoxColumn
            With ColEStilo12
                .HeaderText = "NROIMPORTACION |"
                .MappingName = "NROIMPORTACION"
                .Width = 0
                .ReadOnly = True

            End With
            Dim ColEStilo13 As New DataGridTextBoxColumn
            With ColEStilo13
                .HeaderText = "FRECIBO"
                .MappingName = "FRECIBO"
                .Width = 0
                .ReadOnly = True

            End With

            Dim ColEStilo14 As New DataGridTextBoxColumn
            With ColEStilo14
                .HeaderText = "BULTOS"
                .MappingName = "DESCANTIPO"
                .Width = 100
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
            End With



            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5, ColEStilo6, ColEStilo7, ColEStilo8, ColEStilo9, ColEStilo10, ColEStilo11, ColEStilo12, ColEStilo13, ColEStilo14})
            grilla.TableStyles.Add(dgEstiloColumna)

        Catch ex As Exception
            MsgBox(ex.Message + Chr(13) + ex.Source, MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
        End Try

    End Sub
    Public Sub FACT_Cargagrid(ByVal grilla As Object, ByVal store_procedure As String)
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cmd.Dispose()
            cn.Dispose()
            cn.Close()
            cmd = Nothing
            cn = Nothing
            grilla.DataSource = DS.Tables("MITABLA").DefaultView

        Catch ex As Exception
        End Try
    End Sub
    Public Sub Limpiatextbox(ByVal frm As Form)
        Dim ctrtextbox As Object
        For Each ctrtextbox In frm.Controls
            If TypeOf ctrtextbox Is TextBox Then
                ctrtextbox.text = ""
            End If
            If TypeOf ctrtextbox Is GroupBox Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrtextbox.CONTROLS
                    If TypeOf OBJTEXT Is TextBox Then
                        OBJTEXT.TEXT = ""
                    End If
                    If TypeOf OBJTEXT Is GroupBox Then
                        Dim OBJTEXT2 As Object
                        For Each OBJTEXT2 In OBJTEXT.CONTROLS
                            If TypeOf OBJTEXT2 Is TextBox Then
                                OBJTEXT2.TEXT = String.Empty
                            End If
                        Next
                    End If
                Next

            End If

        Next
    End Sub
    Public Sub desbloqueatextbox(ByVal frm As Form)
        Dim ctrtextbox, ctrcombo As Object
        For Each ctrtextbox In frm.Controls
            If TypeOf ctrtextbox Is TextBox Then
                ctrtextbox.ReadOnly = False
            End If

            If TypeOf ctrtextbox Is GroupBox Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrtextbox.CONTROLS
                    If TypeOf OBJTEXT Is TextBox Then
                        OBJTEXT.ReadOnly = False
                    End If
                    If TypeOf OBJTEXT Is GroupBox Then
                        Dim OBJTEXT2 As Object
                        For Each OBJTEXT2 In OBJTEXT.CONTROLS
                            If TypeOf OBJTEXT2 Is TextBox Then
                                OBJTEXT2.ReadOnly = False
                            End If
                        Next
                    End If
                Next
            End If
        Next
        For Each ctrcombo In frm.Controls
            If TypeOf ctrcombo Is ComboBox Then
                ctrcombo.enabled = True
            End If

            If TypeOf ctrcombo Is GroupBox Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrcombo.CONTROLS
                    If TypeOf OBJTEXT Is ComboBox Then
                        OBJTEXT.enabled = True
                    End If
                Next

            End If
        Next
    End Sub
    Public Function NumerosDecimales(ByVal Keyascii As Short) As Short
        Keyascii = Asc(UCase(Chr(Keyascii)))
        If (InStr("1234567890.", Chr(Keyascii)) = 0) Then
            NumerosDecimales = 0
        Else
            NumerosDecimales = Keyascii
        End If
        'backspace
        If Keyascii = 8 Then NumerosDecimales = Keyascii
        'enter
        If Keyascii = 13 Then NumerosDecimales = Keyascii
    End Function
    Public Sub Bloqueatextbox(ByVal frm As Form)
        Dim ctrtextbox, ctrcombo As Object
        For Each ctrtextbox In frm.Controls
            If TypeOf ctrtextbox Is TextBox Then
                ctrtextbox.ReadOnly = True
            End If
            If TypeOf ctrtextbox Is GroupBox Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrtextbox.CONTROLS
                    If TypeOf OBJTEXT Is TextBox Then
                        OBJTEXT.ReadOnly = True
                        'objTEXT.BACKcOLOR = Color.White
                    End If
                    If TypeOf OBJTEXT Is GroupBox Then
                        Dim OBJTEXT2 As Object
                        For Each OBJTEXT2 In OBJTEXT.CONTROLS
                            If TypeOf OBJTEXT2 Is TextBox Then
                                OBJTEXT2.ReadOnly = True
                                'OBJTEXT2.BACKcOLOR = Color.White
                            End If
                        Next
                    End If
                Next
            End If

            If TypeOf ctrtextbox Is TabPage Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrtextbox.CONTROLS
                    If TypeOf OBJTEXT Is TextBox Then
                        OBJTEXT.ReadOnly = True
                    End If
                Next

            End If
        Next



        For Each ctrcombo In frm.Controls
            If TypeOf ctrcombo Is ComboBox Then
                ctrcombo.enabled = False
            End If


            If TypeOf ctrcombo Is GroupBox Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrcombo.CONTROLS
                    If TypeOf OBJTEXT Is ComboBox Then
                        OBJTEXT.enabled = False
                    End If
                Next

            End If

            If TypeOf ctrcombo Is TabControl Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrcombo.CONTROLS
                    If TypeOf OBJTEXT Is ComboBox Then
                        OBJTEXT.enabled = False
                    End If
                Next

            End If
        Next

    End Sub
    Public Function GValidarVacios(ByVal IVarDato As Object) As Object
        If IVarDato = "" Then
            GValidarVacios = 0
        Else
            GValidarVacios = IVarDato
        End If
    End Function
    Public Function GVDATOVACIO(ByVal IVarDato As Object) As String
        IVarDato = Trim(UCase(GValidarVacios(IVarDato)))
        GVDATOVACIO = IVarDato
    End Function
    Public Sub quita_maxi_min_form(ByVal frm As Form)
        frm.MaximizeBox = False
    End Sub
    Public Function FACT_GFormatodeNumero(ByVal Valor As Double) As Object
        FACT_GFormatodeNumero = Format(Valor, "#######0.00")
    End Function
    Public Sub formatotextbox(ByVal frm As Form)
        Dim ctrtextbox As Object
        For Each ctrtextbox In frm.Controls
            If TypeOf ctrtextbox Is TextBox Then
                ctrtextbox.Text = Trim(StrConv(ctrtextbox.Text, 3))
            End If

            If TypeOf ctrtextbox Is GroupBox Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrtextbox.CONTROLS
                    If TypeOf OBJTEXT Is TextBox Then
                        OBJTEXT.TEXT = Trim(StrConv(OBJTEXT.Text, 3))
                    End If
                Next

            End If

            If TypeOf ctrtextbox Is TabControl Then
                Dim OBJTEXT As Object
                For Each OBJTEXT In ctrtextbox.CONTROLS
                    If TypeOf OBJTEXT Is TextBox Then
                        OBJTEXT.TEXT = Trim(StrConv(OBJTEXT.Text, 3))
                    End If
                Next

            End If

        Next
    End Sub
    Public Function mensaje_cancelar() As Boolean
        Dim respuesta As DialogResult
        respuesta = (MessageBox.Show("Seguro de Cancelar el Proceso", DesEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        If respuesta = DialogResult.No Then
            mensaje_cancelar = False
        Else
            mensaje_cancelar = True
        End If

    End Function
    Public Function FACT_TotalLetras(ByVal nume As Double, ByVal TMONEDA As String) As String
        '------------------------------------
        '  nume    : Cifra (incluye decimales)
        '  TMONEDA : Texto que debe indicar la moneda ("Nuevos Soles","Dolares")
        '------------------------------------
        Dim c1 As String = ""
        Dim c2 As String = ""
        Dim c3 As String = ""
        Dim c4 As String = ""
        Dim z1 As String = ""
        Dim xdec As String = ""
        Dim xcad_dec As String = ""
        Dim d As String = ""
        Dim c As String = ""
        Dim cifra As String = ""
        Dim s As String = ""
        Dim sys As String = ""
        Dim u As String = ""
        Dim z As String = ""
        Dim xlg As Double
        Dim k, n, y As Integer

        xlg = 12 - Len(Trim(CStr(Int(nume))))
        z1 = Space(xlg) & Trim(CStr(Int(nume)))
        xdec = Right(Format(nume - Int(nume), "#0.00"), 2)
        xcad_dec = " Y " + xdec + "/100"

        k = 1
        y = 10
        n = 3
        Do While k <= 4
            z = Mid(z1, y, 3)
            s = Mid(z, n, 1)
            If s = "1" Then
                u = "UNO"
                If k = 2 Or k = 3 Then
                    u = "UN"
                End If
            Else
                u = IIf(s = "2", "DOS", IIf(s = "3", "TRES", IIf(s = "4", "CUATRO",
                    IIf(s = "5", "CINCO", IIf(s = "6", "SEIS", IIf(s = "7", "SIETE",
                    IIf(s = "8", "OCHO", IIf(s = "9", "NUEVE", ""))))))))
            End If

            If Mid(z, n - 1, 1) = "1" Then
                If Mid(z, n, 1) = "0" Then
                    d = "DIEZ"
                Else
                    If Mid(z, n, 1) = "1" Then
                        d = "ONCE"
                        u = ""
                    Else
                        If Mid(z, n, 1) = "2" Then
                            d = "DOCE"
                            u = ""
                        Else
                            If Mid(z, n, 1) = "3" Then
                                d = "TRECE"
                                u = ""
                            Else
                                If Mid(z, n, 1) = "4" Then
                                    d = "CATORCE"
                                    u = ""
                                Else
                                    If Mid(z, n, 1) = "5" Then
                                        d = "QUINCE"
                                        u = ""
                                    Else
                                        d = "DIECI"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                If Mid(z, n - 1, 1) = "2" Then
                    If Mid(z, n, 1) = "0" Then
                        d = "VEINTE"
                    Else
                        d = "VEINTE Y "
                    End If
                Else
                    If Mid(z, n - 1, 1) = "3" Then
                        If Mid(z, n, 1) = "0" Then
                            d = "TREINTA"
                        Else
                            d = "TREINTA Y "
                        End If
                    Else
                        If Mid(z, n - 1, 1) = "4" Then
                            If Mid(z, n, 1) = "0" Then
                                d = "CUARENTA"
                            Else
                                d = "CUARENTA Y "
                            End If
                        Else
                            If Mid(z, n - 1, 1) = "5" Then
                                If Mid(z, n, 1) = "0" Then
                                    d = "CINCUENTA"
                                Else
                                    d = "CINCUENTA Y "
                                End If
                            Else
                                If Mid(z, n - 1, 1) = "6" Then
                                    If Mid(z, n, 1) = "0" Then
                                        d = "SESENTA"
                                    Else
                                        d = "SESENTA Y "
                                    End If
                                Else
                                    If Mid(z, n - 1, 1) = "7" Then
                                        If Mid(z, n, 1) = "0" Then
                                            d = "SETENTA"
                                        Else
                                            d = "SETENTA Y "
                                        End If
                                    Else
                                        If Mid(z, n - 1, 1) = "8" Then
                                            If Mid(z, n, 1) = "0" Then
                                                d = "OCHENTA"
                                            Else
                                                d = "OCHENTA Y "
                                            End If
                                        Else
                                            If Mid(z, n - 1, 1) = "9" Then
                                                If Mid(z, n, 1) = "0" Then
                                                    d = "NOVENTA"
                                                Else
                                                    d = "NOVENTA Y "
                                                End If
                                            Else
                                                d = ""
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If Mid(z, n - 2, 1) = "1" Then
                If Mid(z, n - 1, 1) = "0" And Mid(z, n, 1) = "0" Then
                    c = "CIEN"
                Else
                    c = "CIENTO"
                End If
            Else
                If Mid(z, n - 2, 1) = "2" Then
                    c = "DOSCIENTOS"
                Else
                    If Mid(z, n - 2, 1) = "3" Then
                        c = "TRESCIENTOS"
                    Else
                        If Mid(z, n - 2, 1) = "4" Then
                            c = "CUATROCIENTOS"
                        Else
                            If Mid(z, n - 2, 1) = "5" Then
                                c = "QUINIENTOS"
                            Else
                                If Mid(z, n - 2, 1) = "6" Then
                                    c = "SEISCIENTOS"
                                Else
                                    If Mid(z, n - 2, 1) = "7" Then
                                        c = "SETECIENTOS"
                                    Else
                                        If Mid(z, n - 2, 1) = "8" Then
                                            c = "OCHOCIENTOS"
                                        Else
                                            If Mid(z, n - 2, 1) = "9" Then
                                                c = "NOVECIENTOS"
                                            Else
                                                c = ""
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            Select Case k
                Case 1
                    c1 = c + " " + d + u
                Case 2
                    c2 = c + " " + d + u
                Case 3
                    c3 = c + " " + d + u
                Case 4
                    c4 = c + " " + d + u
            End Select
            k = k + 1
            y = y - 3
        Loop
        If (Len(c4) - 1) <> 0 Then
            If c4 = "UN" Then
                sys = " MILLON "
            Else
                sys = " MILLONES "
            End If
            cifra = c4 + " MIL " + c3 + sys + c2 + " MIL " + c1
        Else
            If (Len(c3) - 1) <> 0 Then
                If c3 = "UN" Then
                    sys = " MILLON "
                Else
                    sys = " MILLONES "
                End If
                cifra = c3 + sys + c2 + " MIL " + c1
            Else
                If (Len(c2) - 1) <> 0 Then
                    cifra = c2 + " MIL " + c1
                Else
                    If Len(c1) <> 0 Then
                        cifra = c1
                    End If
                End If
            End If
        End If
        TMONEDA = " " + TMONEDA

        FACT_TotalLetras = Trim(cifra + xcad_dec + TMONEDA)
    End Function
    Public Function OBTENCORREL_VTA()
        Dim SQL As String
        Dim DS As New DataTable
        Dim Correl As Double
        SQL = "ObtenerCorrelativoProcUtil '" & CodUsuario & "'"
        DS = TmpListarDatos(SQL)
        Correl = DS.Rows(0)(0)
        Return Correl
    End Function
    Public Function OBTENCORREL_INVENTARIO()
        Dim Correl As Double
        Dim SQL As String
        Dim DS As New DataTable
        SQL = "ObtenerCorrelInventario '" & CodUsuario & "'"
        DS = TmpListarDatos(SQL)
        Correl = DS.Rows(0)(0)
        Return Correl
    End Function
    Public Function ObtenerNroDocXabrv(ByVal ABRV As String) As String
        If ABRV = "BOLETA DE VENTA" Then
            ABRV = "BV"
        ElseIf ABRV = "FACTURA" Then
            ABRV = "FV"
        Else
            ABRV = "NP"
        End If
        Dim tableDocumento As New DataTable
        tableDocumento = TmpListarDatos("NSP_NRODOC_PTOVTA '" & codempresa & "','" & NROPTOVTA & "','" & ABRV & "' ")
        Return tableDocumento.Rows(0)(0).ToString.Trim
    End Function
    Public Function ObtenerNroDeFilas2(ByVal CODTIPODOC As String) As Integer
        Dim ITEM As Integer
        Dim TABLE_ITEM As New DataTable
        TABLE_ITEM = TmpListarDatos("SELECT   ITEMDEFACT, ITEMDEBOLETA,ITEMDENTAPEDIDO FROM    CONFIGVTA ")

        If CODTIPODOC.Trim = "01" Then
            ITEM = TABLE_ITEM.Rows(0)("ITEMDEFACT").ToString
        ElseIf CODTIPODOC.Trim = "03" Then
            ITEM = TABLE_ITEM.Rows(0)("ITEMDEBOLETA").ToString
        ElseIf CODTIPODOC.Trim = "06" Then
            ITEM = TABLE_ITEM.Rows(0)("ITEMDENTAPEDIDO").ToString
        End If
        Return ITEM
    End Function

    Public Function ObtenerNroDocX(ByVal CODTIPODOC As String) As String
        Dim tableDocumento As New DataTable
        Dim NRODOCUMENTO As String = String.Empty
        tableDocumento = TmpListarDatos("NSP_BUSQUEDA_NROPTOVTA '" & codempresa & "','" & NROPTOVTA & "' ")
        If CODTIPODOC = "01" Then
            NRODOCUMENTO = tableDocumento.Rows(0)("NROTICKFAC").ToString.Trim
        ElseIf CODTIPODOC = "03" Then
            NRODOCUMENTO = tableDocumento.Rows(0)("NROTICKBOL").ToString.Trim
        ElseIf CODTIPODOC = "06" Then
            NRODOCUMENTO = tableDocumento.Rows(0)("NROPEDIDO").ToString.Trim
        End If
        Return NRODOCUMENTO.Trim
    End Function

    Public Function ObtenerPtoVta(ByVal STRTERMINAL As String) As String
        Dim TablePtovta As New DataTable
        TablePtovta = TmpListarDatos("SELECT  * FROM  PTOVTA  WHERE TERMINAL='" & STRTERMINAL & "'")
        NROPTOVTA = TablePtovta.Rows(0)("NROPTOVTA").ToString.Trim
        Return NROPTOVTA
    End Function

    Public Sub CargaVariablesGlobales()

        Dim TblCfvta As New DataTable
        Dim TblCfgSis As New DataTable
        Dim TblPtoVta As New DataTable
        Dim TblCtaCte As New DataTable
        Dim TableCambio As New DataTable

        Try
            TblCfvta = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGVTA", codempresa).Tables(0)
            IDIMPIGV = TblCfvta.Rows(0)("IDIMPIGV")
            IDIMPISC = TblCfvta.Rows(0)("IDIMPISC")
            CDTICKET = Trim(TblCfvta.Rows(0)("CDTICKET"))
            CDFACTURA = Trim(TblCfvta.Rows(0)("CDFACTURA"))
            CDBOLETA = Trim(TblCfvta.Rows(0)("CDBOLETA"))
            CDNTACREDP = Trim(TblCfvta.Rows(0)("CDNTACREDP"))
            CDNTAPEDIDO = Trim(TblCfvta.Rows(0)("CDNTAPEDIDO"))
            ITEMDEGUIA = TblCfvta.Rows(0)("ITEMDEGUIA")
            NTACRED_INS_CUENTA_CLIE = TblCfvta.Rows(0)("NTACRED_INS_CUENTA_CLIE")
            DURACION_PEDIDO = TblCfvta.Rows(0)("DURACION_PEDIDO")
            ITEMDEFACT = TblCfvta.Rows(0)("ITEMDEFACT")
            ITEMDEBOLETA = TblCfvta.Rows(0)("ITEMDEBOLETA")
            ITEMDENOTACRED = TblCfvta.Rows(0)("ITEMDENOTACRED")
            ITEMDENTAPEDIDO = TblCfvta.Rows(0)("ITEMDENTAPEDIDO")
            VCdPagEfectivo = TblCfvta.Rows(0)("CDPAGEFECTIVO")
            VCdPagCredito = TblCfvta.Rows(0)("CDPAGCREDITO")
            VCODRETENCION = TblCfvta.Rows(0)("CODRETENCION")
            VCODPERCEPCION = TblCfvta.Rows(0)("CODPERCEPCION")
            VCODNEXTEL = TblCfvta.Rows(0)("CODNEXTEL")

            VCorrelVta = OBTENCORREL_VTA()
            VCorrelInv = OBTENCORREL_INVENTARIO()

            TblCfgSis = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGSIS", codempresa).Tables(0)
            CDMONBASE = TblCfgSis.Rows(0)("CDMONBASE")
            FACT_CDMONEDA = CDMONBASE
            DECICANT = TblCfgSis.Rows(0)("DECICANT")
            DECICOST = TblCfgSis.Rows(0)("DECICOST")
            DECIPREC = TblCfgSis.Rows(0)("DECIPREC")
            DECIRESU = TblCfgSis.Rows(0)("DECIRESU")
            FECHAPROC = TblCfgSis.Rows(0)("FECHAPROC")
            PORCIGV = TblCfgSis.Rows(0)("PORCENIGV")
            ACTIVABD = TblCfgSis.Rows(0)("ACTIVABD")
            ACTIVACAJA = TblCfgSis.Rows(0)("ACTICAJA")
            LIMCREDITO = TblCfgSis.Rows(0)("LIMCREDTO")
            COEFICIENT = TblCfgSis.Rows(0)("COEFICIENTE")
            PREC_BOLETA = TblCfgSis.Rows(0)("PREC_BOLETA")
            PREC_FACTURA = TblCfgSis.Rows(0)("PREC_FACTURA")
            PREC_NOTAPEDIDO = TblCfgSis.Rows(0)("PREC_NOTAPEDIDO")
            PORCDESC = TblCfgSis.Rows(0)("porcDescuento")
            MARGENDESC = TblCfgSis.Rows(0)("MARGENMIN")
            TIPODESC = TblCfgSis.Rows(0)("TIPODESC")
            CANT_DIAS_ADE = TblCfgSis.Rows(0)("DiaCStk")
            TIPOOPERACION = TblCfgSis.Rows(0)("TIPOOPERACION")
            DOMICILIOFISCAL = TblCfgSis.Rows(0)("CODDOMFISCAL")
            RUTAARCHIVO = TblCfgSis.Rows(0)("RUTA_ARCHIVO")
            EMIELECTRONIC = TblCfgSis.Rows(0)("EMIFACT")
            RESOLUCION = TblCfgSis.Rows(0)("resolucion")
            URL = TblCfgSis.Rows(0)("consulta")
            ' CODCASH = TblCfgSis.Rows(0)("CodHash")
            UBIGUEO = TblCfgSis.Rows(0)("UBIGEO")
            CORREO = TblCfgSis.Rows(0)("CORREO")
            CANT_F = TblCfgSis.Rows(0)("CERTELECT")
            IMP = TblCfgSis.Rows(0)("SALIDAIMP")
            MARGENDESC_PORC = TblCfgSis.Rows(0)("MARGENMIN_PD")
            NOSERIE = TblCfgSis.Rows(0)("NOSERIE")
            CODLOCAL = TblCfgSis.Rows(0)("CodLocal")
            FACTPTOVTA = TblCfgSis.Rows(0)("FACTPTOVTA")
            FACTLINEA = TblCfgSis.Rows(0)("FACTLINEA")
            FACTSUBEMP = TblCfgSis.Rows(0)("FACTSUBEMP")
            FACTSUBEMPHU = TblCfgSis.Rows(0)("FACTSUBEMPHU")
            FACTSUPERVHU = TblCfgSis.Rows(0)("FACTSUPERVPHU")
            TblPtoVta = CAyuda.ListarDatos("SP_SELECTPTOVTA", codempresa, Environment.MachineName).Tables(0)
            NROPTOVTA = TblPtoVta.Rows(0)("NROPTOVTA")
            CDZONA = TblPtoVta.Rows(0)("CDZONA").ToString.Trim
            CDTIPOPRE1 = TblPtoVta.Rows(0)("CDTIPOPRE1").ToString.Trim
            PPPUNTOVENTA = TblPtoVta.Rows(0)("CPTOVENTA")
            PPFUERZVENTA = TblPtoVta.Rows(0)("CFUERZAVENT")
            FACT_EDITPRECIO = TblPtoVta.Rows(0)("EDITPRECIO")
            VEEIDTFECHA = TblPtoVta.Rows(0)("EDITFECHA")
            CLIENTEPTOVTA = TblPtoVta.Rows(0)("CLIENTEVARIOS")
            CHECKCLIPTOVTA = TblPtoVta.Rows(0)("CHECKCLIE")
            CHECKPROMO = TblPtoVta.Rows(0)("CHECKCLIE")
            'RUTAPRN = TblPtoVta.Rows(0)("rutaprn")

            TblCtaCte = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGCTACTE", codempresa).Tables(0)
            CODFECTIVO = TblCtaCte.Rows(0)("CODFECTIVO")
            CODDEPBAN = TblCtaCte.Rows(0)("CODDEPBAN")
            CODCHEQUE = TblCtaCte.Rows(0)("CODCHEQUE")
            CODCHEQUEDIF = TblCtaCte.Rows(0)("CODCHEQUEDIF")
            CODTRAN = TblCtaCte.Rows(0)("CODTRAN")

            TableCambio = TmpListarDatos("SELECT  TOP 1 TVENTA,TCOMPRA  FROM   CAMBIO  WHERE CODEMPRESA='" & codempresa & "' ORDER BY FECHA  DESC  ")

            ' CAyuda.ListarDatos("NSP_SELCT_SELECIONACAMBIO", cdmonbase).Tables(0)
            If TableCambio.Rows.Count = 0 Then
                MsgBox("- Falta Ingresar el tipo de cambio.", MsgBoxStyle.Information, "NARSISTEMAS")
            Else
                VCambioVta = FormatoMonto(CDbl(TableCambio.Rows(0)("TVENTA").ToString), DECIRESU)
                VCambioCompra = FormatoMonto(CDbl(TableCambio.Rows(0)("tcompra")), DECIRESU)
            End If

            'DesUsuario = TmpListarDatos("Select  CodUsuario from CodUsuario where codempresa='" & codempresa & "' and cdusuario='" & CodUsuario & "'").Rows(0)(0).ToString.Trim

            Dim TableInv As New DataTable
            TableInv = CAyuda.ListarDatos("NSP_SELECT_LISTACONFIGINV", codempresa).Tables(0)
            FECHA_INV = TableInv.Rows(0)("FECHA_INV")
            VCODINGCOMP = TableInv.Rows(0)("CDINGCOMP")
            CDSALNTACRED = TableInv.Rows(0)("CDSALNTACRED").ToString.Trim
            Fecha_Actual()

            Conecta("select * from  EMPRESA ", "T")
            RucEmpresa = Trim(ds.Tables("T").Rows(0)(2).ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Function Fecha_Actual() As Date
        vFechaActual = CType(CAyuda.ListarDatos("SP_DATE_HOUR").Tables(0).Rows(0)(0), Date)
        Return vFechaActual
    End Function

    Public Function FormatoMonto(ByVal Monto As Double, ByVal NroDecimales As Integer) As String
        Dim valor As String = ""
        Select Case NroDecimales
            Case 0
                valor = Format(Monto, "#######0")
            Case 1
                valor = Format(Monto, "#######0.0")
            Case 2
                valor = Format(Monto, "#######0.00")
            Case 3
                valor = Format(Monto, "#######0.000")
            Case 4
                valor = Format(Monto, "#######0.0000")
            Case 5
                valor = Format(Monto, "#######0.00000")
            Case 6
                valor = Format(Monto, "#######0.000000")
            Case 7
                valor = Format(Monto, "#######0.0000000")
            Case 8
                valor = Format(Monto, "#######0.00000000")
        End Select
        Return valor

    End Function

    Public Function GMascaraDec_D(ByVal Monto As Double) As String
        Dim valor As String = ""
        Select Case CType(DECIRESU, Int32)
            Case 0
                valor = Format(Monto, "#######0")
            Case 1
                valor = Format(Monto, "#######0.0")
            Case 2
                valor = Format(Monto, "#######0.00")
            Case 3
                valor = Format(Monto, "#######0.000")
            Case 4
                valor = Format(Monto, "#######0.0000")
            Case 5
                valor = Format(Monto, "#######0.00000")
            Case 6
                valor = Format(Monto, "#######0.000000")
            Case 7
                valor = Format(Monto, "#######0.0000000")
            Case 8
                valor = Format(Monto, "#######0.00000000")
        End Select
        Return valor

    End Function

    Public Function GMascaraDec(ByVal AIntNDeci As Integer) As String
        Dim IintNumerodeDecimales As Integer
        IintNumerodeDecimales = AIntNDeci
        GMascaraDec = ""
        Select Case IintNumerodeDecimales
            Case 0
                GMascaraDec = "#######0"
            Case 1
                GMascaraDec = "#######0.0"
            Case 2
                GMascaraDec = "#######0.00"
            Case 3
                GMascaraDec = "#######0.000"
            Case 4
                GMascaraDec = "#######0.0000"
            Case 5
                GMascaraDec = "#######0.00000"
            Case 6
                GMascaraDec = "#######0.000000"
            Case 7
                GMascaraDec = "#######0.0000000"
            Case 8
                GMascaraDec = "#######0.00000000"
        End Select
    End Function

    Public Sub GenerarNroDocCot(Optional ByVal rb As Boolean = False)

        Dim dt As DataTable
        dt = TmpListarDatos("NSP_BUSCAR_NRODOC_COTIZACION  '" & codempresa & "'")
        If dt.Rows.Count > 0 Then
            VNroDoc = dt.Rows(0)(0)
        Else
            MsgBox("Falta Configurar el PtoVta...", MsgBoxStyle.Exclamation, "")
            End
        End If

    End Sub

    Public Sub GenerarNroDoc(Optional ByVal rb As Boolean = False)

        Dim dt As DataTable
        dt = TmpListarDatos("NSP_BUSCAR_NRODOC  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
        If dt.Rows.Count > 0 Then
            VNroDoc = dt.Rows(0)(0)
        Else
            MsgBox("Falta Configurar el PtoVta...", MsgBoxStyle.Exclamation, "")
            End
        End If

    End Sub

    Public Sub GenerarNroDoc2(Optional ByVal rb As Boolean = False)

        If rb = False Then
            If VUsarNotaPedido = True Then
                VCdTipoDoc = CDNTAPEDIDO
            Else
                If VRuc = "" Then
                    VCdTipoDoc = CDBOLETA
                Else
                    VCdTipoDoc = CDFACTURA
                End If
            End If
        End If

        Dim dt As DataTable
        dt = TmpListarDatos("NSP_BUSCAR_NRODOC  '" & codempresa & "','" & NROPTOVTA & "','" & VCdTipoDoc & "'")
        If dt.Rows.Count > 0 Then
            VNroDoc = dt.Rows(0)(0)
        Else
            MsgBox("Falta Configurar el PtoVta...", MsgBoxStyle.Exclamation, "")
            End
        End If

    End Sub

    Public Sub CargagridRETENEMIPROVCAB(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "NUMERO DOC"
                .MappingName = "NRONTARETEN"
                .Width = 80
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "PROVEERDOR"
                .MappingName = "DESPROVEE"
                .Width = 190
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "R.U.C"
                .MappingName = "RUCPROVEE"
                .Width = 190
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "DIRECCION"
                .MappingName = "DIRPROVEE"
                .Width = 90
                .ReadOnly = True
            End With

            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "FECHA DOCU"
                .MappingName = "FECDOCUM"
                .Width = 90
                .ReadOnly = True
            End With


            Dim ColEStilo6 As New DataGridTextBoxColumn
            With ColEStilo6
                .HeaderText = "ESTADO"
                .MappingName = "ESTADO"
                .Width = 90
                .ReadOnly = True
            End With

            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5, ColEStilo6})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try

    End Sub

    Public Sub CargagridRETENEMIPROVDET(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String


            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "TIPODOC"
                .MappingName = "TIPODOC"
                .Width = 150
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "SERIE"
                .MappingName = "SERIE"
                .Width = 70
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "CORRELATIVO"
                .MappingName = "CORRELATIVO"
                .Width = 100
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "FECEMISION"
                .MappingName = "FECEMISION"
                .Width = 90
                .ReadOnly = True
            End With

            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "MONTOPAGBAS"
                .MappingName = "MONTOPAGBAS"
                .Width = 90
                .ReadOnly = True
            End With

            Dim ColEStilo6 As New DataGridTextBoxColumn
            With ColEStilo6
                .HeaderText = "MONTOPAGEXT"
                .MappingName = "MONTOPAGEXT"
                .Width = 0
                .ReadOnly = True
            End With

            Dim ColEStilo7 As New DataGridTextBoxColumn
            With ColEStilo7
                .HeaderText = "MONTORETBAS"
                .MappingName = "MONTORETBAS"
                .Width = 90
                .ReadOnly = True
            End With

            Dim ColEStilo8 As New DataGridTextBoxColumn
            With ColEStilo8
                .HeaderText = "MONTORETEXT"
                .MappingName = "MONTORETEXT"
                .Width = 0
                .ReadOnly = True
            End With

            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5, ColEStilo6, ColEStilo7, ColEStilo8})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try

    End Sub

    Public Sub CargagridPERCEPEMIPROVCAB(ByVal grilla As Object, ByVal store_procedure As String)
        Dim vNombreTabla As String = "MITABLA"
        Try
            Dim cn As New SqlConnection
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DS As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DS, "MITABLA")
            cn.Close()
            grilla.DataSource = DS.Tables("MITABLA").DefaultView
            Dim ncolum As Integer
            Dim nombrecolumna As String

            Dim dgEstiloColumna As New DataGridTableStyle
            With dgEstiloColumna
                .MappingName = vNombreTabla
                .PreferredColumnWidth = 125
                .PreferredRowHeight = 15
            End With
            ncolum = DS.Tables("MITABLA").Columns.Count
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim ColEStilo1 As New DataGridTextBoxColumn
            With ColEStilo1
                .HeaderText = "NUMERO DOC"
                .MappingName = "NRONTARETEN"
                .Width = 80
                .ReadOnly = True
            End With

            Dim ColEStilo2 As New DataGridTextBoxColumn
            With ColEStilo2
                .HeaderText = "CLIENTE"
                .MappingName = "DESPCLIENTE"
                .Width = 190
                .ReadOnly = True
            End With

            Dim ColEStilo3 As New DataGridTextBoxColumn
            With ColEStilo3
                .HeaderText = "R.U.C"
                .MappingName = "RUCCLIENTE"
                .Width = 190
                .ReadOnly = True
            End With

            Dim ColEStilo4 As New DataGridTextBoxColumn
            With ColEStilo4
                .HeaderText = "DIRECCION"
                .MappingName = "DIRCLIENTE"
                .Width = 90
                .ReadOnly = True
            End With

            Dim ColEStilo5 As New DataGridTextBoxColumn
            With ColEStilo5
                .HeaderText = "FECHA DOCU"
                .MappingName = "FECDOCUM"
                .Width = 90
                .ReadOnly = True
            End With


            ' Agregar los estilos de las columnas al estilo del Grid
            dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4, ColEStilo5})
            grilla.TableStyles.Add(dgEstiloColumna)
            cn.Dispose()
            cmd.Dispose()
            cn = Nothing
            cmd = Nothing
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Function the Store Procedure"
    Public Sub Conecta(ByVal sql As String, ByVal tabla As String)
        Try
            If Cn.ConnectionString = String.Empty Then
                Cn.ConnectionString = STRCN
            End If
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If
            Cn.Open()

            Dim cmd As New SqlCommand(sql, Cn)
            cmd.CommandType = CommandType.Text

            Dim da As New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, tabla)

        Catch x As Exception
            MessageBox.Show(x.Message)
        Finally
            Cn.Close()
        End Try
    End Sub
    Public Sub conecta1(ByVal sql As String, ByVal tabla As String)
        Try
            Cn = New SqlConnection(STRCN)
            oda = New SqlDataAdapter(sql, Cn)
            cmb = New SqlCommandBuilder(oda)
            ds = New DataSet
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If
            Cn.Open()
            oda.Fill(ds, tabla)
            Cn.Close()

        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub
    Public Function TmpListarDatos(ByVal sql As String) As DataTable
        Try
            If Cn.ConnectionString = String.Empty Then
                Cn.ConnectionString = STRCN
            End If

            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If
            Cn.Open()

            Dim Dt_TimeOut As Integer = 5000

            Dim cmd As New SqlCommand(sql, Cn)
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = Dt_TimeOut

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            dt.TableName = "Table"
            da.Fill(dt)
            Cn.Close()
            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function TmpInsertDatos(ByVal sql As String) As Boolean

        Try
            If Cn.ConnectionString = String.Empty Then
                Cn.ConnectionString = STRCN
            End If

            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If
            Cn.Open()

            Dim Dt_TimeOut As Integer = 5000
            Dim cmd As New SqlCommand(sql, Cn)
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = Dt_TimeOut
            Dim Rspta As Integer
            Rspta = cmd.ExecuteNonQuery

            If Rspta > 0 Then
                TmpInsertDatos = True
            Else
                TmpInsertDatos = False
            End If
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

#End Region

#Region "Function DatoReporte"
    Public Function M_Cabecera_R(ByVal codusu As String, ByVal codemp As String) As DataTable
        Dim dt As New DataTable
        dt = CAyuda.ListarDatos("SP_CABECERA_RPT", codemp.Trim, codusu.Trim).Tables(0)
        Return dt
    End Function
#End Region

    Public Sub ReEscribirTicketFact(ByVal RUTA As String, ByVal NRODOC As String, ByVal PORCONSUMO As Boolean, ByVal NROMESA As String)

        FileOpen(1, RUTA, OpenMode.Output)

        Dim simbolo, simbolo2, GR_TOTCASHBAS, GR_TOTCASHEXT, GR_TOTCASHPESOS, GR_TOTVUELTOBAS, CDTIPOPAGO As String
        Dim RUC, RAZONSOCIAL, DIRECCION, TOTALVENTA, SUBTOTAL As String
        Dim IGV As String
        Dim TABLA_TRAER_DOCUMENTO As New DataTable

        TABLA_TRAER_DOCUMENTO = TmpListarDatos("TRAER_DOCUMENTO  '" & NRODOC.Trim & "','" & VCdTipoDoc.Trim & "'  ")
        GR_TOTCASHBAS = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTCASHBAS").ToString.Trim, 2)
        GR_TOTCASHEXT = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTCASHEXT").ToString.Trim, 2)
        GR_TOTCASHPESOS = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTCASHEXT").ToString.Trim, 2)
        GR_TOTVUELTOBAS = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTVUELTOBAS").ToString.Trim, 2)
        TOTALVENTA = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTALBAS").ToString.Trim, 2)
        SUBTOTAL = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("SUBTOTALBAS").ToString.Trim, 2)
        IGV = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("IGV").ToString.Trim, 2)
        CDTIPOPAGO = TABLA_TRAER_DOCUMENTO.Rows(0)("CODTIPOPAGO").ToString.Trim
        RUC = TABLA_TRAER_DOCUMENTO.Rows(0)("RUCCLIENTE").ToString.Trim
        RAZONSOCIAL = TABLA_TRAER_DOCUMENTO.Rows(0)("DESCLIENTE").ToString.Trim
        DIRECCION = TABLA_TRAER_DOCUMENTO.Rows(0)("DIRCLIENTE").ToString.Trim

        Dim i As Integer = 0
        simbolo = "S/.:"
        simbolo2 = "US$:"


        Dim cabecera As String
        If VCdTipoDoc.Trim = "099" Then

            PrintLine(1, Alineacion("I", IntAnchoTicket, GstrLinea4.Trim.Length, GstrLinea4.Trim))

            cabecera = "CONSUMO INTERNO"
            cabecera = Alineacion("C", IntAnchoTicket, cabecera.Trim.Length, cabecera.Trim)
            ''PrintLine(1, cabecera)
            cabecera = "NO VALIDO  COMO COMPROBANTE DE PAGO"
            cabecera = Alineacion("C", IntAnchoTicket, cabecera.Trim.Length, cabecera.Trim)
            ''PrintLine(1, cabecera)
            PrintLine(1, Alineacion("I", IntAnchoTicket, GstrLinea4.Trim.Length, GstrLinea4.Trim))

        End If

        'If TicketAnular = True Then
        '    PrintLine(1, Alineacion("I", IntAnchoTicket, GstrLinea4.Trim.Length, GstrLinea4.Trim))
        '    cabecera = "*******   DOCUMENTO ANULADO   ********"
        '    cabecera = Alineacion("C", IntAnchoTicket, cabecera.Trim.Length, cabecera.Trim)
        '    PrintLine(1, cabecera)
        '    PrintLine(1, Alineacion("I", IntAnchoTicket, GstrLinea4.Trim.Length, GstrLinea4.Trim))
        'End If

        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD1)), Trim(GHEAD1)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD2)), Trim(GHEAD2)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD4)), Trim(GHEAD4)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD5)), Trim(GHEAD5)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD3)), Trim(GHEAD3)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim TIPODOCUMENTO As String = ""
        Dim LETRADOC As String = ""

        If VCdTipoDoc.Trim = "01" Then
            TIPODOCUMENTO = "FACTURA DE VENTA ELECTRONICA"
            LETRADOC = "F"
        End If

        If VCdTipoDoc.Trim = "03" Then
            TIPODOCUMENTO = "BOLETA DE VENTA ELECTRONICA"
            LETRADOC = "B"
        End If

        If VCdTipoDoc.Trim = "06" Then
            TIPODOCUMENTO = "NOTA PEDIDO DE VENTA ELECTRONICA"
            LETRADOC = "F"
        End If


        'Dim FilaMaquinaRegist As String = ""
        'FilaMaquinaRegist = "Maq.Regist.No: " & TIPODOCUMENTO.Trim
        'FilaMaquinaRegist = FilaMaquinaRegist

        If VCdTipoDoc.Trim = "099" Then
        Else
            ' PrintLine(1, FilaMaquinaRegist)
            PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(TIPODOCUMENTO)), Trim(TIPODOCUMENTO)))
        End If

        Dim SERIE As String
        SERIE = LETRADOC + CStr(Left(NRODOC, 3))

        Dim NRODOCSIN As String
        NRODOCSIN = CStr(Right(NRODOC, 7))
        Dim NRODOCFINAL As String
        NRODOCFINAL = SERIE + "-" + NRODOCSIN


        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(NRODOCFINAL)), Trim(NRODOCFINAL)))

        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim RucRazonSocial As String
        Dim FilaMaquinaRegist As String = ""
        RucRazonSocial = "RUC/RAZON SOCIAL: " & RUC & " " & RAZONSOCIAL
        'FilaMaquinaRegist = FilaMaquinaRegist

        'PrintLine(1, FilaMaquinaRegist)

        Dim StrObserv As String = ""
        If RucRazonSocial <> "" Then

            Dim MinObs As Integer = 0
            Dim MxObserv As Integer = RucRazonSocial.Length
ReimpObs1:

            If (MxObserv - MinObs) > 38 Then
                StrObserv = RucRazonSocial.Substring(MinObs, 38)

                PrintLine(1, StrObserv)
                MinObs += 38
                GoTo ReimpObs1
            Else
                StrObserv = RucRazonSocial.Substring(MinObs, (MxObserv - MinObs))
                PrintLine(1, StrObserv)
            End If
        End If

        'RUC = TABLA_TRAER_DOCUMENTO.Rows(0)("RUCCLIENdTE").ToString.Trim
        'RAZONSOCIAL = TABLA_TRAER_DOCUMENTO.Rows(0)("DESCLIENTE").ToString.Trim
        'Dim fecha, hora As String
        'fecha = Format(Date.Now, "dd/MM/yyyy")
        'hora = "Hora: " & Format(Date.Now, "hh:mm tt")
        'FilaMaquinaRegist = "Fecha: " & fecha.Trim
        'FilaMaquinaRegist = FilaMaquinaRegist & Alineacion("D", IntAnchoTicket - FilaMaquinaRegist.Trim.Length, hora.Trim.Length, hora.Trim)
        'PrintLine(1, FilaMaquinaRegist)

        'Dim FilaNroticket, doc As String
        'doc = NRODOC.Trim

        'If VCdTipoDoc.Trim = "099" Then
        '    FilaNroticket = "Nro Recibo: " & Mid(doc, 1, 3) & "-" & Mid(doc, 4, doc.Trim.Length)
        'Else
        '    FilaNroticket = "Ticket Nro: " & Mid(doc, 1, 3) & "-" & Mid(doc, 4, doc.Trim.Length)
        'End If

        ''FilaNroticket = FilaNroticket & Alineacion("D", IntAnchoTicket - FilaNroticket.Trim.Length, hora.Trim.Length, hora.Trim)
        'PrintLine(1, FilaNroticket)

        'Dim LStrRazonSocial As String
        'If (Trim(RUC)) <> "" Then
        '    If (Trim(RAZONSOCIAL)) <> "" Then
        '        LStrRazonSocial = Alineacion("I", IntAnchoTicket, Len("Raz.Soc:" & RAZONSOCIAL), "Raz.Soc:" & RAZONSOCIAL)
        '        PrintLine(1, LStrRazonSocial)
        '    End If
        'Else
        '    If (Trim(RAZONSOCIAL)) <> "" Then
        '        LStrRazonSocial = Alineacion("I", IntAnchoTicket, Len("Nombre :" & RAZONSOCIAL), "Nombre :" & RAZONSOCIAL)
        '        PrintLine(1, LStrRazonSocial)
        '    End If
        'End If

        'Dim LstrRuc As String
        'If (Trim(RUC)) <> "" Then
        '    LstrRuc = Alineacion("I", IntAnchoTicket, Len("RUC    :" & RUC), "RUC    :" & RUC)
        '    PrintLine(1, LstrRuc)
        'End If
        'Dim LstrDireccion As String
        'If (Trim(DIRECCION)) <> "" Then
        '    LstrDireccion = Alineacion("I", IntAnchoTicket, Len("DIRECC.:" & DIRECCION), "DIRECC :" & DIRECCION)
        '    PrintLine(1, LstrDireccion)
        'End If
        'PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim LstrProducto As String
        Dim LstrDescripcion As String
        Dim codarti As String
        Dim CantDes As String
        Dim precio As String
        Dim Total As Double
        Dim import As String
        Dim despres As String
        Dim RsDetalleTemporal As New DataTable
        Dim MontoDesc As Double = 0
        VNroDoc = NRODOC


        Dim dsarti As String = ""
        Dim precioarti As Double = 0.0

        RsDetalleTemporal = TmpListarDatos("SELECT  *,PRE.despres  FROM VENTADET D   INNER JOIN  PRESENTACION  PRE ON   PRE.codpres= D.CODPRES  WHERE D.CODTIPODOC='" & VCdTipoDoc.Trim & "' AND  D.NRODOCU='" & NRODOC & "' ORDER BY  D.ITEM ")
        'For fil As Integer = 0 To RsDetalleTemporal.Rows.Count - 1
        '    codarti = RsDetalleTemporal.Rows(fil)("CODARTI").ToString.Trim
        '    dsarti = RsDetalleTemporal.Rows(fil)("DESARTI").ToString.Trim
        '    precioarti = CDbl(RsDetalleTemporal.Rows(fil)("PRECIO").ToString.Trim)
        '    ' MontoDesc = MontoDesc + CDbl(RsDetalleTemporal.Rows(fil)("MONTODESCBAS").ToString.Trim)

        'Next

        If PORCONSUMO = False Then
            If MontoDesc > 0 Then
                For a As Integer = 0 To RsDetalleTemporal.Rows.Count - 1
                    If CDbl(RsDetalleTemporal.Rows(a)("MONTODESCBAS").ToString.Trim) > 0 Then
                        Dim Cantidad As String
                        Dim Fcant() As String
                        Fcant = CStr(RsDetalleTemporal.Rows(a)(8).ToString.Trim).Split(".")

                        If Fcant.Length > 1 Then
                            If CDbl(Fcant.GetValue(1)) = 0 Then
                                Cantidad = FACT_GMascara(CDbl(RsDetalleTemporal.Rows(a)(13).ToString.Trim), 0)
                            Else
                                Cantidad = FACT_GMascara(CDbl(RsDetalleTemporal.Rows(a)(13).ToString.Trim), GdeciCant)
                            End If
                        Else
                            Cantidad = FACT_GMascara(CDbl(RsDetalleTemporal.Rows(a)(13).ToString.Trim), 0)
                        End If

                        CantDes = Alineacion("D", 5, Len(FACT_GMascara(Cantidad, GdeciCant)), FACT_GMascara(Cantidad, GdeciCant)) & " "
                        LstrDescripcion = Alineacion("I", 17, Len(Trim(RsDetalleTemporal.Rows(a)(5))), Trim(RsDetalleTemporal.Rows(a)(5))) & " "
                        precio = Alineacion("D", 6, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)(14).ToString, 2)), FACT_GMascara(RsDetalleTemporal.Rows(a)(9).ToString, 2)) & " "
                        Total = CDbl(CDbl(RsDetalleTemporal.Rows(a)(16).ToString))
                        import = Alineacion("D", 6, Len(FACT_GMascara(Total.ToString, Gdeciprec)), FACT_GMascara(Total.ToString, Gdeciprec))

                        LstrProducto = CantDes & LstrDescripcion & precio & "      "
                        LstrProducto = Alineacion("D", IntAnchoTicket, LstrProducto.Length, LstrProducto)
                        PrintLine(1, LstrProducto)

                        Dim FilaMontoDesc, MontDesc As String

                        MontDesc = Alineacion("D", 6, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)(11).ToString, Gdeciprec)), FACT_GMascara(RsDetalleTemporal.Rows(a)(11).ToString, Gdeciprec))
                        FilaMontoDesc = Alineacion("D", 6, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)("MONTODESCBAS").ToString, Gdeciprec)), FACT_GMascara(RsDetalleTemporal.Rows(a)("MONTODESCBAS").ToString, Gdeciprec)) & " "
                        FilaMontoDesc = "Desc(-" & FilaMontoDesc.Trim & ") " & MontDesc.Trim
                        FilaMontoDesc = Alineacion("D", IntAnchoTicket, FilaMontoDesc.Length, FilaMontoDesc)
                        PrintLine(1, FilaMontoDesc)

                    Else




                        CantDes = Alineacion("C", 17, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)(8).ToString, GdeciCant)), FACT_GMascara(RsDetalleTemporal.Rows(a)(8).ToString, GdeciCant)) & " "
                        despres = Alineacion("C", 17, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)("despres").ToString, GdeciCant)), FACT_GMascara(RsDetalleTemporal.Rows(a)("despres").ToString, GdeciCant)) & " "

                        precio = Alineacion("I", 17, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)(9).ToString, Gdeciprec)), FACT_GMascara(RsDetalleTemporal.Rows(a)(9).ToString, Gdeciprec)) & " "
                        codarti = Alineacion("D", 7, Len(Trim(RsDetalleTemporal.Rows(a)(4))), Trim(RsDetalleTemporal.Rows(a)(4))) & " "
                        LstrDescripcion = Alineacion("I", 17, Len(Trim(RsDetalleTemporal.Rows(a)(7))), Trim(RsDetalleTemporal.Rows(a)(7))) & " "
                        import = CDbl(CantDes) * CDbl(precio)
                        import = Alineacion("D", 6, Len(FACT_GMascara(import, Gdeciprec)), FACT_GMascara(import, Gdeciprec))

                        LstrProducto = CantDes & precio & codarti & LstrDescripcion & import
                        LstrProducto = Alineacion("D", IntAnchoTicket, LstrProducto.Trim.Length, LstrProducto.Trim)
                        PrintLine(1, LstrProducto)

                        '''' imprimo la observacion en el ticket linea por linea
                        Dim Robserv, RLinea2 As String
                        Dim TMP_VENTADET As New DataTable
                        TMP_VENTADET = TmpListarDatos("SELECT T.OBSERV  FROM TMP_VENTADET  T  WHERE  T.CORRNBR=" & CInt(VCorrelVta) & " AND T.ITEM=" & Int(RsDetalleTemporal.Rows(a)(2).ToString.Trim) & "")

                        If TMP_VENTADET.Rows.Count > 0 Then
                            Robserv = Trim(TMP_VENTADET.Rows(0)("OBSERV"))
                            If Robserv <> "" Then
                                ' Dim StrObserv As String = ""
                                Dim MinObs As Integer = 0
                                Dim MxObserv As Integer = Robserv.Length
ReimpObs0:
                                RLinea2 = ">>"
                                If (MxObserv - MinObs) > 35 Then
                                    StrObserv = Robserv.Substring(MinObs, 35)
                                    RLinea2 = RLinea2 & StrObserv
                                    PrintLine(1, RLinea2)
                                    MinObs += 35
                                    GoTo ReimpObs0
                                Else
                                    StrObserv = Robserv.Substring(MinObs, (MxObserv - MinObs))
                                    RLinea2 = RLinea2 & StrObserv
                                    PrintLine(1, RLinea2)
                                End If
                            End If
                        End If


                    End If
                Next
            Else
                For a As Integer = 0 To RsDetalleTemporal.Rows.Count - 1
                    Dim Cantidad As String
                    Dim Fcant() As String
                    Fcant = CStr(RsDetalleTemporal.Rows(a)(13).ToString.Trim).Split(".")
                    If Fcant.Length > 1 Then
                        If CDbl(Fcant.GetValue(1)) = 0 Then
                            Cantidad = FACT_GMascara(CDbl(RsDetalleTemporal.Rows(a)(13).ToString.Trim), 0)
                        Else
                            Cantidad = FACT_GMascara(CDbl(RsDetalleTemporal.Rows(a)(13).ToString.Trim), GdeciCant)
                        End If
                    Else
                        Cantidad = FACT_GMascara(CDbl(RsDetalleTemporal.Rows(a)(13).ToString.Trim), 0)
                    End If



                    CantDes = Alineacion("D", 9, Len(Cantidad), Cantidad) & " "
                    despres = Alineacion("I", 8, Len(RsDetalleTemporal.Rows(a)("despres").ToString), RsDetalleTemporal.Rows(a)("despres").ToString) & " "
                    precio = Alineacion("I", 18, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)(14).ToString, 2)), FACT_GMascara(RsDetalleTemporal.Rows(a)(14).ToString, 2)) & " "
                    codarti = Alineacion("I", 6, Len(RsDetalleTemporal.Rows(a)(4).ToString.Trim), RsDetalleTemporal.Rows(a)(4).ToString.Trim) & " "
                    LstrDescripcion = Alineacion("I", 24, Len(Trim(RsDetalleTemporal.Rows(a)(5))), Trim(RsDetalleTemporal.Rows(a)(5))) & " "
                    import = Alineacion("D", 5, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)(16).ToString, 2)), FACT_GMascara(RsDetalleTemporal.Rows(a)(16).ToString, 2))

                    LstrProducto = CantDes & despres & precio & codarti & LstrDescripcion & import

                    'LstrProducto = Alineacion("D", IntAnchoTicket, LstrProducto.Trim.Length, LstrProducto.Trim)
                    ' PrintLine(1, LstrProducto)
                    '''' imprimo la observacion en el ticket linea por linea

                    Dim Robserv, RLinea2 As String

                    'Dim TMP_VENTADET As New DataTable
                    'TMP_VENTADET = TmpListarDatos("SELECT T.OBSERV  FROM TMP_VENTADET  T  WHERE  T.CORRNBR=" & CInt(VCorrelVta) & " AND T.ITEM=" & Int(RsDetalleTemporal.Rows(a)(2).ToString.Trim) & "")

                    'If TMP_VENTADET.Rows.Count > 0 Then
                    ' Robserv = Trim(TMP_VENTADET.Rows(0)("OBSERV"))

                    'Robserv = "123456789 123456789 123456789 123456789 123456789 123456789 "

                    Robserv = LstrProducto

                    If Robserv <> "" Then
                        'Dim StrObserv As String = ""
                        Dim MinObs As Integer = 0
                        Dim MxObserv As Integer = Robserv.Length
ReimpObs:
                        RLinea2 = ""
                        If (MxObserv - MinObs) > 38 Then
                            StrObserv = Robserv.Substring(MinObs, 38)
                            RLinea2 = RLinea2 & StrObserv
                            PrintLine(1, RLinea2)
                            MinObs += 38
                            GoTo ReimpObs
                        Else
                            StrObserv = Robserv.Substring(MinObs, (MxObserv - MinObs))
                            RLinea2 = "*" + RLinea2 & StrObserv
                            PrintLine(1, RLinea2)
                        End If
                    End If

                    ' End If


                Next
            End If
        Else
            Dim PorConsumos As String
            PorConsumos = "P O R  C O N S U M O"
            PorConsumos = PorConsumos & Alineacion("D", IntAnchoTicket - PorConsumos.Trim.Length, TOTALVENTA.Trim.Length, TOTALVENTA.Trim)
            PrintLine(1, PorConsumos)
        End If


        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))


        Dim FilaTotal As String
        FilaTotal = "     TOTAL"
        FilaTotal = FilaTotal & Alineacion("D", 31 - FilaTotal.Length, "S/.".Trim.Length, "S/.".Trim)

        FilaTotal = FilaTotal & Alineacion("D", IntAnchoTicket - FilaTotal.Length, TOTALVENTA.Trim.Length, TOTALVENTA.Trim)
        PrintLine(1, FilaTotal)

        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))



        Dim INAFECTO As String = ""
        Dim TABLA_INAFECTO As New DataTable
        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO  '" & VCdTipoDoc.Trim & "','" & NRODOC.Trim & "'  ")
        If TABLA_INAFECTO.Rows.Count > 0 Then
            INAFECTO = FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString
        End If

        Dim AFECTO As String = ""
        Dim TABLA_AFECTO As New DataTable
        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_AFECTO  '" & VCdTipoDoc.Trim & "','" & NRODOC.Trim & "'  ")
        If TABLA_INAFECTO.Rows.Count > 0 Then
            AFECTO = FACT_GMascara(TABLA_INAFECTO.Rows(0)("AFECTO").ToString.Trim, 2).ToString
        End If

        Dim FilaInafecto As String
        FilaInafecto = "     OP. INAFECTO"
        FilaInafecto = FilaInafecto & Alineacion("D", 31 - FilaInafecto.Length, "S/.".Trim.Length, "S/.".Trim)
        FilaInafecto = FilaInafecto & Alineacion("D", IntAnchoTicket - FilaInafecto.Length, INAFECTO.Trim.Length, INAFECTO.Trim)
        PrintLine(1, FilaInafecto)

        Dim FilaAfecto As String
        FilaAfecto = "     OP. GRAVADA"
        FilaAfecto = FilaAfecto & Alineacion("D", 31 - FilaAfecto.Length, "S/.".Trim.Length, "S/.".Trim)
        FilaAfecto = FilaAfecto & Alineacion("D", IntAnchoTicket - FilaAfecto.Length, AFECTO.Trim.Length, AFECTO.Trim)
        PrintLine(1, FilaAfecto)


        ' If RUC.Trim <> "" Then

        Dim FilaIGV, Strigv As String
        FilaIGV = "     IGV"
        FilaIGV = FilaIGV & Alineacion("D", 31 - FilaIGV.Length, "S/.".Trim.Length, "S/.".Trim)

        Strigv = FACT_GMascara(IGV, 2)

        FilaIGV = FilaIGV & Alineacion("D", IntAnchoTicket - FilaIGV.Length, Strigv.Trim.Length, Strigv.Trim)
        PrintLine(1, FilaIGV)

        Dim FilaValorVenta, subtot As String
        FilaValorVenta = "     IMPORTE TOTAL"
        FilaValorVenta = FilaValorVenta & Alineacion("D", 31 - FilaValorVenta.Length, "S/.".Trim.Length, "S/.".Trim)

        subtot = FACT_GMascara(TOTALVENTA.Trim, 2)

        FilaValorVenta = FilaValorVenta & Alineacion("D", IntAnchoTicket - FilaValorVenta.Length, subtot.Trim.Length, subtot.Trim)
        PrintLine(1, FilaValorVenta)

        'Dim StrMonLet As String
        'StrMonLet = FACT_TotalLetras(CDbl(TOTALVENTA.Trim.ToString), "SOLES")


        'Dim FilaLetra As String
        'FilaLetra = "     SON:"
        'FilaLetra = FilaLetra & Alineacion("D", 31 - FilaLetra.Length, "S/.".Trim.Length, "S/.".Trim)
        'FilaLetra = FilaLetra & Alineacion("D", IntAnchoTicket - FilaLetra.Length, StrMonLet.Trim.Length, StrMonLet.Trim)
        'PrintLine(1, FilaLetra)



        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim StrMonLet As String
        StrMonLet = "SON: " + FACT_TotalLetras(CDbl(TOTALVENTA.Trim.ToString), "SOLES")

        'FilaMaquinaRegist = FilaMaquinaRegist

        'PrintLine(1, FilaMaquinaRegist)

        Dim StrObserv1 As String = ""
        If StrMonLet <> "" Then

            Dim MinObs As Integer = 0
            Dim MxObserv As Integer = StrMonLet.Length
ReimpObs3:

            If (MxObserv - MinObs) > 38 Then
                StrObserv1 = StrMonLet.Substring(MinObs, 38)

                PrintLine(1, StrObserv1)
                MinObs += 38
                GoTo ReimpObs3
            Else
                StrObserv1 = StrMonLet.Substring(MinObs, (MxObserv - MinObs))
                ' PrintLine(1, StrObserv1)

                PrintLine(1, Alineacion("C", IntAnchoTicket, StrObserv1.Length, StrObserv1))


            End If
        End If

        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim codhash1 As String
        codhash1 = "Cod Hash: " & CODCASH
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(codhash1)), Trim(codhash1)))

        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim("Autorizado mediante")), Trim("Autorizado mediante")))
        Dim resolucion1 As String
        resolucion1 = "Resolucion Nro. " & RESOLUCION
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(resolucion1)), Trim(resolucion1)))

        Dim pie As String
        pie = "Representacion Impresa de la " & TIPODOCUMENTO & ". Para consultar el documento ingrese a " & URL

        Dim StrObserv4 As String = ""
        If RucRazonSocial <> "" Then

            Dim MinObs As Integer = 0
            Dim MxObserv As Integer = pie.Length
ReimpObs4:

            If (MxObserv - MinObs) > 38 Then
                StrObserv4 = pie.Substring(MinObs, 38)

                PrintLine(1, StrObserv4)
                MinObs += 38
                GoTo ReimpObs4
            Else
                StrObserv4 = pie.Substring(MinObs, (MxObserv - MinObs))
                PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(StrObserv4)), Trim(StrObserv4)))
            End If
        End If



        'End If



        'Dim FilaTarjeta, dsTarjeta, NroTarjeta As String
        'Dim Tabla_Tmp_Tarjeta As New DataTable

        'Tabla_Tmp_Tarjeta = TmpListarDatos("TRAER_PAGO_CON_TARJETA  '" & NRODOC.Trim & "','" & CDTICKET.Trim & "' ")

        'If Tabla_Tmp_Tarjeta.Rows.Count > 0 Then
        '    PrintLine(1, "TARJETA:")
        '    For i = 0 To Tabla_Tmp_Tarjeta.Rows.Count - 1
        '        dsTarjeta = Alineacion("I", 17, Tabla_Tmp_Tarjeta.Rows(i)("DSTARJETA").ToString.Trim.Length, Tabla_Tmp_Tarjeta.Rows(i)("DSTARJETA").ToString.Trim)
        '        NroTarjeta = Microsoft.VisualBasic.Right(Tabla_Tmp_Tarjeta.Rows(i)("NROTARJETA").ToString.Trim, 4)

        '        FilaTarjeta = dsTarjeta & NroTarjeta
        '        Select Case Tabla_Tmp_Tarjeta.Rows(i)("CDMONEDA").ToString.Trim
        '            Case "S"
        '                FilaTarjeta = FilaTarjeta & Alineacion("D", 31 - FilaTarjeta.Length, simbolo.Trim.Length, simbolo.Trim)
        '                FilaTarjeta = FilaTarjeta & Alineacion("D", IntAnchoTicket - FilaTarjeta.Trim.Length, FACT_GMascara(Tabla_Tmp_Tarjeta.Rows(i)("TOTTARJBAS").ToString.Trim, 2).Trim.Length, FACT_GMascara(Tabla_Tmp_Tarjeta.Rows(i)("TOTTARJBAS").ToString.Trim, 2).Trim)
        '            Case Else
        '                FilaTarjeta = FilaTarjeta & Alineacion("D", 31 - FilaTarjeta.Length, simbolo2.Trim.Length, simbolo2.Trim)
        '                FilaTarjeta = FilaTarjeta & Alineacion("D", IntAnchoTicket - FilaTarjeta.Trim.Length, FACT_GMascara(Tabla_Tmp_Tarjeta.Rows(i)("TOTTARJEXT").ToString.Trim, 2).Trim.Length, FACT_GMascara(Tabla_Tmp_Tarjeta.Rows(i)("TOTTARJEXT").ToString.Trim, 2).Trim)
        '        End Select
        '        PrintLine(1, FilaTarjeta)
        '    Next
        'End If
        ''Dim FilaVale As String
        ''Dim Tabla_Tmp_Vale As New DataTable

        ''Tabla_Tmp_Vale = TmpListarDatos("SELECT  V.CDMONEDA, V.NROVALE ,V.CDCLIENTE,E.NOMEMPRESA,V.TOTVALEBAS,V.TOTVALEEXT   FROM   VENTAVALES  V LEFT JOIN EMPVALE  E  ON  V.CDCLIENTE=E.CODEMPRESA  WHERE  V.NRODOCU='" & NRODOC.Trim & "' AND  V.CDTIPODOC='" & CDTICKET.Trim & "' ")
        ''If Tabla_Tmp_Vale.Rows.Count > 0 Then
        ''    PrintLine(1, "VALES: " & Trim(Tabla_Tmp_Vale.Rows(0)("NOMEMPRESA").ToString))
        ''    For i = 0 To Tabla_Tmp_Vale.Rows.Count - 1
        ''        FilaVale = Alineacion("I", 16, Tabla_Tmp_Vale.Rows(i)("NROVALE").ToString.Trim.Length, Tabla_Tmp_Vale.Rows(i)("NROVALE").ToString.Trim)
        ''        Select Case Tabla_Tmp_Vale.Rows(i)("CDMONEDA").ToString.Trim
        ''            Case "S"
        ''                FilaVale = FilaVale & Alineacion("D", 31 - FilaVale.Length, simbolo.Trim.Length, simbolo.Trim)
        ''                FilaVale = FilaVale & Alineacion("D", IntAnchoTicket - FilaVale.Trim.Length, Trim(FACT_GMascara(CDbl(Tabla_Tmp_Vale.Rows(i)("TOTVALEBAS")), 2)).Length, Trim(FACT_GMascara(CDbl(Tabla_Tmp_Vale.Rows(i)("TOTVALEBAS")), 2)))
        ''            Case Else
        ''                FilaVale = FilaVale & Alineacion("D", 31 - FilaVale.Length, simbolo2.Trim.Length, simbolo2.Trim)
        ''                FilaVale = FilaVale & Alineacion("D", IntAnchoTicket - FilaVale.Trim.Length, Trim(FACT_GMascara(CDbl(Tabla_Tmp_Vale.Rows(i)("TOTVALEEXT")), 2)).Length, Trim(FACT_GMascara(CDbl(Tabla_Tmp_Vale.Rows(i)("TOTVALEEXT")), 2)))
        ''        End Select
        ''        PrintLine(1, FilaVale)
        ''    Next
        ''End If

        Dim FilaEfectivo As String
        FilaEfectivo = "EFECTIVO:"
        Dim mon() As String
        If CDbl(GR_TOTCASHBAS) <> 0 Then
            mon = simbolo.Split(":")
            FilaEfectivo = FilaEfectivo & mon(0) & FACT_GMascara(GR_TOTCASHBAS, 2) & "   "
        Else
            'If ClsData.VCdTipoPago = "10" Then
            '    FilaEfectivo = "TRANSFERENCIA GRATUITA"

            'End If
        End If
        If CDbl(GR_TOTCASHEXT) <> 0 Then
            mon = simbolo2.Split(":")
            FilaEfectivo = FilaEfectivo & mon(0) & FACT_GMascara(GR_TOTCASHEXT, 2) & "  "
        End If
        If CDbl(GR_TOTCASHPESOS) <> 0 Then
            'mon = simbolo2.Split(":")
            FilaEfectivo = FilaEfectivo & "S" & FACT_GMascara(GR_TOTCASHPESOS, 2)
        End If

        If FilaEfectivo.Trim <> "EFECTIVO:" Then
            PrintLine(1, FilaEfectivo)
        End If

        Dim FilaVuelto As String
        If CDbl(GR_TOTVUELTOBAS) <> 0 Then
            Dim mone() As String
            mone = simbolo.Split(":")
            FilaVuelto = "VUELTO:    " & mone(0) & GR_TOTVUELTOBAS.Trim
            PrintLine(1, FilaVuelto)
        End If

        'Dim Tabla_tmp_Cheque As New DataTable
        'Tabla_tmp_Cheque = TmpListarDatos("select    V.CDMONEDA,B.DSBANCO,V.NROCHEQUE,V.TOTCHEQBAS,V.TOTCHEQEXT   from    VENTACHEQUE  V  LEFT JOIN BANCOS  B  ON  V.CDBANCO=B.CDBANCO  where  NRODOCU='" & NRODOC.Trim & "'  AND CDTIPODOC='" & CDTICKET & "'")
        'If Tabla_tmp_Cheque.Rows.Count > 0 Then
        '    PrintLine(1, "PAGO Cheque:")
        'End If
        'For cheq As Integer = 0 To Tabla_tmp_Cheque.Rows.Count - 1
        '    PrintLine(1, "Banco: " & Tabla_tmp_Cheque.Rows(cheq)("DSBANCO").ToString.Trim)
        '    Dim FilaNroCheq, TotalChque As String
        '    FilaNroCheq = "N.-: " & Tabla_tmp_Cheque.Rows(cheq)("NROCHEQUE").ToString.Trim & "            S/.:"
        '    If Tabla_tmp_Cheque.Rows(cheq)("CDMONEDA").ToString.Trim = "S" Then
        '        TotalChque = FACT_GMascara(Tabla_tmp_Cheque.Rows(cheq)("TOTCHEQBAS").ToString.Trim, 2)
        '    Else
        '        TotalChque = FACT_GMascara(Tabla_tmp_Cheque.Rows(cheq)("TOTCHEQEXT").ToString.Trim, 2)
        '    End If
        '    TotalChque = Alineacion("D", IntAnchoTicket - FilaNroCheq.Trim.Length, TotalChque.Trim.Length, TotalChque.Trim)
        '    FilaNroCheq = FilaNroCheq & TotalChque
        '    PrintLine(1, FilaNroCheq)
        'Next

        'Dim Tabla_Credito As New DataTable
        'Dim AcumulaTotalCred As String
        'Tabla_Credito = TmpListarDatos("select  V.NRODOCU,V.CDTIPODOC,T.DESCREDFAC,V.CDMONEDA,V.TOTCREDBAS,V.TOTCREDEXT  from  VENTACRED  V  left join   cliente  C  on  V.cdcliente=C.cdcliente  LEFT JOIN   TIPCREDF T  ON  C.TIPOCRECF=T.TIPCREDFAC  where  V.NRODOCU='" & NRODOC & "' AND  V.CDTIPODOC='" & CDTICKET & "'  ")
        'If Tabla_Credito.Rows.Count > 0 Then
        '    PrintLine(1, "Credito:")
        '    Dim FilaCredito, moneda As String
        '    If Tabla_Credito.Rows(0)("CDMONEDA").ToString.Trim = CDMONBASE.Trim Then
        '        AcumulaTotalCred = FACT_GMascara(Tabla_Credito.Rows(0)("TOTCREDBAS"), 2)
        '        moneda = "S"
        '    Else
        '        AcumulaTotalCred = FACT_GMascara(Tabla_Credito.Rows(0)("TOTCREDEXT"), 2)
        '        moneda = "S"
        '    End If

        '    FilaCredito = Tabla_Credito.Rows(0)("DESCREDFAC").ToString.Trim
        '    FilaCredito = FilaCredito & Alineacion("D", 31 - FilaCredito.Trim.Length, moneda.Trim.Length, moneda.Trim)
        '    FilaCredito = FilaCredito & Alineacion("D", IntAnchoTicket - FilaCredito.Trim.Length, CStr(AcumulaTotalCred).Trim.Length, CStr(AcumulaTotalCred).Trim)
        '    PrintLine(1, FilaCredito)
        'End If


        'Dim FilaTipocambio As String
        'FilaTipocambio = "TC:" & FACT_GMascara(TipoCambioVenta, 2)

        'FilaTipocambio = FilaTipocambio & "   CAJERO:" & "JORGE"
        'PrintLine(1, FilaTipocambio)
        'Dim filaNroMesa As String
        'filaNroMesa = "Nro.Mesa " & NROMESA.Trim
        'PrintLine(1, filaNroMesa)


        'Dim Rclie As String
        'Rclie = "Cliente: " & "AAAA"
        'PrintLine(1, Rclie)

        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim LFoot1, LFoot2, LFoot3, LFoot4, LFoot5, LFoot6, LFoot7, LFoot8, LFoot9, LFoot10 As String

        LFoot1 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT1)), Trim(GstrFOOT1))
        LFoot2 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT2)), Trim(GstrFOOT2))
        LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT3)), Trim(GstrFOOT3))
        LFoot4 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT4)), Trim(GstrFOOT4))
        LFoot5 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT5)), Trim(GstrFOOT5))

        LFoot6 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT6)), Trim(GstrFOOT6))

        LFoot7 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT7)), Trim(GstrFOOT7))

        LFoot8 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT8)), Trim(GstrFOOT8))

        LFoot9 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT9)), Trim(GstrFOOT9))

        LFoot10 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT10)), Trim(GstrFOOT10))

        If Not IsNothing(Trim(LFoot1)) Then
            PrintLine(1, LFoot1)
        End If

        If Not IsNothing(Trim(LFoot2)) Then
            PrintLine(1, LFoot2)
        End If

        If Trim(LFoot3) <> "" Then
            PrintLine(1, LFoot3)
        End If

        If Trim(LFoot4) <> "" Then
            PrintLine(1, LFoot4)
        End If

        If Trim(LFoot5) <> "" Then
            PrintLine(1, LFoot5)
        End If

        If Trim(LFoot6) <> "" Then
            PrintLine(1, LFoot6)
        End If

        If Trim(LFoot7) <> "" Then
            PrintLine(1, LFoot7)
        End If

        If Trim(LFoot8) <> "" Then
            PrintLine(1, LFoot8)
        End If

        If Trim(LFoot9) <> "" Then
            PrintLine(1, LFoot9)
        End If

        If Trim(LFoot10) <> "" Then
            PrintLine(1, LFoot10)
        End If
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        FileClose(1)
    End Sub



    Public Sub ReEscribirTicketFact2(ByVal RUTA As String, ByVal NRODOC As String, ByVal PORCONSUMO As Boolean, ByVal NROMESA As String, ByVal FECHADOCUM As String)

        FileOpen(1, RUTA, OpenMode.Output)

        Dim simbolo, simbolo2, GR_TOTCASHBAS, GR_TOTCASHEXT, GR_TOTCASHPESOS, GR_TOTVUELTOBAS, CDTIPOPAGO As String
        Dim RUC, RAZONSOCIAL, DIRECCION, TOTALVENTA, SUBTOTAL As String
        Dim IPERCEP As Double, CODHASH As String
        Dim CODCLIENTE As String

        Dim IGV As String
        Dim TABLA_TRAER_DOCUMENTO As New DataTable

        TABLA_TRAER_DOCUMENTO = TmpListarDatos("TRAER_DOCUMENTO  '" & codempresa.Trim & "','" & NRODOC.Trim & "','" & VCdTipoDoc.Trim & "','" & CStr(FECHADOCUM) & "'")

        GR_TOTCASHBAS = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTCASHBAS").ToString.Trim, 2)
        GR_TOTCASHEXT = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTCASHEXT").ToString.Trim, 2)
        GR_TOTCASHPESOS = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTCASHEXT").ToString.Trim, 2)
        GR_TOTVUELTOBAS = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTVUELTOBAS").ToString.Trim, 2)
        TOTALVENTA = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("TOTALBAS").ToString.Trim, 2)
        SUBTOTAL = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("SUBTOTALBAS").ToString.Trim, 2)
        IGV = FACT_GMascara(TABLA_TRAER_DOCUMENTO.Rows(0)("IGV").ToString.Trim, 2)
        CDTIPOPAGO = TABLA_TRAER_DOCUMENTO.Rows(0)("CODTIPOPAGO").ToString.Trim
        RUC = TABLA_TRAER_DOCUMENTO.Rows(0)("RUCCLIENTE").ToString.Trim
        RAZONSOCIAL = TABLA_TRAER_DOCUMENTO.Rows(0)("DESCLIENTE").ToString.Trim
        DIRECCION = TABLA_TRAER_DOCUMENTO.Rows(0)("DIRCLIENTE").ToString.Trim
        IPERCEP = TABLA_TRAER_DOCUMENTO.Rows(0)("IPERCEP").ToString.Trim
        CODHASH = TABLA_TRAER_DOCUMENTO.Rows(0)("CODHASH").ToString.Trim
        CODCLIENTE = TABLA_TRAER_DOCUMENTO.Rows(0)("CODCLIENTE").ToString.Trim

        VDescliente = RAZONSOCIAL
        VDireccion = DIRECCION
        VCodCliente = CODCLIENTE
        VRuc = RUC

        Dim i As Integer
        simbolo = "S/.:"
        simbolo2 = "US$:"

        Dim cabecera As String
        If VCdTipoDoc.Trim = "099" Then

            PrintLine(1, Alineacion("I", IntAnchoTicket, GstrLinea4.Trim.Length, GstrLinea4.Trim))

            cabecera = "CONSUMO INTERNO"
            cabecera = Alineacion("C", IntAnchoTicket, cabecera.Trim.Length, cabecera.Trim)
            ''PrintLine(1, cabecera)
            cabecera = "NO VALIDO  COMO COMPROBANTE DE PAGO"
            cabecera = Alineacion("C", IntAnchoTicket, cabecera.Trim.Length, cabecera.Trim)
            ''PrintLine(1, cabecera)
            PrintLine(1, Alineacion("I", IntAnchoTicket, GstrLinea4.Trim.Length, GstrLinea4.Trim))

        End If

        'If TicketAnular = True Then
        '    PrintLine(1, Alineacion("I", IntAnchoTicket, GstrLinea4.Trim.Length, GstrLinea4.Trim))
        '    cabecera = "*******   DOCUMENTO ANULADO   ********"
        '    cabecera = Alineacion("C", IntAnchoTicket, cabecera.Trim.Length, cabecera.Trim)
        '    PrintLine(1, cabecera)
        '    PrintLine(1, Alineacion("I", IntAnchoTicket, GstrLinea4.Trim.Length, GstrLinea4.Trim))
        'End If

        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD1)), Trim(GHEAD1)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD3)), Trim(GHEAD3)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD4)), Trim(GHEAD4)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(GHEAD5)), Trim(GHEAD5)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim TIPODOCUMENTO As String
        Dim LETRADOC As String

        If VCdTipoDoc.Trim = "01" Then
            TIPODOCUMENTO = "FACTURA DE VENTA ELECTRONICA"
            LETRADOC = "F"
        End If

        If VCdTipoDoc.Trim = "03" Then
            TIPODOCUMENTO = "BOLETA DE VENTA ELECTRONICA"
            LETRADOC = "B"
        End If

        If VCdTipoDoc.Trim = "06" Then
            TIPODOCUMENTO = "NOTA PEDIDO"
            LETRADOC = "P"
        End If

        'Dim FilaMaquinaRegist As String = ""
        'FilaMaquinaRegist = "Maq.Regist.No: " & TIPODOCUMENTO.Trim
        'FilaMaquinaRegist = FilaMaquinaRegist

        If VCdTipoDoc.Trim = "099" Then
        Else
            ' PrintLine(1, FilaMaquinaRegist)
            ' PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(TIPODOCUMENTO)), Trim(TIPODOCUMENTO)))
        End If

        Dim DSTIPOPAGO As String
        If CDTIPOPAGO = "01" Then
            DSTIPOPAGO = "EFECTIVO"
        End If
        If CDTIPOPAGO = "06" Then
            DSTIPOPAGO = "CREDITO"
        End If


        Dim SERIE As String
        Dim FormatNroDoc As String
        FormatNroDoc = Format(CDbl(NRODOC.Trim), "0##-########")
        Dim NUMSERIE As String
        NUMSERIE = Microsoft.VisualBasic.Left(FormatNroDoc, 3)

        SERIE = LETRADOC + NUMSERIE

        Dim NRODOCSIN As String
        NRODOCSIN = CStr(Right(NRODOC, 8))
        Dim NRODOCFINAL As String
        NRODOCFINAL = SERIE + "-" + NRODOCSIN


        'PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(NRODOCFINAL)), Trim(NRODOCFINAL)))

        'PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))



        PrintLine(1, "")
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(TIPODOCUMENTO)), Trim(TIPODOCUMENTO)))
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(NRODOCFINAL)), Trim(NRODOCFINAL)))
        PrintLine(1, "")
        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim RucRazonSocial As String

        Dim fecha, hora As String
        fecha = Format(Date.Now, "dd/MM/yyyy")
        hora = Format(Date.Now, "hh:mm tt")

        ' Dim FilaMaquinaRegist As String = ""
        'RucRazonSocial = "COD. CLIENTE: " & RUC & " " & RAZONSOCIAL

        PrintLine(1, "COD.CLIENTE: " & VCodCliente)
        'PrintLine(1, "CLIENTE: " & VDescliente)

        RucRazonSocial = "CLIENTE: " & VDescliente

        Dim StrObserv As String = ""
        If RucRazonSocial <> "" Then

            Dim MinObs As Integer = 0
            Dim MxObserv As Integer = RucRazonSocial.Length
ReimpObs1:

            If (MxObserv - MinObs) > 38 Then
                StrObserv = RucRazonSocial.Substring(MinObs, 38)

                PrintLine(1, StrObserv)
                MinObs += 38
                GoTo ReimpObs1
            Else
                StrObserv = RucRazonSocial.Substring(MinObs, (MxObserv - MinObs))
                PrintLine(1, StrObserv)
            End If
        End If

        PrintLine(1, "RUC: " & VRuc)

        Dim ClieDireccion As String
        ClieDireccion = "DIRECCION: " & VDireccion

        Dim StrObserv2 As String = ""
        If ClieDireccion <> "" Then

            Dim MinObs As Integer = 0
            Dim MxObserv As Integer = ClieDireccion.Length
ReimpObs7:

            If (MxObserv - MinObs) > 38 Then
                StrObserv2 = ClieDireccion.Substring(MinObs, 38)

                PrintLine(1, StrObserv2)
                MinObs += 38
                GoTo ReimpObs7
            Else
                StrObserv2 = ClieDireccion.Substring(MinObs, (MxObserv - MinObs))
                PrintLine(1, StrObserv2)
            End If
        End If

        PrintLine(1, "CONDICION:" & DSTIPOPAGO)
        PrintLine(1, "FECHA: " & fecha & " / HORA:" & hora)
        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim LstrProducto As String
        Dim LstrDescripcion As String
        Dim codarti As String
        Dim CantDes As String
        Dim precio As String
        Dim Total As Double
        Dim import As String
        Dim despres As String
        Dim RsDetalleTemporal As New DataTable
        Dim MontoDesc As Double = 0
        ' VNroDoc = NRODOC


        Dim dsarti As String
        Dim precioarti As Double

        '//RsDetalleTemporal = TmpListarDatos("SELECT  *,PRE.codumed   FROM VENTADET D   INNER JOIN  ARTICULO  PRE ON   PRE.CODARTI= D.CODARTI  WHERE D.CODTIPODOC='" & VCdTipoDoc.Trim & "' AND  D.NRODOCU='" & NRODOC.Trim & "' ORDER BY  D.ITEM ")

        RsDetalleTemporal = TmpListarDatos("NSP_LISTAR_VENTADET  '" & codempresa.Trim & "','" & NRODOC.Trim & "','" & VCdTipoDoc.Trim & "','" & CStr(FECHADOCUM) & "'")

        If RsDetalleTemporal.Rows.Count > 0 Then
            For a As Integer = 0 To RsDetalleTemporal.Rows.Count - 1
                If CDbl(RsDetalleTemporal.Rows(a)("MONTODESCBAS").ToString.Trim) > 0 Then
                Else
                    PrintLine(1, "CODIGO: " & Trim(RsDetalleTemporal.Rows(a)("CodArti")) & " PRES:" & Trim(RsDetalleTemporal.Rows(a)("despres")))

                    Dim DescArticulo As String
                    DescArticulo = Trim(RsDetalleTemporal.Rows(a)("DesArti"))

                    Dim StrObserv7 As String = ""
                    If DescArticulo <> "" Then

                        Dim MinObs As Integer = 0
                        Dim MxObserv As Integer = DescArticulo.Length
ReimpObs6:
                        If (MxObserv - MinObs) > 38 Then
                            StrObserv7 = DescArticulo.Substring(MinObs, 38)

                            PrintLine(1, StrObserv7)
                            MinObs += 38
                            GoTo ReimpObs6
                        Else
                            StrObserv7 = DescArticulo.Substring(MinObs, (MxObserv - MinObs))
                            PrintLine(1, StrObserv7)
                        End If
                    End If

                    CantDes = FACT_GMascara(RsDetalleTemporal.Rows(a)("Cantidad").ToString, GdeciCant)
                    '  despres = Alineacion("C", 17, Len(FACT_GMascara(RsDetalleTemporal.Rows(a)("despres").ToString, GdeciCant)), FACT_GMascara(RsDetalleTemporal.Rows(a)("despres").ToString, GdeciCant)) & " "
                    precio = FACT_GMascara(RsDetalleTemporal.Rows(a)("Precio").ToString, 2)
                    import = CDbl(CantDes) * CDbl(precio)

                    PrintLine(1, "CANT : " & CInt(RsDetalleTemporal.Rows(a)("Cantidad").ToString) & " COSTO:S/" & FACT_GMascara(RsDetalleTemporal.Rows(a)("Precio").ToString, 2) & " IMP:S/" & import)
                    PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

                    ''' FIN DE LA IMPRESION DE LA OBSERVACION
                End If
            Next
        End If

        Dim FilaTotal As String
        FilaTotal = "     VALOR VENTA"
        FilaTotal = FilaTotal & Alineacion("D", 31 - FilaTotal.Length, "S/.".Trim.Length, "S/.".Trim)
        FilaTotal = FilaTotal & Alineacion("D", IntAnchoTicket - FilaTotal.Length, SUBTOTAL.Trim.Length, SUBTOTAL.Trim)
        PrintLine(1, FilaTotal)

        Dim FilaIGV, Strigv As String
        FilaIGV = "     IGV"
        FilaIGV = FilaIGV & Alineacion("D", 31 - FilaIGV.Length, "S/.".Trim.Length, "S/.".Trim)
        Strigv = FACT_GMascara(IGV, 2)
        FilaIGV = FilaIGV & Alineacion("D", IntAnchoTicket - FilaIGV.Length, Strigv.Trim.Length, Strigv.Trim)
        PrintLine(1, FilaIGV)

        Dim FilaValorVenta, subtot As String
        FilaValorVenta = "     IMPORTE TOTAL"
        FilaValorVenta = FilaValorVenta & Alineacion("D", 31 - FilaValorVenta.Length, "S/.".Trim.Length, "S/.".Trim)

        subtot = FACT_GMascara(TOTALVENTA.Trim, 2)

        FilaValorVenta = FilaValorVenta & Alineacion("D", IntAnchoTicket - FilaValorVenta.Length, subtot.Trim.Length, subtot.Trim)
        PrintLine(1, FilaValorVenta)

        'Dim StrMonLet As String
        'StrMonLet = FACT_TotalLetras(CDbl(TOTALVENTA.Trim.ToString), "SOLES")


        'Dim FilaLetra As String
        'FilaLetra = "     SON:"
        'FilaLetra = FilaLetra & Alineacion("D", 31 - FilaLetra.Length, "S/.".Trim.Length, "S/.".Trim)
        'FilaLetra = FilaLetra & Alineacion("D", IntAnchoTicket - FilaLetra.Length, StrMonLet.Trim.Length, StrMonLet.Trim)
        'PrintLine(1, FilaLetra)



        '        Dim StrMonLet As String
        '        StrMonLet = "SON: " + FACT_TotalLetras((CDbl(TOTALVENTA) - IPERCEP), "SOLES")

        '        Dim StrObserv1 As String = ""
        '        If StrMonLet <> "" Then
        '            Dim MinObs As Integer = 0
        '            Dim MxObserv As Integer = StrMonLet.Length
        'ReimpObs3:
        '            If (MxObserv - MinObs) > 38 Then
        '                StrObserv1 = StrMonLet.Substring(MinObs, 38)

        '                PrintLine(1, StrObserv1)
        '                MinObs += 38
        '                GoTo ReimpObs3
        '            Else
        '                StrObserv1 = StrMonLet.Substring(MinObs, (MxObserv - MinObs))
        '                PrintLine(1, Alineacion("I", IntAnchoTicket, StrObserv1.Length, StrObserv1))
        '            End If
        '        End If

        '        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))
        '        PrintLine(1, "COMPROBANTE DE PERCEPCION: ")





        ' PrintLine(1, "Percepcion:S/" & IPERCEP & " Total:S/" & FACT_GMascara((CDbl(TOTALVENTA) - IPERCEP), 2))

        Dim StrPercTotal As String
        StrPercTotal = "Percepcion:S/" & IPERCEP & " Total:S/" & FACT_GMascara((CDbl(TOTALVENTA) - IPERCEP), 2)
        PrintLine(1, Alineacion("D", IntAnchoTicket, StrPercTotal.Length, StrPercTotal))



        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim INAFECTO As String
        Dim TABLA_INAFECTO As New DataTable
        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_INAFECTO_HISTO  '" & codempresa.Trim & "','" & VCdTipoDoc.Trim & "','" & NRODOC.Trim & "','" & CStr(FECHADOCUM.Trim) & "'")

        If TABLA_INAFECTO.Rows.Count > 0 Then
            INAFECTO = FACT_GMascara(TABLA_INAFECTO.Rows(0)("INAFECTO").ToString.Trim, 2).ToString
        End If

        Dim AFECTO As String
        Dim TABLA_AFECTO As New DataTable
        TABLA_INAFECTO = TmpListarDatos("SP_SUMA_AFECTO_HISTO  '" & codempresa.Trim & "','" & VCdTipoDoc.Trim & "','" & NRODOC.Trim & "','" & CStr(FECHADOCUM.Trim) & "'")
        If TABLA_INAFECTO.Rows.Count > 0 Then
            AFECTO = FACT_GMascara(TABLA_INAFECTO.Rows(0)("AFECTO").ToString.Trim, 2).ToString
        End If

        Dim FilaInafecto As String
        FilaInafecto = "OP. INAFECTO"
        FilaInafecto = FilaInafecto & Alineacion("I", 31 - FilaInafecto.Length, "S/.".Trim.Length, "S/.".Trim)
        FilaInafecto = FilaInafecto & Alineacion("I", IntAnchoTicket - FilaInafecto.Length, INAFECTO.Trim.Length, INAFECTO.Trim)
        PrintLine(1, FilaInafecto)

        Dim FilaAfecto As String
        FilaAfecto = "OP. GRAVADA"
        FilaAfecto = FilaAfecto & Alineacion("I", 31 - FilaAfecto.Length, "S/.".Trim.Length, "S/.".Trim)
        FilaAfecto = FilaAfecto & Alineacion("I", IntAnchoTicket - FilaAfecto.Length, AFECTO.Trim.Length, AFECTO.Trim)
        PrintLine(1, FilaAfecto)

        Dim Filaexonerada As String
        Filaexonerada = "OP. EXONERADA"
        Filaexonerada = Filaexonerada & Alineacion("I", 31 - Filaexonerada.Length, "S/.".Trim.Length, "S/.".Trim)
        Filaexonerada = Filaexonerada & Alineacion("I", IntAnchoTicket - Filaexonerada.Length, 0, 0)
        PrintLine(1, Filaexonerada)

        'PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")

        PrintLine(1, "------------------ " & " ----------------")
        PrintLine(1, "ENTREGADO CONFORME " & " RECIBI CONFORME")

        Dim codhash1 As String
        codhash1 = "Cod Hash: " & CODHASH

        Dim StrObserv3 As String = ""
        If codhash1 <> "" Then
            Dim MinObs As Integer = 0
            Dim MxObserv As Integer = codhash1.Length
ReimpObs4:
            If (MxObserv - MinObs) > 38 Then
                StrObserv3 = codhash1.Substring(MinObs, 38)

                PrintLine(1, StrObserv3)
                MinObs += 38
                GoTo ReimpObs4
            Else
                StrObserv3 = codhash1.Substring(MinObs, (MxObserv - MinObs))
                PrintLine(1, Alineacion("I", IntAnchoTicket, StrObserv3.Length, StrObserv3))
            End If
        End If



        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim("Autorizado mediante")), Trim("Autorizado mediante")))
        Dim resolucion1 As String
        resolucion1 = "Resolucion Nro. " & RESOLUCION
        PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(resolucion1)), Trim(resolucion1)))

        Dim pie As String
        pie = "Representacion Impresa de la " & TIPODOCUMENTO & ". Para consultar el documento ingrese a " & URL

        Dim StrObserv4 As String = ""
        If RucRazonSocial <> "" Then

            Dim MinObs As Integer = 0
            Dim MxObserv As Integer = pie.Length
ReimpObs5:

            If (MxObserv - MinObs) > 38 Then
                StrObserv4 = pie.Substring(MinObs, 38)

                PrintLine(1, StrObserv4)
                MinObs += 38
                GoTo ReimpObs5
            Else
                StrObserv4 = pie.Substring(MinObs, (MxObserv - MinObs))
                PrintLine(1, Alineacion("C", IntAnchoTicket, Len(Trim(StrObserv4)), Trim(StrObserv4)))
            End If
        End If


        PrintLine(1, Alineacion("C", IntAnchoTicket, GstrLinea3.Length, GstrLinea3))

        Dim LFoot1, LFoot2, LFoot3, LFoot4, LFoot5, LFoot6, LFoot7, LFoot8, LFoot9, LFoot10 As String

        LFoot1 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT1)), Trim(GstrFOOT1))
        LFoot2 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT2)), Trim(GstrFOOT2))
        LFoot3 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT3)), Trim(GstrFOOT3))
        LFoot4 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT4)), Trim(GstrFOOT4))
        LFoot5 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT5)), Trim(GstrFOOT5))

        LFoot6 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT6)), Trim(GstrFOOT6))

        LFoot7 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT7)), Trim(GstrFOOT7))

        LFoot8 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT8)), Trim(GstrFOOT8))

        LFoot9 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT9)), Trim(GstrFOOT9))

        LFoot10 = Alineacion("C", IntAnchoTicket, Len(Trim(GstrFOOT10)), Trim(GstrFOOT10))

        If Not IsNothing(Trim(LFoot1)) Then
            PrintLine(1, LFoot1)
        End If

        If Not IsNothing(Trim(LFoot2)) Then
            PrintLine(1, LFoot2)
        End If

        If Trim(LFoot3) <> "" Then
            PrintLine(1, LFoot3)
        End If

        If Trim(LFoot4) <> "" Then
            PrintLine(1, LFoot4)
        End If

        If Trim(LFoot5) <> "" Then
            PrintLine(1, LFoot5)
        End If

        If Trim(LFoot6) <> "" Then
            PrintLine(1, LFoot6)
        End If

        If Trim(LFoot7) <> "" Then
            PrintLine(1, LFoot7)
        End If

        If Trim(LFoot8) <> "" Then
            PrintLine(1, LFoot8)
        End If

        If Trim(LFoot9) <> "" Then
            PrintLine(1, LFoot9)
        End If

        If Trim(LFoot10) <> "" Then
            PrintLine(1, LFoot10)
        End If

        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        PrintLine(1, "")
        FileClose(1)


    End Sub



    Public Function Alineacion(ByVal Lugar As String, ByVal Tam_Campo As Integer, ByVal log_text As Integer, ByVal cont_text As String) As String
        If log_text > Tam_Campo Then
            log_text = Tam_Campo
            cont_text = Mid(cont_text, 1, Tam_Campo)
        End If
        Alineacion = ""
        Select Case Lugar
            Case "D"
                Alineacion = Space(Tam_Campo - log_text) + cont_text
            Case "I"
                Alineacion = cont_text + Space(Tam_Campo - log_text)
            Case "C"
                Alineacion = Space((Tam_Campo - log_text) / 2) + cont_text + Space((Tam_Campo - log_text) / 2)
        End Select
        Return Alineacion
    End Function
    Public Function FACT_GMascara(ByVal valor As Double, ByVal numerodecimal As Integer) As String

        Dim IintNumerodeDecimales As Integer
        IintNumerodeDecimales = numerodecimal
        FACT_GMascara = ""
        Select Case IintNumerodeDecimales
            Case 0
                FACT_GMascara = Format(valor, "#######0")
            Case 1
                FACT_GMascara = Format(valor, "#######0.0")
            Case 2
                FACT_GMascara = Format(valor, "#######0.00")
            Case 3
                FACT_GMascara = Format(valor, "#######0.000")
            Case 4
                FACT_GMascara = Format(valor, "#######0.0000")
            Case 5
                FACT_GMascara = Format(valor, "#######0.00000")
            Case 6
                FACT_GMascara = Format(valor, "#######0.000000")
            Case 7
                FACT_GMascara = Format(valor, "#######0.0000000")
            Case 8
                FACT_GMascara = Format(valor, "#######0.00000000")
        End Select
    End Function


    Public Sub ProcesarFormatoTicket()
        GstrLinea1 = String.Empty
        GstrLinea2 = String.Empty
        GstrLinea3 = String.Empty
        GstrLinea4 = String.Empty
        GstrCadCortaTicket = String.Empty
        For i As Integer = 0 To IntAnchoTicket
            GstrLinea1 = GstrLinea1 + "-"
            GstrLinea2 = GstrLinea2 + "-"
            GstrLinea3 = GstrLinea3 + "-"
            GstrLinea4 = GstrLinea4 + "*"
            GstrCadCortaTicket = GstrCadCortaTicket + "-"
        Next
    End Sub

    Public Sub PTOVTASelProc()
        Dim dtset As New DataSet
        dtset.ReadXml(Application.StartupPath + "\config.xml")
        'impresora = dtset.Tables(0).Rows(0)("impresoraptovta").ToString.Trim
        'HoraValidada = dtset.Tables(0).Rows(0)("HoraValidada").ToString.Trim

        Conecta("select * from       PTOVTA   where   TERMINAL='" & Environment.MachineName & "'", "T")
        'GstrRUTAPRN = ds.Tables("T").Rows(0)(13).ToString
        'GbytImpTickResu = (ds.Tables("T").Rows(0)(37).ToString)
        'GintSaltaLineas = (ds.Tables("T").Rows(0)(17).ToString)
        GmaquinaRegist = (ds.Tables("T").Rows(0)(2).ToString)
        'ACTIMPESTIK = (ds.Tables("T").Rows(0)("ACTIMPESTIK").ToString)
        'PEDNROCOMANDSALON = (ds.Tables("T").Rows(0)("PEDNROCOMANDSALON").ToString)

        'ACTIIMPMULT = (ds.Tables("T").Rows(0)("ACTIIMPMULT").ToString)
        'DOCPREIMP = (ds.Tables("T").Rows(0)("DOCPREIMP").ToString)
        'TICKETIMP = (ds.Tables("T").Rows(0)("TICKETIMP").ToString)

        'DISPLAY = (ds.Tables("T").Rows(0)("DISPLAY").ToString)
        'EDIT_PRECIO = (ds.Tables("T").Rows(0)("EDITPRECIO").ToString)
        'MODO_COMPORTAMIENTO = (ds.Tables("T").Rows(0)("MODO_COMPORTAMIENTO").ToString)
        'CDZONA = Trim(ds.Tables("T").Rows(0)("CDZONA").ToString)
        'GR_CDZONA = Trim(ds.Tables("T").Rows(0)("CDZONA").ToString)

        'SALVACDZONA = (ds.Tables("T").Rows(0)("CDZONA").ToString)
        'CDTIPOPRE1 = (ds.Tables("T").Rows(0)("CDTIPOPRE1").ToString)
        'RUTAPRN = (ds.Tables("T").Rows(0)("RUTAPRN").ToString)
        'RUTAKIT = (ds.Tables("T").Rows(0)("RUTAKIT").ToString)


        'ClsData.VSaltoAut = (ds.Tables("T").Rows(0)("SaltoAut").ToString)
        'IMPCONSUMINT = (ds.Tables("T").Rows(0)("IMPCONSUMINT").ToString)
        'PEDIRCANTPRODUC = (ds.Tables("T").Rows(0)("CANTPRODUC").ToString)

        'Conecta("select * from TICKETFORM", "C")
        'GHEAD1 = ds.Tables("C").Rows(0)(0).ToString
        'GHEAD3 = ds.Tables("C").Rows(0)(2).ToString
        'GHEAD4 = ds.Tables("C").Rows(0)(3).ToString
        'GHEAD5 = ds.Tables("C").Rows(0)(4).ToString
        'GHEAD6 = ds.Tables("C").Rows(0)(5).ToString
        'GHEAD7 = ds.Tables("C").Rows(0)(6).ToString
        'GHEAD8 = ds.Tables("C").Rows(0)(7).ToString
        'GHEAD9 = ds.Tables("C").Rows(0)(8).ToString
        'GHEAD10 = ds.Tables("C").Rows(0)(9).ToString

        'GLINES1 = ds.Tables("C").Rows(0)(10).ToString
        'GLINES2 = ds.Tables("C").Rows(0)(11).ToString
        'GLINES3 = ds.Tables("C").Rows(0)(12).ToString
        'GLINES4 = ds.Tables("C").Rows(0)(13).ToString

        'GstrFOOT1 = ds.Tables("C").Rows(0)(14).ToString
        'GstrFOOT2 = ds.Tables("C").Rows(0)(15).ToString
        'GstrFOOT3 = ds.Tables("C").Rows(0)(16).ToString
        'GstrFOOT4 = ds.Tables("C").Rows(0)(17).ToString
        'GstrFOOT5 = ds.Tables("C").Rows(0)(18).ToString
        'GstrFOOT6 = ds.Tables("C").Rows(0)(19).ToString
        'GstrFOOT7 = ds.Tables("C").Rows(0)(20).ToString
        'GstrFOOT8 = ds.Tables("C").Rows(0)(21).ToString
        'GstrFOOT9 = ds.Tables("C").Rows(0)(22).ToString
        'GstrFOOT10 = ds.Tables("C").Rows(0)(23).ToString

    End Sub


    Public Sub ObtenerNroLineasTicket(ByVal Documento As String)
        Dim objReader As New StreamReader(Application.StartupPath & "\" & Documento)
        Dim sLine As String = ""
        VContIni = 0
        VContFin = 0
        Do
            sLine = objReader.ReadLine()
            VContFin += 1
        Loop Until sLine Is Nothing
        objReader.Close()
    End Sub


    Public CANTCORTAPTOVTA As Integer
    Public Sub CortarTicket()
        For ContA As Integer = 1 To 2
            Shell(Application.StartupPath & ("\CortaTicket.exe"))
        Next
    End Sub

    Public Function ValidaNullSTring(ByVal Obj As Object) As Object
        If Microsoft.VisualBasic.IsDBNull(Obj) Then
            Return ""
        Else
            Return Obj.ToString.Trim
        End If
    End Function



End Module
