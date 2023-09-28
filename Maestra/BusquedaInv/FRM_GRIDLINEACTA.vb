Public Class FRM_GRIDLINEACTA
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
    Friend WithEvents grdLinea As System.Windows.Forms.DataGrid
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents Ds_gridclie21 As mantenimiento.ds_gridclie2
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AXCRT2 As AxCrystal.AxCrystalReport
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_GRIDLINEA))
        Me.grdLinea = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.AXCRT2 = New AxCrystal.AxCrystalReport
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdLinea
        '
        Me.grdLinea.CaptionText = "ESC = Salir  -   ENTER = Aceptar"
        Me.grdLinea.DataMember = ""
        Me.grdLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLinea.Location = New System.Drawing.Point(21, 66)
        Me.grdLinea.Name = "grdLinea"
        Me.grdLinea.ReadOnly = True
        Me.grdLinea.Size = New System.Drawing.Size(503, 232)
        Me.grdLinea.TabIndex = 1
        Me.grdLinea.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdLinea
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "cliente"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "codigo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Categoria"
        Me.DataGridTextBoxColumn2.MappingName = "apellidop"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 270
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Tipo Producto"
        Me.DataGridTextBoxColumn3.MappingName = "razon"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Correlativo"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'txtdato
        '
        Me.txtdato.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(72, 22)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(208, 21)
        Me.txtdato.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dato : "
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(328, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 16)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Código "
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(416, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 16)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.Text = "Categoria"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "F1 [Filtrar]"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(292, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 24)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Imprimir"
        '
        'AXCRT2
        '
        Me.AXCRT2.Enabled = True
        Me.AXCRT2.Location = New System.Drawing.Point(64, 224)
        Me.AXCRT2.Name = "AXCRT2"
        Me.AXCRT2.OcxState = CType(resources.GetObject("AXCRT2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AXCRT2.Size = New System.Drawing.Size(28, 28)
        Me.AXCRT2.TabIndex = 15
        '
        'FRM_GRIDLINEA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(538, 340)
        Me.Controls.Add(Me.AXCRT2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdLinea)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(544, 368)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(544, 368)
        Me.Name = "FRM_GRIDLINEA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Categoria"
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public VIE As New Cta_Contable
    Public vie3 As FrmFuerzaVenta
    Public Vie2 As FrmCuotasVendedorX_Linea
    Private Ds_gridclie21 As New DataTable

#Region "FUNCIONES"
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const KEYDOWN As Integer = &H100
        Const KEYSYSTEM As Integer = &H104
        If (MSG.Msg = KEYDOWN) Or (MSG.Msg = KEYSYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If grdLinea.Focus = True Then
                        Dim Sender As Object = Nothing
                        Dim e As EventArgs = Nothing
                        If Ds_gridclie21.Rows.Count > 0 Then
                            grdLinea_DoubleClick(Sender, e)
                        End If
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function
#End Region
    Private Sub FRM_GRIDLINEA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Sub llena()
        Me.Ds_gridclie21.Clear()

        If Me.RadioButton1.Checked = True Then

            Conecta("Nsp_sel_CTACONTABLE_report '" & codempresa & "','" & Me.txtdato.Text.Trim & "',''", "llena")
        Else
            Conecta("Nsp_sel_CTACONTABLE_report '" & codempresa & "','','" & Me.txtdato.Text.Trim & "'", "llena")
        End If
        Ds_gridclie21 = ds.Tables("llena")
        grdLinea.DataSource = Ds_gridclie21

        Dim tablestyle1 As New DataGridTableStyle
        With tablestyle1
            .MappingName = ds.Tables("llena").TableName
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "codigo"
            .HeaderText = "Codigo"
            .Width = 75
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "apellidop"
            .HeaderText = "Categoria"
            .Width = 270
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "razon"
            .Width = 0
        End With
        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "correlativo"
            .Width = 0
        End With
        grdLinea.TableStyles.Clear()

        tablestyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4})

        grdLinea.TableStyles.Add(tablestyle1)


        ' oda.Fill(Me.Ds_gridclie21.cliente)
        ' Me.grdLinea.Refresh()
    End Sub

    Private Sub grdLinea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLinea.DoubleClick
        If Not Vie2 Is Nothing Then
            'Vie2.txtLinea.Text = grdLinea.Item(grdLinea.CurrentRowIndex, 0)
            Vie2.CodLinea = grdLinea.Item(grdLinea.CurrentRowIndex, 0)
            'Vie2.lbLinea.Text = grdLinea.Item(grdLinea.CurrentRowIndex, 1)
            Me.Close()
            Exit Sub
        ElseIf Not vie3 Is Nothing Then
            vie3.txtCategoria.Text = grdLinea.Item(grdLinea.CurrentRowIndex, 0)
            vie3.lbCategoria.Text = grdLinea.Item(grdLinea.CurrentRowIndex, 1)
            Me.Close()
            Exit Sub
        End If
        Try
            VIE.txtcod.Text = grdLinea.Item(grdLinea.CurrentRowIndex, 0)
            VIE.txtdescripcion.Text = grdLinea.Item(grdLinea.CurrentRowIndex, 1)
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim a As String
            If Me.txtdato.Text.Trim = "" Then
                a = 0
            Else
                a = Me.txtdato.Text.Trim
            End If

            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)

            AXCRT2.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            AXCRT2.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")

            If Me.RadioButton1.Checked = True Then
                AXCRT2.set_StoredProcParam(0, codempresa)
                AXCRT2.set_StoredProcParam(1, a)
                AXCRT2.set_StoredProcParam(2, 0)
            Else
                AXCRT2.set_StoredProcParam(0, codempresa)
                AXCRT2.set_StoredProcParam(1, 0)
                AXCRT2.set_StoredProcParam(2, a)
            End If


            AXCRT2.ReportFileName = rutareporte + CType("REGISTRO POR LINEAS.rpt", String)
            AXCRT2.WindowState = Crystal.WindowStateConstants.crptMaximized
            AXCRT2.Action = 1
            AXCRT2.Reset()

        Catch x As Exception
            MessageBox.Show(x.Message)
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub txtdato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
        If Asc(e.KeyChar) = 13 Then
            grdLinea.Focus()

        End If
    End Sub

    Private Sub grdLinea_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdLinea.Navigate

    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        llena()
    End Sub

    Private Sub txtdato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdato.KeyDown
        If e.KeyCode = Keys.F1 Then
            If RadioButton1.Checked = True Then
                RadioButton2.Checked = True
            Else
                RadioButton1.Checked = True
            End If
        End If
    End Sub

End Class
