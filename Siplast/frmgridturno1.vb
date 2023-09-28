Public Class frmgridturno1
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
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents axcrt2 As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmgridumedida))
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.axcrt2 = New AxCrystal.AxCrystalReport
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.axcrt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de Medidas"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(12, 64)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(480, 216)
        Me.Grid1.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbmedida)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 48)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(384, 19)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(72, 16)
        Me.rbmedida.TabIndex = 3
        Me.rbmedida.Text = "Medida"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(296, 19)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 16)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(64, 17)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(205, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 24)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "&Imprimir"
        '
        'axcrt2
        '
        Me.axcrt2.Enabled = True
        Me.axcrt2.Location = New System.Drawing.Point(144, 136)
        Me.axcrt2.Name = "axcrt2"
        Me.axcrt2.OcxState = CType(resources.GetObject("axcrt2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axcrt2.Size = New System.Drawing.Size(28, 28)
        Me.axcrt2.TabIndex = 27
        '
        'frmgridumedida
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(504, 316)
        Me.Controls.Add(Me.axcrt2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(512, 344)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(510, 344)
        Me.Name = "frmgridumedida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Turno"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.axcrt2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmgridciudad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            Cargagridmedida(Grid1, "nsp_sele_TURNO_REPORT '" & codempresa & "','',''")
        Else
            If Me.rbcodigo.Checked = True Then
                Cargagridmedida(Grid1, "nsp_sele_TURNO_REPORT '" & codempresa & "','" & Me.txtdato.Text.Trim & "',''")
            Else
                Cargagridmedida(Grid1, "nsp_sele_TURNO_REPORT '" & codempresa & "','','" & Me.txtdato.Text.Trim & "'")
            End If
        End If
    End Sub


    Private Sub grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick

        VAR1 = Grid1.Item(Grid1.CurrentRowIndex, 0)
        VAR2 = Grid1.Item(Grid1.CurrentRowIndex, 1)
        VAR3 = Grid1.Item(Grid1.CurrentRowIndex, 2)
        Dim obj As New FRMUMEDIDA
        obj.mostrar()
        Me.Close()
    End Sub


    Private Sub txtdato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            Dim a As String
            If Me.txtdato.Text.Trim = "" Then
                a = 0
            Else
                a = Me.txtdato.Text.Trim
            End If

            'Dim dt As New DataTable
            'dt = M_Cabecera_R(CodUsuario, codempresa)

            'axcrt2.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            'axcrt2.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")


            If Me.rbcodigo.Checked = True Then
                axcrt2.set_StoredProcParam(0, codempresa)
                axcrt2.set_StoredProcParam(1, a)
                axcrt2.set_StoredProcParam(2, 0)
            Else
                axcrt2.set_StoredProcParam(0, codempresa)
                axcrt2.set_StoredProcParam(1, 0)
                axcrt2.set_StoredProcParam(2, a)
            End If


            axcrt2.ReportFileName = rutareporte + CType("REGISTRO POR umedida.rpt", String)
            axcrt2.WindowState = Crystal.WindowStateConstants.crptMaximized
            axcrt2.Action = 1
            axcrt2.Reset()

        Catch x As Exception
            MessageBox.Show(x.Message)
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        llena()
    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub
End Class
