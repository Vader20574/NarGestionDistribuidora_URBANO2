Public Class frmDetallePedido
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
    Friend WithEvents LblTotalPeso As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblTotalSoles As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgdetalle As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dgdetalle = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.LblTotalPeso = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblTotalSoles = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgdetalle
        '
        Me.dgdetalle.DataMember = ""
        Me.dgdetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgdetalle.Location = New System.Drawing.Point(3, 16)
        Me.dgdetalle.Name = "dgdetalle"
        Me.dgdetalle.ReadOnly = True
        Me.dgdetalle.Size = New System.Drawing.Size(909, 211)
        Me.dgdetalle.TabIndex = 0
        Me.dgdetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgdetalle
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TABLE"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ITEM"
        Me.DataGridTextBoxColumn1.MappingName = "ITEM"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "ALMACEN"
        Me.DataGridTextBoxColumn2.MappingName = "CODALMACEN"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn3.MappingName = "CODARTI"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn4.MappingName = "DESARTI"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "UNIDADES"
        Me.DataGridTextBoxColumn5.MappingName = "UNIDADES"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "PRES. PAQ."
        Me.DataGridTextBoxColumn6.MappingName = "PRESPAQ"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "PRES.UND."
        Me.DataGridTextBoxColumn7.MappingName = "PRESUND"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "PRECIO PROM."
        Me.DataGridTextBoxColumn8.MappingName = "PRECIO"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "PESO PROMED."
        Me.DataGridTextBoxColumn9.MappingName = "PESO"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "UNI.FALT."
        Me.DataGridTextBoxColumn10.MappingName = "UNDFALTANTE"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'LblTotalPeso
        '
        Me.LblTotalPeso.BackColor = System.Drawing.Color.White
        Me.LblTotalPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalPeso.Location = New System.Drawing.Point(552, 277)
        Me.LblTotalPeso.Name = "LblTotalPeso"
        Me.LblTotalPeso.TabIndex = 3
        Me.LblTotalPeso.Text = "0.00"
        Me.LblTotalPeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(480, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Peso : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTotalSoles
        '
        Me.LblTotalSoles.BackColor = System.Drawing.Color.White
        Me.LblTotalSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalSoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSoles.Location = New System.Drawing.Point(816, 277)
        Me.LblTotalSoles.Name = "LblTotalSoles"
        Me.LblTotalSoles.TabIndex = 5
        Me.LblTotalSoles.Text = "0.00"
        Me.LblTotalSoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(704, 280)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Total Soles S/.: "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgdetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(907, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalle de Pedidos"
        '
        'frmDetallePedido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(930, 312)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTotalPeso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblTotalSoles)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetallePedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalles"
        CType(Me.dgdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public corre As Integer
    Public pedido As Decimal
    Dim dt As New DataTable
    Private Sub frmDetallePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tot, tope As Decimal
        dt = CAyuda.ListarDatos("SP_LIST_DET_PEDI", codempresa, corre, pedido).Tables(0)
        Me.dgdetalle.DataSource = dt
        For Each dr As DataRow In dt.Rows
            tot = tot + dr.Item(10)
            tope = tope + dr.Item(8)
        Next
        LblTotalPeso.Text = Format(tope, "0.00")
        LblTotalSoles.Text = Format(tot, "0.00")
        FORMATO_GRIDDET()
    End Sub

    Private Sub FORMATO_GRIDDET()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = "Table"
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "ITEM"
            .HeaderText = "Item"
            .Width = 35
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODALMACEN"
            .HeaderText = "Almacen"
            .NullText = ""
            .Width = 50
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "CODARTI"
            .HeaderText = "Codigo"
            .Width = 75
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "DESARTI"
            .HeaderText = "Descripcion"
            .Width = 200
        End With

        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "UNIDADES"
            .HeaderText = "Unidades"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column6 As New DataGridTextBoxColumn
        With column6
            .MappingName = "PRESPAQ"
            .HeaderText = "Pres. Paq."
            .Width = 120
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column8 As New DataGridTextBoxColumn
        With column8
            .MappingName = "PRESUND"
            .HeaderText = "Pres. Und."
            .Width = 100
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With

        Dim column9 As New DataGridTextBoxColumn
        With column9
            .MappingName = "PRECIO"
            .HeaderText = "Precio Promedio"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column10 As New DataGridTextBoxColumn
        With column10
            .MappingName = "PESO"
            .HeaderText = "Peso Promedio"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With
        Dim column11 As New DataGridTextBoxColumn
        With column11
            .MappingName = "UNDFALTANTE"
            .HeaderText = "Unidades Faltantes"
            .Width = 75
            .NullText = ""
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
        End With

        Dim column12 As New DataGridTextBoxColumn
        With column12
            .MappingName = "TOTBAS"
            .HeaderText = "TOTAL"
            .Alignment = HorizontalAlignment.Right
            .Width = 100
            .Format = GMascaraDec(DECIRESU)
        End With

        dgdetalle.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5, column6, column8, column9, column10, column11, column12})
        dgdetalle.TableStyles.Add(TableStyle1)


    End Sub
End Class
