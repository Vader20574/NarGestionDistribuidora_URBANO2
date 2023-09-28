Public Class FrmFuerzaVenta
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents TablaEstiloCateg As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgCateg As System.Windows.Forms.DataGrid
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents lbCategoria As System.Windows.Forms.Label
    Friend WithEvents btnBuscarCateg As System.Windows.Forms.Button
    Friend WithEvents cbSubCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CODSUBLINEA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESSUBLINEA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CODLINEA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESLINEA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ckTodosSubCateg As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFuerzaVenta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ckTodosSubCateg = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbSubCategoria = New System.Windows.Forms.ComboBox
        Me.btnBuscarCateg = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.lbCategoria = New System.Windows.Forms.Label
        Me.txtCategoria = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgCateg = New System.Windows.Forms.DataGrid
        Me.TablaEstiloCateg = New System.Windows.Forms.DataGridTableStyle
        Me.CODLINEA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESLINEA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CODSUBLINEA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESSUBLINEA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCateg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckTodosSubCateg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbSubCategoria)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCateg)
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.lbCategoria)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgCateg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 318)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'ckTodosSubCateg
        '
        Me.ckTodosSubCateg.Location = New System.Drawing.Point(357, 104)
        Me.ckTodosSubCateg.Name = "ckTodosSubCateg"
        Me.ckTodosSubCateg.Size = New System.Drawing.Size(63, 17)
        Me.ckTodosSubCateg.TabIndex = 32
        Me.ckTodosSubCateg.Text = "Todos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Sub Categoría :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSubCategoria
        '
        Me.cbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubCategoria.Location = New System.Drawing.Point(103, 102)
        Me.cbSubCategoria.Name = "cbSubCategoria"
        Me.cbSubCategoria.Size = New System.Drawing.Size(249, 21)
        Me.cbSubCategoria.TabIndex = 30
        '
        'btnBuscarCateg
        '
        Me.btnBuscarCateg.ImageIndex = 5
        Me.btnBuscarCateg.ImageList = Me.ImageList1
        Me.btnBuscarCateg.Location = New System.Drawing.Point(420, 79)
        Me.btnBuscarCateg.Name = "btnBuscarCateg"
        Me.btnBuscarCateg.Size = New System.Drawing.Size(32, 23)
        Me.btnBuscarCateg.TabIndex = 29
        Me.btnBuscarCateg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(233, 128)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(121, 23)
        Me.btnQuitar.TabIndex = 28
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(108, 128)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(122, 23)
        Me.btnAgregar.TabIndex = 27
        Me.btnAgregar.Text = "Agregar"
        '
        'lbCategoria
        '
        Me.lbCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCategoria.Location = New System.Drawing.Point(138, 80)
        Me.lbCategoria.Name = "lbCategoria"
        Me.lbCategoria.Size = New System.Drawing.Size(281, 21)
        Me.lbCategoria.TabIndex = 26
        Me.lbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCategoria
        '
        Me.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCategoria.Location = New System.Drawing.Point(78, 80)
        Me.txtCategoria.MaxLength = 4
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(58, 20)
        Me.txtCategoria.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Categoria :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgCateg
        '
        Me.dgCateg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgCateg.CaptionVisible = False
        Me.dgCateg.DataMember = ""
        Me.dgCateg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCateg.Location = New System.Drawing.Point(12, 158)
        Me.dgCateg.Name = "dgCateg"
        Me.dgCateg.ReadOnly = True
        Me.dgCateg.Size = New System.Drawing.Size(433, 155)
        Me.dgCateg.TabIndex = 20
        Me.dgCateg.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloCateg})
        '
        'TablaEstiloCateg
        '
        Me.TablaEstiloCateg.AlternatingBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TablaEstiloCateg.DataGrid = Me.dgCateg
        Me.TablaEstiloCateg.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CODLINEA, Me.DESLINEA, Me.CODSUBLINEA, Me.DESSUBLINEA})
        Me.TablaEstiloCateg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloCateg.ReadOnly = True
        '
        'CODLINEA
        '
        Me.CODLINEA.Format = ""
        Me.CODLINEA.FormatInfo = Nothing
        Me.CODLINEA.Width = 0
        '
        'DESLINEA
        '
        Me.DESLINEA.Format = ""
        Me.DESLINEA.FormatInfo = Nothing
        Me.DESLINEA.HeaderText = "Categoría"
        Me.DESLINEA.Width = 150
        '
        'CODSUBLINEA
        '
        Me.CODSUBLINEA.Format = ""
        Me.CODSUBLINEA.FormatInfo = Nothing
        Me.CODSUBLINEA.Width = 0
        '
        'DESSUBLINEA
        '
        Me.DESSUBLINEA.Format = ""
        Me.DESSUBLINEA.FormatInfo = Nothing
        Me.DESSUBLINEA.HeaderText = "Sub Categoría"
        Me.DESSUBLINEA.Width = 200
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(431, 3)
        Me.Label2.TabIndex = 19
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(97, 43)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(293, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Descripción :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(97, 18)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(200, 18)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 18
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 98)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(304, 20)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(78, 34)
        Me.btnreporte.TabIndex = 805
        Me.btnreporte.TabStop = False
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(182, 58)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(78, 34)
        Me.BTNCANCELAR.TabIndex = 804
        Me.BTNCANCELAR.TabStop = False
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(262, 58)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(78, 34)
        Me.BTNCERRAR.TabIndex = 806
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(224, 20)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(78, 34)
        Me.BTNMODIFICAR.TabIndex = 809
        Me.BTNMODIFICAR.TabStop = False
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(102, 58)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(78, 34)
        Me.BTNELIMINAR.TabIndex = 803
        Me.BTNELIMINAR.TabStop = False
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(64, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(78, 34)
        Me.BTNNUEVO.TabIndex = 807
        Me.BTNNUEVO.TabStop = False
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(144, 20)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(78, 34)
        Me.BTNGUARDAR.TabIndex = 808
        Me.BTNGUARDAR.TabStop = False
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmFuerzaVenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(466, 418)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmFuerzaVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FUERZA VENTA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgCateg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Fields"
    Private INTFLAG_FV As Integer
    'Private Obj As New ClsInterface
    Public TableCateg As New DataTable
#End Region

    Private Sub CargarSubCate()
        CAyuda.CargarDataCombo(cbSubCategoria, "SP_SELECT_SUBLINEAxLINEA '" & codempresa & "','" & txtCategoria.Text & "'", "CODSUBLINEA", "DESSUBLINEA")
    End Sub

    Private Sub FrmFuerzaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        'Call cargadatos()
        BTNCANCELAR.Enabled = False
        TableCateg = CAyuda.ListarDatos("NSP_LISTAR_CATEG_X_FZAVTA", codempresa, "XXXXXXX").Tables(0)
        TablaEstiloCateg.MappingName = TableCateg.TableName
        TablaEstiloCateg.GridColumnStyles(0).MappingName = "CODLINEA"
        TablaEstiloCateg.GridColumnStyles(1).MappingName = "DESLINEA"
        TablaEstiloCateg.GridColumnStyles(2).MappingName = "CODSUBLINEA"
        TablaEstiloCateg.GridColumnStyles(3).MappingName = "DESSUBLINEA"
        Me.dgCateg.TableStyles.Add(TablaEstiloCateg)
        Me.dgCateg.DataSource = TableCateg
        'CargadataCombos(cbSubCategoria, "NSP_Select_Listado_SubLinea '" & codempresa & "'", "Código", "Descripción")
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)

        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR

    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        'tcuotat.Text = "0"
        'tcuotas.Text = "0"
        'tcuotad.Text = "0"
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)
        'INTFLAGVEND = 0
        INTFLAG_FV = 0
        txtCodigo.Focus()
        BTNCANCELAR.Enabled = True

        TableCateg.Rows.Clear()
        Me.dgCateg.DataSource = TableCateg
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call BOTONES(True, False, True, True, True)
        Call Bloqueatextbox(Me)

        Dim FRMX As New FrmGridFuerzaVenta
        FRMX.vie = Me
        'FRMX.bol = True
        FRMX.ShowDialog()

        txtCodigo.ReadOnly = True
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim sql As String
        Call formatotextbox(Me)

        If Not VerificarDatos() Then
            Exit Sub
        End If

        If INTFLAG_FV = 0 Then
            sql = "NSP_INSERT_FUERZAVENTA '" & codempresa & "','" & txtCodigo.Text & "','" & txtDescripcion.Text & "'"
            If TmpInsertDatos(sql) = True Then
                CAyuda.Ejecutar("NSP_DELETE_FUERZAVENTA_CATEG", codempresa, txtCodigo.Text.Trim)
                For ContJ As Integer = 0 To TableCateg.Rows.Count - 1
                    CAyuda.Ejecutar("NSP_INSERT_FUERZAVENTA_CATEG", codempresa, txtCodigo.Text.Trim, TableCateg.Rows(ContJ)("CODLINEA").ToString.Trim, TableCateg.Rows(ContJ)("CODSUBLINEA").ToString.Trim)
                Next
                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)
                Bloqueatextbox(Me)
                TableCateg.Rows.Clear()

                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")


            End If
        End If
        If INTFLAG_FV = 1 Then
            sql = "NSP_UPDATE_FUERZAVENTA '" & codempresa & "','" & txtCodigo.Text & "','" & txtDescripcion.Text & "'"
            If TmpInsertDatos(sql) = True Then
                CAyuda.Ejecutar("NSP_DELETE_FUERZAVENTA_CATEG", codempresa, txtCodigo.Text.Trim)
                For ContJ As Integer = 0 To TableCateg.Rows.Count - 1
                    CAyuda.Ejecutar("NSP_INSERT_FUERZAVENTA_CATEG", codempresa, txtCodigo.Text.Trim, TableCateg.Rows(ContJ)("CODLINEA").ToString.Trim, TableCateg.Rows(ContJ)("CODSUBLINEA").ToString.Trim)
                Next
                Call BOTONES(True, False, True, True, True)
                Limpiatextbox(Me)
                Bloqueatextbox(Me)
                TableCateg.Rows.Clear()

                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")


            End If
        End If

        BTNCANCELAR.Enabled = False
    End Sub

    Public Function VerificarDatos() As Boolean
        Dim Obs1 As String = String.Empty, obs2 As String = String.Empty
        If INTFLAG_FV = 0 Then
            If Me.txtCodigo.Text.Trim.Length = 0 Then
                Obs1 = vbCrLf + "-   Ingrese el código."
            Else
                Dim TablaConsulta As New DataTable
                TablaConsulta = CAyuda.ListarDatos("NSP_LISTAR_FUERZAVENTA", codempresa, Me.txtCodigo.Text.Trim).Tables(0)
                If TablaConsulta.Rows.Count > 0 Then
                    Obs1 = vbCrLf + "-   Este código ya ha sido ingresado."
                End If
            End If
        End If
        If Me.txtDescripcion.Text.Trim.Length = 0 Then
            obs2 = vbCrLf + "-   Ingrese la Descripción."
        End If
        If Obs1 <> String.Empty Or obs2 <> String.Empty Then
            MsgBox("Para grabar corrija las siguientes observaciones. :" + vbCrLf + Obs1 + obs2)
            VerificarDatos = False
        Else
            VerificarDatos = True
        End If
    End Function

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        txtCodigo.ReadOnly = True
        Call BOTONES(False, True, False, False, False)
        INTFLAG_FV = 1
        txtDescripcion.Focus()
        txtDescripcion.SelectAll()
        BTNCANCELAR.Enabled = True
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub

        If INTFLAG_FV = 0 Then
            Call Limpiatextbox(Me)
            Call BOTONES(True, False, False, False, True)
        Else
            Call BOTONES(True, False, True, True, True)
        End If
        Call Bloqueatextbox(Me)
        BTNCANCELAR.Enabled = False
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el Registro ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_FUERZAVENTA", codempresa, txtCodigo.Text.Trim)
            BOTONES(True, False, True, False, True)
            Call Bloqueatextbox(Me)
            Call Limpiatextbox(Me)
            TableCateg.Rows.Clear()

        End If
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If Me.lbCategoria.Text.Trim.Length = 0 Then
            MsgBox("Falta la Categoria ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")

            Exit Sub
        End If
        If Me.cbSubCategoria.Text.Trim.Length = 0 Then
            MsgBox("Falta la SubCategoria ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")

            Exit Sub
        End If
        If Me.TableCateg.Rows.Count = 0 Then
            If ckTodosSubCateg.Checked Then
                Conecta("SP_SELECT_SUBLINEAxLINEA   '" & codempresa & "','" & txtCategoria.Text & "'", "TABG")
                Dim TablaTempG As New DataTable
                TablaTempG = ds.Tables("TABG")
                If ds.Tables("TABG").Rows.Count > 0 Then
                    For ContG As Integer = 0 To TablaTempG.Rows.Count - 1
                        Dim FilaC As DataRow = TableCateg.NewRow
                        FilaC("CODLINEA") = Me.txtCategoria.Text.Trim
                        FilaC("DESLINEA") = Me.lbCategoria.Text.Trim
                        FilaC("CODSUBLINEA") = TablaTempG.Rows(ContG)("CODSUBLINEA").ToString.Trim
                        FilaC("DESSUBLINEA") = TablaTempG.Rows(ContG)("DESSUBLINEA").ToString.Trim
                        TableCateg.Rows.Add(FilaC)
                        TableCateg.AcceptChanges()
                    Next
                    Me.dgCateg.DataSource = TableCateg
                End If
            Else
                Dim FilaC As DataRow = TableCateg.NewRow
                FilaC("CODLINEA") = Me.txtCategoria.Text.Trim
                FilaC("DESLINEA") = Me.lbCategoria.Text.Trim
                FilaC("CODSUBLINEA") = Me.cbSubCategoria.SelectedValue.ToString.Trim
                FilaC("DESSUBLINEA") = Me.cbSubCategoria.Text.Trim
                TableCateg.Rows.Add(FilaC)
                TableCateg.AcceptChanges()
                Me.dgCateg.DataSource = TableCateg
            End If
            Exit Sub
        End If
        If ckTodosSubCateg.Checked Then
            For ContY As Integer = 0 To TableCateg.Rows.Count - 1
                If ContY > TableCateg.Rows.Count - 1 Then
                    Exit For
                End If
                If TableCateg.Rows(ContY)("CODLINEA").ToString.Trim = txtCategoria.Text.Trim Then
                    TableCateg.Rows.RemoveAt(ContY)
                    ContY = ContY - 1
                End If
            Next
            Conecta("SP_SELECT_SUBLINEAxLINEA   '" & codempresa & "','" & txtCategoria.Text & "'", "TABG")
            Dim TablaTempG As New DataTable
            TablaTempG = ds.Tables("TABG")
            If ds.Tables("TABG").Rows.Count > 0 Then
                For ContG As Integer = 0 To TablaTempG.Rows.Count - 1
                    Dim FilaC As DataRow = TableCateg.NewRow
                    FilaC("CODLINEA") = Me.txtCategoria.Text.Trim
                    FilaC("DESLINEA") = Me.lbCategoria.Text.Trim
                    FilaC("CODSUBLINEA") = TablaTempG.Rows(ContG)("CODSUBLINEA").ToString.Trim
                    FilaC("DESSUBLINEA") = TablaTempG.Rows(ContG)("DESSUBLINEA").ToString.Trim
                    TableCateg.Rows.Add(FilaC)
                    TableCateg.AcceptChanges()
                Next
                Me.dgCateg.DataSource = TableCateg
            End If
        Else
            For ContE As Integer = 0 To TableCateg.Rows.Count - 1
                If TableCateg.Rows(ContE)("CODLINEA").ToString.Trim = Me.txtCategoria.Text.Trim And TableCateg.Rows(ContE)("CODSUBLINEA").ToString.Trim = Me.cbSubCategoria.SelectedValue.ToString.Trim Then
                    Exit Sub
                End If
                If ContE = TableCateg.Rows.Count - 1 Then
                    Dim FilaC As DataRow = TableCateg.NewRow
                    FilaC("CODLINEA") = Me.txtCategoria.Text.Trim
                    FilaC("DESLINEA") = Me.lbCategoria.Text.Trim
                    FilaC("CODSUBLINEA") = Me.cbSubCategoria.SelectedValue.ToString.Trim
                    FilaC("DESSUBLINEA") = Me.cbSubCategoria.Text.Trim
                    TableCateg.Rows.Add(FilaC)
                    TableCateg.AcceptChanges()
                    Me.dgCateg.DataSource = TableCateg
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub btnBuscarCateg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCateg.Click
        Dim MEN As New FRM_GRIDLINEA
        MEN.vie3 = Me
        MEN.ShowDialog()
        CargarSubCate()

        cbSubCategoria.Focus()

    End Sub

    Private Sub txtCategoria_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategoria.TextChanged
        Conecta("SELECT DESLINEA FROM LINEA WHERE CODLINEA='" & txtCategoria.Text.Trim & "' AND CODEMPRESA ='" & codempresa & "'", "TabH")
        If ds.Tables("TabH").Rows.Count > 0 Then
            Me.lbCategoria.Text = ds.Tables("TabH").Rows(0)(0).ToString.Trim
            ' CargadataCombos(cbSubCategoria, "NSP_Sele_SubLineaxlinea '" & txtCategoria.Text.Trim & "','" & codempresa & "'", "Codigo", "Descripcion")

        End If
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim VarCod As String
        Try
            VarCod = Me.dgCateg(Me.dgCateg.CurrentRowIndex, 0)
            For contG As Integer = 0 To TableCateg.Rows.Count - 1
                If Me.TableCateg.Rows(contG)("CODLINEA").ToString.Trim = VarCod.Trim Then
                    TableCateg.Rows.RemoveAt(contG)
                    TableCateg.AcceptChanges()
                    Me.dgCateg.DataSource = TableCateg
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCategoria.KeyPress

        If Asc(e.KeyChar) = 13 Then
            btnBuscarCateg_Click(sender, e)
        End If

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtDescripcion.Focus()
        End If

    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtCategoria.Focus()
        End If

    End Sub

    Private Sub cbSubCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSubCategoria.SelectedIndexChanged

    End Sub

    Private Sub cbSubCategoria_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbSubCategoria.KeyPress

        If Asc(e.KeyChar) = 13 Then
            btnAgregar_Click(sender, e)
        End If


    End Sub

    Private Sub lbCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCategoria.Click

    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click

    End Sub
End Class
