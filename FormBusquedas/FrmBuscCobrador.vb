Public Class FrmBuscCobrador
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
    Friend WithEvents DgCobrador As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboFiltrar As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DgCobrador = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboFiltrar = New System.Windows.Forms.ComboBox
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DgCobrador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgCobrador
        '
        Me.DgCobrador.CaptionText = "DobleClik o Enter para Seleccionar"
        Me.DgCobrador.DataMember = ""
        Me.DgCobrador.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgCobrador.Location = New System.Drawing.Point(8, 50)
        Me.DgCobrador.Name = "DgCobrador"
        Me.DgCobrador.ReadOnly = True
        Me.DgCobrador.Size = New System.Drawing.Size(452, 264)
        Me.DgCobrador.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboFiltrar)
        Me.GroupBox1.Controls.Add(Me.TxtDato)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 42)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'CboFiltrar
        '
        Me.CboFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFiltrar.Items.AddRange(New Object() {"Codigo", "Nombre"})
        Me.CboFiltrar.Location = New System.Drawing.Point(312, 14)
        Me.CboFiltrar.Name = "CboFiltrar"
        Me.CboFiltrar.Size = New System.Drawing.Size(132, 21)
        Me.CboFiltrar.TabIndex = 2
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(40, 10)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(192, 20)
        Me.TxtDato.TabIndex = 1
        Me.TxtDato.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Filtrar: "
        '
        'FrmBuscCobrador
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(470, 324)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgCobrador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscCobrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cobrador"
        CType(Me.DgCobrador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "Variables"
    Public DEVOLVER As Boolean
    Private TAB_COBRADOR As New DataTable
#End Region

#Region "Funciones"

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If TAB_COBRADOR.Rows.Count > 0 Then
                        If DgCobrador.Focus = True Then
                            DEVOLVER = True
                            Me.Close()
                        End If
                    End If
            End Select
        End If




    End Function


    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_COBRADOR.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CDCOBRADOR"
            .NullText = ""
            .HeaderText = "Codigo"
            .Width = 50
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "NOMCOBRADOR"
            .NullText = ""
            .HeaderText = "Nombre"
            .Width = 250
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2})
        DgCobrador.TableStyles.Add(TableStyle1)
    End Sub


#End Region

    Private Sub FrmBuscCobrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TAB_COBRADOR = TmpListarDatos("SELECT  * FROM COBRADOR  WHERE CODEMPRESA='" & codempresa & "' AND ESTADO=1")
        DgCobrador.DataSource = TAB_COBRADOR
        FormatoGrid()
        CboFiltrar.SelectedIndex = 1

    End Sub

    Private Sub DgCobrador_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgCobrador.Navigate

    End Sub

    Private Sub DgCobrador_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgCobrador.DoubleClick
        DEVOLVER = True
        Me.Close()

    End Sub

    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged

        For i As Integer = 0 To TAB_COBRADOR.Rows.Count - 1
            Select Case CboFiltrar.SelectedIndex
                Case 0
                    If CStr(DgCobrador.Item(i, 0)).Trim.Length < TxtDato.Text.Trim.Length Then
                        Exit Select
                    End If
                    If CStr(Mid(DgCobrador.Item(i, 0), 1, TxtDato.Text.Trim.Length)).Trim.ToUpper = TxtDato.Text.Trim.ToUpper Then
                        DgCobrador.CurrentRowIndex = i
                        Exit For
                    End If
                Case 1
                    If CStr(DgCobrador.Item(i, 1)).Trim.Length < TxtDato.Text.Trim.Length Then
                        Exit Select
                    End If
                    If CStr(Mid(DgCobrador.Item(i, 1), 1, TxtDato.Text.Trim.Length)).Trim.ToUpper = TxtDato.Text.Trim.ToUpper Then
                        DgCobrador.CurrentRowIndex = i
                        Exit For
                    End If
            End Select
        Next
    End Sub
End Class
