Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmTipoGuia
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
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Grplistado As System.Windows.Forms.GroupBox
    Friend WithEvents grdLinea As System.Windows.Forms.DataGrid
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chksal As System.Windows.Forms.CheckBox
    Friend WithEvents chkval As System.Windows.Forms.CheckBox
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents rdbprecio As System.Windows.Forms.RadioButton
    Friend WithEvents rdbcosto As System.Windows.Forms.RadioButton
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents rbmedida As System.Windows.Forms.RadioButton
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoGuia))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.btnreporte = New System.Windows.Forms.Button
        Me.rdbcosto = New System.Windows.Forms.RadioButton
        Me.rdbprecio = New System.Windows.Forms.RadioButton
        Me.chksal = New System.Windows.Forms.CheckBox
        Me.chkval = New System.Windows.Forms.CheckBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Grplistado = New System.Windows.Forms.GroupBox
        Me.rbmedida = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.grdLinea = New System.Windows.Forms.DataGrid
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Grplistado.SuspendLayout()
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(372, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 192)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(17, 128)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNCANCELAR.TabIndex = 12
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(17, 154)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(78, 21)
        Me.BTNCERRAR.TabIndex = 13
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(17, 76)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNMODIFICAR.TabIndex = 10
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(17, 102)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNELIMINAR.TabIndex = 11
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(17, 24)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(78, 23)
        Me.BTNNUEVO.TabIndex = 8
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
        Me.BTNGUARDAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNGUARDAR.TabIndex = 9
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Controls.Add(Me.btnreporte)
        Me.GroupBox2.Controls.Add(Me.rdbcosto)
        Me.GroupBox2.Controls.Add(Me.rdbprecio)
        Me.GroupBox2.Controls.Add(Me.chksal)
        Me.GroupBox2.Controls.Add(Me.chkval)
        Me.GroupBox2.Controls.Add(Me.txtdescripcion)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 144)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(192, 24)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 2
        Me.btnbuscar.Text = "..."
        Me.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(216, 160)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(72, 23)
        Me.btnreporte.TabIndex = 18
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnreporte.Visible = False
        '
        'rdbcosto
        '
        Me.rdbcosto.Location = New System.Drawing.Point(232, 89)
        Me.rdbcosto.Name = "rdbcosto"
        Me.rdbcosto.Size = New System.Drawing.Size(56, 16)
        Me.rdbcosto.TabIndex = 5
        Me.rdbcosto.Text = "Costo"
        '
        'rdbprecio
        '
        Me.rdbprecio.Checked = True
        Me.rdbprecio.Location = New System.Drawing.Point(160, 89)
        Me.rdbprecio.Name = "rdbprecio"
        Me.rdbprecio.Size = New System.Drawing.Size(56, 16)
        Me.rdbprecio.TabIndex = 4
        Me.rdbprecio.TabStop = True
        Me.rdbprecio.Text = "Precio"
        '
        'chksal
        '
        Me.chksal.Location = New System.Drawing.Point(232, 113)
        Me.chksal.Name = "chksal"
        Me.chksal.Size = New System.Drawing.Size(96, 16)
        Me.chksal.TabIndex = 7
        Me.chksal.Text = "Generar Salida"
        '
        'chkval
        '
        Me.chkval.Location = New System.Drawing.Point(120, 113)
        Me.chkval.Name = "chkval"
        Me.chkval.Size = New System.Drawing.Size(96, 16)
        Me.chkval.TabIndex = 6
        Me.chkval.Text = "Valorizado"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdescripcion.Location = New System.Drawing.Point(88, 49)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(240, 21)
        Me.txtdescripcion.TabIndex = 3
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(88, 25)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 21)
        Me.txtcodigo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tipo Salida Artículo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Código :"
        '
        'Grplistado
        '
        Me.Grplistado.Controls.Add(Me.rbmedida)
        Me.Grplistado.Controls.Add(Me.rbcodigo)
        Me.Grplistado.Controls.Add(Me.grdLinea)
        Me.Grplistado.Controls.Add(Me.txtdato)
        Me.Grplistado.Controls.Add(Me.Label4)
        Me.Grplistado.Location = New System.Drawing.Point(9, 6)
        Me.Grplistado.Name = "Grplistado"
        Me.Grplistado.Size = New System.Drawing.Size(475, 208)
        Me.Grplistado.TabIndex = 23
        Me.Grplistado.TabStop = False
        '
        'rbmedida
        '
        Me.rbmedida.Location = New System.Drawing.Point(368, 24)
        Me.rbmedida.Name = "rbmedida"
        Me.rbmedida.Size = New System.Drawing.Size(88, 16)
        Me.rbmedida.TabIndex = 5
        Me.rbmedida.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Location = New System.Drawing.Point(296, 24)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'grdLinea
        '
        Me.grdLinea.BackgroundColor = System.Drawing.Color.Gray
        Me.grdLinea.CaptionText = "Enter = Modificar   -  Escape = Salir"
        Me.grdLinea.DataMember = ""
        Me.grdLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLinea.Location = New System.Drawing.Point(15, 48)
        Me.grdLinea.Name = "grdLinea"
        Me.grdLinea.ReadOnly = True
        Me.grdLinea.Size = New System.Drawing.Size(448, 152)
        Me.grdLinea.TabIndex = 3
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(83, 24)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(189, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Dato : "
        '
        'FrmTipoGuia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(496, 216)
        Me.Controls.Add(Me.Grplistado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(504, 248)
        Me.Name = "FrmTipoGuia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros Tipo Guia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Grplistado.ResumeLayout(False)
        Me.Grplistado.PerformLayout()
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private ValidaDatos As Boolean
    Private valor As Integer
    Private Resp As Integer
    Private agregar As Boolean
    Private tblImp As New DataTable

    Private Sub FrmTipoGuia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ValidaDatos = False
        Call BOTONES(True, False, False, False, True)
        txtcodigo.Enabled = False
        txtdescripcion.Enabled = False
        Grplistado.Visible = False
        valor = 0
        agregar = True
        tblImp = CAyuda.ListarDatos("NSP_SELECT_LISTATIPOGUIA", codempresa.ToString()).Tables(0)
        grdLinea.DataSource = tblImp
        FormatGrid()
        BTNNUEVO.Focus()

    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                 ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If grdLinea.Focus = True Then
                        Try
                            Dim tblc As DataTable
                            tblc = CAyuda.ListarDatos("NSP_SELECT_VERIFICACODGUIA", codempresa.ToString(), grdLinea.Item(grdLinea.CurrentRowIndex, 0)).Tables(0)
                            txtcodigo.Text = tblc.Rows(0)(0)
                            txtdescripcion.Text = tblc.Rows(0)(1)
                            chkval.Checked = tblc.Rows(0)("VALORIZADO")
                            chksal.Checked = tblc.Rows(0)("GENERASALIDA")
                            If tblc.Rows(0)("TIPOVENTA") Then
                                rdbprecio.Checked = True
                            Else
                                rdbcosto.Checked = True
                            End If
                            tblc.Dispose()
                            Grplistado.Visible = False
                        Catch
                            txtdato.Focus()
                            Exit Function
                        End Try
                    End If
                Case Keys.Escape
                    Grplistado.Visible = False
            End Select
        End If
        ' Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .AlternatingBackColor = Color.GhostWhite
            .MappingName = tblImp.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Codigo"
            .MappingName = "Código"
            .Width = 60
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Descripcion"
            .MappingName = "Descripción"
            .Width = 200
        End With

        Dim grdColStyle3 As New DataGridBoolColumn
        With grdColStyle3
            .HeaderText = "Valorizado_"
            .MappingName = "VALORIZADO"
            .Width = 70
        End With

        Dim grdColStyle4 As New DataGridBoolColumn
        With grdColStyle4
            .HeaderText = "Genera Salida"
            .MappingName = "GENERASALIDA"
            .Width = 70
        End With

        Dim grdColStyle5 As New DataGridTextBoxColumn
        With grdColStyle5
            .HeaderText = "Tipo Salida Art."
            .MappingName = "TIPOVENTA"
            .Width = 70
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2, grdColStyle3, grdColStyle4, grdColStyle5})
        grdLinea.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        BTNCANCELAR_Click(sender, e)
        Grplistado.Visible = True
        Grplistado.BringToFront()
        txtdato.Focus()
        tblImp = CAyuda.ListarDatos("NSP_SELECT_LISTATIPOGUIA", codempresa.ToString()).Tables(0)
        grdLinea.DataSource = tblImp
        txtdato.ReadOnly = False
        Call BOTONES(True, False, True, True, True)
    End Sub

    Private Sub BTNNUEVO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        desbloqueatextos(Me)
        Call BOTONES(False, True, False, False, False)
        txtcodigo.Enabled = True
        txtdescripcion.Enabled = True
        txtcodigo.Focus()
        chksal.Checked = False
        chkval.Checked = False
        rdbprecio.Checked = True
        LimpiarFormularios(Me)
        agregar = True
    End Sub


    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        BTNNUEVO.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        BTNMODIFICAR.Enabled = MODIFICAR
        BTNELIMINAR.Enabled = ELIMINAR
        btnbuscar.Enabled = BUSCAR
    End Sub


    Private Sub BTNCANCELAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Call BOTONES(True, False, False, False, True)
        LimpiarFormularios(Me)
        txtcodigo.Enabled = False
        txtdescripcion.Enabled = False
    End Sub
    Sub valida_datos()
        If txtcodigo.Text = "" Then
            ValidaDatos = True
        End If
        If txtdescripcion.Text = "" Then
            ValidaDatos = True
        End If
    End Sub

    Private Sub BTNGUARDAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click

        valida_datos()
        If ValidaDatos Then
            MessageBox.Show("Falta Ingresar Algunos Valores", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        valor = CAyuda.ListarDatos("NSP_SELECT_VERIFICACODGUIA", codempresa.ToString(), txtcodigo.Text).Tables(0).Rows.Count
        If agregar Then

            If valor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Resp = CAyuda.Ejecutar("nsp_ins_TIPO_GUIA", txtcodigo.Text, txtdescripcion.Text, IIf(chkval.Checked = True, 1, 0), IIf(chksal.Checked = True, 1, 0), codempresa.ToString(), IIf(rdbprecio.Checked = True, 1, 0))
                If Resp = 1 Then
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodigo.Text & "','INSERT','TIPOGUIA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MessageBox.Show("Error Durante Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            Resp = CAyuda.Ejecutar("NSP_upd_TIPO_GUIA", txtcodigo.Text, txtdescripcion.Text, IIf(chkval.Checked = True, 1, 0), IIf(chksal.Checked = True, 1, 0), codempresa.ToString(), IIf(rdbprecio.Checked = True, 1, 0))
            If Resp = 1 Then
                MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodigo.Text & "','UPDATE','TIPOGUIA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MessageBox.Show("Error Durante el Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        Call BOTONES(True, False, False, False, True)

        LimpiarFormularios(Me)
        bloqueatextos(Me)
        BTNNUEVO.Focus()

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
    End Sub

    Private Sub BTNELIMINAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            Resp = CAyuda.Ejecutar("NSP_del_TIPO_GUIA", txtcodigo.Text, codempresa)
            If Resp = 1 Then
                MessageBox.Show("Registro Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodigo.Text & "','DELETE','TIPOGUIA','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("El codigo se encuentra en uso, no se puede eliminar.", MsgBoxStyle.Information, "Aviso")
            End If
            LimpiarFormularios(Me)
            bloqueatextos(Me)
            BOTONES(True, False, False, False, True)
        End If

    End Sub
    Private Sub cmborden_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub grdLinea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLinea.DoubleClick
        Try
            Dim tblc As DataTable
            tblc = CAyuda.ListarDatos("NSP_SELECT_VERIFICACODGUIA", codempresa.ToString(), grdLinea.Item(grdLinea.CurrentRowIndex, 0)).Tables(0)
            txtcodigo.Text = tblc.Rows(0)(0)
            txtdescripcion.Text = tblc.Rows(0)(1)
            chkval.Checked = tblc.Rows(0)("VALORIZADO")
            chksal.Checked = tblc.Rows(0)("GENERASALIDA")
            If tblc.Rows(0)("TIPOVENTA") Then
                rdbprecio.Checked = True
            Else
                rdbcosto.Checked = True
            End If
            tblc.Dispose()
            Grplistado.Visible = False
        Catch
            txtdato.Focus()
            Exit Sub
        End Try
    End Sub

    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged


        If Me.rbcodigo.Checked = True Then
            tblImp = CAyuda.ListarDatos("NSP_SELECT_LISTATIPOGUIA_FILTRADO", codempresa.ToString(), txtdato.Text, 0).Tables(0)
            grdLinea.DataSource = tblImp
        Else
            tblImp = CAyuda.ListarDatos("NSP_SELECT_LISTATIPOGUIA_FILTRADO", codempresa.ToString(), txtdato.Text, 1).Tables(0)
            grdLinea.DataSource = tblImp
        End If

    End Sub


    Private Sub rbcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcodigo.CheckedChanged

    End Sub

    Private Sub txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            txtdescripcion.Focus()
        End If


    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub txtdescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress

        Dim Keyascii As Short = CShort(Asc(e.KeyChar))
        If Keyascii = 13 Then
            BTNGUARDAR.Focus()
        End If

    End Sub
End Class
