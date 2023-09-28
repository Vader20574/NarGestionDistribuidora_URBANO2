Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class Linea
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
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents BTNREPORTE As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbotipoprod As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtCorrelat As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Linea))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtCorrelat = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbotipoprod = New System.Windows.Forms.ComboBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.BTNREPORTE = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox2.Controls.Add(Me.TxtCorrelat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbotipoprod)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.txtcod)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 131)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'TxtCorrelat
        '
        Me.TxtCorrelat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCorrelat.BackColor = System.Drawing.Color.White
        Me.TxtCorrelat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCorrelat.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorrelat.Location = New System.Drawing.Point(98, 75)
        Me.TxtCorrelat.MaxLength = 4
        Me.TxtCorrelat.Name = "TxtCorrelat"
        Me.TxtCorrelat.Size = New System.Drawing.Size(90, 21)
        Me.TxtCorrelat.TabIndex = 22
        Me.TxtCorrelat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Correlativo  : "
        '
        'cbotipoprod
        '
        Me.cbotipoprod.Location = New System.Drawing.Point(194, 80)
        Me.cbotipoprod.Name = "cbotipoprod"
        Me.cbotipoprod.Size = New System.Drawing.Size(121, 21)
        Me.cbotipoprod.TabIndex = 19
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(96, 48)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(217, 21)
        Me.txtdescripcion.TabIndex = 18
        '
        'btnbuscar
        '
        Me.btnbuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(176, 22)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 17
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcod
        '
        Me.txtcod.BackColor = System.Drawing.Color.White
        Me.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcod.Location = New System.Drawing.Point(96, 22)
        Me.txtcod.MaxLength = 4
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(72, 21)
        Me.txtcod.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Categoria : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tipo de Producto :"
        Me.Label4.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 188)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(14, 123)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNCANCELAR.TabIndex = 5
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(14, 150)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNCERRAR.TabIndex = 4
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(14, 69)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNMODIFICAR.TabIndex = 3
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(14, 96)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(14, 15)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(75, 23)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(14, 42)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(75, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNREPORTE.ImageIndex = 6
        Me.BTNREPORTE.ImageList = Me.ImageList1
        Me.BTNREPORTE.Location = New System.Drawing.Point(248, 112)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(75, 23)
        Me.BTNREPORTE.TabIndex = 11
        Me.BTNREPORTE.Text = "&Cancelar"
        Me.BTNREPORTE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Linea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(480, 212)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNREPORTE)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(486, 240)
        Me.Name = "Linea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantemiento de Categoria"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Public objbus As New ClsInterface
    Private ValidaDatos As Boolean
    Dim valor As Integer
    Dim Resp As Integer
    Dim agregar As Boolean
    Dim tblImp As New DataTable
    Private Sub Linea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValidaDatos = False
        Bloqueatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        txtcod.Enabled = False
        txtdescripcion.Enabled = False
        TxtCorrelat.Enabled = False
        TxtCorrelat.Text = "0"
        valor = 0
        agregar = True
        BTNNUEVO.Focus()
        CAyuda.CargarDataCombo(Me.cbotipoprod, "nsp_sele_tipoprod", "Codigo", "Descripcion")
    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        desbloqueatextos(Me)
        Call BOTONES(False, True, False, False, False)
        txtcod.Enabled = True
        txtdescripcion.Enabled = True
        TxtCorrelat.Enabled = True
        cbotipoprod.Enabled = True
        txtcod.Focus()
        LimpiarFormularios(Me)
        agregar = True
    End Sub
    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Call BOTONES(True, False, False, False, True)
        LimpiarFormularios(Me)
        txtcod.Enabled = False
        txtdescripcion.Enabled = False
        cbotipoprod.Enabled = False
    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR

    End Sub

    Sub valida_datos()

        If txtcod.Text = "" Then
            ValidaDatos = True
        End If

        If txtdescripcion.Text.Trim = "" Then
            ValidaDatos = True
        End If

        If CDbl(IIf(TxtCorrelat.Text.Trim = "", 0, TxtCorrelat.Text)) < 0 Then
            ValidaDatos = True
        End If

    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim Var_Renzo As Integer
        valida_datos()
        If ValidaDatos Then
            MsgBox("FALTA INGRESAR ALGUNOS VALORES", MsgBoxStyle.Information, "AVISO")
            ValidaDatos = False
            Exit Sub
        End If
        REM Verificando si existe el Codigo de Linea
        valor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoLinea", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
        REM Verificando si existe la descripcion de Linea
        Var_Renzo = CAyuda.ListarDatos("NSP_SELECT_VERIFICAR_DESCRIPCION_LINEA", Me.txtdescripcion.Text.Trim, codempresa.ToString()).Tables(0).Rows.Count
        If agregar Then
            If valor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtcod.Text = ""
                Me.txtcod.Focus()
                Exit Sub
            ElseIf Var_Renzo = 1 Then
                MsgBox("La Descripcion ya Existe en la Tabla Linea, Gracias", MsgBoxStyle.Information, "Error")
                Me.txtdescripcion.Text = ""
                Me.txtdescripcion.Focus()
                Exit Sub
            Else
                Resp = CAyuda.Ejecutar("NSP_ins_LINEA", txtcod.Text.Trim, txtdescripcion.Text.Trim, 0, codempresa.ToString(), cbotipoprod.SelectedValue, TxtCorrelat.Text.Trim)
                If Resp = 1 Then
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','INSERT','LINEA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
                End If
            End If
        Else

            If TmpListarDatos("SELECT * FROM LINEA  WHERE  DESLINEA='" & txtdescripcion.Text.Trim & "' AND CODEMPRESA='" & codempresa & "' AND CODLINEA <> '" & txtcod.Text.Trim & "' ").Rows.Count > 0 Then
                MsgBox("La Descripcion ya Existe en la Tabla Linea, Gracias", MsgBoxStyle.Information, "Error")
                Me.txtdescripcion.Text = ""
                Me.txtdescripcion.Focus()
                Exit Sub
            End If

            Resp = CAyuda.Ejecutar("NSP_upd_LINEA", txtcod.Text.Trim, txtdescripcion.Text.Trim, 0, "", codempresa, TxtCorrelat.Text.Trim)
            If Resp = 1 Then
                MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','UPDATE','LINEA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
            End If
        End If
        Call BOTONES(True, False, False, False, True)
        LimpiarFormularios(Me)
        bloqueatextos(Me)
        cbotipoprod.Enabled = False
    End Sub
    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            valor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoLinea", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
            If valor <> 0 Then
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
        agregar = False
        Call BOTONES(False, True, False, False, True)
        txtdescripcion.ReadOnly = False
        txtdescripcion.Enabled = True
        TxtCorrelat.Enabled = True
        cbotipoprod.Enabled = True
        txtdescripcion.Focus()
        txtdescripcion.SelectAll()
    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            Resp = CAyuda.Ejecutar("NSP_del_LINEA", txtcod.Text, codempresa)
            If Resp = 1 Then
                MessageBox.Show("Registro Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','DELETE','LINEA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("No se puede eliminar. Tabla relacionada a otros registros !!", MsgBoxStyle.Critical, "Aviso")
            End If
            LimpiarFormularios(Me)
            bloqueatextos(Me)
            BOTONES(True, False, False, False, True)
            cbotipoprod.Enabled = False
        End If


    End Sub
    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim MEN As New FRM_GRIDLINEA
        MEN.VIE = Me
        Call BOTONES(True, False, True, True, True)
        MEN.ShowDialog()
    End Sub

    Private Sub TxtCorrelat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCorrelat.TextChanged

    End Sub

    Private Sub TxtCorrelat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCorrelat.KeyPress
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

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtcod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcod.TextChanged

    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            TxtCorrelat.Focus()
        End If
    End Sub
End Class
