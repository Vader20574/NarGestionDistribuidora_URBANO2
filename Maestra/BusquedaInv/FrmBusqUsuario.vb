Public Class FrmBusqUsuario
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
    Friend WithEvents gridUsuario As System.Windows.Forms.DataGrid
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grplistado = New System.Windows.Forms.GroupBox
        Me.gridUsuario = New System.Windows.Forms.DataGrid
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.Grplistado.SuspendLayout()
        CType(Me.gridUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grplistado
        '
        Me.Grplistado.Controls.Add(Me.rbdescripcion)
        Me.Grplistado.Controls.Add(Me.rbcodigo)
        Me.Grplistado.Controls.Add(Me.gridUsuario)
        Me.Grplistado.Controls.Add(Me.txtdato)
        Me.Grplistado.Controls.Add(Me.Label4)
        Me.Grplistado.Location = New System.Drawing.Point(14, 9)
        Me.Grplistado.Name = "Grplistado"
        Me.Grplistado.Size = New System.Drawing.Size(520, 249)
        Me.Grplistado.TabIndex = 25
        Me.Grplistado.TabStop = False
        '
        'gridUsuario
        '
        Me.gridUsuario.BackgroundColor = System.Drawing.Color.Gray
        Me.gridUsuario.CaptionText = "Tecla  ESC = SALIR  "
        Me.gridUsuario.DataMember = ""
        Me.gridUsuario.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.gridUsuario.Location = New System.Drawing.Point(13, 56)
        Me.gridUsuario.Name = "gridUsuario"
        Me.gridUsuario.ReadOnly = True
        Me.gridUsuario.Size = New System.Drawing.Size(495, 176)
        Me.gridUsuario.TabIndex = 3
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(64, 22)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(240, 20)
        Me.txtdato.TabIndex = 1
        Me.txtdato.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dato : "
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(422, 26)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(88, 20)
        Me.rbdescripcion.TabIndex = 5
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(350, 26)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FrmBusqUsuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 266)
        Me.Controls.Add(Me.Grplistado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Usuario"
        Me.Grplistado.ResumeLayout(False)
        CType(Me.gridUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Public DEVOLVER As Boolean
    Dim tblImp As New DataTable
    

#End Region
#Region "Funciones del Formulario"
    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .MappingName = "table"
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "NIVEL"
            .MappingName = "NIVEL"
            .Width = 0
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "ID USUARIO"
            .MappingName = "CDUSUARIO"
            .Width = 80
        End With


        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "DESCRIPCION"
            .MappingName = "USUARIO"
            .Width = 250
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "PASSWORD"
            .MappingName = "PASSWORD"
            .Width = 0
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "codvend"
            .MappingName = "codvend"
            .Width = 0
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5})
        gridUsuario.TableStyles.Add(grdTableStyle1)
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                            ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If gridUsuario.Focus = True Then
                        DEVOLVER = True
                        Me.Close()

                    End If
                Case Keys.Escape
                    Grplistado.Visible = False
            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function





#End Region

    Private Sub FrmBusqUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormatGrid()
        tblImp = CAyuda.ListarDatos("NSP_Select_Listado_Usuario", codempresa.ToString()).Tables(0)
        gridUsuario.DataSource = tblImp


        Grplistado.Visible = True
        ' Me.cmborden.Text = "Descripcion"
        txtdato.Text = ""
        txtdato.Focus()
        tblImp = CAyuda.ListarDatos("NSP_Select_Listado_Usuario", codempresa.ToString()).Tables(0)
        gridUsuario.DataSource = tblImp

        'cmborden.SelectedIndex = 0


    End Sub
    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub
    Private Sub cmborden_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtdato.ReadOnly = False
        Me.txtdato.Text = ""
        txtdato.Focus()
    End Sub
    Private Sub gridUsuario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridUsuario.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub txtdato_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        If Me.rbcodigo.Checked = True Then
            tblImp = CAyuda.ListarDatos("Nsp_Sele_Usuario_Filtrado", txtdato.Text, "", codempresa.ToString()).Tables(0)
            gridUsuario.DataSource = tblImp
        End If

        If Me.rbdescripcion.Checked = True Then
            tblImp = CAyuda.ListarDatos("Nsp_Sele_Usuario_Filtrado", "", txtdato.Text, codempresa.ToString()).Tables(0)
            gridUsuario.DataSource = tblImp
        End If

    End Sub
End Class
