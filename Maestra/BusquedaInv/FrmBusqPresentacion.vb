Public Class FrmBusqPresentacion
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents rbpresentacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbpresentacion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de Presentacion"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(10, 70)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(592, 240)
        Me.Grid1.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbmedida)
        Me.GroupBox1.Controls.Add(Me.rbpresentacion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 48)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
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
        Me.txtdato.Size = New System.Drawing.Size(232, 20)
        Me.txtdato.TabIndex = 1
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'FrmBusqPresentacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(614, 330)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusqPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Presentacion"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "Fields Form"

    Private Table_Present As New DataTable
    Public DEVOLVER As Boolean


#End Region

#Region "Function  Form"
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
                    DEVOLVER = True
                    Me.Close()
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function
#End Region


    Private Sub FrmBusqPresentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llena()
    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        llena()
    End Sub
End Class
