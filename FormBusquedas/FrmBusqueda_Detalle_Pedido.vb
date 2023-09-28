Public Class FrmBusqueda_Detalle_Pedido
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
    Friend WithEvents GridPedidoDetalle As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents LblCabecera As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBusqueda_Detalle_Pedido))
        Me.GridPedidoDetalle = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LblCabecera = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.GridPedidoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPedidoDetalle
        '
        Me.GridPedidoDetalle.DataMember = ""
        Me.GridPedidoDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridPedidoDetalle.Location = New System.Drawing.Point(12, 126)
        Me.GridPedidoDetalle.Name = "GridPedidoDetalle"
        Me.GridPedidoDetalle.ReadOnly = True
        Me.GridPedidoDetalle.Size = New System.Drawing.Size(690, 264)
        Me.GridPedidoDetalle.TabIndex = 0
        Me.GridPedidoDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridPedidoDetalle
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "NumPedido"
        Me.DataGridTextBoxColumn6.MappingName = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODARTICULO"
        Me.DataGridTextBoxColumn1.MappingName = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn2.Format = "#######0.00"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "CANTIDAD"
        Me.DataGridTextBoxColumn2.MappingName = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn3.MappingName = ""
        Me.DataGridTextBoxColumn3.Width = 300
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#######0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "PRECIO"
        Me.DataGridTextBoxColumn4.MappingName = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "#######0.00"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "MONTO"
        Me.DataGridTextBoxColumn5.MappingName = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'LblCabecera
        '
        Me.LblCabecera.BackColor = System.Drawing.Color.White
        Me.LblCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCabecera.Location = New System.Drawing.Point(126, 6)
        Me.LblCabecera.Name = "LblCabecera"
        Me.LblCabecera.Size = New System.Drawing.Size(404, 116)
        Me.LblCabecera.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(518, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Total S/.: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.Color.White
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(590, 400)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.TabIndex = 97
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(534, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 34)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Quitar"
        '
        'FrmBusqueda_Detalle_Pedido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(712, 430)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblCabecera)
        Me.Controls.Add(Me.GridPedidoDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusqueda_Detalle_Pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda Detalle Pedido"
        CType(Me.GridPedidoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private TMP_DETALLE_PEDIDO As New DataTable
    Public CORREL As String
    Public CODARTI As String

    Sub CargarGrid()
        TMP_DETALLE_PEDIDO = TmpListarDatos("NSP_LISTAR_PEDIDO_DET   '" & codempresa & "','" & CORREL & "' ,'" & CODARTI & "'")
        GridPedidoDetalle.DataSource = TMP_DETALLE_PEDIDO

        DataGridTableStyle1.MappingName = TMP_DETALLE_PEDIDO.TableName
        DataGridTableStyle1.GridColumnStyles(0).MappingName = "NUM_PEDIDO"
        DataGridTableStyle1.GridColumnStyles(1).MappingName = "CODARTI"
        DataGridTableStyle1.GridColumnStyles(2).MappingName = "CANTIDAD"
        DataGridTableStyle1.GridColumnStyles(3).MappingName = "DESARTI"
        DataGridTableStyle1.GridColumnStyles(4).MappingName = "PRECIOVTA"
        DataGridTableStyle1.GridColumnStyles(5).MappingName = "TOTBAS"
        GridPedidoDetalle.TableStyles.Add(DataGridTableStyle1)
        LblTotal.Text = 0.0

        For i As Integer = 0 To TMP_DETALLE_PEDIDO.Rows.Count - 1
            LblTotal.Text = Format((CDbl(LblTotal.Text) + CDbl(TMP_DETALLE_PEDIDO.Rows(i)("TOTBAS").ToString.Trim)), "#######0.00")
        Next

        LblCabecera.Text = vbNewLine & "Nro Pedido: " & TMP_DETALLE_PEDIDO.Rows(0)("NUM_PEDIDO").ToString.Trim _
        & vbNewLine & "Cliente: " & TMP_DETALLE_PEDIDO.Rows(0)("DESCLIENTE").ToString.Trim _
        & vbNewLine & "Direccion: " & TMP_DETALLE_PEDIDO.Rows(0)("DIRECCION").ToString.Trim
        '& vbNewLine & "El Vendedor: " & TMP_DETALLE_PEDIDO.Rows(0)("DSVEND").ToString.Trim

    End Sub

    Private Sub FrmBusqueda_Detalle_Pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TMP_DETALLE_PEDIDO.Rows.Count > 0 Then
            TmpInsertDatos("SP_EliArtiTMP_GUIAINTERNADETVTA  '" & codempresa & "','" & CORREL & "','" & GridPedidoDetalle.Item(GridPedidoDetalle.CurrentRowIndex, 1) & "','" & GridPedidoDetalle.Item(GridPedidoDetalle.CurrentRowIndex, 0) & "'")
            CargarGrid()
        End If
    End Sub
End Class
