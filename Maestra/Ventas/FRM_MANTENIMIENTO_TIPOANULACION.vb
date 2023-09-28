Public Class FRM_MANTENIMIENTO_TIPOANULACION
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents ckactivo As System.Windows.Forms.CheckBox
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MANTENIMIENTO_TIPOANULACION))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.ckactivo = New System.Windows.Forms.CheckBox
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
        Me.GroupBox1.Controls.Add(Me.ckactivo)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 122)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(97, 48)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(293, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Descripción :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(97, 23)
        Me.txtCodigo.MaxLength = 3
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 25)
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
        Me.btnbuscar.Location = New System.Drawing.Point(200, 22)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 110)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(308, 26)
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
        Me.BTNCANCELAR.Location = New System.Drawing.Point(182, 64)
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
        Me.BTNCERRAR.Location = New System.Drawing.Point(266, 64)
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
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(226, 26)
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
        Me.BTNELIMINAR.Location = New System.Drawing.Point(98, 64)
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
        Me.BTNNUEVO.Location = New System.Drawing.Point(62, 26)
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
        Me.BTNGUARDAR.Location = New System.Drawing.Point(146, 26)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(78, 34)
        Me.BTNGUARDAR.TabIndex = 808
        Me.BTNGUARDAR.TabStop = False
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckactivo
        '
        Me.ckactivo.AutoSize = True
        Me.ckactivo.Location = New System.Drawing.Point(97, 74)
        Me.ckactivo.Name = "ckactivo"
        Me.ckactivo.Size = New System.Drawing.Size(56, 17)
        Me.ckactivo.TabIndex = 19
        Me.ckactivo.Text = "Activo"
        Me.ckactivo.UseVisualStyleBackColor = True
        '
        'FRM_MANTENIMIENTO_TIPOANULACION
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(475, 262)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRM_MANTENIMIENTO_TIPOANULACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Tipo Anulacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Fields"
    Private INTFLAG_ZV As Integer
    'Private Obj As New ClsInterface

    Dim estado As Integer
#End Region



    Private Sub FRM_MANTENIMIENTO_TIPOANULACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        'Call cargadatos()
        BTNCANCELAR.Enabled = False
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
        INTFLAG_ZV = 0
        txtCodigo.Focus()
        BTNCANCELAR.Enabled = True
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call BOTONES(True, False, True, True, True)
        Call Bloqueatextbox(Me)

        Dim FRMX As New Frm_Grid_TipoAnulacion
        FRMX.vie = Me
        FRMX.ShowDialog()

        txtCodigo.ReadOnly = True
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim sql As String
        Call formatotextbox(Me)

        If Not VerificarDatos() Then
            Exit Sub
        End If

        If INTFLAG_ZV = 0 Then
            sql = "NSP_INSERTAR_TIPOANULACION '" & codempresa & "','" & txtCodigo.Text & "','" & txtDescripcion.Text & "'," & estado

            If TmpInsertDatos(sql) = True Then
                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)
                Bloqueatextbox(Me)
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

            End If

        End If

        If INTFLAG_ZV = 1 Then
            sql = "NSP_UPDATE_TIPOANULACION '" & codempresa & "','" & txtCodigo.Text & "','" & txtDescripcion.Text & "'," & estado

            If TmpInsertDatos(sql) = True Then
                Call BOTONES(True, False, False, False, True)
                Limpiatextbox(Me)
                Bloqueatextbox(Me)
                MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")

            End If
        End If

        BTNCANCELAR.Enabled = False


    End Sub

    Public Function VerificarDatos() As Boolean
        Dim Obs1 As String = String.Empty, obs2 As String = String.Empty
        If INTFLAG_ZV = 0 Then
            If Me.txtCodigo.Text.Trim.Length = 0 Then
                Obs1 = vbCrLf + "-   Ingrese el código."
            Else
                Dim TablaConsulta As New DataTable
                TablaConsulta = CAyuda.ListarDatos("NSP_CONSUL_TIPOANULACION", codempresa, Me.txtCodigo.Text.Trim).Tables(0)
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
        Call BOTONES(False, True, False, False, True)
        INTFLAG_ZV = 1
        txtDescripcion.Focus()
        txtDescripcion.SelectAll()
        BTNCANCELAR.Enabled = True
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub

        If INTFLAG_ZV = 0 Then
            Call Limpiatextbox(Me)
            Call BOTONES(True, False, False, False, True)
        Else
            Call BOTONES(True, False, False, False, True)
        End If
        Call Bloqueatextbox(Me)
        BTNCANCELAR.Enabled = False
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el Registro ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_TIPOANULACION", codempresa, txtCodigo.Text.Trim)
            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)
            Call Limpiatextbox(Me)
        End If
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
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
            BTNGUARDAR.Focus()
        End If

    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click

    End Sub

    Private Sub ckactivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckactivo.CheckedChanged

        If ckactivo.Checked = True Then
            estado = 1
        Else
            estado = 0
        End If

    End Sub
End Class
