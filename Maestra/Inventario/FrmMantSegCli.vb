Public Class FrmMantSegCli
    Inherits System.Windows.Forms.Form
    Dim flag As Integer

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
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents AXCRT2 As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmZona))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtdes = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.AXCRT2 = New AxCrystal.AxCrystalReport
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.btneliminar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(348, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(96, 216)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(12, 155)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(74, 23)
        Me.btnreporte.TabIndex = 9
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(12, 128)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(74, 23)
        Me.BTNCANCELAR.TabIndex = 8
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(12, 182)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(74, 23)
        Me.BTNCERRAR.TabIndex = 10
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnmodificar
        '
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.ImageIndex = 2
        Me.btnmodificar.ImageList = Me.ImageList1
        Me.btnmodificar.Location = New System.Drawing.Point(12, 74)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(74, 23)
        Me.btnmodificar.TabIndex = 6
        Me.btnmodificar.Text = "&Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btneliminar
        '
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.ImageIndex = 3
        Me.btneliminar.ImageList = Me.ImageList1
        Me.btneliminar.Location = New System.Drawing.Point(12, 101)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(74, 23)
        Me.btneliminar.TabIndex = 7
        Me.btneliminar.Text = "&Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnnuevo
        '
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.ImageIndex = 0
        Me.btnnuevo.ImageList = Me.ImageList1
        Me.btnnuevo.Location = New System.Drawing.Point(12, 20)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(74, 23)
        Me.btnnuevo.TabIndex = 4
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(12, 47)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(74, 23)
        Me.BTNGUARDAR.TabIndex = 5
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.txtdes)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 88)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.ImageIndex = 5
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(204, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(40, 24)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Tag = ""
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdes
        '
        Me.txtdes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdes.Location = New System.Drawing.Point(88, 47)
        Me.txtdes.MaxLength = 15
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(216, 21)
        Me.txtdes.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Descripcion :"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(88, 23)
        Me.txtcodigo.MaxLength = 4
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(112, 21)
        Me.txtcodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo :"
        '
        'AXCRT2
        '
        Me.AXCRT2.Enabled = True
        Me.AXCRT2.Location = New System.Drawing.Point(224, 32)
        Me.AXCRT2.Name = "AXCRT2"
        Me.AXCRT2.OcxState = CType(resources.GetObject("AXCRT2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AXCRT2.Size = New System.Drawing.Size(28, 28)
        Me.AXCRT2.TabIndex = 25
        '
        'FrmZona
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(456, 224)
        Me.Controls.Add(Me.AXCRT2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(464, 256)
        Me.Name = "FrmZona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Segmento de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AXCRT2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)

    End Sub
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        btnnuevo.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        btnmodificar.Enabled = MODIFICAR
        btneliminar.Enabled = ELIMINAR
        btnBuscar.Enabled = BUSCAR
    End Sub
    Public Sub mostrar()
        txtcodigo.Text = VAR1
        txtdes.Text = VAR2
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)
        flag = 0
        txtcodigo.Focus()
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        Dim sql As String
        Dim PROCESO As Boolean
        Call formatotextbox(Me)
        If txtcodigo.Text = "" Or txtdes.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If flag = 0 Then
            If CAyuda.ListarDatos("SP_VAL_SEGMENTO_CLIENTE", txtcodigo.Text.Trim, codempresa).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("El código ya existe.", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If CAyuda.ListarDatos("SP_VAL_DESC_SEGMENTO_CLIENTE", txtdes.Text.Trim, codempresa).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("La Descripcion ya existe.", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            sql = "Nsp_inst_SEGMENTO_CLIENTE '" & txtcodigo.Text & "','" & txtdes.Text & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
        End If

        If flag = 1 Then

            If CAyuda.ListarDatos("SP_VAL_DESC_SEGMENTO_CLIENTE_UP", txtcodigo.Text, txtdes.Text.Trim, codempresa).Tables(0).Rows.Count > 0 Then
                MessageBox.Show("La Descripcion ya existe.", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            sql = "Nsp_upda_SEGMENTO_CLIENTE '" & txtcodigo.Text & "','" & txtdes.Text & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
        End If


        '    If PROCESO = False Then Exit Sub

        If PROCESO = False Then
            Exit Sub
        Else
            MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If


        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
        btnnuevo.Focus()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Call desbloqueatextbox(Me)
        txtcodigo.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        flag = 1
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Dim PROCESO As Boolean
        Dim sql As String
        sql = "Nsp_delete_SEGMENTO_CLIENTE '" & txtcodigo.Text & "','" & txtdes.Text & "','" & codempresa & "'"
        PROCESO = TmpInsertDatos(sql)
        If PROCESO = True Then
            MsgBox("El Registro Fue Eliminado Correctamente" & Chr(13) & "Gracias ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C")
        Else
            MsgBox("Error al Eliminar esta siendo utilizado ", MsgBoxStyle.Critical, "NAR SISTEMAS S.A.C")
            Exit Sub
        End If

        BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim frmx As New FrmBuscaSegClient
        frmx.ShowDialog()
        mostrar()
        Call BOTONES(True, False, True, True, True)
        txtcodigo.ReadOnly = True
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            AXCRT2.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            AXCRT2.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            AXCRT2.ReportFileName = rutareporte + CType("RPTZONAS.rpt", String)
            AXCRT2.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            AXCRT2.set_StoredProcParam(0, codempresa)
            AXCRT2.WindowState = Crystal.WindowStateConstants.crptMaximized
            AXCRT2.Action = 1
            AXCRT2.Reset()

        Catch x As Exception
            MessageBox.Show(x.Message)
            MessageBox.Show("La ruta predeterminada de reportes no se encuentra o ha sido cambiada. Configure el archivo Config.ini para poder mostrar el Reporte", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub FrmZona_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        btnnuevo.Focus()
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
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub txtcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodigo.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnBuscar_Click(sender, e)
        End If

    End Sub

    Private Sub txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txtdes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdes.TextChanged

    End Sub
End Class
