Public Class FrmTipoMovAlmacen
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DgDocTipMov As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents LbldsTipoMovi As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents CboAlmacen As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTipoMovAlmacen))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DgDocTipMov = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnQuitar = New System.Windows.Forms.Button
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.LbldsTipoMovi = New System.Windows.Forms.Label
        Me.CboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        CType(Me.DgDocTipMov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DgDocTipMov
        '
        Me.DgDocTipMov.CaptionText = "                                    == Eliminar Fila=[F3]=="
        Me.DgDocTipMov.DataMember = ""
        Me.DgDocTipMov.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgDocTipMov.Location = New System.Drawing.Point(6, 84)
        Me.DgDocTipMov.Name = "DgDocTipMov"
        Me.DgDocTipMov.ReadOnly = True
        Me.DgDocTipMov.Size = New System.Drawing.Size(420, 240)
        Me.DgDocTipMov.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnQuitar)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.LbldsTipoMovi)
        Me.GroupBox1.Controls.Add(Me.CboAlmacen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 70)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'BtnQuitar
        '
        Me.BtnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuitar.ImageIndex = 3
        Me.BtnQuitar.ImageList = Me.ImageList1
        Me.BtnQuitar.Location = New System.Drawing.Point(328, 42)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.TabIndex = 5
        Me.BtnQuitar.Text = "&Quitar"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.ImageIndex = 13
        Me.BtnAgregar.ImageList = Me.ImageList1
        Me.BtnAgregar.Location = New System.Drawing.Point(328, 14)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "    &Agregar"
        '
        'LbldsTipoMovi
        '
        Me.LbldsTipoMovi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbldsTipoMovi.Location = New System.Drawing.Point(94, 12)
        Me.LbldsTipoMovi.Name = "LbldsTipoMovi"
        Me.LbldsTipoMovi.Size = New System.Drawing.Size(230, 24)
        Me.LbldsTipoMovi.TabIndex = 3
        Me.LbldsTipoMovi.Text = "Ingreso por Compra"
        Me.LbldsTipoMovi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CboAlmacen
        '
        Me.CboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboAlmacen.Location = New System.Drawing.Point(90, 42)
        Me.CboAlmacen.Name = "CboAlmacen"
        Me.CboAlmacen.Size = New System.Drawing.Size(208, 21)
        Me.CboAlmacen.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo Movimiento :  "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Almacen : "
        '
        'BtnGuardar
        '
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.ImageIndex = 1
        Me.BtnGuardar.ImageList = Me.ImageList1
        Me.BtnGuardar.Location = New System.Drawing.Point(96, 346)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(86, 26)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "      &Guardar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 14
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(238, 346)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(86, 26)
        Me.BtnCancelar.TabIndex = 11
        Me.BtnCancelar.Text = " &Salir"
        '
        'FrmTipoMovAlmacen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 384)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.DgDocTipMov)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmTipoMovAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacion Tipo Movimiento -->  Almacen"
        CType(Me.DgDocTipMov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "Variable"
    Public DEVOLVER As Boolean
    Public CDTIPOMOV As String
    Private TABLE_DOC As New DataTable

#End Region

#Region "Funciones Form"

    Private Sub CargarGrid()
        TABLE_DOC = TmpListarDatos("SelecTMP_TIPOMOVIALMACxproc  '" & codempresa & "','" & VCorrelInv & "'")
        DgDocTipMov.DataSource = TABLE_DOC
    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_DOC.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODALMACEN"
            .HeaderText = "CODALMACEN"
            .NullText = ""
            .Width = 100
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "DESALMACEN"
            .HeaderText = "DESALMACEN"
            .NullText = ""
            .Width = 250
        End With
        DgDocTipMov.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2})
        DgDocTipMov.TableStyles.Add(TableStyle1)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104
        Dim Sender As Object = Nothing
        Dim e As EventArgs = Nothing

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.F3
                    BtnQuitar_Click(Sender, e)
                Case Keys.Escape
                    BtnCancelar_Click(Sender, e)
            End Select
        End If

    End Function

#End Region

    Private Sub FrmTipoMovAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.Ejecutar("InsNuevoTMP_TIPOMOVIALMACxProc", VCorrelInv, codempresa, CDTIPOMOV)
        CAyuda.CargarDataCombo(CboAlmacen, "USP_LLENAR_ALMACEN   '" & codempresa & "'", "Codigo", "Descripcion")
        CargarGrid()
        FormatoGrid()
    End Sub
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        CAyuda.Ejecutar("InsTMP_TIPOMOVIALMACxProc", VCorrelInv, codempresa, CDTIPOMOV, CStr(CboAlmacen.SelectedValue).Trim)
        CargarGrid()
        FormatoGrid()
    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        If TABLE_DOC.Rows.Count > 0 Then
            CAyuda.Ejecutar("EliTMP_TIPOMOVIALMACxProc", VCorrelInv, codempresa, DgDocTipMov.Item(DgDocTipMov.CurrentRowIndex, 0))
            CargarGrid()
            FormatoGrid()
        End If

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TmpInsertDatos("DELETE  FROM TMP_TIPOMOVIALMAC WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & VCorrelInv & "'")
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        DEVOLVER = True
        Me.Close()

    End Sub

    
End Class
