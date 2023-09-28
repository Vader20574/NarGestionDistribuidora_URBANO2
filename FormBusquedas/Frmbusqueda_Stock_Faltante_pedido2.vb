

Public Class Frmbusqueda_Stock_Faltante_pedido2
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
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents BtnNoproce As System.Windows.Forms.Button
    Friend WithEvents ChkMarcarTodo As System.Windows.Forms.CheckBox
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents GridStockFaltante As System.Windows.Forms.DataGrid
    Friend WithEvents DgPedidosXart As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.BtnNoproce = New System.Windows.Forms.Button
        Me.ChkMarcarTodo = New System.Windows.Forms.CheckBox
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.GridStockFaltante = New System.Windows.Forms.DataGrid
        Me.DgPedidosXart = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.GridStockFaltante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgPedidosXart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(22, 344)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(128, 32)
        Me.btnProcesar.TabIndex = 7
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.Visible = False
        '
        'BtnNoproce
        '
        Me.BtnNoproce.Location = New System.Drawing.Point(278, 342)
        Me.BtnNoproce.Name = "BtnNoproce"
        Me.BtnNoproce.Size = New System.Drawing.Size(128, 32)
        Me.BtnNoproce.TabIndex = 5
        Me.BtnNoproce.Text = "Aceptar"
        '
        'ChkMarcarTodo
        '
        Me.ChkMarcarTodo.Location = New System.Drawing.Point(856, 18)
        Me.ChkMarcarTodo.Name = "ChkMarcarTodo"
        Me.ChkMarcarTodo.Size = New System.Drawing.Size(96, 22)
        Me.ChkMarcarTodo.TabIndex = 2
        Me.ChkMarcarTodo.Text = "Marcar Todo"
        Me.ChkMarcarTodo.Visible = False
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(92, 12)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(482, 23)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "STOCK FALTANTE POR PEDIDO"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridStockFaltante
        '
        Me.GridStockFaltante.DataMember = ""
        Me.GridStockFaltante.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridStockFaltante.Location = New System.Drawing.Point(14, 44)
        Me.GridStockFaltante.Name = "GridStockFaltante"
        Me.GridStockFaltante.ReadOnly = True
        Me.GridStockFaltante.RowHeaderWidth = 0
        Me.GridStockFaltante.Size = New System.Drawing.Size(736, 286)
        Me.GridStockFaltante.TabIndex = 3
        '
        'DgPedidosXart
        '
        Me.DgPedidosXart.DataMember = ""
        Me.DgPedidosXart.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgPedidosXart.Location = New System.Drawing.Point(908, 46)
        Me.DgPedidosXart.Name = "DgPedidosXart"
        Me.DgPedidosXart.ReadOnly = True
        Me.DgPedidosXart.RowHeadersVisible = False
        Me.DgPedidosXart.RowHeaderWidth = 0
        Me.DgPedidosXart.Size = New System.Drawing.Size(440, 286)
        Me.DgPedidosXart.TabIndex = 4
        Me.DgPedidosXart.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(762, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Actualizando Verificacion de Stock"
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(750, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PEDIDOS DE ARTICULO FALTANTES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Frmbusqueda_Stock_Faltante_pedido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(762, 382)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgPedidosXart)
        Me.Controls.Add(Me.GridStockFaltante)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.BtnNoproce)
        Me.Controls.Add(Me.ChkMarcarTodo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frmbusqueda_Stock_Faltante_pedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Faltante de  Pedido Cargados"
        CType(Me.GridStockFaltante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgPedidosXart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "VARIABLES"
    Public TABLE_MOSTRAR_PEDIDO_FALTANTE As New DataTable
    Public FrmPedCarg As New FrmCargarPedido_a_Camion
    Public Table_Ped_SinStock As New DataTable
    Public Table_Ped_ConStock As New DataTable
#End Region


#Region "FUNCIONES"

    Private Sub cargarDgPedidosXart()
        Dim codart As String

        Table_Ped_SinStock.Clear()

        For art As Integer = 0 To TABLE_MOSTRAR_PEDIDO_FALTANTE.Rows.Count - 1
            codart = TABLE_MOSTRAR_PEDIDO_FALTANTE.Rows(art)("CODARTI").ToString.Trim
            For i As Integer = 0 To FrmPedCarg.TMP_PEDDELL.Rows.Count - 1
                'If FrmPedCarg.TMP_PEDDELL.Rows(i)("CARGAR").ToString.Trim = 1 Then
                '    NUM_PEDIDO = FrmPedCarg.TMP_PEDDELL.Rows(i)("NUM_PEDIDO").ToString.Trim
                '    Dim tablecarg As New DataTable
                '    tablecarg = TmpListarDatos("NSP_BUSCAR_ARTI_PED  '" & codempresa & "','" & codart & "','" & NUM_PEDIDO & "'")
                '    If Table_Ped_SinStock.Rows.Count > 0 Then
                '        For ins As Integer = 0 To tablecarg.Rows.Count - 1
                '            Table_Ped_SinStock.ImportRow(tablecarg.Rows(ins))
                '        Next
                '    Else
                '        Table_Ped_SinStock = TmpListarDatos("NSP_BUSCAR_ARTI_PED  '" & codempresa & "','" & codart & "','" & NUM_PEDIDO & "'")
                '    End If
                'End If
            Next
        Next

        DgPedidosXart.DataSource = Table_Ped_SinStock
    End Sub
    Private Sub cargarPed_ConStock()
        'Dim codart As String
        'Dim NUM_PEDIDO As String
        Table_Ped_ConStock.Clear()
        For i As Integer = 0 To FrmPedCarg.TMP_PEDDELL.Rows.Count - 1
            'If FrmPedCarg.TMP_PEDDELL.Rows(i)("CARGAR").ToString.Trim = 1 Then
            '    NUM_PEDIDO = FrmPedCarg.TMP_PEDDELL.Rows(i)("NUM_PEDIDO").ToString.Trim
            '    Dim tablecarg As New DataTable
            '    tablecarg = TmpListarDatos("NSP_BUSCAR_ARTI_PEDVTADET  '" & codempresa & "','" & NUM_PEDIDO & "'")
            '    If Table_Ped_ConStock.Rows.Count > 0 Then
            '        For ins As Integer = 0 To tablecarg.Rows.Count - 1
            '            Table_Ped_ConStock.ImportRow(tablecarg.Rows(ins))
            '        Next
            '    Else
            '        Table_Ped_ConStock = TmpListarDatos("NSP_BUSCAR_ARTI_PEDVTADET  '" & codempresa & "','" & NUM_PEDIDO & "'")
            '    End If
            'End If
        Next
    End Sub

    Private Sub FormatoGridFaltante()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            '.PreferredColumnWidth = 125
            '.PreferredRowHeight = 25
            .RowHeadersVisible = False
            .MappingName = TABLE_MOSTRAR_PEDIDO_FALTANTE.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "NUM_PEDIDO"
            .HeaderText = "NroPedido"
            .NullText = ""
            .Width = 80
            .Alignment = HorizontalAlignment.Right
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "CODARTI"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 75
        End With
        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "DESARTI"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 320
        End With
        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "STOCK_FALT_PAQ"
            .HeaderText = "Paquetes"
            .NullText = ""
            .Width = 125
        End With
        Dim DataColumn5 As New DataGridTextBoxColumn
        With DataColumn5
            .MappingName = "STOCK_FALT_UND"
            .HeaderText = "Unidades"
            .NullText = ""
            .Width = 125
        End With
        'Dim DataColumn7 As New DataGridBoolColumn
        'With DataColumn7
        '    .MappingName = "PROCESAR"
        '    .HeaderText = "Cargar"
        '    .NullText = ""
        '    .FalseValue = 0
        '    .TrueValue = 1
        '    .Width = 25
        'End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5})
        'TableStyle1.GridColumnStyles.Add(DataColumn7)

        GridStockFaltante.TableStyles.Add(TableStyle1)
    End Sub

    Private Sub FormatoGridPedidosArtFaltantes()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            '.PreferredColumnWidth = 125
            '.PreferredRowHeight = 25
            .RowHeadersVisible = False
            .MappingName = Table_Ped_SinStock.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "NOMCLI"
            .HeaderText = "NOMCLI"
            .NullText = ""
            .Width = 200
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "CODARTI"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 0
        End With
        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "DESARTI"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 125
        End With
        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "CANTIDAD"
            .HeaderText = "CANTIDAD"
            .NullText = ""
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
            .Width = 50
        End With
        Dim DataColumn5 As New DataGridTextBoxColumn
        With DataColumn5
            .MappingName = "DESPRES"
            .HeaderText = "DESPRES"
            .NullText = ""
            .Width = 125
        End With
        Dim DataColumn6 As New DataGridBoolColumn
        With DataColumn6
            .MappingName = "PROCESAR"
            .HeaderText = "Cargar"
            .NullText = ""
            .FalseValue = 0
            .TrueValue = 1
            .Width = 25
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5})
        TableStyle1.GridColumnStyles.Add(DataColumn6)

        DgPedidosXart.TableStyles.Add(TableStyle1)



    End Sub

    Private Sub CargarGridFaltante()
        GridStockFaltante.DataSource = TABLE_MOSTRAR_PEDIDO_FALTANTE
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const Wd_KeyDown As Integer = &H100
        Const Wd_KeySystem As Integer = &H104

        If ((MSG.Msg = Wd_KeyDown) Or (MSG.Msg = Wd_KeySystem)) Then
            Select Case (KeyData)
                Case Keys.Space
                    If DgPedidosXart.Focus = True Then
                        If Table_Ped_SinStock.Rows.Count > 0 Then
                            If CBool(DgPedidosXart.Item(DgPedidosXart.CurrentRowIndex, 5)) = False Then
                                DgPedidosXart.Item(DgPedidosXart.CurrentRowIndex, 5) = True
                            Else
                                DgPedidosXart.Item(DgPedidosXart.CurrentRowIndex, 5) = False
                            End If
                        End If
                    End If
            End Select
        End If
    End Function

#End Region
    Private Sub Frmbusqueda_Stock_Faltante_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        CargarGridFaltante()
        FormatoGridFaltante()
        cargarDgPedidosXart()
        FormatoGridPedidosArtFaltantes()
        cargarPed_ConStock()

    End Sub

    Private Sub BtnNoproce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNoproce.Click
        Me.Close()
        'For modf As Integer = 0 To TABLE_MOSTRAR_PEDIDO_FALTANTE.Rows.Count - 1
        '    TABLE_MOSTRAR_PEDIDO_FALTANTE.Rows(modf)("PROCESAR") = 1
        'Next
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Me.Close()
    End Sub

    Private Sub ChkMarcarTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkMarcarTodo.CheckedChanged
        For i As Integer = 0 To TABLE_MOSTRAR_PEDIDO_FALTANTE.Rows.Count - 1
            If ChkMarcarTodo.CheckState = CheckState.Checked Then
                TABLE_MOSTRAR_PEDIDO_FALTANTE.Rows(i)("PROCESAR") = 1
            Else
                TABLE_MOSTRAR_PEDIDO_FALTANTE.Rows(i)("PROCESAR") = 0
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
