Imports System.Data
Imports VB = Microsoft.VisualBasic
Public Class FrmBusNotaCredito
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
        Me.DBListar.Location = New System.Drawing.Point(16, 56)
        Me.DBListar.Name = "DBListar"
        Me.DBListar.ReadOnly = True
        Me.DBListar.Size = New System.Drawing.Size(456, 240)
        Me.DBListar.TabIndex = 4
        '
        'CmbCriterioBusqueda
        '
        Me.CmbCriterioBusqueda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCriterioBusqueda.Location = New System.Drawing.Point(320, 16)
        Me.CmbCriterioBusqueda.Name = "CmbCriterioBusqueda"
        Me.CmbCriterioBusqueda.Size = New System.Drawing.Size(144, 21)
        Me.CmbCriterioBusqueda.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Criterio"
        '
        'TxtDatoBuscado
        '
        Me.TxtDatoBuscado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatoBuscado.Location = New System.Drawing.Point(56, 16)
        Me.TxtDatoBuscado.Name = "TxtDatoBuscado"
        Me.TxtDatoBuscado.Size = New System.Drawing.Size(168, 21)
        Me.TxtDatoBuscado.TabIndex = 1
        Me.TxtDatoBuscado.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato"
        '
        'FrmBusNotaCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(488, 303)
        Me.Controls.Add(Me.DBListar)
        Me.Controls.Add(Me.CmbCriterioBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDatoBuscado)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(494, 335)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(494, 335)
        Me.Name = "FrmBusNotaCredito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Registros de Nota Credito"
        CType(Me.DBListar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public AObjBus As New ClsAyuda
    Public ATbldet As New DataTable
    Public IDCODIGO As Double
    Public ADblNroR As New Double
    Public IDOCREF As String

    Private Sub FrmBusNotaCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AboolCargarValor = False
        LimpiarFormularios(Me)
        ATbldet = AObjBus.ListarDatos("NSP_SELECT_LISTARDOCUMENTOSNTACREDITO", codempresa.ToString, NROPTOVTA).Tables(0)
        DBListar.DataSource = ATbldet
        FormatGrid()
    End Sub



    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = ATbldet.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With

        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Cliente"
            .MappingName = "DESCLIENTE"
            .Width = 235
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Número"
            .MappingName = "Número_"
            .Width = 100
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "Esatdo NotCred"
            .MappingName = "Estado"
            .Width = 80
        End With

        Dim grdColStyle4 As New DataGridTextBoxColumn
        With grdColStyle4
            .HeaderText = "Cod Doc Ref"
            .MappingName = "CDTIPODOCREF"
            .Width = 80
        End With


        ' Add the style objects to the table style's collection of 
        ' column styles. Without this the styles do not take effect.        
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4})
        DBListar.TableStyles.Add(grdTableStyle1)
    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message,
                                ByVal keyData As Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If DBListar.Focus = True Then
                        Dim formu As New FrmNotaCredito
                        If ATbldet.Rows.Count > 0 Then
                            IDCODIGO = CDbl(DBListar.Item(DBListar.CurrentRowIndex, 1))
                            IDOCREF = DBListar.Item(DBListar.CurrentRowIndex, 3)
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

    Private Sub DBListar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBListar.DoubleClick
        If ATbldet.Rows.Count > 0 Then
            IDCODIGO = CDbl(DBListar.Item(DBListar.CurrentRowIndex, 1))
            IDOCREF = DBListar.Item(DBListar.CurrentRowIndex, 3)
            AboolCargarValor = True
            Me.Close()
        End If
    End Sub
End Class
