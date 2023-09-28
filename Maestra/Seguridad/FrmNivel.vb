Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmNivel
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
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtcod As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents BTNACCESO As System.Windows.Forms.Button
    Friend WithEvents Crpt1 As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmNivel))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.txtcod = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNACCESO = New System.Windows.Forms.Button
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.Crpt1 = New AxCrystal.AxCrystalReport
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Crpt1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.txtcod)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 88)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(71, 48)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(289, 21)
        Me.txtdescripcion.TabIndex = 2
        Me.txtdescripcion.Text = ""
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(143, 22)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 3
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcod
        '
        Me.txtcod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcod.Location = New System.Drawing.Point(71, 23)
        Me.txtcod.MaxLength = 4
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(72, 21)
        Me.txtcod.TabIndex = 1
        Me.txtcod.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nivel :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Código :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNACCESO)
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(405, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 240)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNACCESO
        '
        Me.BTNACCESO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACCESO.ImageIndex = 4
        Me.BTNACCESO.ImageList = Me.ImageList2
        Me.BTNACCESO.Location = New System.Drawing.Point(15, 124)
        Me.BTNACCESO.Name = "BTNACCESO"
        Me.BTNACCESO.Size = New System.Drawing.Size(82, 23)
        Me.BTNACCESO.TabIndex = 8
        Me.BTNACCESO.Text = "&Acceso"
        Me.BTNACCESO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList2
        '
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(15, 176)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 23)
        Me.btnreporte.TabIndex = 10
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(15, 150)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCANCELAR.TabIndex = 9
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(15, 202)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCERRAR.TabIndex = 11
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(15, 71)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNMODIFICAR.TabIndex = 6
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(15, 97)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(82, 24)
        Me.BTNELIMINAR.TabIndex = 7
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(15, 19)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(82, 23)
        Me.BTNNUEVO.TabIndex = 4
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(15, 45)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNGUARDAR.TabIndex = 5
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Crpt1
        '
        Me.Crpt1.Enabled = True
        Me.Crpt1.Location = New System.Drawing.Point(216, 212)
        Me.Crpt1.Name = "Crpt1"
        Me.Crpt1.OcxState = CType(resources.GetObject("Crpt1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Crpt1.Size = New System.Drawing.Size(28, 28)
        Me.Crpt1.TabIndex = 20
        '
        'FrmNivel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(522, 256)
        Me.Controls.Add(Me.Crpt1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(536, 288)
        Me.Name = "FrmNivel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Niveles de Acceso"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Crpt1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private AIntvalor As Integer
    Private AIntResp As Integer
    Private ABoolAgregar As Boolean
    Private ValidaDatos As Boolean


    Private Sub FrmNivel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValidaDatos = False
        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
    BTNCERRAR, True, False, True, True, True, True, True)
        txtcod.Enabled = False
        txtdescripcion.Enabled = False

        AIntvalor = 0
        ABoolAgregar = True

      BTNNUEVO.Focus()

    End Sub
   
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        desbloqueatextos(Me)
        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
            BTNCERRAR, False, True, False, False, True, True, True)
        txtcod.Enabled = True
        txtdescripcion.Enabled = True
        txtcod.Focus()
        LimpiarFormularios(Me)
        ABoolAgregar = True
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
BTNCERRAR, True, False, True, True, True, True, True)
        LimpiarFormularios(Me)
        txtcod.Enabled = False
        txtdescripcion.Enabled = False
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        BTNCANCELAR_Click(sender, e)
        Dim FrmBusc As New FrmBusqNivel
        FrmBusc.ShowDialog()
        If FrmBusc.DEVOLVER = False Then
            Exit Sub
        End If
        txtcod.Text = FrmBusc.grdLinea.Item(FrmBusc.grdLinea.CurrentRowIndex, 0)
        txtdescripcion.Text = FrmBusc.grdLinea.Item(FrmBusc.grdLinea.CurrentRowIndex, 1)

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
        Dim FRM As New FrmAcceso
        valida_datos()
        If ValidaDatos Then
            MessageBox.Show("Falta Ingresar Algunos Valores", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ValidaDatos = False
            Exit Sub
        End If
        AIntvalor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoNivel", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
        If ABoolAgregar Then

            If AIntvalor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                AIntResp = CAyuda.Ejecutar("NSP_ins_Nivel", txtcod.Text, txtdescripcion.Text, codempresa.ToString())
                If AIntResp = 1 Then
                    FRM.TxtCdNivel.Text = txtcod.Text
                    FRM.TxtDesNivel.Text = txtdescripcion.Text
                    FRM.CDNIVEL = txtcod.Text.Trim
                    FRM.ShowDialog()
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','INSERT','NIVELES','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MessageBox.Show("Error Durante Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            AIntResp = CAyuda.Ejecutar("NSP_upd_Nivel", txtdescripcion.Text, 0, txtcod.Text)
            If AIntResp = 1 Then
                MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','UPDATE','NIVELES','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MessageBox.Show("Error Durante el Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
BTNCERRAR, True, False, True, True, True, True, True)
        LimpiarFormularios(Me)
        bloqueatextos(Me)
        BTNNUEVO.Focus()


    End Sub


    Private Sub txtcod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcod.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            AIntvalor = CAyuda.ListarDatos("NSP_Select_VerficaCodigoNivel", txtcod.Text, codempresa.ToString()).Tables(0).Rows.Count
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
        botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
    BTNCERRAR, False, True, False, False, True, True, True)
        txtdescripcion.ReadOnly = False
        txtdescripcion.Enabled = True
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then

            AIntResp = CAyuda.Ejecutar("NSP_del_Nivel", 1, 0, txtcod.Text)

            Dim sql As String
            Dim PROCESO As Boolean
            sql = "delete from ACCESO WHERE cdnivel=  '" & txtcod.Text & "'"
            PROCESO = TmpInsertDatos(sql)

            sql = "delete from ACCESOPROC WHERE cdnivel=  '" & txtcod.Text & "'"
            PROCESO = TmpInsertDatos(sql)

            If AIntResp = 1 Then
                MessageBox.Show("Registro Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcod.Text & "','DELETE','NIVELES','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MessageBox.Show("Error Durante el Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            LimpiarFormularios(Me)
            bloqueatextos(Me)
            botones(BTNNUEVO, BTNGUARDAR, BTNMODIFICAR, BTNELIMINAR, BTNCANCELAR, btnreporte, _
    BTNCERRAR, True, False, True, True, True, True, True)

        End If

    End Sub
    Private Sub txtcod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcod.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub
    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If

    End Sub


    Private Sub BTNACCESO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNACCESO.Click
        If txtcod.Text.Trim <> "" Then
            If txtdescripcion.Text.Trim <> "" Then
                Dim FRM As New FrmAcceso
                FRM.TxtCdNivel.Text = txtcod.Text
                FRM.TxtDesNivel.Text = txtdescripcion.Text
                FRM.CDNIVEL = txtcod.Text.Trim
                FRM.ShowDialog()
            End If

        End If
    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        Try
            With Crpt1
                .set_StoredProcParam(0, codempresa)
                .set_Formulas(0, "EMPRESA=  '" & DesEmpresa & "'")
                .set_Formulas(1, "USUARIO='" & DesUsuario & "'")
                .ReportFileName = rutareporte & CType("Rpt_NivelesAcceso.rpt", String)
                .Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"

                .WindowState = Crystal.WindowStateConstants.crptMaximized
                .Destination = Crystal.DestinationConstants.crptToWindow
                .Action = 1
                .Reset()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
