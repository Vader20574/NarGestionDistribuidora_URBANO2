Public Class FrmAlmacen
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
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageLis2 As System.Windows.Forms.ImageList
    Friend WithEvents cboptovta As System.Windows.Forms.ComboBox
    Friend WithEvents ChkTipo As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlmacen))
        Me.ImageLis2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ChkTipo = New System.Windows.Forms.CheckBox
        Me.cboptovta = New System.Windows.Forms.ComboBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdes = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageLis2
        '
        Me.ImageLis2.ImageStream = CType(resources.GetObject("ImageLis2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageLis2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageLis2.Images.SetKeyName(0, "")
        Me.ImageLis2.Images.SetKeyName(1, "")
        Me.ImageLis2.Images.SetKeyName(2, "")
        Me.ImageLis2.Images.SetKeyName(3, "")
        Me.ImageLis2.Images.SetKeyName(4, "")
        Me.ImageLis2.Images.SetKeyName(5, "")
        Me.ImageLis2.Images.SetKeyName(6, "")
        Me.ImageLis2.Images.SetKeyName(7, "")
        Me.ImageLis2.Images.SetKeyName(8, "")
        Me.ImageLis2.Images.SetKeyName(9, "")
        Me.ImageLis2.Images.SetKeyName(10, "")
        Me.ImageLis2.Images.SetKeyName(11, "")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(409, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 178)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageLis2
        Me.BTNCANCELAR.Location = New System.Drawing.Point(16, 123)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNCANCELAR.TabIndex = 11
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageLis2
        Me.BTNCERRAR.Location = New System.Drawing.Point(16, 150)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNCERRAR.TabIndex = 13
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageLis2
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(16, 69)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNMODIFICAR.TabIndex = 9
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageLis2
        Me.BTNELIMINAR.Location = New System.Drawing.Point(16, 96)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNELIMINAR.TabIndex = 10
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageLis2
        Me.BTNNUEVO.Location = New System.Drawing.Point(16, 15)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(79, 23)
        Me.BTNNUEVO.TabIndex = 7
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageLis2
        Me.BTNGUARDAR.Location = New System.Drawing.Point(16, 42)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNGUARDAR.TabIndex = 8
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkTipo)
        Me.GroupBox3.Controls.Add(Me.cboptovta)
        Me.GroupBox3.Controls.Add(Me.btnbuscar)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtdes)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtcodigo)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(392, 136)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        '
        'ChkTipo
        '
        Me.ChkTipo.Location = New System.Drawing.Point(82, 108)
        Me.ChkTipo.Name = "ChkTipo"
        Me.ChkTipo.Size = New System.Drawing.Size(96, 16)
        Me.ChkTipo.TabIndex = 39
        Me.ChkTipo.Text = "&Tienda Venta"
        '
        'cboptovta
        '
        Me.cboptovta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboptovta.Location = New System.Drawing.Point(112, 72)
        Me.cboptovta.Name = "cboptovta"
        Me.cboptovta.Size = New System.Drawing.Size(263, 21)
        Me.cboptovta.TabIndex = 4
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageLis2
        Me.btnbuscar.Location = New System.Drawing.Point(240, 23)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(32, 23)
        Me.btnbuscar.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Punto de Venta :"
        '
        'txtdes
        '
        Me.txtdes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdes.Location = New System.Drawing.Point(113, 48)
        Me.txtdes.MaxLength = 60
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(261, 21)
        Me.txtdes.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Descripcion :"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(113, 24)
        Me.txtcodigo.MaxLength = 20
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(128, 21)
        Me.txtcodigo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Codigo :"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(188, 108)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(90, 16)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Ajuste stock"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(287, 106)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(76, 20)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "Activo"
        '
        'FrmAlmacen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(515, 187)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(542, 234)
        Me.MinimizeBox = False
        Me.Name = "FrmAlmacen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Almacen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim flag As Integer
    Dim Accion As String

    Private Sub FrmAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CAyuda.CargarDataCombo(cboptovta, "select nroptovta,desptovta from tiendaptovta", "nroptovta", "desptovta")
        Call Bloqueatextbox(Me)
        Me.CheckBox1.Enabled = False
        Me.CheckBox2.Enabled = False
        Me.ChkTipo.Enabled = False
        Call BOTONES(True, False, False, False, True)
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Me.CheckBox1.Enabled = False
        Me.CheckBox2.Enabled = False
        Call Limpiatextbox(Me)
        BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
    End Sub

 
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim SQL As String
        Call formatotextbox(Me)

        If txtcodigo.Text = "" Or txtdes.Text = "" Or cboptovta.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Accion = "Grabar" Then
            If CAyuda.ListarDatos("SP_VAL_COD_ALMACEN", codempresa, txtcodigo.Text.Trim).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("El codigo ya existe.", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If CAyuda.ListarDatos("SP_VAL_DESC_ALMACEN", codempresa, txtdes.Text.Trim, cboptovta.SelectedValue).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("La descripcion del almacen de este Punto de Venta ya existe.", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            SQL = "Nsp_inst_Almacen '" & txtcodigo.Text & "','" & txtdes.Text & "'," & IIf(Me.CheckBox1.Checked = True, 1, 0) & ",'" & cboptovta.SelectedValue.ToString & "'," & IIf(Me.CheckBox2.Checked = True, 1, 0) & ",'" & codempresa & "','" & CodUsuario & "'," & IIf(Me.ChkTipo.Checked = True, 1, 0) & ""
            If TmpInsertDatos(SQL) = True Then
                MsgBox("El Registro Fue Grabado Correctamente" & Chr(13) & "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                Call Limpiatextbox(Me)
                Call Bloqueatextbox(Me)
                Me.CheckBox1.Enabled = False
                Me.CheckBox2.Enabled = False
                Me.ChkTipo.Enabled = False
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = False
                Me.ChkTipo.Checked = False

                Call BOTONES(True, False, False, False, True)
            Else
                MsgBox("Error al Crear al Almacen, Consulte a su" & Chr(13) & "Proveedor", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            End If

        ElseIf Accion = "Modificar" Then

            If CAyuda.ListarDatos("SP_VAL_DESC_ALMACEN_UP", txtcodigo.Text, codempresa, txtdes.Text.Trim, cboptovta.SelectedValue).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("La descripcion del almacen de este Punto de Venta ya existe.", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


            SQL = "Nsp_upda_Almacen '" & txtcodigo.Text & "','" & txtdes.Text & "'," & IIf(Me.CheckBox1.Checked = True, 1, 0) & ",'" & cboptovta.SelectedValue.ToString & "'," & IIf(Me.CheckBox2.Checked = True, 1, 0) & ",'" & codempresa & "','" & CodUsuario & "'," & IIf(Me.ChkTipo.Checked = True, "1", "0").ToString.Trim
            If TmpInsertDatos(SQL) = True Then
                MsgBox("El Registro Fue Modificado Correctamente" & Chr(13) & "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                Call Limpiatextbox(Me)
                Call Bloqueatextbox(Me)
                Me.CheckBox1.Enabled = False
                Me.CheckBox2.Enabled = False
                Me.ChkTipo.Enabled = False
                Me.CheckBox1.Checked = False
                Me.CheckBox2.Checked = False
                Me.ChkTipo.Checked = False
                Call BOTONES(True, False, False, False, True)
            Else
                MsgBox("Error al Modificar al Almacen, Consulte a su" & Chr(13) & "Proveedor", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            End If
        End If

    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Accion = "Grabar"
        Me.CheckBox1.Enabled = True
        Me.CheckBox2.Enabled = True
        Me.ChkTipo.Enabled = True

        Me.CheckBox1.Checked = False
        Me.CheckBox2.Checked = False
        Me.ChkTipo.Checked = False



        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)

        txtcodigo.Focus()
    End Sub
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR
    End Sub
    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Accion = "Modificar"
        Me.CheckBox1.Enabled = True
        Me.CheckBox2.Enabled = True
        Me.ChkTipo.Enabled = True
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, True)
        txtcodigo.ReadOnly = True
    End Sub
    Public Sub mostrar()
        txtcodigo.Text = VAR1
        txtdes.Text = VAR2
        If VAR3 = "True" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        cboptovta.Text = VAR4
        If VAR5 = "True" Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If

        If VARTIPO Then
            ChkTipo.Checked = True
        Else
            ChkTipo.Checked = False
        End If
    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim SQL As String

        Try
            If Len(Me.txtcodigo.Text.Trim) = 0 Then
                MsgBox("No Selecciono Ningun Registro Para Eliminar" & Chr(13) & "Intente de Nuevo Por Favor", MsgBoxStyle.Exclamation, "")
                Exit Sub
            End If

            If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
                SQL = "Nsp_delete_Almacen '" & txtcodigo.Text & "','" & CodUsuario & "','" & codempresa & "'"
                If TmpInsertDatos(SQL) = True Then
                    MsgBox("El Registro Fue Eliminado Correctamente" & Chr(13) & "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
                    Call Limpiatextbox(Me)
                    Call Bloqueatextbox(Me)
                    Me.CheckBox1.Checked = False
                    Me.CheckBox2.Checked = False
                    Me.ChkTipo.Enabled = False
                Else
                    MsgBox("Error al Eliminar el almacen Seleccionado esta siendo utilizado por los articulos ", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
                End If
            End If

            BOTONES(True, False, False, False, True)


        Catch ex As Exception
            MsgBox(ex.Message & Chr(13) & "Consulte a su Proveedor", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
        End Try
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub



    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Me.CheckBox1.Enabled = False
        Me.CheckBox2.Enabled = False
        Me.ChkTipo.Enabled = False

        Dim frmx As New FrmBuscaAlmacen
        frmx.ShowDialog()
        mostrar()
        Call BOTONES(True, False, True, True, True)
        txtcodigo.ReadOnly = True
        VAR1 = ""
        VAR2 = ""
        VAR3 = ""
        VAR4 = ""
        VAR5 = ""
        VAR6 = ""
        'Variables.VARTIPO = ""
    End Sub
    Private Sub FrmAlmacen_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        BTNNUEVO.Focus()
    End Sub
    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdes.Focus()
        End If
    End Sub
    Private Sub txtdes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdes.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cboptovta.Focus()
        End If

    End Sub
    Private Sub txtterminal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub
    Private Sub txtcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodigo.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub cboptovta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboptovta.SelectedIndexChanged

    End Sub
End Class
