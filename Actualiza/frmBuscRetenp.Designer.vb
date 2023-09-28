<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscRetenp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbpais = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgblista = New System.Windows.Forms.DataGridView
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RUC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECDOCUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgblista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbpais)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(713, 50)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'rbpais
        '
        Me.rbpais.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbpais.Location = New System.Drawing.Point(453, 19)
        Me.rbpais.Name = "rbpais"
        Me.rbpais.Size = New System.Drawing.Size(135, 16)
        Me.rbpais.TabIndex = 3
        Me.rbpais.Text = "Proveedor"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(313, 18)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(125, 19)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Nro de Documento"
        '
        'txtdato
        '
        Me.txtdato.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(56, 17)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(230, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'dgblista
        '
        Me.dgblista.AllowUserToAddRows = False
        Me.dgblista.AllowUserToDeleteRows = False
        Me.dgblista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgblista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.PROVEEDOR, Me.RUC, Me.DIRECCION, Me.FECDOCUM, Me.ESTADO})
        Me.dgblista.Location = New System.Drawing.Point(12, 68)
        Me.dgblista.Name = "dgblista"
        Me.dgblista.ReadOnly = True
        Me.dgblista.Size = New System.Drawing.Size(714, 248)
        Me.dgblista.TabIndex = 28
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "CODIGO"
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        '
        'PROVEEDOR
        '
        Me.PROVEEDOR.DataPropertyName = "PROVEEDOR"
        Me.PROVEEDOR.HeaderText = "PROVEEDOR"
        Me.PROVEEDOR.Name = "PROVEEDOR"
        Me.PROVEEDOR.ReadOnly = True
        Me.PROVEEDOR.Width = 150
        '
        'RUC
        '
        Me.RUC.DataPropertyName = "RUC"
        Me.RUC.HeaderText = "RUC"
        Me.RUC.Name = "RUC"
        Me.RUC.ReadOnly = True
        '
        'DIRECCION
        '
        Me.DIRECCION.DataPropertyName = "DIRECCION"
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.ReadOnly = True
        Me.DIRECCION.Width = 150
        '
        'FECDOCUM
        '
        Me.FECDOCUM.DataPropertyName = "FECDOCUM"
        Me.FECDOCUM.HeaderText = "FECDOCUM"
        Me.FECDOCUM.Name = "FECDOCUM"
        Me.FECDOCUM.ReadOnly = True
        '
        'ESTADO
        '
        Me.ESTADO.DataPropertyName = "ESTADO"
        Me.ESTADO.HeaderText = "ESTADO"
        Me.ESTADO.Name = "ESTADO"
        Me.ESTADO.ReadOnly = True
        Me.ESTADO.Width = 70
        '
        'frmBuscRetenp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 328)
        Me.Controls.Add(Me.dgblista)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmBuscRetenp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgblista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbpais As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgblista As System.Windows.Forms.DataGridView
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROVEEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECDOCUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
