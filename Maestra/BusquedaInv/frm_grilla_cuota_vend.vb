Public Class frm_grilla_cuota_vend
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
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    'Friend WithEvents Ds_detimportacion1 As mantenimiento.ds_detimportacion
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        'Me.Ds_detimportacion1 = New mantenimiento.ds_detimportacion
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Ds_detimportacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(188, 75)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(160, 16)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.Text = "Filtro por Fecha de Fin"
        '
        'RadioButton3
        '
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(28, 75)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(160, 16)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Filtro por Fecha de Inicio"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(380, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 72)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro por Fechas"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(144, 42)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker2.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(144, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Al :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Del :"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(24, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Por Rangos"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 56)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Filtro"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(192, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 21)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(56, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 21)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Artículo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "IdArti :"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        'Me.DataGrid1.DataSource = Me.Ds_detimportacion1.importaciones
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 99)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(632, 256)
        Me.DataGrid1.TabIndex = 10
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
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "importaciones"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Ident"
        Me.DataGridTextBoxColumn1.MappingName = "correl"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "IdVend"
        Me.DataGridTextBoxColumn2.MappingName = "codigo"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Vendedor"
        Me.DataGridTextBoxColumn3.MappingName = "descripcion"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 260
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "FInicio"
        Me.DataGridTextBoxColumn4.MappingName = "fvenc"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 90
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "FFin"
        Me.DataGridTextBoxColumn5.MappingName = "fproceso"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 90
        '
        'frm_grilla_cuota_vend
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(666, 367)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(672, 392)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(672, 392)
        Me.Name = "frm_grilla_cuota_vend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Cuotas por Vendedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Ds_detimportacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public vie As New cuota_vendedor
    Private Ds_detimportacion1 As New DataTable

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
        Else
            Me.DateTimePicker1.Enabled = True
            Me.DateTimePicker2.Enabled = True
        End If
    End Sub

    Private Sub frm_grilla_cuota_art_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Sub llena()
        Me.Ds_detimportacion1.Clear()
        If Me.RadioButton1.Checked = True Then
            Conecta("select c.ident as correl,c.idvend as codigo,a.dsvend as descripcion,c.finicio as fvenc,c.ffin as fproceso from cuota_vendedor c,vendedor a where c.idvend=a.codvend and c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "' and c.idvend like '" & Me.TextBox1.Text.Trim & "%' and a.dsvend like '" & Me.TextBox2.Text.Trim & "%'", "llena")
        Else
            If Me.RadioButton3.Checked = True Then
                Conecta("select c.ident as correl,c.idvend as codigo,a.dsvend as descripcion,c.finicio as fvenc,c.ffin as fproceso from cuota_vendedor c,vendedor a where c.idvend=a.codvend and c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "' and c.idvend like '" & Me.TextBox1.Text.Trim & "%' and a.dsvend like '" & Me.TextBox2.Text.Trim & "%' and c.finicio between '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "' and '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "MM/dd/yy") & "'", "llena")
            ElseIf Me.RadioButton4.Checked = True Then
                Conecta("select c.ident as correl,c.idvend as codigo,a.dsvend as descripcion,c.finicio as fvenc,c.ffin as fproceso from cuota_vendedor c,vendedor a where c.idvend=a.codvend and c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "' and c.idvend like '" & Me.TextBox1.Text.Trim & "%' and a.dsvend like '" & Me.TextBox2.Text.Trim & "%' and c.ffin between '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "' and '" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "MM/dd/yy") & "'", "llena")
            End If
        End If

        oda.Fill(Me.Ds_detimportacion1)
        Me.DataGrid1.Refresh()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, DateTimePicker1.KeyPress, DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Try
            Conecta("select c.ident,c.idvend,a.dsvend,c.finicio,c.ffin,c.cuotasoles,c.cuotadolar,c.cuotaton from cuota_vendedor c,vendedor a  where c.idvend=a.codvend and c.codempresa='" & codempresa & "' and a.codempresa='" & codempresa & "' and c.ident=" & DataGrid1.Item(DataGrid1.CurrentRowIndex, 0) & "", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                vie.tcodigo.Text = Trim(ds.Tables("llena").Rows(0)(0))
                vie.tvendedor.Text = Trim(ds.Tables("llena").Rows(0)(1))
                vie.TextBox1.Text = Trim(ds.Tables("llena").Rows(0)(2))
                vie.DateTimePicker1.Value = Trim(ds.Tables("llena").Rows(0)(3))
                vie.DateTimePicker2.Value = Trim(ds.Tables("llena").Rows(0)(4))
                vie.tcuotas.Text = Trim(ds.Tables("llena").Rows(0)(5))
                vie.tcuotad.Text = Trim(ds.Tables("llena").Rows(0)(6))
                vie.tcuotat.Text = Trim(ds.Tables("llena").Rows(0)(7))
            End If
            Me.Close()

        Catch ex As Exception
        End Try
    End Sub

End Class
