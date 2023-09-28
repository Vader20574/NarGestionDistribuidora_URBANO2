Public Class frmSeleTDoc
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
    Friend WithEvents lbdocumento As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbdocumento = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lbdocumento
        '
        Me.lbdocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbdocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdocumento.ItemHeight = 55
        Me.lbdocumento.Location = New System.Drawing.Point(0, 0)
        Me.lbdocumento.Name = "lbdocumento"
        Me.lbdocumento.Size = New System.Drawing.Size(468, 114)
        Me.lbdocumento.TabIndex = 0
        '
        'frmSeleTDoc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(468, 120)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbdocumento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSeleTDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo Documento"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dt As New DataTable
    Dim colum As DataColumn
    Dim fila As DataRow
    Public oFrm As New frmDetalle_FacuracionPedidos

    Private Sub frmSeleTDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        colum = New DataColumn
        colum.ColumnName = "CODIGO"
        colum.DataType = Type.GetType("System.String")

        dt.Columns.Add(colum)

        colum = New DataColumn
        colum.ColumnName = "TIPO"
        colum.DataType = Type.GetType("System.String")

        dt.Columns.Add(colum)

        fila = dt.NewRow
        fila(0) = CDBOLETA
        fila(1) = CAyuda.ListarDatos("SP_TIP_DOCUM", codempresa, CDBOLETA).Tables(0).Rows(0)(0)

        dt.Rows.Add(fila)


        fila = dt.NewRow
        fila(0) = CDFACTURA
        fila(1) = CAyuda.ListarDatos("SP_TIP_DOCUM", codempresa, CDFACTURA).Tables(0).Rows(0)(0)

        dt.Rows.Add(fila)

        Me.lbdocumento.DataSource = dt
        lbdocumento.DisplayMember = "TIPO"
        lbdocumento.ValueMember = "CODIGO"
    End Sub

    Private Sub lbdocumento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbdocumento.DoubleClick
        oFrm.CDNTIPODOC = Me.lbdocumento.SelectedValue.ToString
        Me.Close()
    End Sub
End Class
