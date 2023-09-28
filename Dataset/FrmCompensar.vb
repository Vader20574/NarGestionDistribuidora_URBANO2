Public Class FrmCompensar
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCaja As System.Windows.Forms.ComboBox
    Friend WithEvents label8 As System.Windows.Forms.Label
    Friend WithEvents lbNumPlanilla As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMontoCompensado As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMontoCompensar As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dgCompensacion As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbSubCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRucProv As System.Windows.Forms.TextBox
    Friend WithEvents txtRucAdq As System.Windows.Forms.TextBox
    Friend WithEvents txtTributario As System.Windows.Forms.TextBox
    Friend WithEvents txtBienServicio As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CODCAJA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCAJA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUENTAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPOC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BServi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PTributario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RucADQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RucProve As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.txtRucProv = New System.Windows.Forms.TextBox
        Me.txtRucAdq = New System.Windows.Forms.TextBox
        Me.txtTributario = New System.Windows.Forms.TextBox
        Me.txtBienServicio = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbSubCuentaContable = New System.Windows.Forms.ComboBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbCuentaContable = New System.Windows.Forms.ComboBox
        Me.dgCompensacion = New System.Windows.Forms.DataGridView
        Me.CODCAJA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DESCAJA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CUENTAC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPOC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BServi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PTributario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RucADQ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RucProve = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cbCaja = New System.Windows.Forms.ComboBox
        Me.label8 = New System.Windows.Forms.Label
        Me.lbNumPlanilla = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblMontoCompensar = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTipoComp = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblMontoCompensado = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCompensacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txtRucProv)
        Me.GroupBox1.Controls.Add(Me.txtRucAdq)
        Me.GroupBox1.Controls.Add(Me.txtTributario)
        Me.GroupBox1.Controls.Add(Me.txtBienServicio)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbSubCuentaContable)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbCuentaContable)
        Me.GroupBox1.Controls.Add(Me.dgCompensacion)
        Me.GroupBox1.Controls.Add(Me.cbCaja)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.lbNumPlanilla)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblMontoCompensar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbTipoComp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 541)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(134, 212)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "Solo Detraccion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtRucProv
        '
        Me.txtRucProv.Location = New System.Drawing.Point(138, 312)
        Me.txtRucProv.Name = "txtRucProv"
        Me.txtRucProv.Size = New System.Drawing.Size(154, 20)
        Me.txtRucProv.TabIndex = 36
        '
        'txtRucAdq
        '
        Me.txtRucAdq.Location = New System.Drawing.Point(140, 286)
        Me.txtRucAdq.Name = "txtRucAdq"
        Me.txtRucAdq.Size = New System.Drawing.Size(154, 20)
        Me.txtRucAdq.TabIndex = 35
        '
        'txtTributario
        '
        Me.txtTributario.Location = New System.Drawing.Point(140, 256)
        Me.txtTributario.Name = "txtTributario"
        Me.txtTributario.Size = New System.Drawing.Size(154, 20)
        Me.txtTributario.TabIndex = 34
        '
        'txtBienServicio
        '
        Me.txtBienServicio.Location = New System.Drawing.Point(140, 230)
        Me.txtBienServicio.Name = "txtBienServicio"
        Me.txtBienServicio.Size = New System.Drawing.Size(154, 20)
        Me.txtBienServicio.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(18, 314)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 18)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Ruc Prov :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(18, 288)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 18)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Ruc ADQ :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(20, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 18)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "P.Tributario :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(22, 232)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 18)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Bien/Servicio :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(13, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 18)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Sub Cuenta Contable : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSubCuentaContable
        '
        Me.cbSubCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbSubCuentaContable.Location = New System.Drawing.Point(134, 180)
        Me.cbSubCuentaContable.Name = "cbSubCuentaContable"
        Me.cbSubCuentaContable.Size = New System.Drawing.Size(140, 21)
        Me.cbSubCuentaContable.TabIndex = 27
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(336, 156)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(90, 20)
        Me.dtpFecha.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(290, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Fecha :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(38, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 18)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Cuenta Contable : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCuentaContable
        '
        Me.cbCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbCuentaContable.Location = New System.Drawing.Point(134, 153)
        Me.cbCuentaContable.Name = "cbCuentaContable"
        Me.cbCuentaContable.Size = New System.Drawing.Size(140, 21)
        Me.cbCuentaContable.TabIndex = 23
        '
        'dgCompensacion
        '
        Me.dgCompensacion.AllowUserToAddRows = False
        Me.dgCompensacion.AllowUserToDeleteRows = False
        Me.dgCompensacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCompensacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCompensacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODCAJA, Me.DESCAJA, Me.TIPO, Me.NUMERO, Me.MONTO, Me.CUENTAC, Me.TIPOC, Me.BServi, Me.PTributario, Me.RucADQ, Me.RucProve})
        Me.dgCompensacion.Location = New System.Drawing.Point(21, 360)
        Me.dgCompensacion.Name = "dgCompensacion"
        Me.dgCompensacion.ReadOnly = True
        Me.dgCompensacion.RowHeadersWidth = 20
        Me.dgCompensacion.Size = New System.Drawing.Size(486, 166)
        Me.dgCompensacion.TabIndex = 9
        '
        'CODCAJA
        '
        Me.CODCAJA.DataPropertyName = "CODCAJA"
        Me.CODCAJA.HeaderText = "CODCAJA"
        Me.CODCAJA.Name = "CODCAJA"
        Me.CODCAJA.ReadOnly = True
        Me.CODCAJA.Visible = False
        '
        'DESCAJA
        '
        Me.DESCAJA.DataPropertyName = "DESCAJA"
        Me.DESCAJA.FillWeight = 215.1945!
        Me.DESCAJA.HeaderText = "CAJA"
        Me.DESCAJA.Name = "DESCAJA"
        Me.DESCAJA.ReadOnly = True
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        Me.TIPO.FillWeight = 179.3288!
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'NUMERO
        '
        Me.NUMERO.DataPropertyName = "NUMERO"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.NUMERO.DefaultCellStyle = DataGridViewCellStyle5
        Me.NUMERO.FillWeight = 161.3959!
        Me.NUMERO.HeaderText = "NUMERO"
        Me.NUMERO.Name = "NUMERO"
        Me.NUMERO.ReadOnly = True
        '
        'MONTO
        '
        Me.MONTO.DataPropertyName = "MONTO"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.MONTO.DefaultCellStyle = DataGridViewCellStyle6
        Me.MONTO.FillWeight = 161.3959!
        Me.MONTO.HeaderText = "MONTO"
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'CUENTAC
        '
        Me.CUENTAC.DataPropertyName = "CUENTAC"
        Me.CUENTAC.HeaderText = "CUENTA CONTABLE"
        Me.CUENTAC.Name = "CUENTAC"
        Me.CUENTAC.ReadOnly = True
        Me.CUENTAC.Visible = False
        '
        'TIPOC
        '
        Me.TIPOC.DataPropertyName = "TIPOC"
        Me.TIPOC.HeaderText = "TIPOC"
        Me.TIPOC.Name = "TIPOC"
        Me.TIPOC.ReadOnly = True
        Me.TIPOC.Visible = False
        '
        'BServi
        '
        Me.BServi.DataPropertyName = "RucProve"
        Me.BServi.FillWeight = 20.30457!
        Me.BServi.HeaderText = "RucProve"
        Me.BServi.Name = "BServi"
        Me.BServi.ReadOnly = True
        '
        'PTributario
        '
        Me.PTributario.DataPropertyName = "PTributario"
        Me.PTributario.FillWeight = 20.61892!
        Me.PTributario.HeaderText = "PTributario"
        Me.PTributario.Name = "PTributario"
        Me.PTributario.ReadOnly = True
        '
        'RucADQ
        '
        Me.RucADQ.DataPropertyName = "RucADQ"
        Me.RucADQ.FillWeight = 20.82838!
        Me.RucADQ.HeaderText = "RucADQ"
        Me.RucADQ.Name = "RucADQ"
        Me.RucADQ.ReadOnly = True
        '
        'RucProve
        '
        Me.RucProve.DataPropertyName = "RucADQ"
        Me.RucProve.FillWeight = 20.93307!
        Me.RucProve.HeaderText = "RucProve"
        Me.RucProve.Name = "RucProve"
        Me.RucProve.ReadOnly = True
        '
        'cbCaja
        '
        Me.cbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCaja.Items.AddRange(New Object() {"VALES", "VOUCHER (DEPÓSITO)", "OTROS"})
        Me.cbCaja.Location = New System.Drawing.Point(134, 64)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(251, 21)
        Me.cbCaja.TabIndex = 18
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(22, 66)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(112, 18)
        Me.label8.TabIndex = 17
        Me.label8.Text = "Caja a Abonar : "
        Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbNumPlanilla
        '
        Me.lbNumPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbNumPlanilla.Location = New System.Drawing.Point(138, 16)
        Me.lbNumPlanilla.Name = "lbNumPlanilla"
        Me.lbNumPlanilla.Size = New System.Drawing.Size(114, 18)
        Me.lbNumPlanilla.TabIndex = 16
        Me.lbNumPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(18, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Num. Planilla :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(134, 130)
        Me.txtMonto.MaxLength = 12
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(106, 20)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(22, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Monto :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(10, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(387, 3)
        Me.Label6.TabIndex = 11
        '
        'lblMontoCompensar
        '
        Me.lblMontoCompensar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMontoCompensar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoCompensar.Location = New System.Drawing.Point(138, 36)
        Me.lblMontoCompensar.Name = "lblMontoCompensar"
        Me.lblMontoCompensar.Size = New System.Drawing.Size(114, 20)
        Me.lblMontoCompensar.TabIndex = 10
        Me.lblMontoCompensar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(18, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Monto a Compensar :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuitar
        '
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Location = New System.Drawing.Point(307, 124)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(78, 26)
        Me.btnQuitar.TabIndex = 3
        Me.btnQuitar.Text = "Quitar"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(134, 108)
        Me.txtNumero.MaxLength = 20
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(134, 20)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Número y/o Serie :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(22, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(387, 3)
        Me.Label2.TabIndex = 2
        '
        'cbTipoComp
        '
        Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoComp.Location = New System.Drawing.Point(134, 86)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Size = New System.Drawing.Size(251, 21)
        Me.cbTipoComp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Comprobante :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMontoCompensado
        '
        Me.lblMontoCompensado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMontoCompensado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoCompensado.Location = New System.Drawing.Point(191, 551)
        Me.lblMontoCompensado.Name = "lblMontoCompensado"
        Me.lblMontoCompensado.Size = New System.Drawing.Size(151, 23)
        Me.lblMontoCompensado.TabIndex = 13
        Me.lblMontoCompensado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(44, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Monto Compensado :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(60, 585)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 32)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "&Aceptar"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(257, 585)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 32)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "&Cancelar"
        '
        'FrmCompensar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(641, 716)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblMontoCompensado)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCompensar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compensacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgCompensacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "Fields"
    Public ParamFechaPlaCobro As Date
    Public ParamCodVendedor As String
    Public ParamTipoDoc As String
    Public ParamNumDoc As String
    Public ParamNumPlanillA As String
    Public TempTablaPlanillaCobros As DataTable
    Public TablaTemp As New DataTable
    Public DEVOLVER As Boolean
    'Private obj As New ClsInterface
    Public TbRecibeTABLA_DESPACHO As DataTable
    Public TIPOINV As Boolean



#End Region


    Private Sub FrmCompensar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Conecta("SELECT CODCAJA, DESC1CAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa & "'", "DATC")
            Me.cbCaja.ValueMember = "CODCAJA"
            Me.cbCaja.DisplayMember = "DESC1CAJA"
            Me.cbCaja.DataSource = ds.Tables("DATC")
            CAyuda.CargarDataCombo(cbTipoComp, "ListarCOMPROBANTESxProc '" & codempresa & "','2'", "CODTIPODOC", "DSTIPODOC")

            CAyuda.CargarDataCombo(cbCuentaContable, "NSP_Select_Listado_CATEGORIA_CTACONTABLE  '" & codempresa & "'", "Código", "Descripción")

            TablaTemp = New DataTable

            TablaTemp.Columns.Add("CODCAJA")
            TablaTemp.Columns.Add("DESCAJA")
            TablaTemp.Columns.Add("TIPO")
            TablaTemp.Columns.Add("NUMERO")
            TablaTemp.Columns.Add("MONTO")
            TablaTemp.Columns.Add("CUENTAC")
            TablaTemp.Columns.Add("TIPOC")
            TablaTemp.Columns.Add("FECHA")
            TablaTemp.Columns.Add("BServi")
            TablaTemp.Columns.Add("PTributario")
            TablaTemp.Columns.Add("RucADQ")
            TablaTemp.Columns.Add("RucProve")

            'TablaEstilo.MappingName = TablaTemp.TableName
            'TablaEstilo.GridColumnStyles(0).MappingName = "TIPO"
            'TablaEstilo.GridColumnStyles(1).MappingName = "NUMERO"
            'TablaEstilo.GridColumnStyles(2).MappingName = "MONTO"
            'TablaEstilo.GridColumnStyles(3).MappingName = "CODCAJA"
            'TablaEstilo.GridColumnStyles(4).MappingName = "DESCAJA"
            'dgCompensacion.TableStyles.Add(TablaEstilo)


            dgCompensacion.DataSource = TablaTemp
            Me.lblMontoCompensado.Text = 0.0
            Me.lblMontoCompensado.ForeColor = Color.Red







        Catch ex As Exception

        End Try


        txtBienServicio.Enabled = False
        txtTributario.Enabled = False
        txtRucAdq.Enabled = False
        txtRucProv.Enabled = False


    End Sub

    Private Sub ActionAgregar()

        If Me.txtNumero.Text.Trim.Length = 0 Or Me.txtMonto.Text.Trim.Length = 0 Then
            MsgBox("Ingrese los datos correctamente para poder añadir.")
            Exit Sub
        End If

        If TmpListarDatos("SELECT NROCOMP FROM CAJAMOVI WHERE NROCOMP='" & txtNumero.Text.Trim & "' AND CODEMPRESA='" & codempresa & "' ").Rows.Count > 0 Then
            Dim TB_MAXITEM As DataTable

            TB_MAXITEM = TmpListarDatos("SP_NRO_PLAN '" & txtNumero.Text.Trim & "','" & codempresa & "'")


            If TB_MAXITEM.Rows.Count > 0 Then
                MsgBox("EL CODIGO YA EXISTE EN LOS REGISTROS NRO PLANILLA: " & TB_MAXITEM.Rows(0)(0).ToString & " TIPO PLANILLA: " & TB_MAXITEM.Rows(0)(1).ToString, MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

        End If

        For ContA As Integer = 0 To TablaTemp.Rows.Count - 1
            If TablaTemp.Rows(ContA)(0).ToString.Trim = Me.cbTipoComp.Text And TablaTemp.Rows(ContA)(1).ToString.Trim = txtNumero.Text.Trim Then
                MsgBox("YA SE HA REGISTRADO ESTE COMPROBANTE, VERIFIQUE EL NÚMERO O TIPO DE COMPROBANTE")
                Exit Sub
            End If
        Next



        Dim Fila As DataRow = TablaTemp.NewRow
        Fila("TIPO") = cbTipoComp.Text
        Fila("NUMERO") = txtNumero.Text.Trim
        Fila("MONTO") = txtMonto.Text.Trim
        Fila("CODCAJA") = Me.cbCaja.SelectedValue.ToString
        Fila("DESCAJA") = Me.cbCaja.Text
        Fila("CUENTAC") = Me.cbSubCuentaContable.SelectedValue.ToString
        Fila("TIPOC") = Me.cbTipoComp.SelectedValue.ToString

        Fila("FECHA") = Format(Me.dtpFecha.Value, "dd/MM/yyyy")


        Fila("BServi") = txtBienServicio.Text
        Fila("PTributario") = txtTributario.Text
        Fila("RucADQ") = txtRucAdq.Text
        Fila("RucProve") = txtRucProv.Text

        TablaTemp.Rows.Add(Fila)
        lblMontoCompensado.Text = CalcularCantidadCompensada()
        dgCompensacion.DataSource = TablaTemp
        Me.txtNumero.Text = String.Empty : Me.txtMonto.Text = String.Empty : txtNumero.Focus()
        Try
            If CDbl(lblMontoCompensado.Text) <> CDbl(lblMontoCompensar.Text) Then
                lblMontoCompensado.ForeColor = Color.Red
            Else
                lblMontoCompensado.ForeColor = Color.Green
            End If
        Catch ex As Exception
            lblMontoCompensado.ForeColor = Color.Red
        End Try

    End Sub

    Private Function CalcularCantidadCompensada() As Double
        For ContA As Integer = 0 To TablaTemp.Rows.Count - 1
            CalcularCantidadCompensada += CDbl(TablaTemp.Rows(ContA)("MONTO"))
        Next
    End Function

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        For ContA As Integer = 0 To TablaTemp.Rows.Count - 1


            If TablaTemp.Rows(ContA)(0).ToString.Trim = Me.dgCompensacion.CurrentRow.Cells.Item(0).Value And TablaTemp.Rows(ContA)(3).ToString.Trim = Me.dgCompensacion.CurrentRow.Cells.Item(3).Value Then
                TablaTemp.Rows.RemoveAt(ContA)
                lblMontoCompensado.Text = CalcularCantidadCompensada()
                dgCompensacion.DataSource = TablaTemp
                Exit Sub
            End If
        Next
        Try
            If CDbl(lblMontoCompensado.Text) <> CDbl(lblMontoCompensar.Text) Then
                lblMontoCompensado.ForeColor = Color.Red
            Else
                lblMontoCompensado.ForeColor = Color.Green
            End If
        Catch ex As Exception
            lblMontoCompensado.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If CDbl(lblMontoCompensar.Text.Trim) = CDbl(lblMontoCompensado.Text.Trim) Then

            DEVOLVER = True
            Me.Close()

        End If
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ActionAgregar()
        End If
    End Sub
#Region "RESTRICCIONES-KEYPRESS"

    Private Sub CajaTexto_SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub ActionTab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtMonto.Focus()
        End If
    End Sub
    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

#End Region


    Private Sub txtMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.TextChanged

    End Sub

    Private Sub cbCuentaContable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCuentaContable.SelectedIndexChanged


        CAyuda.CargarDataCombo(cbSubCuentaContable, "NSP_Select_Listado_SUBCTACONTABLE  '" & codempresa & "','" & cbCuentaContable.SelectedValue.ToString & "'", "Código", "Descripción")


    End Sub

    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged





    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            txtBienServicio.Enabled = True
            txtTributario.Enabled = True
            txtRucAdq.Enabled = True
            txtRucProv.Enabled = True

        End If


        If CheckBox1.Checked = False Then
            txtBienServicio.Enabled = False
            txtTributario.Enabled = False
            txtRucAdq.Enabled = False
            txtRucProv.Enabled = False

        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cbCaja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCaja.SelectedIndexChanged

    End Sub

    Private Sub cbTipoComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoComp.SelectedIndexChanged

    End Sub

    Private Sub cbSubCuentaContable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSubCuentaContable.SelectedIndexChanged

    End Sub
End Class
