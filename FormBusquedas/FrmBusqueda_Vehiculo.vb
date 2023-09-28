Public Class FrmBusqueda_Vehiculo
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
    Friend WithEvents txtDato As System.Windows.Forms.TextBox
    Friend WithEvents DatagridVehiculo As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBusqueda_Vehiculo))
        Me.DatagridVehiculo = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtDato = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboCriterio = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        CType(Me.DatagridVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatagridVehiculo
        '
        Me.DatagridVehiculo.DataMember = ""
        Me.DatagridVehiculo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DatagridVehiculo.Location = New System.Drawing.Point(10, 68)
        Me.DatagridVehiculo.Name = "DatagridVehiculo"
        Me.DatagridVehiculo.ReadOnly = True
        Me.DatagridVehiculo.Size = New System.Drawing.Size(568, 290)
        Me.DatagridVehiculo.TabIndex = 0
        Me.DatagridVehiculo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DatagridVehiculo
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn1.MappingName = ""
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripcion"
        Me.DataGridTextBoxColumn2.MappingName = ""
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Placa"
        Me.DataGridTextBoxColumn3.MappingName = ""
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Certificado"
        Me.DataGridTextBoxColumn4.MappingName = ""
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Color"
        Me.DataGridTextBoxColumn5.MappingName = ""
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 150
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Marca"
        Me.DataGridTextBoxColumn6.MappingName = ""
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'txtDato
        '
        Me.txtDato.Location = New System.Drawing.Point(52, 12)
        Me.txtDato.Name = "txtDato"
        Me.txtDato.Size = New System.Drawing.Size(236, 20)
        Me.txtDato.TabIndex = 1
        Me.txtDato.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dato : "
        '
        'CboCriterio
        '
        Me.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCriterio.Location = New System.Drawing.Point(386, 8)
        Me.CboCriterio.Name = "CboCriterio"
        Me.CboCriterio.Size = New System.Drawing.Size(166, 21)
        Me.CboCriterio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Criterio :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtDato)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CboCriterio)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(6, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 44)
        Me.Panel1.TabIndex = 5
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(504, 366)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 158
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
        'FrmBusqueda_Vehiculo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 446)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DatagridVehiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqueda_Vehiculo"
        Me.Text = "Busqueda Vehiculo"
        CType(Me.DatagridVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "FIELDS"
    Public FilaSelec As Integer
    Public DEVOLVER As Boolean
    Private TABLE_VEHI As New DataTable

#End Region

#Region "FUNCIONES"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const Wd_KeyDown As Integer = &H100
        Const Wd_SysKeyDown As Integer = &H104

        If ((MSG.Msg = Wd_KeyDown) Or (MSG.Msg = Wd_SysKeyDown)) Then
            Select Case (KeyData)
                Case Keys.Enter
                    If DatagridVehiculo.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
                    DatagridVehiculo.Select(FilaSelec)
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function
    Sub CargarGrid()
        TABLE_VEHI = CAyuda.ListarDatos("NSP_TRAER_VEHICULO", codempresa).Tables(0)
        DatagridVehiculo.DataSource = TABLE_VEHI

        DataGridTableStyle1.MappingName = TABLE_VEHI.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "CODVEHI"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "DESVEHI"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "PLACA"
        DataGridTableStyle1.GridColumnStyles(3).MappingName = "CERTIFICADO"
        DataGridTableStyle1.GridColumnStyles(4).MappingName = "COLOR"
        DataGridTableStyle1.GridColumnStyles(5).MappingName = "MARCA"

        DatagridVehiculo.TableStyles.Add(DataGridTableStyle1)

    End Sub

#End Region


    Private Sub FrmBusqueda_Vehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboCriterio.Items.Add("Codigo")
        CboCriterio.Items.Add("Placa")
        CboCriterio.Items.Add("MARCA")
        CboCriterio.SelectedIndex = 0
        CargarGrid()

    End Sub
    Private Sub txtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDato.TextChanged
        For i As Integer = 0 To TABLE_VEHI.Rows.Count - 1
            DatagridVehiculo.UnSelect(i)
        Next
        Select Case CboCriterio.SelectedIndex
            Case 0
                For i As Integer = 0 To TABLE_VEHI.Rows.Count - 1
                    If Mid(TABLE_VEHI.Rows(i)("CODVEHI").tostring.Trim.ToUpper, 1, txtDato.Text.Trim.Length) = txtDato.Text.Trim.ToUpper Then
                        DatagridVehiculo.Select(i)
                        FilaSelec = i
                        Exit Sub
                    End If
                Next
            Case 1
                For i As Integer = 0 To TABLE_VEHI.Rows.Count - 1
                    If Mid(TABLE_VEHI.Rows(i)("PLACA").tostring.Trim.ToUpper, 1, txtDato.Text.Trim.Length) = txtDato.Text.Trim.ToUpper Then
                        DatagridVehiculo.Select(i)
                        FilaSelec = i
                        Exit Sub
                    End If
                Next
            Case 2
                For i As Integer = 0 To TABLE_VEHI.Rows.Count - 1
                    If Mid(TABLE_VEHI.Rows(i)("MARCA").tostring.Trim.ToUpper, 1, txtDato.Text.Trim.Length) = txtDato.Text.Trim.ToUpper Then
                        DatagridVehiculo.Select(i)
                        FilaSelec = i
                        Exit Sub
                    End If
                Next
        End Select
    End Sub

    Private Sub DatagridVehiculo_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DatagridVehiculo.Navigate

    End Sub

    Private Sub DatagridVehiculo_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DatagridVehiculo.CurrentCellChanged
        FilaSelec = DatagridVehiculo.CurrentRowIndex
    End Sub

    Private Sub DatagridVehiculo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DatagridVehiculo.DoubleClick
        DEVOLVER = True
        FilaSelec = DatagridVehiculo.CurrentRowIndex
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
End Class
