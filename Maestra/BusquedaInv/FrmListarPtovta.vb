Public Class FrmListarPtovta
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgArticulo As System.Windows.Forms.DataGrid
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DgArticulo = New System.Windows.Forms.DataGrid
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.Panel1.SuspendLayout()
        CType(Me.DgArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rbmedida)
        Me.Panel1.Controls.Add(Me.rbcodigo)
        Me.Panel1.Controls.Add(Me.TxtDato)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 38)
        Me.Panel1.TabIndex = 3
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(60, 8)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(230, 20)
        Me.TxtDato.TabIndex = 1
        Me.TxtDato.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato : "
        '
        'DgArticulo
        '
        Me.DgArticulo.DataMember = ""
        Me.DgArticulo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgArticulo.Location = New System.Drawing.Point(4, 54)
        Me.DgArticulo.Name = "DgArticulo"
        Me.DgArticulo.ReadOnly = True
        Me.DgArticulo.Size = New System.Drawing.Size(534, 264)
        Me.DgArticulo.TabIndex = 2
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(394, 8)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(104, 16)
        Me.rbmedida.TabIndex = 5
        Me.rbmedida.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(314, 8)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FrmListarPtovta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 328)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListarPtovta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Ptovta"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "VARIABLES"
    Private TABLE_ART As New DataTable
    Public DEVOLVER As Boolean

#End Region
#Region "FUNCIONES"
    Protected Overrides Function ProcessCmdKey(ByRef Msg As Message, ByVal KeyData As Keys) As Boolean
        Const WIN_KEYDOWN As Integer = &H100
        Const WIN_SYSTEM As Integer = &H104
        If ((Msg.Msg = WIN_KEYDOWN) Or (Msg.Msg = WIN_SYSTEM)) Then
            Select Case KeyData
                Case Keys.Enter
                    If TABLE_ART.Rows.Count > 0 Then
                        If DgArticulo.Focus = True Then
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
        TABLE_ART = TmpListarDatos("SP_LISTA_PTOVTA  '" & codempresa & "' ")
        DgArticulo.DataSource = TABLE_ART
    End Sub

    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_ART.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "NROPTOVTA"
            .HeaderText = "NroPtovta"
            .Width = 120
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "TERMINAL"
            .HeaderText = "Terminal"
            .Width = 200
        End With
        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "NROSERIE"
            .HeaderText = "Nroserie"
            .Width = 200
        End With
        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "RESPONABLE"
            .HeaderText = "Responsable"
            .Width = 200
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColumn1, DataColumn2, DataColumn3, DataColumn4})
        DgArticulo.TableStyles.Add(TableStyle1)
    End Sub

#End Region
    Private Sub FrmListarPtovta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()
        FormatoGrid()

        TxtDato.Focus()
    End Sub

    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged

        llena()

    End Sub

    Sub llena()

        If Me.TxtDato.Text.Trim = "" Then

            TABLE_ART = TmpListarDatos("SP_LISTA_PTOVTA  '" & codempresa & "' ")
            DgArticulo.DataSource = TABLE_ART
            'FormatoGrid()
        Else
            If Me.rbcodigo.Checked = True Then
                TABLE_ART = CAyuda.ListarDatos("SP_LISTA_PTOVTA_FILTRO", codempresa.ToString(), 0, TxtDato.Text).Tables(0)
                DgArticulo.DataSource = TABLE_ART
                'FormatoGrid()
            Else
                TABLE_ART = CAyuda.ListarDatos("SP_LISTA_PTOVTA_FILTRO", codempresa.ToString(), 1, TxtDato.Text).Tables(0)
                DgArticulo.DataSource = TABLE_ART
                'FormatoGrid()
            End If
        End If

    End Sub




    Private Sub DgArticulo_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgArticulo.Navigate

    End Sub

    Private Sub DgArticulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgArticulo.DoubleClick
        DEVOLVER = True
        Me.Close()

    End Sub

    Private Sub DgArticulo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DgArticulo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DEVOLVER = True
            Me.Close()
        End If
    End Sub
End Class
