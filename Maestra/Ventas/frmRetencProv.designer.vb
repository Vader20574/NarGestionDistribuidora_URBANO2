<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetencProv
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtproveedor = New System.Windows.Forms.TextBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblruc = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbldireccion = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.txtserienum = New System.Windows.Forms.TextBox
        Me.panel2 = New System.Windows.Forms.GroupBox
        Me.dgvlista = New System.Windows.Forms.DataGridView
        Me.lblcodproveedor = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.GroupBox
        Me.txtimporte = New System.Windows.Forms.TextBox
        Me.txtmontop = New System.Windows.Forms.TextBox
        Me.cmbdocu = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpfechaemi = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcorrel = New System.Windows.Forms.TextBox
        Me.txtserie = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbltotal = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnguardar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblcambio = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.TIPODOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SERIEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CORRELATIVODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHAEMISIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MONTOPAGODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IMPORTERETENIDODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RetencProvDetEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.panel2.SuspendLayout()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RetencProvDetEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(554, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "INGRESO DE COMPROBANTE DE RETENCION DEL PROVEEDOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Proveedor :"
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(123, 72)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(233, 20)
        Me.txtproveedor.TabIndex = 4
        '
        'btnbuscar
        '
        Me.btnbuscar.Enabled = False
        Me.btnbuscar.Location = New System.Drawing.Point(362, 71)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(34, 23)
        Me.btnbuscar.TabIndex = 0
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ruc :"
        '
        'lblruc
        '
        Me.lblruc.BackColor = System.Drawing.Color.White
        Me.lblruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblruc.Location = New System.Drawing.Point(123, 93)
        Me.lblruc.Name = "lblruc"
        Me.lblruc.Size = New System.Drawing.Size(100, 20)
        Me.lblruc.TabIndex = 5
        Me.lblruc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Dirección :"
        '
        'lbldireccion
        '
        Me.lbldireccion.BackColor = System.Drawing.Color.White
        Me.lbldireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldireccion.Location = New System.Drawing.Point(123, 114)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(396, 20)
        Me.lbldireccion.TabIndex = 6
        Me.lbldireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Serie Numero :"
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(123, 135)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(100, 20)
        Me.dtpfecha.TabIndex = 1
        '
        'txtserienum
        '
        Me.txtserienum.Location = New System.Drawing.Point(123, 156)
        Me.txtserienum.Name = "txtserienum"
        Me.txtserienum.Size = New System.Drawing.Size(100, 20)
        Me.txtserienum.TabIndex = 2
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.dgvlista)
        Me.panel2.Enabled = False
        Me.panel2.Location = New System.Drawing.Point(12, 260)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(680, 185)
        Me.panel2.TabIndex = 5
        Me.panel2.TabStop = False
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AutoGenerateColumns = False
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPODOCDataGridViewTextBoxColumn, Me.SERIEDataGridViewTextBoxColumn, Me.CORRELATIVODataGridViewTextBoxColumn, Me.FECHAEMISIONDataGridViewTextBoxColumn, Me.MONTOPAGODataGridViewTextBoxColumn, Me.IMPORTERETENIDODataGridViewTextBoxColumn})
        Me.dgvlista.DataSource = Me.RetencProvDetEBindingSource
        Me.dgvlista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlista.Location = New System.Drawing.Point(3, 16)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.Size = New System.Drawing.Size(674, 166)
        Me.dgvlista.TabIndex = 0
        '
        'lblcodproveedor
        '
        Me.lblcodproveedor.BackColor = System.Drawing.Color.White
        Me.lblcodproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodproveedor.Location = New System.Drawing.Point(419, 72)
        Me.lblcodproveedor.Name = "lblcodproveedor"
        Me.lblcodproveedor.Size = New System.Drawing.Size(100, 20)
        Me.lblcodproveedor.TabIndex = 3
        Me.lblcodproveedor.Text = "0"
        Me.lblcodproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.txtimporte)
        Me.panel1.Controls.Add(Me.txtmontop)
        Me.panel1.Controls.Add(Me.cmbdocu)
        Me.panel1.Controls.Add(Me.Label9)
        Me.panel1.Controls.Add(Me.dtpfechaemi)
        Me.panel1.Controls.Add(Me.Label8)
        Me.panel1.Controls.Add(Me.Label12)
        Me.panel1.Controls.Add(Me.txtcorrel)
        Me.panel1.Controls.Add(Me.txtserie)
        Me.panel1.Controls.Add(Me.Label11)
        Me.panel1.Controls.Add(Me.Label10)
        Me.panel1.Controls.Add(Me.Label7)
        Me.panel1.Enabled = False
        Me.panel1.Location = New System.Drawing.Point(18, 181)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(674, 78)
        Me.panel1.TabIndex = 3
        Me.panel1.TabStop = False
        '
        'txtimporte
        '
        Me.txtimporte.Location = New System.Drawing.Point(545, 45)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(100, 20)
        Me.txtimporte.TabIndex = 8
        '
        'txtmontop
        '
        Me.txtmontop.Location = New System.Drawing.Point(314, 44)
        Me.txtmontop.Name = "txtmontop"
        Me.txtmontop.Size = New System.Drawing.Size(100, 20)
        Me.txtmontop.TabIndex = 6
        '
        'cmbdocu
        '
        Me.cmbdocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdocu.FormattingEnabled = True
        Me.cmbdocu.Location = New System.Drawing.Point(94, 16)
        Me.cmbdocu.Name = "cmbdocu"
        Me.cmbdocu.Size = New System.Drawing.Size(121, 21)
        Me.cmbdocu.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(474, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Correlativo :"
        '
        'dtpfechaemi
        '
        Me.dtpfechaemi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaemi.Location = New System.Drawing.Point(94, 45)
        Me.dtpfechaemi.Name = "dtpfechaemi"
        Me.dtpfechaemi.Size = New System.Drawing.Size(121, 20)
        Me.dtpfechaemi.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(271, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Serie :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(443, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Importe Retenido :"
        '
        'txtcorrel
        '
        Me.txtcorrel.Location = New System.Drawing.Point(545, 16)
        Me.txtcorrel.Name = "txtcorrel"
        Me.txtcorrel.Size = New System.Drawing.Size(100, 20)
        Me.txtcorrel.TabIndex = 7
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(314, 16)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(100, 20)
        Me.txtserie.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(222, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Monto de Pago :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Fecha Emisión :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipo Doc. :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(544, 458)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Total :"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.White
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(583, 454)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(100, 20)
        Me.lbltotal.TabIndex = 1
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnsalir)
        Me.GroupBox3.Controls.Add(Me.btncancelar)
        Me.GroupBox3.Controls.Add(Me.btnguardar)
        Me.GroupBox3.Controls.Add(Me.btnnuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(583, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(92, 130)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(5, 97)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 0
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Enabled = False
        Me.btncancelar.Location = New System.Drawing.Point(5, 71)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 0
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Location = New System.Drawing.Point(5, 45)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(5, 19)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 0
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(515, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "$"
        '
        'lblcambio
        '
        Me.lblcambio.AutoSize = True
        Me.lblcambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcambio.Location = New System.Drawing.Point(539, 156)
        Me.lblcambio.Name = "lblcambio"
        Me.lblcambio.Size = New System.Drawing.Size(32, 13)
        Me.lblcambio.TabIndex = 15
        Me.lblcambio.Text = "3.14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(485, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "T.C."
        '
        'TIPODOCDataGridViewTextBoxColumn
        '
        Me.TIPODOCDataGridViewTextBoxColumn.DataPropertyName = "TIPODOC"
        Me.TIPODOCDataGridViewTextBoxColumn.HeaderText = "Tipo Doc."
        Me.TIPODOCDataGridViewTextBoxColumn.Name = "TIPODOCDataGridViewTextBoxColumn"
        Me.TIPODOCDataGridViewTextBoxColumn.ReadOnly = True
        Me.TIPODOCDataGridViewTextBoxColumn.Width = 135
        '
        'SERIEDataGridViewTextBoxColumn
        '
        Me.SERIEDataGridViewTextBoxColumn.DataPropertyName = "SERIE"
        Me.SERIEDataGridViewTextBoxColumn.HeaderText = "Serie"
        Me.SERIEDataGridViewTextBoxColumn.Name = "SERIEDataGridViewTextBoxColumn"
        Me.SERIEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CORRELATIVODataGridViewTextBoxColumn
        '
        Me.CORRELATIVODataGridViewTextBoxColumn.DataPropertyName = "CORRELATIVO"
        Me.CORRELATIVODataGridViewTextBoxColumn.HeaderText = "Correlativo"
        Me.CORRELATIVODataGridViewTextBoxColumn.Name = "CORRELATIVODataGridViewTextBoxColumn"
        Me.CORRELATIVODataGridViewTextBoxColumn.ReadOnly = True
        Me.CORRELATIVODataGridViewTextBoxColumn.Width = 120
        '
        'FECHAEMISIONDataGridViewTextBoxColumn
        '
        Me.FECHAEMISIONDataGridViewTextBoxColumn.DataPropertyName = "FECHAEMISION"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.FECHAEMISIONDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FECHAEMISIONDataGridViewTextBoxColumn.HeaderText = "Fecha Em."
        Me.FECHAEMISIONDataGridViewTextBoxColumn.Name = "FECHAEMISIONDataGridViewTextBoxColumn"
        Me.FECHAEMISIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MONTOPAGODataGridViewTextBoxColumn
        '
        Me.MONTOPAGODataGridViewTextBoxColumn.DataPropertyName = "MONTOPAGO"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.MONTOPAGODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.MONTOPAGODataGridViewTextBoxColumn.HeaderText = "Mt. Pago"
        Me.MONTOPAGODataGridViewTextBoxColumn.Name = "MONTOPAGODataGridViewTextBoxColumn"
        Me.MONTOPAGODataGridViewTextBoxColumn.ReadOnly = True
        Me.MONTOPAGODataGridViewTextBoxColumn.Width = 80
        '
        'IMPORTERETENIDODataGridViewTextBoxColumn
        '
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.DataPropertyName = "IMPORTERETENIDO"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0.00"
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.HeaderText = "Imp. Ret."
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.Name = "IMPORTERETENIDODataGridViewTextBoxColumn"
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.ReadOnly = True
        Me.IMPORTERETENIDODataGridViewTextBoxColumn.Width = 80
        '
        'RetencProvDetEBindingSource
        '
        Me.RetencProvDetEBindingSource.DataSource = GetType(NarGestionDistribuidora.RetencProvDetE)
        '
        'frmRetencProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 485)
        Me.Controls.Add(Me.lblcambio)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.txtserienum)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblruc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblcodproveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRetencProv"
        Me.Text = "frmRetencProv"
        Me.panel2.ResumeLayout(False)
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.RetencProvDetEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblruc As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbldireccion As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtserienum As System.Windows.Forms.TextBox
    Friend WithEvents panel2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvlista As System.Windows.Forms.DataGridView
    Friend WithEvents lblcodproveedor As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbdocu As System.Windows.Forms.ComboBox
    Friend WithEvents dtpfechaemi As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcorrel As System.Windows.Forms.TextBox
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents RetencProvDetEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPODOCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERIEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CORRELATIVODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAEMISIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MONTOPAGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IMPORTERETENIDODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents txtmontop As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblcambio As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
