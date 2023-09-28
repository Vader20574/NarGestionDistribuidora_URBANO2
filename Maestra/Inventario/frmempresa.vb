Public Class frmempresa
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTRUC As System.Windows.Forms.TextBox
    Friend WithEvents TXTRAZONSOCIALABR As System.Windows.Forms.TextBox
    Friend WithEvents TXTRAZONSOCIAL As System.Windows.Forms.TextBox
    Friend WithEvents TXTCODEMPRESA As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmempresa))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TXTRUC = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXTRAZONSOCIALABR = New System.Windows.Forms.TextBox
        Me.TXTRAZONSOCIAL = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.TXTCODEMPRESA = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox2.Controls.Add(Me.TXTRUC)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TXTRAZONSOCIALABR)
        Me.GroupBox2.Controls.Add(Me.TXTRAZONSOCIAL)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.TXTCODEMPRESA)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 150)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'TXTRUC
        '
        Me.TXTRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRUC.Location = New System.Drawing.Point(128, 104)
        Me.TXTRUC.MaxLength = 11
        Me.TXTRUC.Name = "TXTRUC"
        Me.TXTRUC.Size = New System.Drawing.Size(106, 21)
        Me.TXTRUC.TabIndex = 16
        Me.TXTRUC.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "R.U.C."
        '
        'TXTRAZONSOCIALABR
        '
        Me.TXTRAZONSOCIALABR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRAZONSOCIALABR.Location = New System.Drawing.Point(128, 79)
        Me.TXTRAZONSOCIALABR.MaxLength = 50
        Me.TXTRAZONSOCIALABR.Name = "TXTRAZONSOCIALABR"
        Me.TXTRAZONSOCIALABR.Size = New System.Drawing.Size(169, 21)
        Me.TXTRAZONSOCIALABR.TabIndex = 14
        Me.TXTRAZONSOCIALABR.Text = ""
        '
        'TXTRAZONSOCIAL
        '
        Me.TXTRAZONSOCIAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTRAZONSOCIAL.Location = New System.Drawing.Point(128, 52)
        Me.TXTRAZONSOCIAL.MaxLength = 50
        Me.TXTRAZONSOCIAL.Name = "TXTRAZONSOCIAL"
        Me.TXTRAZONSOCIAL.Size = New System.Drawing.Size(236, 21)
        Me.TXTRAZONSOCIAL.TabIndex = 13
        Me.TXTRAZONSOCIAL.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Razon Social Abrev :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Razon Social : "
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(187, 25)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(47, 23)
        Me.btnbuscar.TabIndex = 10
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXTCODEMPRESA
        '
        Me.TXTCODEMPRESA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTCODEMPRESA.Location = New System.Drawing.Point(128, 26)
        Me.TXTCODEMPRESA.MaxLength = 4
        Me.TXTCODEMPRESA.Name = "TXTCODEMPRESA"
        Me.TXTCODEMPRESA.Size = New System.Drawing.Size(56, 21)
        Me.TXTCODEMPRESA.TabIndex = 8
        Me.TXTCODEMPRESA.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(407, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 191)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(15, 128)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNCANCELAR.TabIndex = 5
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
        Me.BTNCERRAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(15, 74)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNMODIFICAR.TabIndex = 3
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(15, 101)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNELIMINAR.TabIndex = 2
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
        Me.BTNNUEVO.Size = New System.Drawing.Size(76, 23)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(15, 47)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmempresa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(529, 205)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(535, 237)
        Me.Name = "frmempresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Empresa"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Dim sql As String
        Dim PROCESO As Boolean
        Call formatotextbox(Me)
        If TXTCODEMPRESA.Text = "" Or TXTRAZONSOCIAL.Text = "" Or TXTRAZONSOCIALABR.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If FACT_GValidaRUC(TXTRUC.Text) = False Then
            Exit Sub
        End If

        If FLAG = 0 Then
            If CAyuda.ListarDatos("SP_VAL_COD_EMP", TXTCODEMPRESA.Text.Trim).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("El codigo ya existe.", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If TmpListarDatos("select * from empresa WHERE ruc='" & TXTRUC.Text.Trim & "'").Rows.Count > 0 Then
                MsgBox("EL RUC YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If


            sql = "nsp_inst_empresa '" & TXTCODEMPRESA.Text & "','" & TXTRAZONSOCIAL.Text & "','" & TXTRAZONSOCIALABR.Text & "','" & TXTRUC.Text & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TXTCODEMPRESA.Text & "','INSERT','EMPRESA','" & Format(System.DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            End If
        End If

        If FLAG = 1 Then
            sql = "nsp_upda_empresa '" & TXTCODEMPRESA.Text & "','" & TXTRAZONSOCIAL.Text & "','" & TXTRAZONSOCIALABR.Text & "','" & TXTRUC.Text & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TXTCODEMPRESA.Text & "','UPDATE','EMPRESA','" & Format(System.DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
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
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)
        FLAG = 0
        TXTCODEMPRESA.Focus()


    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
    End Sub
    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim FRMX As New FRMGRIDEMPRESA
        FRMX.ShowDialog()
        mostrar()
        Call BOTONES(True, False, True, True, True)
        TXTCODEMPRESA.ReadOnly = True
    End Sub
    Public Sub mostrar()
        TXTCODEMPRESA.Text = VAR1
        TXTRAZONSOCIAL.Text = VAR2
        TXTRAZONSOCIALABR.Text = VAR3
        TXTRUC.Text = VAR4

    End Sub
    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        TXTCODEMPRESA.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        FLAG = 1
        TXTRAZONSOCIAL.Focus()
        TXTRAZONSOCIAL.SelectAll()
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

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            Dim sql As String
            sql = "nsp_dele_empresa '" & TXTCODEMPRESA.Text & "'"
            PROCESO = TmpInsertDatos(sql)
        Else
            Exit Sub
        End If

        If PROCESO = True Then

            MsgBox("El Registro Fue Eliminado Correctamente", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")

            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & TXTCODEMPRESA.Text & "','DELETE','EMPRESA','" & Format(System.DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & CodUsuario & "'")
        Else
            MsgBox("Error al Eliminar la Empresa Seleccionado esta siendo utilizado ", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            Exit Sub
        End If

        BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
    End Sub

    Private Sub TXTRUC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTRUC.TextChanged
        If IsNumeric(TXTRUC.Text) = False Then
            TXTRUC.Text = Space(0)
        End If
    End Sub

    Private Sub frmempresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)

    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub frmempresa_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        BTNNUEVO.Focus()
    End Sub

    Private Sub TXTCODEMPRESA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTCODEMPRESA.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            TXTRAZONSOCIAL.Focus()
        End If
    End Sub

    Private Sub TXTRAZONSOCIAL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTRAZONSOCIAL.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            TXTRAZONSOCIALABR.Focus()
        End If
    End Sub

    Private Sub TXTRAZONSOCIALABR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTRAZONSOCIALABR.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            TXTRUC.Focus()
        End If
    End Sub

    Private Sub TXTRUC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTRUC.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub


    Private Sub TXTCODEMPRESA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTCODEMPRESA.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub
End Class
