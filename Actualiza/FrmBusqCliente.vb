Imports System.Data
Imports VB = Microsoft.VisualBasic
Public Class FrmBusqCliente
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
    Friend WithEvents DBListar As System.Windows.Forms.DataGrid
    Friend WithEvents CmbCriterioBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDatoBuscado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DBListar = New System.Windows.Forms.DataGrid
        Me.CmbCriterioBusqueda = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtDatoBuscado = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DBListar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DBListar
        '
        Me.DBListar.DataMember = ""
        Me.DBListar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBListar.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DBListar.Location = New System.Drawing.Point(8, 48)
        Me.DBListar.Name = "DBListar"
        Me.DBListar.ReadOnly = True
        Me.DBListar.Size = New System.Drawing.Size(568, 240)
        Me.DBListar.TabIndex = 4
        '
        'CmbCriterioBusqueda
        '
        Me.CmbCriterioBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCriterioBusqueda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCriterioBusqueda.Location = New System.Drawing.Point(360, 14)
        Me.CmbCriterioBusqueda.Name = "CmbCriterioBusqueda"
        Me.CmbCriterioBusqueda.Size = New System.Drawing.Size(144, 21)
        Me.CmbCriterioBusqueda.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Criterio"
        '
        'TxtDatoBuscado
        '
        Me.TxtDatoBuscado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatoBuscado.Location = New System.Drawing.Point(64, 14)
        Me.TxtDatoBuscado.Name = "TxtDatoBuscado"
        Me.TxtDatoBuscado.Size = New System.Drawing.Size(192, 21)
        Me.TxtDatoBuscado.TabIndex = 1
        Me.TxtDatoBuscado.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato"
        '
        'FrmBusqCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(586, 296)
        Me.Controls.Add(Me.DBListar)
        Me.Controls.Add(Me.CmbCriterioBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDatoBuscado)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros Clientes"
        CType(Me.DBListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AObjBus As New ClsAyuda
    Public ATbldet As New DataTable
    Public IDCODIGO As String
    Public Lista As New ArrayList
    Private SELECT_FILA As Integer
    Dim Columna As Int32
    Private Sub FrmBusqCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Top = 0
        'Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        AboolCargarValor = False
        LimpiarFormularios(Me)
        ATbldet = AObjBus.ListarDatos("NSP_SELECT_CLIENTEXPUNTO", codempresa, NROPTOVTA).Tables(0)
        DBListar.DataSource = ATbldet
        FormatGrid()

        For Each dt As DataRow In ATbldet.Rows
            'CmbCriterioBusqueda.Items()


        Next

        Dim dictionary As New DictionaryEntry
        'dictionary.CreateInstance(Type.GetType("System.String"), 5)
        dictionary.Key = "1"
        dictionary.Value = "Codigo"

        Lista.Add(dictionary)

        dictionary = New DictionaryEntry
        dictionary.Key = "2"
        dictionary.Value = "Nombre"
        Lista.Add(dictionary)

        dictionary = New DictionaryEntry
        dictionary.Key = "3"
        dictionary.Value = "Razon Social"

        Lista.Add(dictionary)

        Me.CmbCriterioBusqueda.DataSource = Lista
        Me.CmbCriterioBusqueda.ValueMember = "Key"
        Me.CmbCriterioBusqueda.DisplayMember = "Value"
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If DBListar.Focus = True Then
                        Dim formu As New FrmNotCredServ
                        If ATbldet.Rows.Count > 0 Then
                            IDCODIGO = DBListar.Item(DBListar.CurrentRowIndex, 0)
                            AboolCargarValor = True
                            Me.Close()
                        End If

                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .MappingName = ATbldet.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Cod.Cliente"
            .MappingName = "Codigo"
            .Width = 80
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Cliente"
            .MappingName = "Cliente_Nombre"
            .Width = 200
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "Razon Social"
            .MappingName = "Razon_Social"
            .Width = 200
        End With

        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3})
        DBListar.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub DBListar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBListar.DoubleClick
        If ATbldet.Rows.Count > 0 Then
            IDCODIGO = DBListar.Item(DBListar.CurrentRowIndex, 0)
            AboolCargarValor = True
            Me.Close()
        End If
    End Sub

    Private Sub TxtDatoBuscado_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDatoBuscado.TextChanged
        For i As Integer = 0 To ATbldet.Rows.Count - 1
            DBListar.UnSelect(i)
        Next
        Columna = CType(Me.CmbCriterioBusqueda.SelectedValue, Int32) - 1
        For FILA As Integer = 0 To ATbldet.Rows.Count - 1
            If Mid(DBListar.Item(FILA, Columna).ToString.Trim, 1, TxtDatoBuscado.Text.Trim.Length).ToLower = TxtDatoBuscado.Text.Trim.ToLower Then
                DBListar.Select(FILA)
                DBListar.CurrentRowIndex = FILA
                SELECT_FILA = FILA
                Exit Sub
            End If
        Next
    End Sub
End Class
