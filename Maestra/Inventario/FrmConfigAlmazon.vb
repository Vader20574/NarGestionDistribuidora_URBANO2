Public Class FrmConfigAlmazon
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbZona As System.Windows.Forms.ComboBox
    Friend WithEvents cbAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgAlmacen As System.Windows.Forms.DataGrid
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents TablaEstilo As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CDZONA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CDALMACEN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESZONA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESALMANCEN As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbAlmacen = New System.Windows.Forms.ComboBox
        Me.cbZona = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dgAlmacen = New System.Windows.Forms.DataGrid
        Me.TablaEstilo = New System.Windows.Forms.DataGridTableStyle
        Me.CDZONA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CDALMACEN = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESZONA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESALMANCEN = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbAlmacen)
        Me.GroupBox1.Controls.Add(Me.cbZona)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(264, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Escoger Almacen :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbAlmacen
        '
        Me.cbAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAlmacen.Location = New System.Drawing.Point(364, 18)
        Me.cbAlmacen.Name = "cbAlmacen"
        Me.cbAlmacen.Size = New System.Drawing.Size(148, 21)
        Me.cbAlmacen.TabIndex = 1
        '
        'cbZona
        '
        Me.cbZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbZona.Location = New System.Drawing.Point(96, 18)
        Me.cbZona.Name = "cbZona"
        Me.cbZona.Size = New System.Drawing.Size(158, 21)
        Me.cbZona.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escoger Zona :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.btnQuitar)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.dgAlmacen)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 188)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(438, 110)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 32)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(438, 36)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.TabIndex = 2
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(438, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        '
        'dgAlmacen
        '
        Me.dgAlmacen.DataMember = ""
        Me.dgAlmacen.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgAlmacen.Location = New System.Drawing.Point(26, 16)
        Me.dgAlmacen.Name = "dgAlmacen"
        Me.dgAlmacen.ReadOnly = True
        Me.dgAlmacen.Size = New System.Drawing.Size(376, 160)
        Me.dgAlmacen.TabIndex = 0
        Me.dgAlmacen.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstilo})
        '
        'TablaEstilo
        '
        Me.TablaEstilo.DataGrid = Me.dgAlmacen
        Me.TablaEstilo.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CDZONA, Me.CDALMACEN, Me.DESZONA, Me.DESALMANCEN})
        Me.TablaEstilo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstilo.MappingName = ""
        Me.TablaEstilo.ReadOnly = True
        '
        'CDZONA
        '
        Me.CDZONA.Format = ""
        Me.CDZONA.FormatInfo = Nothing
        Me.CDZONA.MappingName = ""
        Me.CDZONA.Width = 0
        '
        'CDALMACEN
        '
        Me.CDALMACEN.Format = ""
        Me.CDALMACEN.FormatInfo = Nothing
        Me.CDALMACEN.MappingName = ""
        Me.CDALMACEN.Width = 0
        '
        'DESZONA
        '
        Me.DESZONA.Format = ""
        Me.DESZONA.FormatInfo = Nothing
        Me.DESZONA.HeaderText = "Zona"
        Me.DESZONA.MappingName = ""
        Me.DESZONA.Width = 150
        '
        'DESALMANCEN
        '
        Me.DESALMANCEN.Format = ""
        Me.DESALMANCEN.FormatInfo = Nothing
        Me.DESALMANCEN.HeaderText = "Almacen"
        Me.DESALMANCEN.MappingName = ""
        Me.DESALMANCEN.Width = 150
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(438, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 28)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Salir"
        '
        'FrmConfigAlmazon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(524, 242)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmConfigAlmazon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfigAlmazon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private TablaDataAux As New DataTable
    Private Sub FrmConfigAlmazon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conecta("SELECT * FROM ZONA WHERE CODEMPRESA ='" & codempresa.Trim & "'", "dt2")
        Dim TablaZona As New DataTable
        TablaZona = ds.Tables("dt2")
        Me.cbZona.DisplayMember = "deszona"
        Me.cbZona.ValueMember = "codzona"
        Me.cbZona.DataSource = TablaZona
        Conecta("SELECT * FROM ALMACEN WHERE CODEMPRESA ='" & codempresa.Trim & "'", "dt3")
        Dim TablaAlmacen As New DataTable
        TablaAlmacen = ds.Tables("dt3")
        Me.cbAlmacen.DisplayMember = "DESALMACEN"
        Me.cbAlmacen.ValueMember = "CODALMACEN"
        Me.cbAlmacen.DataSource = TablaAlmacen
        'Conecta("SELECT * FROM ALMAZON WHERE CODEMPRESA = '" & codempresa.Trim & "'", "TR")
        TablaDataAux = CAyuda.ListarDatos("NSP_LISTAR_ALMAZON", codempresa.Trim).Tables(0)
        TablaEstilo.MappingName = TablaDataAux.TableName
        TablaEstilo.GridColumnStyles(0).MappingName = "CDZONA"
        TablaEstilo.GridColumnStyles(1).MappingName = "CDALMACEN"
        TablaEstilo.GridColumnStyles(2).MappingName = "DESZONA"
        TablaEstilo.GridColumnStyles(3).MappingName = "DESALMACEN"
        Me.dgAlmacen.TableStyles.Add(TablaEstilo)
        Me.dgAlmacen.DataSource = TablaDataAux

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        For ContX As Integer = 0 To TablaDataAux.Rows.Count - 1
            If TablaDataAux.Rows(ContX)("CDZONA").ToString.Trim = Me.cbZona.SelectedValue.ToString.Trim And TablaDataAux.Rows(ContX)("CDALMACEN").ToString.Trim = Me.cbAlmacen.SelectedValue.ToString.Trim Then
                MsgBox("EL REGISTRO YA EXITE...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If
        Next
        Dim FilaT As DataRow = TablaDataAux.NewRow
        FilaT("CDZONA") = Me.cbZona.SelectedValue.ToString.Trim
        FilaT("DESZONA") = Me.cbZona.Text.Trim
        FilaT("CDALMACEN") = Me.cbAlmacen.SelectedValue.ToString.Trim
        FilaT("DESALMACEN") = Me.cbAlmacen.Text.Trim
        TablaDataAux.Rows.Add(FilaT)
        TablaDataAux.AcceptChanges()
        Me.dgAlmacen.DataSource = TablaDataAux
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        For ContZ As Integer = 0 To TablaDataAux.Rows.Count - 1
            If TablaDataAux.Rows(ContZ)("CDZONA").ToString.Trim = dgAlmacen(dgAlmacen.CurrentRowIndex, 0).ToString.Trim And TablaDataAux.Rows(ContZ)("CDALMACEN").ToString.Trim = dgAlmacen(dgAlmacen.CurrentRowIndex, 1).ToString.Trim Then
                TablaDataAux.Rows.RemoveAt(ContZ)
                Exit For
            End If
        Next
        Me.dgAlmacen.DataSource = TablaDataAux
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        CAyuda.Ejecutar("NSP_DELETE_ALMAZON", codempresa.Trim)
        For ContM As Integer = 0 To TablaDataAux.Rows.Count - 1
            CAyuda.Ejecutar("NSP_INSERT_ALMAZON", TablaDataAux.Rows(ContM)("CDZONA").ToString.Trim, TablaDataAux.Rows(ContM)("CDALMACEN").ToString.Trim, codempresa.Trim)
        Next

        MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")


    End Sub


End Class
