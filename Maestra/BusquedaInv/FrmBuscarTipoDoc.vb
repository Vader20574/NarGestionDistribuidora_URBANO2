Public Class FrmBucarTipoDoc
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
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Ivory
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(8, 58)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(814, 220)
        Me.grid1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbmedida)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 40)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(328, 19)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(88, 16)
        Me.rbmedida.TabIndex = 3
        Me.rbmedida.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(256, 16)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(43, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(205, 20)
        Me.txtdato.TabIndex = 1
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
        'FrmBucarTipoDoc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 288)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBucarTipoDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Tipo de Documento"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones Form"
    Private Sub cargadatos()
        TAB_TIPODOC = TmpListarDatos("nsp_sele_tipodoc '" & codempresa & "'")
        grid1.DataSource = TAB_TIPODOC
    End Sub

    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_TIPODOC.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "Codigo"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 50
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "Descripcion"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 300
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "Abreviatura"
            .HeaderText = "Abrev"
            .NullText = ""
            .Width = 50
        End With
        Dim Column4 As New DataGridBoolColumn
        With Column4
            .MappingName = "Nota_de_Credito"
            .HeaderText = "Nta Cred"
            .NullText = ""
            .Width = 50
        End With
        Dim Column5 As New DataGridBoolColumn
        With Column5
            .MappingName = "CONTABLE"
            .HeaderText = "Contable"
            .NullText = ""
            .Width = 50
        End With

        Dim Column6 As New DataGridBoolColumn
        With Column6
            .MappingName = "COMPRBTECOBRO"
            .HeaderText = "Comprabante Cobro"
            .NullText = ""
            .Width = 120
        End With

        Dim Column7 As New DataGridBoolColumn
        With Column7
            .MappingName = "COMPRBTEPAGO"
            .HeaderText = "Comprabante Pago"
            .NullText = ""
            .Width = 120
        End With

        Dim Column8 As New DataGridBoolColumn
        With Column8
            .MappingName = "PERCEP"
            .HeaderText = "PERCEP"
            .NullText = ""
            .Width = 120
        End With

        Dim Column9 As New DataGridBoolColumn
        With Column9
            .MappingName = "PERCEPT"
            .HeaderText = "PERCEPT"
            .NullText = ""
            .Width = 120
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3})
        TableStyle1.GridColumnStyles.AddRange(New DataGridBoolColumn() {Column4, Column5, Column6, Column7, Column8, Column9})
        grid1.TableStyles.Add(TableStyle1)


    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If grid1.Focus = True Then
                        Dim Sender As Object = Nothing
                        Dim e As EventArgs = Nothing
                        grid1_DoubleClick(Sender, e)
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select

        End If
    End Function

#End Region

#Region "Variables Form"
    Private TAB_TIPODOC As New DataTable

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call quita_maxi_min_form(Me)
        cargadatos()
        FormatoGrid()
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        Dim FRM As New FrmTipoDoc
        Dim obj As New FrmTipoDoc
        VAR1 = grid1.Item(grid1.CurrentRowIndex, 0)
        VAR2 = grid1.Item(grid1.CurrentRowIndex, 1)
        VAR3 = grid1.Item(grid1.CurrentRowIndex, 2)
        VAR4 = grid1.Item(grid1.CurrentRowIndex, 3)
        VAR5 = grid1.Item(grid1.CurrentRowIndex, 4)
        VAR6 = grid1.Item(grid1.CurrentRowIndex, 5)
        VAR7 = grid1.Item(grid1.CurrentRowIndex, 6)
        VAR8 = grid1.Item(grid1.CurrentRowIndex, 7)
        VAR9 = grid1.Item(grid1.CurrentRowIndex, 8)
        obj.mostrar()
        Me.Close()

    End Sub
    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        llena()


    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then
            
                TAB_TIPODOC = TmpListarDatos("Nsp_Sele_tipodoc_1 '','','" & codempresa & "'")
                grid1.DataSource = TAB_TIPODOC

            Else
                TAB_TIPODOC = TmpListarDatos("Nsp_Sele_tipodoc_1 '','','" & codempresa & "'")
                grid1.DataSource = TAB_TIPODOC
            End If
        Else
            If Me.rbcodigo.Checked = True Then
                TAB_TIPODOC = TmpListarDatos("Nsp_Sele_tipodoc_1 '" & Me.txtdato.Text.Trim & "','','" & codempresa & "'")
                grid1.DataSource = TAB_TIPODOC
            Else
                TAB_TIPODOC = TmpListarDatos("Nsp_Sele_tipodoc_1 '','" & Me.txtdato.Text.Trim & "','" & codempresa & "'")
                grid1.DataSource = TAB_TIPODOC
            End If
        End If
    End Sub


    Private Sub rbcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcodigo.CheckedChanged

    End Sub

    Private Sub rbmedida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbmedida.CheckedChanged

    End Sub
End Class
