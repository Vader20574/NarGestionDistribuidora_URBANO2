Public Class FrmDescuentoXVol_Familia
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Rpt1 As AxCrystal.AxCrystalReport
    Friend WithEvents DgDescuentoxVolumenes As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtDescPorc As System.Windows.Forms.TextBox
    Friend WithEvents GrDatos As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboIntervalo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSubCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents CODINTERV As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MONTOPORC As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SUBCATEGORIA As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDescuentoXVol_Familia))
        Me.GrDatos = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCategoria = New System.Windows.Forms.ComboBox
        Me.DgDescuentoxVolumenes = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.CODINTERV = New System.Windows.Forms.DataGridTextBoxColumn
        Me.SUBCATEGORIA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESCRIPCION = New System.Windows.Forms.DataGridTextBoxColumn
        Me.MONTOPORC = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtDescPorc = New System.Windows.Forms.TextBox
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.cboIntervalo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboSubCategoria = New System.Windows.Forms.ComboBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.Rpt1 = New AxCrystal.AxCrystalReport
        Me.GrDatos.SuspendLayout()
        CType(Me.DgDescuentoxVolumenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrDatos
        '
        Me.GrDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrDatos.Controls.Add(Me.Label1)
        Me.GrDatos.Controls.Add(Me.cboCategoria)
        Me.GrDatos.Controls.Add(Me.DgDescuentoxVolumenes)
        Me.GrDatos.Controls.Add(Me.GroupBox1)
        Me.GrDatos.Controls.Add(Me.Label2)
        Me.GrDatos.Controls.Add(Me.cboSubCategoria)
        Me.GrDatos.Location = New System.Drawing.Point(4, 4)
        Me.GrDatos.Name = "GrDatos"
        Me.GrDatos.Size = New System.Drawing.Size(482, 310)
        Me.GrDatos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Categoría : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.Location = New System.Drawing.Point(8, 22)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(230, 21)
        Me.cboCategoria.TabIndex = 9
        '
        'DgDescuentoxVolumenes
        '
        Me.DgDescuentoxVolumenes.DataMember = ""
        Me.DgDescuentoxVolumenes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgDescuentoxVolumenes.Location = New System.Drawing.Point(8, 50)
        Me.DgDescuentoxVolumenes.Name = "DgDescuentoxVolumenes"
        Me.DgDescuentoxVolumenes.ReadOnly = True
        Me.DgDescuentoxVolumenes.Size = New System.Drawing.Size(464, 176)
        Me.DgDescuentoxVolumenes.TabIndex = 7
        Me.DgDescuentoxVolumenes.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DgDescuentoxVolumenes
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODINTERV, Me.SUBCATEGORIA, Me.DESCRIPCION, Me.MONTOPORC})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'CODINTERV
        '
        Me.CODINTERV.Format = ""
        Me.CODINTERV.FormatInfo = Nothing
        Me.CODINTERV.Width = 0
        '
        'SUBCATEGORIA
        '
        Me.SUBCATEGORIA.Format = ""
        Me.SUBCATEGORIA.FormatInfo = Nothing
        Me.SUBCATEGORIA.HeaderText = "SUBCATEGORIA"
        Me.SUBCATEGORIA.NullText = """"""
        Me.SUBCATEGORIA.Width = 150
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.Format = ""
        Me.DESCRIPCION.FormatInfo = Nothing
        Me.DESCRIPCION.HeaderText = "Intervalo."
        Me.DESCRIPCION.Width = 75
        '
        'MONTOPORC
        '
        Me.MONTOPORC.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.MONTOPORC.Format = "#####0.0"
        Me.MONTOPORC.FormatInfo = Nothing
        Me.MONTOPORC.HeaderText = "Descto (%)"
        Me.MONTOPORC.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescPorc)
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.cboIntervalo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 230)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 74)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtDescPorc
        '
        Me.txtDescPorc.Location = New System.Drawing.Point(108, 42)
        Me.txtDescPorc.Name = "txtDescPorc"
        Me.txtDescPorc.Size = New System.Drawing.Size(84, 20)
        Me.txtDescPorc.TabIndex = 6
        Me.txtDescPorc.Text = "0.00"
        Me.txtDescPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(376, 42)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(84, 26)
        Me.btnQuitar.TabIndex = 2
        Me.btnQuitar.Text = "&Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(376, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(84, 26)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "&Agregar"
        '
        'cboIntervalo
        '
        Me.cboIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIntervalo.ItemHeight = 13
        Me.cboIntervalo.Location = New System.Drawing.Point(108, 14)
        Me.cboIntervalo.Name = "cboIntervalo"
        Me.cboIntervalo.Size = New System.Drawing.Size(220, 21)
        Me.cboIntervalo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Intervalo Soles:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descuento-Vol (%): "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sub Categoría : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboSubCategoria
        '
        Me.cboSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubCategoria.Location = New System.Drawing.Point(240, 22)
        Me.cboSubCategoria.Name = "cboSubCategoria"
        Me.cboSubCategoria.Size = New System.Drawing.Size(234, 21)
        Me.cboSubCategoria.TabIndex = 5
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
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(488, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 200)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(10, 128)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(84, 30)
        Me.btnreporte.TabIndex = 29
        Me.btnreporte.TabStop = False
        Me.btnreporte.Text = "     &Reporte"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(10, 92)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(84, 30)
        Me.BTNCANCELAR.TabIndex = 28
        Me.BTNCANCELAR.TabStop = False
        Me.BTNCANCELAR.Text = "     &Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(10, 162)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(84, 30)
        Me.BTNCERRAR.TabIndex = 500
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "  &Salir"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(10, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(84, 30)
        Me.BTNNUEVO.TabIndex = 800
        Me.BTNNUEVO.TabStop = False
        Me.BTNNUEVO.Text = "  &Nuevo"
        Me.BTNNUEVO.Visible = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(10, 54)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(84, 30)
        Me.BTNGUARDAR.TabIndex = 801
        Me.BTNGUARDAR.TabStop = False
        Me.BTNGUARDAR.Text = "    &Guardar"
        '
        'Rpt1
        '
        Me.Rpt1.Enabled = True
        Me.Rpt1.Location = New System.Drawing.Point(514, 274)
        Me.Rpt1.Name = "Rpt1"
        Me.Rpt1.OcxState = CType(resources.GetObject("Rpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Rpt1.Size = New System.Drawing.Size(28, 28)
        Me.Rpt1.TabIndex = 8
        '
        'FrmDescuentoXVol_Familia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 316)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrDatos)
        Me.Controls.Add(Me.Rpt1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDescuentoXVol_Familia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dscto. de Volumen por Sub-Categoría"
        Me.GrDatos.ResumeLayout(False)
        Me.GrDatos.PerformLayout()
        CType(Me.DgDescuentoxVolumenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Rpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ACT_EVENT As Integer
    Private TABLE_INTERV As New DataTable
    Private NUEVO As Integer
    'Private Obj As New ClsInterface

#Region "Funciones "
    Sub CargarDatos()

        CAyuda.CargarDataCombo(cboCategoria, "NSP_Select_Listado_Linea   '" & codempresa & "'", "Código", "Descripción")
        CAyuda.CargarDataCombo(cboIntervalo, "NSP_LISTAR_INTERVALO   '" + codempresa & "'", "CODIGO", "DESCRIPCION")
        CAyuda.CargarDataCombo(cboSubCategoria, "NSP_Select_Listado_SubLinea '" & codempresa & "'", "Código", "Descripción")

    End Sub
    'Sub MOSTRAR()
    '    DgDescuentoxVolumenes.DataSource = TABLE_INTERV
    '    DataGridTableStyle1.MappingName = TABLE_INTERV.TableName

    '    DataGridTableStyle1.GridColumnStyles(0).MappingName = "CODINTERV"
    '    DataGridTableStyle1.GridColumnStyles(1).MappingName = "DESSUBLINEA"
    '    DataGridTableStyle1.GridColumnStyles(2).MappingName = "DESCRIPCION"
    '    DataGridTableStyle1.GridColumnStyles(3).MappingName = "MONTOPORC"
    '    'DataGridTableStyle1.GridColumnStyles(0).MappingName = "CODEMPRESA"
    '    'DataGridTableStyle1.GridColumnStyles(1).MappingName = "CODLINEA"
    '    'DataGridTableStyle1.GridColumnStyles(3).MappingName = "CODINTERV"
    '    'DataGridTableStyle1.GridColumnStyles(4).MappingName = "DESCRIPCION"
    '    'DataGridTableStyle1.GridColumnStyles(5).MappingName = "MONTOPORC"
    '    DgDescuentoxVolumenes.TableStyles.Add(DataGridTableStyle1)
    'End Sub

    Sub MOSTRAR()

        DgDescuentoxVolumenes.DataSource = TABLE_INTERV
        '  DataGridTableStyle1.MappingName = TABLE_INTERV.TableName

        Dim tablestyle1 As New DataGridTableStyle
        With tablestyle1
            .MappingName = TABLE_INTERV.TableName
        End With

        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CODINTERV"
            .HeaderText = "CODINTERV"
            .Width = 0
        End With

        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODSUBLINEA"
            .HeaderText = "CODSUBLINEA"
            .Width = 0
        End With

        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "DESSUBLINEA"
            .HeaderText = "DESSUBLINEA"
            .Width = 150
        End With

        Dim column4 As New DataGridTextBoxColumn
        With column4
            .MappingName = "DESCRIPCION"
            .HeaderText = "DESCRIPCION"
            .Width = 75
        End With

        Dim column5 As New DataGridTextBoxColumn
        With column5
            .MappingName = "MONTOPORC"
            .HeaderText = "MONTOPORC"
            .Width = 75
        End With

        DgDescuentoxVolumenes.TableStyles.Clear()

        tablestyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3, column4, column5})

        DgDescuentoxVolumenes.TableStyles.Add(tablestyle1)

    End Sub



    Sub Limpiar()
        txtDescPorc.Text = "0.00"
        DgDescuentoxVolumenes.DataSource = Nothing
    End Sub

    Sub BLOQUEO_INTERVALO(ByVal estado As Boolean)
        Dim o As Object
        For Each o In Me.GrDatos.Controls
            o.enabled = estado
        Next
    End Sub

    Sub BOTONES(ByVal estado As Boolean)
        BTNNUEVO.Enabled = estado
        BTNGUARDAR.Enabled = Not estado
    End Sub

#End Region

    Private Sub FrmDescuentoXVol_Familia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BLOQUEO_INTERVALO(False)
        BOTONES(True)
        CargarDatos()
        ACT_EVENT = 1
        Limpiar()
        BTNNUEVO_Click(sender, e)
        cboCategoria.Focus()
    End Sub



    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click

        Try
            Rpt1.ReportFileName = rutareporte & "Rpt_Descuento_Vol_Familia.rpt"
            Rpt1.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            Rpt1.set_StoredProcParam(0, codempresa)
            Rpt1.Destination = Crystal.DestinationConstants.crptToWindow
            Rpt1.WindowState = Crystal.WindowStateConstants.crptMaximized
            Rpt1.Action = 1
            Rpt1.Reset()
        Catch ex As Exception
            MsgBox("No se encuentra el archivo..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End Try
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub cboIntervalo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIntervalo.SelectedIndexChanged

    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If TABLE_INTERV.Rows.Count = 0 Then
            Dim FILA As DataRow = TABLE_INTERV.NewRow
            'FILA("CODEMPRESA") = codempresa
            'FILA("CODLINEA") = cboSubCategoria.SelectedValue.ToString
            FILA("CODSUBLINEA") = cboSubCategoria.SelectedValue.ToString
            FILA("DESSUBLINEA") = cboSubCategoria.Text.Trim
            FILA("CODINTERV") = cboIntervalo.SelectedValue.ToString
            FILA("DESCRIPCION") = cboIntervalo.Text.Trim
            FILA("MONTOPORC") = txtDescPorc.Text.Trim
            TABLE_INTERV.Rows.Add(FILA)
            TABLE_INTERV.AcceptChanges()
            Limpiar()
            MOSTRAR()
            Exit Sub
        End If


        For ContI As Integer = 0 To TABLE_INTERV.Rows.Count - 1
            If TABLE_INTERV.Rows(ContI)("CODINTERV").ToString.Trim = cboIntervalo.SelectedValue.ToString.Trim And TABLE_INTERV.Rows(ContI)("CODSUBLINEA").ToString.Trim = cboSubCategoria.SelectedValue.ToString.Trim Then
                Dim Rpta As String
                Rpta = MsgBox("¿ Desea reemplazar el los datos de este intervalo ?", MsgBoxStyle.YesNo).ToString
                If Rpta.Equals("Yes") Then
                    TABLE_INTERV.Rows(ContI)("MONTOPORC") = txtDescPorc.Text.Trim
                    TABLE_INTERV.AcceptChanges()
                    Exit For
                Else
                    cboIntervalo.Focus()
                    Exit For
                End If
            End If
            If ContI = TABLE_INTERV.Rows.Count - 1 Then
                Dim FILA As DataRow = TABLE_INTERV.NewRow
                'FILA("CODEMPRESA") = codempresa
                'FILA("CODLINEA") = cboSubCategoria.SelectedValue.ToString
                FILA("CODSUBLINEA") = cboSubCategoria.SelectedValue.ToString
                FILA("DESSUBLINEA") = cboSubCategoria.Text.Trim
                FILA("CODINTERV") = cboIntervalo.SelectedValue.ToString
                FILA("DESCRIPCION") = cboIntervalo.Text.Trim
                FILA("MONTOPORC") = txtDescPorc.Text.Trim
                TABLE_INTERV.Rows.Add(FILA)
                TABLE_INTERV.AcceptChanges()
                Exit For
            End If
        Next
        Limpiar()
        MOSTRAR()

        'cboLinea.Focus()
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            TABLE_INTERV.Rows.RemoveAt(DgDescuentoxVolumenes.CurrentRowIndex)
            TABLE_INTERV.AcceptChanges()
            MOSTRAR()
        Catch ex As Exception
            MsgBox("Debe escoger una Fila para eliminar el registro", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C.")
        End Try
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        BLOQUEO_INTERVALO(True)
        Limpiar()
        BOTONES(False)
        cboIntervalo.Focus()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        BLOQUEO_INTERVALO(False)
        Limpiar()
        'BOTONES(True)
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click


        CAyuda.Ejecutar("NSP_DELETE_DESCUENTO_VOL_FAMILIA", codempresa, cboCategoria.SelectedValue.ToString.Trim)
        For i As Integer = 0 To TABLE_INTERV.Rows.Count - 1
            TmpInsertDatos("NSP_INSERT_DESCUENTO_VOL_FAMILIA  '" & codempresa & "','" & cboCategoria.SelectedValue.ToString.Trim & "','" & TABLE_INTERV.Rows(i)("CODSUBLINEA").ToString & "', '" & TABLE_INTERV.Rows(i)("CODINTERV").ToString & "','" & TABLE_INTERV.Rows(i)("MONTOPORC").ToString & "' ")
        Next
        ' BLOQUEO_INTERVALO(False)
        Limpiar()

        MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

        'BOTONES(True)
    End Sub

    Private Sub cboLinea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubCategoria.SelectedIndexChanged
        'If ACT_EVENT = 1 Then
        '    TABLE_INTERV = CAyuda.ListarDatos("NSP_LISTAR_DESCUENTO_VOL_FAMILIAxINTERV", codempresa, cboCategoria.SelectedValue.ToString.Trim, cboSubCategoria.SelectedValue.ToString.Trim).Tables(0)
        '    MOSTRAR()
        'End If
    End Sub

    Private Sub cboLinea_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSubCategoria.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescPorc.Focus()
        End If
    End Sub

    Private Sub txtDescPorc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescPorc.TextChanged

    End Sub

    Private Sub txtDescPorc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescPorc.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAgregar_Click(sender, e)
        End If
    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategoria.SelectedIndexChanged

        If ACT_EVENT = 1 Then
            Try
                CAyuda.CargarDataCombo(cboSubCategoria, "NSP_Sele_SubLineaxlinea '" & cboCategoria.SelectedValue & "','" & codempresa & "'", "Codigo", "Descripcion")
                TABLE_INTERV = CAyuda.ListarDatos("NSP_LISTAR_DESCUENTO_VOL_FAMILIAxINTERV", codempresa, IIf(IsNothing(cboCategoria.SelectedValue), "", cboCategoria.SelectedValue), IIf(IsNothing(cboSubCategoria.SelectedValue), "", cboSubCategoria.SelectedValue)).Tables(0)
                MOSTRAR()
                ' MOSTRAR2()
            Catch ex As Exception
                MsgBox("No hay un valor correcto de sub-categoria", MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub cboCategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCategoria.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.cboSubCategoria.Focus()
        End If


    End Sub

    Private Sub cboIntervalo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboIntervalo.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.txtDescPorc.Focus()
        End If

    End Sub
End Class
