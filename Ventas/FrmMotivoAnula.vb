Public Class FrmMotivoAnula
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboTipAnul As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents TxtObserv As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoRechazo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboLiquidador As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboRepartidor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMotivoAnula))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboTipAnul = New System.Windows.Forms.ComboBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtObserv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.cboTipoRechazo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboLiquidador = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboRepartidor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Motivo de Anulacion: "
        '
        'CboTipAnul
        '
        Me.CboTipAnul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipAnul.Location = New System.Drawing.Point(122, 16)
        Me.CboTipAnul.Name = "CboTipAnul"
        Me.CboTipAnul.Size = New System.Drawing.Size(228, 21)
        Me.CboTipAnul.TabIndex = 1
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Image = CType(resources.GetObject("BtnAceptar.Image"), System.Drawing.Image)
        Me.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAceptar.Location = New System.Drawing.Point(175, 260)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(86, 42)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        '
        'TxtObserv
        '
        Me.TxtObserv.Location = New System.Drawing.Point(18, 68)
        Me.TxtObserv.MaxLength = 200
        Me.TxtObserv.Multiline = True
        Me.TxtObserv.Name = "TxtObserv"
        Me.TxtObserv.Size = New System.Drawing.Size(320, 72)
        Me.TxtObserv.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Observacion : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto de Rechazo : "
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(122, 234)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(225, 20)
        Me.txtmonto.TabIndex = 7
        '
        'cboTipoRechazo
        '
        Me.cboTipoRechazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoRechazo.Location = New System.Drawing.Point(122, 146)
        Me.cboTipoRechazo.Name = "cboTipoRechazo"
        Me.cboTipoRechazo.Size = New System.Drawing.Size(228, 21)
        Me.cboTipoRechazo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo Rechazo: "
        '
        'cboLiquidador
        '
        Me.cboLiquidador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLiquidador.Location = New System.Drawing.Point(122, 173)
        Me.cboLiquidador.Name = "cboLiquidador"
        Me.cboLiquidador.Size = New System.Drawing.Size(228, 21)
        Me.cboLiquidador.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Quien Liquido: "
        '
        'cboRepartidor
        '
        Me.cboRepartidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRepartidor.Location = New System.Drawing.Point(122, 200)
        Me.cboRepartidor.Name = "cboRepartidor"
        Me.cboRepartidor.Size = New System.Drawing.Size(228, 21)
        Me.cboRepartidor.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Quien Repartio: "
        '
        'FrmMotivoAnula
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboRepartidor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboLiquidador)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboTipoRechazo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtObserv)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.CboTipAnul)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmMotivoAnula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Motivo de Anulacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        VCdTipoAnula = CboTipAnul.SelectedValue

        VCdLiquidador = cboLiquidador.SelectedValue
        VCdRepartidor = cboRepartidor.SelectedValue
        VCdTipoRechazo = cboTipoRechazo.SelectedValue



        VObserv = TxtObserv.Text

        If txtmonto.Text.Length = 0 Then
            txtmonto.Text = 0
        End If
        VDescTotbas = CDbl(txtmonto.Text)
        Me.Close()
    End Sub

    Private Sub FrmMotivoAnula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CboTipAnul.DataSource = TmpListarDatos("NSP_LISTAR_TIPOANULACION  '" & codempresa & "'")
        CboTipAnul.DisplayMember = "DESCRIPCION"
        CboTipAnul.ValueMember = "CODIGO"

        cboTipoRechazo.DataSource = TmpListarDatos("NSP_LISTAR_Tipo_Rechazo  '" & codempresa & "'")
        cboTipoRechazo.DisplayMember = "DESCRIPCION"
        cboTipoRechazo.ValueMember = "Id"

        cboLiquidador.DataSource = TmpListarDatos("NSP_LISTAR_Liquidador  '" & codempresa & "'")
        cboLiquidador.DisplayMember = "DESCRIPCION"
        cboLiquidador.ValueMember = "Id"

        cboRepartidor.DataSource = TmpListarDatos("NSP_LISTAR_Repartidor  '" & codempresa & "'")
        cboRepartidor.DisplayMember = "DESCRIPCION"
        cboRepartidor.ValueMember = "Id"


    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtmonto_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonto.KeyPress
        If Char.IsControl(CType(e.KeyChar, Char)) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Or e.KeyChar.ToString = "." Then
            If e.KeyChar.ToString = "." Then
                For cont As Integer = 0 To CType(sender, TextBox).Text.Length - 1
                    If CType(sender, TextBox).Text.Chars(cont).ToString = "." Then
                        e.Handled = True
                        Exit For
                    End If
                Next
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

 
    Private Sub txtmonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmonto.TextChanged

    End Sub
End Class
