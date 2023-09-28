Public Class frmBuscaDocumentoHor
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
    Friend WithEvents txtOrdenDespacho As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents griddata As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBuscaDocumentoVenta))
        Me.griddata = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtOrdenDespacho = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.griddata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'griddata
        '
        Me.griddata.CaptionText = "[Enter para seleccionar]  o Doble clik"
        Me.griddata.DataMember = ""
        Me.griddata.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.griddata.Location = New System.Drawing.Point(8, 40)
        Me.griddata.Name = "griddata"
        Me.griddata.ReadOnly = True
        Me.griddata.Size = New System.Drawing.Size(312, 294)
        Me.griddata.TabIndex = 166
        Me.griddata.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.griddata
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "FEC DOCUM"
        Me.DataGridTextBoxColumn1.MappingName = "FECDOCUM"
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "NRODOCU"
        Me.DataGridTextBoxColumn2.MappingName = "NRODOCU"
        Me.DataGridTextBoxColumn2.Width = 120
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
        Me.DataGridTextBoxColumn6.HeaderText = "PAGCREDBAS"
        Me.DataGridTextBoxColumn6.MappingName = "PAGCREDBAS"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'txtOrdenDespacho
        '
        Me.txtOrdenDespacho.Location = New System.Drawing.Point(104, 16)
        Me.txtOrdenDespacho.Name = "txtOrdenDespacho"
        Me.txtOrdenDespacho.Size = New System.Drawing.Size(170, 20)
        Me.txtOrdenDespacho.TabIndex = 167
        Me.txtOrdenDespacho.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Nro Documento"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 222)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "#  DOCUMENT"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(320, 264)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 169
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
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmBuscaDocumentoVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(394, 342)
        Me.Controls.Add(Me.griddata)
        Me.Controls.Add(Me.txtOrdenDespacho)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscaDocumentoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Documento"
        CType(Me.griddata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public dt_data As New DataTable
    Public valor As Boolean
    Dim SELECT_FILA As Integer
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_kEYDOWN As Integer = &H100
        Const WD_KEYSYSTEM As Integer = &H104

        If ((MSG.Msg = WD_kEYDOWN) Or (MSG.Msg = WD_KEYSYSTEM)) Then
            Select Case KeyData
                Case Keys.Enter
                    If griddata.Focus = True Then
                        valor = True
                        Me.Close()
                    End If
            End Select
        End If
    End Function

    Private Sub frmBuscaDocumentoVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        griddata.DataSource = dt_data
    End Sub

    Private Sub griddata_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles griddata.Navigate

    End Sub

    Private Sub griddata_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles griddata.DoubleClick
        If dt_data.Rows.Count > 0 Then
            valor = True
            Me.Close()
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub txtOrdenDespacho_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrdenDespacho.TextChanged

        For i As Integer = 0 To dt_data.Rows.Count - 1
            griddata.UnSelect(i)
        Next
        For FILA As Integer = 0 To dt_data.Rows.Count - 1
            If Mid(griddata.Item(FILA, 1).ToString.Trim, 1, txtOrdenDespacho.Text.Trim.Length) = txtOrdenDespacho.Text.Trim Then
                griddata.Select(FILA)
                SELECT_FILA = FILA
                Exit Sub
            End If
        Next

    End Sub
End Class
