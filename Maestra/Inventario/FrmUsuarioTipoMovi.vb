Public Class FrmUsuarioTipoMovi
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
    Friend WithEvents Cbousuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents LbldsTipoMovi As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents DgUsuTipMov As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmUsuarioTipoMovi))
        Me.DgUsuTipMov = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnQuitar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnAgregar = New System.Windows.Forms.Button
        Me.LbldsTipoMovi = New System.Windows.Forms.Label
        Me.Cbousuario = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnGuardar = New System.Windows.Forms.Button
        Me.BtnCancelar = New System.Windows.Forms.Button
        CType(Me.DgUsuTipMov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgUsuTipMov
        '
        Me.DgUsuTipMov.CaptionText = "                                    == Eliminar Fila=[F3]=="
        Me.DgUsuTipMov.DataMember = ""
        Me.DgUsuTipMov.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgUsuTipMov.Location = New System.Drawing.Point(6, 88)
        Me.DgUsuTipMov.Name = "DgUsuTipMov"
        Me.DgUsuTipMov.ReadOnly = True
        Me.DgUsuTipMov.Size = New System.Drawing.Size(420, 240)
        Me.DgUsuTipMov.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnQuitar)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Controls.Add(Me.LbldsTipoMovi)
        Me.GroupBox1.Controls.Add(Me.Cbousuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 70)
        Me.GroupBox1.TabIndex = 1
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
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
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
        'Cbousuario
        '
        Me.Cbousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbousuario.Location = New System.Drawing.Point(90, 42)
        Me.Cbousuario.Name = "Cbousuario"
        Me.Cbousuario.Size = New System.Drawing.Size(208, 21)
        Me.Cbousuario.TabIndex = 0
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
        Me.Label1.Location = New System.Drawing.Point(40, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario : "
        '
        'BtnGuardar
        '
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.ImageIndex = 1
        Me.BtnGuardar.ImageList = Me.ImageList1
        Me.BtnGuardar.Location = New System.Drawing.Point(96, 350)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(86, 26)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "      &Guardar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.ImageIndex = 14
        Me.BtnCancelar.ImageList = Me.ImageList1
        Me.BtnCancelar.Location = New System.Drawing.Point(238, 350)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(86, 26)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = " &Salir"
        '
        'FrmUsuarioTipoMovi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(436, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgUsuTipMov)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUsuarioTipoMovi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relacion  Tipo Movimiento -->  Usuario"
        CType(Me.DgUsuTipMov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variable"
    Public DEVOLVER As Boolean
    Public CDTIPOMOV As String
    Private TABLE_USU As New DataTable

#End Region

#Region "Funciones Form"

    Private Sub CargarGrid()
        TABLE_USU = TmpListarDatos("SelectTMP_USERTIPOMOVIxProc  '" & codempresa & "','" & VCorrelInv & "'")
        DgUsuTipMov.DataSource = TABLE_USU
    End Sub
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_USU.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "USERID"
            .HeaderText = "CodUsuario"
            .NullText = ""
            .Width = 100
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "USUARIO"
            .HeaderText = "USUARIO"
            .NullText = ""
            .Width = 250
        End With
        DgUsuTipMov.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2})
        DgUsuTipMov.TableStyles.Add(TableStyle1)
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

    Private Sub FrmUsuarioTipoMovi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.Ejecutar("InsNuevoTMP_USERTIPOMOVIxProc", codempresa, VCorrelInv, CDTIPOMOV)
        CAyuda.CargarDataCombo(Cbousuario, "SP_LISTAR_USUARIO  '" & codempresa & "'", "cdusuario", "usuario")
        CargarGrid()
        FormatoGrid()
    End Sub
    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        CAyuda.Ejecutar("InsTMP_USERTIPOMOVIxProc", VCorrelInv, codempresa, CDTIPOMOV, CStr(Cbousuario.SelectedValue).Trim)
        CargarGrid()
        FormatoGrid()
    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        If TABLE_USU.Rows.Count > 0 Then
            CAyuda.Ejecutar("EliTMP_USERTIPOMOVIxProc", VCorrelInv, codempresa, DgUsuTipMov.Item(DgUsuTipMov.CurrentRowIndex, 0))
            CargarGrid()
            FormatoGrid()
        End If


    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        TmpInsertDatos("DELETE  FROM TMP_USERTIPOMOVI WHERE CODEMPRESA='" & codempresa & "' AND CORRNBR='" & VCorrelInv & "'")
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        DEVOLVER = True
        Me.Close()

    End Sub
End Class
