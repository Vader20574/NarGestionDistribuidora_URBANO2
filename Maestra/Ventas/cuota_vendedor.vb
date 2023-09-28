Public Class cuota_vendedor
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tcuotad As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents tcuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tcuotat As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tvendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(cuota_vendedor))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.tcuotad = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.tcuotas = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.tcuotat = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.tvendedor = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tcodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(528, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 216)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(15, 154)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 23)
        Me.btnreporte.TabIndex = 14
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(18, 18)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(15, 127)
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
        Me.BTNCERRAR.Location = New System.Drawing.Point(15, 181)
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
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(15, 73)
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
        Me.BTNELIMINAR.Location = New System.Drawing.Point(15, 100)
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
        Me.BTNNUEVO.Location = New System.Drawing.Point(15, 19)
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
        Me.BTNGUARDAR.Location = New System.Drawing.Point(15, 46)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNGUARDAR.TabIndex = 10
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tcuotad)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.tcuotas)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.tcuotat)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.tvendedor)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 214)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(116, 97)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker2.TabIndex = 51
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 73)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 21)
        Me.DateTimePicker1.TabIndex = 50
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(255, 49)
        Me.TextBox1.MaxLength = 150
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 21)
        Me.TextBox1.TabIndex = 49
        Me.TextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(213, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcuotad
        '
        Me.tcuotad.Location = New System.Drawing.Point(115, 169)
        Me.tcuotad.MaxLength = 5
        Me.tcuotad.Name = "tcuotad"
        Me.tcuotad.TabIndex = 8
        Me.tcuotad.Text = "0"
        Me.tcuotad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 171)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 17)
        Me.Label22.TabIndex = 47
        Me.Label22.Text = "Cuota Dólares :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcuotas
        '
        Me.tcuotas.Location = New System.Drawing.Point(115, 145)
        Me.tcuotas.MaxLength = 5
        Me.tcuotas.Name = "tcuotas"
        Me.tcuotas.TabIndex = 7
        Me.tcuotas.Text = "0"
        Me.tcuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(34, 147)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 17)
        Me.Label23.TabIndex = 45
        Me.Label23.Text = "Cuota Soles  :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcuotat
        '
        Me.tcuotat.Location = New System.Drawing.Point(115, 121)
        Me.tcuotat.MaxLength = 5
        Me.tcuotat.Name = "tcuotat"
        Me.tcuotat.TabIndex = 6
        Me.tcuotat.Text = "0"
        Me.tcuotat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(13, 123)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 17)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Cuota Toneladas :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tvendedor
        '
        Me.tvendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tvendedor.Location = New System.Drawing.Point(115, 49)
        Me.tvendedor.MaxLength = 150
        Me.tvendedor.Name = "tvendedor"
        Me.tvendedor.TabIndex = 2
        Me.tvendedor.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(63, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 17)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "F Final :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(49, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Vendedor :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Inicial :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tcodigo
        '
        Me.tcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tcodigo.Location = New System.Drawing.Point(115, 25)
        Me.tcodigo.MaxLength = 4
        Me.tcodigo.Name = "tcodigo"
        Me.tcodigo.TabIndex = 1
        Me.tcodigo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(213, 24)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 18
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cuota_vendedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(648, 229)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(656, 256)
        Me.Name = "cuota_vendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cuotas por Vendedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim INTFLAGVEND As Integer

    Private Sub frm_clie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False
        bloqueatextbox(Me)
        Call BOTONES(True, False, False, False)
        BTNCANCELAR.Enabled = False
    End Sub

    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub

        If INTFLAGVEND = 0 Then
            Call limpiatextbox(Me)
            Call BOTONES(True, False, False, False)
        Else
            Call BOTONES(True, False, True, True)
        End If
        Call bloqueatextbox(Me)
        BTNCANCELAR.Enabled = False
        btnbuscar.Enabled = True
        Button1.Enabled = False
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False
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
        sql = "nsp_dele_cuota_vendedor '" & tcodigo.Text & "','" & Me.tvendedor.Text.Trim & "','" & codempresa & "','" & CodUsuario & "'"
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
        INTFLAGVEND = 1
        tvendedor.Focus()
        tvendedor.SelectAll()
        BTNCANCELAR.Enabled = True
        btnbuscar.Enabled = False
        Button1.Enabled = True
        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True
        Me.TextBox1.ReadOnly = True
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        tcuotat.Text = "0"
        tcuotas.Text = "0"
        tcuotad.Text = "0"
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False)
        INTFLAGVEND = 0
        tvendedor.Focus()
        BTNCANCELAR.Enabled = True
        tcodigo.ReadOnly = True
        TextBox1.ReadOnly = True
        btnbuscar.Enabled = False
        Button1.Enabled = True
        Me.DateTimePicker1.Enabled = True
        Me.DateTimePicker2.Enabled = True
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim sql As String
        Call formatotextbox(Me)

        If tvendedor.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tcuotad.Text.Trim = "" Then
            MessageBox.Show("Ingrese la Cuota en Dólares Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tcuotat.Text.Trim = "" Then
            MessageBox.Show("Ingrese la Cuota de toneladas Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf tcuotas.Text.Trim = "" Then
            MessageBox.Show("Ingrese la Cuotas en Soles Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim o As Int64

        If INTFLAGVEND = 0 Then

            Conecta("verifica_cuota_vendedor '" & Me.tvendedor.Text.Trim & "','" & codempresa & "'", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                For o = 0 To ds.Tables("llena").Rows.Count - 1
                    If ((Me.DateTimePicker1.Value > CDate(ds.Tables("llena").Rows(o)(0)) And Me.DateTimePicker1.Value < CDate(ds.Tables("llena").Rows(o)(1))) Or (Me.DateTimePicker2.Value > CDate(ds.Tables("llena").Rows(o)(0)) And Me.DateTimePicker2.Value < CDate(ds.Tables("llena").Rows(o)(1)))) Or (Me.DateTimePicker1.Value < CDate(ds.Tables("llena").Rows(o)(0)) And Me.DateTimePicker2.Value > CDate(ds.Tables("llena").Rows(o)(1))) Then
                        MessageBox.Show("Ya existe una cuota ingresada que se cruza con el Rango de Fecha que está queriendo ingresar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            End If

            sql = "NSP_ins_CUOTA_vendedor '" & tvendedor.Text & "'," & Me.tcuotas.Text & "," & Me.tcuotad.Text & "," & Me.tcuotat.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "MM/dd/yy") & "','" & codempresa & "','" & CodUsuario & "'"

            If TmpInsertDatos(sql) = True Then
                Call BOTONES(True, False, False, False)
            End If

        End If

        If INTFLAGVEND = 1 Then

            Conecta("verifica_cuota_vendedor_mod '" & Me.tvendedor.Text.Trim & "','" & codempresa & "'", "llena")
            If ds.Tables("llena").Rows.Count > 0 Then
                For o = 0 To ds.Tables("llena").Rows.Count - 1
                    If ((Me.DateTimePicker1.Value > CDate(ds.Tables("llena").Rows(o)(0)) And Me.DateTimePicker1.Value < CDate(ds.Tables("llena").Rows(o)(1))) Or (Me.DateTimePicker2.Value > CDate(ds.Tables("llena").Rows(o)(0)) And Me.DateTimePicker2.Value < CDate(ds.Tables("llena").Rows(o)(1)))) Or (Me.DateTimePicker1.Value < CDate(ds.Tables("llena").Rows(o)(0)) And Me.DateTimePicker2.Value > CDate(ds.Tables("llena").Rows(o)(1))) Then
                        MessageBox.Show("Ya existe una cuota ingresada que se cruza con el Rango de Fecha que está queriendo ingresar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Next
            End If

            sql = "NSP_UPD_CUOTA_vendedor " & tcodigo.Text & ",'" & tvendedor.Text & "'," & Me.tcuotas.Text & "," & Me.tcuotad.Text & "," & Me.tcuotat.Text & ",'" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value), "MM/dd/yy") & "','" & Format(Microsoft.VisualBasic.DateValue(Me.DateTimePicker2.Value), "MM/dd/yy") & "','" & codempresa & "','" & CodUsuario & "'"
            If TmpInsertDatos(sql) = True Then
                Call BOTONES(True, False, True, True)
            End If
        End If


        Bloqueatextbox(Me)
        Button1.Enabled = False
        btnbuscar.Enabled = True
        BTNCANCELAR.Enabled = False
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker2.Enabled = False

        Conecta("select top 1 finicio from cuota_vendedor where idvend='" & Me.tvendedor.Text.Trim & "' and codempresa='" & codempresa & "' order by finicio desc", "verifica")
        If ds.Tables("verifica").Rows.Count > 0 Then
            If Trim(ds.Tables("verifica").Rows(0)(0)) = Microsoft.VisualBasic.DateValue(Me.DateTimePicker1.Value) Then
                TmpInsertDatos("update vendedor set cuotat=" & Me.tcuotat.Text & ",cuotas=" & Me.tcuotas.Text & ",cuotad=" & Me.tcuotad.Text & " where codvend='" & Me.tvendedor.Text & "' and codempresa='" & codempresa & "'")
            End If
        End If

        If INTFLAGVEND = 0 Then
            Limpiatextbox(Me)
        End If
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call BOTONES(True, False, True, True)
        Call Bloqueatextbox(Me)
        tcodigo.ReadOnly = True
        Button1.Enabled = False

        Dim men As New frm_grilla_cuota_vend
        men.vie = Me
        men.ShowDialog()

    End Sub

    Private Sub tcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tvendedor.Focus()
            Me.tvendedor.SelectAll()
        End If
    End Sub


    Private Sub tcuotat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcuotat.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tcuotat.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tcuotas.Focus()
            Me.tcuotas.SelectAll()
        End If
    End Sub

    Private Sub tcuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcuotas.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tcuotas.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.tcuotad.Focus()
            Me.tcuotad.SelectAll()
        End If
    End Sub

    Private Sub tcuotad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tcuotad.KeyPress
        Call GBloqueaCaracter(Asc(e.KeyChar))

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        Keyascii = CShort(NumerosDecimales(Keyascii))
        If Keyascii = 0 Then
            e.Handled = True
            MessageBox.Show("Sólo Números", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tcuotad.Focus()
        End If

        If Asc(e.KeyChar) = 13 Then
            Me.BTNGUARDAR.Focus()
        End If
    End Sub
    Private Sub tcodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tcodigo.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub tvendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tvendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If tvendedor.Text.Trim <> "" Then
                Conecta("SELECT codvend,dsvend FROM vendedor WHERE CODEMPRESA='" & codempresa & "' AND codvend='" & Me.tvendedor.Text.Trim & "'", "LLENA")
                If ds.Tables("LLENA").Rows.Count > 0 Then
                    Me.tvendedor.Text = Trim(ds.Tables("llena").Rows(0)(0))
                    Me.TextBox1.Text = Trim(ds.Tables("llena").Rows(0)(1))
                Else
                    MessageBox.Show("No existe Vendedor Solicitado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            Me.DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub DateTimePicker1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DateTimePicker2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.tcuotat.Focus()
            Me.tcuotat.SelectAll()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MEN As New FRM_GRIDVEND
        MEN.vie1 = Me
        MEN.bol = False
        MEN.ShowDialog()
    End Sub

End Class
