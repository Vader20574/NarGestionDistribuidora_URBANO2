Public Class FrmPlanilla_Liquid_NtaCred
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
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LblMontoAprob As System.Windows.Forms.Label
    Friend WithEvents BtnBusNta As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridNotaCred As System.Windows.Forms.DataGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents Grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblNroPlanilla As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlanilla_Liquid_NtaCred))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LblMontoAprob = New System.Windows.Forms.Label
        Me.BtnBusNta = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblUsuario = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GridNotaCred = New System.Windows.Forms.DataGrid
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Grp1 = New System.Windows.Forms.GroupBox
        Me.LblNroPlanilla = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        CType(Me.GridNotaCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Grp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(466, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        '
        'LblMontoAprob
        '
        Me.LblMontoAprob.BackColor = System.Drawing.Color.White
        Me.LblMontoAprob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoAprob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoAprob.Location = New System.Drawing.Point(456, 310)
        Me.LblMontoAprob.Name = "LblMontoAprob"
        Me.LblMontoAprob.Size = New System.Drawing.Size(100, 23)
        Me.LblMontoAprob.TabIndex = 8
        Me.LblMontoAprob.Text = "0.00"
        Me.LblMontoAprob.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnBusNta
        '
        Me.BtnBusNta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusNta.ImageIndex = 5
        Me.BtnBusNta.ImageList = Me.ImageList1
        Me.BtnBusNta.Location = New System.Drawing.Point(394, 2)
        Me.BtnBusNta.Name = "BtnBusNta"
        Me.BtnBusNta.Size = New System.Drawing.Size(32, 28)
        Me.BtnBusNta.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(266, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Monto Total de Aprobacion: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUsuario
        '
        Me.LblUsuario.BackColor = System.Drawing.Color.White
        Me.LblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUsuario.Location = New System.Drawing.Point(258, 20)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(100, 23)
        Me.LblUsuario.TabIndex = 3
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridNotaCred
        '
        Me.GridNotaCred.DataMember = ""
        Me.GridNotaCred.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridNotaCred.Location = New System.Drawing.Point(8, 56)
        Me.GridNotaCred.Name = "GridNotaCred"
        Me.GridNotaCred.ReadOnly = True
        Me.GridNotaCred.Size = New System.Drawing.Size(558, 250)
        Me.GridNotaCred.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha Aprobacion: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox4.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox4.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox4.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox4.Location = New System.Drawing.Point(590, 94)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(110, 152)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mantenimiento"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(16, 86)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNCANCELAR.TabIndex = 2
        Me.BTNCANCELAR.TabStop = False
        Me.BTNCANCELAR.Text = "   &Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(16, 120)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNCERRAR.TabIndex = 3
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "   &Cerrar"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(14, 22)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(83, 25)
        Me.BTNNUEVO.TabIndex = 0
        Me.BTNNUEVO.TabStop = False
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Enabled = False
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(14, 52)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.TabStop = False
        Me.BTNGUARDAR.Text = "   &Guardar"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(296, 2)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Planilla:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Grp1
        '
        Me.Grp1.Controls.Add(Me.LblNroPlanilla)
        Me.Grp1.Controls.Add(Me.Label6)
        Me.Grp1.Controls.Add(Me.DateTimePicker1)
        Me.Grp1.Controls.Add(Me.Label5)
        Me.Grp1.Controls.Add(Me.LblUsuario)
        Me.Grp1.Controls.Add(Me.Label1)
        Me.Grp1.Controls.Add(Me.GridNotaCred)
        Me.Grp1.Controls.Add(Me.LblMontoAprob)
        Me.Grp1.Controls.Add(Me.Label4)
        Me.Grp1.Location = New System.Drawing.Point(14, 28)
        Me.Grp1.Name = "Grp1"
        Me.Grp1.Size = New System.Drawing.Size(572, 346)
        Me.Grp1.TabIndex = 3
        Me.Grp1.TabStop = False
        '
        'LblNroPlanilla
        '
        Me.LblNroPlanilla.BackColor = System.Drawing.Color.White
        Me.LblNroPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroPlanilla.Location = New System.Drawing.Point(80, 20)
        Me.LblNroPlanilla.Name = "LblNroPlanilla"
        Me.LblNroPlanilla.Size = New System.Drawing.Size(78, 23)
        Me.LblNroPlanilla.TabIndex = 1
        Me.LblNroPlanilla.Text = "0"
        Me.LblNroPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nro Planilla:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmPlanilla_Liquid_NtaCred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(708, 386)
        Me.Controls.Add(Me.BtnBusNta)
        Me.Controls.Add(Me.Grp1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPlanilla_Liquid_NtaCred"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Liquidacion  [ Nota de Credito de  Cliente]"
        CType(Me.GridNotaCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.Grp1.ResumeLayout(False)
        Me.Grp1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "VARIABLES"
    Private TABLE_NTA_CRED As New DataTable
    Dim VCONSULTAR As Boolean

#End Region


#Region "FUNCIONES"



    Private Sub FormatoGrid()

        Dim DataGridStyle1 As New DataGridTableStyle
        With DataGridStyle1
            .MappingName = TABLE_NTA_CRED.TableName
            .PreferredColumnWidth = 150
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "PREPLANILLA"
            .HeaderText = "#PREPLANILLA"
            .Alignment = HorizontalAlignment.Center
            .NullText = ""
            .Width = 100
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "FECHAPREPLAN"
            .HeaderText = "FECHA"
            .NullText = ""
            .Width = 150
        End With

        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "CANTDOC"
            .HeaderText = "CANTIDAD DE DOCUMENTOS"
            .NullText = ""
            .Alignment = HorizontalAlignment.Right
            .Width = 30
        End With

        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "SUBTOTBAS"
            .HeaderText = "SUBTOTAL"
            .NullText = "0.00"
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .Width = 75
        End With
        Dim DataColumn5 As New DataGridTextBoxColumn
        With DataColumn5
            .MappingName = "IGVBAS"
            .HeaderText = "IGV"
            .NullText = "0.00"
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .Width = 75
        End With

        Dim DataColumn6 As New DataGridTextBoxColumn
        With DataColumn6
            .MappingName = "TOTBAS"
            .HeaderText = "TOTAL"
            .NullText = "0.00"
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .Width = 75
        End With

        GridNotaCred.TableStyles.Clear()
        DataGridStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() _
        {DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5, DataColumn6})
        GridNotaCred.TableStyles.Add(DataGridStyle1)

    End Sub




    Private Sub CargarGrid()
        Dim titulo As String
        TABLE_NTA_CRED = TmpListarDatos("NSP_SELECT_PREPLANILLA  '" & codempresa & "'")
        titulo = "[F3]Para eliminar--------[ENTER]Para ver Detalle"
        GridNotaCred.CaptionText = Space(CInt(40 / 2)) & titulo & Space(CInt(40 / 2))
        GridNotaCred.DataSource = TABLE_NTA_CRED
        FormatoGrid()
        Dim Monto As Double
        For i As Integer = 0 To TABLE_NTA_CRED.Rows.Count - 1
            Monto = Monto + CDbl(TABLE_NTA_CRED.Rows(i)("TOTBAS").ToString.Trim)
        Next
        LblMontoAprob.Text = Format(Monto, "#######0.00")
    End Sub


    Private Sub CargarGrid2(ByVal NRO As Integer)
        Dim titulo As String

        TABLE_NTA_CRED = TmpListarDatos("NSP_SELECT_PREPLANILLA_2  '" & codempresa & "','" & NRO & "'")
        titulo = "[F3]Para eliminar--------[ENTER]Para ver Detalle"
        GridNotaCred.CaptionText = Space(CInt(40 / 2)) & titulo & Space(CInt(40 / 2))
        GridNotaCred.DataSource = TABLE_NTA_CRED
        FormatoGrid()
        Dim Monto As Double
        For i As Integer = 0 To TABLE_NTA_CRED.Rows.Count - 1
            Monto = Monto + CDbl(TABLE_NTA_CRED.Rows(i)("TOTBAS").ToString.Trim)
        Next
        LblMontoAprob.Text = Format(Monto, "#######0.00")
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WD_KEYDOWN As Integer = &H100
        Const WD_KEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WD_KEYDOWN) Or (MSG.Msg = WD_KEYSYSTEM)) Then
            Select Case KeyData
                Case Keys.Enter
                    If TABLE_NTA_CRED.Rows.Count > 0 Then

                        If VCONSULTAR = False Then
                            If GridNotaCred.Focus = True Then
                                Dim FRM As New FrmBuscDetPreplanilla
                                FRM.LblNroPlanilla.Text = LblNroPlanilla.Text
                                FRM.LblNroPreplanilla.Text = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 0).ToString.Trim
                                FRM.CARGAR_GRID()
                                FRM.ShowDialog()
                            End If
                        End If


                        If VCONSULTAR = True Then
                            If GridNotaCred.Focus = True Then
                                Dim FRM As New FrmBuscDetplanilla
                                FRM.LblNroPlanilla.Text = LblNroPlanilla.Text
                                FRM.LblNroPreplanilla.Text = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 0).ToString.Trim
                                FRM.CARGAR_GRID()
                                FRM.ShowDialog()
                            End If
                        End If

                    End If

            End Select


        End If




    End Function

#End Region


    Private Sub FrmPlanilla_Liquid_NtaCred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblUsuario.Text = CodUsuario.Trim
        Me.DateTimePicker1.Value = Format(vFechaActual, "dd/MM/yyyy")

    End Sub

    Private Sub BtnBusNta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusNta.Click
        Dim FrmBus As New FrmBusqPlanilla
        FrmBus.ShowDialog()
        If FrmBus.DEVOLVER = False Then

            Exit Sub

        Else
            VCONSULTAR = True
            Dim numPlanilla As Integer
            numPlanilla = FrmBus.GridBusq.Item(FrmBus.GridBusq.CurrentRowIndex, 0)
            LblNroPlanilla.Text = numPlanilla
            CargarGrid2(numPlanilla)

        End If

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Dim TABLE_1 As DataTable
        TABLE_1 = TmpListarDatos("NSP_SELECT_PREPLANILLA2  '" & codempresa & "'")

    

        Dim TABLE_2 As DataTable

        Dim NRODOC As String
        Dim TIPODOC As String
        Dim TOTAL As Double
        Dim SALDO As Double
        For X As Integer = 0 To TABLE_1.Rows.Count - 1

            NRODOC = TABLE_1.Rows(X)(0).ToString()

            TIPODOC = TABLE_1.Rows(X)(1).ToString()

            TABLE_2 = TmpListarDatos("SP_TOTAL_VENTA_X_COBRA  '" & NRODOC & "','" & TIPODOC & "'")

            If TABLE_2.Rows.Count > 0 Then
                TOTAL = TABLE_2.Rows(0)(0).ToString()
            End If

            Dim TABLE_3 As DataTable
            TABLE_3 = TmpListarDatos("SP_SALDONC  '" & NRODOC & "','" & TIPODOC & "'")
            If TABLE_3.Rows.Count > 0 Then
                SALDO = TABLE_3.Rows(0)(0).ToString()
            End If

            If SALDO > TOTAL Then
                MsgBox("EL SALDO DEL DOCU: " & NRODOC & " ES MAYOR")
                Exit Sub
            End If

        Next


        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DateTimePicker1.Value.Year
        MES = DateTimePicker1.Value.Month

        Select Case MES
            Case 1
                DESMES = "ENERO"
            Case 2
                DESMES = "FEBRERO"
            Case 3
                DESMES = "MARZO"
            Case 4
                DESMES = "ABRIL"
            Case 5
                DESMES = "MAYO"
            Case 6
                DESMES = "JUNIO"
            Case 7
                DESMES = "JULIO"
            Case 8
                DESMES = "AGOSTO"
            Case 9
                DESMES = "SETIEMBRE"
            Case 10
                DESMES = "OCTUBRE"
            Case 11
                DESMES = "NOVIEMBRE"
            Case 12
                DESMES = "DECIEMBRE"
        End Select

        TB_VALIDAR_FINMES = TmpListarDatos("SP_VALIDAR_FINMES '" & codempresa & "','" & AÑO & "','" & MES & "'")

        If TB_VALIDAR_FINMES.Rows.Count > 0 Then

        Else
            MsgBox("NO SE PUEDE GUARDAR POR QUE EL AÑO " & AÑO & " Y MES " & DESMES & " ESTA DESACTIVADO EN CIERRE DE MES")
            Exit Sub
        End If
        '************************************************************************************************




        If TABLE_NTA_CRED.Rows.Count = 0 Then
            MsgBox("NO HAY DATOS PARA GUARDAR..", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If
        For i As Integer = 0 To TABLE_NTA_CRED.Rows.Count - 1
            If TmpInsertDatos("NSP_INS_PLANILLA_NTACREDCABSER '" & codempresa & "' ,'" & TABLE_NTA_CRED.Rows(i)("PREPLANILLA").ToString.Trim & "','" & LblNroPlanilla.Text.Trim & "' ,'" & TABLE_NTA_CRED.Rows(i)("NRONTACRED").ToString.Trim & "'") = False Then
                Exit Sub
            End If
        Next
        Dim TABLE_PLANILLA As New DataTable
        TABLE_PLANILLA = TmpListarDatos("NSP_PLANILLA_NTACREDCABSER  '" & codempresa & "','" & LblNroPlanilla.Text.Trim & "' ")
        For fil As Integer = 0 To TABLE_PLANILLA.Rows.Count - 1
            'IF  TmpListarDatos ("NSP_BUSC_NTACREDCABSER  '"&  &"'")

            If TmpInsertDatos("NSP_ins_NTACREDCABSER_DEL_TEMPORAL   '" & codempresa & "','" & TABLE_PLANILLA.Rows(fil)("NRONTACRED").ToString.Trim & "'") = False Then
                Exit Sub
            End If
        Next
        For i As Integer = 0 To TABLE_NTA_CRED.Rows.Count - 1
            If TmpInsertDatos("NSP_DELETE_PREPLANILLA '" & codempresa & "' ,'" & TABLE_NTA_CRED.Rows(i)("PREPLANILLA").ToString.Trim & "' ") = False Then
                'Exit Sub
            End If
        Next

        MsgBox("SE GUARDO CORRECTAMENTE LA PLANILLA CON EL NUMERO " & LblNroPlanilla.Text & "...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        BTNCANCELAR_Click(sender, e)

    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        LblNroPlanilla.Text = TmpListarDatos("NSP_MAXNRO_PLAN_NTACREDCABSER  '" & codempresa & "'").Rows(0)(0).ToString.Trim
        If TmpInsertDatos("NSP_DELETE_PREPLANILLA_2 '" & codempresa & "' ,'" & LblNroPlanilla.Text & "' ") = False Then

        End If
        CargarGrid()
        BTNGUARDAR.Enabled = True
        VCONSULTAR = False
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()

    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        LblNroPlanilla.Text = "0"
        TABLE_NTA_CRED.Rows.Clear()
        BTNGUARDAR.Enabled = True

    End Sub

    Private Sub GridNotaCred_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridNotaCred.BindingContextChanged

    End Sub

    Private Sub GridNotaCred_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridNotaCred.Navigate

    End Sub
End Class
