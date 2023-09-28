Public Class FRMINGXTRANSFER
    Inherits System.Windows.Forms.Form
    Public objfrming_otros As New frm_guiaing_otros
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtDoc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDoc1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.txtDoc2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDoc1 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 10)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(472, 208)
        Me.DataGrid1.TabIndex = 0
        '
        'txtDoc2
        '
        Me.txtDoc2.Location = New System.Drawing.Point(8, 13)
        Me.txtDoc2.MaxLength = 7
        Me.txtDoc2.Name = "txtDoc2"
        Me.txtDoc2.Size = New System.Drawing.Size(112, 20)
        Me.txtDoc2.TabIndex = 1
        Me.txtDoc2.Text = ""
        Me.txtDoc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese el Nro de Documento de Referencia :"
        '
        'txtDoc1
        '
        Me.txtDoc1.Location = New System.Drawing.Point(8, 13)
        Me.txtDoc1.MaxLength = 3
        Me.txtDoc1.Name = "txtDoc1"
        Me.txtDoc1.Size = New System.Drawing.Size(56, 20)
        Me.txtDoc1.TabIndex = 1
        Me.txtDoc1.Text = ""
        Me.txtDoc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDoc2)
        Me.GroupBox1.Location = New System.Drawing.Point(104, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 224)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDoc1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(72, 40)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRMINGXTRANSFER
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 294)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMINGXTRANSFER"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos por Transferencia"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FRMINGXTRANSFER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FORMATOGRID()
        Call CARGAR()
    End Sub
    Private Sub FORMATOGRID()

        Dim dgEstiloColumna As New DataGridTableStyle
        With dgEstiloColumna
            .HeaderFont = New System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            .MappingName = "table"
            .PreferredRowHeight = 15
        End With
        Dim ColEStilo1 As New DataGridTextBoxColumn
        With ColEStilo1
            .HeaderText = "MOVIMIENTO"
            .MappingName = "MOVIMIENTO"
            .Width = 100
            .ReadOnly = True
        End With

        Dim ColEStilo2 As New DataGridTextBoxColumn
        With ColEStilo2
            .HeaderText = "NRO. DOCUMENTO"
            .MappingName = "NRODOC"
            .Width = 120
            .ReadOnly = True
        End With

        Dim ColEStilo3 As New DataGridTextBoxColumn
        With ColEStilo3
            .HeaderText = "DOC. REFERENCIA"
            .MappingName = "NRODOCREF"
            .Width = 120
            .ReadOnly = True
        End With

        Dim ColEStilo4 As New DataGridTextBoxColumn
        With ColEStilo4
            .HeaderText = "FECHA"
            .MappingName = "FECDOCUM"
            .Width = 80
            .ReadOnly = True
        End With

        ' Agregar los estilos de las columnas al estilo del Grid
        dgEstiloColumna.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
          {ColEStilo1, ColEStilo2, ColEStilo3, ColEStilo4})
        Me.DataGrid1.TableStyles.Add(dgEstiloColumna)
    End Sub
    Private Sub CARGAR()
        'Dim CLSINTER As New ClsInterface
        Dim dato As String = ""
        If txtDoc1.Text.Trim <> "" Or txtDoc2.Text.Trim <> "" Then
            dato = txtDoc1.Text.Trim + "-" + txtDoc2.Text.Trim
        End If
        DataGrid1.DataSource = CAyuda.ListarDatos("SP_LISTAR_INGRESOXTRANSFER", dato, objfrming_otros.calmacen.SelectedValue).Tables(0)
    End Sub


    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Call devuelve()
    End Sub
    Private Sub devuelve()
        If Me.DataGrid1.CurrentRowIndex <> -1 Then
            objfrming_otros.TxtDocRef1.Text = Strings.Left(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2), 3)
            objfrming_otros.TREF.Text = Strings.Right(Trim(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2)), 7)
            Me.Close()
        End If
    End Sub
    Private Sub FRMINGXTRANSFER_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.txtDoc2.Focus()
    End Sub
End Class
