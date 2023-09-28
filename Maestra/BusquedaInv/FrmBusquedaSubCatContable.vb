Public Class FrmBusquedaSubCatContable
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
    Friend WithEvents Grplistado As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents Grid1 As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grplistado = New System.Windows.Forms.GroupBox
        Me.Grid1 = New System.Windows.Forms.DataGrid
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Grplistado.SuspendLayout()
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grplistado
        '
        Me.Grplistado.Controls.Add(Me.Grid1)
        Me.Grplistado.Controls.Add(Me.rbdescripcion)
        Me.Grplistado.Controls.Add(Me.rbcodigo)
        Me.Grplistado.Controls.Add(Me.Label3)
        Me.Grplistado.Controls.Add(Me.txtdato)
        Me.Grplistado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grplistado.Location = New System.Drawing.Point(2, 0)
        Me.Grplistado.Name = "Grplistado"
        Me.Grplistado.Size = New System.Drawing.Size(480, 240)
        Me.Grplistado.TabIndex = 21
        Me.Grplistado.TabStop = False
        '
        'Grid1
        '
        Me.Grid1.BackgroundColor = System.Drawing.Color.Gray
        Me.Grid1.CaptionText = "Registro de SubCategoria"
        Me.Grid1.DataMember = ""
        Me.Grid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Grid1.Location = New System.Drawing.Point(16, 62)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.ReadOnly = True
        Me.Grid1.Size = New System.Drawing.Size(448, 166)
        Me.Grid1.TabIndex = 24
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(376, 28)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(82, 20)
        Me.rbdescripcion.TabIndex = 5
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(302, 28)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dato : "
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(60, 24)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(216, 21)
        Me.txtdato.TabIndex = 1
        Me.txtdato.Text = ""
        '
        'FrmBusquedaSubLinea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(486, 244)
        Me.Controls.Add(Me.Grplistado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaSubLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda SubCategoria"
        Me.Grplistado.ResumeLayout(False)
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Public Frm As FrmSubCatContable
    'Private ObjBus As New ClsInterface
    Private tblImp As New DataTable
#End Region
#Region "Funciones del formulario"
    'Sub FormatGrid()
    '    Dim grdTableStyle1 As New DataGridTableStyle
    '    With grdTableStyle1
    '        .MappingName = tblImp.TableName
    '        .PreferredColumnWidth = 125
    '        .PreferredRowHeight = 15
    '    End With
    '    Dim grdColStyle1 As New DataGridTextBoxColumn
    '    With grdColStyle1
    '        .MappingName = "CODSUBLINEA"
    '        .HeaderText = "Código"
    '        .Width = 80
    '    End With

    '    Dim grdColStyle2 As New DataGridTextBoxColumn
    '    With grdColStyle2
    '        .MappingName = "DESSUBLINEA"
    '        .HeaderText = "Descripción"
    '        .Width = 280
    '    End With
    '    Dim grdColStyle3 As New DataGridTextBoxColumn
    '    With grdColStyle3
    '        .HeaderText = "CODLINEA"
    '        .MappingName = "CODLINEA"
    '        .Width = 0
    '    End With
    '    Dim grdColStyle4 As New DataGridTextBoxColumn
    '    With grdColStyle4
    '        .HeaderText = "DESLINEA"
    '        .MappingName = "DESLINEA"
    '        .Width = 0
    '    End With

    '    grdTableStyle1.GridColumnStyles.AddRange _
    '        (New DataGridColumnStyle() _
    '        {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4})
    '    grdsubLinea.TableStyles.Add(grdTableStyle1)


    'End Sub


    Sub EnviarDatosImpuesto()

        Try
            'tblc = ObjBus.ListarDatos("NSP_Select_VerficaCodigoSubLinea", grdsubLinea.Item(grdsubLinea.CurrentRowIndex, 0), codempresa.ToString()).Tables(0)
            Frm.txtcod.Text = Grid1.Item(Grid1.CurrentRowIndex, 0)
            Frm.txtdescripcion.Text = Grid1.Item(Grid1.CurrentRowIndex, 1)
            Frm.CboCat.SelectedValue = Grid1.Item(Grid1.CurrentRowIndex, 2)
            ' Frm.TxtCuenta.Text = Grid1.Item(Grid1.CurrentRowIndex, 3)

            Grplistado.Visible = False
        Catch eqx As Exception
            txtdato.Focus()
            Exit Sub
        End Try
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WIN_KEYDOWN As Integer = &H100
        Const WIN_SYSKEY As Integer = &H104

        If (MSG.Msg = WIN_KEYDOWN) Or (MSG.Msg = WIN_SYSKEY) Then
            Select Case KeyData
                Case Keys.Enter
                    If Grid1.Focus = True Then
                        If tblImp.Rows.Count > 0 Then
                            EnviarDatosImpuesto()
                            Me.Close()

                        End If
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
    End Function

#End Region
    Private Sub grdsubLinea_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EnviarDatosImpuesto()
        Me.Close()
    End Sub
    Private Sub FrmBusquedaSubLinea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' tblImp = CAyuda.ListarDatos("NSP_SelectListadoSubLinea", codempresa.ToString()).Tables(0)
        ' FormatGrid()
        ' Me.grdsubLinea.DataSource = tblImp
        'cmborden.SelectedIndex = 0
        llena()
    End Sub
    Sub llena()
        If Me.txtdato.Text.Trim = "" Then
            If Me.rbcodigo.Checked = True Then
                CargagridSubLinea(Grid1, "Nsp_Sele_SUBCTACONTABLE '','','" & codempresa.ToString() & "'")
            Else
                CargagridSubLinea(Grid1, "Nsp_Sele_SUBCTACONTABLE '','','" & codempresa.ToString() & "'")
            End If
        Else
            If Me.rbcodigo.Checked = True Then
                CargagridSubLinea(Grid1, "Nsp_Sele_SUBCTACONTABLE '" & Me.txtdato.Text.Trim & "','','" & codempresa.ToString() & "'")
            Else
                CargagridSubLinea(Grid1, "Nsp_Sele_SUBCTACONTABLE '','" & Me.txtdato.Text.Trim & "','" & codempresa.ToString() & "'")
            End If
        End If
    End Sub


    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged
        llena()
    End Sub

    Private Sub Grid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Grid1.Navigate

    End Sub

    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        EnviarDatosImpuesto()
        Me.Close()
    End Sub
End Class
