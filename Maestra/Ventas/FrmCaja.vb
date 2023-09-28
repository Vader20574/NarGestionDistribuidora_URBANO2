Public Class FrmCaja
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodCaja As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents ckActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtSaldoBas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSaldoExt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarCuota As System.Windows.Forms.Button
    Friend WithEvents dgCuotaLinea As System.Windows.Forms.DataGrid
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCaja))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSaldoBas = New System.Windows.Forms.TextBox
        Me.txtSaldoExt = New System.Windows.Forms.TextBox
        Me.ckActivo = New System.Windows.Forms.CheckBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.txtResponsable = New System.Windows.Forms.TextBox
        Me.txtDesc2 = New System.Windows.Forms.TextBox
        Me.txtDesc1 = New System.Windows.Forms.TextBox
        Me.txtCodCaja = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAñadir = New System.Windows.Forms.Button
        Me.BtnQuitarCuota = New System.Windows.Forms.Button
        Me.dgCuotaLinea = New System.Windows.Forms.DataGrid
        Me.cboUsuario = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.crRpt)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.ckActivo)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtResponsable)
        Me.GroupBox1.Controls.Add(Me.txtDesc2)
        Me.GroupBox1.Controls.Add(Me.txtDesc1)
        Me.GroupBox1.Controls.Add(Me.txtCodCaja)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 278)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(386, 24)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 26
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtSaldoBas)
        Me.GroupBox3.Controls.Add(Me.txtSaldoExt)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Location = New System.Drawing.Point(50, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 32)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Saldos"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(204, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "U$$"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "S/."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSaldoBas
        '
        Me.txtSaldoBas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoBas.Location = New System.Drawing.Point(88, 8)
        Me.txtSaldoBas.Name = "txtSaldoBas"
        Me.txtSaldoBas.Size = New System.Drawing.Size(96, 20)
        Me.txtSaldoBas.TabIndex = 8
        Me.txtSaldoBas.Text = "0.00"
        Me.txtSaldoBas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSaldoExt
        '
        Me.txtSaldoExt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldoExt.Location = New System.Drawing.Point(236, 10)
        Me.txtSaldoExt.Name = "txtSaldoExt"
        Me.txtSaldoExt.Size = New System.Drawing.Size(96, 20)
        Me.txtSaldoExt.TabIndex = 9
        Me.txtSaldoExt.Text = "0.00"
        Me.txtSaldoExt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ckActivo
        '
        Me.ckActivo.Location = New System.Drawing.Point(116, 154)
        Me.ckActivo.Name = "ckActivo"
        Me.ckActivo.Size = New System.Drawing.Size(104, 18)
        Me.ckActivo.TabIndex = 24
        Me.ckActivo.Text = "Activo"
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(222, 20)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 23
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 94)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(304, 18)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(78, 34)
        Me.btnreporte.TabIndex = 805
        Me.btnreporte.TabStop = False
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(182, 56)
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
        Me.BTNCERRAR.Location = New System.Drawing.Point(262, 56)
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
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(224, 18)
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
        Me.BTNELIMINAR.Location = New System.Drawing.Point(102, 56)
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
        Me.BTNNUEVO.Location = New System.Drawing.Point(64, 18)
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
        Me.BTNGUARDAR.Location = New System.Drawing.Point(144, 18)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(78, 34)
        Me.BTNGUARDAR.TabIndex = 808
        Me.BTNGUARDAR.TabStop = False
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtResponsable
        '
        Me.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable.Location = New System.Drawing.Point(116, 130)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(320, 20)
        Me.txtResponsable.TabIndex = 9
        '
        'txtDesc2
        '
        Me.txtDesc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc2.Location = New System.Drawing.Point(116, 68)
        Me.txtDesc2.Name = "txtDesc2"
        Me.txtDesc2.Size = New System.Drawing.Size(218, 20)
        Me.txtDesc2.TabIndex = 7
        '
        'txtDesc1
        '
        Me.txtDesc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc1.Location = New System.Drawing.Point(116, 44)
        Me.txtDesc1.Name = "txtDesc1"
        Me.txtDesc1.Size = New System.Drawing.Size(218, 20)
        Me.txtDesc1.TabIndex = 6
        '
        'txtCodCaja
        '
        Me.txtCodCaja.Location = New System.Drawing.Point(116, 20)
        Me.txtCodCaja.Name = "txtCodCaja"
        Me.txtCodCaja.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCaja.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Responsable : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción 2 :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción 1 :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(513, 303)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(70, 26)
        Me.btnAñadir.TabIndex = 33
        Me.btnAñadir.Text = "Añadir"
        '
        'BtnQuitarCuota
        '
        Me.BtnQuitarCuota.Location = New System.Drawing.Point(513, 341)
        Me.BtnQuitarCuota.Name = "BtnQuitarCuota"
        Me.BtnQuitarCuota.Size = New System.Drawing.Size(70, 26)
        Me.BtnQuitarCuota.TabIndex = 34
        Me.BtnQuitarCuota.Text = "Quitar"
        '
        'dgCuotaLinea
        '
        Me.dgCuotaLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCuotaLinea.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgCuotaLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCuotaLinea.DataMember = ""
        Me.dgCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotaLinea.Location = New System.Drawing.Point(14, 303)
        Me.dgCuotaLinea.Name = "dgCuotaLinea"
        Me.dgCuotaLinea.ReadOnly = True
        Me.dgCuotaLinea.Size = New System.Drawing.Size(486, 140)
        Me.dgCuotaLinea.TabIndex = 32
        '
        'cboUsuario
        '
        Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuario.ItemHeight = 13
        Me.cboUsuario.Location = New System.Drawing.Point(91, 276)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(282, 21)
        Me.cboUsuario.TabIndex = 31
        '
        'FrmCaja
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(654, 448)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.BtnQuitarCuota)
        Me.Controls.Add(Me.dgCuotaLinea)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ValidaDatos As Boolean
    Private AIntvalor As Integer
    Private AIntResp As Integer
    Private ABoolAgregar As Boolean = False
    Private ATblImp As New DataTable
    Public GrecibeUbicacion As Object

    Dim TablaCuotasLinea As DataTable

    Private Sub FrmCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            ValidaDatos = True
            LimpiarFormularios(Me)
            Call BOTONES(True, False, False, False, True)
            AIntvalor = 0
            'AObjBus.GCargaDataCombo(cmbde, AObjBus.ListarDatos("NSP_Select_Listado_Moneda", codempresa.ToString()).Tables(0), "Código", "Descripción")
            'AObjBus.GCargaDataCombo(cmba, AObjBus.ListarDatos("NSP_Select_Listado_Moneda", codempresa.ToString()).Tables(0), "Código", "Descripción")
            ABoolAgregar = True
            bloqueatextos(Me)
            'cmbde.Enabled = False
            'cmba.Enabled = False

            CAyuda.CargarDataCombo(Me.cboUsuario, "SP_LIST_USU '" & codempresa & "'", "CDUSUARIO", "USUARIO")

        Catch
            MessageBox.Show("Error Cargando Variables", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Public Sub LLenarValores(ByVal VarCaja As String)
        Conecta("SELECT CODCAJA, DESC1CAJA, DESC2CAJA, SALDOBASCAJA, SALDOEXTCAJA, RESPONSABLE, ACTIVO FROM CAJA WHERE CODEMPRESA ='" & codempresa & "' AND CODCAJA ='" & VarCaja.Trim & "'", "TB3")
        Dim TablaDatos As New DataTable
        TablaDatos = ds.Tables("TB3")
        Me.txtCodCaja.Text = TablaDatos.Rows(0)("CODCAJA")
        Me.txtDesc1.Text = TablaDatos.Rows(0)("DESC1CAJA")
        Me.txtDesc2.Text = TablaDatos.Rows(0)("DESC2CAJA")
        Me.txtSaldoBas.Text = TablaDatos.Rows(0)("SALDOBASCAJA")
        Me.txtSaldoExt.Text = TablaDatos.Rows(0)("SALDOEXTCAJA")
        Me.txtResponsable.Text = TablaDatos.Rows(0)("RESPONSABLE")
        Me.ckActivo.Checked = TablaDatos.Rows(0)("ACTIVO")
        Me.BTNMODIFICAR.Enabled = True
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim FrmB As New FrmBusqCaja
        FrmB.FrmPadre = Me
        FrmB.ShowDialog()
        Call BOTONES(True, False, True, True, True)


        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CAJAXUSUARIO", codempresa, txtCodCaja.Text.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()



    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        ABoolAgregar = False
        Call BOTONES(False, True, False, False, True)

        desbloqueatextos(Me)
        txtSaldoBas.Text = "0.0"
        txtSaldoExt.Text = "0.0"
        ckActivo.Checked = False
        Me.txtCodCaja.Enabled = False
        Me.txtSaldoBas.Enabled = False
        Me.txtSaldoExt.Enabled = False
    End Sub


    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR

    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click

        Call BOTONES(True, False, False, False, True)
        Limpiatextbox(Me)
        bloqueatextos(Me)
        txtSaldoBas.Text = "0.0"
        txtSaldoExt.Text = "0.0"
        ckActivo.Checked = False


        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CAJAXUSUARIO", codempresa, txtCodCaja.Text.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If ABoolAgregar Then
            Conecta("SELECT CODCAJA FROM CAJA WHERE CODEMPRESA='" & codempresa & "' AND CODCAJA='" & Me.txtCodCaja.Text.Trim & "'", "DST")
            If ds.Tables("DST").Rows.Count > 0 Then
                MsgBox("Ya existe un registro con el mismo código, ingrese otro código.", MsgBoxStyle.Information)
                Exit Sub
            End If
            If Me.txtDesc1.Text.Trim.Length = 0 Then
                MsgBox("Ingrese una descripción válida para la CAJA", MsgBoxStyle.Information)
                Exit Sub
            End If
            CAyuda.Ejecutar("NSP_INSERT_CAJA", codempresa.Trim, Me.txtCodCaja.Text.Trim, Me.txtDesc1.Text.Trim, Me.txtDesc2.Text.Trim, Me.txtSaldoBas.Text.Trim, Me.txtSaldoExt.Text.Trim, Me.txtResponsable.Text.Trim, Me.ckActivo.Checked)
        Else
            If Me.txtDesc1.Text.Trim.Length = 0 Then
                MsgBox("Ingrese una descripción válida para la CAJA", MsgBoxStyle.Information)
                Exit Sub
            End If
            CAyuda.Ejecutar("NSP_UPDATE_CAJA", codempresa.Trim, Me.txtCodCaja.Text.Trim, Me.txtDesc1.Text.Trim, Me.txtDesc2.Text.Trim, Me.txtSaldoBas.Text.Trim, Me.txtResponsable.Text.Trim, Me.ckActivo.Checked)
        End If
        MsgBox("Registro guardado correctamente !")
        Call BOTONES(True, False, False, False, True)

        LimpiarFormularios(Me)
        bloqueatextos(Me)
        ckActivo.Checked = False
        txtSaldoBas.Text = "0.0"
        txtSaldoExt.Text = "0.0"


        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPOMOVIMIENTOXUSUARIO", codempresa, txtCodCaja.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()



    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        ABoolAgregar = True
        desbloqueatextos(Me)

        Call BOTONES(False, True, False, False, False)

        LimpiarFormularios(Me)
        Me.txtCodCaja.Text = GenerarNuevoCodigo()
        txtSaldoBas.Text = "0.0"
        txtSaldoExt.Text = "0.0"
        ckActivo.Checked = False
        Me.txtDesc1.Focus()
    End Sub

    Private Function GenerarNuevoCodigo() As String
        Try
            Dim VarCodigo As String
            Conecta("SELECT MAX(CAST(CODCAJA AS INT))+1 FROM CAJA WHERE CODEMPRESA ='" & codempresa.Trim & "'", "DSTR")
            VarCodigo = ds.Tables("DSTR").Rows(0)(0)
            GenerarNuevoCodigo = VarCodigo.Trim
        Catch ex As Exception
            GenerarNuevoCodigo = "1"
        End Try
    End Function

    Private Sub txtCodCaja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCaja.TextChanged




    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            If txtCodCaja.Text.Trim.Length = 0 Then
                MsgBox("Falta seleccionar un item.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            CAyuda.Ejecutar("NSP_ELIMINA_CAJA", codempresa.Trim, Me.txtCodCaja.Text.Trim)
            BTNCANCELAR_Click(sender, e)





        End If

    End Sub



    Private Sub txtSaldoBas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaldoBas.TextChanged
        Try
            Me.txtSaldoExt.Text = CDbl(Me.txtSaldoBas.Text) / VCambioVta
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "RptCaja.rpt"
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Connect = "DSN=REPORTES; uid=" & usuariodb & "; pwd=" & Trim(passworddb) & ";"
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtDesc1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesc1.TextChanged

    End Sub


    Private Sub txtCodCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCaja.KeyPress


        If Asc(e.KeyChar) = 13 Then
            Me.txtDesc1.Focus()
        End If

    End Sub

    Private Sub txtDesc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc1.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.txtDesc2.Focus()
        End If

    End Sub

    Private Sub txtDesc2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesc2.TextChanged

    End Sub

    Private Sub txtDesc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc2.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.txtResponsable.Focus()
        End If

    End Sub

    Private Sub txtSaldoBas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldoBas.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.txtSaldoExt.Focus()
        End If
    End Sub

    Private Sub txtSaldoExt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSaldoExt.TextChanged

    End Sub

    Private Sub txtSaldoExt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldoExt.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.txtResponsable.Focus()
        End If

    End Sub

    Private Sub txtResponsable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResponsable.TextChanged
     
    End Sub

    Private Sub txtResponsable_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtResponsable.KeyDown



    End Sub

    Private Sub txtResponsable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtResponsable.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Me.BTNGUARDAR.Focus()
        End If

    End Sub

    Private Sub btnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadir.Click

        CAyuda.Ejecutar("NSP_INSERT_CAJAXUSUARIO", codempresa, txtCodCaja.Text.Trim, cboUsuario.SelectedValue, cboUsuario.Text)
        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CAJAXUSUARIO", codempresa, txtCodCaja.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()

    End Sub



    Public Sub FORMATO_GRID()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TablaCuotasLinea.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CDTIPOMOV"
            .HeaderText = "CDTIPOMOV"
            .Width = 100
        End With


        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODUSUARIO"
            .HeaderText = "CODUSUARIO"
            .Width = 100
        End With

        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "DSUSUARIO"
            .HeaderText = "DSUSUARIO"
            .Width = 100
        End With

        dgCuotaLinea.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3})
        dgCuotaLinea.TableStyles.Add(TableStyle1)

    End Sub



    Private Sub BtnQuitarCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarCuota.Click


        If txtCodCaja.Text.Trim = "" Then
            MsgBox("Falta el Codigo del Tipo Movimiento..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TablaCuotasLinea.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el usuarioxTipoMovimiento " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_CAJAXUSUARIO", codempresa, txtCodCaja.Text.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 1).ToString.Trim)

            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_CTACONTABLEXUSUARIO", codempresa, txtCodCaja.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()




        End If




    End Sub
End Class

