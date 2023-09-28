Public Class frmBuscarDocumento
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtdocumento As System.Windows.Forms.TextBox
    Friend WithEvents griddata As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarDocumento))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdocumento = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFin = New System.Windows.Forms.DateTimePicker
        Me.DtIni = New System.Windows.Forms.DateTimePicker
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.griddata = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.griddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(352, 296)
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
        Me.BtnSalir.Location = New System.Drawing.Point(8, 12)
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
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Nro Documento :"
        '
        'txtdocumento
        '
        Me.txtdocumento.Location = New System.Drawing.Point(152, 32)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.Size = New System.Drawing.Size(176, 20)
        Me.txtdocumento.TabIndex = 161
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtFin)
        Me.Panel1.Controls.Add(Me.DtIni)
        Me.Panel1.Controls.Add(Me.BtnFiltrar)
        Me.Panel1.Location = New System.Drawing.Point(368, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 46)
        Me.Panel1.TabIndex = 160
        Me.Panel1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "De"
        '
        'dtFin
        '
        Me.dtFin.Checked = False
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(202, 10)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.ShowCheckBox = True
        Me.dtFin.Size = New System.Drawing.Size(102, 20)
        Me.dtFin.TabIndex = 1
        '
        'DtIni
        '
        Me.DtIni.Checked = False
        Me.DtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtIni.Location = New System.Drawing.Point(34, 10)
        Me.DtIni.Name = "DtIni"
        Me.DtIni.ShowCheckBox = True
        Me.DtIni.Size = New System.Drawing.Size(102, 20)
        Me.DtIni.TabIndex = 0
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(318, 6)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(82, 28)
        Me.BtnFiltrar.TabIndex = 1
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'griddata
        '
        Me.griddata.CaptionText = "[Enter para seleccionar]  o Doble clik"
        Me.griddata.DataMember = ""
        Me.griddata.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.griddata.Location = New System.Drawing.Point(8, 72)
        Me.griddata.Name = "griddata"
        Me.griddata.ReadOnly = True
        Me.griddata.Size = New System.Drawing.Size(346, 294)
        Me.griddata.TabIndex = 159
        Me.griddata.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.griddata
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "FEC. DOCUM"
        Me.DataGridTextBoxColumn1.MappingName = "FECDOCUM"
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "NRODOCU"
        Me.DataGridTextBoxColumn2.MappingName = "NRODOCU"
        Me.DataGridTextBoxColumn2.Width = 165
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CODTIPODOC"
        Me.DataGridTextBoxColumn3.MappingName = "CODTIPODOC"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "DSTIPODOC"
        Me.DataGridTextBoxColumn4.MappingName = "DSTIPODOC"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "ACUENTA"
        Me.DataGridTextBoxColumn5.MappingName = "ACUENTA"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "RESTO"
        Me.DataGridTextBoxColumn6.MappingName = "SALDOBAS"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 224)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "# DOCUMENT."
        '
        'frmBuscarDocumento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 376)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdocumento)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.griddata)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarDocumento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Documentos."
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.griddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public dt_data As New DataTable
    Public frmPlorde As New FrmPlanillaOrdenDespacho
    Private SELECT_FILA As Integer
    Public Valor As Boolean = False

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmBuscarDocumento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        griddata.DataSource = dt_data
    End Sub

    Private Sub txtdocumento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdocumento.TextChanged
        For i As Integer = 0 To dt_data.Rows.Count - 1
            griddata.UnSelect(i)
        Next
        For FILA As Integer = 0 To dt_data.Rows.Count - 1
            If Mid(griddata.Item(FILA, 1).ToString.Trim, 1, txtdocumento.Text.Trim.Length) = txtdocumento.Text.Trim Then
                griddata.Select(FILA)
                SELECT_FILA = FILA
                Exit Sub
            End If
        Next
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_kEYDOWN As Integer = &H100
        Const WD_KEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WD_kEYDOWN) Or (MSG.Msg = WD_KEYSYSTEM)) Then
            Select Case KeyData
                Case Keys.Enter
                    If griddata.Focused = True Then
                        Valor = True
                        Me.Close()
                    End If
            End Select
        End If
    End Function


    Private Sub griddata_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griddata.DoubleClick
        Valor = True
        Me.Close()
    End Sub

    Private Sub txtdocumento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdocumento.KeyDown
        If griddata.VisibleRowCount > 0 Then
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            griddata.Focus()
            griddata.Select(SELECT_FILA)
        End If
    End Sub

    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click

    End Sub

    Private Sub griddata_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles griddata.Navigate

    End Sub
End Class
