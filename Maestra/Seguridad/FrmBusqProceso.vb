Public Class FrmBusqProceso
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
    Friend WithEvents Dg1 As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents rbdescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CDPROCESO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DSPROCESO As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Dg1 = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbdescripcion = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.CDPROCESO = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DSPROCESO = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.Dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dg1
        '
        Me.Dg1.DataMember = ""
        Me.Dg1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dg1.Location = New System.Drawing.Point(10, 68)
        Me.Dg1.Name = "Dg1"
        Me.Dg1.ReadOnly = True
        Me.Dg1.Size = New System.Drawing.Size(658, 402)
        Me.Dg1.TabIndex = 1
        Me.Dg1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdescripcion)
        Me.GroupBox1.Controls.Add(Me.rbcodigo)
        Me.GroupBox1.Controls.Add(Me.TxtDato)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'rbdescripcion
        '
        Me.rbdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdescripcion.Location = New System.Drawing.Point(556, 18)
        Me.rbdescripcion.Name = "rbdescripcion"
        Me.rbdescripcion.Size = New System.Drawing.Size(88, 20)
        Me.rbdescripcion.TabIndex = 9
        Me.rbdescripcion.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(484, 18)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 8
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(54, 18)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(304, 20)
        Me.TxtDato.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato:"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dg1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CDPROCESO, Me.DSPROCESO})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'CDPROCESO
        '
        Me.CDPROCESO.Format = ""
        Me.CDPROCESO.FormatInfo = Nothing
        '
        'DSPROCESO
        '
        Me.DSPROCESO.Format = ""
        Me.DSPROCESO.FormatInfo = Nothing
        Me.DSPROCESO.Width = 75
        '
        'FrmBusqProceso
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(678, 480)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dg1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusqProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Proceso"
        CType(Me.Dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "FIELDS FORM"
    Private TMP_MODULO As New DataTable
    Public DEVOLVER As Boolean
#End Region

#Region "FUNCTION FORM"

    Private Sub CargarGrid()
        TMP_MODULO = TmpListarDatos("SELECT  * FROM PROCESOS WHERE CODEMPRESA='" & codempresa & "'  ORDER BY dsproceso ASC")
        Dg1.DataSource = TMP_MODULO
    End Sub

    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TMP_MODULO.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CDPROCESO"
            .HeaderText = "CODIGO"
            .NullText = ""
            .Width = 100
        End With
        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "DSPROCESO"
            .HeaderText = "DESCRIPCION"
            .NullText = ""
            .Width = 250
        End With
        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "DSPROCESO"
            .HeaderText = "MENU TEXTO"
            .NullText = ""
            .Width = 250
        End With
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3})
        Dg1.TableStyles.Add(TableStyle1)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal Keydata As Keys) As Boolean
        Const KEYDOWN As Integer = &H100
        Const KEYSYSTEM As Integer = &H104
        If (MSG.Msg = KEYDOWN) Or (MSG.Msg = KEYSYSTEM) Then
            Select Case Keydata
                Case Keys.Enter
                    If Dg1.Focus = True Then
                        If TMP_MODULO.Rows.Count > 0 Then
                            DEVOLVER = True
                            Me.Close()
                        End If
                    End If
                Case Keys.Escape
                    Me.Close()
            End Select
        End If

    End Function

#End Region



    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged

        If Me.rbcodigo.Checked = True Then
            TMP_MODULO = CAyuda.ListarDatos("Nsp_Sele_Proceso_Filtrado", TxtDato.Text, "", codempresa.ToString()).Tables(0)
            Dg1.DataSource = TMP_MODULO
        End If

        If Me.rbdescripcion.Checked = True Then
            TMP_MODULO = CAyuda.ListarDatos("Nsp_Sele_Proceso_Filtrado", "", TxtDato.Text, codempresa.ToString()).Tables(0)
            Dg1.DataSource = TMP_MODULO
        End If


    End Sub

    Private Sub Dg1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles Dg1.Navigate

    End Sub

    Private Sub Dg1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dg1.DoubleClick
        DEVOLVER = True
        Me.Close()

    End Sub

    Private Sub FrmBusqModulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()
        'FormatoGrid()

    End Sub
End Class
