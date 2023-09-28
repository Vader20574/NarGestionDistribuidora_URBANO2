Imports System.Data
Imports vb = Microsoft.VisualBasic

Public Class FrmCambio
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCompra As System.Windows.Forms.TextBox
    Friend WithEvents Txtventa As System.Windows.Forms.TextBox
    Friend WithEvents cmba As System.Windows.Forms.ComboBox
    Friend WithEvents cmbde As System.Windows.Forms.ComboBox
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambio))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtCompra = New System.Windows.Forms.TextBox
        Me.Txtventa = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.dtfecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmba = New System.Windows.Forms.ComboBox
        Me.cmbde = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnreporte = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "T.Compra :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "T.Venta :"
        '
        'TxtCompra
        '
        Me.TxtCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCompra.Location = New System.Drawing.Point(88, 48)
        Me.TxtCompra.Name = "TxtCompra"
        Me.TxtCompra.Size = New System.Drawing.Size(88, 21)
        Me.TxtCompra.TabIndex = 3
        '
        'Txtventa
        '
        Me.Txtventa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtventa.Location = New System.Drawing.Point(88, 74)
        Me.Txtventa.Name = "Txtventa"
        Me.Txtventa.Size = New System.Drawing.Size(88, 21)
        Me.Txtventa.TabIndex = 4
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
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(392, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 168)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(17, 106)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNCANCELAR.TabIndex = 10
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(17, 134)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(79, 21)
        Me.BTNCERRAR.TabIndex = 11
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(17, 78)
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
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(-83, 84)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(81, 23)
        Me.BTNELIMINAR.TabIndex = 2
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNELIMINAR.Visible = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(17, 22)
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
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(17, 50)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(79, 23)
        Me.BTNGUARDAR.TabIndex = 8
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(208, 21)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(45, 23)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtfecha
        '
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecha.Location = New System.Drawing.Point(88, 22)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(120, 21)
        Me.dtfecha.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmba)
        Me.GroupBox2.Controls.Add(Me.cmbde)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtCompra)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtfecha)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Txtventa)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 168)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'cmba
        '
        Me.cmba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmba.Location = New System.Drawing.Point(88, 126)
        Me.cmba.Name = "cmba"
        Me.cmba.Size = New System.Drawing.Size(232, 21)
        Me.cmba.TabIndex = 6
        '
        'cmbde
        '
        Me.cmbde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbde.Location = New System.Drawing.Point(88, 100)
        Me.cmbde.Name = "cmbde"
        Me.cmbde.Size = New System.Drawing.Size(232, 21)
        Me.cmbde.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "A :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "De :"
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(280, 136)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(72, 23)
        Me.btnreporte.TabIndex = 24
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'FrmCambio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(512, 182)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnreporte)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 216)
        Me.Name = "FrmCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Cambio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private ValidaDatos As Boolean
    Private AIntvalor As Integer
    Private AIntResp As Integer
    Private ABoolAgregar As Boolean
    Private ATblImp As New DataTable
    Public GrecibeUbicacion As Object
    Private Sub TxtCompra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCompra.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtCompra.Focus()
        End If
        If Keyascii = 13 Then
            Txtventa.Focus()
        End If
    End Sub

    Private Sub Txtventa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtventa.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(CAyuda.SoloNumeros(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Txtventa.Focus()
        End If
        If Keyascii = 13 Then
            cmbde.Focus()
        End If
    End Sub

    Private Sub cmbde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbde.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cmba.Focus()
        End If
    End Sub

    Private Sub FrmCambio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
       Try
            ValidaDatos = True
            LimpiarFormularios(Me)
        Call BOTONES(True, False, False, False, True)
            AIntvalor = 0
            CAyuda.CargarDataCombo(cmbde, "NSP_Select_Listado_Moneda  '" & codempresa & "'", "Código", "Descripción")
            CAyuda.CargarDataCombo(cmba, "NSP_Select_Listado_Moneda  '" & codempresa & "'", "Código", "Descripción")
            ABoolAgregar = True
            bloqueatextos(Me)
            cmbde.Enabled = False
            cmba.Enabled = False
        Catch
            MessageBox.Show("Error Cargando Variables", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click

        desbloqueatextos(Me)
        Call BOTONES(False, True, False, False, False)
        LimpiarFormularios(Me)

        dtfecha.Enabled = True
        cmbde.Enabled = True
        cmba.Enabled = True
        TxtCompra.Focus()
        ABoolAgregar = True

    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR
    End Sub



    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Call BOTONES(True, False, False, False, True)
        LimpiarFormularios(Me)
        bloqueatextos(Me)

        cmbde.Enabled = False
        cmba.Enabled = False

    End Sub
    Sub valida_datos()
        ValidaDatos = True
        If TxtCompra.Text = "" Or IIf(TxtCompra.Text = "", 0, TxtCompra.Text) = 0 Then
            ValidaDatos = False
        End If
        If Txtventa.Text = "" Or IIf(Txtventa.Text = "", 0, Txtventa.Text) = 0 Then
            ValidaDatos = False
        End If
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        valida_datos()
        If ValidaDatos = False Then
            MessageBox.Show("Falta Ingresar un Registro", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ABoolAgregar Then
            TmpInsertDatos("NSP_ins_Cambio '" & CodUsuario & "'," & Txtventa.Text & "," & TxtCompra.Text & ",'" & cmba.SelectedValue & "','" & cmbde.SelectedValue & "','" & Format(dtfecha.Value, "dd/MM/yy") & "','" & codempresa.ToString() & "'")
            MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & Txtventa.Text - TxtCompra.Text & "','INSERT','TIPOCAMBIO','" & Format(System.DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
        Else
            TmpInsertDatos("NSP_upd_Cambio 0," & Txtventa.Text & "," & TxtCompra.Text & ",'" & Format(dtfecha.Value, "dd/MM/yyyy") & "'")
            MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & Txtventa.Text - TxtCompra.Text & "','UPDATE','TIPOCAMBIO','" & Format(System.DateTime.Now, "dd/MM/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
        End If
        Call BOTONES(True, False, False, False, True)
        LimpiarFormularios(Me)
        bloqueatextos(Me)
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        desbloqueatextos(Me)
        ABoolAgregar = False
        Call BOTONES(False, True, False, False, True)
        dtfecha.Enabled = False
        cmbde.Enabled = False
        cmba.Enabled = False
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Dim form As New FrmBusquedaCambio
        Dim ArrayBusqueda(4, 2) As Object
        Try
            ArrayBusqueda(0, 0) = "Fecha"
            ArrayBusqueda(0, 1) = "Fecha "
            ArrayBusqueda(0, 2) = 1500
            ArrayBusqueda(1, 0) = "De"
            ArrayBusqueda(1, 1) = "De "
            ArrayBusqueda(1, 2) = 4000
            ArrayBusqueda(2, 0) = "A"
            ArrayBusqueda(2, 1) = "A "
            ArrayBusqueda(2, 2) = 4000
            ArrayBusqueda(3, 0) = "Compra"
            ArrayBusqueda(3, 1) = "Compra "
            ArrayBusqueda(3, 2) = 4000
            ArrayBusqueda(4, 0) = "Venta"
            ArrayBusqueda(4, 1) = "Venta "
            ArrayBusqueda(4, 2) = 4000

            form.GObtenerRegistros(CAyuda.ListarDatos("NSP_Select_ListaCambio", codempresa.ToString()).Tables(0), ArrayBusqueda, 4, 1)
            form.ShowDialog()
            If AboolCargarValor = True Then
                dtfecha.Value = AobjARRAYAYUDA(0, 0)
                cmbde.SelectedValue = AobjARRAYAYUDA(1, 0)
                cmba.SelectedValue = AobjARRAYAYUDA(2, 0)
                TxtCompra.Text = AobjARRAYAYUDA(3, 0)
                Txtventa.Text = AobjARRAYAYUDA(4, 0)
            End If
            AboolCargarValor = False
        Catch eqx As Exception
            MsgBox(eqx.Message)
        End Try

        Call BOTONES(True, False, True, True, True)

    End Sub
    Public Sub RetornaValores(ByVal IArrayValores As Object)

    End Sub

    Private Sub FrmCambio_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        BTNNUEVO.Focus()
    End Sub
    Private Sub TxtCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCompra.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub cmba_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmba.KeyPress
        BTNGUARDAR.Focus()
    End Sub


    Private Sub dtfecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtfecha.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub TxtCompra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCompra.TextChanged

    End Sub
End Class
