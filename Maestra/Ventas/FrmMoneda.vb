Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmMoneda
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
    Friend WithEvents Grplistado As System.Windows.Forms.GroupBox
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
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
    Friend WithEvents gridMoneda As System.Windows.Forms.DataGrid
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMoneda))
        Me.Grplistado = New System.Windows.Forms.GroupBox
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.gridMoneda = New System.Windows.Forms.DataGrid
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtvalor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.btnreporte = New System.Windows.Forms.Button
        Me.Grplistado.SuspendLayout()
        CType(Me.gridMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grplistado
        '
        Me.Grplistado.Controls.Add(Me.rbmedida)
        Me.Grplistado.Controls.Add(Me.rbcodigo)
        Me.Grplistado.Controls.Add(Me.gridMoneda)
        Me.Grplistado.Controls.Add(Me.txtdato)
        Me.Grplistado.Controls.Add(Me.Label4)
        Me.Grplistado.Location = New System.Drawing.Point(10, 2)
        Me.Grplistado.Name = "Grplistado"
        Me.Grplistado.Size = New System.Drawing.Size(478, 234)
        Me.Grplistado.TabIndex = 21
        Me.Grplistado.TabStop = False
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(336, 24)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(88, 16)
        Me.rbmedida.TabIndex = 7
        Me.rbmedida.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(264, 24)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 6
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'gridMoneda
        '
        Me.gridMoneda.BackgroundColor = System.Drawing.Color.Gray
        Me.gridMoneda.DataMember = ""
        Me.gridMoneda.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.gridMoneda.Location = New System.Drawing.Point(14, 56)
        Me.gridMoneda.Name = "gridMoneda"
        Me.gridMoneda.ReadOnly = True
        Me.gridMoneda.Size = New System.Drawing.Size(448, 168)
        Me.gridMoneda.TabIndex = 3
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(56, 24)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(181, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dato : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtvalor)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.txtcod)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 112)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'txtvalor
        '
        Me.txtvalor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtvalor.Location = New System.Drawing.Point(88, 72)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(136, 21)
        Me.txtvalor.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Simbolo :"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(88, 48)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(256, 21)
        Me.txtdescripcion.TabIndex = 2
        '
        'txtcod
        '
        Me.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcod.Location = New System.Drawing.Point(88, 24)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(80, 21)
        Me.txtcod.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Descripción :"
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(176, 24)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(45, 23)
        Me.btnbuscar.TabIndex = 4
        Me.btnbuscar.Text = "..."
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 186)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(14, 128)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(74, 23)
        Me.BTNCANCELAR.TabIndex = 9
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(15, 155)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(74, 23)
        Me.BTNCERRAR.TabIndex = 11
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(14, 74)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(74, 23)
        Me.BTNMODIFICAR.TabIndex = 7
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(14, 101)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(74, 23)
        Me.BTNELIMINAR.TabIndex = 8
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(14, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(74, 23)
        Me.BTNNUEVO.TabIndex = 5
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(14, 47)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(74, 23)
        Me.BTNGUARDAR.TabIndex = 6
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(14, 155)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(74, 23)
        Me.btnreporte.TabIndex = 10
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'FrmMoneda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(496, 240)
        Me.Controls.Add(Me.Grplistado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(504, 272)
        Me.Name = "FrmMoneda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Moneda"
        Me.Grplistado.ResumeLayout(False)
        Me.Grplistado.PerformLayout()
        CType(Me.gridMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

 
    Private AIntvalor As Integer
    Private AIntResp As Integer
    Private ABoolAgregar As Boolean
    Private ATblImp As New DataTable
    Private ValidaDatos As Boolean


    Private Sub FrmMoneda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValidaDatos = False
        Call BOTONES(True, False, False, False, True)
        Grplistado.Visible = False
        AIntvalor = 0
        ABoolAgregar = True
        bloqueatextos(Me)
        ATblImp = CAyuda.ListarDatos("NSP_Select_Listado_Moneda", codempresa.ToString()).Tables(0)
        gridMoneda.DataSource = ATblImp
        FormatGrid()

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                        ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If gridMoneda.Focus = True Then

                        EnviarDatosImpuesto()
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
        LimpiarFormularios(Me)
        txtcod.Focus()
        ABoolAgregar = True
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
        BTNCANCELAR_Click(sender, e)
        Grplistado.Visible = True
        txtdato.Focus()
        ATblImp = CAyuda.ListarDatos("NSP_Select_Listado_Moneda", codempresa.ToString()).Tables(0)
        gridMoneda.DataSource = ATblImp
        txtdato.Text = ""
        txtdato.ReadOnly = False
        Call BOTONES(True, False, True, True, True)
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

    Private Sub BTNGUARDAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        valida_datos()
        If ValidaDatos Then
            MsgBox("FALTA INGRESAR ALGUNOS VALORES", MsgBoxStyle.Information, "AVISO")
            ValidaDatos = False
            Exit Sub
        End If
        AIntvalor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoMoneda", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
        If ABoolAgregar Then

            If AIntvalor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                AIntResp = CAyuda.Ejecutar("NSP_ins_Moneda", txtvalor.Text, txtdescripcion.Text, txtcod.Text, codempresa.ToString())
                If AIntResp = 1 Then
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtvalor.Text.Trim & "','INSERT','MONEDA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
                End If
            End If
        Else
            AIntResp = CAyuda.Ejecutar("NSP_upd_Moneda", txtvalor.Text, txtdescripcion.Text, txtcod.Text, 0)
            If AIntResp = 1 Then
                MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtvalor.Text.Trim & "','UPDATE','MONEDA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
            End If
        End If

        Call BOTONES(True, False, False, False, True)

        LimpiarFormularios(Me)
        bloqueatextos(Me)
    End Sub


    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            AIntvalor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoMoneda", txtcod.Text, codempresa.ToString).Tables(0).Rows.Count
            If AIntvalor <> 0 Then
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
        ABoolAgregar = False
        Call BOTONES(False, True, False, False, True)
        txtdescripcion.ReadOnly = False
        txtcod.ReadOnly = True
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then

            If txtcod.Text.Trim.Length = 0 Then
                MsgBox("Falta seleccionar un item.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
            AIntResp = CAyuda.Ejecutar("NSP_del_Moneda", txtcod.Text, 1, 0)
            If AIntResp = 1 Then
                MessageBox.Show("Registro Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtvalor.Text.Trim & "','DELETE','IMPUESTO','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
            End If
            LimpiarFormularios(Me)
            bloqueatextos(Me)

            BOTONES(True, False, False, False, True)

        End If




    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        If Me.rbcodigo.Checked = True Then
            ATblImp = CAyuda.ListarDatos("NSP_Select_Listado_Moneda_FILTRADO", codempresa.ToString(), txtdato.Text, 0).Tables(0)
            gridMoneda.DataSource = ATblImp
        Else
            ATblImp = CAyuda.ListarDatos("NSP_Select_Listado_Moneda_FILTRADO", codempresa.ToString(), txtdato.Text, 1).Tables(0)
            gridMoneda.DataSource = ATblImp
        End If

    End Sub



    Private Sub cmborden_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txtvalor.Focus()
        End If
    End Sub


    Sub EnviarDatosImpuesto()
        Dim tblc As DataTable
        Try
            tblc = CAyuda.ListarDatos("NSP_Select_VerficaCodigoMoneda", gridMoneda.Item(gridMoneda.CurrentRowIndex, 0), codempresa.ToString()).Tables(0)
            txtcod.Text = tblc.Rows(0)(0)
            txtdescripcion.Text = tblc.Rows(0)(1)
            txtvalor.Text = tblc.Rows(0)(2)
            tblc.Dispose()
            Grplistado.Visible = False
        Catch eqx As Exception
            txtdato.Focus()
            Exit Sub
        End Try
    End Sub

    Private Sub txtdato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdato.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            EnviarDatosImpuesto()
        End If
    End Sub
    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .MappingName = ATblImp.TableName
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
            .Width = 235
        End With

        Dim grdColStyle3 As New DataGridTextBoxColumn
        With grdColStyle3
            .HeaderText = "Mon.Simbolo"
            .MappingName = "simbolo"
            .Width = 50
        End With
        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3})
        gridMoneda.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub gridMoneda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridMoneda.DoubleClick
        EnviarDatosImpuesto()
    End Sub

    Private Sub txtvalor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvalor.TextChanged

    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged

    End Sub

    Private Sub txtvalor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalor.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If

    End Sub
End Class
