Public Class FrmBusqDocumContable
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents DtFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DtgDocum As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DtgDocum = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.DtFecFin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtFecIni = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DtgDocum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgDocum
        '
        Me.DtgDocum.CaptionText = "                                                     Seleccionar  --> [Enter]  ó " & _
        "[Doble Click]"
        Me.DtgDocum.DataMember = ""
        Me.DtgDocum.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DtgDocum.Location = New System.Drawing.Point(10, 116)
        Me.DtgDocum.Name = "DtgDocum"
        Me.DtgDocum.ReadOnly = True
        Me.DtgDocum.Size = New System.Drawing.Size(680, 262)
        Me.DtgDocum.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtDato)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 40)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(456, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Filtrar :"
        Me.Label3.Visible = False
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(50, 10)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(304, 20)
        Me.TxtDato.TabIndex = 2
        Me.TxtDato.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Dato :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox1.Controls.Add(Me.DtFecFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DtFecIni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 46)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(326, 14)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(82, 23)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'DtFecFin
        '
        Me.DtFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFecFin.Location = New System.Drawing.Point(210, 16)
        Me.DtFecFin.Name = "DtFecFin"
        Me.DtFecFin.Size = New System.Drawing.Size(90, 20)
        Me.DtFecFin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(172, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta :"
        '
        'DtFecIni
        '
        Me.DtFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short
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
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'FrmBusqDocumContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(700, 394)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtgDocum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBusqDocumContable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Documento Contable"
        CType(Me.DtgDocum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "VARIABLES  FORM"
    Public DEVOLVER As Boolean
    Private TAB_DOC As New DataTable



#End Region

#Region "FUNCIONES FORM"


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If DtgDocum.Focus = True Then
                        If TAB_DOC.Rows.Count > 0 Then
                            DEVOLVER = True
                            Me.Close()
                        End If
                    End If

                Case Keys.Escape
                    Me.Close()

            End Select


        End If



    End Function
    Private Sub CargarGrid()
        TAB_DOC = TmpListarDatos("ListarDOCUMCONTABLExProc  '" & codempresa & "','" & Format(CDate(DtFecIni.Value), "dd/MM/yyyy") & "','" & Format(CDate(DtFecFin.Value), "dd/MM/yyyy") & "'")
        DtgDocum.DataSource = TAB_DOC
    End Sub

    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_DOC.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "CODTIPODOC"
            .HeaderText = "CODTIPODOC"
            .NullText = ""
            .Width = 0
        End With

        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "DSTIPODOC"
            .HeaderText = "DSTIPODOC"
            .NullText = ""
            .Width = 200
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "NRODOCUM"
            .HeaderText = "NRODOCUM"
            .NullText = ""
            .Width = 75
        End With
        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "FECDOCUM"
            .HeaderText = "FECDOCUM"
            .NullText = ""
            .Format = "dd/MM/yyyy"
            .Width = 75
        End With
        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "CODPROVEEDOR"
            .HeaderText = "CODPROVEEDOR"
            .NullText = ""
            .Width = 0
        End With

        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "DESPROVEEDOR"
            .HeaderText = "DESPROVEEDOR"
            .NullText = ""
            .Width = 200
        End With
        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "RUC"
            .HeaderText = "RUC"
            .NullText = ""
            .Width = 0
        End With

        Dim Column8 As New DataGridTextBoxColumn
        With Column8
            .MappingName = "MONTOBAS"
            .HeaderText = "MONTOBAS"
            .NullText = ""
            .Alignment = HorizontalAlignment.Right
            .Format = "#######0.00"
            .Width = 75
        End With

        Dim Column9 As New DataGridTextBoxColumn
        With Column9
            .MappingName = "EJERCICIO"
            .HeaderText = "EJERCICIO"
            .NullText = ""
            .Width = 0
        End With

        Dim Column10 As New DataGridTextBoxColumn
        With Column10
            .MappingName = "PERIODO"
            .HeaderText = "PERIODO"
            .NullText = ""
            .Width = 0
        End With

        Dim Column11 As New DataGridTextBoxColumn
        With Column11
            .MappingName = "OBS"
            .HeaderText = "OBS"
            .NullText = ""
            .Width = 0
        End With

        Dim Column12 As New DataGridTextBoxColumn
        With Column12
            .MappingName = "ESTADO"
            .HeaderText = "ESTADO"
            .NullText = ""
            .Width = 30
        End With

        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12})
        DtgDocum.TableStyles.Clear()
        DtgDocum.TableStyles.Add(TableStyle1)
    End Sub


#End Region
    Private Sub FrmBusqDocumContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtFecIni.Value = DateAdd(DateInterval.Day, -7, DtFecIni.Value)
        BtnFiltrar_Click(sender, e)
        TxtDato.Focus()


    End Sub

    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        CargarGrid()
        FormatoGrid()
    End Sub
End Class
