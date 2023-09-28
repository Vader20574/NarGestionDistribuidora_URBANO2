Public Class frmDetalle_FacuracionPedidos
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
    Friend WithEvents GridDetalle As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btncambiar As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GridDetalle = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.btncambiar = New System.Windows.Forms.Button
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridDetalle
        '
        Me.GridDetalle.AllowSorting = False
        Me.GridDetalle.DataMember = ""
        Me.GridDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridDetalle.Location = New System.Drawing.Point(6, 64)
        Me.GridDetalle.Name = "GridDetalle"
        Me.GridDetalle.ReadOnly = True
        Me.GridDetalle.Size = New System.Drawing.Size(694, 282)
        Me.GridDetalle.TabIndex = 2
        Me.GridDetalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridDetalle
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "TIPO DOC"
        Me.DataGridTextBoxColumn6.MappingName = "DSTIPODOC"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "ITEM"
        Me.DataGridTextBoxColumn7.MappingName = "ITEM"
        Me.DataGridTextBoxColumn7.Width = 50
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODARTI"
        Me.DataGridTextBoxColumn1.MappingName = "CODARTI"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn2.MappingName = "DESARTI"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 260
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "#######0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CANTIDAD"
        Me.DataGridTextBoxColumn3.MappingName = "CANTIDAD"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "#######0.00"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "PRECIO"
        Me.DataGridTextBoxColumn4.MappingName = "PRECIO"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "#######0.00"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "IMPORTE"
        Me.DataGridTextBoxColumn5.MappingName = "TOTBAS"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "RUC"
        Me.DataGridTextBoxColumn8.MappingName = "RUC"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "CODTIPODOC"
        Me.DataGridTextBoxColumn9.MappingName = "CODTIPODOC"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(22, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 14)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Seleccionar Todo"
        Me.CheckBox1.Visible = False
        '
        'btncambiar
        '
        Me.btncambiar.Location = New System.Drawing.Point(588, 22)
        Me.btncambiar.Name = "btncambiar"
        Me.btncambiar.Size = New System.Drawing.Size(106, 36)
        Me.btncambiar.TabIndex = 1
        Me.btncambiar.Text = "Cambiar Tipo Documento"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(68, 352)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(106, 36)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar Cambios"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(494, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 36)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        '
        'frmDetalle_FacuracionPedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(706, 392)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.btncambiar)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GridDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDetalle_FacuracionPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Facuracion Pedidos"
        CType(Me.GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public CDTIPODOC_BK As String
    Public CDNTIPODOC As String
    Public TABLE_DETALLE_FACTURACION As New DataTable
    Public DEVOLVER As Boolean
    Dim CDTIOPODOC_T As String = String.Empty



    Private Sub frmDetalle_FacuracionPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar()
    End Sub
    Private Sub Cargar()
        GridDetalle.DataSource = Nothing
        GridDetalle.DataSource = TABLE_DETALLE_FACTURACION
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambiar.Click
        Dim frm As New frmSeleTDoc
        frm.oFrm = Me
        frm.ShowDialog()

        If IsNothing(CDNTIPODOC) = True Then
            Exit Sub
        End If

        For Each fi As DataRow In TABLE_DETALLE_FACTURACION.Rows
            If LTrim(fi.Item("RUC")) = "" Then
                If CDNTIPODOC = CDFACTURA Then
                    MessageBox.Show("- NO SE PUEDE CAMBIAR DE DOCUMENTO (FACTURA)." & vbNewLine & "EL CLIENTE NO TIENE RUC.", "NARSISTEMAS", MessageBoxButtons.OK)
                    Exit Sub
                End If
            End If
        Next

        Dim dt As New DataTable
        For Each fi As DataRow In TABLE_DETALLE_FACTURACION.Rows
            dt = CAyuda.ListarDatos("SP_TIP_DOCUM", codempresa, CDNTIPODOC).Tables(0)
            fi.Item("DSTIPODOC") = dt.Rows(0)(0)
            fi.Item("CODTIPODOC") = CDNTIPODOC
        Next
        CDTIOPODOC_T = CDNTIPODOC
        Cargar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DEVOLVER = False
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        If CDTIOPODOC_T.Trim.Length = 0 Then
            MessageBox.Show("- NO SE REALIZO NINGUN CAMBIO.", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DEVOLVER = False
            Me.Close()
            Exit Sub
        ElseIf CDTIPODOC_BK.Trim = CDTIOPODOC_T.Trim Then
            MessageBox.Show("- NO SE REALIZO NINGUN CAMBIO.", "NARSISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DEVOLVER = False
            Me.Close()
            Exit Sub
        ElseIf MessageBox.Show("- DESEA CAMBIAR EL TIPO DE DOCUMENTO?", "NARSISTEMAS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            DEVOLVER = True
            Me.Close()
        Else
            DEVOLVER = False
            Me.Close()
        End If
    End Sub
End Class
