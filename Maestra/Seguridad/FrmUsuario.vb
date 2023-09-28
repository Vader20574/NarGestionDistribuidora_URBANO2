Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmUsuario
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
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtclaveconfi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbnivel As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtvend As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuario))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtvend = New System.Windows.Forms.TextBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.cmbnivel = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtclaveconfi = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtclave = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtvend)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.cmbnivel)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtclaveconfi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtclave)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.txtcod)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 160)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'txtvend
        '
        Me.txtvend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvend.Location = New System.Drawing.Point(111, 139)
        Me.txtvend.MaxLength = 100000
        Me.txtvend.Name = "txtvend"
        Me.txtvend.Size = New System.Drawing.Size(446, 21)
        Me.txtvend.TabIndex = 27
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(233, 11)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 18
        '
        'cmbnivel
        '
        Me.cmbnivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnivel.Location = New System.Drawing.Point(112, 115)
        Me.cmbnivel.Name = "cmbnivel"
        Me.cmbnivel.Size = New System.Drawing.Size(160, 21)
        Me.cmbnivel.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(71, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nivel :"
        '
        'txtclaveconfi
        '
        Me.txtclaveconfi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtclaveconfi.Location = New System.Drawing.Point(112, 89)
        Me.txtclaveconfi.MaxLength = 12
        Me.txtclaveconfi.Name = "txtclaveconfi"
        Me.txtclaveconfi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclaveconfi.Size = New System.Drawing.Size(160, 21)
        Me.txtclaveconfi.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Confirmar Clave :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtclave
        '
        Me.txtclave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtclave.Location = New System.Drawing.Point(112, 63)
        Me.txtclave.MaxLength = 12
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(160, 21)
        Me.txtclave.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Clave :"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(112, 37)
        Me.txtdescripcion.MaxLength = 30
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(272, 21)
        Me.txtdescripcion.TabIndex = 2
        '
        'txtcod
        '
        Me.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcod.Location = New System.Drawing.Point(112, 11)
        Me.txtcod.MaxLength = 20
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(120, 21)
        Me.txtcod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdUsuario :"
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 82)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(171, 50)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(104, 28)
        Me.btnreporte.TabIndex = 11
        Me.btnreporte.Text = "&Reporte"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(66, 50)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(104, 28)
        Me.BTNCANCELAR.TabIndex = 10
        Me.BTNCANCELAR.Text = "&Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(276, 50)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(104, 28)
        Me.BTNCERRAR.TabIndex = 12
        Me.BTNCERRAR.Text = "&Cerrar"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(228, 21)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(104, 28)
        Me.BTNMODIFICAR.TabIndex = 8
        Me.BTNMODIFICAR.Text = "&Modificar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(333, 21)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(104, 28)
        Me.BTNELIMINAR.TabIndex = 9
        Me.BTNELIMINAR.Text = "&Eliminar"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(16, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(104, 28)
        Me.BTNNUEVO.TabIndex = 6
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(121, 20)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(104, 28)
        Me.BTNGUARDAR.TabIndex = 7
        Me.BTNGUARDAR.Text = "&Guardar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(578, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(482, 158)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 124
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Vendedor :"
        '
        'FrmUsuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(716, 262)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(742, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(542, 290)
        Me.Name = "FrmUsuario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Usuario"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Public objbus As New ClsInterface
    Private valor As Integer
    Private Resp As Integer
    Private agregar As Boolean
    Private ValidaDatos As Boolean


    Private Sub FrmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValidaDatos = False

        Call BOTONES(True, False, False, False, True)

        valor = 0
        agregar = True
        bloqueatextos(Me)
        CAyuda.CargarDataCombo(cmbnivel, "NSP_Select_Listado_Nivel  '" & codempresa & "'", "Código", "Descripción")

    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        desbloqueatextos(Me)
        ''Me.cmbnivel.SelectedIndex = 0

        Call BOTONES(False, True, False, False, False)

        txtcod.Enabled = True
        txtdescripcion.Enabled = True
        LimpiarFormularios(Me)
        txtcod.Focus()
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

        LimpiarFormularios(Me)
        bloqueatextos(Me)

    End Sub
    Private Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim FrmBusc As New FrmBusqUsuario
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        Try
            With FrmBusc.gridUsuario
                cmbnivel.SelectedValue = .Item(.CurrentRowIndex, 0)
                txtcod.Text = Trim(.Item(.CurrentRowIndex, 1)).ToString
                txtdescripcion.Text = Trim(.Item(.CurrentRowIndex, 2)).ToString
                txtclave.Text = Trim(.Item(.CurrentRowIndex, 3)).ToString
                txtclaveconfi.Text = Trim(.Item(.CurrentRowIndex, 3)).ToString
                txtvend.Text = Trim(.Item(.CurrentRowIndex, 4)).ToString
            End With
        Catch eqx As Exception
            Exit Sub
        End Try


        Call BOTONES(True, False, True, True, True)

    End Sub
    Sub valida_datos()
        If txtcod.Text = "" Then
            ValidaDatos = True
        End If
        If txtdescripcion.Text = "" Then
            ValidaDatos = True
        End If

    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        If ValidaDatos Then
            MsgBox("FALTA INGRESAR ALGUNOS VALORES", MsgBoxStyle.Information, "AVISO")
            Exit Sub
        End If






        If agregar Then
            If Me.txtcod.Text.Trim = "" Then
                MessageBox.Show("Ingrese Un Codigo Por Favor al Usuario", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtcod.Focus()
                Exit Sub
            End If

            If Me.txtdescripcion.Text.Trim = "" Then
                MessageBox.Show("Ingrese Una Descripcion Por Favor al Usuario", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtdescripcion.Focus()
                Exit Sub
            End If

            If Me.txtclave.Text.Trim = "" Then
                MessageBox.Show("Ingrese Una Clave Por Favor al Usuario", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtclave.Focus()
                Exit Sub
            End If

            If Me.txtclaveconfi.Text.Trim <> Me.txtclave.Text.Trim Then
                MessageBox.Show("La Clave Confirmada no es Igual a la Clave Actual", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtclaveconfi.Text = ""
                Me.txtclaveconfi.Focus()
                Exit Sub
            End If



            Resp = CAyuda.Ejecutar("NSP_ins_USUARIO", Date.Now, cmbnivel.SelectedValue, txtclave.Text, txtdescripcion.Text, txtcod.Text, codempresa.ToString(), txtvend.Text)

            If CAyuda.ListarDatos("USP_BUSCAR_CODIGO_USUARIO", txtcod.Text.Trim).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("El Codigo Ya Existe para el Usuario", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtcod.Text = ""
                Me.txtcod.Focus()
                Exit Sub
            Else
                Resp = CAyuda.Ejecutar("NSP_ins_USUARIO", Date.Now, cmbnivel.SelectedValue, txtclave.Text, txtdescripcion.Text, txtcod.Text, codempresa.ToString(), txtvend.Text)
                If Resp = 1 Then
                    MessageBox.Show("Registro Grabado Correctamente, Gracias ...", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','INSERT','USUARIO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MsgBox("Error Durante Esta Operacion", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
                End If
            End If
        Else
            If Me.txtdescripcion.Text.Trim = "" Then
                MessageBox.Show("Ingrese Una Descripcion Por Favor al Usuario", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtdescripcion.Focus()
                Exit Sub
            End If

            If Me.txtclave.Text.Trim = "" Then
                MessageBox.Show("Ingrese Una Clave Por Favor al Usuario", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtclave.Focus()
                Exit Sub
            End If

            If Me.txtclaveconfi.Text.Trim <> Me.txtclave.Text.Trim Then
                MessageBox.Show("La Clave Confirmada no es Igual al Clave Actual", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtclaveconfi.Focus()
                Exit Sub
            End If






            Resp = CAyuda.Ejecutar("NSP_upd_USUARIO", cmbnivel.SelectedValue, txtclave.Text, txtdescripcion.Text, txtcod.Text, 0, txtvend.Text)
            If Resp = 1 Then
                MessageBox.Show("Registro Actualizado Correctamente", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','UPDATE','USUARIO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("Error DuranTe Esta Operacion", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            End If
        End If

        Call BOTONES(True, False, False, False, True)

        LimpiarFormularios(Me)
        bloqueatextos(Me)
        Me.cmbnivel.SelectedIndex = 0



    End Sub
    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            'valor = objbus.ListarDatos("NSP_Select_VerficaCodigoUsuario", txtcod.Text, G2_CODEMPRESA.ToString()).Tables(0).Rows.Count
            'If valor <> 0 Then
            '    MessageBox.Show("El Codigo Ya Existe", strempresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            txtdescripcion.Focus()
        End If
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    Private Sub BTNMODIFICAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        If Me.txtcod.Text.Trim = "" Then
            MsgBox("No Selecciono Usuario para Actualizar", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
            Exit Sub
        End If
        desbloqueatextos(Me)
        agregar = False

        Call BOTONES(False, True, False, False, True)

        txtdescripcion.ReadOnly = False
        txtcod.ReadOnly = True
    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If Me.txtcod.Text.Trim = "" Then
            MsgBox("No Selecciono Usuario para Eliminar", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
            Exit Sub
        End If
        Resp = CAyuda.Ejecutar("NSP_del_USUARIO", txtcod.Text, 1, 0)
        If Resp = 1 Then
            MessageBox.Show("Registro Eliminado Correctamente", "NAR SISTEMAS S.A.C", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','DELETE','USUARIO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
        End If
        LimpiarFormularios(Me)
        bloqueatextos(Me)
        Me.cmbnivel.SelectedIndex = 0

        BOTONES(True, False, False, False, True)

    End Sub


    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txtclave.Focus()
        End If
    End Sub

    Private Sub txtclave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclave.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txtclaveconfi.Focus()
        End If
    End Sub
    Private Sub txtclaveconfi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtclaveconfi.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            VericaClave()
        End If
    End Sub
    Sub VericaClave()
        'If Trim(txtclave.Text) = Trim(txtclaveconfi.Text) Then
        '    cmbnivel.Focus()
        'Else
        '    MessageBox.Show("Clave Errada", strempresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    txtclaveconfi.Focus()
        '    txtclaveconfi.Text = ""
        '    Exit Sub
        'End If
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub
    Private Sub FrmUsuario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        BTNNUEVO.Focus()
    End Sub
    Private Sub txtclaveconfi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtclaveconfi.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cmbnivel.Focus()
        End If
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        crRpt.ReportFileName = rutareporte & "RptUsuario.rpt"
        crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
        crRpt.set_StoredProcParam(0, codempresa)
        crRpt.set_StoredProcParam(1, CodUsuario)
        crRpt.Destination = Crystal.DestinationConstants.crptToWindow
        crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
        crRpt.Action = 1
        crRpt.Reset()
    End Sub

    Private Sub cmbnivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbnivel.SelectedIndexChanged

    End Sub

    Private Sub cmbnivel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbnivel.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If

    End Sub
End Class
