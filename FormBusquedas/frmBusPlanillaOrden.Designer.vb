<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusPlanillaOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusPlanillaOrden))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtOrdenDespacho = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtFin = New System.Windows.Forms.DateTimePicker
        Me.DtIni = New System.Windows.Forms.DateTimePicker
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.NroPlanillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalBasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlanillaOrdenEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillaOrdenEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(428, 326)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(8, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nro de Planilla"
        '
        'txtOrdenDespacho
        '
        Me.txtOrdenDespacho.Location = New System.Drawing.Point(132, 65)
        Me.txtOrdenDespacho.Name = "txtOrdenDespacho"
        Me.txtOrdenDespacho.Size = New System.Drawing.Size(207, 20)
        Me.txtOrdenDespacho.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtFin)
        Me.Panel1.Controls.Add(Me.DtIni)
        Me.Panel1.Controls.Add(Me.BtnFiltrar)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 46)
        Me.Panel1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "De"
        '
        'dtFin
        '
        Me.dtFin.Checked = False
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(234, 11)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.ShowCheckBox = True
        Me.dtFin.Size = New System.Drawing.Size(124, 20)
        Me.dtFin.TabIndex = 3
        '
        'DtIni
        '
        Me.DtIni.Checked = False
        Me.DtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtIni.Location = New System.Drawing.Point(34, 11)
        Me.DtIni.Name = "DtIni"
        Me.DtIni.ShowCheckBox = True
        Me.DtIni.Size = New System.Drawing.Size(144, 20)
        Me.DtIni.TabIndex = 2
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(368, 7)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(82, 28)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 233)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "# DESPACHO"
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AllowUserToResizeRows = False
        Me.dgvlista.AutoGenerateColumns = False
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroPlanillaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TotalBasDataGridViewTextBoxColumn})
        Me.dgvlista.DataSource = Me.PlanillaOrdenEBindingSource
        Me.dgvlista.Location = New System.Drawing.Point(12, 92)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.Size = New System.Drawing.Size(411, 299)
        Me.dgvlista.TabIndex = 12
        '
        'NroPlanillaDataGridViewTextBoxColumn
        '
        Me.NroPlanillaDataGridViewTextBoxColumn.DataPropertyName = "NroPlanilla"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NroPlanillaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.NroPlanillaDataGridViewTextBoxColumn.HeaderText = "NRO PLANILLA"
        Me.NroPlanillaDataGridViewTextBoxColumn.Name = "NroPlanillaDataGridViewTextBoxColumn"
        Me.NroPlanillaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NroPlanillaDataGridViewTextBoxColumn.Width = 120
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalBasDataGridViewTextBoxColumn
        '
        Me.TotalBasDataGridViewTextBoxColumn.DataPropertyName = "TotalBas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.TotalBasDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalBasDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TotalBasDataGridViewTextBoxColumn.Name = "TotalBasDataGridViewTextBoxColumn"
        Me.TotalBasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlanillaOrdenEBindingSource
        '
        Me.PlanillaOrdenEBindingSource.DataSource = GetType(NarGestionDistribuidora.PlanillaOrdenE)
        '
        'frmBusPlanillaOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 403)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOrdenDespacho)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBusPlanillaOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Planilla"
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillaOrdenEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOrdenDespacho As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents PlanillaOrdenEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NroPlanillaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalBasDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
