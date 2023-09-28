Public Class FrmBusqNivel
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
    Friend WithEvents grdLinea As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Grplistado = New System.Windows.Forms.GroupBox
        Me.grdLinea = New System.Windows.Forms.DataGrid
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.Grplistado.SuspendLayout()
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grplistado
        '
        Me.Grplistado.Controls.Add(Me.rbdescripcion)
        Me.Grplistado.Controls.Add(Me.rbcodigo)
        Me.Grplistado.Controls.Add(Me.grdLinea)
        Me.Grplistado.Controls.Add(Me.Label3)
        Me.Grplistado.Controls.Add(Me.txtdato)
        Me.Grplistado.Location = New System.Drawing.Point(8, 8)
        Me.Grplistado.Name = "Grplistado"
        Me.Grplistado.Size = New System.Drawing.Size(512, 248)
        Me.Grplistado.TabIndex = 21
        Me.Grplistado.TabStop = False
        '
        'grdLinea
        '
        Me.grdLinea.BackgroundColor = System.Drawing.Color.Gray
        Me.grdLinea.DataMember = ""
        Me.grdLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLinea.Location = New System.Drawing.Point(12, 48)
        Me.grdLinea.Name = "grdLinea"
        Me.grdLinea.ReadOnly = True
        Me.grdLinea.Size = New System.Drawing.Size(488, 192)
        Me.grdLinea.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dato : "
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(96, 16)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(189, 20)
        Me.txtdato.TabIndex = 1
        Me.txtdato.Text = ""
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(414, 18)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(88, 20)
        Me.rbdescripcion.TabIndex = 7
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(342, 18)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 6
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FrmBusqNivel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 278)
        Me.Controls.Add(Me.Grplistado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqNivel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Nivel"
        Me.Grplistado.ResumeLayout(False)
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"

    Dim ATblImp As New DataTable
    Public DEVOLVER As Boolean


#End Region
#Region "Funciones del Formulario"
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                        ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If grdLinea.Focus = True Then
                        Try
                            If ATblImp.Rows.Count > 0 Then
                                DEVOLVER = True
                                Me.Close()
                            End If
                        Catch
                            txtdato.Focus()
                            Exit Function
                        End Try
                    End If
                Case Keys.Escape
                    Grplistado.Visible = False
            End Select
        End If

        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .MappingName = ATblImp.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Codigo"
            .MappingName = "Código"
            .Width = 90
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Descripcion"
            .MappingName = "Descripción"
            .Width = 280
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2})
        grdLinea.TableStyles.Add(grdTableStyle1)
    End Sub




#End Region


    Private Sub FrmBusqNivel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ATblImp = CAyuda.ListarDatos("NSP_Select_Listado_Nivel", codempresa.ToString()).Tables(0)
        grdLinea.DataSource = ATblImp
        FormatGrid()

        Grplistado.Visible = True
        txtdato.Focus()
        txtdato.ReadOnly = False

    End Sub

    Private Sub grdLinea_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdLinea.Navigate

    End Sub

    Private Sub grdLinea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLinea.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub rbcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcodigo.CheckedChanged

    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        If Me.rbcodigo.Checked = True Then
            ATblImp = CAyuda.ListarDatos("Nsp_Sele_Nivel_Filtrado", txtdato.Text, "", codempresa).Tables(0)
            grdLinea.DataSource = ATblImp
        End If

        If Me.rbdescripcion.Checked = True Then
            ATblImp = CAyuda.ListarDatos("Nsp_Sele_Nivel_Filtrado", "", txtdato.Text, codempresa.ToString()).Tables(0)
            grdLinea.DataSource = ATblImp
        End If

    End Sub
End Class
