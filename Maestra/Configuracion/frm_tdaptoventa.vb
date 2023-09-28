Public Class frm_tdaptoventa
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents tdireccion As System.Windows.Forms.TextBox
    Friend WithEvents tdesc As System.Windows.Forms.TextBox
    Friend WithEvents tdistritop As System.Windows.Forms.ComboBox
    Friend WithEvents tprovinciap As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tdaptoventa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tdistritop = New System.Windows.Forms.ComboBox
        Me.tprovinciap = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tdireccion = New System.Windows.Forms.TextBox
        Me.tdesc = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tdistritop)
        Me.GroupBox1.Controls.Add(Me.tprovinciap)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tdireccion)
        Me.GroupBox1.Controls.Add(Me.tdesc)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 152)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'tdistritop
        '
        Me.tdistritop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tdistritop.Location = New System.Drawing.Point(122, 115)
        Me.tdistritop.Name = "tdistritop"
        Me.tdistritop.Size = New System.Drawing.Size(251, 21)
        Me.tdistritop.TabIndex = 50
        '
        'tprovinciap
        '
        Me.tprovinciap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tprovinciap.Location = New System.Drawing.Point(122, 91)
        Me.tprovinciap.Name = "tprovinciap"
        Me.tprovinciap.Size = New System.Drawing.Size(249, 21)
        Me.tprovinciap.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Distrito :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Cuidad :"
        '
        'tdireccion
        '
        Me.tdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdireccion.Location = New System.Drawing.Point(122, 67)
        Me.tdireccion.MaxLength = 50
        Me.tdireccion.Name = "tdireccion"
        Me.tdireccion.Size = New System.Drawing.Size(372, 21)
        Me.tdireccion.TabIndex = 44
        '
        'tdesc
        '
        Me.tdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tdesc.Location = New System.Drawing.Point(122, 43)
        Me.tdesc.MaxLength = 30
        Me.tdesc.Name = "tdesc"
        Me.tdesc.Size = New System.Drawing.Size(372, 21)
        Me.tdesc.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Descripción :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dirección :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcodigo
        '
        Me.tcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodigo.Location = New System.Drawing.Point(122, 19)
        Me.tcodigo.MaxLength = 6
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.Size = New System.Drawing.Size(100, 21)
        Me.tcodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro Pto Venta :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(233, 18)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 18
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox2.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox2.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox2.Location = New System.Drawing.Point(536, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(107, 188)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(13, 179)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 23)
        Me.btnreporte.TabIndex = 14
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(13, 127)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCANCELAR.TabIndex = 13
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(13, 153)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCERRAR.TabIndex = 15
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(13, 73)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNMODIFICAR.TabIndex = 11
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(13, 100)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNELIMINAR.TabIndex = 12
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(13, 19)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(82, 23)
        Me.BTNNUEVO.TabIndex = 9
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(13, 46)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNGUARDAR.TabIndex = 10
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_tdaptoventa
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(656, 207)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(686, 320)
        Me.Name = "frm_tdaptoventa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tiendas por Punto de Venta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim INTFLAGTDAPTOVTA As Integer
    Dim BOL As Boolean

    Private Sub frm_clie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False)
        CAyuda.CargarDataCombo(tprovinciap, "NSP_SELECT_LISTA_PROVINCIA '" & codempresa & "'", "CODCIUDAD", "DESCIUDAD")
        CAyuda.CargarDataCombo(tdistritop, "NSP_SELECT_LISTA_DISTRITO '" & tprovinciap.SelectedValue().ToString & "','" & codempresa & "'", "coddis", "DESCRIPCION")
        BTNCANCELAR.Enabled = False
    End Sub


    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub

        If INTFLAGTDAPTOVTA = 0 Then
            Call Limpiatextbox(Me)
            Call BOTONES(True, False, False, False)
        Else
            Call BOTONES(True, False, True, True)
        End If

        BTNCANCELAR.Enabled = False
        Call Bloqueatextbox(Me)
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
    End Sub


    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        Dim PROCESO As Boolean
        Dim sql As String
        sql = "nsp_dele_tiendaptoventa '" & tcodigo.Text & "','" & Fecha_Actual() & "','" & CodUsuario & "','" & codempresa & "'"
        PROCESO = TmpInsertDatos(sql)
        If PROCESO = False Then Exit Sub
        BOTONES(True, False, True, False)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        tcodigo.ReadOnly = True
        Call BOTONES(False, True, False, False)
        INTFLAGTDAPTOVTA = 1
        tdesc.Focus()
        tdesc.SelectAll()
        BTNCANCELAR.Enabled = True
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False)
        INTFLAGTDAPTOVTA = 0
        tcodigo.Focus()
        BTNCANCELAR.Enabled = True
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim sql As String

        Call formatotextbox(Me)

        If tcodigo.Text = "" Or tdesc.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If INTFLAGTDAPTOVTA = 0 Then
            sql = "NSP_ins_TDAPTOVTA '" & tcodigo.Text & "','" & tdesc.Text & "','" & tdireccion.Text & "','" & codempresa & "'," & "0" & ",'" & Fecha_Actual() & "','" & CodUsuario & "','" & "0" & "','" & Me.tprovinciap.SelectedValue.ToString() & "','" & Me.tdistritop.SelectedValue.ToString() & "','" & "0" & "','" & "0" & "'"
            If TmpInsertDatos(sql) = True Then
                Call BOTONES(True, False, False, False)
                Limpiatextbox(Me)
                Bloqueatextbox(Me)
            End If
        End If

        If INTFLAGTDAPTOVTA = 1 Then
            sql = "NSP_upd_TDAPTOVTA '" & tcodigo.Text & "','" & tdesc.Text & "','" & tdireccion.Text & "','" & codempresa & "'," & "0" & ",'" & Fecha_Actual() & "','" & CodUsuario & "','" & "0" & "','" & Me.tprovinciap.SelectedValue.ToString() & "','" & Me.tdistritop.SelectedValue.ToString() & "','" & "0" & "','" & "0" & "'"
            If TmpInsertDatos(sql) = True Then
                Call BOTONES(True, False, True, True)
                Bloqueatextbox(Me)
            End If
        End If

        BTNCANCELAR.Enabled = False
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim FRMX As New frm_gridtptovta
        FRMX.ShowDialog()
        If FRMX.boubicptovta = True Then
            Dim dt As New DataTable
            dt = TmpListarDatos("select nroptovta,desptovta,dirptovta,CODCIUDAD,CodDis from tiendaptovta where codempresa='" & codempresa & "' and estado=0 and nroptovta='" & FRMX.grid1.Item(0, FRMX.grid1.CurrentRow.Index).Value.ToString() & "'")
            If dt.Rows.Count > 0 Then
                tcodigo.Text = CAyuda.ValidaNulls(dt.Rows(0)(0))
                tdesc.Text = CAyuda.ValidaNulls(dt.Rows(0)(1))
                tdireccion.Text = CAyuda.ValidaNulls(dt.Rows(0)(2))
                tprovinciap.SelectedValue = CAyuda.ValidaNulls(dt.Rows(0)(3))
                tdistritop.SelectedValue = CAyuda.ValidaNulls(dt.Rows(0)(4))
                Call BOTONES(True, False, True, True)
                Bloqueatextbox(Me)
                tcodigo.ReadOnly = True
            End If
        End If
   
    End Sub

    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdesc.Focus()
            Me.tdesc.SelectAll()
        End If
    End Sub

    Private Sub tdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdesc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdireccion.Focus()
            Me.tdireccion.SelectAll()
        End If
    End Sub

    Private Sub tdireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tprovinciap.Focus()
            Me.tprovinciap.SelectAll()
        End If
    End Sub

    Private Sub tprovinciap_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tprovinciap.SelectedIndexChanged
        CAyuda.CargarDataCombo(tdistritop, "NSP_SELECT_LISTA_DISTRITO '" & tprovinciap.SelectedValue.ToString() & "','" & codempresa & "'", "coddis", "DESCRIPCION")
        Try
            If tprovinciap.SelectedValue <> "System.Data.DataRowView" Then
                CAyuda.CargarDataCombo(tdistritop, "NSP_SELECT_LISTA_DISTRITO '" & tprovinciap.SelectedValue.ToString() & "','" & codempresa & "'", "coddis", "DESCRIPCION")
            End If
        Catch
        End Try
    End Sub

    Private Sub tprovinciap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tprovinciap.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tdistritop.Focus()
            Me.tdistritop.SelectAll()
        End If
    End Sub

    Private Sub tdistritop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdistritop.KeyPress
        If Asc(e.KeyChar) = 13 Then

        End If
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click

    End Sub
End Class

