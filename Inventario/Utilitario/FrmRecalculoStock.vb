Public Class FrmRecalculoStock
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboAlmacen)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recalculo"
        '
        'CboAlmacen
        '
        Me.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAlmacen.Location = New System.Drawing.Point(68, 16)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(256, 21)
        Me.CboAlmacen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almacen : "
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(54, 82)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(100, 23)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "Calcular &Stock"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(278, 82)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 23)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'FrmRecalculoStock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(430, 116)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmRecalculoStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recalculo de Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Fields  Form"


#End Region


#Region "Reclaculo de Stock"

    Private Sub SeleccionaIngresos(ByVal StrAlmacen As String, ByVal datFechaini As String, ByVal datFechaFin As String)

        Try
            Dim CADI As String
            Dim CADF As String

            CADI = datFechaini & " 00:00:00"
            CADF = datFechaFin & " 23:59:00"

            TmpInsertDatos("LLENA_TMP_RECALCULO1  '" & codempresa & "','" & StrAlmacen & "','" & CADI & "','" & CADF & "'")

        Catch ex As Exception
            MsgBox(ex.Message & " seleccionar Artidat")
        End Try


    End Sub

    Private Sub GENERA_SALDO(ByVal StrAlmacen As String)
        Try
            Dim StrSql As String
            StrSql = " EXEC GENERA_SALDO   '" & codempresa & "','" & StrAlmacen & "'"
            TmpInsertDatos(StrSql)
        Catch ex As Exception
            MsgBox(ex.Message & " GENERA_SALDO")
        End Try

    End Sub

    Private Sub SeleccionaVentasHistorico(ByVal StrNumTabla As String, ByVal strstrAlmacen As String, ByVal datFechaini As String, ByVal datFechaFin As String)
        Try
            Dim StrSql As String
            Dim CADI As String
            Dim CADF As String
            CADI = datFechaini & " 00:00:00"
            CADF = datFechaFin & " 23:59:00"
            StrSql = " EXEC  LLENA_TMP_RECALCULO4    '" & codempresa & "','" & strstrAlmacen & "','" & CADI & "','" & CADF & "','" & StrNumTabla & "'"
            TmpInsertDatos(StrSql)

        Catch ex As Exception
            MsgBox(ex.Message & " SeleccionaVentasHistorico")
        End Try

    End Sub

    Private Function VERIFICA_HISTORICOVENT(ByVal StrHistorico As String) As Boolean
        Try

            Dim StrSql As String
            Dim rs As New DataTable
            StrSql = " EXEC   VERIFICA_HISTORICOVENT    '" & codempresa & "','" & StrHistorico & "'"
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


    Private Sub SeleccionaVentas(ByVal StrAlmacen As String, ByVal datFechaini As String, ByVal datFechaFin As String)

        Try
            Dim CADI As String
            Dim CADF As String
            CADI = datFechaini & " 00:00:00"
            CADF = datFechaFin & " 23:59:00"

            TmpInsertDatos("LLENA_TMP_RECALCULO3  '" & codempresa & "','" & StrAlmacen & "' ,'" & CADI & "','" & CADF & "'")


        Catch ex As Exception
            MsgBox(ex.Message & " SeleccionaVentas")

        End Try

    End Sub



    Private Sub SeleccionaSalidas(ByVal StrAlmacen As String, ByVal datFechaini As String, ByVal datFechaFin As String)
        Try

            Dim CADI As String
            Dim CADF As String

            CADI = datFechaini & " 00:00:00"
            CADF = datFechaFin & " 23:59:00"
            TmpInsertDatos("LLENA_TMP_RECALCULO2   '" & codempresa & "','" & StrAlmacen & "','" & CADI & "','" & CADF & "'")

        Catch ex As Exception
            MsgBox(ex.Message & " SeleccionaSalidas")
        End Try

    End Sub

    Private Function BuscaUltCierre(ByVal StrAlmacen As String) As String
        Dim StrCad As String
        Dim rs As New DataTable

        StrCad = "SELECT ISNULL(MAX(FECHA),'01/01/1800 00:00:00') AS MAX_FECHA FROM RESUKDX WHERE ALMACEN='" & StrAlmacen & "' AND  CODEMPRESA='" & codempresa & "' "
        rs = TmpListarDatos(StrCad)

        'If Not IsNothing(rs.Rows(0)("MAX_FECHA")) Then
        BuscaUltCierre = Format(rs.Rows(0)("MAX_FECHA"), "dd/MM/yyyy")

        'Else
        '    BuscaUltCierre = "01/01/1800 00:00:00"
        'End If

    End Function

    Private Sub SeleccinaArtidatResukdk(ByVal StrAlmacen As String, ByVal DatFecha As String)
        Try
            Dim StrSql As String
            StrSql = " EXEC SELECT_RESUKDX_RECALCULO  '" & codempresa & "','" & StrAlmacen & "','" & DatFecha & "'"
            TmpInsertDatos(StrSql)

        Catch ex As Exception
            MsgBox(ex.Message & " SeleccinaArtidatResukdk")
        End Try
    End Sub

    Private Sub BORRATMPRECALCULO()
        Try
            TmpInsertDatos("BORRA_TMPRECALCULO  '" & codempresa & "'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SeleccionaArtidat(ByVal StrAlmacen As String)
        Try
            Dim StrSql As String
            StrSql = " EXEC LLENA_TMP_RECALCULO    '" & codempresa & "','" & StrAlmacen & "'"
            TmpInsertDatos(StrSql)

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub



#End Region
    Dim h As Boolean

    Private Sub FrmRecalculoStock_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If h = True Then
            MsgBox("Hay un proceso en ejecuacion, espere . . .", MsgBoxStyle.Information, DesEmpresa)
            e.Cancel = True
        End If
    End Sub
    Private Sub FrmRecalculoStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(CboAlmacen, "SELECT  CODALMACEN,DESALMACEN FROM ALMACEN  WHERE  CODEMPRESA='" & codempresa & "'", "CODALMACEN", "DESALMACEN")




        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Me.Cursor = Cursors.WaitCursor
        Me.BtnAceptar.Enabled = False
        Me.BtnCancelar.Enabled = False
        Dim hilo As New Threading.Thread(AddressOf CalcularStock)
        hilo.IsBackground = True
        hilo.Start()


    End Sub

    Sub CalcularStock()
        h = True
        Dim CDALMACEN, FIni, FFin As String

        CDALMACEN = Trim(CboAlmacen.SelectedValue)
        FIni = BuscaUltCierre(Trim(CDALMACEN))
        FFin = Format(CDate(Date.Now).AddDays(1), "dd/MM/yyyy")

        ''Borrar los temporales
        Call BORRATMPRECALCULO()

        ''''cargar los articulos  de artidat
        Call SeleccionaArtidat(CDALMACEN)

        ''''Cargar de ResuKdx 
        Call SeleccinaArtidatResukdk(CDALMACEN, FIni)

        Call SeleccionaIngresos(Trim(CDALMACEN), FIni, FFin)
        Call SeleccionaSalidas(Trim(CDALMACEN), FIni, FFin)
        Call SeleccionaVentas(Trim(CDALMACEN), FIni, FFin)

        Dim NOMTABLAC, NomTablaD As String
        Dim Nromeses As Long
        Dim i As Integer
        'VENTAS ---> SALIDA
        Nromeses = DateDiff("m", CDate(FIni), CDate(Date.Now).AddDays(1))

        For i = 0 To Nromeses
            NOMTABLAC = "VENTC" & Format(DateAdd("m", i, CDate(FIni)), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, CDate(FIni)), "yyyyMM")

            If Not VERIFICA_HISTORICOVENT(NOMTABLAC) Then
                GoTo Sgte
            End If
            Call SeleccionaVentasHistorico(NomTablaD, Trim(CDALMACEN), FIni, FFin)
Sgte:
        Next i
        Call GENERA_SALDO(Trim(CDALMACEN))
        Me.Cursor = Cursors.Default
        MsgBox("EL RECALCULO FUE SATISFACTORIO..", MsgBoxStyle.Information, DesEmpresa)
        Me.BtnAceptar.Enabled = True
        Me.BtnCancelar.Enabled = True
        h = False
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub
End Class
