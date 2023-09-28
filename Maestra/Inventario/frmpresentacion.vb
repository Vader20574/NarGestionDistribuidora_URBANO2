Public Class frmpresentacion
    Inherits System.Windows.Forms.Form
    Dim FLAG As Integer
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents txtdespresentacion As System.Windows.Forms.TextBox
    Friend WithEvents txtcodpresentacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbomedida As System.Windows.Forms.ComboBox
    Friend WithEvents txtfactor As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkpventa As System.Windows.Forms.CheckBox
    Friend WithEvents TxtUMSunat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkfuerzaventa As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpresentacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TxtUMSunat = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkpventa = New System.Windows.Forms.CheckBox
        Me.txtfactor = New System.Windows.Forms.NumericUpDown
        Me.cbomedida = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.txtdespresentacion = New System.Windows.Forms.TextBox
        Me.txtcodpresentacion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkfuerzaventa = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtfactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(422, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(14, 128)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNCANCELAR.TabIndex = 4
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(14, 157)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNCERRAR.TabIndex = 5
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(14, 74)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNMODIFICAR.TabIndex = 2
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(14, 101)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(14, 20)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(76, 23)
        Me.BTNNUEVO.TabIndex = 0
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(14, 47)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(76, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtUMSunat)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.chkpventa)
        Me.GroupBox2.Controls.Add(Me.txtfactor)
        Me.GroupBox2.Controls.Add(Me.cbomedida)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.txtdespresentacion)
        Me.GroupBox2.Controls.Add(Me.txtcodpresentacion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.chkfuerzaventa)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 208)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TxtUMSunat
        '
        Me.TxtUMSunat.AcceptsReturn = True
        Me.TxtUMSunat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtUMSunat.Enabled = False
        Me.TxtUMSunat.Location = New System.Drawing.Point(118, 121)
        Me.TxtUMSunat.MaxLength = 3
        Me.TxtUMSunat.Name = "TxtUMSunat"
        Me.TxtUMSunat.ReadOnly = True
        Me.TxtUMSunat.Size = New System.Drawing.Size(125, 21)
        Me.TxtUMSunat.TabIndex = 26
        Me.TxtUMSunat.Text = "NIU"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-2, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Unidad Medida Sunat : "
        '
        'chkpventa
        '
        Me.chkpventa.Location = New System.Drawing.Point(101, 148)
        Me.chkpventa.Name = "chkpventa"
        Me.chkpventa.Size = New System.Drawing.Size(104, 24)
        Me.chkpventa.TabIndex = 9
        Me.chkpventa.Text = "Punto de Venta"
        '
        'txtfactor
        '
        Me.txtfactor.DecimalPlaces = 2
        Me.txtfactor.Location = New System.Drawing.Point(101, 96)
        Me.txtfactor.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txtfactor.Name = "txtfactor"
        Me.txtfactor.Size = New System.Drawing.Size(91, 21)
        Me.txtfactor.TabIndex = 8
        Me.txtfactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbomedida
        '
        Me.cbomedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomedida.Location = New System.Drawing.Point(101, 47)
        Me.cbomedida.Name = "cbomedida"
        Me.cbomedida.Size = New System.Drawing.Size(286, 21)
        Me.cbomedida.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Medida : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Factor : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(178, 22)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdespresentacion
        '
        Me.txtdespresentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdespresentacion.Location = New System.Drawing.Point(101, 72)
        Me.txtdespresentacion.MaxLength = 50
        Me.txtdespresentacion.Name = "txtdespresentacion"
        Me.txtdespresentacion.Size = New System.Drawing.Size(286, 21)
        Me.txtdespresentacion.TabIndex = 6
        '
        'txtcodpresentacion
        '
        Me.txtcodpresentacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodpresentacion.Location = New System.Drawing.Point(101, 23)
        Me.txtcodpresentacion.MaxLength = 4
        Me.txtcodpresentacion.Name = "txtcodpresentacion"
        Me.txtcodpresentacion.Size = New System.Drawing.Size(72, 21)
        Me.txtcodpresentacion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Presentacion : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkfuerzaventa
        '
        Me.chkfuerzaventa.Location = New System.Drawing.Point(101, 167)
        Me.chkfuerzaventa.Name = "chkfuerzaventa"
        Me.chkfuerzaventa.Size = New System.Drawing.Size(104, 24)
        Me.chkfuerzaventa.TabIndex = 10
        Me.chkfuerzaventa.Text = "Fuerza de Venta"
        '
        'frmpresentacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(541, 208)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(547, 237)
        Me.Name = "frmpresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Presentacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtfactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmpresentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bloqueatextbox(Me)
        cbomedida.Enabled = False
        Call BOTONES(True, False, False, False, True)
        CAyuda.CargarDataCombo(cbomedida, "nsp_sele_umedida '" & codempresa & "'", "Codigo", "Medida")
        txtfactor.Enabled = False
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim PROCESO As Boolean
        Dim sql As String
        Dim h, j As Integer
        Call formatotextbox(Me)
        If txtcodpresentacion.Text = "" Or txtdespresentacion.Text = "" Or txtfactor.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If Me.chkpventa.Checked = True Then
            h = 1
        Else
            h = 0
        End If

        If Me.chkfuerzaventa.Checked = True Then
            j = 1
        Else
            j = 0
        End If

        If FLAG = 0 Then

            If TmpListarDatos("SELECT * FROM PRESENTACION WHERE CODMED= '" & cbomedida.SelectedValue & "' AND DESPRES='" & txtdespresentacion.Text.Trim & "' AND CODEMPRESA='" & codempresa & "' ").Rows.Count > 0 Then
                MsgBox("LA PRENSENTACION YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            sql = "Nsp_inst_presentacion '" & txtcodpresentacion.Text & "','" & txtdespresentacion.Text & "'," & txtfactor.Text & ",'" & cbomedida.SelectedValue.ToString & "','" & codempresa & "','" & h & "','" & j & "','" & TxtUMSunat.Text & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodpresentacion.Text & "','INSERT','PRESENTACION','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            End If
        End If

        If FLAG = 1 Then

            If TmpListarDatos("SELECT * FROM PRESENTACION WHERE CODMED= '" & cbomedida.SelectedValue & "' AND DESPRES='" & txtdespresentacion.Text.Trim & "' AND CODEMPRESA='" & codempresa & "' AND CODPRES <> '" & txtcodpresentacion.Text & "' ").Rows.Count > 0 Then
                MsgBox("LA PRENSENTACION YA EXISTE EN LOS REGISTROS...", MsgBoxStyle.Exclamation, "NAR SISTEMAS S.A.C.")
                Exit Sub
            End If

            sql = "Nsp_upda_presentacion '" & txtcodpresentacion.Text & "','" & txtdespresentacion.Text & "'," & txtfactor.Text & ",'" & cbomedida.SelectedValue.ToString & "','" & codempresa & "', '" & h & "','" & j & "','" & TxtUMSunat.Text & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodpresentacion.Text & "','UPDATE','PRESENTACION','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            End If
        End If

        If PROCESO = False Then
            Exit Sub
        Else
            MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If

        Call BOTONES(True, False, False, False, True)
        cbomedida.Enabled = False
        Bloqueatextbox(Me)
        Call Bloqueatextbox(Me)
        Call Limpiatextbox(Me)
        txtfactor.Value = 0
        txtfactor.Enabled = False

        Me.chkpventa.Checked = False
        Me.chkfuerzaventa.Checked = False
        BTNNUEVO.Focus()

    End Sub
    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, False)
        FLAG = 0
        cbomedida.Enabled = True
        cbomedida.Focus()
        txtcodpresentacion.ReadOnly = True
        txtfactor.Value = 0
        txtfactor.Enabled = True
        chkpventa.Checked = False
        Me.chkfuerzaventa.Checked = False
        Conecta("SELECT  RIGHT('000' + RTRIM(LTRIM(ISNULL( MAX(CONVERT(INTEGER,CODPRES)+1)  , 1 ))),3)AS CODE    FROM  presentacion ", "code")
        If ds.Tables("code").Rows.Count = 0 Then
            txtcodpresentacion.Text = "001"
        Else
            txtcodpresentacion.Text = ds.Tables("code").Rows(0)(0).ToString
        End If


        TxtUMSunat.Text = "NIU"


    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        cbomedida.Enabled = False
        txtfactor.Enabled = False

        Me.chkpventa.Checked = False
        Me.chkfuerzaventa.Checked = False




    End Sub
    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Try
            Dim FRMX As New frmgridpresentacion
            FRMX.ShowDialog()

            Call BOTONES(True, False, True, True, True)
            txtcodpresentacion.ReadOnly = True
            cbomedida.Enabled = False
            Bloqueatextbox(Me)
            mostrar()
        Catch ex As Exception
            MsgBox("No se encontro una fila seleccionada ...", MsgBoxStyle.Information, "Nar Gestion")
        End Try
    End Sub
    Public Sub mostrar()

        txtcodpresentacion.Text = VAR1
        cbomedida.Text = VAR2
        txtdespresentacion.Text = VAR3
        txtfactor.Text = VAR4
        TxtUMSunat.Text = VAR5
        Me.chkpventa.Checked = CBool(VAR5)
        Me.chkfuerzaventa.Checked = CBool(VAR6)
        'TxtUMSunat.Text = VAR7
        TxtUMSunat.Text = "NIU"

    End Sub
    Private Sub BTNMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        Call desbloqueatextbox(Me)
        Call BOTONES(False, True, False, False, True)
        FLAG = 1
        cbomedida.Enabled = True
        desbloqueatextbox(Me)
        txtcodpresentacion.ReadOnly = True
        txtfactor.Enabled = True
        cbomedida.Focus()
    End Sub
    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR

    End Sub
    Private Sub BTNELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then

            Dim PROCESO As Boolean
            Dim sql As String
            sql = "Nsp_dele_presentacion '" & txtcodpresentacion.Text & "','" & codempresa & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodpresentacion.Text & "','DELETE','PRESENTACION','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            End If

            If PROCESO = False Then
                Exit Sub
            Else
                MsgBox("SE ELIMINO CORRECTAMENTE EL  REGISTRO...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
            End If

            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)
            Call Limpiatextbox(Me)
            txtfactor.Value = 0
            txtfactor.Enabled = False

            Me.chkpventa.Checked = False
            Me.chkfuerzaventa.Checked = False
        End If

    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub frmpresentacion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        BTNNUEVO.Focus()
    End Sub
    Private Sub cbomedida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbomedida.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdespresentacion.Focus()
        End If
    End Sub

    Private Sub txtcodpresentacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodpresentacion.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            cbomedida.Focus()
        End If
    End Sub
    Private Sub txtdespresentacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdespresentacion.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtfactor.Focus()
        End If
    End Sub

    Private Sub txttara_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub
    Private Sub txtcodpresentacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcodpresentacion.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub txtfactor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfactor.KeyPress
        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            TxtUMSunat.Focus()
        End If
    End Sub

    Private Sub txtfactor_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfactor.ValueChanged

    End Sub

    Private Sub txtdespresentacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdespresentacion.TextChanged

    End Sub
End Class
