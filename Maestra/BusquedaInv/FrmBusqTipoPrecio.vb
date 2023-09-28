Public Class FrmBusqTipoPrecio
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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TablaEstiloTPrecio As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.TablaEstiloTPrecio = New System.Windows.Forms.DataGridTableStyle
        Me.CODIGO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Registro Chofer"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(6, 56)
        Me.grid1.Name = "grid1"
        Me.grid1.Size = New System.Drawing.Size(454, 260)
        Me.grid1.TabIndex = 14
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloTPrecio})
        '
        'TablaEstiloTPrecio
        '
        Me.TablaEstiloTPrecio.DataGrid = Me.grid1
        Me.TablaEstiloTPrecio.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODIGO, Me.DESCRIPCION})
        Me.TablaEstiloTPrecio.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloTPrecio.MappingName = ""
        '
        'CODIGO
        '
        Me.CODIGO.Format = ""
        Me.CODIGO.FormatInfo = Nothing
        Me.CODIGO.HeaderText = "Código"
        Me.CODIGO.MappingName = ""
        Me.CODIGO.Width = 75
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Format = ""
        Me.DESCRIPCION.FormatInfo = Nothing
        Me.DESCRIPCION.HeaderText = "Descripción"
        Me.DESCRIPCION.MappingName = ""
        Me.DESCRIPCION.Width = 250
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 46)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(232, 16)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(220, 20)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(64, 16)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código :"
        '
        'FrmBusqTipoPrecio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(468, 322)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusqTipoPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Tipo Precio"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Fields"
    Public frm As frmarticulos
#End Region

    Private Sub FrmBusqTipoPrecio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Sub llena()
        Try
            'Dim obj As New ClsInterface
            Dim TablaTipoPrecio As New DataTable
            TablaTipoPrecio = CAyuda.ListarDatos("NSP_LSITAR_TIPOPRE", codempresa, "%").Tables(0)
            TablaEstiloTPrecio.MappingName = TablaTipoPrecio.TableName
            TablaEstiloTPrecio.GridColumnStyles(0).MappingName = "CODTIPOPRE"
            TablaEstiloTPrecio.GridColumnStyles(1).MappingName = "DSTIPOPRE"
            grid1.TableStyles.Add(TablaEstiloTPrecio)
            Me.grid1.DataSource = TablaTipoPrecio
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub
End Class
