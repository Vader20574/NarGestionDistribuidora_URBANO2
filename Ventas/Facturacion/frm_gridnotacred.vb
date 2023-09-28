Public Class frm_gridnotacred
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    'Friend WithEvents Ds_detimportacion1 As mantenimiento.ds_detimportacion
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        'Me.Ds_detimportacion1 = New mantenimiento.ds_detimportacion
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Ds_detimportacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        'Me.DataGrid1.DataSource = Me.Ds_detimportacion1.importaciones
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(13, 102)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(585, 280)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Ds_detimportacion1
        '
        'Me.Ds_detimportacion1.DataSetName = "ds_detimportacion"
        'Me.Ds_detimportacion1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "importaciones"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CDoc"
        Me.DataGridTextBoxColumn1.MappingName = "codigo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nro Doc"
        Me.DataGridTextBoxColumn2.MappingName = "descripcion"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 160
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Nro Nota Cred"
        Me.DataGridTextBoxColumn3.MappingName = "marca"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 160
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn4.MappingName = "fvenc"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 90
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Mon"
        Me.DataGridTextBoxColumn5.MappingName = "mon"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Cambio"
        Me.DataGridTextBoxColumn6.MappingName = "cantidad"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(326, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro por Fechas"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(160, 46)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker2.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(160, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Al :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Del :"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(24, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Por Rangos"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 80)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones de Filtro"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 21)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 21)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nro Nota Cred :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nro Documento :"
        '
        'frm_gridnotacred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(610, 391)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(616, 416)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(616, 416)
        Me.Name = "frm_gridnotacred"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Notas de Crédito"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ds_detimportacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vie As New frm_guiaing_otros

    Private Sub frm_gridnotacred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Sub llena()
        Try
            'Me.Ds_detimportacion1.Clear()
            If Me.RadioButton1.Checked = True Then
                conecta("nsp_select_nta_credito '" & CodEmpresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "MM/dd/yy") & "','" & Me.TextBox1.Text.Trim & "','" & Me.TextBox2.Text.Trim & "',0,'" & vie.ComboBox2.SelectedValue.ToString & "'", "llena")
            Else
                conecta("nsp_select_nta_credito '" & CodEmpresa & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "MM/dd/yy") & "','" & Me.TextBox1.Text.Trim & "','" & Me.TextBox2.Text.Trim & "',1,'" & vie.ComboBox2.SelectedValue.ToString & "'", "llena")
            End If

            'oda.Fill(Me.Ds_detimportacion1.importaciones)
            Me.DataGrid1.Refresh()

        Catch x As Exception
        End Try
    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, DateTimePicker1.KeyPress, DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Try
            vie.ctipodoc.SelectedValue = DataGrid1.Item(DataGrid1.CurrentRowIndex, 0)

            'If Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 1)).Length > 7 Then
            '    vie.tdoc1.Text = Strings.Right("000" + CType(Strings.Left(Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2)), Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2)).Length - 7), String), 3)
            'End If

            vie.TREF.Text = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2))
            vie.ctipoprecio.SelectedValue = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 4))
            vie.txtcambio.Text = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 5))

            'Dim i, a1, a2, a3 As Double

            TmpInsertDatos("NSP_SELECT_NTACRED '" & CodEmpresa & "','" & Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2)) & "','" & vie.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & vie.ComboBox1.SelectedValue.ToString & "'")
            vie.correl = Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2))
            vie.cargagrilla()

            'If vie.bomedidaing = True And vie.boumedidaing = False Then
            '    'vie.Ds_diferencia_de_reportes1.Clear()
            '    TmpInsertDatos("NSP_SELECT_NTACRED '" & CodEmpresa & "','" & Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 1)) & "','" & vie.calmacen.SelectedValue.ToString & "','" & CodUsuario & "','" & vie.ComboBox1.SelectedValue.ToString & "'")
            '    'oda.Fill(vie.Ds_diferencia_de_reportes1.Dsdifreporte)
            '    'vie.grid1.Refresh()

            '    'For i = 0 To vie.Ds_diferencia_de_reportes1.Dsdifreporte.Rows.Count - 1
            '    '    a1 += Val(vie.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(4))
            '    '    a2 += Val(vie.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(5))
            '    '    a3 += Val(vie.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(11))
            '    'Next
            '    'vie.totbruto.Text = a1.ToString("###0.00")
            '    'vie.tottara.Text = a2.ToString("###0.00")
            '    'vie.totneto.Text = Val(a1 - a2).ToString("###0.00")
            '    'vie.tottotal.Text = a3.ToString("###0.00")

            'ElseIf vie.bomedidaing = False And vie.boumedidaing = True Then
            '    vie.DsInventInicial1.Clear()
            '    conecta("NSP_SELECT_NTACRED '" & CodEmpresa & "','" & Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2)) & "',1", "LLENA")
            '    oda.Fill(vie.DsInventInicial1.ds_inventini)
            '    vie.grid1.Refresh()

            'ElseIf vie.bomedidaing = True And vie.boumedidaing = True Then
            '    vie.Ds_diferencia_de_reportes1.Clear()
            '    conecta("NSP_SELECT_NTACRED '" & CodEmpresa & "','" & Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2)) & "',0", "LLENA")
            '    oda.Fill(vie.Ds_diferencia_de_reportes1.Dsdifreporte)
            '    vie.grid1.Refresh()

            '    For i = 0 To vie.Ds_diferencia_de_reportes1.Dsdifreporte.Rows.Count - 1
            '        a1 += Val(vie.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(4))
            '        a2 += Val(vie.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(5))
            '        a3 += Val(vie.Ds_diferencia_de_reportes1.Dsdifreporte.Rows(i)(11))
            '    Next
            '    vie.totbruto.Text = a1.ToString("###0.00")
            '    vie.tottara.Text = a2.ToString("###0.00")
            '    vie.totneto.Text = Val(a1 - a2).ToString("###0.00")
            '    vie.tottotal.Text = a3.ToString("###0.00")

            'End If

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
