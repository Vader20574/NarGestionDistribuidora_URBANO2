Public Class FrmBuscVendedor
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    Friend WithEvents GridVend As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscVendedor))
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.GridVend = New System.Windows.Forms.DataGrid
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        CType(Me.GridVend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(74, 4)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(240, 20)
        Me.TxtDato.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Vendedor : "
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.GridVend
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'GridVend
        '
        Me.GridVend.CaptionText = "[Enter para seleccionar]  o Doble clik"
        Me.GridVend.DataMember = ""
        Me.GridVend.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridVend.Location = New System.Drawing.Point(10, 30)
        Me.GridVend.Name = "GridVend"
        Me.GridVend.ReadOnly = True
        Me.GridVend.Size = New System.Drawing.Size(461, 294)
        Me.GridVend.TabIndex = 166
        Me.GridVend.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 85
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "#Orden de Venta"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "HH:mm:ss tt"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Hora Salida"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 85
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Estado"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 35
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Location = New System.Drawing.Point(394, 6)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(104, 16)
        Me.rbdescripcion.TabIndex = 170
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(334, 4)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 169
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'FrmBuscVendedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(501, 336)
        Me.Controls.Add(Me.rbdescripcion)
        Me.Controls.Add(Me.rbcodigo)
        Me.Controls.Add(Me.TxtDato)
        Me.Controls.Add(Me.GridVend)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Vendedor"
        CType(Me.GridVend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables Form"
    Private TAB_CLIENTE As New DataTable
    Public DEVOLVER As Boolean

#End Region

#Region "Funciones Form"

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WIND_KEYDOWN As Integer = &H100
        Const WIND_KEYSYSTEM As Integer = &H104
        If (MSG.Msg = WIND_KEYDOWN) Or (MSG.Msg = WIND_KEYSYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If TAB_CLIENTE.Rows.Count > 0 Then
                        If GridVend.Focus = True Then
                            DEVOLVER = True
                            Me.Close()
                        End If
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If

    End Function
    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_CLIENTE.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODVEND"
            .HeaderText = "Codigo"
            .NullText = ""
            .Width = 75
        End With

        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DSVEND"
            .HeaderText = "Descripcion"
            .NullText = ""
            .Width = 220
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2})
        GridVend.TableStyles.Add(TableStyle1)

    End Sub


#End Region

    Private Sub FrmBuscVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TAB_CLIENTE = TmpListarDatos("SP_ListVendedor  '" & codempresa & "'")
        GridVend.DataSource = TAB_CLIENTE
        FormatoGrid()
    End Sub

    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged

llena()


    End Sub


    Sub llena()
        Try
            If Me.TxtDato.Text.Trim = "" Then

                TAB_CLIENTE = TmpListarDatos("SP_ListVendedor  '" & codempresa & "'")
                GridVend.DataSource = TAB_CLIENTE


            Else
                If Me.rbcodigo.Checked = True Then
                    TAB_CLIENTE = CAyuda.ListarDatos("SP_ListVendedor_filtro", TxtDato.Text, "", codempresa).Tables(0)
                    GridVend.DataSource = TAB_CLIENTE

                End If

                If Me.rbdescripcion.Checked = True Then
                    TAB_CLIENTE = CAyuda.ListarDatos("SP_ListVendedor_filtro", "", TxtDato.Text, codempresa.ToString()).Tables(0)
                    GridVend.DataSource = TAB_CLIENTE

                End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Sub llenar()
    '    If Me.TxtDato.Text.Trim = "" Then
    '        If Me.rbcodigo.Checked = True Then
    '            CargagridZona(grid1, "Nsp_Sele_Zona '','','" & codempresa & "'")
    '        Else
    '            CargagridZona(grid1, "Nsp_Sele_Zona '','','" & codempresa & "'")
    '        End If
    '    Else
    '        If Me.rbcodigo.Checked = True Then
    '            CargagridZona(grid1, "Nsp_Sele_Zona '" & Me.TxtDato.Text.Trim & "','','" & codempresa & "'")
    '        Else
    '            CargagridZona(grid1, "Nsp_Sele_Zona '','" & Me.TxtDato.Text.Trim & "','" & codempresa & "'")
    '        End If
    '    End If
    'End Sub

    Private Sub GridVend_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVend.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub GridVend_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridVend.Navigate

    End Sub
End Class
