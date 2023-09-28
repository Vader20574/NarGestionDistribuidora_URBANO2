Public Class frm_griddep
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
    Friend WithEvents axcrt2 As AxCrystal.AxCrystalReport
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbciudad As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_griddep))
        Me.axcrt2 = New AxCrystal.AxCrystalReport
        Me.Button1 = New System.Windows.Forms.Button
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rbciudad = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.axcrt2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'axcrt2
        '
        Me.axcrt2.Enabled = True
        Me.axcrt2.Location = New System.Drawing.Point(336, 206)
        Me.axcrt2.Name = "axcrt2"
        Me.axcrt2.OcxState = CType(resources.GetObject("axcrt2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axcrt2.Size = New System.Drawing.Size(28, 28)
        Me.axcrt2.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(392, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 24)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Imprimir"
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de Departamentos"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(16, 62)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(536, 266)
        Me.Grid1.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbciudad)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 48)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(448, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "País"
        '
        'rbciudad
        '
        Me.rbciudad.Location = New System.Drawing.Point(336, 20)
        Me.rbciudad.Name = "rbciudad"
        Me.rbciudad.Size = New System.Drawing.Size(104, 16)
        Me.rbciudad.TabIndex = 3
        Me.rbciudad.Text = "Departamento"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(264, 19)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(68, 18)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(188, 21)
        Me.txtdato.TabIndex = 1
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'frm_griddep
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(570, 340)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.axcrt2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(576, 368)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(576, 368)
        Me.Name = "frm_griddep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Departamentos"
        CType(Me.axcrt2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public vie As New FRM_DEP

    Sub cargadatos()
        llena()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                          ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Grid1.Focus = True Then
                        Dim FRM As New frmciudad
                        vie.txtcodciud.Text = Grid1.Item(Grid1.CurrentRowIndex, 0)
                        vie.txtdesciud.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
                        vie.cbopais.Text = Grid1.Item(Grid1.CurrentRowIndex, 2)
                        Dim obj As New frmciudad
                        obj.mostrar()
                        Me.Close()

                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            Cargagriddepa(Grid1, "nsp_sele_depa '','','','" & codempresa & "'")
        Else
            If Me.rbcodigo.Checked = True Then
                Cargagriddepa(Grid1, "nsp_sele_depa '" & Me.txtdato.Text.Trim & "','','','" & codempresa & "'")
            ElseIf Me.rbciudad.Checked = True Then
                Cargagriddepa(Grid1, "nsp_sele_depa '','" & Me.txtdato.Text.Trim & "','','" & codempresa & "'")
            Else
                Cargagriddepa(Grid1, "nsp_sele_depa '','','" & Me.txtdato.Text.Trim & "','" & codempresa & "'")
            End If
        End If
    End Sub

    Private Sub frmgridciudad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargadatos()
    End Sub

    Private Sub grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        pasadatos()
    End Sub

    Sub pasadatos()
        Dim FRM As New frmciudad
        vie.txtcodciud.Text = Grid1.Item(Grid1.CurrentRowIndex, 0)
        vie.txtdesciud.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
        vie.cbopais.Text = Grid1.Item(Grid1.CurrentRowIndex, 2)
        Dim obj As New frmciudad
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


            If Me.rbcodigo.Checked = True Then
                axcrt2.set_StoredProcParam(0, a)
                axcrt2.set_StoredProcParam(1, 0)
                axcrt2.set_StoredProcParam(2, 0)
                axcrt2.set_StoredProcParam(3, codempresa)
            ElseIf Me.rbciudad.Checked = True Then
                axcrt2.set_StoredProcParam(0, 0)
                axcrt2.set_StoredProcParam(1, a)
                axcrt2.set_StoredProcParam(2, 0)
                axcrt2.set_StoredProcParam(3, codempresa)
            Else
                axcrt2.set_StoredProcParam(0, 0)
                axcrt2.set_StoredProcParam(1, 0)
                axcrt2.set_StoredProcParam(2, a)
                axcrt2.set_StoredProcParam(3, codempresa)
            End If


            axcrt2.ReportFileName = rutareporte + CType("REGISTRO POR CIUDAD.rpt", String)
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
    Private Sub txtdato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdato.KeyDown
        If e.KeyCode = Keys.Down Then
            Me.Grid1.Focus()
        End If
    End Sub
    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate
    End Sub
    Private Sub Grid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            pasadatos()
        End If
    End Sub
End Class
