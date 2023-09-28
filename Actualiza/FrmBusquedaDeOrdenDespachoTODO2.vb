Public Class FrmBusquedaDeOrdenDespachoTODO2
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents GridOrdenDesp As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents BtnReporte As System.Windows.Forms.Button
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnQuitaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents LstSelecRuta As System.Windows.Forms.ListBox
    Friend WithEvents LstDispRuta As System.Windows.Forms.ListBox
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaDeOrdenDespachoTODO2))
        Me.GridOrdenDesp = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFin = New System.Windows.Forms.DateTimePicker
        Me.DtIni = New System.Windows.Forms.DateTimePicker
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnReporte = New System.Windows.Forms.Button
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtnQuitaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnQuitaUno_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaUno_Ruta = New System.Windows.Forms.Button
        Me.LstSelecRuta = New System.Windows.Forms.ListBox
        Me.LstDispRuta = New System.Windows.Forms.ListBox
        CType(Me.GridOrdenDesp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridOrdenDesp
        '
        Me.GridOrdenDesp.CaptionText = "[Enter para seleccionar]  o Doble clik"
        Me.GridOrdenDesp.DataMember = ""
        Me.GridOrdenDesp.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridOrdenDesp.Location = New System.Drawing.Point(24, 289)
        Me.GridOrdenDesp.Name = "GridOrdenDesp"
        Me.GridOrdenDesp.ReadOnly = True
        Me.GridOrdenDesp.Size = New System.Drawing.Size(1030, 216)
        Me.GridOrdenDesp.TabIndex = 3
        Me.GridOrdenDesp.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridOrdenDesp
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 85
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "#OD"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 50
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = "HH:mm:ss tt"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Hora Salida"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Responsable"
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Estado"
        Me.DataGridTextBoxColumn5.Width = 40
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Numero Planilla"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Nro Planilla Desc"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Monto Desc"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Rechazo"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "I.Inicial"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "I.Actual"
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Contado"
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Saldo"
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(390, 6)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(82, 28)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtFin)
        Me.Panel1.Controls.Add(Me.DtIni)
        Me.Panel1.Controls.Add(Me.BtnFiltrar)
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 46)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "De"
        '
        'dtFin
        '
        Me.dtFin.Checked = False
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(260, 8)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.ShowCheckBox = True
        Me.dtFin.Size = New System.Drawing.Size(124, 20)
        Me.dtFin.TabIndex = 3
        '
        'DtIni
        '
        Me.DtIni.Checked = False
        Me.DtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtIni.Location = New System.Drawing.Point(34, 8)
        Me.DtIni.Name = "DtIni"
        Me.DtIni.ShowCheckBox = True
        Me.DtIni.Size = New System.Drawing.Size(144, 20)
        Me.DtIni.TabIndex = 2
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(806, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(10, 72)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(1044, 325)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1061, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 233)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "# DESPACHO"
        '
        'BtnReporte
        '
        Me.BtnReporte.Location = New System.Drawing.Point(520, 17)
        Me.BtnReporte.Name = "BtnReporte"
        Me.BtnReporte.Size = New System.Drawing.Size(82, 28)
        Me.BtnReporte.TabIndex = 6
        Me.BtnReporte.Text = "Reportes"
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(37, 128)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(550, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Tipo Anulacion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(179, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Tipo Anulacion"
        '
        'BtnQuitaTodo_Ruta
        '
        Me.BtnQuitaTodo_Ruta.ImageIndex = 10
        Me.BtnQuitaTodo_Ruta.Location = New System.Drawing.Point(489, 211)
        Me.BtnQuitaTodo_Ruta.Name = "BtnQuitaTodo_Ruta"
        Me.BtnQuitaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo_Ruta.TabIndex = 65
        Me.BtnQuitaTodo_Ruta.Text = "<<"
        '
        'BtnQuitaUno_Ruta
        '
        Me.BtnQuitaUno_Ruta.ImageIndex = 8
        Me.BtnQuitaUno_Ruta.Location = New System.Drawing.Point(489, 171)
        Me.BtnQuitaUno_Ruta.Name = "BtnQuitaUno_Ruta"
        Me.BtnQuitaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno_Ruta.TabIndex = 64
        Me.BtnQuitaUno_Ruta.Text = "<"
        '
        'BtnPasaTodo_Ruta
        '
        Me.BtnPasaTodo_Ruta.ImageIndex = 9
        Me.BtnPasaTodo_Ruta.Location = New System.Drawing.Point(489, 131)
        Me.BtnPasaTodo_Ruta.Name = "BtnPasaTodo_Ruta"
        Me.BtnPasaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo_Ruta.TabIndex = 63
        Me.BtnPasaTodo_Ruta.Text = ">>"
        '
        'BtnPasaUno_Ruta
        '
        Me.BtnPasaUno_Ruta.ImageIndex = 7
        Me.BtnPasaUno_Ruta.Location = New System.Drawing.Point(489, 91)
        Me.BtnPasaUno_Ruta.Name = "BtnPasaUno_Ruta"
        Me.BtnPasaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno_Ruta.TabIndex = 62
        Me.BtnPasaUno_Ruta.Text = ">"
        '
        'LstSelecRuta
        '
        Me.LstSelecRuta.Location = New System.Drawing.Point(553, 87)
        Me.LstSelecRuta.Name = "LstSelecRuta"
        Me.LstSelecRuta.Size = New System.Drawing.Size(310, 160)
        Me.LstSelecRuta.TabIndex = 61
        '
        'LstDispRuta
        '
        Me.LstDispRuta.Location = New System.Drawing.Point(177, 87)
        Me.LstDispRuta.Name = "LstDispRuta"
        Me.LstDispRuta.Size = New System.Drawing.Size(302, 160)
        Me.LstDispRuta.TabIndex = 60
        '
        'FrmBusquedaDeOrdenDespachoTODO2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1117, 531)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnQuitaTodo_Ruta)
        Me.Controls.Add(Me.BtnQuitaUno_Ruta)
        Me.Controls.Add(Me.BtnPasaTodo_Ruta)
        Me.Controls.Add(Me.BtnPasaUno_Ruta)
        Me.Controls.Add(Me.LstSelecRuta)
        Me.Controls.Add(Me.LstDispRuta)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.BtnReporte)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GridOrdenDesp)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusquedaDeOrdenDespachoTODO2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda De OrdenDespacho"
        CType(Me.GridOrdenDesp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "FIELDS"
    Public TIPO As String
    Public DEVOLVER As Boolean
    Private TABLE_ORDENDESPACHO As New DataTable
    Private SELECT_FILA As Integer


    Private Tb_RutaDisponible As New DataTable
    Private Tb_RutaModSelec As New DataTable

    Dim rand As Integer
    Dim fechaini, fechahas As Date
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String

    Dim GUIAC As String
    Dim GUIAD As String



#End Region

#Region "FUNCIONES"

    Sub CargarDatos(ByVal TIPO As String)



        TmpInsertDatos("DELETE FROM TMP_ORDENDESPACHO  WHERE CORREL='" & rand & "'")





        Dim FechaIni, FechaFin As String
        FechaIni = Format(CDate(DtIni.Value), "dd/MM/yyyy")
        FechaFin = Format(CDate(dtFin.Value), "dd/MM/yyyy")


        nromeses = DateDiff("m", FechaIni, FechaFin)

        For i As Integer = 0 To nromeses

            NomTablaC = "VENTC" & Format(DateAdd("m", i, FechaIni), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, FechaIni), "yyyyMM")
            GUIAC = "GUIAC" & Format(DateAdd("m", i, FechaIni), "yyyyMM")
            GUIAD = "GUIAD" & Format(DateAdd("m", i, FechaIni), "yyyyMM")


            If VERIFICA_HISTORICOVENT(NomTablaC) = True Then
                TmpInsertDatos("INS_LISTAR_ORDEN_DESPACHO_TODO  '" & codempresa & "','" & FechaIni & "','" & FechaFin & "','" & rand & "','" & NomTablaC & "','" & GUIAC & "'")
            End If
        Next


        TmpInsertDatos("INS_LISTAR_ORDEN_DESPACHO_TODO  '" & codempresa & "','" & FechaIni & "','" & FechaFin & "','" & rand & "','',''")

        TABLE_ORDENDESPACHO = TmpListarDatos("NSP_LISTAR_ORDEN_DESPACHO_TODO  '" & rand & "'")
        GridOrdenDesp.DataSource = TABLE_ORDENDESPACHO

        DataGridTableStyle1.MappingName = TABLE_ORDENDESPACHO.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "FECDESPACHO"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "NRODESPACHO"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "HORADESPACHO"
        DataGridTableStyle1.GridColumnStyles(3).MappingName = "RESPONSABLE"
        DataGridTableStyle1.GridColumnStyles(4).MappingName = "ESTADO"
        DataGridTableStyle1.GridColumnStyles(5).MappingName = "NROPLANILLA"

        DataGridTableStyle1.GridColumnStyles(6).MappingName = "NroPlanillaDesc"
        DataGridTableStyle1.GridColumnStyles(7).MappingName = "MONTODES"
        DataGridTableStyle1.GridColumnStyles(8).MappingName = "RECHAZO"

        DataGridTableStyle1.GridColumnStyles(9).MappingName = "INCIAL"
        DataGridTableStyle1.GridColumnStyles(10).MappingName = "ACTUALIZADO"
        DataGridTableStyle1.GridColumnStyles(11).MappingName = "CONTADO"
        DataGridTableStyle1.GridColumnStyles(12).MappingName = "SALDO"



        GridOrdenDesp.TableStyles.Add(DataGridTableStyle1)
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







    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_kEYDOWN As Integer = &H100
        Const WD_KEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WD_kEYDOWN) Or (MSG.Msg = WD_KEYSYSTEM)) Then
            Select Case KeyData
                Case Keys.Enter
                    If GridOrdenDesp.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
            End Select
        End If
    End Function

#End Region




    Private Sub FrmBusquedaDeOrdenDespacho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValorRan()

        CargarDatos(TIPO)



        Tb_RutaDisponible = TmpListarDatos("SP_LISTAR_TIPOANULFACT '" & codempresa & "'")
        Tb_RutaModSelec = TmpListarDatos("SP_LISTAR_TIPOANULFACT '" & 4566 & "'")
        CargarModulo()
    End Sub

    Private Sub CargarModulo()
        LstDispRuta.DataSource = Tb_RutaDisponible
        LstDispRuta.ValueMember = "Codigo"
        LstDispRuta.DisplayMember = "Descripcion"

        LstSelecRuta.DataSource = Tb_RutaModSelec
        LstSelecRuta.ValueMember = "Codigo"
        LstSelecRuta.DisplayMember = "Descripcion"
    End Sub


    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Private Sub txtOrdenDespacho_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'For i As Integer = 0 To TABLE_ORDENDESPACHO.Rows.Count - 1
        '    GridOrdenDesp.UnSelect(i)
        'Next
        'For FILA As Integer = 0 To TABLE_ORDENDESPACHO.Rows.Count - 1
        '    If Mid(GridOrdenDesp.Item(FILA, 1).ToString.Trim, 1, txtOrdenDespacho.Text.Trim.Length) = txtOrdenDespacho.Text.Trim Then
        '        GridOrdenDesp.Select(FILA)
        '        SELECT_FILA = FILA
        '        Exit Sub
        '    End If
        'Next
    End Sub

    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        If DtIni.Checked = True And dtFin.Checked = True Then
            CargarDatos(5)
        End If






    End Sub

    Private Sub GridOrdenDesp_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridOrdenDesp.Navigate

    End Sub

    Private Sub GridOrdenDesp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOrdenDesp.DoubleClick
        DEVOLVER = True
        Me.Close()

    End Sub

    Private Sub GridOrdenDesp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridOrdenDesp.KeyDown
        If e.KeyCode = Keys.Enter Then
            DEVOLVER = True
            Me.Close()
        End If
    End Sub

    Private Sub txtOrdenDespacho_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If GridOrdenDesp.VisibleRowCount > 0 Then
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            GridOrdenDesp.Focus()
            GridOrdenDesp.Select(SELECT_FILA)
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub





    Private Sub BtnReporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReporte.Click

        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "Rpt_Orden_Despacho_todo.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

            crRpt.set_StoredProcParam(0, rand)
            'crRpt.set_StoredProcParam(1, ACTIVOCLIENTE)
            'crRpt.set_Formulas(0, "formTotLetras='" & formTotLetrasDoc.Trim & "'")
            'crRpt.set_Formulas(1, "formnundoc='" & TxtDoc1.Text.Trim & "'")
            'crRpt.set_Formulas(2, "numero='" & TxtDoc2.Text.Trim & "'")

            crRpt.set_Formulas(0, "Empresa='" & codempresa & "'")
            crRpt.set_Formulas(1, "Usuario='" & DesUsuario & "'")

            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        TmpInsertDatos(String.Format("DELETE FROM TMP_RPT_DOCUM_ANUL WHERE CORREL={0}", rand))

        Dim FechaIni, FechaFin As String
        FechaIni = Format(CDate(DtIni.Value), "dd/MM/yyyy")
        FechaFin = Format(CDate(dtFin.Value), "dd/MM/yyyy")


        nromeses = DateDiff("m", FechaIni, FechaFin)

        For i As Integer = 0 To nromeses

            NomTablaC = "VENTC" & Format(DateAdd("m", i, FechaIni), "yyyyMM")
            NomTablaD = "VENTD" & Format(DateAdd("m", i, FechaIni), "yyyyMM")

            If VERIFICA_HISTORICOVENT(NomTablaC) = True Then

                CAyuda.Ejecutar("SP_RPT_DOCUM_ANULADOS2", rand, codempresa, Format(DtIni.Value, "dd/MM/yyyy"), Format(dtFin.Value, "dd/MM/yyyy"), NomTablaC)

            End If
        Next

        CAyuda.Ejecutar("SP_RPT_DOCUM_ANULADOS2", rand, codempresa, Format(DtIni.Value, "dd/MM/yyyy"), Format(dtFin.Value, "dd/MM/yyyy"), "VENTACAB")



        Try
            With crRpt
                .ReportFileName = RutaRptInv & "Rpt_Cuadre_Ventas2.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & DtIni.Value.ToShortDateString & "'")
                .set_Formulas(3, "FechaH='" & dtFin.Value.ToShortDateString & "'")

                .set_StoredProcParam(0, rand)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Dim Sql As String

        Sql = "DELETE  FROM tmp_tipoanulacion "
        If TmpInsertDatos(Sql) = True Then
        End If

        For i As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Sql = "NSP_INSERT_tmp_tipoanulacion '" & codempresa & "','" & Tb_RutaModSelec.Rows(i)("Codigo").ToString.Trim & "','" & rand & "'"
            If TmpInsertDatos(Sql) = True Then
            End If
        Next


        Try
            With crRpt
                .ReportFileName = RutaRptInv & "Rpt_Cuadre_Ventas3.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_Formulas(2, "FechaIni='" & DtIni.Value.ToShortDateString & "'")
                .set_Formulas(3, "FechaH='" & dtFin.Value.ToShortDateString & "'")

                .set_StoredProcParam(0, rand)
                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        TmpInsertDatos(String.Format("DELETE FROM TMP_RPT_DOCUM_ANUL WHERE CORREL={0}", rand))



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub BtnPasaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaUno_Ruta.Click
        PasarUno_Ruta()
    End Sub
    Private Sub PasarUno_Ruta()
        If Tb_RutaDisponible.Rows.Count > 0 Then

            Dim FILA As DataRow = Tb_RutaModSelec.NewRow
            FILA("Codigo") = LstDispRuta.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstDispRuta.Text.Trim
            Tb_RutaModSelec.Rows.Add(FILA)

            For F As Integer = 0 To Tb_RutaDisponible.Rows.Count - 1
                If LstDispRuta.SelectedValue.ToString.Trim = Tb_RutaDisponible.Rows(F)("Codigo").ToString.Trim Then
                    Tb_RutaDisponible.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub PasarTodo_Ruta()

        For F As Integer = 0 To Tb_RutaDisponible.Rows.Count - 1
            Dim FILA As DataRow = Tb_RutaModSelec.NewRow
            FILA("Codigo") = Tb_RutaDisponible.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_RutaDisponible.Rows(F)("Descripcion").ToString.Trim
            Tb_RutaModSelec.Rows.Add(FILA)
        Next
        Tb_RutaDisponible.Rows.Clear()
    End Sub


    Private Sub QuitarUno_Ruta()
        If Tb_RutaModSelec.Rows.Count > 0 Then
            Dim FILA As DataRow = Tb_RutaDisponible.NewRow
            FILA("Codigo") = LstSelecRuta.SelectedValue.ToString.Trim
            FILA("Descripcion") = LstSelecRuta.Text.Trim
            Tb_RutaDisponible.Rows.Add(FILA)
            For F As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
                If LstSelecRuta.SelectedValue.ToString.Trim = Tb_RutaModSelec.Rows(F)("Codigo").ToString.Trim Then
                    Tb_RutaModSelec.Rows.RemoveAt(F)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub QuitarTodo_Ruta()

        For F As Integer = 0 To Tb_RutaModSelec.Rows.Count - 1
            Dim FILA As DataRow = Tb_RutaDisponible.NewRow
            FILA("Codigo") = Tb_RutaModSelec.Rows(F)("Codigo").ToString.Trim
            FILA("Descripcion") = Tb_RutaModSelec.Rows(F)("Descripcion").ToString.Trim
            Tb_RutaDisponible.Rows.Add(FILA)
        Next
        Tb_RutaModSelec.Rows.Clear()

    End Sub

    Private Sub BtnPasaTodo_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPasaTodo_Ruta.Click
        PasarTodo_Ruta()
    End Sub

    Private Sub BtnQuitaUno_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaUno_Ruta.Click
        QuitarUno_Ruta()
    End Sub

    Private Sub BtnQuitaTodo_Ruta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitaTodo_Ruta.Click
        QuitarTodo_Ruta()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class
