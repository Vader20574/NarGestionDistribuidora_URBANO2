Public Class FrmBusqPreplanillaNtaCred
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridBusq As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBusqPreplanillaNtaCred))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GridBusq = New System.Windows.Forms.DataGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox5.SuspendLayout()
        CType(Me.GridBusq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(436, 308)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 161
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList1
        Me.BtnSalir.Location = New System.Drawing.Point(8, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GridBusq
        '
        Me.GridBusq.DataMember = ""
        Me.GridBusq.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridBusq.Location = New System.Drawing.Point(10, 70)
        Me.GridBusq.Name = "GridBusq"
        Me.GridBusq.ReadOnly = True
        Me.GridBusq.Size = New System.Drawing.Size(502, 232)
        Me.GridBusq.TabIndex = 162
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 48)
        Me.GroupBox1.TabIndex = 163
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro  Preplanilla: "
        '
        'FrmBusqPreplanillaNtaCred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(524, 386)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GridBusq)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusqPreplanillaNtaCred"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Preplanilla [Nota Credito de Cliente]"
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GridBusq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "VARIABLES"
    Public DEVOLVER As Boolean
    Private TABLE_BUSC_NTACRED As New DataTable


#End Region

#Region "FUNCIONES"
    Private Sub CargarGridBus()
        TABLE_BUSC_NTACRED = TmpListarDatos("NSP_CARGAR_PREPLAN_NTACREDCABSER   '" & codempresa & "'")
        GridBusq.DataSource = TABLE_BUSC_NTACRED
    End Sub
    Private Sub FormatoGrid()
        Dim DatagridStyle1 As New DataGridTableStyle
        With DatagridStyle1
            .MappingName = TABLE_BUSC_NTACRED.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim DataColum1 As New DataGridTextBoxColumn
        With DataColum1
            .MappingName = "PREPLANILLA"
            .HeaderText = "NRO PREPLANILLA"
            .NullText = ""
            .Width = 100
        End With
        Dim Datacolum2 As New DataGridTextBoxColumn
        With Datacolum2
            .MappingName = "USERID"
            .HeaderText = "USUARIO"
            .NullText = ""
            .Width = 150
        End With
        Dim Datacolum3 As New DataGridTextBoxColumn
        With Datacolum3
            .MappingName = "CANTDOC"
            .HeaderText = "CANT DOC"
            .Alignment = HorizontalAlignment.Center
            .NullText = ""
            .Width = 50
        End With
        Dim Datacolum4 As New DataGridTextBoxColumn
        With Datacolum4
            .MappingName = "MONTO"
            .HeaderText = "MONTO"
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .NullText = ""
            .Width = 75
        End With
        Dim Datacolum5 As New DataGridTextBoxColumn
        With Datacolum5
            .MappingName = "FECHAPREPLAN"
            .HeaderText = "FECHA"
            .Format = "dd/MM/yyyy"
            .Alignment = HorizontalAlignment.Right
            .NullText = ""
            .Width = 100
        End With
        DatagridStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColum1, Datacolum2, Datacolum3, Datacolum4, Datacolum5})
        GridBusq.TableStyles.Add(DatagridStyle1)

    End Sub

#End Region



    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmBusqPreplanillaNtaCred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarGridBus()
        FormatoGrid()

    End Sub

    Private Sub GridBusq_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridBusq.Navigate

    End Sub


    Private Sub GridBusq_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridBusq.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub


End Class
