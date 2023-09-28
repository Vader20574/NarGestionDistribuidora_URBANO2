Public Class FrmConsultarMovimientoMercaderiaOC
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNroMovi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Lblmensaje As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents calmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
    Friend WithEvents rbNroDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents rbNroMovimiento As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents MoviCabEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NromoviDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NRODOCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECDOCUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDALMACENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DSALMACENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDTIPOMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DSTIPOMOVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESTADODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CDPROVEE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultarMovimientoMercaderiaOC))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.CDPROVEE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtNroMovi = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.LblTitulo = New System.Windows.Forms.Label
        Me.Lblmensaje = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.calmacen = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbNroDocumento = New System.Windows.Forms.RadioButton
        Me.rbNroMovimiento = New System.Windows.Forms.RadioButton
        Me.NromoviDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NRODOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECDOCUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDALMACENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DSALMACENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CDTIPOMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DSTIPOMOVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ESTADODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MoviCabEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MoviCabEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvlista)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1029, 281)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoGenerateColumns = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NromoviDataGridViewTextBoxColumn, Me.NRODOCDataGridViewTextBoxColumn, Me.FECDOCUMDataGridViewTextBoxColumn, Me.CDALMACENDataGridViewTextBoxColumn, Me.DSALMACENDataGridViewTextBoxColumn, Me.CDTIPOMOVDataGridViewTextBoxColumn, Me.DSTIPOMOVDataGridViewTextBoxColumn, Me.ESTADODataGridViewTextBoxColumn, Me.CDPROVEE})
        Me.dgvlista.DataSource = Me.MoviCabEBindingSource
        Me.dgvlista.Location = New System.Drawing.Point(9, 19)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlista.Size = New System.Drawing.Size(987, 225)
        Me.dgvlista.TabIndex = 0
        '
        'CDPROVEE
        '
        Me.CDPROVEE.DataPropertyName = "CDPROVEE"
        Me.CDPROVEE.HeaderText = "PROVEEDOR"
        Me.CDPROVEE.Name = "CDPROVEE"
        Me.CDPROVEE.ReadOnly = True
        Me.CDPROVEE.Width = 250
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtNroMovi)
        Me.GroupBox2.Location = New System.Drawing.Point(174, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 40)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'TxtNroMovi
        '
        Me.TxtNroMovi.Location = New System.Drawing.Point(5, 13)
        Me.TxtNroMovi.Name = "TxtNroMovi"
        Me.TxtNroMovi.Size = New System.Drawing.Size(128, 20)
        Me.TxtNroMovi.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(34, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ingrese Nro Movimiento :"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(660, 374)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(66, 62)
        Me.GroupBox5.TabIndex = 165
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(8, 8)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(50, 48)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'LblTitulo
        '
        Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(1067, 30)
        Me.LblTitulo.TabIndex = 166
        Me.LblTitulo.Text = "CONSULTA DE  INGRESOS"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblmensaje
        '
        Me.Lblmensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmensaje.Location = New System.Drawing.Point(16, 380)
        Me.Lblmensaje.Name = "Lblmensaje"
        Me.Lblmensaje.Size = New System.Drawing.Size(412, 23)
        Me.Lblmensaje.TabIndex = 167
        Me.Lblmensaje.Text = "Nro de registros encontrados :  "
        Me.Lblmensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(14, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 41)
        Me.Panel1.TabIndex = 168
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.calmacen)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.BtnFiltrar)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(769, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(367, 60)
        Me.Panel2.TabIndex = 66
        Me.Panel2.Visible = False
        '
        'calmacen
        '
        Me.calmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.calmacen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calmacen.Location = New System.Drawing.Point(82, 4)
        Me.calmacen.Name = "calmacen"
        Me.calmacen.Size = New System.Drawing.Size(192, 22)
        Me.calmacen.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 14)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "  Almacén :  "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnFiltrar.ImageIndex = 1
        Me.BtnFiltrar.ImageList = Me.ImageList1
        Me.BtnFiltrar.Location = New System.Drawing.Point(296, 2)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(59, 54)
        Me.BtnFiltrar.TabIndex = 8
        Me.BtnFiltrar.Text = "&Filtrar"
        Me.BtnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 14)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = " Des :  "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(54, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(90, 20)
        Me.DateTimePicker1.TabIndex = 62
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(186, 33)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(146, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 14)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Has :  "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNroDocumento)
        Me.GroupBox1.Controls.Add(Me.rbNroMovimiento)
        Me.GroupBox1.Location = New System.Drawing.Point(544, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 52)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'rbNroDocumento
        '
        Me.rbNroDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNroDocumento.Location = New System.Drawing.Point(7, 32)
        Me.rbNroDocumento.Name = "rbNroDocumento"
        Me.rbNroDocumento.Size = New System.Drawing.Size(149, 20)
        Me.rbNroDocumento.TabIndex = 68
        Me.rbNroDocumento.Text = "Ingrese Nro Documento"
        '
        'rbNroMovimiento
        '
        Me.rbNroMovimiento.Checked = True
        Me.rbNroMovimiento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNroMovimiento.Location = New System.Drawing.Point(10, 9)
        Me.rbNroMovimiento.Name = "rbNroMovimiento"
        Me.rbNroMovimiento.Size = New System.Drawing.Size(149, 23)
        Me.rbNroMovimiento.TabIndex = 67
        Me.rbNroMovimiento.TabStop = True
        Me.rbNroMovimiento.Text = "Ingrese Nro Movimiento"
        '
        'NromoviDataGridViewTextBoxColumn
        '
        Me.NromoviDataGridViewTextBoxColumn.DataPropertyName = "Nromovi"
        Me.NromoviDataGridViewTextBoxColumn.HeaderText = "NRO MOVIMIENTO"
        Me.NromoviDataGridViewTextBoxColumn.Name = "NromoviDataGridViewTextBoxColumn"
        Me.NromoviDataGridViewTextBoxColumn.ReadOnly = True
        Me.NromoviDataGridViewTextBoxColumn.Width = 130
        '
        'NRODOCDataGridViewTextBoxColumn
        '
        Me.NRODOCDataGridViewTextBoxColumn.DataPropertyName = "NRODOC"
        Me.NRODOCDataGridViewTextBoxColumn.HeaderText = "NRO DOCUMENTO"
        Me.NRODOCDataGridViewTextBoxColumn.Name = "NRODOCDataGridViewTextBoxColumn"
        Me.NRODOCDataGridViewTextBoxColumn.ReadOnly = True
        Me.NRODOCDataGridViewTextBoxColumn.Width = 130
        '
        'FECDOCUMDataGridViewTextBoxColumn
        '
        Me.FECDOCUMDataGridViewTextBoxColumn.DataPropertyName = "FECDOCUM"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.FECDOCUMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FECDOCUMDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FECDOCUMDataGridViewTextBoxColumn.Name = "FECDOCUMDataGridViewTextBoxColumn"
        Me.FECDOCUMDataGridViewTextBoxColumn.ReadOnly = True
        Me.FECDOCUMDataGridViewTextBoxColumn.Width = 80
        '
        'CDALMACENDataGridViewTextBoxColumn
        '
        Me.CDALMACENDataGridViewTextBoxColumn.DataPropertyName = "CDALMACEN"
        Me.CDALMACENDataGridViewTextBoxColumn.HeaderText = "CDALMACEN"
        Me.CDALMACENDataGridViewTextBoxColumn.Name = "CDALMACENDataGridViewTextBoxColumn"
        Me.CDALMACENDataGridViewTextBoxColumn.ReadOnly = True
        Me.CDALMACENDataGridViewTextBoxColumn.Visible = False
        '
        'DSALMACENDataGridViewTextBoxColumn
        '
        Me.DSALMACENDataGridViewTextBoxColumn.DataPropertyName = "DSALMACEN"
        Me.DSALMACENDataGridViewTextBoxColumn.HeaderText = "ALMACEN"
        Me.DSALMACENDataGridViewTextBoxColumn.Name = "DSALMACENDataGridViewTextBoxColumn"
        Me.DSALMACENDataGridViewTextBoxColumn.ReadOnly = True
        Me.DSALMACENDataGridViewTextBoxColumn.Width = 130
        '
        'CDTIPOMOVDataGridViewTextBoxColumn
        '
        Me.CDTIPOMOVDataGridViewTextBoxColumn.DataPropertyName = "CDTIPOMOV"
        Me.CDTIPOMOVDataGridViewTextBoxColumn.HeaderText = "CDTIPOMOV"
        Me.CDTIPOMOVDataGridViewTextBoxColumn.Name = "CDTIPOMOVDataGridViewTextBoxColumn"
        Me.CDTIPOMOVDataGridViewTextBoxColumn.ReadOnly = True
        Me.CDTIPOMOVDataGridViewTextBoxColumn.Visible = False
        '
        'DSTIPOMOVDataGridViewTextBoxColumn
        '
        Me.DSTIPOMOVDataGridViewTextBoxColumn.DataPropertyName = "DSTIPOMOV"
        Me.DSTIPOMOVDataGridViewTextBoxColumn.HeaderText = "TIPO MOVIMIENTO"
        Me.DSTIPOMOVDataGridViewTextBoxColumn.Name = "DSTIPOMOVDataGridViewTextBoxColumn"
        Me.DSTIPOMOVDataGridViewTextBoxColumn.ReadOnly = True
        Me.DSTIPOMOVDataGridViewTextBoxColumn.Width = 160
        '
        'ESTADODataGridViewTextBoxColumn
        '
        Me.ESTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO"
        Me.ESTADODataGridViewTextBoxColumn.Name = "ESTADODataGridViewTextBoxColumn"
        Me.ESTADODataGridViewTextBoxColumn.ReadOnly = True
        Me.ESTADODataGridViewTextBoxColumn.Width = 50
        '
        'MoviCabEBindingSource
        '
        Me.MoviCabEBindingSource.DataSource = GetType(NarGestionDistribuidora.MoviCabE)
        '
        'FrmConsultarMovimientoMercaderiaOC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1067, 442)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Lblmensaje)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmConsultarMovimientoMercaderiaOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Movimiento Mercaderia"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.MoviCabEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "VARIABLES"
    Public DEVOLVER As Boolean
    Public TABLE_MOV As New DataTable
    Public INOUT As Integer
    Dim nromeses As Integer
    Dim NomTablaC, NomTablaD As String
    Dim fechaini, fechahas As Date
    Public Lista As New List(Of MoviCabE)
    Dim Table_Filtro As New DataTable
    Dim Movidet As String
#End Region
#Region "FUNCIONES"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        'Const WIND_KEYDOWN As Integer = &H100
        'Const WIND_SYSTEM As Integer = &H104
        'If (MSG.Msg = WIND_KEYDOWN) Or (MSG.Msg = WIND_SYSTEM) Then
        '    If DataGridMov.Focus = True Then
        '        If TABLE_MOV.Rows.Count > 0 Then
        '            DEVOLVER = True
        '            Me.Close()
        '        End If
        '    End If
        'End If
    End Function


    Private Sub CargarGrid()
        TABLE_MOV = TmpListarDatos("NSP_LISTAR_MOVIMIENTO_MERCOC'" & codempresa & "','" & INOUT & "'")
        LLenar_Lista(TABLE_MOV)
        MoviCabEBindingSource.ResetBindings(False)
        MoviCabEBindingSource.DataSource = Lista
        Lblmensaje.Text = Lblmensaje.Text & TABLE_MOV.Rows.Count
    End Sub

#End Region

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmConsultarMovimientoMercaderia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(Me.calmacen, "USP_LLENAR_ALMACEN  '" & codempresa & "'", "Codigo", "Descripcion")
        CargarGrid()
        If INOUT = 1 Then
            LblTitulo.Text = "CONSULTA DE INGRESOS"
        Else
            LblTitulo.Text = "CONSULTA DE SALIDAS"
        End If

    End Sub

    Private Sub TxtNroMovi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNroMovi.TextChanged
        llenar()
    End Sub

    Sub llenar()
        Table_Filtro = CAyuda.ListarDatos("SP_LIST_HISTOMOVI", codempresa).Tables(0)
        Lista.Clear()
        For Each dr As DataRow In Table_Filtro.Rows
            Movidet = dr.Item(0).ToString.Replace("MOVIC", "MOVID")
            If rbNroMovimiento.Checked = True And TxtNroMovi.Text.Trim.Length <> 0 Then
                TABLE_MOV = TmpListarDatos("NSP_LISTAR_MOVIMIENTO_MERC_FILTRO_OC  '" & codempresa & "','" & INOUT & "','" & 0 & "','" & TxtNroMovi.Text & "','" & dr.Item(0).ToString & "'," & 1)
                LLenar_Lista(TABLE_MOV, dr.Item(0).ToString, Movidet)
            End If

            If rbNroDocumento.Checked = True And TxtNroMovi.Text.Trim.Length <> 0 Then
                TABLE_MOV = TmpListarDatos("NSP_LISTAR_MOVIMIENTO_MERC_FILTRO_OC  '" & codempresa & "','" & INOUT & "','" & 1 & "','" & TxtNroMovi.Text & "','" & dr.Item(0).ToString & "'," & 1)
                LLenar_Lista(TABLE_MOV, dr.Item(0).ToString, Movidet)
            End If
        Next

        If TxtNroMovi.Text = "" Then
            TABLE_MOV = TmpListarDatos("NSP_LISTAR_MOVIMIENTO_MERCOC  '" & codempresa & "','" & INOUT & "'")
            LLenar_Lista(TABLE_MOV)
        End If

        If rbNroMovimiento.Checked = True And TxtNroMovi.Text.Trim.Length <> 0 Then
            TABLE_MOV = TmpListarDatos("NSP_LISTAR_MOVIMIENTO_MERC_FILTRO_OC  '" & codempresa & "','" & INOUT & "','" & 0 & "','" & TxtNroMovi.Text & "',''," & 0)
            LLenar_Lista(TABLE_MOV)
        End If

        If rbNroDocumento.Checked = True And TxtNroMovi.Text.Trim.Length <> 0 Then
            TABLE_MOV = TmpListarDatos("NSP_LISTAR_MOVIMIENTO_MERC_FILTRO  '" & codempresa & "','" & INOUT & "','" & 1 & "','" & TxtNroMovi.Text & "',''," & 0)
            LLenar_Lista(TABLE_MOV)
        End If

        MoviCabEBindingSource.ResetBindings(True)
        MoviCabEBindingSource.DataSource = Lista
    End Sub

    Private Sub DataGridMov_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If TABLE_MOV.Rows.Count > 0 Then
            DEVOLVER = True
            Me.Close()
        End If
    End Sub

    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        Calcula_Meses()
        Lista.Clear()
        For i As Integer = 0 To nromeses

            NomTablaC = "MOVIC" & Format(DateAdd("m", i, fechaini), "yyyyMM")
            NomTablaD = "MOVID" & Format(DateAdd("m", i, fechaini), "yyyyMM")

            If CAyuda.ListarDatos("SP_VERIFICA_HISTOMOVI", NomTablaC, codempresa).Tables(0).Rows.Count > 0 Then
                TABLE_MOV = TmpListarDatos("NSP_LISTAR_MOVIMIENTO_MERC_2  '" & codempresa & "','" & INOUT & "','" & calmacen.SelectedValue & "','" & fechaini.ToShortDateString & "','" & fechahas.ToShortDateString & "','" & NomTablaC & "'," & 1)
                LLenar_Lista(TABLE_MOV, NomTablaC, NomTablaD)
            End If
        Next

        TABLE_MOV = TmpListarDatos("NSP_LISTAR_MOVIMIENTO_MERC_2  '" & codempresa & "','" & INOUT & "','" & calmacen.SelectedValue & "','" & fechaini.ToShortDateString & "','" & fechahas.ToShortDateString & "','" & NomTablaC & "'," & 0)
        LLenar_Lista(TABLE_MOV)

        MoviCabEBindingSource.ResetBindings(False)
        MoviCabEBindingSource.DataSource = Lista

        Lblmensaje.Text = "Nro de registros encontrados : " & Lista.Count
    End Sub

    Private Sub LLenar_Lista(ByVal dt As DataTable, Optional ByVal tablaC As String = "", Optional ByVal tablade As String = "")
        For Each dr As DataRow In dt.Rows
            Dim oM As New MoviCabE
            oM.Nromovi = dr.Item(0)
            oM.NRODOC = dr.Item(1)
            oM.FECDOCUM = dr.Item(2)
            oM.CDALMACEN = dr.Item(3)
            oM.DSALMACEN = dr.Item(4)
            oM.CDTIPOMOV = dr.Item(5)
            oM.DSTIPOMOV = dr.Item(6)
            oM.ESTADO = dr.Item(7)
            oM.CDPROVEE = dr.Item(8)
            oM.TABLACAB = tablaC
            oM.TABLADET = tablade
            Lista.Add(oM)
        Next

    End Sub

    Private Sub Calcula_Meses()
        fechaini = String.Format(Me.DateTimePicker1.Value.ToShortDateString, "dd/MM/yyyy")
        fechahas = String.Format(Me.DateTimePicker2.Value.ToShortDateString, "dd/MM/yyyy")
        nromeses = DateDiff("m", fechaini, fechahas)
    End Sub

    Private Sub dgvlista_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvlista.DoubleClick
        If Lista.Count > 0 Then
            DEVOLVER = True
            Me.Close()
        End If
    End Sub

    Private Sub dgvlista_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvlista.CellContentClick

    End Sub
End Class
