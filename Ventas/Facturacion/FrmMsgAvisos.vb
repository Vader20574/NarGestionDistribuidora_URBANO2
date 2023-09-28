Public Class FrmMsgAvisos
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
    Friend WithEvents lbTitutlo As System.Windows.Forms.Label
    Friend WithEvents lbCuerpo As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbTitutlo = New System.Windows.Forms.Label
        Me.lbCuerpo = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbTitutlo
        '
        Me.lbTitutlo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTitutlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitutlo.Location = New System.Drawing.Point(4, 4)
        Me.lbTitutlo.Name = "lbTitutlo"
        Me.lbTitutlo.Size = New System.Drawing.Size(434, 56)
        Me.lbTitutlo.TabIndex = 0
        Me.lbTitutlo.Text = "Label1"
        Me.lbTitutlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbCuerpo
        '
        Me.lbCuerpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCuerpo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCuerpo.Location = New System.Drawing.Point(4, 64)
        Me.lbCuerpo.Name = "lbCuerpo"
        Me.lbCuerpo.Size = New System.Drawing.Size(434, 138)
        Me.lbCuerpo.TabIndex = 1
        Me.lbCuerpo.Text = "Label2"
        Me.lbCuerpo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Gray
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAceptar.Location = New System.Drawing.Point(24, 204)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(152, 48)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(250, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 48)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CANCELAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmMsgAvisos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(442, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lbCuerpo)
        Me.Controls.Add(Me.lbTitutlo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMsgAvisos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENSAJE"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public DEVOLVER As Boolean
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        DEVOLVER = True
        Me.Close()
    End Sub
    Private Sub FrmMsgAvisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If VCdTipoDoc = CDBOLETA Then
            lbTitutlo.Text = "BOLETA"
        ElseIf VCdTipoDoc = CDFACTURA Then
            lbTitutlo.Text = "FACTURA"
        ElseIf VCdTipoDoc = CDNTAPEDIDO Then
            lbTitutlo.Text = "NOTA DE PEDIDO"
        End If


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
