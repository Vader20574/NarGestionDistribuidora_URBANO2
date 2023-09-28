Public Class FrmBusquedaDeCliente
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
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents RdbRuc As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBusquedaDeCliente))
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdbRuc = New System.Windows.Forms.RadioButton
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        Me.Grid1.Location = New System.Drawing.Point(12, 56)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(770, 309)
        Me.Grid1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbRuc)
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(706, 38)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'RdbRuc
        '
        Me.RdbRuc.Location = New System.Drawing.Point(554, 14)
        Me.RdbRuc.Name = "RdbRuc"
        Me.RdbRuc.Size = New System.Drawing.Size(62, 16)
        Me.RdbRuc.TabIndex = 4
        Me.RdbRuc.Text = "Ruc"
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Checked = True
        Me.rbdescripcion.Location = New System.Drawing.Point(414, 14)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(110, 16)
        Me.rbdescripcion.TabIndex = 3
        Me.rbdescripcion.TabStop = True
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Location = New System.Drawing.Point(338, 14)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 16)
        Me.rbcodigo.TabIndex = 2
        Me.rbcodigo.Text = "Codigo"
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(52, 12)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(277, 20)
        Me.txtdato.TabIndex = 0
        Me.txtdato.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dato : "
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(706, 368)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(8, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FrmBusquedaDeCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 442)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Grid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaDeCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Cliente"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "FIELDS"
    Dim TABLE_CLIENT As New DataTable
    Public DEVOLVER As Boolean


#End Region

#Region "FUNCIONES"

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WINDKEYDON As Integer = &H100
        Const WINDKEYSISTEM As Integer = &H104
        If ((MSG.Msg = WINDKEYDON) Or (MSG.Msg = WINDKEYSISTEM)) Then
            Select Case KeyData
                Case Keys.Enter
                    If Grid1.Focus = True Then
                        DEVOLVER = True
                        Me.Close()
                    End If
            End Select
        End If


    End Function


    Sub CargarGrid()
        TABLE_CLIENT = TmpListarDatos("NSP_LISTAR_CLIENTE  '" & codempresa & "'")
        Grid1.DataSource = TABLE_CLIENT
        FormatoGrid()

    End Sub

    Sub FormatoGrid()
        Dim DataGridTableStyle1 As New DataGridTableStyle
        With DataGridTableStyle1
            .MappingName = TABLE_CLIENT.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "CODCLIENTE"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 100
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "DATOADJUNTO"
            .HeaderText = "Apell./Rz Social"
            .NullText = ""
            .Width = 250
        End With
        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "RUC"
            .HeaderText = "Documento"
            .NullText = ""
            .Width = 100
        End With
        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "DIRECCION"
            .HeaderText = "Direccion"
            .NullText = ""
            .Width = 300
        End With

        Dim DataColumn5 As New DataGridTextBoxColumn
        With DataColumn5
            .MappingName = "RUTA"
            .HeaderText = "CODRUTA"
            .NullText = ""
            .Width = 0
        End With

        DataGridTableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5})
        Grid1.TableStyles.Add(DataGridTableStyle1)

    End Sub
#End Region
    Private Sub FrmBusquedaDeCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()

    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        For i As Integer = 0 To TABLE_CLIENT.Rows.Count - 1
            Grid1.UnSelect(i)
        Next

        If rbcodigo.Checked = True Then
            For i As Integer = 0 To TABLE_CLIENT.Rows.Count - 1
                If (Mid((Grid1.Item(i, 0).tostring.Trim).ToUpper, 1, txtdato.Text.Trim.Length)) = txtdato.Text.Trim Then
                    Grid1.CurrentRowIndex = i
                    Grid1.Select(i)
                    Exit Sub
                End If
            Next
        ElseIf rbdescripcion.Checked = True Then
            For i As Integer = 0 To TABLE_CLIENT.Rows.Count - 1
                If (Mid((Grid1.Item(i, 1).tostring.Trim).ToUpper, 1, txtdato.Text.Trim.Length)) = txtdato.Text.Trim Then
                    Grid1.CurrentRowIndex = i
                    Grid1.Select(i)
                    Exit Sub
                End If
            Next
        ElseIf RdbRuc.Checked = True Then
            For i As Integer = 0 To TABLE_CLIENT.Rows.Count - 1
                If (Mid((Grid1.Item(i, 2).tostring.Trim).ToUpper, 1, txtdato.Text.Trim.Length)) = txtdato.Text.Trim Then
                    Grid1.CurrentRowIndex = i
                    Grid1.Select(i)
                    Exit Sub
                End If
            Next
        End If

    End Sub
End Class
