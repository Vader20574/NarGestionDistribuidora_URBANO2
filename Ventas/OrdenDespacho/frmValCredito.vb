Public Class frmValCredito
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
    Friend WithEvents dgdata As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn4 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.dgdata = New System.Windows.Forms.DataGrid()
		Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
		Me.MenuItem2 = New System.Windows.Forms.MenuItem()
		Me.MenuItem1 = New System.Windows.Forms.MenuItem()
		Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
		Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
		Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
		Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.DataGridBoolColumn4 = New System.Windows.Forms.DataGridBoolColumn()
		Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.dgdata, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(792, 248)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		'
		'dgdata
		'
		Me.dgdata.ContextMenu = Me.ContextMenu1
		Me.dgdata.DataMember = ""
		Me.dgdata.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.dgdata.Location = New System.Drawing.Point(20, 60)
		Me.dgdata.Name = "dgdata"
		Me.dgdata.ReadOnly = True
		Me.dgdata.Size = New System.Drawing.Size(969, 291)
		Me.dgdata.TabIndex = 0
		Me.dgdata.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
		'
		'ContextMenu1
		'
		Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem1})
		'
		'MenuItem2
		'
		Me.MenuItem2.Index = 0
		Me.MenuItem2.Text = "-"
		'
		'MenuItem1
		'
		Me.MenuItem1.Index = 1
		Me.MenuItem1.Text = "&Eliminar"
		'
		'DataGridTableStyle1
		'
		Me.DataGridTableStyle1.DataGrid = Me.dgdata
		Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn2, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn4, Me.DataGridBoolColumn2, Me.DataGridTextBoxColumn5, Me.DataGridBoolColumn4, Me.DataGridTextBoxColumn6, Me.DataGridBoolColumn3})
		Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.DataGridTableStyle1.MappingName = "Table"
		Me.DataGridTableStyle1.ReadOnly = True
		'
		'DataGridTextBoxColumn1
		'
		Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
		Me.DataGridTextBoxColumn1.Format = ""
		Me.DataGridTextBoxColumn1.FormatInfo = Nothing
		Me.DataGridTextBoxColumn1.HeaderText = "#PEDIDO"
		Me.DataGridTextBoxColumn1.MappingName = "NUM_PEDIDO"
		Me.DataGridTextBoxColumn1.Width = 75
		'
		'DataGridTextBoxColumn3
		'
		Me.DataGridTextBoxColumn3.Format = ""
		Me.DataGridTextBoxColumn3.FormatInfo = Nothing
		Me.DataGridTextBoxColumn3.HeaderText = "CLIENTE"
		Me.DataGridTextBoxColumn3.MappingName = "CODCLIENTE"
		Me.DataGridTextBoxColumn3.Width = 160
		'
		'DataGridTextBoxColumn2
		'
		Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn2.Format = "0.00"
		Me.DataGridTextBoxColumn2.FormatInfo = Nothing
		Me.DataGridTextBoxColumn2.HeaderText = "TOTAL"
		Me.DataGridTextBoxColumn2.MappingName = "TOTBAS"
		Me.DataGridTextBoxColumn2.NullText = "0"
		Me.DataGridTextBoxColumn2.Width = 75
		'
		'DataGridBoolColumn1
		'
		Me.DataGridBoolColumn1.HeaderText = "LIMITE CREDITO"
		Me.DataGridBoolColumn1.MappingName = "LINECRED"
		Me.DataGridBoolColumn1.NullValue = "False"
		Me.DataGridBoolColumn1.Width = 90
		'
		'DataGridTextBoxColumn4
		'
		Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn4.Format = "0.00"
		Me.DataGridTextBoxColumn4.FormatInfo = Nothing
		Me.DataGridTextBoxColumn4.HeaderText = "SALDO DISPONIBLE"
		Me.DataGridTextBoxColumn4.MappingName = "SALDODISPOCRE"
		Me.DataGridTextBoxColumn4.NullText = "0"
		Me.DataGridTextBoxColumn4.Width = 75
		'
		'DataGridBoolColumn2
		'
		Me.DataGridBoolColumn2.HeaderText = "SOBREGIRO"
		Me.DataGridBoolColumn2.MappingName = "SOBREGIRO"
		Me.DataGridBoolColumn2.NullText = "0"
		Me.DataGridBoolColumn2.NullValue = "False"
		Me.DataGridBoolColumn2.Width = 90
		'
		'DataGridTextBoxColumn5
		'
		Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn5.Format = "0.00"
		Me.DataGridTextBoxColumn5.FormatInfo = Nothing
		Me.DataGridTextBoxColumn5.HeaderText = "MONTO LIM. CRED."
		Me.DataGridTextBoxColumn5.MappingName = "MTOLIMCRE"
		Me.DataGridTextBoxColumn5.NullText = "0"
		Me.DataGridTextBoxColumn5.Width = 80
		'
		'DataGridBoolColumn4
		'
		Me.DataGridBoolColumn4.HeaderText = "MOROSIDAD"
		Me.DataGridBoolColumn4.MappingName = "DEUDAPEND"
		Me.DataGridBoolColumn4.NullText = "0"
		Me.DataGridBoolColumn4.NullValue = "False"
		Me.DataGridBoolColumn4.Width = 75
		'
		'DataGridTextBoxColumn6
		'
		Me.DataGridTextBoxColumn6.Format = ""
		Me.DataGridTextBoxColumn6.FormatInfo = Nothing
		Me.DataGridTextBoxColumn6.HeaderText = "DIASCRED"
		Me.DataGridTextBoxColumn6.MappingName = "DIASCRED"
		Me.DataGridTextBoxColumn6.NullText = "0"
		Me.DataGridTextBoxColumn6.Width = 75
		'
		'DataGridBoolColumn3
		'
		Me.DataGridBoolColumn3.HeaderText = "EXCESOPEND"
		Me.DataGridBoolColumn3.MappingName = "EXCESOPEND"
		Me.DataGridBoolColumn3.NullText = "0"
		Me.DataGridBoolColumn3.NullValue = "False"
		Me.DataGridBoolColumn3.Width = 75
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(16, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(451, 31)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Detalles - Linea Credito - Sobregiros - Deudas Mayores"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(539, 20)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(158, 34)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Aceptar"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'frmValCredito
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(1013, 429)
		Me.Controls.Add(Me.dgdata)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmValCredito"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "DETALLE CREDITOS"
		CType(Me.dgdata, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region
	Public CORREL As Integer
    Public frm As New FrmCargarPedido_a_Camion
    Dim dt As New DataTable
    Private Sub frmValCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frm.desbloquerDeuda = False
        dt = CAyuda.ListarDatos("SP_CALCUL_CREDITO_PED", codempresa, CORREL, VCdPagCredito, LIMCREDITO, COEFICIENT).Tables(0)
        Me.dgdata.DataSource = dt

    End Sub

    Private Sub dgdata_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdata.Click
        Me.dgdata.Select(Me.dgdata.CurrentRowIndex)
        Dim X As String

        X = dgdata.Item(dgdata.CurrentRowIndex, 1)
        'MsgBox(X)

        Dim frmcred As New FrmDocPlazo

        frmcred.X = X
        'frmcred.CORREL = Me.CORREL
        frmcred.ShowDialog()


    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If MessageBox.Show("- Desea Eliminar el Pedido Seleccionado?.", "NARSISTEMAS", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = DialogResult.Yes Then
            If CAyuda.Ejecutar("SP_ELI_TMP_GUIAINTERNADET", codempresa, CORREL, Me.dgdata.Item(Me.dgdata.CurrentRowIndex, 0)) <> 0 Then
                Me.dt.Rows.RemoveAt(Me.dgdata.CurrentRowIndex)
                Me.dgdata.DataSource = Nothing
                Me.dgdata.DataSource = dt
                frm.CARGARPEDIDOS(False)
                MsgBox("- Se Elimino con Exito.", MsgBoxStyle.Information, "NARSISTEMAS")
            Else
                MsgBox("- El Pedido ya fue Eliminado.", MsgBoxStyle.Information, "NARSISTEMAS")
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm.desbloquerDeuda = True
        Me.Close()

    End Sub

    Private Sub dgdata_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dgdata.Navigate

    End Sub
End Class
