Public Class FrmGridPedidosVta2
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumPedido As System.Windows.Forms.TextBox
    Friend WithEvents TablaEstiloGridPedido As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents NUM_PEDIDO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents FECHA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CLIENTE As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VENDEDOR As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DSESTADO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbNumpedido As System.Windows.Forms.RadioButton
    Friend WithEvents rbCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbVendedor As System.Windows.Forms.RadioButton
    Friend WithEvents ckSoloPend As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.TablaEstiloGridPedido = New System.Windows.Forms.DataGridTableStyle
        Me.NUM_PEDIDO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.FECHA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CLIENTE = New System.Windows.Forms.DataGridTextBoxColumn
        Me.VENDEDOR = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DSESTADO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ckSoloPend = New System.Windows.Forms.CheckBox
        Me.rbVendedor = New System.Windows.Forms.RadioButton
        Me.rbCliente = New System.Windows.Forms.RadioButton
        Me.rbNumpedido = New System.Windows.Forms.RadioButton
        Me.txtNumPedido = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid1
        '
        Me.grid1.AllowSorting = False
        Me.grid1.CaptionText = "Num. Pedidos"
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(12, 48)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(634, 260)
        Me.grid1.TabIndex = 14
        Me.grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloGridPedido})
        '
        'TablaEstiloGridPedido
        '
        Me.TablaEstiloGridPedido.DataGrid = Me.grid1
        Me.TablaEstiloGridPedido.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.NUM_PEDIDO, Me.FECHA, Me.CLIENTE, Me.VENDEDOR, Me.DSESTADO})
        Me.TablaEstiloGridPedido.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloGridPedido.MappingName = ""
        '
        'NUM_PEDIDO
        '
        Me.NUM_PEDIDO.Format = ""
        Me.NUM_PEDIDO.FormatInfo = Nothing
        Me.NUM_PEDIDO.HeaderText = "Num.Pedido"
        Me.NUM_PEDIDO.MappingName = ""
        Me.NUM_PEDIDO.Width = 75
        '
        'FECHA
        '
        Me.FECHA.Format = ""
        Me.FECHA.FormatInfo = Nothing
        Me.FECHA.HeaderText = "Fecha"
        Me.FECHA.MappingName = ""
        Me.FECHA.Width = 75
        '
        'CLIENTE
        '
        Me.CLIENTE.Format = ""
        Me.CLIENTE.FormatInfo = Nothing
        Me.CLIENTE.HeaderText = "Cliente"
        Me.CLIENTE.MappingName = ""
        Me.CLIENTE.Width = 200
        '
        'VENDEDOR
        '
        Me.VENDEDOR.Format = ""
        Me.VENDEDOR.FormatInfo = Nothing
        Me.VENDEDOR.HeaderText = "Vendedor"
        Me.VENDEDOR.MappingName = ""
        Me.VENDEDOR.Width = 150
        '
        'DSESTADO
        '
        Me.DSESTADO.Format = ""
        Me.DSESTADO.FormatInfo = Nothing
        Me.DSESTADO.HeaderText = "Estado"
        Me.DSESTADO.MappingName = ""
        Me.DSESTADO.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckSoloPend)
        Me.GroupBox1.Controls.Add(Me.rbVendedor)
        Me.GroupBox1.Controls.Add(Me.rbCliente)
        Me.GroupBox1.Controls.Add(Me.rbNumpedido)
        Me.GroupBox1.Controls.Add(Me.txtNumPedido)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 46)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'ckSoloPend
        '
        Me.ckSoloPend.Location = New System.Drawing.Point(526, 20)
        Me.ckSoloPend.Name = "ckSoloPend"
        Me.ckSoloPend.Size = New System.Drawing.Size(106, 18)
        Me.ckSoloPend.TabIndex = 7
        Me.ckSoloPend.Text = "Solo Pendientes"
        '
        'rbVendedor
        '
        Me.rbVendedor.Location = New System.Drawing.Point(444, 18)
        Me.rbVendedor.Name = "rbVendedor"
        Me.rbVendedor.Size = New System.Drawing.Size(72, 22)
        Me.rbVendedor.TabIndex = 6
        Me.rbVendedor.Text = "Vendedor"
        '
        'rbCliente
        '
        Me.rbCliente.Location = New System.Drawing.Point(380, 18)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(58, 22)
        Me.rbCliente.TabIndex = 5
        Me.rbCliente.Text = "Cliente"
        '
        'rbNumpedido
        '
        Me.rbNumpedido.Checked = True
        Me.rbNumpedido.Location = New System.Drawing.Point(288, 18)
        Me.rbNumpedido.Name = "rbNumpedido"
        Me.rbNumpedido.Size = New System.Drawing.Size(86, 22)
        Me.rbNumpedido.TabIndex = 4
        Me.rbNumpedido.TabStop = True
        Me.rbNumpedido.Text = "Núm.Pedido"
        '
        'txtNumPedido
        '
        Me.txtNumPedido.Location = New System.Drawing.Point(90, 18)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(182, 20)
        Me.txtNumPedido.TabIndex = 3
        Me.txtNumPedido.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción :"
        '
        'FrmGridPedidosVta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(646, 318)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGridPedidosVta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de pedidos"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Fields"
    Public vie As FrmPedido2
    Public vieAnula As FrmAnularPedidos
    Private TablaTempP As New DataTable
#End Region

    Private Sub FrmGridPedidosVta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub
    Sub llena()
        Try
            TablaTempP = CAyuda.ListarDatos("NSP_LISTAR_ED_CAB", codempresa, ckSoloPend.Checked).Tables(0)
            TablaEstiloGridPedido.MappingName = TablaTempP.TableName
            TablaEstiloGridPedido.GridColumnStyles(0).MappingName = "NUM_PEDIDO"
            TablaEstiloGridPedido.GridColumnStyles(1).MappingName = "FECHA"
            TablaEstiloGridPedido.GridColumnStyles(2).MappingName = "CLIENTE"
            TablaEstiloGridPedido.GridColumnStyles(3).MappingName = "DSVEND"
            TablaEstiloGridPedido.GridColumnStyles(4).MappingName = "DSESTADO"
            grid1.TableStyles.Add(TablaEstiloGridPedido)
            Me.grid1.DataSource = TablaTempP
        Catch ex As Exception
        End Try
    End Sub
    Sub pasadatos()
        vie.txtNumPedido.Text = grid1(grid1.CurrentRowIndex, 0).ToString.Trim
        If Me.grid1(grid1.CurrentRowIndex, 4).ToString.Trim = "TERMINADO" Then
            vie.PedidoTerminado = "T"
        ElseIf Me.grid1(grid1.CurrentRowIndex, 4).ToString.Trim = "PENDIENTE" Then
            vie.PedidoTerminado = "P"
        ElseIf Me.grid1(grid1.CurrentRowIndex, 4).ToString.Trim = "ANULADO" Then
            vie.PedidoTerminado = "A"
        End If
        Me.Close()
    End Sub
    Sub pasadatos2()
        vieAnula.txtNumPedido.Text = grid1(grid1.CurrentRowIndex, 0).ToString.Trim
        Me.Close()
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        If Not vie Is Nothing Then
            pasadatos()
        End If
        If Not vieAnula Is Nothing Then
            pasadatos2()
        End If

    End Sub

    Private Sub ckSoloPend_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckSoloPend.CheckedChanged
        llena()
    End Sub

    Private Sub txtNumPedido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumPedido.TextChanged
        For Cont2 As Integer = 0 To TablaTempP.Rows.Count - 1
            Me.grid1.UnSelect(Cont2)
        Next
        If Me.txtNumPedido.Text.Length = 0 Then
            Exit Sub
        End If
        If rbNumpedido.Checked Then
            For Cont1 As Integer = 0 To TablaTempP.Rows.Count - 1
                If Me.txtNumPedido.Text.ToUpper = Mid(grid1(Cont1, 0).tostring.ToUpper, 1, Me.txtNumPedido.Text.Length).ToString.ToUpper Then
                    Me.grid1.CurrentRowIndex = Cont1
                    Me.grid1.Select(Cont1)
                    Exit For
                End If
            Next
        ElseIf rbCliente.Checked Then
            For Cont1 As Integer = 0 To TablaTempP.Rows.Count - 1
                If Me.txtNumPedido.Text.ToUpper = Mid(grid1(Cont1, 2).tostring.ToUpper, 1, Me.txtNumPedido.Text.Length).ToString.ToUpper Then
                    Me.grid1.CurrentRowIndex = Cont1
                    Me.grid1.Select(Cont1)
                    Exit For
                End If
            Next
        ElseIf rbVendedor.Checked Then
            For Cont1 As Integer = 0 To TablaTempP.Rows.Count - 1
                If Me.txtNumPedido.Text.ToUpper = Mid(grid1(Cont1, 3).tostring.ToUpper, 1, Me.txtNumPedido.Text.Length).ToString.ToUpper Then
                    Me.grid1.CurrentRowIndex = Cont1
                    Me.grid1.Select(Cont1)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
