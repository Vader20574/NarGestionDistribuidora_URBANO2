Public Class FrmBusqNotaCredComprasXdinero
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents GridNtaCred As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.DtFecFin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtFecIni = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridNtaCred = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridNtaCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.DtFecFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtFecIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(530, 17)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(82, 23)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'DtFecFin
        '
        Me.DtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecFin.Location = New System.Drawing.Point(210, 18)
        Me.DtFecFin.Name = "DtFecFin"
        Me.DtFecFin.Size = New System.Drawing.Size(90, 20)
        Me.DtFecFin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta :"
        '
        'DtFecIni
        '
        Me.DtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecIni.Location = New System.Drawing.Point(56, 16)
        Me.DtFecIni.Name = "DtFecIni"
        Me.DtFecIni.Size = New System.Drawing.Size(90, 20)
        Me.DtFecIni.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'GridNtaCred
        '
        Me.GridNtaCred.CaptionText = "                                       SELECCIONAR --> [ENTER]   O  DOBLE CLICK"
        Me.GridNtaCred.DataMember = ""
        Me.GridNtaCred.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridNtaCred.Location = New System.Drawing.Point(12, 104)
        Me.GridNtaCred.Name = "GridNtaCred"
        Me.GridNtaCred.ReadOnly = True
        Me.GridNtaCred.Size = New System.Drawing.Size(640, 296)
        Me.GridNtaCred.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDato)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 40)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(100, 12)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(138, 20)
        Me.TxtDato.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nro Nota Credito :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(369, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Proveedor :"
        '
        'FrmBusqNotaCredComprasXdinero
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 420)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GridNtaCred)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusqNotaCredComprasXdinero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de NotaCredito de Proveedor x Dinero"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridNtaCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables Form "
    Public DEVOLVER As Boolean
    Private TAB_NTACRED As New DataTable


#End Region
#Region "Funciones Form"
    Private Sub CargarGrid()
        TAB_NTACRED = TmpListarDatos("ListarNTACREDCOMPRACABxProc  '" & codempresa & "','" & Format(CDate(DtFecIni.Value), "dd/MM/yyyy") & "','" & Format(CDate(DtFecFin.Value), "dd/MM/yyyy") & "','D','" & TextBox1.Text & "'")

    
        GridNtaCred.DataSource = TAB_NTACRED

    End Sub

    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_NTACRED.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "NRONTACRED"
            .HeaderText = "NroNtaCred"
            .NullText = ""
            .Width = 100
        End With

        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CODTIPODOC"
            .HeaderText = "TipoDoc"
            .NullText = ""
            .Width = 0
        End With

        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "NROREFE"
            .HeaderText = "Nro Referencia"
            .NullText = ""
            .Width = 75
        End With

        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "ESTADO"
            .HeaderText = "Estado"
            .NullText = ""
            .Width = 75
        End With
    
        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "FECDOCUM"
            .HeaderText = "Fecha Documento"
            .Format = "dd/MM/yyyy"
            .NullText = ""
            .Width = 75
        End With
        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "CODPROVEEDOR"
            .HeaderText = "CdProveedor"
            .NullText = ""
            .Width = 0
        End With

        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "DESPROVEEDOR"
            .HeaderText = "Proveedor"
            .NullText = ""
            .Width = 150
        End With
        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "TOTBAS"
            .HeaderText = "Monto"
            .NullText = ""
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .Width = 100
        End With

        Dim Column12 As New DataGridTextBoxColumn
        With Column12
            .MappingName = "OBS"
            .HeaderText = "OBS"
            .NullText = ""
            .Width = 150
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column4, Column5, Column8, Column9, Column10, Column11, Column12})
        GridNtaCred.TableStyles.Add(TableStyle1)

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If TAB_NTACRED.Rows.Count > 0 Then
                        If GridNtaCred.Focus = True Then
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

    Private Sub FrmBusqNotaCredComprasXdinero_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DtFecIni.Value = DateAdd(DateInterval.Day, -7, DtFecIni.Value)
        CargarGrid()
        FormatoGrid()

    End Sub

    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        CargarGrid()
        'FormatoGrid()

    End Sub

    Private Sub GridNtaCred_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridNtaCred.Navigate

    End Sub

    Private Sub GridNtaCred_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridNtaCred.DoubleClick
        DEVOLVER = True
        Me.Close()
    End Sub

    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged
        For i As Integer = 0 To TAB_NTACRED.Rows.Count - 1
            If CStr(GridNtaCred.Item(i, 0)).Trim.Length >= TxtDato.Text.Trim.Length Then
                If CStr(Mid(CStr(GridNtaCred.Item(i, 0)), 1, TxtDato.Text.Trim.Length)).ToUpper = TxtDato.Text.Trim.ToUpper Then
                    GridNtaCred.CurrentRowIndex = i
                    Exit For
                End If
            End If
        Next

    End Sub

End Class
