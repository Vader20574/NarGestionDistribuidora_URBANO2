Public Class FrmBuscDetplanilla
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
    Friend WithEvents GrpCabecera As System.Windows.Forms.GroupBox
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents LblNroPreplanilla As System.Windows.Forms.Label
    Friend WithEvents GridNotaCred As System.Windows.Forms.DataGrid
    Friend WithEvents LblPreplanilla As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblMontoAprob As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents LblNroPlanilla As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscDetplanilla))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GrpCabecera = New System.Windows.Forms.GroupBox
        Me.LblNroPlanilla = New System.Windows.Forms.Label
        Me.DtFecha = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LblUsuario = New System.Windows.Forms.Label
        Me.LblNroPreplanilla = New System.Windows.Forms.Label
        Me.LblPreplanilla = New System.Windows.Forms.Label
        Me.GridNotaCred = New System.Windows.Forms.DataGrid
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblMontoAprob = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnreporte = New System.Windows.Forms.Button
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport
        Me.GrpCabecera.SuspendLayout()
        CType(Me.GridNotaCred, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'GrpCabecera
        '
        Me.GrpCabecera.Controls.Add(Me.Label2)
        Me.GrpCabecera.Controls.Add(Me.LblNroPlanilla)
        Me.GrpCabecera.Controls.Add(Me.DtFecha)
        Me.GrpCabecera.Controls.Add(Me.Label5)
        Me.GrpCabecera.Controls.Add(Me.Label1)
        Me.GrpCabecera.Controls.Add(Me.LblUsuario)
        Me.GrpCabecera.Controls.Add(Me.LblNroPreplanilla)
        Me.GrpCabecera.Controls.Add(Me.LblPreplanilla)
        Me.GrpCabecera.Enabled = False
        Me.GrpCabecera.Location = New System.Drawing.Point(14, 8)
        Me.GrpCabecera.Name = "GrpCabecera"
        Me.GrpCabecera.Size = New System.Drawing.Size(917, 44)
        Me.GrpCabecera.TabIndex = 38
        Me.GrpCabecera.TabStop = False
        '
        'LblNroPlanilla
        '
        Me.LblNroPlanilla.BackColor = System.Drawing.Color.White
        Me.LblNroPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroPlanilla.ForeColor = System.Drawing.Color.Navy
        Me.LblNroPlanilla.Location = New System.Drawing.Point(116, 10)
        Me.LblNroPlanilla.Name = "LblNroPlanilla"
        Me.LblNroPlanilla.Size = New System.Drawing.Size(100, 30)
        Me.LblNroPlanilla.TabIndex = 36
        Me.LblNroPlanilla.Text = "0"
        Me.LblNroPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtFecha
        '
        Me.DtFecha.Enabled = False
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(807, 18)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(96, 20)
        Me.DtFecha.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(759, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Fecha: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(523, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUsuario
        '
        Me.LblUsuario.BackColor = System.Drawing.Color.White
        Me.LblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblUsuario.Location = New System.Drawing.Point(577, 14)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(164, 23)
        Me.LblUsuario.TabIndex = 2
        Me.LblUsuario.Text = "USUARIO"
        Me.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNroPreplanilla
        '
        Me.LblNroPreplanilla.BackColor = System.Drawing.Color.White
        Me.LblNroPreplanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblNroPreplanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNroPreplanilla.ForeColor = System.Drawing.Color.Navy
        Me.LblNroPreplanilla.Location = New System.Drawing.Point(367, 8)
        Me.LblNroPreplanilla.Name = "LblNroPreplanilla"
        Me.LblNroPreplanilla.Size = New System.Drawing.Size(100, 30)
        Me.LblNroPreplanilla.TabIndex = 29
        Me.LblNroPreplanilla.Text = "0"
        Me.LblNroPreplanilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPreplanilla
        '
        Me.LblPreplanilla.AutoSize = True
        Me.LblPreplanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPreplanilla.Location = New System.Drawing.Point(239, 12)
        Me.LblPreplanilla.Name = "LblPreplanilla"
        Me.LblPreplanilla.Size = New System.Drawing.Size(130, 20)
        Me.LblPreplanilla.TabIndex = 35
        Me.LblPreplanilla.Text = "Nro Preplanilla:"
        Me.LblPreplanilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridNotaCred
        '
        Me.GridNotaCred.DataMember = ""
        Me.GridNotaCred.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.GridNotaCred.Location = New System.Drawing.Point(12, 58)
        Me.GridNotaCred.Name = "GridNotaCred"
        Me.GridNotaCred.ReadOnly = True
        Me.GridNotaCred.Size = New System.Drawing.Size(842, 284)
        Me.GridNotaCred.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(310, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Monto Total de Aprobacion: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblMontoAprob
        '
        Me.LblMontoAprob.BackColor = System.Drawing.Color.White
        Me.LblMontoAprob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblMontoAprob.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoAprob.Location = New System.Drawing.Point(543, 364)
        Me.LblMontoAprob.Name = "LblMontoAprob"
        Me.LblMontoAprob.Size = New System.Drawing.Size(100, 48)
        Me.LblMontoAprob.TabIndex = 33
        Me.LblMontoAprob.Text = "0.00"
        Me.LblMontoAprob.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSalir)
        Me.GroupBox5.Controls.Add(Me.btnreporte)
        Me.GroupBox5.Location = New System.Drawing.Point(666, 350)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(188, 72)
        Me.GroupBox5.TabIndex = 162
        Me.GroupBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSalir.ImageIndex = 0
        Me.BtnSalir.ImageList = Me.ImageList2
        Me.BtnSalir.Location = New System.Drawing.Point(6, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(59, 54)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Nro Planilla:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(79, 14)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(85, 52)
        Me.btnreporte.TabIndex = 163
        Me.btnreporte.TabStop = False
        Me.btnreporte.Text = "&Reporte"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(903, 125)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 164
        '
        'FrmBuscDetplanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(943, 428)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GrpCabecera)
        Me.Controls.Add(Me.GridNotaCred)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblMontoAprob)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmBuscDetplanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLE DE PREPLANILLA"
        Me.GrpCabecera.ResumeLayout(False)
        Me.GrpCabecera.PerformLayout()
        CType(Me.GridNotaCred, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "VARIABLES"
    Dim TABLE_NTACREDSERV As New DataTable

#End Region

    Dim fechaini, fechahas As Date
#Region "FUNCIONES"

    Public Sub CARGAR_GRID()
        
    End Sub
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
            .MappingName = "CORRNBR"
            .HeaderText = "CORRNBR"
            .NullText = ""
            .Width = 50
        End With
        Dim DataColumn2 As New DataGridTextBoxColumn
        With DataColumn2
            .MappingName = "NRONTACRED"
            .HeaderText = "NOTA DE CREDITO"
            .NullText = ""
            .Width = 100
        End With
        Dim DataColumn3 As New DataGridTextBoxColumn
        With DataColumn3
            .MappingName = "CDTIPODOC"
            .HeaderText = "TIPODOC"
            .NullText = ""
            .Width = 0
        End With
        Dim DataColumn4 As New DataGridTextBoxColumn
        With DataColumn4
            .MappingName = "DSTIPODOC"
            .HeaderText = "TIPODOC"
            .NullText = ""
            .Width = 120
        End With

        Dim DataColumn5 As New DataGridTextBoxColumn
        With DataColumn5
            .MappingName = "NROREFE"
            .HeaderText = "NRO REFERENCIA"
            .NullText = ""
            .Width = 100
        End With
        Dim DataColumn6 As New DataGridTextBoxColumn
        With DataColumn6
            .MappingName = "PRODUCTO"
            .HeaderText = "MOTIVO"
            .NullText = ""
            .Width = 265
        End With
        Dim DataColumn7 As New DataGridTextBoxColumn
        With DataColumn7
            .MappingName = "TOTBAS"
            .HeaderText = "MONTO"
            .NullText = ""
            .Format = "#######0.00"
            .Alignment = HorizontalAlignment.Right
            .Width = 75
        End With

        Dim DataColumn8 As New DataGridTextBoxColumn
        With DataColumn8
            .MappingName = "ESTD_APROB"
            .HeaderText = "APROBACION"
            .NullText = ""
            .Width = 0
        End With

        DataGridTableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {DataColumn1, DataColumn2, DataColumn3, DataColumn4, DataColumn5, DataColumn6, DataColumn7, DataColumn8})
        GridNotaCred.TableStyles.Add(DataGridTableStyle1)
    End Sub

#End Region

    Private Sub FrmBuscDetPreplanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click


        Try
            With AxCrystalReport1
                .ReportFileName = RutaRptInv & "RptPlanillaNotaCredito.rpt"
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
                .set_Formulas(0, "Empresa='" & DesEmpresa & "'")
                .set_Formulas(1, "Usuario='" & DesUsuario & "'")
                .set_StoredProcParam(0, codempresa)
                .set_StoredProcParam(1, LblNroPlanilla.Text.Trim)
                .set_StoredProcParam(2, LblNroPreplanilla.Text.Trim)

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class
