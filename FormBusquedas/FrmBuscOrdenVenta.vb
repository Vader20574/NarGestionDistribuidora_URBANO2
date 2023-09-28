Public Class FrmBuscOrdenVenta
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GridOrdenDesp As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtOrdenDespacho As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ChkAnul As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscOrdenVenta))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GridOrdenDesp = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtOrdenDespacho = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ChkAnul = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFin = New System.Windows.Forms.DateTimePicker
        Me.DtIni = New System.Windows.Forms.DateTimePicker
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.GroupBox5.SuspendLayout()
        CType(Me.GridOrdenDesp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(434, 335)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 163
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(6, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Nro Orden  Venta"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "#Orden de Venta"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "HH:mm:ss tt"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Hora Salida"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 85
        '
        'GridOrdenDesp
        '
        Me.GridOrdenDesp.CaptionText = "[Enter para seleccionar]  o Doble clik"
        Me.GridOrdenDesp.DataMember = ""
        Me.GridOrdenDesp.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridOrdenDesp.Location = New System.Drawing.Point(4, 113)
        Me.GridOrdenDesp.Name = "GridOrdenDesp"
        Me.GridOrdenDesp.ReadOnly = True
        Me.GridOrdenDesp.Size = New System.Drawing.Size(424, 294)
        Me.GridOrdenDesp.TabIndex = 159
        Me.GridOrdenDesp.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridOrdenDesp
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 85
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Estado"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 35
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'txtOrdenDespacho
        '
        Me.txtOrdenDespacho.Location = New System.Drawing.Point(103, 62)
        Me.txtOrdenDespacho.Name = "txtOrdenDespacho"
        Me.txtOrdenDespacho.Size = New System.Drawing.Size(170, 20)
        Me.txtOrdenDespacho.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 222)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "#  VENTA"
        '
        'ChkAnul
        '
        Me.ChkAnul.Location = New System.Drawing.Point(279, 59)
        Me.ChkAnul.Name = "ChkAnul"
        Me.ChkAnul.Size = New System.Drawing.Size(78, 20)
        Me.ChkAnul.TabIndex = 165
        Me.ChkAnul.Text = "Anulados"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtFin)
        Me.Panel1.Controls.Add(Me.DtIni)
        Me.Panel1.Controls.Add(Me.BtnFiltrar)
        Me.Panel1.Location = New System.Drawing.Point(16, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 46)
        Me.Panel1.TabIndex = 166
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
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(394, 6)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(82, 28)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'FrmBuscOrdenVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(517, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ChkAnul)
        Me.Controls.Add(Me.GridOrdenDesp)
        Me.Controls.Add(Me.txtOrdenDespacho)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscOrdenVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Orden Venta"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GridOrdenDesp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "FIELDS"
    Public TIPO As String
    Public DEVOLVER As Boolean
    Private TABLE_ORDENDESPACHO As New DataTable
    Private SELECT_FILA As Integer


    Dim rand As Integer
    Dim fechaini, fechahas As Date
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String



#End Region
#Region "FUNCIONES"
    Sub CargarDatos(ByVal TIPO As String)

        Dim FechaIni, FechaFin As String

        TmpInsertDatos("DELETE FROM TMP_GUIAINTERNACAB  WHERE CORREL='" & rand & "'")

        FechaIni = Format(CDate(DtIni.Value), "dd/MM/yyyy")
        FechaFin = Format(CDate(dtFin.Value), "dd/MM/yyyy")

        nromeses = DateDiff("m", FechaIni, FechaFin)
        For i As Integer = 0 To nromeses
            NomTablaC = "GUIAC" & Format(DateAdd("m", i, FechaIni), "yyyyMM")
            NomTablaD = "GUIAD" & Format(DateAdd("m", i, FechaIni), "yyyyMM")

            If TmpListarDatos("VERIFICA_HISTOGUIAINTERNA   '" & codempresa & "','" & NomTablaC & "'  ").Rows.Count <> 0 Then
                TmpInsertDatos("INS_LISTAR_ORDENVENTACAB  '" & codempresa & "','" & TIPO & "','" & FechaIni & "','" & FechaFin & "','" & rand & "','" & NomTablaC & "','" & NomTablaD & "'")
            End If
        Next
        TmpInsertDatos("INS_LISTAR_ORDENVENTACAB  '" & codempresa & "','" & TIPO & "','" & FechaIni & "','" & FechaFin & "','" & rand & "','',''")


        TABLE_ORDENDESPACHO = TmpListarDatos("NSP_LISTAR_ORDEN_DESPACHO  '" & rand & "'")

        GridOrdenDesp.DataSource = TABLE_ORDENDESPACHO
        DataGridTableStyle1.MappingName = TABLE_ORDENDESPACHO.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "FECDESPACHO"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "NRODESPACHO"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "HORADESPACHO"
        DataGridTableStyle1.GridColumnStyles(3).MappingName = "RESPONSABLE"
        DataGridTableStyle1.GridColumnStyles(4).MappingName = "GUIAC"
        DataGridTableStyle1.GridColumnStyles(5).MappingName = "GUIAD"
        GridOrdenDesp.TableStyles.Add(DataGridTableStyle1)

    End Sub
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

    Private Sub FrmBuscOrdenVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos(TIPO)
        ValorRan()
    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function



    Private Sub txtOrdenDespacho_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrdenDespacho.TextChanged
        For i As Integer = 0 To TABLE_ORDENDESPACHO.Rows.Count - 1
            GridOrdenDesp.UnSelect(i)
        Next
        For FILA As Integer = 0 To TABLE_ORDENDESPACHO.Rows.Count - 1
            If Mid(GridOrdenDesp.Item(FILA, 1).ToString.Trim, 1, txtOrdenDespacho.Text.Trim.Length) = txtOrdenDespacho.Text.Trim Then
                GridOrdenDesp.Select(FILA)
                SELECT_FILA = FILA
                Exit Sub
            End If
        Next
    End Sub
    Private Sub GridOrdenDesp_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridOrdenDesp.Navigate

    End Sub

    Private Sub GridOrdenDesp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOrdenDesp.DoubleClick
        If TABLE_ORDENDESPACHO.Rows.Count > 0 Then
            DEVOLVER = True
            Me.Close()
        End If


    End Sub

    Private Sub GridOrdenDesp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridOrdenDesp.KeyDown
        If e.KeyCode = Keys.Enter Then
            DEVOLVER = True
            Me.Close()
        End If
    End Sub

    Private Sub txtOrdenDespacho_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrdenDespacho.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridOrdenDesp.Focus()
            GridOrdenDesp.Select(SELECT_FILA)
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub ChkAnul_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAnul.CheckedChanged
        If ChkAnul.Checked = True Then
            CargarDatos("A")
        Else
            CargarDatos(TIPO)
        End If
    End Sub

    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        CargarDatos(TIPO)
    End Sub
End Class
