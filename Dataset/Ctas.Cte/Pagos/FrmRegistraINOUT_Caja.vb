Public Class FrmRegistraINOUT_Caja
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbSoles As System.Windows.Forms.RadioButton
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cbTipoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents lbSaldo As System.Windows.Forms.Label
    Friend WithEvents rbDolares As System.Windows.Forms.RadioButton
    Friend WithEvents lbSignoMoneda As System.Windows.Forms.Label
    Friend WithEvents cbCajaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents lbCajaDestino As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEjercicio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents BTNANULAR As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbSubCuentaContable As System.Windows.Forms.ComboBox
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents txtcodsubcuentaconta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TXTEcomprobante As System.Windows.Forms.TextBox
    Friend WithEvents TXTTcomprobante As System.Windows.Forms.TextBox
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TXTEcomprobante = New System.Windows.Forms.TextBox
        Me.TXTTcomprobante = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcodsubcuentaconta = New System.Windows.Forms.TextBox
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbSubCuentaContable = New System.Windows.Forms.ComboBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.BTNANULAR = New System.Windows.Forms.Button
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtEjercicio = New System.Windows.Forms.TextBox
        Me.cbCuentaContable = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTipoComp = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbCajaDestino = New System.Windows.Forms.ComboBox
        Me.lbCajaDestino = New System.Windows.Forms.Label
        Me.lbSignoMoneda = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbDolares = New System.Windows.Forms.RadioButton
        Me.rbSoles = New System.Windows.Forms.RadioButton
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbTipoMovimiento = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbSaldo = New System.Windows.Forms.Label
        Me.cbCaja = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TXTEcomprobante)
        Me.GroupBox1.Controls.Add(Me.TXTTcomprobante)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtcodsubcuentaconta)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbSubCuentaContable)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.BTNANULAR)
        Me.GroupBox1.Controls.Add(Me.cboPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtEjercicio)
        Me.GroupBox1.Controls.Add(Me.cbCuentaContable)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtpfecha)
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbTipoComp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbCajaDestino)
        Me.GroupBox1.Controls.Add(Me.lbCajaDestino)
        Me.GroupBox1.Controls.Add(Me.lbSignoMoneda)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbTipoMovimiento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbSaldo)
        Me.GroupBox1.Controls.Add(Me.cbCaja)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 408)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(462, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Ecomprobante"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(466, 225)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Tcomprobante"
        '
        'TXTEcomprobante
        '
        Me.TXTEcomprobante.Location = New System.Drawing.Point(541, 246)
        Me.TXTEcomprobante.Name = "TXTEcomprobante"
        Me.TXTEcomprobante.Size = New System.Drawing.Size(181, 20)
        Me.TXTEcomprobante.TabIndex = 38
        '
        'TXTTcomprobante
        '
        Me.TXTTcomprobante.Location = New System.Drawing.Point(541, 220)
        Me.TXTTcomprobante.Name = "TXTTcomprobante"
        Me.TXTTcomprobante.Size = New System.Drawing.Size(181, 20)
        Me.TXTTcomprobante.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(408, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Sub Cuenta: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 25)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Mostrar Saldo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(478, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 20)
        Me.TextBox1.TabIndex = 34
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(240, 328)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 32)
        Me.btnModificar.TabIndex = 33
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(408, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Cod sub ct : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcodsubcuentaconta
        '
        Me.txtcodsubcuentaconta.Enabled = False
        Me.txtcodsubcuentaconta.Location = New System.Drawing.Point(478, 169)
        Me.txtcodsubcuentaconta.Name = "txtcodsubcuentaconta"
        Me.txtcodsubcuentaconta.Size = New System.Drawing.Size(111, 20)
        Me.txtcodsubcuentaconta.TabIndex = 31
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Location = New System.Drawing.Point(23, 328)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(104, 32)
        Me.BTNNUEVO.TabIndex = 30
        Me.BTNNUEVO.Text = "Nuevo"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 35)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Sub Cuenta Contable : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSubCuentaContable
        '
        Me.cbSubCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbSubCuentaContable.Location = New System.Drawing.Point(114, 173)
        Me.cbSubCuentaContable.Name = "cbSubCuentaContable"
        Me.cbSubCuentaContable.Size = New System.Drawing.Size(288, 21)
        Me.cbSubCuentaContable.TabIndex = 28
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(23, 370)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 32)
        Me.btnCancelar.TabIndex = 27
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.Location = New System.Drawing.Point(663, 48)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(97, 44)
        Me.btnbuscar.TabIndex = 26
        Me.btnbuscar.Text = "Consulta"
        '
        'BTNANULAR
        '
        Me.BTNANULAR.Location = New System.Drawing.Point(354, 328)
        Me.BTNANULAR.Name = "BTNANULAR"
        Me.BTNANULAR.Size = New System.Drawing.Size(104, 32)
        Me.BTNANULAR.TabIndex = 25
        Me.BTNANULAR.Text = "Anular"
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.Location = New System.Drawing.Point(516, 104)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(136, 21)
        Me.cboPeriodo.TabIndex = 24
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(462, 106)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 13)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Periodo: "
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(18, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 18)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Cuenta Contable : "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEjercicio
        '
        Me.txtEjercicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEjercicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjercicio.Location = New System.Drawing.Point(414, 104)
        Me.txtEjercicio.MaxLength = 7
        Me.txtEjercicio.Name = "txtEjercicio"
        Me.txtEjercicio.Size = New System.Drawing.Size(40, 20)
        Me.txtEjercicio.TabIndex = 22
        Me.txtEjercicio.Text = "2010"
        Me.txtEjercicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbCuentaContable
        '
        Me.cbCuentaContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaContable.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbCuentaContable.Location = New System.Drawing.Point(114, 149)
        Me.cbCuentaContable.Name = "cbCuentaContable"
        Me.cbCuentaContable.Size = New System.Drawing.Size(290, 21)
        Me.cbCuentaContable.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(350, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ejercicio: "
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(24, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Observación : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpfecha
        '
        Me.dtpfecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(461, 77)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpfecha.Size = New System.Drawing.Size(82, 20)
        Me.dtpfecha.TabIndex = 20
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Location = New System.Drawing.Point(114, 244)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(290, 78)
        Me.txtObservacion.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(347, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Fecha Documento :"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Location = New System.Drawing.Point(114, 200)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(124, 20)
        Me.txtNumero.TabIndex = 4
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Número y/o Serie :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTipoComp
        '
        Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoComp.Location = New System.Drawing.Point(114, 126)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Size = New System.Drawing.Size(224, 21)
        Me.cbTipoComp.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tipo Comprobante :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCajaDestino
        '
        Me.cbCajaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCajaDestino.ItemHeight = 13
        Me.cbCajaDestino.Location = New System.Drawing.Point(114, 102)
        Me.cbCajaDestino.Name = "cbCajaDestino"
        Me.cbCajaDestino.Size = New System.Drawing.Size(224, 21)
        Me.cbCajaDestino.TabIndex = 2
        '
        'lbCajaDestino
        '
        Me.lbCajaDestino.Location = New System.Drawing.Point(12, 104)
        Me.lbCajaDestino.Name = "lbCajaDestino"
        Me.lbCajaDestino.Size = New System.Drawing.Size(100, 18)
        Me.lbCajaDestino.TabIndex = 13
        Me.lbCajaDestino.Text = "Caja Destino : "
        Me.lbCajaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSignoMoneda
        '
        Me.lbSignoMoneda.Location = New System.Drawing.Point(130, 224)
        Me.lbSignoMoneda.Name = "lbSignoMoneda"
        Me.lbSignoMoneda.Size = New System.Drawing.Size(26, 18)
        Me.lbSignoMoneda.TabIndex = 12
        Me.lbSignoMoneda.Text = "S/."
        Me.lbSignoMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(134, 370)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 32)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(134, 328)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 32)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(778, 32)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Ingresos / Salidas     | Caja"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbDolares)
        Me.GroupBox2.Controls.Add(Me.rbSoles)
        Me.GroupBox2.Location = New System.Drawing.Point(242, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 40)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Moneda"
        '
        'rbDolares
        '
        Me.rbDolares.Location = New System.Drawing.Point(94, 22)
        Me.rbDolares.Name = "rbDolares"
        Me.rbDolares.Size = New System.Drawing.Size(66, 14)
        Me.rbDolares.TabIndex = 1
        Me.rbDolares.Text = "Dolares"
        '
        'rbSoles
        '
        Me.rbSoles.Checked = True
        Me.rbSoles.Location = New System.Drawing.Point(24, 22)
        Me.rbSoles.Name = "rbSoles"
        Me.rbSoles.Size = New System.Drawing.Size(58, 14)
        Me.rbSoles.TabIndex = 0
        Me.rbSoles.TabStop = True
        Me.rbSoles.Text = "Soles"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(156, 222)
        Me.txtImporte.MaxLength = 10
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(82, 20)
        Me.txtImporte.TabIndex = 6
        Me.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(30, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Importe :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(18, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo Movimiento : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTipoMovimiento
        '
        Me.cbTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoMovimiento.Items.AddRange(New Object() {"INGRESO", "SALIDA", "TRASLADO"})
        Me.cbTipoMovimiento.Location = New System.Drawing.Point(114, 76)
        Me.cbTipoMovimiento.Name = "cbTipoMovimiento"
        Me.cbTipoMovimiento.Size = New System.Drawing.Size(224, 21)
        Me.cbTipoMovimiento.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(350, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Saldo :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSaldo
        '
        Me.lbSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSaldo.Location = New System.Drawing.Point(398, 51)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.Size = New System.Drawing.Size(104, 20)
        Me.lbSaldo.TabIndex = 2
        Me.lbSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCaja
        '
        Me.cbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCaja.ItemHeight = 13
        Me.cbCaja.Location = New System.Drawing.Point(114, 52)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(224, 21)
        Me.cbCaja.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(70, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmRegistraINOUT_Caja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(841, 420)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistraINOUT_Caja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Ingresos / Salidas  - Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private Obj As New ClsInterface
    Private TipoMovi As Integer '' 1 -> INGRESO , 2 -> SALIDA , 3 -> TRASLADO
    Public AObjBus As New ClsAyuda

    Dim FLAG As Integer

    Dim rand As Integer

    Private Sub FrmRegistraINOUT_Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Conecta("SELECT CODCAJA, DESC1CAJA, DESC2CAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "'", "DS1")
        'Me.cbCaja.ValueMember = "CODCAJA"
        'Me.cbCaja.DisplayMember = "DESC1CAJA"
        'Me.cbCaja.DataSource = ds.Tables("DS1")


        CAyuda.CargarDataCombo(cbCaja, "SelecCAJAXUSUARIO '" & codempresa & "','" & CodUsuario & "'", "Código", "Descripción")

        CAyuda.CargarDataCombo(cbTipoMovimiento, "SelecMOVIXUSUARIO '" & codempresa & "','" & CodUsuario & "'", "Código", "Descripción")

       

        CAyuda.CargarDataCombo(cbCuentaContable, "NSP_Select_Listado_CATEGORIA_CTACONTABLE  '" & codempresa & "'", "Código", "Descripción")


        'Conecta("SELECT CODCAJA, DESC1CAJA, DESC2CAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "'", "DS2")
        'Me.cbCajaDestino.ValueMember = "CODCAJA"
        'Me.cbCajaDestino.DisplayMember = "DESC1CAJA"
        'Me.cbCajaDestino.DataSource = ds.Tables("DS2")

        CAyuda.CargarDataCombo(cbCajaDestino, "SelecCAJAXUSUARIO '" & codempresa & "','" & CodUsuario & "'", "Código", "Descripción")


        Me.cbTipoMovimiento.SelectedIndex = 0
        'Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
        'Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")
        'Conecta("SELECT SALDOBASCAJA FROM CAJA WHERE CODCAJA='""' AND CODEMPRESA='" & CODEMPRESA.Trim & "'", "RR")

        'CAyuda.CargarDataCombo(cbTipoComp, "ListarCOMPROBANTESxProc '" & codempresa & "','2'", "CODTIPODOC", "DSTIPODOC")

        CAyuda.CargarDataCombo(cbTipoComp, "SelecTIPODOCXUSUARIO '" & codempresa & "','" & CodUsuario & "'", "Código", "Descripción")


        'CAyuda.CargarDataCombo(cbCuentaContable, "NSP_Select_Listado_CATEGORIA_CTACONTABLE  '" & codempresa & "'", "Código", "Descripción")

        CAyuda.CargarDataCombo(cbCuentaContable, "SelecCTACONTABLExUserId '" & codempresa & "','" & CodUsuario & "'", "Código", "Descripción")




        cboPeriodo.Items.Add("ENERO")
        cboPeriodo.Items.Add("FEBRERO")
        cboPeriodo.Items.Add("MARZO")
        cboPeriodo.Items.Add("ABRIL")
        cboPeriodo.Items.Add("MAYO")
        cboPeriodo.Items.Add("JUNIO")
        cboPeriodo.Items.Add("JULIO")
        cboPeriodo.Items.Add("AGOSTO")
        cboPeriodo.Items.Add("SEPTIEMBRE")
        cboPeriodo.Items.Add("OCTUBRE")
        cboPeriodo.Items.Add("NOVIEMBRE")
        cboPeriodo.Items.Add("DICIEMBRE")
        cboPeriodo.SelectedIndex = Date.Now.Month - 1


        'Call BOTONES(False, True, False, False, False)

        dtpfecha.Value = Format(vFechaActual, "dd/MM/yyyy")

        Call Bloqueatextbox(Me)


        Call BOTONES(True, False, False, False, True)


        ValorRan()


    End Sub

    Function ValorRan() As Integer
        Dim rd As New Random
        rand = rd.Next() * 0.5
        Return rand
    End Function


    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ANULAR As Boolean, ByVal BUSCAR As Boolean)

        BTNNUEVO.Enabled = NUEVO
        btnGuardar.Enabled = GUARDAR
        btnModificar.Enabled = MODIFICAR
        BTNANULAR.Enabled = ANULAR
        btnbuscar.Enabled = BUSCAR

    End Sub








    'Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
    '    BTNNUEVO.Enabled = NUEVO
    '    BTNGUARDAR.Enabled = GUARDAR
    '    BTNMODIFICAR.Enabled = MODIFICAR
    '    ' BTNELIMINAR.Enabled = ELIMINAR
    '    btnbuscar.Enabled = BUSCAR
    'End Sub



    Private Sub cbCaja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCaja.SelectedIndexChanged
        'Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
        'Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")



        'Dim VAR1 As String
        'Dim TB_BUSQCLIDEP As DataTable

        'TB_BUSQCLIDEP = TmpListarDatos("MENOR_FECHA_CAJAMOVI '" & codempresa & "'")
        'If TB_BUSQCLIDEP.Rows.Count > 0 Then
        '    VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
        'End If



        'CAyuda.Ejecutar("SP_INSER_TTMP_FLUJOCAJA2", VAR1, String.Format(Me.dtpfecha.Value.ToShortDateString, "dd/MM/yyyy"), Me.cbCaja.SelectedValue.ToString(), 4, rand, 0)

        'CAyuda.Ejecutar("SP_MODIFIC_SALDO_FLUJOCAJA", rand)




        'CAyuda.Ejecutar("INS_TMP_FLUJOCAJA_2", rand, String.Format(VAR1, "dd/MM/yyyy"), String.Format(Me.dtpfecha.Value.ToShortDateString, "dd/MM/yyyy"))


        'TB_BUSQCLIDEP = TmpListarDatos("SP_REPORTE_ULTIMSALDO '" & rand & "'")
        'If TB_BUSQCLIDEP.Rows.Count > 0 Then
        '    Me.lbSaldo.Text = TB_BUSQCLIDEP.Rows(0)("SALDO")

        'End If








    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub rbDolares_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDolares.CheckedChanged
        Me.lbSignoMoneda.Text = "US$"
    End Sub

    Private Sub rbSoles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSoles.CheckedChanged
        Me.lbSignoMoneda.Text = "S/."
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click




        If FLAG = 0 Then
            If TmpListarDatos("SELECT NROCOMP FROM CAJAMOVI WHERE NROCOMP='" & txtNumero.Text.Trim & "' AND CODEMPRESA='" & codempresa & "' ").Rows.Count > 0 Then
                MsgBox("EL CODIGO YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

        End If




        '************************************************************************************************

        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = dtpfecha.Value.Year
        MES = dtpfecha.Value.Month

        Select Case MES
            Case 1
                DESMES = "ENERO"
            Case 2
                DESMES = "FEBRERO"
            Case 3
                DESMES = "MARZO"
            Case 4
                DESMES = "ABRIL"
            Case 5
                DESMES = "MAYO"
            Case 6
                DESMES = "JUNIO"
            Case 7
                DESMES = "JULIO"
            Case 8
                DESMES = "AGOSTO"
            Case 9
                DESMES = "SETIEMBRE"
            Case 10
                DESMES = "OCTUBRE"
            Case 11
                DESMES = "NOVIEMBRE"
            Case 12
                DESMES = "DECIEMBRE"
        End Select

        Dim TB_VALIDAR_FINMES As DataTable

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If




        If txtEjercicio.Text.Trim.Length = 0 Then
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL EJERCICIO ESTA VACIO")
            txtEjercicio.Focus()
            Exit Sub
        End If



        '************************************************************************************************






        Dim VarCbDestino As String
        If Me.cbTipoMovimiento.SelectedValue = 3 Then
            VarCbDestino = Me.cbCajaDestino.SelectedValue.ToString
        Else
            VarCbDestino = ""
        End If
        If Me.txtImporte.Text.Trim.Length = 0 Then
            MsgBox("Es necesario que ingrese el importe de la transacción.", MsgBoxStyle.Information, "NARGEST | Caja")
            Exit Sub
        Else
            'If Me.cbTipoMovimiento.SelectedIndex = 1 And CDbl(Me.txtImporte.Text.Trim) > CDbl(Me.lbSaldo.Text.Trim) Then
            '    MsgBox("El importe no debe de exceder el saldo de esta caja.", MsgBoxStyle.Information, "NARGEST | Caja")
            '    Exit Sub
            'End If
        End If


        If FLAG = 0 Then


            If Me.cbTipoMovimiento.SelectedValue = 3 Then


                If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, Me.cbCaja.SelectedValue.ToString, Format(dtpfecha.Value, "dd/MM/yyyy"), 2, Me.cbTipoComp.SelectedValue, Me.txtNumero.Text.Trim, Me.txtImporte.Text.Trim, Me.cbCaja.SelectedValue.ToString, Me.txtObservacion.Text.Trim, CodUsuario.Trim, cbSubCuentaContable.SelectedValue, txtEjercicio.Text, cboPeriodo.Text, TXTTcomprobante.Text, TXTEcomprobante.Text, "", "", "", "") <> 0 Then
                    MsgBox("La transacción se ha guardado con éxito.", MsgBoxStyle.Information)
                    'Me.txtImporte.Text = String.Empty
                    'Me.txtObservacion.Text = String.Empty
                    'Me.txtNumero.Text = String.Empty
                    'Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
                    'Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")
                End If

                If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, Me.cbCajaDestino.SelectedValue.ToString, Format(dtpfecha.Value, "dd/MM/yyyy"), 1, Me.cbTipoComp.SelectedValue, Me.txtNumero.Text.Trim, Me.txtImporte.Text.Trim, Me.cbCajaDestino.SelectedValue.ToString, Me.txtObservacion.Text.Trim, CodUsuario.Trim, cbSubCuentaContable.SelectedValue, txtEjercicio.Text, cboPeriodo.Text, TXTTcomprobante.Text, TXTEcomprobante.Text) <> 0 Then
                    MsgBox("La transacción se ha guardado con éxito.", MsgBoxStyle.Information)
                    'Me.txtImporte.Text = String.Empty
                    'Me.txtObservacion.Text = String.Empty
                    'Me.txtNumero.Text = String.Empty
                    'Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
                    'Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")
                End If

            Else


                If CAyuda.Ejecutar("NSP_INSERT_MOVIMIEMTO_CAJA", codempresa, Me.cbCaja.SelectedValue.ToString, Format(dtpfecha.Value, "dd/MM/yyyy"), Me.cbTipoMovimiento.SelectedValue, Me.cbTipoComp.SelectedValue, Me.txtNumero.Text.Trim, Me.txtImporte.Text.Trim, Me.cbCajaDestino.SelectedValue.ToString, Me.txtObservacion.Text.Trim, CodUsuario.Trim, cbSubCuentaContable.SelectedValue, txtEjercicio.Text, cboPeriodo.Text, TXTTcomprobante.Text, TXTEcomprobante.Text, "", "", "", "") <> 0 Then
                    MsgBox("La transacción se ha guardado con éxito.", MsgBoxStyle.Information)
                    Me.txtImporte.Text = String.Empty
                    Me.txtObservacion.Text = String.Empty
                    Me.txtNumero.Text = String.Empty
                    Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
                    Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")
                End If

            End If




        End If

        If FLAG = 1 Then


            If CAyuda.Ejecutar("NSP_UPDATE_MOVIMIEMTO_CAJA", codempresa, Me.cbCaja.SelectedValue.ToString, Format(dtpfecha.Value, "dd/MM/yyyy"), Me.cbTipoMovimiento.SelectedValue, Me.cbTipoComp.SelectedValue, Me.txtNumero.Text.Trim, Me.txtImporte.Text.Trim, Me.cbCajaDestino.SelectedValue.ToString, Me.txtObservacion.Text.Trim, CodUsuario.Trim, cbSubCuentaContable.SelectedValue, txtEjercicio.Text, cboPeriodo.Text, TXTEcomprobante.Text, TXTEcomprobante.Text, "", "", "", "") <> 0 Then
                MsgBox("La transacción se ha guardado con éxito.", MsgBoxStyle.Information)
                'Me.txtImporte.Text = String.Empty
                'Me.txtObservacion.Text = String.Empty
                'Me.txtNumero.Text = String.Empty
                'Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
                'Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")
            End If

        End If

        Call Bloqueatextbox(Me)

        Call BOTONES(True, False, False, False, True)



        Me.txtImporte.Text = String.Empty
        Me.txtObservacion.Text = String.Empty
        Me.txtNumero.Text = String.Empty


        Me.TXTTcomprobante.Text = String.Empty
        Me.TXTEcomprobante.Text = String.Empty


    End Sub

    Private Sub cbTipoMovimiento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoMovimiento.SelectedIndexChanged
  


        If Me.cbTipoMovimiento.Text = "TRASLADO" Then
            Me.lbCajaDestino.Enabled = True
            Me.cbCajaDestino.Enabled = True
        Else
            Me.lbCajaDestino.Enabled = False
            Me.cbCajaDestino.Enabled = False
        End If




    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtObservacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservacion.KeyDown

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
    Private Sub ActionTab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
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

    Private Sub btnnotcred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        Dim FrmBus As New FrmBusqCajaMov
        FrmBus.ShowDialog()
        If FrmBus.DEVOLVER = False Then
            Exit Sub
        End If

        Call BOTONES(True, False, True, True, True)


        Dim ATblNotCred As DataTable
        Dim NRONTACRED As String = ""

        ATblNotCred = AObjBus.ListarDatos("ListarCAJAMOVIxProc_3", codempresa.ToString(), FrmBus.GridNtaCred.Item(FrmBus.GridNtaCred.CurrentRowIndex, 0), FrmBus.GridNtaCred.Item(FrmBus.GridNtaCred.CurrentRowIndex, 2)).Tables(0)

        If ATblNotCred.Rows.Count > 0 Then

            ''NRONTACRED = ATblNotCred.Rows(0)(1)

            cbCaja.SelectedValue = ATblNotCred.Rows(0)("CODCAJA")
            cbTipoMovimiento.SelectedValue = ATblNotCred.Rows(0)("TIPOMOV")
            cbCajaDestino.SelectedValue = ATblNotCred.Rows(0)("CODCAJASALIDA")
            cbTipoComp.SelectedValue = ATblNotCred.Rows(0)("TIPOCOMP")



            Dim TB_01 As DataTable
            TB_01 = TmpListarDatos("SP_CODSUBCTACONTABLE '" & codempresa & "','" & ATblNotCred.Rows(0)("CContable") & "'")

            If TB_01.Rows.Count > 0 Then
                cbCuentaContable.SelectedValue = TB_01.Rows(0)("CODLINEA")
            End If


            cbSubCuentaContable.SelectedValue = ATblNotCred.Rows(0)("CContable")
            txtNumero.Text = ATblNotCred.Rows(0)("NROCOMP")
            txtImporte.Text = ATblNotCred.Rows(0)("MONTO")
            txtObservacion.Text = ATblNotCred.Rows(0)("OBERVACION")
            '   lbSaldtxtImporte.Texto.Text = ATblNotCred.Rows(0)("EJERCICIO")
            dtpfecha.Value = Format(CDate(ATblNotCred.Rows(0)("FECHA")), "dd/MM/yyyy")

            TXTTcomprobante.Text = ATblNotCred.Rows(0)("TCOMPROBANTE")
            TXTEcomprobante.Text = ATblNotCred.Rows(0)("ECOMPROBANTE")

            txtEjercicio.Text = ATblNotCred.Rows(0)("ejercicio")
            cboPeriodo.Text = ATblNotCred.Rows(0)("periodo")

            'Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
            'Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")
            'Me.lbSaldo.Text = CDbl(Me.lbSaldo.Text) - CDbl(txtImporte.Text)


            'Format(CDate(ATblNotCred.Rows(0)("FECDOCUM")), "dd/MM/yyyy")

            'Me.TxtNtaCred2.Text = Strings.Right("0000000" + CType(NRONTACRED, String), 7)
            'Me.TxtNtaCred1.Text = Strings.Right("000" + Strings.Left(CType(NRONTACRED, String), Len(CType(NRONTACRED, String)) - 7), 3)

            'txtEjercicio.Text = ATblNotCred.Rows(0)("EJERCICIO")
            'cboPeriodo.SelectedValue = ATblNotCred.Rows(0)("PERIODO")
            'cmbreferncia.SelectedValue = ATblNotCred.Rows(0)("CODTIPODOC")
            'TxtNroRef.Text = ATblNotCred.Rows(0)("NROREFE")
            'TxtCodProvee.Text = ATblNotCred.Rows(0)("CODPROVEEDOR")


            'Txtruc.Text = ATblNotCred.Rows(0)("RUCPROVEEDOR")
            'TxtProveedor.Text = ATblNotCred.Rows(0)("DESPROVEEDOR")
            'TxtCodProvee.Text = ATblNotCred.Rows(0)("CODPROVEEDOR")
            'TxtDireccion.Text = ATblNotCred.Rows(0)("DIRPROVEEDOR")
            'TxtObs.Text = ATblNotCred.Rows(0)("OBS")
            'TxtSubTotal.Text = ATblNotCred.Rows(0)("SUBTOTBAS")
            'TxtIgv.Text = ATblNotCred.Rows(0)("IGVBAS")
            'TxtTotal.Text = ATblNotCred.Rows(0)("TOTBAS")


            'txtmoneda.Text = ATblNotCred.Rows(0)("CDMONEDA")
            'dtpfecha.Value = Format(CDate(ATblNotCred.Rows(0)("FECDOCUM")), "dd/MM/yyyy")
            'txtcambio.Text = ATblNotCred.Rows(0)("CAMBIO")


            'TxtMontoInicial.Text = "0.00"


            'If ATblNotCred.Rows(0)("ESTADO") = "A" Then
            '    BtnAnular.Enabled = False
            '    MessageBox.Show("¡ DOCUMENTO ANULADO................ !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Else
            '    If ATblNotCred.Rows(0)("ESTADO") = "G" Then
            '        BtnAnular.Enabled = False
            '        MessageBox.Show("¡ DOCUMENTO GENERADO........ !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Else
            '        'If AObjBus.ListarDatos("NSP_SELECT_BUSCA_NOTACREDITO_VENTAXCOBRAR", codempresa, txtnronotcred.Text, 1).Tables(0).Rows.Count = 0 Then
            '        '    BTNELIMINAR.Enabled = False
            '        '    MessageBox.Show("¡ DOCUMENTO GENERADO CANCELADO EN CUENTAS POR COBRAR !", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)

            '        'Else
            '        BtnAnular.Enabled = True
            '        'End If

            '    End If
            'End If



        End If





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNANULAR.Click



        Dim Proceso As String
        Proceso = "ANULINGRSALDIN"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If



        Dim VarCbDestino As String
        If Me.cbTipoMovimiento.SelectedIndex = 2 Then
            VarCbDestino = Me.cbCajaDestino.SelectedValue.ToString
        Else
            VarCbDestino = ""
        End If


        If Me.txtImporte.Text.Trim.Length = 0 Then
            MsgBox("Es necesario que ingrese el importe de la transacción.", MsgBoxStyle.Information, "NARGEST | Caja")
            Exit Sub
        Else
            If Me.cbTipoMovimiento.SelectedIndex = 1 And CDbl(Me.txtImporte.Text.Trim) > CDbl(Me.lbSaldo.Text.Trim) Then
                MsgBox("El importe no debe de exceder el saldo de esta caja.", MsgBoxStyle.Information, "NARGEST | Caja")
                Exit Sub
            End If
        End If


        If CAyuda.Ejecutar("NSP_ANULAR_MOVIMIEMTO_CAJA", codempresa, Me.cbCaja.SelectedValue.ToString, Me.cbCaja.SelectedValue.ToString, Me.cbTipoMovimiento.SelectedIndex + 1, Me.txtNumero.Text.Trim, txtImporte.Text) <> 0 Then
            MsgBox("Se anulo con éxito.", MsgBoxStyle.Information)
            Me.txtImporte.Text = String.Empty
            Me.txtObservacion.Text = String.Empty
            Me.txtNumero.Text = String.Empty
            Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
            Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")
        End If



        BOTONES(True, False, False, False, True)



    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        FLAG = 0
        Me.txtImporte.Text = String.Empty
        Me.txtObservacion.Text = String.Empty
        Me.txtNumero.Text = String.Empty



        'Call BOTONES(False, True, False, False, False)

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.txtImporte.Text = String.Empty
        Me.txtObservacion.Text = String.Empty
        Me.txtNumero.Text = String.Empty


        Me.TXTTcomprobante.Text = String.Empty
        Me.TXTEcomprobante.Text = String.Empty




        Call Bloqueatextbox(Me)

        Call BOTONES(True, False, False, False, True)


    End Sub

    Private Sub cbSubCuentaContable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSubCuentaContable.SelectedIndexChanged
        txtcodsubcuentaconta.Text = cbSubCuentaContable.SelectedValue.ToString
    End Sub

    Private Sub cbCuentaContable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCuentaContable.SelectedIndexChanged

        ''CAyuda.CargarDataCombo(cbSubCuentaContable, "NSP_Select_Listado_SUBCTACONTABLE  '" & codempresa & "','" & cbCuentaContable.SelectedValue.ToString & "'", "Código", "Descripción")

        CAyuda.CargarDataCombo(cbSubCuentaContable, "SelecSUBCTACONTABLEXUSUARIO '" & codempresa & "','" & CodUsuario & "','" & cbCuentaContable.SelectedValue.ToString & "'", "Código", "Descripción")




    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)

        Call BOTONES(False, True, False, False, False)

        FLAG = 0




    End Sub

    Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
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

    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub txtObservacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacion.TextChanged

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim VAR1 As String = ""
        Dim TB_BUSQCLIDEP As DataTable

        TB_BUSQCLIDEP = TmpListarDatos("MENOR_FECHA_CAJAMOVI '" & codempresa & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then
            VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
        End If



        CAyuda.Ejecutar("SP_INSER_TTMP_FLUJOCAJA", VAR1, String.Format(Me.dtpfecha.Value.ToShortDateString, "dd/MM/yyyy"), Me.cbCaja.SelectedValue.ToString(), Me.cbTipoMovimiento.SelectedIndex + 1, rand, 0)

        CAyuda.Ejecutar("SP_MODIFIC_SALDO_FLUJOCAJA", rand)




        CAyuda.Ejecutar("INS_TMP_FLUJOCAJA_2", rand, String.Format(VAR1, "dd/MM/yyyy"), String.Format(Me.dtpfecha.Value.ToShortDateString, "dd/MM/yyyy"))


        TB_BUSQCLIDEP = TmpListarDatos("SP_REPORTE_ULTIMSALDO '" & rand & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then
            Me.lbSaldo.Text = TB_BUSQCLIDEP.Rows(0)("SALDO")

        End If



    End Sub



    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click



        '************************************************************************************************

        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = dtpfecha.Value.Year
        MES = dtpfecha.Value.Month

        Select Case MES
            Case 1
                DESMES = "ENERO"
            Case 2
                DESMES = "FEBRERO"
            Case 3
                DESMES = "MARZO"
            Case 4
                DESMES = "ABRIL"
            Case 5
                DESMES = "MAYO"
            Case 6
                DESMES = "JUNIO"
            Case 7
                DESMES = "JULIO"
            Case 8
                DESMES = "AGOSTO"
            Case 9
                DESMES = "SETIEMBRE"
            Case 10
                DESMES = "OCTUBRE"
            Case 11
                DESMES = "NOVIEMBRE"
            Case 12
                DESMES = "DECIEMBRE"
        End Select

        Dim TB_VALIDAR_FINMES As DataTable

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If
        '************************************************************************************************





        Call desbloqueatextbox(Me)

        FLAG = 1
        Call BOTONES(False, True, False, False, True)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress


        If Asc(e.KeyChar) = 13 Then
            Dim TB_BUSQCLIDEP As DataTable

            TB_BUSQCLIDEP = TmpListarDatos("NSP_Select_SUBCTACONTABLE '" & codempresa & "','" & TextBox1.Text & "'")
            If TB_BUSQCLIDEP.Rows.Count > 0 Then
                'VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()

                cbCuentaContable.SelectedValue = TB_BUSQCLIDEP.Rows(0)(0).ToString()
                cbSubCuentaContable.SelectedValue = TB_BUSQCLIDEP.Rows(0)(1).ToString()
            End If
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged




    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Conecta("SELECT DESC1CAJA, DESC2CAJA , SALDOBASCAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCAJA='" & Me.cbCaja.SelectedValue.ToString.Trim & "'", "TAB")
        'Me.lbSaldo.Text = ds.Tables("TAB").Rows(0)("SALDOBASCAJA")



        Dim VAR1 As String = ""
        Dim TB_BUSQCLIDEP As DataTable

        TB_BUSQCLIDEP = TmpListarDatos("MENOR_FECHA_CAJAMOVI '" & codempresa & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then
            VAR1 = TB_BUSQCLIDEP.Rows(0)(0).ToString()
        End If



        CAyuda.Ejecutar("SP_INSER_TTMP_FLUJOCAJA2", VAR1, String.Format(Me.dtpfecha.Value.ToShortDateString, "dd/MM/yyyy"), Me.cbCaja.SelectedValue.ToString(), 4, rand, 0)

        CAyuda.Ejecutar("SP_MODIFIC_SALDO_FLUJOCAJA", rand)




        CAyuda.Ejecutar("INS_TMP_FLUJOCAJA_2", rand, String.Format(VAR1, "dd/MM/yyyy"), String.Format(Me.dtpfecha.Value.ToShortDateString, "dd/MM/yyyy"))


        TB_BUSQCLIDEP = TmpListarDatos("SP_REPORTE_ULTIMSALDO '" & rand & "'")
        If TB_BUSQCLIDEP.Rows.Count > 0 Then
            Me.lbSaldo.Text = TB_BUSQCLIDEP.Rows(0)("SALDO")

        End If






    End Sub

    Private Sub cbTipoComp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoComp.SelectedIndexChanged

    End Sub
End Class
