Public Class FrmAnularPedidos
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
    Friend WithEvents btnBusNumPedido As System.Windows.Forms.Button
    Friend WithEvents txtNumPedido As System.Windows.Forms.TextBox
    Friend WithEvents Pedido As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmAnularPedidos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnBusNumPedido = New System.Windows.Forms.Button
        Me.txtNumPedido = New System.Windows.Forms.TextBox
        Me.Pedido = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBusNumPedido)
        Me.GroupBox1.Controls.Add(Me.txtNumPedido)
        Me.GroupBox1.Controls.Add(Me.Pedido)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnBusNumPedido
        '
        Me.btnBusNumPedido.ImageIndex = 5
        Me.btnBusNumPedido.ImageList = Me.ImageList1
        Me.btnBusNumPedido.Location = New System.Drawing.Point(206, 16)
        Me.btnBusNumPedido.Name = "btnBusNumPedido"
        Me.btnBusNumPedido.Size = New System.Drawing.Size(38, 22)
        Me.btnBusNumPedido.TabIndex = 13
        '
        'txtNumPedido
        '
        Me.txtNumPedido.Location = New System.Drawing.Point(90, 16)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(110, 20)
        Me.txtNumPedido.TabIndex = 11
        Me.txtNumPedido.Text = ""
        '
        'Pedido
        '
        Me.Pedido.Location = New System.Drawing.Point(12, 18)
        Me.Pedido.Name = "Pedido"
        Me.Pedido.Size = New System.Drawing.Size(78, 18)
        Me.Pedido.TabIndex = 12
        Me.Pedido.Text = "Num. Pedido : "
        Me.Pedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Num. Pedido : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(110, 20)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Num. Pedido : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmAnularPedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(602, 364)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAnularPedidos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anular Pedido"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnBusNumPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusNumPedido.Click
        Dim fr As New FrmGridPedidosVta
        fr.vieAnula = Me
        fr.ShowDialog()
    End Sub
End Class
