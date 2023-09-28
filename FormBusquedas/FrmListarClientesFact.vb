Public Class FrmListarClientesFact
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
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboFiltrar As System.Windows.Forms.ComboBox
    Friend WithEvents GridCli As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridCli = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboFiltrar = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.GridCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridCli
        '
        Me.GridCli.BackgroundColor = System.Drawing.Color.White
        Me.GridCli.CaptionBackColor = System.Drawing.Color.Silver
        Me.GridCli.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCli.CaptionForeColor = System.Drawing.Color.Black
        Me.GridCli.CaptionText = "Registro de Clientes"
        Me.GridCli.DataMember = ""
        Me.GridCli.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridCli.Location = New System.Drawing.Point(10, 48)
        Me.GridCli.Name = "GridCli"
        Me.GridCli.ReadOnly = True
        Me.GridCli.Size = New System.Drawing.Size(703, 309)
        Me.GridCli.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 38)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CboFiltrar
        '
        Me.CboFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltrar.Items.AddRange(New Object() {"Codigo", "Descripcion", "Direccion", "Ruc"})
        Me.CboFiltrar.Location = New System.Drawing.Point(486, 12)
        Me.CboFiltrar.Name = "CboFiltrar"
        Me.CboFiltrar.Size = New System.Drawing.Size(196, 21)
        Me.CboFiltrar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filtrar : "
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(43, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(323, 20)
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
        'FrmListarClientesFact
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(730, 370)
        Me.Controls.Add(Me.GridCli)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListarClientesFact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Clientes"
        CType(Me.GridCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "Variables"
    Dim TABLECLIENT As New DataTable
    Public DEVOLVER As Boolean

#End Region

#Region "Funciones"

    Private Sub CargarGridForm()
        TABLECLIENT = TmpListarDatos("SP_LISTAR_CLIENTE_FACT  '" & codempresa & "','" & CboFiltrar.SelectedIndex & "'")
        GridCli.DataSource = TABLECLIENT
    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLECLIENT.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        End With

        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODCLIENTE"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 75
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DATOADJUNTO"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 350
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "DIRECCION"
            .HeaderText = "Direccion"
            .NullText = ""
            .Width = 350
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "RUC"
            .HeaderText = "Ruc"
            .NullText = ""
            .Width = 75
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "CODDEP"
            .HeaderText = "CODDEP"
            .NullText = ""
            .Width = 0
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5})
        GridCli.TableStyles.Add(TableStyle1)

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean

        Select Case KeyData
            Case Keys.Enter
                If TABLECLIENT.Rows.Count > 0 Then
                    If GridCli.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
                End If

            Case Keys.Escape
                Me.Close()
        End Select

    End Function


#End Region

    Private Sub FrmListarClientesFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboFiltrar.SelectedIndex = 1
        CargarGridForm()
        FormatoGrid()

    End Sub

     

    Private Sub CboFiltrar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboFiltrar.SelectedIndexChanged
        CargarGridForm()

    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        Select Case CboFiltrar.SelectedIndex
            Case 0
                For i As Integer = 0 To TABLECLIENT.Rows.Count - 1
                    If CStr(Mid(GridCli.Item(i, 0), 1, txtdato.Text.Trim.Length)).ToUpper = txtdato.Text.Trim.ToUpper Then
                        GridCli.CurrentRowIndex = i
                        Exit Sub
                    End If
                Next
            Case 1
                For i As Integer = 0 To TABLECLIENT.Rows.Count - 1
                    If CStr(Mid(GridCli.Item(i, 1), 1, txtdato.Text.Trim.Length)).ToUpper = txtdato.Text.Trim.ToUpper Then
                        GridCli.CurrentRowIndex = i
                        Exit Sub
                    End If
                Next
            Case 2
                For i As Integer = 0 To TABLECLIENT.Rows.Count - 1
                    If CStr(Mid(GridCli.Item(i, 2), 1, txtdato.Text.Trim.Length)).ToUpper = txtdato.Text.Trim.ToUpper Then
                        GridCli.CurrentRowIndex = i
                        Exit Sub
                    End If
                Next
            Case 3
                For i As Integer = 0 To TABLECLIENT.Rows.Count - 1
                    If CStr(Mid(GridCli.Item(i, 3), 1, txtdato.Text.Trim.Length)).ToUpper = txtdato.Text.Trim.ToUpper Then
                        GridCli.CurrentRowIndex = i
                        Exit Sub
                    End If
                Next




        End Select

    End Sub

    Private Sub GridCli_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridCli.Navigate

    End Sub

    Private Sub GridCli_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCli.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub
End Class
