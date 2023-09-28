Public Class FrmBuscaCatClient
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Codigo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.Codigo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Descripcion = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.grid1.Location = New System.Drawing.Point(8, 64)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(448, 172)
        Me.grid1.TabIndex = 15
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.Codigo, Me.Descripcion})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = """"""
        '
        'Codigo
        '
        Me.Codigo.Format = ""
        Me.Codigo.FormatInfo = Nothing
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Width = 75
        '
        'Descripcion
        '
        Me.Descripcion.Format = ""
        Me.Descripcion.FormatInfo = Nothing
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Width = 250
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbmedida)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 40)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(336, 16)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(104, 16)
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
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'FrmBuscaCatClient
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 246)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBuscaCatClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta de Categoria de Cliente"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmBuscaZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then
                CargagridZona(grid1, "Nsp_Sele_Cat_cliente '','','" & codempresa & "'")
            Else
                CargagridZona(grid1, "Nsp_Sele_Cat_cliente '','','" & codempresa & "'")
            End If
        Else
            If Me.rbcodigo.Checked = True Then
                CargagridZona(grid1, "Nsp_Sele_Cat_cliente '" & Me.txtdato.Text.Trim & "','','" & codempresa & "'")
            Else
                CargagridZona(grid1, "Nsp_Sele_Cat_cliente '','" & Me.txtdato.Text.Trim & "','" & codempresa & "'")
            End If
        End If
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        Dim FRM As New FrmZona
        VAR1 = grid1.Item(grid1.CurrentRowIndex, 0)
        VAR2 = grid1.Item(grid1.CurrentRowIndex, 1)
        Dim obj As New FrmZona
        obj.mostrar()
        Me.Close()
    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        llena()
    End Sub
End Class
