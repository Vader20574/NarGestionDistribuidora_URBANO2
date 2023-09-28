<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptVentas7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRptVentas7))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpfin = New System.Windows.Forms.DateTimePicker
        Me.dtpinicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnpassizt = New System.Windows.Forms.Button
        Me.btnpassiz = New System.Windows.Forms.Button
        Me.btnpasde = New System.Windows.Forms.Button
        Me.btnpasdet = New System.Windows.Forms.Button
        Me.lbvende2 = New System.Windows.Forms.ListBox
        Me.lbvende1 = New System.Windows.Forms.ListBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.dgvcategoria = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetallePorDocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetalladoPorProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EfectividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnmostrar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbruta = New System.Windows.Forms.ComboBox
        Me.cmbfuerza = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LstSelecRuta = New System.Windows.Forms.ListBox
        Me.BtnQuitaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnQuitaUno_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaTodo_Ruta = New System.Windows.Forms.Button
        Me.BtnPasaUno_Ruta = New System.Windows.Forms.Button
        Me.LstDispRuta = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LstDispDistrito = New System.Windows.Forms.ListBox
        Me.LstSelecDistrito = New System.Windows.Forms.ListBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.ReporteVentaEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvcategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ReporteVentaEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Size = New System.Drawing.Size(565, 214)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendedores"
        '
        'btnpassizt
        '
        Me.btnpassizt.Location = New System.Drawing.Point(227, 135)
        Me.btnpassizt.Name = "btnpassizt"
        Me.btnpassizt.Size = New System.Drawing.Size(65, 23)
        Me.btnpassizt.TabIndex = 1
        Me.btnpassizt.Text = "<<"
        Me.btnpassizt.UseVisualStyleBackColor = True
        '
        'btnpassiz
        '
        Me.btnpassiz.Location = New System.Drawing.Point(227, 100)
        Me.btnpassiz.Name = "btnpassiz"
        Me.btnpassiz.Size = New System.Drawing.Size(65, 23)
        Me.btnpassiz.TabIndex = 1
        Me.btnpassiz.Text = "<"
        Me.btnpassiz.UseVisualStyleBackColor = True
        '
        'btnpasde
        '
        Me.btnpasde.Location = New System.Drawing.Point(227, 65)
        Me.btnpasde.Name = "btnpasde"
        Me.btnpasde.Size = New System.Drawing.Size(65, 23)
        Me.btnpasde.TabIndex = 1
        Me.btnpasde.Text = ">"
        Me.btnpasde.UseVisualStyleBackColor = True
        '
        'btnpasdet
        '
        Me.btnpasdet.Location = New System.Drawing.Point(227, 30)
        Me.btnpasdet.Name = "btnpasdet"
        Me.btnpasdet.Size = New System.Drawing.Size(65, 23)
        Me.btnpasdet.TabIndex = 1
        Me.btnpasdet.Text = ">>"
        Me.btnpasdet.UseVisualStyleBackColor = True
        '
        'lbvende2
        '
        Me.lbvende2.FormattingEnabled = True
        Me.lbvende2.Location = New System.Drawing.Point(316, 19)
        Me.lbvende2.Name = "lbvende2"
        Me.lbvende2.Size = New System.Drawing.Size(225, 186)
        Me.lbvende2.TabIndex = 0
        '
        'lbvende1
        '
        Me.lbvende1.FormattingEnabled = True
        Me.lbvende1.Location = New System.Drawing.Point(17, 19)
        Me.lbvende1.Name = "lbvende1"
        Me.lbvende1.Size = New System.Drawing.Size(204, 186)
        Me.lbvende1.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvcategoria)
        Me.GroupBox5.Location = New System.Drawing.Point(20, 357)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(533, 179)
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
        Me.dgvcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcategoria.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvcategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvcategoria.Location = New System.Drawing.Point(3, 16)
        Me.dgvcategoria.Name = "dgvcategoria"
        Me.dgvcategoria.ReadOnly = True
        Me.dgvcategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcategoria.Size = New System.Drawing.Size(527, 160)
        Me.dgvcategoria.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetallePorDocToolStripMenuItem, Me.DetalladoPorProductosToolStripMenuItem, Me.EfectividadToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(203, 70)
        '
        'DetallePorDocToolStripMenuItem
        '
        Me.DetallePorDocToolStripMenuItem.Name = "DetallePorDocToolStripMenuItem"
        Me.DetallePorDocToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DetallePorDocToolStripMenuItem.Text = "Detalle por Doc."
        '
        'DetalladoPorProductosToolStripMenuItem
        '
        Me.DetalladoPorProductosToolStripMenuItem.Name = "DetalladoPorProductosToolStripMenuItem"
        Me.DetalladoPorProductosToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DetalladoPorProductosToolStripMenuItem.Text = "Detallado por Productos"
        '
        'EfectividadToolStripMenuItem
        '
        Me.EfectividadToolStripMenuItem.Name = "EfectividadToolStripMenuItem"
        Me.EfectividadToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.EfectividadToolStripMenuItem.Text = "Efectividad"
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(570, 25)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnmostrar.TabIndex = 4
        Me.btnmostrar.Text = "Reporte 2"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbruta)
        Me.GroupBox3.Controls.Add(Me.cmbfuerza)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(594, 421)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(533, 50)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'cmbruta
        '
        Me.cmbruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbruta.FormattingEnabled = True
        Me.cmbruta.Location = New System.Drawing.Point(343, 18)
        Me.cmbruta.Name = "cmbruta"
        Me.cmbruta.Size = New System.Drawing.Size(162, 21)
        Me.cmbruta.TabIndex = 1
        '
        'cmbfuerza
        '
        Me.cmbfuerza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfuerza.FormattingEnabled = True
        Me.cmbfuerza.Location = New System.Drawing.Point(101, 18)
        Me.cmbfuerza.Name = "cmbfuerza"
        Me.cmbfuerza.Size = New System.Drawing.Size(162, 21)
        Me.cmbfuerza.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(291, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ruta :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 22)
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LstSelecRuta)
        Me.GroupBox4.Controls.Add(Me.BtnQuitaTodo_Ruta)
        Me.GroupBox4.Controls.Add(Me.BtnQuitaUno_Ruta)
        Me.GroupBox4.Controls.Add(Me.BtnPasaTodo_Ruta)
        Me.GroupBox4.Controls.Add(Me.BtnPasaUno_Ruta)
        Me.GroupBox4.Controls.Add(Me.LstDispRuta)
        Me.GroupBox4.Location = New System.Drawing.Point(1341, 58)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(720, 214)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ruta"
        '
        'LstSelecRuta
        '
        Me.LstSelecRuta.Location = New System.Drawing.Point(385, 19)
        Me.LstSelecRuta.Name = "LstSelecRuta"
        Me.LstSelecRuta.Size = New System.Drawing.Size(310, 186)
        Me.LstSelecRuta.TabIndex = 38
        '
        'BtnQuitaTodo_Ruta
        '
        Me.BtnQuitaTodo_Ruta.ImageIndex = 10
        Me.BtnQuitaTodo_Ruta.Location = New System.Drawing.Point(323, 139)
        Me.BtnQuitaTodo_Ruta.Name = "BtnQuitaTodo_Ruta"
        Me.BtnQuitaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaTodo_Ruta.TabIndex = 37
        Me.BtnQuitaTodo_Ruta.Text = "<<"
        '
        'BtnQuitaUno_Ruta
        '
        Me.BtnQuitaUno_Ruta.ImageIndex = 8
        Me.BtnQuitaUno_Ruta.Location = New System.Drawing.Point(323, 99)
        Me.BtnQuitaUno_Ruta.Name = "BtnQuitaUno_Ruta"
        Me.BtnQuitaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnQuitaUno_Ruta.TabIndex = 36
        Me.BtnQuitaUno_Ruta.Text = "<"
        '
        'BtnPasaTodo_Ruta
        '
        Me.BtnPasaTodo_Ruta.ImageIndex = 9
        Me.BtnPasaTodo_Ruta.Location = New System.Drawing.Point(323, 59)
        Me.BtnPasaTodo_Ruta.Name = "BtnPasaTodo_Ruta"
        Me.BtnPasaTodo_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaTodo_Ruta.TabIndex = 35
        Me.BtnPasaTodo_Ruta.Text = ">>"
        '
        'BtnPasaUno_Ruta
        '
        Me.BtnPasaUno_Ruta.ImageIndex = 7
        Me.BtnPasaUno_Ruta.Location = New System.Drawing.Point(323, 19)
        Me.BtnPasaUno_Ruta.Name = "BtnPasaUno_Ruta"
        Me.BtnPasaUno_Ruta.Size = New System.Drawing.Size(56, 32)
        Me.BtnPasaUno_Ruta.TabIndex = 34
        Me.BtnPasaUno_Ruta.Text = ">"
        '
        'LstDispRuta
        '
        Me.LstDispRuta.Location = New System.Drawing.Point(15, 19)
        Me.LstDispRuta.Name = "LstDispRuta"
        Me.LstDispRuta.Size = New System.Drawing.Size(302, 186)
        Me.LstDispRuta.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 514)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 514)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 25)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Total"
        '
        'LstDispDistrito
        '
        Me.LstDispDistrito.Location = New System.Drawing.Point(583, 77)
        Me.LstDispDistrito.Name = "LstDispDistrito"
        Me.LstDispDistrito.Size = New System.Drawing.Size(302, 186)
        Me.LstDispDistrito.TabIndex = 54
        '
        'LstSelecDistrito
        '
        Me.LstSelecDistrito.Location = New System.Drawing.Point(953, 77)
        Me.LstSelecDistrito.Name = "LstSelecDistrito"
        Me.LstSelecDistrito.Size = New System.Drawing.Size(310, 186)
        Me.LstSelecDistrito.TabIndex = 55
        '
        'Button6
        '
        Me.Button6.ImageIndex = 10
        Me.Button6.Location = New System.Drawing.Point(891, 197)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 32)
        Me.Button6.TabIndex = 64
        Me.Button6.Text = "<<"
        '
        'Button7
        '
        Me.Button7.ImageIndex = 8
        Me.Button7.Location = New System.Drawing.Point(891, 157)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 32)
        Me.Button7.TabIndex = 63
        Me.Button7.Text = "<"
        '
        'Button8
        '
        Me.Button8.ImageIndex = 9
        Me.Button8.Location = New System.Drawing.Point(891, 117)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 32)
        Me.Button8.TabIndex = 62
        Me.Button8.Text = ">>"
        '
        'Button9
        '
        Me.Button9.ImageIndex = 7
        Me.Button9.Location = New System.Drawing.Point(891, 77)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 32)
        Me.Button9.TabIndex = 61
        Me.Button9.Text = ">"
        '
        'ReporteVentaEBindingSource
        '
        Me.ReporteVentaEBindingSource.DataSource = GetType(NarGestionDistribuidora.ReporteVentaE)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(475, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Reporte 1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmRptVentas7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 321)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.LstSelecDistrito)
        Me.Controls.Add(Me.LstDispDistrito)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRptVentas7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas x Vendedor Categoria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvcategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ReporteVentaEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents ReporteVentaEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbruta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfuerza As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LstSelecRuta As System.Windows.Forms.ListBox
    Friend WithEvents BtnQuitaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnQuitaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaTodo_Ruta As System.Windows.Forms.Button
    Friend WithEvents BtnPasaUno_Ruta As System.Windows.Forms.Button
    Friend WithEvents LstDispRuta As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LstDispDistrito As System.Windows.Forms.ListBox
    Friend WithEvents LstSelecDistrito As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
