Public Class frmgridclienteFACT
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
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbldescripcion = New System.Windows.Forms.Label
        Me.lblcodigo = New System.Windows.Forms.Label
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.White
        Me.Grid1.CaptionBackColor = System.Drawing.Color.Silver
        Me.Grid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid1.CaptionForeColor = System.Drawing.Color.Black
        Me.Grid1.CaptionText = "Registro de Clientes"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(5, 50)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(703, 309)
        Me.Grid1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 38)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Checked = True
        Me.rbdescripcion.Location = New System.Drawing.Point(328, 19)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(110, 16)
        Me.rbdescripcion.TabIndex = 3
        Me.rbdescripcion.TabStop = True
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Location = New System.Drawing.Point(256, 16)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(43, 14)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(205, 20)
        Me.txtdato.TabIndex = 1
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dato : "
        '
        'lbldescripcion
        '
        Me.lbldescripcion.Location = New System.Drawing.Point(45, 428)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(180, 23)
        Me.lbldescripcion.TabIndex = 26
        Me.lbldescripcion.Text = "Label3"
        '
        'lblcodigo
        '
        Me.lblcodigo.Location = New System.Drawing.Point(41, 377)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(207, 28)
        Me.lblcodigo.TabIndex = 27
        Me.lblcodigo.Text = "Label1"
        '
        'frmgridclienteFACT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(717, 362)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.Grid1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmgridclienteFACT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Clientes"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmgridcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FACT_CargagridclienteFACT(Grid1, "NSP_SELE_clienteFac '" & codempresa & "','',2,'" & NROPTOVTA & "'")
        VCodCliente = ""
    End Sub
    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        Try

            VCodCliente = Grid1.Item(Grid1.CurrentRowIndex, 0)
            lblcodigo.Text = VCodCliente
            lbldescripcion.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub txtdato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
        Try

            If Asc(e.KeyChar) = 13 Then
                Dim TIPO As Integer
                If rbcodigo.Checked = True Then TIPO = 0
                If rbdescripcion.Checked = True Then TIPO = 1
                FACT_CargagridclienteFACT(Grid1, "NSP_SELE_clienteFac '" & codempresa & "','" & txtdato.Text.Trim & "'," & TIPO & ",'" & NROPTOVTA & "'")
                VCodCliente = ""
                txtdato.Focus()
            End If

        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104

        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If Grid1.Focus = True Then
                        Try
                            VCodCliente = Grid1.Item(Grid1.CurrentRowIndex, 0)
                            lblcodigo.Text = VCodCliente
                            '    If Trim(Grid1.Item(Grid1.CurrentRowIndex, 1)) <> "" Then
                            'lbldescripcion.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
                            '   End If
                            '  If Trim(Grid1.Item(Grid1.CurrentRowIndex, 2)) <> "" Then
                            lbldescripcion.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
                            ' End If
                            Me.Close()
                            'Dim frmx As New frmtipoclieFACT
                            'frmx.VIE = Me
                            'frmx.cond = 0
                            'frmx.ShowDialog()
                        Catch ex As Exception
                        End Try
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmgridclienteFACT_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        txtdato.Focus()
    End Sub

    Private Sub Grid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.CurrentCellChanged
        VCodCliente = Grid1.Item(Grid1.CurrentRowIndex, 0)
        lblcodigo.Text = VCodCliente
    End Sub

    Private Sub lblcodigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
