<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmValPromo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DSPROMO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODPROMO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROM_CONS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROM_PED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCK_PROMO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOCKTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXCEDIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DSPROMO, Me.CODPROMO, Me.PROM_CONS, Me.PROM_PED, Me.STOCK_PROMO, Me.STOCKTOTAL, Me.EXCEDIO})
        Me.DataGridView1.Location = New System.Drawing.Point(21, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(755, 282)
        Me.DataGridView1.TabIndex = 0
        '
        'DSPROMO
        '
        Me.DSPROMO.DataPropertyName = "DSPROMO"
        Me.DSPROMO.HeaderText = "PROMO"
        Me.DSPROMO.Name = "DSPROMO"
        '
        'CODPROMO
        '
        Me.CODPROMO.DataPropertyName = "CODPROMO"
        Me.CODPROMO.HeaderText = "CODIGO"
        Me.CODPROMO.Name = "CODPROMO"
        '
        'PROM_CONS
        '
        Me.PROM_CONS.DataPropertyName = "PROM_CONS"
        Me.PROM_CONS.HeaderText = "CONSUMIDO"
        Me.PROM_CONS.Name = "PROM_CONS"
        '
        'PROM_PED
        '
        Me.PROM_PED.DataPropertyName = "PROM_PED"
        Me.PROM_PED.HeaderText = "PEDIDO"
        Me.PROM_PED.Name = "PROM_PED"
        '
        'STOCK_PROMO
        '
        Me.STOCK_PROMO.DataPropertyName = "STOCK_PROMO"
        Me.STOCK_PROMO.HeaderText = "STOCK"
        Me.STOCK_PROMO.Name = "STOCK_PROMO"
        '
        'STOCKTOTAL
        '
        Me.STOCKTOTAL.DataPropertyName = "STOCKTOTAL"
        Me.STOCKTOTAL.HeaderText = "TOTAL"
        Me.STOCKTOTAL.Name = "STOCKTOTAL"
        '
        'EXCEDIO
        '
        Me.EXCEDIO.DataPropertyName = "EXCEDIO"
        Me.EXCEDIO.HeaderText = "EXCEDIO"
        Me.EXCEDIO.Name = "EXCEDIO"
        Me.EXCEDIO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'FrmValPromo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 358)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmValPromo"
        Me.Text = "Validar Promociones"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DSPROMO As DataGridViewTextBoxColumn
    Friend WithEvents CODPROMO As DataGridViewTextBoxColumn
    Friend WithEvents PROM_CONS As DataGridViewTextBoxColumn
    Friend WithEvents PROM_PED As DataGridViewTextBoxColumn
    Friend WithEvents STOCK_PROMO As DataGridViewTextBoxColumn
    Friend WithEvents STOCKTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents EXCEDIO As DataGridViewTextBoxColumn
End Class
