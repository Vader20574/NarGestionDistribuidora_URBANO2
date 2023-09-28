Imports System.Data.SqlClient
Imports System.Data

Public Class ClsAyuda

#Region "Cargar Combos"

    Public Sub CargarDataCombo(ByVal DataCombo As ComboBox, ByVal store_procedure As String, ByVal codigo As String, ByVal descripcion As String)
        'Try
        '    If Cn.ConnectionString = String.Empty Then
        '        Cn.ConnectionString = STRCN
        '    End If
        '    If Cn.State = ConnectionState.Open Then
        '        Cn.Close()
        '    End If
        '    Cn.Open()
        '    Dim cmd As New SqlCommand(store_procedure, Cn)
        '    cmd.CommandType = CommandType.Text
        '    Dim dt As New DataTable
        '    Dim da As New SqlDataAdapter(cmd)
        '    da.Fill(dt)
        '    DataCombo.DataSource = dt
        '    DataCombo.ValueMember = codigo
        '    DataCombo.DisplayMember = descripcion
        '    Cn.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = STRCN
            cn.Open()
            Dim cmd As New SqlCommand(store_procedure, cn)
            Dim DSi As New DataSet
            Dim DAT As New SqlDataAdapter
            DAT.SelectCommand = cmd
            DAT.Fill(DSi, "MITABLA")
            DataCombo.DataSource = DSi.Tables("MITABLA")
            DataCombo.ValueMember = codigo.ToString
            DataCombo.DisplayMember = descripcion.ToString
            'cmd.Dispose()
            'cmd = Nothing
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            cn.Close()

        End Try
        cn.Dispose()
        cn = Nothing


    End Sub

    Public Sub conecta_AUX(ByVal sql As String, ByVal tabla As String)
        Try
            Cn = New SqlConnection(STRCN)
            oda = New SqlDataAdapter(sql, Cn)
            'ocmb = New SqlCommandBuilder(oda)
            'ocn.Open()
            'oda.Fill(ds, tabla)
            'ocn.Close()

        Catch x As Exception
            MessageBox.Show(x.Message)
        End Try
    End Sub


    Public Sub GCargaDataCombo(ByVal objDataCombo As Object, ByVal rsSource As Object, ByVal istrCampo1 As String, ByVal istrCampo2 As String)
        On Error Resume Next
        objDataCombo.DataSource = rsSource
        objDataCombo.ValueMember = istrCampo1
        objDataCombo.DisplayMember = istrCampo2
    End Sub

#End Region

#Region "Acciones"

    Public Function ValidaNulls(ByVal Obj As Object) As Object
        If Microsoft.VisualBasic.IsDBNull(Obj) Then
            Return ""
        Else
            Return Obj
        End If
    End Function
    Public Function SoloNumeros(ByVal Keyascii As Short) As Short
        Keyascii = Asc(UCase(Chr(Keyascii)))
        If (InStr("1234567890.", Chr(Keyascii)) = 0) Then
            SoloNumeros = 0
        Else
            SoloNumeros = Keyascii
        End If
        'backspace
        If Keyascii = 8 Then SoloNumeros = Keyascii
        'enter
        If Keyascii = 13 Then SoloNumeros = Keyascii
    End Function
    Public Function ValidaNullsInteger(ByVal Obj As Object) As Object
        If Microsoft.VisualBasic.IsDBNull(Obj) Then
            Return 0
        Else
            Return Obj
        End If
    End Function
    Public Sub CargagridARTICULOPRECIO(ByVal grilla As Object, ByVal store_procedure As String)
        Dim MIDS As New DataSet
        'FALTA VERIFGICAR LOS 2 PROCEDIUMIENTOS.-------------------------------------------------------------<<<<<<<<<
        'MIDS = ListarDatos("CONFIGGRID '" & NROPTOVTA & "','" & codempresa & "'")
        'FACT_CONFIGGRID = MIDS.Tables(0).Rows(0)(0)

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

            '********************************************

            '*******************************************
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
            FilasAyudaG = ncolum
            nombrecolumna = DS.Tables("MITABLA").Columns.Item(0).Caption
            ' falta como hacerle para q los camps tomen un tamaño automatico deacuerdo a su maximo contenido
            'por mientras funciona con dos jejee
            Dim CODIGO As New DataGridTextBoxColumn

            With CODIGO
                .HeaderText = "Codigo"
                .MappingName = "Codigo"
                .Width = 100
                .ReadOnly = True
            End With

            Dim DESCRIPCION As New DataGridTextBoxColumn
            With DESCRIPCION
                .HeaderText = "Descripcion Articulo"
                .MappingName = "Descripcion"
                .Width = 250
                .ReadOnly = True
            End With

            Dim MEDIDA As New DataGridTextBoxColumn
            With MEDIDA
                .HeaderText = "Medida"
                .MappingName = "Medida"
                .Width = 70
                .ReadOnly = True
            End With

            Dim PRESENTACION As New DataGridTextBoxColumn
            With PRESENTACION
                .HeaderText = "Presentacion"
                .MappingName = "Presentacion"
                .Width = 120
                .ReadOnly = True
            End With



            Dim PRECIO_MEDIDA As New DataGridTextBoxColumn
            With PRECIO_MEDIDA
                .HeaderText = "Precio _"
                .MappingName = "Precio_Medida"
                .Width = 50
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Center
                .Format = FACT_GFormatodeNumero(0)
            End With


            Dim UNIDAD As New DataGridTextBoxColumn
            With UNIDAD
                .HeaderText = "Unidad"
                .MappingName = "Unidad"
                .Width = 80
                .ReadOnly = True
            End With

            Dim PRECIO_UNIDAD As New DataGridTextBoxColumn
            With PRECIO_UNIDAD
                .HeaderText = "Precio _"
                .MappingName = "Precio_Unidad"
                .Width = 50
                .ReadOnly = True
                .Alignment = HorizontalAlignment.Right
                .Format = FACT_GFormatodeNumero(0)
            End With

            Dim MONEDA As New DataGridTextBoxColumn
            With MONEDA
                .HeaderText = "Moneda"
                .MappingName = "Moneda"
                .Width = 70
                .Alignment = HorizontalAlignment.Center
                .ReadOnly = True
            End With

            Dim CODUMED As New DataGridTextBoxColumn
            With CODUMED
                .HeaderText = ""
                .MappingName = "CODUMED"
                .Width = 0
                .Alignment = HorizontalAlignment.Center
                .ReadOnly = True
            End With

            Dim IMPORT As New DataGridTextBoxColumn
            With IMPORT
                .HeaderText = "Nro Importacion"
                .MappingName = "NROIMPORTACION"
                .Width = 120
                .ReadOnly = True
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function ValidaNullSTring(ByVal Obj As Object) As Object
        If Microsoft.VisualBasic.IsDBNull(Obj) Then
            Return ""
        Else
            Return Obj.ToString.Trim
        End If
    End Function
    Public Function Ejecutar(ByVal StoreProcedure As String, ByVal ParamArray Argumentos() As System.Object) As Integer

        If Cn.ConnectionString = String.Empty Then
            Cn.ConnectionString = STRCN
        End If

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Cn.Open()

        Dim Dt_TimeOut As Integer = 500000
        Dim mCom As SqlCommand = Comando(StoreProcedure)
        mCom.CommandType = CommandType.StoredProcedure
        mCom.CommandTimeout = Dt_TimeOut
        Dim Rspta As Integer
        CargarParametros(mCom, Argumentos)
        Try
            Rspta = mCom.ExecuteNonQuery
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cn.Close()
        End Try
        Return Rspta

    End Function
    Public Function ListarDatos(ByVal bd As Integer, ByVal StoreProcedure As String, ByVal ParamArray Argumentos() As System.Object) As DataSet

        Try
            If Cn2.ConnectionString = String.Empty Then
                Cn2.ConnectionString = STRCN2
            End If
            If Cn2.State = ConnectionState.Open Then
                Cn2.Close()
            End If
            Cn2.Open()
            Dim mDataset As New DataSet
            CrearDataAdapter2(StoreProcedure, Argumentos).Fill(mDataset)
            Return mDataset
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function Ejecutar(ByVal bd As Integer, ByVal StoreProcedure As String, ByVal ParamArray Argumentos() As System.Object) As Integer

        If Cn2.ConnectionString = String.Empty Then
            Cn2.ConnectionString = STRCN2
        End If

        If Cn2.State = ConnectionState.Open Then
            Cn2.Close()
        End If
        Cn2.Open()

        Dim mCom As SqlCommand = Comando2(StoreProcedure)
        mCom.CommandType = CommandType.StoredProcedure
        Dim Rspta As Integer
        CargarParametros(mCom, Argumentos)
        Try
            Rspta = mCom.ExecuteNonQuery
            Cn2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cn2.Close()
        End Try
        Return Rspta

    End Function

    Public Function ListarDatos(ByVal StoreProcedure As String, ByVal ParamArray Argumentos() As System.Object) As DataSet

        Try
            If Cn.ConnectionString = String.Empty Then
                Cn.ConnectionString = STRCN
            End If
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If
            Cn.Open()
            Dim mDataset As New DataSet
            CrearDataAdapter(StoreProcedure, Argumentos).Fill(mDataset)

            Return mDataset
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    Public Function Valida_Solo_Lectura(ByVal fecha As Date) As Boolean
        Dim activo As Boolean
        activo = CBool(CAyuda.ListarDatos("SP_VALIDA_REG_HISTORICO", codempresa, fecha.ToString("dd/MM/yyyy")).Tables(0).Rows(0)(0))
        If activo = True Then
            MsgBox("EL REGISTRO ESTA EN MODO LECTURA.", MsgBoxStyle.Information, "NARSISTEMAS")
        End If
        Return activo
    End Function

#End Region

#Region "Poner Parametros"
    Shared mColComandos As New System.Collections.Hashtable
    Protected Function Comando(ByVal storeProcedure As String) As System.Data.IDbCommand
        Dim mComando As SqlCommand
        If mColComandos.Contains(storeProcedure) = True Then
            mComando = CType(mColComandos.Item(storeProcedure), SqlCommand)
        Else
            mComando = New SqlCommand(storeProcedure, Cn)
            Dim mConstructor As New SqlCommandBuilder
            mComando.CommandType = CommandType.StoredProcedure
            SqlCommandBuilder.DeriveParameters(mComando)
            mColComandos.Add(storeProcedure, mComando)
        End If
        Return mComando
    End Function
    Protected Function Comando2(ByVal storeProcedure As String) As System.Data.IDbCommand
        Dim mComando As SqlCommand
        If mColComandos.Contains(storeProcedure) = True Then
            mComando = CType(mColComandos.Item(storeProcedure), SqlCommand)
        Else
            mComando = New SqlCommand(storeProcedure, Cn2)
            Dim mConstructor As New SqlCommandBuilder
            mComando.CommandType = CommandType.StoredProcedure
            SqlCommandBuilder.DeriveParameters(mComando)
            mColComandos.Add(storeProcedure, mComando)
        End If
        Return mComando
    End Function

    Protected Sub CargarParametros(ByVal Comandos As System.Data.IDbCommand, ByVal Args() As Object)
        Dim i As Integer
        With Comandos
            For i = 0 To Args.GetUpperBound(0)
                Try
                    CType(.Parameters(i + 1), SqlParameter).Value = Args(i)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End With

    End Sub


#End Region


#Region "Devolver Parametros"
    Protected Function CrearDataAdapter(ByVal ProcedimientoAlmacenado As String, _
    ByVal ParamArray Args() As Object) As IDataAdapter

        Dim Dt_TimeOut As Integer = 50000

        Dim mCom As SqlCommand = Comando(ProcedimientoAlmacenado)
        mCom.CommandTimeout = Dt_TimeOut

        If Not Args Is Nothing Then
            CargarParametros(mCom, Args)
        End If
        Return New SqlDataAdapter(mCom)
    End Function
    Protected Function CrearDataAdapter2(ByVal ProcedimientoAlmacenado As String, _
ByVal ParamArray Args() As Object) As IDataAdapter
        Dim mCom As SqlCommand = Comando2(ProcedimientoAlmacenado)
        If Not Args Is Nothing Then
            CargarParametros(mCom, Args)
        End If
        Return New SqlDataAdapter(mCom)
    End Function
#End Region

End Class

