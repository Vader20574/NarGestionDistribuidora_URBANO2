Public Class frmgridpresentacion
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
    Friend WithEvents rbpresentacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AXCRT2 As AxCrystal.AxCrystalReport
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgridpresentacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbpresentacion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.AXCRT2 = New AxCrystal.AxCrystalReport
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbmedida)
        Me.GroupBox1.Controls.Add(Me.rbpresentacion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 48)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filtrar(F1)"
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(392, 20)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(68, 16)
        Me.rbmedida.TabIndex = 4
        Me.rbmedida.Text = "Medida"
        '
        'rbpresentacion
        '
        Me.rbpresentacion.Location = New System.Drawing.Point(480, 20)
        Me.rbpresentacion.Name = "rbpresentacion"
        Me.rbpresentacion.Size = New System.Drawing.Size(89, 16)
        Me.rbpresentacion.TabIndex = 3
        Me.rbpresentacion.Text = "Presentacion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(320, 20)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 16)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(64, 18)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(232, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de Presentacion"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(12, 64)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(592, 240)
        Me.Grid1.TabIndex = 20
        Me.Grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "MITABLA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "CODIGO"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "MEDIDA"
        Me.DataGridTextBoxColumn2.MappingName = "MEDIDA"
        Me.DataGridTextBoxColumn2.Width = 130
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "PRESENTACIÒN"
        Me.DataGridTextBoxColumn3.MappingName = "PRESENTACION"
        Me.DataGridTextBoxColumn3.Width = 200
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "FACTOR"
        Me.DataGridTextBoxColumn4.MappingName = "FACTOR"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "CPTOVENTA"
        Me.DataGridTextBoxColumn5.MappingName = "CPTOVENTA"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "CFUERZAVENT"
        Me.DataGridTextBoxColumn6.MappingName = "CFUERZAVENT"
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 24)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "&Imprimir"
        '
        'AXCRT2
        '
        Me.AXCRT2.Enabled = True
        Me.AXCRT2.Location = New System.Drawing.Point(112, 152)
        Me.AXCRT2.Name = "AXCRT2"
        Me.AXCRT2.OcxState = CType(resources.GetObject("AXCRT2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AXCRT2.Size = New System.Drawing.Size(28, 28)
        Me.AXCRT2.TabIndex = 22
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "DESUMEDSUNAT"
        Me.DataGridTextBoxColumn7.MappingName = "DESUMEDSUNAT"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'frmgridpresentacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(616, 340)
        Me.Controls.Add(Me.AXCRT2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(622, 368)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(622, 368)
        Me.Name = "frmgridpresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Presentaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "DECLARACION DE VARIABLES"
    Public DEVOLVERVALORES As Boolean
    Public FrmAR As frmarticulos
    Public Table_Present As New DataTable

#End Region
    Private Sub frmgridpresentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            CargagridPresentacion(Grid1, "nsp_sele_presentacion '','','','" & codempresa & "'")
            Table_Present = TmpListarDatos("nsp_sele_presentacion '','','','" & codempresa & "'")
        Else
            If Me.rbcodigo.Checked = True Then
                CargagridPresentacion(Grid1, "nsp_sele_presentacion '" & Me.txtdato.Text.Trim & "','','','" & codempresa & "'")
            ElseIf Me.rbmedida.Checked = True Then
                CargagridPresentacion(Grid1, "nsp_sele_presentacion '','" & Me.txtdato.Text.Trim & "','','" & codempresa & "'")
            Else
                CargagridPresentacion(Grid1, "nsp_sele_presentacion '','','" & Me.txtdato.Text.Trim & "','" & codempresa & "'")
            End If
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                          ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Grid1.Focus = True Then
                        Dim FRM As New frmpresentacion
                        VAR1 = Grid1.Item(Grid1.CurrentRowIndex, 0)
                        VAR2 = Grid1.Item(Grid1.CurrentRowIndex, 1)
                        VAR3 = Grid1.Item(Grid1.CurrentRowIndex, 2)
                        VAR4 = Grid1.Item(Grid1.CurrentRowIndex, 3)
                        VAR5 = Grid1.Item(Grid1.CurrentRowIndex, 5)
                        VAR7 = Grid1.Item(Grid1.CurrentRowIndex, 6)

                        'Variables.VAR5 = Grid1.Item(Grid1.CurrentRowIndex, 4)
                        Dim obj As New frmpresentacion
                        obj.mostrar()
                        Dim sender As Object = Nothing
                        Dim e As EventArgs = Nothing
                        grid1_DoubleClick(sender, e)
                        Me.Close()
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function
    Private Sub grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        If Not FrmAR Is Nothing Then
            'FrmAR.txtCodPresentacion.Text = Grid1.Item(Grid1.CurrentRowIndex, 0)
            'FrmAR.txtMedida.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
            'FrmAR.lbPresentacion.Text = Grid1.Item(Grid1.CurrentRowIndex, 2)
            'FrmAR.LblFactor.Text = Grid1.Item(Grid1.CurrentRowIndex, 3)
            Me.Close()
            Exit Sub
        End If
        Dim FRM As New frmpresentacion
        VAR1 = Grid1.Item(Grid1.CurrentRowIndex, 0)
        VAR2 = Grid1.Item(Grid1.CurrentRowIndex, 1)
        VAR3 = Grid1.Item(Grid1.CurrentRowIndex, 2)
        VAR4 = Grid1.Item(Grid1.CurrentRowIndex, 3)
        VAR5 = Grid1.Item(Grid1.CurrentRowIndex, 4)
        VAR6 = Grid1.Item(Grid1.CurrentRowIndex, 5)
        VAR7 = Grid1.Item(Grid1.CurrentRowIndex, 6)
        'Variables.VAR5 = Grid1.Item(Grid1.CurrentRowIndex, 4)
        Dim obj As New frmpresentacion
        obj.mostrar()
        DEVOLVERVALORES = True
        Me.Close()
    End Sub
    Private Sub txtdato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Grid1.Focus()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)

            AXCRT2.set_Formulas(0, "Empresa='" & dt.Rows(0)(1).ToString & "'")
            AXCRT2.set_Formulas(1, "Usuario='" & dt.Rows(0)(0).ToString & "'")
            Dim a As String
            If Me.txtdato.Text.Trim = "" Then
                a = 0
            Else
                a = Me.txtdato.Text.Trim
            End If
            If Me.rbcodigo.Checked = True Then
                AXCRT2.set_StoredProcParam(0, a)
                AXCRT2.set_StoredProcParam(1, 0)
                AXCRT2.set_StoredProcParam(2, 0)
                AXCRT2.set_StoredProcParam(3, codempresa)
            ElseIf Me.rbmedida.Checked = True Then
                AXCRT2.set_StoredProcParam(0, 0)
                AXCRT2.set_StoredProcParam(1, a)
                AXCRT2.set_StoredProcParam(2, 0)
                AXCRT2.set_StoredProcParam(3, codempresa)
            Else
                AXCRT2.set_StoredProcParam(0, 0)
                AXCRT2.set_StoredProcParam(1, 0)
                AXCRT2.set_StoredProcParam(2, a)
                AXCRT2.set_StoredProcParam(3, codempresa)
            End If
            AXCRT2.ReportFileName = rutareporte + CType("REGISTRO POR PRESENTACION.rpt", String)
            AXCRT2.WindowState = Crystal.WindowStateConstants.crptMaximized
            AXCRT2.Action = 1
            AXCRT2.Reset()
        Catch x As Exception
            MessageBox.Show(x.Message)
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged


        llena()

    End Sub

    Private Sub txtdato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdato.KeyDown
        Static caso As Integer = 1
        If e.KeyCode = Keys.F1 Then
            Select Case caso
                Case 0
                    rbcodigo.Checked = True
                    caso = 1
                Case 1
                    rbmedida.Checked = True
                    caso = 2
                Case 2
                    rbpresentacion.Checked = True
                    caso = 0
            End Select
        End If
    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub
End Class
