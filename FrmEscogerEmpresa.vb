Public Class FrmEscogerEmpresa
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
    Friend WithEvents FRAMEPUNTO As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.FRAMEPUNTO = New System.Windows.Forms.GroupBox
        Me.cbEmpresa = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BTNACEPTAR = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.FRAMEPUNTO.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FRAMEPUNTO)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 81)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        '
        'FRAMEPUNTO
        '
        Me.FRAMEPUNTO.Controls.Add(Me.cbEmpresa)
        Me.FRAMEPUNTO.Controls.Add(Me.Label4)
        Me.FRAMEPUNTO.Location = New System.Drawing.Point(10, 18)
        Me.FRAMEPUNTO.Name = "FRAMEPUNTO"
        Me.FRAMEPUNTO.Size = New System.Drawing.Size(375, 48)
        Me.FRAMEPUNTO.TabIndex = 3
        Me.FRAMEPUNTO.TabStop = False
        '
        'cbEmpresa
        '
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.Location = New System.Drawing.Point(86, 15)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(254, 24)
        Me.cbEmpresa.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Empresa :"
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.Location = New System.Drawing.Point(77, 92)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(230, 33)
        Me.BTNACEPTAR.TabIndex = 52
        Me.BTNACEPTAR.Text = "Aceptar"
        '
        'FrmEscogerEmpresa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(408, 155)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmEscogerEmpresa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccionar Empresa"
        Me.GroupBox1.ResumeLayout(False)
        Me.FRAMEPUNTO.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "FUNCIONES"
   


#End Region


    Private Sub FrmEscogerEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(cbEmpresa, "SCP_SELECT_EMPRESA", "CODEMPRESA", "RAZONSOCIAL")
    End Sub

    Private Sub BTNACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACEPTAR.Click
        codempresa = Me.cbEmpresa.SelectedValue.ToString
        DesEmpresa = cbEmpresa.Text.Trim
        Close()

    End Sub

    Private Sub cbEmpresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEmpresa.SelectedIndexChanged

    End Sub

    Private Sub cbEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbEmpresa.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BTNACEPTAR.Focus()
        End If
    End Sub

    Private Sub FrmEscogerEmpresa_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'End
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
