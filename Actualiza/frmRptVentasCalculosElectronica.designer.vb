<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRptVentasCalculosElectronica
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptVentasCalculosElectronica))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpfin = New System.Windows.Forms.DateTimePicker()
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnpassizt = New System.Windows.Forms.Button()
        Me.btnpassiz = New System.Windows.Forms.Button()
        Me.btnpasde = New System.Windows.Forms.Button()
        Me.btnpasdet = New System.Windows.Forms.Button()
        Me.lbvende2 = New System.Windows.Forms.ListBox()
        Me.lbvende1 = New System.Windows.Forms.ListBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvcategoria = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTOCUOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUOTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetalladoPorProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EfectividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetallePorDocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EfectividadPorVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetallePorDocTodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteVentaEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbruta = New System.Windows.Forms.ComboBox()
        Me.cmbfuerza = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ReporteVentaEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfin)
        Me.GroupBox1.Controls.Add(Me.dtpinicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fechas"
        '
        'dtpfin
        '
        Me.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfin.Location = New System.Drawing.Point(316, 12)
        Me.dtpfin.Name = "dtpfin"
        Me.dtpfin.Size = New System.Drawing.Size(110, 20)
        Me.dtpfin.TabIndex = 1
        '
        'dtpinicio
        '
        Me.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpinicio.Location = New System.Drawing.Point(98, 12)
        Me.dtpinicio.Name = "dtpinicio"
        Me.dtpinicio.Size = New System.Drawing.Size(110, 20)
        Me.dtpinicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnpassizt)
        Me.GroupBox2.Controls.Add(Me.btnpassiz)
        Me.GroupBox2.Controls.Add(Me.btnpasde)
        Me.GroupBox2.Controls.Add(Me.btnpasdet)
        Me.GroupBox2.Controls.Add(Me.lbvende2)
        Me.GroupBox2.Controls.Add(Me.lbvende1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 214)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendedores"
        '
        'btnpassizt
        '
        Me.btnpassizt.Location = New System.Drawing.Point(246, 135)
        Me.btnpassizt.Name = "btnpassizt"
        Me.btnpassizt.Size = New System.Drawing.Size(65, 23)
        Me.btnpassizt.TabIndex = 1
        Me.btnpassizt.Text = "<<"
        Me.btnpassizt.UseVisualStyleBackColor = True
        '
        'btnpassiz
        '
        Me.btnpassiz.Location = New System.Drawing.Point(246, 100)
        Me.btnpassiz.Name = "btnpassiz"
        Me.btnpassiz.Size = New System.Drawing.Size(65, 23)
        Me.btnpassiz.TabIndex = 1
        Me.btnpassiz.Text = "<"
        Me.btnpassiz.UseVisualStyleBackColor = True
        '
        'btnpasde
        '
        Me.btnpasde.Location = New System.Drawing.Point(246, 65)
        Me.btnpasde.Name = "btnpasde"
        Me.btnpasde.Size = New System.Drawing.Size(65, 23)
        Me.btnpasde.TabIndex = 1
        Me.btnpasde.Text = ">"
        Me.btnpasde.UseVisualStyleBackColor = True
        '
        'btnpasdet
        '
        Me.btnpasdet.Location = New System.Drawing.Point(246, 30)
        Me.btnpasdet.Name = "btnpasdet"
        Me.btnpasdet.Size = New System.Drawing.Size(65, 23)
        Me.btnpasdet.TabIndex = 1
        Me.btnpasdet.Text = ">>"
        Me.btnpasdet.UseVisualStyleBackColor = True
        '
        'lbvende2
        '
        Me.lbvende2.FormattingEnabled = True
        Me.lbvende2.Location = New System.Drawing.Point(328, 19)
        Me.lbvende2.Name = "lbvende2"
        Me.lbvende2.Size = New System.Drawing.Size(208, 186)
        Me.lbvende2.TabIndex = 0
        '
        'lbvende1
        '
        Me.lbvende1.FormattingEnabled = True
        Me.lbvende1.Location = New System.Drawing.Point(17, 19)
        Me.lbvende1.Name = "lbvende1"
        Me.lbvende1.Size = New System.Drawing.Size(208, 186)
        Me.lbvende1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvcategoria)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 325)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(558, 179)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Categorias"
        '
        'dgvcategoria
        '
        Me.dgvcategoria.AllowUserToAddRows = False
        Me.dgvcategoria.AllowUserToDeleteRows = False
        Me.dgvcategoria.AllowUserToResizeColumns = False
        Me.dgvcategoria.AllowUserToResizeRows = False
        Me.dgvcategoria.AutoGenerateColumns = False
        Me.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.MONTOCUOTADataGridViewTextBoxColumn, Me.CUOTADataGridViewTextBoxColumn})
        Me.dgvcategoria.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvcategoria.DataSource = Me.ReporteVentaEBindingSource
        Me.dgvcategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcategoria.Location = New System.Drawing.Point(3, 16)
        Me.dgvcategoria.Name = "dgvcategoria"
        Me.dgvcategoria.ReadOnly = True
        Me.dgvcategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcategoria.Size = New System.Drawing.Size(552, 160)
        Me.dgvcategoria.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CODIGO"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TOTAL"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'MONTOCUOTADataGridViewTextBoxColumn
        '
        Me.MONTOCUOTADataGridViewTextBoxColumn.DataPropertyName = "MONTOCUOTA"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.MONTOCUOTADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.MONTOCUOTADataGridViewTextBoxColumn.HeaderText = "Monto C."
        Me.MONTOCUOTADataGridViewTextBoxColumn.Name = "MONTOCUOTADataGridViewTextBoxColumn"
        Me.MONTOCUOTADataGridViewTextBoxColumn.ReadOnly = True
        Me.MONTOCUOTADataGridViewTextBoxColumn.Width = 80
        '
        'CUOTADataGridViewTextBoxColumn
        '
        Me.CUOTADataGridViewTextBoxColumn.DataPropertyName = "CUOTA"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.CUOTADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.CUOTADataGridViewTextBoxColumn.HeaderText = "Cuota %"
        Me.CUOTADataGridViewTextBoxColumn.Name = "CUOTADataGridViewTextBoxColumn"
        Me.CUOTADataGridViewTextBoxColumn.ReadOnly = True
        Me.CUOTADataGridViewTextBoxColumn.Width = 80
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalladoPorProductosToolStripMenuItem, Me.EfectividadToolStripMenuItem, Me.DetallePorDocToolStripMenuItem, Me.DeToolStripMenuItem, Me.EfectividadPorVendedorToolStripMenuItem, Me.DetallePorDocTodosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(264, 136)
        '
        'DetalladoPorProductosToolStripMenuItem
        '
        Me.DetalladoPorProductosToolStripMenuItem.Name = "DetalladoPorProductosToolStripMenuItem"
        Me.DetalladoPorProductosToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.DetalladoPorProductosToolStripMenuItem.Text = "Detallado por Productos x vendedor"
        Me.DetalladoPorProductosToolStripMenuItem.Visible = False
        '
        'EfectividadToolStripMenuItem
        '
        Me.EfectividadToolStripMenuItem.Name = "EfectividadToolStripMenuItem"
        Me.EfectividadToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.EfectividadToolStripMenuItem.Text = "Detallado por Productos Todo"
        Me.EfectividadToolStripMenuItem.Visible = False
        '
        'DetallePorDocToolStripMenuItem
        '
        Me.DetallePorDocToolStripMenuItem.Name = "DetallePorDocToolStripMenuItem"
        Me.DetallePorDocToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.DetallePorDocToolStripMenuItem.Text = "Detalle por Doc."
        '
        'DeToolStripMenuItem
        '
        Me.DeToolStripMenuItem.Name = "DeToolStripMenuItem"
        Me.DeToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.DeToolStripMenuItem.Text = "Efectividad"
        Me.DeToolStripMenuItem.Visible = False
        '
        'EfectividadPorVendedorToolStripMenuItem
        '
        Me.EfectividadPorVendedorToolStripMenuItem.Name = "EfectividadPorVendedorToolStripMenuItem"
        Me.EfectividadPorVendedorToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.EfectividadPorVendedorToolStripMenuItem.Text = "Efectividad por Vendedor"
        Me.EfectividadPorVendedorToolStripMenuItem.Visible = False
        '
        'DetallePorDocTodosToolStripMenuItem
        '
        Me.DetallePorDocTodosToolStripMenuItem.Name = "DetallePorDocTodosToolStripMenuItem"
        Me.DetallePorDocTodosToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.DetallePorDocTodosToolStripMenuItem.Text = "Detalle por Doc.Todas las Categoria"
        '
        'ReporteVentaEBindingSource
        '
        Me.ReporteVentaEBindingSource.DataSource = GetType(NarGestionDistribuidora.ReporteVentaE)
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(470, 24)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnmostrar.TabIndex = 4
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbruta)
        Me.GroupBox3.Controls.Add(Me.cmbfuerza)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 273)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 50)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'cmbruta
        '
        Me.cmbruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbruta.FormattingEnabled = True
        Me.cmbruta.Location = New System.Drawing.Point(358, 18)
        Me.cmbruta.Name = "cmbruta"
        Me.cmbruta.Size = New System.Drawing.Size(162, 21)
        Me.cmbruta.TabIndex = 1
        '
        'cmbfuerza
        '
        Me.cmbfuerza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfuerza.FormattingEnabled = True
        Me.cmbfuerza.Location = New System.Drawing.Point(116, 18)
        Me.cmbfuerza.Name = "cmbfuerza"
        Me.cmbfuerza.Size = New System.Drawing.Size(162, 21)
        Me.cmbfuerza.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(306, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ruta :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fuerza Venta :"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(306, -5)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 6
        '
        'frmRptVentasCalculosElectronica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 548)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRptVentasCalculosElectronica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Venta Calculos Electronica"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ReporteVentaEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbvende2 As System.Windows.Forms.ListBox
    Friend WithEvents lbvende1 As System.Windows.Forms.ListBox
    Friend WithEvents btnpassizt As System.Windows.Forms.Button
    Friend WithEvents btnpassiz As System.Windows.Forms.Button
    Friend WithEvents btnpasde As System.Windows.Forms.Button
    Friend WithEvents btnpasdet As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvcategoria As System.Windows.Forms.DataGridView
    Friend WithEvents CODIGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DetallePorDocToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetalladoPorProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EfectividadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnmostrar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTOCUOTADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUOTADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReporteVentaEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbruta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfuerza As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents DeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EfectividadPorVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetallePorDocTodosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
