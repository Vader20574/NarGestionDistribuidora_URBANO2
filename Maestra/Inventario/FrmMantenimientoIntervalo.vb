Public Class FrmMantenimientoIntervalo
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
    Friend WithEvents GrDatos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnbus As System.Windows.Forms.Button
    Friend WithEvents TxtDecrip As System.Windows.Forms.TextBox
    Friend WithEvents TxtCantInic As System.Windows.Forms.TextBox
    Friend WithEvents TxtCantFin As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMantenimientoIntervalo))
        Me.GrDatos = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnbus = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtDecrip = New System.Windows.Forms.TextBox
        Me.TxtCantInic = New System.Windows.Forms.TextBox
        Me.TxtCantFin = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GrDatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrDatos
        '
        Me.GrDatos.Controls.Add(Me.PictureBox1)
        Me.GrDatos.Controls.Add(Me.Label12)
        Me.GrDatos.Controls.Add(Me.btnbus)
        Me.GrDatos.Controls.Add(Me.TxtCodigo)
        Me.GrDatos.Controls.Add(Me.Label1)
        Me.GrDatos.Controls.Add(Me.Label2)
        Me.GrDatos.Controls.Add(Me.Label3)
        Me.GrDatos.Controls.Add(Me.Label4)
        Me.GrDatos.Controls.Add(Me.TxtDecrip)
        Me.GrDatos.Controls.Add(Me.TxtCantInic)
        Me.GrDatos.Controls.Add(Me.TxtCantFin)
        Me.GrDatos.Location = New System.Drawing.Point(10, 14)
        Me.GrDatos.Name = "GrDatos"
        Me.GrDatos.Size = New System.Drawing.Size(474, 206)
        Me.GrDatos.TabIndex = 0
        Me.GrDatos.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(362, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 24)
        Me.Label12.TabIndex = 109
        Me.Label12.Text = "[F2]  Buscar"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnbus
        '
        Me.btnbus.ImageIndex = 5
        Me.btnbus.ImageList = Me.ImageList1
        Me.btnbus.Location = New System.Drawing.Point(326, 28)
        Me.btnbus.Name = "btnbus"
        Me.btnbus.Size = New System.Drawing.Size(32, 26)
        Me.btnbus.TabIndex = 108
        Me.btnbus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(214, 30)
        Me.TxtCodigo.MaxLength = 3
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.TabIndex = 1
        Me.TxtCodigo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descripcion : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cant Inicial : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(138, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cant Final : "
        '
        'TxtDecrip
        '
        Me.TxtDecrip.Location = New System.Drawing.Point(214, 54)
        Me.TxtDecrip.MaxLength = 50
        Me.TxtDecrip.Name = "TxtDecrip"
        Me.TxtDecrip.Size = New System.Drawing.Size(248, 20)
        Me.TxtDecrip.TabIndex = 1
        Me.TxtDecrip.Text = ""
        '
        'TxtCantInic
        '
        Me.TxtCantInic.Location = New System.Drawing.Point(214, 78)
        Me.TxtCantInic.MaxLength = 15
        Me.TxtCantInic.Name = "TxtCantInic"
        Me.TxtCantInic.Size = New System.Drawing.Size(76, 20)
        Me.TxtCantInic.TabIndex = 1
        Me.TxtCantInic.Text = ""
        '
        'TxtCantFin
        '
        Me.TxtCantFin.Location = New System.Drawing.Point(214, 102)
        Me.TxtCantFin.MaxLength = 15
        Me.TxtCantFin.Name = "TxtCantFin"
        Me.TxtCantFin.Size = New System.Drawing.Size(76, 20)
        Me.TxtCantFin.TabIndex = 1
        Me.TxtCantFin.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(494, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(110, 230)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(14, 156)
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
        Me.BTNCERRAR.Location = New System.Drawing.Point(14, 192)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(84, 30)
        Me.BTNCERRAR.TabIndex = 500
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "  &Salir"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(14, 86)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(84, 30)
        Me.BTNMODIFICAR.TabIndex = 802
        Me.BTNMODIFICAR.TabStop = False
        Me.BTNMODIFICAR.Text = "    &Modificar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(14, 120)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(84, 30)
        Me.BTNELIMINAR.TabIndex = 27
        Me.BTNELIMINAR.TabStop = False
        Me.BTNELIMINAR.Text = "   &Eliminar"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(14, 18)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(84, 30)
        Me.BTNNUEVO.TabIndex = 800
        Me.BTNNUEVO.TabStop = False
        Me.BTNNUEVO.Text = "  &Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(14, 52)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(84, 30)
        Me.BTNGUARDAR.TabIndex = 801
        Me.BTNGUARDAR.TabStop = False
        Me.BTNGUARDAR.Text = "    &Guardar"
        '
        'FrmMantenimientoIntervalo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 252)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrDatos)
        Me.Name = "FrmMantenimientoIntervalo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de  Intervalo"
        Me.GrDatos.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private NUEVO As Integer



#Region "Funciones"
    Sub Limpiar()
        Dim o As Object
        For Each o In Me.GrDatos.Controls
            If TypeOf o Is TextBox Then
                o.text = ""
            End If
        Next
    End Sub

    Sub BLOQUEO_INTERVALO(ByVal estado As Boolean)
        Dim o As Object
        For Each o In Me.GrDatos.Controls
            If TypeOf o Is TextBox Then
                o.enabled = estado
            End If
        Next
        btnbus.Enabled = Not estado
    End Sub

    Sub BOTONES(ByVal estado As Boolean)
        BTNNUEVO.Enabled = estado
        BTNGUARDAR.Enabled = Not estado
        BTNMODIFICAR.Enabled = estado
        BTNELIMINAR.Enabled = estado
    End Sub

#End Region


    Private Sub FrmMantenimientoIntervalo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BLOQUEO_INTERVALO(False)
        Limpiar()
        Call BOTONES(True, False, False, False, True)
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbus.Enabled = BUSCAR
    End Sub



    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        BLOQUEO_INTERVALO(True)
        Limpiar()
        Call BOTONES(False, True, False, False, False)
        TxtCodigo.Focus()
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()

    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        BLOQUEO_INTERVALO(False)
        Limpiar()
        NUEVO = 0
        Call BOTONES(True, False, False, False, True)

    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        BLOQUEO_INTERVALO(True)
        Call BOTONES(False, True, False, False, True)
        TxtCodigo.Enabled = False
        NUEVO = 1
        TxtDecrip.Focus()

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim PROCESO As Boolean
        If NUEVO = 0 Then

            Dim TABLE_INTER As New DataTable
            TABLE_INTER = CAyuda.ListarDatos("NSP_BUSQUED_INTERVALO", codempresa.Trim, TxtCodigo.Text.Trim).Tables(0)
            If TABLE_INTER.Rows.Count > 0 Then
                MsgBox("El codigo ya existe ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            Dim TABLE_INTER1 As New DataTable
            TABLE_INTER1 = CAyuda.ListarDatos("NSP_BUSQUED_DESCRIPCION_INTERVALO", codempresa.Trim, TxtDecrip.Text.Trim).Tables(0)
            If TABLE_INTER1.Rows.Count > 0 Then
                MsgBox("El descripcion ya existe ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If


            PROCESO = TmpInsertDatos("NSP_INSERTAR_INTERVALO   '" & codempresa.Trim & "','" & TxtCodigo.Text.Trim & "','" & TxtDecrip.Text.Trim & "','" & TxtCantInic.Text.Trim & "','" & TxtCantFin.Text.Trim & "'  ")
        ElseIf NUEVO = 1 Then
            PROCESO = TmpInsertDatos("NSP_UPDATE_INTERVALO  '" & codempresa.Trim & "','" & TxtCodigo.Text.Trim & "','" & TxtDecrip.Text.Trim & "','" & TxtCantInic.Text.Trim & "','" & TxtCantFin.Text.Trim & "'  ")
        End If
        If PROCESO = True Then
            BLOQUEO_INTERVALO(False)
            Call BOTONES(True, False, False, False, True)
            Limpiar()
            NUEVO = 0
            MsgBox("Se Guardo correctamente..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If TxtCodigo.Text.Trim = "" Then
            MsgBox("Debe indicar el intervalo que va eliminar..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            Exit Sub
        End If
        If MsgBox("¿Esta seguro de eliminar el registro?", MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C.") = MsgBoxResult.Yes Then
            If TmpInsertDatos("NSP_DELETE_INTERVALO  '" & codempresa.Trim & "','" & TxtCodigo.Text.Trim & "' ") Then
                MsgBox("Se elimino el registro correctamente..", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
                BLOQUEO_INTERVALO(False)
                BOTONES(True, False, False, False, True)
                Limpiar()
                NUEVO = 0
            End If
        End If
    End Sub

    Private Sub TxtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo.TextChanged

    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDecrip.Focus()
        End If
    End Sub

    Private Sub TxtDecrip_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDecrip.TextChanged

    End Sub

    Private Sub TxtDecrip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDecrip.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCantInic.Focus()
        End If
    End Sub

    Private Sub TxtCantInic_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantInic.TextChanged

    End Sub

    Private Sub TxtCantInic_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCantInic.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCantFin.Focus()
        End If
    End Sub

    Private Sub btnbus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbus.Click
        Limpiar()
        Dim o As New FrmBusqIntervalo
        o.ShowDialog()
        If o.DEVOLVERDATOS = True Then
            TxtCodigo.Text = o.DgIntervalo.Item(o.DgIntervalo.CurrentRowIndex, 0)
            TxtDecrip.Text = o.DgIntervalo.Item(o.DgIntervalo.CurrentRowIndex, 1)
            TxtCantInic.Text = o.DgIntervalo.Item(o.DgIntervalo.CurrentRowIndex, 2)
            TxtCantFin.Text = o.DgIntervalo.Item(o.DgIntervalo.CurrentRowIndex, 3)
            Call BOTONES(True, False, True, True, True)
            BLOQUEO_INTERVALO(False)
        End If
    End Sub

    Private Sub TxtCantFin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCantFin.TextChanged

    End Sub

    Private Sub TxtCantFin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantFin.KeyPress
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

    Private Sub TxtCantInic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantInic.KeyPress

        Call GBloqueaCaracter(Asc(e.KeyChar))
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True

        End If


    End Sub
End Class
