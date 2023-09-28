Public Class FrmTipoDescuentoFinanciero
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgDescuentos As System.Windows.Forms.DataGrid
    Friend WithEvents TablaEstiloDescuento As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MONTO_EFECTIVO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MONTO_CREDITO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtDsctoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtDsctoEfec As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FECHA_INI As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents FECHA_FIN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboSubCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents ckSUbcategoria As System.Windows.Forms.CheckBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboSubCategoria = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCategoria = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtDsctoCredito = New System.Windows.Forms.TextBox
        Me.txtDsctoEfec = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgDescuentos = New System.Windows.Forms.DataGrid
        Me.TablaEstiloDescuento = New System.Windows.Forms.DataGridTableStyle
        Me.CODIGO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridTextBoxColumn
        Me.MONTO_EFECTIVO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.MONTO_CREDITO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.FECHA_INI = New System.Windows.Forms.DataGridTextBoxColumn
        Me.FECHA_FIN = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.ckSUbcategoria = New System.Windows.Forms.CheckBox
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSubCategoria)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboCategoria)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboSubCategoria
        '
        Me.cboSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubCategoria.Location = New System.Drawing.Point(268, 38)
        Me.cboSubCategoria.Name = "cboSubCategoria"
        Me.cboSubCategoria.Size = New System.Drawing.Size(244, 21)
        Me.cboSubCategoria.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Categoría : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.Location = New System.Drawing.Point(16, 36)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(244, 21)
        Me.cboCategoria.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sub Categoría : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(4, 342)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(132, 28)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        '
        'txtDsctoCredito
        '
        Me.txtDsctoCredito.Location = New System.Drawing.Point(114, 38)
        Me.txtDsctoCredito.MaxLength = 10
        Me.txtDsctoCredito.Name = "txtDsctoCredito"
        Me.txtDsctoCredito.Size = New System.Drawing.Size(66, 20)
        Me.txtDsctoCredito.TabIndex = 5
        Me.txtDsctoCredito.Text = "0.00"
        Me.txtDsctoCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDsctoEfec
        '
        Me.txtDsctoEfec.Location = New System.Drawing.Point(114, 14)
        Me.txtDsctoEfec.MaxLength = 10
        Me.txtDsctoEfec.Name = "txtDsctoEfec"
        Me.txtDsctoEfec.Size = New System.Drawing.Size(66, 20)
        Me.txtDsctoEfec.TabIndex = 4
        Me.txtDsctoEfec.Text = "0.00"
        Me.txtDsctoEfec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Crédito Descto(%) : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Efectivo  Descto(%) : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgDescuentos
        '
        Me.dgDescuentos.DataMember = ""
        Me.dgDescuentos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDescuentos.Location = New System.Drawing.Point(4, 156)
        Me.dgDescuentos.Name = "dgDescuentos"
        Me.dgDescuentos.ReadOnly = True
        Me.dgDescuentos.RowHeadersVisible = False
        Me.dgDescuentos.Size = New System.Drawing.Size(520, 182)
        Me.dgDescuentos.TabIndex = 1
        Me.dgDescuentos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloDescuento})
        '
        'TablaEstiloDescuento
        '
        Me.TablaEstiloDescuento.DataGrid = Me.dgDescuentos
        Me.TablaEstiloDescuento.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODIGO, Me.DESCRIPCION, Me.MONTO_EFECTIVO, Me.MONTO_CREDITO, Me.FECHA_INI, Me.FECHA_FIN})
        Me.TablaEstiloDescuento.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloDescuento.MappingName = ""
        Me.TablaEstiloDescuento.ReadOnly = True
        Me.TablaEstiloDescuento.RowHeadersVisible = False
        '
        'CODIGO
        '
        Me.CODIGO.Format = ""
        Me.CODIGO.FormatInfo = Nothing
        Me.CODIGO.MappingName = ""
        Me.CODIGO.Width = 0
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Format = ""
        Me.DESCRIPCION.FormatInfo = Nothing
        Me.DESCRIPCION.HeaderText = "Descripción"
        Me.DESCRIPCION.MappingName = ""
        Me.DESCRIPCION.Width = 220
        '
        'MONTO_EFECTIVO
        '
        Me.MONTO_EFECTIVO.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.MONTO_EFECTIVO.Format = "#####0.00"
        Me.MONTO_EFECTIVO.FormatInfo = Nothing
        Me.MONTO_EFECTIVO.HeaderText = "Monto Efectivo"
        Me.MONTO_EFECTIVO.MappingName = ""
        Me.MONTO_EFECTIVO.Width = 75
        '
        'MONTO_CREDITO
        '
        Me.MONTO_CREDITO.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.MONTO_CREDITO.Format = "#####0.00"
        Me.MONTO_CREDITO.FormatInfo = Nothing
        Me.MONTO_CREDITO.HeaderText = "Monto Crèdito"
        Me.MONTO_CREDITO.MappingName = ""
        Me.MONTO_CREDITO.Width = 75
        '
        'FECHA_INI
        '
        Me.FECHA_INI.Format = "dd/MM/yyyy"
        Me.FECHA_INI.FormatInfo = Nothing
        Me.FECHA_INI.HeaderText = "Fecha Ini."
        Me.FECHA_INI.MappingName = ""
        Me.FECHA_INI.Width = 75
        '
        'FECHA_FIN
        '
        Me.FECHA_FIN.Format = "dd/MM/yyyy"
        Me.FECHA_FIN.FormatInfo = Nothing
        Me.FECHA_FIN.HeaderText = "Fecha Fin"
        Me.FECHA_FIN.MappingName = ""
        Me.FECHA_FIN.Width = 75
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnQuitar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.ckSUbcategoria)
        Me.GroupBox2.Controls.Add(Me.dtpFecha2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpFecha1)
        Me.GroupBox2.Controls.Add(Me.txtDsctoCredito)
        Me.GroupBox2.Controls.Add(Me.txtDsctoEfec)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 90)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btnQuitar
        '
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Location = New System.Drawing.Point(384, 38)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(130, 24)
        Me.btnQuitar.TabIndex = 13
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(384, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(130, 24)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar"
        '
        'ckSUbcategoria
        '
        Me.ckSUbcategoria.Location = New System.Drawing.Point(360, 68)
        Me.ckSUbcategoria.Name = "ckSUbcategoria"
        Me.ckSUbcategoria.Size = New System.Drawing.Size(150, 16)
        Me.ckSUbcategoria.TabIndex = 11
        Me.ckSUbcategoria.Text = "Todas las Sub-Categorias"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha2.Location = New System.Drawing.Point(286, 40)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(86, 20)
        Me.dtpFecha2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(258, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fin :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(246, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Inicio :"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha1.Location = New System.Drawing.Point(286, 16)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(86, 20)
        Me.dtpFecha1.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(392, 342)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(132, 28)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'FrmTipoDescuentoFinanciero
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 374)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgDescuentos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmTipoDescuentoFinanciero"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Descuento Financiero"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Private TablaGenrl As New DataTable
    'Private Obj As New ClsInterface
    Private VarCodigo As String = String.Empty
    Private NoEvalCod As Boolean = False

    Public ActEventCombo As Boolean


#End Region

    Private Sub FrmTipoDescuentoFinanciero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
        'ListarGrid()
        'Me.txtBusqueda.Focus()
        '6VarCodigo = Me.dgDescuentos(Me.dgDescuentos.CurrentRowIndex, 0).ToString.Trim
    End Sub

    Sub CargarDatos()
        CAyuda.CargarDataCombo(cboCategoria, "NSP_Select_Listado_Linea '" & codempresa & "'", "Código", "Descripción")
        'CargadataCombos(cboSubCategoria, "NSP_Select_Listado_SubLinea '" & codempresa & "'", "Código", "Descripción")
        'Call CargadataCombos(cboIntervalo, "NSP_LISTAR_INTERVALO   '" & codempresa & "'", "CODIGO", "DESCRIPCION")
        'linea
        ActEventCombo = True

    End Sub

    Private Sub ListarGrid()

        TablaGenrl = CAyuda.ListarDatos("NSP_LISTAR_TIPODSCTO_FINANCIERO", codempresa, IIf(IsNothing(cboCategoria.SelectedValue), "", cboCategoria.SelectedValue), IIf(IsNothing(cboSubCategoria.SelectedValue), "", cboSubCategoria.SelectedValue)).Tables(0)

        TablaEstiloDescuento.MappingName = TablaGenrl.TableName
        TablaEstiloDescuento.GridColumnStyles(0).MappingName = "CODSUBLINEA"
        TablaEstiloDescuento.GridColumnStyles(1).MappingName = "DESSUBLINEA"
        TablaEstiloDescuento.GridColumnStyles(2).MappingName = "MONTO_EFECTIVO"
        TablaEstiloDescuento.GridColumnStyles(3).MappingName = "MONTO_CREDITO"
        TablaEstiloDescuento.GridColumnStyles(4).MappingName = "FECHA_INI"
        TablaEstiloDescuento.GridColumnStyles(5).MappingName = "FECHA_FIN"
        Me.dgDescuentos.TableStyles.Add(TablaEstiloDescuento)
        Me.dgDescuentos.DataSource = TablaGenrl


    End Sub

    'Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    For cont2 As Integer = 0 To TablaGenrl.Rows.Count - 1
    '        If Me.txtBusqueda.Text.Trim = Mid(Me.dgDescuentos(cont2, 1).ToString.Trim, 1, Me.txtBusqueda.Text.Trim.Length) Then
    '            Me.dgDescuentos.CurrentRowIndex = cont2
    '        End If
    '    Next
    'End Sub

    Private Sub dgDescuentos_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDescuentos.CurrentCellChanged
        If NoEvalCod Then
            Exit Sub
        End If
        VarCodigo = Me.dgDescuentos(Me.dgDescuentos.CurrentRowIndex, 0).ToString.Trim
    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dgDescuentos.Enabled Then
            NoEvalCod = True
            For cont4 As Integer = 0 To TablaGenrl.Rows.Count - 1
                Me.dgDescuentos.UnSelect(cont4)
            Next
            If Me.dgDescuentos.CurrentRowIndex >= 0 Then
                TablaEstiloDescuento.SelectionBackColor = Color.Green
                TablaEstiloDescuento.BackColor = Color.Gray
                TablaEstiloDescuento.AlternatingBackColor = Color.Gray
                Me.dgDescuentos.Enabled = False
                For cont3 As Integer = 0 To TablaGenrl.Rows.Count - 1
                    If Me.dgDescuentos(cont3, 0).ToString.Trim = VarCodigo.Trim Then
                        Me.dgDescuentos.CurrentRowIndex = cont3
                        Me.dgDescuentos.Select(Me.dgDescuentos.CurrentRowIndex)
                        'Me.txtBusqueda.Text = Me.dgDescuentos(cont3, 1).ToString.Trim
                        Me.txtDsctoEfec.Text = dgDescuentos(cont3, 2)
                        Me.txtDsctoCredito.Text = dgDescuentos(cont3, 3)
                        Me.dtpFecha1.Value = IIf(dgDescuentos(cont3, 4) Is DBNull.Value, Now, dgDescuentos(cont3, 4))
                        Me.dtpFecha2.Value = IIf(dgDescuentos(cont3, 5) Is DBNull.Value, Now, dgDescuentos(cont3, 5))
                        Exit For
                    End If
                Next
                Me.txtDsctoEfec.Focus()
            End If
        Else
            TablaEstiloDescuento.ResetBackColor()
            TablaEstiloDescuento.ResetAlternatingBackColor()
            TablaEstiloDescuento.ResetSelectionBackColor()
            Me.dgDescuentos.Enabled = True
            NoEvalCod = True
            For cont4 As Integer = 0 To TablaGenrl.Rows.Count - 1
                Me.dgDescuentos.UnSelect(cont4)
            Next
            For cont2 As Integer = 0 To TablaGenrl.Rows.Count - 1
                If Me.dgDescuentos(cont2, 0).ToString.Trim = VarCodigo.Trim Then
                    Me.dgDescuentos.CurrentRowIndex = cont2
                    Me.dgDescuentos.Select(cont2)
                    Exit For
                End If
            Next
            'Me.txtBusqueda.Text = String.Empty : txtDsctoEfec.Text = String.Empty : txtDsctoCredito.Text = String.Empty
            'VarCodigo = String.Empty
            'Me.txtBusqueda.Focus()
        End If
        NoEvalCod = False
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'If ProcValidacion() Then
        For ContL As Integer = 0 To TablaGenrl.Rows.Count - 1
            CAyuda.Ejecutar("NSP_ELIMINA_DSCTO_FINANCIERO", codempresa, Me.cboCategoria.SelectedValue.ToString.Trim)
        Next
        For ContL As Integer = 0 To TablaGenrl.Rows.Count - 1
            CAyuda.Ejecutar("NSP_INSERT_DSCTO_FINANCIERO", codempresa, Me.cboCategoria.SelectedValue.ToString.Trim, TablaGenrl.Rows(ContL)("CODSUBLINEA"), TablaGenrl.Rows(ContL)("MONTO_EFECTIVO"), TablaGenrl.Rows(ContL)("MONTO_CREDITO"), TablaGenrl.Rows(ContL)("FECHA_INI"), TablaGenrl.Rows(ContL)("FECHA_FIN"))
        Next
        MsgBox("Los datos se han guardado correctamente ! ", MsgBoxStyle.Information)
        'Obj.gGrabarReg("NSP_UPDATE_TIPODSCTO_FINANCIERO", codempresa, VarCodigo.Trim, FACT_GFormatodeNumero(Me.txtDsctoEfec.Text.Trim), FACT_GFormatodeNumero(Me.txtDsctoCredito.Text.Trim), Me.dtpFecha1.Value.ToShortDateString, Me.dtpFecha2.Value.ToShortDateString)
        ListarGrid()
        'TablaEstiloDescuento.ResetBackColor()
        'TablaEstiloDescuento.ResetAlternatingBackColor()
        'TablaEstiloDescuento.ResetSelectionBackColor()
        'Me.dgDescuentos.Enabled = True
        'NoEvalCod = True
        'For cont2 As Integer = 0 To TablaGenrl.Rows.Count - 1
        'If Me.dgDescuentos(cont2, 0).ToString.Trim = VarCodigo.Trim Then
        'Me.dgDescuentos.CurrentRowIndex = cont2
        'Me.dgDescuentos.Select(cont2)
        'Exit For
        'End If
        'Next
        'NoEvalCod = False
        'VarCodigo = String.Empty
        'Me.txtDsctoEfec.Text = String.Empty : Me.txtDsctoCredito.Text = String.Empty
        'Me.dgDescuentos.Focus()
        'End If
        Me.txtDsctoCredito.Text = String.Empty
        Me.txtDsctoEfec.Text = String.Empty
        Me.dtpFecha1.Value = Now
        Me.dtpFecha2.Value = Now
    End Sub

    Private Function ProcValidacion() As Boolean
        Dim Obs1 As String = String.Empty, Obs2 As String = String.Empty
        If Me.txtDsctoEfec.Text.Trim.Length = 0 Then
            Obs1 = vbCrLf + "-  El Dscto. Efectivo no ha sido ingresado."
        End If
        If Me.txtDsctoCredito.Text.Trim.Length = 0 Then
            Obs2 = vbCrLf + "-  El Dscto. Crédito no ha sido ingresado."
        End If
        If Obs1 <> String.Empty Or Obs2 <> String.Empty Then
            Return False
        Else
            Return True
        End If
    End Function


#Region "RESTRICCIONES-KEYPRESS"

    Private Sub CajaTexto_SoloLetras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub CajaTexto_SoloMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDsctoEfec.KeyPress, txtDsctoCredito.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Then
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

    Private Sub Enter_Tab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDsctoEfec.KeyPress, txtDsctoCredito.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

#End Region

    Private Sub dgDescuentos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDescuentos.Click
        'For Contador As Integer = 0 To Me.TablaGenrl.Rows.Count - 1
        '    Me.dgDescuentos.UnSelect(Contador)
        'Next
        'For Contador As Integer = 0 To Me.TablaGenrl.Rows.Count - 1
        '    If dgDescuentos.CurrentRowIndex = contador Then
        '        Me.dgDescuentos.Select(Contador)
        '    End If
        'Next
    End Sub

    Private Sub dgDescuentos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgDescuentos.KeyPress
        'If Me.dgDescuentos.CurrentRowIndex <> Nothing Then
        '    If Asc(e.KeyChar) = 13 Then
        '        btnCargar_Click(sender, e)
        '    End If
        'End If
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoria.SelectedIndexChanged
        'Call CargadataCombos(cboSubCategoria, "NSP_Select_Listado_SubLinea '" & codempresa & "'", "Código", "Descripción")
        If ActEventCombo = True Then
            CAyuda.CargarDataCombo(cboSubCategoria, "NSP_Sele_SubLineaxlinea '" & cboCategoria.SelectedValue.ToString & "','" & codempresa & "'", "Codigo", "Descripcion")
            ListarGrid()
        End If

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Me.txtDsctoCredito.Text.Trim.Length = 0 Or Me.txtDsctoEfec.Text.Trim.Length = 0 Then
            Exit Sub
        End If
        If TablaGenrl.Rows.Count = 0 Then
            If ckSUbcategoria.Checked Then
                'Dim Rpta As String
                'Rpta = MsgBox("¿ Desea Reemplazar los datos existentes ?", MsgBoxStyle.YesNo).ToString
                'If Rpta.Equals("Yes") Then
                TablaGenrl.Rows.Clear()
                Conecta("SELECT CODSUBLINEA, DESSUBLINEA FROM SUBLINEA WHERE CODEMPRESA='" & codempresa.Trim & "'", "TAB_G")
                Dim TablaSubCategoria As New DataTable
                TablaSubCategoria = ds.Tables("TAB_G")
                For ContGY As Integer = 0 To TablaSubCategoria.Rows.Count - 1
                    Dim FilaSC As DataRow = TablaGenrl.NewRow
                    FilaSC("CODSUBLINEA") = TablaSubCategoria.Rows(ContGY)("CODSUBLINEA")
                    FilaSC("DESSUBLINEA") = TablaSubCategoria.Rows(ContGY)("DESSUBLINEA")
                    FilaSC("MONTO_EFECTIVO") = txtDsctoEfec.Text.Trim
                    FilaSC("MONTO_CREDITO") = txtDsctoCredito.Text.Trim
                    FilaSC("FECHA_INI") = Me.dtpFecha1.Value.ToShortDateString
                    FilaSC("FECHA_FIN") = Me.dtpFecha2.Value.ToShortDateString
                    TablaGenrl.Rows.Add(FilaSC)
                    TablaGenrl.AcceptChanges()
                Next
                'End If
            Else
                Dim FilaSC As DataRow = TablaGenrl.NewRow
                FilaSC("CODSUBLINEA") = Me.cboSubCategoria.SelectedValue.ToString.Trim
                FilaSC("DESSUBLINEA") = Me.cboSubCategoria.Text.ToString.Trim
                FilaSC("MONTO_EFECTIVO") = txtDsctoEfec.Text.Trim
                FilaSC("MONTO_CREDITO") = txtDsctoCredito.Text.Trim
                FilaSC("FECHA_INI") = Me.dtpFecha1.Value.ToShortDateString
                FilaSC("FECHA_FIN") = Me.dtpFecha2.Value.ToShortDateString
                TablaGenrl.Rows.Add(FilaSC)
                TablaGenrl.AcceptChanges()
                Me.dgDescuentos.DataSource = TablaGenrl
                Exit Sub
            End If
        Else
            For ContH As Integer = 0 To TablaGenrl.Rows.Count - 1
                If TablaGenrl.Rows(ContH)("CODSUBLINEA").ToString.Trim = Me.cboSubCategoria.SelectedValue.ToString Then
                    '' SI ENCUENTRA UNA SUB CATEGORIA YA AGREGADA
                    If ckSUbcategoria.Checked Then
                        'SI SE APLICA PARA TODAS LAS SUBCATEGORIAS DE LA CATEGORIA
                        Dim Rpta As String
                        Rpta = MsgBox("¿ Desea Reemplazar los datos existentes ?", MsgBoxStyle.YesNo).ToString
                        If Rpta.Equals("Yes") Then
                            TablaGenrl.Rows.Clear()
                            Conecta("SELECT CODSUBLINEA, DESSUBLINEA FROM SUBLINEA WHERE CODLINEA ='" & cboCategoria.SelectedValue.ToString.Trim & "'", "TAB_G")
                            Dim TablaSubCategoria As New DataTable
                            TablaSubCategoria = ds.Tables("TAB_G")
                            For ContGY As Integer = 0 To TablaSubCategoria.Rows.Count - 1
                                Dim FilaSC As DataRow = TablaGenrl.NewRow
                                FilaSC("CODSUBLINEA") = TablaSubCategoria.Rows(ContGY)("CODSUBLINEA")
                                FilaSC("DESSUBLINEA") = TablaSubCategoria.Rows(ContGY)("DESSUBLINEA")
                                FilaSC("MONTO_EFECTIVO") = txtDsctoEfec.Text.Trim
                                FilaSC("MONTO_CREDITO") = txtDsctoCredito.Text.Trim
                                FilaSC("FECHA_INI") = Me.dtpFecha1.Value.ToShortDateString
                                FilaSC("FECHA_FIN") = Me.dtpFecha2.Value.ToShortDateString
                                TablaGenrl.Rows.Add(FilaSC)
                                TablaGenrl.AcceptChanges()
                            Next
                            Exit For
                        Else
                            Exit For
                        End If
                    Else
                        Dim Rpta As String
                        Rpta = MsgBox("¿ Desea reemplazar los datos de esta categoria que ya existe ?", MsgBoxStyle.YesNo).ToString
                        If Rpta.Equals("Yes") Then
                            TablaGenrl.Rows(ContH)("MONTO_EFECTIVO") = txtDsctoEfec.Text.Trim
                            TablaGenrl.Rows(ContH)("MONTO_CREDITO") = txtDsctoCredito.Text.Trim
                            TablaGenrl.Rows(ContH)("FECHA_INI") = Me.dtpFecha1.Value.ToShortDateString
                            TablaGenrl.Rows(ContH)("FECHA_FIN") = Me.dtpFecha2.Value.ToShortDateString
                            TablaGenrl.AcceptChanges()
                            Exit For
                        End If
                    End If
                End If
                If ContH = TablaGenrl.Rows.Count - 1 Then
                    Dim FilaSC As DataRow = TablaGenrl.NewRow
                    FilaSC("CODSUBLINEA") = Me.cboSubCategoria.SelectedValue.ToString.Trim
                    FilaSC("DESSUBLINEA") = Me.cboSubCategoria.Text.ToString.Trim
                    FilaSC("MONTO_EFECTIVO") = txtDsctoEfec.Text.Trim
                    FilaSC("MONTO_CREDITO") = txtDsctoCredito.Text.Trim
                    FilaSC("FECHA_INI") = Me.dtpFecha1.Value.ToShortDateString
                    FilaSC("FECHA_FIN") = Me.dtpFecha2.Value.ToShortDateString
                    TablaGenrl.Rows.Add(FilaSC)
                    TablaGenrl.AcceptChanges()
                    Exit For
                End If
            Next
        End If

        Me.dgDescuentos.DataSource = TablaGenrl
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim VarCodigo As String
        Try
            VarCodigo = dgDescuentos(dgDescuentos.CurrentRowIndex, 0).ToString.Trim
        Catch ex As Exception
            Exit Sub
        End Try
        For ContR As Integer = 0 To TablaGenrl.Rows.Count - 1
            If VarCodigo.Trim = TablaGenrl.Rows(ContR)("CODSUBLINEA").ToString.Trim Then
                TablaGenrl.Rows.RemoveAt(ContR)
                TablaGenrl.AcceptChanges()
                Me.dgDescuentos.DataSource = TablaGenrl
                Exit For
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
