Public Class FrmListarSolicitudServicio
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridNotaCred As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblMontoAprob As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblPreplanilla As System.Windows.Forms.Label
    Friend WithEvents TxtPrePlanilla As System.Windows.Forms.TextBox
    Friend WithEvents BtnBuscPrePlanilla As System.Windows.Forms.Button
    Friend WithEvents GrpCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblNroPreplanilla As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListarSolicitudServicio))
        Me.GridNotaCred = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblUsuario = New System.Windows.Forms.Label
        Me.LblMontoAprob = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtFecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.LblPreplanilla = New System.Windows.Forms.Label
        Me.TxtPrePlanilla = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LblNroPreplanilla = New System.Windows.Forms.Label
        Me.GrpCabecera = New System.Windows.Forms.GroupBox
        Me.BtnBuscPrePlanilla = New System.Windows.Forms.Button
        CType(Me.GridNotaCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GrpCabecera.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridNotaCred
        '
        Me.GridNotaCred.CaptionText = "                                     "
        Me.GridNotaCred.DataMember = ""
        Me.GridNotaCred.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridNotaCred.Location = New System.Drawing.Point(22, 12)
        Me.GridNotaCred.Name = "GridNotaCred"
        Me.GridNotaCred.ReadOnly = True
        Me.GridNotaCred.Size = New System.Drawing.Size(858, 298)
        Me.GridNotaCred.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUsuario
        '
        Me.LblUsuario.BackColor = System.Drawing.Color.White
        Me.LblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUsuario.Location = New System.Drawing.Point(346, 16)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(164, 23)
        Me.LblUsuario.TabIndex = 3
        Me.LblUsuario.Text = "USUARIO"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblMontoAprob
        '
        Me.LblMontoAprob.BackColor = System.Drawing.Color.White
        Me.LblMontoAprob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoAprob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoAprob.Location = New System.Drawing.Point(1111, 322)
        Me.LblMontoAprob.Name = "LblMontoAprob"
        Me.LblMontoAprob.Size = New System.Drawing.Size(100, 23)
        Me.LblMontoAprob.TabIndex = 7
        Me.LblMontoAprob.Text = "0.00"
        Me.LblMontoAprob.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblMontoAprob.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(922, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Monto Total de Aprobacion: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'DtFecha
        '
        Me.DtFecha.Enabled = False
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(576, 20)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(96, 20)
        Me.DtFecha.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(528, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox4.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox4.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox4.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox4.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox4.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox4.Location = New System.Drawing.Point(911, 79)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(110, 210)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mantenimiento"
        Me.GroupBox4.Visible = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(14, 142)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNCANCELAR.TabIndex = 4
        Me.BTNCANCELAR.TabStop = False
        Me.BTNCANCELAR.Text = "   &Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(14, 174)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNCERRAR.TabIndex = 5
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "   &Cerrar"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(14, 82)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(82, 26)
        Me.BTNMODIFICAR.TabIndex = 2
        Me.BTNMODIFICAR.TabStop = False
        Me.BTNMODIFICAR.Text = "   &Modificar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(14, 112)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.TabStop = False
        Me.BTNELIMINAR.Text = "   &Anular"
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
        'LblPreplanilla
        '
        Me.LblPreplanilla.AutoSize = True
        Me.LblPreplanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPreplanilla.Location = New System.Drawing.Point(907, 9)
        Me.LblPreplanilla.Name = "LblPreplanilla"
        Me.LblPreplanilla.Size = New System.Drawing.Size(130, 20)
        Me.LblPreplanilla.TabIndex = 0
        Me.LblPreplanilla.Text = "Nro Preplanilla:"
        Me.LblPreplanilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblPreplanilla.Visible = False
        '
        'TxtPrePlanilla
        '
        Me.TxtPrePlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrePlanilla.Location = New System.Drawing.Point(1033, 5)
        Me.TxtPrePlanilla.Name = "TxtPrePlanilla"
        Me.TxtPrePlanilla.Size = New System.Drawing.Size(100, 26)
        Me.TxtPrePlanilla.TabIndex = 1
        Me.TxtPrePlanilla.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nro Preplanilla:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNroPreplanilla
        '
        Me.LblNroPreplanilla.BackColor = System.Drawing.Color.White
        Me.LblNroPreplanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroPreplanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroPreplanilla.ForeColor = System.Drawing.Color.Navy
        Me.LblNroPreplanilla.Location = New System.Drawing.Point(96, 10)
        Me.LblNroPreplanilla.Name = "LblNroPreplanilla"
        Me.LblNroPreplanilla.Size = New System.Drawing.Size(100, 30)
        Me.LblNroPreplanilla.TabIndex = 1
        Me.LblNroPreplanilla.Text = "0"
        Me.LblNroPreplanilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpCabecera
        '
        Me.GrpCabecera.Controls.Add(Me.DtFecha)
        Me.GrpCabecera.Controls.Add(Me.Label5)
        Me.GrpCabecera.Controls.Add(Me.Label1)
        Me.GrpCabecera.Controls.Add(Me.LblUsuario)
        Me.GrpCabecera.Controls.Add(Me.LblNroPreplanilla)
        Me.GrpCabecera.Controls.Add(Me.Label6)
        Me.GrpCabecera.Enabled = False
        Me.GrpCabecera.Location = New System.Drawing.Point(911, 29)
        Me.GrpCabecera.Name = "GrpCabecera"
        Me.GrpCabecera.Size = New System.Drawing.Size(774, 44)
        Me.GrpCabecera.TabIndex = 3
        Me.GrpCabecera.TabStop = False
        Me.GrpCabecera.Visible = False
        '
        'BtnBuscPrePlanilla
        '
        Me.BtnBuscPrePlanilla.ImageIndex = 5
        Me.BtnBuscPrePlanilla.ImageList = Me.ImageList1
        Me.BtnBuscPrePlanilla.Location = New System.Drawing.Point(1118, 5)
        Me.BtnBuscPrePlanilla.Name = "BtnBuscPrePlanilla"
        Me.BtnBuscPrePlanilla.Size = New System.Drawing.Size(32, 28)
        Me.BtnBuscPrePlanilla.TabIndex = 2
        Me.BtnBuscPrePlanilla.Visible = False
        '
        'FrmListarSolicitudServicio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1060, 372)
        Me.Controls.Add(Me.GrpCabecera)
        Me.Controls.Add(Me.BtnBuscPrePlanilla)
        Me.Controls.Add(Me.TxtPrePlanilla)
        Me.Controls.Add(Me.LblPreplanilla)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblMontoAprob)
        Me.Controls.Add(Me.GridNotaCred)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmListarSolicitudServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Solicitud Servicio"
        CType(Me.GridNotaCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GrpCabecera.ResumeLayout(False)
        Me.GrpCabecera.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "VARIABLES"
    Public TABLE_NTACREDSERV As New DataTable
    Public obsv As String
#End Region
#Region "FUNCIONES"
    Private Sub FonmatoGrid()
        Dim DataGridTableStyle1 As New DataGridTableStyle
        With DataGridTableStyle1
            .MappingName = TABLE_NTACREDSERV.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim DataColumn1 As New DataGridTextBoxColumn
        With DataColumn1
            .MappingName = "FECHAING"
            .HeaderText = "FECHA"
            .NullText = ""
            .Width = 100
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "HORAING"
            .HeaderText = "HORA"
            .NullText = ""
            .Width = 100
        End With
        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "CODSOL"
            .HeaderText = "N°SOLICITUD"
            .NullText = ""
            .Width = 50
        End With
        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "DESCRIPHAB"
            .HeaderText = "HABITACION"
            .NullText = ""
            .Width = 150
        End With

        Dim DataColumn5 As New DataGridTextBoxColumn
        With DataColumn5
            .MappingName = "AP"
            .HeaderText = "AP.PATERNO"
            .NullText = ""
            .Width = 150
        End With
        Dim DataColumn6 As New DataGridTextBoxColumn
        With DataColumn6
            .MappingName = "AM"
            .HeaderText = "AP.MATERNO"
            .NullText = ""
            .Width = 150
        End With
        Dim DataColumn7 As New DataGridTextBoxColumn
        With DataColumn7
            .MappingName = "NOMB"
            .HeaderText = "NOMB"
            .NullText = ""
            .Width = 150
        End With

       
        GridNotaCred.TableStyles.Clear()
        DataGridTableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5, DataColumn6, DataColumn7})
        GridNotaCred.TableStyles.Add(DataGridTableStyle1)


        'TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11})
        'dgDetalleCobros.TableStyles.Add(TableStyle1)



    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef MSG As Message, ByVal KeyData As Keys) As Boolean
        Const WINKEYdOWN As Integer = &H100
        Const WINKEYSYSTEM As Integer = &H104
        If ((MSG.Msg = WINKEYdOWN) Or (MSG.Msg = WINKEYSYSTEM)) Then
            Select Case (KeyData)
                Case Keys.Enter
                    If GridNotaCred.Focus = True Then
                        If TABLE_NTACREDSERV.Rows.Count > 0 Then
                            If GridNotaCred.CurrentCell.ColumnNumber = 8 Then
                                If GridNotaCred.CurrentRowIndex > -1 Then
                                    Dim FrmOpciones As New FrmOpciones
                                    FrmOpciones.ShowDialog()
                                    If FrmOpciones.DEVOLVER = True Then
                                        For i As Integer = 0 To TABLE_NTACREDSERV.Rows.Count - 1
                                            If TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 1).ToString.Trim _
                                            And TABLE_NTACREDSERV.Rows(i)("NRONTACRED").ToString.Trim = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 2).ToString.Trim Then
                                                ''''''''''''''''''CAMBIAR EL ESTADO DE NTA CRED
                                                Select Case FrmOpciones.Opcion
                                                    Case 1
                                                        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "NO"
                                                    Case 2
                                                        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "SI"
                                                    Case 3
                                                        TABLE_NTACREDSERV.Rows(i)("ESTD_APROB") = "EN PROCESO"
                                                End Select
                                                RecalcularMonto()
                                            End If
                                        Next
                                    End If
                                End If
                            End If




                            If GridNotaCred.CurrentCell.ColumnNumber = 0 Then
                                If GridNotaCred.CurrentRowIndex > -1 Then
                                    Dim fr As New frm_ActuSolicitudServi
                                    ''VNroDoc = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 5).ToString.Trim
                                    ''VCdTipoDoc = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 3).ToString.Trim
                                    'fr.TipoDoc = VCdTipoDoc
                                    'fr.NroDoc = VNroDoc
                                    fr.codsolicitud = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 2).ToString.Trim
                                    'fr.correl = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 1).ToString.Trim
                                    fr.frm = Me
                                    fr.Show()






                                End If
                            End If



                            If GridNotaCred.CurrentCell.ColumnNumber = 5 Then
                                If GridNotaCred.CurrentRowIndex > -1 Then
                                    Dim fr As New FRMFACTURACION3
                                    VCdTipoDoc = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 3).ToString.Trim

                                    VNroDoc = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 5).ToString.Trim
                                    fr.Show()
                                End If
                            End If


                            If GridNotaCred.CurrentCell.ColumnNumber = 4 Then
                                If GridNotaCred.CurrentRowIndex > -1 Then
                                    Dim fr As New RptAnalisisCobro3
                                    VCdTipoDoc = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 3).ToString.Trim

                                    VNroDoc = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 5).ToString.Trim
                                    fr.TipoDoc = VCdTipoDoc
                                    fr.NroDoc = VNroDoc

                                    fr.Show()
                                End If
                            End If



                        End If
                    End If

                Case Keys.F3
                    If GridNotaCred.Focus = True Then
                        For i As Integer = 0 To TABLE_NTACREDSERV.Rows.Count - 1
                            If TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 0).ToString.Trim _
                            And TABLE_NTACREDSERV.Rows(i)("NRONTACRED").ToString.Trim = GridNotaCred.Item(GridNotaCred.CurrentRowIndex, 1).ToString.Trim Then
                                ''''''''''''''''''ELIMINAR
                                TABLE_NTACREDSERV.Rows.RemoveAt(i)
                                RecalcularMonto()
                                Exit For
                            End If
                        Next
                    End If
            End Select
        End If
    End Function


    Private Sub CargarGrid()
        TABLE_NTACREDSERV = TmpListarDatos("SP_LISTAR_SOLICITUD_SERVICIO  '" & codempresa.Trim & "'")
        GridNotaCred.DataSource = TABLE_NTACREDSERV
        FonmatoGrid()

        ' DataGridViewNotaCred.DataSource = TABLE_NTACREDSERV



    End Sub

    Private Sub RecalcularMonto()
        LblMontoAprob.Text = "0.00"
        For i As Integer = 0 To TABLE_NTACREDSERV.Rows.Count - 1
            If TABLE_NTACREDSERV.Rows(i)("ESTD_APROB").ToString.Trim = "SI" Then
                LblMontoAprob.Text = CDbl(LblMontoAprob.Text) + CDbl(TABLE_NTACREDSERV.Rows(i)("TOTBAS").ToString.Trim)
            End If
        Next
        LblMontoAprob.Text = Format(CDbl(LblMontoAprob.Text), "#######0.00")
    End Sub

    Private Sub Nuevo()
        Limpiar()
        LblPreplanilla.Visible = False
        TxtPrePlanilla.Visible = False
        BtnBuscPrePlanilla.Visible = False
        GrpCabecera.Enabled = True
        LblNroPreplanilla.Text = TmpListarDatos("NSP_CREAR_NRO_PREPLANTACRED  '" & codempresa & "'").Rows(0)("NROPREPLANILLA").ToString.Trim
        BTNGUARDAR.Enabled = True
        LblUsuario.Text = CodUsuario
    End Sub
    Private Sub Cancelar()
        LblPreplanilla.Visible = True
        TxtPrePlanilla.Visible = True
        BtnBuscPrePlanilla.Visible = True
        BTNGUARDAR.Enabled = False
        GrpCabecera.Enabled = False
        Limpiar()
    End Sub
    Private Sub Limpiar()
        DtFecha.Value = Date.Now
        TxtPrePlanilla.Text = ""
        LblNroPreplanilla.Text = ""
        LblMontoAprob.Text = "0.00"
        TABLE_NTACREDSERV.Clear()
    End Sub

#End Region

    Private Sub FrmPreplanillaDeAprobacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DtFecha.Value = Format(vFechaActual, "dd/MM/yyyy")


        'Nuevo()
        CargarGrid()



    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Nuevo()
        CargarGrid()
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()

    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Cancelar()

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click



        '************************************************************************************************
        Dim TB_VALIDAR_FINMES As DataTable
        Dim AÑO As String
        Dim MES As String
        Dim DESMES As String = ""

        AÑO = DtFecha.Value.Year
        MES = DtFecha.Value.Month

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





        If TABLE_NTACREDSERV.Rows.Count = 0 Then
            Exit Sub
        End If
        If TxtPrePlanilla.Visible = True Then
            For i As Integer = 0 To TABLE_NTACREDSERV.Rows.Count - 1
                If TABLE_NTACREDSERV.Rows(i)("ESTD_APROB").ToString.Trim = "NO" Then
                    TmpInsertDatos("NSP_ELI_CORREL_NTACREDCABSER  '" & codempresa & "','" & TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim & "','" & TABLE_NTACREDSERV.Rows(i)("NRONTACRED").ToString.Trim & "'  ")
                ElseIf TABLE_NTACREDSERV.Rows(i)("ESTD_APROB").ToString.Trim = "EN PROCESO" Then
                    TmpInsertDatos("NSP_GUARDAR_ENPROCESO_NTACRED  '" & codempresa & "','" & TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim & "','" & TABLE_NTACREDSERV.Rows(i)("NRONTACRED").ToString.Trim & "'  ")
                End If
            Next
            MsgBox("SE GUARDO CORRECTAMENTE...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Cancelar()
        Else
            Try
                If LblNroPreplanilla.Text.Trim = "" Then
                    MsgBox("FALTA EL NRO DE PREPLANILLA A CREAR...", MsgBoxStyle.Exclamation, "NAR SISTEMA S.A.C.")
                    Exit Sub
                End If
                For i As Integer = 0 To TABLE_NTACREDSERV.Rows.Count - 1
                    If TABLE_NTACREDSERV.Rows(i)("ESTD_APROB").ToString.Trim = "NO" Then
                        TmpInsertDatos("NSP_ELI_CORREL_NTACREDCABSER  '" & codempresa & "','" & TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim & "','" & TABLE_NTACREDSERV.Rows(i)("NRONTACRED").ToString.Trim & "'  ")
                    ElseIf TABLE_NTACREDSERV.Rows(i)("ESTD_APROB").ToString.Trim = "SI" Then
                        TmpInsertDatos("NSP_GUARDAR_PREPLANILLA  '" & codempresa & "','" & LblNroPreplanilla.Text & "','" & TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim & "','" & TABLE_NTACREDSERV.Rows(i)("NRONTACRED").ToString.Trim & "'  ")
                    ElseIf TABLE_NTACREDSERV.Rows(i)("ESTD_APROB").ToString.Trim = "EN PROCESO" Then
                        TmpInsertDatos("NSP_GUARDAR_ENPROCESO_NTACRED  '" & codempresa & "','" & TABLE_NTACREDSERV.Rows(i)("CORRNBR").ToString.Trim & "','" & TABLE_NTACREDSERV.Rows(i)("NRONTACRED").ToString.Trim & "'  ")
                    End If
                Next
                MsgBox("SE GUARDO CORRECTAMENTE LA PREPLANILLA.." & vbNewLine & "NRO " & LblNroPreplanilla.Text, MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                Cancelar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub
    Private Sub BtnBuscPrePlanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscPrePlanilla.Click
        Dim Frm As New FrmBusqPreplanillaNtaCred
        Frm.ShowDialog()
        If Frm.DEVOLVER = False Then
            Exit Sub
        End If
        TxtPrePlanilla.Text = Frm.GridBusq.Item(Frm.GridBusq.CurrentRowIndex, 0)
        TABLE_NTACREDSERV = TmpListarDatos("NSP_TRAER_PREPLANILLA  '" & codempresa & "','" & Frm.GridBusq.Item(Frm.GridBusq.CurrentRowIndex, 0) & "' ")
        GridNotaCred.DataSource = TABLE_NTACREDSERV
        FonmatoGrid()

        BTNMODIFICAR.Enabled = True
        GridNotaCred.Enabled = False

    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click



        Dim Proceso As String
        Proceso = "ANULPREPLANAPROB"
        If SELECT_PERMISO_PROC(Proceso, CodUsuario) = False Then
            Dim o As New FrmIngresaUsuClave
            o.Proceso = Proceso
            o.ShowDialog()
            If o.DEVOLVER = False Then
                Exit Sub
            End If
        End If


        If TxtPrePlanilla.Text.Trim.Length = 0 Then
            MsgBox("- SELECCIONE UNA PREPLANILLA.", MsgBoxStyle.Information, "NARSISTEMAS")
            Exit Sub
        End If
        If TmpInsertDatos("NSP_ANULAR_PREPLAN_NTACREDSER  '" & codempresa & "','" & TxtPrePlanilla.Text & "'") = True Then
            MsgBox("SE ANULO CORRECTAMENTE LA PREPLANILLA" & vbNewLine & "NRO " & TxtPrePlanilla.Text, MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Cancelar()
        Else
            MsgBox("NO SE PUDO ANULAR CONSULTE CON EL ADMINISTRADOR ", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
        End If
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        BTNGUARDAR.Enabled = True
        BTNMODIFICAR.Enabled = False
        GridNotaCred.Enabled = True
    End Sub

    Private Sub DataGridViewNotaCred_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)




    End Sub

    Private Sub GridNotaCred_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridNotaCred.CurrentCellChanged

    End Sub

    Private Sub GridNotaCred_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles GridNotaCred.Navigate

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fr As New FRMFACTURACION3
        fr.Show()
    End Sub
End Class
