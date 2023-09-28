Public Class FrmBuscarProveedor
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgProveedor As System.Windows.Forms.DataGrid
    Friend WithEvents CboFiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DgProveedor = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboFiltrar = New System.Windows.Forms.ComboBox
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DgProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgProveedor
        '
        Me.DgProveedor.CaptionText = "                                              Seleccionar -->[Enter]   ó    [Dobl" & _
        "e Click]"
        Me.DgProveedor.DataMember = ""
        Me.DgProveedor.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgProveedor.Location = New System.Drawing.Point(14, 60)
        Me.DgProveedor.Name = "DgProveedor"
        Me.DgProveedor.ReadOnly = True
        Me.DgProveedor.Size = New System.Drawing.Size(634, 262)
        Me.DgProveedor.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboFiltrar)
        Me.GroupBox1.Controls.Add(Me.TxtDato)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 44)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CboFiltrar
        '
        Me.CboFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltrar.Items.AddRange(New Object() {"Codigo", "Razon Social", "Ruc"})
        Me.CboFiltrar.Location = New System.Drawing.Point(458, 12)
        Me.CboFiltrar.Name = "CboFiltrar"
        Me.CboFiltrar.Size = New System.Drawing.Size(158, 21)
        Me.CboFiltrar.TabIndex = 1
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(42, 14)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(308, 20)
        Me.TxtDato.TabIndex = 0
        Me.TxtDato.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(422, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Filtrar : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmBuscarProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscarProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de  Proveedor"
        CType(Me.DgProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables de Form"
    Public DEVOLVER As Boolean
    Private TAB_PROVEE As New DataTable




#End Region

#Region "Funciones de Form"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If TAB_PROVEE.Rows.Count > 0 Then
                        If DgProveedor.Focus = True Then
                            DEVOLVER = True
                            Me.Close()
                        End If
                    End If

                Case Keys.Escape
                    Me.Close()

            End Select



        End If



    End Function



    Private Sub CargarGrid()
        TAB_PROVEE = TmpListarDatos("ListarPROVEEDORxProc   '" & codempresa & "'")
        DgProveedor.DataSource = TAB_PROVEE


    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle

        With TableStyle1
            .MappingName = TAB_PROVEE.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODPROVEEDOR"
            .NullText = ""
            .HeaderText = "Codproveedor"
            .Width = 100
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DESPROVEEDOR"
            .NullText = ""
            .HeaderText = "Razon Social"
            .Width = 200
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "RUC"
            .NullText = ""
            .HeaderText = "Ruc"
            .Width = 100
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "DIRECCION"
            .NullText = ""
            .HeaderText = "Direccion"
            .Width = 250
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4})
        DgProveedor.TableStyles.Add(TableStyle1)

    End Sub

#End Region



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub
    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgProveedor.Navigate
    End Sub
    Private Sub FrmBuscarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()
        FormatoGrid()
        CboFiltrar.SelectedIndex = 1
        TxtDato.Focus()
    End Sub

    Private Sub DgProveedor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgProveedor.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged

        For i As Integer = 0 To TAB_PROVEE.Rows.Count - 1

            Select Case CboFiltrar.SelectedIndex
                Case 0
                    If CStr(DgProveedor.Item(i, 0)).Trim.Length >= TxtDato.Text.Trim.Length Then
                        If CStr(Mid(DgProveedor.Item(i, 0), 1, TxtDato.Text.Trim.Length)).ToUpper = TxtDato.Text.Trim.ToUpper Then
                            DgProveedor.CurrentRowIndex = i
                            Exit For
                        End If
                    End If
                Case 1
                    If CStr(DgProveedor.Item(i, 1)).Trim.Length >= TxtDato.Text.Trim.Length Then
                        If CStr(Mid(DgProveedor.Item(i, 1), 1, TxtDato.Text.Trim.Length)).ToUpper = TxtDato.Text.Trim.ToUpper Then
                            DgProveedor.CurrentRowIndex = i
                            Exit For
                        End If
                    End If
                Case 2
                    If CStr(DgProveedor.Item(i, 2)).Trim.Length >= TxtDato.Text.Trim.Length Then
                        If CStr(Mid(DgProveedor.Item(i, 2), 1, TxtDato.Text.Trim.Length)).ToUpper = TxtDato.Text.Trim.ToUpper Then
                            DgProveedor.CurrentRowIndex = i
                            Exit For
                        End If
                    End If
            End Select
        Next

    End Sub
End Class
