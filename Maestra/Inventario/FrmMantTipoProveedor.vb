Public Class FrmMantTipoProveedor
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBuscTipo As System.Windows.Forms.Button
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMantTipoProveedor))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnBuscTipo = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnBuscTipo)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(114, 40)
        Me.TxtDescripcion.MaxLength = 25
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(230, 20)
        Me.TxtDescripcion.TabIndex = 3
        Me.TxtDescripcion.Text = ""
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(114, 14)
        Me.TxtCodigo.MaxLength = 2
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(58, 20)
        Me.TxtCodigo.TabIndex = 2
        Me.TxtCodigo.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion de  Tipo : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo : "
        '
        'BtnBuscTipo
        '
        Me.BtnBuscTipo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBuscTipo.ImageIndex = 5
        Me.BtnBuscTipo.ImageList = Me.ImageList1
        Me.BtnBuscTipo.Location = New System.Drawing.Point(174, 12)
        Me.BtnBuscTipo.Name = "BtnBuscTipo"
        Me.BtnBuscTipo.Size = New System.Drawing.Size(34, 24)
        Me.BtnBuscTipo.TabIndex = 157
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnImprimir)
        Me.GroupBox4.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox4.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox4.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox4.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox4.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox4.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox4.Location = New System.Drawing.Point(116, 82)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 78)
        Me.GroupBox4.TabIndex = 156
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mantenimiento"
        '
        'BtnImprimir
        '
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnImprimir.ImageIndex = 15
        Me.BtnImprimir.ImageList = Me.ImageList1
        Me.BtnImprimir.Location = New System.Drawing.Point(132, 44)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(83, 25)
        Me.BtnImprimir.TabIndex = 803
        Me.BtnImprimir.TabStop = False
        Me.BtnImprimir.Text = "   &Reporte"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(50, 44)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNCANCELAR.TabIndex = 28
        Me.BTNCANCELAR.TabStop = False
        Me.BTNCANCELAR.Text = "   &Cancelar"
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 16
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(214, 44)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNCERRAR.TabIndex = 500
        Me.BTNCERRAR.TabStop = False
        Me.BTNCERRAR.Text = "   &Cerrar"
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(178, 18)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(82, 26)
        Me.BTNMODIFICAR.TabIndex = 802
        Me.BTNMODIFICAR.TabStop = False
        Me.BTNMODIFICAR.Text = "   &Modificar"
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(262, 18)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNELIMINAR.TabIndex = 27
        Me.BTNELIMINAR.TabStop = False
        Me.BTNELIMINAR.Text = "   &Eliminar"
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(8, 18)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(83, 25)
        Me.BTNNUEVO.TabIndex = 800
        Me.BTNNUEVO.TabStop = False
        Me.BTNNUEVO.Text = "&Nuevo"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Enabled = False
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(94, 18)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(83, 25)
        Me.BTNGUARDAR.TabIndex = 801
        Me.BTNGUARDAR.TabStop = False
        Me.BTNGUARDAR.Text = "   &Guardar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 157
        Me.PictureBox1.TabStop = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(228, 70)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 158
        '
        'FrmMantTipoProveedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(484, 168)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMantTipoProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Tipo de Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Private Agregar As Boolean


#End Region

#Region "Funciones Form"

    Private Sub LimpiarDatos()
        TxtCodigo.Text = ""
        TxtDescripcion.Text = ""
        TxtCodigo.Enabled = False
        TxtDescripcion.Enabled = False
        Agregar = False

    End Sub


#End Region



    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub BtnBuscTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscTipo.Click
        Dim FrmTip As New FrmBusqTipoProveedor
        FrmTip.ShowDialog()
        If FrmTip.DEVOLVER = False Then
            Exit Sub
        End If
        TxtCodigo.Text = FrmTip.DgTipo.Item(FrmTip.DgTipo.CurrentRowIndex, 0)
        TxtDescripcion.Text = FrmTip.DgTipo.Item(FrmTip.DgTipo.CurrentRowIndex, 1)

        Call BOTONES(True, False, True, True, True)

    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        LimpiarDatos()
        Call BOTONES(True, False, False, False, True)
    End Sub

    Private Sub FrmMantTipoProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarDatos()
        Call BOTONES(True, False, False, False, True)

    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Agregar = True
        Call botones(False, True, False, False, False)

        TxtCodigo.Enabled = True
        TxtDescripcion.Enabled = True
        TxtCodigo.Text = String.Empty
        TxtDescripcion.Text = String.Empty

        TxtCodigo.Focus()

    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        BtnBuscTipo.Enabled = BUSCAR

    End Sub


    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        If TxtCodigo.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR CODIGO.. ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If Agregar = True Then

            If TmpListarDatos("SELECT * FROM TIPOPROVEE WHERE CODEMPRESA='" & codempresa & "' AND CDTIPOPROV='" & TxtCodigo.Text.Trim & "' ").Rows.Count > 0 Then
                MsgBox("EL CODIGO YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            If TmpListarDatos("SELECT * FROM TIPOPROVEE WHERE CODEMPRESA='" & codempresa & "' AND DSTIPOPROV='" & TxtDescripcion.Text.Trim & "' ").Rows.Count > 0 Then
                MsgBox("LA DESCRIPCION YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            If CAyuda.Ejecutar("InsTIPOPROVEExProc", codempresa, TxtCodigo.Text.Trim, TxtDescripcion.Text.Trim) > 0 Then
                MsgBox("SE GUARDO CORRECTAMENTE EL REGISTRO...", MsgBoxStyle.Information, "")
                LimpiarDatos()
            End If
        Else

            If TmpListarDatos("SELECT * FROM TIPOPROVEE WHERE CODEMPRESA='" & codempresa & "' AND DSTIPOPROV='" & TxtDescripcion.Text.Trim & "' AND CDTIPOPROV <> '" & TxtCodigo.Text.Trim & "'").Rows.Count > 0 Then
                MsgBox("LA DESCRIPCION YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            If CAyuda.Ejecutar("UpdateTIPOPROVEExProc", codempresa, TxtCodigo.Text.Trim, TxtDescripcion.Text.Trim) > 0 Then
                MsgBox("SE GUARDO CORRECTAMENTE EL REGISTRO...", MsgBoxStyle.Information, "")
                LimpiarDatos()
            End If
        End If

        Call BOTONES(True, False, False, False, True)

    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Agregar = False
        TxtDescripcion.Enabled = True

        TxtDescripcion.Focus()

        Call BOTONES(False, True, False, False, True)

    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If TxtCodigo.Text.Trim = "" Then
            MsgBox("FALTA INGRESAR CODIGO.. ", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        If CAyuda.Ejecutar("EliTIPOPROVEExProc", codempresa, TxtCodigo.Text.Trim) > 0 Then
            MsgBox("SE ELIMINO CORRECTAMENTE EL REGISTRO...", MsgBoxStyle.Information, "")
            LimpiarDatos()
        End If

        BOTONES(True, False, False, False, True)

    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()

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
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "RptTipProv.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_Formulas(0, "Empresa='" & dt.Rows(0)(0).ToString & "'")
            crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
