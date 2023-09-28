Imports System.Data
Imports vb = Microsoft.VisualBasic
Public Class FrmTipoMovi
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreporte As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNCERRAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents Grplistado As System.Windows.Forms.GroupBox
    Friend WithEvents grdLinea As System.Windows.Forms.DataGrid
    Friend WithEvents txtdato As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtAbrev As System.Windows.Forms.TextBox
    Friend WithEvents Ctrlcorr As System.Windows.Forms.TextBox
    Friend WithEvents cmbMov As System.Windows.Forms.ComboBox
    Friend WithEvents chkValor As System.Windows.Forms.CheckBox
    Friend WithEvents chkProvee As System.Windows.Forms.CheckBox
    Friend WithEvents Chkmusu As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPcred As System.Windows.Forms.CheckBox
    Friend WithEvents ChecPerCont As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents crRpt As AxCrystal.AxCrystalReport
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbusuario As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDescrip As System.Windows.Forms.RadioButton
    Friend WithEvents CheckAlmDestino As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbDestino As System.Windows.Forms.ComboBox
    Friend WithEvents cmbOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents CheckAlmOrig As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgCuotaLinea As System.Windows.Forms.DataGrid
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents BtnQuitarCuota As System.Windows.Forms.Button
    Friend WithEvents rbcodigo As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoMovi))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtAbrev = New System.Windows.Forms.TextBox
        Me.Ctrlcorr = New System.Windows.Forms.TextBox
        Me.cmbMov = New System.Windows.Forms.ComboBox
        Me.btnbuscar = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnreporte = New System.Windows.Forms.Button
        Me.BTNCANCELAR = New System.Windows.Forms.Button
        Me.BTNCERRAR = New System.Windows.Forms.Button
        Me.BTNMODIFICAR = New System.Windows.Forms.Button
        Me.BTNELIMINAR = New System.Windows.Forms.Button
        Me.BTNNUEVO = New System.Windows.Forms.Button
        Me.BTNGUARDAR = New System.Windows.Forms.Button
        Me.chkValor = New System.Windows.Forms.CheckBox
        Me.chkProvee = New System.Windows.Forms.CheckBox
        Me.Chkmusu = New System.Windows.Forms.CheckBox
        Me.ChkPcred = New System.Windows.Forms.CheckBox
        Me.ChecPerCont = New System.Windows.Forms.CheckBox
        Me.Grplistado = New System.Windows.Forms.GroupBox
        Me.crRpt = New AxCrystal.AxCrystalReport
        Me.grdLinea = New System.Windows.Forms.DataGrid
        Me.txtdato = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbDescrip = New System.Windows.Forms.RadioButton
        Me.rbcodigo = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbDestino = New System.Windows.Forms.ComboBox
        Me.cmbOrigen = New System.Windows.Forms.ComboBox
        Me.CheckAlmOrig = New System.Windows.Forms.CheckBox
        Me.CheckAlmDestino = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbusuario = New System.Windows.Forms.ComboBox
        Me.cboUsuario = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dgCuotaLinea = New System.Windows.Forms.DataGrid
        Me.btnAñadir = New System.Windows.Forms.Button
        Me.BtnQuitarCuota = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Grplistado.SuspendLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Abreviatura :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Movimiento :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Correlativo :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(92, 22)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(72, 21)
        Me.txtCodigo.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(92, 47)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(228, 21)
        Me.txtDescripcion.TabIndex = 4
        '
        'txtAbrev
        '
        Me.txtAbrev.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAbrev.Location = New System.Drawing.Point(92, 72)
        Me.txtAbrev.Name = "txtAbrev"
        Me.txtAbrev.Size = New System.Drawing.Size(72, 21)
        Me.txtAbrev.TabIndex = 7
        '
        'Ctrlcorr
        '
        Me.Ctrlcorr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Ctrlcorr.Location = New System.Drawing.Point(92, 122)
        Me.Ctrlcorr.MaxLength = 8
        Me.Ctrlcorr.Name = "Ctrlcorr"
        Me.Ctrlcorr.Size = New System.Drawing.Size(104, 21)
        Me.Ctrlcorr.TabIndex = 13
        '
        'cmbMov
        '
        Me.cmbMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMov.Items.AddRange(New Object() {"SALIDA", "INGRESO", "TRASLADO", "PRODUCCION"})
        Me.cmbMov.Location = New System.Drawing.Point(92, 97)
        Me.cmbMov.Name = "cmbMov"
        Me.cmbMov.Size = New System.Drawing.Size(128, 21)
        Me.cmbMov.TabIndex = 10
        '
        'btnbuscar
        '
        Me.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscar.ImageIndex = 5
        Me.btnbuscar.ImageList = Me.ImageList1
        Me.btnbuscar.Location = New System.Drawing.Point(172, 21)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(41, 23)
        Me.btnbuscar.TabIndex = 2
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnreporte)
        Me.GroupBox1.Controls.Add(Me.BTNCANCELAR)
        Me.GroupBox1.Controls.Add(Me.BTNCERRAR)
        Me.GroupBox1.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox1.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox1.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox1.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox1.Location = New System.Drawing.Point(488, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 213)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento "
        '
        'btnreporte
        '
        Me.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnreporte.ImageIndex = 11
        Me.btnreporte.ImageList = Me.ImageList1
        Me.btnreporte.Location = New System.Drawing.Point(13, 150)
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(78, 23)
        Me.btnreporte.TabIndex = 5
        Me.btnreporte.Text = "&Reporte"
        Me.btnreporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCANCELAR.ImageIndex = 6
        Me.BTNCANCELAR.ImageList = Me.ImageList1
        Me.BTNCANCELAR.Location = New System.Drawing.Point(13, 123)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNCANCELAR.TabIndex = 4
        Me.BTNCANCELAR.Text = "&Cancelar"
        Me.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNCERRAR
        '
        Me.BTNCERRAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNCERRAR.ImageIndex = 4
        Me.BTNCERRAR.ImageList = Me.ImageList1
        Me.BTNCERRAR.Location = New System.Drawing.Point(13, 177)
        Me.BTNCERRAR.Name = "BTNCERRAR"
        Me.BTNCERRAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNCERRAR.TabIndex = 6
        Me.BTNCERRAR.Text = "&Cerrar"
        Me.BTNCERRAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.ImageIndex = 2
        Me.BTNMODIFICAR.ImageList = Me.ImageList1
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(13, 69)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNMODIFICAR.TabIndex = 2
        Me.BTNMODIFICAR.Text = "&Modificar"
        Me.BTNMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.ImageIndex = 3
        Me.BTNELIMINAR.ImageList = Me.ImageList1
        Me.BTNELIMINAR.Location = New System.Drawing.Point(13, 96)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.Text = "&Eliminar"
        Me.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.ImageIndex = 0
        Me.BTNNUEVO.ImageList = Me.ImageList1
        Me.BTNNUEVO.Location = New System.Drawing.Point(13, 15)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(78, 23)
        Me.BTNNUEVO.TabIndex = 0
        Me.BTNNUEVO.Text = "&Nuevo"
        Me.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.ImageIndex = 1
        Me.BTNGUARDAR.ImageList = Me.ImageList1
        Me.BTNGUARDAR.Location = New System.Drawing.Point(13, 42)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(78, 23)
        Me.BTNGUARDAR.TabIndex = 1
        Me.BTNGUARDAR.Text = "&Guardar"
        Me.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkValor
        '
        Me.chkValor.Location = New System.Drawing.Point(328, 13)
        Me.chkValor.Name = "chkValor"
        Me.chkValor.Size = New System.Drawing.Size(104, 24)
        Me.chkValor.TabIndex = 5
        Me.chkValor.Text = "Es Valorizado"
        '
        'chkProvee
        '
        Me.chkProvee.Location = New System.Drawing.Point(328, 37)
        Me.chkProvee.Name = "chkProvee"
        Me.chkProvee.Size = New System.Drawing.Size(136, 24)
        Me.chkProvee.TabIndex = 8
        Me.chkProvee.Text = "Requiere Proveedor"
        '
        'Chkmusu
        '
        Me.Chkmusu.Location = New System.Drawing.Point(328, 61)
        Me.Chkmusu.Name = "Chkmusu"
        Me.Chkmusu.Size = New System.Drawing.Size(112, 24)
        Me.Chkmusu.TabIndex = 11
        Me.Chkmusu.Text = "MultiUsuario"
        '
        'ChkPcred
        '
        Me.ChkPcred.Location = New System.Drawing.Point(328, 85)
        Me.ChkPcred.Name = "ChkPcred"
        Me.ChkPcred.Size = New System.Drawing.Size(112, 24)
        Me.ChkPcred.TabIndex = 14
        Me.ChkPcred.Text = "Pago a Credito"
        '
        'ChecPerCont
        '
        Me.ChecPerCont.Location = New System.Drawing.Point(328, 109)
        Me.ChecPerCont.Name = "ChecPerCont"
        Me.ChecPerCont.Size = New System.Drawing.Size(152, 24)
        Me.ChecPerCont.TabIndex = 17
        Me.ChecPerCont.Text = "Activar Periodo Contable"
        '
        'Grplistado
        '
        Me.Grplistado.Controls.Add(Me.crRpt)
        Me.Grplistado.Controls.Add(Me.grdLinea)
        Me.Grplistado.Controls.Add(Me.txtdato)
        Me.Grplistado.Controls.Add(Me.Label7)
        Me.Grplistado.Controls.Add(Me.GroupBox3)
        Me.Grplistado.Location = New System.Drawing.Point(604, 12)
        Me.Grplistado.Name = "Grplistado"
        Me.Grplistado.Size = New System.Drawing.Size(575, 244)
        Me.Grplistado.TabIndex = 0
        Me.Grplistado.TabStop = False
        '
        'crRpt
        '
        Me.crRpt.Enabled = True
        Me.crRpt.Location = New System.Drawing.Point(208, 160)
        Me.crRpt.Name = "crRpt"
        Me.crRpt.OcxState = CType(resources.GetObject("crRpt.OcxState"), System.Windows.Forms.AxHost.State)
        Me.crRpt.Size = New System.Drawing.Size(28, 28)
        Me.crRpt.TabIndex = 4
        '
        'grdLinea
        '
        Me.grdLinea.BackgroundColor = System.Drawing.Color.Gray
        Me.grdLinea.CaptionText = "Enter = Modificar   -  Escape = Salir"
        Me.grdLinea.DataMember = ""
        Me.grdLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLinea.Location = New System.Drawing.Point(12, 48)
        Me.grdLinea.Name = "grdLinea"
        Me.grdLinea.ReadOnly = True
        Me.grdLinea.Size = New System.Drawing.Size(556, 304)
        Me.grdLinea.TabIndex = 3
        '
        'txtdato
        '
        Me.txtdato.Location = New System.Drawing.Point(64, 16)
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(240, 21)
        Me.txtdato.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Dato : "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbDescrip)
        Me.GroupBox3.Controls.Add(Me.rbcodigo)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 32)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'rbDescrip
        '
        Me.rbDescrip.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDescrip.Location = New System.Drawing.Point(80, 8)
        Me.rbDescrip.Name = "rbDescrip"
        Me.rbDescrip.Size = New System.Drawing.Size(80, 16)
        Me.rbDescrip.TabIndex = 5
        Me.rbDescrip.Text = "Descripcion"
        '
        'rbcodigo
        '
        Me.rbcodigo.Checked = True
        Me.rbcodigo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcodigo.Location = New System.Drawing.Point(8, 8)
        Me.rbcodigo.Name = "rbcodigo"
        Me.rbcodigo.Size = New System.Drawing.Size(68, 19)
        Me.rbcodigo.TabIndex = 4
        Me.rbcodigo.TabStop = True
        Me.rbcodigo.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbDestino)
        Me.GroupBox2.Controls.Add(Me.cmbOrigen)
        Me.GroupBox2.Controls.Add(Me.CheckAlmOrig)
        Me.GroupBox2.Controls.Add(Me.CheckAlmDestino)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.Chkmusu)
        Me.GroupBox2.Controls.Add(Me.chkProvee)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtAbrev)
        Me.GroupBox2.Controls.Add(Me.ChkPcred)
        Me.GroupBox2.Controls.Add(Me.Ctrlcorr)
        Me.GroupBox2.Controls.Add(Me.ChecPerCont)
        Me.GroupBox2.Controls.Add(Me.cmbMov)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.chkValor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnbuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 226)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Almacen Destino :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Almacen Origen :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDestino
        '
        Me.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDestino.Location = New System.Drawing.Point(94, 180)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(228, 21)
        Me.cmbDestino.TabIndex = 23
        '
        'cmbOrigen
        '
        Me.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrigen.Location = New System.Drawing.Point(92, 149)
        Me.cmbOrigen.Name = "cmbOrigen"
        Me.cmbOrigen.Size = New System.Drawing.Size(228, 21)
        Me.cmbOrigen.TabIndex = 21
        '
        'CheckAlmOrig
        '
        Me.CheckAlmOrig.Location = New System.Drawing.Point(328, 138)
        Me.CheckAlmOrig.Name = "CheckAlmOrig"
        Me.CheckAlmOrig.Size = New System.Drawing.Size(152, 24)
        Me.CheckAlmOrig.TabIndex = 19
        Me.CheckAlmOrig.Text = "Activar Almacen Origen"
        '
        'CheckAlmDestino
        '
        Me.CheckAlmDestino.Location = New System.Drawing.Point(328, 160)
        Me.CheckAlmDestino.Name = "CheckAlmDestino"
        Me.CheckAlmDestino.Size = New System.Drawing.Size(152, 24)
        Me.CheckAlmDestino.TabIndex = 18
        Me.CheckAlmDestino.Text = "Activar Almacen Destino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(601, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Nivel :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'cmbusuario
        '
        Me.cmbusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbusuario.Location = New System.Drawing.Point(651, 395)
        Me.cmbusuario.Name = "cmbusuario"
        Me.cmbusuario.Size = New System.Drawing.Size(228, 21)
        Me.cmbusuario.TabIndex = 16
        Me.cmbusuario.Visible = False
        '
        'cboUsuario
        '
        Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuario.ItemHeight = 13
        Me.cboUsuario.Location = New System.Drawing.Point(85, 243)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(282, 21)
        Me.cboUsuario.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(27, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Usuario :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgCuotaLinea
        '
        Me.dgCuotaLinea.BackColor = System.Drawing.Color.Gainsboro
        Me.dgCuotaLinea.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgCuotaLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCuotaLinea.DataMember = ""
        Me.dgCuotaLinea.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCuotaLinea.Location = New System.Drawing.Point(8, 270)
        Me.dgCuotaLinea.Name = "dgCuotaLinea"
        Me.dgCuotaLinea.ReadOnly = True
        Me.dgCuotaLinea.Size = New System.Drawing.Size(486, 140)
        Me.dgCuotaLinea.TabIndex = 24
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(507, 270)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(70, 26)
        Me.btnAñadir.TabIndex = 25
        Me.btnAñadir.Text = "Añadir"
        '
        'BtnQuitarCuota
        '
        Me.BtnQuitarCuota.Location = New System.Drawing.Point(507, 308)
        Me.BtnQuitarCuota.Name = "BtnQuitarCuota"
        Me.BtnQuitarCuota.Size = New System.Drawing.Size(70, 26)
        Me.BtnQuitarCuota.TabIndex = 26
        Me.BtnQuitarCuota.Text = "Quitar"
        '
        'FrmTipoMovi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(994, 760)
        Me.Controls.Add(Me.Grplistado)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.BtnQuitarCuota)
        Me.Controls.Add(Me.dgCuotaLinea)
        Me.Controls.Add(Me.cboUsuario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbusuario)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(1000, 1000)
        Me.Name = "FrmTipoMovi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Tipos de Movimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.Grplistado.ResumeLayout(False)
        Me.Grplistado.PerformLayout()
        CType(Me.crRpt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgCuotaLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public objbus As New ClsAyuda
    Dim valor As Integer
    Dim Resp As Integer
    Dim agregar As Boolean
    Dim tblImp As New DataTable
    Dim ValidaDatos As Boolean

    Dim TablaCuotasLinea As DataTable


    Private Sub FrmTipoMovi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LimpiarFormularios(Me)
        bloqueatextos(Me)
        ValidaDatos = False
        Call BOTONES(True, False, False, False, True)
        Grplistado.Visible = False
        valor = 0
        agregar = True
        tblImp = objbus.ListarDatos("NSP_Select_ListaTipoMovi", codempresa.ToString()).Tables(0)
        grdLinea.DataSource = tblImp
        FormatGrid()
        CAyuda.CargarDataCombo(Me.cmbusuario, "SP_LIST_USU '" & codempresa & "'", "CDUSUARIO", "USUARIO")
        BTNNUEVO.Focus()
        cmbMov.SelectedIndex = 0

        CAyuda.CargarDataCombo(Me.cmbOrigen, "USP_LLENAR_ALMACEN   '" & codempresa & "'", "Codigo", "Descripcion")

        CAyuda.CargarDataCombo(Me.cmbDestino, "USP_LLENAR_ALMACEN   '" & codempresa & "'", "Codigo", "Descripcion")

        CAyuda.CargarDataCombo(Me.cboUsuario, "USP_LLENAR_USUARIO   '" & codempresa & "'", "Codigo", "Descripcion")


    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, _
                                         ByVal keyData As Keys) As Boolean

        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        If ((msg.Msg = WM_KEYDOWN) Or (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)
                Case Keys.Enter
                    If grdLinea.Focus = True Then
                        Dim tblc As DataTable

                        Try
                            tblc = objbus.ListarDatos("NSP_Select_VerificaCodigoTipoMovi", grdLinea.Item(grdLinea.CurrentRowIndex, 0), codempresa.ToString()).Tables(0)
                            txtCodigo.Text = tblc.Rows(0)(0)
                            txtDescripcion.Text = tblc.Rows(0)(1)
                            txtAbrev.Text = tblc.Rows(0)(2)
                            cmbMov.SelectedIndex = IIf(tblc.Rows(0)(3) = 0, 1, 0)
                            Ctrlcorr.Text = tblc.Rows(0)(9)
                            chkValor.Checked = tblc.Rows(0)(5)
                            chkProvee.Checked = tblc.Rows(0)(4)
                            Chkmusu.Checked = tblc.Rows(0)(10)
                            ChkPcred.Checked = tblc.Rows(0)(11)
                            ChecPerCont.Checked = tblc.Rows(0)(12)

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

    Private Sub BTNNUEVO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNUEVO.Click
        desbloqueatextos(Me)

        Call BOTONES(False, True, False, False, False)

        LimpiarFormularios(Me)
        desbloqueatextos(Me)

        chkValor.Checked = False
        chkProvee.Checked = False
        Chkmusu.Checked = False
        ChkPcred.Checked = False
        ChecPerCont.Checked = False

        txtCodigo.Focus()
        agregar = True

        CheckAlmOrig.Checked = False
        CheckAlmDestino.Checked = False

        dgCuotaLinea.DataSource = Nothing

        ', 0, 1), IIf(CheckAlmDestino.Checked = False, 0, 1), cmbOrigen.SelectedValue, cmbDestino.SelectedValue)





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
        Chkmusu.Checked = False
        ChkPcred.Checked = False
        chkProvee.Checked = False
        chkValor.Checked = False
        ChecPerCont.Checked = False
        agregar = True
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnbuscar.Click

        Call BOTONES(True, False, True, True, True)

        Grplistado.Visible = True
        txtdato.Focus()
        tblImp = objbus.ListarDatos("NSP_Select_ListaTipoMovi", codempresa.ToString()).Tables(0)
        grdLinea.DataSource = tblImp

        txtdato.ReadOnly = False


   


    End Sub

    Private Sub Linea_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Grplistado.Visible = False
        End If
    End Sub

    Private Sub Grplistado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grplistado.KeyDown
        If e.KeyCode = Keys.Escape Then
            Grplistado.Visible = False
        End If
    End Sub


    Private Sub txtdato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdato.KeyDown
        If e.KeyCode = Keys.Escape Then
            Grplistado.Visible = False
        End If
    End Sub
    Sub valida_datos()
        ValidaDatos = False
        If GVDATO(txtCodigo.Text) = "" Then
            ValidaDatos = True
        End If
        If GVDATO(txtDescripcion.Text) = "" Then
            ValidaDatos = True
        End If
        If Me.cmbusuario.SelectedValue Is Nothing Then
            ValidaDatos = True
        End If

    End Sub
    Dim cond As Integer
    Private Sub BTNGUARDAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        valida_datos()
        If ValidaDatos Then
            MsgBox("FALTA INGRESAR ALGUNOS VALORES", MsgBoxStyle.Information, "AVISO")
            ValidaDatos = False
            Exit Sub
        End If

        valor = objbus.ListarDatos("NSP_Select_VerificaCodigoTipoMovi", txtCodigo.Text, codempresa.ToString()).Tables(0).Rows.Count

        If Me.cmbMov.Text = "SALIDA" Then
            cond = 0
        End If

        If Me.cmbMov.Text = "INGRESO" Then
            cond = 1
        End If

        If Me.cmbMov.Text = "TRASLADO" Then
            cond = 2
        End If

        If Me.cmbMov.Text = "PRODUCCION" Then
            cond = 3
        End If



     
        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPOMOVIMIENTOXUSUARIO", codempresa, txtCodigo.Text.Trim.Trim).Tables(0)

        If TablaCuotasLinea.Rows.Count > 0 Then
        Else
            MsgBox("FALTA INGRESAR USUARIOS PARA ESTE TIPO DE MOVIMIENTO", MsgBoxStyle.Information, "AVISO")
            Exit Sub
        End If


        If agregar = True Then

            If valor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Resp = objbus.Ejecutar("NSP_Ins_TIPOMOV", GVDATO(txtCodigo.Text), GVDATO(txtDescripcion.Text), GVDATO(txtAbrev.Text), cond, IIf(chkProvee.Checked = False, 0, 1), IIf(chkValor.Checked = False, 0, 1), CDbl(GValidarVacios(Ctrlcorr.Text)), IIf(Chkmusu.Checked = False, 0, 1), IIf(ChkPcred.Checked = False, 0, 1), IIf(ChecPerCont.Checked = False, 0, 1), codempresa.ToString(), IIf(CheckAlmOrig.Checked = False, 0, 1), IIf(CheckAlmDestino.Checked = False, 0, 1), cmbOrigen.SelectedValue, cmbDestino.SelectedValue)
                If Resp = 1 Then
                    CAyuda.Ejecutar("SP_REG_TMOVI_USUARIO", codempresa, txtCodigo.Text.Trim, Me.cmbusuario.SelectedValue.ToString)
                    MessageBox.Show("Registro Grabado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtCodigo.Text & "','INSERT','TIPOMOVI','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
                Else
                    MsgBox("Error Durante Esta Operacion", MsgBoxStyle.Critical, "Aviso")
                End If
            End If
        Else
            Resp = objbus.Ejecutar("NSP_Upd_TIPOMOV", GVDATO(txtCodigo.Text), GVDATO(txtDescripcion.Text), GVDATO(txtAbrev.Text), CInt(cond), IIf(chkProvee.Checked = False, 0, 1), IIf(chkValor.Checked = False, 0, 1), CDbl(Ctrlcorr.Text), IIf(Chkmusu.Checked = False, 0, 1), IIf(ChkPcred.Checked = False, 0, 1), IIf(ChecPerCont.Checked = False, 0, 1), codempresa, IIf(CheckAlmOrig.Checked = False, 0, 1), IIf(CheckAlmDestino.Checked = False, 0, 1), cmbOrigen.SelectedValue, cmbDestino.SelectedValue)
            If Resp = 1 Then
                CAyuda.Ejecutar("SP_REG_TMOVI_USUARIO", codempresa, txtCodigo.Text.Trim, Me.cmbusuario.SelectedValue.ToString)
                MessageBox.Show("Registro Actualizado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtCodigo.Text & "','UPDATE','TIPOMOVI','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
            Else
                MsgBox("Error Durante Esta Operacion", MsgBoxStyle.Critical, "Aviso")
            End If
        End If

        Call BOTONES(True, False, False, False, True)

        LimpiarFormularios(Me)
        bloqueatextos(Me)
        bloqueatextos(Me)
        Chkmusu.Checked = False
        ChkPcred.Checked = False
        chkProvee.Checked = False
        chkValor.Checked = False
        ChecPerCont.Checked = False
        agregar = True
        ValidaDatos = False
        dgCuotaLinea.DataSource = Nothing

    End Sub



    Private Sub BTNCERRAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNCERRAR.Click
        Me.Close()
    End Sub

    Private Sub BTNMODIFICAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNMODIFICAR.Click
        desbloqueatextos(Me)
        Me.txtCodigo.ReadOnly = True
        agregar = False

        Call BOTONES(False, True, False, False, True)

    End Sub
    Private Sub txtdato_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdato.TextChanged

        cargar()
    End Sub
    Sub cargar()
        If Me.txtdato.Text.Trim = "" Then
            tblImp = objbus.ListarDatos("NSP_Select_ListaTipoMovi", codempresa.ToString()).Tables(0)
            grdLinea.DataSource = tblImp
        Else
            If Me.rbcodigo.Checked = True Then
                tblImp.Clear()
                tblImp = objbus.ListarDatos("NSP_Select_ListaTipoMovi_FILTRADO", codempresa.ToString(), txtdato.Text, 2).Tables(0)
                grdLinea.DataSource = tblImp
            End If

            If Me.rbDescrip.Checked = True Then
                tblImp.Clear()
                tblImp = objbus.ListarDatos("NSP_Select_ListaTipoMovi_FILTRADO", codempresa.ToString(), txtdato.Text, 1).Tables(0)
                grdLinea.DataSource = tblImp
            End If
        End If


    End Sub


    Private Sub BTNELIMINAR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTNELIMINAR.Click
        If txtCodigo.Text.Trim.Length = 0 Then
            MessageBox.Show("Debe seleccionar un item.", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Resp = objbus.Ejecutar("NSP_del_TIPOMOV", txtCodigo.Text)
        If Resp = 1 Then
            MessageBox.Show("Registro Eliminado", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
            TmpInsertDatos("SP_REGISTRA_AUDITORIA '" & txtCodigo.Text & "','DELETE','TIPOMOVI','" & Format(System.DateTime.Now, "MM/dd/yyyy hh:mm:ss tt") & "','" & CodUsuario & "','" & codempresa & "'")
        Else
            MsgBox("Error Durane Esta Operacion", MsgBoxStyle.Critical, "Aviso")
        End If
        LimpiarFormularios(Me)
        bloqueatextos(Me)

        BOTONES(True, False, False, False, True)

        bloqueatextos(Me)
        Chkmusu.Checked = False
        ChkPcred.Checked = False
        chkProvee.Checked = False
        chkValor.Checked = False
        ChecPerCont.Checked = False
        agregar = True
        dgCuotaLinea.DataSource = Nothing



    End Sub


    Private Sub cmborden_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        txtdato.Focus()
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            valor = objbus.ListarDatos("NSP_Select_VerificaCodigoTipoMovi", txtCodigo.Text, codempresa.ToString()).Tables(0).Rows.Count
            If valor <> 0 Then
                MessageBox.Show("El Codigo Ya Existe", DesEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            txtDescripcion.Focus()
        End If

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            txtAbrev.Focus()
        End If
    End Sub

    Private Sub txtAbrev_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAbrev.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            cmbMov.Focus()
        End If
    End Sub

    Private Sub cmbMov_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMov.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        If KeyAscii = 13 Then
            Ctrlcorr.Focus()
        End If
    End Sub

    Private Sub Ctrlcorr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ctrlcorr.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(objbus.SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
            MessageBox.Show("Solo Numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Ctrlcorr.Focus()
        End If
        If KeyAscii = 13 Then
            cmbusuario.Focus()
        End If
    End Sub

    Sub FormatGrid()
        Dim grdTableStyle1 As New DataGridTableStyle
        With grdTableStyle1
            .MappingName = tblImp.TableName
            .PreferredColumnWidth = 125
            .PreferredRowHeight = 15
        End With
        Dim grdColStyle1 As New DataGridTextBoxColumn
        With grdColStyle1
            .HeaderText = "Codigo"
            .MappingName = "Código"
            .Width = 80
        End With

        Dim grdColStyle2 As New DataGridTextBoxColumn
        With grdColStyle2
            .HeaderText = "Descripcion"
            .MappingName = "Descripción"
            .Width = 280
        End With

        grdTableStyle1.GridColumnStyles.AddRange _
            (New DataGridColumnStyle() _
            {grdColStyle1, grdColStyle2})
        grdLinea.TableStyles.Add(grdTableStyle1)
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnbuscar_Click(sender, e)
        End If
    End Sub

    Private Sub grdLinea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdLinea.DoubleClick

        Dim tblc As DataTable
        Try
            tblc = objbus.ListarDatos("NSP_Select_VerificaCodigoTipoMovi", grdLinea.Item(grdLinea.CurrentRowIndex, 0), codempresa.ToString()).Tables(0)
            txtCodigo.Text = tblc.Rows(0)(0)
            txtDescripcion.Text = tblc.Rows(0)(1)
            txtAbrev.Text = tblc.Rows(0)(2)
            'cmbMov.SelectedIndex = IIf(tblc.Rows(0)(3) = 0, 1, 0)
            If tblc.Rows(0)(3) = 0 Then
                cmbMov.SelectedIndex = 0
            End If

            If tblc.Rows(0)(3) = 1 Then
                cmbMov.SelectedIndex = 1
            End If

            If tblc.Rows(0)(3) = 2 Then
                cmbMov.SelectedIndex = 2
            End If

            If tblc.Rows(0)(3) = 3 Then
                cmbMov.SelectedIndex = 3
            End If



            Ctrlcorr.Text = tblc.Rows(0)(9)
            chkValor.Checked = tblc.Rows(0)(5)
            chkProvee.Checked = tblc.Rows(0)(4)
            Chkmusu.Checked = tblc.Rows(0)(10)
            ChkPcred.Checked = tblc.Rows(0)(11)
            ChecPerCont.Checked = tblc.Rows(0)(12)

            CheckAlmOrig.Checked = tblc.Rows(0)(16)
            CheckAlmDestino.Checked = tblc.Rows(0)(17)
            cmbOrigen.SelectedValue = tblc.Rows(0)(18)
            cmbDestino.SelectedValue = tblc.Rows(0)(19)


            'tblc = objbus.ListarDatos("SP_SELE_TIMOVO_USU", codempresa, txtCodigo.Text.Trim).Tables(0)
            'If tblc.Rows.Count > 0 Then
            '    Me.cmbusuario.SelectedValue = tblc.Rows(0)(0)
            'Else
            '    Me.cmbusuario.SelectedIndex = -1
            'End If

            'tblc.Dispose()




            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPOMOVIMIENTOXUSUARIO", codempresa, txtCodigo.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()

            Grplistado.Visible = False

        Catch ex As Exception
            txtdato.Focus()
            Exit Sub
        End Try

    End Sub
    Private Sub btnreporte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        crRpt.ReportFileName = rutareporte & "Rpt_TipoMovi.RPT"
        crRpt.Connect = "DSN=reportes;UID=" & usuariodb & ";PWD=" & Trim(passworddb) & ";"
        crRpt.set_StoredProcParam(0, codempresa)
        crRpt.set_StoredProcParam(1, CodUsuario)
        crRpt.Destination = Crystal.DestinationConstants.crptToWindow
        crRpt.WindowState = Crystal.WindowStateConstants.crptMaximized
        crRpt.Action = 1
        crRpt.Reset()
    End Sub

    Private Sub grdLinea_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles grdLinea.Navigate

    End Sub

    Private Sub rbcodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcodigo.CheckedChanged

    End Sub




    Private Sub Ctrlcorr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ctrlcorr.TextChanged

    End Sub

    Private Sub cmbusuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario.SelectedIndexChanged

    End Sub

    Private Sub cmbusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbusuario.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(objbus.SoloNumeros(KeyAscii))

        If KeyAscii = 13 Then
            BTNGUARDAR.Focus()
        End If
    End Sub

    Private Sub btnAñadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadir.Click



        CAyuda.Ejecutar("NSP_INSERT_TIPOMOVIMIENTOXUSUARIO", codempresa, txtCodigo.Text.Trim, cboUsuario.SelectedValue, cboUsuario.Text)
        TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPOMOVIMIENTOXUSUARIO", codempresa, txtCodigo.Text.Trim.Trim).Tables(0)
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
        If txtCodigo.Text.Trim = "" Then
            MsgBox("Falta el Codigo del Tipo Movimiento..", MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If
        If TablaCuotasLinea.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim Rpta As String
        Rpta = MsgBox("¿ Desea Eliminar el usuarioxTipoMovimiento " & Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 2).ToString.Trim & " ] ?", MsgBoxStyle.YesNo).ToString
        If Rpta.Equals("Yes") Then
            CAyuda.Ejecutar("NSP_DELETE_TIPOMOVIMIENTOXUSUARIO", codempresa, txtCodigo.Text.Trim, Me.dgCuotaLinea(Me.dgCuotaLinea.CurrentRowIndex, 1).ToString.Trim)
       
            TablaCuotasLinea = CAyuda.ListarDatos("NSP_LISTAR_TIPOMOVIMIENTOXUSUARIO", codempresa, txtCodigo.Text.Trim.Trim).Tables(0)
            Me.dgCuotaLinea.DataSource = TablaCuotasLinea
            FORMATO_GRID()




        End If
    End Sub

    Private Sub cmbMov_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMov.SelectedIndexChanged

    End Sub
End Class
