<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActCodvend
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
        Me.components = New System.ComponentModel.Container()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.btnsele = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtruta = New System.Windows.Forms.TextBox()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.CODARTICULODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODPRESENTACIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO12DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo de Texto (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Seleccionar el Archivo Cvs"
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoGenerateColumns = False
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODARTICULODataGridViewTextBoxColumn, Me.CODPRESENTACIONDataGridViewTextBoxColumn, Me.PRECIO1DataGridViewTextBoxColumn, Me.PRECIO2DataGridViewTextBoxColumn, Me.PRECIO3DataGridViewTextBoxColumn, Me.PRECIO4DataGridViewTextBoxColumn, Me.PRECIO5DataGridViewTextBoxColumn, Me.PRECIO6DataGridViewTextBoxColumn, Me.PRECIO7DataGridViewTextBoxColumn, Me.PRECIO8DataGridViewTextBoxColumn, Me.PRECIO9DataGridViewTextBoxColumn, Me.PRECIO10DataGridViewTextBoxColumn, Me.PRECIO11DataGridViewTextBoxColumn, Me.PRECIO12DataGridViewTextBoxColumn})
        Me.dgvlista.DataSource = Me.BindingSource1
        Me.dgvlista.Location = New System.Drawing.Point(12, 60)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.Size = New System.Drawing.Size(1006, 293)
        Me.dgvlista.TabIndex = 8
        '
        'btnsele
        '
        Me.btnsele.Location = New System.Drawing.Point(459, 13)
        Me.btnsele.Name = "btnsele"
        Me.btnsele.Size = New System.Drawing.Size(43, 23)
        Me.btnsele.TabIndex = 7
        Me.btnsele.Text = "..."
        Me.btnsele.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ruta Excel :"
        '
        'txtruta
        '
        Me.txtruta.Enabled = False
        Me.txtruta.Location = New System.Drawing.Point(96, 14)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(357, 20)
        Me.txtruta.TabIndex = 5
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(311, 359)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(191, 32)
        Me.btnactualizar.TabIndex = 9
        Me.btnactualizar.Text = "Button1"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'CODARTICULODataGridViewTextBoxColumn
        '
        Me.CODARTICULODataGridViewTextBoxColumn.DataPropertyName = "CODARTICULO"
        Me.CODARTICULODataGridViewTextBoxColumn.HeaderText = "CODARTICULO"
        Me.CODARTICULODataGridViewTextBoxColumn.Name = "CODARTICULODataGridViewTextBoxColumn"
        Me.CODARTICULODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CODPRESENTACIONDataGridViewTextBoxColumn
        '
        Me.CODPRESENTACIONDataGridViewTextBoxColumn.DataPropertyName = "CODPRESENTACION"
        Me.CODPRESENTACIONDataGridViewTextBoxColumn.HeaderText = "CODPRESENTACION"
        Me.CODPRESENTACIONDataGridViewTextBoxColumn.Name = "CODPRESENTACIONDataGridViewTextBoxColumn"
        Me.CODPRESENTACIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO1DataGridViewTextBoxColumn
        '
        Me.PRECIO1DataGridViewTextBoxColumn.DataPropertyName = "PRECIO1"
        Me.PRECIO1DataGridViewTextBoxColumn.HeaderText = "PRECIO1"
        Me.PRECIO1DataGridViewTextBoxColumn.Name = "PRECIO1DataGridViewTextBoxColumn"
        Me.PRECIO1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO2DataGridViewTextBoxColumn
        '
        Me.PRECIO2DataGridViewTextBoxColumn.DataPropertyName = "PRECIO2"
        Me.PRECIO2DataGridViewTextBoxColumn.HeaderText = "PRECIO2"
        Me.PRECIO2DataGridViewTextBoxColumn.Name = "PRECIO2DataGridViewTextBoxColumn"
        Me.PRECIO2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO3DataGridViewTextBoxColumn
        '
        Me.PRECIO3DataGridViewTextBoxColumn.DataPropertyName = "PRECIO3"
        Me.PRECIO3DataGridViewTextBoxColumn.HeaderText = "PRECIO3"
        Me.PRECIO3DataGridViewTextBoxColumn.Name = "PRECIO3DataGridViewTextBoxColumn"
        Me.PRECIO3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO4DataGridViewTextBoxColumn
        '
        Me.PRECIO4DataGridViewTextBoxColumn.DataPropertyName = "PRECIO4"
        Me.PRECIO4DataGridViewTextBoxColumn.HeaderText = "PRECIO4"
        Me.PRECIO4DataGridViewTextBoxColumn.Name = "PRECIO4DataGridViewTextBoxColumn"
        Me.PRECIO4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO5DataGridViewTextBoxColumn
        '
        Me.PRECIO5DataGridViewTextBoxColumn.DataPropertyName = "PRECIO5"
        Me.PRECIO5DataGridViewTextBoxColumn.HeaderText = "PRECIO5"
        Me.PRECIO5DataGridViewTextBoxColumn.Name = "PRECIO5DataGridViewTextBoxColumn"
        Me.PRECIO5DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO6DataGridViewTextBoxColumn
        '
        Me.PRECIO6DataGridViewTextBoxColumn.DataPropertyName = "PRECIO6"
        Me.PRECIO6DataGridViewTextBoxColumn.HeaderText = "PRECIO6"
        Me.PRECIO6DataGridViewTextBoxColumn.Name = "PRECIO6DataGridViewTextBoxColumn"
        Me.PRECIO6DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO7DataGridViewTextBoxColumn
        '
        Me.PRECIO7DataGridViewTextBoxColumn.DataPropertyName = "PRECIO7"
        Me.PRECIO7DataGridViewTextBoxColumn.HeaderText = "PRECIO7"
        Me.PRECIO7DataGridViewTextBoxColumn.Name = "PRECIO7DataGridViewTextBoxColumn"
        Me.PRECIO7DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO8DataGridViewTextBoxColumn
        '
        Me.PRECIO8DataGridViewTextBoxColumn.DataPropertyName = "PRECIO8"
        Me.PRECIO8DataGridViewTextBoxColumn.HeaderText = "PRECIO8"
        Me.PRECIO8DataGridViewTextBoxColumn.Name = "PRECIO8DataGridViewTextBoxColumn"
        Me.PRECIO8DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO9DataGridViewTextBoxColumn
        '
        Me.PRECIO9DataGridViewTextBoxColumn.DataPropertyName = "PRECIO9"
        Me.PRECIO9DataGridViewTextBoxColumn.HeaderText = "PRECIO9"
        Me.PRECIO9DataGridViewTextBoxColumn.Name = "PRECIO9DataGridViewTextBoxColumn"
        Me.PRECIO9DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO10DataGridViewTextBoxColumn
        '
        Me.PRECIO10DataGridViewTextBoxColumn.DataPropertyName = "PRECIO10"
        Me.PRECIO10DataGridViewTextBoxColumn.HeaderText = "PRECIO10"
        Me.PRECIO10DataGridViewTextBoxColumn.Name = "PRECIO10DataGridViewTextBoxColumn"
        Me.PRECIO10DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO11DataGridViewTextBoxColumn
        '
        Me.PRECIO11DataGridViewTextBoxColumn.DataPropertyName = "PRECIO11"
        Me.PRECIO11DataGridViewTextBoxColumn.HeaderText = "PRECIO11"
        Me.PRECIO11DataGridViewTextBoxColumn.Name = "PRECIO11DataGridViewTextBoxColumn"
        Me.PRECIO11DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PRECIO12DataGridViewTextBoxColumn
        '
        Me.PRECIO12DataGridViewTextBoxColumn.DataPropertyName = "PRECIO12"
        Me.PRECIO12DataGridViewTextBoxColumn.HeaderText = "PRECIO12"
        Me.PRECIO12DataGridViewTextBoxColumn.Name = "PRECIO12DataGridViewTextBoxColumn"
        Me.PRECIO12DataGridViewTextBoxColumn.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(NarGestionDistribuidora.TransPrecios)
        '
        'FrmActCodvend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 397)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.btnsele)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtruta)
        Me.Name = "FrmActCodvend"
        Me.Text = "Form7"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents dgvlista As DataGridView
    Friend WithEvents btnsele As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtruta As TextBox
    Friend WithEvents btnactualizar As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents codCliente As DataGridViewTextBoxColumn
    Friend WithEvents TipoDoc As DataGridViewTextBoxColumn
    Friend WithEvents NroDoc As DataGridViewTextBoxColumn
    Friend WithEvents CodVend As DataGridViewTextBoxColumn
    Friend WithEvents CODARTICULODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CODPRESENTACIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO6DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO7DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO8DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO9DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO10DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO11DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO12DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
