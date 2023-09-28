Public Class FrmCompensarPago
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
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgCompensacion As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbTipoComp As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbCaja = New System.Windows.Forms.ComboBox
        Me.label8 = New System.Windows.Forms.Label
        Me.lbNumPlanilla = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblMontoCompensado = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblMontoCompensar = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgCompensacion = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbTipoComp = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCompensacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(40, 372)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 32)
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "&Aceptar"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(224, 372)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(122, 32)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "&Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbCaja)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.lbNumPlanilla)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblMontoCompensado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblMontoCompensar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgCompensacion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbTipoComp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 356)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'cbCaja
        '
        Me.cbCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCaja.Items.AddRange(New Object() {"VALES", "VOUCHER (DEPÓSITO)", "OTROS"})
        Me.cbCaja.Location = New System.Drawing.Point(134, 64)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(224, 21)
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
        Me.txtMonto.Text = ""
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
        'lblMontoCompensado
        '
        Me.lblMontoCompensado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMontoCompensado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoCompensado.Location = New System.Drawing.Point(160, 320)
        Me.lblMontoCompensado.Name = "lblMontoCompensado"
        Me.lblMontoCompensado.Size = New System.Drawing.Size(152, 22)
        Me.lblMontoCompensado.TabIndex = 13
        Me.lblMontoCompensado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Monto Compensado :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(10, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(354, 3)
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
        Me.btnQuitar.Location = New System.Drawing.Point(276, 124)
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
        Me.txtNumero.Text = ""
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
        'dgCompensacion
        '
        Me.dgCompensacion.DataMember = ""
        Me.dgCompensacion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCompensacion.Location = New System.Drawing.Point(8, 158)
        Me.dgCompensacion.Name = "dgCompensacion"
        Me.dgCompensacion.ReadOnly = True
        Me.dgCompensacion.RowHeadersVisible = False
        Me.dgCompensacion.Size = New System.Drawing.Size(356, 160)
        Me.dgCompensacion.TabIndex = 3
        Me.dgCompensacion.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgCompensacion
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn1.MappingName = ""
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Número y/o serie"
        Me.DataGridTextBoxColumn2.MappingName = ""
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Monto"
        Me.DataGridTextBoxColumn3.MappingName = ""
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = ""
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = ""
        Me.DataGridTextBoxColumn5.Width = 150
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(8, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 3)
        Me.Label2.TabIndex = 2
        '
        'cbTipoComp
        '
        Me.cbTipoComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoComp.Location = New System.Drawing.Point(134, 86)
        Me.cbTipoComp.Name = "cbTipoComp"
        Me.cbTipoComp.Size = New System.Drawing.Size(224, 21)
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
        'FrmCompensarPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(394, 424)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCompensarPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compensacion de Pago"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgCompensacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "Fields"
    Public DEVOLVER As Boolean
    Public TIPOINV As Boolean
    Private TMP_COMPENSACION As New DataTable

#End Region

#Region "Funciones Form"

    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_COMPENSACION.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODCAJA"
            .HeaderText = "CODCAJA"
            .Width = 0
        End With

        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "DESC1CAJA"
            .HeaderText = "CAJA"
            .Width = 150
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "TIPOCOMPRBTE"
            .HeaderText = "CODTIPODOC"
            .Width = 0
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "DSTIPODOC"
            .HeaderText = "COMPROBANTE"
            .Width = 150
        End With
        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "NROSERIE"
            .HeaderText = "NRO/SERIE"
            .Width = 100
        End With
        Dim column6 As New DataGridTextBoxColumn
        With column6
            .MappingName = "MONTOCOMPBAS"
            .HeaderText = "MONTOCOMPBAS"
            .Format = "#######0.00"
            .Width = 75
            .Alignment = HorizontalAlignment.Right
        End With

        dgCompensacion.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5, column6})
        dgCompensacion.TableStyles.Add(TableStyle1)

    End Sub

    Private Sub MostrarPago()
        TMP_COMPENSACION = TmpListarDatos("ListarTMP_COMPENSACIONPAGOxProc  '" & codempresa & "','" & VCorrelInv & "'")
        dgCompensacion.DataSource = TMP_COMPENSACION
        lblMontoCompensado.Text = FormatoMonto(TmpListarDatos("SELECT ISNULL(SUM(MONTOCOMPBAS),0)  FROM  TMP_COMPENSACIONPAGO  WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & VCorrelInv & "'").Rows(0)(0), 2)

    End Sub

    Private Sub AgregarPago()
        CAyuda.Ejecutar("InsTMP_COMPENSACIONPAGOxProc", codempresa, lbNumPlanilla.Text.Trim, VCorrelInv, cbCaja.SelectedValue, cbTipoComp.SelectedValue, txtNumero.Text, CDbl(txtMonto.Text), FormatoMonto((CDbl(txtMonto.Text) / VCambioCompra), DECIRESU))
        MostrarPago()
        FormatoGrid()
    End Sub

    Private Sub QuitarPago()
        If TMP_COMPENSACION.Rows.Count > 0 Then
            CAyuda.Ejecutar("EliTMP_COMPENSACIONPAGOxProc", codempresa, VCorrelInv, dgCompensacion.Item(dgCompensacion.CurrentRowIndex, 0), dgCompensacion.Item(dgCompensacion.CurrentRowIndex, 0), dgCompensacion.Item(dgCompensacion.CurrentRowIndex, 0))
            MostrarPago()
            FormatoGrid()
        End If


    End Sub
#End Region

    Private Sub FrmCompensarPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TmpInsertDatos("DELETE  FROM  TMP_COMPENSACIONPAGO WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & VCorrelInv & "'")
            Conecta("SELECT CODCAJA, DESC1CAJA FROM CAJA WHERE CODEMPRESA ='" & codempresa & "'", "DATC")
            Me.cbCaja.ValueMember = "CODCAJA"
            Me.cbCaja.DisplayMember = "DESC1CAJA"
            Me.cbCaja.DataSource = ds.Tables("DATC")
            '  CAyuda.CargarDataCombo(cbTipoComp, "ListarCOMPROBANTESxProc  '" & codempresa & "','" & IIf(TIPOINV, 1, 0) & "'", "CODTIPODOC", "DSTIPODOC")

            CAyuda.CargarDataCombo(cbTipoComp, "ListarCOMPROBANTESxProc '" & codempresa & "','2'", "CODTIPODOC", "DSTIPODOC")


            Me.lblMontoCompensado.ForeColor = Color.Red
            MostrarPago()
            FormatoGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub ActionAgregar()
    '    If Me.txtNumero.Text.Trim.Length = 0 Or Me.txtMonto.Text.Trim.Length = 0 Then
    '        MsgBox("Ingrese los datos correctamente para poder añadir.")
    '        Exit Sub
    '    End If
    '    For ContA As Integer = 0 To TablaTemp.Rows.Count - 1
    '        If TablaTemp.Rows(ContA)(0).ToString.Trim = Me.cbTipoComp.Text And TablaTemp.Rows(ContA)(1).ToString.Trim = txtNumero.Text.Trim Then
    '            MsgBox("YA SE HA REGISTRADO ESTE COMPROBANTE, VERIFIQUE EL NÚMERO O TIPO DE COMPROBANTE")
    '            Exit Sub
    '        End If
    '    Next


    '    Dim Fila As DataRow = TablaTemp.NewRow
    '    Fila("TIPO") = cbTipoComp.Text
    '    Fila("NUMERO") = txtNumero.Text.Trim
    '    Fila("MONTO") = txtMonto.Text.Trim
    '    Fila("CODCAJA") = Me.cbCaja.SelectedValue.ToString
    '    TablaTemp.Rows.Add(Fila)
    '    lblMontoCompensado.Text = CalcularCantidadCompensada()
    '    dgCompensacion.DataSource = TablaTemp
    '    Me.txtNumero.Text = String.Empty : Me.txtMonto.Text = String.Empty : txtNumero.Focus()
    '    Try
    '        If CDbl(lblMontoCompensado.Text) <> CDbl(lblMontoCompensar.Text) Then
    '            lblMontoCompensado.ForeColor = Color.Red
    '        Else
    '            lblMontoCompensado.ForeColor = Color.Green
    '        End If
    '    Catch ex As Exception
    '        lblMontoCompensado.ForeColor = Color.Red
    '    End Try
    'End Sub

    'Private Function CalcularCantidadCompensada() As Double
    '    For ContA As Integer = 0 To TablaTemp.Rows.Count - 1
    '        CalcularCantidadCompensada += CDbl(TablaTemp.Rows(ContA)("MONTO"))
    '    Next
    'End Function

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        QuitarPago()

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


    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub txtMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            AgregarPago()

        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
