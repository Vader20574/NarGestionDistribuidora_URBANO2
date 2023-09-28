Public Class FrmBuscaAlmacen
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grid1 As System.Windows.Forms.DataGrid
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rbalmacen As System.Windows.Forms.RadioButton
    Friend WithEvents AXCRT2 As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscaAlmacen))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AXCRT2 = New AxCrystal.AxCrystalReport
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.grid1 = New System.Windows.Forms.DataGrid
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.rbalmacen = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AXCRT2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.grid1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtdato)
        Me.GroupBox2.Controls.Add(Me.rbcodigo)
        Me.GroupBox2.Controls.Add(Me.rbalmacen)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 290)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'AXCRT2
        '
        Me.AXCRT2.Enabled = True
        Me.AXCRT2.Location = New System.Drawing.Point(96, 152)
        Me.AXCRT2.Name = "AXCRT2"
        Me.AXCRT2.OcxState = CType(resources.GetObject("AXCRT2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AXCRT2.Size = New System.Drawing.Size(28, 28)
        Me.AXCRT2.TabIndex = 13
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(440, 18)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(96, 16)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.Text = "Pto Venta "
        '
        'grid1
        '
        Me.grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.grid1.DataMember = ""
        Me.grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grid1.Location = New System.Drawing.Point(16, 48)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(544, 240)
        Me.grid1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(72, 16)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(184, 21)
        Me.txtdato.TabIndex = 1
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(288, 17)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'rbalmacen
        '
        Me.rbalmacen.Location = New System.Drawing.Point(360, 18)
        Me.rbalmacen.Name = "rbalmacen"
        Me.rbalmacen.Size = New System.Drawing.Size(72, 16)
        Me.rbalmacen.TabIndex = 3
        Me.rbalmacen.Text = "Almacén"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 24)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Imprimir"
        '
        'FrmBuscaAlmacen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(592, 335)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(598, 392)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(598, 360)
        Me.Name = "FrmBuscaAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Almacen"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmBuscaAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub
    Private Sub grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid1.DoubleClick
        Dim FRM As New FrmAlmacen
        VAR1 = grid1.Item(grid1.CurrentRowIndex, 0)
        VAR2 = grid1.Item(grid1.CurrentRowIndex, 1)
        VAR3 = grid1.Item(grid1.CurrentRowIndex, 2)
        VAR4 = grid1.Item(grid1.CurrentRowIndex, 3)
        VAR5 = grid1.Item(grid1.CurrentRowIndex, 4)
        VARTIPO = grid1.Item(grid1.CurrentRowIndex, 5)
        Dim obj As New FrmAlmacen
        obj.mostrar()
        Me.Close()
    End Sub

    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            Cargagridalmacen(grid1, "Nsp_select_Almacen_report '" & codempresa & "','','',''")
        Else
            If Me.rbcodigo.Checked = True Then
                Cargagridalmacen(grid1, "Nsp_select_Almacen_report '" & codempresa & "','" & Me.txtdato.Text.Trim & "','',''")
            ElseIf Me.rbalmacen.Checked = True Then
                Cargagridalmacen(grid1, "Nsp_select_Almacen_report '" & codempresa & "','','" & Me.txtdato.Text.Trim & "',''")
            Else
                Cargagridalmacen(grid1, "Nsp_select_Almacen_report '" & codempresa & "','','','" & Me.txtdato.Text.Trim & "'")
            End If
        End If
    End Sub

    Private Sub txtdato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
        If Asc(e.KeyChar) = 13 Then
            llena()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)

            AXCRT2.set_Formulas(1, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            AXCRT2.set_Formulas(0, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            If txtdato.Text.Trim.Length = 0 Then
                AXCRT2.set_StoredProcParam(0, codempresa.ToString)
                AXCRT2.set_StoredProcParam(1, " ")
                AXCRT2.set_StoredProcParam(2, " ")
                AXCRT2.set_StoredProcParam(3, " ")

            ElseIf Me.rbcodigo.Checked = True Then
                AXCRT2.set_StoredProcParam(0, codempresa.ToString)
                AXCRT2.set_StoredProcParam(1, Me.txtdato.Text.Trim)
                AXCRT2.set_StoredProcParam(2, " ")
                AXCRT2.set_StoredProcParam(3, " ")

            ElseIf Me.rbalmacen.Checked = True Then
                AXCRT2.set_StoredProcParam(0, codempresa)
                AXCRT2.set_StoredProcParam(1, " ")
                AXCRT2.set_StoredProcParam(2, Me.txtdato.Text.Trim)
                AXCRT2.set_StoredProcParam(3, " ")

            Else
                AXCRT2.set_StoredProcParam(0, codempresa)
                AXCRT2.set_StoredProcParam(1, " ")
                AXCRT2.set_StoredProcParam(2, " ")
                AXCRT2.set_StoredProcParam(3, Me.txtdato.Text.Trim)
            End If

            AXCRT2.ReportFileName = rutareporte + CType("RptRegistroAlmacen.rpt", String)
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

    Private Sub grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grid1.Navigate

    End Sub
End Class
