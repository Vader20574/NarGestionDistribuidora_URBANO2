Public Class FRMUMEDIDA
    Inherits System.Windows.Forms.Form
    Dim FLAG As Integer

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtdesmedida As System.Windows.Forms.TextBox
    Friend WithEvents txtcodmedida As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtUMSunat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFactor As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMUMEDIDA))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtUMSunat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtFactor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.txtdesmedida = New System.Windows.Forms.TextBox
        Me.txtcodmedida = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(380, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 198)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(15, 132)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNCANCELAR.TabIndex = 8
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(15, 160)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNCERRAR.TabIndex = 10
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(15, 76)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNMODIFICAR.TabIndex = 6
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(15, 104)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNELIMINAR.TabIndex = 7
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(15, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(83, 23)
        Me.BTNNUEVO.TabIndex = 4
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(15, 48)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(83, 23)
        Me.BTNGUARDAR.TabIndex = 5
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtUMSunat)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtFactor)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.txtdesmedida)
        Me.GroupBox2.Controls.Add(Me.txtcodmedida)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 135)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'TxtUMSunat
        '
        Me.TxtUMSunat.AcceptsReturn = True
        Me.TxtUMSunat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUMSunat.Location = New System.Drawing.Point(119, 97)
        Me.TxtUMSunat.MaxLength = 50
        Me.TxtUMSunat.Name = "TxtUMSunat"
        Me.TxtUMSunat.Size = New System.Drawing.Size(125, 21)
        Me.TxtUMSunat.TabIndex = 11
        Me.TxtUMSunat.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Unidad Medida Sunat : "
        Me.Label4.Visible = False
        '
        'TxtFactor
        '
        Me.TxtFactor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFactor.Location = New System.Drawing.Point(116, 72)
        Me.TxtFactor.MaxLength = 4
        Me.TxtFactor.Name = "TxtFactor"
        Me.TxtFactor.Size = New System.Drawing.Size(72, 21)
        Me.TxtFactor.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Factor : "
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(192, 21)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdesmedida
        '
        Me.txtdesmedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdesmedida.Location = New System.Drawing.Point(116, 46)
        Me.txtdesmedida.MaxLength = 50
        Me.txtdesmedida.Name = "txtdesmedida"
        Me.txtdesmedida.Size = New System.Drawing.Size(228, 21)
        Me.txtdesmedida.TabIndex = 3
        '
        'txtcodmedida
        '
        Me.txtcodmedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodmedida.Location = New System.Drawing.Point(116, 22)
        Me.txtcodmedida.MaxLength = 4
        Me.txtcodmedida.Name = "txtcodmedida"
        Me.txtcodmedida.Size = New System.Drawing.Size(72, 21)
        Me.txtcodmedida.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Unidad Medida : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo :"
        '
        'FRMUMEDIDA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(504, 208)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(510, 240)
        Me.Name = "FRMUMEDIDA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidades de Medida "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Dim sql As String
        Dim PROCESO As Boolean
        Call formatotextbox(Me)
        If txtcodmedida.Text = "" Or txtdesmedida.Text = "" Or TxtFactor.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If FLAG = 0 Then
            Conecta("SELECT CODUMED FROM UMEDIDA WHERE CODUMED='" & Me.txtcodmedida.Text.Trim & "' AND CODEMPRESA='" & codempresa & "'", "VER")
            If ds.Tables("VER").Rows.Count > 0 Then
                MessageBox.Show("El còdigo ingresado ya esta registrado para una Medida. Las Medidas y Unidades de Medida deben tener códigos diferentes", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Conecta("SELECT * FROM UMEDIDA WHERE desumed='" & Me.txtdesmedida.Text.Trim & "' AND CODEMPRESA='" & codempresa & "'", "VER")
            If ds.Tables("VER").Rows.Count > 0 Then
                MessageBox.Show("La descripcion ingresado ya esta registrado para una Medida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            sql = "nsp_inst_umedida '" & txtcodmedida.Text & "','" & txtdesmedida.Text & "','" & codempresa & "','" & TxtFactor.Text & "','" & TxtUMSunat.Text & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodmedida.Text & "','INSERT','UNIMEDIDA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            End If

        End If
        If FLAG = 1 Then
            sql = "nsp_upda_umedida '" & txtcodmedida.Text & "','" & txtdesmedida.Text & "','" & codempresa & "', '" & TxtFactor.Text & "','" & TxtUMSunat.Text & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodmedida.Text & "','UPDATE','UNIMEDIDA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MessageBox.Show("La descripcion ingresado ya esta registrado para una Medida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If

        If PROCESO = False Then
            Exit Sub
        Else
            MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If

        Call BOTONES(True, False, False, False, True)

        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
        BTNNUEVO.Focus()
    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)
        FLAG = 0
        txtcodmedida.Focus()
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Call limpiatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call bloqueatextbox(Me)
    End Sub
    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim FRMX As New frmgridumedida
        FRMX.ShowDialog()
        mostrar()
        Call BOTONES(True, False, True, True, True)
        txtcodmedida.ReadOnly = True
    End Sub
    Public Sub mostrar()
        txtcodmedida.Text = VAR1
        txtdesmedida.Text = VAR2
        TxtFactor.Text = VAR3
        TxtUMSunat.Text = VAR4
    End Sub
    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        txtcodmedida.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        FLAG = 1
        Me.txtdesmedida.Focus()
        Me.txtdesmedida.SelectAll()
    End Sub
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR
    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim PROCESO As Boolean
        Dim sql As String
        sql = "nsp_DELE_umedida '" & txtcodmedida.Text & "','" & codempresa & "'"
        PROCESO = TmpInsertDatos(sql)
        If PROCESO = True Then
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodmedida.Text & "','DELETE','UNIMEDIDA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
        End If

        If PROCESO = False Then
            Exit Sub
        Else
            MsgBox("SE ELIMINO CORRECTAMENTE EL  REGISTRO...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If


        BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
    End Sub
    Private Sub frmmedida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub FRMUMEDIDA_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        BTNNUEVO.Focus()
    End Sub

    Private Sub txtcodmedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodmedida.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdesmedida.Focus()
        End If
    End Sub

    Private Sub txtdesmedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesmedida.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            TxtFactor.Focus()
        End If
    End Sub

    Private Sub txtcodmedida_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodmedida.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub txtdesmedida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdesmedida.TextChanged

    End Sub

    Private Sub TxtFactor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFactor.TextChanged

    End Sub

    Private Sub TxtFactor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFactor.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            Me.BTNGUARDAR.Focus()
        End If

        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub
End Class


