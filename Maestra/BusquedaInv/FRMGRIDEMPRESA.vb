Public Class FRMGRIDEMPRESA
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
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbempresa As System.Windows.Forms.RadioButton
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AXCRT2 As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMGRIDEMPRESA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rbempresa = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.AXCRT2 = New AxCrystal.AxCrystalReport
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbempresa)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 48)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(532, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 16)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "RUC"
        '
        'rbempresa
        '
        Me.rbempresa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbempresa.Location = New System.Drawing.Point(420, 20)
        Me.rbempresa.Name = "rbempresa"
        Me.rbempresa.Size = New System.Drawing.Size(96, 16)
        Me.rbempresa.TabIndex = 3
        Me.rbempresa.Text = "Razón Social"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(332, 20)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 16)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(76, 18)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(232, 21)
        Me.txtdato.TabIndex = 1
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de Empresa"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(12, 66)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(616, 232)
        Me.Grid1.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(448, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 24)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Imprimir"
        '
        'AXCRT2
        '
        Me.AXCRT2.Enabled = True
        Me.AXCRT2.Location = New System.Drawing.Point(88, 192)
        Me.AXCRT2.Name = "AXCRT2"
        Me.AXCRT2.OcxState = CType(resources.GetObject("AXCRT2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AXCRT2.Size = New System.Drawing.Size(28, 28)
        Me.AXCRT2.TabIndex = 24
        '
        'FRMGRIDEMPRESA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(640, 332)
        Me.Controls.Add(Me.AXCRT2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(648, 360)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(646, 360)
        Me.Name = "FRMGRIDEMPRESA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Empresas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
   Private Sub FRMGRIDMARCAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            CargagridEmpresa(Grid1, "NSP_SELE_EMPRESA_report '','',''")
        Else
            If Me.rbcodigo.Checked = True Then
                CargagridEmpresa(Grid1, "NSP_SELE_EMPRESA_report '" & Me.txtdato.Text.Trim & "','',''")
            ElseIf Me.rbempresa.Checked = True Then
                CargagridEmpresa(Grid1, "NSP_SELE_EMPRESA_report '','" & Me.txtdato.Text.Trim & "',''")
            Else
                CargagridEmpresa(Grid1, "NSP_SELE_EMPRESA_report '','','" & Me.txtdato.Text.Trim & "'")
            End If
        End If
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        Try
            Dim FRM As New frmempresa
            VAR1 = Grid1.Item(Grid1.CurrentRowIndex, 0)
            VAR2 = Grid1.Item(Grid1.CurrentRowIndex, 1)
            VAR3 = Grid1.Item(Grid1.CurrentRowIndex, 2)
            VAR4 = Grid1.Item(Grid1.CurrentRowIndex, 3)
            Dim obj As New frmempresa
            obj.mostrar()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtdato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            
            'If Me.rbcodigo.Checked = True Then
            '    AXCRT2.set_StoredProcParam(0, Me.txtdato.Text.Trim)
            '    AXCRT2.set_StoredProcParam(1, "")
            '    AXCRT2.set_StoredProcParam(2, "")
            'ElseIf Me.rbempresa.Checked = True Then
            '    AXCRT2.set_StoredProcParam(0, "")
            '    AXCRT2.set_StoredProcParam(1, Me.txtdato.Text.Trim)
            '    AXCRT2.set_StoredProcParam(2, "")
            'Else
            '    AXCRT2.set_StoredProcParam(0, "")
            '    AXCRT2.set_StoredProcParam(1, "")
            '    AXCRT2.set_StoredProcParam(2, Me.txtdato.Text.Trim)
            'End If

            Dim a As String = ""

            If Me.txtdato.Text.Trim = "" Then
                a = "0"
            End If

            AXCRT2.set_StoredProcParam(0, a)

            AXCRT2.ReportFileName = rutareporte + CType("REGISTRO POR EMPRESAS.rpt", String)
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
End Class
