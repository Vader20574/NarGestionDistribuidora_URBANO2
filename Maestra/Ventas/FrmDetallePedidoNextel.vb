Public Class FrmDetallePedidoNextel
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New System.Windows.Forms.DataGrid
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de Pedidos Nextel"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(16, 16)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(664, 218)
        Me.Grid1.TabIndex = 25
        '
        'FrmDetallePedidoNextel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 250)
        Me.Controls.Add(Me.Grid1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetallePedidoNextel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDetallePedido"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public CODPEDIDO As String
    Private Sub FrmDetallePedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargagridDetPedidosNextel(Grid1, "SP_LISTA_TBL_DETALLE '" & VCODNEXTEL & "','" & CODPEDIDO & "'")

    End Sub
End Class
