Public Class FrmTipoDoc
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtdes As System.Windows.Forms.TextBox
    Friend WithEvents txtabrev As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkContable As System.Windows.Forms.CheckBox
    Friend WithEvents ChkComprbtePag As System.Windows.Forms.CheckBox
    Friend WithEvents ChkComprbteCobro As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPercepcion As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarCuota As System.Windows.Forms.Button
    Friend WithEvents dgCuotaLinea As System.Windows.Forms.DataGrid
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents ChkPercepcionT As System.Windows.Forms.CheckBox
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoDoc))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdes = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtabrev = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ChkPercepcion = New System.Windows.Forms.CheckBox
        Me.ChkComprbteCobro = New System.Windows.Forms.CheckBox
        Me.ChkComprbtePag = New System.Windows.Forms.CheckBox
        Me.ChkContable = New System.Windows.Forms.CheckBox
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnQuitarCuota = New System.Windows.Forms.Button
        Me.dgCuotaLinea = New System.Windows.Forms.DataGrid
        Me.cboUsuario = New System.Windows.Forms.ComboBox
        Me.ChkPercepcionT = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo :"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcodigo.Location = New System.Drawing.Point(96, 17)
        Me.txtcodigo.MaxLength = 6
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(104, 21)
        Me.txtcodigo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Descripcion :"
        '
        'txtdes
        '
        Me.txtdes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdes.Location = New System.Drawing.Point(96, 41)
        Me.txtdes.MaxLength = 30
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(248, 21)
        Me.txtdes.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Abreviatura :"
        '
        'txtabrev
        '
        Me.txtabrev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtabrev.Location = New System.Drawing.Point(96, 65)
        Me.txtabrev.MaxLength = 5
        Me.txtabrev.Name = "txtabrev"
        Me.txtabrev.Size = New System.Drawing.Size(104, 21)
        Me.txtabrev.TabIndex = 4
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(217, 65)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(184, 19)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Documentos Contables"
        '
        'btnBuscar
        '
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.ImageIndex = 5
        Me.btnBuscar.ImageList = Me.ImageList1
        Me.btnBuscar.Location = New System.Drawing.Point(200, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(48, 24)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "..."
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.btnmodificar)
        Me.GroupBox1.Controls.Add(Me.btneliminar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(429, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 216)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(14, 155)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(82, 23)
        Me.btnreporte.TabIndex = 11
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(14, 128)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCANCELAR.TabIndex = 10
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(14, 182)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNCERRAR.TabIndex = 12
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnmodificar
        '
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodificar.ImageIndex = 2
        Me.btnmodificar.ImageList = Me.ImageList1
        Me.btnmodificar.Location = New System.Drawing.Point(14, 74)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(82, 23)
        Me.btnmodificar.TabIndex = 8
        Me.btnmodificar.Text = "&Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btneliminar
        '
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneliminar.ImageIndex = 3
        Me.btneliminar.ImageList = Me.ImageList1
        Me.btneliminar.Location = New System.Drawing.Point(14, 101)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(82, 23)
        Me.btneliminar.TabIndex = 9
        Me.btneliminar.Text = "&Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnnuevo
        '
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnuevo.ImageIndex = 0
        Me.btnnuevo.ImageList = Me.ImageList1
        Me.btnnuevo.Location = New System.Drawing.Point(14, 20)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(82, 23)
        Me.btnnuevo.TabIndex = 6
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(14, 47)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(82, 23)
        Me.BTNGUARDAR.TabIndex = 7
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkPercepcionT)
        Me.GroupBox2.Controls.Add(Me.ChkPercepcion)
        Me.GroupBox2.Controls.Add(Me.ChkComprbteCobro)
        Me.GroupBox2.Controls.Add(Me.ChkComprbtePag)
        Me.GroupBox2.Controls.Add(Me.ChkContable)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.txtabrev)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtdes)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(360, 219)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'ChkPercepcion
        '
        Me.ChkPercepcion.Location = New System.Drawing.Point(217, 164)
        Me.ChkPercepcion.Name = "ChkPercepcion"
        Me.ChkPercepcion.Size = New System.Drawing.Size(152, 28)
        Me.ChkPercepcion.TabIndex = 12
        Me.ChkPercepcion.Text = "Percepcion Distribucion"
        '
        'ChkComprbteCobro
        '
        Me.ChkComprbteCobro.Location = New System.Drawing.Point(217, 87)
        Me.ChkComprbteCobro.Name = "ChkComprbteCobro"
        Me.ChkComprbteCobro.Size = New System.Drawing.Size(150, 28)
        Me.ChkComprbteCobro.TabIndex = 11
        Me.ChkComprbteCobro.Text = "Comprobante de Cobro"
        '
        'ChkComprbtePag
        '
        Me.ChkComprbtePag.Location = New System.Drawing.Point(217, 141)
        Me.ChkComprbtePag.Name = "ChkComprbtePag"
        Me.ChkComprbtePag.Size = New System.Drawing.Size(152, 28)
        Me.ChkComprbtePag.TabIndex = 10
        Me.ChkComprbtePag.Text = "Recibos Pago"
        '
        'ChkContable
        '
        Me.ChkContable.Location = New System.Drawing.Point(217, 119)
        Me.ChkContable.Name = "ChkContable"
        Me.ChkContable.Size = New System.Drawing.Size(150, 16)
        Me.ChkContable.TabIndex = 9
        Me.ChkContable.Text = "Cuenta Contable"
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(338, 2)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(505, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 26)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Añadir"
        '
        'BtnQuitarCuota
        '
        Me.BtnQuitarCuota.Location = New System.Drawing.Point(505, 325)
        Me.BtnQuitarCuota.Name = "BtnQuitarCuota"
        Me.BtnQuitarCuota.Size = New System.Drawing.Size(70, 26)
        Me.BtnQuitarCuota.TabIndex = 36
        Me.BtnQuitarCuota.Text = "Quitar"
        '
        'dgCuotaLinea
        '
        Me.dgCuotaLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCuotaLinea.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgCuotaLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCuotaLinea.DataMember = ""
        Me.dgCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotaLinea.Location = New System.Drawing.Point(11, 273)
        Me.dgCuotaLinea.Name = "dgCuotaLinea"
        Me.dgCuotaLinea.ReadOnly = True
        Me.dgCuotaLinea.Size = New System.Drawing.Size(486, 140)
        Me.dgCuotaLinea.TabIndex = 34
        '
        'cboUsuario
        '
        Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuario.ItemHeight = 13
        Me.cboUsuario.Location = New System.Drawing.Point(88, 246)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(282, 21)
        Me.cboUsuario.TabIndex = 33
        '
        'ChkPercepcionT
        '
        Me.ChkPercepcionT.Location = New System.Drawing.Point(215, 189)
        Me.ChkPercepcionT.Name = "ChkPercepcionT"
        Me.ChkPercepcionT.Size = New System.Drawing.Size(152, 28)
        Me.ChkPercepcionT.TabIndex = 13
        Me.ChkPercepcionT.Text = "Percepcion Tienda"
        '
        'FrmTipoDoc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(596, 444)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnQuitarCuota)
        Me.Controls.Add(Me.dgCuotaLinea)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.crRpt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 6000)
        Me.Name = "FrmTipoDoc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Tipo de Documento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim TablaCuotasLinea As DataTable
    Private Sub FrmTipoDoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bloqueatextbox(Me)
        CheckBox1.Enabled = False
        ChkContable.Enabled = False
        ChkComprbteCobro.Enabled = False
        ChkComprbtePag.Enabled = False
        ChkPercepcion.Enabled = False
        Call BOTONES(True, False, False, False, True)

        CAyuda.CargarDataCombo(Me.cboUsuario, "SP_LIST_USU '" & codempresa & "'", "CDUSUARIO", "USUARIO")




    End Sub

    Public Sub mostrar()
        Try
            txtcodigo.Text = VAR1
            txtdes.Text = VAR2
            txtabrev.Text = VAR3
            If VAR4 = True Then
                CheckBox1.Checked = True
            Else
                CheckBox1.Checked = False
            End If
            If VAR5 = True Then
                ChkContable.Checked = True
            Else
                ChkContable.Checked = False
            End If
            If VAR6 = True Then
                ChkComprbteCobro.Checked = True
            Else
                ChkComprbteCobro.Checked = False
            End If
            If VAR7 = True Then
                ChkComprbtePag.Checked = True
            Else
                ChkComprbtePag.Checked = False
            End If

            If VAR8 = True Then
                ChkPercepcion.Checked = True
            Else
                ChkPercepcion.Checked = False
            End If


            If VAR9 = True Then
                ChkPercepcionT.Checked = True
            Else
                ChkPercepcionT.Checked = False
            End If

        Catch x As Exception
        End Try
    End Sub
    Private Sub BTNCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim frmx As New FrmBucarTipoDoc
        frmx.ShowDialog()
        mostrar()
        Call BOTONES(True, False, True, True, True)


        txtcodigo.ReadOnly = True



        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()
    End Sub
    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim n As Integer
        If CheckBox1.Checked = True Then
            n = 1
        Else
            n = 0
        End If
        Dim sql As String
        Dim PROCESO As Boolean
        Call formatotextbox(Me)
        If txtcodigo.Text = "" Or txtdes.Text = "" Or txtabrev.Text = "" Then
            MessageBox.Show("Complete los Campos Para Realizar el Proceso", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If flag = 0 Then
            sql = "NSP_INSERT_TIPODOC '" & txtcodigo.Text & "'," & n & ",'" & txtabrev.Text & "','" & txtdes.Text & "','" & codempresa & "','" & CodUsuario & "','" & ChkContable.CheckState & "','" & ChkComprbteCobro.CheckState & "','" & ChkComprbtePag.CheckState & "','" & ChkPercepcion.CheckState & "','" & ChkPercepcionT.CheckState & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodigo.Text & "','INSERT','TIPODOC','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("El codigo ya existe.", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End If
        End If

        If flag = 1 Then
            sql = "NSP_UPDATE_TIPODOC '" & txtcodigo.Text & "'," & n & ",'" & txtabrev.Text & "','" & txtdes.Text & "','" & codempresa & "','" & CodUsuario & "','" & ChkContable.CheckState & "','" & ChkComprbteCobro.CheckState & "','" & ChkComprbtePag.CheckState & "','" & ChkPercepcion.CheckState & "','" & ChkPercepcionT.CheckState & "'"
            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodigo.Text & "','UPDATE','TIPODOC','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            End If
        End If

        If PROCESO = False Then
            Exit Sub
        Else
            MsgBox("EL REGISTRO FUE GRABADO CORRECTAMENTE ...", MsgBoxStyle.Information, "NAR SISTEMAS S.A.C.")
        End If

        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        CheckBox1.Enabled = False
        ChkContable.Enabled = False
        ChkComprbteCobro.Enabled = False
        ChkComprbtePag.Enabled = False
        ChkPercepcion.Enabled = False
        ChkPercepcionT.Enabled = False

        Call Limpiatextbox(Me)
        btnnuevo.Focus()


        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()

    End Sub

    Sub BOTONES(ByVal NUEVO As Boolean, ByVal GUARDAR As Boolean, ByVal MODIFICAR As Boolean, ByVal ELIMINAR As Boolean, ByVal BUSCAR As Boolean)
        btnnuevo.Enabled = NUEVO
        BTNGUARDAR.Enabled = GUARDAR
        btnmodificar.Enabled = MODIFICAR
        btneliminar.Enabled = ELIMINAR
        btnBuscar.Enabled = BUSCAR
    End Sub
    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Call desbloqueatextbox(Me)
        CheckBox1.Enabled = True
        ChkContable.Enabled = True
        ChkComprbteCobro.Enabled = True
        ChkComprbtePag.Enabled = True
        ChkPercepcion.Enabled = True

        txtcodigo.ReadOnly = True
        Call BOTONES(False, True, False, False, True)
        flag = 1
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click

        If MsgBox("Desea Eliminar Este Registro que Selecciono", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "NAR SISTEMAS S.A.C") = MsgBoxResult.Yes Then
            Dim PROCESO As Boolean
            Dim sql As String
            sql = "NSP_ELIMINAR_TIPODOC '" & txtcodigo.Text & "','" & CodUsuario & "'"

            PROCESO = TmpInsertDatos(sql)
            If PROCESO = True Then
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtcodigo.Text & "','DELETE','TIPODOC','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("El codigo se encuentra en uso, no se puede eliminar.", MsgBoxStyle.Information, "Aviso")
            End If


            If PROCESO = False Then Exit Sub
            BOTONES(True, False, False, False, True)
            Call Bloqueatextbox(Me)
            CheckBox1.Enabled = False
            ChkContable.Enabled = False
            ChkComprbteCobro.Enabled = False
            ChkComprbtePag.Enabled = False
            ChkPercepcionT.Enabled = False

            Call Limpiatextbox(Me)
            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()
        End If


    End Sub

    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        'Dim n As New VistaReporteTDoc
        'n.Show()
        Try
            Dim dt As New DataTable
            dt = M_Cabecera_R(CodUsuario, codempresa)
            crRpt.ReportFileName = rutareporte & "RptTipDocumento.rpt"
            crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
            crRpt.set_StoredProcParam(0, codempresa)
            crRpt.set_Formulas(0, "Empresa= '" & dt.Rows(0)(0).ToString & "'")
            crRpt.set_Formulas(1, "Usuario='" & dt.Rows(0)(1).ToString & "'")
            crRpt.Destination = Crystal.DestinationConstants.crptToWindow
            crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
            crRpt.Action = 1
            crRpt.Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCANCELAR.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_cancelar()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call BOTONES(True, False, False, False, True)
        Call Bloqueatextbox(Me)
        CheckBox1.Enabled = False
        ChkContable.Enabled = False
        ChkComprbteCobro.Enabled = False
        ChkComprbtePag.Enabled = False
        ChkPercepcionT.Enabled = False

        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()


    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Dim RESPUESTA As Boolean
        RESPUESTA = mensaje_ingreso()
        If RESPUESTA = False Then Exit Sub
        Call Limpiatextbox(Me)
        Call desbloqueatextbox(Me)
        CheckBox1.Enabled = True
        ChkContable.Enabled = True
        ChkComprbteCobro.Enabled = True
        ChkComprbtePag.Enabled = True
        ChkPercepcionT.Enabled = False
        Call BOTONES(False, True, False, False, False)


        flag = 0
        txtcodigo.Focus()

        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()

    End Sub

    Private Sub FrmTipoDoc_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
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
            txtabrev.Focus()
        End If

    End Sub

    Private Sub txtabrev_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtabrev.KeyPress
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

    Private Sub txtabrev_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtabrev.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CAyuda.Ejecutar("NSP_INSERT_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim, cboUsuario.SelectedValue, cboUsuario.Text)
        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim.Trim).Tables(0)
        Me.dgCuotaLinea.DataSource = TablaCuotasLinea
        FORMATO_GRID()
    End Sub



    Public Sub FORMATO_GRID()

        Dim TableStyle1 As New DataGridTableStyle
        With TableStyle1
            .MappingName = TablaCuotasLinea.TableName
            .HeaderFont = New System.Drawing.Font("Arial", 8.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
        End With
        Dim column1 As New DataGridTextBoxColumn
        With column1
            .MappingName = "CDTIPOMOV"
            .HeaderText = "CDTIPOMOV"
            .Width = 100
        End With


        Dim column2 As New DataGridTextBoxColumn
        With column2
            .MappingName = "CODUSUARIO"
            .HeaderText = "CODUSUARIO"
            .Width = 100
        End With

        Dim column3 As New DataGridTextBoxColumn
        With column3
            .MappingName = "DSUSUARIO"
            .HeaderText = "DSUSUARIO"
            .Width = 100
        End With

        dgCuotaLinea.TableStyles.Clear()
        TableStyle1.GridColumnStyles.AddRange(New DataGridTextBoxColumn() {column1, column2, column3})
        dgCuotaLinea.TableStyles.Add(TableStyle1)

    End Sub









    Private Sub BtnQuitarCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitarCuota.Click



        If txtcodigo.Text.Trim = "" Then
            MsgBox("Falta el Codigo del Tipo Movimiento..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TablaCuotasLinea.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el usuarioxTipoMovimiento " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 1).ToString.Trim)

            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPODOCXUSUARIO", codempresa, txtcodigo.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()

        End If

    End Sub
End Class
