Public Class FrmBusqPlanilla
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GridBusq As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents DTINI As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnfiltrar As System.Windows.Forms.Button
    Friend WithEvents txtNroPlanilla As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusqPlanilla))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnfiltrar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DTFIN = New System.Windows.Forms.DateTimePicker
        Me.DTINI = New System.Windows.Forms.DateTimePicker
        Me.txtNroPlanilla = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GridBusq = New System.Windows.Forms.DataGrid
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridBusq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnfiltrar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DTFIN)
        Me.GroupBox1.Controls.Add(Me.DTINI)
        Me.GroupBox1.Controls.Add(Me.txtNroPlanilla)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 48)
        Me.GroupBox1.TabIndex = 166
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'btnfiltrar
        '
        Me.btnfiltrar.Location = New System.Drawing.Point(482, 20)
        Me.btnfiltrar.Name = "btnfiltrar"
        Me.btnfiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnfiltrar.TabIndex = 6
        Me.btnfiltrar.Text = "Filtrar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(356, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "AL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DE"
        '
        'DTFIN
        '
        Me.DTFIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFIN.Location = New System.Drawing.Point(374, 24)
        Me.DTFIN.Name = "DTFIN"
        Me.DTFIN.Size = New System.Drawing.Size(90, 20)
        Me.DTFIN.TabIndex = 3
        '
        'DTINI
        '
        Me.DTINI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTINI.Location = New System.Drawing.Point(240, 24)
        Me.DTINI.Name = "DTINI"
        Me.DTINI.Size = New System.Drawing.Size(90, 20)
        Me.DTINI.TabIndex = 2
        '
        'txtNroPlanilla
        '
        Me.txtNroPlanilla.Location = New System.Drawing.Point(98, 20)
        Me.txtNroPlanilla.Name = "txtNroPlanilla"
        Me.txtNroPlanilla.Size = New System.Drawing.Size(74, 20)
        Me.txtNroPlanilla.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nro  Planilla: "
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'GridBusq
        '
        Me.GridBusq.DataMember = ""
        Me.GridBusq.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridBusq.Location = New System.Drawing.Point(8, 66)
        Me.GridBusq.Name = "GridBusq"
        Me.GridBusq.ReadOnly = True
        Me.GridBusq.Size = New System.Drawing.Size(502, 232)
        Me.GridBusq.TabIndex = 165
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(514, 222)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 164
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        'FrmBusqPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(588, 308)
        Me.Controls.Add(Me.GridBusq)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusqPlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Planilla [Nota Credito de Cliente]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridBusq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "VARIABLES"

    Public DEVOLVER As Boolean
    Private TABLE_PLAN As New DataTable



#End Region


#Region "FUNCIONES"

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_KEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_KEYSYSTEM)) Then
            Select Case KeyData
                Case Keys.Enter

                    If TABLE_PLAN.Rows.Count > 0 Then
                        If GridBusq.Focus = True Then
                            DEVOLVER = True
                            Me.Close()
                        End If
                    End If
            End Select
        End If
    End Function






    Private Sub FormatoGrid()
        Dim DatagridStyle1 As New DataGridTableStyle
        With DatagridStyle1
            .MappingName = TABLE_PLAN.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim DataColum1 As New DataGridTextBoxColumn
        With DataColum1
            .MappingName = "PLANILLA"
            .HeaderText = "PLANILLA"
            .NullText = ""
            .Width = 100
        End With
        Dim Datacolum2 As New DataGridTextBoxColumn
        With Datacolum2
            .MappingName = "FECHAPROB"
            .HeaderText = "FECHAPROB"
            .Format = "dd/MM/yyyy"
            .NullText = ""
            .Width = 150
        End With
        Dim Datacolum3 As New DataGridTextBoxColumn
        With Datacolum3
            .MappingName = "SUBTOTBAS"
            .HeaderText = "SUBTOTBAS"
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
            .NullText = ""
            .Width = 75
        End With
        Dim Datacolum4 As New DataGridTextBoxColumn
        With Datacolum4
            .MappingName = "IGVBAS"
            .HeaderText = "IGVBAS"
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .NullText = ""
            .Width = 75
        End With
        Dim Datacolum5 As New DataGridTextBoxColumn
        With Datacolum5
            .MappingName = "TOTBAS"
            .HeaderText = "TOTBAS"
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .NullText = ""
            .Width = 75
        End With
        GridBusq.TableStyles.Clear()
        DatagridStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColum1, Datacolum2, Datacolum3, Datacolum4, Datacolum5})
        GridBusq.TableStyles.Add(DatagridStyle1)

    End Sub


    Private Sub CARGAR_GRID()
        TABLE_PLAN = TmpListarDatos("NSP_LISTAR_PLAN_NTACREDCABSER  '" & codempresa & "','" & Format(CDate(DTINI.Value), "dd/MM/yyyy") & "','" & Format(CDate(DTFIN.Value).AddDays(1), "dd/MM/yyyy") & "' ")
        GridBusq.DataSource = TABLE_PLAN
        FormatoGrid()
    End Sub


#End Region

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub
    Private Sub GridBusq_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridBusq.DoubleClick
        If TABLE_PLAN.Rows.Count > 0 Then

            'GridBusq.RO()

            DEVOLVER = True
            Me.Close()
        End If
    End Sub

    Private Sub FrmBusqPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CARGAR_GRID()
    End Sub

    Private Sub btnfiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfiltrar.Click
        CARGAR_GRID()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNroPlanilla.TextChanged
        For i As Integer = 0 To TABLE_PLAN.Rows.Count - 1
            GridBusq.UnSelect(i)
        Next

        For i As Integer = 0 To TABLE_PLAN.Rows.Count - 1
            If Mid(GridBusq.Item(i, 0), 1, txtNroPlanilla.Text.Trim.Length) = txtNroPlanilla.Text.Trim Then
                GridBusq.CurrentRowIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub txtNroPlanilla_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroPlanilla.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridBusq.Focus()
        End If
    End Sub



    Private Sub GridBusq_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridBusq.Navigate

    End Sub


End Class
