Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmSubLinea
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents dgGridLineaas As System.Windows.Forms.DataGrid
    Friend WithEvents TablaEstiloLinea As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CODLINEA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DESLINEA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboCat As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSubLinea))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CboCat = New System.Windows.Forms.ComboBox
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnAñadir = New System.Windows.Forms.Button
        Me.dgGridLineaas = New System.Windows.Forms.DataGrid
        Me.TablaEstiloLinea = New System.Windows.Forms.DataGridTableStyle
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtCuenta = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.CODLINEA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DESLINEA = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgGridLineaas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboCat)
        Me.GroupBox2.Controls.Add(Me.btnQuitar)
        Me.GroupBox2.Controls.Add(Me.btnAñadir)
        Me.GroupBox2.Controls.Add(Me.dgGridLineaas)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.txtcod)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.crRpt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtCuenta)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(2, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 214)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'CboCat
        '
        Me.CboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCat.Location = New System.Drawing.Point(90, 124)
        Me.CboCat.Name = "CboCat"
        Me.CboCat.Size = New System.Drawing.Size(268, 21)
        Me.CboCat.TabIndex = 27
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Location = New System.Drawing.Point(196, 236)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(62, 22)
        Me.btnQuitar.TabIndex = 25
        Me.btnQuitar.Text = "Quitar"
        '
        'btnAñadir
        '
        Me.btnAñadir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadir.Location = New System.Drawing.Point(260, 236)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(62, 22)
        Me.btnAñadir.TabIndex = 24
        Me.btnAñadir.Text = "Añadir"
        '
        'dgGridLineaas
        '
        Me.dgGridLineaas.CaptionVisible = False
        Me.dgGridLineaas.DataMember = ""
        Me.dgGridLineaas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGridLineaas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgGridLineaas.Location = New System.Drawing.Point(24, 228)
        Me.dgGridLineaas.Name = "dgGridLineaas"
        Me.dgGridLineaas.ReadOnly = True
        Me.dgGridLineaas.RowHeadersVisible = False
        Me.dgGridLineaas.Size = New System.Drawing.Size(314, 46)
        Me.dgGridLineaas.TabIndex = 23
        Me.dgGridLineaas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.TablaEstiloLinea})
        '
        'TablaEstiloLinea
        '
        Me.TablaEstiloLinea.DataGrid = Me.dgGridLineaas
        Me.TablaEstiloLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.TablaEstiloLinea.MappingName = ""
        Me.TablaEstiloLinea.ReadOnly = True
        Me.TablaEstiloLinea.RowHeadersVisible = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtdescripcion.Location = New System.Drawing.Point(90, 96)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(268, 21)
        Me.txtdescripcion.TabIndex = 3
        Me.txtdescripcion.Text = ""
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.Color.Black
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(198, 72)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcod
        '
        Me.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.ForeColor = System.Drawing.Color.Black
        Me.txtcod.Location = New System.Drawing.Point(90, 72)
        Me.txtcod.MaxLength = 6
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(104, 21)
        Me.txtcod.TabIndex = 1
        Me.txtcod.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(42, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'crRpt
        '
        Me.crRpt.ContainingControl = Me
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(16, 16)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "SubCategoria :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Categoria :"
        '
        'TxtCuenta
        '
        Me.TxtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCuenta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCuenta.ForeColor = System.Drawing.Color.Black
        Me.TxtCuenta.Location = New System.Drawing.Point(90, 154)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(148, 21)
        Me.TxtCuenta.TabIndex = 3
        Me.TxtCuenta.Text = ""
        Me.TxtCuenta.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Cuenta contable : "
        Me.Label4.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(380, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(86, 210)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(9, 150)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(72, 23)
        Me.btnreporte.TabIndex = 10
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(9, 123)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNCANCELAR.TabIndex = 9
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(9, 177)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNCERRAR.TabIndex = 11
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(9, 69)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNMODIFICAR.TabIndex = 7
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(9, 96)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNELIMINAR.TabIndex = 8
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(9, 15)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(72, 23)
        Me.BTNNUEVO.TabIndex = 5
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(9, 42)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(72, 23)
        Me.BTNGUARDAR.TabIndex = 6
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CODLINEA
        '
        Me.CODLINEA.Format = ""
        Me.CODLINEA.FormatInfo = Nothing
        Me.CODLINEA.MappingName = ""
        Me.CODLINEA.Width = 0
        '
        'DESLINEA
        '
        Me.DESLINEA.Format = ""
        Me.DESLINEA.FormatInfo = Nothing
        Me.DESLINEA.HeaderText = "Linea"
        Me.DESLINEA.MappingName = ""
        Me.DESLINEA.ReadOnly = True
        Me.DESLINEA.Width = 300
        '
        'FrmSubLinea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(472, 222)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmSubLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento SubCategoria"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgGridLineaas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private ValidaDatos As Boolean
    Private valor As Integer
    Private Resp As Integer
    Private agregar As Boolean
    Private tblImp As New DataTable
    Private TablaTempLineas As New DataTable


    Private Sub FrmSubLinea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TablaTempLineas.Columns.Add("CODIGO")
        TablaTempLineas.Columns.Add("DESCRIPCION")
         Call BOTONES(True, False, False, False, True)
        'Grplistado.Visible = False
        valor = 0
        agregar = True
        CAyuda.CargarDataCombo(CboCat, "NSP_Select_Listado_Linea  '" & codempresa & "'", "Código", "Descripción")
        bloqueatextos(Me)
        tblImp = CAyuda.ListarDatos("NSP_Select_Listado_SubLinea", codempresa.ToString()).Tables(0)
        'grdsubLinea.DataSource = tblImp
        'FormatGrid()
        BTNNUEVO.Focus()
        Me.CboCat.Enabled = False

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                        ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    ' If grdsubLinea.Focus = True Then
                    ' EnviarDatosImpuesto()
                    '  End If
                Case Keys.Escape
                    'Grplistado.Visible = False
            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        desbloqueatextos(Me)
        txtcod.Enabled = True
        txtdescripcion.Enabled = True
        LimpiarFormularios(Me)
        txtcod.Focus()
        agregar = True
        Me.CboCat.Enabled = True
        Call BOTONES(False, True, False, False, False)

    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)

        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR

    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Me.CboCat.Enabled = False
        Call BOTONES(True, False, False, False, True)
        LimpiarFormularios(Me)
        bloqueatextos(Me)
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        Call BOTONES(True, False, True, True, True)
        'Grplistado.Visible = True
        'txtdato.Focus()
        Dim frmV As New FrmBusquedaSubLinea
        frmV.Frm = Me
        frmV.ShowDialog()
    End Sub
    Sub valida_datos()
        If txtcod.Text = "" Then
            ValidaDatos = False
        End If
        If txtdescripcion.Text = "" Then
            ValidaDatos = False
        End If
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Me.CboCat.Enabled = False
        If txtcod.Text.Trim = "" Or txtdescripcion.Text.Trim = "" Then
            MessageBox.Show("Falta Ingresar Valores", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'ValidaDatos = True
            Exit Sub
        End If

        ''''''''''''''''''''''''''''''''''''''''
        If Me.txtcod.ReadOnly And txtcod.Text.Trim <> "" Then

            valor = CAyuda.ListarDatos("NSP_Select_VerficaDescripSubLineaUp", txtcod.Text, CboCat.SelectedValue, txtdescripcion.Text, codempresa.ToString()).Tables(0).Rows.Count
            If valor <> 0 Then
                MsgBox("LA DESCRIPCION YA EXISTE DE ESTA SUB CATEGORIA...", MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC")
                Exit Sub
            End If

            If CAyuda.Ejecutar("NSP_UPDATE_SUBLINEA", codempresa.Trim, txtcod.Text.Trim, txtdescripcion.Text.Trim, CboCat.SelectedValue) = 1 Then
                MsgBox("SE MODIFICO CORRECTAMENTE EL REGISTRO...", MsgBoxStyle.Exclamation, "NARSISTEMAS SAC")
            End If
        Else

            valor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoSubLinea", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
            If valor <> 0 Then
                MsgBox("EL CODIGO YA EXISTE ...", MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC")
                Exit Sub
            End If

            valor = CAyuda.ListarDatos("NSP_Select_VerficaDescripSubLinea", CboCat.SelectedValue, txtdescripcion.Text, codempresa.ToString()).Tables(0).Rows.Count
            If valor <> 0 Then
                MsgBox("LA DESCRIPCION YA EXISTE DE ESTA SUB CATEGORIA...", MsgBoxStyle.Exclamation, "NAR SISTEMAS SAC")
                Exit Sub
            End If

            If CAyuda.Ejecutar("NSP_ins_SUBLINEA", txtcod.Text, txtdescripcion.Text, codempresa, CboCat.SelectedValue) = 1 Then
                MsgBox("SE GRABO CORRECTAMENTE EL REGISTRO...", MsgBoxStyle.Exclamation, "NARSISTEMAS SAC")
            End If
        End If
        ''''''''''''''''''''''''''''''''''''''''
        Me.TablaTempLineas.Rows.Clear()


        Call BOTONES(True, False, False, False, True)

        LimpiarFormularios(Me)
        bloqueatextos(Me)

    End Sub


    Private Sub txtcod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            valor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoSubLinea", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
            If valor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            txtdescripcion.Focus()
        End If
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        desbloqueatextos(Me)
        agregar = False
        Call BOTONES(False, True, False, False, True)
        txtdescripcion.ReadOnly = False
        txtcod.ReadOnly = True
        Me.CboCat.Enabled = True
        Me.txtdescripcion.Focus()
        Me.txtdescripcion.SelectAll()
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            If Me.txtcod.Text.Trim.Length = 0 Then
                MsgBox("Falta seleccionar un item.", MsgBoxStyle.Critical, "Aviso")
                Exit Sub
            End If
            Resp = CAyuda.Ejecutar("NSP_del_SUBLINEA", txtcod.Text, 1, 0, codempresa.Trim)
            If Resp = 1 Then
                MessageBox.Show("Registro Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','DELETE','SUBLINEA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
            End If
            LimpiarFormularios(Me)
            bloqueatextos(Me)
            BOTONES(True, False, False, False, True)
        End If



    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            CboCat.Focus()
        End If
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub btnreporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        crRpt.ReportFileName = rutareporte & "RPTSUBLINEA.RPT"
        crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
        crRpt.set_StoredProcParam(0, codempresa)
        crRpt.set_StoredProcParam(1, CodUsuario)
        crRpt.Destination = Crystal.DestinationConstants.crptToWindow
        crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
        crRpt.Action = 1
        crRpt.Reset()
    End Sub

    Private Sub btnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadir.Click
        For Cont1 As Integer = 0 To TablaTempLineas.Rows.Count - 1
            If TablaTempLineas.Rows(Cont1)(0).ToString.Trim = Me.CboCat.SelectedValue.ToString.Trim Then
                Exit Sub
            End If
        Next
        Dim Fila As DataRow = TablaTempLineas.NewRow
        Fila(0) = Me.CboCat.SelectedValue.ToString.Trim
        Fila(1) = Me.CboCat.Text.ToString.Trim
        TablaTempLineas.Rows.Add(Fila)
        TablaTempLineas.AcceptChanges()
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If Me.dgGridLineaas.CurrentRowIndex >= 0 Then
            For Cont2 As Integer = 0 To TablaTempLineas.Rows.Count - 1
                If dgGridLineaas(Me.dgGridLineaas.CurrentRowIndex, 0).ToString.Trim = TablaTempLineas.Rows(Cont2)(0).ToString.Trim Then
                    TablaTempLineas.Rows.RemoveAt(Cont2)
                    TablaTempLineas.AcceptChanges()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub CboCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCat.SelectedIndexChanged

    End Sub

    Private Sub TxtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCuenta.TextChanged

    End Sub

    Private Sub CboCat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboCat.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If

    End Sub
End Class


