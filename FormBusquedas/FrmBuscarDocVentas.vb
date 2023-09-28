Public Class FrmBuscarDocVentas
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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LblCont As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNroDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDesCli As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DtgDoc As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBuscarDocVentas))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LblCont = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtNroDoc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDesCli = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DtgDoc = New System.Windows.Forms.DataGrid
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DtgDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Location = New System.Drawing.Point(550, 288)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(72, 72)
        Me.GroupBox5.TabIndex = 163
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
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'LblCont
        '
        Me.LblCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCont.ForeColor = System.Drawing.Color.Blue
        Me.LblCont.Location = New System.Drawing.Point(16, 298)
        Me.LblCont.Name = "LblCont"
        Me.LblCont.Size = New System.Drawing.Size(360, 16)
        Me.LblCont.TabIndex = 162
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNroDoc)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 40)
        Me.GroupBox1.TabIndex = 159
        Me.GroupBox1.TabStop = False
        '
        'TxtNroDoc
        '
        Me.TxtNroDoc.Location = New System.Drawing.Point(8, 13)
        Me.TxtNroDoc.Name = "TxtNroDoc"
        Me.TxtNroDoc.Size = New System.Drawing.Size(144, 20)
        Me.TxtNroDoc.TabIndex = 0
        Me.TxtNroDoc.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 24)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "&Ingrese Nombre del Cliente :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDesCli)
        Me.GroupBox2.Location = New System.Drawing.Point(176, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 40)
        Me.GroupBox2.TabIndex = 160
        Me.GroupBox2.TabStop = False
        '
        'TxtDesCli
        '
        Me.TxtDesCli.Location = New System.Drawing.Point(8, 13)
        Me.TxtDesCli.Name = "TxtDesCli"
        Me.TxtDesCli.Size = New System.Drawing.Size(396, 20)
        Me.TxtDesCli.TabIndex = 1
        Me.TxtDesCli.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "&Ingrese Nro de Documento :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DtgDoc)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(638, 216)
        Me.GroupBox3.TabIndex = 161
        Me.GroupBox3.TabStop = False
        '
        'DtgDoc
        '
        Me.DtgDoc.BackgroundColor = System.Drawing.Color.White
        Me.DtgDoc.CaptionBackColor = System.Drawing.Color.Silver
        Me.DtgDoc.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgDoc.CaptionForeColor = System.Drawing.Color.DarkBlue
        Me.DtgDoc.CaptionText = "Doble Click Sobre el Registro Seleccioando"
        Me.DtgDoc.DataMember = ""
        Me.DtgDoc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtgDoc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgDoc.Location = New System.Drawing.Point(8, 10)
        Me.DtgDoc.Name = "DtgDoc"
        Me.DtgDoc.ReadOnly = True
        Me.DtgDoc.Size = New System.Drawing.Size(624, 200)
        Me.DtgDoc.TabIndex = 49
        '
        'FrmBuscarDocVentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(650, 362)
        Me.Controls.Add(Me.LblCont)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarDocVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Documentos de Facturacion "
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DtgDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "FIELDS"
    Public DEVOLVER As Boolean
    Private TABLE_DOC As New DataTable
    Public DATACODTIPODOC As String = ""
    Public DATACODCLIENTE As String = ""
    Private Indice As Integer

#End Region
#Region "FUNCIONES"

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const KeyDown As Integer = &H100
        Const KeySystem As Integer = &H104

        If ((MSG.Msg = KeyDown) Or (MSG.Msg = KeySystem)) Then
            Select Case KeyData
                Case Keys.Enter
                    If DtgDoc.Focus = True Then
                        If TABLE_DOC.Rows.Count > 0 Then
                            DEVOLVER = True
                            DtgDoc.Select(Indice)
                            Me.Close()
                        End If
                    End If
            End Select

        End If

    End Function

    Sub CargarGrid()
        TABLE_DOC = TmpListarDatos("SP_BuscarDocPendienteDeCliente  '" & codempresa & "','" & DATACODTIPODOC & "','" & DATACODCLIENTE & "' ")
        DtgDoc.DataSource = TABLE_DOC
        FormatoGrid()
    End Sub

    Sub FormatoGrid()
        Dim DataGRidTableStyle1 As New DataGridTableStyle

        With DataGRidTableStyle1
            .MappingName = TABLE_DOC.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        End With

        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "CDTIPODOCUM"
            .HeaderText = "CODTIPODOC"
            .NullText = ""
            .Width = 0
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "DSABRV"
            .HeaderText = "DSABRV"
            .NullText = ""
            .Width = 30
        End With
        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "NRODOCU"
            .HeaderText = "NRODOCU"
            .NullText = ""
            .Width = 100
        End With
        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "CDCLIENTE"
            .HeaderText = "CODCLIENTE"
            .NullText = ""
            .Width = 0
        End With
        Dim DataColumn5 As New DataGridTextBoxColumn
        With DataColumn5
            .MappingName = "DATOADJUNTO"
            .HeaderText = "DESCLIENTE"
            .NullText = ""
            .Width = 200
        End With
        Dim DataColumn6 As New DataGridTextBoxColumn
        With DataColumn6
            .MappingName = "TOTCREDBAS"
            .HeaderText = "IMPORTE"
            .NullText = ""
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
        End With
        Dim DataColumn7 As New DataGridTextBoxColumn
        With DataColumn7
            .MappingName = "PAGCREDBAS"
            .HeaderText = "ACUENTA"
            .NullText = ""
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
        End With
        Dim DataColumn8 As New DataGridTextBoxColumn
        With DataColumn8
            .MappingName = "SALDO"
            .HeaderText = "SALDO"
            .NullText = ""
            .Width = 75
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
        End With
        Dim DataColumn9 As New DataGridTextBoxColumn
        With DataColumn9
            .MappingName = "CDCLIENTEDEP"
            .HeaderText = "CDCLIENTEDEP"
            .NullText = ""
            .Width = 0
        End With

        Dim DataColumn10 As New DataGridTextBoxColumn
        With DataColumn10
            .MappingName = "CODTIPOPAGO"
            .HeaderText = "CODTIPOPAGO"
            .NullText = ""
            .Width = 0
        End With

        DataGRidTableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5, DataColumn6, DataColumn7, DataColumn8, DataColumn9, DataColumn10})
        DtgDoc.TableStyles.Add(DataGRidTableStyle1)

    End Sub


#End Region



    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmBuscarDocVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrid()

    End Sub

    Private Sub TxtDesCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesCli.TextChanged
        For i As Integer = 0 To TABLE_DOC.Rows.Count - 1
            DtgDoc.UnSelect(i)
        Next
        For i As Integer = 0 To TABLE_DOC.Rows.Count - 1
            If Mid((DtgDoc.Item(i, 4).tostring.Trim).ToUpper, 1, TxtDesCli.Text.Trim.Length) = (TxtDesCli.Text.Trim).ToUpper Then
                DtgDoc.Select(i)
                DtgDoc.CurrentRowIndex = i
                Indice = i
                Exit For
            End If
        Next
    End Sub

    Private Sub TxtNroDoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNroDoc.TextChanged
        For i As Integer = 0 To TABLE_DOC.Rows.Count - 1
            DtgDoc.UnSelect(i)
        Next

        For i As Integer = 0 To TABLE_DOC.Rows.Count - 1
            If Mid((DtgDoc.Item(i, 2).tostring.Trim).ToUpper, 1, TxtNroDoc.Text.Trim.Length) = (TxtNroDoc.Text.Trim).ToUpper Then
                DtgDoc.Select(i)
                DtgDoc.CurrentRowIndex = i
                Indice = i
                Exit For
            End If
        Next
    End Sub

    Private Sub DtgDoc_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DtgDoc.Navigate

    End Sub

    Private Sub DtgDoc_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgDoc.CurrentCellChanged
        Indice = DtgDoc.CurrentRowIndex

    End Sub

    Private Sub DtgDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtgDoc.DoubleClick
        If TABLE_DOC.Rows.Count > 0 Then
            DEVOLVER = True
            DtgDoc.Select(Indice)
            Me.Close()
        End If
    End Sub

    Private Sub TxtDesCli_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDesCli.KeyDown, TxtNroDoc.KeyDown
        If TABLE_DOC.Rows.Count > 0 Then
            If e.KeyCode = Keys.Enter Then
                DtgDoc.Focus()
                DtgDoc.Select(Indice)
            End If
        End If
    End Sub
End Class
