Public Class FrmGridSubLinea
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
    Friend WithEvents CboFiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridSubCat As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridSubCat = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboFiltrar = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.GridSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridSubCat
        '
        Me.GridSubCat.BackgroundColor = System.Drawing.Color.White
        Me.GridSubCat.CaptionBackColor = System.Drawing.Color.Silver
        Me.GridSubCat.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSubCat.CaptionForeColor = System.Drawing.Color.Black
        Me.GridSubCat.CaptionText = "Registro de SubCategoria"
        Me.GridSubCat.DataMember = ""
        Me.GridSubCat.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridSubCat.Location = New System.Drawing.Point(8, 46)
        Me.GridSubCat.Name = "GridSubCat"
        Me.GridSubCat.ReadOnly = True
        Me.GridSubCat.Size = New System.Drawing.Size(474, 309)
        Me.GridSubCat.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 38)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'CboFiltrar
        '
        Me.CboFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltrar.Items.AddRange(New Object() {"Codigo", "Descripcion"})
        Me.CboFiltrar.Location = New System.Drawing.Point(280, 12)
        Me.CboFiltrar.Name = "CboFiltrar"
        Me.CboFiltrar.Size = New System.Drawing.Size(196, 21)
        Me.CboFiltrar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(232, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filtrar : "
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(43, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(149, 20)
        Me.txtdato.TabIndex = 0
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'FrmGridSubLinea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(500, 390)
        Me.Controls.Add(Me.GridSubCat)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGridSubLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Sub Categoria"
        CType(Me.GridSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public DEVOLVER As Boolean
    Private TMP_GRID As New DataTable

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    DEVOLVER = True
                    Me.Close()
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function

    Private Sub FORMATO_GRID_SUBCATEGORIA()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_GRID.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "Código"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 100
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "Descripción"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 250
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2})
        GridSubCat.TableStyles.Add(TableStyle1)

    End Sub


    Private Sub FrmGridSubLinea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TMP_GRID = TmpListarDatos("NSP_Select_Listado_SubLinea  '" & codempresa & "'")
        GridSubCat.DataSource = TMP_GRID
        FORMATO_GRID_SUBCATEGORIA()
        CboFiltrar.SelectedIndex = 1

    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        For i As Integer = 0 To TMP_GRID.Rows.Count - 1
            Select Case CboFiltrar.SelectedIndex
                Case 0
                    If CStr(Mid(GridSubCat.Item(i, 0), 1, txtdato.Text.Trim)).ToUpper = txtdato.Text.Trim.ToUpper Then
                        GridSubCat.CurrentRowIndex = i
                        Exit Sub
                    End If
                Case 1
                    If CStr(Mid(GridSubCat.Item(i, 1), 1, txtdato.Text.Trim)).ToUpper = txtdato.Text.Trim.ToUpper Then
                        GridSubCat.CurrentRowIndex = i
                        Exit Sub
                    End If
            End Select
        Next

    End Sub

    Private Sub GridSubCat_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridSubCat.Navigate

    End Sub

    Private Sub GridSubCat_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSubCat.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub
End Class
