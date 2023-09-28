Public Class FrmBuscarTipoDoc2
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridTipoDoc As System.Windows.Forms.DataGrid
    Friend WithEvents TxtDatos As System.Windows.Forms.TextBox
    Friend WithEvents CboCriterio As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBuscarTipoDoc2))
        Me.DataGridTipoDoc = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CboCriterio = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDatos = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.DataGridTipoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridTipoDoc
        '
        Me.DataGridTipoDoc.DataMember = ""
        Me.DataGridTipoDoc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTipoDoc.Location = New System.Drawing.Point(8, 74)
        Me.DataGridTipoDoc.Name = "DataGridTipoDoc"
        Me.DataGridTipoDoc.ReadOnly = True
        Me.DataGridTipoDoc.Size = New System.Drawing.Size(504, 212)
        Me.DataGridTipoDoc.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dato: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CboCriterio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtDatos)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 38)
        Me.Panel1.TabIndex = 2
        '
        'CboCriterio
        '
        Me.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCriterio.Items.AddRange(New Object() {"Descripcion", "Codigo"})
        Me.CboCriterio.Location = New System.Drawing.Point(332, 6)
        Me.CboCriterio.Name = "CboCriterio"
        Me.CboCriterio.Size = New System.Drawing.Size(156, 21)
        Me.CboCriterio.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Criterio: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDatos
        '
        Me.TxtDatos.Location = New System.Drawing.Point(46, 8)
        Me.TxtDatos.Name = "TxtDatos"
        Me.TxtDatos.Size = New System.Drawing.Size(206, 20)
        Me.TxtDatos.TabIndex = 2
        Me.TxtDatos.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Busqueda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.GroupBox5.Location = New System.Drawing.Point(436, 292)
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
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(416, 48)
        Me.Label4.TabIndex = 159
        '
        'FrmBuscarTipoDoc2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(526, 366)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.DataGridTipoDoc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarTipoDoc2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Tipo de Documento"
        CType(Me.DataGridTipoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "FIELDS"
    Private TABLE_TIPODOC As New DataTable
    Public DEVOLVER As Boolean
    Private Indice As Integer

#End Region
#Region "FUNCIONES"

    Sub CargarGrid()
        TABLE_TIPODOC = TmpListarDatos("NSP_SELE_TIPODOC_NTACRED  '" & codempresa & "'")
        DataGridTipoDoc.DataSource = TABLE_TIPODOC
        FORMATOGRID()
    End Sub
    Sub FORMATOGRID()
        Dim DatagridTableStyle1 As New DataGridTableStyle
        With DatagridTableStyle1
            .MappingName = TABLE_TIPODOC.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        End With
        Dim GridColumn1 As New DataGridTextBoxColumn
        With GridColumn1
            .MappingName = "Codigo"
            .HeaderText = "codigo"
            .NullText = ""
            .Width = 100
        End With
        Dim GridColumn2 As New DataGridTextBoxColumn
        With GridColumn2
            .MappingName = "Descripcion"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 250
        End With
        DatagridTableStyle1.GridColumnStyles.AddRange(New DataGridColumnStyle() {GridColumn1, GridColumn2})
        DataGridTipoDoc.TableStyles.Add(DatagridTableStyle1)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal Keydata As Keys) As Boolean
        Const Keydown As Integer = &H100
        Const KeySystem As Integer = &H104
        If ((MSG.Msg = Keydown) Or (MSG.Msg = KeySystem)) Then
            Select Case Keydata
                Case Keys.Enter
                    If DataGridTipoDoc.Focus = True Then
                        DataGridTipoDoc.Select(Indice)
                        DEVOLVER = True
                        Me.Close()
                    End If
            End Select
        End If
    End Function


#End Region

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmBuscarTipoDoc2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()
        CboCriterio.SelectedIndex = 0
    End Sub
    Private Sub TxtDatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDatos.TextChanged
        For i As Integer = 0 To TABLE_TIPODOC.Rows.Count - 1
            DataGridTipoDoc.UnSelect(i)
        Next
        If CboCriterio.SelectedIndex = 0 Then
            For i As Integer = 0 To TABLE_TIPODOC.Rows.Count - 1
                If Mid((DataGridTipoDoc.Item(i, 1).tostring.Trim).ToUpper, 1, TxtDatos.Text.Trim.Length) = (TxtDatos.Text.Trim).ToUpper Then
                    DataGridTipoDoc.Select(i)
                    DataGridTipoDoc.CurrentRowIndex = i
                    Indice = i
                    Exit For
                End If
            Next
        Else
            For i As Integer = 0 To TABLE_TIPODOC.Rows.Count - 1
                If Mid((DataGridTipoDoc.Item(i, 0).tostring.Trim).ToUpper, 1, TxtDatos.Text.Trim.Length) = (TxtDatos.Text.Trim).ToUpper Then
                    DataGridTipoDoc.Select(i)
                    DataGridTipoDoc.CurrentRowIndex = i
                    Indice = i
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub DataGridTipoDoc_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridTipoDoc.Navigate

    End Sub

    Private Sub DataGridTipoDoc_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridTipoDoc.CurrentCellChanged
        Indice = DataGridTipoDoc.CurrentRowIndex
    End Sub

    Private Sub DataGridTipoDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridTipoDoc.DoubleClick
        DataGridTipoDoc.Select(Indice)
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub TxtDatos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDatos.KeyDown
        If e.KeyCode = Keys.Enter Then
            DataGridTipoDoc.Select(Indice)
            DataGridTipoDoc.Focus()
        End If
    End Sub
End Class
