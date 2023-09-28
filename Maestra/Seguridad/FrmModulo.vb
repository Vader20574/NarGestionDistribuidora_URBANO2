Public Class FrmModulo
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDescrip2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnNivel As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmModulo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDescrip2 = New System.Windows.Forms.TextBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BtnNivel = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDescrip2)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(120, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtDescrip2
        '
        Me.TxtDescrip2.Location = New System.Drawing.Point(138, 70)
        Me.TxtDescrip2.MaxLength = 80
        Me.TxtDescrip2.Name = "TxtDescrip2"
        Me.TxtDescrip2.Size = New System.Drawing.Size(372, 20)
        Me.TxtDescrip2.TabIndex = 21
        Me.TxtDescrip2.Text = ""
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(266, 10)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 19
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(138, 40)
        Me.TxtDescripcion.MaxLength = 80
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(372, 20)
        Me.TxtDescripcion.TabIndex = 3
        Me.TxtDescripcion.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descripcion Modulo : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(138, 12)
        Me.TxtCodigo.MaxLength = 20
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(126, 20)
        Me.TxtCodigo.TabIndex = 1
        Me.TxtCodigo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Texto del menu : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnNivel)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 48)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'BtnNivel
        '
        Me.BtnNivel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNivel.ImageIndex = 13
        Me.BtnNivel.ImageList = Me.ImageList1
        Me.BtnNivel.Location = New System.Drawing.Point(366, 18)
        Me.BtnNivel.Name = "BtnNivel"
        Me.BtnNivel.Size = New System.Drawing.Size(75, 22)
        Me.BtnNivel.TabIndex = 12
        Me.BtnNivel.Text = "&Niveles"
        Me.BtnNivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(458, 18)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNCANCELAR.TabIndex = 9
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(546, 18)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNCERRAR.TabIndex = 11
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(186, 18)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNMODIFICAR.TabIndex = 7
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(270, 18)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNELIMINAR.TabIndex = 8
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(8, 18)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(75, 22)
        Me.BTNNUEVO.TabIndex = 5
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(96, 18)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(75, 22)
        Me.BTNGUARDAR.TabIndex = 6
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'FrmModulo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 196)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmModulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Modulo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Function Form "

    Private Sub LimpiarData()
        TxtCodigo.Text = ""
        TxtDescripcion.Text = ""
        TxtDescrip2.Text = ""

    End Sub

    Private Sub HabilitaBotones(ByVal valor As Boolean)
        BTNNUEVO.Enabled = valor
        btnbuscar.Enabled = valor
        BTNMODIFICAR.Enabled = valor
        BTNELIMINAR.Enabled = valor
        BtnNivel.Enabled = valor

        BTNGUARDAR.Enabled = Not valor
        BTNCANCELAR.Enabled = Not valor

    End Sub

#End Region


    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If Trim(TxtCodigo.Text) = "" Then
            MsgBox("FALTA INGRESAR EL CODIGO..", MsgBoxStyle.Exclamation, DesEmpresa)
            Exit Sub
        End If
        If Trim(TxtDescripcion.Text) = "" Then
            MsgBox("FALTA INGRESAR LA DESCRIPCION..", MsgBoxStyle.Exclamation, DesEmpresa)
            Exit Sub
        End If

        If TxtCodigo.Enabled = True Then
            CAyuda.Ejecutar("SP_MODULO_InsProc", codempresa, TxtCodigo.Text.Trim, TxtDescripcion.Text.Trim, TxtDescrip2.Text)
        Else
            CAyuda.Ejecutar("SP_MODULO_UpdProc", codempresa, TxtCodigo.Text.Trim, TxtDescripcion.Text.Trim, TxtDescrip2.Text)
        End If
        MsgBox("SE GUARDO CORRECTAMENTE...", MsgBoxStyle.Information, DesEmpresa)

        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescrip2.Enabled = False
        LimpiarData()
        Call BOTONES(True, False, False, False, True)

    End Sub

    Private Sub TxtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCodigo.TextChanged

    End Sub

    Private Sub TxtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDescripcion.Focus()
        End If
    End Sub

    Private Sub TxtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescripcion.TextChanged

    End Sub

    Private Sub TxtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtDescrip2.Focus()
        End If
    End Sub

    Private Sub TxtDescrip2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescrip2.TextChanged

    End Sub

    Private Sub TxtDescrip2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescrip2.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim FrmBusc As New FrmBusqModulo
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        TxtCodigo.Text = FrmBusc.Dg1.Item(FrmBusc.Dg1.CurrentRowIndex, 0)
        TxtDescripcion.Text = FrmBusc.Dg1.Item(FrmBusc.Dg1.CurrentRowIndex, 1)
        TxtDescrip2.Text = FrmBusc.Dg1.Item(FrmBusc.Dg1.CurrentRowIndex, 2)

        Call BOTONES(True, False, True, True, True)

    End Sub

    Private Sub FrmModulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescrip2.Enabled = False
        LimpiarData()

        Call BOTONES(True, False, False, False, True)
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()

    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click



        LimpiarData()
        TxtCodigo.Enabled = True
        TxtDescripcion.Enabled = True
        TxtDescrip2.Enabled = True
        TxtCodigo.Focus()

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

        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = False
        TxtDescrip2.Enabled = False
        LimpiarData()

        Call BOTONES(True, False, False, False, True)

    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click

        If TxtCodigo.Text.Trim = "" Then
            MsgBox("FALTA EL CODIGO DEL MODULO....", MsgBoxStyle.Exclamation, DesEmpresa)
            Exit Sub
        End If
        Call BOTONES(False, True, False, False, True)
        TxtDescripcion.Enabled = True
        TxtDescrip2.Enabled = True

    End Sub



    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            If TxtCodigo.Text.Trim = "" Then
                MsgBox("FALTA EL CODIGO DEL MODULO....", MsgBoxStyle.Exclamation, DesEmpresa)
                Exit Sub
            End If
            If TmpInsertDatos("DELETE FROM MODULO  WHERE  CODEMPRESA='" & codempresa & "'  AND  CDMODULO='" & TxtCodigo.Text.Trim & "'") = True Then
                If TmpInsertDatos("DELETE FROM ACCESO  WHERE  CODEMPRESA='" & codempresa & "'  AND  CDMODULO='" & TxtCodigo.Text.Trim & "'") = True Then
                    MsgBox("EL REGISTRO SE ELIMINO CORRECTAMENTE...", MsgBoxStyle.Exclamation, DesEmpresa)

                End If
            End If
            LimpiarData()
            botones(True, False, False, False, True)
        End If

    End Sub


    Private Sub BtnNivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNivel.Click
        If TxtCodigo.Text.Trim = "" Then
            MsgBox("FALTA EL CODIGO DEL MODULO....", MsgBoxStyle.Exclamation, DesEmpresa)
            Exit Sub
        End If
        Dim FrmNmod As New FrmNivelModulo
        FrmNmod.CDMODULO = TxtCodigo.Text.Trim
        FrmNmod.LblModulo.Text = TxtDescripcion.Text.Trim
        FrmNmod.ShowDialog()


    End Sub
End Class
