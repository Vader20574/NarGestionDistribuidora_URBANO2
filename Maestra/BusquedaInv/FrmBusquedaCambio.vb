Imports System.Data
Imports VB = Microsoft.VisualBasic
Public Class FrmBusquedaCambio
    Inherits System.Windows.Forms.Form
    Private TAB_TIPODOC As New DataTable
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
    Friend WithEvents DBListar As System.Windows.Forms.DataGrid
    Friend WithEvents TxtDatoBuscado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DBListar = New System.Windows.Forms.DataGrid
        Me.TxtDatoBuscado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DBListar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBListar
        '
        Me.DBListar.DataMember = ""
        Me.DBListar.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBListar.Location = New System.Drawing.Point(16, 72)
        Me.DBListar.Name = "DBListar"
        Me.DBListar.Size = New System.Drawing.Size(496, 240)
        Me.DBListar.TabIndex = 11
        '
        'TxtDatoBuscado
        '
        Me.TxtDatoBuscado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDatoBuscado.Location = New System.Drawing.Point(56, 24)
        Me.TxtDatoBuscado.Name = "TxtDatoBuscado"
        Me.TxtDatoBuscado.Size = New System.Drawing.Size(200, 20)
        Me.TxtDatoBuscado.TabIndex = 8
        Me.TxtDatoBuscado.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha"
        '
        'FrmBusquedaCambio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 334)
        Me.Controls.Add(Me.DBListar)
        Me.Controls.Add(Me.TxtDatoBuscado)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registros de Tipo Cambio"
        CType(Me.DBListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private MrsobtieneRegistros As New DataTable
    Private MstrCodigo As String
    Private Mstrdescripcion As String
    Private MArrayDeBusqueda As Object
    Private MintNumerodeFilas As Integer
    Private MintItemInicio As Integer
    Private MstrOrden As String
    Private MVarDevuelveColumna As Object
    Private Sub ActualizarGrid()
        Dim i As Integer
        Dim colum1 As New DataGridTextBoxColumn
        Dim colum2 As New DataGridTextBoxColumn
        '        For i = 1 To MintNumerodeFilas
        '       DBListar.Columns(i - 1).Width = MArrayDeBusqueda(i, 3)
        '      DBListar.Columns(i - 1).Caption = MArrayDeBusqueda(i, 2)
        ' Next

        Try

            Dim myGridStyle As DataGridTableStyle = DBListar.TableStyles(MrsobtieneRegistros.TableName)

            For i = 0 To MintNumerodeFilas
                myGridStyle.GridColumnStyles(i).Width = MArrayDeBusqueda(i, 2)
                myGridStyle.GridColumnStyles(i).HeaderText = MArrayDeBusqueda(i, 1)
            Next

            'If MintNumerodeFilas < MrsobtieneRegistros.Rows.Count Then
            '    For i = MintNumerodeFilas To MrsobtieneRegistros.Rows.Count - 1
            '        myGridStyle.GridColumnStyles(i) = False
            '            VB(.AllowSizing = False
            '    Next
            'End If

        Catch eqx As Exception
            MsgBox(eqx.Message)
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                     ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If DBListar.Focus = True Then
                        TxtDatoBuscado.Focus()
                        RetornarValores()
                        Me.Close()
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Sub llena_grid()

        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = MrsobtieneRegistros.TableName
        End With


        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Descripción"
            .MappingName = "Descripción"
        End With
    End Sub
    Private Sub RetornarValores()
        'LA COLUMNA 1 ES LA QUE CONTIENE EL NOMBRE DEL CAMPO (BASE DE DATOS) A MOSTRAR
        Dim columna As Integer
        Dim i As Integer
        columna = MrsobtieneRegistros.Columns.Count()
        Dim ArrayDevolucion(columna, 0) As Object
        For i = 0 To columna - 1
            ArrayDevolucion(i, 0) = DBListar.Item(DBListar.CurrentRowIndex, i)
        Next
        AobjARRAYAYUDA = ArrayDevolucion.Clone
        AboolCargarValor = True
    End Sub


    Private Sub FrmBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        MstrOrden = "ASC"
        Me.Top = 0
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        For i = 0 To MintNumerodeFilas
            ' CmbCriterioBusqueda.Items.Add(MArrayDeBusqueda(i, 1))
        Next
        '    CmbCriterioBusqueda.SelectedIndex = MintItemInicio - 1
        DBListar.Visible = True
      
        ''llenar()

    End Sub


    Public Sub GObtenerRegistros(ByVal IRS As DataTable, _
    ByVal IArrayBusqueda As Object, ByVal IintFila As Integer, ByVal IintColumnaInicio As Integer, _
    Optional ByVal IintAnchoForm As Integer = 7230, _
    Optional ByVal IintAltoForm As Integer = 5970, _
    Optional ByVal IintTopForm As Integer = 1905, _
    Optional ByVal IintLeftForm As Integer = 2895, _
    Optional ByVal IVarDevuelveColumna As Object = -1)

        MrsobtieneRegistros = IRS
        If Not MrsobtieneRegistros.Rows.Count > 0 Then
            DBListar.DataSource = IRS
            DBListar.CurrentRowIndex = 0
        End If

        MArrayDeBusqueda = IArrayBusqueda
        MintNumerodeFilas = IintFila
        MintItemInicio = IintColumnaInicio
        MVarDevuelveColumna = IVarDevuelveColumna

        DBListar.DataSource = IRS
        'ActualizarGrid()
        DBListar.Refresh()
        '     lblRegistro.Caption = MrsobtieneRegistros.RecordCount & " registros encontrados"
    End Sub

    Private Sub TxtDatoBuscado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDatoBuscado.TextChanged

    llenar()


    End Sub
    Sub llenar()
        TAB_TIPODOC = TmpListarDatos("NSP_Select_ListaCambio_filtro '" & codempresa & "','" & TxtDatoBuscado.Text & "'")
        DBListar.DataSource = TAB_TIPODOC
        'FormatGrid()
    End Sub
    Private Sub CmbCriterioBusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' MrsobtieneRegistros.DefaultView.Sort = CmbCriterioBusqueda.Text & " " & "ASC"
        ' txtdato.Focus()
    End Sub

    Private Sub DBListar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DBListar.KeyDown

    End Sub



    Private Sub TxtDatoBuscado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscado.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            TxtDatoBuscado.Focus()
            RetornarValores()
            Me.Close()
        End If

    End Sub
    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .MappingName = MrsobtieneRegistros.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Fecha_"
            .MappingName = "Fecha"
            .Width = 100
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "De_"
            .MappingName = "De"
            .Width = 80
        End With


        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "A_"
            .MappingName = "A"
            .Width = 80
        End With


        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "Compra_"
            .MappingName = "Compra"
            .Width = 100
            .Alignment = HorizontalAlignment.Right
        End With


        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "Venta_"
            .MappingName = "Venta"
            .Width = 100
            .Alignment = HorizontalAlignment.Right
        End With
        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5})
        DBListar.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub DBListar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBListar.DoubleClick
        TxtDatoBuscado.Focus()
        RetornarValores()
        Me.Close()
    End Sub

    Private Sub DBListar_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DBListar.Navigate

    End Sub
End Class
