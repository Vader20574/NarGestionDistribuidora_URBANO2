Public Class FrmBuscPlanillaCobranza3

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
    Friend WithEvents DgPlanilla As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDato As System.Windows.Forms.TextBox
    Friend WithEvents CboCriterio As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnFiltrar As System.Windows.Forms.Button
    Friend WithEvents DtIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtFin As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CboCriterio = New System.Windows.Forms.ComboBox
        Me.TxtDato = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DgPlanilla = New System.Windows.Forms.DataGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnFiltrar = New System.Windows.Forms.Button
        Me.DtFin = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtIni = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgPlanilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboCriterio)
        Me.GroupBox1.Controls.Add(Me.TxtDato)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(744, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'CboCriterio
        '
        Me.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCriterio.Items.AddRange(New Object() {"NroPlanilla", "Cobrador", "Total"})
        Me.CboCriterio.Location = New System.Drawing.Point(398, 12)
        Me.CboCriterio.Name = "CboCriterio"
        Me.CboCriterio.Size = New System.Drawing.Size(130, 21)
        Me.CboCriterio.TabIndex = 2
        '
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(40, 12)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(236, 20)
        Me.TxtDato.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Criterio : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato : "
        '
        'DgPlanilla
        '
        Me.DgPlanilla.CaptionText = "Doble Click o Enter para Seleccionar"
        Me.DgPlanilla.DataMember = ""
        Me.DgPlanilla.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgPlanilla.Location = New System.Drawing.Point(10, 92)
        Me.DgPlanilla.Name = "DgPlanilla"
        Me.DgPlanilla.ReadOnly = True
        Me.DgPlanilla.Size = New System.Drawing.Size(682, 320)
        Me.DgPlanilla.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnFiltrar)
        Me.GroupBox2.Controls.Add(Me.DtFin)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DtIni)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(682, 44)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(352, 16)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(166, 22)
        Me.BtnFiltrar.TabIndex = 5
        Me.BtnFiltrar.Text = "Filtrar"
        '
        'DtFin
        '
        Me.DtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFin.Location = New System.Drawing.Point(240, 16)
        Me.DtFin.Name = "DtFin"
        Me.DtFin.Size = New System.Drawing.Size(90, 20)
        Me.DtFin.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(194, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasta :"
        '
        'DtIni
        '
        Me.DtIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtIni.Location = New System.Drawing.Point(58, 16)
        Me.DtIni.Name = "DtIni"
        Me.DtIni.Size = New System.Drawing.Size(90, 20)
        Me.DtIni.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Desde :"
        '
        'FrmBuscPlanillaCobranza3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(722, 424)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DgPlanilla)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscPlanillaCobranza3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Pre Planilla "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgPlanilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Private TAB_COBRANZAC As New DataTable
    Public DEVOLVER As Boolean



#End Region

#Region "Funciones Form"

    Private Sub CargarGrid()
        TAB_COBRANZAC = TmpListarDatos("SP_LISTAR_PREPLANILLAS  '" & codempresa & "','" & Format(CDate(DtIni.Value), "dd/MM/yyyy") & "','" & Format(CDate(DtFin.Value), "dd/MM/yyyy") & "'")
        DgPlanilla.DataSource = TAB_COBRANZAC
    End Sub

    Private Sub FormatoGrid()
        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TAB_COBRANZAC.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With

        Dim Column1 As New DataGridTextBoxColumn
        With Column1
            .MappingName = "NROPLANILLA"
            .HeaderText = "Nº Pre Planilla"
            .NullText = ""
            .Width = 100
        End With
        Dim Column2 As New DataGridTextBoxColumn
        With Column2
            .MappingName = "CDCOBRADOR"
            .HeaderText = "CDCOBRADOR"
            .NullText = ""
            .Width = 0
        End With
        Dim Column3 As New DataGridTextBoxColumn
        With Column3
            .MappingName = "NOMCOBRADOR"
            .HeaderText = "Cobrador"
            .NullText = ""
            .Width = 200
        End With

        Dim Column4 As New DataGridTextBoxColumn
        With Column4
            .MappingName = "FECHA"
            .HeaderText = "Fecha"
            .NullText = ""
            .Format = "dd/MM/yyyy"
            .Width = 70
        End With

        Dim Column5 As New DataGridTextBoxColumn
        With Column5
            .MappingName = "TOTALBAS"
            .HeaderText = "Total"
            .NullText = "0.00"
            .Alignment = HorizontalAlignment.Right
            .Format = GMascaraDec(DECIRESU)
            .Width = 75
        End With
        Dim Column6 As New DataGridTextBoxColumn
        With Column6
            .MappingName = "ESTADO"
            .HeaderText = "Estado"
            .NullText = ""
            .Width = 50
        End With

        Dim Column7 As New DataGridTextBoxColumn
        With Column7
            .MappingName = "NROPLANILLAFINAL"
            .HeaderText = "Nº Planilla Final"
            .NullText = ""
            .Width = 100
        End With


        DgPlanilla.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column4, Column1, Column3, Column5, Column6, Column7})
        DgPlanilla.TableStyles.Add(TableStyle1)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_SYSTEM As Integer = &H104

        If (MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_SYSTEM) Then
            Select Case KeyData
                Case Keys.Enter
                    If TAB_COBRANZAC.Rows.Count > 0 Then
                        Try
                            Dim NroPreplanilla As String
                            NroPreplanilla = DgPlanilla.Item(DgPlanilla.CurrentRowIndex, 1)
                            If NroPreplanilla.Trim = "" Then
                                MsgBox("Debe escojer un Pedido  a  buscar ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                                Exit Function
                            End If

                            Dim frmdet As New FrmDetallePrePlanilla
                            frmdet.nropreplan = NroPreplanilla
                            frmdet.ShowDialog()

                        Catch ex As Exception

                        End Try
                    End If
            End Select
        End If

    End Function
#End Region


    Private Sub FrmBuscPlanillaCobranza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtIni.Value = DateAdd(DateInterval.Day, -7, DtIni.Value)
        CargarGrid()
        FormatoGrid()
        CboCriterio.SelectedIndex = 0
        TxtDato.Focus()

    End Sub

    Private Sub BtnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFiltrar.Click
        CargarGrid()
        FormatoGrid()
        CboCriterio.SelectedIndex = 0
        TxtDato.Focus()

    End Sub

    Private Sub TxtDato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDato.TextChanged
        If TAB_COBRANZAC.Rows.Count > 0 Then
            For i As Integer = 0 To TAB_COBRANZAC.Rows.Count - 1
                Select Case CboCriterio.SelectedIndex
                    Case 0
                        If CStr(Mid(DgPlanilla.Item(i, 0), 1, TxtDato.Text.Trim.Length)).ToUpper = CStr(TxtDato.Text.Trim).ToUpper Then
                            DgPlanilla.CurrentRowIndex = i
                            Exit For
                        End If
                    Case 1
                        If DgPlanilla.Item(i, 2).ToString.Trim = "" Then
                            Exit Select
                        End If
                        If CStr(Mid(DgPlanilla.Item(i, 2), 1, TxtDato.Text.Trim.Length)).ToUpper = CStr(TxtDato.Text.Trim).ToUpper Then
                            DgPlanilla.CurrentRowIndex = i
                            Exit For
                        End If

                    Case 2
                        If CStr(Mid(DgPlanilla.Item(i, 3), 1, TxtDato.Text.Trim.Length)).ToUpper = CStr(TxtDato.Text.Trim).ToUpper Then
                            DgPlanilla.CurrentRowIndex = i
                            Exit For
                        End If
                End Select
            Next
        End If
    End Sub

    Private Sub DgPlanilla_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgPlanilla.Navigate

    End Sub

    Private Sub DgPlanilla_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgPlanilla.DoubleClick
        'DEVOLVER = True
        'Me.Close()

        If TAB_COBRANZAC.Rows.Count > 0 Then
            Try
                Dim NroPreplanilla As String
                NroPreplanilla = DgPlanilla.Item(DgPlanilla.CurrentRowIndex, 1)
                If NroPreplanilla.Trim = "" Then
                    MsgBox("Debe escojer un Pedido  a  buscar ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                    Exit Sub
                End If

                Dim frmdet As New FrmDetallePrePlanilla
                frmdet.nropreplan = NroPreplanilla
                frmdet.ShowDialog()

            Catch ex As Exception

            End Try
        End If





    End Sub
End Class
