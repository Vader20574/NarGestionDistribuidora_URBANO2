Public Class frmgridarticulo
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.txtdato = New System.Windows.Forms.TextBox
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registros de Articulos "
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(4, 62)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(616, 334)
        Me.Grid1.TabIndex = 1
        Me.Grid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Grid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "cliente"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "codigo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 110
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Artículo"
        Me.DataGridTextBoxColumn2.MappingName = "apellidop"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 420
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.txtdato)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Filtro [F1]"
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Location = New System.Drawing.Point(16, 38)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(82, 15)
        Me.rbdescripcion.TabIndex = 7
        Me.rbdescripcion.Text = "Descripcion "
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(16, 17)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(78, 15)
        Me.rbcodigo.TabIndex = 6
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo "
        '
        'txtdato
        '
        Me.txtdato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdato.Location = New System.Drawing.Point(144, 24)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(434, 21)
        Me.txtdato.TabIndex = 0
        Me.txtdato.Text = ""
        '
        'frmgridarticulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(650, 412)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Grid1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(656, 440)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(656, 440)
        Me.Name = "frmgridarticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Articulos "
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Public frmA As FrmMantenimientoPromociones
    Public FrmB As FrmPedido
    Public FrmC As FrmEditarDocumento_enOrdenDespacho
    Public TipoArti As Integer
    'Private Obj As New ClsInterface
    Public DEVOLVER As Boolean
    Public TABLE_ARTI As New DataTable
    Private Samira As Boolean

#End Region

#Region "FUNCIONES"


    Public Sub CargarGrid()
        TABLE_ARTI = TmpListarDatos("sp_sele_arti '" & codempresa & "','" & txtdato.Text.Trim.ToUpper & "',''")
        Grid1.DataSource = TABLE_ARTI
    End Sub

    Public Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TABLE_ARTI.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))

        End With

        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "codigo"
            .NullText = ""
            .Width = 100
            .HeaderText = "Codigo"
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "apellidop"
            .NullText = ""
            .Width = 350
            .HeaderText = "Descripcion"
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColumn1, DataColumn2})
        Grid1.TableStyles.Add(TableStyle1)

    End Sub



#End Region


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const SYS_KEYDOWN As Integer = &H100
        Const SYSTEM_KEY As Integer = &H104
        If ((MSG.Msg = SYS_KEYDOWN) Or (MSG.Msg = SYSTEM_KEY)) Then
            'If Me.txtdato.Focus Then
            If KeyData = Keys.F1 Then
                If Me.rbcodigo.Checked Then
                    Me.rbdescripcion.Checked = True
                Else
                    Me.rbcodigo.Checked = True
                End If
                Me.txtdato.Focus()
            End If
            If KeyData = Keys.Enter Then
                If Me.Grid1.Focus Then
                    Dim Sender As System.Object = Nothing
                    Dim e As System.EventArgs = Nothing
                    grid1_DoubleClick(Sender, e)

                End If
            End If

        End If
    End Function

    Private Sub frmgridciudad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If Not FrmB Is Nothing Then
            Dim VarCodFv As String
            Conecta("SELECT COD_FV FROM VENDEDOR WHERE CODEMPRESA ='" & codempresa & "' AND CODVEND='" & FrmB.CboVended.SelectedValue.Trim & "'", "TabF")
            VarCodFv = ds.Tables("TabF").Rows(0)(0)
            Try
                Dim VarCodTipoPrecio As String
                Conecta("SELECT CODTIPOPRE FROM CLIENTE WHERE CODEMPRESA ='" & codempresa.Trim & "' AND CODCLIENTE = '" & FrmB.txtCodCliente.Text.Trim & "' ", "DSR")
                VarCodTipoPrecio = ds.Tables("DSR").Rows(0)(0)
                Conecta("sp_sele_arti_X_FZAVTA_LINEA2 '" & codempresa & "','" & VarCodFv.Trim & "','" & VarCodTipoPrecio & "'", "llena")
            Catch ex As Exception
                MsgBox("El cliente no tiene una lista de precio asignada.", MsgBoxStyle.Information)
                Me.Close()
            End Try
        Else
            If Not FrmC Is Nothing Then
                Dim VarCodTipoPrecio As String
                Conecta("SELECT TOP 1 CODTIPOPRE  FROM CLIENTE	WHERE CODCLIENTE IN (SELECT TOP 1 CODCLIENTE FROM CLIDIR  WHERE  CODDIRCLI='" & FrmC.CODCLIENTE.Trim & "' AND CODEMPRESA='" & codempresa.Trim & "') AND CODEMPRESA = '" & codempresa.Trim & "'", "DSR")
                VarCodTipoPrecio = ds.Tables("DSR").Rows(0)(0)
                Conecta("sp_sele_arti_X_FZAVTA_LINEA '" & codempresa & "','" & VarCodTipoPrecio & "'", "llena")
            Else

            End If
        End If
        CargarGrid()
        FormatoGrid()
        Me.txtdato.Focus()

    End Sub
    Private Sub grid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        pasadatos()
    End Sub
    Private Sub txtdato_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = 13 Then
            pasadatos()
        End If
    End Sub
    Sub pasadatos()
        DEVOLVER = True
        If Not FrmB Is Nothing Then
            FrmB.txtArticulo.Text = Grid1.Item(Grid1.CurrentRowIndex, 0)
            FrmB.lblArticulo.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
            Dim TablaComboPresent As New DataTable
            TablaComboPresent = CAyuda.ListarDatos("NSP_LISTAR_PRESENT_ARTI_FACT", codempresa, Grid1.Item(Grid1.CurrentRowIndex, 0).ToString.Trim, FrmB.CodTipoPrecio).Tables(0)
            FrmB.cbTipoPresent.DataSource = TablaComboPresent
            FrmB.cbTipoPresent.DisplayMember = "DESPRES"
            FrmB.cbTipoPresent.ValueMember = "CODPRES"
            Me.Close()
            Exit Sub
        End If
        If Not FrmC Is Nothing Then
            'FrmC.txtArticulo.Text = Grid1.Item(Grid1.CurrentRowIndex, 0)
            'FrmC.lblArticulo.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
            'Dim TablaComboPresent As New DataTable
            'TablaComboPresent = Obj.ListarDatos("NSP_LISTAR_PRESENT_ARTI", codempresa, Grid1.Item(Grid1.CurrentRowIndex, 0).ToString.Trim, FrmC.CODCLIENTE.Trim).Tables(0)
            'FrmC.cbTipoPresent.DisplayMember = "DESPRES"
            'FrmC.cbTipoPresent.ValueMember = "CODPRES"
            'FrmC.cbTipoPresent.DataSource = TablaComboPresent
            Me.Close()
            Exit Sub
        End If


        If Not frmA Is Nothing Then
            Select Case TipoArti
                Case 1
                    frmA.txtProdVtaCod.Text = Grid1.Item(Grid1.CurrentRowIndex, 0)
                    frmA.lbProductoVta.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
                Case 2
                    frmA.txtProdPromoCod.Text = Grid1.Item(Grid1.CurrentRowIndex, 0)
                    frmA.lbProductoPromo.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
            End Select
            Me.Close()
            Exit Sub
        End If

        ' Dim FRM As New frmarticulos
        Try
            VAR1 = Grid1.Item(Grid1.CurrentRowIndex, 0)
            'Dim obj As New frmarticulos
            'obj.mostrar()
            Samira = True
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        If rbcodigo.Checked = True Then
            TABLE_ARTI = TmpListarDatos("sp_sele_arti '" & codempresa & "','" & txtdato.Text.Trim.ToUpper & "','1'")
            Grid1.DataSource = TABLE_ARTI
        End If

        If rbdescripcion.Checked = True Then
            TABLE_ARTI = TmpListarDatos("sp_sele_arti '" & codempresa & "','" & txtdato.Text.Trim.ToUpper & "','2'")
            Grid1.DataSource = TABLE_ARTI
        End If

    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    Private Sub rbcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcodigo.CheckedChanged

    End Sub

    Private Sub rbdescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbdescripcion.CheckedChanged

    End Sub
End Class
