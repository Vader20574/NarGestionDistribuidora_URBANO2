<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransPrecios3
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
        Me.components = New System.ComponentModel.Container
        Me.txtruta = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnsele = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnactualizar = New System.Windows.Forms.Button
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.PF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtEjercicio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRECIO12DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtruta
        '
        Me.txtruta.Enabled = False
        Me.txtruta.Location = New System.Drawing.Point(92, 25)
        Me.txtruta.Name = "txtruta"
        Me.txtruta.Size = New System.Drawing.Size(122, 20)
        Me.txtruta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ruta Excel :"
        '
        'btnsele
        '
        Me.btnsele.Location = New System.Drawing.Point(455, 24)
        Me.btnsele.Name = "btnsele"
        Me.btnsele.Size = New System.Drawing.Size(43, 23)
        Me.btnsele.TabIndex = 2
        Me.btnsele.Text = "..."
        Me.btnsele.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivo de Texto (*.csv)|*.csv"
        Me.OpenFileDialog1.Title = "Seleccionar el Archivo Cvs"
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(188, 169)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 3
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoGenerateColumns = False
        Me.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.PF, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.PRECIO4DataGridViewTextBoxColumn, Me.PRECIO5DataGridViewTextBoxColumn, Me.PRECIO6DataGridViewTextBoxColumn, Me.PRECIO7DataGridViewTextBoxColumn, Me.PRECIO8DataGridViewTextBoxColumn, Me.PRECIO9DataGridViewTextBoxColumn, Me.PRECIO10DataGridViewTextBoxColumn, Me.PRECIO11DataGridViewTextBoxColumn, Me.PRECIO12DataGridViewTextBoxColumn})
        Me.dgvlista.DataSource = Me.BindingSource1
        Me.dgvlista.Location = New System.Drawing.Point(8, 71)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.Size = New System.Drawing.Size(143, 293)
        Me.dgvlista.TabIndex = 4
        '
        'PF
        '
        Me.PF.DataPropertyName = "PF"
        Me.PF.HeaderText = "PF"
        Me.PF.Name = "PF"
        Me.PF.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(251, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(156, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(342, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(156, 34)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Procesar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1306, 391)
        Me.DataGridView1.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1168, 438)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 51
        Me.DateTimePicker1.Visible = False
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(188, 437)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(136, 21)
        Me.cboPeriodo.TabIndex = 55
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(134, 439)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Periodo: "
        '
        'txtEjercicio
        '
        Me.txtEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEjercicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjercicio.Location = New System.Drawing.Point(86, 437)
        Me.txtEjercicio.MaxLength = 7
        Me.txtEjercicio.Name = "txtEjercicio"
        Me.txtEjercicio.Size = New System.Drawing.Size(40, 20)
        Me.txtEjercicio.TabIndex = 53
        Me.txtEjercicio.Text = "2010"
        Me.txtEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 439)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Ejercicio: "
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CODARTICULO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CODARTICULO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PRECIO1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PRECIO1"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PRECIO2"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PRECIO2"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PRECIO3"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PRECIO3"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
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
        'frmTransPrecios3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 470)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtEjercicio)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnsele)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtruta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTransPrecios3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de remuneraciones"
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtruta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsele As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnactualizar As System.Windows.Forms.Button
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents CODARTICULODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODPRESENTACIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO9DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO10DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECIO12DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEjercicio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
