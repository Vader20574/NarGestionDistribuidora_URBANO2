Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmTipoPago
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
    Friend WithEvents Grplistado As System.Windows.Forms.GroupBox
    Friend WithEvents grdLinea As System.Windows.Forms.DataGrid
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoPago))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Grplistado = New System.Windows.Forms.GroupBox
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.grdLinea = New System.Windows.Forms.DataGrid
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Grplistado.SuspendLayout()
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'Grplistado
        '
        Me.Grplistado.Controls.Add(Me.rbmedida)
        Me.Grplistado.Controls.Add(Me.rbcodigo)
        Me.Grplistado.Controls.Add(Me.grdLinea)
        Me.Grplistado.Controls.Add(Me.txtdato)
        Me.Grplistado.Controls.Add(Me.Label3)
        Me.Grplistado.Location = New System.Drawing.Point(8, 4)
        Me.Grplistado.Name = "Grplistado"
        Me.Grplistado.Size = New System.Drawing.Size(494, 226)
        Me.Grplistado.TabIndex = 20
        Me.Grplistado.TabStop = False
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(376, 16)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(88, 16)
        Me.rbmedida.TabIndex = 5
        Me.rbmedida.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(296, 16)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 16)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'grdLinea
        '
        Me.grdLinea.BackgroundColor = System.Drawing.Color.Gray
        Me.grdLinea.DataMember = ""
        Me.grdLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLinea.Location = New System.Drawing.Point(20, 48)
        Me.grdLinea.Name = "grdLinea"
        Me.grdLinea.ReadOnly = True
        Me.grdLinea.Size = New System.Drawing.Size(456, 152)
        Me.grdLinea.TabIndex = 3
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(88, 16)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(189, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dato : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.txtcod)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 88)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(100, 48)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(260, 21)
        Me.txtdescripcion.TabIndex = 3
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(178, 22)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcod
        '
        Me.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcod.Location = New System.Drawing.Point(100, 23)
        Me.txtcod.MaxLength = 4
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(72, 21)
        Me.txtcod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Código :"
        '
        'btnreporte
        '
        Me.btnreporte.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(13, 152)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(78, 23)
        Me.btnreporte.TabIndex = 9
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(13, 126)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNCANCELAR.TabIndex = 8
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(13, 179)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNCERRAR.TabIndex = 10
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(13, 71)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNMODIFICAR.TabIndex = 6
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(13, 100)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNELIMINAR.TabIndex = 7
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(13, 15)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(78, 23)
        Me.BTNNUEVO.TabIndex = 4
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(13, 43)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNGUARDAR.TabIndex = 5
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox1.Location = New System.Drawing.Point(400, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 213)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(22, 4)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 21
        '
        'FrmTipoPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(514, 236)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.Grplistado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 264)
        Me.Name = "FrmTipoPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Tipo Pago"
        Me.Grplistado.ResumeLayout(False)
        Me.Grplistado.PerformLayout()
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ValidaDatos As Boolean
    Private valor As Integer
    Private Resp As Integer
    Private agregar As Boolean
    Private tblImp As New DataTable

    Private Sub FrmTipoPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValidaDatos = False
          Call BOTONES(True, False, False, False, True)
        txtcod.Enabled = False
        txtdescripcion.Enabled = False
        Grplistado.Visible = False
        valor = 0
        agregar = True
        tblImp = CAyuda.ListarDatos("NSP_Select_Listado_TipoPago", codempresa.ToString()).Tables(0)
        grdLinea.DataSource = tblImp
        FormatGrid()
        BTNNUEVO.Focus()
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR
    End Sub



    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                         ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If grdLinea.Focus = True Then
                        Dim tblc As DataTable
                        Try
                            tblc = CAyuda.ListarDatos("NSP_Select_VerficaCodigoTipoPago", grdLinea.Item(grdLinea.CurrentRowIndex, 0), codempresa.ToString()).Tables(0)
                            txtcod.Text = tblc.Rows(0)(0)
                            txtdescripcion.Text = tblc.Rows(0)(1)
                            tblc.Dispose()
                            Grplistado.Visible = False
                        Catch
                            txtdato.Focus()
                            Exit Function
                        End Try
                    End If
                Case Keys.Escape
                    Grplistado.Visible = False
            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        desbloqueatextos(Me)
        Call BOTONES(False, True, False, False, False)
        txtcod.Enabled = True
        txtdescripcion.Enabled = True
        txtcod.Focus()
        LimpiarFormularios(Me)
        txtcod.Focus()
        agregar = True
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Call BOTONES(True, False, False, False, True)
        LimpiarFormularios(Me)
        txtcod.Enabled = False
        txtdescripcion.Enabled = False

    End Sub

    Private Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        BTNCANCELAR_Click(sender, e)
        Grplistado.Visible = True
        txtdato.Focus()
        tblImp = CAyuda.ListarDatos("NSP_Select_Listado_TipoPago", codempresa.ToString()).Tables(0)
        grdLinea.DataSource = tblImp
        Call BOTONES(True, False, True, True, True)
        txtdato.ReadOnly = False



    End Sub

    Private Sub Linea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Grplistado.Visible = False
        End If
    End Sub

    Private Sub Grplistado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grplistado.KeyDown
        If e.KeyCode = Keys.Escape Then
            Grplistado.Visible = False
        End If
    End Sub


    Private Sub txtdato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdato.KeyDown
        If e.KeyCode = Keys.Escape Then
            Grplistado.Visible = False
        End If
    End Sub
    Sub valida_datos()
        If txtcod.Text = "" Then
            ValidaDatos = True
        End If
        If txtdescripcion.Text = "" Then
            ValidaDatos = True
        End If

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        valida_datos()
        If ValidaDatos Then
            MsgBox("FALTA INGRESAR ALGUNOS VALORES", MsgBoxStyle.Information, "AVISO")
            ValidaDatos = False
            Exit Sub
        End If

        valor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoTipoPago", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
        If agregar Then

            If valor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Resp = CAyuda.Ejecutar("NSP_ins_TIPOPAGO", txtdescripcion.Text, txtcod.Text, codempresa.ToString())
                If Resp = 1 Then
                    Guardar_Nextel()
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','INSERT','TIPOPAGO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
                End If
            End If
        Else
            Resp = CAyuda.Ejecutar("NSP_upd_TIPOPAGO", 0, txtdescripcion.Text, txtcod.Text)
            If Resp = 1 Then
                Guardar_Nextel()
                MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','UPDATE','TIPOPAGO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
            End If
        End If

        Call BOTONES(True, False, False, False, True)

        LimpiarFormularios(Me)
        bloqueatextos(Me)
        BTNNUEVO.Focus()

    End Sub
    Sub Guardar_Nextel()
        Try

            If ACTIVABD = True Then
                CAyuda.Ejecutar(2, "SP_IN_FORMA_PAGO", VCODNEXTEL.Trim, txtcod.Text.Trim, txtdescripcion.Text.Trim)

            End If
        Catch ex As Exception
            MsgBox("Problema de conexión con Nextel, intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try

    End Sub
    Sub Eliminar_Nextel()
        Try
            If ACTIVABD = True Then
                CAyuda.Ejecutar(2, "SP_DEL_FORMA_PAGO", VCODNEXTEL.Trim, txtcod.Text.Trim)
            End If
        Catch ex As Exception
            MsgBox("Problema de conexión con Nextel, intentelo otra vez.", MsgBoxStyle.Information, "NARSISTEMAS")
        End Try

    End Sub



    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            valor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoTipoPago", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
            If valor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            txtdescripcion.Focus()
        End If
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        desbloqueatextos(Me)
        agregar = False
        Call BOTONES(False, True, False, False, True)
        txtdescripcion.ReadOnly = False
        txtdescripcion.Enabled = True
    End Sub


    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        If Me.rbcodigo.Checked = True Then
            tblImp = CAyuda.ListarDatos("NSP_Select_Listado_TipoPago_FILTRADO", codempresa.ToString(), txtdato.Text, 0).Tables(0)
            grdLinea.DataSource = tblImp
        Else
            tblImp = CAyuda.ListarDatos("NSP_Select_Listado_TipoPago_FILTRADO", codempresa.ToString(), txtdato.Text, 1).Tables(0)
            grdLinea.DataSource = tblImp
        End If

    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then

            If txtcod.Text.Length = 0 Then
                MsgBox("Falta seleccionar un tipo de pago.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            Resp = CAyuda.Ejecutar("NSP_del_TIPOPAGO", 0, 1, txtcod.Text)
            If Resp = 1 Then
                Eliminar_Nextel()
                MessageBox.Show("Registro Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','DELETE','TIPOPAGO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("El codigo se encuentra en uso, no se puede eliminar.", MsgBoxStyle.Information, "Aviso")

            End If
            LimpiarFormularios(Me)
            bloqueatextos(Me)
            BOTONES(True, False, False, False, True)

        End If


    End Sub

    Private Sub cmborden_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .MappingName = tblImp.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Codigo"
            .MappingName = "Código"
            .Width = 80
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Descripcion"
            .MappingName = "Descripción"
            .Width = 280
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2})
        grdLinea.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub grdLinea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLinea.DoubleClick
        Dim tblc As DataTable
        Try
            tblc = CAyuda.ListarDatos("NSP_Select_VerficaCodigoTipoPago", grdLinea.Item(grdLinea.CurrentRowIndex, 0), codempresa.ToString()).Tables(0)
            txtcod.Text = tblc.Rows(0)(0)
            txtdescripcion.Text = tblc.Rows(0)(1)
            tblc.Dispose()
            Grplistado.Visible = False
        Catch
            txtdato.Focus()
            Exit Sub
        End Try
    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub btnreporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Try
            crRpt.ReportFileName = rutareporte & "RptTipoPago.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_StoredProcParam(1, CodUsuario)
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
