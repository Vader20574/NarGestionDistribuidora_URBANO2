Public Class frm_gridtptovta
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
    Friend WithEvents tserie As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents NROPTOVTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tserie = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.grid1 = New System.Windows.Forms.DataGridView
        Me.NROPTOVTA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tserie)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tcodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 48)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'tserie
        '
        Me.tserie.Location = New System.Drawing.Point(284, 17)
        Me.tserie.Name = "tserie"
        Me.tserie.Size = New System.Drawing.Size(163, 21)
        Me.tserie.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción :"
        '
        'tcodigo
        '
        Me.tcodigo.Location = New System.Drawing.Point(97, 17)
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(96, 21)
        Me.tcodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nro Pto Venta :"
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NROPTOVTA, Me.DESCRIPCION})
        Me.grid1.Location = New System.Drawing.Point(16, 65)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(460, 240)
        Me.grid1.TabIndex = 11
        '
        'NROPTOVTA
        '
        Me.NROPTOVTA.DataPropertyName = "NROPTOVTA"
        Me.NROPTOVTA.HeaderText = "NRO PUNTO VENTA"
        Me.NROPTOVTA.Name = "NROPTOVTA"
        Me.NROPTOVTA.ReadOnly = True
        Me.NROPTOVTA.Width = 200
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "DESPTOVTA"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 200
        '
        'frm_gridtptovta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(490, 319)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_gridtptovta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas por Puntos de Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public boubicptovta As Boolean
    Dim dt As New DataTable

    Private Sub frm_gridclie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llena()
    End Sub

    Sub cargadatos()
        Call Cargagrid(grid1, "Nsp_Sele_tdaptoventa '" & codempresa & "'")
    End Sub

    Sub llena()
        Try
            dt = TmpListarDatos("select nroptovta ,desptovta  from tiendaptovta where estado=0 and nroptovta like '" & Me.tcodigo.Text.Trim.Trim & "%' and desptovta like '" & Me.tserie.Text.Trim.Trim & "%' and codempresa='" & codempresa & "'")
            grid1.AutoGenerateColumns = False
            Me.grid1.DataSource = Nothing
            Me.grid1.DataSource = dt

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tcodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress, tserie.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub grid1_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        If dt.Rows.Count = 0 Then Exit Sub
        boubicptovta = True
        Me.Close()
    End Sub
End Class
